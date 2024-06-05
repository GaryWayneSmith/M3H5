/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SER2">Serial number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetNextHigherResponse></returns>
		/// <exception cref="M3Exception<GetNextHigherResponse>"></exception>
		public async Task<M3Response<GetNextHigherResponse>> GetNextHigher(
			string m3ITNO, 
			string m3SER2, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SER2))
				throw new ArgumentNullException(nameof(m3SER2));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SER2", m3SER2.Trim());

			// Execute the request
			var result = await Execute<GetNextHigherResponse>(
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

		/// <summary>
		/// Name LstAsBuild
		/// Description List As Build Structure
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3MTRL">Component identity (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3EXPA">Expand structure Y/N</param>
		/// <param name="m3MEVA">Display Meter Values Y/N</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAsBuildResponse></returns>
		/// <exception cref="M3Exception<LstAsBuildResponse>"></exception>
		public async Task<M3Response<LstAsBuildResponse>> LstAsBuild(
			string m3MTRL, 
			string m3SERN, 
			int? m3EXPA = null, 
			int? m3MEVA = null, 
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
			if (string.IsNullOrWhiteSpace(m3MTRL))
				throw new ArgumentNullException(nameof(m3MTRL));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MTRL", m3MTRL.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3EXPA.HasValue)
				request.WithQueryParameter("EXPA", m3EXPA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MEVA.HasValue)
				request.WithQueryParameter("MEVA", m3MEVA.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAsBuildResponse>(
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

		/// <summary>
		/// Name LstAsBuildLevel
		/// Description List As Build StructureAllLevels
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3MTRL">Component identity (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAsBuildLevelResponse></returns>
		/// <exception cref="M3Exception<LstAsBuildLevelResponse>"></exception>
		public async Task<M3Response<LstAsBuildLevelResponse>> LstAsBuildLevel(
			string m3MTRL, 
			string m3SERN, 
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
			if (string.IsNullOrWhiteSpace(m3MTRL))
				throw new ArgumentNullException(nameof(m3MTRL));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MTRL", m3MTRL.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim());

			// Execute the request
			var result = await Execute<LstAsBuildLevelResponse>(
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
