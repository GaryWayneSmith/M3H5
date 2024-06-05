/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.CRS137MI;
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
	/// Name: CRS137MI
	/// Component Name: Geographical code-Jurisdiction
	/// Description: Api: Geographical code-Jurisdiction
	/// Version Release: 5ea0
	///</summary>
	public partial class CRS137MIResource : M3BaseResourceEndpoint
	{
		public CRS137MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS137MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddGeoCode
		/// Description Add Geographical code
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3GEOC">Geographical code (Required)</param>
		/// <param name="m3TAJ1">Tax jurisdiction 1</param>
		/// <param name="m3TAJ2">Tax jurisdiction 2</param>
		/// <param name="m3TAJ3">Tax jurisdiction 3</param>
		/// <param name="m3TAJ4">Tax jurisdiction 4</param>
		/// <param name="m3TAJ5">Tax jurisdiction 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddGeoCode(
			int m3GEOC, 
			string m3TAJ1 = null, 
			string m3TAJ2 = null, 
			string m3TAJ3 = null, 
			string m3TAJ4 = null, 
			string m3TAJ5 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddGeoCode",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("GEOC", m3GEOC.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TAJ1))
				request.WithQueryParameter("TAJ1", m3TAJ1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAJ2))
				request.WithQueryParameter("TAJ2", m3TAJ2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAJ3))
				request.WithQueryParameter("TAJ3", m3TAJ3.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAJ4))
				request.WithQueryParameter("TAJ4", m3TAJ4.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAJ5))
				request.WithQueryParameter("TAJ5", m3TAJ5.Trim());

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
		/// Name DltGeoCode
		/// Description Delete Geographical code
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3GEOC">Geographical code (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltGeoCode(
			int m3GEOC, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltGeoCode",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("GEOC", m3GEOC.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetGeoCode
		/// Description Retrieves Geographical code
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3GEOC">Geographical code (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetGeoCodeResponse></returns>
		/// <exception cref="M3Exception<GetGeoCodeResponse>"></exception>
		public async Task<M3Response<GetGeoCodeResponse>> GetGeoCode(
			int m3GEOC, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetGeoCode",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("GEOC", m3GEOC.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetGeoCodeResponse>(
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
		/// Name LstGeoCodes
		/// Description List  Geographical codes
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3GEOC">Geographical code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstGeoCodesResponse></returns>
		/// <exception cref="M3Exception<LstGeoCodesResponse>"></exception>
		public async Task<M3Response<LstGeoCodesResponse>> LstGeoCodes(
			int? m3GEOC = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstGeoCodes",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3GEOC.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstGeoCodesResponse>(
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
		/// Name UpdGeoCode
		/// Description Update Geographical code
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3GEOC">Geographical code (Required)</param>
		/// <param name="m3TAJ1">Tax jurisdiction 1</param>
		/// <param name="m3TAJ2">Tax jurisdiction 2</param>
		/// <param name="m3TAJ3">Tax jurisdiction 3</param>
		/// <param name="m3TAJ4">Tax jurisdiction 4</param>
		/// <param name="m3TAJ5">Tax jurisdiction 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdGeoCode(
			int m3GEOC, 
			string m3TAJ1 = null, 
			string m3TAJ2 = null, 
			string m3TAJ3 = null, 
			string m3TAJ4 = null, 
			string m3TAJ5 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdGeoCode",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("GEOC", m3GEOC.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TAJ1))
				request.WithQueryParameter("TAJ1", m3TAJ1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAJ2))
				request.WithQueryParameter("TAJ2", m3TAJ2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAJ3))
				request.WithQueryParameter("TAJ3", m3TAJ3.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAJ4))
				request.WithQueryParameter("TAJ4", m3TAJ4.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAJ5))
				request.WithQueryParameter("TAJ5", m3TAJ5.Trim());

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
