/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3ITTY">Item type</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3ITCL">Product group</param>
		/// <param name="m3EQTP">Equipment type</param>
		/// <param name="m3EQGR">Equipment group</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3ORTP">Customer order type</param>
		/// <param name="m3CSRE">Supplier's customer reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDealerCodeResponse></returns>
		/// <exception cref="M3Exception<GetDealerCodeResponse>"></exception>
		public async Task<M3Response<GetDealerCodeResponse>> GetDealerCode(
			string m3ITTY = null, 
			string m3ITGR = null, 
			string m3ITCL = null, 
			string m3EQTP = null, 
			string m3EQGR = null, 
			string m3CUNO = null, 
			string m3CSCD = null, 
			string m3DIVI = null, 
			string m3FACI = null, 
			string m3ECAR = null, 
			string m3WHLO = null, 
			string m3ORTP = null, 
			string m3CSRE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3ITTY))
				request.WithQueryParameter("ITTY", m3ITTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITCL))
				request.WithQueryParameter("ITCL", m3ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQTP))
				request.WithQueryParameter("EQTP", m3EQTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQGR))
				request.WithQueryParameter("EQGR", m3EQGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTP))
				request.WithQueryParameter("ORTP", m3ORTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSRE))
				request.WithQueryParameter("CSRE", m3CSRE.Trim());

			// Execute the request
			var result = await Execute<GetDealerCodeResponse>(
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
