/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3AOCA">Acquisition order category (Required)</param>
		/// <param name="m3ARDN">Acquisition order number (Required)</param>
		/// <param name="m3ARDL">Acquisition order line</param>
		/// <param name="m3ARDX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAcqOrderResponse></returns>
		/// <exception cref="M3Exception<GetAcqOrderResponse>"></exception>
		public async Task<M3Response<GetAcqOrderResponse>> GetAcqOrder(
			string m3AOCA, 
			string m3ARDN, 
			int? m3ARDL = null, 
			int? m3ARDX = null, 
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
			if (string.IsNullOrWhiteSpace(m3AOCA))
				throw new ArgumentNullException(nameof(m3AOCA));
			if (string.IsNullOrWhiteSpace(m3ARDN))
				throw new ArgumentNullException(nameof(m3ARDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("AOCA", m3AOCA.Trim())
				.WithQueryParameter("ARDN", m3ARDN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3ARDL.HasValue)
				request.WithQueryParameter("ARDL", m3ARDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ARDX.HasValue)
				request.WithQueryParameter("ARDX", m3ARDX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetAcqOrderResponse>(
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
		/// Name GetDmdOrder
		/// Description Get existing Demand Order details
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3DOCA">Demand order category (Required)</param>
		/// <param name="m3DRDN">Demand order number (Required)</param>
		/// <param name="m3DRDL">Demand order line (Required)</param>
		/// <param name="m3DRDX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDmdOrderResponse></returns>
		/// <exception cref="M3Exception<GetDmdOrderResponse>"></exception>
		public async Task<M3Response<GetDmdOrderResponse>> GetDmdOrder(
			string m3DOCA, 
			string m3DRDN, 
			int m3DRDL, 
			int? m3DRDX = null, 
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
			if (string.IsNullOrWhiteSpace(m3DOCA))
				throw new ArgumentNullException(nameof(m3DOCA));
			if (string.IsNullOrWhiteSpace(m3DRDN))
				throw new ArgumentNullException(nameof(m3DRDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("DOCA", m3DOCA.Trim())
				.WithQueryParameter("DRDN", m3DRDN.Trim())
				.WithQueryParameter("DRDL", m3DRDL.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3DRDX.HasValue)
				request.WithQueryParameter("DRDX", m3DRDX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetDmdOrderResponse>(
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
		/// Name LstAcqByDmdOrd
		/// Description List Acquisition by Dmd Order
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3DOCA">Demand order category (Required)</param>
		/// <param name="m3DRDN">Demand order number (Required)</param>
		/// <param name="m3DRDL">Demand order line (Required)</param>
		/// <param name="m3DRDX">Line suffix</param>
		/// <param name="m3AOCA">Acquistion order category</param>
		/// <param name="m3ARDN">Acquisition order number</param>
		/// <param name="m3ARDL">Acquisition order line</param>
		/// <param name="m3ARDX">Line suffix</param>
		/// <param name="m3NFTR">Number of filters</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAcqByDmdOrdResponse></returns>
		/// <exception cref="M3Exception<LstAcqByDmdOrdResponse>"></exception>
		public async Task<M3Response<LstAcqByDmdOrdResponse>> LstAcqByDmdOrd(
			string m3DOCA, 
			string m3DRDN, 
			int m3DRDL, 
			int? m3DRDX = null, 
			string m3AOCA = null, 
			string m3ARDN = null, 
			int? m3ARDL = null, 
			int? m3ARDX = null, 
			int? m3NFTR = null, 
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
			if (string.IsNullOrWhiteSpace(m3DOCA))
				throw new ArgumentNullException(nameof(m3DOCA));
			if (string.IsNullOrWhiteSpace(m3DRDN))
				throw new ArgumentNullException(nameof(m3DRDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("DOCA", m3DOCA.Trim())
				.WithQueryParameter("DRDN", m3DRDN.Trim())
				.WithQueryParameter("DRDL", m3DRDL.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3DRDX.HasValue)
				request.WithQueryParameter("DRDX", m3DRDX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AOCA))
				request.WithQueryParameter("AOCA", m3AOCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARDN))
				request.WithQueryParameter("ARDN", m3ARDN.Trim());
			if (m3ARDL.HasValue)
				request.WithQueryParameter("ARDL", m3ARDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ARDX.HasValue)
				request.WithQueryParameter("ARDX", m3ARDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3NFTR.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAcqByDmdOrdResponse>(
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
		/// Name LstDmdByAcqOrd
		/// Description List Demand by Acq Order
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3AOCA">Acquistion order category (Required)</param>
		/// <param name="m3ARDN">Acquisition order number (Required)</param>
		/// <param name="m3ARDL">Acquisition order line</param>
		/// <param name="m3ARDX">Line suffix</param>
		/// <param name="m3DOCA">Demand order category</param>
		/// <param name="m3DRDN">Demand order number</param>
		/// <param name="m3DRDL">Demand order line</param>
		/// <param name="m3DRDX">Line suffix</param>
		/// <param name="m3NFTR">Number of filters</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDmdByAcqOrdResponse></returns>
		/// <exception cref="M3Exception<LstDmdByAcqOrdResponse>"></exception>
		public async Task<M3Response<LstDmdByAcqOrdResponse>> LstDmdByAcqOrd(
			string m3AOCA, 
			string m3ARDN, 
			int? m3ARDL = null, 
			int? m3ARDX = null, 
			string m3DOCA = null, 
			string m3DRDN = null, 
			int? m3DRDL = null, 
			int? m3DRDX = null, 
			int? m3NFTR = null, 
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
			if (string.IsNullOrWhiteSpace(m3AOCA))
				throw new ArgumentNullException(nameof(m3AOCA));
			if (string.IsNullOrWhiteSpace(m3ARDN))
				throw new ArgumentNullException(nameof(m3ARDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("AOCA", m3AOCA.Trim())
				.WithQueryParameter("ARDN", m3ARDN.Trim());

			// Set optional parameters, checking for null/blank data for each element
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
			if (m3NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3NFTR.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstDmdByAcqOrdResponse>(
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
		/// Name Preallocate
		/// Description Preallocate
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3DOCA">Demand order category (Required)</param>
		/// <param name="m3DRDN">Demand order number (Required)</param>
		/// <param name="m3DRDL">Demand order line (Required)</param>
		/// <param name="m3AOCA">Acquistion order category (Required)</param>
		/// <param name="m3ARDN">Acquisition order number (Required)</param>
		/// <param name="m3PQTY">Pre-allocated quantity (Required)</param>
		/// <param name="m3DRDX">Line suffix</param>
		/// <param name="m3ARDL">Acquisition order line</param>
		/// <param name="m3ARDX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Preallocate(
			string m3DOCA, 
			string m3DRDN, 
			int m3DRDL, 
			string m3AOCA, 
			string m3ARDN, 
			decimal m3PQTY, 
			int? m3DRDX = null, 
			int? m3ARDL = null, 
			int? m3ARDX = null, 
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
			if (string.IsNullOrWhiteSpace(m3DOCA))
				throw new ArgumentNullException(nameof(m3DOCA));
			if (string.IsNullOrWhiteSpace(m3DRDN))
				throw new ArgumentNullException(nameof(m3DRDN));
			if (string.IsNullOrWhiteSpace(m3AOCA))
				throw new ArgumentNullException(nameof(m3AOCA));
			if (string.IsNullOrWhiteSpace(m3ARDN))
				throw new ArgumentNullException(nameof(m3ARDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("DOCA", m3DOCA.Trim())
				.WithQueryParameter("DRDN", m3DRDN.Trim())
				.WithQueryParameter("DRDL", m3DRDL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("AOCA", m3AOCA.Trim())
				.WithQueryParameter("ARDN", m3ARDN.Trim())
				.WithQueryParameter("PQTY", m3PQTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3DRDX.HasValue)
				request.WithQueryParameter("DRDX", m3DRDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ARDL.HasValue)
				request.WithQueryParameter("ARDL", m3ARDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ARDX.HasValue)
				request.WithQueryParameter("ARDX", m3ARDX.Value.ToString(CultureInfo.CurrentCulture));

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
