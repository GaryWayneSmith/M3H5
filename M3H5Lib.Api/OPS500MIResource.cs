/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.OPS500MI;
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
	/// Name: OPS500MI
	/// Component Name: Store Information
	/// Description: Retrieves Store Information
	/// Version Release: 14.x
	///</summary>
	public partial class OPS500MIResource : M3BaseResourceEndpoint
	{
		public OPS500MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OPS500MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstCollabStores
		/// Description LstCollabStores
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCollabStoresResponse></returns>
		/// <exception cref="M3Exception<LstCollabStoresResponse>"></exception>
		public async Task<M3Response<LstCollabStoresResponse>> LstCollabStores(
			int? m3CONO = null, 
			string m3WHLO = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstCollabStores",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Execute the request
			var result = await Execute<LstCollabStoresResponse>(
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

		/// <summary>
		/// Name LstShopCategory
		/// Description Store category
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company Number</param>
		/// <param name="m3FRSC">From Shop Category</param>
		/// <param name="m3TOSC">To Shop Number</param>
		/// <param name="m3LMTS">Last import´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstShopCategoryResponse></returns>
		/// <exception cref="M3Exception<LstShopCategoryResponse>"></exception>
		public async Task<M3Response<LstShopCategoryResponse>> LstShopCategory(
			int? m3CONO = null, 
			string m3FRSC = null, 
			string m3TOSC = null, 
			decimal? m3LMTS = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstShopCategory",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRSC))
				request.WithQueryParameter("FRSC", m3FRSC.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOSC))
				request.WithQueryParameter("TOSC", m3TOSC.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstShopCategoryResponse>(
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

		/// <summary>
		/// Name LstShopClass
		/// Description Store shop classes
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company Number</param>
		/// <param name="m3FRST">From Shop Classes</param>
		/// <param name="m3TOST">To Shop Classes</param>
		/// <param name="m3LMTS">Last import´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstShopClassResponse></returns>
		/// <exception cref="M3Exception<LstShopClassResponse>"></exception>
		public async Task<M3Response<LstShopClassResponse>> LstShopClass(
			int? m3CONO = null, 
			string m3FRST = null, 
			string m3TOST = null, 
			decimal? m3LMTS = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstShopClass",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRST))
				request.WithQueryParameter("FRST", m3FRST.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOST))
				request.WithQueryParameter("TOST", m3TOST.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstShopClassResponse>(
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

		/// <summary>
		/// Name LstShopVolClass
		/// Description Store Volume class
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company Number</param>
		/// <param name="m3FRVO">From Shop Vol Class</param>
		/// <param name="m3TOVO">To Shop Vol Class</param>
		/// <param name="m3LMTS">Last import´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstShopVolClassResponse></returns>
		/// <exception cref="M3Exception<LstShopVolClassResponse>"></exception>
		public async Task<M3Response<LstShopVolClassResponse>> LstShopVolClass(
			int? m3CONO = null, 
			string m3FRVO = null, 
			string m3TOVO = null, 
			decimal? m3LMTS = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstShopVolClass",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRVO))
				request.WithQueryParameter("FRVO", m3FRVO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOVO))
				request.WithQueryParameter("TOVO", m3TOVO.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstShopVolClassResponse>(
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

		/// <summary>
		/// Name LstStore
		/// Description Transfers Store related data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FWHL">From Warehouse</param>
		/// <param name="m3TWHL">To Warehouse</param>
		/// <param name="m3FRSN">From Store</param>
		/// <param name="m3TRSN">To Store</param>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstStoreResponse></returns>
		/// <exception cref="M3Exception<LstStoreResponse>"></exception>
		public async Task<M3Response<LstStoreResponse>> LstStore(
			int? m3CONO = null, 
			string m3FWHL = null, 
			string m3TWHL = null, 
			string m3FRSN = null, 
			string m3TRSN = null, 
			DateTime? m3LMTS = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstStore",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FWHL))
				request.WithQueryParameter("FWHL", m3FWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWHL))
				request.WithQueryParameter("TWHL", m3TWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRSN))
				request.WithQueryParameter("FRSN", m3FRSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRSN))
				request.WithQueryParameter("TRSN", m3TRSN.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstStoreResponse>(
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

		/// <summary>
		/// Name LstTmplCustomer
		/// Description LstTmplCustomer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTmplCustomerResponse></returns>
		/// <exception cref="M3Exception<LstTmplCustomerResponse>"></exception>
		public async Task<M3Response<LstTmplCustomerResponse>> LstTmplCustomer(
			int? m3CONO = null, 
			string m3WHLO = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstTmplCustomer",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Execute the request
			var result = await Execute<LstTmplCustomerResponse>(
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
