/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddRoundNumberResponse></returns>
		/// <exception cref="M3Exception<AddRoundNumberResponse>"></exception>
		public async Task<M3Response<AddRoundNumberResponse>> AddRoundNumber(
			int? m3CONO = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddRoundNumberResponse>(
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
		/// Name AddSlsTicketLin
		/// Description Add sales ticket line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3XRCD">Record type</param>
		/// <param name="m3ITRN">Interface round number</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3CSHC">Cash code</param>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3TRTM">Transaction time</param>
		/// <param name="m3CUAM">Foreign currency amount</param>
		/// <param name="m3VTCD">VAT code</param>
		/// <param name="m3DUDT">Due date</param>
		/// <param name="m3PYCD">Payment method - accounts receivable</param>
		/// <param name="m3ALUN">Alternate U/M</param>
		/// <param name="m3IVQA">Invoiced quantity - alternate U/M</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3DIA1">Discount amount 1</param>
		/// <param name="m3IVNO">Invoice number</param>
		/// <param name="m3INYR">Invoice year</param>
		/// <param name="m3SERI">Serial number</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3SDEP">Sales department</param>
		/// <param name="m3DIA2">Discount amount 2</param>
		/// <param name="m3DIA3">Discount amount 3</param>
		/// <param name="m3DIA4">Discount amount 4</param>
		/// <param name="m3DIA5">Discount amount 5</param>
		/// <param name="m3DIA6">Discount amount 6</param>
		/// <param name="m3REFE">Reference</param>
		/// <param name="m3CMNO">Sales campaign</param>
		/// <param name="m3FVT1">Calculated VAT amount 1</param>
		/// <param name="m3FVT2">Calculated VAT amount 2</param>
		/// <param name="m3FVT3">Calculated VAT amount 3</param>
		/// <param name="m3FVT4">Calculated VAT amount 4</param>
		/// <param name="m3VTP1">VAT rate 1</param>
		/// <param name="m3VTP2">VAT rate 2</param>
		/// <param name="m3FRE1">Statistics identity 1 customer</param>
		/// <param name="m3FRE2">Statistics identity 2 customer</param>
		/// <param name="m3FRE3">Statistics identity 3 item</param>
		/// <param name="m3FRE4">Statistics identity 4 item</param>
		/// <param name="m3ARAT">Exchange rate</param>
		/// <param name="m3CRTP">Exchange rate type</param>
		/// <param name="m3INPX">Invoice Prefix</param>
		/// <param name="m3EXIN">Extended Invoice Number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWT">Alias category</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3MCHP">Price change indicator</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSlsTicketLin(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3XRCD = null, 
			decimal? m3ITRN = null, 
			string m3WHLO = null, 
			string m3CSHC = null, 
			string m3ORNO = null, 
			decimal? m3DLIX = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
			string m3CUCD = null, 
			string m3CUNO = null, 
			string m3ITNO = null, 
			DateTime? m3TRDT = null, 
			int? m3TRTM = null, 
			decimal? m3CUAM = null, 
			int? m3VTCD = null, 
			DateTime? m3DUDT = null, 
			string m3PYCD = null, 
			string m3ALUN = null, 
			decimal? m3IVQA = null, 
			string m3RSCD = null, 
			decimal? m3DIA1 = null, 
			int? m3IVNO = null, 
			int? m3INYR = null, 
			string m3SERI = null, 
			string m3RESP = null, 
			string m3SDEP = null, 
			decimal? m3DIA2 = null, 
			decimal? m3DIA3 = null, 
			decimal? m3DIA4 = null, 
			decimal? m3DIA5 = null, 
			decimal? m3DIA6 = null, 
			string m3REFE = null, 
			string m3CMNO = null, 
			decimal? m3FVT1 = null, 
			decimal? m3FVT2 = null, 
			decimal? m3FVT3 = null, 
			decimal? m3FVT4 = null, 
			int? m3VTP1 = null, 
			int? m3VTP2 = null, 
			string m3FRE1 = null, 
			string m3FRE2 = null, 
			string m3FRE3 = null, 
			string m3FRE4 = null, 
			decimal? m3ARAT = null, 
			int? m3CRTP = null, 
			string m3INPX = null, 
			string m3EXIN = null, 
			string m3POPN = null, 
			int? m3ALWT = null, 
			string m3ALWQ = null, 
			string m3PYNO = null, 
			int? m3MCHP = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3XRCD))
				request.WithQueryParameter("XRCD", m3XRCD.Trim());
			if (m3ITRN.HasValue)
				request.WithQueryParameter("ITRN", m3ITRN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSHC))
				request.WithQueryParameter("CSHC", m3CSHC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (m3TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3TRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CUAM.HasValue)
				request.WithQueryParameter("CUAM", m3CUAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3VTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DUDT.HasValue)
				request.WithQueryParameter("DUDT", m3DUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PYCD))
				request.WithQueryParameter("PYCD", m3PYCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALUN))
				request.WithQueryParameter("ALUN", m3ALUN.Trim());
			if (m3IVQA.HasValue)
				request.WithQueryParameter("IVQA", m3IVQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (m3DIA1.HasValue)
				request.WithQueryParameter("DIA1", m3DIA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IVNO.HasValue)
				request.WithQueryParameter("IVNO", m3IVNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INYR.HasValue)
				request.WithQueryParameter("INYR", m3INYR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SERI))
				request.WithQueryParameter("SERI", m3SERI.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDEP))
				request.WithQueryParameter("SDEP", m3SDEP.Trim());
			if (m3DIA2.HasValue)
				request.WithQueryParameter("DIA2", m3DIA2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIA3.HasValue)
				request.WithQueryParameter("DIA3", m3DIA3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIA4.HasValue)
				request.WithQueryParameter("DIA4", m3DIA4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIA5.HasValue)
				request.WithQueryParameter("DIA5", m3DIA5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIA6.HasValue)
				request.WithQueryParameter("DIA6", m3DIA6.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REFE))
				request.WithQueryParameter("REFE", m3REFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3CMNO))
				request.WithQueryParameter("CMNO", m3CMNO.Trim());
			if (m3FVT1.HasValue)
				request.WithQueryParameter("FVT1", m3FVT1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FVT2.HasValue)
				request.WithQueryParameter("FVT2", m3FVT2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FVT3.HasValue)
				request.WithQueryParameter("FVT3", m3FVT3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FVT4.HasValue)
				request.WithQueryParameter("FVT4", m3FVT4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTP1.HasValue)
				request.WithQueryParameter("VTP1", m3VTP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTP2.HasValue)
				request.WithQueryParameter("VTP2", m3VTP2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRE1))
				request.WithQueryParameter("FRE1", m3FRE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRE2))
				request.WithQueryParameter("FRE2", m3FRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRE3))
				request.WithQueryParameter("FRE3", m3FRE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRE4))
				request.WithQueryParameter("FRE4", m3FRE4.Trim());
			if (m3ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3ARAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3CRTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INPX))
				request.WithQueryParameter("INPX", m3INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXIN))
				request.WithQueryParameter("EXIN", m3EXIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (m3MCHP.HasValue)
				request.WithQueryParameter("MCHP", m3MCHP.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddSlsTicketPay
		/// Description Send sales ticket payment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3XRCD">Record type</param>
		/// <param name="m3ITRN">Interface round number</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3CSHC">Cash code</param>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3TRTM">Transaction time</param>
		/// <param name="m3CUAM">Foreign currency amount</param>
		/// <param name="m3PYCD">Payment method - accounts receivable</param>
		/// <param name="m3REFE">Reference</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3CRCT">Card type</param>
		/// <param name="m3CRCN">Credit card number</param>
		/// <param name="m3EPDA">Expiration date</param>
		/// <param name="m3DUDT">Due date</param>
		/// <param name="m3ARAT">Exchange rate</param>
		/// <param name="m3CRTP">Exchange rate type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSlsTicketPay(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3XRCD = null, 
			decimal? m3ITRN = null, 
			string m3WHLO = null, 
			string m3CSHC = null, 
			string m3ORNO = null, 
			decimal? m3DLIX = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
			string m3CUCD = null, 
			DateTime? m3TRDT = null, 
			int? m3TRTM = null, 
			decimal? m3CUAM = null, 
			string m3PYCD = null, 
			string m3REFE = null, 
			string m3RESP = null, 
			string m3CRCT = null, 
			string m3CRCN = null, 
			string m3EPDA = null, 
			DateTime? m3DUDT = null, 
			decimal? m3ARAT = null, 
			int? m3CRTP = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3XRCD))
				request.WithQueryParameter("XRCD", m3XRCD.Trim());
			if (m3ITRN.HasValue)
				request.WithQueryParameter("ITRN", m3ITRN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSHC))
				request.WithQueryParameter("CSHC", m3CSHC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (m3TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3TRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CUAM.HasValue)
				request.WithQueryParameter("CUAM", m3CUAM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PYCD))
				request.WithQueryParameter("PYCD", m3PYCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3REFE))
				request.WithQueryParameter("REFE", m3REFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CRCT))
				request.WithQueryParameter("CRCT", m3CRCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3CRCN))
				request.WithQueryParameter("CRCN", m3CRCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3EPDA))
				request.WithQueryParameter("EPDA", m3EPDA.Trim());
			if (m3DUDT.HasValue)
				request.WithQueryParameter("DUDT", m3DUDT.Value.ToM3String());
			if (m3ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3ARAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3CRTP.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name BchPrcRound
		/// Description Batch process round number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITRN">Interface round number (Required)</param>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3ACDT">Accounting date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3OPMM">Inventory accounting interface</param>
		/// <param name="m3OPSS">Sales statistics interface</param>
		/// <param name="m3OPGL">Financial interface</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> BchPrcRound(
			decimal m3ITRN, 
			string m3DIVI, 
			DateTime m3ACDT, 
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
			DateTime? m3TRDT = null, 
			int? m3OPMM = null, 
			int? m3OPSS = null, 
			int? m3OPGL = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITRN", m3ITRN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("ACDT", m3ACDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (m3OPMM.HasValue)
				request.WithQueryParameter("OPMM", m3OPMM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPSS.HasValue)
				request.WithQueryParameter("OPSS", m3OPSS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPGL.HasValue)
				request.WithQueryParameter("OPGL", m3OPGL.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelRoundNumber
		/// Description Delete interface round Number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITRN">Interface round number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DelRoundNumberResponse></returns>
		/// <exception cref="M3Exception<DelRoundNumberResponse>"></exception>
		public async Task<M3Response<DelRoundNumberResponse>> DelRoundNumber(
			decimal m3ITRN, 
			int? m3CONO = null, 
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
				.WithQueryParameter("ITRN", m3ITRN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<DelRoundNumberResponse>(
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
		/// Name GetRoundNumber
		/// Description Get info about interface round number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITRN">Interface round number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetRoundNumberResponse></returns>
		/// <exception cref="M3Exception<GetRoundNumberResponse>"></exception>
		public async Task<M3Response<GetRoundNumberResponse>> GetRoundNumber(
			decimal m3ITRN, 
			int? m3CONO = null, 
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
				.WithQueryParameter("ITRN", m3ITRN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetRoundNumberResponse>(
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
		/// Name SndSlsTicketLin
		/// Description Send sales ticket line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3XRCD">Record type</param>
		/// <param name="m3ITRN">Interface round number</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3CSHC">Cash code</param>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3TRTM">Transaction time</param>
		/// <param name="m3CUAM">Foreign currency amount</param>
		/// <param name="m3VTCD">VAT code</param>
		/// <param name="m3DUDT">Due date</param>
		/// <param name="m3PYCD">Payment method - accounts receivable</param>
		/// <param name="m3ALUN">Alternate U/M</param>
		/// <param name="m3IVQA">Invoiced quantity - alternate U/M</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3DIA1">Discount amount 1</param>
		/// <param name="m3IVNO">Invoice number</param>
		/// <param name="m3INYR">Invoice year</param>
		/// <param name="m3SERI">Serial number</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3SDEP">Sales department</param>
		/// <param name="m3DIA2">Discount amount 2</param>
		/// <param name="m3DIA3">Discount amount 3</param>
		/// <param name="m3DIA4">Discount amount 4</param>
		/// <param name="m3DIA5">Discount amount 5</param>
		/// <param name="m3DIA6">Discount amount 6</param>
		/// <param name="m3REFE">Reference</param>
		/// <param name="m3CMNO">Sales campaign</param>
		/// <param name="m3FVT1">Calculated VAT amount 1</param>
		/// <param name="m3FVT2">Calculated VAT amount 2</param>
		/// <param name="m3FVT3">Calculated VAT amount 3</param>
		/// <param name="m3FVT4">Calculated VAT amount 4</param>
		/// <param name="m3VTP1">VAT rate 1</param>
		/// <param name="m3VTP2">VAT rate 2</param>
		/// <param name="m3FRE1">Statistics identity 1 customer</param>
		/// <param name="m3FRE2">Statistics identity 2 customer</param>
		/// <param name="m3FRE3">Statistics identity 3 item</param>
		/// <param name="m3FRE4">Statistics identity 4 item</param>
		/// <param name="m3ARAT">Exchange rate</param>
		/// <param name="m3CRTP">Exchange rate type</param>
		/// <param name="m3INPX">Invoice Prefix</param>
		/// <param name="m3EXIN">Extended Invoice Number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWT">Alias category</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3MCHP">Price change indicator</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndSlsTicketLin(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3XRCD = null, 
			decimal? m3ITRN = null, 
			string m3WHLO = null, 
			string m3CSHC = null, 
			string m3ORNO = null, 
			decimal? m3DLIX = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
			string m3CUCD = null, 
			string m3CUNO = null, 
			string m3ITNO = null, 
			DateTime? m3TRDT = null, 
			int? m3TRTM = null, 
			decimal? m3CUAM = null, 
			int? m3VTCD = null, 
			DateTime? m3DUDT = null, 
			string m3PYCD = null, 
			string m3ALUN = null, 
			decimal? m3IVQA = null, 
			string m3RSCD = null, 
			decimal? m3DIA1 = null, 
			int? m3IVNO = null, 
			int? m3INYR = null, 
			string m3SERI = null, 
			string m3RESP = null, 
			string m3SDEP = null, 
			decimal? m3DIA2 = null, 
			decimal? m3DIA3 = null, 
			decimal? m3DIA4 = null, 
			decimal? m3DIA5 = null, 
			decimal? m3DIA6 = null, 
			string m3REFE = null, 
			string m3CMNO = null, 
			decimal? m3FVT1 = null, 
			decimal? m3FVT2 = null, 
			decimal? m3FVT3 = null, 
			decimal? m3FVT4 = null, 
			int? m3VTP1 = null, 
			int? m3VTP2 = null, 
			string m3FRE1 = null, 
			string m3FRE2 = null, 
			string m3FRE3 = null, 
			string m3FRE4 = null, 
			decimal? m3ARAT = null, 
			int? m3CRTP = null, 
			string m3INPX = null, 
			string m3EXIN = null, 
			string m3POPN = null, 
			int? m3ALWT = null, 
			string m3ALWQ = null, 
			string m3PYNO = null, 
			int? m3MCHP = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3XRCD))
				request.WithQueryParameter("XRCD", m3XRCD.Trim());
			if (m3ITRN.HasValue)
				request.WithQueryParameter("ITRN", m3ITRN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSHC))
				request.WithQueryParameter("CSHC", m3CSHC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (m3TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3TRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CUAM.HasValue)
				request.WithQueryParameter("CUAM", m3CUAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3VTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DUDT.HasValue)
				request.WithQueryParameter("DUDT", m3DUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PYCD))
				request.WithQueryParameter("PYCD", m3PYCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALUN))
				request.WithQueryParameter("ALUN", m3ALUN.Trim());
			if (m3IVQA.HasValue)
				request.WithQueryParameter("IVQA", m3IVQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (m3DIA1.HasValue)
				request.WithQueryParameter("DIA1", m3DIA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IVNO.HasValue)
				request.WithQueryParameter("IVNO", m3IVNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INYR.HasValue)
				request.WithQueryParameter("INYR", m3INYR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SERI))
				request.WithQueryParameter("SERI", m3SERI.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDEP))
				request.WithQueryParameter("SDEP", m3SDEP.Trim());
			if (m3DIA2.HasValue)
				request.WithQueryParameter("DIA2", m3DIA2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIA3.HasValue)
				request.WithQueryParameter("DIA3", m3DIA3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIA4.HasValue)
				request.WithQueryParameter("DIA4", m3DIA4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIA5.HasValue)
				request.WithQueryParameter("DIA5", m3DIA5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIA6.HasValue)
				request.WithQueryParameter("DIA6", m3DIA6.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REFE))
				request.WithQueryParameter("REFE", m3REFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3CMNO))
				request.WithQueryParameter("CMNO", m3CMNO.Trim());
			if (m3FVT1.HasValue)
				request.WithQueryParameter("FVT1", m3FVT1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FVT2.HasValue)
				request.WithQueryParameter("FVT2", m3FVT2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FVT3.HasValue)
				request.WithQueryParameter("FVT3", m3FVT3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FVT4.HasValue)
				request.WithQueryParameter("FVT4", m3FVT4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTP1.HasValue)
				request.WithQueryParameter("VTP1", m3VTP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTP2.HasValue)
				request.WithQueryParameter("VTP2", m3VTP2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRE1))
				request.WithQueryParameter("FRE1", m3FRE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRE2))
				request.WithQueryParameter("FRE2", m3FRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRE3))
				request.WithQueryParameter("FRE3", m3FRE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRE4))
				request.WithQueryParameter("FRE4", m3FRE4.Trim());
			if (m3ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3ARAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3CRTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INPX))
				request.WithQueryParameter("INPX", m3INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXIN))
				request.WithQueryParameter("EXIN", m3EXIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (m3MCHP.HasValue)
				request.WithQueryParameter("MCHP", m3MCHP.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name SndSlsTicketPay
		/// Description Send sales ticket payment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3XRCD">Record type</param>
		/// <param name="m3ITRN">Interface round number</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3CSHC">Cash code</param>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3TRTM">Transaction time</param>
		/// <param name="m3CUAM">Foreign currency amount</param>
		/// <param name="m3PYCD">Payment method - accounts receivable</param>
		/// <param name="m3REFE">Reference</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3CRCT">Card type</param>
		/// <param name="m3CRCN">Credit card number</param>
		/// <param name="m3EPDA">Expiration date</param>
		/// <param name="m3DUDT">Due date</param>
		/// <param name="m3ARAT">Exchange rate</param>
		/// <param name="m3CRTP">Exchange rate type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndSlsTicketPay(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3XRCD = null, 
			decimal? m3ITRN = null, 
			string m3WHLO = null, 
			string m3CSHC = null, 
			string m3ORNO = null, 
			decimal? m3DLIX = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
			string m3CUCD = null, 
			DateTime? m3TRDT = null, 
			int? m3TRTM = null, 
			decimal? m3CUAM = null, 
			string m3PYCD = null, 
			string m3REFE = null, 
			string m3RESP = null, 
			string m3CRCT = null, 
			string m3CRCN = null, 
			string m3EPDA = null, 
			DateTime? m3DUDT = null, 
			decimal? m3ARAT = null, 
			int? m3CRTP = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3XRCD))
				request.WithQueryParameter("XRCD", m3XRCD.Trim());
			if (m3ITRN.HasValue)
				request.WithQueryParameter("ITRN", m3ITRN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSHC))
				request.WithQueryParameter("CSHC", m3CSHC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (m3TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3TRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CUAM.HasValue)
				request.WithQueryParameter("CUAM", m3CUAM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PYCD))
				request.WithQueryParameter("PYCD", m3PYCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3REFE))
				request.WithQueryParameter("REFE", m3REFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CRCT))
				request.WithQueryParameter("CRCT", m3CRCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3CRCN))
				request.WithQueryParameter("CRCN", m3CRCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3EPDA))
				request.WithQueryParameter("EPDA", m3EPDA.Trim());
			if (m3DUDT.HasValue)
				request.WithQueryParameter("DUDT", m3DUDT.Value.ToM3String());
			if (m3ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3ARAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3CRTP.Value.ToString(CultureInfo.CurrentCulture));

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
