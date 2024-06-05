/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.COS410MI;
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
	/// Name: COS410MI
	/// Component Name: Maintenance Agreement
	/// Description: Maint Agreement Interface
	/// Version Release: 5ea1
	///</summary>
	public partial class COS410MIResource : M3BaseResourceEndpoint
	{
		public COS410MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "COS410MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAgrCharges
		/// Description Add agreement - charges
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3AAGN">Agreement (Required)</param>
		/// <param name="m3CRID">Charge (Required)</param>
		/// <param name="m3CRAM">Charge</param>
		/// <param name="m3VTCD">VAT code</param>
		/// <param name="m3HACD">Debit frequency</param>
		/// <param name="m3CRD0">Description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAgrCharges(
			string m3AAGN, 
			string m3CRID, 
			decimal? m3CRAM = null, 
			int? m3VTCD = null, 
			int? m3HACD = null, 
			string m3CRD0 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAgrCharges",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));
			if (string.IsNullOrWhiteSpace(m3CRID))
				throw new ArgumentNullException(nameof(m3CRID));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim())
				.WithQueryParameter("CRID", m3CRID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CRAM.HasValue)
				request.WithQueryParameter("CRAM", m3CRAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3VTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HACD.HasValue)
				request.WithQueryParameter("HACD", m3HACD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CRD0))
				request.WithQueryParameter("CRD0", m3CRD0.Trim());

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
		/// Name AddAgrLines
		/// Description Add agreement - lines
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3AAGN">Agreement (Required)</param>
		/// <param name="m3SRVP">Service price method</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="m3PRTX">Text</param>
		/// <param name="m3LEAS">Lead time - service</param>
		/// <param name="m3MES0">Meter</param>
		/// <param name="m3WAL1">Warranty limit 1</param>
		/// <param name="m3MES1">Meter 1</param>
		/// <param name="m3WAL2">Warranty limit 2</param>
		/// <param name="m3MES2">Meter 2</param>
		/// <param name="m3WAL3">Warranty limit 3</param>
		/// <param name="m3MES3">Meter 3</param>
		/// <param name="m3WAL4">Warranty limit 4</param>
		/// <param name="m3MES4">Meter 4</param>
		/// <param name="m3AINX">Index</param>
		/// <param name="m3AMVI">Maximum material value per item</param>
		/// <param name="m3AMAM">Maximum material cost</param>
		/// <param name="m3AMPI">Max material price per transaction</param>
		/// <param name="m3AMAL">Maximum labor cost</param>
		/// <param name="m3AMM1">Max material price per order</param>
		/// <param name="m3AMLL">Minimum hours per line</param>
		/// <param name="m3AEXC">Exclude / include material</param>
		/// <param name="m3AMLJ">Minimum labor hours per job ID</param>
		/// <param name="m3AMLO">Minimum hours per order</param>
		/// <param name="m3AMIL">Minimum material cost/line</param>
		/// <param name="m3AMIO">Minimum material cost/order</param>
		/// <param name="m3AMSL">Minimum subcontract charge per line</param>
		/// <param name="m3AMSO">Minimum subcontract charge per order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAgrLines(
			string m3AAGN, 
			int? m3SRVP = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			DateTime? m3STDT = null, 
			DateTime? m3TODT = null, 
			string m3PRTX = null, 
			int? m3LEAS = null, 
			string m3MES0 = null, 
			decimal? m3WAL1 = null, 
			string m3MES1 = null, 
			decimal? m3WAL2 = null, 
			string m3MES2 = null, 
			decimal? m3WAL3 = null, 
			string m3MES3 = null, 
			decimal? m3WAL4 = null, 
			string m3MES4 = null, 
			int? m3AINX = null, 
			decimal? m3AMVI = null, 
			decimal? m3AMAM = null, 
			decimal? m3AMPI = null, 
			decimal? m3AMAL = null, 
			decimal? m3AMM1 = null, 
			decimal? m3AMLL = null, 
			int? m3AEXC = null, 
			decimal? m3AMLJ = null, 
			decimal? m3AMLO = null, 
			decimal? m3AMIL = null, 
			decimal? m3AMIO = null, 
			decimal? m3AMSL = null, 
			decimal? m3AMSO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAgrLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3SRVP.HasValue)
				request.WithQueryParameter("SRVP", m3SRVP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PRTX))
				request.WithQueryParameter("PRTX", m3PRTX.Trim());
			if (m3LEAS.HasValue)
				request.WithQueryParameter("LEAS", m3LEAS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MES0))
				request.WithQueryParameter("MES0", m3MES0.Trim());
			if (m3WAL1.HasValue)
				request.WithQueryParameter("WAL1", m3WAL1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MES1))
				request.WithQueryParameter("MES1", m3MES1.Trim());
			if (m3WAL2.HasValue)
				request.WithQueryParameter("WAL2", m3WAL2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MES2))
				request.WithQueryParameter("MES2", m3MES2.Trim());
			if (m3WAL3.HasValue)
				request.WithQueryParameter("WAL3", m3WAL3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MES3))
				request.WithQueryParameter("MES3", m3MES3.Trim());
			if (m3WAL4.HasValue)
				request.WithQueryParameter("WAL4", m3WAL4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MES4))
				request.WithQueryParameter("MES4", m3MES4.Trim());
			if (m3AINX.HasValue)
				request.WithQueryParameter("AINX", m3AINX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMVI.HasValue)
				request.WithQueryParameter("AMVI", m3AMVI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMAM.HasValue)
				request.WithQueryParameter("AMAM", m3AMAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMPI.HasValue)
				request.WithQueryParameter("AMPI", m3AMPI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMAL.HasValue)
				request.WithQueryParameter("AMAL", m3AMAL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMM1.HasValue)
				request.WithQueryParameter("AMM1", m3AMM1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMLL.HasValue)
				request.WithQueryParameter("AMLL", m3AMLL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AEXC.HasValue)
				request.WithQueryParameter("AEXC", m3AEXC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMLJ.HasValue)
				request.WithQueryParameter("AMLJ", m3AMLJ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMLO.HasValue)
				request.WithQueryParameter("AMLO", m3AMLO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMIL.HasValue)
				request.WithQueryParameter("AMIL", m3AMIL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMIO.HasValue)
				request.WithQueryParameter("AMIO", m3AMIO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMSL.HasValue)
				request.WithQueryParameter("AMSL", m3AMSL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMSO.HasValue)
				request.WithQueryParameter("AMSO", m3AMSO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddAgrObjects
		/// Description Add agreement - objects
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3AAGN">Agreement (Required)</param>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAgrObjects(
			string m3AAGN, 
			string m3PRNO, 
			string m3BANO = null, 
			DateTime? m3STDT = null, 
			DateTime? m3TODT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAgrObjects",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());

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
		/// Name AddAgreement
		/// Description Add agreement
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3TODT">To date (Required)</param>
		/// <param name="m3TAGR">Template agreement</param>
		/// <param name="m3AAGT">Agreement type</param>
		/// <param name="m3AAGN">Agreement</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3TX30">Text</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3AMCU">Material currency</param>
		/// <param name="m3CRTM">Critical material</param>
		/// <param name="m3AACU">Agreement currency</param>
		/// <param name="m3CRTA">Exchange rate type</param>
		/// <param name="m3ACSE">Serial number administration</param>
		/// <param name="m3AMRE">Maximum repair cost</param>
		/// <param name="m3AMOD">Modification</param>
		/// <param name="m3RIUS">Removal/installation update invoice spec</param>
		/// <param name="m3AISP">Invoice specification layout</param>
		/// <param name="m3SNRC">Serial number return code</param>
		/// <param name="m3AOTY">Order type</param>
		/// <param name="m3PIOT">Periodic invoice order type</param>
		/// <param name="m3INVM">Invoicing method</param>
		/// <param name="m3APBA">Material price method</param>
		/// <param name="m3PRMS">Price origin sequence</param>
		/// <param name="m3AHCM">Material handling charge method</param>
		/// <param name="m3PRR1">Price list 1</param>
		/// <param name="m3PRR2">Price list 2</param>
		/// <param name="m3PRR3">Price list 3</param>
		/// <param name="m3PRR4">Price list 4</param>
		/// <param name="m3PRR5">Price list 5</param>
		/// <param name="m3SPRL">Service price list</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3CFI2">User-defined field 2 - item</param>
		/// <param name="m3AICD">Summary invoice</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3ACDY">Agreement cancellation - days notice</param>
		/// <param name="m3AREF">External reference</param>
		/// <param name="m3OREF">Our reference</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3AMTN">Curve</param>
		/// <param name="m3NPAM">Number of periods</param>
		/// <param name="m3PERA">Period accounting</param>
		/// <param name="m3ROPP">Rounding-off category</param>
		/// <param name="m3ACT9">Check scope of agreement - object</param>
		/// <param name="m3ACRG">Check scope of agreement - model indiv</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3TEDL">Delivery terms</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3TEPA">Packaging terms</param>
		/// <param name="m3TEAF">Freight terms</param>
		/// <param name="m3PLTB">Price list table</param>
		/// <param name="m3DISY">Discount model</param>
		/// <param name="m3APR1">Used material price discount</param>
		/// <param name="m3AMHC">Handling charge customer-owned items</param>
		/// <param name="m3AEHA">Percent new material price - exchange</param>
		/// <param name="m3AMHA">General handling charge</param>
		/// <param name="m3ASHA">Subcontract handling charge</param>
		/// <param name="m3AAOG">Priority markup</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAgreement(
			DateTime m3STDT, 
			DateTime m3TODT, 
			string m3TAGR = null, 
			string m3AAGT = null, 
			string m3AAGN = null, 
			string m3CUNO = null, 
			string m3FACI = null, 
			string m3PYNO = null, 
			string m3STAT = null, 
			string m3TX30 = null, 
			string m3WHLO = null, 
			string m3RESP = null, 
			string m3AMCU = null, 
			int? m3CRTM = null, 
			string m3AACU = null, 
			int? m3CRTA = null, 
			int? m3ACSE = null, 
			int? m3AMRE = null, 
			int? m3AMOD = null, 
			int? m3RIUS = null, 
			int? m3AISP = null, 
			int? m3SNRC = null, 
			string m3AOTY = null, 
			string m3PIOT = null, 
			string m3INVM = null, 
			int? m3APBA = null, 
			string m3PRMS = null, 
			int? m3AHCM = null, 
			string m3PRR1 = null, 
			string m3PRR2 = null, 
			string m3PRR3 = null, 
			string m3PRR4 = null, 
			string m3PRR5 = null, 
			string m3SPRL = null, 
			string m3LNCD = null, 
			decimal? m3CFI2 = null, 
			int? m3AICD = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			int? m3ACDY = null, 
			string m3AREF = null, 
			string m3OREF = null, 
			string m3YREF = null, 
			int? m3AMTN = null, 
			int? m3NPAM = null, 
			string m3PERA = null, 
			int? m3ROPP = null, 
			int? m3ACT9 = null, 
			int? m3ACRG = null, 
			string m3MODL = null, 
			string m3TEDL = null, 
			string m3TEPY = null, 
			string m3TEPA = null, 
			string m3TEAF = null, 
			string m3PLTB = null, 
			string m3DISY = null, 
			int? m3APR1 = null, 
			int? m3AMHC = null, 
			int? m3AEHA = null, 
			int? m3AMHA = null, 
			int? m3ASHA = null, 
			int? m3AAOG = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAgreement",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("STDT", m3STDT.ToM3String())
				.WithQueryParameter("TODT", m3TODT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TAGR))
				request.WithQueryParameter("TAGR", m3TAGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3AAGT))
				request.WithQueryParameter("AAGT", m3AAGT.Trim());
			if (!string.IsNullOrWhiteSpace(m3AAGN))
				request.WithQueryParameter("AAGN", m3AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX30))
				request.WithQueryParameter("TX30", m3TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3AMCU))
				request.WithQueryParameter("AMCU", m3AMCU.Trim());
			if (m3CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3CRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AACU))
				request.WithQueryParameter("AACU", m3AACU.Trim());
			if (m3CRTA.HasValue)
				request.WithQueryParameter("CRTA", m3CRTA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACSE.HasValue)
				request.WithQueryParameter("ACSE", m3ACSE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMRE.HasValue)
				request.WithQueryParameter("AMRE", m3AMRE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMOD.HasValue)
				request.WithQueryParameter("AMOD", m3AMOD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIUS.HasValue)
				request.WithQueryParameter("RIUS", m3RIUS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AISP.HasValue)
				request.WithQueryParameter("AISP", m3AISP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SNRC.HasValue)
				request.WithQueryParameter("SNRC", m3SNRC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AOTY))
				request.WithQueryParameter("AOTY", m3AOTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PIOT))
				request.WithQueryParameter("PIOT", m3PIOT.Trim());
			if (!string.IsNullOrWhiteSpace(m3INVM))
				request.WithQueryParameter("INVM", m3INVM.Trim());
			if (m3APBA.HasValue)
				request.WithQueryParameter("APBA", m3APBA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRMS))
				request.WithQueryParameter("PRMS", m3PRMS.Trim());
			if (m3AHCM.HasValue)
				request.WithQueryParameter("AHCM", m3AHCM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRR1))
				request.WithQueryParameter("PRR1", m3PRR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRR2))
				request.WithQueryParameter("PRR2", m3PRR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRR3))
				request.WithQueryParameter("PRR3", m3PRR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRR4))
				request.WithQueryParameter("PRR4", m3PRR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRR5))
				request.WithQueryParameter("PRR5", m3PRR5.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPRL))
				request.WithQueryParameter("SPRL", m3SPRL.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (m3CFI2.HasValue)
				request.WithQueryParameter("CFI2", m3CFI2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AICD.HasValue)
				request.WithQueryParameter("AICD", m3AICD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (m3ACDY.HasValue)
				request.WithQueryParameter("ACDY", m3ACDY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AREF))
				request.WithQueryParameter("AREF", m3AREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3OREF))
				request.WithQueryParameter("OREF", m3OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (m3AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3AMTN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NPAM.HasValue)
				request.WithQueryParameter("NPAM", m3NPAM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PERA))
				request.WithQueryParameter("PERA", m3PERA.Trim());
			if (m3ROPP.HasValue)
				request.WithQueryParameter("ROPP", m3ROPP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACT9.HasValue)
				request.WithQueryParameter("ACT9", m3ACT9.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACRG.HasValue)
				request.WithQueryParameter("ACRG", m3ACRG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEAF))
				request.WithQueryParameter("TEAF", m3TEAF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLTB))
				request.WithQueryParameter("PLTB", m3PLTB.Trim());
			if (!string.IsNullOrWhiteSpace(m3DISY))
				request.WithQueryParameter("DISY", m3DISY.Trim());
			if (m3APR1.HasValue)
				request.WithQueryParameter("APR1", m3APR1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMHC.HasValue)
				request.WithQueryParameter("AMHC", m3AMHC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AEHA.HasValue)
				request.WithQueryParameter("AEHA", m3AEHA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMHA.HasValue)
				request.WithQueryParameter("AMHA", m3AMHA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ASHA.HasValue)
				request.WithQueryParameter("ASHA", m3ASHA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AAOG.HasValue)
				request.WithQueryParameter("AAOG", m3AAOG.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltAgrCharges
		/// Description Delete agreeent - charges
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3AAGN">Agreement (Required)</param>
		/// <param name="m3CRID">Charge (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAgrCharges(
			string m3AAGN, 
			string m3CRID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltAgrCharges",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));
			if (string.IsNullOrWhiteSpace(m3CRID))
				throw new ArgumentNullException(nameof(m3CRID));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim())
				.WithQueryParameter("CRID", m3CRID.Trim());

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
		/// Name DltAgrLines
		/// Description Delete agreement - lines
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3AAGN">Agreement (Required)</param>
		/// <param name="m3SRVP">Service price method (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAgrLines(
			string m3AAGN, 
			int m3SRVP, 
			DateTime m3STDT, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltAgrLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim())
				.WithQueryParameter("SRVP", m3SRVP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STDT", m3STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());

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
		/// Name DltAgrObjects
		/// Description Delete agreement - objects
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3AAGN">Agreement (Required)</param>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAgrObjects(
			string m3AAGN, 
			string m3PRNO, 
			DateTime m3STDT, 
			string m3BANO = null, 
			DateTime? m3TODT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltAgrObjects",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());

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
		/// Name DltAgreement
		/// Description Delete agreement
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3AAGN">Agreement (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAgreement(
			string m3AAGN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltAgreement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim());

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
		/// Name GetAgrCharges
		/// Description Get agreement - charges
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3AAGN">Agreement (Required)</param>
		/// <param name="m3CRID">Charge (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgrChargesResponse></returns>
		/// <exception cref="M3Exception<GetAgrChargesResponse>"></exception>
		public async Task<M3Response<GetAgrChargesResponse>> GetAgrCharges(
			string m3AAGN, 
			string m3CRID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAgrCharges",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));
			if (string.IsNullOrWhiteSpace(m3CRID))
				throw new ArgumentNullException(nameof(m3CRID));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim())
				.WithQueryParameter("CRID", m3CRID.Trim());

			// Execute the request
			var result = await Execute<GetAgrChargesResponse>(
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
		/// Name GetAgrLines
		/// Description Get agreement - lines
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3AAGN">Agreement (Required)</param>
		/// <param name="m3SRVP">Service price method (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgrLinesResponse></returns>
		/// <exception cref="M3Exception<GetAgrLinesResponse>"></exception>
		public async Task<M3Response<GetAgrLinesResponse>> GetAgrLines(
			string m3AAGN, 
			int m3SRVP, 
			DateTime m3STDT, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAgrLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim())
				.WithQueryParameter("SRVP", m3SRVP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STDT", m3STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());

			// Execute the request
			var result = await Execute<GetAgrLinesResponse>(
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
		/// Name GetAgrObjects
		/// Description Get agreement - objects
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3AAGN">Agreement (Required)</param>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgrObjectsResponse></returns>
		/// <exception cref="M3Exception<GetAgrObjectsResponse>"></exception>
		public async Task<M3Response<GetAgrObjectsResponse>> GetAgrObjects(
			string m3AAGN, 
			string m3PRNO, 
			DateTime m3STDT, 
			string m3BANO = null, 
			DateTime? m3TODT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAgrObjects",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetAgrObjectsResponse>(
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
		/// Name GetAgreement
		/// Description Get agreement
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3AAGN">Agreement (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgreementResponse></returns>
		/// <exception cref="M3Exception<GetAgreementResponse>"></exception>
		public async Task<M3Response<GetAgreementResponse>> GetAgreement(
			string m3AAGN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAgreement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim());

			// Execute the request
			var result = await Execute<GetAgreementResponse>(
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
		/// Name LstAgrCharges
		/// Description List agreement - charges
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3AAGN">Agreement (Required)</param>
		/// <param name="m3CRID">Charge</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrChargesResponse></returns>
		/// <exception cref="M3Exception<LstAgrChargesResponse>"></exception>
		public async Task<M3Response<LstAgrChargesResponse>> LstAgrCharges(
			string m3AAGN, 
			string m3CRID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgrCharges",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CRID))
				request.WithQueryParameter("CRID", m3CRID.Trim());

			// Execute the request
			var result = await Execute<LstAgrChargesResponse>(
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
		/// Name LstAgrLines
		/// Description List agreement - lines
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3AAGN">Agreement (Required)</param>
		/// <param name="m3SRVP">Service price method</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrLinesResponse></returns>
		/// <exception cref="M3Exception<LstAgrLinesResponse>"></exception>
		public async Task<M3Response<LstAgrLinesResponse>> LstAgrLines(
			string m3AAGN, 
			int? m3SRVP = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			DateTime? m3STDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgrLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3SRVP.HasValue)
				request.WithQueryParameter("SRVP", m3SRVP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstAgrLinesResponse>(
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
		/// Name LstAgrObjects
		/// Description List agreement - objects
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3AAGN">Agreement (Required)</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrObjectsResponse></returns>
		/// <exception cref="M3Exception<LstAgrObjectsResponse>"></exception>
		public async Task<M3Response<LstAgrObjectsResponse>> LstAgrObjects(
			string m3AAGN, 
			string m3PRNO = null, 
			string m3BANO = null, 
			DateTime? m3STDT = null, 
			DateTime? m3TODT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgrObjects",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstAgrObjectsResponse>(
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
		/// Name LstAgreement
		/// Description List agreement
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3AAGN">Agreement</param>
		/// <param name="m3AAGT">Agreement type</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgreementResponse></returns>
		/// <exception cref="M3Exception<LstAgreementResponse>"></exception>
		public async Task<M3Response<LstAgreementResponse>> LstAgreement(
			string m3AAGN = null, 
			string m3AAGT = null, 
			string m3CUNO = null, 
			string m3FACI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgreement",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AAGN))
				request.WithQueryParameter("AAGN", m3AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3AAGT))
				request.WithQueryParameter("AAGT", m3AAGT.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());

			// Execute the request
			var result = await Execute<LstAgreementResponse>(
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
		/// Name UpdAgrCharges
		/// Description Update agreement - charges
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3AAGN">Agreement (Required)</param>
		/// <param name="m3CRID">Charge (Required)</param>
		/// <param name="m3CRAA">Charge</param>
		/// <param name="m3VTCD">VAT code</param>
		/// <param name="m3HACD">Debit frequency</param>
		/// <param name="m3CRD0">Description</param>
		/// <param name="m3TAXC">Tax code customer/address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAgrCharges(
			string m3AAGN, 
			string m3CRID, 
			decimal? m3CRAA = null, 
			int? m3VTCD = null, 
			int? m3HACD = null, 
			string m3CRD0 = null, 
			string m3TAXC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdAgrCharges",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));
			if (string.IsNullOrWhiteSpace(m3CRID))
				throw new ArgumentNullException(nameof(m3CRID));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim())
				.WithQueryParameter("CRID", m3CRID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CRAA.HasValue)
				request.WithQueryParameter("CRAA", m3CRAA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3VTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HACD.HasValue)
				request.WithQueryParameter("HACD", m3HACD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CRD0))
				request.WithQueryParameter("CRD0", m3CRD0.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAXC))
				request.WithQueryParameter("TAXC", m3TAXC.Trim());

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
		/// Name UpdAgrLines
		/// Description Update agreement - lines
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3AAGN">Agreement (Required)</param>
		/// <param name="m3SRVP">Service price method (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="m3PRTX">Text</param>
		/// <param name="m3LEAS">Lead time - service</param>
		/// <param name="m3MES0">Meter</param>
		/// <param name="m3WAL1">Warranty limit 1</param>
		/// <param name="m3MES1">Meter 1</param>
		/// <param name="m3WAL2">Warranty limit 2</param>
		/// <param name="m3MES2">Meter 2</param>
		/// <param name="m3WAL3">Warranty limit 3</param>
		/// <param name="m3MES3">Meter 3</param>
		/// <param name="m3WAL4">Warranty limit 4</param>
		/// <param name="m3MES4">Meter 4</param>
		/// <param name="m3AINX">Index</param>
		/// <param name="m3AMVI">Maximum material value per item</param>
		/// <param name="m3AMAM">Maximum material cost</param>
		/// <param name="m3AMPI">Max material price per transaction</param>
		/// <param name="m3AMAL">Maximum labor cost</param>
		/// <param name="m3AMM1">Max material price per order</param>
		/// <param name="m3AMLL">Minimum hours per line</param>
		/// <param name="m3AEXC">Exclude / include material</param>
		/// <param name="m3AMLJ">Minimum labor hours per job ID</param>
		/// <param name="m3AMLO">Minimum hours per order</param>
		/// <param name="m3AMIL">Minimum material cost/line</param>
		/// <param name="m3AMIO">Minimum material cost/order</param>
		/// <param name="m3AMSL">Minimum subcontract charge per line</param>
		/// <param name="m3AMSO">Minimum subcontract charge per order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAgrLines(
			string m3AAGN, 
			int m3SRVP, 
			DateTime m3STDT, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			DateTime? m3TODT = null, 
			string m3PRTX = null, 
			int? m3LEAS = null, 
			string m3MES0 = null, 
			decimal? m3WAL1 = null, 
			string m3MES1 = null, 
			decimal? m3WAL2 = null, 
			string m3MES2 = null, 
			decimal? m3WAL3 = null, 
			string m3MES3 = null, 
			decimal? m3WAL4 = null, 
			string m3MES4 = null, 
			int? m3AINX = null, 
			decimal? m3AMVI = null, 
			decimal? m3AMAM = null, 
			decimal? m3AMPI = null, 
			decimal? m3AMAL = null, 
			decimal? m3AMM1 = null, 
			decimal? m3AMLL = null, 
			int? m3AEXC = null, 
			decimal? m3AMLJ = null, 
			decimal? m3AMLO = null, 
			decimal? m3AMIL = null, 
			decimal? m3AMIO = null, 
			decimal? m3AMSL = null, 
			decimal? m3AMSO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdAgrLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim())
				.WithQueryParameter("SRVP", m3SRVP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STDT", m3STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PRTX))
				request.WithQueryParameter("PRTX", m3PRTX.Trim());
			if (m3LEAS.HasValue)
				request.WithQueryParameter("LEAS", m3LEAS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MES0))
				request.WithQueryParameter("MES0", m3MES0.Trim());
			if (m3WAL1.HasValue)
				request.WithQueryParameter("WAL1", m3WAL1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MES1))
				request.WithQueryParameter("MES1", m3MES1.Trim());
			if (m3WAL2.HasValue)
				request.WithQueryParameter("WAL2", m3WAL2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MES2))
				request.WithQueryParameter("MES2", m3MES2.Trim());
			if (m3WAL3.HasValue)
				request.WithQueryParameter("WAL3", m3WAL3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MES3))
				request.WithQueryParameter("MES3", m3MES3.Trim());
			if (m3WAL4.HasValue)
				request.WithQueryParameter("WAL4", m3WAL4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MES4))
				request.WithQueryParameter("MES4", m3MES4.Trim());
			if (m3AINX.HasValue)
				request.WithQueryParameter("AINX", m3AINX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMVI.HasValue)
				request.WithQueryParameter("AMVI", m3AMVI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMAM.HasValue)
				request.WithQueryParameter("AMAM", m3AMAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMPI.HasValue)
				request.WithQueryParameter("AMPI", m3AMPI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMAL.HasValue)
				request.WithQueryParameter("AMAL", m3AMAL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMM1.HasValue)
				request.WithQueryParameter("AMM1", m3AMM1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMLL.HasValue)
				request.WithQueryParameter("AMLL", m3AMLL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AEXC.HasValue)
				request.WithQueryParameter("AEXC", m3AEXC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMLJ.HasValue)
				request.WithQueryParameter("AMLJ", m3AMLJ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMLO.HasValue)
				request.WithQueryParameter("AMLO", m3AMLO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMIL.HasValue)
				request.WithQueryParameter("AMIL", m3AMIL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMIO.HasValue)
				request.WithQueryParameter("AMIO", m3AMIO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMSL.HasValue)
				request.WithQueryParameter("AMSL", m3AMSL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMSO.HasValue)
				request.WithQueryParameter("AMSO", m3AMSO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdAgrObjects
		/// Description Update agreement - objects
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3AAGN">Agreement (Required)</param>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAgrObjects(
			string m3AAGN, 
			string m3PRNO, 
			DateTime m3STDT, 
			string m3BANO = null, 
			DateTime? m3TODT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdAgrObjects",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());

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
		/// Name UpdAgreement
		/// Description Update agreement
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3AAGN">Agreement (Required)</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3TX30">Text</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3AMCU">Material currency</param>
		/// <param name="m3CRTM">Critical material</param>
		/// <param name="m3AACU">Agreement currency</param>
		/// <param name="m3CRTA">Exchange rate type</param>
		/// <param name="m3ACSE">Serial number administration</param>
		/// <param name="m3AMRE">Maximum repair cost</param>
		/// <param name="m3AMOD">Modification</param>
		/// <param name="m3RIUS">Removal/installation update invoice spec</param>
		/// <param name="m3AISP">Invoice specification layout</param>
		/// <param name="m3SNRC">Serial number return code</param>
		/// <param name="m3AOTY">Order type</param>
		/// <param name="m3PIOT">Periodic invoice order type</param>
		/// <param name="m3INVM">Invoicing method</param>
		/// <param name="m3APBA">Material price method</param>
		/// <param name="m3PRMS">Price origin sequence</param>
		/// <param name="m3AHCM">Material handling charge method</param>
		/// <param name="m3PRR1">Price list 1</param>
		/// <param name="m3PRR2">Price list 2</param>
		/// <param name="m3PRR3">Price list 3</param>
		/// <param name="m3PRR4">Price list 4</param>
		/// <param name="m3PRR5">Price list 5</param>
		/// <param name="m3SPRL">Service price list</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3CFI2">User-defined field 2 - item</param>
		/// <param name="m3AICD">Summary invoice</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3ACDY">Agreement cancellation - days notice</param>
		/// <param name="m3AREF">External reference</param>
		/// <param name="m3OREF">Our reference</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3AMTN">Curve</param>
		/// <param name="m3NPAM">Number of periods</param>
		/// <param name="m3PERA">Period accounting</param>
		/// <param name="m3ROPP">Rounding-off category</param>
		/// <param name="m3ACT9">Check scope of agreement - object</param>
		/// <param name="m3ACRG">Check scope of agreement - model indiv</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3TEDL">Delivery terms</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3TEPA">Packaging terms</param>
		/// <param name="m3TEAF">Freight terms</param>
		/// <param name="m3PLTB">Price list table</param>
		/// <param name="m3DISY">Discount model</param>
		/// <param name="m3APR1">Used material price discount</param>
		/// <param name="m3AMHC">Handling charge customer-owned items</param>
		/// <param name="m3AEHA">Percent new material price - exchange</param>
		/// <param name="m3AMHA">General handling charge</param>
		/// <param name="m3ASHA">Subcontract handling charge</param>
		/// <param name="m3AAOG">Priority markup</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAgreement(
			string m3AAGN, 
			string m3FACI = null, 
			string m3PYNO = null, 
			string m3STAT = null, 
			string m3TX30 = null, 
			DateTime? m3STDT = null, 
			DateTime? m3TODT = null, 
			string m3WHLO = null, 
			string m3RESP = null, 
			string m3AMCU = null, 
			int? m3CRTM = null, 
			string m3AACU = null, 
			int? m3CRTA = null, 
			int? m3ACSE = null, 
			int? m3AMRE = null, 
			int? m3AMOD = null, 
			int? m3RIUS = null, 
			int? m3AISP = null, 
			int? m3SNRC = null, 
			string m3AOTY = null, 
			string m3PIOT = null, 
			string m3INVM = null, 
			int? m3APBA = null, 
			string m3PRMS = null, 
			int? m3AHCM = null, 
			string m3PRR1 = null, 
			string m3PRR2 = null, 
			string m3PRR3 = null, 
			string m3PRR4 = null, 
			string m3PRR5 = null, 
			string m3SPRL = null, 
			string m3LNCD = null, 
			decimal? m3CFI2 = null, 
			int? m3AICD = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			int? m3ACDY = null, 
			string m3AREF = null, 
			string m3OREF = null, 
			string m3YREF = null, 
			int? m3AMTN = null, 
			int? m3NPAM = null, 
			string m3PERA = null, 
			int? m3ROPP = null, 
			int? m3ACT9 = null, 
			int? m3ACRG = null, 
			string m3MODL = null, 
			string m3TEDL = null, 
			string m3TEPY = null, 
			string m3TEPA = null, 
			string m3TEAF = null, 
			string m3PLTB = null, 
			string m3DISY = null, 
			int? m3APR1 = null, 
			int? m3AMHC = null, 
			int? m3AEHA = null, 
			int? m3AMHA = null, 
			int? m3ASHA = null, 
			int? m3AAOG = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdAgreement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX30))
				request.WithQueryParameter("TX30", m3TX30.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3AMCU))
				request.WithQueryParameter("AMCU", m3AMCU.Trim());
			if (m3CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3CRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AACU))
				request.WithQueryParameter("AACU", m3AACU.Trim());
			if (m3CRTA.HasValue)
				request.WithQueryParameter("CRTA", m3CRTA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACSE.HasValue)
				request.WithQueryParameter("ACSE", m3ACSE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMRE.HasValue)
				request.WithQueryParameter("AMRE", m3AMRE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMOD.HasValue)
				request.WithQueryParameter("AMOD", m3AMOD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIUS.HasValue)
				request.WithQueryParameter("RIUS", m3RIUS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AISP.HasValue)
				request.WithQueryParameter("AISP", m3AISP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SNRC.HasValue)
				request.WithQueryParameter("SNRC", m3SNRC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AOTY))
				request.WithQueryParameter("AOTY", m3AOTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PIOT))
				request.WithQueryParameter("PIOT", m3PIOT.Trim());
			if (!string.IsNullOrWhiteSpace(m3INVM))
				request.WithQueryParameter("INVM", m3INVM.Trim());
			if (m3APBA.HasValue)
				request.WithQueryParameter("APBA", m3APBA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRMS))
				request.WithQueryParameter("PRMS", m3PRMS.Trim());
			if (m3AHCM.HasValue)
				request.WithQueryParameter("AHCM", m3AHCM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRR1))
				request.WithQueryParameter("PRR1", m3PRR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRR2))
				request.WithQueryParameter("PRR2", m3PRR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRR3))
				request.WithQueryParameter("PRR3", m3PRR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRR4))
				request.WithQueryParameter("PRR4", m3PRR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRR5))
				request.WithQueryParameter("PRR5", m3PRR5.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPRL))
				request.WithQueryParameter("SPRL", m3SPRL.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (m3CFI2.HasValue)
				request.WithQueryParameter("CFI2", m3CFI2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AICD.HasValue)
				request.WithQueryParameter("AICD", m3AICD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (m3ACDY.HasValue)
				request.WithQueryParameter("ACDY", m3ACDY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AREF))
				request.WithQueryParameter("AREF", m3AREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3OREF))
				request.WithQueryParameter("OREF", m3OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (m3AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3AMTN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NPAM.HasValue)
				request.WithQueryParameter("NPAM", m3NPAM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PERA))
				request.WithQueryParameter("PERA", m3PERA.Trim());
			if (m3ROPP.HasValue)
				request.WithQueryParameter("ROPP", m3ROPP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACT9.HasValue)
				request.WithQueryParameter("ACT9", m3ACT9.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACRG.HasValue)
				request.WithQueryParameter("ACRG", m3ACRG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEAF))
				request.WithQueryParameter("TEAF", m3TEAF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLTB))
				request.WithQueryParameter("PLTB", m3PLTB.Trim());
			if (!string.IsNullOrWhiteSpace(m3DISY))
				request.WithQueryParameter("DISY", m3DISY.Trim());
			if (m3APR1.HasValue)
				request.WithQueryParameter("APR1", m3APR1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMHC.HasValue)
				request.WithQueryParameter("AMHC", m3AMHC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AEHA.HasValue)
				request.WithQueryParameter("AEHA", m3AEHA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMHA.HasValue)
				request.WithQueryParameter("AMHA", m3AMHA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ASHA.HasValue)
				request.WithQueryParameter("ASHA", m3ASHA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AAOG.HasValue)
				request.WithQueryParameter("AAOG", m3AAOG.Value.ToString(CultureInfo.CurrentCulture));

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
