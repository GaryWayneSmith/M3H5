/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.GLS840MI;
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
	/// Name: GLS840MI
	/// Component Name: GL interface
	/// Description: Generic GL interface
	/// Version Release: 15.x
	///</summary>
	public partial class GLS840MIResource : M3BaseResourceEndpoint
	{
		public GLS840MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "GLS840MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddBatchHead
		/// Description Add data to FGLINH
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_KEY1">Key value (Required)</param>
		/// <param name="m3_INTN">Interface (Required)</param>
		/// <param name="m3_DESC">Description (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_USID">User</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddBatchHeadResponse></returns>
		/// <exception cref="M3Exception<AddBatchHeadResponse>"></exception>
		public async Task<M3Response<AddBatchHeadResponse>> AddBatchHead(
			int m3_CONO, 
			string m3_KEY1, 
			string m3_INTN, 
			string m3_DESC, 
			string m3_DIVI = null, 
			string m3_USID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBatchHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_KEY1))
				throw new ArgumentNullException("m3_KEY1");
			if (string.IsNullOrWhiteSpace(m3_INTN))
				throw new ArgumentNullException("m3_INTN");
			if (string.IsNullOrWhiteSpace(m3_DESC))
				throw new ArgumentNullException("m3_DESC");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("KEY1", m3_KEY1.Trim())
				.WithQueryParameter("INTN", m3_INTN.Trim())
				.WithQueryParameter("DESC", m3_DESC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());

			// Execute the request
			var result = await Execute<AddBatchHeadResponse>(
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
		/// Name AddBatchLine
		/// Description Add data to FGLINL
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_KEY1">Key value (Required)</param>
		/// <param name="m3_LINE">Line number (Required)</param>
		/// <param name="m3_PARM">Parameter value (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddBatchLineResponse></returns>
		/// <exception cref="M3Exception<AddBatchLineResponse>"></exception>
		public async Task<M3Response<AddBatchLineResponse>> AddBatchLine(
			int m3_CONO, 
			string m3_KEY1, 
			int m3_LINE, 
			string m3_PARM, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBatchLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_KEY1))
				throw new ArgumentNullException("m3_KEY1");
			if (string.IsNullOrWhiteSpace(m3_PARM))
				throw new ArgumentNullException("m3_PARM");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("KEY1", m3_KEY1.Trim())
				.WithQueryParameter("LINE", m3_LINE.ToString())
				.WithQueryParameter("PARM", m3_PARM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<AddBatchLineResponse>(
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
		/// Name CtrlBatch
		/// Description Run option 6 from GLS840
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_KEY1">Key value (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CtrlBatchResponse></returns>
		/// <exception cref="M3Exception<CtrlBatchResponse>"></exception>
		public async Task<M3Response<CtrlBatchResponse>> CtrlBatch(
			int m3_CONO, 
			string m3_KEY1, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CtrlBatch",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_KEY1))
				throw new ArgumentNullException("m3_KEY1");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("KEY1", m3_KEY1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<CtrlBatchResponse>(
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
		/// Name UpdBatch
		/// Description Run option 9 from GLS840
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_KEY1">Key value (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<UpdBatchResponse></returns>
		/// <exception cref="M3Exception<UpdBatchResponse>"></exception>
		public async Task<M3Response<UpdBatchResponse>> UpdBatch(
			int m3_CONO, 
			string m3_KEY1, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdBatch",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_KEY1))
				throw new ArgumentNullException("m3_KEY1");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("KEY1", m3_KEY1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<UpdBatchResponse>(
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
