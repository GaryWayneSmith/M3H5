/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS275MI;
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
	/// Name: CRS275MI
	/// Component Name: CustomerOrderLineCharges
	/// Description: Order line charges
	/// Version Release: 12.4
	///</summary>
	public partial class CRS275MIResource : M3BaseResourceEndpoint
	{
		public CRS275MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS275MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstLineChrgHead
		/// Description List order line charges
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CRID">Charge</param>
		/// <param name="m3_CRTY">Internal charge</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineChrgHeadResponse></returns>
		/// <exception cref="M3Exception<LstLineChrgHeadResponse>"></exception>
		public async Task<M3Response<LstLineChrgHeadResponse>> LstLineChrgHead(
			int? m3_CONO = null, 
			string m3_CRID = null, 
			int? m3_CRTY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLineChrgHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CRID))
				request.WithQueryParameter("CRID", m3_CRID.Trim());
			if (m3_CRTY.HasValue)
				request.WithQueryParameter("CRTY", m3_CRTY.Value.ToString());

			// Execute the request
			var result = await Execute<LstLineChrgHeadResponse>(
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
		/// Name LstLineChrgLng
		/// Description List order line charges languages
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CRID">Charge</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineChrgLngResponse></returns>
		/// <exception cref="M3Exception<LstLineChrgLngResponse>"></exception>
		public async Task<M3Response<LstLineChrgLngResponse>> LstLineChrgLng(
			int? m3_CONO = null, 
			string m3_CRID = null, 
			string m3_LNCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLineChrgLng",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CRID))
				request.WithQueryParameter("CRID", m3_CRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<LstLineChrgLngResponse>(
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
		/// Name LstLineChrgRate
		/// Description List order line charge rates
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CRID">Charge</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineChrgRateResponse></returns>
		/// <exception cref="M3Exception<LstLineChrgRateResponse>"></exception>
		public async Task<M3Response<LstLineChrgRateResponse>> LstLineChrgRate(
			int? m3_CONO = null, 
			string m3_CRID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLineChrgRate",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CRID))
				request.WithQueryParameter("CRID", m3_CRID.Trim());

			// Execute the request
			var result = await Execute<LstLineChrgRateResponse>(
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
