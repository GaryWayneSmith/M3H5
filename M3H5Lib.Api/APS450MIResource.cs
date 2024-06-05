/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.APS450MI;
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
	/// Name: APS450MI
	/// Component Name: SupplierInvoiceBatch
	/// Description: Supplier invoice batch interface
	/// Version Release: 5ea1
	///</summary>
	public partial class APS450MIResource : M3BaseResourceEndpoint
	{
		public APS450MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "APS450MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Acknowledge
		/// Description Acknowledges the supplier invoice batch
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_INBN">Invoice batch number (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_CRNO">Credit number</param>
		/// <param name="m3_YRE1">Your reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Acknowledge(
			long m3_INBN, 
			string m3_DIVI = null, 
			string m3_CRNO = null, 
			string m3_YRE1 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Acknowledge",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("INBN", m3_INBN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CRNO))
				request.WithQueryParameter("CRNO", m3_CRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YRE1))
				request.WithQueryParameter("YRE1", m3_YRE1.Trim());

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
		/// Name AddAddInfo
		/// Description Adds an invoice batch additional information ref
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_INBN">Invoice batch number (Required)</param>
		/// <param name="m3_PEXN">AP information category (Required)</param>
		/// <param name="m3_PEXI">AP additional information (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_PEXS">AP information sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAddInfo(
			long m3_INBN, 
			int m3_PEXN, 
			string m3_PEXI, 
			string m3_DIVI = null, 
			int? m3_PEXS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAddInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PEXI))
				throw new ArgumentNullException("m3_PEXI");

			// Set mandatory parameters
			request
				.WithQueryParameter("INBN", m3_INBN.ToString())
				.WithQueryParameter("PEXN", m3_PEXN.ToString())
				.WithQueryParameter("PEXI", m3_PEXI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_PEXS.HasValue)
				request.WithQueryParameter("PEXS", m3_PEXS.Value.ToString());

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
		/// Name AddHead
		/// Description Adds an invoice batch head
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_IVDT">Invoice date (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_IBTP">Invoice batch type</param>
		/// <param name="m3_SINO">Supplier invoice number</param>
		/// <param name="m3_SPYN">Payee</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_ARAT">Exchange rate</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_PYME">Payment method - accounts payable</param>
		/// <param name="m3_TDCD">Trade code</param>
		/// <param name="m3_CUAM">Foreign currency amount</param>
		/// <param name="m3_VTAM">VAT</param>
		/// <param name="m3_ACDT">Accounting date</param>
		/// <param name="m3_APCD">Authorized user</param>
		/// <param name="m3_IMCD">Invoice matching</param>
		/// <param name="m3_SERS">Service code</param>
		/// <param name="m3_DUDT">Due date</param>
		/// <param name="m3_FECN">Future rate agreement number</param>
		/// <param name="m3_CRTP">Exchange rate type</param>
		/// <param name="m3_FTCO">From/to country</param>
		/// <param name="m3_BSCD">Base country</param>
		/// <param name="m3_PUNO">Purchase order number</param>
		/// <param name="m3_PUDT">Order date</param>
		/// <param name="m3_TECD">Cash discount term</param>
		/// <param name="m3_CDT1">Cash discount date 1</param>
		/// <param name="m3_CDP1">Cash discount percentage</param>
		/// <param name="m3_CDC1">Cash discount amount 1</param>
		/// <param name="m3_CDT2">Cash discount date 2</param>
		/// <param name="m3_CDP2">Cash discount percentage</param>
		/// <param name="m3_CDC2">Cash discount amount 2</param>
		/// <param name="m3_CDT3">Cash discount date 3</param>
		/// <param name="m3_CDP3">Cash discount percentage</param>
		/// <param name="m3_CDC3">Cash discount amount 3</param>
		/// <param name="m3_TTXA">Total taxable amount</param>
		/// <param name="m3_TASD">Cash discount base</param>
		/// <param name="m3_PRPA">Prepaid amount</param>
		/// <param name="m3_VRNO">VAT registration number</param>
		/// <param name="m3_TXAP">Tax applicable</param>
		/// <param name="m3_DNCO">Document code</param>
		/// <param name="m3_SDAP">AP standard document</param>
		/// <param name="m3_DNRE">Debit note reason</param>
		/// <param name="m3_PYAD">Our invoicing address</param>
		/// <param name="m3_SDA1">Text line 1</param>
		/// <param name="m3_SDA2">Text line 2</param>
		/// <param name="m3_SDA3">Text line 3</param>
		/// <param name="m3_EALP">EAN location code payee</param>
		/// <param name="m3_EALR">EAN location code consignee</param>
		/// <param name="m3_EALS">EAN location code supplier</param>
		/// <param name="m3_DEDA">Delivery date</param>
		/// <param name="m3_GPDF">Get payee defaults</param>
		/// <param name="m3_BKID">Bank account identity</param>
		/// <param name="m3_GEOC">Geographical code</param>
		/// <param name="m3_TXIN">Tax included</param>
		/// <param name="m3_DNOI">Original invoice number</param>
		/// <param name="m3_OYEA">Original year</param>
		/// <param name="m3_PPYR">Reference number</param>
		/// <param name="m3_PPYN">Payment request  number</param>
		/// <param name="m3_YEA4">Year</param>
		/// <param name="m3_PVLD">Partial validation</param>
		/// <param name="m3_VONO">Voucher number</param>
		/// <param name="m3_CORI">Correlation ID</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddHeadResponse></returns>
		/// <exception cref="M3Exception<AddHeadResponse>"></exception>
		public async Task<M3Response<AddHeadResponse>> AddHead(
			string m3_SUNO, 
			DateTime m3_IVDT, 
			string m3_DIVI = null, 
			string m3_IBTP = null, 
			string m3_SINO = null, 
			string m3_SPYN = null, 
			string m3_CUCD = null, 
			decimal? m3_ARAT = null, 
			string m3_TEPY = null, 
			string m3_PYME = null, 
			string m3_TDCD = null, 
			decimal? m3_CUAM = null, 
			decimal? m3_VTAM = null, 
			DateTime? m3_ACDT = null, 
			string m3_APCD = null, 
			string m3_IMCD = null, 
			int? m3_SERS = null, 
			DateTime? m3_DUDT = null, 
			string m3_FECN = null, 
			int? m3_CRTP = null, 
			string m3_FTCO = null, 
			string m3_BSCD = null, 
			string m3_PUNO = null, 
			DateTime? m3_PUDT = null, 
			string m3_TECD = null, 
			DateTime? m3_CDT1 = null, 
			int? m3_CDP1 = null, 
			decimal? m3_CDC1 = null, 
			DateTime? m3_CDT2 = null, 
			int? m3_CDP2 = null, 
			decimal? m3_CDC2 = null, 
			DateTime? m3_CDT3 = null, 
			int? m3_CDP3 = null, 
			decimal? m3_CDC3 = null, 
			decimal? m3_TTXA = null, 
			decimal? m3_TASD = null, 
			decimal? m3_PRPA = null, 
			string m3_VRNO = null, 
			int? m3_TXAP = null, 
			string m3_DNCO = null, 
			string m3_SDAP = null, 
			string m3_DNRE = null, 
			string m3_PYAD = null, 
			string m3_SDA1 = null, 
			string m3_SDA2 = null, 
			string m3_SDA3 = null, 
			string m3_EALP = null, 
			string m3_EALR = null, 
			string m3_EALS = null, 
			DateTime? m3_DEDA = null, 
			int? m3_GPDF = null, 
			string m3_BKID = null, 
			int? m3_GEOC = null, 
			int? m3_TXIN = null, 
			string m3_DNOI = null, 
			int? m3_OYEA = null, 
			string m3_PPYR = null, 
			string m3_PPYN = null, 
			int? m3_YEA4 = null, 
			int? m3_PVLD = null, 
			int? m3_VONO = null, 
			string m3_CORI = null, 
			string m3_ECAR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("IVDT", m3_IVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IBTP))
				request.WithQueryParameter("IBTP", m3_IBTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SINO))
				request.WithQueryParameter("SINO", m3_SINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPYN))
				request.WithQueryParameter("SPYN", m3_SPYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3_ARAT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYME))
				request.WithQueryParameter("PYME", m3_PYME.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TDCD))
				request.WithQueryParameter("TDCD", m3_TDCD.Trim());
			if (m3_CUAM.HasValue)
				request.WithQueryParameter("CUAM", m3_CUAM.Value.ToString());
			if (m3_VTAM.HasValue)
				request.WithQueryParameter("VTAM", m3_VTAM.Value.ToString());
			if (m3_ACDT.HasValue)
				request.WithQueryParameter("ACDT", m3_ACDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_APCD))
				request.WithQueryParameter("APCD", m3_APCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IMCD))
				request.WithQueryParameter("IMCD", m3_IMCD.Trim());
			if (m3_SERS.HasValue)
				request.WithQueryParameter("SERS", m3_SERS.Value.ToString());
			if (m3_DUDT.HasValue)
				request.WithQueryParameter("DUDT", m3_DUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_FECN))
				request.WithQueryParameter("FECN", m3_FECN.Trim());
			if (m3_CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3_CRTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FTCO))
				request.WithQueryParameter("FTCO", m3_FTCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BSCD))
				request.WithQueryParameter("BSCD", m3_BSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PUNO))
				request.WithQueryParameter("PUNO", m3_PUNO.Trim());
			if (m3_PUDT.HasValue)
				request.WithQueryParameter("PUDT", m3_PUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TECD))
				request.WithQueryParameter("TECD", m3_TECD.Trim());
			if (m3_CDT1.HasValue)
				request.WithQueryParameter("CDT1", m3_CDT1.Value.ToM3String());
			if (m3_CDP1.HasValue)
				request.WithQueryParameter("CDP1", m3_CDP1.Value.ToString());
			if (m3_CDC1.HasValue)
				request.WithQueryParameter("CDC1", m3_CDC1.Value.ToString());
			if (m3_CDT2.HasValue)
				request.WithQueryParameter("CDT2", m3_CDT2.Value.ToM3String());
			if (m3_CDP2.HasValue)
				request.WithQueryParameter("CDP2", m3_CDP2.Value.ToString());
			if (m3_CDC2.HasValue)
				request.WithQueryParameter("CDC2", m3_CDC2.Value.ToString());
			if (m3_CDT3.HasValue)
				request.WithQueryParameter("CDT3", m3_CDT3.Value.ToM3String());
			if (m3_CDP3.HasValue)
				request.WithQueryParameter("CDP3", m3_CDP3.Value.ToString());
			if (m3_CDC3.HasValue)
				request.WithQueryParameter("CDC3", m3_CDC3.Value.ToString());
			if (m3_TTXA.HasValue)
				request.WithQueryParameter("TTXA", m3_TTXA.Value.ToString());
			if (m3_TASD.HasValue)
				request.WithQueryParameter("TASD", m3_TASD.Value.ToString());
			if (m3_PRPA.HasValue)
				request.WithQueryParameter("PRPA", m3_PRPA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_VRNO))
				request.WithQueryParameter("VRNO", m3_VRNO.Trim());
			if (m3_TXAP.HasValue)
				request.WithQueryParameter("TXAP", m3_TXAP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DNCO))
				request.WithQueryParameter("DNCO", m3_DNCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDAP))
				request.WithQueryParameter("SDAP", m3_SDAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DNRE))
				request.WithQueryParameter("DNRE", m3_DNRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYAD))
				request.WithQueryParameter("PYAD", m3_PYAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDA1))
				request.WithQueryParameter("SDA1", m3_SDA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDA2))
				request.WithQueryParameter("SDA2", m3_SDA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDA3))
				request.WithQueryParameter("SDA3", m3_SDA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EALP))
				request.WithQueryParameter("EALP", m3_EALP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EALR))
				request.WithQueryParameter("EALR", m3_EALR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EALS))
				request.WithQueryParameter("EALS", m3_EALS.Trim());
			if (m3_DEDA.HasValue)
				request.WithQueryParameter("DEDA", m3_DEDA.Value.ToM3String());
			if (m3_GPDF.HasValue)
				request.WithQueryParameter("GPDF", m3_GPDF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BKID))
				request.WithQueryParameter("BKID", m3_BKID.Trim());
			if (m3_GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3_GEOC.Value.ToString());
			if (m3_TXIN.HasValue)
				request.WithQueryParameter("TXIN", m3_TXIN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DNOI))
				request.WithQueryParameter("DNOI", m3_DNOI.Trim());
			if (m3_OYEA.HasValue)
				request.WithQueryParameter("OYEA", m3_OYEA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PPYR))
				request.WithQueryParameter("PPYR", m3_PPYR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PPYN))
				request.WithQueryParameter("PPYN", m3_PPYN.Trim());
			if (m3_YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3_YEA4.Value.ToString());
			if (m3_PVLD.HasValue)
				request.WithQueryParameter("PVLD", m3_PVLD.Value.ToString());
			if (m3_VONO.HasValue)
				request.WithQueryParameter("VONO", m3_VONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CORI))
				request.WithQueryParameter("CORI", m3_CORI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());

			// Execute the request
			var result = await Execute<AddHeadResponse>(
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
		/// Name AddLine
		/// Description Adds an invoice batch line
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_INBN">Invoice batch number (Required)</param>
		/// <param name="m3_RDTP">Line type (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_SERS">Service code</param>
		/// <param name="m3_NLAM">Net amount - line</param>
		/// <param name="m3_VTA1">VAT amount 1</param>
		/// <param name="m3_VTA2">VAT amount 2</param>
		/// <param name="m3_VTCD">VAT code</param>
		/// <param name="m3_PUNO">Purchase order number</param>
		/// <param name="m3_PNLI">Purchase order line</param>
		/// <param name="m3_PNLS">Purchase order line subnumber</param>
		/// <param name="m3_IVQA">Invoiced quantity - alternate U/M</param>
		/// <param name="m3_PUUN">Purchase order U/M</param>
		/// <param name="m3_GRPR">Gross price</param>
		/// <param name="m3_PPUN">Purchase price U/M</param>
		/// <param name="m3_NEPR">Net price</param>
		/// <param name="m3_PUCD">Purchase price quantity</param>
		/// <param name="m3_GLAM">Gross amount - line</param>
		/// <param name="m3_DIPC">Discount</param>
		/// <param name="m3_DIAM">Discount amount</param>
		/// <param name="m3_IVCW">Invoiced catch weight</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_SBAN">Self-billing agreement number</param>
		/// <param name="m3_CDSE">Sequence number - costing element</param>
		/// <param name="m3_CEID">Costing element</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_RELP">Receipt type</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_DNDT">Delivery note date</param>
		/// <param name="m3_CLAN">Claim number</param>
		/// <param name="m3_CLLN">Claim order line</param>
		/// <param name="m3_TRNO">Transaction number</param>
		/// <param name="m3_VTP1">VAT rate 1</param>
		/// <param name="m3_VTP2">VAT rate 2</param>
		/// <param name="m3_CHGT">Charge text</param>
		/// <param name="m3_PVLD">Partial validation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddLineResponse></returns>
		/// <exception cref="M3Exception<AddLineResponse>"></exception>
		public async Task<M3Response<AddLineResponse>> AddLine(
			long m3_INBN, 
			int m3_RDTP, 
			string m3_DIVI = null, 
			int? m3_SERS = null, 
			decimal? m3_NLAM = null, 
			decimal? m3_VTA1 = null, 
			decimal? m3_VTA2 = null, 
			int? m3_VTCD = null, 
			string m3_PUNO = null, 
			int? m3_PNLI = null, 
			int? m3_PNLS = null, 
			decimal? m3_IVQA = null, 
			string m3_PUUN = null, 
			decimal? m3_GRPR = null, 
			string m3_PPUN = null, 
			decimal? m3_NEPR = null, 
			int? m3_PUCD = null, 
			decimal? m3_GLAM = null, 
			int? m3_DIPC = null, 
			decimal? m3_DIAM = null, 
			decimal? m3_IVCW = null, 
			string m3_ITNO = null, 
			string m3_POPN = null, 
			string m3_SBAN = null, 
			int? m3_CDSE = null, 
			string m3_CEID = null, 
			long? m3_REPN = null, 
			int? m3_RELP = null, 
			string m3_SUDO = null, 
			DateTime? m3_DNDT = null, 
			string m3_CLAN = null, 
			int? m3_CLLN = null, 
			int? m3_TRNO = null, 
			int? m3_VTP1 = null, 
			int? m3_VTP2 = null, 
			string m3_CHGT = null, 
			int? m3_PVLD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLine",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("INBN", m3_INBN.ToString())
				.WithQueryParameter("RDTP", m3_RDTP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_SERS.HasValue)
				request.WithQueryParameter("SERS", m3_SERS.Value.ToString());
			if (m3_NLAM.HasValue)
				request.WithQueryParameter("NLAM", m3_NLAM.Value.ToString());
			if (m3_VTA1.HasValue)
				request.WithQueryParameter("VTA1", m3_VTA1.Value.ToString());
			if (m3_VTA2.HasValue)
				request.WithQueryParameter("VTA2", m3_VTA2.Value.ToString());
			if (m3_VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3_VTCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PUNO))
				request.WithQueryParameter("PUNO", m3_PUNO.Trim());
			if (m3_PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3_PNLI.Value.ToString());
			if (m3_PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3_PNLS.Value.ToString());
			if (m3_IVQA.HasValue)
				request.WithQueryParameter("IVQA", m3_IVQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PUUN))
				request.WithQueryParameter("PUUN", m3_PUUN.Trim());
			if (m3_GRPR.HasValue)
				request.WithQueryParameter("GRPR", m3_GRPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PPUN))
				request.WithQueryParameter("PPUN", m3_PPUN.Trim());
			if (m3_NEPR.HasValue)
				request.WithQueryParameter("NEPR", m3_NEPR.Value.ToString());
			if (m3_PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3_PUCD.Value.ToString());
			if (m3_GLAM.HasValue)
				request.WithQueryParameter("GLAM", m3_GLAM.Value.ToString());
			if (m3_DIPC.HasValue)
				request.WithQueryParameter("DIPC", m3_DIPC.Value.ToString());
			if (m3_DIAM.HasValue)
				request.WithQueryParameter("DIAM", m3_DIAM.Value.ToString());
			if (m3_IVCW.HasValue)
				request.WithQueryParameter("IVCW", m3_IVCW.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SBAN))
				request.WithQueryParameter("SBAN", m3_SBAN.Trim());
			if (m3_CDSE.HasValue)
				request.WithQueryParameter("CDSE", m3_CDSE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CEID))
				request.WithQueryParameter("CEID", m3_CEID.Trim());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (m3_RELP.HasValue)
				request.WithQueryParameter("RELP", m3_RELP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (m3_DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3_DNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CLAN))
				request.WithQueryParameter("CLAN", m3_CLAN.Trim());
			if (m3_CLLN.HasValue)
				request.WithQueryParameter("CLLN", m3_CLLN.Value.ToString());
			if (m3_TRNO.HasValue)
				request.WithQueryParameter("TRNO", m3_TRNO.Value.ToString());
			if (m3_VTP1.HasValue)
				request.WithQueryParameter("VTP1", m3_VTP1.Value.ToString());
			if (m3_VTP2.HasValue)
				request.WithQueryParameter("VTP2", m3_VTP2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHGT))
				request.WithQueryParameter("CHGT", m3_CHGT.Trim());
			if (m3_PVLD.HasValue)
				request.WithQueryParameter("PVLD", m3_PVLD.Value.ToString());

			// Execute the request
			var result = await Execute<AddLineResponse>(
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
		/// Name AdjustLine
		/// Description Adjust amount on invoice line
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_INBN">Invoice batch number (Required)</param>
		/// <param name="m3_TRNO">Transaction number (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_ADAB">Adjusted amount</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AdjustLine(
			long m3_INBN, 
			int m3_TRNO, 
			string m3_DIVI = null, 
			decimal? m3_ADAB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AdjustLine",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("INBN", m3_INBN.ToString())
				.WithQueryParameter("TRNO", m3_TRNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_ADAB.HasValue)
				request.WithQueryParameter("ADAB", m3_ADAB.Value.ToString());

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
		/// Name ApproveInvoice
		/// Description Approves the supplier invoice batch
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_INBN">Invoice batch number (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_AAPD">Approval date</param>
		/// <param name="m3_CRNO">Credit number</param>
		/// <param name="m3_YRE1">Your reference</param>
		/// <param name="m3_SINO">Supplier invoice number</param>
		/// <param name="m3_IVDT">Invoice date</param>
		/// <param name="m3_DUDT">Due date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ApproveInvoice(
			long m3_INBN, 
			string m3_DIVI = null, 
			DateTime? m3_AAPD = null, 
			string m3_CRNO = null, 
			string m3_YRE1 = null, 
			string m3_SINO = null, 
			DateTime? m3_IVDT = null, 
			DateTime? m3_DUDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ApproveInvoice",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("INBN", m3_INBN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_AAPD.HasValue)
				request.WithQueryParameter("AAPD", m3_AAPD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CRNO))
				request.WithQueryParameter("CRNO", m3_CRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YRE1))
				request.WithQueryParameter("YRE1", m3_YRE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SINO))
				request.WithQueryParameter("SINO", m3_SINO.Trim());
			if (m3_IVDT.HasValue)
				request.WithQueryParameter("IVDT", m3_IVDT.Value.ToM3String());
			if (m3_DUDT.HasValue)
				request.WithQueryParameter("DUDT", m3_DUDT.Value.ToM3String());

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
		/// Name GetHead
		/// Description Gets data from supplier invoice batch head
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_INBN">Invoice batch number (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadResponse></returns>
		/// <exception cref="M3Exception<GetHeadResponse>"></exception>
		public async Task<M3Response<GetHeadResponse>> GetHead(
			long m3_INBN, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHead",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("INBN", m3_INBN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<GetHeadResponse>(
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
		/// Name LstClaimDetails
		/// Description Lists claim invoice details
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_INBN">Invoice batch number (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_YEA4">Year</param>
		/// <param name="m3_EXIN">Extended Invoice Number</param>
		/// <param name="m3_RIDI">Delivery number</param>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_ALI1">Transaction number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstClaimDetailsResponse></returns>
		/// <exception cref="M3Exception<LstClaimDetailsResponse>"></exception>
		public async Task<M3Response<LstClaimDetailsResponse>> LstClaimDetails(
			long m3_INBN, 
			string m3_DIVI = null, 
			int? m3_YEA4 = null, 
			string m3_EXIN = null, 
			decimal? m3_RIDI = null, 
			string m3_ORCA = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
			int? m3_ALI1 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstClaimDetails",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("INBN", m3_INBN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3_YEA4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EXIN))
				request.WithQueryParameter("EXIN", m3_EXIN.Trim());
			if (m3_RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3_RIDI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (m3_ALI1.HasValue)
				request.WithQueryParameter("ALI1", m3_ALI1.Value.ToString());

			// Execute the request
			var result = await Execute<LstClaimDetailsResponse>(
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
		/// Name LstInvBatchNo
		/// Description Lists invoice batch numbers by payee
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_SPYN">Payee (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_IBTP">Invoice batch type</param>
		/// <param name="m3_SUPA">Invoice status</param>
		/// <param name="m3_INBN">Invoice batch number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvBatchNoResponse></returns>
		/// <exception cref="M3Exception<LstInvBatchNoResponse>"></exception>
		public async Task<M3Response<LstInvBatchNoResponse>> LstInvBatchNo(
			string m3_SPYN, 
			string m3_DIVI = null, 
			string m3_SUNO = null, 
			string m3_IBTP = null, 
			int? m3_SUPA = null, 
			long? m3_INBN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInvBatchNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SPYN))
				throw new ArgumentNullException("m3_SPYN");

			// Set mandatory parameters
			request
				.WithQueryParameter("SPYN", m3_SPYN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IBTP))
				request.WithQueryParameter("IBTP", m3_IBTP.Trim());
			if (m3_SUPA.HasValue)
				request.WithQueryParameter("SUPA", m3_SUPA.Value.ToString());
			if (m3_INBN.HasValue)
				request.WithQueryParameter("INBN", m3_INBN.Value.ToString());

			// Execute the request
			var result = await Execute<LstInvBatchNoResponse>(
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
		/// Name LstInvBySupInv
		/// Description Lists invoice batch numbers by supplier invoice number
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_SPYN">Payee (Required)</param>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_SINO">Supplier invoice number (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvBySupInvResponse></returns>
		/// <exception cref="M3Exception<LstInvBySupInvResponse>"></exception>
		public async Task<M3Response<LstInvBySupInvResponse>> LstInvBySupInv(
			string m3_SPYN, 
			string m3_SUNO, 
			string m3_SINO, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInvBySupInv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SPYN))
				throw new ArgumentNullException("m3_SPYN");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SINO))
				throw new ArgumentNullException("m3_SINO");

			// Set mandatory parameters
			request
				.WithQueryParameter("SPYN", m3_SPYN.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SINO", m3_SINO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstInvBySupInvResponse>(
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
		/// Name LstLines
		/// Description Lists supplier invoice batch line data
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_INBN">Invoice batch number (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_TRNO">Transaction number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLinesResponse></returns>
		/// <exception cref="M3Exception<LstLinesResponse>"></exception>
		public async Task<M3Response<LstLinesResponse>> LstLines(
			long m3_INBN, 
			string m3_DIVI = null, 
			int? m3_TRNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLines",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("INBN", m3_INBN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_TRNO.HasValue)
				request.WithQueryParameter("TRNO", m3_TRNO.Value.ToString());

			// Execute the request
			var result = await Execute<LstLinesResponse>(
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
		/// Name PrintInvoice
		/// Description Submits print of the invoice
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_INBN">Invoice batch number (Required)</param>
		/// <param name="m3_LITP">Report layout (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrintInvoice(
			long m3_INBN, 
			int m3_LITP, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrintInvoice",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("INBN", m3_INBN.ToString())
				.WithQueryParameter("LITP", m3_LITP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

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
		/// Name RejectInvoice
		/// Description Rejects the supplier invoice batch
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_INBN">Invoice batch number (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_REJD">Rejection date</param>
		/// <param name="m3_SCRE">Rejection reason</param>
		/// <param name="m3_RPAA">Reprint after adjustment</param>
		/// <param name="m3_SDA1">Text line 1</param>
		/// <param name="m3_SDA2">Text line 2</param>
		/// <param name="m3_SDA3">Text line 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<RejectInvoiceResponse></returns>
		/// <exception cref="M3Exception<RejectInvoiceResponse>"></exception>
		public async Task<M3Response<RejectInvoiceResponse>> RejectInvoice(
			long m3_INBN, 
			string m3_DIVI = null, 
			DateTime? m3_REJD = null, 
			string m3_SCRE = null, 
			int? m3_RPAA = null, 
			string m3_SDA1 = null, 
			string m3_SDA2 = null, 
			string m3_SDA3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RejectInvoice",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("INBN", m3_INBN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_REJD.HasValue)
				request.WithQueryParameter("REJD", m3_REJD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_SCRE))
				request.WithQueryParameter("SCRE", m3_SCRE.Trim());
			if (m3_RPAA.HasValue)
				request.WithQueryParameter("RPAA", m3_RPAA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SDA1))
				request.WithQueryParameter("SDA1", m3_SDA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDA2))
				request.WithQueryParameter("SDA2", m3_SDA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDA3))
				request.WithQueryParameter("SDA3", m3_SDA3.Trim());

			// Execute the request
			var result = await Execute<RejectInvoiceResponse>(
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
		/// Name UpdClaimDetails
		/// Description Update claim invoice details
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_INBN">Invoice batch number (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_EXIN">Extended invoice number (Required)</param>
		/// <param name="m3_RIDI">Delivery number (Required)</param>
		/// <param name="m3_ORCA">Order category (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line (Required)</param>
		/// <param name="m3_RIDX">Line suffix (Required)</param>
		/// <param name="m3_ALI1">Transaction number</param>
		/// <param name="m3_PARA">Paid rebate amount</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimDetails(
			string m3_DIVI, 
			long m3_INBN, 
			int m3_YEA4, 
			string m3_EXIN, 
			decimal m3_RIDI, 
			string m3_ORCA, 
			string m3_RIDN, 
			int m3_RIDL, 
			int m3_RIDX, 
			int? m3_ALI1 = null, 
			decimal? m3_PARA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdClaimDetails",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_EXIN))
				throw new ArgumentNullException("m3_EXIN");
			if (string.IsNullOrWhiteSpace(m3_ORCA))
				throw new ArgumentNullException("m3_ORCA");
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("INBN", m3_INBN.ToString())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("EXIN", m3_EXIN.Trim())
				.WithQueryParameter("RIDI", m3_RIDI.ToString())
				.WithQueryParameter("ORCA", m3_ORCA.Trim())
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("RIDL", m3_RIDL.ToString())
				.WithQueryParameter("RIDX", m3_RIDX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_ALI1.HasValue)
				request.WithQueryParameter("ALI1", m3_ALI1.Value.ToString());
			if (m3_PARA.HasValue)
				request.WithQueryParameter("PARA", m3_PARA.Value.ToString());

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
		/// Name UpdHead
		/// Description Updatess an invoice batch head
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_INBN">Invoice batch number (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_SINO">Supplier invoice number</param>
		/// <param name="m3_SPYN">Payee</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_IVDT">Invoice date</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_ARAT">Exchange rate</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_PYME">Payment method - accounts payable</param>
		/// <param name="m3_TDCD">Trade code</param>
		/// <param name="m3_CUAM">Foreign currency amount</param>
		/// <param name="m3_VTAM">VAT</param>
		/// <param name="m3_ACDT">Accounting date</param>
		/// <param name="m3_APCD">Authorized user</param>
		/// <param name="m3_IMCD">Invoice matching</param>
		/// <param name="m3_SERS">Service code</param>
		/// <param name="m3_DUDT">Due date</param>
		/// <param name="m3_FECN">Future rate agreement number</param>
		/// <param name="m3_CRTP">Exchange rate type</param>
		/// <param name="m3_FTCO">From/to country</param>
		/// <param name="m3_BSCD">Base country</param>
		/// <param name="m3_PUNO">Purchase order number</param>
		/// <param name="m3_PUDT">Order date</param>
		/// <param name="m3_TECD">Cash discount term</param>
		/// <param name="m3_CDT1">Cash discount date 1</param>
		/// <param name="m3_CDP1">Cash discount percentage</param>
		/// <param name="m3_CDC1">Cash discount amount 1</param>
		/// <param name="m3_CDT2">Cash discount date 2</param>
		/// <param name="m3_CDP2">Cash discount percentage</param>
		/// <param name="m3_CDC2">Cash discount amount 2</param>
		/// <param name="m3_CDT3">Cash discount date 3</param>
		/// <param name="m3_CDP3">Cash discount percentage</param>
		/// <param name="m3_CDC3">Cash discount amount 3</param>
		/// <param name="m3_TTXA">Total taxable amount</param>
		/// <param name="m3_TASD">Cash discount base</param>
		/// <param name="m3_PRPA">Prepaid amount</param>
		/// <param name="m3_VRNO">VAT registration number</param>
		/// <param name="m3_TXAP">Tax applicable</param>
		/// <param name="m3_DNCO">Document code</param>
		/// <param name="m3_SDAP">AP standard document</param>
		/// <param name="m3_DNRE">Debit note reason</param>
		/// <param name="m3_PYAD">Our invoicing address</param>
		/// <param name="m3_SDA1">Text line 1</param>
		/// <param name="m3_SDA2">Text line 2</param>
		/// <param name="m3_SDA3">Text line 3</param>
		/// <param name="m3_EALP">EAN location code payee</param>
		/// <param name="m3_EALR">EAN location code consignee</param>
		/// <param name="m3_EALS">EAN location code supplier</param>
		/// <param name="m3_DEDA">Delivery date</param>
		/// <param name="m3_GPDF">Get payee defaults</param>
		/// <param name="m3_BKID">Bank account identity</param>
		/// <param name="m3_GEOC">Geographical code</param>
		/// <param name="m3_TXIN">Tax included</param>
		/// <param name="m3_DNOI">Original invoice number</param>
		/// <param name="m3_OYEA">Original year</param>
		/// <param name="m3_PPYR">Reference number</param>
		/// <param name="m3_PPYN">Payment request  number</param>
		/// <param name="m3_YEA4">Year</param>
		/// <param name="m3_PVLD">Partial validation</param>
		/// <param name="m3_VONO">Voucher number</param>
		/// <param name="m3_CORI">Correlation ID</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdHead(
			long m3_INBN, 
			string m3_DIVI = null, 
			string m3_SINO = null, 
			string m3_SPYN = null, 
			string m3_SUNO = null, 
			DateTime? m3_IVDT = null, 
			string m3_CUCD = null, 
			decimal? m3_ARAT = null, 
			string m3_TEPY = null, 
			string m3_PYME = null, 
			string m3_TDCD = null, 
			decimal? m3_CUAM = null, 
			decimal? m3_VTAM = null, 
			DateTime? m3_ACDT = null, 
			string m3_APCD = null, 
			string m3_IMCD = null, 
			int? m3_SERS = null, 
			DateTime? m3_DUDT = null, 
			string m3_FECN = null, 
			int? m3_CRTP = null, 
			string m3_FTCO = null, 
			string m3_BSCD = null, 
			string m3_PUNO = null, 
			DateTime? m3_PUDT = null, 
			string m3_TECD = null, 
			DateTime? m3_CDT1 = null, 
			int? m3_CDP1 = null, 
			decimal? m3_CDC1 = null, 
			DateTime? m3_CDT2 = null, 
			int? m3_CDP2 = null, 
			decimal? m3_CDC2 = null, 
			DateTime? m3_CDT3 = null, 
			int? m3_CDP3 = null, 
			decimal? m3_CDC3 = null, 
			decimal? m3_TTXA = null, 
			decimal? m3_TASD = null, 
			decimal? m3_PRPA = null, 
			string m3_VRNO = null, 
			int? m3_TXAP = null, 
			string m3_DNCO = null, 
			string m3_SDAP = null, 
			string m3_DNRE = null, 
			string m3_PYAD = null, 
			string m3_SDA1 = null, 
			string m3_SDA2 = null, 
			string m3_SDA3 = null, 
			string m3_EALP = null, 
			string m3_EALR = null, 
			string m3_EALS = null, 
			DateTime? m3_DEDA = null, 
			int? m3_GPDF = null, 
			string m3_BKID = null, 
			int? m3_GEOC = null, 
			int? m3_TXIN = null, 
			string m3_DNOI = null, 
			int? m3_OYEA = null, 
			string m3_PPYR = null, 
			string m3_PPYN = null, 
			int? m3_YEA4 = null, 
			int? m3_PVLD = null, 
			int? m3_VONO = null, 
			string m3_CORI = null, 
			string m3_ECAR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdHead",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("INBN", m3_INBN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SINO))
				request.WithQueryParameter("SINO", m3_SINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPYN))
				request.WithQueryParameter("SPYN", m3_SPYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_IVDT.HasValue)
				request.WithQueryParameter("IVDT", m3_IVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3_ARAT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYME))
				request.WithQueryParameter("PYME", m3_PYME.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TDCD))
				request.WithQueryParameter("TDCD", m3_TDCD.Trim());
			if (m3_CUAM.HasValue)
				request.WithQueryParameter("CUAM", m3_CUAM.Value.ToString());
			if (m3_VTAM.HasValue)
				request.WithQueryParameter("VTAM", m3_VTAM.Value.ToString());
			if (m3_ACDT.HasValue)
				request.WithQueryParameter("ACDT", m3_ACDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_APCD))
				request.WithQueryParameter("APCD", m3_APCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IMCD))
				request.WithQueryParameter("IMCD", m3_IMCD.Trim());
			if (m3_SERS.HasValue)
				request.WithQueryParameter("SERS", m3_SERS.Value.ToString());
			if (m3_DUDT.HasValue)
				request.WithQueryParameter("DUDT", m3_DUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_FECN))
				request.WithQueryParameter("FECN", m3_FECN.Trim());
			if (m3_CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3_CRTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FTCO))
				request.WithQueryParameter("FTCO", m3_FTCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BSCD))
				request.WithQueryParameter("BSCD", m3_BSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PUNO))
				request.WithQueryParameter("PUNO", m3_PUNO.Trim());
			if (m3_PUDT.HasValue)
				request.WithQueryParameter("PUDT", m3_PUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TECD))
				request.WithQueryParameter("TECD", m3_TECD.Trim());
			if (m3_CDT1.HasValue)
				request.WithQueryParameter("CDT1", m3_CDT1.Value.ToM3String());
			if (m3_CDP1.HasValue)
				request.WithQueryParameter("CDP1", m3_CDP1.Value.ToString());
			if (m3_CDC1.HasValue)
				request.WithQueryParameter("CDC1", m3_CDC1.Value.ToString());
			if (m3_CDT2.HasValue)
				request.WithQueryParameter("CDT2", m3_CDT2.Value.ToM3String());
			if (m3_CDP2.HasValue)
				request.WithQueryParameter("CDP2", m3_CDP2.Value.ToString());
			if (m3_CDC2.HasValue)
				request.WithQueryParameter("CDC2", m3_CDC2.Value.ToString());
			if (m3_CDT3.HasValue)
				request.WithQueryParameter("CDT3", m3_CDT3.Value.ToM3String());
			if (m3_CDP3.HasValue)
				request.WithQueryParameter("CDP3", m3_CDP3.Value.ToString());
			if (m3_CDC3.HasValue)
				request.WithQueryParameter("CDC3", m3_CDC3.Value.ToString());
			if (m3_TTXA.HasValue)
				request.WithQueryParameter("TTXA", m3_TTXA.Value.ToString());
			if (m3_TASD.HasValue)
				request.WithQueryParameter("TASD", m3_TASD.Value.ToString());
			if (m3_PRPA.HasValue)
				request.WithQueryParameter("PRPA", m3_PRPA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_VRNO))
				request.WithQueryParameter("VRNO", m3_VRNO.Trim());
			if (m3_TXAP.HasValue)
				request.WithQueryParameter("TXAP", m3_TXAP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DNCO))
				request.WithQueryParameter("DNCO", m3_DNCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDAP))
				request.WithQueryParameter("SDAP", m3_SDAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DNRE))
				request.WithQueryParameter("DNRE", m3_DNRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYAD))
				request.WithQueryParameter("PYAD", m3_PYAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDA1))
				request.WithQueryParameter("SDA1", m3_SDA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDA2))
				request.WithQueryParameter("SDA2", m3_SDA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDA3))
				request.WithQueryParameter("SDA3", m3_SDA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EALP))
				request.WithQueryParameter("EALP", m3_EALP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EALR))
				request.WithQueryParameter("EALR", m3_EALR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EALS))
				request.WithQueryParameter("EALS", m3_EALS.Trim());
			if (m3_DEDA.HasValue)
				request.WithQueryParameter("DEDA", m3_DEDA.Value.ToM3String());
			if (m3_GPDF.HasValue)
				request.WithQueryParameter("GPDF", m3_GPDF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BKID))
				request.WithQueryParameter("BKID", m3_BKID.Trim());
			if (m3_GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3_GEOC.Value.ToString());
			if (m3_TXIN.HasValue)
				request.WithQueryParameter("TXIN", m3_TXIN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DNOI))
				request.WithQueryParameter("DNOI", m3_DNOI.Trim());
			if (m3_OYEA.HasValue)
				request.WithQueryParameter("OYEA", m3_OYEA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PPYR))
				request.WithQueryParameter("PPYR", m3_PPYR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PPYN))
				request.WithQueryParameter("PPYN", m3_PPYN.Trim());
			if (m3_YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3_YEA4.Value.ToString());
			if (m3_PVLD.HasValue)
				request.WithQueryParameter("PVLD", m3_PVLD.Value.ToString());
			if (m3_VONO.HasValue)
				request.WithQueryParameter("VONO", m3_VONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CORI))
				request.WithQueryParameter("CORI", m3_CORI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());

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
