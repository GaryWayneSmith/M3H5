/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.QUS100MI;
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
	/// Name: QUS100MI
	/// Component Name: Quatation
	/// Description: Api: Quatation head
	/// Version Release: 5ea0
	///</summary>
	public partial class QUS100MIResource : M3BaseResourceEndpoint
	{
		public QUS100MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QUS100MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddQuote
		/// Description Add Quotation
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3QUTY">Quotation type (Required)</param>
		/// <param name="m3CUNM">Customer name</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3ORTP">Customer order type</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3DWDT">Requested delivery date</param>
		/// <param name="m3CUA1">Customer address 1</param>
		/// <param name="m3CUA2">Customer address 2</param>
		/// <param name="m3CUA3">Customer address 3</param>
		/// <param name="m3CUA4">Customer address 4</param>
		/// <param name="m3CESA">Marketing ID - Movex SMS</param>
		/// <param name="m3LHCD">Language code order head</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3CRTP">Exchange rate type</param>
		/// <param name="m3TEDL">Delivery terms</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3ORQA">Ordered quantity - alternate U/M</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3UCOS">Cost price</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3QFOR">Forcasting</param>
		/// <param name="m3QPRO">Probability</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3SMCD">Salesperson</param>
		/// <param name="m3SMNG">Sales manager</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3YRE2">Your reference 2</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3PHN2">Telephone number 2</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3PONO">Postal code</param>
		/// <param name="m3TPCU">Template customer</param>
		/// <param name="m3DLDT">Planned delivery date</param>
		/// <param name="m3CUCL">Customer group</param>
		/// <param name="m3OYNO">Opportunity number</param>
		/// <param name="m3QRNO">Related quotation group</param>
		/// <param name="m3QGRP">Quotation group</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3QCAT">Quotation category</param>
		/// <param name="m3SPST">Line type</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3WATP">Warranty type</param>
		/// <param name="m3AAGN">Agreement</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddQuoteResponse></returns>
		/// <exception cref="M3Exception<AddQuoteResponse>"></exception>
		public async Task<M3Response<AddQuoteResponse>> AddQuote(
			string m3CUNO, 
			string m3QUTY, 
			string m3CUNM = null, 
			string m3TX40 = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
			string m3ORTP = null, 
			DateTime? m3FVDT = null, 
			DateTime? m3LVDT = null, 
			string m3RESP = null, 
			DateTime? m3DWDT = null, 
			string m3CUA1 = null, 
			string m3CUA2 = null, 
			string m3CUA3 = null, 
			string m3CUA4 = null, 
			string m3CESA = null, 
			string m3LHCD = null, 
			string m3CUCD = null, 
			int? m3CRTP = null, 
			string m3TEDL = null, 
			string m3MODL = null, 
			string m3TEPY = null, 
			decimal? m3TXID = null, 
			string m3PRNO = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			decimal? m3ORQA = null, 
			decimal? m3SAPR = null, 
			decimal? m3UCOS = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			string m3RSCD = null, 
			int? m3QFOR = null, 
			int? m3QPRO = null, 
			string m3ADID = null, 
			string m3SMCD = null, 
			string m3SMNG = null, 
			string m3YREF = null, 
			string m3YRE2 = null, 
			string m3PHNO = null, 
			string m3PHN2 = null, 
			string m3ECAR = null, 
			string m3CSCD = null, 
			string m3TOWN = null, 
			string m3PONO = null, 
			string m3TPCU = null, 
			DateTime? m3DLDT = null, 
			string m3CUCL = null, 
			string m3OYNO = null, 
			string m3QRNO = null, 
			string m3QGRP = null, 
			string m3FRCO = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3QCAT = null, 
			int? m3SPST = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			string m3WATP = null, 
			string m3AAGN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddQuote",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3QUTY))
				throw new ArgumentNullException(nameof(m3QUTY));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("QUTY", m3QUTY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNM))
				request.WithQueryParameter("CUNM", m3CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTP))
				request.WithQueryParameter("ORTP", m3ORTP.Trim());
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3DWDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CUA1))
				request.WithQueryParameter("CUA1", m3CUA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA2))
				request.WithQueryParameter("CUA2", m3CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA3))
				request.WithQueryParameter("CUA3", m3CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA4))
				request.WithQueryParameter("CUA4", m3CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3CESA))
				request.WithQueryParameter("CESA", m3CESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3LHCD))
				request.WithQueryParameter("LHCD", m3LHCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3CRTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3ORQA.HasValue)
				request.WithQueryParameter("ORQA", m3ORQA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UCOS.HasValue)
				request.WithQueryParameter("UCOS", m3UCOS.Value.ToString(CultureInfo.CurrentCulture));
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
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (m3QFOR.HasValue)
				request.WithQueryParameter("QFOR", m3QFOR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QPRO.HasValue)
				request.WithQueryParameter("QPRO", m3QPRO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMCD))
				request.WithQueryParameter("SMCD", m3SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMNG))
				request.WithQueryParameter("SMNG", m3SMNG.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3YRE2))
				request.WithQueryParameter("YRE2", m3YRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHN2))
				request.WithQueryParameter("PHN2", m3PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOWN))
				request.WithQueryParameter("TOWN", m3TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TPCU))
				request.WithQueryParameter("TPCU", m3TPCU.Trim());
			if (m3DLDT.HasValue)
				request.WithQueryParameter("DLDT", m3DLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CUCL))
				request.WithQueryParameter("CUCL", m3CUCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3OYNO))
				request.WithQueryParameter("OYNO", m3OYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QRNO))
				request.WithQueryParameter("QRNO", m3QRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QGRP))
				request.WithQueryParameter("QGRP", m3QGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRCO))
				request.WithQueryParameter("FRCO", m3FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QCAT))
				request.WithQueryParameter("QCAT", m3QCAT.Trim());
			if (m3SPST.HasValue)
				request.WithQueryParameter("SPST", m3SPST.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WATP))
				request.WithQueryParameter("WATP", m3WATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3AAGN))
				request.WithQueryParameter("AAGN", m3AAGN.Trim());

			// Execute the request
			var result = await Execute<AddQuoteResponse>(
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
		/// Name AddQuoteHead
		/// Description Add Quotation Head
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3QUTY">Quotation type (Required)</param>
		/// <param name="m3CUNM">Customer name</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3ORTP">Customer order type</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3DWDT">Requested delivery date</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3LHCD">Language code order head</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3CRTP">Exchange rate type</param>
		/// <param name="m3TEDL">Delivery terms</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3CUA1">Customer address 1</param>
		/// <param name="m3CUA2">Customer address 2</param>
		/// <param name="m3CUA3">Customer address 3</param>
		/// <param name="m3CUA4">Customer address 4</param>
		/// <param name="m3CESA">Marketing ID - Movex SMS</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3QFOR">Forcasting</param>
		/// <param name="m3QPRO">Probability</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3SMCD">Salesperson</param>
		/// <param name="m3SMNG">Sales manager</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3YRE2">Your reference 2</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3PHN2">Telephone number 2</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3PONO">Postal code</param>
		/// <param name="m3TPCU">Template customer</param>
		/// <param name="m3DLDT">Planned delivery date</param>
		/// <param name="m3CUCL">Customer group</param>
		/// <param name="m3OYNO">Opportunity number</param>
		/// <param name="m3QRNO">Related quotation group</param>
		/// <param name="m3QGRP">Quotation group</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3QCAT">Quotation category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddQuoteHeadResponse></returns>
		/// <exception cref="M3Exception<AddQuoteHeadResponse>"></exception>
		public async Task<M3Response<AddQuoteHeadResponse>> AddQuoteHead(
			string m3CUNO, 
			string m3QUTY, 
			string m3CUNM = null, 
			string m3TX40 = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
			string m3ORTP = null, 
			DateTime? m3FVDT = null, 
			DateTime? m3LVDT = null, 
			DateTime? m3DWDT = null, 
			string m3RESP = null, 
			string m3LHCD = null, 
			string m3CUCD = null, 
			int? m3CRTP = null, 
			string m3TEDL = null, 
			string m3MODL = null, 
			string m3TEPY = null, 
			string m3CUA1 = null, 
			string m3CUA2 = null, 
			string m3CUA3 = null, 
			string m3CUA4 = null, 
			string m3CESA = null, 
			decimal? m3TXID = null, 
			string m3RSCD = null, 
			int? m3QFOR = null, 
			int? m3QPRO = null, 
			string m3ADID = null, 
			string m3SMCD = null, 
			string m3SMNG = null, 
			string m3YREF = null, 
			string m3YRE2 = null, 
			string m3PHNO = null, 
			string m3PHN2 = null, 
			string m3ECAR = null, 
			string m3CSCD = null, 
			string m3TOWN = null, 
			string m3PONO = null, 
			string m3TPCU = null, 
			DateTime? m3DLDT = null, 
			string m3CUCL = null, 
			string m3OYNO = null, 
			string m3QRNO = null, 
			string m3QGRP = null, 
			string m3FRCO = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3QCAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddQuoteHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3QUTY))
				throw new ArgumentNullException(nameof(m3QUTY));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("QUTY", m3QUTY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNM))
				request.WithQueryParameter("CUNM", m3CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTP))
				request.WithQueryParameter("ORTP", m3ORTP.Trim());
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (m3DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3DWDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3LHCD))
				request.WithQueryParameter("LHCD", m3LHCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3CRTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA1))
				request.WithQueryParameter("CUA1", m3CUA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA2))
				request.WithQueryParameter("CUA2", m3CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA3))
				request.WithQueryParameter("CUA3", m3CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA4))
				request.WithQueryParameter("CUA4", m3CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3CESA))
				request.WithQueryParameter("CESA", m3CESA.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (m3QFOR.HasValue)
				request.WithQueryParameter("QFOR", m3QFOR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QPRO.HasValue)
				request.WithQueryParameter("QPRO", m3QPRO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMCD))
				request.WithQueryParameter("SMCD", m3SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMNG))
				request.WithQueryParameter("SMNG", m3SMNG.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3YRE2))
				request.WithQueryParameter("YRE2", m3YRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHN2))
				request.WithQueryParameter("PHN2", m3PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOWN))
				request.WithQueryParameter("TOWN", m3TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TPCU))
				request.WithQueryParameter("TPCU", m3TPCU.Trim());
			if (m3DLDT.HasValue)
				request.WithQueryParameter("DLDT", m3DLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CUCL))
				request.WithQueryParameter("CUCL", m3CUCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3OYNO))
				request.WithQueryParameter("OYNO", m3OYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QRNO))
				request.WithQueryParameter("QRNO", m3QRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QGRP))
				request.WithQueryParameter("QGRP", m3QGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRCO))
				request.WithQueryParameter("FRCO", m3FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QCAT))
				request.WithQueryParameter("QCAT", m3QCAT.Trim());

			// Execute the request
			var result = await Execute<AddQuoteHeadResponse>(
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
		/// Name AddQuoteLine
		/// Description Add Quotation Line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3OFNO">Quotation number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3ORQA">Ordered quantity - alternate U/M</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3UCOS">Cost price</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3DRDE">Direct delivery</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddQuoteLineResponse></returns>
		/// <exception cref="M3Exception<AddQuoteLineResponse>"></exception>
		public async Task<M3Response<AddQuoteLineResponse>> AddQuoteLine(
			string m3OFNO, 
			int m3VERS, 
			int m3PONR, 
			int m3POSX, 
			string m3PRNO, 
			string m3ITNO = null, 
			string m3BANO = null, 
			decimal? m3ORQA = null, 
			decimal? m3SAPR = null, 
			decimal? m3UCOS = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			string m3WHLO = null, 
			int? m3DRDE = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddQuoteLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3OFNO))
				throw new ArgumentNullException(nameof(m3OFNO));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("OFNO", m3OFNO.Trim())
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("POSX", m3POSX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PRNO", m3PRNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3ORQA.HasValue)
				request.WithQueryParameter("ORQA", m3ORQA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UCOS.HasValue)
				request.WithQueryParameter("UCOS", m3UCOS.Value.ToString(CultureInfo.CurrentCulture));
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
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3DRDE.HasValue)
				request.WithQueryParameter("DRDE", m3DRDE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());

			// Execute the request
			var result = await Execute<AddQuoteLineResponse>(
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
		/// Name DltQuoteHead
		/// Description Delete Quotation Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3OFNO">Quotation number (Required)</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltQuoteHead(
			string m3OFNO, 
			int? m3VERS = null, 
			string m3RSCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltQuoteHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3OFNO))
				throw new ArgumentNullException(nameof(m3OFNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("OFNO", m3OFNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3VERS.HasValue)
				request.WithQueryParameter("VERS", m3VERS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());

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
		/// Name DltQuoteLine
		/// Description Delete Quotatin Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3OFNO">Quotation number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltQuoteLine(
			string m3OFNO, 
			int m3VERS, 
			int m3PONR, 
			int? m3POSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltQuoteLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3OFNO))
				throw new ArgumentNullException(nameof(m3OFNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("OFNO", m3OFNO.Trim())
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetQuoteHead
		/// Description Get Quotation Head
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3OFNO">Quotation number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetQuoteHeadResponse></returns>
		/// <exception cref="M3Exception<GetQuoteHeadResponse>"></exception>
		public async Task<M3Response<GetQuoteHeadResponse>> GetQuoteHead(
			string m3OFNO, 
			int m3VERS, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetQuoteHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3OFNO))
				throw new ArgumentNullException(nameof(m3OFNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("OFNO", m3OFNO.Trim())
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetQuoteHeadResponse>(
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
		/// Name GetQuoteLine
		/// Description Get Quotation Line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3OFNO">Quotation number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetQuoteLineResponse></returns>
		/// <exception cref="M3Exception<GetQuoteLineResponse>"></exception>
		public async Task<M3Response<GetQuoteLineResponse>> GetQuoteLine(
			string m3OFNO, 
			int m3VERS, 
			int m3PONR, 
			int m3POSX, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetQuoteLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3OFNO))
				throw new ArgumentNullException(nameof(m3OFNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("OFNO", m3OFNO.Trim())
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("POSX", m3POSX.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetQuoteLineResponse>(
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
		/// Name LstQuoteByCuno
		/// Description List Quatation Head By Customer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstQuoteByCunoResponse></returns>
		/// <exception cref="M3Exception<LstQuoteByCunoResponse>"></exception>
		public async Task<M3Response<LstQuoteByCunoResponse>> LstQuoteByCuno(
			string m3CUNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstQuoteByCuno",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Execute the request
			var result = await Execute<LstQuoteByCunoResponse>(
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
		/// Name LstQuoteByGuid
		/// Description List Quatation Head By Guid
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CESA">Marketing ID - Movex SMS</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstQuoteByGuidResponse></returns>
		/// <exception cref="M3Exception<LstQuoteByGuidResponse>"></exception>
		public async Task<M3Response<LstQuoteByGuidResponse>> LstQuoteByGuid(
			string m3CESA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstQuoteByGuid",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CESA))
				request.WithQueryParameter("CESA", m3CESA.Trim());

			// Execute the request
			var result = await Execute<LstQuoteByGuidResponse>(
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
		/// Name LstQuoteByTme
		/// Description List Quotation Head By Timestamp
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstQuoteByTmeResponse></returns>
		/// <exception cref="M3Exception<LstQuoteByTmeResponse>"></exception>
		public async Task<M3Response<LstQuoteByTmeResponse>> LstQuoteByTme(
			decimal? m3LMTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstQuoteByTme",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstQuoteByTmeResponse>(
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
		/// Name LstQuoteHead
		/// Description List Quotation Head
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3OFNO">Quotation number</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstQuoteHeadResponse></returns>
		/// <exception cref="M3Exception<LstQuoteHeadResponse>"></exception>
		public async Task<M3Response<LstQuoteHeadResponse>> LstQuoteHead(
			string m3OFNO = null, 
			int? m3VERS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstQuoteHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OFNO))
				request.WithQueryParameter("OFNO", m3OFNO.Trim());
			if (m3VERS.HasValue)
				request.WithQueryParameter("VERS", m3VERS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstQuoteHeadResponse>(
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
		/// Name LstQuoteLine
		/// Description ist Quotation Liner
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3OFNO">Quotation number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstQuoteLineResponse></returns>
		/// <exception cref="M3Exception<LstQuoteLineResponse>"></exception>
		public async Task<M3Response<LstQuoteLineResponse>> LstQuoteLine(
			string m3OFNO, 
			int m3VERS, 
			int? m3PONR = null, 
			int? m3POSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstQuoteLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3OFNO))
				throw new ArgumentNullException(nameof(m3OFNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("OFNO", m3OFNO.Trim())
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstQuoteLineResponse>(
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
		/// Name UpdQuoteHead
		/// Description Update Quotation Head
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3OFNO">Quotation number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3CUNM">Customer name</param>
		/// <param name="m3QUTY">Quotation type</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3ORTP">Customer order type</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3DWDT">Requested delivery date</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3LHCD">Language code order head</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3CRTP">Exchange rate type</param>
		/// <param name="m3TEDL">Delivery terms</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3CUA1">Customer address 1</param>
		/// <param name="m3CUA2">Customer address 2</param>
		/// <param name="m3CUA3">Customer address 3</param>
		/// <param name="m3CUA4">Customer address 4</param>
		/// <param name="m3CESA">Marketing ID - Movex SMS</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3QFOR">Forcasting</param>
		/// <param name="m3QPRO">Probability</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3SMCD">Salesperson</param>
		/// <param name="m3SMNG">Sales manager</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3YRE2">Your reference 2</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3PHN2">Telephone number 2</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3PONO">Postal code</param>
		/// <param name="m3TPCU">Template customer</param>
		/// <param name="m3DLDT">Planned delivery date</param>
		/// <param name="m3QGRP">Quotation group</param>
		/// <param name="m3QRNO">Related quotation no</param>
		/// <param name="m3OYNO">Opportunity number</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3QCAT">Quotation category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<UpdQuoteHeadResponse></returns>
		/// <exception cref="M3Exception<UpdQuoteHeadResponse>"></exception>
		public async Task<M3Response<UpdQuoteHeadResponse>> UpdQuoteHead(
			string m3OFNO, 
			int m3VERS, 
			string m3CUNO = null, 
			string m3CUNM = null, 
			string m3QUTY = null, 
			string m3TX40 = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
			string m3ORTP = null, 
			DateTime? m3FVDT = null, 
			DateTime? m3LVDT = null, 
			DateTime? m3DWDT = null, 
			string m3RESP = null, 
			string m3LHCD = null, 
			string m3CUCD = null, 
			int? m3CRTP = null, 
			string m3TEDL = null, 
			string m3MODL = null, 
			string m3TEPY = null, 
			string m3CUA1 = null, 
			string m3CUA2 = null, 
			string m3CUA3 = null, 
			string m3CUA4 = null, 
			string m3CESA = null, 
			decimal? m3TXID = null, 
			string m3RSCD = null, 
			int? m3QFOR = null, 
			int? m3QPRO = null, 
			string m3ADID = null, 
			string m3SMCD = null, 
			string m3SMNG = null, 
			string m3YREF = null, 
			string m3YRE2 = null, 
			string m3PHNO = null, 
			string m3PHN2 = null, 
			string m3ECAR = null, 
			string m3CSCD = null, 
			string m3TOWN = null, 
			string m3PONO = null, 
			string m3TPCU = null, 
			DateTime? m3DLDT = null, 
			string m3QGRP = null, 
			string m3QRNO = null, 
			string m3OYNO = null, 
			string m3FRCO = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3QCAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdQuoteHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3OFNO))
				throw new ArgumentNullException(nameof(m3OFNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("OFNO", m3OFNO.Trim())
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNM))
				request.WithQueryParameter("CUNM", m3CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3QUTY))
				request.WithQueryParameter("QUTY", m3QUTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTP))
				request.WithQueryParameter("ORTP", m3ORTP.Trim());
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (m3DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3DWDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3LHCD))
				request.WithQueryParameter("LHCD", m3LHCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3CRTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA1))
				request.WithQueryParameter("CUA1", m3CUA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA2))
				request.WithQueryParameter("CUA2", m3CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA3))
				request.WithQueryParameter("CUA3", m3CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA4))
				request.WithQueryParameter("CUA4", m3CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3CESA))
				request.WithQueryParameter("CESA", m3CESA.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (m3QFOR.HasValue)
				request.WithQueryParameter("QFOR", m3QFOR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QPRO.HasValue)
				request.WithQueryParameter("QPRO", m3QPRO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMCD))
				request.WithQueryParameter("SMCD", m3SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMNG))
				request.WithQueryParameter("SMNG", m3SMNG.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3YRE2))
				request.WithQueryParameter("YRE2", m3YRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHN2))
				request.WithQueryParameter("PHN2", m3PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOWN))
				request.WithQueryParameter("TOWN", m3TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TPCU))
				request.WithQueryParameter("TPCU", m3TPCU.Trim());
			if (m3DLDT.HasValue)
				request.WithQueryParameter("DLDT", m3DLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3QGRP))
				request.WithQueryParameter("QGRP", m3QGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3QRNO))
				request.WithQueryParameter("QRNO", m3QRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3OYNO))
				request.WithQueryParameter("OYNO", m3OYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRCO))
				request.WithQueryParameter("FRCO", m3FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QCAT))
				request.WithQueryParameter("QCAT", m3QCAT.Trim());

			// Execute the request
			var result = await Execute<UpdQuoteHeadResponse>(
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
