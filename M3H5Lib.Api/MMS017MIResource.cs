/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Create Features - Style
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3STYN">Style number (Required)</param>
		/// <param name="m3SQNU">Sequence number for sorting (Required)</param>
		/// <param name="m3FTID">Feature (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3STYN, 
			int m3SQNU, 
			string m3FTID, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STYN))
				throw new ArgumentNullException(nameof(m3STYN));
			if (string.IsNullOrWhiteSpace(m3FTID))
				throw new ArgumentNullException(nameof(m3FTID));

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3STYN.Trim())
				.WithQueryParameter("SQNU", m3SQNU.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FTID", m3FTID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Copy
		/// Description Copy Features - Style
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3STYN">Style number (Required)</param>
		/// <param name="m3SQNU">Sequence number for sorting (Required)</param>
		/// <param name="m3FTID">Feature (Required)</param>
		/// <param name="m3TSQN">Target Sequence number (Required)</param>
		/// <param name="m3TFID">Target Feature (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Copy(
			string m3STYN, 
			int m3SQNU, 
			string m3FTID, 
			int m3TSQN, 
			string m3TFID, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Copy",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STYN))
				throw new ArgumentNullException(nameof(m3STYN));
			if (string.IsNullOrWhiteSpace(m3FTID))
				throw new ArgumentNullException(nameof(m3FTID));
			if (string.IsNullOrWhiteSpace(m3TFID))
				throw new ArgumentNullException(nameof(m3TFID));

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3STYN.Trim())
				.WithQueryParameter("SQNU", m3SQNU.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FTID", m3FTID.Trim())
				.WithQueryParameter("TSQN", m3TSQN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TFID", m3TFID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Delete
		/// Description Delete Features - Style
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3STYN">Style number (Required)</param>
		/// <param name="m3SQNU">Sequence number for sorting (Required)</param>
		/// <param name="m3FTID">Feature (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3STYN, 
			int m3SQNU, 
			string m3FTID, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Delete",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STYN))
				throw new ArgumentNullException(nameof(m3STYN));
			if (string.IsNullOrWhiteSpace(m3FTID))
				throw new ArgumentNullException(nameof(m3FTID));

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3STYN.Trim())
				.WithQueryParameter("SQNU", m3SQNU.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FTID", m3FTID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Get
		/// Description Get Features - Style
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3STYN">Style number (Required)</param>
		/// <param name="m3SQNU">Sequence number for sorting (Required)</param>
		/// <param name="m3FTID">Feature (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3STYN, 
			int m3SQNU, 
			string m3FTID, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STYN))
				throw new ArgumentNullException(nameof(m3STYN));
			if (string.IsNullOrWhiteSpace(m3FTID))
				throw new ArgumentNullException(nameof(m3FTID));

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3STYN.Trim())
				.WithQueryParameter("SQNU", m3SQNU.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FTID", m3FTID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name List
		/// Description List Features - Style
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3STYN">Style number (Required)</param>
		/// <param name="m3SQNU">Sequence number for sorting (Required)</param>
		/// <param name="m3FTID">Feature (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3STYN, 
			int m3SQNU, 
			string m3FTID, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/List",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STYN))
				throw new ArgumentNullException(nameof(m3STYN));
			if (string.IsNullOrWhiteSpace(m3FTID))
				throw new ArgumentNullException(nameof(m3FTID));

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3STYN.Trim())
				.WithQueryParameter("SQNU", m3SQNU.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FTID", m3FTID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ListResponse>(
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
