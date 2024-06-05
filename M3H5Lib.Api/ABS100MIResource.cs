/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.ABS100MI;
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
	/// Name: ABS100MI
	/// Component Name: BankStatement
	/// Description: Bank statement interface
	/// Version Release: 5ea1
	///</summary>
	public partial class ABS100MIResource : M3BaseResourceEndpoint
	{
		public ABS100MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "ABS100MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddStatmtAdditi
		/// Description Add statement additional information
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BLSN">Sequence number (Required)</param>
		/// <param name="m3BLAI">Additional information number (Required)</param>
		/// <param name="m3BLFX">Free text field (Required)</param>
		/// <param name="m3JBNO">Job number (Required)</param>
		/// <param name="m3JBDT">Job date (Required)</param>
		/// <param name="m3JBTM">Job time (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddStatmtAdditiResponse></returns>
		/// <exception cref="M3Exception<AddStatmtAdditiResponse>"></exception>
		public async Task<M3Response<AddStatmtAdditiResponse>> AddStatmtAdditi(
			string m3DIVI, 
			int m3BLSN, 
			int m3BLAI, 
			string m3BLFX, 
			int m3JBNO, 
			DateTime m3JBDT, 
			int m3JBTM, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddStatmtAdditi",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BLFX))
				throw new ArgumentNullException(nameof(m3BLFX));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BLSN", m3BLSN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BLAI", m3BLAI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BLFX", m3BLFX.Trim())
				.WithQueryParameter("JBNO", m3JBNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBDT", m3JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3JBTM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddStatmtAdditiResponse>(
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
		/// Name AddStatmtDetail
		/// Description Add statement detail
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BLSN">Sequence number (Required)</param>
		/// <param name="m3BLSS">Sequence sub no (Required)</param>
		/// <param name="m3JBNO">Job number (Required)</param>
		/// <param name="m3JBDT">Job date (Required)</param>
		/// <param name="m3JBTM">Job time (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3BLTT">Transaction type</param>
		/// <param name="m3BLBC">Business transaction code</param>
		/// <param name="m3BLTX">Transaction text</param>
		/// <param name="m3BLDC">Debit-credit code</param>
		/// <param name="m3BLNF">Net amount Cur</param>
		/// <param name="m3CINO">Invoice no AR</param>
		/// <param name="m3SINO">Invoice no AP</param>
		/// <param name="m3INYR">Invoice year</param>
		/// <param name="m3EXN1">GL information number</param>
		/// <param name="m3EXI1">GL additional information</param>
		/// <param name="m3EXN2">GL information number</param>
		/// <param name="m3EXI2">GL additional information</param>
		/// <param name="m3EXN3">GL information number</param>
		/// <param name="m3EXI3">GL additional information</param>
		/// <param name="m3EXN4">GL information number</param>
		/// <param name="m3EXI4">GL additional information</param>
		/// <param name="m3EXN5">GL information number</param>
		/// <param name="m3EXI5">GL additional information</param>
		/// <param name="m3IRNO">Payment reference number</param>
		/// <param name="m3ODIV">Original division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddStatmtDetailResponse></returns>
		/// <exception cref="M3Exception<AddStatmtDetailResponse>"></exception>
		public async Task<M3Response<AddStatmtDetailResponse>> AddStatmtDetail(
			string m3DIVI, 
			int m3BLSN, 
			int m3BLSS, 
			int m3JBNO, 
			DateTime m3JBDT, 
			int m3JBTM, 
			int? m3CONO = null, 
			string m3BLTT = null, 
			string m3BLBC = null, 
			string m3BLTX = null, 
			string m3BLDC = null, 
			decimal? m3BLNF = null, 
			string m3CINO = null, 
			string m3SINO = null, 
			int? m3INYR = null, 
			int? m3EXN1 = null, 
			string m3EXI1 = null, 
			int? m3EXN2 = null, 
			string m3EXI2 = null, 
			int? m3EXN3 = null, 
			string m3EXI3 = null, 
			int? m3EXN4 = null, 
			string m3EXI4 = null, 
			int? m3EXN5 = null, 
			string m3EXI5 = null, 
			string m3IRNO = null, 
			string m3ODIV = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddStatmtDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BLSN", m3BLSN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BLSS", m3BLSS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBNO", m3JBNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBDT", m3JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3JBTM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BLTT))
				request.WithQueryParameter("BLTT", m3BLTT.Trim());
			if (!string.IsNullOrWhiteSpace(m3BLBC))
				request.WithQueryParameter("BLBC", m3BLBC.Trim());
			if (!string.IsNullOrWhiteSpace(m3BLTX))
				request.WithQueryParameter("BLTX", m3BLTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3BLDC))
				request.WithQueryParameter("BLDC", m3BLDC.Trim());
			if (m3BLNF.HasValue)
				request.WithQueryParameter("BLNF", m3BLNF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CINO))
				request.WithQueryParameter("CINO", m3CINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SINO))
				request.WithQueryParameter("SINO", m3SINO.Trim());
			if (m3INYR.HasValue)
				request.WithQueryParameter("INYR", m3INYR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXN1.HasValue)
				request.WithQueryParameter("EXN1", m3EXN1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EXI1))
				request.WithQueryParameter("EXI1", m3EXI1.Trim());
			if (m3EXN2.HasValue)
				request.WithQueryParameter("EXN2", m3EXN2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EXI2))
				request.WithQueryParameter("EXI2", m3EXI2.Trim());
			if (m3EXN3.HasValue)
				request.WithQueryParameter("EXN3", m3EXN3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EXI3))
				request.WithQueryParameter("EXI3", m3EXI3.Trim());
			if (m3EXN4.HasValue)
				request.WithQueryParameter("EXN4", m3EXN4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EXI4))
				request.WithQueryParameter("EXI4", m3EXI4.Trim());
			if (m3EXN5.HasValue)
				request.WithQueryParameter("EXN5", m3EXN5.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EXI5))
				request.WithQueryParameter("EXI5", m3EXI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3IRNO))
				request.WithQueryParameter("IRNO", m3IRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ODIV))
				request.WithQueryParameter("ODIV", m3ODIV.Trim());

			// Execute the request
			var result = await Execute<AddStatmtDetailResponse>(
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
		/// Name AddStatmtHead
		/// Description Add statement head
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BSTY">Bank statement type (Required)</param>
		/// <param name="m3STMN">Bank statment no (Required)</param>
		/// <param name="m3BSID">Bank identifier (Required)</param>
		/// <param name="m3CUCD">Currency code (Required)</param>
		/// <param name="m3BSOB">Opening balance (Currency)</param>
		/// <param name="m3BSOT">Opening balance date</param>
		/// <param name="m3BSCB">Closing balance (Currency)</param>
		/// <param name="m3BSCT">Closing balance date</param>
		/// <param name="m3BSTD">Total amount - Debit (Currency)</param>
		/// <param name="m3BSTC">Total amount - Credit (Currency)</param>
		/// <param name="m3BSRE">Transaction reference no</param>
		/// <param name="m3BSRX">Transaction reference no</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddStatmtHeadResponse></returns>
		/// <exception cref="M3Exception<AddStatmtHeadResponse>"></exception>
		public async Task<M3Response<AddStatmtHeadResponse>> AddStatmtHead(
			int m3CONO, 
			string m3DIVI, 
			int m3BSTY, 
			string m3STMN, 
			string m3BSID, 
			string m3CUCD, 
			decimal? m3BSOB = null, 
			DateTime? m3BSOT = null, 
			decimal? m3BSCB = null, 
			DateTime? m3BSCT = null, 
			decimal? m3BSTD = null, 
			decimal? m3BSTC = null, 
			string m3BSRE = null, 
			string m3BSRX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddStatmtHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3STMN))
				throw new ArgumentNullException(nameof(m3STMN));
			if (string.IsNullOrWhiteSpace(m3BSID))
				throw new ArgumentNullException(nameof(m3BSID));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BSTY", m3BSTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STMN", m3STMN.Trim())
				.WithQueryParameter("BSID", m3BSID.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3BSOB.HasValue)
				request.WithQueryParameter("BSOB", m3BSOB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BSOT.HasValue)
				request.WithQueryParameter("BSOT", m3BSOT.Value.ToM3String());
			if (m3BSCB.HasValue)
				request.WithQueryParameter("BSCB", m3BSCB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BSCT.HasValue)
				request.WithQueryParameter("BSCT", m3BSCT.Value.ToM3String());
			if (m3BSTD.HasValue)
				request.WithQueryParameter("BSTD", m3BSTD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BSTC.HasValue)
				request.WithQueryParameter("BSTC", m3BSTC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BSRE))
				request.WithQueryParameter("BSRE", m3BSRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3BSRX))
				request.WithQueryParameter("BSRX", m3BSRX.Trim());

			// Execute the request
			var result = await Execute<AddStatmtHeadResponse>(
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
		/// Name AddStatmtLine
		/// Description Add statement line
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BLSN">Sequence number (Required)</param>
		/// <param name="m3BLLF">Line amount Cur (Required)</param>
		/// <param name="m3JBNO">Job number (Required)</param>
		/// <param name="m3JBDT">Job date (Required)</param>
		/// <param name="m3JBTM">Job time (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3BLLT">Statement line type</param>
		/// <param name="m3BLBS">Bank statment bank no</param>
		/// <param name="m3CUCD">Currency code</param>
		/// <param name="m3ARAT">Exchange rate</param>
		/// <param name="m3BLLL">Line amount Loc</param>
		/// <param name="m3BLAN">Payer / Payee bank account number</param>
		/// <param name="m3CURD">Value date</param>
		/// <param name="m3ACDT">Accounting date</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3SPYN">Payee</param>
		/// <param name="m3AIN1">Payer / Payee- Info 1</param>
		/// <param name="m3AIN2">Payer / Payee- Info 2</param>
		/// <param name="m3AIN3">Payer / Payee- Info 3</param>
		/// <param name="m3ABNO">Bank reference</param>
		/// <param name="m3RIMA">Primanota</param>
		/// <param name="m3ECCD">Record code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddStatmtLineResponse></returns>
		/// <exception cref="M3Exception<AddStatmtLineResponse>"></exception>
		public async Task<M3Response<AddStatmtLineResponse>> AddStatmtLine(
			string m3DIVI, 
			int m3BLSN, 
			decimal m3BLLF, 
			int m3JBNO, 
			DateTime m3JBDT, 
			int m3JBTM, 
			int? m3CONO = null, 
			int? m3BLLT = null, 
			string m3BLBS = null, 
			string m3CUCD = null, 
			decimal? m3ARAT = null, 
			decimal? m3BLLL = null, 
			string m3BLAN = null, 
			DateTime? m3CURD = null, 
			DateTime? m3ACDT = null, 
			string m3PYNO = null, 
			string m3SPYN = null, 
			string m3AIN1 = null, 
			string m3AIN2 = null, 
			string m3AIN3 = null, 
			string m3ABNO = null, 
			string m3RIMA = null, 
			string m3ECCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddStatmtLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BLSN", m3BLSN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BLLF", m3BLLF.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBNO", m3JBNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBDT", m3JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3JBTM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BLLT.HasValue)
				request.WithQueryParameter("BLLT", m3BLLT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BLBS))
				request.WithQueryParameter("BLBS", m3BLBS.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3ARAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BLLL.HasValue)
				request.WithQueryParameter("BLLL", m3BLLL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BLAN))
				request.WithQueryParameter("BLAN", m3BLAN.Trim());
			if (m3CURD.HasValue)
				request.WithQueryParameter("CURD", m3CURD.Value.ToM3String());
			if (m3ACDT.HasValue)
				request.WithQueryParameter("ACDT", m3ACDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPYN))
				request.WithQueryParameter("SPYN", m3SPYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIN1))
				request.WithQueryParameter("AIN1", m3AIN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIN2))
				request.WithQueryParameter("AIN2", m3AIN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIN3))
				request.WithQueryParameter("AIN3", m3AIN3.Trim());
			if (!string.IsNullOrWhiteSpace(m3ABNO))
				request.WithQueryParameter("ABNO", m3ABNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RIMA))
				request.WithQueryParameter("RIMA", m3RIMA.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECCD))
				request.WithQueryParameter("ECCD", m3ECCD.Trim());

			// Execute the request
			var result = await Execute<AddStatmtLineResponse>(
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
		/// Name GetBankIdent
		/// Description Get bank identifier
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BSID">Bank identifier (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBankIdentResponse></returns>
		/// <exception cref="M3Exception<GetBankIdentResponse>"></exception>
		public async Task<M3Response<GetBankIdentResponse>> GetBankIdent(
			string m3DIVI, 
			string m3BSID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBankIdent",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BSID))
				throw new ArgumentNullException(nameof(m3BSID));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BSID", m3BSID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetBankIdentResponse>(
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
		/// Name UpdStatmtAdditi
		/// Description Update statement additional information
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BLSN">Sequence number (Required)</param>
		/// <param name="m3BLAI">Additional information number (Required)</param>
		/// <param name="m3JBNO">Job number (Required)</param>
		/// <param name="m3JBDT">Job date (Required)</param>
		/// <param name="m3JBTM">Job time (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3BLFX">Free text field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdStatmtAdditi(
			string m3DIVI, 
			int m3BLSN, 
			int m3BLAI, 
			int m3JBNO, 
			DateTime m3JBDT, 
			int m3JBTM, 
			int? m3CONO = null, 
			string m3BLFX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdStatmtAdditi",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BLSN", m3BLSN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BLAI", m3BLAI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBNO", m3JBNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBDT", m3JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3JBTM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BLFX))
				request.WithQueryParameter("BLFX", m3BLFX.Trim());

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
		/// Name UpdStatmtDetail
		/// Description Update statement detail
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3JBNO">Job number (Required)</param>
		/// <param name="m3JBDT">Job date (Required)</param>
		/// <param name="m3JBTM">Job time (Required)</param>
		/// <param name="m3BLSN">Sequence number (Required)</param>
		/// <param name="m3BLSS">Sequence sub no (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3BLTT">Transaction type</param>
		/// <param name="m3BLBC">Business transaction code</param>
		/// <param name="m3BLTX">Transaction text</param>
		/// <param name="m3BLDC">Debit-credit code</param>
		/// <param name="m3BLNF">Net amount Cur</param>
		/// <param name="m3BLNL">Net amount Loc</param>
		/// <param name="m3CINO">Invoice  no AR</param>
		/// <param name="m3SINO">Invoice no AP</param>
		/// <param name="m3INYR">Invoice year</param>
		/// <param name="m3EXN1">GL information number</param>
		/// <param name="m3EXI1">GL additiona information</param>
		/// <param name="m3EXN2">GL information number</param>
		/// <param name="m3EXI2">GL additional information</param>
		/// <param name="m3EXN3">GL information number</param>
		/// <param name="m3EXI3">GL additional information</param>
		/// <param name="m3EXN4">GL information number</param>
		/// <param name="m3EXI4">GL additional information</param>
		/// <param name="m3EXN5">GL information number</param>
		/// <param name="m3EXI5">GL additional information</param>
		/// <param name="m3IRNO">Payment reference number</param>
		/// <param name="m3ODIV">Original division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdStatmtDetail(
			string m3DIVI, 
			int m3JBNO, 
			DateTime m3JBDT, 
			int m3JBTM, 
			int m3BLSN, 
			int m3BLSS, 
			int? m3CONO = null, 
			string m3BLTT = null, 
			string m3BLBC = null, 
			string m3BLTX = null, 
			string m3BLDC = null, 
			decimal? m3BLNF = null, 
			decimal? m3BLNL = null, 
			string m3CINO = null, 
			string m3SINO = null, 
			int? m3INYR = null, 
			int? m3EXN1 = null, 
			string m3EXI1 = null, 
			int? m3EXN2 = null, 
			string m3EXI2 = null, 
			int? m3EXN3 = null, 
			string m3EXI3 = null, 
			int? m3EXN4 = null, 
			string m3EXI4 = null, 
			int? m3EXN5 = null, 
			string m3EXI5 = null, 
			string m3IRNO = null, 
			string m3ODIV = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdStatmtDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("JBNO", m3JBNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBDT", m3JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3JBTM.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BLSN", m3BLSN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BLSS", m3BLSS.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BLTT))
				request.WithQueryParameter("BLTT", m3BLTT.Trim());
			if (!string.IsNullOrWhiteSpace(m3BLBC))
				request.WithQueryParameter("BLBC", m3BLBC.Trim());
			if (!string.IsNullOrWhiteSpace(m3BLTX))
				request.WithQueryParameter("BLTX", m3BLTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3BLDC))
				request.WithQueryParameter("BLDC", m3BLDC.Trim());
			if (m3BLNF.HasValue)
				request.WithQueryParameter("BLNF", m3BLNF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BLNL.HasValue)
				request.WithQueryParameter("BLNL", m3BLNL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CINO))
				request.WithQueryParameter("CINO", m3CINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SINO))
				request.WithQueryParameter("SINO", m3SINO.Trim());
			if (m3INYR.HasValue)
				request.WithQueryParameter("INYR", m3INYR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXN1.HasValue)
				request.WithQueryParameter("EXN1", m3EXN1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EXI1))
				request.WithQueryParameter("EXI1", m3EXI1.Trim());
			if (m3EXN2.HasValue)
				request.WithQueryParameter("EXN2", m3EXN2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EXI2))
				request.WithQueryParameter("EXI2", m3EXI2.Trim());
			if (m3EXN3.HasValue)
				request.WithQueryParameter("EXN3", m3EXN3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EXI3))
				request.WithQueryParameter("EXI3", m3EXI3.Trim());
			if (m3EXN4.HasValue)
				request.WithQueryParameter("EXN4", m3EXN4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EXI4))
				request.WithQueryParameter("EXI4", m3EXI4.Trim());
			if (m3EXN5.HasValue)
				request.WithQueryParameter("EXN5", m3EXN5.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EXI5))
				request.WithQueryParameter("EXI5", m3EXI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3IRNO))
				request.WithQueryParameter("IRNO", m3IRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ODIV))
				request.WithQueryParameter("ODIV", m3ODIV.Trim());

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
		/// Name UpdStatmtHead
		/// Description Update statement head
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3JBNO">Job number (Required)</param>
		/// <param name="m3JBDT">Job date (Required)</param>
		/// <param name="m3JBTM">Job time (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3BSCB">Closing balance (Currency)</param>
		/// <param name="m3BSCT">Closing balance date</param>
		/// <param name="m3BSTD">Total amount - Debit (Currency)</param>
		/// <param name="m3BSTC">Total amount - Credit (Currency)</param>
		/// <param name="m3STMN">Bank statement no</param>
		/// <param name="m3BSOT">Opening balance date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdStatmtHead(
			string m3DIVI, 
			int m3JBNO, 
			DateTime m3JBDT, 
			int m3JBTM, 
			int? m3CONO = null, 
			decimal? m3BSCB = null, 
			DateTime? m3BSCT = null, 
			decimal? m3BSTD = null, 
			decimal? m3BSTC = null, 
			string m3STMN = null, 
			DateTime? m3BSOT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdStatmtHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("JBNO", m3JBNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBDT", m3JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3JBTM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BSCB.HasValue)
				request.WithQueryParameter("BSCB", m3BSCB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BSCT.HasValue)
				request.WithQueryParameter("BSCT", m3BSCT.Value.ToM3String());
			if (m3BSTD.HasValue)
				request.WithQueryParameter("BSTD", m3BSTD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BSTC.HasValue)
				request.WithQueryParameter("BSTC", m3BSTC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STMN))
				request.WithQueryParameter("STMN", m3STMN.Trim());
			if (m3BSOT.HasValue)
				request.WithQueryParameter("BSOT", m3BSOT.Value.ToM3String());

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
		/// Name UpdStatmtLine
		/// Description Update statement line
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3JBNO">Job number (Required)</param>
		/// <param name="m3JBDT">Job date (Required)</param>
		/// <param name="m3JBTM">Job time (Required)</param>
		/// <param name="m3BLSN">Sequence number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3BLLT">Statement line type</param>
		/// <param name="m3BLBS">Bank statement bank no</param>
		/// <param name="m3CUCD">Currency code</param>
		/// <param name="m3ARAT">Exchange rate</param>
		/// <param name="m3BLLF">Line amount Cur</param>
		/// <param name="m3BLLL">Line amount Loc</param>
		/// <param name="m3BLAN">Payer/Payee bank account</param>
		/// <param name="m3CURD">Value date</param>
		/// <param name="m3ACDT">Accounting date</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3SPYN">Payee</param>
		/// <param name="m3AIN1">Payer/Payee- Info 1</param>
		/// <param name="m3AIN2">Payer/Payee- Info 2</param>
		/// <param name="m3AIN3">Payer/Payee- Info 3</param>
		/// <param name="m3ABNO">Bank reference</param>
		/// <param name="m3RIMA">Primanota</param>
		/// <param name="m3ECCD">Record code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdStatmtLine(
			string m3DIVI, 
			int m3JBNO, 
			DateTime m3JBDT, 
			int m3JBTM, 
			int m3BLSN, 
			int? m3CONO = null, 
			int? m3BLLT = null, 
			string m3BLBS = null, 
			string m3CUCD = null, 
			decimal? m3ARAT = null, 
			decimal? m3BLLF = null, 
			decimal? m3BLLL = null, 
			string m3BLAN = null, 
			DateTime? m3CURD = null, 
			DateTime? m3ACDT = null, 
			string m3PYNO = null, 
			string m3SPYN = null, 
			string m3AIN1 = null, 
			string m3AIN2 = null, 
			string m3AIN3 = null, 
			string m3ABNO = null, 
			string m3RIMA = null, 
			string m3ECCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdStatmtLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("JBNO", m3JBNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBDT", m3JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3JBTM.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BLSN", m3BLSN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BLLT.HasValue)
				request.WithQueryParameter("BLLT", m3BLLT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BLBS))
				request.WithQueryParameter("BLBS", m3BLBS.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3ARAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BLLF.HasValue)
				request.WithQueryParameter("BLLF", m3BLLF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BLLL.HasValue)
				request.WithQueryParameter("BLLL", m3BLLL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BLAN))
				request.WithQueryParameter("BLAN", m3BLAN.Trim());
			if (m3CURD.HasValue)
				request.WithQueryParameter("CURD", m3CURD.Value.ToM3String());
			if (m3ACDT.HasValue)
				request.WithQueryParameter("ACDT", m3ACDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPYN))
				request.WithQueryParameter("SPYN", m3SPYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIN1))
				request.WithQueryParameter("AIN1", m3AIN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIN2))
				request.WithQueryParameter("AIN2", m3AIN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIN3))
				request.WithQueryParameter("AIN3", m3AIN3.Trim());
			if (!string.IsNullOrWhiteSpace(m3ABNO))
				request.WithQueryParameter("ABNO", m3ABNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RIMA))
				request.WithQueryParameter("RIMA", m3RIMA.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECCD))
				request.WithQueryParameter("ECCD", m3ECCD.Trim());

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
		/// Name UpdStatmtStatus
		/// Description Update statement status
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3JBNO">Job number (Required)</param>
		/// <param name="m3JBDT">Job date (Required)</param>
		/// <param name="m3JBTM">Job time (Required)</param>
		/// <param name="m3BSHS">Bank statement status (Required)</param>
		/// <param name="m3BSHB">Blocked (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdStatmtStatus(
			string m3DIVI, 
			int m3JBNO, 
			DateTime m3JBDT, 
			int m3JBTM, 
			int m3BSHS, 
			int m3BSHB, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdStatmtStatus",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("JBNO", m3JBNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBDT", m3JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3JBTM.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BSHS", m3BSHS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BSHB", m3BSHB.ToString(CultureInfo.CurrentCulture));

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
	}
}
// EOF
