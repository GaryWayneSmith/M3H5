/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MWS422MI;
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
	/// Name: MWS422MI
	/// Component Name: Picking list
	/// Description: Picking list interface retrieval
	/// Version Release: 5ea1
	///</summary>
	public partial class MWS422MIResource : M3BaseResourceEndpoint
	{
		public MWS422MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MWS422MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetPickByRepNo
		/// Description Retrieve picking list by reporting number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLRN">Reporting number - pick line (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPickByRepNoResponse></returns>
		/// <exception cref="M3Exception<GetPickByRepNoResponse>"></exception>
		public async Task<M3Response<GetPickByRepNoResponse>> GetPickByRepNo(
			decimal m3_PLRN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPickByRepNo",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLRN", m3_PLRN.ToString());

			// Execute the request
			var result = await Execute<GetPickByRepNoResponse>(
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
		/// Name LstPickDetail
		/// Description Retrieve picking list detail
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DLIX">Delivery number (Required)</param>
		/// <param name="m3_PLSX">Picking list suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPickDetailResponse></returns>
		/// <exception cref="M3Exception<LstPickDetailResponse>"></exception>
		public async Task<M3Response<LstPickDetailResponse>> LstPickDetail(
			decimal m3_DLIX, 
			int? m3_PLSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPickDetail",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DLIX", m3_DLIX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3_PLSX.Value.ToString());

			// Execute the request
			var result = await Execute<LstPickDetailResponse>(
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
		/// Name LstWavePickDet
		/// Description Retrieve picking list detail by wave number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_PLRI">Wave number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstWavePickDetResponse></returns>
		/// <exception cref="M3Exception<LstWavePickDetResponse>"></exception>
		public async Task<M3Response<LstWavePickDetResponse>> LstWavePickDet(
			string m3_WHLO, 
			string m3_PLRI, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstWavePickDet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_PLRI))
				throw new ArgumentNullException("m3_PLRI");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("PLRI", m3_PLRI.Trim());

			// Execute the request
			var result = await Execute<LstWavePickDetResponse>(
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
		/// Name RtvLastLoc
		/// Description RtvLastLoc
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_PLSX">Picking list suffix</param>
		/// <param name="m3_RLPL">Retrieve last pack location</param>
		/// <param name="m3_RLDL">Retrieve last dock location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<RtvLastLocResponse></returns>
		/// <exception cref="M3Exception<RtvLastLocResponse>"></exception>
		public async Task<M3Response<RtvLastLocResponse>> RtvLastLoc(
			decimal? m3_DLIX = null, 
			int? m3_PLSX = null, 
			int? m3_RLPL = null, 
			int? m3_RLDL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RtvLastLoc",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (m3_PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3_PLSX.Value.ToString());
			if (m3_RLPL.HasValue)
				request.WithQueryParameter("RLPL", m3_RLPL.Value.ToString());
			if (m3_RLDL.HasValue)
				request.WithQueryParameter("RLDL", m3_RLDL.Value.ToString());

			// Execute the request
			var result = await Execute<RtvLastLocResponse>(
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
		/// Name SelPickDetail
		/// Description Select picking list detail
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_PLSX">Picking list suffix</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_PLRN">Reporting number - pick line</param>
		/// <param name="m3_ISTS">Incl status</param>
		/// <param name="m3_ISTH">Incl only if line sts = pick list sts</param>
		/// <param name="m3_IRPK">Incl only if remain to pack > 0</param>
		/// <param name="m3_CWV1">Calculate weight/volume to pick</param>
		/// <param name="m3_CWV2">Calculate weight/volume to pack</param>
		/// <param name="m3_TL40">To location status 40</param>
		/// <param name="m3_TL50">To location status 50</param>
		/// <param name="m3_TL60">To location status 60</param>
		/// <param name="m3_CONP">Consolidate package</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelPickDetailResponse></returns>
		/// <exception cref="M3Exception<SelPickDetailResponse>"></exception>
		public async Task<M3Response<SelPickDetailResponse>> SelPickDetail(
			decimal? m3_DLIX = null, 
			int? m3_PLSX = null, 
			string m3_PANR = null, 
			string m3_SSCC = null, 
			string m3_ITNO = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			decimal? m3_PLRN = null, 
			string m3_ISTS = null, 
			int? m3_ISTH = null, 
			int? m3_IRPK = null, 
			int? m3_CWV1 = null, 
			int? m3_CWV2 = null, 
			int? m3_TL40 = null, 
			int? m3_TL50 = null, 
			int? m3_TL60 = null, 
			int? m3_CONP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelPickDetail",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (m3_PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3_PLSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_PLRN.HasValue)
				request.WithQueryParameter("PLRN", m3_PLRN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ISTS))
				request.WithQueryParameter("ISTS", m3_ISTS.Trim());
			if (m3_ISTH.HasValue)
				request.WithQueryParameter("ISTH", m3_ISTH.Value.ToString());
			if (m3_IRPK.HasValue)
				request.WithQueryParameter("IRPK", m3_IRPK.Value.ToString());
			if (m3_CWV1.HasValue)
				request.WithQueryParameter("CWV1", m3_CWV1.Value.ToString());
			if (m3_CWV2.HasValue)
				request.WithQueryParameter("CWV2", m3_CWV2.Value.ToString());
			if (m3_TL40.HasValue)
				request.WithQueryParameter("TL40", m3_TL40.Value.ToString());
			if (m3_TL50.HasValue)
				request.WithQueryParameter("TL50", m3_TL50.Value.ToString());
			if (m3_TL60.HasValue)
				request.WithQueryParameter("TL60", m3_TL60.Value.ToString());
			if (m3_CONP.HasValue)
				request.WithQueryParameter("CONP", m3_CONP.Value.ToString());

			// Execute the request
			var result = await Execute<SelPickDetailResponse>(
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
