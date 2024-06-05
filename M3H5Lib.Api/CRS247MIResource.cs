/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.CRS247MI;
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
	/// Name: CRS247MI
	/// Component Name: StandardNumbering
	/// Description: Api: Standard Numbering-Functional Area
	/// Version Release: 13.1
	///</summary>
	public partial class CRS247MIResource : M3BaseResourceEndpoint
	{
		public CRS247MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS247MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddFunctionArea
		/// Description Add Function Area
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3STNC">Standard numbering system (Required)</param>
		/// <param name="m3FLVL">Numbering level (Required)</param>
		/// <param name="m3FUNC">Function area (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFunctionArea(
			string m3STNC, 
			int m3FLVL, 
			string m3FUNC, 
			string m3TX40, 
			string m3TX15 = null, 
			string m3STAT = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddFunctionArea",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STNC))
				throw new ArgumentNullException(nameof(m3STNC));
			if (string.IsNullOrWhiteSpace(m3FUNC))
				throw new ArgumentNullException(nameof(m3FUNC));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("STNC", m3STNC.Trim())
				.WithQueryParameter("FLVL", m3FLVL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FUNC", m3FUNC.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelFunctionArea
		/// Description Delete Function Area
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3STNC">Standard numbering system (Required)</param>
		/// <param name="m3FLVL">Numbering level (Required)</param>
		/// <param name="m3FUNC">Function area (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelFunctionArea(
			string m3STNC, 
			int m3FLVL, 
			string m3FUNC, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelFunctionArea",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STNC))
				throw new ArgumentNullException(nameof(m3STNC));
			if (string.IsNullOrWhiteSpace(m3FUNC))
				throw new ArgumentNullException(nameof(m3FUNC));

			// Set mandatory parameters
			request
				.WithQueryParameter("STNC", m3STNC.Trim())
				.WithQueryParameter("FLVL", m3FLVL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FUNC", m3FUNC.Trim());

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
		/// Name GetFunctionArea
		/// Description GetFunctionArea
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3STNC">Standard numbering system (Required)</param>
		/// <param name="m3FLVL">Numbering level (Required)</param>
		/// <param name="m3FUNC">Function area (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFunctionAreaResponse></returns>
		/// <exception cref="M3Exception<GetFunctionAreaResponse>"></exception>
		public async Task<M3Response<GetFunctionAreaResponse>> GetFunctionArea(
			string m3STNC, 
			int m3FLVL, 
			string m3FUNC, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetFunctionArea",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STNC))
				throw new ArgumentNullException(nameof(m3STNC));
			if (string.IsNullOrWhiteSpace(m3FUNC))
				throw new ArgumentNullException(nameof(m3FUNC));

			// Set mandatory parameters
			request
				.WithQueryParameter("STNC", m3STNC.Trim())
				.WithQueryParameter("FLVL", m3FLVL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FUNC", m3FUNC.Trim());

			// Execute the request
			var result = await Execute<GetFunctionAreaResponse>(
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
		/// Name LstFunctionArea
		/// Description List Function Area
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3STNC">Standard numbering system (Required)</param>
		/// <param name="m3FLVL">Numbering level</param>
		/// <param name="m3FUNC">Function area</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFunctionAreaResponse></returns>
		/// <exception cref="M3Exception<LstFunctionAreaResponse>"></exception>
		public async Task<M3Response<LstFunctionAreaResponse>> LstFunctionArea(
			string m3STNC, 
			int? m3FLVL = null, 
			string m3FUNC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFunctionArea",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STNC))
				throw new ArgumentNullException(nameof(m3STNC));

			// Set mandatory parameters
			request
				.WithQueryParameter("STNC", m3STNC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3FLVL.HasValue)
				request.WithQueryParameter("FLVL", m3FLVL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FUNC))
				request.WithQueryParameter("FUNC", m3FUNC.Trim());

			// Execute the request
			var result = await Execute<LstFunctionAreaResponse>(
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
		/// Name UpdFunctionArea
		/// Description Update Function Area
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3STNC">Standard numbering system (Required)</param>
		/// <param name="m3FLVL">Numbering level (Required)</param>
		/// <param name="m3FUNC">Function area (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdFunctionArea(
			string m3STNC, 
			int m3FLVL, 
			string m3FUNC, 
			string m3TX40, 
			string m3TX15 = null, 
			string m3STAT = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdFunctionArea",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STNC))
				throw new ArgumentNullException(nameof(m3STNC));
			if (string.IsNullOrWhiteSpace(m3FUNC))
				throw new ArgumentNullException(nameof(m3FUNC));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("STNC", m3STNC.Trim())
				.WithQueryParameter("FLVL", m3FLVL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FUNC", m3FUNC.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
