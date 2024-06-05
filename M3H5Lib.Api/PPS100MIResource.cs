/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PPS100MI;
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
	/// Name: PPS100MI
	/// Component Name: PurchaseAgreement
	/// Description: Purchase agreement interface
	/// Version Release: 5ea5
	///</summary>
	public partial class PPS100MIResource : M3BaseResourceEndpoint
	{
		public PPS100MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PPS100MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAgrHead
		/// Description Create new agreement head
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_AGTP">Agreement type (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_UVDT">Valid to</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_TX30">Text</param>
		/// <param name="m3_AGRD">Agreement date</param>
		/// <param name="m3_RNDT">Renewal date</param>
		/// <param name="m3_PAST">Status - supplier agreement</param>
		/// <param name="m3_TENT">Period of notice</param>
		/// <param name="m3_BUYE">Buyer</param>
		/// <param name="m3_AGPT">Agreement priority</param>
		/// <param name="m3_RFID">Reference</param>
		/// <param name="m3_QREM">Update purchased quantity</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_TEPA">Packaging terms</param>
		/// <param name="m3_CRTP">Exchange rate type</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TEDL">Delivery terms</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_TEAF">Freight terms</param>
		/// <param name="m3_CIVC">Check item/supplier combination</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_VAGN">Supplier agreement number</param>
		/// <param name="m3_DIP2">Discount 2</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_SBAN">Self-billing agreement number</param>
		/// <param name="m3_ACGR">Object access group</param>
		/// <param name="m3_PGDP">Number of print generations</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddAgrHeadResponse></returns>
		/// <exception cref="M3Exception<AddAgrHeadResponse>"></exception>
		public async Task<M3Response<AddAgrHeadResponse>> AddAgrHead(
			string m3_SUNO, 
			string m3_AGTP, 
			DateTime m3_FVDT, 
			int? m3_CONO = null, 
			DateTime? m3_UVDT = null, 
			string m3_AGNB = null, 
			string m3_TX30 = null, 
			DateTime? m3_AGRD = null, 
			DateTime? m3_RNDT = null, 
			string m3_PAST = null, 
			int? m3_TENT = null, 
			string m3_BUYE = null, 
			int? m3_AGPT = null, 
			string m3_RFID = null, 
			int? m3_QREM = null, 
			string m3_CUCD = null, 
			string m3_TEPA = null, 
			int? m3_CRTP = null, 
			string m3_MODL = null, 
			string m3_TEDL = null, 
			string m3_TEPY = null, 
			string m3_TEAF = null, 
			int? m3_CIVC = null, 
			string m3_WHLO = null, 
			string m3_VAGN = null, 
			int? m3_DIP2 = null, 
			string m3_FACI = null, 
			string m3_SBAN = null, 
			string m3_ACGR = null, 
			int? m3_PGDP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAgrHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_AGTP))
				throw new ArgumentNullException("m3_AGTP");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("AGTP", m3_AGTP.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_UVDT.HasValue)
				request.WithQueryParameter("UVDT", m3_UVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX30))
				request.WithQueryParameter("TX30", m3_TX30.Trim());
			if (m3_AGRD.HasValue)
				request.WithQueryParameter("AGRD", m3_AGRD.Value.ToM3String());
			if (m3_RNDT.HasValue)
				request.WithQueryParameter("RNDT", m3_RNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PAST))
				request.WithQueryParameter("PAST", m3_PAST.Trim());
			if (m3_TENT.HasValue)
				request.WithQueryParameter("TENT", m3_TENT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BUYE))
				request.WithQueryParameter("BUYE", m3_BUYE.Trim());
			if (m3_AGPT.HasValue)
				request.WithQueryParameter("AGPT", m3_AGPT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RFID))
				request.WithQueryParameter("RFID", m3_RFID.Trim());
			if (m3_QREM.HasValue)
				request.WithQueryParameter("QREM", m3_QREM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (m3_CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3_CRTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEAF))
				request.WithQueryParameter("TEAF", m3_TEAF.Trim());
			if (m3_CIVC.HasValue)
				request.WithQueryParameter("CIVC", m3_CIVC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAGN))
				request.WithQueryParameter("VAGN", m3_VAGN.Trim());
			if (m3_DIP2.HasValue)
				request.WithQueryParameter("DIP2", m3_DIP2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SBAN))
				request.WithQueryParameter("SBAN", m3_SBAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACGR))
				request.WithQueryParameter("ACGR", m3_ACGR.Trim());
			if (m3_PGDP.HasValue)
				request.WithQueryParameter("PGDP", m3_PGDP.Value.ToString());

			// Execute the request
			var result = await Execute<AddAgrHeadResponse>(
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
		/// Name AddAgrLine
		/// Description Create new agreement line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_GRPI">Group identity (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_PUPR">Purchase price (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_UVDT">Valid to</param>
		/// <param name="m3_SAGL">Status agreement line</param>
		/// <param name="m3_SUPR">Setup price</param>
		/// <param name="m3_PUCD">Purchase price quantity</param>
		/// <param name="m3_UASU">Update material plan</param>
		/// <param name="m3_DIP3">Discount 3</param>
		/// <param name="m3_AGQT">Agreed quantity</param>
		/// <param name="m3_VOLI">Purchase commitment</param>
		/// <param name="m3_PTCD">Purchase price text</param>
		/// <param name="m3_REQU">Renewal quantity</param>
		/// <param name="m3_RENA">Agreement renewal amount</param>
		/// <param name="m3_BOGE">Bonus item</param>
		/// <param name="m3_BOFO">Bonus generating</param>
		/// <param name="m3_PODI">Order total discount base</param>
		/// <param name="m3_LEA1">Supply lead time</param>
		/// <param name="m3_WAL1">Warranty limit 1</param>
		/// <param name="m3_WAL2">Warranty limit 2</param>
		/// <param name="m3_WAL3">Warranty limit 3</param>
		/// <param name="m3_WAL4">Warranty limit 4</param>
		/// <param name="m3_ORCO">Country of origin</param>
		/// <param name="m3_SCPM">Service type</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_DEFD">Detention free lead time - days</param>
		/// <param name="m3_DEFH">Detention free lead time - hours</param>
		/// <param name="m3_DEFM">Detention free lead time - minutes</param>
		/// <param name="m3_WSCA">Costing model</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAgrLine(
			string m3_SUNO, 
			string m3_AGNB, 
			int m3_GRPI, 
			string m3_OBV1, 
			DateTime m3_FVDT, 
			decimal m3_PUPR, 
			int? m3_CONO = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
			DateTime? m3_UVDT = null, 
			int? m3_SAGL = null, 
			decimal? m3_SUPR = null, 
			int? m3_PUCD = null, 
			int? m3_UASU = null, 
			int? m3_DIP3 = null, 
			decimal? m3_AGQT = null, 
			string m3_VOLI = null, 
			int? m3_PTCD = null, 
			decimal? m3_REQU = null, 
			decimal? m3_RENA = null, 
			int? m3_BOGE = null, 
			int? m3_BOFO = null, 
			int? m3_PODI = null, 
			int? m3_LEA1 = null, 
			decimal? m3_WAL1 = null, 
			decimal? m3_WAL2 = null, 
			decimal? m3_WAL3 = null, 
			decimal? m3_WAL4 = null, 
			string m3_ORCO = null, 
			int? m3_SCPM = null, 
			string m3_FACI = null, 
			int? m3_DEFD = null, 
			int? m3_DEFH = null, 
			int? m3_DEFM = null, 
			string m3_WSCA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAgrLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("GRPI", m3_GRPI.ToString())
				.WithQueryParameter("OBV1", m3_OBV1.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String())
				.WithQueryParameter("PUPR", m3_PUPR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (m3_UVDT.HasValue)
				request.WithQueryParameter("UVDT", m3_UVDT.Value.ToM3String());
			if (m3_SAGL.HasValue)
				request.WithQueryParameter("SAGL", m3_SAGL.Value.ToString());
			if (m3_SUPR.HasValue)
				request.WithQueryParameter("SUPR", m3_SUPR.Value.ToString());
			if (m3_PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3_PUCD.Value.ToString());
			if (m3_UASU.HasValue)
				request.WithQueryParameter("UASU", m3_UASU.Value.ToString());
			if (m3_DIP3.HasValue)
				request.WithQueryParameter("DIP3", m3_DIP3.Value.ToString());
			if (m3_AGQT.HasValue)
				request.WithQueryParameter("AGQT", m3_AGQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_VOLI))
				request.WithQueryParameter("VOLI", m3_VOLI.Trim());
			if (m3_PTCD.HasValue)
				request.WithQueryParameter("PTCD", m3_PTCD.Value.ToString());
			if (m3_REQU.HasValue)
				request.WithQueryParameter("REQU", m3_REQU.Value.ToString());
			if (m3_RENA.HasValue)
				request.WithQueryParameter("RENA", m3_RENA.Value.ToString());
			if (m3_BOGE.HasValue)
				request.WithQueryParameter("BOGE", m3_BOGE.Value.ToString());
			if (m3_BOFO.HasValue)
				request.WithQueryParameter("BOFO", m3_BOFO.Value.ToString());
			if (m3_PODI.HasValue)
				request.WithQueryParameter("PODI", m3_PODI.Value.ToString());
			if (m3_LEA1.HasValue)
				request.WithQueryParameter("LEA1", m3_LEA1.Value.ToString());
			if (m3_WAL1.HasValue)
				request.WithQueryParameter("WAL1", m3_WAL1.Value.ToString());
			if (m3_WAL2.HasValue)
				request.WithQueryParameter("WAL2", m3_WAL2.Value.ToString());
			if (m3_WAL3.HasValue)
				request.WithQueryParameter("WAL3", m3_WAL3.Value.ToString());
			if (m3_WAL4.HasValue)
				request.WithQueryParameter("WAL4", m3_WAL4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (m3_SCPM.HasValue)
				request.WithQueryParameter("SCPM", m3_SCPM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (m3_DEFD.HasValue)
				request.WithQueryParameter("DEFD", m3_DEFD.Value.ToString());
			if (m3_DEFH.HasValue)
				request.WithQueryParameter("DEFH", m3_DEFH.Value.ToString());
			if (m3_DEFM.HasValue)
				request.WithQueryParameter("DEFM", m3_DEFM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WSCA))
				request.WithQueryParameter("WSCA", m3_WSCA.Trim());

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
		/// Name AddStgPrice
		/// Description Add staggered price
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_GRPI">Group identity (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_FRQT">From quantity (Required)</param>
		/// <param name="m3_PUPR">Purchase price (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_DIP3">Discount 3</param>
		/// <param name="m3_MAPR">Normal price</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddStgPrice(
			string m3_SUNO, 
			string m3_AGNB, 
			int m3_GRPI, 
			string m3_OBV1, 
			DateTime m3_FVDT, 
			decimal m3_FRQT, 
			decimal m3_PUPR, 
			int? m3_CONO = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
			int? m3_DIP3 = null, 
			int? m3_MAPR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddStgPrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("GRPI", m3_GRPI.ToString())
				.WithQueryParameter("OBV1", m3_OBV1.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String())
				.WithQueryParameter("FRQT", m3_FRQT.ToString())
				.WithQueryParameter("PUPR", m3_PUPR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (m3_DIP3.HasValue)
				request.WithQueryParameter("DIP3", m3_DIP3.Value.ToString());
			if (m3_MAPR.HasValue)
				request.WithQueryParameter("MAPR", m3_MAPR.Value.ToString());

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
		/// Name GetAgrHead
		/// Description Get agreement head information
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgrHeadResponse></returns>
		/// <exception cref="M3Exception<GetAgrHeadResponse>"></exception>
		public async Task<M3Response<GetAgrHeadResponse>> GetAgrHead(
			string m3_SUNO, 
			string m3_AGNB, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAgrHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("AGNB", m3_AGNB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetAgrHeadResponse>(
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
		/// Name GetAgrLine
		/// Description Get agreement line information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_GRPI">Group identity (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgrLineResponse></returns>
		/// <exception cref="M3Exception<GetAgrLineResponse>"></exception>
		public async Task<M3Response<GetAgrLineResponse>> GetAgrLine(
			string m3_SUNO, 
			string m3_AGNB, 
			int m3_GRPI, 
			string m3_OBV1, 
			DateTime m3_FVDT, 
			int? m3_CONO = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAgrLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("GRPI", m3_GRPI.ToString())
				.WithQueryParameter("OBV1", m3_OBV1.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());

			// Execute the request
			var result = await Execute<GetAgrLineResponse>(
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
		/// Name LstAgrHead
		/// Description List agreement heads
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrHeadResponse></returns>
		/// <exception cref="M3Exception<LstAgrHeadResponse>"></exception>
		public async Task<M3Response<LstAgrHeadResponse>> LstAgrHead(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgrHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstAgrHeadResponse>(
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
		/// Name LstAgrHeadBySup
		/// Description List agreement head by supplier
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_VAGN">Supplier agreement number</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrHeadBySupResponse></returns>
		/// <exception cref="M3Exception<LstAgrHeadBySupResponse>"></exception>
		public async Task<M3Response<LstAgrHeadBySupResponse>> LstAgrHeadBySup(
			string m3_SUNO = null, 
			string m3_VAGN = null, 
			DateTime? m3_FVDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgrHeadBySup",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAGN))
				request.WithQueryParameter("VAGN", m3_VAGN.Trim());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstAgrHeadBySupResponse>(
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
		/// Name LstAgrLine
		/// Description List agreement lines
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrLineResponse></returns>
		/// <exception cref="M3Exception<LstAgrLineResponse>"></exception>
		public async Task<M3Response<LstAgrLineResponse>> LstAgrLine(
			string m3_SUNO, 
			string m3_AGNB, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgrLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("AGNB", m3_AGNB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstAgrLineResponse>(
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
		/// Name LstStgPrice
		/// Description List staggered prices
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_GRPI">Group identity (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstStgPriceResponse></returns>
		/// <exception cref="M3Exception<LstStgPriceResponse>"></exception>
		public async Task<M3Response<LstStgPriceResponse>> LstStgPrice(
			string m3_SUNO, 
			string m3_AGNB, 
			int m3_GRPI, 
			string m3_OBV1, 
			DateTime m3_FVDT, 
			int? m3_CONO = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstStgPrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("GRPI", m3_GRPI.ToString())
				.WithQueryParameter("OBV1", m3_OBV1.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());

			// Execute the request
			var result = await Execute<LstStgPriceResponse>(
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
		/// Name UpdAgrHead
		/// Description Update Agreement Head
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_UVDT">Valid to</param>
		/// <param name="m3_TX30">Text</param>
		/// <param name="m3_AGRD">Agreement date</param>
		/// <param name="m3_PAST">Status - supplier agreement</param>
		/// <param name="m3_BUYE">Buyer</param>
		/// <param name="m3_AGPT">Agreement priority</param>
		/// <param name="m3_RFID">Reference</param>
		/// <param name="m3_QREM">Update purchased quantity</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_TEPA">Packaging terms</param>
		/// <param name="m3_CRTP">Exchange rate type</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TEDL">Delivery terms</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_TEAF">Freight terms</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_VAGN">Supplier agreement number</param>
		/// <param name="m3_DIP2">Discount 2</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_SBAN">Self-billing agreement number</param>
		/// <param name="m3_ACGR">Object access group</param>
		/// <param name="m3_PGDP">Number of print generations</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAgrHead(
			string m3_SUNO, 
			string m3_AGNB, 
			int? m3_CONO = null, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_UVDT = null, 
			string m3_TX30 = null, 
			DateTime? m3_AGRD = null, 
			string m3_PAST = null, 
			string m3_BUYE = null, 
			int? m3_AGPT = null, 
			string m3_RFID = null, 
			int? m3_QREM = null, 
			string m3_CUCD = null, 
			string m3_TEPA = null, 
			int? m3_CRTP = null, 
			string m3_MODL = null, 
			string m3_TEDL = null, 
			string m3_TEPY = null, 
			string m3_TEAF = null, 
			string m3_WHLO = null, 
			string m3_VAGN = null, 
			int? m3_DIP2 = null, 
			string m3_FACI = null, 
			string m3_SBAN = null, 
			string m3_ACGR = null, 
			int? m3_PGDP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdAgrHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("AGNB", m3_AGNB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_UVDT.HasValue)
				request.WithQueryParameter("UVDT", m3_UVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TX30))
				request.WithQueryParameter("TX30", m3_TX30.Trim());
			if (m3_AGRD.HasValue)
				request.WithQueryParameter("AGRD", m3_AGRD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PAST))
				request.WithQueryParameter("PAST", m3_PAST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BUYE))
				request.WithQueryParameter("BUYE", m3_BUYE.Trim());
			if (m3_AGPT.HasValue)
				request.WithQueryParameter("AGPT", m3_AGPT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RFID))
				request.WithQueryParameter("RFID", m3_RFID.Trim());
			if (m3_QREM.HasValue)
				request.WithQueryParameter("QREM", m3_QREM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (m3_CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3_CRTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEAF))
				request.WithQueryParameter("TEAF", m3_TEAF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAGN))
				request.WithQueryParameter("VAGN", m3_VAGN.Trim());
			if (m3_DIP2.HasValue)
				request.WithQueryParameter("DIP2", m3_DIP2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SBAN))
				request.WithQueryParameter("SBAN", m3_SBAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACGR))
				request.WithQueryParameter("ACGR", m3_ACGR.Trim());
			if (m3_PGDP.HasValue)
				request.WithQueryParameter("PGDP", m3_PGDP.Value.ToString());

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
		/// Name UpdAgrLine
		/// Description Update agreement line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_GRPI">Group identity (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_UVDT">Valid to</param>
		/// <param name="m3_SAGL">Status agreement line</param>
		/// <param name="m3_SUPR">Setup price</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_PUCD">Purchase price quantity</param>
		/// <param name="m3_UASU">Update material plan</param>
		/// <param name="m3_DIP3">Discount 3</param>
		/// <param name="m3_AGQT">Agreed quantity</param>
		/// <param name="m3_VOLI">Purchase commitment</param>
		/// <param name="m3_PTCD">Purchase price text</param>
		/// <param name="m3_REQU">Renewal quantity</param>
		/// <param name="m3_RENA">Agreement renewal amount</param>
		/// <param name="m3_BOGE">Bonus item</param>
		/// <param name="m3_BOFO">Bonus generating</param>
		/// <param name="m3_PODI">Order total discount base</param>
		/// <param name="m3_LEA1">Supply lead time</param>
		/// <param name="m3_WAL1">Warranty limit 1</param>
		/// <param name="m3_WAL2">Warranty limit 2</param>
		/// <param name="m3_WAL3">Warranty limit 3</param>
		/// <param name="m3_WAL4">Warranty limit 4</param>
		/// <param name="m3_ORCO">Country of origin</param>
		/// <param name="m3_DEFD">Detention free lead time - days</param>
		/// <param name="m3_DEFH">Detention free lead time - hours</param>
		/// <param name="m3_DEFM">Detention free lead time - minutes</param>
		/// <param name="m3_WSCA">Costing model</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAgrLine(
			string m3_SUNO, 
			string m3_AGNB, 
			int m3_GRPI, 
			string m3_OBV1, 
			DateTime m3_FVDT, 
			int? m3_CONO = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
			DateTime? m3_UVDT = null, 
			int? m3_SAGL = null, 
			decimal? m3_SUPR = null, 
			decimal? m3_PUPR = null, 
			int? m3_PUCD = null, 
			int? m3_UASU = null, 
			int? m3_DIP3 = null, 
			decimal? m3_AGQT = null, 
			string m3_VOLI = null, 
			int? m3_PTCD = null, 
			decimal? m3_REQU = null, 
			decimal? m3_RENA = null, 
			int? m3_BOGE = null, 
			int? m3_BOFO = null, 
			int? m3_PODI = null, 
			int? m3_LEA1 = null, 
			decimal? m3_WAL1 = null, 
			decimal? m3_WAL2 = null, 
			decimal? m3_WAL3 = null, 
			decimal? m3_WAL4 = null, 
			string m3_ORCO = null, 
			int? m3_DEFD = null, 
			int? m3_DEFH = null, 
			int? m3_DEFM = null, 
			string m3_WSCA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdAgrLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("GRPI", m3_GRPI.ToString())
				.WithQueryParameter("OBV1", m3_OBV1.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (m3_UVDT.HasValue)
				request.WithQueryParameter("UVDT", m3_UVDT.Value.ToM3String());
			if (m3_SAGL.HasValue)
				request.WithQueryParameter("SAGL", m3_SAGL.Value.ToString());
			if (m3_SUPR.HasValue)
				request.WithQueryParameter("SUPR", m3_SUPR.Value.ToString());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (m3_PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3_PUCD.Value.ToString());
			if (m3_UASU.HasValue)
				request.WithQueryParameter("UASU", m3_UASU.Value.ToString());
			if (m3_DIP3.HasValue)
				request.WithQueryParameter("DIP3", m3_DIP3.Value.ToString());
			if (m3_AGQT.HasValue)
				request.WithQueryParameter("AGQT", m3_AGQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_VOLI))
				request.WithQueryParameter("VOLI", m3_VOLI.Trim());
			if (m3_PTCD.HasValue)
				request.WithQueryParameter("PTCD", m3_PTCD.Value.ToString());
			if (m3_REQU.HasValue)
				request.WithQueryParameter("REQU", m3_REQU.Value.ToString());
			if (m3_RENA.HasValue)
				request.WithQueryParameter("RENA", m3_RENA.Value.ToString());
			if (m3_BOGE.HasValue)
				request.WithQueryParameter("BOGE", m3_BOGE.Value.ToString());
			if (m3_BOFO.HasValue)
				request.WithQueryParameter("BOFO", m3_BOFO.Value.ToString());
			if (m3_PODI.HasValue)
				request.WithQueryParameter("PODI", m3_PODI.Value.ToString());
			if (m3_LEA1.HasValue)
				request.WithQueryParameter("LEA1", m3_LEA1.Value.ToString());
			if (m3_WAL1.HasValue)
				request.WithQueryParameter("WAL1", m3_WAL1.Value.ToString());
			if (m3_WAL2.HasValue)
				request.WithQueryParameter("WAL2", m3_WAL2.Value.ToString());
			if (m3_WAL3.HasValue)
				request.WithQueryParameter("WAL3", m3_WAL3.Value.ToString());
			if (m3_WAL4.HasValue)
				request.WithQueryParameter("WAL4", m3_WAL4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (m3_DEFD.HasValue)
				request.WithQueryParameter("DEFD", m3_DEFD.Value.ToString());
			if (m3_DEFH.HasValue)
				request.WithQueryParameter("DEFH", m3_DEFH.Value.ToString());
			if (m3_DEFM.HasValue)
				request.WithQueryParameter("DEFM", m3_DEFM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WSCA))
				request.WithQueryParameter("WSCA", m3_WSCA.Trim());

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
		/// Name UpdStgPrice
		/// Description Add staggered price
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_GRPI">Group identity (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_FRQT">From quantity (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_DIP3">Discount 3</param>
		/// <param name="m3_MAPR">Normal price</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdStgPrice(
			string m3_SUNO, 
			string m3_AGNB, 
			int m3_GRPI, 
			string m3_OBV1, 
			DateTime m3_FVDT, 
			decimal m3_FRQT, 
			int? m3_CONO = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
			decimal? m3_PUPR = null, 
			int? m3_DIP3 = null, 
			int? m3_MAPR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdStgPrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("GRPI", m3_GRPI.ToString())
				.WithQueryParameter("OBV1", m3_OBV1.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String())
				.WithQueryParameter("FRQT", m3_FRQT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (m3_DIP3.HasValue)
				request.WithQueryParameter("DIP3", m3_DIP3.Value.ToString());
			if (m3_MAPR.HasValue)
				request.WithQueryParameter("MAPR", m3_MAPR.Value.ToString());

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
