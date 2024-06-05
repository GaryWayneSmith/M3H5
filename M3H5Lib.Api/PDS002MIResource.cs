/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_FDAT">From Date</param>
		/// <param name="m3_STRD">Structure date</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="m3_MTPL">Component number/work center</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_TECV">To revision number</param>
		/// <param name="m3_FECV">From revision number</param>
		/// <param name="m3_FLST">Floor stock</param>
		/// <param name="m3_OVOP">Order initiated</param>
		/// <param name="m3_OVTP">Phantom item</param>
		/// <param name="m3_ACTS">Operation element number</param>
		/// <param name="m3_SPMT">Issue method</param>
		/// <param name="m3_FXCD">Fixed quantity</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_CNQT">Quantity</param>
		/// <param name="m3_CCQT">Quantity on drawing</param>
		/// <param name="m3_PEUN">Product engineering U/M</param>
		/// <param name="m3_DWPO">Drawing position</param>
		/// <param name="m3_VAPC">Option percentage</param>
		/// <param name="m3_WAPC">Normal waste percentage</param>
		/// <param name="m3_STGS">Subcontract control</param>
		/// <param name="m3_SSUF">Subservice</param>
		/// <param name="m3_FMT1">Text</param>
		/// <param name="m3_FMT2">Technical reference</param>
		/// <param name="m3_MPRC">Component price</param>
		/// <param name="m3_EXMA">Yield component</param>
		/// <param name="m3_CMCD">Lot controlling component</param>
		/// <param name="m3_CRTM">Critical material</param>
		/// <param name="m3_SDCD">Standard</param>
		/// <param name="m3_BYPR">By/co-product code</param>
		/// <param name="m3_LGTH">Length</param>
		/// <param name="m3_WDTH">Width</param>
		/// <param name="m3_LWF1">Factor 1</param>
		/// <param name="m3_LWF2">Factor 2</param>
		/// <param name="m3_SIDI">Selection identity - component</param>
		/// <param name="m3_SITI">Selection type - component</param>
		/// <param name="m3_SIDQ">Selection identity - quantity</param>
		/// <param name="m3_SITQ">Selection type - quantity</param>
		/// <param name="m3_FORI">Formula result identity</param>
		/// <param name="m3_SDUP">Skip direct update</param>
		/// <param name="m3_DSP6">Warning Indicator 1</param>
		/// <param name="m3_DSP5">Warning Indicator 2</param>
		/// <param name="m3_NORD">Additional days - material reservation</param>
		/// <param name="m3_RTHI">Reservation time - material</param>
		/// <param name="m3_AADM">Add components - not in item master</param>
		/// <param name="m3_INHI">Item to inherit from</param>
		/// <param name="m3_EXCH">Exchange</param>
		/// <param name="m3_VRSN">Version</param>
		/// <param name="m3_ELRF">External line reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddComponent(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_MSEQ = null, 
			int? m3_OPNO = null, 
			int? m3_FDAT = null, 
			int? m3_STRD = null, 
			string m3_ECVE = null, 
			string m3_MTPL = null, 
			int? m3_TDAT = null, 
			string m3_TECV = null, 
			string m3_FECV = null, 
			int? m3_FLST = null, 
			string m3_OVOP = null, 
			string m3_OVTP = null, 
			int? m3_ACTS = null, 
			int? m3_SPMT = null, 
			int? m3_FXCD = null, 
			string m3_WHLO = null, 
			string m3_WHSL = null, 
			string m3_CNQT = null, 
			string m3_CCQT = null, 
			string m3_PEUN = null, 
			string m3_DWPO = null, 
			int? m3_VAPC = null, 
			int? m3_WAPC = null, 
			int? m3_STGS = null, 
			string m3_SSUF = null, 
			string m3_FMT1 = null, 
			string m3_FMT2 = null, 
			string m3_MPRC = null, 
			int? m3_EXMA = null, 
			int? m3_CMCD = null, 
			int? m3_CRTM = null, 
			int? m3_SDCD = null, 
			int? m3_BYPR = null, 
			int? m3_LGTH = null, 
			int? m3_WDTH = null, 
			string m3_LWF1 = null, 
			string m3_LWF2 = null, 
			string m3_SIDI = null, 
			int? m3_SITI = null, 
			string m3_SIDQ = null, 
			int? m3_SITQ = null, 
			string m3_FORI = null, 
			string m3_SDUP = null, 
			int? m3_DSP6 = null, 
			int? m3_DSP5 = null, 
			string m3_NORD = null, 
			int? m3_RTHI = null, 
			int? m3_AADM = null, 
			int? m3_INHI = null, 
			int? m3_EXCH = null, 
			int? m3_VRSN = null, 
			int? m3_ELRF = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToString());
			if (m3_STRD.HasValue)
				request.WithQueryParameter("STRD", m3_STRD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTPL))
				request.WithQueryParameter("MTPL", m3_MTPL.Trim());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TECV))
				request.WithQueryParameter("TECV", m3_TECV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FECV))
				request.WithQueryParameter("FECV", m3_FECV.Trim());
			if (m3_FLST.HasValue)
				request.WithQueryParameter("FLST", m3_FLST.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OVOP))
				request.WithQueryParameter("OVOP", m3_OVOP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVTP))
				request.WithQueryParameter("OVTP", m3_OVTP.Trim());
			if (m3_ACTS.HasValue)
				request.WithQueryParameter("ACTS", m3_ACTS.Value.ToString());
			if (m3_SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3_SPMT.Value.ToString());
			if (m3_FXCD.HasValue)
				request.WithQueryParameter("FXCD", m3_FXCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CNQT))
				request.WithQueryParameter("CNQT", m3_CNQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CCQT))
				request.WithQueryParameter("CCQT", m3_CCQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PEUN))
				request.WithQueryParameter("PEUN", m3_PEUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DWPO))
				request.WithQueryParameter("DWPO", m3_DWPO.Trim());
			if (m3_VAPC.HasValue)
				request.WithQueryParameter("VAPC", m3_VAPC.Value.ToString());
			if (m3_WAPC.HasValue)
				request.WithQueryParameter("WAPC", m3_WAPC.Value.ToString());
			if (m3_STGS.HasValue)
				request.WithQueryParameter("STGS", m3_STGS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SSUF))
				request.WithQueryParameter("SSUF", m3_SSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMT1))
				request.WithQueryParameter("FMT1", m3_FMT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMT2))
				request.WithQueryParameter("FMT2", m3_FMT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MPRC))
				request.WithQueryParameter("MPRC", m3_MPRC.Trim());
			if (m3_EXMA.HasValue)
				request.WithQueryParameter("EXMA", m3_EXMA.Value.ToString());
			if (m3_CMCD.HasValue)
				request.WithQueryParameter("CMCD", m3_CMCD.Value.ToString());
			if (m3_CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3_CRTM.Value.ToString());
			if (m3_SDCD.HasValue)
				request.WithQueryParameter("SDCD", m3_SDCD.Value.ToString());
			if (m3_BYPR.HasValue)
				request.WithQueryParameter("BYPR", m3_BYPR.Value.ToString());
			if (m3_LGTH.HasValue)
				request.WithQueryParameter("LGTH", m3_LGTH.Value.ToString());
			if (m3_WDTH.HasValue)
				request.WithQueryParameter("WDTH", m3_WDTH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LWF1))
				request.WithQueryParameter("LWF1", m3_LWF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LWF2))
				request.WithQueryParameter("LWF2", m3_LWF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SIDI))
				request.WithQueryParameter("SIDI", m3_SIDI.Trim());
			if (m3_SITI.HasValue)
				request.WithQueryParameter("SITI", m3_SITI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SIDQ))
				request.WithQueryParameter("SIDQ", m3_SIDQ.Trim());
			if (m3_SITQ.HasValue)
				request.WithQueryParameter("SITQ", m3_SITQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FORI))
				request.WithQueryParameter("FORI", m3_FORI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDUP))
				request.WithQueryParameter("SDUP", m3_SDUP.Trim());
			if (m3_DSP6.HasValue)
				request.WithQueryParameter("DSP6", m3_DSP6.Value.ToString());
			if (m3_DSP5.HasValue)
				request.WithQueryParameter("DSP5", m3_DSP5.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NORD))
				request.WithQueryParameter("NORD", m3_NORD.Trim());
			if (m3_RTHI.HasValue)
				request.WithQueryParameter("RTHI", m3_RTHI.Value.ToString());
			if (m3_AADM.HasValue)
				request.WithQueryParameter("AADM", m3_AADM.Value.ToString());
			if (m3_INHI.HasValue)
				request.WithQueryParameter("INHI", m3_INHI.Value.ToString());
			if (m3_EXCH.HasValue)
				request.WithQueryParameter("EXCH", m3_EXCH.Value.ToString());
			if (m3_VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3_VRSN.Value.ToString());
			if (m3_ELRF.HasValue)
				request.WithQueryParameter("ELRF", m3_ELRF.Value.ToString());

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
		/// Description Add Operation
		/// Version Release: 5ea6
		/// </summary>
		/// <param name="m3_SDCD">Standard (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_STRD">Structure date</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="m3_MTPL">Component number/work center</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_OPDS">Operation description</param>
		/// <param name="m3_PITI">Run time</param>
		/// <param name="m3_CTCD">Price and time quantity</param>
		/// <param name="m3_SETI">Setup time</param>
		/// <param name="m3_FXTI">Fixed time</param>
		/// <param name="m3_OSET">External setup time</param>
		/// <param name="m3_PRNM">Planned number of machines</param>
		/// <param name="m3_PRNP">Planned number of workers - run time</param>
		/// <param name="m3_PHOP">Phantom operation method</param>
		/// <param name="m3_SENP">Planned number of workers - setup</param>
		/// <param name="m3_ODBF">Lead time offset</param>
		/// <param name="m3_PRDY">Production days</param>
		/// <param name="m3_SLAC">Transport value in days</param>
		/// <param name="m3_VAPC">Option percentage</param>
		/// <param name="m3_SCPC">Scrap percentage</param>
		/// <param name="m3_SWQT">Setup scrap</param>
		/// <param name="m3_DOID">Document identity</param>
		/// <param name="m3_TOOL">Tool number</param>
		/// <param name="m3_WLDE">Infinite/finite</param>
		/// <param name="m3_SUBC">Subcontract control</param>
		/// <param name="m3_SSUF">Subservice</param>
		/// <param name="m3_LASK">Labor skill</param>
		/// <param name="m3_INSK">Inspection skill</param>
		/// <param name="m3_PIPR">Unit price</param>
		/// <param name="m3_WAFA">Time rate</param>
		/// <param name="m3_SEPR">Setup price</param>
		/// <param name="m3_WCRF">Time reference</param>
		/// <param name="m3_KIWG">Pay element</param>
		/// <param name="m3_CAMP">Number of labor tickets</param>
		/// <param name="m3_INWE">Initial weight</param>
		/// <param name="m3_OPV3">Operation volume</param>
		/// <param name="m3_MFPR">Multiplication factor - manufacturing</param>
		/// <param name="m3_AURP">Automatic operation reporting</param>
		/// <param name="m3_OPCM">Operation cost multiplier</param>
		/// <param name="m3_AUIN">Automatic receipt</param>
		/// <param name="m3_CFID">Formula</param>
		/// <param name="m3_CFRI">Formula result</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_NSUN">Supplier at agent</param>
		/// <param name="m3_TXT1">Text line 1</param>
		/// <param name="m3_TXT2">Text line 2</param>
		/// <param name="m3_ASOP">Assembly operation</param>
		/// <param name="m3_SDUP">Skip direct update</param>
		/// <param name="m3_TDAT">To Date</param>
		/// <param name="m3_VRSN">Version</param>
		/// <param name="m3_MFP2">Multiplication factor - manufacturing</param>
		/// <param name="m3_AMAO">Additional Material Offset</param>
		/// <param name="m3_APON">APP operation number</param>
		/// <param name="m3_NXOP">Next APP operation number</param>
		/// <param name="m3_SLAT">Transit unit of measure/Overlap code</param>
		/// <param name="m3_POOC">Parallel operation overlap code</param>
		/// <param name="m3_RESR">Resource restriction</param>
		/// <param name="m3_PRET">Preparation time</param>
		/// <param name="m3_SPLK">Split method - operation</param>
		/// <param name="m3_SPLN">Number of operations after split</param>
		/// <param name="m3_SPSZ">Split quantity</param>
		/// <param name="m3_MDOP">Max duration of operation in percent</param>
		/// <param name="m3_POTM">Post-operation time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddOperation(
			int m3_SDCD, 
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_MSEQ = null, 
			int? m3_OPNO = null, 
			int? m3_FDAT = null, 
			int? m3_STRD = null, 
			string m3_ECVE = null, 
			string m3_MTPL = null, 
			string m3_PLGR = null, 
			string m3_OPDS = null, 
			int? m3_PITI = null, 
			int? m3_CTCD = null, 
			int? m3_SETI = null, 
			int? m3_FXTI = null, 
			int? m3_OSET = null, 
			int? m3_PRNM = null, 
			int? m3_PRNP = null, 
			int? m3_PHOP = null, 
			int? m3_SENP = null, 
			int? m3_ODBF = null, 
			int? m3_PRDY = null, 
			string m3_SLAC = null, 
			int? m3_VAPC = null, 
			int? m3_SCPC = null, 
			string m3_SWQT = null, 
			string m3_DOID = null, 
			string m3_TOOL = null, 
			int? m3_WLDE = null, 
			string m3_SUBC = null, 
			string m3_SSUF = null, 
			string m3_LASK = null, 
			string m3_INSK = null, 
			string m3_PIPR = null, 
			string m3_WAFA = null, 
			string m3_SEPR = null, 
			string m3_WCRF = null, 
			int? m3_KIWG = null, 
			int? m3_CAMP = null, 
			int? m3_INWE = null, 
			int? m3_OPV3 = null, 
			int? m3_MFPR = null, 
			int? m3_AURP = null, 
			int? m3_OPCM = null, 
			int? m3_AUIN = null, 
			string m3_CFID = null, 
			string m3_CFRI = null, 
			string m3_SUNO = null, 
			string m3_NSUN = null, 
			string m3_TXT1 = null, 
			string m3_TXT2 = null, 
			int? m3_ASOP = null, 
			string m3_SDUP = null, 
			int? m3_TDAT = null, 
			int? m3_VRSN = null, 
			int? m3_MFP2 = null, 
			int? m3_AMAO = null, 
			int? m3_APON = null, 
			int? m3_NXOP = null, 
			string m3_SLAT = null, 
			int? m3_POOC = null, 
			string m3_RESR = null, 
			int? m3_PRET = null, 
			int? m3_SPLK = null, 
			int? m3_SPLN = null, 
			decimal? m3_SPSZ = null, 
			int? m3_MDOP = null, 
			int? m3_POTM = null, 
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
				.WithQueryParameter("SDCD", m3_SDCD.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToString());
			if (m3_STRD.HasValue)
				request.WithQueryParameter("STRD", m3_STRD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTPL))
				request.WithQueryParameter("MTPL", m3_MTPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPDS))
				request.WithQueryParameter("OPDS", m3_OPDS.Trim());
			if (m3_PITI.HasValue)
				request.WithQueryParameter("PITI", m3_PITI.Value.ToString());
			if (m3_CTCD.HasValue)
				request.WithQueryParameter("CTCD", m3_CTCD.Value.ToString());
			if (m3_SETI.HasValue)
				request.WithQueryParameter("SETI", m3_SETI.Value.ToString());
			if (m3_FXTI.HasValue)
				request.WithQueryParameter("FXTI", m3_FXTI.Value.ToString());
			if (m3_OSET.HasValue)
				request.WithQueryParameter("OSET", m3_OSET.Value.ToString());
			if (m3_PRNM.HasValue)
				request.WithQueryParameter("PRNM", m3_PRNM.Value.ToString());
			if (m3_PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3_PRNP.Value.ToString());
			if (m3_PHOP.HasValue)
				request.WithQueryParameter("PHOP", m3_PHOP.Value.ToString());
			if (m3_SENP.HasValue)
				request.WithQueryParameter("SENP", m3_SENP.Value.ToString());
			if (m3_ODBF.HasValue)
				request.WithQueryParameter("ODBF", m3_ODBF.Value.ToString());
			if (m3_PRDY.HasValue)
				request.WithQueryParameter("PRDY", m3_PRDY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SLAC))
				request.WithQueryParameter("SLAC", m3_SLAC.Trim());
			if (m3_VAPC.HasValue)
				request.WithQueryParameter("VAPC", m3_VAPC.Value.ToString());
			if (m3_SCPC.HasValue)
				request.WithQueryParameter("SCPC", m3_SCPC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SWQT))
				request.WithQueryParameter("SWQT", m3_SWQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOOL))
				request.WithQueryParameter("TOOL", m3_TOOL.Trim());
			if (m3_WLDE.HasValue)
				request.WithQueryParameter("WLDE", m3_WLDE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUBC))
				request.WithQueryParameter("SUBC", m3_SUBC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSUF))
				request.WithQueryParameter("SSUF", m3_SSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LASK))
				request.WithQueryParameter("LASK", m3_LASK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INSK))
				request.WithQueryParameter("INSK", m3_INSK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PIPR))
				request.WithQueryParameter("PIPR", m3_PIPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WAFA))
				request.WithQueryParameter("WAFA", m3_WAFA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SEPR))
				request.WithQueryParameter("SEPR", m3_SEPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WCRF))
				request.WithQueryParameter("WCRF", m3_WCRF.Trim());
			if (m3_KIWG.HasValue)
				request.WithQueryParameter("KIWG", m3_KIWG.Value.ToString());
			if (m3_CAMP.HasValue)
				request.WithQueryParameter("CAMP", m3_CAMP.Value.ToString());
			if (m3_INWE.HasValue)
				request.WithQueryParameter("INWE", m3_INWE.Value.ToString());
			if (m3_OPV3.HasValue)
				request.WithQueryParameter("OPV3", m3_OPV3.Value.ToString());
			if (m3_MFPR.HasValue)
				request.WithQueryParameter("MFPR", m3_MFPR.Value.ToString());
			if (m3_AURP.HasValue)
				request.WithQueryParameter("AURP", m3_AURP.Value.ToString());
			if (m3_OPCM.HasValue)
				request.WithQueryParameter("OPCM", m3_OPCM.Value.ToString());
			if (m3_AUIN.HasValue)
				request.WithQueryParameter("AUIN", m3_AUIN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFID))
				request.WithQueryParameter("CFID", m3_CFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFRI))
				request.WithQueryParameter("CFRI", m3_CFRI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NSUN))
				request.WithQueryParameter("NSUN", m3_NSUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT1))
				request.WithQueryParameter("TXT1", m3_TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT2))
				request.WithQueryParameter("TXT2", m3_TXT2.Trim());
			if (m3_ASOP.HasValue)
				request.WithQueryParameter("ASOP", m3_ASOP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SDUP))
				request.WithQueryParameter("SDUP", m3_SDUP.Trim());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToString());
			if (m3_VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3_VRSN.Value.ToString());
			if (m3_MFP2.HasValue)
				request.WithQueryParameter("MFP2", m3_MFP2.Value.ToString());
			if (m3_AMAO.HasValue)
				request.WithQueryParameter("AMAO", m3_AMAO.Value.ToString());
			if (m3_APON.HasValue)
				request.WithQueryParameter("APON", m3_APON.Value.ToString());
			if (m3_NXOP.HasValue)
				request.WithQueryParameter("NXOP", m3_NXOP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SLAT))
				request.WithQueryParameter("SLAT", m3_SLAT.Trim());
			if (m3_POOC.HasValue)
				request.WithQueryParameter("POOC", m3_POOC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESR))
				request.WithQueryParameter("RESR", m3_RESR.Trim());
			if (m3_PRET.HasValue)
				request.WithQueryParameter("PRET", m3_PRET.Value.ToString());
			if (m3_SPLK.HasValue)
				request.WithQueryParameter("SPLK", m3_SPLK.Value.ToString());
			if (m3_SPLN.HasValue)
				request.WithQueryParameter("SPLN", m3_SPLN.Value.ToString());
			if (m3_SPSZ.HasValue)
				request.WithQueryParameter("SPSZ", m3_SPSZ.Value.ToString());
			if (m3_MDOP.HasValue)
				request.WithQueryParameter("MDOP", m3_MDOP.Value.ToString());
			if (m3_POTM.HasValue)
				request.WithQueryParameter("POTM", m3_POTM.Value.ToString());

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
		/// Name AddOperation2
		/// Description Add OEM for Operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STRT">Product structure type</param>
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
		public async Task<M3Response<M3Record>> AddOperation2(
			string m3_FACI, 
			string m3_PRNO, 
			int m3_OPNO, 
			int? m3_CONO = null, 
			string m3_STRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddOperation2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
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
		/// Name CpyComp
		/// Description Copy Operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_CSEQ">Sequence number</param>
		/// <param name="m3_CFDT">From date</param>
		/// <param name="m3_VRSN">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyComp(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_MSEQ = null, 
			DateTime? m3_FDAT = null, 
			int? m3_CSEQ = null, 
			DateTime? m3_CFDT = null, 
			int? m3_VRSN = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (m3_CSEQ.HasValue)
				request.WithQueryParameter("CSEQ", m3_CSEQ.Value.ToString());
			if (m3_CFDT.HasValue)
				request.WithQueryParameter("CFDT", m3_CFDT.Value.ToM3String());
			if (m3_VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3_VRSN.Value.ToString());

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
		/// Name CpyComponent
		/// Description Copy Component
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_FDAT">From Date</param>
		/// <param name="m3_CSEQ">Sequence number</param>
		/// <param name="m3_COPN">Operation number</param>
		/// <param name="m3_CFDT">From Date</param>
		/// <param name="m3_STRD">Structure date</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="m3_MTPL">Component number/work center</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_TECV">To revision number</param>
		/// <param name="m3_FECV">From revision number</param>
		/// <param name="m3_FLST">Floor stock</param>
		/// <param name="m3_OVOP">Order initiated</param>
		/// <param name="m3_OVTP">Phantom item</param>
		/// <param name="m3_ACTS">Operation element number</param>
		/// <param name="m3_SPMT">Issue method</param>
		/// <param name="m3_FXCD">Fixed quantity</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_CNQT">Quantity</param>
		/// <param name="m3_CCQT">Quantity on drawing</param>
		/// <param name="m3_PEUN">Product engineering U/M</param>
		/// <param name="m3_DWPO">Drawing position</param>
		/// <param name="m3_VAPC">Option percentage</param>
		/// <param name="m3_WAPC">Normal waste percentage</param>
		/// <param name="m3_STGS">Subcontract control</param>
		/// <param name="m3_SSUF">Subservice</param>
		/// <param name="m3_FMT1">Text</param>
		/// <param name="m3_FMT2">Technical reference</param>
		/// <param name="m3_MPRC">Component price</param>
		/// <param name="m3_EXMA">Yield component</param>
		/// <param name="m3_CMCD">Lot controlling component</param>
		/// <param name="m3_CRTM">Critical material</param>
		/// <param name="m3_SDCD">Standard</param>
		/// <param name="m3_BYPR">By/co-product code</param>
		/// <param name="m3_LGTH">Length</param>
		/// <param name="m3_WDTH">Width</param>
		/// <param name="m3_LWF1">Factor 1</param>
		/// <param name="m3_LWF2">Factor 2</param>
		/// <param name="m3_SIDI">Selection identity - component</param>
		/// <param name="m3_SITI">Selection type - component</param>
		/// <param name="m3_SIDQ">Selection identity - quantity</param>
		/// <param name="m3_SITQ">Selection type - quantity</param>
		/// <param name="m3_FORI">Formula result identity</param>
		/// <param name="m3_SDUP">Skip direct update</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyComponent(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_MSEQ = null, 
			int? m3_OPNO = null, 
			int? m3_FDAT = null, 
			int? m3_CSEQ = null, 
			int? m3_COPN = null, 
			DateTime? m3_CFDT = null, 
			int? m3_STRD = null, 
			string m3_ECVE = null, 
			string m3_MTPL = null, 
			int? m3_TDAT = null, 
			string m3_TECV = null, 
			string m3_FECV = null, 
			int? m3_FLST = null, 
			string m3_OVOP = null, 
			string m3_OVTP = null, 
			int? m3_ACTS = null, 
			int? m3_SPMT = null, 
			int? m3_FXCD = null, 
			string m3_WHLO = null, 
			string m3_WHSL = null, 
			string m3_CNQT = null, 
			string m3_CCQT = null, 
			string m3_PEUN = null, 
			string m3_DWPO = null, 
			int? m3_VAPC = null, 
			int? m3_WAPC = null, 
			int? m3_STGS = null, 
			string m3_SSUF = null, 
			string m3_FMT1 = null, 
			string m3_FMT2 = null, 
			string m3_MPRC = null, 
			int? m3_EXMA = null, 
			int? m3_CMCD = null, 
			int? m3_CRTM = null, 
			int? m3_SDCD = null, 
			int? m3_BYPR = null, 
			int? m3_LGTH = null, 
			int? m3_WDTH = null, 
			string m3_LWF1 = null, 
			string m3_LWF2 = null, 
			string m3_SIDI = null, 
			int? m3_SITI = null, 
			string m3_SIDQ = null, 
			int? m3_SITQ = null, 
			string m3_FORI = null, 
			string m3_SDUP = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToString());
			if (m3_CSEQ.HasValue)
				request.WithQueryParameter("CSEQ", m3_CSEQ.Value.ToString());
			if (m3_COPN.HasValue)
				request.WithQueryParameter("COPN", m3_COPN.Value.ToString());
			if (m3_CFDT.HasValue)
				request.WithQueryParameter("CFDT", m3_CFDT.Value.ToM3String());
			if (m3_STRD.HasValue)
				request.WithQueryParameter("STRD", m3_STRD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTPL))
				request.WithQueryParameter("MTPL", m3_MTPL.Trim());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TECV))
				request.WithQueryParameter("TECV", m3_TECV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FECV))
				request.WithQueryParameter("FECV", m3_FECV.Trim());
			if (m3_FLST.HasValue)
				request.WithQueryParameter("FLST", m3_FLST.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OVOP))
				request.WithQueryParameter("OVOP", m3_OVOP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVTP))
				request.WithQueryParameter("OVTP", m3_OVTP.Trim());
			if (m3_ACTS.HasValue)
				request.WithQueryParameter("ACTS", m3_ACTS.Value.ToString());
			if (m3_SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3_SPMT.Value.ToString());
			if (m3_FXCD.HasValue)
				request.WithQueryParameter("FXCD", m3_FXCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CNQT))
				request.WithQueryParameter("CNQT", m3_CNQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CCQT))
				request.WithQueryParameter("CCQT", m3_CCQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PEUN))
				request.WithQueryParameter("PEUN", m3_PEUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DWPO))
				request.WithQueryParameter("DWPO", m3_DWPO.Trim());
			if (m3_VAPC.HasValue)
				request.WithQueryParameter("VAPC", m3_VAPC.Value.ToString());
			if (m3_WAPC.HasValue)
				request.WithQueryParameter("WAPC", m3_WAPC.Value.ToString());
			if (m3_STGS.HasValue)
				request.WithQueryParameter("STGS", m3_STGS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SSUF))
				request.WithQueryParameter("SSUF", m3_SSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMT1))
				request.WithQueryParameter("FMT1", m3_FMT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMT2))
				request.WithQueryParameter("FMT2", m3_FMT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MPRC))
				request.WithQueryParameter("MPRC", m3_MPRC.Trim());
			if (m3_EXMA.HasValue)
				request.WithQueryParameter("EXMA", m3_EXMA.Value.ToString());
			if (m3_CMCD.HasValue)
				request.WithQueryParameter("CMCD", m3_CMCD.Value.ToString());
			if (m3_CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3_CRTM.Value.ToString());
			if (m3_SDCD.HasValue)
				request.WithQueryParameter("SDCD", m3_SDCD.Value.ToString());
			if (m3_BYPR.HasValue)
				request.WithQueryParameter("BYPR", m3_BYPR.Value.ToString());
			if (m3_LGTH.HasValue)
				request.WithQueryParameter("LGTH", m3_LGTH.Value.ToString());
			if (m3_WDTH.HasValue)
				request.WithQueryParameter("WDTH", m3_WDTH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LWF1))
				request.WithQueryParameter("LWF1", m3_LWF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LWF2))
				request.WithQueryParameter("LWF2", m3_LWF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SIDI))
				request.WithQueryParameter("SIDI", m3_SIDI.Trim());
			if (m3_SITI.HasValue)
				request.WithQueryParameter("SITI", m3_SITI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SIDQ))
				request.WithQueryParameter("SIDQ", m3_SIDQ.Trim());
			if (m3_SITQ.HasValue)
				request.WithQueryParameter("SITQ", m3_SITQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FORI))
				request.WithQueryParameter("FORI", m3_FORI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDUP))
				request.WithQueryParameter("SDUP", m3_SDUP.Trim());

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
		/// Name CpyOper
		/// Description Copy Operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_COPN">Operation number</param>
		/// <param name="m3_CFDT">From date</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_VRSN">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyOper(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_OPNO = null, 
			DateTime? m3_FDAT = null, 
			int? m3_COPN = null, 
			DateTime? m3_CFDT = null, 
			DateTime? m3_TDAT = null, 
			int? m3_VRSN = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (m3_COPN.HasValue)
				request.WithQueryParameter("COPN", m3_COPN.Value.ToString());
			if (m3_CFDT.HasValue)
				request.WithQueryParameter("CFDT", m3_CFDT.Value.ToM3String());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());
			if (m3_VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3_VRSN.Value.ToString());

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
		/// Name CpyOperation
		/// Description Copy Operation
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_CSEQ">Sequence number</param>
		/// <param name="m3_COPN">Operation number</param>
		/// <param name="m3_CFDT">From Date</param>
		/// <param name="m3_STRD">Structure date</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="m3_MTPL">Component number/work center</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_OPDS">Operation description</param>
		/// <param name="m3_PITI">Run time</param>
		/// <param name="m3_CTCD">Price and time quantity</param>
		/// <param name="m3_SETI">Setup time</param>
		/// <param name="m3_FXTI">Fixed time</param>
		/// <param name="m3_OSET">External setup time</param>
		/// <param name="m3_PRNM">Planned number of machines</param>
		/// <param name="m3_PRNP">Planned number of workers - run time</param>
		/// <param name="m3_PHOP">Phantom operation method</param>
		/// <param name="m3_SENP">Planned number of workers - setup</param>
		/// <param name="m3_ODBF">Lead time offset</param>
		/// <param name="m3_PRDY">Production days</param>
		/// <param name="m3_SLAC">Transport value in days</param>
		/// <param name="m3_VAPC">Option percentage</param>
		/// <param name="m3_SCPC">Scrap percentage</param>
		/// <param name="m3_SWQT">Setup scrap</param>
		/// <param name="m3_DOID">Document identity</param>
		/// <param name="m3_TOOL">Tool number</param>
		/// <param name="m3_WLDE">Infinite/finite</param>
		/// <param name="m3_SUBC">Subcontract control</param>
		/// <param name="m3_SSUF">Subservice</param>
		/// <param name="m3_LASK">Labor skill</param>
		/// <param name="m3_SDCD">Standard</param>
		/// <param name="m3_INSK">Inspection skill</param>
		/// <param name="m3_PIPR">Unit price</param>
		/// <param name="m3_WAFA">Time rate</param>
		/// <param name="m3_SEPR">Setup price</param>
		/// <param name="m3_WCRF">Time reference</param>
		/// <param name="m3_KIWG">Pay element</param>
		/// <param name="m3_CAMP">Number of labor tickets</param>
		/// <param name="m3_INWE">Initial weight</param>
		/// <param name="m3_OPV3">Operation volume</param>
		/// <param name="m3_MFPR">Multiplication factor - manufacturing</param>
		/// <param name="m3_AURP">Automatic operation reporting</param>
		/// <param name="m3_OPCM">Operation cost multiplier</param>
		/// <param name="m3_AUIN">Automatic receipt</param>
		/// <param name="m3_CFID">Formula</param>
		/// <param name="m3_CFRI">Formula result</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_NSUN">Supplier at agent</param>
		/// <param name="m3_TXT1">Text line 1</param>
		/// <param name="m3_TXT2">Text line 2</param>
		/// <param name="m3_ASOP">Assembly operation</param>
		/// <param name="m3_SDUP">Skip direct update</param>
		/// <param name="m3_MFP2">Multiplication factor - manufacturing</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyOperation(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_MSEQ = null, 
			int? m3_OPNO = null, 
			int? m3_FDAT = null, 
			int? m3_CSEQ = null, 
			int? m3_COPN = null, 
			DateTime? m3_CFDT = null, 
			int? m3_STRD = null, 
			string m3_ECVE = null, 
			string m3_MTPL = null, 
			string m3_PLGR = null, 
			string m3_OPDS = null, 
			int? m3_PITI = null, 
			int? m3_CTCD = null, 
			int? m3_SETI = null, 
			int? m3_FXTI = null, 
			int? m3_OSET = null, 
			int? m3_PRNM = null, 
			int? m3_PRNP = null, 
			int? m3_PHOP = null, 
			int? m3_SENP = null, 
			int? m3_ODBF = null, 
			int? m3_PRDY = null, 
			string m3_SLAC = null, 
			int? m3_VAPC = null, 
			int? m3_SCPC = null, 
			string m3_SWQT = null, 
			string m3_DOID = null, 
			string m3_TOOL = null, 
			int? m3_WLDE = null, 
			string m3_SUBC = null, 
			string m3_SSUF = null, 
			string m3_LASK = null, 
			int? m3_SDCD = null, 
			string m3_INSK = null, 
			string m3_PIPR = null, 
			string m3_WAFA = null, 
			string m3_SEPR = null, 
			string m3_WCRF = null, 
			int? m3_KIWG = null, 
			int? m3_CAMP = null, 
			int? m3_INWE = null, 
			int? m3_OPV3 = null, 
			int? m3_MFPR = null, 
			int? m3_AURP = null, 
			int? m3_OPCM = null, 
			int? m3_AUIN = null, 
			string m3_CFID = null, 
			string m3_CFRI = null, 
			string m3_SUNO = null, 
			string m3_NSUN = null, 
			string m3_TXT1 = null, 
			string m3_TXT2 = null, 
			int? m3_ASOP = null, 
			string m3_SDUP = null, 
			int? m3_MFP2 = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToString());
			if (m3_CSEQ.HasValue)
				request.WithQueryParameter("CSEQ", m3_CSEQ.Value.ToString());
			if (m3_COPN.HasValue)
				request.WithQueryParameter("COPN", m3_COPN.Value.ToString());
			if (m3_CFDT.HasValue)
				request.WithQueryParameter("CFDT", m3_CFDT.Value.ToM3String());
			if (m3_STRD.HasValue)
				request.WithQueryParameter("STRD", m3_STRD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTPL))
				request.WithQueryParameter("MTPL", m3_MTPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPDS))
				request.WithQueryParameter("OPDS", m3_OPDS.Trim());
			if (m3_PITI.HasValue)
				request.WithQueryParameter("PITI", m3_PITI.Value.ToString());
			if (m3_CTCD.HasValue)
				request.WithQueryParameter("CTCD", m3_CTCD.Value.ToString());
			if (m3_SETI.HasValue)
				request.WithQueryParameter("SETI", m3_SETI.Value.ToString());
			if (m3_FXTI.HasValue)
				request.WithQueryParameter("FXTI", m3_FXTI.Value.ToString());
			if (m3_OSET.HasValue)
				request.WithQueryParameter("OSET", m3_OSET.Value.ToString());
			if (m3_PRNM.HasValue)
				request.WithQueryParameter("PRNM", m3_PRNM.Value.ToString());
			if (m3_PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3_PRNP.Value.ToString());
			if (m3_PHOP.HasValue)
				request.WithQueryParameter("PHOP", m3_PHOP.Value.ToString());
			if (m3_SENP.HasValue)
				request.WithQueryParameter("SENP", m3_SENP.Value.ToString());
			if (m3_ODBF.HasValue)
				request.WithQueryParameter("ODBF", m3_ODBF.Value.ToString());
			if (m3_PRDY.HasValue)
				request.WithQueryParameter("PRDY", m3_PRDY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SLAC))
				request.WithQueryParameter("SLAC", m3_SLAC.Trim());
			if (m3_VAPC.HasValue)
				request.WithQueryParameter("VAPC", m3_VAPC.Value.ToString());
			if (m3_SCPC.HasValue)
				request.WithQueryParameter("SCPC", m3_SCPC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SWQT))
				request.WithQueryParameter("SWQT", m3_SWQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOOL))
				request.WithQueryParameter("TOOL", m3_TOOL.Trim());
			if (m3_WLDE.HasValue)
				request.WithQueryParameter("WLDE", m3_WLDE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUBC))
				request.WithQueryParameter("SUBC", m3_SUBC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSUF))
				request.WithQueryParameter("SSUF", m3_SSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LASK))
				request.WithQueryParameter("LASK", m3_LASK.Trim());
			if (m3_SDCD.HasValue)
				request.WithQueryParameter("SDCD", m3_SDCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INSK))
				request.WithQueryParameter("INSK", m3_INSK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PIPR))
				request.WithQueryParameter("PIPR", m3_PIPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WAFA))
				request.WithQueryParameter("WAFA", m3_WAFA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SEPR))
				request.WithQueryParameter("SEPR", m3_SEPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WCRF))
				request.WithQueryParameter("WCRF", m3_WCRF.Trim());
			if (m3_KIWG.HasValue)
				request.WithQueryParameter("KIWG", m3_KIWG.Value.ToString());
			if (m3_CAMP.HasValue)
				request.WithQueryParameter("CAMP", m3_CAMP.Value.ToString());
			if (m3_INWE.HasValue)
				request.WithQueryParameter("INWE", m3_INWE.Value.ToString());
			if (m3_OPV3.HasValue)
				request.WithQueryParameter("OPV3", m3_OPV3.Value.ToString());
			if (m3_MFPR.HasValue)
				request.WithQueryParameter("MFPR", m3_MFPR.Value.ToString());
			if (m3_AURP.HasValue)
				request.WithQueryParameter("AURP", m3_AURP.Value.ToString());
			if (m3_OPCM.HasValue)
				request.WithQueryParameter("OPCM", m3_OPCM.Value.ToString());
			if (m3_AUIN.HasValue)
				request.WithQueryParameter("AUIN", m3_AUIN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFID))
				request.WithQueryParameter("CFID", m3_CFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFRI))
				request.WithQueryParameter("CFRI", m3_CFRI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NSUN))
				request.WithQueryParameter("NSUN", m3_NSUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT1))
				request.WithQueryParameter("TXT1", m3_TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT2))
				request.WithQueryParameter("TXT2", m3_TXT2.Trim());
			if (m3_ASOP.HasValue)
				request.WithQueryParameter("ASOP", m3_ASOP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SDUP))
				request.WithQueryParameter("SDUP", m3_SDUP.Trim());
			if (m3_MFP2.HasValue)
				request.WithQueryParameter("MFP2", m3_MFP2.Value.ToString());

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
		/// Name Delete
		/// Description Delete
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_SDUP">Skip direct update</param>
		/// <param name="m3_VRSN">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_MSEQ = null, 
			int? m3_OPNO = null, 
			int? m3_FDAT = null, 
			string m3_SDUP = null, 
			int? m3_VRSN = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SDUP))
				request.WithQueryParameter("SDUP", m3_SDUP.Trim());
			if (m3_VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3_VRSN.Value.ToString());

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
		/// Name GetComponent
		/// Description Get Component
		/// Version Release: 5ea6
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_VRSN">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetComponentResponse></returns>
		/// <exception cref="M3Exception<GetComponentResponse>"></exception>
		public async Task<M3Response<GetComponentResponse>> GetComponent(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_MSEQ = null, 
			int? m3_OPNO = null, 
			int? m3_FDAT = null, 
			int? m3_VRSN = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToString());
			if (m3_VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3_VRSN.Value.ToString());

			// Execute the request
			var result = await Execute<GetComponentResponse>(
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
		/// Description Get Operation
		/// Version Release: 5ea6
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_VRSN">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOperationResponse></returns>
		/// <exception cref="M3Exception<GetOperationResponse>"></exception>
		public async Task<M3Response<GetOperationResponse>> GetOperation(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_MSEQ = null, 
			int? m3_OPNO = null, 
			int? m3_FDAT = null, 
			int? m3_TDAT = null, 
			int? m3_VRSN = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToString());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToString());
			if (m3_VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3_VRSN.Value.ToString());

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
		/// Name GetOperation2
		/// Description Get OEM for Operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOperation2Response></returns>
		/// <exception cref="M3Exception<GetOperation2Response>"></exception>
		public async Task<M3Response<GetOperation2Response>> GetOperation2(
			string m3_FACI, 
			string m3_PRNO, 
			int m3_OPNO, 
			int? m3_CONO = null, 
			string m3_STRT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());

			// Execute the request
			var result = await Execute<GetOperation2Response>(
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
		/// Name LstComponent
		/// Description List Component
		/// Version Release: 5ea6
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstComponentResponse></returns>
		/// <exception cref="M3Exception<LstComponentResponse>"></exception>
		public async Task<M3Response<LstComponentResponse>> LstComponent(
			string m3_FACI, 
			int? m3_CONO = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_MSEQ = null, 
			int? m3_OPNO = null, 
			int? m3_FDAT = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToString());

			// Execute the request
			var result = await Execute<LstComponentResponse>(
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
		/// Name LstKitItems
		/// Description List Component
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstKitItemsResponse></returns>
		/// <exception cref="M3Exception<LstKitItemsResponse>"></exception>
		public async Task<M3Response<LstKitItemsResponse>> LstKitItems(
			string m3_FACI, 
			int? m3_CONO = null, 
			string m3_STRT = null, 
			string m3_PRNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());

			// Execute the request
			var result = await Execute<LstKitItemsResponse>(
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
		/// Name LstOperation
		/// Description List Operation
		/// Version Release: 5ea6
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOperationResponse></returns>
		/// <exception cref="M3Exception<LstOperationResponse>"></exception>
		public async Task<M3Response<LstOperationResponse>> LstOperation(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_MSEQ = null, 
			int? m3_OPNO = null, 
			int? m3_FDAT = null, 
			int? m3_TDAT = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToString());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToString());

			// Execute the request
			var result = await Execute<LstOperationResponse>(
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
		/// Description Search material
		/// Version Release: 5ea2
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
		/// Description Search operation
		/// Version Release: 5ea2
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
		/// Name SelMatByHead
		/// Description Transfer Material
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_APIP">APS - policy</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_CRTM">Critical material</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelMatByHeadResponse></returns>
		/// <exception cref="M3Exception<SelMatByHeadResponse>"></exception>
		public async Task<M3Response<SelMatByHeadResponse>> SelMatByHead(
			string m3_FACI, 
			string m3_APIP = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_CRTM = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3_CRTM.Value.ToString());

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
		/// Name SelOpeByHead
		/// Description Transfer Operations
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_APIP">APS - policy</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_CRTR">Critical resource</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelOpeByHeadResponse></returns>
		/// <exception cref="M3Exception<SelOpeByHeadResponse>"></exception>
		public async Task<M3Response<SelOpeByHeadResponse>> SelOpeByHead(
			string m3_FACI, 
			string m3_APIP = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelOpeByHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_CRTR.HasValue)
				request.WithQueryParameter("CRTR", m3_CRTR.Value.ToString());

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
		/// Name UpdOperation2
		/// Description Update OEM for Operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SMC0">User defined field 0</param>
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
		public async Task<M3Response<M3Record>> UpdOperation2(
			string m3_FACI, 
			string m3_PRNO, 
			int m3_OPNO, 
			int? m3_CONO = null, 
			string m3_STRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdOperation2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
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
		/// Name UpdateComponent
		/// Description Update Component
		/// Version Release: 5ea6
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_FDAT">From Date</param>
		/// <param name="m3_STRD">Structure date</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="m3_MTPL">Component number/work center</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_TECV">To revision number</param>
		/// <param name="m3_FECV">From revision number</param>
		/// <param name="m3_FLST">Floor stock</param>
		/// <param name="m3_OVOP">Order initiated</param>
		/// <param name="m3_OVTP">Phantom item</param>
		/// <param name="m3_ACTS">Operation element number</param>
		/// <param name="m3_SPMT">Issue method</param>
		/// <param name="m3_FXCD">Fixed quantity</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_CNQT">Quantity</param>
		/// <param name="m3_CCQT">Quantity on drawing</param>
		/// <param name="m3_PEUN">Product engineering U/M</param>
		/// <param name="m3_DWPO">Drawing position</param>
		/// <param name="m3_VAPC">Option percentage</param>
		/// <param name="m3_WAPC">Normal waste percentage</param>
		/// <param name="m3_STGS">Subcontract control</param>
		/// <param name="m3_SSUF">Subservice</param>
		/// <param name="m3_FMT1">Text</param>
		/// <param name="m3_FMT2">Technical reference</param>
		/// <param name="m3_MPRC">Component price</param>
		/// <param name="m3_EXMA">Yield component</param>
		/// <param name="m3_CMCD">Lot controlling component</param>
		/// <param name="m3_CRTM">Critical material</param>
		/// <param name="m3_SDCD">Standard</param>
		/// <param name="m3_BYPR">By/co-product code</param>
		/// <param name="m3_LGTH">Length</param>
		/// <param name="m3_WDTH">Width</param>
		/// <param name="m3_LWF1">Factor 1</param>
		/// <param name="m3_LWF2">Factor 2</param>
		/// <param name="m3_SIDI">Selection identity - component</param>
		/// <param name="m3_SITI">Selection type - component</param>
		/// <param name="m3_SIDQ">Selection identity - quantity</param>
		/// <param name="m3_SITQ">Selection type - quantity</param>
		/// <param name="m3_FORI">Formula result identity</param>
		/// <param name="m3_INHI">Item to inherit from</param>
		/// <param name="m3_SDUP">Skip direct update</param>
		/// <param name="m3_DSP6">Warning Indicator 1</param>
		/// <param name="m3_DSP5">Warning Indicator 2</param>
		/// <param name="m3_EXCH">Exchange</param>
		/// <param name="m3_VRSN">Version</param>
		/// <param name="m3_ELRF">External line reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdateComponent(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_MSEQ = null, 
			int? m3_OPNO = null, 
			int? m3_FDAT = null, 
			int? m3_STRD = null, 
			string m3_ECVE = null, 
			string m3_MTPL = null, 
			int? m3_TDAT = null, 
			string m3_TECV = null, 
			string m3_FECV = null, 
			int? m3_FLST = null, 
			string m3_OVOP = null, 
			string m3_OVTP = null, 
			int? m3_ACTS = null, 
			int? m3_SPMT = null, 
			int? m3_FXCD = null, 
			string m3_WHLO = null, 
			string m3_WHSL = null, 
			string m3_CNQT = null, 
			string m3_CCQT = null, 
			string m3_PEUN = null, 
			string m3_DWPO = null, 
			int? m3_VAPC = null, 
			int? m3_WAPC = null, 
			int? m3_STGS = null, 
			string m3_SSUF = null, 
			string m3_FMT1 = null, 
			string m3_FMT2 = null, 
			string m3_MPRC = null, 
			int? m3_EXMA = null, 
			int? m3_CMCD = null, 
			int? m3_CRTM = null, 
			int? m3_SDCD = null, 
			int? m3_BYPR = null, 
			int? m3_LGTH = null, 
			int? m3_WDTH = null, 
			string m3_LWF1 = null, 
			string m3_LWF2 = null, 
			string m3_SIDI = null, 
			int? m3_SITI = null, 
			string m3_SIDQ = null, 
			int? m3_SITQ = null, 
			string m3_FORI = null, 
			int? m3_INHI = null, 
			string m3_SDUP = null, 
			int? m3_DSP6 = null, 
			int? m3_DSP5 = null, 
			int? m3_EXCH = null, 
			int? m3_VRSN = null, 
			int? m3_ELRF = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToString());
			if (m3_STRD.HasValue)
				request.WithQueryParameter("STRD", m3_STRD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTPL))
				request.WithQueryParameter("MTPL", m3_MTPL.Trim());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TECV))
				request.WithQueryParameter("TECV", m3_TECV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FECV))
				request.WithQueryParameter("FECV", m3_FECV.Trim());
			if (m3_FLST.HasValue)
				request.WithQueryParameter("FLST", m3_FLST.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OVOP))
				request.WithQueryParameter("OVOP", m3_OVOP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVTP))
				request.WithQueryParameter("OVTP", m3_OVTP.Trim());
			if (m3_ACTS.HasValue)
				request.WithQueryParameter("ACTS", m3_ACTS.Value.ToString());
			if (m3_SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3_SPMT.Value.ToString());
			if (m3_FXCD.HasValue)
				request.WithQueryParameter("FXCD", m3_FXCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CNQT))
				request.WithQueryParameter("CNQT", m3_CNQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CCQT))
				request.WithQueryParameter("CCQT", m3_CCQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PEUN))
				request.WithQueryParameter("PEUN", m3_PEUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DWPO))
				request.WithQueryParameter("DWPO", m3_DWPO.Trim());
			if (m3_VAPC.HasValue)
				request.WithQueryParameter("VAPC", m3_VAPC.Value.ToString());
			if (m3_WAPC.HasValue)
				request.WithQueryParameter("WAPC", m3_WAPC.Value.ToString());
			if (m3_STGS.HasValue)
				request.WithQueryParameter("STGS", m3_STGS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SSUF))
				request.WithQueryParameter("SSUF", m3_SSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMT1))
				request.WithQueryParameter("FMT1", m3_FMT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMT2))
				request.WithQueryParameter("FMT2", m3_FMT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MPRC))
				request.WithQueryParameter("MPRC", m3_MPRC.Trim());
			if (m3_EXMA.HasValue)
				request.WithQueryParameter("EXMA", m3_EXMA.Value.ToString());
			if (m3_CMCD.HasValue)
				request.WithQueryParameter("CMCD", m3_CMCD.Value.ToString());
			if (m3_CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3_CRTM.Value.ToString());
			if (m3_SDCD.HasValue)
				request.WithQueryParameter("SDCD", m3_SDCD.Value.ToString());
			if (m3_BYPR.HasValue)
				request.WithQueryParameter("BYPR", m3_BYPR.Value.ToString());
			if (m3_LGTH.HasValue)
				request.WithQueryParameter("LGTH", m3_LGTH.Value.ToString());
			if (m3_WDTH.HasValue)
				request.WithQueryParameter("WDTH", m3_WDTH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LWF1))
				request.WithQueryParameter("LWF1", m3_LWF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LWF2))
				request.WithQueryParameter("LWF2", m3_LWF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SIDI))
				request.WithQueryParameter("SIDI", m3_SIDI.Trim());
			if (m3_SITI.HasValue)
				request.WithQueryParameter("SITI", m3_SITI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SIDQ))
				request.WithQueryParameter("SIDQ", m3_SIDQ.Trim());
			if (m3_SITQ.HasValue)
				request.WithQueryParameter("SITQ", m3_SITQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FORI))
				request.WithQueryParameter("FORI", m3_FORI.Trim());
			if (m3_INHI.HasValue)
				request.WithQueryParameter("INHI", m3_INHI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SDUP))
				request.WithQueryParameter("SDUP", m3_SDUP.Trim());
			if (m3_DSP6.HasValue)
				request.WithQueryParameter("DSP6", m3_DSP6.Value.ToString());
			if (m3_DSP5.HasValue)
				request.WithQueryParameter("DSP5", m3_DSP5.Value.ToString());
			if (m3_EXCH.HasValue)
				request.WithQueryParameter("EXCH", m3_EXCH.Value.ToString());
			if (m3_VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3_VRSN.Value.ToString());
			if (m3_ELRF.HasValue)
				request.WithQueryParameter("ELRF", m3_ELRF.Value.ToString());

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
		/// Name UpdateOperation
		/// Description Update Operation
		/// Version Release: 5ea6
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_STRD">Structure date</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="m3_MTPL">Component number/work center</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_OPDS">Operation description</param>
		/// <param name="m3_PITI">Run time</param>
		/// <param name="m3_CTCD">Price and time quantity</param>
		/// <param name="m3_SETI">Setup time</param>
		/// <param name="m3_FXTI">Fixed time</param>
		/// <param name="m3_OSET">External setup time</param>
		/// <param name="m3_PRNM">Planned number of machines</param>
		/// <param name="m3_PRNP">Planned number of workers - run time</param>
		/// <param name="m3_PHOP">Phantom operation method</param>
		/// <param name="m3_SENP">Planned number of workers - setup</param>
		/// <param name="m3_ODBF">Lead time offset</param>
		/// <param name="m3_PRDY">Production days</param>
		/// <param name="m3_SLAC">Transport value in days</param>
		/// <param name="m3_VAPC">Option percentage</param>
		/// <param name="m3_SCPC">Scrap percentage</param>
		/// <param name="m3_SWQT">Setup scrap</param>
		/// <param name="m3_DOID">Document identity</param>
		/// <param name="m3_TOOL">Tool number</param>
		/// <param name="m3_WLDE">Infinite/finite</param>
		/// <param name="m3_SUBC">Subcontract control</param>
		/// <param name="m3_SSUF">Subservice</param>
		/// <param name="m3_LASK">Labor skill</param>
		/// <param name="m3_SDCD">Standard</param>
		/// <param name="m3_INSK">Inspection skill</param>
		/// <param name="m3_PIPR">Unit price</param>
		/// <param name="m3_WAFA">Time rate</param>
		/// <param name="m3_SEPR">Setup price</param>
		/// <param name="m3_WCRF">Time reference</param>
		/// <param name="m3_KIWG">Pay element</param>
		/// <param name="m3_CAMP">Number of labor tickets</param>
		/// <param name="m3_INWE">Initial weight</param>
		/// <param name="m3_OPV3">Operation volume</param>
		/// <param name="m3_MFPR">Multiplication factor - manufacturing</param>
		/// <param name="m3_AURP">Automatic operation reporting</param>
		/// <param name="m3_OPCM">Operation cost multiplier</param>
		/// <param name="m3_AUIN">Automatic receipt</param>
		/// <param name="m3_CFID">Formula</param>
		/// <param name="m3_CFRI">Formula result</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_NSUN">Supplier at agent</param>
		/// <param name="m3_TXT1">Text line 1</param>
		/// <param name="m3_TXT2">Text line 2</param>
		/// <param name="m3_ASOP">Assembly operation</param>
		/// <param name="m3_SDUP">Skip direct update</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_VRSN">Version</param>
		/// <param name="m3_MFP2">Multiplication factor - manufacturing</param>
		/// <param name="m3_AMAO">Additional material offset</param>
		/// <param name="m3_APON">APP operation number</param>
		/// <param name="m3_NXOP">Next APP operation number</param>
		/// <param name="m3_SLAT">Transit unit of measure/Overlap code</param>
		/// <param name="m3_POOC">Parallel operation overlap code</param>
		/// <param name="m3_RESR">Resource restriction</param>
		/// <param name="m3_PRET">Preparation time</param>
		/// <param name="m3_SPLK">Split method - operation</param>
		/// <param name="m3_SPLN">Number of operations after split</param>
		/// <param name="m3_SPSZ">Split quantity</param>
		/// <param name="m3_MDOP">Max duration of operation in percent</param>
		/// <param name="m3_POTM">Post-operation time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdateOperation(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_MSEQ = null, 
			int? m3_OPNO = null, 
			int? m3_FDAT = null, 
			int? m3_STRD = null, 
			string m3_ECVE = null, 
			string m3_MTPL = null, 
			string m3_PLGR = null, 
			string m3_OPDS = null, 
			int? m3_PITI = null, 
			int? m3_CTCD = null, 
			int? m3_SETI = null, 
			int? m3_FXTI = null, 
			int? m3_OSET = null, 
			int? m3_PRNM = null, 
			int? m3_PRNP = null, 
			int? m3_PHOP = null, 
			int? m3_SENP = null, 
			int? m3_ODBF = null, 
			int? m3_PRDY = null, 
			string m3_SLAC = null, 
			int? m3_VAPC = null, 
			int? m3_SCPC = null, 
			string m3_SWQT = null, 
			string m3_DOID = null, 
			string m3_TOOL = null, 
			int? m3_WLDE = null, 
			string m3_SUBC = null, 
			string m3_SSUF = null, 
			string m3_LASK = null, 
			int? m3_SDCD = null, 
			string m3_INSK = null, 
			string m3_PIPR = null, 
			string m3_WAFA = null, 
			string m3_SEPR = null, 
			string m3_WCRF = null, 
			int? m3_KIWG = null, 
			int? m3_CAMP = null, 
			int? m3_INWE = null, 
			int? m3_OPV3 = null, 
			int? m3_MFPR = null, 
			int? m3_AURP = null, 
			int? m3_OPCM = null, 
			int? m3_AUIN = null, 
			string m3_CFID = null, 
			string m3_CFRI = null, 
			string m3_SUNO = null, 
			string m3_NSUN = null, 
			string m3_TXT1 = null, 
			string m3_TXT2 = null, 
			int? m3_ASOP = null, 
			string m3_SDUP = null, 
			int? m3_TDAT = null, 
			int? m3_VRSN = null, 
			int? m3_MFP2 = null, 
			int? m3_AMAO = null, 
			int? m3_APON = null, 
			int? m3_NXOP = null, 
			string m3_SLAT = null, 
			int? m3_POOC = null, 
			string m3_RESR = null, 
			int? m3_PRET = null, 
			int? m3_SPLK = null, 
			int? m3_SPLN = null, 
			decimal? m3_SPSZ = null, 
			int? m3_MDOP = null, 
			int? m3_POTM = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToString());
			if (m3_STRD.HasValue)
				request.WithQueryParameter("STRD", m3_STRD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTPL))
				request.WithQueryParameter("MTPL", m3_MTPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPDS))
				request.WithQueryParameter("OPDS", m3_OPDS.Trim());
			if (m3_PITI.HasValue)
				request.WithQueryParameter("PITI", m3_PITI.Value.ToString());
			if (m3_CTCD.HasValue)
				request.WithQueryParameter("CTCD", m3_CTCD.Value.ToString());
			if (m3_SETI.HasValue)
				request.WithQueryParameter("SETI", m3_SETI.Value.ToString());
			if (m3_FXTI.HasValue)
				request.WithQueryParameter("FXTI", m3_FXTI.Value.ToString());
			if (m3_OSET.HasValue)
				request.WithQueryParameter("OSET", m3_OSET.Value.ToString());
			if (m3_PRNM.HasValue)
				request.WithQueryParameter("PRNM", m3_PRNM.Value.ToString());
			if (m3_PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3_PRNP.Value.ToString());
			if (m3_PHOP.HasValue)
				request.WithQueryParameter("PHOP", m3_PHOP.Value.ToString());
			if (m3_SENP.HasValue)
				request.WithQueryParameter("SENP", m3_SENP.Value.ToString());
			if (m3_ODBF.HasValue)
				request.WithQueryParameter("ODBF", m3_ODBF.Value.ToString());
			if (m3_PRDY.HasValue)
				request.WithQueryParameter("PRDY", m3_PRDY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SLAC))
				request.WithQueryParameter("SLAC", m3_SLAC.Trim());
			if (m3_VAPC.HasValue)
				request.WithQueryParameter("VAPC", m3_VAPC.Value.ToString());
			if (m3_SCPC.HasValue)
				request.WithQueryParameter("SCPC", m3_SCPC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SWQT))
				request.WithQueryParameter("SWQT", m3_SWQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOOL))
				request.WithQueryParameter("TOOL", m3_TOOL.Trim());
			if (m3_WLDE.HasValue)
				request.WithQueryParameter("WLDE", m3_WLDE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUBC))
				request.WithQueryParameter("SUBC", m3_SUBC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSUF))
				request.WithQueryParameter("SSUF", m3_SSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LASK))
				request.WithQueryParameter("LASK", m3_LASK.Trim());
			if (m3_SDCD.HasValue)
				request.WithQueryParameter("SDCD", m3_SDCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INSK))
				request.WithQueryParameter("INSK", m3_INSK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PIPR))
				request.WithQueryParameter("PIPR", m3_PIPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WAFA))
				request.WithQueryParameter("WAFA", m3_WAFA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SEPR))
				request.WithQueryParameter("SEPR", m3_SEPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WCRF))
				request.WithQueryParameter("WCRF", m3_WCRF.Trim());
			if (m3_KIWG.HasValue)
				request.WithQueryParameter("KIWG", m3_KIWG.Value.ToString());
			if (m3_CAMP.HasValue)
				request.WithQueryParameter("CAMP", m3_CAMP.Value.ToString());
			if (m3_INWE.HasValue)
				request.WithQueryParameter("INWE", m3_INWE.Value.ToString());
			if (m3_OPV3.HasValue)
				request.WithQueryParameter("OPV3", m3_OPV3.Value.ToString());
			if (m3_MFPR.HasValue)
				request.WithQueryParameter("MFPR", m3_MFPR.Value.ToString());
			if (m3_AURP.HasValue)
				request.WithQueryParameter("AURP", m3_AURP.Value.ToString());
			if (m3_OPCM.HasValue)
				request.WithQueryParameter("OPCM", m3_OPCM.Value.ToString());
			if (m3_AUIN.HasValue)
				request.WithQueryParameter("AUIN", m3_AUIN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFID))
				request.WithQueryParameter("CFID", m3_CFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFRI))
				request.WithQueryParameter("CFRI", m3_CFRI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NSUN))
				request.WithQueryParameter("NSUN", m3_NSUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT1))
				request.WithQueryParameter("TXT1", m3_TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT2))
				request.WithQueryParameter("TXT2", m3_TXT2.Trim());
			if (m3_ASOP.HasValue)
				request.WithQueryParameter("ASOP", m3_ASOP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SDUP))
				request.WithQueryParameter("SDUP", m3_SDUP.Trim());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToString());
			if (m3_VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3_VRSN.Value.ToString());
			if (m3_MFP2.HasValue)
				request.WithQueryParameter("MFP2", m3_MFP2.Value.ToString());
			if (m3_AMAO.HasValue)
				request.WithQueryParameter("AMAO", m3_AMAO.Value.ToString());
			if (m3_APON.HasValue)
				request.WithQueryParameter("APON", m3_APON.Value.ToString());
			if (m3_NXOP.HasValue)
				request.WithQueryParameter("NXOP", m3_NXOP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SLAT))
				request.WithQueryParameter("SLAT", m3_SLAT.Trim());
			if (m3_POOC.HasValue)
				request.WithQueryParameter("POOC", m3_POOC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESR))
				request.WithQueryParameter("RESR", m3_RESR.Trim());
			if (m3_PRET.HasValue)
				request.WithQueryParameter("PRET", m3_PRET.Value.ToString());
			if (m3_SPLK.HasValue)
				request.WithQueryParameter("SPLK", m3_SPLK.Value.ToString());
			if (m3_SPLN.HasValue)
				request.WithQueryParameter("SPLN", m3_SPLN.Value.ToString());
			if (m3_SPSZ.HasValue)
				request.WithQueryParameter("SPSZ", m3_SPSZ.Value.ToString());
			if (m3_MDOP.HasValue)
				request.WithQueryParameter("MDOP", m3_MDOP.Value.ToString());
			if (m3_POTM.HasValue)
				request.WithQueryParameter("POTM", m3_POTM.Value.ToString());

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
