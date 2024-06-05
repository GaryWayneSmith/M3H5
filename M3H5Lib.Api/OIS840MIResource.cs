/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PIDE">Promotion (Required)</param>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPromCust(
			string m3DIVI, 
			string m3PIDE, 
			string m3CUNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPromCust",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PIDE))
				throw new ArgumentNullException(nameof(m3PIDE));
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PIDE", m3PIDE.Trim())
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddPromHead
		/// Description Add Promotion Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PIDE">Promotion (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3PTPE">Promotion Type (Required)</param>
		/// <param name="m3PRES">Promotion responsible (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3LVDT">Valid To (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3PTER">Promotion Term (Required)</param>
		/// <param name="m3PPT1">Promotion statistics period type 1 (Required)</param>
		/// <param name="m3PPT2">Promotion statistics period type 2 (Required)</param>
		/// <param name="m3UPPC">Update Promotion (Required)</param>
		/// <param name="m3DIBE">Discount Base (Required)</param>
		/// <param name="m3DDSU">Discount presentation (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SCMO">Costing sales model</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3FRD2">Activity start date</param>
		/// <param name="m3TOD2">Activity end date</param>
		/// <param name="m3ACUS">Activity customer</param>
		/// <param name="m3BUFC">Budgeted fixed cost</param>
		/// <param name="m3ACFC">Actual fixed cost</param>
		/// <param name="m3DIMI">Distribution method</param>
		/// <param name="m3TX08">Additional text</param>
		/// <param name="m3DIRE">Discount relation</param>
		/// <param name="m3DCHA">Manually changeable discount</param>
		/// <param name="m3IDSC">Internal discount</param>
		/// <param name="m3ACRF">User defined accounting</param>
		/// <param name="m3ACGR">Object access group</param>
		/// <param name="m3BNCD">Bonus generating</param>
		/// <param name="m3PRAC">Commission generating</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3CLMT">Claim calculation method</param>
		/// <param name="m3SCLP">SPA claim percentage</param>
		/// <param name="m3DISP">Discount percentage</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3PRI2">Priority</param>
		/// <param name="m3PSUP">Propose supplier</param>
		/// <param name="m3PRR1">Price list 1</param>
		/// <param name="m3CUC1">Currency code 1</param>
		/// <param name="m3LFL1">Label flag 1</param>
		/// <param name="m3PRRF">Price list</param>
		/// <param name="m3OTYG">Order type group</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3TAID">Table</param>
		/// <param name="m3CHAI">Business chain</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3WHTA">Warehouse table</param>
		/// <param name="m3INIS">Initial start</param>
		/// <param name="m3INIE">Initial end</param>
		/// <param name="m3ANIN">Auto retrieval of promotion</param>
		/// <param name="m3HOIN">Hold Initial order</param>
		/// <param name="m3SCPO">Supply chain policy</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3BOOV">Automatic closing override</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPromHead(
			string m3DIVI, 
			string m3PIDE, 
			string m3TX40, 
			string m3PTPE, 
			string m3PRES, 
			DateTime m3FVDT, 
			DateTime m3LVDT, 
			string m3CUCD, 
			int m3PTER, 
			int m3PPT1, 
			int m3PPT2, 
			int m3UPPC, 
			string m3DIBE, 
			int m3DDSU, 
			int? m3CONO = null, 
			string m3SCMO = null, 
			string m3TX15 = null, 
			int? m3FRD2 = null, 
			int? m3TOD2 = null, 
			string m3ACUS = null, 
			decimal? m3BUFC = null, 
			decimal? m3ACFC = null, 
			int? m3DIMI = null, 
			string m3TX08 = null, 
			string m3DIRE = null, 
			int? m3DCHA = null, 
			int? m3IDSC = null, 
			string m3ACRF = null, 
			string m3ACGR = null, 
			int? m3BNCD = null, 
			int? m3PRAC = null, 
			string m3SUNO = null, 
			int? m3CLMT = null, 
			int? m3SCLP = null, 
			int? m3DISP = null, 
			string m3AGNB = null, 
			string m3TEPY = null, 
			int? m3PRI2 = null, 
			int? m3PSUP = null, 
			string m3PRR1 = null, 
			string m3CUC1 = null, 
			string m3LFL1 = null, 
			string m3PRRF = null, 
			string m3OTYG = null, 
			string m3CUNO = null, 
			string m3TAID = null, 
			string m3CHAI = null, 
			string m3WHLO = null, 
			string m3WHTA = null, 
			DateTime? m3INIS = null, 
			DateTime? m3INIE = null, 
			DateTime? m3ANIN = null, 
			int? m3HOIN = null, 
			string m3SCPO = null, 
			string m3ORTY = null, 
			int? m3BOOV = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PIDE))
				throw new ArgumentNullException(nameof(m3PIDE));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));
			if (string.IsNullOrWhiteSpace(m3PTPE))
				throw new ArgumentNullException(nameof(m3PTPE));
			if (string.IsNullOrWhiteSpace(m3PRES))
				throw new ArgumentNullException(nameof(m3PRES));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3DIBE))
				throw new ArgumentNullException(nameof(m3DIBE));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PIDE", m3PIDE.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim())
				.WithQueryParameter("PTPE", m3PTPE.Trim())
				.WithQueryParameter("PRES", m3PRES.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String())
				.WithQueryParameter("LVDT", m3LVDT.ToM3String())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("PTER", m3PTER.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PPT1", m3PPT1.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PPT2", m3PPT2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("UPPC", m3UPPC.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DIBE", m3DIBE.Trim())
				.WithQueryParameter("DDSU", m3DDSU.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCMO))
				request.WithQueryParameter("SCMO", m3SCMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3FRD2.HasValue)
				request.WithQueryParameter("FRD2", m3FRD2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOD2.HasValue)
				request.WithQueryParameter("TOD2", m3TOD2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACUS))
				request.WithQueryParameter("ACUS", m3ACUS.Trim());
			if (m3BUFC.HasValue)
				request.WithQueryParameter("BUFC", m3BUFC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACFC.HasValue)
				request.WithQueryParameter("ACFC", m3ACFC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIMI.HasValue)
				request.WithQueryParameter("DIMI", m3DIMI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX08))
				request.WithQueryParameter("TX08", m3TX08.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIRE))
				request.WithQueryParameter("DIRE", m3DIRE.Trim());
			if (m3DCHA.HasValue)
				request.WithQueryParameter("DCHA", m3DCHA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IDSC.HasValue)
				request.WithQueryParameter("IDSC", m3IDSC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACGR))
				request.WithQueryParameter("ACGR", m3ACGR.Trim());
			if (m3BNCD.HasValue)
				request.WithQueryParameter("BNCD", m3BNCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRAC.HasValue)
				request.WithQueryParameter("PRAC", m3PRAC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3CLMT.HasValue)
				request.WithQueryParameter("CLMT", m3CLMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCLP.HasValue)
				request.WithQueryParameter("SCLP", m3SCLP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DISP.HasValue)
				request.WithQueryParameter("DISP", m3DISP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (m3PRI2.HasValue)
				request.WithQueryParameter("PRI2", m3PRI2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PSUP.HasValue)
				request.WithQueryParameter("PSUP", m3PSUP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRR1))
				request.WithQueryParameter("PRR1", m3PRR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUC1))
				request.WithQueryParameter("CUC1", m3CUC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3LFL1))
				request.WithQueryParameter("LFL1", m3LFL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRRF))
				request.WithQueryParameter("PRRF", m3PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3OTYG))
				request.WithQueryParameter("OTYG", m3OTYG.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAID))
				request.WithQueryParameter("TAID", m3TAID.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHAI))
				request.WithQueryParameter("CHAI", m3CHAI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHTA))
				request.WithQueryParameter("WHTA", m3WHTA.Trim());
			if (m3INIS.HasValue)
				request.WithQueryParameter("INIS", m3INIS.Value.ToM3String());
			if (m3INIE.HasValue)
				request.WithQueryParameter("INIE", m3INIE.Value.ToM3String());
			if (m3ANIN.HasValue)
				request.WithQueryParameter("ANIN", m3ANIN.Value.ToM3String());
			if (m3HOIN.HasValue)
				request.WithQueryParameter("HOIN", m3HOIN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCPO))
				request.WithQueryParameter("SCPO", m3SCPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (m3BOOV.HasValue)
				request.WithQueryParameter("BOOV", m3BOOV.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddPromLine
		/// Description Add Promotion Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PIDE">Promotion (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SAPR">Sales price (Required)</param>
		/// <param name="m3SACD">Sales price quantity (Required)</param>
		/// <param name="m3DIAM">Discount amount (Required)</param>
		/// <param name="m3DISP">Discount percentage (Required)</param>
		/// <param name="m3SPUN">Sales price unit of measure (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3BUFC">Budgeted fixed cost</param>
		/// <param name="m3ACFC">Actual fixed cost</param>
		/// <param name="m3ITNR">Item number</param>
		/// <param name="m3ORQT">Ordered quantity-basic U/M</param>
		/// <param name="m3SAPX">Sales price</param>
		/// <param name="m3BUQT">Budget quantity</param>
		/// <param name="m3BUAM">Budget amount</param>
		/// <param name="m3SPLC">Delivery split rule</param>
		/// <param name="m3BNCD">Bonus generation</param>
		/// <param name="m3PRAC">commission generating</param>
		/// <param name="m3DEFC">Demand factor</param>
		/// <param name="m3BCPR">Budgeted cost</param>
		/// <param name="m3ACPI">Actual cost</param>
		/// <param name="m3IVSH">Affected volume percentage</param>
		/// <param name="m3AVSH">Actual volume percentage</param>
		/// <param name="m3SOAM">Sold amount</param>
		/// <param name="m3SOQT">Sold quantity</param>
		/// <param name="m3SGGU">Scale unit of measure</param>
		/// <param name="m3SCLA">SPA claim</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3SCLP">SPA claim percentage</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3LIMT">Limit value</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3BOOV">Automatic closing override</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPromLine(
			string m3DIVI, 
			string m3PIDE, 
			string m3ITNO, 
			decimal m3SAPR, 
			int m3SACD, 
			decimal m3DIAM, 
			decimal m3DISP, 
			string m3SPUN, 
			int? m3CONO = null, 
			decimal? m3BUFC = null, 
			decimal? m3ACFC = null, 
			string m3ITNR = null, 
			decimal? m3ORQT = null, 
			decimal? m3SAPX = null, 
			decimal? m3BUQT = null, 
			decimal? m3BUAM = null, 
			string m3SPLC = null, 
			int? m3BNCD = null, 
			int? m3PRAC = null, 
			int? m3DEFC = null, 
			decimal? m3BCPR = null, 
			decimal? m3ACPI = null, 
			int? m3IVSH = null, 
			int? m3AVSH = null, 
			decimal? m3SOAM = null, 
			decimal? m3SOQT = null, 
			string m3SGGU = null, 
			decimal? m3SCLA = null, 
			string m3SUNO = null, 
			string m3TEPY = null, 
			int? m3SCLP = null, 
			string m3AGNB = null, 
			decimal? m3LIMT = null, 
			DateTime? m3FVDT = null, 
			DateTime? m3LVDT = null, 
			int? m3BOOV = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PIDE))
				throw new ArgumentNullException(nameof(m3PIDE));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SPUN))
				throw new ArgumentNullException(nameof(m3SPUN));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PIDE", m3PIDE.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SAPR", m3SAPR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SACD", m3SACD.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DIAM", m3DIAM.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DISP", m3DISP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SPUN", m3SPUN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUFC.HasValue)
				request.WithQueryParameter("BUFC", m3BUFC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACFC.HasValue)
				request.WithQueryParameter("ACFC", m3ACFC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNR))
				request.WithQueryParameter("ITNR", m3ITNR.Trim());
			if (m3ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3ORQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAPX.HasValue)
				request.WithQueryParameter("SAPX", m3SAPX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUQT.HasValue)
				request.WithQueryParameter("BUQT", m3BUQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUAM.HasValue)
				request.WithQueryParameter("BUAM", m3BUAM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPLC))
				request.WithQueryParameter("SPLC", m3SPLC.Trim());
			if (m3BNCD.HasValue)
				request.WithQueryParameter("BNCD", m3BNCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRAC.HasValue)
				request.WithQueryParameter("PRAC", m3PRAC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DEFC.HasValue)
				request.WithQueryParameter("DEFC", m3DEFC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCPR.HasValue)
				request.WithQueryParameter("BCPR", m3BCPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACPI.HasValue)
				request.WithQueryParameter("ACPI", m3ACPI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IVSH.HasValue)
				request.WithQueryParameter("IVSH", m3IVSH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AVSH.HasValue)
				request.WithQueryParameter("AVSH", m3AVSH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SOAM.HasValue)
				request.WithQueryParameter("SOAM", m3SOAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SOQT.HasValue)
				request.WithQueryParameter("SOQT", m3SOQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SGGU))
				request.WithQueryParameter("SGGU", m3SGGU.Trim());
			if (m3SCLA.HasValue)
				request.WithQueryParameter("SCLA", m3SCLA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (m3SCLP.HasValue)
				request.WithQueryParameter("SCLP", m3SCLP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (m3LIMT.HasValue)
				request.WithQueryParameter("LIMT", m3LIMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (m3BOOV.HasValue)
				request.WithQueryParameter("BOOV", m3BOOV.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddPromWhs
		/// Description Add Promotion Warehouse
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PIDE">Promotion (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPromWhs(
			string m3DIVI, 
			string m3PIDE, 
			string m3WHLO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPromWhs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PIDE))
				throw new ArgumentNullException(nameof(m3PIDE));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PIDE", m3PIDE.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltProm
		/// Description Delete Promotion
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PIDE">Promotion (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltProm(
			string m3DIVI, 
			string m3PIDE, 
			DateTime m3FVDT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltProm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PIDE))
				throw new ArgumentNullException(nameof(m3PIDE));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PIDE", m3PIDE.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltPromCust
		/// Description Delete Promotion Customer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PIDE">Promotion (Required)</param>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltPromCust(
			string m3DIVI, 
			string m3PIDE, 
			string m3CUNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltPromCust",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PIDE))
				throw new ArgumentNullException(nameof(m3PIDE));
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PIDE", m3PIDE.Trim())
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltPromLine
		/// Description Delete Promotion Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PIDE">Promotion (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltPromLine(
			string m3DIVI, 
			string m3PIDE, 
			string m3ITNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltPromLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PIDE))
				throw new ArgumentNullException(nameof(m3PIDE));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PIDE", m3PIDE.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltPromWhs
		/// Description Delete Promotion Warehouse
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PIDE">Promotion (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltPromWhs(
			string m3DIVI, 
			string m3PIDE, 
			string m3WHLO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltPromWhs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PIDE))
				throw new ArgumentNullException(nameof(m3PIDE));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PIDE", m3PIDE.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetPromCust
		/// Description Get promotion customer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PIDE">Promotion (Required)</param>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPromCustResponse></returns>
		/// <exception cref="M3Exception<GetPromCustResponse>"></exception>
		public async Task<M3Response<GetPromCustResponse>> GetPromCust(
			string m3PIDE, 
			string m3CUNO, 
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPromCust",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PIDE))
				throw new ArgumentNullException(nameof(m3PIDE));
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PIDE", m3PIDE.Trim())
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<GetPromCustResponse>(
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
		/// Name GetPromHead
		/// Description Get promotion header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PIDE">Promotion (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPromHeadResponse></returns>
		/// <exception cref="M3Exception<GetPromHeadResponse>"></exception>
		public async Task<M3Response<GetPromHeadResponse>> GetPromHead(
			string m3PIDE, 
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPromHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PIDE))
				throw new ArgumentNullException(nameof(m3PIDE));

			// Set mandatory parameters
			request
				.WithQueryParameter("PIDE", m3PIDE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<GetPromHeadResponse>(
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
		/// Name GetPromLine
		/// Description Get promotion for an item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PIDE">Promotion (Required)</param>
		/// <param name="m3ITNO">Item no (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPromLineResponse></returns>
		/// <exception cref="M3Exception<GetPromLineResponse>"></exception>
		public async Task<M3Response<GetPromLineResponse>> GetPromLine(
			string m3PIDE, 
			string m3ITNO, 
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPromLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PIDE))
				throw new ArgumentNullException(nameof(m3PIDE));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PIDE", m3PIDE.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<GetPromLineResponse>(
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
		/// Name GetPromWhs
		/// Description Get Promotion Warehouse
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PIDE">Promotion (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPromWhsResponse></returns>
		/// <exception cref="M3Exception<GetPromWhsResponse>"></exception>
		public async Task<M3Response<GetPromWhsResponse>> GetPromWhs(
			string m3DIVI, 
			string m3PIDE, 
			string m3WHLO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPromWhs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PIDE))
				throw new ArgumentNullException(nameof(m3PIDE));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PIDE", m3PIDE.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetPromWhsResponse>(
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
		/// Name LstPromCust
		/// Description List promotion customers
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3PIDE">Promotion</param>
		/// <param name="m3LMDT">Change date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPromCustResponse></returns>
		/// <exception cref="M3Exception<LstPromCustResponse>"></exception>
		public async Task<M3Response<LstPromCustResponse>> LstPromCust(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3PIDE = null, 
			DateTime? m3LMDT = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PIDE))
				request.WithQueryParameter("PIDE", m3PIDE.Trim());
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstPromCustResponse>(
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
		/// Name LstPromHead
		/// Description List promotion header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3PIDE">Promotion</param>
		/// <param name="m3PROS">Status - promotion</param>
		/// <param name="m3LMDT">Change date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPromHeadResponse></returns>
		/// <exception cref="M3Exception<LstPromHeadResponse>"></exception>
		public async Task<M3Response<LstPromHeadResponse>> LstPromHead(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3PIDE = null, 
			int? m3PROS = null, 
			DateTime? m3LMDT = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PIDE))
				request.WithQueryParameter("PIDE", m3PIDE.Trim());
			if (m3PROS.HasValue)
				request.WithQueryParameter("PROS", m3PROS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstPromHeadResponse>(
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
		/// Name LstPromLine
		/// Description List promotion items
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3PIDE">Promotion</param>
		/// <param name="m3LMDT">Change date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPromLineResponse></returns>
		/// <exception cref="M3Exception<LstPromLineResponse>"></exception>
		public async Task<M3Response<LstPromLineResponse>> LstPromLine(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3PIDE = null, 
			DateTime? m3LMDT = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PIDE))
				request.WithQueryParameter("PIDE", m3PIDE.Trim());
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstPromLineResponse>(
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
		/// Name LstPromWhs
		/// Description List Promotion Warehouse
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PIDE">Promotion</param>
		/// <param name="m3LMDT">Change date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPromWhsResponse></returns>
		/// <exception cref="M3Exception<LstPromWhsResponse>"></exception>
		public async Task<M3Response<LstPromWhsResponse>> LstPromWhs(
			string m3DIVI, 
			int? m3CONO = null, 
			string m3PIDE = null, 
			DateTime? m3LMDT = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PIDE))
				request.WithQueryParameter("PIDE", m3PIDE.Trim());
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstPromWhsResponse>(
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
		/// Name UpdPromHead
		/// Description Update Promotion Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PIDE">Promotion (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3PROS">Status promotion</param>
		/// <param name="m3PTPE">Promotion Type</param>
		/// <param name="m3PRES">Promotion responsible</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3FRD2">Activity start date</param>
		/// <param name="m3TOD2">Activity end date</param>
		/// <param name="m3PTER">Prmotion term</param>
		/// <param name="m3SCMO">Costing sales model</param>
		/// <param name="m3ACUS">Activity Customer</param>
		/// <param name="m3BUFC">Budgeted fixed cost</param>
		/// <param name="m3ACFC">Actual fixed cost</param>
		/// <param name="m3DIMI">Distribution method</param>
		/// <param name="m3TX08">Additional text</param>
		/// <param name="m3DIBE">Discount base</param>
		/// <param name="m3DIRE">Discount relation</param>
		/// <param name="m3DCHA">Manually changeable discount</param>
		/// <param name="m3DPST">Statistics field  for discount</param>
		/// <param name="m3IDSC">Internal discount</param>
		/// <param name="m3ACRF">User defined accounting control object</param>
		/// <param name="m3PPT1">Promtotion statistics period type 1</param>
		/// <param name="m3PPT2">Promotion statistics period type 2</param>
		/// <param name="m3ACGR">Object access group</param>
		/// <param name="m3BNCD">Bonus generating</param>
		/// <param name="m3PRAC">Commission generating</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3CLMT">Claim calculation method</param>
		/// <param name="m3SCLP">SPA claim percentage</param>
		/// <param name="m3DISP">Discount percentage</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3PRI2">Priority</param>
		/// <param name="m3PSUP">Propose supplier</param>
		/// <param name="m3PRR1">Price list 1</param>
		/// <param name="m3CUC1">Currency code 1</param>
		/// <param name="m3LFL1">Label flag 1</param>
		/// <param name="m3PRRF">Price list</param>
		/// <param name="m3INIS">Initial start</param>
		/// <param name="m3INIE">Initial end</param>
		/// <param name="m3ANIN">Auto retrieval of promotion</param>
		/// <param name="m3HOIN">Hold Initial order</param>
		/// <param name="m3SCPO">Supply chain policy</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3BOOV">Backorder override</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPromHead(
			string m3DIVI, 
			string m3PIDE, 
			int? m3CONO = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			int? m3PROS = null, 
			string m3PTPE = null, 
			string m3PRES = null, 
			DateTime? m3FVDT = null, 
			DateTime? m3LVDT = null, 
			int? m3FRD2 = null, 
			int? m3TOD2 = null, 
			int? m3PTER = null, 
			string m3SCMO = null, 
			string m3ACUS = null, 
			decimal? m3BUFC = null, 
			decimal? m3ACFC = null, 
			int? m3DIMI = null, 
			string m3TX08 = null, 
			string m3DIBE = null, 
			string m3DIRE = null, 
			int? m3DCHA = null, 
			int? m3DPST = null, 
			int? m3IDSC = null, 
			string m3ACRF = null, 
			int? m3PPT1 = null, 
			int? m3PPT2 = null, 
			string m3ACGR = null, 
			int? m3BNCD = null, 
			int? m3PRAC = null, 
			string m3SUNO = null, 
			int? m3CLMT = null, 
			int? m3SCLP = null, 
			int? m3DISP = null, 
			string m3AGNB = null, 
			int? m3PRI2 = null, 
			int? m3PSUP = null, 
			string m3PRR1 = null, 
			string m3CUC1 = null, 
			string m3LFL1 = null, 
			string m3PRRF = null, 
			DateTime? m3INIS = null, 
			DateTime? m3INIE = null, 
			DateTime? m3ANIN = null, 
			int? m3HOIN = null, 
			string m3SCPO = null, 
			string m3ORTY = null, 
			int? m3BOOV = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PIDE))
				throw new ArgumentNullException(nameof(m3PIDE));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PIDE", m3PIDE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3PROS.HasValue)
				request.WithQueryParameter("PROS", m3PROS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PTPE))
				request.WithQueryParameter("PTPE", m3PTPE.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRES))
				request.WithQueryParameter("PRES", m3PRES.Trim());
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (m3FRD2.HasValue)
				request.WithQueryParameter("FRD2", m3FRD2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOD2.HasValue)
				request.WithQueryParameter("TOD2", m3TOD2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PTER.HasValue)
				request.WithQueryParameter("PTER", m3PTER.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCMO))
				request.WithQueryParameter("SCMO", m3SCMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACUS))
				request.WithQueryParameter("ACUS", m3ACUS.Trim());
			if (m3BUFC.HasValue)
				request.WithQueryParameter("BUFC", m3BUFC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACFC.HasValue)
				request.WithQueryParameter("ACFC", m3ACFC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIMI.HasValue)
				request.WithQueryParameter("DIMI", m3DIMI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX08))
				request.WithQueryParameter("TX08", m3TX08.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIBE))
				request.WithQueryParameter("DIBE", m3DIBE.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIRE))
				request.WithQueryParameter("DIRE", m3DIRE.Trim());
			if (m3DCHA.HasValue)
				request.WithQueryParameter("DCHA", m3DCHA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DPST.HasValue)
				request.WithQueryParameter("DPST", m3DPST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IDSC.HasValue)
				request.WithQueryParameter("IDSC", m3IDSC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (m3PPT1.HasValue)
				request.WithQueryParameter("PPT1", m3PPT1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PPT2.HasValue)
				request.WithQueryParameter("PPT2", m3PPT2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACGR))
				request.WithQueryParameter("ACGR", m3ACGR.Trim());
			if (m3BNCD.HasValue)
				request.WithQueryParameter("BNCD", m3BNCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRAC.HasValue)
				request.WithQueryParameter("PRAC", m3PRAC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3CLMT.HasValue)
				request.WithQueryParameter("CLMT", m3CLMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCLP.HasValue)
				request.WithQueryParameter("SCLP", m3SCLP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DISP.HasValue)
				request.WithQueryParameter("DISP", m3DISP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (m3PRI2.HasValue)
				request.WithQueryParameter("PRI2", m3PRI2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PSUP.HasValue)
				request.WithQueryParameter("PSUP", m3PSUP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRR1))
				request.WithQueryParameter("PRR1", m3PRR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUC1))
				request.WithQueryParameter("CUC1", m3CUC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3LFL1))
				request.WithQueryParameter("LFL1", m3LFL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRRF))
				request.WithQueryParameter("PRRF", m3PRRF.Trim());
			if (m3INIS.HasValue)
				request.WithQueryParameter("INIS", m3INIS.Value.ToM3String());
			if (m3INIE.HasValue)
				request.WithQueryParameter("INIE", m3INIE.Value.ToM3String());
			if (m3ANIN.HasValue)
				request.WithQueryParameter("ANIN", m3ANIN.Value.ToM3String());
			if (m3HOIN.HasValue)
				request.WithQueryParameter("HOIN", m3HOIN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCPO))
				request.WithQueryParameter("SCPO", m3SCPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (m3BOOV.HasValue)
				request.WithQueryParameter("BOOV", m3BOOV.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdPromLine
		/// Description Update Promotion Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PIDE">Promotion (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3SACD">Sales price quantity</param>
		/// <param name="m3DIAM">Discount amount</param>
		/// <param name="m3DISP">Discount percentage</param>
		/// <param name="m3SPUN">Sales price U/M</param>
		/// <param name="m3BUFC">Budgeted fixed cost</param>
		/// <param name="m3ACFC">Actual fixed cost</param>
		/// <param name="m3ITNR">Item number</param>
		/// <param name="m3ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3SAPX">Sales price</param>
		/// <param name="m3BUQT">Budget quantity</param>
		/// <param name="m3BUAM">Budget amount</param>
		/// <param name="m3SPLC">Delivery split rule</param>
		/// <param name="m3BNCD">Bonus generation</param>
		/// <param name="m3PRAC">Commission generating</param>
		/// <param name="m3DEFC">Demand factor</param>
		/// <param name="m3BCPR">Budgeted cost</param>
		/// <param name="m3ACPI">Actual cost</param>
		/// <param name="m3SOAM">Sold amount</param>
		/// <param name="m3SOQT">Sold quantity</param>
		/// <param name="m3SGGU">Scale unit of measure</param>
		/// <param name="m3SCLA">SPA claim</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3SCLP">SPA claim percentage</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3LIMT">Limit value</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3BOOV">Automatic closing override</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPromLine(
			string m3DIVI, 
			string m3PIDE, 
			string m3ITNO, 
			int? m3CONO = null, 
			decimal? m3SAPR = null, 
			int? m3SACD = null, 
			decimal? m3DIAM = null, 
			decimal? m3DISP = null, 
			string m3SPUN = null, 
			decimal? m3BUFC = null, 
			decimal? m3ACFC = null, 
			string m3ITNR = null, 
			decimal? m3ORQT = null, 
			decimal? m3SAPX = null, 
			decimal? m3BUQT = null, 
			decimal? m3BUAM = null, 
			string m3SPLC = null, 
			int? m3BNCD = null, 
			int? m3PRAC = null, 
			int? m3DEFC = null, 
			decimal? m3BCPR = null, 
			decimal? m3ACPI = null, 
			decimal? m3SOAM = null, 
			decimal? m3SOQT = null, 
			string m3SGGU = null, 
			decimal? m3SCLA = null, 
			string m3TEPY = null, 
			int? m3SCLP = null, 
			string m3AGNB = null, 
			decimal? m3LIMT = null, 
			DateTime? m3FVDT = null, 
			DateTime? m3LVDT = null, 
			string m3SUNO = null, 
			int? m3BOOV = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PIDE))
				throw new ArgumentNullException(nameof(m3PIDE));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PIDE", m3PIDE.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SACD.HasValue)
				request.WithQueryParameter("SACD", m3SACD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIAM.HasValue)
				request.WithQueryParameter("DIAM", m3DIAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DISP.HasValue)
				request.WithQueryParameter("DISP", m3DISP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPUN))
				request.WithQueryParameter("SPUN", m3SPUN.Trim());
			if (m3BUFC.HasValue)
				request.WithQueryParameter("BUFC", m3BUFC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACFC.HasValue)
				request.WithQueryParameter("ACFC", m3ACFC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNR))
				request.WithQueryParameter("ITNR", m3ITNR.Trim());
			if (m3ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3ORQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAPX.HasValue)
				request.WithQueryParameter("SAPX", m3SAPX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUQT.HasValue)
				request.WithQueryParameter("BUQT", m3BUQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUAM.HasValue)
				request.WithQueryParameter("BUAM", m3BUAM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPLC))
				request.WithQueryParameter("SPLC", m3SPLC.Trim());
			if (m3BNCD.HasValue)
				request.WithQueryParameter("BNCD", m3BNCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRAC.HasValue)
				request.WithQueryParameter("PRAC", m3PRAC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DEFC.HasValue)
				request.WithQueryParameter("DEFC", m3DEFC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCPR.HasValue)
				request.WithQueryParameter("BCPR", m3BCPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACPI.HasValue)
				request.WithQueryParameter("ACPI", m3ACPI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SOAM.HasValue)
				request.WithQueryParameter("SOAM", m3SOAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SOQT.HasValue)
				request.WithQueryParameter("SOQT", m3SOQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SGGU))
				request.WithQueryParameter("SGGU", m3SGGU.Trim());
			if (m3SCLA.HasValue)
				request.WithQueryParameter("SCLA", m3SCLA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (m3SCLP.HasValue)
				request.WithQueryParameter("SCLP", m3SCLP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (m3LIMT.HasValue)
				request.WithQueryParameter("LIMT", m3LIMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3BOOV.HasValue)
				request.WithQueryParameter("BOOV", m3BOOV.Value.ToString(CultureInfo.CurrentCulture));

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
