/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.OIS840MI;
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
	/// Name: OIS840MI
	/// Component Name: Promotion
	/// Description: Promotion API
	/// Version Release: 14.x
	///</summary>
	public partial class OIS840MIResource : M3BaseResourceEndpoint
	{
		public OIS840MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS840MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddPromCust
		/// Description Add Promotion Customer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PIDE">Promotion (Required)</param>
		/// <param name="m3_CUNO">Customer (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPromCust(
			string m3_DIVI, 
			string m3_PIDE, 
			string m3_CUNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPromCust",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PIDE))
				throw new ArgumentNullException("m3_PIDE");
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PIDE", m3_PIDE.Trim())
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name AddPromHead
		/// Description Add Promotion Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PIDE">Promotion (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_PTPE">Promotion Type (Required)</param>
		/// <param name="m3_PRES">Promotion responsible (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_LVDT">Valid To (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_PTER">Promotion Term (Required)</param>
		/// <param name="m3_PPT1">Promotion statistics period type 1 (Required)</param>
		/// <param name="m3_PPT2">Promotion statistics period type 2 (Required)</param>
		/// <param name="m3_UPPC">Update Promotion (Required)</param>
		/// <param name="m3_DIBE">Discount Base (Required)</param>
		/// <param name="m3_DDSU">Discount presentation (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SCMO">Costing sales model</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_FRD2">Activity start date</param>
		/// <param name="m3_TOD2">Activity end date</param>
		/// <param name="m3_ACUS">Activity customer</param>
		/// <param name="m3_BUFC">Budgeted fixed cost</param>
		/// <param name="m3_ACFC">Actual fixed cost</param>
		/// <param name="m3_DIMI">Distribution method</param>
		/// <param name="m3_TX08">Additional text</param>
		/// <param name="m3_DIRE">Discount relation</param>
		/// <param name="m3_DCHA">Manually changeable discount</param>
		/// <param name="m3_IDSC">Internal discount</param>
		/// <param name="m3_ACRF">User defined accounting</param>
		/// <param name="m3_ACGR">Object access group</param>
		/// <param name="m3_BNCD">Bonus generating</param>
		/// <param name="m3_PRAC">Commission generating</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_CLMT">Claim calculation method</param>
		/// <param name="m3_SCLP">SPA claim percentage</param>
		/// <param name="m3_DISP">Discount percentage</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_PRI2">Priority</param>
		/// <param name="m3_PSUP">Propose supplier</param>
		/// <param name="m3_PRR1">Price list 1</param>
		/// <param name="m3_CUC1">Currency code 1</param>
		/// <param name="m3_LFL1">Label flag 1</param>
		/// <param name="m3_PRRF">Price list</param>
		/// <param name="m3_OTYG">Order type group</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_TAID">Table</param>
		/// <param name="m3_CHAI">Business chain</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHTA">Warehouse table</param>
		/// <param name="m3_INIS">Initial start</param>
		/// <param name="m3_INIE">Initial end</param>
		/// <param name="m3_ANIN">Auto retrieval of promotion</param>
		/// <param name="m3_HOIN">Hold Initial order</param>
		/// <param name="m3_SCPO">Supply chain policy</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_BOOV">Automatic closing override</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPromHead(
			string m3_DIVI, 
			string m3_PIDE, 
			string m3_TX40, 
			string m3_PTPE, 
			string m3_PRES, 
			DateTime m3_FVDT, 
			DateTime m3_LVDT, 
			string m3_CUCD, 
			int m3_PTER, 
			int m3_PPT1, 
			int m3_PPT2, 
			int m3_UPPC, 
			string m3_DIBE, 
			int m3_DDSU, 
			int? m3_CONO = null, 
			string m3_SCMO = null, 
			string m3_TX15 = null, 
			int? m3_FRD2 = null, 
			int? m3_TOD2 = null, 
			string m3_ACUS = null, 
			decimal? m3_BUFC = null, 
			decimal? m3_ACFC = null, 
			int? m3_DIMI = null, 
			string m3_TX08 = null, 
			string m3_DIRE = null, 
			int? m3_DCHA = null, 
			int? m3_IDSC = null, 
			string m3_ACRF = null, 
			string m3_ACGR = null, 
			int? m3_BNCD = null, 
			int? m3_PRAC = null, 
			string m3_SUNO = null, 
			int? m3_CLMT = null, 
			int? m3_SCLP = null, 
			int? m3_DISP = null, 
			string m3_AGNB = null, 
			string m3_TEPY = null, 
			int? m3_PRI2 = null, 
			int? m3_PSUP = null, 
			string m3_PRR1 = null, 
			string m3_CUC1 = null, 
			string m3_LFL1 = null, 
			string m3_PRRF = null, 
			string m3_OTYG = null, 
			string m3_CUNO = null, 
			string m3_TAID = null, 
			string m3_CHAI = null, 
			string m3_WHLO = null, 
			string m3_WHTA = null, 
			DateTime? m3_INIS = null, 
			DateTime? m3_INIE = null, 
			DateTime? m3_ANIN = null, 
			int? m3_HOIN = null, 
			string m3_SCPO = null, 
			string m3_ORTY = null, 
			int? m3_BOOV = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPromHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PIDE))
				throw new ArgumentNullException("m3_PIDE");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");
			if (string.IsNullOrWhiteSpace(m3_PTPE))
				throw new ArgumentNullException("m3_PTPE");
			if (string.IsNullOrWhiteSpace(m3_PRES))
				throw new ArgumentNullException("m3_PRES");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_DIBE))
				throw new ArgumentNullException("m3_DIBE");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PIDE", m3_PIDE.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim())
				.WithQueryParameter("PTPE", m3_PTPE.Trim())
				.WithQueryParameter("PRES", m3_PRES.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String())
				.WithQueryParameter("LVDT", m3_LVDT.ToM3String())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("PTER", m3_PTER.ToString())
				.WithQueryParameter("PPT1", m3_PPT1.ToString())
				.WithQueryParameter("PPT2", m3_PPT2.ToString())
				.WithQueryParameter("UPPC", m3_UPPC.ToString())
				.WithQueryParameter("DIBE", m3_DIBE.Trim())
				.WithQueryParameter("DDSU", m3_DDSU.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCMO))
				request.WithQueryParameter("SCMO", m3_SCMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_FRD2.HasValue)
				request.WithQueryParameter("FRD2", m3_FRD2.Value.ToString());
			if (m3_TOD2.HasValue)
				request.WithQueryParameter("TOD2", m3_TOD2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACUS))
				request.WithQueryParameter("ACUS", m3_ACUS.Trim());
			if (m3_BUFC.HasValue)
				request.WithQueryParameter("BUFC", m3_BUFC.Value.ToString());
			if (m3_ACFC.HasValue)
				request.WithQueryParameter("ACFC", m3_ACFC.Value.ToString());
			if (m3_DIMI.HasValue)
				request.WithQueryParameter("DIMI", m3_DIMI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX08))
				request.WithQueryParameter("TX08", m3_TX08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIRE))
				request.WithQueryParameter("DIRE", m3_DIRE.Trim());
			if (m3_DCHA.HasValue)
				request.WithQueryParameter("DCHA", m3_DCHA.Value.ToString());
			if (m3_IDSC.HasValue)
				request.WithQueryParameter("IDSC", m3_IDSC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACGR))
				request.WithQueryParameter("ACGR", m3_ACGR.Trim());
			if (m3_BNCD.HasValue)
				request.WithQueryParameter("BNCD", m3_BNCD.Value.ToString());
			if (m3_PRAC.HasValue)
				request.WithQueryParameter("PRAC", m3_PRAC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_CLMT.HasValue)
				request.WithQueryParameter("CLMT", m3_CLMT.Value.ToString());
			if (m3_SCLP.HasValue)
				request.WithQueryParameter("SCLP", m3_SCLP.Value.ToString());
			if (m3_DISP.HasValue)
				request.WithQueryParameter("DISP", m3_DISP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (m3_PRI2.HasValue)
				request.WithQueryParameter("PRI2", m3_PRI2.Value.ToString());
			if (m3_PSUP.HasValue)
				request.WithQueryParameter("PSUP", m3_PSUP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRR1))
				request.WithQueryParameter("PRR1", m3_PRR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUC1))
				request.WithQueryParameter("CUC1", m3_CUC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LFL1))
				request.WithQueryParameter("LFL1", m3_LFL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRRF))
				request.WithQueryParameter("PRRF", m3_PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OTYG))
				request.WithQueryParameter("OTYG", m3_OTYG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAID))
				request.WithQueryParameter("TAID", m3_TAID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHAI))
				request.WithQueryParameter("CHAI", m3_CHAI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHTA))
				request.WithQueryParameter("WHTA", m3_WHTA.Trim());
			if (m3_INIS.HasValue)
				request.WithQueryParameter("INIS", m3_INIS.Value.ToM3String());
			if (m3_INIE.HasValue)
				request.WithQueryParameter("INIE", m3_INIE.Value.ToM3String());
			if (m3_ANIN.HasValue)
				request.WithQueryParameter("ANIN", m3_ANIN.Value.ToM3String());
			if (m3_HOIN.HasValue)
				request.WithQueryParameter("HOIN", m3_HOIN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCPO))
				request.WithQueryParameter("SCPO", m3_SCPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (m3_BOOV.HasValue)
				request.WithQueryParameter("BOOV", m3_BOOV.Value.ToString());

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
		/// Name AddPromLine
		/// Description Add Promotion Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PIDE">Promotion (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SAPR">Sales price (Required)</param>
		/// <param name="m3_SACD">Sales price quantity (Required)</param>
		/// <param name="m3_DIAM">Discount amount (Required)</param>
		/// <param name="m3_DISP">Discount percentage (Required)</param>
		/// <param name="m3_SPUN">Sales price unit of measure (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_BUFC">Budgeted fixed cost</param>
		/// <param name="m3_ACFC">Actual fixed cost</param>
		/// <param name="m3_ITNR">Item number</param>
		/// <param name="m3_ORQT">Ordered quantity-basic U/M</param>
		/// <param name="m3_SAPX">Sales price</param>
		/// <param name="m3_BUQT">Budget quantity</param>
		/// <param name="m3_BUAM">Budget amount</param>
		/// <param name="m3_SPLC">Delivery split rule</param>
		/// <param name="m3_BNCD">Bonus generation</param>
		/// <param name="m3_PRAC">commission generating</param>
		/// <param name="m3_DEFC">Demand factor</param>
		/// <param name="m3_BCPR">Budgeted cost</param>
		/// <param name="m3_ACPI">Actual cost</param>
		/// <param name="m3_IVSH">Affected volume percentage</param>
		/// <param name="m3_AVSH">Actual volume percentage</param>
		/// <param name="m3_SOAM">Sold amount</param>
		/// <param name="m3_SOQT">Sold quantity</param>
		/// <param name="m3_SGGU">Scale unit of measure</param>
		/// <param name="m3_SCLA">SPA claim</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_SCLP">SPA claim percentage</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_LIMT">Limit value</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_BOOV">Automatic closing override</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPromLine(
			string m3_DIVI, 
			string m3_PIDE, 
			string m3_ITNO, 
			decimal m3_SAPR, 
			int m3_SACD, 
			decimal m3_DIAM, 
			decimal m3_DISP, 
			string m3_SPUN, 
			int? m3_CONO = null, 
			decimal? m3_BUFC = null, 
			decimal? m3_ACFC = null, 
			string m3_ITNR = null, 
			decimal? m3_ORQT = null, 
			decimal? m3_SAPX = null, 
			decimal? m3_BUQT = null, 
			decimal? m3_BUAM = null, 
			string m3_SPLC = null, 
			int? m3_BNCD = null, 
			int? m3_PRAC = null, 
			int? m3_DEFC = null, 
			decimal? m3_BCPR = null, 
			decimal? m3_ACPI = null, 
			int? m3_IVSH = null, 
			int? m3_AVSH = null, 
			decimal? m3_SOAM = null, 
			decimal? m3_SOQT = null, 
			string m3_SGGU = null, 
			decimal? m3_SCLA = null, 
			string m3_SUNO = null, 
			string m3_TEPY = null, 
			int? m3_SCLP = null, 
			string m3_AGNB = null, 
			decimal? m3_LIMT = null, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_LVDT = null, 
			int? m3_BOOV = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPromLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PIDE))
				throw new ArgumentNullException("m3_PIDE");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SPUN))
				throw new ArgumentNullException("m3_SPUN");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PIDE", m3_PIDE.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SAPR", m3_SAPR.ToString())
				.WithQueryParameter("SACD", m3_SACD.ToString())
				.WithQueryParameter("DIAM", m3_DIAM.ToString())
				.WithQueryParameter("DISP", m3_DISP.ToString())
				.WithQueryParameter("SPUN", m3_SPUN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_BUFC.HasValue)
				request.WithQueryParameter("BUFC", m3_BUFC.Value.ToString());
			if (m3_ACFC.HasValue)
				request.WithQueryParameter("ACFC", m3_ACFC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNR))
				request.WithQueryParameter("ITNR", m3_ITNR.Trim());
			if (m3_ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3_ORQT.Value.ToString());
			if (m3_SAPX.HasValue)
				request.WithQueryParameter("SAPX", m3_SAPX.Value.ToString());
			if (m3_BUQT.HasValue)
				request.WithQueryParameter("BUQT", m3_BUQT.Value.ToString());
			if (m3_BUAM.HasValue)
				request.WithQueryParameter("BUAM", m3_BUAM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPLC))
				request.WithQueryParameter("SPLC", m3_SPLC.Trim());
			if (m3_BNCD.HasValue)
				request.WithQueryParameter("BNCD", m3_BNCD.Value.ToString());
			if (m3_PRAC.HasValue)
				request.WithQueryParameter("PRAC", m3_PRAC.Value.ToString());
			if (m3_DEFC.HasValue)
				request.WithQueryParameter("DEFC", m3_DEFC.Value.ToString());
			if (m3_BCPR.HasValue)
				request.WithQueryParameter("BCPR", m3_BCPR.Value.ToString());
			if (m3_ACPI.HasValue)
				request.WithQueryParameter("ACPI", m3_ACPI.Value.ToString());
			if (m3_IVSH.HasValue)
				request.WithQueryParameter("IVSH", m3_IVSH.Value.ToString());
			if (m3_AVSH.HasValue)
				request.WithQueryParameter("AVSH", m3_AVSH.Value.ToString());
			if (m3_SOAM.HasValue)
				request.WithQueryParameter("SOAM", m3_SOAM.Value.ToString());
			if (m3_SOQT.HasValue)
				request.WithQueryParameter("SOQT", m3_SOQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SGGU))
				request.WithQueryParameter("SGGU", m3_SGGU.Trim());
			if (m3_SCLA.HasValue)
				request.WithQueryParameter("SCLA", m3_SCLA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (m3_SCLP.HasValue)
				request.WithQueryParameter("SCLP", m3_SCLP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (m3_LIMT.HasValue)
				request.WithQueryParameter("LIMT", m3_LIMT.Value.ToString());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (m3_BOOV.HasValue)
				request.WithQueryParameter("BOOV", m3_BOOV.Value.ToString());

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
		/// Name AddPromWhs
		/// Description Add Promotion Warehouse
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PIDE">Promotion (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPromWhs(
			string m3_DIVI, 
			string m3_PIDE, 
			string m3_WHLO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPromWhs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PIDE))
				throw new ArgumentNullException("m3_PIDE");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PIDE", m3_PIDE.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name DltProm
		/// Description Delete Promotion
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PIDE">Promotion (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltProm(
			string m3_DIVI, 
			string m3_PIDE, 
			DateTime m3_FVDT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltProm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PIDE))
				throw new ArgumentNullException("m3_PIDE");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PIDE", m3_PIDE.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name DltPromCust
		/// Description Delete Promotion Customer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PIDE">Promotion (Required)</param>
		/// <param name="m3_CUNO">Customer (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltPromCust(
			string m3_DIVI, 
			string m3_PIDE, 
			string m3_CUNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltPromCust",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PIDE))
				throw new ArgumentNullException("m3_PIDE");
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PIDE", m3_PIDE.Trim())
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name DltPromLine
		/// Description Delete Promotion Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PIDE">Promotion (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltPromLine(
			string m3_DIVI, 
			string m3_PIDE, 
			string m3_ITNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltPromLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PIDE))
				throw new ArgumentNullException("m3_PIDE");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PIDE", m3_PIDE.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name DltPromWhs
		/// Description Delete Promotion Warehouse
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PIDE">Promotion (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltPromWhs(
			string m3_DIVI, 
			string m3_PIDE, 
			string m3_WHLO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltPromWhs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PIDE))
				throw new ArgumentNullException("m3_PIDE");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PIDE", m3_PIDE.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name GetPromCust
		/// Description Get promotion customer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PIDE">Promotion (Required)</param>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPromCustResponse></returns>
		/// <exception cref="M3Exception<GetPromCustResponse>"></exception>
		public async Task<M3Response<GetPromCustResponse>> GetPromCust(
			string m3_PIDE, 
			string m3_CUNO, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPromCust",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PIDE))
				throw new ArgumentNullException("m3_PIDE");
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PIDE", m3_PIDE.Trim())
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<GetPromCustResponse>(
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
		/// Name GetPromHead
		/// Description Get promotion header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PIDE">Promotion (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPromHeadResponse></returns>
		/// <exception cref="M3Exception<GetPromHeadResponse>"></exception>
		public async Task<M3Response<GetPromHeadResponse>> GetPromHead(
			string m3_PIDE, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPromHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PIDE))
				throw new ArgumentNullException("m3_PIDE");

			// Set mandatory parameters
			request
				.WithQueryParameter("PIDE", m3_PIDE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<GetPromHeadResponse>(
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
		/// Name GetPromLine
		/// Description Get promotion for an item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PIDE">Promotion (Required)</param>
		/// <param name="m3_ITNO">Item no (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPromLineResponse></returns>
		/// <exception cref="M3Exception<GetPromLineResponse>"></exception>
		public async Task<M3Response<GetPromLineResponse>> GetPromLine(
			string m3_PIDE, 
			string m3_ITNO, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPromLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PIDE))
				throw new ArgumentNullException("m3_PIDE");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PIDE", m3_PIDE.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<GetPromLineResponse>(
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
		/// Name GetPromWhs
		/// Description Get Promotion Warehouse
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PIDE">Promotion (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPromWhsResponse></returns>
		/// <exception cref="M3Exception<GetPromWhsResponse>"></exception>
		public async Task<M3Response<GetPromWhsResponse>> GetPromWhs(
			string m3_DIVI, 
			string m3_PIDE, 
			string m3_WHLO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPromWhs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PIDE))
				throw new ArgumentNullException("m3_PIDE");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PIDE", m3_PIDE.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetPromWhsResponse>(
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
		/// Name LstPromCust
		/// Description List promotion customers
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_PIDE">Promotion</param>
		/// <param name="m3_LMDT">Change date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPromCustResponse></returns>
		/// <exception cref="M3Exception<LstPromCustResponse>"></exception>
		public async Task<M3Response<LstPromCustResponse>> LstPromCust(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_PIDE = null, 
			DateTime? m3_LMDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPromCust",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PIDE))
				request.WithQueryParameter("PIDE", m3_PIDE.Trim());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstPromCustResponse>(
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
		/// Name LstPromHead
		/// Description List promotion header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_PIDE">Promotion</param>
		/// <param name="m3_PROS">Status - promotion</param>
		/// <param name="m3_LMDT">Change date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPromHeadResponse></returns>
		/// <exception cref="M3Exception<LstPromHeadResponse>"></exception>
		public async Task<M3Response<LstPromHeadResponse>> LstPromHead(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_PIDE = null, 
			int? m3_PROS = null, 
			DateTime? m3_LMDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPromHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PIDE))
				request.WithQueryParameter("PIDE", m3_PIDE.Trim());
			if (m3_PROS.HasValue)
				request.WithQueryParameter("PROS", m3_PROS.Value.ToString());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstPromHeadResponse>(
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
		/// Name LstPromLine
		/// Description List promotion items
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_PIDE">Promotion</param>
		/// <param name="m3_LMDT">Change date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPromLineResponse></returns>
		/// <exception cref="M3Exception<LstPromLineResponse>"></exception>
		public async Task<M3Response<LstPromLineResponse>> LstPromLine(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_PIDE = null, 
			DateTime? m3_LMDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPromLine",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PIDE))
				request.WithQueryParameter("PIDE", m3_PIDE.Trim());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstPromLineResponse>(
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
		/// Name LstPromWhs
		/// Description List Promotion Warehouse
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PIDE">Promotion</param>
		/// <param name="m3_LMDT">Change date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPromWhsResponse></returns>
		/// <exception cref="M3Exception<LstPromWhsResponse>"></exception>
		public async Task<M3Response<LstPromWhsResponse>> LstPromWhs(
			string m3_DIVI, 
			int? m3_CONO = null, 
			string m3_PIDE = null, 
			DateTime? m3_LMDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPromWhs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PIDE))
				request.WithQueryParameter("PIDE", m3_PIDE.Trim());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstPromWhsResponse>(
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
		/// Name UpdPromHead
		/// Description Update Promotion Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PIDE">Promotion (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_PROS">Status promotion</param>
		/// <param name="m3_PTPE">Promotion Type</param>
		/// <param name="m3_PRES">Promotion responsible</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_FRD2">Activity start date</param>
		/// <param name="m3_TOD2">Activity end date</param>
		/// <param name="m3_PTER">Prmotion term</param>
		/// <param name="m3_SCMO">Costing sales model</param>
		/// <param name="m3_ACUS">Activity Customer</param>
		/// <param name="m3_BUFC">Budgeted fixed cost</param>
		/// <param name="m3_ACFC">Actual fixed cost</param>
		/// <param name="m3_DIMI">Distribution method</param>
		/// <param name="m3_TX08">Additional text</param>
		/// <param name="m3_DIBE">Discount base</param>
		/// <param name="m3_DIRE">Discount relation</param>
		/// <param name="m3_DCHA">Manually changeable discount</param>
		/// <param name="m3_DPST">Statistics field  for discount</param>
		/// <param name="m3_IDSC">Internal discount</param>
		/// <param name="m3_ACRF">User defined accounting control object</param>
		/// <param name="m3_PPT1">Promtotion statistics period type 1</param>
		/// <param name="m3_PPT2">Promotion statistics period type 2</param>
		/// <param name="m3_ACGR">Object access group</param>
		/// <param name="m3_BNCD">Bonus generating</param>
		/// <param name="m3_PRAC">Commission generating</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_CLMT">Claim calculation method</param>
		/// <param name="m3_SCLP">SPA claim percentage</param>
		/// <param name="m3_DISP">Discount percentage</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_PRI2">Priority</param>
		/// <param name="m3_PSUP">Propose supplier</param>
		/// <param name="m3_PRR1">Price list 1</param>
		/// <param name="m3_CUC1">Currency code 1</param>
		/// <param name="m3_LFL1">Label flag 1</param>
		/// <param name="m3_PRRF">Price list</param>
		/// <param name="m3_INIS">Initial start</param>
		/// <param name="m3_INIE">Initial end</param>
		/// <param name="m3_ANIN">Auto retrieval of promotion</param>
		/// <param name="m3_HOIN">Hold Initial order</param>
		/// <param name="m3_SCPO">Supply chain policy</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_BOOV">Backorder override</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPromHead(
			string m3_DIVI, 
			string m3_PIDE, 
			int? m3_CONO = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			int? m3_PROS = null, 
			string m3_PTPE = null, 
			string m3_PRES = null, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_LVDT = null, 
			int? m3_FRD2 = null, 
			int? m3_TOD2 = null, 
			int? m3_PTER = null, 
			string m3_SCMO = null, 
			string m3_ACUS = null, 
			decimal? m3_BUFC = null, 
			decimal? m3_ACFC = null, 
			int? m3_DIMI = null, 
			string m3_TX08 = null, 
			string m3_DIBE = null, 
			string m3_DIRE = null, 
			int? m3_DCHA = null, 
			int? m3_DPST = null, 
			int? m3_IDSC = null, 
			string m3_ACRF = null, 
			int? m3_PPT1 = null, 
			int? m3_PPT2 = null, 
			string m3_ACGR = null, 
			int? m3_BNCD = null, 
			int? m3_PRAC = null, 
			string m3_SUNO = null, 
			int? m3_CLMT = null, 
			int? m3_SCLP = null, 
			int? m3_DISP = null, 
			string m3_AGNB = null, 
			int? m3_PRI2 = null, 
			int? m3_PSUP = null, 
			string m3_PRR1 = null, 
			string m3_CUC1 = null, 
			string m3_LFL1 = null, 
			string m3_PRRF = null, 
			DateTime? m3_INIS = null, 
			DateTime? m3_INIE = null, 
			DateTime? m3_ANIN = null, 
			int? m3_HOIN = null, 
			string m3_SCPO = null, 
			string m3_ORTY = null, 
			int? m3_BOOV = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdPromHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PIDE))
				throw new ArgumentNullException("m3_PIDE");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PIDE", m3_PIDE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_PROS.HasValue)
				request.WithQueryParameter("PROS", m3_PROS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PTPE))
				request.WithQueryParameter("PTPE", m3_PTPE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRES))
				request.WithQueryParameter("PRES", m3_PRES.Trim());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (m3_FRD2.HasValue)
				request.WithQueryParameter("FRD2", m3_FRD2.Value.ToString());
			if (m3_TOD2.HasValue)
				request.WithQueryParameter("TOD2", m3_TOD2.Value.ToString());
			if (m3_PTER.HasValue)
				request.WithQueryParameter("PTER", m3_PTER.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCMO))
				request.WithQueryParameter("SCMO", m3_SCMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACUS))
				request.WithQueryParameter("ACUS", m3_ACUS.Trim());
			if (m3_BUFC.HasValue)
				request.WithQueryParameter("BUFC", m3_BUFC.Value.ToString());
			if (m3_ACFC.HasValue)
				request.WithQueryParameter("ACFC", m3_ACFC.Value.ToString());
			if (m3_DIMI.HasValue)
				request.WithQueryParameter("DIMI", m3_DIMI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX08))
				request.WithQueryParameter("TX08", m3_TX08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIBE))
				request.WithQueryParameter("DIBE", m3_DIBE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIRE))
				request.WithQueryParameter("DIRE", m3_DIRE.Trim());
			if (m3_DCHA.HasValue)
				request.WithQueryParameter("DCHA", m3_DCHA.Value.ToString());
			if (m3_DPST.HasValue)
				request.WithQueryParameter("DPST", m3_DPST.Value.ToString());
			if (m3_IDSC.HasValue)
				request.WithQueryParameter("IDSC", m3_IDSC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (m3_PPT1.HasValue)
				request.WithQueryParameter("PPT1", m3_PPT1.Value.ToString());
			if (m3_PPT2.HasValue)
				request.WithQueryParameter("PPT2", m3_PPT2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACGR))
				request.WithQueryParameter("ACGR", m3_ACGR.Trim());
			if (m3_BNCD.HasValue)
				request.WithQueryParameter("BNCD", m3_BNCD.Value.ToString());
			if (m3_PRAC.HasValue)
				request.WithQueryParameter("PRAC", m3_PRAC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_CLMT.HasValue)
				request.WithQueryParameter("CLMT", m3_CLMT.Value.ToString());
			if (m3_SCLP.HasValue)
				request.WithQueryParameter("SCLP", m3_SCLP.Value.ToString());
			if (m3_DISP.HasValue)
				request.WithQueryParameter("DISP", m3_DISP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (m3_PRI2.HasValue)
				request.WithQueryParameter("PRI2", m3_PRI2.Value.ToString());
			if (m3_PSUP.HasValue)
				request.WithQueryParameter("PSUP", m3_PSUP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRR1))
				request.WithQueryParameter("PRR1", m3_PRR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUC1))
				request.WithQueryParameter("CUC1", m3_CUC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LFL1))
				request.WithQueryParameter("LFL1", m3_LFL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRRF))
				request.WithQueryParameter("PRRF", m3_PRRF.Trim());
			if (m3_INIS.HasValue)
				request.WithQueryParameter("INIS", m3_INIS.Value.ToM3String());
			if (m3_INIE.HasValue)
				request.WithQueryParameter("INIE", m3_INIE.Value.ToM3String());
			if (m3_ANIN.HasValue)
				request.WithQueryParameter("ANIN", m3_ANIN.Value.ToM3String());
			if (m3_HOIN.HasValue)
				request.WithQueryParameter("HOIN", m3_HOIN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCPO))
				request.WithQueryParameter("SCPO", m3_SCPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (m3_BOOV.HasValue)
				request.WithQueryParameter("BOOV", m3_BOOV.Value.ToString());

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
		/// Name UpdPromLine
		/// Description Update Promotion Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PIDE">Promotion (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_SACD">Sales price quantity</param>
		/// <param name="m3_DIAM">Discount amount</param>
		/// <param name="m3_DISP">Discount percentage</param>
		/// <param name="m3_SPUN">Sales price U/M</param>
		/// <param name="m3_BUFC">Budgeted fixed cost</param>
		/// <param name="m3_ACFC">Actual fixed cost</param>
		/// <param name="m3_ITNR">Item number</param>
		/// <param name="m3_ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3_SAPX">Sales price</param>
		/// <param name="m3_BUQT">Budget quantity</param>
		/// <param name="m3_BUAM">Budget amount</param>
		/// <param name="m3_SPLC">Delivery split rule</param>
		/// <param name="m3_BNCD">Bonus generation</param>
		/// <param name="m3_PRAC">Commission generating</param>
		/// <param name="m3_DEFC">Demand factor</param>
		/// <param name="m3_BCPR">Budgeted cost</param>
		/// <param name="m3_ACPI">Actual cost</param>
		/// <param name="m3_SOAM">Sold amount</param>
		/// <param name="m3_SOQT">Sold quantity</param>
		/// <param name="m3_SGGU">Scale unit of measure</param>
		/// <param name="m3_SCLA">SPA claim</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_SCLP">SPA claim percentage</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_LIMT">Limit value</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_BOOV">Automatic closing override</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPromLine(
			string m3_DIVI, 
			string m3_PIDE, 
			string m3_ITNO, 
			int? m3_CONO = null, 
			decimal? m3_SAPR = null, 
			int? m3_SACD = null, 
			decimal? m3_DIAM = null, 
			decimal? m3_DISP = null, 
			string m3_SPUN = null, 
			decimal? m3_BUFC = null, 
			decimal? m3_ACFC = null, 
			string m3_ITNR = null, 
			decimal? m3_ORQT = null, 
			decimal? m3_SAPX = null, 
			decimal? m3_BUQT = null, 
			decimal? m3_BUAM = null, 
			string m3_SPLC = null, 
			int? m3_BNCD = null, 
			int? m3_PRAC = null, 
			int? m3_DEFC = null, 
			decimal? m3_BCPR = null, 
			decimal? m3_ACPI = null, 
			decimal? m3_SOAM = null, 
			decimal? m3_SOQT = null, 
			string m3_SGGU = null, 
			decimal? m3_SCLA = null, 
			string m3_TEPY = null, 
			int? m3_SCLP = null, 
			string m3_AGNB = null, 
			decimal? m3_LIMT = null, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_LVDT = null, 
			string m3_SUNO = null, 
			int? m3_BOOV = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdPromLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PIDE))
				throw new ArgumentNullException("m3_PIDE");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PIDE", m3_PIDE.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_SACD.HasValue)
				request.WithQueryParameter("SACD", m3_SACD.Value.ToString());
			if (m3_DIAM.HasValue)
				request.WithQueryParameter("DIAM", m3_DIAM.Value.ToString());
			if (m3_DISP.HasValue)
				request.WithQueryParameter("DISP", m3_DISP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPUN))
				request.WithQueryParameter("SPUN", m3_SPUN.Trim());
			if (m3_BUFC.HasValue)
				request.WithQueryParameter("BUFC", m3_BUFC.Value.ToString());
			if (m3_ACFC.HasValue)
				request.WithQueryParameter("ACFC", m3_ACFC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNR))
				request.WithQueryParameter("ITNR", m3_ITNR.Trim());
			if (m3_ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3_ORQT.Value.ToString());
			if (m3_SAPX.HasValue)
				request.WithQueryParameter("SAPX", m3_SAPX.Value.ToString());
			if (m3_BUQT.HasValue)
				request.WithQueryParameter("BUQT", m3_BUQT.Value.ToString());
			if (m3_BUAM.HasValue)
				request.WithQueryParameter("BUAM", m3_BUAM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPLC))
				request.WithQueryParameter("SPLC", m3_SPLC.Trim());
			if (m3_BNCD.HasValue)
				request.WithQueryParameter("BNCD", m3_BNCD.Value.ToString());
			if (m3_PRAC.HasValue)
				request.WithQueryParameter("PRAC", m3_PRAC.Value.ToString());
			if (m3_DEFC.HasValue)
				request.WithQueryParameter("DEFC", m3_DEFC.Value.ToString());
			if (m3_BCPR.HasValue)
				request.WithQueryParameter("BCPR", m3_BCPR.Value.ToString());
			if (m3_ACPI.HasValue)
				request.WithQueryParameter("ACPI", m3_ACPI.Value.ToString());
			if (m3_SOAM.HasValue)
				request.WithQueryParameter("SOAM", m3_SOAM.Value.ToString());
			if (m3_SOQT.HasValue)
				request.WithQueryParameter("SOQT", m3_SOQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SGGU))
				request.WithQueryParameter("SGGU", m3_SGGU.Trim());
			if (m3_SCLA.HasValue)
				request.WithQueryParameter("SCLA", m3_SCLA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (m3_SCLP.HasValue)
				request.WithQueryParameter("SCLP", m3_SCLP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (m3_LIMT.HasValue)
				request.WithQueryParameter("LIMT", m3_LIMT.Value.ToString());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_BOOV.HasValue)
				request.WithQueryParameter("BOOV", m3_BOOV.Value.ToString());

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
