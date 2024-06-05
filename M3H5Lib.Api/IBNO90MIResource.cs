/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.IBNO90MI;
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
	/// Name: IBNO90MI
	/// Component Name: EB-modulen
	/// Description: COUNTRY: Norw banking module
	/// Version Release: 12.4
	///</summary>
	public partial class IBNO90MIResource : M3BaseResourceEndpoint
	{
		public IBNO90MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "IBNO90MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ClrFile
		/// Description Clear file
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_XBET">Bank (Required)</param>
		/// <param name="m3_XFNM">File name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ClrFile(
			int m3_CONO, 
			string m3_DIVI, 
			string m3_XBET, 
			string m3_XFNM, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ClrFile",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_XBET))
				throw new ArgumentNullException("m3_XBET");
			if (string.IsNullOrWhiteSpace(m3_XFNM))
				throw new ArgumentNullException("m3_XFNM");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("XBET", m3_XBET.Trim())
				.WithQueryParameter("XFNM", m3_XFNM.Trim());

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
		/// Name ClrLockFlag
		/// Description Remove lock flag
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_XBET">Bank (Required)</param>
		/// <param name="m3_XFNM">File name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ClrLockFlag(
			int m3_CONO, 
			string m3_DIVI, 
			string m3_XBET, 
			string m3_XFNM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ClrLockFlag",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_XBET))
				throw new ArgumentNullException("m3_XBET");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("XBET", m3_XBET.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_XFNM))
				request.WithQueryParameter("XFNM", m3_XFNM.Trim());

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
		/// Name GetPath
		/// Description Get InputPath for Data from Bank
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_XBET">Bank (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPathResponse></returns>
		/// <exception cref="M3Exception<GetPathResponse>"></exception>
		public async Task<M3Response<GetPathResponse>> GetPath(
			int m3_CONO, 
			string m3_DIVI, 
			string m3_XBET, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPath",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_XBET))
				throw new ArgumentNullException("m3_XBET");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("XBET", m3_XBET.Trim());

			// Execute the request
			var result = await Execute<GetPathResponse>(
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
		/// Name PrintUpdate
		/// Description Print and update
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_XBET">Bank (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrintUpdate(
			int m3_CONO, 
			string m3_DIVI, 
			string m3_XBET, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrintUpdate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_XBET))
				throw new ArgumentNullException("m3_XBET");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("XBET", m3_XBET.Trim());

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
		/// Name Receive
		/// Description Receive data from PC
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_XBET">Bank (Required)</param>
		/// <param name="m3_DATA">Data (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Receive(
			int m3_CONO, 
			string m3_DIVI, 
			string m3_XBET, 
			string m3_DATA, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Receive",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_XBET))
				throw new ArgumentNullException("m3_XBET");
			if (string.IsNullOrWhiteSpace(m3_DATA))
				throw new ArgumentNullException("m3_DATA");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("XBET", m3_XBET.Trim())
				.WithQueryParameter("DATA", m3_DATA.Trim());

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
		/// Name Send
		/// Description Send data to PC
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_XBET">Bank (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SendResponse></returns>
		/// <exception cref="M3Exception<SendResponse>"></exception>
		public async Task<M3Response<SendResponse>> Send(
			int m3_CONO, 
			string m3_DIVI, 
			string m3_XBET, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Send",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_XBET))
				throw new ArgumentNullException("m3_XBET");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("XBET", m3_XBET.Trim());

			// Execute the request
			var result = await Execute<SendResponse>(
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
		/// Name SetLockFlag
		/// Description Set lock flag
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_XBET">Bank (Required)</param>
		/// <param name="m3_XFNM">File name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetLockFlag(
			int m3_CONO, 
			string m3_DIVI, 
			string m3_XBET, 
			string m3_XFNM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SetLockFlag",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_XBET))
				throw new ArgumentNullException("m3_XBET");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("XBET", m3_XBET.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_XFNM))
				request.WithQueryParameter("XFNM", m3_XFNM.Trim());

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
		/// Name Test
		/// Description Test connection
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Test(
			int m3_CONO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Test",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString());

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
