/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
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
	/// Name: MOS140MI
	/// Component Name: MAI
	/// Description: PrintWorkOrder
	/// Version Release: 5ea0
	///</summary>
	public partial class MOS140MIResource : M3BaseResourceEndpoint
	{
		public MOS140MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS140MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name PrintWorkOrder
		/// Description PrintWorkOrder
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FSTDT">Start date from</param>
		/// <param name="m3_TSTDT">Start date to</param>
		/// <param name="m3_FFACI">Facility from</param>
		/// <param name="m3_TFACI">Facility to</param>
		/// <param name="m3_FPRNO">Product from</param>
		/// <param name="m3_TPRNO">Product to</param>
		/// <param name="m3_FBANO">Lot number from</param>
		/// <param name="m3_TBANO">Lot number to</param>
		/// <param name="m3_FSTRT">Product structure type from</param>
		/// <param name="m3_TSTRT">Product structure type to</param>
		/// <param name="m3_FSUFI">Service from</param>
		/// <param name="m3_TSUFI">Service to</param>
		/// <param name="m3_FEVTY">Event type from</param>
		/// <param name="m3_TEVTY">Event type to</param>
		/// <param name="m3_FRSCD">Transaction reason from</param>
		/// <param name="m3_TRSCD">Transaction reason to</param>
		/// <param name="m3_FMWNO">Work order number from</param>
		/// <param name="m3_TMWNO">Work order number to</param>
		/// <param name="m3_FRORC">Reference order category from</param>
		/// <param name="m3_TRORC">Reference order category to</param>
		/// <param name="m3_FRORN">Reference order number from</param>
		/// <param name="m3_TRORN">Reference order number to</param>
		/// <param name="m3_FRORL">Reference order line from</param>
		/// <param name="m3_TRORL">Reference order line to</param>
		/// <param name="m3_FRESP">Responsible from</param>
		/// <param name="m3_TRESP">Responsible to</param>
		/// <param name="m3_FORTY">Order type from</param>
		/// <param name="m3_TORTY">Order type to</param>
		/// <param name="m3_FWHST">Status - manufacturing order from</param>
		/// <param name="m3_TWHST">Status - manufacturing order to</param>
		/// <param name="m3_FPROJ">Project number from</param>
		/// <param name="m3_TPROJ">Project number to</param>
		/// <param name="m3_FELNO">Project element from</param>
		/// <param name="m3_TELNO">Project element to</param>
		/// <param name="m3_FCFI1">User-defined field 1 - item from</param>
		/// <param name="m3_TCFI1">User-defined field 1 - item to</param>
		/// <param name="m3_FPLGR">Work center from</param>
		/// <param name="m3_TPLGR">Work center to</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="m3_COPY">Number of copies</param>
		/// <param name="m3_PWEL">Print skill</param>
		/// <param name="m3_PTOL">Prt tools</param>
		/// <param name="m3_PDOC">Prt documents</param>
		/// <param name="m3_PINS">Prt inspection</param>
		/// <param name="m3_CPNM">Contact person</param>
		/// <param name="m3_EMAL">Electronic mail address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrintWorkOrder(
			DateTime? m3_FSTDT = null, 
			DateTime? m3_TSTDT = null, 
			string m3_FFACI = null, 
			string m3_TFACI = null, 
			string m3_FPRNO = null, 
			string m3_TPRNO = null, 
			string m3_FBANO = null, 
			string m3_TBANO = null, 
			string m3_FSTRT = null, 
			string m3_TSTRT = null, 
			string m3_FSUFI = null, 
			string m3_TSUFI = null, 
			string m3_FEVTY = null, 
			string m3_TEVTY = null, 
			string m3_FRSCD = null, 
			string m3_TRSCD = null, 
			string m3_FMWNO = null, 
			string m3_TMWNO = null, 
			int? m3_FRORC = null, 
			int? m3_TRORC = null, 
			string m3_FRORN = null, 
			string m3_TRORN = null, 
			int? m3_FRORL = null, 
			int? m3_TRORL = null, 
			string m3_FRESP = null, 
			string m3_TRESP = null, 
			string m3_FORTY = null, 
			string m3_TORTY = null, 
			string m3_FWHST = null, 
			string m3_TWHST = null, 
			string m3_FPROJ = null, 
			string m3_TPROJ = null, 
			string m3_FELNO = null, 
			string m3_TELNO = null, 
			string m3_FCFI1 = null, 
			string m3_TCFI1 = null, 
			string m3_FPLGR = null, 
			string m3_TPLGR = null, 
			string m3_DOVA = null, 
			int? m3_COPY = null, 
			int? m3_PWEL = null, 
			int? m3_PTOL = null, 
			int? m3_PDOC = null, 
			int? m3_PINS = null, 
			string m3_CPNM = null, 
			string m3_EMAL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrintWorkOrder",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_FSTDT.HasValue)
				request.WithQueryParameter("FSTDT", m3_FSTDT.Value.ToM3String());
			if (m3_TSTDT.HasValue)
				request.WithQueryParameter("TSTDT", m3_TSTDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_FFACI))
				request.WithQueryParameter("FFACI", m3_FFACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFACI))
				request.WithQueryParameter("TFACI", m3_TFACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FPRNO))
				request.WithQueryParameter("FPRNO", m3_FPRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TPRNO))
				request.WithQueryParameter("TPRNO", m3_TPRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FBANO))
				request.WithQueryParameter("FBANO", m3_FBANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TBANO))
				request.WithQueryParameter("TBANO", m3_TBANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FSTRT))
				request.WithQueryParameter("FSTRT", m3_FSTRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSTRT))
				request.WithQueryParameter("TSTRT", m3_TSTRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FSUFI))
				request.WithQueryParameter("FSUFI", m3_FSUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSUFI))
				request.WithQueryParameter("TSUFI", m3_TSUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FEVTY))
				request.WithQueryParameter("FEVTY", m3_FEVTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEVTY))
				request.WithQueryParameter("TEVTY", m3_TEVTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRSCD))
				request.WithQueryParameter("FRSCD", m3_FRSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRSCD))
				request.WithQueryParameter("TRSCD", m3_TRSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMWNO))
				request.WithQueryParameter("FMWNO", m3_FMWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TMWNO))
				request.WithQueryParameter("TMWNO", m3_TMWNO.Trim());
			if (m3_FRORC.HasValue)
				request.WithQueryParameter("FRORC", m3_FRORC.Value.ToString());
			if (m3_TRORC.HasValue)
				request.WithQueryParameter("TRORC", m3_TRORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRORN))
				request.WithQueryParameter("FRORN", m3_FRORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRORN))
				request.WithQueryParameter("TRORN", m3_TRORN.Trim());
			if (m3_FRORL.HasValue)
				request.WithQueryParameter("FRORL", m3_FRORL.Value.ToString());
			if (m3_TRORL.HasValue)
				request.WithQueryParameter("TRORL", m3_TRORL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRESP))
				request.WithQueryParameter("FRESP", m3_FRESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRESP))
				request.WithQueryParameter("TRESP", m3_TRESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FORTY))
				request.WithQueryParameter("FORTY", m3_FORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TORTY))
				request.WithQueryParameter("TORTY", m3_TORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FWHST))
				request.WithQueryParameter("FWHST", m3_FWHST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWHST))
				request.WithQueryParameter("TWHST", m3_TWHST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FPROJ))
				request.WithQueryParameter("FPROJ", m3_FPROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TPROJ))
				request.WithQueryParameter("TPROJ", m3_TPROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FELNO))
				request.WithQueryParameter("FELNO", m3_FELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TELNO))
				request.WithQueryParameter("TELNO", m3_TELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCFI1))
				request.WithQueryParameter("FCFI1", m3_FCFI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TCFI1))
				request.WithQueryParameter("TCFI1", m3_TCFI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FPLGR))
				request.WithQueryParameter("FPLGR", m3_FPLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TPLGR))
				request.WithQueryParameter("TPLGR", m3_TPLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());
			if (m3_COPY.HasValue)
				request.WithQueryParameter("COPY", m3_COPY.Value.ToString());
			if (m3_PWEL.HasValue)
				request.WithQueryParameter("PWEL", m3_PWEL.Value.ToString());
			if (m3_PTOL.HasValue)
				request.WithQueryParameter("PTOL", m3_PTOL.Value.ToString());
			if (m3_PDOC.HasValue)
				request.WithQueryParameter("PDOC", m3_PDOC.Value.ToString());
			if (m3_PINS.HasValue)
				request.WithQueryParameter("PINS", m3_PINS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CPNM))
				request.WithQueryParameter("CPNM", m3_CPNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMAL))
				request.WithQueryParameter("EMAL", m3_EMAL.Trim());

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
