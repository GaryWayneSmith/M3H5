/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CMS030MI;
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
	/// Name: CMS030MI
	/// Component Name: KeySearch
	/// Description: Key search
	/// Version Release: 5ea0
	///</summary>
	public partial class CMS030MIResource : M3BaseResourceEndpoint
	{
		public CMS030MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS030MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddKeySearch
		/// Description Add key search
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_CONI">Key search id (Required)</param>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_SQNR">Sequence number (Required)</param>
		/// <param name="m3_FL01">Field (Required)</param>
		/// <param name="m3_USID">User</param>
		/// <param name="m3_ROLL">Role</param>
		/// <param name="m3_PGNM">Program name</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TX30">Text</param>
		/// <param name="m3_MSID">Message ID</param>
		/// <param name="m3_FL02">Field</param>
		/// <param name="m3_FL03">Field</param>
		/// <param name="m3_FL04">Field</param>
		/// <param name="m3_FL05">Field</param>
		/// <param name="m3_FL06">Field</param>
		/// <param name="m3_FL07">Field</param>
		/// <param name="m3_FL08">Field</param>
		/// <param name="m3_FL09">Field</param>
		/// <param name="m3_FL10">Field</param>
		/// <param name="m3_FL11">Field</param>
		/// <param name="m3_FL12">Field</param>
		/// <param name="m3_FL13">Field</param>
		/// <param name="m3_FL14">Field</param>
		/// <param name="m3_FL15">Field</param>
		/// <param name="m3_FL16">Field</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_SQRY">Search query</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_PRIO">Priority</param>
		/// <param name="m3_FLDT">Field type</param>
		/// <param name="m3_SCNI">Sub search ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddKeySearch(
			string m3_CONI, 
			string m3_FILE, 
			int m3_SQNR, 
			string m3_FL01, 
			string m3_USID = null, 
			string m3_ROLL = null, 
			string m3_PGNM = null, 
			string m3_TX15 = null, 
			string m3_TX30 = null, 
			string m3_MSID = null, 
			string m3_FL02 = null, 
			string m3_FL03 = null, 
			string m3_FL04 = null, 
			string m3_FL05 = null, 
			string m3_FL06 = null, 
			string m3_FL07 = null, 
			string m3_FL08 = null, 
			string m3_FL09 = null, 
			string m3_FL10 = null, 
			string m3_FL11 = null, 
			string m3_FL12 = null, 
			string m3_FL13 = null, 
			string m3_FL14 = null, 
			string m3_FL15 = null, 
			string m3_FL16 = null, 
			decimal? m3_TXID = null, 
			string m3_SQRY = null, 
			string m3_STAT = null, 
			int? m3_PRIO = null, 
			string m3_FLDT = null, 
			string m3_SCNI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddKeySearch",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CONI))
				throw new ArgumentNullException("m3_CONI");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FL01))
				throw new ArgumentNullException("m3_FL01");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONI", m3_CONI.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("SQNR", m3_SQNR.ToString())
				.WithQueryParameter("FL01", m3_FL01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ROLL))
				request.WithQueryParameter("ROLL", m3_ROLL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PGNM))
				request.WithQueryParameter("PGNM", m3_PGNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX30))
				request.WithQueryParameter("TX30", m3_TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSID))
				request.WithQueryParameter("MSID", m3_MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL02))
				request.WithQueryParameter("FL02", m3_FL02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL03))
				request.WithQueryParameter("FL03", m3_FL03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL04))
				request.WithQueryParameter("FL04", m3_FL04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL05))
				request.WithQueryParameter("FL05", m3_FL05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL06))
				request.WithQueryParameter("FL06", m3_FL06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL07))
				request.WithQueryParameter("FL07", m3_FL07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL08))
				request.WithQueryParameter("FL08", m3_FL08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL09))
				request.WithQueryParameter("FL09", m3_FL09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL10))
				request.WithQueryParameter("FL10", m3_FL10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL11))
				request.WithQueryParameter("FL11", m3_FL11.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL12))
				request.WithQueryParameter("FL12", m3_FL12.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL13))
				request.WithQueryParameter("FL13", m3_FL13.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL14))
				request.WithQueryParameter("FL14", m3_FL14.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL15))
				request.WithQueryParameter("FL15", m3_FL15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL16))
				request.WithQueryParameter("FL16", m3_FL16.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SQRY))
				request.WithQueryParameter("SQRY", m3_SQRY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_PRIO.HasValue)
				request.WithQueryParameter("PRIO", m3_PRIO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FLDT))
				request.WithQueryParameter("FLDT", m3_FLDT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCNI))
				request.WithQueryParameter("SCNI", m3_SCNI.Trim());

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
		/// Name DelKeySearch
		/// Description Delete a key search record
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_CONI">Key search id (Required)</param>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_SQNR">Sequence number (Required)</param>
		/// <param name="m3_USID">User</param>
		/// <param name="m3_ROLL">Role</param>
		/// <param name="m3_PGNM">Program name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelKeySearch(
			string m3_CONI, 
			string m3_FILE, 
			int m3_SQNR, 
			string m3_USID = null, 
			string m3_ROLL = null, 
			string m3_PGNM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelKeySearch",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CONI))
				throw new ArgumentNullException("m3_CONI");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONI", m3_CONI.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("SQNR", m3_SQNR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ROLL))
				request.WithQueryParameter("ROLL", m3_ROLL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PGNM))
				request.WithQueryParameter("PGNM", m3_PGNM.Trim());

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
		/// Name GetKeySearch
		/// Description Retrieve a single key search record
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_CONI">Key search id (Required)</param>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_SQNR">Sequence number (Required)</param>
		/// <param name="m3_USID">User</param>
		/// <param name="m3_ROLL">Role</param>
		/// <param name="m3_PGNM">Program name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetKeySearchResponse></returns>
		/// <exception cref="M3Exception<GetKeySearchResponse>"></exception>
		public async Task<M3Response<GetKeySearchResponse>> GetKeySearch(
			string m3_CONI, 
			string m3_FILE, 
			int m3_SQNR, 
			string m3_USID = null, 
			string m3_ROLL = null, 
			string m3_PGNM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetKeySearch",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CONI))
				throw new ArgumentNullException("m3_CONI");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONI", m3_CONI.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("SQNR", m3_SQNR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ROLL))
				request.WithQueryParameter("ROLL", m3_ROLL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PGNM))
				request.WithQueryParameter("PGNM", m3_PGNM.Trim());

			// Execute the request
			var result = await Execute<GetKeySearchResponse>(
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
		/// Name LstKeySearch
		/// Description List key searches
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_CONI">Key search id</param>
		/// <param name="m3_FILE">File</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstKeySearchResponse></returns>
		/// <exception cref="M3Exception<LstKeySearchResponse>"></exception>
		public async Task<M3Response<LstKeySearchResponse>> LstKeySearch(
			string m3_CONI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstKeySearch",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CONI))
				request.WithQueryParameter("CONI", m3_CONI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());

			// Execute the request
			var result = await Execute<LstKeySearchResponse>(
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
		/// Name UpdKeySearch
		/// Description Update an existing key search record
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_CONI">Key search id (Required)</param>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_SQNR">Sequence number (Required)</param>
		/// <param name="m3_USID">User</param>
		/// <param name="m3_ROLL">Role</param>
		/// <param name="m3_PGNM">Program name</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TX30">Text</param>
		/// <param name="m3_MSID">Message ID</param>
		/// <param name="m3_FL01">Field</param>
		/// <param name="m3_FL02">Field</param>
		/// <param name="m3_FL03">Field</param>
		/// <param name="m3_FL04">Field</param>
		/// <param name="m3_FL05">Field</param>
		/// <param name="m3_FL06">Field</param>
		/// <param name="m3_FL07">Field</param>
		/// <param name="m3_FL08">Field</param>
		/// <param name="m3_FL09">Field</param>
		/// <param name="m3_FL10">Field</param>
		/// <param name="m3_FL11">Field</param>
		/// <param name="m3_FL12">Field</param>
		/// <param name="m3_FL13">Field</param>
		/// <param name="m3_FL14">Field</param>
		/// <param name="m3_FL15">Field</param>
		/// <param name="m3_FL16">Field</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_SQRY">Search query</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_PRIO">Priority</param>
		/// <param name="m3_FLDT">Field type</param>
		/// <param name="m3_SCNI">Sub search ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdKeySearch(
			string m3_CONI, 
			string m3_FILE, 
			int m3_SQNR, 
			string m3_USID = null, 
			string m3_ROLL = null, 
			string m3_PGNM = null, 
			string m3_TX15 = null, 
			string m3_TX30 = null, 
			string m3_MSID = null, 
			string m3_FL01 = null, 
			string m3_FL02 = null, 
			string m3_FL03 = null, 
			string m3_FL04 = null, 
			string m3_FL05 = null, 
			string m3_FL06 = null, 
			string m3_FL07 = null, 
			string m3_FL08 = null, 
			string m3_FL09 = null, 
			string m3_FL10 = null, 
			string m3_FL11 = null, 
			string m3_FL12 = null, 
			string m3_FL13 = null, 
			string m3_FL14 = null, 
			string m3_FL15 = null, 
			string m3_FL16 = null, 
			decimal? m3_TXID = null, 
			string m3_SQRY = null, 
			string m3_STAT = null, 
			int? m3_PRIO = null, 
			string m3_FLDT = null, 
			string m3_SCNI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdKeySearch",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CONI))
				throw new ArgumentNullException("m3_CONI");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONI", m3_CONI.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("SQNR", m3_SQNR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ROLL))
				request.WithQueryParameter("ROLL", m3_ROLL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PGNM))
				request.WithQueryParameter("PGNM", m3_PGNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX30))
				request.WithQueryParameter("TX30", m3_TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSID))
				request.WithQueryParameter("MSID", m3_MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL01))
				request.WithQueryParameter("FL01", m3_FL01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL02))
				request.WithQueryParameter("FL02", m3_FL02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL03))
				request.WithQueryParameter("FL03", m3_FL03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL04))
				request.WithQueryParameter("FL04", m3_FL04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL05))
				request.WithQueryParameter("FL05", m3_FL05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL06))
				request.WithQueryParameter("FL06", m3_FL06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL07))
				request.WithQueryParameter("FL07", m3_FL07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL08))
				request.WithQueryParameter("FL08", m3_FL08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL09))
				request.WithQueryParameter("FL09", m3_FL09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL10))
				request.WithQueryParameter("FL10", m3_FL10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL11))
				request.WithQueryParameter("FL11", m3_FL11.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL12))
				request.WithQueryParameter("FL12", m3_FL12.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL13))
				request.WithQueryParameter("FL13", m3_FL13.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL14))
				request.WithQueryParameter("FL14", m3_FL14.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL15))
				request.WithQueryParameter("FL15", m3_FL15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL16))
				request.WithQueryParameter("FL16", m3_FL16.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SQRY))
				request.WithQueryParameter("SQRY", m3_SQRY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_PRIO.HasValue)
				request.WithQueryParameter("PRIO", m3_PRIO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FLDT))
				request.WithQueryParameter("FLDT", m3_FLDT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCNI))
				request.WithQueryParameter("SCNI", m3_SCNI.Trim());

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
	}
}
// EOF
