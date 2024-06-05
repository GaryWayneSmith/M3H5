/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MHS820MI;
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
	/// Name: MHS820MI
	/// Component Name: LstStkTranTask
	/// Description: List movement tasks
	/// Version Release: 14.x
	///</summary>
	public partial class MHS820MIResource : M3BaseResourceEndpoint
	{
		public MHS820MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MHS820MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstStkTranTask
		/// Description List Movement Task
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_DOWN">0/blank=Unprocessed, 1=Processed</param>
		/// <param name="m3_ABFC">ABC class - frequency</param>
		/// <param name="m3_SLTP">Stock zone</param>
		/// <param name="m3_WHLT">Location type</param>
		/// <param name="m3_LOCG">Location group</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstStkTranTaskResponse></returns>
		/// <exception cref="M3Exception<LstStkTranTaskResponse>"></exception>
		public async Task<M3Response<LstStkTranTaskResponse>> LstStkTranTask(
			string m3_E0PA, 
			int? m3_CONO = null, 
			string m3_WHLO = null, 
			int? m3_DOWN = null, 
			string m3_ABFC = null, 
			string m3_SLTP = null, 
			string m3_WHLT = null, 
			string m3_LOCG = null, 
			string m3_RSCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstStkTranTask",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_DOWN.HasValue)
				request.WithQueryParameter("DOWN", m3_DOWN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ABFC))
				request.WithQueryParameter("ABFC", m3_ABFC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLTP))
				request.WithQueryParameter("SLTP", m3_SLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLT))
				request.WithQueryParameter("WHLT", m3_WHLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LOCG))
				request.WithQueryParameter("LOCG", m3_LOCG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());

			// Execute the request
			var result = await Execute<LstStkTranTaskResponse>(
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
		/// Name PrcStkTranTask
		/// Description Process Stock Transaction tasks
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_TASN">Task Number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_DOWN">0/blank=Unprocessed, 1=Processed</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrcStkTranTask(
			string m3_E0PA, 
			long m3_TASN, 
			int? m3_CONO = null, 
			string m3_WHLO = null, 
			int? m3_DOWN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrcStkTranTask",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("TASN", m3_TASN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_DOWN.HasValue)
				request.WithQueryParameter("DOWN", m3_DOWN.Value.ToString());

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
	}
}
// EOF
