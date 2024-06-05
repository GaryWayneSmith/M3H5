/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CSS200MI;
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
	/// Name: CSS200MI
	/// Component Name: GetDealerCode API
	/// Description: Api:GetDealerCode
	/// Version Release: 14.x
	///</summary>
	public partial class CSS200MIResource : M3BaseResourceEndpoint
	{
		public CSS200MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CSS200MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetDealerCode
		/// Description Get Delaer Code
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_ITTY">Item type</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_ITCL">Product group</param>
		/// <param name="m3_EQTP">Equipment type</param>
		/// <param name="m3_EQGR">Equipment group</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_ORTP">Customer order type</param>
		/// <param name="m3_CSRE">Supplier's customer reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDealerCodeResponse></returns>
		/// <exception cref="M3Exception<GetDealerCodeResponse>"></exception>
		public async Task<M3Response<GetDealerCodeResponse>> GetDealerCode(
			string m3_ITTY = null, 
			string m3_ITGR = null, 
			string m3_ITCL = null, 
			string m3_EQTP = null, 
			string m3_EQGR = null, 
			string m3_CUNO = null, 
			string m3_CSCD = null, 
			string m3_DIVI = null, 
			string m3_FACI = null, 
			string m3_ECAR = null, 
			string m3_WHLO = null, 
			string m3_ORTP = null, 
			string m3_CSRE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDealerCode",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITTY))
				request.WithQueryParameter("ITTY", m3_ITTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITCL))
				request.WithQueryParameter("ITCL", m3_ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQTP))
				request.WithQueryParameter("EQTP", m3_EQTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQGR))
				request.WithQueryParameter("EQGR", m3_EQGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTP))
				request.WithQueryParameter("ORTP", m3_ORTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSRE))
				request.WithQueryParameter("CSRE", m3_CSRE.Trim());

			// Execute the request
			var result = await Execute<GetDealerCodeResponse>(
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
