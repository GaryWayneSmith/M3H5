/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.GLS180MI;
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
	/// Name: GLS180MI
	/// Component Name: BankStatement
	/// Description: Bank statement reconciliation interface
	/// Version Release: 5ea3
	///</summary>
	public partial class GLS180MIResource : M3BaseResourceEndpoint
	{
		public GLS180MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "GLS180MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddHead
		/// Description Add Head information
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_STMN">Statement number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_AIT1">Accounting dimension 1</param>
		/// <param name="m3_BKID">Bank account identity</param>
		/// <param name="m3_BAF1">Bank account field 1</param>
		/// <param name="m3_BAF2">Bank account field 2</param>
		/// <param name="m3_BAF3">Bank account field 3</param>
		/// <param name="m3_BAF4">Bank account field 4</param>
		/// <param name="m3_BAF5">Bank account field 5</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_FRDT">From date</param>
		/// <param name="m3_TODT">To date</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_PSAD">Previous statement of account date</param>
		/// <param name="m3_SDRC">Statement of account date</param>
		/// <param name="m3_OBST">Opening balance on statement</param>
		/// <param name="m3_CBST">Closing balance on statement</param>
		/// <param name="m3_IDAC">Invert Debit and Credit</param>
		/// <param name="m3_RGDT">Entry date</param>
		/// <param name="m3_RGTM">Entry time</param>
		/// <param name="m3_CHID">Changed by</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddHeadResponse></returns>
		/// <exception cref="M3Exception<AddHeadResponse>"></exception>
		public async Task<M3Response<AddHeadResponse>> AddHead(
			string m3_DIVI, 
			string m3_STMN, 
			int? m3_CONO = null, 
			string m3_AIT1 = null, 
			string m3_BKID = null, 
			string m3_BAF1 = null, 
			string m3_BAF2 = null, 
			string m3_BAF3 = null, 
			string m3_BAF4 = null, 
			string m3_BAF5 = null, 
			DateTime? m3_STDT = null, 
			DateTime? m3_FRDT = null, 
			DateTime? m3_TODT = null, 
			string m3_TX40 = null, 
			DateTime? m3_PSAD = null, 
			DateTime? m3_SDRC = null, 
			decimal? m3_OBST = null, 
			decimal? m3_CBST = null, 
			int? m3_IDAC = null, 
			DateTime? m3_RGDT = null, 
			int? m3_RGTM = null, 
			string m3_CHID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_STMN))
				throw new ArgumentNullException("m3_STMN");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("STMN", m3_STMN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AIT1))
				request.WithQueryParameter("AIT1", m3_AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKID))
				request.WithQueryParameter("BKID", m3_BKID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF1))
				request.WithQueryParameter("BAF1", m3_BAF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF2))
				request.WithQueryParameter("BAF2", m3_BAF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF3))
				request.WithQueryParameter("BAF3", m3_BAF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF4))
				request.WithQueryParameter("BAF4", m3_BAF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF5))
				request.WithQueryParameter("BAF5", m3_BAF5.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3_FRDT.Value.ToM3String());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (m3_PSAD.HasValue)
				request.WithQueryParameter("PSAD", m3_PSAD.Value.ToM3String());
			if (m3_SDRC.HasValue)
				request.WithQueryParameter("SDRC", m3_SDRC.Value.ToM3String());
			if (m3_OBST.HasValue)
				request.WithQueryParameter("OBST", m3_OBST.Value.ToString());
			if (m3_CBST.HasValue)
				request.WithQueryParameter("CBST", m3_CBST.Value.ToString());
			if (m3_IDAC.HasValue)
				request.WithQueryParameter("IDAC", m3_IDAC.Value.ToString());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3_RGTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());

			// Execute the request
			var result = await Execute<AddHeadResponse>(
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
		/// Name AddHeadRecord
		/// Description Add Header record
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_STMN">Statement number (Required)</param>
		/// <param name="m3_SDRC">Statement of account date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_AIT1">Accounting dimension 1</param>
		/// <param name="m3_BKID">Bank account identity</param>
		/// <param name="m3_BAF1">Bank account field 1</param>
		/// <param name="m3_BAF2">Bank account field 2</param>
		/// <param name="m3_BAF3">Bank account field 3</param>
		/// <param name="m3_BAF4">Bank account field 4</param>
		/// <param name="m3_BAF5">Bank account field 5</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_FRDT">From date</param>
		/// <param name="m3_TODT">To date</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_ERDT">External reconciliation date</param>
		/// <param name="m3_OBST">Opening balance on statement</param>
		/// <param name="m3_CBST">Closing balance on statement</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_IDAC">Invert Debit and Credit</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddHeadRecordResponse></returns>
		/// <exception cref="M3Exception<AddHeadRecordResponse>"></exception>
		public async Task<M3Response<AddHeadRecordResponse>> AddHeadRecord(
			string m3_STMN, 
			DateTime m3_SDRC, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_AIT1 = null, 
			string m3_BKID = null, 
			string m3_BAF1 = null, 
			string m3_BAF2 = null, 
			string m3_BAF3 = null, 
			string m3_BAF4 = null, 
			string m3_BAF5 = null, 
			DateTime? m3_STDT = null, 
			DateTime? m3_FRDT = null, 
			DateTime? m3_TODT = null, 
			string m3_TX40 = null, 
			string m3_STAT = null, 
			DateTime? m3_ERDT = null, 
			decimal? m3_OBST = null, 
			decimal? m3_CBST = null, 
			decimal? m3_TXID = null, 
			int? m3_IDAC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddHeadRecord",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STMN))
				throw new ArgumentNullException("m3_STMN");

			// Set mandatory parameters
			request
				.WithQueryParameter("STMN", m3_STMN.Trim())
				.WithQueryParameter("SDRC", m3_SDRC.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT1))
				request.WithQueryParameter("AIT1", m3_AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKID))
				request.WithQueryParameter("BKID", m3_BKID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF1))
				request.WithQueryParameter("BAF1", m3_BAF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF2))
				request.WithQueryParameter("BAF2", m3_BAF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF3))
				request.WithQueryParameter("BAF3", m3_BAF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF4))
				request.WithQueryParameter("BAF4", m3_BAF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF5))
				request.WithQueryParameter("BAF5", m3_BAF5.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3_FRDT.Value.ToM3String());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_ERDT.HasValue)
				request.WithQueryParameter("ERDT", m3_ERDT.Value.ToM3String());
			if (m3_OBST.HasValue)
				request.WithQueryParameter("OBST", m3_OBST.Value.ToString());
			if (m3_CBST.HasValue)
				request.WithQueryParameter("CBST", m3_CBST.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_IDAC.HasValue)
				request.WithQueryParameter("IDAC", m3_IDAC.Value.ToString());

			// Execute the request
			var result = await Execute<AddHeadRecordResponse>(
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
		/// Name AddHeadRecord2
		/// Description Add Header record
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_STMN">Statement number (Required)</param>
		/// <param name="m3_SDRC">Statement of account date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_AIT1">Accounting dimension 1</param>
		/// <param name="m3_BKID">Bank account identity</param>
		/// <param name="m3_IBAN">International bank account number</param>
		/// <param name="m3_BACN">Bank account number</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_FRDT">From date</param>
		/// <param name="m3_TODT">To date</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_ERDT">External reconciliation date</param>
		/// <param name="m3_OBST">Opening balance on statement</param>
		/// <param name="m3_CBST">Closing balance on statement</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_IDAC">Invert Debit and Credit</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddHeadRecord2Response></returns>
		/// <exception cref="M3Exception<AddHeadRecord2Response>"></exception>
		public async Task<M3Response<AddHeadRecord2Response>> AddHeadRecord2(
			string m3_STMN, 
			DateTime m3_SDRC, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_AIT1 = null, 
			string m3_BKID = null, 
			string m3_IBAN = null, 
			string m3_BACN = null, 
			DateTime? m3_STDT = null, 
			DateTime? m3_FRDT = null, 
			DateTime? m3_TODT = null, 
			string m3_TX40 = null, 
			string m3_STAT = null, 
			DateTime? m3_ERDT = null, 
			decimal? m3_OBST = null, 
			decimal? m3_CBST = null, 
			decimal? m3_TXID = null, 
			int? m3_IDAC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddHeadRecord2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STMN))
				throw new ArgumentNullException("m3_STMN");

			// Set mandatory parameters
			request
				.WithQueryParameter("STMN", m3_STMN.Trim())
				.WithQueryParameter("SDRC", m3_SDRC.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT1))
				request.WithQueryParameter("AIT1", m3_AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKID))
				request.WithQueryParameter("BKID", m3_BKID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IBAN))
				request.WithQueryParameter("IBAN", m3_IBAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BACN))
				request.WithQueryParameter("BACN", m3_BACN.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3_FRDT.Value.ToM3String());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_ERDT.HasValue)
				request.WithQueryParameter("ERDT", m3_ERDT.Value.ToM3String());
			if (m3_OBST.HasValue)
				request.WithQueryParameter("OBST", m3_OBST.Value.ToString());
			if (m3_CBST.HasValue)
				request.WithQueryParameter("CBST", m3_CBST.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_IDAC.HasValue)
				request.WithQueryParameter("IDAC", m3_IDAC.Value.ToString());

			// Execute the request
			var result = await Execute<AddHeadRecord2Response>(
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
		/// Name AddLine
		/// Description Add Line information
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_STMN">Statement number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_AIT1">Accounting dimension 1</param>
		/// <param name="m3_BKID">Bank account identity</param>
		/// <param name="m3_BAF1">Bank account field 1</param>
		/// <param name="m3_BAF2">Bank account field 2</param>
		/// <param name="m3_BAF3">Bank account field 3</param>
		/// <param name="m3_BAF4">Bank account field 4</param>
		/// <param name="m3_BAF5">Bank account field 5</param>
		/// <param name="m3_PSAD">Previous statement of account date</param>
		/// <param name="m3_SDRC">Statement of account date</param>
		/// <param name="m3_ACDT">Accounting date</param>
		/// <param name="m3_CURD">Value date</param>
		/// <param name="m3_CKNO">Check number</param>
		/// <param name="m3_BOPC">Bank operation</param>
		/// <param name="m3_DRRN">Drawee reference number</param>
		/// <param name="m3_OPAM">Open amount</param>
		/// <param name="m3_RFFD">Reference field</param>
		/// <param name="m3_BLAM">Bank currency amount</param>
		/// <param name="m3_IDAC">Invert Debit and Credit</param>
		/// <param name="m3_RGDT">Entry date</param>
		/// <param name="m3_RGTM">Entry time</param>
		/// <param name="m3_CHID">Changed by</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddLineResponse></returns>
		/// <exception cref="M3Exception<AddLineResponse>"></exception>
		public async Task<M3Response<AddLineResponse>> AddLine(
			string m3_DIVI, 
			string m3_STMN, 
			int? m3_CONO = null, 
			string m3_AIT1 = null, 
			string m3_BKID = null, 
			string m3_BAF1 = null, 
			string m3_BAF2 = null, 
			string m3_BAF3 = null, 
			string m3_BAF4 = null, 
			string m3_BAF5 = null, 
			DateTime? m3_PSAD = null, 
			DateTime? m3_SDRC = null, 
			DateTime? m3_ACDT = null, 
			DateTime? m3_CURD = null, 
			string m3_CKNO = null, 
			string m3_BOPC = null, 
			string m3_DRRN = null, 
			decimal? m3_OPAM = null, 
			string m3_RFFD = null, 
			decimal? m3_BLAM = null, 
			int? m3_IDAC = null, 
			DateTime? m3_RGDT = null, 
			int? m3_RGTM = null, 
			string m3_CHID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_STMN))
				throw new ArgumentNullException("m3_STMN");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("STMN", m3_STMN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AIT1))
				request.WithQueryParameter("AIT1", m3_AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKID))
				request.WithQueryParameter("BKID", m3_BKID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF1))
				request.WithQueryParameter("BAF1", m3_BAF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF2))
				request.WithQueryParameter("BAF2", m3_BAF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF3))
				request.WithQueryParameter("BAF3", m3_BAF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF4))
				request.WithQueryParameter("BAF4", m3_BAF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF5))
				request.WithQueryParameter("BAF5", m3_BAF5.Trim());
			if (m3_PSAD.HasValue)
				request.WithQueryParameter("PSAD", m3_PSAD.Value.ToM3String());
			if (m3_SDRC.HasValue)
				request.WithQueryParameter("SDRC", m3_SDRC.Value.ToM3String());
			if (m3_ACDT.HasValue)
				request.WithQueryParameter("ACDT", m3_ACDT.Value.ToM3String());
			if (m3_CURD.HasValue)
				request.WithQueryParameter("CURD", m3_CURD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CKNO))
				request.WithQueryParameter("CKNO", m3_CKNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BOPC))
				request.WithQueryParameter("BOPC", m3_BOPC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DRRN))
				request.WithQueryParameter("DRRN", m3_DRRN.Trim());
			if (m3_OPAM.HasValue)
				request.WithQueryParameter("OPAM", m3_OPAM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RFFD))
				request.WithQueryParameter("RFFD", m3_RFFD.Trim());
			if (m3_BLAM.HasValue)
				request.WithQueryParameter("BLAM", m3_BLAM.Value.ToString());
			if (m3_IDAC.HasValue)
				request.WithQueryParameter("IDAC", m3_IDAC.Value.ToString());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3_RGTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());

			// Execute the request
			var result = await Execute<AddLineResponse>(
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
		/// Name AddLineRecord
		/// Description Add Line record
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_BKID">Bank account identity (Required)</param>
		/// <param name="m3_SDRC">Statement of account date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_ACDT">Accounting date</param>
		/// <param name="m3_CURD">Value date</param>
		/// <param name="m3_CKNO">Check number</param>
		/// <param name="m3_BOPC">Bank operation code</param>
		/// <param name="m3_DRRN">Drawee reference number</param>
		/// <param name="m3_OPAM">Open amount</param>
		/// <param name="m3_RFFD">Reference field</param>
		/// <param name="m3_BLAM">Bank currency amount</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_IDAC">Invert Debit and Credit</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLineRecord(
			string m3_BKID, 
			DateTime m3_SDRC, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_STAT = null, 
			DateTime? m3_ACDT = null, 
			DateTime? m3_CURD = null, 
			string m3_CKNO = null, 
			string m3_BOPC = null, 
			string m3_DRRN = null, 
			decimal? m3_OPAM = null, 
			string m3_RFFD = null, 
			decimal? m3_BLAM = null, 
			decimal? m3_TXID = null, 
			int? m3_IDAC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLineRecord",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BKID))
				throw new ArgumentNullException("m3_BKID");

			// Set mandatory parameters
			request
				.WithQueryParameter("BKID", m3_BKID.Trim())
				.WithQueryParameter("SDRC", m3_SDRC.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_ACDT.HasValue)
				request.WithQueryParameter("ACDT", m3_ACDT.Value.ToM3String());
			if (m3_CURD.HasValue)
				request.WithQueryParameter("CURD", m3_CURD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CKNO))
				request.WithQueryParameter("CKNO", m3_CKNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BOPC))
				request.WithQueryParameter("BOPC", m3_BOPC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DRRN))
				request.WithQueryParameter("DRRN", m3_DRRN.Trim());
			if (m3_OPAM.HasValue)
				request.WithQueryParameter("OPAM", m3_OPAM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RFFD))
				request.WithQueryParameter("RFFD", m3_RFFD.Trim());
			if (m3_BLAM.HasValue)
				request.WithQueryParameter("BLAM", m3_BLAM.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_IDAC.HasValue)
				request.WithQueryParameter("IDAC", m3_IDAC.Value.ToString());

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
		/// Name DeleteStatement
		/// Description Delete Statement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_STMN">Statement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteStatement(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_STMN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeleteStatement",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STMN))
				request.WithQueryParameter("STMN", m3_STMN.Trim());

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
		/// Name UpdHead
		/// Description Update of Head information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_STMN">Statement number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_AIT1">Accounting dimension 1</param>
		/// <param name="m3_BKID">Bank account identity</param>
		/// <param name="m3_BAF1">Bank account field 1</param>
		/// <param name="m3_BAF2">Bank account field 2</param>
		/// <param name="m3_BAF3">Bank account field 3</param>
		/// <param name="m3_BAF4">Bank account field 4</param>
		/// <param name="m3_BAF5">Bank account field 5</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_FRDT">From date</param>
		/// <param name="m3_TODT">To date</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_PSAD">Previous statement of account date</param>
		/// <param name="m3_SDRC">Statement of account date</param>
		/// <param name="m3_OBST">Opening balance on statement</param>
		/// <param name="m3_CBST">Closing balance on statement</param>
		/// <param name="m3_IDAC">Invert Debit and Credit</param>
		/// <param name="m3_LMDT">Change date</param>
		/// <param name="m3_CHID">Changed by</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<UpdHeadResponse></returns>
		/// <exception cref="M3Exception<UpdHeadResponse>"></exception>
		public async Task<M3Response<UpdHeadResponse>> UpdHead(
			string m3_DIVI, 
			string m3_STMN, 
			int? m3_CONO = null, 
			string m3_AIT1 = null, 
			string m3_BKID = null, 
			string m3_BAF1 = null, 
			string m3_BAF2 = null, 
			string m3_BAF3 = null, 
			string m3_BAF4 = null, 
			string m3_BAF5 = null, 
			DateTime? m3_STDT = null, 
			DateTime? m3_FRDT = null, 
			DateTime? m3_TODT = null, 
			string m3_TX40 = null, 
			DateTime? m3_PSAD = null, 
			DateTime? m3_SDRC = null, 
			decimal? m3_OBST = null, 
			decimal? m3_CBST = null, 
			int? m3_IDAC = null, 
			DateTime? m3_LMDT = null, 
			string m3_CHID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_STMN))
				throw new ArgumentNullException("m3_STMN");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("STMN", m3_STMN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AIT1))
				request.WithQueryParameter("AIT1", m3_AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKID))
				request.WithQueryParameter("BKID", m3_BKID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF1))
				request.WithQueryParameter("BAF1", m3_BAF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF2))
				request.WithQueryParameter("BAF2", m3_BAF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF3))
				request.WithQueryParameter("BAF3", m3_BAF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF4))
				request.WithQueryParameter("BAF4", m3_BAF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF5))
				request.WithQueryParameter("BAF5", m3_BAF5.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3_FRDT.Value.ToM3String());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (m3_PSAD.HasValue)
				request.WithQueryParameter("PSAD", m3_PSAD.Value.ToM3String());
			if (m3_SDRC.HasValue)
				request.WithQueryParameter("SDRC", m3_SDRC.Value.ToM3String());
			if (m3_OBST.HasValue)
				request.WithQueryParameter("OBST", m3_OBST.Value.ToString());
			if (m3_CBST.HasValue)
				request.WithQueryParameter("CBST", m3_CBST.Value.ToString());
			if (m3_IDAC.HasValue)
				request.WithQueryParameter("IDAC", m3_IDAC.Value.ToString());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());

			// Execute the request
			var result = await Execute<UpdHeadResponse>(
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
		/// Name UpdHeadRecord
		/// Description Update Header record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_STMN">Statement number (Required)</param>
		/// <param name="m3_SDRC">Statement of account date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_AIT1">Accounting dimension 1</param>
		/// <param name="m3_BKID">Bank account identity</param>
		/// <param name="m3_BAF1">Bank account field 1</param>
		/// <param name="m3_BAF2">Bank account field 2</param>
		/// <param name="m3_BAF3">Bank account field 3</param>
		/// <param name="m3_BAF4">Bank account field 4</param>
		/// <param name="m3_BAF5">Bank account field 5</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_FRDT">From date</param>
		/// <param name="m3_TODT">To date</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_ERDT">External reconciliation date</param>
		/// <param name="m3_OBST">Opening balance on statement</param>
		/// <param name="m3_CBST">Closing balance on statement</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_IDAC">Invert Debit and Credit</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdHeadRecord(
			string m3_STMN, 
			DateTime m3_SDRC, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_AIT1 = null, 
			string m3_BKID = null, 
			string m3_BAF1 = null, 
			string m3_BAF2 = null, 
			string m3_BAF3 = null, 
			string m3_BAF4 = null, 
			string m3_BAF5 = null, 
			DateTime? m3_STDT = null, 
			DateTime? m3_FRDT = null, 
			DateTime? m3_TODT = null, 
			string m3_TX40 = null, 
			string m3_STAT = null, 
			DateTime? m3_ERDT = null, 
			decimal? m3_OBST = null, 
			decimal? m3_CBST = null, 
			decimal? m3_TXID = null, 
			int? m3_IDAC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdHeadRecord",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STMN))
				throw new ArgumentNullException("m3_STMN");

			// Set mandatory parameters
			request
				.WithQueryParameter("STMN", m3_STMN.Trim())
				.WithQueryParameter("SDRC", m3_SDRC.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT1))
				request.WithQueryParameter("AIT1", m3_AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKID))
				request.WithQueryParameter("BKID", m3_BKID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF1))
				request.WithQueryParameter("BAF1", m3_BAF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF2))
				request.WithQueryParameter("BAF2", m3_BAF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF3))
				request.WithQueryParameter("BAF3", m3_BAF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF4))
				request.WithQueryParameter("BAF4", m3_BAF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF5))
				request.WithQueryParameter("BAF5", m3_BAF5.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3_FRDT.Value.ToM3String());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_ERDT.HasValue)
				request.WithQueryParameter("ERDT", m3_ERDT.Value.ToM3String());
			if (m3_OBST.HasValue)
				request.WithQueryParameter("OBST", m3_OBST.Value.ToString());
			if (m3_CBST.HasValue)
				request.WithQueryParameter("CBST", m3_CBST.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_IDAC.HasValue)
				request.WithQueryParameter("IDAC", m3_IDAC.Value.ToString());

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
