/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.GLS030MI;
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
	/// Name: GLS030MI
	/// Component Name: Finance
	/// Description: Api: Accounting translation
	/// Version Release: 
	///</summary>
	public partial class GLS030MIResource : M3BaseResourceEndpoint
	{
		public GLS030MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "GLS030MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetAcntIdCtgry
		/// Description Get accounting id category
		/// Version Release: 
		/// </summary>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_SCEN">Scenario</param>
		/// <param name="m3_AITP">Accounting dimension</param>
		/// <param name="m3_AITM">Accounting identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAcntIdCtgryResponse></returns>
		/// <exception cref="M3Exception<GetAcntIdCtgryResponse>"></exception>
		public async Task<M3Response<GetAcntIdCtgryResponse>> GetAcntIdCtgry(
			string m3_DIVI = null, 
			string m3_SCEN = null, 
			int? m3_AITP = null, 
			string m3_AITM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAcntIdCtgry",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCEN))
				request.WithQueryParameter("SCEN", m3_SCEN.Trim());
			if (m3_AITP.HasValue)
				request.WithQueryParameter("AITP", m3_AITP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AITM))
				request.WithQueryParameter("AITM", m3_AITM.Trim());

			// Execute the request
			var result = await Execute<GetAcntIdCtgryResponse>(
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
