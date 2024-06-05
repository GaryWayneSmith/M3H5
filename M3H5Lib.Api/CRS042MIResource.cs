/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddCountyID
		/// Description Add a County ID
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CSCD">Country (Required)</param>
		/// <param name="m3ECAR">State (Required)</param>
		/// <param name="m3FRCO">County ID (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCountyID(
			string m3CSCD, 
			string m3ECAR, 
			string m3FRCO, 
			string m3TX40, 
			string m3TX15 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddCountyID",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CSCD))
				throw new ArgumentNullException(nameof(m3CSCD));
			if (string.IsNullOrWhiteSpace(m3ECAR))
				throw new ArgumentNullException(nameof(m3ECAR));
			if (string.IsNullOrWhiteSpace(m3FRCO))
				throw new ArgumentNullException(nameof(m3FRCO));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("CSCD", m3CSCD.Trim())
				.WithQueryParameter("ECAR", m3ECAR.Trim())
				.WithQueryParameter("FRCO", m3FRCO.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());

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
		/// Name DltCountyID
		/// Description Delete a County ID
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CSCD">Country (Required)</param>
		/// <param name="m3ECAR">State (Required)</param>
		/// <param name="m3FRCO">County ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltCountyID(
			string m3CSCD, 
			string m3ECAR, 
			string m3FRCO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltCountyID",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CSCD))
				throw new ArgumentNullException(nameof(m3CSCD));
			if (string.IsNullOrWhiteSpace(m3ECAR))
				throw new ArgumentNullException(nameof(m3ECAR));
			if (string.IsNullOrWhiteSpace(m3FRCO))
				throw new ArgumentNullException(nameof(m3FRCO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CSCD", m3CSCD.Trim())
				.WithQueryParameter("ECAR", m3ECAR.Trim())
				.WithQueryParameter("FRCO", m3FRCO.Trim());

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
		/// Name GetCountyID
		/// Description Get a County ID
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CSCD">Country (Required)</param>
		/// <param name="m3ECAR">State (Required)</param>
		/// <param name="m3FRCO">County ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCountyIDResponse></returns>
		/// <exception cref="M3Exception<GetCountyIDResponse>"></exception>
		public async Task<M3Response<GetCountyIDResponse>> GetCountyID(
			string m3CSCD, 
			string m3ECAR, 
			string m3FRCO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetCountyID",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CSCD))
				throw new ArgumentNullException(nameof(m3CSCD));
			if (string.IsNullOrWhiteSpace(m3ECAR))
				throw new ArgumentNullException(nameof(m3ECAR));
			if (string.IsNullOrWhiteSpace(m3FRCO))
				throw new ArgumentNullException(nameof(m3FRCO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CSCD", m3CSCD.Trim())
				.WithQueryParameter("ECAR", m3ECAR.Trim())
				.WithQueryParameter("FRCO", m3FRCO.Trim());

			// Execute the request
			var result = await Execute<GetCountyIDResponse>(
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
		/// Name LstCountyID
		/// Description List County ID
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CSCD">Country (Required)</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCountyIDResponse></returns>
		/// <exception cref="M3Exception<LstCountyIDResponse>"></exception>
		public async Task<M3Response<LstCountyIDResponse>> LstCountyID(
			string m3CSCD, 
			string m3ECAR = null, 
			string m3FRCO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstCountyID",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CSCD))
				throw new ArgumentNullException(nameof(m3CSCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("CSCD", m3CSCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRCO))
				request.WithQueryParameter("FRCO", m3FRCO.Trim());

			// Execute the request
			var result = await Execute<LstCountyIDResponse>(
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
		/// Name UpdCountyID
		/// Description Update a County ID
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CSCD">Country (Required)</param>
		/// <param name="m3ECAR">State (Required)</param>
		/// <param name="m3FRCO">County ID (Required)</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdCountyID(
			string m3CSCD, 
			string m3ECAR, 
			string m3FRCO, 
			string m3TX15 = null, 
			string m3TX40 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdCountyID",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CSCD))
				throw new ArgumentNullException(nameof(m3CSCD));
			if (string.IsNullOrWhiteSpace(m3ECAR))
				throw new ArgumentNullException(nameof(m3ECAR));
			if (string.IsNullOrWhiteSpace(m3FRCO))
				throw new ArgumentNullException(nameof(m3FRCO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CSCD", m3CSCD.Trim())
				.WithQueryParameter("ECAR", m3ECAR.Trim())
				.WithQueryParameter("FRCO", m3FRCO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());

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
