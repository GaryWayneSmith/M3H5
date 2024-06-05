/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.COS119MI;
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
	/// Name: COS119MI
	/// Component Name: MaintenanceCustomeOrder
	/// Description: Maintenance customer order. Connect Contact
	/// Version Release: 5e90
	///</summary>
	public partial class COS119MIResource : M3BaseResourceEndpoint
	{
		public COS119MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "COS119MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddConnection
		/// Description Add order connection
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_CNPE">Contact (Required)</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_ADRT">Address type</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_RFTP">Contact type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddConnection(
			string m3_CNPE, 
			string m3_ORNO = null, 
			int? m3_ADRT = null, 
			string m3_ADID = null, 
			string m3_RFTP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddConnection",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CNPE))
				throw new ArgumentNullException("m3_CNPE");

			// Set mandatory parameters
			request
				.WithQueryParameter("CNPE", m3_CNPE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (m3_ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3_ADRT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFTP))
				request.WithQueryParameter("RFTP", m3_RFTP.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
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
		/// Name DeleteConnect
		/// Description Delete order connection
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_CNPE">Contact (Required)</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_ADRT">Address type</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_RFTP">Contact type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteConnect(
			string m3_CNPE, 
			string m3_ORNO = null, 
			int? m3_ADRT = null, 
			string m3_ADID = null, 
			string m3_RFTP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeleteConnect",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CNPE))
				throw new ArgumentNullException("m3_CNPE");

			// Set mandatory parameters
			request
				.WithQueryParameter("CNPE", m3_CNPE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (m3_ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3_ADRT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFTP))
				request.WithQueryParameter("RFTP", m3_RFTP.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
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
		/// Name LstByOrder
		/// Description LstByOrder
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_ADRT">Address type</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_RFTP">Contact type</param>
		/// <param name="m3_CNPE">Contact</param>
		/// <param name="m3_NFTR">Number of filters</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByOrderResponse></returns>
		/// <exception cref="M3Exception<LstByOrderResponse>"></exception>
		public async Task<M3Response<LstByOrderResponse>> LstByOrder(
			string m3_ORNO = null, 
			int? m3_ADRT = null, 
			string m3_ADID = null, 
			string m3_RFTP = null, 
			string m3_CNPE = null, 
			int? m3_NFTR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByOrder",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (m3_ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3_ADRT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFTP))
				request.WithQueryParameter("RFTP", m3_RFTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CNPE))
				request.WithQueryParameter("CNPE", m3_CNPE.Trim());
			if (m3_NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3_NFTR.Value.ToString());

			// Execute the request
			var result = await Execute<LstByOrderResponse>(
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
		/// Name LstConnection
		/// Description List order connection
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_CNPE">Contact</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstConnectionResponse></returns>
		/// <exception cref="M3Exception<LstConnectionResponse>"></exception>
		public async Task<M3Response<LstConnectionResponse>> LstConnection(
			string m3_CNPE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstConnection",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CNPE))
				request.WithQueryParameter("CNPE", m3_CNPE.Trim());

			// Execute the request
			var result = await Execute<LstConnectionResponse>(
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
