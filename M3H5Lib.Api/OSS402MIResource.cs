/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.OSS402MI;
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
	/// Name: OSS402MI
	/// Component Name: DatasetKeysAccumulators
	/// Description: Dataset keys  and accumulators interface
	/// Version Release: 12.1
	///</summary>
	public partial class OSS402MIResource : M3BaseResourceEndpoint
	{
		public OSS402MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OSS402MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Select
		/// Description Select Dataset Accumulators
		/// Version Release: 12.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FDAT">From Dataset</param>
		/// <param name="m3_TDAT">To Dataset</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectResponse></returns>
		/// <exception cref="M3Exception<SelectResponse>"></exception>
		public async Task<M3Response<SelectResponse>> Select(
			int? m3_CONO = null, 
			string m3_FDAT = null, 
			string m3_TDAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Select",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FDAT))
				request.WithQueryParameter("FDAT", m3_FDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TDAT))
				request.WithQueryParameter("TDAT", m3_TDAT.Trim());

			// Execute the request
			var result = await Execute<SelectResponse>(
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
