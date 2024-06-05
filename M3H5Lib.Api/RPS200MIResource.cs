/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Extensions;
using M3H5Lib.Models;
using ExtensibleHttp.Payload;
using ExtensibleHttp;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace M3H5Lib.Api
{

	/// <summary>
	/// Name: RPS200MI
	/// Component Name: Macro orders
	/// Description: Work with supplychain order
	/// Version Release: 14.x
	///</summary>
	public partial class RPS200MIResource : M3BaseResourceEndpoint
	{
		public RPS200MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "RPS200MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ReGenSupChain
		/// Description Generate Demand Order Statistics
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SCNB">Supply chain number</param>
		/// <param name="m3_SCFD">Supply chain finish date</param>
		/// <param name="m3_SCFT">Supply chain finish time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ReGenSupChain(
			string m3_SCNB = null, 
			DateTime? m3_SCFD = null, 
			int? m3_SCFT = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ReGenSupChain",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SCNB))
				request.WithQueryParameter("SCNB", m3_SCNB.Trim());
			if (m3_SCFD.HasValue)
				request.WithQueryParameter("SCFD", m3_SCFD.Value.ToM3String());
			if (m3_SCFT.HasValue)
				request.WithQueryParameter("SCFT", m3_SCFT.Value.ToString());

			// Execute the request
			var result = await Execute<M3Record>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}
	}
}
// EOF
