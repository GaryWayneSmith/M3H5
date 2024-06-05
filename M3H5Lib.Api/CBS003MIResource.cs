/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3OBCA">Capability object category (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3CATY">Capability type (Required)</param>
		/// <param name="m3CABI">Capability (Required)</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3FRDT">From date</param>
		/// <param name="m3SEQN">Sequence number</param>
		/// <param name="m3AALF">From attribute value</param>
		/// <param name="m3AALT">To attribute value</param>
		/// <param name="m3ANUF">From attribute value</param>
		/// <param name="m3ANUT">To attribute value</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			int m3OBCA, 
			string m3OBV1, 
			string m3CATY, 
			string m3CABI, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			DateTime? m3FRDT = null, 
			int? m3SEQN = null, 
			string m3AALF = null, 
			string m3AALT = null, 
			decimal? m3ANUF = null, 
			decimal? m3ANUT = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));
			if (string.IsNullOrWhiteSpace(m3CATY))
				throw new ArgumentNullException(nameof(m3CATY));
			if (string.IsNullOrWhiteSpace(m3CABI))
				throw new ArgumentNullException(nameof(m3CABI));

			// Set mandatory parameters
			request
				.WithQueryParameter("OBCA", m3OBCA.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OBV1", m3OBV1.Trim())
				.WithQueryParameter("CATY", m3CATY.Trim())
				.WithQueryParameter("CABI", m3CABI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (m3FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3FRDT.Value.ToM3String());
			if (m3SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3SEQN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AALF))
				request.WithQueryParameter("AALF", m3AALF.Trim());
			if (!string.IsNullOrWhiteSpace(m3AALT))
				request.WithQueryParameter("AALT", m3AALT.Trim());
			if (m3ANUF.HasValue)
				request.WithQueryParameter("ANUF", m3ANUF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ANUT.HasValue)
				request.WithQueryParameter("ANUT", m3ANUT.Value.ToString(CultureInfo.CurrentCulture));
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
		/// Name Chg
		/// Description Change/Update
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3OBCA">Capability object category (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3CATY">Capability type (Required)</param>
		/// <param name="m3CABI">Capability (Required)</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3FRDT">From date</param>
		/// <param name="m3SEQN">Sequence number</param>
		/// <param name="m3AALF">From attribute value</param>
		/// <param name="m3AALT">To attribute value</param>
		/// <param name="m3ANUF">From attribute value</param>
		/// <param name="m3ANUT">To attribute value</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Chg(
			int m3OBCA, 
			string m3OBV1, 
			string m3CATY, 
			string m3CABI, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			DateTime? m3FRDT = null, 
			int? m3SEQN = null, 
			string m3AALF = null, 
			string m3AALT = null, 
			decimal? m3ANUF = null, 
			decimal? m3ANUT = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Chg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));
			if (string.IsNullOrWhiteSpace(m3CATY))
				throw new ArgumentNullException(nameof(m3CATY));
			if (string.IsNullOrWhiteSpace(m3CABI))
				throw new ArgumentNullException(nameof(m3CABI));

			// Set mandatory parameters
			request
				.WithQueryParameter("OBCA", m3OBCA.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OBV1", m3OBV1.Trim())
				.WithQueryParameter("CATY", m3CATY.Trim())
				.WithQueryParameter("CABI", m3CABI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (m3FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3FRDT.Value.ToM3String());
			if (m3SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3SEQN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AALF))
				request.WithQueryParameter("AALF", m3AALF.Trim());
			if (!string.IsNullOrWhiteSpace(m3AALT))
				request.WithQueryParameter("AALT", m3AALT.Trim());
			if (m3ANUF.HasValue)
				request.WithQueryParameter("ANUF", m3ANUF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ANUT.HasValue)
				request.WithQueryParameter("ANUT", m3ANUT.Value.ToString(CultureInfo.CurrentCulture));
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
		/// Name Cpy
		/// Description Copy
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3OBCA">Capability object category (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3CATY">Capability type (Required)</param>
		/// <param name="m3CABI">Capability (Required)</param>
		/// <param name="m3SEQN">Sequence number (Required)</param>
		/// <param name="m3TBV1">To Start value 1 (Required)</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3FRDT">From date</param>
		/// <param name="m3TBV2">Start value 2</param>
		/// <param name="m3TBV3">Start value 3</param>
		/// <param name="m3TATY">Capability type</param>
		/// <param name="m3TABI">Capability</param>
		/// <param name="m3FRDX">From date</param>
		/// <param name="m3TEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Cpy(
			int m3OBCA, 
			string m3OBV1, 
			string m3CATY, 
			string m3CABI, 
			int m3SEQN, 
			string m3TBV1, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			DateTime? m3FRDT = null, 
			string m3TBV2 = null, 
			string m3TBV3 = null, 
			string m3TATY = null, 
			string m3TABI = null, 
			DateTime? m3FRDX = null, 
			int? m3TEQN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Cpy",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));
			if (string.IsNullOrWhiteSpace(m3CATY))
				throw new ArgumentNullException(nameof(m3CATY));
			if (string.IsNullOrWhiteSpace(m3CABI))
				throw new ArgumentNullException(nameof(m3CABI));
			if (string.IsNullOrWhiteSpace(m3TBV1))
				throw new ArgumentNullException(nameof(m3TBV1));

			// Set mandatory parameters
			request
				.WithQueryParameter("OBCA", m3OBCA.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OBV1", m3OBV1.Trim())
				.WithQueryParameter("CATY", m3CATY.Trim())
				.WithQueryParameter("CABI", m3CABI.Trim())
				.WithQueryParameter("SEQN", m3SEQN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TBV1", m3TBV1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (m3FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3FRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TBV2))
				request.WithQueryParameter("TBV2", m3TBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TBV3))
				request.WithQueryParameter("TBV3", m3TBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3TATY))
				request.WithQueryParameter("TATY", m3TATY.Trim());
			if (!string.IsNullOrWhiteSpace(m3TABI))
				request.WithQueryParameter("TABI", m3TABI.Trim());
			if (m3FRDX.HasValue)
				request.WithQueryParameter("FRDX", m3FRDX.Value.ToM3String());
			if (m3TEQN.HasValue)
				request.WithQueryParameter("TEQN", m3TEQN.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Del
		/// Description Delete
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3OBCA">Capability object category (Required)</param>
		/// <param name="m3CATY">Capability type (Required)</param>
		/// <param name="m3CABI">Capability (Required)</param>
		/// <param name="m3SEQN">Sequence number (Required)</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3FRDT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			int m3OBCA, 
			string m3CATY, 
			string m3CABI, 
			int m3SEQN, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			DateTime? m3FRDT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Del",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CATY))
				throw new ArgumentNullException(nameof(m3CATY));
			if (string.IsNullOrWhiteSpace(m3CABI))
				throw new ArgumentNullException(nameof(m3CABI));

			// Set mandatory parameters
			request
				.WithQueryParameter("OBCA", m3OBCA.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CATY", m3CATY.Trim())
				.WithQueryParameter("CABI", m3CABI.Trim())
				.WithQueryParameter("SEQN", m3SEQN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (m3FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3FRDT.Value.ToM3String());

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
		/// Name Get
		/// Description Get
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3OBCA">Capability object category (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3CATY">Capability type (Required)</param>
		/// <param name="m3CABI">Capability (Required)</param>
		/// <param name="m3SEQN">Sequence number (Required)</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3FRDT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			int m3OBCA, 
			string m3OBV1, 
			string m3CATY, 
			string m3CABI, 
			int m3SEQN, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			DateTime? m3FRDT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));
			if (string.IsNullOrWhiteSpace(m3CATY))
				throw new ArgumentNullException(nameof(m3CATY));
			if (string.IsNullOrWhiteSpace(m3CABI))
				throw new ArgumentNullException(nameof(m3CABI));

			// Set mandatory parameters
			request
				.WithQueryParameter("OBCA", m3OBCA.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OBV1", m3OBV1.Trim())
				.WithQueryParameter("CATY", m3CATY.Trim())
				.WithQueryParameter("CABI", m3CABI.Trim())
				.WithQueryParameter("SEQN", m3SEQN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (m3FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3FRDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name Lst
		/// Description List
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3OBCA">Capability object category (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			int m3OBCA, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Lst",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("OBCA", m3OBCA.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstResponse>(
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
