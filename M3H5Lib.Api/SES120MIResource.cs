/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.SES120MI;
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
	/// Name: SES120MI
	/// Component Name: FATAccess
	/// Description: Field Audit Trail Access
	/// Version Release: 14.1
	///</summary>
	public partial class SES120MIResource : M3BaseResourceEndpoint
	{
		public SES120MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "SES120MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name HasDeleted
		/// Description Is specific table set up and has deleted records
		/// Version Release: 14.2
		/// </summary>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<HasDeletedResponse></returns>
		/// <exception cref="M3Exception<HasDeletedResponse>"></exception>
		public async Task<M3Response<HasDeletedResponse>> HasDeleted(
			string m3_FILE, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/HasDeleted",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim());

			// Execute the request
			var result = await Execute<HasDeletedResponse>(
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
		/// Name LstAuditFields
		/// Description Returns a list of audited fields for a specific table
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAuditFieldsResponse></returns>
		/// <exception cref="M3Exception<LstAuditFieldsResponse>"></exception>
		public async Task<M3Response<LstAuditFieldsResponse>> LstAuditFields(
			string m3_FILE, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAuditFields",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim());

			// Execute the request
			var result = await Execute<LstAuditFieldsResponse>(
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
		/// Name LstDeleted
		/// Description List deleted records for table
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_LMTS">Timestamp (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDeletedResponse></returns>
		/// <exception cref="M3Exception<LstDeletedResponse>"></exception>
		public async Task<M3Response<LstDeletedResponse>> LstDeleted(
			string m3_FILE, 
			decimal m3_LMTS, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDeleted",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("LMTS", m3_LMTS.ToString());

			// Execute the request
			var result = await Execute<LstDeletedResponse>(
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
		/// Name LstFieldInfo
		/// Description Returns main index field info
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFieldInfoResponse></returns>
		/// <exception cref="M3Exception<LstFieldInfoResponse>"></exception>
		public async Task<M3Response<LstFieldInfoResponse>> LstFieldInfo(
			string m3_FILE, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFieldInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim());

			// Execute the request
			var result = await Execute<LstFieldInfoResponse>(
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
