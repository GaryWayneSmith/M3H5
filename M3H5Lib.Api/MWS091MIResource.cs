/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MWS091MI;
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
	/// Name: MWS091MI
	/// Component Name: Customer Variations
	/// Description: Api: Core Attrition
	/// Version Release: 14.x
	///</summary>
	public partial class MWS091MIResource : M3BaseResourceEndpoint
	{
		public MWS091MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MWS091MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddCorAttrition
		/// Description Add Core Attrition
		/// Version Release: 
		/// </summary>
		/// <param name="m3_ENNO">Entitlement number (Required)</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_AODT">Attrition date</param>
		/// <param name="m3_ATQT">Attrition quantity</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCorAttrition(
			string m3_ENNO, 
			int? m3_SEQN = null, 
			string m3_STAT = null, 
			DateTime? m3_AODT = null, 
			decimal? m3_ATQT = null, 
			string m3_RSCD = null, 
			string m3_ITNO = null, 
			string m3_SUNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCorAttrition",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ENNO))
				throw new ArgumentNullException("m3_ENNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ENNO", m3_ENNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_AODT.HasValue)
				request.WithQueryParameter("AODT", m3_AODT.Value.ToM3String());
			if (m3_ATQT.HasValue)
				request.WithQueryParameter("ATQT", m3_ATQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());

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
		/// Name ChgCorAttrition
		/// Description Change Core Attrition
		/// Version Release: 
		/// </summary>
		/// <param name="m3_ENNO">Entitlement number (Required)</param>
		/// <param name="m3_SEQN">Sequence number (Required)</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_AODT">Attrition date</param>
		/// <param name="m3_ATQT">Attrition quantity</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgCorAttrition(
			string m3_ENNO, 
			int m3_SEQN, 
			string m3_STAT = null, 
			DateTime? m3_AODT = null, 
			decimal? m3_ATQT = null, 
			string m3_RSCD = null, 
			string m3_ITNO = null, 
			string m3_SUNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgCorAttrition",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ENNO))
				throw new ArgumentNullException("m3_ENNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ENNO", m3_ENNO.Trim())
				.WithQueryParameter("SEQN", m3_SEQN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_AODT.HasValue)
				request.WithQueryParameter("AODT", m3_AODT.Value.ToM3String());
			if (m3_ATQT.HasValue)
				request.WithQueryParameter("ATQT", m3_ATQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());

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
		/// Name DltCorAttrition
		/// Description Delete Core Attrition
		/// Version Release: 
		/// </summary>
		/// <param name="m3_ENNO">Entitlement number (Required)</param>
		/// <param name="m3_SEQN">Sequence number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DltCorAttritionResponse></returns>
		/// <exception cref="M3Exception<DltCorAttritionResponse>"></exception>
		public async Task<M3Response<DltCorAttritionResponse>> DltCorAttrition(
			string m3_ENNO, 
			int m3_SEQN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltCorAttrition",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ENNO))
				throw new ArgumentNullException("m3_ENNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ENNO", m3_ENNO.Trim())
				.WithQueryParameter("SEQN", m3_SEQN.ToString());

			// Execute the request
			var result = await Execute<DltCorAttritionResponse>(
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
		/// Name GetCorAttrition
		/// Description Get Core Attrition
		/// Version Release: 
		/// </summary>
		/// <param name="m3_ENNO">Entitlement number (Required)</param>
		/// <param name="m3_SEQN">Sequence number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCorAttritionResponse></returns>
		/// <exception cref="M3Exception<GetCorAttritionResponse>"></exception>
		public async Task<M3Response<GetCorAttritionResponse>> GetCorAttrition(
			string m3_ENNO, 
			int m3_SEQN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetCorAttrition",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ENNO))
				throw new ArgumentNullException("m3_ENNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ENNO", m3_ENNO.Trim())
				.WithQueryParameter("SEQN", m3_SEQN.ToString());

			// Execute the request
			var result = await Execute<GetCorAttritionResponse>(
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
		/// Name LstAttrBySuno
		/// Description List Core Attrition by supplier
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_STAT">Status (Required)</param>
		/// <param name="m3_ENNO">Entitlement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrBySunoResponse></returns>
		/// <exception cref="M3Exception<LstAttrBySunoResponse>"></exception>
		public async Task<M3Response<LstAttrBySunoResponse>> LstAttrBySuno(
			string m3_SUNO, 
			string m3_STAT, 
			string m3_ENNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAttrBySuno",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_STAT))
				throw new ArgumentNullException("m3_STAT");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("STAT", m3_STAT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ENNO))
				request.WithQueryParameter("ENNO", m3_ENNO.Trim());

			// Execute the request
			var result = await Execute<LstAttrBySunoResponse>(
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
		/// Name LstCorAttrition
		/// Description List Core Attrition
		/// Version Release: 
		/// </summary>
		/// <param name="m3_ENNO">Entitlement number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCorAttritionResponse></returns>
		/// <exception cref="M3Exception<LstCorAttritionResponse>"></exception>
		public async Task<M3Response<LstCorAttritionResponse>> LstCorAttrition(
			string m3_ENNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCorAttrition",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ENNO))
				throw new ArgumentNullException("m3_ENNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ENNO", m3_ENNO.Trim());

			// Execute the request
			var result = await Execute<LstCorAttritionResponse>(
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
