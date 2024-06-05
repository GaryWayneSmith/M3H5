/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.QUS113MI;
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
	/// Name: QUS113MI
	/// Component Name: Warranty
	/// Description: Api: Add Warranty
	/// Version Release: 14.x
	///</summary>
	public partial class QUS113MIResource : M3BaseResourceEndpoint
	{
		public QUS113MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QUS113MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddWarranty
		/// Description Add Warranty
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_WATP">Warranty type (Required)</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_EWST">Extended warranty start</param>
		/// <param name="m3_DERE">Default record</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddWarrantyResponse></returns>
		/// <exception cref="M3Exception<AddWarrantyResponse>"></exception>
		public async Task<M3Response<AddWarrantyResponse>> AddWarranty(
			string m3_PRNO, 
			string m3_WATP, 
			string m3_STAT = null, 
			string m3_RESP = null, 
			int? m3_EWST = null, 
			int? m3_DERE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddWarranty",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_WATP))
				throw new ArgumentNullException("m3_WATP");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("WATP", m3_WATP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_EWST.HasValue)
				request.WithQueryParameter("EWST", m3_EWST.Value.ToString());
			if (m3_DERE.HasValue)
				request.WithQueryParameter("DERE", m3_DERE.Value.ToString());

			// Execute the request
			var result = await Execute<AddWarrantyResponse>(
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
		/// Name ChgWarranty
		/// Description Change  Warranty
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_WATP">Warranty type (Required)</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_EWST">Extended warranty start</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ChgWarrantyResponse></returns>
		/// <exception cref="M3Exception<ChgWarrantyResponse>"></exception>
		public async Task<M3Response<ChgWarrantyResponse>> ChgWarranty(
			string m3_PRNO, 
			string m3_WATP, 
			string m3_STAT = null, 
			string m3_RESP = null, 
			int? m3_EWST = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgWarranty",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_WATP))
				throw new ArgumentNullException("m3_WATP");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("WATP", m3_WATP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_EWST.HasValue)
				request.WithQueryParameter("EWST", m3_EWST.Value.ToString());

			// Execute the request
			var result = await Execute<ChgWarrantyResponse>(
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
		/// Name DltWarranty
		/// Description Delete Warranty
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_WATP">Warranty type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DltWarrantyResponse></returns>
		/// <exception cref="M3Exception<DltWarrantyResponse>"></exception>
		public async Task<M3Response<DltWarrantyResponse>> DltWarranty(
			string m3_PRNO, 
			string m3_WATP, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltWarranty",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_WATP))
				throw new ArgumentNullException("m3_WATP");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("WATP", m3_WATP.Trim());

			// Execute the request
			var result = await Execute<DltWarrantyResponse>(
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
		/// Name GetWarranty
		/// Description Get  Warranty
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_WATP">Warranty type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetWarrantyResponse></returns>
		/// <exception cref="M3Exception<GetWarrantyResponse>"></exception>
		public async Task<M3Response<GetWarrantyResponse>> GetWarranty(
			string m3_PRNO, 
			string m3_WATP, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetWarranty",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_WATP))
				throw new ArgumentNullException("m3_WATP");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("WATP", m3_WATP.Trim());

			// Execute the request
			var result = await Execute<GetWarrantyResponse>(
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
		/// Name LstWarranty
		/// Description List Warranty
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_WATP">Warranty type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstWarrantyResponse></returns>
		/// <exception cref="M3Exception<LstWarrantyResponse>"></exception>
		public async Task<M3Response<LstWarrantyResponse>> LstWarranty(
			string m3_PRNO = null, 
			string m3_WATP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstWarranty",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WATP))
				request.WithQueryParameter("WATP", m3_WATP.Trim());

			// Execute the request
			var result = await Execute<LstWarrantyResponse>(
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
