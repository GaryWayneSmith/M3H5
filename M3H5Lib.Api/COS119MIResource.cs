/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddConnection
		/// Description Add order connection
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3CNPE">Contact (Required)</param>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3ADRT">Address type</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3RFTP">Contact type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddConnection(
			string m3CNPE, 
			string m3ORNO = null, 
			int? m3ADRT = null, 
			string m3ADID = null, 
			string m3RFTP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddConnection",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CNPE))
				throw new ArgumentNullException(nameof(m3CNPE));

			// Set mandatory parameters
			request
				.WithQueryParameter("CNPE", m3CNPE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (m3ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3ADRT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFTP))
				request.WithQueryParameter("RFTP", m3RFTP.Trim());

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

		/// <summary>
		/// Name DeleteConnect
		/// Description Delete order connection
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3CNPE">Contact (Required)</param>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3ADRT">Address type</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3RFTP">Contact type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteConnect(
			string m3CNPE, 
			string m3ORNO = null, 
			int? m3ADRT = null, 
			string m3ADID = null, 
			string m3RFTP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DeleteConnect",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CNPE))
				throw new ArgumentNullException(nameof(m3CNPE));

			// Set mandatory parameters
			request
				.WithQueryParameter("CNPE", m3CNPE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (m3ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3ADRT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFTP))
				request.WithQueryParameter("RFTP", m3RFTP.Trim());

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

		/// <summary>
		/// Name LstByOrder
		/// Description LstByOrder
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3ADRT">Address type</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3RFTP">Contact type</param>
		/// <param name="m3CNPE">Contact</param>
		/// <param name="m3NFTR">Number of filters</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByOrderResponse></returns>
		/// <exception cref="M3Exception<LstByOrderResponse>"></exception>
		public async Task<M3Response<LstByOrderResponse>> LstByOrder(
			string m3ORNO = null, 
			int? m3ADRT = null, 
			string m3ADID = null, 
			string m3RFTP = null, 
			string m3CNPE = null, 
			int? m3NFTR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByOrder",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (m3ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3ADRT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFTP))
				request.WithQueryParameter("RFTP", m3RFTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CNPE))
				request.WithQueryParameter("CNPE", m3CNPE.Trim());
			if (m3NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3NFTR.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstByOrderResponse>(
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
		/// Name LstConnection
		/// Description List order connection
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3CNPE">Contact</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstConnectionResponse></returns>
		/// <exception cref="M3Exception<LstConnectionResponse>"></exception>
		public async Task<M3Response<LstConnectionResponse>> LstConnection(
			string m3CNPE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstConnection",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CNPE))
				request.WithQueryParameter("CNPE", m3CNPE.Trim());

			// Execute the request
			var result = await Execute<LstConnectionResponse>(
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
