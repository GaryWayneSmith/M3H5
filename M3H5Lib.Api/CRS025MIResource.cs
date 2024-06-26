/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.CRS025MI;
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
	/// Name: CRS025MI
	/// Component Name: Api: Item Group Interface
	/// Description: Item Group interface
	/// Version Release: 14.x
	///</summary>
	public partial class CRS025MIResource : M3BaseResourceEndpoint
	{
		public CRS025MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS025MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddItemGroup
		/// Description Add Item Group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITGR">Item group (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3SECU">Seasonal curve</param>
		/// <param name="m3TECU">Trend curve</param>
		/// <param name="m3TCWP">Tolerance catch weight percent</param>
		/// <param name="m3TCWQ">Tolerance catch weight</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddItemGroup(
			string m3ITGR, 
			string m3TX40, 
			string m3TX15 = null, 
			int? m3SECU = null, 
			int? m3TECU = null, 
			int? m3TCWP = null, 
			decimal? m3TCWQ = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddItemGroup",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITGR))
				throw new ArgumentNullException(nameof(m3ITGR));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITGR", m3ITGR.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3SECU.HasValue)
				request.WithQueryParameter("SECU", m3SECU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TECU.HasValue)
				request.WithQueryParameter("TECU", m3TECU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TCWP.HasValue)
				request.WithQueryParameter("TCWP", m3TCWP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TCWQ.HasValue)
				request.WithQueryParameter("TCWQ", m3TCWQ.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelItemGroup
		/// Description Delete Item Group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITGR">Item group (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelItemGroup(
			string m3ITGR, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelItemGroup",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITGR))
				throw new ArgumentNullException(nameof(m3ITGR));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITGR", m3ITGR.Trim());

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
		/// Name GetItemGroup
		/// Description Get Item Group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITGR">Item group (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItemGroupResponse></returns>
		/// <exception cref="M3Exception<GetItemGroupResponse>"></exception>
		public async Task<M3Response<GetItemGroupResponse>> GetItemGroup(
			string m3ITGR, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetItemGroup",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITGR))
				throw new ArgumentNullException(nameof(m3ITGR));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITGR", m3ITGR.Trim());

			// Execute the request
			var result = await Execute<GetItemGroupResponse>(
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
		/// Name LstItemGroup
		/// Description List Item  Group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemGroupResponse></returns>
		/// <exception cref="M3Exception<LstItemGroupResponse>"></exception>
		public async Task<M3Response<LstItemGroupResponse>> LstItemGroup(
			string m3ITGR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstItemGroup",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());

			// Execute the request
			var result = await Execute<LstItemGroupResponse>(
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
		/// Name UpdItemGroup
		/// Description Update Item Group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITGR">Item group (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3SECU">Seasonal curve</param>
		/// <param name="m3TECU">Trend curve</param>
		/// <param name="m3TCWP">Tolerance catch weight percent</param>
		/// <param name="m3TCWQ">Tolerance catch weight</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItemGroup(
			string m3ITGR, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			int? m3SECU = null, 
			int? m3TECU = null, 
			int? m3TCWP = null, 
			decimal? m3TCWQ = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdItemGroup",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITGR))
				throw new ArgumentNullException(nameof(m3ITGR));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITGR", m3ITGR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3SECU.HasValue)
				request.WithQueryParameter("SECU", m3SECU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TECU.HasValue)
				request.WithQueryParameter("TECU", m3TECU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TCWP.HasValue)
				request.WithQueryParameter("TCWP", m3TCWP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TCWQ.HasValue)
				request.WithQueryParameter("TCWQ", m3TCWQ.Value.ToString(CultureInfo.CurrentCulture));

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
