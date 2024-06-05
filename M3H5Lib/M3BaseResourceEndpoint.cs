using ExtensibleHttp;
using ExtensibleHttp.Endpoint;
using ExtensibleHttp.Interfaces;
using M3H5Lib.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace M3H5Lib
{
#pragma warning disable CA1012 // Abstract types should not have public constructors
    public abstract class M3BaseResourceEndpoint
#pragma warning restore CA1012 // Abstract types should not have public constructors
    {
        protected M3Config Config { get; private set; }
        protected IPayloadFactory PayloadFactory { get; set; }
        protected IEndpointHttpHandler Client { get; private set; }
        protected IEndpointClient ApiClient { get; private set; }
        public object ApiException { get; private set; }

        public string ProgramName { get; protected set; }

        public M3BaseResourceEndpoint(IEndpointClient apiClient)
        {
            if (apiClient == null)
                throw new ArgumentNullException(nameof(apiClient));

            ApiClient = apiClient;
            Client = apiClient.GetHttpHandler();
            Config = (M3Config)apiClient.GetEndpointConfig();
        }


        protected async Task<M3Response<TOutput>> Execute<TOutput>(
            M3Request request,
            int? maxRecords = null,
            bool? includeMetadata = null,
            bool? trimResults = null,
            IEnumerable<string> outputColumns = null,
            bool? throwExceptionWithoutSuccess = null,
            CancellationToken cancellationToken = default) where TOutput : M3BaseRecord
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            // Set max records if it's requested
            if (maxRecords.HasValue)
                request.WithMaxRecords(maxRecords.Value);

            // Set output columns if it's requested.  This should have minimal
            // impact except for completeness.
            if (outputColumns != null)
                request.WithOutputColumns(outputColumns);

            // Set flag to include Metadata list, otherwise an empty list
            // will be returned.
            if (includeMetadata.HasValue)
                request.WithMetadata(includeMetadata.Value);

            // Most data is CHAR based with whitespace causing string comparison issues
            // in C# so this normalizes the data.
            request.WithTrimResults(trimResults.GetValueOrDefault(true));

            // Execute the request and get the response object back
            var response = await Client.GetAsync(request, cancellationToken)
                .ConfigureAwait(false);

            // Get the response back
            var result = await ProcessResponse<TOutput>(request, response, cancellationToken)
                .ConfigureAwait(false);


            // Check to see if there are any errors from M3.  If there are, throw an exception
            // if the throwExceptionWithoutSuccess is set.  Otherwise let the caller handle it.
            if (throwExceptionWithoutSuccess.GetValueOrDefault(false)
                && !result.Success)
            {
                throw new M3Exception<TOutput>(result, $"{ProgramName}, Message: {result.Message}");
            }
            return result;
        }

        protected async Task<TOutput> ExecuteSingle<TOutput>(
            M3Request request,
            bool? includeMetadata = null,
            bool? trimResults = null,
            IEnumerable<string> outputColumns = null,
            bool? throwExceptionWithoutSuccess = null,
            CancellationToken cancellationToken = default) where TOutput : M3BaseRecord
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            // Execute the request
            var result = await Execute<TOutput>(
                request: request,
                maxRecords: 1,
                includeMetadata: includeMetadata,
                trimResults: trimResults,
                outputColumns: outputColumns,
                throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
                cancellationToken: cancellationToken)
                .ConfigureAwait(false);

            return result.Rows.FirstOrDefault();
        }



        public async Task<M3Response<TPayload>> ProcessResponse<TPayload>(IRequest request, IResponse response, CancellationToken cancellationToken) where TPayload : M3BaseRecord
        {
            if (response == null)
                throw new ArgumentNullException(nameof(response));

            M3Response<TPayload> m3Response = null;

            if (response.RawResponse.IsSuccessStatusCode)
            {
                string content = await response.GetPayloadAsString(cancellationToken)
                    .ConfigureAwait(false);
                var serializer = PayloadFactory.GetSerializer(Config.ApiFormat);
                m3Response = serializer.Deserialize<M3Response<TPayload>>(content);
            }
            if (m3Response == null)
            {
                m3Response = new M3Response<TPayload>
                {
                    Message = "M3Response was returned null with no exception",
                };
            }

            M3Request m3Request = (M3Request)request;

            // Add the request details here
#pragma warning disable CA1062 // Validate arguments of public methods
            foreach (KeyValuePair<string, IEnumerable<string>> kvp in m3Request.QueryParams)
            {
                m3Response.QueryParameters.Add(kvp.Key, string.Join(",", kvp.Value));
            }
#pragma warning restore CA1062 // Validate arguments of public methods
            m3Response.MaxRecords = m3Request.MaxRecords;

            m3Response.HttpStatus = new M3HttpStatus
            {
                StatusCode = response.RawResponse.StatusCode.ToString(),
                ReasonPhrase = response.RawResponse.ReasonPhrase,
                RequestUri = request.HttpRequest.RequestUri.ToString(),
            };

            // Reset the Metadata sent from M3.  In most cases it's 50% of
            // of result content.
            if (!m3Request.IncludeMetadata)
                m3Response.Metadata = new M3Metadata();

            if (m3Response.Rows == null)
            {
                m3Response.Rows = new M3RecordList<TPayload>();
            }

            // Clean up the M3 data is trim is requested
            if (m3Request.TrimResults)
            {
                foreach (TPayload record in m3Response.Rows)
                {
                    record.CleanResults();
                }
            }

            return m3Response;
        }
    }
}
