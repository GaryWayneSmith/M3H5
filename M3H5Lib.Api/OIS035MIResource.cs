/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.OIS035MI;
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
	/// Name: OIS035MI
	/// Component Name: TextBlocks
	/// Description: Document Text  interface
	/// Version Release: 5e90
	///</summary>
	public partial class OIS035MIResource : M3BaseResourceEndpoint
	{
		public OIS035MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS035MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddTxtDocument
		/// Description Add text Document
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TXCD">Text type (Required)</param>
		/// <param name="m3_TXKY">Text identity (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_TXDE">Text description (Required)</param>
		/// <param name="m3_ENDT">Finish date (Required)</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_TXDO">Print code</param>
		/// <param name="m3_TXPR">Text place</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddTxtDocument(
			int m3_TXCD, 
			string m3_TXKY, 
			DateTime m3_STDT, 
			string m3_TXDE, 
			DateTime m3_ENDT, 
			string m3_LNCD = null, 
			int? m3_TXDO = null, 
			int? m3_TXPR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddTxtDocument",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TXKY))
				throw new ArgumentNullException("m3_TXKY");
			if (string.IsNullOrWhiteSpace(m3_TXDE))
				throw new ArgumentNullException("m3_TXDE");

			// Set mandatory parameters
			request
				.WithQueryParameter("TXCD", m3_TXCD.ToString())
				.WithQueryParameter("TXKY", m3_TXKY.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("TXDE", m3_TXDE.Trim())
				.WithQueryParameter("ENDT", m3_ENDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (m3_TXDO.HasValue)
				request.WithQueryParameter("TXDO", m3_TXDO.Value.ToString());
			if (m3_TXPR.HasValue)
				request.WithQueryParameter("TXPR", m3_TXPR.Value.ToString());
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
		/// Name ChgTxtDocument
		/// Description Change text Document
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TXCD">Text type (Required)</param>
		/// <param name="m3_TXKY">Text identity (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_TXDE">Text description</param>
		/// <param name="m3_TXDO">Print code</param>
		/// <param name="m3_TXPR">Text place</param>
		/// <param name="m3_ENDT">Finish date</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgTxtDocument(
			int m3_TXCD, 
			string m3_TXKY, 
			DateTime m3_STDT, 
			string m3_LNCD = null, 
			string m3_TXDE = null, 
			int? m3_TXDO = null, 
			int? m3_TXPR = null, 
			DateTime? m3_ENDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgTxtDocument",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TXKY))
				throw new ArgumentNullException("m3_TXKY");

			// Set mandatory parameters
			request
				.WithQueryParameter("TXCD", m3_TXCD.ToString())
				.WithQueryParameter("TXKY", m3_TXKY.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXDE))
				request.WithQueryParameter("TXDE", m3_TXDE.Trim());
			if (m3_TXDO.HasValue)
				request.WithQueryParameter("TXDO", m3_TXDO.Value.ToString());
			if (m3_TXPR.HasValue)
				request.WithQueryParameter("TXPR", m3_TXPR.Value.ToString());
			if (m3_ENDT.HasValue)
				request.WithQueryParameter("ENDT", m3_ENDT.Value.ToM3String());
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
		/// Name DltTxtDocument
		/// Description Delete a text document
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TXCD">Text type (Required)</param>
		/// <param name="m3_TXKY">Text identity (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltTxtDocument(
			int m3_TXCD, 
			string m3_TXKY, 
			DateTime m3_STDT, 
			string m3_LNCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltTxtDocument",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TXKY))
				throw new ArgumentNullException("m3_TXKY");

			// Set mandatory parameters
			request
				.WithQueryParameter("TXCD", m3_TXCD.ToString())
				.WithQueryParameter("TXKY", m3_TXKY.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

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
		/// Name GetTxtDocument
		/// Description Get Text Documnent
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TXCD">Text type (Required)</param>
		/// <param name="m3_TXKY">Text identity (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTxtDocumentResponse></returns>
		/// <exception cref="M3Exception<GetTxtDocumentResponse>"></exception>
		public async Task<M3Response<GetTxtDocumentResponse>> GetTxtDocument(
			int m3_TXCD, 
			string m3_TXKY, 
			DateTime m3_STDT, 
			string m3_LNCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetTxtDocument",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TXKY))
				throw new ArgumentNullException("m3_TXKY");

			// Set mandatory parameters
			request
				.WithQueryParameter("TXCD", m3_TXCD.ToString())
				.WithQueryParameter("TXKY", m3_TXKY.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<GetTxtDocumentResponse>(
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
		/// Name LstTxtDocument
		/// Description LstTxtDocument
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_TXCD">Text type (Required)</param>
		/// <param name="m3_TXKY">Text identity (Required)</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTxtDocumentResponse></returns>
		/// <exception cref="M3Exception<LstTxtDocumentResponse>"></exception>
		public async Task<M3Response<LstTxtDocumentResponse>> LstTxtDocument(
			int m3_TXCD, 
			string m3_TXKY, 
			string m3_LNCD = null, 
			DateTime? m3_STDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTxtDocument",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TXKY))
				throw new ArgumentNullException("m3_TXKY");

			// Set mandatory parameters
			request
				.WithQueryParameter("TXCD", m3_TXCD.ToString())
				.WithQueryParameter("TXKY", m3_TXKY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstTxtDocumentResponse>(
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
