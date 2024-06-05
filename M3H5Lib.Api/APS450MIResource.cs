/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3INBN">Invoice batch number (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3CRNO">Credit number</param>
		/// <param name="m3YRE1">Your reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Acknowledge(
			long m3INBN, 
			string m3DIVI = null, 
			string m3CRNO = null, 
			string m3YRE1 = null, 
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
				.WithQueryParameter("INBN", m3INBN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CRNO))
				request.WithQueryParameter("CRNO", m3CRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3YRE1))
				request.WithQueryParameter("YRE1", m3YRE1.Trim());

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
		/// Name AddAddInfo
		/// Description Adds an invoice batch additional information ref
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3INBN">Invoice batch number (Required)</param>
		/// <param name="m3PEXN">AP information category (Required)</param>
		/// <param name="m3PEXI">AP additional information (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3PEXS">AP information sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAddInfo(
			long m3INBN, 
			int m3PEXN, 
			string m3PEXI, 
			string m3DIVI = null, 
			int? m3PEXS = null, 
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
			if (string.IsNullOrWhiteSpace(m3PEXI))
				throw new ArgumentNullException(nameof(m3PEXI));

			// Set mandatory parameters
			request
				.WithQueryParameter("INBN", m3INBN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PEXN", m3PEXN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PEXI", m3PEXI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3PEXS.HasValue)
				request.WithQueryParameter("PEXS", m3PEXS.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddHead
		/// Description Adds an invoice batch head
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3SUNO">Supplier (Required)</param>
		/// <param name="m3IVDT">Invoice date (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3IBTP">Invoice batch type</param>
		/// <param name="m3SINO">Supplier invoice number</param>
		/// <param name="m3SPYN">Payee</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3ARAT">Exchange rate</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3PYME">Payment method - accounts payable</param>
		/// <param name="m3TDCD">Trade code</param>
		/// <param name="m3CUAM">Foreign currency amount</param>
		/// <param name="m3VTAM">VAT</param>
		/// <param name="m3ACDT">Accounting date</param>
		/// <param name="m3APCD">Authorized user</param>
		/// <param name="m3IMCD">Invoice matching</param>
		/// <param name="m3SERS">Service code</param>
		/// <param name="m3DUDT">Due date</param>
		/// <param name="m3FECN">Future rate agreement number</param>
		/// <param name="m3CRTP">Exchange rate type</param>
		/// <param name="m3FTCO">From/to country</param>
		/// <param name="m3BSCD">Base country</param>
		/// <param name="m3PUNO">Purchase order number</param>
		/// <param name="m3PUDT">Order date</param>
		/// <param name="m3TECD">Cash discount term</param>
		/// <param name="m3CDT1">Cash discount date 1</param>
		/// <param name="m3CDP1">Cash discount percentage</param>
		/// <param name="m3CDC1">Cash discount amount 1</param>
		/// <param name="m3CDT2">Cash discount date 2</param>
		/// <param name="m3CDP2">Cash discount percentage</param>
		/// <param name="m3CDC2">Cash discount amount 2</param>
		/// <param name="m3CDT3">Cash discount date 3</param>
		/// <param name="m3CDP3">Cash discount percentage</param>
		/// <param name="m3CDC3">Cash discount amount 3</param>
		/// <param name="m3TTXA">Total taxable amount</param>
		/// <param name="m3TASD">Cash discount base</param>
		/// <param name="m3PRPA">Prepaid amount</param>
		/// <param name="m3VRNO">VAT registration number</param>
		/// <param name="m3TXAP">Tax applicable</param>
		/// <param name="m3DNCO">Document code</param>
		/// <param name="m3SDAP">AP standard document</param>
		/// <param name="m3DNRE">Debit note reason</param>
		/// <param name="m3PYAD">Our invoicing address</param>
		/// <param name="m3SDA1">Text line 1</param>
		/// <param name="m3SDA2">Text line 2</param>
		/// <param name="m3SDA3">Text line 3</param>
		/// <param name="m3EALP">EAN location code payee</param>
		/// <param name="m3EALR">EAN location code consignee</param>
		/// <param name="m3EALS">EAN location code supplier</param>
		/// <param name="m3DEDA">Delivery date</param>
		/// <param name="m3GPDF">Get payee defaults</param>
		/// <param name="m3BKID">Bank account identity</param>
		/// <param name="m3GEOC">Geographical code</param>
		/// <param name="m3TXIN">Tax included</param>
		/// <param name="m3DNOI">Original invoice number</param>
		/// <param name="m3OYEA">Original year</param>
		/// <param name="m3PPYR">Reference number</param>
		/// <param name="m3PPYN">Payment request  number</param>
		/// <param name="m3YEA4">Year</param>
		/// <param name="m3PVLD">Partial validation</param>
		/// <param name="m3VONO">Voucher number</param>
		/// <param name="m3CORI">Correlation ID</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddHeadResponse></returns>
		/// <exception cref="M3Exception<AddHeadResponse>"></exception>
		public async Task<M3Response<AddHeadResponse>> AddHead(
			string m3SUNO, 
			DateTime m3IVDT, 
			string m3DIVI = null, 
			string m3IBTP = null, 
			string m3SINO = null, 
			string m3SPYN = null, 
			string m3CUCD = null, 
			decimal? m3ARAT = null, 
			string m3TEPY = null, 
			string m3PYME = null, 
			string m3TDCD = null, 
			decimal? m3CUAM = null, 
			decimal? m3VTAM = null, 
			DateTime? m3ACDT = null, 
			string m3APCD = null, 
			string m3IMCD = null, 
			int? m3SERS = null, 
			DateTime? m3DUDT = null, 
			string m3FECN = null, 
			int? m3CRTP = null, 
			string m3FTCO = null, 
			string m3BSCD = null, 
			string m3PUNO = null, 
			DateTime? m3PUDT = null, 
			string m3TECD = null, 
			DateTime? m3CDT1 = null, 
			int? m3CDP1 = null, 
			decimal? m3CDC1 = null, 
			DateTime? m3CDT2 = null, 
			int? m3CDP2 = null, 
			decimal? m3CDC2 = null, 
			DateTime? m3CDT3 = null, 
			int? m3CDP3 = null, 
			decimal? m3CDC3 = null, 
			decimal? m3TTXA = null, 
			decimal? m3TASD = null, 
			decimal? m3PRPA = null, 
			string m3VRNO = null, 
			int? m3TXAP = null, 
			string m3DNCO = null, 
			string m3SDAP = null, 
			string m3DNRE = null, 
			string m3PYAD = null, 
			string m3SDA1 = null, 
			string m3SDA2 = null, 
			string m3SDA3 = null, 
			string m3EALP = null, 
			string m3EALR = null, 
			string m3EALS = null, 
			DateTime? m3DEDA = null, 
			int? m3GPDF = null, 
			string m3BKID = null, 
			int? m3GEOC = null, 
			int? m3TXIN = null, 
			string m3DNOI = null, 
			int? m3OYEA = null, 
			string m3PPYR = null, 
			string m3PPYN = null, 
			int? m3YEA4 = null, 
			int? m3PVLD = null, 
			int? m3VONO = null, 
			string m3CORI = null, 
			string m3ECAR = null, 
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
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("IVDT", m3IVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3IBTP))
				request.WithQueryParameter("IBTP", m3IBTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3SINO))
				request.WithQueryParameter("SINO", m3SINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPYN))
				request.WithQueryParameter("SPYN", m3SPYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3ARAT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYME))
				request.WithQueryParameter("PYME", m3PYME.Trim());
			if (!string.IsNullOrWhiteSpace(m3TDCD))
				request.WithQueryParameter("TDCD", m3TDCD.Trim());
			if (m3CUAM.HasValue)
				request.WithQueryParameter("CUAM", m3CUAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTAM.HasValue)
				request.WithQueryParameter("VTAM", m3VTAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACDT.HasValue)
				request.WithQueryParameter("ACDT", m3ACDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3APCD))
				request.WithQueryParameter("APCD", m3APCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3IMCD))
				request.WithQueryParameter("IMCD", m3IMCD.Trim());
			if (m3SERS.HasValue)
				request.WithQueryParameter("SERS", m3SERS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DUDT.HasValue)
				request.WithQueryParameter("DUDT", m3DUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3FECN))
				request.WithQueryParameter("FECN", m3FECN.Trim());
			if (m3CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3CRTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FTCO))
				request.WithQueryParameter("FTCO", m3FTCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BSCD))
				request.WithQueryParameter("BSCD", m3BSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PUNO))
				request.WithQueryParameter("PUNO", m3PUNO.Trim());
			if (m3PUDT.HasValue)
				request.WithQueryParameter("PUDT", m3PUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TECD))
				request.WithQueryParameter("TECD", m3TECD.Trim());
			if (m3CDT1.HasValue)
				request.WithQueryParameter("CDT1", m3CDT1.Value.ToM3String());
			if (m3CDP1.HasValue)
				request.WithQueryParameter("CDP1", m3CDP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CDC1.HasValue)
				request.WithQueryParameter("CDC1", m3CDC1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CDT2.HasValue)
				request.WithQueryParameter("CDT2", m3CDT2.Value.ToM3String());
			if (m3CDP2.HasValue)
				request.WithQueryParameter("CDP2", m3CDP2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CDC2.HasValue)
				request.WithQueryParameter("CDC2", m3CDC2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CDT3.HasValue)
				request.WithQueryParameter("CDT3", m3CDT3.Value.ToM3String());
			if (m3CDP3.HasValue)
				request.WithQueryParameter("CDP3", m3CDP3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CDC3.HasValue)
				request.WithQueryParameter("CDC3", m3CDC3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TTXA.HasValue)
				request.WithQueryParameter("TTXA", m3TTXA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TASD.HasValue)
				request.WithQueryParameter("TASD", m3TASD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRPA.HasValue)
				request.WithQueryParameter("PRPA", m3PRPA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3VRNO))
				request.WithQueryParameter("VRNO", m3VRNO.Trim());
			if (m3TXAP.HasValue)
				request.WithQueryParameter("TXAP", m3TXAP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DNCO))
				request.WithQueryParameter("DNCO", m3DNCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDAP))
				request.WithQueryParameter("SDAP", m3SDAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3DNRE))
				request.WithQueryParameter("DNRE", m3DNRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYAD))
				request.WithQueryParameter("PYAD", m3PYAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDA1))
				request.WithQueryParameter("SDA1", m3SDA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDA2))
				request.WithQueryParameter("SDA2", m3SDA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDA3))
				request.WithQueryParameter("SDA3", m3SDA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3EALP))
				request.WithQueryParameter("EALP", m3EALP.Trim());
			if (!string.IsNullOrWhiteSpace(m3EALR))
				request.WithQueryParameter("EALR", m3EALR.Trim());
			if (!string.IsNullOrWhiteSpace(m3EALS))
				request.WithQueryParameter("EALS", m3EALS.Trim());
			if (m3DEDA.HasValue)
				request.WithQueryParameter("DEDA", m3DEDA.Value.ToM3String());
			if (m3GPDF.HasValue)
				request.WithQueryParameter("GPDF", m3GPDF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BKID))
				request.WithQueryParameter("BKID", m3BKID.Trim());
			if (m3GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3GEOC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXIN.HasValue)
				request.WithQueryParameter("TXIN", m3TXIN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DNOI))
				request.WithQueryParameter("DNOI", m3DNOI.Trim());
			if (m3OYEA.HasValue)
				request.WithQueryParameter("OYEA", m3OYEA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PPYR))
				request.WithQueryParameter("PPYR", m3PPYR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PPYN))
				request.WithQueryParameter("PPYN", m3PPYN.Trim());
			if (m3YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3YEA4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PVLD.HasValue)
				request.WithQueryParameter("PVLD", m3PVLD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VONO.HasValue)
				request.WithQueryParameter("VONO", m3VONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CORI))
				request.WithQueryParameter("CORI", m3CORI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());

			// Execute the request
			var result = await Execute<AddHeadResponse>(
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
		/// Name AddLine
		/// Description Adds an invoice batch line
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3INBN">Invoice batch number (Required)</param>
		/// <param name="m3RDTP">Line type (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3SERS">Service code</param>
		/// <param name="m3NLAM">Net amount - line</param>
		/// <param name="m3VTA1">VAT amount 1</param>
		/// <param name="m3VTA2">VAT amount 2</param>
		/// <param name="m3VTCD">VAT code</param>
		/// <param name="m3PUNO">Purchase order number</param>
		/// <param name="m3PNLI">Purchase order line</param>
		/// <param name="m3PNLS">Purchase order line subnumber</param>
		/// <param name="m3IVQA">Invoiced quantity - alternate U/M</param>
		/// <param name="m3PUUN">Purchase order U/M</param>
		/// <param name="m3GRPR">Gross price</param>
		/// <param name="m3PPUN">Purchase price U/M</param>
		/// <param name="m3NEPR">Net price</param>
		/// <param name="m3PUCD">Purchase price quantity</param>
		/// <param name="m3GLAM">Gross amount - line</param>
		/// <param name="m3DIPC">Discount</param>
		/// <param name="m3DIAM">Discount amount</param>
		/// <param name="m3IVCW">Invoiced catch weight</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3SBAN">Self-billing agreement number</param>
		/// <param name="m3CDSE">Sequence number - costing element</param>
		/// <param name="m3CEID">Costing element</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3RELP">Receipt type</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3DNDT">Delivery note date</param>
		/// <param name="m3CLAN">Claim number</param>
		/// <param name="m3CLLN">Claim order line</param>
		/// <param name="m3TRNO">Transaction number</param>
		/// <param name="m3VTP1">VAT rate 1</param>
		/// <param name="m3VTP2">VAT rate 2</param>
		/// <param name="m3CHGT">Charge text</param>
		/// <param name="m3PVLD">Partial validation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddLineResponse></returns>
		/// <exception cref="M3Exception<AddLineResponse>"></exception>
		public async Task<M3Response<AddLineResponse>> AddLine(
			long m3INBN, 
			int m3RDTP, 
			string m3DIVI = null, 
			int? m3SERS = null, 
			decimal? m3NLAM = null, 
			decimal? m3VTA1 = null, 
			decimal? m3VTA2 = null, 
			int? m3VTCD = null, 
			string m3PUNO = null, 
			int? m3PNLI = null, 
			int? m3PNLS = null, 
			decimal? m3IVQA = null, 
			string m3PUUN = null, 
			decimal? m3GRPR = null, 
			string m3PPUN = null, 
			decimal? m3NEPR = null, 
			int? m3PUCD = null, 
			decimal? m3GLAM = null, 
			int? m3DIPC = null, 
			decimal? m3DIAM = null, 
			decimal? m3IVCW = null, 
			string m3ITNO = null, 
			string m3POPN = null, 
			string m3SBAN = null, 
			int? m3CDSE = null, 
			string m3CEID = null, 
			long? m3REPN = null, 
			int? m3RELP = null, 
			string m3SUDO = null, 
			DateTime? m3DNDT = null, 
			string m3CLAN = null, 
			int? m3CLLN = null, 
			int? m3TRNO = null, 
			int? m3VTP1 = null, 
			int? m3VTP2 = null, 
			string m3CHGT = null, 
			int? m3PVLD = null, 
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
				.WithQueryParameter("INBN", m3INBN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RDTP", m3RDTP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3SERS.HasValue)
				request.WithQueryParameter("SERS", m3SERS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NLAM.HasValue)
				request.WithQueryParameter("NLAM", m3NLAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTA1.HasValue)
				request.WithQueryParameter("VTA1", m3VTA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTA2.HasValue)
				request.WithQueryParameter("VTA2", m3VTA2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3VTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PUNO))
				request.WithQueryParameter("PUNO", m3PUNO.Trim());
			if (m3PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3PNLI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3PNLS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IVQA.HasValue)
				request.WithQueryParameter("IVQA", m3IVQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PUUN))
				request.WithQueryParameter("PUUN", m3PUUN.Trim());
			if (m3GRPR.HasValue)
				request.WithQueryParameter("GRPR", m3GRPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PPUN))
				request.WithQueryParameter("PPUN", m3PPUN.Trim());
			if (m3NEPR.HasValue)
				request.WithQueryParameter("NEPR", m3NEPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3PUCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GLAM.HasValue)
				request.WithQueryParameter("GLAM", m3GLAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIPC.HasValue)
				request.WithQueryParameter("DIPC", m3DIPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIAM.HasValue)
				request.WithQueryParameter("DIAM", m3DIAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IVCW.HasValue)
				request.WithQueryParameter("IVCW", m3IVCW.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SBAN))
				request.WithQueryParameter("SBAN", m3SBAN.Trim());
			if (m3CDSE.HasValue)
				request.WithQueryParameter("CDSE", m3CDSE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CEID))
				request.WithQueryParameter("CEID", m3CEID.Trim());
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RELP.HasValue)
				request.WithQueryParameter("RELP", m3RELP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (m3DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3DNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CLAN))
				request.WithQueryParameter("CLAN", m3CLAN.Trim());
			if (m3CLLN.HasValue)
				request.WithQueryParameter("CLLN", m3CLLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRNO.HasValue)
				request.WithQueryParameter("TRNO", m3TRNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTP1.HasValue)
				request.WithQueryParameter("VTP1", m3VTP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTP2.HasValue)
				request.WithQueryParameter("VTP2", m3VTP2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHGT))
				request.WithQueryParameter("CHGT", m3CHGT.Trim());
			if (m3PVLD.HasValue)
				request.WithQueryParameter("PVLD", m3PVLD.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddLineResponse>(
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
		/// Name AdjustLine
		/// Description Adjust amount on invoice line
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3INBN">Invoice batch number (Required)</param>
		/// <param name="m3TRNO">Transaction number (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3ADAB">Adjusted amount</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AdjustLine(
			long m3INBN, 
			int m3TRNO, 
			string m3DIVI = null, 
			decimal? m3ADAB = null, 
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
				.WithQueryParameter("INBN", m3INBN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TRNO", m3TRNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3ADAB.HasValue)
				request.WithQueryParameter("ADAB", m3ADAB.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ApproveInvoice
		/// Description Approves the supplier invoice batch
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3INBN">Invoice batch number (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3AAPD">Approval date</param>
		/// <param name="m3CRNO">Credit number</param>
		/// <param name="m3YRE1">Your reference</param>
		/// <param name="m3SINO">Supplier invoice number</param>
		/// <param name="m3IVDT">Invoice date</param>
		/// <param name="m3DUDT">Due date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ApproveInvoice(
			long m3INBN, 
			string m3DIVI = null, 
			DateTime? m3AAPD = null, 
			string m3CRNO = null, 
			string m3YRE1 = null, 
			string m3SINO = null, 
			DateTime? m3IVDT = null, 
			DateTime? m3DUDT = null, 
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
				.WithQueryParameter("INBN", m3INBN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3AAPD.HasValue)
				request.WithQueryParameter("AAPD", m3AAPD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CRNO))
				request.WithQueryParameter("CRNO", m3CRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3YRE1))
				request.WithQueryParameter("YRE1", m3YRE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SINO))
				request.WithQueryParameter("SINO", m3SINO.Trim());
			if (m3IVDT.HasValue)
				request.WithQueryParameter("IVDT", m3IVDT.Value.ToM3String());
			if (m3DUDT.HasValue)
				request.WithQueryParameter("DUDT", m3DUDT.Value.ToM3String());

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
		/// Name GetHead
		/// Description Gets data from supplier invoice batch head
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3INBN">Invoice batch number (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadResponse></returns>
		/// <exception cref="M3Exception<GetHeadResponse>"></exception>
		public async Task<M3Response<GetHeadResponse>> GetHead(
			long m3INBN, 
			string m3DIVI = null, 
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
				.WithQueryParameter("INBN", m3INBN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<GetHeadResponse>(
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
		/// Name LstClaimDetails
		/// Description Lists claim invoice details
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3INBN">Invoice batch number (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3YEA4">Year</param>
		/// <param name="m3EXIN">Extended Invoice Number</param>
		/// <param name="m3RIDI">Delivery number</param>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3ALI1">Transaction number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstClaimDetailsResponse></returns>
		/// <exception cref="M3Exception<LstClaimDetailsResponse>"></exception>
		public async Task<M3Response<LstClaimDetailsResponse>> LstClaimDetails(
			long m3INBN, 
			string m3DIVI = null, 
			int? m3YEA4 = null, 
			string m3EXIN = null, 
			decimal? m3RIDI = null, 
			string m3ORCA = null, 
			string m3RIDN = null, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
			int? m3ALI1 = null, 
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
				.WithQueryParameter("INBN", m3INBN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3YEA4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EXIN))
				request.WithQueryParameter("EXIN", m3EXIN.Trim());
			if (m3RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3RIDI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALI1.HasValue)
				request.WithQueryParameter("ALI1", m3ALI1.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstClaimDetailsResponse>(
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
		/// Name LstInvBatchNo
		/// Description Lists invoice batch numbers by payee
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3SPYN">Payee (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3IBTP">Invoice batch type</param>
		/// <param name="m3SUPA">Invoice status</param>
		/// <param name="m3INBN">Invoice batch number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvBatchNoResponse></returns>
		/// <exception cref="M3Exception<LstInvBatchNoResponse>"></exception>
		public async Task<M3Response<LstInvBatchNoResponse>> LstInvBatchNo(
			string m3SPYN, 
			string m3DIVI = null, 
			string m3SUNO = null, 
			string m3IBTP = null, 
			int? m3SUPA = null, 
			long? m3INBN = null, 
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
			if (string.IsNullOrWhiteSpace(m3SPYN))
				throw new ArgumentNullException(nameof(m3SPYN));

			// Set mandatory parameters
			request
				.WithQueryParameter("SPYN", m3SPYN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3IBTP))
				request.WithQueryParameter("IBTP", m3IBTP.Trim());
			if (m3SUPA.HasValue)
				request.WithQueryParameter("SUPA", m3SUPA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INBN.HasValue)
				request.WithQueryParameter("INBN", m3INBN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstInvBatchNoResponse>(
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
		/// Name LstInvBySupInv
		/// Description Lists invoice batch numbers by supplier invoice number
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3SPYN">Payee (Required)</param>
		/// <param name="m3SUNO">Supplier (Required)</param>
		/// <param name="m3SINO">Supplier invoice number (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvBySupInvResponse></returns>
		/// <exception cref="M3Exception<LstInvBySupInvResponse>"></exception>
		public async Task<M3Response<LstInvBySupInvResponse>> LstInvBySupInv(
			string m3SPYN, 
			string m3SUNO, 
			string m3SINO, 
			string m3DIVI = null, 
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
			if (string.IsNullOrWhiteSpace(m3SPYN))
				throw new ArgumentNullException(nameof(m3SPYN));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SINO))
				throw new ArgumentNullException(nameof(m3SINO));

			// Set mandatory parameters
			request
				.WithQueryParameter("SPYN", m3SPYN.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SINO", m3SINO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<LstInvBySupInvResponse>(
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
		/// Name LstLines
		/// Description Lists supplier invoice batch line data
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3INBN">Invoice batch number (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3TRNO">Transaction number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLinesResponse></returns>
		/// <exception cref="M3Exception<LstLinesResponse>"></exception>
		public async Task<M3Response<LstLinesResponse>> LstLines(
			long m3INBN, 
			string m3DIVI = null, 
			int? m3TRNO = null, 
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
				.WithQueryParameter("INBN", m3INBN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3TRNO.HasValue)
				request.WithQueryParameter("TRNO", m3TRNO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstLinesResponse>(
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
		/// Name PrintInvoice
		/// Description Submits print of the invoice
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3INBN">Invoice batch number (Required)</param>
		/// <param name="m3LITP">Report layout (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrintInvoice(
			long m3INBN, 
			int m3LITP, 
			string m3DIVI = null, 
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
				.WithQueryParameter("INBN", m3INBN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("LITP", m3LITP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

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
		/// Name RejectInvoice
		/// Description Rejects the supplier invoice batch
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3INBN">Invoice batch number (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3REJD">Rejection date</param>
		/// <param name="m3SCRE">Rejection reason</param>
		/// <param name="m3RPAA">Reprint after adjustment</param>
		/// <param name="m3SDA1">Text line 1</param>
		/// <param name="m3SDA2">Text line 2</param>
		/// <param name="m3SDA3">Text line 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<RejectInvoiceResponse></returns>
		/// <exception cref="M3Exception<RejectInvoiceResponse>"></exception>
		public async Task<M3Response<RejectInvoiceResponse>> RejectInvoice(
			long m3INBN, 
			string m3DIVI = null, 
			DateTime? m3REJD = null, 
			string m3SCRE = null, 
			int? m3RPAA = null, 
			string m3SDA1 = null, 
			string m3SDA2 = null, 
			string m3SDA3 = null, 
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
				.WithQueryParameter("INBN", m3INBN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3REJD.HasValue)
				request.WithQueryParameter("REJD", m3REJD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3SCRE))
				request.WithQueryParameter("SCRE", m3SCRE.Trim());
			if (m3RPAA.HasValue)
				request.WithQueryParameter("RPAA", m3RPAA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SDA1))
				request.WithQueryParameter("SDA1", m3SDA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDA2))
				request.WithQueryParameter("SDA2", m3SDA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDA3))
				request.WithQueryParameter("SDA3", m3SDA3.Trim());

			// Execute the request
			var result = await Execute<RejectInvoiceResponse>(
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
		/// Name UpdClaimDetails
		/// Description Update claim invoice details
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3INBN">Invoice batch number (Required)</param>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3EXIN">Extended invoice number (Required)</param>
		/// <param name="m3RIDI">Delivery number (Required)</param>
		/// <param name="m3ORCA">Order category (Required)</param>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3RIDL">Order line (Required)</param>
		/// <param name="m3RIDX">Line suffix (Required)</param>
		/// <param name="m3ALI1">Transaction number</param>
		/// <param name="m3PARA">Paid rebate amount</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimDetails(
			string m3DIVI, 
			long m3INBN, 
			int m3YEA4, 
			string m3EXIN, 
			decimal m3RIDI, 
			string m3ORCA, 
			string m3RIDN, 
			int m3RIDL, 
			int m3RIDX, 
			int? m3ALI1 = null, 
			decimal? m3PARA = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3EXIN))
				throw new ArgumentNullException(nameof(m3EXIN));
			if (string.IsNullOrWhiteSpace(m3ORCA))
				throw new ArgumentNullException(nameof(m3ORCA));
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("INBN", m3INBN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("YEA4", m3YEA4.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("EXIN", m3EXIN.Trim())
				.WithQueryParameter("RIDI", m3RIDI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ORCA", m3ORCA.Trim())
				.WithQueryParameter("RIDN", m3RIDN.Trim())
				.WithQueryParameter("RIDL", m3RIDL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RIDX", m3RIDX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3ALI1.HasValue)
				request.WithQueryParameter("ALI1", m3ALI1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PARA.HasValue)
				request.WithQueryParameter("PARA", m3PARA.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdHead
		/// Description Updatess an invoice batch head
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3INBN">Invoice batch number (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3SINO">Supplier invoice number</param>
		/// <param name="m3SPYN">Payee</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3IVDT">Invoice date</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3ARAT">Exchange rate</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3PYME">Payment method - accounts payable</param>
		/// <param name="m3TDCD">Trade code</param>
		/// <param name="m3CUAM">Foreign currency amount</param>
		/// <param name="m3VTAM">VAT</param>
		/// <param name="m3ACDT">Accounting date</param>
		/// <param name="m3APCD">Authorized user</param>
		/// <param name="m3IMCD">Invoice matching</param>
		/// <param name="m3SERS">Service code</param>
		/// <param name="m3DUDT">Due date</param>
		/// <param name="m3FECN">Future rate agreement number</param>
		/// <param name="m3CRTP">Exchange rate type</param>
		/// <param name="m3FTCO">From/to country</param>
		/// <param name="m3BSCD">Base country</param>
		/// <param name="m3PUNO">Purchase order number</param>
		/// <param name="m3PUDT">Order date</param>
		/// <param name="m3TECD">Cash discount term</param>
		/// <param name="m3CDT1">Cash discount date 1</param>
		/// <param name="m3CDP1">Cash discount percentage</param>
		/// <param name="m3CDC1">Cash discount amount 1</param>
		/// <param name="m3CDT2">Cash discount date 2</param>
		/// <param name="m3CDP2">Cash discount percentage</param>
		/// <param name="m3CDC2">Cash discount amount 2</param>
		/// <param name="m3CDT3">Cash discount date 3</param>
		/// <param name="m3CDP3">Cash discount percentage</param>
		/// <param name="m3CDC3">Cash discount amount 3</param>
		/// <param name="m3TTXA">Total taxable amount</param>
		/// <param name="m3TASD">Cash discount base</param>
		/// <param name="m3PRPA">Prepaid amount</param>
		/// <param name="m3VRNO">VAT registration number</param>
		/// <param name="m3TXAP">Tax applicable</param>
		/// <param name="m3DNCO">Document code</param>
		/// <param name="m3SDAP">AP standard document</param>
		/// <param name="m3DNRE">Debit note reason</param>
		/// <param name="m3PYAD">Our invoicing address</param>
		/// <param name="m3SDA1">Text line 1</param>
		/// <param name="m3SDA2">Text line 2</param>
		/// <param name="m3SDA3">Text line 3</param>
		/// <param name="m3EALP">EAN location code payee</param>
		/// <param name="m3EALR">EAN location code consignee</param>
		/// <param name="m3EALS">EAN location code supplier</param>
		/// <param name="m3DEDA">Delivery date</param>
		/// <param name="m3GPDF">Get payee defaults</param>
		/// <param name="m3BKID">Bank account identity</param>
		/// <param name="m3GEOC">Geographical code</param>
		/// <param name="m3TXIN">Tax included</param>
		/// <param name="m3DNOI">Original invoice number</param>
		/// <param name="m3OYEA">Original year</param>
		/// <param name="m3PPYR">Reference number</param>
		/// <param name="m3PPYN">Payment request  number</param>
		/// <param name="m3YEA4">Year</param>
		/// <param name="m3PVLD">Partial validation</param>
		/// <param name="m3VONO">Voucher number</param>
		/// <param name="m3CORI">Correlation ID</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdHead(
			long m3INBN, 
			string m3DIVI = null, 
			string m3SINO = null, 
			string m3SPYN = null, 
			string m3SUNO = null, 
			DateTime? m3IVDT = null, 
			string m3CUCD = null, 
			decimal? m3ARAT = null, 
			string m3TEPY = null, 
			string m3PYME = null, 
			string m3TDCD = null, 
			decimal? m3CUAM = null, 
			decimal? m3VTAM = null, 
			DateTime? m3ACDT = null, 
			string m3APCD = null, 
			string m3IMCD = null, 
			int? m3SERS = null, 
			DateTime? m3DUDT = null, 
			string m3FECN = null, 
			int? m3CRTP = null, 
			string m3FTCO = null, 
			string m3BSCD = null, 
			string m3PUNO = null, 
			DateTime? m3PUDT = null, 
			string m3TECD = null, 
			DateTime? m3CDT1 = null, 
			int? m3CDP1 = null, 
			decimal? m3CDC1 = null, 
			DateTime? m3CDT2 = null, 
			int? m3CDP2 = null, 
			decimal? m3CDC2 = null, 
			DateTime? m3CDT3 = null, 
			int? m3CDP3 = null, 
			decimal? m3CDC3 = null, 
			decimal? m3TTXA = null, 
			decimal? m3TASD = null, 
			decimal? m3PRPA = null, 
			string m3VRNO = null, 
			int? m3TXAP = null, 
			string m3DNCO = null, 
			string m3SDAP = null, 
			string m3DNRE = null, 
			string m3PYAD = null, 
			string m3SDA1 = null, 
			string m3SDA2 = null, 
			string m3SDA3 = null, 
			string m3EALP = null, 
			string m3EALR = null, 
			string m3EALS = null, 
			DateTime? m3DEDA = null, 
			int? m3GPDF = null, 
			string m3BKID = null, 
			int? m3GEOC = null, 
			int? m3TXIN = null, 
			string m3DNOI = null, 
			int? m3OYEA = null, 
			string m3PPYR = null, 
			string m3PPYN = null, 
			int? m3YEA4 = null, 
			int? m3PVLD = null, 
			int? m3VONO = null, 
			string m3CORI = null, 
			string m3ECAR = null, 
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
				.WithQueryParameter("INBN", m3INBN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SINO))
				request.WithQueryParameter("SINO", m3SINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPYN))
				request.WithQueryParameter("SPYN", m3SPYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3IVDT.HasValue)
				request.WithQueryParameter("IVDT", m3IVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3ARAT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYME))
				request.WithQueryParameter("PYME", m3PYME.Trim());
			if (!string.IsNullOrWhiteSpace(m3TDCD))
				request.WithQueryParameter("TDCD", m3TDCD.Trim());
			if (m3CUAM.HasValue)
				request.WithQueryParameter("CUAM", m3CUAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTAM.HasValue)
				request.WithQueryParameter("VTAM", m3VTAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACDT.HasValue)
				request.WithQueryParameter("ACDT", m3ACDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3APCD))
				request.WithQueryParameter("APCD", m3APCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3IMCD))
				request.WithQueryParameter("IMCD", m3IMCD.Trim());
			if (m3SERS.HasValue)
				request.WithQueryParameter("SERS", m3SERS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DUDT.HasValue)
				request.WithQueryParameter("DUDT", m3DUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3FECN))
				request.WithQueryParameter("FECN", m3FECN.Trim());
			if (m3CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3CRTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FTCO))
				request.WithQueryParameter("FTCO", m3FTCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BSCD))
				request.WithQueryParameter("BSCD", m3BSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PUNO))
				request.WithQueryParameter("PUNO", m3PUNO.Trim());
			if (m3PUDT.HasValue)
				request.WithQueryParameter("PUDT", m3PUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TECD))
				request.WithQueryParameter("TECD", m3TECD.Trim());
			if (m3CDT1.HasValue)
				request.WithQueryParameter("CDT1", m3CDT1.Value.ToM3String());
			if (m3CDP1.HasValue)
				request.WithQueryParameter("CDP1", m3CDP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CDC1.HasValue)
				request.WithQueryParameter("CDC1", m3CDC1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CDT2.HasValue)
				request.WithQueryParameter("CDT2", m3CDT2.Value.ToM3String());
			if (m3CDP2.HasValue)
				request.WithQueryParameter("CDP2", m3CDP2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CDC2.HasValue)
				request.WithQueryParameter("CDC2", m3CDC2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CDT3.HasValue)
				request.WithQueryParameter("CDT3", m3CDT3.Value.ToM3String());
			if (m3CDP3.HasValue)
				request.WithQueryParameter("CDP3", m3CDP3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CDC3.HasValue)
				request.WithQueryParameter("CDC3", m3CDC3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TTXA.HasValue)
				request.WithQueryParameter("TTXA", m3TTXA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TASD.HasValue)
				request.WithQueryParameter("TASD", m3TASD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRPA.HasValue)
				request.WithQueryParameter("PRPA", m3PRPA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3VRNO))
				request.WithQueryParameter("VRNO", m3VRNO.Trim());
			if (m3TXAP.HasValue)
				request.WithQueryParameter("TXAP", m3TXAP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DNCO))
				request.WithQueryParameter("DNCO", m3DNCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDAP))
				request.WithQueryParameter("SDAP", m3SDAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3DNRE))
				request.WithQueryParameter("DNRE", m3DNRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYAD))
				request.WithQueryParameter("PYAD", m3PYAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDA1))
				request.WithQueryParameter("SDA1", m3SDA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDA2))
				request.WithQueryParameter("SDA2", m3SDA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDA3))
				request.WithQueryParameter("SDA3", m3SDA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3EALP))
				request.WithQueryParameter("EALP", m3EALP.Trim());
			if (!string.IsNullOrWhiteSpace(m3EALR))
				request.WithQueryParameter("EALR", m3EALR.Trim());
			if (!string.IsNullOrWhiteSpace(m3EALS))
				request.WithQueryParameter("EALS", m3EALS.Trim());
			if (m3DEDA.HasValue)
				request.WithQueryParameter("DEDA", m3DEDA.Value.ToM3String());
			if (m3GPDF.HasValue)
				request.WithQueryParameter("GPDF", m3GPDF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BKID))
				request.WithQueryParameter("BKID", m3BKID.Trim());
			if (m3GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3GEOC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXIN.HasValue)
				request.WithQueryParameter("TXIN", m3TXIN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DNOI))
				request.WithQueryParameter("DNOI", m3DNOI.Trim());
			if (m3OYEA.HasValue)
				request.WithQueryParameter("OYEA", m3OYEA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PPYR))
				request.WithQueryParameter("PPYR", m3PPYR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PPYN))
				request.WithQueryParameter("PPYN", m3PPYN.Trim());
			if (m3YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3YEA4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PVLD.HasValue)
				request.WithQueryParameter("PVLD", m3PVLD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VONO.HasValue)
				request.WithQueryParameter("VONO", m3VONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CORI))
				request.WithQueryParameter("CORI", m3CORI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());

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
