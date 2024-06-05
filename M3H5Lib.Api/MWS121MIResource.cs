/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MWS121MI;
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
	/// Name: MWS121MI
	/// Component Name: Preallocation
	/// Description: Api: Preallocation
	/// Version Release: 14.x
	///</summary>
	public partial class MWS121MIResource : M3BaseResourceEndpoint
	{
		public MWS121MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MWS121MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetAcqOrder
		/// Description Get existing Acquisition Order details
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_AOCA">Acquisition order category (Required)</param>
		/// <param name="m3_ARDN">Acquisition order number (Required)</param>
		/// <param name="m3_ARDL">Acquisition order line</param>
		/// <param name="m3_ARDX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAcqOrderResponse></returns>
		/// <exception cref="M3Exception<GetAcqOrderResponse>"></exception>
		public async Task<M3Response<GetAcqOrderResponse>> GetAcqOrder(
			string m3_AOCA, 
			string m3_ARDN, 
			int? m3_ARDL = null, 
			int? m3_ARDX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAcqOrder",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AOCA))
				throw new ArgumentNullException("m3_AOCA");
			if (string.IsNullOrWhiteSpace(m3_ARDN))
				throw new ArgumentNullException("m3_ARDN");

			// Set mandatory parameters
			request
				.WithQueryParameter("AOCA", m3_AOCA.Trim())
				.WithQueryParameter("ARDN", m3_ARDN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_ARDL.HasValue)
				request.WithQueryParameter("ARDL", m3_ARDL.Value.ToString());
			if (m3_ARDX.HasValue)
				request.WithQueryParameter("ARDX", m3_ARDX.Value.ToString());

			// Execute the request
			var result = await Execute<GetAcqOrderResponse>(
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
		/// Name GetDmdOrder
		/// Description Get existing Demand Order details
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_DOCA">Demand order category (Required)</param>
		/// <param name="m3_DRDN">Demand order number (Required)</param>
		/// <param name="m3_DRDL">Demand order line (Required)</param>
		/// <param name="m3_DRDX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDmdOrderResponse></returns>
		/// <exception cref="M3Exception<GetDmdOrderResponse>"></exception>
		public async Task<M3Response<GetDmdOrderResponse>> GetDmdOrder(
			string m3_DOCA, 
			string m3_DRDN, 
			int m3_DRDL, 
			int? m3_DRDX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDmdOrder",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DOCA))
				throw new ArgumentNullException("m3_DOCA");
			if (string.IsNullOrWhiteSpace(m3_DRDN))
				throw new ArgumentNullException("m3_DRDN");

			// Set mandatory parameters
			request
				.WithQueryParameter("DOCA", m3_DOCA.Trim())
				.WithQueryParameter("DRDN", m3_DRDN.Trim())
				.WithQueryParameter("DRDL", m3_DRDL.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DRDX.HasValue)
				request.WithQueryParameter("DRDX", m3_DRDX.Value.ToString());

			// Execute the request
			var result = await Execute<GetDmdOrderResponse>(
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
		/// Name LstAcqByDmdOrd
		/// Description List Acquisition by Dmd Order
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_DOCA">Demand order category (Required)</param>
		/// <param name="m3_DRDN">Demand order number (Required)</param>
		/// <param name="m3_DRDL">Demand order line (Required)</param>
		/// <param name="m3_DRDX">Line suffix</param>
		/// <param name="m3_AOCA">Acquistion order category</param>
		/// <param name="m3_ARDN">Acquisition order number</param>
		/// <param name="m3_ARDL">Acquisition order line</param>
		/// <param name="m3_ARDX">Line suffix</param>
		/// <param name="m3_NFTR">Number of filters</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAcqByDmdOrdResponse></returns>
		/// <exception cref="M3Exception<LstAcqByDmdOrdResponse>"></exception>
		public async Task<M3Response<LstAcqByDmdOrdResponse>> LstAcqByDmdOrd(
			string m3_DOCA, 
			string m3_DRDN, 
			int m3_DRDL, 
			int? m3_DRDX = null, 
			string m3_AOCA = null, 
			string m3_ARDN = null, 
			int? m3_ARDL = null, 
			int? m3_ARDX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAcqByDmdOrd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DOCA))
				throw new ArgumentNullException("m3_DOCA");
			if (string.IsNullOrWhiteSpace(m3_DRDN))
				throw new ArgumentNullException("m3_DRDN");

			// Set mandatory parameters
			request
				.WithQueryParameter("DOCA", m3_DOCA.Trim())
				.WithQueryParameter("DRDN", m3_DRDN.Trim())
				.WithQueryParameter("DRDL", m3_DRDL.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DRDX.HasValue)
				request.WithQueryParameter("DRDX", m3_DRDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AOCA))
				request.WithQueryParameter("AOCA", m3_AOCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARDN))
				request.WithQueryParameter("ARDN", m3_ARDN.Trim());
			if (m3_ARDL.HasValue)
				request.WithQueryParameter("ARDL", m3_ARDL.Value.ToString());
			if (m3_ARDX.HasValue)
				request.WithQueryParameter("ARDX", m3_ARDX.Value.ToString());
			if (m3_NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3_NFTR.Value.ToString());

			// Execute the request
			var result = await Execute<LstAcqByDmdOrdResponse>(
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
		/// Name LstDmdByAcqOrd
		/// Description List Demand by Acq Order
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_AOCA">Acquistion order category (Required)</param>
		/// <param name="m3_ARDN">Acquisition order number (Required)</param>
		/// <param name="m3_ARDL">Acquisition order line</param>
		/// <param name="m3_ARDX">Line suffix</param>
		/// <param name="m3_DOCA">Demand order category</param>
		/// <param name="m3_DRDN">Demand order number</param>
		/// <param name="m3_DRDL">Demand order line</param>
		/// <param name="m3_DRDX">Line suffix</param>
		/// <param name="m3_NFTR">Number of filters</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDmdByAcqOrdResponse></returns>
		/// <exception cref="M3Exception<LstDmdByAcqOrdResponse>"></exception>
		public async Task<M3Response<LstDmdByAcqOrdResponse>> LstDmdByAcqOrd(
			string m3_AOCA, 
			string m3_ARDN, 
			int? m3_ARDL = null, 
			int? m3_ARDX = null, 
			string m3_DOCA = null, 
			string m3_DRDN = null, 
			int? m3_DRDL = null, 
			int? m3_DRDX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDmdByAcqOrd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AOCA))
				throw new ArgumentNullException("m3_AOCA");
			if (string.IsNullOrWhiteSpace(m3_ARDN))
				throw new ArgumentNullException("m3_ARDN");

			// Set mandatory parameters
			request
				.WithQueryParameter("AOCA", m3_AOCA.Trim())
				.WithQueryParameter("ARDN", m3_ARDN.Trim());

			// Set optional parameters, checking for null/blank data for each element
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
			if (m3_NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3_NFTR.Value.ToString());

			// Execute the request
			var result = await Execute<LstDmdByAcqOrdResponse>(
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
		/// Name Preallocate
		/// Description Preallocate
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_DOCA">Demand order category (Required)</param>
		/// <param name="m3_DRDN">Demand order number (Required)</param>
		/// <param name="m3_DRDL">Demand order line (Required)</param>
		/// <param name="m3_AOCA">Acquistion order category (Required)</param>
		/// <param name="m3_ARDN">Acquisition order number (Required)</param>
		/// <param name="m3_PQTY">Pre-allocated quantity (Required)</param>
		/// <param name="m3_DRDX">Line suffix</param>
		/// <param name="m3_ARDL">Acquisition order line</param>
		/// <param name="m3_ARDX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Preallocate(
			string m3_DOCA, 
			string m3_DRDN, 
			int m3_DRDL, 
			string m3_AOCA, 
			string m3_ARDN, 
			decimal m3_PQTY, 
			int? m3_DRDX = null, 
			int? m3_ARDL = null, 
			int? m3_ARDX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Preallocate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DOCA))
				throw new ArgumentNullException("m3_DOCA");
			if (string.IsNullOrWhiteSpace(m3_DRDN))
				throw new ArgumentNullException("m3_DRDN");
			if (string.IsNullOrWhiteSpace(m3_AOCA))
				throw new ArgumentNullException("m3_AOCA");
			if (string.IsNullOrWhiteSpace(m3_ARDN))
				throw new ArgumentNullException("m3_ARDN");

			// Set mandatory parameters
			request
				.WithQueryParameter("DOCA", m3_DOCA.Trim())
				.WithQueryParameter("DRDN", m3_DRDN.Trim())
				.WithQueryParameter("DRDL", m3_DRDL.ToString())
				.WithQueryParameter("AOCA", m3_AOCA.Trim())
				.WithQueryParameter("ARDN", m3_ARDN.Trim())
				.WithQueryParameter("PQTY", m3_PQTY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DRDX.HasValue)
				request.WithQueryParameter("DRDX", m3_DRDX.Value.ToString());
			if (m3_ARDL.HasValue)
				request.WithQueryParameter("ARDL", m3_ARDL.Value.ToString());
			if (m3_ARDX.HasValue)
				request.WithQueryParameter("ARDX", m3_ARDX.Value.ToString());

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
