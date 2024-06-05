/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
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
		/// <param name="m3MACH">Machine identity</param>
		/// <param name="m3MACN">Macro order number</param>
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
			decimal? m3MACN = null, 
			int? m3RBUP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddInboxOp",
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
			if (m3MACN.HasValue)
				request.WithQueryParameter("MACN", m3MACN.Value.ToString(CultureInfo.CurrentCulture));
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
		/// <param name="m3SCHN">Schedule number</param>
		/// <param name="m3MACN">Macro order number</param>
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
			decimal? m3SCHN = null, 
			decimal? m3MACN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddInboxOrder",
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
			if (m3SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3SCHN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MACN.HasValue)
				request.WithQueryParameter("MACN", m3MACN.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddMOComponent
		/// Description Add component to MO
		/// Version Release: 5ea5
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3MTNO">Component number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3CNQT">Quantity</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3DWPO">Drawing position</param>
		/// <param name="m3FXCD">Quantity relation</param>
		/// <param name="m3WAPC">Normal waste percentage</param>
		/// <param name="m3CRTM">Critical material</param>
		/// <param name="m3BYPR">By/co-product code</param>
		/// <param name="m3SPMT">Issue method</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3LGTH">Length</param>
		/// <param name="m3WDTH">Width</param>
		/// <param name="m3LWF1">Factor 1</param>
		/// <param name="m3LWF2">Factor 2</param>
		/// <param name="m3CMCD">Inheritance control</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3FMT1">Text</param>
		/// <param name="m3FMT2">Technical reference</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3ACTS">Task element number</param>
		/// <param name="m3PEUN">Product engineering U/M</param>
		/// <param name="m3AADM">Add components - not in item master</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddMOComponentResponse></returns>
		/// <exception cref="M3Exception<AddMOComponentResponse>"></exception>
		public async Task<M3Response<AddMOComponentResponse>> AddMOComponent(
			string m3FACI, 
			string m3MFNO, 
			string m3MTNO, 
			int? m3CONO = null, 
			string m3PRNO = null, 
			int? m3MSEQ = null, 
			int? m3OPNO = null, 
			decimal? m3CNQT = null, 
			string m3WHLO = null, 
			string m3DWPO = null, 
			int? m3FXCD = null, 
			int? m3WAPC = null, 
			int? m3CRTM = null, 
			int? m3BYPR = null, 
			int? m3SPMT = null, 
			string m3WHSL = null, 
			int? m3LGTH = null, 
			int? m3WDTH = null, 
			decimal? m3LWF1 = null, 
			decimal? m3LWF2 = null, 
			int? m3CMCD = null, 
			string m3BANO = null, 
			string m3FMT1 = null, 
			string m3FMT2 = null, 
			decimal? m3ATNR = null, 
			int? m3ACTS = null, 
			string m3PEUN = null, 
			int? m3AADM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddMOComponent",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3MFNO))
				throw new ArgumentNullException(nameof(m3MFNO));
			if (string.IsNullOrWhiteSpace(m3MTNO))
				throw new ArgumentNullException(nameof(m3MTNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("MFNO", m3MFNO.Trim())
				.WithQueryParameter("MTNO", m3MTNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CNQT.HasValue)
				request.WithQueryParameter("CNQT", m3CNQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DWPO))
				request.WithQueryParameter("DWPO", m3DWPO.Trim());
			if (m3FXCD.HasValue)
				request.WithQueryParameter("FXCD", m3FXCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAPC.HasValue)
				request.WithQueryParameter("WAPC", m3WAPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3CRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BYPR.HasValue)
				request.WithQueryParameter("BYPR", m3BYPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3SPMT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (m3LGTH.HasValue)
				request.WithQueryParameter("LGTH", m3LGTH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WDTH.HasValue)
				request.WithQueryParameter("WDTH", m3WDTH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LWF1.HasValue)
				request.WithQueryParameter("LWF1", m3LWF1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LWF2.HasValue)
				request.WithQueryParameter("LWF2", m3LWF2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CMCD.HasValue)
				request.WithQueryParameter("CMCD", m3CMCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMT1))
				request.WithQueryParameter("FMT1", m3FMT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMT2))
				request.WithQueryParameter("FMT2", m3FMT2.Trim());
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACTS.HasValue)
				request.WithQueryParameter("ACTS", m3ACTS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PEUN))
				request.WithQueryParameter("PEUN", m3PEUN.Trim());
			if (m3AADM.HasValue)
				request.WithQueryParameter("AADM", m3AADM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddMOComponentResponse>(
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
		/// Name AddMatLine
		/// Description Add material line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3MSEQ">Sequence number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3ACTS">Task element number</param>
		/// <param name="m3MTNO">Component number</param>
		/// <param name="m3DWPO">Drawing position</param>
		/// <param name="m3CNQT">Quantity</param>
		/// <param name="m3PEUN">Product engineering U/M</param>
		/// <param name="m3FXCD">Quantity relation</param>
		/// <param name="m3WAPC">Normal waste percentage</param>
		/// <param name="m3BYPR">By/co-product code</param>
		/// <param name="m3CRTM">Critical material</param>
		/// <param name="m3SPMT">Issue method</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3LGTH">Length</param>
		/// <param name="m3WDTH">Width</param>
		/// <param name="m3LWF1">Factor 1</param>
		/// <param name="m3LWF2">Factor 2</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CMCD">Inheritance control</param>
		/// <param name="m3FMT1">Text</param>
		/// <param name="m3FMT2">Technical reference</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddMatLine(
			string m3FACI, 
			string m3PRNO, 
			string m3MFNO, 
			int m3MSEQ, 
			int? m3CONO = null, 
			int? m3OPNO = null, 
			int? m3ACTS = null, 
			string m3MTNO = null, 
			string m3DWPO = null, 
			decimal? m3CNQT = null, 
			string m3PEUN = null, 
			int? m3FXCD = null, 
			int? m3WAPC = null, 
			int? m3BYPR = null, 
			int? m3CRTM = null, 
			int? m3SPMT = null, 
			string m3WHLO = null, 
			string m3WHSL = null, 
			int? m3LGTH = null, 
			int? m3WDTH = null, 
			decimal? m3LWF1 = null, 
			decimal? m3LWF2 = null, 
			string m3BANO = null, 
			int? m3CMCD = null, 
			string m3FMT1 = null, 
			string m3FMT2 = null, 
			decimal? m3ATNR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddMatLine",
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
				.WithQueryParameter("MSEQ", m3MSEQ.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACTS.HasValue)
				request.WithQueryParameter("ACTS", m3ACTS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MTNO))
				request.WithQueryParameter("MTNO", m3MTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DWPO))
				request.WithQueryParameter("DWPO", m3DWPO.Trim());
			if (m3CNQT.HasValue)
				request.WithQueryParameter("CNQT", m3CNQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PEUN))
				request.WithQueryParameter("PEUN", m3PEUN.Trim());
			if (m3FXCD.HasValue)
				request.WithQueryParameter("FXCD", m3FXCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAPC.HasValue)
				request.WithQueryParameter("WAPC", m3WAPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BYPR.HasValue)
				request.WithQueryParameter("BYPR", m3BYPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3CRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3SPMT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (m3LGTH.HasValue)
				request.WithQueryParameter("LGTH", m3LGTH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WDTH.HasValue)
				request.WithQueryParameter("WDTH", m3WDTH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LWF1.HasValue)
				request.WithQueryParameter("LWF1", m3LWF1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LWF2.HasValue)
				request.WithQueryParameter("LWF2", m3LWF2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3CMCD.HasValue)
				request.WithQueryParameter("CMCD", m3CMCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FMT1))
				request.WithQueryParameter("FMT1", m3FMT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMT2))
				request.WithQueryParameter("FMT2", m3FMT2.Trim());
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddOperation
		/// Description Add operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3OPDS">Operation description</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3PITI">Run time</param>
		/// <param name="m3CTCD">Price and time quantity</param>
		/// <param name="m3SETI">Setup time</param>
		/// <param name="m3OSET">External setup time</param>
		/// <param name="m3FXTI">Fixed time</param>
		/// <param name="m3PRNM">Planned number of machines</param>
		/// <param name="m3PRNP">Planned number of workers - run time</param>
		/// <param name="m3SENP">Planned number of workers - setup</param>
		/// <param name="m3PRDY">Production days</param>
		/// <param name="m3AUIN">Automatic receipt</param>
		/// <param name="m3AURP">Automatic operation reporting</param>
		/// <param name="m3SCPC">Scrap percentage</param>
		/// <param name="m3WLDE">Infinite/finite</param>
		/// <param name="m3DOID">Document identity</param>
		/// <param name="m3TOOL">Tool number</param>
		/// <param name="m3PLLT">Lot number control</param>
		/// <param name="m3CRTR">Critical resource</param>
		/// <param name="m3LASK">Labor skill</param>
		/// <param name="m3SWQT">Setup scrap</param>
		/// <param name="m3CAMP">Number of labor tickets</param>
		/// <param name="m3PIPR">Unit price</param>
		/// <param name="m3WAFA">Time rate</param>
		/// <param name="m3SEPR">Setup price</param>
		/// <param name="m3WCRF">Time reference</param>
		/// <param name="m3KIWG">Pay element</param>
		/// <param name="m3INWE">Initial weight</param>
		/// <param name="m3OPV3">Operation volume</param>
		/// <param name="m3MFPR">Multiplication factor - manufacturing</param>
		/// <param name="m3OPCM">Operation cost multiplier</param>
		/// <param name="m3TXT1">Text line 1</param>
		/// <param name="m3TXT2">Text line 2</param>
		/// <param name="m3PLG6">Work center resource</param>
		/// <param name="m3APON">App operation number</param>
		/// <param name="m3NXOP">Next APP operation number</param>
		/// <param name="m3SLAT">Transit unit of measure/Overlap code</param>
		/// <param name="m3SLAC">Transport value in days</param>
		/// <param name="m3POOC">Parallel operation overlap code</param>
		/// <param name="m3RESR">Resource restriction</param>
		/// <param name="m3PLGF">Forced resource</param>
		/// <param name="m3PRET">Preparation time</param>
		/// <param name="m3POTM">Post-operation time</param>
		/// <param name="m3SPLK">Split method - operation</param>
		/// <param name="m3SPLF">Split fixed rate</param>
		/// <param name="m3SPLN">Number of operations after split</param>
		/// <param name="m3SPSZ">Split quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddOperation(
			string m3FACI, 
			string m3PRNO, 
			string m3MFNO, 
			int? m3CONO = null, 
			int? m3OPNO = null, 
			string m3PLGR = null, 
			string m3OPDS = null, 
			string m3DEPT = null, 
			string m3REAR = null, 
			int? m3PITI = null, 
			int? m3CTCD = null, 
			int? m3SETI = null, 
			int? m3OSET = null, 
			int? m3FXTI = null, 
			int? m3PRNM = null, 
			int? m3PRNP = null, 
			int? m3SENP = null, 
			int? m3PRDY = null, 
			int? m3AUIN = null, 
			int? m3AURP = null, 
			int? m3SCPC = null, 
			int? m3WLDE = null, 
			string m3DOID = null, 
			string m3TOOL = null, 
			int? m3PLLT = null, 
			int? m3CRTR = null, 
			string m3LASK = null, 
			decimal? m3SWQT = null, 
			int? m3CAMP = null, 
			decimal? m3PIPR = null, 
			decimal? m3WAFA = null, 
			decimal? m3SEPR = null, 
			string m3WCRF = null, 
			int? m3KIWG = null, 
			decimal? m3INWE = null, 
			decimal? m3OPV3 = null, 
			int? m3MFPR = null, 
			int? m3OPCM = null, 
			string m3TXT1 = null, 
			string m3TXT2 = null, 
			string m3PLG6 = null, 
			int? m3APON = null, 
			int? m3NXOP = null, 
			string m3SLAT = null, 
			decimal? m3SLAC = null, 
			int? m3POOC = null, 
			string m3RESR = null, 
			string m3PLGF = null, 
			int? m3PRET = null, 
			int? m3POTM = null, 
			int? m3SPLK = null, 
			int? m3SPLF = null, 
			int? m3SPLN = null, 
			decimal? m3SPSZ = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddOperation",
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
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPDS))
				request.WithQueryParameter("OPDS", m3OPDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (m3PITI.HasValue)
				request.WithQueryParameter("PITI", m3PITI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CTCD.HasValue)
				request.WithQueryParameter("CTCD", m3CTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SETI.HasValue)
				request.WithQueryParameter("SETI", m3SETI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OSET.HasValue)
				request.WithQueryParameter("OSET", m3OSET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FXTI.HasValue)
				request.WithQueryParameter("FXTI", m3FXTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNM.HasValue)
				request.WithQueryParameter("PRNM", m3PRNM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3PRNP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SENP.HasValue)
				request.WithQueryParameter("SENP", m3SENP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRDY.HasValue)
				request.WithQueryParameter("PRDY", m3PRDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUIN.HasValue)
				request.WithQueryParameter("AUIN", m3AUIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AURP.HasValue)
				request.WithQueryParameter("AURP", m3AURP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCPC.HasValue)
				request.WithQueryParameter("SCPC", m3SCPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WLDE.HasValue)
				request.WithQueryParameter("WLDE", m3WLDE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOOL))
				request.WithQueryParameter("TOOL", m3TOOL.Trim());
			if (m3PLLT.HasValue)
				request.WithQueryParameter("PLLT", m3PLLT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRTR.HasValue)
				request.WithQueryParameter("CRTR", m3CRTR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LASK))
				request.WithQueryParameter("LASK", m3LASK.Trim());
			if (m3SWQT.HasValue)
				request.WithQueryParameter("SWQT", m3SWQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAMP.HasValue)
				request.WithQueryParameter("CAMP", m3CAMP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PIPR.HasValue)
				request.WithQueryParameter("PIPR", m3PIPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAFA.HasValue)
				request.WithQueryParameter("WAFA", m3WAFA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SEPR.HasValue)
				request.WithQueryParameter("SEPR", m3SEPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WCRF))
				request.WithQueryParameter("WCRF", m3WCRF.Trim());
			if (m3KIWG.HasValue)
				request.WithQueryParameter("KIWG", m3KIWG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INWE.HasValue)
				request.WithQueryParameter("INWE", m3INWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPV3.HasValue)
				request.WithQueryParameter("OPV3", m3OPV3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MFPR.HasValue)
				request.WithQueryParameter("MFPR", m3MFPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPCM.HasValue)
				request.WithQueryParameter("OPCM", m3OPCM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TXT1))
				request.WithQueryParameter("TXT1", m3TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT2))
				request.WithQueryParameter("TXT2", m3TXT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLG6))
				request.WithQueryParameter("PLG6", m3PLG6.Trim());
			if (m3APON.HasValue)
				request.WithQueryParameter("APON", m3APON.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NXOP.HasValue)
				request.WithQueryParameter("NXOP", m3NXOP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SLAT))
				request.WithQueryParameter("SLAT", m3SLAT.Trim());
			if (m3SLAC.HasValue)
				request.WithQueryParameter("SLAC", m3SLAC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POOC.HasValue)
				request.WithQueryParameter("POOC", m3POOC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESR))
				request.WithQueryParameter("RESR", m3RESR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGF))
				request.WithQueryParameter("PLGF", m3PLGF.Trim());
			if (m3PRET.HasValue)
				request.WithQueryParameter("PRET", m3PRET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POTM.HasValue)
				request.WithQueryParameter("POTM", m3POTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPLK.HasValue)
				request.WithQueryParameter("SPLK", m3SPLK.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPLF.HasValue)
				request.WithQueryParameter("SPLF", m3SPLF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPLN.HasValue)
				request.WithQueryParameter("SPLN", m3SPLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPSZ.HasValue)
				request.WithQueryParameter("SPSZ", m3SPSZ.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgAltMaterials
		/// Description Change Alternative Materials
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3MSEQ">Sequence number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3MTAL">Alternative material (Required)</param>
		/// <param name="m3MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgAltMaterials(
			string m3FACI, 
			string m3PRNO, 
			int m3MSEQ, 
			int m3OPNO, 
			string m3MTAL, 
			string m3MFNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgAltMaterials",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3MTAL))
				throw new ArgumentNullException(nameof(m3MTAL));
			if (string.IsNullOrWhiteSpace(m3MFNO))
				throw new ArgumentNullException(nameof(m3MFNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("MSEQ", m3MSEQ.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("MTAL", m3MTAL.Trim())
				.WithQueryParameter("MFNO", m3MFNO.Trim());

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
		/// Name CloseMO
		/// Description CloseMO
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3MFNO">Manufacturing order number</param>
		/// <param name="m3SCHN">Schedule number</param>
		/// <param name="m3DSP1">Flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CloseMO(
			string m3MFNO = null, 
			decimal? m3SCHN = null, 
			int? m3DSP1 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CloseMO",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MFNO))
				request.WithQueryParameter("MFNO", m3MFNO.Trim());
			if (m3SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3SCHN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3DSP1.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name CloseMtrlLine
		/// Description Close Material Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SCHN">Schedule number</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3MFNO">Manufacturing order number</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CloseMtrlLine(
			string m3FACI, 
			int? m3CONO = null, 
			decimal? m3SCHN = null, 
			string m3PRNO = null, 
			string m3MFNO = null, 
			int? m3MSEQ = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CloseMtrlLine",
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
			if (m3SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3SCHN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MFNO))
				request.WithQueryParameter("MFNO", m3MFNO.Trim());
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));

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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ClrInboxes",
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
		/// Name CrtMO
		/// Description Create MO
		/// Version Release: 5ea5
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3STRT">Product structure type (Required)</param>
		/// <param name="m3ORQA">Ordered quantity - alt (Required)</param>
		/// <param name="m3WHST">Status (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3FIDT">Finish date</param>
		/// <param name="m3BDCD">Explosion</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3WCLN">Production line</param>
		/// <param name="m3RORC">Refrence order category</param>
		/// <param name="m3RORN">Refrence order number</param>
		/// <param name="m3RORL">Refrence order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3PRIO">Priority</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3NUC1">Number of put-away card</param>
		/// <param name="m3NUC2">Number of material req</param>
		/// <param name="m3NUC3">Number of labor ticket</param>
		/// <param name="m3NUC4">Number of shop travele</param>
		/// <param name="m3NUC5">Number of routing card</param>
		/// <param name="m3NUC6">Number of picking list</param>
		/// <param name="m3NUC7">Number of design document</param>
		/// <param name="m3SCHN">Schedule number</param>
		/// <param name="m3TX40">Text</param>
		/// <param name="m3MAUN">Alternate U/M</param>
		/// <param name="m3DSP6">WARNING-Ignore order multiple</param>
		/// <param name="m3DSP1">WARNING - Date is earlier than today''s</param>
		/// <param name="m3DSP2">WARNING - Start date may be earlier than</param>
		/// <param name="m3DSP3">WARNING-Finish date &1 gives earliest fi</param>
		/// <param name="m3DSP5">WARNING-Alternative routing identity</param>
		/// <param name="m3DSP4">WARNING-</param>
		/// <param name="m3DSP7">WARNING-</param>
		/// <param name="m3DSP8">WARNING-</param>
		/// <param name="m3AOID">Alternative routing</param>
		/// <param name="m3MEXP">Manual expiration date</param>
		/// <param name="m3MSTI">Start time</param>
		/// <param name="m3MFTI">Finish time</param>
		/// <param name="m3MFPC">Process</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3PCCO">Process code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CrtMOResponse></returns>
		/// <exception cref="M3Exception<CrtMOResponse>"></exception>
		public async Task<M3Response<CrtMOResponse>> CrtMO(
			string m3FACI, 
			string m3PRNO, 
			string m3STRT, 
			string m3ORQA, 
			string m3WHST, 
			int? m3CONO = null, 
			DateTime? m3STDT = null, 
			DateTime? m3FIDT = null, 
			int? m3BDCD = null, 
			string m3RESP = null, 
			string m3WHLO = null, 
			string m3ORTY = null, 
			string m3PROJ = null, 
			string m3WCLN = null, 
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3BANO = null, 
			int? m3PRIO = null, 
			string m3ELNO = null, 
			int? m3NUC1 = null, 
			int? m3NUC2 = null, 
			int? m3NUC3 = null, 
			int? m3NUC4 = null, 
			int? m3NUC5 = null, 
			int? m3NUC6 = null, 
			int? m3NUC7 = null, 
			decimal? m3SCHN = null, 
			string m3TX40 = null, 
			string m3MAUN = null, 
			int? m3DSP6 = null, 
			int? m3DSP1 = null, 
			int? m3DSP2 = null, 
			int? m3DSP3 = null, 
			int? m3DSP5 = null, 
			int? m3DSP4 = null, 
			int? m3DSP7 = null, 
			int? m3DSP8 = null, 
			string m3AOID = null, 
			DateTime? m3MEXP = null, 
			int? m3MSTI = null, 
			int? m3MFTI = null, 
			string m3MFPC = null, 
			string m3WHSL = null, 
			int? m3PCCO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CrtMO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3STRT))
				throw new ArgumentNullException(nameof(m3STRT));
			if (string.IsNullOrWhiteSpace(m3ORQA))
				throw new ArgumentNullException(nameof(m3ORQA));
			if (string.IsNullOrWhiteSpace(m3WHST))
				throw new ArgumentNullException(nameof(m3WHST));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("STRT", m3STRT.Trim())
				.WithQueryParameter("ORQA", m3ORQA.Trim())
				.WithQueryParameter("WHST", m3WHST.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3FIDT.Value.ToM3String());
			if (m3BDCD.HasValue)
				request.WithQueryParameter("BDCD", m3BDCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3WCLN))
				request.WithQueryParameter("WCLN", m3WCLN.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3PRIO.HasValue)
				request.WithQueryParameter("PRIO", m3PRIO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (m3NUC1.HasValue)
				request.WithQueryParameter("NUC1", m3NUC1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC2.HasValue)
				request.WithQueryParameter("NUC2", m3NUC2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC3.HasValue)
				request.WithQueryParameter("NUC3", m3NUC3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC4.HasValue)
				request.WithQueryParameter("NUC4", m3NUC4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC5.HasValue)
				request.WithQueryParameter("NUC5", m3NUC5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC6.HasValue)
				request.WithQueryParameter("NUC6", m3NUC6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC7.HasValue)
				request.WithQueryParameter("NUC7", m3NUC7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3SCHN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3MAUN))
				request.WithQueryParameter("MAUN", m3MAUN.Trim());
			if (m3DSP6.HasValue)
				request.WithQueryParameter("DSP6", m3DSP6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3DSP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP2.HasValue)
				request.WithQueryParameter("DSP2", m3DSP2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP3.HasValue)
				request.WithQueryParameter("DSP3", m3DSP3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP5.HasValue)
				request.WithQueryParameter("DSP5", m3DSP5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP4.HasValue)
				request.WithQueryParameter("DSP4", m3DSP4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP7.HasValue)
				request.WithQueryParameter("DSP7", m3DSP7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP8.HasValue)
				request.WithQueryParameter("DSP8", m3DSP8.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AOID))
				request.WithQueryParameter("AOID", m3AOID.Trim());
			if (m3MEXP.HasValue)
				request.WithQueryParameter("MEXP", m3MEXP.Value.ToM3String());
			if (m3MSTI.HasValue)
				request.WithQueryParameter("MSTI", m3MSTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MFTI.HasValue)
				request.WithQueryParameter("MFTI", m3MFTI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MFPC))
				request.WithQueryParameter("MFPC", m3MFPC.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (m3PCCO.HasValue)
				request.WithQueryParameter("PCCO", m3PCCO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<CrtMOResponse>(
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
		/// Name DltMO
		/// Description Delete workorder
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltMO(
			string m3MFNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltMO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MFNO))
				throw new ArgumentNullException(nameof(m3MFNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MFNO", m3MFNO.Trim());

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
		/// Name DltMOComponent
		/// Description Delete component from  MO
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3MFNO">Manufacturing order number</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltMOComponent(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3MFNO = null, 
			int? m3MSEQ = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltMOComponent",
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
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltMatLine
		/// Description Delete material line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3MFNO">Manufacturing order number</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3MTNO">Component number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltMatLine(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3MFNO = null, 
			int? m3MSEQ = null, 
			string m3MTNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltMatLine",
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
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
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
		/// Name DltOperation
		/// Description Delete operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3MFNO">Manufacturing order number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltOperation(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3MFNO = null, 
			int? m3OPNO = null, 
			string m3PLGR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltOperation",
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
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
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
		/// Description Get one manufacturing order
		/// Version Release: 5ea7
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Get",
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
		/// Name GetMatLine
		/// Description Get material line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3MSEQ">Sequence number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMatLineResponse></returns>
		/// <exception cref="M3Exception<GetMatLineResponse>"></exception>
		public async Task<M3Response<GetMatLineResponse>> GetMatLine(
			string m3FACI, 
			string m3PRNO, 
			string m3MFNO, 
			int m3MSEQ, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetMatLine",
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
				.WithQueryParameter("MSEQ", m3MSEQ.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetMatLineResponse>(
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
		/// Name GetOperation
		/// Description Get operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOperationResponse></returns>
		/// <exception cref="M3Exception<GetOperationResponse>"></exception>
		public async Task<M3Response<GetOperationResponse>> GetOperation(
			string m3FACI, 
			string m3PRNO, 
			string m3MFNO, 
			int? m3CONO = null, 
			int? m3OPNO = null, 
			string m3PLGR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetOperation",
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
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());

			// Execute the request
			var result = await Execute<GetOperationResponse>(
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetUserJobSts",
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
		/// Name LstByRORN
		/// Description List by reference order number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3RORC">Reference order category (Required)</param>
		/// <param name="m3RORN">Reference order number (Required)</param>
		/// <param name="m3RORL">Reference order line (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByRORNResponse></returns>
		/// <exception cref="M3Exception<LstByRORNResponse>"></exception>
		public async Task<M3Response<LstByRORNResponse>> LstByRORN(
			int m3RORC, 
			string m3RORN, 
			int m3RORL, 
			int? m3CONO = null, 
			int? m3RORX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByRORN",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RORN))
				throw new ArgumentNullException(nameof(m3RORN));

			// Set mandatory parameters
			request
				.WithQueryParameter("RORC", m3RORC.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RORN", m3RORN.Trim())
				.WithQueryParameter("RORL", m3RORL.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstByRORNResponse>(
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
		/// Name Reschedule
		/// Description Change workorder date and quantity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3ORQA">Ordered quantity - alt (Required)</param>
		/// <param name="m3WLDE">Infinte/finite (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3FIDT">Finish date</param>
		/// <param name="m3PRIO">Priority</param>
		/// <param name="m3DSP1">Warning -Date is earlier then to date.</param>
		/// <param name="m3DSP2">WARNING - MO connected to order number</param>
		/// <param name="m3DSP3">WARNING - This order contains subcontrac</param>
		/// <param name="m3DSP4">WARNING - Quantity ordered is not divisi</param>
		/// <param name="m3DSP5">WARNING - This order has previously been</param>
		/// <param name="m3DSP6">WARNING - Operations are have been start</param>
		/// <param name="m3DSP7">WARNING - This order has previously been</param>
		/// <param name="m3DSP8">WARNING - Operations have been started</param>
		/// <param name="m3MEXP">Manual expiration date</param>
		/// <param name="m3MSTI">Start time</param>
		/// <param name="m3MFTI">Finish time</param>
		/// <param name="m3RPLL">Reschedule lower levels</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Reschedule(
			string m3FACI, 
			string m3PRNO, 
			string m3MFNO, 
			string m3ORQA, 
			int m3WLDE, 
			int? m3CONO = null, 
			DateTime? m3STDT = null, 
			DateTime? m3FIDT = null, 
			int? m3PRIO = null, 
			int? m3DSP1 = null, 
			int? m3DSP2 = null, 
			int? m3DSP3 = null, 
			int? m3DSP4 = null, 
			int? m3DSP5 = null, 
			int? m3DSP6 = null, 
			int? m3DSP7 = null, 
			int? m3DSP8 = null, 
			DateTime? m3MEXP = null, 
			int? m3MSTI = null, 
			int? m3MFTI = null, 
			int? m3RPLL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Reschedule",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3MFNO))
				throw new ArgumentNullException(nameof(m3MFNO));
			if (string.IsNullOrWhiteSpace(m3ORQA))
				throw new ArgumentNullException(nameof(m3ORQA));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("MFNO", m3MFNO.Trim())
				.WithQueryParameter("ORQA", m3ORQA.Trim())
				.WithQueryParameter("WLDE", m3WLDE.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3FIDT.Value.ToM3String());
			if (m3PRIO.HasValue)
				request.WithQueryParameter("PRIO", m3PRIO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3DSP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP2.HasValue)
				request.WithQueryParameter("DSP2", m3DSP2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP3.HasValue)
				request.WithQueryParameter("DSP3", m3DSP3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP4.HasValue)
				request.WithQueryParameter("DSP4", m3DSP4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP5.HasValue)
				request.WithQueryParameter("DSP5", m3DSP5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP6.HasValue)
				request.WithQueryParameter("DSP6", m3DSP6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP7.HasValue)
				request.WithQueryParameter("DSP7", m3DSP7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP8.HasValue)
				request.WithQueryParameter("DSP8", m3DSP8.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MEXP.HasValue)
				request.WithQueryParameter("MEXP", m3MEXP.Value.ToM3String());
			if (m3MSTI.HasValue)
				request.WithQueryParameter("MSTI", m3MSTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MFTI.HasValue)
				request.WithQueryParameter("MFTI", m3MFTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPLL.HasValue)
				request.WithQueryParameter("RPLL", m3RPLL.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name SearchMO
		/// Description Search Manufaturing order via LES
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchMOResponse></returns>
		/// <exception cref="M3Exception<SearchMOResponse>"></exception>
		public async Task<M3Response<SearchMOResponse>> SearchMO(
			string m3SQRY, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SearchMO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SQRY))
				throw new ArgumentNullException(nameof(m3SQRY));

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchMOResponse>(
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
		/// Name SearchMaterial
		/// Description Search Material
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchMaterialResponse></returns>
		/// <exception cref="M3Exception<SearchMaterialResponse>"></exception>
		public async Task<M3Response<SearchMaterialResponse>> SearchMaterial(
			string m3SQRY, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SearchMaterial",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SQRY))
				throw new ArgumentNullException(nameof(m3SQRY));

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchMaterialResponse>(
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
		/// Name SearchOperation
		/// Description Search Operation
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchOperationResponse></returns>
		/// <exception cref="M3Exception<SearchOperationResponse>"></exception>
		public async Task<M3Response<SearchOperationResponse>> SearchOperation(
			string m3SQRY, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SearchOperation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SQRY))
				throw new ArgumentNullException(nameof(m3SQRY));

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchOperationResponse>(
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
		/// Name SelConfigAttr
		/// Description Selection of attributes
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACF">From facility (Required)</param>
		/// <param name="m3FACT">To facility (Required)</param>
		/// <param name="m3STSF">From status (Required)</param>
		/// <param name="m3STST">To status (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3DATE">Timestamp - Date</param>
		/// <param name="m3TIME">Timestamp - Time</param>
		/// <param name="m3SCHH">Scheduling horizon</param>
		/// <param name="m3FWHS">From warehouse</param>
		/// <param name="m3TWHS">To warehouse</param>
		/// <param name="m3WHGR">Warehouse Group</param>
		/// <param name="m3APIP">APS-policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelConfigAttrResponse></returns>
		/// <exception cref="M3Exception<SelConfigAttrResponse>"></exception>
		public async Task<M3Response<SelConfigAttrResponse>> SelConfigAttr(
			string m3FACF, 
			string m3FACT, 
			int m3STSF, 
			int m3STST, 
			int? m3CONO = null, 
			string m3REAR = null, 
			DateTime? m3DATE = null, 
			int? m3TIME = null, 
			int? m3SCHH = null, 
			string m3FWHS = null, 
			string m3TWHS = null, 
			string m3WHGR = null, 
			string m3APIP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelConfigAttr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACF))
				throw new ArgumentNullException(nameof(m3FACF));
			if (string.IsNullOrWhiteSpace(m3FACT))
				throw new ArgumentNullException(nameof(m3FACT));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACF", m3FACF.Trim())
				.WithQueryParameter("FACT", m3FACT.Trim())
				.WithQueryParameter("STSF", m3STSF.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STST", m3STST.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
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

			// Execute the request
			var result = await Execute<SelConfigAttrResponse>(
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelErrOrders",
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
		/// Name SelFashionAttr
		/// Description Selection of fashion attributes
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACF">From facility (Required)</param>
		/// <param name="m3FACT">To facility (Required)</param>
		/// <param name="m3STSF">From status (Required)</param>
		/// <param name="m3STST">To status (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3DATE">Timestamp - Date</param>
		/// <param name="m3TIME">Timestamp - Time</param>
		/// <param name="m3SCHH">Scheduling horizon</param>
		/// <param name="m3FWHS">From warehouse</param>
		/// <param name="m3TWHS">To warehouse</param>
		/// <param name="m3WHGR">Warehouse Group</param>
		/// <param name="m3APIP">APS-policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelFashionAttrResponse></returns>
		/// <exception cref="M3Exception<SelFashionAttrResponse>"></exception>
		public async Task<M3Response<SelFashionAttrResponse>> SelFashionAttr(
			string m3FACF, 
			string m3FACT, 
			int m3STSF, 
			int m3STST, 
			int? m3CONO = null, 
			string m3REAR = null, 
			DateTime? m3DATE = null, 
			int? m3TIME = null, 
			int? m3SCHH = null, 
			string m3FWHS = null, 
			string m3TWHS = null, 
			string m3WHGR = null, 
			string m3APIP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelFashionAttr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACF))
				throw new ArgumentNullException(nameof(m3FACF));
			if (string.IsNullOrWhiteSpace(m3FACT))
				throw new ArgumentNullException(nameof(m3FACT));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACF", m3FACF.Trim())
				.WithQueryParameter("FACT", m3FACT.Trim())
				.WithQueryParameter("STSF", m3STSF.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STST", m3STST.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
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

			// Execute the request
			var result = await Execute<SelFashionAttrResponse>(
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
		/// Name SelMatByHead
		/// Description Selection of manufacturing order materials By Head
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3FSTS">From Status</param>
		/// <param name="m3TSTS">From Status</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3REAR">Planning Area</param>
		/// <param name="m3DATE">Timestamp - Date</param>
		/// <param name="m3TIME">Timestamp - Time</param>
		/// <param name="m3SCHH">Scheduling Horizon</param>
		/// <param name="m3APIP">APS - Policy</param>
		/// <param name="m3OPCO">Exclude finish marked</param>
		/// <param name="m3SINV">Select only inv.acc(STCD) equals one</param>
		/// <param name="m3DBYP">De-select Byproducts</param>
		/// <param name="m3SALT">Include alternative materials</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelMatByHeadResponse></returns>
		/// <exception cref="M3Exception<SelMatByHeadResponse>"></exception>
		public async Task<M3Response<SelMatByHeadResponse>> SelMatByHead(
			string m3FACI, 
			int? m3CONO = null, 
			string m3WHLO = null, 
			int? m3FSTS = null, 
			int? m3TSTS = null, 
			string m3WHGR = null, 
			string m3REAR = null, 
			DateTime? m3DATE = null, 
			int? m3TIME = null, 
			int? m3SCHH = null, 
			string m3APIP = null, 
			int? m3OPCO = null, 
			int? m3SINV = null, 
			int? m3DBYP = null, 
			int? m3SALT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelMatByHead",
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
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3FSTS.HasValue)
				request.WithQueryParameter("FSTS", m3FSTS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TSTS.HasValue)
				request.WithQueryParameter("TSTS", m3TSTS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (m3DATE.HasValue)
				request.WithQueryParameter("DATE", m3DATE.Value.ToM3String());
			if (m3TIME.HasValue)
				request.WithQueryParameter("TIME", m3TIME.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3SCHH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());
			if (m3OPCO.HasValue)
				request.WithQueryParameter("OPCO", m3OPCO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SINV.HasValue)
				request.WithQueryParameter("SINV", m3SINV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DBYP.HasValue)
				request.WithQueryParameter("DBYP", m3DBYP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SALT.HasValue)
				request.WithQueryParameter("SALT", m3SALT.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelMatByHeadResponse>(
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
		/// Description Selection of manufacturing order materials
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3MFNO">Manufacturing order number</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3SINV">Select only inv.acc(STCD) equals one</param>
		/// <param name="m3DBYP">De-select Byproducts</param>
		/// <param name="m3SALT">Includ alternative materials</param>
		/// <param name="m3DFRM">Deselect finish reported materials</param>
		/// <param name="m3APIP">APS-policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelMaterialsResponse></returns>
		/// <exception cref="M3Exception<SelMaterialsResponse>"></exception>
		public async Task<M3Response<SelMaterialsResponse>> SelMaterials(
			string m3FACI, 
			int? m3CONO = null, 
			string m3PRNO = null, 
			string m3MFNO = null, 
			string m3WHGR = null, 
			int? m3SINV = null, 
			int? m3DBYP = null, 
			int? m3SALT = null, 
			int? m3DFRM = null, 
			string m3APIP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelMaterials",
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
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (m3SINV.HasValue)
				request.WithQueryParameter("SINV", m3SINV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DBYP.HasValue)
				request.WithQueryParameter("DBYP", m3DBYP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SALT.HasValue)
				request.WithQueryParameter("SALT", m3SALT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DFRM.HasValue)
				request.WithQueryParameter("DFRM", m3DFRM.Value.ToString(CultureInfo.CurrentCulture));
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
		/// Name SelOpeByHead
		/// Description Selection of operations By Head
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3FSTS">From Status</param>
		/// <param name="m3TSTS">To Status</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3DATE">Timestamp - Date</param>
		/// <param name="m3TIME">Timestamp - Time</param>
		/// <param name="m3SCHH">Scheduling Horizon</param>
		/// <param name="m3APIP">APS - Policy</param>
		/// <param name="m3OPCO">Check Operations completed</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelOpeByHeadResponse></returns>
		/// <exception cref="M3Exception<SelOpeByHeadResponse>"></exception>
		public async Task<M3Response<SelOpeByHeadResponse>> SelOpeByHead(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
			int? m3FSTS = null, 
			int? m3TSTS = null, 
			string m3WHGR = null, 
			string m3REAR = null, 
			DateTime? m3DATE = null, 
			int? m3TIME = null, 
			int? m3SCHH = null, 
			string m3APIP = null, 
			int? m3OPCO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelOpeByHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3FSTS.HasValue)
				request.WithQueryParameter("FSTS", m3FSTS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TSTS.HasValue)
				request.WithQueryParameter("TSTS", m3TSTS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (m3DATE.HasValue)
				request.WithQueryParameter("DATE", m3DATE.Value.ToM3String());
			if (m3TIME.HasValue)
				request.WithQueryParameter("TIME", m3TIME.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3SCHH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());
			if (m3OPCO.HasValue)
				request.WithQueryParameter("OPCO", m3OPCO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelOpeByHeadResponse>(
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
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3MFNO">Manufacturing order number</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelOperationsResponse></returns>
		/// <exception cref="M3Exception<SelOperationsResponse>"></exception>
		public async Task<M3Response<SelOperationsResponse>> SelOperations(
			string m3FACI, 
			int? m3CONO = null, 
			string m3PRNO = null, 
			string m3MFNO = null, 
			string m3REAR = null, 
			string m3WHGR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelOperations",
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
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());

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
		/// Name SelOrderHead
		/// Description Selection of Order Headers
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3FSTS">From Status</param>
		/// <param name="m3TSTS">To Status</param>
		/// <param name="m3WHGR">Warehouse Group</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3DATE">Timestamp - Date</param>
		/// <param name="m3TIME">Timestamp - Time</param>
		/// <param name="m3SCHH">Scheduling horizon</param>
		/// <param name="m3APIP">APS-policy</param>
		/// <param name="m3OPCO">Check Ope completed- Field not used</param>
		/// <param name="m3SLEN">Select Endproducts (1=YES)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelOrderHeadResponse></returns>
		/// <exception cref="M3Exception<SelOrderHeadResponse>"></exception>
		public async Task<M3Response<SelOrderHeadResponse>> SelOrderHead(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
			int? m3FSTS = null, 
			int? m3TSTS = null, 
			string m3WHGR = null, 
			string m3REAR = null, 
			DateTime? m3DATE = null, 
			int? m3TIME = null, 
			int? m3SCHH = null, 
			string m3APIP = null, 
			int? m3OPCO = null, 
			int? m3SLEN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelOrderHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3FSTS.HasValue)
				request.WithQueryParameter("FSTS", m3FSTS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TSTS.HasValue)
				request.WithQueryParameter("TSTS", m3TSTS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (m3DATE.HasValue)
				request.WithQueryParameter("DATE", m3DATE.Value.ToM3String());
			if (m3TIME.HasValue)
				request.WithQueryParameter("TIME", m3TIME.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3SCHH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());
			if (m3OPCO.HasValue)
				request.WithQueryParameter("OPCO", m3OPCO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SLEN.HasValue)
				request.WithQueryParameter("SLEN", m3SLEN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelOrderHeadResponse>(
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
		/// Description Selection of manufacturing orders
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACF">From facility (Required)</param>
		/// <param name="m3FACT">To facility (Required)</param>
		/// <param name="m3STSF">From status (Required)</param>
		/// <param name="m3STST">To status (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3DATE">Timestamp - Date</param>
		/// <param name="m3TIME">Timestamp - Time</param>
		/// <param name="m3SCHH">Scheduling horizon</param>
		/// <param name="m3FWHS">From warehouse</param>
		/// <param name="m3TWHS">To warehouse</param>
		/// <param name="m3WHGR">Warehouse Group</param>
		/// <param name="m3SLEN">Select Endproducts (1=YES)</param>
		/// <param name="m3APIP">APS-policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectResponse></returns>
		/// <exception cref="M3Exception<SelectResponse>"></exception>
		public async Task<M3Response<SelectResponse>> Select(
			string m3FACF, 
			string m3FACT, 
			int m3STSF, 
			int m3STST, 
			int? m3CONO = null, 
			string m3REAR = null, 
			DateTime? m3DATE = null, 
			int? m3TIME = null, 
			int? m3SCHH = null, 
			string m3FWHS = null, 
			string m3TWHS = null, 
			string m3WHGR = null, 
			int? m3SLEN = null, 
			string m3APIP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Select",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACF))
				throw new ArgumentNullException(nameof(m3FACF));
			if (string.IsNullOrWhiteSpace(m3FACT))
				throw new ArgumentNullException(nameof(m3FACT));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACF", m3FACF.Trim())
				.WithQueryParameter("FACT", m3FACT.Trim())
				.WithQueryParameter("STSF", m3STSF.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STST", m3STST.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
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
			if (m3SLEN.HasValue)
				request.WithQueryParameter("SLEN", m3SLEN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());

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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SetUserJobSts",
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
		/// <param name="m3MACH">Machine identity</param>
		/// <param name="m3MACN">Macro order number</param>
		/// <param name="m3RBUP">Remaining buffer percentage</param>
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
			decimal? m3SCHN = null, 
			long? m3SCHS = null, 
			string m3MACH = null, 
			decimal? m3MACN = null, 
			int? m3RBUP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SndInboxOp",
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
			if (m3MACN.HasValue)
				request.WithQueryParameter("MACN", m3MACN.Value.ToString(CultureInfo.CurrentCulture));
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
		/// <param name="m3SCHN">Schedule number</param>
		/// <param name="m3MACN">Macro order number</param>
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
			decimal? m3SCHN = null, 
			decimal? m3MACN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SndInboxOrder",
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
			if (m3SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3SCHN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MACN.HasValue)
				request.WithQueryParameter("MACN", m3MACN.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name TriggerUpdatJob
		/// Description Starts update processing
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> TriggerUpdatJob(
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/TriggerUpdatJob",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());

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
		/// Name UpdMatLine
		/// Description Update material line
		/// Version Release: 5ea5
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3MSEQ">Sequence number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3ACTS">Task element number</param>
		/// <param name="m3MTNO">Component number</param>
		/// <param name="m3DWPO">Drawing position</param>
		/// <param name="m3CNQT">Quantity</param>
		/// <param name="m3PEUN">Product engineering U/M</param>
		/// <param name="m3FXCD">Quantity relation</param>
		/// <param name="m3WAPC">Normal waste percentage</param>
		/// <param name="m3BYPR">By/co-product code</param>
		/// <param name="m3CRTM">Critical material</param>
		/// <param name="m3SPMT">Issue method</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3LGTH">Length</param>
		/// <param name="m3WDTH">Width</param>
		/// <param name="m3LWF1">Factor 1</param>
		/// <param name="m3LWF2">Factor 2</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CMCD">Inheritance control</param>
		/// <param name="m3FMT1">Text</param>
		/// <param name="m3FMT2">Technical reference</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3AADM">Add components - not in item master</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdMatLine(
			string m3FACI, 
			string m3PRNO, 
			string m3MFNO, 
			int m3MSEQ, 
			int? m3CONO = null, 
			int? m3OPNO = null, 
			int? m3ACTS = null, 
			string m3MTNO = null, 
			string m3DWPO = null, 
			decimal? m3CNQT = null, 
			string m3PEUN = null, 
			int? m3FXCD = null, 
			int? m3WAPC = null, 
			int? m3BYPR = null, 
			int? m3CRTM = null, 
			int? m3SPMT = null, 
			string m3WHLO = null, 
			string m3WHSL = null, 
			int? m3LGTH = null, 
			int? m3WDTH = null, 
			decimal? m3LWF1 = null, 
			decimal? m3LWF2 = null, 
			string m3BANO = null, 
			int? m3CMCD = null, 
			string m3FMT1 = null, 
			string m3FMT2 = null, 
			decimal? m3ATNR = null, 
			int? m3AADM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdMatLine",
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
				.WithQueryParameter("MSEQ", m3MSEQ.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACTS.HasValue)
				request.WithQueryParameter("ACTS", m3ACTS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MTNO))
				request.WithQueryParameter("MTNO", m3MTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DWPO))
				request.WithQueryParameter("DWPO", m3DWPO.Trim());
			if (m3CNQT.HasValue)
				request.WithQueryParameter("CNQT", m3CNQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PEUN))
				request.WithQueryParameter("PEUN", m3PEUN.Trim());
			if (m3FXCD.HasValue)
				request.WithQueryParameter("FXCD", m3FXCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAPC.HasValue)
				request.WithQueryParameter("WAPC", m3WAPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BYPR.HasValue)
				request.WithQueryParameter("BYPR", m3BYPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3CRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3SPMT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (m3LGTH.HasValue)
				request.WithQueryParameter("LGTH", m3LGTH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WDTH.HasValue)
				request.WithQueryParameter("WDTH", m3WDTH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LWF1.HasValue)
				request.WithQueryParameter("LWF1", m3LWF1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LWF2.HasValue)
				request.WithQueryParameter("LWF2", m3LWF2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3CMCD.HasValue)
				request.WithQueryParameter("CMCD", m3CMCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FMT1))
				request.WithQueryParameter("FMT1", m3FMT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMT2))
				request.WithQueryParameter("FMT2", m3FMT2.Trim());
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AADM.HasValue)
				request.WithQueryParameter("AADM", m3AADM.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdOperation
		/// Description Update material line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3OPDS">Operation description</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3PITI">Run time</param>
		/// <param name="m3CTCD">Price and time quantity</param>
		/// <param name="m3SETI">Setup time</param>
		/// <param name="m3OSET">External setup time</param>
		/// <param name="m3FXTI">Fixed time</param>
		/// <param name="m3PRNM">Planned number of machines</param>
		/// <param name="m3PRNP">Planned number of workers - run time</param>
		/// <param name="m3SENP">Planned number of workers - setup</param>
		/// <param name="m3PRDY">Production days</param>
		/// <param name="m3AUIN">Automatic receipt</param>
		/// <param name="m3AURP">Automatic operation reporting</param>
		/// <param name="m3SCPC">Scrap percentage</param>
		/// <param name="m3WLDE">Infinite/finite</param>
		/// <param name="m3DOID">Document identity</param>
		/// <param name="m3TOOL">Tool number</param>
		/// <param name="m3PLLT">Lot number control</param>
		/// <param name="m3CRTR">Critical resource</param>
		/// <param name="m3LASK">Labor skill</param>
		/// <param name="m3SWQT">Setup scrap</param>
		/// <param name="m3CAMP">Number of labor tickets</param>
		/// <param name="m3PIPR">Unit price</param>
		/// <param name="m3WAFA">Time rate</param>
		/// <param name="m3SEPR">Setup price</param>
		/// <param name="m3WCRF">Time reference</param>
		/// <param name="m3KIWG">Pay element</param>
		/// <param name="m3INWE">Initial weight</param>
		/// <param name="m3OPV3">Operation volume</param>
		/// <param name="m3MFPR">Multiplication factor - manufacturing</param>
		/// <param name="m3OPCM">Operation cost multiplier</param>
		/// <param name="m3TXT1">Text line 1</param>
		/// <param name="m3TXT2">Text line 2</param>
		/// <param name="m3PLG6">Work center resource</param>
		/// <param name="m3APON">App operation number</param>
		/// <param name="m3NXOP">Next APP operation number</param>
		/// <param name="m3SLAT">Transit unit of measure/Overlap code</param>
		/// <param name="m3SLAC">Transport value in days</param>
		/// <param name="m3POOC">Parallel operation overlap code</param>
		/// <param name="m3RESR">Resource restriction</param>
		/// <param name="m3PLGF">Forced resource</param>
		/// <param name="m3PRET">Preparation time</param>
		/// <param name="m3POTM">Post-operation time</param>
		/// <param name="m3SPLK">Split method - operation</param>
		/// <param name="m3SPLF">Split fixed rate</param>
		/// <param name="m3SPLN">Number of operations after split</param>
		/// <param name="m3SPSZ">Split quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdOperation(
			string m3FACI, 
			string m3PRNO, 
			string m3MFNO, 
			int? m3CONO = null, 
			int? m3OPNO = null, 
			string m3PLGR = null, 
			string m3OPDS = null, 
			string m3DEPT = null, 
			string m3REAR = null, 
			int? m3PITI = null, 
			int? m3CTCD = null, 
			int? m3SETI = null, 
			int? m3OSET = null, 
			int? m3FXTI = null, 
			int? m3PRNM = null, 
			int? m3PRNP = null, 
			int? m3SENP = null, 
			int? m3PRDY = null, 
			int? m3AUIN = null, 
			int? m3AURP = null, 
			int? m3SCPC = null, 
			int? m3WLDE = null, 
			string m3DOID = null, 
			string m3TOOL = null, 
			int? m3PLLT = null, 
			int? m3CRTR = null, 
			string m3LASK = null, 
			decimal? m3SWQT = null, 
			int? m3CAMP = null, 
			decimal? m3PIPR = null, 
			decimal? m3WAFA = null, 
			decimal? m3SEPR = null, 
			string m3WCRF = null, 
			int? m3KIWG = null, 
			decimal? m3INWE = null, 
			decimal? m3OPV3 = null, 
			int? m3MFPR = null, 
			int? m3OPCM = null, 
			string m3TXT1 = null, 
			string m3TXT2 = null, 
			string m3PLG6 = null, 
			int? m3APON = null, 
			int? m3NXOP = null, 
			string m3SLAT = null, 
			decimal? m3SLAC = null, 
			int? m3POOC = null, 
			string m3RESR = null, 
			string m3PLGF = null, 
			int? m3PRET = null, 
			int? m3POTM = null, 
			int? m3SPLK = null, 
			int? m3SPLF = null, 
			int? m3SPLN = null, 
			decimal? m3SPSZ = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdOperation",
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
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPDS))
				request.WithQueryParameter("OPDS", m3OPDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (m3PITI.HasValue)
				request.WithQueryParameter("PITI", m3PITI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CTCD.HasValue)
				request.WithQueryParameter("CTCD", m3CTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SETI.HasValue)
				request.WithQueryParameter("SETI", m3SETI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OSET.HasValue)
				request.WithQueryParameter("OSET", m3OSET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FXTI.HasValue)
				request.WithQueryParameter("FXTI", m3FXTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNM.HasValue)
				request.WithQueryParameter("PRNM", m3PRNM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3PRNP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SENP.HasValue)
				request.WithQueryParameter("SENP", m3SENP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRDY.HasValue)
				request.WithQueryParameter("PRDY", m3PRDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUIN.HasValue)
				request.WithQueryParameter("AUIN", m3AUIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AURP.HasValue)
				request.WithQueryParameter("AURP", m3AURP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCPC.HasValue)
				request.WithQueryParameter("SCPC", m3SCPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WLDE.HasValue)
				request.WithQueryParameter("WLDE", m3WLDE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOOL))
				request.WithQueryParameter("TOOL", m3TOOL.Trim());
			if (m3PLLT.HasValue)
				request.WithQueryParameter("PLLT", m3PLLT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRTR.HasValue)
				request.WithQueryParameter("CRTR", m3CRTR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LASK))
				request.WithQueryParameter("LASK", m3LASK.Trim());
			if (m3SWQT.HasValue)
				request.WithQueryParameter("SWQT", m3SWQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAMP.HasValue)
				request.WithQueryParameter("CAMP", m3CAMP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PIPR.HasValue)
				request.WithQueryParameter("PIPR", m3PIPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAFA.HasValue)
				request.WithQueryParameter("WAFA", m3WAFA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SEPR.HasValue)
				request.WithQueryParameter("SEPR", m3SEPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WCRF))
				request.WithQueryParameter("WCRF", m3WCRF.Trim());
			if (m3KIWG.HasValue)
				request.WithQueryParameter("KIWG", m3KIWG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INWE.HasValue)
				request.WithQueryParameter("INWE", m3INWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPV3.HasValue)
				request.WithQueryParameter("OPV3", m3OPV3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MFPR.HasValue)
				request.WithQueryParameter("MFPR", m3MFPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPCM.HasValue)
				request.WithQueryParameter("OPCM", m3OPCM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TXT1))
				request.WithQueryParameter("TXT1", m3TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT2))
				request.WithQueryParameter("TXT2", m3TXT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLG6))
				request.WithQueryParameter("PLG6", m3PLG6.Trim());
			if (m3APON.HasValue)
				request.WithQueryParameter("APON", m3APON.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NXOP.HasValue)
				request.WithQueryParameter("NXOP", m3NXOP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SLAT))
				request.WithQueryParameter("SLAT", m3SLAT.Trim());
			if (m3SLAC.HasValue)
				request.WithQueryParameter("SLAC", m3SLAC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POOC.HasValue)
				request.WithQueryParameter("POOC", m3POOC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESR))
				request.WithQueryParameter("RESR", m3RESR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGF))
				request.WithQueryParameter("PLGF", m3PLGF.Trim());
			if (m3PRET.HasValue)
				request.WithQueryParameter("PRET", m3PRET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POTM.HasValue)
				request.WithQueryParameter("POTM", m3POTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPLK.HasValue)
				request.WithQueryParameter("SPLK", m3SPLK.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPLF.HasValue)
				request.WithQueryParameter("SPLF", m3SPLF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPLN.HasValue)
				request.WithQueryParameter("SPLN", m3SPLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPSZ.HasValue)
				request.WithQueryParameter("SPSZ", m3SPSZ.Value.ToString(CultureInfo.CurrentCulture));

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
