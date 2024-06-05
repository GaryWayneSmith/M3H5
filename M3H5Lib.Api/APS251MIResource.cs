/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.APS251MI;
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
	/// Name: APS251MI
	/// Component Name: AccountsPayableInformation
	/// Description: Accounts payable information interface
	/// Version Release: 5ea0
	///</summary>
	public partial class APS251MIResource : M3BaseResourceEndpoint
	{
		public APS251MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "APS251MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddInfoCat
		/// Description Add AP Information category.
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_JRNO">Journal number (Required)</param>
		/// <param name="m3_JSNO">Journal sequence number (Required)</param>
		/// <param name="m3_PEXN">AP information category (Required)</param>
		/// <param name="m3_PEXI">AP additional information (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_PEXS">AP information sequence number</param>
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
			int m3_PEXN, 
			string m3_PEXI, 
			string m3_DIVI = null, 
			int? m3_PEXS = null, 
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
			if (string.IsNullOrWhiteSpace(m3_PEXI))
				throw new ArgumentNullException("m3_PEXI");

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("JRNO", m3_JRNO.ToString())
				.WithQueryParameter("JSNO", m3_JSNO.ToString())
				.WithQueryParameter("PEXN", m3_PEXN.ToString())
				.WithQueryParameter("PEXI", m3_PEXI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_PEXS.HasValue)
				request.WithQueryParameter("PEXS", m3_PEXS.Value.ToString());

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
		/// Description Delete AP Information category.
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_JRNO">Journal number (Required)</param>
		/// <param name="m3_JSNO">Journal sequence number (Required)</param>
		/// <param name="m3_PEXN">AP information category (Required)</param>
		/// <param name="m3_PEXI">AP additional information (Required)</param>
		/// <param name="m3_PEXS">AP information sequence number (Required)</param>
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
			int m3_PEXN, 
			string m3_PEXI, 
			int m3_PEXS, 
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
			if (string.IsNullOrWhiteSpace(m3_PEXI))
				throw new ArgumentNullException("m3_PEXI");

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("JRNO", m3_JRNO.ToString())
				.WithQueryParameter("JSNO", m3_JSNO.ToString())
				.WithQueryParameter("PEXN", m3_PEXN.ToString())
				.WithQueryParameter("PEXI", m3_PEXI.Trim())
				.WithQueryParameter("PEXS", m3_PEXS.ToString());

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
		/// Name GetInfo
		/// Description Get additional information
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_JRNO">Journal number (Required)</param>
		/// <param name="m3_JSNO">Journal sequence number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_PEXN">AP information category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInfoResponse></returns>
		/// <exception cref="M3Exception<GetInfoResponse>"></exception>
		public async Task<M3Response<GetInfoResponse>> GetInfo(
			int m3_YEA4, 
			int m3_JRNO, 
			int m3_JSNO, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			int? m3_PEXN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetInfo",
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
			if (m3_PEXN.HasValue)
				request.WithQueryParameter("PEXN", m3_PEXN.Value.ToString());

			// Execute the request
			var result = await Execute<GetInfoResponse>(
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
		/// Name GetInvInfo
		/// Description Get additional information with invoice number
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_SPYN">Payee (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SINO">Supplier invoice number (Required)</param>
		/// <param name="m3_INYR">Invoice year (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_PEXN">AP information category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInvInfoResponse></returns>
		/// <exception cref="M3Exception<GetInvInfoResponse>"></exception>
		public async Task<M3Response<GetInvInfoResponse>> GetInvInfo(
			string m3_SPYN, 
			string m3_SUNO, 
			string m3_SINO, 
			int m3_INYR, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			int? m3_PEXN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetInvInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SPYN))
				throw new ArgumentNullException("m3_SPYN");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SINO))
				throw new ArgumentNullException("m3_SINO");

			// Set mandatory parameters
			request
				.WithQueryParameter("SPYN", m3_SPYN.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SINO", m3_SINO.Trim())
				.WithQueryParameter("INYR", m3_INYR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_PEXN.HasValue)
				request.WithQueryParameter("PEXN", m3_PEXN.Value.ToString());

			// Execute the request
			var result = await Execute<GetInvInfoResponse>(
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
		/// <param name="m3_PEXN">AP information category</param>
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
			int? m3_PEXN = null, 
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
			if (m3_PEXN.HasValue)
				request.WithQueryParameter("PEXN", m3_PEXN.Value.ToString());

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
		/// Name LstInvInfo
		/// Description Get additional information with invoice number
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_SPYN">Payee (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SINO">Supplier invoice number (Required)</param>
		/// <param name="m3_INYR">Invoice year (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_PEXN">AP information category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvInfoResponse></returns>
		/// <exception cref="M3Exception<LstInvInfoResponse>"></exception>
		public async Task<M3Response<LstInvInfoResponse>> LstInvInfo(
			string m3_SPYN, 
			string m3_SUNO, 
			string m3_SINO, 
			int m3_INYR, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			int? m3_PEXN = null, 
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
			if (string.IsNullOrWhiteSpace(m3_SPYN))
				throw new ArgumentNullException("m3_SPYN");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SINO))
				throw new ArgumentNullException("m3_SINO");

			// Set mandatory parameters
			request
				.WithQueryParameter("SPYN", m3_SPYN.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SINO", m3_SINO.Trim())
				.WithQueryParameter("INYR", m3_INYR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_PEXN.HasValue)
				request.WithQueryParameter("PEXN", m3_PEXN.Value.ToString());

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
