/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddTxtDocument
		/// Description Add text Document
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TXCD">Text type (Required)</param>
		/// <param name="m3TXKY">Text identity (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3TXDE">Text description (Required)</param>
		/// <param name="m3ENDT">Finish date (Required)</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3TXDO">Print code</param>
		/// <param name="m3TXPR">Text place</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddTxtDocument(
			int m3TXCD, 
			string m3TXKY, 
			DateTime m3STDT, 
			string m3TXDE, 
			DateTime m3ENDT, 
			string m3LNCD = null, 
			int? m3TXDO = null, 
			int? m3TXPR = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddTxtDocument",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TXKY))
				throw new ArgumentNullException(nameof(m3TXKY));
			if (string.IsNullOrWhiteSpace(m3TXDE))
				throw new ArgumentNullException(nameof(m3TXDE));

			// Set mandatory parameters
			request
				.WithQueryParameter("TXCD", m3TXCD.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TXKY", m3TXKY.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String())
				.WithQueryParameter("TXDE", m3TXDE.Trim())
				.WithQueryParameter("ENDT", m3ENDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (m3TXDO.HasValue)
				request.WithQueryParameter("TXDO", m3TXDO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXPR.HasValue)
				request.WithQueryParameter("TXPR", m3TXPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgTxtDocument
		/// Description Change text Document
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TXCD">Text type (Required)</param>
		/// <param name="m3TXKY">Text identity (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3TXDE">Text description</param>
		/// <param name="m3TXDO">Print code</param>
		/// <param name="m3TXPR">Text place</param>
		/// <param name="m3ENDT">Finish date</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgTxtDocument(
			int m3TXCD, 
			string m3TXKY, 
			DateTime m3STDT, 
			string m3LNCD = null, 
			string m3TXDE = null, 
			int? m3TXDO = null, 
			int? m3TXPR = null, 
			DateTime? m3ENDT = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgTxtDocument",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TXKY))
				throw new ArgumentNullException(nameof(m3TXKY));

			// Set mandatory parameters
			request
				.WithQueryParameter("TXCD", m3TXCD.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TXKY", m3TXKY.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXDE))
				request.WithQueryParameter("TXDE", m3TXDE.Trim());
			if (m3TXDO.HasValue)
				request.WithQueryParameter("TXDO", m3TXDO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXPR.HasValue)
				request.WithQueryParameter("TXPR", m3TXPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ENDT.HasValue)
				request.WithQueryParameter("ENDT", m3ENDT.Value.ToM3String());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltTxtDocument
		/// Description Delete a text document
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TXCD">Text type (Required)</param>
		/// <param name="m3TXKY">Text identity (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltTxtDocument(
			int m3TXCD, 
			string m3TXKY, 
			DateTime m3STDT, 
			string m3LNCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltTxtDocument",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TXKY))
				throw new ArgumentNullException(nameof(m3TXKY));

			// Set mandatory parameters
			request
				.WithQueryParameter("TXCD", m3TXCD.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TXKY", m3TXKY.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

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
		/// Name GetTxtDocument
		/// Description Get Text Documnent
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TXCD">Text type (Required)</param>
		/// <param name="m3TXKY">Text identity (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTxtDocumentResponse></returns>
		/// <exception cref="M3Exception<GetTxtDocumentResponse>"></exception>
		public async Task<M3Response<GetTxtDocumentResponse>> GetTxtDocument(
			int m3TXCD, 
			string m3TXKY, 
			DateTime m3STDT, 
			string m3LNCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetTxtDocument",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TXKY))
				throw new ArgumentNullException(nameof(m3TXKY));

			// Set mandatory parameters
			request
				.WithQueryParameter("TXCD", m3TXCD.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TXKY", m3TXKY.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<GetTxtDocumentResponse>(
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
		/// Name LstTxtDocument
		/// Description LstTxtDocument
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3TXCD">Text type (Required)</param>
		/// <param name="m3TXKY">Text identity (Required)</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTxtDocumentResponse></returns>
		/// <exception cref="M3Exception<LstTxtDocumentResponse>"></exception>
		public async Task<M3Response<LstTxtDocumentResponse>> LstTxtDocument(
			int m3TXCD, 
			string m3TXKY, 
			string m3LNCD = null, 
			DateTime? m3STDT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstTxtDocument",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TXKY))
				throw new ArgumentNullException(nameof(m3TXKY));

			// Set mandatory parameters
			request
				.WithQueryParameter("TXCD", m3TXCD.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TXKY", m3TXKY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstTxtDocumentResponse>(
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
