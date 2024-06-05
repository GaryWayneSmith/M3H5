/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BLSN">Sequence number (Required)</param>
		/// <param name="m3_BLAI">Additional information number (Required)</param>
		/// <param name="m3_BLFX">Free text field (Required)</param>
		/// <param name="m3_JBNO">Job number (Required)</param>
		/// <param name="m3_JBDT">Job date (Required)</param>
		/// <param name="m3_JBTM">Job time (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddStatmtAdditiResponse></returns>
		/// <exception cref="M3Exception<AddStatmtAdditiResponse>"></exception>
		public async Task<M3Response<AddStatmtAdditiResponse>> AddStatmtAdditi(
			string m3_DIVI, 
			int m3_BLSN, 
			int m3_BLAI, 
			string m3_BLFX, 
			int m3_JBNO, 
			DateTime m3_JBDT, 
			int m3_JBTM, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddStatmtAdditi",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BLFX))
				throw new ArgumentNullException("m3_BLFX");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BLSN", m3_BLSN.ToString())
				.WithQueryParameter("BLAI", m3_BLAI.ToString())
				.WithQueryParameter("BLFX", m3_BLFX.Trim())
				.WithQueryParameter("JBNO", m3_JBNO.ToString())
				.WithQueryParameter("JBDT", m3_JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3_JBTM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<AddStatmtAdditiResponse>(
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
		/// Name AddStatmtDetail
		/// Description Add statement detail
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BLSN">Sequence number (Required)</param>
		/// <param name="m3_BLSS">Sequence sub no (Required)</param>
		/// <param name="m3_JBNO">Job number (Required)</param>
		/// <param name="m3_JBDT">Job date (Required)</param>
		/// <param name="m3_JBTM">Job time (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_BLTT">Transaction type</param>
		/// <param name="m3_BLBC">Business transaction code</param>
		/// <param name="m3_BLTX">Transaction text</param>
		/// <param name="m3_BLDC">Debit-credit code</param>
		/// <param name="m3_BLNF">Net amount Cur</param>
		/// <param name="m3_CINO">Invoice no AR</param>
		/// <param name="m3_SINO">Invoice no AP</param>
		/// <param name="m3_INYR">Invoice year</param>
		/// <param name="m3_EXN1">GL information number</param>
		/// <param name="m3_EXI1">GL additional information</param>
		/// <param name="m3_EXN2">GL information number</param>
		/// <param name="m3_EXI2">GL additional information</param>
		/// <param name="m3_EXN3">GL information number</param>
		/// <param name="m3_EXI3">GL additional information</param>
		/// <param name="m3_EXN4">GL information number</param>
		/// <param name="m3_EXI4">GL additional information</param>
		/// <param name="m3_EXN5">GL information number</param>
		/// <param name="m3_EXI5">GL additional information</param>
		/// <param name="m3_IRNO">Payment reference number</param>
		/// <param name="m3_ODIV">Original division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddStatmtDetailResponse></returns>
		/// <exception cref="M3Exception<AddStatmtDetailResponse>"></exception>
		public async Task<M3Response<AddStatmtDetailResponse>> AddStatmtDetail(
			string m3_DIVI, 
			int m3_BLSN, 
			int m3_BLSS, 
			int m3_JBNO, 
			DateTime m3_JBDT, 
			int m3_JBTM, 
			int? m3_CONO = null, 
			string m3_BLTT = null, 
			string m3_BLBC = null, 
			string m3_BLTX = null, 
			string m3_BLDC = null, 
			decimal? m3_BLNF = null, 
			string m3_CINO = null, 
			string m3_SINO = null, 
			int? m3_INYR = null, 
			int? m3_EXN1 = null, 
			string m3_EXI1 = null, 
			int? m3_EXN2 = null, 
			string m3_EXI2 = null, 
			int? m3_EXN3 = null, 
			string m3_EXI3 = null, 
			int? m3_EXN4 = null, 
			string m3_EXI4 = null, 
			int? m3_EXN5 = null, 
			string m3_EXI5 = null, 
			string m3_IRNO = null, 
			string m3_ODIV = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BLSN", m3_BLSN.ToString())
				.WithQueryParameter("BLSS", m3_BLSS.ToString())
				.WithQueryParameter("JBNO", m3_JBNO.ToString())
				.WithQueryParameter("JBDT", m3_JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3_JBTM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BLTT))
				request.WithQueryParameter("BLTT", m3_BLTT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BLBC))
				request.WithQueryParameter("BLBC", m3_BLBC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BLTX))
				request.WithQueryParameter("BLTX", m3_BLTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BLDC))
				request.WithQueryParameter("BLDC", m3_BLDC.Trim());
			if (m3_BLNF.HasValue)
				request.WithQueryParameter("BLNF", m3_BLNF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CINO))
				request.WithQueryParameter("CINO", m3_CINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SINO))
				request.WithQueryParameter("SINO", m3_SINO.Trim());
			if (m3_INYR.HasValue)
				request.WithQueryParameter("INYR", m3_INYR.Value.ToString());
			if (m3_EXN1.HasValue)
				request.WithQueryParameter("EXN1", m3_EXN1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EXI1))
				request.WithQueryParameter("EXI1", m3_EXI1.Trim());
			if (m3_EXN2.HasValue)
				request.WithQueryParameter("EXN2", m3_EXN2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EXI2))
				request.WithQueryParameter("EXI2", m3_EXI2.Trim());
			if (m3_EXN3.HasValue)
				request.WithQueryParameter("EXN3", m3_EXN3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EXI3))
				request.WithQueryParameter("EXI3", m3_EXI3.Trim());
			if (m3_EXN4.HasValue)
				request.WithQueryParameter("EXN4", m3_EXN4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EXI4))
				request.WithQueryParameter("EXI4", m3_EXI4.Trim());
			if (m3_EXN5.HasValue)
				request.WithQueryParameter("EXN5", m3_EXN5.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EXI5))
				request.WithQueryParameter("EXI5", m3_EXI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IRNO))
				request.WithQueryParameter("IRNO", m3_IRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ODIV))
				request.WithQueryParameter("ODIV", m3_ODIV.Trim());

			// Execute the request
			var result = await Execute<AddStatmtDetailResponse>(
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
		/// Name AddStatmtHead
		/// Description Add statement head
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BSTY">Bank statement type (Required)</param>
		/// <param name="m3_STMN">Bank statment no (Required)</param>
		/// <param name="m3_BSID">Bank identifier (Required)</param>
		/// <param name="m3_CUCD">Currency code (Required)</param>
		/// <param name="m3_BSOB">Opening balance (Currency)</param>
		/// <param name="m3_BSOT">Opening balance date</param>
		/// <param name="m3_BSCB">Closing balance (Currency)</param>
		/// <param name="m3_BSCT">Closing balance date</param>
		/// <param name="m3_BSTD">Total amount - Debit (Currency)</param>
		/// <param name="m3_BSTC">Total amount - Credit (Currency)</param>
		/// <param name="m3_BSRE">Transaction reference no</param>
		/// <param name="m3_BSRX">Transaction reference no</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddStatmtHeadResponse></returns>
		/// <exception cref="M3Exception<AddStatmtHeadResponse>"></exception>
		public async Task<M3Response<AddStatmtHeadResponse>> AddStatmtHead(
			int m3_CONO, 
			string m3_DIVI, 
			int m3_BSTY, 
			string m3_STMN, 
			string m3_BSID, 
			string m3_CUCD, 
			decimal? m3_BSOB = null, 
			DateTime? m3_BSOT = null, 
			decimal? m3_BSCB = null, 
			DateTime? m3_BSCT = null, 
			decimal? m3_BSTD = null, 
			decimal? m3_BSTC = null, 
			string m3_BSRE = null, 
			string m3_BSRX = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_STMN))
				throw new ArgumentNullException("m3_STMN");
			if (string.IsNullOrWhiteSpace(m3_BSID))
				throw new ArgumentNullException("m3_BSID");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BSTY", m3_BSTY.ToString())
				.WithQueryParameter("STMN", m3_STMN.Trim())
				.WithQueryParameter("BSID", m3_BSID.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_BSOB.HasValue)
				request.WithQueryParameter("BSOB", m3_BSOB.Value.ToString());
			if (m3_BSOT.HasValue)
				request.WithQueryParameter("BSOT", m3_BSOT.Value.ToM3String());
			if (m3_BSCB.HasValue)
				request.WithQueryParameter("BSCB", m3_BSCB.Value.ToString());
			if (m3_BSCT.HasValue)
				request.WithQueryParameter("BSCT", m3_BSCT.Value.ToM3String());
			if (m3_BSTD.HasValue)
				request.WithQueryParameter("BSTD", m3_BSTD.Value.ToString());
			if (m3_BSTC.HasValue)
				request.WithQueryParameter("BSTC", m3_BSTC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BSRE))
				request.WithQueryParameter("BSRE", m3_BSRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BSRX))
				request.WithQueryParameter("BSRX", m3_BSRX.Trim());

			// Execute the request
			var result = await Execute<AddStatmtHeadResponse>(
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
		/// Name AddStatmtLine
		/// Description Add statement line
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BLSN">Sequence number (Required)</param>
		/// <param name="m3_BLLF">Line amount Cur (Required)</param>
		/// <param name="m3_JBNO">Job number (Required)</param>
		/// <param name="m3_JBDT">Job date (Required)</param>
		/// <param name="m3_JBTM">Job time (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_BLLT">Statement line type</param>
		/// <param name="m3_BLBS">Bank statment bank no</param>
		/// <param name="m3_CUCD">Currency code</param>
		/// <param name="m3_ARAT">Exchange rate</param>
		/// <param name="m3_BLLL">Line amount Loc</param>
		/// <param name="m3_BLAN">Payer / Payee bank account number</param>
		/// <param name="m3_CURD">Value date</param>
		/// <param name="m3_ACDT">Accounting date</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_SPYN">Payee</param>
		/// <param name="m3_AIN1">Payer / Payee- Info 1</param>
		/// <param name="m3_AIN2">Payer / Payee- Info 2</param>
		/// <param name="m3_AIN3">Payer / Payee- Info 3</param>
		/// <param name="m3_ABNO">Bank reference</param>
		/// <param name="m3_RIMA">Primanota</param>
		/// <param name="m3_ECCD">Record code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddStatmtLineResponse></returns>
		/// <exception cref="M3Exception<AddStatmtLineResponse>"></exception>
		public async Task<M3Response<AddStatmtLineResponse>> AddStatmtLine(
			string m3_DIVI, 
			int m3_BLSN, 
			decimal m3_BLLF, 
			int m3_JBNO, 
			DateTime m3_JBDT, 
			int m3_JBTM, 
			int? m3_CONO = null, 
			int? m3_BLLT = null, 
			string m3_BLBS = null, 
			string m3_CUCD = null, 
			decimal? m3_ARAT = null, 
			decimal? m3_BLLL = null, 
			string m3_BLAN = null, 
			DateTime? m3_CURD = null, 
			DateTime? m3_ACDT = null, 
			string m3_PYNO = null, 
			string m3_SPYN = null, 
			string m3_AIN1 = null, 
			string m3_AIN2 = null, 
			string m3_AIN3 = null, 
			string m3_ABNO = null, 
			string m3_RIMA = null, 
			string m3_ECCD = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BLSN", m3_BLSN.ToString())
				.WithQueryParameter("BLLF", m3_BLLF.ToString())
				.WithQueryParameter("JBNO", m3_JBNO.ToString())
				.WithQueryParameter("JBDT", m3_JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3_JBTM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_BLLT.HasValue)
				request.WithQueryParameter("BLLT", m3_BLLT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BLBS))
				request.WithQueryParameter("BLBS", m3_BLBS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3_ARAT.Value.ToString());
			if (m3_BLLL.HasValue)
				request.WithQueryParameter("BLLL", m3_BLLL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BLAN))
				request.WithQueryParameter("BLAN", m3_BLAN.Trim());
			if (m3_CURD.HasValue)
				request.WithQueryParameter("CURD", m3_CURD.Value.ToM3String());
			if (m3_ACDT.HasValue)
				request.WithQueryParameter("ACDT", m3_ACDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPYN))
				request.WithQueryParameter("SPYN", m3_SPYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIN1))
				request.WithQueryParameter("AIN1", m3_AIN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIN2))
				request.WithQueryParameter("AIN2", m3_AIN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIN3))
				request.WithQueryParameter("AIN3", m3_AIN3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ABNO))
				request.WithQueryParameter("ABNO", m3_ABNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RIMA))
				request.WithQueryParameter("RIMA", m3_RIMA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECCD))
				request.WithQueryParameter("ECCD", m3_ECCD.Trim());

			// Execute the request
			var result = await Execute<AddStatmtLineResponse>(
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
		/// Name GetBankIdent
		/// Description Get bank identifier
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BSID">Bank identifier (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBankIdentResponse></returns>
		/// <exception cref="M3Exception<GetBankIdentResponse>"></exception>
		public async Task<M3Response<GetBankIdentResponse>> GetBankIdent(
			string m3_DIVI, 
			string m3_BSID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBankIdent",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BSID))
				throw new ArgumentNullException("m3_BSID");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BSID", m3_BSID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetBankIdentResponse>(
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
		/// Name UpdStatmtAdditi
		/// Description Update statement additional information
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BLSN">Sequence number (Required)</param>
		/// <param name="m3_BLAI">Additional information number (Required)</param>
		/// <param name="m3_JBNO">Job number (Required)</param>
		/// <param name="m3_JBDT">Job date (Required)</param>
		/// <param name="m3_JBTM">Job time (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_BLFX">Free text field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdStatmtAdditi(
			string m3_DIVI, 
			int m3_BLSN, 
			int m3_BLAI, 
			int m3_JBNO, 
			DateTime m3_JBDT, 
			int m3_JBTM, 
			int? m3_CONO = null, 
			string m3_BLFX = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BLSN", m3_BLSN.ToString())
				.WithQueryParameter("BLAI", m3_BLAI.ToString())
				.WithQueryParameter("JBNO", m3_JBNO.ToString())
				.WithQueryParameter("JBDT", m3_JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3_JBTM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BLFX))
				request.WithQueryParameter("BLFX", m3_BLFX.Trim());

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
		/// Name UpdStatmtDetail
		/// Description Update statement detail
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_JBNO">Job number (Required)</param>
		/// <param name="m3_JBDT">Job date (Required)</param>
		/// <param name="m3_JBTM">Job time (Required)</param>
		/// <param name="m3_BLSN">Sequence number (Required)</param>
		/// <param name="m3_BLSS">Sequence sub no (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_BLTT">Transaction type</param>
		/// <param name="m3_BLBC">Business transaction code</param>
		/// <param name="m3_BLTX">Transaction text</param>
		/// <param name="m3_BLDC">Debit-credit code</param>
		/// <param name="m3_BLNF">Net amount Cur</param>
		/// <param name="m3_BLNL">Net amount Loc</param>
		/// <param name="m3_CINO">Invoice  no AR</param>
		/// <param name="m3_SINO">Invoice no AP</param>
		/// <param name="m3_INYR">Invoice year</param>
		/// <param name="m3_EXN1">GL information number</param>
		/// <param name="m3_EXI1">GL additiona information</param>
		/// <param name="m3_EXN2">GL information number</param>
		/// <param name="m3_EXI2">GL additional information</param>
		/// <param name="m3_EXN3">GL information number</param>
		/// <param name="m3_EXI3">GL additional information</param>
		/// <param name="m3_EXN4">GL information number</param>
		/// <param name="m3_EXI4">GL additional information</param>
		/// <param name="m3_EXN5">GL information number</param>
		/// <param name="m3_EXI5">GL additional information</param>
		/// <param name="m3_IRNO">Payment reference number</param>
		/// <param name="m3_ODIV">Original division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdStatmtDetail(
			string m3_DIVI, 
			int m3_JBNO, 
			DateTime m3_JBDT, 
			int m3_JBTM, 
			int m3_BLSN, 
			int m3_BLSS, 
			int? m3_CONO = null, 
			string m3_BLTT = null, 
			string m3_BLBC = null, 
			string m3_BLTX = null, 
			string m3_BLDC = null, 
			decimal? m3_BLNF = null, 
			decimal? m3_BLNL = null, 
			string m3_CINO = null, 
			string m3_SINO = null, 
			int? m3_INYR = null, 
			int? m3_EXN1 = null, 
			string m3_EXI1 = null, 
			int? m3_EXN2 = null, 
			string m3_EXI2 = null, 
			int? m3_EXN3 = null, 
			string m3_EXI3 = null, 
			int? m3_EXN4 = null, 
			string m3_EXI4 = null, 
			int? m3_EXN5 = null, 
			string m3_EXI5 = null, 
			string m3_IRNO = null, 
			string m3_ODIV = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("JBNO", m3_JBNO.ToString())
				.WithQueryParameter("JBDT", m3_JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3_JBTM.ToString())
				.WithQueryParameter("BLSN", m3_BLSN.ToString())
				.WithQueryParameter("BLSS", m3_BLSS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BLTT))
				request.WithQueryParameter("BLTT", m3_BLTT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BLBC))
				request.WithQueryParameter("BLBC", m3_BLBC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BLTX))
				request.WithQueryParameter("BLTX", m3_BLTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BLDC))
				request.WithQueryParameter("BLDC", m3_BLDC.Trim());
			if (m3_BLNF.HasValue)
				request.WithQueryParameter("BLNF", m3_BLNF.Value.ToString());
			if (m3_BLNL.HasValue)
				request.WithQueryParameter("BLNL", m3_BLNL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CINO))
				request.WithQueryParameter("CINO", m3_CINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SINO))
				request.WithQueryParameter("SINO", m3_SINO.Trim());
			if (m3_INYR.HasValue)
				request.WithQueryParameter("INYR", m3_INYR.Value.ToString());
			if (m3_EXN1.HasValue)
				request.WithQueryParameter("EXN1", m3_EXN1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EXI1))
				request.WithQueryParameter("EXI1", m3_EXI1.Trim());
			if (m3_EXN2.HasValue)
				request.WithQueryParameter("EXN2", m3_EXN2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EXI2))
				request.WithQueryParameter("EXI2", m3_EXI2.Trim());
			if (m3_EXN3.HasValue)
				request.WithQueryParameter("EXN3", m3_EXN3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EXI3))
				request.WithQueryParameter("EXI3", m3_EXI3.Trim());
			if (m3_EXN4.HasValue)
				request.WithQueryParameter("EXN4", m3_EXN4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EXI4))
				request.WithQueryParameter("EXI4", m3_EXI4.Trim());
			if (m3_EXN5.HasValue)
				request.WithQueryParameter("EXN5", m3_EXN5.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EXI5))
				request.WithQueryParameter("EXI5", m3_EXI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IRNO))
				request.WithQueryParameter("IRNO", m3_IRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ODIV))
				request.WithQueryParameter("ODIV", m3_ODIV.Trim());

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
		/// Name UpdStatmtHead
		/// Description Update statement head
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_JBNO">Job number (Required)</param>
		/// <param name="m3_JBDT">Job date (Required)</param>
		/// <param name="m3_JBTM">Job time (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_BSCB">Closing balance (Currency)</param>
		/// <param name="m3_BSCT">Closing balance date</param>
		/// <param name="m3_BSTD">Total amount - Debit (Currency)</param>
		/// <param name="m3_BSTC">Total amount - Credit (Currency)</param>
		/// <param name="m3_STMN">Bank statement no</param>
		/// <param name="m3_BSOT">Opening balance date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdStatmtHead(
			string m3_DIVI, 
			int m3_JBNO, 
			DateTime m3_JBDT, 
			int m3_JBTM, 
			int? m3_CONO = null, 
			decimal? m3_BSCB = null, 
			DateTime? m3_BSCT = null, 
			decimal? m3_BSTD = null, 
			decimal? m3_BSTC = null, 
			string m3_STMN = null, 
			DateTime? m3_BSOT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("JBNO", m3_JBNO.ToString())
				.WithQueryParameter("JBDT", m3_JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3_JBTM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_BSCB.HasValue)
				request.WithQueryParameter("BSCB", m3_BSCB.Value.ToString());
			if (m3_BSCT.HasValue)
				request.WithQueryParameter("BSCT", m3_BSCT.Value.ToM3String());
			if (m3_BSTD.HasValue)
				request.WithQueryParameter("BSTD", m3_BSTD.Value.ToString());
			if (m3_BSTC.HasValue)
				request.WithQueryParameter("BSTC", m3_BSTC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STMN))
				request.WithQueryParameter("STMN", m3_STMN.Trim());
			if (m3_BSOT.HasValue)
				request.WithQueryParameter("BSOT", m3_BSOT.Value.ToM3String());

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
		/// Name UpdStatmtLine
		/// Description Update statement line
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_JBNO">Job number (Required)</param>
		/// <param name="m3_JBDT">Job date (Required)</param>
		/// <param name="m3_JBTM">Job time (Required)</param>
		/// <param name="m3_BLSN">Sequence number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_BLLT">Statement line type</param>
		/// <param name="m3_BLBS">Bank statement bank no</param>
		/// <param name="m3_CUCD">Currency code</param>
		/// <param name="m3_ARAT">Exchange rate</param>
		/// <param name="m3_BLLF">Line amount Cur</param>
		/// <param name="m3_BLLL">Line amount Loc</param>
		/// <param name="m3_BLAN">Payer/Payee bank account</param>
		/// <param name="m3_CURD">Value date</param>
		/// <param name="m3_ACDT">Accounting date</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_SPYN">Payee</param>
		/// <param name="m3_AIN1">Payer/Payee- Info 1</param>
		/// <param name="m3_AIN2">Payer/Payee- Info 2</param>
		/// <param name="m3_AIN3">Payer/Payee- Info 3</param>
		/// <param name="m3_ABNO">Bank reference</param>
		/// <param name="m3_RIMA">Primanota</param>
		/// <param name="m3_ECCD">Record code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdStatmtLine(
			string m3_DIVI, 
			int m3_JBNO, 
			DateTime m3_JBDT, 
			int m3_JBTM, 
			int m3_BLSN, 
			int? m3_CONO = null, 
			int? m3_BLLT = null, 
			string m3_BLBS = null, 
			string m3_CUCD = null, 
			decimal? m3_ARAT = null, 
			decimal? m3_BLLF = null, 
			decimal? m3_BLLL = null, 
			string m3_BLAN = null, 
			DateTime? m3_CURD = null, 
			DateTime? m3_ACDT = null, 
			string m3_PYNO = null, 
			string m3_SPYN = null, 
			string m3_AIN1 = null, 
			string m3_AIN2 = null, 
			string m3_AIN3 = null, 
			string m3_ABNO = null, 
			string m3_RIMA = null, 
			string m3_ECCD = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("JBNO", m3_JBNO.ToString())
				.WithQueryParameter("JBDT", m3_JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3_JBTM.ToString())
				.WithQueryParameter("BLSN", m3_BLSN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_BLLT.HasValue)
				request.WithQueryParameter("BLLT", m3_BLLT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BLBS))
				request.WithQueryParameter("BLBS", m3_BLBS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3_ARAT.Value.ToString());
			if (m3_BLLF.HasValue)
				request.WithQueryParameter("BLLF", m3_BLLF.Value.ToString());
			if (m3_BLLL.HasValue)
				request.WithQueryParameter("BLLL", m3_BLLL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BLAN))
				request.WithQueryParameter("BLAN", m3_BLAN.Trim());
			if (m3_CURD.HasValue)
				request.WithQueryParameter("CURD", m3_CURD.Value.ToM3String());
			if (m3_ACDT.HasValue)
				request.WithQueryParameter("ACDT", m3_ACDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPYN))
				request.WithQueryParameter("SPYN", m3_SPYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIN1))
				request.WithQueryParameter("AIN1", m3_AIN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIN2))
				request.WithQueryParameter("AIN2", m3_AIN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIN3))
				request.WithQueryParameter("AIN3", m3_AIN3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ABNO))
				request.WithQueryParameter("ABNO", m3_ABNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RIMA))
				request.WithQueryParameter("RIMA", m3_RIMA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECCD))
				request.WithQueryParameter("ECCD", m3_ECCD.Trim());

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
		/// Name UpdStatmtStatus
		/// Description Update statement status
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_JBNO">Job number (Required)</param>
		/// <param name="m3_JBDT">Job date (Required)</param>
		/// <param name="m3_JBTM">Job time (Required)</param>
		/// <param name="m3_BSHS">Bank statement status (Required)</param>
		/// <param name="m3_BSHB">Blocked (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdStatmtStatus(
			string m3_DIVI, 
			int m3_JBNO, 
			DateTime m3_JBDT, 
			int m3_JBTM, 
			int m3_BSHS, 
			int m3_BSHB, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdStatmtStatus",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("JBNO", m3_JBNO.ToString())
				.WithQueryParameter("JBDT", m3_JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3_JBTM.ToString())
				.WithQueryParameter("BSHS", m3_BSHS.ToString())
				.WithQueryParameter("BSHB", m3_BSHB.ToString());

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
	}
}
// EOF
