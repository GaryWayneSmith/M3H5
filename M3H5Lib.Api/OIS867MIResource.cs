/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.OIS867MI;
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
	/// Name: OIS867MI
	/// Component Name: OIS867
	/// Description: Supplier rebate on sales
	/// Version Release: 5e90
	///</summary>
	public partial class OIS867MIResource : M3BaseResourceEndpoint
	{
		public OIS867MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS867MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddScaleHead
		/// Description Add scale head
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SRSC">Rebate scale (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_RSCB">Supplier rebate scale base</param>
		/// <param name="m3_PRRF">Price list</param>
		/// <param name="m3_CUCP">Currency - sales price</param>
		/// <param name="m3_SRCA">Rebate calculation method</param>
		/// <param name="m3_SRBA">Rebate base</param>
		/// <param name="m3_RPUN">Rebate amount unit of measure</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_SECW">Search criteria - warehouse</param>
		/// <param name="m3_PRR1">Price list</param>
		/// <param name="m3_CUC1">Currency</param>
		/// <param name="m3_PCTP">Costing type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddScaleHead(
			string m3_SRSC, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_RSCB = null, 
			string m3_PRRF = null, 
			string m3_CUCP = null, 
			int? m3_SRCA = null, 
			int? m3_SRBA = null, 
			string m3_RPUN = null, 
			string m3_CUCD = null, 
			string m3_SUNO = null, 
			string m3_AGNB = null, 
			string m3_SECW = null, 
			string m3_PRR1 = null, 
			string m3_CUC1 = null, 
			string m3_PCTP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddScaleHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SRSC))
				throw new ArgumentNullException("m3_SRSC");

			// Set mandatory parameters
			request
				.WithQueryParameter("SRSC", m3_SRSC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSCB))
				request.WithQueryParameter("RSCB", m3_RSCB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRRF))
				request.WithQueryParameter("PRRF", m3_PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCP))
				request.WithQueryParameter("CUCP", m3_CUCP.Trim());
			if (m3_SRCA.HasValue)
				request.WithQueryParameter("SRCA", m3_SRCA.Value.ToString());
			if (m3_SRBA.HasValue)
				request.WithQueryParameter("SRBA", m3_SRBA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RPUN))
				request.WithQueryParameter("RPUN", m3_RPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SECW))
				request.WithQueryParameter("SECW", m3_SECW.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRR1))
				request.WithQueryParameter("PRR1", m3_PRR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUC1))
				request.WithQueryParameter("CUC1", m3_CUC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PCTP))
				request.WithQueryParameter("PCTP", m3_PCTP.Trim());

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
		/// Name AddScaleLimit
		/// Description Add scale limit
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SRSC">Rebate scale (Required)</param>
		/// <param name="m3_LIMT">Limit value</param>
		/// <param name="m3_SREP">Rebate percentage</param>
		/// <param name="m3_SREA">Rebate amount</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddScaleLimit(
			string m3_SRSC, 
			decimal? m3_LIMT = null, 
			decimal? m3_SREP = null, 
			decimal? m3_SREA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddScaleLimit",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SRSC))
				throw new ArgumentNullException("m3_SRSC");

			// Set mandatory parameters
			request
				.WithQueryParameter("SRSC", m3_SRSC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_LIMT.HasValue)
				request.WithQueryParameter("LIMT", m3_LIMT.Value.ToString());
			if (m3_SREP.HasValue)
				request.WithQueryParameter("SREP", m3_SREP.Value.ToString());
			if (m3_SREA.HasValue)
				request.WithQueryParameter("SREA", m3_SREA.Value.ToString());

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
		/// Name DelScale
		/// Description Delete scale
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SRSC">Rebate scale (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelScale(
			string m3_SRSC, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelScale",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SRSC))
				throw new ArgumentNullException("m3_SRSC");

			// Set mandatory parameters
			request
				.WithQueryParameter("SRSC", m3_SRSC.Trim());

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
		/// Name DelScaleLimit
		/// Description Delete scale limit
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SRSC">Rebate scale (Required)</param>
		/// <param name="m3_LIMT">Limit value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelScaleLimit(
			string m3_SRSC, 
			decimal? m3_LIMT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelScaleLimit",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SRSC))
				throw new ArgumentNullException("m3_SRSC");

			// Set mandatory parameters
			request
				.WithQueryParameter("SRSC", m3_SRSC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_LIMT.HasValue)
				request.WithQueryParameter("LIMT", m3_LIMT.Value.ToString());

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
		/// Name GetScaleHead
		/// Description Get scale head
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SRSC">Rebate scale (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetScaleHeadResponse></returns>
		/// <exception cref="M3Exception<GetScaleHeadResponse>"></exception>
		public async Task<M3Response<GetScaleHeadResponse>> GetScaleHead(
			string m3_SRSC, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetScaleHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SRSC))
				throw new ArgumentNullException("m3_SRSC");

			// Set mandatory parameters
			request
				.WithQueryParameter("SRSC", m3_SRSC.Trim());

			// Execute the request
			var result = await Execute<GetScaleHeadResponse>(
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
		/// Name GetScaleLimit
		/// Description Get scale limit
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SRSC">Rebate scale (Required)</param>
		/// <param name="m3_LIMT">Limit value (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetScaleLimitResponse></returns>
		/// <exception cref="M3Exception<GetScaleLimitResponse>"></exception>
		public async Task<M3Response<GetScaleLimitResponse>> GetScaleLimit(
			string m3_SRSC, 
			decimal m3_LIMT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetScaleLimit",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SRSC))
				throw new ArgumentNullException("m3_SRSC");

			// Set mandatory parameters
			request
				.WithQueryParameter("SRSC", m3_SRSC.Trim())
				.WithQueryParameter("LIMT", m3_LIMT.ToString());

			// Execute the request
			var result = await Execute<GetScaleLimitResponse>(
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
		/// Name LstScaleHead
		/// Description List scale head
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SRSC">Rebate scale (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstScaleHeadResponse></returns>
		/// <exception cref="M3Exception<LstScaleHeadResponse>"></exception>
		public async Task<M3Response<LstScaleHeadResponse>> LstScaleHead(
			string m3_SRSC, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstScaleHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SRSC))
				throw new ArgumentNullException("m3_SRSC");

			// Set mandatory parameters
			request
				.WithQueryParameter("SRSC", m3_SRSC.Trim());

			// Execute the request
			var result = await Execute<LstScaleHeadResponse>(
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
		/// Name LstScaleLimit
		/// Description List scale limit
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SRSC">Rebate scale (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstScaleLimitResponse></returns>
		/// <exception cref="M3Exception<LstScaleLimitResponse>"></exception>
		public async Task<M3Response<LstScaleLimitResponse>> LstScaleLimit(
			string m3_SRSC, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstScaleLimit",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SRSC))
				throw new ArgumentNullException("m3_SRSC");

			// Set mandatory parameters
			request
				.WithQueryParameter("SRSC", m3_SRSC.Trim());

			// Execute the request
			var result = await Execute<LstScaleLimitResponse>(
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
		/// Name UpdScaleHead
		/// Description Update scale head
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SRSC">Rebate scale (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_RSCB">Supplier rebate scale base</param>
		/// <param name="m3_PRRF">Price list</param>
		/// <param name="m3_CUCP">Currency - sales price</param>
		/// <param name="m3_SRCA">Rebate calculation method</param>
		/// <param name="m3_SRBA">Rebate base</param>
		/// <param name="m3_RPUN">Rebate amount unit of measure</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_SECW">Search criteria - warehouse</param>
		/// <param name="m3_PRR1">Price list</param>
		/// <param name="m3_CUC1">Currency</param>
		/// <param name="m3_PCTP">Costing type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdScaleHead(
			string m3_SRSC, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_RSCB = null, 
			string m3_PRRF = null, 
			string m3_CUCP = null, 
			int? m3_SRCA = null, 
			int? m3_SRBA = null, 
			string m3_RPUN = null, 
			string m3_CUCD = null, 
			string m3_SUNO = null, 
			string m3_AGNB = null, 
			string m3_SECW = null, 
			string m3_PRR1 = null, 
			string m3_CUC1 = null, 
			string m3_PCTP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdScaleHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SRSC))
				throw new ArgumentNullException("m3_SRSC");

			// Set mandatory parameters
			request
				.WithQueryParameter("SRSC", m3_SRSC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSCB))
				request.WithQueryParameter("RSCB", m3_RSCB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRRF))
				request.WithQueryParameter("PRRF", m3_PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCP))
				request.WithQueryParameter("CUCP", m3_CUCP.Trim());
			if (m3_SRCA.HasValue)
				request.WithQueryParameter("SRCA", m3_SRCA.Value.ToString());
			if (m3_SRBA.HasValue)
				request.WithQueryParameter("SRBA", m3_SRBA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RPUN))
				request.WithQueryParameter("RPUN", m3_RPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SECW))
				request.WithQueryParameter("SECW", m3_SECW.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRR1))
				request.WithQueryParameter("PRR1", m3_PRR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUC1))
				request.WithQueryParameter("CUC1", m3_CUC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PCTP))
				request.WithQueryParameter("PCTP", m3_PCTP.Trim());

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
		/// Name UpdScaleLimit
		/// Description Update scale limit
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SRSC">Rebate scale (Required)</param>
		/// <param name="m3_LIMT">Limit value</param>
		/// <param name="m3_SREP">Rebate percentage</param>
		/// <param name="m3_SREA">Rebate amount</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdScaleLimit(
			string m3_SRSC, 
			decimal? m3_LIMT = null, 
			decimal? m3_SREP = null, 
			decimal? m3_SREA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdScaleLimit",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SRSC))
				throw new ArgumentNullException("m3_SRSC");

			// Set mandatory parameters
			request
				.WithQueryParameter("SRSC", m3_SRSC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_LIMT.HasValue)
				request.WithQueryParameter("LIMT", m3_LIMT.Value.ToString());
			if (m3_SREP.HasValue)
				request.WithQueryParameter("SREP", m3_SREP.Value.ToString());
			if (m3_SREA.HasValue)
				request.WithQueryParameter("SREA", m3_SREA.Value.ToString());

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
