/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.OIS010MI;
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
	/// Name: OIS010MI
	/// Component Name: OrderType
	/// Description: Order type interface
	/// Version Release: 5e90
	///</summary>
	public partial class OIS010MIResource : M3BaseResourceEndpoint
	{
		public OIS010MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS010MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetFieldInfo
		/// Description Get field information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORTP">Customer order type (Required)</param>
		/// <param name="m3FLDI">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFieldInfoResponse></returns>
		/// <exception cref="M3Exception<GetFieldInfoResponse>"></exception>
		public async Task<M3Response<GetFieldInfoResponse>> GetFieldInfo(
			string m3ORTP, 
			string m3FLDI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetFieldInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORTP))
				throw new ArgumentNullException(nameof(m3ORTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORTP", m3ORTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FLDI))
				request.WithQueryParameter("FLDI", m3FLDI.Trim());

			// Execute the request
			var result = await Execute<GetFieldInfoResponse>(
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
		/// Name LstOrdTypeChrg
		/// Description List order type connected charges
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORTP">Customer order type</param>
		/// <param name="m3CRID">Charge</param>
		/// <param name="m3CRTY">Internal charge</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOrdTypeChrgResponse></returns>
		/// <exception cref="M3Exception<LstOrdTypeChrgResponse>"></exception>
		public async Task<M3Response<LstOrdTypeChrgResponse>> LstOrdTypeChrg(
			int? m3CONO = null, 
			string m3ORTP = null, 
			string m3CRID = null, 
			int? m3CRTY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstOrdTypeChrg",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORTP))
				request.WithQueryParameter("ORTP", m3ORTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CRID))
				request.WithQueryParameter("CRID", m3CRID.Trim());
			if (m3CRTY.HasValue)
				request.WithQueryParameter("CRTY", m3CRTY.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstOrdTypeChrgResponse>(
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
		/// Name LstOrderTypes
		/// Description List order type
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORTP">Customer order type</param>
		/// <param name="m3ORTK">Customer order category</param>
		/// <param name="m3WODP">List authorized order types</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOrderTypesResponse></returns>
		/// <exception cref="M3Exception<LstOrderTypesResponse>"></exception>
		public async Task<M3Response<LstOrderTypesResponse>> LstOrderTypes(
			int? m3CONO = null, 
			string m3ORTP = null, 
			string m3ORTK = null, 
			int? m3WODP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstOrderTypes",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORTP))
				request.WithQueryParameter("ORTP", m3ORTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTK))
				request.WithQueryParameter("ORTK", m3ORTK.Trim());
			if (m3WODP.HasValue)
				request.WithQueryParameter("WODP", m3WODP.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstOrderTypesResponse>(
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
