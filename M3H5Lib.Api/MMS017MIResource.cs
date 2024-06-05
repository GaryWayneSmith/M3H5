/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MMS017MI;
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
	/// Name: MMS017MI
	/// Component Name: FeaturesStyle
	/// Description: Features - Style interface
	/// Version Release: 14.x
	///</summary>
	public partial class MMS017MIResource : M3BaseResourceEndpoint
	{
		public MMS017MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS017MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Create Features - Style
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_STYN">Style number (Required)</param>
		/// <param name="m3_SQNU">Sequence number for sorting (Required)</param>
		/// <param name="m3_FTID">Feature (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_STYN, 
			int m3_SQNU, 
			string m3_FTID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STYN))
				throw new ArgumentNullException("m3_STYN");
			if (string.IsNullOrWhiteSpace(m3_FTID))
				throw new ArgumentNullException("m3_FTID");

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3_STYN.Trim())
				.WithQueryParameter("SQNU", m3_SQNU.ToString())
				.WithQueryParameter("FTID", m3_FTID.Trim());

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
		/// Name Copy
		/// Description Copy Features - Style
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_STYN">Style number (Required)</param>
		/// <param name="m3_SQNU">Sequence number for sorting (Required)</param>
		/// <param name="m3_FTID">Feature (Required)</param>
		/// <param name="m3_TSQN">Target Sequence number (Required)</param>
		/// <param name="m3_TFID">Target Feature (Required)</param>
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
			int m3_SQNU, 
			string m3_FTID, 
			int m3_TSQN, 
			string m3_TFID, 
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
			if (string.IsNullOrWhiteSpace(m3_FTID))
				throw new ArgumentNullException("m3_FTID");
			if (string.IsNullOrWhiteSpace(m3_TFID))
				throw new ArgumentNullException("m3_TFID");

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3_STYN.Trim())
				.WithQueryParameter("SQNU", m3_SQNU.ToString())
				.WithQueryParameter("FTID", m3_FTID.Trim())
				.WithQueryParameter("TSQN", m3_TSQN.ToString())
				.WithQueryParameter("TFID", m3_TFID.Trim());

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
		/// Description Delete Features - Style
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_STYN">Style number (Required)</param>
		/// <param name="m3_SQNU">Sequence number for sorting (Required)</param>
		/// <param name="m3_FTID">Feature (Required)</param>
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
			int m3_SQNU, 
			string m3_FTID, 
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
			if (string.IsNullOrWhiteSpace(m3_FTID))
				throw new ArgumentNullException("m3_FTID");

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3_STYN.Trim())
				.WithQueryParameter("SQNU", m3_SQNU.ToString())
				.WithQueryParameter("FTID", m3_FTID.Trim());

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
		/// Description Get Features - Style
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_STYN">Style number (Required)</param>
		/// <param name="m3_SQNU">Sequence number for sorting (Required)</param>
		/// <param name="m3_FTID">Feature (Required)</param>
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
			int m3_SQNU, 
			string m3_FTID, 
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
			if (string.IsNullOrWhiteSpace(m3_FTID))
				throw new ArgumentNullException("m3_FTID");

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3_STYN.Trim())
				.WithQueryParameter("SQNU", m3_SQNU.ToString())
				.WithQueryParameter("FTID", m3_FTID.Trim());

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
		/// Description List Features - Style
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_STYN">Style number (Required)</param>
		/// <param name="m3_SQNU">Sequence number for sorting (Required)</param>
		/// <param name="m3_FTID">Feature (Required)</param>
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
			int m3_SQNU, 
			string m3_FTID, 
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
			if (string.IsNullOrWhiteSpace(m3_FTID))
				throw new ArgumentNullException("m3_FTID");

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3_STYN.Trim())
				.WithQueryParameter("SQNU", m3_SQNU.ToString())
				.WithQueryParameter("FTID", m3_FTID.Trim());

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
	}
}
// EOF
