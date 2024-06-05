/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_AAGN">Agreement (Required)</param>
		/// <param name="m3_CRID">Charge (Required)</param>
		/// <param name="m3_CRAM">Charge</param>
		/// <param name="m3_VTCD">VAT code</param>
		/// <param name="m3_HACD">Debit frequency</param>
		/// <param name="m3_CRD0">Description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAgrCharges(
			string m3_AAGN, 
			string m3_CRID, 
			decimal? m3_CRAM = null, 
			int? m3_VTCD = null, 
			int? m3_HACD = null, 
			string m3_CRD0 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");
			if (string.IsNullOrWhiteSpace(m3_CRID))
				throw new ArgumentNullException("m3_CRID");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim())
				.WithQueryParameter("CRID", m3_CRID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CRAM.HasValue)
				request.WithQueryParameter("CRAM", m3_CRAM.Value.ToString());
			if (m3_VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3_VTCD.Value.ToString());
			if (m3_HACD.HasValue)
				request.WithQueryParameter("HACD", m3_HACD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CRD0))
				request.WithQueryParameter("CRD0", m3_CRD0.Trim());

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
		/// Name AddAgrLines
		/// Description Add agreement - lines
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_AAGN">Agreement (Required)</param>
		/// <param name="m3_SRVP">Service price method</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_TODT">To date</param>
		/// <param name="m3_PRTX">Text</param>
		/// <param name="m3_LEAS">Lead time - service</param>
		/// <param name="m3_MES0">Meter</param>
		/// <param name="m3_WAL1">Warranty limit 1</param>
		/// <param name="m3_MES1">Meter 1</param>
		/// <param name="m3_WAL2">Warranty limit 2</param>
		/// <param name="m3_MES2">Meter 2</param>
		/// <param name="m3_WAL3">Warranty limit 3</param>
		/// <param name="m3_MES3">Meter 3</param>
		/// <param name="m3_WAL4">Warranty limit 4</param>
		/// <param name="m3_MES4">Meter 4</param>
		/// <param name="m3_AINX">Index</param>
		/// <param name="m3_AMVI">Maximum material value per item</param>
		/// <param name="m3_AMAM">Maximum material cost</param>
		/// <param name="m3_AMPI">Max material price per transaction</param>
		/// <param name="m3_AMAL">Maximum labor cost</param>
		/// <param name="m3_AMM1">Max material price per order</param>
		/// <param name="m3_AMLL">Minimum hours per line</param>
		/// <param name="m3_AEXC">Exclude / include material</param>
		/// <param name="m3_AMLJ">Minimum labor hours per job ID</param>
		/// <param name="m3_AMLO">Minimum hours per order</param>
		/// <param name="m3_AMIL">Minimum material cost/line</param>
		/// <param name="m3_AMIO">Minimum material cost/order</param>
		/// <param name="m3_AMSL">Minimum subcontract charge per line</param>
		/// <param name="m3_AMSO">Minimum subcontract charge per order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAgrLines(
			string m3_AAGN, 
			int? m3_SRVP = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			DateTime? m3_STDT = null, 
			DateTime? m3_TODT = null, 
			string m3_PRTX = null, 
			int? m3_LEAS = null, 
			string m3_MES0 = null, 
			decimal? m3_WAL1 = null, 
			string m3_MES1 = null, 
			decimal? m3_WAL2 = null, 
			string m3_MES2 = null, 
			decimal? m3_WAL3 = null, 
			string m3_MES3 = null, 
			decimal? m3_WAL4 = null, 
			string m3_MES4 = null, 
			int? m3_AINX = null, 
			decimal? m3_AMVI = null, 
			decimal? m3_AMAM = null, 
			decimal? m3_AMPI = null, 
			decimal? m3_AMAL = null, 
			decimal? m3_AMM1 = null, 
			decimal? m3_AMLL = null, 
			int? m3_AEXC = null, 
			decimal? m3_AMLJ = null, 
			decimal? m3_AMLO = null, 
			decimal? m3_AMIL = null, 
			decimal? m3_AMIO = null, 
			decimal? m3_AMSL = null, 
			decimal? m3_AMSO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_SRVP.HasValue)
				request.WithQueryParameter("SRVP", m3_SRVP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PRTX))
				request.WithQueryParameter("PRTX", m3_PRTX.Trim());
			if (m3_LEAS.HasValue)
				request.WithQueryParameter("LEAS", m3_LEAS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MES0))
				request.WithQueryParameter("MES0", m3_MES0.Trim());
			if (m3_WAL1.HasValue)
				request.WithQueryParameter("WAL1", m3_WAL1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MES1))
				request.WithQueryParameter("MES1", m3_MES1.Trim());
			if (m3_WAL2.HasValue)
				request.WithQueryParameter("WAL2", m3_WAL2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MES2))
				request.WithQueryParameter("MES2", m3_MES2.Trim());
			if (m3_WAL3.HasValue)
				request.WithQueryParameter("WAL3", m3_WAL3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MES3))
				request.WithQueryParameter("MES3", m3_MES3.Trim());
			if (m3_WAL4.HasValue)
				request.WithQueryParameter("WAL4", m3_WAL4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MES4))
				request.WithQueryParameter("MES4", m3_MES4.Trim());
			if (m3_AINX.HasValue)
				request.WithQueryParameter("AINX", m3_AINX.Value.ToString());
			if (m3_AMVI.HasValue)
				request.WithQueryParameter("AMVI", m3_AMVI.Value.ToString());
			if (m3_AMAM.HasValue)
				request.WithQueryParameter("AMAM", m3_AMAM.Value.ToString());
			if (m3_AMPI.HasValue)
				request.WithQueryParameter("AMPI", m3_AMPI.Value.ToString());
			if (m3_AMAL.HasValue)
				request.WithQueryParameter("AMAL", m3_AMAL.Value.ToString());
			if (m3_AMM1.HasValue)
				request.WithQueryParameter("AMM1", m3_AMM1.Value.ToString());
			if (m3_AMLL.HasValue)
				request.WithQueryParameter("AMLL", m3_AMLL.Value.ToString());
			if (m3_AEXC.HasValue)
				request.WithQueryParameter("AEXC", m3_AEXC.Value.ToString());
			if (m3_AMLJ.HasValue)
				request.WithQueryParameter("AMLJ", m3_AMLJ.Value.ToString());
			if (m3_AMLO.HasValue)
				request.WithQueryParameter("AMLO", m3_AMLO.Value.ToString());
			if (m3_AMIL.HasValue)
				request.WithQueryParameter("AMIL", m3_AMIL.Value.ToString());
			if (m3_AMIO.HasValue)
				request.WithQueryParameter("AMIO", m3_AMIO.Value.ToString());
			if (m3_AMSL.HasValue)
				request.WithQueryParameter("AMSL", m3_AMSL.Value.ToString());
			if (m3_AMSO.HasValue)
				request.WithQueryParameter("AMSO", m3_AMSO.Value.ToString());

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
		/// Name AddAgrObjects
		/// Description Add agreement - objects
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_AAGN">Agreement (Required)</param>
		/// <param name="m3_PRNO">Product (Required)</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_TODT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAgrObjects(
			string m3_AAGN, 
			string m3_PRNO, 
			string m3_BANO = null, 
			DateTime? m3_STDT = null, 
			DateTime? m3_TODT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());

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
		/// Name AddAgreement
		/// Description Add agreement
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_TODT">To date (Required)</param>
		/// <param name="m3_TAGR">Template agreement</param>
		/// <param name="m3_AAGT">Agreement type</param>
		/// <param name="m3_AAGN">Agreement</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_TX30">Text</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_AMCU">Material currency</param>
		/// <param name="m3_CRTM">Critical material</param>
		/// <param name="m3_AACU">Agreement currency</param>
		/// <param name="m3_CRTA">Exchange rate type</param>
		/// <param name="m3_ACSE">Serial number administration</param>
		/// <param name="m3_AMRE">Maximum repair cost</param>
		/// <param name="m3_AMOD">Modification</param>
		/// <param name="m3_RIUS">Removal/installation update invoice spec</param>
		/// <param name="m3_AISP">Invoice specification layout</param>
		/// <param name="m3_SNRC">Serial number return code</param>
		/// <param name="m3_AOTY">Order type</param>
		/// <param name="m3_PIOT">Periodic invoice order type</param>
		/// <param name="m3_INVM">Invoicing method</param>
		/// <param name="m3_APBA">Material price method</param>
		/// <param name="m3_PRMS">Price origin sequence</param>
		/// <param name="m3_AHCM">Material handling charge method</param>
		/// <param name="m3_PRR1">Price list 1</param>
		/// <param name="m3_PRR2">Price list 2</param>
		/// <param name="m3_PRR3">Price list 3</param>
		/// <param name="m3_PRR4">Price list 4</param>
		/// <param name="m3_PRR5">Price list 5</param>
		/// <param name="m3_SPRL">Service price list</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_CFI2">User-defined field 2 - item</param>
		/// <param name="m3_AICD">Summary invoice</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_ACDY">Agreement cancellation - days notice</param>
		/// <param name="m3_AREF">External reference</param>
		/// <param name="m3_OREF">Our reference</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_AMTN">Curve</param>
		/// <param name="m3_NPAM">Number of periods</param>
		/// <param name="m3_PERA">Period accounting</param>
		/// <param name="m3_ROPP">Rounding-off category</param>
		/// <param name="m3_ACT9">Check scope of agreement - object</param>
		/// <param name="m3_ACRG">Check scope of agreement - model indiv</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TEDL">Delivery terms</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_TEPA">Packaging terms</param>
		/// <param name="m3_TEAF">Freight terms</param>
		/// <param name="m3_PLTB">Price list table</param>
		/// <param name="m3_DISY">Discount model</param>
		/// <param name="m3_APR1">Used material price discount</param>
		/// <param name="m3_AMHC">Handling charge customer-owned items</param>
		/// <param name="m3_AEHA">Percent new material price - exchange</param>
		/// <param name="m3_AMHA">General handling charge</param>
		/// <param name="m3_ASHA">Subcontract handling charge</param>
		/// <param name="m3_AAOG">Priority markup</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAgreement(
			DateTime m3_STDT, 
			DateTime m3_TODT, 
			string m3_TAGR = null, 
			string m3_AAGT = null, 
			string m3_AAGN = null, 
			string m3_CUNO = null, 
			string m3_FACI = null, 
			string m3_PYNO = null, 
			string m3_STAT = null, 
			string m3_TX30 = null, 
			string m3_WHLO = null, 
			string m3_RESP = null, 
			string m3_AMCU = null, 
			int? m3_CRTM = null, 
			string m3_AACU = null, 
			int? m3_CRTA = null, 
			int? m3_ACSE = null, 
			int? m3_AMRE = null, 
			int? m3_AMOD = null, 
			int? m3_RIUS = null, 
			int? m3_AISP = null, 
			int? m3_SNRC = null, 
			string m3_AOTY = null, 
			string m3_PIOT = null, 
			string m3_INVM = null, 
			int? m3_APBA = null, 
			string m3_PRMS = null, 
			int? m3_AHCM = null, 
			string m3_PRR1 = null, 
			string m3_PRR2 = null, 
			string m3_PRR3 = null, 
			string m3_PRR4 = null, 
			string m3_PRR5 = null, 
			string m3_SPRL = null, 
			string m3_LNCD = null, 
			decimal? m3_CFI2 = null, 
			int? m3_AICD = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			int? m3_ACDY = null, 
			string m3_AREF = null, 
			string m3_OREF = null, 
			string m3_YREF = null, 
			int? m3_AMTN = null, 
			int? m3_NPAM = null, 
			string m3_PERA = null, 
			int? m3_ROPP = null, 
			int? m3_ACT9 = null, 
			int? m3_ACRG = null, 
			string m3_MODL = null, 
			string m3_TEDL = null, 
			string m3_TEPY = null, 
			string m3_TEPA = null, 
			string m3_TEAF = null, 
			string m3_PLTB = null, 
			string m3_DISY = null, 
			int? m3_APR1 = null, 
			int? m3_AMHC = null, 
			int? m3_AEHA = null, 
			int? m3_AMHA = null, 
			int? m3_ASHA = null, 
			int? m3_AAOG = null, 
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
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("TODT", m3_TODT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TAGR))
				request.WithQueryParameter("TAGR", m3_TAGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AAGT))
				request.WithQueryParameter("AAGT", m3_AAGT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AAGN))
				request.WithQueryParameter("AAGN", m3_AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX30))
				request.WithQueryParameter("TX30", m3_TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AMCU))
				request.WithQueryParameter("AMCU", m3_AMCU.Trim());
			if (m3_CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3_CRTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AACU))
				request.WithQueryParameter("AACU", m3_AACU.Trim());
			if (m3_CRTA.HasValue)
				request.WithQueryParameter("CRTA", m3_CRTA.Value.ToString());
			if (m3_ACSE.HasValue)
				request.WithQueryParameter("ACSE", m3_ACSE.Value.ToString());
			if (m3_AMRE.HasValue)
				request.WithQueryParameter("AMRE", m3_AMRE.Value.ToString());
			if (m3_AMOD.HasValue)
				request.WithQueryParameter("AMOD", m3_AMOD.Value.ToString());
			if (m3_RIUS.HasValue)
				request.WithQueryParameter("RIUS", m3_RIUS.Value.ToString());
			if (m3_AISP.HasValue)
				request.WithQueryParameter("AISP", m3_AISP.Value.ToString());
			if (m3_SNRC.HasValue)
				request.WithQueryParameter("SNRC", m3_SNRC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AOTY))
				request.WithQueryParameter("AOTY", m3_AOTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PIOT))
				request.WithQueryParameter("PIOT", m3_PIOT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INVM))
				request.WithQueryParameter("INVM", m3_INVM.Trim());
			if (m3_APBA.HasValue)
				request.WithQueryParameter("APBA", m3_APBA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRMS))
				request.WithQueryParameter("PRMS", m3_PRMS.Trim());
			if (m3_AHCM.HasValue)
				request.WithQueryParameter("AHCM", m3_AHCM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRR1))
				request.WithQueryParameter("PRR1", m3_PRR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRR2))
				request.WithQueryParameter("PRR2", m3_PRR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRR3))
				request.WithQueryParameter("PRR3", m3_PRR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRR4))
				request.WithQueryParameter("PRR4", m3_PRR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRR5))
				request.WithQueryParameter("PRR5", m3_PRR5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPRL))
				request.WithQueryParameter("SPRL", m3_SPRL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (m3_CFI2.HasValue)
				request.WithQueryParameter("CFI2", m3_CFI2.Value.ToString());
			if (m3_AICD.HasValue)
				request.WithQueryParameter("AICD", m3_AICD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (m3_ACDY.HasValue)
				request.WithQueryParameter("ACDY", m3_ACDY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AREF))
				request.WithQueryParameter("AREF", m3_AREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OREF))
				request.WithQueryParameter("OREF", m3_OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (m3_AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3_AMTN.Value.ToString());
			if (m3_NPAM.HasValue)
				request.WithQueryParameter("NPAM", m3_NPAM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PERA))
				request.WithQueryParameter("PERA", m3_PERA.Trim());
			if (m3_ROPP.HasValue)
				request.WithQueryParameter("ROPP", m3_ROPP.Value.ToString());
			if (m3_ACT9.HasValue)
				request.WithQueryParameter("ACT9", m3_ACT9.Value.ToString());
			if (m3_ACRG.HasValue)
				request.WithQueryParameter("ACRG", m3_ACRG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEAF))
				request.WithQueryParameter("TEAF", m3_TEAF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLTB))
				request.WithQueryParameter("PLTB", m3_PLTB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DISY))
				request.WithQueryParameter("DISY", m3_DISY.Trim());
			if (m3_APR1.HasValue)
				request.WithQueryParameter("APR1", m3_APR1.Value.ToString());
			if (m3_AMHC.HasValue)
				request.WithQueryParameter("AMHC", m3_AMHC.Value.ToString());
			if (m3_AEHA.HasValue)
				request.WithQueryParameter("AEHA", m3_AEHA.Value.ToString());
			if (m3_AMHA.HasValue)
				request.WithQueryParameter("AMHA", m3_AMHA.Value.ToString());
			if (m3_ASHA.HasValue)
				request.WithQueryParameter("ASHA", m3_ASHA.Value.ToString());
			if (m3_AAOG.HasValue)
				request.WithQueryParameter("AAOG", m3_AAOG.Value.ToString());

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
		/// Name DltAgrCharges
		/// Description Delete agreeent - charges
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_AAGN">Agreement (Required)</param>
		/// <param name="m3_CRID">Charge (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAgrCharges(
			string m3_AAGN, 
			string m3_CRID, 
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
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");
			if (string.IsNullOrWhiteSpace(m3_CRID))
				throw new ArgumentNullException("m3_CRID");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim())
				.WithQueryParameter("CRID", m3_CRID.Trim());

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
		/// Name DltAgrLines
		/// Description Delete agreement - lines
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_AAGN">Agreement (Required)</param>
		/// <param name="m3_SRVP">Service price method (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAgrLines(
			string m3_AAGN, 
			int m3_SRVP, 
			DateTime m3_STDT, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
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
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim())
				.WithQueryParameter("SRVP", m3_SRVP.ToString())
				.WithQueryParameter("STDT", m3_STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());

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
		/// Name DltAgrObjects
		/// Description Delete agreement - objects
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_AAGN">Agreement (Required)</param>
		/// <param name="m3_PRNO">Product (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_TODT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAgrObjects(
			string m3_AAGN, 
			string m3_PRNO, 
			DateTime m3_STDT, 
			string m3_BANO = null, 
			DateTime? m3_TODT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());

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
		/// Name DltAgreement
		/// Description Delete agreement
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_AAGN">Agreement (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAgreement(
			string m3_AAGN, 
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
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim());

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
		/// Name GetAgrCharges
		/// Description Get agreement - charges
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_AAGN">Agreement (Required)</param>
		/// <param name="m3_CRID">Charge (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgrChargesResponse></returns>
		/// <exception cref="M3Exception<GetAgrChargesResponse>"></exception>
		public async Task<M3Response<GetAgrChargesResponse>> GetAgrCharges(
			string m3_AAGN, 
			string m3_CRID, 
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
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");
			if (string.IsNullOrWhiteSpace(m3_CRID))
				throw new ArgumentNullException("m3_CRID");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim())
				.WithQueryParameter("CRID", m3_CRID.Trim());

			// Execute the request
			var result = await Execute<GetAgrChargesResponse>(
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
		/// Name GetAgrLines
		/// Description Get agreement - lines
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_AAGN">Agreement (Required)</param>
		/// <param name="m3_SRVP">Service price method (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgrLinesResponse></returns>
		/// <exception cref="M3Exception<GetAgrLinesResponse>"></exception>
		public async Task<M3Response<GetAgrLinesResponse>> GetAgrLines(
			string m3_AAGN, 
			int m3_SRVP, 
			DateTime m3_STDT, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
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
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim())
				.WithQueryParameter("SRVP", m3_SRVP.ToString())
				.WithQueryParameter("STDT", m3_STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());

			// Execute the request
			var result = await Execute<GetAgrLinesResponse>(
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
		/// Name GetAgrObjects
		/// Description Get agreement - objects
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_AAGN">Agreement (Required)</param>
		/// <param name="m3_PRNO">Product (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_TODT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgrObjectsResponse></returns>
		/// <exception cref="M3Exception<GetAgrObjectsResponse>"></exception>
		public async Task<M3Response<GetAgrObjectsResponse>> GetAgrObjects(
			string m3_AAGN, 
			string m3_PRNO, 
			DateTime m3_STDT, 
			string m3_BANO = null, 
			DateTime? m3_TODT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetAgrObjectsResponse>(
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
		/// Name GetAgreement
		/// Description Get agreement
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_AAGN">Agreement (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgreementResponse></returns>
		/// <exception cref="M3Exception<GetAgreementResponse>"></exception>
		public async Task<M3Response<GetAgreementResponse>> GetAgreement(
			string m3_AAGN, 
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
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim());

			// Execute the request
			var result = await Execute<GetAgreementResponse>(
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
		/// Name LstAgrCharges
		/// Description List agreement - charges
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_AAGN">Agreement (Required)</param>
		/// <param name="m3_CRID">Charge</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrChargesResponse></returns>
		/// <exception cref="M3Exception<LstAgrChargesResponse>"></exception>
		public async Task<M3Response<LstAgrChargesResponse>> LstAgrCharges(
			string m3_AAGN, 
			string m3_CRID = null, 
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
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CRID))
				request.WithQueryParameter("CRID", m3_CRID.Trim());

			// Execute the request
			var result = await Execute<LstAgrChargesResponse>(
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
		/// Name LstAgrLines
		/// Description List agreement - lines
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_AAGN">Agreement (Required)</param>
		/// <param name="m3_SRVP">Service price method</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrLinesResponse></returns>
		/// <exception cref="M3Exception<LstAgrLinesResponse>"></exception>
		public async Task<M3Response<LstAgrLinesResponse>> LstAgrLines(
			string m3_AAGN, 
			int? m3_SRVP = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			DateTime? m3_STDT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_SRVP.HasValue)
				request.WithQueryParameter("SRVP", m3_SRVP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstAgrLinesResponse>(
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
		/// Name LstAgrObjects
		/// Description List agreement - objects
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_AAGN">Agreement (Required)</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_TODT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrObjectsResponse></returns>
		/// <exception cref="M3Exception<LstAgrObjectsResponse>"></exception>
		public async Task<M3Response<LstAgrObjectsResponse>> LstAgrObjects(
			string m3_AAGN, 
			string m3_PRNO = null, 
			string m3_BANO = null, 
			DateTime? m3_STDT = null, 
			DateTime? m3_TODT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstAgrObjectsResponse>(
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
		/// Name LstAgreement
		/// Description List agreement
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_AAGN">Agreement</param>
		/// <param name="m3_AAGT">Agreement type</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgreementResponse></returns>
		/// <exception cref="M3Exception<LstAgreementResponse>"></exception>
		public async Task<M3Response<LstAgreementResponse>> LstAgreement(
			string m3_AAGN = null, 
			string m3_AAGT = null, 
			string m3_CUNO = null, 
			string m3_FACI = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_AAGN))
				request.WithQueryParameter("AAGN", m3_AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AAGT))
				request.WithQueryParameter("AAGT", m3_AAGT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());

			// Execute the request
			var result = await Execute<LstAgreementResponse>(
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
		/// Name UpdAgrCharges
		/// Description Update agreement - charges
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_AAGN">Agreement (Required)</param>
		/// <param name="m3_CRID">Charge (Required)</param>
		/// <param name="m3_CRAA">Charge</param>
		/// <param name="m3_VTCD">VAT code</param>
		/// <param name="m3_HACD">Debit frequency</param>
		/// <param name="m3_CRD0">Description</param>
		/// <param name="m3_TAXC">Tax code customer/address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAgrCharges(
			string m3_AAGN, 
			string m3_CRID, 
			decimal? m3_CRAA = null, 
			int? m3_VTCD = null, 
			int? m3_HACD = null, 
			string m3_CRD0 = null, 
			string m3_TAXC = null, 
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
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");
			if (string.IsNullOrWhiteSpace(m3_CRID))
				throw new ArgumentNullException("m3_CRID");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim())
				.WithQueryParameter("CRID", m3_CRID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CRAA.HasValue)
				request.WithQueryParameter("CRAA", m3_CRAA.Value.ToString());
			if (m3_VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3_VTCD.Value.ToString());
			if (m3_HACD.HasValue)
				request.WithQueryParameter("HACD", m3_HACD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CRD0))
				request.WithQueryParameter("CRD0", m3_CRD0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAXC))
				request.WithQueryParameter("TAXC", m3_TAXC.Trim());

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
		/// Name UpdAgrLines
		/// Description Update agreement - lines
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_AAGN">Agreement (Required)</param>
		/// <param name="m3_SRVP">Service price method (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_TODT">To date</param>
		/// <param name="m3_PRTX">Text</param>
		/// <param name="m3_LEAS">Lead time - service</param>
		/// <param name="m3_MES0">Meter</param>
		/// <param name="m3_WAL1">Warranty limit 1</param>
		/// <param name="m3_MES1">Meter 1</param>
		/// <param name="m3_WAL2">Warranty limit 2</param>
		/// <param name="m3_MES2">Meter 2</param>
		/// <param name="m3_WAL3">Warranty limit 3</param>
		/// <param name="m3_MES3">Meter 3</param>
		/// <param name="m3_WAL4">Warranty limit 4</param>
		/// <param name="m3_MES4">Meter 4</param>
		/// <param name="m3_AINX">Index</param>
		/// <param name="m3_AMVI">Maximum material value per item</param>
		/// <param name="m3_AMAM">Maximum material cost</param>
		/// <param name="m3_AMPI">Max material price per transaction</param>
		/// <param name="m3_AMAL">Maximum labor cost</param>
		/// <param name="m3_AMM1">Max material price per order</param>
		/// <param name="m3_AMLL">Minimum hours per line</param>
		/// <param name="m3_AEXC">Exclude / include material</param>
		/// <param name="m3_AMLJ">Minimum labor hours per job ID</param>
		/// <param name="m3_AMLO">Minimum hours per order</param>
		/// <param name="m3_AMIL">Minimum material cost/line</param>
		/// <param name="m3_AMIO">Minimum material cost/order</param>
		/// <param name="m3_AMSL">Minimum subcontract charge per line</param>
		/// <param name="m3_AMSO">Minimum subcontract charge per order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAgrLines(
			string m3_AAGN, 
			int m3_SRVP, 
			DateTime m3_STDT, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			DateTime? m3_TODT = null, 
			string m3_PRTX = null, 
			int? m3_LEAS = null, 
			string m3_MES0 = null, 
			decimal? m3_WAL1 = null, 
			string m3_MES1 = null, 
			decimal? m3_WAL2 = null, 
			string m3_MES2 = null, 
			decimal? m3_WAL3 = null, 
			string m3_MES3 = null, 
			decimal? m3_WAL4 = null, 
			string m3_MES4 = null, 
			int? m3_AINX = null, 
			decimal? m3_AMVI = null, 
			decimal? m3_AMAM = null, 
			decimal? m3_AMPI = null, 
			decimal? m3_AMAL = null, 
			decimal? m3_AMM1 = null, 
			decimal? m3_AMLL = null, 
			int? m3_AEXC = null, 
			decimal? m3_AMLJ = null, 
			decimal? m3_AMLO = null, 
			decimal? m3_AMIL = null, 
			decimal? m3_AMIO = null, 
			decimal? m3_AMSL = null, 
			decimal? m3_AMSO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim())
				.WithQueryParameter("SRVP", m3_SRVP.ToString())
				.WithQueryParameter("STDT", m3_STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PRTX))
				request.WithQueryParameter("PRTX", m3_PRTX.Trim());
			if (m3_LEAS.HasValue)
				request.WithQueryParameter("LEAS", m3_LEAS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MES0))
				request.WithQueryParameter("MES0", m3_MES0.Trim());
			if (m3_WAL1.HasValue)
				request.WithQueryParameter("WAL1", m3_WAL1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MES1))
				request.WithQueryParameter("MES1", m3_MES1.Trim());
			if (m3_WAL2.HasValue)
				request.WithQueryParameter("WAL2", m3_WAL2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MES2))
				request.WithQueryParameter("MES2", m3_MES2.Trim());
			if (m3_WAL3.HasValue)
				request.WithQueryParameter("WAL3", m3_WAL3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MES3))
				request.WithQueryParameter("MES3", m3_MES3.Trim());
			if (m3_WAL4.HasValue)
				request.WithQueryParameter("WAL4", m3_WAL4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MES4))
				request.WithQueryParameter("MES4", m3_MES4.Trim());
			if (m3_AINX.HasValue)
				request.WithQueryParameter("AINX", m3_AINX.Value.ToString());
			if (m3_AMVI.HasValue)
				request.WithQueryParameter("AMVI", m3_AMVI.Value.ToString());
			if (m3_AMAM.HasValue)
				request.WithQueryParameter("AMAM", m3_AMAM.Value.ToString());
			if (m3_AMPI.HasValue)
				request.WithQueryParameter("AMPI", m3_AMPI.Value.ToString());
			if (m3_AMAL.HasValue)
				request.WithQueryParameter("AMAL", m3_AMAL.Value.ToString());
			if (m3_AMM1.HasValue)
				request.WithQueryParameter("AMM1", m3_AMM1.Value.ToString());
			if (m3_AMLL.HasValue)
				request.WithQueryParameter("AMLL", m3_AMLL.Value.ToString());
			if (m3_AEXC.HasValue)
				request.WithQueryParameter("AEXC", m3_AEXC.Value.ToString());
			if (m3_AMLJ.HasValue)
				request.WithQueryParameter("AMLJ", m3_AMLJ.Value.ToString());
			if (m3_AMLO.HasValue)
				request.WithQueryParameter("AMLO", m3_AMLO.Value.ToString());
			if (m3_AMIL.HasValue)
				request.WithQueryParameter("AMIL", m3_AMIL.Value.ToString());
			if (m3_AMIO.HasValue)
				request.WithQueryParameter("AMIO", m3_AMIO.Value.ToString());
			if (m3_AMSL.HasValue)
				request.WithQueryParameter("AMSL", m3_AMSL.Value.ToString());
			if (m3_AMSO.HasValue)
				request.WithQueryParameter("AMSO", m3_AMSO.Value.ToString());

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
		/// Name UpdAgrObjects
		/// Description Update agreement - objects
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_AAGN">Agreement (Required)</param>
		/// <param name="m3_PRNO">Product (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_TODT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAgrObjects(
			string m3_AAGN, 
			string m3_PRNO, 
			DateTime m3_STDT, 
			string m3_BANO = null, 
			DateTime? m3_TODT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());

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
		/// Name UpdAgreement
		/// Description Update agreement
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_AAGN">Agreement (Required)</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_TX30">Text</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_TODT">To date</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_AMCU">Material currency</param>
		/// <param name="m3_CRTM">Critical material</param>
		/// <param name="m3_AACU">Agreement currency</param>
		/// <param name="m3_CRTA">Exchange rate type</param>
		/// <param name="m3_ACSE">Serial number administration</param>
		/// <param name="m3_AMRE">Maximum repair cost</param>
		/// <param name="m3_AMOD">Modification</param>
		/// <param name="m3_RIUS">Removal/installation update invoice spec</param>
		/// <param name="m3_AISP">Invoice specification layout</param>
		/// <param name="m3_SNRC">Serial number return code</param>
		/// <param name="m3_AOTY">Order type</param>
		/// <param name="m3_PIOT">Periodic invoice order type</param>
		/// <param name="m3_INVM">Invoicing method</param>
		/// <param name="m3_APBA">Material price method</param>
		/// <param name="m3_PRMS">Price origin sequence</param>
		/// <param name="m3_AHCM">Material handling charge method</param>
		/// <param name="m3_PRR1">Price list 1</param>
		/// <param name="m3_PRR2">Price list 2</param>
		/// <param name="m3_PRR3">Price list 3</param>
		/// <param name="m3_PRR4">Price list 4</param>
		/// <param name="m3_PRR5">Price list 5</param>
		/// <param name="m3_SPRL">Service price list</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_CFI2">User-defined field 2 - item</param>
		/// <param name="m3_AICD">Summary invoice</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_ACDY">Agreement cancellation - days notice</param>
		/// <param name="m3_AREF">External reference</param>
		/// <param name="m3_OREF">Our reference</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_AMTN">Curve</param>
		/// <param name="m3_NPAM">Number of periods</param>
		/// <param name="m3_PERA">Period accounting</param>
		/// <param name="m3_ROPP">Rounding-off category</param>
		/// <param name="m3_ACT9">Check scope of agreement - object</param>
		/// <param name="m3_ACRG">Check scope of agreement - model indiv</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TEDL">Delivery terms</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_TEPA">Packaging terms</param>
		/// <param name="m3_TEAF">Freight terms</param>
		/// <param name="m3_PLTB">Price list table</param>
		/// <param name="m3_DISY">Discount model</param>
		/// <param name="m3_APR1">Used material price discount</param>
		/// <param name="m3_AMHC">Handling charge customer-owned items</param>
		/// <param name="m3_AEHA">Percent new material price - exchange</param>
		/// <param name="m3_AMHA">General handling charge</param>
		/// <param name="m3_ASHA">Subcontract handling charge</param>
		/// <param name="m3_AAOG">Priority markup</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAgreement(
			string m3_AAGN, 
			string m3_FACI = null, 
			string m3_PYNO = null, 
			string m3_STAT = null, 
			string m3_TX30 = null, 
			DateTime? m3_STDT = null, 
			DateTime? m3_TODT = null, 
			string m3_WHLO = null, 
			string m3_RESP = null, 
			string m3_AMCU = null, 
			int? m3_CRTM = null, 
			string m3_AACU = null, 
			int? m3_CRTA = null, 
			int? m3_ACSE = null, 
			int? m3_AMRE = null, 
			int? m3_AMOD = null, 
			int? m3_RIUS = null, 
			int? m3_AISP = null, 
			int? m3_SNRC = null, 
			string m3_AOTY = null, 
			string m3_PIOT = null, 
			string m3_INVM = null, 
			int? m3_APBA = null, 
			string m3_PRMS = null, 
			int? m3_AHCM = null, 
			string m3_PRR1 = null, 
			string m3_PRR2 = null, 
			string m3_PRR3 = null, 
			string m3_PRR4 = null, 
			string m3_PRR5 = null, 
			string m3_SPRL = null, 
			string m3_LNCD = null, 
			decimal? m3_CFI2 = null, 
			int? m3_AICD = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			int? m3_ACDY = null, 
			string m3_AREF = null, 
			string m3_OREF = null, 
			string m3_YREF = null, 
			int? m3_AMTN = null, 
			int? m3_NPAM = null, 
			string m3_PERA = null, 
			int? m3_ROPP = null, 
			int? m3_ACT9 = null, 
			int? m3_ACRG = null, 
			string m3_MODL = null, 
			string m3_TEDL = null, 
			string m3_TEPY = null, 
			string m3_TEPA = null, 
			string m3_TEAF = null, 
			string m3_PLTB = null, 
			string m3_DISY = null, 
			int? m3_APR1 = null, 
			int? m3_AMHC = null, 
			int? m3_AEHA = null, 
			int? m3_AMHA = null, 
			int? m3_ASHA = null, 
			int? m3_AAOG = null, 
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
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX30))
				request.WithQueryParameter("TX30", m3_TX30.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AMCU))
				request.WithQueryParameter("AMCU", m3_AMCU.Trim());
			if (m3_CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3_CRTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AACU))
				request.WithQueryParameter("AACU", m3_AACU.Trim());
			if (m3_CRTA.HasValue)
				request.WithQueryParameter("CRTA", m3_CRTA.Value.ToString());
			if (m3_ACSE.HasValue)
				request.WithQueryParameter("ACSE", m3_ACSE.Value.ToString());
			if (m3_AMRE.HasValue)
				request.WithQueryParameter("AMRE", m3_AMRE.Value.ToString());
			if (m3_AMOD.HasValue)
				request.WithQueryParameter("AMOD", m3_AMOD.Value.ToString());
			if (m3_RIUS.HasValue)
				request.WithQueryParameter("RIUS", m3_RIUS.Value.ToString());
			if (m3_AISP.HasValue)
				request.WithQueryParameter("AISP", m3_AISP.Value.ToString());
			if (m3_SNRC.HasValue)
				request.WithQueryParameter("SNRC", m3_SNRC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AOTY))
				request.WithQueryParameter("AOTY", m3_AOTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PIOT))
				request.WithQueryParameter("PIOT", m3_PIOT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INVM))
				request.WithQueryParameter("INVM", m3_INVM.Trim());
			if (m3_APBA.HasValue)
				request.WithQueryParameter("APBA", m3_APBA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRMS))
				request.WithQueryParameter("PRMS", m3_PRMS.Trim());
			if (m3_AHCM.HasValue)
				request.WithQueryParameter("AHCM", m3_AHCM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRR1))
				request.WithQueryParameter("PRR1", m3_PRR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRR2))
				request.WithQueryParameter("PRR2", m3_PRR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRR3))
				request.WithQueryParameter("PRR3", m3_PRR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRR4))
				request.WithQueryParameter("PRR4", m3_PRR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRR5))
				request.WithQueryParameter("PRR5", m3_PRR5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPRL))
				request.WithQueryParameter("SPRL", m3_SPRL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (m3_CFI2.HasValue)
				request.WithQueryParameter("CFI2", m3_CFI2.Value.ToString());
			if (m3_AICD.HasValue)
				request.WithQueryParameter("AICD", m3_AICD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (m3_ACDY.HasValue)
				request.WithQueryParameter("ACDY", m3_ACDY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AREF))
				request.WithQueryParameter("AREF", m3_AREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OREF))
				request.WithQueryParameter("OREF", m3_OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (m3_AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3_AMTN.Value.ToString());
			if (m3_NPAM.HasValue)
				request.WithQueryParameter("NPAM", m3_NPAM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PERA))
				request.WithQueryParameter("PERA", m3_PERA.Trim());
			if (m3_ROPP.HasValue)
				request.WithQueryParameter("ROPP", m3_ROPP.Value.ToString());
			if (m3_ACT9.HasValue)
				request.WithQueryParameter("ACT9", m3_ACT9.Value.ToString());
			if (m3_ACRG.HasValue)
				request.WithQueryParameter("ACRG", m3_ACRG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEAF))
				request.WithQueryParameter("TEAF", m3_TEAF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLTB))
				request.WithQueryParameter("PLTB", m3_PLTB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DISY))
				request.WithQueryParameter("DISY", m3_DISY.Trim());
			if (m3_APR1.HasValue)
				request.WithQueryParameter("APR1", m3_APR1.Value.ToString());
			if (m3_AMHC.HasValue)
				request.WithQueryParameter("AMHC", m3_AMHC.Value.ToString());
			if (m3_AEHA.HasValue)
				request.WithQueryParameter("AEHA", m3_AEHA.Value.ToString());
			if (m3_AMHA.HasValue)
				request.WithQueryParameter("AMHA", m3_AMHA.Value.ToString());
			if (m3_ASHA.HasValue)
				request.WithQueryParameter("ASHA", m3_ASHA.Value.ToString());
			if (m3_AAOG.HasValue)
				request.WithQueryParameter("AAOG", m3_AAOG.Value.ToString());

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
