/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.QMS011MI;
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
	/// Name: QMS011MI
	/// Component Name: Laboratory code
	/// Description: Laboratory code interface
	/// Version Release: 5e90
	///</summary>
	public partial class QMS011MIResource : M3BaseResourceEndpoint
	{
		public QMS011MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QMS011MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddLabCode
		/// Description Add a laboratory code
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_LABO">Laboratory</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_ACTF">Active</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_EXLB">External Lab</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLabCode(
			string m3_LABO = null, 
			string m3_TX40 = null, 
			int? m3_ACTF = null, 
			string m3_SUNO = null, 
			int? m3_EXLB = null, 
			string m3_RESP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLabCode",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_LABO))
				request.WithQueryParameter("LABO", m3_LABO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (m3_ACTF.HasValue)
				request.WithQueryParameter("ACTF", m3_ACTF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_EXLB.HasValue)
				request.WithQueryParameter("EXLB", m3_EXLB.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());

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
		/// Name DltLabCode
		/// Description Delete a laboratory code
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_LABO">Laboratory</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltLabCode(
			string m3_LABO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltLabCode",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_LABO))
				request.WithQueryParameter("LABO", m3_LABO.Trim());

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
		/// Name GetLabCode
		/// Description Get data for a laboratory code
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_LABO">Laboratory</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLabCodeResponse></returns>
		/// <exception cref="M3Exception<GetLabCodeResponse>"></exception>
		public async Task<M3Response<GetLabCodeResponse>> GetLabCode(
			string m3_LABO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetLabCode",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_LABO))
				request.WithQueryParameter("LABO", m3_LABO.Trim());

			// Execute the request
			var result = await Execute<GetLabCodeResponse>(
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
		/// Name LstLabCodes
		/// Description List data for a laboratory codes
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_LABO">Laboratory</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLabCodesResponse></returns>
		/// <exception cref="M3Exception<LstLabCodesResponse>"></exception>
		public async Task<M3Response<LstLabCodesResponse>> LstLabCodes(
			string m3_LABO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLabCodes",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_LABO))
				request.WithQueryParameter("LABO", m3_LABO.Trim());

			// Execute the request
			var result = await Execute<LstLabCodesResponse>(
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
		/// Name UpdLabCode
		/// Description Update data for laboratory codes
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_LABO">Laboratory</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_ACTF">Active</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_EXLB">External Lab</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdLabCode(
			string m3_LABO = null, 
			string m3_TX40 = null, 
			int? m3_ACTF = null, 
			string m3_SUNO = null, 
			int? m3_EXLB = null, 
			string m3_RESP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdLabCode",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_LABO))
				request.WithQueryParameter("LABO", m3_LABO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (m3_ACTF.HasValue)
				request.WithQueryParameter("ACTF", m3_ACTF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_EXLB.HasValue)
				request.WithQueryParameter("EXLB", m3_EXLB.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());

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
