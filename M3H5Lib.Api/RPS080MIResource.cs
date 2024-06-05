/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_PTTT">Point of time type</param>
		/// <param name="m3_FRPO">Point of time table</param>
		/// <param name="m3_TOPO">Point of time table</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_ENDT">Finish date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPointOfTimeResponse></returns>
		/// <exception cref="M3Exception<LstPointOfTimeResponse>"></exception>
		public async Task<M3Response<LstPointOfTimeResponse>> LstPointOfTime(
			string m3_WHLO = null, 
			string m3_WHGR = null, 
			string m3_PTTT = null, 
			string m3_FRPO = null, 
			string m3_TOPO = null, 
			DateTime? m3_STDT = null, 
			DateTime? m3_ENDT = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PTTT))
				request.WithQueryParameter("PTTT", m3_PTTT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRPO))
				request.WithQueryParameter("FRPO", m3_FRPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOPO))
				request.WithQueryParameter("TOPO", m3_TOPO.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_ENDT.HasValue)
				request.WithQueryParameter("ENDT", m3_ENDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstPointOfTimeResponse>(
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
