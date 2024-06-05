/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.ARS251MI;
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
	/// Name: ARS251MI
	/// Component Name: AccountsReceivableInformation
	/// Description: Accounts receivable information interface
	/// Version Release: 5ea0
	///</summary>
	public partial class ARS251MIResource : M3BaseResourceEndpoint
	{
		public ARS251MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "ARS251MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddInfoCat
		/// Description AddInfoCat
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_JRNO">Journal number (Required)</param>
		/// <param name="m3_JSNO">Journal sequence number (Required)</param>
		/// <param name="m3_SEXN">AR information category (Required)</param>
		/// <param name="m3_SEXI">AR additional information (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_SEXS">AR information sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddInfoCat(
			int m3_YEA4, 
			int m3_JRNO, 
			int m3_JSNO, 
			int m3_SEXN, 
			string m3_SEXI, 
			string m3_DIVI = null, 
			int? m3_SEXS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddInfoCat",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SEXI))
				throw new ArgumentNullException("m3_SEXI");

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("JRNO", m3_JRNO.ToString())
				.WithQueryParameter("JSNO", m3_JSNO.ToString())
				.WithQueryParameter("SEXN", m3_SEXN.ToString())
				.WithQueryParameter("SEXI", m3_SEXI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_SEXS.HasValue)
				request.WithQueryParameter("SEXS", m3_SEXS.Value.ToString());

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
		/// Name DltInfoCat
		/// Description DltInfoCat
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_JRNO">Journal number (Required)</param>
		/// <param name="m3_JSNO">Journal sequence number (Required)</param>
		/// <param name="m3_SEXN">AR information category (Required)</param>
		/// <param name="m3_SEXI">AR additional information (Required)</param>
		/// <param name="m3_SEXS">AR information sequence number (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltInfoCat(
			int m3_YEA4, 
			int m3_JRNO, 
			int m3_JSNO, 
			int m3_SEXN, 
			string m3_SEXI, 
			int m3_SEXS, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltInfoCat",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SEXI))
				throw new ArgumentNullException("m3_SEXI");

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("JRNO", m3_JRNO.ToString())
				.WithQueryParameter("JSNO", m3_JSNO.ToString())
				.WithQueryParameter("SEXN", m3_SEXN.ToString())
				.WithQueryParameter("SEXI", m3_SEXI.Trim())
				.WithQueryParameter("SEXS", m3_SEXS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

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
		/// Name LstInfo
		/// Description Get additional information
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_JRNO">Journal number (Required)</param>
		/// <param name="m3_JSNO">Journal sequence number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_SEXN">GL information number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInfoResponse></returns>
		/// <exception cref="M3Exception<LstInfoResponse>"></exception>
		public async Task<M3Response<LstInfoResponse>> LstInfo(
			int m3_YEA4, 
			int m3_JRNO, 
			int m3_JSNO, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			int? m3_SEXN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInfo",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("JRNO", m3_JRNO.ToString())
				.WithQueryParameter("JSNO", m3_JSNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_SEXN.HasValue)
				request.WithQueryParameter("SEXN", m3_SEXN.Value.ToString());

			// Execute the request
			var result = await Execute<LstInfoResponse>(
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
		/// Name LstInfoPerAddNo
		/// Description List information per additional number
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_SEXN">AR information category (Required)</param>
		/// <param name="m3_SEXI">AR additional information (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_SEXS">AR information sequence number</param>
		/// <param name="m3_YEA4">Year</param>
		/// <param name="m3_JRNO">Journal number</param>
		/// <param name="m3_JSNO">Journal sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInfoPerAddNoResponse></returns>
		/// <exception cref="M3Exception<LstInfoPerAddNoResponse>"></exception>
		public async Task<M3Response<LstInfoPerAddNoResponse>> LstInfoPerAddNo(
			int m3_SEXN, 
			string m3_SEXI, 
			string m3_DIVI = null, 
			int? m3_SEXS = null, 
			int? m3_YEA4 = null, 
			int? m3_JRNO = null, 
			int? m3_JSNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInfoPerAddNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SEXI))
				throw new ArgumentNullException("m3_SEXI");

			// Set mandatory parameters
			request
				.WithQueryParameter("SEXN", m3_SEXN.ToString())
				.WithQueryParameter("SEXI", m3_SEXI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_SEXS.HasValue)
				request.WithQueryParameter("SEXS", m3_SEXS.Value.ToString());
			if (m3_YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3_YEA4.Value.ToString());
			if (m3_JRNO.HasValue)
				request.WithQueryParameter("JRNO", m3_JRNO.Value.ToString());
			if (m3_JSNO.HasValue)
				request.WithQueryParameter("JSNO", m3_JSNO.Value.ToString());

			// Execute the request
			var result = await Execute<LstInfoPerAddNoResponse>(
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
		/// Name LstInvInfo
		/// Description Get additional information with invoice number
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_PYNO">Payer (Required)</param>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_CINO">Invoice number (Required)</param>
		/// <param name="m3_INYR">Invoice year (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_SEXN">GL information number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvInfoResponse></returns>
		/// <exception cref="M3Exception<LstInvInfoResponse>"></exception>
		public async Task<M3Response<LstInvInfoResponse>> LstInvInfo(
			string m3_PYNO, 
			string m3_CUNO, 
			string m3_CINO, 
			int m3_INYR, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			int? m3_SEXN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInvInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PYNO))
				throw new ArgumentNullException("m3_PYNO");
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_CINO))
				throw new ArgumentNullException("m3_CINO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PYNO", m3_PYNO.Trim())
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("CINO", m3_CINO.Trim())
				.WithQueryParameter("INYR", m3_INYR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_SEXN.HasValue)
				request.WithQueryParameter("SEXN", m3_SEXN.Value.ToString());

			// Execute the request
			var result = await Execute<LstInvInfoResponse>(
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
