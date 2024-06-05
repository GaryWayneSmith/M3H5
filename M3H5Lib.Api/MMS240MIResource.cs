/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.MMS240MI;
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
	/// Name: MMS240MI
	/// Component Name: ItemSerialnumber
	/// Description: Item serialnumber/equipment interface
	/// Version Release: 5ea6
	///</summary>
	public partial class MMS240MIResource : M3BaseResourceEndpoint
	{
		public MMS240MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS240MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add Item/Serialnumber
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3ASID">Fixed asset</param>
		/// <param name="m3SBNO">Subnumber</param>
		/// <param name="m3ABBD">Buy-back date</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3WADT">Warranty date</param>
		/// <param name="m3WAGR">Warranty agreement</param>
		/// <param name="m3WAL1">Warranty limit 1</param>
		/// <param name="m3WAL2">Warranty limit 2</param>
		/// <param name="m3WAL3">Warranty limit 3</param>
		/// <param name="m3WAL4">Warranty limit 4</param>
		/// <param name="m3NESA">Next shop action type</param>
		/// <param name="m3NSUF">Next service</param>
		/// <param name="m3MPGM">Maintenance program</param>
		/// <param name="m3MAPL">Planner - maintenance</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3FCCM">Forecast logic</param>
		/// <param name="m3PUPR">Purchase price</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3PPDT">Purchase price date</param>
		/// <param name="m3BIRT">Origin identity</param>
		/// <param name="m3BIRS">Date introduced into Movex</param>
		/// <param name="m3ALII">Equipment description</param>
		/// <param name="m3DPID">Period frame</param>
		/// <param name="m3CONC">Continuous net change</param>
		/// <param name="m3PLMZ">Planning horizon</param>
		/// <param name="m3SHRE">Percentage of cost price</param>
		/// <param name="m3INSN">Insurance number</param>
		/// <param name="m3EQNO">Equipment number</param>
		/// <param name="m3EQNL">Field not used</param>
		/// <param name="m3PRIP">Priority</param>
		/// <param name="m3PRSS">Process</param>
		/// <param name="m3SBPR">Subprocess</param>
		/// <param name="m3AESC">Criticality class</param>
		/// <param name="m3TEFF">Target availability</param>
		/// <param name="m3DWTC">Downtime cost</param>
		/// <param name="m3CMDD">Commission date</param>
		/// <param name="m3MFDT">Manufacturing date</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3DTID">Data identity</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3MLYR">Year model</param>
		/// <param name="m3AREA">Location description</param>
		/// <param name="m3LOCS">Location</param>
		/// <param name="m3BRAN">Brand</param>
		/// <param name="m3EQTP">Equipment type</param>
		/// <param name="m3EQGR">Equipment group</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3INDA">Installation date</param>
		/// <param name="m3SNRC">Serial number return code</param>
		/// <param name="m3RFIA">Asset tag</param>
		/// <param name="m3TAIL">Registration number/site</param>
		/// <param name="m3AAGN">Agreement number</param>
		/// <param name="m3FLEE">Fleet</param>
		/// <param name="m3COCE">Cost center</param>
		/// <param name="m3FLNO">Fleet number</param>
		/// <param name="m3SKEY">Search key equipment</param>
		/// <param name="m3LAMA">Minimum accepted contributn margin ratio</param>
		/// <param name="m3ASLM">Sales model</param>
		/// <param name="m3APRM">Price model</param>
		/// <param name="m3ADLM">Dealer model</param>
		/// <param name="m3ACMC">Compatibility code</param>
		/// <param name="m3CFI1">User-defined field 1 - item</param>
		/// <param name="m3CFI2">User-defined field 2 - item</param>
		/// <param name="m3CFI3">User-defined field 3 - item</param>
		/// <param name="m3CFI4">User-defined field 4 - item</param>
		/// <param name="m3CFI5">User-defined field 5 - item</param>
		/// <param name="m3CUOW">Owner</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3OWTP">Ownership type</param>
		/// <param name="m3PUEX">Publish External</param>
		/// <param name="m3PUNO">Purchase order number</param>
		/// <param name="m3PNLI">Purchase order line</param>
		/// <param name="m3PNLS">Purchsase order line subnumber</param>
		/// <param name="m3OWNC">Owner</param>
		/// <param name="m3LKST">like kind status</param>
		/// <param name="m3LKDT">like kind date</param>
		/// <param name="m3EQCL">Equipment class</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddResponse></returns>
		/// <exception cref="M3Exception<AddResponse>"></exception>
		public async Task<M3Response<AddResponse>> Add(
			string m3ITNO, 
			string m3FACI, 
			int? m3CONO = null, 
			string m3SERN = null, 
			string m3ASID = null, 
			int? m3SBNO = null, 
			DateTime? m3ABBD = null, 
			string m3STAT = null, 
			DateTime? m3WADT = null, 
			string m3WAGR = null, 
			decimal? m3WAL1 = null, 
			decimal? m3WAL2 = null, 
			decimal? m3WAL3 = null, 
			decimal? m3WAL4 = null, 
			string m3NESA = null, 
			string m3NSUF = null, 
			string m3MPGM = null, 
			string m3MAPL = null, 
			string m3CUNO = null, 
			string m3FCCM = null, 
			decimal? m3PUPR = null, 
			string m3CUCD = null, 
			DateTime? m3PPDT = null, 
			long? m3BIRT = null, 
			DateTime? m3BIRS = null, 
			string m3ALII = null, 
			int? m3DPID = null, 
			int? m3CONC = null, 
			int? m3PLMZ = null, 
			int? m3SHRE = null, 
			string m3INSN = null, 
			string m3EQNO = null, 
			int? m3EQNL = null, 
			string m3PRIP = null, 
			string m3PRSS = null, 
			string m3SBPR = null, 
			int? m3AESC = null, 
			decimal? m3TEFF = null, 
			decimal? m3DWTC = null, 
			DateTime? m3CMDD = null, 
			DateTime? m3MFDT = null, 
			string m3PLGR = null, 
			decimal? m3DTID = null, 
			decimal? m3TXID = null, 
			string m3MLYR = null, 
			string m3AREA = null, 
			string m3LOCS = null, 
			string m3BRAN = null, 
			string m3EQTP = null, 
			string m3EQGR = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			DateTime? m3INDA = null, 
			int? m3SNRC = null, 
			string m3RFIA = null, 
			string m3TAIL = null, 
			string m3AAGN = null, 
			string m3FLEE = null, 
			string m3COCE = null, 
			string m3FLNO = null, 
			string m3SKEY = null, 
			int? m3LAMA = null, 
			string m3ASLM = null, 
			string m3APRM = null, 
			string m3ADLM = null, 
			string m3ACMC = null, 
			string m3CFI1 = null, 
			decimal? m3CFI2 = null, 
			string m3CFI3 = null, 
			string m3CFI4 = null, 
			string m3CFI5 = null, 
			string m3CUOW = null, 
			string m3ADID = null, 
			string m3OWTP = null, 
			int? m3PUEX = null, 
			string m3PUNO = null, 
			int? m3PNLI = null, 
			int? m3PNLS = null, 
			string m3OWNC = null, 
			string m3LKST = null, 
			DateTime? m3LKDT = null, 
			string m3EQCL = null, 
			string m3SUNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ASID))
				request.WithQueryParameter("ASID", m3ASID.Trim());
			if (m3SBNO.HasValue)
				request.WithQueryParameter("SBNO", m3SBNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ABBD.HasValue)
				request.WithQueryParameter("ABBD", m3ABBD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3WADT.HasValue)
				request.WithQueryParameter("WADT", m3WADT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3WAGR))
				request.WithQueryParameter("WAGR", m3WAGR.Trim());
			if (m3WAL1.HasValue)
				request.WithQueryParameter("WAL1", m3WAL1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAL2.HasValue)
				request.WithQueryParameter("WAL2", m3WAL2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAL3.HasValue)
				request.WithQueryParameter("WAL3", m3WAL3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAL4.HasValue)
				request.WithQueryParameter("WAL4", m3WAL4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NESA))
				request.WithQueryParameter("NESA", m3NESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3NSUF))
				request.WithQueryParameter("NSUF", m3NSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3MPGM))
				request.WithQueryParameter("MPGM", m3MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3MAPL))
				request.WithQueryParameter("MAPL", m3MAPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCCM))
				request.WithQueryParameter("FCCM", m3FCCM.Trim());
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3PPDT.HasValue)
				request.WithQueryParameter("PPDT", m3PPDT.Value.ToM3String());
			if (m3BIRT.HasValue)
				request.WithQueryParameter("BIRT", m3BIRT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BIRS.HasValue)
				request.WithQueryParameter("BIRS", m3BIRS.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ALII))
				request.WithQueryParameter("ALII", m3ALII.Trim());
			if (m3DPID.HasValue)
				request.WithQueryParameter("DPID", m3DPID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CONC.HasValue)
				request.WithQueryParameter("CONC", m3CONC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLMZ.HasValue)
				request.WithQueryParameter("PLMZ", m3PLMZ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHRE.HasValue)
				request.WithQueryParameter("SHRE", m3SHRE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INSN))
				request.WithQueryParameter("INSN", m3INSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQNO))
				request.WithQueryParameter("EQNO", m3EQNO.Trim());
			if (m3EQNL.HasValue)
				request.WithQueryParameter("EQNL", m3EQNL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRIP))
				request.WithQueryParameter("PRIP", m3PRIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRSS))
				request.WithQueryParameter("PRSS", m3PRSS.Trim());
			if (!string.IsNullOrWhiteSpace(m3SBPR))
				request.WithQueryParameter("SBPR", m3SBPR.Trim());
			if (m3AESC.HasValue)
				request.WithQueryParameter("AESC", m3AESC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TEFF.HasValue)
				request.WithQueryParameter("TEFF", m3TEFF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DWTC.HasValue)
				request.WithQueryParameter("DWTC", m3DWTC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CMDD.HasValue)
				request.WithQueryParameter("CMDD", m3CMDD.Value.ToM3String());
			if (m3MFDT.HasValue)
				request.WithQueryParameter("MFDT", m3MFDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (m3DTID.HasValue)
				request.WithQueryParameter("DTID", m3DTID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MLYR))
				request.WithQueryParameter("MLYR", m3MLYR.Trim());
			if (!string.IsNullOrWhiteSpace(m3AREA))
				request.WithQueryParameter("AREA", m3AREA.Trim());
			if (!string.IsNullOrWhiteSpace(m3LOCS))
				request.WithQueryParameter("LOCS", m3LOCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRAN))
				request.WithQueryParameter("BRAN", m3BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQTP))
				request.WithQueryParameter("EQTP", m3EQTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQGR))
				request.WithQueryParameter("EQGR", m3EQGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (m3INDA.HasValue)
				request.WithQueryParameter("INDA", m3INDA.Value.ToM3String());
			if (m3SNRC.HasValue)
				request.WithQueryParameter("SNRC", m3SNRC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RFIA))
				request.WithQueryParameter("RFIA", m3RFIA.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAIL))
				request.WithQueryParameter("TAIL", m3TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3AAGN))
				request.WithQueryParameter("AAGN", m3AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLEE))
				request.WithQueryParameter("FLEE", m3FLEE.Trim());
			if (!string.IsNullOrWhiteSpace(m3COCE))
				request.WithQueryParameter("COCE", m3COCE.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLNO))
				request.WithQueryParameter("FLNO", m3FLNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SKEY))
				request.WithQueryParameter("SKEY", m3SKEY.Trim());
			if (m3LAMA.HasValue)
				request.WithQueryParameter("LAMA", m3LAMA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ASLM))
				request.WithQueryParameter("ASLM", m3ASLM.Trim());
			if (!string.IsNullOrWhiteSpace(m3APRM))
				request.WithQueryParameter("APRM", m3APRM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADLM))
				request.WithQueryParameter("ADLM", m3ADLM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACMC))
				request.WithQueryParameter("ACMC", m3ACMC.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3CUOW))
				request.WithQueryParameter("CUOW", m3CUOW.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3OWTP))
				request.WithQueryParameter("OWTP", m3OWTP.Trim());
			if (m3PUEX.HasValue)
				request.WithQueryParameter("PUEX", m3PUEX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PUNO))
				request.WithQueryParameter("PUNO", m3PUNO.Trim());
			if (m3PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3PNLI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3PNLS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OWNC))
				request.WithQueryParameter("OWNC", m3OWNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3LKST))
				request.WithQueryParameter("LKST", m3LKST.Trim());
			if (m3LKDT.HasValue)
				request.WithQueryParameter("LKDT", m3LKDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3EQCL))
				request.WithQueryParameter("EQCL", m3EQCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());

			// Execute the request
			var result = await Execute<AddResponse>(
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
		/// Name AddEquipment
		/// Description Add Equipment
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3EQNO">Equipment number (Required)</param>
		/// <param name="m3TAIL">Registration number/site (Required)</param>
		/// <param name="m3ITTY">Item type (Required)</param>
		/// <param name="m3ITDS">Name (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STCD">Inventory accounting</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3CFGH">NHA configuration position</param>
		/// <param name="m3POEQ">Position/equipment</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3ITCL">Product group</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3PRIP">Priority</param>
		/// <param name="m3ALII">Equipment description</param>
		/// <param name="m3TEFF">Target availability</param>
		/// <param name="m3DWTC">Downtime cost</param>
		/// <param name="m3PRSS">Process</param>
		/// <param name="m3SBPR">Subprocess</param>
		/// <param name="m3AESC">Criticality class</param>
		/// <param name="m3INSN">Insurance number</param>
		/// <param name="m3INDA">Installation date</param>
		/// <param name="m3INTS">Installation time</param>
		/// <param name="m3CMDD">Commission date</param>
		/// <param name="m3ASID">Fixed asset</param>
		/// <param name="m3SBNO">Subnumber</param>
		/// <param name="m3ABBD">Buy-back date</param>
		/// <param name="m3WADT">Warranty date</param>
		/// <param name="m3WAGR">Warranty agreement</param>
		/// <param name="m3WAL1">Warranty limit 1</param>
		/// <param name="m3WAL2">Warranty limit 2</param>
		/// <param name="m3WAL3">Warranty limit 3</param>
		/// <param name="m3WAL4">Warranty limit 4</param>
		/// <param name="m3NESA">Next shop action type</param>
		/// <param name="m3NSUF">Next service</param>
		/// <param name="m3MPGM">Maintenance program</param>
		/// <param name="m3MAPL">Planner - maintenance</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3FCCM">Forecast logic</param>
		/// <param name="m3PUPR">Purchase price</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3PRDT">Purchase price date</param>
		/// <param name="m3BIRT">Origin identity</param>
		/// <param name="m3BIRS">Date introduced into Movex</param>
		/// <param name="m3DPID">Period frame</param>
		/// <param name="m3CONC">Continuous net change</param>
		/// <param name="m3PLMZ">Planning horizon</param>
		/// <param name="m3SHRE">Percentage of cost price</param>
		/// <param name="m3EQNL">Field not used</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3MFDT">Manufacturing date</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3DTID">Data identity</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3MLYR">Year model</param>
		/// <param name="m3AREA">Location description</param>
		/// <param name="m3LOCS">Location</param>
		/// <param name="m3BRAN">Brand</param>
		/// <param name="m3EQTP">Equipment type</param>
		/// <param name="m3EQGR">Equipment group</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3EQGC">Equipment group category</param>
		/// <param name="m3SNRC">Serial number return code</param>
		/// <param name="m3RFIA">Asset tag</param>
		/// <param name="m3OWNC">Owner</param>
		/// <param name="m3MFIT">Supplier/manufacturer item number</param>
		/// <param name="m3MFSN">Manufacturer serial number</param>
		/// <param name="m3COCE">Cost center</param>
		/// <param name="m3FLNO">Fleet number</param>
		/// <param name="m3SKEY">Search key equipment</param>
		/// <param name="m3LAMA">Minimum accepted contributn margin ratio</param>
		/// <param name="m3PUNO">Purchase order number</param>
		/// <param name="m3PNLI">Purchase order line</param>
		/// <param name="m3PNLS">Purchase order  line subnumber</param>
		/// <param name="m3EQCL">Equipment class</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddEquipmentResponse></returns>
		/// <exception cref="M3Exception<AddEquipmentResponse>"></exception>
		public async Task<M3Response<AddEquipmentResponse>> AddEquipment(
			string m3EQNO, 
			string m3TAIL, 
			string m3ITTY, 
			string m3ITDS, 
			int? m3CONO = null, 
			int? m3STCD = null, 
			string m3ITNO = null, 
			string m3SERN = null, 
			string m3CFGH = null, 
			int? m3POEQ = null, 
			string m3ITGR = null, 
			string m3ITCL = null, 
			string m3ACRF = null, 
			string m3STAT = null, 
			string m3PRIP = null, 
			string m3ALII = null, 
			decimal? m3TEFF = null, 
			decimal? m3DWTC = null, 
			string m3PRSS = null, 
			string m3SBPR = null, 
			int? m3AESC = null, 
			string m3INSN = null, 
			DateTime? m3INDA = null, 
			int? m3INTS = null, 
			DateTime? m3CMDD = null, 
			string m3ASID = null, 
			int? m3SBNO = null, 
			DateTime? m3ABBD = null, 
			DateTime? m3WADT = null, 
			string m3WAGR = null, 
			decimal? m3WAL1 = null, 
			decimal? m3WAL2 = null, 
			decimal? m3WAL3 = null, 
			decimal? m3WAL4 = null, 
			string m3NESA = null, 
			string m3NSUF = null, 
			string m3MPGM = null, 
			string m3MAPL = null, 
			string m3CUNO = null, 
			string m3FCCM = null, 
			decimal? m3PUPR = null, 
			string m3CUCD = null, 
			DateTime? m3PRDT = null, 
			long? m3BIRT = null, 
			DateTime? m3BIRS = null, 
			int? m3DPID = null, 
			int? m3CONC = null, 
			int? m3PLMZ = null, 
			int? m3SHRE = null, 
			int? m3EQNL = null, 
			string m3FACI = null, 
			DateTime? m3MFDT = null, 
			string m3PLGR = null, 
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			decimal? m3DTID = null, 
			decimal? m3TXID = null, 
			string m3MLYR = null, 
			string m3AREA = null, 
			string m3LOCS = null, 
			string m3BRAN = null, 
			string m3EQTP = null, 
			string m3EQGR = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3EQGC = null, 
			int? m3SNRC = null, 
			string m3RFIA = null, 
			string m3OWNC = null, 
			string m3MFIT = null, 
			string m3MFSN = null, 
			string m3COCE = null, 
			string m3FLNO = null, 
			string m3SKEY = null, 
			int? m3LAMA = null, 
			string m3PUNO = null, 
			int? m3PNLI = null, 
			int? m3PNLS = null, 
			string m3EQCL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddEquipment",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EQNO))
				throw new ArgumentNullException(nameof(m3EQNO));
			if (string.IsNullOrWhiteSpace(m3TAIL))
				throw new ArgumentNullException(nameof(m3TAIL));
			if (string.IsNullOrWhiteSpace(m3ITTY))
				throw new ArgumentNullException(nameof(m3ITTY));
			if (string.IsNullOrWhiteSpace(m3ITDS))
				throw new ArgumentNullException(nameof(m3ITDS));

			// Set mandatory parameters
			request
				.WithQueryParameter("EQNO", m3EQNO.Trim())
				.WithQueryParameter("TAIL", m3TAIL.Trim())
				.WithQueryParameter("ITTY", m3ITTY.Trim())
				.WithQueryParameter("ITDS", m3ITDS.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STCD.HasValue)
				request.WithQueryParameter("STCD", m3STCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGH))
				request.WithQueryParameter("CFGH", m3CFGH.Trim());
			if (m3POEQ.HasValue)
				request.WithQueryParameter("POEQ", m3POEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITCL))
				request.WithQueryParameter("ITCL", m3ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRIP))
				request.WithQueryParameter("PRIP", m3PRIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALII))
				request.WithQueryParameter("ALII", m3ALII.Trim());
			if (m3TEFF.HasValue)
				request.WithQueryParameter("TEFF", m3TEFF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DWTC.HasValue)
				request.WithQueryParameter("DWTC", m3DWTC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRSS))
				request.WithQueryParameter("PRSS", m3PRSS.Trim());
			if (!string.IsNullOrWhiteSpace(m3SBPR))
				request.WithQueryParameter("SBPR", m3SBPR.Trim());
			if (m3AESC.HasValue)
				request.WithQueryParameter("AESC", m3AESC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INSN))
				request.WithQueryParameter("INSN", m3INSN.Trim());
			if (m3INDA.HasValue)
				request.WithQueryParameter("INDA", m3INDA.Value.ToM3String());
			if (m3INTS.HasValue)
				request.WithQueryParameter("INTS", m3INTS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CMDD.HasValue)
				request.WithQueryParameter("CMDD", m3CMDD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ASID))
				request.WithQueryParameter("ASID", m3ASID.Trim());
			if (m3SBNO.HasValue)
				request.WithQueryParameter("SBNO", m3SBNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ABBD.HasValue)
				request.WithQueryParameter("ABBD", m3ABBD.Value.ToM3String());
			if (m3WADT.HasValue)
				request.WithQueryParameter("WADT", m3WADT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3WAGR))
				request.WithQueryParameter("WAGR", m3WAGR.Trim());
			if (m3WAL1.HasValue)
				request.WithQueryParameter("WAL1", m3WAL1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAL2.HasValue)
				request.WithQueryParameter("WAL2", m3WAL2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAL3.HasValue)
				request.WithQueryParameter("WAL3", m3WAL3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAL4.HasValue)
				request.WithQueryParameter("WAL4", m3WAL4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NESA))
				request.WithQueryParameter("NESA", m3NESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3NSUF))
				request.WithQueryParameter("NSUF", m3NSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3MPGM))
				request.WithQueryParameter("MPGM", m3MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3MAPL))
				request.WithQueryParameter("MAPL", m3MAPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCCM))
				request.WithQueryParameter("FCCM", m3FCCM.Trim());
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3PRDT.Value.ToM3String());
			if (m3BIRT.HasValue)
				request.WithQueryParameter("BIRT", m3BIRT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BIRS.HasValue)
				request.WithQueryParameter("BIRS", m3BIRS.Value.ToM3String());
			if (m3DPID.HasValue)
				request.WithQueryParameter("DPID", m3DPID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CONC.HasValue)
				request.WithQueryParameter("CONC", m3CONC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLMZ.HasValue)
				request.WithQueryParameter("PLMZ", m3PLMZ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHRE.HasValue)
				request.WithQueryParameter("SHRE", m3SHRE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EQNL.HasValue)
				request.WithQueryParameter("EQNL", m3EQNL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (m3MFDT.HasValue)
				request.WithQueryParameter("MFDT", m3MFDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTID.HasValue)
				request.WithQueryParameter("DTID", m3DTID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MLYR))
				request.WithQueryParameter("MLYR", m3MLYR.Trim());
			if (!string.IsNullOrWhiteSpace(m3AREA))
				request.WithQueryParameter("AREA", m3AREA.Trim());
			if (!string.IsNullOrWhiteSpace(m3LOCS))
				request.WithQueryParameter("LOCS", m3LOCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRAN))
				request.WithQueryParameter("BRAN", m3BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQTP))
				request.WithQueryParameter("EQTP", m3EQTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQGR))
				request.WithQueryParameter("EQGR", m3EQGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQGC))
				request.WithQueryParameter("EQGC", m3EQGC.Trim());
			if (m3SNRC.HasValue)
				request.WithQueryParameter("SNRC", m3SNRC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RFIA))
				request.WithQueryParameter("RFIA", m3RFIA.Trim());
			if (!string.IsNullOrWhiteSpace(m3OWNC))
				request.WithQueryParameter("OWNC", m3OWNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3MFIT))
				request.WithQueryParameter("MFIT", m3MFIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3MFSN))
				request.WithQueryParameter("MFSN", m3MFSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3COCE))
				request.WithQueryParameter("COCE", m3COCE.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLNO))
				request.WithQueryParameter("FLNO", m3FLNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SKEY))
				request.WithQueryParameter("SKEY", m3SKEY.Trim());
			if (m3LAMA.HasValue)
				request.WithQueryParameter("LAMA", m3LAMA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PUNO))
				request.WithQueryParameter("PUNO", m3PUNO.Trim());
			if (m3PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3PNLI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3PNLS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EQCL))
				request.WithQueryParameter("EQCL", m3EQCL.Trim());

			// Execute the request
			var result = await Execute<AddEquipmentResponse>(
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
		/// Name AddFixedAsset
		/// Description Add Fixed asset
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3ASID">Fixed asset (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3EQNO">Equipment number</param>
		/// <param name="m3STCD">Inventory accounting</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3TAIL">Registration number/site</param>
		/// <param name="m3CFGH">NHA configuration position</param>
		/// <param name="m3POEQ">Position/equipment</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3ITCL">Product group</param>
		/// <param name="m3ITTY">Item type</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3PRIP">Priority</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3ALII">Equipment description</param>
		/// <param name="m3TEFF">Target availability</param>
		/// <param name="m3DWTC">Downtime cost</param>
		/// <param name="m3PRSS">Process</param>
		/// <param name="m3SBPR">Subprocess</param>
		/// <param name="m3AESC">Criticality class</param>
		/// <param name="m3INSN">Insurance number</param>
		/// <param name="m3INDA">Installation date</param>
		/// <param name="m3INTS">Installation time</param>
		/// <param name="m3CMDD">Commission date</param>
		/// <param name="m3SBNO">Subnumber</param>
		/// <param name="m3ABBD">Buy-back date</param>
		/// <param name="m3WADT">Warranty date</param>
		/// <param name="m3WAGR">Warranty agreement</param>
		/// <param name="m3WAL1">Warranty limit 1</param>
		/// <param name="m3WAL2">Warranty limit 2</param>
		/// <param name="m3WAL3">Warranty limit 3</param>
		/// <param name="m3WAL4">Warranty limit 4</param>
		/// <param name="m3NESA">Next shop action type</param>
		/// <param name="m3NSUF">Next service</param>
		/// <param name="m3MPGM">Maintenance program</param>
		/// <param name="m3MAPL">Planner - maintenance</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3FCCM">Forecast logic</param>
		/// <param name="m3PUPR">Purchase price</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3PRDT">Purchase price date</param>
		/// <param name="m3BIRT">Origin identity</param>
		/// <param name="m3BIRS">Date introduced into Movex</param>
		/// <param name="m3DPID">Period frame</param>
		/// <param name="m3CONC">Continuous net change</param>
		/// <param name="m3PLMZ">Planning horizon</param>
		/// <param name="m3SHRE">Percentage of cost price</param>
		/// <param name="m3EQNL">Field not used</param>
		/// <param name="m3MFDT">Manufacturing date</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3DTID">Data identity</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3MLYR">Year model</param>
		/// <param name="m3AREA">Location description</param>
		/// <param name="m3LOCS">Location</param>
		/// <param name="m3BRAN">Brand</param>
		/// <param name="m3EQTP">Equipment type</param>
		/// <param name="m3EQGR">Equipment group</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3EQGC">Equipment group category</param>
		/// <param name="m3SNRC">Serial number return code</param>
		/// <param name="m3FLNO">Fleet number</param>
		/// <param name="m3SKEY">Search key equipment</param>
		/// <param name="m3EQCL">Equipment class</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddFixedAssetResponse></returns>
		/// <exception cref="M3Exception<AddFixedAssetResponse>"></exception>
		public async Task<M3Response<AddFixedAssetResponse>> AddFixedAsset(
			string m3ASID, 
			string m3ITNO, 
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3EQNO = null, 
			int? m3STCD = null, 
			string m3SERN = null, 
			string m3TAIL = null, 
			string m3CFGH = null, 
			int? m3POEQ = null, 
			string m3ITGR = null, 
			string m3ITCL = null, 
			string m3ITTY = null, 
			string m3ACRF = null, 
			string m3STAT = null, 
			string m3PRIP = null, 
			string m3ITDS = null, 
			string m3ALII = null, 
			decimal? m3TEFF = null, 
			decimal? m3DWTC = null, 
			string m3PRSS = null, 
			string m3SBPR = null, 
			int? m3AESC = null, 
			string m3INSN = null, 
			DateTime? m3INDA = null, 
			int? m3INTS = null, 
			DateTime? m3CMDD = null, 
			int? m3SBNO = null, 
			DateTime? m3ABBD = null, 
			DateTime? m3WADT = null, 
			string m3WAGR = null, 
			decimal? m3WAL1 = null, 
			decimal? m3WAL2 = null, 
			decimal? m3WAL3 = null, 
			decimal? m3WAL4 = null, 
			string m3NESA = null, 
			string m3NSUF = null, 
			string m3MPGM = null, 
			string m3MAPL = null, 
			string m3CUNO = null, 
			string m3FCCM = null, 
			decimal? m3PUPR = null, 
			string m3CUCD = null, 
			DateTime? m3PRDT = null, 
			long? m3BIRT = null, 
			DateTime? m3BIRS = null, 
			int? m3DPID = null, 
			int? m3CONC = null, 
			int? m3PLMZ = null, 
			int? m3SHRE = null, 
			int? m3EQNL = null, 
			DateTime? m3MFDT = null, 
			string m3PLGR = null, 
			decimal? m3DTID = null, 
			decimal? m3TXID = null, 
			string m3MLYR = null, 
			string m3AREA = null, 
			string m3LOCS = null, 
			string m3BRAN = null, 
			string m3EQTP = null, 
			string m3EQGR = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3EQGC = null, 
			int? m3SNRC = null, 
			string m3FLNO = null, 
			string m3SKEY = null, 
			string m3EQCL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddFixedAsset",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ASID))
				throw new ArgumentNullException(nameof(m3ASID));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ASID", m3ASID.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQNO))
				request.WithQueryParameter("EQNO", m3EQNO.Trim());
			if (m3STCD.HasValue)
				request.WithQueryParameter("STCD", m3STCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAIL))
				request.WithQueryParameter("TAIL", m3TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGH))
				request.WithQueryParameter("CFGH", m3CFGH.Trim());
			if (m3POEQ.HasValue)
				request.WithQueryParameter("POEQ", m3POEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITCL))
				request.WithQueryParameter("ITCL", m3ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITTY))
				request.WithQueryParameter("ITTY", m3ITTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRIP))
				request.WithQueryParameter("PRIP", m3PRIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALII))
				request.WithQueryParameter("ALII", m3ALII.Trim());
			if (m3TEFF.HasValue)
				request.WithQueryParameter("TEFF", m3TEFF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DWTC.HasValue)
				request.WithQueryParameter("DWTC", m3DWTC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRSS))
				request.WithQueryParameter("PRSS", m3PRSS.Trim());
			if (!string.IsNullOrWhiteSpace(m3SBPR))
				request.WithQueryParameter("SBPR", m3SBPR.Trim());
			if (m3AESC.HasValue)
				request.WithQueryParameter("AESC", m3AESC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INSN))
				request.WithQueryParameter("INSN", m3INSN.Trim());
			if (m3INDA.HasValue)
				request.WithQueryParameter("INDA", m3INDA.Value.ToM3String());
			if (m3INTS.HasValue)
				request.WithQueryParameter("INTS", m3INTS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CMDD.HasValue)
				request.WithQueryParameter("CMDD", m3CMDD.Value.ToM3String());
			if (m3SBNO.HasValue)
				request.WithQueryParameter("SBNO", m3SBNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ABBD.HasValue)
				request.WithQueryParameter("ABBD", m3ABBD.Value.ToM3String());
			if (m3WADT.HasValue)
				request.WithQueryParameter("WADT", m3WADT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3WAGR))
				request.WithQueryParameter("WAGR", m3WAGR.Trim());
			if (m3WAL1.HasValue)
				request.WithQueryParameter("WAL1", m3WAL1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAL2.HasValue)
				request.WithQueryParameter("WAL2", m3WAL2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAL3.HasValue)
				request.WithQueryParameter("WAL3", m3WAL3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAL4.HasValue)
				request.WithQueryParameter("WAL4", m3WAL4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NESA))
				request.WithQueryParameter("NESA", m3NESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3NSUF))
				request.WithQueryParameter("NSUF", m3NSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3MPGM))
				request.WithQueryParameter("MPGM", m3MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3MAPL))
				request.WithQueryParameter("MAPL", m3MAPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCCM))
				request.WithQueryParameter("FCCM", m3FCCM.Trim());
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3PRDT.Value.ToM3String());
			if (m3BIRT.HasValue)
				request.WithQueryParameter("BIRT", m3BIRT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BIRS.HasValue)
				request.WithQueryParameter("BIRS", m3BIRS.Value.ToM3String());
			if (m3DPID.HasValue)
				request.WithQueryParameter("DPID", m3DPID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CONC.HasValue)
				request.WithQueryParameter("CONC", m3CONC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLMZ.HasValue)
				request.WithQueryParameter("PLMZ", m3PLMZ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHRE.HasValue)
				request.WithQueryParameter("SHRE", m3SHRE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EQNL.HasValue)
				request.WithQueryParameter("EQNL", m3EQNL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MFDT.HasValue)
				request.WithQueryParameter("MFDT", m3MFDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (m3DTID.HasValue)
				request.WithQueryParameter("DTID", m3DTID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MLYR))
				request.WithQueryParameter("MLYR", m3MLYR.Trim());
			if (!string.IsNullOrWhiteSpace(m3AREA))
				request.WithQueryParameter("AREA", m3AREA.Trim());
			if (!string.IsNullOrWhiteSpace(m3LOCS))
				request.WithQueryParameter("LOCS", m3LOCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRAN))
				request.WithQueryParameter("BRAN", m3BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQTP))
				request.WithQueryParameter("EQTP", m3EQTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQGR))
				request.WithQueryParameter("EQGR", m3EQGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQGC))
				request.WithQueryParameter("EQGC", m3EQGC.Trim());
			if (m3SNRC.HasValue)
				request.WithQueryParameter("SNRC", m3SNRC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FLNO))
				request.WithQueryParameter("FLNO", m3FLNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SKEY))
				request.WithQueryParameter("SKEY", m3SKEY.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQCL))
				request.WithQueryParameter("EQCL", m3EQCL.Trim());

			// Execute the request
			var result = await Execute<AddFixedAssetResponse>(
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
		/// Name AddOEM
		/// Description Add OEM Codes
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3CONO">Company</param>
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
		public async Task<M3Response<M3Record>> AddOEM(
			string m3ITNO, 
			string m3SERN, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddOEM",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
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
		/// Name Del
		/// Description Delete Item/Serialnumber
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			string m3ITNO, 
			string m3SERN, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim());

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
		/// Name DelEquipment
		/// Description Del Equipment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3EQNO">Equipment number (Required)</param>
		/// <param name="m3TAIL">Registration number/site (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelEquipment(
			string m3EQNO, 
			string m3TAIL, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelEquipment",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EQNO))
				throw new ArgumentNullException(nameof(m3EQNO));
			if (string.IsNullOrWhiteSpace(m3TAIL))
				throw new ArgumentNullException(nameof(m3TAIL));

			// Set mandatory parameters
			request
				.WithQueryParameter("EQNO", m3EQNO.Trim())
				.WithQueryParameter("TAIL", m3TAIL.Trim());

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
		/// Name GenServiceHist
		/// Description Generate service history
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> GenServiceHist(
			string m3ITNO, 
			string m3SERN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GenServiceHist",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim());

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
		/// Description GEt Basic Data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicResponse></returns>
		/// <exception cref="M3Exception<GetBasicResponse>"></exception>
		public async Task<M3Response<GetBasicResponse>> GetBasic(
			string m3ITNO, 
			string m3SERN, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim());

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
		/// Name GetEquipAlias
		/// Description Get Equipment Search Alias
		/// Version Release: 
		/// </summary>
		/// <param name="m3POPN">Equipment Search Alias</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetEquipAliasResponse></returns>
		/// <exception cref="M3Exception<GetEquipAliasResponse>"></exception>
		public async Task<M3Response<GetEquipAliasResponse>> GetEquipAlias(
			string m3POPN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetEquipAlias",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());

			// Execute the request
			var result = await Execute<GetEquipAliasResponse>(
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
		/// Name GetModIndReg
		/// Description GetModIndReg
		/// Version Release: 15
		/// </summary>
		/// <param name="m3MTRL">Component identity (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetModIndRegResponse></returns>
		/// <exception cref="M3Exception<GetModIndRegResponse>"></exception>
		public async Task<M3Response<GetModIndRegResponse>> GetModIndReg(
			string m3MTRL, 
			string m3SERN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetModIndReg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MTRL))
				throw new ArgumentNullException(nameof(m3MTRL));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MTRL", m3MTRL.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim());

			// Execute the request
			var result = await Execute<GetModIndRegResponse>(
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
		/// Name GetOEM
		/// Description Get OEM Codes
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOEMResponse></returns>
		/// <exception cref="M3Exception<GetOEMResponse>"></exception>
		public async Task<M3Response<GetOEMResponse>> GetOEM(
			string m3ITNO, 
			string m3SERN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetOEM",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetOEMResponse>(
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
		/// Name LstByCompany
		/// Description List serial no by company
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByCompanyResponse></returns>
		/// <exception cref="M3Exception<LstByCompanyResponse>"></exception>
		public async Task<M3Response<LstByCompanyResponse>> LstByCompany(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByCompany",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstByCompanyResponse>(
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
		/// Name LstByCustomer
		/// Description LstByCustomer
		/// Version Release: 15
		/// </summary>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByCustomerResponse></returns>
		/// <exception cref="M3Exception<LstByCustomerResponse>"></exception>
		public async Task<M3Response<LstByCustomerResponse>> LstByCustomer(
			string m3CUNO, 
			string m3ITNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByCustomer",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<LstByCustomerResponse>(
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
		/// Name LstByItem
		/// Description List serial number by item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByItemResponse></returns>
		/// <exception cref="M3Exception<LstByItemResponse>"></exception>
		public async Task<M3Response<LstByItemResponse>> LstByItem(
			string m3ITNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstByItemResponse>(
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
		/// Name LstBySerialNo
		/// Description List by serial number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BRAN">Brand</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBySerialNoResponse></returns>
		/// <exception cref="M3Exception<LstBySerialNoResponse>"></exception>
		public async Task<M3Response<LstBySerialNoResponse>> LstBySerialNo(
			string m3SERN, 
			string m3ITNO = null, 
			string m3BRAN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstBySerialNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));

			// Set mandatory parameters
			request
				.WithQueryParameter("SERN", m3SERN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRAN))
				request.WithQueryParameter("BRAN", m3BRAN.Trim());

			// Execute the request
			var result = await Execute<LstBySerialNoResponse>(
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
		/// Name Reclassify
		/// Description Reclassify
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3NSER">New serial number (Required)</param>
		/// <param name="m3NITN">New item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ReclassifyResponse></returns>
		/// <exception cref="M3Exception<ReclassifyResponse>"></exception>
		public async Task<M3Response<ReclassifyResponse>> Reclassify(
			string m3ITNO, 
			string m3SERN, 
			string m3NSER, 
			string m3NITN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Reclassify",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));
			if (string.IsNullOrWhiteSpace(m3NSER))
				throw new ArgumentNullException(nameof(m3NSER));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim())
				.WithQueryParameter("NSER", m3NSER.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3NITN))
				request.WithQueryParameter("NITN", m3NITN.Trim());

			// Execute the request
			var result = await Execute<ReclassifyResponse>(
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
		/// Name SearchEquipment
		/// Description Search equipment
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchEquipmentResponse></returns>
		/// <exception cref="M3Exception<SearchEquipmentResponse>"></exception>
		public async Task<M3Response<SearchEquipmentResponse>> SearchEquipment(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SearchEquipment",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SQRY))
				throw new ArgumentNullException(nameof(m3SQRY));

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchEquipmentResponse>(
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
		/// Description Update Item/Serialnumber
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ASID">Fixed asset</param>
		/// <param name="m3SBNO">Subnumber</param>
		/// <param name="m3ABBD">Buy-back date</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3WADT">Warranty date</param>
		/// <param name="m3WAGR">Warranty agreement</param>
		/// <param name="m3WAL1">Warranty limit 1</param>
		/// <param name="m3WAL2">Warranty limit 2</param>
		/// <param name="m3WAL3">Warranty limit 3</param>
		/// <param name="m3WAL4">Warranty limit 4</param>
		/// <param name="m3NESA">Next shop action type</param>
		/// <param name="m3NSUF">Next service</param>
		/// <param name="m3MPGM">Maintenance program</param>
		/// <param name="m3MAPL">Planner - maintenance</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3FCCM">Forecast logic</param>
		/// <param name="m3PUPR">Purchase price</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3PPDT">Purchase price date</param>
		/// <param name="m3BIRT">Origin identity</param>
		/// <param name="m3BIRS">Date introduced into Movex</param>
		/// <param name="m3ALII">Equipment description</param>
		/// <param name="m3DPID">Period frame</param>
		/// <param name="m3CONC">Continuous net change</param>
		/// <param name="m3PLMZ">Planning horizon</param>
		/// <param name="m3SHRE">Percentage of cost price</param>
		/// <param name="m3INSN">Insurance number</param>
		/// <param name="m3EQNO">Equipment number</param>
		/// <param name="m3EQNL">Field not used</param>
		/// <param name="m3PRIP">Priority</param>
		/// <param name="m3PRSS">Process</param>
		/// <param name="m3SBPR">Subprocess</param>
		/// <param name="m3AESC">Criticality class</param>
		/// <param name="m3TEFF">Target availability</param>
		/// <param name="m3DWTC">Downtime cost</param>
		/// <param name="m3CMDD">Commission date</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3MFDT">Manufacturing date</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3MLYR">Year model</param>
		/// <param name="m3AREA">Location description</param>
		/// <param name="m3LOCS">Location</param>
		/// <param name="m3BRAN">Brand</param>
		/// <param name="m3EQTP">Equipment type</param>
		/// <param name="m3EQGR">Equipment group</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3INDA">Installation date</param>
		/// <param name="m3SNRC">Serial number return code</param>
		/// <param name="m3RFIA">Asset tag</param>
		/// <param name="m3AAGN">Agreement number</param>
		/// <param name="m3FLEE">Fleet</param>
		/// <param name="m3COCE">Cost center</param>
		/// <param name="m3FLNO">Fleet number</param>
		/// <param name="m3SKEY">Search key equipment</param>
		/// <param name="m3LAMA">Minimum accepted contributn margin ratio</param>
		/// <param name="m3ASLM">Sales model</param>
		/// <param name="m3APRM">Price model</param>
		/// <param name="m3ADLM">Dealer model</param>
		/// <param name="m3ACMC">Compatibility code</param>
		/// <param name="m3CFI1">User-defined field 1 - item</param>
		/// <param name="m3CFI2">User-defined field 2 - item</param>
		/// <param name="m3CFI3">User-defined field 3 - item</param>
		/// <param name="m3CFI4">User-defined field 4 - item</param>
		/// <param name="m3CFI5">User-defined field 5 - item</param>
		/// <param name="m3CUOW">Owner</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3OWTP">Ownership type</param>
		/// <param name="m3PUEX">Publish External</param>
		/// <param name="m3PUNO">purchase order number</param>
		/// <param name="m3PNLI">Purchase order line number</param>
		/// <param name="m3PNLS">Purchase order line subnumber</param>
		/// <param name="m3OWNC">OWNC</param>
		/// <param name="m3LKDT">like kind date</param>
		/// <param name="m3LKST">like kind status</param>
		/// <param name="m3TAIL">Registration number/site</param>
		/// <param name="m3OENV">Operating Enviroment</param>
		/// <param name="m3EQCL">Equipment class</param>
		/// <param name="m3TXID">Text Identity</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3ITNO, 
			string m3SERN, 
			int? m3CONO = null, 
			string m3ASID = null, 
			int? m3SBNO = null, 
			DateTime? m3ABBD = null, 
			string m3STAT = null, 
			DateTime? m3WADT = null, 
			string m3WAGR = null, 
			decimal? m3WAL1 = null, 
			decimal? m3WAL2 = null, 
			decimal? m3WAL3 = null, 
			decimal? m3WAL4 = null, 
			string m3NESA = null, 
			string m3NSUF = null, 
			string m3MPGM = null, 
			string m3MAPL = null, 
			string m3CUNO = null, 
			string m3FCCM = null, 
			decimal? m3PUPR = null, 
			string m3CUCD = null, 
			DateTime? m3PPDT = null, 
			long? m3BIRT = null, 
			DateTime? m3BIRS = null, 
			string m3ALII = null, 
			int? m3DPID = null, 
			int? m3CONC = null, 
			int? m3PLMZ = null, 
			int? m3SHRE = null, 
			string m3INSN = null, 
			string m3EQNO = null, 
			int? m3EQNL = null, 
			string m3PRIP = null, 
			string m3PRSS = null, 
			string m3SBPR = null, 
			int? m3AESC = null, 
			decimal? m3TEFF = null, 
			decimal? m3DWTC = null, 
			DateTime? m3CMDD = null, 
			string m3FACI = null, 
			DateTime? m3MFDT = null, 
			string m3PLGR = null, 
			string m3MLYR = null, 
			string m3AREA = null, 
			string m3LOCS = null, 
			string m3BRAN = null, 
			string m3EQTP = null, 
			string m3EQGR = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			DateTime? m3INDA = null, 
			int? m3SNRC = null, 
			string m3RFIA = null, 
			string m3AAGN = null, 
			string m3FLEE = null, 
			string m3COCE = null, 
			string m3FLNO = null, 
			string m3SKEY = null, 
			int? m3LAMA = null, 
			string m3ASLM = null, 
			string m3APRM = null, 
			string m3ADLM = null, 
			string m3ACMC = null, 
			string m3CFI1 = null, 
			decimal? m3CFI2 = null, 
			string m3CFI3 = null, 
			string m3CFI4 = null, 
			string m3CFI5 = null, 
			string m3CUOW = null, 
			string m3ADID = null, 
			string m3OWTP = null, 
			int? m3PUEX = null, 
			string m3PUNO = null, 
			int? m3PNLI = null, 
			int? m3PNLS = null, 
			string m3OWNC = null, 
			DateTime? m3LKDT = null, 
			string m3LKST = null, 
			string m3TAIL = null, 
			string m3OENV = null, 
			string m3EQCL = null, 
			decimal? m3TXID = null, 
			string m3SUNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ASID))
				request.WithQueryParameter("ASID", m3ASID.Trim());
			if (m3SBNO.HasValue)
				request.WithQueryParameter("SBNO", m3SBNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ABBD.HasValue)
				request.WithQueryParameter("ABBD", m3ABBD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3WADT.HasValue)
				request.WithQueryParameter("WADT", m3WADT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3WAGR))
				request.WithQueryParameter("WAGR", m3WAGR.Trim());
			if (m3WAL1.HasValue)
				request.WithQueryParameter("WAL1", m3WAL1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAL2.HasValue)
				request.WithQueryParameter("WAL2", m3WAL2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAL3.HasValue)
				request.WithQueryParameter("WAL3", m3WAL3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAL4.HasValue)
				request.WithQueryParameter("WAL4", m3WAL4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NESA))
				request.WithQueryParameter("NESA", m3NESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3NSUF))
				request.WithQueryParameter("NSUF", m3NSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3MPGM))
				request.WithQueryParameter("MPGM", m3MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3MAPL))
				request.WithQueryParameter("MAPL", m3MAPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCCM))
				request.WithQueryParameter("FCCM", m3FCCM.Trim());
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3PPDT.HasValue)
				request.WithQueryParameter("PPDT", m3PPDT.Value.ToM3String());
			if (m3BIRT.HasValue)
				request.WithQueryParameter("BIRT", m3BIRT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BIRS.HasValue)
				request.WithQueryParameter("BIRS", m3BIRS.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ALII))
				request.WithQueryParameter("ALII", m3ALII.Trim());
			if (m3DPID.HasValue)
				request.WithQueryParameter("DPID", m3DPID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CONC.HasValue)
				request.WithQueryParameter("CONC", m3CONC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLMZ.HasValue)
				request.WithQueryParameter("PLMZ", m3PLMZ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHRE.HasValue)
				request.WithQueryParameter("SHRE", m3SHRE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INSN))
				request.WithQueryParameter("INSN", m3INSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQNO))
				request.WithQueryParameter("EQNO", m3EQNO.Trim());
			if (m3EQNL.HasValue)
				request.WithQueryParameter("EQNL", m3EQNL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRIP))
				request.WithQueryParameter("PRIP", m3PRIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRSS))
				request.WithQueryParameter("PRSS", m3PRSS.Trim());
			if (!string.IsNullOrWhiteSpace(m3SBPR))
				request.WithQueryParameter("SBPR", m3SBPR.Trim());
			if (m3AESC.HasValue)
				request.WithQueryParameter("AESC", m3AESC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TEFF.HasValue)
				request.WithQueryParameter("TEFF", m3TEFF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DWTC.HasValue)
				request.WithQueryParameter("DWTC", m3DWTC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CMDD.HasValue)
				request.WithQueryParameter("CMDD", m3CMDD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (m3MFDT.HasValue)
				request.WithQueryParameter("MFDT", m3MFDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3MLYR))
				request.WithQueryParameter("MLYR", m3MLYR.Trim());
			if (!string.IsNullOrWhiteSpace(m3AREA))
				request.WithQueryParameter("AREA", m3AREA.Trim());
			if (!string.IsNullOrWhiteSpace(m3LOCS))
				request.WithQueryParameter("LOCS", m3LOCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRAN))
				request.WithQueryParameter("BRAN", m3BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQTP))
				request.WithQueryParameter("EQTP", m3EQTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQGR))
				request.WithQueryParameter("EQGR", m3EQGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (m3INDA.HasValue)
				request.WithQueryParameter("INDA", m3INDA.Value.ToM3String());
			if (m3SNRC.HasValue)
				request.WithQueryParameter("SNRC", m3SNRC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RFIA))
				request.WithQueryParameter("RFIA", m3RFIA.Trim());
			if (!string.IsNullOrWhiteSpace(m3AAGN))
				request.WithQueryParameter("AAGN", m3AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLEE))
				request.WithQueryParameter("FLEE", m3FLEE.Trim());
			if (!string.IsNullOrWhiteSpace(m3COCE))
				request.WithQueryParameter("COCE", m3COCE.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLNO))
				request.WithQueryParameter("FLNO", m3FLNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SKEY))
				request.WithQueryParameter("SKEY", m3SKEY.Trim());
			if (m3LAMA.HasValue)
				request.WithQueryParameter("LAMA", m3LAMA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ASLM))
				request.WithQueryParameter("ASLM", m3ASLM.Trim());
			if (!string.IsNullOrWhiteSpace(m3APRM))
				request.WithQueryParameter("APRM", m3APRM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADLM))
				request.WithQueryParameter("ADLM", m3ADLM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACMC))
				request.WithQueryParameter("ACMC", m3ACMC.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3CUOW))
				request.WithQueryParameter("CUOW", m3CUOW.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3OWTP))
				request.WithQueryParameter("OWTP", m3OWTP.Trim());
			if (m3PUEX.HasValue)
				request.WithQueryParameter("PUEX", m3PUEX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PUNO))
				request.WithQueryParameter("PUNO", m3PUNO.Trim());
			if (m3PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3PNLI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3PNLS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OWNC))
				request.WithQueryParameter("OWNC", m3OWNC.Trim());
			if (m3LKDT.HasValue)
				request.WithQueryParameter("LKDT", m3LKDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3LKST))
				request.WithQueryParameter("LKST", m3LKST.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAIL))
				request.WithQueryParameter("TAIL", m3TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3OENV))
				request.WithQueryParameter("OENV", m3OENV.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQCL))
				request.WithQueryParameter("EQCL", m3EQCL.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());

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
		/// Name UpdEquipment
		/// Description Upd Equipment
		/// Version Release: 5ea5
		/// </summary>
		/// <param name="m3EQNO">Equipment number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ASID">Fixed asset</param>
		/// <param name="m3SBNO">Subnumber</param>
		/// <param name="m3ABBD">Buy-back date</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3WADT">Warranty date</param>
		/// <param name="m3WAGR">Warranty agreement</param>
		/// <param name="m3WAL1">Warranty limit 1</param>
		/// <param name="m3WAL2">Warranty limit 2</param>
		/// <param name="m3WAL3">Warranty limit 3</param>
		/// <param name="m3WAL4">Warranty limit 4</param>
		/// <param name="m3NESA">Next shop action type</param>
		/// <param name="m3NSUF">Next service</param>
		/// <param name="m3MPGM">Maintenance program</param>
		/// <param name="m3MAPL">Planner - maintenance</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3FCCM">Forecast logic</param>
		/// <param name="m3PUPR">Purchase price</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3PPDT">Purchase price date</param>
		/// <param name="m3BIRT">Origin identity</param>
		/// <param name="m3BIRS">Date introduced into Movex</param>
		/// <param name="m3ALII">Equipment description</param>
		/// <param name="m3DPID">Period frame</param>
		/// <param name="m3CONC">Continuous net change</param>
		/// <param name="m3PLMZ">Planning horizon</param>
		/// <param name="m3SHRE">Percentage of cost price</param>
		/// <param name="m3INSN">Insurance number</param>
		/// <param name="m3EQNL">Field not used</param>
		/// <param name="m3PRIP">Priority</param>
		/// <param name="m3PRSS">Process</param>
		/// <param name="m3SBPR">Subprocess</param>
		/// <param name="m3AESC">Criticality class</param>
		/// <param name="m3TEFF">Target availability</param>
		/// <param name="m3DWTC">Downtime cost</param>
		/// <param name="m3CMDD">Commission date</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3MFDT">Manufacturing date</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3MLYR">Year model</param>
		/// <param name="m3AREA">Location description</param>
		/// <param name="m3LOCS">Location</param>
		/// <param name="m3BRAN">Brand</param>
		/// <param name="m3EQTP">Equipment type</param>
		/// <param name="m3EQGR">Equipment group</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3EQGC">Equipment group category</param>
		/// <param name="m3INDA">Installation date</param>
		/// <param name="m3SNRC">Serial number return code</param>
		/// <param name="m3RFIA">Asset tag</param>
		/// <param name="m3OWNC">Owner</param>
		/// <param name="m3MFIT">Supplier/manufacturer item number</param>
		/// <param name="m3MFSN">Manufacturer serial number</param>
		/// <param name="m3COCE">Cost center</param>
		/// <param name="m3FLNO">Fleet number</param>
		/// <param name="m3SKEY">Search key equipment</param>
		/// <param name="m3LAMA">Minimum accepted contributn margin ratio</param>
		/// <param name="m3PUNO">Purchase order number</param>
		/// <param name="m3PNLI">Purchase order line number</param>
		/// <param name="m3PNLS">Purchase order line subnumber</param>
		/// <param name="m3OENV">Operating Enviroment</param>
		/// <param name="m3EQCL">Equipment class</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdEquipment(
			string m3EQNO, 
			int? m3CONO = null, 
			string m3ASID = null, 
			int? m3SBNO = null, 
			DateTime? m3ABBD = null, 
			string m3STAT = null, 
			DateTime? m3WADT = null, 
			string m3WAGR = null, 
			decimal? m3WAL1 = null, 
			decimal? m3WAL2 = null, 
			decimal? m3WAL3 = null, 
			decimal? m3WAL4 = null, 
			string m3NESA = null, 
			string m3NSUF = null, 
			string m3MPGM = null, 
			string m3MAPL = null, 
			string m3CUNO = null, 
			string m3FCCM = null, 
			decimal? m3PUPR = null, 
			string m3CUCD = null, 
			DateTime? m3PPDT = null, 
			long? m3BIRT = null, 
			DateTime? m3BIRS = null, 
			string m3ALII = null, 
			int? m3DPID = null, 
			int? m3CONC = null, 
			int? m3PLMZ = null, 
			int? m3SHRE = null, 
			string m3INSN = null, 
			int? m3EQNL = null, 
			string m3PRIP = null, 
			string m3PRSS = null, 
			string m3SBPR = null, 
			int? m3AESC = null, 
			decimal? m3TEFF = null, 
			decimal? m3DWTC = null, 
			DateTime? m3CMDD = null, 
			string m3FACI = null, 
			DateTime? m3MFDT = null, 
			string m3PLGR = null, 
			string m3MLYR = null, 
			string m3AREA = null, 
			string m3LOCS = null, 
			string m3BRAN = null, 
			string m3EQTP = null, 
			string m3EQGR = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3EQGC = null, 
			DateTime? m3INDA = null, 
			int? m3SNRC = null, 
			string m3RFIA = null, 
			string m3OWNC = null, 
			string m3MFIT = null, 
			string m3MFSN = null, 
			string m3COCE = null, 
			string m3FLNO = null, 
			string m3SKEY = null, 
			int? m3LAMA = null, 
			string m3PUNO = null, 
			int? m3PNLI = null, 
			int? m3PNLS = null, 
			string m3OENV = null, 
			string m3EQCL = null, 
			string m3ACRF = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdEquipment",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EQNO))
				throw new ArgumentNullException(nameof(m3EQNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("EQNO", m3EQNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ASID))
				request.WithQueryParameter("ASID", m3ASID.Trim());
			if (m3SBNO.HasValue)
				request.WithQueryParameter("SBNO", m3SBNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ABBD.HasValue)
				request.WithQueryParameter("ABBD", m3ABBD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3WADT.HasValue)
				request.WithQueryParameter("WADT", m3WADT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3WAGR))
				request.WithQueryParameter("WAGR", m3WAGR.Trim());
			if (m3WAL1.HasValue)
				request.WithQueryParameter("WAL1", m3WAL1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAL2.HasValue)
				request.WithQueryParameter("WAL2", m3WAL2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAL3.HasValue)
				request.WithQueryParameter("WAL3", m3WAL3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WAL4.HasValue)
				request.WithQueryParameter("WAL4", m3WAL4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NESA))
				request.WithQueryParameter("NESA", m3NESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3NSUF))
				request.WithQueryParameter("NSUF", m3NSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3MPGM))
				request.WithQueryParameter("MPGM", m3MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3MAPL))
				request.WithQueryParameter("MAPL", m3MAPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCCM))
				request.WithQueryParameter("FCCM", m3FCCM.Trim());
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3PPDT.HasValue)
				request.WithQueryParameter("PPDT", m3PPDT.Value.ToM3String());
			if (m3BIRT.HasValue)
				request.WithQueryParameter("BIRT", m3BIRT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BIRS.HasValue)
				request.WithQueryParameter("BIRS", m3BIRS.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ALII))
				request.WithQueryParameter("ALII", m3ALII.Trim());
			if (m3DPID.HasValue)
				request.WithQueryParameter("DPID", m3DPID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CONC.HasValue)
				request.WithQueryParameter("CONC", m3CONC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLMZ.HasValue)
				request.WithQueryParameter("PLMZ", m3PLMZ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHRE.HasValue)
				request.WithQueryParameter("SHRE", m3SHRE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INSN))
				request.WithQueryParameter("INSN", m3INSN.Trim());
			if (m3EQNL.HasValue)
				request.WithQueryParameter("EQNL", m3EQNL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRIP))
				request.WithQueryParameter("PRIP", m3PRIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRSS))
				request.WithQueryParameter("PRSS", m3PRSS.Trim());
			if (!string.IsNullOrWhiteSpace(m3SBPR))
				request.WithQueryParameter("SBPR", m3SBPR.Trim());
			if (m3AESC.HasValue)
				request.WithQueryParameter("AESC", m3AESC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TEFF.HasValue)
				request.WithQueryParameter("TEFF", m3TEFF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DWTC.HasValue)
				request.WithQueryParameter("DWTC", m3DWTC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CMDD.HasValue)
				request.WithQueryParameter("CMDD", m3CMDD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (m3MFDT.HasValue)
				request.WithQueryParameter("MFDT", m3MFDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3MLYR))
				request.WithQueryParameter("MLYR", m3MLYR.Trim());
			if (!string.IsNullOrWhiteSpace(m3AREA))
				request.WithQueryParameter("AREA", m3AREA.Trim());
			if (!string.IsNullOrWhiteSpace(m3LOCS))
				request.WithQueryParameter("LOCS", m3LOCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRAN))
				request.WithQueryParameter("BRAN", m3BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQTP))
				request.WithQueryParameter("EQTP", m3EQTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQGR))
				request.WithQueryParameter("EQGR", m3EQGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQGC))
				request.WithQueryParameter("EQGC", m3EQGC.Trim());
			if (m3INDA.HasValue)
				request.WithQueryParameter("INDA", m3INDA.Value.ToM3String());
			if (m3SNRC.HasValue)
				request.WithQueryParameter("SNRC", m3SNRC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RFIA))
				request.WithQueryParameter("RFIA", m3RFIA.Trim());
			if (!string.IsNullOrWhiteSpace(m3OWNC))
				request.WithQueryParameter("OWNC", m3OWNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3MFIT))
				request.WithQueryParameter("MFIT", m3MFIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3MFSN))
				request.WithQueryParameter("MFSN", m3MFSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3COCE))
				request.WithQueryParameter("COCE", m3COCE.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLNO))
				request.WithQueryParameter("FLNO", m3FLNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SKEY))
				request.WithQueryParameter("SKEY", m3SKEY.Trim());
			if (m3LAMA.HasValue)
				request.WithQueryParameter("LAMA", m3LAMA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PUNO))
				request.WithQueryParameter("PUNO", m3PUNO.Trim());
			if (m3PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3PNLI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3PNLS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OENV))
				request.WithQueryParameter("OENV", m3OENV.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQCL))
				request.WithQueryParameter("EQCL", m3EQCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());

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
		/// Name UpdOEM
		/// Description Update OEM Codes
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3CONO">Company</param>
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
		public async Task<M3Response<M3Record>> UpdOEM(
			string m3ITNO, 
			string m3SERN, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdOEM",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
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
	}
}
// EOF
