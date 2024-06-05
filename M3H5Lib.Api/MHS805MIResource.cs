/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstPreAlloc
		/// Description List Pre Allocations
		/// Version Release: 11.4
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3AOCA">Acquistion order category</param>
		/// <param name="m3ARDN">Acquisition order number</param>
		/// <param name="m3ARDL">Acquisition order line</param>
		/// <param name="m3ARDX">Line suffix</param>
		/// <param name="m3DOCA">Demand order category</param>
		/// <param name="m3DRDN">Demand order number</param>
		/// <param name="m3DRDL">Demand order line</param>
		/// <param name="m3DRDX">Line suffix</param>
		/// <param name="m3DOWN">0/blank=Unprocessed, 1=Processed</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPreAllocResponse></returns>
		/// <exception cref="M3Exception<LstPreAllocResponse>"></exception>
		public async Task<M3Response<LstPreAllocResponse>> LstPreAlloc(
			string m3E0PA, 
			int? m3CONO = null, 
			string m3WHLO = null, 
			string m3AOCA = null, 
			string m3ARDN = null, 
			int? m3ARDL = null, 
			int? m3ARDX = null, 
			string m3DOCA = null, 
			string m3DRDN = null, 
			int? m3DRDL = null, 
			int? m3DRDX = null, 
			int? m3DOWN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPreAlloc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AOCA))
				request.WithQueryParameter("AOCA", m3AOCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARDN))
				request.WithQueryParameter("ARDN", m3ARDN.Trim());
			if (m3ARDL.HasValue)
				request.WithQueryParameter("ARDL", m3ARDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ARDX.HasValue)
				request.WithQueryParameter("ARDX", m3ARDX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DOCA))
				request.WithQueryParameter("DOCA", m3DOCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3DRDN))
				request.WithQueryParameter("DRDN", m3DRDN.Trim());
			if (m3DRDL.HasValue)
				request.WithQueryParameter("DRDL", m3DRDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DRDX.HasValue)
				request.WithQueryParameter("DRDX", m3DRDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DOWN.HasValue)
				request.WithQueryParameter("DOWN", m3DOWN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPreAllocResponse>(
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
		/// Name PrcPreAlloc
		/// Description Process Pre Allocations
		/// Version Release: 11.4
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3AOCA">Acquistion order category</param>
		/// <param name="m3ARDN">Acquisition order number</param>
		/// <param name="m3ARDL">Acquisition order line</param>
		/// <param name="m3ARDX">Line suffix</param>
		/// <param name="m3DOCA">Demand order category</param>
		/// <param name="m3DRDN">Demand order number</param>
		/// <param name="m3DRDL">Demand order line</param>
		/// <param name="m3DRDX">Line suffix</param>
		/// <param name="m3DOWN">0/blank=Unprocessed, 1=Processed</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrcPreAlloc(
			string m3E0PA, 
			int? m3CONO = null, 
			string m3WHLO = null, 
			string m3AOCA = null, 
			string m3ARDN = null, 
			int? m3ARDL = null, 
			int? m3ARDX = null, 
			string m3DOCA = null, 
			string m3DRDN = null, 
			int? m3DRDL = null, 
			int? m3DRDX = null, 
			int? m3DOWN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/PrcPreAlloc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AOCA))
				request.WithQueryParameter("AOCA", m3AOCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARDN))
				request.WithQueryParameter("ARDN", m3ARDN.Trim());
			if (m3ARDL.HasValue)
				request.WithQueryParameter("ARDL", m3ARDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ARDX.HasValue)
				request.WithQueryParameter("ARDX", m3ARDX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DOCA))
				request.WithQueryParameter("DOCA", m3DOCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3DRDN))
				request.WithQueryParameter("DRDN", m3DRDN.Trim());
			if (m3DRDL.HasValue)
				request.WithQueryParameter("DRDL", m3DRDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DRDX.HasValue)
				request.WithQueryParameter("DRDX", m3DRDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DOWN.HasValue)
				request.WithQueryParameter("DOWN", m3DOWN.Value.ToString(CultureInfo.CurrentCulture));

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
