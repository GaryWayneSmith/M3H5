/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_TEL1">Termstext (Required)</param>
		/// <param name="m3_DELT">Goodsresponsibility (Required)</param>
		/// <param name="m3_TXPO">Tax point (Required)</param>
		/// <param name="m3_FRRU">Fiscal representative rule (Required)</param>
		/// <param name="m3_TEDL">Deliveryterms</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TEL2">Termstext</param>
		/// <param name="m3_RCPY">Recipientpays</param>
		/// <param name="m3_ADJR">Adjustmentfactorconsignee</param>
		/// <param name="m3_ADJS">Adjustmentfactorconsignor</param>
		/// <param name="m3_ECDT">Deliveryterms-INTRASTAT</param>
		/// <param name="m3_EXTD">Delivery terms - Extrastat (Extra)</param>
		/// <param name="m3_FRCK">Freight cost control</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDelyTerm(
			string m3_TEL1, 
			int m3_DELT, 
			int m3_TXPO, 
			int m3_FRRU, 
			string m3_TEDL = null, 
			string m3_LNCD = null, 
			string m3_TX15 = null, 
			string m3_TEL2 = null, 
			int? m3_RCPY = null, 
			int? m3_ADJR = null, 
			int? m3_ADJS = null, 
			string m3_ECDT = null, 
			string m3_EXTD = null, 
			int? m3_FRCK = null, 
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
			if (string.IsNullOrWhiteSpace(m3_TEL1))
				throw new ArgumentNullException("m3_TEL1");

			// Set mandatory parameters
			request
				.WithQueryParameter("TEL1", m3_TEL1.Trim())
				.WithQueryParameter("DELT", m3_DELT.ToString())
				.WithQueryParameter("TXPO", m3_TXPO.ToString())
				.WithQueryParameter("FRRU", m3_FRRU.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEL2))
				request.WithQueryParameter("TEL2", m3_TEL2.Trim());
			if (m3_RCPY.HasValue)
				request.WithQueryParameter("RCPY", m3_RCPY.Value.ToString());
			if (m3_ADJR.HasValue)
				request.WithQueryParameter("ADJR", m3_ADJR.Value.ToString());
			if (m3_ADJS.HasValue)
				request.WithQueryParameter("ADJS", m3_ADJS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECDT))
				request.WithQueryParameter("ECDT", m3_ECDT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXTD))
				request.WithQueryParameter("EXTD", m3_EXTD.Trim());
			if (m3_FRCK.HasValue)
				request.WithQueryParameter("FRCK", m3_FRCK.Value.ToString());

			// Execute the request
			var result = await Execute<M3Record>(
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
		/// Name DelDelyTerm
		/// Description Delete Delivery Term
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_TEDL">Deliveryterms</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelDelyTerm(
			string m3_TEDL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelDelyTerm",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
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
		/// Name GetDelyTerm
		/// Description Get Delivery Term
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_TEDL">Deliveryterms</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDelyTermResponse></returns>
		/// <exception cref="M3Exception<GetDelyTermResponse>"></exception>
		public async Task<M3Response<GetDelyTermResponse>> GetDelyTerm(
			string m3_TEDL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDelyTerm",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<GetDelyTermResponse>(
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
		/// Name LstDelyTerm
		/// Description List Delivery Term
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_TEDL">Deliveryterms</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDelyTermResponse></returns>
		/// <exception cref="M3Exception<LstDelyTermResponse>"></exception>
		public async Task<M3Response<LstDelyTermResponse>> LstDelyTerm(
			string m3_TEDL = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());

			// Execute the request
			var result = await Execute<LstDelyTermResponse>(
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
		/// Name UpdDelyTerm
		/// Description Update Delivery Term
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_TEDL">Deliveryterms</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TEL1">Termstext</param>
		/// <param name="m3_TEL2">Termstext</param>
		/// <param name="m3_RCPY">Recipientpays</param>
		/// <param name="m3_DELT">Goodsresponsibility</param>
		/// <param name="m3_ADJR">Adjustmentfactorconsignee</param>
		/// <param name="m3_ADJS">Adjustmentfactorconsignor</param>
		/// <param name="m3_ECDT">Deliveryterms-INTRASTAT</param>
		/// <param name="m3_EXTD">Delivery terms - Extrastat (Extra)</param>
		/// <param name="m3_TXPO">Tax point</param>
		/// <param name="m3_FRCK">Freight cost control</param>
		/// <param name="m3_FRRU">Fiscal representative rule</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdDelyTerm(
			string m3_TEDL = null, 
			string m3_LNCD = null, 
			string m3_TX15 = null, 
			string m3_TEL1 = null, 
			string m3_TEL2 = null, 
			int? m3_RCPY = null, 
			int? m3_DELT = null, 
			int? m3_ADJR = null, 
			int? m3_ADJS = null, 
			string m3_ECDT = null, 
			string m3_EXTD = null, 
			int? m3_TXPO = null, 
			int? m3_FRCK = null, 
			int? m3_FRRU = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEL1))
				request.WithQueryParameter("TEL1", m3_TEL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEL2))
				request.WithQueryParameter("TEL2", m3_TEL2.Trim());
			if (m3_RCPY.HasValue)
				request.WithQueryParameter("RCPY", m3_RCPY.Value.ToString());
			if (m3_DELT.HasValue)
				request.WithQueryParameter("DELT", m3_DELT.Value.ToString());
			if (m3_ADJR.HasValue)
				request.WithQueryParameter("ADJR", m3_ADJR.Value.ToString());
			if (m3_ADJS.HasValue)
				request.WithQueryParameter("ADJS", m3_ADJS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECDT))
				request.WithQueryParameter("ECDT", m3_ECDT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXTD))
				request.WithQueryParameter("EXTD", m3_EXTD.Trim());
			if (m3_TXPO.HasValue)
				request.WithQueryParameter("TXPO", m3_TXPO.Value.ToString());
			if (m3_FRCK.HasValue)
				request.WithQueryParameter("FRCK", m3_FRCK.Value.ToString());
			if (m3_FRRU.HasValue)
				request.WithQueryParameter("FRRU", m3_FRRU.Value.ToString());

			// Execute the request
			var result = await Execute<M3Record>(
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
