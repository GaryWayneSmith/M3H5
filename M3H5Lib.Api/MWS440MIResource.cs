/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MWS440MI;
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
	/// Name: MWS440MI
	/// Component Name: GoodsReceipt
	/// Description: Api: Goods Receipt DO/RO
	/// Version Release: 14.x
	///</summary>
	public partial class MWS440MIResource : M3BaseResourceEndpoint
	{
		public MWS440MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MWS440MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetPack
		/// Description Get Package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPackResponse></returns>
		/// <exception cref="M3Exception<GetPackResponse>"></exception>
		public async Task<M3Response<GetPackResponse>> GetPack(
			string m3_WHLO, 
			string m3_SSCC = null, 
			decimal? m3_DLIX = null, 
			string m3_PANR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPack",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());

			// Execute the request
			var result = await Execute<GetPackResponse>(
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
		/// Name LstPack
		/// Description List Package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPackResponse></returns>
		/// <exception cref="M3Exception<LstPackResponse>"></exception>
		public async Task<M3Response<LstPackResponse>> LstPack(
			string m3_WHLO, 
			string m3_SSCC = null, 
			decimal? m3_DLIX = null, 
			string m3_PANR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPack",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());

			// Execute the request
			var result = await Execute<LstPackResponse>(
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
		/// Name LstPackLine
		/// Description List Package Lines Detail
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_RORC">Order category</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPackLineResponse></returns>
		/// <exception cref="M3Exception<LstPackLineResponse>"></exception>
		public async Task<M3Response<LstPackLineResponse>> LstPackLine(
			string m3_WHLO, 
			decimal? m3_DLIX = null, 
			string m3_PANR = null, 
			int? m3_RORC = null, 
			string m3_RIDN = null, 
			string m3_SSCC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPackLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());

			// Execute the request
			var result = await Execute<LstPackLineResponse>(
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
