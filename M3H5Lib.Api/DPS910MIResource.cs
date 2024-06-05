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
	/// Name: DPS910MI
	/// Component Name: Distribution
	/// Description: Api: Recreate distribution Levell
	/// Version Release: 15.x
	///</summary>
	public partial class DPS910MIResource : M3BaseResourceEndpoint
	{
		public DPS910MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "DPS910MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name CalcItmWhsDOLvl
		/// Description Recreate distribution level
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3_FITN">From Item number</param>
		/// <param name="m3_TITN">To Item number</param>
		/// <param name="m3_OLUP">Online update</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CalcItmWhsDOLvl(
			string m3_FITN = null, 
			string m3_TITN = null, 
			int? m3_OLUP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CalcItmWhsDOLvl",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FITN))
				request.WithQueryParameter("FITN", m3_FITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TITN))
				request.WithQueryParameter("TITN", m3_TITN.Trim());
			if (m3_OLUP.HasValue)
				request.WithQueryParameter("OLUP", m3_OLUP.Value.ToString());

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
