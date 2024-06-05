/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CBS007MI;
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
	/// Name: CBS007MI
	/// Component Name: Capability history
	/// Description: Api: Capability history
	/// Version Release: 13.1
	///</summary>
	public partial class CBS007MIResource : M3BaseResourceEndpoint
	{
		public CBS007MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CBS007MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_OBCA">Capability object category</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_CATY">Capability type</param>
		/// <param name="m3_CABI">Capability</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TRTM">Transaction time</param>
		/// <param name="m3_CLEV">Capability level</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_OBV1, 
			int? m3_OBCA = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_CATY = null, 
			string m3_CABI = null, 
			DateTime? m3_TRDT = null, 
			int? m3_TRTM = null, 
			int? m3_CLEV = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");

			// Set mandatory parameters
			request
				.WithQueryParameter("OBV1", m3_OBV1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_OBCA.HasValue)
				request.WithQueryParameter("OBCA", m3_OBCA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CATY))
				request.WithQueryParameter("CATY", m3_CATY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CABI))
				request.WithQueryParameter("CABI", m3_CABI.Trim());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());
			if (m3_CLEV.HasValue)
				request.WithQueryParameter("CLEV", m3_CLEV.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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

		/// <summary>
		/// Name Chg
		/// Description Change/Update
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_OBCA">Capability object category (Required)</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_CATY">Capability type</param>
		/// <param name="m3_CABI">Capability</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TRTM">Transaction time</param>
		/// <param name="m3_CLEV">Capability level</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Chg(
			int m3_OBCA, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_CATY = null, 
			string m3_CABI = null, 
			DateTime? m3_TRDT = null, 
			int? m3_TRTM = null, 
			int? m3_CLEV = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Chg",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("OBCA", m3_OBCA.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CATY))
				request.WithQueryParameter("CATY", m3_CATY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CABI))
				request.WithQueryParameter("CABI", m3_CABI.Trim());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());
			if (m3_CLEV.HasValue)
				request.WithQueryParameter("CLEV", m3_CLEV.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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

		/// <summary>
		/// Name Del
		/// Description Delete
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_OBCA">Capability object category (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_CATY">Capability type (Required)</param>
		/// <param name="m3_CABI">Capability (Required)</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TRTM">Transaction time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			int m3_OBCA, 
			string m3_OBV1, 
			string m3_CATY, 
			string m3_CABI, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			DateTime? m3_TRDT = null, 
			int? m3_TRTM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Del",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");
			if (string.IsNullOrWhiteSpace(m3_CATY))
				throw new ArgumentNullException("m3_CATY");
			if (string.IsNullOrWhiteSpace(m3_CABI))
				throw new ArgumentNullException("m3_CABI");

			// Set mandatory parameters
			request
				.WithQueryParameter("OBCA", m3_OBCA.ToString())
				.WithQueryParameter("OBV1", m3_OBV1.Trim())
				.WithQueryParameter("CATY", m3_CATY.Trim())
				.WithQueryParameter("CABI", m3_CABI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());

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

		/// <summary>
		/// Name Get
		/// Description Get
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_OBCA">Capability object category (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_CATY">Capability type (Required)</param>
		/// <param name="m3_CABI">Capability (Required)</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TRTM">Transaction time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			int m3_OBCA, 
			string m3_OBV1, 
			string m3_CATY, 
			string m3_CABI, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			DateTime? m3_TRDT = null, 
			int? m3_TRTM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");
			if (string.IsNullOrWhiteSpace(m3_CATY))
				throw new ArgumentNullException("m3_CATY");
			if (string.IsNullOrWhiteSpace(m3_CABI))
				throw new ArgumentNullException("m3_CABI");

			// Set mandatory parameters
			request
				.WithQueryParameter("OBCA", m3_OBCA.ToString())
				.WithQueryParameter("OBV1", m3_OBV1.Trim())
				.WithQueryParameter("CATY", m3_CATY.Trim())
				.WithQueryParameter("CABI", m3_CABI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name Lst
		/// Description List
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_OBCA">Capability object category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			int? m3_OBCA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Lst",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_OBCA.HasValue)
				request.WithQueryParameter("OBCA", m3_OBCA.Value.ToString());

			// Execute the request
			var result = await Execute<LstResponse>(
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
