/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddMtrl
		/// Description Add Material
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PLPN">Planned order (Required)</param>
		/// <param name="m3PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3PLP2">Subnumber - order proposal (Required)</param>
		/// <param name="m3MTNO">Component number (Required)</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3DWPO">Drawing position</param>
		/// <param name="m3STGS">Subcontract control</param>
		/// <param name="m3FMT1">Text</param>
		/// <param name="m3FMT2">Technical reference</param>
		/// <param name="m3CNQT">Quantity</param>
		/// <param name="m3LGTH">Length</param>
		/// <param name="m3WDTH">Width</param>
		/// <param name="m3LWF1">Factor 1</param>
		/// <param name="m3LWF2">Factor 2</param>
		/// <param name="m3VAPC">Option percentage</param>
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
		/// <param name="m3SPMT">Issue method</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3PEUN">Product engineering U/M</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3EXCH">Exchange</param>
		/// <param name="m3ADRR">Address file</param>
		/// <param name="m3ADRT">Address type</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3IORN">Interface order number</param>
		/// <param name="m3IORL">Interface order line</param>
		/// <param name="m3IOSX">Interface line suffix</param>
		/// <param name="m3OT53">Abnormal demand</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddMtrl(
			int m3PLPN, 
			int m3PLPS, 
			int m3PLP2, 
			string m3MTNO, 
			int? m3OPNO = null, 
			int? m3MSEQ = null, 
			string m3DWPO = null, 
			int? m3STGS = null, 
			string m3FMT1 = null, 
			string m3FMT2 = null, 
			decimal? m3CNQT = null, 
			int? m3LGTH = null, 
			int? m3WDTH = null, 
			decimal? m3LWF1 = null, 
			decimal? m3LWF2 = null, 
			int? m3VAPC = null, 
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
			int? m3SPMT = null, 
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			decimal? m3ATNR = null, 
			string m3PEUN = null, 
			decimal? m3TXID = null, 
			int? m3EXCH = null, 
			int? m3ADRR = null, 
			int? m3ADRT = null, 
			string m3ADID = null, 
			string m3IORN = null, 
			int? m3IORL = null, 
			int? m3IOSX = null, 
			int? m3OT53 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddMtrl",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MTNO))
				throw new ArgumentNullException(nameof(m3MTNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLPS", m3PLPS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLP2", m3PLP2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("MTNO", m3MTNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DWPO))
				request.WithQueryParameter("DWPO", m3DWPO.Trim());
			if (m3STGS.HasValue)
				request.WithQueryParameter("STGS", m3STGS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FMT1))
				request.WithQueryParameter("FMT1", m3FMT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMT2))
				request.WithQueryParameter("FMT2", m3FMT2.Trim());
			if (m3CNQT.HasValue)
				request.WithQueryParameter("CNQT", m3CNQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LGTH.HasValue)
				request.WithQueryParameter("LGTH", m3LGTH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WDTH.HasValue)
				request.WithQueryParameter("WDTH", m3WDTH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LWF1.HasValue)
				request.WithQueryParameter("LWF1", m3LWF1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LWF2.HasValue)
				request.WithQueryParameter("LWF2", m3LWF2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VAPC.HasValue)
				request.WithQueryParameter("VAPC", m3VAPC.Value.ToString(CultureInfo.CurrentCulture));
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
			if (m3SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3SPMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PEUN))
				request.WithQueryParameter("PEUN", m3PEUN.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXCH.HasValue)
				request.WithQueryParameter("EXCH", m3EXCH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADRR.HasValue)
				request.WithQueryParameter("ADRR", m3ADRR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3ADRT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3IORN))
				request.WithQueryParameter("IORN", m3IORN.Trim());
			if (m3IORL.HasValue)
				request.WithQueryParameter("IORL", m3IORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IOSX.HasValue)
				request.WithQueryParameter("IOSX", m3IOSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OT53.HasValue)
				request.WithQueryParameter("OT53", m3OT53.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddOp
		/// Description Add Operation
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PLPN">Planned order (Required)</param>
		/// <param name="m3PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3PLP2">Subnumber - order proposal (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3PLGR">Work center (Required)</param>
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
		/// <param name="m3DPLG">Deviating work center</param>
		/// <param name="m3WLDE">Infinite/finite</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3EQNO">Equipment number</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3SPRQ">Specific requirement category</param>
		/// <param name="m3SPRT">Specific requirements</param>
		/// <param name="m3FCLA">Error code 1</param>
		/// <param name="m3FCL2">Error code 2</param>
		/// <param name="m3FCL3">Error code 3</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3SEPR">Setup price</param>
		/// <param name="m3PIPR">Unit price</param>
		/// <param name="m3IORN">Interface order number</param>
		/// <param name="m3IORL">Interface order line</param>
		/// <param name="m3IOSX">Interface line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddOp(
			int m3PLPN, 
			int m3PLPS, 
			int m3PLP2, 
			int m3OPNO, 
			string m3PLGR, 
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
			string m3DPLG = null, 
			int? m3WLDE = null, 
			decimal? m3TXID = null, 
			string m3CFGL = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3EQNO = null, 
			string m3SUFI = null, 
			string m3SPRQ = null, 
			string m3SPRT = null, 
			string m3FCLA = null, 
			string m3FCL2 = null, 
			string m3FCL3 = null, 
			decimal? m3ATNR = null, 
			decimal? m3SEPR = null, 
			decimal? m3PIPR = null, 
			string m3IORN = null, 
			int? m3IORL = null, 
			int? m3IOSX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddOp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PLGR))
				throw new ArgumentNullException(nameof(m3PLGR));

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLPS", m3PLPS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLP2", m3PLP2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLGR", m3PLGR.Trim());

			// Set optional parameters, checking for null/blank data for each element
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
			if (!string.IsNullOrWhiteSpace(m3DPLG))
				request.WithQueryParameter("DPLG", m3DPLG.Trim());
			if (m3WLDE.HasValue)
				request.WithQueryParameter("WLDE", m3WLDE.Value.ToString(CultureInfo.CurrentCulture));
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
			if (!string.IsNullOrWhiteSpace(m3FCLA))
				request.WithQueryParameter("FCLA", m3FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL2))
				request.WithQueryParameter("FCL2", m3FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL3))
				request.WithQueryParameter("FCL3", m3FCL3.Trim());
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SEPR.HasValue)
				request.WithQueryParameter("SEPR", m3SEPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PIPR.HasValue)
				request.WithQueryParameter("PIPR", m3PIPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3IORN))
				request.WithQueryParameter("IORN", m3IORN.Trim());
			if (m3IORL.HasValue)
				request.WithQueryParameter("IORL", m3IORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IOSX.HasValue)
				request.WithQueryParameter("IOSX", m3IOSX.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddOp2
		/// Description Add OEM for Operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PLPN">Planned order (Required)</param>
		/// <param name="m3PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3PLP2">Subnumber - order proposal (Required)</param>
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
			int m3PLPN, 
			int m3PLPS, 
			int m3PLP2, 
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddOp2",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLPS", m3PLPS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLP2", m3PLP2.ToString(CultureInfo.CurrentCulture))
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
		/// Name AddOpElement
		/// Description Add Operation Elemet
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PLPN">Planned order (Required)</param>
		/// <param name="m3PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3PLP2">Subnumber - order proposal (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3ACTS">Task element number (Required)</param>
		/// <param name="m3ACTT">Operation element type (Required)</param>
		/// <param name="m3ACTR">Work element</param>
		/// <param name="m3TOOL">Tool number</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3DOID">Document identity</param>
		/// <param name="m3INSI">Inspection identity</param>
		/// <param name="m3ACDS">Description</param>
		/// <param name="m3TXT1">Text line 1</param>
		/// <param name="m3TXT2">Text line 2</param>
		/// <param name="m3SETI">Setup time</param>
		/// <param name="m3PITI">Run time</param>
		/// <param name="m3SENP">Planned number of workers - setup</param>
		/// <param name="m3PRNP">Planned number of workers - run time</param>
		/// <param name="m3LASK">Labor skill</param>
		/// <param name="m3INSK">Inspection skill</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3PERM">Permit</param>
		/// <param name="m3TPRM">Permit type</param>
		/// <param name="m3PRMA">Permit mandatory</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3CATY">Capability type</param>
		/// <param name="m3TRQT">Transaction quantity - basic U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddOpElement(
			int m3PLPN, 
			int m3PLPS, 
			int m3PLP2, 
			int m3OPNO, 
			int m3ACTS, 
			string m3ACTT, 
			string m3ACTR = null, 
			string m3TOOL = null, 
			string m3SERN = null, 
			string m3EMNO = null, 
			string m3DOID = null, 
			string m3INSI = null, 
			string m3ACDS = null, 
			string m3TXT1 = null, 
			string m3TXT2 = null, 
			int? m3SETI = null, 
			int? m3PITI = null, 
			int? m3SENP = null, 
			int? m3PRNP = null, 
			string m3LASK = null, 
			string m3INSK = null, 
			string m3STAT = null, 
			string m3PERM = null, 
			string m3TPRM = null, 
			int? m3PRMA = null, 
			decimal? m3TXID = null, 
			string m3CATY = null, 
			decimal? m3TRQT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddOpElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ACTT))
				throw new ArgumentNullException(nameof(m3ACTT));

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLPS", m3PLPS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLP2", m3PLP2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACTS", m3ACTS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACTT", m3ACTT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ACTR))
				request.WithQueryParameter("ACTR", m3ACTR.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOOL))
				request.WithQueryParameter("TOOL", m3TOOL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3INSI))
				request.WithQueryParameter("INSI", m3INSI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACDS))
				request.WithQueryParameter("ACDS", m3ACDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT1))
				request.WithQueryParameter("TXT1", m3TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT2))
				request.WithQueryParameter("TXT2", m3TXT2.Trim());
			if (m3SETI.HasValue)
				request.WithQueryParameter("SETI", m3SETI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PITI.HasValue)
				request.WithQueryParameter("PITI", m3PITI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SENP.HasValue)
				request.WithQueryParameter("SENP", m3SENP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3PRNP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LASK))
				request.WithQueryParameter("LASK", m3LASK.Trim());
			if (!string.IsNullOrWhiteSpace(m3INSK))
				request.WithQueryParameter("INSK", m3INSK.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PERM))
				request.WithQueryParameter("PERM", m3PERM.Trim());
			if (!string.IsNullOrWhiteSpace(m3TPRM))
				request.WithQueryParameter("TPRM", m3TPRM.Trim());
			if (m3PRMA.HasValue)
				request.WithQueryParameter("PRMA", m3PRMA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CATY))
				request.WithQueryParameter("CATY", m3CATY.Trim());
			if (m3TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3TRQT.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddProp
		/// Description Add proposal
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TAIL">TailNumber</param>
		/// <param name="m3CFGL">ConfigPosition</param>
		/// <param name="m3EQNO">Equipment</param>
		/// <param name="m3STRT">Structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3PLGR">PlanningGroup</param>
		/// <param name="m3PRIP">Priority</param>
		/// <param name="m3APRB">ApprovedBy</param>
		/// <param name="m3RSCD">ReasonCode</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3FIDT">Finish date</param>
		/// <param name="m3TXT1">Text line 1</param>
		/// <param name="m3TXT2">Text line 2</param>
		/// <param name="m3FCLA">Error code 1</param>
		/// <param name="m3FCL2">Error code 2</param>
		/// <param name="m3FCL3">Error code 3</param>
		/// <param name="m3CTPE">Complaint type</param>
		/// <param name="m3RTRO">REtro order</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3PPQT">Planned quantity</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3TXID">Text Identity</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3ESBU">Estimated cost</param>
		/// <param name="m3RREQ">Requester</param>
		/// <param name="m3RBAM">Request budget amount</param>
		/// <param name="m3RRSD">Requested start date</param>
		/// <param name="m3RRST">Requested start time</param>
		/// <param name="m3RRFD">Requested finish date</param>
		/// <param name="m3RRFT">Requested finish time</param>
		/// <param name="m3EDWT">Estimated downtime</param>
		/// <param name="m3SCHL">Scheduling logic</param>
		/// <param name="m3DEID">Complaint</param>
		/// <param name="m3AECN">Engineering order number</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3EMNO">Employee number</param>
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
		/// <param name="m3ADRR">Address file</param>
		/// <param name="m3ADRT">Address type</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3FWSL">From location</param>
		/// <param name="m3IORN">Interface order number</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3AAGN">Agreement</param>
		/// <param name="m3AOTY">Order type</param>
		/// <param name="m3CUOR">Customer´s order number</param>
		/// <param name="m3CUPO">Order line number</param>
		/// <param name="m3CUSX">Line suffix</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3MSTI">Start time</param>
		/// <param name="m3MFTI">Finish time</param>
		/// <param name="m3BRDT">Breakdown date</param>
		/// <param name="m3BRTI">Break down time</param>
		/// <param name="m3WATP">Warranty type</param>
		/// <param name="m3GWAR">Generic warranty</param>
		/// <param name="m3PITI">Run time</param>
		/// <param name="m3CFI1">User-defined field 1 - item</param>
		/// <param name="m3CFI2">User-defined field 2 - item</param>
		/// <param name="m3CFI3">User-defined field 3 - item</param>
		/// <param name="m3CFI4">User-defined field 4 - item</param>
		/// <param name="m3CFI5">User-defined field 5 - item</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3EVTY">Event type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPropResponse></returns>
		/// <exception cref="M3Exception<AddPropResponse>"></exception>
		public async Task<M3Response<AddPropResponse>> AddProp(
			int? m3CONO = null, 
			string m3TAIL = null, 
			string m3CFGL = null, 
			string m3EQNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			string m3RESP = null, 
			string m3TX40 = null, 
			string m3PLGR = null, 
			string m3PRIP = null, 
			string m3APRB = null, 
			string m3RSCD = null, 
			DateTime? m3STDT = null, 
			DateTime? m3FIDT = null, 
			string m3TXT1 = null, 
			string m3TXT2 = null, 
			string m3FCLA = null, 
			string m3FCL2 = null, 
			string m3FCL3 = null, 
			string m3CTPE = null, 
			int? m3RTRO = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			decimal? m3PPQT = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
			decimal? m3TXID = null, 
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			decimal? m3ESBU = null, 
			string m3RREQ = null, 
			decimal? m3RBAM = null, 
			DateTime? m3RRSD = null, 
			int? m3RRST = null, 
			DateTime? m3RRFD = null, 
			int? m3RRFT = null, 
			int? m3EDWT = null, 
			int? m3SCHL = null, 
			int? m3DEID = null, 
			string m3AECN = null, 
			string m3ORTY = null, 
			string m3EMNO = null, 
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
			int? m3ADRR = null, 
			int? m3ADRT = null, 
			string m3ADID = null, 
			string m3FWSL = null, 
			string m3IORN = null, 
			string m3CUNO = null, 
			string m3AAGN = null, 
			string m3AOTY = null, 
			string m3CUOR = null, 
			int? m3CUPO = null, 
			int? m3CUSX = null, 
			string m3YREF = null, 
			int? m3MSTI = null, 
			int? m3MFTI = null, 
			DateTime? m3BRDT = null, 
			int? m3BRTI = null, 
			string m3WATP = null, 
			int? m3GWAR = null, 
			int? m3PITI = null, 
			string m3CFI1 = null, 
			decimal? m3CFI2 = null, 
			string m3CFI3 = null, 
			string m3CFI4 = null, 
			string m3CFI5 = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3EVTY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddProp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TAIL))
				request.WithQueryParameter("TAIL", m3TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQNO))
				request.WithQueryParameter("EQNO", m3EQNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRIP))
				request.WithQueryParameter("PRIP", m3PRIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3APRB))
				request.WithQueryParameter("APRB", m3APRB.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3FIDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TXT1))
				request.WithQueryParameter("TXT1", m3TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT2))
				request.WithQueryParameter("TXT2", m3TXT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCLA))
				request.WithQueryParameter("FCLA", m3FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL2))
				request.WithQueryParameter("FCL2", m3FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL3))
				request.WithQueryParameter("FCL3", m3FCL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTPE))
				request.WithQueryParameter("CTPE", m3CTPE.Trim());
			if (m3RTRO.HasValue)
				request.WithQueryParameter("RTRO", m3RTRO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3PPQT.HasValue)
				request.WithQueryParameter("PPQT", m3PPQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ESBU.HasValue)
				request.WithQueryParameter("ESBU", m3ESBU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RREQ))
				request.WithQueryParameter("RREQ", m3RREQ.Trim());
			if (m3RBAM.HasValue)
				request.WithQueryParameter("RBAM", m3RBAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RRSD.HasValue)
				request.WithQueryParameter("RRSD", m3RRSD.Value.ToM3String());
			if (m3RRST.HasValue)
				request.WithQueryParameter("RRST", m3RRST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RRFD.HasValue)
				request.WithQueryParameter("RRFD", m3RRFD.Value.ToM3String());
			if (m3RRFT.HasValue)
				request.WithQueryParameter("RRFT", m3RRFT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EDWT.HasValue)
				request.WithQueryParameter("EDWT", m3EDWT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHL.HasValue)
				request.WithQueryParameter("SCHL", m3SCHL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DEID.HasValue)
				request.WithQueryParameter("DEID", m3DEID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AECN))
				request.WithQueryParameter("AECN", m3AECN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
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
			if (m3ADRR.HasValue)
				request.WithQueryParameter("ADRR", m3ADRR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3ADRT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3FWSL))
				request.WithQueryParameter("FWSL", m3FWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3IORN))
				request.WithQueryParameter("IORN", m3IORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AAGN))
				request.WithQueryParameter("AAGN", m3AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3AOTY))
				request.WithQueryParameter("AOTY", m3AOTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (m3CUPO.HasValue)
				request.WithQueryParameter("CUPO", m3CUPO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CUSX.HasValue)
				request.WithQueryParameter("CUSX", m3CUSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (m3MSTI.HasValue)
				request.WithQueryParameter("MSTI", m3MSTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MFTI.HasValue)
				request.WithQueryParameter("MFTI", m3MFTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BRDT.HasValue)
				request.WithQueryParameter("BRDT", m3BRDT.Value.ToM3String());
			if (m3BRTI.HasValue)
				request.WithQueryParameter("BRTI", m3BRTI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WATP))
				request.WithQueryParameter("WATP", m3WATP.Trim());
			if (m3GWAR.HasValue)
				request.WithQueryParameter("GWAR", m3GWAR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PITI.HasValue)
				request.WithQueryParameter("PITI", m3PITI.Value.ToString(CultureInfo.CurrentCulture));
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
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVTY))
				request.WithQueryParameter("EVTY", m3EVTY.Trim());

			// Execute the request
			var result = await Execute<AddPropResponse>(
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
		/// Description Change Material
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PLPN">Planned order (Required)</param>
		/// <param name="m3PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3PLP2">Subnumber - order proposal (Required)</param>
		/// <param name="m3MSEQ">Sequence number (Required)</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3DWPO">Drawing position</param>
		/// <param name="m3STGS">Subcontract control</param>
		/// <param name="m3MTNO">Component number</param>
		/// <param name="m3FMT1">Text</param>
		/// <param name="m3FMT2">Technical reference</param>
		/// <param name="m3CNQT">Quantity</param>
		/// <param name="m3LGTH">Length</param>
		/// <param name="m3WDTH">Width</param>
		/// <param name="m3LWF1">Factor 1</param>
		/// <param name="m3LWF2">Factor 2</param>
		/// <param name="m3VAPC">Option percentage</param>
		/// <param name="m3RDAT">Reservation date</param>
		/// <param name="m3TIHM">Time hours & minutes</param>
		/// <param name="m3MDBF">Lead time offset</param>
		/// <param name="m3MPRC">Component price</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3PRDY">Production days</param>
		/// <param name="m3SPMT">Issue method</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3PEUN">Product engineering U/M</param>
		/// <param name="m3ADRR">Address file</param>
		/// <param name="m3ADRT">Address type</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3OT53">Abnormal demand</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgMtrl(
			int m3PLPN, 
			int m3PLPS, 
			int m3PLP2, 
			int m3MSEQ, 
			int? m3OPNO = null, 
			string m3DWPO = null, 
			int? m3STGS = null, 
			string m3MTNO = null, 
			string m3FMT1 = null, 
			string m3FMT2 = null, 
			decimal? m3CNQT = null, 
			int? m3LGTH = null, 
			int? m3WDTH = null, 
			decimal? m3LWF1 = null, 
			decimal? m3LWF2 = null, 
			int? m3VAPC = null, 
			DateTime? m3RDAT = null, 
			int? m3TIHM = null, 
			int? m3MDBF = null, 
			decimal? m3MPRC = null, 
			string m3WHSL = null, 
			string m3TWSL = null, 
			string m3BANO = null, 
			string m3SUNO = null, 
			int? m3PRDY = null, 
			int? m3SPMT = null, 
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			decimal? m3ATNR = null, 
			decimal? m3TXID = null, 
			string m3PEUN = null, 
			int? m3ADRR = null, 
			int? m3ADRT = null, 
			string m3ADID = null, 
			int? m3OT53 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgMtrl",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLPS", m3PLPS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLP2", m3PLP2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("MSEQ", m3MSEQ.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DWPO))
				request.WithQueryParameter("DWPO", m3DWPO.Trim());
			if (m3STGS.HasValue)
				request.WithQueryParameter("STGS", m3STGS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MTNO))
				request.WithQueryParameter("MTNO", m3MTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMT1))
				request.WithQueryParameter("FMT1", m3FMT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMT2))
				request.WithQueryParameter("FMT2", m3FMT2.Trim());
			if (m3CNQT.HasValue)
				request.WithQueryParameter("CNQT", m3CNQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LGTH.HasValue)
				request.WithQueryParameter("LGTH", m3LGTH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WDTH.HasValue)
				request.WithQueryParameter("WDTH", m3WDTH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LWF1.HasValue)
				request.WithQueryParameter("LWF1", m3LWF1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LWF2.HasValue)
				request.WithQueryParameter("LWF2", m3LWF2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VAPC.HasValue)
				request.WithQueryParameter("VAPC", m3VAPC.Value.ToString(CultureInfo.CurrentCulture));
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
			if (m3SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3SPMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PEUN))
				request.WithQueryParameter("PEUN", m3PEUN.Trim());
			if (m3ADRR.HasValue)
				request.WithQueryParameter("ADRR", m3ADRR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3ADRT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (m3OT53.HasValue)
				request.WithQueryParameter("OT53", m3OT53.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Description Change Operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PLPN">Planned order (Required)</param>
		/// <param name="m3PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3PLP2">Subnumber - order proposal (Required)</param>
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
		/// <param name="m3DPLG">Deviating work center</param>
		/// <param name="m3WLDE">Infinite/finite</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3EQNO">Equipment number</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3SPRQ">Specific requirement category</param>
		/// <param name="m3SPRT">Specific requirements</param>
		/// <param name="m3FCLA">Error code 1</param>
		/// <param name="m3FCL2">Error code 2</param>
		/// <param name="m3FCL3">Error code 3</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3SEPR">Setup price</param>
		/// <param name="m3PIPR">Unit price</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgOp(
			int m3PLPN, 
			int m3PLPS, 
			int m3PLP2, 
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
			string m3DPLG = null, 
			int? m3WLDE = null, 
			decimal? m3TXID = null, 
			string m3CFGL = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3EQNO = null, 
			string m3SUFI = null, 
			string m3SPRQ = null, 
			string m3SPRT = null, 
			string m3FCLA = null, 
			string m3FCL2 = null, 
			string m3FCL3 = null, 
			decimal? m3ATNR = null, 
			decimal? m3SEPR = null, 
			decimal? m3PIPR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgOp",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLPS", m3PLPS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLP2", m3PLP2.ToString(CultureInfo.CurrentCulture))
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
			if (!string.IsNullOrWhiteSpace(m3DPLG))
				request.WithQueryParameter("DPLG", m3DPLG.Trim());
			if (m3WLDE.HasValue)
				request.WithQueryParameter("WLDE", m3WLDE.Value.ToString(CultureInfo.CurrentCulture));
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
			if (!string.IsNullOrWhiteSpace(m3FCLA))
				request.WithQueryParameter("FCLA", m3FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL2))
				request.WithQueryParameter("FCL2", m3FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL3))
				request.WithQueryParameter("FCL3", m3FCL3.Trim());
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SEPR.HasValue)
				request.WithQueryParameter("SEPR", m3SEPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PIPR.HasValue)
				request.WithQueryParameter("PIPR", m3PIPR.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Description Change OEM for Operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PLPN">Planned order (Required)</param>
		/// <param name="m3PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3PLP2">Subnumber - order proposal (Required)</param>
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
			int m3PLPN, 
			int m3PLPS, 
			int m3PLP2, 
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgOp2",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLPS", m3PLPS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLP2", m3PLP2.ToString(CultureInfo.CurrentCulture))
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
		/// Name ChgOpElement
		/// Description Cange Operation Elemet
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PLPN">Planned order (Required)</param>
		/// <param name="m3PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3PLP2">Subnumber - order proposal (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3ACTS">Task element number (Required)</param>
		/// <param name="m3ACTT">Operation element type (Required)</param>
		/// <param name="m3ACTR">Work element</param>
		/// <param name="m3TOOL">Tool number</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3DOID">Document identity</param>
		/// <param name="m3INSI">Inspection identity</param>
		/// <param name="m3ACDS">Description</param>
		/// <param name="m3TXT1">Text line 1</param>
		/// <param name="m3TXT2">Text line 2</param>
		/// <param name="m3SETI">Setup time</param>
		/// <param name="m3PITI">Run time</param>
		/// <param name="m3SENP">Planned number of workers - setup</param>
		/// <param name="m3PRNP">Planned number of workers - run time</param>
		/// <param name="m3LASK">Labor skill</param>
		/// <param name="m3INSK">Inspection skill</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3PERM">Permit</param>
		/// <param name="m3TPRM">Permit type</param>
		/// <param name="m3PRMA">Permit mandatory</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3CATY">Capability type</param>
		/// <param name="m3TRQT">Transaction quantity - basic U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgOpElement(
			int m3PLPN, 
			int m3PLPS, 
			int m3PLP2, 
			int m3OPNO, 
			int m3ACTS, 
			string m3ACTT, 
			string m3ACTR = null, 
			string m3TOOL = null, 
			string m3SERN = null, 
			string m3EMNO = null, 
			string m3DOID = null, 
			string m3INSI = null, 
			string m3ACDS = null, 
			string m3TXT1 = null, 
			string m3TXT2 = null, 
			int? m3SETI = null, 
			int? m3PITI = null, 
			int? m3SENP = null, 
			int? m3PRNP = null, 
			string m3LASK = null, 
			string m3INSK = null, 
			string m3STAT = null, 
			string m3PERM = null, 
			string m3TPRM = null, 
			int? m3PRMA = null, 
			decimal? m3TXID = null, 
			string m3CATY = null, 
			decimal? m3TRQT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgOpElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ACTT))
				throw new ArgumentNullException(nameof(m3ACTT));

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLPS", m3PLPS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLP2", m3PLP2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACTS", m3ACTS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACTT", m3ACTT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ACTR))
				request.WithQueryParameter("ACTR", m3ACTR.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOOL))
				request.WithQueryParameter("TOOL", m3TOOL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3INSI))
				request.WithQueryParameter("INSI", m3INSI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACDS))
				request.WithQueryParameter("ACDS", m3ACDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT1))
				request.WithQueryParameter("TXT1", m3TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT2))
				request.WithQueryParameter("TXT2", m3TXT2.Trim());
			if (m3SETI.HasValue)
				request.WithQueryParameter("SETI", m3SETI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PITI.HasValue)
				request.WithQueryParameter("PITI", m3PITI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SENP.HasValue)
				request.WithQueryParameter("SENP", m3SENP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3PRNP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LASK))
				request.WithQueryParameter("LASK", m3LASK.Trim());
			if (!string.IsNullOrWhiteSpace(m3INSK))
				request.WithQueryParameter("INSK", m3INSK.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PERM))
				request.WithQueryParameter("PERM", m3PERM.Trim());
			if (!string.IsNullOrWhiteSpace(m3TPRM))
				request.WithQueryParameter("TPRM", m3TPRM.Trim());
			if (m3PRMA.HasValue)
				request.WithQueryParameter("PRMA", m3PRMA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CATY))
				request.WithQueryParameter("CATY", m3CATY.Trim());
			if (m3TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3TRQT.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgProp
		/// Description Change proposal
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PLPN">Planned order (Required)</param>
		/// <param name="m3PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3PLP2">Subnumber - order proposal (Required)</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3RRSD">Requested start date</param>
		/// <param name="m3RRST">Requested start time</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3MSTI">Start time</param>
		/// <param name="m3FIDT">Finish date</param>
		/// <param name="m3MFTI">Finish time</param>
		/// <param name="m3RRFD">Requested finish date</param>
		/// <param name="m3RRFT">Requested finish time</param>
		/// <param name="m3PPQT">Planned quantity</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3PSTS">Status - planned MO</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3BANO">Lot Number</param>
		/// <param name="m3PRIP">Priority</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3GRTI">Group technology class</param>
		/// <param name="m3SCHN">Schedule number</param>
		/// <param name="m3APRB">Approved by</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3RBAM">Request budget amount</param>
		/// <param name="m3EVTY">Event type</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3CFI1">User-defined field 1 - item</param>
		/// <param name="m3CFI2">User-defined field 2 - item</param>
		/// <param name="m3CFI3">User-defined field 3 - item</param>
		/// <param name="m3CFI4">User-defined field 4 - item</param>
		/// <param name="m3CFI5">User-defined field 5 - item</param>
		/// <param name="m3SPR1">Specific requirement category</param>
		/// <param name="m3SPR2">Specific requirement category</param>
		/// <param name="m3SPR3">Specific requirement category</param>
		/// <param name="m3SPR4">Specific requirement category</param>
		/// <param name="m3SPR5">Specific requirement category</param>
		/// <param name="m3SPR6">Specific requirements</param>
		/// <param name="m3SPR7">Specific requirements</param>
		/// <param name="m3SPR8">Specific requirements</param>
		/// <param name="m3SPR9">Specific requirements</param>
		/// <param name="m3SPR0">Specific requirements</param>
		/// <param name="m3TOFP">Process type</param>
		/// <param name="m3SRGP">Service group</param>
		/// <param name="m3NSTP">Shutdown</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3CLGP">Color group</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3SPRQ">Specific requirement category</param>
		/// <param name="m3SPRT">Specific requirements</param>
		/// <param name="m3EDWT">Estimated downtime</param>
		/// <param name="m3SCHL">Scheduling logic</param>
		/// <param name="m3RREQ">Requester</param>
		/// <param name="m3ESBU">Estimated cost</param>
		/// <param name="m3PLRD">Planner receipt date</param>
		/// <param name="m3PLRT">Planner receipt time</param>
		/// <param name="m3AAPD">Approval date</param>
		/// <param name="m3AAPT">Approval time</param>
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
		/// <param name="m3ADRR">Address file</param>
		/// <param name="m3ADRT">Address type</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3FWSL">From location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgProp(
			int m3PLPN, 
			int m3PLPS, 
			int m3PLP2, 
			string m3SUFI = null, 
			DateTime? m3RRSD = null, 
			int? m3RRST = null, 
			DateTime? m3STDT = null, 
			int? m3MSTI = null, 
			DateTime? m3FIDT = null, 
			int? m3MFTI = null, 
			DateTime? m3RRFD = null, 
			int? m3RRFT = null, 
			decimal? m3PPQT = null, 
			string m3RESP = null, 
			string m3PSTS = null, 
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			string m3BANO = null, 
			string m3PRIP = null, 
			string m3PLGR = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3GRTI = null, 
			decimal? m3SCHN = null, 
			string m3APRB = null, 
			string m3RSCD = null, 
			decimal? m3RBAM = null, 
			string m3EVTY = null, 
			string m3TX40 = null, 
			string m3CFI1 = null, 
			decimal? m3CFI2 = null, 
			string m3CFI3 = null, 
			string m3CFI4 = null, 
			string m3CFI5 = null, 
			string m3SPR1 = null, 
			string m3SPR2 = null, 
			string m3SPR3 = null, 
			string m3SPR4 = null, 
			string m3SPR5 = null, 
			string m3SPR6 = null, 
			string m3SPR7 = null, 
			string m3SPR8 = null, 
			string m3SPR9 = null, 
			string m3SPR0 = null, 
			string m3TOFP = null, 
			string m3SRGP = null, 
			int? m3NSTP = null, 
			decimal? m3TXID = null, 
			int? m3CLGP = null, 
			decimal? m3ATNR = null, 
			string m3SPRQ = null, 
			string m3SPRT = null, 
			int? m3EDWT = null, 
			int? m3SCHL = null, 
			string m3RREQ = null, 
			decimal? m3ESBU = null, 
			DateTime? m3PLRD = null, 
			int? m3PLRT = null, 
			DateTime? m3AAPD = null, 
			int? m3AAPT = null, 
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
			int? m3ADRR = null, 
			int? m3ADRT = null, 
			string m3ADID = null, 
			string m3FWSL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgProp",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLPS", m3PLPS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLP2", m3PLP2.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (m3RRSD.HasValue)
				request.WithQueryParameter("RRSD", m3RRSD.Value.ToM3String());
			if (m3RRST.HasValue)
				request.WithQueryParameter("RRST", m3RRST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3MSTI.HasValue)
				request.WithQueryParameter("MSTI", m3MSTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3FIDT.Value.ToM3String());
			if (m3MFTI.HasValue)
				request.WithQueryParameter("MFTI", m3MFTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RRFD.HasValue)
				request.WithQueryParameter("RRFD", m3RRFD.Value.ToM3String());
			if (m3RRFT.HasValue)
				request.WithQueryParameter("RRFT", m3RRFT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PPQT.HasValue)
				request.WithQueryParameter("PPQT", m3PPQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PSTS))
				request.WithQueryParameter("PSTS", m3PSTS.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRIP))
				request.WithQueryParameter("PRIP", m3PRIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRTI))
				request.WithQueryParameter("GRTI", m3GRTI.Trim());
			if (m3SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3SCHN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3APRB))
				request.WithQueryParameter("APRB", m3APRB.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (m3RBAM.HasValue)
				request.WithQueryParameter("RBAM", m3RBAM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EVTY))
				request.WithQueryParameter("EVTY", m3EVTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3SPR1))
				request.WithQueryParameter("SPR1", m3SPR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPR2))
				request.WithQueryParameter("SPR2", m3SPR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPR3))
				request.WithQueryParameter("SPR3", m3SPR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPR4))
				request.WithQueryParameter("SPR4", m3SPR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPR5))
				request.WithQueryParameter("SPR5", m3SPR5.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPR6))
				request.WithQueryParameter("SPR6", m3SPR6.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPR7))
				request.WithQueryParameter("SPR7", m3SPR7.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPR8))
				request.WithQueryParameter("SPR8", m3SPR8.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPR9))
				request.WithQueryParameter("SPR9", m3SPR9.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPR0))
				request.WithQueryParameter("SPR0", m3SPR0.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOFP))
				request.WithQueryParameter("TOFP", m3TOFP.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRGP))
				request.WithQueryParameter("SRGP", m3SRGP.Trim());
			if (m3NSTP.HasValue)
				request.WithQueryParameter("NSTP", m3NSTP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CLGP.HasValue)
				request.WithQueryParameter("CLGP", m3CLGP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPRQ))
				request.WithQueryParameter("SPRQ", m3SPRQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPRT))
				request.WithQueryParameter("SPRT", m3SPRT.Trim());
			if (m3EDWT.HasValue)
				request.WithQueryParameter("EDWT", m3EDWT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHL.HasValue)
				request.WithQueryParameter("SCHL", m3SCHL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RREQ))
				request.WithQueryParameter("RREQ", m3RREQ.Trim());
			if (m3ESBU.HasValue)
				request.WithQueryParameter("ESBU", m3ESBU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLRD.HasValue)
				request.WithQueryParameter("PLRD", m3PLRD.Value.ToM3String());
			if (m3PLRT.HasValue)
				request.WithQueryParameter("PLRT", m3PLRT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AAPD.HasValue)
				request.WithQueryParameter("AAPD", m3AAPD.Value.ToM3String());
			if (m3AAPT.HasValue)
				request.WithQueryParameter("AAPT", m3AAPT.Value.ToString(CultureInfo.CurrentCulture));
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
			if (m3ADRR.HasValue)
				request.WithQueryParameter("ADRR", m3ADRR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3ADRT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3FWSL))
				request.WithQueryParameter("FWSL", m3FWSL.Trim());

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
		/// <param name="m3PLPN">Planned order (Required)</param>
		/// <param name="m3PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3PLP2">Subnumber - order proposal (Required)</param>
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
			int m3PLPN, 
			int m3PLPS, 
			int m3PLP2, 
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelMtrl",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLPS", m3PLPS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLP2", m3PLP2.ToString(CultureInfo.CurrentCulture))
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
		/// Name DelOp
		/// Description Del Operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PLPN">Planned order (Required)</param>
		/// <param name="m3PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3PLP2">Subnumber - order proposal (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelOp(
			int m3PLPN, 
			int m3PLPS, 
			int m3PLP2, 
			int m3OPNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelOp",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLPS", m3PLPS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLP2", m3PLP2.ToString(CultureInfo.CurrentCulture))
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
		/// Name DelOpElement
		/// Description Delete Operation Elemet
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PLPN">Planned order (Required)</param>
		/// <param name="m3PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3PLP2">Subnumber - order proposal (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3ACTS">Task element number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelOpElement(
			int m3PLPN, 
			int m3PLPS, 
			int m3PLP2, 
			int m3OPNO, 
			int m3ACTS, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelOpElement",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLPS", m3PLPS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLP2", m3PLP2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACTS", m3ACTS.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelProp
		/// Description Delete proposal
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PLPN">Planned order (Required)</param>
		/// <param name="m3PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3PLP2">Subnumber - order proposal (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelProp(
			int m3PLPN, 
			int m3PLPS, 
			int m3PLP2, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelProp",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLPS", m3PLPS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLP2", m3PLP2.ToString(CultureInfo.CurrentCulture));

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
		/// Name DenyProp
		/// Description Reject/Deny Proposal
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PLPN">Planned order</param>
		/// <param name="m3PLPS">Subnumber - planned order</param>
		/// <param name="m3PLP2">Subnumber - order proposal</param>
		/// <param name="m3REJD">Rejection date</param>
		/// <param name="m3REJT">Rejection time</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DenyProp(
			int? m3PLPN = null, 
			int? m3PLPS = null, 
			int? m3PLP2 = null, 
			DateTime? m3REJD = null, 
			int? m3REJT = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DenyProp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3PLPN.HasValue)
				request.WithQueryParameter("PLPN", m3PLPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3PLPS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLP2.HasValue)
				request.WithQueryParameter("PLP2", m3PLP2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REJD.HasValue)
				request.WithQueryParameter("REJD", m3REJD.Value.ToM3String());
			if (m3REJT.HasValue)
				request.WithQueryParameter("REJT", m3REJT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetMtrl
		/// Description Get Material
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PLPN">Planned order (Required)</param>
		/// <param name="m3PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3PLP2">Subnumber - order proposal (Required)</param>
		/// <param name="m3MSEQ">Sequence number (Required)</param>
		/// <param name="m3RCOS">Retrive estimated cost</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMtrlResponse></returns>
		/// <exception cref="M3Exception<GetMtrlResponse>"></exception>
		public async Task<M3Response<GetMtrlResponse>> GetMtrl(
			int m3PLPN, 
			int m3PLPS, 
			int m3PLP2, 
			int m3MSEQ, 
			int? m3RCOS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetMtrl",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLPS", m3PLPS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLP2", m3PLP2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("MSEQ", m3MSEQ.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3RCOS.HasValue)
				request.WithQueryParameter("RCOS", m3RCOS.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetOp
		/// Description Get Operation
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PLPN">Planned order (Required)</param>
		/// <param name="m3PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3PLP2">Subnumber - order proposal (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3RCOS">Retrive estimated cost</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOpResponse></returns>
		/// <exception cref="M3Exception<GetOpResponse>"></exception>
		public async Task<M3Response<GetOpResponse>> GetOp(
			int m3PLPN, 
			int m3PLPS, 
			int m3PLP2, 
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetOp",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLPS", m3PLPS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLP2", m3PLP2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3RCOS.HasValue)
				request.WithQueryParameter("RCOS", m3RCOS.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PLPN">Planned order (Required)</param>
		/// <param name="m3PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3PLP2">Subnumber - order proposal (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOp2Response></returns>
		/// <exception cref="M3Exception<GetOp2Response>"></exception>
		public async Task<M3Response<GetOp2Response>> GetOp2(
			int m3PLPN, 
			int m3PLPS, 
			int m3PLP2, 
			int m3OPNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetOp2",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLPS", m3PLPS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLP2", m3PLP2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetOpElement
		/// Description Get Operation Elemet
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PLPN">Planned order (Required)</param>
		/// <param name="m3PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3PLP2">Subnumber - order proposal (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3ACTS">Task element number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOpElementResponse></returns>
		/// <exception cref="M3Exception<GetOpElementResponse>"></exception>
		public async Task<M3Response<GetOpElementResponse>> GetOpElement(
			int m3PLPN, 
			int m3PLPS, 
			int m3PLP2, 
			int m3OPNO, 
			int m3ACTS, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetOpElement",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLPS", m3PLPS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLP2", m3PLP2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACTS", m3ACTS.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetOpElementResponse>(
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
		/// Name GetProp
		/// Description Get Proposal
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PLPN">Planned order (Required)</param>
		/// <param name="m3PLPS">Subnumber - planned order (Required)</param>
		/// <param name="m3PLP2">Subnumber - order proposal (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPropResponse></returns>
		/// <exception cref="M3Exception<GetPropResponse>"></exception>
		public async Task<M3Response<GetPropResponse>> GetProp(
			int m3PLPN, 
			int m3PLPS, 
			int m3PLP2, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetProp",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLPS", m3PLPS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLP2", m3PLP2.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetPropResponse>(
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
		/// Name RelProp
		/// Description Release proposal
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PLPN">ProposalNumber (Required)</param>
		/// <param name="m3PLPS">ProposalSubnumber (Required)</param>
		/// <param name="m3PLP2">ProposalSubnumber (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RelProp(
			int m3PLPN, 
			int m3PLPS, 
			int m3PLP2, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/RelProp",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLPS", m3PLPS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLP2", m3PLP2.ToString(CultureInfo.CurrentCulture));

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
		/// Name RelWorkScope
		/// Description Release Work Scope
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3RORC">Reference order category (Required)</param>
		/// <param name="m3RORN">Reference order number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RelWorkScope(
			int m3RORC, 
			string m3RORN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/RelWorkScope",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RORN))
				throw new ArgumentNullException(nameof(m3RORN));

			// Set mandatory parameters
			request
				.WithQueryParameter("RORC", m3RORC.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RORN", m3RORN.Trim());

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
		/// Name Search
		/// Description Search
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3SQRY">Search query</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchResponse></returns>
		/// <exception cref="M3Exception<SearchResponse>"></exception>
		public async Task<M3Response<SearchResponse>> Search(
			string m3SQRY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Search",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SQRY))
				request.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchResponse>(
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
