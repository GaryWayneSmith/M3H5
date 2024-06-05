/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.CLAIMSMI;
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
	/// Name: CLAIMSMI
	/// Component Name: EquipmentInfo
	/// Description: API interface Maint Claims
	/// Version Release: 5ea4
	///</summary>
	public partial class CLAIMSMIResource : M3BaseResourceEndpoint
	{
		public CLAIMSMIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CLAIMSMI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddClaimHead
		/// Description Adds Claim Head
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3AAGN">Agreement number (Required)</param>
		/// <param name="m3CLTP">Claim type (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CLNO">Claim</param>
		/// <param name="m3ECLN">External Claim Number</param>
		/// <param name="m3AL03">Prefix</param>
		/// <param name="m3TEPS">Teps Claim</param>
		/// <param name="m3CDTE">Claim date</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3PROD">Manufacturer</param>
		/// <param name="m3PYAG">Payer agreement</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3APRF">Approval reference</param>
		/// <param name="m3TAIL">Registration number/site</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3OWNC">Owner</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3DEDA">Delivery date</param>
		/// <param name="m3DSMM">Date submitted to manufacturer</param>
		/// <param name="m3MES1">Meter 1</param>
		/// <param name="m3MES2">Meter 2</param>
		/// <param name="m3MES3">Meter 3</param>
		/// <param name="m3MES4">Meter 4</param>
		/// <param name="m3MVA1">Meter value 1</param>
		/// <param name="m3MVA2">Meter value 2</param>
		/// <param name="m3MVA3">Meter value 3</param>
		/// <param name="m3MVA4">Meter value 4</param>
		/// <param name="m3MES5">Meter 1</param>
		/// <param name="m3MES6">Meter 2</param>
		/// <param name="m3MES7">Meter 3</param>
		/// <param name="m3MES8">Meter 4</param>
		/// <param name="m3MVA5">Meter value 1</param>
		/// <param name="m3MVA6">Meter value 2</param>
		/// <param name="m3MVA7">Meter value 3</param>
		/// <param name="m3MVA8">Meter value 4</param>
		/// <param name="m3ITN1">Item Causing Problem</param>
		/// <param name="m3YMD8">FailureDate</param>
		/// <param name="m3TSCL">Time stamp closed by mfg</param>
		/// <param name="m3CNAD">Credit note acceptance date</param>
		/// <param name="m3CDNN">Credit note number</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3DTRC">Date to recall Customer</param>
		/// <param name="m3CANT">Call notes</param>
		/// <param name="m3LCLD">Latest claim date</param>
		/// <param name="m3WATP">Warranty type</param>
		/// <param name="m3SMC0">User defined field 1</param>
		/// <param name="m3SMC1">User defined field 2</param>
		/// <param name="m3SMC2">User defined field 3</param>
		/// <param name="m3SMC3">User defined field 4</param>
		/// <param name="m3SMC4">User defined field 5</param>
		/// <param name="m3SMC5">User defined field 6</param>
		/// <param name="m3SMC6">User defined field 7</param>
		/// <param name="m3SMC7">User defined field 8</param>
		/// <param name="m3SMC8">User defined field 9</param>
		/// <param name="m3SMC9">User defined field 10</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3MES0">Meter</param>
		/// <param name="m3MVA0">Since new</param>
		/// <param name="m3SECP">Serial number</param>
		/// <param name="m3FALD">Failure date</param>
		/// <param name="m3MRDT">Machine ready date</param>
		/// <param name="m3MRTI">Machine ready time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddClaimHeadResponse></returns>
		/// <exception cref="M3Exception<AddClaimHeadResponse>"></exception>
		public async Task<M3Response<AddClaimHeadResponse>> AddClaimHead(
			string m3AAGN, 
			string m3CLTP, 
			string m3FACI, 
			string m3CLNO = null, 
			string m3ECLN = null, 
			string m3AL03 = null, 
			int? m3TEPS = null, 
			DateTime? m3CDTE = null, 
			string m3STAT = null, 
			string m3PROD = null, 
			string m3PYAG = null, 
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3APRF = null, 
			string m3TAIL = null, 
			string m3PRNO = null, 
			string m3BANO = null, 
			string m3ITNO = null, 
			string m3SERN = null, 
			string m3SUFI = null, 
			string m3STRT = null, 
			string m3OWNC = null, 
			string m3CUNO = null, 
			DateTime? m3DEDA = null, 
			DateTime? m3DSMM = null, 
			string m3MES1 = null, 
			string m3MES2 = null, 
			string m3MES3 = null, 
			string m3MES4 = null, 
			decimal? m3MVA1 = null, 
			decimal? m3MVA2 = null, 
			decimal? m3MVA3 = null, 
			decimal? m3MVA4 = null, 
			string m3MES5 = null, 
			string m3MES6 = null, 
			string m3MES7 = null, 
			string m3MES8 = null, 
			decimal? m3MVA5 = null, 
			decimal? m3MVA6 = null, 
			decimal? m3MVA7 = null, 
			decimal? m3MVA8 = null, 
			string m3ITN1 = null, 
			DateTime? m3YMD8 = null, 
			decimal? m3TSCL = null, 
			DateTime? m3CNAD = null, 
			int? m3CDNN = null, 
			string m3RESP = null, 
			string m3CUCD = null, 
			string m3RSCD = null, 
			DateTime? m3DTRC = null, 
			string m3CANT = null, 
			DateTime? m3LCLD = null, 
			string m3WATP = null, 
			string m3SMC0 = null, 
			string m3SMC1 = null, 
			string m3SMC2 = null, 
			string m3SMC3 = null, 
			string m3SMC4 = null, 
			string m3SMC5 = null, 
			string m3SMC6 = null, 
			string m3SMC7 = null, 
			string m3SMC8 = null, 
			string m3SMC9 = null, 
			decimal? m3TXID = null, 
			string m3MES0 = null, 
			decimal? m3MVA0 = null, 
			string m3SECP = null, 
			DateTime? m3FALD = null, 
			DateTime? m3MRDT = null, 
			int? m3MRTI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddClaimHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));
			if (string.IsNullOrWhiteSpace(m3CLTP))
				throw new ArgumentNullException(nameof(m3CLTP));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim())
				.WithQueryParameter("CLTP", m3CLTP.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CLNO))
				request.WithQueryParameter("CLNO", m3CLNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECLN))
				request.WithQueryParameter("ECLN", m3ECLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3AL03))
				request.WithQueryParameter("AL03", m3AL03.Trim());
			if (m3TEPS.HasValue)
				request.WithQueryParameter("TEPS", m3TEPS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CDTE.HasValue)
				request.WithQueryParameter("CDTE", m3CDTE.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROD))
				request.WithQueryParameter("PROD", m3PROD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYAG))
				request.WithQueryParameter("PYAG", m3PYAG.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3APRF))
				request.WithQueryParameter("APRF", m3APRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAIL))
				request.WithQueryParameter("TAIL", m3TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3OWNC))
				request.WithQueryParameter("OWNC", m3OWNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3DEDA.HasValue)
				request.WithQueryParameter("DEDA", m3DEDA.Value.ToM3String());
			if (m3DSMM.HasValue)
				request.WithQueryParameter("DSMM", m3DSMM.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3MES1))
				request.WithQueryParameter("MES1", m3MES1.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES2))
				request.WithQueryParameter("MES2", m3MES2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES3))
				request.WithQueryParameter("MES3", m3MES3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES4))
				request.WithQueryParameter("MES4", m3MES4.Trim());
			if (m3MVA1.HasValue)
				request.WithQueryParameter("MVA1", m3MVA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVA2.HasValue)
				request.WithQueryParameter("MVA2", m3MVA2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVA3.HasValue)
				request.WithQueryParameter("MVA3", m3MVA3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVA4.HasValue)
				request.WithQueryParameter("MVA4", m3MVA4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MES5))
				request.WithQueryParameter("MES5", m3MES5.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES6))
				request.WithQueryParameter("MES6", m3MES6.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES7))
				request.WithQueryParameter("MES7", m3MES7.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES8))
				request.WithQueryParameter("MES8", m3MES8.Trim());
			if (m3MVA5.HasValue)
				request.WithQueryParameter("MVA5", m3MVA5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVA6.HasValue)
				request.WithQueryParameter("MVA6", m3MVA6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVA7.HasValue)
				request.WithQueryParameter("MVA7", m3MVA7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVA8.HasValue)
				request.WithQueryParameter("MVA8", m3MVA8.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITN1))
				request.WithQueryParameter("ITN1", m3ITN1.Trim());
			if (m3YMD8.HasValue)
				request.WithQueryParameter("YMD8", m3YMD8.Value.ToM3String());
			if (m3TSCL.HasValue)
				request.WithQueryParameter("TSCL", m3TSCL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CNAD.HasValue)
				request.WithQueryParameter("CNAD", m3CNAD.Value.ToM3String());
			if (m3CDNN.HasValue)
				request.WithQueryParameter("CDNN", m3CDNN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (m3DTRC.HasValue)
				request.WithQueryParameter("DTRC", m3DTRC.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CANT))
				request.WithQueryParameter("CANT", m3CANT.Trim());
			if (m3LCLD.HasValue)
				request.WithQueryParameter("LCLD", m3LCLD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3WATP))
				request.WithQueryParameter("WATP", m3WATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC0))
				request.WithQueryParameter("SMC0", m3SMC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC1))
				request.WithQueryParameter("SMC1", m3SMC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC2))
				request.WithQueryParameter("SMC2", m3SMC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC3))
				request.WithQueryParameter("SMC3", m3SMC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC4))
				request.WithQueryParameter("SMC4", m3SMC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC5))
				request.WithQueryParameter("SMC5", m3SMC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC6))
				request.WithQueryParameter("SMC6", m3SMC6.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC7))
				request.WithQueryParameter("SMC7", m3SMC7.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC8))
				request.WithQueryParameter("SMC8", m3SMC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC9))
				request.WithQueryParameter("SMC9", m3SMC9.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MES0))
				request.WithQueryParameter("MES0", m3MES0.Trim());
			if (m3MVA0.HasValue)
				request.WithQueryParameter("MVA0", m3MVA0.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SECP))
				request.WithQueryParameter("SECP", m3SECP.Trim());
			if (m3FALD.HasValue)
				request.WithQueryParameter("FALD", m3FALD.Value.ToM3String());
			if (m3MRDT.HasValue)
				request.WithQueryParameter("MRDT", m3MRDT.Value.ToM3String());
			if (m3MRTI.HasValue)
				request.WithQueryParameter("MRTI", m3MRTI.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddClaimHeadResponse>(
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
		/// Name AddClaimSpec
		/// Description Adds Claim Specification
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3CLNO">Claim (Required)</param>
		/// <param name="m3VENO">Version (Required)</param>
		/// <param name="m3ALNT">Line type (Required)</param>
		/// <param name="m3IVQT">Invoiced quantity - basic U/M (Required)</param>
		/// <param name="m3UNIT">Unit of measure (Required)</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3ARET">Return date</param>
		/// <param name="m3ARE1">Return Date</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3MCTP">Miscellaneous cost type</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3AHPR">Handling charge</param>
		/// <param name="m3PSPC">Parts settlement percentage</param>
		/// <param name="m3MFAQ">Mfg approved qty</param>
		/// <param name="m3MFAP">Mfg approved price</param>
		/// <param name="m3MHAA">Mfg handling approved amount</param>
		/// <param name="m3NEPR">Net price</param>
		/// <param name="m3DPRR">Date part return requested</param>
		/// <param name="m3RTND">Part rtn dt ship</param>
		/// <param name="m3DLRM">Remark</param>
		/// <param name="m3TX60">Text</param>
		/// <param name="m3MWNO">Work order number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3AWCO">WIP debit</param>
		/// <param name="m3DIPL">Discount</param>
		/// <param name="m3DIAL">Discount amount</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3RTPR">Return processing</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3APSP">Approved parts settlement percentage</param>
		/// <param name="m3TTPE">Time type</param>
		/// <param name="m3SMC0">User defined field 1</param>
		/// <param name="m3SMC1">User defined field 2</param>
		/// <param name="m3SMC2">User defined field 3</param>
		/// <param name="m3SMC3">User defined field 4</param>
		/// <param name="m3SMC4">User defined field 5</param>
		/// <param name="m3SMC5">User defined field 6</param>
		/// <param name="m3SMC6">User defined field 7</param>
		/// <param name="m3SMC7">User defined field 8</param>
		/// <param name="m3SMC8">User defined field 9</param>
		/// <param name="m3SMC9">User defined field 10</param>
		/// <param name="m3ALI1">Transaction number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RSCD">New field description</param>
		/// <param name="m3CFI1">User-defined field 1 - item</param>
		/// <param name="m3CFI2">User-defined field 2 - item</param>
		/// <param name="m3CFI3">User-defined field 3 - item</param>
		/// <param name="m3CFI4">User-defined field 4 - item</param>
		/// <param name="m3CFI5">User-defined field 5 - item</param>
		/// <param name="m3CFI6">User-defined field 6 - item</param>
		/// <param name="m3CFI7">User-defined field 7 - item</param>
		/// <param name="m3CFI8">User-defined field 8 - item</param>
		/// <param name="m3CFI9">User-defined field 9 - item</param>
		/// <param name="m3CFI0">User-defined field 0 - item</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddClaimSpec(
			string m3CLNO, 
			int m3VENO, 
			int m3ALNT, 
			decimal m3IVQT, 
			string m3UNIT, 
			string m3STAT = null, 
			string m3ITNO = null, 
			DateTime? m3ARET = null, 
			long? m3ARE1 = null, 
			int? m3MSEQ = null, 
			string m3EMNO = null, 
			string m3PLGR = null, 
			string m3SUNO = null, 
			string m3MCTP = null, 
			string m3WHLO = null, 
			decimal? m3SAPR = null, 
			decimal? m3AHPR = null, 
			int? m3PSPC = null, 
			decimal? m3MFAQ = null, 
			decimal? m3MFAP = null, 
			decimal? m3MHAA = null, 
			decimal? m3NEPR = null, 
			DateTime? m3DPRR = null, 
			DateTime? m3RTND = null, 
			string m3DLRM = null, 
			string m3TX60 = null, 
			string m3MWNO = null, 
			int? m3OPNO = null, 
			decimal? m3AWCO = null, 
			int? m3DIPL = null, 
			decimal? m3DIAL = null, 
			decimal? m3TXID = null, 
			string m3CUCD = null, 
			string m3SUFI = null, 
			string m3STRT = null, 
			int? m3RTPR = null, 
			string m3SERN = null, 
			int? m3APSP = null, 
			string m3TTPE = null, 
			string m3SMC0 = null, 
			string m3SMC1 = null, 
			string m3SMC2 = null, 
			string m3SMC3 = null, 
			string m3SMC4 = null, 
			string m3SMC5 = null, 
			string m3SMC6 = null, 
			string m3SMC7 = null, 
			string m3SMC8 = null, 
			string m3SMC9 = null, 
			int? m3ALI1 = null, 
			int? m3RORL = null, 
			string m3RSCD = null, 
			string m3CFI1 = null, 
			decimal? m3CFI2 = null, 
			string m3CFI3 = null, 
			string m3CFI4 = null, 
			string m3CFI5 = null, 
			string m3CFI6 = null, 
			decimal? m3CFI7 = null, 
			string m3CFI8 = null, 
			string m3CFI9 = null, 
			string m3CFI0 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddClaimSpec",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CLNO))
				throw new ArgumentNullException(nameof(m3CLNO));
			if (string.IsNullOrWhiteSpace(m3UNIT))
				throw new ArgumentNullException(nameof(m3UNIT));

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3CLNO.Trim())
				.WithQueryParameter("VENO", m3VENO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ALNT", m3ALNT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("IVQT", m3IVQT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("UNIT", m3UNIT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3ARET.HasValue)
				request.WithQueryParameter("ARET", m3ARET.Value.ToM3String());
			if (m3ARE1.HasValue)
				request.WithQueryParameter("ARE1", m3ARE1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MCTP))
				request.WithQueryParameter("MCTP", m3MCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AHPR.HasValue)
				request.WithQueryParameter("AHPR", m3AHPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PSPC.HasValue)
				request.WithQueryParameter("PSPC", m3PSPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MFAQ.HasValue)
				request.WithQueryParameter("MFAQ", m3MFAQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MFAP.HasValue)
				request.WithQueryParameter("MFAP", m3MFAP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MHAA.HasValue)
				request.WithQueryParameter("MHAA", m3MHAA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NEPR.HasValue)
				request.WithQueryParameter("NEPR", m3NEPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DPRR.HasValue)
				request.WithQueryParameter("DPRR", m3DPRR.Value.ToM3String());
			if (m3RTND.HasValue)
				request.WithQueryParameter("RTND", m3RTND.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3DLRM))
				request.WithQueryParameter("DLRM", m3DLRM.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX60))
				request.WithQueryParameter("TX60", m3TX60.Trim());
			if (!string.IsNullOrWhiteSpace(m3MWNO))
				request.WithQueryParameter("MWNO", m3MWNO.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AWCO.HasValue)
				request.WithQueryParameter("AWCO", m3AWCO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIPL.HasValue)
				request.WithQueryParameter("DIPL", m3DIPL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIAL.HasValue)
				request.WithQueryParameter("DIAL", m3DIAL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3RTPR.HasValue)
				request.WithQueryParameter("RTPR", m3RTPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (m3APSP.HasValue)
				request.WithQueryParameter("APSP", m3APSP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TTPE))
				request.WithQueryParameter("TTPE", m3TTPE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC0))
				request.WithQueryParameter("SMC0", m3SMC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC1))
				request.WithQueryParameter("SMC1", m3SMC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC2))
				request.WithQueryParameter("SMC2", m3SMC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC3))
				request.WithQueryParameter("SMC3", m3SMC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC4))
				request.WithQueryParameter("SMC4", m3SMC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC5))
				request.WithQueryParameter("SMC5", m3SMC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC6))
				request.WithQueryParameter("SMC6", m3SMC6.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC7))
				request.WithQueryParameter("SMC7", m3SMC7.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC8))
				request.WithQueryParameter("SMC8", m3SMC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC9))
				request.WithQueryParameter("SMC9", m3SMC9.Trim());
			if (m3ALI1.HasValue)
				request.WithQueryParameter("ALI1", m3ALI1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI1))
				request.WithQueryParameter("CFI1", m3CFI1.Trim());
			if (m3CFI2.HasValue)
				request.WithQueryParameter("CFI2", m3CFI2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFI3))
				request.WithQueryParameter("CFI3", m3CFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI4))
				request.WithQueryParameter("CFI4", m3CFI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI5))
				request.WithQueryParameter("CFI5", m3CFI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI6))
				request.WithQueryParameter("CFI6", m3CFI6.Trim());
			if (m3CFI7.HasValue)
				request.WithQueryParameter("CFI7", m3CFI7.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFI8))
				request.WithQueryParameter("CFI8", m3CFI8.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI9))
				request.WithQueryParameter("CFI9", m3CFI9.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI0))
				request.WithQueryParameter("CFI0", m3CFI0.Trim());

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
		/// Name AddClaimVer
		/// Description Adds Claim Version
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CLNO">Claim (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3DSMM">Date submitted to manufacturer</param>
		/// <param name="m3AAPD">Approval date</param>
		/// <param name="m3REJD">Rejection date</param>
		/// <param name="m3ANDT">Answer recieved date</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddClaimVerResponse></returns>
		/// <exception cref="M3Exception<AddClaimVerResponse>"></exception>
		public async Task<M3Response<AddClaimVerResponse>> AddClaimVer(
			string m3CLNO, 
			string m3TX40, 
			DateTime? m3DSMM = null, 
			DateTime? m3AAPD = null, 
			DateTime? m3REJD = null, 
			DateTime? m3ANDT = null, 
			string m3STAT = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddClaimVer",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CLNO))
				throw new ArgumentNullException(nameof(m3CLNO));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3CLNO.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3DSMM.HasValue)
				request.WithQueryParameter("DSMM", m3DSMM.Value.ToM3String());
			if (m3AAPD.HasValue)
				request.WithQueryParameter("AAPD", m3AAPD.Value.ToM3String());
			if (m3REJD.HasValue)
				request.WithQueryParameter("REJD", m3REJD.Value.ToM3String());
			if (m3ANDT.HasValue)
				request.WithQueryParameter("ANDT", m3ANDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddClaimVerResponse>(
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
		/// Name CreateNewVer
		/// Description Create New Version
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CreateNewVer(
			string m3CLNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CreateNewVer",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CLNO))
				request.WithQueryParameter("CLNO", m3CLNO.Trim());

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
		/// Name DelClaimSpec
		/// Description Delete Claim Spec record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CLNO">Claim (Required)</param>
		/// <param name="m3VENO">Version (Required)</param>
		/// <param name="m3CLSP">Claim spec (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelClaimSpec(
			string m3CLNO, 
			int m3VENO, 
			int m3CLSP, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelClaimSpec",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CLNO))
				throw new ArgumentNullException(nameof(m3CLNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3CLNO.Trim())
				.WithQueryParameter("VENO", m3VENO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CLSP", m3CLSP.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetClaimHead
		/// Description Gets Claim Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CLNO">Claim</param>
		/// <param name="m3ECLN">External Claim Number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetClaimHeadResponse></returns>
		/// <exception cref="M3Exception<GetClaimHeadResponse>"></exception>
		public async Task<M3Response<GetClaimHeadResponse>> GetClaimHead(
			string m3CLNO = null, 
			string m3ECLN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetClaimHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CLNO))
				request.WithQueryParameter("CLNO", m3CLNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECLN))
				request.WithQueryParameter("ECLN", m3ECLN.Trim());

			// Execute the request
			var result = await Execute<GetClaimHeadResponse>(
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
		/// Name GetClaimHeadFF
		/// Description Get Claim Head Free Fields
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CLNO">Claim (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetClaimHeadFFResponse></returns>
		/// <exception cref="M3Exception<GetClaimHeadFFResponse>"></exception>
		public async Task<M3Response<GetClaimHeadFFResponse>> GetClaimHeadFF(
			string m3CLNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetClaimHeadFF",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CLNO))
				throw new ArgumentNullException(nameof(m3CLNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3CLNO.Trim());

			// Execute the request
			var result = await Execute<GetClaimHeadFFResponse>(
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
		/// Name GetClaimHeadTxt
		/// Description Gets Claim Head Text
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CLNO">Claim (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetClaimHeadTxtResponse></returns>
		/// <exception cref="M3Exception<GetClaimHeadTxtResponse>"></exception>
		public async Task<M3Response<GetClaimHeadTxtResponse>> GetClaimHeadTxt(
			string m3CLNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetClaimHeadTxt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CLNO))
				throw new ArgumentNullException(nameof(m3CLNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3CLNO.Trim());

			// Execute the request
			var result = await Execute<GetClaimHeadTxtResponse>(
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
		/// Name GetClaimSpec
		/// Description Gets Claim Specifications
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3CLNO">Claim (Required)</param>
		/// <param name="m3VENO">Version (Required)</param>
		/// <param name="m3CLSP">Claim spec</param>
		/// <param name="m3TSEQ">Transaction Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetClaimSpecResponse></returns>
		/// <exception cref="M3Exception<GetClaimSpecResponse>"></exception>
		public async Task<M3Response<GetClaimSpecResponse>> GetClaimSpec(
			string m3CLNO, 
			int m3VENO, 
			int? m3CLSP = null, 
			int? m3TSEQ = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetClaimSpec",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CLNO))
				throw new ArgumentNullException(nameof(m3CLNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3CLNO.Trim())
				.WithQueryParameter("VENO", m3VENO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CLSP.HasValue)
				request.WithQueryParameter("CLSP", m3CLSP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TSEQ.HasValue)
				request.WithQueryParameter("TSEQ", m3TSEQ.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetClaimSpecResponse>(
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
		/// Name GetClaimVer
		/// Description Selects Claim Version
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CLNO">Claim (Required)</param>
		/// <param name="m3VENO">Version (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetClaimVerResponse></returns>
		/// <exception cref="M3Exception<GetClaimVerResponse>"></exception>
		public async Task<M3Response<GetClaimVerResponse>> GetClaimVer(
			string m3CLNO, 
			int m3VENO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetClaimVer",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CLNO))
				throw new ArgumentNullException(nameof(m3CLNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3CLNO.Trim())
				.WithQueryParameter("VENO", m3VENO.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetClaimVerResponse>(
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
		/// Name GetItemFailInfo
		/// Description GetItemFailInfo
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3CLNO">Claim</param>
		/// <param name="m3ECLN">External claim number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItemFailInfoResponse></returns>
		/// <exception cref="M3Exception<GetItemFailInfoResponse>"></exception>
		public async Task<M3Response<GetItemFailInfoResponse>> GetItemFailInfo(
			string m3CLNO = null, 
			string m3ECLN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetItemFailInfo",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CLNO))
				request.WithQueryParameter("CLNO", m3CLNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECLN))
				request.WithQueryParameter("ECLN", m3ECLN.Trim());

			// Execute the request
			var result = await Execute<GetItemFailInfoResponse>(
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
		/// Name LstCLHbyRORC
		/// Description Lists Claim Head By RORC
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3RORC">Reference order category (Required)</param>
		/// <param name="m3RORN">Reference order number (Required)</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCLHbyRORCResponse></returns>
		/// <exception cref="M3Exception<LstCLHbyRORCResponse>"></exception>
		public async Task<M3Response<LstCLHbyRORCResponse>> LstCLHbyRORC(
			int m3RORC, 
			string m3RORN, 
			int? m3RORL = null, 
			int? m3RORX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstCLHbyRORC",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RORN))
				throw new ArgumentNullException(nameof(m3RORN));

			// Set mandatory parameters
			request
				.WithQueryParameter("RORC", m3RORC.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RORN", m3RORN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstCLHbyRORCResponse>(
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
		/// Name LstClaimHead
		/// Description Lists Claim Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstClaimHeadResponse></returns>
		/// <exception cref="M3Exception<LstClaimHeadResponse>"></exception>
		public async Task<M3Response<LstClaimHeadResponse>> LstClaimHead(
			string m3PRNO = null, 
			string m3BANO = null, 
			string m3CLNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstClaimHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CLNO))
				request.WithQueryParameter("CLNO", m3CLNO.Trim());

			// Execute the request
			var result = await Execute<LstClaimHeadResponse>(
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
		/// Name LstClaimSpec
		/// Description Lists Claim Specifications
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CLNO">Claim (Required)</param>
		/// <param name="m3VENO">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstClaimSpecResponse></returns>
		/// <exception cref="M3Exception<LstClaimSpecResponse>"></exception>
		public async Task<M3Response<LstClaimSpecResponse>> LstClaimSpec(
			string m3CLNO, 
			int? m3VENO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstClaimSpec",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CLNO))
				throw new ArgumentNullException(nameof(m3CLNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3CLNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3VENO.HasValue)
				request.WithQueryParameter("VENO", m3VENO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstClaimSpecResponse>(
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
		/// Name LstClaimVer
		/// Description Selects Claim Version
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstClaimVerResponse></returns>
		/// <exception cref="M3Exception<LstClaimVerResponse>"></exception>
		public async Task<M3Response<LstClaimVerResponse>> LstClaimVer(
			string m3CLNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstClaimVer",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CLNO))
				request.WithQueryParameter("CLNO", m3CLNO.Trim());

			// Execute the request
			var result = await Execute<LstClaimVerResponse>(
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
		/// Name SelClaimHead
		/// Description Selects Claim Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelClaimHeadResponse></returns>
		/// <exception cref="M3Exception<SelClaimHeadResponse>"></exception>
		public async Task<M3Response<SelClaimHeadResponse>> SelClaimHead(
			string m3PRNO, 
			string m3BANO = null, 
			string m3CLNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelClaimHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRNO", m3PRNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CLNO))
				request.WithQueryParameter("CLNO", m3CLNO.Trim());

			// Execute the request
			var result = await Execute<SelClaimHeadResponse>(
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
		/// Name SelClaimSpec
		/// Description Selects Claim Specifications
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CLNO">Claim (Required)</param>
		/// <param name="m3VENO">Version (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelClaimSpecResponse></returns>
		/// <exception cref="M3Exception<SelClaimSpecResponse>"></exception>
		public async Task<M3Response<SelClaimSpecResponse>> SelClaimSpec(
			string m3CLNO, 
			int m3VENO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelClaimSpec",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CLNO))
				throw new ArgumentNullException(nameof(m3CLNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3CLNO.Trim())
				.WithQueryParameter("VENO", m3VENO.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelClaimSpecResponse>(
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
		/// Name SelClaimVer
		/// Description Selects Claim Version
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CLNO">Claim (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelClaimVerResponse></returns>
		/// <exception cref="M3Exception<SelClaimVerResponse>"></exception>
		public async Task<M3Response<SelClaimVerResponse>> SelClaimVer(
			string m3CLNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelClaimVer",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CLNO))
				throw new ArgumentNullException(nameof(m3CLNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3CLNO.Trim());

			// Execute the request
			var result = await Execute<SelClaimVerResponse>(
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
		/// Name UpdClaimAccept
		/// Description Update Claim Accept
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<UpdClaimAcceptResponse></returns>
		/// <exception cref="M3Exception<UpdClaimAcceptResponse>"></exception>
		public async Task<M3Response<UpdClaimAcceptResponse>> UpdClaimAccept(
			string m3CLNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdClaimAccept",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CLNO))
				request.WithQueryParameter("CLNO", m3CLNO.Trim());

			// Execute the request
			var result = await Execute<UpdClaimAcceptResponse>(
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
		/// Name UpdClaimAnswer
		/// Description Update Claim Anwser
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimAnswer(
			string m3CLNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdClaimAnswer",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CLNO))
				request.WithQueryParameter("CLNO", m3CLNO.Trim());

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
		/// Name UpdClaimCancel
		/// Description Update Claim Cancel
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimCancel(
			string m3CLNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdClaimCancel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CLNO))
				request.WithQueryParameter("CLNO", m3CLNO.Trim());

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
		/// Name UpdClaimClose
		/// Description Update Claim Close
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimClose(
			string m3CLNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdClaimClose",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CLNO))
				request.WithQueryParameter("CLNO", m3CLNO.Trim());

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
		/// Name UpdClaimError
		/// Description Update Claim Error
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimError(
			string m3CLNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdClaimError",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CLNO))
				request.WithQueryParameter("CLNO", m3CLNO.Trim());

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
		/// Name UpdClaimHead
		/// Description Updates Claim Head
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3CLNO">Claim (Required)</param>
		/// <param name="m3AL03">Prefix</param>
		/// <param name="m3CDTE">Claim date</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3PROD">Manufacturer</param>
		/// <param name="m3PYAG">Payer agreement</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3APRF">Approval reference</param>
		/// <param name="m3TAIL">Registration number/site</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3AAGN">Agreement number</param>
		/// <param name="m3OWNC">Owner</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3DEDA">Delivery date</param>
		/// <param name="m3DSMM">Date submitted to manufacturer</param>
		/// <param name="m3MES1">Meter 1</param>
		/// <param name="m3MES2">Meter 2</param>
		/// <param name="m3MES3">Meter 3</param>
		/// <param name="m3MES4">Meter 4</param>
		/// <param name="m3MVA1">Meter value 1</param>
		/// <param name="m3MVA2">Meter value 2</param>
		/// <param name="m3MVA3">Meter value 3</param>
		/// <param name="m3MVA4">Meter value 4</param>
		/// <param name="m3MES5">Meter 1</param>
		/// <param name="m3MES6">Meter 2</param>
		/// <param name="m3MES7">Meter 3</param>
		/// <param name="m3MES8">Meter 4</param>
		/// <param name="m3MVA5">Meter value 1</param>
		/// <param name="m3MVA6">Meter value 2</param>
		/// <param name="m3MVA7">Meter value 3</param>
		/// <param name="m3MVA8">Meter value 4</param>
		/// <param name="m3ITN1">Item number</param>
		/// <param name="m3YMD8">Date YYYYMMDD</param>
		/// <param name="m3TSCL">Time stamp closed by mfg</param>
		/// <param name="m3CNAD">Credit note acceptance date</param>
		/// <param name="m3CDNN">Credit note number</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3NUM1">Numeric field 1 position</param>
		/// <param name="m3DTRC">Date to recall Customer</param>
		/// <param name="m3CANT">Call notes</param>
		/// <param name="m3LCLD">Latest claim date</param>
		/// <param name="m3SMC0">User defined field 1</param>
		/// <param name="m3SMC1">User defined field 2</param>
		/// <param name="m3SMC2">User defined field 3</param>
		/// <param name="m3SMC3">User defined field 4</param>
		/// <param name="m3SMC4">User defined field 5</param>
		/// <param name="m3SMC5">User defined field 6</param>
		/// <param name="m3SMC6">User defined field 7</param>
		/// <param name="m3SMC7">User defined field 8</param>
		/// <param name="m3SMC8">User defined field 9</param>
		/// <param name="m3SMC9">User defined field 10</param>
		/// <param name="m3ECLN">Alpha field 20 positions</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3MES0">Meter</param>
		/// <param name="m3MVA0">Since new</param>
		/// <param name="m3SECP">Serial number</param>
		/// <param name="m3FALD">Failure date</param>
		/// <param name="m3MRDT">Machine ready date</param>
		/// <param name="m3MRTI">Machine ready time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimHead(
			string m3CLNO, 
			string m3AL03 = null, 
			DateTime? m3CDTE = null, 
			string m3STAT = null, 
			string m3PROD = null, 
			string m3PYAG = null, 
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3APRF = null, 
			string m3TAIL = null, 
			string m3PRNO = null, 
			string m3BANO = null, 
			string m3ITNO = null, 
			string m3SERN = null, 
			string m3SUFI = null, 
			string m3STRT = null, 
			string m3AAGN = null, 
			string m3OWNC = null, 
			string m3CUNO = null, 
			DateTime? m3DEDA = null, 
			DateTime? m3DSMM = null, 
			string m3MES1 = null, 
			string m3MES2 = null, 
			string m3MES3 = null, 
			string m3MES4 = null, 
			decimal? m3MVA1 = null, 
			decimal? m3MVA2 = null, 
			decimal? m3MVA3 = null, 
			decimal? m3MVA4 = null, 
			string m3MES5 = null, 
			string m3MES6 = null, 
			string m3MES7 = null, 
			string m3MES8 = null, 
			decimal? m3MVA5 = null, 
			decimal? m3MVA6 = null, 
			decimal? m3MVA7 = null, 
			decimal? m3MVA8 = null, 
			string m3ITN1 = null, 
			DateTime? m3YMD8 = null, 
			decimal? m3TSCL = null, 
			DateTime? m3CNAD = null, 
			int? m3CDNN = null, 
			string m3RESP = null, 
			string m3CUCD = null, 
			string m3RSCD = null, 
			int? m3NUM1 = null, 
			DateTime? m3DTRC = null, 
			string m3CANT = null, 
			DateTime? m3LCLD = null, 
			string m3SMC0 = null, 
			string m3SMC1 = null, 
			string m3SMC2 = null, 
			string m3SMC3 = null, 
			string m3SMC4 = null, 
			string m3SMC5 = null, 
			string m3SMC6 = null, 
			string m3SMC7 = null, 
			string m3SMC8 = null, 
			string m3SMC9 = null, 
			string m3ECLN = null, 
			decimal? m3TXID = null, 
			string m3MES0 = null, 
			decimal? m3MVA0 = null, 
			string m3SECP = null, 
			DateTime? m3FALD = null, 
			DateTime? m3MRDT = null, 
			int? m3MRTI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdClaimHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CLNO))
				throw new ArgumentNullException(nameof(m3CLNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3CLNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AL03))
				request.WithQueryParameter("AL03", m3AL03.Trim());
			if (m3CDTE.HasValue)
				request.WithQueryParameter("CDTE", m3CDTE.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROD))
				request.WithQueryParameter("PROD", m3PROD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYAG))
				request.WithQueryParameter("PYAG", m3PYAG.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3APRF))
				request.WithQueryParameter("APRF", m3APRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAIL))
				request.WithQueryParameter("TAIL", m3TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3AAGN))
				request.WithQueryParameter("AAGN", m3AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3OWNC))
				request.WithQueryParameter("OWNC", m3OWNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3DEDA.HasValue)
				request.WithQueryParameter("DEDA", m3DEDA.Value.ToM3String());
			if (m3DSMM.HasValue)
				request.WithQueryParameter("DSMM", m3DSMM.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3MES1))
				request.WithQueryParameter("MES1", m3MES1.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES2))
				request.WithQueryParameter("MES2", m3MES2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES3))
				request.WithQueryParameter("MES3", m3MES3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES4))
				request.WithQueryParameter("MES4", m3MES4.Trim());
			if (m3MVA1.HasValue)
				request.WithQueryParameter("MVA1", m3MVA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVA2.HasValue)
				request.WithQueryParameter("MVA2", m3MVA2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVA3.HasValue)
				request.WithQueryParameter("MVA3", m3MVA3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVA4.HasValue)
				request.WithQueryParameter("MVA4", m3MVA4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MES5))
				request.WithQueryParameter("MES5", m3MES5.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES6))
				request.WithQueryParameter("MES6", m3MES6.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES7))
				request.WithQueryParameter("MES7", m3MES7.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES8))
				request.WithQueryParameter("MES8", m3MES8.Trim());
			if (m3MVA5.HasValue)
				request.WithQueryParameter("MVA5", m3MVA5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVA6.HasValue)
				request.WithQueryParameter("MVA6", m3MVA6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVA7.HasValue)
				request.WithQueryParameter("MVA7", m3MVA7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVA8.HasValue)
				request.WithQueryParameter("MVA8", m3MVA8.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITN1))
				request.WithQueryParameter("ITN1", m3ITN1.Trim());
			if (m3YMD8.HasValue)
				request.WithQueryParameter("YMD8", m3YMD8.Value.ToM3String());
			if (m3TSCL.HasValue)
				request.WithQueryParameter("TSCL", m3TSCL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CNAD.HasValue)
				request.WithQueryParameter("CNAD", m3CNAD.Value.ToM3String());
			if (m3CDNN.HasValue)
				request.WithQueryParameter("CDNN", m3CDNN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (m3NUM1.HasValue)
				request.WithQueryParameter("NUM1", m3NUM1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTRC.HasValue)
				request.WithQueryParameter("DTRC", m3DTRC.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CANT))
				request.WithQueryParameter("CANT", m3CANT.Trim());
			if (m3LCLD.HasValue)
				request.WithQueryParameter("LCLD", m3LCLD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3SMC0))
				request.WithQueryParameter("SMC0", m3SMC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC1))
				request.WithQueryParameter("SMC1", m3SMC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC2))
				request.WithQueryParameter("SMC2", m3SMC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC3))
				request.WithQueryParameter("SMC3", m3SMC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC4))
				request.WithQueryParameter("SMC4", m3SMC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC5))
				request.WithQueryParameter("SMC5", m3SMC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC6))
				request.WithQueryParameter("SMC6", m3SMC6.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC7))
				request.WithQueryParameter("SMC7", m3SMC7.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC8))
				request.WithQueryParameter("SMC8", m3SMC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC9))
				request.WithQueryParameter("SMC9", m3SMC9.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECLN))
				request.WithQueryParameter("ECLN", m3ECLN.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MES0))
				request.WithQueryParameter("MES0", m3MES0.Trim());
			if (m3MVA0.HasValue)
				request.WithQueryParameter("MVA0", m3MVA0.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SECP))
				request.WithQueryParameter("SECP", m3SECP.Trim());
			if (m3FALD.HasValue)
				request.WithQueryParameter("FALD", m3FALD.Value.ToM3String());
			if (m3MRDT.HasValue)
				request.WithQueryParameter("MRDT", m3MRDT.Value.ToM3String());
			if (m3MRTI.HasValue)
				request.WithQueryParameter("MRTI", m3MRTI.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdClaimHeadFF
		/// Description Upd Claim Head Free Fields
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CLNO">Claim (Required)</param>
		/// <param name="m3FRE1">Text</param>
		/// <param name="m3FRE2">Text</param>
		/// <param name="m3FRE3">Text</param>
		/// <param name="m3FRE4">Text</param>
		/// <param name="m3FRE5">Text</param>
		/// <param name="m3FRE6">Text</param>
		/// <param name="m3FRE7">Text</param>
		/// <param name="m3FRE8">Text</param>
		/// <param name="m3FRE9">Text</param>
		/// <param name="m3FREA">Text</param>
		/// <param name="m3DT01">Entry date</param>
		/// <param name="m3DT02">Entry date</param>
		/// <param name="m3NF01">Numeric field 19¤6 positions</param>
		/// <param name="m3NF02">Numeric field 19¤6 positions</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimHeadFF(
			string m3CLNO, 
			string m3FRE1 = null, 
			string m3FRE2 = null, 
			string m3FRE3 = null, 
			string m3FRE4 = null, 
			string m3FRE5 = null, 
			string m3FRE6 = null, 
			string m3FRE7 = null, 
			string m3FRE8 = null, 
			string m3FRE9 = null, 
			string m3FREA = null, 
			DateTime? m3DT01 = null, 
			DateTime? m3DT02 = null, 
			decimal? m3NF01 = null, 
			decimal? m3NF02 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdClaimHeadFF",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CLNO))
				throw new ArgumentNullException(nameof(m3CLNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3CLNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FRE1))
				request.WithQueryParameter("FRE1", m3FRE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRE2))
				request.WithQueryParameter("FRE2", m3FRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRE3))
				request.WithQueryParameter("FRE3", m3FRE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRE4))
				request.WithQueryParameter("FRE4", m3FRE4.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRE5))
				request.WithQueryParameter("FRE5", m3FRE5.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRE6))
				request.WithQueryParameter("FRE6", m3FRE6.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRE7))
				request.WithQueryParameter("FRE7", m3FRE7.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRE8))
				request.WithQueryParameter("FRE8", m3FRE8.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRE9))
				request.WithQueryParameter("FRE9", m3FRE9.Trim());
			if (!string.IsNullOrWhiteSpace(m3FREA))
				request.WithQueryParameter("FREA", m3FREA.Trim());
			if (m3DT01.HasValue)
				request.WithQueryParameter("DT01", m3DT01.Value.ToM3String());
			if (m3DT02.HasValue)
				request.WithQueryParameter("DT02", m3DT02.Value.ToM3String());
			if (m3NF01.HasValue)
				request.WithQueryParameter("NF01", m3NF01.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NF02.HasValue)
				request.WithQueryParameter("NF02", m3NF02.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdClaimHeadTx2
		/// Description Updates Claim Head Text
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3CLNO">Claim (Required)</param>
		/// <param name="m3RTX1">Repair Comment 1</param>
		/// <param name="m3RTX2">Repair Comment 2</param>
		/// <param name="m3RTX3">Repair Comment 3</param>
		/// <param name="m3RTX4">Repair Comment 4</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimHeadTx2(
			string m3CLNO, 
			string m3RTX1 = null, 
			string m3RTX2 = null, 
			string m3RTX3 = null, 
			string m3RTX4 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdClaimHeadTx2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CLNO))
				throw new ArgumentNullException(nameof(m3CLNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3CLNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3RTX1))
				request.WithQueryParameter("RTX1", m3RTX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3RTX2))
				request.WithQueryParameter("RTX2", m3RTX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3RTX3))
				request.WithQueryParameter("RTX3", m3RTX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3RTX4))
				request.WithQueryParameter("RTX4", m3RTX4.Trim());

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
		/// Name UpdClaimHeadTxt
		/// Description Updates Claim Head Text
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3CLNO">Claim (Required)</param>
		/// <param name="m3FCLA">Error code 1</param>
		/// <param name="m3ETX1">Error symptom text 1</param>
		/// <param name="m3ETX2">Error symptom text 2</param>
		/// <param name="m3ETX3">Error symptom text 3</param>
		/// <param name="m3ETX4">Error symptom text 4</param>
		/// <param name="m3FCL2">Error code 2</param>
		/// <param name="m3TX60">Error Cause Text line 1</param>
		/// <param name="m3CTX2">Error cause text line 2</param>
		/// <param name="m3CTX3">Error cause text line 2</param>
		/// <param name="m3CTX4">Error cause text line 2</param>
		/// <param name="m3FCL3">Error code 3</param>
		/// <param name="m3MTX1">Text 1</param>
		/// <param name="m3MTX2">Text 2</param>
		/// <param name="m3MTX3">Text 3</param>
		/// <param name="m3MTX4">Text 4</param>
		/// <param name="m3EVTX">Evaluation text 1</param>
		/// <param name="m3EVTM">Evaluation text 2</param>
		/// <param name="m3CLNT">Claim notes</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimHeadTxt(
			string m3CLNO, 
			string m3FCLA = null, 
			string m3ETX1 = null, 
			string m3ETX2 = null, 
			string m3ETX3 = null, 
			string m3ETX4 = null, 
			string m3FCL2 = null, 
			string m3TX60 = null, 
			string m3CTX2 = null, 
			string m3CTX3 = null, 
			string m3CTX4 = null, 
			string m3FCL3 = null, 
			string m3MTX1 = null, 
			string m3MTX2 = null, 
			string m3MTX3 = null, 
			string m3MTX4 = null, 
			string m3EVTX = null, 
			string m3EVTM = null, 
			string m3CLNT = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdClaimHeadTxt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CLNO))
				throw new ArgumentNullException(nameof(m3CLNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3CLNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FCLA))
				request.WithQueryParameter("FCLA", m3FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETX1))
				request.WithQueryParameter("ETX1", m3ETX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETX2))
				request.WithQueryParameter("ETX2", m3ETX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETX3))
				request.WithQueryParameter("ETX3", m3ETX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETX4))
				request.WithQueryParameter("ETX4", m3ETX4.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL2))
				request.WithQueryParameter("FCL2", m3FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX60))
				request.WithQueryParameter("TX60", m3TX60.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTX2))
				request.WithQueryParameter("CTX2", m3CTX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTX3))
				request.WithQueryParameter("CTX3", m3CTX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTX4))
				request.WithQueryParameter("CTX4", m3CTX4.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL3))
				request.WithQueryParameter("FCL3", m3FCL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTX1))
				request.WithQueryParameter("MTX1", m3MTX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTX2))
				request.WithQueryParameter("MTX2", m3MTX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTX3))
				request.WithQueryParameter("MTX3", m3MTX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTX4))
				request.WithQueryParameter("MTX4", m3MTX4.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVTX))
				request.WithQueryParameter("EVTX", m3EVTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVTM))
				request.WithQueryParameter("EVTM", m3EVTM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CLNT))
				request.WithQueryParameter("CLNT", m3CLNT.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdClaimOpen
		/// Description Update Claim Open
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimOpen(
			string m3CLNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdClaimOpen",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CLNO))
				request.WithQueryParameter("CLNO", m3CLNO.Trim());

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
		/// Name UpdClaimReady
		/// Description Update Claim Ready
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimReady(
			string m3CLNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdClaimReady",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CLNO))
				request.WithQueryParameter("CLNO", m3CLNO.Trim());

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
		/// Name UpdClaimReject
		/// Description Update Claim Reject
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimReject(
			string m3CLNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdClaimReject",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CLNO))
				request.WithQueryParameter("CLNO", m3CLNO.Trim());

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
		/// Name UpdClaimReopen
		/// Description Update Claim Reopen
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimReopen(
			string m3CLNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdClaimReopen",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CLNO))
				request.WithQueryParameter("CLNO", m3CLNO.Trim());

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
		/// Name UpdClaimSent
		/// Description Update Claim Sent
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimSent(
			string m3CLNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdClaimSent",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CLNO))
				request.WithQueryParameter("CLNO", m3CLNO.Trim());

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
		/// Name UpdClaimSettled
		/// Description Update Claim Settled
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimSettled(
			string m3CLNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdClaimSettled",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CLNO))
				request.WithQueryParameter("CLNO", m3CLNO.Trim());

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
		/// Name UpdClaimSpec
		/// Description Updates Claim Specification
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3CLNO">Claim (Required)</param>
		/// <param name="m3VENO">Version (Required)</param>
		/// <param name="m3CLSP">Claim spec (Required)</param>
		/// <param name="m3TSEQ">Transaction Sequence number</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3ALNT">Line type</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3ARET">Return date</param>
		/// <param name="m3ARE1">Return Date</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3MCTP">Miscellaneous cost type</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3IVQT">Invoiced quantity - basic U/M</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3AHPR">Handling charge</param>
		/// <param name="m3PSPC">Parts settlement percentage</param>
		/// <param name="m3MFAQ">Mfg approved qty</param>
		/// <param name="m3MFAP">Mfg approved price</param>
		/// <param name="m3MHAA">Mfg handling approved amount</param>
		/// <param name="m3NEPR">Net price</param>
		/// <param name="m3DPRR">Date part return requested</param>
		/// <param name="m3RTND">Part rtn dt ship</param>
		/// <param name="m3DLRM">Remark</param>
		/// <param name="m3TX60">Text</param>
		/// <param name="m3MWNO">Work order number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3AWCO">WIP debit</param>
		/// <param name="m3DIPL">Discount</param>
		/// <param name="m3DIAL">Discount amount</param>
		/// <param name="m3UNIT">Unit of measure</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3APSP">Approved parts settlement percentage</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3TTPE">Time type</param>
		/// <param name="m3SMC0">User defined field 1</param>
		/// <param name="m3SMC1">User defined field 2</param>
		/// <param name="m3SMC2">User defined field 3</param>
		/// <param name="m3SMC3">User defined field 4</param>
		/// <param name="m3SMC4">User defined field 5</param>
		/// <param name="m3SMC5">User defined field 6</param>
		/// <param name="m3SMC6">User defined field 7</param>
		/// <param name="m3SMC7">User defined field 8</param>
		/// <param name="m3SMC8">User defined field 9</param>
		/// <param name="m3SMC9">User defined field 10</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3CFI1">User-defined field 1 - item</param>
		/// <param name="m3CFI2">User-defined field 2 - item</param>
		/// <param name="m3CFI3">User-defined field 3 - item</param>
		/// <param name="m3CFI4">User-defined field 4 - item</param>
		/// <param name="m3CFI5">User-defined field 5 - item</param>
		/// <param name="m3CFI6">User-defined field 6 - item</param>
		/// <param name="m3CFI7">User-defined field 7 - item</param>
		/// <param name="m3CFI8">User-defined field 8 - item</param>
		/// <param name="m3CFI9">User-defined field 9 - item</param>
		/// <param name="m3CFI0">User-defined field 0 - item</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimSpec(
			string m3CLNO, 
			int m3VENO, 
			int m3CLSP, 
			int? m3TSEQ = null, 
			string m3STAT = null, 
			int? m3ALNT = null, 
			string m3ITNO = null, 
			DateTime? m3ARET = null, 
			long? m3ARE1 = null, 
			int? m3MSEQ = null, 
			string m3EMNO = null, 
			string m3PLGR = null, 
			string m3SUNO = null, 
			string m3MCTP = null, 
			string m3WHLO = null, 
			decimal? m3IVQT = null, 
			decimal? m3SAPR = null, 
			decimal? m3AHPR = null, 
			int? m3PSPC = null, 
			decimal? m3MFAQ = null, 
			decimal? m3MFAP = null, 
			decimal? m3MHAA = null, 
			decimal? m3NEPR = null, 
			DateTime? m3DPRR = null, 
			DateTime? m3RTND = null, 
			string m3DLRM = null, 
			string m3TX60 = null, 
			string m3MWNO = null, 
			int? m3OPNO = null, 
			decimal? m3AWCO = null, 
			int? m3DIPL = null, 
			decimal? m3DIAL = null, 
			string m3UNIT = null, 
			decimal? m3TXID = null, 
			string m3SERN = null, 
			int? m3APSP = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			string m3TTPE = null, 
			string m3SMC0 = null, 
			string m3SMC1 = null, 
			string m3SMC2 = null, 
			string m3SMC3 = null, 
			string m3SMC4 = null, 
			string m3SMC5 = null, 
			string m3SMC6 = null, 
			string m3SMC7 = null, 
			string m3SMC8 = null, 
			string m3SMC9 = null, 
			string m3RSCD = null, 
			string m3CFI1 = null, 
			decimal? m3CFI2 = null, 
			string m3CFI3 = null, 
			string m3CFI4 = null, 
			string m3CFI5 = null, 
			string m3CFI6 = null, 
			decimal? m3CFI7 = null, 
			string m3CFI8 = null, 
			string m3CFI9 = null, 
			string m3CFI0 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdClaimSpec",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CLNO))
				throw new ArgumentNullException(nameof(m3CLNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3CLNO.Trim())
				.WithQueryParameter("VENO", m3VENO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CLSP", m3CLSP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3TSEQ.HasValue)
				request.WithQueryParameter("TSEQ", m3TSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3ALNT.HasValue)
				request.WithQueryParameter("ALNT", m3ALNT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3ARET.HasValue)
				request.WithQueryParameter("ARET", m3ARET.Value.ToM3String());
			if (m3ARE1.HasValue)
				request.WithQueryParameter("ARE1", m3ARE1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MCTP))
				request.WithQueryParameter("MCTP", m3MCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3IVQT.HasValue)
				request.WithQueryParameter("IVQT", m3IVQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AHPR.HasValue)
				request.WithQueryParameter("AHPR", m3AHPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PSPC.HasValue)
				request.WithQueryParameter("PSPC", m3PSPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MFAQ.HasValue)
				request.WithQueryParameter("MFAQ", m3MFAQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MFAP.HasValue)
				request.WithQueryParameter("MFAP", m3MFAP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MHAA.HasValue)
				request.WithQueryParameter("MHAA", m3MHAA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NEPR.HasValue)
				request.WithQueryParameter("NEPR", m3NEPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DPRR.HasValue)
				request.WithQueryParameter("DPRR", m3DPRR.Value.ToM3String());
			if (m3RTND.HasValue)
				request.WithQueryParameter("RTND", m3RTND.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3DLRM))
				request.WithQueryParameter("DLRM", m3DLRM.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX60))
				request.WithQueryParameter("TX60", m3TX60.Trim());
			if (!string.IsNullOrWhiteSpace(m3MWNO))
				request.WithQueryParameter("MWNO", m3MWNO.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AWCO.HasValue)
				request.WithQueryParameter("AWCO", m3AWCO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIPL.HasValue)
				request.WithQueryParameter("DIPL", m3DIPL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIAL.HasValue)
				request.WithQueryParameter("DIAL", m3DIAL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3UNIT))
				request.WithQueryParameter("UNIT", m3UNIT.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (m3APSP.HasValue)
				request.WithQueryParameter("APSP", m3APSP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3TTPE))
				request.WithQueryParameter("TTPE", m3TTPE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC0))
				request.WithQueryParameter("SMC0", m3SMC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC1))
				request.WithQueryParameter("SMC1", m3SMC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC2))
				request.WithQueryParameter("SMC2", m3SMC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC3))
				request.WithQueryParameter("SMC3", m3SMC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC4))
				request.WithQueryParameter("SMC4", m3SMC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC5))
				request.WithQueryParameter("SMC5", m3SMC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC6))
				request.WithQueryParameter("SMC6", m3SMC6.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC7))
				request.WithQueryParameter("SMC7", m3SMC7.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC8))
				request.WithQueryParameter("SMC8", m3SMC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC9))
				request.WithQueryParameter("SMC9", m3SMC9.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI1))
				request.WithQueryParameter("CFI1", m3CFI1.Trim());
			if (m3CFI2.HasValue)
				request.WithQueryParameter("CFI2", m3CFI2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFI3))
				request.WithQueryParameter("CFI3", m3CFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI4))
				request.WithQueryParameter("CFI4", m3CFI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI5))
				request.WithQueryParameter("CFI5", m3CFI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI6))
				request.WithQueryParameter("CFI6", m3CFI6.Trim());
			if (m3CFI7.HasValue)
				request.WithQueryParameter("CFI7", m3CFI7.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFI8))
				request.WithQueryParameter("CFI8", m3CFI8.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI9))
				request.WithQueryParameter("CFI9", m3CFI9.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI0))
				request.WithQueryParameter("CFI0", m3CFI0.Trim());

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
		/// Name UpdClaimVer
		/// Description Updates Claim Version
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CLNO">Claim (Required)</param>
		/// <param name="m3VENO">Version (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3DSMM">Date submitted to manufacturer</param>
		/// <param name="m3AAPD">Approval date</param>
		/// <param name="m3REJD">Rejection date</param>
		/// <param name="m3ANDT">Answer recieved date</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimVer(
			string m3CLNO, 
			int m3VENO, 
			string m3TX40 = null, 
			DateTime? m3DSMM = null, 
			DateTime? m3AAPD = null, 
			DateTime? m3REJD = null, 
			DateTime? m3ANDT = null, 
			string m3STAT = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdClaimVer",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CLNO))
				throw new ArgumentNullException(nameof(m3CLNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3CLNO.Trim())
				.WithQueryParameter("VENO", m3VENO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (m3DSMM.HasValue)
				request.WithQueryParameter("DSMM", m3DSMM.Value.ToM3String());
			if (m3AAPD.HasValue)
				request.WithQueryParameter("AAPD", m3AAPD.Value.ToM3String());
			if (m3REJD.HasValue)
				request.WithQueryParameter("REJD", m3REJD.Value.ToM3String());
			if (m3ANDT.HasValue)
				request.WithQueryParameter("ANDT", m3ANDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
