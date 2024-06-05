/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddCOPick
		/// Description Add Customer Order Pick
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3RIDL">Order line (Required)</param>
		/// <param name="m3PLSX">Picking list suffix (Required)</param>
		/// <param name="m3PRFL">Process Flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3QTYP">Quantity Picked</param>
		/// <param name="m3QTYO">Quantity to be picked</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3RIDI">Order index</param>
		/// <param name="m3DLIX">Delivery index</param>
		/// <param name="m3USD1">User Defined 1</param>
		/// <param name="m3USD2">User defined 2</param>
		/// <param name="m3USD3">User defined 3</param>
		/// <param name="m3USD4">User defined 4</param>
		/// <param name="m3USD5">User defined 5</param>
		/// <param name="m3PLRN">Reporting number - pick line</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="m3OEND">Flagged as completed</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3AMKO">Number of packages</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3PARE">Packaging reference</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="m3ISMD">Issue/move mode</param>
		/// <param name="m3BREF">Lot Reference 1</param>
		/// <param name="m3BRE2">Lot Reference 2</param>
		/// <param name="m3GRWE">Gross Weight</param>
		/// <param name="m3VOM3">Volume</param>
		/// <param name="m3FRCP">Free Capacity unit</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3LODO">Loading platform</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddCOPickResponse></returns>
		/// <exception cref="M3Exception<AddCOPickResponse>"></exception>
		public async Task<M3Response<AddCOPickResponse>> AddCOPick(
			string m3WHLO, 
			string m3E0PA, 
			string m3E065, 
			string m3CUNO, 
			string m3RIDN, 
			int m3RIDL, 
			int m3PLSX, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSGN = null, 
			string m3PACN = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3ADID = null, 
			string m3ITNO = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			decimal? m3QTYP = null, 
			decimal? m3QTYO = null, 
			int? m3RIDX = null, 
			decimal? m3RIDI = null, 
			decimal? m3DLIX = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			decimal? m3PLRN = null, 
			string m3TWSL = null, 
			int? m3OEND = null, 
			DateTime? m3RPDT = null, 
			decimal? m3CAWE = null, 
			string m3PACT = null, 
			int? m3AMKO = null, 
			string m3PMSN = null, 
			string m3PARE = null, 
			string m3SSCC = null, 
			int? m3ISMD = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			decimal? m3GRWE = null, 
			decimal? m3VOM3 = null, 
			decimal? m3FRCP = null, 
			int? m3RPTM = null, 
			string m3LODO = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddCOPick",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("RIDN", m3RIDN.Trim())
				.WithQueryParameter("RIDL", m3RIDL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLSX", m3PLSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3QTYP.HasValue)
				request.WithQueryParameter("QTYP", m3QTYP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QTYO.HasValue)
				request.WithQueryParameter("QTYO", m3QTYO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3RIDI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3PLRN.HasValue)
				request.WithQueryParameter("PLRN", m3PLRN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (m3AMKO.HasValue)
				request.WithQueryParameter("AMKO", m3AMKO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PARE))
				request.WithQueryParameter("PARE", m3PARE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());
			if (m3ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3ISMD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOM3.HasValue)
				request.WithQueryParameter("VOM3", m3VOM3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRCP.HasValue)
				request.WithQueryParameter("FRCP", m3FRCP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LODO))
				request.WithQueryParameter("LODO", m3LODO.Trim());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddCOPickResponse>(
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
		/// Name AddCOReturn
		/// Description Add Customer Order Return
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3REPN">Receiving number (Required)</param>
		/// <param name="m3RELI">Line number (Required)</param>
		/// <param name="m3RESP">Responsible (Required)</param>
		/// <param name="m3PRFL">Process Flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3QTY">Returned Quantity</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3USD1">User Defined 1</param>
		/// <param name="m3USD2">User defined 2</param>
		/// <param name="m3USD3">User defined 3</param>
		/// <param name="m3USD4">User defined 4</param>
		/// <param name="m3USD5">User defined 5</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddCOReturnResponse></returns>
		/// <exception cref="M3Exception<AddCOReturnResponse>"></exception>
		public async Task<M3Response<AddCOReturnResponse>> AddCOReturn(
			string m3WHLO, 
			string m3E0PA, 
			string m3E065, 
			string m3CUNO, 
			long m3REPN, 
			int m3RELI, 
			string m3RESP, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSGN = null, 
			string m3PACN = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3ADID = null, 
			string m3ITNO = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			decimal? m3QTY = null, 
			decimal? m3CAWE = null, 
			string m3RIDN = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			string m3PMSN = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddCOReturn",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3RESP))
				throw new ArgumentNullException(nameof(m3RESP));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("REPN", m3REPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RELI", m3RELI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RESP", m3RESP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3QTY.HasValue)
				request.WithQueryParameter("QTY", m3QTY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddCOReturnResponse>(
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
		/// Name AddCfmPickList
		/// Description Add Confirm Picklist
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3PLSX">Picking list suffix (Required)</param>
		/// <param name="m3PRMD">Process Flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ISMD">Issue/move mode</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3USD1">User defined - 1</param>
		/// <param name="m3UDS2">User defined - 2</param>
		/// <param name="m3USD3">User defined - 3</param>
		/// <param name="m3USD4">User defined - 4</param>
		/// <param name="m3USD5">User defined - 5</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3LODO">Loading platform</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddCfmPickListResponse></returns>
		/// <exception cref="M3Exception<AddCfmPickListResponse>"></exception>
		public async Task<M3Response<AddCfmPickListResponse>> AddCfmPickList(
			string m3WHLO, 
			string m3E0PA, 
			string m3E065, 
			decimal m3DLIX, 
			int m3PLSX, 
			string m3PRMD = null, 
			int? m3CONO = null, 
			int? m3ISMD = null, 
			string m3TWSL = null, 
			string m3MSGN = null, 
			string m3PMSN = null, 
			string m3PACN = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3USD1 = null, 
			string m3UDS2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			DateTime? m3RPDT = null, 
			int? m3RPTM = null, 
			string m3LODO = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddCfmPickList",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLSX", m3PLSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3ISMD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3UDS2))
				request.WithQueryParameter("UDS2", m3UDS2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LODO))
				request.WithQueryParameter("LODO", m3LODO.Trim());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddCfmPickListResponse>(
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
		/// Name AddDO
		/// Description Add DO transaction
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E0PB">Partner ID (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3TRTP">Order type (Required)</param>
		/// <param name="m3RESP">Responsible (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3ADID">Address ID</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias category</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3ALQT">Allocate qty - basic U/M</param>
		/// <param name="m3DLQT">Delivered qty - basic U/M</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3RIDI">Delivery number</param>
		/// <param name="m3PLSX">Picking list suffix</param>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="m3USD1">User defined field</param>
		/// <param name="m3USD2">User defined field</param>
		/// <param name="m3USD3">User defined field</param>
		/// <param name="m3USD4">User defined field</param>
		/// <param name="m3USD5">User defined field</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORN">Reference Order Number</param>
		/// <param name="m3RORL">Reference Order Line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddDOResponse></returns>
		/// <exception cref="M3Exception<AddDOResponse>"></exception>
		public async Task<M3Response<AddDOResponse>> AddDO(
			string m3WHLO, 
			string m3E0PA, 
			string m3E0PB, 
			string m3E065, 
			string m3TRTP, 
			string m3RESP, 
			string m3PRMD = null, 
			int? m3CONO = null, 
			string m3MSGN = null, 
			string m3PACN = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3CUNO = null, 
			string m3ADID = null, 
			string m3ITNO = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			string m3WHSL = null, 
			string m3TWSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			decimal? m3ALQT = null, 
			decimal? m3DLQT = null, 
			string m3RIDN = null, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
			decimal? m3RIDI = null, 
			int? m3PLSX = null, 
			decimal? m3DLIX = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			decimal? m3CAWE = null, 
			string m3PMSN = null, 
			int? m3OPNO = null, 
			string m3RSCD = null, 
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			DateTime? m3RPDT = null, 
			int? m3RPTM = null, 
			long? m3REPN = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddDO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E0PB))
				throw new ArgumentNullException(nameof(m3E0PB));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3TRTP))
				throw new ArgumentNullException(nameof(m3TRTP));
			if (string.IsNullOrWhiteSpace(m3RESP))
				throw new ArgumentNullException(nameof(m3RESP));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E0PB", m3E0PB.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("TRTP", m3TRTP.Trim())
				.WithQueryParameter("RESP", m3RESP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3ALQT.HasValue)
				request.WithQueryParameter("ALQT", m3ALQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLQT.HasValue)
				request.WithQueryParameter("DLQT", m3DLQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3RIDI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3PLSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddDOResponse>(
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
		/// Name AddDOPackRec
		/// Description AddPackReceipt
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3TWSL">To Location (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3CONN">Shipment</param>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddDOPackRecResponse></returns>
		/// <exception cref="M3Exception<AddDOPackRecResponse>"></exception>
		public async Task<M3Response<AddDOPackRecResponse>> AddDOPackRec(
			string m3WHLO, 
			string m3E0PA, 
			string m3E065, 
			string m3TWSL, 
			string m3PRMD = null, 
			int? m3CONO = null, 
			string m3MSGN = null, 
			string m3PACN = null, 
			int? m3CONN = null, 
			decimal? m3DLIX = null, 
			string m3SSCC = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddDOPackRec",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3TWSL))
				throw new ArgumentNullException(nameof(m3TWSL));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("TWSL", m3TWSL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3CONN.HasValue)
				request.WithQueryParameter("CONN", m3CONN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());

			// Execute the request
			var result = await Execute<AddDOPackRecResponse>(
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
		/// Name AddDOPick
		/// Description Add Distribution Order Pick
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3RIDL">Order line (Required)</param>
		/// <param name="m3RIDI">Order index (Required)</param>
		/// <param name="m3PLSX">Picking list suffix (Required)</param>
		/// <param name="m3PRFL">Process Flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3QTYP">Quantity Picked</param>
		/// <param name="m3QTYO">Quantity to be picked</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3USD1">User Defined 1</param>
		/// <param name="m3USD2">User defined 2</param>
		/// <param name="m3USD3">User defined 3</param>
		/// <param name="m3USD4">User defined 4</param>
		/// <param name="m3USD5">User defined 5</param>
		/// <param name="m3PLRN">Reporting number - pick line</param>
		/// <param name="m3OEND">Flagged as completed</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3AMKO">Number of packages</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="m3PARE">Packaging reference</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="m3ISMD">Issue/move mode</param>
		/// <param name="m3BREF">Lot Reference 1</param>
		/// <param name="m3BRE2">Lot Reference 2</param>
		/// <param name="m3GRWE">Gross Weight</param>
		/// <param name="m3VOM3">Volume</param>
		/// <param name="m3FRCP">Free capacity unit</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3LODO">Loading platform</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddDOPickResponse></returns>
		/// <exception cref="M3Exception<AddDOPickResponse>"></exception>
		public async Task<M3Response<AddDOPickResponse>> AddDOPick(
			string m3WHLO, 
			string m3E0PA, 
			string m3E065, 
			string m3RIDN, 
			int m3RIDL, 
			decimal m3RIDI, 
			int m3PLSX, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSGN = null, 
			string m3PACN = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3ADID = null, 
			string m3ITNO = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			decimal? m3QTYP = null, 
			decimal? m3QTYO = null, 
			int? m3RIDX = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			decimal? m3PLRN = null, 
			int? m3OEND = null, 
			DateTime? m3RPDT = null, 
			decimal? m3CAWE = null, 
			string m3PACT = null, 
			int? m3AMKO = null, 
			string m3PMSN = null, 
			string m3TWSL = null, 
			string m3PARE = null, 
			string m3SSCC = null, 
			int? m3ISMD = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			decimal? m3GRWE = null, 
			decimal? m3VOM3 = null, 
			decimal? m3FRCP = null, 
			int? m3RPTM = null, 
			string m3LODO = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddDOPick",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("RIDN", m3RIDN.Trim())
				.WithQueryParameter("RIDL", m3RIDL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RIDI", m3RIDI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLSX", m3PLSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3QTYP.HasValue)
				request.WithQueryParameter("QTYP", m3QTYP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QTYO.HasValue)
				request.WithQueryParameter("QTYO", m3QTYO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3PLRN.HasValue)
				request.WithQueryParameter("PLRN", m3PLRN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (m3AMKO.HasValue)
				request.WithQueryParameter("AMKO", m3AMKO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3PARE))
				request.WithQueryParameter("PARE", m3PARE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());
			if (m3ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3ISMD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOM3.HasValue)
				request.WithQueryParameter("VOM3", m3VOM3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRCP.HasValue)
				request.WithQueryParameter("FRCP", m3FRCP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LODO))
				request.WithQueryParameter("LODO", m3LODO.Trim());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddDOPickResponse>(
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
		/// Name AddDORecViaPack
		/// Description DO Reciept Via Packaging
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3PRFL">Process flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="m3DLIX">Delivery</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDORecViaPack(
			string m3E0PA, 
			string m3E065, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3PACN = null, 
			string m3SSCC = null, 
			decimal? m3DLIX = null, 
			string m3RIDN = null, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
			string m3MSGN = null, 
			string m3ITNO = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddDORecViaPack",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddDOReceipt
		/// Description Add Distribution Order Receipt
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3QTY">Quantity Received (Required)</param>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3RIDL">Order line (Required)</param>
		/// <param name="m3RIDI">Order index (Required)</param>
		/// <param name="m3PRFL">Process Flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3TWHL">From Warehouse</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3RIDO">Order operation</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3PLSX">Picking list suffix</param>
		/// <param name="m3USD1">User Defined 1</param>
		/// <param name="m3USD2">User defined 2</param>
		/// <param name="m3USD3">User defined 3</param>
		/// <param name="m3USD4">User defined 4</param>
		/// <param name="m3USD5">User defined 5</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3BREF">Lot Reference 1</param>
		/// <param name="m3BRE2">Lot Reference 2</param>
		/// <param name="m3OEND">Flagged as completed</param>
		/// <param name="m3RPDT">Reporting Date</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3TOCA">To Container</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddDOReceiptResponse></returns>
		/// <exception cref="M3Exception<AddDOReceiptResponse>"></exception>
		public async Task<M3Response<AddDOReceiptResponse>> AddDOReceipt(
			string m3WHLO, 
			string m3E0PA, 
			string m3E065, 
			decimal m3QTY, 
			string m3RIDN, 
			int m3RIDL, 
			decimal m3RIDI, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSGN = null, 
			string m3PACN = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3TWHL = null, 
			string m3ADID = null, 
			string m3ITNO = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			int? m3RIDO = null, 
			int? m3RIDX = null, 
			int? m3PLSX = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			decimal? m3CAWE = null, 
			string m3PMSN = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			int? m3OEND = null, 
			DateTime? m3RPDT = null, 
			int? m3RPTM = null, 
			string m3TOCA = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddDOReceipt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("QTY", m3QTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RIDN", m3RIDN.Trim())
				.WithQueryParameter("RIDL", m3RIDL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RIDI", m3RIDI.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TWHL))
				request.WithQueryParameter("TWHL", m3TWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3RIDO.HasValue)
				request.WithQueryParameter("RIDO", m3RIDO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3PLSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TOCA))
				request.WithQueryParameter("TOCA", m3TOCA.Trim());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddDOReceiptResponse>(
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
		/// Name AddMOPick
		/// Description Add Manufacturing Order Pick
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3RIDL">Order line (Required)</param>
		/// <param name="m3RIDO">Order operation (Required)</param>
		/// <param name="m3DLIX">Delivery index (Required)</param>
		/// <param name="m3PLSX">Picking list suffix (Required)</param>
		/// <param name="m3PRFL">Process Flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3QTYP">Quantity Picked</param>
		/// <param name="m3QTYO">Quantity to be picked</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3USD1">User Defined 1</param>
		/// <param name="m3USD2">User defined 2</param>
		/// <param name="m3USD3">User defined 3</param>
		/// <param name="m3USD4">User defined 4</param>
		/// <param name="m3USD5">User defined 5</param>
		/// <param name="m3PLRN">Reporting number - pick line</param>
		/// <param name="m3OEND">Flagged as completed</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="m3PARE">Packaging reference</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="m3ISMD">Issue/move mode</param>
		/// <param name="m3GRWE">Gross weight</param>
		/// <param name="m3VOM3">Volume</param>
		/// <param name="m3FRCP">Free capacity</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3AMKO">Number of packages</param>
		/// <param name="m3LODO">Loading platform</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddMOPickResponse></returns>
		/// <exception cref="M3Exception<AddMOPickResponse>"></exception>
		public async Task<M3Response<AddMOPickResponse>> AddMOPick(
			string m3WHLO, 
			string m3E0PA, 
			string m3E065, 
			string m3RIDN, 
			int m3RIDL, 
			int m3RIDO, 
			decimal m3DLIX, 
			int m3PLSX, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSGN = null, 
			string m3PACN = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3ADID = null, 
			string m3ITNO = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			decimal? m3QTYP = null, 
			decimal? m3QTYO = null, 
			int? m3RIDX = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			decimal? m3PLRN = null, 
			int? m3OEND = null, 
			DateTime? m3RPDT = null, 
			decimal? m3CAWE = null, 
			string m3PMSN = null, 
			string m3TWSL = null, 
			string m3PARE = null, 
			string m3SSCC = null, 
			int? m3ISMD = null, 
			decimal? m3GRWE = null, 
			decimal? m3VOM3 = null, 
			decimal? m3FRCP = null, 
			int? m3RPTM = null, 
			string m3PACT = null, 
			int? m3AMKO = null, 
			string m3LODO = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddMOPick",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("RIDN", m3RIDN.Trim())
				.WithQueryParameter("RIDL", m3RIDL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RIDO", m3RIDO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLSX", m3PLSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3QTYP.HasValue)
				request.WithQueryParameter("QTYP", m3QTYP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QTYO.HasValue)
				request.WithQueryParameter("QTYO", m3QTYO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3PLRN.HasValue)
				request.WithQueryParameter("PLRN", m3PLRN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3PARE))
				request.WithQueryParameter("PARE", m3PARE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());
			if (m3ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3ISMD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOM3.HasValue)
				request.WithQueryParameter("VOM3", m3VOM3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRCP.HasValue)
				request.WithQueryParameter("FRCP", m3FRCP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (m3AMKO.HasValue)
				request.WithQueryParameter("AMKO", m3AMKO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LODO))
				request.WithQueryParameter("LODO", m3LODO.Trim());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddMOPickResponse>(
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
		/// Name AddMOReceipt
		/// Description Add Manufacturing Order Receipt
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3PRFL">Process Flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3TWHL">From Warehouse</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3QTY">Quantity Received</param>
		/// <param name="m3RIDO">Order operation</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3RIDI">Order index</param>
		/// <param name="m3PLSX">Picking list suffix</param>
		/// <param name="m3USD1">User Defined 1</param>
		/// <param name="m3USD2">User defined 2</param>
		/// <param name="m3USD3">User defined 3</param>
		/// <param name="m3USD4">User defined 4</param>
		/// <param name="m3USD5">User defined 5</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3BREF">Lot Reference 1</param>
		/// <param name="m3BRE2">Lot Reference 2</param>
		/// <param name="m3OEND">Flagged as completed</param>
		/// <param name="m3RPDT">Reporting Date</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3STAS">Status - balance ID</param>
		/// <param name="m3POCY">Normal potency</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddMOReceiptResponse></returns>
		/// <exception cref="M3Exception<AddMOReceiptResponse>"></exception>
		public async Task<M3Response<AddMOReceiptResponse>> AddMOReceipt(
			string m3WHLO, 
			string m3E0PA, 
			string m3E065, 
			string m3RIDN, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSGN = null, 
			string m3PACN = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3TWHL = null, 
			string m3ADID = null, 
			string m3ITNO = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			decimal? m3QTY = null, 
			int? m3RIDO = null, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
			decimal? m3RIDI = null, 
			int? m3PLSX = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			decimal? m3CAWE = null, 
			string m3PMSN = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			int? m3OEND = null, 
			DateTime? m3RPDT = null, 
			int? m3RPTM = null, 
			string m3STAS = null, 
			int? m3POCY = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddMOReceipt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("RIDN", m3RIDN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TWHL))
				request.WithQueryParameter("TWHL", m3TWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3QTY.HasValue)
				request.WithQueryParameter("QTY", m3QTY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDO.HasValue)
				request.WithQueryParameter("RIDO", m3RIDO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3RIDI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3PLSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAS))
				request.WithQueryParameter("STAS", m3STAS.Trim());
			if (m3POCY.HasValue)
				request.WithQueryParameter("POCY", m3POCY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddMOReceiptResponse>(
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
		/// Name AddPOClose
		/// Description Add Purchase Order Close
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3PRFL">Process flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3USD1">User defined 1</param>
		/// <param name="m3USD2">User defined 2</param>
		/// <param name="m3USD3">User defined 3</param>
		/// <param name="m3USD4">User defined 4</param>
		/// <param name="m3USD5">User defined 5</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPOCloseResponse></returns>
		/// <exception cref="M3Exception<AddPOCloseResponse>"></exception>
		public async Task<M3Response<AddPOCloseResponse>> AddPOClose(
			string m3WHLO, 
			string m3E0PA, 
			string m3E065, 
			string m3RIDN, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSGN = null, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
			string m3PMSN = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			string m3PACN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddPOClose",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("RIDN", m3RIDN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());

			// Execute the request
			var result = await Execute<AddPOCloseResponse>(
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
		/// Name AddPOInspect
		/// Description Add Purchase Order Inspection
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SUTY">Supplier type (Required)</param>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3RIDL">Order line (Required)</param>
		/// <param name="m3PRFL">Process Flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3QCRA">Quality inspection result</param>
		/// <param name="m3SCRE">Rejection reason</param>
		/// <param name="m3QTY">Quantity Received</param>
		/// <param name="m3OEND">Flagged as completed</param>
		/// <param name="m3EXPI">Expiration date</param>
		/// <param name="m3SEDT">Sales date</param>
		/// <param name="m3CNDT">Follow-up date</param>
		/// <param name="m3USD1">User Defined 1</param>
		/// <param name="m3USD2">User defined 2</param>
		/// <param name="m3USD3">User defined 3</param>
		/// <param name="m3USD4">User defined 4</param>
		/// <param name="m3USD5">User defined 5</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPOInspectResponse></returns>
		/// <exception cref="M3Exception<AddPOInspectResponse>"></exception>
		public async Task<M3Response<AddPOInspectResponse>> AddPOInspect(
			string m3WHLO, 
			string m3E0PA, 
			string m3E065, 
			string m3SUNO, 
			int m3SUTY, 
			string m3RIDN, 
			int m3RIDL, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSGN = null, 
			string m3PACN = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3ADID = null, 
			int? m3RIDX = null, 
			string m3ITNO = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			string m3BREM = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			string m3QCRA = null, 
			string m3SCRE = null, 
			decimal? m3QTY = null, 
			int? m3OEND = null, 
			DateTime? m3EXPI = null, 
			DateTime? m3SEDT = null, 
			DateTime? m3CNDT = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			string m3PMSN = null, 
			string m3RESP = null, 
			long? m3REPN = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddPOInspect",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SUTY", m3SUTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RIDN", m3RIDN.Trim())
				.WithQueryParameter("RIDL", m3RIDL.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3QCRA))
				request.WithQueryParameter("QCRA", m3QCRA.Trim());
			if (!string.IsNullOrWhiteSpace(m3SCRE))
				request.WithQueryParameter("SCRE", m3SCRE.Trim());
			if (m3QTY.HasValue)
				request.WithQueryParameter("QTY", m3QTY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3EXPI.Value.ToM3String());
			if (m3SEDT.HasValue)
				request.WithQueryParameter("SEDT", m3SEDT.Value.ToM3String());
			if (m3CNDT.HasValue)
				request.WithQueryParameter("CNDT", m3CNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddPOInspectResponse>(
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
		/// Name AddPOPackInsp
		/// Description Add PO Inspection by package
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3E0PA">Partner</param>
		/// <param name="m3E065">Message type</param>
		/// <param name="m3QCRA">Quality inspection result</param>
		/// <param name="m3SCRE">Rejection reason</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3OEND">Flagged as completed</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPOPackInspResponse></returns>
		/// <exception cref="M3Exception<AddPOPackInspResponse>"></exception>
		public async Task<M3Response<AddPOPackInspResponse>> AddPOPackInsp(
			string m3PRMD = null, 
			int? m3CONO = null, 
			string m3WHLO = null, 
			string m3MSGN = null, 
			string m3PACN = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3E0PA = null, 
			string m3E065 = null, 
			string m3QCRA = null, 
			string m3SCRE = null, 
			string m3TWSL = null, 
			string m3BREM = null, 
			string m3RESP = null, 
			int? m3OEND = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddPOPackInsp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3E0PA))
				request.WithQueryParameter("E0PA", m3E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3E065))
				request.WithQueryParameter("E065", m3E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3QCRA))
				request.WithQueryParameter("QCRA", m3QCRA.Trim());
			if (!string.IsNullOrWhiteSpace(m3SCRE))
				request.WithQueryParameter("SCRE", m3SCRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddPOPackInspResponse>(
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
		/// Name AddPOPutaway
		/// Description Add Purchase OrderPut away
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SUTY">Supplier type (Required)</param>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3RIDL">Order line (Required)</param>
		/// <param name="m3REPN">Receiving number (Required)</param>
		/// <param name="m3PRFL">Process Flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3BREF">Lot Reference 1</param>
		/// <param name="m3BRE2">Lot Reference 2</param>
		/// <param name="m3QTY">Quantity Received</param>
		/// <param name="m3OEND">Flagged as completed</param>
		/// <param name="m3EXPI">Expiration date</param>
		/// <param name="m3USD1">User Defined 1</param>
		/// <param name="m3USD2">User defined 2</param>
		/// <param name="m3USD3">User defined 3</param>
		/// <param name="m3USD4">User defined 4</param>
		/// <param name="m3USD5">User defined 5</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPOPutawayResponse></returns>
		/// <exception cref="M3Exception<AddPOPutawayResponse>"></exception>
		public async Task<M3Response<AddPOPutawayResponse>> AddPOPutaway(
			string m3WHLO, 
			string m3E0PA, 
			string m3E065, 
			string m3SUNO, 
			int m3SUTY, 
			string m3RIDN, 
			int m3RIDL, 
			long m3REPN, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSGN = null, 
			string m3PACN = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3ADID = null, 
			int? m3RIDX = null, 
			string m3ITNO = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			decimal? m3CAWE = null, 
			string m3BREM = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			decimal? m3QTY = null, 
			int? m3OEND = null, 
			DateTime? m3EXPI = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			string m3PMSN = null, 
			string m3RESP = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddPOPutaway",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SUTY", m3SUTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RIDN", m3RIDN.Trim())
				.WithQueryParameter("RIDL", m3RIDL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("REPN", m3REPN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3QTY.HasValue)
				request.WithQueryParameter("QTY", m3QTY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3EXPI.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddPOPutawayResponse>(
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
		/// Name AddPOReceipt
		/// Description Add Purchase Order Receipt
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SUTY">Supplier type (Required)</param>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3RIDL">Order line (Required)</param>
		/// <param name="m3PRFL">Process Flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3QTY">Quantity Received</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3USD1">User Defined 1</param>
		/// <param name="m3USD2">User defined 2</param>
		/// <param name="m3USD3">User defined 3</param>
		/// <param name="m3USD4">User defined 4</param>
		/// <param name="m3USD5">User defined 5</param>
		/// <param name="m3RIDI">Delivery number</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3OEND">Flagged as completed</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3BREF">Lot Reference 1</param>
		/// <param name="m3BRE2">Lot Reference 2</param>
		/// <param name="m3EXPI">Expiration date</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3DNDT">Delivery note date</param>
		/// <param name="m3POCY">Normal potency</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPOReceiptResponse></returns>
		/// <exception cref="M3Exception<AddPOReceiptResponse>"></exception>
		public async Task<M3Response<AddPOReceiptResponse>> AddPOReceipt(
			string m3WHLO, 
			string m3E0PA, 
			string m3E065, 
			string m3SUNO, 
			int m3SUTY, 
			string m3RIDN, 
			int m3RIDL, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSGN = null, 
			string m3PACN = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3ADID = null, 
			string m3ITNO = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			decimal? m3QTY = null, 
			int? m3RIDX = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			decimal? m3RIDI = null, 
			decimal? m3CAWE = null, 
			int? m3OEND = null, 
			string m3PMSN = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			DateTime? m3EXPI = null, 
			DateTime? m3RPDT = null, 
			int? m3RPTM = null, 
			string m3SUDO = null, 
			DateTime? m3DNDT = null, 
			int? m3POCY = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddPOReceipt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SUTY", m3SUTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RIDN", m3RIDN.Trim())
				.WithQueryParameter("RIDL", m3RIDL.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3QTY.HasValue)
				request.WithQueryParameter("QTY", m3QTY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3RIDI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3EXPI.Value.ToM3String());
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (m3DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3DNDT.Value.ToM3String());
			if (m3POCY.HasValue)
				request.WithQueryParameter("POCY", m3POCY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddPOReceiptResponse>(
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddPickByCubAl",
			};

			// Execute the request
			var result = await Execute<AddPickByCubAlResponse>(
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddPickByIntPac",
			};

			// Execute the request
			var result = await Execute<AddPickByIntPacResponse>(
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
		/// Name AddPickByPacStk
		/// Description AddPickByPackage inStock
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3PRMD">Process Flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3PANR">Package number</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="m3ISMD">Issue/move mode</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3USD1">User defined - 1</param>
		/// <param name="m3UDS2">User defined - 2</param>
		/// <param name="m3USD3">User defined - 3</param>
		/// <param name="m3USD4">User defined - 4</param>
		/// <param name="m3USD5">User defined - 5</param>
		/// <param name="m3LODO">Loading platform</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPickByPacStkResponse></returns>
		/// <exception cref="M3Exception<AddPickByPacStkResponse>"></exception>
		public async Task<M3Response<AddPickByPacStkResponse>> AddPickByPacStk(
			string m3WHLO, 
			string m3E0PA, 
			string m3E065, 
			decimal m3DLIX, 
			string m3PRMD = null, 
			int? m3CONO = null, 
			string m3MSGN = null, 
			string m3PMSN = null, 
			string m3PANR = null, 
			string m3SSCC = null, 
			int? m3ISMD = null, 
			string m3TWSL = null, 
			DateTime? m3RPDT = null, 
			int? m3RPTM = null, 
			string m3USD1 = null, 
			string m3UDS2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			string m3LODO = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddPickByPacStk",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PANR))
				request.WithQueryParameter("PANR", m3PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());
			if (m3ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3ISMD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3UDS2))
				request.WithQueryParameter("UDS2", m3UDS2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3LODO))
				request.WithQueryParameter("LODO", m3LODO.Trim());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddPickByPacStkResponse>(
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
		/// Name AddPickSftPacLn
		/// Description Add pick by soft packed line
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3PRMD">Process Flag</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3ALWT">Alias category</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3TRQT">Transaction quantity - basic U/M</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3ISMD">Issue/move mode</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3USD1">User defined - 1</param>
		/// <param name="m3USD3">User defined - 3</param>
		/// <param name="m3USD4">User defined - 4</param>
		/// <param name="m3USD5">User defined - 5</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3LODO">Loading platform</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPickSftPacLnResponse></returns>
		/// <exception cref="M3Exception<AddPickSftPacLnResponse>"></exception>
		public async Task<M3Response<AddPickSftPacLnResponse>> AddPickSftPacLn(
			string m3E0PA, 
			string m3E065, 
			decimal m3DLIX, 
			string m3WHLO, 
			string m3PRMD = null, 
			string m3MSGN = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3PACN = null, 
			string m3SSCC = null, 
			string m3ITNO = null, 
			string m3WHSL = null, 
			string m3CAMU = null, 
			string m3BANO = null, 
			int? m3ALWT = null, 
			string m3ALWQ = null, 
			string m3POPN = null, 
			decimal? m3TRQT = null, 
			decimal? m3CAWE = null, 
			int? m3ISMD = null, 
			string m3TWSL = null, 
			DateTime? m3RPDT = null, 
			int? m3RPTM = null, 
			string m3USD1 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			string m3USD2 = null, 
			string m3LODO = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddPickSftPacLn",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (m3TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3TRQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3ISMD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3LODO))
				request.WithQueryParameter("LODO", m3LODO.Trim());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddPickSftPacLnResponse>(
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
		/// Name AddPickViaPack
		/// Description AddPickViaPackage
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3PRMD">Process Flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3PANR">Package number</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="m3ISMD">Issue/move mode</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3USD1">User defined - 1</param>
		/// <param name="m3UDS2">User defined - 2</param>
		/// <param name="m3USD3">User defined - 3</param>
		/// <param name="m3USD4">User defined - 4</param>
		/// <param name="m3USD5">User defined - 5</param>
		/// <param name="m3LODO">Loading platform</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPickViaPackResponse></returns>
		/// <exception cref="M3Exception<AddPickViaPackResponse>"></exception>
		public async Task<M3Response<AddPickViaPackResponse>> AddPickViaPack(
			string m3WHLO, 
			string m3E0PA, 
			string m3E065, 
			decimal m3DLIX, 
			string m3PRMD = null, 
			int? m3CONO = null, 
			string m3MSGN = null, 
			string m3PMSN = null, 
			string m3PANR = null, 
			string m3SSCC = null, 
			int? m3ISMD = null, 
			string m3TWSL = null, 
			DateTime? m3RPDT = null, 
			int? m3RPTM = null, 
			string m3USD1 = null, 
			string m3UDS2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			string m3LODO = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddPickViaPack",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PANR))
				request.WithQueryParameter("PANR", m3PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());
			if (m3ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3ISMD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3UDS2))
				request.WithQueryParameter("UDS2", m3UDS2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3LODO))
				request.WithQueryParameter("LODO", m3LODO.Trim());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddPickViaPackResponse>(
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
		/// Name AddPickViaRepNo
		/// Description Add Pick list via Reporting number
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3PLRN">Reporting number - pick line (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3QTYP">Quantity Picked</param>
		/// <param name="m3QTYO">Quantity to be picked</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="m3OEND">Flagged as completed</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3AMKO">Number of packages</param>
		/// <param name="m3PARE">Packaging reference</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="m3ISMD">Issue/move mode</param>
		/// <param name="m3GRWE">Gross weight</param>
		/// <param name="m3VOM3">Volume</param>
		/// <param name="m3FRCP">Free Capacity unit</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3LODO">Loading platform</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPickViaRepNoResponse></returns>
		/// <exception cref="M3Exception<AddPickViaRepNoResponse>"></exception>
		public async Task<M3Response<AddPickViaRepNoResponse>> AddPickViaRepNo(
			string m3WHLO, 
			string m3E0PA, 
			string m3E065, 
			decimal m3PLRN, 
			string m3PRMD = null, 
			int? m3CONO = null, 
			string m3MSGN = null, 
			string m3PACN = null, 
			int? m3MSLN = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			decimal? m3QTYP = null, 
			decimal? m3QTYO = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			string m3TWSL = null, 
			int? m3OEND = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			DateTime? m3RPDT = null, 
			string m3PACT = null, 
			int? m3AMKO = null, 
			string m3PARE = null, 
			string m3SSCC = null, 
			int? m3ISMD = null, 
			decimal? m3GRWE = null, 
			decimal? m3VOM3 = null, 
			decimal? m3FRCP = null, 
			int? m3RPTM = null, 
			decimal? m3CAWE = null, 
			string m3PMSN = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			string m3LODO = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddPickViaRepNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("PLRN", m3PLRN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QTYP.HasValue)
				request.WithQueryParameter("QTYP", m3QTYP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QTYO.HasValue)
				request.WithQueryParameter("QTYO", m3QTYO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (m3AMKO.HasValue)
				request.WithQueryParameter("AMKO", m3AMKO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PARE))
				request.WithQueryParameter("PARE", m3PARE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());
			if (m3ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3ISMD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOM3.HasValue)
				request.WithQueryParameter("VOM3", m3VOM3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRCP.HasValue)
				request.WithQueryParameter("FRCP", m3FRCP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3LODO))
				request.WithQueryParameter("LODO", m3LODO.Trim());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddPickViaRepNoResponse>(
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
		/// Name AddPickViaSblot
		/// Description AddPickViaSblot
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3PLRN">Reporting number - pick line (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3BANT">Reference sublot ID</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="m3OEND">Flagged as completed</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3ISMD">Issue/move mode</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPickViaSblotResponse></returns>
		/// <exception cref="M3Exception<AddPickViaSblotResponse>"></exception>
		public async Task<M3Response<AddPickViaSblotResponse>> AddPickViaSblot(
			string m3WHLO, 
			string m3E0PA, 
			string m3E065, 
			decimal m3PLRN, 
			string m3PRMD = null, 
			int? m3CONO = null, 
			string m3MSGN = null, 
			string m3PACN = null, 
			int? m3MSLN = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3BANT = null, 
			string m3TWSL = null, 
			int? m3OEND = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			int? m3ISMD = null, 
			DateTime? m3RPDT = null, 
			int? m3RPTM = null, 
			string m3PMSN = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			string m3PACT = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddPickViaSblot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("PLRN", m3PLRN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BANT))
				request.WithQueryParameter("BANT", m3BANT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3ISMD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddPickViaSblotResponse>(
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
		/// Name AddPutAwayConf
		/// Description Two Step Put Away
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3PANO">Put-away number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3RVQA">Received quantity</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias category</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPutAwayConfResponse></returns>
		/// <exception cref="M3Exception<AddPutAwayConfResponse>"></exception>
		public async Task<M3Response<AddPutAwayConfResponse>> AddPutAwayConf(
			string m3WHLO, 
			string m3E0PA, 
			string m3E065, 
			string m3PRMD = null, 
			int? m3CONO = null, 
			string m3MSGN = null, 
			int? m3MSLN = null, 
			string m3PACN = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3ITNO = null, 
			string m3ORCA = null, 
			string m3RIDN = null, 
			int? m3RIDL = null, 
			long? m3PANO = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			decimal? m3RVQA = null, 
			long? m3REPN = null, 
			string m3WHSL = null, 
			string m3TWSL = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			string m3PMSN = null, 
			int? m3RIDX = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddPutAwayConf",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PANO.HasValue)
				request.WithQueryParameter("PANO", m3PANO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3RVQA.HasValue)
				request.WithQueryParameter("RVQA", m3RVQA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddPutAwayConfResponse>(
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
		/// Name AddPutAwayPack
		/// Description AddPutAwayPack
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3TWSL">To Location</param>
		/// <param name="m3SPNO">Shipment package number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPutAwayPackResponse></returns>
		/// <exception cref="M3Exception<AddPutAwayPackResponse>"></exception>
		public async Task<M3Response<AddPutAwayPackResponse>> AddPutAwayPack(
			string m3WHLO, 
			string m3E0PA, 
			string m3E065, 
			string m3PRMD = null, 
			int? m3CONO = null, 
			string m3MSGN = null, 
			string m3PACN = null, 
			string m3TWSL = null, 
			string m3SPNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddPutAwayPack",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPNO))
				request.WithQueryParameter("SPNO", m3SPNO.Trim());

			// Execute the request
			var result = await Execute<AddPutAwayPackResponse>(
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
		/// Name AddROPick
		/// Description Add Requisition Order Pick
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3RIDL">Order line (Required)</param>
		/// <param name="m3RIDI">Order index (Required)</param>
		/// <param name="m3PLSX">Picking list suffix (Required)</param>
		/// <param name="m3PRFL">Process Flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3QTYP">Quantity Picked</param>
		/// <param name="m3QTYO">Quantity to be picked</param>
		/// <param name="m3USD1">User Defined 1</param>
		/// <param name="m3USD2">User defined 2</param>
		/// <param name="m3USD3">User defined 3</param>
		/// <param name="m3USD4">User defined 4</param>
		/// <param name="m3USD5">User defined 5</param>
		/// <param name="m3PLRN">Reporting number - pick line</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3AMKO">Number of packages</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="m3OEND">Flagged as completed</param>
		/// <param name="m3PARE">Packaging reference</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="m3ISMD">Issue/move mode</param>
		/// <param name="m3BREF">Lot Reference 1</param>
		/// <param name="m3BRE2">Lot Reference 2</param>
		/// <param name="m3GRWE">Gross weight</param>
		/// <param name="m3VOM3">Volume</param>
		/// <param name="m3FRCP">Free capacity unit</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3LODO">Loading platform</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddROPickResponse></returns>
		/// <exception cref="M3Exception<AddROPickResponse>"></exception>
		public async Task<M3Response<AddROPickResponse>> AddROPick(
			string m3WHLO, 
			string m3E0PA, 
			string m3E065, 
			string m3RIDN, 
			int m3RIDL, 
			decimal m3RIDI, 
			int m3PLSX, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSGN = null, 
			string m3PACN = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3ADID = null, 
			string m3ITNO = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			decimal? m3QTYP = null, 
			decimal? m3QTYO = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			decimal? m3PLRN = null, 
			DateTime? m3RPDT = null, 
			decimal? m3CAWE = null, 
			string m3PACT = null, 
			int? m3AMKO = null, 
			string m3PMSN = null, 
			string m3TWSL = null, 
			int? m3OEND = null, 
			string m3PARE = null, 
			string m3SSCC = null, 
			int? m3ISMD = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			decimal? m3GRWE = null, 
			decimal? m3VOM3 = null, 
			decimal? m3FRCP = null, 
			int? m3RPTM = null, 
			int? m3RIDX = null, 
			string m3LODO = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddROPick",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("RIDN", m3RIDN.Trim())
				.WithQueryParameter("RIDL", m3RIDL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RIDI", m3RIDI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLSX", m3PLSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3QTYP.HasValue)
				request.WithQueryParameter("QTYP", m3QTYP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QTYO.HasValue)
				request.WithQueryParameter("QTYO", m3QTYO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3PLRN.HasValue)
				request.WithQueryParameter("PLRN", m3PLRN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (m3AMKO.HasValue)
				request.WithQueryParameter("AMKO", m3AMKO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PARE))
				request.WithQueryParameter("PARE", m3PARE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());
			if (m3ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3ISMD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOM3.HasValue)
				request.WithQueryParameter("VOM3", m3VOM3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRCP.HasValue)
				request.WithQueryParameter("FRCP", m3FRCP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LODO))
				request.WithQueryParameter("LODO", m3LODO.Trim());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddROPickResponse>(
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
		/// Name AddROReceipt
		/// Description Add Requisition Order Receipt
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3QTY">Quantity Received (Required)</param>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3RIDL">Order line (Required)</param>
		/// <param name="m3RIDI">Order index (Required)</param>
		/// <param name="m3PRFL">Process Flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3RIDO">Order operation</param>
		/// <param name="m3USD1">User Defined 1</param>
		/// <param name="m3USD2">User defined 2</param>
		/// <param name="m3USD3">User defined 3</param>
		/// <param name="m3USD4">User defined 4</param>
		/// <param name="m3USD5">User defined 5</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3BREF">Lot Reference 1</param>
		/// <param name="m3BRE2">Lot Reference 2</param>
		/// <param name="m3OEND">Flagged as completed</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddROReceiptResponse></returns>
		/// <exception cref="M3Exception<AddROReceiptResponse>"></exception>
		public async Task<M3Response<AddROReceiptResponse>> AddROReceipt(
			string m3WHLO, 
			string m3E0PA, 
			string m3E065, 
			decimal m3QTY, 
			string m3RIDN, 
			int m3RIDL, 
			decimal m3RIDI, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSGN = null, 
			string m3PACN = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3ADID = null, 
			string m3ITNO = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			int? m3RIDO = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			decimal? m3CAWE = null, 
			string m3PMSN = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			int? m3OEND = null, 
			int? m3RIDX = null, 
			DateTime? m3RPDT = null, 
			int? m3RPTM = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddROReceipt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("QTY", m3QTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RIDN", m3RIDN.Trim())
				.WithQueryParameter("RIDL", m3RIDL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RIDI", m3RIDI.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3RIDO.HasValue)
				request.WithQueryParameter("RIDO", m3RIDO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddROReceiptResponse>(
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
		/// Name AddReplPick
		/// Description Add Replenishment Order Pick
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3RIDL">Order line (Required)</param>
		/// <param name="m3RIDI">Order index (Required)</param>
		/// <param name="m3PLSX">Picking list suffix (Required)</param>
		/// <param name="m3PRFL">Process Flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3QTYP">Quantity Picked</param>
		/// <param name="m3QTYO">Quantity to be picked</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3USD1">User Defined 1</param>
		/// <param name="m3USD2">User defined 2</param>
		/// <param name="m3USD3">User defined 3</param>
		/// <param name="m3USD4">User defined 4</param>
		/// <param name="m3USD5">User defined 5</param>
		/// <param name="m3PLRN">Reporting number - pick line</param>
		/// <param name="m3OEND">Flagged as completed</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3PARE">Packaging reference</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="m3ISMD">Issue/move mode</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3LODO">Loading platform</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddReplPickResponse></returns>
		/// <exception cref="M3Exception<AddReplPickResponse>"></exception>
		public async Task<M3Response<AddReplPickResponse>> AddReplPick(
			string m3WHLO, 
			string m3E0PA, 
			string m3E065, 
			string m3RIDN, 
			int m3RIDL, 
			decimal m3RIDI, 
			int m3PLSX, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSGN = null, 
			string m3PACN = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3ADID = null, 
			string m3ITNO = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			decimal? m3QTYP = null, 
			decimal? m3QTYO = null, 
			int? m3RIDX = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			decimal? m3PLRN = null, 
			int? m3OEND = null, 
			DateTime? m3RPDT = null, 
			decimal? m3CAWE = null, 
			string m3PMSN = null, 
			string m3PARE = null, 
			string m3SSCC = null, 
			int? m3ISMD = null, 
			int? m3RPTM = null, 
			string m3LODO = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddReplPick",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("RIDN", m3RIDN.Trim())
				.WithQueryParameter("RIDL", m3RIDL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RIDI", m3RIDI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLSX", m3PLSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3QTYP.HasValue)
				request.WithQueryParameter("QTYP", m3QTYP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QTYO.HasValue)
				request.WithQueryParameter("QTYO", m3QTYO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3PLRN.HasValue)
				request.WithQueryParameter("PLRN", m3PLRN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PARE))
				request.WithQueryParameter("PARE", m3PARE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());
			if (m3ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3ISMD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LODO))
				request.WithQueryParameter("LODO", m3LODO.Trim());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddReplPickResponse>(
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
		/// Name AddSubLine
		/// Description AddSubLIne
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3PACN">Package number (Required)</param>
		/// <param name="m3MSLN">Message line number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SUBL">Subline number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3QLFR">Qualifier</param>
		/// <param name="m3BANT">Reference sublot ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSubLine(
			string m3MSGN, 
			string m3PACN, 
			int m3MSLN, 
			int? m3CONO = null, 
			int? m3SUBL = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			decimal? m3CAWE = null, 
			string m3QLFR = null, 
			string m3BANT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddSubLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));
			if (string.IsNullOrWhiteSpace(m3PACN))
				throw new ArgumentNullException(nameof(m3PACN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim())
				.WithQueryParameter("PACN", m3PACN.Trim())
				.WithQueryParameter("MSLN", m3MSLN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUBL.HasValue)
				request.WithQueryParameter("SUBL", m3SUBL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QLFR))
				request.WithQueryParameter("QLFR", m3QLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANT))
				request.WithQueryParameter("BANT", m3BANT.Trim());

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
		/// Name AddTransNotify
		/// Description Add transport notification
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3PRFL">Process flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3DNDT">Delivery note date</param>
		/// <param name="m3EDFR">EDI reference</param>
		/// <param name="m3PUSN">Delivery note reference</param>
		/// <param name="m3SORN">Supplier order number</param>
		/// <param name="m3E0B4">Transport identity - departure</param>
		/// <param name="m3E0BH">Trailer registration number</param>
		/// <param name="m3BOLN">Bill of lading</param>
		/// <param name="m3FWRF">Forwarding agent reference</param>
		/// <param name="m3SHD4">Requested departure date</param>
		/// <param name="m3ARDT">Arrival date</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3TEDL">Delivery terms</param>
		/// <param name="m3TFNO">Facsimile transmission number</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddTransNotifyResponse></returns>
		/// <exception cref="M3Exception<AddTransNotifyResponse>"></exception>
		public async Task<M3Response<AddTransNotifyResponse>> AddTransNotify(
			string m3WHLO, 
			string m3E0PA, 
			string m3E065, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSGN = null, 
			string m3SUNO = null, 
			string m3SUDO = null, 
			DateTime? m3DNDT = null, 
			string m3EDFR = null, 
			string m3PUSN = null, 
			string m3SORN = null, 
			string m3E0B4 = null, 
			string m3E0BH = null, 
			string m3BOLN = null, 
			string m3FWRF = null, 
			DateTime? m3SHD4 = null, 
			DateTime? m3ARDT = null, 
			string m3MODL = null, 
			string m3TEDL = null, 
			string m3TFNO = null, 
			string m3PMSN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddTransNotify",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (m3DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3DNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3EDFR))
				request.WithQueryParameter("EDFR", m3EDFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PUSN))
				request.WithQueryParameter("PUSN", m3PUSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SORN))
				request.WithQueryParameter("SORN", m3SORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0B4))
				request.WithQueryParameter("E0B4", m3E0B4.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0BH))
				request.WithQueryParameter("E0BH", m3E0BH.Trim());
			if (!string.IsNullOrWhiteSpace(m3BOLN))
				request.WithQueryParameter("BOLN", m3BOLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FWRF))
				request.WithQueryParameter("FWRF", m3FWRF.Trim());
			if (m3SHD4.HasValue)
				request.WithQueryParameter("SHD4", m3SHD4.Value.ToM3String());
			if (m3ARDT.HasValue)
				request.WithQueryParameter("ARDT", m3ARDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());

			// Execute the request
			var result = await Execute<AddTransNotifyResponse>(
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
		/// Name AddWOPick
		/// Description Add Work Order Pick
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3RIDL">Order line (Required)</param>
		/// <param name="m3RIDO">Order operation (Required)</param>
		/// <param name="m3DLIX">Delivery index (Required)</param>
		/// <param name="m3PLSX">Picking list suffix (Required)</param>
		/// <param name="m3PRFL">Process Flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3QTYP">Quantity Picked</param>
		/// <param name="m3QTYO">Quantity to be picked</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3USD1">User Defined 1</param>
		/// <param name="m3USD2">User defined 2</param>
		/// <param name="m3USD3">User defined 3</param>
		/// <param name="m3USD4">User defined 4</param>
		/// <param name="m3USD5">User defined 5</param>
		/// <param name="m3PLRN">Reporting number - pick line</param>
		/// <param name="m3OEND">Flagged as completed</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="m3PARE">Packaging reference</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="m3ISMD">Issue/move mode</param>
		/// <param name="m3GRWE">Gross weight</param>
		/// <param name="m3VOM3">Volume</param>
		/// <param name="m3FRCP">Free capacity</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3AMKO">Number of packages</param>
		/// <param name="m3LODO">Loading platform</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddWOPickResponse></returns>
		/// <exception cref="M3Exception<AddWOPickResponse>"></exception>
		public async Task<M3Response<AddWOPickResponse>> AddWOPick(
			string m3WHLO, 
			string m3E0PA, 
			string m3E065, 
			string m3RIDN, 
			int m3RIDL, 
			int m3RIDO, 
			decimal m3DLIX, 
			int m3PLSX, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSGN = null, 
			string m3PACN = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3ADID = null, 
			string m3ITNO = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			decimal? m3QTYP = null, 
			decimal? m3QTYO = null, 
			int? m3RIDX = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			decimal? m3PLRN = null, 
			int? m3OEND = null, 
			DateTime? m3RPDT = null, 
			decimal? m3CAWE = null, 
			string m3PMSN = null, 
			string m3TWSL = null, 
			string m3PARE = null, 
			string m3SSCC = null, 
			int? m3ISMD = null, 
			decimal? m3GRWE = null, 
			decimal? m3VOM3 = null, 
			decimal? m3FRCP = null, 
			int? m3RPTM = null, 
			string m3PACT = null, 
			int? m3AMKO = null, 
			string m3LODO = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddWOPick",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("RIDN", m3RIDN.Trim())
				.WithQueryParameter("RIDL", m3RIDL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RIDO", m3RIDO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLSX", m3PLSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3QTYP.HasValue)
				request.WithQueryParameter("QTYP", m3QTYP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QTYO.HasValue)
				request.WithQueryParameter("QTYO", m3QTYO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3PLRN.HasValue)
				request.WithQueryParameter("PLRN", m3PLRN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3PARE))
				request.WithQueryParameter("PARE", m3PARE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());
			if (m3ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3ISMD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOM3.HasValue)
				request.WithQueryParameter("VOM3", m3VOM3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRCP.HasValue)
				request.WithQueryParameter("FRCP", m3FRCP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (m3AMKO.HasValue)
				request.WithQueryParameter("AMKO", m3AMKO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LODO))
				request.WithQueryParameter("LODO", m3LODO.Trim());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddWOPickResponse>(
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
		/// Name AddWhsHead
		/// Description Add Warehouse Integration Header
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3QLFR">Qualifier (Required)</param>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E0PB">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3E0IO">Message direction</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3CHGD">Date changed</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3TRSL">Lowest status - stock transaction</param>
		/// <param name="m3TRSH">Highest status - stock transaction</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3ADTY">Internal address type</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3E0QA">Code list qualifier</param>
		/// <param name="m3E0QB">Code list qualifier</param>
		/// <param name="m3DONR">Document number</param>
		/// <param name="m3E007">Qualifier</param>
		/// <param name="m3E014">Routing address</param>
		/// <param name="m3E026">Application reference</param>
		/// <param name="m3E035">Test indicator</param>
		/// <param name="m3E052">Message version</param>
		/// <param name="m3E054">Message release</param>
		/// <param name="m3E051">Controlling organization</param>
		/// <param name="m3E057">Organization assigned code</param>
		/// <param name="m3DLSP">Delivery specification</param>
		/// <param name="m3EDFR">EDI reference</param>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDO">Order operation</param>
		/// <param name="m3RIDI">Order index</param>
		/// <param name="m3PLSX">Picking list suffix</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3DNDT">Delivery note date</param>
		/// <param name="m3PUSN">Delivery note reference</param>
		/// <param name="m3GRWE">Gross weight</param>
		/// <param name="m3VOL3">Volume</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SUTY">Supplier type</param>
		/// <param name="m3SORN">Supplier order number</param>
		/// <param name="m3DPNR">Delivery schedule</param>
		/// <param name="m3RSAG">Delivery contract number</param>
		/// <param name="m3DLDT">Planned delivery date</param>
		/// <param name="m3DLTM">Time of delivery</param>
		/// <param name="m3SHD4">Actual ship date</param>
		/// <param name="m3SHTM">Actual ship time</param>
		/// <param name="m3RCDT">Last receipt date</param>
		/// <param name="m3RCTM">Last receipt time</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3E0B4">Transport identity - departure</param>
		/// <param name="m3E0BH">Trailer registration number</param>
		/// <param name="m3E0B5">Transport nationality - departure</param>
		/// <param name="m3TEDL">Delivery terms</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3TFNO">Facsimile transmission number</param>
		/// <param name="m3VRNO">VAT registration number</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3DTID">Data identity</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3RGDT">Not used</param>
		/// <param name="m3RGTM">Not used</param>
		/// <param name="m3LMDT">Not used</param>
		/// <param name="m3CHNO">Not used</param>
		/// <param name="m3CHID">Not used</param>
		/// <param name="m3DNTM">Delivery note time</param>
		/// <param name="m3TIZO">Time zone</param>
		/// <param name="m3BOLN">Bill of lading</param>
		/// <param name="m3FWRF">Forwarding agent reference</param>
		/// <param name="m3ARDT">Arrival date</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddWhsHeadResponse></returns>
		/// <exception cref="M3Exception<AddWhsHeadResponse>"></exception>
		public async Task<M3Response<AddWhsHeadResponse>> AddWhsHead(
			string m3WHLO, 
			string m3QLFR, 
			string m3E0PA, 
			string m3E0PB, 
			string m3E065, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3MSGN = null, 
			string m3E0IO = null, 
			string m3FACI = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			DateTime? m3CHGD = null, 
			string m3STAT = null, 
			string m3TRSL = null, 
			string m3TRSH = null, 
			string m3ADID = null, 
			int? m3ADTY = null, 
			string m3PMSN = null, 
			string m3E0QA = null, 
			string m3E0QB = null, 
			string m3DONR = null, 
			string m3E007 = null, 
			string m3E014 = null, 
			string m3E026 = null, 
			int? m3E035 = null, 
			string m3E052 = null, 
			string m3E054 = null, 
			string m3E051 = null, 
			string m3E057 = null, 
			string m3DLSP = null, 
			string m3EDFR = null, 
			string m3ORCA = null, 
			string m3RIDN = null, 
			int? m3RIDO = null, 
			decimal? m3RIDI = null, 
			int? m3PLSX = null, 
			string m3CUNO = null, 
			string m3CUOR = null, 
			string m3SUDO = null, 
			DateTime? m3DNDT = null, 
			string m3PUSN = null, 
			decimal? m3GRWE = null, 
			decimal? m3VOL3 = null, 
			string m3SUNO = null, 
			int? m3SUTY = null, 
			string m3SORN = null, 
			string m3DPNR = null, 
			string m3RSAG = null, 
			DateTime? m3DLDT = null, 
			int? m3DLTM = null, 
			DateTime? m3SHD4 = null, 
			int? m3SHTM = null, 
			DateTime? m3RCDT = null, 
			int? m3RCTM = null, 
			string m3MODL = null, 
			string m3E0B4 = null, 
			string m3E0BH = null, 
			string m3E0B5 = null, 
			string m3TEDL = null, 
			string m3YREF = null, 
			string m3TFNO = null, 
			string m3VRNO = null, 
			string m3RESP = null, 
			decimal? m3DTID = null, 
			decimal? m3TXID = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			DateTime? m3RGDT = null, 
			int? m3RGTM = null, 
			DateTime? m3LMDT = null, 
			int? m3CHNO = null, 
			string m3CHID = null, 
			int? m3DNTM = null, 
			string m3TIZO = null, 
			string m3BOLN = null, 
			string m3FWRF = null, 
			DateTime? m3ARDT = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddWhsHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3QLFR))
				throw new ArgumentNullException(nameof(m3QLFR));
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E0PB))
				throw new ArgumentNullException(nameof(m3E0PB));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("QLFR", m3QLFR.Trim())
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E0PB", m3E0PB.Trim())
				.WithQueryParameter("E065", m3E065.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0IO))
				request.WithQueryParameter("E0IO", m3E0IO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRSL))
				request.WithQueryParameter("TRSL", m3TRSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRSH))
				request.WithQueryParameter("TRSH", m3TRSH.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (m3ADTY.HasValue)
				request.WithQueryParameter("ADTY", m3ADTY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0QA))
				request.WithQueryParameter("E0QA", m3E0QA.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0QB))
				request.WithQueryParameter("E0QB", m3E0QB.Trim());
			if (!string.IsNullOrWhiteSpace(m3DONR))
				request.WithQueryParameter("DONR", m3DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3E007))
				request.WithQueryParameter("E007", m3E007.Trim());
			if (!string.IsNullOrWhiteSpace(m3E014))
				request.WithQueryParameter("E014", m3E014.Trim());
			if (!string.IsNullOrWhiteSpace(m3E026))
				request.WithQueryParameter("E026", m3E026.Trim());
			if (m3E035.HasValue)
				request.WithQueryParameter("E035", m3E035.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3E052))
				request.WithQueryParameter("E052", m3E052.Trim());
			if (!string.IsNullOrWhiteSpace(m3E054))
				request.WithQueryParameter("E054", m3E054.Trim());
			if (!string.IsNullOrWhiteSpace(m3E051))
				request.WithQueryParameter("E051", m3E051.Trim());
			if (!string.IsNullOrWhiteSpace(m3E057))
				request.WithQueryParameter("E057", m3E057.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLSP))
				request.WithQueryParameter("DLSP", m3DLSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDFR))
				request.WithQueryParameter("EDFR", m3EDFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDO.HasValue)
				request.WithQueryParameter("RIDO", m3RIDO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3RIDI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3PLSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (m3DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3DNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PUSN))
				request.WithQueryParameter("PUSN", m3PUSN.Trim());
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3VOL3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3SUTY.HasValue)
				request.WithQueryParameter("SUTY", m3SUTY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SORN))
				request.WithQueryParameter("SORN", m3SORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3DPNR))
				request.WithQueryParameter("DPNR", m3DPNR.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSAG))
				request.WithQueryParameter("RSAG", m3RSAG.Trim());
			if (m3DLDT.HasValue)
				request.WithQueryParameter("DLDT", m3DLDT.Value.ToM3String());
			if (m3DLTM.HasValue)
				request.WithQueryParameter("DLTM", m3DLTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHD4.HasValue)
				request.WithQueryParameter("SHD4", m3SHD4.Value.ToM3String());
			if (m3SHTM.HasValue)
				request.WithQueryParameter("SHTM", m3SHTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RCDT.HasValue)
				request.WithQueryParameter("RCDT", m3RCDT.Value.ToM3String());
			if (m3RCTM.HasValue)
				request.WithQueryParameter("RCTM", m3RCTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0B4))
				request.WithQueryParameter("E0B4", m3E0B4.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0BH))
				request.WithQueryParameter("E0BH", m3E0BH.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0B5))
				request.WithQueryParameter("E0B5", m3E0B5.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3VRNO))
				request.WithQueryParameter("VRNO", m3VRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3DTID.HasValue)
				request.WithQueryParameter("DTID", m3DTID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3RGTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());
			if (m3CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3CHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());
			if (m3DNTM.HasValue)
				request.WithQueryParameter("DNTM", m3DNTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TIZO))
				request.WithQueryParameter("TIZO", m3TIZO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BOLN))
				request.WithQueryParameter("BOLN", m3BOLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FWRF))
				request.WithQueryParameter("FWRF", m3FWRF.Trim());
			if (m3ARDT.HasValue)
				request.WithQueryParameter("ARDT", m3ARDT.Value.ToM3String());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddWhsHeadResponse>(
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
		/// Name AddWhsLine
		/// Description Add Warehouse Integration Line
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3PACN">Package number (Required)</param>
		/// <param name="m3QLFR">Qualifier (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3QLFS">Sequence number</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3CHGD">Date changed</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3RELI">Line number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3DLQT">Delivered quantity - basic U/M</param>
		/// <param name="m3UNIT">Unit of measure</param>
		/// <param name="m3DLQA">Delivered quantity - alternate U/M</param>
		/// <param name="m3ALUN">Alternate U/M</param>
		/// <param name="m3VOL3">Volume</param>
		/// <param name="m3NEWE">Net weight</param>
		/// <param name="m3GRWE">Gross weight</param>
		/// <param name="m3D1QT">Standard quantity</param>
		/// <param name="m3DLSP">Delivery specification</param>
		/// <param name="m3RVQA">Received quantity</param>
		/// <param name="m3PUUN">Purchase order U/M</param>
		/// <param name="m3ALQT">Allocated quantity - basic U/M</param>
		/// <param name="m3PAQT">Packed quantity</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3POCY">Normal potency</param>
		/// <param name="m3OEND">Flagged as completed</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3FLOC">From picking location</param>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="m3TTYP">Stock transaction type</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDO">Order operation</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3RIDI">Order index</param>
		/// <param name="m3PLSX">Picking list suffix</param>
		/// <param name="m3DLIX">Delivery index</param>
		/// <param name="m3DNNO">Delivery note number</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SUTY">Supplier type</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3DNDT">Delivery note date</param>
		/// <param name="m3SITE">Supplier item number</param>
		/// <param name="m3SITD">Supplier item name</param>
		/// <param name="m3PUPR">Purchase price</param>
		/// <param name="m3PPUN">Purchase price U/M</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3PUCD">Purchase price quantity</param>
		/// <param name="m3LNAM">Line amount - order currency</param>
		/// <param name="m3VTCD">VAT code</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3DTID">Data identity</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">Reporting time</param>
		/// <param name="m3RGDT">Not used</param>
		/// <param name="m3RGTM">Not used</param>
		/// <param name="m3LMDT">Not used</param>
		/// <param name="m3CHNO">Not used</param>
		/// <param name="m3CHID">Not used</param>
		/// <param name="m3QCRA">Quality inspection result</param>
		/// <param name="m3SCRE">Rejection reason</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3EXPI">Expiration date</param>
		/// <param name="m3CNDT">Follow-up date</param>
		/// <param name="m3SEDT">Sales date</param>
		/// <param name="m3TRTP">Order type</param>
		/// <param name="m3PLRN">Reporting number - pick line</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="m3ISMD">Issue/move mode</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3MFDT">Manufacturing date</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddWhsLineResponse></returns>
		/// <exception cref="M3Exception<AddWhsLineResponse>"></exception>
		public async Task<M3Response<AddWhsLineResponse>> AddWhsLine(
			string m3WHLO, 
			string m3MSGN, 
			string m3PACN, 
			string m3QLFR, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			int? m3MSLN = null, 
			int? m3QLFS = null, 
			string m3FACI = null, 
			DateTime? m3CHGD = null, 
			string m3STAT = null, 
			string m3ITNO = null, 
			string m3ITDS = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			long? m3REPN = null, 
			int? m3RELI = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			decimal? m3DLQT = null, 
			string m3UNIT = null, 
			decimal? m3DLQA = null, 
			string m3ALUN = null, 
			decimal? m3VOL3 = null, 
			decimal? m3NEWE = null, 
			decimal? m3GRWE = null, 
			decimal? m3D1QT = null, 
			string m3DLSP = null, 
			decimal? m3RVQA = null, 
			string m3PUUN = null, 
			decimal? m3ALQT = null, 
			decimal? m3PAQT = null, 
			decimal? m3CAWE = null, 
			int? m3POCY = null, 
			int? m3OEND = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			string m3FLOC = null, 
			string m3ORCA = null, 
			int? m3TTYP = null, 
			string m3RIDN = null, 
			int? m3RIDO = null, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
			decimal? m3RIDI = null, 
			int? m3PLSX = null, 
			decimal? m3DLIX = null, 
			string m3DNNO = null, 
			string m3CUOR = null, 
			string m3CUNO = null, 
			string m3ADID = null, 
			string m3SUNO = null, 
			int? m3SUTY = null, 
			string m3SUDO = null, 
			DateTime? m3DNDT = null, 
			string m3SITE = null, 
			string m3SITD = null, 
			decimal? m3PUPR = null, 
			string m3PPUN = null, 
			string m3CUCD = null, 
			int? m3PUCD = null, 
			decimal? m3LNAM = null, 
			int? m3VTCD = null, 
			string m3AGNB = null, 
			string m3RESP = null, 
			decimal? m3DTID = null, 
			decimal? m3TXID = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			DateTime? m3RGDT = null, 
			int? m3RGTM = null, 
			DateTime? m3LMDT = null, 
			int? m3CHNO = null, 
			string m3CHID = null, 
			string m3QCRA = null, 
			string m3SCRE = null, 
			string m3BREM = null, 
			DateTime? m3EXPI = null, 
			DateTime? m3CNDT = null, 
			DateTime? m3SEDT = null, 
			string m3TRTP = null, 
			decimal? m3PLRN = null, 
			DateTime? m3RPDT = null, 
			string m3TWSL = null, 
			int? m3ISMD = null, 
			string m3RSCD = null, 
			DateTime? m3MFDT = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddWhsLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));
			if (string.IsNullOrWhiteSpace(m3PACN))
				throw new ArgumentNullException(nameof(m3PACN));
			if (string.IsNullOrWhiteSpace(m3QLFR))
				throw new ArgumentNullException(nameof(m3QLFR));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("MSGN", m3MSGN.Trim())
				.WithQueryParameter("PACN", m3PACN.Trim())
				.WithQueryParameter("QLFR", m3QLFR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QLFS.HasValue)
				request.WithQueryParameter("QLFS", m3QLFS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (m3CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RELI.HasValue)
				request.WithQueryParameter("RELI", m3RELI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLQT.HasValue)
				request.WithQueryParameter("DLQT", m3DLQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3UNIT))
				request.WithQueryParameter("UNIT", m3UNIT.Trim());
			if (m3DLQA.HasValue)
				request.WithQueryParameter("DLQA", m3DLQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALUN))
				request.WithQueryParameter("ALUN", m3ALUN.Trim());
			if (m3VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3VOL3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3NEWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3D1QT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DLSP))
				request.WithQueryParameter("DLSP", m3DLSP.Trim());
			if (m3RVQA.HasValue)
				request.WithQueryParameter("RVQA", m3RVQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PUUN))
				request.WithQueryParameter("PUUN", m3PUUN.Trim());
			if (m3ALQT.HasValue)
				request.WithQueryParameter("ALQT", m3ALQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PAQT.HasValue)
				request.WithQueryParameter("PAQT", m3PAQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POCY.HasValue)
				request.WithQueryParameter("POCY", m3POCY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLOC))
				request.WithQueryParameter("FLOC", m3FLOC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());
			if (m3TTYP.HasValue)
				request.WithQueryParameter("TTYP", m3TTYP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDO.HasValue)
				request.WithQueryParameter("RIDO", m3RIDO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3RIDI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3PLSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DNNO))
				request.WithQueryParameter("DNNO", m3DNNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3SUTY.HasValue)
				request.WithQueryParameter("SUTY", m3SUTY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (m3DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3DNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3SITE))
				request.WithQueryParameter("SITE", m3SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SITD))
				request.WithQueryParameter("SITD", m3SITD.Trim());
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PPUN))
				request.WithQueryParameter("PPUN", m3PPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3PUCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LNAM.HasValue)
				request.WithQueryParameter("LNAM", m3LNAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3VTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3DTID.HasValue)
				request.WithQueryParameter("DTID", m3DTID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3RGTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());
			if (m3CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3CHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3QCRA))
				request.WithQueryParameter("QCRA", m3QCRA.Trim());
			if (!string.IsNullOrWhiteSpace(m3SCRE))
				request.WithQueryParameter("SCRE", m3SCRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (m3EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3EXPI.Value.ToM3String());
			if (m3CNDT.HasValue)
				request.WithQueryParameter("CNDT", m3CNDT.Value.ToM3String());
			if (m3SEDT.HasValue)
				request.WithQueryParameter("SEDT", m3SEDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TRTP))
				request.WithQueryParameter("TRTP", m3TRTP.Trim());
			if (m3PLRN.HasValue)
				request.WithQueryParameter("PLRN", m3PLRN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (m3ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3ISMD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (m3MFDT.HasValue)
				request.WithQueryParameter("MFDT", m3MFDT.Value.ToM3String());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddWhsLineResponse>(
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
		/// Name AddWhsPack
		/// Description Add Warehouse Integration Package
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3QLFR">Qualifier (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3CHGD">Date changed</param>
		/// <param name="m3PARE">Package reference</param>
		/// <param name="m3DIPA">Disconnected package</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3DNNO">Delivery note number</param>
		/// <param name="m3DNDT">Delivery note date</param>
		/// <param name="m3TRSH">Highest status - stock transaction</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3TRSL">Lowest status - stock transaction</param>
		/// <param name="m3PACO">Package level</param>
		/// <param name="m3PACU">Bulk package</param>
		/// <param name="m3PACC">Included in package number</param>
		/// <param name="m3AMKO">Number of packages</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3PACK">Package type</param>
		/// <param name="m3TEPA">Packaging terms</param>
		/// <param name="m3SORT">Sort value</param>
		/// <param name="m3DLRM">Remark</param>
		/// <param name="m3DLMO">Goods mark Odette standard</param>
		/// <param name="m3DLSP">Delivery specification</param>
		/// <param name="m3VOM3">Volume</param>
		/// <param name="m3NEWE">Net weight</param>
		/// <param name="m3GRWE">Gross weight</param>
		/// <param name="m3GRW3">Included gross weight</param>
		/// <param name="m3GRW4">Manual gross weight</param>
		/// <param name="m3GRW5">Included net weight</param>
		/// <param name="m3D1QT">Standard quantity</param>
		/// <param name="m3VOMT">Weight</param>
		/// <param name="m3PACL">Package length</param>
		/// <param name="m3PACW">Package width</param>
		/// <param name="m3PACH">Package height</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3SUTY">Supplier type</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3DTID">Data identity</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3RGDT">Not used!</param>
		/// <param name="m3RGTM">Not used!</param>
		/// <param name="m3LMDT">Not used!</param>
		/// <param name="m3CHNO">Not used!</param>
		/// <param name="m3CHID">Not used!</param>
		/// <param name="m3ROUT">Route</param>
		/// <param name="m3RODN">Route departure</param>
		/// <param name="m3CONN">Shipment</param>
		/// <param name="m3DSDT">Departure date</param>
		/// <param name="m3DSHM">Departure time</param>
		/// <param name="m3CDEL">Changed delivery</param>
		/// <param name="m3NDLX">New delivery number</param>
		/// <param name="m3FRCP">Capacity - free capacity unit</param>
		/// <param name="m3PPNB">Pre-pack number</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddWhsPackResponse></returns>
		/// <exception cref="M3Exception<AddWhsPackResponse>"></exception>
		public async Task<M3Response<AddWhsPackResponse>> AddWhsPack(
			string m3WHLO, 
			string m3MSGN, 
			string m3QLFR, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3PACN = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			DateTime? m3CHGD = null, 
			string m3PARE = null, 
			int? m3DIPA = null, 
			string m3SUDO = null, 
			string m3DNNO = null, 
			DateTime? m3DNDT = null, 
			string m3TRSH = null, 
			string m3STAT = null, 
			string m3TRSL = null, 
			int? m3PACO = null, 
			int? m3PACU = null, 
			string m3PACC = null, 
			int? m3AMKO = null, 
			string m3PACT = null, 
			string m3PACK = null, 
			string m3TEPA = null, 
			string m3SORT = null, 
			string m3DLRM = null, 
			string m3DLMO = null, 
			string m3DLSP = null, 
			decimal? m3VOM3 = null, 
			decimal? m3NEWE = null, 
			decimal? m3GRWE = null, 
			decimal? m3GRW3 = null, 
			decimal? m3GRW4 = null, 
			decimal? m3GRW5 = null, 
			decimal? m3D1QT = null, 
			decimal? m3VOMT = null, 
			int? m3PACL = null, 
			int? m3PACW = null, 
			int? m3PACH = null, 
			string m3SSCC = null, 
			string m3WHSL = null, 
			string m3CUNO = null, 
			string m3ADID = null, 
			int? m3SUTY = null, 
			string m3SUNO = null, 
			string m3RESP = null, 
			decimal? m3DTID = null, 
			decimal? m3TXID = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			DateTime? m3RGDT = null, 
			int? m3RGTM = null, 
			DateTime? m3LMDT = null, 
			int? m3CHNO = null, 
			string m3CHID = null, 
			string m3ROUT = null, 
			int? m3RODN = null, 
			int? m3CONN = null, 
			DateTime? m3DSDT = null, 
			int? m3DSHM = null, 
			int? m3CDEL = null, 
			decimal? m3NDLX = null, 
			decimal? m3FRCP = null, 
			string m3PPNB = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddWhsPack",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));
			if (string.IsNullOrWhiteSpace(m3QLFR))
				throw new ArgumentNullException(nameof(m3QLFR));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("MSGN", m3MSGN.Trim())
				.WithQueryParameter("QLFR", m3QLFR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PARE))
				request.WithQueryParameter("PARE", m3PARE.Trim());
			if (m3DIPA.HasValue)
				request.WithQueryParameter("DIPA", m3DIPA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DNNO))
				request.WithQueryParameter("DNNO", m3DNNO.Trim());
			if (m3DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3DNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TRSH))
				request.WithQueryParameter("TRSH", m3TRSH.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRSL))
				request.WithQueryParameter("TRSL", m3TRSL.Trim());
			if (m3PACO.HasValue)
				request.WithQueryParameter("PACO", m3PACO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PACU.HasValue)
				request.WithQueryParameter("PACU", m3PACU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PACC))
				request.WithQueryParameter("PACC", m3PACC.Trim());
			if (m3AMKO.HasValue)
				request.WithQueryParameter("AMKO", m3AMKO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACK))
				request.WithQueryParameter("PACK", m3PACK.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3SORT))
				request.WithQueryParameter("SORT", m3SORT.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLRM))
				request.WithQueryParameter("DLRM", m3DLRM.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLMO))
				request.WithQueryParameter("DLMO", m3DLMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLSP))
				request.WithQueryParameter("DLSP", m3DLSP.Trim());
			if (m3VOM3.HasValue)
				request.WithQueryParameter("VOM3", m3VOM3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3NEWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRW3.HasValue)
				request.WithQueryParameter("GRW3", m3GRW3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRW4.HasValue)
				request.WithQueryParameter("GRW4", m3GRW4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRW5.HasValue)
				request.WithQueryParameter("GRW5", m3GRW5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3D1QT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOMT.HasValue)
				request.WithQueryParameter("VOMT", m3VOMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PACL.HasValue)
				request.WithQueryParameter("PACL", m3PACL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PACW.HasValue)
				request.WithQueryParameter("PACW", m3PACW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PACH.HasValue)
				request.WithQueryParameter("PACH", m3PACH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (m3SUTY.HasValue)
				request.WithQueryParameter("SUTY", m3SUTY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3DTID.HasValue)
				request.WithQueryParameter("DTID", m3DTID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3RGTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());
			if (m3CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3CHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ROUT))
				request.WithQueryParameter("ROUT", m3ROUT.Trim());
			if (m3RODN.HasValue)
				request.WithQueryParameter("RODN", m3RODN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CONN.HasValue)
				request.WithQueryParameter("CONN", m3CONN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSDT.HasValue)
				request.WithQueryParameter("DSDT", m3DSDT.Value.ToM3String());
			if (m3DSHM.HasValue)
				request.WithQueryParameter("DSHM", m3DSHM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CDEL.HasValue)
				request.WithQueryParameter("CDEL", m3CDEL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NDLX.HasValue)
				request.WithQueryParameter("NDLX", m3NDLX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRCP.HasValue)
				request.WithQueryParameter("FRCP", m3FRCP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PPNB))
				request.WithQueryParameter("PPNB", m3PPNB.Trim());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddWhsPackResponse>(
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
		/// Name ChgSubLine
		/// Description ChgSubLine
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3PACN">Package number (Required)</param>
		/// <param name="m3MSLN">Message line number (Required)</param>
		/// <param name="m3SUBL">Subline number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3QLFR">Qualifier</param>
		/// <param name="m3BANT">Reference sublot ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgSubLine(
			string m3MSGN, 
			string m3PACN, 
			int m3MSLN, 
			int m3SUBL, 
			int? m3CONO = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			decimal? m3CAWE = null, 
			string m3QLFR = null, 
			string m3BANT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgSubLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));
			if (string.IsNullOrWhiteSpace(m3PACN))
				throw new ArgumentNullException(nameof(m3PACN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim())
				.WithQueryParameter("PACN", m3PACN.Trim())
				.WithQueryParameter("MSLN", m3MSLN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SUBL", m3SUBL.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QLFR))
				request.WithQueryParameter("QLFR", m3QLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANT))
				request.WithQueryParameter("BANT", m3BANT.Trim());

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
		/// Name ChgWhsHead
		/// Description Change Warehouse Integration Header
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3E0IO">Message direction</param>
		/// <param name="m3QLFR">Qualifier</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3CHGD">Date changed</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3TRSL">Lowest status - stock transaction</param>
		/// <param name="m3TRSH">Highest status - stock transaction</param>
		/// <param name="m3ADTY">Internal address type</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3E0PA">Partner</param>
		/// <param name="m3E0QA">Code list qualifier</param>
		/// <param name="m3E0PB">Partner</param>
		/// <param name="m3E0QB">Code list qualifier</param>
		/// <param name="m3DONR">Document number</param>
		/// <param name="m3E007">Qualifier</param>
		/// <param name="m3E014">Routing address</param>
		/// <param name="m3E026">Application reference</param>
		/// <param name="m3E035">Test indicator</param>
		/// <param name="m3E065">Message type</param>
		/// <param name="m3E052">Message version</param>
		/// <param name="m3E054">Message release</param>
		/// <param name="m3E051">Controlling organization</param>
		/// <param name="m3E057">Organization assigned code</param>
		/// <param name="m3DLSP">Delivery specification</param>
		/// <param name="m3EDFR">EDI reference</param>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDO">Order operation</param>
		/// <param name="m3RIDI">Order index</param>
		/// <param name="m3PLSX">Picking list suffix</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3DNDT">Delivery note date</param>
		/// <param name="m3PUSN">Delivery note reference</param>
		/// <param name="m3GRWE">Gross weight</param>
		/// <param name="m3VOL3">Volume</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SUTY">Supplier type</param>
		/// <param name="m3SORN">Supplier order number</param>
		/// <param name="m3DPNR">Delivery schedule</param>
		/// <param name="m3RSAG">Delivery contract number</param>
		/// <param name="m3DLDT">Planned delivery date</param>
		/// <param name="m3DLTM">Time of delivery</param>
		/// <param name="m3SHD4">Actual ship date</param>
		/// <param name="m3SHTM">Actual ship time</param>
		/// <param name="m3RCDT">Last receipt date</param>
		/// <param name="m3RCTM">Last receipt time</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3E0B4">Transport identity - departure</param>
		/// <param name="m3E0BH">Trailer registration number</param>
		/// <param name="m3E0B5">Transport nationality - departure</param>
		/// <param name="m3TEDL">Delivery terms</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3TFNO">Facsimile transmission number</param>
		/// <param name="m3VRNO">VAT registration number</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3DTID">Data identity</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3RGDT">Not used!</param>
		/// <param name="m3RGTM">Not used!</param>
		/// <param name="m3LMDT">Not used!</param>
		/// <param name="m3CHNO">Not used!</param>
		/// <param name="m3CHID">Not used!</param>
		/// <param name="m3DNTM">Delivery note time</param>
		/// <param name="m3BOLN">Bill of lading</param>
		/// <param name="m3FWRF">Forwarding agent reference</param>
		/// <param name="m3ARDT">Arrival date</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgWhsHead(
			string m3MSGN, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3WHLO = null, 
			string m3E0IO = null, 
			string m3QLFR = null, 
			string m3FACI = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			DateTime? m3CHGD = null, 
			string m3STAT = null, 
			string m3TRSL = null, 
			string m3TRSH = null, 
			int? m3ADTY = null, 
			string m3ADID = null, 
			string m3PMSN = null, 
			string m3E0PA = null, 
			string m3E0QA = null, 
			string m3E0PB = null, 
			string m3E0QB = null, 
			string m3DONR = null, 
			string m3E007 = null, 
			string m3E014 = null, 
			string m3E026 = null, 
			int? m3E035 = null, 
			string m3E065 = null, 
			string m3E052 = null, 
			string m3E054 = null, 
			string m3E051 = null, 
			string m3E057 = null, 
			string m3DLSP = null, 
			string m3EDFR = null, 
			string m3ORCA = null, 
			string m3RIDN = null, 
			int? m3RIDO = null, 
			decimal? m3RIDI = null, 
			int? m3PLSX = null, 
			string m3CUNO = null, 
			string m3CUOR = null, 
			string m3SUDO = null, 
			DateTime? m3DNDT = null, 
			string m3PUSN = null, 
			decimal? m3GRWE = null, 
			decimal? m3VOL3 = null, 
			string m3SUNO = null, 
			int? m3SUTY = null, 
			string m3SORN = null, 
			string m3DPNR = null, 
			string m3RSAG = null, 
			DateTime? m3DLDT = null, 
			int? m3DLTM = null, 
			DateTime? m3SHD4 = null, 
			int? m3SHTM = null, 
			DateTime? m3RCDT = null, 
			int? m3RCTM = null, 
			string m3MODL = null, 
			string m3E0B4 = null, 
			string m3E0BH = null, 
			string m3E0B5 = null, 
			string m3TEDL = null, 
			string m3YREF = null, 
			string m3TFNO = null, 
			string m3VRNO = null, 
			string m3RESP = null, 
			decimal? m3DTID = null, 
			decimal? m3TXID = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			DateTime? m3RGDT = null, 
			int? m3RGTM = null, 
			DateTime? m3LMDT = null, 
			int? m3CHNO = null, 
			string m3CHID = null, 
			int? m3DNTM = null, 
			string m3BOLN = null, 
			string m3FWRF = null, 
			DateTime? m3ARDT = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgWhsHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0IO))
				request.WithQueryParameter("E0IO", m3E0IO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QLFR))
				request.WithQueryParameter("QLFR", m3QLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRSL))
				request.WithQueryParameter("TRSL", m3TRSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRSH))
				request.WithQueryParameter("TRSH", m3TRSH.Trim());
			if (m3ADTY.HasValue)
				request.WithQueryParameter("ADTY", m3ADTY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0PA))
				request.WithQueryParameter("E0PA", m3E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0QA))
				request.WithQueryParameter("E0QA", m3E0QA.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0PB))
				request.WithQueryParameter("E0PB", m3E0PB.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0QB))
				request.WithQueryParameter("E0QB", m3E0QB.Trim());
			if (!string.IsNullOrWhiteSpace(m3DONR))
				request.WithQueryParameter("DONR", m3DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3E007))
				request.WithQueryParameter("E007", m3E007.Trim());
			if (!string.IsNullOrWhiteSpace(m3E014))
				request.WithQueryParameter("E014", m3E014.Trim());
			if (!string.IsNullOrWhiteSpace(m3E026))
				request.WithQueryParameter("E026", m3E026.Trim());
			if (m3E035.HasValue)
				request.WithQueryParameter("E035", m3E035.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3E065))
				request.WithQueryParameter("E065", m3E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3E052))
				request.WithQueryParameter("E052", m3E052.Trim());
			if (!string.IsNullOrWhiteSpace(m3E054))
				request.WithQueryParameter("E054", m3E054.Trim());
			if (!string.IsNullOrWhiteSpace(m3E051))
				request.WithQueryParameter("E051", m3E051.Trim());
			if (!string.IsNullOrWhiteSpace(m3E057))
				request.WithQueryParameter("E057", m3E057.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLSP))
				request.WithQueryParameter("DLSP", m3DLSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDFR))
				request.WithQueryParameter("EDFR", m3EDFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDO.HasValue)
				request.WithQueryParameter("RIDO", m3RIDO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3RIDI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3PLSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (m3DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3DNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PUSN))
				request.WithQueryParameter("PUSN", m3PUSN.Trim());
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3VOL3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3SUTY.HasValue)
				request.WithQueryParameter("SUTY", m3SUTY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SORN))
				request.WithQueryParameter("SORN", m3SORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3DPNR))
				request.WithQueryParameter("DPNR", m3DPNR.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSAG))
				request.WithQueryParameter("RSAG", m3RSAG.Trim());
			if (m3DLDT.HasValue)
				request.WithQueryParameter("DLDT", m3DLDT.Value.ToM3String());
			if (m3DLTM.HasValue)
				request.WithQueryParameter("DLTM", m3DLTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHD4.HasValue)
				request.WithQueryParameter("SHD4", m3SHD4.Value.ToM3String());
			if (m3SHTM.HasValue)
				request.WithQueryParameter("SHTM", m3SHTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RCDT.HasValue)
				request.WithQueryParameter("RCDT", m3RCDT.Value.ToM3String());
			if (m3RCTM.HasValue)
				request.WithQueryParameter("RCTM", m3RCTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0B4))
				request.WithQueryParameter("E0B4", m3E0B4.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0BH))
				request.WithQueryParameter("E0BH", m3E0BH.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0B5))
				request.WithQueryParameter("E0B5", m3E0B5.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3VRNO))
				request.WithQueryParameter("VRNO", m3VRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3DTID.HasValue)
				request.WithQueryParameter("DTID", m3DTID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3RGTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());
			if (m3CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3CHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());
			if (m3DNTM.HasValue)
				request.WithQueryParameter("DNTM", m3DNTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BOLN))
				request.WithQueryParameter("BOLN", m3BOLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FWRF))
				request.WithQueryParameter("FWRF", m3FWRF.Trim());
			if (m3ARDT.HasValue)
				request.WithQueryParameter("ARDT", m3ARDT.Value.ToM3String());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgWhsLine
		/// Description Change Warehouse Integration Line
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3PACN">Package number (Required)</param>
		/// <param name="m3MSLN">Message line number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3QLFR">Qualifier</param>
		/// <param name="m3QLFS">Sequence number</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3CHGD">Date changed</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3RELI">Line number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3DLQT">Delivered quantity - basic U/M</param>
		/// <param name="m3UNIT">Unit of measure</param>
		/// <param name="m3DLQA">Delivered quantity - alternate U/M</param>
		/// <param name="m3ALUN">Alternate U/M</param>
		/// <param name="m3VOL3">Volume</param>
		/// <param name="m3NEWE">Net weight</param>
		/// <param name="m3GRWE">Gross weight</param>
		/// <param name="m3D1QT">Standard quantity</param>
		/// <param name="m3DLSP">Delivery specification</param>
		/// <param name="m3RVQA">Received quantity</param>
		/// <param name="m3PUUN">Purchase order U/M</param>
		/// <param name="m3ALQT">Allocated quantity - basic U/M</param>
		/// <param name="m3PAQT">Packed quantity</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3POCY">Normal potency</param>
		/// <param name="m3OEND">Flagged as completed</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3FLOC">From picking location</param>
		/// <param name="m3TTYP">Stock transaction type</param>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDO">Order operation</param>
		/// <param name="m3PLSX">Picking list suffix</param>
		/// <param name="m3DLIX">Delivery index</param>
		/// <param name="m3RIDI">Order index</param>
		/// <param name="m3DNNO">Delivery note number</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SUTY">Supplier type</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3DNDT">Delivery note date</param>
		/// <param name="m3SITE">Supplier item number</param>
		/// <param name="m3SITD">Supplier item name</param>
		/// <param name="m3PUPR">Purchase price</param>
		/// <param name="m3PPUN">Purchase price U/M</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3PUCD">Purchase price quantity</param>
		/// <param name="m3LNAM">Line amount - order currency</param>
		/// <param name="m3VTCD">VAT code</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3DTID">Data identity</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">Reporting time</param>
		/// <param name="m3RGDT">Not used!</param>
		/// <param name="m3RGTM">Not used!</param>
		/// <param name="m3LMDT">Not used!</param>
		/// <param name="m3CHNO">Not used!</param>
		/// <param name="m3CHID">Not used!</param>
		/// <param name="m3QCRA">Quality inspection result</param>
		/// <param name="m3SCRE">Rejection reason</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3EXPI">Expiration date</param>
		/// <param name="m3CNDT">Follow-up date</param>
		/// <param name="m3SEDT">Sales date</param>
		/// <param name="m3TRTP">Order type</param>
		/// <param name="m3PLRN">Reporting number - pick line</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3ISMD">Issue/move mode</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3MFDT">Manufacturing date</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgWhsLine(
			string m3MSGN, 
			string m3PACN, 
			int m3MSLN, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3WHLO = null, 
			string m3QLFR = null, 
			int? m3QLFS = null, 
			string m3FACI = null, 
			DateTime? m3CHGD = null, 
			string m3STAT = null, 
			string m3ITNO = null, 
			string m3ITDS = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			long? m3REPN = null, 
			int? m3RELI = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			decimal? m3DLQT = null, 
			string m3UNIT = null, 
			decimal? m3DLQA = null, 
			string m3ALUN = null, 
			decimal? m3VOL3 = null, 
			decimal? m3NEWE = null, 
			decimal? m3GRWE = null, 
			decimal? m3D1QT = null, 
			string m3DLSP = null, 
			decimal? m3RVQA = null, 
			string m3PUUN = null, 
			decimal? m3ALQT = null, 
			decimal? m3PAQT = null, 
			decimal? m3CAWE = null, 
			int? m3POCY = null, 
			int? m3OEND = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			string m3FLOC = null, 
			int? m3TTYP = null, 
			string m3ORCA = null, 
			string m3RIDN = null, 
			int? m3RIDL = null, 
			int? m3RIDO = null, 
			int? m3PLSX = null, 
			decimal? m3DLIX = null, 
			decimal? m3RIDI = null, 
			string m3DNNO = null, 
			string m3CUOR = null, 
			string m3CUNO = null, 
			string m3ADID = null, 
			string m3SUNO = null, 
			int? m3SUTY = null, 
			string m3SUDO = null, 
			DateTime? m3DNDT = null, 
			string m3SITE = null, 
			string m3SITD = null, 
			decimal? m3PUPR = null, 
			string m3PPUN = null, 
			string m3CUCD = null, 
			int? m3PUCD = null, 
			decimal? m3LNAM = null, 
			int? m3VTCD = null, 
			string m3AGNB = null, 
			string m3RESP = null, 
			decimal? m3DTID = null, 
			decimal? m3TXID = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			DateTime? m3RGDT = null, 
			int? m3RGTM = null, 
			DateTime? m3LMDT = null, 
			int? m3CHNO = null, 
			string m3CHID = null, 
			string m3QCRA = null, 
			string m3SCRE = null, 
			string m3BREM = null, 
			DateTime? m3EXPI = null, 
			DateTime? m3CNDT = null, 
			DateTime? m3SEDT = null, 
			string m3TRTP = null, 
			decimal? m3PLRN = null, 
			DateTime? m3RPDT = null, 
			int? m3ISMD = null, 
			string m3TWSL = null, 
			int? m3RIDX = null, 
			string m3RSCD = null, 
			DateTime? m3MFDT = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgWhsLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));
			if (string.IsNullOrWhiteSpace(m3PACN))
				throw new ArgumentNullException(nameof(m3PACN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim())
				.WithQueryParameter("PACN", m3PACN.Trim())
				.WithQueryParameter("MSLN", m3MSLN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QLFR))
				request.WithQueryParameter("QLFR", m3QLFR.Trim());
			if (m3QLFS.HasValue)
				request.WithQueryParameter("QLFS", m3QLFS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (m3CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RELI.HasValue)
				request.WithQueryParameter("RELI", m3RELI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLQT.HasValue)
				request.WithQueryParameter("DLQT", m3DLQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3UNIT))
				request.WithQueryParameter("UNIT", m3UNIT.Trim());
			if (m3DLQA.HasValue)
				request.WithQueryParameter("DLQA", m3DLQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALUN))
				request.WithQueryParameter("ALUN", m3ALUN.Trim());
			if (m3VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3VOL3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3NEWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3D1QT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DLSP))
				request.WithQueryParameter("DLSP", m3DLSP.Trim());
			if (m3RVQA.HasValue)
				request.WithQueryParameter("RVQA", m3RVQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PUUN))
				request.WithQueryParameter("PUUN", m3PUUN.Trim());
			if (m3ALQT.HasValue)
				request.WithQueryParameter("ALQT", m3ALQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PAQT.HasValue)
				request.WithQueryParameter("PAQT", m3PAQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POCY.HasValue)
				request.WithQueryParameter("POCY", m3POCY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLOC))
				request.WithQueryParameter("FLOC", m3FLOC.Trim());
			if (m3TTYP.HasValue)
				request.WithQueryParameter("TTYP", m3TTYP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDO.HasValue)
				request.WithQueryParameter("RIDO", m3RIDO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3PLSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3RIDI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DNNO))
				request.WithQueryParameter("DNNO", m3DNNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3SUTY.HasValue)
				request.WithQueryParameter("SUTY", m3SUTY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (m3DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3DNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3SITE))
				request.WithQueryParameter("SITE", m3SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SITD))
				request.WithQueryParameter("SITD", m3SITD.Trim());
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PPUN))
				request.WithQueryParameter("PPUN", m3PPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3PUCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LNAM.HasValue)
				request.WithQueryParameter("LNAM", m3LNAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3VTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3DTID.HasValue)
				request.WithQueryParameter("DTID", m3DTID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3RGTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());
			if (m3CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3CHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3QCRA))
				request.WithQueryParameter("QCRA", m3QCRA.Trim());
			if (!string.IsNullOrWhiteSpace(m3SCRE))
				request.WithQueryParameter("SCRE", m3SCRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (m3EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3EXPI.Value.ToM3String());
			if (m3CNDT.HasValue)
				request.WithQueryParameter("CNDT", m3CNDT.Value.ToM3String());
			if (m3SEDT.HasValue)
				request.WithQueryParameter("SEDT", m3SEDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TRTP))
				request.WithQueryParameter("TRTP", m3TRTP.Trim());
			if (m3PLRN.HasValue)
				request.WithQueryParameter("PLRN", m3PLRN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3ISMD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (m3MFDT.HasValue)
				request.WithQueryParameter("MFDT", m3MFDT.Value.ToM3String());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgWhsPack
		/// Description Change Warehouse Integration Package
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3PACN">Package number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3QLFR">Qualifier</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3CHGD">Date changed</param>
		/// <param name="m3PARE">Package reference</param>
		/// <param name="m3DIPA">Disconnected package</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3DNNO">Delivery note number</param>
		/// <param name="m3DNDT">Delivery note date</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3TRSL">Lowest status - stock transaction</param>
		/// <param name="m3TRSH">Highest status - stock transaction</param>
		/// <param name="m3PACO">Package level</param>
		/// <param name="m3PACU">Bulk package</param>
		/// <param name="m3PACC">Included in package number</param>
		/// <param name="m3AMKO">Number of packages</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3PACK">Package type</param>
		/// <param name="m3TEPA">Packaging terms</param>
		/// <param name="m3SORT">Sort value</param>
		/// <param name="m3DLRM">Remark</param>
		/// <param name="m3DLMO">Goods mark Odette standard</param>
		/// <param name="m3DLSP">Delivery specification</param>
		/// <param name="m3VOM3">Volume</param>
		/// <param name="m3NEWE">Net weight</param>
		/// <param name="m3GRWE">Gross weight</param>
		/// <param name="m3GRW3">Included gross weight</param>
		/// <param name="m3GRW4">Manual gross weight</param>
		/// <param name="m3GRW5">Included net weight</param>
		/// <param name="m3D1QT">Standard quantity</param>
		/// <param name="m3VOMT">Weight</param>
		/// <param name="m3PACW">Package width</param>
		/// <param name="m3PACL">Package length</param>
		/// <param name="m3PACH">Package height</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3SUTY">Supplier type</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3DTID">Data identity</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3RGDT">Not used!</param>
		/// <param name="m3RGTM">Not used!</param>
		/// <param name="m3LMDT">Not used!</param>
		/// <param name="m3CHNO">Not used!</param>
		/// <param name="m3CHID">Not used!</param>
		/// <param name="m3ROUT">Route</param>
		/// <param name="m3RODN">Route departure</param>
		/// <param name="m3CONN">Shipment</param>
		/// <param name="m3DSDT">Departure date</param>
		/// <param name="m3DSHM">Departure time</param>
		/// <param name="m3CDEL">Changed delivery</param>
		/// <param name="m3NDLX">New delivery number</param>
		/// <param name="m3FRCP">Capacity - free capacity unit</param>
		/// <param name="m3PPNB">Pre-pack number</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgWhsPack(
			string m3WHLO, 
			string m3MSGN, 
			string m3PACN, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3QLFR = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			DateTime? m3CHGD = null, 
			string m3PARE = null, 
			int? m3DIPA = null, 
			string m3SUDO = null, 
			string m3DNNO = null, 
			DateTime? m3DNDT = null, 
			string m3STAT = null, 
			string m3TRSL = null, 
			string m3TRSH = null, 
			int? m3PACO = null, 
			int? m3PACU = null, 
			string m3PACC = null, 
			int? m3AMKO = null, 
			string m3PACT = null, 
			string m3PACK = null, 
			string m3TEPA = null, 
			string m3SORT = null, 
			string m3DLRM = null, 
			string m3DLMO = null, 
			string m3DLSP = null, 
			decimal? m3VOM3 = null, 
			decimal? m3NEWE = null, 
			decimal? m3GRWE = null, 
			decimal? m3GRW3 = null, 
			decimal? m3GRW4 = null, 
			decimal? m3GRW5 = null, 
			decimal? m3D1QT = null, 
			decimal? m3VOMT = null, 
			int? m3PACW = null, 
			int? m3PACL = null, 
			int? m3PACH = null, 
			string m3SSCC = null, 
			string m3WHSL = null, 
			string m3CUNO = null, 
			string m3ADID = null, 
			int? m3SUTY = null, 
			string m3SUNO = null, 
			string m3RESP = null, 
			decimal? m3DTID = null, 
			decimal? m3TXID = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			DateTime? m3RGDT = null, 
			int? m3RGTM = null, 
			DateTime? m3LMDT = null, 
			int? m3CHNO = null, 
			string m3CHID = null, 
			string m3ROUT = null, 
			int? m3RODN = null, 
			int? m3CONN = null, 
			DateTime? m3DSDT = null, 
			int? m3DSHM = null, 
			int? m3CDEL = null, 
			decimal? m3NDLX = null, 
			decimal? m3FRCP = null, 
			string m3PPNB = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgWhsPack",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));
			if (string.IsNullOrWhiteSpace(m3PACN))
				throw new ArgumentNullException(nameof(m3PACN));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("MSGN", m3MSGN.Trim())
				.WithQueryParameter("PACN", m3PACN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3QLFR))
				request.WithQueryParameter("QLFR", m3QLFR.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PARE))
				request.WithQueryParameter("PARE", m3PARE.Trim());
			if (m3DIPA.HasValue)
				request.WithQueryParameter("DIPA", m3DIPA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DNNO))
				request.WithQueryParameter("DNNO", m3DNNO.Trim());
			if (m3DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3DNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRSL))
				request.WithQueryParameter("TRSL", m3TRSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRSH))
				request.WithQueryParameter("TRSH", m3TRSH.Trim());
			if (m3PACO.HasValue)
				request.WithQueryParameter("PACO", m3PACO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PACU.HasValue)
				request.WithQueryParameter("PACU", m3PACU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PACC))
				request.WithQueryParameter("PACC", m3PACC.Trim());
			if (m3AMKO.HasValue)
				request.WithQueryParameter("AMKO", m3AMKO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACK))
				request.WithQueryParameter("PACK", m3PACK.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3SORT))
				request.WithQueryParameter("SORT", m3SORT.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLRM))
				request.WithQueryParameter("DLRM", m3DLRM.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLMO))
				request.WithQueryParameter("DLMO", m3DLMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLSP))
				request.WithQueryParameter("DLSP", m3DLSP.Trim());
			if (m3VOM3.HasValue)
				request.WithQueryParameter("VOM3", m3VOM3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3NEWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRW3.HasValue)
				request.WithQueryParameter("GRW3", m3GRW3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRW4.HasValue)
				request.WithQueryParameter("GRW4", m3GRW4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRW5.HasValue)
				request.WithQueryParameter("GRW5", m3GRW5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3D1QT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOMT.HasValue)
				request.WithQueryParameter("VOMT", m3VOMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PACW.HasValue)
				request.WithQueryParameter("PACW", m3PACW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PACL.HasValue)
				request.WithQueryParameter("PACL", m3PACL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PACH.HasValue)
				request.WithQueryParameter("PACH", m3PACH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (m3SUTY.HasValue)
				request.WithQueryParameter("SUTY", m3SUTY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3DTID.HasValue)
				request.WithQueryParameter("DTID", m3DTID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3RGTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());
			if (m3CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3CHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ROUT))
				request.WithQueryParameter("ROUT", m3ROUT.Trim());
			if (m3RODN.HasValue)
				request.WithQueryParameter("RODN", m3RODN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CONN.HasValue)
				request.WithQueryParameter("CONN", m3CONN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSDT.HasValue)
				request.WithQueryParameter("DSDT", m3DSDT.Value.ToM3String());
			if (m3DSHM.HasValue)
				request.WithQueryParameter("DSHM", m3DSHM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CDEL.HasValue)
				request.WithQueryParameter("CDEL", m3CDEL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NDLX.HasValue)
				request.WithQueryParameter("NDLX", m3NDLX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRCP.HasValue)
				request.WithQueryParameter("FRCP", m3FRCP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PPNB))
				request.WithQueryParameter("PPNB", m3PPNB.Trim());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DeleteSubLine
		/// Description DeleteSubLine
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3PACN">Package number (Required)</param>
		/// <param name="m3MSLN">Message line number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SUBL">Subline number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteSubLine(
			string m3MSGN, 
			string m3PACN, 
			int m3MSLN, 
			int? m3CONO = null, 
			int? m3SUBL = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DeleteSubLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));
			if (string.IsNullOrWhiteSpace(m3PACN))
				throw new ArgumentNullException(nameof(m3PACN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim())
				.WithQueryParameter("PACN", m3PACN.Trim())
				.WithQueryParameter("MSLN", m3MSLN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUBL.HasValue)
				request.WithQueryParameter("SUBL", m3SUBL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());

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
		/// Name DeleteWhsTran
		/// Description Delete Warehouse Integration Transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteWhsTran(
			string m3MSGN, 
			int? m3CONO = null, 
			string m3PACN = null, 
			int? m3MSLN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DeleteWhsTran",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetMvxMsg
		/// Description Get Movex Message ID
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PB">Partner (Required)</param>
		/// <param name="m3PMSN">External message number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMvxMsgResponse></returns>
		/// <exception cref="M3Exception<GetMvxMsgResponse>"></exception>
		public async Task<M3Response<GetMvxMsgResponse>> GetMvxMsg(
			string m3E0PB, 
			string m3PMSN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetMvxMsg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PB))
				throw new ArgumentNullException(nameof(m3E0PB));
			if (string.IsNullOrWhiteSpace(m3PMSN))
				throw new ArgumentNullException(nameof(m3PMSN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PB", m3E0PB.Trim())
				.WithQueryParameter("PMSN", m3PMSN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetMvxMsgResponse>(
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
		/// Name GetWhsHead
		/// Description Get Warehouse Integration Header
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetWhsHeadResponse></returns>
		/// <exception cref="M3Exception<GetWhsHeadResponse>"></exception>
		public async Task<M3Response<GetWhsHeadResponse>> GetWhsHead(
			string m3MSGN, 
			int? m3CONO = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetWhsHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetWhsHeadResponse>(
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
		/// Name GetWhsLine
		/// Description Get Warehouse Integration Line
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3PACN">Package number (Required)</param>
		/// <param name="m3MSLN">Message line number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetWhsLineResponse></returns>
		/// <exception cref="M3Exception<GetWhsLineResponse>"></exception>
		public async Task<M3Response<GetWhsLineResponse>> GetWhsLine(
			string m3MSGN, 
			string m3PACN, 
			int m3MSLN, 
			int? m3CONO = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetWhsLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));
			if (string.IsNullOrWhiteSpace(m3PACN))
				throw new ArgumentNullException(nameof(m3PACN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim())
				.WithQueryParameter("PACN", m3PACN.Trim())
				.WithQueryParameter("MSLN", m3MSLN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetWhsLineResponse>(
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
		/// Name GetWhsPack
		/// Description Get Warehouse Integration Package
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3PACN">Package number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetWhsPackResponse></returns>
		/// <exception cref="M3Exception<GetWhsPackResponse>"></exception>
		public async Task<M3Response<GetWhsPackResponse>> GetWhsPack(
			string m3MSGN, 
			string m3PACN, 
			int? m3CONO = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetWhsPack",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));
			if (string.IsNullOrWhiteSpace(m3PACN))
				throw new ArgumentNullException(nameof(m3PACN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim())
				.WithQueryParameter("PACN", m3PACN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetWhsPackResponse>(
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
		/// Name LstItemSubLine
		/// Description LstItemSubLine
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemSubLineResponse></returns>
		/// <exception cref="M3Exception<LstItemSubLineResponse>"></exception>
		public async Task<M3Response<LstItemSubLineResponse>> LstItemSubLine(
			string m3MSGN, 
			int? m3CONO = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3PACN = null, 
			int? m3MSLN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstItemSubLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstItemSubLineResponse>(
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
		/// Name LstMvxMsg
		/// Description List Movex Message ID
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PB">Partner (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMvxMsgResponse></returns>
		/// <exception cref="M3Exception<LstMvxMsgResponse>"></exception>
		public async Task<M3Response<LstMvxMsgResponse>> LstMvxMsg(
			string m3E0PB, 
			int? m3CONO = null, 
			string m3PMSN = null, 
			string m3STAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMvxMsg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PB))
				throw new ArgumentNullException(nameof(m3E0PB));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PB", m3E0PB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());

			// Execute the request
			var result = await Execute<LstMvxMsgResponse>(
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
		/// Name LstSubLine
		/// Description LstSubLine
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3BANT">Reference sublot ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSubLineResponse></returns>
		/// <exception cref="M3Exception<LstSubLineResponse>"></exception>
		public async Task<M3Response<LstSubLineResponse>> LstSubLine(
			string m3MSGN, 
			int? m3CONO = null, 
			string m3PACN = null, 
			int? m3MSLN = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3BANT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstSubLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANT))
				request.WithQueryParameter("BANT", m3BANT.Trim());

			// Execute the request
			var result = await Execute<LstSubLineResponse>(
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
		/// Name LstWhsLine
		/// Description List Warehouse Integration Line
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstWhsLineResponse></returns>
		/// <exception cref="M3Exception<LstWhsLineResponse>"></exception>
		public async Task<M3Response<LstWhsLineResponse>> LstWhsLine(
			string m3MSGN, 
			string m3PACN = null, 
			int? m3MSLN = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstWhsLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstWhsLineResponse>(
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
		/// Name PrcWhsTran
		/// Description Process Warehouse Integration Transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3PRFL">Process flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrcWhsTran(
			string m3MSGN, 
			int? m3CONO = null, 
			string m3PACN = null, 
			int? m3MSLN = null, 
			string m3PRFL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/PrcWhsTran",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());

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
		/// Name SndPOReceipt
		/// Description Snd Purchase Order Receipt
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SUTY">Supplier type (Required)</param>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3RIDL">Order line (Required)</param>
		/// <param name="m3PRFL">Process Flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3QTY">Quantity Received</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3USD1">User Defined 1</param>
		/// <param name="m3USD2">User defined 2</param>
		/// <param name="m3USD3">User defined 3</param>
		/// <param name="m3USD4">User defined 4</param>
		/// <param name="m3USD5">User defined 5</param>
		/// <param name="m3RIDI">Delivery number</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3OEND">Flagged as completed</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3BREF">Lot Reference 1</param>
		/// <param name="m3BRE2">Lot Reference 2</param>
		/// <param name="m3EXPI">Expiration date</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3DNDT">Delivery note date</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndPOReceipt(
			string m3WHLO, 
			string m3E0PA, 
			string m3E065, 
			string m3SUNO, 
			int m3SUTY, 
			string m3RIDN, 
			int m3RIDL, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSGN = null, 
			string m3PACN = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3ADID = null, 
			string m3ITNO = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			decimal? m3QTY = null, 
			int? m3RIDX = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			decimal? m3RIDI = null, 
			decimal? m3CAWE = null, 
			int? m3OEND = null, 
			string m3PMSN = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			DateTime? m3EXPI = null, 
			DateTime? m3RPDT = null, 
			int? m3RPTM = null, 
			string m3SUDO = null, 
			DateTime? m3DNDT = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SndPOReceipt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SUTY", m3SUTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RIDN", m3RIDN.Trim())
				.WithQueryParameter("RIDL", m3RIDL.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3QTY.HasValue)
				request.WithQueryParameter("QTY", m3QTY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3RIDI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3EXPI.Value.ToM3String());
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (m3DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3DNDT.Value.ToM3String());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name SndWhsLine
		/// Description Send Warehouse Integration Line
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3PACN">Package number (Required)</param>
		/// <param name="m3QLFR">Qualifier (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3QLFS">Sequence number</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3CHGD">Date changed</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3RELI">Line number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3DLQT">Delivered quantity - basic U/M</param>
		/// <param name="m3UNIT">Unit of measure</param>
		/// <param name="m3DLQA">Delivered quantity - alternate U/M</param>
		/// <param name="m3ALUN">Alternate U/M</param>
		/// <param name="m3VOL3">Volume</param>
		/// <param name="m3NEWE">Net weight</param>
		/// <param name="m3GRWE">Gross weight</param>
		/// <param name="m3D1QT">Standard quantity</param>
		/// <param name="m3DLSP">Delivery specification</param>
		/// <param name="m3RVQA">Received quantity</param>
		/// <param name="m3PUUN">Purchase order U/M</param>
		/// <param name="m3ALQT">Allocated quantity - basic U/M</param>
		/// <param name="m3PAQT">Packed quantity</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3POCY">Normal potency</param>
		/// <param name="m3OEND">Flagged as completed</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3FLOC">From picking location</param>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="m3TTYP">Stock transaction type</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDO">Order operation</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDI">Order index</param>
		/// <param name="m3PLSX">Picking list suffix</param>
		/// <param name="m3DLIX">Delivery index</param>
		/// <param name="m3DNNO">Delivery note number</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SUTY">Supplier type</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3DNDT">Delivery note date</param>
		/// <param name="m3SITE">Supplier item number</param>
		/// <param name="m3SITD">Supplier item name</param>
		/// <param name="m3PUPR">Purchase price</param>
		/// <param name="m3PPUN">Purchase price U/M</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3PUCD">Purchase price quantity</param>
		/// <param name="m3LNAM">Line amount - order currency</param>
		/// <param name="m3VTCD">VAT code</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3DTID">Data identity</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">Reporting time</param>
		/// <param name="m3RGDT">Not used!</param>
		/// <param name="m3RGTM">Not used!</param>
		/// <param name="m3LMDT">Not used!</param>
		/// <param name="m3CHNO">Not used!</param>
		/// <param name="m3CHID">Not used!</param>
		/// <param name="m3QCRA">Quality inspection result</param>
		/// <param name="m3SCRE">Rejection reason</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3EXPI">Expiration date</param>
		/// <param name="m3CNDT">Follow-up date</param>
		/// <param name="m3SEDT">Sales date</param>
		/// <param name="m3TRTP">Order type</param>
		/// <param name="m3PLRN">Reporting number - pick line</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3TWSL">To Location</param>
		/// <param name="m3ISMD">Issue Mode</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndWhsLine(
			string m3WHLO, 
			string m3MSGN, 
			string m3PACN, 
			string m3QLFR, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			int? m3MSLN = null, 
			int? m3QLFS = null, 
			string m3FACI = null, 
			DateTime? m3CHGD = null, 
			string m3STAT = null, 
			string m3ITNO = null, 
			string m3ITDS = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			long? m3REPN = null, 
			int? m3RELI = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			decimal? m3DLQT = null, 
			string m3UNIT = null, 
			decimal? m3DLQA = null, 
			string m3ALUN = null, 
			decimal? m3VOL3 = null, 
			decimal? m3NEWE = null, 
			decimal? m3GRWE = null, 
			decimal? m3D1QT = null, 
			string m3DLSP = null, 
			decimal? m3RVQA = null, 
			string m3PUUN = null, 
			decimal? m3ALQT = null, 
			decimal? m3PAQT = null, 
			decimal? m3CAWE = null, 
			int? m3POCY = null, 
			int? m3OEND = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			string m3FLOC = null, 
			string m3ORCA = null, 
			int? m3TTYP = null, 
			string m3RIDN = null, 
			int? m3RIDO = null, 
			int? m3RIDL = null, 
			decimal? m3RIDI = null, 
			int? m3PLSX = null, 
			decimal? m3DLIX = null, 
			string m3DNNO = null, 
			string m3CUOR = null, 
			string m3CUNO = null, 
			string m3ADID = null, 
			string m3SUNO = null, 
			int? m3SUTY = null, 
			string m3SUDO = null, 
			DateTime? m3DNDT = null, 
			string m3SITE = null, 
			string m3SITD = null, 
			decimal? m3PUPR = null, 
			string m3PPUN = null, 
			string m3CUCD = null, 
			int? m3PUCD = null, 
			decimal? m3LNAM = null, 
			int? m3VTCD = null, 
			string m3AGNB = null, 
			string m3RESP = null, 
			decimal? m3DTID = null, 
			decimal? m3TXID = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			DateTime? m3RGDT = null, 
			int? m3RGTM = null, 
			DateTime? m3LMDT = null, 
			int? m3CHNO = null, 
			string m3CHID = null, 
			string m3QCRA = null, 
			string m3SCRE = null, 
			string m3BREM = null, 
			DateTime? m3EXPI = null, 
			DateTime? m3CNDT = null, 
			DateTime? m3SEDT = null, 
			string m3TRTP = null, 
			decimal? m3PLRN = null, 
			DateTime? m3RPDT = null, 
			string m3TWSL = null, 
			int? m3ISMD = null, 
			int? m3RIDX = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SndWhsLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));
			if (string.IsNullOrWhiteSpace(m3PACN))
				throw new ArgumentNullException(nameof(m3PACN));
			if (string.IsNullOrWhiteSpace(m3QLFR))
				throw new ArgumentNullException(nameof(m3QLFR));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("MSGN", m3MSGN.Trim())
				.WithQueryParameter("PACN", m3PACN.Trim())
				.WithQueryParameter("QLFR", m3QLFR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QLFS.HasValue)
				request.WithQueryParameter("QLFS", m3QLFS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (m3CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RELI.HasValue)
				request.WithQueryParameter("RELI", m3RELI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLQT.HasValue)
				request.WithQueryParameter("DLQT", m3DLQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3UNIT))
				request.WithQueryParameter("UNIT", m3UNIT.Trim());
			if (m3DLQA.HasValue)
				request.WithQueryParameter("DLQA", m3DLQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALUN))
				request.WithQueryParameter("ALUN", m3ALUN.Trim());
			if (m3VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3VOL3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3NEWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3D1QT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DLSP))
				request.WithQueryParameter("DLSP", m3DLSP.Trim());
			if (m3RVQA.HasValue)
				request.WithQueryParameter("RVQA", m3RVQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PUUN))
				request.WithQueryParameter("PUUN", m3PUUN.Trim());
			if (m3ALQT.HasValue)
				request.WithQueryParameter("ALQT", m3ALQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PAQT.HasValue)
				request.WithQueryParameter("PAQT", m3PAQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POCY.HasValue)
				request.WithQueryParameter("POCY", m3POCY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLOC))
				request.WithQueryParameter("FLOC", m3FLOC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());
			if (m3TTYP.HasValue)
				request.WithQueryParameter("TTYP", m3TTYP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDO.HasValue)
				request.WithQueryParameter("RIDO", m3RIDO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3RIDI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3PLSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DNNO))
				request.WithQueryParameter("DNNO", m3DNNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3SUTY.HasValue)
				request.WithQueryParameter("SUTY", m3SUTY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (m3DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3DNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3SITE))
				request.WithQueryParameter("SITE", m3SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SITD))
				request.WithQueryParameter("SITD", m3SITD.Trim());
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PPUN))
				request.WithQueryParameter("PPUN", m3PPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3PUCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LNAM.HasValue)
				request.WithQueryParameter("LNAM", m3LNAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3VTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3DTID.HasValue)
				request.WithQueryParameter("DTID", m3DTID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3RGTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());
			if (m3CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3CHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3QCRA))
				request.WithQueryParameter("QCRA", m3QCRA.Trim());
			if (!string.IsNullOrWhiteSpace(m3SCRE))
				request.WithQueryParameter("SCRE", m3SCRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (m3EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3EXPI.Value.ToM3String());
			if (m3CNDT.HasValue)
				request.WithQueryParameter("CNDT", m3CNDT.Value.ToM3String());
			if (m3SEDT.HasValue)
				request.WithQueryParameter("SEDT", m3SEDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TRTP))
				request.WithQueryParameter("TRTP", m3TRTP.Trim());
			if (m3PLRN.HasValue)
				request.WithQueryParameter("PLRN", m3PLRN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (m3ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3ISMD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name SndWhsPack
		/// Description Send Warehouse Integration Package
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3QLFR">Qualifier (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3CHGD">Date changed</param>
		/// <param name="m3PARE">Package reference</param>
		/// <param name="m3DIPA">Disconnected package</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3DNNO">Delivery note number</param>
		/// <param name="m3DNDT">Delivery note date</param>
		/// <param name="m3TRSH">Highest status - stock transaction</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3TRSL">Lowest status - stock transaction</param>
		/// <param name="m3PACO">Package level</param>
		/// <param name="m3PACU">Bulk package</param>
		/// <param name="m3PACC">Included in package number</param>
		/// <param name="m3AMKO">Number of packages</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3PACK">Package type</param>
		/// <param name="m3TEPA">Packaging terms</param>
		/// <param name="m3SORT">Sort value</param>
		/// <param name="m3DLRM">Remark</param>
		/// <param name="m3DLMO">Goods mark Odette standard</param>
		/// <param name="m3DLSP">Delivery specification</param>
		/// <param name="m3VOM3">Volume</param>
		/// <param name="m3NEWE">Net weight</param>
		/// <param name="m3GRWE">Gross weight</param>
		/// <param name="m3GRW3">Included gross weight</param>
		/// <param name="m3GRW4">Manual gross weight</param>
		/// <param name="m3GRW5">Included net weight</param>
		/// <param name="m3D1QT">Standard quantity</param>
		/// <param name="m3VOMT">Weight</param>
		/// <param name="m3PACL">Package length</param>
		/// <param name="m3PACW">Package width</param>
		/// <param name="m3PACH">Package height</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3SUTY">Supplier type</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3DTID">Data identity</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3RGDT">Not used!</param>
		/// <param name="m3RGTM">Not used!</param>
		/// <param name="m3LMDT">Not used!</param>
		/// <param name="m3CHNO">Not used!</param>
		/// <param name="m3CHID">Not used!</param>
		/// <param name="m3ROUT">Route</param>
		/// <param name="m3RODN">Route departure</param>
		/// <param name="m3CONN">Shipment</param>
		/// <param name="m3DSDT">Departure date</param>
		/// <param name="m3DSHM">Departure time</param>
		/// <param name="m3CDEL">Changed delivery</param>
		/// <param name="m3NDLX">New delivery number</param>
		/// <param name="m3FRCP">Capacity - free capacity unit</param>
		/// <param name="m3PPNB">Pre-pack number</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndWhsPack(
			string m3WHLO, 
			string m3MSGN, 
			string m3QLFR, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3PACN = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			DateTime? m3CHGD = null, 
			string m3PARE = null, 
			int? m3DIPA = null, 
			string m3SUDO = null, 
			string m3DNNO = null, 
			DateTime? m3DNDT = null, 
			string m3TRSH = null, 
			string m3STAT = null, 
			string m3TRSL = null, 
			int? m3PACO = null, 
			int? m3PACU = null, 
			string m3PACC = null, 
			int? m3AMKO = null, 
			string m3PACT = null, 
			string m3PACK = null, 
			string m3TEPA = null, 
			string m3SORT = null, 
			string m3DLRM = null, 
			string m3DLMO = null, 
			string m3DLSP = null, 
			decimal? m3VOM3 = null, 
			decimal? m3NEWE = null, 
			decimal? m3GRWE = null, 
			decimal? m3GRW3 = null, 
			decimal? m3GRW4 = null, 
			decimal? m3GRW5 = null, 
			decimal? m3D1QT = null, 
			decimal? m3VOMT = null, 
			int? m3PACL = null, 
			int? m3PACW = null, 
			int? m3PACH = null, 
			string m3SSCC = null, 
			string m3WHSL = null, 
			string m3CUNO = null, 
			string m3ADID = null, 
			int? m3SUTY = null, 
			string m3SUNO = null, 
			string m3RESP = null, 
			decimal? m3DTID = null, 
			decimal? m3TXID = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			DateTime? m3RGDT = null, 
			int? m3RGTM = null, 
			DateTime? m3LMDT = null, 
			int? m3CHNO = null, 
			string m3CHID = null, 
			string m3ROUT = null, 
			int? m3RODN = null, 
			int? m3CONN = null, 
			DateTime? m3DSDT = null, 
			int? m3DSHM = null, 
			int? m3CDEL = null, 
			decimal? m3NDLX = null, 
			decimal? m3FRCP = null, 
			string m3PPNB = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SndWhsPack",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));
			if (string.IsNullOrWhiteSpace(m3QLFR))
				throw new ArgumentNullException(nameof(m3QLFR));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("MSGN", m3MSGN.Trim())
				.WithQueryParameter("QLFR", m3QLFR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PARE))
				request.WithQueryParameter("PARE", m3PARE.Trim());
			if (m3DIPA.HasValue)
				request.WithQueryParameter("DIPA", m3DIPA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DNNO))
				request.WithQueryParameter("DNNO", m3DNNO.Trim());
			if (m3DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3DNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TRSH))
				request.WithQueryParameter("TRSH", m3TRSH.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRSL))
				request.WithQueryParameter("TRSL", m3TRSL.Trim());
			if (m3PACO.HasValue)
				request.WithQueryParameter("PACO", m3PACO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PACU.HasValue)
				request.WithQueryParameter("PACU", m3PACU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PACC))
				request.WithQueryParameter("PACC", m3PACC.Trim());
			if (m3AMKO.HasValue)
				request.WithQueryParameter("AMKO", m3AMKO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACK))
				request.WithQueryParameter("PACK", m3PACK.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3SORT))
				request.WithQueryParameter("SORT", m3SORT.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLRM))
				request.WithQueryParameter("DLRM", m3DLRM.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLMO))
				request.WithQueryParameter("DLMO", m3DLMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLSP))
				request.WithQueryParameter("DLSP", m3DLSP.Trim());
			if (m3VOM3.HasValue)
				request.WithQueryParameter("VOM3", m3VOM3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3NEWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRW3.HasValue)
				request.WithQueryParameter("GRW3", m3GRW3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRW4.HasValue)
				request.WithQueryParameter("GRW4", m3GRW4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRW5.HasValue)
				request.WithQueryParameter("GRW5", m3GRW5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3D1QT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOMT.HasValue)
				request.WithQueryParameter("VOMT", m3VOMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PACL.HasValue)
				request.WithQueryParameter("PACL", m3PACL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PACW.HasValue)
				request.WithQueryParameter("PACW", m3PACW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PACH.HasValue)
				request.WithQueryParameter("PACH", m3PACH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (m3SUTY.HasValue)
				request.WithQueryParameter("SUTY", m3SUTY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3DTID.HasValue)
				request.WithQueryParameter("DTID", m3DTID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3RGTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());
			if (m3CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3CHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ROUT))
				request.WithQueryParameter("ROUT", m3ROUT.Trim());
			if (m3RODN.HasValue)
				request.WithQueryParameter("RODN", m3RODN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CONN.HasValue)
				request.WithQueryParameter("CONN", m3CONN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSDT.HasValue)
				request.WithQueryParameter("DSDT", m3DSDT.Value.ToM3String());
			if (m3DSHM.HasValue)
				request.WithQueryParameter("DSHM", m3DSHM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CDEL.HasValue)
				request.WithQueryParameter("CDEL", m3CDEL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NDLX.HasValue)
				request.WithQueryParameter("NDLX", m3NDLX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRCP.HasValue)
				request.WithQueryParameter("FRCP", m3FRCP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PPNB))
				request.WithQueryParameter("PPNB", m3PPNB.Trim());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

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
