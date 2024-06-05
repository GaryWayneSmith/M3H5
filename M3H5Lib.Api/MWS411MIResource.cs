/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MWS411MI;
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
	/// Name: MWS411MI
	/// Component Name: Api: Delivery Lines Interface
	/// Description: Delivery Lines  interface
	/// Version Release: 5e90
	///</summary>
	public partial class MWS411MIResource : M3BaseResourceEndpoint
	{
		public MWS411MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MWS411MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetDeliveryLine
		/// Description Get Delivery Lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DLIX">Delivery number (Required)</param>
		/// <param name="m3_RORC">Reference order category (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line (Required)</param>
		/// <param name="m3_RIDX">Line suffix (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDeliveryLineResponse></returns>
		/// <exception cref="M3Exception<GetDeliveryLineResponse>"></exception>
		public async Task<M3Response<GetDeliveryLineResponse>> GetDeliveryLine(
			decimal m3_DLIX, 
			int m3_RORC, 
			string m3_RIDN, 
			int m3_RIDL, 
			int m3_RIDX, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDeliveryLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");

			// Set mandatory parameters
			request
				.WithQueryParameter("DLIX", m3_DLIX.ToString())
				.WithQueryParameter("RORC", m3_RORC.ToString())
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("RIDL", m3_RIDL.ToString())
				.WithQueryParameter("RIDX", m3_RIDX.ToString());

			// Execute the request
			var result = await Execute<GetDeliveryLineResponse>(
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
		/// Name LstDelLnByOrd
		/// Description List Delivery Lines by Order number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDelLnByOrdResponse></returns>
		/// <exception cref="M3Exception<LstDelLnByOrdResponse>"></exception>
		public async Task<M3Response<LstDelLnByOrdResponse>> LstDelLnByOrd(
			int? m3_RORC = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDelLnByOrd",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());

			// Execute the request
			var result = await Execute<LstDelLnByOrdResponse>(
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
		/// Name LstDeliveryLine
		/// Description List Delivery Lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DLIX">Delivery number (Required)</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDeliveryLineResponse></returns>
		/// <exception cref="M3Exception<LstDeliveryLineResponse>"></exception>
		public async Task<M3Response<LstDeliveryLineResponse>> LstDeliveryLine(
			decimal m3_DLIX, 
			string m3_RIDN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDeliveryLine",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DLIX", m3_DLIX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());

			// Execute the request
			var result = await Execute<LstDeliveryLineResponse>(
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
