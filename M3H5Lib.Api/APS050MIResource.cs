/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_SPYN">Payee (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SINO">Supplier invoice number (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PUDT">Order date</param>
		/// <param name="m3_SDA1">Text line 1</param>
		/// <param name="m3_SDA2">Text line 2</param>
		/// <param name="m3_SDA3">Text line 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AcceptInv(
			string m3_DIVI, 
			string m3_SPYN, 
			string m3_SUNO, 
			string m3_SINO, 
			string m3_CUCD, 
			int? m3_CONO = null, 
			DateTime? m3_PUDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AcceptInv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_SPYN))
				throw new ArgumentNullException("m3_SPYN");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SINO))
				throw new ArgumentNullException("m3_SINO");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("SPYN", m3_SPYN.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SINO", m3_SINO.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PUDT.HasValue)
				request.WithQueryParameter("PUDT", m3_PUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_SDA1))
				request.WithQueryParameter("SDA1", m3_SDA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDA2))
				request.WithQueryParameter("SDA2", m3_SDA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDA3))
				request.WithQueryParameter("SDA3", m3_SDA3.Trim());

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
		/// Name AddBatchAddInfo
		/// Description Create new batch invoice additional information reference
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SINO">Supplier invoice number (Required)</param>
		/// <param name="m3_PEXN">AP information category (Required)</param>
		/// <param name="m3_PEXI">AP additional information (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SPYN">Payee</param>
		/// <param name="m3_PEXS">AP information sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBatchAddInfo(
			string m3_DIVI, 
			string m3_SUNO, 
			string m3_SINO, 
			int m3_PEXN, 
			string m3_PEXI, 
			int? m3_CONO = null, 
			string m3_SPYN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBatchAddInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SINO))
				throw new ArgumentNullException("m3_SINO");
			if (string.IsNullOrWhiteSpace(m3_PEXI))
				throw new ArgumentNullException("m3_PEXI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SINO", m3_SINO.Trim())
				.WithQueryParameter("PEXN", m3_PEXN.ToString())
				.WithQueryParameter("PEXI", m3_PEXI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPYN))
				request.WithQueryParameter("SPYN", m3_SPYN.Trim());
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
		/// Name AddBatchHead
		/// Description Create new batch invoice head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SINO">Supplier invoice number (Required)</param>
		/// <param name="m3_IVDT">Invoice date (Required)</param>
		/// <param name="m3_CUAM">Foreign currency amount (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SPYN">Payee</param>
		/// <param name="m3_BITP">Type of automatically generated invoice</param>
		/// <param name="m3_IMCD">Invoice matching</param>
		/// <param name="m3_EALS">EAN location code supplier</param>
		/// <param name="m3_VRNO">VAT registration number</param>
		/// <param name="m3_EALP">EAN location code payee</param>
		/// <param name="m3_EALR">EAN location code consignee</param>
		/// <param name="m3_DUDT">Due date</param>
		/// <param name="m3_IVTP">Information type</param>
		/// <param name="m3_DNCO">Document code</param>
		/// <param name="m3_VTAM">VAT</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_TLNA">Total line amount - net</param>
		/// <param name="m3_TASD">Discount base amount</param>
		/// <param name="m3_TTXA">Total taxable amount</param>
		/// <param name="m3_TCHG">Total charges</param>
		/// <param name="m3_TOPA">Total due</param>
		/// <param name="m3_PRPA">Prepaid amount</param>
		/// <param name="m3_TECD">Cash discount term</param>
		/// <param name="m3_CDT1">Cash discount date 1</param>
		/// <param name="m3_CDP1">Cash discount percentage</param>
		/// <param name="m3_CDC1">Cash discount amount 1</param>
		/// <param name="m3_CDT2">Cash discount date 2</param>
		/// <param name="m3_CDP2">Cash discount percentage 2</param>
		/// <param name="m3_CDC2">Cash discount amount 2</param>
		/// <param name="m3_CDT3">Cash discount date 3</param>
		/// <param name="m3_CDP3">Cash discount percentage 3</param>
		/// <param name="m3_CDC3">Cash discount amount 3</param>
		/// <param name="m3_PYME">Payment method - accounts payable</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_ARAT">Exchange rate</param>
		/// <param name="m3_CRTP">Exchange rate type</param>
		/// <param name="m3_PUDT">Order date</param>
		/// <param name="m3_FECN">Future rate agreement number</param>
		/// <param name="m3_SERS">Service code</param>
		/// <param name="m3_VSER">Voucher number series</param>
		/// <param name="m3_VONO">Voucher number</param>
		/// <param name="m3_ACDT">Accounting date</param>
		/// <param name="m3_BIST">Status - batch invoice</param>
		/// <param name="m3_INST">Status - invoice</param>
		/// <param name="m3_UPBI">Invoice per receiving number</param>
		/// <param name="m3_SUAC">Supplier acceptance</param>
		/// <param name="m3_SBAD">Conditions for adding lines</param>
		/// <param name="m3_PYAD">Our invoicing address</param>
		/// <param name="m3_APCD">Authorized</param>
		/// <param name="m3_SDAP">AP standard document</param>
		/// <param name="m3_DNRE">Debit note reason</param>
		/// <param name="m3_SDA1">Text line 1</param>
		/// <param name="m3_SDA2">Text line 2</param>
		/// <param name="m3_SDA3">Text line 3</param>
		/// <param name="m3_BSCD">Base country code</param>
		/// <param name="m3_FTCO">From/To country</param>
		/// <param name="m3_TDCD">Trade code</param>
		/// <param name="m3_TXAP">Tax applicable</param>
		/// <param name="m3_VDME">VAT summation method</param>
		/// <param name="m3_PUNO">Purchase order number</param>
		/// <param name="m3_APCT">Authorized description</param>
		/// <param name="m3_DEDA">Delivery date</param>
		/// <param name="m3_DNOI">Original invoice number</param>
		/// <param name="m3_OYEA">Original year</param>
		/// <param name="m3_PPYR">Reference number</param>
		/// <param name="m3_PPYN">Payment request  number</param>
		/// <param name="m3_YEA4">Year</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBatchHead(
			string m3_DIVI, 
			string m3_SUNO, 
			string m3_SINO, 
			DateTime m3_IVDT, 
			decimal m3_CUAM, 
			int? m3_CONO = null, 
			string m3_SPYN = null, 
			string m3_BITP = null, 
			string m3_IMCD = null, 
			string m3_EALS = null, 
			string m3_VRNO = null, 
			string m3_EALP = null, 
			string m3_EALR = null, 
			DateTime? m3_DUDT = null, 
			string m3_IVTP = null, 
			string m3_DNCO = null, 
			decimal? m3_VTAM = null, 
			string m3_CUCD = null, 
			decimal? m3_TLNA = null, 
			decimal? m3_TASD = null, 
			decimal? m3_TTXA = null, 
			decimal? m3_TCHG = null, 
			decimal? m3_TOPA = null, 
			decimal? m3_PRPA = null, 
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
			string m3_PYME = null, 
			string m3_TEPY = null, 
			decimal? m3_ARAT = null, 
			int? m3_CRTP = null, 
			DateTime? m3_PUDT = null, 
			string m3_FECN = null, 
			int? m3_SERS = null, 
			string m3_VSER = null, 
			int? m3_VONO = null, 
			DateTime? m3_ACDT = null, 
			int? m3_BIST = null, 
			string m3_INST = null, 
			int? m3_UPBI = null, 
			int? m3_SUAC = null, 
			int? m3_SBAD = null, 
			string m3_PYAD = null, 
			string m3_APCD = null, 
			string m3_SDAP = null, 
			string m3_DNRE = null, 
			string m3_SDA1 = null, 
			string m3_SDA2 = null, 
			string m3_SDA3 = null, 
			string m3_BSCD = null, 
			string m3_FTCO = null, 
			string m3_TDCD = null, 
			int? m3_TXAP = null, 
			int? m3_VDME = null, 
			string m3_PUNO = null, 
			string m3_APCT = null, 
			DateTime? m3_DEDA = null, 
			string m3_DNOI = null, 
			int? m3_OYEA = null, 
			string m3_PPYR = null, 
			string m3_PPYN = null, 
			int? m3_YEA4 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SINO))
				throw new ArgumentNullException("m3_SINO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SINO", m3_SINO.Trim())
				.WithQueryParameter("IVDT", m3_IVDT.ToM3String())
				.WithQueryParameter("CUAM", m3_CUAM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPYN))
				request.WithQueryParameter("SPYN", m3_SPYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BITP))
				request.WithQueryParameter("BITP", m3_BITP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IMCD))
				request.WithQueryParameter("IMCD", m3_IMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EALS))
				request.WithQueryParameter("EALS", m3_EALS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VRNO))
				request.WithQueryParameter("VRNO", m3_VRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EALP))
				request.WithQueryParameter("EALP", m3_EALP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EALR))
				request.WithQueryParameter("EALR", m3_EALR.Trim());
			if (m3_DUDT.HasValue)
				request.WithQueryParameter("DUDT", m3_DUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_IVTP))
				request.WithQueryParameter("IVTP", m3_IVTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DNCO))
				request.WithQueryParameter("DNCO", m3_DNCO.Trim());
			if (m3_VTAM.HasValue)
				request.WithQueryParameter("VTAM", m3_VTAM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_TLNA.HasValue)
				request.WithQueryParameter("TLNA", m3_TLNA.Value.ToString());
			if (m3_TASD.HasValue)
				request.WithQueryParameter("TASD", m3_TASD.Value.ToString());
			if (m3_TTXA.HasValue)
				request.WithQueryParameter("TTXA", m3_TTXA.Value.ToString());
			if (m3_TCHG.HasValue)
				request.WithQueryParameter("TCHG", m3_TCHG.Value.ToString());
			if (m3_TOPA.HasValue)
				request.WithQueryParameter("TOPA", m3_TOPA.Value.ToString());
			if (m3_PRPA.HasValue)
				request.WithQueryParameter("PRPA", m3_PRPA.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_PYME))
				request.WithQueryParameter("PYME", m3_PYME.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (m3_ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3_ARAT.Value.ToString());
			if (m3_CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3_CRTP.Value.ToString());
			if (m3_PUDT.HasValue)
				request.WithQueryParameter("PUDT", m3_PUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_FECN))
				request.WithQueryParameter("FECN", m3_FECN.Trim());
			if (m3_SERS.HasValue)
				request.WithQueryParameter("SERS", m3_SERS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_VSER))
				request.WithQueryParameter("VSER", m3_VSER.Trim());
			if (m3_VONO.HasValue)
				request.WithQueryParameter("VONO", m3_VONO.Value.ToString());
			if (m3_ACDT.HasValue)
				request.WithQueryParameter("ACDT", m3_ACDT.Value.ToM3String());
			if (m3_BIST.HasValue)
				request.WithQueryParameter("BIST", m3_BIST.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INST))
				request.WithQueryParameter("INST", m3_INST.Trim());
			if (m3_UPBI.HasValue)
				request.WithQueryParameter("UPBI", m3_UPBI.Value.ToString());
			if (m3_SUAC.HasValue)
				request.WithQueryParameter("SUAC", m3_SUAC.Value.ToString());
			if (m3_SBAD.HasValue)
				request.WithQueryParameter("SBAD", m3_SBAD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PYAD))
				request.WithQueryParameter("PYAD", m3_PYAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APCD))
				request.WithQueryParameter("APCD", m3_APCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDAP))
				request.WithQueryParameter("SDAP", m3_SDAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DNRE))
				request.WithQueryParameter("DNRE", m3_DNRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDA1))
				request.WithQueryParameter("SDA1", m3_SDA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDA2))
				request.WithQueryParameter("SDA2", m3_SDA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDA3))
				request.WithQueryParameter("SDA3", m3_SDA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BSCD))
				request.WithQueryParameter("BSCD", m3_BSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FTCO))
				request.WithQueryParameter("FTCO", m3_FTCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TDCD))
				request.WithQueryParameter("TDCD", m3_TDCD.Trim());
			if (m3_TXAP.HasValue)
				request.WithQueryParameter("TXAP", m3_TXAP.Value.ToString());
			if (m3_VDME.HasValue)
				request.WithQueryParameter("VDME", m3_VDME.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PUNO))
				request.WithQueryParameter("PUNO", m3_PUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APCT))
				request.WithQueryParameter("APCT", m3_APCT.Trim());
			if (m3_DEDA.HasValue)
				request.WithQueryParameter("DEDA", m3_DEDA.Value.ToM3String());
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
		/// Name AddBatchLine
		/// Description Create new batch invoice line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_SPYN">Payee</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_SINO">Supplier invoice number</param>
		/// <param name="m3_RDTP">Line type</param>
		/// <param name="m3_TRNO">Transaction number</param>
		/// <param name="m3_BITP">Type of automatically generated invoice</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_CDSE">Sequence number - costing element</param>
		/// <param name="m3_CEID">Purchase costing element</param>
		/// <param name="m3_IVQA">Invoiced quantity - alternate U/M</param>
		/// <param name="m3_PUUN">Purchase order U/M</param>
		/// <param name="m3_NLAM">Net amount - line</param>
		/// <param name="m3_GLAM">Gross amount - line</param>
		/// <param name="m3_GRPR">Gross price</param>
		/// <param name="m3_NEPR">Net price</param>
		/// <param name="m3_PPUN">Purchase price U/M</param>
		/// <param name="m3_PUCD">Purchase price quantity</param>
		/// <param name="m3_IVCW">Invoiced catch weight</param>
		/// <param name="m3_VTCD">VAT code</param>
		/// <param name="m3_VTA1">VAT amount 1</param>
		/// <param name="m3_VTA2">VAT amount 2</param>
		/// <param name="m3_DIAM">Discount amount</param>
		/// <param name="m3_DIPC">Discount</param>
		/// <param name="m3_PUNO">Purchase order number</param>
		/// <param name="m3_PNLI">Purchase order line</param>
		/// <param name="m3_PNLS">Purchase order line subnumber</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_DNDT">Delivery note date</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_RELP">Receipt type</param>
		/// <param name="m3_SBAN">Agreement number - self-billing</param>
		/// <param name="m3_ILST">Error status</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_VTP1">VAT rate 1</param>
		/// <param name="m3_VTP2">VAT rate 2</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBatchLine(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_SPYN = null, 
			string m3_SUNO = null, 
			string m3_SINO = null, 
			int? m3_RDTP = null, 
			int? m3_TRNO = null, 
			string m3_BITP = null, 
			string m3_ITNO = null, 
			int? m3_CDSE = null, 
			string m3_CEID = null, 
			decimal? m3_IVQA = null, 
			string m3_PUUN = null, 
			decimal? m3_NLAM = null, 
			decimal? m3_GLAM = null, 
			decimal? m3_GRPR = null, 
			decimal? m3_NEPR = null, 
			string m3_PPUN = null, 
			int? m3_PUCD = null, 
			decimal? m3_IVCW = null, 
			int? m3_VTCD = null, 
			decimal? m3_VTA1 = null, 
			decimal? m3_VTA2 = null, 
			decimal? m3_DIAM = null, 
			int? m3_DIPC = null, 
			string m3_PUNO = null, 
			int? m3_PNLI = null, 
			int? m3_PNLS = null, 
			string m3_SUDO = null, 
			DateTime? m3_DNDT = null, 
			long? m3_REPN = null, 
			int? m3_RELP = null, 
			string m3_SBAN = null, 
			string m3_ILST = null, 
			string m3_POPN = null, 
			int? m3_VTP1 = null, 
			int? m3_VTP2 = null, 
			string m3_TX40 = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPYN))
				request.WithQueryParameter("SPYN", m3_SPYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SINO))
				request.WithQueryParameter("SINO", m3_SINO.Trim());
			if (m3_RDTP.HasValue)
				request.WithQueryParameter("RDTP", m3_RDTP.Value.ToString());
			if (m3_TRNO.HasValue)
				request.WithQueryParameter("TRNO", m3_TRNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BITP))
				request.WithQueryParameter("BITP", m3_BITP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_CDSE.HasValue)
				request.WithQueryParameter("CDSE", m3_CDSE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CEID))
				request.WithQueryParameter("CEID", m3_CEID.Trim());
			if (m3_IVQA.HasValue)
				request.WithQueryParameter("IVQA", m3_IVQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PUUN))
				request.WithQueryParameter("PUUN", m3_PUUN.Trim());
			if (m3_NLAM.HasValue)
				request.WithQueryParameter("NLAM", m3_NLAM.Value.ToString());
			if (m3_GLAM.HasValue)
				request.WithQueryParameter("GLAM", m3_GLAM.Value.ToString());
			if (m3_GRPR.HasValue)
				request.WithQueryParameter("GRPR", m3_GRPR.Value.ToString());
			if (m3_NEPR.HasValue)
				request.WithQueryParameter("NEPR", m3_NEPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PPUN))
				request.WithQueryParameter("PPUN", m3_PPUN.Trim());
			if (m3_PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3_PUCD.Value.ToString());
			if (m3_IVCW.HasValue)
				request.WithQueryParameter("IVCW", m3_IVCW.Value.ToString());
			if (m3_VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3_VTCD.Value.ToString());
			if (m3_VTA1.HasValue)
				request.WithQueryParameter("VTA1", m3_VTA1.Value.ToString());
			if (m3_VTA2.HasValue)
				request.WithQueryParameter("VTA2", m3_VTA2.Value.ToString());
			if (m3_DIAM.HasValue)
				request.WithQueryParameter("DIAM", m3_DIAM.Value.ToString());
			if (m3_DIPC.HasValue)
				request.WithQueryParameter("DIPC", m3_DIPC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PUNO))
				request.WithQueryParameter("PUNO", m3_PUNO.Trim());
			if (m3_PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3_PNLI.Value.ToString());
			if (m3_PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3_PNLS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (m3_DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3_DNDT.Value.ToM3String());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (m3_RELP.HasValue)
				request.WithQueryParameter("RELP", m3_RELP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SBAN))
				request.WithQueryParameter("SBAN", m3_SBAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ILST))
				request.WithQueryParameter("ILST", m3_ILST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (m3_VTP1.HasValue)
				request.WithQueryParameter("VTP1", m3_VTP1.Value.ToString());
			if (m3_VTP2.HasValue)
				request.WithQueryParameter("VTP2", m3_VTP2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());

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
		/// Name GetAddInfo
		/// Description Get additional information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SPYN">Payee (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SINO">Supplier invoice number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_PEXN">AP information category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAddInfoResponse></returns>
		/// <exception cref="M3Exception<GetAddInfoResponse>"></exception>
		public async Task<M3Response<GetAddInfoResponse>> GetAddInfo(
			string m3_SPYN, 
			string m3_SUNO, 
			string m3_SINO, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			int? m3_PEXN = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_PEXN.HasValue)
				request.WithQueryParameter("PEXN", m3_PEXN.Value.ToString());

			// Execute the request
			var result = await Execute<GetAddInfoResponse>(
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
		/// Name GetBatchHead
		/// Description Get Batch Head information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_SPYN">Payee (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SINO">Supplier invoice number (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBatchHeadResponse></returns>
		/// <exception cref="M3Exception<GetBatchHeadResponse>"></exception>
		public async Task<M3Response<GetBatchHeadResponse>> GetBatchHead(
			string m3_DIVI, 
			string m3_SPYN, 
			string m3_SUNO, 
			string m3_SINO, 
			string m3_CUCD, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBatchHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_SPYN))
				throw new ArgumentNullException("m3_SPYN");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SINO))
				throw new ArgumentNullException("m3_SINO");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("SPYN", m3_SPYN.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SINO", m3_SINO.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetBatchHeadResponse>(
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
		/// Name GetBatchHeadPre
		/// Description Get Batch Head information Prepayment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_SPYN">Payee (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SINO">Supplier invoice number (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBatchHeadPreResponse></returns>
		/// <exception cref="M3Exception<GetBatchHeadPreResponse>"></exception>
		public async Task<M3Response<GetBatchHeadPreResponse>> GetBatchHeadPre(
			string m3_DIVI, 
			string m3_SPYN, 
			string m3_SUNO, 
			string m3_SINO, 
			string m3_CUCD, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBatchHeadPre",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_SPYN))
				throw new ArgumentNullException("m3_SPYN");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SINO))
				throw new ArgumentNullException("m3_SINO");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("SPYN", m3_SPYN.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SINO", m3_SINO.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetBatchHeadPreResponse>(
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
		/// Name GetBatchLine
		/// Description Get Batch Line information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_SPYN">Payee (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SINO">Supplier invoice number (Required)</param>
		/// <param name="m3_TRNO">Transaction number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBatchLineResponse></returns>
		/// <exception cref="M3Exception<GetBatchLineResponse>"></exception>
		public async Task<M3Response<GetBatchLineResponse>> GetBatchLine(
			string m3_DIVI, 
			string m3_SPYN, 
			string m3_SUNO, 
			string m3_SINO, 
			int m3_TRNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBatchLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_SPYN))
				throw new ArgumentNullException("m3_SPYN");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SINO))
				throw new ArgumentNullException("m3_SINO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("SPYN", m3_SPYN.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SINO", m3_SINO.Trim())
				.WithQueryParameter("TRNO", m3_TRNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetBatchLineResponse>(
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
		/// Name GetCorrectiveIn
		/// Description Get corrective invoice
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_SPYN">Payee</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_SINO">Supplier invoice number</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCorrectiveInResponse></returns>
		/// <exception cref="M3Exception<GetCorrectiveInResponse>"></exception>
		public async Task<M3Response<GetCorrectiveInResponse>> GetCorrectiveIn(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_SPYN = null, 
			string m3_SUNO = null, 
			string m3_SINO = null, 
			string m3_CUCD = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPYN))
				request.WithQueryParameter("SPYN", m3_SPYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SINO))
				request.WithQueryParameter("SINO", m3_SINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());

			// Execute the request
			var result = await Execute<GetCorrectiveInResponse>(
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
		/// Name LstBatchAddInfo
		/// Description List Batch invoice additional number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_SPYN">Payee</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_SINO">Supplier invoice number</param>
		/// <param name="m3_PEXN">AP information category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBatchAddInfoResponse></returns>
		/// <exception cref="M3Exception<LstBatchAddInfoResponse>"></exception>
		public async Task<M3Response<LstBatchAddInfoResponse>> LstBatchAddInfo(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_SPYN = null, 
			string m3_SUNO = null, 
			string m3_SINO = null, 
			int? m3_PEXN = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPYN))
				request.WithQueryParameter("SPYN", m3_SPYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SINO))
				request.WithQueryParameter("SINO", m3_SINO.Trim());
			if (m3_PEXN.HasValue)
				request.WithQueryParameter("PEXN", m3_PEXN.Value.ToString());

			// Execute the request
			var result = await Execute<LstBatchAddInfoResponse>(
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
		/// Name LstHeadByPayer
		/// Description List Batch head by payer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_SPYN">Payee (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_BITP">Type of automatically generated invoice</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadByPayerResponse></returns>
		/// <exception cref="M3Exception<LstHeadByPayerResponse>"></exception>
		public async Task<M3Response<LstHeadByPayerResponse>> LstHeadByPayer(
			string m3_DIVI, 
			string m3_SPYN, 
			int? m3_CONO = null, 
			string m3_SUNO = null, 
			string m3_BITP = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_SPYN))
				throw new ArgumentNullException("m3_SPYN");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("SPYN", m3_SPYN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BITP))
				request.WithQueryParameter("BITP", m3_BITP.Trim());

			// Execute the request
			var result = await Execute<LstHeadByPayerResponse>(
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
		/// Name LstHeadByPayerP
		/// Description List Batch head by payer - Prepayment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_SPYN">Payee (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_BITP">Type of automatically generated invoice</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadByPayerPResponse></returns>
		/// <exception cref="M3Exception<LstHeadByPayerPResponse>"></exception>
		public async Task<M3Response<LstHeadByPayerPResponse>> LstHeadByPayerP(
			string m3_DIVI, 
			string m3_SPYN, 
			int? m3_CONO = null, 
			string m3_SUNO = null, 
			string m3_BITP = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_SPYN))
				throw new ArgumentNullException("m3_SPYN");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("SPYN", m3_SPYN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BITP))
				request.WithQueryParameter("BITP", m3_BITP.Trim());

			// Execute the request
			var result = await Execute<LstHeadByPayerPResponse>(
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
		/// Name LstLineByNumber
		/// Description List Batch lines by transaction number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_SPYN">Payee (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SINO">Supplier invoice number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TRNO">Transaction number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineByNumberResponse></returns>
		/// <exception cref="M3Exception<LstLineByNumberResponse>"></exception>
		public async Task<M3Response<LstLineByNumberResponse>> LstLineByNumber(
			string m3_DIVI, 
			string m3_SPYN, 
			string m3_SUNO, 
			string m3_SINO, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLineByNumber",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_SPYN))
				throw new ArgumentNullException("m3_SPYN");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SINO))
				throw new ArgumentNullException("m3_SINO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("SPYN", m3_SPYN.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SINO", m3_SINO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_TRNO.HasValue)
				request.WithQueryParameter("TRNO", m3_TRNO.Value.ToString());

			// Execute the request
			var result = await Execute<LstLineByNumberResponse>(
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
		/// Name LstLineByRcvnr
		/// Description List Batch lines by delivery note number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_SPYN">Payee (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SINO">Supplier invoice number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineByRcvnrResponse></returns>
		/// <exception cref="M3Exception<LstLineByRcvnrResponse>"></exception>
		public async Task<M3Response<LstLineByRcvnrResponse>> LstLineByRcvnr(
			string m3_DIVI, 
			string m3_SPYN, 
			string m3_SUNO, 
			string m3_SINO, 
			int? m3_CONO = null, 
			string m3_SUDO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_SPYN))
				throw new ArgumentNullException("m3_SPYN");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SINO))
				throw new ArgumentNullException("m3_SINO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("SPYN", m3_SPYN.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SINO", m3_SINO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());

			// Execute the request
			var result = await Execute<LstLineByRcvnrResponse>(
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
		/// Name RejectInv
		/// Description Reject Self-billing invoice
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_SPYN">Payee (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SINO">Supplier invoice number (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PUDT">Order date</param>
		/// <param name="m3_SDA1">Text line 1</param>
		/// <param name="m3_SDA2">Text line 2</param>
		/// <param name="m3_SDA3">Text line 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RejectInv(
			string m3_DIVI, 
			string m3_SPYN, 
			string m3_SUNO, 
			string m3_SINO, 
			string m3_CUCD, 
			int? m3_CONO = null, 
			DateTime? m3_PUDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RejectInv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_SPYN))
				throw new ArgumentNullException("m3_SPYN");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SINO))
				throw new ArgumentNullException("m3_SINO");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("SPYN", m3_SPYN.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SINO", m3_SINO.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PUDT.HasValue)
				request.WithQueryParameter("PUDT", m3_PUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_SDA1))
				request.WithQueryParameter("SDA1", m3_SDA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDA2))
				request.WithQueryParameter("SDA2", m3_SDA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDA3))
				request.WithQueryParameter("SDA3", m3_SDA3.Trim());

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
