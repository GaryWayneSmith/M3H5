/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CMS470MI;
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
	/// Name: CMS470MI
	/// Component Name: Custom fields
	/// Description: Custom fields
	/// Version Release: 5ea0
	///</summary>
	public partial class CMS470MIResource : M3BaseResourceEndpoint
	{
		public CMS470MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS470MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddCustomField
		/// Description Add custom field
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CFMF">Custom field (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_FLDM">Field type (Required)</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_CFML">Heading - custom field</param>
		/// <param name="m3_FLDB">Field length</param>
		/// <param name="m3_DCCD">Number of decimal places</param>
		/// <param name="m3_MES0">Meter</param>
		/// <param name="m3_FLCT">Field category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCustomField(
			string m3_CFMF, 
			string m3_TX40, 
			string m3_FLDM, 
			string m3_TX15 = null, 
			string m3_CFML = null, 
			int? m3_FLDB = null, 
			int? m3_DCCD = null, 
			string m3_MES0 = null, 
			int? m3_FLCT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCustomField",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CFMF))
				throw new ArgumentNullException("m3_CFMF");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");
			if (string.IsNullOrWhiteSpace(m3_FLDM))
				throw new ArgumentNullException("m3_FLDM");

			// Set mandatory parameters
			request
				.WithQueryParameter("CFMF", m3_CFMF.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim())
				.WithQueryParameter("FLDM", m3_FLDM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFML))
				request.WithQueryParameter("CFML", m3_CFML.Trim());
			if (m3_FLDB.HasValue)
				request.WithQueryParameter("FLDB", m3_FLDB.Value.ToString());
			if (m3_DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3_DCCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MES0))
				request.WithQueryParameter("MES0", m3_MES0.Trim());
			if (m3_FLCT.HasValue)
				request.WithQueryParameter("FLCT", m3_FLCT.Value.ToString());

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
		/// Name DltCustomField
		/// Description Delete custom field
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CFMF">Custom field (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltCustomField(
			string m3_CFMF, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltCustomField",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CFMF))
				throw new ArgumentNullException("m3_CFMF");

			// Set mandatory parameters
			request
				.WithQueryParameter("CFMF", m3_CFMF.Trim());

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
		/// Name GetCustomField
		/// Description Get custom field
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CFMF">Custom field (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCustomFieldResponse></returns>
		/// <exception cref="M3Exception<GetCustomFieldResponse>"></exception>
		public async Task<M3Response<GetCustomFieldResponse>> GetCustomField(
			string m3_CFMF, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetCustomField",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CFMF))
				throw new ArgumentNullException("m3_CFMF");

			// Set mandatory parameters
			request
				.WithQueryParameter("CFMF", m3_CFMF.Trim());

			// Execute the request
			var result = await Execute<GetCustomFieldResponse>(
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
		/// Name LstCustomField
		/// Description List custom field
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CFMF">Custom field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCustomFieldResponse></returns>
		/// <exception cref="M3Exception<LstCustomFieldResponse>"></exception>
		public async Task<M3Response<LstCustomFieldResponse>> LstCustomField(
			string m3_CFMF = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCustomField",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CFMF))
				request.WithQueryParameter("CFMF", m3_CFMF.Trim());

			// Execute the request
			var result = await Execute<LstCustomFieldResponse>(
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
		/// Name UpdCustomField
		/// Description Update custom field
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CFMF">Custom field (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_CFML">Heading - custom field</param>
		/// <param name="m3_FLDM">Field type</param>
		/// <param name="m3_FLDB">Field length</param>
		/// <param name="m3_DCCD">Number of decimal places</param>
		/// <param name="m3_MES0">Meter</param>
		/// <param name="m3_FLCT">Field category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdCustomField(
			string m3_CFMF, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_CFML = null, 
			string m3_FLDM = null, 
			int? m3_FLDB = null, 
			int? m3_DCCD = null, 
			string m3_MES0 = null, 
			int? m3_FLCT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdCustomField",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CFMF))
				throw new ArgumentNullException("m3_CFMF");

			// Set mandatory parameters
			request
				.WithQueryParameter("CFMF", m3_CFMF.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFML))
				request.WithQueryParameter("CFML", m3_CFML.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLDM))
				request.WithQueryParameter("FLDM", m3_FLDM.Trim());
			if (m3_FLDB.HasValue)
				request.WithQueryParameter("FLDB", m3_FLDB.Value.ToString());
			if (m3_DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3_DCCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MES0))
				request.WithQueryParameter("MES0", m3_MES0.Trim());
			if (m3_FLCT.HasValue)
				request.WithQueryParameter("FLCT", m3_FLCT.Value.ToString());

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
