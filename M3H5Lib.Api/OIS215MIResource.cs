/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_PMNB">Payment number</param>
		/// <param name="m3_IRNO">Invoice reference number</param>
		/// <param name="m3_CCEC">Result</param>
		/// <param name="m3_MSGE">Message text</param>
		/// <param name="m3_MSID">Message ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add3rdpResult(
			int? m3_PMNB = null, 
			string m3_IRNO = null, 
			string m3_CCEC = null, 
			string m3_MSGE = null, 
			string m3_MSID = null, 
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
			if (m3_PMNB.HasValue)
				request.WithQueryParameter("PMNB", m3_PMNB.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_IRNO))
				request.WithQueryParameter("IRNO", m3_IRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CCEC))
				request.WithQueryParameter("CCEC", m3_CCEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSGE))
				request.WithQueryParameter("MSGE", m3_MSGE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSID))
				request.WithQueryParameter("MSID", m3_MSID.Trim());

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
		/// Name AddCashMovement
		/// Description Add cash movement
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CSHD">From Cash desk (Required)</param>
		/// <param name="m3_CSH2">To Cash desk (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_PYDT">Payment date (Required)</param>
		/// <param name="m3_PMAM">Payment amount - foreign currency (Required)</param>
		/// <param name="m3_PMNB">Payment number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCashMovement(
			string m3_CSHD, 
			string m3_CSH2, 
			string m3_CUCD, 
			DateTime m3_PYDT, 
			decimal m3_PMAM, 
			int? m3_PMNB = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CSHD))
				throw new ArgumentNullException("m3_CSHD");
			if (string.IsNullOrWhiteSpace(m3_CSH2))
				throw new ArgumentNullException("m3_CSH2");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("CSHD", m3_CSHD.Trim())
				.WithQueryParameter("CSH2", m3_CSH2.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("PYDT", m3_PYDT.ToM3String())
				.WithQueryParameter("PMAM", m3_PMAM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_PMNB.HasValue)
				request.WithQueryParameter("PMNB", m3_PMNB.Value.ToString());

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
		/// Name AddCreateCheck
		/// Description Create check and perform a validation
		/// Version Release: 
		/// </summary>
		/// <param name="m3_PMNB">Payment number (Required)</param>
		/// <param name="m3_CSHD">Cash desk (Required)</param>
		/// <param name="m3_PYNO">Payer (Required)</param>
		/// <param name="m3_PYDT">Payment date (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_ACDT">Accounting date (Required)</param>
		/// <param name="m3_CKNO">Check number (Required)</param>
		/// <param name="m3_PYCD">Payment method - accounts receivable</param>
		/// <param name="m3_ADR1">Address line 1</param>
		/// <param name="m3_ADR2">Address line 2</param>
		/// <param name="m3_ADR3">Address line 3</param>
		/// <param name="m3_ADR4">Address line 4</param>
		/// <param name="m3_TX01">Text line  1</param>
		/// <param name="m3_TX02">Text line  2</param>
		/// <param name="m3_PRCX">Print receipt</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCreateCheck(
			int m3_PMNB, 
			string m3_CSHD, 
			string m3_PYNO, 
			DateTime m3_PYDT, 
			string m3_CUCD, 
			DateTime m3_ACDT, 
			string m3_CKNO, 
			string m3_PYCD = null, 
			string m3_ADR1 = null, 
			string m3_ADR2 = null, 
			string m3_ADR3 = null, 
			string m3_ADR4 = null, 
			string m3_TX01 = null, 
			string m3_TX02 = null, 
			int? m3_PRCX = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CSHD))
				throw new ArgumentNullException("m3_CSHD");
			if (string.IsNullOrWhiteSpace(m3_PYNO))
				throw new ArgumentNullException("m3_PYNO");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_CKNO))
				throw new ArgumentNullException("m3_CKNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PMNB", m3_PMNB.ToString())
				.WithQueryParameter("CSHD", m3_CSHD.Trim())
				.WithQueryParameter("PYNO", m3_PYNO.Trim())
				.WithQueryParameter("PYDT", m3_PYDT.ToM3String())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("ACDT", m3_ACDT.ToM3String())
				.WithQueryParameter("CKNO", m3_CKNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PYCD))
				request.WithQueryParameter("PYCD", m3_PYCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR1))
				request.WithQueryParameter("ADR1", m3_ADR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR2))
				request.WithQueryParameter("ADR2", m3_ADR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR3))
				request.WithQueryParameter("ADR3", m3_ADR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR4))
				request.WithQueryParameter("ADR4", m3_ADR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX01))
				request.WithQueryParameter("TX01", m3_TX01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX02))
				request.WithQueryParameter("TX02", m3_TX02.Trim());
			if (m3_PRCX.HasValue)
				request.WithQueryParameter("PRCX", m3_PRCX.Value.ToString());

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
		/// Name AddInvoice
		/// Description Add invoice
		/// Version Release: 
		/// </summary>
		/// <param name="m3_PMNB">Payment number (Required)</param>
		/// <param name="m3_CSHD">Cash desk (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_EXIN">Extended invoice number (Required)</param>
		/// <param name="m3_PYNO">Payer (Required)</param>
		/// <param name="m3_PYCD">Payment method - accounts receivable (Required)</param>
		/// <param name="m3_PYDT">Payment date (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddInvoice(
			int m3_PMNB, 
			string m3_CSHD, 
			int m3_YEA4, 
			string m3_EXIN, 
			string m3_PYNO, 
			string m3_PYCD, 
			DateTime m3_PYDT, 
			string m3_CUCD, 
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
			if (string.IsNullOrWhiteSpace(m3_CSHD))
				throw new ArgumentNullException("m3_CSHD");
			if (string.IsNullOrWhiteSpace(m3_EXIN))
				throw new ArgumentNullException("m3_EXIN");
			if (string.IsNullOrWhiteSpace(m3_PYNO))
				throw new ArgumentNullException("m3_PYNO");
			if (string.IsNullOrWhiteSpace(m3_PYCD))
				throw new ArgumentNullException("m3_PYCD");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("PMNB", m3_PMNB.ToString())
				.WithQueryParameter("CSHD", m3_CSHD.Trim())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("EXIN", m3_EXIN.Trim())
				.WithQueryParameter("PYNO", m3_PYNO.Trim())
				.WithQueryParameter("PYCD", m3_PYCD.Trim())
				.WithQueryParameter("PYDT", m3_PYDT.ToM3String())
				.WithQueryParameter("CUCD", m3_CUCD.Trim());

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
		/// Name AddOnAccount
		/// Description Add an on account payment
		/// Version Release: 
		/// </summary>
		/// <param name="m3_PMNB">Payment number (Required)</param>
		/// <param name="m3_CSHD">Cash desk (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_PYNO">Payer (Required)</param>
		/// <param name="m3_PYDT">Payment date (Required)</param>
		/// <param name="m3_PMAM">Payment amount - foreign currency (Required)</param>
		/// <param name="m3_VTXT">Voucher text (Required)</param>
		/// <param name="m3_YEA4">Year</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddOnAccount(
			int m3_PMNB, 
			string m3_CSHD, 
			string m3_CUCD, 
			string m3_PYNO, 
			DateTime m3_PYDT, 
			decimal m3_PMAM, 
			string m3_VTXT, 
			int? m3_YEA4 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CSHD))
				throw new ArgumentNullException("m3_CSHD");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_PYNO))
				throw new ArgumentNullException("m3_PYNO");
			if (string.IsNullOrWhiteSpace(m3_VTXT))
				throw new ArgumentNullException("m3_VTXT");

			// Set mandatory parameters
			request
				.WithQueryParameter("PMNB", m3_PMNB.ToString())
				.WithQueryParameter("CSHD", m3_CSHD.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("PYNO", m3_PYNO.Trim())
				.WithQueryParameter("PYDT", m3_PYDT.ToM3String())
				.WithQueryParameter("PMAM", m3_PMAM.ToString())
				.WithQueryParameter("VTXT", m3_VTXT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3_YEA4.Value.ToString());

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
		/// Name AddPayment
		/// Description Add payment
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PMNB">Payment number (Required)</param>
		/// <param name="m3_CSHD">Cash desk (Required)</param>
		/// <param name="m3_PYNO">Payer (Required)</param>
		/// <param name="m3_PYCD">Payment method - accounts receivable (Required)</param>
		/// <param name="m3_PYDT">Payment date (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_PMAM">Payment amount - foreign currency (Required)</param>
		/// <param name="m3_BKID">Bank account identity</param>
		/// <param name="m3_CKNO">Check number</param>
		/// <param name="m3_IRNO">Invoice reference number</param>
		/// <param name="m3_3RDP">3rd-party provider</param>
		/// <param name="m3_3RDI">3rd-party ID</param>
		/// <param name="m3_TRTY">Transaction type</param>
		/// <param name="m3_CTPY">Card type</param>
		/// <param name="m3_CANU">Card number</param>
		/// <param name="m3_NOCA">Name on card</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPayment(
			int m3_PMNB, 
			string m3_CSHD, 
			string m3_PYNO, 
			string m3_PYCD, 
			DateTime m3_PYDT, 
			string m3_CUCD, 
			decimal m3_PMAM, 
			string m3_BKID = null, 
			string m3_CKNO = null, 
			string m3_IRNO = null, 
			string m3_3RDP = null, 
			string m3_3RDI = null, 
			string m3_TRTY = null, 
			string m3_CTPY = null, 
			string m3_CANU = null, 
			string m3_NOCA = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CSHD))
				throw new ArgumentNullException("m3_CSHD");
			if (string.IsNullOrWhiteSpace(m3_PYNO))
				throw new ArgumentNullException("m3_PYNO");
			if (string.IsNullOrWhiteSpace(m3_PYCD))
				throw new ArgumentNullException("m3_PYCD");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("PMNB", m3_PMNB.ToString())
				.WithQueryParameter("CSHD", m3_CSHD.Trim())
				.WithQueryParameter("PYNO", m3_PYNO.Trim())
				.WithQueryParameter("PYCD", m3_PYCD.Trim())
				.WithQueryParameter("PYDT", m3_PYDT.ToM3String())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("PMAM", m3_PMAM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BKID))
				request.WithQueryParameter("BKID", m3_BKID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CKNO))
				request.WithQueryParameter("CKNO", m3_CKNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IRNO))
				request.WithQueryParameter("IRNO", m3_IRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_3RDP))
				request.WithQueryParameter("3RDP", m3_3RDP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_3RDI))
				request.WithQueryParameter("3RDI", m3_3RDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRTY))
				request.WithQueryParameter("TRTY", m3_TRTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTPY))
				request.WithQueryParameter("CTPY", m3_CTPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CANU))
				request.WithQueryParameter("CANU", m3_CANU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NOCA))
				request.WithQueryParameter("NOCA", m3_NOCA.Trim());

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
		/// Name AddPaymentNo
		/// Description Add payment number
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CSHD">Cash desk</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPaymentNoResponse></returns>
		/// <exception cref="M3Exception<AddPaymentNoResponse>"></exception>
		public async Task<M3Response<AddPaymentNoResponse>> AddPaymentNo(
			string m3_CSHD = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_CSHD))
				request.WithQueryParameter("CSHD", m3_CSHD.Trim());

			// Execute the request
			var result = await Execute<AddPaymentNoResponse>(
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
		/// Name AddPettyCash
		/// Description Add a petty cash transaction
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CSHD">Cash desk (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_PYNO">Payer (Required)</param>
		/// <param name="m3_PYDT">Payment date (Required)</param>
		/// <param name="m3_SLOP">Accounting option - payt rcvd variances (Required)</param>
		/// <param name="m3_PMAM">Payment amount - foreign currency (Required)</param>
		/// <param name="m3_PMNB">Payment number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPettyCash(
			string m3_CSHD, 
			string m3_CUCD, 
			string m3_PYNO, 
			DateTime m3_PYDT, 
			int m3_SLOP, 
			decimal m3_PMAM, 
			int? m3_PMNB = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CSHD))
				throw new ArgumentNullException("m3_CSHD");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_PYNO))
				throw new ArgumentNullException("m3_PYNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CSHD", m3_CSHD.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("PYNO", m3_PYNO.Trim())
				.WithQueryParameter("PYDT", m3_PYDT.ToM3String())
				.WithQueryParameter("SLOP", m3_SLOP.ToString())
				.WithQueryParameter("PMAM", m3_PMAM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_PMNB.HasValue)
				request.WithQueryParameter("PMNB", m3_PMNB.Value.ToString());

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
		/// Name ChgHeadValues
		/// Description Change head values
		/// Version Release: 
		/// </summary>
		/// <param name="m3_PMNB">Payment number (Required)</param>
		/// <param name="m3_CSHD">Cash desk (Required)</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_PYCD">Payment method - accounts receivable</param>
		/// <param name="m3_PYDT">Payment date</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ChgHeadValuesResponse></returns>
		/// <exception cref="M3Exception<ChgHeadValuesResponse>"></exception>
		public async Task<M3Response<ChgHeadValuesResponse>> ChgHeadValues(
			int m3_PMNB, 
			string m3_CSHD, 
			string m3_CUCD = null, 
			string m3_PYCD = null, 
			DateTime? m3_PYDT = null, 
			string m3_PYNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CSHD))
				throw new ArgumentNullException("m3_CSHD");

			// Set mandatory parameters
			request
				.WithQueryParameter("PMNB", m3_PMNB.ToString())
				.WithQueryParameter("CSHD", m3_CSHD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYCD))
				request.WithQueryParameter("PYCD", m3_PYCD.Trim());
			if (m3_PYDT.HasValue)
				request.WithQueryParameter("PYDT", m3_PYDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());

			// Execute the request
			var result = await Execute<ChgHeadValuesResponse>(
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
		/// Name DelLine
		/// Description Delete line
		/// Version Release: 
		/// </summary>
		/// <param name="m3_PMNB">Payment number (Required)</param>
		/// <param name="m3_PLNB">Line number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelLine(
			int m3_PMNB, 
			int m3_PLNB, 
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
				.WithQueryParameter("PMNB", m3_PMNB.ToString())
				.WithQueryParameter("PLNB", m3_PLNB.ToString());

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
		/// Name EndProgram
		/// Description End program
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CSHD">Cash desk (Required)</param>
		/// <param name="m3_PMNB">Payment number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> EndProgram(
			string m3_CSHD, 
			int? m3_PMNB = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CSHD))
				throw new ArgumentNullException("m3_CSHD");

			// Set mandatory parameters
			request
				.WithQueryParameter("CSHD", m3_CSHD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_PMNB.HasValue)
				request.WithQueryParameter("PMNB", m3_PMNB.Value.ToString());

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
		/// Name GetCrtChkInit
		/// Description Retrieve init of fields for AddCreateCheck
		/// Version Release: 
		/// </summary>
		/// <param name="m3_PMNB">Payment number (Required)</param>
		/// <param name="m3_CSHD">Cash desk (Required)</param>
		/// <param name="m3_PYNO">Payer (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_PYCD">Payment method - accounts receivable</param>
		/// <param name="m3_PYDT">Payment date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCrtChkInitResponse></returns>
		/// <exception cref="M3Exception<GetCrtChkInitResponse>"></exception>
		public async Task<M3Response<GetCrtChkInitResponse>> GetCrtChkInit(
			int m3_PMNB, 
			string m3_CSHD, 
			string m3_PYNO, 
			string m3_CUCD, 
			string m3_PYCD = null, 
			DateTime? m3_PYDT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CSHD))
				throw new ArgumentNullException("m3_CSHD");
			if (string.IsNullOrWhiteSpace(m3_PYNO))
				throw new ArgumentNullException("m3_PYNO");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("PMNB", m3_PMNB.ToString())
				.WithQueryParameter("CSHD", m3_CSHD.Trim())
				.WithQueryParameter("PYNO", m3_PYNO.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PYCD))
				request.WithQueryParameter("PYCD", m3_PYCD.Trim());
			if (m3_PYDT.HasValue)
				request.WithQueryParameter("PYDT", m3_PYDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetCrtChkInitResponse>(
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
		/// Name GetDetails
		/// Description Get details about a cash desk line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PMNB">Payment number (Required)</param>
		/// <param name="m3_PLNB">Line number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDetailsResponse></returns>
		/// <exception cref="M3Exception<GetDetailsResponse>"></exception>
		public async Task<M3Response<GetDetailsResponse>> GetDetails(
			int m3_PMNB, 
			int m3_PLNB, 
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
				.WithQueryParameter("PMNB", m3_PMNB.ToString())
				.WithQueryParameter("PLNB", m3_PLNB.ToString());

			// Execute the request
			var result = await Execute<GetDetailsResponse>(
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
		/// Name GetHeadValues
		/// Description Get head values
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PMNB">Payment number</param>
		/// <param name="m3_CSHD">Cash desk</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadValuesResponse></returns>
		/// <exception cref="M3Exception<GetHeadValuesResponse>"></exception>
		public async Task<M3Response<GetHeadValuesResponse>> GetHeadValues(
			int? m3_PMNB = null, 
			string m3_CSHD = null, 
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
			if (m3_PMNB.HasValue)
				request.WithQueryParameter("PMNB", m3_PMNB.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CSHD))
				request.WithQueryParameter("CSHD", m3_CSHD.Trim());

			// Execute the request
			var result = await Execute<GetHeadValuesResponse>(
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
		/// Name GetParameters
		/// Description Get cash desk parameters
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PMNB">Payment number</param>
		/// <param name="m3_CSHD">Cash desk</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetParametersResponse></returns>
		/// <exception cref="M3Exception<GetParametersResponse>"></exception>
		public async Task<M3Response<GetParametersResponse>> GetParameters(
			int? m3_PMNB = null, 
			string m3_CSHD = null, 
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
			if (m3_PMNB.HasValue)
				request.WithQueryParameter("PMNB", m3_PMNB.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CSHD))
				request.WithQueryParameter("CSHD", m3_CSHD.Trim());

			// Execute the request
			var result = await Execute<GetParametersResponse>(
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
		/// Name GetSummary
		/// Description Get summary fields
		/// Version Release: 
		/// </summary>
		/// <param name="m3_PMNB">Payment number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSummaryResponse></returns>
		/// <exception cref="M3Exception<GetSummaryResponse>"></exception>
		public async Task<M3Response<GetSummaryResponse>> GetSummary(
			int? m3_PMNB = null, 
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
			if (m3_PMNB.HasValue)
				request.WithQueryParameter("PMNB", m3_PMNB.Value.ToString());

			// Execute the request
			var result = await Execute<GetSummaryResponse>(
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
		/// Name LstAccOptions
		/// Description List account options
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAccOptionsResponse></returns>
		/// <exception cref="M3Exception<LstAccOptionsResponse>"></exception>
		public async Task<M3Response<LstAccOptionsResponse>> LstAccOptions(
			string m3_DIVI, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstAccOptionsResponse>(
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
		/// Name LstAllInvByPay
		/// Description List all invoices by payer
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PYNO">Payer (Required)</param>
		/// <param name="m3_YEA4">Year</param>
		/// <param name="m3_INPX">Invoice prefix</param>
		/// <param name="m3_IVNO">Invoice number</param>
		/// <param name="m3_EXIN">Extended invoice number</param>
		/// <param name="m3_OOIN">Only open invoices</param>
		/// <param name="m3_NOYE">Number of years</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAllInvByPayResponse></returns>
		/// <exception cref="M3Exception<LstAllInvByPayResponse>"></exception>
		public async Task<M3Response<LstAllInvByPayResponse>> LstAllInvByPay(
			string m3_DIVI, 
			string m3_PYNO, 
			int? m3_YEA4 = null, 
			string m3_INPX = null, 
			int? m3_IVNO = null, 
			string m3_EXIN = null, 
			string m3_OOIN = null, 
			int? m3_NOYE = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PYNO))
				throw new ArgumentNullException("m3_PYNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PYNO", m3_PYNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3_YEA4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INPX))
				request.WithQueryParameter("INPX", m3_INPX.Trim());
			if (m3_IVNO.HasValue)
				request.WithQueryParameter("IVNO", m3_IVNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EXIN))
				request.WithQueryParameter("EXIN", m3_EXIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OOIN))
				request.WithQueryParameter("OOIN", m3_OOIN.Trim());
			if (m3_NOYE.HasValue)
				request.WithQueryParameter("NOYE", m3_NOYE.Value.ToString());

			// Execute the request
			var result = await Execute<LstAllInvByPayResponse>(
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
		/// Name LstLineCrCrd
		/// Description List lines
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PMNB">Payment number (Required)</param>
		/// <param name="m3_RCVA">Cash received</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineCrCrdResponse></returns>
		/// <exception cref="M3Exception<LstLineCrCrdResponse>"></exception>
		public async Task<M3Response<LstLineCrCrdResponse>> LstLineCrCrd(
			int m3_PMNB, 
			decimal? m3_RCVA = null, 
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
				.WithQueryParameter("PMNB", m3_PMNB.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RCVA.HasValue)
				request.WithQueryParameter("RCVA", m3_RCVA.Value.ToString());

			// Execute the request
			var result = await Execute<LstLineCrCrdResponse>(
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
		/// Name LstLines
		/// Description List lines
		/// Version Release: 
		/// </summary>
		/// <param name="m3_PMNB">Payment number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLinesResponse></returns>
		/// <exception cref="M3Exception<LstLinesResponse>"></exception>
		public async Task<M3Response<LstLinesResponse>> LstLines(
			int m3_PMNB, 
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
				.WithQueryParameter("PMNB", m3_PMNB.ToString());

			// Execute the request
			var result = await Execute<LstLinesResponse>(
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
		/// Name Reset
		/// Description Reset - deletes all lines
		/// Version Release: 
		/// </summary>
		/// <param name="m3_PMNB">Payment number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Reset(
			int m3_PMNB, 
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
				.WithQueryParameter("PMNB", m3_PMNB.ToString());

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
		/// Name Validate
		/// Description Validate
		/// Version Release: 
		/// </summary>
		/// <param name="m3_PMNB">Payment number (Required)</param>
		/// <param name="m3_CSHD">Cash desk (Required)</param>
		/// <param name="m3_PYNO">Payer (Required)</param>
		/// <param name="m3_PYDT">Payment date (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_PYCD">Payment method - accounts receivable</param>
		/// <param name="m3_PRCX">Print receipt</param>
		/// <param name="m3_PATO">Create payment tolerance</param>
		/// <param name="m3_SLOP">Accounting option - payt rcvd variances</param>
		/// <param name="m3_PAPA">Create partial payment</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Validate(
			int m3_PMNB, 
			string m3_CSHD, 
			string m3_PYNO, 
			DateTime m3_PYDT, 
			string m3_CUCD, 
			string m3_PYCD = null, 
			int? m3_PRCX = null, 
			int? m3_PATO = null, 
			int? m3_SLOP = null, 
			int? m3_PAPA = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CSHD))
				throw new ArgumentNullException("m3_CSHD");
			if (string.IsNullOrWhiteSpace(m3_PYNO))
				throw new ArgumentNullException("m3_PYNO");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("PMNB", m3_PMNB.ToString())
				.WithQueryParameter("CSHD", m3_CSHD.Trim())
				.WithQueryParameter("PYNO", m3_PYNO.Trim())
				.WithQueryParameter("PYDT", m3_PYDT.ToM3String())
				.WithQueryParameter("CUCD", m3_CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PYCD))
				request.WithQueryParameter("PYCD", m3_PYCD.Trim());
			if (m3_PRCX.HasValue)
				request.WithQueryParameter("PRCX", m3_PRCX.Value.ToString());
			if (m3_PATO.HasValue)
				request.WithQueryParameter("PATO", m3_PATO.Value.ToString());
			if (m3_SLOP.HasValue)
				request.WithQueryParameter("SLOP", m3_SLOP.Value.ToString());
			if (m3_PAPA.HasValue)
				request.WithQueryParameter("PAPA", m3_PAPA.Value.ToString());

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
		/// Name ValidateCCData
		/// Description ValidateCCData
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PMNB">Payment number (Required)</param>
		/// <param name="m3_CSHD">Cash desk (Required)</param>
		/// <param name="m3_PYNO">Payer (Required)</param>
		/// <param name="m3_PYDT">Payment date (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_PYCD">Payment method - accounts receivable (Required)</param>
		/// <param name="m3_PMAM">Payment amount - foreign currency (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ValidateCCData(
			int m3_PMNB, 
			string m3_CSHD, 
			string m3_PYNO, 
			DateTime m3_PYDT, 
			string m3_CUCD, 
			string m3_PYCD, 
			decimal m3_PMAM, 
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
			if (string.IsNullOrWhiteSpace(m3_CSHD))
				throw new ArgumentNullException("m3_CSHD");
			if (string.IsNullOrWhiteSpace(m3_PYNO))
				throw new ArgumentNullException("m3_PYNO");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_PYCD))
				throw new ArgumentNullException("m3_PYCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("PMNB", m3_PMNB.ToString())
				.WithQueryParameter("CSHD", m3_CSHD.Trim())
				.WithQueryParameter("PYNO", m3_PYNO.Trim())
				.WithQueryParameter("PYDT", m3_PYDT.ToM3String())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("PYCD", m3_PYCD.Trim())
				.WithQueryParameter("PMAM", m3_PMAM.ToString());

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
