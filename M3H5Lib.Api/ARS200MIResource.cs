/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.ARS200MI;
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
	/// Name: ARS200MI
	/// Component Name: CustomerInvoice
	/// Description: Customer invoice interface
	/// Version Release: 5ea2
	///</summary>
	public partial class ARS200MIResource : M3BaseResourceEndpoint
	{
		public ARS200MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "ARS200MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetCashDiscInfo
		/// Description Get Cash Discount
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3JRNO">Journal number (Required)</param>
		/// <param name="m3JSNO">Journal sequence number (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCashDiscInfoResponse></returns>
		/// <exception cref="M3Exception<GetCashDiscInfoResponse>"></exception>
		public async Task<M3Response<GetCashDiscInfoResponse>> GetCashDiscInfo(
			int m3CONO, 
			int m3YEA4, 
			int m3JRNO, 
			int m3JSNO, 
			string m3DIVI = null, 
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
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("YEA4", m3YEA4.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JRNO", m3JRNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JSNO", m3JSNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<GetCashDiscInfoResponse>(
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
		/// Name GetInvTotInfo
		/// Description Get Invoice Total Information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PYNO">Payer (Required)</param>
		/// <param name="m3CINO">Invoice number (Required)</param>
		/// <param name="m3INYR">Invoice year (Required)</param>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInvTotInfoResponse></returns>
		/// <exception cref="M3Exception<GetInvTotInfoResponse>"></exception>
		public async Task<M3Response<GetInvTotInfoResponse>> GetInvTotInfo(
			string m3PYNO, 
			string m3CINO, 
			int m3INYR, 
			string m3CUNO, 
			string m3DIVI = null, 
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
			if (string.IsNullOrWhiteSpace(m3PYNO))
				throw new ArgumentNullException(nameof(m3PYNO));
			if (string.IsNullOrWhiteSpace(m3CINO))
				throw new ArgumentNullException(nameof(m3CINO));
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PYNO", m3PYNO.Trim())
				.WithQueryParameter("CINO", m3CINO.Trim())
				.WithQueryParameter("INYR", m3INYR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<GetInvTotInfoResponse>(
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
		/// Name GetInvoice
		/// Description Get Customer Invoice
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3JRNO">Journal number (Required)</param>
		/// <param name="m3JSNO">Journal sequence number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInvoiceResponse></returns>
		/// <exception cref="M3Exception<GetInvoiceResponse>"></exception>
		public async Task<M3Response<GetInvoiceResponse>> GetInvoice(
			int m3YEA4, 
			int m3JRNO, 
			int m3JSNO, 
			int? m3CONO = null, 
			string m3DIVI = null, 
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
				.WithQueryParameter("YEA4", m3YEA4.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JRNO", m3JRNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JSNO", m3JSNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<GetInvoiceResponse>(
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
		/// Name GetUniqueKey
		/// Description Get unique key to customer invoice record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3CINO">Invoice number (Required)</param>
		/// <param name="m3IVDT">Invoice date (Required)</param>
		/// <param name="m3INYR">Invoice year (Required)</param>
		/// <param name="m3TRCD">Transaction code (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetUniqueKeyResponse></returns>
		/// <exception cref="M3Exception<GetUniqueKeyResponse>"></exception>
		public async Task<M3Response<GetUniqueKeyResponse>> GetUniqueKey(
			string m3CUNO, 
			string m3CINO, 
			DateTime m3IVDT, 
			int m3INYR, 
			int m3TRCD, 
			int? m3CONO = null, 
			string m3DIVI = null, 
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
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3CINO))
				throw new ArgumentNullException(nameof(m3CINO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("CINO", m3CINO.Trim())
				.WithQueryParameter("IVDT", m3IVDT.ToM3String())
				.WithQueryParameter("INYR", m3INYR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TRCD", m3TRCD.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<GetUniqueKeyResponse>(
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
		/// Name LstInvByDivi
		/// Description List invoices per division
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3FDIV">Division</param>
		/// <param name="m3TDIV">Division</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3AAC0">Only open invoices</param>
		/// <param name="m3IVDT">Invoice date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvByDiviResponse></returns>
		/// <exception cref="M3Exception<LstInvByDiviResponse>"></exception>
		public async Task<M3Response<LstInvByDiviResponse>> LstInvByDivi(
			string m3FDIV = null, 
			string m3TDIV = null, 
			string m3PYNO = null, 
			string m3CUNO = null, 
			int? m3AAC0 = null, 
			DateTime? m3IVDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInvByDivi",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FDIV))
				request.WithQueryParameter("FDIV", m3FDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3TDIV))
				request.WithQueryParameter("TDIV", m3TDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3AAC0.HasValue)
				request.WithQueryParameter("AAC0", m3AAC0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IVDT.HasValue)
				request.WithQueryParameter("IVDT", m3IVDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstInvByDiviResponse>(
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
		/// Name LstInvoices
		/// Description List invoices per customer
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3AAC0">Only open invoices</param>
		/// <param name="m3IVDT">Invoice date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvoicesResponse></returns>
		/// <exception cref="M3Exception<LstInvoicesResponse>"></exception>
		public async Task<M3Response<LstInvoicesResponse>> LstInvoices(
			string m3CUNO, 
			int? m3AAC0 = null, 
			DateTime? m3IVDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInvoices",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3AAC0.HasValue)
				request.WithQueryParameter("AAC0", m3AAC0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IVDT.HasValue)
				request.WithQueryParameter("IVDT", m3IVDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstInvoicesResponse>(
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
		/// Name SearchInvoices
		/// Description SearchInvoices
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchInvoicesResponse></returns>
		/// <exception cref="M3Exception<SearchInvoicesResponse>"></exception>
		public async Task<M3Response<SearchInvoicesResponse>> SearchInvoices(
			string m3SQRY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchInvoices",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SQRY))
				throw new ArgumentNullException(nameof(m3SQRY));

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchInvoicesResponse>(
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
