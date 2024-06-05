/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.MOS440MI;
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
	/// Name: MOS440MI
	/// Component Name: MaintenancePositions
	/// Description: Maintenance positions interface
	/// Version Release: 14.x
	///</summary>
	public partial class MOS440MIResource : M3BaseResourceEndpoint
	{
		public MOS440MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS440MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add Positions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MOTP">Model/site (Required)</param>
		/// <param name="m3CFGL">Configuration position (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MATP">Component type</param>
		/// <param name="m3POS0">Location</param>
		/// <param name="m3MAND">Mandatory</param>
		/// <param name="m3CAT0">Config position category</param>
		/// <param name="m3HIGH">Highest in structure</param>
		/// <param name="m3AESC">Criticality class</param>
		/// <param name="m3AES2">Extended-range twin-engine operations</param>
		/// <param name="m3REMC">Removal concept</param>
		/// <param name="m3FPCO">Failure protection concept</param>
		/// <param name="m3AMOR">Maintenance/overhaul/repair class</param>
		/// <param name="m3ASRS">Exchange requirements</param>
		/// <param name="m3ASSI">SOS indicator</param>
		/// <param name="m3AEFI">Effectivity indicator</param>
		/// <param name="m3MPEC">Maintenance percent</param>
		/// <param name="m3MSPT">Service lead time</param>
		/// <param name="m3TBSR">Time between scheduled shop visits</param>
		/// <param name="m3MBSR">Meter - scheduled shop visits</param>
		/// <param name="m3TBUR">Unscheduled removal rate</param>
		/// <param name="m3MBUR">Meter - unscheduled removal rate</param>
		/// <param name="m3RCFG">Configuration position category</param>
		/// <param name="m3STNC">Standard numbering system</param>
		/// <param name="m3MCDE">Maintenance code</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3LPOS">Load position</param>
		/// <param name="m3NUCP">Number of units for config position</param>
		/// <param name="m3ENGI">Engine</param>
		/// <param name="m3LOCH">Location history</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3PPOS">Planning position</param>
		/// <param name="m3DWTC">Downtime cost</param>
		/// <param name="m3TEFF">Target availability</param>
		/// <param name="m3PRSS">Process</param>
		/// <param name="m3SBPR">Subprocess</param>
		/// <param name="m3PRIP">Priority</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3DOID">Document identity</param>
		/// <param name="m3DWNO">Drawing number</param>
		/// <param name="m3MES1">Meter 1</param>
		/// <param name="m3MES2">Meter 2</param>
		/// <param name="m3MES3">Meter 3</param>
		/// <param name="m3MES4">Meter 4</param>
		/// <param name="m3POCA">Configuration position group</param>
		/// <param name="m3AMUI">Meter indicator</param>
		/// <param name="m3ASID">Fixed asset</param>
		/// <param name="m3SBNO">Subnumber</param>
		/// <param name="m3CFGH">NHA configuration position</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3COCE">Cost center</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3MOTP, 
			string m3CFGL, 
			int? m3CONO = null, 
			string m3MATP = null, 
			string m3POS0 = null, 
			string m3MAND = null, 
			string m3CAT0 = null, 
			int? m3HIGH = null, 
			int? m3AESC = null, 
			int? m3AES2 = null, 
			string m3REMC = null, 
			string m3FPCO = null, 
			int? m3AMOR = null, 
			string m3ASRS = null, 
			int? m3ASSI = null, 
			int? m3AEFI = null, 
			int? m3MPEC = null, 
			int? m3MSPT = null, 
			decimal? m3TBSR = null, 
			string m3MBSR = null, 
			decimal? m3TBUR = null, 
			string m3MBUR = null, 
			int? m3RCFG = null, 
			string m3STNC = null, 
			int? m3MCDE = null, 
			string m3STAT = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			int? m3LPOS = null, 
			int? m3NUCP = null, 
			int? m3ENGI = null, 
			int? m3LOCH = null, 
			string m3ACRF = null, 
			int? m3PPOS = null, 
			decimal? m3DWTC = null, 
			decimal? m3TEFF = null, 
			string m3PRSS = null, 
			string m3SBPR = null, 
			string m3PRIP = null, 
			string m3RESP = null, 
			string m3DOID = null, 
			string m3DWNO = null, 
			string m3MES1 = null, 
			string m3MES2 = null, 
			string m3MES3 = null, 
			string m3MES4 = null, 
			string m3POCA = null, 
			int? m3AMUI = null, 
			string m3ASID = null, 
			int? m3SBNO = null, 
			string m3CFGH = null, 
			string m3PLGR = null, 
			string m3COCE = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MOTP))
				throw new ArgumentNullException(nameof(m3MOTP));
			if (string.IsNullOrWhiteSpace(m3CFGL))
				throw new ArgumentNullException(nameof(m3CFGL));

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3MOTP.Trim())
				.WithQueryParameter("CFGL", m3CFGL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MATP))
				request.WithQueryParameter("MATP", m3MATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3POS0))
				request.WithQueryParameter("POS0", m3POS0.Trim());
			if (!string.IsNullOrWhiteSpace(m3MAND))
				request.WithQueryParameter("MAND", m3MAND.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAT0))
				request.WithQueryParameter("CAT0", m3CAT0.Trim());
			if (m3HIGH.HasValue)
				request.WithQueryParameter("HIGH", m3HIGH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AESC.HasValue)
				request.WithQueryParameter("AESC", m3AESC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AES2.HasValue)
				request.WithQueryParameter("AES2", m3AES2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REMC))
				request.WithQueryParameter("REMC", m3REMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3FPCO))
				request.WithQueryParameter("FPCO", m3FPCO.Trim());
			if (m3AMOR.HasValue)
				request.WithQueryParameter("AMOR", m3AMOR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ASRS))
				request.WithQueryParameter("ASRS", m3ASRS.Trim());
			if (m3ASSI.HasValue)
				request.WithQueryParameter("ASSI", m3ASSI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AEFI.HasValue)
				request.WithQueryParameter("AEFI", m3AEFI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MPEC.HasValue)
				request.WithQueryParameter("MPEC", m3MPEC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSPT.HasValue)
				request.WithQueryParameter("MSPT", m3MSPT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TBSR.HasValue)
				request.WithQueryParameter("TBSR", m3TBSR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MBSR))
				request.WithQueryParameter("MBSR", m3MBSR.Trim());
			if (m3TBUR.HasValue)
				request.WithQueryParameter("TBUR", m3TBUR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MBUR))
				request.WithQueryParameter("MBUR", m3MBUR.Trim());
			if (m3RCFG.HasValue)
				request.WithQueryParameter("RCFG", m3RCFG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STNC))
				request.WithQueryParameter("STNC", m3STNC.Trim());
			if (m3MCDE.HasValue)
				request.WithQueryParameter("MCDE", m3MCDE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3LPOS.HasValue)
				request.WithQueryParameter("LPOS", m3LPOS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUCP.HasValue)
				request.WithQueryParameter("NUCP", m3NUCP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ENGI.HasValue)
				request.WithQueryParameter("ENGI", m3ENGI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LOCH.HasValue)
				request.WithQueryParameter("LOCH", m3LOCH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (m3PPOS.HasValue)
				request.WithQueryParameter("PPOS", m3PPOS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DWTC.HasValue)
				request.WithQueryParameter("DWTC", m3DWTC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TEFF.HasValue)
				request.WithQueryParameter("TEFF", m3TEFF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRSS))
				request.WithQueryParameter("PRSS", m3PRSS.Trim());
			if (!string.IsNullOrWhiteSpace(m3SBPR))
				request.WithQueryParameter("SBPR", m3SBPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRIP))
				request.WithQueryParameter("PRIP", m3PRIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3DWNO))
				request.WithQueryParameter("DWNO", m3DWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES1))
				request.WithQueryParameter("MES1", m3MES1.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES2))
				request.WithQueryParameter("MES2", m3MES2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES3))
				request.WithQueryParameter("MES3", m3MES3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES4))
				request.WithQueryParameter("MES4", m3MES4.Trim());
			if (!string.IsNullOrWhiteSpace(m3POCA))
				request.WithQueryParameter("POCA", m3POCA.Trim());
			if (m3AMUI.HasValue)
				request.WithQueryParameter("AMUI", m3AMUI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ASID))
				request.WithQueryParameter("ASID", m3ASID.Trim());
			if (m3SBNO.HasValue)
				request.WithQueryParameter("SBNO", m3SBNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFGH))
				request.WithQueryParameter("CFGH", m3CFGH.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3COCE))
				request.WithQueryParameter("COCE", m3COCE.Trim());

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
		/// Name Del
		/// Description Delete Positions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MOTP">Model/site (Required)</param>
		/// <param name="m3CFGL">Configuration position (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			string m3MOTP, 
			string m3CFGL, 
			int? m3CONO = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Del",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MOTP))
				throw new ArgumentNullException(nameof(m3MOTP));
			if (string.IsNullOrWhiteSpace(m3CFGL))
				throw new ArgumentNullException(nameof(m3CFGL));

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3MOTP.Trim())
				.WithQueryParameter("CFGL", m3CFGL.Trim());

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
		/// Name GetBasic
		/// Description Get basic data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MOTP">Model/site (Required)</param>
		/// <param name="m3CFGL">Configuration position (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicResponse></returns>
		/// <exception cref="M3Exception<GetBasicResponse>"></exception>
		public async Task<M3Response<GetBasicResponse>> GetBasic(
			string m3MOTP, 
			string m3CFGL, 
			int? m3CONO = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetBasic",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MOTP))
				throw new ArgumentNullException(nameof(m3MOTP));
			if (string.IsNullOrWhiteSpace(m3CFGL))
				throw new ArgumentNullException(nameof(m3CFGL));

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3MOTP.Trim())
				.WithQueryParameter("CFGL", m3CFGL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetBasicResponse>(
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
		/// Name LstPosition
		/// Description List Positions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MOTP">Model/site (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPositionResponse></returns>
		/// <exception cref="M3Exception<LstPositionResponse>"></exception>
		public async Task<M3Response<LstPositionResponse>> LstPosition(
			string m3MOTP, 
			int? m3CONO = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPosition",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MOTP))
				throw new ArgumentNullException(nameof(m3MOTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3MOTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPositionResponse>(
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
		/// Name Upd
		/// Description Upd Positions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MOTP">Model/site (Required)</param>
		/// <param name="m3CFGL">Configuration position (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MATP">Component type</param>
		/// <param name="m3POS0">Location</param>
		/// <param name="m3MAND">Mandatory</param>
		/// <param name="m3CAT0">Config position category</param>
		/// <param name="m3HIGH">Highest in structure</param>
		/// <param name="m3AESC">Criticality class</param>
		/// <param name="m3AES2">Extended-range twin-engine operations</param>
		/// <param name="m3REMC">Removal concept</param>
		/// <param name="m3FPCO">Failure protection concept</param>
		/// <param name="m3AMOR">Maintenance/overhaul/repair class</param>
		/// <param name="m3ASRS">Exchange requirements</param>
		/// <param name="m3ASSI">SOS indicator</param>
		/// <param name="m3AEFI">Effectivity indicator</param>
		/// <param name="m3MPEC">Maintenance percent</param>
		/// <param name="m3MSPT">Service lead time</param>
		/// <param name="m3TBSR">Time between scheduled shop visits</param>
		/// <param name="m3MBSR">Meter - scheduled shop visits</param>
		/// <param name="m3TBUR">Unscheduled removal rate</param>
		/// <param name="m3MBUR">Meter - unscheduled removal rate</param>
		/// <param name="m3RCFG">Configuration position category</param>
		/// <param name="m3STNC">Standard numbering system</param>
		/// <param name="m3MCDE">Maintenance code</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3LPOS">Load position</param>
		/// <param name="m3NUCP">Number of units for config position</param>
		/// <param name="m3ENGI">Engine</param>
		/// <param name="m3LOCH">Location history</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3PPOS">Planning position</param>
		/// <param name="m3DWTC">Downtime cost</param>
		/// <param name="m3TEFF">Target availability</param>
		/// <param name="m3PRSS">Process</param>
		/// <param name="m3SBPR">Subprocess</param>
		/// <param name="m3PRIP">Priority</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3DOID">Document identity</param>
		/// <param name="m3DWNO">Drawing number</param>
		/// <param name="m3MES1">Meter 1</param>
		/// <param name="m3MES2">Meter 2</param>
		/// <param name="m3MES3">Meter 3</param>
		/// <param name="m3MES4">Meter 4</param>
		/// <param name="m3POCA">Configuration position group</param>
		/// <param name="m3AMUI">Meter indicator</param>
		/// <param name="m3ASID">Fixed asset</param>
		/// <param name="m3SBNO">Subnumber</param>
		/// <param name="m3CFGH">NHA configuration position</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3COCE">Cost center</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3MOTP, 
			string m3CFGL, 
			int? m3CONO = null, 
			string m3MATP = null, 
			string m3POS0 = null, 
			string m3MAND = null, 
			string m3CAT0 = null, 
			int? m3HIGH = null, 
			int? m3AESC = null, 
			int? m3AES2 = null, 
			string m3REMC = null, 
			string m3FPCO = null, 
			int? m3AMOR = null, 
			string m3ASRS = null, 
			int? m3ASSI = null, 
			int? m3AEFI = null, 
			int? m3MPEC = null, 
			int? m3MSPT = null, 
			decimal? m3TBSR = null, 
			string m3MBSR = null, 
			decimal? m3TBUR = null, 
			string m3MBUR = null, 
			int? m3RCFG = null, 
			string m3STNC = null, 
			int? m3MCDE = null, 
			string m3STAT = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			int? m3LPOS = null, 
			int? m3NUCP = null, 
			int? m3ENGI = null, 
			int? m3LOCH = null, 
			string m3ACRF = null, 
			int? m3PPOS = null, 
			decimal? m3DWTC = null, 
			decimal? m3TEFF = null, 
			string m3PRSS = null, 
			string m3SBPR = null, 
			string m3PRIP = null, 
			string m3RESP = null, 
			string m3DOID = null, 
			string m3DWNO = null, 
			string m3MES1 = null, 
			string m3MES2 = null, 
			string m3MES3 = null, 
			string m3MES4 = null, 
			string m3POCA = null, 
			int? m3AMUI = null, 
			string m3ASID = null, 
			int? m3SBNO = null, 
			string m3CFGH = null, 
			string m3PLGR = null, 
			string m3COCE = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Upd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MOTP))
				throw new ArgumentNullException(nameof(m3MOTP));
			if (string.IsNullOrWhiteSpace(m3CFGL))
				throw new ArgumentNullException(nameof(m3CFGL));

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3MOTP.Trim())
				.WithQueryParameter("CFGL", m3CFGL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MATP))
				request.WithQueryParameter("MATP", m3MATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3POS0))
				request.WithQueryParameter("POS0", m3POS0.Trim());
			if (!string.IsNullOrWhiteSpace(m3MAND))
				request.WithQueryParameter("MAND", m3MAND.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAT0))
				request.WithQueryParameter("CAT0", m3CAT0.Trim());
			if (m3HIGH.HasValue)
				request.WithQueryParameter("HIGH", m3HIGH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AESC.HasValue)
				request.WithQueryParameter("AESC", m3AESC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AES2.HasValue)
				request.WithQueryParameter("AES2", m3AES2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REMC))
				request.WithQueryParameter("REMC", m3REMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3FPCO))
				request.WithQueryParameter("FPCO", m3FPCO.Trim());
			if (m3AMOR.HasValue)
				request.WithQueryParameter("AMOR", m3AMOR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ASRS))
				request.WithQueryParameter("ASRS", m3ASRS.Trim());
			if (m3ASSI.HasValue)
				request.WithQueryParameter("ASSI", m3ASSI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AEFI.HasValue)
				request.WithQueryParameter("AEFI", m3AEFI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MPEC.HasValue)
				request.WithQueryParameter("MPEC", m3MPEC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSPT.HasValue)
				request.WithQueryParameter("MSPT", m3MSPT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TBSR.HasValue)
				request.WithQueryParameter("TBSR", m3TBSR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MBSR))
				request.WithQueryParameter("MBSR", m3MBSR.Trim());
			if (m3TBUR.HasValue)
				request.WithQueryParameter("TBUR", m3TBUR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MBUR))
				request.WithQueryParameter("MBUR", m3MBUR.Trim());
			if (m3RCFG.HasValue)
				request.WithQueryParameter("RCFG", m3RCFG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STNC))
				request.WithQueryParameter("STNC", m3STNC.Trim());
			if (m3MCDE.HasValue)
				request.WithQueryParameter("MCDE", m3MCDE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3LPOS.HasValue)
				request.WithQueryParameter("LPOS", m3LPOS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUCP.HasValue)
				request.WithQueryParameter("NUCP", m3NUCP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ENGI.HasValue)
				request.WithQueryParameter("ENGI", m3ENGI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LOCH.HasValue)
				request.WithQueryParameter("LOCH", m3LOCH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (m3PPOS.HasValue)
				request.WithQueryParameter("PPOS", m3PPOS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DWTC.HasValue)
				request.WithQueryParameter("DWTC", m3DWTC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TEFF.HasValue)
				request.WithQueryParameter("TEFF", m3TEFF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRSS))
				request.WithQueryParameter("PRSS", m3PRSS.Trim());
			if (!string.IsNullOrWhiteSpace(m3SBPR))
				request.WithQueryParameter("SBPR", m3SBPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRIP))
				request.WithQueryParameter("PRIP", m3PRIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3DWNO))
				request.WithQueryParameter("DWNO", m3DWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES1))
				request.WithQueryParameter("MES1", m3MES1.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES2))
				request.WithQueryParameter("MES2", m3MES2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES3))
				request.WithQueryParameter("MES3", m3MES3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES4))
				request.WithQueryParameter("MES4", m3MES4.Trim());
			if (!string.IsNullOrWhiteSpace(m3POCA))
				request.WithQueryParameter("POCA", m3POCA.Trim());
			if (m3AMUI.HasValue)
				request.WithQueryParameter("AMUI", m3AMUI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ASID))
				request.WithQueryParameter("ASID", m3ASID.Trim());
			if (m3SBNO.HasValue)
				request.WithQueryParameter("SBNO", m3SBNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFGH))
				request.WithQueryParameter("CFGH", m3CFGH.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3COCE))
				request.WithQueryParameter("COCE", m3COCE.Trim());

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
