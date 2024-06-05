/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.OPS270MI;
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
	/// Name: OPS270MI
	/// Component Name: PointOfSale
	/// Description: POS Sales Tickets interface
	/// Version Release: 5ea0
	///</summary>
	public partial class OPS270MIResource : M3BaseResourceEndpoint
	{
		public OPS270MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OPS270MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddRoundNumber
		/// Description Add interface round number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddRoundNumberResponse></returns>
		/// <exception cref="M3Exception<AddRoundNumberResponse>"></exception>
		public async Task<M3Response<AddRoundNumberResponse>> AddRoundNumber(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddRoundNumber",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<AddRoundNumberResponse>(
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
		/// Name AddSlsTicketLin
		/// Description Add sales ticket line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_XRCD">Record type</param>
		/// <param name="m3_ITRN">Interface round number</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_CSHC">Cash code</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TRTM">Transaction time</param>
		/// <param name="m3_CUAM">Foreign currency amount</param>
		/// <param name="m3_VTCD">VAT code</param>
		/// <param name="m3_DUDT">Due date</param>
		/// <param name="m3_PYCD">Payment method - accounts receivable</param>
		/// <param name="m3_ALUN">Alternate U/M</param>
		/// <param name="m3_IVQA">Invoiced quantity - alternate U/M</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_DIA1">Discount amount 1</param>
		/// <param name="m3_IVNO">Invoice number</param>
		/// <param name="m3_INYR">Invoice year</param>
		/// <param name="m3_SERI">Serial number</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_SDEP">Sales department</param>
		/// <param name="m3_DIA2">Discount amount 2</param>
		/// <param name="m3_DIA3">Discount amount 3</param>
		/// <param name="m3_DIA4">Discount amount 4</param>
		/// <param name="m3_DIA5">Discount amount 5</param>
		/// <param name="m3_DIA6">Discount amount 6</param>
		/// <param name="m3_REFE">Reference</param>
		/// <param name="m3_CMNO">Sales campaign</param>
		/// <param name="m3_FVT1">Calculated VAT amount 1</param>
		/// <param name="m3_FVT2">Calculated VAT amount 2</param>
		/// <param name="m3_FVT3">Calculated VAT amount 3</param>
		/// <param name="m3_FVT4">Calculated VAT amount 4</param>
		/// <param name="m3_VTP1">VAT rate 1</param>
		/// <param name="m3_VTP2">VAT rate 2</param>
		/// <param name="m3_FRE1">Statistics identity 1 customer</param>
		/// <param name="m3_FRE2">Statistics identity 2 customer</param>
		/// <param name="m3_FRE3">Statistics identity 3 item</param>
		/// <param name="m3_FRE4">Statistics identity 4 item</param>
		/// <param name="m3_ARAT">Exchange rate</param>
		/// <param name="m3_CRTP">Exchange rate type</param>
		/// <param name="m3_INPX">Invoice Prefix</param>
		/// <param name="m3_EXIN">Extended Invoice Number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWT">Alias category</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_MCHP">Price change indicator</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSlsTicketLin(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_XRCD = null, 
			decimal? m3_ITRN = null, 
			string m3_WHLO = null, 
			string m3_CSHC = null, 
			string m3_ORNO = null, 
			decimal? m3_DLIX = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			string m3_CUCD = null, 
			string m3_CUNO = null, 
			string m3_ITNO = null, 
			DateTime? m3_TRDT = null, 
			int? m3_TRTM = null, 
			decimal? m3_CUAM = null, 
			int? m3_VTCD = null, 
			DateTime? m3_DUDT = null, 
			string m3_PYCD = null, 
			string m3_ALUN = null, 
			decimal? m3_IVQA = null, 
			string m3_RSCD = null, 
			decimal? m3_DIA1 = null, 
			int? m3_IVNO = null, 
			int? m3_INYR = null, 
			string m3_SERI = null, 
			string m3_RESP = null, 
			string m3_SDEP = null, 
			decimal? m3_DIA2 = null, 
			decimal? m3_DIA3 = null, 
			decimal? m3_DIA4 = null, 
			decimal? m3_DIA5 = null, 
			decimal? m3_DIA6 = null, 
			string m3_REFE = null, 
			string m3_CMNO = null, 
			decimal? m3_FVT1 = null, 
			decimal? m3_FVT2 = null, 
			decimal? m3_FVT3 = null, 
			decimal? m3_FVT4 = null, 
			int? m3_VTP1 = null, 
			int? m3_VTP2 = null, 
			string m3_FRE1 = null, 
			string m3_FRE2 = null, 
			string m3_FRE3 = null, 
			string m3_FRE4 = null, 
			decimal? m3_ARAT = null, 
			int? m3_CRTP = null, 
			string m3_INPX = null, 
			string m3_EXIN = null, 
			string m3_POPN = null, 
			int? m3_ALWT = null, 
			string m3_ALWQ = null, 
			string m3_PYNO = null, 
			int? m3_MCHP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSlsTicketLin",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_XRCD))
				request.WithQueryParameter("XRCD", m3_XRCD.Trim());
			if (m3_ITRN.HasValue)
				request.WithQueryParameter("ITRN", m3_ITRN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSHC))
				request.WithQueryParameter("CSHC", m3_CSHC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());
			if (m3_CUAM.HasValue)
				request.WithQueryParameter("CUAM", m3_CUAM.Value.ToString());
			if (m3_VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3_VTCD.Value.ToString());
			if (m3_DUDT.HasValue)
				request.WithQueryParameter("DUDT", m3_DUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PYCD))
				request.WithQueryParameter("PYCD", m3_PYCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());
			if (m3_IVQA.HasValue)
				request.WithQueryParameter("IVQA", m3_IVQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (m3_DIA1.HasValue)
				request.WithQueryParameter("DIA1", m3_DIA1.Value.ToString());
			if (m3_IVNO.HasValue)
				request.WithQueryParameter("IVNO", m3_IVNO.Value.ToString());
			if (m3_INYR.HasValue)
				request.WithQueryParameter("INYR", m3_INYR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SERI))
				request.WithQueryParameter("SERI", m3_SERI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDEP))
				request.WithQueryParameter("SDEP", m3_SDEP.Trim());
			if (m3_DIA2.HasValue)
				request.WithQueryParameter("DIA2", m3_DIA2.Value.ToString());
			if (m3_DIA3.HasValue)
				request.WithQueryParameter("DIA3", m3_DIA3.Value.ToString());
			if (m3_DIA4.HasValue)
				request.WithQueryParameter("DIA4", m3_DIA4.Value.ToString());
			if (m3_DIA5.HasValue)
				request.WithQueryParameter("DIA5", m3_DIA5.Value.ToString());
			if (m3_DIA6.HasValue)
				request.WithQueryParameter("DIA6", m3_DIA6.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REFE))
				request.WithQueryParameter("REFE", m3_REFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CMNO))
				request.WithQueryParameter("CMNO", m3_CMNO.Trim());
			if (m3_FVT1.HasValue)
				request.WithQueryParameter("FVT1", m3_FVT1.Value.ToString());
			if (m3_FVT2.HasValue)
				request.WithQueryParameter("FVT2", m3_FVT2.Value.ToString());
			if (m3_FVT3.HasValue)
				request.WithQueryParameter("FVT3", m3_FVT3.Value.ToString());
			if (m3_FVT4.HasValue)
				request.WithQueryParameter("FVT4", m3_FVT4.Value.ToString());
			if (m3_VTP1.HasValue)
				request.WithQueryParameter("VTP1", m3_VTP1.Value.ToString());
			if (m3_VTP2.HasValue)
				request.WithQueryParameter("VTP2", m3_VTP2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRE1))
				request.WithQueryParameter("FRE1", m3_FRE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRE2))
				request.WithQueryParameter("FRE2", m3_FRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRE3))
				request.WithQueryParameter("FRE3", m3_FRE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRE4))
				request.WithQueryParameter("FRE4", m3_FRE4.Trim());
			if (m3_ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3_ARAT.Value.ToString());
			if (m3_CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3_CRTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INPX))
				request.WithQueryParameter("INPX", m3_INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXIN))
				request.WithQueryParameter("EXIN", m3_EXIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (m3_MCHP.HasValue)
				request.WithQueryParameter("MCHP", m3_MCHP.Value.ToString());

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
		/// Name AddSlsTicketPay
		/// Description Send sales ticket payment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_XRCD">Record type</param>
		/// <param name="m3_ITRN">Interface round number</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_CSHC">Cash code</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TRTM">Transaction time</param>
		/// <param name="m3_CUAM">Foreign currency amount</param>
		/// <param name="m3_PYCD">Payment method - accounts receivable</param>
		/// <param name="m3_REFE">Reference</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_CRCT">Card type</param>
		/// <param name="m3_CRCN">Credit card number</param>
		/// <param name="m3_EPDA">Expiration date</param>
		/// <param name="m3_DUDT">Due date</param>
		/// <param name="m3_ARAT">Exchange rate</param>
		/// <param name="m3_CRTP">Exchange rate type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSlsTicketPay(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_XRCD = null, 
			decimal? m3_ITRN = null, 
			string m3_WHLO = null, 
			string m3_CSHC = null, 
			string m3_ORNO = null, 
			decimal? m3_DLIX = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			string m3_CUCD = null, 
			DateTime? m3_TRDT = null, 
			int? m3_TRTM = null, 
			decimal? m3_CUAM = null, 
			string m3_PYCD = null, 
			string m3_REFE = null, 
			string m3_RESP = null, 
			string m3_CRCT = null, 
			string m3_CRCN = null, 
			string m3_EPDA = null, 
			DateTime? m3_DUDT = null, 
			decimal? m3_ARAT = null, 
			int? m3_CRTP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSlsTicketPay",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_XRCD))
				request.WithQueryParameter("XRCD", m3_XRCD.Trim());
			if (m3_ITRN.HasValue)
				request.WithQueryParameter("ITRN", m3_ITRN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSHC))
				request.WithQueryParameter("CSHC", m3_CSHC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());
			if (m3_CUAM.HasValue)
				request.WithQueryParameter("CUAM", m3_CUAM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PYCD))
				request.WithQueryParameter("PYCD", m3_PYCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REFE))
				request.WithQueryParameter("REFE", m3_REFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CRCT))
				request.WithQueryParameter("CRCT", m3_CRCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CRCN))
				request.WithQueryParameter("CRCN", m3_CRCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EPDA))
				request.WithQueryParameter("EPDA", m3_EPDA.Trim());
			if (m3_DUDT.HasValue)
				request.WithQueryParameter("DUDT", m3_DUDT.Value.ToM3String());
			if (m3_ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3_ARAT.Value.ToString());
			if (m3_CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3_CRTP.Value.ToString());

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
		/// Name BchPrcRound
		/// Description Batch process round number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITRN">Interface round number (Required)</param>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_ACDT">Accounting date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_OPMM">Inventory accounting interface</param>
		/// <param name="m3_OPSS">Sales statistics interface</param>
		/// <param name="m3_OPGL">Financial interface</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> BchPrcRound(
			decimal m3_ITRN, 
			string m3_DIVI, 
			DateTime m3_ACDT, 
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			DateTime? m3_TRDT = null, 
			int? m3_OPMM = null, 
			int? m3_OPSS = null, 
			int? m3_OPGL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/BchPrcRound",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITRN", m3_ITRN.ToString())
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("ACDT", m3_ACDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_OPMM.HasValue)
				request.WithQueryParameter("OPMM", m3_OPMM.Value.ToString());
			if (m3_OPSS.HasValue)
				request.WithQueryParameter("OPSS", m3_OPSS.Value.ToString());
			if (m3_OPGL.HasValue)
				request.WithQueryParameter("OPGL", m3_OPGL.Value.ToString());

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
		/// Name DelRoundNumber
		/// Description Delete interface round Number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITRN">Interface round number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DelRoundNumberResponse></returns>
		/// <exception cref="M3Exception<DelRoundNumberResponse>"></exception>
		public async Task<M3Response<DelRoundNumberResponse>> DelRoundNumber(
			decimal m3_ITRN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelRoundNumber",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("ITRN", m3_ITRN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<DelRoundNumberResponse>(
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
		/// Name GetRoundNumber
		/// Description Get info about interface round number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITRN">Interface round number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetRoundNumberResponse></returns>
		/// <exception cref="M3Exception<GetRoundNumberResponse>"></exception>
		public async Task<M3Response<GetRoundNumberResponse>> GetRoundNumber(
			decimal m3_ITRN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetRoundNumber",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("ITRN", m3_ITRN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetRoundNumberResponse>(
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
		/// Name SndSlsTicketLin
		/// Description Send sales ticket line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_XRCD">Record type</param>
		/// <param name="m3_ITRN">Interface round number</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_CSHC">Cash code</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TRTM">Transaction time</param>
		/// <param name="m3_CUAM">Foreign currency amount</param>
		/// <param name="m3_VTCD">VAT code</param>
		/// <param name="m3_DUDT">Due date</param>
		/// <param name="m3_PYCD">Payment method - accounts receivable</param>
		/// <param name="m3_ALUN">Alternate U/M</param>
		/// <param name="m3_IVQA">Invoiced quantity - alternate U/M</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_DIA1">Discount amount 1</param>
		/// <param name="m3_IVNO">Invoice number</param>
		/// <param name="m3_INYR">Invoice year</param>
		/// <param name="m3_SERI">Serial number</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_SDEP">Sales department</param>
		/// <param name="m3_DIA2">Discount amount 2</param>
		/// <param name="m3_DIA3">Discount amount 3</param>
		/// <param name="m3_DIA4">Discount amount 4</param>
		/// <param name="m3_DIA5">Discount amount 5</param>
		/// <param name="m3_DIA6">Discount amount 6</param>
		/// <param name="m3_REFE">Reference</param>
		/// <param name="m3_CMNO">Sales campaign</param>
		/// <param name="m3_FVT1">Calculated VAT amount 1</param>
		/// <param name="m3_FVT2">Calculated VAT amount 2</param>
		/// <param name="m3_FVT3">Calculated VAT amount 3</param>
		/// <param name="m3_FVT4">Calculated VAT amount 4</param>
		/// <param name="m3_VTP1">VAT rate 1</param>
		/// <param name="m3_VTP2">VAT rate 2</param>
		/// <param name="m3_FRE1">Statistics identity 1 customer</param>
		/// <param name="m3_FRE2">Statistics identity 2 customer</param>
		/// <param name="m3_FRE3">Statistics identity 3 item</param>
		/// <param name="m3_FRE4">Statistics identity 4 item</param>
		/// <param name="m3_ARAT">Exchange rate</param>
		/// <param name="m3_CRTP">Exchange rate type</param>
		/// <param name="m3_INPX">Invoice Prefix</param>
		/// <param name="m3_EXIN">Extended Invoice Number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWT">Alias category</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_MCHP">Price change indicator</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndSlsTicketLin(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_XRCD = null, 
			decimal? m3_ITRN = null, 
			string m3_WHLO = null, 
			string m3_CSHC = null, 
			string m3_ORNO = null, 
			decimal? m3_DLIX = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			string m3_CUCD = null, 
			string m3_CUNO = null, 
			string m3_ITNO = null, 
			DateTime? m3_TRDT = null, 
			int? m3_TRTM = null, 
			decimal? m3_CUAM = null, 
			int? m3_VTCD = null, 
			DateTime? m3_DUDT = null, 
			string m3_PYCD = null, 
			string m3_ALUN = null, 
			decimal? m3_IVQA = null, 
			string m3_RSCD = null, 
			decimal? m3_DIA1 = null, 
			int? m3_IVNO = null, 
			int? m3_INYR = null, 
			string m3_SERI = null, 
			string m3_RESP = null, 
			string m3_SDEP = null, 
			decimal? m3_DIA2 = null, 
			decimal? m3_DIA3 = null, 
			decimal? m3_DIA4 = null, 
			decimal? m3_DIA5 = null, 
			decimal? m3_DIA6 = null, 
			string m3_REFE = null, 
			string m3_CMNO = null, 
			decimal? m3_FVT1 = null, 
			decimal? m3_FVT2 = null, 
			decimal? m3_FVT3 = null, 
			decimal? m3_FVT4 = null, 
			int? m3_VTP1 = null, 
			int? m3_VTP2 = null, 
			string m3_FRE1 = null, 
			string m3_FRE2 = null, 
			string m3_FRE3 = null, 
			string m3_FRE4 = null, 
			decimal? m3_ARAT = null, 
			int? m3_CRTP = null, 
			string m3_INPX = null, 
			string m3_EXIN = null, 
			string m3_POPN = null, 
			int? m3_ALWT = null, 
			string m3_ALWQ = null, 
			string m3_PYNO = null, 
			int? m3_MCHP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndSlsTicketLin",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_XRCD))
				request.WithQueryParameter("XRCD", m3_XRCD.Trim());
			if (m3_ITRN.HasValue)
				request.WithQueryParameter("ITRN", m3_ITRN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSHC))
				request.WithQueryParameter("CSHC", m3_CSHC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());
			if (m3_CUAM.HasValue)
				request.WithQueryParameter("CUAM", m3_CUAM.Value.ToString());
			if (m3_VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3_VTCD.Value.ToString());
			if (m3_DUDT.HasValue)
				request.WithQueryParameter("DUDT", m3_DUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PYCD))
				request.WithQueryParameter("PYCD", m3_PYCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());
			if (m3_IVQA.HasValue)
				request.WithQueryParameter("IVQA", m3_IVQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (m3_DIA1.HasValue)
				request.WithQueryParameter("DIA1", m3_DIA1.Value.ToString());
			if (m3_IVNO.HasValue)
				request.WithQueryParameter("IVNO", m3_IVNO.Value.ToString());
			if (m3_INYR.HasValue)
				request.WithQueryParameter("INYR", m3_INYR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SERI))
				request.WithQueryParameter("SERI", m3_SERI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDEP))
				request.WithQueryParameter("SDEP", m3_SDEP.Trim());
			if (m3_DIA2.HasValue)
				request.WithQueryParameter("DIA2", m3_DIA2.Value.ToString());
			if (m3_DIA3.HasValue)
				request.WithQueryParameter("DIA3", m3_DIA3.Value.ToString());
			if (m3_DIA4.HasValue)
				request.WithQueryParameter("DIA4", m3_DIA4.Value.ToString());
			if (m3_DIA5.HasValue)
				request.WithQueryParameter("DIA5", m3_DIA5.Value.ToString());
			if (m3_DIA6.HasValue)
				request.WithQueryParameter("DIA6", m3_DIA6.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REFE))
				request.WithQueryParameter("REFE", m3_REFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CMNO))
				request.WithQueryParameter("CMNO", m3_CMNO.Trim());
			if (m3_FVT1.HasValue)
				request.WithQueryParameter("FVT1", m3_FVT1.Value.ToString());
			if (m3_FVT2.HasValue)
				request.WithQueryParameter("FVT2", m3_FVT2.Value.ToString());
			if (m3_FVT3.HasValue)
				request.WithQueryParameter("FVT3", m3_FVT3.Value.ToString());
			if (m3_FVT4.HasValue)
				request.WithQueryParameter("FVT4", m3_FVT4.Value.ToString());
			if (m3_VTP1.HasValue)
				request.WithQueryParameter("VTP1", m3_VTP1.Value.ToString());
			if (m3_VTP2.HasValue)
				request.WithQueryParameter("VTP2", m3_VTP2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRE1))
				request.WithQueryParameter("FRE1", m3_FRE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRE2))
				request.WithQueryParameter("FRE2", m3_FRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRE3))
				request.WithQueryParameter("FRE3", m3_FRE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRE4))
				request.WithQueryParameter("FRE4", m3_FRE4.Trim());
			if (m3_ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3_ARAT.Value.ToString());
			if (m3_CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3_CRTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INPX))
				request.WithQueryParameter("INPX", m3_INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXIN))
				request.WithQueryParameter("EXIN", m3_EXIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (m3_MCHP.HasValue)
				request.WithQueryParameter("MCHP", m3_MCHP.Value.ToString());

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
		/// Name SndSlsTicketPay
		/// Description Send sales ticket payment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_XRCD">Record type</param>
		/// <param name="m3_ITRN">Interface round number</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_CSHC">Cash code</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TRTM">Transaction time</param>
		/// <param name="m3_CUAM">Foreign currency amount</param>
		/// <param name="m3_PYCD">Payment method - accounts receivable</param>
		/// <param name="m3_REFE">Reference</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_CRCT">Card type</param>
		/// <param name="m3_CRCN">Credit card number</param>
		/// <param name="m3_EPDA">Expiration date</param>
		/// <param name="m3_DUDT">Due date</param>
		/// <param name="m3_ARAT">Exchange rate</param>
		/// <param name="m3_CRTP">Exchange rate type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndSlsTicketPay(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_XRCD = null, 
			decimal? m3_ITRN = null, 
			string m3_WHLO = null, 
			string m3_CSHC = null, 
			string m3_ORNO = null, 
			decimal? m3_DLIX = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			string m3_CUCD = null, 
			DateTime? m3_TRDT = null, 
			int? m3_TRTM = null, 
			decimal? m3_CUAM = null, 
			string m3_PYCD = null, 
			string m3_REFE = null, 
			string m3_RESP = null, 
			string m3_CRCT = null, 
			string m3_CRCN = null, 
			string m3_EPDA = null, 
			DateTime? m3_DUDT = null, 
			decimal? m3_ARAT = null, 
			int? m3_CRTP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndSlsTicketPay",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_XRCD))
				request.WithQueryParameter("XRCD", m3_XRCD.Trim());
			if (m3_ITRN.HasValue)
				request.WithQueryParameter("ITRN", m3_ITRN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSHC))
				request.WithQueryParameter("CSHC", m3_CSHC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());
			if (m3_CUAM.HasValue)
				request.WithQueryParameter("CUAM", m3_CUAM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PYCD))
				request.WithQueryParameter("PYCD", m3_PYCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REFE))
				request.WithQueryParameter("REFE", m3_REFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CRCT))
				request.WithQueryParameter("CRCT", m3_CRCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CRCN))
				request.WithQueryParameter("CRCN", m3_CRCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EPDA))
				request.WithQueryParameter("EPDA", m3_EPDA.Trim());
			if (m3_DUDT.HasValue)
				request.WithQueryParameter("DUDT", m3_DUDT.Value.ToM3String());
			if (m3_ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3_ARAT.Value.ToString());
			if (m3_CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3_CRTP.Value.ToString());

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
