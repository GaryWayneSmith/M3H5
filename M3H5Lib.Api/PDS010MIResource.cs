/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PLG1">Work center (Required)</param>
		/// <param name="m3_PLG6">Work center resource (Required)</param>
		/// <param name="m3_DSCR">Description (Required)</param>
		/// <param name="m3_PRIR">Work center priority</param>
		/// <param name="m3_PLGF">Forced resource</param>
		/// <param name="m3_PLGN">Norm resource</param>
		/// <param name="m3_EFFA">Efficiency factor</param>
		/// <param name="m3_RPLF">Line control</param>
		/// <param name="m3_SECR">Preferred resource</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddRelation(
			string m3_FACI, 
			string m3_PLG1, 
			string m3_PLG6, 
			string m3_DSCR, 
			string m3_PRIR = null, 
			string m3_PLGF = null, 
			string m3_PLGN = null, 
			int? m3_EFFA = null, 
			int? m3_RPLF = null, 
			int? m3_SECR = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PLG1))
				throw new ArgumentNullException("m3_PLG1");
			if (string.IsNullOrWhiteSpace(m3_PLG6))
				throw new ArgumentNullException("m3_PLG6");
			if (string.IsNullOrWhiteSpace(m3_DSCR))
				throw new ArgumentNullException("m3_DSCR");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PLG1", m3_PLG1.Trim())
				.WithQueryParameter("PLG6", m3_PLG6.Trim())
				.WithQueryParameter("DSCR", m3_DSCR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRIR))
				request.WithQueryParameter("PRIR", m3_PRIR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGF))
				request.WithQueryParameter("PLGF", m3_PLGF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGN))
				request.WithQueryParameter("PLGN", m3_PLGN.Trim());
			if (m3_EFFA.HasValue)
				request.WithQueryParameter("EFFA", m3_EFFA.Value.ToString());
			if (m3_RPLF.HasValue)
				request.WithQueryParameter("RPLF", m3_RPLF.Value.ToString());
			if (m3_SECR.HasValue)
				request.WithQueryParameter("SECR", m3_SECR.Value.ToString());

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
		/// Name AddShiftInfo
		/// Description Add work center - shift record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PLGR">Work center (Required)</param>
		/// <param name="m3_SHFC">Shift (Required)</param>
		/// <param name="m3_VALT">Validity type (Required)</param>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_TODT">To date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WCNR">Number of resources</param>
		/// <param name="m3_WCNM">Number of machines</param>
		/// <param name="m3_WCNP">Number of persons</param>
		/// <param name="m3_AVEF">Utilization rate</param>
		/// <param name="m3_CHNO">Change number</param>
		/// <param name="m3_PMSR">APP shift reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddShiftInfo(
			string m3_FACI, 
			string m3_PLGR, 
			string m3_SHFC, 
			int m3_VALT, 
			DateTime m3_FRDT, 
			DateTime m3_TODT, 
			int? m3_CONO = null, 
			int? m3_WCNR = null, 
			int? m3_WCNM = null, 
			int? m3_WCNP = null, 
			int? m3_AVEF = null, 
			int? m3_CHNO = null, 
			int? m3_PMSR = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PLGR))
				throw new ArgumentNullException("m3_PLGR");
			if (string.IsNullOrWhiteSpace(m3_SHFC))
				throw new ArgumentNullException("m3_SHFC");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PLGR", m3_PLGR.Trim())
				.WithQueryParameter("SHFC", m3_SHFC.Trim())
				.WithQueryParameter("VALT", m3_VALT.ToString())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String())
				.WithQueryParameter("TODT", m3_TODT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_WCNR.HasValue)
				request.WithQueryParameter("WCNR", m3_WCNR.Value.ToString());
			if (m3_WCNM.HasValue)
				request.WithQueryParameter("WCNM", m3_WCNM.Value.ToString());
			if (m3_WCNP.HasValue)
				request.WithQueryParameter("WCNP", m3_WCNP.Value.ToString());
			if (m3_AVEF.HasValue)
				request.WithQueryParameter("AVEF", m3_AVEF.Value.ToString());
			if (m3_CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3_CHNO.Value.ToString());
			if (m3_PMSR.HasValue)
				request.WithQueryParameter("PMSR", m3_PMSR.Value.ToString());

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
		/// Name AddShiftPatAdj
		/// Description Add shift pattern adjustment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PLGR">Work center (Required)</param>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_TODT">To date (Required)</param>
		/// <param name="m3_SHPA">Shift pattern (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CHNO">Change number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddShiftPatAdj(
			string m3_FACI, 
			string m3_PLGR, 
			DateTime m3_FRDT, 
			DateTime m3_TODT, 
			string m3_SHPA, 
			int? m3_CONO = null, 
			int? m3_CHNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PLGR))
				throw new ArgumentNullException("m3_PLGR");
			if (string.IsNullOrWhiteSpace(m3_SHPA))
				throw new ArgumentNullException("m3_SHPA");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PLGR", m3_PLGR.Trim())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String())
				.WithQueryParameter("TODT", m3_TODT.ToM3String())
				.WithQueryParameter("SHPA", m3_SHPA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3_CHNO.Value.ToString());

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
		/// Name AddWorkCenter
		/// Description Add Work Center
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_PLNM">Name</param>
		/// <param name="m3_PLTP">Resource type</param>
		/// <param name="m3_IIWC">Included in work center</param>
		/// <param name="m3_WCRE">Work center responsible</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_QUAC">Quality inspection</param>
		/// <param name="m3_PLGT">Work center type</param>
		/// <param name="m3_CRTR">Critical resource</param>
		/// <param name="m3_COCE">Cost center</param>
		/// <param name="m3_CINA">Create cost accounting transactions</param>
		/// <param name="m3_CPTY">Capacity per unit and shift</param>
		/// <param name="m3_PCAP">Capacity type</param>
		/// <param name="m3_ACAP">Alternate capacity</param>
		/// <param name="m3_RCUN">Alternate capacity U/M</param>
		/// <param name="m3_SHPA">Shift pattern</param>
		/// <param name="m3_PRLN">Production line</param>
		/// <param name="m3_WCNM">Number of machines</param>
		/// <param name="m3_WCNP">Number of persons</param>
		/// <param name="m3_SHFT">Number of shifts</param>
		/// <param name="m3_AVEF">Utilization rate</param>
		/// <param name="m3_PLHZ">Planning horizon</param>
		/// <param name="m3_EFCH">Efficiency control</param>
		/// <param name="m3_LVDY">Daily load leveling</param>
		/// <param name="m3_RATP">Production rate display code</param>
		/// <param name="m3_DPLH">Weekly load leveling</param>
		/// <param name="m3_GEOX">Geographic cod X</param>
		/// <param name="m3_GEOY">Geographic code Y</param>
		/// <param name="m3_GEOZ">Geographic cod  Z</param>
		/// <param name="m3_AUIN">Automatic receipt</param>
		/// <param name="m3_PLGD">Default resource</param>
		/// <param name="m3_AURP">Automatic operation reporting</param>
		/// <param name="m3_KANB">Item location issue</param>
		/// <param name="m3_VEOC">Verify operation closing</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="m3_KYRE">Flow order resource</param>
		/// <param name="m3_RWCD">Load reduction method</param>
		/// <param name="m3_WLDE">Infinite/finite</param>
		/// <param name="m3_AMAO">Additional material offset</param>
		/// <param name="m3_DAFA">Day factor</param>
		/// <param name="m3_VAPC">Option percentage</param>
		/// <param name="m3_QUDY">Queue days</param>
		/// <param name="m3_RAUM">Reporting in alternate U/M</param>
		/// <param name="m3_PSQT">Co-sorting identity</param>
		/// <param name="m3_SOFD">CO-sort feature or drawing measurement</param>
		/// <param name="m3_FITP">From item position</param>
		/// <param name="m3_TITP">To item position</param>
		/// <param name="m3_PIDS">Panel identity - MO W/C schedule</param>
		/// <param name="m3_PIDW">Panel identity - WO W/C schedule</param>
		/// <param name="m3_PLLT">Lot number control</param>
		/// <param name="m3_OPDS">Operation description</param>
		/// <param name="m3_PRNP">Planned number of workers - run time</param>
		/// <param name="m3_SENP">Planned number of workers - setup</param>
		/// <param name="m3_PRNM">Planned number of machines</param>
		/// <param name="m3_SWQT">Setup scrap</param>
		/// <param name="m3_SCPC">Scrap percentage</param>
		/// <param name="m3_PLOQ">Production lot size</param>
		/// <param name="m3_SETI">Setup time</param>
		/// <param name="m3_PITI">Run time</param>
		/// <param name="m3_OSET">External setup time</param>
		/// <param name="m3_PTUN">Time U/M</param>
		/// <param name="m3_CTCD">Price and time quantity</param>
		/// <param name="m3_FXTI">Fixed time</param>
		/// <param name="m3_SEPR">Setup price</param>
		/// <param name="m3_PIPR">Unit price</param>
		/// <param name="m3_PDCC">Number of price decimal places</param>
		/// <param name="m3_KIWG">Pay element</param>
		/// <param name="m3_WCRF">Time reference</param>
		/// <param name="m3_SLAC">Transport value in days</param>
		/// <param name="m3_SLAT">Transit unit of measure/Overlap code</param>
		/// <param name="m3_CAMP">Number of labor tickets</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_DOID">Document identity</param>
		/// <param name="m3_TOOL">Tool number</param>
		/// <param name="m3_SHBP">Shipping buffer in production days</param>
		/// <param name="m3_SEQP">Sequencing priority</param>
		/// <param name="m3_ACZO">Work zone</param>
		/// <param name="m3_PRET">Preparation time</param>
		/// <param name="m3_CAPL">Capacity level</param>
		/// <param name="m3_AVQT">Average queue time</param>
		/// <param name="m3_ACOL">Activity color</param>
		/// <param name="m3_LDPR">Loading principle</param>
		/// <param name="m3_MDOP">Max duration of operation in percent</param>
		/// <param name="m3_FUMT">Fill method</param>
		/// <param name="m3_POTM">Post-operation time</param>
		/// <param name="m3_MINR">Minimum restriction</param>
		/// <param name="m3_CPOT">Continuous post-opr time</param>
		/// <param name="m3_MAXR">Maximum restriction</param>
		/// <param name="m3_MPTF">Operator time factor</param>
		/// <param name="m3_UNIT">Unit of measure</param>
		/// <param name="m3_GRMU">Oven load U/M</param>
		/// <param name="m3_GRMX">Maximum oven load</param>
		/// <param name="m3_AVFL">Average load percentage</param>
		/// <param name="m3_BAME">Batch sizing method</param>
		/// <param name="m3_BAMI">Minimum batch size</param>
		/// <param name="m3_BAML">Minimum level percentage</param>
		/// <param name="m3_BAMA">Maximum batch size</param>
		/// <param name="m3_BASL">Step level percentage</param>
		/// <param name="m3_BASS">Multiple batch size</param>
		/// <param name="m3_BARD">Surplus rule</param>
		/// <param name="m3_BAFD">Frozen horizon</param>
		/// <param name="m3_BALD">Sequence lock horizon</param>
		/// <param name="m3_BASD">Slushy horizon</param>
		/// <param name="m3_RETL">Return location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddWorkCenter(
			string m3_FACI = null, 
			string m3_PLGR = null, 
			string m3_PLNM = null, 
			string m3_PLTP = null, 
			string m3_IIWC = null, 
			string m3_WCRE = null, 
			string m3_DEPT = null, 
			string m3_REAR = null, 
			int? m3_QUAC = null, 
			string m3_PLGT = null, 
			int? m3_CRTR = null, 
			string m3_COCE = null, 
			int? m3_CINA = null, 
			decimal? m3_CPTY = null, 
			string m3_PCAP = null, 
			decimal? m3_ACAP = null, 
			string m3_RCUN = null, 
			string m3_SHPA = null, 
			int? m3_PRLN = null, 
			int? m3_WCNM = null, 
			int? m3_WCNP = null, 
			int? m3_SHFT = null, 
			int? m3_AVEF = null, 
			int? m3_PLHZ = null, 
			int? m3_EFCH = null, 
			int? m3_LVDY = null, 
			int? m3_RATP = null, 
			int? m3_DPLH = null, 
			decimal? m3_GEOX = null, 
			decimal? m3_GEOY = null, 
			decimal? m3_GEOZ = null, 
			int? m3_AUIN = null, 
			string m3_PLGD = null, 
			int? m3_AURP = null, 
			int? m3_KANB = null, 
			int? m3_VEOC = null, 
			string m3_WHLO = null, 
			string m3_WHSL = null, 
			string m3_TWSL = null, 
			int? m3_KYRE = null, 
			string m3_RWCD = null, 
			int? m3_WLDE = null, 
			int? m3_AMAO = null, 
			int? m3_DAFA = null, 
			int? m3_VAPC = null, 
			int? m3_QUDY = null, 
			int? m3_RAUM = null, 
			int? m3_PSQT = null, 
			string m3_SOFD = null, 
			int? m3_FITP = null, 
			int? m3_TITP = null, 
			string m3_PIDS = null, 
			string m3_PIDW = null, 
			int? m3_PLLT = null, 
			string m3_OPDS = null, 
			int? m3_PRNP = null, 
			int? m3_SENP = null, 
			int? m3_PRNM = null, 
			decimal? m3_SWQT = null, 
			int? m3_SCPC = null, 
			decimal? m3_PLOQ = null, 
			int? m3_SETI = null, 
			int? m3_PITI = null, 
			int? m3_OSET = null, 
			string m3_PTUN = null, 
			int? m3_CTCD = null, 
			int? m3_FXTI = null, 
			decimal? m3_SEPR = null, 
			decimal? m3_PIPR = null, 
			int? m3_PDCC = null, 
			int? m3_KIWG = null, 
			string m3_WCRF = null, 
			decimal? m3_SLAC = null, 
			string m3_SLAT = null, 
			int? m3_CAMP = null, 
			string m3_SUNO = null, 
			string m3_DOID = null, 
			string m3_TOOL = null, 
			int? m3_SHBP = null, 
			int? m3_SEQP = null, 
			string m3_ACZO = null, 
			int? m3_PRET = null, 
			int? m3_CAPL = null, 
			int? m3_AVQT = null, 
			int? m3_ACOL = null, 
			int? m3_LDPR = null, 
			int? m3_MDOP = null, 
			int? m3_FUMT = null, 
			int? m3_POTM = null, 
			string m3_MINR = null, 
			int? m3_CPOT = null, 
			string m3_MAXR = null, 
			int? m3_MPTF = null, 
			string m3_UNIT = null, 
			int? m3_GRMU = null, 
			long? m3_GRMX = null, 
			int? m3_AVFL = null, 
			int? m3_BAME = null, 
			decimal? m3_BAMI = null, 
			int? m3_BAML = null, 
			decimal? m3_BAMA = null, 
			int? m3_BASL = null, 
			decimal? m3_BASS = null, 
			int? m3_BARD = null, 
			int? m3_BAFD = null, 
			int? m3_BALD = null, 
			int? m3_BASD = null, 
			string m3_RETL = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLNM))
				request.WithQueryParameter("PLNM", m3_PLNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLTP))
				request.WithQueryParameter("PLTP", m3_PLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IIWC))
				request.WithQueryParameter("IIWC", m3_IIWC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WCRE))
				request.WithQueryParameter("WCRE", m3_WCRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (m3_QUAC.HasValue)
				request.WithQueryParameter("QUAC", m3_QUAC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLGT))
				request.WithQueryParameter("PLGT", m3_PLGT.Trim());
			if (m3_CRTR.HasValue)
				request.WithQueryParameter("CRTR", m3_CRTR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_COCE))
				request.WithQueryParameter("COCE", m3_COCE.Trim());
			if (m3_CINA.HasValue)
				request.WithQueryParameter("CINA", m3_CINA.Value.ToString());
			if (m3_CPTY.HasValue)
				request.WithQueryParameter("CPTY", m3_CPTY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PCAP))
				request.WithQueryParameter("PCAP", m3_PCAP.Trim());
			if (m3_ACAP.HasValue)
				request.WithQueryParameter("ACAP", m3_ACAP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RCUN))
				request.WithQueryParameter("RCUN", m3_RCUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SHPA))
				request.WithQueryParameter("SHPA", m3_SHPA.Trim());
			if (m3_PRLN.HasValue)
				request.WithQueryParameter("PRLN", m3_PRLN.Value.ToString());
			if (m3_WCNM.HasValue)
				request.WithQueryParameter("WCNM", m3_WCNM.Value.ToString());
			if (m3_WCNP.HasValue)
				request.WithQueryParameter("WCNP", m3_WCNP.Value.ToString());
			if (m3_SHFT.HasValue)
				request.WithQueryParameter("SHFT", m3_SHFT.Value.ToString());
			if (m3_AVEF.HasValue)
				request.WithQueryParameter("AVEF", m3_AVEF.Value.ToString());
			if (m3_PLHZ.HasValue)
				request.WithQueryParameter("PLHZ", m3_PLHZ.Value.ToString());
			if (m3_EFCH.HasValue)
				request.WithQueryParameter("EFCH", m3_EFCH.Value.ToString());
			if (m3_LVDY.HasValue)
				request.WithQueryParameter("LVDY", m3_LVDY.Value.ToString());
			if (m3_RATP.HasValue)
				request.WithQueryParameter("RATP", m3_RATP.Value.ToString());
			if (m3_DPLH.HasValue)
				request.WithQueryParameter("DPLH", m3_DPLH.Value.ToString());
			if (m3_GEOX.HasValue)
				request.WithQueryParameter("GEOX", m3_GEOX.Value.ToString());
			if (m3_GEOY.HasValue)
				request.WithQueryParameter("GEOY", m3_GEOY.Value.ToString());
			if (m3_GEOZ.HasValue)
				request.WithQueryParameter("GEOZ", m3_GEOZ.Value.ToString());
			if (m3_AUIN.HasValue)
				request.WithQueryParameter("AUIN", m3_AUIN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLGD))
				request.WithQueryParameter("PLGD", m3_PLGD.Trim());
			if (m3_AURP.HasValue)
				request.WithQueryParameter("AURP", m3_AURP.Value.ToString());
			if (m3_KANB.HasValue)
				request.WithQueryParameter("KANB", m3_KANB.Value.ToString());
			if (m3_VEOC.HasValue)
				request.WithQueryParameter("VEOC", m3_VEOC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (m3_KYRE.HasValue)
				request.WithQueryParameter("KYRE", m3_KYRE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RWCD))
				request.WithQueryParameter("RWCD", m3_RWCD.Trim());
			if (m3_WLDE.HasValue)
				request.WithQueryParameter("WLDE", m3_WLDE.Value.ToString());
			if (m3_AMAO.HasValue)
				request.WithQueryParameter("AMAO", m3_AMAO.Value.ToString());
			if (m3_DAFA.HasValue)
				request.WithQueryParameter("DAFA", m3_DAFA.Value.ToString());
			if (m3_VAPC.HasValue)
				request.WithQueryParameter("VAPC", m3_VAPC.Value.ToString());
			if (m3_QUDY.HasValue)
				request.WithQueryParameter("QUDY", m3_QUDY.Value.ToString());
			if (m3_RAUM.HasValue)
				request.WithQueryParameter("RAUM", m3_RAUM.Value.ToString());
			if (m3_PSQT.HasValue)
				request.WithQueryParameter("PSQT", m3_PSQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SOFD))
				request.WithQueryParameter("SOFD", m3_SOFD.Trim());
			if (m3_FITP.HasValue)
				request.WithQueryParameter("FITP", m3_FITP.Value.ToString());
			if (m3_TITP.HasValue)
				request.WithQueryParameter("TITP", m3_TITP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PIDS))
				request.WithQueryParameter("PIDS", m3_PIDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PIDW))
				request.WithQueryParameter("PIDW", m3_PIDW.Trim());
			if (m3_PLLT.HasValue)
				request.WithQueryParameter("PLLT", m3_PLLT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OPDS))
				request.WithQueryParameter("OPDS", m3_OPDS.Trim());
			if (m3_PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3_PRNP.Value.ToString());
			if (m3_SENP.HasValue)
				request.WithQueryParameter("SENP", m3_SENP.Value.ToString());
			if (m3_PRNM.HasValue)
				request.WithQueryParameter("PRNM", m3_PRNM.Value.ToString());
			if (m3_SWQT.HasValue)
				request.WithQueryParameter("SWQT", m3_SWQT.Value.ToString());
			if (m3_SCPC.HasValue)
				request.WithQueryParameter("SCPC", m3_SCPC.Value.ToString());
			if (m3_PLOQ.HasValue)
				request.WithQueryParameter("PLOQ", m3_PLOQ.Value.ToString());
			if (m3_SETI.HasValue)
				request.WithQueryParameter("SETI", m3_SETI.Value.ToString());
			if (m3_PITI.HasValue)
				request.WithQueryParameter("PITI", m3_PITI.Value.ToString());
			if (m3_OSET.HasValue)
				request.WithQueryParameter("OSET", m3_OSET.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PTUN))
				request.WithQueryParameter("PTUN", m3_PTUN.Trim());
			if (m3_CTCD.HasValue)
				request.WithQueryParameter("CTCD", m3_CTCD.Value.ToString());
			if (m3_FXTI.HasValue)
				request.WithQueryParameter("FXTI", m3_FXTI.Value.ToString());
			if (m3_SEPR.HasValue)
				request.WithQueryParameter("SEPR", m3_SEPR.Value.ToString());
			if (m3_PIPR.HasValue)
				request.WithQueryParameter("PIPR", m3_PIPR.Value.ToString());
			if (m3_PDCC.HasValue)
				request.WithQueryParameter("PDCC", m3_PDCC.Value.ToString());
			if (m3_KIWG.HasValue)
				request.WithQueryParameter("KIWG", m3_KIWG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WCRF))
				request.WithQueryParameter("WCRF", m3_WCRF.Trim());
			if (m3_SLAC.HasValue)
				request.WithQueryParameter("SLAC", m3_SLAC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SLAT))
				request.WithQueryParameter("SLAT", m3_SLAT.Trim());
			if (m3_CAMP.HasValue)
				request.WithQueryParameter("CAMP", m3_CAMP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOOL))
				request.WithQueryParameter("TOOL", m3_TOOL.Trim());
			if (m3_SHBP.HasValue)
				request.WithQueryParameter("SHBP", m3_SHBP.Value.ToString());
			if (m3_SEQP.HasValue)
				request.WithQueryParameter("SEQP", m3_SEQP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACZO))
				request.WithQueryParameter("ACZO", m3_ACZO.Trim());
			if (m3_PRET.HasValue)
				request.WithQueryParameter("PRET", m3_PRET.Value.ToString());
			if (m3_CAPL.HasValue)
				request.WithQueryParameter("CAPL", m3_CAPL.Value.ToString());
			if (m3_AVQT.HasValue)
				request.WithQueryParameter("AVQT", m3_AVQT.Value.ToString());
			if (m3_ACOL.HasValue)
				request.WithQueryParameter("ACOL", m3_ACOL.Value.ToString());
			if (m3_LDPR.HasValue)
				request.WithQueryParameter("LDPR", m3_LDPR.Value.ToString());
			if (m3_MDOP.HasValue)
				request.WithQueryParameter("MDOP", m3_MDOP.Value.ToString());
			if (m3_FUMT.HasValue)
				request.WithQueryParameter("FUMT", m3_FUMT.Value.ToString());
			if (m3_POTM.HasValue)
				request.WithQueryParameter("POTM", m3_POTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MINR))
				request.WithQueryParameter("MINR", m3_MINR.Trim());
			if (m3_CPOT.HasValue)
				request.WithQueryParameter("CPOT", m3_CPOT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MAXR))
				request.WithQueryParameter("MAXR", m3_MAXR.Trim());
			if (m3_MPTF.HasValue)
				request.WithQueryParameter("MPTF", m3_MPTF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNIT))
				request.WithQueryParameter("UNIT", m3_UNIT.Trim());
			if (m3_GRMU.HasValue)
				request.WithQueryParameter("GRMU", m3_GRMU.Value.ToString());
			if (m3_GRMX.HasValue)
				request.WithQueryParameter("GRMX", m3_GRMX.Value.ToString());
			if (m3_AVFL.HasValue)
				request.WithQueryParameter("AVFL", m3_AVFL.Value.ToString());
			if (m3_BAME.HasValue)
				request.WithQueryParameter("BAME", m3_BAME.Value.ToString());
			if (m3_BAMI.HasValue)
				request.WithQueryParameter("BAMI", m3_BAMI.Value.ToString());
			if (m3_BAML.HasValue)
				request.WithQueryParameter("BAML", m3_BAML.Value.ToString());
			if (m3_BAMA.HasValue)
				request.WithQueryParameter("BAMA", m3_BAMA.Value.ToString());
			if (m3_BASL.HasValue)
				request.WithQueryParameter("BASL", m3_BASL.Value.ToString());
			if (m3_BASS.HasValue)
				request.WithQueryParameter("BASS", m3_BASS.Value.ToString());
			if (m3_BARD.HasValue)
				request.WithQueryParameter("BARD", m3_BARD.Value.ToString());
			if (m3_BAFD.HasValue)
				request.WithQueryParameter("BAFD", m3_BAFD.Value.ToString());
			if (m3_BALD.HasValue)
				request.WithQueryParameter("BALD", m3_BALD.Value.ToString());
			if (m3_BASD.HasValue)
				request.WithQueryParameter("BASD", m3_BASD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RETL))
				request.WithQueryParameter("RETL", m3_RETL.Trim());

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
		/// Name ChgRelation
		/// Description Change resource relationship
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PLG1">Work center (Required)</param>
		/// <param name="m3_PLG6">Work center resource (Required)</param>
		/// <param name="m3_DSCR">Description (Required)</param>
		/// <param name="m3_PRIR">Work center priority</param>
		/// <param name="m3_PLGF">Forced resource</param>
		/// <param name="m3_PLGN">Norm resource</param>
		/// <param name="m3_EFFA">Efficiency factor</param>
		/// <param name="m3_RPLF">Line control</param>
		/// <param name="m3_SECR">Preferred resource</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgRelation(
			string m3_FACI, 
			string m3_PLG1, 
			string m3_PLG6, 
			string m3_DSCR, 
			string m3_PRIR = null, 
			string m3_PLGF = null, 
			string m3_PLGN = null, 
			int? m3_EFFA = null, 
			int? m3_RPLF = null, 
			int? m3_SECR = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PLG1))
				throw new ArgumentNullException("m3_PLG1");
			if (string.IsNullOrWhiteSpace(m3_PLG6))
				throw new ArgumentNullException("m3_PLG6");
			if (string.IsNullOrWhiteSpace(m3_DSCR))
				throw new ArgumentNullException("m3_DSCR");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PLG1", m3_PLG1.Trim())
				.WithQueryParameter("PLG6", m3_PLG6.Trim())
				.WithQueryParameter("DSCR", m3_DSCR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRIR))
				request.WithQueryParameter("PRIR", m3_PRIR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGF))
				request.WithQueryParameter("PLGF", m3_PLGF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGN))
				request.WithQueryParameter("PLGN", m3_PLGN.Trim());
			if (m3_EFFA.HasValue)
				request.WithQueryParameter("EFFA", m3_EFFA.Value.ToString());
			if (m3_RPLF.HasValue)
				request.WithQueryParameter("RPLF", m3_RPLF.Value.ToString());
			if (m3_SECR.HasValue)
				request.WithQueryParameter("SECR", m3_SECR.Value.ToString());

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
		/// Name ChgShiftInfo
		/// Description Change work center - shift record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PLGR">Work center (Required)</param>
		/// <param name="m3_SHFC">Shift (Required)</param>
		/// <param name="m3_VALT">Validity type (Required)</param>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_CHNO">Change number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TODT">To date</param>
		/// <param name="m3_WCNR">Number of resources</param>
		/// <param name="m3_WCNM">Number of machines</param>
		/// <param name="m3_WCNP">Number of persons</param>
		/// <param name="m3_AVEF">Utilization rate</param>
		/// <param name="m3_PMSR">APP shift reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgShiftInfo(
			string m3_FACI, 
			string m3_PLGR, 
			string m3_SHFC, 
			int m3_VALT, 
			DateTime m3_FRDT, 
			int m3_CHNO, 
			int? m3_CONO = null, 
			DateTime? m3_TODT = null, 
			int? m3_WCNR = null, 
			string m3_WCNM = null, 
			int? m3_WCNP = null, 
			string m3_AVEF = null, 
			int? m3_PMSR = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PLGR))
				throw new ArgumentNullException("m3_PLGR");
			if (string.IsNullOrWhiteSpace(m3_SHFC))
				throw new ArgumentNullException("m3_SHFC");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PLGR", m3_PLGR.Trim())
				.WithQueryParameter("SHFC", m3_SHFC.Trim())
				.WithQueryParameter("VALT", m3_VALT.ToString())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String())
				.WithQueryParameter("CHNO", m3_CHNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());
			if (m3_WCNR.HasValue)
				request.WithQueryParameter("WCNR", m3_WCNR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WCNM))
				request.WithQueryParameter("WCNM", m3_WCNM.Trim());
			if (m3_WCNP.HasValue)
				request.WithQueryParameter("WCNP", m3_WCNP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AVEF))
				request.WithQueryParameter("AVEF", m3_AVEF.Trim());
			if (m3_PMSR.HasValue)
				request.WithQueryParameter("PMSR", m3_PMSR.Value.ToString());

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
		/// Name ChgShiftPatAdj
		/// Description Update Shift Pattern Adjustment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PLGR">Work center (Required)</param>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_TODT">To date (Required)</param>
		/// <param name="m3_SHPA">Shift pattern (Required)</param>
		/// <param name="m3_CHNO">Change number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgShiftPatAdj(
			string m3_FACI, 
			string m3_PLGR, 
			DateTime m3_FRDT, 
			DateTime m3_TODT, 
			string m3_SHPA, 
			int m3_CHNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgShiftPatAdj",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PLGR))
				throw new ArgumentNullException("m3_PLGR");
			if (string.IsNullOrWhiteSpace(m3_SHPA))
				throw new ArgumentNullException("m3_SHPA");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PLGR", m3_PLGR.Trim())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String())
				.WithQueryParameter("TODT", m3_TODT.ToM3String())
				.WithQueryParameter("SHPA", m3_SHPA.Trim())
				.WithQueryParameter("CHNO", m3_CHNO.ToString());

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
		/// Name CpyRelation
		/// Description Copy resource relationship
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PLG1">Work center (Required)</param>
		/// <param name="m3_PLG6">Work center resource (Required)</param>
		/// <param name="m3_TOG1">Copy to work center (Required)</param>
		/// <param name="m3_TOG6">Copy to work center resource (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyRelation(
			string m3_FACI, 
			string m3_PLG1, 
			string m3_PLG6, 
			string m3_TOG1, 
			string m3_TOG6, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PLG1))
				throw new ArgumentNullException("m3_PLG1");
			if (string.IsNullOrWhiteSpace(m3_PLG6))
				throw new ArgumentNullException("m3_PLG6");
			if (string.IsNullOrWhiteSpace(m3_TOG1))
				throw new ArgumentNullException("m3_TOG1");
			if (string.IsNullOrWhiteSpace(m3_TOG6))
				throw new ArgumentNullException("m3_TOG6");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PLG1", m3_PLG1.Trim())
				.WithQueryParameter("PLG6", m3_PLG6.Trim())
				.WithQueryParameter("TOG1", m3_TOG1.Trim())
				.WithQueryParameter("TOG6", m3_TOG6.Trim());

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
		/// Name CrtCapacity
		/// Description Create server capacity of work center
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PLGR">Work center (Required)</param>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_TODT">To date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CrtCapacity(
			string m3_FACI, 
			string m3_PLGR, 
			DateTime m3_FRDT, 
			DateTime m3_TODT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CrtCapacity",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PLGR))
				throw new ArgumentNullException("m3_PLGR");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PLGR", m3_PLGR.Trim())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String())
				.WithQueryParameter("TODT", m3_TODT.ToM3String());

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
		/// Name DelRelation
		/// Description Delete resource relationship
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PLG1">Work center</param>
		/// <param name="m3_PLG6">Work center resource</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelRelation(
			string m3_FACI = null, 
			string m3_PLG1 = null, 
			string m3_PLG6 = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLG1))
				request.WithQueryParameter("PLG1", m3_PLG1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLG6))
				request.WithQueryParameter("PLG6", m3_PLG6.Trim());

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
		/// Name DelShiftInfo
		/// Description Delete work center - shift record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PLGR">Work center (Required)</param>
		/// <param name="m3_SHFC">Shift (Required)</param>
		/// <param name="m3_VALT">Validity type (Required)</param>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TODT">To date</param>
		/// <param name="m3_WCNR">Number of resources</param>
		/// <param name="m3_WCNM">Number of machines</param>
		/// <param name="m3_WCNP">Number of persons</param>
		/// <param name="m3_AVEF">Utilization rate</param>
		/// <param name="m3_CHNO">Change number</param>
		/// <param name="m3_PMSR">APP shift reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelShiftInfo(
			string m3_FACI, 
			string m3_PLGR, 
			string m3_SHFC, 
			int m3_VALT, 
			DateTime m3_FRDT, 
			int? m3_CONO = null, 
			DateTime? m3_TODT = null, 
			int? m3_WCNR = null, 
			string m3_WCNM = null, 
			int? m3_WCNP = null, 
			string m3_AVEF = null, 
			int? m3_CHNO = null, 
			int? m3_PMSR = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PLGR))
				throw new ArgumentNullException("m3_PLGR");
			if (string.IsNullOrWhiteSpace(m3_SHFC))
				throw new ArgumentNullException("m3_SHFC");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PLGR", m3_PLGR.Trim())
				.WithQueryParameter("SHFC", m3_SHFC.Trim())
				.WithQueryParameter("VALT", m3_VALT.ToString())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());
			if (m3_WCNR.HasValue)
				request.WithQueryParameter("WCNR", m3_WCNR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WCNM))
				request.WithQueryParameter("WCNM", m3_WCNM.Trim());
			if (m3_WCNP.HasValue)
				request.WithQueryParameter("WCNP", m3_WCNP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AVEF))
				request.WithQueryParameter("AVEF", m3_AVEF.Trim());
			if (m3_CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3_CHNO.Value.ToString());
			if (m3_PMSR.HasValue)
				request.WithQueryParameter("PMSR", m3_PMSR.Value.ToString());

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
		/// Name DelShiftPatAdj
		/// Description Delete Shift Pattern Adjustment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PLGR">Work center (Required)</param>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelShiftPatAdj(
			string m3_FACI, 
			string m3_PLGR, 
			DateTime m3_FRDT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelShiftPatAdj",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PLGR))
				throw new ArgumentNullException("m3_PLGR");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PLGR", m3_PLGR.Trim())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String());

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
		/// Name DelWorkCenter
		/// Description Delete Work Center
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelWorkCenter(
			string m3_FACI = null, 
			string m3_PLGR = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());

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
		/// Name Get
		/// Description Get
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PLGR">Work center (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_FACI, 
			string m3_PLGR, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PLGR))
				throw new ArgumentNullException("m3_PLGR");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PLGR", m3_PLGR.Trim());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name GetRelation
		/// Description Get resource relationship
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PLG1">Work center (Required)</param>
		/// <param name="m3_PLG6">Work center resource (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetRelationResponse></returns>
		/// <exception cref="M3Exception<GetRelationResponse>"></exception>
		public async Task<M3Response<GetRelationResponse>> GetRelation(
			string m3_FACI, 
			string m3_PLG1, 
			string m3_PLG6, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PLG1))
				throw new ArgumentNullException("m3_PLG1");
			if (string.IsNullOrWhiteSpace(m3_PLG6))
				throw new ArgumentNullException("m3_PLG6");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PLG1", m3_PLG1.Trim())
				.WithQueryParameter("PLG6", m3_PLG6.Trim());

			// Execute the request
			var result = await Execute<GetRelationResponse>(
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
		/// Name GetShiftInfo
		/// Description Retrieve work center - shift record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PLGR">Work center (Required)</param>
		/// <param name="m3_SHFC">Shift (Required)</param>
		/// <param name="m3_VALT">Validity type (Required)</param>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TODT">To date</param>
		/// <param name="m3_WCNR">Number of resources</param>
		/// <param name="m3_WCNM">Number of machines</param>
		/// <param name="m3_WCNP">Number of persons</param>
		/// <param name="m3_AVEF">Utilization rate</param>
		/// <param name="m3_CHNO">Change number</param>
		/// <param name="m3_PMSR">Shift reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetShiftInfoResponse></returns>
		/// <exception cref="M3Exception<GetShiftInfoResponse>"></exception>
		public async Task<M3Response<GetShiftInfoResponse>> GetShiftInfo(
			string m3_FACI, 
			string m3_PLGR, 
			string m3_SHFC, 
			string m3_VALT, 
			DateTime m3_FRDT, 
			int? m3_CONO = null, 
			DateTime? m3_TODT = null, 
			string m3_WCNR = null, 
			string m3_WCNM = null, 
			string m3_WCNP = null, 
			string m3_AVEF = null, 
			int? m3_CHNO = null, 
			int? m3_PMSR = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PLGR))
				throw new ArgumentNullException("m3_PLGR");
			if (string.IsNullOrWhiteSpace(m3_SHFC))
				throw new ArgumentNullException("m3_SHFC");
			if (string.IsNullOrWhiteSpace(m3_VALT))
				throw new ArgumentNullException("m3_VALT");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PLGR", m3_PLGR.Trim())
				.WithQueryParameter("SHFC", m3_SHFC.Trim())
				.WithQueryParameter("VALT", m3_VALT.Trim())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_WCNR))
				request.WithQueryParameter("WCNR", m3_WCNR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WCNM))
				request.WithQueryParameter("WCNM", m3_WCNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WCNP))
				request.WithQueryParameter("WCNP", m3_WCNP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AVEF))
				request.WithQueryParameter("AVEF", m3_AVEF.Trim());
			if (m3_CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3_CHNO.Value.ToString());
			if (m3_PMSR.HasValue)
				request.WithQueryParameter("PMSR", m3_PMSR.Value.ToString());

			// Execute the request
			var result = await Execute<GetShiftInfoResponse>(
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
		/// Name GetShiftPatAdj
		/// Description Retrieve shift pattern adjustment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PLGR">Work center (Required)</param>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetShiftPatAdjResponse></returns>
		/// <exception cref="M3Exception<GetShiftPatAdjResponse>"></exception>
		public async Task<M3Response<GetShiftPatAdjResponse>> GetShiftPatAdj(
			string m3_FACI, 
			string m3_PLGR, 
			DateTime m3_FRDT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetShiftPatAdj",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PLGR))
				throw new ArgumentNullException("m3_PLGR");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PLGR", m3_PLGR.Trim())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetShiftPatAdjResponse>(
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
		/// Name List
		/// Description List
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3_FACI = null, 
			string m3_PLGR = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());

			// Execute the request
			var result = await Execute<ListResponse>(
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
		/// Name LstDailyCap
		/// Description List daily Capacity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_PLTP">Resource type</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_FRDT">From date</param>
		/// <param name="m3_TODT">To date</param>
		/// <param name="m3_SKNW">Skip non working days</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDailyCapResponse></returns>
		/// <exception cref="M3Exception<LstDailyCapResponse>"></exception>
		public async Task<M3Response<LstDailyCapResponse>> LstDailyCap(
			string m3_FACI, 
			int? m3_CONO = null, 
			string m3_PLGR = null, 
			string m3_PLTP = null, 
			string m3_REAR = null, 
			string m3_DEPT = null, 
			DateTime? m3_FRDT = null, 
			DateTime? m3_TODT = null, 
			int? m3_SKNW = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLTP))
				request.WithQueryParameter("PLTP", m3_PLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (m3_FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3_FRDT.Value.ToM3String());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());
			if (m3_SKNW.HasValue)
				request.WithQueryParameter("SKNW", m3_SKNW.Value.ToString());

			// Execute the request
			var result = await Execute<LstDailyCapResponse>(
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
		/// Name LstRelPerRes
		/// Description List resource relations by resource
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PLG6">Work center resource</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRelPerResResponse></returns>
		/// <exception cref="M3Exception<LstRelPerResResponse>"></exception>
		public async Task<M3Response<LstRelPerResResponse>> LstRelPerRes(
			string m3_FACI, 
			string m3_PLG6 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PLG6))
				request.WithQueryParameter("PLG6", m3_PLG6.Trim());

			// Execute the request
			var result = await Execute<LstRelPerResResponse>(
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
		/// Name LstRelPerWC
		/// Description List resource relations by work center
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PLG1">Work center</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRelPerWCResponse></returns>
		/// <exception cref="M3Exception<LstRelPerWCResponse>"></exception>
		public async Task<M3Response<LstRelPerWCResponse>> LstRelPerWC(
			string m3_FACI, 
			string m3_PLG1 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PLG1))
				request.WithQueryParameter("PLG1", m3_PLG1.Trim());

			// Execute the request
			var result = await Execute<LstRelPerWCResponse>(
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
		/// Name SelRelations
		/// Description Select work center relationships
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FFAC">From facility (Required)</param>
		/// <param name="m3_TFAC">To facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PLTP">Resource type</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelRelationsResponse></returns>
		/// <exception cref="M3Exception<SelRelationsResponse>"></exception>
		public async Task<M3Response<SelRelationsResponse>> SelRelations(
			string m3_FFAC, 
			string m3_TFAC, 
			int? m3_CONO = null, 
			int? m3_PLTP = null, 
			string m3_WHGR = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FFAC))
				throw new ArgumentNullException("m3_FFAC");
			if (string.IsNullOrWhiteSpace(m3_TFAC))
				throw new ArgumentNullException("m3_TFAC");

			// Set mandatory parameters
			request
				.WithQueryParameter("FFAC", m3_FFAC.Trim())
				.WithQueryParameter("TFAC", m3_TFAC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PLTP.HasValue)
				request.WithQueryParameter("PLTP", m3_PLTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());

			// Execute the request
			var result = await Execute<SelRelationsResponse>(
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
		/// Name SelShiftInfo
		/// Description Select work center - shift records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FFAC">From facility (Required)</param>
		/// <param name="m3_TFAC">To facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PLTP">Resource type</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelShiftInfoResponse></returns>
		/// <exception cref="M3Exception<SelShiftInfoResponse>"></exception>
		public async Task<M3Response<SelShiftInfoResponse>> SelShiftInfo(
			string m3_FFAC, 
			string m3_TFAC, 
			int? m3_CONO = null, 
			int? m3_PLTP = null, 
			string m3_WHGR = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FFAC))
				throw new ArgumentNullException("m3_FFAC");
			if (string.IsNullOrWhiteSpace(m3_TFAC))
				throw new ArgumentNullException("m3_TFAC");

			// Set mandatory parameters
			request
				.WithQueryParameter("FFAC", m3_FFAC.Trim())
				.WithQueryParameter("TFAC", m3_TFAC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PLTP.HasValue)
				request.WithQueryParameter("PLTP", m3_PLTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());

			// Execute the request
			var result = await Execute<SelShiftInfoResponse>(
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
		/// Name SelShiftPatAdj
		/// Description Select shift pattern adjustment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FFAC">From facility (Required)</param>
		/// <param name="m3_TFAC">To facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PLTP">Resource type</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelShiftPatAdjResponse></returns>
		/// <exception cref="M3Exception<SelShiftPatAdjResponse>"></exception>
		public async Task<M3Response<SelShiftPatAdjResponse>> SelShiftPatAdj(
			string m3_FFAC, 
			string m3_TFAC, 
			int? m3_CONO = null, 
			int? m3_PLTP = null, 
			string m3_WHGR = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FFAC))
				throw new ArgumentNullException("m3_FFAC");
			if (string.IsNullOrWhiteSpace(m3_TFAC))
				throw new ArgumentNullException("m3_TFAC");

			// Set mandatory parameters
			request
				.WithQueryParameter("FFAC", m3_FFAC.Trim())
				.WithQueryParameter("TFAC", m3_TFAC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PLTP.HasValue)
				request.WithQueryParameter("PLTP", m3_PLTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());

			// Execute the request
			var result = await Execute<SelShiftPatAdjResponse>(
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
		/// Name SelTranspTimes
		/// Description Select transport and queue times
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FFAC">From facility (Required)</param>
		/// <param name="m3_TFAC">To facility (Required)</param>
		/// <param name="m3_TTTP">Transport time type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelTranspTimesResponse></returns>
		/// <exception cref="M3Exception<SelTranspTimesResponse>"></exception>
		public async Task<M3Response<SelTranspTimesResponse>> SelTranspTimes(
			string m3_FFAC, 
			string m3_TFAC, 
			int m3_TTTP, 
			int? m3_CONO = null, 
			string m3_WHGR = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FFAC))
				throw new ArgumentNullException("m3_FFAC");
			if (string.IsNullOrWhiteSpace(m3_TFAC))
				throw new ArgumentNullException("m3_TFAC");

			// Set mandatory parameters
			request
				.WithQueryParameter("FFAC", m3_FFAC.Trim())
				.WithQueryParameter("TFAC", m3_TFAC.Trim())
				.WithQueryParameter("TTTP", m3_TTTP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());

			// Execute the request
			var result = await Execute<SelTranspTimesResponse>(
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
		/// Name Select
		/// Description Select work centers
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_FFAC">From facility (Required)</param>
		/// <param name="m3_TFAC">To facility (Required)</param>
		/// <param name="m3_PLTP">Resource type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_CRTR">Critical resource</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectResponse></returns>
		/// <exception cref="M3Exception<SelectResponse>"></exception>
		public async Task<M3Response<SelectResponse>> Select(
			string m3_FFAC, 
			string m3_TFAC, 
			string m3_PLTP, 
			int? m3_CONO = null, 
			string m3_WHGR = null, 
			int? m3_CRTR = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FFAC))
				throw new ArgumentNullException("m3_FFAC");
			if (string.IsNullOrWhiteSpace(m3_TFAC))
				throw new ArgumentNullException("m3_TFAC");
			if (string.IsNullOrWhiteSpace(m3_PLTP))
				throw new ArgumentNullException("m3_PLTP");

			// Set mandatory parameters
			request
				.WithQueryParameter("FFAC", m3_FFAC.Trim())
				.WithQueryParameter("TFAC", m3_TFAC.Trim())
				.WithQueryParameter("PLTP", m3_PLTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (m3_CRTR.HasValue)
				request.WithQueryParameter("CRTR", m3_CRTR.Value.ToString());

			// Execute the request
			var result = await Execute<SelectResponse>(
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
		/// Name UpdWorkCenter
		/// Description Update Work Center
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_PLNM">Name</param>
		/// <param name="m3_PLTP">Resource type</param>
		/// <param name="m3_IIWC">Included in work center</param>
		/// <param name="m3_WCRE">Work center responsible</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_QUAC">Quality inspection</param>
		/// <param name="m3_PLGT">Work center type</param>
		/// <param name="m3_CRTR">Critical resource</param>
		/// <param name="m3_COCE">Cost center</param>
		/// <param name="m3_CINA">Create cost accounting transactions</param>
		/// <param name="m3_CPTY">Capacity per unit and shift</param>
		/// <param name="m3_PCAP">Capacity type</param>
		/// <param name="m3_ACAP">Alternate capacity</param>
		/// <param name="m3_RCUN">Alternate capacity U/M</param>
		/// <param name="m3_SHPA">Shift pattern</param>
		/// <param name="m3_PRLN">Production line</param>
		/// <param name="m3_WCNM">Number of machines</param>
		/// <param name="m3_WCNP">Number of persons</param>
		/// <param name="m3_SHFT">Number of shifts</param>
		/// <param name="m3_AVEF">Utilization rate</param>
		/// <param name="m3_PLHZ">Planning horizon</param>
		/// <param name="m3_EFCH">Efficiency control</param>
		/// <param name="m3_LVDY">Daily load leveling</param>
		/// <param name="m3_RATP">Production rate display code</param>
		/// <param name="m3_DPLH">Weekly load leveling</param>
		/// <param name="m3_GEOX">Geographic cod X</param>
		/// <param name="m3_GEOY">Geographic code Y</param>
		/// <param name="m3_GEOZ">Geographic cod  Z</param>
		/// <param name="m3_AUIN">Automatic receipt</param>
		/// <param name="m3_PLGD">Default resource</param>
		/// <param name="m3_AURP">Automatic operation reporting</param>
		/// <param name="m3_KANB">Item location issue</param>
		/// <param name="m3_VEOC">Verify operation closing</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="m3_KYRE">Flow order resource</param>
		/// <param name="m3_RWCD">Load reduction method</param>
		/// <param name="m3_WLDE">Infinite/finite</param>
		/// <param name="m3_AMAO">Additional material offset</param>
		/// <param name="m3_DAFA">Day factor</param>
		/// <param name="m3_VAPC">Option percentage</param>
		/// <param name="m3_QUDY">Queue days</param>
		/// <param name="m3_RAUM">Reporting in alternate U/M</param>
		/// <param name="m3_PSQT">Co-sorting identity</param>
		/// <param name="m3_SOFD">CO-sort feature or drawing measurement</param>
		/// <param name="m3_FITP">From item position</param>
		/// <param name="m3_TITP">To item position</param>
		/// <param name="m3_PIDS">Panel identity - MO W/C schedule</param>
		/// <param name="m3_PIDW">Panel identity - WO W/C schedule</param>
		/// <param name="m3_PLLT">Lot number control</param>
		/// <param name="m3_OPDS">Operation description</param>
		/// <param name="m3_PRNP">Planned number of workers - run time</param>
		/// <param name="m3_SENP">Planned number of workers - setup</param>
		/// <param name="m3_PRNM">Planned number of machines</param>
		/// <param name="m3_SWQT">Setup scrap</param>
		/// <param name="m3_SCPC">Scrap percentage</param>
		/// <param name="m3_PLOQ">Production lot size</param>
		/// <param name="m3_SETI">Setup time</param>
		/// <param name="m3_PITI">Run time</param>
		/// <param name="m3_OSET">External setup time</param>
		/// <param name="m3_PTUN">Time U/M</param>
		/// <param name="m3_CTCD">Price and time quantity</param>
		/// <param name="m3_FXTI">Fixed time</param>
		/// <param name="m3_SEPR">Setup price</param>
		/// <param name="m3_PIPR">Unit price</param>
		/// <param name="m3_PDCC">Number of price decimal places</param>
		/// <param name="m3_KIWG">Pay element</param>
		/// <param name="m3_WCRF">Time reference</param>
		/// <param name="m3_SLAC">Transport value in days</param>
		/// <param name="m3_SLAT">Transit unit of measure/Overlap code</param>
		/// <param name="m3_CAMP">Number of labor tickets</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_DOID">Document identity</param>
		/// <param name="m3_TOOL">Tool number</param>
		/// <param name="m3_SHBP">Shipping buffer in production days</param>
		/// <param name="m3_SEQP">Sequencing priority</param>
		/// <param name="m3_ACZO">Work zone</param>
		/// <param name="m3_PRET">Preparation time</param>
		/// <param name="m3_CAPL">Capacity level</param>
		/// <param name="m3_AVQT">Average queue time</param>
		/// <param name="m3_ACOL">Activity color</param>
		/// <param name="m3_LDPR">Loading principle</param>
		/// <param name="m3_MDOP">Max duration of operation in percent</param>
		/// <param name="m3_FUMT">Fill method</param>
		/// <param name="m3_POTM">Post-operation time</param>
		/// <param name="m3_MINR">Minimum restriction</param>
		/// <param name="m3_CPOT">Continuous post-opr time</param>
		/// <param name="m3_MAXR">Maximum restriction</param>
		/// <param name="m3_MPTF">Operator time factor</param>
		/// <param name="m3_UNIT">Unit of measure</param>
		/// <param name="m3_GRMU">Oven load U/M</param>
		/// <param name="m3_GRMX">Maximum oven load</param>
		/// <param name="m3_AVFL">Average load percentage</param>
		/// <param name="m3_BAME">Batch sizing method</param>
		/// <param name="m3_BAMI">Minimum batch size</param>
		/// <param name="m3_BAML">Minimum level percentage</param>
		/// <param name="m3_BAMA">Maximum batch size</param>
		/// <param name="m3_BASL">Step level percentage</param>
		/// <param name="m3_BASS">Multiple batch size</param>
		/// <param name="m3_BARD">Surplus rule</param>
		/// <param name="m3_BAFD">Frozen horizon</param>
		/// <param name="m3_BALD">Sequence lock horizon</param>
		/// <param name="m3_BASD">Slushy horizon</param>
		/// <param name="m3_RETL">Return location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdWorkCenter(
			string m3_FACI = null, 
			string m3_PLGR = null, 
			string m3_PLNM = null, 
			string m3_PLTP = null, 
			string m3_IIWC = null, 
			string m3_WCRE = null, 
			string m3_DEPT = null, 
			string m3_REAR = null, 
			int? m3_QUAC = null, 
			string m3_PLGT = null, 
			int? m3_CRTR = null, 
			string m3_COCE = null, 
			int? m3_CINA = null, 
			decimal? m3_CPTY = null, 
			string m3_PCAP = null, 
			decimal? m3_ACAP = null, 
			string m3_RCUN = null, 
			string m3_SHPA = null, 
			int? m3_PRLN = null, 
			int? m3_WCNM = null, 
			int? m3_WCNP = null, 
			int? m3_SHFT = null, 
			int? m3_AVEF = null, 
			int? m3_PLHZ = null, 
			int? m3_EFCH = null, 
			int? m3_LVDY = null, 
			int? m3_RATP = null, 
			int? m3_DPLH = null, 
			decimal? m3_GEOX = null, 
			decimal? m3_GEOY = null, 
			decimal? m3_GEOZ = null, 
			int? m3_AUIN = null, 
			string m3_PLGD = null, 
			int? m3_AURP = null, 
			int? m3_KANB = null, 
			int? m3_VEOC = null, 
			string m3_WHLO = null, 
			string m3_WHSL = null, 
			string m3_TWSL = null, 
			int? m3_KYRE = null, 
			string m3_RWCD = null, 
			int? m3_WLDE = null, 
			int? m3_AMAO = null, 
			int? m3_DAFA = null, 
			int? m3_VAPC = null, 
			int? m3_QUDY = null, 
			int? m3_RAUM = null, 
			int? m3_PSQT = null, 
			string m3_SOFD = null, 
			int? m3_FITP = null, 
			int? m3_TITP = null, 
			string m3_PIDS = null, 
			string m3_PIDW = null, 
			int? m3_PLLT = null, 
			string m3_OPDS = null, 
			int? m3_PRNP = null, 
			int? m3_SENP = null, 
			int? m3_PRNM = null, 
			decimal? m3_SWQT = null, 
			int? m3_SCPC = null, 
			decimal? m3_PLOQ = null, 
			int? m3_SETI = null, 
			int? m3_PITI = null, 
			int? m3_OSET = null, 
			string m3_PTUN = null, 
			int? m3_CTCD = null, 
			int? m3_FXTI = null, 
			decimal? m3_SEPR = null, 
			decimal? m3_PIPR = null, 
			int? m3_PDCC = null, 
			int? m3_KIWG = null, 
			string m3_WCRF = null, 
			decimal? m3_SLAC = null, 
			string m3_SLAT = null, 
			int? m3_CAMP = null, 
			string m3_SUNO = null, 
			string m3_DOID = null, 
			string m3_TOOL = null, 
			int? m3_SHBP = null, 
			int? m3_SEQP = null, 
			string m3_ACZO = null, 
			int? m3_PRET = null, 
			int? m3_CAPL = null, 
			int? m3_AVQT = null, 
			int? m3_ACOL = null, 
			int? m3_LDPR = null, 
			int? m3_MDOP = null, 
			int? m3_FUMT = null, 
			int? m3_POTM = null, 
			string m3_MINR = null, 
			int? m3_CPOT = null, 
			string m3_MAXR = null, 
			int? m3_MPTF = null, 
			string m3_UNIT = null, 
			int? m3_GRMU = null, 
			long? m3_GRMX = null, 
			int? m3_AVFL = null, 
			int? m3_BAME = null, 
			decimal? m3_BAMI = null, 
			int? m3_BAML = null, 
			decimal? m3_BAMA = null, 
			int? m3_BASL = null, 
			decimal? m3_BASS = null, 
			int? m3_BARD = null, 
			int? m3_BAFD = null, 
			int? m3_BALD = null, 
			int? m3_BASD = null, 
			string m3_RETL = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLNM))
				request.WithQueryParameter("PLNM", m3_PLNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLTP))
				request.WithQueryParameter("PLTP", m3_PLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IIWC))
				request.WithQueryParameter("IIWC", m3_IIWC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WCRE))
				request.WithQueryParameter("WCRE", m3_WCRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (m3_QUAC.HasValue)
				request.WithQueryParameter("QUAC", m3_QUAC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLGT))
				request.WithQueryParameter("PLGT", m3_PLGT.Trim());
			if (m3_CRTR.HasValue)
				request.WithQueryParameter("CRTR", m3_CRTR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_COCE))
				request.WithQueryParameter("COCE", m3_COCE.Trim());
			if (m3_CINA.HasValue)
				request.WithQueryParameter("CINA", m3_CINA.Value.ToString());
			if (m3_CPTY.HasValue)
				request.WithQueryParameter("CPTY", m3_CPTY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PCAP))
				request.WithQueryParameter("PCAP", m3_PCAP.Trim());
			if (m3_ACAP.HasValue)
				request.WithQueryParameter("ACAP", m3_ACAP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RCUN))
				request.WithQueryParameter("RCUN", m3_RCUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SHPA))
				request.WithQueryParameter("SHPA", m3_SHPA.Trim());
			if (m3_PRLN.HasValue)
				request.WithQueryParameter("PRLN", m3_PRLN.Value.ToString());
			if (m3_WCNM.HasValue)
				request.WithQueryParameter("WCNM", m3_WCNM.Value.ToString());
			if (m3_WCNP.HasValue)
				request.WithQueryParameter("WCNP", m3_WCNP.Value.ToString());
			if (m3_SHFT.HasValue)
				request.WithQueryParameter("SHFT", m3_SHFT.Value.ToString());
			if (m3_AVEF.HasValue)
				request.WithQueryParameter("AVEF", m3_AVEF.Value.ToString());
			if (m3_PLHZ.HasValue)
				request.WithQueryParameter("PLHZ", m3_PLHZ.Value.ToString());
			if (m3_EFCH.HasValue)
				request.WithQueryParameter("EFCH", m3_EFCH.Value.ToString());
			if (m3_LVDY.HasValue)
				request.WithQueryParameter("LVDY", m3_LVDY.Value.ToString());
			if (m3_RATP.HasValue)
				request.WithQueryParameter("RATP", m3_RATP.Value.ToString());
			if (m3_DPLH.HasValue)
				request.WithQueryParameter("DPLH", m3_DPLH.Value.ToString());
			if (m3_GEOX.HasValue)
				request.WithQueryParameter("GEOX", m3_GEOX.Value.ToString());
			if (m3_GEOY.HasValue)
				request.WithQueryParameter("GEOY", m3_GEOY.Value.ToString());
			if (m3_GEOZ.HasValue)
				request.WithQueryParameter("GEOZ", m3_GEOZ.Value.ToString());
			if (m3_AUIN.HasValue)
				request.WithQueryParameter("AUIN", m3_AUIN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLGD))
				request.WithQueryParameter("PLGD", m3_PLGD.Trim());
			if (m3_AURP.HasValue)
				request.WithQueryParameter("AURP", m3_AURP.Value.ToString());
			if (m3_KANB.HasValue)
				request.WithQueryParameter("KANB", m3_KANB.Value.ToString());
			if (m3_VEOC.HasValue)
				request.WithQueryParameter("VEOC", m3_VEOC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (m3_KYRE.HasValue)
				request.WithQueryParameter("KYRE", m3_KYRE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RWCD))
				request.WithQueryParameter("RWCD", m3_RWCD.Trim());
			if (m3_WLDE.HasValue)
				request.WithQueryParameter("WLDE", m3_WLDE.Value.ToString());
			if (m3_AMAO.HasValue)
				request.WithQueryParameter("AMAO", m3_AMAO.Value.ToString());
			if (m3_DAFA.HasValue)
				request.WithQueryParameter("DAFA", m3_DAFA.Value.ToString());
			if (m3_VAPC.HasValue)
				request.WithQueryParameter("VAPC", m3_VAPC.Value.ToString());
			if (m3_QUDY.HasValue)
				request.WithQueryParameter("QUDY", m3_QUDY.Value.ToString());
			if (m3_RAUM.HasValue)
				request.WithQueryParameter("RAUM", m3_RAUM.Value.ToString());
			if (m3_PSQT.HasValue)
				request.WithQueryParameter("PSQT", m3_PSQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SOFD))
				request.WithQueryParameter("SOFD", m3_SOFD.Trim());
			if (m3_FITP.HasValue)
				request.WithQueryParameter("FITP", m3_FITP.Value.ToString());
			if (m3_TITP.HasValue)
				request.WithQueryParameter("TITP", m3_TITP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PIDS))
				request.WithQueryParameter("PIDS", m3_PIDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PIDW))
				request.WithQueryParameter("PIDW", m3_PIDW.Trim());
			if (m3_PLLT.HasValue)
				request.WithQueryParameter("PLLT", m3_PLLT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OPDS))
				request.WithQueryParameter("OPDS", m3_OPDS.Trim());
			if (m3_PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3_PRNP.Value.ToString());
			if (m3_SENP.HasValue)
				request.WithQueryParameter("SENP", m3_SENP.Value.ToString());
			if (m3_PRNM.HasValue)
				request.WithQueryParameter("PRNM", m3_PRNM.Value.ToString());
			if (m3_SWQT.HasValue)
				request.WithQueryParameter("SWQT", m3_SWQT.Value.ToString());
			if (m3_SCPC.HasValue)
				request.WithQueryParameter("SCPC", m3_SCPC.Value.ToString());
			if (m3_PLOQ.HasValue)
				request.WithQueryParameter("PLOQ", m3_PLOQ.Value.ToString());
			if (m3_SETI.HasValue)
				request.WithQueryParameter("SETI", m3_SETI.Value.ToString());
			if (m3_PITI.HasValue)
				request.WithQueryParameter("PITI", m3_PITI.Value.ToString());
			if (m3_OSET.HasValue)
				request.WithQueryParameter("OSET", m3_OSET.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PTUN))
				request.WithQueryParameter("PTUN", m3_PTUN.Trim());
			if (m3_CTCD.HasValue)
				request.WithQueryParameter("CTCD", m3_CTCD.Value.ToString());
			if (m3_FXTI.HasValue)
				request.WithQueryParameter("FXTI", m3_FXTI.Value.ToString());
			if (m3_SEPR.HasValue)
				request.WithQueryParameter("SEPR", m3_SEPR.Value.ToString());
			if (m3_PIPR.HasValue)
				request.WithQueryParameter("PIPR", m3_PIPR.Value.ToString());
			if (m3_PDCC.HasValue)
				request.WithQueryParameter("PDCC", m3_PDCC.Value.ToString());
			if (m3_KIWG.HasValue)
				request.WithQueryParameter("KIWG", m3_KIWG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WCRF))
				request.WithQueryParameter("WCRF", m3_WCRF.Trim());
			if (m3_SLAC.HasValue)
				request.WithQueryParameter("SLAC", m3_SLAC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SLAT))
				request.WithQueryParameter("SLAT", m3_SLAT.Trim());
			if (m3_CAMP.HasValue)
				request.WithQueryParameter("CAMP", m3_CAMP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOOL))
				request.WithQueryParameter("TOOL", m3_TOOL.Trim());
			if (m3_SHBP.HasValue)
				request.WithQueryParameter("SHBP", m3_SHBP.Value.ToString());
			if (m3_SEQP.HasValue)
				request.WithQueryParameter("SEQP", m3_SEQP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACZO))
				request.WithQueryParameter("ACZO", m3_ACZO.Trim());
			if (m3_PRET.HasValue)
				request.WithQueryParameter("PRET", m3_PRET.Value.ToString());
			if (m3_CAPL.HasValue)
				request.WithQueryParameter("CAPL", m3_CAPL.Value.ToString());
			if (m3_AVQT.HasValue)
				request.WithQueryParameter("AVQT", m3_AVQT.Value.ToString());
			if (m3_ACOL.HasValue)
				request.WithQueryParameter("ACOL", m3_ACOL.Value.ToString());
			if (m3_LDPR.HasValue)
				request.WithQueryParameter("LDPR", m3_LDPR.Value.ToString());
			if (m3_MDOP.HasValue)
				request.WithQueryParameter("MDOP", m3_MDOP.Value.ToString());
			if (m3_FUMT.HasValue)
				request.WithQueryParameter("FUMT", m3_FUMT.Value.ToString());
			if (m3_POTM.HasValue)
				request.WithQueryParameter("POTM", m3_POTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MINR))
				request.WithQueryParameter("MINR", m3_MINR.Trim());
			if (m3_CPOT.HasValue)
				request.WithQueryParameter("CPOT", m3_CPOT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MAXR))
				request.WithQueryParameter("MAXR", m3_MAXR.Trim());
			if (m3_MPTF.HasValue)
				request.WithQueryParameter("MPTF", m3_MPTF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNIT))
				request.WithQueryParameter("UNIT", m3_UNIT.Trim());
			if (m3_GRMU.HasValue)
				request.WithQueryParameter("GRMU", m3_GRMU.Value.ToString());
			if (m3_GRMX.HasValue)
				request.WithQueryParameter("GRMX", m3_GRMX.Value.ToString());
			if (m3_AVFL.HasValue)
				request.WithQueryParameter("AVFL", m3_AVFL.Value.ToString());
			if (m3_BAME.HasValue)
				request.WithQueryParameter("BAME", m3_BAME.Value.ToString());
			if (m3_BAMI.HasValue)
				request.WithQueryParameter("BAMI", m3_BAMI.Value.ToString());
			if (m3_BAML.HasValue)
				request.WithQueryParameter("BAML", m3_BAML.Value.ToString());
			if (m3_BAMA.HasValue)
				request.WithQueryParameter("BAMA", m3_BAMA.Value.ToString());
			if (m3_BASL.HasValue)
				request.WithQueryParameter("BASL", m3_BASL.Value.ToString());
			if (m3_BASS.HasValue)
				request.WithQueryParameter("BASS", m3_BASS.Value.ToString());
			if (m3_BARD.HasValue)
				request.WithQueryParameter("BARD", m3_BARD.Value.ToString());
			if (m3_BAFD.HasValue)
				request.WithQueryParameter("BAFD", m3_BAFD.Value.ToString());
			if (m3_BALD.HasValue)
				request.WithQueryParameter("BALD", m3_BALD.Value.ToString());
			if (m3_BASD.HasValue)
				request.WithQueryParameter("BASD", m3_BASD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RETL))
				request.WithQueryParameter("RETL", m3_RETL.Trim());

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
