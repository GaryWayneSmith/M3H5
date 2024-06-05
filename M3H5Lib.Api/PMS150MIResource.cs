/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PMS150MI;
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
	/// Name: PMS150MI
	/// Component Name: Batch balancing
	/// Description: Batch balancing interface
	/// Version Release: 5ea0
	///</summary>
	public partial class PMS150MIResource : M3BaseResourceEndpoint
	{
		public PMS150MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PMS150MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name BatchBalancing
		/// Description Batch balancing
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_ARDN">Acquisition order number</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_ORQA">Ordered quantity - alternate U/M</param>
		/// <param name="m3_MAUN">Manufacturing U/M</param>
		/// <param name="m3_FIDT">Finish date</param>
		/// <param name="m3_MFPC">Process</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> BatchBalancing(
			string m3_FACI = null, 
			string m3_ARDN = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			decimal? m3_ORQA = null, 
			string m3_MAUN = null, 
			DateTime? m3_FIDT = null, 
			string m3_MFPC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/BatchBalancing",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARDN))
				request.WithQueryParameter("ARDN", m3_ARDN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_ORQA.HasValue)
				request.WithQueryParameter("ORQA", m3_ORQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MAUN))
				request.WithQueryParameter("MAUN", m3_MAUN.Trim());
			if (m3_FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3_FIDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_MFPC))
				request.WithQueryParameter("MFPC", m3_MFPC.Trim());

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
		/// Name GetProcessOrder
		/// Description GetProcessOrder
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DRDN">Demand order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetProcessOrderResponse></returns>
		/// <exception cref="M3Exception<GetProcessOrderResponse>"></exception>
		public async Task<M3Response<GetProcessOrderResponse>> GetProcessOrder(
			string m3_DRDN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetProcessOrder",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DRDN))
				request.WithQueryParameter("DRDN", m3_DRDN.Trim());

			// Execute the request
			var result = await Execute<GetProcessOrderResponse>(
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
		/// Name LstBatchBal
		/// Description List batch balancing
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ARDN">Acquisition order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBatchBalResponse></returns>
		/// <exception cref="M3Exception<LstBatchBalResponse>"></exception>
		public async Task<M3Response<LstBatchBalResponse>> LstBatchBal(
			string m3_ARDN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBatchBal",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ARDN))
				request.WithQueryParameter("ARDN", m3_ARDN.Trim());

			// Execute the request
			var result = await Execute<LstBatchBalResponse>(
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
		/// Name UndoBatchBal
		/// Description Undo batch balancing
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DRDN">Demand order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UndoBatchBal(
			string m3_DRDN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UndoBatchBal",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DRDN))
				request.WithQueryParameter("DRDN", m3_DRDN.Trim());

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
