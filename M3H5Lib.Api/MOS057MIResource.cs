/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MOS057MI;
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
	/// Name: MOS057MI
	/// Component Name: MAI
	/// Description: Service Error report
	/// Version Release: 5ea4
	///</summary>
	public partial class MOS057MIResource : M3BaseResourceEndpoint
	{
		public MOS057MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS057MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add record
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_SQNR">Sequence number</param>
		/// <param name="m3_MAIN">Main service</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_RIDC">Reference identity code</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_FCLA">Error code 1</param>
		/// <param name="m3_FCL2">Error code 2</param>
		/// <param name="m3_FCL3">Error code 3</param>
		/// <param name="m3_BRDT">Breakdown date</param>
		/// <param name="m3_BRTI">Break down time</param>
		/// <param name="m3_MRDT">Machine ready date</param>
		/// <param name="m3_MRTI">Machine ready time</param>
		/// <param name="m3_EQDT">Equipment in production - date</param>
		/// <param name="m3_EQTI">Equipment in production - time</param>
		/// <param name="m3_ERQT">Error Report Quantity</param>
		/// <param name="m3_NOEM">Non OEM part</param>
		/// <param name="m3_REPR">Reported by</param>
		/// <param name="m3_MVA1">Meter value 1</param>
		/// <param name="m3_MVA2">Meter value 2</param>
		/// <param name="m3_MVA3">Meter value 3</param>
		/// <param name="m3_MVA4">Meter value 4</param>
		/// <param name="m3_FLG1">Durability flag</param>
		/// <param name="m3_FLG2">Inoperable</param>
		/// <param name="m3_CFI1">User-defined field 1 - item</param>
		/// <param name="m3_CFI2">User-defined field 2 - item</param>
		/// <param name="m3_CFI3">User-defined field 3 - item</param>
		/// <param name="m3_CFI4">User-defined field 4 - item</param>
		/// <param name="m3_CFI5">User-defined field 5 - item</param>
		/// <param name="m3_WARR">Warranty</param>
		/// <param name="m3_DWPO">Drawing position</param>
		/// <param name="m3_DOID">Document identity</param>
		/// <param name="m3_TXL1">Text</param>
		/// <param name="m3_TXL2">Text</param>
		/// <param name="m3_TXL3">Text</param>
		/// <param name="m3_TXL4">Text</param>
		/// <param name="m3_TXL5">Text</param>
		/// <param name="m3_TXL6">Text</param>
		/// <param name="m3_TXL7">Text</param>
		/// <param name="m3_TXL8">Text</param>
		/// <param name="m3_TXL9">Text</param>
		/// <param name="m3_TXL0">Text</param>
		/// <param name="m3_MES0">Meter</param>
		/// <param name="m3_MVA0">Since new</param>
		/// <param name="m3_SECP">Serial number</param>
		/// <param name="m3_BKDC">Breakdown cause</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddResponse></returns>
		/// <exception cref="M3Exception<AddResponse>"></exception>
		public async Task<M3Response<AddResponse>> Add(
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			int? m3_SQNR = null, 
			int? m3_MAIN = null, 
			string m3_STAT = null, 
			int? m3_RIDC = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
			string m3_ITNO = null, 
			string m3_FCLA = null, 
			string m3_FCL2 = null, 
			string m3_FCL3 = null, 
			DateTime? m3_BRDT = null, 
			int? m3_BRTI = null, 
			DateTime? m3_MRDT = null, 
			int? m3_MRTI = null, 
			DateTime? m3_EQDT = null, 
			int? m3_EQTI = null, 
			int? m3_ERQT = null, 
			int? m3_NOEM = null, 
			string m3_REPR = null, 
			decimal? m3_MVA1 = null, 
			decimal? m3_MVA2 = null, 
			decimal? m3_MVA3 = null, 
			decimal? m3_MVA4 = null, 
			int? m3_FLG1 = null, 
			int? m3_FLG2 = null, 
			string m3_CFI1 = null, 
			decimal? m3_CFI2 = null, 
			string m3_CFI3 = null, 
			string m3_CFI4 = null, 
			string m3_CFI5 = null, 
			int? m3_WARR = null, 
			string m3_DWPO = null, 
			string m3_DOID = null, 
			string m3_TXL1 = null, 
			string m3_TXL2 = null, 
			string m3_TXL3 = null, 
			string m3_TXL4 = null, 
			string m3_TXL5 = null, 
			string m3_TXL6 = null, 
			string m3_TXL7 = null, 
			string m3_TXL8 = null, 
			string m3_TXL9 = null, 
			string m3_TXL0 = null, 
			string m3_MES0 = null, 
			decimal? m3_MVA0 = null, 
			string m3_SECP = null, 
			string m3_BKDC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Add",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_SQNR.HasValue)
				request.WithQueryParameter("SQNR", m3_SQNR.Value.ToString());
			if (m3_MAIN.HasValue)
				request.WithQueryParameter("MAIN", m3_MAIN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_RIDC.HasValue)
				request.WithQueryParameter("RIDC", m3_RIDC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCLA))
				request.WithQueryParameter("FCLA", m3_FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL2))
				request.WithQueryParameter("FCL2", m3_FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL3))
				request.WithQueryParameter("FCL3", m3_FCL3.Trim());
			if (m3_BRDT.HasValue)
				request.WithQueryParameter("BRDT", m3_BRDT.Value.ToM3String());
			if (m3_BRTI.HasValue)
				request.WithQueryParameter("BRTI", m3_BRTI.Value.ToString());
			if (m3_MRDT.HasValue)
				request.WithQueryParameter("MRDT", m3_MRDT.Value.ToM3String());
			if (m3_MRTI.HasValue)
				request.WithQueryParameter("MRTI", m3_MRTI.Value.ToString());
			if (m3_EQDT.HasValue)
				request.WithQueryParameter("EQDT", m3_EQDT.Value.ToM3String());
			if (m3_EQTI.HasValue)
				request.WithQueryParameter("EQTI", m3_EQTI.Value.ToString());
			if (m3_ERQT.HasValue)
				request.WithQueryParameter("ERQT", m3_ERQT.Value.ToString());
			if (m3_NOEM.HasValue)
				request.WithQueryParameter("NOEM", m3_NOEM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REPR))
				request.WithQueryParameter("REPR", m3_REPR.Trim());
			if (m3_MVA1.HasValue)
				request.WithQueryParameter("MVA1", m3_MVA1.Value.ToString());
			if (m3_MVA2.HasValue)
				request.WithQueryParameter("MVA2", m3_MVA2.Value.ToString());
			if (m3_MVA3.HasValue)
				request.WithQueryParameter("MVA3", m3_MVA3.Value.ToString());
			if (m3_MVA4.HasValue)
				request.WithQueryParameter("MVA4", m3_MVA4.Value.ToString());
			if (m3_FLG1.HasValue)
				request.WithQueryParameter("FLG1", m3_FLG1.Value.ToString());
			if (m3_FLG2.HasValue)
				request.WithQueryParameter("FLG2", m3_FLG2.Value.ToString());
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
			if (m3_WARR.HasValue)
				request.WithQueryParameter("WARR", m3_WARR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DWPO))
				request.WithQueryParameter("DWPO", m3_DWPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL1))
				request.WithQueryParameter("TXL1", m3_TXL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL2))
				request.WithQueryParameter("TXL2", m3_TXL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL3))
				request.WithQueryParameter("TXL3", m3_TXL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL4))
				request.WithQueryParameter("TXL4", m3_TXL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL5))
				request.WithQueryParameter("TXL5", m3_TXL5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL6))
				request.WithQueryParameter("TXL6", m3_TXL6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL7))
				request.WithQueryParameter("TXL7", m3_TXL7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL8))
				request.WithQueryParameter("TXL8", m3_TXL8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL9))
				request.WithQueryParameter("TXL9", m3_TXL9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL0))
				request.WithQueryParameter("TXL0", m3_TXL0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES0))
				request.WithQueryParameter("MES0", m3_MES0.Trim());
			if (m3_MVA0.HasValue)
				request.WithQueryParameter("MVA0", m3_MVA0.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SECP))
				request.WithQueryParameter("SECP", m3_SECP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKDC))
				request.WithQueryParameter("BKDC", m3_BKDC.Trim());

			// Execute the request
			var result = await Execute<AddResponse>(
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
		/// Name AddText
		/// Description Add record
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_MOTT">Work order text type (Required)</param>
		/// <param name="m3_RORC">Reference order category (Required)</param>
		/// <param name="m3_RORN">Reference order number (Required)</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_SQNR">Sequence number</param>
		/// <param name="m3_TX60">Text</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_TXVR">Text block</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddTextResponse></returns>
		/// <exception cref="M3Exception<AddTextResponse>"></exception>
		public async Task<M3Response<AddTextResponse>> AddText(
			string m3_MOTT, 
			int m3_RORC, 
			string m3_RORN, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			int? m3_SQNR = null, 
			string m3_TX60 = null, 
			decimal? m3_TXID = null, 
			string m3_TXVR = null, 
			string m3_LNCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MOTT))
				throw new ArgumentNullException("m3_MOTT");
			if (string.IsNullOrWhiteSpace(m3_RORN))
				throw new ArgumentNullException("m3_RORN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTT", m3_MOTT.Trim())
				.WithQueryParameter("RORC", m3_RORC.ToString())
				.WithQueryParameter("RORN", m3_RORN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_SQNR.HasValue)
				request.WithQueryParameter("SQNR", m3_SQNR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX60))
				request.WithQueryParameter("TX60", m3_TX60.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TXVR))
				request.WithQueryParameter("TXVR", m3_TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<AddTextResponse>(
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
		/// Name DltText
		/// Description Deletes text lines
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_MOTT">Work order text type (Required)</param>
		/// <param name="m3_RORC">Reference order category (Required)</param>
		/// <param name="m3_RORN">Reference order number (Required)</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_SQNR">Sequence number</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_TXVR">Text block</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltText(
			string m3_MOTT, 
			int m3_RORC, 
			string m3_RORN, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			int? m3_SQNR = null, 
			decimal? m3_TXID = null, 
			string m3_TXVR = null, 
			string m3_LNCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MOTT))
				throw new ArgumentNullException("m3_MOTT");
			if (string.IsNullOrWhiteSpace(m3_RORN))
				throw new ArgumentNullException("m3_RORN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTT", m3_MOTT.Trim())
				.WithQueryParameter("RORC", m3_RORC.ToString())
				.WithQueryParameter("RORN", m3_RORN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_SQNR.HasValue)
				request.WithQueryParameter("SQNR", m3_SQNR.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TXVR))
				request.WithQueryParameter("TXVR", m3_TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

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
		/// Name Get
		/// Description Get Service Error Report
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_SQNR">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			int? m3_SQNR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Get",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_SQNR.HasValue)
				request.WithQueryParameter("SQNR", m3_SQNR.Value.ToString());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name GetMain
		/// Description Get Service Error Report
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMainResponse></returns>
		/// <exception cref="M3Exception<GetMainResponse>"></exception>
		public async Task<M3Response<GetMainResponse>> GetMain(
			int? m3_RORC = null, 
			string m3_RORN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMain",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());

			// Execute the request
			var result = await Execute<GetMainResponse>(
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
		/// Name GetMainRidx
		/// Description Get Service Error Report RIDx
		/// Version Release: 
		/// </summary>
		/// <param name="m3_RIDC">Reference identity code</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMainRidxResponse></returns>
		/// <exception cref="M3Exception<GetMainRidxResponse>"></exception>
		public async Task<M3Response<GetMainRidxResponse>> GetMainRidx(
			int? m3_RIDC = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMainRidx",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RIDC.HasValue)
				request.WithQueryParameter("RIDC", m3_RIDC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());

			// Execute the request
			var result = await Execute<GetMainRidxResponse>(
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
		/// Name GetText
		/// Description Get Text
		/// Version Release: 
		/// </summary>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_SQNR">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTextResponse></returns>
		/// <exception cref="M3Exception<GetTextResponse>"></exception>
		public async Task<M3Response<GetTextResponse>> GetText(
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			int? m3_SQNR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetText",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_SQNR.HasValue)
				request.WithQueryParameter("SQNR", m3_SQNR.Value.ToString());

			// Execute the request
			var result = await Execute<GetTextResponse>(
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
		/// Name Lst
		/// Description List Service Error Report
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Lst",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());

			// Execute the request
			var result = await Execute<LstResponse>(
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
		/// Name LstByRef
		/// Description List by Reference
		/// Version Release: 
		/// </summary>
		/// <param name="m3_RIDC">Reference identity code</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByRefResponse></returns>
		/// <exception cref="M3Exception<LstByRefResponse>"></exception>
		public async Task<M3Response<LstByRefResponse>> LstByRef(
			int? m3_RIDC = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByRef",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RIDC.HasValue)
				request.WithQueryParameter("RIDC", m3_RIDC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());

			// Execute the request
			var result = await Execute<LstByRefResponse>(
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
		/// Name PrintSend
		/// Description Print and Send report
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_SQNR">Sequence number</param>
		/// <param name="m3_CNPE">Contact person</param>
		/// <param name="m3_EMAL">Electronic mail address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrintSend(
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			int? m3_SQNR = null, 
			string m3_CNPE = null, 
			string m3_EMAL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrintSend",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_SQNR.HasValue)
				request.WithQueryParameter("SQNR", m3_SQNR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CNPE))
				request.WithQueryParameter("CNPE", m3_CNPE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMAL))
				request.WithQueryParameter("EMAL", m3_EMAL.Trim());

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
		/// Name Upd
		/// Description Update record
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_SQNR">Sequence number</param>
		/// <param name="m3_MAIN">Main service</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_RIDC">Reference identity code</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_FCLA">Error code 1</param>
		/// <param name="m3_FCL2">Error code 2</param>
		/// <param name="m3_FCL3">Error code 3</param>
		/// <param name="m3_BRDT">Breakdown date</param>
		/// <param name="m3_BRTI">Break down time</param>
		/// <param name="m3_MRDT">Machine ready date</param>
		/// <param name="m3_MRTI">Machine ready time</param>
		/// <param name="m3_EQDT">Equipment in production - date</param>
		/// <param name="m3_EQTI">Equipment in production - time</param>
		/// <param name="m3_ERQT">Error Report Quantity</param>
		/// <param name="m3_NOEM">Non OEM part</param>
		/// <param name="m3_REPR">Reported by</param>
		/// <param name="m3_MVA1">Meter value 1</param>
		/// <param name="m3_MVA2">Meter value 2</param>
		/// <param name="m3_MVA3">Meter value 3</param>
		/// <param name="m3_MVA4">Meter value 4</param>
		/// <param name="m3_FLG1">Durability flag</param>
		/// <param name="m3_FLG2">Inoperable</param>
		/// <param name="m3_CFI1">User-defined field 1 - item</param>
		/// <param name="m3_CFI2">User-defined field 2 - item</param>
		/// <param name="m3_CFI3">User-defined field 3 - item</param>
		/// <param name="m3_CFI4">User-defined field 4 - item</param>
		/// <param name="m3_CFI5">User-defined field 5 - item</param>
		/// <param name="m3_WARR">Warranty</param>
		/// <param name="m3_DWPO">Drawing position</param>
		/// <param name="m3_DOID">Document identity</param>
		/// <param name="m3_TXL1">Text</param>
		/// <param name="m3_TXL2">Text</param>
		/// <param name="m3_TXL3">Text</param>
		/// <param name="m3_TXL4">Text</param>
		/// <param name="m3_TXL5">Text</param>
		/// <param name="m3_TXL6">Text</param>
		/// <param name="m3_TXL7">Text</param>
		/// <param name="m3_TXL8">Text</param>
		/// <param name="m3_TXL9">Text</param>
		/// <param name="m3_TXL0">Text</param>
		/// <param name="m3_MES0">Meter</param>
		/// <param name="m3_MVA0">Since new</param>
		/// <param name="m3_SECP">Serial number</param>
		/// <param name="m3_BKDC">Breakdown cause</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			int? m3_SQNR = null, 
			int? m3_MAIN = null, 
			string m3_STAT = null, 
			int? m3_RIDC = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
			string m3_ITNO = null, 
			string m3_FCLA = null, 
			string m3_FCL2 = null, 
			string m3_FCL3 = null, 
			DateTime? m3_BRDT = null, 
			int? m3_BRTI = null, 
			DateTime? m3_MRDT = null, 
			int? m3_MRTI = null, 
			DateTime? m3_EQDT = null, 
			int? m3_EQTI = null, 
			int? m3_ERQT = null, 
			int? m3_NOEM = null, 
			string m3_REPR = null, 
			decimal? m3_MVA1 = null, 
			decimal? m3_MVA2 = null, 
			decimal? m3_MVA3 = null, 
			decimal? m3_MVA4 = null, 
			int? m3_FLG1 = null, 
			int? m3_FLG2 = null, 
			string m3_CFI1 = null, 
			decimal? m3_CFI2 = null, 
			string m3_CFI3 = null, 
			string m3_CFI4 = null, 
			string m3_CFI5 = null, 
			int? m3_WARR = null, 
			string m3_DWPO = null, 
			string m3_DOID = null, 
			string m3_TXL1 = null, 
			string m3_TXL2 = null, 
			string m3_TXL3 = null, 
			string m3_TXL4 = null, 
			string m3_TXL5 = null, 
			string m3_TXL6 = null, 
			string m3_TXL7 = null, 
			string m3_TXL8 = null, 
			string m3_TXL9 = null, 
			string m3_TXL0 = null, 
			string m3_MES0 = null, 
			decimal? m3_MVA0 = null, 
			string m3_SECP = null, 
			string m3_BKDC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Upd",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_SQNR.HasValue)
				request.WithQueryParameter("SQNR", m3_SQNR.Value.ToString());
			if (m3_MAIN.HasValue)
				request.WithQueryParameter("MAIN", m3_MAIN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_RIDC.HasValue)
				request.WithQueryParameter("RIDC", m3_RIDC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCLA))
				request.WithQueryParameter("FCLA", m3_FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL2))
				request.WithQueryParameter("FCL2", m3_FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL3))
				request.WithQueryParameter("FCL3", m3_FCL3.Trim());
			if (m3_BRDT.HasValue)
				request.WithQueryParameter("BRDT", m3_BRDT.Value.ToM3String());
			if (m3_BRTI.HasValue)
				request.WithQueryParameter("BRTI", m3_BRTI.Value.ToString());
			if (m3_MRDT.HasValue)
				request.WithQueryParameter("MRDT", m3_MRDT.Value.ToM3String());
			if (m3_MRTI.HasValue)
				request.WithQueryParameter("MRTI", m3_MRTI.Value.ToString());
			if (m3_EQDT.HasValue)
				request.WithQueryParameter("EQDT", m3_EQDT.Value.ToM3String());
			if (m3_EQTI.HasValue)
				request.WithQueryParameter("EQTI", m3_EQTI.Value.ToString());
			if (m3_ERQT.HasValue)
				request.WithQueryParameter("ERQT", m3_ERQT.Value.ToString());
			if (m3_NOEM.HasValue)
				request.WithQueryParameter("NOEM", m3_NOEM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REPR))
				request.WithQueryParameter("REPR", m3_REPR.Trim());
			if (m3_MVA1.HasValue)
				request.WithQueryParameter("MVA1", m3_MVA1.Value.ToString());
			if (m3_MVA2.HasValue)
				request.WithQueryParameter("MVA2", m3_MVA2.Value.ToString());
			if (m3_MVA3.HasValue)
				request.WithQueryParameter("MVA3", m3_MVA3.Value.ToString());
			if (m3_MVA4.HasValue)
				request.WithQueryParameter("MVA4", m3_MVA4.Value.ToString());
			if (m3_FLG1.HasValue)
				request.WithQueryParameter("FLG1", m3_FLG1.Value.ToString());
			if (m3_FLG2.HasValue)
				request.WithQueryParameter("FLG2", m3_FLG2.Value.ToString());
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
			if (m3_WARR.HasValue)
				request.WithQueryParameter("WARR", m3_WARR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DWPO))
				request.WithQueryParameter("DWPO", m3_DWPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL1))
				request.WithQueryParameter("TXL1", m3_TXL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL2))
				request.WithQueryParameter("TXL2", m3_TXL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL3))
				request.WithQueryParameter("TXL3", m3_TXL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL4))
				request.WithQueryParameter("TXL4", m3_TXL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL5))
				request.WithQueryParameter("TXL5", m3_TXL5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL6))
				request.WithQueryParameter("TXL6", m3_TXL6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL7))
				request.WithQueryParameter("TXL7", m3_TXL7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL8))
				request.WithQueryParameter("TXL8", m3_TXL8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL9))
				request.WithQueryParameter("TXL9", m3_TXL9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL0))
				request.WithQueryParameter("TXL0", m3_TXL0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES0))
				request.WithQueryParameter("MES0", m3_MES0.Trim());
			if (m3_MVA0.HasValue)
				request.WithQueryParameter("MVA0", m3_MVA0.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SECP))
				request.WithQueryParameter("SECP", m3_SECP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKDC))
				request.WithQueryParameter("BKDC", m3_BKDC.Trim());

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
		/// Name UpdOEM
		/// Description Update OEM codes
		/// Version Release: 
		/// </summary>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_SQNR">Sequence number</param>
		/// <param name="m3_SMC0">OEM code</param>
		/// <param name="m3_SMC1">OEM code</param>
		/// <param name="m3_SMC2">OEM code</param>
		/// <param name="m3_SMC3">OEM code</param>
		/// <param name="m3_SMC4">OEM code</param>
		/// <param name="m3_SMC5">OEM code</param>
		/// <param name="m3_SMC6">OEM code</param>
		/// <param name="m3_SMC7">OEM code</param>
		/// <param name="m3_SMC8">OEM code</param>
		/// <param name="m3_SMC9">OEM code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdOEM(
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			int? m3_SQNR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdOEM",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_SQNR.HasValue)
				request.WithQueryParameter("SQNR", m3_SQNR.Value.ToString());
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
