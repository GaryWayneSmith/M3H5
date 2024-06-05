/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MHS805MI;
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
	/// Name: MHS805MI
	/// Component Name: Pre-AllocationDownload
	/// Description: Pre-allocation download interface
	/// Version Release: 11.4
	///</summary>
	public partial class MHS805MIResource : M3BaseResourceEndpoint
	{
		public MHS805MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MHS805MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstPreAlloc
		/// Description List Pre Allocations
		/// Version Release: 11.4
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_AOCA">Acquistion order category</param>
		/// <param name="m3_ARDN">Acquisition order number</param>
		/// <param name="m3_ARDL">Acquisition order line</param>
		/// <param name="m3_ARDX">Line suffix</param>
		/// <param name="m3_DOCA">Demand order category</param>
		/// <param name="m3_DRDN">Demand order number</param>
		/// <param name="m3_DRDL">Demand order line</param>
		/// <param name="m3_DRDX">Line suffix</param>
		/// <param name="m3_DOWN">0/blank=Unprocessed, 1=Processed</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPreAllocResponse></returns>
		/// <exception cref="M3Exception<LstPreAllocResponse>"></exception>
		public async Task<M3Response<LstPreAllocResponse>> LstPreAlloc(
			string m3_E0PA, 
			int? m3_CONO = null, 
			string m3_WHLO = null, 
			string m3_AOCA = null, 
			string m3_ARDN = null, 
			int? m3_ARDL = null, 
			int? m3_ARDX = null, 
			string m3_DOCA = null, 
			string m3_DRDN = null, 
			int? m3_DRDL = null, 
			int? m3_DRDX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPreAlloc",
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
			if (!string.IsNullOrWhiteSpace(m3_AOCA))
				request.WithQueryParameter("AOCA", m3_AOCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARDN))
				request.WithQueryParameter("ARDN", m3_ARDN.Trim());
			if (m3_ARDL.HasValue)
				request.WithQueryParameter("ARDL", m3_ARDL.Value.ToString());
			if (m3_ARDX.HasValue)
				request.WithQueryParameter("ARDX", m3_ARDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DOCA))
				request.WithQueryParameter("DOCA", m3_DOCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DRDN))
				request.WithQueryParameter("DRDN", m3_DRDN.Trim());
			if (m3_DRDL.HasValue)
				request.WithQueryParameter("DRDL", m3_DRDL.Value.ToString());
			if (m3_DRDX.HasValue)
				request.WithQueryParameter("DRDX", m3_DRDX.Value.ToString());
			if (m3_DOWN.HasValue)
				request.WithQueryParameter("DOWN", m3_DOWN.Value.ToString());

			// Execute the request
			var result = await Execute<LstPreAllocResponse>(
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
		/// Name PrcPreAlloc
		/// Description Process Pre Allocations
		/// Version Release: 11.4
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_AOCA">Acquistion order category</param>
		/// <param name="m3_ARDN">Acquisition order number</param>
		/// <param name="m3_ARDL">Acquisition order line</param>
		/// <param name="m3_ARDX">Line suffix</param>
		/// <param name="m3_DOCA">Demand order category</param>
		/// <param name="m3_DRDN">Demand order number</param>
		/// <param name="m3_DRDL">Demand order line</param>
		/// <param name="m3_DRDX">Line suffix</param>
		/// <param name="m3_DOWN">0/blank=Unprocessed, 1=Processed</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrcPreAlloc(
			string m3_E0PA, 
			int? m3_CONO = null, 
			string m3_WHLO = null, 
			string m3_AOCA = null, 
			string m3_ARDN = null, 
			int? m3_ARDL = null, 
			int? m3_ARDX = null, 
			string m3_DOCA = null, 
			string m3_DRDN = null, 
			int? m3_DRDL = null, 
			int? m3_DRDX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrcPreAlloc",
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
			if (!string.IsNullOrWhiteSpace(m3_AOCA))
				request.WithQueryParameter("AOCA", m3_AOCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARDN))
				request.WithQueryParameter("ARDN", m3_ARDN.Trim());
			if (m3_ARDL.HasValue)
				request.WithQueryParameter("ARDL", m3_ARDL.Value.ToString());
			if (m3_ARDX.HasValue)
				request.WithQueryParameter("ARDX", m3_ARDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DOCA))
				request.WithQueryParameter("DOCA", m3_DOCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DRDN))
				request.WithQueryParameter("DRDN", m3_DRDN.Trim());
			if (m3_DRDL.HasValue)
				request.WithQueryParameter("DRDL", m3_DRDL.Value.ToString());
			if (m3_DRDX.HasValue)
				request.WithQueryParameter("DRDX", m3_DRDX.Value.ToString());
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
