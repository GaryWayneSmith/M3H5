/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.SES410MI;
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
	/// Name: SES410MI
	/// Component Name: eSign Program
	/// Description: eSign Program interface
	/// Version Release: 5ea0
	///</summary>
	public partial class SES410MIResource : M3BaseResourceEndpoint
	{
		public SES410MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "SES410MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetProgram
		/// Description Get data for an eSign Program
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PGNM">Program (Required)</param>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetProgramResponse></returns>
		/// <exception cref="M3Exception<GetProgramResponse>"></exception>
		public async Task<M3Response<GetProgramResponse>> GetProgram(
			string m3PGNM, 
			string m3FILE, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetProgram",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim());

			// Execute the request
			var result = await Execute<GetProgramResponse>(
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
		/// Name LstPrograms
		/// Description List data for eSign Programs
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PGNM">Program</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstProgramsResponse></returns>
		/// <exception cref="M3Exception<LstProgramsResponse>"></exception>
		public async Task<M3Response<LstProgramsResponse>> LstPrograms(
			string m3PGNM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPrograms",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PGNM))
				request.WithQueryParameter("PGNM", m3PGNM.Trim());

			// Execute the request
			var result = await Execute<LstProgramsResponse>(
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
		/// Name UpdProgram
		/// Description Update data for an eSign Program
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PGNM">Program (Required)</param>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3ESEV">Sign event</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdProgram(
			string m3PGNM, 
			string m3FILE, 
			int? m3ESEV = null, 
			string m3STAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdProgram",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3ESEV.HasValue)
				request.WithQueryParameter("ESEV", m3ESEV.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());

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
