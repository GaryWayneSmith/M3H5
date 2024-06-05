/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.FCS366MI;
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
	/// Name: FCS366MI
	/// Component Name: PlanningEntity
	/// Description: Planning entity interface
	/// Version Release: 14.x
	///</summary>
	public partial class FCS366MIResource : M3BaseResourceEndpoint
	{
		public FCS366MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "FCS366MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstForPacing
		/// Description List forecast pacing
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_APIP">APS - policy</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_POOT">Point of time table</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_ENDT">Finish date</param>
		/// <param name="m3_LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstForPacingResponse></returns>
		/// <exception cref="M3Exception<LstForPacingResponse>"></exception>
		public async Task<M3Response<LstForPacingResponse>> LstForPacing(
			string m3_WHGR = null, 
			string m3_WHLO = null, 
			string m3_APIP = null, 
			string m3_ITNO = null, 
			string m3_POOT = null, 
			DateTime? m3_STDT = null, 
			DateTime? m3_ENDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstForPacing",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POOT))
				request.WithQueryParameter("POOT", m3_POOT.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_ENDT.HasValue)
				request.WithQueryParameter("ENDT", m3_ENDT.Value.ToM3String());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstForPacingResponse>(
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
