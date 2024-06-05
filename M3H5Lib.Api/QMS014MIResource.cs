/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.QMS014MI;
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
	/// Name: QMS014MI
	/// Component Name: Reinspection Plan
	/// Description: Reinspection Plan
	/// Version Release: 5ea0
	///</summary>
	public partial class QMS014MIResource : M3BaseResourceEndpoint
	{
		public QMS014MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QMS014MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddReinsPlan
		/// Description Add Reinspection Plan
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_QTID">Reinspection ID (Required)</param>
		/// <param name="m3_QTSQ">Reinspection sequence (Required)</param>
		/// <param name="m3_REDY">Reinspection days</param>
		/// <param name="m3_REHR">Reinspection hours</param>
		/// <param name="m3_REMN">Reinspection minutes</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddReinsPlan(
			string m3_QTID, 
			int m3_QTSQ, 
			int? m3_REDY = null, 
			int? m3_REHR = null, 
			int? m3_REMN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddReinsPlan",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_QTID))
				throw new ArgumentNullException("m3_QTID");

			// Set mandatory parameters
			request
				.WithQueryParameter("QTID", m3_QTID.Trim())
				.WithQueryParameter("QTSQ", m3_QTSQ.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_REDY.HasValue)
				request.WithQueryParameter("REDY", m3_REDY.Value.ToString());
			if (m3_REHR.HasValue)
				request.WithQueryParameter("REHR", m3_REHR.Value.ToString());
			if (m3_REMN.HasValue)
				request.WithQueryParameter("REMN", m3_REMN.Value.ToString());

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
		/// Name DltReinsPlan
		/// Description Delete Reinspection Plan
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_QTID">Reinspection ID (Required)</param>
		/// <param name="m3_QTSQ">Reinspection sequence (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltReinsPlan(
			string m3_QTID, 
			int m3_QTSQ, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltReinsPlan",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_QTID))
				throw new ArgumentNullException("m3_QTID");

			// Set mandatory parameters
			request
				.WithQueryParameter("QTID", m3_QTID.Trim())
				.WithQueryParameter("QTSQ", m3_QTSQ.ToString());

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
		/// Name GetReinsPlan
		/// Description Get Reinspection Plan
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_QTID">Reinspection ID (Required)</param>
		/// <param name="m3_QTSQ">Reinspection sequence (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetReinsPlanResponse></returns>
		/// <exception cref="M3Exception<GetReinsPlanResponse>"></exception>
		public async Task<M3Response<GetReinsPlanResponse>> GetReinsPlan(
			string m3_QTID, 
			int m3_QTSQ, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetReinsPlan",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_QTID))
				throw new ArgumentNullException("m3_QTID");

			// Set mandatory parameters
			request
				.WithQueryParameter("QTID", m3_QTID.Trim())
				.WithQueryParameter("QTSQ", m3_QTSQ.ToString());

			// Execute the request
			var result = await Execute<GetReinsPlanResponse>(
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
		/// Name LstReinsPlan
		/// Description List Reinspection Plan
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_QTID">Reinspection ID (Required)</param>
		/// <param name="m3_QTSQ">Reinspection sequence (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstReinsPlanResponse></returns>
		/// <exception cref="M3Exception<LstReinsPlanResponse>"></exception>
		public async Task<M3Response<LstReinsPlanResponse>> LstReinsPlan(
			string m3_QTID, 
			int m3_QTSQ, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstReinsPlan",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_QTID))
				throw new ArgumentNullException("m3_QTID");

			// Set mandatory parameters
			request
				.WithQueryParameter("QTID", m3_QTID.Trim())
				.WithQueryParameter("QTSQ", m3_QTSQ.ToString());

			// Execute the request
			var result = await Execute<LstReinsPlanResponse>(
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
		/// Name UpdReinsPlan
		/// Description Update Reinspection Plan
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_QTID">Reinspection ID (Required)</param>
		/// <param name="m3_QTSQ">Reinspection sequence (Required)</param>
		/// <param name="m3_REDY">Reinspection days</param>
		/// <param name="m3_REHR">Reinspection hours</param>
		/// <param name="m3_REMN">Reinspection minutes</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdReinsPlan(
			string m3_QTID, 
			int m3_QTSQ, 
			int? m3_REDY = null, 
			int? m3_REHR = null, 
			int? m3_REMN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdReinsPlan",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_QTID))
				throw new ArgumentNullException("m3_QTID");

			// Set mandatory parameters
			request
				.WithQueryParameter("QTID", m3_QTID.Trim())
				.WithQueryParameter("QTSQ", m3_QTSQ.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_REDY.HasValue)
				request.WithQueryParameter("REDY", m3_REDY.Value.ToString());
			if (m3_REHR.HasValue)
				request.WithQueryParameter("REHR", m3_REHR.Value.ToString());
			if (m3_REMN.HasValue)
				request.WithQueryParameter("REMN", m3_REMN.Value.ToString());

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
