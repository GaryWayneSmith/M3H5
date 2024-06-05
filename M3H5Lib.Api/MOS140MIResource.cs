/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name PrintWorkOrder
		/// Description PrintWorkOrder
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FSTDT">Start date from</param>
		/// <param name="m3TSTDT">Start date to</param>
		/// <param name="m3FFACI">Facility from</param>
		/// <param name="m3TFACI">Facility to</param>
		/// <param name="m3FPRNO">Product from</param>
		/// <param name="m3TPRNO">Product to</param>
		/// <param name="m3FBANO">Lot number from</param>
		/// <param name="m3TBANO">Lot number to</param>
		/// <param name="m3FSTRT">Product structure type from</param>
		/// <param name="m3TSTRT">Product structure type to</param>
		/// <param name="m3FSUFI">Service from</param>
		/// <param name="m3TSUFI">Service to</param>
		/// <param name="m3FEVTY">Event type from</param>
		/// <param name="m3TEVTY">Event type to</param>
		/// <param name="m3FRSCD">Transaction reason from</param>
		/// <param name="m3TRSCD">Transaction reason to</param>
		/// <param name="m3FMWNO">Work order number from</param>
		/// <param name="m3TMWNO">Work order number to</param>
		/// <param name="m3FRORC">Reference order category from</param>
		/// <param name="m3TRORC">Reference order category to</param>
		/// <param name="m3FRORN">Reference order number from</param>
		/// <param name="m3TRORN">Reference order number to</param>
		/// <param name="m3FRORL">Reference order line from</param>
		/// <param name="m3TRORL">Reference order line to</param>
		/// <param name="m3FRESP">Responsible from</param>
		/// <param name="m3TRESP">Responsible to</param>
		/// <param name="m3FORTY">Order type from</param>
		/// <param name="m3TORTY">Order type to</param>
		/// <param name="m3FWHST">Status - manufacturing order from</param>
		/// <param name="m3TWHST">Status - manufacturing order to</param>
		/// <param name="m3FPROJ">Project number from</param>
		/// <param name="m3TPROJ">Project number to</param>
		/// <param name="m3FELNO">Project element from</param>
		/// <param name="m3TELNO">Project element to</param>
		/// <param name="m3FCFI1">User-defined field 1 - item from</param>
		/// <param name="m3TCFI1">User-defined field 1 - item to</param>
		/// <param name="m3FPLGR">Work center from</param>
		/// <param name="m3TPLGR">Work center to</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="m3COPY">Number of copies</param>
		/// <param name="m3PWEL">Print skill</param>
		/// <param name="m3PTOL">Prt tools</param>
		/// <param name="m3PDOC">Prt documents</param>
		/// <param name="m3PINS">Prt inspection</param>
		/// <param name="m3CPNM">Contact person</param>
		/// <param name="m3EMAL">Electronic mail address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrintWorkOrder(
			DateTime? m3FSTDT = null, 
			DateTime? m3TSTDT = null, 
			string m3FFACI = null, 
			string m3TFACI = null, 
			string m3FPRNO = null, 
			string m3TPRNO = null, 
			string m3FBANO = null, 
			string m3TBANO = null, 
			string m3FSTRT = null, 
			string m3TSTRT = null, 
			string m3FSUFI = null, 
			string m3TSUFI = null, 
			string m3FEVTY = null, 
			string m3TEVTY = null, 
			string m3FRSCD = null, 
			string m3TRSCD = null, 
			string m3FMWNO = null, 
			string m3TMWNO = null, 
			int? m3FRORC = null, 
			int? m3TRORC = null, 
			string m3FRORN = null, 
			string m3TRORN = null, 
			int? m3FRORL = null, 
			int? m3TRORL = null, 
			string m3FRESP = null, 
			string m3TRESP = null, 
			string m3FORTY = null, 
			string m3TORTY = null, 
			string m3FWHST = null, 
			string m3TWHST = null, 
			string m3FPROJ = null, 
			string m3TPROJ = null, 
			string m3FELNO = null, 
			string m3TELNO = null, 
			string m3FCFI1 = null, 
			string m3TCFI1 = null, 
			string m3FPLGR = null, 
			string m3TPLGR = null, 
			string m3DOVA = null, 
			int? m3COPY = null, 
			int? m3PWEL = null, 
			int? m3PTOL = null, 
			int? m3PDOC = null, 
			int? m3PINS = null, 
			string m3CPNM = null, 
			string m3EMAL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/PrintWorkOrder",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3FSTDT.HasValue)
				request.WithQueryParameter("FSTDT", m3FSTDT.Value.ToM3String());
			if (m3TSTDT.HasValue)
				request.WithQueryParameter("TSTDT", m3TSTDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3FFACI))
				request.WithQueryParameter("FFACI", m3FFACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFACI))
				request.WithQueryParameter("TFACI", m3TFACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FPRNO))
				request.WithQueryParameter("FPRNO", m3FPRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TPRNO))
				request.WithQueryParameter("TPRNO", m3TPRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FBANO))
				request.WithQueryParameter("FBANO", m3FBANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TBANO))
				request.WithQueryParameter("TBANO", m3TBANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FSTRT))
				request.WithQueryParameter("FSTRT", m3FSTRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSTRT))
				request.WithQueryParameter("TSTRT", m3TSTRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3FSUFI))
				request.WithQueryParameter("FSUFI", m3FSUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSUFI))
				request.WithQueryParameter("TSUFI", m3TSUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FEVTY))
				request.WithQueryParameter("FEVTY", m3FEVTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEVTY))
				request.WithQueryParameter("TEVTY", m3TEVTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRSCD))
				request.WithQueryParameter("FRSCD", m3FRSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRSCD))
				request.WithQueryParameter("TRSCD", m3TRSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMWNO))
				request.WithQueryParameter("FMWNO", m3FMWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TMWNO))
				request.WithQueryParameter("TMWNO", m3TMWNO.Trim());
			if (m3FRORC.HasValue)
				request.WithQueryParameter("FRORC", m3FRORC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRORC.HasValue)
				request.WithQueryParameter("TRORC", m3TRORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRORN))
				request.WithQueryParameter("FRORN", m3FRORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRORN))
				request.WithQueryParameter("TRORN", m3TRORN.Trim());
			if (m3FRORL.HasValue)
				request.WithQueryParameter("FRORL", m3FRORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRORL.HasValue)
				request.WithQueryParameter("TRORL", m3TRORL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRESP))
				request.WithQueryParameter("FRESP", m3FRESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRESP))
				request.WithQueryParameter("TRESP", m3TRESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FORTY))
				request.WithQueryParameter("FORTY", m3FORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3TORTY))
				request.WithQueryParameter("TORTY", m3TORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3FWHST))
				request.WithQueryParameter("FWHST", m3FWHST.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWHST))
				request.WithQueryParameter("TWHST", m3TWHST.Trim());
			if (!string.IsNullOrWhiteSpace(m3FPROJ))
				request.WithQueryParameter("FPROJ", m3FPROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3TPROJ))
				request.WithQueryParameter("TPROJ", m3TPROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3FELNO))
				request.WithQueryParameter("FELNO", m3FELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TELNO))
				request.WithQueryParameter("TELNO", m3TELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCFI1))
				request.WithQueryParameter("FCFI1", m3FCFI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TCFI1))
				request.WithQueryParameter("TCFI1", m3TCFI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FPLGR))
				request.WithQueryParameter("FPLGR", m3FPLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3TPLGR))
				request.WithQueryParameter("TPLGR", m3TPLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());
			if (m3COPY.HasValue)
				request.WithQueryParameter("COPY", m3COPY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PWEL.HasValue)
				request.WithQueryParameter("PWEL", m3PWEL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PTOL.HasValue)
				request.WithQueryParameter("PTOL", m3PTOL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PDOC.HasValue)
				request.WithQueryParameter("PDOC", m3PDOC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PINS.HasValue)
				request.WithQueryParameter("PINS", m3PINS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CPNM))
				request.WithQueryParameter("CPNM", m3CPNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMAL))
				request.WithQueryParameter("EMAL", m3EMAL.Trim());

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
