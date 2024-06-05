/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.FAS845MI;
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
	/// Name: FAS845MI
	/// Component Name: DeprecaitionPlanSimulation
	/// Description: API: Deprecaition Plan Simulation batch interface
	/// Version Release: 5ea0
	///</summary>
	public partial class FAS845MIResource : M3BaseResourceEndpoint
	{
		public FAS845MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "FAS845MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name CrtSimulation
		/// Description Deprecaition Plan Simulation batch
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ASID">Fixed Asset (Required)</param>
		/// <param name="m3_SBNO">Fixed Asset Subnumber (Required)</param>
		/// <param name="m3_DPTP">Depreciation type (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CrtSimulationResponse></returns>
		/// <exception cref="M3Exception<CrtSimulationResponse>"></exception>
		public async Task<M3Response<CrtSimulationResponse>> CrtSimulation(
			string m3_ASID, 
			int m3_SBNO, 
			int m3_DPTP, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CrtSimulation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ASID))
				throw new ArgumentNullException("m3_ASID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ASID", m3_ASID.Trim())
				.WithQueryParameter("SBNO", m3_SBNO.ToString())
				.WithQueryParameter("DPTP", m3_DPTP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<CrtSimulationResponse>(
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
