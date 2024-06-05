/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MOS170MI;
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
	/// Name: MOS170MI
	/// Component Name: MaintenanceOrderProposals
	/// Description: Maintenance order proposals interface
	/// Version Release: 5ea3
	///</summary>
	public partial class MOS170MIResource : M3BaseResourceEndpoint
	{
		public MOS170MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS170MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddMtrl
		/// Description Add Material
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PLPN">Planned order (Required)</param>
		/// <param name="m3_PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3_PLP2">Subnumber - order proposal (Required)</param>
		/// <param name="m3_MTNO">Component number (Required)</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_DWPO">Drawing position</param>
		/// <param name="m3_STGS">Subcontract control</param>
		/// <param name="m3_FMT1">Text</param>
		/// <param name="m3_FMT2">Technical reference</param>
		/// <param name="m3_CNQT">Quantity</param>
		/// <param name="m3_LGTH">Length</param>
		/// <param name="m3_WDTH">Width</param>
		/// <param name="m3_LWF1">Factor 1</param>
		/// <param name="m3_LWF2">Factor 2</param>
		/// <param name="m3_VAPC">Option percentage</param>
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
		/// <param name="m3_SPMT">Issue method</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_PEUN">Product engineering U/M</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_EXCH">Exchange</param>
		/// <param name="m3_ADRR">Address file</param>
		/// <param name="m3_ADRT">Address type</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_IORN">Interface order number</param>
		/// <param name="m3_IORL">Interface order line</param>
		/// <param name="m3_IOSX">Interface line suffix</param>
		/// <param name="m3_OT53">Abnormal demand</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddMtrl(
			int m3_PLPN, 
			int m3_PLPS, 
			int m3_PLP2, 
			string m3_MTNO, 
			int? m3_OPNO = null, 
			int? m3_MSEQ = null, 
			string m3_DWPO = null, 
			int? m3_STGS = null, 
			string m3_FMT1 = null, 
			string m3_FMT2 = null, 
			decimal? m3_CNQT = null, 
			int? m3_LGTH = null, 
			int? m3_WDTH = null, 
			decimal? m3_LWF1 = null, 
			decimal? m3_LWF2 = null, 
			int? m3_VAPC = null, 
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
			int? m3_SPMT = null, 
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			decimal? m3_ATNR = null, 
			string m3_PEUN = null, 
			decimal? m3_TXID = null, 
			int? m3_EXCH = null, 
			int? m3_ADRR = null, 
			int? m3_ADRT = null, 
			string m3_ADID = null, 
			string m3_IORN = null, 
			int? m3_IORL = null, 
			int? m3_IOSX = null, 
			int? m3_OT53 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_MTNO))
				throw new ArgumentNullException("m3_MTNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString())
				.WithQueryParameter("PLPS", m3_PLPS.ToString())
				.WithQueryParameter("PLP2", m3_PLP2.ToString())
				.WithQueryParameter("MTNO", m3_MTNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DWPO))
				request.WithQueryParameter("DWPO", m3_DWPO.Trim());
			if (m3_STGS.HasValue)
				request.WithQueryParameter("STGS", m3_STGS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FMT1))
				request.WithQueryParameter("FMT1", m3_FMT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMT2))
				request.WithQueryParameter("FMT2", m3_FMT2.Trim());
			if (m3_CNQT.HasValue)
				request.WithQueryParameter("CNQT", m3_CNQT.Value.ToString());
			if (m3_LGTH.HasValue)
				request.WithQueryParameter("LGTH", m3_LGTH.Value.ToString());
			if (m3_WDTH.HasValue)
				request.WithQueryParameter("WDTH", m3_WDTH.Value.ToString());
			if (m3_LWF1.HasValue)
				request.WithQueryParameter("LWF1", m3_LWF1.Value.ToString());
			if (m3_LWF2.HasValue)
				request.WithQueryParameter("LWF2", m3_LWF2.Value.ToString());
			if (m3_VAPC.HasValue)
				request.WithQueryParameter("VAPC", m3_VAPC.Value.ToString());
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
			if (m3_SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3_SPMT.Value.ToString());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PEUN))
				request.WithQueryParameter("PEUN", m3_PEUN.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_EXCH.HasValue)
				request.WithQueryParameter("EXCH", m3_EXCH.Value.ToString());
			if (m3_ADRR.HasValue)
				request.WithQueryParameter("ADRR", m3_ADRR.Value.ToString());
			if (m3_ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3_ADRT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IORN))
				request.WithQueryParameter("IORN", m3_IORN.Trim());
			if (m3_IORL.HasValue)
				request.WithQueryParameter("IORL", m3_IORL.Value.ToString());
			if (m3_IOSX.HasValue)
				request.WithQueryParameter("IOSX", m3_IOSX.Value.ToString());
			if (m3_OT53.HasValue)
				request.WithQueryParameter("OT53", m3_OT53.Value.ToString());

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
		/// Name AddOp
		/// Description Add Operation
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PLPN">Planned order (Required)</param>
		/// <param name="m3_PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3_PLP2">Subnumber - order proposal (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_PLGR">Work center (Required)</param>
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
		/// <param name="m3_DPLG">Deviating work center</param>
		/// <param name="m3_WLDE">Infinite/finite</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_EQNO">Equipment number</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_SPRQ">Specific requirement category</param>
		/// <param name="m3_SPRT">Specific requirements</param>
		/// <param name="m3_FCLA">Error code 1</param>
		/// <param name="m3_FCL2">Error code 2</param>
		/// <param name="m3_FCL3">Error code 3</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_SEPR">Setup price</param>
		/// <param name="m3_PIPR">Unit price</param>
		/// <param name="m3_IORN">Interface order number</param>
		/// <param name="m3_IORL">Interface order line</param>
		/// <param name="m3_IOSX">Interface line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddOp(
			int m3_PLPN, 
			int m3_PLPS, 
			int m3_PLP2, 
			int m3_OPNO, 
			string m3_PLGR, 
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
			string m3_DPLG = null, 
			int? m3_WLDE = null, 
			decimal? m3_TXID = null, 
			string m3_CFGL = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_EQNO = null, 
			string m3_SUFI = null, 
			string m3_SPRQ = null, 
			string m3_SPRT = null, 
			string m3_FCLA = null, 
			string m3_FCL2 = null, 
			string m3_FCL3 = null, 
			decimal? m3_ATNR = null, 
			decimal? m3_SEPR = null, 
			decimal? m3_PIPR = null, 
			string m3_IORN = null, 
			int? m3_IORL = null, 
			int? m3_IOSX = null, 
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
			if (string.IsNullOrWhiteSpace(m3_PLGR))
				throw new ArgumentNullException("m3_PLGR");

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString())
				.WithQueryParameter("PLPS", m3_PLPS.ToString())
				.WithQueryParameter("PLP2", m3_PLP2.ToString())
				.WithQueryParameter("OPNO", m3_OPNO.ToString())
				.WithQueryParameter("PLGR", m3_PLGR.Trim());

			// Set optional parameters, checking for null/blank data for each element
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
			if (!string.IsNullOrWhiteSpace(m3_DPLG))
				request.WithQueryParameter("DPLG", m3_DPLG.Trim());
			if (m3_WLDE.HasValue)
				request.WithQueryParameter("WLDE", m3_WLDE.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_FCLA))
				request.WithQueryParameter("FCLA", m3_FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL2))
				request.WithQueryParameter("FCL2", m3_FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL3))
				request.WithQueryParameter("FCL3", m3_FCL3.Trim());
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (m3_SEPR.HasValue)
				request.WithQueryParameter("SEPR", m3_SEPR.Value.ToString());
			if (m3_PIPR.HasValue)
				request.WithQueryParameter("PIPR", m3_PIPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_IORN))
				request.WithQueryParameter("IORN", m3_IORN.Trim());
			if (m3_IORL.HasValue)
				request.WithQueryParameter("IORL", m3_IORL.Value.ToString());
			if (m3_IOSX.HasValue)
				request.WithQueryParameter("IOSX", m3_IOSX.Value.ToString());

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
		/// Name AddOp2
		/// Description Add OEM for Operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLPN">Planned order (Required)</param>
		/// <param name="m3_PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3_PLP2">Subnumber - order proposal (Required)</param>
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
			int m3_PLPN, 
			int m3_PLPS, 
			int m3_PLP2, 
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

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString())
				.WithQueryParameter("PLPS", m3_PLPS.ToString())
				.WithQueryParameter("PLP2", m3_PLP2.ToString())
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
		/// Name AddOpElement
		/// Description Add Operation Elemet
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLPN">Planned order (Required)</param>
		/// <param name="m3_PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3_PLP2">Subnumber - order proposal (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_ACTS">Task element number (Required)</param>
		/// <param name="m3_ACTT">Operation element type (Required)</param>
		/// <param name="m3_ACTR">Work element</param>
		/// <param name="m3_TOOL">Tool number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="m3_DOID">Document identity</param>
		/// <param name="m3_INSI">Inspection identity</param>
		/// <param name="m3_ACDS">Description</param>
		/// <param name="m3_TXT1">Text line 1</param>
		/// <param name="m3_TXT2">Text line 2</param>
		/// <param name="m3_SETI">Setup time</param>
		/// <param name="m3_PITI">Run time</param>
		/// <param name="m3_SENP">Planned number of workers - setup</param>
		/// <param name="m3_PRNP">Planned number of workers - run time</param>
		/// <param name="m3_LASK">Labor skill</param>
		/// <param name="m3_INSK">Inspection skill</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_PERM">Permit</param>
		/// <param name="m3_TPRM">Permit type</param>
		/// <param name="m3_PRMA">Permit mandatory</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_CATY">Capability type</param>
		/// <param name="m3_TRQT">Transaction quantity - basic U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddOpElement(
			int m3_PLPN, 
			int m3_PLPS, 
			int m3_PLP2, 
			int m3_OPNO, 
			int m3_ACTS, 
			string m3_ACTT, 
			string m3_ACTR = null, 
			string m3_TOOL = null, 
			string m3_SERN = null, 
			string m3_EMNO = null, 
			string m3_DOID = null, 
			string m3_INSI = null, 
			string m3_ACDS = null, 
			string m3_TXT1 = null, 
			string m3_TXT2 = null, 
			int? m3_SETI = null, 
			int? m3_PITI = null, 
			int? m3_SENP = null, 
			int? m3_PRNP = null, 
			string m3_LASK = null, 
			string m3_INSK = null, 
			string m3_STAT = null, 
			string m3_PERM = null, 
			string m3_TPRM = null, 
			int? m3_PRMA = null, 
			decimal? m3_TXID = null, 
			string m3_CATY = null, 
			decimal? m3_TRQT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddOpElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ACTT))
				throw new ArgumentNullException("m3_ACTT");

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString())
				.WithQueryParameter("PLPS", m3_PLPS.ToString())
				.WithQueryParameter("PLP2", m3_PLP2.ToString())
				.WithQueryParameter("OPNO", m3_OPNO.ToString())
				.WithQueryParameter("ACTS", m3_ACTS.ToString())
				.WithQueryParameter("ACTT", m3_ACTT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ACTR))
				request.WithQueryParameter("ACTR", m3_ACTR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOOL))
				request.WithQueryParameter("TOOL", m3_TOOL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INSI))
				request.WithQueryParameter("INSI", m3_INSI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACDS))
				request.WithQueryParameter("ACDS", m3_ACDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT1))
				request.WithQueryParameter("TXT1", m3_TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT2))
				request.WithQueryParameter("TXT2", m3_TXT2.Trim());
			if (m3_SETI.HasValue)
				request.WithQueryParameter("SETI", m3_SETI.Value.ToString());
			if (m3_PITI.HasValue)
				request.WithQueryParameter("PITI", m3_PITI.Value.ToString());
			if (m3_SENP.HasValue)
				request.WithQueryParameter("SENP", m3_SENP.Value.ToString());
			if (m3_PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3_PRNP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LASK))
				request.WithQueryParameter("LASK", m3_LASK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INSK))
				request.WithQueryParameter("INSK", m3_INSK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PERM))
				request.WithQueryParameter("PERM", m3_PERM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TPRM))
				request.WithQueryParameter("TPRM", m3_TPRM.Trim());
			if (m3_PRMA.HasValue)
				request.WithQueryParameter("PRMA", m3_PRMA.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CATY))
				request.WithQueryParameter("CATY", m3_CATY.Trim());
			if (m3_TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3_TRQT.Value.ToString());

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
		/// Name AddProp
		/// Description Add proposal
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TAIL">TailNumber</param>
		/// <param name="m3_CFGL">ConfigPosition</param>
		/// <param name="m3_EQNO">Equipment</param>
		/// <param name="m3_STRT">Structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_PLGR">PlanningGroup</param>
		/// <param name="m3_PRIP">Priority</param>
		/// <param name="m3_APRB">ApprovedBy</param>
		/// <param name="m3_RSCD">ReasonCode</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_FIDT">Finish date</param>
		/// <param name="m3_TXT1">Text line 1</param>
		/// <param name="m3_TXT2">Text line 2</param>
		/// <param name="m3_FCLA">Error code 1</param>
		/// <param name="m3_FCL2">Error code 2</param>
		/// <param name="m3_FCL3">Error code 3</param>
		/// <param name="m3_CTPE">Complaint type</param>
		/// <param name="m3_RTRO">REtro order</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_PPQT">Planned quantity</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_TXID">Text Identity</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_ESBU">Estimated cost</param>
		/// <param name="m3_RREQ">Requester</param>
		/// <param name="m3_RBAM">Request budget amount</param>
		/// <param name="m3_RRSD">Requested start date</param>
		/// <param name="m3_RRST">Requested start time</param>
		/// <param name="m3_RRFD">Requested finish date</param>
		/// <param name="m3_RRFT">Requested finish time</param>
		/// <param name="m3_EDWT">Estimated downtime</param>
		/// <param name="m3_SCHL">Scheduling logic</param>
		/// <param name="m3_DEID">Complaint</param>
		/// <param name="m3_AECN">Engineering order number</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_EMNO">Employee number</param>
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
		/// <param name="m3_ADRR">Address file</param>
		/// <param name="m3_ADRT">Address type</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_FWSL">From location</param>
		/// <param name="m3_IORN">Interface order number</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_AAGN">Agreement</param>
		/// <param name="m3_AOTY">Order type</param>
		/// <param name="m3_CUOR">Customer´s order number</param>
		/// <param name="m3_CUPO">Order line number</param>
		/// <param name="m3_CUSX">Line suffix</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_MSTI">Start time</param>
		/// <param name="m3_MFTI">Finish time</param>
		/// <param name="m3_BRDT">Breakdown date</param>
		/// <param name="m3_BRTI">Break down time</param>
		/// <param name="m3_WATP">Warranty type</param>
		/// <param name="m3_GWAR">Generic warranty</param>
		/// <param name="m3_PITI">Run time</param>
		/// <param name="m3_CFI1">User-defined field 1 - item</param>
		/// <param name="m3_CFI2">User-defined field 2 - item</param>
		/// <param name="m3_CFI3">User-defined field 3 - item</param>
		/// <param name="m3_CFI4">User-defined field 4 - item</param>
		/// <param name="m3_CFI5">User-defined field 5 - item</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_EVTY">Event type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPropResponse></returns>
		/// <exception cref="M3Exception<AddPropResponse>"></exception>
		public async Task<M3Response<AddPropResponse>> AddProp(
			int? m3_CONO = null, 
			string m3_TAIL = null, 
			string m3_CFGL = null, 
			string m3_EQNO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			string m3_RESP = null, 
			string m3_TX40 = null, 
			string m3_PLGR = null, 
			string m3_PRIP = null, 
			string m3_APRB = null, 
			string m3_RSCD = null, 
			DateTime? m3_STDT = null, 
			DateTime? m3_FIDT = null, 
			string m3_TXT1 = null, 
			string m3_TXT2 = null, 
			string m3_FCLA = null, 
			string m3_FCL2 = null, 
			string m3_FCL3 = null, 
			string m3_CTPE = null, 
			int? m3_RTRO = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			decimal? m3_PPQT = null, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			decimal? m3_TXID = null, 
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			decimal? m3_ESBU = null, 
			string m3_RREQ = null, 
			decimal? m3_RBAM = null, 
			DateTime? m3_RRSD = null, 
			int? m3_RRST = null, 
			DateTime? m3_RRFD = null, 
			int? m3_RRFT = null, 
			int? m3_EDWT = null, 
			int? m3_SCHL = null, 
			int? m3_DEID = null, 
			string m3_AECN = null, 
			string m3_ORTY = null, 
			string m3_EMNO = null, 
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
			int? m3_ADRR = null, 
			int? m3_ADRT = null, 
			string m3_ADID = null, 
			string m3_FWSL = null, 
			string m3_IORN = null, 
			string m3_CUNO = null, 
			string m3_AAGN = null, 
			string m3_AOTY = null, 
			string m3_CUOR = null, 
			int? m3_CUPO = null, 
			int? m3_CUSX = null, 
			string m3_YREF = null, 
			int? m3_MSTI = null, 
			int? m3_MFTI = null, 
			DateTime? m3_BRDT = null, 
			int? m3_BRTI = null, 
			string m3_WATP = null, 
			int? m3_GWAR = null, 
			int? m3_PITI = null, 
			string m3_CFI1 = null, 
			decimal? m3_CFI2 = null, 
			string m3_CFI3 = null, 
			string m3_CFI4 = null, 
			string m3_CFI5 = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_EVTY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddProp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TAIL))
				request.WithQueryParameter("TAIL", m3_TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQNO))
				request.WithQueryParameter("EQNO", m3_EQNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRIP))
				request.WithQueryParameter("PRIP", m3_PRIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APRB))
				request.WithQueryParameter("APRB", m3_APRB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3_FIDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TXT1))
				request.WithQueryParameter("TXT1", m3_TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT2))
				request.WithQueryParameter("TXT2", m3_TXT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCLA))
				request.WithQueryParameter("FCLA", m3_FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL2))
				request.WithQueryParameter("FCL2", m3_FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL3))
				request.WithQueryParameter("FCL3", m3_FCL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTPE))
				request.WithQueryParameter("CTPE", m3_CTPE.Trim());
			if (m3_RTRO.HasValue)
				request.WithQueryParameter("RTRO", m3_RTRO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_PPQT.HasValue)
				request.WithQueryParameter("PPQT", m3_PPQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_ESBU.HasValue)
				request.WithQueryParameter("ESBU", m3_ESBU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RREQ))
				request.WithQueryParameter("RREQ", m3_RREQ.Trim());
			if (m3_RBAM.HasValue)
				request.WithQueryParameter("RBAM", m3_RBAM.Value.ToString());
			if (m3_RRSD.HasValue)
				request.WithQueryParameter("RRSD", m3_RRSD.Value.ToM3String());
			if (m3_RRST.HasValue)
				request.WithQueryParameter("RRST", m3_RRST.Value.ToString());
			if (m3_RRFD.HasValue)
				request.WithQueryParameter("RRFD", m3_RRFD.Value.ToM3String());
			if (m3_RRFT.HasValue)
				request.WithQueryParameter("RRFT", m3_RRFT.Value.ToString());
			if (m3_EDWT.HasValue)
				request.WithQueryParameter("EDWT", m3_EDWT.Value.ToString());
			if (m3_SCHL.HasValue)
				request.WithQueryParameter("SCHL", m3_SCHL.Value.ToString());
			if (m3_DEID.HasValue)
				request.WithQueryParameter("DEID", m3_DEID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AECN))
				request.WithQueryParameter("AECN", m3_AECN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
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
			if (m3_ADRR.HasValue)
				request.WithQueryParameter("ADRR", m3_ADRR.Value.ToString());
			if (m3_ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3_ADRT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FWSL))
				request.WithQueryParameter("FWSL", m3_FWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IORN))
				request.WithQueryParameter("IORN", m3_IORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AAGN))
				request.WithQueryParameter("AAGN", m3_AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AOTY))
				request.WithQueryParameter("AOTY", m3_AOTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (m3_CUPO.HasValue)
				request.WithQueryParameter("CUPO", m3_CUPO.Value.ToString());
			if (m3_CUSX.HasValue)
				request.WithQueryParameter("CUSX", m3_CUSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (m3_MSTI.HasValue)
				request.WithQueryParameter("MSTI", m3_MSTI.Value.ToString());
			if (m3_MFTI.HasValue)
				request.WithQueryParameter("MFTI", m3_MFTI.Value.ToString());
			if (m3_BRDT.HasValue)
				request.WithQueryParameter("BRDT", m3_BRDT.Value.ToM3String());
			if (m3_BRTI.HasValue)
				request.WithQueryParameter("BRTI", m3_BRTI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WATP))
				request.WithQueryParameter("WATP", m3_WATP.Trim());
			if (m3_GWAR.HasValue)
				request.WithQueryParameter("GWAR", m3_GWAR.Value.ToString());
			if (m3_PITI.HasValue)
				request.WithQueryParameter("PITI", m3_PITI.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVTY))
				request.WithQueryParameter("EVTY", m3_EVTY.Trim());

			// Execute the request
			var result = await Execute<AddPropResponse>(
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
		/// Description Change Material
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PLPN">Planned order (Required)</param>
		/// <param name="m3_PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3_PLP2">Subnumber - order proposal (Required)</param>
		/// <param name="m3_MSEQ">Sequence number (Required)</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_DWPO">Drawing position</param>
		/// <param name="m3_STGS">Subcontract control</param>
		/// <param name="m3_MTNO">Component number</param>
		/// <param name="m3_FMT1">Text</param>
		/// <param name="m3_FMT2">Technical reference</param>
		/// <param name="m3_CNQT">Quantity</param>
		/// <param name="m3_LGTH">Length</param>
		/// <param name="m3_WDTH">Width</param>
		/// <param name="m3_LWF1">Factor 1</param>
		/// <param name="m3_LWF2">Factor 2</param>
		/// <param name="m3_VAPC">Option percentage</param>
		/// <param name="m3_RDAT">Reservation date</param>
		/// <param name="m3_TIHM">Time hours & minutes</param>
		/// <param name="m3_MDBF">Lead time offset</param>
		/// <param name="m3_MPRC">Component price</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_PRDY">Production days</param>
		/// <param name="m3_SPMT">Issue method</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_PEUN">Product engineering U/M</param>
		/// <param name="m3_ADRR">Address file</param>
		/// <param name="m3_ADRT">Address type</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_OT53">Abnormal demand</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgMtrl(
			int m3_PLPN, 
			int m3_PLPS, 
			int m3_PLP2, 
			int m3_MSEQ, 
			int? m3_OPNO = null, 
			string m3_DWPO = null, 
			int? m3_STGS = null, 
			string m3_MTNO = null, 
			string m3_FMT1 = null, 
			string m3_FMT2 = null, 
			decimal? m3_CNQT = null, 
			int? m3_LGTH = null, 
			int? m3_WDTH = null, 
			decimal? m3_LWF1 = null, 
			decimal? m3_LWF2 = null, 
			int? m3_VAPC = null, 
			DateTime? m3_RDAT = null, 
			int? m3_TIHM = null, 
			int? m3_MDBF = null, 
			decimal? m3_MPRC = null, 
			string m3_WHSL = null, 
			string m3_TWSL = null, 
			string m3_BANO = null, 
			string m3_SUNO = null, 
			int? m3_PRDY = null, 
			int? m3_SPMT = null, 
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			decimal? m3_ATNR = null, 
			decimal? m3_TXID = null, 
			string m3_PEUN = null, 
			int? m3_ADRR = null, 
			int? m3_ADRT = null, 
			string m3_ADID = null, 
			int? m3_OT53 = null, 
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

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString())
				.WithQueryParameter("PLPS", m3_PLPS.ToString())
				.WithQueryParameter("PLP2", m3_PLP2.ToString())
				.WithQueryParameter("MSEQ", m3_MSEQ.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DWPO))
				request.WithQueryParameter("DWPO", m3_DWPO.Trim());
			if (m3_STGS.HasValue)
				request.WithQueryParameter("STGS", m3_STGS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MTNO))
				request.WithQueryParameter("MTNO", m3_MTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMT1))
				request.WithQueryParameter("FMT1", m3_FMT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMT2))
				request.WithQueryParameter("FMT2", m3_FMT2.Trim());
			if (m3_CNQT.HasValue)
				request.WithQueryParameter("CNQT", m3_CNQT.Value.ToString());
			if (m3_LGTH.HasValue)
				request.WithQueryParameter("LGTH", m3_LGTH.Value.ToString());
			if (m3_WDTH.HasValue)
				request.WithQueryParameter("WDTH", m3_WDTH.Value.ToString());
			if (m3_LWF1.HasValue)
				request.WithQueryParameter("LWF1", m3_LWF1.Value.ToString());
			if (m3_LWF2.HasValue)
				request.WithQueryParameter("LWF2", m3_LWF2.Value.ToString());
			if (m3_VAPC.HasValue)
				request.WithQueryParameter("VAPC", m3_VAPC.Value.ToString());
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
			if (m3_SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3_SPMT.Value.ToString());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PEUN))
				request.WithQueryParameter("PEUN", m3_PEUN.Trim());
			if (m3_ADRR.HasValue)
				request.WithQueryParameter("ADRR", m3_ADRR.Value.ToString());
			if (m3_ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3_ADRT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (m3_OT53.HasValue)
				request.WithQueryParameter("OT53", m3_OT53.Value.ToString());

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
		/// Description Change Operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLPN">Planned order (Required)</param>
		/// <param name="m3_PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3_PLP2">Subnumber - order proposal (Required)</param>
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
		/// <param name="m3_DPLG">Deviating work center</param>
		/// <param name="m3_WLDE">Infinite/finite</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_EQNO">Equipment number</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_SPRQ">Specific requirement category</param>
		/// <param name="m3_SPRT">Specific requirements</param>
		/// <param name="m3_FCLA">Error code 1</param>
		/// <param name="m3_FCL2">Error code 2</param>
		/// <param name="m3_FCL3">Error code 3</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_SEPR">Setup price</param>
		/// <param name="m3_PIPR">Unit price</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgOp(
			int m3_PLPN, 
			int m3_PLPS, 
			int m3_PLP2, 
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
			string m3_DPLG = null, 
			int? m3_WLDE = null, 
			decimal? m3_TXID = null, 
			string m3_CFGL = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_EQNO = null, 
			string m3_SUFI = null, 
			string m3_SPRQ = null, 
			string m3_SPRT = null, 
			string m3_FCLA = null, 
			string m3_FCL2 = null, 
			string m3_FCL3 = null, 
			decimal? m3_ATNR = null, 
			decimal? m3_SEPR = null, 
			decimal? m3_PIPR = null, 
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

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString())
				.WithQueryParameter("PLPS", m3_PLPS.ToString())
				.WithQueryParameter("PLP2", m3_PLP2.ToString())
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
			if (!string.IsNullOrWhiteSpace(m3_DPLG))
				request.WithQueryParameter("DPLG", m3_DPLG.Trim());
			if (m3_WLDE.HasValue)
				request.WithQueryParameter("WLDE", m3_WLDE.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_FCLA))
				request.WithQueryParameter("FCLA", m3_FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL2))
				request.WithQueryParameter("FCL2", m3_FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL3))
				request.WithQueryParameter("FCL3", m3_FCL3.Trim());
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (m3_SEPR.HasValue)
				request.WithQueryParameter("SEPR", m3_SEPR.Value.ToString());
			if (m3_PIPR.HasValue)
				request.WithQueryParameter("PIPR", m3_PIPR.Value.ToString());

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
		/// Description Change OEM for Operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLPN">Planned order (Required)</param>
		/// <param name="m3_PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3_PLP2">Subnumber - order proposal (Required)</param>
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
			int m3_PLPN, 
			int m3_PLPS, 
			int m3_PLP2, 
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

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString())
				.WithQueryParameter("PLPS", m3_PLPS.ToString())
				.WithQueryParameter("PLP2", m3_PLP2.ToString())
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
		/// Name ChgOpElement
		/// Description Cange Operation Elemet
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLPN">Planned order (Required)</param>
		/// <param name="m3_PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3_PLP2">Subnumber - order proposal (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_ACTS">Task element number (Required)</param>
		/// <param name="m3_ACTT">Operation element type (Required)</param>
		/// <param name="m3_ACTR">Work element</param>
		/// <param name="m3_TOOL">Tool number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="m3_DOID">Document identity</param>
		/// <param name="m3_INSI">Inspection identity</param>
		/// <param name="m3_ACDS">Description</param>
		/// <param name="m3_TXT1">Text line 1</param>
		/// <param name="m3_TXT2">Text line 2</param>
		/// <param name="m3_SETI">Setup time</param>
		/// <param name="m3_PITI">Run time</param>
		/// <param name="m3_SENP">Planned number of workers - setup</param>
		/// <param name="m3_PRNP">Planned number of workers - run time</param>
		/// <param name="m3_LASK">Labor skill</param>
		/// <param name="m3_INSK">Inspection skill</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_PERM">Permit</param>
		/// <param name="m3_TPRM">Permit type</param>
		/// <param name="m3_PRMA">Permit mandatory</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_CATY">Capability type</param>
		/// <param name="m3_TRQT">Transaction quantity - basic U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgOpElement(
			int m3_PLPN, 
			int m3_PLPS, 
			int m3_PLP2, 
			int m3_OPNO, 
			int m3_ACTS, 
			string m3_ACTT, 
			string m3_ACTR = null, 
			string m3_TOOL = null, 
			string m3_SERN = null, 
			string m3_EMNO = null, 
			string m3_DOID = null, 
			string m3_INSI = null, 
			string m3_ACDS = null, 
			string m3_TXT1 = null, 
			string m3_TXT2 = null, 
			int? m3_SETI = null, 
			int? m3_PITI = null, 
			int? m3_SENP = null, 
			int? m3_PRNP = null, 
			string m3_LASK = null, 
			string m3_INSK = null, 
			string m3_STAT = null, 
			string m3_PERM = null, 
			string m3_TPRM = null, 
			int? m3_PRMA = null, 
			decimal? m3_TXID = null, 
			string m3_CATY = null, 
			decimal? m3_TRQT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgOpElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ACTT))
				throw new ArgumentNullException("m3_ACTT");

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString())
				.WithQueryParameter("PLPS", m3_PLPS.ToString())
				.WithQueryParameter("PLP2", m3_PLP2.ToString())
				.WithQueryParameter("OPNO", m3_OPNO.ToString())
				.WithQueryParameter("ACTS", m3_ACTS.ToString())
				.WithQueryParameter("ACTT", m3_ACTT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ACTR))
				request.WithQueryParameter("ACTR", m3_ACTR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOOL))
				request.WithQueryParameter("TOOL", m3_TOOL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INSI))
				request.WithQueryParameter("INSI", m3_INSI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACDS))
				request.WithQueryParameter("ACDS", m3_ACDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT1))
				request.WithQueryParameter("TXT1", m3_TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT2))
				request.WithQueryParameter("TXT2", m3_TXT2.Trim());
			if (m3_SETI.HasValue)
				request.WithQueryParameter("SETI", m3_SETI.Value.ToString());
			if (m3_PITI.HasValue)
				request.WithQueryParameter("PITI", m3_PITI.Value.ToString());
			if (m3_SENP.HasValue)
				request.WithQueryParameter("SENP", m3_SENP.Value.ToString());
			if (m3_PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3_PRNP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LASK))
				request.WithQueryParameter("LASK", m3_LASK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INSK))
				request.WithQueryParameter("INSK", m3_INSK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PERM))
				request.WithQueryParameter("PERM", m3_PERM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TPRM))
				request.WithQueryParameter("TPRM", m3_TPRM.Trim());
			if (m3_PRMA.HasValue)
				request.WithQueryParameter("PRMA", m3_PRMA.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CATY))
				request.WithQueryParameter("CATY", m3_CATY.Trim());
			if (m3_TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3_TRQT.Value.ToString());

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
		/// Name ChgProp
		/// Description Change proposal
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLPN">Planned order (Required)</param>
		/// <param name="m3_PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3_PLP2">Subnumber - order proposal (Required)</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_RRSD">Requested start date</param>
		/// <param name="m3_RRST">Requested start time</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_MSTI">Start time</param>
		/// <param name="m3_FIDT">Finish date</param>
		/// <param name="m3_MFTI">Finish time</param>
		/// <param name="m3_RRFD">Requested finish date</param>
		/// <param name="m3_RRFT">Requested finish time</param>
		/// <param name="m3_PPQT">Planned quantity</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_PSTS">Status - planned MO</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_BANO">Lot Number</param>
		/// <param name="m3_PRIP">Priority</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_GRTI">Group technology class</param>
		/// <param name="m3_SCHN">Schedule number</param>
		/// <param name="m3_APRB">Approved by</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_RBAM">Request budget amount</param>
		/// <param name="m3_EVTY">Event type</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_CFI1">User-defined field 1 - item</param>
		/// <param name="m3_CFI2">User-defined field 2 - item</param>
		/// <param name="m3_CFI3">User-defined field 3 - item</param>
		/// <param name="m3_CFI4">User-defined field 4 - item</param>
		/// <param name="m3_CFI5">User-defined field 5 - item</param>
		/// <param name="m3_SPR1">Specific requirement category</param>
		/// <param name="m3_SPR2">Specific requirement category</param>
		/// <param name="m3_SPR3">Specific requirement category</param>
		/// <param name="m3_SPR4">Specific requirement category</param>
		/// <param name="m3_SPR5">Specific requirement category</param>
		/// <param name="m3_SPR6">Specific requirements</param>
		/// <param name="m3_SPR7">Specific requirements</param>
		/// <param name="m3_SPR8">Specific requirements</param>
		/// <param name="m3_SPR9">Specific requirements</param>
		/// <param name="m3_SPR0">Specific requirements</param>
		/// <param name="m3_TOFP">Process type</param>
		/// <param name="m3_SRGP">Service group</param>
		/// <param name="m3_NSTP">Shutdown</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_CLGP">Color group</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_SPRQ">Specific requirement category</param>
		/// <param name="m3_SPRT">Specific requirements</param>
		/// <param name="m3_EDWT">Estimated downtime</param>
		/// <param name="m3_SCHL">Scheduling logic</param>
		/// <param name="m3_RREQ">Requester</param>
		/// <param name="m3_ESBU">Estimated cost</param>
		/// <param name="m3_PLRD">Planner receipt date</param>
		/// <param name="m3_PLRT">Planner receipt time</param>
		/// <param name="m3_AAPD">Approval date</param>
		/// <param name="m3_AAPT">Approval time</param>
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
		/// <param name="m3_ADRR">Address file</param>
		/// <param name="m3_ADRT">Address type</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_FWSL">From location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgProp(
			int m3_PLPN, 
			int m3_PLPS, 
			int m3_PLP2, 
			string m3_SUFI = null, 
			DateTime? m3_RRSD = null, 
			int? m3_RRST = null, 
			DateTime? m3_STDT = null, 
			int? m3_MSTI = null, 
			DateTime? m3_FIDT = null, 
			int? m3_MFTI = null, 
			DateTime? m3_RRFD = null, 
			int? m3_RRFT = null, 
			decimal? m3_PPQT = null, 
			string m3_RESP = null, 
			string m3_PSTS = null, 
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			string m3_BANO = null, 
			string m3_PRIP = null, 
			string m3_PLGR = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_GRTI = null, 
			decimal? m3_SCHN = null, 
			string m3_APRB = null, 
			string m3_RSCD = null, 
			decimal? m3_RBAM = null, 
			string m3_EVTY = null, 
			string m3_TX40 = null, 
			string m3_CFI1 = null, 
			decimal? m3_CFI2 = null, 
			string m3_CFI3 = null, 
			string m3_CFI4 = null, 
			string m3_CFI5 = null, 
			string m3_SPR1 = null, 
			string m3_SPR2 = null, 
			string m3_SPR3 = null, 
			string m3_SPR4 = null, 
			string m3_SPR5 = null, 
			string m3_SPR6 = null, 
			string m3_SPR7 = null, 
			string m3_SPR8 = null, 
			string m3_SPR9 = null, 
			string m3_SPR0 = null, 
			string m3_TOFP = null, 
			string m3_SRGP = null, 
			int? m3_NSTP = null, 
			decimal? m3_TXID = null, 
			int? m3_CLGP = null, 
			decimal? m3_ATNR = null, 
			string m3_SPRQ = null, 
			string m3_SPRT = null, 
			int? m3_EDWT = null, 
			int? m3_SCHL = null, 
			string m3_RREQ = null, 
			decimal? m3_ESBU = null, 
			DateTime? m3_PLRD = null, 
			int? m3_PLRT = null, 
			DateTime? m3_AAPD = null, 
			int? m3_AAPT = null, 
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
			int? m3_ADRR = null, 
			int? m3_ADRT = null, 
			string m3_ADID = null, 
			string m3_FWSL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgProp",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString())
				.WithQueryParameter("PLPS", m3_PLPS.ToString())
				.WithQueryParameter("PLP2", m3_PLP2.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_RRSD.HasValue)
				request.WithQueryParameter("RRSD", m3_RRSD.Value.ToM3String());
			if (m3_RRST.HasValue)
				request.WithQueryParameter("RRST", m3_RRST.Value.ToString());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_MSTI.HasValue)
				request.WithQueryParameter("MSTI", m3_MSTI.Value.ToString());
			if (m3_FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3_FIDT.Value.ToM3String());
			if (m3_MFTI.HasValue)
				request.WithQueryParameter("MFTI", m3_MFTI.Value.ToString());
			if (m3_RRFD.HasValue)
				request.WithQueryParameter("RRFD", m3_RRFD.Value.ToM3String());
			if (m3_RRFT.HasValue)
				request.WithQueryParameter("RRFT", m3_RRFT.Value.ToString());
			if (m3_PPQT.HasValue)
				request.WithQueryParameter("PPQT", m3_PPQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PSTS))
				request.WithQueryParameter("PSTS", m3_PSTS.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRIP))
				request.WithQueryParameter("PRIP", m3_PRIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRTI))
				request.WithQueryParameter("GRTI", m3_GRTI.Trim());
			if (m3_SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3_SCHN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_APRB))
				request.WithQueryParameter("APRB", m3_APRB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (m3_RBAM.HasValue)
				request.WithQueryParameter("RBAM", m3_RBAM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EVTY))
				request.WithQueryParameter("EVTY", m3_EVTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_SPR1))
				request.WithQueryParameter("SPR1", m3_SPR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPR2))
				request.WithQueryParameter("SPR2", m3_SPR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPR3))
				request.WithQueryParameter("SPR3", m3_SPR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPR4))
				request.WithQueryParameter("SPR4", m3_SPR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPR5))
				request.WithQueryParameter("SPR5", m3_SPR5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPR6))
				request.WithQueryParameter("SPR6", m3_SPR6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPR7))
				request.WithQueryParameter("SPR7", m3_SPR7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPR8))
				request.WithQueryParameter("SPR8", m3_SPR8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPR9))
				request.WithQueryParameter("SPR9", m3_SPR9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPR0))
				request.WithQueryParameter("SPR0", m3_SPR0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOFP))
				request.WithQueryParameter("TOFP", m3_TOFP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRGP))
				request.WithQueryParameter("SRGP", m3_SRGP.Trim());
			if (m3_NSTP.HasValue)
				request.WithQueryParameter("NSTP", m3_NSTP.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_CLGP.HasValue)
				request.WithQueryParameter("CLGP", m3_CLGP.Value.ToString());
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPRQ))
				request.WithQueryParameter("SPRQ", m3_SPRQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPRT))
				request.WithQueryParameter("SPRT", m3_SPRT.Trim());
			if (m3_EDWT.HasValue)
				request.WithQueryParameter("EDWT", m3_EDWT.Value.ToString());
			if (m3_SCHL.HasValue)
				request.WithQueryParameter("SCHL", m3_SCHL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RREQ))
				request.WithQueryParameter("RREQ", m3_RREQ.Trim());
			if (m3_ESBU.HasValue)
				request.WithQueryParameter("ESBU", m3_ESBU.Value.ToString());
			if (m3_PLRD.HasValue)
				request.WithQueryParameter("PLRD", m3_PLRD.Value.ToM3String());
			if (m3_PLRT.HasValue)
				request.WithQueryParameter("PLRT", m3_PLRT.Value.ToString());
			if (m3_AAPD.HasValue)
				request.WithQueryParameter("AAPD", m3_AAPD.Value.ToM3String());
			if (m3_AAPT.HasValue)
				request.WithQueryParameter("AAPT", m3_AAPT.Value.ToString());
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
			if (m3_ADRR.HasValue)
				request.WithQueryParameter("ADRR", m3_ADRR.Value.ToString());
			if (m3_ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3_ADRT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FWSL))
				request.WithQueryParameter("FWSL", m3_FWSL.Trim());

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
		/// <param name="m3_PLPN">Planned order (Required)</param>
		/// <param name="m3_PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3_PLP2">Subnumber - order proposal (Required)</param>
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
			int m3_PLPN, 
			int m3_PLPS, 
			int m3_PLP2, 
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

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString())
				.WithQueryParameter("PLPS", m3_PLPS.ToString())
				.WithQueryParameter("PLP2", m3_PLP2.ToString())
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
		/// Name DelOp
		/// Description Del Operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLPN">Planned order (Required)</param>
		/// <param name="m3_PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3_PLP2">Subnumber - order proposal (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelOp(
			int m3_PLPN, 
			int m3_PLPS, 
			int m3_PLP2, 
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

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString())
				.WithQueryParameter("PLPS", m3_PLPS.ToString())
				.WithQueryParameter("PLP2", m3_PLP2.ToString())
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
		/// Name DelOpElement
		/// Description Delete Operation Elemet
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLPN">Planned order (Required)</param>
		/// <param name="m3_PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3_PLP2">Subnumber - order proposal (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_ACTS">Task element number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelOpElement(
			int m3_PLPN, 
			int m3_PLPS, 
			int m3_PLP2, 
			int m3_OPNO, 
			int m3_ACTS, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelOpElement",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString())
				.WithQueryParameter("PLPS", m3_PLPS.ToString())
				.WithQueryParameter("PLP2", m3_PLP2.ToString())
				.WithQueryParameter("OPNO", m3_OPNO.ToString())
				.WithQueryParameter("ACTS", m3_ACTS.ToString());

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
		/// Name DelProp
		/// Description Delete proposal
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLPN">Planned order (Required)</param>
		/// <param name="m3_PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3_PLP2">Subnumber - order proposal (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelProp(
			int m3_PLPN, 
			int m3_PLPS, 
			int m3_PLP2, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelProp",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString())
				.WithQueryParameter("PLPS", m3_PLPS.ToString())
				.WithQueryParameter("PLP2", m3_PLP2.ToString());

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
		/// Name DenyProp
		/// Description Reject/Deny Proposal
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLPN">Planned order</param>
		/// <param name="m3_PLPS">Subnumber - planned order</param>
		/// <param name="m3_PLP2">Subnumber - order proposal</param>
		/// <param name="m3_REJD">Rejection date</param>
		/// <param name="m3_REJT">Rejection time</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DenyProp(
			int? m3_PLPN = null, 
			int? m3_PLPS = null, 
			int? m3_PLP2 = null, 
			DateTime? m3_REJD = null, 
			int? m3_REJT = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DenyProp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_PLPN.HasValue)
				request.WithQueryParameter("PLPN", m3_PLPN.Value.ToString());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());
			if (m3_PLP2.HasValue)
				request.WithQueryParameter("PLP2", m3_PLP2.Value.ToString());
			if (m3_REJD.HasValue)
				request.WithQueryParameter("REJD", m3_REJD.Value.ToM3String());
			if (m3_REJT.HasValue)
				request.WithQueryParameter("REJT", m3_REJT.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
		/// Name GetMtrl
		/// Description Get Material
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PLPN">Planned order (Required)</param>
		/// <param name="m3_PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3_PLP2">Subnumber - order proposal (Required)</param>
		/// <param name="m3_MSEQ">Sequence number (Required)</param>
		/// <param name="m3_RCOS">Retrive estimated cost</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMtrlResponse></returns>
		/// <exception cref="M3Exception<GetMtrlResponse>"></exception>
		public async Task<M3Response<GetMtrlResponse>> GetMtrl(
			int m3_PLPN, 
			int m3_PLPS, 
			int m3_PLP2, 
			int m3_MSEQ, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMtrl",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString())
				.WithQueryParameter("PLPS", m3_PLPS.ToString())
				.WithQueryParameter("PLP2", m3_PLP2.ToString())
				.WithQueryParameter("MSEQ", m3_MSEQ.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RCOS.HasValue)
				request.WithQueryParameter("RCOS", m3_RCOS.Value.ToString());

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
		/// Name GetOp
		/// Description Get Operation
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PLPN">Planned order (Required)</param>
		/// <param name="m3_PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3_PLP2">Subnumber - order proposal (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_RCOS">Retrive estimated cost</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOpResponse></returns>
		/// <exception cref="M3Exception<GetOpResponse>"></exception>
		public async Task<M3Response<GetOpResponse>> GetOp(
			int m3_PLPN, 
			int m3_PLPS, 
			int m3_PLP2, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetOp",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString())
				.WithQueryParameter("PLPS", m3_PLPS.ToString())
				.WithQueryParameter("PLP2", m3_PLP2.ToString())
				.WithQueryParameter("OPNO", m3_OPNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RCOS.HasValue)
				request.WithQueryParameter("RCOS", m3_RCOS.Value.ToString());

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
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLPN">Planned order (Required)</param>
		/// <param name="m3_PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3_PLP2">Subnumber - order proposal (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOp2Response></returns>
		/// <exception cref="M3Exception<GetOp2Response>"></exception>
		public async Task<M3Response<GetOp2Response>> GetOp2(
			int m3_PLPN, 
			int m3_PLPS, 
			int m3_PLP2, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetOp2",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString())
				.WithQueryParameter("PLPS", m3_PLPS.ToString())
				.WithQueryParameter("PLP2", m3_PLP2.ToString())
				.WithQueryParameter("OPNO", m3_OPNO.ToString());

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
		/// Name GetOpElement
		/// Description Get Operation Elemet
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLPN">Planned order (Required)</param>
		/// <param name="m3_PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3_PLP2">Subnumber - order proposal (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_ACTS">Task element number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOpElementResponse></returns>
		/// <exception cref="M3Exception<GetOpElementResponse>"></exception>
		public async Task<M3Response<GetOpElementResponse>> GetOpElement(
			int m3_PLPN, 
			int m3_PLPS, 
			int m3_PLP2, 
			int m3_OPNO, 
			int m3_ACTS, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetOpElement",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString())
				.WithQueryParameter("PLPS", m3_PLPS.ToString())
				.WithQueryParameter("PLP2", m3_PLP2.ToString())
				.WithQueryParameter("OPNO", m3_OPNO.ToString())
				.WithQueryParameter("ACTS", m3_ACTS.ToString());

			// Execute the request
			var result = await Execute<GetOpElementResponse>(
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
		/// Name GetProp
		/// Description Get Proposal
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PLPN">Planned order (Required)</param>
		/// <param name="m3_PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3_PLP2">Subnumber - order proposal (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPropResponse></returns>
		/// <exception cref="M3Exception<GetPropResponse>"></exception>
		public async Task<M3Response<GetPropResponse>> GetProp(
			int m3_PLPN, 
			int m3_PLPS, 
			int m3_PLP2, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetProp",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString())
				.WithQueryParameter("PLPS", m3_PLPS.ToString())
				.WithQueryParameter("PLP2", m3_PLP2.ToString());

			// Execute the request
			var result = await Execute<GetPropResponse>(
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
		/// Name RelProp
		/// Description Release proposal
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLPN">ProposalNumber (Required)</param>
		/// <param name="m3_PLPS">ProposalSubnumber (Required)</param>
		/// <param name="m3_PLP2">ProposalSubnumber (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RelProp(
			int m3_PLPN, 
			int m3_PLPS, 
			int m3_PLP2, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RelProp",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString())
				.WithQueryParameter("PLPS", m3_PLPS.ToString())
				.WithQueryParameter("PLP2", m3_PLP2.ToString());

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
		/// Name RelWorkScope
		/// Description Release Work Scope
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RORC">Reference order category (Required)</param>
		/// <param name="m3_RORN">Reference order number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RelWorkScope(
			int m3_RORC, 
			string m3_RORN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RelWorkScope",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RORN))
				throw new ArgumentNullException("m3_RORN");

			// Set mandatory parameters
			request
				.WithQueryParameter("RORC", m3_RORC.ToString())
				.WithQueryParameter("RORN", m3_RORN.Trim());

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
		/// Name Search
		/// Description Search
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_SQRY">Search query</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchResponse></returns>
		/// <exception cref="M3Exception<SearchResponse>"></exception>
		public async Task<M3Response<SearchResponse>> Search(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Search",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SQRY))
				request.WithQueryParameter("SQRY", m3_SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchResponse>(
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
