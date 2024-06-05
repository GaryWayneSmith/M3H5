/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.CRS035MI;
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
	/// Name: CRS035MI
	/// Component Name: Api: Product Group Interface
	/// Description: Product Group interface
	/// Version Release: 14.x
	///</summary>
	public partial class CRS035MIResource : M3BaseResourceEndpoint
	{
		public CRS035MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS035MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddProductGroup
		/// Description Add Product Group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITCL">Product group (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3SECU">Seasonal curve</param>
		/// <param name="m3CONF">CONF Yes/no</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddProductGroup(
			string m3ITCL, 
			string m3TX40, 
			string m3TX15 = null, 
			int? m3SECU = null, 
			int? m3CONF = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddProductGroup",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITCL))
				throw new ArgumentNullException(nameof(m3ITCL));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITCL", m3ITCL.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3SECU.HasValue)
				request.WithQueryParameter("SECU", m3SECU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CONF.HasValue)
				request.WithQueryParameter("CONF", m3CONF.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelProductGroup
		/// Description Delete Product Group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITCL">Product group (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelProductGroup(
			string m3ITCL, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelProductGroup",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITCL))
				throw new ArgumentNullException(nameof(m3ITCL));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITCL", m3ITCL.Trim());

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
		/// Name GetProductGroup
		/// Description Get Product Group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITCL">Product group (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetProductGroupResponse></returns>
		/// <exception cref="M3Exception<GetProductGroupResponse>"></exception>
		public async Task<M3Response<GetProductGroupResponse>> GetProductGroup(
			string m3ITCL, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetProductGroup",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITCL))
				throw new ArgumentNullException(nameof(m3ITCL));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITCL", m3ITCL.Trim());

			// Execute the request
			var result = await Execute<GetProductGroupResponse>(
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
		/// Name LstProductGroup
		/// Description List Product Group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstProductGroupResponse></returns>
		/// <exception cref="M3Exception<LstProductGroupResponse>"></exception>
		public async Task<M3Response<LstProductGroupResponse>> LstProductGroup(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstProductGroup",
			};

			// Execute the request
			var result = await Execute<LstProductGroupResponse>(
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
		/// Name UpdProductGroup
		/// Description Update Product Group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITCL">Product group (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3SECU">Seasonal curve</param>
		/// <param name="m3CONF">CONF Yes/no</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdProductGroup(
			string m3ITCL, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			int? m3SECU = null, 
			int? m3CONF = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdProductGroup",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITCL))
				throw new ArgumentNullException(nameof(m3ITCL));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITCL", m3ITCL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3SECU.HasValue)
				request.WithQueryParameter("SECU", m3SECU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CONF.HasValue)
				request.WithQueryParameter("CONF", m3CONF.Value.ToString(CultureInfo.CurrentCulture));

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
