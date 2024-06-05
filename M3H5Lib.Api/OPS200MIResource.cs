/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.OPS200MI;
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
	/// Name: OPS200MI
	/// Component Name: PointOfSale
	/// Description: Value coupon ledger
	/// Version Release: 13.1
	///</summary>
	public partial class OPS200MIResource : M3BaseResourceEndpoint
	{
		public OPS200MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OPS200MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ChkVCLdgSale
		/// Description Check value coupon ledger sale
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_PYCD">Payment method - accounts receivable</param>
		/// <param name="m3_VCNO">Value coupon no</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ChkVCLdgSaleResponse></returns>
		/// <exception cref="M3Exception<ChkVCLdgSaleResponse>"></exception>
		public async Task<M3Response<ChkVCLdgSaleResponse>> ChkVCLdgSale(
			string m3_PYCD = null, 
			string m3_VCNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChkVCLdgSale",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PYCD))
				request.WithQueryParameter("PYCD", m3_PYCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VCNO))
				request.WithQueryParameter("VCNO", m3_VCNO.Trim());

			// Execute the request
			var result = await Execute<ChkVCLdgSaleResponse>(
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

		/// <summary>
		/// Name ChkVCLdgTend
		/// Description Check value coupon ledger end
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_PYCD">Payment method - accounts receivable</param>
		/// <param name="m3_VCNO">Value coupon no</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ChkVCLdgTendResponse></returns>
		/// <exception cref="M3Exception<ChkVCLdgTendResponse>"></exception>
		public async Task<M3Response<ChkVCLdgTendResponse>> ChkVCLdgTend(
			string m3_PYCD = null, 
			string m3_VCNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChkVCLdgTend",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PYCD))
				request.WithQueryParameter("PYCD", m3_PYCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VCNO))
				request.WithQueryParameter("VCNO", m3_VCNO.Trim());

			// Execute the request
			var result = await Execute<ChkVCLdgTendResponse>(
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
