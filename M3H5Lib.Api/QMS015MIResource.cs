/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.QMS015MI;
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
	/// Name: QMS015MI
	/// Component Name: Item Whs Quality Plan
	/// Description: Item Warehouse Quality Plan
	/// Version Release: 5ea0
	///</summary>
	public partial class QMS015MIResource : M3BaseResourceEndpoint
	{
		public QMS015MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QMS015MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddItemWhQPlan
		/// Description Add Item Whs Quality Plan
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3QLPN">Quality plan (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3QTID">Reinspection ID</param>
		/// <param name="m3QDOR">DO test at receiving</param>
		/// <param name="m3QDCP">DO copy test results</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddItemWhQPlan(
			string m3QLPN, 
			string m3ITNO, 
			string m3WHLO, 
			string m3QTID = null, 
			int? m3QDOR = null, 
			int? m3QDCP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddItemWhQPlan",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3QLPN))
				throw new ArgumentNullException(nameof(m3QLPN));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("QLPN", m3QLPN.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3QTID))
				request.WithQueryParameter("QTID", m3QTID.Trim());
			if (m3QDOR.HasValue)
				request.WithQueryParameter("QDOR", m3QDOR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QDCP.HasValue)
				request.WithQueryParameter("QDCP", m3QDCP.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltItemWhQPlan
		/// Description DltItemWhQPlan
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3QLPN">Quality plan (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltItemWhQPlan(
			string m3QLPN, 
			string m3ITNO, 
			string m3WHLO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltItemWhQPlan",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3QLPN))
				throw new ArgumentNullException(nameof(m3QLPN));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("QLPN", m3QLPN.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim());

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
		/// Name GetItemWhQPlan
		/// Description Get Item Whs Quality Plan
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3QLPN">Quality plan (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItemWhQPlanResponse></returns>
		/// <exception cref="M3Exception<GetItemWhQPlanResponse>"></exception>
		public async Task<M3Response<GetItemWhQPlanResponse>> GetItemWhQPlan(
			string m3QLPN, 
			string m3ITNO, 
			string m3WHLO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetItemWhQPlan",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3QLPN))
				throw new ArgumentNullException(nameof(m3QLPN));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("QLPN", m3QLPN.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Execute the request
			var result = await Execute<GetItemWhQPlanResponse>(
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
		/// Name LstItemWhQPlan
		/// Description List Item Whs Quality Plan
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3QLPN">Quality plan (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemWhQPlanResponse></returns>
		/// <exception cref="M3Exception<LstItemWhQPlanResponse>"></exception>
		public async Task<M3Response<LstItemWhQPlanResponse>> LstItemWhQPlan(
			string m3QLPN, 
			string m3ITNO, 
			string m3WHLO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItemWhQPlan",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3QLPN))
				throw new ArgumentNullException(nameof(m3QLPN));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("QLPN", m3QLPN.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Execute the request
			var result = await Execute<LstItemWhQPlanResponse>(
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
		/// Name UpdItemWhQPlan
		/// Description Update Item Whs Quality Plan
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3QLPN">Quality plan (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3QTID">Reinspection ID</param>
		/// <param name="m3QDOR">DO test at receiving</param>
		/// <param name="m3QDCP">DO copy test results</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItemWhQPlan(
			string m3QLPN, 
			string m3ITNO, 
			string m3WHLO, 
			string m3QTID = null, 
			int? m3QDOR = null, 
			int? m3QDCP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdItemWhQPlan",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3QLPN))
				throw new ArgumentNullException(nameof(m3QLPN));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("QLPN", m3QLPN.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3QTID))
				request.WithQueryParameter("QTID", m3QTID.Trim());
			if (m3QDOR.HasValue)
				request.WithQueryParameter("QDOR", m3QDOR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QDCP.HasValue)
				request.WithQueryParameter("QDCP", m3QDCP.Value.ToString(CultureInfo.CurrentCulture));

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
