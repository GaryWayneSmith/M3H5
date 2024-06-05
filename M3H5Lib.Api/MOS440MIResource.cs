/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add Positions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MOTP">Model/site (Required)</param>
		/// <param name="m3_CFGL">Configuration position (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MATP">Component type</param>
		/// <param name="m3_POS0">Location</param>
		/// <param name="m3_MAND">Mandatory</param>
		/// <param name="m3_CAT0">Config position category</param>
		/// <param name="m3_HIGH">Highest in structure</param>
		/// <param name="m3_AESC">Criticality class</param>
		/// <param name="m3_AES2">Extended-range twin-engine operations</param>
		/// <param name="m3_REMC">Removal concept</param>
		/// <param name="m3_FPCO">Failure protection concept</param>
		/// <param name="m3_AMOR">Maintenance/overhaul/repair class</param>
		/// <param name="m3_ASRS">Exchange requirements</param>
		/// <param name="m3_ASSI">SOS indicator</param>
		/// <param name="m3_AEFI">Effectivity indicator</param>
		/// <param name="m3_MPEC">Maintenance percent</param>
		/// <param name="m3_MSPT">Service lead time</param>
		/// <param name="m3_TBSR">Time between scheduled shop visits</param>
		/// <param name="m3_MBSR">Meter - scheduled shop visits</param>
		/// <param name="m3_TBUR">Unscheduled removal rate</param>
		/// <param name="m3_MBUR">Meter - unscheduled removal rate</param>
		/// <param name="m3_RCFG">Configuration position category</param>
		/// <param name="m3_STNC">Standard numbering system</param>
		/// <param name="m3_MCDE">Maintenance code</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_LPOS">Load position</param>
		/// <param name="m3_NUCP">Number of units for config position</param>
		/// <param name="m3_ENGI">Engine</param>
		/// <param name="m3_LOCH">Location history</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_PPOS">Planning position</param>
		/// <param name="m3_DWTC">Downtime cost</param>
		/// <param name="m3_TEFF">Target availability</param>
		/// <param name="m3_PRSS">Process</param>
		/// <param name="m3_SBPR">Subprocess</param>
		/// <param name="m3_PRIP">Priority</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_DOID">Document identity</param>
		/// <param name="m3_DWNO">Drawing number</param>
		/// <param name="m3_MES1">Meter 1</param>
		/// <param name="m3_MES2">Meter 2</param>
		/// <param name="m3_MES3">Meter 3</param>
		/// <param name="m3_MES4">Meter 4</param>
		/// <param name="m3_POCA">Configuration position group</param>
		/// <param name="m3_AMUI">Meter indicator</param>
		/// <param name="m3_ASID">Fixed asset</param>
		/// <param name="m3_SBNO">Subnumber</param>
		/// <param name="m3_CFGH">NHA configuration position</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_COCE">Cost center</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_MOTP, 
			string m3_CFGL, 
			int? m3_CONO = null, 
			string m3_MATP = null, 
			string m3_POS0 = null, 
			string m3_MAND = null, 
			string m3_CAT0 = null, 
			int? m3_HIGH = null, 
			int? m3_AESC = null, 
			int? m3_AES2 = null, 
			string m3_REMC = null, 
			string m3_FPCO = null, 
			int? m3_AMOR = null, 
			string m3_ASRS = null, 
			int? m3_ASSI = null, 
			int? m3_AEFI = null, 
			int? m3_MPEC = null, 
			int? m3_MSPT = null, 
			decimal? m3_TBSR = null, 
			string m3_MBSR = null, 
			decimal? m3_TBUR = null, 
			string m3_MBUR = null, 
			int? m3_RCFG = null, 
			string m3_STNC = null, 
			int? m3_MCDE = null, 
			string m3_STAT = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			int? m3_LPOS = null, 
			int? m3_NUCP = null, 
			int? m3_ENGI = null, 
			int? m3_LOCH = null, 
			string m3_ACRF = null, 
			int? m3_PPOS = null, 
			decimal? m3_DWTC = null, 
			decimal? m3_TEFF = null, 
			string m3_PRSS = null, 
			string m3_SBPR = null, 
			string m3_PRIP = null, 
			string m3_RESP = null, 
			string m3_DOID = null, 
			string m3_DWNO = null, 
			string m3_MES1 = null, 
			string m3_MES2 = null, 
			string m3_MES3 = null, 
			string m3_MES4 = null, 
			string m3_POCA = null, 
			int? m3_AMUI = null, 
			string m3_ASID = null, 
			int? m3_SBNO = null, 
			string m3_CFGH = null, 
			string m3_PLGR = null, 
			string m3_COCE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MOTP))
				throw new ArgumentNullException("m3_MOTP");
			if (string.IsNullOrWhiteSpace(m3_CFGL))
				throw new ArgumentNullException("m3_CFGL");

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3_MOTP.Trim())
				.WithQueryParameter("CFGL", m3_CFGL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MATP))
				request.WithQueryParameter("MATP", m3_MATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POS0))
				request.WithQueryParameter("POS0", m3_POS0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MAND))
				request.WithQueryParameter("MAND", m3_MAND.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAT0))
				request.WithQueryParameter("CAT0", m3_CAT0.Trim());
			if (m3_HIGH.HasValue)
				request.WithQueryParameter("HIGH", m3_HIGH.Value.ToString());
			if (m3_AESC.HasValue)
				request.WithQueryParameter("AESC", m3_AESC.Value.ToString());
			if (m3_AES2.HasValue)
				request.WithQueryParameter("AES2", m3_AES2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REMC))
				request.WithQueryParameter("REMC", m3_REMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FPCO))
				request.WithQueryParameter("FPCO", m3_FPCO.Trim());
			if (m3_AMOR.HasValue)
				request.WithQueryParameter("AMOR", m3_AMOR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ASRS))
				request.WithQueryParameter("ASRS", m3_ASRS.Trim());
			if (m3_ASSI.HasValue)
				request.WithQueryParameter("ASSI", m3_ASSI.Value.ToString());
			if (m3_AEFI.HasValue)
				request.WithQueryParameter("AEFI", m3_AEFI.Value.ToString());
			if (m3_MPEC.HasValue)
				request.WithQueryParameter("MPEC", m3_MPEC.Value.ToString());
			if (m3_MSPT.HasValue)
				request.WithQueryParameter("MSPT", m3_MSPT.Value.ToString());
			if (m3_TBSR.HasValue)
				request.WithQueryParameter("TBSR", m3_TBSR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MBSR))
				request.WithQueryParameter("MBSR", m3_MBSR.Trim());
			if (m3_TBUR.HasValue)
				request.WithQueryParameter("TBUR", m3_TBUR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MBUR))
				request.WithQueryParameter("MBUR", m3_MBUR.Trim());
			if (m3_RCFG.HasValue)
				request.WithQueryParameter("RCFG", m3_RCFG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STNC))
				request.WithQueryParameter("STNC", m3_STNC.Trim());
			if (m3_MCDE.HasValue)
				request.WithQueryParameter("MCDE", m3_MCDE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_LPOS.HasValue)
				request.WithQueryParameter("LPOS", m3_LPOS.Value.ToString());
			if (m3_NUCP.HasValue)
				request.WithQueryParameter("NUCP", m3_NUCP.Value.ToString());
			if (m3_ENGI.HasValue)
				request.WithQueryParameter("ENGI", m3_ENGI.Value.ToString());
			if (m3_LOCH.HasValue)
				request.WithQueryParameter("LOCH", m3_LOCH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (m3_PPOS.HasValue)
				request.WithQueryParameter("PPOS", m3_PPOS.Value.ToString());
			if (m3_DWTC.HasValue)
				request.WithQueryParameter("DWTC", m3_DWTC.Value.ToString());
			if (m3_TEFF.HasValue)
				request.WithQueryParameter("TEFF", m3_TEFF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRSS))
				request.WithQueryParameter("PRSS", m3_PRSS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SBPR))
				request.WithQueryParameter("SBPR", m3_SBPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRIP))
				request.WithQueryParameter("PRIP", m3_PRIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DWNO))
				request.WithQueryParameter("DWNO", m3_DWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES1))
				request.WithQueryParameter("MES1", m3_MES1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES2))
				request.WithQueryParameter("MES2", m3_MES2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES3))
				request.WithQueryParameter("MES3", m3_MES3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES4))
				request.WithQueryParameter("MES4", m3_MES4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POCA))
				request.WithQueryParameter("POCA", m3_POCA.Trim());
			if (m3_AMUI.HasValue)
				request.WithQueryParameter("AMUI", m3_AMUI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ASID))
				request.WithQueryParameter("ASID", m3_ASID.Trim());
			if (m3_SBNO.HasValue)
				request.WithQueryParameter("SBNO", m3_SBNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFGH))
				request.WithQueryParameter("CFGH", m3_CFGH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COCE))
				request.WithQueryParameter("COCE", m3_COCE.Trim());

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
		/// Name Del
		/// Description Delete Positions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MOTP">Model/site (Required)</param>
		/// <param name="m3_CFGL">Configuration position (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			string m3_MOTP, 
			string m3_CFGL, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Del",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MOTP))
				throw new ArgumentNullException("m3_MOTP");
			if (string.IsNullOrWhiteSpace(m3_CFGL))
				throw new ArgumentNullException("m3_CFGL");

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3_MOTP.Trim())
				.WithQueryParameter("CFGL", m3_CFGL.Trim());

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
		/// Name GetBasic
		/// Description Get basic data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MOTP">Model/site (Required)</param>
		/// <param name="m3_CFGL">Configuration position (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicResponse></returns>
		/// <exception cref="M3Exception<GetBasicResponse>"></exception>
		public async Task<M3Response<GetBasicResponse>> GetBasic(
			string m3_MOTP, 
			string m3_CFGL, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBasic",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MOTP))
				throw new ArgumentNullException("m3_MOTP");
			if (string.IsNullOrWhiteSpace(m3_CFGL))
				throw new ArgumentNullException("m3_CFGL");

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3_MOTP.Trim())
				.WithQueryParameter("CFGL", m3_CFGL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetBasicResponse>(
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
		/// Name LstPosition
		/// Description List Positions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MOTP">Model/site (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPositionResponse></returns>
		/// <exception cref="M3Exception<LstPositionResponse>"></exception>
		public async Task<M3Response<LstPositionResponse>> LstPosition(
			string m3_MOTP, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPosition",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MOTP))
				throw new ArgumentNullException("m3_MOTP");

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3_MOTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstPositionResponse>(
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
		/// Name Upd
		/// Description Upd Positions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MOTP">Model/site (Required)</param>
		/// <param name="m3_CFGL">Configuration position (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MATP">Component type</param>
		/// <param name="m3_POS0">Location</param>
		/// <param name="m3_MAND">Mandatory</param>
		/// <param name="m3_CAT0">Config position category</param>
		/// <param name="m3_HIGH">Highest in structure</param>
		/// <param name="m3_AESC">Criticality class</param>
		/// <param name="m3_AES2">Extended-range twin-engine operations</param>
		/// <param name="m3_REMC">Removal concept</param>
		/// <param name="m3_FPCO">Failure protection concept</param>
		/// <param name="m3_AMOR">Maintenance/overhaul/repair class</param>
		/// <param name="m3_ASRS">Exchange requirements</param>
		/// <param name="m3_ASSI">SOS indicator</param>
		/// <param name="m3_AEFI">Effectivity indicator</param>
		/// <param name="m3_MPEC">Maintenance percent</param>
		/// <param name="m3_MSPT">Service lead time</param>
		/// <param name="m3_TBSR">Time between scheduled shop visits</param>
		/// <param name="m3_MBSR">Meter - scheduled shop visits</param>
		/// <param name="m3_TBUR">Unscheduled removal rate</param>
		/// <param name="m3_MBUR">Meter - unscheduled removal rate</param>
		/// <param name="m3_RCFG">Configuration position category</param>
		/// <param name="m3_STNC">Standard numbering system</param>
		/// <param name="m3_MCDE">Maintenance code</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_LPOS">Load position</param>
		/// <param name="m3_NUCP">Number of units for config position</param>
		/// <param name="m3_ENGI">Engine</param>
		/// <param name="m3_LOCH">Location history</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_PPOS">Planning position</param>
		/// <param name="m3_DWTC">Downtime cost</param>
		/// <param name="m3_TEFF">Target availability</param>
		/// <param name="m3_PRSS">Process</param>
		/// <param name="m3_SBPR">Subprocess</param>
		/// <param name="m3_PRIP">Priority</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_DOID">Document identity</param>
		/// <param name="m3_DWNO">Drawing number</param>
		/// <param name="m3_MES1">Meter 1</param>
		/// <param name="m3_MES2">Meter 2</param>
		/// <param name="m3_MES3">Meter 3</param>
		/// <param name="m3_MES4">Meter 4</param>
		/// <param name="m3_POCA">Configuration position group</param>
		/// <param name="m3_AMUI">Meter indicator</param>
		/// <param name="m3_ASID">Fixed asset</param>
		/// <param name="m3_SBNO">Subnumber</param>
		/// <param name="m3_CFGH">NHA configuration position</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_COCE">Cost center</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3_MOTP, 
			string m3_CFGL, 
			int? m3_CONO = null, 
			string m3_MATP = null, 
			string m3_POS0 = null, 
			string m3_MAND = null, 
			string m3_CAT0 = null, 
			int? m3_HIGH = null, 
			int? m3_AESC = null, 
			int? m3_AES2 = null, 
			string m3_REMC = null, 
			string m3_FPCO = null, 
			int? m3_AMOR = null, 
			string m3_ASRS = null, 
			int? m3_ASSI = null, 
			int? m3_AEFI = null, 
			int? m3_MPEC = null, 
			int? m3_MSPT = null, 
			decimal? m3_TBSR = null, 
			string m3_MBSR = null, 
			decimal? m3_TBUR = null, 
			string m3_MBUR = null, 
			int? m3_RCFG = null, 
			string m3_STNC = null, 
			int? m3_MCDE = null, 
			string m3_STAT = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			int? m3_LPOS = null, 
			int? m3_NUCP = null, 
			int? m3_ENGI = null, 
			int? m3_LOCH = null, 
			string m3_ACRF = null, 
			int? m3_PPOS = null, 
			decimal? m3_DWTC = null, 
			decimal? m3_TEFF = null, 
			string m3_PRSS = null, 
			string m3_SBPR = null, 
			string m3_PRIP = null, 
			string m3_RESP = null, 
			string m3_DOID = null, 
			string m3_DWNO = null, 
			string m3_MES1 = null, 
			string m3_MES2 = null, 
			string m3_MES3 = null, 
			string m3_MES4 = null, 
			string m3_POCA = null, 
			int? m3_AMUI = null, 
			string m3_ASID = null, 
			int? m3_SBNO = null, 
			string m3_CFGH = null, 
			string m3_PLGR = null, 
			string m3_COCE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Upd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MOTP))
				throw new ArgumentNullException("m3_MOTP");
			if (string.IsNullOrWhiteSpace(m3_CFGL))
				throw new ArgumentNullException("m3_CFGL");

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3_MOTP.Trim())
				.WithQueryParameter("CFGL", m3_CFGL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MATP))
				request.WithQueryParameter("MATP", m3_MATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POS0))
				request.WithQueryParameter("POS0", m3_POS0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MAND))
				request.WithQueryParameter("MAND", m3_MAND.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAT0))
				request.WithQueryParameter("CAT0", m3_CAT0.Trim());
			if (m3_HIGH.HasValue)
				request.WithQueryParameter("HIGH", m3_HIGH.Value.ToString());
			if (m3_AESC.HasValue)
				request.WithQueryParameter("AESC", m3_AESC.Value.ToString());
			if (m3_AES2.HasValue)
				request.WithQueryParameter("AES2", m3_AES2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REMC))
				request.WithQueryParameter("REMC", m3_REMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FPCO))
				request.WithQueryParameter("FPCO", m3_FPCO.Trim());
			if (m3_AMOR.HasValue)
				request.WithQueryParameter("AMOR", m3_AMOR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ASRS))
				request.WithQueryParameter("ASRS", m3_ASRS.Trim());
			if (m3_ASSI.HasValue)
				request.WithQueryParameter("ASSI", m3_ASSI.Value.ToString());
			if (m3_AEFI.HasValue)
				request.WithQueryParameter("AEFI", m3_AEFI.Value.ToString());
			if (m3_MPEC.HasValue)
				request.WithQueryParameter("MPEC", m3_MPEC.Value.ToString());
			if (m3_MSPT.HasValue)
				request.WithQueryParameter("MSPT", m3_MSPT.Value.ToString());
			if (m3_TBSR.HasValue)
				request.WithQueryParameter("TBSR", m3_TBSR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MBSR))
				request.WithQueryParameter("MBSR", m3_MBSR.Trim());
			if (m3_TBUR.HasValue)
				request.WithQueryParameter("TBUR", m3_TBUR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MBUR))
				request.WithQueryParameter("MBUR", m3_MBUR.Trim());
			if (m3_RCFG.HasValue)
				request.WithQueryParameter("RCFG", m3_RCFG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STNC))
				request.WithQueryParameter("STNC", m3_STNC.Trim());
			if (m3_MCDE.HasValue)
				request.WithQueryParameter("MCDE", m3_MCDE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_LPOS.HasValue)
				request.WithQueryParameter("LPOS", m3_LPOS.Value.ToString());
			if (m3_NUCP.HasValue)
				request.WithQueryParameter("NUCP", m3_NUCP.Value.ToString());
			if (m3_ENGI.HasValue)
				request.WithQueryParameter("ENGI", m3_ENGI.Value.ToString());
			if (m3_LOCH.HasValue)
				request.WithQueryParameter("LOCH", m3_LOCH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (m3_PPOS.HasValue)
				request.WithQueryParameter("PPOS", m3_PPOS.Value.ToString());
			if (m3_DWTC.HasValue)
				request.WithQueryParameter("DWTC", m3_DWTC.Value.ToString());
			if (m3_TEFF.HasValue)
				request.WithQueryParameter("TEFF", m3_TEFF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRSS))
				request.WithQueryParameter("PRSS", m3_PRSS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SBPR))
				request.WithQueryParameter("SBPR", m3_SBPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRIP))
				request.WithQueryParameter("PRIP", m3_PRIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DWNO))
				request.WithQueryParameter("DWNO", m3_DWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES1))
				request.WithQueryParameter("MES1", m3_MES1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES2))
				request.WithQueryParameter("MES2", m3_MES2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES3))
				request.WithQueryParameter("MES3", m3_MES3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES4))
				request.WithQueryParameter("MES4", m3_MES4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POCA))
				request.WithQueryParameter("POCA", m3_POCA.Trim());
			if (m3_AMUI.HasValue)
				request.WithQueryParameter("AMUI", m3_AMUI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ASID))
				request.WithQueryParameter("ASID", m3_ASID.Trim());
			if (m3_SBNO.HasValue)
				request.WithQueryParameter("SBNO", m3_SBNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFGH))
				request.WithQueryParameter("CFGH", m3_CFGH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COCE))
				request.WithQueryParameter("COCE", m3_COCE.Trim());

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
