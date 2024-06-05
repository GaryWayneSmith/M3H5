/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3CONI">Key search id (Required)</param>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3SQNR">Sequence number (Required)</param>
		/// <param name="m3FL01">Field (Required)</param>
		/// <param name="m3USID">User</param>
		/// <param name="m3ROLL">Role</param>
		/// <param name="m3PGNM">Program name</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3TX30">Text</param>
		/// <param name="m3MSID">Message ID</param>
		/// <param name="m3FL02">Field</param>
		/// <param name="m3FL03">Field</param>
		/// <param name="m3FL04">Field</param>
		/// <param name="m3FL05">Field</param>
		/// <param name="m3FL06">Field</param>
		/// <param name="m3FL07">Field</param>
		/// <param name="m3FL08">Field</param>
		/// <param name="m3FL09">Field</param>
		/// <param name="m3FL10">Field</param>
		/// <param name="m3FL11">Field</param>
		/// <param name="m3FL12">Field</param>
		/// <param name="m3FL13">Field</param>
		/// <param name="m3FL14">Field</param>
		/// <param name="m3FL15">Field</param>
		/// <param name="m3FL16">Field</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3SQRY">Search query</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3PRIO">Priority</param>
		/// <param name="m3FLDT">Field type</param>
		/// <param name="m3SCNI">Sub search ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddKeySearch(
			string m3CONI, 
			string m3FILE, 
			int m3SQNR, 
			string m3FL01, 
			string m3USID = null, 
			string m3ROLL = null, 
			string m3PGNM = null, 
			string m3TX15 = null, 
			string m3TX30 = null, 
			string m3MSID = null, 
			string m3FL02 = null, 
			string m3FL03 = null, 
			string m3FL04 = null, 
			string m3FL05 = null, 
			string m3FL06 = null, 
			string m3FL07 = null, 
			string m3FL08 = null, 
			string m3FL09 = null, 
			string m3FL10 = null, 
			string m3FL11 = null, 
			string m3FL12 = null, 
			string m3FL13 = null, 
			string m3FL14 = null, 
			string m3FL15 = null, 
			string m3FL16 = null, 
			decimal? m3TXID = null, 
			string m3SQRY = null, 
			string m3STAT = null, 
			int? m3PRIO = null, 
			string m3FLDT = null, 
			string m3SCNI = null, 
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
			if (string.IsNullOrWhiteSpace(m3CONI))
				throw new ArgumentNullException(nameof(m3CONI));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FL01))
				throw new ArgumentNullException(nameof(m3FL01));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONI", m3CONI.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("SQNR", m3SQNR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FL01", m3FL01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ROLL))
				request.WithQueryParameter("ROLL", m3ROLL.Trim());
			if (!string.IsNullOrWhiteSpace(m3PGNM))
				request.WithQueryParameter("PGNM", m3PGNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX30))
				request.WithQueryParameter("TX30", m3TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSID))
				request.WithQueryParameter("MSID", m3MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL02))
				request.WithQueryParameter("FL02", m3FL02.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL03))
				request.WithQueryParameter("FL03", m3FL03.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL04))
				request.WithQueryParameter("FL04", m3FL04.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL05))
				request.WithQueryParameter("FL05", m3FL05.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL06))
				request.WithQueryParameter("FL06", m3FL06.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL07))
				request.WithQueryParameter("FL07", m3FL07.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL08))
				request.WithQueryParameter("FL08", m3FL08.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL09))
				request.WithQueryParameter("FL09", m3FL09.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL10))
				request.WithQueryParameter("FL10", m3FL10.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL11))
				request.WithQueryParameter("FL11", m3FL11.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL12))
				request.WithQueryParameter("FL12", m3FL12.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL13))
				request.WithQueryParameter("FL13", m3FL13.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL14))
				request.WithQueryParameter("FL14", m3FL14.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL15))
				request.WithQueryParameter("FL15", m3FL15.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL16))
				request.WithQueryParameter("FL16", m3FL16.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SQRY))
				request.WithQueryParameter("SQRY", m3SQRY.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3PRIO.HasValue)
				request.WithQueryParameter("PRIO", m3PRIO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FLDT))
				request.WithQueryParameter("FLDT", m3FLDT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SCNI))
				request.WithQueryParameter("SCNI", m3SCNI.Trim());

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
		/// Name DelKeySearch
		/// Description Delete a key search record
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3CONI">Key search id (Required)</param>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3SQNR">Sequence number (Required)</param>
		/// <param name="m3USID">User</param>
		/// <param name="m3ROLL">Role</param>
		/// <param name="m3PGNM">Program name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelKeySearch(
			string m3CONI, 
			string m3FILE, 
			int m3SQNR, 
			string m3USID = null, 
			string m3ROLL = null, 
			string m3PGNM = null, 
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
			if (string.IsNullOrWhiteSpace(m3CONI))
				throw new ArgumentNullException(nameof(m3CONI));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONI", m3CONI.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("SQNR", m3SQNR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ROLL))
				request.WithQueryParameter("ROLL", m3ROLL.Trim());
			if (!string.IsNullOrWhiteSpace(m3PGNM))
				request.WithQueryParameter("PGNM", m3PGNM.Trim());

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
		/// Name GetKeySearch
		/// Description Retrieve a single key search record
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3CONI">Key search id (Required)</param>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3SQNR">Sequence number (Required)</param>
		/// <param name="m3USID">User</param>
		/// <param name="m3ROLL">Role</param>
		/// <param name="m3PGNM">Program name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetKeySearchResponse></returns>
		/// <exception cref="M3Exception<GetKeySearchResponse>"></exception>
		public async Task<M3Response<GetKeySearchResponse>> GetKeySearch(
			string m3CONI, 
			string m3FILE, 
			int m3SQNR, 
			string m3USID = null, 
			string m3ROLL = null, 
			string m3PGNM = null, 
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
			if (string.IsNullOrWhiteSpace(m3CONI))
				throw new ArgumentNullException(nameof(m3CONI));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONI", m3CONI.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("SQNR", m3SQNR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ROLL))
				request.WithQueryParameter("ROLL", m3ROLL.Trim());
			if (!string.IsNullOrWhiteSpace(m3PGNM))
				request.WithQueryParameter("PGNM", m3PGNM.Trim());

			// Execute the request
			var result = await Execute<GetKeySearchResponse>(
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
		/// Name LstKeySearch
		/// Description List key searches
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3CONI">Key search id</param>
		/// <param name="m3FILE">File</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstKeySearchResponse></returns>
		/// <exception cref="M3Exception<LstKeySearchResponse>"></exception>
		public async Task<M3Response<LstKeySearchResponse>> LstKeySearch(
			string m3CONI = null, 
			string m3FILE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3CONI))
				request.WithQueryParameter("CONI", m3CONI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());

			// Execute the request
			var result = await Execute<LstKeySearchResponse>(
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
		/// Name UpdKeySearch
		/// Description Update an existing key search record
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3CONI">Key search id (Required)</param>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3SQNR">Sequence number (Required)</param>
		/// <param name="m3USID">User</param>
		/// <param name="m3ROLL">Role</param>
		/// <param name="m3PGNM">Program name</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3TX30">Text</param>
		/// <param name="m3MSID">Message ID</param>
		/// <param name="m3FL01">Field</param>
		/// <param name="m3FL02">Field</param>
		/// <param name="m3FL03">Field</param>
		/// <param name="m3FL04">Field</param>
		/// <param name="m3FL05">Field</param>
		/// <param name="m3FL06">Field</param>
		/// <param name="m3FL07">Field</param>
		/// <param name="m3FL08">Field</param>
		/// <param name="m3FL09">Field</param>
		/// <param name="m3FL10">Field</param>
		/// <param name="m3FL11">Field</param>
		/// <param name="m3FL12">Field</param>
		/// <param name="m3FL13">Field</param>
		/// <param name="m3FL14">Field</param>
		/// <param name="m3FL15">Field</param>
		/// <param name="m3FL16">Field</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3SQRY">Search query</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3PRIO">Priority</param>
		/// <param name="m3FLDT">Field type</param>
		/// <param name="m3SCNI">Sub search ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdKeySearch(
			string m3CONI, 
			string m3FILE, 
			int m3SQNR, 
			string m3USID = null, 
			string m3ROLL = null, 
			string m3PGNM = null, 
			string m3TX15 = null, 
			string m3TX30 = null, 
			string m3MSID = null, 
			string m3FL01 = null, 
			string m3FL02 = null, 
			string m3FL03 = null, 
			string m3FL04 = null, 
			string m3FL05 = null, 
			string m3FL06 = null, 
			string m3FL07 = null, 
			string m3FL08 = null, 
			string m3FL09 = null, 
			string m3FL10 = null, 
			string m3FL11 = null, 
			string m3FL12 = null, 
			string m3FL13 = null, 
			string m3FL14 = null, 
			string m3FL15 = null, 
			string m3FL16 = null, 
			decimal? m3TXID = null, 
			string m3SQRY = null, 
			string m3STAT = null, 
			int? m3PRIO = null, 
			string m3FLDT = null, 
			string m3SCNI = null, 
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
			if (string.IsNullOrWhiteSpace(m3CONI))
				throw new ArgumentNullException(nameof(m3CONI));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONI", m3CONI.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("SQNR", m3SQNR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ROLL))
				request.WithQueryParameter("ROLL", m3ROLL.Trim());
			if (!string.IsNullOrWhiteSpace(m3PGNM))
				request.WithQueryParameter("PGNM", m3PGNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX30))
				request.WithQueryParameter("TX30", m3TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSID))
				request.WithQueryParameter("MSID", m3MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL01))
				request.WithQueryParameter("FL01", m3FL01.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL02))
				request.WithQueryParameter("FL02", m3FL02.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL03))
				request.WithQueryParameter("FL03", m3FL03.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL04))
				request.WithQueryParameter("FL04", m3FL04.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL05))
				request.WithQueryParameter("FL05", m3FL05.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL06))
				request.WithQueryParameter("FL06", m3FL06.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL07))
				request.WithQueryParameter("FL07", m3FL07.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL08))
				request.WithQueryParameter("FL08", m3FL08.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL09))
				request.WithQueryParameter("FL09", m3FL09.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL10))
				request.WithQueryParameter("FL10", m3FL10.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL11))
				request.WithQueryParameter("FL11", m3FL11.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL12))
				request.WithQueryParameter("FL12", m3FL12.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL13))
				request.WithQueryParameter("FL13", m3FL13.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL14))
				request.WithQueryParameter("FL14", m3FL14.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL15))
				request.WithQueryParameter("FL15", m3FL15.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL16))
				request.WithQueryParameter("FL16", m3FL16.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SQRY))
				request.WithQueryParameter("SQRY", m3SQRY.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3PRIO.HasValue)
				request.WithQueryParameter("PRIO", m3PRIO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FLDT))
				request.WithQueryParameter("FLDT", m3FLDT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SCNI))
				request.WithQueryParameter("SCNI", m3SCNI.Trim());

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
