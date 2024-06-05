/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MHS850MI;
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
	/// Name: MHS850MI
	/// Component Name: OrderInitiatedStockTrans
	/// Description: Order initiated stock transaction interface
	/// Version Release: 5ea4
	///</summary>
	public partial class MHS850MIResource : M3BaseResourceEndpoint
	{
		public MHS850MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MHS850MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddCOPick
		/// Description Add Customer Order Pick
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line (Required)</param>
		/// <param name="m3_PLSX">Picking list suffix (Required)</param>
		/// <param name="m3_PRFL">Process Flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_QTYP">Quantity Picked</param>
		/// <param name="m3_QTYO">Quantity to be picked</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_RIDI">Order index</param>
		/// <param name="m3_DLIX">Delivery index</param>
		/// <param name="m3_USD1">User Defined 1</param>
		/// <param name="m3_USD2">User defined 2</param>
		/// <param name="m3_USD3">User defined 3</param>
		/// <param name="m3_USD4">User defined 4</param>
		/// <param name="m3_USD5">User defined 5</param>
		/// <param name="m3_PLRN">Reporting number - pick line</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="m3_OEND">Flagged as completed</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_AMKO">Number of packages</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_PARE">Packaging reference</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="m3_ISMD">Issue/move mode</param>
		/// <param name="m3_BREF">Lot Reference 1</param>
		/// <param name="m3_BRE2">Lot Reference 2</param>
		/// <param name="m3_GRWE">Gross Weight</param>
		/// <param name="m3_VOM3">Volume</param>
		/// <param name="m3_FRCP">Free Capacity unit</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_LODO">Loading platform</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddCOPickResponse></returns>
		/// <exception cref="M3Exception<AddCOPickResponse>"></exception>
		public async Task<M3Response<AddCOPickResponse>> AddCOPick(
			string m3_WHLO, 
			string m3_E0PA, 
			string m3_E065, 
			string m3_CUNO, 
			string m3_RIDN, 
			int m3_RIDL, 
			int m3_PLSX, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSGN = null, 
			string m3_PACN = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_ADID = null, 
			string m3_ITNO = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			decimal? m3_QTYP = null, 
			decimal? m3_QTYO = null, 
			int? m3_RIDX = null, 
			decimal? m3_RIDI = null, 
			decimal? m3_DLIX = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_PLRN = null, 
			string m3_TWSL = null, 
			int? m3_OEND = null, 
			DateTime? m3_RPDT = null, 
			decimal? m3_CAWE = null, 
			string m3_PACT = null, 
			int? m3_AMKO = null, 
			string m3_PMSN = null, 
			string m3_PARE = null, 
			string m3_SSCC = null, 
			int? m3_ISMD = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			decimal? m3_GRWE = null, 
			decimal? m3_VOM3 = null, 
			decimal? m3_FRCP = null, 
			int? m3_RPTM = null, 
			string m3_LODO = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCOPick",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("RIDL", m3_RIDL.ToString())
				.WithQueryParameter("PLSX", m3_PLSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_QTYP.HasValue)
				request.WithQueryParameter("QTYP", m3_QTYP.Value.ToString());
			if (m3_QTYO.HasValue)
				request.WithQueryParameter("QTYO", m3_QTYO.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (m3_RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3_RIDI.Value.ToString());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_PLRN.HasValue)
				request.WithQueryParameter("PLRN", m3_PLRN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (m3_AMKO.HasValue)
				request.WithQueryParameter("AMKO", m3_AMKO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PARE))
				request.WithQueryParameter("PARE", m3_PARE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());
			if (m3_ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3_ISMD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (m3_VOM3.HasValue)
				request.WithQueryParameter("VOM3", m3_VOM3.Value.ToString());
			if (m3_FRCP.HasValue)
				request.WithQueryParameter("FRCP", m3_FRCP.Value.ToString());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LODO))
				request.WithQueryParameter("LODO", m3_LODO.Trim());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<AddCOPickResponse>(
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
		/// Name AddCOReturn
		/// Description Add Customer Order Return
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_REPN">Receiving number (Required)</param>
		/// <param name="m3_RELI">Line number (Required)</param>
		/// <param name="m3_RESP">Responsible (Required)</param>
		/// <param name="m3_PRFL">Process Flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_QTY">Returned Quantity</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_USD1">User Defined 1</param>
		/// <param name="m3_USD2">User defined 2</param>
		/// <param name="m3_USD3">User defined 3</param>
		/// <param name="m3_USD4">User defined 4</param>
		/// <param name="m3_USD5">User defined 5</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddCOReturnResponse></returns>
		/// <exception cref="M3Exception<AddCOReturnResponse>"></exception>
		public async Task<M3Response<AddCOReturnResponse>> AddCOReturn(
			string m3_WHLO, 
			string m3_E0PA, 
			string m3_E065, 
			string m3_CUNO, 
			long m3_REPN, 
			int m3_RELI, 
			string m3_RESP, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSGN = null, 
			string m3_PACN = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_ADID = null, 
			string m3_ITNO = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			decimal? m3_QTY = null, 
			decimal? m3_CAWE = null, 
			string m3_RIDN = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			string m3_PMSN = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCOReturn",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_RESP))
				throw new ArgumentNullException("m3_RESP");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("REPN", m3_REPN.ToString())
				.WithQueryParameter("RELI", m3_RELI.ToString())
				.WithQueryParameter("RESP", m3_RESP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_QTY.HasValue)
				request.WithQueryParameter("QTY", m3_QTY.Value.ToString());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<AddCOReturnResponse>(
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
		/// Name AddCfmPickList
		/// Description Add Confirm Picklist
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_DLIX">Delivery number (Required)</param>
		/// <param name="m3_PLSX">Picking list suffix (Required)</param>
		/// <param name="m3_PRMD">Process Flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ISMD">Issue/move mode</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_USD1">User defined - 1</param>
		/// <param name="m3_UDS2">User defined - 2</param>
		/// <param name="m3_USD3">User defined - 3</param>
		/// <param name="m3_USD4">User defined - 4</param>
		/// <param name="m3_USD5">User defined - 5</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_LODO">Loading platform</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddCfmPickListResponse></returns>
		/// <exception cref="M3Exception<AddCfmPickListResponse>"></exception>
		public async Task<M3Response<AddCfmPickListResponse>> AddCfmPickList(
			string m3_WHLO, 
			string m3_E0PA, 
			string m3_E065, 
			decimal m3_DLIX, 
			int m3_PLSX, 
			string m3_PRMD = null, 
			int? m3_CONO = null, 
			int? m3_ISMD = null, 
			string m3_TWSL = null, 
			string m3_MSGN = null, 
			string m3_PMSN = null, 
			string m3_PACN = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_USD1 = null, 
			string m3_UDS2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			DateTime? m3_RPDT = null, 
			int? m3_RPTM = null, 
			string m3_LODO = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCfmPickList",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("DLIX", m3_DLIX.ToString())
				.WithQueryParameter("PLSX", m3_PLSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3_ISMD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UDS2))
				request.WithQueryParameter("UDS2", m3_UDS2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LODO))
				request.WithQueryParameter("LODO", m3_LODO.Trim());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<AddCfmPickListResponse>(
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
		/// Name AddDO
		/// Description Add DO transaction
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E0PB">Partner ID (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_TRTP">Order type (Required)</param>
		/// <param name="m3_RESP">Responsible (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_ADID">Address ID</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias category</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_ALQT">Allocate qty - basic U/M</param>
		/// <param name="m3_DLQT">Delivered qty - basic U/M</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_RIDI">Delivery number</param>
		/// <param name="m3_PLSX">Picking list suffix</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_USD1">User defined field</param>
		/// <param name="m3_USD2">User defined field</param>
		/// <param name="m3_USD3">User defined field</param>
		/// <param name="m3_USD4">User defined field</param>
		/// <param name="m3_USD5">User defined field</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference Order Number</param>
		/// <param name="m3_RORL">Reference Order Line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddDOResponse></returns>
		/// <exception cref="M3Exception<AddDOResponse>"></exception>
		public async Task<M3Response<AddDOResponse>> AddDO(
			string m3_WHLO, 
			string m3_E0PA, 
			string m3_E0PB, 
			string m3_E065, 
			string m3_TRTP, 
			string m3_RESP, 
			string m3_PRMD = null, 
			int? m3_CONO = null, 
			string m3_MSGN = null, 
			string m3_PACN = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_CUNO = null, 
			string m3_ADID = null, 
			string m3_ITNO = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			string m3_WHSL = null, 
			string m3_TWSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			decimal? m3_ALQT = null, 
			decimal? m3_DLQT = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
			decimal? m3_RIDI = null, 
			int? m3_PLSX = null, 
			decimal? m3_DLIX = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_CAWE = null, 
			string m3_PMSN = null, 
			int? m3_OPNO = null, 
			string m3_RSCD = null, 
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			DateTime? m3_RPDT = null, 
			int? m3_RPTM = null, 
			long? m3_REPN = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddDO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E0PB))
				throw new ArgumentNullException("m3_E0PB");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_TRTP))
				throw new ArgumentNullException("m3_TRTP");
			if (string.IsNullOrWhiteSpace(m3_RESP))
				throw new ArgumentNullException("m3_RESP");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E0PB", m3_E0PB.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("TRTP", m3_TRTP.Trim())
				.WithQueryParameter("RESP", m3_RESP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_ALQT.HasValue)
				request.WithQueryParameter("ALQT", m3_ALQT.Value.ToString());
			if (m3_DLQT.HasValue)
				request.WithQueryParameter("DLQT", m3_DLQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (m3_RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3_RIDI.Value.ToString());
			if (m3_PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3_PLSX.Value.ToString());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<AddDOResponse>(
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
		/// Name AddDOPackRec
		/// Description AddPackReceipt
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_TWSL">To Location (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_CONN">Shipment</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddDOPackRecResponse></returns>
		/// <exception cref="M3Exception<AddDOPackRecResponse>"></exception>
		public async Task<M3Response<AddDOPackRecResponse>> AddDOPackRec(
			string m3_WHLO, 
			string m3_E0PA, 
			string m3_E065, 
			string m3_TWSL, 
			string m3_PRMD = null, 
			int? m3_CONO = null, 
			string m3_MSGN = null, 
			string m3_PACN = null, 
			int? m3_CONN = null, 
			decimal? m3_DLIX = null, 
			string m3_SSCC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddDOPackRec",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_TWSL))
				throw new ArgumentNullException("m3_TWSL");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("TWSL", m3_TWSL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_CONN.HasValue)
				request.WithQueryParameter("CONN", m3_CONN.Value.ToString());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());

			// Execute the request
			var result = await Execute<AddDOPackRecResponse>(
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
		/// Name AddDOPick
		/// Description Add Distribution Order Pick
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line (Required)</param>
		/// <param name="m3_RIDI">Order index (Required)</param>
		/// <param name="m3_PLSX">Picking list suffix (Required)</param>
		/// <param name="m3_PRFL">Process Flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_QTYP">Quantity Picked</param>
		/// <param name="m3_QTYO">Quantity to be picked</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_USD1">User Defined 1</param>
		/// <param name="m3_USD2">User defined 2</param>
		/// <param name="m3_USD3">User defined 3</param>
		/// <param name="m3_USD4">User defined 4</param>
		/// <param name="m3_USD5">User defined 5</param>
		/// <param name="m3_PLRN">Reporting number - pick line</param>
		/// <param name="m3_OEND">Flagged as completed</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_AMKO">Number of packages</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="m3_PARE">Packaging reference</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="m3_ISMD">Issue/move mode</param>
		/// <param name="m3_BREF">Lot Reference 1</param>
		/// <param name="m3_BRE2">Lot Reference 2</param>
		/// <param name="m3_GRWE">Gross Weight</param>
		/// <param name="m3_VOM3">Volume</param>
		/// <param name="m3_FRCP">Free capacity unit</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_LODO">Loading platform</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddDOPickResponse></returns>
		/// <exception cref="M3Exception<AddDOPickResponse>"></exception>
		public async Task<M3Response<AddDOPickResponse>> AddDOPick(
			string m3_WHLO, 
			string m3_E0PA, 
			string m3_E065, 
			string m3_RIDN, 
			int m3_RIDL, 
			decimal m3_RIDI, 
			int m3_PLSX, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSGN = null, 
			string m3_PACN = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_ADID = null, 
			string m3_ITNO = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			decimal? m3_QTYP = null, 
			decimal? m3_QTYO = null, 
			int? m3_RIDX = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_PLRN = null, 
			int? m3_OEND = null, 
			DateTime? m3_RPDT = null, 
			decimal? m3_CAWE = null, 
			string m3_PACT = null, 
			int? m3_AMKO = null, 
			string m3_PMSN = null, 
			string m3_TWSL = null, 
			string m3_PARE = null, 
			string m3_SSCC = null, 
			int? m3_ISMD = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			decimal? m3_GRWE = null, 
			decimal? m3_VOM3 = null, 
			decimal? m3_FRCP = null, 
			int? m3_RPTM = null, 
			string m3_LODO = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddDOPick",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("RIDL", m3_RIDL.ToString())
				.WithQueryParameter("RIDI", m3_RIDI.ToString())
				.WithQueryParameter("PLSX", m3_PLSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_QTYP.HasValue)
				request.WithQueryParameter("QTYP", m3_QTYP.Value.ToString());
			if (m3_QTYO.HasValue)
				request.WithQueryParameter("QTYO", m3_QTYO.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_PLRN.HasValue)
				request.WithQueryParameter("PLRN", m3_PLRN.Value.ToString());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (m3_AMKO.HasValue)
				request.WithQueryParameter("AMKO", m3_AMKO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PARE))
				request.WithQueryParameter("PARE", m3_PARE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());
			if (m3_ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3_ISMD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (m3_VOM3.HasValue)
				request.WithQueryParameter("VOM3", m3_VOM3.Value.ToString());
			if (m3_FRCP.HasValue)
				request.WithQueryParameter("FRCP", m3_FRCP.Value.ToString());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LODO))
				request.WithQueryParameter("LODO", m3_LODO.Trim());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<AddDOPickResponse>(
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
		/// Name AddDORecViaPack
		/// Description DO Reciept Via Packaging
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_PRFL">Process flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="m3_DLIX">Delivery</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDORecViaPack(
			string m3_E0PA, 
			string m3_E065, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_PACN = null, 
			string m3_SSCC = null, 
			decimal? m3_DLIX = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
			string m3_MSGN = null, 
			string m3_ITNO = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddDORecViaPack",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

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
		/// Name AddDOReceipt
		/// Description Add Distribution Order Receipt
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_QTY">Quantity Received (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line (Required)</param>
		/// <param name="m3_RIDI">Order index (Required)</param>
		/// <param name="m3_PRFL">Process Flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_TWHL">From Warehouse</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_RIDO">Order operation</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_PLSX">Picking list suffix</param>
		/// <param name="m3_USD1">User Defined 1</param>
		/// <param name="m3_USD2">User defined 2</param>
		/// <param name="m3_USD3">User defined 3</param>
		/// <param name="m3_USD4">User defined 4</param>
		/// <param name="m3_USD5">User defined 5</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_BREF">Lot Reference 1</param>
		/// <param name="m3_BRE2">Lot Reference 2</param>
		/// <param name="m3_OEND">Flagged as completed</param>
		/// <param name="m3_RPDT">Reporting Date</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_TOCA">To Container</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddDOReceiptResponse></returns>
		/// <exception cref="M3Exception<AddDOReceiptResponse>"></exception>
		public async Task<M3Response<AddDOReceiptResponse>> AddDOReceipt(
			string m3_WHLO, 
			string m3_E0PA, 
			string m3_E065, 
			decimal m3_QTY, 
			string m3_RIDN, 
			int m3_RIDL, 
			decimal m3_RIDI, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSGN = null, 
			string m3_PACN = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_TWHL = null, 
			string m3_ADID = null, 
			string m3_ITNO = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			int? m3_RIDO = null, 
			int? m3_RIDX = null, 
			int? m3_PLSX = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_CAWE = null, 
			string m3_PMSN = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			int? m3_OEND = null, 
			DateTime? m3_RPDT = null, 
			int? m3_RPTM = null, 
			string m3_TOCA = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddDOReceipt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("QTY", m3_QTY.ToString())
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("RIDL", m3_RIDL.ToString())
				.WithQueryParameter("RIDI", m3_RIDI.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TWHL))
				request.WithQueryParameter("TWHL", m3_TWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_RIDO.HasValue)
				request.WithQueryParameter("RIDO", m3_RIDO.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (m3_PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3_PLSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TOCA))
				request.WithQueryParameter("TOCA", m3_TOCA.Trim());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<AddDOReceiptResponse>(
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
		/// Name AddMOPick
		/// Description Add Manufacturing Order Pick
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line (Required)</param>
		/// <param name="m3_RIDO">Order operation (Required)</param>
		/// <param name="m3_DLIX">Delivery index (Required)</param>
		/// <param name="m3_PLSX">Picking list suffix (Required)</param>
		/// <param name="m3_PRFL">Process Flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_QTYP">Quantity Picked</param>
		/// <param name="m3_QTYO">Quantity to be picked</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_USD1">User Defined 1</param>
		/// <param name="m3_USD2">User defined 2</param>
		/// <param name="m3_USD3">User defined 3</param>
		/// <param name="m3_USD4">User defined 4</param>
		/// <param name="m3_USD5">User defined 5</param>
		/// <param name="m3_PLRN">Reporting number - pick line</param>
		/// <param name="m3_OEND">Flagged as completed</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="m3_PARE">Packaging reference</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="m3_ISMD">Issue/move mode</param>
		/// <param name="m3_GRWE">Gross weight</param>
		/// <param name="m3_VOM3">Volume</param>
		/// <param name="m3_FRCP">Free capacity</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_AMKO">Number of packages</param>
		/// <param name="m3_LODO">Loading platform</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddMOPickResponse></returns>
		/// <exception cref="M3Exception<AddMOPickResponse>"></exception>
		public async Task<M3Response<AddMOPickResponse>> AddMOPick(
			string m3_WHLO, 
			string m3_E0PA, 
			string m3_E065, 
			string m3_RIDN, 
			int m3_RIDL, 
			int m3_RIDO, 
			decimal m3_DLIX, 
			int m3_PLSX, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSGN = null, 
			string m3_PACN = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_ADID = null, 
			string m3_ITNO = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			decimal? m3_QTYP = null, 
			decimal? m3_QTYO = null, 
			int? m3_RIDX = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_PLRN = null, 
			int? m3_OEND = null, 
			DateTime? m3_RPDT = null, 
			decimal? m3_CAWE = null, 
			string m3_PMSN = null, 
			string m3_TWSL = null, 
			string m3_PARE = null, 
			string m3_SSCC = null, 
			int? m3_ISMD = null, 
			decimal? m3_GRWE = null, 
			decimal? m3_VOM3 = null, 
			decimal? m3_FRCP = null, 
			int? m3_RPTM = null, 
			string m3_PACT = null, 
			int? m3_AMKO = null, 
			string m3_LODO = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddMOPick",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("RIDL", m3_RIDL.ToString())
				.WithQueryParameter("RIDO", m3_RIDO.ToString())
				.WithQueryParameter("DLIX", m3_DLIX.ToString())
				.WithQueryParameter("PLSX", m3_PLSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_QTYP.HasValue)
				request.WithQueryParameter("QTYP", m3_QTYP.Value.ToString());
			if (m3_QTYO.HasValue)
				request.WithQueryParameter("QTYO", m3_QTYO.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_PLRN.HasValue)
				request.WithQueryParameter("PLRN", m3_PLRN.Value.ToString());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PARE))
				request.WithQueryParameter("PARE", m3_PARE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());
			if (m3_ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3_ISMD.Value.ToString());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (m3_VOM3.HasValue)
				request.WithQueryParameter("VOM3", m3_VOM3.Value.ToString());
			if (m3_FRCP.HasValue)
				request.WithQueryParameter("FRCP", m3_FRCP.Value.ToString());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (m3_AMKO.HasValue)
				request.WithQueryParameter("AMKO", m3_AMKO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LODO))
				request.WithQueryParameter("LODO", m3_LODO.Trim());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<AddMOPickResponse>(
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
		/// Name AddMOReceipt
		/// Description Add Manufacturing Order Receipt
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_PRFL">Process Flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_TWHL">From Warehouse</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_QTY">Quantity Received</param>
		/// <param name="m3_RIDO">Order operation</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_RIDI">Order index</param>
		/// <param name="m3_PLSX">Picking list suffix</param>
		/// <param name="m3_USD1">User Defined 1</param>
		/// <param name="m3_USD2">User defined 2</param>
		/// <param name="m3_USD3">User defined 3</param>
		/// <param name="m3_USD4">User defined 4</param>
		/// <param name="m3_USD5">User defined 5</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_BREF">Lot Reference 1</param>
		/// <param name="m3_BRE2">Lot Reference 2</param>
		/// <param name="m3_OEND">Flagged as completed</param>
		/// <param name="m3_RPDT">Reporting Date</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_STAS">Status - balance ID</param>
		/// <param name="m3_POCY">Normal potency</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddMOReceiptResponse></returns>
		/// <exception cref="M3Exception<AddMOReceiptResponse>"></exception>
		public async Task<M3Response<AddMOReceiptResponse>> AddMOReceipt(
			string m3_WHLO, 
			string m3_E0PA, 
			string m3_E065, 
			string m3_RIDN, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSGN = null, 
			string m3_PACN = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_TWHL = null, 
			string m3_ADID = null, 
			string m3_ITNO = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			decimal? m3_QTY = null, 
			int? m3_RIDO = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
			decimal? m3_RIDI = null, 
			int? m3_PLSX = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_CAWE = null, 
			string m3_PMSN = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			int? m3_OEND = null, 
			DateTime? m3_RPDT = null, 
			int? m3_RPTM = null, 
			string m3_STAS = null, 
			int? m3_POCY = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddMOReceipt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("RIDN", m3_RIDN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TWHL))
				request.WithQueryParameter("TWHL", m3_TWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_QTY.HasValue)
				request.WithQueryParameter("QTY", m3_QTY.Value.ToString());
			if (m3_RIDO.HasValue)
				request.WithQueryParameter("RIDO", m3_RIDO.Value.ToString());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (m3_RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3_RIDI.Value.ToString());
			if (m3_PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3_PLSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAS))
				request.WithQueryParameter("STAS", m3_STAS.Trim());
			if (m3_POCY.HasValue)
				request.WithQueryParameter("POCY", m3_POCY.Value.ToString());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<AddMOReceiptResponse>(
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
		/// Name AddPOClose
		/// Description Add Purchase Order Close
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_PRFL">Process flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_USD1">User defined 1</param>
		/// <param name="m3_USD2">User defined 2</param>
		/// <param name="m3_USD3">User defined 3</param>
		/// <param name="m3_USD4">User defined 4</param>
		/// <param name="m3_USD5">User defined 5</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPOCloseResponse></returns>
		/// <exception cref="M3Exception<AddPOCloseResponse>"></exception>
		public async Task<M3Response<AddPOCloseResponse>> AddPOClose(
			string m3_WHLO, 
			string m3_E0PA, 
			string m3_E065, 
			string m3_RIDN, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSGN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
			string m3_PMSN = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			string m3_PACN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPOClose",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("RIDN", m3_RIDN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());

			// Execute the request
			var result = await Execute<AddPOCloseResponse>(
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
		/// Name AddPOInspect
		/// Description Add Purchase Order Inspection
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SUTY">Supplier type (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line (Required)</param>
		/// <param name="m3_PRFL">Process Flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_QCRA">Quality inspection result</param>
		/// <param name="m3_SCRE">Rejection reason</param>
		/// <param name="m3_QTY">Quantity Received</param>
		/// <param name="m3_OEND">Flagged as completed</param>
		/// <param name="m3_EXPI">Expiration date</param>
		/// <param name="m3_SEDT">Sales date</param>
		/// <param name="m3_CNDT">Follow-up date</param>
		/// <param name="m3_USD1">User Defined 1</param>
		/// <param name="m3_USD2">User defined 2</param>
		/// <param name="m3_USD3">User defined 3</param>
		/// <param name="m3_USD4">User defined 4</param>
		/// <param name="m3_USD5">User defined 5</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPOInspectResponse></returns>
		/// <exception cref="M3Exception<AddPOInspectResponse>"></exception>
		public async Task<M3Response<AddPOInspectResponse>> AddPOInspect(
			string m3_WHLO, 
			string m3_E0PA, 
			string m3_E065, 
			string m3_SUNO, 
			int m3_SUTY, 
			string m3_RIDN, 
			int m3_RIDL, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSGN = null, 
			string m3_PACN = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_ADID = null, 
			int? m3_RIDX = null, 
			string m3_ITNO = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			string m3_BREM = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			string m3_QCRA = null, 
			string m3_SCRE = null, 
			decimal? m3_QTY = null, 
			int? m3_OEND = null, 
			DateTime? m3_EXPI = null, 
			DateTime? m3_SEDT = null, 
			DateTime? m3_CNDT = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			string m3_PMSN = null, 
			string m3_RESP = null, 
			long? m3_REPN = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPOInspect",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SUTY", m3_SUTY.ToString())
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("RIDL", m3_RIDL.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QCRA))
				request.WithQueryParameter("QCRA", m3_QCRA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCRE))
				request.WithQueryParameter("SCRE", m3_SCRE.Trim());
			if (m3_QTY.HasValue)
				request.WithQueryParameter("QTY", m3_QTY.Value.ToString());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (m3_EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3_EXPI.Value.ToM3String());
			if (m3_SEDT.HasValue)
				request.WithQueryParameter("SEDT", m3_SEDT.Value.ToM3String());
			if (m3_CNDT.HasValue)
				request.WithQueryParameter("CNDT", m3_CNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<AddPOInspectResponse>(
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
		/// Name AddPOPackInsp
		/// Description Add PO Inspection by package
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_E0PA">Partner</param>
		/// <param name="m3_E065">Message type</param>
		/// <param name="m3_QCRA">Quality inspection result</param>
		/// <param name="m3_SCRE">Rejection reason</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_OEND">Flagged as completed</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPOPackInspResponse></returns>
		/// <exception cref="M3Exception<AddPOPackInspResponse>"></exception>
		public async Task<M3Response<AddPOPackInspResponse>> AddPOPackInsp(
			string m3_PRMD = null, 
			int? m3_CONO = null, 
			string m3_WHLO = null, 
			string m3_MSGN = null, 
			string m3_PACN = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_E0PA = null, 
			string m3_E065 = null, 
			string m3_QCRA = null, 
			string m3_SCRE = null, 
			string m3_TWSL = null, 
			string m3_BREM = null, 
			string m3_RESP = null, 
			int? m3_OEND = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPOPackInsp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_E0PA))
				request.WithQueryParameter("E0PA", m3_E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E065))
				request.WithQueryParameter("E065", m3_E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QCRA))
				request.WithQueryParameter("QCRA", m3_QCRA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCRE))
				request.WithQueryParameter("SCRE", m3_SCRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<AddPOPackInspResponse>(
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
		/// Name AddPOPutaway
		/// Description Add Purchase OrderPut away
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SUTY">Supplier type (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line (Required)</param>
		/// <param name="m3_REPN">Receiving number (Required)</param>
		/// <param name="m3_PRFL">Process Flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_BREF">Lot Reference 1</param>
		/// <param name="m3_BRE2">Lot Reference 2</param>
		/// <param name="m3_QTY">Quantity Received</param>
		/// <param name="m3_OEND">Flagged as completed</param>
		/// <param name="m3_EXPI">Expiration date</param>
		/// <param name="m3_USD1">User Defined 1</param>
		/// <param name="m3_USD2">User defined 2</param>
		/// <param name="m3_USD3">User defined 3</param>
		/// <param name="m3_USD4">User defined 4</param>
		/// <param name="m3_USD5">User defined 5</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPOPutawayResponse></returns>
		/// <exception cref="M3Exception<AddPOPutawayResponse>"></exception>
		public async Task<M3Response<AddPOPutawayResponse>> AddPOPutaway(
			string m3_WHLO, 
			string m3_E0PA, 
			string m3_E065, 
			string m3_SUNO, 
			int m3_SUTY, 
			string m3_RIDN, 
			int m3_RIDL, 
			long m3_REPN, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSGN = null, 
			string m3_PACN = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_ADID = null, 
			int? m3_RIDX = null, 
			string m3_ITNO = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			decimal? m3_CAWE = null, 
			string m3_BREM = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			decimal? m3_QTY = null, 
			int? m3_OEND = null, 
			DateTime? m3_EXPI = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			string m3_PMSN = null, 
			string m3_RESP = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPOPutaway",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SUTY", m3_SUTY.ToString())
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("RIDL", m3_RIDL.ToString())
				.WithQueryParameter("REPN", m3_REPN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (m3_QTY.HasValue)
				request.WithQueryParameter("QTY", m3_QTY.Value.ToString());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (m3_EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3_EXPI.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<AddPOPutawayResponse>(
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
		/// Name AddPOReceipt
		/// Description Add Purchase Order Receipt
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SUTY">Supplier type (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line (Required)</param>
		/// <param name="m3_PRFL">Process Flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_QTY">Quantity Received</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_USD1">User Defined 1</param>
		/// <param name="m3_USD2">User defined 2</param>
		/// <param name="m3_USD3">User defined 3</param>
		/// <param name="m3_USD4">User defined 4</param>
		/// <param name="m3_USD5">User defined 5</param>
		/// <param name="m3_RIDI">Delivery number</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_OEND">Flagged as completed</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_BREF">Lot Reference 1</param>
		/// <param name="m3_BRE2">Lot Reference 2</param>
		/// <param name="m3_EXPI">Expiration date</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_DNDT">Delivery note date</param>
		/// <param name="m3_POCY">Normal potency</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPOReceiptResponse></returns>
		/// <exception cref="M3Exception<AddPOReceiptResponse>"></exception>
		public async Task<M3Response<AddPOReceiptResponse>> AddPOReceipt(
			string m3_WHLO, 
			string m3_E0PA, 
			string m3_E065, 
			string m3_SUNO, 
			int m3_SUTY, 
			string m3_RIDN, 
			int m3_RIDL, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSGN = null, 
			string m3_PACN = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_ADID = null, 
			string m3_ITNO = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			decimal? m3_QTY = null, 
			int? m3_RIDX = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_RIDI = null, 
			decimal? m3_CAWE = null, 
			int? m3_OEND = null, 
			string m3_PMSN = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			DateTime? m3_EXPI = null, 
			DateTime? m3_RPDT = null, 
			int? m3_RPTM = null, 
			string m3_SUDO = null, 
			DateTime? m3_DNDT = null, 
			int? m3_POCY = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPOReceipt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SUTY", m3_SUTY.ToString())
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("RIDL", m3_RIDL.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_QTY.HasValue)
				request.WithQueryParameter("QTY", m3_QTY.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3_RIDI.Value.ToString());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (m3_EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3_EXPI.Value.ToM3String());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (m3_DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3_DNDT.Value.ToM3String());
			if (m3_POCY.HasValue)
				request.WithQueryParameter("POCY", m3_POCY.Value.ToString());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<AddPOReceiptResponse>(
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
		/// Name AddPickByCubAl
		/// Description Add pick by cubing allocation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPickByCubAlResponse></returns>
		/// <exception cref="M3Exception<AddPickByCubAlResponse>"></exception>
		public async Task<M3Response<AddPickByCubAlResponse>> AddPickByCubAl(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPickByCubAl",
			};

			// Execute the request
			var result = await Execute<AddPickByCubAlResponse>(
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
		/// Name AddPickByIntPac
		/// Description Add pci by int pac
		/// Version Release: 14.x
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPickByIntPacResponse></returns>
		/// <exception cref="M3Exception<AddPickByIntPacResponse>"></exception>
		public async Task<M3Response<AddPickByIntPacResponse>> AddPickByIntPac(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPickByIntPac",
			};

			// Execute the request
			var result = await Execute<AddPickByIntPacResponse>(
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
		/// Name AddPickByPacStk
		/// Description AddPickByPackage inStock
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_DLIX">Delivery number (Required)</param>
		/// <param name="m3_PRMD">Process Flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="m3_ISMD">Issue/move mode</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_USD1">User defined - 1</param>
		/// <param name="m3_UDS2">User defined - 2</param>
		/// <param name="m3_USD3">User defined - 3</param>
		/// <param name="m3_USD4">User defined - 4</param>
		/// <param name="m3_USD5">User defined - 5</param>
		/// <param name="m3_LODO">Loading platform</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPickByPacStkResponse></returns>
		/// <exception cref="M3Exception<AddPickByPacStkResponse>"></exception>
		public async Task<M3Response<AddPickByPacStkResponse>> AddPickByPacStk(
			string m3_WHLO, 
			string m3_E0PA, 
			string m3_E065, 
			decimal m3_DLIX, 
			string m3_PRMD = null, 
			int? m3_CONO = null, 
			string m3_MSGN = null, 
			string m3_PMSN = null, 
			string m3_PANR = null, 
			string m3_SSCC = null, 
			int? m3_ISMD = null, 
			string m3_TWSL = null, 
			DateTime? m3_RPDT = null, 
			int? m3_RPTM = null, 
			string m3_USD1 = null, 
			string m3_UDS2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			string m3_LODO = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPickByPacStk",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("DLIX", m3_DLIX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());
			if (m3_ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3_ISMD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UDS2))
				request.WithQueryParameter("UDS2", m3_UDS2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LODO))
				request.WithQueryParameter("LODO", m3_LODO.Trim());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<AddPickByPacStkResponse>(
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
		/// Name AddPickSftPacLn
		/// Description Add pick by soft packed line
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_DLIX">Delivery number (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_PRMD">Process Flag</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_ALWT">Alias category</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_TRQT">Transaction quantity - basic U/M</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_ISMD">Issue/move mode</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_USD1">User defined - 1</param>
		/// <param name="m3_USD3">User defined - 3</param>
		/// <param name="m3_USD4">User defined - 4</param>
		/// <param name="m3_USD5">User defined - 5</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_LODO">Loading platform</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPickSftPacLnResponse></returns>
		/// <exception cref="M3Exception<AddPickSftPacLnResponse>"></exception>
		public async Task<M3Response<AddPickSftPacLnResponse>> AddPickSftPacLn(
			string m3_E0PA, 
			string m3_E065, 
			decimal m3_DLIX, 
			string m3_WHLO, 
			string m3_PRMD = null, 
			string m3_MSGN = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_PACN = null, 
			string m3_SSCC = null, 
			string m3_ITNO = null, 
			string m3_WHSL = null, 
			string m3_CAMU = null, 
			string m3_BANO = null, 
			int? m3_ALWT = null, 
			string m3_ALWQ = null, 
			string m3_POPN = null, 
			decimal? m3_TRQT = null, 
			decimal? m3_CAWE = null, 
			int? m3_ISMD = null, 
			string m3_TWSL = null, 
			DateTime? m3_RPDT = null, 
			int? m3_RPTM = null, 
			string m3_USD1 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			string m3_USD2 = null, 
			string m3_LODO = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPickSftPacLn",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("DLIX", m3_DLIX.ToString())
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (m3_TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3_TRQT.Value.ToString());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (m3_ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3_ISMD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LODO))
				request.WithQueryParameter("LODO", m3_LODO.Trim());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<AddPickSftPacLnResponse>(
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
		/// Name AddPickViaPack
		/// Description AddPickViaPackage
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_DLIX">Delivery number (Required)</param>
		/// <param name="m3_PRMD">Process Flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="m3_ISMD">Issue/move mode</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_USD1">User defined - 1</param>
		/// <param name="m3_UDS2">User defined - 2</param>
		/// <param name="m3_USD3">User defined - 3</param>
		/// <param name="m3_USD4">User defined - 4</param>
		/// <param name="m3_USD5">User defined - 5</param>
		/// <param name="m3_LODO">Loading platform</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPickViaPackResponse></returns>
		/// <exception cref="M3Exception<AddPickViaPackResponse>"></exception>
		public async Task<M3Response<AddPickViaPackResponse>> AddPickViaPack(
			string m3_WHLO, 
			string m3_E0PA, 
			string m3_E065, 
			decimal m3_DLIX, 
			string m3_PRMD = null, 
			int? m3_CONO = null, 
			string m3_MSGN = null, 
			string m3_PMSN = null, 
			string m3_PANR = null, 
			string m3_SSCC = null, 
			int? m3_ISMD = null, 
			string m3_TWSL = null, 
			DateTime? m3_RPDT = null, 
			int? m3_RPTM = null, 
			string m3_USD1 = null, 
			string m3_UDS2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			string m3_LODO = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPickViaPack",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("DLIX", m3_DLIX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());
			if (m3_ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3_ISMD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UDS2))
				request.WithQueryParameter("UDS2", m3_UDS2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LODO))
				request.WithQueryParameter("LODO", m3_LODO.Trim());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<AddPickViaPackResponse>(
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
		/// Name AddPickViaRepNo
		/// Description Add Pick list via Reporting number
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_PLRN">Reporting number - pick line (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_QTYP">Quantity Picked</param>
		/// <param name="m3_QTYO">Quantity to be picked</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="m3_OEND">Flagged as completed</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_AMKO">Number of packages</param>
		/// <param name="m3_PARE">Packaging reference</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="m3_ISMD">Issue/move mode</param>
		/// <param name="m3_GRWE">Gross weight</param>
		/// <param name="m3_VOM3">Volume</param>
		/// <param name="m3_FRCP">Free Capacity unit</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_LODO">Loading platform</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPickViaRepNoResponse></returns>
		/// <exception cref="M3Exception<AddPickViaRepNoResponse>"></exception>
		public async Task<M3Response<AddPickViaRepNoResponse>> AddPickViaRepNo(
			string m3_WHLO, 
			string m3_E0PA, 
			string m3_E065, 
			decimal m3_PLRN, 
			string m3_PRMD = null, 
			int? m3_CONO = null, 
			string m3_MSGN = null, 
			string m3_PACN = null, 
			int? m3_MSLN = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			decimal? m3_QTYP = null, 
			decimal? m3_QTYO = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			string m3_TWSL = null, 
			int? m3_OEND = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			DateTime? m3_RPDT = null, 
			string m3_PACT = null, 
			int? m3_AMKO = null, 
			string m3_PARE = null, 
			string m3_SSCC = null, 
			int? m3_ISMD = null, 
			decimal? m3_GRWE = null, 
			decimal? m3_VOM3 = null, 
			decimal? m3_FRCP = null, 
			int? m3_RPTM = null, 
			decimal? m3_CAWE = null, 
			string m3_PMSN = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			string m3_LODO = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPickViaRepNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("PLRN", m3_PLRN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (m3_QTYP.HasValue)
				request.WithQueryParameter("QTYP", m3_QTYP.Value.ToString());
			if (m3_QTYO.HasValue)
				request.WithQueryParameter("QTYO", m3_QTYO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (m3_AMKO.HasValue)
				request.WithQueryParameter("AMKO", m3_AMKO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PARE))
				request.WithQueryParameter("PARE", m3_PARE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());
			if (m3_ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3_ISMD.Value.ToString());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (m3_VOM3.HasValue)
				request.WithQueryParameter("VOM3", m3_VOM3.Value.ToString());
			if (m3_FRCP.HasValue)
				request.WithQueryParameter("FRCP", m3_FRCP.Value.ToString());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LODO))
				request.WithQueryParameter("LODO", m3_LODO.Trim());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<AddPickViaRepNoResponse>(
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
		/// Name AddPickViaSblot
		/// Description AddPickViaSblot
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_PLRN">Reporting number - pick line (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_BANT">Reference sublot ID</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="m3_OEND">Flagged as completed</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_ISMD">Issue/move mode</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPickViaSblotResponse></returns>
		/// <exception cref="M3Exception<AddPickViaSblotResponse>"></exception>
		public async Task<M3Response<AddPickViaSblotResponse>> AddPickViaSblot(
			string m3_WHLO, 
			string m3_E0PA, 
			string m3_E065, 
			decimal m3_PLRN, 
			string m3_PRMD = null, 
			int? m3_CONO = null, 
			string m3_MSGN = null, 
			string m3_PACN = null, 
			int? m3_MSLN = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_BANT = null, 
			string m3_TWSL = null, 
			int? m3_OEND = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			int? m3_ISMD = null, 
			DateTime? m3_RPDT = null, 
			int? m3_RPTM = null, 
			string m3_PMSN = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			string m3_PACT = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPickViaSblot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("PLRN", m3_PLRN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANT))
				request.WithQueryParameter("BANT", m3_BANT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3_ISMD.Value.ToString());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<AddPickViaSblotResponse>(
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
		/// Name AddPutAwayConf
		/// Description Two Step Put Away
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_PANO">Put-away number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_RVQA">Received quantity</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias category</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPutAwayConfResponse></returns>
		/// <exception cref="M3Exception<AddPutAwayConfResponse>"></exception>
		public async Task<M3Response<AddPutAwayConfResponse>> AddPutAwayConf(
			string m3_WHLO, 
			string m3_E0PA, 
			string m3_E065, 
			string m3_PRMD = null, 
			int? m3_CONO = null, 
			string m3_MSGN = null, 
			int? m3_MSLN = null, 
			string m3_PACN = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_ITNO = null, 
			string m3_ORCA = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			long? m3_PANO = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			decimal? m3_RVQA = null, 
			long? m3_REPN = null, 
			string m3_WHSL = null, 
			string m3_TWSL = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			string m3_PMSN = null, 
			int? m3_RIDX = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPutAwayConf",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_PANO.HasValue)
				request.WithQueryParameter("PANO", m3_PANO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_RVQA.HasValue)
				request.WithQueryParameter("RVQA", m3_RVQA.Value.ToString());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<AddPutAwayConfResponse>(
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
		/// Name AddPutAwayPack
		/// Description AddPutAwayPack
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_TWSL">To Location</param>
		/// <param name="m3_SPNO">Shipment package number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPutAwayPackResponse></returns>
		/// <exception cref="M3Exception<AddPutAwayPackResponse>"></exception>
		public async Task<M3Response<AddPutAwayPackResponse>> AddPutAwayPack(
			string m3_WHLO, 
			string m3_E0PA, 
			string m3_E065, 
			string m3_PRMD = null, 
			int? m3_CONO = null, 
			string m3_MSGN = null, 
			string m3_PACN = null, 
			string m3_TWSL = null, 
			string m3_SPNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPutAwayPack",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPNO))
				request.WithQueryParameter("SPNO", m3_SPNO.Trim());

			// Execute the request
			var result = await Execute<AddPutAwayPackResponse>(
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
		/// Name AddROPick
		/// Description Add Requisition Order Pick
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line (Required)</param>
		/// <param name="m3_RIDI">Order index (Required)</param>
		/// <param name="m3_PLSX">Picking list suffix (Required)</param>
		/// <param name="m3_PRFL">Process Flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_QTYP">Quantity Picked</param>
		/// <param name="m3_QTYO">Quantity to be picked</param>
		/// <param name="m3_USD1">User Defined 1</param>
		/// <param name="m3_USD2">User defined 2</param>
		/// <param name="m3_USD3">User defined 3</param>
		/// <param name="m3_USD4">User defined 4</param>
		/// <param name="m3_USD5">User defined 5</param>
		/// <param name="m3_PLRN">Reporting number - pick line</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_AMKO">Number of packages</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="m3_OEND">Flagged as completed</param>
		/// <param name="m3_PARE">Packaging reference</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="m3_ISMD">Issue/move mode</param>
		/// <param name="m3_BREF">Lot Reference 1</param>
		/// <param name="m3_BRE2">Lot Reference 2</param>
		/// <param name="m3_GRWE">Gross weight</param>
		/// <param name="m3_VOM3">Volume</param>
		/// <param name="m3_FRCP">Free capacity unit</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_LODO">Loading platform</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddROPickResponse></returns>
		/// <exception cref="M3Exception<AddROPickResponse>"></exception>
		public async Task<M3Response<AddROPickResponse>> AddROPick(
			string m3_WHLO, 
			string m3_E0PA, 
			string m3_E065, 
			string m3_RIDN, 
			int m3_RIDL, 
			decimal m3_RIDI, 
			int m3_PLSX, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSGN = null, 
			string m3_PACN = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_ADID = null, 
			string m3_ITNO = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			decimal? m3_QTYP = null, 
			decimal? m3_QTYO = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_PLRN = null, 
			DateTime? m3_RPDT = null, 
			decimal? m3_CAWE = null, 
			string m3_PACT = null, 
			int? m3_AMKO = null, 
			string m3_PMSN = null, 
			string m3_TWSL = null, 
			int? m3_OEND = null, 
			string m3_PARE = null, 
			string m3_SSCC = null, 
			int? m3_ISMD = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			decimal? m3_GRWE = null, 
			decimal? m3_VOM3 = null, 
			decimal? m3_FRCP = null, 
			int? m3_RPTM = null, 
			int? m3_RIDX = null, 
			string m3_LODO = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddROPick",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("RIDL", m3_RIDL.ToString())
				.WithQueryParameter("RIDI", m3_RIDI.ToString())
				.WithQueryParameter("PLSX", m3_PLSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_QTYP.HasValue)
				request.WithQueryParameter("QTYP", m3_QTYP.Value.ToString());
			if (m3_QTYO.HasValue)
				request.WithQueryParameter("QTYO", m3_QTYO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_PLRN.HasValue)
				request.WithQueryParameter("PLRN", m3_PLRN.Value.ToString());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (m3_AMKO.HasValue)
				request.WithQueryParameter("AMKO", m3_AMKO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PARE))
				request.WithQueryParameter("PARE", m3_PARE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());
			if (m3_ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3_ISMD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (m3_VOM3.HasValue)
				request.WithQueryParameter("VOM3", m3_VOM3.Value.ToString());
			if (m3_FRCP.HasValue)
				request.WithQueryParameter("FRCP", m3_FRCP.Value.ToString());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LODO))
				request.WithQueryParameter("LODO", m3_LODO.Trim());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<AddROPickResponse>(
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
		/// Name AddROReceipt
		/// Description Add Requisition Order Receipt
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_QTY">Quantity Received (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line (Required)</param>
		/// <param name="m3_RIDI">Order index (Required)</param>
		/// <param name="m3_PRFL">Process Flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_RIDO">Order operation</param>
		/// <param name="m3_USD1">User Defined 1</param>
		/// <param name="m3_USD2">User defined 2</param>
		/// <param name="m3_USD3">User defined 3</param>
		/// <param name="m3_USD4">User defined 4</param>
		/// <param name="m3_USD5">User defined 5</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_BREF">Lot Reference 1</param>
		/// <param name="m3_BRE2">Lot Reference 2</param>
		/// <param name="m3_OEND">Flagged as completed</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddROReceiptResponse></returns>
		/// <exception cref="M3Exception<AddROReceiptResponse>"></exception>
		public async Task<M3Response<AddROReceiptResponse>> AddROReceipt(
			string m3_WHLO, 
			string m3_E0PA, 
			string m3_E065, 
			decimal m3_QTY, 
			string m3_RIDN, 
			int m3_RIDL, 
			decimal m3_RIDI, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSGN = null, 
			string m3_PACN = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_ADID = null, 
			string m3_ITNO = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			int? m3_RIDO = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_CAWE = null, 
			string m3_PMSN = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			int? m3_OEND = null, 
			int? m3_RIDX = null, 
			DateTime? m3_RPDT = null, 
			int? m3_RPTM = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddROReceipt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("QTY", m3_QTY.ToString())
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("RIDL", m3_RIDL.ToString())
				.WithQueryParameter("RIDI", m3_RIDI.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_RIDO.HasValue)
				request.WithQueryParameter("RIDO", m3_RIDO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<AddROReceiptResponse>(
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
		/// Name AddReplPick
		/// Description Add Replenishment Order Pick
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line (Required)</param>
		/// <param name="m3_RIDI">Order index (Required)</param>
		/// <param name="m3_PLSX">Picking list suffix (Required)</param>
		/// <param name="m3_PRFL">Process Flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_QTYP">Quantity Picked</param>
		/// <param name="m3_QTYO">Quantity to be picked</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_USD1">User Defined 1</param>
		/// <param name="m3_USD2">User defined 2</param>
		/// <param name="m3_USD3">User defined 3</param>
		/// <param name="m3_USD4">User defined 4</param>
		/// <param name="m3_USD5">User defined 5</param>
		/// <param name="m3_PLRN">Reporting number - pick line</param>
		/// <param name="m3_OEND">Flagged as completed</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_PARE">Packaging reference</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="m3_ISMD">Issue/move mode</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_LODO">Loading platform</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddReplPickResponse></returns>
		/// <exception cref="M3Exception<AddReplPickResponse>"></exception>
		public async Task<M3Response<AddReplPickResponse>> AddReplPick(
			string m3_WHLO, 
			string m3_E0PA, 
			string m3_E065, 
			string m3_RIDN, 
			int m3_RIDL, 
			decimal m3_RIDI, 
			int m3_PLSX, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSGN = null, 
			string m3_PACN = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_ADID = null, 
			string m3_ITNO = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			decimal? m3_QTYP = null, 
			decimal? m3_QTYO = null, 
			int? m3_RIDX = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_PLRN = null, 
			int? m3_OEND = null, 
			DateTime? m3_RPDT = null, 
			decimal? m3_CAWE = null, 
			string m3_PMSN = null, 
			string m3_PARE = null, 
			string m3_SSCC = null, 
			int? m3_ISMD = null, 
			int? m3_RPTM = null, 
			string m3_LODO = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddReplPick",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("RIDL", m3_RIDL.ToString())
				.WithQueryParameter("RIDI", m3_RIDI.ToString())
				.WithQueryParameter("PLSX", m3_PLSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_QTYP.HasValue)
				request.WithQueryParameter("QTYP", m3_QTYP.Value.ToString());
			if (m3_QTYO.HasValue)
				request.WithQueryParameter("QTYO", m3_QTYO.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_PLRN.HasValue)
				request.WithQueryParameter("PLRN", m3_PLRN.Value.ToString());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PARE))
				request.WithQueryParameter("PARE", m3_PARE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());
			if (m3_ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3_ISMD.Value.ToString());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LODO))
				request.WithQueryParameter("LODO", m3_LODO.Trim());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<AddReplPickResponse>(
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
		/// Name AddSubLine
		/// Description AddSubLIne
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_PACN">Package number (Required)</param>
		/// <param name="m3_MSLN">Message line number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SUBL">Subline number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_QLFR">Qualifier</param>
		/// <param name="m3_BANT">Reference sublot ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSubLine(
			string m3_MSGN, 
			string m3_PACN, 
			int m3_MSLN, 
			int? m3_CONO = null, 
			int? m3_SUBL = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			decimal? m3_CAWE = null, 
			string m3_QLFR = null, 
			string m3_BANT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSubLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");
			if (string.IsNullOrWhiteSpace(m3_PACN))
				throw new ArgumentNullException("m3_PACN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim())
				.WithQueryParameter("PACN", m3_PACN.Trim())
				.WithQueryParameter("MSLN", m3_MSLN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_SUBL.HasValue)
				request.WithQueryParameter("SUBL", m3_SUBL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QLFR))
				request.WithQueryParameter("QLFR", m3_QLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANT))
				request.WithQueryParameter("BANT", m3_BANT.Trim());

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
		/// Name AddTransNotify
		/// Description Add transport notification
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_PRFL">Process flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_DNDT">Delivery note date</param>
		/// <param name="m3_EDFR">EDI reference</param>
		/// <param name="m3_PUSN">Delivery note reference</param>
		/// <param name="m3_SORN">Supplier order number</param>
		/// <param name="m3_E0B4">Transport identity - departure</param>
		/// <param name="m3_E0BH">Trailer registration number</param>
		/// <param name="m3_BOLN">Bill of lading</param>
		/// <param name="m3_FWRF">Forwarding agent reference</param>
		/// <param name="m3_SHD4">Requested departure date</param>
		/// <param name="m3_ARDT">Arrival date</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TEDL">Delivery terms</param>
		/// <param name="m3_TFNO">Facsimile transmission number</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddTransNotifyResponse></returns>
		/// <exception cref="M3Exception<AddTransNotifyResponse>"></exception>
		public async Task<M3Response<AddTransNotifyResponse>> AddTransNotify(
			string m3_WHLO, 
			string m3_E0PA, 
			string m3_E065, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSGN = null, 
			string m3_SUNO = null, 
			string m3_SUDO = null, 
			DateTime? m3_DNDT = null, 
			string m3_EDFR = null, 
			string m3_PUSN = null, 
			string m3_SORN = null, 
			string m3_E0B4 = null, 
			string m3_E0BH = null, 
			string m3_BOLN = null, 
			string m3_FWRF = null, 
			DateTime? m3_SHD4 = null, 
			DateTime? m3_ARDT = null, 
			string m3_MODL = null, 
			string m3_TEDL = null, 
			string m3_TFNO = null, 
			string m3_PMSN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddTransNotify",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (m3_DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3_DNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_EDFR))
				request.WithQueryParameter("EDFR", m3_EDFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PUSN))
				request.WithQueryParameter("PUSN", m3_PUSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SORN))
				request.WithQueryParameter("SORN", m3_SORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0B4))
				request.WithQueryParameter("E0B4", m3_E0B4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0BH))
				request.WithQueryParameter("E0BH", m3_E0BH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BOLN))
				request.WithQueryParameter("BOLN", m3_BOLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FWRF))
				request.WithQueryParameter("FWRF", m3_FWRF.Trim());
			if (m3_SHD4.HasValue)
				request.WithQueryParameter("SHD4", m3_SHD4.Value.ToM3String());
			if (m3_ARDT.HasValue)
				request.WithQueryParameter("ARDT", m3_ARDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());

			// Execute the request
			var result = await Execute<AddTransNotifyResponse>(
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
		/// Name AddWOPick
		/// Description Add Work Order Pick
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line (Required)</param>
		/// <param name="m3_RIDO">Order operation (Required)</param>
		/// <param name="m3_DLIX">Delivery index (Required)</param>
		/// <param name="m3_PLSX">Picking list suffix (Required)</param>
		/// <param name="m3_PRFL">Process Flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_QTYP">Quantity Picked</param>
		/// <param name="m3_QTYO">Quantity to be picked</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_USD1">User Defined 1</param>
		/// <param name="m3_USD2">User defined 2</param>
		/// <param name="m3_USD3">User defined 3</param>
		/// <param name="m3_USD4">User defined 4</param>
		/// <param name="m3_USD5">User defined 5</param>
		/// <param name="m3_PLRN">Reporting number - pick line</param>
		/// <param name="m3_OEND">Flagged as completed</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="m3_PARE">Packaging reference</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="m3_ISMD">Issue/move mode</param>
		/// <param name="m3_GRWE">Gross weight</param>
		/// <param name="m3_VOM3">Volume</param>
		/// <param name="m3_FRCP">Free capacity</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_AMKO">Number of packages</param>
		/// <param name="m3_LODO">Loading platform</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddWOPickResponse></returns>
		/// <exception cref="M3Exception<AddWOPickResponse>"></exception>
		public async Task<M3Response<AddWOPickResponse>> AddWOPick(
			string m3_WHLO, 
			string m3_E0PA, 
			string m3_E065, 
			string m3_RIDN, 
			int m3_RIDL, 
			int m3_RIDO, 
			decimal m3_DLIX, 
			int m3_PLSX, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSGN = null, 
			string m3_PACN = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_ADID = null, 
			string m3_ITNO = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			decimal? m3_QTYP = null, 
			decimal? m3_QTYO = null, 
			int? m3_RIDX = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_PLRN = null, 
			int? m3_OEND = null, 
			DateTime? m3_RPDT = null, 
			decimal? m3_CAWE = null, 
			string m3_PMSN = null, 
			string m3_TWSL = null, 
			string m3_PARE = null, 
			string m3_SSCC = null, 
			int? m3_ISMD = null, 
			decimal? m3_GRWE = null, 
			decimal? m3_VOM3 = null, 
			decimal? m3_FRCP = null, 
			int? m3_RPTM = null, 
			string m3_PACT = null, 
			int? m3_AMKO = null, 
			string m3_LODO = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddWOPick",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("RIDL", m3_RIDL.ToString())
				.WithQueryParameter("RIDO", m3_RIDO.ToString())
				.WithQueryParameter("DLIX", m3_DLIX.ToString())
				.WithQueryParameter("PLSX", m3_PLSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_QTYP.HasValue)
				request.WithQueryParameter("QTYP", m3_QTYP.Value.ToString());
			if (m3_QTYO.HasValue)
				request.WithQueryParameter("QTYO", m3_QTYO.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_PLRN.HasValue)
				request.WithQueryParameter("PLRN", m3_PLRN.Value.ToString());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PARE))
				request.WithQueryParameter("PARE", m3_PARE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());
			if (m3_ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3_ISMD.Value.ToString());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (m3_VOM3.HasValue)
				request.WithQueryParameter("VOM3", m3_VOM3.Value.ToString());
			if (m3_FRCP.HasValue)
				request.WithQueryParameter("FRCP", m3_FRCP.Value.ToString());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (m3_AMKO.HasValue)
				request.WithQueryParameter("AMKO", m3_AMKO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LODO))
				request.WithQueryParameter("LODO", m3_LODO.Trim());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<AddWOPickResponse>(
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
		/// Name AddWhsHead
		/// Description Add Warehouse Integration Header
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_QLFR">Qualifier (Required)</param>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E0PB">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_E0IO">Message direction</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_CHGD">Date changed</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_TRSL">Lowest status - stock transaction</param>
		/// <param name="m3_TRSH">Highest status - stock transaction</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_ADTY">Internal address type</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_E0QA">Code list qualifier</param>
		/// <param name="m3_E0QB">Code list qualifier</param>
		/// <param name="m3_DONR">Document number</param>
		/// <param name="m3_E007">Qualifier</param>
		/// <param name="m3_E014">Routing address</param>
		/// <param name="m3_E026">Application reference</param>
		/// <param name="m3_E035">Test indicator</param>
		/// <param name="m3_E052">Message version</param>
		/// <param name="m3_E054">Message release</param>
		/// <param name="m3_E051">Controlling organization</param>
		/// <param name="m3_E057">Organization assigned code</param>
		/// <param name="m3_DLSP">Delivery specification</param>
		/// <param name="m3_EDFR">EDI reference</param>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDO">Order operation</param>
		/// <param name="m3_RIDI">Order index</param>
		/// <param name="m3_PLSX">Picking list suffix</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_DNDT">Delivery note date</param>
		/// <param name="m3_PUSN">Delivery note reference</param>
		/// <param name="m3_GRWE">Gross weight</param>
		/// <param name="m3_VOL3">Volume</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_SUTY">Supplier type</param>
		/// <param name="m3_SORN">Supplier order number</param>
		/// <param name="m3_DPNR">Delivery schedule</param>
		/// <param name="m3_RSAG">Delivery contract number</param>
		/// <param name="m3_DLDT">Planned delivery date</param>
		/// <param name="m3_DLTM">Time of delivery</param>
		/// <param name="m3_SHD4">Actual ship date</param>
		/// <param name="m3_SHTM">Actual ship time</param>
		/// <param name="m3_RCDT">Last receipt date</param>
		/// <param name="m3_RCTM">Last receipt time</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_E0B4">Transport identity - departure</param>
		/// <param name="m3_E0BH">Trailer registration number</param>
		/// <param name="m3_E0B5">Transport nationality - departure</param>
		/// <param name="m3_TEDL">Delivery terms</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_TFNO">Facsimile transmission number</param>
		/// <param name="m3_VRNO">VAT registration number</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_DTID">Data identity</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_RGDT">Not used</param>
		/// <param name="m3_RGTM">Not used</param>
		/// <param name="m3_LMDT">Not used</param>
		/// <param name="m3_CHNO">Not used</param>
		/// <param name="m3_CHID">Not used</param>
		/// <param name="m3_DNTM">Delivery note time</param>
		/// <param name="m3_TIZO">Time zone</param>
		/// <param name="m3_BOLN">Bill of lading</param>
		/// <param name="m3_FWRF">Forwarding agent reference</param>
		/// <param name="m3_ARDT">Arrival date</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddWhsHeadResponse></returns>
		/// <exception cref="M3Exception<AddWhsHeadResponse>"></exception>
		public async Task<M3Response<AddWhsHeadResponse>> AddWhsHead(
			string m3_WHLO, 
			string m3_QLFR, 
			string m3_E0PA, 
			string m3_E0PB, 
			string m3_E065, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_MSGN = null, 
			string m3_E0IO = null, 
			string m3_FACI = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			DateTime? m3_CHGD = null, 
			string m3_STAT = null, 
			string m3_TRSL = null, 
			string m3_TRSH = null, 
			string m3_ADID = null, 
			int? m3_ADTY = null, 
			string m3_PMSN = null, 
			string m3_E0QA = null, 
			string m3_E0QB = null, 
			string m3_DONR = null, 
			string m3_E007 = null, 
			string m3_E014 = null, 
			string m3_E026 = null, 
			int? m3_E035 = null, 
			string m3_E052 = null, 
			string m3_E054 = null, 
			string m3_E051 = null, 
			string m3_E057 = null, 
			string m3_DLSP = null, 
			string m3_EDFR = null, 
			string m3_ORCA = null, 
			string m3_RIDN = null, 
			int? m3_RIDO = null, 
			decimal? m3_RIDI = null, 
			int? m3_PLSX = null, 
			string m3_CUNO = null, 
			string m3_CUOR = null, 
			string m3_SUDO = null, 
			DateTime? m3_DNDT = null, 
			string m3_PUSN = null, 
			decimal? m3_GRWE = null, 
			decimal? m3_VOL3 = null, 
			string m3_SUNO = null, 
			int? m3_SUTY = null, 
			string m3_SORN = null, 
			string m3_DPNR = null, 
			string m3_RSAG = null, 
			DateTime? m3_DLDT = null, 
			int? m3_DLTM = null, 
			DateTime? m3_SHD4 = null, 
			int? m3_SHTM = null, 
			DateTime? m3_RCDT = null, 
			int? m3_RCTM = null, 
			string m3_MODL = null, 
			string m3_E0B4 = null, 
			string m3_E0BH = null, 
			string m3_E0B5 = null, 
			string m3_TEDL = null, 
			string m3_YREF = null, 
			string m3_TFNO = null, 
			string m3_VRNO = null, 
			string m3_RESP = null, 
			decimal? m3_DTID = null, 
			decimal? m3_TXID = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			DateTime? m3_RGDT = null, 
			int? m3_RGTM = null, 
			DateTime? m3_LMDT = null, 
			int? m3_CHNO = null, 
			string m3_CHID = null, 
			int? m3_DNTM = null, 
			string m3_TIZO = null, 
			string m3_BOLN = null, 
			string m3_FWRF = null, 
			DateTime? m3_ARDT = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddWhsHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_QLFR))
				throw new ArgumentNullException("m3_QLFR");
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E0PB))
				throw new ArgumentNullException("m3_E0PB");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("QLFR", m3_QLFR.Trim())
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E0PB", m3_E0PB.Trim())
				.WithQueryParameter("E065", m3_E065.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0IO))
				request.WithQueryParameter("E0IO", m3_E0IO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (m3_CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3_CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRSL))
				request.WithQueryParameter("TRSL", m3_TRSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRSH))
				request.WithQueryParameter("TRSH", m3_TRSH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (m3_ADTY.HasValue)
				request.WithQueryParameter("ADTY", m3_ADTY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0QA))
				request.WithQueryParameter("E0QA", m3_E0QA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0QB))
				request.WithQueryParameter("E0QB", m3_E0QB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DONR))
				request.WithQueryParameter("DONR", m3_DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E007))
				request.WithQueryParameter("E007", m3_E007.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E014))
				request.WithQueryParameter("E014", m3_E014.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E026))
				request.WithQueryParameter("E026", m3_E026.Trim());
			if (m3_E035.HasValue)
				request.WithQueryParameter("E035", m3_E035.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_E052))
				request.WithQueryParameter("E052", m3_E052.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E054))
				request.WithQueryParameter("E054", m3_E054.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E051))
				request.WithQueryParameter("E051", m3_E051.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E057))
				request.WithQueryParameter("E057", m3_E057.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLSP))
				request.WithQueryParameter("DLSP", m3_DLSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDFR))
				request.WithQueryParameter("EDFR", m3_EDFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDO.HasValue)
				request.WithQueryParameter("RIDO", m3_RIDO.Value.ToString());
			if (m3_RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3_RIDI.Value.ToString());
			if (m3_PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3_PLSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (m3_DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3_DNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PUSN))
				request.WithQueryParameter("PUSN", m3_PUSN.Trim());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (m3_VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3_VOL3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_SUTY.HasValue)
				request.WithQueryParameter("SUTY", m3_SUTY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SORN))
				request.WithQueryParameter("SORN", m3_SORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DPNR))
				request.WithQueryParameter("DPNR", m3_DPNR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSAG))
				request.WithQueryParameter("RSAG", m3_RSAG.Trim());
			if (m3_DLDT.HasValue)
				request.WithQueryParameter("DLDT", m3_DLDT.Value.ToM3String());
			if (m3_DLTM.HasValue)
				request.WithQueryParameter("DLTM", m3_DLTM.Value.ToString());
			if (m3_SHD4.HasValue)
				request.WithQueryParameter("SHD4", m3_SHD4.Value.ToM3String());
			if (m3_SHTM.HasValue)
				request.WithQueryParameter("SHTM", m3_SHTM.Value.ToString());
			if (m3_RCDT.HasValue)
				request.WithQueryParameter("RCDT", m3_RCDT.Value.ToM3String());
			if (m3_RCTM.HasValue)
				request.WithQueryParameter("RCTM", m3_RCTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0B4))
				request.WithQueryParameter("E0B4", m3_E0B4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0BH))
				request.WithQueryParameter("E0BH", m3_E0BH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0B5))
				request.WithQueryParameter("E0B5", m3_E0B5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VRNO))
				request.WithQueryParameter("VRNO", m3_VRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_DTID.HasValue)
				request.WithQueryParameter("DTID", m3_DTID.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3_RGTM.Value.ToString());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());
			if (m3_CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3_CHNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());
			if (m3_DNTM.HasValue)
				request.WithQueryParameter("DNTM", m3_DNTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TIZO))
				request.WithQueryParameter("TIZO", m3_TIZO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BOLN))
				request.WithQueryParameter("BOLN", m3_BOLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FWRF))
				request.WithQueryParameter("FWRF", m3_FWRF.Trim());
			if (m3_ARDT.HasValue)
				request.WithQueryParameter("ARDT", m3_ARDT.Value.ToM3String());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<AddWhsHeadResponse>(
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
		/// Name AddWhsLine
		/// Description Add Warehouse Integration Line
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_PACN">Package number (Required)</param>
		/// <param name="m3_QLFR">Qualifier (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_QLFS">Sequence number</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_CHGD">Date changed</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_RELI">Line number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_DLQT">Delivered quantity - basic U/M</param>
		/// <param name="m3_UNIT">Unit of measure</param>
		/// <param name="m3_DLQA">Delivered quantity - alternate U/M</param>
		/// <param name="m3_ALUN">Alternate U/M</param>
		/// <param name="m3_VOL3">Volume</param>
		/// <param name="m3_NEWE">Net weight</param>
		/// <param name="m3_GRWE">Gross weight</param>
		/// <param name="m3_D1QT">Standard quantity</param>
		/// <param name="m3_DLSP">Delivery specification</param>
		/// <param name="m3_RVQA">Received quantity</param>
		/// <param name="m3_PUUN">Purchase order U/M</param>
		/// <param name="m3_ALQT">Allocated quantity - basic U/M</param>
		/// <param name="m3_PAQT">Packed quantity</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_POCY">Normal potency</param>
		/// <param name="m3_OEND">Flagged as completed</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_FLOC">From picking location</param>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="m3_TTYP">Stock transaction type</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDO">Order operation</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_RIDI">Order index</param>
		/// <param name="m3_PLSX">Picking list suffix</param>
		/// <param name="m3_DLIX">Delivery index</param>
		/// <param name="m3_DNNO">Delivery note number</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_SUTY">Supplier type</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_DNDT">Delivery note date</param>
		/// <param name="m3_SITE">Supplier item number</param>
		/// <param name="m3_SITD">Supplier item name</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_PPUN">Purchase price U/M</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_PUCD">Purchase price quantity</param>
		/// <param name="m3_LNAM">Line amount - order currency</param>
		/// <param name="m3_VTCD">VAT code</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_DTID">Data identity</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">Reporting time</param>
		/// <param name="m3_RGDT">Not used</param>
		/// <param name="m3_RGTM">Not used</param>
		/// <param name="m3_LMDT">Not used</param>
		/// <param name="m3_CHNO">Not used</param>
		/// <param name="m3_CHID">Not used</param>
		/// <param name="m3_QCRA">Quality inspection result</param>
		/// <param name="m3_SCRE">Rejection reason</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_EXPI">Expiration date</param>
		/// <param name="m3_CNDT">Follow-up date</param>
		/// <param name="m3_SEDT">Sales date</param>
		/// <param name="m3_TRTP">Order type</param>
		/// <param name="m3_PLRN">Reporting number - pick line</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="m3_ISMD">Issue/move mode</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_MFDT">Manufacturing date</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddWhsLineResponse></returns>
		/// <exception cref="M3Exception<AddWhsLineResponse>"></exception>
		public async Task<M3Response<AddWhsLineResponse>> AddWhsLine(
			string m3_WHLO, 
			string m3_MSGN, 
			string m3_PACN, 
			string m3_QLFR, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			int? m3_MSLN = null, 
			int? m3_QLFS = null, 
			string m3_FACI = null, 
			DateTime? m3_CHGD = null, 
			string m3_STAT = null, 
			string m3_ITNO = null, 
			string m3_ITDS = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			long? m3_REPN = null, 
			int? m3_RELI = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			decimal? m3_DLQT = null, 
			string m3_UNIT = null, 
			decimal? m3_DLQA = null, 
			string m3_ALUN = null, 
			decimal? m3_VOL3 = null, 
			decimal? m3_NEWE = null, 
			decimal? m3_GRWE = null, 
			decimal? m3_D1QT = null, 
			string m3_DLSP = null, 
			decimal? m3_RVQA = null, 
			string m3_PUUN = null, 
			decimal? m3_ALQT = null, 
			decimal? m3_PAQT = null, 
			decimal? m3_CAWE = null, 
			int? m3_POCY = null, 
			int? m3_OEND = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			string m3_FLOC = null, 
			string m3_ORCA = null, 
			int? m3_TTYP = null, 
			string m3_RIDN = null, 
			int? m3_RIDO = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
			decimal? m3_RIDI = null, 
			int? m3_PLSX = null, 
			decimal? m3_DLIX = null, 
			string m3_DNNO = null, 
			string m3_CUOR = null, 
			string m3_CUNO = null, 
			string m3_ADID = null, 
			string m3_SUNO = null, 
			int? m3_SUTY = null, 
			string m3_SUDO = null, 
			DateTime? m3_DNDT = null, 
			string m3_SITE = null, 
			string m3_SITD = null, 
			decimal? m3_PUPR = null, 
			string m3_PPUN = null, 
			string m3_CUCD = null, 
			int? m3_PUCD = null, 
			decimal? m3_LNAM = null, 
			int? m3_VTCD = null, 
			string m3_AGNB = null, 
			string m3_RESP = null, 
			decimal? m3_DTID = null, 
			decimal? m3_TXID = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			DateTime? m3_RGDT = null, 
			int? m3_RGTM = null, 
			DateTime? m3_LMDT = null, 
			int? m3_CHNO = null, 
			string m3_CHID = null, 
			string m3_QCRA = null, 
			string m3_SCRE = null, 
			string m3_BREM = null, 
			DateTime? m3_EXPI = null, 
			DateTime? m3_CNDT = null, 
			DateTime? m3_SEDT = null, 
			string m3_TRTP = null, 
			decimal? m3_PLRN = null, 
			DateTime? m3_RPDT = null, 
			string m3_TWSL = null, 
			int? m3_ISMD = null, 
			string m3_RSCD = null, 
			DateTime? m3_MFDT = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddWhsLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");
			if (string.IsNullOrWhiteSpace(m3_PACN))
				throw new ArgumentNullException("m3_PACN");
			if (string.IsNullOrWhiteSpace(m3_QLFR))
				throw new ArgumentNullException("m3_QLFR");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("MSGN", m3_MSGN.Trim())
				.WithQueryParameter("PACN", m3_PACN.Trim())
				.WithQueryParameter("QLFR", m3_QLFR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (m3_QLFS.HasValue)
				request.WithQueryParameter("QLFS", m3_QLFS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (m3_CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3_CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (m3_RELI.HasValue)
				request.WithQueryParameter("RELI", m3_RELI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (m3_DLQT.HasValue)
				request.WithQueryParameter("DLQT", m3_DLQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNIT))
				request.WithQueryParameter("UNIT", m3_UNIT.Trim());
			if (m3_DLQA.HasValue)
				request.WithQueryParameter("DLQA", m3_DLQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());
			if (m3_VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3_VOL3.Value.ToString());
			if (m3_NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3_NEWE.Value.ToString());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (m3_D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3_D1QT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DLSP))
				request.WithQueryParameter("DLSP", m3_DLSP.Trim());
			if (m3_RVQA.HasValue)
				request.WithQueryParameter("RVQA", m3_RVQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PUUN))
				request.WithQueryParameter("PUUN", m3_PUUN.Trim());
			if (m3_ALQT.HasValue)
				request.WithQueryParameter("ALQT", m3_ALQT.Value.ToString());
			if (m3_PAQT.HasValue)
				request.WithQueryParameter("PAQT", m3_PAQT.Value.ToString());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (m3_POCY.HasValue)
				request.WithQueryParameter("POCY", m3_POCY.Value.ToString());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLOC))
				request.WithQueryParameter("FLOC", m3_FLOC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());
			if (m3_TTYP.HasValue)
				request.WithQueryParameter("TTYP", m3_TTYP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDO.HasValue)
				request.WithQueryParameter("RIDO", m3_RIDO.Value.ToString());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (m3_RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3_RIDI.Value.ToString());
			if (m3_PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3_PLSX.Value.ToString());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DNNO))
				request.WithQueryParameter("DNNO", m3_DNNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_SUTY.HasValue)
				request.WithQueryParameter("SUTY", m3_SUTY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (m3_DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3_DNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_SITE))
				request.WithQueryParameter("SITE", m3_SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SITD))
				request.WithQueryParameter("SITD", m3_SITD.Trim());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PPUN))
				request.WithQueryParameter("PPUN", m3_PPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3_PUCD.Value.ToString());
			if (m3_LNAM.HasValue)
				request.WithQueryParameter("LNAM", m3_LNAM.Value.ToString());
			if (m3_VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3_VTCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_DTID.HasValue)
				request.WithQueryParameter("DTID", m3_DTID.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3_RGTM.Value.ToString());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());
			if (m3_CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3_CHNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QCRA))
				request.WithQueryParameter("QCRA", m3_QCRA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCRE))
				request.WithQueryParameter("SCRE", m3_SCRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (m3_EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3_EXPI.Value.ToM3String());
			if (m3_CNDT.HasValue)
				request.WithQueryParameter("CNDT", m3_CNDT.Value.ToM3String());
			if (m3_SEDT.HasValue)
				request.WithQueryParameter("SEDT", m3_SEDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TRTP))
				request.WithQueryParameter("TRTP", m3_TRTP.Trim());
			if (m3_PLRN.HasValue)
				request.WithQueryParameter("PLRN", m3_PLRN.Value.ToString());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (m3_ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3_ISMD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (m3_MFDT.HasValue)
				request.WithQueryParameter("MFDT", m3_MFDT.Value.ToM3String());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<AddWhsLineResponse>(
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
		/// Name AddWhsPack
		/// Description Add Warehouse Integration Package
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_QLFR">Qualifier (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_CHGD">Date changed</param>
		/// <param name="m3_PARE">Package reference</param>
		/// <param name="m3_DIPA">Disconnected package</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_DNNO">Delivery note number</param>
		/// <param name="m3_DNDT">Delivery note date</param>
		/// <param name="m3_TRSH">Highest status - stock transaction</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_TRSL">Lowest status - stock transaction</param>
		/// <param name="m3_PACO">Package level</param>
		/// <param name="m3_PACU">Bulk package</param>
		/// <param name="m3_PACC">Included in package number</param>
		/// <param name="m3_AMKO">Number of packages</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_PACK">Package type</param>
		/// <param name="m3_TEPA">Packaging terms</param>
		/// <param name="m3_SORT">Sort value</param>
		/// <param name="m3_DLRM">Remark</param>
		/// <param name="m3_DLMO">Goods mark Odette standard</param>
		/// <param name="m3_DLSP">Delivery specification</param>
		/// <param name="m3_VOM3">Volume</param>
		/// <param name="m3_NEWE">Net weight</param>
		/// <param name="m3_GRWE">Gross weight</param>
		/// <param name="m3_GRW3">Included gross weight</param>
		/// <param name="m3_GRW4">Manual gross weight</param>
		/// <param name="m3_GRW5">Included net weight</param>
		/// <param name="m3_D1QT">Standard quantity</param>
		/// <param name="m3_VOMT">Weight</param>
		/// <param name="m3_PACL">Package length</param>
		/// <param name="m3_PACW">Package width</param>
		/// <param name="m3_PACH">Package height</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_SUTY">Supplier type</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_DTID">Data identity</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_RGDT">Not used!</param>
		/// <param name="m3_RGTM">Not used!</param>
		/// <param name="m3_LMDT">Not used!</param>
		/// <param name="m3_CHNO">Not used!</param>
		/// <param name="m3_CHID">Not used!</param>
		/// <param name="m3_ROUT">Route</param>
		/// <param name="m3_RODN">Route departure</param>
		/// <param name="m3_CONN">Shipment</param>
		/// <param name="m3_DSDT">Departure date</param>
		/// <param name="m3_DSHM">Departure time</param>
		/// <param name="m3_CDEL">Changed delivery</param>
		/// <param name="m3_NDLX">New delivery number</param>
		/// <param name="m3_FRCP">Capacity - free capacity unit</param>
		/// <param name="m3_PPNB">Pre-pack number</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddWhsPackResponse></returns>
		/// <exception cref="M3Exception<AddWhsPackResponse>"></exception>
		public async Task<M3Response<AddWhsPackResponse>> AddWhsPack(
			string m3_WHLO, 
			string m3_MSGN, 
			string m3_QLFR, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_PACN = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			DateTime? m3_CHGD = null, 
			string m3_PARE = null, 
			int? m3_DIPA = null, 
			string m3_SUDO = null, 
			string m3_DNNO = null, 
			DateTime? m3_DNDT = null, 
			string m3_TRSH = null, 
			string m3_STAT = null, 
			string m3_TRSL = null, 
			int? m3_PACO = null, 
			int? m3_PACU = null, 
			string m3_PACC = null, 
			int? m3_AMKO = null, 
			string m3_PACT = null, 
			string m3_PACK = null, 
			string m3_TEPA = null, 
			string m3_SORT = null, 
			string m3_DLRM = null, 
			string m3_DLMO = null, 
			string m3_DLSP = null, 
			decimal? m3_VOM3 = null, 
			decimal? m3_NEWE = null, 
			decimal? m3_GRWE = null, 
			decimal? m3_GRW3 = null, 
			decimal? m3_GRW4 = null, 
			decimal? m3_GRW5 = null, 
			decimal? m3_D1QT = null, 
			decimal? m3_VOMT = null, 
			int? m3_PACL = null, 
			int? m3_PACW = null, 
			int? m3_PACH = null, 
			string m3_SSCC = null, 
			string m3_WHSL = null, 
			string m3_CUNO = null, 
			string m3_ADID = null, 
			int? m3_SUTY = null, 
			string m3_SUNO = null, 
			string m3_RESP = null, 
			decimal? m3_DTID = null, 
			decimal? m3_TXID = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			DateTime? m3_RGDT = null, 
			int? m3_RGTM = null, 
			DateTime? m3_LMDT = null, 
			int? m3_CHNO = null, 
			string m3_CHID = null, 
			string m3_ROUT = null, 
			int? m3_RODN = null, 
			int? m3_CONN = null, 
			DateTime? m3_DSDT = null, 
			int? m3_DSHM = null, 
			int? m3_CDEL = null, 
			decimal? m3_NDLX = null, 
			decimal? m3_FRCP = null, 
			string m3_PPNB = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddWhsPack",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");
			if (string.IsNullOrWhiteSpace(m3_QLFR))
				throw new ArgumentNullException("m3_QLFR");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("MSGN", m3_MSGN.Trim())
				.WithQueryParameter("QLFR", m3_QLFR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (m3_CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3_CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PARE))
				request.WithQueryParameter("PARE", m3_PARE.Trim());
			if (m3_DIPA.HasValue)
				request.WithQueryParameter("DIPA", m3_DIPA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DNNO))
				request.WithQueryParameter("DNNO", m3_DNNO.Trim());
			if (m3_DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3_DNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TRSH))
				request.WithQueryParameter("TRSH", m3_TRSH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRSL))
				request.WithQueryParameter("TRSL", m3_TRSL.Trim());
			if (m3_PACO.HasValue)
				request.WithQueryParameter("PACO", m3_PACO.Value.ToString());
			if (m3_PACU.HasValue)
				request.WithQueryParameter("PACU", m3_PACU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACC))
				request.WithQueryParameter("PACC", m3_PACC.Trim());
			if (m3_AMKO.HasValue)
				request.WithQueryParameter("AMKO", m3_AMKO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACK))
				request.WithQueryParameter("PACK", m3_PACK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SORT))
				request.WithQueryParameter("SORT", m3_SORT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLRM))
				request.WithQueryParameter("DLRM", m3_DLRM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLMO))
				request.WithQueryParameter("DLMO", m3_DLMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLSP))
				request.WithQueryParameter("DLSP", m3_DLSP.Trim());
			if (m3_VOM3.HasValue)
				request.WithQueryParameter("VOM3", m3_VOM3.Value.ToString());
			if (m3_NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3_NEWE.Value.ToString());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (m3_GRW3.HasValue)
				request.WithQueryParameter("GRW3", m3_GRW3.Value.ToString());
			if (m3_GRW4.HasValue)
				request.WithQueryParameter("GRW4", m3_GRW4.Value.ToString());
			if (m3_GRW5.HasValue)
				request.WithQueryParameter("GRW5", m3_GRW5.Value.ToString());
			if (m3_D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3_D1QT.Value.ToString());
			if (m3_VOMT.HasValue)
				request.WithQueryParameter("VOMT", m3_VOMT.Value.ToString());
			if (m3_PACL.HasValue)
				request.WithQueryParameter("PACL", m3_PACL.Value.ToString());
			if (m3_PACW.HasValue)
				request.WithQueryParameter("PACW", m3_PACW.Value.ToString());
			if (m3_PACH.HasValue)
				request.WithQueryParameter("PACH", m3_PACH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (m3_SUTY.HasValue)
				request.WithQueryParameter("SUTY", m3_SUTY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_DTID.HasValue)
				request.WithQueryParameter("DTID", m3_DTID.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3_RGTM.Value.ToString());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());
			if (m3_CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3_CHNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ROUT))
				request.WithQueryParameter("ROUT", m3_ROUT.Trim());
			if (m3_RODN.HasValue)
				request.WithQueryParameter("RODN", m3_RODN.Value.ToString());
			if (m3_CONN.HasValue)
				request.WithQueryParameter("CONN", m3_CONN.Value.ToString());
			if (m3_DSDT.HasValue)
				request.WithQueryParameter("DSDT", m3_DSDT.Value.ToM3String());
			if (m3_DSHM.HasValue)
				request.WithQueryParameter("DSHM", m3_DSHM.Value.ToString());
			if (m3_CDEL.HasValue)
				request.WithQueryParameter("CDEL", m3_CDEL.Value.ToString());
			if (m3_NDLX.HasValue)
				request.WithQueryParameter("NDLX", m3_NDLX.Value.ToString());
			if (m3_FRCP.HasValue)
				request.WithQueryParameter("FRCP", m3_FRCP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PPNB))
				request.WithQueryParameter("PPNB", m3_PPNB.Trim());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<AddWhsPackResponse>(
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
		/// Name ChgSubLine
		/// Description ChgSubLine
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_PACN">Package number (Required)</param>
		/// <param name="m3_MSLN">Message line number (Required)</param>
		/// <param name="m3_SUBL">Subline number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_QLFR">Qualifier</param>
		/// <param name="m3_BANT">Reference sublot ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgSubLine(
			string m3_MSGN, 
			string m3_PACN, 
			int m3_MSLN, 
			int m3_SUBL, 
			int? m3_CONO = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			decimal? m3_CAWE = null, 
			string m3_QLFR = null, 
			string m3_BANT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgSubLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");
			if (string.IsNullOrWhiteSpace(m3_PACN))
				throw new ArgumentNullException("m3_PACN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim())
				.WithQueryParameter("PACN", m3_PACN.Trim())
				.WithQueryParameter("MSLN", m3_MSLN.ToString())
				.WithQueryParameter("SUBL", m3_SUBL.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QLFR))
				request.WithQueryParameter("QLFR", m3_QLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANT))
				request.WithQueryParameter("BANT", m3_BANT.Trim());

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
		/// Name ChgWhsHead
		/// Description Change Warehouse Integration Header
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_E0IO">Message direction</param>
		/// <param name="m3_QLFR">Qualifier</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_CHGD">Date changed</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_TRSL">Lowest status - stock transaction</param>
		/// <param name="m3_TRSH">Highest status - stock transaction</param>
		/// <param name="m3_ADTY">Internal address type</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_E0PA">Partner</param>
		/// <param name="m3_E0QA">Code list qualifier</param>
		/// <param name="m3_E0PB">Partner</param>
		/// <param name="m3_E0QB">Code list qualifier</param>
		/// <param name="m3_DONR">Document number</param>
		/// <param name="m3_E007">Qualifier</param>
		/// <param name="m3_E014">Routing address</param>
		/// <param name="m3_E026">Application reference</param>
		/// <param name="m3_E035">Test indicator</param>
		/// <param name="m3_E065">Message type</param>
		/// <param name="m3_E052">Message version</param>
		/// <param name="m3_E054">Message release</param>
		/// <param name="m3_E051">Controlling organization</param>
		/// <param name="m3_E057">Organization assigned code</param>
		/// <param name="m3_DLSP">Delivery specification</param>
		/// <param name="m3_EDFR">EDI reference</param>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDO">Order operation</param>
		/// <param name="m3_RIDI">Order index</param>
		/// <param name="m3_PLSX">Picking list suffix</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_DNDT">Delivery note date</param>
		/// <param name="m3_PUSN">Delivery note reference</param>
		/// <param name="m3_GRWE">Gross weight</param>
		/// <param name="m3_VOL3">Volume</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_SUTY">Supplier type</param>
		/// <param name="m3_SORN">Supplier order number</param>
		/// <param name="m3_DPNR">Delivery schedule</param>
		/// <param name="m3_RSAG">Delivery contract number</param>
		/// <param name="m3_DLDT">Planned delivery date</param>
		/// <param name="m3_DLTM">Time of delivery</param>
		/// <param name="m3_SHD4">Actual ship date</param>
		/// <param name="m3_SHTM">Actual ship time</param>
		/// <param name="m3_RCDT">Last receipt date</param>
		/// <param name="m3_RCTM">Last receipt time</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_E0B4">Transport identity - departure</param>
		/// <param name="m3_E0BH">Trailer registration number</param>
		/// <param name="m3_E0B5">Transport nationality - departure</param>
		/// <param name="m3_TEDL">Delivery terms</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_TFNO">Facsimile transmission number</param>
		/// <param name="m3_VRNO">VAT registration number</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_DTID">Data identity</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_RGDT">Not used!</param>
		/// <param name="m3_RGTM">Not used!</param>
		/// <param name="m3_LMDT">Not used!</param>
		/// <param name="m3_CHNO">Not used!</param>
		/// <param name="m3_CHID">Not used!</param>
		/// <param name="m3_DNTM">Delivery note time</param>
		/// <param name="m3_BOLN">Bill of lading</param>
		/// <param name="m3_FWRF">Forwarding agent reference</param>
		/// <param name="m3_ARDT">Arrival date</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgWhsHead(
			string m3_MSGN, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_WHLO = null, 
			string m3_E0IO = null, 
			string m3_QLFR = null, 
			string m3_FACI = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			DateTime? m3_CHGD = null, 
			string m3_STAT = null, 
			string m3_TRSL = null, 
			string m3_TRSH = null, 
			int? m3_ADTY = null, 
			string m3_ADID = null, 
			string m3_PMSN = null, 
			string m3_E0PA = null, 
			string m3_E0QA = null, 
			string m3_E0PB = null, 
			string m3_E0QB = null, 
			string m3_DONR = null, 
			string m3_E007 = null, 
			string m3_E014 = null, 
			string m3_E026 = null, 
			int? m3_E035 = null, 
			string m3_E065 = null, 
			string m3_E052 = null, 
			string m3_E054 = null, 
			string m3_E051 = null, 
			string m3_E057 = null, 
			string m3_DLSP = null, 
			string m3_EDFR = null, 
			string m3_ORCA = null, 
			string m3_RIDN = null, 
			int? m3_RIDO = null, 
			decimal? m3_RIDI = null, 
			int? m3_PLSX = null, 
			string m3_CUNO = null, 
			string m3_CUOR = null, 
			string m3_SUDO = null, 
			DateTime? m3_DNDT = null, 
			string m3_PUSN = null, 
			decimal? m3_GRWE = null, 
			decimal? m3_VOL3 = null, 
			string m3_SUNO = null, 
			int? m3_SUTY = null, 
			string m3_SORN = null, 
			string m3_DPNR = null, 
			string m3_RSAG = null, 
			DateTime? m3_DLDT = null, 
			int? m3_DLTM = null, 
			DateTime? m3_SHD4 = null, 
			int? m3_SHTM = null, 
			DateTime? m3_RCDT = null, 
			int? m3_RCTM = null, 
			string m3_MODL = null, 
			string m3_E0B4 = null, 
			string m3_E0BH = null, 
			string m3_E0B5 = null, 
			string m3_TEDL = null, 
			string m3_YREF = null, 
			string m3_TFNO = null, 
			string m3_VRNO = null, 
			string m3_RESP = null, 
			decimal? m3_DTID = null, 
			decimal? m3_TXID = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			DateTime? m3_RGDT = null, 
			int? m3_RGTM = null, 
			DateTime? m3_LMDT = null, 
			int? m3_CHNO = null, 
			string m3_CHID = null, 
			int? m3_DNTM = null, 
			string m3_BOLN = null, 
			string m3_FWRF = null, 
			DateTime? m3_ARDT = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgWhsHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0IO))
				request.WithQueryParameter("E0IO", m3_E0IO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QLFR))
				request.WithQueryParameter("QLFR", m3_QLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (m3_CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3_CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRSL))
				request.WithQueryParameter("TRSL", m3_TRSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRSH))
				request.WithQueryParameter("TRSH", m3_TRSH.Trim());
			if (m3_ADTY.HasValue)
				request.WithQueryParameter("ADTY", m3_ADTY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0PA))
				request.WithQueryParameter("E0PA", m3_E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0QA))
				request.WithQueryParameter("E0QA", m3_E0QA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0PB))
				request.WithQueryParameter("E0PB", m3_E0PB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0QB))
				request.WithQueryParameter("E0QB", m3_E0QB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DONR))
				request.WithQueryParameter("DONR", m3_DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E007))
				request.WithQueryParameter("E007", m3_E007.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E014))
				request.WithQueryParameter("E014", m3_E014.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E026))
				request.WithQueryParameter("E026", m3_E026.Trim());
			if (m3_E035.HasValue)
				request.WithQueryParameter("E035", m3_E035.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_E065))
				request.WithQueryParameter("E065", m3_E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E052))
				request.WithQueryParameter("E052", m3_E052.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E054))
				request.WithQueryParameter("E054", m3_E054.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E051))
				request.WithQueryParameter("E051", m3_E051.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E057))
				request.WithQueryParameter("E057", m3_E057.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLSP))
				request.WithQueryParameter("DLSP", m3_DLSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDFR))
				request.WithQueryParameter("EDFR", m3_EDFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDO.HasValue)
				request.WithQueryParameter("RIDO", m3_RIDO.Value.ToString());
			if (m3_RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3_RIDI.Value.ToString());
			if (m3_PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3_PLSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (m3_DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3_DNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PUSN))
				request.WithQueryParameter("PUSN", m3_PUSN.Trim());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (m3_VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3_VOL3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_SUTY.HasValue)
				request.WithQueryParameter("SUTY", m3_SUTY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SORN))
				request.WithQueryParameter("SORN", m3_SORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DPNR))
				request.WithQueryParameter("DPNR", m3_DPNR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSAG))
				request.WithQueryParameter("RSAG", m3_RSAG.Trim());
			if (m3_DLDT.HasValue)
				request.WithQueryParameter("DLDT", m3_DLDT.Value.ToM3String());
			if (m3_DLTM.HasValue)
				request.WithQueryParameter("DLTM", m3_DLTM.Value.ToString());
			if (m3_SHD4.HasValue)
				request.WithQueryParameter("SHD4", m3_SHD4.Value.ToM3String());
			if (m3_SHTM.HasValue)
				request.WithQueryParameter("SHTM", m3_SHTM.Value.ToString());
			if (m3_RCDT.HasValue)
				request.WithQueryParameter("RCDT", m3_RCDT.Value.ToM3String());
			if (m3_RCTM.HasValue)
				request.WithQueryParameter("RCTM", m3_RCTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0B4))
				request.WithQueryParameter("E0B4", m3_E0B4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0BH))
				request.WithQueryParameter("E0BH", m3_E0BH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0B5))
				request.WithQueryParameter("E0B5", m3_E0B5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VRNO))
				request.WithQueryParameter("VRNO", m3_VRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_DTID.HasValue)
				request.WithQueryParameter("DTID", m3_DTID.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3_RGTM.Value.ToString());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());
			if (m3_CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3_CHNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());
			if (m3_DNTM.HasValue)
				request.WithQueryParameter("DNTM", m3_DNTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BOLN))
				request.WithQueryParameter("BOLN", m3_BOLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FWRF))
				request.WithQueryParameter("FWRF", m3_FWRF.Trim());
			if (m3_ARDT.HasValue)
				request.WithQueryParameter("ARDT", m3_ARDT.Value.ToM3String());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

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
		/// Name ChgWhsLine
		/// Description Change Warehouse Integration Line
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_PACN">Package number (Required)</param>
		/// <param name="m3_MSLN">Message line number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_QLFR">Qualifier</param>
		/// <param name="m3_QLFS">Sequence number</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_CHGD">Date changed</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_RELI">Line number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_DLQT">Delivered quantity - basic U/M</param>
		/// <param name="m3_UNIT">Unit of measure</param>
		/// <param name="m3_DLQA">Delivered quantity - alternate U/M</param>
		/// <param name="m3_ALUN">Alternate U/M</param>
		/// <param name="m3_VOL3">Volume</param>
		/// <param name="m3_NEWE">Net weight</param>
		/// <param name="m3_GRWE">Gross weight</param>
		/// <param name="m3_D1QT">Standard quantity</param>
		/// <param name="m3_DLSP">Delivery specification</param>
		/// <param name="m3_RVQA">Received quantity</param>
		/// <param name="m3_PUUN">Purchase order U/M</param>
		/// <param name="m3_ALQT">Allocated quantity - basic U/M</param>
		/// <param name="m3_PAQT">Packed quantity</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_POCY">Normal potency</param>
		/// <param name="m3_OEND">Flagged as completed</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_FLOC">From picking location</param>
		/// <param name="m3_TTYP">Stock transaction type</param>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDO">Order operation</param>
		/// <param name="m3_PLSX">Picking list suffix</param>
		/// <param name="m3_DLIX">Delivery index</param>
		/// <param name="m3_RIDI">Order index</param>
		/// <param name="m3_DNNO">Delivery note number</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_SUTY">Supplier type</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_DNDT">Delivery note date</param>
		/// <param name="m3_SITE">Supplier item number</param>
		/// <param name="m3_SITD">Supplier item name</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_PPUN">Purchase price U/M</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_PUCD">Purchase price quantity</param>
		/// <param name="m3_LNAM">Line amount - order currency</param>
		/// <param name="m3_VTCD">VAT code</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_DTID">Data identity</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">Reporting time</param>
		/// <param name="m3_RGDT">Not used!</param>
		/// <param name="m3_RGTM">Not used!</param>
		/// <param name="m3_LMDT">Not used!</param>
		/// <param name="m3_CHNO">Not used!</param>
		/// <param name="m3_CHID">Not used!</param>
		/// <param name="m3_QCRA">Quality inspection result</param>
		/// <param name="m3_SCRE">Rejection reason</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_EXPI">Expiration date</param>
		/// <param name="m3_CNDT">Follow-up date</param>
		/// <param name="m3_SEDT">Sales date</param>
		/// <param name="m3_TRTP">Order type</param>
		/// <param name="m3_PLRN">Reporting number - pick line</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_ISMD">Issue/move mode</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_MFDT">Manufacturing date</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgWhsLine(
			string m3_MSGN, 
			string m3_PACN, 
			int m3_MSLN, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_WHLO = null, 
			string m3_QLFR = null, 
			int? m3_QLFS = null, 
			string m3_FACI = null, 
			DateTime? m3_CHGD = null, 
			string m3_STAT = null, 
			string m3_ITNO = null, 
			string m3_ITDS = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			long? m3_REPN = null, 
			int? m3_RELI = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			decimal? m3_DLQT = null, 
			string m3_UNIT = null, 
			decimal? m3_DLQA = null, 
			string m3_ALUN = null, 
			decimal? m3_VOL3 = null, 
			decimal? m3_NEWE = null, 
			decimal? m3_GRWE = null, 
			decimal? m3_D1QT = null, 
			string m3_DLSP = null, 
			decimal? m3_RVQA = null, 
			string m3_PUUN = null, 
			decimal? m3_ALQT = null, 
			decimal? m3_PAQT = null, 
			decimal? m3_CAWE = null, 
			int? m3_POCY = null, 
			int? m3_OEND = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			string m3_FLOC = null, 
			int? m3_TTYP = null, 
			string m3_ORCA = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDO = null, 
			int? m3_PLSX = null, 
			decimal? m3_DLIX = null, 
			decimal? m3_RIDI = null, 
			string m3_DNNO = null, 
			string m3_CUOR = null, 
			string m3_CUNO = null, 
			string m3_ADID = null, 
			string m3_SUNO = null, 
			int? m3_SUTY = null, 
			string m3_SUDO = null, 
			DateTime? m3_DNDT = null, 
			string m3_SITE = null, 
			string m3_SITD = null, 
			decimal? m3_PUPR = null, 
			string m3_PPUN = null, 
			string m3_CUCD = null, 
			int? m3_PUCD = null, 
			decimal? m3_LNAM = null, 
			int? m3_VTCD = null, 
			string m3_AGNB = null, 
			string m3_RESP = null, 
			decimal? m3_DTID = null, 
			decimal? m3_TXID = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			DateTime? m3_RGDT = null, 
			int? m3_RGTM = null, 
			DateTime? m3_LMDT = null, 
			int? m3_CHNO = null, 
			string m3_CHID = null, 
			string m3_QCRA = null, 
			string m3_SCRE = null, 
			string m3_BREM = null, 
			DateTime? m3_EXPI = null, 
			DateTime? m3_CNDT = null, 
			DateTime? m3_SEDT = null, 
			string m3_TRTP = null, 
			decimal? m3_PLRN = null, 
			DateTime? m3_RPDT = null, 
			int? m3_ISMD = null, 
			string m3_TWSL = null, 
			int? m3_RIDX = null, 
			string m3_RSCD = null, 
			DateTime? m3_MFDT = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgWhsLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");
			if (string.IsNullOrWhiteSpace(m3_PACN))
				throw new ArgumentNullException("m3_PACN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim())
				.WithQueryParameter("PACN", m3_PACN.Trim())
				.WithQueryParameter("MSLN", m3_MSLN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QLFR))
				request.WithQueryParameter("QLFR", m3_QLFR.Trim());
			if (m3_QLFS.HasValue)
				request.WithQueryParameter("QLFS", m3_QLFS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (m3_CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3_CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (m3_RELI.HasValue)
				request.WithQueryParameter("RELI", m3_RELI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (m3_DLQT.HasValue)
				request.WithQueryParameter("DLQT", m3_DLQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNIT))
				request.WithQueryParameter("UNIT", m3_UNIT.Trim());
			if (m3_DLQA.HasValue)
				request.WithQueryParameter("DLQA", m3_DLQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());
			if (m3_VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3_VOL3.Value.ToString());
			if (m3_NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3_NEWE.Value.ToString());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (m3_D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3_D1QT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DLSP))
				request.WithQueryParameter("DLSP", m3_DLSP.Trim());
			if (m3_RVQA.HasValue)
				request.WithQueryParameter("RVQA", m3_RVQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PUUN))
				request.WithQueryParameter("PUUN", m3_PUUN.Trim());
			if (m3_ALQT.HasValue)
				request.WithQueryParameter("ALQT", m3_ALQT.Value.ToString());
			if (m3_PAQT.HasValue)
				request.WithQueryParameter("PAQT", m3_PAQT.Value.ToString());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (m3_POCY.HasValue)
				request.WithQueryParameter("POCY", m3_POCY.Value.ToString());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLOC))
				request.WithQueryParameter("FLOC", m3_FLOC.Trim());
			if (m3_TTYP.HasValue)
				request.WithQueryParameter("TTYP", m3_TTYP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDO.HasValue)
				request.WithQueryParameter("RIDO", m3_RIDO.Value.ToString());
			if (m3_PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3_PLSX.Value.ToString());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (m3_RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3_RIDI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DNNO))
				request.WithQueryParameter("DNNO", m3_DNNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_SUTY.HasValue)
				request.WithQueryParameter("SUTY", m3_SUTY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (m3_DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3_DNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_SITE))
				request.WithQueryParameter("SITE", m3_SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SITD))
				request.WithQueryParameter("SITD", m3_SITD.Trim());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PPUN))
				request.WithQueryParameter("PPUN", m3_PPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3_PUCD.Value.ToString());
			if (m3_LNAM.HasValue)
				request.WithQueryParameter("LNAM", m3_LNAM.Value.ToString());
			if (m3_VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3_VTCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_DTID.HasValue)
				request.WithQueryParameter("DTID", m3_DTID.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3_RGTM.Value.ToString());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());
			if (m3_CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3_CHNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QCRA))
				request.WithQueryParameter("QCRA", m3_QCRA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCRE))
				request.WithQueryParameter("SCRE", m3_SCRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (m3_EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3_EXPI.Value.ToM3String());
			if (m3_CNDT.HasValue)
				request.WithQueryParameter("CNDT", m3_CNDT.Value.ToM3String());
			if (m3_SEDT.HasValue)
				request.WithQueryParameter("SEDT", m3_SEDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TRTP))
				request.WithQueryParameter("TRTP", m3_TRTP.Trim());
			if (m3_PLRN.HasValue)
				request.WithQueryParameter("PLRN", m3_PLRN.Value.ToString());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3_ISMD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (m3_MFDT.HasValue)
				request.WithQueryParameter("MFDT", m3_MFDT.Value.ToM3String());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

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
		/// Name ChgWhsPack
		/// Description Change Warehouse Integration Package
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_PACN">Package number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_QLFR">Qualifier</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_CHGD">Date changed</param>
		/// <param name="m3_PARE">Package reference</param>
		/// <param name="m3_DIPA">Disconnected package</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_DNNO">Delivery note number</param>
		/// <param name="m3_DNDT">Delivery note date</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_TRSL">Lowest status - stock transaction</param>
		/// <param name="m3_TRSH">Highest status - stock transaction</param>
		/// <param name="m3_PACO">Package level</param>
		/// <param name="m3_PACU">Bulk package</param>
		/// <param name="m3_PACC">Included in package number</param>
		/// <param name="m3_AMKO">Number of packages</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_PACK">Package type</param>
		/// <param name="m3_TEPA">Packaging terms</param>
		/// <param name="m3_SORT">Sort value</param>
		/// <param name="m3_DLRM">Remark</param>
		/// <param name="m3_DLMO">Goods mark Odette standard</param>
		/// <param name="m3_DLSP">Delivery specification</param>
		/// <param name="m3_VOM3">Volume</param>
		/// <param name="m3_NEWE">Net weight</param>
		/// <param name="m3_GRWE">Gross weight</param>
		/// <param name="m3_GRW3">Included gross weight</param>
		/// <param name="m3_GRW4">Manual gross weight</param>
		/// <param name="m3_GRW5">Included net weight</param>
		/// <param name="m3_D1QT">Standard quantity</param>
		/// <param name="m3_VOMT">Weight</param>
		/// <param name="m3_PACW">Package width</param>
		/// <param name="m3_PACL">Package length</param>
		/// <param name="m3_PACH">Package height</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_SUTY">Supplier type</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_DTID">Data identity</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_RGDT">Not used!</param>
		/// <param name="m3_RGTM">Not used!</param>
		/// <param name="m3_LMDT">Not used!</param>
		/// <param name="m3_CHNO">Not used!</param>
		/// <param name="m3_CHID">Not used!</param>
		/// <param name="m3_ROUT">Route</param>
		/// <param name="m3_RODN">Route departure</param>
		/// <param name="m3_CONN">Shipment</param>
		/// <param name="m3_DSDT">Departure date</param>
		/// <param name="m3_DSHM">Departure time</param>
		/// <param name="m3_CDEL">Changed delivery</param>
		/// <param name="m3_NDLX">New delivery number</param>
		/// <param name="m3_FRCP">Capacity - free capacity unit</param>
		/// <param name="m3_PPNB">Pre-pack number</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgWhsPack(
			string m3_WHLO, 
			string m3_MSGN, 
			string m3_PACN, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_QLFR = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			DateTime? m3_CHGD = null, 
			string m3_PARE = null, 
			int? m3_DIPA = null, 
			string m3_SUDO = null, 
			string m3_DNNO = null, 
			DateTime? m3_DNDT = null, 
			string m3_STAT = null, 
			string m3_TRSL = null, 
			string m3_TRSH = null, 
			int? m3_PACO = null, 
			int? m3_PACU = null, 
			string m3_PACC = null, 
			int? m3_AMKO = null, 
			string m3_PACT = null, 
			string m3_PACK = null, 
			string m3_TEPA = null, 
			string m3_SORT = null, 
			string m3_DLRM = null, 
			string m3_DLMO = null, 
			string m3_DLSP = null, 
			decimal? m3_VOM3 = null, 
			decimal? m3_NEWE = null, 
			decimal? m3_GRWE = null, 
			decimal? m3_GRW3 = null, 
			decimal? m3_GRW4 = null, 
			decimal? m3_GRW5 = null, 
			decimal? m3_D1QT = null, 
			decimal? m3_VOMT = null, 
			int? m3_PACW = null, 
			int? m3_PACL = null, 
			int? m3_PACH = null, 
			string m3_SSCC = null, 
			string m3_WHSL = null, 
			string m3_CUNO = null, 
			string m3_ADID = null, 
			int? m3_SUTY = null, 
			string m3_SUNO = null, 
			string m3_RESP = null, 
			decimal? m3_DTID = null, 
			decimal? m3_TXID = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			DateTime? m3_RGDT = null, 
			int? m3_RGTM = null, 
			DateTime? m3_LMDT = null, 
			int? m3_CHNO = null, 
			string m3_CHID = null, 
			string m3_ROUT = null, 
			int? m3_RODN = null, 
			int? m3_CONN = null, 
			DateTime? m3_DSDT = null, 
			int? m3_DSHM = null, 
			int? m3_CDEL = null, 
			decimal? m3_NDLX = null, 
			decimal? m3_FRCP = null, 
			string m3_PPNB = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgWhsPack",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");
			if (string.IsNullOrWhiteSpace(m3_PACN))
				throw new ArgumentNullException("m3_PACN");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("MSGN", m3_MSGN.Trim())
				.WithQueryParameter("PACN", m3_PACN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QLFR))
				request.WithQueryParameter("QLFR", m3_QLFR.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (m3_CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3_CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PARE))
				request.WithQueryParameter("PARE", m3_PARE.Trim());
			if (m3_DIPA.HasValue)
				request.WithQueryParameter("DIPA", m3_DIPA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DNNO))
				request.WithQueryParameter("DNNO", m3_DNNO.Trim());
			if (m3_DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3_DNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRSL))
				request.WithQueryParameter("TRSL", m3_TRSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRSH))
				request.WithQueryParameter("TRSH", m3_TRSH.Trim());
			if (m3_PACO.HasValue)
				request.WithQueryParameter("PACO", m3_PACO.Value.ToString());
			if (m3_PACU.HasValue)
				request.WithQueryParameter("PACU", m3_PACU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACC))
				request.WithQueryParameter("PACC", m3_PACC.Trim());
			if (m3_AMKO.HasValue)
				request.WithQueryParameter("AMKO", m3_AMKO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACK))
				request.WithQueryParameter("PACK", m3_PACK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SORT))
				request.WithQueryParameter("SORT", m3_SORT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLRM))
				request.WithQueryParameter("DLRM", m3_DLRM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLMO))
				request.WithQueryParameter("DLMO", m3_DLMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLSP))
				request.WithQueryParameter("DLSP", m3_DLSP.Trim());
			if (m3_VOM3.HasValue)
				request.WithQueryParameter("VOM3", m3_VOM3.Value.ToString());
			if (m3_NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3_NEWE.Value.ToString());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (m3_GRW3.HasValue)
				request.WithQueryParameter("GRW3", m3_GRW3.Value.ToString());
			if (m3_GRW4.HasValue)
				request.WithQueryParameter("GRW4", m3_GRW4.Value.ToString());
			if (m3_GRW5.HasValue)
				request.WithQueryParameter("GRW5", m3_GRW5.Value.ToString());
			if (m3_D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3_D1QT.Value.ToString());
			if (m3_VOMT.HasValue)
				request.WithQueryParameter("VOMT", m3_VOMT.Value.ToString());
			if (m3_PACW.HasValue)
				request.WithQueryParameter("PACW", m3_PACW.Value.ToString());
			if (m3_PACL.HasValue)
				request.WithQueryParameter("PACL", m3_PACL.Value.ToString());
			if (m3_PACH.HasValue)
				request.WithQueryParameter("PACH", m3_PACH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (m3_SUTY.HasValue)
				request.WithQueryParameter("SUTY", m3_SUTY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_DTID.HasValue)
				request.WithQueryParameter("DTID", m3_DTID.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3_RGTM.Value.ToString());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());
			if (m3_CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3_CHNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ROUT))
				request.WithQueryParameter("ROUT", m3_ROUT.Trim());
			if (m3_RODN.HasValue)
				request.WithQueryParameter("RODN", m3_RODN.Value.ToString());
			if (m3_CONN.HasValue)
				request.WithQueryParameter("CONN", m3_CONN.Value.ToString());
			if (m3_DSDT.HasValue)
				request.WithQueryParameter("DSDT", m3_DSDT.Value.ToM3String());
			if (m3_DSHM.HasValue)
				request.WithQueryParameter("DSHM", m3_DSHM.Value.ToString());
			if (m3_CDEL.HasValue)
				request.WithQueryParameter("CDEL", m3_CDEL.Value.ToString());
			if (m3_NDLX.HasValue)
				request.WithQueryParameter("NDLX", m3_NDLX.Value.ToString());
			if (m3_FRCP.HasValue)
				request.WithQueryParameter("FRCP", m3_FRCP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PPNB))
				request.WithQueryParameter("PPNB", m3_PPNB.Trim());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

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
		/// Name DeleteSubLine
		/// Description DeleteSubLine
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_PACN">Package number (Required)</param>
		/// <param name="m3_MSLN">Message line number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SUBL">Subline number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteSubLine(
			string m3_MSGN, 
			string m3_PACN, 
			int m3_MSLN, 
			int? m3_CONO = null, 
			int? m3_SUBL = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeleteSubLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");
			if (string.IsNullOrWhiteSpace(m3_PACN))
				throw new ArgumentNullException("m3_PACN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim())
				.WithQueryParameter("PACN", m3_PACN.Trim())
				.WithQueryParameter("MSLN", m3_MSLN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_SUBL.HasValue)
				request.WithQueryParameter("SUBL", m3_SUBL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());

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
		/// Name DeleteWhsTran
		/// Description Delete Warehouse Integration Transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteWhsTran(
			string m3_MSGN, 
			int? m3_CONO = null, 
			string m3_PACN = null, 
			int? m3_MSLN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeleteWhsTran",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());

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
		/// Name GetMvxMsg
		/// Description Get Movex Message ID
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PB">Partner (Required)</param>
		/// <param name="m3_PMSN">External message number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMvxMsgResponse></returns>
		/// <exception cref="M3Exception<GetMvxMsgResponse>"></exception>
		public async Task<M3Response<GetMvxMsgResponse>> GetMvxMsg(
			string m3_E0PB, 
			string m3_PMSN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMvxMsg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PB))
				throw new ArgumentNullException("m3_E0PB");
			if (string.IsNullOrWhiteSpace(m3_PMSN))
				throw new ArgumentNullException("m3_PMSN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PB", m3_E0PB.Trim())
				.WithQueryParameter("PMSN", m3_PMSN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetMvxMsgResponse>(
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
		/// Name GetWhsHead
		/// Description Get Warehouse Integration Header
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetWhsHeadResponse></returns>
		/// <exception cref="M3Exception<GetWhsHeadResponse>"></exception>
		public async Task<M3Response<GetWhsHeadResponse>> GetWhsHead(
			string m3_MSGN, 
			int? m3_CONO = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetWhsHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<GetWhsHeadResponse>(
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
		/// Name GetWhsLine
		/// Description Get Warehouse Integration Line
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_PACN">Package number (Required)</param>
		/// <param name="m3_MSLN">Message line number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetWhsLineResponse></returns>
		/// <exception cref="M3Exception<GetWhsLineResponse>"></exception>
		public async Task<M3Response<GetWhsLineResponse>> GetWhsLine(
			string m3_MSGN, 
			string m3_PACN, 
			int m3_MSLN, 
			int? m3_CONO = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetWhsLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");
			if (string.IsNullOrWhiteSpace(m3_PACN))
				throw new ArgumentNullException("m3_PACN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim())
				.WithQueryParameter("PACN", m3_PACN.Trim())
				.WithQueryParameter("MSLN", m3_MSLN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<GetWhsLineResponse>(
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
		/// Name GetWhsPack
		/// Description Get Warehouse Integration Package
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_PACN">Package number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetWhsPackResponse></returns>
		/// <exception cref="M3Exception<GetWhsPackResponse>"></exception>
		public async Task<M3Response<GetWhsPackResponse>> GetWhsPack(
			string m3_MSGN, 
			string m3_PACN, 
			int? m3_CONO = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetWhsPack",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");
			if (string.IsNullOrWhiteSpace(m3_PACN))
				throw new ArgumentNullException("m3_PACN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim())
				.WithQueryParameter("PACN", m3_PACN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<GetWhsPackResponse>(
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
		/// Name LstItemSubLine
		/// Description LstItemSubLine
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemSubLineResponse></returns>
		/// <exception cref="M3Exception<LstItemSubLineResponse>"></exception>
		public async Task<M3Response<LstItemSubLineResponse>> LstItemSubLine(
			string m3_MSGN, 
			int? m3_CONO = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_PACN = null, 
			int? m3_MSLN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItemSubLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());

			// Execute the request
			var result = await Execute<LstItemSubLineResponse>(
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
		/// Name LstMvxMsg
		/// Description List Movex Message ID
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PB">Partner (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMvxMsgResponse></returns>
		/// <exception cref="M3Exception<LstMvxMsgResponse>"></exception>
		public async Task<M3Response<LstMvxMsgResponse>> LstMvxMsg(
			string m3_E0PB, 
			int? m3_CONO = null, 
			string m3_PMSN = null, 
			string m3_STAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMvxMsg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PB))
				throw new ArgumentNullException("m3_E0PB");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PB", m3_E0PB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());

			// Execute the request
			var result = await Execute<LstMvxMsgResponse>(
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
		/// Name LstSubLine
		/// Description LstSubLine
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_BANT">Reference sublot ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSubLineResponse></returns>
		/// <exception cref="M3Exception<LstSubLineResponse>"></exception>
		public async Task<M3Response<LstSubLineResponse>> LstSubLine(
			string m3_MSGN, 
			int? m3_CONO = null, 
			string m3_PACN = null, 
			int? m3_MSLN = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_BANT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSubLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANT))
				request.WithQueryParameter("BANT", m3_BANT.Trim());

			// Execute the request
			var result = await Execute<LstSubLineResponse>(
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
		/// Name LstWhsLine
		/// Description List Warehouse Integration Line
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstWhsLineResponse></returns>
		/// <exception cref="M3Exception<LstWhsLineResponse>"></exception>
		public async Task<M3Response<LstWhsLineResponse>> LstWhsLine(
			string m3_MSGN, 
			string m3_PACN = null, 
			int? m3_MSLN = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstWhsLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<LstWhsLineResponse>(
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
		/// Name PrcWhsTran
		/// Description Process Warehouse Integration Transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_PRFL">Process flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrcWhsTran(
			string m3_MSGN, 
			int? m3_CONO = null, 
			string m3_PACN = null, 
			int? m3_MSLN = null, 
			string m3_PRFL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrcWhsTran",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());

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
		/// Name SndPOReceipt
		/// Description Snd Purchase Order Receipt
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SUTY">Supplier type (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line (Required)</param>
		/// <param name="m3_PRFL">Process Flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_QTY">Quantity Received</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_USD1">User Defined 1</param>
		/// <param name="m3_USD2">User defined 2</param>
		/// <param name="m3_USD3">User defined 3</param>
		/// <param name="m3_USD4">User defined 4</param>
		/// <param name="m3_USD5">User defined 5</param>
		/// <param name="m3_RIDI">Delivery number</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_OEND">Flagged as completed</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_BREF">Lot Reference 1</param>
		/// <param name="m3_BRE2">Lot Reference 2</param>
		/// <param name="m3_EXPI">Expiration date</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_DNDT">Delivery note date</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndPOReceipt(
			string m3_WHLO, 
			string m3_E0PA, 
			string m3_E065, 
			string m3_SUNO, 
			int m3_SUTY, 
			string m3_RIDN, 
			int m3_RIDL, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSGN = null, 
			string m3_PACN = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_ADID = null, 
			string m3_ITNO = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			decimal? m3_QTY = null, 
			int? m3_RIDX = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_RIDI = null, 
			decimal? m3_CAWE = null, 
			int? m3_OEND = null, 
			string m3_PMSN = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			DateTime? m3_EXPI = null, 
			DateTime? m3_RPDT = null, 
			int? m3_RPTM = null, 
			string m3_SUDO = null, 
			DateTime? m3_DNDT = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndPOReceipt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SUTY", m3_SUTY.ToString())
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("RIDL", m3_RIDL.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_QTY.HasValue)
				request.WithQueryParameter("QTY", m3_QTY.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3_RIDI.Value.ToString());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (m3_EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3_EXPI.Value.ToM3String());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (m3_DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3_DNDT.Value.ToM3String());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

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
		/// Name SndWhsLine
		/// Description Send Warehouse Integration Line
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_PACN">Package number (Required)</param>
		/// <param name="m3_QLFR">Qualifier (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_QLFS">Sequence number</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_CHGD">Date changed</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_RELI">Line number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_DLQT">Delivered quantity - basic U/M</param>
		/// <param name="m3_UNIT">Unit of measure</param>
		/// <param name="m3_DLQA">Delivered quantity - alternate U/M</param>
		/// <param name="m3_ALUN">Alternate U/M</param>
		/// <param name="m3_VOL3">Volume</param>
		/// <param name="m3_NEWE">Net weight</param>
		/// <param name="m3_GRWE">Gross weight</param>
		/// <param name="m3_D1QT">Standard quantity</param>
		/// <param name="m3_DLSP">Delivery specification</param>
		/// <param name="m3_RVQA">Received quantity</param>
		/// <param name="m3_PUUN">Purchase order U/M</param>
		/// <param name="m3_ALQT">Allocated quantity - basic U/M</param>
		/// <param name="m3_PAQT">Packed quantity</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_POCY">Normal potency</param>
		/// <param name="m3_OEND">Flagged as completed</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_FLOC">From picking location</param>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="m3_TTYP">Stock transaction type</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDO">Order operation</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDI">Order index</param>
		/// <param name="m3_PLSX">Picking list suffix</param>
		/// <param name="m3_DLIX">Delivery index</param>
		/// <param name="m3_DNNO">Delivery note number</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_SUTY">Supplier type</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_DNDT">Delivery note date</param>
		/// <param name="m3_SITE">Supplier item number</param>
		/// <param name="m3_SITD">Supplier item name</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_PPUN">Purchase price U/M</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_PUCD">Purchase price quantity</param>
		/// <param name="m3_LNAM">Line amount - order currency</param>
		/// <param name="m3_VTCD">VAT code</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_DTID">Data identity</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">Reporting time</param>
		/// <param name="m3_RGDT">Not used!</param>
		/// <param name="m3_RGTM">Not used!</param>
		/// <param name="m3_LMDT">Not used!</param>
		/// <param name="m3_CHNO">Not used!</param>
		/// <param name="m3_CHID">Not used!</param>
		/// <param name="m3_QCRA">Quality inspection result</param>
		/// <param name="m3_SCRE">Rejection reason</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_EXPI">Expiration date</param>
		/// <param name="m3_CNDT">Follow-up date</param>
		/// <param name="m3_SEDT">Sales date</param>
		/// <param name="m3_TRTP">Order type</param>
		/// <param name="m3_PLRN">Reporting number - pick line</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_TWSL">To Location</param>
		/// <param name="m3_ISMD">Issue Mode</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndWhsLine(
			string m3_WHLO, 
			string m3_MSGN, 
			string m3_PACN, 
			string m3_QLFR, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			int? m3_MSLN = null, 
			int? m3_QLFS = null, 
			string m3_FACI = null, 
			DateTime? m3_CHGD = null, 
			string m3_STAT = null, 
			string m3_ITNO = null, 
			string m3_ITDS = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			long? m3_REPN = null, 
			int? m3_RELI = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			decimal? m3_DLQT = null, 
			string m3_UNIT = null, 
			decimal? m3_DLQA = null, 
			string m3_ALUN = null, 
			decimal? m3_VOL3 = null, 
			decimal? m3_NEWE = null, 
			decimal? m3_GRWE = null, 
			decimal? m3_D1QT = null, 
			string m3_DLSP = null, 
			decimal? m3_RVQA = null, 
			string m3_PUUN = null, 
			decimal? m3_ALQT = null, 
			decimal? m3_PAQT = null, 
			decimal? m3_CAWE = null, 
			int? m3_POCY = null, 
			int? m3_OEND = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			string m3_FLOC = null, 
			string m3_ORCA = null, 
			int? m3_TTYP = null, 
			string m3_RIDN = null, 
			int? m3_RIDO = null, 
			int? m3_RIDL = null, 
			decimal? m3_RIDI = null, 
			int? m3_PLSX = null, 
			decimal? m3_DLIX = null, 
			string m3_DNNO = null, 
			string m3_CUOR = null, 
			string m3_CUNO = null, 
			string m3_ADID = null, 
			string m3_SUNO = null, 
			int? m3_SUTY = null, 
			string m3_SUDO = null, 
			DateTime? m3_DNDT = null, 
			string m3_SITE = null, 
			string m3_SITD = null, 
			decimal? m3_PUPR = null, 
			string m3_PPUN = null, 
			string m3_CUCD = null, 
			int? m3_PUCD = null, 
			decimal? m3_LNAM = null, 
			int? m3_VTCD = null, 
			string m3_AGNB = null, 
			string m3_RESP = null, 
			decimal? m3_DTID = null, 
			decimal? m3_TXID = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			DateTime? m3_RGDT = null, 
			int? m3_RGTM = null, 
			DateTime? m3_LMDT = null, 
			int? m3_CHNO = null, 
			string m3_CHID = null, 
			string m3_QCRA = null, 
			string m3_SCRE = null, 
			string m3_BREM = null, 
			DateTime? m3_EXPI = null, 
			DateTime? m3_CNDT = null, 
			DateTime? m3_SEDT = null, 
			string m3_TRTP = null, 
			decimal? m3_PLRN = null, 
			DateTime? m3_RPDT = null, 
			string m3_TWSL = null, 
			int? m3_ISMD = null, 
			int? m3_RIDX = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndWhsLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");
			if (string.IsNullOrWhiteSpace(m3_PACN))
				throw new ArgumentNullException("m3_PACN");
			if (string.IsNullOrWhiteSpace(m3_QLFR))
				throw new ArgumentNullException("m3_QLFR");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("MSGN", m3_MSGN.Trim())
				.WithQueryParameter("PACN", m3_PACN.Trim())
				.WithQueryParameter("QLFR", m3_QLFR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (m3_QLFS.HasValue)
				request.WithQueryParameter("QLFS", m3_QLFS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (m3_CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3_CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (m3_RELI.HasValue)
				request.WithQueryParameter("RELI", m3_RELI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (m3_DLQT.HasValue)
				request.WithQueryParameter("DLQT", m3_DLQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNIT))
				request.WithQueryParameter("UNIT", m3_UNIT.Trim());
			if (m3_DLQA.HasValue)
				request.WithQueryParameter("DLQA", m3_DLQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());
			if (m3_VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3_VOL3.Value.ToString());
			if (m3_NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3_NEWE.Value.ToString());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (m3_D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3_D1QT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DLSP))
				request.WithQueryParameter("DLSP", m3_DLSP.Trim());
			if (m3_RVQA.HasValue)
				request.WithQueryParameter("RVQA", m3_RVQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PUUN))
				request.WithQueryParameter("PUUN", m3_PUUN.Trim());
			if (m3_ALQT.HasValue)
				request.WithQueryParameter("ALQT", m3_ALQT.Value.ToString());
			if (m3_PAQT.HasValue)
				request.WithQueryParameter("PAQT", m3_PAQT.Value.ToString());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (m3_POCY.HasValue)
				request.WithQueryParameter("POCY", m3_POCY.Value.ToString());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLOC))
				request.WithQueryParameter("FLOC", m3_FLOC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());
			if (m3_TTYP.HasValue)
				request.WithQueryParameter("TTYP", m3_TTYP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDO.HasValue)
				request.WithQueryParameter("RIDO", m3_RIDO.Value.ToString());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3_RIDI.Value.ToString());
			if (m3_PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3_PLSX.Value.ToString());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DNNO))
				request.WithQueryParameter("DNNO", m3_DNNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_SUTY.HasValue)
				request.WithQueryParameter("SUTY", m3_SUTY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (m3_DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3_DNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_SITE))
				request.WithQueryParameter("SITE", m3_SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SITD))
				request.WithQueryParameter("SITD", m3_SITD.Trim());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PPUN))
				request.WithQueryParameter("PPUN", m3_PPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3_PUCD.Value.ToString());
			if (m3_LNAM.HasValue)
				request.WithQueryParameter("LNAM", m3_LNAM.Value.ToString());
			if (m3_VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3_VTCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_DTID.HasValue)
				request.WithQueryParameter("DTID", m3_DTID.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3_RGTM.Value.ToString());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());
			if (m3_CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3_CHNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QCRA))
				request.WithQueryParameter("QCRA", m3_QCRA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCRE))
				request.WithQueryParameter("SCRE", m3_SCRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (m3_EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3_EXPI.Value.ToM3String());
			if (m3_CNDT.HasValue)
				request.WithQueryParameter("CNDT", m3_CNDT.Value.ToM3String());
			if (m3_SEDT.HasValue)
				request.WithQueryParameter("SEDT", m3_SEDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TRTP))
				request.WithQueryParameter("TRTP", m3_TRTP.Trim());
			if (m3_PLRN.HasValue)
				request.WithQueryParameter("PLRN", m3_PLRN.Value.ToString());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (m3_ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3_ISMD.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

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
		/// Name SndWhsPack
		/// Description Send Warehouse Integration Package
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_QLFR">Qualifier (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_CHGD">Date changed</param>
		/// <param name="m3_PARE">Package reference</param>
		/// <param name="m3_DIPA">Disconnected package</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_DNNO">Delivery note number</param>
		/// <param name="m3_DNDT">Delivery note date</param>
		/// <param name="m3_TRSH">Highest status - stock transaction</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_TRSL">Lowest status - stock transaction</param>
		/// <param name="m3_PACO">Package level</param>
		/// <param name="m3_PACU">Bulk package</param>
		/// <param name="m3_PACC">Included in package number</param>
		/// <param name="m3_AMKO">Number of packages</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_PACK">Package type</param>
		/// <param name="m3_TEPA">Packaging terms</param>
		/// <param name="m3_SORT">Sort value</param>
		/// <param name="m3_DLRM">Remark</param>
		/// <param name="m3_DLMO">Goods mark Odette standard</param>
		/// <param name="m3_DLSP">Delivery specification</param>
		/// <param name="m3_VOM3">Volume</param>
		/// <param name="m3_NEWE">Net weight</param>
		/// <param name="m3_GRWE">Gross weight</param>
		/// <param name="m3_GRW3">Included gross weight</param>
		/// <param name="m3_GRW4">Manual gross weight</param>
		/// <param name="m3_GRW5">Included net weight</param>
		/// <param name="m3_D1QT">Standard quantity</param>
		/// <param name="m3_VOMT">Weight</param>
		/// <param name="m3_PACL">Package length</param>
		/// <param name="m3_PACW">Package width</param>
		/// <param name="m3_PACH">Package height</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_SUTY">Supplier type</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_DTID">Data identity</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_RGDT">Not used!</param>
		/// <param name="m3_RGTM">Not used!</param>
		/// <param name="m3_LMDT">Not used!</param>
		/// <param name="m3_CHNO">Not used!</param>
		/// <param name="m3_CHID">Not used!</param>
		/// <param name="m3_ROUT">Route</param>
		/// <param name="m3_RODN">Route departure</param>
		/// <param name="m3_CONN">Shipment</param>
		/// <param name="m3_DSDT">Departure date</param>
		/// <param name="m3_DSHM">Departure time</param>
		/// <param name="m3_CDEL">Changed delivery</param>
		/// <param name="m3_NDLX">New delivery number</param>
		/// <param name="m3_FRCP">Capacity - free capacity unit</param>
		/// <param name="m3_PPNB">Pre-pack number</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndWhsPack(
			string m3_WHLO, 
			string m3_MSGN, 
			string m3_QLFR, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_PACN = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			DateTime? m3_CHGD = null, 
			string m3_PARE = null, 
			int? m3_DIPA = null, 
			string m3_SUDO = null, 
			string m3_DNNO = null, 
			DateTime? m3_DNDT = null, 
			string m3_TRSH = null, 
			string m3_STAT = null, 
			string m3_TRSL = null, 
			int? m3_PACO = null, 
			int? m3_PACU = null, 
			string m3_PACC = null, 
			int? m3_AMKO = null, 
			string m3_PACT = null, 
			string m3_PACK = null, 
			string m3_TEPA = null, 
			string m3_SORT = null, 
			string m3_DLRM = null, 
			string m3_DLMO = null, 
			string m3_DLSP = null, 
			decimal? m3_VOM3 = null, 
			decimal? m3_NEWE = null, 
			decimal? m3_GRWE = null, 
			decimal? m3_GRW3 = null, 
			decimal? m3_GRW4 = null, 
			decimal? m3_GRW5 = null, 
			decimal? m3_D1QT = null, 
			decimal? m3_VOMT = null, 
			int? m3_PACL = null, 
			int? m3_PACW = null, 
			int? m3_PACH = null, 
			string m3_SSCC = null, 
			string m3_WHSL = null, 
			string m3_CUNO = null, 
			string m3_ADID = null, 
			int? m3_SUTY = null, 
			string m3_SUNO = null, 
			string m3_RESP = null, 
			decimal? m3_DTID = null, 
			decimal? m3_TXID = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			DateTime? m3_RGDT = null, 
			int? m3_RGTM = null, 
			DateTime? m3_LMDT = null, 
			int? m3_CHNO = null, 
			string m3_CHID = null, 
			string m3_ROUT = null, 
			int? m3_RODN = null, 
			int? m3_CONN = null, 
			DateTime? m3_DSDT = null, 
			int? m3_DSHM = null, 
			int? m3_CDEL = null, 
			decimal? m3_NDLX = null, 
			decimal? m3_FRCP = null, 
			string m3_PPNB = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndWhsPack",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");
			if (string.IsNullOrWhiteSpace(m3_QLFR))
				throw new ArgumentNullException("m3_QLFR");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("MSGN", m3_MSGN.Trim())
				.WithQueryParameter("QLFR", m3_QLFR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (m3_CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3_CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PARE))
				request.WithQueryParameter("PARE", m3_PARE.Trim());
			if (m3_DIPA.HasValue)
				request.WithQueryParameter("DIPA", m3_DIPA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DNNO))
				request.WithQueryParameter("DNNO", m3_DNNO.Trim());
			if (m3_DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3_DNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TRSH))
				request.WithQueryParameter("TRSH", m3_TRSH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRSL))
				request.WithQueryParameter("TRSL", m3_TRSL.Trim());
			if (m3_PACO.HasValue)
				request.WithQueryParameter("PACO", m3_PACO.Value.ToString());
			if (m3_PACU.HasValue)
				request.WithQueryParameter("PACU", m3_PACU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACC))
				request.WithQueryParameter("PACC", m3_PACC.Trim());
			if (m3_AMKO.HasValue)
				request.WithQueryParameter("AMKO", m3_AMKO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACK))
				request.WithQueryParameter("PACK", m3_PACK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SORT))
				request.WithQueryParameter("SORT", m3_SORT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLRM))
				request.WithQueryParameter("DLRM", m3_DLRM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLMO))
				request.WithQueryParameter("DLMO", m3_DLMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLSP))
				request.WithQueryParameter("DLSP", m3_DLSP.Trim());
			if (m3_VOM3.HasValue)
				request.WithQueryParameter("VOM3", m3_VOM3.Value.ToString());
			if (m3_NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3_NEWE.Value.ToString());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (m3_GRW3.HasValue)
				request.WithQueryParameter("GRW3", m3_GRW3.Value.ToString());
			if (m3_GRW4.HasValue)
				request.WithQueryParameter("GRW4", m3_GRW4.Value.ToString());
			if (m3_GRW5.HasValue)
				request.WithQueryParameter("GRW5", m3_GRW5.Value.ToString());
			if (m3_D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3_D1QT.Value.ToString());
			if (m3_VOMT.HasValue)
				request.WithQueryParameter("VOMT", m3_VOMT.Value.ToString());
			if (m3_PACL.HasValue)
				request.WithQueryParameter("PACL", m3_PACL.Value.ToString());
			if (m3_PACW.HasValue)
				request.WithQueryParameter("PACW", m3_PACW.Value.ToString());
			if (m3_PACH.HasValue)
				request.WithQueryParameter("PACH", m3_PACH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (m3_SUTY.HasValue)
				request.WithQueryParameter("SUTY", m3_SUTY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_DTID.HasValue)
				request.WithQueryParameter("DTID", m3_DTID.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3_RGTM.Value.ToString());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());
			if (m3_CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3_CHNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ROUT))
				request.WithQueryParameter("ROUT", m3_ROUT.Trim());
			if (m3_RODN.HasValue)
				request.WithQueryParameter("RODN", m3_RODN.Value.ToString());
			if (m3_CONN.HasValue)
				request.WithQueryParameter("CONN", m3_CONN.Value.ToString());
			if (m3_DSDT.HasValue)
				request.WithQueryParameter("DSDT", m3_DSDT.Value.ToM3String());
			if (m3_DSHM.HasValue)
				request.WithQueryParameter("DSHM", m3_DSHM.Value.ToString());
			if (m3_CDEL.HasValue)
				request.WithQueryParameter("CDEL", m3_CDEL.Value.ToString());
			if (m3_NDLX.HasValue)
				request.WithQueryParameter("NDLX", m3_NDLX.Value.ToString());
			if (m3_FRCP.HasValue)
				request.WithQueryParameter("FRCP", m3_FRCP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PPNB))
				request.WithQueryParameter("PPNB", m3_PPNB.Trim());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

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
