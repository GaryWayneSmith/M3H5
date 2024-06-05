/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3APIP">APS - policy</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3POOT">Point of time table</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3ENDT">Finish date</param>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstForPacingResponse></returns>
		/// <exception cref="M3Exception<LstForPacingResponse>"></exception>
		public async Task<M3Response<LstForPacingResponse>> LstForPacing(
			string m3WHGR = null, 
			string m3WHLO = null, 
			string m3APIP = null, 
			string m3ITNO = null, 
			string m3POOT = null, 
			DateTime? m3STDT = null, 
			DateTime? m3ENDT = null, 
			decimal? m3LMTS = null, 
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
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3POOT))
				request.WithQueryParameter("POOT", m3POOT.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3ENDT.HasValue)
				request.WithQueryParameter("ENDT", m3ENDT.Value.ToM3String());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstForPacingResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}
	}
}
// EOF
