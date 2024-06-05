/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAuth
		/// Description Add authorization
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_CINO">Invoice number</param>
		/// <param name="m3_YEA4">Year</param>
		/// <param name="m3_CCAA">Credit card authorization amount</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_CANU">Credit card account number</param>
		/// <param name="m3_EXP0">Expiration date</param>
		/// <param name="m3_CTPY">Card type</param>
		/// <param name="m3_CSC1">Card sequrity code</param>
		/// <param name="m3_NREF">Reference number</param>
		/// <param name="m3_TRDP">3rd party provider</param>
		/// <param name="m3_AUTH">Voice authorization code</param>
		/// <param name="m3_CUNM">Customer name</param>
		/// <param name="m3_CUA1">Customer address 1</param>
		/// <param name="m3_PONO">ZIPcode</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_COM1">Message text</param>
		/// <param name="m3_COM2">Message text</param>
		/// <param name="m3_CUN1">Customer name</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="m3_NOCA">Name on card</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddAuthResponse></returns>
		/// <exception cref="M3Exception<AddAuthResponse>"></exception>
		public async Task<M3Response<AddAuthResponse>> AddAuth(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			int? m3_RORC = null, 
			string m3_CINO = null, 
			int? m3_YEA4 = null, 
			decimal? m3_CCAA = null, 
			string m3_CUCD = null, 
			string m3_CANU = null, 
			string m3_EXP0 = null, 
			string m3_CTPY = null, 
			string m3_CSC1 = null, 
			string m3_NREF = null, 
			string m3_TRDP = null, 
			string m3_AUTH = null, 
			string m3_CUNM = null, 
			string m3_CUA1 = null, 
			string m3_PONO = null, 
			string m3_TOWN = null, 
			string m3_CSCD = null, 
			string m3_ECAR = null, 
			string m3_PHNO = null, 
			string m3_COM1 = null, 
			string m3_COM2 = null, 
			string m3_CUN1 = null, 
			string m3_FRCO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAuth",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CINO))
				request.WithQueryParameter("CINO", m3_CINO.Trim());
			if (m3_YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3_YEA4.Value.ToString());
			if (m3_CCAA.HasValue)
				request.WithQueryParameter("CCAA", m3_CCAA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CANU))
				request.WithQueryParameter("CANU", m3_CANU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXP0))
				request.WithQueryParameter("EXP0", m3_EXP0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTPY))
				request.WithQueryParameter("CTPY", m3_CTPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSC1))
				request.WithQueryParameter("CSC1", m3_CSC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NREF))
				request.WithQueryParameter("NREF", m3_NREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRDP))
				request.WithQueryParameter("TRDP", m3_TRDP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AUTH))
				request.WithQueryParameter("AUTH", m3_AUTH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNM))
				request.WithQueryParameter("CUNM", m3_CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA1))
				request.WithQueryParameter("CUA1", m3_CUA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOWN))
				request.WithQueryParameter("TOWN", m3_TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COM1))
				request.WithQueryParameter("COM1", m3_COM1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COM2))
				request.WithQueryParameter("COM2", m3_COM2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUN1))
				request.WithQueryParameter("CUN1", m3_CUN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRCO))
				request.WithQueryParameter("FRCO", m3_FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NOCA))
				request.WithQueryParameter("NOCA", m3_NOCA.Trim());

			// Execute the request
			var result = await Execute<AddAuthResponse>(
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
		/// Name AddCCRefNo
		/// Description Add credit card reference no
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_3RDP">3rd-party provider (Required)</param>
		/// <param name="m3_RORC">Reference order category (Required)</param>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_CCEC">Result (Required)</param>
		/// <param name="m3_CCAA">Credit card authorization amount (Required)</param>
		/// <param name="m3_CANU">Credit card account number (Required)</param>
		/// <param name="m3_CTPY">Card type (Required)</param>
		/// <param name="m3_STAT">Status (Required)</param>
		/// <param name="m3_REFE">Reference (Required)</param>
		/// <param name="m3_TRTY">Transaction type (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_3RDI">3rd-party ID (Required)</param>
		/// <param name="m3_EXP0">Expiration date</param>
		/// <param name="m3_MSG1">Free message ID 1</param>
		/// <param name="m3_MSG2">Free message ID 2</param>
		/// <param name="m3_CPCT">Type of corporate purchase card</param>
		/// <param name="m3_NOCA">Name on card</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddCCRefNoResponse></returns>
		/// <exception cref="M3Exception<AddCCRefNoResponse>"></exception>
		public async Task<M3Response<AddCCRefNoResponse>> AddCCRefNo(
			string m3_DIVI, 
			string m3_3RDP, 
			int m3_RORC, 
			string m3_ORNO, 
			string m3_CCEC, 
			decimal m3_CCAA, 
			string m3_CANU, 
			string m3_CTPY, 
			string m3_STAT, 
			string m3_REFE, 
			string m3_TRTY, 
			string m3_CUCD, 
			string m3_3RDI, 
			string m3_EXP0 = null, 
			string m3_MSG1 = null, 
			string m3_MSG2 = null, 
			string m3_CPCT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCCRefNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_3RDP))
				throw new ArgumentNullException("m3_3RDP");
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_CCEC))
				throw new ArgumentNullException("m3_CCEC");
			if (string.IsNullOrWhiteSpace(m3_CANU))
				throw new ArgumentNullException("m3_CANU");
			if (string.IsNullOrWhiteSpace(m3_CTPY))
				throw new ArgumentNullException("m3_CTPY");
			if (string.IsNullOrWhiteSpace(m3_STAT))
				throw new ArgumentNullException("m3_STAT");
			if (string.IsNullOrWhiteSpace(m3_REFE))
				throw new ArgumentNullException("m3_REFE");
			if (string.IsNullOrWhiteSpace(m3_TRTY))
				throw new ArgumentNullException("m3_TRTY");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_3RDI))
				throw new ArgumentNullException("m3_3RDI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("3RDP", m3_3RDP.Trim())
				.WithQueryParameter("RORC", m3_RORC.ToString())
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("CCEC", m3_CCEC.Trim())
				.WithQueryParameter("CCAA", m3_CCAA.ToString())
				.WithQueryParameter("CANU", m3_CANU.Trim())
				.WithQueryParameter("CTPY", m3_CTPY.Trim())
				.WithQueryParameter("STAT", m3_STAT.Trim())
				.WithQueryParameter("REFE", m3_REFE.Trim())
				.WithQueryParameter("TRTY", m3_TRTY.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("3RDI", m3_3RDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EXP0))
				request.WithQueryParameter("EXP0", m3_EXP0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSG1))
				request.WithQueryParameter("MSG1", m3_MSG1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSG2))
				request.WithQueryParameter("MSG2", m3_MSG2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CPCT))
				request.WithQueryParameter("CPCT", m3_CPCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NOCA))
				request.WithQueryParameter("NOCA", m3_NOCA.Trim());

			// Execute the request
			var result = await Execute<AddCCRefNoResponse>(
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
		/// Name AddCapture
		/// Description Add a transaction for delayed capture
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_CINO">Invoice number</param>
		/// <param name="m3_YEA4">Year</param>
		/// <param name="m3_CCAA">Credit card authorization amount</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_NREF">Reference number</param>
		/// <param name="m3_TRDP">3rd party provider</param>
		/// <param name="m3_CUNM">Customer name</param>
		/// <param name="m3_CUA1">Customer address 1</param>
		/// <param name="m3_PONO">ZIPcode</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_COM1">Message text</param>
		/// <param name="m3_COM2">Message text</param>
		/// <param name="m3_CUN1">Customer name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddCaptureResponse></returns>
		/// <exception cref="M3Exception<AddCaptureResponse>"></exception>
		public async Task<M3Response<AddCaptureResponse>> AddCapture(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			int? m3_RORC = null, 
			string m3_CINO = null, 
			int? m3_YEA4 = null, 
			decimal? m3_CCAA = null, 
			string m3_CUCD = null, 
			string m3_NREF = null, 
			string m3_TRDP = null, 
			string m3_CUNM = null, 
			string m3_CUA1 = null, 
			string m3_PONO = null, 
			string m3_TOWN = null, 
			string m3_PHNO = null, 
			string m3_COM1 = null, 
			string m3_COM2 = null, 
			string m3_CUN1 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCapture",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CINO))
				request.WithQueryParameter("CINO", m3_CINO.Trim());
			if (m3_YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3_YEA4.Value.ToString());
			if (m3_CCAA.HasValue)
				request.WithQueryParameter("CCAA", m3_CCAA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NREF))
				request.WithQueryParameter("NREF", m3_NREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRDP))
				request.WithQueryParameter("TRDP", m3_TRDP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNM))
				request.WithQueryParameter("CUNM", m3_CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA1))
				request.WithQueryParameter("CUA1", m3_CUA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOWN))
				request.WithQueryParameter("TOWN", m3_TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COM1))
				request.WithQueryParameter("COM1", m3_COM1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COM2))
				request.WithQueryParameter("COM2", m3_COM2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUN1))
				request.WithQueryParameter("CUN1", m3_CUN1.Trim());

			// Execute the request
			var result = await Execute<AddCaptureResponse>(
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
		/// Name AddCredit
		/// Description Add credit transactions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_CINO">Invoice number</param>
		/// <param name="m3_YEA4">Year</param>
		/// <param name="m3_CCAA">Credit card authorization amount</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_CANU">Credit card account number</param>
		/// <param name="m3_EXP0">Expiration date</param>
		/// <param name="m3_TRDP">3rd party provider</param>
		/// <param name="m3_NREF">Reference number</param>
		/// <param name="m3_CTPY">Card type</param>
		/// <param name="m3_CSC1">Card sequrity code</param>
		/// <param name="m3_CUNM">Customer name</param>
		/// <param name="m3_CUA1">Customer address 1</param>
		/// <param name="m3_PONO">ZIPcode</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_COM1">Message text</param>
		/// <param name="m3_COM2">Message text</param>
		/// <param name="m3_CUN1">Customer name</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="m3_NOCA">Name on card</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddCreditResponse></returns>
		/// <exception cref="M3Exception<AddCreditResponse>"></exception>
		public async Task<M3Response<AddCreditResponse>> AddCredit(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			int? m3_RORC = null, 
			string m3_CINO = null, 
			int? m3_YEA4 = null, 
			decimal? m3_CCAA = null, 
			string m3_CUCD = null, 
			string m3_CANU = null, 
			string m3_EXP0 = null, 
			string m3_TRDP = null, 
			string m3_NREF = null, 
			string m3_CTPY = null, 
			string m3_CSC1 = null, 
			string m3_CUNM = null, 
			string m3_CUA1 = null, 
			string m3_PONO = null, 
			string m3_TOWN = null, 
			string m3_ECAR = null, 
			string m3_CSCD = null, 
			string m3_PHNO = null, 
			string m3_COM1 = null, 
			string m3_COM2 = null, 
			string m3_CUN1 = null, 
			string m3_FRCO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCredit",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CINO))
				request.WithQueryParameter("CINO", m3_CINO.Trim());
			if (m3_YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3_YEA4.Value.ToString());
			if (m3_CCAA.HasValue)
				request.WithQueryParameter("CCAA", m3_CCAA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CANU))
				request.WithQueryParameter("CANU", m3_CANU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXP0))
				request.WithQueryParameter("EXP0", m3_EXP0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRDP))
				request.WithQueryParameter("TRDP", m3_TRDP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NREF))
				request.WithQueryParameter("NREF", m3_NREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTPY))
				request.WithQueryParameter("CTPY", m3_CTPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSC1))
				request.WithQueryParameter("CSC1", m3_CSC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNM))
				request.WithQueryParameter("CUNM", m3_CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA1))
				request.WithQueryParameter("CUA1", m3_CUA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOWN))
				request.WithQueryParameter("TOWN", m3_TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COM1))
				request.WithQueryParameter("COM1", m3_COM1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COM2))
				request.WithQueryParameter("COM2", m3_COM2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUN1))
				request.WithQueryParameter("CUN1", m3_CUN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRCO))
				request.WithQueryParameter("FRCO", m3_FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NOCA))
				request.WithQueryParameter("NOCA", m3_NOCA.Trim());

			// Execute the request
			var result = await Execute<AddCreditResponse>(
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
		/// Name AddSale
		/// Description Add a sale transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_CINO">Invoice number</param>
		/// <param name="m3_YEA4">Year</param>
		/// <param name="m3_CCAA">Credit card authorization amount</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_CANU">Credit card account number</param>
		/// <param name="m3_EXP0">Expiration date</param>
		/// <param name="m3_CTPY">Card type</param>
		/// <param name="m3_CSC1">Card sequrity code</param>
		/// <param name="m3_NREF">Reference number</param>
		/// <param name="m3_TRDP">3rd party provider</param>
		/// <param name="m3_AUTH">Voice authorization code</param>
		/// <param name="m3_CUNM">Customer name</param>
		/// <param name="m3_CUA1">Customer address 1</param>
		/// <param name="m3_PONO">ZIPcode</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_COM1">Message text</param>
		/// <param name="m3_COM2">Message text</param>
		/// <param name="m3_CUN1">Customer name</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="m3_NOCA">Name on card</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddSaleResponse></returns>
		/// <exception cref="M3Exception<AddSaleResponse>"></exception>
		public async Task<M3Response<AddSaleResponse>> AddSale(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			int? m3_RORC = null, 
			string m3_CINO = null, 
			int? m3_YEA4 = null, 
			decimal? m3_CCAA = null, 
			string m3_CUCD = null, 
			string m3_CANU = null, 
			string m3_EXP0 = null, 
			string m3_CTPY = null, 
			string m3_CSC1 = null, 
			string m3_NREF = null, 
			string m3_TRDP = null, 
			string m3_AUTH = null, 
			string m3_CUNM = null, 
			string m3_CUA1 = null, 
			string m3_PONO = null, 
			string m3_TOWN = null, 
			string m3_ECAR = null, 
			string m3_CSCD = null, 
			string m3_PHNO = null, 
			string m3_COM1 = null, 
			string m3_COM2 = null, 
			string m3_CUN1 = null, 
			string m3_FRCO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSale",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CINO))
				request.WithQueryParameter("CINO", m3_CINO.Trim());
			if (m3_YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3_YEA4.Value.ToString());
			if (m3_CCAA.HasValue)
				request.WithQueryParameter("CCAA", m3_CCAA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CANU))
				request.WithQueryParameter("CANU", m3_CANU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXP0))
				request.WithQueryParameter("EXP0", m3_EXP0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTPY))
				request.WithQueryParameter("CTPY", m3_CTPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSC1))
				request.WithQueryParameter("CSC1", m3_CSC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NREF))
				request.WithQueryParameter("NREF", m3_NREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRDP))
				request.WithQueryParameter("TRDP", m3_TRDP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AUTH))
				request.WithQueryParameter("AUTH", m3_AUTH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNM))
				request.WithQueryParameter("CUNM", m3_CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA1))
				request.WithQueryParameter("CUA1", m3_CUA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOWN))
				request.WithQueryParameter("TOWN", m3_TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COM1))
				request.WithQueryParameter("COM1", m3_COM1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COM2))
				request.WithQueryParameter("COM2", m3_COM2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUN1))
				request.WithQueryParameter("CUN1", m3_CUN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRCO))
				request.WithQueryParameter("FRCO", m3_FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NOCA))
				request.WithQueryParameter("NOCA", m3_NOCA.Trim());

			// Execute the request
			var result = await Execute<AddSaleResponse>(
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
		/// Name AddVoid
		/// Description Add void transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_CINO">Invoice number</param>
		/// <param name="m3_YEA4">Year</param>
		/// <param name="m3_NREF">Reference number</param>
		/// <param name="m3_TRDP">3rd party provider</param>
		/// <param name="m3_CUNM">Customer name</param>
		/// <param name="m3_CUA1">Customer address 1</param>
		/// <param name="m3_PONO">ZIPcode</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_COM1">Message text</param>
		/// <param name="m3_COM2">Message text</param>
		/// <param name="m3_CUN1">Customer name</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddVoidResponse></returns>
		/// <exception cref="M3Exception<AddVoidResponse>"></exception>
		public async Task<M3Response<AddVoidResponse>> AddVoid(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_CINO = null, 
			int? m3_YEA4 = null, 
			string m3_NREF = null, 
			string m3_TRDP = null, 
			string m3_CUNM = null, 
			string m3_CUA1 = null, 
			string m3_PONO = null, 
			string m3_TOWN = null, 
			string m3_ECAR = null, 
			string m3_CSCD = null, 
			string m3_PHNO = null, 
			string m3_COM1 = null, 
			string m3_COM2 = null, 
			string m3_CUN1 = null, 
			string m3_FRCO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddVoid",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CINO))
				request.WithQueryParameter("CINO", m3_CINO.Trim());
			if (m3_YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3_YEA4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NREF))
				request.WithQueryParameter("NREF", m3_NREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRDP))
				request.WithQueryParameter("TRDP", m3_TRDP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNM))
				request.WithQueryParameter("CUNM", m3_CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA1))
				request.WithQueryParameter("CUA1", m3_CUA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOWN))
				request.WithQueryParameter("TOWN", m3_TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COM1))
				request.WithQueryParameter("COM1", m3_COM1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COM2))
				request.WithQueryParameter("COM2", m3_COM2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUN1))
				request.WithQueryParameter("CUN1", m3_CUN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRCO))
				request.WithQueryParameter("FRCO", m3_FRCO.Trim());

			// Execute the request
			var result = await Execute<AddVoidResponse>(
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
		/// Name GetInquiry
		/// Description Make an inquiry about a previous credit card transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_CINO">Invoice number</param>
		/// <param name="m3_YEA4">Year</param>
		/// <param name="m3_NREF">Reference number</param>
		/// <param name="m3_TRDP">3rd party provider</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInquiryResponse></returns>
		/// <exception cref="M3Exception<GetInquiryResponse>"></exception>
		public async Task<M3Response<GetInquiryResponse>> GetInquiry(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			int? m3_RORC = null, 
			string m3_CINO = null, 
			int? m3_YEA4 = null, 
			string m3_NREF = null, 
			string m3_TRDP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetInquiry",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CINO))
				request.WithQueryParameter("CINO", m3_CINO.Trim());
			if (m3_YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3_YEA4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NREF))
				request.WithQueryParameter("NREF", m3_NREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRDP))
				request.WithQueryParameter("TRDP", m3_TRDP.Trim());

			// Execute the request
			var result = await Execute<GetInquiryResponse>(
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
		/// Name GetValidateInfo
		/// Description Validate credit card
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_CANU">Credit card account number</param>
		/// <param name="m3_EXP0">Expiration date</param>
		/// <param name="m3_DATE">Entry date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetValidateInfoResponse></returns>
		/// <exception cref="M3Exception<GetValidateInfoResponse>"></exception>
		public async Task<M3Response<GetValidateInfoResponse>> GetValidateInfo(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_CANU = null, 
			string m3_EXP0 = null, 
			DateTime? m3_DATE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetValidateInfo",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CANU))
				request.WithQueryParameter("CANU", m3_CANU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXP0))
				request.WithQueryParameter("EXP0", m3_EXP0.Trim());
			if (m3_DATE.HasValue)
				request.WithQueryParameter("DATE", m3_DATE.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetValidateInfoResponse>(
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
