/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MNS410MI;
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
	/// Name: MNS410MI
	/// Component Name: Menu
	/// Description: Api: Roles per user
	/// Version Release: 5ea0
	///</summary>
	public partial class MNS410MIResource : M3BaseResourceEndpoint
	{
		public MNS410MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MNS410MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_USID">User (Required)</param>
		/// <param name="m3_ROLL">Role (Required)</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_VTDT">Valid to</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_USID, 
			string m3_ROLL, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_VTDT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");
			if (string.IsNullOrWhiteSpace(m3_ROLL))
				throw new ArgumentNullException("m3_ROLL");

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3_USID.Trim())
				.WithQueryParameter("ROLL", m3_ROLL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_VTDT.HasValue)
				request.WithQueryParameter("VTDT", m3_VTDT.Value.ToM3String());

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
		/// Description Dlt
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_USID">User (Required)</param>
		/// <param name="m3_ROLL">Role (Required)</param>
		/// <param name="m3_DLPR">WDLPR</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Dlt(
			string m3_USID, 
			string m3_ROLL, 
			string m3_DLPR = null, 
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
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");
			if (string.IsNullOrWhiteSpace(m3_ROLL))
				throw new ArgumentNullException("m3_ROLL");

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3_USID.Trim())
				.WithQueryParameter("ROLL", m3_ROLL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DLPR))
				request.WithQueryParameter("DLPR", m3_DLPR.Trim());

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
		/// Description Get
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_USID">User (Required)</param>
		/// <param name="m3_ROLL">Role (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_USID, 
			string m3_ROLL, 
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
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");
			if (string.IsNullOrWhiteSpace(m3_ROLL))
				throw new ArgumentNullException("m3_ROLL");

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3_USID.Trim())
				.WithQueryParameter("ROLL", m3_ROLL.Trim());

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
		/// Description Lst
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_USID">User (Required)</param>
		/// <param name="m3_ROLL">Role (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3_USID, 
			string m3_ROLL, 
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
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");
			if (string.IsNullOrWhiteSpace(m3_ROLL))
				throw new ArgumentNullException("m3_ROLL");

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3_USID.Trim())
				.WithQueryParameter("ROLL", m3_ROLL.Trim());

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
		/// Name LstRoles
		/// Description List roles by role id
		/// Version Release: 13
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRolesResponse></returns>
		/// <exception cref="M3Exception<LstRolesResponse>"></exception>
		public async Task<M3Response<LstRolesResponse>> LstRoles(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstRoles",
			};

			// Execute the request
			var result = await Execute<LstRolesResponse>(
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
		/// Name LstRolesByUser
		/// Description LstRolesByUser
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_USID">User (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRolesByUserResponse></returns>
		/// <exception cref="M3Exception<LstRolesByUserResponse>"></exception>
		public async Task<M3Response<LstRolesByUserResponse>> LstRolesByUser(
			string m3_USID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstRolesByUser",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3_USID.Trim());

			// Execute the request
			var result = await Execute<LstRolesByUserResponse>(
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
		/// Description Upd
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_USID">User (Required)</param>
		/// <param name="m3_ROLL">Role (Required)</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_VTDT">Valid to</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3_USID, 
			string m3_ROLL, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_VTDT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");
			if (string.IsNullOrWhiteSpace(m3_ROLL))
				throw new ArgumentNullException("m3_ROLL");

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3_USID.Trim())
				.WithQueryParameter("ROLL", m3_ROLL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_VTDT.HasValue)
				request.WithQueryParameter("VTDT", m3_VTDT.Value.ToM3String());

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
