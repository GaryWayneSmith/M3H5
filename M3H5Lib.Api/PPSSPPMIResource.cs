/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PPSSPPMI;
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
	/// Name: PPSSPPMI
	/// Component Name: SupplierPortal
	/// Description: Supplier Portal
	/// Version Release: 14.x
	///</summary>
	public partial class PPSSPPMIResource : M3BaseResourceEndpoint
	{
		public PPSSPPMIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PPSSPPMI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetSupLine
		/// Description Get supplies PO Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_PUNO">Purchase order number (Required)</param>
		/// <param name="m3_PNLI">Purchase order line (Required)</param>
		/// <param name="m3_PNLS">Purchase order line subnumber (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSupLineResponse></returns>
		/// <exception cref="M3Exception<GetSupLineResponse>"></exception>
		public async Task<M3Response<GetSupLineResponse>> GetSupLine(
			string m3_SUNO, 
			string m3_PUNO, 
			int m3_PNLI, 
			int m3_PNLS, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSupLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("PUNO", m3_PUNO.Trim())
				.WithQueryParameter("PNLI", m3_PNLI.ToString())
				.WithQueryParameter("PNLS", m3_PNLS.ToString());

			// Execute the request
			var result = await Execute<GetSupLineResponse>(
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
		/// Name LstSupAddresses
		/// Description List suppliers PO-adresses
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_POTC">Purchase order category</param>
		/// <param name="m3_SLFR">From status</param>
		/// <param name="m3_SLTO">To status</param>
		/// <param name="m3_LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSupAddressesResponse></returns>
		/// <exception cref="M3Exception<LstSupAddressesResponse>"></exception>
		public async Task<M3Response<LstSupAddressesResponse>> LstSupAddresses(
			string m3_SUNO, 
			string m3_POTC = null, 
			string m3_SLFR = null, 
			string m3_SLTO = null, 
			decimal? m3_LMTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSupAddresses",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_POTC))
				request.WithQueryParameter("POTC", m3_POTC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLFR))
				request.WithQueryParameter("SLFR", m3_SLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLTO))
				request.WithQueryParameter("SLTO", m3_SLTO.Trim());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstSupAddressesResponse>(
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
		/// Name LstSupHead
		/// Description List Supplier PO-head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_POTC">Purchase order category</param>
		/// <param name="m3_SLFR">From status</param>
		/// <param name="m3_SLTO">To status</param>
		/// <param name="m3_LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSupHeadResponse></returns>
		/// <exception cref="M3Exception<LstSupHeadResponse>"></exception>
		public async Task<M3Response<LstSupHeadResponse>> LstSupHead(
			string m3_SUNO = null, 
			string m3_POTC = null, 
			string m3_SLFR = null, 
			string m3_SLTO = null, 
			decimal? m3_LMTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSupHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POTC))
				request.WithQueryParameter("POTC", m3_POTC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLFR))
				request.WithQueryParameter("SLFR", m3_SLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLTO))
				request.WithQueryParameter("SLTO", m3_SLTO.Trim());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstSupHeadResponse>(
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
		/// Name LstSupLine1
		/// Description List suppliers PO-lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_POTC">Purchase order category</param>
		/// <param name="m3_SLFR">From status</param>
		/// <param name="m3_SLTO">To status</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSupLine1Response></returns>
		/// <exception cref="M3Exception<LstSupLine1Response>"></exception>
		public async Task<M3Response<LstSupLine1Response>> LstSupLine1(
			string m3_SUNO, 
			string m3_POTC = null, 
			string m3_SLFR = null, 
			string m3_SLTO = null, 
			DateTime? m3_FDAT = null, 
			DateTime? m3_TDAT = null, 
			decimal? m3_LMTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSupLine1",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_POTC))
				request.WithQueryParameter("POTC", m3_POTC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLFR))
				request.WithQueryParameter("SLFR", m3_SLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLTO))
				request.WithQueryParameter("SLTO", m3_SLTO.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstSupLine1Response>(
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
		/// Name LstSupLine2
		/// Description List suppliers PO-lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_POTC">Purchase order category</param>
		/// <param name="m3_SLFR">From status</param>
		/// <param name="m3_SLTO">To status</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSupLine2Response></returns>
		/// <exception cref="M3Exception<LstSupLine2Response>"></exception>
		public async Task<M3Response<LstSupLine2Response>> LstSupLine2(
			string m3_SUNO, 
			string m3_POTC = null, 
			string m3_SLFR = null, 
			string m3_SLTO = null, 
			DateTime? m3_FDAT = null, 
			DateTime? m3_TDAT = null, 
			decimal? m3_LMTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSupLine2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_POTC))
				request.WithQueryParameter("POTC", m3_POTC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLFR))
				request.WithQueryParameter("SLFR", m3_SLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLTO))
				request.WithQueryParameter("SLTO", m3_SLTO.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstSupLine2Response>(
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
