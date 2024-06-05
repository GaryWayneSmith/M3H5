/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddInvoiceLog
		/// Description Add record to file FPLLOG
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3JRNO">Journal number (Required)</param>
		/// <param name="m3JSNO">Journal sequence number (Required)</param>
		/// <param name="m3ACTO">Action (Required)</param>
		/// <param name="m3USID">User ID (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3USI2">User ID 2</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddInvoiceLog(
			int m3YEA4, 
			int m3JRNO, 
			int m3JSNO, 
			int m3ACTO, 
			string m3USID, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3USI2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddInvoiceLog",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3USID))
				throw new ArgumentNullException(nameof(m3USID));

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3YEA4.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JRNO", m3JRNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JSNO", m3JSNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACTO", m3ACTO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("USID", m3USID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3USI2))
				request.WithQueryParameter("USI2", m3USI2.Trim());

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
		/// Name GetCashDiscInfo
		/// Description Get Cash Discount
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
		/// <returns>M3Response<GetCashDiscInfoResponse></returns>
		/// <exception cref="M3Exception<GetCashDiscInfoResponse>"></exception>
		public async Task<M3Response<GetCashDiscInfoResponse>> GetCashDiscInfo(
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetCashDiscInfo",
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
		/// Name GetInvImagePath
		/// Description Retrieve the image path
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3JRNO">Journal number (Required)</param>
		/// <param name="m3JSNO">Journal Sequence number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInvImagePathResponse></returns>
		/// <exception cref="M3Exception<GetInvImagePathResponse>"></exception>
		public async Task<M3Response<GetInvImagePathResponse>> GetInvImagePath(
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetInvImagePath",
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
			var result = await Execute<GetInvImagePathResponse>(
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
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3SPYN">Payee (Required)</param>
		/// <param name="m3SINO">Supplier invoice number (Required)</param>
		/// <param name="m3INYR">Invoice year (Required)</param>
		/// <param name="m3SUNO">Supplier (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInvTotInfoResponse></returns>
		/// <exception cref="M3Exception<GetInvTotInfoResponse>"></exception>
		public async Task<M3Response<GetInvTotInfoResponse>> GetInvTotInfo(
			string m3DIVI, 
			string m3SPYN, 
			string m3SINO, 
			int m3INYR, 
			string m3SUNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetInvTotInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3SPYN))
				throw new ArgumentNullException(nameof(m3SPYN));
			if (string.IsNullOrWhiteSpace(m3SINO))
				throw new ArgumentNullException(nameof(m3SINO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("SPYN", m3SPYN.Trim())
				.WithQueryParameter("SINO", m3SINO.Trim())
				.WithQueryParameter("INYR", m3INYR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SUNO", m3SUNO.Trim());

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
		/// Description Get Supplier Invoice
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetInvoice",
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
		/// Description Get unique key to supplier invoice record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SINO">Supplier invoice number (Required)</param>
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
			string m3SUNO, 
			string m3SINO, 
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetUniqueKey",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SINO))
				throw new ArgumentNullException(nameof(m3SINO));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SINO", m3SINO.Trim())
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
		/// Name LstInvoiceLog
		/// Description List records from file FPLLOG
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3JRNO">Journal number (Required)</param>
		/// <param name="m3JSNO">Journal sequence number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3ACTO">Action</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvoiceLogResponse></returns>
		/// <exception cref="M3Exception<LstInvoiceLogResponse>"></exception>
		public async Task<M3Response<LstInvoiceLogResponse>> LstInvoiceLog(
			int m3YEA4, 
			int m3JRNO, 
			int m3JSNO, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			int? m3ACTO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstInvoiceLog",
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
			if (m3ACTO.HasValue)
				request.WithQueryParameter("ACTO", m3ACTO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstInvoiceLogResponse>(
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
		/// Name SearchSupInvoic
		/// Description Search Supplier Invoice
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchSupInvoicResponse></returns>
		/// <exception cref="M3Exception<SearchSupInvoicResponse>"></exception>
		public async Task<M3Response<SearchSupInvoicResponse>> SearchSupInvoic(
			string m3SQRY, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SearchSupInvoic",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SQRY))
				throw new ArgumentNullException(nameof(m3SQRY));

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchSupInvoicResponse>(
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
		/// Name SetInvAsADC
		/// Description Set Invoice as an ADC invoice
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
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetInvAsADC(
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SetInvAsADC",
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
