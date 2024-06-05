/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PMS120MI;
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
	/// Name: PMS120MI
	/// Component Name: PMS120
	/// Description: Manufacturing order type interface
	/// Version Release: 5ea0
	///</summary>
	public partial class PMS120MIResource : M3BaseResourceEndpoint
	{
		public PMS120MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PMS120MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetOrderType
		/// Description Get manufacturing order type
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ORTY">Order type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOrderTypeResponse></returns>
		/// <exception cref="M3Exception<GetOrderTypeResponse>"></exception>
		public async Task<M3Response<GetOrderTypeResponse>> GetOrderType(
			string m3_ORTY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetOrderType",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORTY))
				throw new ArgumentNullException("m3_ORTY");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORTY", m3_ORTY.Trim());

			// Execute the request
			var result = await Execute<GetOrderTypeResponse>(
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
		/// Name LstOrderType
		/// Description List manufacturing order type
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOrderTypeResponse></returns>
		/// <exception cref="M3Exception<LstOrderTypeResponse>"></exception>
		public async Task<M3Response<LstOrderTypeResponse>> LstOrderType(
			string m3_ORTY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstOrderType",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());

			// Execute the request
			var result = await Execute<LstOrderTypeResponse>(
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
