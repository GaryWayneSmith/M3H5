/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3PLRN">Reporting number - pick line (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPickByRepNoResponse></returns>
		/// <exception cref="M3Exception<GetPickByRepNoResponse>"></exception>
		public async Task<M3Response<GetPickByRepNoResponse>> GetPickByRepNo(
			decimal m3PLRN, 
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
				.WithQueryParameter("PLRN", m3PLRN.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetPickByRepNoResponse>(
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
		/// Name LstPickDetail
		/// Description Retrieve picking list detail
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3PLSX">Picking list suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPickDetailResponse></returns>
		/// <exception cref="M3Exception<LstPickDetailResponse>"></exception>
		public async Task<M3Response<LstPickDetailResponse>> LstPickDetail(
			decimal m3DLIX, 
			int? m3PLSX = null, 
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
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3PLSX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPickDetailResponse>(
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
		/// Name LstWavePickDet
		/// Description Retrieve picking list detail by wave number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3PLRI">Wave number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstWavePickDetResponse></returns>
		/// <exception cref="M3Exception<LstWavePickDetResponse>"></exception>
		public async Task<M3Response<LstWavePickDetResponse>> LstWavePickDet(
			string m3WHLO, 
			string m3PLRI, 
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
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3PLRI))
				throw new ArgumentNullException(nameof(m3PLRI));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("PLRI", m3PLRI.Trim());

			// Execute the request
			var result = await Execute<LstWavePickDetResponse>(
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
		/// Name RtvLastLoc
		/// Description RtvLastLoc
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="m3PLSX">Picking list suffix</param>
		/// <param name="m3RLPL">Retrieve last pack location</param>
		/// <param name="m3RLDL">Retrieve last dock location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<RtvLastLocResponse></returns>
		/// <exception cref="M3Exception<RtvLastLocResponse>"></exception>
		public async Task<M3Response<RtvLastLocResponse>> RtvLastLoc(
			decimal? m3DLIX = null, 
			int? m3PLSX = null, 
			int? m3RLPL = null, 
			int? m3RLDL = null, 
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
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3PLSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RLPL.HasValue)
				request.WithQueryParameter("RLPL", m3RLPL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RLDL.HasValue)
				request.WithQueryParameter("RLDL", m3RLDL.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<RtvLastLocResponse>(
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
		/// Name SelPickDetail
		/// Description Select picking list detail
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="m3PLSX">Picking list suffix</param>
		/// <param name="m3PANR">Package number</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3PLRN">Reporting number - pick line</param>
		/// <param name="m3ISTS">Incl status</param>
		/// <param name="m3ISTH">Incl only if line sts = pick list sts</param>
		/// <param name="m3IRPK">Incl only if remain to pack > 0</param>
		/// <param name="m3CWV1">Calculate weight/volume to pick</param>
		/// <param name="m3CWV2">Calculate weight/volume to pack</param>
		/// <param name="m3TL40">To location status 40</param>
		/// <param name="m3TL50">To location status 50</param>
		/// <param name="m3TL60">To location status 60</param>
		/// <param name="m3CONP">Consolidate package</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelPickDetailResponse></returns>
		/// <exception cref="M3Exception<SelPickDetailResponse>"></exception>
		public async Task<M3Response<SelPickDetailResponse>> SelPickDetail(
			decimal? m3DLIX = null, 
			int? m3PLSX = null, 
			string m3PANR = null, 
			string m3SSCC = null, 
			string m3ITNO = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			decimal? m3PLRN = null, 
			string m3ISTS = null, 
			int? m3ISTH = null, 
			int? m3IRPK = null, 
			int? m3CWV1 = null, 
			int? m3CWV2 = null, 
			int? m3TL40 = null, 
			int? m3TL50 = null, 
			int? m3TL60 = null, 
			int? m3CONP = null, 
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
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3PLSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PANR))
				request.WithQueryParameter("PANR", m3PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3PLRN.HasValue)
				request.WithQueryParameter("PLRN", m3PLRN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ISTS))
				request.WithQueryParameter("ISTS", m3ISTS.Trim());
			if (m3ISTH.HasValue)
				request.WithQueryParameter("ISTH", m3ISTH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IRPK.HasValue)
				request.WithQueryParameter("IRPK", m3IRPK.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CWV1.HasValue)
				request.WithQueryParameter("CWV1", m3CWV1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CWV2.HasValue)
				request.WithQueryParameter("CWV2", m3CWV2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TL40.HasValue)
				request.WithQueryParameter("TL40", m3TL40.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TL50.HasValue)
				request.WithQueryParameter("TL50", m3TL50.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TL60.HasValue)
				request.WithQueryParameter("TL60", m3TL60.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CONP.HasValue)
				request.WithQueryParameter("CONP", m3CONP.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelPickDetailResponse>(
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
