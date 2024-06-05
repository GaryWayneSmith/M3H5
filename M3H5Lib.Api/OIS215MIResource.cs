/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.OIS215MI;
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
	/// Name: OIS215MI
	/// Component Name: OIS215
	/// Description: Cash sales open
	/// Version Release: 5ea0
	///</summary>
	public partial class OIS215MIResource : M3BaseResourceEndpoint
	{
		public OIS215MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS215MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add3rdpResult
		/// Description Add3rdpResult
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PMNB">Payment number</param>
		/// <param name="m3IRNO">Invoice reference number</param>
		/// <param name="m3CCEC">Result</param>
		/// <param name="m3MSGE">Message text</param>
		/// <param name="m3MSID">Message ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add3rdpResult(
			int? m3PMNB = null, 
			string m3IRNO = null, 
			string m3CCEC = null, 
			string m3MSGE = null, 
			string m3MSID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Add3rdpResult",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3PMNB.HasValue)
				request.WithQueryParameter("PMNB", m3PMNB.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3IRNO))
				request.WithQueryParameter("IRNO", m3IRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CCEC))
				request.WithQueryParameter("CCEC", m3CCEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSGE))
				request.WithQueryParameter("MSGE", m3MSGE.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSID))
				request.WithQueryParameter("MSID", m3MSID.Trim());

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
		/// Name AddCashMovement
		/// Description Add cash movement
		/// Version Release: 
		/// </summary>
		/// <param name="m3CSHD">From Cash desk (Required)</param>
		/// <param name="m3CSH2">To Cash desk (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3PYDT">Payment date (Required)</param>
		/// <param name="m3PMAM">Payment amount - foreign currency (Required)</param>
		/// <param name="m3PMNB">Payment number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCashMovement(
			string m3CSHD, 
			string m3CSH2, 
			string m3CUCD, 
			DateTime m3PYDT, 
			decimal m3PMAM, 
			int? m3PMNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCashMovement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CSHD))
				throw new ArgumentNullException(nameof(m3CSHD));
			if (string.IsNullOrWhiteSpace(m3CSH2))
				throw new ArgumentNullException(nameof(m3CSH2));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("CSHD", m3CSHD.Trim())
				.WithQueryParameter("CSH2", m3CSH2.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("PYDT", m3PYDT.ToM3String())
				.WithQueryParameter("PMAM", m3PMAM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3PMNB.HasValue)
				request.WithQueryParameter("PMNB", m3PMNB.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddCreateCheck
		/// Description Create check and perform a validation
		/// Version Release: 
		/// </summary>
		/// <param name="m3PMNB">Payment number (Required)</param>
		/// <param name="m3CSHD">Cash desk (Required)</param>
		/// <param name="m3PYNO">Payer (Required)</param>
		/// <param name="m3PYDT">Payment date (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3ACDT">Accounting date (Required)</param>
		/// <param name="m3CKNO">Check number (Required)</param>
		/// <param name="m3PYCD">Payment method - accounts receivable</param>
		/// <param name="m3ADR1">Address line 1</param>
		/// <param name="m3ADR2">Address line 2</param>
		/// <param name="m3ADR3">Address line 3</param>
		/// <param name="m3ADR4">Address line 4</param>
		/// <param name="m3TX01">Text line  1</param>
		/// <param name="m3TX02">Text line  2</param>
		/// <param name="m3PRCX">Print receipt</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCreateCheck(
			int m3PMNB, 
			string m3CSHD, 
			string m3PYNO, 
			DateTime m3PYDT, 
			string m3CUCD, 
			DateTime m3ACDT, 
			string m3CKNO, 
			string m3PYCD = null, 
			string m3ADR1 = null, 
			string m3ADR2 = null, 
			string m3ADR3 = null, 
			string m3ADR4 = null, 
			string m3TX01 = null, 
			string m3TX02 = null, 
			int? m3PRCX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCreateCheck",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CSHD))
				throw new ArgumentNullException(nameof(m3CSHD));
			if (string.IsNullOrWhiteSpace(m3PYNO))
				throw new ArgumentNullException(nameof(m3PYNO));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3CKNO))
				throw new ArgumentNullException(nameof(m3CKNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PMNB", m3PMNB.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CSHD", m3CSHD.Trim())
				.WithQueryParameter("PYNO", m3PYNO.Trim())
				.WithQueryParameter("PYDT", m3PYDT.ToM3String())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("ACDT", m3ACDT.ToM3String())
				.WithQueryParameter("CKNO", m3CKNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PYCD))
				request.WithQueryParameter("PYCD", m3PYCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR1))
				request.WithQueryParameter("ADR1", m3ADR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR2))
				request.WithQueryParameter("ADR2", m3ADR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR3))
				request.WithQueryParameter("ADR3", m3ADR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR4))
				request.WithQueryParameter("ADR4", m3ADR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX01))
				request.WithQueryParameter("TX01", m3TX01.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX02))
				request.WithQueryParameter("TX02", m3TX02.Trim());
			if (m3PRCX.HasValue)
				request.WithQueryParameter("PRCX", m3PRCX.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddInvoice
		/// Description Add invoice
		/// Version Release: 
		/// </summary>
		/// <param name="m3PMNB">Payment number (Required)</param>
		/// <param name="m3CSHD">Cash desk (Required)</param>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3EXIN">Extended invoice number (Required)</param>
		/// <param name="m3PYNO">Payer (Required)</param>
		/// <param name="m3PYCD">Payment method - accounts receivable (Required)</param>
		/// <param name="m3PYDT">Payment date (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddInvoice(
			int m3PMNB, 
			string m3CSHD, 
			int m3YEA4, 
			string m3EXIN, 
			string m3PYNO, 
			string m3PYCD, 
			DateTime m3PYDT, 
			string m3CUCD, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddInvoice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CSHD))
				throw new ArgumentNullException(nameof(m3CSHD));
			if (string.IsNullOrWhiteSpace(m3EXIN))
				throw new ArgumentNullException(nameof(m3EXIN));
			if (string.IsNullOrWhiteSpace(m3PYNO))
				throw new ArgumentNullException(nameof(m3PYNO));
			if (string.IsNullOrWhiteSpace(m3PYCD))
				throw new ArgumentNullException(nameof(m3PYCD));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("PMNB", m3PMNB.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CSHD", m3CSHD.Trim())
				.WithQueryParameter("YEA4", m3YEA4.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("EXIN", m3EXIN.Trim())
				.WithQueryParameter("PYNO", m3PYNO.Trim())
				.WithQueryParameter("PYCD", m3PYCD.Trim())
				.WithQueryParameter("PYDT", m3PYDT.ToM3String())
				.WithQueryParameter("CUCD", m3CUCD.Trim());

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
		/// Name AddOnAccount
		/// Description Add an on account payment
		/// Version Release: 
		/// </summary>
		/// <param name="m3PMNB">Payment number (Required)</param>
		/// <param name="m3CSHD">Cash desk (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3PYNO">Payer (Required)</param>
		/// <param name="m3PYDT">Payment date (Required)</param>
		/// <param name="m3PMAM">Payment amount - foreign currency (Required)</param>
		/// <param name="m3VTXT">Voucher text (Required)</param>
		/// <param name="m3YEA4">Year</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddOnAccount(
			int m3PMNB, 
			string m3CSHD, 
			string m3CUCD, 
			string m3PYNO, 
			DateTime m3PYDT, 
			decimal m3PMAM, 
			string m3VTXT, 
			int? m3YEA4 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddOnAccount",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CSHD))
				throw new ArgumentNullException(nameof(m3CSHD));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3PYNO))
				throw new ArgumentNullException(nameof(m3PYNO));
			if (string.IsNullOrWhiteSpace(m3VTXT))
				throw new ArgumentNullException(nameof(m3VTXT));

			// Set mandatory parameters
			request
				.WithQueryParameter("PMNB", m3PMNB.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CSHD", m3CSHD.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("PYNO", m3PYNO.Trim())
				.WithQueryParameter("PYDT", m3PYDT.ToM3String())
				.WithQueryParameter("PMAM", m3PMAM.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("VTXT", m3VTXT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3YEA4.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddPayment
		/// Description Add payment
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PMNB">Payment number (Required)</param>
		/// <param name="m3CSHD">Cash desk (Required)</param>
		/// <param name="m3PYNO">Payer (Required)</param>
		/// <param name="m3PYCD">Payment method - accounts receivable (Required)</param>
		/// <param name="m3PYDT">Payment date (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3PMAM">Payment amount - foreign currency (Required)</param>
		/// <param name="m3BKID">Bank account identity</param>
		/// <param name="m3CKNO">Check number</param>
		/// <param name="m3IRNO">Invoice reference number</param>
		/// <param name="m33RDP">3rd-party provider</param>
		/// <param name="m33RDI">3rd-party ID</param>
		/// <param name="m3TRTY">Transaction type</param>
		/// <param name="m3CTPY">Card type</param>
		/// <param name="m3CANU">Card number</param>
		/// <param name="m3NOCA">Name on card</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPayment(
			int m3PMNB, 
			string m3CSHD, 
			string m3PYNO, 
			string m3PYCD, 
			DateTime m3PYDT, 
			string m3CUCD, 
			decimal m3PMAM, 
			string m3BKID = null, 
			string m3CKNO = null, 
			string m3IRNO = null, 
			string m33RDP = null, 
			string m33RDI = null, 
			string m3TRTY = null, 
			string m3CTPY = null, 
			string m3CANU = null, 
			string m3NOCA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPayment",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CSHD))
				throw new ArgumentNullException(nameof(m3CSHD));
			if (string.IsNullOrWhiteSpace(m3PYNO))
				throw new ArgumentNullException(nameof(m3PYNO));
			if (string.IsNullOrWhiteSpace(m3PYCD))
				throw new ArgumentNullException(nameof(m3PYCD));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("PMNB", m3PMNB.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CSHD", m3CSHD.Trim())
				.WithQueryParameter("PYNO", m3PYNO.Trim())
				.WithQueryParameter("PYCD", m3PYCD.Trim())
				.WithQueryParameter("PYDT", m3PYDT.ToM3String())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("PMAM", m3PMAM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BKID))
				request.WithQueryParameter("BKID", m3BKID.Trim());
			if (!string.IsNullOrWhiteSpace(m3CKNO))
				request.WithQueryParameter("CKNO", m3CKNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3IRNO))
				request.WithQueryParameter("IRNO", m3IRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m33RDP))
				request.WithQueryParameter("3RDP", m33RDP.Trim());
			if (!string.IsNullOrWhiteSpace(m33RDI))
				request.WithQueryParameter("3RDI", m33RDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRTY))
				request.WithQueryParameter("TRTY", m3TRTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTPY))
				request.WithQueryParameter("CTPY", m3CTPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3CANU))
				request.WithQueryParameter("CANU", m3CANU.Trim());
			if (!string.IsNullOrWhiteSpace(m3NOCA))
				request.WithQueryParameter("NOCA", m3NOCA.Trim());

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
		/// Name AddPaymentNo
		/// Description Add payment number
		/// Version Release: 
		/// </summary>
		/// <param name="m3CSHD">Cash desk</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPaymentNoResponse></returns>
		/// <exception cref="M3Exception<AddPaymentNoResponse>"></exception>
		public async Task<M3Response<AddPaymentNoResponse>> AddPaymentNo(
			string m3CSHD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPaymentNo",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CSHD))
				request.WithQueryParameter("CSHD", m3CSHD.Trim());

			// Execute the request
			var result = await Execute<AddPaymentNoResponse>(
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
		/// Name AddPettyCash
		/// Description Add a petty cash transaction
		/// Version Release: 
		/// </summary>
		/// <param name="m3CSHD">Cash desk (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3PYNO">Payer (Required)</param>
		/// <param name="m3PYDT">Payment date (Required)</param>
		/// <param name="m3SLOP">Accounting option - payt rcvd variances (Required)</param>
		/// <param name="m3PMAM">Payment amount - foreign currency (Required)</param>
		/// <param name="m3PMNB">Payment number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPettyCash(
			string m3CSHD, 
			string m3CUCD, 
			string m3PYNO, 
			DateTime m3PYDT, 
			int m3SLOP, 
			decimal m3PMAM, 
			int? m3PMNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPettyCash",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CSHD))
				throw new ArgumentNullException(nameof(m3CSHD));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3PYNO))
				throw new ArgumentNullException(nameof(m3PYNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CSHD", m3CSHD.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("PYNO", m3PYNO.Trim())
				.WithQueryParameter("PYDT", m3PYDT.ToM3String())
				.WithQueryParameter("SLOP", m3SLOP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PMAM", m3PMAM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3PMNB.HasValue)
				request.WithQueryParameter("PMNB", m3PMNB.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgHeadValues
		/// Description Change head values
		/// Version Release: 
		/// </summary>
		/// <param name="m3PMNB">Payment number (Required)</param>
		/// <param name="m3CSHD">Cash desk (Required)</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3PYCD">Payment method - accounts receivable</param>
		/// <param name="m3PYDT">Payment date</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ChgHeadValuesResponse></returns>
		/// <exception cref="M3Exception<ChgHeadValuesResponse>"></exception>
		public async Task<M3Response<ChgHeadValuesResponse>> ChgHeadValues(
			int m3PMNB, 
			string m3CSHD, 
			string m3CUCD = null, 
			string m3PYCD = null, 
			DateTime? m3PYDT = null, 
			string m3PYNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgHeadValues",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CSHD))
				throw new ArgumentNullException(nameof(m3CSHD));

			// Set mandatory parameters
			request
				.WithQueryParameter("PMNB", m3PMNB.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CSHD", m3CSHD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYCD))
				request.WithQueryParameter("PYCD", m3PYCD.Trim());
			if (m3PYDT.HasValue)
				request.WithQueryParameter("PYDT", m3PYDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());

			// Execute the request
			var result = await Execute<ChgHeadValuesResponse>(
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
		/// Name DelLine
		/// Description Delete line
		/// Version Release: 
		/// </summary>
		/// <param name="m3PMNB">Payment number (Required)</param>
		/// <param name="m3PLNB">Line number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelLine(
			int m3PMNB, 
			int m3PLNB, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelLine",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PMNB", m3PMNB.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLNB", m3PLNB.ToString(CultureInfo.CurrentCulture));

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
		/// Name EndProgram
		/// Description End program
		/// Version Release: 
		/// </summary>
		/// <param name="m3CSHD">Cash desk (Required)</param>
		/// <param name="m3PMNB">Payment number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> EndProgram(
			string m3CSHD, 
			int? m3PMNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/EndProgram",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CSHD))
				throw new ArgumentNullException(nameof(m3CSHD));

			// Set mandatory parameters
			request
				.WithQueryParameter("CSHD", m3CSHD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3PMNB.HasValue)
				request.WithQueryParameter("PMNB", m3PMNB.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetCrtChkInit
		/// Description Retrieve init of fields for AddCreateCheck
		/// Version Release: 
		/// </summary>
		/// <param name="m3PMNB">Payment number (Required)</param>
		/// <param name="m3CSHD">Cash desk (Required)</param>
		/// <param name="m3PYNO">Payer (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3PYCD">Payment method - accounts receivable</param>
		/// <param name="m3PYDT">Payment date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCrtChkInitResponse></returns>
		/// <exception cref="M3Exception<GetCrtChkInitResponse>"></exception>
		public async Task<M3Response<GetCrtChkInitResponse>> GetCrtChkInit(
			int m3PMNB, 
			string m3CSHD, 
			string m3PYNO, 
			string m3CUCD, 
			string m3PYCD = null, 
			DateTime? m3PYDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetCrtChkInit",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CSHD))
				throw new ArgumentNullException(nameof(m3CSHD));
			if (string.IsNullOrWhiteSpace(m3PYNO))
				throw new ArgumentNullException(nameof(m3PYNO));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("PMNB", m3PMNB.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CSHD", m3CSHD.Trim())
				.WithQueryParameter("PYNO", m3PYNO.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PYCD))
				request.WithQueryParameter("PYCD", m3PYCD.Trim());
			if (m3PYDT.HasValue)
				request.WithQueryParameter("PYDT", m3PYDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetCrtChkInitResponse>(
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
		/// Name GetDetails
		/// Description Get details about a cash desk line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PMNB">Payment number (Required)</param>
		/// <param name="m3PLNB">Line number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDetailsResponse></returns>
		/// <exception cref="M3Exception<GetDetailsResponse>"></exception>
		public async Task<M3Response<GetDetailsResponse>> GetDetails(
			int m3PMNB, 
			int m3PLNB, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDetails",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PMNB", m3PMNB.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLNB", m3PLNB.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetDetailsResponse>(
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
		/// Name GetHeadValues
		/// Description Get head values
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PMNB">Payment number</param>
		/// <param name="m3CSHD">Cash desk</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadValuesResponse></returns>
		/// <exception cref="M3Exception<GetHeadValuesResponse>"></exception>
		public async Task<M3Response<GetHeadValuesResponse>> GetHeadValues(
			int? m3PMNB = null, 
			string m3CSHD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHeadValues",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3PMNB.HasValue)
				request.WithQueryParameter("PMNB", m3PMNB.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CSHD))
				request.WithQueryParameter("CSHD", m3CSHD.Trim());

			// Execute the request
			var result = await Execute<GetHeadValuesResponse>(
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
		/// Name GetParameters
		/// Description Get cash desk parameters
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PMNB">Payment number</param>
		/// <param name="m3CSHD">Cash desk</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetParametersResponse></returns>
		/// <exception cref="M3Exception<GetParametersResponse>"></exception>
		public async Task<M3Response<GetParametersResponse>> GetParameters(
			int? m3PMNB = null, 
			string m3CSHD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetParameters",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3PMNB.HasValue)
				request.WithQueryParameter("PMNB", m3PMNB.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CSHD))
				request.WithQueryParameter("CSHD", m3CSHD.Trim());

			// Execute the request
			var result = await Execute<GetParametersResponse>(
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
		/// Name GetSummary
		/// Description Get summary fields
		/// Version Release: 
		/// </summary>
		/// <param name="m3PMNB">Payment number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSummaryResponse></returns>
		/// <exception cref="M3Exception<GetSummaryResponse>"></exception>
		public async Task<M3Response<GetSummaryResponse>> GetSummary(
			int? m3PMNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSummary",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3PMNB.HasValue)
				request.WithQueryParameter("PMNB", m3PMNB.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetSummaryResponse>(
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
		/// Name LstAccOptions
		/// Description List account options
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAccOptionsResponse></returns>
		/// <exception cref="M3Exception<LstAccOptionsResponse>"></exception>
		public async Task<M3Response<LstAccOptionsResponse>> LstAccOptions(
			string m3DIVI, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAccOptions",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<LstAccOptionsResponse>(
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
		/// Name LstAllInvByPay
		/// Description List all invoices by payer
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PYNO">Payer (Required)</param>
		/// <param name="m3YEA4">Year</param>
		/// <param name="m3INPX">Invoice prefix</param>
		/// <param name="m3IVNO">Invoice number</param>
		/// <param name="m3EXIN">Extended invoice number</param>
		/// <param name="m3OOIN">Only open invoices</param>
		/// <param name="m3NOYE">Number of years</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAllInvByPayResponse></returns>
		/// <exception cref="M3Exception<LstAllInvByPayResponse>"></exception>
		public async Task<M3Response<LstAllInvByPayResponse>> LstAllInvByPay(
			string m3DIVI, 
			string m3PYNO, 
			int? m3YEA4 = null, 
			string m3INPX = null, 
			int? m3IVNO = null, 
			string m3EXIN = null, 
			string m3OOIN = null, 
			int? m3NOYE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAllInvByPay",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PYNO))
				throw new ArgumentNullException(nameof(m3PYNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PYNO", m3PYNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3YEA4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INPX))
				request.WithQueryParameter("INPX", m3INPX.Trim());
			if (m3IVNO.HasValue)
				request.WithQueryParameter("IVNO", m3IVNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EXIN))
				request.WithQueryParameter("EXIN", m3EXIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3OOIN))
				request.WithQueryParameter("OOIN", m3OOIN.Trim());
			if (m3NOYE.HasValue)
				request.WithQueryParameter("NOYE", m3NOYE.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAllInvByPayResponse>(
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
		/// Name LstLineCrCrd
		/// Description List lines
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PMNB">Payment number (Required)</param>
		/// <param name="m3RCVA">Cash received</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineCrCrdResponse></returns>
		/// <exception cref="M3Exception<LstLineCrCrdResponse>"></exception>
		public async Task<M3Response<LstLineCrCrdResponse>> LstLineCrCrd(
			int m3PMNB, 
			decimal? m3RCVA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLineCrCrd",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PMNB", m3PMNB.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3RCVA.HasValue)
				request.WithQueryParameter("RCVA", m3RCVA.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstLineCrCrdResponse>(
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
		/// Name LstLines
		/// Description List lines
		/// Version Release: 
		/// </summary>
		/// <param name="m3PMNB">Payment number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLinesResponse></returns>
		/// <exception cref="M3Exception<LstLinesResponse>"></exception>
		public async Task<M3Response<LstLinesResponse>> LstLines(
			int m3PMNB, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLines",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PMNB", m3PMNB.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstLinesResponse>(
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
		/// Name Reset
		/// Description Reset - deletes all lines
		/// Version Release: 
		/// </summary>
		/// <param name="m3PMNB">Payment number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Reset(
			int m3PMNB, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Reset",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PMNB", m3PMNB.ToString(CultureInfo.CurrentCulture));

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
		/// Name Validate
		/// Description Validate
		/// Version Release: 
		/// </summary>
		/// <param name="m3PMNB">Payment number (Required)</param>
		/// <param name="m3CSHD">Cash desk (Required)</param>
		/// <param name="m3PYNO">Payer (Required)</param>
		/// <param name="m3PYDT">Payment date (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3PYCD">Payment method - accounts receivable</param>
		/// <param name="m3PRCX">Print receipt</param>
		/// <param name="m3PATO">Create payment tolerance</param>
		/// <param name="m3SLOP">Accounting option - payt rcvd variances</param>
		/// <param name="m3PAPA">Create partial payment</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Validate(
			int m3PMNB, 
			string m3CSHD, 
			string m3PYNO, 
			DateTime m3PYDT, 
			string m3CUCD, 
			string m3PYCD = null, 
			int? m3PRCX = null, 
			int? m3PATO = null, 
			int? m3SLOP = null, 
			int? m3PAPA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Validate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CSHD))
				throw new ArgumentNullException(nameof(m3CSHD));
			if (string.IsNullOrWhiteSpace(m3PYNO))
				throw new ArgumentNullException(nameof(m3PYNO));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("PMNB", m3PMNB.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CSHD", m3CSHD.Trim())
				.WithQueryParameter("PYNO", m3PYNO.Trim())
				.WithQueryParameter("PYDT", m3PYDT.ToM3String())
				.WithQueryParameter("CUCD", m3CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PYCD))
				request.WithQueryParameter("PYCD", m3PYCD.Trim());
			if (m3PRCX.HasValue)
				request.WithQueryParameter("PRCX", m3PRCX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PATO.HasValue)
				request.WithQueryParameter("PATO", m3PATO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SLOP.HasValue)
				request.WithQueryParameter("SLOP", m3SLOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PAPA.HasValue)
				request.WithQueryParameter("PAPA", m3PAPA.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ValidateCCData
		/// Description ValidateCCData
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PMNB">Payment number (Required)</param>
		/// <param name="m3CSHD">Cash desk (Required)</param>
		/// <param name="m3PYNO">Payer (Required)</param>
		/// <param name="m3PYDT">Payment date (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3PYCD">Payment method - accounts receivable (Required)</param>
		/// <param name="m3PMAM">Payment amount - foreign currency (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ValidateCCData(
			int m3PMNB, 
			string m3CSHD, 
			string m3PYNO, 
			DateTime m3PYDT, 
			string m3CUCD, 
			string m3PYCD, 
			decimal m3PMAM, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ValidateCCData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CSHD))
				throw new ArgumentNullException(nameof(m3CSHD));
			if (string.IsNullOrWhiteSpace(m3PYNO))
				throw new ArgumentNullException(nameof(m3PYNO));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3PYCD))
				throw new ArgumentNullException(nameof(m3PYCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("PMNB", m3PMNB.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CSHD", m3CSHD.Trim())
				.WithQueryParameter("PYNO", m3PYNO.Trim())
				.WithQueryParameter("PYDT", m3PYDT.ToM3String())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("PYCD", m3PYCD.Trim())
				.WithQueryParameter("PMAM", m3PMAM.ToString(CultureInfo.CurrentCulture));

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
