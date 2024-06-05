/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.BOOKMKMI;
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
	/// Name: BOOKMKMI
	/// Component Name: BookmarkMetadata
	/// Description: Bookmark metadata interface
	/// Version Release: 14.x
	///</summary>
	public partial class BOOKMKMIResource : M3BaseResourceEndpoint
	{
		public BOOKMKMIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "BOOKMKMI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetParByInfoCat
		/// Description Get bookmark parameters by information browse category
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IBCA">Information browser category (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetParByInfoCatResponse></returns>
		/// <exception cref="M3Exception<GetParByInfoCatResponse>"></exception>
		public async Task<M3Response<GetParByInfoCatResponse>> GetParByInfoCat(
			string m3_IBCA, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetParByInfoCat",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IBCA))
				throw new ArgumentNullException("m3_IBCA");

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3_IBCA.Trim());

			// Execute the request
			var result = await Execute<GetParByInfoCatResponse>(
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
		/// Name GetParByPgm
		/// Description Get bookmark parameters by program
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PGNM">Program name (Required)</param>
		/// <param name="m3_FILE">Table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetParByPgmResponse></returns>
		/// <exception cref="M3Exception<GetParByPgmResponse>"></exception>
		public async Task<M3Response<GetParByPgmResponse>> GetParByPgm(
			string m3_PGNM, 
			string m3_FILE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetParByPgm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());

			// Execute the request
			var result = await Execute<GetParByPgmResponse>(
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
		/// Name GetParByTable
		/// Description Get bookmark parameters by table
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetParByTableResponse></returns>
		/// <exception cref="M3Exception<GetParByTableResponse>"></exception>
		public async Task<M3Response<GetParByTableResponse>> GetParByTable(
			string m3_FILE, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetParByTable",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim());

			// Execute the request
			var result = await Execute<GetParByTableResponse>(
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
		/// Name LstExtraParams
		/// Description List extra bookmark parameters
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_PGNM">Program name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstExtraParamsResponse></returns>
		/// <exception cref="M3Exception<LstExtraParamsResponse>"></exception>
		public async Task<M3Response<LstExtraParamsResponse>> LstExtraParams(
			string m3_PGNM, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstExtraParams",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim());

			// Execute the request
			var result = await Execute<LstExtraParamsResponse>(
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
