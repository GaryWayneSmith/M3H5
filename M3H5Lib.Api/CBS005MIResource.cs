/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CBS005MI;
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
	/// Name: CBS005MI
	/// Component Name: Capability type
	/// Description: Api: Capability type
	/// Version Release: 13.1
	///</summary>
	public partial class CBS005MIResource : M3BaseResourceEndpoint
	{
		public CBS005MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CBS005MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CATY">Capability type (Required)</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_CACA">Capability category</param>
		/// <param name="m3_CAEX">Capability expiry method</param>
		/// <param name="m3_EXM1">Expiry meter 1</param>
		/// <param name="m3_EXL1">Expiry limit 1</param>
		/// <param name="m3_EXM2">Expiry meter 2</param>
		/// <param name="m3_EXL2">Expiry limit 2</param>
		/// <param name="m3_UNMS">Basic unit of measure</param>
		/// <param name="m3_CAHI">Capability history</param>
		/// <param name="m3_CARC">Capability range used</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_CATY, 
			string m3_TX15 = null, 
			string m3_TX40 = null, 
			int? m3_CACA = null, 
			int? m3_CAEX = null, 
			string m3_EXM1 = null, 
			decimal? m3_EXL1 = null, 
			string m3_EXM2 = null, 
			decimal? m3_EXL2 = null, 
			string m3_UNMS = null, 
			int? m3_CAHI = null, 
			int? m3_CARC = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CATY))
				throw new ArgumentNullException("m3_CATY");

			// Set mandatory parameters
			request
				.WithQueryParameter("CATY", m3_CATY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (m3_CACA.HasValue)
				request.WithQueryParameter("CACA", m3_CACA.Value.ToString());
			if (m3_CAEX.HasValue)
				request.WithQueryParameter("CAEX", m3_CAEX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EXM1))
				request.WithQueryParameter("EXM1", m3_EXM1.Trim());
			if (m3_EXL1.HasValue)
				request.WithQueryParameter("EXL1", m3_EXL1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EXM2))
				request.WithQueryParameter("EXM2", m3_EXM2.Trim());
			if (m3_EXL2.HasValue)
				request.WithQueryParameter("EXL2", m3_EXL2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNMS))
				request.WithQueryParameter("UNMS", m3_UNMS.Trim());
			if (m3_CAHI.HasValue)
				request.WithQueryParameter("CAHI", m3_CAHI.Value.ToString());
			if (m3_CARC.HasValue)
				request.WithQueryParameter("CARC", m3_CARC.Value.ToString());
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
		/// <param name="m3_CATY">Capability type (Required)</param>
		/// <param name="m3_CACA">Capability category (Required)</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_CAEX">Capability expiry method</param>
		/// <param name="m3_EXM1">Expiry meter 1</param>
		/// <param name="m3_EXL1">Expiry limit 1</param>
		/// <param name="m3_EXM2">Expiry meter 2</param>
		/// <param name="m3_EXL2">Expiry limit 2</param>
		/// <param name="m3_UNMS">Basic unit of measure</param>
		/// <param name="m3_CAHI">Capability history</param>
		/// <param name="m3_CARC">Capability range used</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Chg(
			string m3_CATY, 
			int m3_CACA, 
			string m3_TX15 = null, 
			string m3_TX40 = null, 
			int? m3_CAEX = null, 
			string m3_EXM1 = null, 
			decimal? m3_EXL1 = null, 
			string m3_EXM2 = null, 
			decimal? m3_EXL2 = null, 
			string m3_UNMS = null, 
			int? m3_CAHI = null, 
			int? m3_CARC = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CATY))
				throw new ArgumentNullException("m3_CATY");

			// Set mandatory parameters
			request
				.WithQueryParameter("CATY", m3_CATY.Trim())
				.WithQueryParameter("CACA", m3_CACA.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (m3_CAEX.HasValue)
				request.WithQueryParameter("CAEX", m3_CAEX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EXM1))
				request.WithQueryParameter("EXM1", m3_EXM1.Trim());
			if (m3_EXL1.HasValue)
				request.WithQueryParameter("EXL1", m3_EXL1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EXM2))
				request.WithQueryParameter("EXM2", m3_EXM2.Trim());
			if (m3_EXL2.HasValue)
				request.WithQueryParameter("EXL2", m3_EXL2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNMS))
				request.WithQueryParameter("UNMS", m3_UNMS.Trim());
			if (m3_CAHI.HasValue)
				request.WithQueryParameter("CAHI", m3_CAHI.Value.ToString());
			if (m3_CARC.HasValue)
				request.WithQueryParameter("CARC", m3_CARC.Value.ToString());
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
		/// <param name="m3_CATY">Capability type (Required)</param>
		/// <param name="m3_TATY">Capability type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Cpy(
			string m3_CATY, 
			string m3_TATY, 
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
			if (string.IsNullOrWhiteSpace(m3_CATY))
				throw new ArgumentNullException("m3_CATY");
			if (string.IsNullOrWhiteSpace(m3_TATY))
				throw new ArgumentNullException("m3_TATY");

			// Set mandatory parameters
			request
				.WithQueryParameter("CATY", m3_CATY.Trim())
				.WithQueryParameter("TATY", m3_TATY.Trim());

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
		/// <param name="m3_CATY">Capability type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			string m3_CATY, 
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

			// Set mandatory parameters
			request
				.WithQueryParameter("CATY", m3_CATY.Trim());

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
		/// <param name="m3_CATY">Capability type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_CATY, 
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
			if (string.IsNullOrWhiteSpace(m3_CATY))
				throw new ArgumentNullException("m3_CATY");

			// Set mandatory parameters
			request
				.WithQueryParameter("CATY", m3_CATY.Trim());

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
		/// <param name="m3_CATY">Capability type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3_CATY = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_CATY))
				request.WithQueryParameter("CATY", m3_CATY.Trim());

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
