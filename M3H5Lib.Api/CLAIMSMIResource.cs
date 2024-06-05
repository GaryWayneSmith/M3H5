/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddClaimHead
		/// Description Adds Claim Head
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_AAGN">Agreement number (Required)</param>
		/// <param name="m3_CLTP">Claim type (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CLNO">Claim</param>
		/// <param name="m3_ECLN">External Claim Number</param>
		/// <param name="m3_AL03">Prefix</param>
		/// <param name="m3_TEPS">Teps Claim</param>
		/// <param name="m3_CDTE">Claim date</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_PROD">Manufacturer</param>
		/// <param name="m3_PYAG">Payer agreement</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_APRF">Approval reference</param>
		/// <param name="m3_TAIL">Registration number/site</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_OWNC">Owner</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_DEDA">Delivery date</param>
		/// <param name="m3_DSMM">Date submitted to manufacturer</param>
		/// <param name="m3_MES1">Meter 1</param>
		/// <param name="m3_MES2">Meter 2</param>
		/// <param name="m3_MES3">Meter 3</param>
		/// <param name="m3_MES4">Meter 4</param>
		/// <param name="m3_MVA1">Meter value 1</param>
		/// <param name="m3_MVA2">Meter value 2</param>
		/// <param name="m3_MVA3">Meter value 3</param>
		/// <param name="m3_MVA4">Meter value 4</param>
		/// <param name="m3_MES5">Meter 1</param>
		/// <param name="m3_MES6">Meter 2</param>
		/// <param name="m3_MES7">Meter 3</param>
		/// <param name="m3_MES8">Meter 4</param>
		/// <param name="m3_MVA5">Meter value 1</param>
		/// <param name="m3_MVA6">Meter value 2</param>
		/// <param name="m3_MVA7">Meter value 3</param>
		/// <param name="m3_MVA8">Meter value 4</param>
		/// <param name="m3_ITN1">Item Causing Problem</param>
		/// <param name="m3_YMD8">FailureDate</param>
		/// <param name="m3_TSCL">Time stamp closed by mfg</param>
		/// <param name="m3_CNAD">Credit note acceptance date</param>
		/// <param name="m3_CDNN">Credit note number</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_DTRC">Date to recall Customer</param>
		/// <param name="m3_CANT">Call notes</param>
		/// <param name="m3_LCLD">Latest claim date</param>
		/// <param name="m3_WATP">Warranty type</param>
		/// <param name="m3_SMC0">User defined field 1</param>
		/// <param name="m3_SMC1">User defined field 2</param>
		/// <param name="m3_SMC2">User defined field 3</param>
		/// <param name="m3_SMC3">User defined field 4</param>
		/// <param name="m3_SMC4">User defined field 5</param>
		/// <param name="m3_SMC5">User defined field 6</param>
		/// <param name="m3_SMC6">User defined field 7</param>
		/// <param name="m3_SMC7">User defined field 8</param>
		/// <param name="m3_SMC8">User defined field 9</param>
		/// <param name="m3_SMC9">User defined field 10</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_MES0">Meter</param>
		/// <param name="m3_MVA0">Since new</param>
		/// <param name="m3_SECP">Serial number</param>
		/// <param name="m3_FALD">Failure date</param>
		/// <param name="m3_MRDT">Machine ready date</param>
		/// <param name="m3_MRTI">Machine ready time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddClaimHeadResponse></returns>
		/// <exception cref="M3Exception<AddClaimHeadResponse>"></exception>
		public async Task<M3Response<AddClaimHeadResponse>> AddClaimHead(
			string m3_AAGN, 
			string m3_CLTP, 
			string m3_FACI, 
			string m3_CLNO = null, 
			string m3_ECLN = null, 
			string m3_AL03 = null, 
			int? m3_TEPS = null, 
			DateTime? m3_CDTE = null, 
			string m3_STAT = null, 
			string m3_PROD = null, 
			string m3_PYAG = null, 
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_APRF = null, 
			string m3_TAIL = null, 
			string m3_PRNO = null, 
			string m3_BANO = null, 
			string m3_ITNO = null, 
			string m3_SERN = null, 
			string m3_SUFI = null, 
			string m3_STRT = null, 
			string m3_OWNC = null, 
			string m3_CUNO = null, 
			DateTime? m3_DEDA = null, 
			DateTime? m3_DSMM = null, 
			string m3_MES1 = null, 
			string m3_MES2 = null, 
			string m3_MES3 = null, 
			string m3_MES4 = null, 
			decimal? m3_MVA1 = null, 
			decimal? m3_MVA2 = null, 
			decimal? m3_MVA3 = null, 
			decimal? m3_MVA4 = null, 
			string m3_MES5 = null, 
			string m3_MES6 = null, 
			string m3_MES7 = null, 
			string m3_MES8 = null, 
			decimal? m3_MVA5 = null, 
			decimal? m3_MVA6 = null, 
			decimal? m3_MVA7 = null, 
			decimal? m3_MVA8 = null, 
			string m3_ITN1 = null, 
			DateTime? m3_YMD8 = null, 
			decimal? m3_TSCL = null, 
			DateTime? m3_CNAD = null, 
			int? m3_CDNN = null, 
			string m3_RESP = null, 
			string m3_CUCD = null, 
			string m3_RSCD = null, 
			DateTime? m3_DTRC = null, 
			string m3_CANT = null, 
			DateTime? m3_LCLD = null, 
			string m3_WATP = null, 
			string m3_SMC0 = null, 
			string m3_SMC1 = null, 
			string m3_SMC2 = null, 
			string m3_SMC3 = null, 
			string m3_SMC4 = null, 
			string m3_SMC5 = null, 
			string m3_SMC6 = null, 
			string m3_SMC7 = null, 
			string m3_SMC8 = null, 
			string m3_SMC9 = null, 
			decimal? m3_TXID = null, 
			string m3_MES0 = null, 
			decimal? m3_MVA0 = null, 
			string m3_SECP = null, 
			DateTime? m3_FALD = null, 
			DateTime? m3_MRDT = null, 
			int? m3_MRTI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddClaimHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");
			if (string.IsNullOrWhiteSpace(m3_CLTP))
				throw new ArgumentNullException("m3_CLTP");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim())
				.WithQueryParameter("CLTP", m3_CLTP.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CLNO))
				request.WithQueryParameter("CLNO", m3_CLNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECLN))
				request.WithQueryParameter("ECLN", m3_ECLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AL03))
				request.WithQueryParameter("AL03", m3_AL03.Trim());
			if (m3_TEPS.HasValue)
				request.WithQueryParameter("TEPS", m3_TEPS.Value.ToString());
			if (m3_CDTE.HasValue)
				request.WithQueryParameter("CDTE", m3_CDTE.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROD))
				request.WithQueryParameter("PROD", m3_PROD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYAG))
				request.WithQueryParameter("PYAG", m3_PYAG.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_APRF))
				request.WithQueryParameter("APRF", m3_APRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAIL))
				request.WithQueryParameter("TAIL", m3_TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OWNC))
				request.WithQueryParameter("OWNC", m3_OWNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_DEDA.HasValue)
				request.WithQueryParameter("DEDA", m3_DEDA.Value.ToM3String());
			if (m3_DSMM.HasValue)
				request.WithQueryParameter("DSMM", m3_DSMM.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_MES1))
				request.WithQueryParameter("MES1", m3_MES1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES2))
				request.WithQueryParameter("MES2", m3_MES2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES3))
				request.WithQueryParameter("MES3", m3_MES3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES4))
				request.WithQueryParameter("MES4", m3_MES4.Trim());
			if (m3_MVA1.HasValue)
				request.WithQueryParameter("MVA1", m3_MVA1.Value.ToString());
			if (m3_MVA2.HasValue)
				request.WithQueryParameter("MVA2", m3_MVA2.Value.ToString());
			if (m3_MVA3.HasValue)
				request.WithQueryParameter("MVA3", m3_MVA3.Value.ToString());
			if (m3_MVA4.HasValue)
				request.WithQueryParameter("MVA4", m3_MVA4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MES5))
				request.WithQueryParameter("MES5", m3_MES5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES6))
				request.WithQueryParameter("MES6", m3_MES6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES7))
				request.WithQueryParameter("MES7", m3_MES7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES8))
				request.WithQueryParameter("MES8", m3_MES8.Trim());
			if (m3_MVA5.HasValue)
				request.WithQueryParameter("MVA5", m3_MVA5.Value.ToString());
			if (m3_MVA6.HasValue)
				request.WithQueryParameter("MVA6", m3_MVA6.Value.ToString());
			if (m3_MVA7.HasValue)
				request.WithQueryParameter("MVA7", m3_MVA7.Value.ToString());
			if (m3_MVA8.HasValue)
				request.WithQueryParameter("MVA8", m3_MVA8.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITN1))
				request.WithQueryParameter("ITN1", m3_ITN1.Trim());
			if (m3_YMD8.HasValue)
				request.WithQueryParameter("YMD8", m3_YMD8.Value.ToM3String());
			if (m3_TSCL.HasValue)
				request.WithQueryParameter("TSCL", m3_TSCL.Value.ToString());
			if (m3_CNAD.HasValue)
				request.WithQueryParameter("CNAD", m3_CNAD.Value.ToM3String());
			if (m3_CDNN.HasValue)
				request.WithQueryParameter("CDNN", m3_CDNN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (m3_DTRC.HasValue)
				request.WithQueryParameter("DTRC", m3_DTRC.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CANT))
				request.WithQueryParameter("CANT", m3_CANT.Trim());
			if (m3_LCLD.HasValue)
				request.WithQueryParameter("LCLD", m3_LCLD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_WATP))
				request.WithQueryParameter("WATP", m3_WATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC0))
				request.WithQueryParameter("SMC0", m3_SMC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC1))
				request.WithQueryParameter("SMC1", m3_SMC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC2))
				request.WithQueryParameter("SMC2", m3_SMC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC3))
				request.WithQueryParameter("SMC3", m3_SMC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC4))
				request.WithQueryParameter("SMC4", m3_SMC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC5))
				request.WithQueryParameter("SMC5", m3_SMC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC6))
				request.WithQueryParameter("SMC6", m3_SMC6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC7))
				request.WithQueryParameter("SMC7", m3_SMC7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC8))
				request.WithQueryParameter("SMC8", m3_SMC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC9))
				request.WithQueryParameter("SMC9", m3_SMC9.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MES0))
				request.WithQueryParameter("MES0", m3_MES0.Trim());
			if (m3_MVA0.HasValue)
				request.WithQueryParameter("MVA0", m3_MVA0.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SECP))
				request.WithQueryParameter("SECP", m3_SECP.Trim());
			if (m3_FALD.HasValue)
				request.WithQueryParameter("FALD", m3_FALD.Value.ToM3String());
			if (m3_MRDT.HasValue)
				request.WithQueryParameter("MRDT", m3_MRDT.Value.ToM3String());
			if (m3_MRTI.HasValue)
				request.WithQueryParameter("MRTI", m3_MRTI.Value.ToString());

			// Execute the request
			var result = await Execute<AddClaimHeadResponse>(
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
		/// Name AddClaimSpec
		/// Description Adds Claim Specification
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_CLNO">Claim (Required)</param>
		/// <param name="m3_VENO">Version (Required)</param>
		/// <param name="m3_ALNT">Line type (Required)</param>
		/// <param name="m3_IVQT">Invoiced quantity - basic U/M (Required)</param>
		/// <param name="m3_UNIT">Unit of measure (Required)</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_ARET">Return date</param>
		/// <param name="m3_ARE1">Return Date</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_MCTP">Miscellaneous cost type</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_AHPR">Handling charge</param>
		/// <param name="m3_PSPC">Parts settlement percentage</param>
		/// <param name="m3_MFAQ">Mfg approved qty</param>
		/// <param name="m3_MFAP">Mfg approved price</param>
		/// <param name="m3_MHAA">Mfg handling approved amount</param>
		/// <param name="m3_NEPR">Net price</param>
		/// <param name="m3_DPRR">Date part return requested</param>
		/// <param name="m3_RTND">Part rtn dt ship</param>
		/// <param name="m3_DLRM">Remark</param>
		/// <param name="m3_TX60">Text</param>
		/// <param name="m3_MWNO">Work order number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_AWCO">WIP debit</param>
		/// <param name="m3_DIPL">Discount</param>
		/// <param name="m3_DIAL">Discount amount</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_RTPR">Return processing</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_APSP">Approved parts settlement percentage</param>
		/// <param name="m3_TTPE">Time type</param>
		/// <param name="m3_SMC0">User defined field 1</param>
		/// <param name="m3_SMC1">User defined field 2</param>
		/// <param name="m3_SMC2">User defined field 3</param>
		/// <param name="m3_SMC3">User defined field 4</param>
		/// <param name="m3_SMC4">User defined field 5</param>
		/// <param name="m3_SMC5">User defined field 6</param>
		/// <param name="m3_SMC6">User defined field 7</param>
		/// <param name="m3_SMC7">User defined field 8</param>
		/// <param name="m3_SMC8">User defined field 9</param>
		/// <param name="m3_SMC9">User defined field 10</param>
		/// <param name="m3_ALI1">Transaction number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RSCD">New field description</param>
		/// <param name="m3_CFI1">User-defined field 1 - item</param>
		/// <param name="m3_CFI2">User-defined field 2 - item</param>
		/// <param name="m3_CFI3">User-defined field 3 - item</param>
		/// <param name="m3_CFI4">User-defined field 4 - item</param>
		/// <param name="m3_CFI5">User-defined field 5 - item</param>
		/// <param name="m3_CFI6">User-defined field 6 - item</param>
		/// <param name="m3_CFI7">User-defined field 7 - item</param>
		/// <param name="m3_CFI8">User-defined field 8 - item</param>
		/// <param name="m3_CFI9">User-defined field 9 - item</param>
		/// <param name="m3_CFI0">User-defined field 0 - item</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddClaimSpec(
			string m3_CLNO, 
			int m3_VENO, 
			int m3_ALNT, 
			decimal m3_IVQT, 
			string m3_UNIT, 
			string m3_STAT = null, 
			string m3_ITNO = null, 
			DateTime? m3_ARET = null, 
			long? m3_ARE1 = null, 
			int? m3_MSEQ = null, 
			string m3_EMNO = null, 
			string m3_PLGR = null, 
			string m3_SUNO = null, 
			string m3_MCTP = null, 
			string m3_WHLO = null, 
			decimal? m3_SAPR = null, 
			decimal? m3_AHPR = null, 
			int? m3_PSPC = null, 
			decimal? m3_MFAQ = null, 
			decimal? m3_MFAP = null, 
			decimal? m3_MHAA = null, 
			decimal? m3_NEPR = null, 
			DateTime? m3_DPRR = null, 
			DateTime? m3_RTND = null, 
			string m3_DLRM = null, 
			string m3_TX60 = null, 
			string m3_MWNO = null, 
			int? m3_OPNO = null, 
			decimal? m3_AWCO = null, 
			int? m3_DIPL = null, 
			decimal? m3_DIAL = null, 
			decimal? m3_TXID = null, 
			string m3_CUCD = null, 
			string m3_SUFI = null, 
			string m3_STRT = null, 
			int? m3_RTPR = null, 
			string m3_SERN = null, 
			int? m3_APSP = null, 
			string m3_TTPE = null, 
			string m3_SMC0 = null, 
			string m3_SMC1 = null, 
			string m3_SMC2 = null, 
			string m3_SMC3 = null, 
			string m3_SMC4 = null, 
			string m3_SMC5 = null, 
			string m3_SMC6 = null, 
			string m3_SMC7 = null, 
			string m3_SMC8 = null, 
			string m3_SMC9 = null, 
			int? m3_ALI1 = null, 
			int? m3_RORL = null, 
			string m3_RSCD = null, 
			string m3_CFI1 = null, 
			decimal? m3_CFI2 = null, 
			string m3_CFI3 = null, 
			string m3_CFI4 = null, 
			string m3_CFI5 = null, 
			string m3_CFI6 = null, 
			decimal? m3_CFI7 = null, 
			string m3_CFI8 = null, 
			string m3_CFI9 = null, 
			string m3_CFI0 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddClaimSpec",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CLNO))
				throw new ArgumentNullException("m3_CLNO");
			if (string.IsNullOrWhiteSpace(m3_UNIT))
				throw new ArgumentNullException("m3_UNIT");

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3_CLNO.Trim())
				.WithQueryParameter("VENO", m3_VENO.ToString())
				.WithQueryParameter("ALNT", m3_ALNT.ToString())
				.WithQueryParameter("IVQT", m3_IVQT.ToString())
				.WithQueryParameter("UNIT", m3_UNIT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_ARET.HasValue)
				request.WithQueryParameter("ARET", m3_ARET.Value.ToM3String());
			if (m3_ARE1.HasValue)
				request.WithQueryParameter("ARE1", m3_ARE1.Value.ToString());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MCTP))
				request.WithQueryParameter("MCTP", m3_MCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_AHPR.HasValue)
				request.WithQueryParameter("AHPR", m3_AHPR.Value.ToString());
			if (m3_PSPC.HasValue)
				request.WithQueryParameter("PSPC", m3_PSPC.Value.ToString());
			if (m3_MFAQ.HasValue)
				request.WithQueryParameter("MFAQ", m3_MFAQ.Value.ToString());
			if (m3_MFAP.HasValue)
				request.WithQueryParameter("MFAP", m3_MFAP.Value.ToString());
			if (m3_MHAA.HasValue)
				request.WithQueryParameter("MHAA", m3_MHAA.Value.ToString());
			if (m3_NEPR.HasValue)
				request.WithQueryParameter("NEPR", m3_NEPR.Value.ToString());
			if (m3_DPRR.HasValue)
				request.WithQueryParameter("DPRR", m3_DPRR.Value.ToM3String());
			if (m3_RTND.HasValue)
				request.WithQueryParameter("RTND", m3_RTND.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_DLRM))
				request.WithQueryParameter("DLRM", m3_DLRM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX60))
				request.WithQueryParameter("TX60", m3_TX60.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MWNO))
				request.WithQueryParameter("MWNO", m3_MWNO.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_AWCO.HasValue)
				request.WithQueryParameter("AWCO", m3_AWCO.Value.ToString());
			if (m3_DIPL.HasValue)
				request.WithQueryParameter("DIPL", m3_DIPL.Value.ToString());
			if (m3_DIAL.HasValue)
				request.WithQueryParameter("DIAL", m3_DIAL.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_RTPR.HasValue)
				request.WithQueryParameter("RTPR", m3_RTPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (m3_APSP.HasValue)
				request.WithQueryParameter("APSP", m3_APSP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TTPE))
				request.WithQueryParameter("TTPE", m3_TTPE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC0))
				request.WithQueryParameter("SMC0", m3_SMC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC1))
				request.WithQueryParameter("SMC1", m3_SMC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC2))
				request.WithQueryParameter("SMC2", m3_SMC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC3))
				request.WithQueryParameter("SMC3", m3_SMC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC4))
				request.WithQueryParameter("SMC4", m3_SMC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC5))
				request.WithQueryParameter("SMC5", m3_SMC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC6))
				request.WithQueryParameter("SMC6", m3_SMC6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC7))
				request.WithQueryParameter("SMC7", m3_SMC7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC8))
				request.WithQueryParameter("SMC8", m3_SMC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC9))
				request.WithQueryParameter("SMC9", m3_SMC9.Trim());
			if (m3_ALI1.HasValue)
				request.WithQueryParameter("ALI1", m3_ALI1.Value.ToString());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI1))
				request.WithQueryParameter("CFI1", m3_CFI1.Trim());
			if (m3_CFI2.HasValue)
				request.WithQueryParameter("CFI2", m3_CFI2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFI3))
				request.WithQueryParameter("CFI3", m3_CFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI4))
				request.WithQueryParameter("CFI4", m3_CFI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI5))
				request.WithQueryParameter("CFI5", m3_CFI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI6))
				request.WithQueryParameter("CFI6", m3_CFI6.Trim());
			if (m3_CFI7.HasValue)
				request.WithQueryParameter("CFI7", m3_CFI7.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFI8))
				request.WithQueryParameter("CFI8", m3_CFI8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI9))
				request.WithQueryParameter("CFI9", m3_CFI9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI0))
				request.WithQueryParameter("CFI0", m3_CFI0.Trim());

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
		/// Name AddClaimVer
		/// Description Adds Claim Version
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CLNO">Claim (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_DSMM">Date submitted to manufacturer</param>
		/// <param name="m3_AAPD">Approval date</param>
		/// <param name="m3_REJD">Rejection date</param>
		/// <param name="m3_ANDT">Answer recieved date</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddClaimVerResponse></returns>
		/// <exception cref="M3Exception<AddClaimVerResponse>"></exception>
		public async Task<M3Response<AddClaimVerResponse>> AddClaimVer(
			string m3_CLNO, 
			string m3_TX40, 
			DateTime? m3_DSMM = null, 
			DateTime? m3_AAPD = null, 
			DateTime? m3_REJD = null, 
			DateTime? m3_ANDT = null, 
			string m3_STAT = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddClaimVer",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CLNO))
				throw new ArgumentNullException("m3_CLNO");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3_CLNO.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DSMM.HasValue)
				request.WithQueryParameter("DSMM", m3_DSMM.Value.ToM3String());
			if (m3_AAPD.HasValue)
				request.WithQueryParameter("AAPD", m3_AAPD.Value.ToM3String());
			if (m3_REJD.HasValue)
				request.WithQueryParameter("REJD", m3_REJD.Value.ToM3String());
			if (m3_ANDT.HasValue)
				request.WithQueryParameter("ANDT", m3_ANDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

			// Execute the request
			var result = await Execute<AddClaimVerResponse>(
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
		/// Name CreateNewVer
		/// Description Create New Version
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CreateNewVer(
			string m3_CLNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CreateNewVer",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CLNO))
				request.WithQueryParameter("CLNO", m3_CLNO.Trim());

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
		/// Name DelClaimSpec
		/// Description Delete Claim Spec record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CLNO">Claim (Required)</param>
		/// <param name="m3_VENO">Version (Required)</param>
		/// <param name="m3_CLSP">Claim spec (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelClaimSpec(
			string m3_CLNO, 
			int m3_VENO, 
			int m3_CLSP, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelClaimSpec",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CLNO))
				throw new ArgumentNullException("m3_CLNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3_CLNO.Trim())
				.WithQueryParameter("VENO", m3_VENO.ToString())
				.WithQueryParameter("CLSP", m3_CLSP.ToString());

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
		/// Name GetClaimHead
		/// Description Gets Claim Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CLNO">Claim</param>
		/// <param name="m3_ECLN">External Claim Number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetClaimHeadResponse></returns>
		/// <exception cref="M3Exception<GetClaimHeadResponse>"></exception>
		public async Task<M3Response<GetClaimHeadResponse>> GetClaimHead(
			string m3_CLNO = null, 
			string m3_ECLN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetClaimHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CLNO))
				request.WithQueryParameter("CLNO", m3_CLNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECLN))
				request.WithQueryParameter("ECLN", m3_ECLN.Trim());

			// Execute the request
			var result = await Execute<GetClaimHeadResponse>(
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
		/// Name GetClaimHeadFF
		/// Description Get Claim Head Free Fields
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CLNO">Claim (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetClaimHeadFFResponse></returns>
		/// <exception cref="M3Exception<GetClaimHeadFFResponse>"></exception>
		public async Task<M3Response<GetClaimHeadFFResponse>> GetClaimHeadFF(
			string m3_CLNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetClaimHeadFF",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CLNO))
				throw new ArgumentNullException("m3_CLNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3_CLNO.Trim());

			// Execute the request
			var result = await Execute<GetClaimHeadFFResponse>(
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
		/// Name GetClaimHeadTxt
		/// Description Gets Claim Head Text
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CLNO">Claim (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetClaimHeadTxtResponse></returns>
		/// <exception cref="M3Exception<GetClaimHeadTxtResponse>"></exception>
		public async Task<M3Response<GetClaimHeadTxtResponse>> GetClaimHeadTxt(
			string m3_CLNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetClaimHeadTxt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CLNO))
				throw new ArgumentNullException("m3_CLNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3_CLNO.Trim());

			// Execute the request
			var result = await Execute<GetClaimHeadTxtResponse>(
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
		/// Name GetClaimSpec
		/// Description Gets Claim Specifications
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_CLNO">Claim (Required)</param>
		/// <param name="m3_VENO">Version (Required)</param>
		/// <param name="m3_CLSP">Claim spec</param>
		/// <param name="m3_TSEQ">Transaction Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetClaimSpecResponse></returns>
		/// <exception cref="M3Exception<GetClaimSpecResponse>"></exception>
		public async Task<M3Response<GetClaimSpecResponse>> GetClaimSpec(
			string m3_CLNO, 
			int m3_VENO, 
			int? m3_CLSP = null, 
			int? m3_TSEQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetClaimSpec",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CLNO))
				throw new ArgumentNullException("m3_CLNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3_CLNO.Trim())
				.WithQueryParameter("VENO", m3_VENO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CLSP.HasValue)
				request.WithQueryParameter("CLSP", m3_CLSP.Value.ToString());
			if (m3_TSEQ.HasValue)
				request.WithQueryParameter("TSEQ", m3_TSEQ.Value.ToString());

			// Execute the request
			var result = await Execute<GetClaimSpecResponse>(
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
		/// Name GetClaimVer
		/// Description Selects Claim Version
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CLNO">Claim (Required)</param>
		/// <param name="m3_VENO">Version (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetClaimVerResponse></returns>
		/// <exception cref="M3Exception<GetClaimVerResponse>"></exception>
		public async Task<M3Response<GetClaimVerResponse>> GetClaimVer(
			string m3_CLNO, 
			int m3_VENO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetClaimVer",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CLNO))
				throw new ArgumentNullException("m3_CLNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3_CLNO.Trim())
				.WithQueryParameter("VENO", m3_VENO.ToString());

			// Execute the request
			var result = await Execute<GetClaimVerResponse>(
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
		/// Name GetItemFailInfo
		/// Description GetItemFailInfo
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_CLNO">Claim</param>
		/// <param name="m3_ECLN">External claim number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItemFailInfoResponse></returns>
		/// <exception cref="M3Exception<GetItemFailInfoResponse>"></exception>
		public async Task<M3Response<GetItemFailInfoResponse>> GetItemFailInfo(
			string m3_CLNO = null, 
			string m3_ECLN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetItemFailInfo",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CLNO))
				request.WithQueryParameter("CLNO", m3_CLNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECLN))
				request.WithQueryParameter("ECLN", m3_ECLN.Trim());

			// Execute the request
			var result = await Execute<GetItemFailInfoResponse>(
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
		/// Name LstCLHbyRORC
		/// Description Lists Claim Head By RORC
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_RORC">Reference order category (Required)</param>
		/// <param name="m3_RORN">Reference order number (Required)</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCLHbyRORCResponse></returns>
		/// <exception cref="M3Exception<LstCLHbyRORCResponse>"></exception>
		public async Task<M3Response<LstCLHbyRORCResponse>> LstCLHbyRORC(
			int m3_RORC, 
			string m3_RORN, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCLHbyRORC",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RORN))
				throw new ArgumentNullException("m3_RORN");

			// Set mandatory parameters
			request
				.WithQueryParameter("RORC", m3_RORC.ToString())
				.WithQueryParameter("RORN", m3_RORN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());

			// Execute the request
			var result = await Execute<LstCLHbyRORCResponse>(
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
		/// Name LstClaimHead
		/// Description Lists Claim Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstClaimHeadResponse></returns>
		/// <exception cref="M3Exception<LstClaimHeadResponse>"></exception>
		public async Task<M3Response<LstClaimHeadResponse>> LstClaimHead(
			string m3_PRNO = null, 
			string m3_BANO = null, 
			string m3_CLNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstClaimHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CLNO))
				request.WithQueryParameter("CLNO", m3_CLNO.Trim());

			// Execute the request
			var result = await Execute<LstClaimHeadResponse>(
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
		/// Name LstClaimSpec
		/// Description Lists Claim Specifications
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CLNO">Claim (Required)</param>
		/// <param name="m3_VENO">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstClaimSpecResponse></returns>
		/// <exception cref="M3Exception<LstClaimSpecResponse>"></exception>
		public async Task<M3Response<LstClaimSpecResponse>> LstClaimSpec(
			string m3_CLNO, 
			int? m3_VENO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstClaimSpec",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CLNO))
				throw new ArgumentNullException("m3_CLNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3_CLNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_VENO.HasValue)
				request.WithQueryParameter("VENO", m3_VENO.Value.ToString());

			// Execute the request
			var result = await Execute<LstClaimSpecResponse>(
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
		/// Name LstClaimVer
		/// Description Selects Claim Version
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstClaimVerResponse></returns>
		/// <exception cref="M3Exception<LstClaimVerResponse>"></exception>
		public async Task<M3Response<LstClaimVerResponse>> LstClaimVer(
			string m3_CLNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstClaimVer",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CLNO))
				request.WithQueryParameter("CLNO", m3_CLNO.Trim());

			// Execute the request
			var result = await Execute<LstClaimVerResponse>(
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
		/// Name SelClaimHead
		/// Description Selects Claim Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelClaimHeadResponse></returns>
		/// <exception cref="M3Exception<SelClaimHeadResponse>"></exception>
		public async Task<M3Response<SelClaimHeadResponse>> SelClaimHead(
			string m3_PRNO, 
			string m3_BANO = null, 
			string m3_CLNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelClaimHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRNO", m3_PRNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CLNO))
				request.WithQueryParameter("CLNO", m3_CLNO.Trim());

			// Execute the request
			var result = await Execute<SelClaimHeadResponse>(
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
		/// Name SelClaimSpec
		/// Description Selects Claim Specifications
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CLNO">Claim (Required)</param>
		/// <param name="m3_VENO">Version (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelClaimSpecResponse></returns>
		/// <exception cref="M3Exception<SelClaimSpecResponse>"></exception>
		public async Task<M3Response<SelClaimSpecResponse>> SelClaimSpec(
			string m3_CLNO, 
			int m3_VENO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelClaimSpec",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CLNO))
				throw new ArgumentNullException("m3_CLNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3_CLNO.Trim())
				.WithQueryParameter("VENO", m3_VENO.ToString());

			// Execute the request
			var result = await Execute<SelClaimSpecResponse>(
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
		/// Name SelClaimVer
		/// Description Selects Claim Version
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CLNO">Claim (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelClaimVerResponse></returns>
		/// <exception cref="M3Exception<SelClaimVerResponse>"></exception>
		public async Task<M3Response<SelClaimVerResponse>> SelClaimVer(
			string m3_CLNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelClaimVer",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CLNO))
				throw new ArgumentNullException("m3_CLNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3_CLNO.Trim());

			// Execute the request
			var result = await Execute<SelClaimVerResponse>(
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
		/// Name UpdClaimAccept
		/// Description Update Claim Accept
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<UpdClaimAcceptResponse></returns>
		/// <exception cref="M3Exception<UpdClaimAcceptResponse>"></exception>
		public async Task<M3Response<UpdClaimAcceptResponse>> UpdClaimAccept(
			string m3_CLNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdClaimAccept",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CLNO))
				request.WithQueryParameter("CLNO", m3_CLNO.Trim());

			// Execute the request
			var result = await Execute<UpdClaimAcceptResponse>(
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
		/// Name UpdClaimAnswer
		/// Description Update Claim Anwser
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimAnswer(
			string m3_CLNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdClaimAnswer",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CLNO))
				request.WithQueryParameter("CLNO", m3_CLNO.Trim());

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
		/// Name UpdClaimCancel
		/// Description Update Claim Cancel
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimCancel(
			string m3_CLNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdClaimCancel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CLNO))
				request.WithQueryParameter("CLNO", m3_CLNO.Trim());

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
		/// Name UpdClaimClose
		/// Description Update Claim Close
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimClose(
			string m3_CLNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdClaimClose",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CLNO))
				request.WithQueryParameter("CLNO", m3_CLNO.Trim());

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
		/// Name UpdClaimError
		/// Description Update Claim Error
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimError(
			string m3_CLNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdClaimError",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CLNO))
				request.WithQueryParameter("CLNO", m3_CLNO.Trim());

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
		/// Name UpdClaimHead
		/// Description Updates Claim Head
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_CLNO">Claim (Required)</param>
		/// <param name="m3_AL03">Prefix</param>
		/// <param name="m3_CDTE">Claim date</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_PROD">Manufacturer</param>
		/// <param name="m3_PYAG">Payer agreement</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_APRF">Approval reference</param>
		/// <param name="m3_TAIL">Registration number/site</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_AAGN">Agreement number</param>
		/// <param name="m3_OWNC">Owner</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_DEDA">Delivery date</param>
		/// <param name="m3_DSMM">Date submitted to manufacturer</param>
		/// <param name="m3_MES1">Meter 1</param>
		/// <param name="m3_MES2">Meter 2</param>
		/// <param name="m3_MES3">Meter 3</param>
		/// <param name="m3_MES4">Meter 4</param>
		/// <param name="m3_MVA1">Meter value 1</param>
		/// <param name="m3_MVA2">Meter value 2</param>
		/// <param name="m3_MVA3">Meter value 3</param>
		/// <param name="m3_MVA4">Meter value 4</param>
		/// <param name="m3_MES5">Meter 1</param>
		/// <param name="m3_MES6">Meter 2</param>
		/// <param name="m3_MES7">Meter 3</param>
		/// <param name="m3_MES8">Meter 4</param>
		/// <param name="m3_MVA5">Meter value 1</param>
		/// <param name="m3_MVA6">Meter value 2</param>
		/// <param name="m3_MVA7">Meter value 3</param>
		/// <param name="m3_MVA8">Meter value 4</param>
		/// <param name="m3_ITN1">Item number</param>
		/// <param name="m3_YMD8">Date YYYYMMDD</param>
		/// <param name="m3_TSCL">Time stamp closed by mfg</param>
		/// <param name="m3_CNAD">Credit note acceptance date</param>
		/// <param name="m3_CDNN">Credit note number</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_NUM1">Numeric field 1 position</param>
		/// <param name="m3_DTRC">Date to recall Customer</param>
		/// <param name="m3_CANT">Call notes</param>
		/// <param name="m3_LCLD">Latest claim date</param>
		/// <param name="m3_SMC0">User defined field 1</param>
		/// <param name="m3_SMC1">User defined field 2</param>
		/// <param name="m3_SMC2">User defined field 3</param>
		/// <param name="m3_SMC3">User defined field 4</param>
		/// <param name="m3_SMC4">User defined field 5</param>
		/// <param name="m3_SMC5">User defined field 6</param>
		/// <param name="m3_SMC6">User defined field 7</param>
		/// <param name="m3_SMC7">User defined field 8</param>
		/// <param name="m3_SMC8">User defined field 9</param>
		/// <param name="m3_SMC9">User defined field 10</param>
		/// <param name="m3_ECLN">Alpha field 20 positions</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_MES0">Meter</param>
		/// <param name="m3_MVA0">Since new</param>
		/// <param name="m3_SECP">Serial number</param>
		/// <param name="m3_FALD">Failure date</param>
		/// <param name="m3_MRDT">Machine ready date</param>
		/// <param name="m3_MRTI">Machine ready time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimHead(
			string m3_CLNO, 
			string m3_AL03 = null, 
			DateTime? m3_CDTE = null, 
			string m3_STAT = null, 
			string m3_PROD = null, 
			string m3_PYAG = null, 
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_APRF = null, 
			string m3_TAIL = null, 
			string m3_PRNO = null, 
			string m3_BANO = null, 
			string m3_ITNO = null, 
			string m3_SERN = null, 
			string m3_SUFI = null, 
			string m3_STRT = null, 
			string m3_AAGN = null, 
			string m3_OWNC = null, 
			string m3_CUNO = null, 
			DateTime? m3_DEDA = null, 
			DateTime? m3_DSMM = null, 
			string m3_MES1 = null, 
			string m3_MES2 = null, 
			string m3_MES3 = null, 
			string m3_MES4 = null, 
			decimal? m3_MVA1 = null, 
			decimal? m3_MVA2 = null, 
			decimal? m3_MVA3 = null, 
			decimal? m3_MVA4 = null, 
			string m3_MES5 = null, 
			string m3_MES6 = null, 
			string m3_MES7 = null, 
			string m3_MES8 = null, 
			decimal? m3_MVA5 = null, 
			decimal? m3_MVA6 = null, 
			decimal? m3_MVA7 = null, 
			decimal? m3_MVA8 = null, 
			string m3_ITN1 = null, 
			DateTime? m3_YMD8 = null, 
			decimal? m3_TSCL = null, 
			DateTime? m3_CNAD = null, 
			int? m3_CDNN = null, 
			string m3_RESP = null, 
			string m3_CUCD = null, 
			string m3_RSCD = null, 
			int? m3_NUM1 = null, 
			DateTime? m3_DTRC = null, 
			string m3_CANT = null, 
			DateTime? m3_LCLD = null, 
			string m3_SMC0 = null, 
			string m3_SMC1 = null, 
			string m3_SMC2 = null, 
			string m3_SMC3 = null, 
			string m3_SMC4 = null, 
			string m3_SMC5 = null, 
			string m3_SMC6 = null, 
			string m3_SMC7 = null, 
			string m3_SMC8 = null, 
			string m3_SMC9 = null, 
			string m3_ECLN = null, 
			decimal? m3_TXID = null, 
			string m3_MES0 = null, 
			decimal? m3_MVA0 = null, 
			string m3_SECP = null, 
			DateTime? m3_FALD = null, 
			DateTime? m3_MRDT = null, 
			int? m3_MRTI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdClaimHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CLNO))
				throw new ArgumentNullException("m3_CLNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3_CLNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_AL03))
				request.WithQueryParameter("AL03", m3_AL03.Trim());
			if (m3_CDTE.HasValue)
				request.WithQueryParameter("CDTE", m3_CDTE.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROD))
				request.WithQueryParameter("PROD", m3_PROD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYAG))
				request.WithQueryParameter("PYAG", m3_PYAG.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_APRF))
				request.WithQueryParameter("APRF", m3_APRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAIL))
				request.WithQueryParameter("TAIL", m3_TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AAGN))
				request.WithQueryParameter("AAGN", m3_AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OWNC))
				request.WithQueryParameter("OWNC", m3_OWNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_DEDA.HasValue)
				request.WithQueryParameter("DEDA", m3_DEDA.Value.ToM3String());
			if (m3_DSMM.HasValue)
				request.WithQueryParameter("DSMM", m3_DSMM.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_MES1))
				request.WithQueryParameter("MES1", m3_MES1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES2))
				request.WithQueryParameter("MES2", m3_MES2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES3))
				request.WithQueryParameter("MES3", m3_MES3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES4))
				request.WithQueryParameter("MES4", m3_MES4.Trim());
			if (m3_MVA1.HasValue)
				request.WithQueryParameter("MVA1", m3_MVA1.Value.ToString());
			if (m3_MVA2.HasValue)
				request.WithQueryParameter("MVA2", m3_MVA2.Value.ToString());
			if (m3_MVA3.HasValue)
				request.WithQueryParameter("MVA3", m3_MVA3.Value.ToString());
			if (m3_MVA4.HasValue)
				request.WithQueryParameter("MVA4", m3_MVA4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MES5))
				request.WithQueryParameter("MES5", m3_MES5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES6))
				request.WithQueryParameter("MES6", m3_MES6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES7))
				request.WithQueryParameter("MES7", m3_MES7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES8))
				request.WithQueryParameter("MES8", m3_MES8.Trim());
			if (m3_MVA5.HasValue)
				request.WithQueryParameter("MVA5", m3_MVA5.Value.ToString());
			if (m3_MVA6.HasValue)
				request.WithQueryParameter("MVA6", m3_MVA6.Value.ToString());
			if (m3_MVA7.HasValue)
				request.WithQueryParameter("MVA7", m3_MVA7.Value.ToString());
			if (m3_MVA8.HasValue)
				request.WithQueryParameter("MVA8", m3_MVA8.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITN1))
				request.WithQueryParameter("ITN1", m3_ITN1.Trim());
			if (m3_YMD8.HasValue)
				request.WithQueryParameter("YMD8", m3_YMD8.Value.ToM3String());
			if (m3_TSCL.HasValue)
				request.WithQueryParameter("TSCL", m3_TSCL.Value.ToString());
			if (m3_CNAD.HasValue)
				request.WithQueryParameter("CNAD", m3_CNAD.Value.ToM3String());
			if (m3_CDNN.HasValue)
				request.WithQueryParameter("CDNN", m3_CDNN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (m3_NUM1.HasValue)
				request.WithQueryParameter("NUM1", m3_NUM1.Value.ToString());
			if (m3_DTRC.HasValue)
				request.WithQueryParameter("DTRC", m3_DTRC.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CANT))
				request.WithQueryParameter("CANT", m3_CANT.Trim());
			if (m3_LCLD.HasValue)
				request.WithQueryParameter("LCLD", m3_LCLD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_SMC0))
				request.WithQueryParameter("SMC0", m3_SMC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC1))
				request.WithQueryParameter("SMC1", m3_SMC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC2))
				request.WithQueryParameter("SMC2", m3_SMC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC3))
				request.WithQueryParameter("SMC3", m3_SMC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC4))
				request.WithQueryParameter("SMC4", m3_SMC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC5))
				request.WithQueryParameter("SMC5", m3_SMC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC6))
				request.WithQueryParameter("SMC6", m3_SMC6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC7))
				request.WithQueryParameter("SMC7", m3_SMC7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC8))
				request.WithQueryParameter("SMC8", m3_SMC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC9))
				request.WithQueryParameter("SMC9", m3_SMC9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECLN))
				request.WithQueryParameter("ECLN", m3_ECLN.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MES0))
				request.WithQueryParameter("MES0", m3_MES0.Trim());
			if (m3_MVA0.HasValue)
				request.WithQueryParameter("MVA0", m3_MVA0.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SECP))
				request.WithQueryParameter("SECP", m3_SECP.Trim());
			if (m3_FALD.HasValue)
				request.WithQueryParameter("FALD", m3_FALD.Value.ToM3String());
			if (m3_MRDT.HasValue)
				request.WithQueryParameter("MRDT", m3_MRDT.Value.ToM3String());
			if (m3_MRTI.HasValue)
				request.WithQueryParameter("MRTI", m3_MRTI.Value.ToString());

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
		/// Name UpdClaimHeadFF
		/// Description Upd Claim Head Free Fields
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CLNO">Claim (Required)</param>
		/// <param name="m3_FRE1">Text</param>
		/// <param name="m3_FRE2">Text</param>
		/// <param name="m3_FRE3">Text</param>
		/// <param name="m3_FRE4">Text</param>
		/// <param name="m3_FRE5">Text</param>
		/// <param name="m3_FRE6">Text</param>
		/// <param name="m3_FRE7">Text</param>
		/// <param name="m3_FRE8">Text</param>
		/// <param name="m3_FRE9">Text</param>
		/// <param name="m3_FREA">Text</param>
		/// <param name="m3_DT01">Entry date</param>
		/// <param name="m3_DT02">Entry date</param>
		/// <param name="m3_NF01">Numeric field 19¤6 positions</param>
		/// <param name="m3_NF02">Numeric field 19¤6 positions</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimHeadFF(
			string m3_CLNO, 
			string m3_FRE1 = null, 
			string m3_FRE2 = null, 
			string m3_FRE3 = null, 
			string m3_FRE4 = null, 
			string m3_FRE5 = null, 
			string m3_FRE6 = null, 
			string m3_FRE7 = null, 
			string m3_FRE8 = null, 
			string m3_FRE9 = null, 
			string m3_FREA = null, 
			DateTime? m3_DT01 = null, 
			DateTime? m3_DT02 = null, 
			decimal? m3_NF01 = null, 
			decimal? m3_NF02 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdClaimHeadFF",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CLNO))
				throw new ArgumentNullException("m3_CLNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3_CLNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FRE1))
				request.WithQueryParameter("FRE1", m3_FRE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRE2))
				request.WithQueryParameter("FRE2", m3_FRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRE3))
				request.WithQueryParameter("FRE3", m3_FRE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRE4))
				request.WithQueryParameter("FRE4", m3_FRE4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRE5))
				request.WithQueryParameter("FRE5", m3_FRE5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRE6))
				request.WithQueryParameter("FRE6", m3_FRE6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRE7))
				request.WithQueryParameter("FRE7", m3_FRE7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRE8))
				request.WithQueryParameter("FRE8", m3_FRE8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRE9))
				request.WithQueryParameter("FRE9", m3_FRE9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FREA))
				request.WithQueryParameter("FREA", m3_FREA.Trim());
			if (m3_DT01.HasValue)
				request.WithQueryParameter("DT01", m3_DT01.Value.ToM3String());
			if (m3_DT02.HasValue)
				request.WithQueryParameter("DT02", m3_DT02.Value.ToM3String());
			if (m3_NF01.HasValue)
				request.WithQueryParameter("NF01", m3_NF01.Value.ToString());
			if (m3_NF02.HasValue)
				request.WithQueryParameter("NF02", m3_NF02.Value.ToString());

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
		/// Name UpdClaimHeadTx2
		/// Description Updates Claim Head Text
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_CLNO">Claim (Required)</param>
		/// <param name="m3_RTX1">Repair Comment 1</param>
		/// <param name="m3_RTX2">Repair Comment 2</param>
		/// <param name="m3_RTX3">Repair Comment 3</param>
		/// <param name="m3_RTX4">Repair Comment 4</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimHeadTx2(
			string m3_CLNO, 
			string m3_RTX1 = null, 
			string m3_RTX2 = null, 
			string m3_RTX3 = null, 
			string m3_RTX4 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdClaimHeadTx2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CLNO))
				throw new ArgumentNullException("m3_CLNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3_CLNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RTX1))
				request.WithQueryParameter("RTX1", m3_RTX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RTX2))
				request.WithQueryParameter("RTX2", m3_RTX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RTX3))
				request.WithQueryParameter("RTX3", m3_RTX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RTX4))
				request.WithQueryParameter("RTX4", m3_RTX4.Trim());

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
		/// Name UpdClaimHeadTxt
		/// Description Updates Claim Head Text
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_CLNO">Claim (Required)</param>
		/// <param name="m3_FCLA">Error code 1</param>
		/// <param name="m3_ETX1">Error symptom text 1</param>
		/// <param name="m3_ETX2">Error symptom text 2</param>
		/// <param name="m3_ETX3">Error symptom text 3</param>
		/// <param name="m3_ETX4">Error symptom text 4</param>
		/// <param name="m3_FCL2">Error code 2</param>
		/// <param name="m3_TX60">Error Cause Text line 1</param>
		/// <param name="m3_CTX2">Error cause text line 2</param>
		/// <param name="m3_CTX3">Error cause text line 2</param>
		/// <param name="m3_CTX4">Error cause text line 2</param>
		/// <param name="m3_FCL3">Error code 3</param>
		/// <param name="m3_MTX1">Text 1</param>
		/// <param name="m3_MTX2">Text 2</param>
		/// <param name="m3_MTX3">Text 3</param>
		/// <param name="m3_MTX4">Text 4</param>
		/// <param name="m3_EVTX">Evaluation text 1</param>
		/// <param name="m3_EVTM">Evaluation text 2</param>
		/// <param name="m3_CLNT">Claim notes</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimHeadTxt(
			string m3_CLNO, 
			string m3_FCLA = null, 
			string m3_ETX1 = null, 
			string m3_ETX2 = null, 
			string m3_ETX3 = null, 
			string m3_ETX4 = null, 
			string m3_FCL2 = null, 
			string m3_TX60 = null, 
			string m3_CTX2 = null, 
			string m3_CTX3 = null, 
			string m3_CTX4 = null, 
			string m3_FCL3 = null, 
			string m3_MTX1 = null, 
			string m3_MTX2 = null, 
			string m3_MTX3 = null, 
			string m3_MTX4 = null, 
			string m3_EVTX = null, 
			string m3_EVTM = null, 
			string m3_CLNT = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdClaimHeadTxt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CLNO))
				throw new ArgumentNullException("m3_CLNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3_CLNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FCLA))
				request.WithQueryParameter("FCLA", m3_FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETX1))
				request.WithQueryParameter("ETX1", m3_ETX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETX2))
				request.WithQueryParameter("ETX2", m3_ETX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETX3))
				request.WithQueryParameter("ETX3", m3_ETX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETX4))
				request.WithQueryParameter("ETX4", m3_ETX4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL2))
				request.WithQueryParameter("FCL2", m3_FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX60))
				request.WithQueryParameter("TX60", m3_TX60.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTX2))
				request.WithQueryParameter("CTX2", m3_CTX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTX3))
				request.WithQueryParameter("CTX3", m3_CTX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTX4))
				request.WithQueryParameter("CTX4", m3_CTX4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL3))
				request.WithQueryParameter("FCL3", m3_FCL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTX1))
				request.WithQueryParameter("MTX1", m3_MTX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTX2))
				request.WithQueryParameter("MTX2", m3_MTX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTX3))
				request.WithQueryParameter("MTX3", m3_MTX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTX4))
				request.WithQueryParameter("MTX4", m3_MTX4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVTX))
				request.WithQueryParameter("EVTX", m3_EVTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVTM))
				request.WithQueryParameter("EVTM", m3_EVTM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CLNT))
				request.WithQueryParameter("CLNT", m3_CLNT.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
		/// Name UpdClaimOpen
		/// Description Update Claim Open
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimOpen(
			string m3_CLNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdClaimOpen",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CLNO))
				request.WithQueryParameter("CLNO", m3_CLNO.Trim());

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
		/// Name UpdClaimReady
		/// Description Update Claim Ready
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimReady(
			string m3_CLNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdClaimReady",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CLNO))
				request.WithQueryParameter("CLNO", m3_CLNO.Trim());

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
		/// Name UpdClaimReject
		/// Description Update Claim Reject
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimReject(
			string m3_CLNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdClaimReject",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CLNO))
				request.WithQueryParameter("CLNO", m3_CLNO.Trim());

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
		/// Name UpdClaimReopen
		/// Description Update Claim Reopen
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimReopen(
			string m3_CLNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdClaimReopen",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CLNO))
				request.WithQueryParameter("CLNO", m3_CLNO.Trim());

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
		/// Name UpdClaimSent
		/// Description Update Claim Sent
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimSent(
			string m3_CLNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdClaimSent",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CLNO))
				request.WithQueryParameter("CLNO", m3_CLNO.Trim());

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
		/// Name UpdClaimSettled
		/// Description Update Claim Settled
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_CLNO">Claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimSettled(
			string m3_CLNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdClaimSettled",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CLNO))
				request.WithQueryParameter("CLNO", m3_CLNO.Trim());

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
		/// Name UpdClaimSpec
		/// Description Updates Claim Specification
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_CLNO">Claim (Required)</param>
		/// <param name="m3_VENO">Version (Required)</param>
		/// <param name="m3_CLSP">Claim spec (Required)</param>
		/// <param name="m3_TSEQ">Transaction Sequence number</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_ALNT">Line type</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_ARET">Return date</param>
		/// <param name="m3_ARE1">Return Date</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_MCTP">Miscellaneous cost type</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_IVQT">Invoiced quantity - basic U/M</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_AHPR">Handling charge</param>
		/// <param name="m3_PSPC">Parts settlement percentage</param>
		/// <param name="m3_MFAQ">Mfg approved qty</param>
		/// <param name="m3_MFAP">Mfg approved price</param>
		/// <param name="m3_MHAA">Mfg handling approved amount</param>
		/// <param name="m3_NEPR">Net price</param>
		/// <param name="m3_DPRR">Date part return requested</param>
		/// <param name="m3_RTND">Part rtn dt ship</param>
		/// <param name="m3_DLRM">Remark</param>
		/// <param name="m3_TX60">Text</param>
		/// <param name="m3_MWNO">Work order number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_AWCO">WIP debit</param>
		/// <param name="m3_DIPL">Discount</param>
		/// <param name="m3_DIAL">Discount amount</param>
		/// <param name="m3_UNIT">Unit of measure</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_APSP">Approved parts settlement percentage</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_TTPE">Time type</param>
		/// <param name="m3_SMC0">User defined field 1</param>
		/// <param name="m3_SMC1">User defined field 2</param>
		/// <param name="m3_SMC2">User defined field 3</param>
		/// <param name="m3_SMC3">User defined field 4</param>
		/// <param name="m3_SMC4">User defined field 5</param>
		/// <param name="m3_SMC5">User defined field 6</param>
		/// <param name="m3_SMC6">User defined field 7</param>
		/// <param name="m3_SMC7">User defined field 8</param>
		/// <param name="m3_SMC8">User defined field 9</param>
		/// <param name="m3_SMC9">User defined field 10</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_CFI1">User-defined field 1 - item</param>
		/// <param name="m3_CFI2">User-defined field 2 - item</param>
		/// <param name="m3_CFI3">User-defined field 3 - item</param>
		/// <param name="m3_CFI4">User-defined field 4 - item</param>
		/// <param name="m3_CFI5">User-defined field 5 - item</param>
		/// <param name="m3_CFI6">User-defined field 6 - item</param>
		/// <param name="m3_CFI7">User-defined field 7 - item</param>
		/// <param name="m3_CFI8">User-defined field 8 - item</param>
		/// <param name="m3_CFI9">User-defined field 9 - item</param>
		/// <param name="m3_CFI0">User-defined field 0 - item</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimSpec(
			string m3_CLNO, 
			int m3_VENO, 
			int m3_CLSP, 
			int? m3_TSEQ = null, 
			string m3_STAT = null, 
			int? m3_ALNT = null, 
			string m3_ITNO = null, 
			DateTime? m3_ARET = null, 
			long? m3_ARE1 = null, 
			int? m3_MSEQ = null, 
			string m3_EMNO = null, 
			string m3_PLGR = null, 
			string m3_SUNO = null, 
			string m3_MCTP = null, 
			string m3_WHLO = null, 
			decimal? m3_IVQT = null, 
			decimal? m3_SAPR = null, 
			decimal? m3_AHPR = null, 
			int? m3_PSPC = null, 
			decimal? m3_MFAQ = null, 
			decimal? m3_MFAP = null, 
			decimal? m3_MHAA = null, 
			decimal? m3_NEPR = null, 
			DateTime? m3_DPRR = null, 
			DateTime? m3_RTND = null, 
			string m3_DLRM = null, 
			string m3_TX60 = null, 
			string m3_MWNO = null, 
			int? m3_OPNO = null, 
			decimal? m3_AWCO = null, 
			int? m3_DIPL = null, 
			decimal? m3_DIAL = null, 
			string m3_UNIT = null, 
			decimal? m3_TXID = null, 
			string m3_SERN = null, 
			int? m3_APSP = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			string m3_TTPE = null, 
			string m3_SMC0 = null, 
			string m3_SMC1 = null, 
			string m3_SMC2 = null, 
			string m3_SMC3 = null, 
			string m3_SMC4 = null, 
			string m3_SMC5 = null, 
			string m3_SMC6 = null, 
			string m3_SMC7 = null, 
			string m3_SMC8 = null, 
			string m3_SMC9 = null, 
			string m3_RSCD = null, 
			string m3_CFI1 = null, 
			decimal? m3_CFI2 = null, 
			string m3_CFI3 = null, 
			string m3_CFI4 = null, 
			string m3_CFI5 = null, 
			string m3_CFI6 = null, 
			decimal? m3_CFI7 = null, 
			string m3_CFI8 = null, 
			string m3_CFI9 = null, 
			string m3_CFI0 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdClaimSpec",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CLNO))
				throw new ArgumentNullException("m3_CLNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3_CLNO.Trim())
				.WithQueryParameter("VENO", m3_VENO.ToString())
				.WithQueryParameter("CLSP", m3_CLSP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_TSEQ.HasValue)
				request.WithQueryParameter("TSEQ", m3_TSEQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_ALNT.HasValue)
				request.WithQueryParameter("ALNT", m3_ALNT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_ARET.HasValue)
				request.WithQueryParameter("ARET", m3_ARET.Value.ToM3String());
			if (m3_ARE1.HasValue)
				request.WithQueryParameter("ARE1", m3_ARE1.Value.ToString());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MCTP))
				request.WithQueryParameter("MCTP", m3_MCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_IVQT.HasValue)
				request.WithQueryParameter("IVQT", m3_IVQT.Value.ToString());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_AHPR.HasValue)
				request.WithQueryParameter("AHPR", m3_AHPR.Value.ToString());
			if (m3_PSPC.HasValue)
				request.WithQueryParameter("PSPC", m3_PSPC.Value.ToString());
			if (m3_MFAQ.HasValue)
				request.WithQueryParameter("MFAQ", m3_MFAQ.Value.ToString());
			if (m3_MFAP.HasValue)
				request.WithQueryParameter("MFAP", m3_MFAP.Value.ToString());
			if (m3_MHAA.HasValue)
				request.WithQueryParameter("MHAA", m3_MHAA.Value.ToString());
			if (m3_NEPR.HasValue)
				request.WithQueryParameter("NEPR", m3_NEPR.Value.ToString());
			if (m3_DPRR.HasValue)
				request.WithQueryParameter("DPRR", m3_DPRR.Value.ToM3String());
			if (m3_RTND.HasValue)
				request.WithQueryParameter("RTND", m3_RTND.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_DLRM))
				request.WithQueryParameter("DLRM", m3_DLRM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX60))
				request.WithQueryParameter("TX60", m3_TX60.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MWNO))
				request.WithQueryParameter("MWNO", m3_MWNO.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_AWCO.HasValue)
				request.WithQueryParameter("AWCO", m3_AWCO.Value.ToString());
			if (m3_DIPL.HasValue)
				request.WithQueryParameter("DIPL", m3_DIPL.Value.ToString());
			if (m3_DIAL.HasValue)
				request.WithQueryParameter("DIAL", m3_DIAL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNIT))
				request.WithQueryParameter("UNIT", m3_UNIT.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (m3_APSP.HasValue)
				request.WithQueryParameter("APSP", m3_APSP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TTPE))
				request.WithQueryParameter("TTPE", m3_TTPE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC0))
				request.WithQueryParameter("SMC0", m3_SMC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC1))
				request.WithQueryParameter("SMC1", m3_SMC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC2))
				request.WithQueryParameter("SMC2", m3_SMC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC3))
				request.WithQueryParameter("SMC3", m3_SMC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC4))
				request.WithQueryParameter("SMC4", m3_SMC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC5))
				request.WithQueryParameter("SMC5", m3_SMC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC6))
				request.WithQueryParameter("SMC6", m3_SMC6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC7))
				request.WithQueryParameter("SMC7", m3_SMC7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC8))
				request.WithQueryParameter("SMC8", m3_SMC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC9))
				request.WithQueryParameter("SMC9", m3_SMC9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI1))
				request.WithQueryParameter("CFI1", m3_CFI1.Trim());
			if (m3_CFI2.HasValue)
				request.WithQueryParameter("CFI2", m3_CFI2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFI3))
				request.WithQueryParameter("CFI3", m3_CFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI4))
				request.WithQueryParameter("CFI4", m3_CFI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI5))
				request.WithQueryParameter("CFI5", m3_CFI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI6))
				request.WithQueryParameter("CFI6", m3_CFI6.Trim());
			if (m3_CFI7.HasValue)
				request.WithQueryParameter("CFI7", m3_CFI7.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFI8))
				request.WithQueryParameter("CFI8", m3_CFI8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI9))
				request.WithQueryParameter("CFI9", m3_CFI9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI0))
				request.WithQueryParameter("CFI0", m3_CFI0.Trim());

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
		/// Name UpdClaimVer
		/// Description Updates Claim Version
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CLNO">Claim (Required)</param>
		/// <param name="m3_VENO">Version (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_DSMM">Date submitted to manufacturer</param>
		/// <param name="m3_AAPD">Approval date</param>
		/// <param name="m3_REJD">Rejection date</param>
		/// <param name="m3_ANDT">Answer recieved date</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimVer(
			string m3_CLNO, 
			int m3_VENO, 
			string m3_TX40 = null, 
			DateTime? m3_DSMM = null, 
			DateTime? m3_AAPD = null, 
			DateTime? m3_REJD = null, 
			DateTime? m3_ANDT = null, 
			string m3_STAT = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdClaimVer",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CLNO))
				throw new ArgumentNullException("m3_CLNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3_CLNO.Trim())
				.WithQueryParameter("VENO", m3_VENO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (m3_DSMM.HasValue)
				request.WithQueryParameter("DSMM", m3_DSMM.Value.ToM3String());
			if (m3_AAPD.HasValue)
				request.WithQueryParameter("AAPD", m3_AAPD.Value.ToM3String());
			if (m3_REJD.HasValue)
				request.WithQueryParameter("REJD", m3_REJD.Value.ToM3String());
			if (m3_ANDT.HasValue)
				request.WithQueryParameter("ANDT", m3_ANDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
