/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddCorAttrition
		/// Description Add Core Attrition
		/// Version Release: 
		/// </summary>
		/// <param name="m3ENNO">Entitlement number (Required)</param>
		/// <param name="m3SEQN">Sequence number</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3AODT">Attrition date</param>
		/// <param name="m3ATQT">Attrition quantity</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCorAttrition(
			string m3ENNO, 
			int? m3SEQN = null, 
			string m3STAT = null, 
			DateTime? m3AODT = null, 
			decimal? m3ATQT = null, 
			string m3RSCD = null, 
			string m3ITNO = null, 
			string m3SUNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddCorAttrition",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ENNO))
				throw new ArgumentNullException(nameof(m3ENNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ENNO", m3ENNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3SEQN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3AODT.HasValue)
				request.WithQueryParameter("AODT", m3AODT.Value.ToM3String());
			if (m3ATQT.HasValue)
				request.WithQueryParameter("ATQT", m3ATQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());

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
		/// Name ChgCorAttrition
		/// Description Change Core Attrition
		/// Version Release: 
		/// </summary>
		/// <param name="m3ENNO">Entitlement number (Required)</param>
		/// <param name="m3SEQN">Sequence number (Required)</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3AODT">Attrition date</param>
		/// <param name="m3ATQT">Attrition quantity</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgCorAttrition(
			string m3ENNO, 
			int m3SEQN, 
			string m3STAT = null, 
			DateTime? m3AODT = null, 
			decimal? m3ATQT = null, 
			string m3RSCD = null, 
			string m3ITNO = null, 
			string m3SUNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgCorAttrition",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ENNO))
				throw new ArgumentNullException(nameof(m3ENNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ENNO", m3ENNO.Trim())
				.WithQueryParameter("SEQN", m3SEQN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3AODT.HasValue)
				request.WithQueryParameter("AODT", m3AODT.Value.ToM3String());
			if (m3ATQT.HasValue)
				request.WithQueryParameter("ATQT", m3ATQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());

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
		/// Name DltCorAttrition
		/// Description Delete Core Attrition
		/// Version Release: 
		/// </summary>
		/// <param name="m3ENNO">Entitlement number (Required)</param>
		/// <param name="m3SEQN">Sequence number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DltCorAttritionResponse></returns>
		/// <exception cref="M3Exception<DltCorAttritionResponse>"></exception>
		public async Task<M3Response<DltCorAttritionResponse>> DltCorAttrition(
			string m3ENNO, 
			int m3SEQN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltCorAttrition",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ENNO))
				throw new ArgumentNullException(nameof(m3ENNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ENNO", m3ENNO.Trim())
				.WithQueryParameter("SEQN", m3SEQN.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<DltCorAttritionResponse>(
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
		/// Name GetCorAttrition
		/// Description Get Core Attrition
		/// Version Release: 
		/// </summary>
		/// <param name="m3ENNO">Entitlement number (Required)</param>
		/// <param name="m3SEQN">Sequence number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCorAttritionResponse></returns>
		/// <exception cref="M3Exception<GetCorAttritionResponse>"></exception>
		public async Task<M3Response<GetCorAttritionResponse>> GetCorAttrition(
			string m3ENNO, 
			int m3SEQN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetCorAttrition",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ENNO))
				throw new ArgumentNullException(nameof(m3ENNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ENNO", m3ENNO.Trim())
				.WithQueryParameter("SEQN", m3SEQN.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetCorAttritionResponse>(
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
		/// Name LstAttrBySuno
		/// Description List Core Attrition by supplier
		/// Version Release: 
		/// </summary>
		/// <param name="m3SUNO">Supplier (Required)</param>
		/// <param name="m3STAT">Status (Required)</param>
		/// <param name="m3ENNO">Entitlement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrBySunoResponse></returns>
		/// <exception cref="M3Exception<LstAttrBySunoResponse>"></exception>
		public async Task<M3Response<LstAttrBySunoResponse>> LstAttrBySuno(
			string m3SUNO, 
			string m3STAT, 
			string m3ENNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAttrBySuno",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3STAT))
				throw new ArgumentNullException(nameof(m3STAT));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("STAT", m3STAT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ENNO))
				request.WithQueryParameter("ENNO", m3ENNO.Trim());

			// Execute the request
			var result = await Execute<LstAttrBySunoResponse>(
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
		/// Name LstCorAttrition
		/// Description List Core Attrition
		/// Version Release: 
		/// </summary>
		/// <param name="m3ENNO">Entitlement number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCorAttritionResponse></returns>
		/// <exception cref="M3Exception<LstCorAttritionResponse>"></exception>
		public async Task<M3Response<LstCorAttritionResponse>> LstCorAttrition(
			string m3ENNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstCorAttrition",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ENNO))
				throw new ArgumentNullException(nameof(m3ENNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ENNO", m3ENNO.Trim());

			// Execute the request
			var result = await Execute<LstCorAttritionResponse>(
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
