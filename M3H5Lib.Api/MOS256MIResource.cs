/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MOS256MI;
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
	/// Name: MOS256MI
	/// Component Name: AsBuildStructure
	/// Description: Api: As Build Structure
	/// Version Release: 5ea1
	///</summary>
	public partial class MOS256MIResource : M3BaseResourceEndpoint
	{
		public MOS256MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS256MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetNextHigher
		/// Description GetNextHigher
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SER2">Serial number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetNextHigherResponse></returns>
		/// <exception cref="M3Exception<GetNextHigherResponse>"></exception>
		public async Task<M3Response<GetNextHigherResponse>> GetNextHigher(
			string m3_ITNO, 
			string m3_SER2, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetNextHigher",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SER2))
				throw new ArgumentNullException("m3_SER2");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SER2", m3_SER2.Trim());

			// Execute the request
			var result = await Execute<GetNextHigherResponse>(
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
		/// Name LstAsBuild
		/// Description List As Build Structure
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_MTRL">Component identity (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_EXPA">Expand structure Y/N</param>
		/// <param name="m3_MEVA">Display Meter Values Y/N</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAsBuildResponse></returns>
		/// <exception cref="M3Exception<LstAsBuildResponse>"></exception>
		public async Task<M3Response<LstAsBuildResponse>> LstAsBuild(
			string m3_MTRL, 
			string m3_SERN, 
			int? m3_EXPA = null, 
			int? m3_MEVA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAsBuild",
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

			// Set optional parameters, checking for null/blank data for each element
			if (m3_EXPA.HasValue)
				request.WithQueryParameter("EXPA", m3_EXPA.Value.ToString());
			if (m3_MEVA.HasValue)
				request.WithQueryParameter("MEVA", m3_MEVA.Value.ToString());

			// Execute the request
			var result = await Execute<LstAsBuildResponse>(
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
		/// Name LstAsBuildLevel
		/// Description List As Build StructureAllLevels
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_MTRL">Component identity (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAsBuildLevelResponse></returns>
		/// <exception cref="M3Exception<LstAsBuildLevelResponse>"></exception>
		public async Task<M3Response<LstAsBuildLevelResponse>> LstAsBuildLevel(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAsBuildLevel",
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
			var result = await Execute<LstAsBuildLevelResponse>(
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
