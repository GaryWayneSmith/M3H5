/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.CRS065MI;
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
	/// Name: CRS065MI
	/// Component Name: DeliveryTerm
	/// Description: Delivery Term interface
	/// Version Release: 5ea0
	///</summary>
	public partial class CRS065MIResource : M3BaseResourceEndpoint
	{
		public CRS065MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS065MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddDelyTerm
		/// Description Add Delivery Term
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3TEL1">Termstext (Required)</param>
		/// <param name="m3DELT">Goodsresponsibility (Required)</param>
		/// <param name="m3TXPO">Tax point (Required)</param>
		/// <param name="m3FRRU">Fiscal representative rule (Required)</param>
		/// <param name="m3TEDL">Deliveryterms</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3TEL2">Termstext</param>
		/// <param name="m3RCPY">Recipientpays</param>
		/// <param name="m3ADJR">Adjustmentfactorconsignee</param>
		/// <param name="m3ADJS">Adjustmentfactorconsignor</param>
		/// <param name="m3ECDT">Deliveryterms-INTRASTAT</param>
		/// <param name="m3EXTD">Delivery terms - Extrastat (Extra)</param>
		/// <param name="m3FRCK">Freight cost control</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDelyTerm(
			string m3TEL1, 
			int m3DELT, 
			int m3TXPO, 
			int m3FRRU, 
			string m3TEDL = null, 
			string m3LNCD = null, 
			string m3TX15 = null, 
			string m3TEL2 = null, 
			int? m3RCPY = null, 
			int? m3ADJR = null, 
			int? m3ADJS = null, 
			string m3ECDT = null, 
			string m3EXTD = null, 
			int? m3FRCK = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddDelyTerm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TEL1))
				throw new ArgumentNullException(nameof(m3TEL1));

			// Set mandatory parameters
			request
				.WithQueryParameter("TEL1", m3TEL1.Trim())
				.WithQueryParameter("DELT", m3DELT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TXPO", m3TXPO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FRRU", m3FRRU.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEL2))
				request.WithQueryParameter("TEL2", m3TEL2.Trim());
			if (m3RCPY.HasValue)
				request.WithQueryParameter("RCPY", m3RCPY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADJR.HasValue)
				request.WithQueryParameter("ADJR", m3ADJR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADJS.HasValue)
				request.WithQueryParameter("ADJS", m3ADJS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECDT))
				request.WithQueryParameter("ECDT", m3ECDT.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXTD))
				request.WithQueryParameter("EXTD", m3EXTD.Trim());
			if (m3FRCK.HasValue)
				request.WithQueryParameter("FRCK", m3FRCK.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<M3Record>(
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
		/// Name DelDelyTerm
		/// Description Delete Delivery Term
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3TEDL">Deliveryterms</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelDelyTerm(
			string m3TEDL = null, 
			string m3LNCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelDelyTerm",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
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
		/// Name GetDelyTerm
		/// Description Get Delivery Term
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3TEDL">Deliveryterms</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDelyTermResponse></returns>
		/// <exception cref="M3Exception<GetDelyTermResponse>"></exception>
		public async Task<M3Response<GetDelyTermResponse>> GetDelyTerm(
			string m3TEDL = null, 
			string m3LNCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDelyTerm",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<GetDelyTermResponse>(
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
		/// Name LstDelyTerm
		/// Description List Delivery Term
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3TEDL">Deliveryterms</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDelyTermResponse></returns>
		/// <exception cref="M3Exception<LstDelyTermResponse>"></exception>
		public async Task<M3Response<LstDelyTermResponse>> LstDelyTerm(
			string m3TEDL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDelyTerm",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());

			// Execute the request
			var result = await Execute<LstDelyTermResponse>(
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
		/// Name UpdDelyTerm
		/// Description Update Delivery Term
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3TEDL">Deliveryterms</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3TEL1">Termstext</param>
		/// <param name="m3TEL2">Termstext</param>
		/// <param name="m3RCPY">Recipientpays</param>
		/// <param name="m3DELT">Goodsresponsibility</param>
		/// <param name="m3ADJR">Adjustmentfactorconsignee</param>
		/// <param name="m3ADJS">Adjustmentfactorconsignor</param>
		/// <param name="m3ECDT">Deliveryterms-INTRASTAT</param>
		/// <param name="m3EXTD">Delivery terms - Extrastat (Extra)</param>
		/// <param name="m3TXPO">Tax point</param>
		/// <param name="m3FRCK">Freight cost control</param>
		/// <param name="m3FRRU">Fiscal representative rule</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdDelyTerm(
			string m3TEDL = null, 
			string m3LNCD = null, 
			string m3TX15 = null, 
			string m3TEL1 = null, 
			string m3TEL2 = null, 
			int? m3RCPY = null, 
			int? m3DELT = null, 
			int? m3ADJR = null, 
			int? m3ADJS = null, 
			string m3ECDT = null, 
			string m3EXTD = null, 
			int? m3TXPO = null, 
			int? m3FRCK = null, 
			int? m3FRRU = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdDelyTerm",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEL1))
				request.WithQueryParameter("TEL1", m3TEL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEL2))
				request.WithQueryParameter("TEL2", m3TEL2.Trim());
			if (m3RCPY.HasValue)
				request.WithQueryParameter("RCPY", m3RCPY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DELT.HasValue)
				request.WithQueryParameter("DELT", m3DELT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADJR.HasValue)
				request.WithQueryParameter("ADJR", m3ADJR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADJS.HasValue)
				request.WithQueryParameter("ADJS", m3ADJS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECDT))
				request.WithQueryParameter("ECDT", m3ECDT.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXTD))
				request.WithQueryParameter("EXTD", m3EXTD.Trim());
			if (m3TXPO.HasValue)
				request.WithQueryParameter("TXPO", m3TXPO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRCK.HasValue)
				request.WithQueryParameter("FRCK", m3FRCK.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRRU.HasValue)
				request.WithQueryParameter("FRRU", m3FRRU.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<M3Record>(
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
