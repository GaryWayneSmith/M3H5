using ExtensibleHttp;
using ExtensibleHttp.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace M3H5Lib
{
    public class M3Request : BaseRequest
    {
        int? _maxRecords;
        bool _trimResults;
        bool _includeMetadata;

        public M3Config M3Config => (M3Config)Config;

        public int? MaxRecords => _maxRecords;
        public bool TrimResults => _trimResults;
        public bool IncludeMetadata => _includeMetadata;
        public IEnumerable<string> OutputColumns { get; set; } = new List<string>();

        public M3Request(IRequestConfig config)
            : base(config)
        {
        }



        public M3Request WithTrimResults()
        {
            _trimResults = true;
            return this;
        }

        public M3Request WithTrimResults(bool trimResults)
        {
            _trimResults = trimResults;
            return this;
        }

        public M3Request WithMetadata(bool includeMetadata)
        {
            _includeMetadata = includeMetadata;
            return this;
        }

        public M3Request WithOutputColumns(IEnumerable<string> outputColumns)
        {
            OutputColumns = outputColumns;
            return this;
        }

        public M3Request WithQueryParameter(string key, string value)
        {
            if (QueryParams.ContainsKey(key))
                QueryParams[key] = new List<string> { value };
            else
                QueryParams.Add(key, new List<string> { value });
            return this;
        }

        public M3Request WithMaxRecords(int limit)
        {
            _maxRecords = limit;
            return this;
        }

        public override Task BuildUri(CancellationToken cancellationToken)
        {
            // UPDATE 2012-07-31: You can set the maximum number of records returned with
            // the matrix parameter maxrecs, for example:
            // http://hostname:port/m3api-rest/execute/CRS610MI/LstByNumber;maxrecs=20?CONO=1
            if (_maxRecords.HasValue)
                EndpointUri = $"{EndpointUri};maxrecs={_maxRecords.Value}";

            // UPDATE 2012-08-02:
            // You can set the output fields returned with the parameter returncols, for example:
            // http://hostname:port/m3api-rest/execute/CRS610MI/LstByNumber;returncols=CUNO,CUNM,CUA1,STAT,PHNO
            if (OutputColumns.Any())
                EndpointUri = $"{EndpointUri};returncols={string.Join(",", OutputColumns)}";

            if (EndpointUri.StartsWith("/", StringComparison.OrdinalIgnoreCase))
            {
                EndpointUri = EndpointUri.Substring(1);
            }
            return base.BuildUri(cancellationToken);
        }

        public override async Task AddUserAgentHeader(CancellationToken cancellationToken)
        {
            HttpRequest.Headers.Add(BaseHeaders.USER_AGENT, Config.UserAgent);
            await base.AddUserAgentHeader(cancellationToken)
                .ConfigureAwait(false);
        }

        public override async Task AddHeaders(CancellationToken cancellationToken)
        {
            HttpRequest.Headers.Add(BaseHeaders.AUTHORIZATION, M3Config.Authorization);
            HttpRequest.Headers.Add(M3Headers.CORRELATION_ID, CorrelationId);
            // Must go last.
            HttpRequest.Headers.Add(BaseHeaders.ACCEPT, M3Config.GetContentType(Config.ApiFormat));
            await base.AddHeaders(cancellationToken)
                .ConfigureAwait(false);
        }



    }
}
