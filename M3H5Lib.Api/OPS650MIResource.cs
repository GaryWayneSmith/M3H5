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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name PrintLabel
		/// Description Prints Labels
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FITN">From Item number</param>
		/// <param name="m3_TITN">To Item number</param>
		/// <param name="m3_FITG">From item group</param>
		/// <param name="m3_TITG">To item group</param>
		/// <param name="m3_FICL">From Product group</param>
		/// <param name="m3_TICL">To Product group</param>
		/// <param name="m3_FSUN">From main supplier</param>
		/// <param name="m3_TSUN">To main supplier</param>
		/// <param name="m3_FWHS">From Location</param>
		/// <param name="m3_TWHS">To Location</param>
		/// <param name="m3_FOPL">From Planning method</param>
		/// <param name="m3_TOPL">To Planning method</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_SPDT">Sales price date</param>
		/// <param name="m3_PRRF">Price list</param>
		/// <param name="m3_PSTQ">Physical stock</param>
		/// <param name="m3_PLSI">Label type</param>
		/// <param name="m3_POVL">Override label type</param>
		/// <param name="m3_PAUT">Auto gen label</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_CHID">Changed by</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrintLabel(
			string m3_FITN = null, 
			string m3_TITN = null, 
			string m3_FITG = null, 
			string m3_TITG = null, 
			string m3_FICL = null, 
			string m3_TICL = null, 
			string m3_FSUN = null, 
			string m3_TSUN = null, 
			string m3_FWHS = null, 
			string m3_TWHS = null, 
			int? m3_FOPL = null, 
			int? m3_TOPL = null, 
			string m3_WHLO = null, 
			DateTime? m3_SPDT = null, 
			string m3_PRRF = null, 
			int? m3_PSTQ = null, 
			string m3_PLSI = null, 
			string m3_POVL = null, 
			int? m3_PAUT = null, 
			string m3_CUNO = null, 
			string m3_CUCD = null, 
			string m3_CHID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrintLabel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FITN))
				request.WithQueryParameter("FITN", m3_FITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TITN))
				request.WithQueryParameter("TITN", m3_TITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FITG))
				request.WithQueryParameter("FITG", m3_FITG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TITG))
				request.WithQueryParameter("TITG", m3_TITG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FICL))
				request.WithQueryParameter("FICL", m3_FICL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TICL))
				request.WithQueryParameter("TICL", m3_TICL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FSUN))
				request.WithQueryParameter("FSUN", m3_FSUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSUN))
				request.WithQueryParameter("TSUN", m3_TSUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FWHS))
				request.WithQueryParameter("FWHS", m3_FWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWHS))
				request.WithQueryParameter("TWHS", m3_TWHS.Trim());
			if (m3_FOPL.HasValue)
				request.WithQueryParameter("FOPL", m3_FOPL.Value.ToString());
			if (m3_TOPL.HasValue)
				request.WithQueryParameter("TOPL", m3_TOPL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_SPDT.HasValue)
				request.WithQueryParameter("SPDT", m3_SPDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PRRF))
				request.WithQueryParameter("PRRF", m3_PRRF.Trim());
			if (m3_PSTQ.HasValue)
				request.WithQueryParameter("PSTQ", m3_PSTQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLSI))
				request.WithQueryParameter("PLSI", m3_PLSI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POVL))
				request.WithQueryParameter("POVL", m3_POVL.Trim());
			if (m3_PAUT.HasValue)
				request.WithQueryParameter("PAUT", m3_PAUT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());

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
