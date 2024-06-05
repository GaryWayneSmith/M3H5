/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.RPS080MI;
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
	/// Name: RPS080MI
	/// Component Name: List of  Point of time tables
	/// Description: Api:  Point of time table
	/// Version Release: 14.x
	///</summary>
	public partial class RPS080MIResource : M3BaseResourceEndpoint
	{
		public RPS080MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "RPS080MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstPointOfTime
		/// Description List Poist of time tables
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3PTTT">Point of time type</param>
		/// <param name="m3FRPO">Point of time table</param>
		/// <param name="m3TOPO">Point of time table</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3ENDT">Finish date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPointOfTimeResponse></returns>
		/// <exception cref="M3Exception<LstPointOfTimeResponse>"></exception>
		public async Task<M3Response<LstPointOfTimeResponse>> LstPointOfTime(
			string m3WHLO = null, 
			string m3WHGR = null, 
			string m3PTTT = null, 
			string m3FRPO = null, 
			string m3TOPO = null, 
			DateTime? m3STDT = null, 
			DateTime? m3ENDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPointOfTime",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PTTT))
				request.WithQueryParameter("PTTT", m3PTTT.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRPO))
				request.WithQueryParameter("FRPO", m3FRPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOPO))
				request.WithQueryParameter("TOPO", m3TOPO.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3ENDT.HasValue)
				request.WithQueryParameter("ENDT", m3ENDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstPointOfTimeResponse>(
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
