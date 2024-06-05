/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAgrHead
		/// Description Create new agreement head
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3AGTP">Agreement type (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3UVDT">Valid to</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3TX30">Text</param>
		/// <param name="m3AGRD">Agreement date</param>
		/// <param name="m3RNDT">Renewal date</param>
		/// <param name="m3PAST">Status - supplier agreement</param>
		/// <param name="m3TENT">Period of notice</param>
		/// <param name="m3BUYE">Buyer</param>
		/// <param name="m3AGPT">Agreement priority</param>
		/// <param name="m3RFID">Reference</param>
		/// <param name="m3QREM">Update purchased quantity</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3TEPA">Packaging terms</param>
		/// <param name="m3CRTP">Exchange rate type</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3TEDL">Delivery terms</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3TEAF">Freight terms</param>
		/// <param name="m3CIVC">Check item/supplier combination</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3VAGN">Supplier agreement number</param>
		/// <param name="m3DIP2">Discount 2</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3SBAN">Self-billing agreement number</param>
		/// <param name="m3ACGR">Object access group</param>
		/// <param name="m3PGDP">Number of print generations</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddAgrHeadResponse></returns>
		/// <exception cref="M3Exception<AddAgrHeadResponse>"></exception>
		public async Task<M3Response<AddAgrHeadResponse>> AddAgrHead(
			string m3SUNO, 
			string m3AGTP, 
			DateTime m3FVDT, 
			int? m3CONO = null, 
			DateTime? m3UVDT = null, 
			string m3AGNB = null, 
			string m3TX30 = null, 
			DateTime? m3AGRD = null, 
			DateTime? m3RNDT = null, 
			string m3PAST = null, 
			int? m3TENT = null, 
			string m3BUYE = null, 
			int? m3AGPT = null, 
			string m3RFID = null, 
			int? m3QREM = null, 
			string m3CUCD = null, 
			string m3TEPA = null, 
			int? m3CRTP = null, 
			string m3MODL = null, 
			string m3TEDL = null, 
			string m3TEPY = null, 
			string m3TEAF = null, 
			int? m3CIVC = null, 
			string m3WHLO = null, 
			string m3VAGN = null, 
			int? m3DIP2 = null, 
			string m3FACI = null, 
			string m3SBAN = null, 
			string m3ACGR = null, 
			int? m3PGDP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddAgrHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3AGTP))
				throw new ArgumentNullException(nameof(m3AGTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("AGTP", m3AGTP.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UVDT.HasValue)
				request.WithQueryParameter("UVDT", m3UVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX30))
				request.WithQueryParameter("TX30", m3TX30.Trim());
			if (m3AGRD.HasValue)
				request.WithQueryParameter("AGRD", m3AGRD.Value.ToM3String());
			if (m3RNDT.HasValue)
				request.WithQueryParameter("RNDT", m3RNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PAST))
				request.WithQueryParameter("PAST", m3PAST.Trim());
			if (m3TENT.HasValue)
				request.WithQueryParameter("TENT", m3TENT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BUYE))
				request.WithQueryParameter("BUYE", m3BUYE.Trim());
			if (m3AGPT.HasValue)
				request.WithQueryParameter("AGPT", m3AGPT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RFID))
				request.WithQueryParameter("RFID", m3RFID.Trim());
			if (m3QREM.HasValue)
				request.WithQueryParameter("QREM", m3QREM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (m3CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3CRTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEAF))
				request.WithQueryParameter("TEAF", m3TEAF.Trim());
			if (m3CIVC.HasValue)
				request.WithQueryParameter("CIVC", m3CIVC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAGN))
				request.WithQueryParameter("VAGN", m3VAGN.Trim());
			if (m3DIP2.HasValue)
				request.WithQueryParameter("DIP2", m3DIP2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SBAN))
				request.WithQueryParameter("SBAN", m3SBAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACGR))
				request.WithQueryParameter("ACGR", m3ACGR.Trim());
			if (m3PGDP.HasValue)
				request.WithQueryParameter("PGDP", m3PGDP.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddAgrHeadResponse>(
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
		/// Name AddAgrLine
		/// Description Create new agreement line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3GRPI">Group identity (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3PUPR">Purchase price (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3UVDT">Valid to</param>
		/// <param name="m3SAGL">Status agreement line</param>
		/// <param name="m3SUPR">Setup price</param>
		/// <param name="m3PUCD">Purchase price quantity</param>
		/// <param name="m3UASU">Update material plan</param>
		/// <param name="m3DIP3">Discount 3</param>
		/// <param name="m3AGQT">Agreed quantity</param>
		/// <param name="m3VOLI">Purchase commitment</param>
		/// <param name="m3PTCD">Purchase price text</param>
		/// <param name="m3REQU">Renewal quantity</param>
		/// <param name="m3RENA">Agreement renewal amount</param>
		/// <param name="m3BOGE">Bonus item</param>
		/// <param name="m3BOFO">Bonus generating</param>
		/// <param name="m3PODI">Order total discount base</param>
		/// <param name="m3LEA1">Supply lead time</param>
		/// <param name="m3WAL1">Warranty limit 1</param>
		/// <param name="m3WAL2">Warranty limit 2</param>
		/// <param name="m3WAL3">Warranty limit 3</param>
		/// <param name="m3WAL4">Warranty limit 4</param>
		/// <param name="m3ORCO">Country of origin</param>
		/// <param name="m3SCPM">Service type</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3DEFD">Detention free lead time - days</param>
		/// <param name="m3DEFH">Detention free lead time - hours</param>
		/// <param name="m3DEFM">Detention free lead time - minutes</param>
		/// <param name="m3WSCA">Costing model</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAgrLine(
			string m3SUNO, 
			string m3AGNB, 
			int m3GRPI, 
			string m3OBV1, 
			DateTime m3FVDT, 
			decimal m3PUPR, 
			int? m3CONO = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
			DateTime? m3UVDT = null, 
			int? m3SAGL = null, 
			decimal? m3SUPR = null, 
			int? m3PUCD = null, 
			int? m3UASU = null, 
			int? m3DIP3 = null, 
			decimal? m3AGQT = null, 
			string m3VOLI = null, 
			int? m3PTCD = null, 
			decimal? m3REQU = null, 
			decimal? m3RENA = null, 
			int? m3BOGE = null, 
			int? m3BOFO = null, 
			int? m3PODI = null, 
			int? m3LEA1 = null, 
			decimal? m3WAL1 = null, 
			decimal? m3WAL2 = null, 
			decimal? m3WAL3 = null, 
			decimal? m3WAL4 = null, 
			string m3ORCO = null, 
			int? m3SCPM = null, 
			string m3FACI = null, 
			int? m3DEFD = null, 
			int? m3DEFH = null, 
			int? m3DEFM = null, 
			string m3WSCA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddAgrLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("GRPI", m3GRPI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OBV1", m3OBV1.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String())
				.WithQueryParameter("PUPR", m3PUPR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (m3UVDT.HasValue)
				request.WithQueryParameter("UVDT", m3UVDT.Value.ToM3String());
			if (m3SAGL.HasValue)
				request.WithQueryParameter("SAGL", m3SAGL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUPR.HasValue)
				request.WithQueryParameter("SUPR", m3SUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3PUCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UASU.HasValue)
				request.WithQueryParameter("UASU", m3UASU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIP3.HasValue)
				request.WithQueryParameter("DIP3", m3DIP3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGQT.HasValue)
				request.WithQueryParameter("AGQT", m3AGQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3VOLI))
				request.WithQueryParameter("VOLI", m3VOLI.Trim());
			if (m3PTCD.HasValue)
				request.WithQueryParameter("PTCD", m3PTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REQU.HasValue)
				request.WithQueryParameter("REQU", m3REQU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RENA.HasValue)
				request.WithQueryParameter("RENA", m3RENA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BOGE.HasValue)
				request.WithQueryParameter("BOGE", m3BOGE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BOFO.HasValue)
				request.WithQueryParameter("BOFO", m3BOFO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PODI.HasValue)
				request.WithQueryParameter("PODI", m3PODI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEA1.HasValue)
				request.WithQueryParameter("LEA1", m3LEA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAL1.HasValue)
				request.WithQueryParameter("WAL1", m3WAL1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAL2.HasValue)
				request.WithQueryParameter("WAL2", m3WAL2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAL3.HasValue)
				request.WithQueryParameter("WAL3", m3WAL3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAL4.HasValue)
				request.WithQueryParameter("WAL4", m3WAL4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORCO))
				request.WithQueryParameter("ORCO", m3ORCO.Trim());
			if (m3SCPM.HasValue)
				request.WithQueryParameter("SCPM", m3SCPM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (m3DEFD.HasValue)
				request.WithQueryParameter("DEFD", m3DEFD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DEFH.HasValue)
				request.WithQueryParameter("DEFH", m3DEFH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DEFM.HasValue)
				request.WithQueryParameter("DEFM", m3DEFM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WSCA))
				request.WithQueryParameter("WSCA", m3WSCA.Trim());

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
		/// Name AddStgPrice
		/// Description Add staggered price
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3GRPI">Group identity (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3FRQT">From quantity (Required)</param>
		/// <param name="m3PUPR">Purchase price (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3DIP3">Discount 3</param>
		/// <param name="m3MAPR">Normal price</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddStgPrice(
			string m3SUNO, 
			string m3AGNB, 
			int m3GRPI, 
			string m3OBV1, 
			DateTime m3FVDT, 
			decimal m3FRQT, 
			decimal m3PUPR, 
			int? m3CONO = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
			int? m3DIP3 = null, 
			int? m3MAPR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddStgPrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("GRPI", m3GRPI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OBV1", m3OBV1.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String())
				.WithQueryParameter("FRQT", m3FRQT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PUPR", m3PUPR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (m3DIP3.HasValue)
				request.WithQueryParameter("DIP3", m3DIP3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MAPR.HasValue)
				request.WithQueryParameter("MAPR", m3MAPR.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetAgrHead
		/// Description Get agreement head information
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgrHeadResponse></returns>
		/// <exception cref="M3Exception<GetAgrHeadResponse>"></exception>
		public async Task<M3Response<GetAgrHeadResponse>> GetAgrHead(
			string m3SUNO, 
			string m3AGNB, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetAgrHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("AGNB", m3AGNB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetAgrHeadResponse>(
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
		/// Name GetAgrLine
		/// Description Get agreement line information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3GRPI">Group identity (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgrLineResponse></returns>
		/// <exception cref="M3Exception<GetAgrLineResponse>"></exception>
		public async Task<M3Response<GetAgrLineResponse>> GetAgrLine(
			string m3SUNO, 
			string m3AGNB, 
			int m3GRPI, 
			string m3OBV1, 
			DateTime m3FVDT, 
			int? m3CONO = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetAgrLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("GRPI", m3GRPI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OBV1", m3OBV1.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());

			// Execute the request
			var result = await Execute<GetAgrLineResponse>(
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
		/// Name LstAgrHead
		/// Description List agreement heads
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrHeadResponse></returns>
		/// <exception cref="M3Exception<LstAgrHeadResponse>"></exception>
		public async Task<M3Response<LstAgrHeadResponse>> LstAgrHead(
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAgrHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAgrHeadResponse>(
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
		/// Name LstAgrHeadBySup
		/// Description List agreement head by supplier
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3VAGN">Supplier agreement number</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrHeadBySupResponse></returns>
		/// <exception cref="M3Exception<LstAgrHeadBySupResponse>"></exception>
		public async Task<M3Response<LstAgrHeadBySupResponse>> LstAgrHeadBySup(
			string m3SUNO = null, 
			string m3VAGN = null, 
			DateTime? m3FVDT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAgrHeadBySup",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAGN))
				request.WithQueryParameter("VAGN", m3VAGN.Trim());
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstAgrHeadBySupResponse>(
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
		/// Name LstAgrLine
		/// Description List agreement lines
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrLineResponse></returns>
		/// <exception cref="M3Exception<LstAgrLineResponse>"></exception>
		public async Task<M3Response<LstAgrLineResponse>> LstAgrLine(
			string m3SUNO, 
			string m3AGNB, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAgrLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("AGNB", m3AGNB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAgrLineResponse>(
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
		/// Name LstStgPrice
		/// Description List staggered prices
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3GRPI">Group identity (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstStgPriceResponse></returns>
		/// <exception cref="M3Exception<LstStgPriceResponse>"></exception>
		public async Task<M3Response<LstStgPriceResponse>> LstStgPrice(
			string m3SUNO, 
			string m3AGNB, 
			int m3GRPI, 
			string m3OBV1, 
			DateTime m3FVDT, 
			int? m3CONO = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstStgPrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("GRPI", m3GRPI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OBV1", m3OBV1.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());

			// Execute the request
			var result = await Execute<LstStgPriceResponse>(
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
		/// Name UpdAgrHead
		/// Description Update Agreement Head
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3UVDT">Valid to</param>
		/// <param name="m3TX30">Text</param>
		/// <param name="m3AGRD">Agreement date</param>
		/// <param name="m3PAST">Status - supplier agreement</param>
		/// <param name="m3BUYE">Buyer</param>
		/// <param name="m3AGPT">Agreement priority</param>
		/// <param name="m3RFID">Reference</param>
		/// <param name="m3QREM">Update purchased quantity</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3TEPA">Packaging terms</param>
		/// <param name="m3CRTP">Exchange rate type</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3TEDL">Delivery terms</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3TEAF">Freight terms</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3VAGN">Supplier agreement number</param>
		/// <param name="m3DIP2">Discount 2</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3SBAN">Self-billing agreement number</param>
		/// <param name="m3ACGR">Object access group</param>
		/// <param name="m3PGDP">Number of print generations</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAgrHead(
			string m3SUNO, 
			string m3AGNB, 
			int? m3CONO = null, 
			DateTime? m3FVDT = null, 
			DateTime? m3UVDT = null, 
			string m3TX30 = null, 
			DateTime? m3AGRD = null, 
			string m3PAST = null, 
			string m3BUYE = null, 
			int? m3AGPT = null, 
			string m3RFID = null, 
			int? m3QREM = null, 
			string m3CUCD = null, 
			string m3TEPA = null, 
			int? m3CRTP = null, 
			string m3MODL = null, 
			string m3TEDL = null, 
			string m3TEPY = null, 
			string m3TEAF = null, 
			string m3WHLO = null, 
			string m3VAGN = null, 
			int? m3DIP2 = null, 
			string m3FACI = null, 
			string m3SBAN = null, 
			string m3ACGR = null, 
			int? m3PGDP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdAgrHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("AGNB", m3AGNB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3UVDT.HasValue)
				request.WithQueryParameter("UVDT", m3UVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TX30))
				request.WithQueryParameter("TX30", m3TX30.Trim());
			if (m3AGRD.HasValue)
				request.WithQueryParameter("AGRD", m3AGRD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PAST))
				request.WithQueryParameter("PAST", m3PAST.Trim());
			if (!string.IsNullOrWhiteSpace(m3BUYE))
				request.WithQueryParameter("BUYE", m3BUYE.Trim());
			if (m3AGPT.HasValue)
				request.WithQueryParameter("AGPT", m3AGPT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RFID))
				request.WithQueryParameter("RFID", m3RFID.Trim());
			if (m3QREM.HasValue)
				request.WithQueryParameter("QREM", m3QREM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (m3CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3CRTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEAF))
				request.WithQueryParameter("TEAF", m3TEAF.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAGN))
				request.WithQueryParameter("VAGN", m3VAGN.Trim());
			if (m3DIP2.HasValue)
				request.WithQueryParameter("DIP2", m3DIP2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SBAN))
				request.WithQueryParameter("SBAN", m3SBAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACGR))
				request.WithQueryParameter("ACGR", m3ACGR.Trim());
			if (m3PGDP.HasValue)
				request.WithQueryParameter("PGDP", m3PGDP.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdAgrLine
		/// Description Update agreement line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3GRPI">Group identity (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3UVDT">Valid to</param>
		/// <param name="m3SAGL">Status agreement line</param>
		/// <param name="m3SUPR">Setup price</param>
		/// <param name="m3PUPR">Purchase price</param>
		/// <param name="m3PUCD">Purchase price quantity</param>
		/// <param name="m3UASU">Update material plan</param>
		/// <param name="m3DIP3">Discount 3</param>
		/// <param name="m3AGQT">Agreed quantity</param>
		/// <param name="m3VOLI">Purchase commitment</param>
		/// <param name="m3PTCD">Purchase price text</param>
		/// <param name="m3REQU">Renewal quantity</param>
		/// <param name="m3RENA">Agreement renewal amount</param>
		/// <param name="m3BOGE">Bonus item</param>
		/// <param name="m3BOFO">Bonus generating</param>
		/// <param name="m3PODI">Order total discount base</param>
		/// <param name="m3LEA1">Supply lead time</param>
		/// <param name="m3WAL1">Warranty limit 1</param>
		/// <param name="m3WAL2">Warranty limit 2</param>
		/// <param name="m3WAL3">Warranty limit 3</param>
		/// <param name="m3WAL4">Warranty limit 4</param>
		/// <param name="m3ORCO">Country of origin</param>
		/// <param name="m3DEFD">Detention free lead time - days</param>
		/// <param name="m3DEFH">Detention free lead time - hours</param>
		/// <param name="m3DEFM">Detention free lead time - minutes</param>
		/// <param name="m3WSCA">Costing model</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAgrLine(
			string m3SUNO, 
			string m3AGNB, 
			int m3GRPI, 
			string m3OBV1, 
			DateTime m3FVDT, 
			int? m3CONO = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
			DateTime? m3UVDT = null, 
			int? m3SAGL = null, 
			decimal? m3SUPR = null, 
			decimal? m3PUPR = null, 
			int? m3PUCD = null, 
			int? m3UASU = null, 
			int? m3DIP3 = null, 
			decimal? m3AGQT = null, 
			string m3VOLI = null, 
			int? m3PTCD = null, 
			decimal? m3REQU = null, 
			decimal? m3RENA = null, 
			int? m3BOGE = null, 
			int? m3BOFO = null, 
			int? m3PODI = null, 
			int? m3LEA1 = null, 
			decimal? m3WAL1 = null, 
			decimal? m3WAL2 = null, 
			decimal? m3WAL3 = null, 
			decimal? m3WAL4 = null, 
			string m3ORCO = null, 
			int? m3DEFD = null, 
			int? m3DEFH = null, 
			int? m3DEFM = null, 
			string m3WSCA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdAgrLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("GRPI", m3GRPI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OBV1", m3OBV1.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (m3UVDT.HasValue)
				request.WithQueryParameter("UVDT", m3UVDT.Value.ToM3String());
			if (m3SAGL.HasValue)
				request.WithQueryParameter("SAGL", m3SAGL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUPR.HasValue)
				request.WithQueryParameter("SUPR", m3SUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3PUCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UASU.HasValue)
				request.WithQueryParameter("UASU", m3UASU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIP3.HasValue)
				request.WithQueryParameter("DIP3", m3DIP3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGQT.HasValue)
				request.WithQueryParameter("AGQT", m3AGQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3VOLI))
				request.WithQueryParameter("VOLI", m3VOLI.Trim());
			if (m3PTCD.HasValue)
				request.WithQueryParameter("PTCD", m3PTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REQU.HasValue)
				request.WithQueryParameter("REQU", m3REQU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RENA.HasValue)
				request.WithQueryParameter("RENA", m3RENA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BOGE.HasValue)
				request.WithQueryParameter("BOGE", m3BOGE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BOFO.HasValue)
				request.WithQueryParameter("BOFO", m3BOFO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PODI.HasValue)
				request.WithQueryParameter("PODI", m3PODI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEA1.HasValue)
				request.WithQueryParameter("LEA1", m3LEA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAL1.HasValue)
				request.WithQueryParameter("WAL1", m3WAL1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAL2.HasValue)
				request.WithQueryParameter("WAL2", m3WAL2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAL3.HasValue)
				request.WithQueryParameter("WAL3", m3WAL3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAL4.HasValue)
				request.WithQueryParameter("WAL4", m3WAL4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORCO))
				request.WithQueryParameter("ORCO", m3ORCO.Trim());
			if (m3DEFD.HasValue)
				request.WithQueryParameter("DEFD", m3DEFD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DEFH.HasValue)
				request.WithQueryParameter("DEFH", m3DEFH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DEFM.HasValue)
				request.WithQueryParameter("DEFM", m3DEFM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WSCA))
				request.WithQueryParameter("WSCA", m3WSCA.Trim());

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
		/// Name UpdStgPrice
		/// Description Add staggered price
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3GRPI">Group identity (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3FRQT">From quantity (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3PUPR">Purchase price</param>
		/// <param name="m3DIP3">Discount 3</param>
		/// <param name="m3MAPR">Normal price</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdStgPrice(
			string m3SUNO, 
			string m3AGNB, 
			int m3GRPI, 
			string m3OBV1, 
			DateTime m3FVDT, 
			decimal m3FRQT, 
			int? m3CONO = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
			decimal? m3PUPR = null, 
			int? m3DIP3 = null, 
			int? m3MAPR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdStgPrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("GRPI", m3GRPI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OBV1", m3OBV1.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String())
				.WithQueryParameter("FRQT", m3FRQT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIP3.HasValue)
				request.WithQueryParameter("DIP3", m3DIP3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MAPR.HasValue)
				request.WithQueryParameter("MAPR", m3MAPR.Value.ToString(CultureInfo.CurrentCulture));

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
