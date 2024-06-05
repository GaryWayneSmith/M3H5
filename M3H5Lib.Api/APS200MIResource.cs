/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.APS200MI;
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
	/// Name: APS200MI
	/// Component Name: SupplierInvoice
	/// Description: Supplier invoice interface
	/// Version Release: 5ea1
	///</summary>
	public partial class APS200MIResource : M3BaseResourceEndpoint
	{
		public APS200MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "APS200MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddInvoiceLog
		/// Description Add record to file FPLLOG
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_JRNO">Journal number (Required)</param>
		/// <param name="m3_JSNO">Journal sequence number (Required)</param>
		/// <param name="m3_ACTO">Action (Required)</param>
		/// <param name="m3_USID">User ID (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_USI2">User ID 2</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddInvoiceLog(
			int m3_YEA4, 
			int m3_JRNO, 
			int m3_JSNO, 
			int m3_ACTO, 
			string m3_USID, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_USI2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddInvoiceLog",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("JRNO", m3_JRNO.ToString())
				.WithQueryParameter("JSNO", m3_JSNO.ToString())
				.WithQueryParameter("ACTO", m3_ACTO.ToString())
				.WithQueryParameter("USID", m3_USID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USI2))
				request.WithQueryParameter("USI2", m3_USI2.Trim());

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
		/// Name GetCashDiscInfo
		/// Description Get Cash Discount
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_JRNO">Journal number (Required)</param>
		/// <param name="m3_JSNO">Journal sequence number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCashDiscInfoResponse></returns>
		/// <exception cref="M3Exception<GetCashDiscInfoResponse>"></exception>
		public async Task<M3Response<GetCashDiscInfoResponse>> GetCashDiscInfo(
			int m3_YEA4, 
			int m3_JRNO, 
			int m3_JSNO, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetCashDiscInfo",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("JRNO", m3_JRNO.ToString())
				.WithQueryParameter("JSNO", m3_JSNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<GetCashDiscInfoResponse>(
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
		/// Name GetInvImagePath
		/// Description Retrieve the image path
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_JRNO">Journal number (Required)</param>
		/// <param name="m3_JSNO">Journal Sequence number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInvImagePathResponse></returns>
		/// <exception cref="M3Exception<GetInvImagePathResponse>"></exception>
		public async Task<M3Response<GetInvImagePathResponse>> GetInvImagePath(
			int m3_YEA4, 
			int m3_JRNO, 
			int m3_JSNO, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetInvImagePath",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("JRNO", m3_JRNO.ToString())
				.WithQueryParameter("JSNO", m3_JSNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<GetInvImagePathResponse>(
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
		/// Name GetInvTotInfo
		/// Description Get Invoice Total Information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_SPYN">Payee (Required)</param>
		/// <param name="m3_SINO">Supplier invoice number (Required)</param>
		/// <param name="m3_INYR">Invoice year (Required)</param>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInvTotInfoResponse></returns>
		/// <exception cref="M3Exception<GetInvTotInfoResponse>"></exception>
		public async Task<M3Response<GetInvTotInfoResponse>> GetInvTotInfo(
			string m3_DIVI, 
			string m3_SPYN, 
			string m3_SINO, 
			int m3_INYR, 
			string m3_SUNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetInvTotInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_SPYN))
				throw new ArgumentNullException("m3_SPYN");
			if (string.IsNullOrWhiteSpace(m3_SINO))
				throw new ArgumentNullException("m3_SINO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("SPYN", m3_SPYN.Trim())
				.WithQueryParameter("SINO", m3_SINO.Trim())
				.WithQueryParameter("INYR", m3_INYR.ToString())
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Execute the request
			var result = await Execute<GetInvTotInfoResponse>(
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
		/// Name GetInvoice
		/// Description Get Supplier Invoice
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_JRNO">Journal number (Required)</param>
		/// <param name="m3_JSNO">Journal sequence number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInvoiceResponse></returns>
		/// <exception cref="M3Exception<GetInvoiceResponse>"></exception>
		public async Task<M3Response<GetInvoiceResponse>> GetInvoice(
			int m3_YEA4, 
			int m3_JRNO, 
			int m3_JSNO, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetInvoice",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("JRNO", m3_JRNO.ToString())
				.WithQueryParameter("JSNO", m3_JSNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<GetInvoiceResponse>(
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
		/// Name GetUniqueKey
		/// Description Get unique key to supplier invoice record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SINO">Supplier invoice number (Required)</param>
		/// <param name="m3_IVDT">Invoice date (Required)</param>
		/// <param name="m3_INYR">Invoice year (Required)</param>
		/// <param name="m3_TRCD">Transaction code (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetUniqueKeyResponse></returns>
		/// <exception cref="M3Exception<GetUniqueKeyResponse>"></exception>
		public async Task<M3Response<GetUniqueKeyResponse>> GetUniqueKey(
			string m3_SUNO, 
			string m3_SINO, 
			DateTime m3_IVDT, 
			int m3_INYR, 
			int m3_TRCD, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetUniqueKey",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SINO))
				throw new ArgumentNullException("m3_SINO");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SINO", m3_SINO.Trim())
				.WithQueryParameter("IVDT", m3_IVDT.ToM3String())
				.WithQueryParameter("INYR", m3_INYR.ToString())
				.WithQueryParameter("TRCD", m3_TRCD.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<GetUniqueKeyResponse>(
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
		/// Name LstInvoiceLog
		/// Description List records from file FPLLOG
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_JRNO">Journal number (Required)</param>
		/// <param name="m3_JSNO">Journal sequence number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_ACTO">Action</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvoiceLogResponse></returns>
		/// <exception cref="M3Exception<LstInvoiceLogResponse>"></exception>
		public async Task<M3Response<LstInvoiceLogResponse>> LstInvoiceLog(
			int m3_YEA4, 
			int m3_JRNO, 
			int m3_JSNO, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			int? m3_ACTO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInvoiceLog",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("JRNO", m3_JRNO.ToString())
				.WithQueryParameter("JSNO", m3_JSNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_ACTO.HasValue)
				request.WithQueryParameter("ACTO", m3_ACTO.Value.ToString());

			// Execute the request
			var result = await Execute<LstInvoiceLogResponse>(
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
		/// Name SearchSupInvoic
		/// Description Search Supplier Invoice
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchSupInvoicResponse></returns>
		/// <exception cref="M3Exception<SearchSupInvoicResponse>"></exception>
		public async Task<M3Response<SearchSupInvoicResponse>> SearchSupInvoic(
			string m3_SQRY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchSupInvoic",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SQRY))
				throw new ArgumentNullException("m3_SQRY");

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3_SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchSupInvoicResponse>(
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
		/// Name SetInvAsADC
		/// Description Set Invoice as an ADC invoice
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_JRNO">Journal number (Required)</param>
		/// <param name="m3_JSNO">Journal sequence number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetInvAsADC(
			int m3_YEA4, 
			int m3_JRNO, 
			int m3_JSNO, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SetInvAsADC",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("JRNO", m3_JRNO.ToString())
				.WithQueryParameter("JSNO", m3_JSNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

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
