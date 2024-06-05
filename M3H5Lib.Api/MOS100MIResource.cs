/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3RORC">Reference order category (Required)</param>
		/// <param name="m3RORN">Reference order number (Required)</param>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3SPMO">Supplying WO (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddInboxNetwork(
			string m3FACI, 
			int m3RORC, 
			string m3RORN, 
			string m3MWNO, 
			int m3SPMO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddInboxNetwork",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3RORN))
				throw new ArgumentNullException(nameof(m3RORN));
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("RORC", m3RORC.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RORN", m3RORN.Trim())
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("SPMO", m3SPMO.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddInboxOp
		/// Description Add record to operations in-box
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3RPCD">Released/planned code (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3MSTI">Start time (Required)</param>
		/// <param name="m3FIDT">Finish date (Required)</param>
		/// <param name="m3MFTI">Finish time (Required)</param>
		/// <param name="m3PLGR">Finite scheduled resource (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PLG1">APP work center</param>
		/// <param name="m3PLGF">Forced resource</param>
		/// <param name="m3NXOP">Next operation</param>
		/// <param name="m3APON">Primary operation number</param>
		/// <param name="m3POOC">Parallel operation overlap code</param>
		/// <param name="m3SLAT">Transit U/M / Overlap's code</param>
		/// <param name="m3RESR">Resource restriction</param>
		/// <param name="m3SPLK">Split code operation</param>
		/// <param name="m3SPLN">Number of operations after split</param>
		/// <param name="m3SPSZ">Split quantinty</param>
		/// <param name="m3FRCD">Forced start date</param>
		/// <param name="m3FRCT">Forced start time</param>
		/// <param name="m3SEQS">Sequencing status</param>
		/// <param name="m3PRAP">APP processed</param>
		/// <param name="m3SPLT">Change code</param>
		/// <param name="m3CHNO">Change number</param>
		/// <param name="m3WLDE">Infinite/finite</param>
		/// <param name="m3PLNR">Planned number of resources</param>
		/// <param name="m3SETI">Setup time</param>
		/// <param name="m3ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3SCHN">Schedule number</param>
		/// <param name="m3SCHS">Sequence number within schedule</param>
		/// <param name="m3MACH">Machine identity</param>
		/// <param name="m3OADS">Operation element exists</param>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3ROLE">Role/organizational position</param>
		/// <param name="m3PITI">Run time</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3OPDS">Operation description</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3RRSD">Requested start date</param>
		/// <param name="m3RRST">Requested start time</param>
		/// <param name="m3RRFD">Requested finish date</param>
		/// <param name="m3RRFT">Requested finish time</param>
		/// <param name="m3RBUP">Remaining buffer percent</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddInboxOp(
			string m3FACI, 
			string m3PRNO, 
			string m3MFNO, 
			string m3RPCD, 
			int m3OPNO, 
			DateTime m3STDT, 
			int m3MSTI, 
			DateTime m3FIDT, 
			int m3MFTI, 
			string m3PLGR, 
			int? m3CONO = null, 
			string m3PLG1 = null, 
			string m3PLGF = null, 
			int? m3NXOP = null, 
			int? m3APON = null, 
			int? m3POOC = null, 
			string m3SLAT = null, 
			string m3RESR = null, 
			int? m3SPLK = null, 
			int? m3SPLN = null, 
			decimal? m3SPSZ = null, 
			DateTime? m3FRCD = null, 
			int? m3FRCT = null, 
			int? m3SEQS = null, 
			string m3PRAP = null, 
			int? m3SPLT = null, 
			int? m3CHNO = null, 
			int? m3WLDE = null, 
			string m3PLNR = null, 
			int? m3SETI = null, 
			decimal? m3ORQT = null, 
			decimal? m3SCHN = null, 
			long? m3SCHS = null, 
			string m3MACH = null, 
			int? m3OADS = null, 
			string m3EMNO = null, 
			string m3ROLE = null, 
			int? m3PITI = null, 
			string m3SUFI = null, 
			string m3OPDS = null, 
			decimal? m3TXID = null, 
			DateTime? m3RRSD = null, 
			int? m3RRST = null, 
			DateTime? m3RRFD = null, 
			int? m3RRFT = null, 
			int? m3RBUP = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3MFNO))
				throw new ArgumentNullException(nameof(m3MFNO));
			if (string.IsNullOrWhiteSpace(m3RPCD))
				throw new ArgumentNullException(nameof(m3RPCD));
			if (string.IsNullOrWhiteSpace(m3PLGR))
				throw new ArgumentNullException(nameof(m3PLGR));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("MFNO", m3MFNO.Trim())
				.WithQueryParameter("RPCD", m3RPCD.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STDT", m3STDT.ToM3String())
				.WithQueryParameter("MSTI", m3MSTI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FIDT", m3FIDT.ToM3String())
				.WithQueryParameter("MFTI", m3MFTI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLGR", m3PLGR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLG1))
				request.WithQueryParameter("PLG1", m3PLG1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGF))
				request.WithQueryParameter("PLGF", m3PLGF.Trim());
			if (m3NXOP.HasValue)
				request.WithQueryParameter("NXOP", m3NXOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3APON.HasValue)
				request.WithQueryParameter("APON", m3APON.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POOC.HasValue)
				request.WithQueryParameter("POOC", m3POOC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SLAT))
				request.WithQueryParameter("SLAT", m3SLAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESR))
				request.WithQueryParameter("RESR", m3RESR.Trim());
			if (m3SPLK.HasValue)
				request.WithQueryParameter("SPLK", m3SPLK.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPLN.HasValue)
				request.WithQueryParameter("SPLN", m3SPLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPSZ.HasValue)
				request.WithQueryParameter("SPSZ", m3SPSZ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRCD.HasValue)
				request.WithQueryParameter("FRCD", m3FRCD.Value.ToM3String());
			if (m3FRCT.HasValue)
				request.WithQueryParameter("FRCT", m3FRCT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SEQS.HasValue)
				request.WithQueryParameter("SEQS", m3SEQS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRAP))
				request.WithQueryParameter("PRAP", m3PRAP.Trim());
			if (m3SPLT.HasValue)
				request.WithQueryParameter("SPLT", m3SPLT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3CHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WLDE.HasValue)
				request.WithQueryParameter("WLDE", m3WLDE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLNR))
				request.WithQueryParameter("PLNR", m3PLNR.Trim());
			if (m3SETI.HasValue)
				request.WithQueryParameter("SETI", m3SETI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3ORQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3SCHN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHS.HasValue)
				request.WithQueryParameter("SCHS", m3SCHS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MACH))
				request.WithQueryParameter("MACH", m3MACH.Trim());
			if (m3OADS.HasValue)
				request.WithQueryParameter("OADS", m3OADS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ROLE))
				request.WithQueryParameter("ROLE", m3ROLE.Trim());
			if (m3PITI.HasValue)
				request.WithQueryParameter("PITI", m3PITI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPDS))
				request.WithQueryParameter("OPDS", m3OPDS.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RRSD.HasValue)
				request.WithQueryParameter("RRSD", m3RRSD.Value.ToM3String());
			if (m3RRST.HasValue)
				request.WithQueryParameter("RRST", m3RRST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RRFD.HasValue)
				request.WithQueryParameter("RRFD", m3RRFD.Value.ToM3String());
			if (m3RRFT.HasValue)
				request.WithQueryParameter("RRFT", m3RRFT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RBUP.HasValue)
				request.WithQueryParameter("RBUP", m3RBUP.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddInboxOrder
		/// Description Add record to order in-box
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3RPCD">Released/planned code (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3MSTI">Start time (Required)</param>
		/// <param name="m3FIDT">Finish date (Required)</param>
		/// <param name="m3MFTI">Finish time (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORQA">Ordered quantity alternate U/M</param>
		/// <param name="m3ORQT">Ordered quantity basic U/M</param>
		/// <param name="m3PULD">Pull-up control delayed</param>
		/// <param name="m3PULN">Pull-up control non-delayed</param>
		/// <param name="m3AOID">Alternative routing</param>
		/// <param name="m3CHNO">Change number</param>
		/// <param name="m3UPDC">Update code</param>
		/// <param name="m3SUBN">Sub-network mark</param>
		/// <param name="m3SUBD">Sub-network date</param>
		/// <param name="m3PRIO">Priority</param>
		/// <param name="m3NTWP">External network priority</param>
		/// <param name="m3CLGP">Color group</param>
		/// <param name="m3PSTS">Status - planned MO</param>
		/// <param name="m3QADJ">Adjust quantity (yes/no)</param>
		/// <param name="m3NSTP">Shutdown</param>
		/// <param name="m3RRSD">Requested start date</param>
		/// <param name="m3RRST">Requested start time</param>
		/// <param name="m3RRFD">Requested finish date</param>
		/// <param name="m3RRFT">Requested finish time</param>
		/// <param name="m3RREQ">Requester</param>
		/// <param name="m3RBAM">Request budget amount</param>
		/// <param name="m3ESBU">Estimated cost</param>
		/// <param name="m3EDWT">Estimated downtime</param>
		/// <param name="m3SCHL">Scheduling logic</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddInboxOrder(
			string m3FACI, 
			string m3PRNO, 
			string m3MFNO, 
			string m3RPCD, 
			DateTime m3STDT, 
			int m3MSTI, 
			DateTime m3FIDT, 
			int m3MFTI, 
			int? m3CONO = null, 
			decimal? m3ORQA = null, 
			decimal? m3ORQT = null, 
			int? m3PULD = null, 
			int? m3PULN = null, 
			string m3AOID = null, 
			int? m3CHNO = null, 
			int? m3UPDC = null, 
			int? m3SUBN = null, 
			DateTime? m3SUBD = null, 
			int? m3PRIO = null, 
			int? m3NTWP = null, 
			int? m3CLGP = null, 
			string m3PSTS = null, 
			int? m3QADJ = null, 
			int? m3NSTP = null, 
			DateTime? m3RRSD = null, 
			int? m3RRST = null, 
			DateTime? m3RRFD = null, 
			int? m3RRFT = null, 
			string m3RREQ = null, 
			decimal? m3RBAM = null, 
			decimal? m3ESBU = null, 
			int? m3EDWT = null, 
			int? m3SCHL = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3MFNO))
				throw new ArgumentNullException(nameof(m3MFNO));
			if (string.IsNullOrWhiteSpace(m3RPCD))
				throw new ArgumentNullException(nameof(m3RPCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("MFNO", m3MFNO.Trim())
				.WithQueryParameter("RPCD", m3RPCD.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String())
				.WithQueryParameter("MSTI", m3MSTI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FIDT", m3FIDT.ToM3String())
				.WithQueryParameter("MFTI", m3MFTI.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORQA.HasValue)
				request.WithQueryParameter("ORQA", m3ORQA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3ORQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PULD.HasValue)
				request.WithQueryParameter("PULD", m3PULD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PULN.HasValue)
				request.WithQueryParameter("PULN", m3PULN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AOID))
				request.WithQueryParameter("AOID", m3AOID.Trim());
			if (m3CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3CHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UPDC.HasValue)
				request.WithQueryParameter("UPDC", m3UPDC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUBN.HasValue)
				request.WithQueryParameter("SUBN", m3SUBN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUBD.HasValue)
				request.WithQueryParameter("SUBD", m3SUBD.Value.ToM3String());
			if (m3PRIO.HasValue)
				request.WithQueryParameter("PRIO", m3PRIO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NTWP.HasValue)
				request.WithQueryParameter("NTWP", m3NTWP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CLGP.HasValue)
				request.WithQueryParameter("CLGP", m3CLGP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PSTS))
				request.WithQueryParameter("PSTS", m3PSTS.Trim());
			if (m3QADJ.HasValue)
				request.WithQueryParameter("QADJ", m3QADJ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NSTP.HasValue)
				request.WithQueryParameter("NSTP", m3NSTP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RRSD.HasValue)
				request.WithQueryParameter("RRSD", m3RRSD.Value.ToM3String());
			if (m3RRST.HasValue)
				request.WithQueryParameter("RRST", m3RRST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RRFD.HasValue)
				request.WithQueryParameter("RRFD", m3RRFD.Value.ToM3String());
			if (m3RRFT.HasValue)
				request.WithQueryParameter("RRFT", m3RRFT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RREQ))
				request.WithQueryParameter("RREQ", m3RREQ.Trim());
			if (m3RBAM.HasValue)
				request.WithQueryParameter("RBAM", m3RBAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ESBU.HasValue)
				request.WithQueryParameter("ESBU", m3ESBU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EDWT.HasValue)
				request.WithQueryParameter("EDWT", m3EDWT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHL.HasValue)
				request.WithQueryParameter("SCHL", m3SCHL.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddMtrl
		/// Description Add material to existing work order
		/// Version Release: 5eaF
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3MTNO">Component number (Required)</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3DWNO">Drawing number</param>
		/// <param name="m3FMT1">Text</param>
		/// <param name="m3FMT2">Technical reference</param>
		/// <param name="m3CNQT">Quantity</param>
		/// <param name="m3PEUN">Product engineering U/M</param>
		/// <param name="m3LGTH">Length</param>
		/// <param name="m3WDTH">Width</param>
		/// <param name="m3LWF1">Factor 1</param>
		/// <param name="m3LWF2">Factor 2</param>
		/// <param name="m3RDAT">Reservation date</param>
		/// <param name="m3TIHM">Time hours & minutes</param>
		/// <param name="m3MDBF">Lead time offset</param>
		/// <param name="m3MPRC">Component price</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3PRDY">Production days</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3STGS">Subcontract control</param>
		/// <param name="m3SPMT">Issue method</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3DWPO">Drawing position</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3WMST">Material status</param>
		/// <param name="m3NORD">Additional days - material reservation</param>
		/// <param name="m3RTHI">Reservation time - material</param>
		/// <param name="m3DSP1">Skip Warning Messages</param>
		/// <param name="m3EXCH">Exchange</param>
		/// <param name="m3ADRR">Address file</param>
		/// <param name="m3ADRT">Address type</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3LTYP">Line type</param>
		/// <param name="m3FWHL">From warehouse</param>
		/// <param name="m3TRTP">Order type</param>
		/// <param name="m3IORL">Interface order line</param>
		/// <param name="m3IORN">Interface order number</param>
		/// <param name="m3PRMO">Price origin</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3OT53">Abnormal demand</param>
		/// <param name="m3FWHS">Firm warehouse</param>
		/// <param name="m3FXCD">Quantity Relation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddMtrlResponse></returns>
		/// <exception cref="M3Exception<AddMtrlResponse>"></exception>
		public async Task<M3Response<AddMtrlResponse>> AddMtrl(
			string m3MWNO, 
			string m3MTNO, 
			int? m3OPNO = null, 
			int? m3MSEQ = null, 
			string m3DWNO = null, 
			string m3FMT1 = null, 
			string m3FMT2 = null, 
			decimal? m3CNQT = null, 
			string m3PEUN = null, 
			int? m3LGTH = null, 
			int? m3WDTH = null, 
			decimal? m3LWF1 = null, 
			decimal? m3LWF2 = null, 
			DateTime? m3RDAT = null, 
			int? m3TIHM = null, 
			int? m3MDBF = null, 
			decimal? m3MPRC = null, 
			string m3WHLO = null, 
			string m3WHSL = null, 
			string m3TWSL = null, 
			string m3BANO = null, 
			string m3SUNO = null, 
			int? m3PRDY = null, 
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			decimal? m3ATNR = null, 
			int? m3STGS = null, 
			int? m3SPMT = null, 
			string m3RSCD = null, 
			string m3DWPO = null, 
			decimal? m3TXID = null, 
			string m3WMST = null, 
			string m3NORD = null, 
			int? m3RTHI = null, 
			int? m3DSP1 = null, 
			int? m3EXCH = null, 
			int? m3ADRR = null, 
			int? m3ADRT = null, 
			string m3ADID = null, 
			string m3LTYP = null, 
			string m3FWHL = null, 
			string m3TRTP = null, 
			int? m3IORL = null, 
			string m3IORN = null, 
			string m3PRMO = null, 
			decimal? m3SAPR = null, 
			int? m3OT53 = null, 
			int? m3FWHS = null, 
			int? m3FXCD = null, 
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
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));
			if (string.IsNullOrWhiteSpace(m3MTNO))
				throw new ArgumentNullException(nameof(m3MTNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("MTNO", m3MTNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DWNO))
				request.WithQueryParameter("DWNO", m3DWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMT1))
				request.WithQueryParameter("FMT1", m3FMT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMT2))
				request.WithQueryParameter("FMT2", m3FMT2.Trim());
			if (m3CNQT.HasValue)
				request.WithQueryParameter("CNQT", m3CNQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PEUN))
				request.WithQueryParameter("PEUN", m3PEUN.Trim());
			if (m3LGTH.HasValue)
				request.WithQueryParameter("LGTH", m3LGTH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WDTH.HasValue)
				request.WithQueryParameter("WDTH", m3WDTH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LWF1.HasValue)
				request.WithQueryParameter("LWF1", m3LWF1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LWF2.HasValue)
				request.WithQueryParameter("LWF2", m3LWF2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RDAT.HasValue)
				request.WithQueryParameter("RDAT", m3RDAT.Value.ToM3String());
			if (m3TIHM.HasValue)
				request.WithQueryParameter("TIHM", m3TIHM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MDBF.HasValue)
				request.WithQueryParameter("MDBF", m3MDBF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MPRC.HasValue)
				request.WithQueryParameter("MPRC", m3MPRC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3PRDY.HasValue)
				request.WithQueryParameter("PRDY", m3PRDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STGS.HasValue)
				request.WithQueryParameter("STGS", m3STGS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3SPMT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3DWPO))
				request.WithQueryParameter("DWPO", m3DWPO.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WMST))
				request.WithQueryParameter("WMST", m3WMST.Trim());
			if (!string.IsNullOrWhiteSpace(m3NORD))
				request.WithQueryParameter("NORD", m3NORD.Trim());
			if (m3RTHI.HasValue)
				request.WithQueryParameter("RTHI", m3RTHI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3DSP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXCH.HasValue)
				request.WithQueryParameter("EXCH", m3EXCH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADRR.HasValue)
				request.WithQueryParameter("ADRR", m3ADRR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3ADRT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3LTYP))
				request.WithQueryParameter("LTYP", m3LTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FWHL))
				request.WithQueryParameter("FWHL", m3FWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRTP))
				request.WithQueryParameter("TRTP", m3TRTP.Trim());
			if (m3IORL.HasValue)
				request.WithQueryParameter("IORL", m3IORL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3IORN))
				request.WithQueryParameter("IORN", m3IORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRMO))
				request.WithQueryParameter("PRMO", m3PRMO.Trim());
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OT53.HasValue)
				request.WithQueryParameter("OT53", m3OT53.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FWHS.HasValue)
				request.WithQueryParameter("FWHS", m3FWHS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FXCD.HasValue)
				request.WithQueryParameter("FXCD", m3FXCD.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddMtrlResponse>(
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
		/// Name AddOp
		/// Description Add operation to existing work order
		/// Version Release: 5eaD
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3PLGR">Work center (Required)</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3OPDS">Operation description</param>
		/// <param name="m3TXT1">Text line 1</param>
		/// <param name="m3TXT2">Text line 2</param>
		/// <param name="m3DOID">Document identity</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3MSTI">Start time</param>
		/// <param name="m3FIDT">Finish date</param>
		/// <param name="m3MFTI">Finish time</param>
		/// <param name="m3LASK">Labor skill</param>
		/// <param name="m3FXTI">Fixed time</param>
		/// <param name="m3SETI">Setup time</param>
		/// <param name="m3OSET">External setup time</param>
		/// <param name="m3PITI">Run time</param>
		/// <param name="m3SENP">Planned number of workers - setup</param>
		/// <param name="m3PRNP">Planned number of workers - run time</param>
		/// <param name="m3PRNM">Planned number of machines</param>
		/// <param name="m3TOOL">Tool number</param>
		/// <param name="m3CAMP">Number of labor tickets</param>
		/// <param name="m3QUDY">Queue days</param>
		/// <param name="m3SLAC">Transport value in days</param>
		/// <param name="m3ODBF">Lead time offset</param>
		/// <param name="m3PRDY">Production days</param>
		/// <param name="m3SWQT">Setup scrap</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3PSSQ">Co-sorting key</param>
		/// <param name="m3SCHN">Schedule number</param>
		/// <param name="m3SCHS">Schedule number sequence</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3EQNO">Equipment number</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3SPRQ">Specific requirement category</param>
		/// <param name="m3SPRT">Specific requirements</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3DLY1">Delay time 1</param>
		/// <param name="m3DLY2">Delay time 2</param>
		/// <param name="m3FCLA">Error code 1</param>
		/// <param name="m3FCL2">Error code 2</param>
		/// <param name="m3FCL3">Error code 3</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3DPLG">Deviating work center</param>
		/// <param name="m3WLDE">Infinite/finite</param>
		/// <param name="m3SEPR">Setup price</param>
		/// <param name="m3PIPR">Unit price</param>
		/// <param name="m3DOWT">Downtime</param>
		/// <param name="m3IORN">Interface order number</param>
		/// <param name="m3IORL">Interface order line</param>
		/// <param name="m3ORQT">Ordered quantity - basic U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddOpResponse></returns>
		/// <exception cref="M3Exception<AddOpResponse>"></exception>
		public async Task<M3Response<AddOpResponse>> AddOp(
			string m3MWNO, 
			string m3PLGR, 
			int? m3OPNO = null, 
			string m3OPDS = null, 
			string m3TXT1 = null, 
			string m3TXT2 = null, 
			string m3DOID = null, 
			DateTime? m3STDT = null, 
			int? m3MSTI = null, 
			DateTime? m3FIDT = null, 
			int? m3MFTI = null, 
			string m3LASK = null, 
			int? m3FXTI = null, 
			int? m3SETI = null, 
			int? m3OSET = null, 
			int? m3PITI = null, 
			int? m3SENP = null, 
			int? m3PRNP = null, 
			int? m3PRNM = null, 
			string m3TOOL = null, 
			int? m3CAMP = null, 
			int? m3QUDY = null, 
			decimal? m3SLAC = null, 
			int? m3ODBF = null, 
			int? m3PRDY = null, 
			decimal? m3SWQT = null, 
			string m3SUNO = null, 
			string m3PSSQ = null, 
			decimal? m3SCHN = null, 
			long? m3SCHS = null, 
			decimal? m3TXID = null, 
			string m3CFGL = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3EQNO = null, 
			string m3SUFI = null, 
			string m3SPRQ = null, 
			string m3SPRT = null, 
			int? m3RORL = null, 
			int? m3DLY1 = null, 
			int? m3DLY2 = null, 
			string m3FCLA = null, 
			string m3FCL2 = null, 
			string m3FCL3 = null, 
			decimal? m3ATNR = null, 
			string m3DPLG = null, 
			int? m3WLDE = null, 
			decimal? m3SEPR = null, 
			decimal? m3PIPR = null, 
			int? m3DOWT = null, 
			string m3IORN = null, 
			int? m3IORL = null, 
			decimal? m3ORQT = null, 
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
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));
			if (string.IsNullOrWhiteSpace(m3PLGR))
				throw new ArgumentNullException(nameof(m3PLGR));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("PLGR", m3PLGR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OPDS))
				request.WithQueryParameter("OPDS", m3OPDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT1))
				request.WithQueryParameter("TXT1", m3TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT2))
				request.WithQueryParameter("TXT2", m3TXT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3MSTI.HasValue)
				request.WithQueryParameter("MSTI", m3MSTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3FIDT.Value.ToM3String());
			if (m3MFTI.HasValue)
				request.WithQueryParameter("MFTI", m3MFTI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LASK))
				request.WithQueryParameter("LASK", m3LASK.Trim());
			if (m3FXTI.HasValue)
				request.WithQueryParameter("FXTI", m3FXTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SETI.HasValue)
				request.WithQueryParameter("SETI", m3SETI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OSET.HasValue)
				request.WithQueryParameter("OSET", m3OSET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PITI.HasValue)
				request.WithQueryParameter("PITI", m3PITI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SENP.HasValue)
				request.WithQueryParameter("SENP", m3SENP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3PRNP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNM.HasValue)
				request.WithQueryParameter("PRNM", m3PRNM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TOOL))
				request.WithQueryParameter("TOOL", m3TOOL.Trim());
			if (m3CAMP.HasValue)
				request.WithQueryParameter("CAMP", m3CAMP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QUDY.HasValue)
				request.WithQueryParameter("QUDY", m3QUDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SLAC.HasValue)
				request.WithQueryParameter("SLAC", m3SLAC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ODBF.HasValue)
				request.WithQueryParameter("ODBF", m3ODBF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRDY.HasValue)
				request.WithQueryParameter("PRDY", m3PRDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SWQT.HasValue)
				request.WithQueryParameter("SWQT", m3SWQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PSSQ))
				request.WithQueryParameter("PSSQ", m3PSSQ.Trim());
			if (m3SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3SCHN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHS.HasValue)
				request.WithQueryParameter("SCHS", m3SCHS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQNO))
				request.WithQueryParameter("EQNO", m3EQNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPRQ))
				request.WithQueryParameter("SPRQ", m3SPRQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPRT))
				request.WithQueryParameter("SPRT", m3SPRT.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLY1.HasValue)
				request.WithQueryParameter("DLY1", m3DLY1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLY2.HasValue)
				request.WithQueryParameter("DLY2", m3DLY2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FCLA))
				request.WithQueryParameter("FCLA", m3FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL2))
				request.WithQueryParameter("FCL2", m3FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL3))
				request.WithQueryParameter("FCL3", m3FCL3.Trim());
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DPLG))
				request.WithQueryParameter("DPLG", m3DPLG.Trim());
			if (m3WLDE.HasValue)
				request.WithQueryParameter("WLDE", m3WLDE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SEPR.HasValue)
				request.WithQueryParameter("SEPR", m3SEPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PIPR.HasValue)
				request.WithQueryParameter("PIPR", m3PIPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DOWT.HasValue)
				request.WithQueryParameter("DOWT", m3DOWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3IORN))
				request.WithQueryParameter("IORN", m3IORN.Trim());
			if (m3IORL.HasValue)
				request.WithQueryParameter("IORL", m3IORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3ORQT.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddOpResponse>(
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
		/// Name AddOp2
		/// Description Add OEM for operation to existing work order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3SMC0">User defined field 1</param>
		/// <param name="m3SMC1">User defined field 2</param>
		/// <param name="m3SMC2">User defined field 3</param>
		/// <param name="m3SMC3">User defined field 4</param>
		/// <param name="m3SMC4">User defined field 5</param>
		/// <param name="m3SMC5">User defined field 6</param>
		/// <param name="m3SMC6">User defined field 7</param>
		/// <param name="m3SMC7">User defined field 8</param>
		/// <param name="m3SMC8">User defined field 9</param>
		/// <param name="m3SMC9">User defined field 10</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddOp2(
			string m3MWNO, 
			int m3OPNO, 
			string m3SMC0 = null, 
			string m3SMC1 = null, 
			string m3SMC2 = null, 
			string m3SMC3 = null, 
			string m3SMC4 = null, 
			string m3SMC5 = null, 
			string m3SMC6 = null, 
			string m3SMC7 = null, 
			string m3SMC8 = null, 
			string m3SMC9 = null, 
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
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SMC0))
				request.WithQueryParameter("SMC0", m3SMC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC1))
				request.WithQueryParameter("SMC1", m3SMC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC2))
				request.WithQueryParameter("SMC2", m3SMC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC3))
				request.WithQueryParameter("SMC3", m3SMC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC4))
				request.WithQueryParameter("SMC4", m3SMC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC5))
				request.WithQueryParameter("SMC5", m3SMC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC6))
				request.WithQueryParameter("SMC6", m3SMC6.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC7))
				request.WithQueryParameter("SMC7", m3SMC7.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC8))
				request.WithQueryParameter("SMC8", m3SMC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC9))
				request.WithQueryParameter("SMC9", m3SMC9.Trim());

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
		/// Name ChgMtrl
		/// Description Change material to existing work order
		/// Version Release: 5eaF
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3DWNO">Drawing number</param>
		/// <param name="m3MTNO">Component number</param>
		/// <param name="m3FMT1">Text</param>
		/// <param name="m3FMT2">Technical reference</param>
		/// <param name="m3CNQT">Quantity</param>
		/// <param name="m3PEUN">Product engineering U/M</param>
		/// <param name="m3LGTH">Length</param>
		/// <param name="m3WDTH">Width</param>
		/// <param name="m3LWF1">Factor 1</param>
		/// <param name="m3LWF2">Factor 2</param>
		/// <param name="m3RDAT">Reservation date</param>
		/// <param name="m3TIHM">Time hours & minutes</param>
		/// <param name="m3MDBF">Lead time offset</param>
		/// <param name="m3MPRC">Component price</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3PRDY">Production days</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3STGS">Subcontract control</param>
		/// <param name="m3SPMT">Issue method</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3DWPO">Drawing position</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3WMST">Material status</param>
		/// <param name="m3NORD">Additional days - material reservation</param>
		/// <param name="m3RTHI">Reservation time - material</param>
		/// <param name="m3ADRR">Address file</param>
		/// <param name="m3ADRT">Address type</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3PRMO">Price origin</param>
		/// <param name="m3WATP">Warranty type</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3PYAG">Payer agreement</param>
		/// <param name="m3MAUP">Manually updated</param>
		/// <param name="m3ACWA">Claim warranty</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3OT53">Abnormal demand</param>
		/// <param name="m3FWHS">Firm warehouse</param>
		/// <param name="m3FXCD">Quantity Relation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgMtrl(
			string m3MWNO, 
			int? m3OPNO = null, 
			int? m3MSEQ = null, 
			string m3DWNO = null, 
			string m3MTNO = null, 
			string m3FMT1 = null, 
			string m3FMT2 = null, 
			decimal? m3CNQT = null, 
			string m3PEUN = null, 
			int? m3LGTH = null, 
			int? m3WDTH = null, 
			decimal? m3LWF1 = null, 
			decimal? m3LWF2 = null, 
			DateTime? m3RDAT = null, 
			int? m3TIHM = null, 
			int? m3MDBF = null, 
			decimal? m3MPRC = null, 
			string m3WHSL = null, 
			string m3TWSL = null, 
			string m3BANO = null, 
			string m3SUNO = null, 
			int? m3PRDY = null, 
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			decimal? m3ATNR = null, 
			int? m3STGS = null, 
			int? m3SPMT = null, 
			string m3RSCD = null, 
			string m3DWPO = null, 
			decimal? m3TXID = null, 
			string m3WMST = null, 
			string m3NORD = null, 
			int? m3RTHI = null, 
			int? m3ADRR = null, 
			int? m3ADRT = null, 
			string m3ADID = null, 
			string m3PRMO = null, 
			string m3WATP = null, 
			string m3PYNO = null, 
			string m3PYAG = null, 
			int? m3MAUP = null, 
			int? m3ACWA = null, 
			decimal? m3SAPR = null, 
			int? m3OT53 = null, 
			int? m3FWHS = null, 
			int? m3FXCD = null, 
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
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DWNO))
				request.WithQueryParameter("DWNO", m3DWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTNO))
				request.WithQueryParameter("MTNO", m3MTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMT1))
				request.WithQueryParameter("FMT1", m3FMT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMT2))
				request.WithQueryParameter("FMT2", m3FMT2.Trim());
			if (m3CNQT.HasValue)
				request.WithQueryParameter("CNQT", m3CNQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PEUN))
				request.WithQueryParameter("PEUN", m3PEUN.Trim());
			if (m3LGTH.HasValue)
				request.WithQueryParameter("LGTH", m3LGTH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WDTH.HasValue)
				request.WithQueryParameter("WDTH", m3WDTH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LWF1.HasValue)
				request.WithQueryParameter("LWF1", m3LWF1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LWF2.HasValue)
				request.WithQueryParameter("LWF2", m3LWF2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RDAT.HasValue)
				request.WithQueryParameter("RDAT", m3RDAT.Value.ToM3String());
			if (m3TIHM.HasValue)
				request.WithQueryParameter("TIHM", m3TIHM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MDBF.HasValue)
				request.WithQueryParameter("MDBF", m3MDBF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MPRC.HasValue)
				request.WithQueryParameter("MPRC", m3MPRC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3PRDY.HasValue)
				request.WithQueryParameter("PRDY", m3PRDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STGS.HasValue)
				request.WithQueryParameter("STGS", m3STGS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3SPMT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3DWPO))
				request.WithQueryParameter("DWPO", m3DWPO.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WMST))
				request.WithQueryParameter("WMST", m3WMST.Trim());
			if (!string.IsNullOrWhiteSpace(m3NORD))
				request.WithQueryParameter("NORD", m3NORD.Trim());
			if (m3RTHI.HasValue)
				request.WithQueryParameter("RTHI", m3RTHI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADRR.HasValue)
				request.WithQueryParameter("ADRR", m3ADRR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3ADRT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRMO))
				request.WithQueryParameter("PRMO", m3PRMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WATP))
				request.WithQueryParameter("WATP", m3WATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYAG))
				request.WithQueryParameter("PYAG", m3PYAG.Trim());
			if (m3MAUP.HasValue)
				request.WithQueryParameter("MAUP", m3MAUP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACWA.HasValue)
				request.WithQueryParameter("ACWA", m3ACWA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OT53.HasValue)
				request.WithQueryParameter("OT53", m3OT53.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FWHS.HasValue)
				request.WithQueryParameter("FWHS", m3FWHS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FXCD.HasValue)
				request.WithQueryParameter("FXCD", m3FXCD.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgOp
		/// Description Change existing operation
		/// Version Release: 5eaD
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3OPDS">Operation description</param>
		/// <param name="m3TXT1">Text line 1</param>
		/// <param name="m3TXT2">Text line 2</param>
		/// <param name="m3DOID">Document identity</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3MSTI">Start time</param>
		/// <param name="m3FIDT">Finish date</param>
		/// <param name="m3MFTI">Finish time</param>
		/// <param name="m3LASK">Labor skill</param>
		/// <param name="m3FXTI">Fixed time</param>
		/// <param name="m3SETI">Setup time</param>
		/// <param name="m3OSET">External setup time</param>
		/// <param name="m3PITI">Run time</param>
		/// <param name="m3SENP">Planned number of workers - setup</param>
		/// <param name="m3PRNP">Planned number of workers - run time</param>
		/// <param name="m3PRNM">Planned number of machines</param>
		/// <param name="m3TOOL">Tool number</param>
		/// <param name="m3CAMP">Number of labor tickets</param>
		/// <param name="m3QUDY">Queue days</param>
		/// <param name="m3SLAC">Transport value in days</param>
		/// <param name="m3ODBF">Lead time offset</param>
		/// <param name="m3PRDY">Production days</param>
		/// <param name="m3SWQT">Setup scrap</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3PSSQ">Co-sorting key</param>
		/// <param name="m3SCHN">Schedule number</param>
		/// <param name="m3SCHS">Schedule number sequence</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3EQNO">Equipment number</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3SPRQ">Specific requirement category</param>
		/// <param name="m3SPRT">Specific requirements</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3DLY1">Delay time 1</param>
		/// <param name="m3DLY2">Delay time 2</param>
		/// <param name="m3FCLA">Error code 1</param>
		/// <param name="m3FCL2">Error code 2</param>
		/// <param name="m3FCL3">Error code 3</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3DPLG">Deviating work center</param>
		/// <param name="m3WLDE">Infinite/finite</param>
		/// <param name="m3SEPR">Setup price</param>
		/// <param name="m3PIPR">Unit price</param>
		/// <param name="m3DOWT">Downtime</param>
		/// <param name="m3MAUP">Manually updated</param>
		/// <param name="m3PRMO">Price origin</param>
		/// <param name="m3WATP">Warranty type</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3PYAG">Payer agreement</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3ORQT">Ordered quantity - basic U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgOp(
			string m3MWNO, 
			int m3OPNO, 
			string m3PLGR = null, 
			string m3OPDS = null, 
			string m3TXT1 = null, 
			string m3TXT2 = null, 
			string m3DOID = null, 
			DateTime? m3STDT = null, 
			int? m3MSTI = null, 
			DateTime? m3FIDT = null, 
			int? m3MFTI = null, 
			string m3LASK = null, 
			int? m3FXTI = null, 
			int? m3SETI = null, 
			int? m3OSET = null, 
			int? m3PITI = null, 
			int? m3SENP = null, 
			int? m3PRNP = null, 
			int? m3PRNM = null, 
			string m3TOOL = null, 
			int? m3CAMP = null, 
			int? m3QUDY = null, 
			decimal? m3SLAC = null, 
			int? m3ODBF = null, 
			int? m3PRDY = null, 
			decimal? m3SWQT = null, 
			string m3SUNO = null, 
			string m3PSSQ = null, 
			decimal? m3SCHN = null, 
			long? m3SCHS = null, 
			decimal? m3TXID = null, 
			string m3CFGL = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3EQNO = null, 
			string m3SUFI = null, 
			string m3SPRQ = null, 
			string m3SPRT = null, 
			int? m3RORL = null, 
			int? m3DLY1 = null, 
			int? m3DLY2 = null, 
			string m3FCLA = null, 
			string m3FCL2 = null, 
			string m3FCL3 = null, 
			decimal? m3ATNR = null, 
			string m3DPLG = null, 
			int? m3WLDE = null, 
			decimal? m3SEPR = null, 
			decimal? m3PIPR = null, 
			int? m3DOWT = null, 
			int? m3MAUP = null, 
			string m3PRMO = null, 
			string m3WATP = null, 
			string m3PYNO = null, 
			string m3PYAG = null, 
			decimal? m3SAPR = null, 
			decimal? m3ORQT = null, 
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
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPDS))
				request.WithQueryParameter("OPDS", m3OPDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT1))
				request.WithQueryParameter("TXT1", m3TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT2))
				request.WithQueryParameter("TXT2", m3TXT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3MSTI.HasValue)
				request.WithQueryParameter("MSTI", m3MSTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3FIDT.Value.ToM3String());
			if (m3MFTI.HasValue)
				request.WithQueryParameter("MFTI", m3MFTI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LASK))
				request.WithQueryParameter("LASK", m3LASK.Trim());
			if (m3FXTI.HasValue)
				request.WithQueryParameter("FXTI", m3FXTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SETI.HasValue)
				request.WithQueryParameter("SETI", m3SETI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OSET.HasValue)
				request.WithQueryParameter("OSET", m3OSET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PITI.HasValue)
				request.WithQueryParameter("PITI", m3PITI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SENP.HasValue)
				request.WithQueryParameter("SENP", m3SENP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3PRNP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNM.HasValue)
				request.WithQueryParameter("PRNM", m3PRNM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TOOL))
				request.WithQueryParameter("TOOL", m3TOOL.Trim());
			if (m3CAMP.HasValue)
				request.WithQueryParameter("CAMP", m3CAMP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QUDY.HasValue)
				request.WithQueryParameter("QUDY", m3QUDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SLAC.HasValue)
				request.WithQueryParameter("SLAC", m3SLAC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ODBF.HasValue)
				request.WithQueryParameter("ODBF", m3ODBF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRDY.HasValue)
				request.WithQueryParameter("PRDY", m3PRDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SWQT.HasValue)
				request.WithQueryParameter("SWQT", m3SWQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PSSQ))
				request.WithQueryParameter("PSSQ", m3PSSQ.Trim());
			if (m3SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3SCHN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHS.HasValue)
				request.WithQueryParameter("SCHS", m3SCHS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQNO))
				request.WithQueryParameter("EQNO", m3EQNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPRQ))
				request.WithQueryParameter("SPRQ", m3SPRQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPRT))
				request.WithQueryParameter("SPRT", m3SPRT.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLY1.HasValue)
				request.WithQueryParameter("DLY1", m3DLY1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLY2.HasValue)
				request.WithQueryParameter("DLY2", m3DLY2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FCLA))
				request.WithQueryParameter("FCLA", m3FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL2))
				request.WithQueryParameter("FCL2", m3FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL3))
				request.WithQueryParameter("FCL3", m3FCL3.Trim());
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DPLG))
				request.WithQueryParameter("DPLG", m3DPLG.Trim());
			if (m3WLDE.HasValue)
				request.WithQueryParameter("WLDE", m3WLDE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SEPR.HasValue)
				request.WithQueryParameter("SEPR", m3SEPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PIPR.HasValue)
				request.WithQueryParameter("PIPR", m3PIPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DOWT.HasValue)
				request.WithQueryParameter("DOWT", m3DOWT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MAUP.HasValue)
				request.WithQueryParameter("MAUP", m3MAUP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRMO))
				request.WithQueryParameter("PRMO", m3PRMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WATP))
				request.WithQueryParameter("WATP", m3WATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYAG))
				request.WithQueryParameter("PYAG", m3PYAG.Trim());
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3ORQT.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgOp2
		/// Description Change existing OEM for operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3SMC0">User defined field 1</param>
		/// <param name="m3SMC1">User defined field 2</param>
		/// <param name="m3SMC2">User defined field 3</param>
		/// <param name="m3SMC3">User defined field 4</param>
		/// <param name="m3SMC4">User defined field 5</param>
		/// <param name="m3SMC5">User defined field 6</param>
		/// <param name="m3SMC6">User defined field 7</param>
		/// <param name="m3SMC7">User defined field 8</param>
		/// <param name="m3SMC8">User defined field 9</param>
		/// <param name="m3SMC9">User defined field 10</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgOp2(
			string m3MWNO, 
			int m3OPNO, 
			string m3SMC0 = null, 
			string m3SMC1 = null, 
			string m3SMC2 = null, 
			string m3SMC3 = null, 
			string m3SMC4 = null, 
			string m3SMC5 = null, 
			string m3SMC6 = null, 
			string m3SMC7 = null, 
			string m3SMC8 = null, 
			string m3SMC9 = null, 
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
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SMC0))
				request.WithQueryParameter("SMC0", m3SMC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC1))
				request.WithQueryParameter("SMC1", m3SMC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC2))
				request.WithQueryParameter("SMC2", m3SMC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC3))
				request.WithQueryParameter("SMC3", m3SMC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC4))
				request.WithQueryParameter("SMC4", m3SMC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC5))
				request.WithQueryParameter("SMC5", m3SMC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC6))
				request.WithQueryParameter("SMC6", m3SMC6.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC7))
				request.WithQueryParameter("SMC7", m3SMC7.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC8))
				request.WithQueryParameter("SMC8", m3SMC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC9))
				request.WithQueryParameter("SMC9", m3SMC9.Trim());

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
		/// Name ChgPrio
		/// Description Change priority and shutdown
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3PRIO">Priority (Required)</param>
		/// <param name="m3NSTP">Shutdown</param>
		/// <param name="m3RREQ">Requester</param>
		/// <param name="m3APRB">Approved by</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3EVTY">Event type</param>
		/// <param name="m3TXT1">Text line 1</param>
		/// <param name="m3TXT2">Text line 2</param>
		/// <param name="m3EDWT">Estimated downtime</param>
		/// <param name="m3ESBU">Estimated cost</param>
		/// <param name="m3RRSD">Requested start date</param>
		/// <param name="m3RRST">Requested start time</param>
		/// <param name="m3RRFD">Requested finish date</param>
		/// <param name="m3RRFT">Requested finish time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ChgPrioResponse></returns>
		/// <exception cref="M3Exception<ChgPrioResponse>"></exception>
		public async Task<M3Response<ChgPrioResponse>> ChgPrio(
			string m3MWNO, 
			int m3PRIO, 
			int? m3NSTP = null, 
			string m3RREQ = null, 
			string m3APRB = null, 
			string m3RESP = null, 
			string m3EVTY = null, 
			string m3TXT1 = null, 
			string m3TXT2 = null, 
			int? m3EDWT = null, 
			decimal? m3ESBU = null, 
			DateTime? m3RRSD = null, 
			int? m3RRST = null, 
			DateTime? m3RRFD = null, 
			int? m3RRFT = null, 
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
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("PRIO", m3PRIO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3NSTP.HasValue)
				request.WithQueryParameter("NSTP", m3NSTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RREQ))
				request.WithQueryParameter("RREQ", m3RREQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3APRB))
				request.WithQueryParameter("APRB", m3APRB.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVTY))
				request.WithQueryParameter("EVTY", m3EVTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT1))
				request.WithQueryParameter("TXT1", m3TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT2))
				request.WithQueryParameter("TXT2", m3TXT2.Trim());
			if (m3EDWT.HasValue)
				request.WithQueryParameter("EDWT", m3EDWT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ESBU.HasValue)
				request.WithQueryParameter("ESBU", m3ESBU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RRSD.HasValue)
				request.WithQueryParameter("RRSD", m3RRSD.Value.ToM3String());
			if (m3RRST.HasValue)
				request.WithQueryParameter("RRST", m3RRST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RRFD.HasValue)
				request.WithQueryParameter("RRFD", m3RRFD.Value.ToM3String());
			if (m3RRFT.HasValue)
				request.WithQueryParameter("RRFT", m3RRFT.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ChgPrioResponse>(
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
		/// Name ClrInboxes
		/// Description Delete all records in user's in-box
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ClrInboxes(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ClrInboxes",
			};

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
		/// Name DelMtrl
		/// Description Delete Material
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3MSEQ">Sequence number (Required)</param>
		/// <param name="m3MTNO">Component number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelMtrl(
			string m3MWNO, 
			int m3MSEQ, 
			string m3MTNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("MSEQ", m3MSEQ.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MTNO))
				request.WithQueryParameter("MTNO", m3MTNO.Trim());

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
		/// Name DelNetwork
		/// Description Delete network
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3MWNO">Work order number</param>
		/// <param name="m3SPMO">Supplying WO</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelNetwork(
			string m3FACI = null, 
			int? m3RORC = null, 
			string m3RORN = null, 
			string m3MWNO = null, 
			string m3SPMO = null, 
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
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3MWNO))
				request.WithQueryParameter("MWNO", m3MWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPMO))
				request.WithQueryParameter("SPMO", m3SPMO.Trim());

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
		/// Name DelOp
		/// Description Delete Operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelOp(
			string m3MWNO, 
			int m3OPNO, 
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
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

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
		/// Description Get one maintenance order
		/// Version Release: 5eaF
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3FACI, 
			string m3PRNO, 
			string m3MFNO, 
			int? m3CONO = null, 
			string m3REAR = null, 
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
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3MFNO))
				throw new ArgumentNullException(nameof(m3MFNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("MFNO", m3MFNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());

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
		/// Name GetMtrl
		/// Description Get Material
		/// Version Release: 5eaF
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3MSEQ">Sequence number (Required)</param>
		/// <param name="m3RCOS">Retrive cost</param>
		/// <param name="m3RPRI">Yes/no</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMtrlResponse></returns>
		/// <exception cref="M3Exception<GetMtrlResponse>"></exception>
		public async Task<M3Response<GetMtrlResponse>> GetMtrl(
			string m3MWNO, 
			int m3MSEQ, 
			int? m3RCOS = null, 
			int? m3RPRI = null, 
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
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("MSEQ", m3MSEQ.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3RCOS.HasValue)
				request.WithQueryParameter("RCOS", m3RCOS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPRI.HasValue)
				request.WithQueryParameter("RPRI", m3RPRI.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetMtrlResponse>(
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
		/// Name GetMtrl2
		/// Description Get Material
		/// Version Release: 5eaF
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3MSEQ">Sequence number (Required)</param>
		/// <param name="m3RCOS">Retrive cost</param>
		/// <param name="m3RPRI">Yes/no</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMtrl2Response></returns>
		/// <exception cref="M3Exception<GetMtrl2Response>"></exception>
		public async Task<M3Response<GetMtrl2Response>> GetMtrl2(
			string m3MWNO, 
			int m3MSEQ, 
			int? m3RCOS = null, 
			int? m3RPRI = null, 
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
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("MSEQ", m3MSEQ.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3RCOS.HasValue)
				request.WithQueryParameter("RCOS", m3RCOS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPRI.HasValue)
				request.WithQueryParameter("RPRI", m3RPRI.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetMtrl2Response>(
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
		/// Name GetOp
		/// Description Get Operation
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3RCOS">Retrive estimated cost</param>
		/// <param name="m3RPRI">Yes/no</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOpResponse></returns>
		/// <exception cref="M3Exception<GetOpResponse>"></exception>
		public async Task<M3Response<GetOpResponse>> GetOp(
			string m3MWNO, 
			int m3OPNO, 
			int? m3RCOS = null, 
			int? m3RPRI = null, 
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
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3RCOS.HasValue)
				request.WithQueryParameter("RCOS", m3RCOS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPRI.HasValue)
				request.WithQueryParameter("RPRI", m3RPRI.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetOpResponse>(
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
		/// Name GetOp2
		/// Description Get OEM for Operation
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3RCOS">Retrive estimated cost</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOp2Response></returns>
		/// <exception cref="M3Exception<GetOp2Response>"></exception>
		public async Task<M3Response<GetOp2Response>> GetOp2(
			string m3MWNO, 
			int m3OPNO, 
			int? m3RCOS = null, 
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
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3RCOS.HasValue)
				request.WithQueryParameter("RCOS", m3RCOS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetOp2Response>(
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
		/// Name GetUserJobSts
		/// Description Get update status per user
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetUserJobStsResponse></returns>
		/// <exception cref="M3Exception<GetUserJobStsResponse>"></exception>
		public async Task<M3Response<GetUserJobStsResponse>> GetUserJobSts(
			int? m3CONO = null, 
			string m3STAT = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());

			// Execute the request
			var result = await Execute<GetUserJobStsResponse>(
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
		/// Name GetWoAddress
		/// Description Get the dilivery address
		/// Version Release: 15
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetWoAddressResponse></returns>
		/// <exception cref="M3Exception<GetWoAddressResponse>"></exception>
		public async Task<M3Response<GetWoAddressResponse>> GetWoAddress(
			string m3MWNO, 
			int? m3MSEQ = null, 
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
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetWoAddressResponse>(
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
		/// Name LstReportByLine
		/// Description List reporting nbr by material line
		/// Version Release: 5eaC
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3MSEQ">Sequence number (Required)</param>
		/// <param name="m3RPQT">Reported quantity</param>
		/// <param name="m3OEND">Flagged as completed</param>
		/// <param name="m3MTNO">Component number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstReportByLineResponse></returns>
		/// <exception cref="M3Exception<LstReportByLineResponse>"></exception>
		public async Task<M3Response<LstReportByLineResponse>> LstReportByLine(
			string m3MWNO, 
			int m3MSEQ, 
			decimal? m3RPQT = null, 
			int? m3OEND = null, 
			string m3MTNO = null, 
			string m3BANO = null, 
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
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("MSEQ", m3MSEQ.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3RPQT.HasValue)
				request.WithQueryParameter("RPQT", m3RPQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MTNO))
				request.WithQueryParameter("MTNO", m3MTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());

			// Execute the request
			var result = await Execute<LstReportByLineResponse>(
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
		/// Name ReportUsedMtrl
		/// Description ReportUsedMtrl
		/// Version Release: 5eaC
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3MSEQ">Sequence number (Required)</param>
		/// <param name="m3RPQT">Reported quantity</param>
		/// <param name="m3OEND">Flagged as completed</param>
		/// <param name="m3MTNO">Component number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ReportUsedMtrl(
			string m3MWNO, 
			int m3MSEQ, 
			decimal? m3RPQT = null, 
			int? m3OEND = null, 
			string m3MTNO = null, 
			string m3BANO = null, 
			string m3WHSL = null, 
			string m3CAMU = null, 
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
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("MSEQ", m3MSEQ.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3RPQT.HasValue)
				request.WithQueryParameter("RPQT", m3RPQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MTNO))
				request.WithQueryParameter("MTNO", m3MTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());

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
		/// Name SearchOpno
		/// Description Search Operations
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3SQRY">New field description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchOpnoResponse></returns>
		/// <exception cref="M3Exception<SearchOpnoResponse>"></exception>
		public async Task<M3Response<SearchOpnoResponse>> SearchOpno(
			string m3SQRY = null, 
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
			if (!string.IsNullOrWhiteSpace(m3SQRY))
				request.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchOpnoResponse>(
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
		/// Name SearchWo
		/// Description Search Work order
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3SQRY">New field description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchWoResponse></returns>
		/// <exception cref="M3Exception<SearchWoResponse>"></exception>
		public async Task<M3Response<SearchWoResponse>> SearchWo(
			string m3SQRY = null, 
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
			if (!string.IsNullOrWhiteSpace(m3SQRY))
				request.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchWoResponse>(
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
		/// Name SelErrOrders
		/// Description Selection of orders not correctly updated
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelErrOrdersResponse></returns>
		/// <exception cref="M3Exception<SelErrOrdersResponse>"></exception>
		public async Task<M3Response<SelErrOrdersResponse>> SelErrOrders(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelErrOrders",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelErrOrdersResponse>(
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
		/// Name SelMaterials
		/// Description Selection of maintenance order materials
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3MFNO">Manufacturing order number</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3NETW">Net work planning (0/1)</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3CLOS">Yes/no</param>
		/// <param name="m3APIP">APS - policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelMaterialsResponse></returns>
		/// <exception cref="M3Exception<SelMaterialsResponse>"></exception>
		public async Task<M3Response<SelMaterialsResponse>> SelMaterials(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3MFNO = null, 
			string m3WHGR = null, 
			int? m3NETW = null, 
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3CLOS = null, 
			string m3APIP = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MFNO))
				request.WithQueryParameter("MFNO", m3MFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (m3NETW.HasValue)
				request.WithQueryParameter("NETW", m3NETW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3CLOS.HasValue)
				request.WithQueryParameter("CLOS", m3CLOS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());

			// Execute the request
			var result = await Execute<SelMaterialsResponse>(
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
		/// Name SelOperations
		/// Description Selection of operations
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3MFNO">Manufacturing order number</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3CLFI">Select closed operations first</param>
		/// <param name="m3CPRI">Create Primary operation</param>
		/// <param name="m3SKIL">Skill</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelOperationsResponse></returns>
		/// <exception cref="M3Exception<SelOperationsResponse>"></exception>
		public async Task<M3Response<SelOperationsResponse>> SelOperations(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3MFNO = null, 
			string m3REAR = null, 
			string m3WHGR = null, 
			string m3CLFI = null, 
			string m3CPRI = null, 
			string m3SKIL = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MFNO))
				request.WithQueryParameter("MFNO", m3MFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CLFI))
				request.WithQueryParameter("CLFI", m3CLFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CPRI))
				request.WithQueryParameter("CPRI", m3CPRI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SKIL))
				request.WithQueryParameter("SKIL", m3SKIL.Trim());

			// Execute the request
			var result = await Execute<SelOperationsResponse>(
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
		/// Name SelTools
		/// Description Selection of maintenance order materials
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3MFNO">Manufacturing order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelToolsResponse></returns>
		/// <exception cref="M3Exception<SelToolsResponse>"></exception>
		public async Task<M3Response<SelToolsResponse>> SelTools(
			string m3FACI, 
			int? m3CONO = null, 
			string m3PRNO = null, 
			string m3MFNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MFNO))
				request.WithQueryParameter("MFNO", m3MFNO.Trim());

			// Execute the request
			var result = await Execute<SelToolsResponse>(
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
		/// Description Selection of maintenance orders
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3STSF">From status (Required)</param>
		/// <param name="m3STST">To status (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACF">From facility</param>
		/// <param name="m3FACT">To facility</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3DATE">Timestamp - Date</param>
		/// <param name="m3TIME">Timestamp - Time</param>
		/// <param name="m3SCHH">Scheduling horizon</param>
		/// <param name="m3FWHS">From warehouse</param>
		/// <param name="m3TWHS">To warehouse</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3APIP">APS - policy</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3STRT">Structure type</param>
		/// <param name="m3SECL">Service Classification</param>
		/// <param name="m3LMDT">Change date from</param>
		/// <param name="m3TLMDT">Change date to</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectResponse></returns>
		/// <exception cref="M3Exception<SelectResponse>"></exception>
		public async Task<M3Response<SelectResponse>> Select(
			int m3STSF, 
			int m3STST, 
			int? m3CONO = null, 
			string m3FACF = null, 
			string m3FACT = null, 
			string m3REAR = null, 
			DateTime? m3DATE = null, 
			int? m3TIME = null, 
			int? m3SCHH = null, 
			string m3FWHS = null, 
			string m3TWHS = null, 
			string m3WHGR = null, 
			string m3APIP = null, 
			string m3SUFI = null, 
			string m3STRT = null, 
			int? m3SECL = null, 
			DateTime? m3LMDT = null, 
			DateTime? m3TLMDT = null, 
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
				.WithQueryParameter("STSF", m3STSF.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STST", m3STST.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACF))
				request.WithQueryParameter("FACF", m3FACF.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACT))
				request.WithQueryParameter("FACT", m3FACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (m3DATE.HasValue)
				request.WithQueryParameter("DATE", m3DATE.Value.ToM3String());
			if (m3TIME.HasValue)
				request.WithQueryParameter("TIME", m3TIME.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3SCHH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FWHS))
				request.WithQueryParameter("FWHS", m3FWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWHS))
				request.WithQueryParameter("TWHS", m3TWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3SECL.HasValue)
				request.WithQueryParameter("SECL", m3SECL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());
			if (m3TLMDT.HasValue)
				request.WithQueryParameter("TLMDT", m3TLMDT.Value.ToM3String());

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
		/// Name SetUserJobSts
		/// Description Set update status per user
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3STAT">Status (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetUserJobSts(
			string m3STAT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SetUserJobSts",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STAT))
				throw new ArgumentNullException(nameof(m3STAT));

			// Set mandatory parameters
			request
				.WithQueryParameter("STAT", m3STAT.Trim());

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
		/// Name SndInboxOp
		/// Description Send record to operations in-box
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3RPCD">Released/planned code (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3MSTI">Start time (Required)</param>
		/// <param name="m3FIDT">Finish date (Required)</param>
		/// <param name="m3MFTI">Finish time (Required)</param>
		/// <param name="m3PLGR">Finite scheduled resource (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PLG1">APP work center</param>
		/// <param name="m3PLGF">Forced resource</param>
		/// <param name="m3NXOP">Next operation</param>
		/// <param name="m3APON">Primary operation number</param>
		/// <param name="m3POOC">Parallel operation overlap code</param>
		/// <param name="m3SLAT">Transit U/M / Overlap's code</param>
		/// <param name="m3RESR">Resource restriction</param>
		/// <param name="m3SPLK">Split code operation</param>
		/// <param name="m3SPLN">Number of operations after split</param>
		/// <param name="m3SPSZ">Split quatinty</param>
		/// <param name="m3FRCD">Forced start date</param>
		/// <param name="m3FRCT">Forced start time</param>
		/// <param name="m3SEQS">Sequencing status</param>
		/// <param name="m3PRAP">APP processed</param>
		/// <param name="m3SPLT">Change code</param>
		/// <param name="m3CHNO">Change number</param>
		/// <param name="m3WLDE">Infinite/finite</param>
		/// <param name="m3PLNR">Planned number of resources</param>
		/// <param name="m3SETI">Setup time</param>
		/// <param name="m3ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3SCHN">Schedule number</param>
		/// <param name="m3SCHS">Sequence number within schedule</param>
		/// <param name="m3RRSD">Requested start date</param>
		/// <param name="m3RRST">Requested start time</param>
		/// <param name="m3RRFD">Requested finish date</param>
		/// <param name="m3RRFT">Requested finish time</param>
		/// <param name="m3RBUP">Remaining buffer percent</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndInboxOp(
			string m3FACI, 
			string m3PRNO, 
			string m3MFNO, 
			string m3RPCD, 
			int m3OPNO, 
			DateTime m3STDT, 
			int m3MSTI, 
			DateTime m3FIDT, 
			int m3MFTI, 
			string m3PLGR, 
			int? m3CONO = null, 
			string m3PLG1 = null, 
			string m3PLGF = null, 
			int? m3NXOP = null, 
			int? m3APON = null, 
			int? m3POOC = null, 
			string m3SLAT = null, 
			string m3RESR = null, 
			int? m3SPLK = null, 
			int? m3SPLN = null, 
			decimal? m3SPSZ = null, 
			DateTime? m3FRCD = null, 
			int? m3FRCT = null, 
			int? m3SEQS = null, 
			string m3PRAP = null, 
			int? m3SPLT = null, 
			int? m3CHNO = null, 
			int? m3WLDE = null, 
			string m3PLNR = null, 
			int? m3SETI = null, 
			decimal? m3ORQT = null, 
			int? m3SCHN = null, 
			long? m3SCHS = null, 
			DateTime? m3RRSD = null, 
			int? m3RRST = null, 
			DateTime? m3RRFD = null, 
			int? m3RRFT = null, 
			int? m3RBUP = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3MFNO))
				throw new ArgumentNullException(nameof(m3MFNO));
			if (string.IsNullOrWhiteSpace(m3RPCD))
				throw new ArgumentNullException(nameof(m3RPCD));
			if (string.IsNullOrWhiteSpace(m3PLGR))
				throw new ArgumentNullException(nameof(m3PLGR));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("MFNO", m3MFNO.Trim())
				.WithQueryParameter("RPCD", m3RPCD.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STDT", m3STDT.ToM3String())
				.WithQueryParameter("MSTI", m3MSTI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FIDT", m3FIDT.ToM3String())
				.WithQueryParameter("MFTI", m3MFTI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLGR", m3PLGR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLG1))
				request.WithQueryParameter("PLG1", m3PLG1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGF))
				request.WithQueryParameter("PLGF", m3PLGF.Trim());
			if (m3NXOP.HasValue)
				request.WithQueryParameter("NXOP", m3NXOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3APON.HasValue)
				request.WithQueryParameter("APON", m3APON.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POOC.HasValue)
				request.WithQueryParameter("POOC", m3POOC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SLAT))
				request.WithQueryParameter("SLAT", m3SLAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESR))
				request.WithQueryParameter("RESR", m3RESR.Trim());
			if (m3SPLK.HasValue)
				request.WithQueryParameter("SPLK", m3SPLK.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPLN.HasValue)
				request.WithQueryParameter("SPLN", m3SPLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPSZ.HasValue)
				request.WithQueryParameter("SPSZ", m3SPSZ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRCD.HasValue)
				request.WithQueryParameter("FRCD", m3FRCD.Value.ToM3String());
			if (m3FRCT.HasValue)
				request.WithQueryParameter("FRCT", m3FRCT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SEQS.HasValue)
				request.WithQueryParameter("SEQS", m3SEQS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRAP))
				request.WithQueryParameter("PRAP", m3PRAP.Trim());
			if (m3SPLT.HasValue)
				request.WithQueryParameter("SPLT", m3SPLT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3CHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WLDE.HasValue)
				request.WithQueryParameter("WLDE", m3WLDE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLNR))
				request.WithQueryParameter("PLNR", m3PLNR.Trim());
			if (m3SETI.HasValue)
				request.WithQueryParameter("SETI", m3SETI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3ORQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3SCHN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHS.HasValue)
				request.WithQueryParameter("SCHS", m3SCHS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RRSD.HasValue)
				request.WithQueryParameter("RRSD", m3RRSD.Value.ToM3String());
			if (m3RRST.HasValue)
				request.WithQueryParameter("RRST", m3RRST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RRFD.HasValue)
				request.WithQueryParameter("RRFD", m3RRFD.Value.ToM3String());
			if (m3RRFT.HasValue)
				request.WithQueryParameter("RRFT", m3RRFT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RBUP.HasValue)
				request.WithQueryParameter("RBUP", m3RBUP.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name SndInboxOrder
		/// Description Send record to order in-box
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3RPCD">Released/planned code (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3MSTI">Start time (Required)</param>
		/// <param name="m3FIDT">Finish date (Required)</param>
		/// <param name="m3MFTI">Finish time (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORQA">Ordered quantity alternate U/M</param>
		/// <param name="m3ORQT">Ordered quantity basic U/M</param>
		/// <param name="m3PULD">Pull-up control delayed</param>
		/// <param name="m3PULN">Pull-up control non-delayed</param>
		/// <param name="m3AOID">Alternative routing</param>
		/// <param name="m3CHNO">Change number</param>
		/// <param name="m3UPDC">Update code</param>
		/// <param name="m3SUBN">Sub-network mark</param>
		/// <param name="m3SUBD">Sub-network date</param>
		/// <param name="m3PRIO">Priority</param>
		/// <param name="m3NTWP">External network priority</param>
		/// <param name="m3CLGP">Color group</param>
		/// <param name="m3PSTS">Status - planned MO</param>
		/// <param name="m3QADJ">Adjust quantity (yes/no)</param>
		/// <param name="m3RRSD">Requested start date</param>
		/// <param name="m3RRST">Requested start time</param>
		/// <param name="m3RRFD">Requested finish date</param>
		/// <param name="m3RRFT">Requested finish time</param>
		/// <param name="m3RREQ">Requester</param>
		/// <param name="m3RBAM">Request budget amount</param>
		/// <param name="m3ESBU">Estimated cost</param>
		/// <param name="m3EDWT">Estimated downtime</param>
		/// <param name="m3SCHL">Scheduling logic</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndInboxOrder(
			string m3FACI, 
			string m3PRNO, 
			string m3MFNO, 
			string m3RPCD, 
			DateTime m3STDT, 
			int m3MSTI, 
			DateTime m3FIDT, 
			int m3MFTI, 
			int? m3CONO = null, 
			decimal? m3ORQA = null, 
			decimal? m3ORQT = null, 
			int? m3PULD = null, 
			int? m3PULN = null, 
			string m3AOID = null, 
			int? m3CHNO = null, 
			int? m3UPDC = null, 
			int? m3SUBN = null, 
			DateTime? m3SUBD = null, 
			int? m3PRIO = null, 
			int? m3NTWP = null, 
			int? m3CLGP = null, 
			string m3PSTS = null, 
			int? m3QADJ = null, 
			DateTime? m3RRSD = null, 
			int? m3RRST = null, 
			DateTime? m3RRFD = null, 
			int? m3RRFT = null, 
			string m3RREQ = null, 
			decimal? m3RBAM = null, 
			decimal? m3ESBU = null, 
			int? m3EDWT = null, 
			int? m3SCHL = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3MFNO))
				throw new ArgumentNullException(nameof(m3MFNO));
			if (string.IsNullOrWhiteSpace(m3RPCD))
				throw new ArgumentNullException(nameof(m3RPCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("MFNO", m3MFNO.Trim())
				.WithQueryParameter("RPCD", m3RPCD.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String())
				.WithQueryParameter("MSTI", m3MSTI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FIDT", m3FIDT.ToM3String())
				.WithQueryParameter("MFTI", m3MFTI.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORQA.HasValue)
				request.WithQueryParameter("ORQA", m3ORQA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3ORQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PULD.HasValue)
				request.WithQueryParameter("PULD", m3PULD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PULN.HasValue)
				request.WithQueryParameter("PULN", m3PULN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AOID))
				request.WithQueryParameter("AOID", m3AOID.Trim());
			if (m3CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3CHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UPDC.HasValue)
				request.WithQueryParameter("UPDC", m3UPDC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUBN.HasValue)
				request.WithQueryParameter("SUBN", m3SUBN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUBD.HasValue)
				request.WithQueryParameter("SUBD", m3SUBD.Value.ToM3String());
			if (m3PRIO.HasValue)
				request.WithQueryParameter("PRIO", m3PRIO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NTWP.HasValue)
				request.WithQueryParameter("NTWP", m3NTWP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CLGP.HasValue)
				request.WithQueryParameter("CLGP", m3CLGP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PSTS))
				request.WithQueryParameter("PSTS", m3PSTS.Trim());
			if (m3QADJ.HasValue)
				request.WithQueryParameter("QADJ", m3QADJ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RRSD.HasValue)
				request.WithQueryParameter("RRSD", m3RRSD.Value.ToM3String());
			if (m3RRST.HasValue)
				request.WithQueryParameter("RRST", m3RRST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RRFD.HasValue)
				request.WithQueryParameter("RRFD", m3RRFD.Value.ToM3String());
			if (m3RRFT.HasValue)
				request.WithQueryParameter("RRFT", m3RRFT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RREQ))
				request.WithQueryParameter("RREQ", m3RREQ.Trim());
			if (m3RBAM.HasValue)
				request.WithQueryParameter("RBAM", m3RBAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ESBU.HasValue)
				request.WithQueryParameter("ESBU", m3ESBU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EDWT.HasValue)
				request.WithQueryParameter("EDWT", m3EDWT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHL.HasValue)
				request.WithQueryParameter("SCHL", m3SCHL.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name TSelInbox
		/// Description Select Inbox for errors
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<TSelInboxResponse></returns>
		/// <exception cref="M3Exception<TSelInboxResponse>"></exception>
		public async Task<M3Response<TSelInboxResponse>> TSelInbox(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/TSelInbox",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<TSelInboxResponse>(
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
		/// Name TSelOperText
		/// Description Select Operation text
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TXVR">Text block</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<TSelOperTextResponse></returns>
		/// <exception cref="M3Exception<TSelOperTextResponse>"></exception>
		public async Task<M3Response<TSelOperTextResponse>> TSelOperText(
			string m3FACI, 
			string m3PRNO, 
			string m3MFNO, 
			int m3OPNO, 
			int? m3CONO = null, 
			string m3TXVR = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3MFNO))
				throw new ArgumentNullException(nameof(m3MFNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("MFNO", m3MFNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TXVR))
				request.WithQueryParameter("TXVR", m3TXVR.Trim());

			// Execute the request
			var result = await Execute<TSelOperTextResponse>(
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
		/// Name TriggerUpdatJob
		/// Description Starts update processing
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> TriggerUpdatJob(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/TriggerUpdatJob",
			};

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
		/// Name Upd
		/// Description Update work order header
		/// Version Release: 5ea9
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3CFI1">User-defined field 1 - item</param>
		/// <param name="m3CFI2">User-defined field 2 - item</param>
		/// <param name="m3CFI3">User-defined field 3 - item</param>
		/// <param name="m3CFI4">User-defined field 4 - item</param>
		/// <param name="m3CFI5">User-defined field 5 - item</param>
		/// <param name="m3TXT1">Text line 1</param>
		/// <param name="m3TXT2">Text line 2</param>
		/// <param name="m3ADRR">Address file</param>
		/// <param name="m3ADRT">Address type</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3BRDT">Breakdown date</param>
		/// <param name="m3BRTI">Break down time</param>
		/// <param name="m3MRDT">Machine ready date</param>
		/// <param name="m3MRTI">Machine ready time</param>
		/// <param name="m3EQDT">Equipment in production - date</param>
		/// <param name="m3EQTI">Equipment in production - time</param>
		/// <param name="m3EVTY">Event type</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3FACI, 
			string m3PRNO, 
			string m3MWNO, 
			string m3CFI1 = null, 
			decimal? m3CFI2 = null, 
			string m3CFI3 = null, 
			string m3CFI4 = null, 
			string m3CFI5 = null, 
			string m3TXT1 = null, 
			string m3TXT2 = null, 
			int? m3ADRR = null, 
			int? m3ADRT = null, 
			string m3ADID = null, 
			DateTime? m3BRDT = null, 
			int? m3BRTI = null, 
			DateTime? m3MRDT = null, 
			int? m3MRTI = null, 
			DateTime? m3EQDT = null, 
			int? m3EQTI = null, 
			string m3EVTY = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3RESP = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("MWNO", m3MWNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CFI1))
				request.WithQueryParameter("CFI1", m3CFI1.Trim());
			if (m3CFI2.HasValue)
				request.WithQueryParameter("CFI2", m3CFI2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFI3))
				request.WithQueryParameter("CFI3", m3CFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI4))
				request.WithQueryParameter("CFI4", m3CFI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI5))
				request.WithQueryParameter("CFI5", m3CFI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT1))
				request.WithQueryParameter("TXT1", m3TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT2))
				request.WithQueryParameter("TXT2", m3TXT2.Trim());
			if (m3ADRR.HasValue)
				request.WithQueryParameter("ADRR", m3ADRR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3ADRT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (m3BRDT.HasValue)
				request.WithQueryParameter("BRDT", m3BRDT.Value.ToM3String());
			if (m3BRTI.HasValue)
				request.WithQueryParameter("BRTI", m3BRTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MRDT.HasValue)
				request.WithQueryParameter("MRDT", m3MRDT.Value.ToM3String());
			if (m3MRTI.HasValue)
				request.WithQueryParameter("MRTI", m3MRTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EQDT.HasValue)
				request.WithQueryParameter("EQDT", m3EQDT.Value.ToM3String());
			if (m3EQTI.HasValue)
				request.WithQueryParameter("EQTI", m3EQTI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EVTY))
				request.WithQueryParameter("EVTY", m3EVTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());

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
