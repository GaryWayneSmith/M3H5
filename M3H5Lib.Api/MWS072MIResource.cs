/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MWS072MI;
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
	/// Name: MWS072MI
	/// Component Name: Sublot transactions
	/// Description: Sublot transactions
	/// Version Release: 5ea1
	///</summary>
	public partial class MWS072MIResource : M3BaseResourceEndpoint
	{
		public MWS072MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MWS072MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetSublotTrans
		/// Description GetSublotTrans
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CRDT">Creation date (Required)</param>
		/// <param name="m3_CRTE">Creation time (Required)</param>
		/// <param name="m3_TMSX">Time suffix (Required)</param>
		/// <param name="m3_BANO">Lot number (Required)</param>
		/// <param name="m3_BANS">Sublot ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSublotTransResponse></returns>
		/// <exception cref="M3Exception<GetSublotTransResponse>"></exception>
		public async Task<M3Response<GetSublotTransResponse>> GetSublotTrans(
			string m3_WHLO, 
			string m3_ITNO, 
			DateTime m3_CRDT, 
			int m3_CRTE, 
			int m3_TMSX, 
			string m3_BANO, 
			int m3_BANS, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSublotTrans",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("CRDT", m3_CRDT.ToM3String())
				.WithQueryParameter("CRTE", m3_CRTE.ToString())
				.WithQueryParameter("TMSX", m3_TMSX.ToString())
				.WithQueryParameter("BANO", m3_BANO.Trim())
				.WithQueryParameter("BANS", m3_BANS.ToString());

			// Execute the request
			var result = await Execute<GetSublotTransResponse>(
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
		/// Name LstSelectByItem
		/// Description LstSelectByItem
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CRDT">Creation date (Required)</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CRTE">Creation time</param>
		/// <param name="m3_TMSX">Time suffix</param>
		/// <param name="m3_BANS">Sublot ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSelectByItemResponse></returns>
		/// <exception cref="M3Exception<LstSelectByItemResponse>"></exception>
		public async Task<M3Response<LstSelectByItemResponse>> LstSelectByItem(
			string m3_WHLO, 
			string m3_ITNO, 
			DateTime m3_CRDT, 
			string m3_BANO = null, 
			int? m3_CRTE = null, 
			int? m3_TMSX = null, 
			int? m3_BANS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSelectByItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("CRDT", m3_CRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_CRTE.HasValue)
				request.WithQueryParameter("CRTE", m3_CRTE.Value.ToString());
			if (m3_TMSX.HasValue)
				request.WithQueryParameter("TMSX", m3_TMSX.Value.ToString());
			if (m3_BANS.HasValue)
				request.WithQueryParameter("BANS", m3_BANS.Value.ToString());

			// Execute the request
			var result = await Execute<LstSelectByItemResponse>(
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
		/// Name LstSublotTrans
		/// Description LstSublotTrans
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSublotTransResponse></returns>
		/// <exception cref="M3Exception<LstSublotTransResponse>"></exception>
		public async Task<M3Response<LstSublotTransResponse>> LstSublotTrans(
			string m3_WHLO, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSublotTrans",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());

			// Execute the request
			var result = await Execute<LstSublotTransResponse>(
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
		/// Name LstTransByDate
		/// Description LstTransByDate
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CRDT">Creation date (Required)</param>
		/// <param name="m3_CRTE">Creation time</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_TTYP">Stock transaction type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTransByDateResponse></returns>
		/// <exception cref="M3Exception<LstTransByDateResponse>"></exception>
		public async Task<M3Response<LstTransByDateResponse>> LstTransByDate(
			string m3_WHLO, 
			DateTime m3_CRDT, 
			int? m3_CRTE = null, 
			string m3_ITNO = null, 
			int? m3_TTYP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTransByDate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("CRDT", m3_CRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CRTE.HasValue)
				request.WithQueryParameter("CRTE", m3_CRTE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_TTYP.HasValue)
				request.WithQueryParameter("TTYP", m3_TTYP.Value.ToString());

			// Execute the request
			var result = await Execute<LstTransByDateResponse>(
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
		/// Name LstTransByRef
		/// Description LstTransByRef
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line (Required)</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_RIDI">Delivery number</param>
		/// <param name="m3_TTYP">Stock transaction type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTransByRefResponse></returns>
		/// <exception cref="M3Exception<LstTransByRefResponse>"></exception>
		public async Task<M3Response<LstTransByRefResponse>> LstTransByRef(
			string m3_RIDN, 
			int m3_RIDL, 
			int? m3_RIDX = null, 
			decimal? m3_RIDI = null, 
			int? m3_TTYP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTransByRef",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");

			// Set mandatory parameters
			request
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("RIDL", m3_RIDL.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (m3_RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3_RIDI.Value.ToString());
			if (m3_TTYP.HasValue)
				request.WithQueryParameter("TTYP", m3_TTYP.Value.ToString());

			// Execute the request
			var result = await Execute<LstTransByRefResponse>(
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
