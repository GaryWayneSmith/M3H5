/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.CRCCINMI;
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
	/// Name: CRCCINMI
	/// Component Name: CreditCards
	/// Description: Credit Card Interface
	/// Version Release: 5ea0
	///</summary>
	public partial class CRCCINMIResource : M3BaseResourceEndpoint
	{
		public CRCCINMIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRCCINMI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAuth
		/// Description Add authorization
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3CINO">Invoice number</param>
		/// <param name="m3YEA4">Year</param>
		/// <param name="m3CCAA">Credit card authorization amount</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3CANU">Credit card account number</param>
		/// <param name="m3EXP0">Expiration date</param>
		/// <param name="m3CTPY">Card type</param>
		/// <param name="m3CSC1">Card sequrity code</param>
		/// <param name="m3NREF">Reference number</param>
		/// <param name="m3TRDP">3rd party provider</param>
		/// <param name="m3AUTH">Voice authorization code</param>
		/// <param name="m3CUNM">Customer name</param>
		/// <param name="m3CUA1">Customer address 1</param>
		/// <param name="m3PONO">ZIPcode</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3COM1">Message text</param>
		/// <param name="m3COM2">Message text</param>
		/// <param name="m3CUN1">Customer name</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="m3NOCA">Name on card</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddAuthResponse></returns>
		/// <exception cref="M3Exception<AddAuthResponse>"></exception>
		public async Task<M3Response<AddAuthResponse>> AddAuth(
			int? m3CONO = null, 
			string m3DIVI = null, 
			int? m3RORC = null, 
			string m3CINO = null, 
			int? m3YEA4 = null, 
			decimal? m3CCAA = null, 
			string m3CUCD = null, 
			string m3CANU = null, 
			string m3EXP0 = null, 
			string m3CTPY = null, 
			string m3CSC1 = null, 
			string m3NREF = null, 
			string m3TRDP = null, 
			string m3AUTH = null, 
			string m3CUNM = null, 
			string m3CUA1 = null, 
			string m3PONO = null, 
			string m3TOWN = null, 
			string m3CSCD = null, 
			string m3ECAR = null, 
			string m3PHNO = null, 
			string m3COM1 = null, 
			string m3COM2 = null, 
			string m3CUN1 = null, 
			string m3FRCO = null, 
			string m3NOCA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddAuth",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CINO))
				request.WithQueryParameter("CINO", m3CINO.Trim());
			if (m3YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3YEA4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CCAA.HasValue)
				request.WithQueryParameter("CCAA", m3CCAA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CANU))
				request.WithQueryParameter("CANU", m3CANU.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXP0))
				request.WithQueryParameter("EXP0", m3EXP0.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTPY))
				request.WithQueryParameter("CTPY", m3CTPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSC1))
				request.WithQueryParameter("CSC1", m3CSC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3NREF))
				request.WithQueryParameter("NREF", m3NREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRDP))
				request.WithQueryParameter("TRDP", m3TRDP.Trim());
			if (!string.IsNullOrWhiteSpace(m3AUTH))
				request.WithQueryParameter("AUTH", m3AUTH.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNM))
				request.WithQueryParameter("CUNM", m3CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA1))
				request.WithQueryParameter("CUA1", m3CUA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOWN))
				request.WithQueryParameter("TOWN", m3TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3COM1))
				request.WithQueryParameter("COM1", m3COM1.Trim());
			if (!string.IsNullOrWhiteSpace(m3COM2))
				request.WithQueryParameter("COM2", m3COM2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUN1))
				request.WithQueryParameter("CUN1", m3CUN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRCO))
				request.WithQueryParameter("FRCO", m3FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3NOCA))
				request.WithQueryParameter("NOCA", m3NOCA.Trim());

			// Execute the request
			var result = await Execute<AddAuthResponse>(
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
		/// Name AddCCRefNo
		/// Description Add credit card reference no
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m33RDP">3rd-party provider (Required)</param>
		/// <param name="m3RORC">Reference order category (Required)</param>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3CCEC">Result (Required)</param>
		/// <param name="m3CCAA">Credit card authorization amount (Required)</param>
		/// <param name="m3CANU">Credit card account number (Required)</param>
		/// <param name="m3CTPY">Card type (Required)</param>
		/// <param name="m3STAT">Status (Required)</param>
		/// <param name="m3REFE">Reference (Required)</param>
		/// <param name="m3TRTY">Transaction type (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m33RDI">3rd-party ID (Required)</param>
		/// <param name="m3EXP0">Expiration date</param>
		/// <param name="m3MSG1">Free message ID 1</param>
		/// <param name="m3MSG2">Free message ID 2</param>
		/// <param name="m3CPCT">Type of corporate purchase card</param>
		/// <param name="m3NOCA">Name on card</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddCCRefNoResponse></returns>
		/// <exception cref="M3Exception<AddCCRefNoResponse>"></exception>
		public async Task<M3Response<AddCCRefNoResponse>> AddCCRefNo(
			string m3DIVI, 
			string m33RDP, 
			int m3RORC, 
			string m3ORNO, 
			string m3CCEC, 
			decimal m3CCAA, 
			string m3CANU, 
			string m3CTPY, 
			string m3STAT, 
			string m3REFE, 
			string m3TRTY, 
			string m3CUCD, 
			string m33RDI, 
			string m3EXP0 = null, 
			string m3MSG1 = null, 
			string m3MSG2 = null, 
			string m3CPCT = null, 
			string m3NOCA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddCCRefNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m33RDP))
				throw new ArgumentNullException(nameof(m33RDP));
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3CCEC))
				throw new ArgumentNullException(nameof(m3CCEC));
			if (string.IsNullOrWhiteSpace(m3CANU))
				throw new ArgumentNullException(nameof(m3CANU));
			if (string.IsNullOrWhiteSpace(m3CTPY))
				throw new ArgumentNullException(nameof(m3CTPY));
			if (string.IsNullOrWhiteSpace(m3STAT))
				throw new ArgumentNullException(nameof(m3STAT));
			if (string.IsNullOrWhiteSpace(m3REFE))
				throw new ArgumentNullException(nameof(m3REFE));
			if (string.IsNullOrWhiteSpace(m3TRTY))
				throw new ArgumentNullException(nameof(m3TRTY));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m33RDI))
				throw new ArgumentNullException(nameof(m33RDI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("3RDP", m33RDP.Trim())
				.WithQueryParameter("RORC", m3RORC.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("CCEC", m3CCEC.Trim())
				.WithQueryParameter("CCAA", m3CCAA.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CANU", m3CANU.Trim())
				.WithQueryParameter("CTPY", m3CTPY.Trim())
				.WithQueryParameter("STAT", m3STAT.Trim())
				.WithQueryParameter("REFE", m3REFE.Trim())
				.WithQueryParameter("TRTY", m3TRTY.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("3RDI", m33RDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EXP0))
				request.WithQueryParameter("EXP0", m3EXP0.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSG1))
				request.WithQueryParameter("MSG1", m3MSG1.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSG2))
				request.WithQueryParameter("MSG2", m3MSG2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CPCT))
				request.WithQueryParameter("CPCT", m3CPCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3NOCA))
				request.WithQueryParameter("NOCA", m3NOCA.Trim());

			// Execute the request
			var result = await Execute<AddCCRefNoResponse>(
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
		/// Name AddCapture
		/// Description Add a transaction for delayed capture
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3CINO">Invoice number</param>
		/// <param name="m3YEA4">Year</param>
		/// <param name="m3CCAA">Credit card authorization amount</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3NREF">Reference number</param>
		/// <param name="m3TRDP">3rd party provider</param>
		/// <param name="m3CUNM">Customer name</param>
		/// <param name="m3CUA1">Customer address 1</param>
		/// <param name="m3PONO">ZIPcode</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3COM1">Message text</param>
		/// <param name="m3COM2">Message text</param>
		/// <param name="m3CUN1">Customer name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddCaptureResponse></returns>
		/// <exception cref="M3Exception<AddCaptureResponse>"></exception>
		public async Task<M3Response<AddCaptureResponse>> AddCapture(
			int? m3CONO = null, 
			string m3DIVI = null, 
			int? m3RORC = null, 
			string m3CINO = null, 
			int? m3YEA4 = null, 
			decimal? m3CCAA = null, 
			string m3CUCD = null, 
			string m3NREF = null, 
			string m3TRDP = null, 
			string m3CUNM = null, 
			string m3CUA1 = null, 
			string m3PONO = null, 
			string m3TOWN = null, 
			string m3PHNO = null, 
			string m3COM1 = null, 
			string m3COM2 = null, 
			string m3CUN1 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddCapture",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CINO))
				request.WithQueryParameter("CINO", m3CINO.Trim());
			if (m3YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3YEA4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CCAA.HasValue)
				request.WithQueryParameter("CCAA", m3CCAA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3NREF))
				request.WithQueryParameter("NREF", m3NREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRDP))
				request.WithQueryParameter("TRDP", m3TRDP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNM))
				request.WithQueryParameter("CUNM", m3CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA1))
				request.WithQueryParameter("CUA1", m3CUA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOWN))
				request.WithQueryParameter("TOWN", m3TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3COM1))
				request.WithQueryParameter("COM1", m3COM1.Trim());
			if (!string.IsNullOrWhiteSpace(m3COM2))
				request.WithQueryParameter("COM2", m3COM2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUN1))
				request.WithQueryParameter("CUN1", m3CUN1.Trim());

			// Execute the request
			var result = await Execute<AddCaptureResponse>(
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
		/// Name AddCredit
		/// Description Add credit transactions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3CINO">Invoice number</param>
		/// <param name="m3YEA4">Year</param>
		/// <param name="m3CCAA">Credit card authorization amount</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3CANU">Credit card account number</param>
		/// <param name="m3EXP0">Expiration date</param>
		/// <param name="m3TRDP">3rd party provider</param>
		/// <param name="m3NREF">Reference number</param>
		/// <param name="m3CTPY">Card type</param>
		/// <param name="m3CSC1">Card sequrity code</param>
		/// <param name="m3CUNM">Customer name</param>
		/// <param name="m3CUA1">Customer address 1</param>
		/// <param name="m3PONO">ZIPcode</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3COM1">Message text</param>
		/// <param name="m3COM2">Message text</param>
		/// <param name="m3CUN1">Customer name</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="m3NOCA">Name on card</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddCreditResponse></returns>
		/// <exception cref="M3Exception<AddCreditResponse>"></exception>
		public async Task<M3Response<AddCreditResponse>> AddCredit(
			int? m3CONO = null, 
			string m3DIVI = null, 
			int? m3RORC = null, 
			string m3CINO = null, 
			int? m3YEA4 = null, 
			decimal? m3CCAA = null, 
			string m3CUCD = null, 
			string m3CANU = null, 
			string m3EXP0 = null, 
			string m3TRDP = null, 
			string m3NREF = null, 
			string m3CTPY = null, 
			string m3CSC1 = null, 
			string m3CUNM = null, 
			string m3CUA1 = null, 
			string m3PONO = null, 
			string m3TOWN = null, 
			string m3ECAR = null, 
			string m3CSCD = null, 
			string m3PHNO = null, 
			string m3COM1 = null, 
			string m3COM2 = null, 
			string m3CUN1 = null, 
			string m3FRCO = null, 
			string m3NOCA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddCredit",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CINO))
				request.WithQueryParameter("CINO", m3CINO.Trim());
			if (m3YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3YEA4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CCAA.HasValue)
				request.WithQueryParameter("CCAA", m3CCAA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CANU))
				request.WithQueryParameter("CANU", m3CANU.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXP0))
				request.WithQueryParameter("EXP0", m3EXP0.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRDP))
				request.WithQueryParameter("TRDP", m3TRDP.Trim());
			if (!string.IsNullOrWhiteSpace(m3NREF))
				request.WithQueryParameter("NREF", m3NREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTPY))
				request.WithQueryParameter("CTPY", m3CTPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSC1))
				request.WithQueryParameter("CSC1", m3CSC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNM))
				request.WithQueryParameter("CUNM", m3CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA1))
				request.WithQueryParameter("CUA1", m3CUA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOWN))
				request.WithQueryParameter("TOWN", m3TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3COM1))
				request.WithQueryParameter("COM1", m3COM1.Trim());
			if (!string.IsNullOrWhiteSpace(m3COM2))
				request.WithQueryParameter("COM2", m3COM2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUN1))
				request.WithQueryParameter("CUN1", m3CUN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRCO))
				request.WithQueryParameter("FRCO", m3FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3NOCA))
				request.WithQueryParameter("NOCA", m3NOCA.Trim());

			// Execute the request
			var result = await Execute<AddCreditResponse>(
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
		/// Name AddSale
		/// Description Add a sale transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3CINO">Invoice number</param>
		/// <param name="m3YEA4">Year</param>
		/// <param name="m3CCAA">Credit card authorization amount</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3CANU">Credit card account number</param>
		/// <param name="m3EXP0">Expiration date</param>
		/// <param name="m3CTPY">Card type</param>
		/// <param name="m3CSC1">Card sequrity code</param>
		/// <param name="m3NREF">Reference number</param>
		/// <param name="m3TRDP">3rd party provider</param>
		/// <param name="m3AUTH">Voice authorization code</param>
		/// <param name="m3CUNM">Customer name</param>
		/// <param name="m3CUA1">Customer address 1</param>
		/// <param name="m3PONO">ZIPcode</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3COM1">Message text</param>
		/// <param name="m3COM2">Message text</param>
		/// <param name="m3CUN1">Customer name</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="m3NOCA">Name on card</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddSaleResponse></returns>
		/// <exception cref="M3Exception<AddSaleResponse>"></exception>
		public async Task<M3Response<AddSaleResponse>> AddSale(
			int? m3CONO = null, 
			string m3DIVI = null, 
			int? m3RORC = null, 
			string m3CINO = null, 
			int? m3YEA4 = null, 
			decimal? m3CCAA = null, 
			string m3CUCD = null, 
			string m3CANU = null, 
			string m3EXP0 = null, 
			string m3CTPY = null, 
			string m3CSC1 = null, 
			string m3NREF = null, 
			string m3TRDP = null, 
			string m3AUTH = null, 
			string m3CUNM = null, 
			string m3CUA1 = null, 
			string m3PONO = null, 
			string m3TOWN = null, 
			string m3ECAR = null, 
			string m3CSCD = null, 
			string m3PHNO = null, 
			string m3COM1 = null, 
			string m3COM2 = null, 
			string m3CUN1 = null, 
			string m3FRCO = null, 
			string m3NOCA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddSale",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CINO))
				request.WithQueryParameter("CINO", m3CINO.Trim());
			if (m3YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3YEA4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CCAA.HasValue)
				request.WithQueryParameter("CCAA", m3CCAA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CANU))
				request.WithQueryParameter("CANU", m3CANU.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXP0))
				request.WithQueryParameter("EXP0", m3EXP0.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTPY))
				request.WithQueryParameter("CTPY", m3CTPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSC1))
				request.WithQueryParameter("CSC1", m3CSC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3NREF))
				request.WithQueryParameter("NREF", m3NREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRDP))
				request.WithQueryParameter("TRDP", m3TRDP.Trim());
			if (!string.IsNullOrWhiteSpace(m3AUTH))
				request.WithQueryParameter("AUTH", m3AUTH.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNM))
				request.WithQueryParameter("CUNM", m3CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA1))
				request.WithQueryParameter("CUA1", m3CUA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOWN))
				request.WithQueryParameter("TOWN", m3TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3COM1))
				request.WithQueryParameter("COM1", m3COM1.Trim());
			if (!string.IsNullOrWhiteSpace(m3COM2))
				request.WithQueryParameter("COM2", m3COM2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUN1))
				request.WithQueryParameter("CUN1", m3CUN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRCO))
				request.WithQueryParameter("FRCO", m3FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3NOCA))
				request.WithQueryParameter("NOCA", m3NOCA.Trim());

			// Execute the request
			var result = await Execute<AddSaleResponse>(
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
		/// Name AddVoid
		/// Description Add void transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3CINO">Invoice number</param>
		/// <param name="m3YEA4">Year</param>
		/// <param name="m3NREF">Reference number</param>
		/// <param name="m3TRDP">3rd party provider</param>
		/// <param name="m3CUNM">Customer name</param>
		/// <param name="m3CUA1">Customer address 1</param>
		/// <param name="m3PONO">ZIPcode</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3COM1">Message text</param>
		/// <param name="m3COM2">Message text</param>
		/// <param name="m3CUN1">Customer name</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddVoidResponse></returns>
		/// <exception cref="M3Exception<AddVoidResponse>"></exception>
		public async Task<M3Response<AddVoidResponse>> AddVoid(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3CINO = null, 
			int? m3YEA4 = null, 
			string m3NREF = null, 
			string m3TRDP = null, 
			string m3CUNM = null, 
			string m3CUA1 = null, 
			string m3PONO = null, 
			string m3TOWN = null, 
			string m3ECAR = null, 
			string m3CSCD = null, 
			string m3PHNO = null, 
			string m3COM1 = null, 
			string m3COM2 = null, 
			string m3CUN1 = null, 
			string m3FRCO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddVoid",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CINO))
				request.WithQueryParameter("CINO", m3CINO.Trim());
			if (m3YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3YEA4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NREF))
				request.WithQueryParameter("NREF", m3NREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRDP))
				request.WithQueryParameter("TRDP", m3TRDP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNM))
				request.WithQueryParameter("CUNM", m3CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA1))
				request.WithQueryParameter("CUA1", m3CUA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOWN))
				request.WithQueryParameter("TOWN", m3TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3COM1))
				request.WithQueryParameter("COM1", m3COM1.Trim());
			if (!string.IsNullOrWhiteSpace(m3COM2))
				request.WithQueryParameter("COM2", m3COM2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUN1))
				request.WithQueryParameter("CUN1", m3CUN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRCO))
				request.WithQueryParameter("FRCO", m3FRCO.Trim());

			// Execute the request
			var result = await Execute<AddVoidResponse>(
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
		/// Name GetInquiry
		/// Description Make an inquiry about a previous credit card transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3CINO">Invoice number</param>
		/// <param name="m3YEA4">Year</param>
		/// <param name="m3NREF">Reference number</param>
		/// <param name="m3TRDP">3rd party provider</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInquiryResponse></returns>
		/// <exception cref="M3Exception<GetInquiryResponse>"></exception>
		public async Task<M3Response<GetInquiryResponse>> GetInquiry(
			int? m3CONO = null, 
			string m3DIVI = null, 
			int? m3RORC = null, 
			string m3CINO = null, 
			int? m3YEA4 = null, 
			string m3NREF = null, 
			string m3TRDP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetInquiry",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CINO))
				request.WithQueryParameter("CINO", m3CINO.Trim());
			if (m3YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3YEA4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NREF))
				request.WithQueryParameter("NREF", m3NREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRDP))
				request.WithQueryParameter("TRDP", m3TRDP.Trim());

			// Execute the request
			var result = await Execute<GetInquiryResponse>(
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
		/// Name GetValidateInfo
		/// Description Validate credit card
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3CANU">Credit card account number</param>
		/// <param name="m3EXP0">Expiration date</param>
		/// <param name="m3DATE">Entry date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetValidateInfoResponse></returns>
		/// <exception cref="M3Exception<GetValidateInfoResponse>"></exception>
		public async Task<M3Response<GetValidateInfoResponse>> GetValidateInfo(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3CANU = null, 
			string m3EXP0 = null, 
			DateTime? m3DATE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetValidateInfo",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CANU))
				request.WithQueryParameter("CANU", m3CANU.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXP0))
				request.WithQueryParameter("EXP0", m3EXP0.Trim());
			if (m3DATE.HasValue)
				request.WithQueryParameter("DATE", m3DATE.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetValidateInfoResponse>(
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
