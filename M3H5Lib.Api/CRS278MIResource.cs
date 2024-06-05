/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.CRS278MI;
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
	/// Name: CRS278MI
	/// Component Name: CustomerOrderLineChargeModels
	/// Description: Line charge models
	/// Version Release: 12.4
	///</summary>
	public partial class CRS278MIResource : M3BaseResourceEndpoint
	{
		public CRS278MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS278MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstChrgModels
		/// Description List charge models
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CHSY">Line charge model</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstChrgModelsResponse></returns>
		/// <exception cref="M3Exception<LstChrgModelsResponse>"></exception>
		public async Task<M3Response<LstChrgModelsResponse>> LstChrgModels(
			int? m3CONO = null, 
			string m3CHSY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstChrgModels",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHSY))
				request.WithQueryParameter("CHSY", m3CHSY.Trim());

			// Execute the request
			var result = await Execute<LstChrgModelsResponse>(
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
		/// Name LstKeyLineChrg
		/// Description List keys for order line charges
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CHSY">Line charge model</param>
		/// <param name="m3CRID">Charge</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstKeyLineChrgResponse></returns>
		/// <exception cref="M3Exception<LstKeyLineChrgResponse>"></exception>
		public async Task<M3Response<LstKeyLineChrgResponse>> LstKeyLineChrg(
			int? m3CONO = null, 
			string m3CHSY = null, 
			string m3CRID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstKeyLineChrg",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHSY))
				request.WithQueryParameter("CHSY", m3CHSY.Trim());
			if (!string.IsNullOrWhiteSpace(m3CRID))
				request.WithQueryParameter("CRID", m3CRID.Trim());

			// Execute the request
			var result = await Execute<LstKeyLineChrgResponse>(
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
		/// Name LstLineChrgMod
		/// Description List line charges per model
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CHSY">Line charge model</param>
		/// <param name="m3CRID">Charge</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineChrgModResponse></returns>
		/// <exception cref="M3Exception<LstLineChrgModResponse>"></exception>
		public async Task<M3Response<LstLineChrgModResponse>> LstLineChrgMod(
			int? m3CONO = null, 
			string m3CHSY = null, 
			string m3CRID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLineChrgMod",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHSY))
				request.WithQueryParameter("CHSY", m3CHSY.Trim());
			if (!string.IsNullOrWhiteSpace(m3CRID))
				request.WithQueryParameter("CRID", m3CRID.Trim());

			// Execute the request
			var result = await Execute<LstLineChrgModResponse>(
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
