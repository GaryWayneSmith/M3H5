/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.COS024MI;
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
	/// Name: COS024MI
	/// Component Name: LaborSellRate
	/// Description: Labor sell rate interface
	/// Version Release: 5ea0
	///</summary>
	public partial class COS024MIResource : M3BaseResourceEndpoint
	{
		public COS024MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "COS024MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add labor sell rate
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRIO">Priority (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3OBV5">Start value 5 (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3ALP1">Man-hour price (Required)</param>
		/// <param name="m3TODT">To date (Required)</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3DIVI, 
			string m3FACI, 
			int m3PRIO, 
			string m3OBV1, 
			string m3OBV5, 
			string m3CUCD, 
			DateTime m3STDT, 
			decimal m3ALP1, 
			DateTime m3TODT, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));
			if (string.IsNullOrWhiteSpace(m3OBV5))
				throw new ArgumentNullException(nameof(m3OBV5));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRIO", m3PRIO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OBV1", m3OBV1.Trim())
				.WithQueryParameter("OBV5", m3OBV5.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String())
				.WithQueryParameter("ALP1", m3ALP1.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TODT", m3TODT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());

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
		/// Name Delete
		/// Description Delete a labor sell rate record
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRIO">Priority (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3OBV5">Start value 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3DIVI, 
			string m3FACI, 
			int m3PRIO, 
			string m3OBV1, 
			string m3CUCD, 
			DateTime m3STDT, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
			string m3OBV5 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Delete",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRIO", m3PRIO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OBV1", m3OBV1.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV5))
				request.WithQueryParameter("OBV5", m3OBV5.Trim());

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
		/// Description Get a labor sell rate record
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRIO">Priority (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3OBV5">Start value 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3DIVI, 
			string m3FACI, 
			int m3PRIO, 
			string m3OBV1, 
			string m3CUCD, 
			DateTime m3STDT, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
			string m3OBV5 = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRIO", m3PRIO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OBV1", m3OBV1.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV5))
				request.WithQueryParameter("OBV5", m3OBV5.Trim());

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
		/// Name List
		/// Description List records
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3DIVI = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

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
		/// Name LstByPriority
		/// Description List records in priority order
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRIO">Priority</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByPriorityResponse></returns>
		/// <exception cref="M3Exception<LstByPriorityResponse>"></exception>
		public async Task<M3Response<LstByPriorityResponse>> LstByPriority(
			int? m3PRIO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByPriority",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3PRIO.HasValue)
				request.WithQueryParameter("PRIO", m3PRIO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstByPriorityResponse>(
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
		/// Name Update
		/// Description Update
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRIO">Priority (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3OBV5">Start value 5 (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3ALP1">Man-hour price</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Update(
			string m3DIVI, 
			string m3FACI, 
			int m3PRIO, 
			string m3OBV1, 
			string m3OBV5, 
			string m3CUCD, 
			DateTime m3STDT, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
			decimal? m3ALP1 = null, 
			DateTime? m3TODT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Update",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));
			if (string.IsNullOrWhiteSpace(m3OBV5))
				throw new ArgumentNullException(nameof(m3OBV5));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRIO", m3PRIO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OBV1", m3OBV1.Trim())
				.WithQueryParameter("OBV5", m3OBV5.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (m3ALP1.HasValue)
				request.WithQueryParameter("ALP1", m3ALP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());

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
