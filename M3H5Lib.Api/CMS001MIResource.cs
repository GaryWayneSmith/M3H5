/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CMS001MI;
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
	/// Name: CMS001MI
	/// Component Name: Sputnik
	/// Description: Planning node distribution relation
	/// Version Release: 12.6
	///</summary>
	public partial class CMS001MIResource : M3BaseResourceEndpoint
	{
		public CMS001MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS001MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstRelations
		/// Description List Relations
		/// Version Release: 12.6
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FPND">From planning node</param>
		/// <param name="m3_TPND">To planning node</param>
		/// <param name="m3_LMTS">Last import´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRelationsResponse></returns>
		/// <exception cref="M3Exception<LstRelationsResponse>"></exception>
		public async Task<M3Response<LstRelationsResponse>> LstRelations(
			int? m3_CONO = null, 
			string m3_FPND = null, 
			string m3_TPND = null, 
			decimal? m3_LMTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstRelations",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FPND))
				request.WithQueryParameter("FPND", m3_FPND.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TPND))
				request.WithQueryParameter("TPND", m3_TPND.Trim());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstRelationsResponse>(
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
