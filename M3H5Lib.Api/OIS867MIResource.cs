/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddScaleHead
		/// Description Add scale head
		/// Version Release: 
		/// </summary>
		/// <param name="m3SRSC">Rebate scale (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3RSCB">Supplier rebate scale base</param>
		/// <param name="m3PRRF">Price list</param>
		/// <param name="m3CUCP">Currency - sales price</param>
		/// <param name="m3SRCA">Rebate calculation method</param>
		/// <param name="m3SRBA">Rebate base</param>
		/// <param name="m3RPUN">Rebate amount unit of measure</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3SECW">Search criteria - warehouse</param>
		/// <param name="m3PRR1">Price list</param>
		/// <param name="m3CUC1">Currency</param>
		/// <param name="m3PCTP">Costing type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddScaleHead(
			string m3SRSC, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3RSCB = null, 
			string m3PRRF = null, 
			string m3CUCP = null, 
			int? m3SRCA = null, 
			int? m3SRBA = null, 
			string m3RPUN = null, 
			string m3CUCD = null, 
			string m3SUNO = null, 
			string m3AGNB = null, 
			string m3SECW = null, 
			string m3PRR1 = null, 
			string m3CUC1 = null, 
			string m3PCTP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddScaleHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SRSC))
				throw new ArgumentNullException(nameof(m3SRSC));

			// Set mandatory parameters
			request
				.WithQueryParameter("SRSC", m3SRSC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSCB))
				request.WithQueryParameter("RSCB", m3RSCB.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRRF))
				request.WithQueryParameter("PRRF", m3PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCP))
				request.WithQueryParameter("CUCP", m3CUCP.Trim());
			if (m3SRCA.HasValue)
				request.WithQueryParameter("SRCA", m3SRCA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SRBA.HasValue)
				request.WithQueryParameter("SRBA", m3SRBA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RPUN))
				request.WithQueryParameter("RPUN", m3RPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3SECW))
				request.WithQueryParameter("SECW", m3SECW.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRR1))
				request.WithQueryParameter("PRR1", m3PRR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUC1))
				request.WithQueryParameter("CUC1", m3CUC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PCTP))
				request.WithQueryParameter("PCTP", m3PCTP.Trim());

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
		/// Name AddScaleLimit
		/// Description Add scale limit
		/// Version Release: 
		/// </summary>
		/// <param name="m3SRSC">Rebate scale (Required)</param>
		/// <param name="m3LIMT">Limit value</param>
		/// <param name="m3SREP">Rebate percentage</param>
		/// <param name="m3SREA">Rebate amount</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddScaleLimit(
			string m3SRSC, 
			decimal? m3LIMT = null, 
			decimal? m3SREP = null, 
			decimal? m3SREA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddScaleLimit",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SRSC))
				throw new ArgumentNullException(nameof(m3SRSC));

			// Set mandatory parameters
			request
				.WithQueryParameter("SRSC", m3SRSC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3LIMT.HasValue)
				request.WithQueryParameter("LIMT", m3LIMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SREP.HasValue)
				request.WithQueryParameter("SREP", m3SREP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SREA.HasValue)
				request.WithQueryParameter("SREA", m3SREA.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelScale
		/// Description Delete scale
		/// Version Release: 
		/// </summary>
		/// <param name="m3SRSC">Rebate scale (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelScale(
			string m3SRSC, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelScale",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SRSC))
				throw new ArgumentNullException(nameof(m3SRSC));

			// Set mandatory parameters
			request
				.WithQueryParameter("SRSC", m3SRSC.Trim());

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
		/// Name DelScaleLimit
		/// Description Delete scale limit
		/// Version Release: 
		/// </summary>
		/// <param name="m3SRSC">Rebate scale (Required)</param>
		/// <param name="m3LIMT">Limit value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelScaleLimit(
			string m3SRSC, 
			decimal? m3LIMT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelScaleLimit",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SRSC))
				throw new ArgumentNullException(nameof(m3SRSC));

			// Set mandatory parameters
			request
				.WithQueryParameter("SRSC", m3SRSC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3LIMT.HasValue)
				request.WithQueryParameter("LIMT", m3LIMT.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetScaleHead
		/// Description Get scale head
		/// Version Release: 
		/// </summary>
		/// <param name="m3SRSC">Rebate scale (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetScaleHeadResponse></returns>
		/// <exception cref="M3Exception<GetScaleHeadResponse>"></exception>
		public async Task<M3Response<GetScaleHeadResponse>> GetScaleHead(
			string m3SRSC, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetScaleHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SRSC))
				throw new ArgumentNullException(nameof(m3SRSC));

			// Set mandatory parameters
			request
				.WithQueryParameter("SRSC", m3SRSC.Trim());

			// Execute the request
			var result = await Execute<GetScaleHeadResponse>(
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
		/// Name GetScaleLimit
		/// Description Get scale limit
		/// Version Release: 
		/// </summary>
		/// <param name="m3SRSC">Rebate scale (Required)</param>
		/// <param name="m3LIMT">Limit value (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetScaleLimitResponse></returns>
		/// <exception cref="M3Exception<GetScaleLimitResponse>"></exception>
		public async Task<M3Response<GetScaleLimitResponse>> GetScaleLimit(
			string m3SRSC, 
			decimal m3LIMT, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetScaleLimit",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SRSC))
				throw new ArgumentNullException(nameof(m3SRSC));

			// Set mandatory parameters
			request
				.WithQueryParameter("SRSC", m3SRSC.Trim())
				.WithQueryParameter("LIMT", m3LIMT.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetScaleLimitResponse>(
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
		/// Name LstScaleHead
		/// Description List scale head
		/// Version Release: 
		/// </summary>
		/// <param name="m3SRSC">Rebate scale (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstScaleHeadResponse></returns>
		/// <exception cref="M3Exception<LstScaleHeadResponse>"></exception>
		public async Task<M3Response<LstScaleHeadResponse>> LstScaleHead(
			string m3SRSC, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstScaleHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SRSC))
				throw new ArgumentNullException(nameof(m3SRSC));

			// Set mandatory parameters
			request
				.WithQueryParameter("SRSC", m3SRSC.Trim());

			// Execute the request
			var result = await Execute<LstScaleHeadResponse>(
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
		/// Name LstScaleLimit
		/// Description List scale limit
		/// Version Release: 
		/// </summary>
		/// <param name="m3SRSC">Rebate scale (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstScaleLimitResponse></returns>
		/// <exception cref="M3Exception<LstScaleLimitResponse>"></exception>
		public async Task<M3Response<LstScaleLimitResponse>> LstScaleLimit(
			string m3SRSC, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstScaleLimit",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SRSC))
				throw new ArgumentNullException(nameof(m3SRSC));

			// Set mandatory parameters
			request
				.WithQueryParameter("SRSC", m3SRSC.Trim());

			// Execute the request
			var result = await Execute<LstScaleLimitResponse>(
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
		/// Name UpdScaleHead
		/// Description Update scale head
		/// Version Release: 
		/// </summary>
		/// <param name="m3SRSC">Rebate scale (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3RSCB">Supplier rebate scale base</param>
		/// <param name="m3PRRF">Price list</param>
		/// <param name="m3CUCP">Currency - sales price</param>
		/// <param name="m3SRCA">Rebate calculation method</param>
		/// <param name="m3SRBA">Rebate base</param>
		/// <param name="m3RPUN">Rebate amount unit of measure</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3SECW">Search criteria - warehouse</param>
		/// <param name="m3PRR1">Price list</param>
		/// <param name="m3CUC1">Currency</param>
		/// <param name="m3PCTP">Costing type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdScaleHead(
			string m3SRSC, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3RSCB = null, 
			string m3PRRF = null, 
			string m3CUCP = null, 
			int? m3SRCA = null, 
			int? m3SRBA = null, 
			string m3RPUN = null, 
			string m3CUCD = null, 
			string m3SUNO = null, 
			string m3AGNB = null, 
			string m3SECW = null, 
			string m3PRR1 = null, 
			string m3CUC1 = null, 
			string m3PCTP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdScaleHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SRSC))
				throw new ArgumentNullException(nameof(m3SRSC));

			// Set mandatory parameters
			request
				.WithQueryParameter("SRSC", m3SRSC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSCB))
				request.WithQueryParameter("RSCB", m3RSCB.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRRF))
				request.WithQueryParameter("PRRF", m3PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCP))
				request.WithQueryParameter("CUCP", m3CUCP.Trim());
			if (m3SRCA.HasValue)
				request.WithQueryParameter("SRCA", m3SRCA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SRBA.HasValue)
				request.WithQueryParameter("SRBA", m3SRBA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RPUN))
				request.WithQueryParameter("RPUN", m3RPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3SECW))
				request.WithQueryParameter("SECW", m3SECW.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRR1))
				request.WithQueryParameter("PRR1", m3PRR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUC1))
				request.WithQueryParameter("CUC1", m3CUC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PCTP))
				request.WithQueryParameter("PCTP", m3PCTP.Trim());

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
		/// Name UpdScaleLimit
		/// Description Update scale limit
		/// Version Release: 
		/// </summary>
		/// <param name="m3SRSC">Rebate scale (Required)</param>
		/// <param name="m3LIMT">Limit value</param>
		/// <param name="m3SREP">Rebate percentage</param>
		/// <param name="m3SREA">Rebate amount</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdScaleLimit(
			string m3SRSC, 
			decimal? m3LIMT = null, 
			decimal? m3SREP = null, 
			decimal? m3SREA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdScaleLimit",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SRSC))
				throw new ArgumentNullException(nameof(m3SRSC));

			// Set mandatory parameters
			request
				.WithQueryParameter("SRSC", m3SRSC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3LIMT.HasValue)
				request.WithQueryParameter("LIMT", m3LIMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SREP.HasValue)
				request.WithQueryParameter("SREP", m3SREP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SREA.HasValue)
				request.WithQueryParameter("SREA", m3SREA.Value.ToString(CultureInfo.CurrentCulture));

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
