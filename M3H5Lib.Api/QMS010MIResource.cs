/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.QMS010MI;
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
	/// Name: QMS010MI
	/// Component Name: Sampling plan
	/// Description: Sampling plan
	/// Version Release: 15.x
	///</summary>
	public partial class QMS010MIResource : M3BaseResourceEndpoint
	{
		public QMS010MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QMS010MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddSamplingPlan
		/// Description Add a Sampling Plan
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3_SAPL">Sampling plan (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_GENF">ID generation</param>
		/// <param name="m3_STNM">Starting number</param>
		/// <param name="m3_SMAC">Sample action</param>
		/// <param name="m3_NBEX">Number of copies</param>
		/// <param name="m3_ACTF">Active</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSamplingPlan(
			string m3_SAPL, 
			string m3_TX40, 
			int? m3_GENF = null, 
			int? m3_STNM = null, 
			int? m3_SMAC = null, 
			int? m3_NBEX = null, 
			int? m3_ACTF = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSamplingPlan",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SAPL))
				throw new ArgumentNullException("m3_SAPL");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("SAPL", m3_SAPL.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_GENF.HasValue)
				request.WithQueryParameter("GENF", m3_GENF.Value.ToString());
			if (m3_STNM.HasValue)
				request.WithQueryParameter("STNM", m3_STNM.Value.ToString());
			if (m3_SMAC.HasValue)
				request.WithQueryParameter("SMAC", m3_SMAC.Value.ToString());
			if (m3_NBEX.HasValue)
				request.WithQueryParameter("NBEX", m3_NBEX.Value.ToString());
			if (m3_ACTF.HasValue)
				request.WithQueryParameter("ACTF", m3_ACTF.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
		/// Name DltSamplingPlan
		/// Description Delete a Sampling Plan
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3_SAPL">Sampling plan (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltSamplingPlan(
			string m3_SAPL, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltSamplingPlan",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SAPL))
				throw new ArgumentNullException("m3_SAPL");

			// Set mandatory parameters
			request
				.WithQueryParameter("SAPL", m3_SAPL.Trim());

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
		/// Name GetSamplingPlan
		/// Description Get a Sampling Plan
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3_SAPL">Sampling plan (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSamplingPlanResponse></returns>
		/// <exception cref="M3Exception<GetSamplingPlanResponse>"></exception>
		public async Task<M3Response<GetSamplingPlanResponse>> GetSamplingPlan(
			string m3_SAPL, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSamplingPlan",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SAPL))
				throw new ArgumentNullException("m3_SAPL");

			// Set mandatory parameters
			request
				.WithQueryParameter("SAPL", m3_SAPL.Trim());

			// Execute the request
			var result = await Execute<GetSamplingPlanResponse>(
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
		/// Name LstSamplingPlan
		/// Description List the Sampling Plan
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3_SAPL">Sampling plan (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSamplingPlanResponse></returns>
		/// <exception cref="M3Exception<LstSamplingPlanResponse>"></exception>
		public async Task<M3Response<LstSamplingPlanResponse>> LstSamplingPlan(
			string m3_SAPL, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSamplingPlan",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SAPL))
				throw new ArgumentNullException("m3_SAPL");

			// Set mandatory parameters
			request
				.WithQueryParameter("SAPL", m3_SAPL.Trim());

			// Execute the request
			var result = await Execute<LstSamplingPlanResponse>(
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
		/// Name UpdSamplingPlan
		/// Description Update a Sampling Plan
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3_SAPL">Sampling plan (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_GENF">ID generation</param>
		/// <param name="m3_STNM">Starting number</param>
		/// <param name="m3_SMAC">Sample action</param>
		/// <param name="m3_NBEX">Number of copies</param>
		/// <param name="m3_ACTF">Active</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSamplingPlan(
			string m3_SAPL, 
			string m3_TX40, 
			int? m3_GENF = null, 
			int? m3_STNM = null, 
			int? m3_SMAC = null, 
			int? m3_NBEX = null, 
			int? m3_ACTF = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdSamplingPlan",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SAPL))
				throw new ArgumentNullException("m3_SAPL");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("SAPL", m3_SAPL.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_GENF.HasValue)
				request.WithQueryParameter("GENF", m3_GENF.Value.ToString());
			if (m3_STNM.HasValue)
				request.WithQueryParameter("STNM", m3_STNM.Value.ToString());
			if (m3_SMAC.HasValue)
				request.WithQueryParameter("SMAC", m3_SMAC.Value.ToString());
			if (m3_NBEX.HasValue)
				request.WithQueryParameter("NBEX", m3_NBEX.Value.ToString());
			if (m3_ACTF.HasValue)
				request.WithQueryParameter("ACTF", m3_ACTF.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
