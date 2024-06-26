/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.MMS022MI;
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
	/// Name: MMS022MI
	/// Component Name: Item Search Group
	/// Description: Item Search Group interface
	/// Version Release: 13.1
	///</summary>
	public partial class MMS022MIResource : M3BaseResourceEndpoint
	{
		public MMS022MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS022MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddItmSearchGrp
		/// Description Add Item Search Group
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3GLVL">Searchgrplevel (Required)</param>
		/// <param name="m3SGP0">Itemsearchgroup (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddItmSearchGrp(
			int m3GLVL, 
			string m3SGP0, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddItmSearchGrp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SGP0))
				throw new ArgumentNullException(nameof(m3SGP0));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("GLVL", m3GLVL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SGP0", m3SGP0.Trim())
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
		/// Name DelItmSearchGrp
		/// Description Delete Item Search Group
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3GLVL">Searchgrplevel (Required)</param>
		/// <param name="m3SGP0">Itemsearchgroup (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelItmSearchGrp(
			int m3GLVL, 
			string m3SGP0, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelItmSearchGrp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SGP0))
				throw new ArgumentNullException(nameof(m3SGP0));

			// Set mandatory parameters
			request
				.WithQueryParameter("GLVL", m3GLVL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SGP0", m3SGP0.Trim());

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
		/// Name GetItmSearchGrp
		/// Description Get Item Search Group
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3GLVL">Searchgrplevel (Required)</param>
		/// <param name="m3SGP0">Itemsearchgroup (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItmSearchGrpResponse></returns>
		/// <exception cref="M3Exception<GetItmSearchGrpResponse>"></exception>
		public async Task<M3Response<GetItmSearchGrpResponse>> GetItmSearchGrp(
			int m3GLVL, 
			string m3SGP0, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetItmSearchGrp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SGP0))
				throw new ArgumentNullException(nameof(m3SGP0));

			// Set mandatory parameters
			request
				.WithQueryParameter("GLVL", m3GLVL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SGP0", m3SGP0.Trim());

			// Execute the request
			var result = await Execute<GetItmSearchGrpResponse>(
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
		/// Name GetSearchGrpSet
		/// Description Get Search Group Set
		/// Version Release: 13.1
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSearchGrpSetResponse></returns>
		/// <exception cref="M3Exception<GetSearchGrpSetResponse>"></exception>
		public async Task<M3Response<GetSearchGrpSetResponse>> GetSearchGrpSet(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetSearchGrpSet",
			};

			// Execute the request
			var result = await Execute<GetSearchGrpSetResponse>(
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
		/// Name LstItmSearchGrp
		/// Description List Item Search Group
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3GLVL">Searchgrplevel</param>
		/// <param name="m3SGP0">Itemsearchgroup</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmSearchGrpResponse></returns>
		/// <exception cref="M3Exception<LstItmSearchGrpResponse>"></exception>
		public async Task<M3Response<LstItmSearchGrpResponse>> LstItmSearchGrp(
			int? m3GLVL = null, 
			string m3SGP0 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstItmSearchGrp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3GLVL.HasValue)
				request.WithQueryParameter("GLVL", m3GLVL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SGP0))
				request.WithQueryParameter("SGP0", m3SGP0.Trim());

			// Execute the request
			var result = await Execute<LstItmSearchGrpResponse>(
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
		/// Name UpdItmSearchGrp
		/// Description Updates Item Search Group
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3GLVL">Searchgrplevel (Required)</param>
		/// <param name="m3SGP0">Itemsearchgroup (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItmSearchGrp(
			int m3GLVL, 
			string m3SGP0, 
			string m3TX40 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdItmSearchGrp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SGP0))
				throw new ArgumentNullException(nameof(m3SGP0));

			// Set mandatory parameters
			request
				.WithQueryParameter("GLVL", m3GLVL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SGP0", m3SGP0.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
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
	}
}
// EOF
