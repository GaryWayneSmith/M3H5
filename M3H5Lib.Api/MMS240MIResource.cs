/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add Item/Serialnumber
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_ASID">Fixed asset</param>
		/// <param name="m3_SBNO">Subnumber</param>
		/// <param name="m3_ABBD">Buy-back date</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_WADT">Warranty date</param>
		/// <param name="m3_WAGR">Warranty agreement</param>
		/// <param name="m3_WAL1">Warranty limit 1</param>
		/// <param name="m3_WAL2">Warranty limit 2</param>
		/// <param name="m3_WAL3">Warranty limit 3</param>
		/// <param name="m3_WAL4">Warranty limit 4</param>
		/// <param name="m3_NESA">Next shop action type</param>
		/// <param name="m3_NSUF">Next service</param>
		/// <param name="m3_MPGM">Maintenance program</param>
		/// <param name="m3_MAPL">Planner - maintenance</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_FCCM">Forecast logic</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_PPDT">Purchase price date</param>
		/// <param name="m3_BIRT">Origin identity</param>
		/// <param name="m3_BIRS">Date introduced into Movex</param>
		/// <param name="m3_ALII">Equipment description</param>
		/// <param name="m3_DPID">Period frame</param>
		/// <param name="m3_CONC">Continuous net change</param>
		/// <param name="m3_PLMZ">Planning horizon</param>
		/// <param name="m3_SHRE">Percentage of cost price</param>
		/// <param name="m3_INSN">Insurance number</param>
		/// <param name="m3_EQNO">Equipment number</param>
		/// <param name="m3_EQNL">Field not used</param>
		/// <param name="m3_PRIP">Priority</param>
		/// <param name="m3_PRSS">Process</param>
		/// <param name="m3_SBPR">Subprocess</param>
		/// <param name="m3_AESC">Criticality class</param>
		/// <param name="m3_TEFF">Target availability</param>
		/// <param name="m3_DWTC">Downtime cost</param>
		/// <param name="m3_CMDD">Commission date</param>
		/// <param name="m3_MFDT">Manufacturing date</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_DTID">Data identity</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_MLYR">Year model</param>
		/// <param name="m3_AREA">Location description</param>
		/// <param name="m3_LOCS">Location</param>
		/// <param name="m3_BRAN">Brand</param>
		/// <param name="m3_EQTP">Equipment type</param>
		/// <param name="m3_EQGR">Equipment group</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_INDA">Installation date</param>
		/// <param name="m3_SNRC">Serial number return code</param>
		/// <param name="m3_RFIA">Asset tag</param>
		/// <param name="m3_TAIL">Registration number/site</param>
		/// <param name="m3_AAGN">Agreement number</param>
		/// <param name="m3_FLEE">Fleet</param>
		/// <param name="m3_COCE">Cost center</param>
		/// <param name="m3_FLNO">Fleet number</param>
		/// <param name="m3_SKEY">Search key equipment</param>
		/// <param name="m3_LAMA">Minimum accepted contributn margin ratio</param>
		/// <param name="m3_ASLM">Sales model</param>
		/// <param name="m3_APRM">Price model</param>
		/// <param name="m3_ADLM">Dealer model</param>
		/// <param name="m3_ACMC">Compatibility code</param>
		/// <param name="m3_CFI1">User-defined field 1 - item</param>
		/// <param name="m3_CFI2">User-defined field 2 - item</param>
		/// <param name="m3_CFI3">User-defined field 3 - item</param>
		/// <param name="m3_CFI4">User-defined field 4 - item</param>
		/// <param name="m3_CFI5">User-defined field 5 - item</param>
		/// <param name="m3_CUOW">Owner</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_OWTP">Ownership type</param>
		/// <param name="m3_PUEX">Publish External</param>
		/// <param name="m3_PUNO">Purchase order number</param>
		/// <param name="m3_PNLI">Purchase order line</param>
		/// <param name="m3_PNLS">Purchsase order line subnumber</param>
		/// <param name="m3_OWNC">Owner</param>
		/// <param name="m3_LKST">like kind status</param>
		/// <param name="m3_LKDT">like kind date</param>
		/// <param name="m3_EQCL">Equipment class</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddResponse></returns>
		/// <exception cref="M3Exception<AddResponse>"></exception>
		public async Task<M3Response<AddResponse>> Add(
			string m3_ITNO, 
			string m3_FACI, 
			int? m3_CONO = null, 
			string m3_SERN = null, 
			string m3_ASID = null, 
			int? m3_SBNO = null, 
			DateTime? m3_ABBD = null, 
			string m3_STAT = null, 
			DateTime? m3_WADT = null, 
			string m3_WAGR = null, 
			decimal? m3_WAL1 = null, 
			decimal? m3_WAL2 = null, 
			decimal? m3_WAL3 = null, 
			decimal? m3_WAL4 = null, 
			string m3_NESA = null, 
			string m3_NSUF = null, 
			string m3_MPGM = null, 
			string m3_MAPL = null, 
			string m3_CUNO = null, 
			string m3_FCCM = null, 
			decimal? m3_PUPR = null, 
			string m3_CUCD = null, 
			DateTime? m3_PPDT = null, 
			long? m3_BIRT = null, 
			DateTime? m3_BIRS = null, 
			string m3_ALII = null, 
			int? m3_DPID = null, 
			int? m3_CONC = null, 
			int? m3_PLMZ = null, 
			int? m3_SHRE = null, 
			string m3_INSN = null, 
			string m3_EQNO = null, 
			int? m3_EQNL = null, 
			string m3_PRIP = null, 
			string m3_PRSS = null, 
			string m3_SBPR = null, 
			int? m3_AESC = null, 
			decimal? m3_TEFF = null, 
			decimal? m3_DWTC = null, 
			DateTime? m3_CMDD = null, 
			DateTime? m3_MFDT = null, 
			string m3_PLGR = null, 
			decimal? m3_DTID = null, 
			decimal? m3_TXID = null, 
			string m3_MLYR = null, 
			string m3_AREA = null, 
			string m3_LOCS = null, 
			string m3_BRAN = null, 
			string m3_EQTP = null, 
			string m3_EQGR = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			DateTime? m3_INDA = null, 
			int? m3_SNRC = null, 
			string m3_RFIA = null, 
			string m3_TAIL = null, 
			string m3_AAGN = null, 
			string m3_FLEE = null, 
			string m3_COCE = null, 
			string m3_FLNO = null, 
			string m3_SKEY = null, 
			int? m3_LAMA = null, 
			string m3_ASLM = null, 
			string m3_APRM = null, 
			string m3_ADLM = null, 
			string m3_ACMC = null, 
			string m3_CFI1 = null, 
			decimal? m3_CFI2 = null, 
			string m3_CFI3 = null, 
			string m3_CFI4 = null, 
			string m3_CFI5 = null, 
			string m3_CUOW = null, 
			string m3_ADID = null, 
			string m3_OWTP = null, 
			int? m3_PUEX = null, 
			string m3_PUNO = null, 
			int? m3_PNLI = null, 
			int? m3_PNLS = null, 
			string m3_OWNC = null, 
			string m3_LKST = null, 
			DateTime? m3_LKDT = null, 
			string m3_EQCL = null, 
			string m3_SUNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ASID))
				request.WithQueryParameter("ASID", m3_ASID.Trim());
			if (m3_SBNO.HasValue)
				request.WithQueryParameter("SBNO", m3_SBNO.Value.ToString());
			if (m3_ABBD.HasValue)
				request.WithQueryParameter("ABBD", m3_ABBD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_WADT.HasValue)
				request.WithQueryParameter("WADT", m3_WADT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_WAGR))
				request.WithQueryParameter("WAGR", m3_WAGR.Trim());
			if (m3_WAL1.HasValue)
				request.WithQueryParameter("WAL1", m3_WAL1.Value.ToString());
			if (m3_WAL2.HasValue)
				request.WithQueryParameter("WAL2", m3_WAL2.Value.ToString());
			if (m3_WAL3.HasValue)
				request.WithQueryParameter("WAL3", m3_WAL3.Value.ToString());
			if (m3_WAL4.HasValue)
				request.WithQueryParameter("WAL4", m3_WAL4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NESA))
				request.WithQueryParameter("NESA", m3_NESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NSUF))
				request.WithQueryParameter("NSUF", m3_NSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MPGM))
				request.WithQueryParameter("MPGM", m3_MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MAPL))
				request.WithQueryParameter("MAPL", m3_MAPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCCM))
				request.WithQueryParameter("FCCM", m3_FCCM.Trim());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_PPDT.HasValue)
				request.WithQueryParameter("PPDT", m3_PPDT.Value.ToM3String());
			if (m3_BIRT.HasValue)
				request.WithQueryParameter("BIRT", m3_BIRT.Value.ToString());
			if (m3_BIRS.HasValue)
				request.WithQueryParameter("BIRS", m3_BIRS.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ALII))
				request.WithQueryParameter("ALII", m3_ALII.Trim());
			if (m3_DPID.HasValue)
				request.WithQueryParameter("DPID", m3_DPID.Value.ToString());
			if (m3_CONC.HasValue)
				request.WithQueryParameter("CONC", m3_CONC.Value.ToString());
			if (m3_PLMZ.HasValue)
				request.WithQueryParameter("PLMZ", m3_PLMZ.Value.ToString());
			if (m3_SHRE.HasValue)
				request.WithQueryParameter("SHRE", m3_SHRE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INSN))
				request.WithQueryParameter("INSN", m3_INSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQNO))
				request.WithQueryParameter("EQNO", m3_EQNO.Trim());
			if (m3_EQNL.HasValue)
				request.WithQueryParameter("EQNL", m3_EQNL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRIP))
				request.WithQueryParameter("PRIP", m3_PRIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRSS))
				request.WithQueryParameter("PRSS", m3_PRSS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SBPR))
				request.WithQueryParameter("SBPR", m3_SBPR.Trim());
			if (m3_AESC.HasValue)
				request.WithQueryParameter("AESC", m3_AESC.Value.ToString());
			if (m3_TEFF.HasValue)
				request.WithQueryParameter("TEFF", m3_TEFF.Value.ToString());
			if (m3_DWTC.HasValue)
				request.WithQueryParameter("DWTC", m3_DWTC.Value.ToString());
			if (m3_CMDD.HasValue)
				request.WithQueryParameter("CMDD", m3_CMDD.Value.ToM3String());
			if (m3_MFDT.HasValue)
				request.WithQueryParameter("MFDT", m3_MFDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (m3_DTID.HasValue)
				request.WithQueryParameter("DTID", m3_DTID.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MLYR))
				request.WithQueryParameter("MLYR", m3_MLYR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AREA))
				request.WithQueryParameter("AREA", m3_AREA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LOCS))
				request.WithQueryParameter("LOCS", m3_LOCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRAN))
				request.WithQueryParameter("BRAN", m3_BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQTP))
				request.WithQueryParameter("EQTP", m3_EQTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQGR))
				request.WithQueryParameter("EQGR", m3_EQGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (m3_INDA.HasValue)
				request.WithQueryParameter("INDA", m3_INDA.Value.ToM3String());
			if (m3_SNRC.HasValue)
				request.WithQueryParameter("SNRC", m3_SNRC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RFIA))
				request.WithQueryParameter("RFIA", m3_RFIA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAIL))
				request.WithQueryParameter("TAIL", m3_TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AAGN))
				request.WithQueryParameter("AAGN", m3_AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLEE))
				request.WithQueryParameter("FLEE", m3_FLEE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COCE))
				request.WithQueryParameter("COCE", m3_COCE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLNO))
				request.WithQueryParameter("FLNO", m3_FLNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SKEY))
				request.WithQueryParameter("SKEY", m3_SKEY.Trim());
			if (m3_LAMA.HasValue)
				request.WithQueryParameter("LAMA", m3_LAMA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ASLM))
				request.WithQueryParameter("ASLM", m3_ASLM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APRM))
				request.WithQueryParameter("APRM", m3_APRM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADLM))
				request.WithQueryParameter("ADLM", m3_ADLM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACMC))
				request.WithQueryParameter("ACMC", m3_ACMC.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_CUOW))
				request.WithQueryParameter("CUOW", m3_CUOW.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OWTP))
				request.WithQueryParameter("OWTP", m3_OWTP.Trim());
			if (m3_PUEX.HasValue)
				request.WithQueryParameter("PUEX", m3_PUEX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PUNO))
				request.WithQueryParameter("PUNO", m3_PUNO.Trim());
			if (m3_PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3_PNLI.Value.ToString());
			if (m3_PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3_PNLS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OWNC))
				request.WithQueryParameter("OWNC", m3_OWNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LKST))
				request.WithQueryParameter("LKST", m3_LKST.Trim());
			if (m3_LKDT.HasValue)
				request.WithQueryParameter("LKDT", m3_LKDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_EQCL))
				request.WithQueryParameter("EQCL", m3_EQCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Execute the request
			var result = await Execute<AddResponse>(
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
		/// Name AddEquipment
		/// Description Add Equipment
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_EQNO">Equipment number (Required)</param>
		/// <param name="m3_TAIL">Registration number/site (Required)</param>
		/// <param name="m3_ITTY">Item type (Required)</param>
		/// <param name="m3_ITDS">Name (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STCD">Inventory accounting</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_CFGH">NHA configuration position</param>
		/// <param name="m3_POEQ">Position/equipment</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_ITCL">Product group</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_PRIP">Priority</param>
		/// <param name="m3_ALII">Equipment description</param>
		/// <param name="m3_TEFF">Target availability</param>
		/// <param name="m3_DWTC">Downtime cost</param>
		/// <param name="m3_PRSS">Process</param>
		/// <param name="m3_SBPR">Subprocess</param>
		/// <param name="m3_AESC">Criticality class</param>
		/// <param name="m3_INSN">Insurance number</param>
		/// <param name="m3_INDA">Installation date</param>
		/// <param name="m3_INTS">Installation time</param>
		/// <param name="m3_CMDD">Commission date</param>
		/// <param name="m3_ASID">Fixed asset</param>
		/// <param name="m3_SBNO">Subnumber</param>
		/// <param name="m3_ABBD">Buy-back date</param>
		/// <param name="m3_WADT">Warranty date</param>
		/// <param name="m3_WAGR">Warranty agreement</param>
		/// <param name="m3_WAL1">Warranty limit 1</param>
		/// <param name="m3_WAL2">Warranty limit 2</param>
		/// <param name="m3_WAL3">Warranty limit 3</param>
		/// <param name="m3_WAL4">Warranty limit 4</param>
		/// <param name="m3_NESA">Next shop action type</param>
		/// <param name="m3_NSUF">Next service</param>
		/// <param name="m3_MPGM">Maintenance program</param>
		/// <param name="m3_MAPL">Planner - maintenance</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_FCCM">Forecast logic</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_PRDT">Purchase price date</param>
		/// <param name="m3_BIRT">Origin identity</param>
		/// <param name="m3_BIRS">Date introduced into Movex</param>
		/// <param name="m3_DPID">Period frame</param>
		/// <param name="m3_CONC">Continuous net change</param>
		/// <param name="m3_PLMZ">Planning horizon</param>
		/// <param name="m3_SHRE">Percentage of cost price</param>
		/// <param name="m3_EQNL">Field not used</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_MFDT">Manufacturing date</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_DTID">Data identity</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_MLYR">Year model</param>
		/// <param name="m3_AREA">Location description</param>
		/// <param name="m3_LOCS">Location</param>
		/// <param name="m3_BRAN">Brand</param>
		/// <param name="m3_EQTP">Equipment type</param>
		/// <param name="m3_EQGR">Equipment group</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_EQGC">Equipment group category</param>
		/// <param name="m3_SNRC">Serial number return code</param>
		/// <param name="m3_RFIA">Asset tag</param>
		/// <param name="m3_OWNC">Owner</param>
		/// <param name="m3_MFIT">Supplier/manufacturer item number</param>
		/// <param name="m3_MFSN">Manufacturer serial number</param>
		/// <param name="m3_COCE">Cost center</param>
		/// <param name="m3_FLNO">Fleet number</param>
		/// <param name="m3_SKEY">Search key equipment</param>
		/// <param name="m3_LAMA">Minimum accepted contributn margin ratio</param>
		/// <param name="m3_PUNO">Purchase order number</param>
		/// <param name="m3_PNLI">Purchase order line</param>
		/// <param name="m3_PNLS">Purchase order  line subnumber</param>
		/// <param name="m3_EQCL">Equipment class</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddEquipmentResponse></returns>
		/// <exception cref="M3Exception<AddEquipmentResponse>"></exception>
		public async Task<M3Response<AddEquipmentResponse>> AddEquipment(
			string m3_EQNO, 
			string m3_TAIL, 
			string m3_ITTY, 
			string m3_ITDS, 
			int? m3_CONO = null, 
			int? m3_STCD = null, 
			string m3_ITNO = null, 
			string m3_SERN = null, 
			string m3_CFGH = null, 
			int? m3_POEQ = null, 
			string m3_ITGR = null, 
			string m3_ITCL = null, 
			string m3_ACRF = null, 
			string m3_STAT = null, 
			string m3_PRIP = null, 
			string m3_ALII = null, 
			decimal? m3_TEFF = null, 
			decimal? m3_DWTC = null, 
			string m3_PRSS = null, 
			string m3_SBPR = null, 
			int? m3_AESC = null, 
			string m3_INSN = null, 
			DateTime? m3_INDA = null, 
			int? m3_INTS = null, 
			DateTime? m3_CMDD = null, 
			string m3_ASID = null, 
			int? m3_SBNO = null, 
			DateTime? m3_ABBD = null, 
			DateTime? m3_WADT = null, 
			string m3_WAGR = null, 
			decimal? m3_WAL1 = null, 
			decimal? m3_WAL2 = null, 
			decimal? m3_WAL3 = null, 
			decimal? m3_WAL4 = null, 
			string m3_NESA = null, 
			string m3_NSUF = null, 
			string m3_MPGM = null, 
			string m3_MAPL = null, 
			string m3_CUNO = null, 
			string m3_FCCM = null, 
			decimal? m3_PUPR = null, 
			string m3_CUCD = null, 
			DateTime? m3_PRDT = null, 
			long? m3_BIRT = null, 
			DateTime? m3_BIRS = null, 
			int? m3_DPID = null, 
			int? m3_CONC = null, 
			int? m3_PLMZ = null, 
			int? m3_SHRE = null, 
			int? m3_EQNL = null, 
			string m3_FACI = null, 
			DateTime? m3_MFDT = null, 
			string m3_PLGR = null, 
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			decimal? m3_DTID = null, 
			decimal? m3_TXID = null, 
			string m3_MLYR = null, 
			string m3_AREA = null, 
			string m3_LOCS = null, 
			string m3_BRAN = null, 
			string m3_EQTP = null, 
			string m3_EQGR = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_EQGC = null, 
			int? m3_SNRC = null, 
			string m3_RFIA = null, 
			string m3_OWNC = null, 
			string m3_MFIT = null, 
			string m3_MFSN = null, 
			string m3_COCE = null, 
			string m3_FLNO = null, 
			string m3_SKEY = null, 
			int? m3_LAMA = null, 
			string m3_PUNO = null, 
			int? m3_PNLI = null, 
			int? m3_PNLS = null, 
			string m3_EQCL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddEquipment",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_EQNO))
				throw new ArgumentNullException("m3_EQNO");
			if (string.IsNullOrWhiteSpace(m3_TAIL))
				throw new ArgumentNullException("m3_TAIL");
			if (string.IsNullOrWhiteSpace(m3_ITTY))
				throw new ArgumentNullException("m3_ITTY");
			if (string.IsNullOrWhiteSpace(m3_ITDS))
				throw new ArgumentNullException("m3_ITDS");

			// Set mandatory parameters
			request
				.WithQueryParameter("EQNO", m3_EQNO.Trim())
				.WithQueryParameter("TAIL", m3_TAIL.Trim())
				.WithQueryParameter("ITTY", m3_ITTY.Trim())
				.WithQueryParameter("ITDS", m3_ITDS.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_STCD.HasValue)
				request.WithQueryParameter("STCD", m3_STCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGH))
				request.WithQueryParameter("CFGH", m3_CFGH.Trim());
			if (m3_POEQ.HasValue)
				request.WithQueryParameter("POEQ", m3_POEQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITCL))
				request.WithQueryParameter("ITCL", m3_ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRIP))
				request.WithQueryParameter("PRIP", m3_PRIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALII))
				request.WithQueryParameter("ALII", m3_ALII.Trim());
			if (m3_TEFF.HasValue)
				request.WithQueryParameter("TEFF", m3_TEFF.Value.ToString());
			if (m3_DWTC.HasValue)
				request.WithQueryParameter("DWTC", m3_DWTC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRSS))
				request.WithQueryParameter("PRSS", m3_PRSS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SBPR))
				request.WithQueryParameter("SBPR", m3_SBPR.Trim());
			if (m3_AESC.HasValue)
				request.WithQueryParameter("AESC", m3_AESC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INSN))
				request.WithQueryParameter("INSN", m3_INSN.Trim());
			if (m3_INDA.HasValue)
				request.WithQueryParameter("INDA", m3_INDA.Value.ToM3String());
			if (m3_INTS.HasValue)
				request.WithQueryParameter("INTS", m3_INTS.Value.ToString());
			if (m3_CMDD.HasValue)
				request.WithQueryParameter("CMDD", m3_CMDD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ASID))
				request.WithQueryParameter("ASID", m3_ASID.Trim());
			if (m3_SBNO.HasValue)
				request.WithQueryParameter("SBNO", m3_SBNO.Value.ToString());
			if (m3_ABBD.HasValue)
				request.WithQueryParameter("ABBD", m3_ABBD.Value.ToM3String());
			if (m3_WADT.HasValue)
				request.WithQueryParameter("WADT", m3_WADT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_WAGR))
				request.WithQueryParameter("WAGR", m3_WAGR.Trim());
			if (m3_WAL1.HasValue)
				request.WithQueryParameter("WAL1", m3_WAL1.Value.ToString());
			if (m3_WAL2.HasValue)
				request.WithQueryParameter("WAL2", m3_WAL2.Value.ToString());
			if (m3_WAL3.HasValue)
				request.WithQueryParameter("WAL3", m3_WAL3.Value.ToString());
			if (m3_WAL4.HasValue)
				request.WithQueryParameter("WAL4", m3_WAL4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NESA))
				request.WithQueryParameter("NESA", m3_NESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NSUF))
				request.WithQueryParameter("NSUF", m3_NSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MPGM))
				request.WithQueryParameter("MPGM", m3_MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MAPL))
				request.WithQueryParameter("MAPL", m3_MAPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCCM))
				request.WithQueryParameter("FCCM", m3_FCCM.Trim());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3_PRDT.Value.ToM3String());
			if (m3_BIRT.HasValue)
				request.WithQueryParameter("BIRT", m3_BIRT.Value.ToString());
			if (m3_BIRS.HasValue)
				request.WithQueryParameter("BIRS", m3_BIRS.Value.ToM3String());
			if (m3_DPID.HasValue)
				request.WithQueryParameter("DPID", m3_DPID.Value.ToString());
			if (m3_CONC.HasValue)
				request.WithQueryParameter("CONC", m3_CONC.Value.ToString());
			if (m3_PLMZ.HasValue)
				request.WithQueryParameter("PLMZ", m3_PLMZ.Value.ToString());
			if (m3_SHRE.HasValue)
				request.WithQueryParameter("SHRE", m3_SHRE.Value.ToString());
			if (m3_EQNL.HasValue)
				request.WithQueryParameter("EQNL", m3_EQNL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (m3_MFDT.HasValue)
				request.WithQueryParameter("MFDT", m3_MFDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_DTID.HasValue)
				request.WithQueryParameter("DTID", m3_DTID.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MLYR))
				request.WithQueryParameter("MLYR", m3_MLYR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AREA))
				request.WithQueryParameter("AREA", m3_AREA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LOCS))
				request.WithQueryParameter("LOCS", m3_LOCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRAN))
				request.WithQueryParameter("BRAN", m3_BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQTP))
				request.WithQueryParameter("EQTP", m3_EQTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQGR))
				request.WithQueryParameter("EQGR", m3_EQGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQGC))
				request.WithQueryParameter("EQGC", m3_EQGC.Trim());
			if (m3_SNRC.HasValue)
				request.WithQueryParameter("SNRC", m3_SNRC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RFIA))
				request.WithQueryParameter("RFIA", m3_RFIA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OWNC))
				request.WithQueryParameter("OWNC", m3_OWNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MFIT))
				request.WithQueryParameter("MFIT", m3_MFIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MFSN))
				request.WithQueryParameter("MFSN", m3_MFSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COCE))
				request.WithQueryParameter("COCE", m3_COCE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLNO))
				request.WithQueryParameter("FLNO", m3_FLNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SKEY))
				request.WithQueryParameter("SKEY", m3_SKEY.Trim());
			if (m3_LAMA.HasValue)
				request.WithQueryParameter("LAMA", m3_LAMA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PUNO))
				request.WithQueryParameter("PUNO", m3_PUNO.Trim());
			if (m3_PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3_PNLI.Value.ToString());
			if (m3_PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3_PNLS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EQCL))
				request.WithQueryParameter("EQCL", m3_EQCL.Trim());

			// Execute the request
			var result = await Execute<AddEquipmentResponse>(
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
		/// Name AddFixedAsset
		/// Description Add Fixed asset
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_ASID">Fixed asset (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_EQNO">Equipment number</param>
		/// <param name="m3_STCD">Inventory accounting</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_TAIL">Registration number/site</param>
		/// <param name="m3_CFGH">NHA configuration position</param>
		/// <param name="m3_POEQ">Position/equipment</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_ITCL">Product group</param>
		/// <param name="m3_ITTY">Item type</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_PRIP">Priority</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_ALII">Equipment description</param>
		/// <param name="m3_TEFF">Target availability</param>
		/// <param name="m3_DWTC">Downtime cost</param>
		/// <param name="m3_PRSS">Process</param>
		/// <param name="m3_SBPR">Subprocess</param>
		/// <param name="m3_AESC">Criticality class</param>
		/// <param name="m3_INSN">Insurance number</param>
		/// <param name="m3_INDA">Installation date</param>
		/// <param name="m3_INTS">Installation time</param>
		/// <param name="m3_CMDD">Commission date</param>
		/// <param name="m3_SBNO">Subnumber</param>
		/// <param name="m3_ABBD">Buy-back date</param>
		/// <param name="m3_WADT">Warranty date</param>
		/// <param name="m3_WAGR">Warranty agreement</param>
		/// <param name="m3_WAL1">Warranty limit 1</param>
		/// <param name="m3_WAL2">Warranty limit 2</param>
		/// <param name="m3_WAL3">Warranty limit 3</param>
		/// <param name="m3_WAL4">Warranty limit 4</param>
		/// <param name="m3_NESA">Next shop action type</param>
		/// <param name="m3_NSUF">Next service</param>
		/// <param name="m3_MPGM">Maintenance program</param>
		/// <param name="m3_MAPL">Planner - maintenance</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_FCCM">Forecast logic</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_PRDT">Purchase price date</param>
		/// <param name="m3_BIRT">Origin identity</param>
		/// <param name="m3_BIRS">Date introduced into Movex</param>
		/// <param name="m3_DPID">Period frame</param>
		/// <param name="m3_CONC">Continuous net change</param>
		/// <param name="m3_PLMZ">Planning horizon</param>
		/// <param name="m3_SHRE">Percentage of cost price</param>
		/// <param name="m3_EQNL">Field not used</param>
		/// <param name="m3_MFDT">Manufacturing date</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_DTID">Data identity</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_MLYR">Year model</param>
		/// <param name="m3_AREA">Location description</param>
		/// <param name="m3_LOCS">Location</param>
		/// <param name="m3_BRAN">Brand</param>
		/// <param name="m3_EQTP">Equipment type</param>
		/// <param name="m3_EQGR">Equipment group</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_EQGC">Equipment group category</param>
		/// <param name="m3_SNRC">Serial number return code</param>
		/// <param name="m3_FLNO">Fleet number</param>
		/// <param name="m3_SKEY">Search key equipment</param>
		/// <param name="m3_EQCL">Equipment class</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddFixedAssetResponse></returns>
		/// <exception cref="M3Exception<AddFixedAssetResponse>"></exception>
		public async Task<M3Response<AddFixedAssetResponse>> AddFixedAsset(
			string m3_ASID, 
			string m3_ITNO, 
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_EQNO = null, 
			int? m3_STCD = null, 
			string m3_SERN = null, 
			string m3_TAIL = null, 
			string m3_CFGH = null, 
			int? m3_POEQ = null, 
			string m3_ITGR = null, 
			string m3_ITCL = null, 
			string m3_ITTY = null, 
			string m3_ACRF = null, 
			string m3_STAT = null, 
			string m3_PRIP = null, 
			string m3_ITDS = null, 
			string m3_ALII = null, 
			decimal? m3_TEFF = null, 
			decimal? m3_DWTC = null, 
			string m3_PRSS = null, 
			string m3_SBPR = null, 
			int? m3_AESC = null, 
			string m3_INSN = null, 
			DateTime? m3_INDA = null, 
			int? m3_INTS = null, 
			DateTime? m3_CMDD = null, 
			int? m3_SBNO = null, 
			DateTime? m3_ABBD = null, 
			DateTime? m3_WADT = null, 
			string m3_WAGR = null, 
			decimal? m3_WAL1 = null, 
			decimal? m3_WAL2 = null, 
			decimal? m3_WAL3 = null, 
			decimal? m3_WAL4 = null, 
			string m3_NESA = null, 
			string m3_NSUF = null, 
			string m3_MPGM = null, 
			string m3_MAPL = null, 
			string m3_CUNO = null, 
			string m3_FCCM = null, 
			decimal? m3_PUPR = null, 
			string m3_CUCD = null, 
			DateTime? m3_PRDT = null, 
			long? m3_BIRT = null, 
			DateTime? m3_BIRS = null, 
			int? m3_DPID = null, 
			int? m3_CONC = null, 
			int? m3_PLMZ = null, 
			int? m3_SHRE = null, 
			int? m3_EQNL = null, 
			DateTime? m3_MFDT = null, 
			string m3_PLGR = null, 
			decimal? m3_DTID = null, 
			decimal? m3_TXID = null, 
			string m3_MLYR = null, 
			string m3_AREA = null, 
			string m3_LOCS = null, 
			string m3_BRAN = null, 
			string m3_EQTP = null, 
			string m3_EQGR = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_EQGC = null, 
			int? m3_SNRC = null, 
			string m3_FLNO = null, 
			string m3_SKEY = null, 
			string m3_EQCL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddFixedAsset",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ASID))
				throw new ArgumentNullException("m3_ASID");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ASID", m3_ASID.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQNO))
				request.WithQueryParameter("EQNO", m3_EQNO.Trim());
			if (m3_STCD.HasValue)
				request.WithQueryParameter("STCD", m3_STCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAIL))
				request.WithQueryParameter("TAIL", m3_TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGH))
				request.WithQueryParameter("CFGH", m3_CFGH.Trim());
			if (m3_POEQ.HasValue)
				request.WithQueryParameter("POEQ", m3_POEQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITCL))
				request.WithQueryParameter("ITCL", m3_ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITTY))
				request.WithQueryParameter("ITTY", m3_ITTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRIP))
				request.WithQueryParameter("PRIP", m3_PRIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALII))
				request.WithQueryParameter("ALII", m3_ALII.Trim());
			if (m3_TEFF.HasValue)
				request.WithQueryParameter("TEFF", m3_TEFF.Value.ToString());
			if (m3_DWTC.HasValue)
				request.WithQueryParameter("DWTC", m3_DWTC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRSS))
				request.WithQueryParameter("PRSS", m3_PRSS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SBPR))
				request.WithQueryParameter("SBPR", m3_SBPR.Trim());
			if (m3_AESC.HasValue)
				request.WithQueryParameter("AESC", m3_AESC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INSN))
				request.WithQueryParameter("INSN", m3_INSN.Trim());
			if (m3_INDA.HasValue)
				request.WithQueryParameter("INDA", m3_INDA.Value.ToM3String());
			if (m3_INTS.HasValue)
				request.WithQueryParameter("INTS", m3_INTS.Value.ToString());
			if (m3_CMDD.HasValue)
				request.WithQueryParameter("CMDD", m3_CMDD.Value.ToM3String());
			if (m3_SBNO.HasValue)
				request.WithQueryParameter("SBNO", m3_SBNO.Value.ToString());
			if (m3_ABBD.HasValue)
				request.WithQueryParameter("ABBD", m3_ABBD.Value.ToM3String());
			if (m3_WADT.HasValue)
				request.WithQueryParameter("WADT", m3_WADT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_WAGR))
				request.WithQueryParameter("WAGR", m3_WAGR.Trim());
			if (m3_WAL1.HasValue)
				request.WithQueryParameter("WAL1", m3_WAL1.Value.ToString());
			if (m3_WAL2.HasValue)
				request.WithQueryParameter("WAL2", m3_WAL2.Value.ToString());
			if (m3_WAL3.HasValue)
				request.WithQueryParameter("WAL3", m3_WAL3.Value.ToString());
			if (m3_WAL4.HasValue)
				request.WithQueryParameter("WAL4", m3_WAL4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NESA))
				request.WithQueryParameter("NESA", m3_NESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NSUF))
				request.WithQueryParameter("NSUF", m3_NSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MPGM))
				request.WithQueryParameter("MPGM", m3_MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MAPL))
				request.WithQueryParameter("MAPL", m3_MAPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCCM))
				request.WithQueryParameter("FCCM", m3_FCCM.Trim());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3_PRDT.Value.ToM3String());
			if (m3_BIRT.HasValue)
				request.WithQueryParameter("BIRT", m3_BIRT.Value.ToString());
			if (m3_BIRS.HasValue)
				request.WithQueryParameter("BIRS", m3_BIRS.Value.ToM3String());
			if (m3_DPID.HasValue)
				request.WithQueryParameter("DPID", m3_DPID.Value.ToString());
			if (m3_CONC.HasValue)
				request.WithQueryParameter("CONC", m3_CONC.Value.ToString());
			if (m3_PLMZ.HasValue)
				request.WithQueryParameter("PLMZ", m3_PLMZ.Value.ToString());
			if (m3_SHRE.HasValue)
				request.WithQueryParameter("SHRE", m3_SHRE.Value.ToString());
			if (m3_EQNL.HasValue)
				request.WithQueryParameter("EQNL", m3_EQNL.Value.ToString());
			if (m3_MFDT.HasValue)
				request.WithQueryParameter("MFDT", m3_MFDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (m3_DTID.HasValue)
				request.WithQueryParameter("DTID", m3_DTID.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MLYR))
				request.WithQueryParameter("MLYR", m3_MLYR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AREA))
				request.WithQueryParameter("AREA", m3_AREA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LOCS))
				request.WithQueryParameter("LOCS", m3_LOCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRAN))
				request.WithQueryParameter("BRAN", m3_BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQTP))
				request.WithQueryParameter("EQTP", m3_EQTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQGR))
				request.WithQueryParameter("EQGR", m3_EQGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQGC))
				request.WithQueryParameter("EQGC", m3_EQGC.Trim());
			if (m3_SNRC.HasValue)
				request.WithQueryParameter("SNRC", m3_SNRC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FLNO))
				request.WithQueryParameter("FLNO", m3_FLNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SKEY))
				request.WithQueryParameter("SKEY", m3_SKEY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQCL))
				request.WithQueryParameter("EQCL", m3_EQCL.Trim());

			// Execute the request
			var result = await Execute<AddFixedAssetResponse>(
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
		/// Name AddOEM
		/// Description Add OEM Codes
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_CONO">Company</param>
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
		public async Task<M3Response<M3Record>> AddOEM(
			string m3_ITNO, 
			string m3_SERN, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddOEM",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
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
		/// Name Del
		/// Description Delete Item/Serialnumber
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			string m3_ITNO, 
			string m3_SERN, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim());

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
		/// Name DelEquipment
		/// Description Del Equipment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_EQNO">Equipment number (Required)</param>
		/// <param name="m3_TAIL">Registration number/site (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelEquipment(
			string m3_EQNO, 
			string m3_TAIL, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelEquipment",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_EQNO))
				throw new ArgumentNullException("m3_EQNO");
			if (string.IsNullOrWhiteSpace(m3_TAIL))
				throw new ArgumentNullException("m3_TAIL");

			// Set mandatory parameters
			request
				.WithQueryParameter("EQNO", m3_EQNO.Trim())
				.WithQueryParameter("TAIL", m3_TAIL.Trim());

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
		/// Name GenServiceHist
		/// Description Generate service history
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> GenServiceHist(
			string m3_ITNO, 
			string m3_SERN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GenServiceHist",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim());

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
		/// Description GEt Basic Data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicResponse></returns>
		/// <exception cref="M3Exception<GetBasicResponse>"></exception>
		public async Task<M3Response<GetBasicResponse>> GetBasic(
			string m3_ITNO, 
			string m3_SERN, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim());

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
		/// Name GetEquipAlias
		/// Description Get Equipment Search Alias
		/// Version Release: 
		/// </summary>
		/// <param name="m3_POPN">Equipment Search Alias</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetEquipAliasResponse></returns>
		/// <exception cref="M3Exception<GetEquipAliasResponse>"></exception>
		public async Task<M3Response<GetEquipAliasResponse>> GetEquipAlias(
			string m3_POPN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetEquipAlias",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());

			// Execute the request
			var result = await Execute<GetEquipAliasResponse>(
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
		/// Name GetModIndReg
		/// Description GetModIndReg
		/// Version Release: 15
		/// </summary>
		/// <param name="m3_MTRL">Component identity (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetModIndRegResponse></returns>
		/// <exception cref="M3Exception<GetModIndRegResponse>"></exception>
		public async Task<M3Response<GetModIndRegResponse>> GetModIndReg(
			string m3_MTRL, 
			string m3_SERN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetModIndReg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MTRL))
				throw new ArgumentNullException("m3_MTRL");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MTRL", m3_MTRL.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim());

			// Execute the request
			var result = await Execute<GetModIndRegResponse>(
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
		/// Name GetOEM
		/// Description Get OEM Codes
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOEMResponse></returns>
		/// <exception cref="M3Exception<GetOEMResponse>"></exception>
		public async Task<M3Response<GetOEMResponse>> GetOEM(
			string m3_ITNO, 
			string m3_SERN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetOEM",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetOEMResponse>(
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
		/// Name LstByCompany
		/// Description List serial no by company
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByCompanyResponse></returns>
		/// <exception cref="M3Exception<LstByCompanyResponse>"></exception>
		public async Task<M3Response<LstByCompanyResponse>> LstByCompany(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByCompany",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstByCompanyResponse>(
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
		/// Name LstByCustomer
		/// Description LstByCustomer
		/// Version Release: 15
		/// </summary>
		/// <param name="m3_CUNO">Customer (Required)</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByCustomerResponse></returns>
		/// <exception cref="M3Exception<LstByCustomerResponse>"></exception>
		public async Task<M3Response<LstByCustomerResponse>> LstByCustomer(
			string m3_CUNO, 
			string m3_ITNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByCustomer",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<LstByCustomerResponse>(
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
		/// Name LstByItem
		/// Description List serial number by item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByItemResponse></returns>
		/// <exception cref="M3Exception<LstByItemResponse>"></exception>
		public async Task<M3Response<LstByItemResponse>> LstByItem(
			string m3_ITNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstByItemResponse>(
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
		/// Name LstBySerialNo
		/// Description List by serial number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BRAN">Brand</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBySerialNoResponse></returns>
		/// <exception cref="M3Exception<LstBySerialNoResponse>"></exception>
		public async Task<M3Response<LstBySerialNoResponse>> LstBySerialNo(
			string m3_SERN, 
			string m3_ITNO = null, 
			string m3_BRAN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBySerialNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");

			// Set mandatory parameters
			request
				.WithQueryParameter("SERN", m3_SERN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRAN))
				request.WithQueryParameter("BRAN", m3_BRAN.Trim());

			// Execute the request
			var result = await Execute<LstBySerialNoResponse>(
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
		/// Name Reclassify
		/// Description Reclassify
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_NSER">New serial number (Required)</param>
		/// <param name="m3_NITN">New item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ReclassifyResponse></returns>
		/// <exception cref="M3Exception<ReclassifyResponse>"></exception>
		public async Task<M3Response<ReclassifyResponse>> Reclassify(
			string m3_ITNO, 
			string m3_SERN, 
			string m3_NSER, 
			string m3_NITN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Reclassify",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_NSER))
				throw new ArgumentNullException("m3_NSER");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("NSER", m3_NSER.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_NITN))
				request.WithQueryParameter("NITN", m3_NITN.Trim());

			// Execute the request
			var result = await Execute<ReclassifyResponse>(
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
		/// Name SearchEquipment
		/// Description Search equipment
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchEquipmentResponse></returns>
		/// <exception cref="M3Exception<SearchEquipmentResponse>"></exception>
		public async Task<M3Response<SearchEquipmentResponse>> SearchEquipment(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchEquipment",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SQRY))
				throw new ArgumentNullException("m3_SQRY");

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3_SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchEquipmentResponse>(
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
		/// Description Update Item/Serialnumber
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ASID">Fixed asset</param>
		/// <param name="m3_SBNO">Subnumber</param>
		/// <param name="m3_ABBD">Buy-back date</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_WADT">Warranty date</param>
		/// <param name="m3_WAGR">Warranty agreement</param>
		/// <param name="m3_WAL1">Warranty limit 1</param>
		/// <param name="m3_WAL2">Warranty limit 2</param>
		/// <param name="m3_WAL3">Warranty limit 3</param>
		/// <param name="m3_WAL4">Warranty limit 4</param>
		/// <param name="m3_NESA">Next shop action type</param>
		/// <param name="m3_NSUF">Next service</param>
		/// <param name="m3_MPGM">Maintenance program</param>
		/// <param name="m3_MAPL">Planner - maintenance</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_FCCM">Forecast logic</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_PPDT">Purchase price date</param>
		/// <param name="m3_BIRT">Origin identity</param>
		/// <param name="m3_BIRS">Date introduced into Movex</param>
		/// <param name="m3_ALII">Equipment description</param>
		/// <param name="m3_DPID">Period frame</param>
		/// <param name="m3_CONC">Continuous net change</param>
		/// <param name="m3_PLMZ">Planning horizon</param>
		/// <param name="m3_SHRE">Percentage of cost price</param>
		/// <param name="m3_INSN">Insurance number</param>
		/// <param name="m3_EQNO">Equipment number</param>
		/// <param name="m3_EQNL">Field not used</param>
		/// <param name="m3_PRIP">Priority</param>
		/// <param name="m3_PRSS">Process</param>
		/// <param name="m3_SBPR">Subprocess</param>
		/// <param name="m3_AESC">Criticality class</param>
		/// <param name="m3_TEFF">Target availability</param>
		/// <param name="m3_DWTC">Downtime cost</param>
		/// <param name="m3_CMDD">Commission date</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_MFDT">Manufacturing date</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_MLYR">Year model</param>
		/// <param name="m3_AREA">Location description</param>
		/// <param name="m3_LOCS">Location</param>
		/// <param name="m3_BRAN">Brand</param>
		/// <param name="m3_EQTP">Equipment type</param>
		/// <param name="m3_EQGR">Equipment group</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_INDA">Installation date</param>
		/// <param name="m3_SNRC">Serial number return code</param>
		/// <param name="m3_RFIA">Asset tag</param>
		/// <param name="m3_AAGN">Agreement number</param>
		/// <param name="m3_FLEE">Fleet</param>
		/// <param name="m3_COCE">Cost center</param>
		/// <param name="m3_FLNO">Fleet number</param>
		/// <param name="m3_SKEY">Search key equipment</param>
		/// <param name="m3_LAMA">Minimum accepted contributn margin ratio</param>
		/// <param name="m3_ASLM">Sales model</param>
		/// <param name="m3_APRM">Price model</param>
		/// <param name="m3_ADLM">Dealer model</param>
		/// <param name="m3_ACMC">Compatibility code</param>
		/// <param name="m3_CFI1">User-defined field 1 - item</param>
		/// <param name="m3_CFI2">User-defined field 2 - item</param>
		/// <param name="m3_CFI3">User-defined field 3 - item</param>
		/// <param name="m3_CFI4">User-defined field 4 - item</param>
		/// <param name="m3_CFI5">User-defined field 5 - item</param>
		/// <param name="m3_CUOW">Owner</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_OWTP">Ownership type</param>
		/// <param name="m3_PUEX">Publish External</param>
		/// <param name="m3_PUNO">purchase order number</param>
		/// <param name="m3_PNLI">Purchase order line number</param>
		/// <param name="m3_PNLS">Purchase order line subnumber</param>
		/// <param name="m3_OWNC">OWNC</param>
		/// <param name="m3_LKDT">like kind date</param>
		/// <param name="m3_LKST">like kind status</param>
		/// <param name="m3_TAIL">Registration number/site</param>
		/// <param name="m3_OENV">Operating Enviroment</param>
		/// <param name="m3_EQCL">Equipment class</param>
		/// <param name="m3_TXID">Text Identity</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3_ITNO, 
			string m3_SERN, 
			int? m3_CONO = null, 
			string m3_ASID = null, 
			int? m3_SBNO = null, 
			DateTime? m3_ABBD = null, 
			string m3_STAT = null, 
			DateTime? m3_WADT = null, 
			string m3_WAGR = null, 
			decimal? m3_WAL1 = null, 
			decimal? m3_WAL2 = null, 
			decimal? m3_WAL3 = null, 
			decimal? m3_WAL4 = null, 
			string m3_NESA = null, 
			string m3_NSUF = null, 
			string m3_MPGM = null, 
			string m3_MAPL = null, 
			string m3_CUNO = null, 
			string m3_FCCM = null, 
			decimal? m3_PUPR = null, 
			string m3_CUCD = null, 
			DateTime? m3_PPDT = null, 
			long? m3_BIRT = null, 
			DateTime? m3_BIRS = null, 
			string m3_ALII = null, 
			int? m3_DPID = null, 
			int? m3_CONC = null, 
			int? m3_PLMZ = null, 
			int? m3_SHRE = null, 
			string m3_INSN = null, 
			string m3_EQNO = null, 
			int? m3_EQNL = null, 
			string m3_PRIP = null, 
			string m3_PRSS = null, 
			string m3_SBPR = null, 
			int? m3_AESC = null, 
			decimal? m3_TEFF = null, 
			decimal? m3_DWTC = null, 
			DateTime? m3_CMDD = null, 
			string m3_FACI = null, 
			DateTime? m3_MFDT = null, 
			string m3_PLGR = null, 
			string m3_MLYR = null, 
			string m3_AREA = null, 
			string m3_LOCS = null, 
			string m3_BRAN = null, 
			string m3_EQTP = null, 
			string m3_EQGR = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			DateTime? m3_INDA = null, 
			int? m3_SNRC = null, 
			string m3_RFIA = null, 
			string m3_AAGN = null, 
			string m3_FLEE = null, 
			string m3_COCE = null, 
			string m3_FLNO = null, 
			string m3_SKEY = null, 
			int? m3_LAMA = null, 
			string m3_ASLM = null, 
			string m3_APRM = null, 
			string m3_ADLM = null, 
			string m3_ACMC = null, 
			string m3_CFI1 = null, 
			decimal? m3_CFI2 = null, 
			string m3_CFI3 = null, 
			string m3_CFI4 = null, 
			string m3_CFI5 = null, 
			string m3_CUOW = null, 
			string m3_ADID = null, 
			string m3_OWTP = null, 
			int? m3_PUEX = null, 
			string m3_PUNO = null, 
			int? m3_PNLI = null, 
			int? m3_PNLS = null, 
			string m3_OWNC = null, 
			DateTime? m3_LKDT = null, 
			string m3_LKST = null, 
			string m3_TAIL = null, 
			string m3_OENV = null, 
			string m3_EQCL = null, 
			decimal? m3_TXID = null, 
			string m3_SUNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ASID))
				request.WithQueryParameter("ASID", m3_ASID.Trim());
			if (m3_SBNO.HasValue)
				request.WithQueryParameter("SBNO", m3_SBNO.Value.ToString());
			if (m3_ABBD.HasValue)
				request.WithQueryParameter("ABBD", m3_ABBD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_WADT.HasValue)
				request.WithQueryParameter("WADT", m3_WADT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_WAGR))
				request.WithQueryParameter("WAGR", m3_WAGR.Trim());
			if (m3_WAL1.HasValue)
				request.WithQueryParameter("WAL1", m3_WAL1.Value.ToString());
			if (m3_WAL2.HasValue)
				request.WithQueryParameter("WAL2", m3_WAL2.Value.ToString());
			if (m3_WAL3.HasValue)
				request.WithQueryParameter("WAL3", m3_WAL3.Value.ToString());
			if (m3_WAL4.HasValue)
				request.WithQueryParameter("WAL4", m3_WAL4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NESA))
				request.WithQueryParameter("NESA", m3_NESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NSUF))
				request.WithQueryParameter("NSUF", m3_NSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MPGM))
				request.WithQueryParameter("MPGM", m3_MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MAPL))
				request.WithQueryParameter("MAPL", m3_MAPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCCM))
				request.WithQueryParameter("FCCM", m3_FCCM.Trim());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_PPDT.HasValue)
				request.WithQueryParameter("PPDT", m3_PPDT.Value.ToM3String());
			if (m3_BIRT.HasValue)
				request.WithQueryParameter("BIRT", m3_BIRT.Value.ToString());
			if (m3_BIRS.HasValue)
				request.WithQueryParameter("BIRS", m3_BIRS.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ALII))
				request.WithQueryParameter("ALII", m3_ALII.Trim());
			if (m3_DPID.HasValue)
				request.WithQueryParameter("DPID", m3_DPID.Value.ToString());
			if (m3_CONC.HasValue)
				request.WithQueryParameter("CONC", m3_CONC.Value.ToString());
			if (m3_PLMZ.HasValue)
				request.WithQueryParameter("PLMZ", m3_PLMZ.Value.ToString());
			if (m3_SHRE.HasValue)
				request.WithQueryParameter("SHRE", m3_SHRE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INSN))
				request.WithQueryParameter("INSN", m3_INSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQNO))
				request.WithQueryParameter("EQNO", m3_EQNO.Trim());
			if (m3_EQNL.HasValue)
				request.WithQueryParameter("EQNL", m3_EQNL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRIP))
				request.WithQueryParameter("PRIP", m3_PRIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRSS))
				request.WithQueryParameter("PRSS", m3_PRSS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SBPR))
				request.WithQueryParameter("SBPR", m3_SBPR.Trim());
			if (m3_AESC.HasValue)
				request.WithQueryParameter("AESC", m3_AESC.Value.ToString());
			if (m3_TEFF.HasValue)
				request.WithQueryParameter("TEFF", m3_TEFF.Value.ToString());
			if (m3_DWTC.HasValue)
				request.WithQueryParameter("DWTC", m3_DWTC.Value.ToString());
			if (m3_CMDD.HasValue)
				request.WithQueryParameter("CMDD", m3_CMDD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (m3_MFDT.HasValue)
				request.WithQueryParameter("MFDT", m3_MFDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MLYR))
				request.WithQueryParameter("MLYR", m3_MLYR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AREA))
				request.WithQueryParameter("AREA", m3_AREA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LOCS))
				request.WithQueryParameter("LOCS", m3_LOCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRAN))
				request.WithQueryParameter("BRAN", m3_BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQTP))
				request.WithQueryParameter("EQTP", m3_EQTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQGR))
				request.WithQueryParameter("EQGR", m3_EQGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (m3_INDA.HasValue)
				request.WithQueryParameter("INDA", m3_INDA.Value.ToM3String());
			if (m3_SNRC.HasValue)
				request.WithQueryParameter("SNRC", m3_SNRC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RFIA))
				request.WithQueryParameter("RFIA", m3_RFIA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AAGN))
				request.WithQueryParameter("AAGN", m3_AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLEE))
				request.WithQueryParameter("FLEE", m3_FLEE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COCE))
				request.WithQueryParameter("COCE", m3_COCE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLNO))
				request.WithQueryParameter("FLNO", m3_FLNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SKEY))
				request.WithQueryParameter("SKEY", m3_SKEY.Trim());
			if (m3_LAMA.HasValue)
				request.WithQueryParameter("LAMA", m3_LAMA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ASLM))
				request.WithQueryParameter("ASLM", m3_ASLM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APRM))
				request.WithQueryParameter("APRM", m3_APRM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADLM))
				request.WithQueryParameter("ADLM", m3_ADLM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACMC))
				request.WithQueryParameter("ACMC", m3_ACMC.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_CUOW))
				request.WithQueryParameter("CUOW", m3_CUOW.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OWTP))
				request.WithQueryParameter("OWTP", m3_OWTP.Trim());
			if (m3_PUEX.HasValue)
				request.WithQueryParameter("PUEX", m3_PUEX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PUNO))
				request.WithQueryParameter("PUNO", m3_PUNO.Trim());
			if (m3_PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3_PNLI.Value.ToString());
			if (m3_PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3_PNLS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OWNC))
				request.WithQueryParameter("OWNC", m3_OWNC.Trim());
			if (m3_LKDT.HasValue)
				request.WithQueryParameter("LKDT", m3_LKDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_LKST))
				request.WithQueryParameter("LKST", m3_LKST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAIL))
				request.WithQueryParameter("TAIL", m3_TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OENV))
				request.WithQueryParameter("OENV", m3_OENV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQCL))
				request.WithQueryParameter("EQCL", m3_EQCL.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());

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
		/// Name UpdEquipment
		/// Description Upd Equipment
		/// Version Release: 5ea5
		/// </summary>
		/// <param name="m3_EQNO">Equipment number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ASID">Fixed asset</param>
		/// <param name="m3_SBNO">Subnumber</param>
		/// <param name="m3_ABBD">Buy-back date</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_WADT">Warranty date</param>
		/// <param name="m3_WAGR">Warranty agreement</param>
		/// <param name="m3_WAL1">Warranty limit 1</param>
		/// <param name="m3_WAL2">Warranty limit 2</param>
		/// <param name="m3_WAL3">Warranty limit 3</param>
		/// <param name="m3_WAL4">Warranty limit 4</param>
		/// <param name="m3_NESA">Next shop action type</param>
		/// <param name="m3_NSUF">Next service</param>
		/// <param name="m3_MPGM">Maintenance program</param>
		/// <param name="m3_MAPL">Planner - maintenance</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_FCCM">Forecast logic</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_PPDT">Purchase price date</param>
		/// <param name="m3_BIRT">Origin identity</param>
		/// <param name="m3_BIRS">Date introduced into Movex</param>
		/// <param name="m3_ALII">Equipment description</param>
		/// <param name="m3_DPID">Period frame</param>
		/// <param name="m3_CONC">Continuous net change</param>
		/// <param name="m3_PLMZ">Planning horizon</param>
		/// <param name="m3_SHRE">Percentage of cost price</param>
		/// <param name="m3_INSN">Insurance number</param>
		/// <param name="m3_EQNL">Field not used</param>
		/// <param name="m3_PRIP">Priority</param>
		/// <param name="m3_PRSS">Process</param>
		/// <param name="m3_SBPR">Subprocess</param>
		/// <param name="m3_AESC">Criticality class</param>
		/// <param name="m3_TEFF">Target availability</param>
		/// <param name="m3_DWTC">Downtime cost</param>
		/// <param name="m3_CMDD">Commission date</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_MFDT">Manufacturing date</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_MLYR">Year model</param>
		/// <param name="m3_AREA">Location description</param>
		/// <param name="m3_LOCS">Location</param>
		/// <param name="m3_BRAN">Brand</param>
		/// <param name="m3_EQTP">Equipment type</param>
		/// <param name="m3_EQGR">Equipment group</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_EQGC">Equipment group category</param>
		/// <param name="m3_INDA">Installation date</param>
		/// <param name="m3_SNRC">Serial number return code</param>
		/// <param name="m3_RFIA">Asset tag</param>
		/// <param name="m3_OWNC">Owner</param>
		/// <param name="m3_MFIT">Supplier/manufacturer item number</param>
		/// <param name="m3_MFSN">Manufacturer serial number</param>
		/// <param name="m3_COCE">Cost center</param>
		/// <param name="m3_FLNO">Fleet number</param>
		/// <param name="m3_SKEY">Search key equipment</param>
		/// <param name="m3_LAMA">Minimum accepted contributn margin ratio</param>
		/// <param name="m3_PUNO">Purchase order number</param>
		/// <param name="m3_PNLI">Purchase order line number</param>
		/// <param name="m3_PNLS">Purchase order line subnumber</param>
		/// <param name="m3_OENV">Operating Enviroment</param>
		/// <param name="m3_EQCL">Equipment class</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdEquipment(
			string m3_EQNO, 
			int? m3_CONO = null, 
			string m3_ASID = null, 
			int? m3_SBNO = null, 
			DateTime? m3_ABBD = null, 
			string m3_STAT = null, 
			DateTime? m3_WADT = null, 
			string m3_WAGR = null, 
			decimal? m3_WAL1 = null, 
			decimal? m3_WAL2 = null, 
			decimal? m3_WAL3 = null, 
			decimal? m3_WAL4 = null, 
			string m3_NESA = null, 
			string m3_NSUF = null, 
			string m3_MPGM = null, 
			string m3_MAPL = null, 
			string m3_CUNO = null, 
			string m3_FCCM = null, 
			decimal? m3_PUPR = null, 
			string m3_CUCD = null, 
			DateTime? m3_PPDT = null, 
			long? m3_BIRT = null, 
			DateTime? m3_BIRS = null, 
			string m3_ALII = null, 
			int? m3_DPID = null, 
			int? m3_CONC = null, 
			int? m3_PLMZ = null, 
			int? m3_SHRE = null, 
			string m3_INSN = null, 
			int? m3_EQNL = null, 
			string m3_PRIP = null, 
			string m3_PRSS = null, 
			string m3_SBPR = null, 
			int? m3_AESC = null, 
			decimal? m3_TEFF = null, 
			decimal? m3_DWTC = null, 
			DateTime? m3_CMDD = null, 
			string m3_FACI = null, 
			DateTime? m3_MFDT = null, 
			string m3_PLGR = null, 
			string m3_MLYR = null, 
			string m3_AREA = null, 
			string m3_LOCS = null, 
			string m3_BRAN = null, 
			string m3_EQTP = null, 
			string m3_EQGR = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_EQGC = null, 
			DateTime? m3_INDA = null, 
			int? m3_SNRC = null, 
			string m3_RFIA = null, 
			string m3_OWNC = null, 
			string m3_MFIT = null, 
			string m3_MFSN = null, 
			string m3_COCE = null, 
			string m3_FLNO = null, 
			string m3_SKEY = null, 
			int? m3_LAMA = null, 
			string m3_PUNO = null, 
			int? m3_PNLI = null, 
			int? m3_PNLS = null, 
			string m3_OENV = null, 
			string m3_EQCL = null, 
			string m3_ACRF = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdEquipment",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_EQNO))
				throw new ArgumentNullException("m3_EQNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("EQNO", m3_EQNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ASID))
				request.WithQueryParameter("ASID", m3_ASID.Trim());
			if (m3_SBNO.HasValue)
				request.WithQueryParameter("SBNO", m3_SBNO.Value.ToString());
			if (m3_ABBD.HasValue)
				request.WithQueryParameter("ABBD", m3_ABBD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_WADT.HasValue)
				request.WithQueryParameter("WADT", m3_WADT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_WAGR))
				request.WithQueryParameter("WAGR", m3_WAGR.Trim());
			if (m3_WAL1.HasValue)
				request.WithQueryParameter("WAL1", m3_WAL1.Value.ToString());
			if (m3_WAL2.HasValue)
				request.WithQueryParameter("WAL2", m3_WAL2.Value.ToString());
			if (m3_WAL3.HasValue)
				request.WithQueryParameter("WAL3", m3_WAL3.Value.ToString());
			if (m3_WAL4.HasValue)
				request.WithQueryParameter("WAL4", m3_WAL4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NESA))
				request.WithQueryParameter("NESA", m3_NESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NSUF))
				request.WithQueryParameter("NSUF", m3_NSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MPGM))
				request.WithQueryParameter("MPGM", m3_MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MAPL))
				request.WithQueryParameter("MAPL", m3_MAPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCCM))
				request.WithQueryParameter("FCCM", m3_FCCM.Trim());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_PPDT.HasValue)
				request.WithQueryParameter("PPDT", m3_PPDT.Value.ToM3String());
			if (m3_BIRT.HasValue)
				request.WithQueryParameter("BIRT", m3_BIRT.Value.ToString());
			if (m3_BIRS.HasValue)
				request.WithQueryParameter("BIRS", m3_BIRS.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ALII))
				request.WithQueryParameter("ALII", m3_ALII.Trim());
			if (m3_DPID.HasValue)
				request.WithQueryParameter("DPID", m3_DPID.Value.ToString());
			if (m3_CONC.HasValue)
				request.WithQueryParameter("CONC", m3_CONC.Value.ToString());
			if (m3_PLMZ.HasValue)
				request.WithQueryParameter("PLMZ", m3_PLMZ.Value.ToString());
			if (m3_SHRE.HasValue)
				request.WithQueryParameter("SHRE", m3_SHRE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INSN))
				request.WithQueryParameter("INSN", m3_INSN.Trim());
			if (m3_EQNL.HasValue)
				request.WithQueryParameter("EQNL", m3_EQNL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRIP))
				request.WithQueryParameter("PRIP", m3_PRIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRSS))
				request.WithQueryParameter("PRSS", m3_PRSS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SBPR))
				request.WithQueryParameter("SBPR", m3_SBPR.Trim());
			if (m3_AESC.HasValue)
				request.WithQueryParameter("AESC", m3_AESC.Value.ToString());
			if (m3_TEFF.HasValue)
				request.WithQueryParameter("TEFF", m3_TEFF.Value.ToString());
			if (m3_DWTC.HasValue)
				request.WithQueryParameter("DWTC", m3_DWTC.Value.ToString());
			if (m3_CMDD.HasValue)
				request.WithQueryParameter("CMDD", m3_CMDD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (m3_MFDT.HasValue)
				request.WithQueryParameter("MFDT", m3_MFDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MLYR))
				request.WithQueryParameter("MLYR", m3_MLYR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AREA))
				request.WithQueryParameter("AREA", m3_AREA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LOCS))
				request.WithQueryParameter("LOCS", m3_LOCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRAN))
				request.WithQueryParameter("BRAN", m3_BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQTP))
				request.WithQueryParameter("EQTP", m3_EQTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQGR))
				request.WithQueryParameter("EQGR", m3_EQGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQGC))
				request.WithQueryParameter("EQGC", m3_EQGC.Trim());
			if (m3_INDA.HasValue)
				request.WithQueryParameter("INDA", m3_INDA.Value.ToM3String());
			if (m3_SNRC.HasValue)
				request.WithQueryParameter("SNRC", m3_SNRC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RFIA))
				request.WithQueryParameter("RFIA", m3_RFIA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OWNC))
				request.WithQueryParameter("OWNC", m3_OWNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MFIT))
				request.WithQueryParameter("MFIT", m3_MFIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MFSN))
				request.WithQueryParameter("MFSN", m3_MFSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COCE))
				request.WithQueryParameter("COCE", m3_COCE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLNO))
				request.WithQueryParameter("FLNO", m3_FLNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SKEY))
				request.WithQueryParameter("SKEY", m3_SKEY.Trim());
			if (m3_LAMA.HasValue)
				request.WithQueryParameter("LAMA", m3_LAMA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PUNO))
				request.WithQueryParameter("PUNO", m3_PUNO.Trim());
			if (m3_PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3_PNLI.Value.ToString());
			if (m3_PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3_PNLS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OENV))
				request.WithQueryParameter("OENV", m3_OENV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQCL))
				request.WithQueryParameter("EQCL", m3_EQCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());

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
		/// Name UpdOEM
		/// Description Update OEM Codes
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_CONO">Company</param>
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
		public async Task<M3Response<M3Record>> UpdOEM(
			string m3_ITNO, 
			string m3_SERN, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdOEM",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
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
	}
}
// EOF
