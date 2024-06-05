/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.FCS350MI;
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
	/// Name: FCS350MI
	/// Component Name: Forecast
	/// Description: Api: Forecast
	/// Version Release: 14.x
	///</summary>
	public partial class FCS350MIResource : M3BaseResourceEndpoint
	{
		public FCS350MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "FCS350MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstForQty
		/// Description List Forecast quantity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_MDVR">Master demand schedule version</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_SULF">Summary level</param>
		/// <param name="m3_SWHG">Sum warehousegroup</param>
		/// <param name="m3_APIP">APS - policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstForQtyResponse></returns>
		/// <exception cref="M3Exception<LstForQtyResponse>"></exception>
		public async Task<M3Response<LstForQtyResponse>> LstForQty(
			string m3_WHLO = null, 
			string m3_WHGR = null, 
			string m3_ITNO = null, 
			string m3_MDVR = null, 
			DateTime? m3_FDAT = null, 
			DateTime? m3_TDAT = null, 
			int? m3_SULF = null, 
			int? m3_SWHG = null, 
			string m3_APIP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstForQty",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MDVR))
				request.WithQueryParameter("MDVR", m3_MDVR.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());
			if (m3_SULF.HasValue)
				request.WithQueryParameter("SULF", m3_SULF.Value.ToString());
			if (m3_SWHG.HasValue)
				request.WithQueryParameter("SWHG", m3_SWHG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());

			// Execute the request
			var result = await Execute<LstForQtyResponse>(
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
		/// Name UpdForQty
		/// Description Update Forecast quantity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_MDVR">Master demand schedule version</param>
		/// <param name="m3_FOQT">Forecast quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdForQty(
			string m3_WHLO = null, 
			string m3_ITNO = null, 
			DateTime? m3_FDAT = null, 
			DateTime? m3_TDAT = null, 
			string m3_MDVR = null, 
			decimal? m3_FOQT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdForQty",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_MDVR))
				request.WithQueryParameter("MDVR", m3_MDVR.Trim());
			if (m3_FOQT.HasValue)
				request.WithQueryParameter("FOQT", m3_FOQT.Value.ToString());

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
