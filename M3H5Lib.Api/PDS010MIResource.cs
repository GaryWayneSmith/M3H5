/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.PDS010MI;
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
	/// Name: PDS010MI
	/// Component Name: WorkCenter
	/// Description: Work Center interface
	/// Version Release: 5ea2
	///</summary>
	public partial class PDS010MIResource : M3BaseResourceEndpoint
	{
		public PDS010MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PDS010MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddRelation
		/// Description Add resource relationship
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PLG1">Work center (Required)</param>
		/// <param name="m3PLG6">Work center resource (Required)</param>
		/// <param name="m3DSCR">Description (Required)</param>
		/// <param name="m3PRIR">Work center priority</param>
		/// <param name="m3PLGF">Forced resource</param>
		/// <param name="m3PLGN">Norm resource</param>
		/// <param name="m3EFFA">Efficiency factor</param>
		/// <param name="m3RPLF">Line control</param>
		/// <param name="m3SECR">Preferred resource</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddRelation(
			string m3FACI, 
			string m3PLG1, 
			string m3PLG6, 
			string m3DSCR, 
			string m3PRIR = null, 
			string m3PLGF = null, 
			string m3PLGN = null, 
			int? m3EFFA = null, 
			int? m3RPLF = null, 
			int? m3SECR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddRelation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PLG1))
				throw new ArgumentNullException(nameof(m3PLG1));
			if (string.IsNullOrWhiteSpace(m3PLG6))
				throw new ArgumentNullException(nameof(m3PLG6));
			if (string.IsNullOrWhiteSpace(m3DSCR))
				throw new ArgumentNullException(nameof(m3DSCR));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PLG1", m3PLG1.Trim())
				.WithQueryParameter("PLG6", m3PLG6.Trim())
				.WithQueryParameter("DSCR", m3DSCR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRIR))
				request.WithQueryParameter("PRIR", m3PRIR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGF))
				request.WithQueryParameter("PLGF", m3PLGF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGN))
				request.WithQueryParameter("PLGN", m3PLGN.Trim());
			if (m3EFFA.HasValue)
				request.WithQueryParameter("EFFA", m3EFFA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPLF.HasValue)
				request.WithQueryParameter("RPLF", m3RPLF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SECR.HasValue)
				request.WithQueryParameter("SECR", m3SECR.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddShiftInfo
		/// Description Add work center - shift record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PLGR">Work center (Required)</param>
		/// <param name="m3SHFC">Shift (Required)</param>
		/// <param name="m3VALT">Validity type (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3TODT">To date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WCNR">Number of resources</param>
		/// <param name="m3WCNM">Number of machines</param>
		/// <param name="m3WCNP">Number of persons</param>
		/// <param name="m3AVEF">Utilization rate</param>
		/// <param name="m3CHNO">Change number</param>
		/// <param name="m3PMSR">APP shift reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddShiftInfo(
			string m3FACI, 
			string m3PLGR, 
			string m3SHFC, 
			int m3VALT, 
			DateTime m3FRDT, 
			DateTime m3TODT, 
			int? m3CONO = null, 
			int? m3WCNR = null, 
			int? m3WCNM = null, 
			int? m3WCNP = null, 
			int? m3AVEF = null, 
			int? m3CHNO = null, 
			int? m3PMSR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddShiftInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PLGR))
				throw new ArgumentNullException(nameof(m3PLGR));
			if (string.IsNullOrWhiteSpace(m3SHFC))
				throw new ArgumentNullException(nameof(m3SHFC));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PLGR", m3PLGR.Trim())
				.WithQueryParameter("SHFC", m3SHFC.Trim())
				.WithQueryParameter("VALT", m3VALT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FRDT", m3FRDT.ToM3String())
				.WithQueryParameter("TODT", m3TODT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WCNR.HasValue)
				request.WithQueryParameter("WCNR", m3WCNR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WCNM.HasValue)
				request.WithQueryParameter("WCNM", m3WCNM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WCNP.HasValue)
				request.WithQueryParameter("WCNP", m3WCNP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AVEF.HasValue)
				request.WithQueryParameter("AVEF", m3AVEF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3CHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PMSR.HasValue)
				request.WithQueryParameter("PMSR", m3PMSR.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddShiftPatAdj
		/// Description Add shift pattern adjustment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PLGR">Work center (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3TODT">To date (Required)</param>
		/// <param name="m3SHPA">Shift pattern (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CHNO">Change number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddShiftPatAdj(
			string m3FACI, 
			string m3PLGR, 
			DateTime m3FRDT, 
			DateTime m3TODT, 
			string m3SHPA, 
			int? m3CONO = null, 
			int? m3CHNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddShiftPatAdj",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PLGR))
				throw new ArgumentNullException(nameof(m3PLGR));
			if (string.IsNullOrWhiteSpace(m3SHPA))
				throw new ArgumentNullException(nameof(m3SHPA));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PLGR", m3PLGR.Trim())
				.WithQueryParameter("FRDT", m3FRDT.ToM3String())
				.WithQueryParameter("TODT", m3TODT.ToM3String())
				.WithQueryParameter("SHPA", m3SHPA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3CHNO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddWorkCenter
		/// Description Add Work Center
		/// Version Release: 
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3PLNM">Name</param>
		/// <param name="m3PLTP">Resource type</param>
		/// <param name="m3IIWC">Included in work center</param>
		/// <param name="m3WCRE">Work center responsible</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3QUAC">Quality inspection</param>
		/// <param name="m3PLGT">Work center type</param>
		/// <param name="m3CRTR">Critical resource</param>
		/// <param name="m3COCE">Cost center</param>
		/// <param name="m3CINA">Create cost accounting transactions</param>
		/// <param name="m3CPTY">Capacity per unit and shift</param>
		/// <param name="m3PCAP">Capacity type</param>
		/// <param name="m3ACAP">Alternate capacity</param>
		/// <param name="m3RCUN">Alternate capacity U/M</param>
		/// <param name="m3SHPA">Shift pattern</param>
		/// <param name="m3PRLN">Production line</param>
		/// <param name="m3WCNM">Number of machines</param>
		/// <param name="m3WCNP">Number of persons</param>
		/// <param name="m3SHFT">Number of shifts</param>
		/// <param name="m3AVEF">Utilization rate</param>
		/// <param name="m3PLHZ">Planning horizon</param>
		/// <param name="m3EFCH">Efficiency control</param>
		/// <param name="m3LVDY">Daily load leveling</param>
		/// <param name="m3RATP">Production rate display code</param>
		/// <param name="m3DPLH">Weekly load leveling</param>
		/// <param name="m3GEOX">Geographic cod X</param>
		/// <param name="m3GEOY">Geographic code Y</param>
		/// <param name="m3GEOZ">Geographic cod  Z</param>
		/// <param name="m3AUIN">Automatic receipt</param>
		/// <param name="m3PLGD">Default resource</param>
		/// <param name="m3AURP">Automatic operation reporting</param>
		/// <param name="m3KANB">Item location issue</param>
		/// <param name="m3VEOC">Verify operation closing</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="m3KYRE">Flow order resource</param>
		/// <param name="m3RWCD">Load reduction method</param>
		/// <param name="m3WLDE">Infinite/finite</param>
		/// <param name="m3AMAO">Additional material offset</param>
		/// <param name="m3DAFA">Day factor</param>
		/// <param name="m3VAPC">Option percentage</param>
		/// <param name="m3QUDY">Queue days</param>
		/// <param name="m3RAUM">Reporting in alternate U/M</param>
		/// <param name="m3PSQT">Co-sorting identity</param>
		/// <param name="m3SOFD">CO-sort feature or drawing measurement</param>
		/// <param name="m3FITP">From item position</param>
		/// <param name="m3TITP">To item position</param>
		/// <param name="m3PIDS">Panel identity - MO W/C schedule</param>
		/// <param name="m3PIDW">Panel identity - WO W/C schedule</param>
		/// <param name="m3PLLT">Lot number control</param>
		/// <param name="m3OPDS">Operation description</param>
		/// <param name="m3PRNP">Planned number of workers - run time</param>
		/// <param name="m3SENP">Planned number of workers - setup</param>
		/// <param name="m3PRNM">Planned number of machines</param>
		/// <param name="m3SWQT">Setup scrap</param>
		/// <param name="m3SCPC">Scrap percentage</param>
		/// <param name="m3PLOQ">Production lot size</param>
		/// <param name="m3SETI">Setup time</param>
		/// <param name="m3PITI">Run time</param>
		/// <param name="m3OSET">External setup time</param>
		/// <param name="m3PTUN">Time U/M</param>
		/// <param name="m3CTCD">Price and time quantity</param>
		/// <param name="m3FXTI">Fixed time</param>
		/// <param name="m3SEPR">Setup price</param>
		/// <param name="m3PIPR">Unit price</param>
		/// <param name="m3PDCC">Number of price decimal places</param>
		/// <param name="m3KIWG">Pay element</param>
		/// <param name="m3WCRF">Time reference</param>
		/// <param name="m3SLAC">Transport value in days</param>
		/// <param name="m3SLAT">Transit unit of measure/Overlap code</param>
		/// <param name="m3CAMP">Number of labor tickets</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3DOID">Document identity</param>
		/// <param name="m3TOOL">Tool number</param>
		/// <param name="m3SHBP">Shipping buffer in production days</param>
		/// <param name="m3SEQP">Sequencing priority</param>
		/// <param name="m3ACZO">Work zone</param>
		/// <param name="m3PRET">Preparation time</param>
		/// <param name="m3CAPL">Capacity level</param>
		/// <param name="m3AVQT">Average queue time</param>
		/// <param name="m3ACOL">Activity color</param>
		/// <param name="m3LDPR">Loading principle</param>
		/// <param name="m3MDOP">Max duration of operation in percent</param>
		/// <param name="m3FUMT">Fill method</param>
		/// <param name="m3POTM">Post-operation time</param>
		/// <param name="m3MINR">Minimum restriction</param>
		/// <param name="m3CPOT">Continuous post-opr time</param>
		/// <param name="m3MAXR">Maximum restriction</param>
		/// <param name="m3MPTF">Operator time factor</param>
		/// <param name="m3UNIT">Unit of measure</param>
		/// <param name="m3GRMU">Oven load U/M</param>
		/// <param name="m3GRMX">Maximum oven load</param>
		/// <param name="m3AVFL">Average load percentage</param>
		/// <param name="m3BAME">Batch sizing method</param>
		/// <param name="m3BAMI">Minimum batch size</param>
		/// <param name="m3BAML">Minimum level percentage</param>
		/// <param name="m3BAMA">Maximum batch size</param>
		/// <param name="m3BASL">Step level percentage</param>
		/// <param name="m3BASS">Multiple batch size</param>
		/// <param name="m3BARD">Surplus rule</param>
		/// <param name="m3BAFD">Frozen horizon</param>
		/// <param name="m3BALD">Sequence lock horizon</param>
		/// <param name="m3BASD">Slushy horizon</param>
		/// <param name="m3RETL">Return location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddWorkCenter(
			string m3FACI = null, 
			string m3PLGR = null, 
			string m3PLNM = null, 
			string m3PLTP = null, 
			string m3IIWC = null, 
			string m3WCRE = null, 
			string m3DEPT = null, 
			string m3REAR = null, 
			int? m3QUAC = null, 
			string m3PLGT = null, 
			int? m3CRTR = null, 
			string m3COCE = null, 
			int? m3CINA = null, 
			decimal? m3CPTY = null, 
			string m3PCAP = null, 
			decimal? m3ACAP = null, 
			string m3RCUN = null, 
			string m3SHPA = null, 
			int? m3PRLN = null, 
			int? m3WCNM = null, 
			int? m3WCNP = null, 
			int? m3SHFT = null, 
			int? m3AVEF = null, 
			int? m3PLHZ = null, 
			int? m3EFCH = null, 
			int? m3LVDY = null, 
			int? m3RATP = null, 
			int? m3DPLH = null, 
			decimal? m3GEOX = null, 
			decimal? m3GEOY = null, 
			decimal? m3GEOZ = null, 
			int? m3AUIN = null, 
			string m3PLGD = null, 
			int? m3AURP = null, 
			int? m3KANB = null, 
			int? m3VEOC = null, 
			string m3WHLO = null, 
			string m3WHSL = null, 
			string m3TWSL = null, 
			int? m3KYRE = null, 
			string m3RWCD = null, 
			int? m3WLDE = null, 
			int? m3AMAO = null, 
			int? m3DAFA = null, 
			int? m3VAPC = null, 
			int? m3QUDY = null, 
			int? m3RAUM = null, 
			int? m3PSQT = null, 
			string m3SOFD = null, 
			int? m3FITP = null, 
			int? m3TITP = null, 
			string m3PIDS = null, 
			string m3PIDW = null, 
			int? m3PLLT = null, 
			string m3OPDS = null, 
			int? m3PRNP = null, 
			int? m3SENP = null, 
			int? m3PRNM = null, 
			decimal? m3SWQT = null, 
			int? m3SCPC = null, 
			decimal? m3PLOQ = null, 
			int? m3SETI = null, 
			int? m3PITI = null, 
			int? m3OSET = null, 
			string m3PTUN = null, 
			int? m3CTCD = null, 
			int? m3FXTI = null, 
			decimal? m3SEPR = null, 
			decimal? m3PIPR = null, 
			int? m3PDCC = null, 
			int? m3KIWG = null, 
			string m3WCRF = null, 
			decimal? m3SLAC = null, 
			string m3SLAT = null, 
			int? m3CAMP = null, 
			string m3SUNO = null, 
			string m3DOID = null, 
			string m3TOOL = null, 
			int? m3SHBP = null, 
			int? m3SEQP = null, 
			string m3ACZO = null, 
			int? m3PRET = null, 
			int? m3CAPL = null, 
			int? m3AVQT = null, 
			int? m3ACOL = null, 
			int? m3LDPR = null, 
			int? m3MDOP = null, 
			int? m3FUMT = null, 
			int? m3POTM = null, 
			string m3MINR = null, 
			int? m3CPOT = null, 
			string m3MAXR = null, 
			int? m3MPTF = null, 
			string m3UNIT = null, 
			int? m3GRMU = null, 
			long? m3GRMX = null, 
			int? m3AVFL = null, 
			int? m3BAME = null, 
			decimal? m3BAMI = null, 
			int? m3BAML = null, 
			decimal? m3BAMA = null, 
			int? m3BASL = null, 
			decimal? m3BASS = null, 
			int? m3BARD = null, 
			int? m3BAFD = null, 
			int? m3BALD = null, 
			int? m3BASD = null, 
			string m3RETL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddWorkCenter",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLNM))
				request.WithQueryParameter("PLNM", m3PLNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLTP))
				request.WithQueryParameter("PLTP", m3PLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3IIWC))
				request.WithQueryParameter("IIWC", m3IIWC.Trim());
			if (!string.IsNullOrWhiteSpace(m3WCRE))
				request.WithQueryParameter("WCRE", m3WCRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (m3QUAC.HasValue)
				request.WithQueryParameter("QUAC", m3QUAC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLGT))
				request.WithQueryParameter("PLGT", m3PLGT.Trim());
			if (m3CRTR.HasValue)
				request.WithQueryParameter("CRTR", m3CRTR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3COCE))
				request.WithQueryParameter("COCE", m3COCE.Trim());
			if (m3CINA.HasValue)
				request.WithQueryParameter("CINA", m3CINA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CPTY.HasValue)
				request.WithQueryParameter("CPTY", m3CPTY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PCAP))
				request.WithQueryParameter("PCAP", m3PCAP.Trim());
			if (m3ACAP.HasValue)
				request.WithQueryParameter("ACAP", m3ACAP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RCUN))
				request.WithQueryParameter("RCUN", m3RCUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SHPA))
				request.WithQueryParameter("SHPA", m3SHPA.Trim());
			if (m3PRLN.HasValue)
				request.WithQueryParameter("PRLN", m3PRLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WCNM.HasValue)
				request.WithQueryParameter("WCNM", m3WCNM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WCNP.HasValue)
				request.WithQueryParameter("WCNP", m3WCNP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHFT.HasValue)
				request.WithQueryParameter("SHFT", m3SHFT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AVEF.HasValue)
				request.WithQueryParameter("AVEF", m3AVEF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLHZ.HasValue)
				request.WithQueryParameter("PLHZ", m3PLHZ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EFCH.HasValue)
				request.WithQueryParameter("EFCH", m3EFCH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LVDY.HasValue)
				request.WithQueryParameter("LVDY", m3LVDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RATP.HasValue)
				request.WithQueryParameter("RATP", m3RATP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DPLH.HasValue)
				request.WithQueryParameter("DPLH", m3DPLH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEOX.HasValue)
				request.WithQueryParameter("GEOX", m3GEOX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEOY.HasValue)
				request.WithQueryParameter("GEOY", m3GEOY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEOZ.HasValue)
				request.WithQueryParameter("GEOZ", m3GEOZ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUIN.HasValue)
				request.WithQueryParameter("AUIN", m3AUIN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLGD))
				request.WithQueryParameter("PLGD", m3PLGD.Trim());
			if (m3AURP.HasValue)
				request.WithQueryParameter("AURP", m3AURP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KANB.HasValue)
				request.WithQueryParameter("KANB", m3KANB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VEOC.HasValue)
				request.WithQueryParameter("VEOC", m3VEOC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (m3KYRE.HasValue)
				request.WithQueryParameter("KYRE", m3KYRE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RWCD))
				request.WithQueryParameter("RWCD", m3RWCD.Trim());
			if (m3WLDE.HasValue)
				request.WithQueryParameter("WLDE", m3WLDE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMAO.HasValue)
				request.WithQueryParameter("AMAO", m3AMAO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DAFA.HasValue)
				request.WithQueryParameter("DAFA", m3DAFA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VAPC.HasValue)
				request.WithQueryParameter("VAPC", m3VAPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QUDY.HasValue)
				request.WithQueryParameter("QUDY", m3QUDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RAUM.HasValue)
				request.WithQueryParameter("RAUM", m3RAUM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PSQT.HasValue)
				request.WithQueryParameter("PSQT", m3PSQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SOFD))
				request.WithQueryParameter("SOFD", m3SOFD.Trim());
			if (m3FITP.HasValue)
				request.WithQueryParameter("FITP", m3FITP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TITP.HasValue)
				request.WithQueryParameter("TITP", m3TITP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PIDS))
				request.WithQueryParameter("PIDS", m3PIDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3PIDW))
				request.WithQueryParameter("PIDW", m3PIDW.Trim());
			if (m3PLLT.HasValue)
				request.WithQueryParameter("PLLT", m3PLLT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OPDS))
				request.WithQueryParameter("OPDS", m3OPDS.Trim());
			if (m3PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3PRNP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SENP.HasValue)
				request.WithQueryParameter("SENP", m3SENP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNM.HasValue)
				request.WithQueryParameter("PRNM", m3PRNM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SWQT.HasValue)
				request.WithQueryParameter("SWQT", m3SWQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCPC.HasValue)
				request.WithQueryParameter("SCPC", m3SCPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLOQ.HasValue)
				request.WithQueryParameter("PLOQ", m3PLOQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SETI.HasValue)
				request.WithQueryParameter("SETI", m3SETI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PITI.HasValue)
				request.WithQueryParameter("PITI", m3PITI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OSET.HasValue)
				request.WithQueryParameter("OSET", m3OSET.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PTUN))
				request.WithQueryParameter("PTUN", m3PTUN.Trim());
			if (m3CTCD.HasValue)
				request.WithQueryParameter("CTCD", m3CTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FXTI.HasValue)
				request.WithQueryParameter("FXTI", m3FXTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SEPR.HasValue)
				request.WithQueryParameter("SEPR", m3SEPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PIPR.HasValue)
				request.WithQueryParameter("PIPR", m3PIPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PDCC.HasValue)
				request.WithQueryParameter("PDCC", m3PDCC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KIWG.HasValue)
				request.WithQueryParameter("KIWG", m3KIWG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WCRF))
				request.WithQueryParameter("WCRF", m3WCRF.Trim());
			if (m3SLAC.HasValue)
				request.WithQueryParameter("SLAC", m3SLAC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SLAT))
				request.WithQueryParameter("SLAT", m3SLAT.Trim());
			if (m3CAMP.HasValue)
				request.WithQueryParameter("CAMP", m3CAMP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOOL))
				request.WithQueryParameter("TOOL", m3TOOL.Trim());
			if (m3SHBP.HasValue)
				request.WithQueryParameter("SHBP", m3SHBP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SEQP.HasValue)
				request.WithQueryParameter("SEQP", m3SEQP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACZO))
				request.WithQueryParameter("ACZO", m3ACZO.Trim());
			if (m3PRET.HasValue)
				request.WithQueryParameter("PRET", m3PRET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAPL.HasValue)
				request.WithQueryParameter("CAPL", m3CAPL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AVQT.HasValue)
				request.WithQueryParameter("AVQT", m3AVQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACOL.HasValue)
				request.WithQueryParameter("ACOL", m3ACOL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LDPR.HasValue)
				request.WithQueryParameter("LDPR", m3LDPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MDOP.HasValue)
				request.WithQueryParameter("MDOP", m3MDOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FUMT.HasValue)
				request.WithQueryParameter("FUMT", m3FUMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POTM.HasValue)
				request.WithQueryParameter("POTM", m3POTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MINR))
				request.WithQueryParameter("MINR", m3MINR.Trim());
			if (m3CPOT.HasValue)
				request.WithQueryParameter("CPOT", m3CPOT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MAXR))
				request.WithQueryParameter("MAXR", m3MAXR.Trim());
			if (m3MPTF.HasValue)
				request.WithQueryParameter("MPTF", m3MPTF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3UNIT))
				request.WithQueryParameter("UNIT", m3UNIT.Trim());
			if (m3GRMU.HasValue)
				request.WithQueryParameter("GRMU", m3GRMU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRMX.HasValue)
				request.WithQueryParameter("GRMX", m3GRMX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AVFL.HasValue)
				request.WithQueryParameter("AVFL", m3AVFL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BAME.HasValue)
				request.WithQueryParameter("BAME", m3BAME.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BAMI.HasValue)
				request.WithQueryParameter("BAMI", m3BAMI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BAML.HasValue)
				request.WithQueryParameter("BAML", m3BAML.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BAMA.HasValue)
				request.WithQueryParameter("BAMA", m3BAMA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BASL.HasValue)
				request.WithQueryParameter("BASL", m3BASL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BASS.HasValue)
				request.WithQueryParameter("BASS", m3BASS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BARD.HasValue)
				request.WithQueryParameter("BARD", m3BARD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BAFD.HasValue)
				request.WithQueryParameter("BAFD", m3BAFD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BALD.HasValue)
				request.WithQueryParameter("BALD", m3BALD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BASD.HasValue)
				request.WithQueryParameter("BASD", m3BASD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RETL))
				request.WithQueryParameter("RETL", m3RETL.Trim());

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
		/// Name ChgRelation
		/// Description Change resource relationship
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PLG1">Work center (Required)</param>
		/// <param name="m3PLG6">Work center resource (Required)</param>
		/// <param name="m3DSCR">Description (Required)</param>
		/// <param name="m3PRIR">Work center priority</param>
		/// <param name="m3PLGF">Forced resource</param>
		/// <param name="m3PLGN">Norm resource</param>
		/// <param name="m3EFFA">Efficiency factor</param>
		/// <param name="m3RPLF">Line control</param>
		/// <param name="m3SECR">Preferred resource</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgRelation(
			string m3FACI, 
			string m3PLG1, 
			string m3PLG6, 
			string m3DSCR, 
			string m3PRIR = null, 
			string m3PLGF = null, 
			string m3PLGN = null, 
			int? m3EFFA = null, 
			int? m3RPLF = null, 
			int? m3SECR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgRelation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PLG1))
				throw new ArgumentNullException(nameof(m3PLG1));
			if (string.IsNullOrWhiteSpace(m3PLG6))
				throw new ArgumentNullException(nameof(m3PLG6));
			if (string.IsNullOrWhiteSpace(m3DSCR))
				throw new ArgumentNullException(nameof(m3DSCR));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PLG1", m3PLG1.Trim())
				.WithQueryParameter("PLG6", m3PLG6.Trim())
				.WithQueryParameter("DSCR", m3DSCR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRIR))
				request.WithQueryParameter("PRIR", m3PRIR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGF))
				request.WithQueryParameter("PLGF", m3PLGF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGN))
				request.WithQueryParameter("PLGN", m3PLGN.Trim());
			if (m3EFFA.HasValue)
				request.WithQueryParameter("EFFA", m3EFFA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPLF.HasValue)
				request.WithQueryParameter("RPLF", m3RPLF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SECR.HasValue)
				request.WithQueryParameter("SECR", m3SECR.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgShiftInfo
		/// Description Change work center - shift record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PLGR">Work center (Required)</param>
		/// <param name="m3SHFC">Shift (Required)</param>
		/// <param name="m3VALT">Validity type (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3CHNO">Change number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="m3WCNR">Number of resources</param>
		/// <param name="m3WCNM">Number of machines</param>
		/// <param name="m3WCNP">Number of persons</param>
		/// <param name="m3AVEF">Utilization rate</param>
		/// <param name="m3PMSR">APP shift reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgShiftInfo(
			string m3FACI, 
			string m3PLGR, 
			string m3SHFC, 
			int m3VALT, 
			DateTime m3FRDT, 
			int m3CHNO, 
			int? m3CONO = null, 
			DateTime? m3TODT = null, 
			int? m3WCNR = null, 
			string m3WCNM = null, 
			int? m3WCNP = null, 
			string m3AVEF = null, 
			int? m3PMSR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgShiftInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PLGR))
				throw new ArgumentNullException(nameof(m3PLGR));
			if (string.IsNullOrWhiteSpace(m3SHFC))
				throw new ArgumentNullException(nameof(m3SHFC));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PLGR", m3PLGR.Trim())
				.WithQueryParameter("SHFC", m3SHFC.Trim())
				.WithQueryParameter("VALT", m3VALT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FRDT", m3FRDT.ToM3String())
				.WithQueryParameter("CHNO", m3CHNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());
			if (m3WCNR.HasValue)
				request.WithQueryParameter("WCNR", m3WCNR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WCNM))
				request.WithQueryParameter("WCNM", m3WCNM.Trim());
			if (m3WCNP.HasValue)
				request.WithQueryParameter("WCNP", m3WCNP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AVEF))
				request.WithQueryParameter("AVEF", m3AVEF.Trim());
			if (m3PMSR.HasValue)
				request.WithQueryParameter("PMSR", m3PMSR.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgShiftPatAdj
		/// Description Update Shift Pattern Adjustment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PLGR">Work center (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3TODT">To date (Required)</param>
		/// <param name="m3SHPA">Shift pattern (Required)</param>
		/// <param name="m3CHNO">Change number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgShiftPatAdj(
			string m3FACI, 
			string m3PLGR, 
			DateTime m3FRDT, 
			DateTime m3TODT, 
			string m3SHPA, 
			int m3CHNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgShiftPatAdj",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PLGR))
				throw new ArgumentNullException(nameof(m3PLGR));
			if (string.IsNullOrWhiteSpace(m3SHPA))
				throw new ArgumentNullException(nameof(m3SHPA));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PLGR", m3PLGR.Trim())
				.WithQueryParameter("FRDT", m3FRDT.ToM3String())
				.WithQueryParameter("TODT", m3TODT.ToM3String())
				.WithQueryParameter("SHPA", m3SHPA.Trim())
				.WithQueryParameter("CHNO", m3CHNO.ToString(CultureInfo.CurrentCulture));

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
		/// Name CpyRelation
		/// Description Copy resource relationship
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PLG1">Work center (Required)</param>
		/// <param name="m3PLG6">Work center resource (Required)</param>
		/// <param name="m3TOG1">Copy to work center (Required)</param>
		/// <param name="m3TOG6">Copy to work center resource (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyRelation(
			string m3FACI, 
			string m3PLG1, 
			string m3PLG6, 
			string m3TOG1, 
			string m3TOG6, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyRelation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PLG1))
				throw new ArgumentNullException(nameof(m3PLG1));
			if (string.IsNullOrWhiteSpace(m3PLG6))
				throw new ArgumentNullException(nameof(m3PLG6));
			if (string.IsNullOrWhiteSpace(m3TOG1))
				throw new ArgumentNullException(nameof(m3TOG1));
			if (string.IsNullOrWhiteSpace(m3TOG6))
				throw new ArgumentNullException(nameof(m3TOG6));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PLG1", m3PLG1.Trim())
				.WithQueryParameter("PLG6", m3PLG6.Trim())
				.WithQueryParameter("TOG1", m3TOG1.Trim())
				.WithQueryParameter("TOG6", m3TOG6.Trim());

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
		/// Name CrtCapacity
		/// Description Create server capacity of work center
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PLGR">Work center (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3TODT">To date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CrtCapacity(
			string m3FACI, 
			string m3PLGR, 
			DateTime m3FRDT, 
			DateTime m3TODT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CrtCapacity",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PLGR))
				throw new ArgumentNullException(nameof(m3PLGR));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PLGR", m3PLGR.Trim())
				.WithQueryParameter("FRDT", m3FRDT.ToM3String())
				.WithQueryParameter("TODT", m3TODT.ToM3String());

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
		/// Name DelRelation
		/// Description Delete resource relationship
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PLG1">Work center</param>
		/// <param name="m3PLG6">Work center resource</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelRelation(
			string m3FACI = null, 
			string m3PLG1 = null, 
			string m3PLG6 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelRelation",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLG1))
				request.WithQueryParameter("PLG1", m3PLG1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLG6))
				request.WithQueryParameter("PLG6", m3PLG6.Trim());

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
		/// Name DelShiftInfo
		/// Description Delete work center - shift record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PLGR">Work center (Required)</param>
		/// <param name="m3SHFC">Shift (Required)</param>
		/// <param name="m3VALT">Validity type (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="m3WCNR">Number of resources</param>
		/// <param name="m3WCNM">Number of machines</param>
		/// <param name="m3WCNP">Number of persons</param>
		/// <param name="m3AVEF">Utilization rate</param>
		/// <param name="m3CHNO">Change number</param>
		/// <param name="m3PMSR">APP shift reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelShiftInfo(
			string m3FACI, 
			string m3PLGR, 
			string m3SHFC, 
			int m3VALT, 
			DateTime m3FRDT, 
			int? m3CONO = null, 
			DateTime? m3TODT = null, 
			int? m3WCNR = null, 
			string m3WCNM = null, 
			int? m3WCNP = null, 
			string m3AVEF = null, 
			int? m3CHNO = null, 
			int? m3PMSR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelShiftInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PLGR))
				throw new ArgumentNullException(nameof(m3PLGR));
			if (string.IsNullOrWhiteSpace(m3SHFC))
				throw new ArgumentNullException(nameof(m3SHFC));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PLGR", m3PLGR.Trim())
				.WithQueryParameter("SHFC", m3SHFC.Trim())
				.WithQueryParameter("VALT", m3VALT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FRDT", m3FRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());
			if (m3WCNR.HasValue)
				request.WithQueryParameter("WCNR", m3WCNR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WCNM))
				request.WithQueryParameter("WCNM", m3WCNM.Trim());
			if (m3WCNP.HasValue)
				request.WithQueryParameter("WCNP", m3WCNP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AVEF))
				request.WithQueryParameter("AVEF", m3AVEF.Trim());
			if (m3CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3CHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PMSR.HasValue)
				request.WithQueryParameter("PMSR", m3PMSR.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelShiftPatAdj
		/// Description Delete Shift Pattern Adjustment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PLGR">Work center (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelShiftPatAdj(
			string m3FACI, 
			string m3PLGR, 
			DateTime m3FRDT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelShiftPatAdj",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PLGR))
				throw new ArgumentNullException(nameof(m3PLGR));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PLGR", m3PLGR.Trim())
				.WithQueryParameter("FRDT", m3FRDT.ToM3String());

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
		/// Name DelWorkCenter
		/// Description Delete Work Center
		/// Version Release: 
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelWorkCenter(
			string m3FACI = null, 
			string m3PLGR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelWorkCenter",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());

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
		/// Name Get
		/// Description Get
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PLGR">Work center (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3FACI, 
			string m3PLGR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PLGR))
				throw new ArgumentNullException(nameof(m3PLGR));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PLGR", m3PLGR.Trim());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name GetRelation
		/// Description Get resource relationship
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PLG1">Work center (Required)</param>
		/// <param name="m3PLG6">Work center resource (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetRelationResponse></returns>
		/// <exception cref="M3Exception<GetRelationResponse>"></exception>
		public async Task<M3Response<GetRelationResponse>> GetRelation(
			string m3FACI, 
			string m3PLG1, 
			string m3PLG6, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetRelation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PLG1))
				throw new ArgumentNullException(nameof(m3PLG1));
			if (string.IsNullOrWhiteSpace(m3PLG6))
				throw new ArgumentNullException(nameof(m3PLG6));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PLG1", m3PLG1.Trim())
				.WithQueryParameter("PLG6", m3PLG6.Trim());

			// Execute the request
			var result = await Execute<GetRelationResponse>(
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
		/// Name GetShiftInfo
		/// Description Retrieve work center - shift record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PLGR">Work center (Required)</param>
		/// <param name="m3SHFC">Shift (Required)</param>
		/// <param name="m3VALT">Validity type (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="m3WCNR">Number of resources</param>
		/// <param name="m3WCNM">Number of machines</param>
		/// <param name="m3WCNP">Number of persons</param>
		/// <param name="m3AVEF">Utilization rate</param>
		/// <param name="m3CHNO">Change number</param>
		/// <param name="m3PMSR">Shift reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetShiftInfoResponse></returns>
		/// <exception cref="M3Exception<GetShiftInfoResponse>"></exception>
		public async Task<M3Response<GetShiftInfoResponse>> GetShiftInfo(
			string m3FACI, 
			string m3PLGR, 
			string m3SHFC, 
			string m3VALT, 
			DateTime m3FRDT, 
			int? m3CONO = null, 
			DateTime? m3TODT = null, 
			string m3WCNR = null, 
			string m3WCNM = null, 
			string m3WCNP = null, 
			string m3AVEF = null, 
			int? m3CHNO = null, 
			int? m3PMSR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetShiftInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PLGR))
				throw new ArgumentNullException(nameof(m3PLGR));
			if (string.IsNullOrWhiteSpace(m3SHFC))
				throw new ArgumentNullException(nameof(m3SHFC));
			if (string.IsNullOrWhiteSpace(m3VALT))
				throw new ArgumentNullException(nameof(m3VALT));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PLGR", m3PLGR.Trim())
				.WithQueryParameter("SHFC", m3SHFC.Trim())
				.WithQueryParameter("VALT", m3VALT.Trim())
				.WithQueryParameter("FRDT", m3FRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3WCNR))
				request.WithQueryParameter("WCNR", m3WCNR.Trim());
			if (!string.IsNullOrWhiteSpace(m3WCNM))
				request.WithQueryParameter("WCNM", m3WCNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3WCNP))
				request.WithQueryParameter("WCNP", m3WCNP.Trim());
			if (!string.IsNullOrWhiteSpace(m3AVEF))
				request.WithQueryParameter("AVEF", m3AVEF.Trim());
			if (m3CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3CHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PMSR.HasValue)
				request.WithQueryParameter("PMSR", m3PMSR.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetShiftInfoResponse>(
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
		/// Name GetShiftPatAdj
		/// Description Retrieve shift pattern adjustment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PLGR">Work center (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetShiftPatAdjResponse></returns>
		/// <exception cref="M3Exception<GetShiftPatAdjResponse>"></exception>
		public async Task<M3Response<GetShiftPatAdjResponse>> GetShiftPatAdj(
			string m3FACI, 
			string m3PLGR, 
			DateTime m3FRDT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetShiftPatAdj",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PLGR))
				throw new ArgumentNullException(nameof(m3PLGR));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PLGR", m3PLGR.Trim())
				.WithQueryParameter("FRDT", m3FRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetShiftPatAdjResponse>(
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
		/// Name List
		/// Description List
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3FACI = null, 
			string m3PLGR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/List",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());

			// Execute the request
			var result = await Execute<ListResponse>(
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
		/// Name LstDailyCap
		/// Description List daily Capacity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3PLTP">Resource type</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3FRDT">From date</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="m3SKNW">Skip non working days</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDailyCapResponse></returns>
		/// <exception cref="M3Exception<LstDailyCapResponse>"></exception>
		public async Task<M3Response<LstDailyCapResponse>> LstDailyCap(
			string m3FACI, 
			int? m3CONO = null, 
			string m3PLGR = null, 
			string m3PLTP = null, 
			string m3REAR = null, 
			string m3DEPT = null, 
			DateTime? m3FRDT = null, 
			DateTime? m3TODT = null, 
			int? m3SKNW = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDailyCap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLTP))
				request.WithQueryParameter("PLTP", m3PLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (m3FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3FRDT.Value.ToM3String());
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());
			if (m3SKNW.HasValue)
				request.WithQueryParameter("SKNW", m3SKNW.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstDailyCapResponse>(
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
		/// Name LstRelPerRes
		/// Description List resource relations by resource
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PLG6">Work center resource</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRelPerResResponse></returns>
		/// <exception cref="M3Exception<LstRelPerResResponse>"></exception>
		public async Task<M3Response<LstRelPerResResponse>> LstRelPerRes(
			string m3FACI, 
			string m3PLG6 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstRelPerRes",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PLG6))
				request.WithQueryParameter("PLG6", m3PLG6.Trim());

			// Execute the request
			var result = await Execute<LstRelPerResResponse>(
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
		/// Name LstRelPerWC
		/// Description List resource relations by work center
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PLG1">Work center</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRelPerWCResponse></returns>
		/// <exception cref="M3Exception<LstRelPerWCResponse>"></exception>
		public async Task<M3Response<LstRelPerWCResponse>> LstRelPerWC(
			string m3FACI, 
			string m3PLG1 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstRelPerWC",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PLG1))
				request.WithQueryParameter("PLG1", m3PLG1.Trim());

			// Execute the request
			var result = await Execute<LstRelPerWCResponse>(
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
		/// Name SelRelations
		/// Description Select work center relationships
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FFAC">From facility (Required)</param>
		/// <param name="m3TFAC">To facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PLTP">Resource type</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelRelationsResponse></returns>
		/// <exception cref="M3Exception<SelRelationsResponse>"></exception>
		public async Task<M3Response<SelRelationsResponse>> SelRelations(
			string m3FFAC, 
			string m3TFAC, 
			int? m3CONO = null, 
			int? m3PLTP = null, 
			string m3WHGR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelRelations",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FFAC))
				throw new ArgumentNullException(nameof(m3FFAC));
			if (string.IsNullOrWhiteSpace(m3TFAC))
				throw new ArgumentNullException(nameof(m3TFAC));

			// Set mandatory parameters
			request
				.WithQueryParameter("FFAC", m3FFAC.Trim())
				.WithQueryParameter("TFAC", m3TFAC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLTP.HasValue)
				request.WithQueryParameter("PLTP", m3PLTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());

			// Execute the request
			var result = await Execute<SelRelationsResponse>(
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
		/// Name SelShiftInfo
		/// Description Select work center - shift records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FFAC">From facility (Required)</param>
		/// <param name="m3TFAC">To facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PLTP">Resource type</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelShiftInfoResponse></returns>
		/// <exception cref="M3Exception<SelShiftInfoResponse>"></exception>
		public async Task<M3Response<SelShiftInfoResponse>> SelShiftInfo(
			string m3FFAC, 
			string m3TFAC, 
			int? m3CONO = null, 
			int? m3PLTP = null, 
			string m3WHGR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelShiftInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FFAC))
				throw new ArgumentNullException(nameof(m3FFAC));
			if (string.IsNullOrWhiteSpace(m3TFAC))
				throw new ArgumentNullException(nameof(m3TFAC));

			// Set mandatory parameters
			request
				.WithQueryParameter("FFAC", m3FFAC.Trim())
				.WithQueryParameter("TFAC", m3TFAC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLTP.HasValue)
				request.WithQueryParameter("PLTP", m3PLTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());

			// Execute the request
			var result = await Execute<SelShiftInfoResponse>(
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
		/// Name SelShiftPatAdj
		/// Description Select shift pattern adjustment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FFAC">From facility (Required)</param>
		/// <param name="m3TFAC">To facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PLTP">Resource type</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelShiftPatAdjResponse></returns>
		/// <exception cref="M3Exception<SelShiftPatAdjResponse>"></exception>
		public async Task<M3Response<SelShiftPatAdjResponse>> SelShiftPatAdj(
			string m3FFAC, 
			string m3TFAC, 
			int? m3CONO = null, 
			int? m3PLTP = null, 
			string m3WHGR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelShiftPatAdj",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FFAC))
				throw new ArgumentNullException(nameof(m3FFAC));
			if (string.IsNullOrWhiteSpace(m3TFAC))
				throw new ArgumentNullException(nameof(m3TFAC));

			// Set mandatory parameters
			request
				.WithQueryParameter("FFAC", m3FFAC.Trim())
				.WithQueryParameter("TFAC", m3TFAC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLTP.HasValue)
				request.WithQueryParameter("PLTP", m3PLTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());

			// Execute the request
			var result = await Execute<SelShiftPatAdjResponse>(
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
		/// Name SelTranspTimes
		/// Description Select transport and queue times
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FFAC">From facility (Required)</param>
		/// <param name="m3TFAC">To facility (Required)</param>
		/// <param name="m3TTTP">Transport time type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelTranspTimesResponse></returns>
		/// <exception cref="M3Exception<SelTranspTimesResponse>"></exception>
		public async Task<M3Response<SelTranspTimesResponse>> SelTranspTimes(
			string m3FFAC, 
			string m3TFAC, 
			int m3TTTP, 
			int? m3CONO = null, 
			string m3WHGR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelTranspTimes",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FFAC))
				throw new ArgumentNullException(nameof(m3FFAC));
			if (string.IsNullOrWhiteSpace(m3TFAC))
				throw new ArgumentNullException(nameof(m3TFAC));

			// Set mandatory parameters
			request
				.WithQueryParameter("FFAC", m3FFAC.Trim())
				.WithQueryParameter("TFAC", m3TFAC.Trim())
				.WithQueryParameter("TTTP", m3TTTP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());

			// Execute the request
			var result = await Execute<SelTranspTimesResponse>(
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
		/// Name Select
		/// Description Select work centers
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3FFAC">From facility (Required)</param>
		/// <param name="m3TFAC">To facility (Required)</param>
		/// <param name="m3PLTP">Resource type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3CRTR">Critical resource</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectResponse></returns>
		/// <exception cref="M3Exception<SelectResponse>"></exception>
		public async Task<M3Response<SelectResponse>> Select(
			string m3FFAC, 
			string m3TFAC, 
			string m3PLTP, 
			int? m3CONO = null, 
			string m3WHGR = null, 
			int? m3CRTR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Select",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FFAC))
				throw new ArgumentNullException(nameof(m3FFAC));
			if (string.IsNullOrWhiteSpace(m3TFAC))
				throw new ArgumentNullException(nameof(m3TFAC));
			if (string.IsNullOrWhiteSpace(m3PLTP))
				throw new ArgumentNullException(nameof(m3PLTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("FFAC", m3FFAC.Trim())
				.WithQueryParameter("TFAC", m3TFAC.Trim())
				.WithQueryParameter("PLTP", m3PLTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (m3CRTR.HasValue)
				request.WithQueryParameter("CRTR", m3CRTR.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelectResponse>(
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
		/// Name UpdWorkCenter
		/// Description Update Work Center
		/// Version Release: 
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3PLNM">Name</param>
		/// <param name="m3PLTP">Resource type</param>
		/// <param name="m3IIWC">Included in work center</param>
		/// <param name="m3WCRE">Work center responsible</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3QUAC">Quality inspection</param>
		/// <param name="m3PLGT">Work center type</param>
		/// <param name="m3CRTR">Critical resource</param>
		/// <param name="m3COCE">Cost center</param>
		/// <param name="m3CINA">Create cost accounting transactions</param>
		/// <param name="m3CPTY">Capacity per unit and shift</param>
		/// <param name="m3PCAP">Capacity type</param>
		/// <param name="m3ACAP">Alternate capacity</param>
		/// <param name="m3RCUN">Alternate capacity U/M</param>
		/// <param name="m3SHPA">Shift pattern</param>
		/// <param name="m3PRLN">Production line</param>
		/// <param name="m3WCNM">Number of machines</param>
		/// <param name="m3WCNP">Number of persons</param>
		/// <param name="m3SHFT">Number of shifts</param>
		/// <param name="m3AVEF">Utilization rate</param>
		/// <param name="m3PLHZ">Planning horizon</param>
		/// <param name="m3EFCH">Efficiency control</param>
		/// <param name="m3LVDY">Daily load leveling</param>
		/// <param name="m3RATP">Production rate display code</param>
		/// <param name="m3DPLH">Weekly load leveling</param>
		/// <param name="m3GEOX">Geographic cod X</param>
		/// <param name="m3GEOY">Geographic code Y</param>
		/// <param name="m3GEOZ">Geographic cod  Z</param>
		/// <param name="m3AUIN">Automatic receipt</param>
		/// <param name="m3PLGD">Default resource</param>
		/// <param name="m3AURP">Automatic operation reporting</param>
		/// <param name="m3KANB">Item location issue</param>
		/// <param name="m3VEOC">Verify operation closing</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="m3KYRE">Flow order resource</param>
		/// <param name="m3RWCD">Load reduction method</param>
		/// <param name="m3WLDE">Infinite/finite</param>
		/// <param name="m3AMAO">Additional material offset</param>
		/// <param name="m3DAFA">Day factor</param>
		/// <param name="m3VAPC">Option percentage</param>
		/// <param name="m3QUDY">Queue days</param>
		/// <param name="m3RAUM">Reporting in alternate U/M</param>
		/// <param name="m3PSQT">Co-sorting identity</param>
		/// <param name="m3SOFD">CO-sort feature or drawing measurement</param>
		/// <param name="m3FITP">From item position</param>
		/// <param name="m3TITP">To item position</param>
		/// <param name="m3PIDS">Panel identity - MO W/C schedule</param>
		/// <param name="m3PIDW">Panel identity - WO W/C schedule</param>
		/// <param name="m3PLLT">Lot number control</param>
		/// <param name="m3OPDS">Operation description</param>
		/// <param name="m3PRNP">Planned number of workers - run time</param>
		/// <param name="m3SENP">Planned number of workers - setup</param>
		/// <param name="m3PRNM">Planned number of machines</param>
		/// <param name="m3SWQT">Setup scrap</param>
		/// <param name="m3SCPC">Scrap percentage</param>
		/// <param name="m3PLOQ">Production lot size</param>
		/// <param name="m3SETI">Setup time</param>
		/// <param name="m3PITI">Run time</param>
		/// <param name="m3OSET">External setup time</param>
		/// <param name="m3PTUN">Time U/M</param>
		/// <param name="m3CTCD">Price and time quantity</param>
		/// <param name="m3FXTI">Fixed time</param>
		/// <param name="m3SEPR">Setup price</param>
		/// <param name="m3PIPR">Unit price</param>
		/// <param name="m3PDCC">Number of price decimal places</param>
		/// <param name="m3KIWG">Pay element</param>
		/// <param name="m3WCRF">Time reference</param>
		/// <param name="m3SLAC">Transport value in days</param>
		/// <param name="m3SLAT">Transit unit of measure/Overlap code</param>
		/// <param name="m3CAMP">Number of labor tickets</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3DOID">Document identity</param>
		/// <param name="m3TOOL">Tool number</param>
		/// <param name="m3SHBP">Shipping buffer in production days</param>
		/// <param name="m3SEQP">Sequencing priority</param>
		/// <param name="m3ACZO">Work zone</param>
		/// <param name="m3PRET">Preparation time</param>
		/// <param name="m3CAPL">Capacity level</param>
		/// <param name="m3AVQT">Average queue time</param>
		/// <param name="m3ACOL">Activity color</param>
		/// <param name="m3LDPR">Loading principle</param>
		/// <param name="m3MDOP">Max duration of operation in percent</param>
		/// <param name="m3FUMT">Fill method</param>
		/// <param name="m3POTM">Post-operation time</param>
		/// <param name="m3MINR">Minimum restriction</param>
		/// <param name="m3CPOT">Continuous post-opr time</param>
		/// <param name="m3MAXR">Maximum restriction</param>
		/// <param name="m3MPTF">Operator time factor</param>
		/// <param name="m3UNIT">Unit of measure</param>
		/// <param name="m3GRMU">Oven load U/M</param>
		/// <param name="m3GRMX">Maximum oven load</param>
		/// <param name="m3AVFL">Average load percentage</param>
		/// <param name="m3BAME">Batch sizing method</param>
		/// <param name="m3BAMI">Minimum batch size</param>
		/// <param name="m3BAML">Minimum level percentage</param>
		/// <param name="m3BAMA">Maximum batch size</param>
		/// <param name="m3BASL">Step level percentage</param>
		/// <param name="m3BASS">Multiple batch size</param>
		/// <param name="m3BARD">Surplus rule</param>
		/// <param name="m3BAFD">Frozen horizon</param>
		/// <param name="m3BALD">Sequence lock horizon</param>
		/// <param name="m3BASD">Slushy horizon</param>
		/// <param name="m3RETL">Return location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdWorkCenter(
			string m3FACI = null, 
			string m3PLGR = null, 
			string m3PLNM = null, 
			string m3PLTP = null, 
			string m3IIWC = null, 
			string m3WCRE = null, 
			string m3DEPT = null, 
			string m3REAR = null, 
			int? m3QUAC = null, 
			string m3PLGT = null, 
			int? m3CRTR = null, 
			string m3COCE = null, 
			int? m3CINA = null, 
			decimal? m3CPTY = null, 
			string m3PCAP = null, 
			decimal? m3ACAP = null, 
			string m3RCUN = null, 
			string m3SHPA = null, 
			int? m3PRLN = null, 
			int? m3WCNM = null, 
			int? m3WCNP = null, 
			int? m3SHFT = null, 
			int? m3AVEF = null, 
			int? m3PLHZ = null, 
			int? m3EFCH = null, 
			int? m3LVDY = null, 
			int? m3RATP = null, 
			int? m3DPLH = null, 
			decimal? m3GEOX = null, 
			decimal? m3GEOY = null, 
			decimal? m3GEOZ = null, 
			int? m3AUIN = null, 
			string m3PLGD = null, 
			int? m3AURP = null, 
			int? m3KANB = null, 
			int? m3VEOC = null, 
			string m3WHLO = null, 
			string m3WHSL = null, 
			string m3TWSL = null, 
			int? m3KYRE = null, 
			string m3RWCD = null, 
			int? m3WLDE = null, 
			int? m3AMAO = null, 
			int? m3DAFA = null, 
			int? m3VAPC = null, 
			int? m3QUDY = null, 
			int? m3RAUM = null, 
			int? m3PSQT = null, 
			string m3SOFD = null, 
			int? m3FITP = null, 
			int? m3TITP = null, 
			string m3PIDS = null, 
			string m3PIDW = null, 
			int? m3PLLT = null, 
			string m3OPDS = null, 
			int? m3PRNP = null, 
			int? m3SENP = null, 
			int? m3PRNM = null, 
			decimal? m3SWQT = null, 
			int? m3SCPC = null, 
			decimal? m3PLOQ = null, 
			int? m3SETI = null, 
			int? m3PITI = null, 
			int? m3OSET = null, 
			string m3PTUN = null, 
			int? m3CTCD = null, 
			int? m3FXTI = null, 
			decimal? m3SEPR = null, 
			decimal? m3PIPR = null, 
			int? m3PDCC = null, 
			int? m3KIWG = null, 
			string m3WCRF = null, 
			decimal? m3SLAC = null, 
			string m3SLAT = null, 
			int? m3CAMP = null, 
			string m3SUNO = null, 
			string m3DOID = null, 
			string m3TOOL = null, 
			int? m3SHBP = null, 
			int? m3SEQP = null, 
			string m3ACZO = null, 
			int? m3PRET = null, 
			int? m3CAPL = null, 
			int? m3AVQT = null, 
			int? m3ACOL = null, 
			int? m3LDPR = null, 
			int? m3MDOP = null, 
			int? m3FUMT = null, 
			int? m3POTM = null, 
			string m3MINR = null, 
			int? m3CPOT = null, 
			string m3MAXR = null, 
			int? m3MPTF = null, 
			string m3UNIT = null, 
			int? m3GRMU = null, 
			long? m3GRMX = null, 
			int? m3AVFL = null, 
			int? m3BAME = null, 
			decimal? m3BAMI = null, 
			int? m3BAML = null, 
			decimal? m3BAMA = null, 
			int? m3BASL = null, 
			decimal? m3BASS = null, 
			int? m3BARD = null, 
			int? m3BAFD = null, 
			int? m3BALD = null, 
			int? m3BASD = null, 
			string m3RETL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdWorkCenter",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLNM))
				request.WithQueryParameter("PLNM", m3PLNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLTP))
				request.WithQueryParameter("PLTP", m3PLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3IIWC))
				request.WithQueryParameter("IIWC", m3IIWC.Trim());
			if (!string.IsNullOrWhiteSpace(m3WCRE))
				request.WithQueryParameter("WCRE", m3WCRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (m3QUAC.HasValue)
				request.WithQueryParameter("QUAC", m3QUAC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLGT))
				request.WithQueryParameter("PLGT", m3PLGT.Trim());
			if (m3CRTR.HasValue)
				request.WithQueryParameter("CRTR", m3CRTR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3COCE))
				request.WithQueryParameter("COCE", m3COCE.Trim());
			if (m3CINA.HasValue)
				request.WithQueryParameter("CINA", m3CINA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CPTY.HasValue)
				request.WithQueryParameter("CPTY", m3CPTY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PCAP))
				request.WithQueryParameter("PCAP", m3PCAP.Trim());
			if (m3ACAP.HasValue)
				request.WithQueryParameter("ACAP", m3ACAP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RCUN))
				request.WithQueryParameter("RCUN", m3RCUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SHPA))
				request.WithQueryParameter("SHPA", m3SHPA.Trim());
			if (m3PRLN.HasValue)
				request.WithQueryParameter("PRLN", m3PRLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WCNM.HasValue)
				request.WithQueryParameter("WCNM", m3WCNM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WCNP.HasValue)
				request.WithQueryParameter("WCNP", m3WCNP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHFT.HasValue)
				request.WithQueryParameter("SHFT", m3SHFT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AVEF.HasValue)
				request.WithQueryParameter("AVEF", m3AVEF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLHZ.HasValue)
				request.WithQueryParameter("PLHZ", m3PLHZ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EFCH.HasValue)
				request.WithQueryParameter("EFCH", m3EFCH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LVDY.HasValue)
				request.WithQueryParameter("LVDY", m3LVDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RATP.HasValue)
				request.WithQueryParameter("RATP", m3RATP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DPLH.HasValue)
				request.WithQueryParameter("DPLH", m3DPLH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEOX.HasValue)
				request.WithQueryParameter("GEOX", m3GEOX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEOY.HasValue)
				request.WithQueryParameter("GEOY", m3GEOY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEOZ.HasValue)
				request.WithQueryParameter("GEOZ", m3GEOZ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUIN.HasValue)
				request.WithQueryParameter("AUIN", m3AUIN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLGD))
				request.WithQueryParameter("PLGD", m3PLGD.Trim());
			if (m3AURP.HasValue)
				request.WithQueryParameter("AURP", m3AURP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KANB.HasValue)
				request.WithQueryParameter("KANB", m3KANB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VEOC.HasValue)
				request.WithQueryParameter("VEOC", m3VEOC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (m3KYRE.HasValue)
				request.WithQueryParameter("KYRE", m3KYRE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RWCD))
				request.WithQueryParameter("RWCD", m3RWCD.Trim());
			if (m3WLDE.HasValue)
				request.WithQueryParameter("WLDE", m3WLDE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMAO.HasValue)
				request.WithQueryParameter("AMAO", m3AMAO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DAFA.HasValue)
				request.WithQueryParameter("DAFA", m3DAFA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VAPC.HasValue)
				request.WithQueryParameter("VAPC", m3VAPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QUDY.HasValue)
				request.WithQueryParameter("QUDY", m3QUDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RAUM.HasValue)
				request.WithQueryParameter("RAUM", m3RAUM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PSQT.HasValue)
				request.WithQueryParameter("PSQT", m3PSQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SOFD))
				request.WithQueryParameter("SOFD", m3SOFD.Trim());
			if (m3FITP.HasValue)
				request.WithQueryParameter("FITP", m3FITP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TITP.HasValue)
				request.WithQueryParameter("TITP", m3TITP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PIDS))
				request.WithQueryParameter("PIDS", m3PIDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3PIDW))
				request.WithQueryParameter("PIDW", m3PIDW.Trim());
			if (m3PLLT.HasValue)
				request.WithQueryParameter("PLLT", m3PLLT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OPDS))
				request.WithQueryParameter("OPDS", m3OPDS.Trim());
			if (m3PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3PRNP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SENP.HasValue)
				request.WithQueryParameter("SENP", m3SENP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNM.HasValue)
				request.WithQueryParameter("PRNM", m3PRNM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SWQT.HasValue)
				request.WithQueryParameter("SWQT", m3SWQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCPC.HasValue)
				request.WithQueryParameter("SCPC", m3SCPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLOQ.HasValue)
				request.WithQueryParameter("PLOQ", m3PLOQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SETI.HasValue)
				request.WithQueryParameter("SETI", m3SETI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PITI.HasValue)
				request.WithQueryParameter("PITI", m3PITI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OSET.HasValue)
				request.WithQueryParameter("OSET", m3OSET.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PTUN))
				request.WithQueryParameter("PTUN", m3PTUN.Trim());
			if (m3CTCD.HasValue)
				request.WithQueryParameter("CTCD", m3CTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FXTI.HasValue)
				request.WithQueryParameter("FXTI", m3FXTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SEPR.HasValue)
				request.WithQueryParameter("SEPR", m3SEPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PIPR.HasValue)
				request.WithQueryParameter("PIPR", m3PIPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PDCC.HasValue)
				request.WithQueryParameter("PDCC", m3PDCC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KIWG.HasValue)
				request.WithQueryParameter("KIWG", m3KIWG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WCRF))
				request.WithQueryParameter("WCRF", m3WCRF.Trim());
			if (m3SLAC.HasValue)
				request.WithQueryParameter("SLAC", m3SLAC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SLAT))
				request.WithQueryParameter("SLAT", m3SLAT.Trim());
			if (m3CAMP.HasValue)
				request.WithQueryParameter("CAMP", m3CAMP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOOL))
				request.WithQueryParameter("TOOL", m3TOOL.Trim());
			if (m3SHBP.HasValue)
				request.WithQueryParameter("SHBP", m3SHBP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SEQP.HasValue)
				request.WithQueryParameter("SEQP", m3SEQP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACZO))
				request.WithQueryParameter("ACZO", m3ACZO.Trim());
			if (m3PRET.HasValue)
				request.WithQueryParameter("PRET", m3PRET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAPL.HasValue)
				request.WithQueryParameter("CAPL", m3CAPL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AVQT.HasValue)
				request.WithQueryParameter("AVQT", m3AVQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACOL.HasValue)
				request.WithQueryParameter("ACOL", m3ACOL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LDPR.HasValue)
				request.WithQueryParameter("LDPR", m3LDPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MDOP.HasValue)
				request.WithQueryParameter("MDOP", m3MDOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FUMT.HasValue)
				request.WithQueryParameter("FUMT", m3FUMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POTM.HasValue)
				request.WithQueryParameter("POTM", m3POTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MINR))
				request.WithQueryParameter("MINR", m3MINR.Trim());
			if (m3CPOT.HasValue)
				request.WithQueryParameter("CPOT", m3CPOT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MAXR))
				request.WithQueryParameter("MAXR", m3MAXR.Trim());
			if (m3MPTF.HasValue)
				request.WithQueryParameter("MPTF", m3MPTF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3UNIT))
				request.WithQueryParameter("UNIT", m3UNIT.Trim());
			if (m3GRMU.HasValue)
				request.WithQueryParameter("GRMU", m3GRMU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRMX.HasValue)
				request.WithQueryParameter("GRMX", m3GRMX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AVFL.HasValue)
				request.WithQueryParameter("AVFL", m3AVFL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BAME.HasValue)
				request.WithQueryParameter("BAME", m3BAME.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BAMI.HasValue)
				request.WithQueryParameter("BAMI", m3BAMI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BAML.HasValue)
				request.WithQueryParameter("BAML", m3BAML.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BAMA.HasValue)
				request.WithQueryParameter("BAMA", m3BAMA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BASL.HasValue)
				request.WithQueryParameter("BASL", m3BASL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BASS.HasValue)
				request.WithQueryParameter("BASS", m3BASS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BARD.HasValue)
				request.WithQueryParameter("BARD", m3BARD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BAFD.HasValue)
				request.WithQueryParameter("BAFD", m3BAFD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BALD.HasValue)
				request.WithQueryParameter("BALD", m3BALD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BASD.HasValue)
				request.WithQueryParameter("BASD", m3BASD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RETL))
				request.WithQueryParameter("RETL", m3RETL.Trim());

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
