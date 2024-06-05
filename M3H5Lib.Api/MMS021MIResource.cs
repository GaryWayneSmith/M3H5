/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.MMS021MI;
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
	/// Name: MMS021MI
	/// Component Name: Supply Chain Execution
	/// Description: Item Hierarchy interface
	/// Version Release: 5e90
	///</summary>
	public partial class MMS021MIResource : M3BaseResourceEndpoint
	{
		public MMS021MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS021MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddItmHierarchy
		/// Description Add Item Hierarchy
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3HLVL">Hierarchylevel (Required)</param>
		/// <param name="m3HIE0">Hierachyidentity (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3GRP0">Searchgroup</param>
		/// <param name="m3DSP1">Flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddItmHierarchy(
			int m3HLVL, 
			string m3HIE0, 
			string m3TX40, 
			string m3TX15 = null, 
			string m3GRP0 = null, 
			int? m3DSP1 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddItmHierarchy",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3HIE0))
				throw new ArgumentNullException(nameof(m3HIE0));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("HLVL", m3HLVL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("HIE0", m3HIE0.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRP0))
				request.WithQueryParameter("GRP0", m3GRP0.Trim());
			if (m3DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3DSP1.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelItmHierarchy
		/// Description Delete Item Hierarchy
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3HLVL">Hierarchylevel (Required)</param>
		/// <param name="m3HIE0">Hierachyidentity (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelItmHierarchy(
			int m3HLVL, 
			string m3HIE0, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelItmHierarchy",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3HIE0))
				throw new ArgumentNullException(nameof(m3HIE0));

			// Set mandatory parameters
			request
				.WithQueryParameter("HLVL", m3HLVL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("HIE0", m3HIE0.Trim());

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
		/// Name GetHierarchySet
		/// Description Get Hierarchy Set settings
		/// Version Release: 13.1
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHierarchySetResponse></returns>
		/// <exception cref="M3Exception<GetHierarchySetResponse>"></exception>
		public async Task<M3Response<GetHierarchySetResponse>> GetHierarchySet(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHierarchySet",
			};

			// Execute the request
			var result = await Execute<GetHierarchySetResponse>(
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
		/// Name GetItmHierarchy
		/// Description Get Item Hierarchy
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3HLVL">Hierarchylevel (Required)</param>
		/// <param name="m3HIE0">Hierachyidentity (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItmHierarchyResponse></returns>
		/// <exception cref="M3Exception<GetItmHierarchyResponse>"></exception>
		public async Task<M3Response<GetItmHierarchyResponse>> GetItmHierarchy(
			int m3HLVL, 
			string m3HIE0, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetItmHierarchy",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3HIE0))
				throw new ArgumentNullException(nameof(m3HIE0));

			// Set mandatory parameters
			request
				.WithQueryParameter("HLVL", m3HLVL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("HIE0", m3HIE0.Trim());

			// Execute the request
			var result = await Execute<GetItmHierarchyResponse>(
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
		/// Name LstItmHierarchy
		/// Description List Item Hierarchy
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3HLVL">Hierarchylevel</param>
		/// <param name="m3HIE0">Hierachyidentity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmHierarchyResponse></returns>
		/// <exception cref="M3Exception<LstItmHierarchyResponse>"></exception>
		public async Task<M3Response<LstItmHierarchyResponse>> LstItmHierarchy(
			int? m3HLVL = null, 
			string m3HIE0 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItmHierarchy",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3HLVL.HasValue)
				request.WithQueryParameter("HLVL", m3HLVL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3HIE0))
				request.WithQueryParameter("HIE0", m3HIE0.Trim());

			// Execute the request
			var result = await Execute<LstItmHierarchyResponse>(
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
		/// Name UpdItmHierarchy
		/// Description Updates Item Hierarchy
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3HLVL">Hierarchylevel (Required)</param>
		/// <param name="m3HIE0">Hierachyidentity (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3GRP0">Searchgroup</param>
		/// <param name="m3DSP1">Flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItmHierarchy(
			int m3HLVL, 
			string m3HIE0, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3GRP0 = null, 
			int? m3DSP1 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdItmHierarchy",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3HIE0))
				throw new ArgumentNullException(nameof(m3HIE0));

			// Set mandatory parameters
			request
				.WithQueryParameter("HLVL", m3HLVL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("HIE0", m3HIE0.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRP0))
				request.WithQueryParameter("GRP0", m3GRP0.Trim());
			if (m3DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3DSP1.Value.ToString(CultureInfo.CurrentCulture));

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
