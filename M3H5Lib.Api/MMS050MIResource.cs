/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MMS050MI;
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
	/// Name: MMS050MI
	/// Component Name: Packaging interface
	/// Description: Packaging interface
	/// Version Release: 14.x
	///</summary>
	public partial class MMS050MIResource : M3BaseResourceEndpoint
	{
		public MMS050MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS050MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddPackaging
		/// Description Add new packaging
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_PANM">Name of packaging type</param>
		/// <param name="m3_WHLT">Location type</param>
		/// <param name="m3_WEIG">Weight capacity</param>
		/// <param name="m3_VOL3">Volume</param>
		/// <param name="m3_VOM3">Volume</param>
		/// <param name="m3_VOMT">Weight</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_PACK">Packaging type</param>
		/// <param name="m3_PACL">Packaging length</param>
		/// <param name="m3_PACW">Packaging width</param>
		/// <param name="m3_PACH">Packaging height</param>
		/// <param name="m3_NMFA">Normalization factor</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_FRCP">Capacity - free capacity unit</param>
		/// <param name="m3_RGDT">Not used!</param>
		/// <param name="m3_RGTM">Not used!</param>
		/// <param name="m3_LMDT">Not used!</param>
		/// <param name="m3_CHNO">Not used!</param>
		/// <param name="m3_CHID">Not used!</param>
		/// <param name="m3_PAGR">Packaging group</param>
		/// <param name="m3_MXFI">Max fill rate</param>
		/// <param name="m3_MIFI">Min fill rate</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPackaging(
			string m3_PACT = null, 
			string m3_PANM = null, 
			string m3_WHLT = null, 
			decimal? m3_WEIG = null, 
			decimal? m3_VOL3 = null, 
			decimal? m3_VOM3 = null, 
			decimal? m3_VOMT = null, 
			string m3_ITNO = null, 
			string m3_PACK = null, 
			int? m3_PACL = null, 
			int? m3_PACW = null, 
			int? m3_PACH = null, 
			int? m3_NMFA = null, 
			decimal? m3_TXID = null, 
			decimal? m3_FRCP = null, 
			DateTime? m3_RGDT = null, 
			int? m3_RGTM = null, 
			DateTime? m3_LMDT = null, 
			int? m3_CHNO = null, 
			string m3_CHID = null, 
			string m3_PAGR = null, 
			int? m3_MXFI = null, 
			int? m3_MIFI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPackaging",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PANM))
				request.WithQueryParameter("PANM", m3_PANM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLT))
				request.WithQueryParameter("WHLT", m3_WHLT.Trim());
			if (m3_WEIG.HasValue)
				request.WithQueryParameter("WEIG", m3_WEIG.Value.ToString());
			if (m3_VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3_VOL3.Value.ToString());
			if (m3_VOM3.HasValue)
				request.WithQueryParameter("VOM3", m3_VOM3.Value.ToString());
			if (m3_VOMT.HasValue)
				request.WithQueryParameter("VOMT", m3_VOMT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACK))
				request.WithQueryParameter("PACK", m3_PACK.Trim());
			if (m3_PACL.HasValue)
				request.WithQueryParameter("PACL", m3_PACL.Value.ToString());
			if (m3_PACW.HasValue)
				request.WithQueryParameter("PACW", m3_PACW.Value.ToString());
			if (m3_PACH.HasValue)
				request.WithQueryParameter("PACH", m3_PACH.Value.ToString());
			if (m3_NMFA.HasValue)
				request.WithQueryParameter("NMFA", m3_NMFA.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_FRCP.HasValue)
				request.WithQueryParameter("FRCP", m3_FRCP.Value.ToString());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3_RGTM.Value.ToString());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());
			if (m3_CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3_CHNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAGR))
				request.WithQueryParameter("PAGR", m3_PAGR.Trim());
			if (m3_MXFI.HasValue)
				request.WithQueryParameter("MXFI", m3_MXFI.Value.ToString());
			if (m3_MIFI.HasValue)
				request.WithQueryParameter("MIFI", m3_MIFI.Value.ToString());

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
		/// Name DelPackaging
		/// Description Delete specific packaging
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelPackaging(
			string m3_PACT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelPackaging",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());

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
		/// Name GetPackaging
		/// Description Retrieve specific packaging
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPackagingResponse></returns>
		/// <exception cref="M3Exception<GetPackagingResponse>"></exception>
		public async Task<M3Response<GetPackagingResponse>> GetPackaging(
			string m3_PACT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPackaging",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());

			// Execute the request
			var result = await Execute<GetPackagingResponse>(
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
		/// Name LstPackaging
		/// Description List packaging records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPackagingResponse></returns>
		/// <exception cref="M3Exception<LstPackagingResponse>"></exception>
		public async Task<M3Response<LstPackagingResponse>> LstPackaging(
			string m3_PACT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPackaging",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());

			// Execute the request
			var result = await Execute<LstPackagingResponse>(
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
		/// Name UpdPackaging
		/// Description Update an existing packaging
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_PANM">Name of packaging type</param>
		/// <param name="m3_WHLT">Location type</param>
		/// <param name="m3_WEIG">Weight capacity</param>
		/// <param name="m3_VOL3">Volume</param>
		/// <param name="m3_VOM3">Volume</param>
		/// <param name="m3_VOMT">Weight</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_PACK">Packaging type</param>
		/// <param name="m3_PACL">Packaging length</param>
		/// <param name="m3_PACW">Packaging width</param>
		/// <param name="m3_PACH">Packaging height</param>
		/// <param name="m3_NMFA">Normalization factor</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_FRCP">Capacity - free capacity unit</param>
		/// <param name="m3_RGDT">Not used!</param>
		/// <param name="m3_RGTM">Not used!</param>
		/// <param name="m3_LMDT">Not used!</param>
		/// <param name="m3_CHNO">Not used!</param>
		/// <param name="m3_PAGR">Packaging group</param>
		/// <param name="m3_MXFI">Max fill rate</param>
		/// <param name="m3_MIFI">Min fill rate</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPackaging(
			string m3_PACT = null, 
			string m3_PANM = null, 
			string m3_WHLT = null, 
			decimal? m3_WEIG = null, 
			decimal? m3_VOL3 = null, 
			decimal? m3_VOM3 = null, 
			decimal? m3_VOMT = null, 
			string m3_ITNO = null, 
			string m3_PACK = null, 
			int? m3_PACL = null, 
			int? m3_PACW = null, 
			int? m3_PACH = null, 
			int? m3_NMFA = null, 
			decimal? m3_TXID = null, 
			decimal? m3_FRCP = null, 
			DateTime? m3_RGDT = null, 
			int? m3_RGTM = null, 
			DateTime? m3_LMDT = null, 
			int? m3_CHNO = null, 
			string m3_PAGR = null, 
			int? m3_MXFI = null, 
			int? m3_MIFI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdPackaging",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PANM))
				request.WithQueryParameter("PANM", m3_PANM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLT))
				request.WithQueryParameter("WHLT", m3_WHLT.Trim());
			if (m3_WEIG.HasValue)
				request.WithQueryParameter("WEIG", m3_WEIG.Value.ToString());
			if (m3_VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3_VOL3.Value.ToString());
			if (m3_VOM3.HasValue)
				request.WithQueryParameter("VOM3", m3_VOM3.Value.ToString());
			if (m3_VOMT.HasValue)
				request.WithQueryParameter("VOMT", m3_VOMT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACK))
				request.WithQueryParameter("PACK", m3_PACK.Trim());
			if (m3_PACL.HasValue)
				request.WithQueryParameter("PACL", m3_PACL.Value.ToString());
			if (m3_PACW.HasValue)
				request.WithQueryParameter("PACW", m3_PACW.Value.ToString());
			if (m3_PACH.HasValue)
				request.WithQueryParameter("PACH", m3_PACH.Value.ToString());
			if (m3_NMFA.HasValue)
				request.WithQueryParameter("NMFA", m3_NMFA.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_FRCP.HasValue)
				request.WithQueryParameter("FRCP", m3_FRCP.Value.ToString());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3_RGTM.Value.ToString());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());
			if (m3_CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3_CHNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PAGR))
				request.WithQueryParameter("PAGR", m3_PAGR.Trim());
			if (m3_MXFI.HasValue)
				request.WithQueryParameter("MXFI", m3_MXFI.Value.ToString());
			if (m3_MIFI.HasValue)
				request.WithQueryParameter("MIFI", m3_MIFI.Value.ToString());

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
