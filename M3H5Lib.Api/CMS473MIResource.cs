/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.CMS473MI;
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
	/// Name: CMS473MI
	/// Component Name: Custom fields
	/// Description: Custom fields
	/// Version Release: 5ea0
	///</summary>
	public partial class CMS473MIResource : M3BaseResourceEndpoint
	{
		public CMS473MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS473MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddConnection
		/// Description Add connections with custom field groups
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3SQNR">Sequence number (Required)</param>
		/// <param name="m3CFMG">Custom field group (Required)</param>
		/// <param name="m3CPGR">Composition group</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3SUCL">Supplier group</param>
		/// <param name="m3POCA">Position group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddConnection(
			int m3SQNR, 
			string m3CFMG, 
			string m3CPGR = null, 
			string m3ITGR = null, 
			string m3SUCL = null, 
			string m3POCA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddConnection",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CFMG))
				throw new ArgumentNullException(nameof(m3CFMG));

			// Set mandatory parameters
			request
				.WithQueryParameter("SQNR", m3SQNR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CFMG", m3CFMG.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CPGR))
				request.WithQueryParameter("CPGR", m3CPGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUCL))
				request.WithQueryParameter("SUCL", m3SUCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3POCA))
				request.WithQueryParameter("POCA", m3POCA.Trim());

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
		/// Name DltConnection
		/// Description Delete connections with custom field groups
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3SQNR">Sequence number (Required)</param>
		/// <param name="m3CPGR">Composition group</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3SUCL">Supplier group</param>
		/// <param name="m3POCA">Position group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltConnection(
			int m3SQNR, 
			string m3CPGR = null, 
			string m3ITGR = null, 
			string m3SUCL = null, 
			string m3POCA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltConnection",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("SQNR", m3SQNR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CPGR))
				request.WithQueryParameter("CPGR", m3CPGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUCL))
				request.WithQueryParameter("SUCL", m3SUCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3POCA))
				request.WithQueryParameter("POCA", m3POCA.Trim());

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
		/// Name GetConnection
		/// Description Get connections with custom field groups
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3SQNR">Sequence number (Required)</param>
		/// <param name="m3CPGR">Composition group</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3SUCL">Supplier group</param>
		/// <param name="m3POCA">Position group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetConnectionResponse></returns>
		/// <exception cref="M3Exception<GetConnectionResponse>"></exception>
		public async Task<M3Response<GetConnectionResponse>> GetConnection(
			int m3SQNR, 
			string m3CPGR = null, 
			string m3ITGR = null, 
			string m3SUCL = null, 
			string m3POCA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetConnection",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("SQNR", m3SQNR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CPGR))
				request.WithQueryParameter("CPGR", m3CPGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUCL))
				request.WithQueryParameter("SUCL", m3SUCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3POCA))
				request.WithQueryParameter("POCA", m3POCA.Trim());

			// Execute the request
			var result = await Execute<GetConnectionResponse>(
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
		/// Name LstConnection
		/// Description List connections with custom field groups
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CPGR">Composition group</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3SUCL">Supplier group</param>
		/// <param name="m3POCA">Position group</param>
		/// <param name="m3SQNR">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstConnectionResponse></returns>
		/// <exception cref="M3Exception<LstConnectionResponse>"></exception>
		public async Task<M3Response<LstConnectionResponse>> LstConnection(
			string m3CPGR = null, 
			string m3ITGR = null, 
			string m3SUCL = null, 
			string m3POCA = null, 
			int? m3SQNR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstConnection",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CPGR))
				request.WithQueryParameter("CPGR", m3CPGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUCL))
				request.WithQueryParameter("SUCL", m3SUCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3POCA))
				request.WithQueryParameter("POCA", m3POCA.Trim());
			if (m3SQNR.HasValue)
				request.WithQueryParameter("SQNR", m3SQNR.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstConnectionResponse>(
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
		/// Name UpdConnection
		/// Description Update connections with custom field groups
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3SQNR">Sequence number (Required)</param>
		/// <param name="m3CFMG">Custom field group (Required)</param>
		/// <param name="m3CPGR">Composition group</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3SUCL">Supplier group</param>
		/// <param name="m3POCA">Position group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdConnection(
			int m3SQNR, 
			string m3CFMG, 
			string m3CPGR = null, 
			string m3ITGR = null, 
			string m3SUCL = null, 
			string m3POCA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdConnection",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CFMG))
				throw new ArgumentNullException(nameof(m3CFMG));

			// Set mandatory parameters
			request
				.WithQueryParameter("SQNR", m3SQNR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CFMG", m3CFMG.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CPGR))
				request.WithQueryParameter("CPGR", m3CPGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUCL))
				request.WithQueryParameter("SUCL", m3SUCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3POCA))
				request.WithQueryParameter("POCA", m3POCA.Trim());

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
