/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MMS018MI;
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
	/// Name: MMS018MI
	/// Component Name: ConnectCompositionToStyle
	/// Description: Connect composition to style Interface
	/// Version Release: 11.3
	///</summary>
	public partial class MMS018MIResource : M3BaseResourceEndpoint
	{
		public MMS018MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS018MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Create Connect composition to style
		/// Version Release: 11.3
		/// </summary>
		/// <param name="m3_STYN">Style number (Required)</param>
		/// <param name="m3_XCDE">Composition (Required)</param>
		/// <param name="m3_XCDS">Composition percentage (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_STYN, 
			string m3_XCDE, 
			int m3_XCDS, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STYN))
				throw new ArgumentNullException("m3_STYN");
			if (string.IsNullOrWhiteSpace(m3_XCDE))
				throw new ArgumentNullException("m3_XCDE");

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3_STYN.Trim())
				.WithQueryParameter("XCDE", m3_XCDE.Trim())
				.WithQueryParameter("XCDS", m3_XCDS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
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
		/// Name Copy
		/// Description Copy Connect composition to style
		/// Version Release: 11.3
		/// </summary>
		/// <param name="m3_STYN">Style number (Required)</param>
		/// <param name="m3_XCDE">Composition (Required)</param>
		/// <param name="m3_TCDE">Target Composition (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Copy(
			string m3_STYN, 
			string m3_XCDE, 
			string m3_TCDE, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Copy",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STYN))
				throw new ArgumentNullException("m3_STYN");
			if (string.IsNullOrWhiteSpace(m3_XCDE))
				throw new ArgumentNullException("m3_XCDE");
			if (string.IsNullOrWhiteSpace(m3_TCDE))
				throw new ArgumentNullException("m3_TCDE");

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3_STYN.Trim())
				.WithQueryParameter("XCDE", m3_XCDE.Trim())
				.WithQueryParameter("TCDE", m3_TCDE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name Delete
		/// Description Delete Connect composition to style
		/// Version Release: 11.3
		/// </summary>
		/// <param name="m3_STYN">Style number (Required)</param>
		/// <param name="m3_XCDE">Composition (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3_STYN, 
			string m3_XCDE, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Delete",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STYN))
				throw new ArgumentNullException("m3_STYN");
			if (string.IsNullOrWhiteSpace(m3_XCDE))
				throw new ArgumentNullException("m3_XCDE");

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3_STYN.Trim())
				.WithQueryParameter("XCDE", m3_XCDE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name Get
		/// Description Get Connect composition to style
		/// Version Release: 11.3
		/// </summary>
		/// <param name="m3_STYN">Style number (Required)</param>
		/// <param name="m3_XCDE">Composition (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_STYN, 
			string m3_XCDE, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STYN))
				throw new ArgumentNullException("m3_STYN");
			if (string.IsNullOrWhiteSpace(m3_XCDE))
				throw new ArgumentNullException("m3_XCDE");

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3_STYN.Trim())
				.WithQueryParameter("XCDE", m3_XCDE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name List
		/// Description List Connect composition to style
		/// Version Release: 11.3
		/// </summary>
		/// <param name="m3_STYN">Style number (Required)</param>
		/// <param name="m3_XCDE">Composition (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3_STYN, 
			string m3_XCDE, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/List",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STYN))
				throw new ArgumentNullException("m3_STYN");
			if (string.IsNullOrWhiteSpace(m3_XCDE))
				throw new ArgumentNullException("m3_XCDE");

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3_STYN.Trim())
				.WithQueryParameter("XCDE", m3_XCDE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<ListResponse>(
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
		/// Name Update
		/// Description Update Connect composition to style
		/// Version Release: 11.3
		/// </summary>
		/// <param name="m3_STYN">Style number (Required)</param>
		/// <param name="m3_XCDE">Composition (Required)</param>
		/// <param name="m3_XCDS">Composition percentage (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Update(
			string m3_STYN, 
			string m3_XCDE, 
			int m3_XCDS, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Update",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STYN))
				throw new ArgumentNullException("m3_STYN");
			if (string.IsNullOrWhiteSpace(m3_XCDE))
				throw new ArgumentNullException("m3_XCDE");

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3_STYN.Trim())
				.WithQueryParameter("XCDE", m3_XCDE.Trim())
				.WithQueryParameter("XCDS", m3_XCDS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
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
