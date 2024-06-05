/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CBS003MI;
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
	/// Name: CBS003MI
	/// Component Name: Capability range
	/// Description: Api: Capability range
	/// Version Release: 13.1
	///</summary>
	public partial class CBS003MIResource : M3BaseResourceEndpoint
	{
		public CBS003MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CBS003MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_OBCA">Capability object category (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_CATY">Capability type (Required)</param>
		/// <param name="m3_CABI">Capability (Required)</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_FRDT">From date</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="m3_AALF">From attribute value</param>
		/// <param name="m3_AALT">To attribute value</param>
		/// <param name="m3_ANUF">From attribute value</param>
		/// <param name="m3_ANUT">To attribute value</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			int m3_OBCA, 
			string m3_OBV1, 
			string m3_CATY, 
			string m3_CABI, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			DateTime? m3_FRDT = null, 
			int? m3_SEQN = null, 
			string m3_AALF = null, 
			string m3_AALT = null, 
			decimal? m3_ANUF = null, 
			decimal? m3_ANUT = null, 
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
			if (m3_FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3_FRDT.Value.ToM3String());
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AALF))
				request.WithQueryParameter("AALF", m3_AALF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AALT))
				request.WithQueryParameter("AALT", m3_AALT.Trim());
			if (m3_ANUF.HasValue)
				request.WithQueryParameter("ANUF", m3_ANUF.Value.ToString());
			if (m3_ANUT.HasValue)
				request.WithQueryParameter("ANUT", m3_ANUT.Value.ToString());
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
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_CATY">Capability type (Required)</param>
		/// <param name="m3_CABI">Capability (Required)</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_FRDT">From date</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="m3_AALF">From attribute value</param>
		/// <param name="m3_AALT">To attribute value</param>
		/// <param name="m3_ANUF">From attribute value</param>
		/// <param name="m3_ANUT">To attribute value</param>
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
			string m3_OBV1, 
			string m3_CATY, 
			string m3_CABI, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			DateTime? m3_FRDT = null, 
			int? m3_SEQN = null, 
			string m3_AALF = null, 
			string m3_AALT = null, 
			decimal? m3_ANUF = null, 
			decimal? m3_ANUT = null, 
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
			if (m3_FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3_FRDT.Value.ToM3String());
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AALF))
				request.WithQueryParameter("AALF", m3_AALF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AALT))
				request.WithQueryParameter("AALT", m3_AALT.Trim());
			if (m3_ANUF.HasValue)
				request.WithQueryParameter("ANUF", m3_ANUF.Value.ToString());
			if (m3_ANUT.HasValue)
				request.WithQueryParameter("ANUT", m3_ANUT.Value.ToString());
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
		/// Name Cpy
		/// Description Copy
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_OBCA">Capability object category (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_CATY">Capability type (Required)</param>
		/// <param name="m3_CABI">Capability (Required)</param>
		/// <param name="m3_SEQN">Sequence number (Required)</param>
		/// <param name="m3_TBV1">To Start value 1 (Required)</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_FRDT">From date</param>
		/// <param name="m3_TBV2">Start value 2</param>
		/// <param name="m3_TBV3">Start value 3</param>
		/// <param name="m3_TATY">Capability type</param>
		/// <param name="m3_TABI">Capability</param>
		/// <param name="m3_FRDX">From date</param>
		/// <param name="m3_TEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Cpy(
			int m3_OBCA, 
			string m3_OBV1, 
			string m3_CATY, 
			string m3_CABI, 
			int m3_SEQN, 
			string m3_TBV1, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			DateTime? m3_FRDT = null, 
			string m3_TBV2 = null, 
			string m3_TBV3 = null, 
			string m3_TATY = null, 
			string m3_TABI = null, 
			DateTime? m3_FRDX = null, 
			int? m3_TEQN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Cpy",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");
			if (string.IsNullOrWhiteSpace(m3_CATY))
				throw new ArgumentNullException("m3_CATY");
			if (string.IsNullOrWhiteSpace(m3_CABI))
				throw new ArgumentNullException("m3_CABI");
			if (string.IsNullOrWhiteSpace(m3_TBV1))
				throw new ArgumentNullException("m3_TBV1");

			// Set mandatory parameters
			request
				.WithQueryParameter("OBCA", m3_OBCA.ToString())
				.WithQueryParameter("OBV1", m3_OBV1.Trim())
				.WithQueryParameter("CATY", m3_CATY.Trim())
				.WithQueryParameter("CABI", m3_CABI.Trim())
				.WithQueryParameter("SEQN", m3_SEQN.ToString())
				.WithQueryParameter("TBV1", m3_TBV1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (m3_FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3_FRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TBV2))
				request.WithQueryParameter("TBV2", m3_TBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TBV3))
				request.WithQueryParameter("TBV3", m3_TBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TATY))
				request.WithQueryParameter("TATY", m3_TATY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TABI))
				request.WithQueryParameter("TABI", m3_TABI.Trim());
			if (m3_FRDX.HasValue)
				request.WithQueryParameter("FRDX", m3_FRDX.Value.ToM3String());
			if (m3_TEQN.HasValue)
				request.WithQueryParameter("TEQN", m3_TEQN.Value.ToString());

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
		/// <param name="m3_CATY">Capability type (Required)</param>
		/// <param name="m3_CABI">Capability (Required)</param>
		/// <param name="m3_SEQN">Sequence number (Required)</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_FRDT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			int m3_OBCA, 
			string m3_CATY, 
			string m3_CABI, 
			int m3_SEQN, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			DateTime? m3_FRDT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CATY))
				throw new ArgumentNullException("m3_CATY");
			if (string.IsNullOrWhiteSpace(m3_CABI))
				throw new ArgumentNullException("m3_CABI");

			// Set mandatory parameters
			request
				.WithQueryParameter("OBCA", m3_OBCA.ToString())
				.WithQueryParameter("CATY", m3_CATY.Trim())
				.WithQueryParameter("CABI", m3_CABI.Trim())
				.WithQueryParameter("SEQN", m3_SEQN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (m3_FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3_FRDT.Value.ToM3String());

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
		/// <param name="m3_SEQN">Sequence number (Required)</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_FRDT">From date</param>
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
			int m3_SEQN, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			DateTime? m3_FRDT = null, 
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
				.WithQueryParameter("CABI", m3_CABI.Trim())
				.WithQueryParameter("SEQN", m3_SEQN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (m3_FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3_FRDT.Value.ToM3String());

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
		/// <param name="m3_OBCA">Capability object category (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			int m3_OBCA, 
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

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("OBCA", m3_OBCA.ToString());

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
