/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.MNS111MI;
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
	/// Name: MNS111MI
	/// Component Name: Menu
	/// Description: Api: Functions - menu
	/// Version Release: 14.x
	///</summary>
	public partial class MNS111MIResource : M3BaseResourceEndpoint
	{
		public MNS111MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MNS111MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name List
		/// Description List a menu
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MNID">Menu (Required)</param>
		/// <param name="m3MNVR">Menu version</param>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3MNID, 
			string m3MNVR = null, 
			decimal? m3LMTS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/List",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MNID))
				throw new ArgumentNullException(nameof(m3MNID));

			// Set mandatory parameters
			request
				.WithQueryParameter("MNID", m3MNID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MNVR))
				request.WithQueryParameter("MNVR", m3MNVR.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ListResponse>(
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
		/// Name ListAll
		/// Description List complete menu tree
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MNVR">Menu version</param>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListAllResponse></returns>
		/// <exception cref="M3Exception<ListAllResponse>"></exception>
		public async Task<M3Response<ListAllResponse>> ListAll(
			string m3MNVR = null, 
			decimal? m3LMTS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ListAll",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MNVR))
				request.WithQueryParameter("MNVR", m3MNVR.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ListAllResponse>(
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
		/// Name ListAllAuth
		/// Description List complete authorized menu tree
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MNVR">Menu version</param>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListAllAuthResponse></returns>
		/// <exception cref="M3Exception<ListAllAuthResponse>"></exception>
		public async Task<M3Response<ListAllAuthResponse>> ListAllAuth(
			string m3MNVR = null, 
			decimal? m3LMTS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ListAllAuth",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MNVR))
				request.WithQueryParameter("MNVR", m3MNVR.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ListAllAuthResponse>(
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
		/// Name ListAuth
		/// Description List a menu, select authourized functions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MNID">Menu (Required)</param>
		/// <param name="m3MNVR">Menu version</param>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListAuthResponse></returns>
		/// <exception cref="M3Exception<ListAuthResponse>"></exception>
		public async Task<M3Response<ListAuthResponse>> ListAuth(
			string m3MNID, 
			string m3MNVR = null, 
			decimal? m3LMTS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ListAuth",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MNID))
				throw new ArgumentNullException(nameof(m3MNID));

			// Set mandatory parameters
			request
				.WithQueryParameter("MNID", m3MNID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MNVR))
				request.WithQueryParameter("MNVR", m3MNVR.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ListAuthResponse>(
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
		/// Name ListTree
		/// Description List complete menu tree starting from root menu
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MNID">Root menu (Required)</param>
		/// <param name="m3MNVR">Menu version</param>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListTreeResponse></returns>
		/// <exception cref="M3Exception<ListTreeResponse>"></exception>
		public async Task<M3Response<ListTreeResponse>> ListTree(
			string m3MNID, 
			string m3MNVR = null, 
			decimal? m3LMTS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ListTree",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MNID))
				throw new ArgumentNullException(nameof(m3MNID));

			// Set mandatory parameters
			request
				.WithQueryParameter("MNID", m3MNID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MNVR))
				request.WithQueryParameter("MNVR", m3MNVR.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ListTreeResponse>(
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
		/// Name ListTreeAuth
		/// Description List authorized menu tree starting from root menu
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MNID">Root menu (Required)</param>
		/// <param name="m3MNVR">Menu version</param>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListTreeAuthResponse></returns>
		/// <exception cref="M3Exception<ListTreeAuthResponse>"></exception>
		public async Task<M3Response<ListTreeAuthResponse>> ListTreeAuth(
			string m3MNID, 
			string m3MNVR = null, 
			decimal? m3LMTS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ListTreeAuth",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MNID))
				throw new ArgumentNullException(nameof(m3MNID));

			// Set mandatory parameters
			request
				.WithQueryParameter("MNID", m3MNID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MNVR))
				request.WithQueryParameter("MNVR", m3MNVR.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ListTreeAuthResponse>(
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
