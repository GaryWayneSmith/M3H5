/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_QUTY">Quotation type (Required)</param>
		/// <param name="m3_CUNM">Customer name</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_ORTP">Customer order type</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_DWDT">Requested delivery date</param>
		/// <param name="m3_CUA1">Customer address 1</param>
		/// <param name="m3_CUA2">Customer address 2</param>
		/// <param name="m3_CUA3">Customer address 3</param>
		/// <param name="m3_CUA4">Customer address 4</param>
		/// <param name="m3_CESA">Marketing ID - Movex SMS</param>
		/// <param name="m3_LHCD">Language code order head</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_CRTP">Exchange rate type</param>
		/// <param name="m3_TEDL">Delivery terms</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_ORQA">Ordered quantity - alternate U/M</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_UCOS">Cost price</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_QFOR">Forcasting</param>
		/// <param name="m3_QPRO">Probability</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_SMCD">Salesperson</param>
		/// <param name="m3_SMNG">Sales manager</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_YRE2">Your reference 2</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_PHN2">Telephone number 2</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_PONO">Postal code</param>
		/// <param name="m3_TPCU">Template customer</param>
		/// <param name="m3_DLDT">Planned delivery date</param>
		/// <param name="m3_CUCL">Customer group</param>
		/// <param name="m3_OYNO">Opportunity number</param>
		/// <param name="m3_QRNO">Related quotation group</param>
		/// <param name="m3_QGRP">Quotation group</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_QCAT">Quotation category</param>
		/// <param name="m3_SPST">Line type</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_WATP">Warranty type</param>
		/// <param name="m3_AAGN">Agreement</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddQuoteResponse></returns>
		/// <exception cref="M3Exception<AddQuoteResponse>"></exception>
		public async Task<M3Response<AddQuoteResponse>> AddQuote(
			string m3_CUNO, 
			string m3_QUTY, 
			string m3_CUNM = null, 
			string m3_TX40 = null, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			string m3_ORTP = null, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_LVDT = null, 
			string m3_RESP = null, 
			DateTime? m3_DWDT = null, 
			string m3_CUA1 = null, 
			string m3_CUA2 = null, 
			string m3_CUA3 = null, 
			string m3_CUA4 = null, 
			string m3_CESA = null, 
			string m3_LHCD = null, 
			string m3_CUCD = null, 
			int? m3_CRTP = null, 
			string m3_TEDL = null, 
			string m3_MODL = null, 
			string m3_TEPY = null, 
			decimal? m3_TXID = null, 
			string m3_PRNO = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			decimal? m3_ORQA = null, 
			decimal? m3_SAPR = null, 
			decimal? m3_UCOS = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			string m3_RSCD = null, 
			int? m3_QFOR = null, 
			int? m3_QPRO = null, 
			string m3_ADID = null, 
			string m3_SMCD = null, 
			string m3_SMNG = null, 
			string m3_YREF = null, 
			string m3_YRE2 = null, 
			string m3_PHNO = null, 
			string m3_PHN2 = null, 
			string m3_ECAR = null, 
			string m3_CSCD = null, 
			string m3_TOWN = null, 
			string m3_PONO = null, 
			string m3_TPCU = null, 
			DateTime? m3_DLDT = null, 
			string m3_CUCL = null, 
			string m3_OYNO = null, 
			string m3_QRNO = null, 
			string m3_QGRP = null, 
			string m3_FRCO = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_QCAT = null, 
			int? m3_SPST = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			string m3_WATP = null, 
			string m3_AAGN = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_QUTY))
				throw new ArgumentNullException("m3_QUTY");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("QUTY", m3_QUTY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNM))
				request.WithQueryParameter("CUNM", m3_CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTP))
				request.WithQueryParameter("ORTP", m3_ORTP.Trim());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3_DWDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CUA1))
				request.WithQueryParameter("CUA1", m3_CUA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA2))
				request.WithQueryParameter("CUA2", m3_CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA3))
				request.WithQueryParameter("CUA3", m3_CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA4))
				request.WithQueryParameter("CUA4", m3_CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CESA))
				request.WithQueryParameter("CESA", m3_CESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LHCD))
				request.WithQueryParameter("LHCD", m3_LHCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3_CRTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_ORQA.HasValue)
				request.WithQueryParameter("ORQA", m3_ORQA.Value.ToString());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_UCOS.HasValue)
				request.WithQueryParameter("UCOS", m3_UCOS.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (m3_QFOR.HasValue)
				request.WithQueryParameter("QFOR", m3_QFOR.Value.ToString());
			if (m3_QPRO.HasValue)
				request.WithQueryParameter("QPRO", m3_QPRO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMCD))
				request.WithQueryParameter("SMCD", m3_SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMNG))
				request.WithQueryParameter("SMNG", m3_SMNG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YRE2))
				request.WithQueryParameter("YRE2", m3_YRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHN2))
				request.WithQueryParameter("PHN2", m3_PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOWN))
				request.WithQueryParameter("TOWN", m3_TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TPCU))
				request.WithQueryParameter("TPCU", m3_TPCU.Trim());
			if (m3_DLDT.HasValue)
				request.WithQueryParameter("DLDT", m3_DLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CUCL))
				request.WithQueryParameter("CUCL", m3_CUCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OYNO))
				request.WithQueryParameter("OYNO", m3_OYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QRNO))
				request.WithQueryParameter("QRNO", m3_QRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QGRP))
				request.WithQueryParameter("QGRP", m3_QGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRCO))
				request.WithQueryParameter("FRCO", m3_FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QCAT))
				request.WithQueryParameter("QCAT", m3_QCAT.Trim());
			if (m3_SPST.HasValue)
				request.WithQueryParameter("SPST", m3_SPST.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WATP))
				request.WithQueryParameter("WATP", m3_WATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AAGN))
				request.WithQueryParameter("AAGN", m3_AAGN.Trim());

			// Execute the request
			var result = await Execute<AddQuoteResponse>(
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
		/// Name AddQuoteHead
		/// Description Add Quotation Head
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_QUTY">Quotation type (Required)</param>
		/// <param name="m3_CUNM">Customer name</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_ORTP">Customer order type</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_DWDT">Requested delivery date</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_LHCD">Language code order head</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_CRTP">Exchange rate type</param>
		/// <param name="m3_TEDL">Delivery terms</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_CUA1">Customer address 1</param>
		/// <param name="m3_CUA2">Customer address 2</param>
		/// <param name="m3_CUA3">Customer address 3</param>
		/// <param name="m3_CUA4">Customer address 4</param>
		/// <param name="m3_CESA">Marketing ID - Movex SMS</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_QFOR">Forcasting</param>
		/// <param name="m3_QPRO">Probability</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_SMCD">Salesperson</param>
		/// <param name="m3_SMNG">Sales manager</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_YRE2">Your reference 2</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_PHN2">Telephone number 2</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_PONO">Postal code</param>
		/// <param name="m3_TPCU">Template customer</param>
		/// <param name="m3_DLDT">Planned delivery date</param>
		/// <param name="m3_CUCL">Customer group</param>
		/// <param name="m3_OYNO">Opportunity number</param>
		/// <param name="m3_QRNO">Related quotation group</param>
		/// <param name="m3_QGRP">Quotation group</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_QCAT">Quotation category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddQuoteHeadResponse></returns>
		/// <exception cref="M3Exception<AddQuoteHeadResponse>"></exception>
		public async Task<M3Response<AddQuoteHeadResponse>> AddQuoteHead(
			string m3_CUNO, 
			string m3_QUTY, 
			string m3_CUNM = null, 
			string m3_TX40 = null, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			string m3_ORTP = null, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_LVDT = null, 
			DateTime? m3_DWDT = null, 
			string m3_RESP = null, 
			string m3_LHCD = null, 
			string m3_CUCD = null, 
			int? m3_CRTP = null, 
			string m3_TEDL = null, 
			string m3_MODL = null, 
			string m3_TEPY = null, 
			string m3_CUA1 = null, 
			string m3_CUA2 = null, 
			string m3_CUA3 = null, 
			string m3_CUA4 = null, 
			string m3_CESA = null, 
			decimal? m3_TXID = null, 
			string m3_RSCD = null, 
			int? m3_QFOR = null, 
			int? m3_QPRO = null, 
			string m3_ADID = null, 
			string m3_SMCD = null, 
			string m3_SMNG = null, 
			string m3_YREF = null, 
			string m3_YRE2 = null, 
			string m3_PHNO = null, 
			string m3_PHN2 = null, 
			string m3_ECAR = null, 
			string m3_CSCD = null, 
			string m3_TOWN = null, 
			string m3_PONO = null, 
			string m3_TPCU = null, 
			DateTime? m3_DLDT = null, 
			string m3_CUCL = null, 
			string m3_OYNO = null, 
			string m3_QRNO = null, 
			string m3_QGRP = null, 
			string m3_FRCO = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_QCAT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_QUTY))
				throw new ArgumentNullException("m3_QUTY");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("QUTY", m3_QUTY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNM))
				request.WithQueryParameter("CUNM", m3_CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTP))
				request.WithQueryParameter("ORTP", m3_ORTP.Trim());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (m3_DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3_DWDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LHCD))
				request.WithQueryParameter("LHCD", m3_LHCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3_CRTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA1))
				request.WithQueryParameter("CUA1", m3_CUA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA2))
				request.WithQueryParameter("CUA2", m3_CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA3))
				request.WithQueryParameter("CUA3", m3_CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA4))
				request.WithQueryParameter("CUA4", m3_CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CESA))
				request.WithQueryParameter("CESA", m3_CESA.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (m3_QFOR.HasValue)
				request.WithQueryParameter("QFOR", m3_QFOR.Value.ToString());
			if (m3_QPRO.HasValue)
				request.WithQueryParameter("QPRO", m3_QPRO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMCD))
				request.WithQueryParameter("SMCD", m3_SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMNG))
				request.WithQueryParameter("SMNG", m3_SMNG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YRE2))
				request.WithQueryParameter("YRE2", m3_YRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHN2))
				request.WithQueryParameter("PHN2", m3_PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOWN))
				request.WithQueryParameter("TOWN", m3_TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TPCU))
				request.WithQueryParameter("TPCU", m3_TPCU.Trim());
			if (m3_DLDT.HasValue)
				request.WithQueryParameter("DLDT", m3_DLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CUCL))
				request.WithQueryParameter("CUCL", m3_CUCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OYNO))
				request.WithQueryParameter("OYNO", m3_OYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QRNO))
				request.WithQueryParameter("QRNO", m3_QRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QGRP))
				request.WithQueryParameter("QGRP", m3_QGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRCO))
				request.WithQueryParameter("FRCO", m3_FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QCAT))
				request.WithQueryParameter("QCAT", m3_QCAT.Trim());

			// Execute the request
			var result = await Execute<AddQuoteHeadResponse>(
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
		/// Name AddQuoteLine
		/// Description Add Quotation Line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_OFNO">Quotation number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_ORQA">Ordered quantity - alternate U/M</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_UCOS">Cost price</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_DRDE">Direct delivery</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddQuoteLineResponse></returns>
		/// <exception cref="M3Exception<AddQuoteLineResponse>"></exception>
		public async Task<M3Response<AddQuoteLineResponse>> AddQuoteLine(
			string m3_OFNO, 
			int m3_VERS, 
			int m3_PONR, 
			int m3_POSX, 
			string m3_PRNO, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			decimal? m3_ORQA = null, 
			decimal? m3_SAPR = null, 
			decimal? m3_UCOS = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			string m3_WHLO = null, 
			int? m3_DRDE = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_OFNO))
				throw new ArgumentNullException("m3_OFNO");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("OFNO", m3_OFNO.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString())
				.WithQueryParameter("PRNO", m3_PRNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_ORQA.HasValue)
				request.WithQueryParameter("ORQA", m3_ORQA.Value.ToString());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_UCOS.HasValue)
				request.WithQueryParameter("UCOS", m3_UCOS.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_DRDE.HasValue)
				request.WithQueryParameter("DRDE", m3_DRDE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());

			// Execute the request
			var result = await Execute<AddQuoteLineResponse>(
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
		/// Name DltQuoteHead
		/// Description Delete Quotation Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_OFNO">Quotation number (Required)</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltQuoteHead(
			string m3_OFNO, 
			int? m3_VERS = null, 
			string m3_RSCD = null, 
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
			if (string.IsNullOrWhiteSpace(m3_OFNO))
				throw new ArgumentNullException("m3_OFNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("OFNO", m3_OFNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());

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
		/// Name DltQuoteLine
		/// Description Delete Quotatin Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_OFNO">Quotation number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltQuoteLine(
			string m3_OFNO, 
			int m3_VERS, 
			int m3_PONR, 
			int? m3_POSX = null, 
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
			if (string.IsNullOrWhiteSpace(m3_OFNO))
				throw new ArgumentNullException("m3_OFNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("OFNO", m3_OFNO.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString())
				.WithQueryParameter("PONR", m3_PONR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());

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
		/// Name GetQuoteHead
		/// Description Get Quotation Head
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_OFNO">Quotation number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetQuoteHeadResponse></returns>
		/// <exception cref="M3Exception<GetQuoteHeadResponse>"></exception>
		public async Task<M3Response<GetQuoteHeadResponse>> GetQuoteHead(
			string m3_OFNO, 
			int m3_VERS, 
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
			if (string.IsNullOrWhiteSpace(m3_OFNO))
				throw new ArgumentNullException("m3_OFNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("OFNO", m3_OFNO.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString());

			// Execute the request
			var result = await Execute<GetQuoteHeadResponse>(
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
		/// Name GetQuoteLine
		/// Description Get Quotation Line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_OFNO">Quotation number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetQuoteLineResponse></returns>
		/// <exception cref="M3Exception<GetQuoteLineResponse>"></exception>
		public async Task<M3Response<GetQuoteLineResponse>> GetQuoteLine(
			string m3_OFNO, 
			int m3_VERS, 
			int m3_PONR, 
			int m3_POSX, 
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
			if (string.IsNullOrWhiteSpace(m3_OFNO))
				throw new ArgumentNullException("m3_OFNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("OFNO", m3_OFNO.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString());

			// Execute the request
			var result = await Execute<GetQuoteLineResponse>(
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
		/// Name LstQuoteByCuno
		/// Description List Quatation Head By Customer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstQuoteByCunoResponse></returns>
		/// <exception cref="M3Exception<LstQuoteByCunoResponse>"></exception>
		public async Task<M3Response<LstQuoteByCunoResponse>> LstQuoteByCuno(
			string m3_CUNO = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Execute the request
			var result = await Execute<LstQuoteByCunoResponse>(
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
		/// Name LstQuoteByGuid
		/// Description List Quatation Head By Guid
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CESA">Marketing ID - Movex SMS</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstQuoteByGuidResponse></returns>
		/// <exception cref="M3Exception<LstQuoteByGuidResponse>"></exception>
		public async Task<M3Response<LstQuoteByGuidResponse>> LstQuoteByGuid(
			string m3_CESA = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_CESA))
				request.WithQueryParameter("CESA", m3_CESA.Trim());

			// Execute the request
			var result = await Execute<LstQuoteByGuidResponse>(
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
		/// Name LstQuoteByTme
		/// Description List Quotation Head By Timestamp
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstQuoteByTmeResponse></returns>
		/// <exception cref="M3Exception<LstQuoteByTmeResponse>"></exception>
		public async Task<M3Response<LstQuoteByTmeResponse>> LstQuoteByTme(
			decimal? m3_LMTS = null, 
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
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstQuoteByTmeResponse>(
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
		/// Name LstQuoteHead
		/// Description List Quotation Head
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_OFNO">Quotation number</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstQuoteHeadResponse></returns>
		/// <exception cref="M3Exception<LstQuoteHeadResponse>"></exception>
		public async Task<M3Response<LstQuoteHeadResponse>> LstQuoteHead(
			string m3_OFNO = null, 
			int? m3_VERS = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_OFNO))
				request.WithQueryParameter("OFNO", m3_OFNO.Trim());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());

			// Execute the request
			var result = await Execute<LstQuoteHeadResponse>(
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
		/// Name LstQuoteLine
		/// Description ist Quotation Liner
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_OFNO">Quotation number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstQuoteLineResponse></returns>
		/// <exception cref="M3Exception<LstQuoteLineResponse>"></exception>
		public async Task<M3Response<LstQuoteLineResponse>> LstQuoteLine(
			string m3_OFNO, 
			int m3_VERS, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
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
			if (string.IsNullOrWhiteSpace(m3_OFNO))
				throw new ArgumentNullException("m3_OFNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("OFNO", m3_OFNO.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());

			// Execute the request
			var result = await Execute<LstQuoteLineResponse>(
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
		/// Name UpdQuoteHead
		/// Description Update Quotation Head
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_OFNO">Quotation number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_CUNM">Customer name</param>
		/// <param name="m3_QUTY">Quotation type</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_ORTP">Customer order type</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_DWDT">Requested delivery date</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_LHCD">Language code order head</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_CRTP">Exchange rate type</param>
		/// <param name="m3_TEDL">Delivery terms</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_CUA1">Customer address 1</param>
		/// <param name="m3_CUA2">Customer address 2</param>
		/// <param name="m3_CUA3">Customer address 3</param>
		/// <param name="m3_CUA4">Customer address 4</param>
		/// <param name="m3_CESA">Marketing ID - Movex SMS</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_QFOR">Forcasting</param>
		/// <param name="m3_QPRO">Probability</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_SMCD">Salesperson</param>
		/// <param name="m3_SMNG">Sales manager</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_YRE2">Your reference 2</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_PHN2">Telephone number 2</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_PONO">Postal code</param>
		/// <param name="m3_TPCU">Template customer</param>
		/// <param name="m3_DLDT">Planned delivery date</param>
		/// <param name="m3_QGRP">Quotation group</param>
		/// <param name="m3_QRNO">Related quotation no</param>
		/// <param name="m3_OYNO">Opportunity number</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_QCAT">Quotation category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<UpdQuoteHeadResponse></returns>
		/// <exception cref="M3Exception<UpdQuoteHeadResponse>"></exception>
		public async Task<M3Response<UpdQuoteHeadResponse>> UpdQuoteHead(
			string m3_OFNO, 
			int m3_VERS, 
			string m3_CUNO = null, 
			string m3_CUNM = null, 
			string m3_QUTY = null, 
			string m3_TX40 = null, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			string m3_ORTP = null, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_LVDT = null, 
			DateTime? m3_DWDT = null, 
			string m3_RESP = null, 
			string m3_LHCD = null, 
			string m3_CUCD = null, 
			int? m3_CRTP = null, 
			string m3_TEDL = null, 
			string m3_MODL = null, 
			string m3_TEPY = null, 
			string m3_CUA1 = null, 
			string m3_CUA2 = null, 
			string m3_CUA3 = null, 
			string m3_CUA4 = null, 
			string m3_CESA = null, 
			decimal? m3_TXID = null, 
			string m3_RSCD = null, 
			int? m3_QFOR = null, 
			int? m3_QPRO = null, 
			string m3_ADID = null, 
			string m3_SMCD = null, 
			string m3_SMNG = null, 
			string m3_YREF = null, 
			string m3_YRE2 = null, 
			string m3_PHNO = null, 
			string m3_PHN2 = null, 
			string m3_ECAR = null, 
			string m3_CSCD = null, 
			string m3_TOWN = null, 
			string m3_PONO = null, 
			string m3_TPCU = null, 
			DateTime? m3_DLDT = null, 
			string m3_QGRP = null, 
			string m3_QRNO = null, 
			string m3_OYNO = null, 
			string m3_FRCO = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_QCAT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_OFNO))
				throw new ArgumentNullException("m3_OFNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("OFNO", m3_OFNO.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNM))
				request.WithQueryParameter("CUNM", m3_CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QUTY))
				request.WithQueryParameter("QUTY", m3_QUTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTP))
				request.WithQueryParameter("ORTP", m3_ORTP.Trim());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (m3_DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3_DWDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LHCD))
				request.WithQueryParameter("LHCD", m3_LHCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3_CRTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA1))
				request.WithQueryParameter("CUA1", m3_CUA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA2))
				request.WithQueryParameter("CUA2", m3_CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA3))
				request.WithQueryParameter("CUA3", m3_CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA4))
				request.WithQueryParameter("CUA4", m3_CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CESA))
				request.WithQueryParameter("CESA", m3_CESA.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (m3_QFOR.HasValue)
				request.WithQueryParameter("QFOR", m3_QFOR.Value.ToString());
			if (m3_QPRO.HasValue)
				request.WithQueryParameter("QPRO", m3_QPRO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMCD))
				request.WithQueryParameter("SMCD", m3_SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMNG))
				request.WithQueryParameter("SMNG", m3_SMNG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YRE2))
				request.WithQueryParameter("YRE2", m3_YRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHN2))
				request.WithQueryParameter("PHN2", m3_PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOWN))
				request.WithQueryParameter("TOWN", m3_TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TPCU))
				request.WithQueryParameter("TPCU", m3_TPCU.Trim());
			if (m3_DLDT.HasValue)
				request.WithQueryParameter("DLDT", m3_DLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_QGRP))
				request.WithQueryParameter("QGRP", m3_QGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QRNO))
				request.WithQueryParameter("QRNO", m3_QRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OYNO))
				request.WithQueryParameter("OYNO", m3_OYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRCO))
				request.WithQueryParameter("FRCO", m3_FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QCAT))
				request.WithQueryParameter("QCAT", m3_QCAT.Trim());

			// Execute the request
			var result = await Execute<UpdQuoteHeadResponse>(
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
