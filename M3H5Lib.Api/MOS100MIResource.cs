/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MOS100MI;
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
	/// Name: MOS100MI
	/// Component Name: MaintenanceOrder
	/// Description: Maintenance order interface
	/// Version Release: 5eaG
	///</summary>
	public partial class MOS100MIResource : M3BaseResourceEndpoint
	{
		public MOS100MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS100MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddInboxNetwork
		/// Description Add record to network in-box
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_RORC">Reference order category (Required)</param>
		/// <param name="m3_RORN">Reference order number (Required)</param>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_SPMO">Supplying WO (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddInboxNetwork(
			string m3_FACI, 
			int m3_RORC, 
			string m3_RORN, 
			string m3_MWNO, 
			int m3_SPMO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddInboxNetwork",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_RORN))
				throw new ArgumentNullException("m3_RORN");
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("RORC", m3_RORC.ToString())
				.WithQueryParameter("RORN", m3_RORN.Trim())
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("SPMO", m3_SPMO.ToString());

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
		/// Name AddInboxOp
		/// Description Add record to operations in-box
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3_RPCD">Released/planned code (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_MSTI">Start time (Required)</param>
		/// <param name="m3_FIDT">Finish date (Required)</param>
		/// <param name="m3_MFTI">Finish time (Required)</param>
		/// <param name="m3_PLGR">Finite scheduled resource (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PLG1">APP work center</param>
		/// <param name="m3_PLGF">Forced resource</param>
		/// <param name="m3_NXOP">Next operation</param>
		/// <param name="m3_APON">Primary operation number</param>
		/// <param name="m3_POOC">Parallel operation overlap code</param>
		/// <param name="m3_SLAT">Transit U/M / Overlap's code</param>
		/// <param name="m3_RESR">Resource restriction</param>
		/// <param name="m3_SPLK">Split code operation</param>
		/// <param name="m3_SPLN">Number of operations after split</param>
		/// <param name="m3_SPSZ">Split quantinty</param>
		/// <param name="m3_FRCD">Forced start date</param>
		/// <param name="m3_FRCT">Forced start time</param>
		/// <param name="m3_SEQS">Sequencing status</param>
		/// <param name="m3_PRAP">APP processed</param>
		/// <param name="m3_SPLT">Change code</param>
		/// <param name="m3_CHNO">Change number</param>
		/// <param name="m3_WLDE">Infinite/finite</param>
		/// <param name="m3_PLNR">Planned number of resources</param>
		/// <param name="m3_SETI">Setup time</param>
		/// <param name="m3_ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3_SCHN">Schedule number</param>
		/// <param name="m3_SCHS">Sequence number within schedule</param>
		/// <param name="m3_MACH">Machine identity</param>
		/// <param name="m3_OADS">Operation element exists</param>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="m3_ROLE">Role/organizational position</param>
		/// <param name="m3_PITI">Run time</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_OPDS">Operation description</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_RRSD">Requested start date</param>
		/// <param name="m3_RRST">Requested start time</param>
		/// <param name="m3_RRFD">Requested finish date</param>
		/// <param name="m3_RRFT">Requested finish time</param>
		/// <param name="m3_RBUP">Remaining buffer percent</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddInboxOp(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_MFNO, 
			string m3_RPCD, 
			int m3_OPNO, 
			DateTime m3_STDT, 
			int m3_MSTI, 
			DateTime m3_FIDT, 
			int m3_MFTI, 
			string m3_PLGR, 
			int? m3_CONO = null, 
			string m3_PLG1 = null, 
			string m3_PLGF = null, 
			int? m3_NXOP = null, 
			int? m3_APON = null, 
			int? m3_POOC = null, 
			string m3_SLAT = null, 
			string m3_RESR = null, 
			int? m3_SPLK = null, 
			int? m3_SPLN = null, 
			decimal? m3_SPSZ = null, 
			DateTime? m3_FRCD = null, 
			int? m3_FRCT = null, 
			int? m3_SEQS = null, 
			string m3_PRAP = null, 
			int? m3_SPLT = null, 
			int? m3_CHNO = null, 
			int? m3_WLDE = null, 
			string m3_PLNR = null, 
			int? m3_SETI = null, 
			decimal? m3_ORQT = null, 
			decimal? m3_SCHN = null, 
			long? m3_SCHS = null, 
			string m3_MACH = null, 
			int? m3_OADS = null, 
			string m3_EMNO = null, 
			string m3_ROLE = null, 
			int? m3_PITI = null, 
			string m3_SUFI = null, 
			string m3_OPDS = null, 
			decimal? m3_TXID = null, 
			DateTime? m3_RRSD = null, 
			int? m3_RRST = null, 
			DateTime? m3_RRFD = null, 
			int? m3_RRFT = null, 
			int? m3_RBUP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddInboxOp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_MFNO))
				throw new ArgumentNullException("m3_MFNO");
			if (string.IsNullOrWhiteSpace(m3_RPCD))
				throw new ArgumentNullException("m3_RPCD");
			if (string.IsNullOrWhiteSpace(m3_PLGR))
				throw new ArgumentNullException("m3_PLGR");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("MFNO", m3_MFNO.Trim())
				.WithQueryParameter("RPCD", m3_RPCD.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("MSTI", m3_MSTI.ToString())
				.WithQueryParameter("FIDT", m3_FIDT.ToM3String())
				.WithQueryParameter("MFTI", m3_MFTI.ToString())
				.WithQueryParameter("PLGR", m3_PLGR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLG1))
				request.WithQueryParameter("PLG1", m3_PLG1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGF))
				request.WithQueryParameter("PLGF", m3_PLGF.Trim());
			if (m3_NXOP.HasValue)
				request.WithQueryParameter("NXOP", m3_NXOP.Value.ToString());
			if (m3_APON.HasValue)
				request.WithQueryParameter("APON", m3_APON.Value.ToString());
			if (m3_POOC.HasValue)
				request.WithQueryParameter("POOC", m3_POOC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SLAT))
				request.WithQueryParameter("SLAT", m3_SLAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESR))
				request.WithQueryParameter("RESR", m3_RESR.Trim());
			if (m3_SPLK.HasValue)
				request.WithQueryParameter("SPLK", m3_SPLK.Value.ToString());
			if (m3_SPLN.HasValue)
				request.WithQueryParameter("SPLN", m3_SPLN.Value.ToString());
			if (m3_SPSZ.HasValue)
				request.WithQueryParameter("SPSZ", m3_SPSZ.Value.ToString());
			if (m3_FRCD.HasValue)
				request.WithQueryParameter("FRCD", m3_FRCD.Value.ToM3String());
			if (m3_FRCT.HasValue)
				request.WithQueryParameter("FRCT", m3_FRCT.Value.ToString());
			if (m3_SEQS.HasValue)
				request.WithQueryParameter("SEQS", m3_SEQS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRAP))
				request.WithQueryParameter("PRAP", m3_PRAP.Trim());
			if (m3_SPLT.HasValue)
				request.WithQueryParameter("SPLT", m3_SPLT.Value.ToString());
			if (m3_CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3_CHNO.Value.ToString());
			if (m3_WLDE.HasValue)
				request.WithQueryParameter("WLDE", m3_WLDE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLNR))
				request.WithQueryParameter("PLNR", m3_PLNR.Trim());
			if (m3_SETI.HasValue)
				request.WithQueryParameter("SETI", m3_SETI.Value.ToString());
			if (m3_ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3_ORQT.Value.ToString());
			if (m3_SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3_SCHN.Value.ToString());
			if (m3_SCHS.HasValue)
				request.WithQueryParameter("SCHS", m3_SCHS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MACH))
				request.WithQueryParameter("MACH", m3_MACH.Trim());
			if (m3_OADS.HasValue)
				request.WithQueryParameter("OADS", m3_OADS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ROLE))
				request.WithQueryParameter("ROLE", m3_ROLE.Trim());
			if (m3_PITI.HasValue)
				request.WithQueryParameter("PITI", m3_PITI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPDS))
				request.WithQueryParameter("OPDS", m3_OPDS.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_RRSD.HasValue)
				request.WithQueryParameter("RRSD", m3_RRSD.Value.ToM3String());
			if (m3_RRST.HasValue)
				request.WithQueryParameter("RRST", m3_RRST.Value.ToString());
			if (m3_RRFD.HasValue)
				request.WithQueryParameter("RRFD", m3_RRFD.Value.ToM3String());
			if (m3_RRFT.HasValue)
				request.WithQueryParameter("RRFT", m3_RRFT.Value.ToString());
			if (m3_RBUP.HasValue)
				request.WithQueryParameter("RBUP", m3_RBUP.Value.ToString());

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
		/// Name AddInboxOrder
		/// Description Add record to order in-box
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3_RPCD">Released/planned code (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_MSTI">Start time (Required)</param>
		/// <param name="m3_FIDT">Finish date (Required)</param>
		/// <param name="m3_MFTI">Finish time (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORQA">Ordered quantity alternate U/M</param>
		/// <param name="m3_ORQT">Ordered quantity basic U/M</param>
		/// <param name="m3_PULD">Pull-up control delayed</param>
		/// <param name="m3_PULN">Pull-up control non-delayed</param>
		/// <param name="m3_AOID">Alternative routing</param>
		/// <param name="m3_CHNO">Change number</param>
		/// <param name="m3_UPDC">Update code</param>
		/// <param name="m3_SUBN">Sub-network mark</param>
		/// <param name="m3_SUBD">Sub-network date</param>
		/// <param name="m3_PRIO">Priority</param>
		/// <param name="m3_NTWP">External network priority</param>
		/// <param name="m3_CLGP">Color group</param>
		/// <param name="m3_PSTS">Status - planned MO</param>
		/// <param name="m3_QADJ">Adjust quantity (yes/no)</param>
		/// <param name="m3_NSTP">Shutdown</param>
		/// <param name="m3_RRSD">Requested start date</param>
		/// <param name="m3_RRST">Requested start time</param>
		/// <param name="m3_RRFD">Requested finish date</param>
		/// <param name="m3_RRFT">Requested finish time</param>
		/// <param name="m3_RREQ">Requester</param>
		/// <param name="m3_RBAM">Request budget amount</param>
		/// <param name="m3_ESBU">Estimated cost</param>
		/// <param name="m3_EDWT">Estimated downtime</param>
		/// <param name="m3_SCHL">Scheduling logic</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddInboxOrder(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_MFNO, 
			string m3_RPCD, 
			DateTime m3_STDT, 
			int m3_MSTI, 
			DateTime m3_FIDT, 
			int m3_MFTI, 
			int? m3_CONO = null, 
			decimal? m3_ORQA = null, 
			decimal? m3_ORQT = null, 
			int? m3_PULD = null, 
			int? m3_PULN = null, 
			string m3_AOID = null, 
			int? m3_CHNO = null, 
			int? m3_UPDC = null, 
			int? m3_SUBN = null, 
			DateTime? m3_SUBD = null, 
			int? m3_PRIO = null, 
			int? m3_NTWP = null, 
			int? m3_CLGP = null, 
			string m3_PSTS = null, 
			int? m3_QADJ = null, 
			int? m3_NSTP = null, 
			DateTime? m3_RRSD = null, 
			int? m3_RRST = null, 
			DateTime? m3_RRFD = null, 
			int? m3_RRFT = null, 
			string m3_RREQ = null, 
			decimal? m3_RBAM = null, 
			decimal? m3_ESBU = null, 
			int? m3_EDWT = null, 
			int? m3_SCHL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddInboxOrder",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_MFNO))
				throw new ArgumentNullException("m3_MFNO");
			if (string.IsNullOrWhiteSpace(m3_RPCD))
				throw new ArgumentNullException("m3_RPCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("MFNO", m3_MFNO.Trim())
				.WithQueryParameter("RPCD", m3_RPCD.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("MSTI", m3_MSTI.ToString())
				.WithQueryParameter("FIDT", m3_FIDT.ToM3String())
				.WithQueryParameter("MFTI", m3_MFTI.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_ORQA.HasValue)
				request.WithQueryParameter("ORQA", m3_ORQA.Value.ToString());
			if (m3_ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3_ORQT.Value.ToString());
			if (m3_PULD.HasValue)
				request.WithQueryParameter("PULD", m3_PULD.Value.ToString());
			if (m3_PULN.HasValue)
				request.WithQueryParameter("PULN", m3_PULN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AOID))
				request.WithQueryParameter("AOID", m3_AOID.Trim());
			if (m3_CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3_CHNO.Value.ToString());
			if (m3_UPDC.HasValue)
				request.WithQueryParameter("UPDC", m3_UPDC.Value.ToString());
			if (m3_SUBN.HasValue)
				request.WithQueryParameter("SUBN", m3_SUBN.Value.ToString());
			if (m3_SUBD.HasValue)
				request.WithQueryParameter("SUBD", m3_SUBD.Value.ToM3String());
			if (m3_PRIO.HasValue)
				request.WithQueryParameter("PRIO", m3_PRIO.Value.ToString());
			if (m3_NTWP.HasValue)
				request.WithQueryParameter("NTWP", m3_NTWP.Value.ToString());
			if (m3_CLGP.HasValue)
				request.WithQueryParameter("CLGP", m3_CLGP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PSTS))
				request.WithQueryParameter("PSTS", m3_PSTS.Trim());
			if (m3_QADJ.HasValue)
				request.WithQueryParameter("QADJ", m3_QADJ.Value.ToString());
			if (m3_NSTP.HasValue)
				request.WithQueryParameter("NSTP", m3_NSTP.Value.ToString());
			if (m3_RRSD.HasValue)
				request.WithQueryParameter("RRSD", m3_RRSD.Value.ToM3String());
			if (m3_RRST.HasValue)
				request.WithQueryParameter("RRST", m3_RRST.Value.ToString());
			if (m3_RRFD.HasValue)
				request.WithQueryParameter("RRFD", m3_RRFD.Value.ToM3String());
			if (m3_RRFT.HasValue)
				request.WithQueryParameter("RRFT", m3_RRFT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RREQ))
				request.WithQueryParameter("RREQ", m3_RREQ.Trim());
			if (m3_RBAM.HasValue)
				request.WithQueryParameter("RBAM", m3_RBAM.Value.ToString());
			if (m3_ESBU.HasValue)
				request.WithQueryParameter("ESBU", m3_ESBU.Value.ToString());
			if (m3_EDWT.HasValue)
				request.WithQueryParameter("EDWT", m3_EDWT.Value.ToString());
			if (m3_SCHL.HasValue)
				request.WithQueryParameter("SCHL", m3_SCHL.Value.ToString());

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
		/// Name AddMtrl
		/// Description Add material to existing work order
		/// Version Release: 5eaF
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_MTNO">Component number (Required)</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_DWNO">Drawing number</param>
		/// <param name="m3_FMT1">Text</param>
		/// <param name="m3_FMT2">Technical reference</param>
		/// <param name="m3_CNQT">Quantity</param>
		/// <param name="m3_PEUN">Product engineering U/M</param>
		/// <param name="m3_LGTH">Length</param>
		/// <param name="m3_WDTH">Width</param>
		/// <param name="m3_LWF1">Factor 1</param>
		/// <param name="m3_LWF2">Factor 2</param>
		/// <param name="m3_RDAT">Reservation date</param>
		/// <param name="m3_TIHM">Time hours & minutes</param>
		/// <param name="m3_MDBF">Lead time offset</param>
		/// <param name="m3_MPRC">Component price</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_PRDY">Production days</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_STGS">Subcontract control</param>
		/// <param name="m3_SPMT">Issue method</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_DWPO">Drawing position</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_WMST">Material status</param>
		/// <param name="m3_NORD">Additional days - material reservation</param>
		/// <param name="m3_RTHI">Reservation time - material</param>
		/// <param name="m3_DSP1">Skip Warning Messages</param>
		/// <param name="m3_EXCH">Exchange</param>
		/// <param name="m3_ADRR">Address file</param>
		/// <param name="m3_ADRT">Address type</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_LTYP">Line type</param>
		/// <param name="m3_FWHL">From warehouse</param>
		/// <param name="m3_TRTP">Order type</param>
		/// <param name="m3_IORL">Interface order line</param>
		/// <param name="m3_IORN">Interface order number</param>
		/// <param name="m3_PRMO">Price origin</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_OT53">Abnormal demand</param>
		/// <param name="m3_FWHS">Firm warehouse</param>
		/// <param name="m3_FXCD">Quantity Relation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddMtrlResponse></returns>
		/// <exception cref="M3Exception<AddMtrlResponse>"></exception>
		public async Task<M3Response<AddMtrlResponse>> AddMtrl(
			string m3_MWNO, 
			string m3_MTNO, 
			int? m3_OPNO = null, 
			int? m3_MSEQ = null, 
			string m3_DWNO = null, 
			string m3_FMT1 = null, 
			string m3_FMT2 = null, 
			decimal? m3_CNQT = null, 
			string m3_PEUN = null, 
			int? m3_LGTH = null, 
			int? m3_WDTH = null, 
			decimal? m3_LWF1 = null, 
			decimal? m3_LWF2 = null, 
			DateTime? m3_RDAT = null, 
			int? m3_TIHM = null, 
			int? m3_MDBF = null, 
			decimal? m3_MPRC = null, 
			string m3_WHLO = null, 
			string m3_WHSL = null, 
			string m3_TWSL = null, 
			string m3_BANO = null, 
			string m3_SUNO = null, 
			int? m3_PRDY = null, 
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			decimal? m3_ATNR = null, 
			int? m3_STGS = null, 
			int? m3_SPMT = null, 
			string m3_RSCD = null, 
			string m3_DWPO = null, 
			decimal? m3_TXID = null, 
			string m3_WMST = null, 
			string m3_NORD = null, 
			int? m3_RTHI = null, 
			int? m3_DSP1 = null, 
			int? m3_EXCH = null, 
			int? m3_ADRR = null, 
			int? m3_ADRT = null, 
			string m3_ADID = null, 
			string m3_LTYP = null, 
			string m3_FWHL = null, 
			string m3_TRTP = null, 
			int? m3_IORL = null, 
			string m3_IORN = null, 
			string m3_PRMO = null, 
			decimal? m3_SAPR = null, 
			int? m3_OT53 = null, 
			int? m3_FWHS = null, 
			int? m3_FXCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddMtrl",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");
			if (string.IsNullOrWhiteSpace(m3_MTNO))
				throw new ArgumentNullException("m3_MTNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("MTNO", m3_MTNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DWNO))
				request.WithQueryParameter("DWNO", m3_DWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMT1))
				request.WithQueryParameter("FMT1", m3_FMT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMT2))
				request.WithQueryParameter("FMT2", m3_FMT2.Trim());
			if (m3_CNQT.HasValue)
				request.WithQueryParameter("CNQT", m3_CNQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PEUN))
				request.WithQueryParameter("PEUN", m3_PEUN.Trim());
			if (m3_LGTH.HasValue)
				request.WithQueryParameter("LGTH", m3_LGTH.Value.ToString());
			if (m3_WDTH.HasValue)
				request.WithQueryParameter("WDTH", m3_WDTH.Value.ToString());
			if (m3_LWF1.HasValue)
				request.WithQueryParameter("LWF1", m3_LWF1.Value.ToString());
			if (m3_LWF2.HasValue)
				request.WithQueryParameter("LWF2", m3_LWF2.Value.ToString());
			if (m3_RDAT.HasValue)
				request.WithQueryParameter("RDAT", m3_RDAT.Value.ToM3String());
			if (m3_TIHM.HasValue)
				request.WithQueryParameter("TIHM", m3_TIHM.Value.ToString());
			if (m3_MDBF.HasValue)
				request.WithQueryParameter("MDBF", m3_MDBF.Value.ToString());
			if (m3_MPRC.HasValue)
				request.WithQueryParameter("MPRC", m3_MPRC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_PRDY.HasValue)
				request.WithQueryParameter("PRDY", m3_PRDY.Value.ToString());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (m3_STGS.HasValue)
				request.WithQueryParameter("STGS", m3_STGS.Value.ToString());
			if (m3_SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3_SPMT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DWPO))
				request.WithQueryParameter("DWPO", m3_DWPO.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WMST))
				request.WithQueryParameter("WMST", m3_WMST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NORD))
				request.WithQueryParameter("NORD", m3_NORD.Trim());
			if (m3_RTHI.HasValue)
				request.WithQueryParameter("RTHI", m3_RTHI.Value.ToString());
			if (m3_DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3_DSP1.Value.ToString());
			if (m3_EXCH.HasValue)
				request.WithQueryParameter("EXCH", m3_EXCH.Value.ToString());
			if (m3_ADRR.HasValue)
				request.WithQueryParameter("ADRR", m3_ADRR.Value.ToString());
			if (m3_ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3_ADRT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LTYP))
				request.WithQueryParameter("LTYP", m3_LTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FWHL))
				request.WithQueryParameter("FWHL", m3_FWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRTP))
				request.WithQueryParameter("TRTP", m3_TRTP.Trim());
			if (m3_IORL.HasValue)
				request.WithQueryParameter("IORL", m3_IORL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_IORN))
				request.WithQueryParameter("IORN", m3_IORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRMO))
				request.WithQueryParameter("PRMO", m3_PRMO.Trim());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_OT53.HasValue)
				request.WithQueryParameter("OT53", m3_OT53.Value.ToString());
			if (m3_FWHS.HasValue)
				request.WithQueryParameter("FWHS", m3_FWHS.Value.ToString());
			if (m3_FXCD.HasValue)
				request.WithQueryParameter("FXCD", m3_FXCD.Value.ToString());

			// Execute the request
			var result = await Execute<AddMtrlResponse>(
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
		/// Name AddOp
		/// Description Add operation to existing work order
		/// Version Release: 5eaD
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_PLGR">Work center (Required)</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_OPDS">Operation description</param>
		/// <param name="m3_TXT1">Text line 1</param>
		/// <param name="m3_TXT2">Text line 2</param>
		/// <param name="m3_DOID">Document identity</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_MSTI">Start time</param>
		/// <param name="m3_FIDT">Finish date</param>
		/// <param name="m3_MFTI">Finish time</param>
		/// <param name="m3_LASK">Labor skill</param>
		/// <param name="m3_FXTI">Fixed time</param>
		/// <param name="m3_SETI">Setup time</param>
		/// <param name="m3_OSET">External setup time</param>
		/// <param name="m3_PITI">Run time</param>
		/// <param name="m3_SENP">Planned number of workers - setup</param>
		/// <param name="m3_PRNP">Planned number of workers - run time</param>
		/// <param name="m3_PRNM">Planned number of machines</param>
		/// <param name="m3_TOOL">Tool number</param>
		/// <param name="m3_CAMP">Number of labor tickets</param>
		/// <param name="m3_QUDY">Queue days</param>
		/// <param name="m3_SLAC">Transport value in days</param>
		/// <param name="m3_ODBF">Lead time offset</param>
		/// <param name="m3_PRDY">Production days</param>
		/// <param name="m3_SWQT">Setup scrap</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_PSSQ">Co-sorting key</param>
		/// <param name="m3_SCHN">Schedule number</param>
		/// <param name="m3_SCHS">Schedule number sequence</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_EQNO">Equipment number</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_SPRQ">Specific requirement category</param>
		/// <param name="m3_SPRT">Specific requirements</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_DLY1">Delay time 1</param>
		/// <param name="m3_DLY2">Delay time 2</param>
		/// <param name="m3_FCLA">Error code 1</param>
		/// <param name="m3_FCL2">Error code 2</param>
		/// <param name="m3_FCL3">Error code 3</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_DPLG">Deviating work center</param>
		/// <param name="m3_WLDE">Infinite/finite</param>
		/// <param name="m3_SEPR">Setup price</param>
		/// <param name="m3_PIPR">Unit price</param>
		/// <param name="m3_DOWT">Downtime</param>
		/// <param name="m3_IORN">Interface order number</param>
		/// <param name="m3_IORL">Interface order line</param>
		/// <param name="m3_ORQT">Ordered quantity - basic U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddOpResponse></returns>
		/// <exception cref="M3Exception<AddOpResponse>"></exception>
		public async Task<M3Response<AddOpResponse>> AddOp(
			string m3_MWNO, 
			string m3_PLGR, 
			int? m3_OPNO = null, 
			string m3_OPDS = null, 
			string m3_TXT1 = null, 
			string m3_TXT2 = null, 
			string m3_DOID = null, 
			DateTime? m3_STDT = null, 
			int? m3_MSTI = null, 
			DateTime? m3_FIDT = null, 
			int? m3_MFTI = null, 
			string m3_LASK = null, 
			int? m3_FXTI = null, 
			int? m3_SETI = null, 
			int? m3_OSET = null, 
			int? m3_PITI = null, 
			int? m3_SENP = null, 
			int? m3_PRNP = null, 
			int? m3_PRNM = null, 
			string m3_TOOL = null, 
			int? m3_CAMP = null, 
			int? m3_QUDY = null, 
			decimal? m3_SLAC = null, 
			int? m3_ODBF = null, 
			int? m3_PRDY = null, 
			decimal? m3_SWQT = null, 
			string m3_SUNO = null, 
			string m3_PSSQ = null, 
			decimal? m3_SCHN = null, 
			long? m3_SCHS = null, 
			decimal? m3_TXID = null, 
			string m3_CFGL = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_EQNO = null, 
			string m3_SUFI = null, 
			string m3_SPRQ = null, 
			string m3_SPRT = null, 
			int? m3_RORL = null, 
			int? m3_DLY1 = null, 
			int? m3_DLY2 = null, 
			string m3_FCLA = null, 
			string m3_FCL2 = null, 
			string m3_FCL3 = null, 
			decimal? m3_ATNR = null, 
			string m3_DPLG = null, 
			int? m3_WLDE = null, 
			decimal? m3_SEPR = null, 
			decimal? m3_PIPR = null, 
			int? m3_DOWT = null, 
			string m3_IORN = null, 
			int? m3_IORL = null, 
			decimal? m3_ORQT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddOp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");
			if (string.IsNullOrWhiteSpace(m3_PLGR))
				throw new ArgumentNullException("m3_PLGR");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("PLGR", m3_PLGR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OPDS))
				request.WithQueryParameter("OPDS", m3_OPDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT1))
				request.WithQueryParameter("TXT1", m3_TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT2))
				request.WithQueryParameter("TXT2", m3_TXT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_MSTI.HasValue)
				request.WithQueryParameter("MSTI", m3_MSTI.Value.ToString());
			if (m3_FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3_FIDT.Value.ToM3String());
			if (m3_MFTI.HasValue)
				request.WithQueryParameter("MFTI", m3_MFTI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LASK))
				request.WithQueryParameter("LASK", m3_LASK.Trim());
			if (m3_FXTI.HasValue)
				request.WithQueryParameter("FXTI", m3_FXTI.Value.ToString());
			if (m3_SETI.HasValue)
				request.WithQueryParameter("SETI", m3_SETI.Value.ToString());
			if (m3_OSET.HasValue)
				request.WithQueryParameter("OSET", m3_OSET.Value.ToString());
			if (m3_PITI.HasValue)
				request.WithQueryParameter("PITI", m3_PITI.Value.ToString());
			if (m3_SENP.HasValue)
				request.WithQueryParameter("SENP", m3_SENP.Value.ToString());
			if (m3_PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3_PRNP.Value.ToString());
			if (m3_PRNM.HasValue)
				request.WithQueryParameter("PRNM", m3_PRNM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TOOL))
				request.WithQueryParameter("TOOL", m3_TOOL.Trim());
			if (m3_CAMP.HasValue)
				request.WithQueryParameter("CAMP", m3_CAMP.Value.ToString());
			if (m3_QUDY.HasValue)
				request.WithQueryParameter("QUDY", m3_QUDY.Value.ToString());
			if (m3_SLAC.HasValue)
				request.WithQueryParameter("SLAC", m3_SLAC.Value.ToString());
			if (m3_ODBF.HasValue)
				request.WithQueryParameter("ODBF", m3_ODBF.Value.ToString());
			if (m3_PRDY.HasValue)
				request.WithQueryParameter("PRDY", m3_PRDY.Value.ToString());
			if (m3_SWQT.HasValue)
				request.WithQueryParameter("SWQT", m3_SWQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PSSQ))
				request.WithQueryParameter("PSSQ", m3_PSSQ.Trim());
			if (m3_SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3_SCHN.Value.ToString());
			if (m3_SCHS.HasValue)
				request.WithQueryParameter("SCHS", m3_SCHS.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQNO))
				request.WithQueryParameter("EQNO", m3_EQNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPRQ))
				request.WithQueryParameter("SPRQ", m3_SPRQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPRT))
				request.WithQueryParameter("SPRT", m3_SPRT.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_DLY1.HasValue)
				request.WithQueryParameter("DLY1", m3_DLY1.Value.ToString());
			if (m3_DLY2.HasValue)
				request.WithQueryParameter("DLY2", m3_DLY2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FCLA))
				request.WithQueryParameter("FCLA", m3_FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL2))
				request.WithQueryParameter("FCL2", m3_FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL3))
				request.WithQueryParameter("FCL3", m3_FCL3.Trim());
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DPLG))
				request.WithQueryParameter("DPLG", m3_DPLG.Trim());
			if (m3_WLDE.HasValue)
				request.WithQueryParameter("WLDE", m3_WLDE.Value.ToString());
			if (m3_SEPR.HasValue)
				request.WithQueryParameter("SEPR", m3_SEPR.Value.ToString());
			if (m3_PIPR.HasValue)
				request.WithQueryParameter("PIPR", m3_PIPR.Value.ToString());
			if (m3_DOWT.HasValue)
				request.WithQueryParameter("DOWT", m3_DOWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_IORN))
				request.WithQueryParameter("IORN", m3_IORN.Trim());
			if (m3_IORL.HasValue)
				request.WithQueryParameter("IORL", m3_IORL.Value.ToString());
			if (m3_ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3_ORQT.Value.ToString());

			// Execute the request
			var result = await Execute<AddOpResponse>(
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
		/// Name AddOp2
		/// Description Add OEM for operation to existing work order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_SMC0">User defined field 1</param>
		/// <param name="m3_SMC1">User defined field 2</param>
		/// <param name="m3_SMC2">User defined field 3</param>
		/// <param name="m3_SMC3">User defined field 4</param>
		/// <param name="m3_SMC4">User defined field 5</param>
		/// <param name="m3_SMC5">User defined field 6</param>
		/// <param name="m3_SMC6">User defined field 7</param>
		/// <param name="m3_SMC7">User defined field 8</param>
		/// <param name="m3_SMC8">User defined field 9</param>
		/// <param name="m3_SMC9">User defined field 10</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddOp2(
			string m3_MWNO, 
			int m3_OPNO, 
			string m3_SMC0 = null, 
			string m3_SMC1 = null, 
			string m3_SMC2 = null, 
			string m3_SMC3 = null, 
			string m3_SMC4 = null, 
			string m3_SMC5 = null, 
			string m3_SMC6 = null, 
			string m3_SMC7 = null, 
			string m3_SMC8 = null, 
			string m3_SMC9 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddOp2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SMC0))
				request.WithQueryParameter("SMC0", m3_SMC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC1))
				request.WithQueryParameter("SMC1", m3_SMC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC2))
				request.WithQueryParameter("SMC2", m3_SMC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC3))
				request.WithQueryParameter("SMC3", m3_SMC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC4))
				request.WithQueryParameter("SMC4", m3_SMC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC5))
				request.WithQueryParameter("SMC5", m3_SMC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC6))
				request.WithQueryParameter("SMC6", m3_SMC6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC7))
				request.WithQueryParameter("SMC7", m3_SMC7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC8))
				request.WithQueryParameter("SMC8", m3_SMC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC9))
				request.WithQueryParameter("SMC9", m3_SMC9.Trim());

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
		/// Name ChgMtrl
		/// Description Change material to existing work order
		/// Version Release: 5eaF
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_DWNO">Drawing number</param>
		/// <param name="m3_MTNO">Component number</param>
		/// <param name="m3_FMT1">Text</param>
		/// <param name="m3_FMT2">Technical reference</param>
		/// <param name="m3_CNQT">Quantity</param>
		/// <param name="m3_PEUN">Product engineering U/M</param>
		/// <param name="m3_LGTH">Length</param>
		/// <param name="m3_WDTH">Width</param>
		/// <param name="m3_LWF1">Factor 1</param>
		/// <param name="m3_LWF2">Factor 2</param>
		/// <param name="m3_RDAT">Reservation date</param>
		/// <param name="m3_TIHM">Time hours & minutes</param>
		/// <param name="m3_MDBF">Lead time offset</param>
		/// <param name="m3_MPRC">Component price</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_PRDY">Production days</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_STGS">Subcontract control</param>
		/// <param name="m3_SPMT">Issue method</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_DWPO">Drawing position</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_WMST">Material status</param>
		/// <param name="m3_NORD">Additional days - material reservation</param>
		/// <param name="m3_RTHI">Reservation time - material</param>
		/// <param name="m3_ADRR">Address file</param>
		/// <param name="m3_ADRT">Address type</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_PRMO">Price origin</param>
		/// <param name="m3_WATP">Warranty type</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_PYAG">Payer agreement</param>
		/// <param name="m3_MAUP">Manually updated</param>
		/// <param name="m3_ACWA">Claim warranty</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_OT53">Abnormal demand</param>
		/// <param name="m3_FWHS">Firm warehouse</param>
		/// <param name="m3_FXCD">Quantity Relation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgMtrl(
			string m3_MWNO, 
			int? m3_OPNO = null, 
			int? m3_MSEQ = null, 
			string m3_DWNO = null, 
			string m3_MTNO = null, 
			string m3_FMT1 = null, 
			string m3_FMT2 = null, 
			decimal? m3_CNQT = null, 
			string m3_PEUN = null, 
			int? m3_LGTH = null, 
			int? m3_WDTH = null, 
			decimal? m3_LWF1 = null, 
			decimal? m3_LWF2 = null, 
			DateTime? m3_RDAT = null, 
			int? m3_TIHM = null, 
			int? m3_MDBF = null, 
			decimal? m3_MPRC = null, 
			string m3_WHSL = null, 
			string m3_TWSL = null, 
			string m3_BANO = null, 
			string m3_SUNO = null, 
			int? m3_PRDY = null, 
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			decimal? m3_ATNR = null, 
			int? m3_STGS = null, 
			int? m3_SPMT = null, 
			string m3_RSCD = null, 
			string m3_DWPO = null, 
			decimal? m3_TXID = null, 
			string m3_WMST = null, 
			string m3_NORD = null, 
			int? m3_RTHI = null, 
			int? m3_ADRR = null, 
			int? m3_ADRT = null, 
			string m3_ADID = null, 
			string m3_PRMO = null, 
			string m3_WATP = null, 
			string m3_PYNO = null, 
			string m3_PYAG = null, 
			int? m3_MAUP = null, 
			int? m3_ACWA = null, 
			decimal? m3_SAPR = null, 
			int? m3_OT53 = null, 
			int? m3_FWHS = null, 
			int? m3_FXCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgMtrl",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DWNO))
				request.WithQueryParameter("DWNO", m3_DWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTNO))
				request.WithQueryParameter("MTNO", m3_MTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMT1))
				request.WithQueryParameter("FMT1", m3_FMT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMT2))
				request.WithQueryParameter("FMT2", m3_FMT2.Trim());
			if (m3_CNQT.HasValue)
				request.WithQueryParameter("CNQT", m3_CNQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PEUN))
				request.WithQueryParameter("PEUN", m3_PEUN.Trim());
			if (m3_LGTH.HasValue)
				request.WithQueryParameter("LGTH", m3_LGTH.Value.ToString());
			if (m3_WDTH.HasValue)
				request.WithQueryParameter("WDTH", m3_WDTH.Value.ToString());
			if (m3_LWF1.HasValue)
				request.WithQueryParameter("LWF1", m3_LWF1.Value.ToString());
			if (m3_LWF2.HasValue)
				request.WithQueryParameter("LWF2", m3_LWF2.Value.ToString());
			if (m3_RDAT.HasValue)
				request.WithQueryParameter("RDAT", m3_RDAT.Value.ToM3String());
			if (m3_TIHM.HasValue)
				request.WithQueryParameter("TIHM", m3_TIHM.Value.ToString());
			if (m3_MDBF.HasValue)
				request.WithQueryParameter("MDBF", m3_MDBF.Value.ToString());
			if (m3_MPRC.HasValue)
				request.WithQueryParameter("MPRC", m3_MPRC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_PRDY.HasValue)
				request.WithQueryParameter("PRDY", m3_PRDY.Value.ToString());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (m3_STGS.HasValue)
				request.WithQueryParameter("STGS", m3_STGS.Value.ToString());
			if (m3_SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3_SPMT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DWPO))
				request.WithQueryParameter("DWPO", m3_DWPO.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WMST))
				request.WithQueryParameter("WMST", m3_WMST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NORD))
				request.WithQueryParameter("NORD", m3_NORD.Trim());
			if (m3_RTHI.HasValue)
				request.WithQueryParameter("RTHI", m3_RTHI.Value.ToString());
			if (m3_ADRR.HasValue)
				request.WithQueryParameter("ADRR", m3_ADRR.Value.ToString());
			if (m3_ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3_ADRT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRMO))
				request.WithQueryParameter("PRMO", m3_PRMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WATP))
				request.WithQueryParameter("WATP", m3_WATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYAG))
				request.WithQueryParameter("PYAG", m3_PYAG.Trim());
			if (m3_MAUP.HasValue)
				request.WithQueryParameter("MAUP", m3_MAUP.Value.ToString());
			if (m3_ACWA.HasValue)
				request.WithQueryParameter("ACWA", m3_ACWA.Value.ToString());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_OT53.HasValue)
				request.WithQueryParameter("OT53", m3_OT53.Value.ToString());
			if (m3_FWHS.HasValue)
				request.WithQueryParameter("FWHS", m3_FWHS.Value.ToString());
			if (m3_FXCD.HasValue)
				request.WithQueryParameter("FXCD", m3_FXCD.Value.ToString());

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
		/// Name ChgOp
		/// Description Change existing operation
		/// Version Release: 5eaD
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_OPDS">Operation description</param>
		/// <param name="m3_TXT1">Text line 1</param>
		/// <param name="m3_TXT2">Text line 2</param>
		/// <param name="m3_DOID">Document identity</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_MSTI">Start time</param>
		/// <param name="m3_FIDT">Finish date</param>
		/// <param name="m3_MFTI">Finish time</param>
		/// <param name="m3_LASK">Labor skill</param>
		/// <param name="m3_FXTI">Fixed time</param>
		/// <param name="m3_SETI">Setup time</param>
		/// <param name="m3_OSET">External setup time</param>
		/// <param name="m3_PITI">Run time</param>
		/// <param name="m3_SENP">Planned number of workers - setup</param>
		/// <param name="m3_PRNP">Planned number of workers - run time</param>
		/// <param name="m3_PRNM">Planned number of machines</param>
		/// <param name="m3_TOOL">Tool number</param>
		/// <param name="m3_CAMP">Number of labor tickets</param>
		/// <param name="m3_QUDY">Queue days</param>
		/// <param name="m3_SLAC">Transport value in days</param>
		/// <param name="m3_ODBF">Lead time offset</param>
		/// <param name="m3_PRDY">Production days</param>
		/// <param name="m3_SWQT">Setup scrap</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_PSSQ">Co-sorting key</param>
		/// <param name="m3_SCHN">Schedule number</param>
		/// <param name="m3_SCHS">Schedule number sequence</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_EQNO">Equipment number</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_SPRQ">Specific requirement category</param>
		/// <param name="m3_SPRT">Specific requirements</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_DLY1">Delay time 1</param>
		/// <param name="m3_DLY2">Delay time 2</param>
		/// <param name="m3_FCLA">Error code 1</param>
		/// <param name="m3_FCL2">Error code 2</param>
		/// <param name="m3_FCL3">Error code 3</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_DPLG">Deviating work center</param>
		/// <param name="m3_WLDE">Infinite/finite</param>
		/// <param name="m3_SEPR">Setup price</param>
		/// <param name="m3_PIPR">Unit price</param>
		/// <param name="m3_DOWT">Downtime</param>
		/// <param name="m3_MAUP">Manually updated</param>
		/// <param name="m3_PRMO">Price origin</param>
		/// <param name="m3_WATP">Warranty type</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_PYAG">Payer agreement</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_ORQT">Ordered quantity - basic U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgOp(
			string m3_MWNO, 
			int m3_OPNO, 
			string m3_PLGR = null, 
			string m3_OPDS = null, 
			string m3_TXT1 = null, 
			string m3_TXT2 = null, 
			string m3_DOID = null, 
			DateTime? m3_STDT = null, 
			int? m3_MSTI = null, 
			DateTime? m3_FIDT = null, 
			int? m3_MFTI = null, 
			string m3_LASK = null, 
			int? m3_FXTI = null, 
			int? m3_SETI = null, 
			int? m3_OSET = null, 
			int? m3_PITI = null, 
			int? m3_SENP = null, 
			int? m3_PRNP = null, 
			int? m3_PRNM = null, 
			string m3_TOOL = null, 
			int? m3_CAMP = null, 
			int? m3_QUDY = null, 
			decimal? m3_SLAC = null, 
			int? m3_ODBF = null, 
			int? m3_PRDY = null, 
			decimal? m3_SWQT = null, 
			string m3_SUNO = null, 
			string m3_PSSQ = null, 
			decimal? m3_SCHN = null, 
			long? m3_SCHS = null, 
			decimal? m3_TXID = null, 
			string m3_CFGL = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_EQNO = null, 
			string m3_SUFI = null, 
			string m3_SPRQ = null, 
			string m3_SPRT = null, 
			int? m3_RORL = null, 
			int? m3_DLY1 = null, 
			int? m3_DLY2 = null, 
			string m3_FCLA = null, 
			string m3_FCL2 = null, 
			string m3_FCL3 = null, 
			decimal? m3_ATNR = null, 
			string m3_DPLG = null, 
			int? m3_WLDE = null, 
			decimal? m3_SEPR = null, 
			decimal? m3_PIPR = null, 
			int? m3_DOWT = null, 
			int? m3_MAUP = null, 
			string m3_PRMO = null, 
			string m3_WATP = null, 
			string m3_PYNO = null, 
			string m3_PYAG = null, 
			decimal? m3_SAPR = null, 
			decimal? m3_ORQT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgOp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPDS))
				request.WithQueryParameter("OPDS", m3_OPDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT1))
				request.WithQueryParameter("TXT1", m3_TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT2))
				request.WithQueryParameter("TXT2", m3_TXT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_MSTI.HasValue)
				request.WithQueryParameter("MSTI", m3_MSTI.Value.ToString());
			if (m3_FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3_FIDT.Value.ToM3String());
			if (m3_MFTI.HasValue)
				request.WithQueryParameter("MFTI", m3_MFTI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LASK))
				request.WithQueryParameter("LASK", m3_LASK.Trim());
			if (m3_FXTI.HasValue)
				request.WithQueryParameter("FXTI", m3_FXTI.Value.ToString());
			if (m3_SETI.HasValue)
				request.WithQueryParameter("SETI", m3_SETI.Value.ToString());
			if (m3_OSET.HasValue)
				request.WithQueryParameter("OSET", m3_OSET.Value.ToString());
			if (m3_PITI.HasValue)
				request.WithQueryParameter("PITI", m3_PITI.Value.ToString());
			if (m3_SENP.HasValue)
				request.WithQueryParameter("SENP", m3_SENP.Value.ToString());
			if (m3_PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3_PRNP.Value.ToString());
			if (m3_PRNM.HasValue)
				request.WithQueryParameter("PRNM", m3_PRNM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TOOL))
				request.WithQueryParameter("TOOL", m3_TOOL.Trim());
			if (m3_CAMP.HasValue)
				request.WithQueryParameter("CAMP", m3_CAMP.Value.ToString());
			if (m3_QUDY.HasValue)
				request.WithQueryParameter("QUDY", m3_QUDY.Value.ToString());
			if (m3_SLAC.HasValue)
				request.WithQueryParameter("SLAC", m3_SLAC.Value.ToString());
			if (m3_ODBF.HasValue)
				request.WithQueryParameter("ODBF", m3_ODBF.Value.ToString());
			if (m3_PRDY.HasValue)
				request.WithQueryParameter("PRDY", m3_PRDY.Value.ToString());
			if (m3_SWQT.HasValue)
				request.WithQueryParameter("SWQT", m3_SWQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PSSQ))
				request.WithQueryParameter("PSSQ", m3_PSSQ.Trim());
			if (m3_SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3_SCHN.Value.ToString());
			if (m3_SCHS.HasValue)
				request.WithQueryParameter("SCHS", m3_SCHS.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQNO))
				request.WithQueryParameter("EQNO", m3_EQNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPRQ))
				request.WithQueryParameter("SPRQ", m3_SPRQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPRT))
				request.WithQueryParameter("SPRT", m3_SPRT.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_DLY1.HasValue)
				request.WithQueryParameter("DLY1", m3_DLY1.Value.ToString());
			if (m3_DLY2.HasValue)
				request.WithQueryParameter("DLY2", m3_DLY2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FCLA))
				request.WithQueryParameter("FCLA", m3_FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL2))
				request.WithQueryParameter("FCL2", m3_FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL3))
				request.WithQueryParameter("FCL3", m3_FCL3.Trim());
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DPLG))
				request.WithQueryParameter("DPLG", m3_DPLG.Trim());
			if (m3_WLDE.HasValue)
				request.WithQueryParameter("WLDE", m3_WLDE.Value.ToString());
			if (m3_SEPR.HasValue)
				request.WithQueryParameter("SEPR", m3_SEPR.Value.ToString());
			if (m3_PIPR.HasValue)
				request.WithQueryParameter("PIPR", m3_PIPR.Value.ToString());
			if (m3_DOWT.HasValue)
				request.WithQueryParameter("DOWT", m3_DOWT.Value.ToString());
			if (m3_MAUP.HasValue)
				request.WithQueryParameter("MAUP", m3_MAUP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRMO))
				request.WithQueryParameter("PRMO", m3_PRMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WATP))
				request.WithQueryParameter("WATP", m3_WATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYAG))
				request.WithQueryParameter("PYAG", m3_PYAG.Trim());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3_ORQT.Value.ToString());

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
		/// Name ChgOp2
		/// Description Change existing OEM for operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_SMC0">User defined field 1</param>
		/// <param name="m3_SMC1">User defined field 2</param>
		/// <param name="m3_SMC2">User defined field 3</param>
		/// <param name="m3_SMC3">User defined field 4</param>
		/// <param name="m3_SMC4">User defined field 5</param>
		/// <param name="m3_SMC5">User defined field 6</param>
		/// <param name="m3_SMC6">User defined field 7</param>
		/// <param name="m3_SMC7">User defined field 8</param>
		/// <param name="m3_SMC8">User defined field 9</param>
		/// <param name="m3_SMC9">User defined field 10</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgOp2(
			string m3_MWNO, 
			int m3_OPNO, 
			string m3_SMC0 = null, 
			string m3_SMC1 = null, 
			string m3_SMC2 = null, 
			string m3_SMC3 = null, 
			string m3_SMC4 = null, 
			string m3_SMC5 = null, 
			string m3_SMC6 = null, 
			string m3_SMC7 = null, 
			string m3_SMC8 = null, 
			string m3_SMC9 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgOp2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SMC0))
				request.WithQueryParameter("SMC0", m3_SMC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC1))
				request.WithQueryParameter("SMC1", m3_SMC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC2))
				request.WithQueryParameter("SMC2", m3_SMC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC3))
				request.WithQueryParameter("SMC3", m3_SMC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC4))
				request.WithQueryParameter("SMC4", m3_SMC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC5))
				request.WithQueryParameter("SMC5", m3_SMC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC6))
				request.WithQueryParameter("SMC6", m3_SMC6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC7))
				request.WithQueryParameter("SMC7", m3_SMC7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC8))
				request.WithQueryParameter("SMC8", m3_SMC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC9))
				request.WithQueryParameter("SMC9", m3_SMC9.Trim());

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
		/// Name ChgPrio
		/// Description Change priority and shutdown
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_PRIO">Priority (Required)</param>
		/// <param name="m3_NSTP">Shutdown</param>
		/// <param name="m3_RREQ">Requester</param>
		/// <param name="m3_APRB">Approved by</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_EVTY">Event type</param>
		/// <param name="m3_TXT1">Text line 1</param>
		/// <param name="m3_TXT2">Text line 2</param>
		/// <param name="m3_EDWT">Estimated downtime</param>
		/// <param name="m3_ESBU">Estimated cost</param>
		/// <param name="m3_RRSD">Requested start date</param>
		/// <param name="m3_RRST">Requested start time</param>
		/// <param name="m3_RRFD">Requested finish date</param>
		/// <param name="m3_RRFT">Requested finish time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ChgPrioResponse></returns>
		/// <exception cref="M3Exception<ChgPrioResponse>"></exception>
		public async Task<M3Response<ChgPrioResponse>> ChgPrio(
			string m3_MWNO, 
			int m3_PRIO, 
			int? m3_NSTP = null, 
			string m3_RREQ = null, 
			string m3_APRB = null, 
			string m3_RESP = null, 
			string m3_EVTY = null, 
			string m3_TXT1 = null, 
			string m3_TXT2 = null, 
			int? m3_EDWT = null, 
			decimal? m3_ESBU = null, 
			DateTime? m3_RRSD = null, 
			int? m3_RRST = null, 
			DateTime? m3_RRFD = null, 
			int? m3_RRFT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgPrio",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("PRIO", m3_PRIO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_NSTP.HasValue)
				request.WithQueryParameter("NSTP", m3_NSTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RREQ))
				request.WithQueryParameter("RREQ", m3_RREQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APRB))
				request.WithQueryParameter("APRB", m3_APRB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVTY))
				request.WithQueryParameter("EVTY", m3_EVTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT1))
				request.WithQueryParameter("TXT1", m3_TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT2))
				request.WithQueryParameter("TXT2", m3_TXT2.Trim());
			if (m3_EDWT.HasValue)
				request.WithQueryParameter("EDWT", m3_EDWT.Value.ToString());
			if (m3_ESBU.HasValue)
				request.WithQueryParameter("ESBU", m3_ESBU.Value.ToString());
			if (m3_RRSD.HasValue)
				request.WithQueryParameter("RRSD", m3_RRSD.Value.ToM3String());
			if (m3_RRST.HasValue)
				request.WithQueryParameter("RRST", m3_RRST.Value.ToString());
			if (m3_RRFD.HasValue)
				request.WithQueryParameter("RRFD", m3_RRFD.Value.ToM3String());
			if (m3_RRFT.HasValue)
				request.WithQueryParameter("RRFT", m3_RRFT.Value.ToString());

			// Execute the request
			var result = await Execute<ChgPrioResponse>(
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
		/// Name ClrInboxes
		/// Description Delete all records in user's in-box
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ClrInboxes(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ClrInboxes",
			};

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
		/// Name DelMtrl
		/// Description Delete Material
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_MSEQ">Sequence number (Required)</param>
		/// <param name="m3_MTNO">Component number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelMtrl(
			string m3_MWNO, 
			int m3_MSEQ, 
			string m3_MTNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelMtrl",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("MSEQ", m3_MSEQ.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MTNO))
				request.WithQueryParameter("MTNO", m3_MTNO.Trim());

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
		/// Name DelNetwork
		/// Description Delete network
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_MWNO">Work order number</param>
		/// <param name="m3_SPMO">Supplying WO</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelNetwork(
			string m3_FACI = null, 
			int? m3_RORC = null, 
			string m3_RORN = null, 
			string m3_MWNO = null, 
			string m3_SPMO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelNetwork",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MWNO))
				request.WithQueryParameter("MWNO", m3_MWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPMO))
				request.WithQueryParameter("SPMO", m3_SPMO.Trim());

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
		/// Name DelOp
		/// Description Delete Operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelOp(
			string m3_MWNO, 
			int m3_OPNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelOp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString());

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
		/// Description Get one maintenance order
		/// Version Release: 5eaF
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_MFNO, 
			int? m3_CONO = null, 
			string m3_REAR = null, 
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
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_MFNO))
				throw new ArgumentNullException("m3_MFNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("MFNO", m3_MFNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());

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
		/// Name GetMtrl
		/// Description Get Material
		/// Version Release: 5eaF
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_MSEQ">Sequence number (Required)</param>
		/// <param name="m3_RCOS">Retrive cost</param>
		/// <param name="m3_RPRI">Yes/no</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMtrlResponse></returns>
		/// <exception cref="M3Exception<GetMtrlResponse>"></exception>
		public async Task<M3Response<GetMtrlResponse>> GetMtrl(
			string m3_MWNO, 
			int m3_MSEQ, 
			int? m3_RCOS = null, 
			int? m3_RPRI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMtrl",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("MSEQ", m3_MSEQ.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RCOS.HasValue)
				request.WithQueryParameter("RCOS", m3_RCOS.Value.ToString());
			if (m3_RPRI.HasValue)
				request.WithQueryParameter("RPRI", m3_RPRI.Value.ToString());

			// Execute the request
			var result = await Execute<GetMtrlResponse>(
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
		/// Name GetMtrl2
		/// Description Get Material
		/// Version Release: 5eaF
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_MSEQ">Sequence number (Required)</param>
		/// <param name="m3_RCOS">Retrive cost</param>
		/// <param name="m3_RPRI">Yes/no</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMtrl2Response></returns>
		/// <exception cref="M3Exception<GetMtrl2Response>"></exception>
		public async Task<M3Response<GetMtrl2Response>> GetMtrl2(
			string m3_MWNO, 
			int m3_MSEQ, 
			int? m3_RCOS = null, 
			int? m3_RPRI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMtrl2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("MSEQ", m3_MSEQ.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RCOS.HasValue)
				request.WithQueryParameter("RCOS", m3_RCOS.Value.ToString());
			if (m3_RPRI.HasValue)
				request.WithQueryParameter("RPRI", m3_RPRI.Value.ToString());

			// Execute the request
			var result = await Execute<GetMtrl2Response>(
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
		/// Name GetOp
		/// Description Get Operation
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_RCOS">Retrive estimated cost</param>
		/// <param name="m3_RPRI">Yes/no</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOpResponse></returns>
		/// <exception cref="M3Exception<GetOpResponse>"></exception>
		public async Task<M3Response<GetOpResponse>> GetOp(
			string m3_MWNO, 
			int m3_OPNO, 
			int? m3_RCOS = null, 
			int? m3_RPRI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetOp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RCOS.HasValue)
				request.WithQueryParameter("RCOS", m3_RCOS.Value.ToString());
			if (m3_RPRI.HasValue)
				request.WithQueryParameter("RPRI", m3_RPRI.Value.ToString());

			// Execute the request
			var result = await Execute<GetOpResponse>(
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
		/// Name GetOp2
		/// Description Get OEM for Operation
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_RCOS">Retrive estimated cost</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOp2Response></returns>
		/// <exception cref="M3Exception<GetOp2Response>"></exception>
		public async Task<M3Response<GetOp2Response>> GetOp2(
			string m3_MWNO, 
			int m3_OPNO, 
			int? m3_RCOS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetOp2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RCOS.HasValue)
				request.WithQueryParameter("RCOS", m3_RCOS.Value.ToString());

			// Execute the request
			var result = await Execute<GetOp2Response>(
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
		/// Name GetUserJobSts
		/// Description Get update status per user
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetUserJobStsResponse></returns>
		/// <exception cref="M3Exception<GetUserJobStsResponse>"></exception>
		public async Task<M3Response<GetUserJobStsResponse>> GetUserJobSts(
			int? m3_CONO = null, 
			string m3_STAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetUserJobSts",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());

			// Execute the request
			var result = await Execute<GetUserJobStsResponse>(
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
		/// Name GetWoAddress
		/// Description Get the dilivery address
		/// Version Release: 15
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetWoAddressResponse></returns>
		/// <exception cref="M3Exception<GetWoAddressResponse>"></exception>
		public async Task<M3Response<GetWoAddressResponse>> GetWoAddress(
			string m3_MWNO, 
			int? m3_MSEQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetWoAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());

			// Execute the request
			var result = await Execute<GetWoAddressResponse>(
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
		/// Name LstReportByLine
		/// Description List reporting nbr by material line
		/// Version Release: 5eaC
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_MSEQ">Sequence number (Required)</param>
		/// <param name="m3_RPQT">Reported quantity</param>
		/// <param name="m3_OEND">Flagged as completed</param>
		/// <param name="m3_MTNO">Component number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstReportByLineResponse></returns>
		/// <exception cref="M3Exception<LstReportByLineResponse>"></exception>
		public async Task<M3Response<LstReportByLineResponse>> LstReportByLine(
			string m3_MWNO, 
			int m3_MSEQ, 
			decimal? m3_RPQT = null, 
			int? m3_OEND = null, 
			string m3_MTNO = null, 
			string m3_BANO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstReportByLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("MSEQ", m3_MSEQ.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RPQT.HasValue)
				request.WithQueryParameter("RPQT", m3_RPQT.Value.ToString());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MTNO))
				request.WithQueryParameter("MTNO", m3_MTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());

			// Execute the request
			var result = await Execute<LstReportByLineResponse>(
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
		/// Name ReportUsedMtrl
		/// Description ReportUsedMtrl
		/// Version Release: 5eaC
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_MSEQ">Sequence number (Required)</param>
		/// <param name="m3_RPQT">Reported quantity</param>
		/// <param name="m3_OEND">Flagged as completed</param>
		/// <param name="m3_MTNO">Component number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ReportUsedMtrl(
			string m3_MWNO, 
			int m3_MSEQ, 
			decimal? m3_RPQT = null, 
			int? m3_OEND = null, 
			string m3_MTNO = null, 
			string m3_BANO = null, 
			string m3_WHSL = null, 
			string m3_CAMU = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ReportUsedMtrl",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("MSEQ", m3_MSEQ.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RPQT.HasValue)
				request.WithQueryParameter("RPQT", m3_RPQT.Value.ToString());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MTNO))
				request.WithQueryParameter("MTNO", m3_MTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());

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
		/// Name SearchOpno
		/// Description Search Operations
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_SQRY">New field description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchOpnoResponse></returns>
		/// <exception cref="M3Exception<SearchOpnoResponse>"></exception>
		public async Task<M3Response<SearchOpnoResponse>> SearchOpno(
			string m3_SQRY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchOpno",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SQRY))
				request.WithQueryParameter("SQRY", m3_SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchOpnoResponse>(
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
		/// Name SearchWo
		/// Description Search Work order
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_SQRY">New field description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchWoResponse></returns>
		/// <exception cref="M3Exception<SearchWoResponse>"></exception>
		public async Task<M3Response<SearchWoResponse>> SearchWo(
			string m3_SQRY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchWo",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SQRY))
				request.WithQueryParameter("SQRY", m3_SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchWoResponse>(
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
		/// Name SelErrOrders
		/// Description Selection of orders not correctly updated
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelErrOrdersResponse></returns>
		/// <exception cref="M3Exception<SelErrOrdersResponse>"></exception>
		public async Task<M3Response<SelErrOrdersResponse>> SelErrOrders(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelErrOrders",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<SelErrOrdersResponse>(
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
		/// Name SelMaterials
		/// Description Selection of maintenance order materials
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_MFNO">Manufacturing order number</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_NETW">Net work planning (0/1)</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_CLOS">Yes/no</param>
		/// <param name="m3_APIP">APS - policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelMaterialsResponse></returns>
		/// <exception cref="M3Exception<SelMaterialsResponse>"></exception>
		public async Task<M3Response<SelMaterialsResponse>> SelMaterials(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_MFNO = null, 
			string m3_WHGR = null, 
			int? m3_NETW = null, 
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_CLOS = null, 
			string m3_APIP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelMaterials",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MFNO))
				request.WithQueryParameter("MFNO", m3_MFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (m3_NETW.HasValue)
				request.WithQueryParameter("NETW", m3_NETW.Value.ToString());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_CLOS.HasValue)
				request.WithQueryParameter("CLOS", m3_CLOS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());

			// Execute the request
			var result = await Execute<SelMaterialsResponse>(
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
		/// Name SelOperations
		/// Description Selection of operations
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_MFNO">Manufacturing order number</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_CLFI">Select closed operations first</param>
		/// <param name="m3_CPRI">Create Primary operation</param>
		/// <param name="m3_SKIL">Skill</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelOperationsResponse></returns>
		/// <exception cref="M3Exception<SelOperationsResponse>"></exception>
		public async Task<M3Response<SelOperationsResponse>> SelOperations(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_MFNO = null, 
			string m3_REAR = null, 
			string m3_WHGR = null, 
			string m3_CLFI = null, 
			string m3_CPRI = null, 
			string m3_SKIL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelOperations",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MFNO))
				request.WithQueryParameter("MFNO", m3_MFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CLFI))
				request.WithQueryParameter("CLFI", m3_CLFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CPRI))
				request.WithQueryParameter("CPRI", m3_CPRI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SKIL))
				request.WithQueryParameter("SKIL", m3_SKIL.Trim());

			// Execute the request
			var result = await Execute<SelOperationsResponse>(
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
		/// Name SelTools
		/// Description Selection of maintenance order materials
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_MFNO">Manufacturing order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelToolsResponse></returns>
		/// <exception cref="M3Exception<SelToolsResponse>"></exception>
		public async Task<M3Response<SelToolsResponse>> SelTools(
			string m3_FACI, 
			int? m3_CONO = null, 
			string m3_PRNO = null, 
			string m3_MFNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelTools",
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
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MFNO))
				request.WithQueryParameter("MFNO", m3_MFNO.Trim());

			// Execute the request
			var result = await Execute<SelToolsResponse>(
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
		/// Description Selection of maintenance orders
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_STSF">From status (Required)</param>
		/// <param name="m3_STST">To status (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACF">From facility</param>
		/// <param name="m3_FACT">To facility</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_DATE">Timestamp - Date</param>
		/// <param name="m3_TIME">Timestamp - Time</param>
		/// <param name="m3_SCHH">Scheduling horizon</param>
		/// <param name="m3_FWHS">From warehouse</param>
		/// <param name="m3_TWHS">To warehouse</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_APIP">APS - policy</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_STRT">Structure type</param>
		/// <param name="m3_SECL">Service Classification</param>
		/// <param name="m3_LMDT">Change date from</param>
		/// <param name="m3_TLMDT">Change date to</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectResponse></returns>
		/// <exception cref="M3Exception<SelectResponse>"></exception>
		public async Task<M3Response<SelectResponse>> Select(
			int m3_STSF, 
			int m3_STST, 
			int? m3_CONO = null, 
			string m3_FACF = null, 
			string m3_FACT = null, 
			string m3_REAR = null, 
			DateTime? m3_DATE = null, 
			int? m3_TIME = null, 
			int? m3_SCHH = null, 
			string m3_FWHS = null, 
			string m3_TWHS = null, 
			string m3_WHGR = null, 
			string m3_APIP = null, 
			string m3_SUFI = null, 
			string m3_STRT = null, 
			int? m3_SECL = null, 
			DateTime? m3_LMDT = null, 
			DateTime? m3_TLMDT = null, 
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

			// Set mandatory parameters
			request
				.WithQueryParameter("STSF", m3_STSF.ToString())
				.WithQueryParameter("STST", m3_STST.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACF))
				request.WithQueryParameter("FACF", m3_FACF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACT))
				request.WithQueryParameter("FACT", m3_FACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (m3_DATE.HasValue)
				request.WithQueryParameter("DATE", m3_DATE.Value.ToM3String());
			if (m3_TIME.HasValue)
				request.WithQueryParameter("TIME", m3_TIME.Value.ToString());
			if (m3_SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3_SCHH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FWHS))
				request.WithQueryParameter("FWHS", m3_FWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWHS))
				request.WithQueryParameter("TWHS", m3_TWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_SECL.HasValue)
				request.WithQueryParameter("SECL", m3_SECL.Value.ToString());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());
			if (m3_TLMDT.HasValue)
				request.WithQueryParameter("TLMDT", m3_TLMDT.Value.ToM3String());

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
		/// Name SetUserJobSts
		/// Description Set update status per user
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_STAT">Status (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetUserJobSts(
			string m3_STAT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SetUserJobSts",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STAT))
				throw new ArgumentNullException("m3_STAT");

			// Set mandatory parameters
			request
				.WithQueryParameter("STAT", m3_STAT.Trim());

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
		/// Name SndInboxOp
		/// Description Send record to operations in-box
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3_RPCD">Released/planned code (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_MSTI">Start time (Required)</param>
		/// <param name="m3_FIDT">Finish date (Required)</param>
		/// <param name="m3_MFTI">Finish time (Required)</param>
		/// <param name="m3_PLGR">Finite scheduled resource (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PLG1">APP work center</param>
		/// <param name="m3_PLGF">Forced resource</param>
		/// <param name="m3_NXOP">Next operation</param>
		/// <param name="m3_APON">Primary operation number</param>
		/// <param name="m3_POOC">Parallel operation overlap code</param>
		/// <param name="m3_SLAT">Transit U/M / Overlap's code</param>
		/// <param name="m3_RESR">Resource restriction</param>
		/// <param name="m3_SPLK">Split code operation</param>
		/// <param name="m3_SPLN">Number of operations after split</param>
		/// <param name="m3_SPSZ">Split quatinty</param>
		/// <param name="m3_FRCD">Forced start date</param>
		/// <param name="m3_FRCT">Forced start time</param>
		/// <param name="m3_SEQS">Sequencing status</param>
		/// <param name="m3_PRAP">APP processed</param>
		/// <param name="m3_SPLT">Change code</param>
		/// <param name="m3_CHNO">Change number</param>
		/// <param name="m3_WLDE">Infinite/finite</param>
		/// <param name="m3_PLNR">Planned number of resources</param>
		/// <param name="m3_SETI">Setup time</param>
		/// <param name="m3_ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3_SCHN">Schedule number</param>
		/// <param name="m3_SCHS">Sequence number within schedule</param>
		/// <param name="m3_RRSD">Requested start date</param>
		/// <param name="m3_RRST">Requested start time</param>
		/// <param name="m3_RRFD">Requested finish date</param>
		/// <param name="m3_RRFT">Requested finish time</param>
		/// <param name="m3_RBUP">Remaining buffer percent</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndInboxOp(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_MFNO, 
			string m3_RPCD, 
			int m3_OPNO, 
			DateTime m3_STDT, 
			int m3_MSTI, 
			DateTime m3_FIDT, 
			int m3_MFTI, 
			string m3_PLGR, 
			int? m3_CONO = null, 
			string m3_PLG1 = null, 
			string m3_PLGF = null, 
			int? m3_NXOP = null, 
			int? m3_APON = null, 
			int? m3_POOC = null, 
			string m3_SLAT = null, 
			string m3_RESR = null, 
			int? m3_SPLK = null, 
			int? m3_SPLN = null, 
			decimal? m3_SPSZ = null, 
			DateTime? m3_FRCD = null, 
			int? m3_FRCT = null, 
			int? m3_SEQS = null, 
			string m3_PRAP = null, 
			int? m3_SPLT = null, 
			int? m3_CHNO = null, 
			int? m3_WLDE = null, 
			string m3_PLNR = null, 
			int? m3_SETI = null, 
			decimal? m3_ORQT = null, 
			int? m3_SCHN = null, 
			long? m3_SCHS = null, 
			DateTime? m3_RRSD = null, 
			int? m3_RRST = null, 
			DateTime? m3_RRFD = null, 
			int? m3_RRFT = null, 
			int? m3_RBUP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndInboxOp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_MFNO))
				throw new ArgumentNullException("m3_MFNO");
			if (string.IsNullOrWhiteSpace(m3_RPCD))
				throw new ArgumentNullException("m3_RPCD");
			if (string.IsNullOrWhiteSpace(m3_PLGR))
				throw new ArgumentNullException("m3_PLGR");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("MFNO", m3_MFNO.Trim())
				.WithQueryParameter("RPCD", m3_RPCD.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("MSTI", m3_MSTI.ToString())
				.WithQueryParameter("FIDT", m3_FIDT.ToM3String())
				.WithQueryParameter("MFTI", m3_MFTI.ToString())
				.WithQueryParameter("PLGR", m3_PLGR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLG1))
				request.WithQueryParameter("PLG1", m3_PLG1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGF))
				request.WithQueryParameter("PLGF", m3_PLGF.Trim());
			if (m3_NXOP.HasValue)
				request.WithQueryParameter("NXOP", m3_NXOP.Value.ToString());
			if (m3_APON.HasValue)
				request.WithQueryParameter("APON", m3_APON.Value.ToString());
			if (m3_POOC.HasValue)
				request.WithQueryParameter("POOC", m3_POOC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SLAT))
				request.WithQueryParameter("SLAT", m3_SLAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESR))
				request.WithQueryParameter("RESR", m3_RESR.Trim());
			if (m3_SPLK.HasValue)
				request.WithQueryParameter("SPLK", m3_SPLK.Value.ToString());
			if (m3_SPLN.HasValue)
				request.WithQueryParameter("SPLN", m3_SPLN.Value.ToString());
			if (m3_SPSZ.HasValue)
				request.WithQueryParameter("SPSZ", m3_SPSZ.Value.ToString());
			if (m3_FRCD.HasValue)
				request.WithQueryParameter("FRCD", m3_FRCD.Value.ToM3String());
			if (m3_FRCT.HasValue)
				request.WithQueryParameter("FRCT", m3_FRCT.Value.ToString());
			if (m3_SEQS.HasValue)
				request.WithQueryParameter("SEQS", m3_SEQS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRAP))
				request.WithQueryParameter("PRAP", m3_PRAP.Trim());
			if (m3_SPLT.HasValue)
				request.WithQueryParameter("SPLT", m3_SPLT.Value.ToString());
			if (m3_CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3_CHNO.Value.ToString());
			if (m3_WLDE.HasValue)
				request.WithQueryParameter("WLDE", m3_WLDE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLNR))
				request.WithQueryParameter("PLNR", m3_PLNR.Trim());
			if (m3_SETI.HasValue)
				request.WithQueryParameter("SETI", m3_SETI.Value.ToString());
			if (m3_ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3_ORQT.Value.ToString());
			if (m3_SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3_SCHN.Value.ToString());
			if (m3_SCHS.HasValue)
				request.WithQueryParameter("SCHS", m3_SCHS.Value.ToString());
			if (m3_RRSD.HasValue)
				request.WithQueryParameter("RRSD", m3_RRSD.Value.ToM3String());
			if (m3_RRST.HasValue)
				request.WithQueryParameter("RRST", m3_RRST.Value.ToString());
			if (m3_RRFD.HasValue)
				request.WithQueryParameter("RRFD", m3_RRFD.Value.ToM3String());
			if (m3_RRFT.HasValue)
				request.WithQueryParameter("RRFT", m3_RRFT.Value.ToString());
			if (m3_RBUP.HasValue)
				request.WithQueryParameter("RBUP", m3_RBUP.Value.ToString());

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
		/// Name SndInboxOrder
		/// Description Send record to order in-box
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3_RPCD">Released/planned code (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_MSTI">Start time (Required)</param>
		/// <param name="m3_FIDT">Finish date (Required)</param>
		/// <param name="m3_MFTI">Finish time (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORQA">Ordered quantity alternate U/M</param>
		/// <param name="m3_ORQT">Ordered quantity basic U/M</param>
		/// <param name="m3_PULD">Pull-up control delayed</param>
		/// <param name="m3_PULN">Pull-up control non-delayed</param>
		/// <param name="m3_AOID">Alternative routing</param>
		/// <param name="m3_CHNO">Change number</param>
		/// <param name="m3_UPDC">Update code</param>
		/// <param name="m3_SUBN">Sub-network mark</param>
		/// <param name="m3_SUBD">Sub-network date</param>
		/// <param name="m3_PRIO">Priority</param>
		/// <param name="m3_NTWP">External network priority</param>
		/// <param name="m3_CLGP">Color group</param>
		/// <param name="m3_PSTS">Status - planned MO</param>
		/// <param name="m3_QADJ">Adjust quantity (yes/no)</param>
		/// <param name="m3_RRSD">Requested start date</param>
		/// <param name="m3_RRST">Requested start time</param>
		/// <param name="m3_RRFD">Requested finish date</param>
		/// <param name="m3_RRFT">Requested finish time</param>
		/// <param name="m3_RREQ">Requester</param>
		/// <param name="m3_RBAM">Request budget amount</param>
		/// <param name="m3_ESBU">Estimated cost</param>
		/// <param name="m3_EDWT">Estimated downtime</param>
		/// <param name="m3_SCHL">Scheduling logic</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndInboxOrder(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_MFNO, 
			string m3_RPCD, 
			DateTime m3_STDT, 
			int m3_MSTI, 
			DateTime m3_FIDT, 
			int m3_MFTI, 
			int? m3_CONO = null, 
			decimal? m3_ORQA = null, 
			decimal? m3_ORQT = null, 
			int? m3_PULD = null, 
			int? m3_PULN = null, 
			string m3_AOID = null, 
			int? m3_CHNO = null, 
			int? m3_UPDC = null, 
			int? m3_SUBN = null, 
			DateTime? m3_SUBD = null, 
			int? m3_PRIO = null, 
			int? m3_NTWP = null, 
			int? m3_CLGP = null, 
			string m3_PSTS = null, 
			int? m3_QADJ = null, 
			DateTime? m3_RRSD = null, 
			int? m3_RRST = null, 
			DateTime? m3_RRFD = null, 
			int? m3_RRFT = null, 
			string m3_RREQ = null, 
			decimal? m3_RBAM = null, 
			decimal? m3_ESBU = null, 
			int? m3_EDWT = null, 
			int? m3_SCHL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndInboxOrder",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_MFNO))
				throw new ArgumentNullException("m3_MFNO");
			if (string.IsNullOrWhiteSpace(m3_RPCD))
				throw new ArgumentNullException("m3_RPCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("MFNO", m3_MFNO.Trim())
				.WithQueryParameter("RPCD", m3_RPCD.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("MSTI", m3_MSTI.ToString())
				.WithQueryParameter("FIDT", m3_FIDT.ToM3String())
				.WithQueryParameter("MFTI", m3_MFTI.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_ORQA.HasValue)
				request.WithQueryParameter("ORQA", m3_ORQA.Value.ToString());
			if (m3_ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3_ORQT.Value.ToString());
			if (m3_PULD.HasValue)
				request.WithQueryParameter("PULD", m3_PULD.Value.ToString());
			if (m3_PULN.HasValue)
				request.WithQueryParameter("PULN", m3_PULN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AOID))
				request.WithQueryParameter("AOID", m3_AOID.Trim());
			if (m3_CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3_CHNO.Value.ToString());
			if (m3_UPDC.HasValue)
				request.WithQueryParameter("UPDC", m3_UPDC.Value.ToString());
			if (m3_SUBN.HasValue)
				request.WithQueryParameter("SUBN", m3_SUBN.Value.ToString());
			if (m3_SUBD.HasValue)
				request.WithQueryParameter("SUBD", m3_SUBD.Value.ToM3String());
			if (m3_PRIO.HasValue)
				request.WithQueryParameter("PRIO", m3_PRIO.Value.ToString());
			if (m3_NTWP.HasValue)
				request.WithQueryParameter("NTWP", m3_NTWP.Value.ToString());
			if (m3_CLGP.HasValue)
				request.WithQueryParameter("CLGP", m3_CLGP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PSTS))
				request.WithQueryParameter("PSTS", m3_PSTS.Trim());
			if (m3_QADJ.HasValue)
				request.WithQueryParameter("QADJ", m3_QADJ.Value.ToString());
			if (m3_RRSD.HasValue)
				request.WithQueryParameter("RRSD", m3_RRSD.Value.ToM3String());
			if (m3_RRST.HasValue)
				request.WithQueryParameter("RRST", m3_RRST.Value.ToString());
			if (m3_RRFD.HasValue)
				request.WithQueryParameter("RRFD", m3_RRFD.Value.ToM3String());
			if (m3_RRFT.HasValue)
				request.WithQueryParameter("RRFT", m3_RRFT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RREQ))
				request.WithQueryParameter("RREQ", m3_RREQ.Trim());
			if (m3_RBAM.HasValue)
				request.WithQueryParameter("RBAM", m3_RBAM.Value.ToString());
			if (m3_ESBU.HasValue)
				request.WithQueryParameter("ESBU", m3_ESBU.Value.ToString());
			if (m3_EDWT.HasValue)
				request.WithQueryParameter("EDWT", m3_EDWT.Value.ToString());
			if (m3_SCHL.HasValue)
				request.WithQueryParameter("SCHL", m3_SCHL.Value.ToString());

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
		/// Name TSelInbox
		/// Description Select Inbox for errors
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<TSelInboxResponse></returns>
		/// <exception cref="M3Exception<TSelInboxResponse>"></exception>
		public async Task<M3Response<TSelInboxResponse>> TSelInbox(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/TSelInbox",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<TSelInboxResponse>(
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
		/// Name TSelOperText
		/// Description Select Operation text
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TXVR">Text block</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<TSelOperTextResponse></returns>
		/// <exception cref="M3Exception<TSelOperTextResponse>"></exception>
		public async Task<M3Response<TSelOperTextResponse>> TSelOperText(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_MFNO, 
			int m3_OPNO, 
			int? m3_CONO = null, 
			string m3_TXVR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/TSelOperText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_MFNO))
				throw new ArgumentNullException("m3_MFNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("MFNO", m3_MFNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TXVR))
				request.WithQueryParameter("TXVR", m3_TXVR.Trim());

			// Execute the request
			var result = await Execute<TSelOperTextResponse>(
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
		/// Name TriggerUpdatJob
		/// Description Starts update processing
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> TriggerUpdatJob(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/TriggerUpdatJob",
			};

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
		/// Name Upd
		/// Description Update work order header
		/// Version Release: 5ea9
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product (Required)</param>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_CFI1">User-defined field 1 - item</param>
		/// <param name="m3_CFI2">User-defined field 2 - item</param>
		/// <param name="m3_CFI3">User-defined field 3 - item</param>
		/// <param name="m3_CFI4">User-defined field 4 - item</param>
		/// <param name="m3_CFI5">User-defined field 5 - item</param>
		/// <param name="m3_TXT1">Text line 1</param>
		/// <param name="m3_TXT2">Text line 2</param>
		/// <param name="m3_ADRR">Address file</param>
		/// <param name="m3_ADRT">Address type</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_BRDT">Breakdown date</param>
		/// <param name="m3_BRTI">Break down time</param>
		/// <param name="m3_MRDT">Machine ready date</param>
		/// <param name="m3_MRTI">Machine ready time</param>
		/// <param name="m3_EQDT">Equipment in production - date</param>
		/// <param name="m3_EQTI">Equipment in production - time</param>
		/// <param name="m3_EVTY">Event type</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_MWNO, 
			string m3_CFI1 = null, 
			decimal? m3_CFI2 = null, 
			string m3_CFI3 = null, 
			string m3_CFI4 = null, 
			string m3_CFI5 = null, 
			string m3_TXT1 = null, 
			string m3_TXT2 = null, 
			int? m3_ADRR = null, 
			int? m3_ADRT = null, 
			string m3_ADID = null, 
			DateTime? m3_BRDT = null, 
			int? m3_BRTI = null, 
			DateTime? m3_MRDT = null, 
			int? m3_MRTI = null, 
			DateTime? m3_EQDT = null, 
			int? m3_EQTI = null, 
			string m3_EVTY = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_RESP = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("MWNO", m3_MWNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CFI1))
				request.WithQueryParameter("CFI1", m3_CFI1.Trim());
			if (m3_CFI2.HasValue)
				request.WithQueryParameter("CFI2", m3_CFI2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFI3))
				request.WithQueryParameter("CFI3", m3_CFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI4))
				request.WithQueryParameter("CFI4", m3_CFI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI5))
				request.WithQueryParameter("CFI5", m3_CFI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT1))
				request.WithQueryParameter("TXT1", m3_TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT2))
				request.WithQueryParameter("TXT2", m3_TXT2.Trim());
			if (m3_ADRR.HasValue)
				request.WithQueryParameter("ADRR", m3_ADRR.Value.ToString());
			if (m3_ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3_ADRT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (m3_BRDT.HasValue)
				request.WithQueryParameter("BRDT", m3_BRDT.Value.ToM3String());
			if (m3_BRTI.HasValue)
				request.WithQueryParameter("BRTI", m3_BRTI.Value.ToString());
			if (m3_MRDT.HasValue)
				request.WithQueryParameter("MRDT", m3_MRDT.Value.ToM3String());
			if (m3_MRTI.HasValue)
				request.WithQueryParameter("MRTI", m3_MRTI.Value.ToString());
			if (m3_EQDT.HasValue)
				request.WithQueryParameter("EQDT", m3_EQDT.Value.ToM3String());
			if (m3_EQTI.HasValue)
				request.WithQueryParameter("EQTI", m3_EQTI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EVTY))
				request.WithQueryParameter("EVTY", m3_EVTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());

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
