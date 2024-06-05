/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CBS012MI;
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
	/// Name: CBS012MI
	/// Component Name: Equipment
	/// Description: Capacity connect to role
	/// Version Release: 5e90
	///</summary>
	public partial class CBS012MIResource : M3BaseResourceEndpoint
	{
		public CBS012MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CBS012MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add record
		/// Version Release: 15
		/// </summary>
		/// <param name="m3_ROLE">Role/organizational position (Required)</param>
		/// <param name="m3_CATY">Capability type (Required)</param>
		/// <param name="m3_CABI">Capability (Required)</param>
		/// <param name="m3_STAT">Status (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_ROLE, 
			string m3_CATY, 
			string m3_CABI, 
			string m3_STAT, 
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
			if (string.IsNullOrWhiteSpace(m3_ROLE))
				throw new ArgumentNullException("m3_ROLE");
			if (string.IsNullOrWhiteSpace(m3_CATY))
				throw new ArgumentNullException("m3_CATY");
			if (string.IsNullOrWhiteSpace(m3_CABI))
				throw new ArgumentNullException("m3_CABI");
			if (string.IsNullOrWhiteSpace(m3_STAT))
				throw new ArgumentNullException("m3_STAT");

			// Set mandatory parameters
			request
				.WithQueryParameter("ROLE", m3_ROLE.Trim())
				.WithQueryParameter("CATY", m3_CATY.Trim())
				.WithQueryParameter("CABI", m3_CABI.Trim())
				.WithQueryParameter("STAT", m3_STAT.Trim());

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
		/// Name Dlt
		/// Description Delete record
		/// Version Release: 15
		/// </summary>
		/// <param name="m3_ROLE">Role/organizational position (Required)</param>
		/// <param name="m3_CATY">Capability type (Required)</param>
		/// <param name="m3_CABI">Capability (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Dlt(
			string m3_ROLE, 
			string m3_CATY, 
			string m3_CABI, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Dlt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ROLE))
				throw new ArgumentNullException("m3_ROLE");
			if (string.IsNullOrWhiteSpace(m3_CATY))
				throw new ArgumentNullException("m3_CATY");
			if (string.IsNullOrWhiteSpace(m3_CABI))
				throw new ArgumentNullException("m3_CABI");

			// Set mandatory parameters
			request
				.WithQueryParameter("ROLE", m3_ROLE.Trim())
				.WithQueryParameter("CATY", m3_CATY.Trim())
				.WithQueryParameter("CABI", m3_CABI.Trim());

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
		/// Description Get record
		/// Version Release: 15
		/// </summary>
		/// <param name="m3_ROLE">Role/organizational position (Required)</param>
		/// <param name="m3_CATY">Capability type (Required)</param>
		/// <param name="m3_CABI">Capability (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_ROLE, 
			string m3_CATY, 
			string m3_CABI, 
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
			if (string.IsNullOrWhiteSpace(m3_ROLE))
				throw new ArgumentNullException("m3_ROLE");
			if (string.IsNullOrWhiteSpace(m3_CATY))
				throw new ArgumentNullException("m3_CATY");
			if (string.IsNullOrWhiteSpace(m3_CABI))
				throw new ArgumentNullException("m3_CABI");

			// Set mandatory parameters
			request
				.WithQueryParameter("ROLE", m3_ROLE.Trim())
				.WithQueryParameter("CATY", m3_CATY.Trim())
				.WithQueryParameter("CABI", m3_CABI.Trim());

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
		/// Name Lst
		/// Description List records
		/// Version Release: 15
		/// </summary>
		/// <param name="m3_ROLE">Role/organizational position (Required)</param>
		/// <param name="m3_CATY">Capability type (Required)</param>
		/// <param name="m3_CABI">Capability (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3_ROLE, 
			string m3_CATY, 
			string m3_CABI, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Lst",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ROLE))
				throw new ArgumentNullException("m3_ROLE");
			if (string.IsNullOrWhiteSpace(m3_CATY))
				throw new ArgumentNullException("m3_CATY");
			if (string.IsNullOrWhiteSpace(m3_CABI))
				throw new ArgumentNullException("m3_CABI");

			// Set mandatory parameters
			request
				.WithQueryParameter("ROLE", m3_ROLE.Trim())
				.WithQueryParameter("CATY", m3_CATY.Trim())
				.WithQueryParameter("CABI", m3_CABI.Trim());

			// Execute the request
			var result = await Execute<LstResponse>(
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
		/// Name Upd
		/// Description Update record
		/// Version Release: 15
		/// </summary>
		/// <param name="m3_ROLE">Role/organizational position (Required)</param>
		/// <param name="m3_CATY">Capability type (Required)</param>
		/// <param name="m3_CABI">Capability (Required)</param>
		/// <param name="m3_STAT">Status (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3_ROLE, 
			string m3_CATY, 
			string m3_CABI, 
			string m3_STAT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Upd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ROLE))
				throw new ArgumentNullException("m3_ROLE");
			if (string.IsNullOrWhiteSpace(m3_CATY))
				throw new ArgumentNullException("m3_CATY");
			if (string.IsNullOrWhiteSpace(m3_CABI))
				throw new ArgumentNullException("m3_CABI");
			if (string.IsNullOrWhiteSpace(m3_STAT))
				throw new ArgumentNullException("m3_STAT");

			// Set mandatory parameters
			request
				.WithQueryParameter("ROLE", m3_ROLE.Trim())
				.WithQueryParameter("CATY", m3_CATY.Trim())
				.WithQueryParameter("CABI", m3_CABI.Trim())
				.WithQueryParameter("STAT", m3_STAT.Trim());

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
