/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.QMS013MI;
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
	/// Name: QMS013MI
	/// Component Name: Measurement instrument
	/// Description: Api: Measurement instrument interface
	/// Version Release: 
	///</summary>
	public partial class QMS013MIResource : M3BaseResourceEndpoint
	{
		public QMS013MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QMS013MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddMsrmntInstr
		/// Description Add a measurement instrument
		/// Version Release: 
		/// </summary>
		/// <param name="m3MSIN">Measurement instrument (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3ACTF">Active</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddMsrmntInstr(
			string m3MSIN, 
			string m3TX40, 
			int? m3ACTF = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddMsrmntInstr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSIN))
				throw new ArgumentNullException(nameof(m3MSIN));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSIN", m3MSIN.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3ACTF.HasValue)
				request.WithQueryParameter("ACTF", m3ACTF.Value.ToString(CultureInfo.CurrentCulture));

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

		/// <summary>
		/// Name DltMsrmntInstr
		/// Description Delete measurement instrument
		/// Version Release: 
		/// </summary>
		/// <param name="m3MSIN">Measurement instrument (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltMsrmntInstr(
			string m3MSIN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltMsrmntInstr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSIN))
				throw new ArgumentNullException(nameof(m3MSIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSIN", m3MSIN.Trim());

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

		/// <summary>
		/// Name GetMsrmntInstr
		/// Description Get measurement instrument
		/// Version Release: 
		/// </summary>
		/// <param name="m3MSIN">Measurement instrument (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMsrmntInstrResponse></returns>
		/// <exception cref="M3Exception<GetMsrmntInstrResponse>"></exception>
		public async Task<M3Response<GetMsrmntInstrResponse>> GetMsrmntInstr(
			string m3MSIN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetMsrmntInstr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSIN))
				throw new ArgumentNullException(nameof(m3MSIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSIN", m3MSIN.Trim());

			// Execute the request
			var result = await Execute<GetMsrmntInstrResponse>(
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
		/// Name LstMsrmntInstr
		/// Description List measurement instrument
		/// Version Release: 
		/// </summary>
		/// <param name="m3MSIN">Measurement instrument (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMsrmntInstrResponse></returns>
		/// <exception cref="M3Exception<LstMsrmntInstrResponse>"></exception>
		public async Task<M3Response<LstMsrmntInstrResponse>> LstMsrmntInstr(
			string m3MSIN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMsrmntInstr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSIN))
				throw new ArgumentNullException(nameof(m3MSIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSIN", m3MSIN.Trim());

			// Execute the request
			var result = await Execute<LstMsrmntInstrResponse>(
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
		/// Name UpdMsrmntInstr
		/// Description Update measurement instrument
		/// Version Release: 
		/// </summary>
		/// <param name="m3MSIN">Measurement instrument (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3ACTF">Active</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdMsrmntInstr(
			string m3MSIN, 
			string m3TX40, 
			int? m3ACTF = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdMsrmntInstr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSIN))
				throw new ArgumentNullException(nameof(m3MSIN));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSIN", m3MSIN.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3ACTF.HasValue)
				request.WithQueryParameter("ACTF", m3ACTF.Value.ToString(CultureInfo.CurrentCulture));

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
