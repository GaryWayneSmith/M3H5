/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_QLPN">Quality plan (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_QTID">Reinspection ID</param>
		/// <param name="m3_QDOR">DO test at receiving</param>
		/// <param name="m3_QDCP">DO copy test results</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddItemWhQPlan(
			string m3_QLPN, 
			string m3_ITNO, 
			string m3_WHLO, 
			string m3_QTID = null, 
			int? m3_QDOR = null, 
			int? m3_QDCP = null, 
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
			if (string.IsNullOrWhiteSpace(m3_QLPN))
				throw new ArgumentNullException("m3_QLPN");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("QLPN", m3_QLPN.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_QTID))
				request.WithQueryParameter("QTID", m3_QTID.Trim());
			if (m3_QDOR.HasValue)
				request.WithQueryParameter("QDOR", m3_QDOR.Value.ToString());
			if (m3_QDCP.HasValue)
				request.WithQueryParameter("QDCP", m3_QDCP.Value.ToString());

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
		/// Name DltItemWhQPlan
		/// Description DltItemWhQPlan
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_QLPN">Quality plan (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltItemWhQPlan(
			string m3_QLPN, 
			string m3_ITNO, 
			string m3_WHLO, 
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
			if (string.IsNullOrWhiteSpace(m3_QLPN))
				throw new ArgumentNullException("m3_QLPN");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("QLPN", m3_QLPN.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

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
		/// Name GetItemWhQPlan
		/// Description Get Item Whs Quality Plan
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_QLPN">Quality plan (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItemWhQPlanResponse></returns>
		/// <exception cref="M3Exception<GetItemWhQPlanResponse>"></exception>
		public async Task<M3Response<GetItemWhQPlanResponse>> GetItemWhQPlan(
			string m3_QLPN, 
			string m3_ITNO, 
			string m3_WHLO, 
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
			if (string.IsNullOrWhiteSpace(m3_QLPN))
				throw new ArgumentNullException("m3_QLPN");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("QLPN", m3_QLPN.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Execute the request
			var result = await Execute<GetItemWhQPlanResponse>(
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
		/// Name LstItemWhQPlan
		/// Description List Item Whs Quality Plan
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_QLPN">Quality plan (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemWhQPlanResponse></returns>
		/// <exception cref="M3Exception<LstItemWhQPlanResponse>"></exception>
		public async Task<M3Response<LstItemWhQPlanResponse>> LstItemWhQPlan(
			string m3_QLPN, 
			string m3_ITNO, 
			string m3_WHLO, 
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
			if (string.IsNullOrWhiteSpace(m3_QLPN))
				throw new ArgumentNullException("m3_QLPN");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("QLPN", m3_QLPN.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Execute the request
			var result = await Execute<LstItemWhQPlanResponse>(
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
		/// Name UpdItemWhQPlan
		/// Description Update Item Whs Quality Plan
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_QLPN">Quality plan (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_QTID">Reinspection ID</param>
		/// <param name="m3_QDOR">DO test at receiving</param>
		/// <param name="m3_QDCP">DO copy test results</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItemWhQPlan(
			string m3_QLPN, 
			string m3_ITNO, 
			string m3_WHLO, 
			string m3_QTID = null, 
			int? m3_QDOR = null, 
			int? m3_QDCP = null, 
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
			if (string.IsNullOrWhiteSpace(m3_QLPN))
				throw new ArgumentNullException("m3_QLPN");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("QLPN", m3_QLPN.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_QTID))
				request.WithQueryParameter("QTID", m3_QTID.Trim());
			if (m3_QDOR.HasValue)
				request.WithQueryParameter("QDOR", m3_QDOR.Value.ToString());
			if (m3_QDCP.HasValue)
				request.WithQueryParameter("QDCP", m3_QDCP.Value.ToString());

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
