/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.APS130MI;
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
	/// Name: APS130MI
	/// Component Name: SupplierPayment
	/// Description: Supplier payment interface
	/// Version Release: 5ea1
	///</summary>
	public partial class APS130MIResource : M3BaseResourceEndpoint
	{
		public APS130MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "APS130MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name CreateConfChk
		/// Description Create Confirm Check
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PRPN">Payment proposal (Required)</param>
		/// <param name="m3_PYON">Payment order (Required)</param>
		/// <param name="m3_ACDT">Accounting date (Required)</param>
		/// <param name="m3_LITP">Report layout (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CKNO">Check number</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_LIMT">Limit value</param>
		/// <param name="m3_VTXT">Voucher text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CreateConfChkResponse></returns>
		/// <exception cref="M3Exception<CreateConfChkResponse>"></exception>
		public async Task<M3Response<CreateConfChkResponse>> CreateConfChk(
			string m3_DIVI, 
			long m3_PRPN, 
			int m3_PYON, 
			DateTime m3_ACDT, 
			int m3_LITP, 
			int? m3_CONO = null, 
			decimal? m3_CKNO = null, 
			string m3_CUCD = null, 
			string m3_LIMT = null, 
			string m3_VTXT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CreateConfChk",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PRPN", m3_PRPN.ToString())
				.WithQueryParameter("PYON", m3_PYON.ToString())
				.WithQueryParameter("ACDT", m3_ACDT.ToM3String())
				.WithQueryParameter("LITP", m3_LITP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_CKNO.HasValue)
				request.WithQueryParameter("CKNO", m3_CKNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LIMT))
				request.WithQueryParameter("LIMT", m3_LIMT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VTXT))
				request.WithQueryParameter("VTXT", m3_VTXT.Trim());

			// Execute the request
			var result = await Execute<CreateConfChkResponse>(
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
		/// Name CreateProposal
		/// Description Create a paymenty proposal
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CUDI">Division (Required)</param>
		/// <param name="m3_DIVF">Division from (Required)</param>
		/// <param name="m3_DIVT">Division to (Required)</param>
		/// <param name="m3_PRPD">Payment proposal date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_BKID">Bank account identity</param>
		/// <param name="m3_PYTF">Payment type</param>
		/// <param name="m3_PYTT">Payment type</param>
		/// <param name="m3_PYM1">Payment method 1 - accounts payable</param>
		/// <param name="m3_PYM2">Payment method 2 - accounts payable</param>
		/// <param name="m3_PYM3">Payment method 3 - accounts payable</param>
		/// <param name="m3_PYM4">Payment method 4 - accounts payable</param>
		/// <param name="m3_PYM5">Payment method 5 - accounts payable</param>
		/// <param name="m3_PYM6">Payment method 6 - accounts payable</param>
		/// <param name="m3_PYM7">Payment method 7 - accounts payable</param>
		/// <param name="m3_DUDF">Due date from</param>
		/// <param name="m3_DUDT">Due date to</param>
		/// <param name="m3_IVDF">Invoice date from</param>
		/// <param name="m3_IVDT">Invoice date to</param>
		/// <param name="m3_SUCF">Supplier group from</param>
		/// <param name="m3_SUCT">Supplier group to</param>
		/// <param name="m3_SPYF">Payee from</param>
		/// <param name="m3_SPYT">Payee to</param>
		/// <param name="m3_PACF">Payment priority from</param>
		/// <param name="m3_PACT">Payment priority to</param>
		/// <param name="m3_CUCF">Currency from</param>
		/// <param name="m3_CUCT">Currency to</param>
		/// <param name="m3_PYAF">Payment amount from - local currency</param>
		/// <param name="m3_PYAT">Payment amount to - local currency</param>
		/// <param name="m3_ORPY">Ordinary payment</param>
		/// <param name="m3_RCYP">Recurring payment</param>
		/// <param name="m3_PAPY">Payment request</param>
		/// <param name="m3_USQU">Use quotas</param>
		/// <param name="m3_MXAA">Max payment amout</param>
		/// <param name="m3_CNMA">Auto match of credit trans in pmt prop</param>
		/// <param name="m3_IVTP">Information type</param>
		/// <param name="m3_PYCD">Payment method - accounts receivable</param>
		/// <param name="m3_NPRD">Next Payment proposal date</param>
		/// <param name="m3_LITX">Report text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CreateProposalResponse></returns>
		/// <exception cref="M3Exception<CreateProposalResponse>"></exception>
		public async Task<M3Response<CreateProposalResponse>> CreateProposal(
			string m3_CUDI, 
			string m3_DIVF, 
			string m3_DIVT, 
			DateTime m3_PRPD, 
			int? m3_CONO = null, 
			string m3_BKID = null, 
			string m3_PYTF = null, 
			string m3_PYTT = null, 
			string m3_PYM1 = null, 
			string m3_PYM2 = null, 
			string m3_PYM3 = null, 
			string m3_PYM4 = null, 
			string m3_PYM5 = null, 
			string m3_PYM6 = null, 
			string m3_PYM7 = null, 
			DateTime? m3_DUDF = null, 
			DateTime? m3_DUDT = null, 
			DateTime? m3_IVDF = null, 
			DateTime? m3_IVDT = null, 
			string m3_SUCF = null, 
			string m3_SUCT = null, 
			string m3_SPYF = null, 
			string m3_SPYT = null, 
			string m3_PACF = null, 
			string m3_PACT = null, 
			string m3_CUCF = null, 
			string m3_CUCT = null, 
			decimal? m3_PYAF = null, 
			decimal? m3_PYAT = null, 
			int? m3_ORPY = null, 
			int? m3_RCYP = null, 
			int? m3_PAPY = null, 
			int? m3_USQU = null, 
			decimal? m3_MXAA = null, 
			int? m3_CNMA = null, 
			string m3_IVTP = null, 
			string m3_PYCD = null, 
			DateTime? m3_NPRD = null, 
			string m3_LITX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CreateProposal",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUDI))
				throw new ArgumentNullException("m3_CUDI");
			if (string.IsNullOrWhiteSpace(m3_DIVF))
				throw new ArgumentNullException("m3_DIVF");
			if (string.IsNullOrWhiteSpace(m3_DIVT))
				throw new ArgumentNullException("m3_DIVT");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUDI", m3_CUDI.Trim())
				.WithQueryParameter("DIVF", m3_DIVF.Trim())
				.WithQueryParameter("DIVT", m3_DIVT.Trim())
				.WithQueryParameter("PRPD", m3_PRPD.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BKID))
				request.WithQueryParameter("BKID", m3_BKID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYTF))
				request.WithQueryParameter("PYTF", m3_PYTF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYTT))
				request.WithQueryParameter("PYTT", m3_PYTT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYM1))
				request.WithQueryParameter("PYM1", m3_PYM1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYM2))
				request.WithQueryParameter("PYM2", m3_PYM2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYM3))
				request.WithQueryParameter("PYM3", m3_PYM3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYM4))
				request.WithQueryParameter("PYM4", m3_PYM4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYM5))
				request.WithQueryParameter("PYM5", m3_PYM5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYM6))
				request.WithQueryParameter("PYM6", m3_PYM6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYM7))
				request.WithQueryParameter("PYM7", m3_PYM7.Trim());
			if (m3_DUDF.HasValue)
				request.WithQueryParameter("DUDF", m3_DUDF.Value.ToM3String());
			if (m3_DUDT.HasValue)
				request.WithQueryParameter("DUDT", m3_DUDT.Value.ToM3String());
			if (m3_IVDF.HasValue)
				request.WithQueryParameter("IVDF", m3_IVDF.Value.ToM3String());
			if (m3_IVDT.HasValue)
				request.WithQueryParameter("IVDT", m3_IVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_SUCF))
				request.WithQueryParameter("SUCF", m3_SUCF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUCT))
				request.WithQueryParameter("SUCT", m3_SUCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPYF))
				request.WithQueryParameter("SPYF", m3_SPYF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPYT))
				request.WithQueryParameter("SPYT", m3_SPYT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACF))
				request.WithQueryParameter("PACF", m3_PACF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCF))
				request.WithQueryParameter("CUCF", m3_CUCF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCT))
				request.WithQueryParameter("CUCT", m3_CUCT.Trim());
			if (m3_PYAF.HasValue)
				request.WithQueryParameter("PYAF", m3_PYAF.Value.ToString());
			if (m3_PYAT.HasValue)
				request.WithQueryParameter("PYAT", m3_PYAT.Value.ToString());
			if (m3_ORPY.HasValue)
				request.WithQueryParameter("ORPY", m3_ORPY.Value.ToString());
			if (m3_RCYP.HasValue)
				request.WithQueryParameter("RCYP", m3_RCYP.Value.ToString());
			if (m3_PAPY.HasValue)
				request.WithQueryParameter("PAPY", m3_PAPY.Value.ToString());
			if (m3_USQU.HasValue)
				request.WithQueryParameter("USQU", m3_USQU.Value.ToString());
			if (m3_MXAA.HasValue)
				request.WithQueryParameter("MXAA", m3_MXAA.Value.ToString());
			if (m3_CNMA.HasValue)
				request.WithQueryParameter("CNMA", m3_CNMA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_IVTP))
				request.WithQueryParameter("IVTP", m3_IVTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYCD))
				request.WithQueryParameter("PYCD", m3_PYCD.Trim());
			if (m3_NPRD.HasValue)
				request.WithQueryParameter("NPRD", m3_NPRD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_LITX))
				request.WithQueryParameter("LITX", m3_LITX.Trim());

			// Execute the request
			var result = await Execute<CreateProposalResponse>(
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
		/// Name DeleteProposal
		/// Description Delete payment proposal
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PRPN">Payment proposal (Required)</param>
		/// <param name="m3_PYON">Payment order (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteProposal(
			string m3_DIVI, 
			long m3_PRPN, 
			int m3_PYON, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeleteProposal",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PRPN", m3_PRPN.ToString())
				.WithQueryParameter("PYON", m3_PYON.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name GetHead
		/// Description Get Head information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PRPN">Payment proposal (Required)</param>
		/// <param name="m3_PYON">Payment order (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadResponse></returns>
		/// <exception cref="M3Exception<GetHeadResponse>"></exception>
		public async Task<M3Response<GetHeadResponse>> GetHead(
			string m3_DIVI, 
			long m3_PRPN, 
			int m3_PYON, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PRPN", m3_PRPN.ToString())
				.WithQueryParameter("PYON", m3_PYON.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetHeadResponse>(
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
		/// Name GetHead2
		/// Description Get Head information with global bank account information
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRPN">Payment proposal (Required)</param>
		/// <param name="m3_PYON">Payment order (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHead2Response></returns>
		/// <exception cref="M3Exception<GetHead2Response>"></exception>
		public async Task<M3Response<GetHead2Response>> GetHead2(
			long m3_PRPN, 
			int m3_PYON, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHead2",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PRPN", m3_PRPN.ToString())
				.WithQueryParameter("PYON", m3_PYON.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<GetHead2Response>(
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
		/// Name GetHeadAddress
		/// Description Get Head Addresses
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PRPN">Payment proposal (Required)</param>
		/// <param name="m3_PYON">Payment order (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadAddressResponse></returns>
		/// <exception cref="M3Exception<GetHeadAddressResponse>"></exception>
		public async Task<M3Response<GetHeadAddressResponse>> GetHeadAddress(
			string m3_DIVI, 
			long m3_PRPN, 
			int m3_PYON, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHeadAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PRPN", m3_PRPN.ToString())
				.WithQueryParameter("PYON", m3_PYON.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetHeadAddressResponse>(
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
		/// Description Get invoice line from payment proposal
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PRPN">Payment proposal (Required)</param>
		/// <param name="m3_PYON">Payment order (Required)</param>
		/// <param name="m3_SPYN">Payee (Required)</param>
		/// <param name="m3_ODIV">Original division (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SCNO">Supplier customer number (Required)</param>
		/// <param name="m3_SINO">Supplier invoice number (Required)</param>
		/// <param name="m3_INYR">Invoice year (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInvLineResponse></returns>
		/// <exception cref="M3Exception<GetInvLineResponse>"></exception>
		public async Task<M3Response<GetInvLineResponse>> GetInvLine(
			string m3_DIVI, 
			long m3_PRPN, 
			int m3_PYON, 
			string m3_SPYN, 
			string m3_ODIV, 
			string m3_SUNO, 
			string m3_SCNO, 
			string m3_SINO, 
			int m3_INYR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetInvLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_SPYN))
				throw new ArgumentNullException("m3_SPYN");
			if (string.IsNullOrWhiteSpace(m3_ODIV))
				throw new ArgumentNullException("m3_ODIV");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SCNO))
				throw new ArgumentNullException("m3_SCNO");
			if (string.IsNullOrWhiteSpace(m3_SINO))
				throw new ArgumentNullException("m3_SINO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PRPN", m3_PRPN.ToString())
				.WithQueryParameter("PYON", m3_PYON.ToString())
				.WithQueryParameter("SPYN", m3_SPYN.Trim())
				.WithQueryParameter("ODIV", m3_ODIV.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SCNO", m3_SCNO.Trim())
				.WithQueryParameter("SINO", m3_SINO.Trim())
				.WithQueryParameter("INYR", m3_INYR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name GetInvLineTxt
		/// Description Get text information from a specific invoice line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PRPN">Payment proposal (Required)</param>
		/// <param name="m3_PYON">Payment order (Required)</param>
		/// <param name="m3_SPYN">Payee (Required)</param>
		/// <param name="m3_ODIV">Original division (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SCNO">Supplier customer number (Required)</param>
		/// <param name="m3_SINO">Supplier invoice number (Required)</param>
		/// <param name="m3_INYR">Invoice year (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInvLineTxtResponse></returns>
		/// <exception cref="M3Exception<GetInvLineTxtResponse>"></exception>
		public async Task<M3Response<GetInvLineTxtResponse>> GetInvLineTxt(
			string m3_DIVI, 
			long m3_PRPN, 
			int m3_PYON, 
			string m3_SPYN, 
			string m3_ODIV, 
			string m3_SUNO, 
			string m3_SCNO, 
			string m3_SINO, 
			int m3_INYR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetInvLineTxt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_SPYN))
				throw new ArgumentNullException("m3_SPYN");
			if (string.IsNullOrWhiteSpace(m3_ODIV))
				throw new ArgumentNullException("m3_ODIV");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SCNO))
				throw new ArgumentNullException("m3_SCNO");
			if (string.IsNullOrWhiteSpace(m3_SINO))
				throw new ArgumentNullException("m3_SINO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PRPN", m3_PRPN.ToString())
				.WithQueryParameter("PYON", m3_PYON.ToString())
				.WithQueryParameter("SPYN", m3_SPYN.Trim())
				.WithQueryParameter("ODIV", m3_ODIV.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SCNO", m3_SCNO.Trim())
				.WithQueryParameter("SINO", m3_SINO.Trim())
				.WithQueryParameter("INYR", m3_INYR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetInvLineTxtResponse>(
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
		/// Name GetPayeeTotal
		/// Description Get Payee information and total on payment document
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PRPN">Payment proposal (Required)</param>
		/// <param name="m3_PYON">Payment order (Required)</param>
		/// <param name="m3_SPYN">Payee (Required)</param>
		/// <param name="m3_PDNB">Payment document number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPayeeTotalResponse></returns>
		/// <exception cref="M3Exception<GetPayeeTotalResponse>"></exception>
		public async Task<M3Response<GetPayeeTotalResponse>> GetPayeeTotal(
			string m3_DIVI, 
			long m3_PRPN, 
			int m3_PYON, 
			string m3_SPYN, 
			int m3_PDNB, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPayeeTotal",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_SPYN))
				throw new ArgumentNullException("m3_SPYN");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PRPN", m3_PRPN.ToString())
				.WithQueryParameter("PYON", m3_PYON.ToString())
				.WithQueryParameter("SPYN", m3_SPYN.Trim())
				.WithQueryParameter("PDNB", m3_PDNB.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetPayeeTotalResponse>(
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
		/// Name LstInvByPayDate
		/// Description List invoices by payment date
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PRPN">Payment proposal (Required)</param>
		/// <param name="m3_PYON">Payment order (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PYDT">Payment date</param>
		/// <param name="m3_PDNB">Payment document number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvByPayDateResponse></returns>
		/// <exception cref="M3Exception<LstInvByPayDateResponse>"></exception>
		public async Task<M3Response<LstInvByPayDateResponse>> LstInvByPayDate(
			string m3_DIVI, 
			long m3_PRPN, 
			int m3_PYON, 
			int? m3_CONO = null, 
			DateTime? m3_PYDT = null, 
			int? m3_PDNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInvByPayDate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PRPN", m3_PRPN.ToString())
				.WithQueryParameter("PYON", m3_PYON.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PYDT.HasValue)
				request.WithQueryParameter("PYDT", m3_PYDT.Value.ToM3String());
			if (m3_PDNB.HasValue)
				request.WithQueryParameter("PDNB", m3_PDNB.Value.ToString());

			// Execute the request
			var result = await Execute<LstInvByPayDateResponse>(
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
		/// Name LstInvByPayDoc
		/// Description List invoices by payment document
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PRPN">Payment proposal (Required)</param>
		/// <param name="m3_PYON">Payment order (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PDNB">Payment document number</param>
		/// <param name="m3_SPYN">Payee</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvByPayDocResponse></returns>
		/// <exception cref="M3Exception<LstInvByPayDocResponse>"></exception>
		public async Task<M3Response<LstInvByPayDocResponse>> LstInvByPayDoc(
			string m3_DIVI, 
			long m3_PRPN, 
			int m3_PYON, 
			int? m3_CONO = null, 
			int? m3_PDNB = null, 
			string m3_SPYN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInvByPayDoc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PRPN", m3_PRPN.ToString())
				.WithQueryParameter("PYON", m3_PYON.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PDNB.HasValue)
				request.WithQueryParameter("PDNB", m3_PDNB.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPYN))
				request.WithQueryParameter("SPYN", m3_SPYN.Trim());

			// Execute the request
			var result = await Execute<LstInvByPayDocResponse>(
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
		/// Name LstInvByPayee
		/// Description List invoices by payee
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PRPN">Payment proposal (Required)</param>
		/// <param name="m3_PYON">Payment order (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SPYN">Payee</param>
		/// <param name="m3_PDNB">Payment document number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvByPayeeResponse></returns>
		/// <exception cref="M3Exception<LstInvByPayeeResponse>"></exception>
		public async Task<M3Response<LstInvByPayeeResponse>> LstInvByPayee(
			string m3_DIVI, 
			long m3_PRPN, 
			int m3_PYON, 
			int? m3_CONO = null, 
			string m3_SPYN = null, 
			int? m3_PDNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInvByPayee",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PRPN", m3_PRPN.ToString())
				.WithQueryParameter("PYON", m3_PYON.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPYN))
				request.WithQueryParameter("SPYN", m3_SPYN.Trim());
			if (m3_PDNB.HasValue)
				request.WithQueryParameter("PDNB", m3_PDNB.Value.ToString());

			// Execute the request
			var result = await Execute<LstInvByPayeeResponse>(
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
		/// Name LstPayInfByDoc
		/// Description List payee information by payee
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PRPN">Payment proposal (Required)</param>
		/// <param name="m3_PYON">Payment order (Required)</param>
		/// <param name="m3_SPYN">Payee (Required)</param>
		/// <param name="m3_PDNB">Payment document number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TAGG">Tagging type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPayInfByDocResponse></returns>
		/// <exception cref="M3Exception<LstPayInfByDocResponse>"></exception>
		public async Task<M3Response<LstPayInfByDocResponse>> LstPayInfByDoc(
			string m3_DIVI, 
			long m3_PRPN, 
			int m3_PYON, 
			string m3_SPYN, 
			int m3_PDNB, 
			int? m3_CONO = null, 
			string m3_TAGG = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPayInfByDoc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_SPYN))
				throw new ArgumentNullException("m3_SPYN");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PRPN", m3_PRPN.ToString())
				.WithQueryParameter("PYON", m3_PYON.ToString())
				.WithQueryParameter("SPYN", m3_SPYN.Trim())
				.WithQueryParameter("PDNB", m3_PDNB.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TAGG))
				request.WithQueryParameter("TAGG", m3_TAGG.Trim());

			// Execute the request
			var result = await Execute<LstPayInfByDocResponse>(
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
		/// Name LstPayeeTotal3
		/// Description Lst Payee info and tot on pmt doc with global bank accnt inf
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRPN">Payment proposal (Required)</param>
		/// <param name="m3_PYON">Payment order (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_SPYN">Payee</param>
		/// <param name="m3_PDNB">Payment document number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPayeeTotal3Response></returns>
		/// <exception cref="M3Exception<LstPayeeTotal3Response>"></exception>
		public async Task<M3Response<LstPayeeTotal3Response>> LstPayeeTotal3(
			long m3_PRPN, 
			int m3_PYON, 
			string m3_DIVI = null, 
			string m3_SPYN = null, 
			int? m3_PDNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPayeeTotal3",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PRPN", m3_PRPN.ToString())
				.WithQueryParameter("PYON", m3_PYON.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPYN))
				request.WithQueryParameter("SPYN", m3_SPYN.Trim());
			if (m3_PDNB.HasValue)
				request.WithQueryParameter("PDNB", m3_PDNB.Value.ToString());

			// Execute the request
			var result = await Execute<LstPayeeTotal3Response>(
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
		/// Name LstPayeeTotals
		/// Description List Payee information and total on payment document
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PRPN">Payment proposal (Required)</param>
		/// <param name="m3_PYON">Payment order (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SPYN">Payee</param>
		/// <param name="m3_PDNB">Payment document number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPayeeTotalsResponse></returns>
		/// <exception cref="M3Exception<LstPayeeTotalsResponse>"></exception>
		public async Task<M3Response<LstPayeeTotalsResponse>> LstPayeeTotals(
			string m3_DIVI, 
			long m3_PRPN, 
			int m3_PYON, 
			int? m3_CONO = null, 
			string m3_SPYN = null, 
			int? m3_PDNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPayeeTotals",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PRPN", m3_PRPN.ToString())
				.WithQueryParameter("PYON", m3_PYON.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPYN))
				request.WithQueryParameter("SPYN", m3_SPYN.Trim());
			if (m3_PDNB.HasValue)
				request.WithQueryParameter("PDNB", m3_PDNB.Value.ToString());

			// Execute the request
			var result = await Execute<LstPayeeTotalsResponse>(
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
		/// Name LstPayeeTotals2
		/// Description List Payee information and total on payment doc include IBAN
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PRPN">Payment proposal (Required)</param>
		/// <param name="m3_PYON">Payment order (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SPYN">Payee</param>
		/// <param name="m3_PDNB">Payment document number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPayeeTotals2Response></returns>
		/// <exception cref="M3Exception<LstPayeeTotals2Response>"></exception>
		public async Task<M3Response<LstPayeeTotals2Response>> LstPayeeTotals2(
			string m3_DIVI, 
			long m3_PRPN, 
			int m3_PYON, 
			int? m3_CONO = null, 
			string m3_SPYN = null, 
			int? m3_PDNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPayeeTotals2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PRPN", m3_PRPN.ToString())
				.WithQueryParameter("PYON", m3_PYON.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPYN))
				request.WithQueryParameter("SPYN", m3_SPYN.Trim());
			if (m3_PDNB.HasValue)
				request.WithQueryParameter("PDNB", m3_PDNB.Value.ToString());

			// Execute the request
			var result = await Execute<LstPayeeTotals2Response>(
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
		/// Name LstProposal
		/// Description List Proposal
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PRPN">Payment proposal (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PYON">Payment order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstProposalResponse></returns>
		/// <exception cref="M3Exception<LstProposalResponse>"></exception>
		public async Task<M3Response<LstProposalResponse>> LstProposal(
			string m3_DIVI, 
			long m3_PRPN, 
			int? m3_CONO = null, 
			int? m3_PYON = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstProposal",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PRPN", m3_PRPN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PYON.HasValue)
				request.WithQueryParameter("PYON", m3_PYON.Value.ToString());

			// Execute the request
			var result = await Execute<LstProposalResponse>(
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
