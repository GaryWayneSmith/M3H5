/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3SUNO">Supplier (Required)</param>
		/// <param name="m3PUNO">Purchase order number (Required)</param>
		/// <param name="m3PNLI">Purchase order line (Required)</param>
		/// <param name="m3PNLS">Purchase order line subnumber (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSupLineResponse></returns>
		/// <exception cref="M3Exception<GetSupLineResponse>"></exception>
		public async Task<M3Response<GetSupLineResponse>> GetSupLine(
			string m3SUNO, 
			string m3PUNO, 
			int m3PNLI, 
			int m3PNLS, 
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
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("PUNO", m3PUNO.Trim())
				.WithQueryParameter("PNLI", m3PNLI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PNLS", m3PNLS.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetSupLineResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstSupAddresses
		/// Description List suppliers PO-adresses
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUNO">Supplier (Required)</param>
		/// <param name="m3POTC">Purchase order category</param>
		/// <param name="m3SLFR">From status</param>
		/// <param name="m3SLTO">To status</param>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSupAddressesResponse></returns>
		/// <exception cref="M3Exception<LstSupAddressesResponse>"></exception>
		public async Task<M3Response<LstSupAddressesResponse>> LstSupAddresses(
			string m3SUNO, 
			string m3POTC = null, 
			string m3SLFR = null, 
			string m3SLTO = null, 
			decimal? m3LMTS = null, 
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
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3POTC))
				request.WithQueryParameter("POTC", m3POTC.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLFR))
				request.WithQueryParameter("SLFR", m3SLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLTO))
				request.WithQueryParameter("SLTO", m3SLTO.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstSupAddressesResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstSupHead
		/// Description List Supplier PO-head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3POTC">Purchase order category</param>
		/// <param name="m3SLFR">From status</param>
		/// <param name="m3SLTO">To status</param>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSupHeadResponse></returns>
		/// <exception cref="M3Exception<LstSupHeadResponse>"></exception>
		public async Task<M3Response<LstSupHeadResponse>> LstSupHead(
			string m3SUNO = null, 
			string m3POTC = null, 
			string m3SLFR = null, 
			string m3SLTO = null, 
			decimal? m3LMTS = null, 
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
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3POTC))
				request.WithQueryParameter("POTC", m3POTC.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLFR))
				request.WithQueryParameter("SLFR", m3SLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLTO))
				request.WithQueryParameter("SLTO", m3SLTO.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstSupHeadResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstSupLine1
		/// Description List suppliers PO-lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUNO">Supplier (Required)</param>
		/// <param name="m3POTC">Purchase order category</param>
		/// <param name="m3SLFR">From status</param>
		/// <param name="m3SLTO">To status</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSupLine1Response></returns>
		/// <exception cref="M3Exception<LstSupLine1Response>"></exception>
		public async Task<M3Response<LstSupLine1Response>> LstSupLine1(
			string m3SUNO, 
			string m3POTC = null, 
			string m3SLFR = null, 
			string m3SLTO = null, 
			DateTime? m3FDAT = null, 
			DateTime? m3TDAT = null, 
			decimal? m3LMTS = null, 
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
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3POTC))
				request.WithQueryParameter("POTC", m3POTC.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLFR))
				request.WithQueryParameter("SLFR", m3SLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLTO))
				request.WithQueryParameter("SLTO", m3SLTO.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstSupLine1Response>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstSupLine2
		/// Description List suppliers PO-lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUNO">Supplier (Required)</param>
		/// <param name="m3POTC">Purchase order category</param>
		/// <param name="m3SLFR">From status</param>
		/// <param name="m3SLTO">To status</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSupLine2Response></returns>
		/// <exception cref="M3Exception<LstSupLine2Response>"></exception>
		public async Task<M3Response<LstSupLine2Response>> LstSupLine2(
			string m3SUNO, 
			string m3POTC = null, 
			string m3SLFR = null, 
			string m3SLTO = null, 
			DateTime? m3FDAT = null, 
			DateTime? m3TDAT = null, 
			decimal? m3LMTS = null, 
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
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3POTC))
				request.WithQueryParameter("POTC", m3POTC.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLFR))
				request.WithQueryParameter("SLFR", m3SLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLTO))
				request.WithQueryParameter("SLTO", m3SLTO.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstSupLine2Response>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}
	}
}
// EOF
