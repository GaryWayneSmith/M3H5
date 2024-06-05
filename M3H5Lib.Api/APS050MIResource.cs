/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.APS050MI;
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
	/// Name: APS050MI
	/// Component Name: SupplierInvoice
	/// Description: Supplier invoice interface
	/// Version Release: 14.x
	///</summary>
	public partial class APS050MIResource : M3BaseResourceEndpoint
	{
		public APS050MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "APS050MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AcceptInv
		/// Description Accept Self-billing invoice
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3SPYN">Payee (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SINO">Supplier invoice number (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PUDT">Order date</param>
		/// <param name="m3SDA1">Text line 1</param>
		/// <param name="m3SDA2">Text line 2</param>
		/// <param name="m3SDA3">Text line 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AcceptInv(
			string m3DIVI, 
			string m3SPYN, 
			string m3SUNO, 
			string m3SINO, 
			string m3CUCD, 
			int? m3CONO = null, 
			DateTime? m3PUDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AcceptInv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3SPYN))
				throw new ArgumentNullException(nameof(m3SPYN));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SINO))
				throw new ArgumentNullException(nameof(m3SINO));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("SPYN", m3SPYN.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SINO", m3SINO.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUDT.HasValue)
				request.WithQueryParameter("PUDT", m3PUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3SDA1))
				request.WithQueryParameter("SDA1", m3SDA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDA2))
				request.WithQueryParameter("SDA2", m3SDA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDA3))
				request.WithQueryParameter("SDA3", m3SDA3.Trim());

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
		/// Name AddBatchAddInfo
		/// Description Create new batch invoice additional information reference
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SINO">Supplier invoice number (Required)</param>
		/// <param name="m3PEXN">AP information category (Required)</param>
		/// <param name="m3PEXI">AP additional information (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SPYN">Payee</param>
		/// <param name="m3PEXS">AP information sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBatchAddInfo(
			string m3DIVI, 
			string m3SUNO, 
			string m3SINO, 
			int m3PEXN, 
			string m3PEXI, 
			int? m3CONO = null, 
			string m3SPYN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBatchAddInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SINO))
				throw new ArgumentNullException(nameof(m3SINO));
			if (string.IsNullOrWhiteSpace(m3PEXI))
				throw new ArgumentNullException(nameof(m3PEXI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SINO", m3SINO.Trim())
				.WithQueryParameter("PEXN", m3PEXN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PEXI", m3PEXI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPYN))
				request.WithQueryParameter("SPYN", m3SPYN.Trim());
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
		/// Name AddBatchHead
		/// Description Create new batch invoice head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SINO">Supplier invoice number (Required)</param>
		/// <param name="m3IVDT">Invoice date (Required)</param>
		/// <param name="m3CUAM">Foreign currency amount (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SPYN">Payee</param>
		/// <param name="m3BITP">Type of automatically generated invoice</param>
		/// <param name="m3IMCD">Invoice matching</param>
		/// <param name="m3EALS">EAN location code supplier</param>
		/// <param name="m3VRNO">VAT registration number</param>
		/// <param name="m3EALP">EAN location code payee</param>
		/// <param name="m3EALR">EAN location code consignee</param>
		/// <param name="m3DUDT">Due date</param>
		/// <param name="m3IVTP">Information type</param>
		/// <param name="m3DNCO">Document code</param>
		/// <param name="m3VTAM">VAT</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3TLNA">Total line amount - net</param>
		/// <param name="m3TASD">Discount base amount</param>
		/// <param name="m3TTXA">Total taxable amount</param>
		/// <param name="m3TCHG">Total charges</param>
		/// <param name="m3TOPA">Total due</param>
		/// <param name="m3PRPA">Prepaid amount</param>
		/// <param name="m3TECD">Cash discount term</param>
		/// <param name="m3CDT1">Cash discount date 1</param>
		/// <param name="m3CDP1">Cash discount percentage</param>
		/// <param name="m3CDC1">Cash discount amount 1</param>
		/// <param name="m3CDT2">Cash discount date 2</param>
		/// <param name="m3CDP2">Cash discount percentage 2</param>
		/// <param name="m3CDC2">Cash discount amount 2</param>
		/// <param name="m3CDT3">Cash discount date 3</param>
		/// <param name="m3CDP3">Cash discount percentage 3</param>
		/// <param name="m3CDC3">Cash discount amount 3</param>
		/// <param name="m3PYME">Payment method - accounts payable</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3ARAT">Exchange rate</param>
		/// <param name="m3CRTP">Exchange rate type</param>
		/// <param name="m3PUDT">Order date</param>
		/// <param name="m3FECN">Future rate agreement number</param>
		/// <param name="m3SERS">Service code</param>
		/// <param name="m3VSER">Voucher number series</param>
		/// <param name="m3VONO">Voucher number</param>
		/// <param name="m3ACDT">Accounting date</param>
		/// <param name="m3BIST">Status - batch invoice</param>
		/// <param name="m3INST">Status - invoice</param>
		/// <param name="m3UPBI">Invoice per receiving number</param>
		/// <param name="m3SUAC">Supplier acceptance</param>
		/// <param name="m3SBAD">Conditions for adding lines</param>
		/// <param name="m3PYAD">Our invoicing address</param>
		/// <param name="m3APCD">Authorized</param>
		/// <param name="m3SDAP">AP standard document</param>
		/// <param name="m3DNRE">Debit note reason</param>
		/// <param name="m3SDA1">Text line 1</param>
		/// <param name="m3SDA2">Text line 2</param>
		/// <param name="m3SDA3">Text line 3</param>
		/// <param name="m3BSCD">Base country code</param>
		/// <param name="m3FTCO">From/To country</param>
		/// <param name="m3TDCD">Trade code</param>
		/// <param name="m3TXAP">Tax applicable</param>
		/// <param name="m3VDME">VAT summation method</param>
		/// <param name="m3PUNO">Purchase order number</param>
		/// <param name="m3APCT">Authorized description</param>
		/// <param name="m3DEDA">Delivery date</param>
		/// <param name="m3DNOI">Original invoice number</param>
		/// <param name="m3OYEA">Original year</param>
		/// <param name="m3PPYR">Reference number</param>
		/// <param name="m3PPYN">Payment request  number</param>
		/// <param name="m3YEA4">Year</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBatchHead(
			string m3DIVI, 
			string m3SUNO, 
			string m3SINO, 
			DateTime m3IVDT, 
			decimal m3CUAM, 
			int? m3CONO = null, 
			string m3SPYN = null, 
			string m3BITP = null, 
			string m3IMCD = null, 
			string m3EALS = null, 
			string m3VRNO = null, 
			string m3EALP = null, 
			string m3EALR = null, 
			DateTime? m3DUDT = null, 
			string m3IVTP = null, 
			string m3DNCO = null, 
			decimal? m3VTAM = null, 
			string m3CUCD = null, 
			decimal? m3TLNA = null, 
			decimal? m3TASD = null, 
			decimal? m3TTXA = null, 
			decimal? m3TCHG = null, 
			decimal? m3TOPA = null, 
			decimal? m3PRPA = null, 
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
			string m3PYME = null, 
			string m3TEPY = null, 
			decimal? m3ARAT = null, 
			int? m3CRTP = null, 
			DateTime? m3PUDT = null, 
			string m3FECN = null, 
			int? m3SERS = null, 
			string m3VSER = null, 
			int? m3VONO = null, 
			DateTime? m3ACDT = null, 
			int? m3BIST = null, 
			string m3INST = null, 
			int? m3UPBI = null, 
			int? m3SUAC = null, 
			int? m3SBAD = null, 
			string m3PYAD = null, 
			string m3APCD = null, 
			string m3SDAP = null, 
			string m3DNRE = null, 
			string m3SDA1 = null, 
			string m3SDA2 = null, 
			string m3SDA3 = null, 
			string m3BSCD = null, 
			string m3FTCO = null, 
			string m3TDCD = null, 
			int? m3TXAP = null, 
			int? m3VDME = null, 
			string m3PUNO = null, 
			string m3APCT = null, 
			DateTime? m3DEDA = null, 
			string m3DNOI = null, 
			int? m3OYEA = null, 
			string m3PPYR = null, 
			string m3PPYN = null, 
			int? m3YEA4 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBatchHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SINO))
				throw new ArgumentNullException(nameof(m3SINO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SINO", m3SINO.Trim())
				.WithQueryParameter("IVDT", m3IVDT.ToM3String())
				.WithQueryParameter("CUAM", m3CUAM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPYN))
				request.WithQueryParameter("SPYN", m3SPYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3BITP))
				request.WithQueryParameter("BITP", m3BITP.Trim());
			if (!string.IsNullOrWhiteSpace(m3IMCD))
				request.WithQueryParameter("IMCD", m3IMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3EALS))
				request.WithQueryParameter("EALS", m3EALS.Trim());
			if (!string.IsNullOrWhiteSpace(m3VRNO))
				request.WithQueryParameter("VRNO", m3VRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EALP))
				request.WithQueryParameter("EALP", m3EALP.Trim());
			if (!string.IsNullOrWhiteSpace(m3EALR))
				request.WithQueryParameter("EALR", m3EALR.Trim());
			if (m3DUDT.HasValue)
				request.WithQueryParameter("DUDT", m3DUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3IVTP))
				request.WithQueryParameter("IVTP", m3IVTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3DNCO))
				request.WithQueryParameter("DNCO", m3DNCO.Trim());
			if (m3VTAM.HasValue)
				request.WithQueryParameter("VTAM", m3VTAM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3TLNA.HasValue)
				request.WithQueryParameter("TLNA", m3TLNA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TASD.HasValue)
				request.WithQueryParameter("TASD", m3TASD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TTXA.HasValue)
				request.WithQueryParameter("TTXA", m3TTXA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TCHG.HasValue)
				request.WithQueryParameter("TCHG", m3TCHG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOPA.HasValue)
				request.WithQueryParameter("TOPA", m3TOPA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRPA.HasValue)
				request.WithQueryParameter("PRPA", m3PRPA.Value.ToString(CultureInfo.CurrentCulture));
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
			if (!string.IsNullOrWhiteSpace(m3PYME))
				request.WithQueryParameter("PYME", m3PYME.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (m3ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3ARAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3CRTP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUDT.HasValue)
				request.WithQueryParameter("PUDT", m3PUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3FECN))
				request.WithQueryParameter("FECN", m3FECN.Trim());
			if (m3SERS.HasValue)
				request.WithQueryParameter("SERS", m3SERS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3VSER))
				request.WithQueryParameter("VSER", m3VSER.Trim());
			if (m3VONO.HasValue)
				request.WithQueryParameter("VONO", m3VONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACDT.HasValue)
				request.WithQueryParameter("ACDT", m3ACDT.Value.ToM3String());
			if (m3BIST.HasValue)
				request.WithQueryParameter("BIST", m3BIST.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INST))
				request.WithQueryParameter("INST", m3INST.Trim());
			if (m3UPBI.HasValue)
				request.WithQueryParameter("UPBI", m3UPBI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUAC.HasValue)
				request.WithQueryParameter("SUAC", m3SUAC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SBAD.HasValue)
				request.WithQueryParameter("SBAD", m3SBAD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PYAD))
				request.WithQueryParameter("PYAD", m3PYAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3APCD))
				request.WithQueryParameter("APCD", m3APCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDAP))
				request.WithQueryParameter("SDAP", m3SDAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3DNRE))
				request.WithQueryParameter("DNRE", m3DNRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDA1))
				request.WithQueryParameter("SDA1", m3SDA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDA2))
				request.WithQueryParameter("SDA2", m3SDA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDA3))
				request.WithQueryParameter("SDA3", m3SDA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3BSCD))
				request.WithQueryParameter("BSCD", m3BSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3FTCO))
				request.WithQueryParameter("FTCO", m3FTCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TDCD))
				request.WithQueryParameter("TDCD", m3TDCD.Trim());
			if (m3TXAP.HasValue)
				request.WithQueryParameter("TXAP", m3TXAP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VDME.HasValue)
				request.WithQueryParameter("VDME", m3VDME.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PUNO))
				request.WithQueryParameter("PUNO", m3PUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3APCT))
				request.WithQueryParameter("APCT", m3APCT.Trim());
			if (m3DEDA.HasValue)
				request.WithQueryParameter("DEDA", m3DEDA.Value.ToM3String());
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
		/// Name AddBatchLine
		/// Description Create new batch invoice line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3SPYN">Payee</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SINO">Supplier invoice number</param>
		/// <param name="m3RDTP">Line type</param>
		/// <param name="m3TRNO">Transaction number</param>
		/// <param name="m3BITP">Type of automatically generated invoice</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3CDSE">Sequence number - costing element</param>
		/// <param name="m3CEID">Purchase costing element</param>
		/// <param name="m3IVQA">Invoiced quantity - alternate U/M</param>
		/// <param name="m3PUUN">Purchase order U/M</param>
		/// <param name="m3NLAM">Net amount - line</param>
		/// <param name="m3GLAM">Gross amount - line</param>
		/// <param name="m3GRPR">Gross price</param>
		/// <param name="m3NEPR">Net price</param>
		/// <param name="m3PPUN">Purchase price U/M</param>
		/// <param name="m3PUCD">Purchase price quantity</param>
		/// <param name="m3IVCW">Invoiced catch weight</param>
		/// <param name="m3VTCD">VAT code</param>
		/// <param name="m3VTA1">VAT amount 1</param>
		/// <param name="m3VTA2">VAT amount 2</param>
		/// <param name="m3DIAM">Discount amount</param>
		/// <param name="m3DIPC">Discount</param>
		/// <param name="m3PUNO">Purchase order number</param>
		/// <param name="m3PNLI">Purchase order line</param>
		/// <param name="m3PNLS">Purchase order line subnumber</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3DNDT">Delivery note date</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3RELP">Receipt type</param>
		/// <param name="m3SBAN">Agreement number - self-billing</param>
		/// <param name="m3ILST">Error status</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3VTP1">VAT rate 1</param>
		/// <param name="m3VTP2">VAT rate 2</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBatchLine(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3SPYN = null, 
			string m3SUNO = null, 
			string m3SINO = null, 
			int? m3RDTP = null, 
			int? m3TRNO = null, 
			string m3BITP = null, 
			string m3ITNO = null, 
			int? m3CDSE = null, 
			string m3CEID = null, 
			decimal? m3IVQA = null, 
			string m3PUUN = null, 
			decimal? m3NLAM = null, 
			decimal? m3GLAM = null, 
			decimal? m3GRPR = null, 
			decimal? m3NEPR = null, 
			string m3PPUN = null, 
			int? m3PUCD = null, 
			decimal? m3IVCW = null, 
			int? m3VTCD = null, 
			decimal? m3VTA1 = null, 
			decimal? m3VTA2 = null, 
			decimal? m3DIAM = null, 
			int? m3DIPC = null, 
			string m3PUNO = null, 
			int? m3PNLI = null, 
			int? m3PNLS = null, 
			string m3SUDO = null, 
			DateTime? m3DNDT = null, 
			long? m3REPN = null, 
			int? m3RELP = null, 
			string m3SBAN = null, 
			string m3ILST = null, 
			string m3POPN = null, 
			int? m3VTP1 = null, 
			int? m3VTP2 = null, 
			string m3TX40 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBatchLine",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPYN))
				request.WithQueryParameter("SPYN", m3SPYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SINO))
				request.WithQueryParameter("SINO", m3SINO.Trim());
			if (m3RDTP.HasValue)
				request.WithQueryParameter("RDTP", m3RDTP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRNO.HasValue)
				request.WithQueryParameter("TRNO", m3TRNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BITP))
				request.WithQueryParameter("BITP", m3BITP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3CDSE.HasValue)
				request.WithQueryParameter("CDSE", m3CDSE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CEID))
				request.WithQueryParameter("CEID", m3CEID.Trim());
			if (m3IVQA.HasValue)
				request.WithQueryParameter("IVQA", m3IVQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PUUN))
				request.WithQueryParameter("PUUN", m3PUUN.Trim());
			if (m3NLAM.HasValue)
				request.WithQueryParameter("NLAM", m3NLAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GLAM.HasValue)
				request.WithQueryParameter("GLAM", m3GLAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRPR.HasValue)
				request.WithQueryParameter("GRPR", m3GRPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NEPR.HasValue)
				request.WithQueryParameter("NEPR", m3NEPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PPUN))
				request.WithQueryParameter("PPUN", m3PPUN.Trim());
			if (m3PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3PUCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IVCW.HasValue)
				request.WithQueryParameter("IVCW", m3IVCW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3VTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTA1.HasValue)
				request.WithQueryParameter("VTA1", m3VTA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTA2.HasValue)
				request.WithQueryParameter("VTA2", m3VTA2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIAM.HasValue)
				request.WithQueryParameter("DIAM", m3DIAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIPC.HasValue)
				request.WithQueryParameter("DIPC", m3DIPC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PUNO))
				request.WithQueryParameter("PUNO", m3PUNO.Trim());
			if (m3PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3PNLI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3PNLS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (m3DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3DNDT.Value.ToM3String());
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RELP.HasValue)
				request.WithQueryParameter("RELP", m3RELP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SBAN))
				request.WithQueryParameter("SBAN", m3SBAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ILST))
				request.WithQueryParameter("ILST", m3ILST.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (m3VTP1.HasValue)
				request.WithQueryParameter("VTP1", m3VTP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTP2.HasValue)
				request.WithQueryParameter("VTP2", m3VTP2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());

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
		/// Name GetAddInfo
		/// Description Get additional information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SPYN">Payee (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SINO">Supplier invoice number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3PEXN">AP information category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAddInfoResponse></returns>
		/// <exception cref="M3Exception<GetAddInfoResponse>"></exception>
		public async Task<M3Response<GetAddInfoResponse>> GetAddInfo(
			string m3SPYN, 
			string m3SUNO, 
			string m3SINO, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			int? m3PEXN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAddInfo",
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3PEXN.HasValue)
				request.WithQueryParameter("PEXN", m3PEXN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetAddInfoResponse>(
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
		/// Name GetBatchHead
		/// Description Get Batch Head information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3SPYN">Payee (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SINO">Supplier invoice number (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBatchHeadResponse></returns>
		/// <exception cref="M3Exception<GetBatchHeadResponse>"></exception>
		public async Task<M3Response<GetBatchHeadResponse>> GetBatchHead(
			string m3DIVI, 
			string m3SPYN, 
			string m3SUNO, 
			string m3SINO, 
			string m3CUCD, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBatchHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3SPYN))
				throw new ArgumentNullException(nameof(m3SPYN));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SINO))
				throw new ArgumentNullException(nameof(m3SINO));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("SPYN", m3SPYN.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SINO", m3SINO.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetBatchHeadResponse>(
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
		/// Name GetBatchHeadPre
		/// Description Get Batch Head information Prepayment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3SPYN">Payee (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SINO">Supplier invoice number (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBatchHeadPreResponse></returns>
		/// <exception cref="M3Exception<GetBatchHeadPreResponse>"></exception>
		public async Task<M3Response<GetBatchHeadPreResponse>> GetBatchHeadPre(
			string m3DIVI, 
			string m3SPYN, 
			string m3SUNO, 
			string m3SINO, 
			string m3CUCD, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBatchHeadPre",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3SPYN))
				throw new ArgumentNullException(nameof(m3SPYN));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SINO))
				throw new ArgumentNullException(nameof(m3SINO));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("SPYN", m3SPYN.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SINO", m3SINO.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetBatchHeadPreResponse>(
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
		/// Name GetBatchLine
		/// Description Get Batch Line information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3SPYN">Payee (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SINO">Supplier invoice number (Required)</param>
		/// <param name="m3TRNO">Transaction number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBatchLineResponse></returns>
		/// <exception cref="M3Exception<GetBatchLineResponse>"></exception>
		public async Task<M3Response<GetBatchLineResponse>> GetBatchLine(
			string m3DIVI, 
			string m3SPYN, 
			string m3SUNO, 
			string m3SINO, 
			int m3TRNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBatchLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3SPYN))
				throw new ArgumentNullException(nameof(m3SPYN));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SINO))
				throw new ArgumentNullException(nameof(m3SINO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("SPYN", m3SPYN.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SINO", m3SINO.Trim())
				.WithQueryParameter("TRNO", m3TRNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetBatchLineResponse>(
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
		/// Name GetCorrectiveIn
		/// Description Get corrective invoice
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3SPYN">Payee</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3SINO">Supplier invoice number</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCorrectiveInResponse></returns>
		/// <exception cref="M3Exception<GetCorrectiveInResponse>"></exception>
		public async Task<M3Response<GetCorrectiveInResponse>> GetCorrectiveIn(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3SPYN = null, 
			string m3SUNO = null, 
			string m3SINO = null, 
			string m3CUCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetCorrectiveIn",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPYN))
				request.WithQueryParameter("SPYN", m3SPYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SINO))
				request.WithQueryParameter("SINO", m3SINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());

			// Execute the request
			var result = await Execute<GetCorrectiveInResponse>(
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
		/// Name LstBatchAddInfo
		/// Description List Batch invoice additional number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3SPYN">Payee</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SINO">Supplier invoice number</param>
		/// <param name="m3PEXN">AP information category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBatchAddInfoResponse></returns>
		/// <exception cref="M3Exception<LstBatchAddInfoResponse>"></exception>
		public async Task<M3Response<LstBatchAddInfoResponse>> LstBatchAddInfo(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3SPYN = null, 
			string m3SUNO = null, 
			string m3SINO = null, 
			int? m3PEXN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBatchAddInfo",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPYN))
				request.WithQueryParameter("SPYN", m3SPYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SINO))
				request.WithQueryParameter("SINO", m3SINO.Trim());
			if (m3PEXN.HasValue)
				request.WithQueryParameter("PEXN", m3PEXN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstBatchAddInfoResponse>(
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
		/// Name LstHeadByPayer
		/// Description List Batch head by payer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3SPYN">Payee (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3BITP">Type of automatically generated invoice</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadByPayerResponse></returns>
		/// <exception cref="M3Exception<LstHeadByPayerResponse>"></exception>
		public async Task<M3Response<LstHeadByPayerResponse>> LstHeadByPayer(
			string m3DIVI, 
			string m3SPYN, 
			int? m3CONO = null, 
			string m3SUNO = null, 
			string m3BITP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstHeadByPayer",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3SPYN))
				throw new ArgumentNullException(nameof(m3SPYN));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("SPYN", m3SPYN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BITP))
				request.WithQueryParameter("BITP", m3BITP.Trim());

			// Execute the request
			var result = await Execute<LstHeadByPayerResponse>(
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
		/// Name LstHeadByPayerP
		/// Description List Batch head by payer - Prepayment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3SPYN">Payee (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3BITP">Type of automatically generated invoice</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadByPayerPResponse></returns>
		/// <exception cref="M3Exception<LstHeadByPayerPResponse>"></exception>
		public async Task<M3Response<LstHeadByPayerPResponse>> LstHeadByPayerP(
			string m3DIVI, 
			string m3SPYN, 
			int? m3CONO = null, 
			string m3SUNO = null, 
			string m3BITP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstHeadByPayerP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3SPYN))
				throw new ArgumentNullException(nameof(m3SPYN));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("SPYN", m3SPYN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BITP))
				request.WithQueryParameter("BITP", m3BITP.Trim());

			// Execute the request
			var result = await Execute<LstHeadByPayerPResponse>(
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
		/// Name LstLineByNumber
		/// Description List Batch lines by transaction number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3SPYN">Payee (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SINO">Supplier invoice number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TRNO">Transaction number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineByNumberResponse></returns>
		/// <exception cref="M3Exception<LstLineByNumberResponse>"></exception>
		public async Task<M3Response<LstLineByNumberResponse>> LstLineByNumber(
			string m3DIVI, 
			string m3SPYN, 
			string m3SUNO, 
			string m3SINO, 
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLineByNumber",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3SPYN))
				throw new ArgumentNullException(nameof(m3SPYN));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SINO))
				throw new ArgumentNullException(nameof(m3SINO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("SPYN", m3SPYN.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SINO", m3SINO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRNO.HasValue)
				request.WithQueryParameter("TRNO", m3TRNO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstLineByNumberResponse>(
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
		/// Name LstLineByRcvnr
		/// Description List Batch lines by delivery note number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3SPYN">Payee (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SINO">Supplier invoice number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineByRcvnrResponse></returns>
		/// <exception cref="M3Exception<LstLineByRcvnrResponse>"></exception>
		public async Task<M3Response<LstLineByRcvnrResponse>> LstLineByRcvnr(
			string m3DIVI, 
			string m3SPYN, 
			string m3SUNO, 
			string m3SINO, 
			int? m3CONO = null, 
			string m3SUDO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLineByRcvnr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3SPYN))
				throw new ArgumentNullException(nameof(m3SPYN));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SINO))
				throw new ArgumentNullException(nameof(m3SINO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("SPYN", m3SPYN.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SINO", m3SINO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());

			// Execute the request
			var result = await Execute<LstLineByRcvnrResponse>(
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
		/// Name RejectInv
		/// Description Reject Self-billing invoice
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3SPYN">Payee (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SINO">Supplier invoice number (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PUDT">Order date</param>
		/// <param name="m3SDA1">Text line 1</param>
		/// <param name="m3SDA2">Text line 2</param>
		/// <param name="m3SDA3">Text line 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RejectInv(
			string m3DIVI, 
			string m3SPYN, 
			string m3SUNO, 
			string m3SINO, 
			string m3CUCD, 
			int? m3CONO = null, 
			DateTime? m3PUDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RejectInv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3SPYN))
				throw new ArgumentNullException(nameof(m3SPYN));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SINO))
				throw new ArgumentNullException(nameof(m3SINO));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("SPYN", m3SPYN.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SINO", m3SINO.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUDT.HasValue)
				request.WithQueryParameter("PUDT", m3PUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3SDA1))
				request.WithQueryParameter("SDA1", m3SDA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDA2))
				request.WithQueryParameter("SDA2", m3SDA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDA3))
				request.WithQueryParameter("SDA3", m3SDA3.Trim());

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
