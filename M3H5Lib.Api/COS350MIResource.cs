/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.COS350MI;
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
	/// Name: COS350MI
	/// Component Name: CustomerOrderInvoice
	/// Description: Api: e-Invoicing
	/// Version Release: 5ea0
	///</summary>
	public partial class COS350MIResource : M3BaseResourceEndpoint
	{
		public COS350MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "COS350MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetDelLine
		/// Description Retrieve Delivery Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_ALI1">Transaction number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ALNT">Line type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDelLineResponse></returns>
		/// <exception cref="M3Exception<GetDelLineResponse>"></exception>
		public async Task<M3Response<GetDelLineResponse>> GetDelLine(
			string m3_ORNO, 
			int m3_PONR, 
			int m3_ALI1, 
			int? m3_CONO = null, 
			int? m3_ALNT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDelLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("ALI1", m3_ALI1.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_ALNT.HasValue)
				request.WithQueryParameter("ALNT", m3_ALNT.Value.ToString());

			// Execute the request
			var result = await Execute<GetDelLineResponse>(
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
		/// Name GetInvHead
		/// Description Retrieve Invoice Head
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_IVNO">Invoice number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_INPX">Invoice Prefix</param>
		/// <param name="m3_EXIN">Extended Invoice Number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInvHeadResponse></returns>
		/// <exception cref="M3Exception<GetInvHeadResponse>"></exception>
		public async Task<M3Response<GetInvHeadResponse>> GetInvHead(
			string m3_DIVI, 
			int m3_YEA4, 
			int m3_IVNO, 
			int? m3_CONO = null, 
			string m3_INPX = null, 
			string m3_EXIN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetInvHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("IVNO", m3_IVNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INPX))
				request.WithQueryParameter("INPX", m3_INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXIN))
				request.WithQueryParameter("EXIN", m3_EXIN.Trim());

			// Execute the request
			var result = await Execute<GetInvHeadResponse>(
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
		/// Name GetInvLine
		/// Description Retrieve Invoice Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_IVNO">Invoice number (Required)</param>
		/// <param name="m3_AIVT">Invoice line type (Required)</param>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_AIVR">Invoice reference (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_INPX">Invoice Prefix</param>
		/// <param name="m3_EXIN">Extended Invoice Number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInvLineResponse></returns>
		/// <exception cref="M3Exception<GetInvLineResponse>"></exception>
		public async Task<M3Response<GetInvLineResponse>> GetInvLine(
			string m3_DIVI, 
			int m3_YEA4, 
			int m3_IVNO, 
			string m3_AIVT, 
			string m3_ORNO, 
			string m3_AIVR, 
			int? m3_CONO = null, 
			string m3_INPX = null, 
			string m3_EXIN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetInvLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_AIVT))
				throw new ArgumentNullException("m3_AIVT");
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_AIVR))
				throw new ArgumentNullException("m3_AIVR");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("IVNO", m3_IVNO.ToString())
				.WithQueryParameter("AIVT", m3_AIVT.Trim())
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("AIVR", m3_AIVR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INPX))
				request.WithQueryParameter("INPX", m3_INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXIN))
				request.WithQueryParameter("EXIN", m3_EXIN.Trim());

			// Execute the request
			var result = await Execute<GetInvLineResponse>(
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
		/// Name LstDelLine
		/// Description List Delivery Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_ALI1">Transaction number</param>
		/// <param name="m3_ALNT">Line type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDelLineResponse></returns>
		/// <exception cref="M3Exception<LstDelLineResponse>"></exception>
		public async Task<M3Response<LstDelLineResponse>> LstDelLine(
			string m3_ORNO, 
			int? m3_CONO = null, 
			int? m3_PONR = null, 
			int? m3_ALI1 = null, 
			int? m3_ALNT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDelLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_ALI1.HasValue)
				request.WithQueryParameter("ALI1", m3_ALI1.Value.ToString());
			if (m3_ALNT.HasValue)
				request.WithQueryParameter("ALNT", m3_ALNT.Value.ToString());

			// Execute the request
			var result = await Execute<LstDelLineResponse>(
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
		/// Name LstInvHead
		/// Description List Invoice Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_IVNO">Invoice number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_INPX">Invoice Prefix</param>
		/// <param name="m3_EXIN">Extended Invoice Number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvHeadResponse></returns>
		/// <exception cref="M3Exception<LstInvHeadResponse>"></exception>
		public async Task<M3Response<LstInvHeadResponse>> LstInvHead(
			string m3_DIVI, 
			int m3_YEA4, 
			int m3_IVNO, 
			int? m3_CONO = null, 
			string m3_INPX = null, 
			string m3_EXIN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInvHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("IVNO", m3_IVNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INPX))
				request.WithQueryParameter("INPX", m3_INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXIN))
				request.WithQueryParameter("EXIN", m3_EXIN.Trim());

			// Execute the request
			var result = await Execute<LstInvHeadResponse>(
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
		/// Name LstInvHeadByCo
		/// Description List Invoice Head by Customer Order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvHeadByCoResponse></returns>
		/// <exception cref="M3Exception<LstInvHeadByCoResponse>"></exception>
		public async Task<M3Response<LstInvHeadByCoResponse>> LstInvHeadByCo(
			string m3_ORNO, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInvHeadByCo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstInvHeadByCoResponse>(
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
		/// Name LstInvHeadByPay
		/// Description List Invoice Head by Payer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_PYNO">Payer (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_IVNO">Invoice number</param>
		/// <param name="m3_INPX">Invoice Prefix</param>
		/// <param name="m3_EXIN">Extended Invoice Number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvHeadByPayResponse></returns>
		/// <exception cref="M3Exception<LstInvHeadByPayResponse>"></exception>
		public async Task<M3Response<LstInvHeadByPayResponse>> LstInvHeadByPay(
			string m3_DIVI, 
			int m3_YEA4, 
			string m3_PYNO, 
			int? m3_CONO = null, 
			int? m3_IVNO = null, 
			string m3_INPX = null, 
			string m3_EXIN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInvHeadByPay",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PYNO))
				throw new ArgumentNullException("m3_PYNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("PYNO", m3_PYNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_IVNO.HasValue)
				request.WithQueryParameter("IVNO", m3_IVNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INPX))
				request.WithQueryParameter("INPX", m3_INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXIN))
				request.WithQueryParameter("EXIN", m3_EXIN.Trim());

			// Execute the request
			var result = await Execute<LstInvHeadByPayResponse>(
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
		/// Name LstInvLine
		/// Description List Invoice Line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_IVNO">Invoice number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_INPX">Invoice Prefix</param>
		/// <param name="m3_EXIN">Extended Invoice Number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvLineResponse></returns>
		/// <exception cref="M3Exception<LstInvLineResponse>"></exception>
		public async Task<M3Response<LstInvLineResponse>> LstInvLine(
			string m3_DIVI, 
			int m3_YEA4, 
			int m3_IVNO, 
			int? m3_CONO = null, 
			string m3_INPX = null, 
			string m3_EXIN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInvLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("IVNO", m3_IVNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INPX))
				request.WithQueryParameter("INPX", m3_INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXIN))
				request.WithQueryParameter("EXIN", m3_EXIN.Trim());

			// Execute the request
			var result = await Execute<LstInvLineResponse>(
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
		/// Name LstInvLineByCO
		/// Description List Invoice Line CO Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvLineByCOResponse></returns>
		/// <exception cref="M3Exception<LstInvLineByCOResponse>"></exception>
		public async Task<M3Response<LstInvLineByCOResponse>> LstInvLineByCO(
			string m3_ORNO, 
			int m3_PONR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInvLineByCO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString());

			// Execute the request
			var result = await Execute<LstInvLineByCOResponse>(
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
		/// Name LstInvLineByTyp
		/// Description List Invoice Line By Type
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_IVNO">Invoice number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_AIVT">Invoice line type</param>
		/// <param name="m3_INPX">Invoice Prefix</param>
		/// <param name="m3_EXIN">Extended Invoice Number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvLineByTypResponse></returns>
		/// <exception cref="M3Exception<LstInvLineByTypResponse>"></exception>
		public async Task<M3Response<LstInvLineByTypResponse>> LstInvLineByTyp(
			string m3_DIVI, 
			int m3_YEA4, 
			int m3_IVNO, 
			int? m3_CONO = null, 
			string m3_AIVT = null, 
			string m3_INPX = null, 
			string m3_EXIN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInvLineByTyp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("IVNO", m3_IVNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AIVT))
				request.WithQueryParameter("AIVT", m3_AIVT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INPX))
				request.WithQueryParameter("INPX", m3_INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXIN))
				request.WithQueryParameter("EXIN", m3_EXIN.Trim());

			// Execute the request
			var result = await Execute<LstInvLineByTypResponse>(
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
