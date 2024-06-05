/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add labor sell rate
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRIO">Priority (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_OBV5">Start value 5 (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_ALP1">Man-hour price (Required)</param>
		/// <param name="m3_TODT">To date (Required)</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_DIVI, 
			string m3_FACI, 
			int m3_PRIO, 
			string m3_OBV1, 
			string m3_OBV5, 
			string m3_CUCD, 
			DateTime m3_STDT, 
			decimal m3_ALP1, 
			DateTime m3_TODT, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");
			if (string.IsNullOrWhiteSpace(m3_OBV5))
				throw new ArgumentNullException("m3_OBV5");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRIO", m3_PRIO.ToString())
				.WithQueryParameter("OBV1", m3_OBV1.Trim())
				.WithQueryParameter("OBV5", m3_OBV5.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("ALP1", m3_ALP1.ToString())
				.WithQueryParameter("TODT", m3_TODT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());

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
		/// Name Delete
		/// Description Delete a labor sell rate record
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRIO">Priority (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_OBV5">Start value 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3_DIVI, 
			string m3_FACI, 
			int m3_PRIO, 
			string m3_OBV1, 
			string m3_CUCD, 
			DateTime m3_STDT, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
			string m3_OBV5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Delete",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRIO", m3_PRIO.ToString())
				.WithQueryParameter("OBV1", m3_OBV1.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV5))
				request.WithQueryParameter("OBV5", m3_OBV5.Trim());

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
		/// Description Get a labor sell rate record
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRIO">Priority (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_OBV5">Start value 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_DIVI, 
			string m3_FACI, 
			int m3_PRIO, 
			string m3_OBV1, 
			string m3_CUCD, 
			DateTime m3_STDT, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
			string m3_OBV5 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRIO", m3_PRIO.ToString())
				.WithQueryParameter("OBV1", m3_OBV1.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV5))
				request.WithQueryParameter("OBV5", m3_OBV5.Trim());

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
		/// Name List
		/// Description List records
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/List",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<ListResponse>(
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
		/// Name LstByPriority
		/// Description List records in priority order
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRIO">Priority</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByPriorityResponse></returns>
		/// <exception cref="M3Exception<LstByPriorityResponse>"></exception>
		public async Task<M3Response<LstByPriorityResponse>> LstByPriority(
			int? m3_PRIO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByPriority",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_PRIO.HasValue)
				request.WithQueryParameter("PRIO", m3_PRIO.Value.ToString());

			// Execute the request
			var result = await Execute<LstByPriorityResponse>(
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
		/// Name Update
		/// Description Update
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRIO">Priority (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_OBV5">Start value 5 (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_ALP1">Man-hour price</param>
		/// <param name="m3_TODT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Update(
			string m3_DIVI, 
			string m3_FACI, 
			int m3_PRIO, 
			string m3_OBV1, 
			string m3_OBV5, 
			string m3_CUCD, 
			DateTime m3_STDT, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
			decimal? m3_ALP1 = null, 
			DateTime? m3_TODT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Update",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");
			if (string.IsNullOrWhiteSpace(m3_OBV5))
				throw new ArgumentNullException("m3_OBV5");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRIO", m3_PRIO.ToString())
				.WithQueryParameter("OBV1", m3_OBV1.Trim())
				.WithQueryParameter("OBV5", m3_OBV5.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (m3_ALP1.HasValue)
				request.WithQueryParameter("ALP1", m3_ALP1.Value.ToString());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());

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
