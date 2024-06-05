/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.PDS002MI;
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
	/// Name: PDS002MI
	/// Component Name: ProductStructure
	/// Description: Product structure interface
	/// Version Release: 5ea7
	///</summary>
	public partial class PDS002MIResource : M3BaseResourceEndpoint
	{
		public PDS002MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PDS002MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddComponent
		/// Description Add Component
		/// Version Release: 5ea6
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3FDAT">From Date</param>
		/// <param name="m3STRD">Structure date</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="m3MTPL">Component number/work center</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3TECV">To revision number</param>
		/// <param name="m3FECV">From revision number</param>
		/// <param name="m3FLST">Floor stock</param>
		/// <param name="m3OVOP">Order initiated</param>
		/// <param name="m3OVTP">Phantom item</param>
		/// <param name="m3ACTS">Operation element number</param>
		/// <param name="m3SPMT">Issue method</param>
		/// <param name="m3FXCD">Fixed quantity</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3CNQT">Quantity</param>
		/// <param name="m3CCQT">Quantity on drawing</param>
		/// <param name="m3PEUN">Product engineering U/M</param>
		/// <param name="m3DWPO">Drawing position</param>
		/// <param name="m3VAPC">Option percentage</param>
		/// <param name="m3WAPC">Normal waste percentage</param>
		/// <param name="m3STGS">Subcontract control</param>
		/// <param name="m3SSUF">Subservice</param>
		/// <param name="m3FMT1">Text</param>
		/// <param name="m3FMT2">Technical reference</param>
		/// <param name="m3MPRC">Component price</param>
		/// <param name="m3EXMA">Yield component</param>
		/// <param name="m3CMCD">Lot controlling component</param>
		/// <param name="m3CRTM">Critical material</param>
		/// <param name="m3SDCD">Standard</param>
		/// <param name="m3BYPR">By/co-product code</param>
		/// <param name="m3LGTH">Length</param>
		/// <param name="m3WDTH">Width</param>
		/// <param name="m3LWF1">Factor 1</param>
		/// <param name="m3LWF2">Factor 2</param>
		/// <param name="m3SIDI">Selection identity - component</param>
		/// <param name="m3SITI">Selection type - component</param>
		/// <param name="m3SIDQ">Selection identity - quantity</param>
		/// <param name="m3SITQ">Selection type - quantity</param>
		/// <param name="m3FORI">Formula result identity</param>
		/// <param name="m3SDUP">Skip direct update</param>
		/// <param name="m3DSP6">Warning Indicator 1</param>
		/// <param name="m3DSP5">Warning Indicator 2</param>
		/// <param name="m3NORD">Additional days - material reservation</param>
		/// <param name="m3RTHI">Reservation time - material</param>
		/// <param name="m3AADM">Add components - not in item master</param>
		/// <param name="m3INHI">Item to inherit from</param>
		/// <param name="m3EXCH">Exchange</param>
		/// <param name="m3VRSN">Version</param>
		/// <param name="m3ELRF">External line reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddComponent(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3MSEQ = null, 
			int? m3OPNO = null, 
			int? m3FDAT = null, 
			int? m3STRD = null, 
			string m3ECVE = null, 
			string m3MTPL = null, 
			int? m3TDAT = null, 
			string m3TECV = null, 
			string m3FECV = null, 
			int? m3FLST = null, 
			string m3OVOP = null, 
			string m3OVTP = null, 
			int? m3ACTS = null, 
			int? m3SPMT = null, 
			int? m3FXCD = null, 
			string m3WHLO = null, 
			string m3WHSL = null, 
			string m3CNQT = null, 
			string m3CCQT = null, 
			string m3PEUN = null, 
			string m3DWPO = null, 
			int? m3VAPC = null, 
			int? m3WAPC = null, 
			int? m3STGS = null, 
			string m3SSUF = null, 
			string m3FMT1 = null, 
			string m3FMT2 = null, 
			string m3MPRC = null, 
			int? m3EXMA = null, 
			int? m3CMCD = null, 
			int? m3CRTM = null, 
			int? m3SDCD = null, 
			int? m3BYPR = null, 
			int? m3LGTH = null, 
			int? m3WDTH = null, 
			string m3LWF1 = null, 
			string m3LWF2 = null, 
			string m3SIDI = null, 
			int? m3SITI = null, 
			string m3SIDQ = null, 
			int? m3SITQ = null, 
			string m3FORI = null, 
			string m3SDUP = null, 
			int? m3DSP6 = null, 
			int? m3DSP5 = null, 
			string m3NORD = null, 
			int? m3RTHI = null, 
			int? m3AADM = null, 
			int? m3INHI = null, 
			int? m3EXCH = null, 
			int? m3VRSN = null, 
			int? m3ELRF = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddComponent",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STRD.HasValue)
				request.WithQueryParameter("STRD", m3STRD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTPL))
				request.WithQueryParameter("MTPL", m3MTPL.Trim());
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TECV))
				request.WithQueryParameter("TECV", m3TECV.Trim());
			if (!string.IsNullOrWhiteSpace(m3FECV))
				request.WithQueryParameter("FECV", m3FECV.Trim());
			if (m3FLST.HasValue)
				request.WithQueryParameter("FLST", m3FLST.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OVOP))
				request.WithQueryParameter("OVOP", m3OVOP.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVTP))
				request.WithQueryParameter("OVTP", m3OVTP.Trim());
			if (m3ACTS.HasValue)
				request.WithQueryParameter("ACTS", m3ACTS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3SPMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FXCD.HasValue)
				request.WithQueryParameter("FXCD", m3FXCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CNQT))
				request.WithQueryParameter("CNQT", m3CNQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3CCQT))
				request.WithQueryParameter("CCQT", m3CCQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PEUN))
				request.WithQueryParameter("PEUN", m3PEUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3DWPO))
				request.WithQueryParameter("DWPO", m3DWPO.Trim());
			if (m3VAPC.HasValue)
				request.WithQueryParameter("VAPC", m3VAPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAPC.HasValue)
				request.WithQueryParameter("WAPC", m3WAPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STGS.HasValue)
				request.WithQueryParameter("STGS", m3STGS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SSUF))
				request.WithQueryParameter("SSUF", m3SSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMT1))
				request.WithQueryParameter("FMT1", m3FMT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMT2))
				request.WithQueryParameter("FMT2", m3FMT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MPRC))
				request.WithQueryParameter("MPRC", m3MPRC.Trim());
			if (m3EXMA.HasValue)
				request.WithQueryParameter("EXMA", m3EXMA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CMCD.HasValue)
				request.WithQueryParameter("CMCD", m3CMCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3CRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SDCD.HasValue)
				request.WithQueryParameter("SDCD", m3SDCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BYPR.HasValue)
				request.WithQueryParameter("BYPR", m3BYPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LGTH.HasValue)
				request.WithQueryParameter("LGTH", m3LGTH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WDTH.HasValue)
				request.WithQueryParameter("WDTH", m3WDTH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LWF1))
				request.WithQueryParameter("LWF1", m3LWF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3LWF2))
				request.WithQueryParameter("LWF2", m3LWF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SIDI))
				request.WithQueryParameter("SIDI", m3SIDI.Trim());
			if (m3SITI.HasValue)
				request.WithQueryParameter("SITI", m3SITI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SIDQ))
				request.WithQueryParameter("SIDQ", m3SIDQ.Trim());
			if (m3SITQ.HasValue)
				request.WithQueryParameter("SITQ", m3SITQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FORI))
				request.WithQueryParameter("FORI", m3FORI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDUP))
				request.WithQueryParameter("SDUP", m3SDUP.Trim());
			if (m3DSP6.HasValue)
				request.WithQueryParameter("DSP6", m3DSP6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP5.HasValue)
				request.WithQueryParameter("DSP5", m3DSP5.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NORD))
				request.WithQueryParameter("NORD", m3NORD.Trim());
			if (m3RTHI.HasValue)
				request.WithQueryParameter("RTHI", m3RTHI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AADM.HasValue)
				request.WithQueryParameter("AADM", m3AADM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INHI.HasValue)
				request.WithQueryParameter("INHI", m3INHI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXCH.HasValue)
				request.WithQueryParameter("EXCH", m3EXCH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3VRSN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ELRF.HasValue)
				request.WithQueryParameter("ELRF", m3ELRF.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Description Add Operation
		/// Version Release: 5ea6
		/// </summary>
		/// <param name="m3SDCD">Standard (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3STRD">Structure date</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="m3MTPL">Component number/work center</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3OPDS">Operation description</param>
		/// <param name="m3PITI">Run time</param>
		/// <param name="m3CTCD">Price and time quantity</param>
		/// <param name="m3SETI">Setup time</param>
		/// <param name="m3FXTI">Fixed time</param>
		/// <param name="m3OSET">External setup time</param>
		/// <param name="m3PRNM">Planned number of machines</param>
		/// <param name="m3PRNP">Planned number of workers - run time</param>
		/// <param name="m3PHOP">Phantom operation method</param>
		/// <param name="m3SENP">Planned number of workers - setup</param>
		/// <param name="m3ODBF">Lead time offset</param>
		/// <param name="m3PRDY">Production days</param>
		/// <param name="m3SLAC">Transport value in days</param>
		/// <param name="m3VAPC">Option percentage</param>
		/// <param name="m3SCPC">Scrap percentage</param>
		/// <param name="m3SWQT">Setup scrap</param>
		/// <param name="m3DOID">Document identity</param>
		/// <param name="m3TOOL">Tool number</param>
		/// <param name="m3WLDE">Infinite/finite</param>
		/// <param name="m3SUBC">Subcontract control</param>
		/// <param name="m3SSUF">Subservice</param>
		/// <param name="m3LASK">Labor skill</param>
		/// <param name="m3INSK">Inspection skill</param>
		/// <param name="m3PIPR">Unit price</param>
		/// <param name="m3WAFA">Time rate</param>
		/// <param name="m3SEPR">Setup price</param>
		/// <param name="m3WCRF">Time reference</param>
		/// <param name="m3KIWG">Pay element</param>
		/// <param name="m3CAMP">Number of labor tickets</param>
		/// <param name="m3INWE">Initial weight</param>
		/// <param name="m3OPV3">Operation volume</param>
		/// <param name="m3MFPR">Multiplication factor - manufacturing</param>
		/// <param name="m3AURP">Automatic operation reporting</param>
		/// <param name="m3OPCM">Operation cost multiplier</param>
		/// <param name="m3AUIN">Automatic receipt</param>
		/// <param name="m3CFID">Formula</param>
		/// <param name="m3CFRI">Formula result</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3NSUN">Supplier at agent</param>
		/// <param name="m3TXT1">Text line 1</param>
		/// <param name="m3TXT2">Text line 2</param>
		/// <param name="m3ASOP">Assembly operation</param>
		/// <param name="m3SDUP">Skip direct update</param>
		/// <param name="m3TDAT">To Date</param>
		/// <param name="m3VRSN">Version</param>
		/// <param name="m3MFP2">Multiplication factor - manufacturing</param>
		/// <param name="m3AMAO">Additional Material Offset</param>
		/// <param name="m3APON">APP operation number</param>
		/// <param name="m3NXOP">Next APP operation number</param>
		/// <param name="m3SLAT">Transit unit of measure/Overlap code</param>
		/// <param name="m3POOC">Parallel operation overlap code</param>
		/// <param name="m3RESR">Resource restriction</param>
		/// <param name="m3PRET">Preparation time</param>
		/// <param name="m3SPLK">Split method - operation</param>
		/// <param name="m3SPLN">Number of operations after split</param>
		/// <param name="m3SPSZ">Split quantity</param>
		/// <param name="m3MDOP">Max duration of operation in percent</param>
		/// <param name="m3POTM">Post-operation time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddOperation(
			int m3SDCD, 
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3MSEQ = null, 
			int? m3OPNO = null, 
			int? m3FDAT = null, 
			int? m3STRD = null, 
			string m3ECVE = null, 
			string m3MTPL = null, 
			string m3PLGR = null, 
			string m3OPDS = null, 
			int? m3PITI = null, 
			int? m3CTCD = null, 
			int? m3SETI = null, 
			int? m3FXTI = null, 
			int? m3OSET = null, 
			int? m3PRNM = null, 
			int? m3PRNP = null, 
			int? m3PHOP = null, 
			int? m3SENP = null, 
			int? m3ODBF = null, 
			int? m3PRDY = null, 
			string m3SLAC = null, 
			int? m3VAPC = null, 
			int? m3SCPC = null, 
			string m3SWQT = null, 
			string m3DOID = null, 
			string m3TOOL = null, 
			int? m3WLDE = null, 
			string m3SUBC = null, 
			string m3SSUF = null, 
			string m3LASK = null, 
			string m3INSK = null, 
			string m3PIPR = null, 
			string m3WAFA = null, 
			string m3SEPR = null, 
			string m3WCRF = null, 
			int? m3KIWG = null, 
			int? m3CAMP = null, 
			int? m3INWE = null, 
			int? m3OPV3 = null, 
			int? m3MFPR = null, 
			int? m3AURP = null, 
			int? m3OPCM = null, 
			int? m3AUIN = null, 
			string m3CFID = null, 
			string m3CFRI = null, 
			string m3SUNO = null, 
			string m3NSUN = null, 
			string m3TXT1 = null, 
			string m3TXT2 = null, 
			int? m3ASOP = null, 
			string m3SDUP = null, 
			int? m3TDAT = null, 
			int? m3VRSN = null, 
			int? m3MFP2 = null, 
			int? m3AMAO = null, 
			int? m3APON = null, 
			int? m3NXOP = null, 
			string m3SLAT = null, 
			int? m3POOC = null, 
			string m3RESR = null, 
			int? m3PRET = null, 
			int? m3SPLK = null, 
			int? m3SPLN = null, 
			decimal? m3SPSZ = null, 
			int? m3MDOP = null, 
			int? m3POTM = null, 
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

			// Set mandatory parameters
			request
				.WithQueryParameter("SDCD", m3SDCD.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STRD.HasValue)
				request.WithQueryParameter("STRD", m3STRD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTPL))
				request.WithQueryParameter("MTPL", m3MTPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPDS))
				request.WithQueryParameter("OPDS", m3OPDS.Trim());
			if (m3PITI.HasValue)
				request.WithQueryParameter("PITI", m3PITI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CTCD.HasValue)
				request.WithQueryParameter("CTCD", m3CTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SETI.HasValue)
				request.WithQueryParameter("SETI", m3SETI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FXTI.HasValue)
				request.WithQueryParameter("FXTI", m3FXTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OSET.HasValue)
				request.WithQueryParameter("OSET", m3OSET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNM.HasValue)
				request.WithQueryParameter("PRNM", m3PRNM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3PRNP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PHOP.HasValue)
				request.WithQueryParameter("PHOP", m3PHOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SENP.HasValue)
				request.WithQueryParameter("SENP", m3SENP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ODBF.HasValue)
				request.WithQueryParameter("ODBF", m3ODBF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRDY.HasValue)
				request.WithQueryParameter("PRDY", m3PRDY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SLAC))
				request.WithQueryParameter("SLAC", m3SLAC.Trim());
			if (m3VAPC.HasValue)
				request.WithQueryParameter("VAPC", m3VAPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCPC.HasValue)
				request.WithQueryParameter("SCPC", m3SCPC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SWQT))
				request.WithQueryParameter("SWQT", m3SWQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOOL))
				request.WithQueryParameter("TOOL", m3TOOL.Trim());
			if (m3WLDE.HasValue)
				request.WithQueryParameter("WLDE", m3WLDE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUBC))
				request.WithQueryParameter("SUBC", m3SUBC.Trim());
			if (!string.IsNullOrWhiteSpace(m3SSUF))
				request.WithQueryParameter("SSUF", m3SSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3LASK))
				request.WithQueryParameter("LASK", m3LASK.Trim());
			if (!string.IsNullOrWhiteSpace(m3INSK))
				request.WithQueryParameter("INSK", m3INSK.Trim());
			if (!string.IsNullOrWhiteSpace(m3PIPR))
				request.WithQueryParameter("PIPR", m3PIPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3WAFA))
				request.WithQueryParameter("WAFA", m3WAFA.Trim());
			if (!string.IsNullOrWhiteSpace(m3SEPR))
				request.WithQueryParameter("SEPR", m3SEPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3WCRF))
				request.WithQueryParameter("WCRF", m3WCRF.Trim());
			if (m3KIWG.HasValue)
				request.WithQueryParameter("KIWG", m3KIWG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAMP.HasValue)
				request.WithQueryParameter("CAMP", m3CAMP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INWE.HasValue)
				request.WithQueryParameter("INWE", m3INWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPV3.HasValue)
				request.WithQueryParameter("OPV3", m3OPV3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MFPR.HasValue)
				request.WithQueryParameter("MFPR", m3MFPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AURP.HasValue)
				request.WithQueryParameter("AURP", m3AURP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPCM.HasValue)
				request.WithQueryParameter("OPCM", m3OPCM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUIN.HasValue)
				request.WithQueryParameter("AUIN", m3AUIN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFID))
				request.WithQueryParameter("CFID", m3CFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFRI))
				request.WithQueryParameter("CFRI", m3CFRI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3NSUN))
				request.WithQueryParameter("NSUN", m3NSUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT1))
				request.WithQueryParameter("TXT1", m3TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT2))
				request.WithQueryParameter("TXT2", m3TXT2.Trim());
			if (m3ASOP.HasValue)
				request.WithQueryParameter("ASOP", m3ASOP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SDUP))
				request.WithQueryParameter("SDUP", m3SDUP.Trim());
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3VRSN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MFP2.HasValue)
				request.WithQueryParameter("MFP2", m3MFP2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMAO.HasValue)
				request.WithQueryParameter("AMAO", m3AMAO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3APON.HasValue)
				request.WithQueryParameter("APON", m3APON.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NXOP.HasValue)
				request.WithQueryParameter("NXOP", m3NXOP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SLAT))
				request.WithQueryParameter("SLAT", m3SLAT.Trim());
			if (m3POOC.HasValue)
				request.WithQueryParameter("POOC", m3POOC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESR))
				request.WithQueryParameter("RESR", m3RESR.Trim());
			if (m3PRET.HasValue)
				request.WithQueryParameter("PRET", m3PRET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPLK.HasValue)
				request.WithQueryParameter("SPLK", m3SPLK.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPLN.HasValue)
				request.WithQueryParameter("SPLN", m3SPLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPSZ.HasValue)
				request.WithQueryParameter("SPSZ", m3SPSZ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MDOP.HasValue)
				request.WithQueryParameter("MDOP", m3MDOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POTM.HasValue)
				request.WithQueryParameter("POTM", m3POTM.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddOperation2
		/// Description Add OEM for Operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STRT">Product structure type</param>
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
		public async Task<M3Response<M3Record>> AddOperation2(
			string m3FACI, 
			string m3PRNO, 
			int m3OPNO, 
			int? m3CONO = null, 
			string m3STRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddOperation2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
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
		/// Name CpyComp
		/// Description Copy Operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3CSEQ">Sequence number</param>
		/// <param name="m3CFDT">From date</param>
		/// <param name="m3VRSN">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyComp(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3MSEQ = null, 
			DateTime? m3FDAT = null, 
			int? m3CSEQ = null, 
			DateTime? m3CFDT = null, 
			int? m3VRSN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyComp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3CSEQ.HasValue)
				request.WithQueryParameter("CSEQ", m3CSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFDT.HasValue)
				request.WithQueryParameter("CFDT", m3CFDT.Value.ToM3String());
			if (m3VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3VRSN.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name CpyComponent
		/// Description Copy Component
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3FDAT">From Date</param>
		/// <param name="m3CSEQ">Sequence number</param>
		/// <param name="m3COPN">Operation number</param>
		/// <param name="m3CFDT">From Date</param>
		/// <param name="m3STRD">Structure date</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="m3MTPL">Component number/work center</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3TECV">To revision number</param>
		/// <param name="m3FECV">From revision number</param>
		/// <param name="m3FLST">Floor stock</param>
		/// <param name="m3OVOP">Order initiated</param>
		/// <param name="m3OVTP">Phantom item</param>
		/// <param name="m3ACTS">Operation element number</param>
		/// <param name="m3SPMT">Issue method</param>
		/// <param name="m3FXCD">Fixed quantity</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3CNQT">Quantity</param>
		/// <param name="m3CCQT">Quantity on drawing</param>
		/// <param name="m3PEUN">Product engineering U/M</param>
		/// <param name="m3DWPO">Drawing position</param>
		/// <param name="m3VAPC">Option percentage</param>
		/// <param name="m3WAPC">Normal waste percentage</param>
		/// <param name="m3STGS">Subcontract control</param>
		/// <param name="m3SSUF">Subservice</param>
		/// <param name="m3FMT1">Text</param>
		/// <param name="m3FMT2">Technical reference</param>
		/// <param name="m3MPRC">Component price</param>
		/// <param name="m3EXMA">Yield component</param>
		/// <param name="m3CMCD">Lot controlling component</param>
		/// <param name="m3CRTM">Critical material</param>
		/// <param name="m3SDCD">Standard</param>
		/// <param name="m3BYPR">By/co-product code</param>
		/// <param name="m3LGTH">Length</param>
		/// <param name="m3WDTH">Width</param>
		/// <param name="m3LWF1">Factor 1</param>
		/// <param name="m3LWF2">Factor 2</param>
		/// <param name="m3SIDI">Selection identity - component</param>
		/// <param name="m3SITI">Selection type - component</param>
		/// <param name="m3SIDQ">Selection identity - quantity</param>
		/// <param name="m3SITQ">Selection type - quantity</param>
		/// <param name="m3FORI">Formula result identity</param>
		/// <param name="m3SDUP">Skip direct update</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyComponent(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3MSEQ = null, 
			int? m3OPNO = null, 
			int? m3FDAT = null, 
			int? m3CSEQ = null, 
			int? m3COPN = null, 
			DateTime? m3CFDT = null, 
			int? m3STRD = null, 
			string m3ECVE = null, 
			string m3MTPL = null, 
			int? m3TDAT = null, 
			string m3TECV = null, 
			string m3FECV = null, 
			int? m3FLST = null, 
			string m3OVOP = null, 
			string m3OVTP = null, 
			int? m3ACTS = null, 
			int? m3SPMT = null, 
			int? m3FXCD = null, 
			string m3WHLO = null, 
			string m3WHSL = null, 
			string m3CNQT = null, 
			string m3CCQT = null, 
			string m3PEUN = null, 
			string m3DWPO = null, 
			int? m3VAPC = null, 
			int? m3WAPC = null, 
			int? m3STGS = null, 
			string m3SSUF = null, 
			string m3FMT1 = null, 
			string m3FMT2 = null, 
			string m3MPRC = null, 
			int? m3EXMA = null, 
			int? m3CMCD = null, 
			int? m3CRTM = null, 
			int? m3SDCD = null, 
			int? m3BYPR = null, 
			int? m3LGTH = null, 
			int? m3WDTH = null, 
			string m3LWF1 = null, 
			string m3LWF2 = null, 
			string m3SIDI = null, 
			int? m3SITI = null, 
			string m3SIDQ = null, 
			int? m3SITQ = null, 
			string m3FORI = null, 
			string m3SDUP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyComponent",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CSEQ.HasValue)
				request.WithQueryParameter("CSEQ", m3CSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COPN.HasValue)
				request.WithQueryParameter("COPN", m3COPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFDT.HasValue)
				request.WithQueryParameter("CFDT", m3CFDT.Value.ToM3String());
			if (m3STRD.HasValue)
				request.WithQueryParameter("STRD", m3STRD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTPL))
				request.WithQueryParameter("MTPL", m3MTPL.Trim());
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TECV))
				request.WithQueryParameter("TECV", m3TECV.Trim());
			if (!string.IsNullOrWhiteSpace(m3FECV))
				request.WithQueryParameter("FECV", m3FECV.Trim());
			if (m3FLST.HasValue)
				request.WithQueryParameter("FLST", m3FLST.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OVOP))
				request.WithQueryParameter("OVOP", m3OVOP.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVTP))
				request.WithQueryParameter("OVTP", m3OVTP.Trim());
			if (m3ACTS.HasValue)
				request.WithQueryParameter("ACTS", m3ACTS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3SPMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FXCD.HasValue)
				request.WithQueryParameter("FXCD", m3FXCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CNQT))
				request.WithQueryParameter("CNQT", m3CNQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3CCQT))
				request.WithQueryParameter("CCQT", m3CCQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PEUN))
				request.WithQueryParameter("PEUN", m3PEUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3DWPO))
				request.WithQueryParameter("DWPO", m3DWPO.Trim());
			if (m3VAPC.HasValue)
				request.WithQueryParameter("VAPC", m3VAPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAPC.HasValue)
				request.WithQueryParameter("WAPC", m3WAPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STGS.HasValue)
				request.WithQueryParameter("STGS", m3STGS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SSUF))
				request.WithQueryParameter("SSUF", m3SSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMT1))
				request.WithQueryParameter("FMT1", m3FMT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMT2))
				request.WithQueryParameter("FMT2", m3FMT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MPRC))
				request.WithQueryParameter("MPRC", m3MPRC.Trim());
			if (m3EXMA.HasValue)
				request.WithQueryParameter("EXMA", m3EXMA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CMCD.HasValue)
				request.WithQueryParameter("CMCD", m3CMCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3CRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SDCD.HasValue)
				request.WithQueryParameter("SDCD", m3SDCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BYPR.HasValue)
				request.WithQueryParameter("BYPR", m3BYPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LGTH.HasValue)
				request.WithQueryParameter("LGTH", m3LGTH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WDTH.HasValue)
				request.WithQueryParameter("WDTH", m3WDTH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LWF1))
				request.WithQueryParameter("LWF1", m3LWF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3LWF2))
				request.WithQueryParameter("LWF2", m3LWF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SIDI))
				request.WithQueryParameter("SIDI", m3SIDI.Trim());
			if (m3SITI.HasValue)
				request.WithQueryParameter("SITI", m3SITI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SIDQ))
				request.WithQueryParameter("SIDQ", m3SIDQ.Trim());
			if (m3SITQ.HasValue)
				request.WithQueryParameter("SITQ", m3SITQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FORI))
				request.WithQueryParameter("FORI", m3FORI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDUP))
				request.WithQueryParameter("SDUP", m3SDUP.Trim());

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
		/// Name CpyOper
		/// Description Copy Operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3COPN">Operation number</param>
		/// <param name="m3CFDT">From date</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3VRSN">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyOper(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3OPNO = null, 
			DateTime? m3FDAT = null, 
			int? m3COPN = null, 
			DateTime? m3CFDT = null, 
			DateTime? m3TDAT = null, 
			int? m3VRSN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyOper",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3COPN.HasValue)
				request.WithQueryParameter("COPN", m3COPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFDT.HasValue)
				request.WithQueryParameter("CFDT", m3CFDT.Value.ToM3String());
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());
			if (m3VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3VRSN.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name CpyOperation
		/// Description Copy Operation
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3CSEQ">Sequence number</param>
		/// <param name="m3COPN">Operation number</param>
		/// <param name="m3CFDT">From Date</param>
		/// <param name="m3STRD">Structure date</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="m3MTPL">Component number/work center</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3OPDS">Operation description</param>
		/// <param name="m3PITI">Run time</param>
		/// <param name="m3CTCD">Price and time quantity</param>
		/// <param name="m3SETI">Setup time</param>
		/// <param name="m3FXTI">Fixed time</param>
		/// <param name="m3OSET">External setup time</param>
		/// <param name="m3PRNM">Planned number of machines</param>
		/// <param name="m3PRNP">Planned number of workers - run time</param>
		/// <param name="m3PHOP">Phantom operation method</param>
		/// <param name="m3SENP">Planned number of workers - setup</param>
		/// <param name="m3ODBF">Lead time offset</param>
		/// <param name="m3PRDY">Production days</param>
		/// <param name="m3SLAC">Transport value in days</param>
		/// <param name="m3VAPC">Option percentage</param>
		/// <param name="m3SCPC">Scrap percentage</param>
		/// <param name="m3SWQT">Setup scrap</param>
		/// <param name="m3DOID">Document identity</param>
		/// <param name="m3TOOL">Tool number</param>
		/// <param name="m3WLDE">Infinite/finite</param>
		/// <param name="m3SUBC">Subcontract control</param>
		/// <param name="m3SSUF">Subservice</param>
		/// <param name="m3LASK">Labor skill</param>
		/// <param name="m3SDCD">Standard</param>
		/// <param name="m3INSK">Inspection skill</param>
		/// <param name="m3PIPR">Unit price</param>
		/// <param name="m3WAFA">Time rate</param>
		/// <param name="m3SEPR">Setup price</param>
		/// <param name="m3WCRF">Time reference</param>
		/// <param name="m3KIWG">Pay element</param>
		/// <param name="m3CAMP">Number of labor tickets</param>
		/// <param name="m3INWE">Initial weight</param>
		/// <param name="m3OPV3">Operation volume</param>
		/// <param name="m3MFPR">Multiplication factor - manufacturing</param>
		/// <param name="m3AURP">Automatic operation reporting</param>
		/// <param name="m3OPCM">Operation cost multiplier</param>
		/// <param name="m3AUIN">Automatic receipt</param>
		/// <param name="m3CFID">Formula</param>
		/// <param name="m3CFRI">Formula result</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3NSUN">Supplier at agent</param>
		/// <param name="m3TXT1">Text line 1</param>
		/// <param name="m3TXT2">Text line 2</param>
		/// <param name="m3ASOP">Assembly operation</param>
		/// <param name="m3SDUP">Skip direct update</param>
		/// <param name="m3MFP2">Multiplication factor - manufacturing</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyOperation(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3MSEQ = null, 
			int? m3OPNO = null, 
			int? m3FDAT = null, 
			int? m3CSEQ = null, 
			int? m3COPN = null, 
			DateTime? m3CFDT = null, 
			int? m3STRD = null, 
			string m3ECVE = null, 
			string m3MTPL = null, 
			string m3PLGR = null, 
			string m3OPDS = null, 
			int? m3PITI = null, 
			int? m3CTCD = null, 
			int? m3SETI = null, 
			int? m3FXTI = null, 
			int? m3OSET = null, 
			int? m3PRNM = null, 
			int? m3PRNP = null, 
			int? m3PHOP = null, 
			int? m3SENP = null, 
			int? m3ODBF = null, 
			int? m3PRDY = null, 
			string m3SLAC = null, 
			int? m3VAPC = null, 
			int? m3SCPC = null, 
			string m3SWQT = null, 
			string m3DOID = null, 
			string m3TOOL = null, 
			int? m3WLDE = null, 
			string m3SUBC = null, 
			string m3SSUF = null, 
			string m3LASK = null, 
			int? m3SDCD = null, 
			string m3INSK = null, 
			string m3PIPR = null, 
			string m3WAFA = null, 
			string m3SEPR = null, 
			string m3WCRF = null, 
			int? m3KIWG = null, 
			int? m3CAMP = null, 
			int? m3INWE = null, 
			int? m3OPV3 = null, 
			int? m3MFPR = null, 
			int? m3AURP = null, 
			int? m3OPCM = null, 
			int? m3AUIN = null, 
			string m3CFID = null, 
			string m3CFRI = null, 
			string m3SUNO = null, 
			string m3NSUN = null, 
			string m3TXT1 = null, 
			string m3TXT2 = null, 
			int? m3ASOP = null, 
			string m3SDUP = null, 
			int? m3MFP2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyOperation",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CSEQ.HasValue)
				request.WithQueryParameter("CSEQ", m3CSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COPN.HasValue)
				request.WithQueryParameter("COPN", m3COPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFDT.HasValue)
				request.WithQueryParameter("CFDT", m3CFDT.Value.ToM3String());
			if (m3STRD.HasValue)
				request.WithQueryParameter("STRD", m3STRD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTPL))
				request.WithQueryParameter("MTPL", m3MTPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPDS))
				request.WithQueryParameter("OPDS", m3OPDS.Trim());
			if (m3PITI.HasValue)
				request.WithQueryParameter("PITI", m3PITI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CTCD.HasValue)
				request.WithQueryParameter("CTCD", m3CTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SETI.HasValue)
				request.WithQueryParameter("SETI", m3SETI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FXTI.HasValue)
				request.WithQueryParameter("FXTI", m3FXTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OSET.HasValue)
				request.WithQueryParameter("OSET", m3OSET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNM.HasValue)
				request.WithQueryParameter("PRNM", m3PRNM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3PRNP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PHOP.HasValue)
				request.WithQueryParameter("PHOP", m3PHOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SENP.HasValue)
				request.WithQueryParameter("SENP", m3SENP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ODBF.HasValue)
				request.WithQueryParameter("ODBF", m3ODBF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRDY.HasValue)
				request.WithQueryParameter("PRDY", m3PRDY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SLAC))
				request.WithQueryParameter("SLAC", m3SLAC.Trim());
			if (m3VAPC.HasValue)
				request.WithQueryParameter("VAPC", m3VAPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCPC.HasValue)
				request.WithQueryParameter("SCPC", m3SCPC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SWQT))
				request.WithQueryParameter("SWQT", m3SWQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOOL))
				request.WithQueryParameter("TOOL", m3TOOL.Trim());
			if (m3WLDE.HasValue)
				request.WithQueryParameter("WLDE", m3WLDE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUBC))
				request.WithQueryParameter("SUBC", m3SUBC.Trim());
			if (!string.IsNullOrWhiteSpace(m3SSUF))
				request.WithQueryParameter("SSUF", m3SSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3LASK))
				request.WithQueryParameter("LASK", m3LASK.Trim());
			if (m3SDCD.HasValue)
				request.WithQueryParameter("SDCD", m3SDCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INSK))
				request.WithQueryParameter("INSK", m3INSK.Trim());
			if (!string.IsNullOrWhiteSpace(m3PIPR))
				request.WithQueryParameter("PIPR", m3PIPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3WAFA))
				request.WithQueryParameter("WAFA", m3WAFA.Trim());
			if (!string.IsNullOrWhiteSpace(m3SEPR))
				request.WithQueryParameter("SEPR", m3SEPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3WCRF))
				request.WithQueryParameter("WCRF", m3WCRF.Trim());
			if (m3KIWG.HasValue)
				request.WithQueryParameter("KIWG", m3KIWG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAMP.HasValue)
				request.WithQueryParameter("CAMP", m3CAMP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INWE.HasValue)
				request.WithQueryParameter("INWE", m3INWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPV3.HasValue)
				request.WithQueryParameter("OPV3", m3OPV3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MFPR.HasValue)
				request.WithQueryParameter("MFPR", m3MFPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AURP.HasValue)
				request.WithQueryParameter("AURP", m3AURP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPCM.HasValue)
				request.WithQueryParameter("OPCM", m3OPCM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUIN.HasValue)
				request.WithQueryParameter("AUIN", m3AUIN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFID))
				request.WithQueryParameter("CFID", m3CFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFRI))
				request.WithQueryParameter("CFRI", m3CFRI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3NSUN))
				request.WithQueryParameter("NSUN", m3NSUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT1))
				request.WithQueryParameter("TXT1", m3TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT2))
				request.WithQueryParameter("TXT2", m3TXT2.Trim());
			if (m3ASOP.HasValue)
				request.WithQueryParameter("ASOP", m3ASOP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SDUP))
				request.WithQueryParameter("SDUP", m3SDUP.Trim());
			if (m3MFP2.HasValue)
				request.WithQueryParameter("MFP2", m3MFP2.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Delete
		/// Description Delete
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3SDUP">Skip direct update</param>
		/// <param name="m3VRSN">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3MSEQ = null, 
			int? m3OPNO = null, 
			int? m3FDAT = null, 
			string m3SDUP = null, 
			int? m3VRSN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Delete",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SDUP))
				request.WithQueryParameter("SDUP", m3SDUP.Trim());
			if (m3VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3VRSN.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetComponent
		/// Description Get Component
		/// Version Release: 5ea6
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3VRSN">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetComponentResponse></returns>
		/// <exception cref="M3Exception<GetComponentResponse>"></exception>
		public async Task<M3Response<GetComponentResponse>> GetComponent(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3MSEQ = null, 
			int? m3OPNO = null, 
			int? m3FDAT = null, 
			int? m3VRSN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetComponent",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3VRSN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetComponentResponse>(
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
		/// Description Get Operation
		/// Version Release: 5ea6
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3VRSN">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOperationResponse></returns>
		/// <exception cref="M3Exception<GetOperationResponse>"></exception>
		public async Task<M3Response<GetOperationResponse>> GetOperation(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3MSEQ = null, 
			int? m3OPNO = null, 
			int? m3FDAT = null, 
			int? m3TDAT = null, 
			int? m3VRSN = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3VRSN.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetOperation2
		/// Description Get OEM for Operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOperation2Response></returns>
		/// <exception cref="M3Exception<GetOperation2Response>"></exception>
		public async Task<M3Response<GetOperation2Response>> GetOperation2(
			string m3FACI, 
			string m3PRNO, 
			int m3OPNO, 
			int? m3CONO = null, 
			string m3STRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetOperation2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());

			// Execute the request
			var result = await Execute<GetOperation2Response>(
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
		/// Name LstComponent
		/// Description List Component
		/// Version Release: 5ea6
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstComponentResponse></returns>
		/// <exception cref="M3Exception<LstComponentResponse>"></exception>
		public async Task<M3Response<LstComponentResponse>> LstComponent(
			string m3FACI, 
			int? m3CONO = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3MSEQ = null, 
			int? m3OPNO = null, 
			int? m3FDAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstComponent",
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
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstComponentResponse>(
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
		/// Name LstKitItems
		/// Description List Component
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstKitItemsResponse></returns>
		/// <exception cref="M3Exception<LstKitItemsResponse>"></exception>
		public async Task<M3Response<LstKitItemsResponse>> LstKitItems(
			string m3FACI, 
			int? m3CONO = null, 
			string m3STRT = null, 
			string m3PRNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstKitItems",
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
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());

			// Execute the request
			var result = await Execute<LstKitItemsResponse>(
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
		/// Name LstOperation
		/// Description List Operation
		/// Version Release: 5ea6
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOperationResponse></returns>
		/// <exception cref="M3Exception<LstOperationResponse>"></exception>
		public async Task<M3Response<LstOperationResponse>> LstOperation(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3MSEQ = null, 
			int? m3OPNO = null, 
			int? m3FDAT = null, 
			int? m3TDAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstOperation",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstOperationResponse>(
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
		/// Description Search material
		/// Version Release: 5ea2
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
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchMaterial",
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
		/// Description Search operation
		/// Version Release: 5ea2
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
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchOperation",
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
		/// Name SelMatByHead
		/// Description Transfer Material
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3APIP">APS - policy</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3CRTM">Critical material</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelMatByHeadResponse></returns>
		/// <exception cref="M3Exception<SelMatByHeadResponse>"></exception>
		public async Task<M3Response<SelMatByHeadResponse>> SelMatByHead(
			string m3FACI, 
			string m3APIP = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3CRTM = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3CRTM.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name SelOpeByHead
		/// Description Transfer Operations
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3APIP">APS - policy</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3CRTR">Critical resource</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelOpeByHeadResponse></returns>
		/// <exception cref="M3Exception<SelOpeByHeadResponse>"></exception>
		public async Task<M3Response<SelOpeByHeadResponse>> SelOpeByHead(
			string m3FACI, 
			string m3APIP = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelOpeByHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3CRTR.HasValue)
				request.WithQueryParameter("CRTR", m3CRTR.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdOperation2
		/// Description Update OEM for Operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SMC0">User defined field 0</param>
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
		public async Task<M3Response<M3Record>> UpdOperation2(
			string m3FACI, 
			string m3PRNO, 
			int m3OPNO, 
			int? m3CONO = null, 
			string m3STRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdOperation2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
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
		/// Name UpdateComponent
		/// Description Update Component
		/// Version Release: 5ea6
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3FDAT">From Date</param>
		/// <param name="m3STRD">Structure date</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="m3MTPL">Component number/work center</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3TECV">To revision number</param>
		/// <param name="m3FECV">From revision number</param>
		/// <param name="m3FLST">Floor stock</param>
		/// <param name="m3OVOP">Order initiated</param>
		/// <param name="m3OVTP">Phantom item</param>
		/// <param name="m3ACTS">Operation element number</param>
		/// <param name="m3SPMT">Issue method</param>
		/// <param name="m3FXCD">Fixed quantity</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3CNQT">Quantity</param>
		/// <param name="m3CCQT">Quantity on drawing</param>
		/// <param name="m3PEUN">Product engineering U/M</param>
		/// <param name="m3DWPO">Drawing position</param>
		/// <param name="m3VAPC">Option percentage</param>
		/// <param name="m3WAPC">Normal waste percentage</param>
		/// <param name="m3STGS">Subcontract control</param>
		/// <param name="m3SSUF">Subservice</param>
		/// <param name="m3FMT1">Text</param>
		/// <param name="m3FMT2">Technical reference</param>
		/// <param name="m3MPRC">Component price</param>
		/// <param name="m3EXMA">Yield component</param>
		/// <param name="m3CMCD">Lot controlling component</param>
		/// <param name="m3CRTM">Critical material</param>
		/// <param name="m3SDCD">Standard</param>
		/// <param name="m3BYPR">By/co-product code</param>
		/// <param name="m3LGTH">Length</param>
		/// <param name="m3WDTH">Width</param>
		/// <param name="m3LWF1">Factor 1</param>
		/// <param name="m3LWF2">Factor 2</param>
		/// <param name="m3SIDI">Selection identity - component</param>
		/// <param name="m3SITI">Selection type - component</param>
		/// <param name="m3SIDQ">Selection identity - quantity</param>
		/// <param name="m3SITQ">Selection type - quantity</param>
		/// <param name="m3FORI">Formula result identity</param>
		/// <param name="m3INHI">Item to inherit from</param>
		/// <param name="m3SDUP">Skip direct update</param>
		/// <param name="m3DSP6">Warning Indicator 1</param>
		/// <param name="m3DSP5">Warning Indicator 2</param>
		/// <param name="m3EXCH">Exchange</param>
		/// <param name="m3VRSN">Version</param>
		/// <param name="m3ELRF">External line reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdateComponent(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3MSEQ = null, 
			int? m3OPNO = null, 
			int? m3FDAT = null, 
			int? m3STRD = null, 
			string m3ECVE = null, 
			string m3MTPL = null, 
			int? m3TDAT = null, 
			string m3TECV = null, 
			string m3FECV = null, 
			int? m3FLST = null, 
			string m3OVOP = null, 
			string m3OVTP = null, 
			int? m3ACTS = null, 
			int? m3SPMT = null, 
			int? m3FXCD = null, 
			string m3WHLO = null, 
			string m3WHSL = null, 
			string m3CNQT = null, 
			string m3CCQT = null, 
			string m3PEUN = null, 
			string m3DWPO = null, 
			int? m3VAPC = null, 
			int? m3WAPC = null, 
			int? m3STGS = null, 
			string m3SSUF = null, 
			string m3FMT1 = null, 
			string m3FMT2 = null, 
			string m3MPRC = null, 
			int? m3EXMA = null, 
			int? m3CMCD = null, 
			int? m3CRTM = null, 
			int? m3SDCD = null, 
			int? m3BYPR = null, 
			int? m3LGTH = null, 
			int? m3WDTH = null, 
			string m3LWF1 = null, 
			string m3LWF2 = null, 
			string m3SIDI = null, 
			int? m3SITI = null, 
			string m3SIDQ = null, 
			int? m3SITQ = null, 
			string m3FORI = null, 
			int? m3INHI = null, 
			string m3SDUP = null, 
			int? m3DSP6 = null, 
			int? m3DSP5 = null, 
			int? m3EXCH = null, 
			int? m3VRSN = null, 
			int? m3ELRF = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdateComponent",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STRD.HasValue)
				request.WithQueryParameter("STRD", m3STRD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTPL))
				request.WithQueryParameter("MTPL", m3MTPL.Trim());
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TECV))
				request.WithQueryParameter("TECV", m3TECV.Trim());
			if (!string.IsNullOrWhiteSpace(m3FECV))
				request.WithQueryParameter("FECV", m3FECV.Trim());
			if (m3FLST.HasValue)
				request.WithQueryParameter("FLST", m3FLST.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OVOP))
				request.WithQueryParameter("OVOP", m3OVOP.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVTP))
				request.WithQueryParameter("OVTP", m3OVTP.Trim());
			if (m3ACTS.HasValue)
				request.WithQueryParameter("ACTS", m3ACTS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3SPMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FXCD.HasValue)
				request.WithQueryParameter("FXCD", m3FXCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CNQT))
				request.WithQueryParameter("CNQT", m3CNQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3CCQT))
				request.WithQueryParameter("CCQT", m3CCQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PEUN))
				request.WithQueryParameter("PEUN", m3PEUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3DWPO))
				request.WithQueryParameter("DWPO", m3DWPO.Trim());
			if (m3VAPC.HasValue)
				request.WithQueryParameter("VAPC", m3VAPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAPC.HasValue)
				request.WithQueryParameter("WAPC", m3WAPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STGS.HasValue)
				request.WithQueryParameter("STGS", m3STGS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SSUF))
				request.WithQueryParameter("SSUF", m3SSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMT1))
				request.WithQueryParameter("FMT1", m3FMT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMT2))
				request.WithQueryParameter("FMT2", m3FMT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MPRC))
				request.WithQueryParameter("MPRC", m3MPRC.Trim());
			if (m3EXMA.HasValue)
				request.WithQueryParameter("EXMA", m3EXMA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CMCD.HasValue)
				request.WithQueryParameter("CMCD", m3CMCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3CRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SDCD.HasValue)
				request.WithQueryParameter("SDCD", m3SDCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BYPR.HasValue)
				request.WithQueryParameter("BYPR", m3BYPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LGTH.HasValue)
				request.WithQueryParameter("LGTH", m3LGTH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WDTH.HasValue)
				request.WithQueryParameter("WDTH", m3WDTH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LWF1))
				request.WithQueryParameter("LWF1", m3LWF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3LWF2))
				request.WithQueryParameter("LWF2", m3LWF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SIDI))
				request.WithQueryParameter("SIDI", m3SIDI.Trim());
			if (m3SITI.HasValue)
				request.WithQueryParameter("SITI", m3SITI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SIDQ))
				request.WithQueryParameter("SIDQ", m3SIDQ.Trim());
			if (m3SITQ.HasValue)
				request.WithQueryParameter("SITQ", m3SITQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FORI))
				request.WithQueryParameter("FORI", m3FORI.Trim());
			if (m3INHI.HasValue)
				request.WithQueryParameter("INHI", m3INHI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SDUP))
				request.WithQueryParameter("SDUP", m3SDUP.Trim());
			if (m3DSP6.HasValue)
				request.WithQueryParameter("DSP6", m3DSP6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP5.HasValue)
				request.WithQueryParameter("DSP5", m3DSP5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXCH.HasValue)
				request.WithQueryParameter("EXCH", m3EXCH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3VRSN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ELRF.HasValue)
				request.WithQueryParameter("ELRF", m3ELRF.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdateOperation
		/// Description Update Operation
		/// Version Release: 5ea6
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3STRD">Structure date</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="m3MTPL">Component number/work center</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3OPDS">Operation description</param>
		/// <param name="m3PITI">Run time</param>
		/// <param name="m3CTCD">Price and time quantity</param>
		/// <param name="m3SETI">Setup time</param>
		/// <param name="m3FXTI">Fixed time</param>
		/// <param name="m3OSET">External setup time</param>
		/// <param name="m3PRNM">Planned number of machines</param>
		/// <param name="m3PRNP">Planned number of workers - run time</param>
		/// <param name="m3PHOP">Phantom operation method</param>
		/// <param name="m3SENP">Planned number of workers - setup</param>
		/// <param name="m3ODBF">Lead time offset</param>
		/// <param name="m3PRDY">Production days</param>
		/// <param name="m3SLAC">Transport value in days</param>
		/// <param name="m3VAPC">Option percentage</param>
		/// <param name="m3SCPC">Scrap percentage</param>
		/// <param name="m3SWQT">Setup scrap</param>
		/// <param name="m3DOID">Document identity</param>
		/// <param name="m3TOOL">Tool number</param>
		/// <param name="m3WLDE">Infinite/finite</param>
		/// <param name="m3SUBC">Subcontract control</param>
		/// <param name="m3SSUF">Subservice</param>
		/// <param name="m3LASK">Labor skill</param>
		/// <param name="m3SDCD">Standard</param>
		/// <param name="m3INSK">Inspection skill</param>
		/// <param name="m3PIPR">Unit price</param>
		/// <param name="m3WAFA">Time rate</param>
		/// <param name="m3SEPR">Setup price</param>
		/// <param name="m3WCRF">Time reference</param>
		/// <param name="m3KIWG">Pay element</param>
		/// <param name="m3CAMP">Number of labor tickets</param>
		/// <param name="m3INWE">Initial weight</param>
		/// <param name="m3OPV3">Operation volume</param>
		/// <param name="m3MFPR">Multiplication factor - manufacturing</param>
		/// <param name="m3AURP">Automatic operation reporting</param>
		/// <param name="m3OPCM">Operation cost multiplier</param>
		/// <param name="m3AUIN">Automatic receipt</param>
		/// <param name="m3CFID">Formula</param>
		/// <param name="m3CFRI">Formula result</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3NSUN">Supplier at agent</param>
		/// <param name="m3TXT1">Text line 1</param>
		/// <param name="m3TXT2">Text line 2</param>
		/// <param name="m3ASOP">Assembly operation</param>
		/// <param name="m3SDUP">Skip direct update</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3VRSN">Version</param>
		/// <param name="m3MFP2">Multiplication factor - manufacturing</param>
		/// <param name="m3AMAO">Additional material offset</param>
		/// <param name="m3APON">APP operation number</param>
		/// <param name="m3NXOP">Next APP operation number</param>
		/// <param name="m3SLAT">Transit unit of measure/Overlap code</param>
		/// <param name="m3POOC">Parallel operation overlap code</param>
		/// <param name="m3RESR">Resource restriction</param>
		/// <param name="m3PRET">Preparation time</param>
		/// <param name="m3SPLK">Split method - operation</param>
		/// <param name="m3SPLN">Number of operations after split</param>
		/// <param name="m3SPSZ">Split quantity</param>
		/// <param name="m3MDOP">Max duration of operation in percent</param>
		/// <param name="m3POTM">Post-operation time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdateOperation(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3MSEQ = null, 
			int? m3OPNO = null, 
			int? m3FDAT = null, 
			int? m3STRD = null, 
			string m3ECVE = null, 
			string m3MTPL = null, 
			string m3PLGR = null, 
			string m3OPDS = null, 
			int? m3PITI = null, 
			int? m3CTCD = null, 
			int? m3SETI = null, 
			int? m3FXTI = null, 
			int? m3OSET = null, 
			int? m3PRNM = null, 
			int? m3PRNP = null, 
			int? m3PHOP = null, 
			int? m3SENP = null, 
			int? m3ODBF = null, 
			int? m3PRDY = null, 
			string m3SLAC = null, 
			int? m3VAPC = null, 
			int? m3SCPC = null, 
			string m3SWQT = null, 
			string m3DOID = null, 
			string m3TOOL = null, 
			int? m3WLDE = null, 
			string m3SUBC = null, 
			string m3SSUF = null, 
			string m3LASK = null, 
			int? m3SDCD = null, 
			string m3INSK = null, 
			string m3PIPR = null, 
			string m3WAFA = null, 
			string m3SEPR = null, 
			string m3WCRF = null, 
			int? m3KIWG = null, 
			int? m3CAMP = null, 
			int? m3INWE = null, 
			int? m3OPV3 = null, 
			int? m3MFPR = null, 
			int? m3AURP = null, 
			int? m3OPCM = null, 
			int? m3AUIN = null, 
			string m3CFID = null, 
			string m3CFRI = null, 
			string m3SUNO = null, 
			string m3NSUN = null, 
			string m3TXT1 = null, 
			string m3TXT2 = null, 
			int? m3ASOP = null, 
			string m3SDUP = null, 
			int? m3TDAT = null, 
			int? m3VRSN = null, 
			int? m3MFP2 = null, 
			int? m3AMAO = null, 
			int? m3APON = null, 
			int? m3NXOP = null, 
			string m3SLAT = null, 
			int? m3POOC = null, 
			string m3RESR = null, 
			int? m3PRET = null, 
			int? m3SPLK = null, 
			int? m3SPLN = null, 
			decimal? m3SPSZ = null, 
			int? m3MDOP = null, 
			int? m3POTM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdateOperation",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STRD.HasValue)
				request.WithQueryParameter("STRD", m3STRD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTPL))
				request.WithQueryParameter("MTPL", m3MTPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPDS))
				request.WithQueryParameter("OPDS", m3OPDS.Trim());
			if (m3PITI.HasValue)
				request.WithQueryParameter("PITI", m3PITI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CTCD.HasValue)
				request.WithQueryParameter("CTCD", m3CTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SETI.HasValue)
				request.WithQueryParameter("SETI", m3SETI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FXTI.HasValue)
				request.WithQueryParameter("FXTI", m3FXTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OSET.HasValue)
				request.WithQueryParameter("OSET", m3OSET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNM.HasValue)
				request.WithQueryParameter("PRNM", m3PRNM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3PRNP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PHOP.HasValue)
				request.WithQueryParameter("PHOP", m3PHOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SENP.HasValue)
				request.WithQueryParameter("SENP", m3SENP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ODBF.HasValue)
				request.WithQueryParameter("ODBF", m3ODBF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRDY.HasValue)
				request.WithQueryParameter("PRDY", m3PRDY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SLAC))
				request.WithQueryParameter("SLAC", m3SLAC.Trim());
			if (m3VAPC.HasValue)
				request.WithQueryParameter("VAPC", m3VAPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCPC.HasValue)
				request.WithQueryParameter("SCPC", m3SCPC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SWQT))
				request.WithQueryParameter("SWQT", m3SWQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOOL))
				request.WithQueryParameter("TOOL", m3TOOL.Trim());
			if (m3WLDE.HasValue)
				request.WithQueryParameter("WLDE", m3WLDE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUBC))
				request.WithQueryParameter("SUBC", m3SUBC.Trim());
			if (!string.IsNullOrWhiteSpace(m3SSUF))
				request.WithQueryParameter("SSUF", m3SSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3LASK))
				request.WithQueryParameter("LASK", m3LASK.Trim());
			if (m3SDCD.HasValue)
				request.WithQueryParameter("SDCD", m3SDCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INSK))
				request.WithQueryParameter("INSK", m3INSK.Trim());
			if (!string.IsNullOrWhiteSpace(m3PIPR))
				request.WithQueryParameter("PIPR", m3PIPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3WAFA))
				request.WithQueryParameter("WAFA", m3WAFA.Trim());
			if (!string.IsNullOrWhiteSpace(m3SEPR))
				request.WithQueryParameter("SEPR", m3SEPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3WCRF))
				request.WithQueryParameter("WCRF", m3WCRF.Trim());
			if (m3KIWG.HasValue)
				request.WithQueryParameter("KIWG", m3KIWG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAMP.HasValue)
				request.WithQueryParameter("CAMP", m3CAMP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INWE.HasValue)
				request.WithQueryParameter("INWE", m3INWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPV3.HasValue)
				request.WithQueryParameter("OPV3", m3OPV3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MFPR.HasValue)
				request.WithQueryParameter("MFPR", m3MFPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AURP.HasValue)
				request.WithQueryParameter("AURP", m3AURP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPCM.HasValue)
				request.WithQueryParameter("OPCM", m3OPCM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUIN.HasValue)
				request.WithQueryParameter("AUIN", m3AUIN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFID))
				request.WithQueryParameter("CFID", m3CFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFRI))
				request.WithQueryParameter("CFRI", m3CFRI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3NSUN))
				request.WithQueryParameter("NSUN", m3NSUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT1))
				request.WithQueryParameter("TXT1", m3TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT2))
				request.WithQueryParameter("TXT2", m3TXT2.Trim());
			if (m3ASOP.HasValue)
				request.WithQueryParameter("ASOP", m3ASOP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SDUP))
				request.WithQueryParameter("SDUP", m3SDUP.Trim());
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3VRSN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MFP2.HasValue)
				request.WithQueryParameter("MFP2", m3MFP2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMAO.HasValue)
				request.WithQueryParameter("AMAO", m3AMAO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3APON.HasValue)
				request.WithQueryParameter("APON", m3APON.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NXOP.HasValue)
				request.WithQueryParameter("NXOP", m3NXOP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SLAT))
				request.WithQueryParameter("SLAT", m3SLAT.Trim());
			if (m3POOC.HasValue)
				request.WithQueryParameter("POOC", m3POOC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESR))
				request.WithQueryParameter("RESR", m3RESR.Trim());
			if (m3PRET.HasValue)
				request.WithQueryParameter("PRET", m3PRET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPLK.HasValue)
				request.WithQueryParameter("SPLK", m3SPLK.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPLN.HasValue)
				request.WithQueryParameter("SPLN", m3SPLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPSZ.HasValue)
				request.WithQueryParameter("SPSZ", m3SPSZ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MDOP.HasValue)
				request.WithQueryParameter("MDOP", m3MDOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POTM.HasValue)
				request.WithQueryParameter("POTM", m3POTM.Value.ToString(CultureInfo.CurrentCulture));

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
