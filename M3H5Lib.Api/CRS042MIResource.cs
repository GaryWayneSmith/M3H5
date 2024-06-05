/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS042MI;
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
	/// Name: CRS042MI
	/// Component Name: County ID
	/// Description: County ID interface
	/// Version Release: 14.x
	///</summary>
	public partial class CRS042MIResource : M3BaseResourceEndpoint
	{
		public CRS042MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS042MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddCountyID
		/// Description Add a County ID
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CSCD">Country (Required)</param>
		/// <param name="m3_ECAR">State (Required)</param>
		/// <param name="m3_FRCO">County ID (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCountyID(
			string m3_CSCD, 
			string m3_ECAR, 
			string m3_FRCO, 
			string m3_TX40, 
			string m3_TX15 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCountyID",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CSCD))
				throw new ArgumentNullException("m3_CSCD");
			if (string.IsNullOrWhiteSpace(m3_ECAR))
				throw new ArgumentNullException("m3_ECAR");
			if (string.IsNullOrWhiteSpace(m3_FRCO))
				throw new ArgumentNullException("m3_FRCO");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("CSCD", m3_CSCD.Trim())
				.WithQueryParameter("ECAR", m3_ECAR.Trim())
				.WithQueryParameter("FRCO", m3_FRCO.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());

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
		/// Name DltCountyID
		/// Description Delete a County ID
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CSCD">Country (Required)</param>
		/// <param name="m3_ECAR">State (Required)</param>
		/// <param name="m3_FRCO">County ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltCountyID(
			string m3_CSCD, 
			string m3_ECAR, 
			string m3_FRCO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltCountyID",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CSCD))
				throw new ArgumentNullException("m3_CSCD");
			if (string.IsNullOrWhiteSpace(m3_ECAR))
				throw new ArgumentNullException("m3_ECAR");
			if (string.IsNullOrWhiteSpace(m3_FRCO))
				throw new ArgumentNullException("m3_FRCO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CSCD", m3_CSCD.Trim())
				.WithQueryParameter("ECAR", m3_ECAR.Trim())
				.WithQueryParameter("FRCO", m3_FRCO.Trim());

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
		/// Name GetCountyID
		/// Description Get a County ID
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CSCD">Country (Required)</param>
		/// <param name="m3_ECAR">State (Required)</param>
		/// <param name="m3_FRCO">County ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCountyIDResponse></returns>
		/// <exception cref="M3Exception<GetCountyIDResponse>"></exception>
		public async Task<M3Response<GetCountyIDResponse>> GetCountyID(
			string m3_CSCD, 
			string m3_ECAR, 
			string m3_FRCO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetCountyID",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CSCD))
				throw new ArgumentNullException("m3_CSCD");
			if (string.IsNullOrWhiteSpace(m3_ECAR))
				throw new ArgumentNullException("m3_ECAR");
			if (string.IsNullOrWhiteSpace(m3_FRCO))
				throw new ArgumentNullException("m3_FRCO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CSCD", m3_CSCD.Trim())
				.WithQueryParameter("ECAR", m3_ECAR.Trim())
				.WithQueryParameter("FRCO", m3_FRCO.Trim());

			// Execute the request
			var result = await Execute<GetCountyIDResponse>(
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
		/// Name LstCountyID
		/// Description List County ID
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CSCD">Country (Required)</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCountyIDResponse></returns>
		/// <exception cref="M3Exception<LstCountyIDResponse>"></exception>
		public async Task<M3Response<LstCountyIDResponse>> LstCountyID(
			string m3_CSCD, 
			string m3_ECAR = null, 
			string m3_FRCO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCountyID",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CSCD))
				throw new ArgumentNullException("m3_CSCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("CSCD", m3_CSCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRCO))
				request.WithQueryParameter("FRCO", m3_FRCO.Trim());

			// Execute the request
			var result = await Execute<LstCountyIDResponse>(
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
		/// Name UpdCountyID
		/// Description Update a County ID
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CSCD">Country (Required)</param>
		/// <param name="m3_ECAR">State (Required)</param>
		/// <param name="m3_FRCO">County ID (Required)</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdCountyID(
			string m3_CSCD, 
			string m3_ECAR, 
			string m3_FRCO, 
			string m3_TX15 = null, 
			string m3_TX40 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdCountyID",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CSCD))
				throw new ArgumentNullException("m3_CSCD");
			if (string.IsNullOrWhiteSpace(m3_ECAR))
				throw new ArgumentNullException("m3_ECAR");
			if (string.IsNullOrWhiteSpace(m3_FRCO))
				throw new ArgumentNullException("m3_FRCO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CSCD", m3_CSCD.Trim())
				.WithQueryParameter("ECAR", m3_ECAR.Trim())
				.WithQueryParameter("FRCO", m3_FRCO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());

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
