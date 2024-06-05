/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CMS020MI;
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
	/// Name: CMS020MI
	/// Component Name: Node
	/// Description: Planning Node
	/// Version Release: 12.2
	///</summary>
	public partial class CMS020MIResource : M3BaseResourceEndpoint
	{
		public CMS020MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS020MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstPlanningNode
		/// Description Planning node informtion
		/// Version Release: 12.6
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FPNO">From planning node</param>
		/// <param name="m3_TPNO">To planning node</param>
		/// <param name="m3_LMTS">Last import´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPlanningNodeResponse></returns>
		/// <exception cref="M3Exception<LstPlanningNodeResponse>"></exception>
		public async Task<M3Response<LstPlanningNodeResponse>> LstPlanningNode(
			int? m3_CONO = null, 
			string m3_FPNO = null, 
			string m3_TPNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPlanningNode",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FPNO))
				request.WithQueryParameter("FPNO", m3_FPNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TPNO))
				request.WithQueryParameter("TPNO", m3_TPNO.Trim());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstPlanningNodeResponse>(
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
