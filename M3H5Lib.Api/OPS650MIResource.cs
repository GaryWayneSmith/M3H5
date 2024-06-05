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
	/// Name: OPS650MI
	/// Component Name: PointOfSale
	/// Description: API: Print label
	/// Version Release: 14.x
	///</summary>
	public partial class OPS650MIResource : M3BaseResourceEndpoint
	{
		public OPS650MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OPS650MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name PrintLabel
		/// Description Prints Labels
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FITN">From Item number</param>
		/// <param name="m3TITN">To Item number</param>
		/// <param name="m3FITG">From item group</param>
		/// <param name="m3TITG">To item group</param>
		/// <param name="m3FICL">From Product group</param>
		/// <param name="m3TICL">To Product group</param>
		/// <param name="m3FSUN">From main supplier</param>
		/// <param name="m3TSUN">To main supplier</param>
		/// <param name="m3FWHS">From Location</param>
		/// <param name="m3TWHS">To Location</param>
		/// <param name="m3FOPL">From Planning method</param>
		/// <param name="m3TOPL">To Planning method</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3SPDT">Sales price date</param>
		/// <param name="m3PRRF">Price list</param>
		/// <param name="m3PSTQ">Physical stock</param>
		/// <param name="m3PLSI">Label type</param>
		/// <param name="m3POVL">Override label type</param>
		/// <param name="m3PAUT">Auto gen label</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3CHID">Changed by</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrintLabel(
			string m3FITN = null, 
			string m3TITN = null, 
			string m3FITG = null, 
			string m3TITG = null, 
			string m3FICL = null, 
			string m3TICL = null, 
			string m3FSUN = null, 
			string m3TSUN = null, 
			string m3FWHS = null, 
			string m3TWHS = null, 
			int? m3FOPL = null, 
			int? m3TOPL = null, 
			string m3WHLO = null, 
			DateTime? m3SPDT = null, 
			string m3PRRF = null, 
			int? m3PSTQ = null, 
			string m3PLSI = null, 
			string m3POVL = null, 
			int? m3PAUT = null, 
			string m3CUNO = null, 
			string m3CUCD = null, 
			string m3CHID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/PrintLabel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FITN))
				request.WithQueryParameter("FITN", m3FITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TITN))
				request.WithQueryParameter("TITN", m3TITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FITG))
				request.WithQueryParameter("FITG", m3FITG.Trim());
			if (!string.IsNullOrWhiteSpace(m3TITG))
				request.WithQueryParameter("TITG", m3TITG.Trim());
			if (!string.IsNullOrWhiteSpace(m3FICL))
				request.WithQueryParameter("FICL", m3FICL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TICL))
				request.WithQueryParameter("TICL", m3TICL.Trim());
			if (!string.IsNullOrWhiteSpace(m3FSUN))
				request.WithQueryParameter("FSUN", m3FSUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSUN))
				request.WithQueryParameter("TSUN", m3TSUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FWHS))
				request.WithQueryParameter("FWHS", m3FWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWHS))
				request.WithQueryParameter("TWHS", m3TWHS.Trim());
			if (m3FOPL.HasValue)
				request.WithQueryParameter("FOPL", m3FOPL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOPL.HasValue)
				request.WithQueryParameter("TOPL", m3TOPL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3SPDT.HasValue)
				request.WithQueryParameter("SPDT", m3SPDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PRRF))
				request.WithQueryParameter("PRRF", m3PRRF.Trim());
			if (m3PSTQ.HasValue)
				request.WithQueryParameter("PSTQ", m3PSTQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLSI))
				request.WithQueryParameter("PLSI", m3PLSI.Trim());
			if (!string.IsNullOrWhiteSpace(m3POVL))
				request.WithQueryParameter("POVL", m3POVL.Trim());
			if (m3PAUT.HasValue)
				request.WithQueryParameter("PAUT", m3PAUT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());

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
