/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddPackaging
		/// Description Add new packaging
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3PANM">Name of packaging type</param>
		/// <param name="m3WHLT">Location type</param>
		/// <param name="m3WEIG">Weight capacity</param>
		/// <param name="m3VOL3">Volume</param>
		/// <param name="m3VOM3">Volume</param>
		/// <param name="m3VOMT">Weight</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3PACK">Packaging type</param>
		/// <param name="m3PACL">Packaging length</param>
		/// <param name="m3PACW">Packaging width</param>
		/// <param name="m3PACH">Packaging height</param>
		/// <param name="m3NMFA">Normalization factor</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3FRCP">Capacity - free capacity unit</param>
		/// <param name="m3RGDT">Not used!</param>
		/// <param name="m3RGTM">Not used!</param>
		/// <param name="m3LMDT">Not used!</param>
		/// <param name="m3CHNO">Not used!</param>
		/// <param name="m3CHID">Not used!</param>
		/// <param name="m3PAGR">Packaging group</param>
		/// <param name="m3MXFI">Max fill rate</param>
		/// <param name="m3MIFI">Min fill rate</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPackaging(
			string m3PACT = null, 
			string m3PANM = null, 
			string m3WHLT = null, 
			decimal? m3WEIG = null, 
			decimal? m3VOL3 = null, 
			decimal? m3VOM3 = null, 
			decimal? m3VOMT = null, 
			string m3ITNO = null, 
			string m3PACK = null, 
			int? m3PACL = null, 
			int? m3PACW = null, 
			int? m3PACH = null, 
			int? m3NMFA = null, 
			decimal? m3TXID = null, 
			decimal? m3FRCP = null, 
			DateTime? m3RGDT = null, 
			int? m3RGTM = null, 
			DateTime? m3LMDT = null, 
			int? m3CHNO = null, 
			string m3CHID = null, 
			string m3PAGR = null, 
			int? m3MXFI = null, 
			int? m3MIFI = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddPackaging",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PANM))
				request.WithQueryParameter("PANM", m3PANM.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLT))
				request.WithQueryParameter("WHLT", m3WHLT.Trim());
			if (m3WEIG.HasValue)
				request.WithQueryParameter("WEIG", m3WEIG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3VOL3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOM3.HasValue)
				request.WithQueryParameter("VOM3", m3VOM3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOMT.HasValue)
				request.WithQueryParameter("VOMT", m3VOMT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACK))
				request.WithQueryParameter("PACK", m3PACK.Trim());
			if (m3PACL.HasValue)
				request.WithQueryParameter("PACL", m3PACL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PACW.HasValue)
				request.WithQueryParameter("PACW", m3PACW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PACH.HasValue)
				request.WithQueryParameter("PACH", m3PACH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NMFA.HasValue)
				request.WithQueryParameter("NMFA", m3NMFA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRCP.HasValue)
				request.WithQueryParameter("FRCP", m3FRCP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3RGTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());
			if (m3CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3CHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAGR))
				request.WithQueryParameter("PAGR", m3PAGR.Trim());
			if (m3MXFI.HasValue)
				request.WithQueryParameter("MXFI", m3MXFI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MIFI.HasValue)
				request.WithQueryParameter("MIFI", m3MIFI.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<M3Record>(
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
		/// Name DelPackaging
		/// Description Delete specific packaging
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelPackaging(
			string m3PACT = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelPackaging",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
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
		/// Name GetPackaging
		/// Description Retrieve specific packaging
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPackagingResponse></returns>
		/// <exception cref="M3Exception<GetPackagingResponse>"></exception>
		public async Task<M3Response<GetPackagingResponse>> GetPackaging(
			string m3PACT = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetPackaging",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());

			// Execute the request
			var result = await Execute<GetPackagingResponse>(
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
		/// Name LstPackaging
		/// Description List packaging records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPackagingResponse></returns>
		/// <exception cref="M3Exception<LstPackagingResponse>"></exception>
		public async Task<M3Response<LstPackagingResponse>> LstPackaging(
			string m3PACT = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPackaging",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());

			// Execute the request
			var result = await Execute<LstPackagingResponse>(
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
		/// Name UpdPackaging
		/// Description Update an existing packaging
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3PANM">Name of packaging type</param>
		/// <param name="m3WHLT">Location type</param>
		/// <param name="m3WEIG">Weight capacity</param>
		/// <param name="m3VOL3">Volume</param>
		/// <param name="m3VOM3">Volume</param>
		/// <param name="m3VOMT">Weight</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3PACK">Packaging type</param>
		/// <param name="m3PACL">Packaging length</param>
		/// <param name="m3PACW">Packaging width</param>
		/// <param name="m3PACH">Packaging height</param>
		/// <param name="m3NMFA">Normalization factor</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3FRCP">Capacity - free capacity unit</param>
		/// <param name="m3RGDT">Not used!</param>
		/// <param name="m3RGTM">Not used!</param>
		/// <param name="m3LMDT">Not used!</param>
		/// <param name="m3CHNO">Not used!</param>
		/// <param name="m3PAGR">Packaging group</param>
		/// <param name="m3MXFI">Max fill rate</param>
		/// <param name="m3MIFI">Min fill rate</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPackaging(
			string m3PACT = null, 
			string m3PANM = null, 
			string m3WHLT = null, 
			decimal? m3WEIG = null, 
			decimal? m3VOL3 = null, 
			decimal? m3VOM3 = null, 
			decimal? m3VOMT = null, 
			string m3ITNO = null, 
			string m3PACK = null, 
			int? m3PACL = null, 
			int? m3PACW = null, 
			int? m3PACH = null, 
			int? m3NMFA = null, 
			decimal? m3TXID = null, 
			decimal? m3FRCP = null, 
			DateTime? m3RGDT = null, 
			int? m3RGTM = null, 
			DateTime? m3LMDT = null, 
			int? m3CHNO = null, 
			string m3PAGR = null, 
			int? m3MXFI = null, 
			int? m3MIFI = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdPackaging",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PANM))
				request.WithQueryParameter("PANM", m3PANM.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLT))
				request.WithQueryParameter("WHLT", m3WHLT.Trim());
			if (m3WEIG.HasValue)
				request.WithQueryParameter("WEIG", m3WEIG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3VOL3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOM3.HasValue)
				request.WithQueryParameter("VOM3", m3VOM3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOMT.HasValue)
				request.WithQueryParameter("VOMT", m3VOMT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACK))
				request.WithQueryParameter("PACK", m3PACK.Trim());
			if (m3PACL.HasValue)
				request.WithQueryParameter("PACL", m3PACL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PACW.HasValue)
				request.WithQueryParameter("PACW", m3PACW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PACH.HasValue)
				request.WithQueryParameter("PACH", m3PACH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NMFA.HasValue)
				request.WithQueryParameter("NMFA", m3NMFA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRCP.HasValue)
				request.WithQueryParameter("FRCP", m3FRCP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3RGTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());
			if (m3CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3CHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PAGR))
				request.WithQueryParameter("PAGR", m3PAGR.Trim());
			if (m3MXFI.HasValue)
				request.WithQueryParameter("MXFI", m3MXFI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MIFI.HasValue)
				request.WithQueryParameter("MIFI", m3MIFI.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<M3Record>(
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
