/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_SQNR">Sequence number (Required)</param>
		/// <param name="m3_CFMG">Custom field group (Required)</param>
		/// <param name="m3_CPGR">Composition group</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_SUCL">Supplier group</param>
		/// <param name="m3_POCA">Position group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddConnection(
			int m3_SQNR, 
			string m3_CFMG, 
			string m3_CPGR = null, 
			string m3_ITGR = null, 
			string m3_SUCL = null, 
			string m3_POCA = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CFMG))
				throw new ArgumentNullException("m3_CFMG");

			// Set mandatory parameters
			request
				.WithQueryParameter("SQNR", m3_SQNR.ToString())
				.WithQueryParameter("CFMG", m3_CFMG.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CPGR))
				request.WithQueryParameter("CPGR", m3_CPGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUCL))
				request.WithQueryParameter("SUCL", m3_SUCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POCA))
				request.WithQueryParameter("POCA", m3_POCA.Trim());

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
		/// Name DltConnection
		/// Description Delete connections with custom field groups
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_SQNR">Sequence number (Required)</param>
		/// <param name="m3_CPGR">Composition group</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_SUCL">Supplier group</param>
		/// <param name="m3_POCA">Position group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltConnection(
			int m3_SQNR, 
			string m3_CPGR = null, 
			string m3_ITGR = null, 
			string m3_SUCL = null, 
			string m3_POCA = null, 
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
				.WithQueryParameter("SQNR", m3_SQNR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CPGR))
				request.WithQueryParameter("CPGR", m3_CPGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUCL))
				request.WithQueryParameter("SUCL", m3_SUCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POCA))
				request.WithQueryParameter("POCA", m3_POCA.Trim());

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
		/// Name GetConnection
		/// Description Get connections with custom field groups
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_SQNR">Sequence number (Required)</param>
		/// <param name="m3_CPGR">Composition group</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_SUCL">Supplier group</param>
		/// <param name="m3_POCA">Position group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetConnectionResponse></returns>
		/// <exception cref="M3Exception<GetConnectionResponse>"></exception>
		public async Task<M3Response<GetConnectionResponse>> GetConnection(
			int m3_SQNR, 
			string m3_CPGR = null, 
			string m3_ITGR = null, 
			string m3_SUCL = null, 
			string m3_POCA = null, 
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
				.WithQueryParameter("SQNR", m3_SQNR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CPGR))
				request.WithQueryParameter("CPGR", m3_CPGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUCL))
				request.WithQueryParameter("SUCL", m3_SUCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POCA))
				request.WithQueryParameter("POCA", m3_POCA.Trim());

			// Execute the request
			var result = await Execute<GetConnectionResponse>(
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
		/// Name LstConnection
		/// Description List connections with custom field groups
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CPGR">Composition group</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_SUCL">Supplier group</param>
		/// <param name="m3_POCA">Position group</param>
		/// <param name="m3_SQNR">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstConnectionResponse></returns>
		/// <exception cref="M3Exception<LstConnectionResponse>"></exception>
		public async Task<M3Response<LstConnectionResponse>> LstConnection(
			string m3_CPGR = null, 
			string m3_ITGR = null, 
			string m3_SUCL = null, 
			string m3_POCA = null, 
			int? m3_SQNR = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_CPGR))
				request.WithQueryParameter("CPGR", m3_CPGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUCL))
				request.WithQueryParameter("SUCL", m3_SUCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POCA))
				request.WithQueryParameter("POCA", m3_POCA.Trim());
			if (m3_SQNR.HasValue)
				request.WithQueryParameter("SQNR", m3_SQNR.Value.ToString());

			// Execute the request
			var result = await Execute<LstConnectionResponse>(
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
		/// Name UpdConnection
		/// Description Update connections with custom field groups
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_SQNR">Sequence number (Required)</param>
		/// <param name="m3_CFMG">Custom field group (Required)</param>
		/// <param name="m3_CPGR">Composition group</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_SUCL">Supplier group</param>
		/// <param name="m3_POCA">Position group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdConnection(
			int m3_SQNR, 
			string m3_CFMG, 
			string m3_CPGR = null, 
			string m3_ITGR = null, 
			string m3_SUCL = null, 
			string m3_POCA = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CFMG))
				throw new ArgumentNullException("m3_CFMG");

			// Set mandatory parameters
			request
				.WithQueryParameter("SQNR", m3_SQNR.ToString())
				.WithQueryParameter("CFMG", m3_CFMG.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CPGR))
				request.WithQueryParameter("CPGR", m3_CPGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUCL))
				request.WithQueryParameter("SUCL", m3_SUCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POCA))
				request.WithQueryParameter("POCA", m3_POCA.Trim());

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
