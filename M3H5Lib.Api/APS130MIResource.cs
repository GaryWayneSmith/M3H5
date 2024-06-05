/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PRPN">Payment proposal (Required)</param>
		/// <param name="m3PYON">Payment order (Required)</param>
		/// <param name="m3ACDT">Accounting date (Required)</param>
		/// <param name="m3LITP">Report layout (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CKNO">Check number</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3LIMT">Limit value</param>
		/// <param name="m3VTXT">Voucher text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CreateConfChkResponse></returns>
		/// <exception cref="M3Exception<CreateConfChkResponse>"></exception>
		public async Task<M3Response<CreateConfChkResponse>> CreateConfChk(
			string m3DIVI, 
			long m3PRPN, 
			int m3PYON, 
			DateTime m3ACDT, 
			int m3LITP, 
			int? m3CONO = null, 
			decimal? m3CKNO = null, 
			string m3CUCD = null, 
			string m3LIMT = null, 
			string m3VTXT = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PRPN", m3PRPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYON", m3PYON.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACDT", m3ACDT.ToM3String())
				.WithQueryParameter("LITP", m3LITP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CKNO.HasValue)
				request.WithQueryParameter("CKNO", m3CKNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3LIMT))
				request.WithQueryParameter("LIMT", m3LIMT.Trim());
			if (!string.IsNullOrWhiteSpace(m3VTXT))
				request.WithQueryParameter("VTXT", m3VTXT.Trim());

			// Execute the request
			var result = await Execute<CreateConfChkResponse>(
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
		/// Name CreateProposal
		/// Description Create a paymenty proposal
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CUDI">Division (Required)</param>
		/// <param name="m3DIVF">Division from (Required)</param>
		/// <param name="m3DIVT">Division to (Required)</param>
		/// <param name="m3PRPD">Payment proposal date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3BKID">Bank account identity</param>
		/// <param name="m3PYTF">Payment type</param>
		/// <param name="m3PYTT">Payment type</param>
		/// <param name="m3PYM1">Payment method 1 - accounts payable</param>
		/// <param name="m3PYM2">Payment method 2 - accounts payable</param>
		/// <param name="m3PYM3">Payment method 3 - accounts payable</param>
		/// <param name="m3PYM4">Payment method 4 - accounts payable</param>
		/// <param name="m3PYM5">Payment method 5 - accounts payable</param>
		/// <param name="m3PYM6">Payment method 6 - accounts payable</param>
		/// <param name="m3PYM7">Payment method 7 - accounts payable</param>
		/// <param name="m3DUDF">Due date from</param>
		/// <param name="m3DUDT">Due date to</param>
		/// <param name="m3IVDF">Invoice date from</param>
		/// <param name="m3IVDT">Invoice date to</param>
		/// <param name="m3SUCF">Supplier group from</param>
		/// <param name="m3SUCT">Supplier group to</param>
		/// <param name="m3SPYF">Payee from</param>
		/// <param name="m3SPYT">Payee to</param>
		/// <param name="m3PACF">Payment priority from</param>
		/// <param name="m3PACT">Payment priority to</param>
		/// <param name="m3CUCF">Currency from</param>
		/// <param name="m3CUCT">Currency to</param>
		/// <param name="m3PYAF">Payment amount from - local currency</param>
		/// <param name="m3PYAT">Payment amount to - local currency</param>
		/// <param name="m3ORPY">Ordinary payment</param>
		/// <param name="m3RCYP">Recurring payment</param>
		/// <param name="m3PAPY">Payment request</param>
		/// <param name="m3USQU">Use quotas</param>
		/// <param name="m3MXAA">Max payment amout</param>
		/// <param name="m3CNMA">Auto match of credit trans in pmt prop</param>
		/// <param name="m3IVTP">Information type</param>
		/// <param name="m3PYCD">Payment method - accounts receivable</param>
		/// <param name="m3NPRD">Next Payment proposal date</param>
		/// <param name="m3LITX">Report text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CreateProposalResponse></returns>
		/// <exception cref="M3Exception<CreateProposalResponse>"></exception>
		public async Task<M3Response<CreateProposalResponse>> CreateProposal(
			string m3CUDI, 
			string m3DIVF, 
			string m3DIVT, 
			DateTime m3PRPD, 
			int? m3CONO = null, 
			string m3BKID = null, 
			string m3PYTF = null, 
			string m3PYTT = null, 
			string m3PYM1 = null, 
			string m3PYM2 = null, 
			string m3PYM3 = null, 
			string m3PYM4 = null, 
			string m3PYM5 = null, 
			string m3PYM6 = null, 
			string m3PYM7 = null, 
			DateTime? m3DUDF = null, 
			DateTime? m3DUDT = null, 
			DateTime? m3IVDF = null, 
			DateTime? m3IVDT = null, 
			string m3SUCF = null, 
			string m3SUCT = null, 
			string m3SPYF = null, 
			string m3SPYT = null, 
			string m3PACF = null, 
			string m3PACT = null, 
			string m3CUCF = null, 
			string m3CUCT = null, 
			decimal? m3PYAF = null, 
			decimal? m3PYAT = null, 
			int? m3ORPY = null, 
			int? m3RCYP = null, 
			int? m3PAPY = null, 
			int? m3USQU = null, 
			decimal? m3MXAA = null, 
			int? m3CNMA = null, 
			string m3IVTP = null, 
			string m3PYCD = null, 
			DateTime? m3NPRD = null, 
			string m3LITX = null, 
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
			if (string.IsNullOrWhiteSpace(m3CUDI))
				throw new ArgumentNullException(nameof(m3CUDI));
			if (string.IsNullOrWhiteSpace(m3DIVF))
				throw new ArgumentNullException(nameof(m3DIVF));
			if (string.IsNullOrWhiteSpace(m3DIVT))
				throw new ArgumentNullException(nameof(m3DIVT));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUDI", m3CUDI.Trim())
				.WithQueryParameter("DIVF", m3DIVF.Trim())
				.WithQueryParameter("DIVT", m3DIVT.Trim())
				.WithQueryParameter("PRPD", m3PRPD.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BKID))
				request.WithQueryParameter("BKID", m3BKID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYTF))
				request.WithQueryParameter("PYTF", m3PYTF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYTT))
				request.WithQueryParameter("PYTT", m3PYTT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYM1))
				request.WithQueryParameter("PYM1", m3PYM1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYM2))
				request.WithQueryParameter("PYM2", m3PYM2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYM3))
				request.WithQueryParameter("PYM3", m3PYM3.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYM4))
				request.WithQueryParameter("PYM4", m3PYM4.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYM5))
				request.WithQueryParameter("PYM5", m3PYM5.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYM6))
				request.WithQueryParameter("PYM6", m3PYM6.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYM7))
				request.WithQueryParameter("PYM7", m3PYM7.Trim());
			if (m3DUDF.HasValue)
				request.WithQueryParameter("DUDF", m3DUDF.Value.ToM3String());
			if (m3DUDT.HasValue)
				request.WithQueryParameter("DUDT", m3DUDT.Value.ToM3String());
			if (m3IVDF.HasValue)
				request.WithQueryParameter("IVDF", m3IVDF.Value.ToM3String());
			if (m3IVDT.HasValue)
				request.WithQueryParameter("IVDT", m3IVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3SUCF))
				request.WithQueryParameter("SUCF", m3SUCF.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUCT))
				request.WithQueryParameter("SUCT", m3SUCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPYF))
				request.WithQueryParameter("SPYF", m3SPYF.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPYT))
				request.WithQueryParameter("SPYT", m3SPYT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACF))
				request.WithQueryParameter("PACF", m3PACF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCF))
				request.WithQueryParameter("CUCF", m3CUCF.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCT))
				request.WithQueryParameter("CUCT", m3CUCT.Trim());
			if (m3PYAF.HasValue)
				request.WithQueryParameter("PYAF", m3PYAF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PYAT.HasValue)
				request.WithQueryParameter("PYAT", m3PYAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORPY.HasValue)
				request.WithQueryParameter("ORPY", m3ORPY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RCYP.HasValue)
				request.WithQueryParameter("RCYP", m3RCYP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PAPY.HasValue)
				request.WithQueryParameter("PAPY", m3PAPY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3USQU.HasValue)
				request.WithQueryParameter("USQU", m3USQU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXAA.HasValue)
				request.WithQueryParameter("MXAA", m3MXAA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CNMA.HasValue)
				request.WithQueryParameter("CNMA", m3CNMA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3IVTP))
				request.WithQueryParameter("IVTP", m3IVTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYCD))
				request.WithQueryParameter("PYCD", m3PYCD.Trim());
			if (m3NPRD.HasValue)
				request.WithQueryParameter("NPRD", m3NPRD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3LITX))
				request.WithQueryParameter("LITX", m3LITX.Trim());

			// Execute the request
			var result = await Execute<CreateProposalResponse>(
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
		/// Name DeleteProposal
		/// Description Delete payment proposal
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PRPN">Payment proposal (Required)</param>
		/// <param name="m3PYON">Payment order (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteProposal(
			string m3DIVI, 
			long m3PRPN, 
			int m3PYON, 
			int? m3CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PRPN", m3PRPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYON", m3PYON.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetHead
		/// Description Get Head information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PRPN">Payment proposal (Required)</param>
		/// <param name="m3PYON">Payment order (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadResponse></returns>
		/// <exception cref="M3Exception<GetHeadResponse>"></exception>
		public async Task<M3Response<GetHeadResponse>> GetHead(
			string m3DIVI, 
			long m3PRPN, 
			int m3PYON, 
			int? m3CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PRPN", m3PRPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYON", m3PYON.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetHeadResponse>(
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
		/// Name GetHead2
		/// Description Get Head information with global bank account information
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRPN">Payment proposal (Required)</param>
		/// <param name="m3PYON">Payment order (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHead2Response></returns>
		/// <exception cref="M3Exception<GetHead2Response>"></exception>
		public async Task<M3Response<GetHead2Response>> GetHead2(
			long m3PRPN, 
			int m3PYON, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHead2",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PRPN", m3PRPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYON", m3PYON.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<GetHead2Response>(
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
		/// Name GetHeadAddress
		/// Description Get Head Addresses
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PRPN">Payment proposal (Required)</param>
		/// <param name="m3PYON">Payment order (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadAddressResponse></returns>
		/// <exception cref="M3Exception<GetHeadAddressResponse>"></exception>
		public async Task<M3Response<GetHeadAddressResponse>> GetHeadAddress(
			string m3DIVI, 
			long m3PRPN, 
			int m3PYON, 
			int? m3CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PRPN", m3PRPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYON", m3PYON.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetHeadAddressResponse>(
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
		/// Name GetInvLine
		/// Description Get invoice line from payment proposal
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PRPN">Payment proposal (Required)</param>
		/// <param name="m3PYON">Payment order (Required)</param>
		/// <param name="m3SPYN">Payee (Required)</param>
		/// <param name="m3ODIV">Original division (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SCNO">Supplier customer number (Required)</param>
		/// <param name="m3SINO">Supplier invoice number (Required)</param>
		/// <param name="m3INYR">Invoice year (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInvLineResponse></returns>
		/// <exception cref="M3Exception<GetInvLineResponse>"></exception>
		public async Task<M3Response<GetInvLineResponse>> GetInvLine(
			string m3DIVI, 
			long m3PRPN, 
			int m3PYON, 
			string m3SPYN, 
			string m3ODIV, 
			string m3SUNO, 
			string m3SCNO, 
			string m3SINO, 
			int m3INYR, 
			int? m3CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3SPYN))
				throw new ArgumentNullException(nameof(m3SPYN));
			if (string.IsNullOrWhiteSpace(m3ODIV))
				throw new ArgumentNullException(nameof(m3ODIV));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SCNO))
				throw new ArgumentNullException(nameof(m3SCNO));
			if (string.IsNullOrWhiteSpace(m3SINO))
				throw new ArgumentNullException(nameof(m3SINO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PRPN", m3PRPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYON", m3PYON.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SPYN", m3SPYN.Trim())
				.WithQueryParameter("ODIV", m3ODIV.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SCNO", m3SCNO.Trim())
				.WithQueryParameter("SINO", m3SINO.Trim())
				.WithQueryParameter("INYR", m3INYR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetInvLineResponse>(
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
		/// Name GetInvLineTxt
		/// Description Get text information from a specific invoice line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PRPN">Payment proposal (Required)</param>
		/// <param name="m3PYON">Payment order (Required)</param>
		/// <param name="m3SPYN">Payee (Required)</param>
		/// <param name="m3ODIV">Original division (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SCNO">Supplier customer number (Required)</param>
		/// <param name="m3SINO">Supplier invoice number (Required)</param>
		/// <param name="m3INYR">Invoice year (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInvLineTxtResponse></returns>
		/// <exception cref="M3Exception<GetInvLineTxtResponse>"></exception>
		public async Task<M3Response<GetInvLineTxtResponse>> GetInvLineTxt(
			string m3DIVI, 
			long m3PRPN, 
			int m3PYON, 
			string m3SPYN, 
			string m3ODIV, 
			string m3SUNO, 
			string m3SCNO, 
			string m3SINO, 
			int m3INYR, 
			int? m3CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3SPYN))
				throw new ArgumentNullException(nameof(m3SPYN));
			if (string.IsNullOrWhiteSpace(m3ODIV))
				throw new ArgumentNullException(nameof(m3ODIV));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SCNO))
				throw new ArgumentNullException(nameof(m3SCNO));
			if (string.IsNullOrWhiteSpace(m3SINO))
				throw new ArgumentNullException(nameof(m3SINO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PRPN", m3PRPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYON", m3PYON.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SPYN", m3SPYN.Trim())
				.WithQueryParameter("ODIV", m3ODIV.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SCNO", m3SCNO.Trim())
				.WithQueryParameter("SINO", m3SINO.Trim())
				.WithQueryParameter("INYR", m3INYR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetInvLineTxtResponse>(
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
		/// Name GetPayeeTotal
		/// Description Get Payee information and total on payment document
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PRPN">Payment proposal (Required)</param>
		/// <param name="m3PYON">Payment order (Required)</param>
		/// <param name="m3SPYN">Payee (Required)</param>
		/// <param name="m3PDNB">Payment document number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPayeeTotalResponse></returns>
		/// <exception cref="M3Exception<GetPayeeTotalResponse>"></exception>
		public async Task<M3Response<GetPayeeTotalResponse>> GetPayeeTotal(
			string m3DIVI, 
			long m3PRPN, 
			int m3PYON, 
			string m3SPYN, 
			int m3PDNB, 
			int? m3CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3SPYN))
				throw new ArgumentNullException(nameof(m3SPYN));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PRPN", m3PRPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYON", m3PYON.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SPYN", m3SPYN.Trim())
				.WithQueryParameter("PDNB", m3PDNB.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetPayeeTotalResponse>(
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
		/// Name LstInvByPayDate
		/// Description List invoices by payment date
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PRPN">Payment proposal (Required)</param>
		/// <param name="m3PYON">Payment order (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PYDT">Payment date</param>
		/// <param name="m3PDNB">Payment document number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvByPayDateResponse></returns>
		/// <exception cref="M3Exception<LstInvByPayDateResponse>"></exception>
		public async Task<M3Response<LstInvByPayDateResponse>> LstInvByPayDate(
			string m3DIVI, 
			long m3PRPN, 
			int m3PYON, 
			int? m3CONO = null, 
			DateTime? m3PYDT = null, 
			int? m3PDNB = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PRPN", m3PRPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYON", m3PYON.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PYDT.HasValue)
				request.WithQueryParameter("PYDT", m3PYDT.Value.ToM3String());
			if (m3PDNB.HasValue)
				request.WithQueryParameter("PDNB", m3PDNB.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstInvByPayDateResponse>(
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
		/// Name LstInvByPayDoc
		/// Description List invoices by payment document
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PRPN">Payment proposal (Required)</param>
		/// <param name="m3PYON">Payment order (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PDNB">Payment document number</param>
		/// <param name="m3SPYN">Payee</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvByPayDocResponse></returns>
		/// <exception cref="M3Exception<LstInvByPayDocResponse>"></exception>
		public async Task<M3Response<LstInvByPayDocResponse>> LstInvByPayDoc(
			string m3DIVI, 
			long m3PRPN, 
			int m3PYON, 
			int? m3CONO = null, 
			int? m3PDNB = null, 
			string m3SPYN = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PRPN", m3PRPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYON", m3PYON.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PDNB.HasValue)
				request.WithQueryParameter("PDNB", m3PDNB.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPYN))
				request.WithQueryParameter("SPYN", m3SPYN.Trim());

			// Execute the request
			var result = await Execute<LstInvByPayDocResponse>(
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
		/// Name LstInvByPayee
		/// Description List invoices by payee
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PRPN">Payment proposal (Required)</param>
		/// <param name="m3PYON">Payment order (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SPYN">Payee</param>
		/// <param name="m3PDNB">Payment document number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvByPayeeResponse></returns>
		/// <exception cref="M3Exception<LstInvByPayeeResponse>"></exception>
		public async Task<M3Response<LstInvByPayeeResponse>> LstInvByPayee(
			string m3DIVI, 
			long m3PRPN, 
			int m3PYON, 
			int? m3CONO = null, 
			string m3SPYN = null, 
			int? m3PDNB = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PRPN", m3PRPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYON", m3PYON.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPYN))
				request.WithQueryParameter("SPYN", m3SPYN.Trim());
			if (m3PDNB.HasValue)
				request.WithQueryParameter("PDNB", m3PDNB.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstInvByPayeeResponse>(
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
		/// Name LstPayInfByDoc
		/// Description List payee information by payee
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PRPN">Payment proposal (Required)</param>
		/// <param name="m3PYON">Payment order (Required)</param>
		/// <param name="m3SPYN">Payee (Required)</param>
		/// <param name="m3PDNB">Payment document number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TAGG">Tagging type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPayInfByDocResponse></returns>
		/// <exception cref="M3Exception<LstPayInfByDocResponse>"></exception>
		public async Task<M3Response<LstPayInfByDocResponse>> LstPayInfByDoc(
			string m3DIVI, 
			long m3PRPN, 
			int m3PYON, 
			string m3SPYN, 
			int m3PDNB, 
			int? m3CONO = null, 
			string m3TAGG = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3SPYN))
				throw new ArgumentNullException(nameof(m3SPYN));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PRPN", m3PRPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYON", m3PYON.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SPYN", m3SPYN.Trim())
				.WithQueryParameter("PDNB", m3PDNB.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TAGG))
				request.WithQueryParameter("TAGG", m3TAGG.Trim());

			// Execute the request
			var result = await Execute<LstPayInfByDocResponse>(
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
		/// Name LstPayeeTotal3
		/// Description Lst Payee info and tot on pmt doc with global bank accnt inf
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRPN">Payment proposal (Required)</param>
		/// <param name="m3PYON">Payment order (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3SPYN">Payee</param>
		/// <param name="m3PDNB">Payment document number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPayeeTotal3Response></returns>
		/// <exception cref="M3Exception<LstPayeeTotal3Response>"></exception>
		public async Task<M3Response<LstPayeeTotal3Response>> LstPayeeTotal3(
			long m3PRPN, 
			int m3PYON, 
			string m3DIVI = null, 
			string m3SPYN = null, 
			int? m3PDNB = null, 
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
				.WithQueryParameter("PRPN", m3PRPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYON", m3PYON.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPYN))
				request.WithQueryParameter("SPYN", m3SPYN.Trim());
			if (m3PDNB.HasValue)
				request.WithQueryParameter("PDNB", m3PDNB.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPayeeTotal3Response>(
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
		/// Name LstPayeeTotals
		/// Description List Payee information and total on payment document
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PRPN">Payment proposal (Required)</param>
		/// <param name="m3PYON">Payment order (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SPYN">Payee</param>
		/// <param name="m3PDNB">Payment document number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPayeeTotalsResponse></returns>
		/// <exception cref="M3Exception<LstPayeeTotalsResponse>"></exception>
		public async Task<M3Response<LstPayeeTotalsResponse>> LstPayeeTotals(
			string m3DIVI, 
			long m3PRPN, 
			int m3PYON, 
			int? m3CONO = null, 
			string m3SPYN = null, 
			int? m3PDNB = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PRPN", m3PRPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYON", m3PYON.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPYN))
				request.WithQueryParameter("SPYN", m3SPYN.Trim());
			if (m3PDNB.HasValue)
				request.WithQueryParameter("PDNB", m3PDNB.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPayeeTotalsResponse>(
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
		/// Name LstPayeeTotals2
		/// Description List Payee information and total on payment doc include IBAN
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PRPN">Payment proposal (Required)</param>
		/// <param name="m3PYON">Payment order (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SPYN">Payee</param>
		/// <param name="m3PDNB">Payment document number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPayeeTotals2Response></returns>
		/// <exception cref="M3Exception<LstPayeeTotals2Response>"></exception>
		public async Task<M3Response<LstPayeeTotals2Response>> LstPayeeTotals2(
			string m3DIVI, 
			long m3PRPN, 
			int m3PYON, 
			int? m3CONO = null, 
			string m3SPYN = null, 
			int? m3PDNB = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PRPN", m3PRPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYON", m3PYON.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPYN))
				request.WithQueryParameter("SPYN", m3SPYN.Trim());
			if (m3PDNB.HasValue)
				request.WithQueryParameter("PDNB", m3PDNB.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPayeeTotals2Response>(
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
		/// Name LstProposal
		/// Description List Proposal
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PRPN">Payment proposal (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PYON">Payment order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstProposalResponse></returns>
		/// <exception cref="M3Exception<LstProposalResponse>"></exception>
		public async Task<M3Response<LstProposalResponse>> LstProposal(
			string m3DIVI, 
			long m3PRPN, 
			int? m3CONO = null, 
			int? m3PYON = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PRPN", m3PRPN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PYON.HasValue)
				request.WithQueryParameter("PYON", m3PYON.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstProposalResponse>(
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
