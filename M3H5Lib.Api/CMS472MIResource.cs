/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CMS472MI;
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
	/// Name: CMS472MI
	/// Component Name: Custom fields
	/// Description: Custom fields
	/// Version Release: 5ea0
	///</summary>
	public partial class CMS472MIResource : M3BaseResourceEndpoint
	{
		public CMS472MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS472MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddCustPerGrp
		/// Description Add custom fields per group
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CFMG">Custom field group (Required)</param>
		/// <param name="m3_SQNR">Sequence number (Required)</param>
		/// <param name="m3_CFMF">Custom field (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCustPerGrp(
			string m3_CFMG, 
			int m3_SQNR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCustPerGrp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CFMG))
				throw new ArgumentNullException("m3_CFMG");
			if (string.IsNullOrWhiteSpace(m3_CFMF))
				throw new ArgumentNullException("m3_CFMF");

			// Set mandatory parameters
			request
				.WithQueryParameter("CFMG", m3_CFMG.Trim())
				.WithQueryParameter("SQNR", m3_SQNR.ToString())
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
		/// Name DltCustPerGrp
		/// Description Delete custom fields per group
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CFMG">Custom field group (Required)</param>
		/// <param name="m3_SQNR">Sequence number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltCustPerGrp(
			string m3_CFMG, 
			int m3_SQNR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltCustPerGrp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CFMG))
				throw new ArgumentNullException("m3_CFMG");

			// Set mandatory parameters
			request
				.WithQueryParameter("CFMG", m3_CFMG.Trim())
				.WithQueryParameter("SQNR", m3_SQNR.ToString());

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
		/// Name GetCustPerGrp
		/// Description Get custom fields per group
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CFMG">Custom field group (Required)</param>
		/// <param name="m3_SQNR">Sequence number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCustPerGrpResponse></returns>
		/// <exception cref="M3Exception<GetCustPerGrpResponse>"></exception>
		public async Task<M3Response<GetCustPerGrpResponse>> GetCustPerGrp(
			string m3_CFMG, 
			int m3_SQNR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetCustPerGrp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CFMG))
				throw new ArgumentNullException("m3_CFMG");

			// Set mandatory parameters
			request
				.WithQueryParameter("CFMG", m3_CFMG.Trim())
				.WithQueryParameter("SQNR", m3_SQNR.ToString());

			// Execute the request
			var result = await Execute<GetCustPerGrpResponse>(
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
		/// Name LstCustPerGrp
		/// Description List custom fields per group
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CFMG">Custom field group</param>
		/// <param name="m3_SQNR">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCustPerGrpResponse></returns>
		/// <exception cref="M3Exception<LstCustPerGrpResponse>"></exception>
		public async Task<M3Response<LstCustPerGrpResponse>> LstCustPerGrp(
			string m3_CFMG = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCustPerGrp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CFMG))
				request.WithQueryParameter("CFMG", m3_CFMG.Trim());
			if (m3_SQNR.HasValue)
				request.WithQueryParameter("SQNR", m3_SQNR.Value.ToString());

			// Execute the request
			var result = await Execute<LstCustPerGrpResponse>(
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
		/// Name UpdCustPerGrp
		/// Description Update custom fields per group
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CFMG">Custom field group (Required)</param>
		/// <param name="m3_SQNR">Sequence number (Required)</param>
		/// <param name="m3_CFMF">Custom field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdCustPerGrp(
			string m3_CFMG, 
			int m3_SQNR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdCustPerGrp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CFMG))
				throw new ArgumentNullException("m3_CFMG");

			// Set mandatory parameters
			request
				.WithQueryParameter("CFMG", m3_CFMG.Trim())
				.WithQueryParameter("SQNR", m3_SQNR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CFMF))
				request.WithQueryParameter("CFMF", m3_CFMF.Trim());

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
