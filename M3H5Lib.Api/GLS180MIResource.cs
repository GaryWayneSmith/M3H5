/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddHead
		/// Description Add Head information
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3STMN">Statement number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3AIT1">Accounting dimension 1</param>
		/// <param name="m3BKID">Bank account identity</param>
		/// <param name="m3BAF1">Bank account field 1</param>
		/// <param name="m3BAF2">Bank account field 2</param>
		/// <param name="m3BAF3">Bank account field 3</param>
		/// <param name="m3BAF4">Bank account field 4</param>
		/// <param name="m3BAF5">Bank account field 5</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3FRDT">From date</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3PSAD">Previous statement of account date</param>
		/// <param name="m3SDRC">Statement of account date</param>
		/// <param name="m3OBST">Opening balance on statement</param>
		/// <param name="m3CBST">Closing balance on statement</param>
		/// <param name="m3IDAC">Invert Debit and Credit</param>
		/// <param name="m3RGDT">Entry date</param>
		/// <param name="m3RGTM">Entry time</param>
		/// <param name="m3CHID">Changed by</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddHeadResponse></returns>
		/// <exception cref="M3Exception<AddHeadResponse>"></exception>
		public async Task<M3Response<AddHeadResponse>> AddHead(
			string m3DIVI, 
			string m3STMN, 
			int? m3CONO = null, 
			string m3AIT1 = null, 
			string m3BKID = null, 
			string m3BAF1 = null, 
			string m3BAF2 = null, 
			string m3BAF3 = null, 
			string m3BAF4 = null, 
			string m3BAF5 = null, 
			DateTime? m3STDT = null, 
			DateTime? m3FRDT = null, 
			DateTime? m3TODT = null, 
			string m3TX40 = null, 
			DateTime? m3PSAD = null, 
			DateTime? m3SDRC = null, 
			decimal? m3OBST = null, 
			decimal? m3CBST = null, 
			int? m3IDAC = null, 
			DateTime? m3RGDT = null, 
			int? m3RGTM = null, 
			string m3CHID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3STMN))
				throw new ArgumentNullException(nameof(m3STMN));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("STMN", m3STMN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AIT1))
				request.WithQueryParameter("AIT1", m3AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKID))
				request.WithQueryParameter("BKID", m3BKID.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF1))
				request.WithQueryParameter("BAF1", m3BAF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF2))
				request.WithQueryParameter("BAF2", m3BAF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF3))
				request.WithQueryParameter("BAF3", m3BAF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF4))
				request.WithQueryParameter("BAF4", m3BAF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF5))
				request.WithQueryParameter("BAF5", m3BAF5.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3FRDT.Value.ToM3String());
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (m3PSAD.HasValue)
				request.WithQueryParameter("PSAD", m3PSAD.Value.ToM3String());
			if (m3SDRC.HasValue)
				request.WithQueryParameter("SDRC", m3SDRC.Value.ToM3String());
			if (m3OBST.HasValue)
				request.WithQueryParameter("OBST", m3OBST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CBST.HasValue)
				request.WithQueryParameter("CBST", m3CBST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IDAC.HasValue)
				request.WithQueryParameter("IDAC", m3IDAC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3RGTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());

			// Execute the request
			var result = await Execute<AddHeadResponse>(
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
		/// Name AddHeadRecord
		/// Description Add Header record
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3STMN">Statement number (Required)</param>
		/// <param name="m3SDRC">Statement of account date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3AIT1">Accounting dimension 1</param>
		/// <param name="m3BKID">Bank account identity</param>
		/// <param name="m3BAF1">Bank account field 1</param>
		/// <param name="m3BAF2">Bank account field 2</param>
		/// <param name="m3BAF3">Bank account field 3</param>
		/// <param name="m3BAF4">Bank account field 4</param>
		/// <param name="m3BAF5">Bank account field 5</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3FRDT">From date</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3ERDT">External reconciliation date</param>
		/// <param name="m3OBST">Opening balance on statement</param>
		/// <param name="m3CBST">Closing balance on statement</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3IDAC">Invert Debit and Credit</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddHeadRecordResponse></returns>
		/// <exception cref="M3Exception<AddHeadRecordResponse>"></exception>
		public async Task<M3Response<AddHeadRecordResponse>> AddHeadRecord(
			string m3STMN, 
			DateTime m3SDRC, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3AIT1 = null, 
			string m3BKID = null, 
			string m3BAF1 = null, 
			string m3BAF2 = null, 
			string m3BAF3 = null, 
			string m3BAF4 = null, 
			string m3BAF5 = null, 
			DateTime? m3STDT = null, 
			DateTime? m3FRDT = null, 
			DateTime? m3TODT = null, 
			string m3TX40 = null, 
			string m3STAT = null, 
			DateTime? m3ERDT = null, 
			decimal? m3OBST = null, 
			decimal? m3CBST = null, 
			decimal? m3TXID = null, 
			int? m3IDAC = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddHeadRecord",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STMN))
				throw new ArgumentNullException(nameof(m3STMN));

			// Set mandatory parameters
			request
				.WithQueryParameter("STMN", m3STMN.Trim())
				.WithQueryParameter("SDRC", m3SDRC.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT1))
				request.WithQueryParameter("AIT1", m3AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKID))
				request.WithQueryParameter("BKID", m3BKID.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF1))
				request.WithQueryParameter("BAF1", m3BAF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF2))
				request.WithQueryParameter("BAF2", m3BAF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF3))
				request.WithQueryParameter("BAF3", m3BAF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF4))
				request.WithQueryParameter("BAF4", m3BAF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF5))
				request.WithQueryParameter("BAF5", m3BAF5.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3FRDT.Value.ToM3String());
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3ERDT.HasValue)
				request.WithQueryParameter("ERDT", m3ERDT.Value.ToM3String());
			if (m3OBST.HasValue)
				request.WithQueryParameter("OBST", m3OBST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CBST.HasValue)
				request.WithQueryParameter("CBST", m3CBST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IDAC.HasValue)
				request.WithQueryParameter("IDAC", m3IDAC.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddHeadRecordResponse>(
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
		/// Name AddHeadRecord2
		/// Description Add Header record
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3STMN">Statement number (Required)</param>
		/// <param name="m3SDRC">Statement of account date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3AIT1">Accounting dimension 1</param>
		/// <param name="m3BKID">Bank account identity</param>
		/// <param name="m3IBAN">International bank account number</param>
		/// <param name="m3BACN">Bank account number</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3FRDT">From date</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3ERDT">External reconciliation date</param>
		/// <param name="m3OBST">Opening balance on statement</param>
		/// <param name="m3CBST">Closing balance on statement</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3IDAC">Invert Debit and Credit</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddHeadRecord2Response></returns>
		/// <exception cref="M3Exception<AddHeadRecord2Response>"></exception>
		public async Task<M3Response<AddHeadRecord2Response>> AddHeadRecord2(
			string m3STMN, 
			DateTime m3SDRC, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3AIT1 = null, 
			string m3BKID = null, 
			string m3IBAN = null, 
			string m3BACN = null, 
			DateTime? m3STDT = null, 
			DateTime? m3FRDT = null, 
			DateTime? m3TODT = null, 
			string m3TX40 = null, 
			string m3STAT = null, 
			DateTime? m3ERDT = null, 
			decimal? m3OBST = null, 
			decimal? m3CBST = null, 
			decimal? m3TXID = null, 
			int? m3IDAC = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddHeadRecord2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STMN))
				throw new ArgumentNullException(nameof(m3STMN));

			// Set mandatory parameters
			request
				.WithQueryParameter("STMN", m3STMN.Trim())
				.WithQueryParameter("SDRC", m3SDRC.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT1))
				request.WithQueryParameter("AIT1", m3AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKID))
				request.WithQueryParameter("BKID", m3BKID.Trim());
			if (!string.IsNullOrWhiteSpace(m3IBAN))
				request.WithQueryParameter("IBAN", m3IBAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3BACN))
				request.WithQueryParameter("BACN", m3BACN.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3FRDT.Value.ToM3String());
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3ERDT.HasValue)
				request.WithQueryParameter("ERDT", m3ERDT.Value.ToM3String());
			if (m3OBST.HasValue)
				request.WithQueryParameter("OBST", m3OBST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CBST.HasValue)
				request.WithQueryParameter("CBST", m3CBST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IDAC.HasValue)
				request.WithQueryParameter("IDAC", m3IDAC.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddHeadRecord2Response>(
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
		/// Name AddLine
		/// Description Add Line information
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3STMN">Statement number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3AIT1">Accounting dimension 1</param>
		/// <param name="m3BKID">Bank account identity</param>
		/// <param name="m3BAF1">Bank account field 1</param>
		/// <param name="m3BAF2">Bank account field 2</param>
		/// <param name="m3BAF3">Bank account field 3</param>
		/// <param name="m3BAF4">Bank account field 4</param>
		/// <param name="m3BAF5">Bank account field 5</param>
		/// <param name="m3PSAD">Previous statement of account date</param>
		/// <param name="m3SDRC">Statement of account date</param>
		/// <param name="m3ACDT">Accounting date</param>
		/// <param name="m3CURD">Value date</param>
		/// <param name="m3CKNO">Check number</param>
		/// <param name="m3BOPC">Bank operation</param>
		/// <param name="m3DRRN">Drawee reference number</param>
		/// <param name="m3OPAM">Open amount</param>
		/// <param name="m3RFFD">Reference field</param>
		/// <param name="m3BLAM">Bank currency amount</param>
		/// <param name="m3IDAC">Invert Debit and Credit</param>
		/// <param name="m3RGDT">Entry date</param>
		/// <param name="m3RGTM">Entry time</param>
		/// <param name="m3CHID">Changed by</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddLineResponse></returns>
		/// <exception cref="M3Exception<AddLineResponse>"></exception>
		public async Task<M3Response<AddLineResponse>> AddLine(
			string m3DIVI, 
			string m3STMN, 
			int? m3CONO = null, 
			string m3AIT1 = null, 
			string m3BKID = null, 
			string m3BAF1 = null, 
			string m3BAF2 = null, 
			string m3BAF3 = null, 
			string m3BAF4 = null, 
			string m3BAF5 = null, 
			DateTime? m3PSAD = null, 
			DateTime? m3SDRC = null, 
			DateTime? m3ACDT = null, 
			DateTime? m3CURD = null, 
			string m3CKNO = null, 
			string m3BOPC = null, 
			string m3DRRN = null, 
			decimal? m3OPAM = null, 
			string m3RFFD = null, 
			decimal? m3BLAM = null, 
			int? m3IDAC = null, 
			DateTime? m3RGDT = null, 
			int? m3RGTM = null, 
			string m3CHID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3STMN))
				throw new ArgumentNullException(nameof(m3STMN));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("STMN", m3STMN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AIT1))
				request.WithQueryParameter("AIT1", m3AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKID))
				request.WithQueryParameter("BKID", m3BKID.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF1))
				request.WithQueryParameter("BAF1", m3BAF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF2))
				request.WithQueryParameter("BAF2", m3BAF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF3))
				request.WithQueryParameter("BAF3", m3BAF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF4))
				request.WithQueryParameter("BAF4", m3BAF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF5))
				request.WithQueryParameter("BAF5", m3BAF5.Trim());
			if (m3PSAD.HasValue)
				request.WithQueryParameter("PSAD", m3PSAD.Value.ToM3String());
			if (m3SDRC.HasValue)
				request.WithQueryParameter("SDRC", m3SDRC.Value.ToM3String());
			if (m3ACDT.HasValue)
				request.WithQueryParameter("ACDT", m3ACDT.Value.ToM3String());
			if (m3CURD.HasValue)
				request.WithQueryParameter("CURD", m3CURD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CKNO))
				request.WithQueryParameter("CKNO", m3CKNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BOPC))
				request.WithQueryParameter("BOPC", m3BOPC.Trim());
			if (!string.IsNullOrWhiteSpace(m3DRRN))
				request.WithQueryParameter("DRRN", m3DRRN.Trim());
			if (m3OPAM.HasValue)
				request.WithQueryParameter("OPAM", m3OPAM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RFFD))
				request.WithQueryParameter("RFFD", m3RFFD.Trim());
			if (m3BLAM.HasValue)
				request.WithQueryParameter("BLAM", m3BLAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IDAC.HasValue)
				request.WithQueryParameter("IDAC", m3IDAC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3RGTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());

			// Execute the request
			var result = await Execute<AddLineResponse>(
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
		/// Name AddLineRecord
		/// Description Add Line record
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3BKID">Bank account identity (Required)</param>
		/// <param name="m3SDRC">Statement of account date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3ACDT">Accounting date</param>
		/// <param name="m3CURD">Value date</param>
		/// <param name="m3CKNO">Check number</param>
		/// <param name="m3BOPC">Bank operation code</param>
		/// <param name="m3DRRN">Drawee reference number</param>
		/// <param name="m3OPAM">Open amount</param>
		/// <param name="m3RFFD">Reference field</param>
		/// <param name="m3BLAM">Bank currency amount</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3IDAC">Invert Debit and Credit</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLineRecord(
			string m3BKID, 
			DateTime m3SDRC, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3STAT = null, 
			DateTime? m3ACDT = null, 
			DateTime? m3CURD = null, 
			string m3CKNO = null, 
			string m3BOPC = null, 
			string m3DRRN = null, 
			decimal? m3OPAM = null, 
			string m3RFFD = null, 
			decimal? m3BLAM = null, 
			decimal? m3TXID = null, 
			int? m3IDAC = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddLineRecord",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BKID))
				throw new ArgumentNullException(nameof(m3BKID));

			// Set mandatory parameters
			request
				.WithQueryParameter("BKID", m3BKID.Trim())
				.WithQueryParameter("SDRC", m3SDRC.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3ACDT.HasValue)
				request.WithQueryParameter("ACDT", m3ACDT.Value.ToM3String());
			if (m3CURD.HasValue)
				request.WithQueryParameter("CURD", m3CURD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CKNO))
				request.WithQueryParameter("CKNO", m3CKNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BOPC))
				request.WithQueryParameter("BOPC", m3BOPC.Trim());
			if (!string.IsNullOrWhiteSpace(m3DRRN))
				request.WithQueryParameter("DRRN", m3DRRN.Trim());
			if (m3OPAM.HasValue)
				request.WithQueryParameter("OPAM", m3OPAM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RFFD))
				request.WithQueryParameter("RFFD", m3RFFD.Trim());
			if (m3BLAM.HasValue)
				request.WithQueryParameter("BLAM", m3BLAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IDAC.HasValue)
				request.WithQueryParameter("IDAC", m3IDAC.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DeleteStatement
		/// Description Delete Statement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3STMN">Statement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteStatement(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3STMN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DeleteStatement",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STMN))
				request.WithQueryParameter("STMN", m3STMN.Trim());

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
		/// Name UpdHead
		/// Description Update of Head information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3STMN">Statement number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3AIT1">Accounting dimension 1</param>
		/// <param name="m3BKID">Bank account identity</param>
		/// <param name="m3BAF1">Bank account field 1</param>
		/// <param name="m3BAF2">Bank account field 2</param>
		/// <param name="m3BAF3">Bank account field 3</param>
		/// <param name="m3BAF4">Bank account field 4</param>
		/// <param name="m3BAF5">Bank account field 5</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3FRDT">From date</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3PSAD">Previous statement of account date</param>
		/// <param name="m3SDRC">Statement of account date</param>
		/// <param name="m3OBST">Opening balance on statement</param>
		/// <param name="m3CBST">Closing balance on statement</param>
		/// <param name="m3IDAC">Invert Debit and Credit</param>
		/// <param name="m3LMDT">Change date</param>
		/// <param name="m3CHID">Changed by</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<UpdHeadResponse></returns>
		/// <exception cref="M3Exception<UpdHeadResponse>"></exception>
		public async Task<M3Response<UpdHeadResponse>> UpdHead(
			string m3DIVI, 
			string m3STMN, 
			int? m3CONO = null, 
			string m3AIT1 = null, 
			string m3BKID = null, 
			string m3BAF1 = null, 
			string m3BAF2 = null, 
			string m3BAF3 = null, 
			string m3BAF4 = null, 
			string m3BAF5 = null, 
			DateTime? m3STDT = null, 
			DateTime? m3FRDT = null, 
			DateTime? m3TODT = null, 
			string m3TX40 = null, 
			DateTime? m3PSAD = null, 
			DateTime? m3SDRC = null, 
			decimal? m3OBST = null, 
			decimal? m3CBST = null, 
			int? m3IDAC = null, 
			DateTime? m3LMDT = null, 
			string m3CHID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3STMN))
				throw new ArgumentNullException(nameof(m3STMN));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("STMN", m3STMN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AIT1))
				request.WithQueryParameter("AIT1", m3AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKID))
				request.WithQueryParameter("BKID", m3BKID.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF1))
				request.WithQueryParameter("BAF1", m3BAF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF2))
				request.WithQueryParameter("BAF2", m3BAF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF3))
				request.WithQueryParameter("BAF3", m3BAF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF4))
				request.WithQueryParameter("BAF4", m3BAF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF5))
				request.WithQueryParameter("BAF5", m3BAF5.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3FRDT.Value.ToM3String());
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (m3PSAD.HasValue)
				request.WithQueryParameter("PSAD", m3PSAD.Value.ToM3String());
			if (m3SDRC.HasValue)
				request.WithQueryParameter("SDRC", m3SDRC.Value.ToM3String());
			if (m3OBST.HasValue)
				request.WithQueryParameter("OBST", m3OBST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CBST.HasValue)
				request.WithQueryParameter("CBST", m3CBST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IDAC.HasValue)
				request.WithQueryParameter("IDAC", m3IDAC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());

			// Execute the request
			var result = await Execute<UpdHeadResponse>(
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
		/// Name UpdHeadRecord
		/// Description Update Header record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3STMN">Statement number (Required)</param>
		/// <param name="m3SDRC">Statement of account date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3AIT1">Accounting dimension 1</param>
		/// <param name="m3BKID">Bank account identity</param>
		/// <param name="m3BAF1">Bank account field 1</param>
		/// <param name="m3BAF2">Bank account field 2</param>
		/// <param name="m3BAF3">Bank account field 3</param>
		/// <param name="m3BAF4">Bank account field 4</param>
		/// <param name="m3BAF5">Bank account field 5</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3FRDT">From date</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3ERDT">External reconciliation date</param>
		/// <param name="m3OBST">Opening balance on statement</param>
		/// <param name="m3CBST">Closing balance on statement</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3IDAC">Invert Debit and Credit</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdHeadRecord(
			string m3STMN, 
			DateTime m3SDRC, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3AIT1 = null, 
			string m3BKID = null, 
			string m3BAF1 = null, 
			string m3BAF2 = null, 
			string m3BAF3 = null, 
			string m3BAF4 = null, 
			string m3BAF5 = null, 
			DateTime? m3STDT = null, 
			DateTime? m3FRDT = null, 
			DateTime? m3TODT = null, 
			string m3TX40 = null, 
			string m3STAT = null, 
			DateTime? m3ERDT = null, 
			decimal? m3OBST = null, 
			decimal? m3CBST = null, 
			decimal? m3TXID = null, 
			int? m3IDAC = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdHeadRecord",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STMN))
				throw new ArgumentNullException(nameof(m3STMN));

			// Set mandatory parameters
			request
				.WithQueryParameter("STMN", m3STMN.Trim())
				.WithQueryParameter("SDRC", m3SDRC.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT1))
				request.WithQueryParameter("AIT1", m3AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKID))
				request.WithQueryParameter("BKID", m3BKID.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF1))
				request.WithQueryParameter("BAF1", m3BAF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF2))
				request.WithQueryParameter("BAF2", m3BAF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF3))
				request.WithQueryParameter("BAF3", m3BAF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF4))
				request.WithQueryParameter("BAF4", m3BAF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF5))
				request.WithQueryParameter("BAF5", m3BAF5.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3FRDT.Value.ToM3String());
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3ERDT.HasValue)
				request.WithQueryParameter("ERDT", m3ERDT.Value.ToM3String());
			if (m3OBST.HasValue)
				request.WithQueryParameter("OBST", m3OBST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CBST.HasValue)
				request.WithQueryParameter("CBST", m3CBST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IDAC.HasValue)
				request.WithQueryParameter("IDAC", m3IDAC.Value.ToString(CultureInfo.CurrentCulture));

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
