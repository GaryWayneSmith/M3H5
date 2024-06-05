/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PMS100MI;
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
	/// Name: PMS100MI
	/// Component Name: ManufacturingOrder
	/// Description: Manufacturing order interface
	/// Version Release: 5ea7
	///</summary>
	public partial class PMS100MIResource : M3BaseResourceEndpoint
	{
		public PMS100MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PMS100MI";
			payloadFactory = new PayloadFactory();
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
		/// <param name="m3_MACH">Machine identity</param>
		/// <param name="m3_MACN">Macro order number</param>
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
			decimal? m3_MACN = null, 
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
			if (m3_MACN.HasValue)
				request.WithQueryParameter("MACN", m3_MACN.Value.ToString());
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
		/// <param name="m3_SCHN">Schedule number</param>
		/// <param name="m3_MACN">Macro order number</param>
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
			decimal? m3_SCHN = null, 
			decimal? m3_MACN = null, 
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
			if (m3_SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3_SCHN.Value.ToString());
			if (m3_MACN.HasValue)
				request.WithQueryParameter("MACN", m3_MACN.Value.ToString());

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
		/// Name AddMOComponent
		/// Description Add component to MO
		/// Version Release: 5ea5
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3_MTNO">Component number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_CNQT">Quantity</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_DWPO">Drawing position</param>
		/// <param name="m3_FXCD">Quantity relation</param>
		/// <param name="m3_WAPC">Normal waste percentage</param>
		/// <param name="m3_CRTM">Critical material</param>
		/// <param name="m3_BYPR">By/co-product code</param>
		/// <param name="m3_SPMT">Issue method</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_LGTH">Length</param>
		/// <param name="m3_WDTH">Width</param>
		/// <param name="m3_LWF1">Factor 1</param>
		/// <param name="m3_LWF2">Factor 2</param>
		/// <param name="m3_CMCD">Inheritance control</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_FMT1">Text</param>
		/// <param name="m3_FMT2">Technical reference</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_ACTS">Task element number</param>
		/// <param name="m3_PEUN">Product engineering U/M</param>
		/// <param name="m3_AADM">Add components - not in item master</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddMOComponentResponse></returns>
		/// <exception cref="M3Exception<AddMOComponentResponse>"></exception>
		public async Task<M3Response<AddMOComponentResponse>> AddMOComponent(
			string m3_FACI, 
			string m3_MFNO, 
			string m3_MTNO, 
			int? m3_CONO = null, 
			string m3_PRNO = null, 
			int? m3_MSEQ = null, 
			int? m3_OPNO = null, 
			decimal? m3_CNQT = null, 
			string m3_WHLO = null, 
			string m3_DWPO = null, 
			int? m3_FXCD = null, 
			int? m3_WAPC = null, 
			int? m3_CRTM = null, 
			int? m3_BYPR = null, 
			int? m3_SPMT = null, 
			string m3_WHSL = null, 
			int? m3_LGTH = null, 
			int? m3_WDTH = null, 
			decimal? m3_LWF1 = null, 
			decimal? m3_LWF2 = null, 
			int? m3_CMCD = null, 
			string m3_BANO = null, 
			string m3_FMT1 = null, 
			string m3_FMT2 = null, 
			decimal? m3_ATNR = null, 
			int? m3_ACTS = null, 
			string m3_PEUN = null, 
			int? m3_AADM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddMOComponent",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_MFNO))
				throw new ArgumentNullException("m3_MFNO");
			if (string.IsNullOrWhiteSpace(m3_MTNO))
				throw new ArgumentNullException("m3_MTNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("MFNO", m3_MFNO.Trim())
				.WithQueryParameter("MTNO", m3_MTNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_CNQT.HasValue)
				request.WithQueryParameter("CNQT", m3_CNQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DWPO))
				request.WithQueryParameter("DWPO", m3_DWPO.Trim());
			if (m3_FXCD.HasValue)
				request.WithQueryParameter("FXCD", m3_FXCD.Value.ToString());
			if (m3_WAPC.HasValue)
				request.WithQueryParameter("WAPC", m3_WAPC.Value.ToString());
			if (m3_CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3_CRTM.Value.ToString());
			if (m3_BYPR.HasValue)
				request.WithQueryParameter("BYPR", m3_BYPR.Value.ToString());
			if (m3_SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3_SPMT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (m3_LGTH.HasValue)
				request.WithQueryParameter("LGTH", m3_LGTH.Value.ToString());
			if (m3_WDTH.HasValue)
				request.WithQueryParameter("WDTH", m3_WDTH.Value.ToString());
			if (m3_LWF1.HasValue)
				request.WithQueryParameter("LWF1", m3_LWF1.Value.ToString());
			if (m3_LWF2.HasValue)
				request.WithQueryParameter("LWF2", m3_LWF2.Value.ToString());
			if (m3_CMCD.HasValue)
				request.WithQueryParameter("CMCD", m3_CMCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMT1))
				request.WithQueryParameter("FMT1", m3_FMT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMT2))
				request.WithQueryParameter("FMT2", m3_FMT2.Trim());
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (m3_ACTS.HasValue)
				request.WithQueryParameter("ACTS", m3_ACTS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PEUN))
				request.WithQueryParameter("PEUN", m3_PEUN.Trim());
			if (m3_AADM.HasValue)
				request.WithQueryParameter("AADM", m3_AADM.Value.ToString());

			// Execute the request
			var result = await Execute<AddMOComponentResponse>(
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
		/// Name AddMatLine
		/// Description Add material line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product (Required)</param>
		/// <param name="m3_MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3_MSEQ">Sequence number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_ACTS">Task element number</param>
		/// <param name="m3_MTNO">Component number</param>
		/// <param name="m3_DWPO">Drawing position</param>
		/// <param name="m3_CNQT">Quantity</param>
		/// <param name="m3_PEUN">Product engineering U/M</param>
		/// <param name="m3_FXCD">Quantity relation</param>
		/// <param name="m3_WAPC">Normal waste percentage</param>
		/// <param name="m3_BYPR">By/co-product code</param>
		/// <param name="m3_CRTM">Critical material</param>
		/// <param name="m3_SPMT">Issue method</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_LGTH">Length</param>
		/// <param name="m3_WDTH">Width</param>
		/// <param name="m3_LWF1">Factor 1</param>
		/// <param name="m3_LWF2">Factor 2</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CMCD">Inheritance control</param>
		/// <param name="m3_FMT1">Text</param>
		/// <param name="m3_FMT2">Technical reference</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddMatLine(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_MFNO, 
			int m3_MSEQ, 
			int? m3_CONO = null, 
			int? m3_OPNO = null, 
			int? m3_ACTS = null, 
			string m3_MTNO = null, 
			string m3_DWPO = null, 
			decimal? m3_CNQT = null, 
			string m3_PEUN = null, 
			int? m3_FXCD = null, 
			int? m3_WAPC = null, 
			int? m3_BYPR = null, 
			int? m3_CRTM = null, 
			int? m3_SPMT = null, 
			string m3_WHLO = null, 
			string m3_WHSL = null, 
			int? m3_LGTH = null, 
			int? m3_WDTH = null, 
			decimal? m3_LWF1 = null, 
			decimal? m3_LWF2 = null, 
			string m3_BANO = null, 
			int? m3_CMCD = null, 
			string m3_FMT1 = null, 
			string m3_FMT2 = null, 
			decimal? m3_ATNR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddMatLine",
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
				.WithQueryParameter("MSEQ", m3_MSEQ.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_ACTS.HasValue)
				request.WithQueryParameter("ACTS", m3_ACTS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MTNO))
				request.WithQueryParameter("MTNO", m3_MTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DWPO))
				request.WithQueryParameter("DWPO", m3_DWPO.Trim());
			if (m3_CNQT.HasValue)
				request.WithQueryParameter("CNQT", m3_CNQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PEUN))
				request.WithQueryParameter("PEUN", m3_PEUN.Trim());
			if (m3_FXCD.HasValue)
				request.WithQueryParameter("FXCD", m3_FXCD.Value.ToString());
			if (m3_WAPC.HasValue)
				request.WithQueryParameter("WAPC", m3_WAPC.Value.ToString());
			if (m3_BYPR.HasValue)
				request.WithQueryParameter("BYPR", m3_BYPR.Value.ToString());
			if (m3_CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3_CRTM.Value.ToString());
			if (m3_SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3_SPMT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (m3_LGTH.HasValue)
				request.WithQueryParameter("LGTH", m3_LGTH.Value.ToString());
			if (m3_WDTH.HasValue)
				request.WithQueryParameter("WDTH", m3_WDTH.Value.ToString());
			if (m3_LWF1.HasValue)
				request.WithQueryParameter("LWF1", m3_LWF1.Value.ToString());
			if (m3_LWF2.HasValue)
				request.WithQueryParameter("LWF2", m3_LWF2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_CMCD.HasValue)
				request.WithQueryParameter("CMCD", m3_CMCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FMT1))
				request.WithQueryParameter("FMT1", m3_FMT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMT2))
				request.WithQueryParameter("FMT2", m3_FMT2.Trim());
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());

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
		/// Name AddOperation
		/// Description Add operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product (Required)</param>
		/// <param name="m3_MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_OPDS">Operation description</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_PITI">Run time</param>
		/// <param name="m3_CTCD">Price and time quantity</param>
		/// <param name="m3_SETI">Setup time</param>
		/// <param name="m3_OSET">External setup time</param>
		/// <param name="m3_FXTI">Fixed time</param>
		/// <param name="m3_PRNM">Planned number of machines</param>
		/// <param name="m3_PRNP">Planned number of workers - run time</param>
		/// <param name="m3_SENP">Planned number of workers - setup</param>
		/// <param name="m3_PRDY">Production days</param>
		/// <param name="m3_AUIN">Automatic receipt</param>
		/// <param name="m3_AURP">Automatic operation reporting</param>
		/// <param name="m3_SCPC">Scrap percentage</param>
		/// <param name="m3_WLDE">Infinite/finite</param>
		/// <param name="m3_DOID">Document identity</param>
		/// <param name="m3_TOOL">Tool number</param>
		/// <param name="m3_PLLT">Lot number control</param>
		/// <param name="m3_CRTR">Critical resource</param>
		/// <param name="m3_LASK">Labor skill</param>
		/// <param name="m3_SWQT">Setup scrap</param>
		/// <param name="m3_CAMP">Number of labor tickets</param>
		/// <param name="m3_PIPR">Unit price</param>
		/// <param name="m3_WAFA">Time rate</param>
		/// <param name="m3_SEPR">Setup price</param>
		/// <param name="m3_WCRF">Time reference</param>
		/// <param name="m3_KIWG">Pay element</param>
		/// <param name="m3_INWE">Initial weight</param>
		/// <param name="m3_OPV3">Operation volume</param>
		/// <param name="m3_MFPR">Multiplication factor - manufacturing</param>
		/// <param name="m3_OPCM">Operation cost multiplier</param>
		/// <param name="m3_TXT1">Text line 1</param>
		/// <param name="m3_TXT2">Text line 2</param>
		/// <param name="m3_PLG6">Work center resource</param>
		/// <param name="m3_APON">App operation number</param>
		/// <param name="m3_NXOP">Next APP operation number</param>
		/// <param name="m3_SLAT">Transit unit of measure/Overlap code</param>
		/// <param name="m3_SLAC">Transport value in days</param>
		/// <param name="m3_POOC">Parallel operation overlap code</param>
		/// <param name="m3_RESR">Resource restriction</param>
		/// <param name="m3_PLGF">Forced resource</param>
		/// <param name="m3_PRET">Preparation time</param>
		/// <param name="m3_POTM">Post-operation time</param>
		/// <param name="m3_SPLK">Split method - operation</param>
		/// <param name="m3_SPLF">Split fixed rate</param>
		/// <param name="m3_SPLN">Number of operations after split</param>
		/// <param name="m3_SPSZ">Split quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddOperation(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_MFNO, 
			int? m3_CONO = null, 
			int? m3_OPNO = null, 
			string m3_PLGR = null, 
			string m3_OPDS = null, 
			string m3_DEPT = null, 
			string m3_REAR = null, 
			int? m3_PITI = null, 
			int? m3_CTCD = null, 
			int? m3_SETI = null, 
			int? m3_OSET = null, 
			int? m3_FXTI = null, 
			int? m3_PRNM = null, 
			int? m3_PRNP = null, 
			int? m3_SENP = null, 
			int? m3_PRDY = null, 
			int? m3_AUIN = null, 
			int? m3_AURP = null, 
			int? m3_SCPC = null, 
			int? m3_WLDE = null, 
			string m3_DOID = null, 
			string m3_TOOL = null, 
			int? m3_PLLT = null, 
			int? m3_CRTR = null, 
			string m3_LASK = null, 
			decimal? m3_SWQT = null, 
			int? m3_CAMP = null, 
			decimal? m3_PIPR = null, 
			decimal? m3_WAFA = null, 
			decimal? m3_SEPR = null, 
			string m3_WCRF = null, 
			int? m3_KIWG = null, 
			decimal? m3_INWE = null, 
			decimal? m3_OPV3 = null, 
			int? m3_MFPR = null, 
			int? m3_OPCM = null, 
			string m3_TXT1 = null, 
			string m3_TXT2 = null, 
			string m3_PLG6 = null, 
			int? m3_APON = null, 
			int? m3_NXOP = null, 
			string m3_SLAT = null, 
			decimal? m3_SLAC = null, 
			int? m3_POOC = null, 
			string m3_RESR = null, 
			string m3_PLGF = null, 
			int? m3_PRET = null, 
			int? m3_POTM = null, 
			int? m3_SPLK = null, 
			int? m3_SPLF = null, 
			int? m3_SPLN = null, 
			decimal? m3_SPSZ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddOperation",
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
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPDS))
				request.WithQueryParameter("OPDS", m3_OPDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (m3_PITI.HasValue)
				request.WithQueryParameter("PITI", m3_PITI.Value.ToString());
			if (m3_CTCD.HasValue)
				request.WithQueryParameter("CTCD", m3_CTCD.Value.ToString());
			if (m3_SETI.HasValue)
				request.WithQueryParameter("SETI", m3_SETI.Value.ToString());
			if (m3_OSET.HasValue)
				request.WithQueryParameter("OSET", m3_OSET.Value.ToString());
			if (m3_FXTI.HasValue)
				request.WithQueryParameter("FXTI", m3_FXTI.Value.ToString());
			if (m3_PRNM.HasValue)
				request.WithQueryParameter("PRNM", m3_PRNM.Value.ToString());
			if (m3_PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3_PRNP.Value.ToString());
			if (m3_SENP.HasValue)
				request.WithQueryParameter("SENP", m3_SENP.Value.ToString());
			if (m3_PRDY.HasValue)
				request.WithQueryParameter("PRDY", m3_PRDY.Value.ToString());
			if (m3_AUIN.HasValue)
				request.WithQueryParameter("AUIN", m3_AUIN.Value.ToString());
			if (m3_AURP.HasValue)
				request.WithQueryParameter("AURP", m3_AURP.Value.ToString());
			if (m3_SCPC.HasValue)
				request.WithQueryParameter("SCPC", m3_SCPC.Value.ToString());
			if (m3_WLDE.HasValue)
				request.WithQueryParameter("WLDE", m3_WLDE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOOL))
				request.WithQueryParameter("TOOL", m3_TOOL.Trim());
			if (m3_PLLT.HasValue)
				request.WithQueryParameter("PLLT", m3_PLLT.Value.ToString());
			if (m3_CRTR.HasValue)
				request.WithQueryParameter("CRTR", m3_CRTR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LASK))
				request.WithQueryParameter("LASK", m3_LASK.Trim());
			if (m3_SWQT.HasValue)
				request.WithQueryParameter("SWQT", m3_SWQT.Value.ToString());
			if (m3_CAMP.HasValue)
				request.WithQueryParameter("CAMP", m3_CAMP.Value.ToString());
			if (m3_PIPR.HasValue)
				request.WithQueryParameter("PIPR", m3_PIPR.Value.ToString());
			if (m3_WAFA.HasValue)
				request.WithQueryParameter("WAFA", m3_WAFA.Value.ToString());
			if (m3_SEPR.HasValue)
				request.WithQueryParameter("SEPR", m3_SEPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WCRF))
				request.WithQueryParameter("WCRF", m3_WCRF.Trim());
			if (m3_KIWG.HasValue)
				request.WithQueryParameter("KIWG", m3_KIWG.Value.ToString());
			if (m3_INWE.HasValue)
				request.WithQueryParameter("INWE", m3_INWE.Value.ToString());
			if (m3_OPV3.HasValue)
				request.WithQueryParameter("OPV3", m3_OPV3.Value.ToString());
			if (m3_MFPR.HasValue)
				request.WithQueryParameter("MFPR", m3_MFPR.Value.ToString());
			if (m3_OPCM.HasValue)
				request.WithQueryParameter("OPCM", m3_OPCM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TXT1))
				request.WithQueryParameter("TXT1", m3_TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT2))
				request.WithQueryParameter("TXT2", m3_TXT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLG6))
				request.WithQueryParameter("PLG6", m3_PLG6.Trim());
			if (m3_APON.HasValue)
				request.WithQueryParameter("APON", m3_APON.Value.ToString());
			if (m3_NXOP.HasValue)
				request.WithQueryParameter("NXOP", m3_NXOP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SLAT))
				request.WithQueryParameter("SLAT", m3_SLAT.Trim());
			if (m3_SLAC.HasValue)
				request.WithQueryParameter("SLAC", m3_SLAC.Value.ToString());
			if (m3_POOC.HasValue)
				request.WithQueryParameter("POOC", m3_POOC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESR))
				request.WithQueryParameter("RESR", m3_RESR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGF))
				request.WithQueryParameter("PLGF", m3_PLGF.Trim());
			if (m3_PRET.HasValue)
				request.WithQueryParameter("PRET", m3_PRET.Value.ToString());
			if (m3_POTM.HasValue)
				request.WithQueryParameter("POTM", m3_POTM.Value.ToString());
			if (m3_SPLK.HasValue)
				request.WithQueryParameter("SPLK", m3_SPLK.Value.ToString());
			if (m3_SPLF.HasValue)
				request.WithQueryParameter("SPLF", m3_SPLF.Value.ToString());
			if (m3_SPLN.HasValue)
				request.WithQueryParameter("SPLN", m3_SPLN.Value.ToString());
			if (m3_SPSZ.HasValue)
				request.WithQueryParameter("SPSZ", m3_SPSZ.Value.ToString());

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
		/// Name ChgAltMaterials
		/// Description Change Alternative Materials
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_MSEQ">Sequence number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_MTAL">Alternative material (Required)</param>
		/// <param name="m3_MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgAltMaterials(
			string m3_FACI, 
			string m3_PRNO, 
			int m3_MSEQ, 
			int m3_OPNO, 
			string m3_MTAL, 
			string m3_MFNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgAltMaterials",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_MTAL))
				throw new ArgumentNullException("m3_MTAL");
			if (string.IsNullOrWhiteSpace(m3_MFNO))
				throw new ArgumentNullException("m3_MFNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("MSEQ", m3_MSEQ.ToString())
				.WithQueryParameter("OPNO", m3_OPNO.ToString())
				.WithQueryParameter("MTAL", m3_MTAL.Trim())
				.WithQueryParameter("MFNO", m3_MFNO.Trim());

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
		/// Name CloseMO
		/// Description CloseMO
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_MFNO">Manufacturing order number</param>
		/// <param name="m3_SCHN">Schedule number</param>
		/// <param name="m3_DSP1">Flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CloseMO(
			string m3_MFNO = null, 
			decimal? m3_SCHN = null, 
			int? m3_DSP1 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CloseMO",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MFNO))
				request.WithQueryParameter("MFNO", m3_MFNO.Trim());
			if (m3_SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3_SCHN.Value.ToString());
			if (m3_DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3_DSP1.Value.ToString());

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
		/// Name CloseMtrlLine
		/// Description Close Material Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SCHN">Schedule number</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_MFNO">Manufacturing order number</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CloseMtrlLine(
			string m3_FACI, 
			int? m3_CONO = null, 
			decimal? m3_SCHN = null, 
			string m3_PRNO = null, 
			string m3_MFNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CloseMtrlLine",
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
			if (m3_SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3_SCHN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MFNO))
				request.WithQueryParameter("MFNO", m3_MFNO.Trim());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());

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
		/// Name CrtMO
		/// Description Create MO
		/// Version Release: 5ea5
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_STRT">Product structure type (Required)</param>
		/// <param name="m3_ORQA">Ordered quantity - alt (Required)</param>
		/// <param name="m3_WHST">Status (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_FIDT">Finish date</param>
		/// <param name="m3_BDCD">Explosion</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_WCLN">Production line</param>
		/// <param name="m3_RORC">Refrence order category</param>
		/// <param name="m3_RORN">Refrence order number</param>
		/// <param name="m3_RORL">Refrence order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_PRIO">Priority</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_NUC1">Number of put-away card</param>
		/// <param name="m3_NUC2">Number of material req</param>
		/// <param name="m3_NUC3">Number of labor ticket</param>
		/// <param name="m3_NUC4">Number of shop travele</param>
		/// <param name="m3_NUC5">Number of routing card</param>
		/// <param name="m3_NUC6">Number of picking list</param>
		/// <param name="m3_NUC7">Number of design document</param>
		/// <param name="m3_SCHN">Schedule number</param>
		/// <param name="m3_TX40">Text</param>
		/// <param name="m3_MAUN">Alternate U/M</param>
		/// <param name="m3_DSP6">WARNING-Ignore order multiple</param>
		/// <param name="m3_DSP1">WARNING - Date is earlier than today''s</param>
		/// <param name="m3_DSP2">WARNING - Start date may be earlier than</param>
		/// <param name="m3_DSP3">WARNING-Finish date &1 gives earliest fi</param>
		/// <param name="m3_DSP5">WARNING-Alternative routing identity</param>
		/// <param name="m3_DSP4">WARNING-</param>
		/// <param name="m3_DSP7">WARNING-</param>
		/// <param name="m3_DSP8">WARNING-</param>
		/// <param name="m3_AOID">Alternative routing</param>
		/// <param name="m3_MEXP">Manual expiration date</param>
		/// <param name="m3_MSTI">Start time</param>
		/// <param name="m3_MFTI">Finish time</param>
		/// <param name="m3_MFPC">Process</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_PCCO">Process code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CrtMOResponse></returns>
		/// <exception cref="M3Exception<CrtMOResponse>"></exception>
		public async Task<M3Response<CrtMOResponse>> CrtMO(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_STRT, 
			string m3_ORQA, 
			string m3_WHST, 
			int? m3_CONO = null, 
			DateTime? m3_STDT = null, 
			DateTime? m3_FIDT = null, 
			int? m3_BDCD = null, 
			string m3_RESP = null, 
			string m3_WHLO = null, 
			string m3_ORTY = null, 
			string m3_PROJ = null, 
			string m3_WCLN = null, 
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_BANO = null, 
			int? m3_PRIO = null, 
			string m3_ELNO = null, 
			int? m3_NUC1 = null, 
			int? m3_NUC2 = null, 
			int? m3_NUC3 = null, 
			int? m3_NUC4 = null, 
			int? m3_NUC5 = null, 
			int? m3_NUC6 = null, 
			int? m3_NUC7 = null, 
			decimal? m3_SCHN = null, 
			string m3_TX40 = null, 
			string m3_MAUN = null, 
			int? m3_DSP6 = null, 
			int? m3_DSP1 = null, 
			int? m3_DSP2 = null, 
			int? m3_DSP3 = null, 
			int? m3_DSP5 = null, 
			int? m3_DSP4 = null, 
			int? m3_DSP7 = null, 
			int? m3_DSP8 = null, 
			string m3_AOID = null, 
			DateTime? m3_MEXP = null, 
			int? m3_MSTI = null, 
			int? m3_MFTI = null, 
			string m3_MFPC = null, 
			string m3_WHSL = null, 
			int? m3_PCCO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CrtMO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_STRT))
				throw new ArgumentNullException("m3_STRT");
			if (string.IsNullOrWhiteSpace(m3_ORQA))
				throw new ArgumentNullException("m3_ORQA");
			if (string.IsNullOrWhiteSpace(m3_WHST))
				throw new ArgumentNullException("m3_WHST");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("STRT", m3_STRT.Trim())
				.WithQueryParameter("ORQA", m3_ORQA.Trim())
				.WithQueryParameter("WHST", m3_WHST.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3_FIDT.Value.ToM3String());
			if (m3_BDCD.HasValue)
				request.WithQueryParameter("BDCD", m3_BDCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WCLN))
				request.WithQueryParameter("WCLN", m3_WCLN.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_PRIO.HasValue)
				request.WithQueryParameter("PRIO", m3_PRIO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (m3_NUC1.HasValue)
				request.WithQueryParameter("NUC1", m3_NUC1.Value.ToString());
			if (m3_NUC2.HasValue)
				request.WithQueryParameter("NUC2", m3_NUC2.Value.ToString());
			if (m3_NUC3.HasValue)
				request.WithQueryParameter("NUC3", m3_NUC3.Value.ToString());
			if (m3_NUC4.HasValue)
				request.WithQueryParameter("NUC4", m3_NUC4.Value.ToString());
			if (m3_NUC5.HasValue)
				request.WithQueryParameter("NUC5", m3_NUC5.Value.ToString());
			if (m3_NUC6.HasValue)
				request.WithQueryParameter("NUC6", m3_NUC6.Value.ToString());
			if (m3_NUC7.HasValue)
				request.WithQueryParameter("NUC7", m3_NUC7.Value.ToString());
			if (m3_SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3_SCHN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MAUN))
				request.WithQueryParameter("MAUN", m3_MAUN.Trim());
			if (m3_DSP6.HasValue)
				request.WithQueryParameter("DSP6", m3_DSP6.Value.ToString());
			if (m3_DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3_DSP1.Value.ToString());
			if (m3_DSP2.HasValue)
				request.WithQueryParameter("DSP2", m3_DSP2.Value.ToString());
			if (m3_DSP3.HasValue)
				request.WithQueryParameter("DSP3", m3_DSP3.Value.ToString());
			if (m3_DSP5.HasValue)
				request.WithQueryParameter("DSP5", m3_DSP5.Value.ToString());
			if (m3_DSP4.HasValue)
				request.WithQueryParameter("DSP4", m3_DSP4.Value.ToString());
			if (m3_DSP7.HasValue)
				request.WithQueryParameter("DSP7", m3_DSP7.Value.ToString());
			if (m3_DSP8.HasValue)
				request.WithQueryParameter("DSP8", m3_DSP8.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AOID))
				request.WithQueryParameter("AOID", m3_AOID.Trim());
			if (m3_MEXP.HasValue)
				request.WithQueryParameter("MEXP", m3_MEXP.Value.ToM3String());
			if (m3_MSTI.HasValue)
				request.WithQueryParameter("MSTI", m3_MSTI.Value.ToString());
			if (m3_MFTI.HasValue)
				request.WithQueryParameter("MFTI", m3_MFTI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MFPC))
				request.WithQueryParameter("MFPC", m3_MFPC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (m3_PCCO.HasValue)
				request.WithQueryParameter("PCCO", m3_PCCO.Value.ToString());

			// Execute the request
			var result = await Execute<CrtMOResponse>(
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
		/// Name DltMO
		/// Description Delete workorder
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltMO(
			string m3_MFNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltMO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MFNO))
				throw new ArgumentNullException("m3_MFNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MFNO", m3_MFNO.Trim());

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
		/// Name DltMOComponent
		/// Description Delete component from  MO
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_MFNO">Manufacturing order number</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltMOComponent(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_MFNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltMOComponent",
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
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());

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
		/// Name DltMatLine
		/// Description Delete material line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_MFNO">Manufacturing order number</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_MTNO">Component number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltMatLine(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_MFNO = null, 
			int? m3_MSEQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltMatLine",
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
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
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
		/// Name DltOperation
		/// Description Delete operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_MFNO">Manufacturing order number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltOperation(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_MFNO = null, 
			int? m3_OPNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltOperation",
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
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
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
		/// Description Get one manufacturing order
		/// Version Release: 5ea7
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
		/// Name GetMatLine
		/// Description Get material line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product (Required)</param>
		/// <param name="m3_MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3_MSEQ">Sequence number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMatLineResponse></returns>
		/// <exception cref="M3Exception<GetMatLineResponse>"></exception>
		public async Task<M3Response<GetMatLineResponse>> GetMatLine(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_MFNO, 
			int m3_MSEQ, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMatLine",
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
				.WithQueryParameter("MSEQ", m3_MSEQ.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetMatLineResponse>(
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
		/// Name GetOperation
		/// Description Get operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product (Required)</param>
		/// <param name="m3_MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOperationResponse></returns>
		/// <exception cref="M3Exception<GetOperationResponse>"></exception>
		public async Task<M3Response<GetOperationResponse>> GetOperation(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_MFNO, 
			int? m3_CONO = null, 
			int? m3_OPNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetOperation",
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
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());

			// Execute the request
			var result = await Execute<GetOperationResponse>(
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
		/// Name LstByRORN
		/// Description List by reference order number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RORC">Reference order category (Required)</param>
		/// <param name="m3_RORN">Reference order number (Required)</param>
		/// <param name="m3_RORL">Reference order line (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByRORNResponse></returns>
		/// <exception cref="M3Exception<LstByRORNResponse>"></exception>
		public async Task<M3Response<LstByRORNResponse>> LstByRORN(
			int m3_RORC, 
			string m3_RORN, 
			int m3_RORL, 
			int? m3_CONO = null, 
			int? m3_RORX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByRORN",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RORN))
				throw new ArgumentNullException("m3_RORN");

			// Set mandatory parameters
			request
				.WithQueryParameter("RORC", m3_RORC.ToString())
				.WithQueryParameter("RORN", m3_RORN.Trim())
				.WithQueryParameter("RORL", m3_RORL.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());

			// Execute the request
			var result = await Execute<LstByRORNResponse>(
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
		/// Name Reschedule
		/// Description Change workorder date and quantity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3_ORQA">Ordered quantity - alt (Required)</param>
		/// <param name="m3_WLDE">Infinte/finite (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_FIDT">Finish date</param>
		/// <param name="m3_PRIO">Priority</param>
		/// <param name="m3_DSP1">Warning -Date is earlier then to date.</param>
		/// <param name="m3_DSP2">WARNING - MO connected to order number</param>
		/// <param name="m3_DSP3">WARNING - This order contains subcontrac</param>
		/// <param name="m3_DSP4">WARNING - Quantity ordered is not divisi</param>
		/// <param name="m3_DSP5">WARNING - This order has previously been</param>
		/// <param name="m3_DSP6">WARNING - Operations are have been start</param>
		/// <param name="m3_DSP7">WARNING - This order has previously been</param>
		/// <param name="m3_DSP8">WARNING - Operations have been started</param>
		/// <param name="m3_MEXP">Manual expiration date</param>
		/// <param name="m3_MSTI">Start time</param>
		/// <param name="m3_MFTI">Finish time</param>
		/// <param name="m3_RPLL">Reschedule lower levels</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Reschedule(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_MFNO, 
			string m3_ORQA, 
			int m3_WLDE, 
			int? m3_CONO = null, 
			DateTime? m3_STDT = null, 
			DateTime? m3_FIDT = null, 
			int? m3_PRIO = null, 
			int? m3_DSP1 = null, 
			int? m3_DSP2 = null, 
			int? m3_DSP3 = null, 
			int? m3_DSP4 = null, 
			int? m3_DSP5 = null, 
			int? m3_DSP6 = null, 
			int? m3_DSP7 = null, 
			int? m3_DSP8 = null, 
			DateTime? m3_MEXP = null, 
			int? m3_MSTI = null, 
			int? m3_MFTI = null, 
			int? m3_RPLL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Reschedule",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_MFNO))
				throw new ArgumentNullException("m3_MFNO");
			if (string.IsNullOrWhiteSpace(m3_ORQA))
				throw new ArgumentNullException("m3_ORQA");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("MFNO", m3_MFNO.Trim())
				.WithQueryParameter("ORQA", m3_ORQA.Trim())
				.WithQueryParameter("WLDE", m3_WLDE.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3_FIDT.Value.ToM3String());
			if (m3_PRIO.HasValue)
				request.WithQueryParameter("PRIO", m3_PRIO.Value.ToString());
			if (m3_DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3_DSP1.Value.ToString());
			if (m3_DSP2.HasValue)
				request.WithQueryParameter("DSP2", m3_DSP2.Value.ToString());
			if (m3_DSP3.HasValue)
				request.WithQueryParameter("DSP3", m3_DSP3.Value.ToString());
			if (m3_DSP4.HasValue)
				request.WithQueryParameter("DSP4", m3_DSP4.Value.ToString());
			if (m3_DSP5.HasValue)
				request.WithQueryParameter("DSP5", m3_DSP5.Value.ToString());
			if (m3_DSP6.HasValue)
				request.WithQueryParameter("DSP6", m3_DSP6.Value.ToString());
			if (m3_DSP7.HasValue)
				request.WithQueryParameter("DSP7", m3_DSP7.Value.ToString());
			if (m3_DSP8.HasValue)
				request.WithQueryParameter("DSP8", m3_DSP8.Value.ToString());
			if (m3_MEXP.HasValue)
				request.WithQueryParameter("MEXP", m3_MEXP.Value.ToM3String());
			if (m3_MSTI.HasValue)
				request.WithQueryParameter("MSTI", m3_MSTI.Value.ToString());
			if (m3_MFTI.HasValue)
				request.WithQueryParameter("MFTI", m3_MFTI.Value.ToString());
			if (m3_RPLL.HasValue)
				request.WithQueryParameter("RPLL", m3_RPLL.Value.ToString());

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
		/// Name SearchMO
		/// Description Search Manufaturing order via LES
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchMOResponse></returns>
		/// <exception cref="M3Exception<SearchMOResponse>"></exception>
		public async Task<M3Response<SearchMOResponse>> SearchMO(
			string m3_SQRY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchMO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SQRY))
				throw new ArgumentNullException("m3_SQRY");

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3_SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchMOResponse>(
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
		/// Name SearchMaterial
		/// Description Search Material
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchMaterialResponse></returns>
		/// <exception cref="M3Exception<SearchMaterialResponse>"></exception>
		public async Task<M3Response<SearchMaterialResponse>> SearchMaterial(
			string m3_SQRY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchMaterial",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SQRY))
				throw new ArgumentNullException("m3_SQRY");

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3_SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchMaterialResponse>(
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
		/// Name SearchOperation
		/// Description Search Operation
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchOperationResponse></returns>
		/// <exception cref="M3Exception<SearchOperationResponse>"></exception>
		public async Task<M3Response<SearchOperationResponse>> SearchOperation(
			string m3_SQRY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchOperation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SQRY))
				throw new ArgumentNullException("m3_SQRY");

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3_SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchOperationResponse>(
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
		/// Name SelConfigAttr
		/// Description Selection of attributes
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACF">From facility (Required)</param>
		/// <param name="m3_FACT">To facility (Required)</param>
		/// <param name="m3_STSF">From status (Required)</param>
		/// <param name="m3_STST">To status (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_DATE">Timestamp - Date</param>
		/// <param name="m3_TIME">Timestamp - Time</param>
		/// <param name="m3_SCHH">Scheduling horizon</param>
		/// <param name="m3_FWHS">From warehouse</param>
		/// <param name="m3_TWHS">To warehouse</param>
		/// <param name="m3_WHGR">Warehouse Group</param>
		/// <param name="m3_APIP">APS-policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelConfigAttrResponse></returns>
		/// <exception cref="M3Exception<SelConfigAttrResponse>"></exception>
		public async Task<M3Response<SelConfigAttrResponse>> SelConfigAttr(
			string m3_FACF, 
			string m3_FACT, 
			int m3_STSF, 
			int m3_STST, 
			int? m3_CONO = null, 
			string m3_REAR = null, 
			DateTime? m3_DATE = null, 
			int? m3_TIME = null, 
			int? m3_SCHH = null, 
			string m3_FWHS = null, 
			string m3_TWHS = null, 
			string m3_WHGR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelConfigAttr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACF))
				throw new ArgumentNullException("m3_FACF");
			if (string.IsNullOrWhiteSpace(m3_FACT))
				throw new ArgumentNullException("m3_FACT");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACF", m3_FACF.Trim())
				.WithQueryParameter("FACT", m3_FACT.Trim())
				.WithQueryParameter("STSF", m3_STSF.ToString())
				.WithQueryParameter("STST", m3_STST.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
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

			// Execute the request
			var result = await Execute<SelConfigAttrResponse>(
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
		/// Name SelFashionAttr
		/// Description Selection of fashion attributes
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACF">From facility (Required)</param>
		/// <param name="m3_FACT">To facility (Required)</param>
		/// <param name="m3_STSF">From status (Required)</param>
		/// <param name="m3_STST">To status (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_DATE">Timestamp - Date</param>
		/// <param name="m3_TIME">Timestamp - Time</param>
		/// <param name="m3_SCHH">Scheduling horizon</param>
		/// <param name="m3_FWHS">From warehouse</param>
		/// <param name="m3_TWHS">To warehouse</param>
		/// <param name="m3_WHGR">Warehouse Group</param>
		/// <param name="m3_APIP">APS-policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelFashionAttrResponse></returns>
		/// <exception cref="M3Exception<SelFashionAttrResponse>"></exception>
		public async Task<M3Response<SelFashionAttrResponse>> SelFashionAttr(
			string m3_FACF, 
			string m3_FACT, 
			int m3_STSF, 
			int m3_STST, 
			int? m3_CONO = null, 
			string m3_REAR = null, 
			DateTime? m3_DATE = null, 
			int? m3_TIME = null, 
			int? m3_SCHH = null, 
			string m3_FWHS = null, 
			string m3_TWHS = null, 
			string m3_WHGR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelFashionAttr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACF))
				throw new ArgumentNullException("m3_FACF");
			if (string.IsNullOrWhiteSpace(m3_FACT))
				throw new ArgumentNullException("m3_FACT");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACF", m3_FACF.Trim())
				.WithQueryParameter("FACT", m3_FACT.Trim())
				.WithQueryParameter("STSF", m3_STSF.ToString())
				.WithQueryParameter("STST", m3_STST.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
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

			// Execute the request
			var result = await Execute<SelFashionAttrResponse>(
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
		/// Name SelMatByHead
		/// Description Selection of manufacturing order materials By Head
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_FSTS">From Status</param>
		/// <param name="m3_TSTS">From Status</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_REAR">Planning Area</param>
		/// <param name="m3_DATE">Timestamp - Date</param>
		/// <param name="m3_TIME">Timestamp - Time</param>
		/// <param name="m3_SCHH">Scheduling Horizon</param>
		/// <param name="m3_APIP">APS - Policy</param>
		/// <param name="m3_OPCO">Exclude finish marked</param>
		/// <param name="m3_SINV">Select only inv.acc(STCD) equals one</param>
		/// <param name="m3_DBYP">De-select Byproducts</param>
		/// <param name="m3_SALT">Include alternative materials</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelMatByHeadResponse></returns>
		/// <exception cref="M3Exception<SelMatByHeadResponse>"></exception>
		public async Task<M3Response<SelMatByHeadResponse>> SelMatByHead(
			string m3_FACI, 
			int? m3_CONO = null, 
			string m3_WHLO = null, 
			int? m3_FSTS = null, 
			int? m3_TSTS = null, 
			string m3_WHGR = null, 
			string m3_REAR = null, 
			DateTime? m3_DATE = null, 
			int? m3_TIME = null, 
			int? m3_SCHH = null, 
			string m3_APIP = null, 
			int? m3_OPCO = null, 
			int? m3_SINV = null, 
			int? m3_DBYP = null, 
			int? m3_SALT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelMatByHead",
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
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_FSTS.HasValue)
				request.WithQueryParameter("FSTS", m3_FSTS.Value.ToString());
			if (m3_TSTS.HasValue)
				request.WithQueryParameter("TSTS", m3_TSTS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (m3_DATE.HasValue)
				request.WithQueryParameter("DATE", m3_DATE.Value.ToM3String());
			if (m3_TIME.HasValue)
				request.WithQueryParameter("TIME", m3_TIME.Value.ToString());
			if (m3_SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3_SCHH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());
			if (m3_OPCO.HasValue)
				request.WithQueryParameter("OPCO", m3_OPCO.Value.ToString());
			if (m3_SINV.HasValue)
				request.WithQueryParameter("SINV", m3_SINV.Value.ToString());
			if (m3_DBYP.HasValue)
				request.WithQueryParameter("DBYP", m3_DBYP.Value.ToString());
			if (m3_SALT.HasValue)
				request.WithQueryParameter("SALT", m3_SALT.Value.ToString());

			// Execute the request
			var result = await Execute<SelMatByHeadResponse>(
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
		/// Description Selection of manufacturing order materials
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_MFNO">Manufacturing order number</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_SINV">Select only inv.acc(STCD) equals one</param>
		/// <param name="m3_DBYP">De-select Byproducts</param>
		/// <param name="m3_SALT">Includ alternative materials</param>
		/// <param name="m3_DFRM">Deselect finish reported materials</param>
		/// <param name="m3_APIP">APS-policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelMaterialsResponse></returns>
		/// <exception cref="M3Exception<SelMaterialsResponse>"></exception>
		public async Task<M3Response<SelMaterialsResponse>> SelMaterials(
			string m3_FACI, 
			int? m3_CONO = null, 
			string m3_PRNO = null, 
			string m3_MFNO = null, 
			string m3_WHGR = null, 
			int? m3_SINV = null, 
			int? m3_DBYP = null, 
			int? m3_SALT = null, 
			int? m3_DFRM = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (m3_SINV.HasValue)
				request.WithQueryParameter("SINV", m3_SINV.Value.ToString());
			if (m3_DBYP.HasValue)
				request.WithQueryParameter("DBYP", m3_DBYP.Value.ToString());
			if (m3_SALT.HasValue)
				request.WithQueryParameter("SALT", m3_SALT.Value.ToString());
			if (m3_DFRM.HasValue)
				request.WithQueryParameter("DFRM", m3_DFRM.Value.ToString());
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
		/// Name SelOpeByHead
		/// Description Selection of operations By Head
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_FSTS">From Status</param>
		/// <param name="m3_TSTS">To Status</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_DATE">Timestamp - Date</param>
		/// <param name="m3_TIME">Timestamp - Time</param>
		/// <param name="m3_SCHH">Scheduling Horizon</param>
		/// <param name="m3_APIP">APS - Policy</param>
		/// <param name="m3_OPCO">Check Operations completed</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelOpeByHeadResponse></returns>
		/// <exception cref="M3Exception<SelOpeByHeadResponse>"></exception>
		public async Task<M3Response<SelOpeByHeadResponse>> SelOpeByHead(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			int? m3_FSTS = null, 
			int? m3_TSTS = null, 
			string m3_WHGR = null, 
			string m3_REAR = null, 
			DateTime? m3_DATE = null, 
			int? m3_TIME = null, 
			int? m3_SCHH = null, 
			string m3_APIP = null, 
			int? m3_OPCO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelOpeByHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_FSTS.HasValue)
				request.WithQueryParameter("FSTS", m3_FSTS.Value.ToString());
			if (m3_TSTS.HasValue)
				request.WithQueryParameter("TSTS", m3_TSTS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (m3_DATE.HasValue)
				request.WithQueryParameter("DATE", m3_DATE.Value.ToM3String());
			if (m3_TIME.HasValue)
				request.WithQueryParameter("TIME", m3_TIME.Value.ToString());
			if (m3_SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3_SCHH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());
			if (m3_OPCO.HasValue)
				request.WithQueryParameter("OPCO", m3_OPCO.Value.ToString());

			// Execute the request
			var result = await Execute<SelOpeByHeadResponse>(
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
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_MFNO">Manufacturing order number</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelOperationsResponse></returns>
		/// <exception cref="M3Exception<SelOperationsResponse>"></exception>
		public async Task<M3Response<SelOperationsResponse>> SelOperations(
			string m3_FACI, 
			int? m3_CONO = null, 
			string m3_PRNO = null, 
			string m3_MFNO = null, 
			string m3_REAR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelOperations",
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
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());

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
		/// Name SelOrderHead
		/// Description Selection of Order Headers
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_FSTS">From Status</param>
		/// <param name="m3_TSTS">To Status</param>
		/// <param name="m3_WHGR">Warehouse Group</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_DATE">Timestamp - Date</param>
		/// <param name="m3_TIME">Timestamp - Time</param>
		/// <param name="m3_SCHH">Scheduling horizon</param>
		/// <param name="m3_APIP">APS-policy</param>
		/// <param name="m3_OPCO">Check Ope completed- Field not used</param>
		/// <param name="m3_SLEN">Select Endproducts (1=YES)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelOrderHeadResponse></returns>
		/// <exception cref="M3Exception<SelOrderHeadResponse>"></exception>
		public async Task<M3Response<SelOrderHeadResponse>> SelOrderHead(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			int? m3_FSTS = null, 
			int? m3_TSTS = null, 
			string m3_WHGR = null, 
			string m3_REAR = null, 
			DateTime? m3_DATE = null, 
			int? m3_TIME = null, 
			int? m3_SCHH = null, 
			string m3_APIP = null, 
			int? m3_OPCO = null, 
			int? m3_SLEN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelOrderHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_FSTS.HasValue)
				request.WithQueryParameter("FSTS", m3_FSTS.Value.ToString());
			if (m3_TSTS.HasValue)
				request.WithQueryParameter("TSTS", m3_TSTS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (m3_DATE.HasValue)
				request.WithQueryParameter("DATE", m3_DATE.Value.ToM3String());
			if (m3_TIME.HasValue)
				request.WithQueryParameter("TIME", m3_TIME.Value.ToString());
			if (m3_SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3_SCHH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());
			if (m3_OPCO.HasValue)
				request.WithQueryParameter("OPCO", m3_OPCO.Value.ToString());
			if (m3_SLEN.HasValue)
				request.WithQueryParameter("SLEN", m3_SLEN.Value.ToString());

			// Execute the request
			var result = await Execute<SelOrderHeadResponse>(
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
		/// Description Selection of manufacturing orders
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACF">From facility (Required)</param>
		/// <param name="m3_FACT">To facility (Required)</param>
		/// <param name="m3_STSF">From status (Required)</param>
		/// <param name="m3_STST">To status (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_DATE">Timestamp - Date</param>
		/// <param name="m3_TIME">Timestamp - Time</param>
		/// <param name="m3_SCHH">Scheduling horizon</param>
		/// <param name="m3_FWHS">From warehouse</param>
		/// <param name="m3_TWHS">To warehouse</param>
		/// <param name="m3_WHGR">Warehouse Group</param>
		/// <param name="m3_SLEN">Select Endproducts (1=YES)</param>
		/// <param name="m3_APIP">APS-policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectResponse></returns>
		/// <exception cref="M3Exception<SelectResponse>"></exception>
		public async Task<M3Response<SelectResponse>> Select(
			string m3_FACF, 
			string m3_FACT, 
			int m3_STSF, 
			int m3_STST, 
			int? m3_CONO = null, 
			string m3_REAR = null, 
			DateTime? m3_DATE = null, 
			int? m3_TIME = null, 
			int? m3_SCHH = null, 
			string m3_FWHS = null, 
			string m3_TWHS = null, 
			string m3_WHGR = null, 
			int? m3_SLEN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Select",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACF))
				throw new ArgumentNullException("m3_FACF");
			if (string.IsNullOrWhiteSpace(m3_FACT))
				throw new ArgumentNullException("m3_FACT");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACF", m3_FACF.Trim())
				.WithQueryParameter("FACT", m3_FACT.Trim())
				.WithQueryParameter("STSF", m3_STSF.ToString())
				.WithQueryParameter("STST", m3_STST.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
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
			if (m3_SLEN.HasValue)
				request.WithQueryParameter("SLEN", m3_SLEN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());

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
		/// <param name="m3_MACH">Machine identity</param>
		/// <param name="m3_MACN">Macro order number</param>
		/// <param name="m3_RBUP">Remaining buffer percentage</param>
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
			decimal? m3_SCHN = null, 
			long? m3_SCHS = null, 
			string m3_MACH = null, 
			decimal? m3_MACN = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_MACH))
				request.WithQueryParameter("MACH", m3_MACH.Trim());
			if (m3_MACN.HasValue)
				request.WithQueryParameter("MACN", m3_MACN.Value.ToString());
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
		/// <param name="m3_SCHN">Schedule number</param>
		/// <param name="m3_MACN">Macro order number</param>
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
			decimal? m3_SCHN = null, 
			decimal? m3_MACN = null, 
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
			if (m3_SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3_SCHN.Value.ToString());
			if (m3_MACN.HasValue)
				request.WithQueryParameter("MACN", m3_MACN.Value.ToString());

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
		/// Name TriggerUpdatJob
		/// Description Starts update processing
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> TriggerUpdatJob(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/TriggerUpdatJob",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());

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
		/// Name UpdMatLine
		/// Description Update material line
		/// Version Release: 5ea5
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product (Required)</param>
		/// <param name="m3_MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3_MSEQ">Sequence number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_ACTS">Task element number</param>
		/// <param name="m3_MTNO">Component number</param>
		/// <param name="m3_DWPO">Drawing position</param>
		/// <param name="m3_CNQT">Quantity</param>
		/// <param name="m3_PEUN">Product engineering U/M</param>
		/// <param name="m3_FXCD">Quantity relation</param>
		/// <param name="m3_WAPC">Normal waste percentage</param>
		/// <param name="m3_BYPR">By/co-product code</param>
		/// <param name="m3_CRTM">Critical material</param>
		/// <param name="m3_SPMT">Issue method</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_LGTH">Length</param>
		/// <param name="m3_WDTH">Width</param>
		/// <param name="m3_LWF1">Factor 1</param>
		/// <param name="m3_LWF2">Factor 2</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CMCD">Inheritance control</param>
		/// <param name="m3_FMT1">Text</param>
		/// <param name="m3_FMT2">Technical reference</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_AADM">Add components - not in item master</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdMatLine(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_MFNO, 
			int m3_MSEQ, 
			int? m3_CONO = null, 
			int? m3_OPNO = null, 
			int? m3_ACTS = null, 
			string m3_MTNO = null, 
			string m3_DWPO = null, 
			decimal? m3_CNQT = null, 
			string m3_PEUN = null, 
			int? m3_FXCD = null, 
			int? m3_WAPC = null, 
			int? m3_BYPR = null, 
			int? m3_CRTM = null, 
			int? m3_SPMT = null, 
			string m3_WHLO = null, 
			string m3_WHSL = null, 
			int? m3_LGTH = null, 
			int? m3_WDTH = null, 
			decimal? m3_LWF1 = null, 
			decimal? m3_LWF2 = null, 
			string m3_BANO = null, 
			int? m3_CMCD = null, 
			string m3_FMT1 = null, 
			string m3_FMT2 = null, 
			decimal? m3_ATNR = null, 
			int? m3_AADM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdMatLine",
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
				.WithQueryParameter("MSEQ", m3_MSEQ.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_ACTS.HasValue)
				request.WithQueryParameter("ACTS", m3_ACTS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MTNO))
				request.WithQueryParameter("MTNO", m3_MTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DWPO))
				request.WithQueryParameter("DWPO", m3_DWPO.Trim());
			if (m3_CNQT.HasValue)
				request.WithQueryParameter("CNQT", m3_CNQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PEUN))
				request.WithQueryParameter("PEUN", m3_PEUN.Trim());
			if (m3_FXCD.HasValue)
				request.WithQueryParameter("FXCD", m3_FXCD.Value.ToString());
			if (m3_WAPC.HasValue)
				request.WithQueryParameter("WAPC", m3_WAPC.Value.ToString());
			if (m3_BYPR.HasValue)
				request.WithQueryParameter("BYPR", m3_BYPR.Value.ToString());
			if (m3_CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3_CRTM.Value.ToString());
			if (m3_SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3_SPMT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (m3_LGTH.HasValue)
				request.WithQueryParameter("LGTH", m3_LGTH.Value.ToString());
			if (m3_WDTH.HasValue)
				request.WithQueryParameter("WDTH", m3_WDTH.Value.ToString());
			if (m3_LWF1.HasValue)
				request.WithQueryParameter("LWF1", m3_LWF1.Value.ToString());
			if (m3_LWF2.HasValue)
				request.WithQueryParameter("LWF2", m3_LWF2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_CMCD.HasValue)
				request.WithQueryParameter("CMCD", m3_CMCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FMT1))
				request.WithQueryParameter("FMT1", m3_FMT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMT2))
				request.WithQueryParameter("FMT2", m3_FMT2.Trim());
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (m3_AADM.HasValue)
				request.WithQueryParameter("AADM", m3_AADM.Value.ToString());

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
		/// Name UpdOperation
		/// Description Update material line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product (Required)</param>
		/// <param name="m3_MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_OPDS">Operation description</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_PITI">Run time</param>
		/// <param name="m3_CTCD">Price and time quantity</param>
		/// <param name="m3_SETI">Setup time</param>
		/// <param name="m3_OSET">External setup time</param>
		/// <param name="m3_FXTI">Fixed time</param>
		/// <param name="m3_PRNM">Planned number of machines</param>
		/// <param name="m3_PRNP">Planned number of workers - run time</param>
		/// <param name="m3_SENP">Planned number of workers - setup</param>
		/// <param name="m3_PRDY">Production days</param>
		/// <param name="m3_AUIN">Automatic receipt</param>
		/// <param name="m3_AURP">Automatic operation reporting</param>
		/// <param name="m3_SCPC">Scrap percentage</param>
		/// <param name="m3_WLDE">Infinite/finite</param>
		/// <param name="m3_DOID">Document identity</param>
		/// <param name="m3_TOOL">Tool number</param>
		/// <param name="m3_PLLT">Lot number control</param>
		/// <param name="m3_CRTR">Critical resource</param>
		/// <param name="m3_LASK">Labor skill</param>
		/// <param name="m3_SWQT">Setup scrap</param>
		/// <param name="m3_CAMP">Number of labor tickets</param>
		/// <param name="m3_PIPR">Unit price</param>
		/// <param name="m3_WAFA">Time rate</param>
		/// <param name="m3_SEPR">Setup price</param>
		/// <param name="m3_WCRF">Time reference</param>
		/// <param name="m3_KIWG">Pay element</param>
		/// <param name="m3_INWE">Initial weight</param>
		/// <param name="m3_OPV3">Operation volume</param>
		/// <param name="m3_MFPR">Multiplication factor - manufacturing</param>
		/// <param name="m3_OPCM">Operation cost multiplier</param>
		/// <param name="m3_TXT1">Text line 1</param>
		/// <param name="m3_TXT2">Text line 2</param>
		/// <param name="m3_PLG6">Work center resource</param>
		/// <param name="m3_APON">App operation number</param>
		/// <param name="m3_NXOP">Next APP operation number</param>
		/// <param name="m3_SLAT">Transit unit of measure/Overlap code</param>
		/// <param name="m3_SLAC">Transport value in days</param>
		/// <param name="m3_POOC">Parallel operation overlap code</param>
		/// <param name="m3_RESR">Resource restriction</param>
		/// <param name="m3_PLGF">Forced resource</param>
		/// <param name="m3_PRET">Preparation time</param>
		/// <param name="m3_POTM">Post-operation time</param>
		/// <param name="m3_SPLK">Split method - operation</param>
		/// <param name="m3_SPLF">Split fixed rate</param>
		/// <param name="m3_SPLN">Number of operations after split</param>
		/// <param name="m3_SPSZ">Split quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdOperation(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_MFNO, 
			int? m3_CONO = null, 
			int? m3_OPNO = null, 
			string m3_PLGR = null, 
			string m3_OPDS = null, 
			string m3_DEPT = null, 
			string m3_REAR = null, 
			int? m3_PITI = null, 
			int? m3_CTCD = null, 
			int? m3_SETI = null, 
			int? m3_OSET = null, 
			int? m3_FXTI = null, 
			int? m3_PRNM = null, 
			int? m3_PRNP = null, 
			int? m3_SENP = null, 
			int? m3_PRDY = null, 
			int? m3_AUIN = null, 
			int? m3_AURP = null, 
			int? m3_SCPC = null, 
			int? m3_WLDE = null, 
			string m3_DOID = null, 
			string m3_TOOL = null, 
			int? m3_PLLT = null, 
			int? m3_CRTR = null, 
			string m3_LASK = null, 
			decimal? m3_SWQT = null, 
			int? m3_CAMP = null, 
			decimal? m3_PIPR = null, 
			decimal? m3_WAFA = null, 
			decimal? m3_SEPR = null, 
			string m3_WCRF = null, 
			int? m3_KIWG = null, 
			decimal? m3_INWE = null, 
			decimal? m3_OPV3 = null, 
			int? m3_MFPR = null, 
			int? m3_OPCM = null, 
			string m3_TXT1 = null, 
			string m3_TXT2 = null, 
			string m3_PLG6 = null, 
			int? m3_APON = null, 
			int? m3_NXOP = null, 
			string m3_SLAT = null, 
			decimal? m3_SLAC = null, 
			int? m3_POOC = null, 
			string m3_RESR = null, 
			string m3_PLGF = null, 
			int? m3_PRET = null, 
			int? m3_POTM = null, 
			int? m3_SPLK = null, 
			int? m3_SPLF = null, 
			int? m3_SPLN = null, 
			decimal? m3_SPSZ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdOperation",
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
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPDS))
				request.WithQueryParameter("OPDS", m3_OPDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (m3_PITI.HasValue)
				request.WithQueryParameter("PITI", m3_PITI.Value.ToString());
			if (m3_CTCD.HasValue)
				request.WithQueryParameter("CTCD", m3_CTCD.Value.ToString());
			if (m3_SETI.HasValue)
				request.WithQueryParameter("SETI", m3_SETI.Value.ToString());
			if (m3_OSET.HasValue)
				request.WithQueryParameter("OSET", m3_OSET.Value.ToString());
			if (m3_FXTI.HasValue)
				request.WithQueryParameter("FXTI", m3_FXTI.Value.ToString());
			if (m3_PRNM.HasValue)
				request.WithQueryParameter("PRNM", m3_PRNM.Value.ToString());
			if (m3_PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3_PRNP.Value.ToString());
			if (m3_SENP.HasValue)
				request.WithQueryParameter("SENP", m3_SENP.Value.ToString());
			if (m3_PRDY.HasValue)
				request.WithQueryParameter("PRDY", m3_PRDY.Value.ToString());
			if (m3_AUIN.HasValue)
				request.WithQueryParameter("AUIN", m3_AUIN.Value.ToString());
			if (m3_AURP.HasValue)
				request.WithQueryParameter("AURP", m3_AURP.Value.ToString());
			if (m3_SCPC.HasValue)
				request.WithQueryParameter("SCPC", m3_SCPC.Value.ToString());
			if (m3_WLDE.HasValue)
				request.WithQueryParameter("WLDE", m3_WLDE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOOL))
				request.WithQueryParameter("TOOL", m3_TOOL.Trim());
			if (m3_PLLT.HasValue)
				request.WithQueryParameter("PLLT", m3_PLLT.Value.ToString());
			if (m3_CRTR.HasValue)
				request.WithQueryParameter("CRTR", m3_CRTR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LASK))
				request.WithQueryParameter("LASK", m3_LASK.Trim());
			if (m3_SWQT.HasValue)
				request.WithQueryParameter("SWQT", m3_SWQT.Value.ToString());
			if (m3_CAMP.HasValue)
				request.WithQueryParameter("CAMP", m3_CAMP.Value.ToString());
			if (m3_PIPR.HasValue)
				request.WithQueryParameter("PIPR", m3_PIPR.Value.ToString());
			if (m3_WAFA.HasValue)
				request.WithQueryParameter("WAFA", m3_WAFA.Value.ToString());
			if (m3_SEPR.HasValue)
				request.WithQueryParameter("SEPR", m3_SEPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WCRF))
				request.WithQueryParameter("WCRF", m3_WCRF.Trim());
			if (m3_KIWG.HasValue)
				request.WithQueryParameter("KIWG", m3_KIWG.Value.ToString());
			if (m3_INWE.HasValue)
				request.WithQueryParameter("INWE", m3_INWE.Value.ToString());
			if (m3_OPV3.HasValue)
				request.WithQueryParameter("OPV3", m3_OPV3.Value.ToString());
			if (m3_MFPR.HasValue)
				request.WithQueryParameter("MFPR", m3_MFPR.Value.ToString());
			if (m3_OPCM.HasValue)
				request.WithQueryParameter("OPCM", m3_OPCM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TXT1))
				request.WithQueryParameter("TXT1", m3_TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT2))
				request.WithQueryParameter("TXT2", m3_TXT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLG6))
				request.WithQueryParameter("PLG6", m3_PLG6.Trim());
			if (m3_APON.HasValue)
				request.WithQueryParameter("APON", m3_APON.Value.ToString());
			if (m3_NXOP.HasValue)
				request.WithQueryParameter("NXOP", m3_NXOP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SLAT))
				request.WithQueryParameter("SLAT", m3_SLAT.Trim());
			if (m3_SLAC.HasValue)
				request.WithQueryParameter("SLAC", m3_SLAC.Value.ToString());
			if (m3_POOC.HasValue)
				request.WithQueryParameter("POOC", m3_POOC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESR))
				request.WithQueryParameter("RESR", m3_RESR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGF))
				request.WithQueryParameter("PLGF", m3_PLGF.Trim());
			if (m3_PRET.HasValue)
				request.WithQueryParameter("PRET", m3_PRET.Value.ToString());
			if (m3_POTM.HasValue)
				request.WithQueryParameter("POTM", m3_POTM.Value.ToString());
			if (m3_SPLK.HasValue)
				request.WithQueryParameter("SPLK", m3_SPLK.Value.ToString());
			if (m3_SPLF.HasValue)
				request.WithQueryParameter("SPLF", m3_SPLF.Value.ToString());
			if (m3_SPLN.HasValue)
				request.WithQueryParameter("SPLN", m3_SPLN.Value.ToString());
			if (m3_SPSZ.HasValue)
				request.WithQueryParameter("SPSZ", m3_SPSZ.Value.ToString());

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
