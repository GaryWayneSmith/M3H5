/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.DRS045MI;
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
	/// Name: DRS045MI
	/// Component Name: SCE
	/// Description: Time zone
	/// Version Release: 5ea1
	///</summary>
	public partial class DRS045MIResource : M3BaseResourceEndpoint
	{
		public DRS045MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "DRS045MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ConvertByRef
		/// Description Convert by Reference
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_FRTM">From time (Required)</param>
		/// <param name="m3_FRTB">From reference (Required)</param>
		/// <param name="m3_FRIA">From ID (Required)</param>
		/// <param name="m3_TOTB">To reference (Required)</param>
		/// <param name="m3_TOIA">To ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ConvertByRefResponse></returns>
		/// <exception cref="M3Exception<ConvertByRefResponse>"></exception>
		public async Task<M3Response<ConvertByRefResponse>> ConvertByRef(
			DateTime m3_FRDT, 
			string m3_FRTM, 
			string m3_FRTB, 
			string m3_FRIA, 
			string m3_TOTB, 
			string m3_TOIA, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ConvertByRef",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FRTM))
				throw new ArgumentNullException("m3_FRTM");
			if (string.IsNullOrWhiteSpace(m3_FRTB))
				throw new ArgumentNullException("m3_FRTB");
			if (string.IsNullOrWhiteSpace(m3_FRIA))
				throw new ArgumentNullException("m3_FRIA");
			if (string.IsNullOrWhiteSpace(m3_TOTB))
				throw new ArgumentNullException("m3_TOTB");
			if (string.IsNullOrWhiteSpace(m3_TOIA))
				throw new ArgumentNullException("m3_TOIA");

			// Set mandatory parameters
			request
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String())
				.WithQueryParameter("FRTM", m3_FRTM.Trim())
				.WithQueryParameter("FRTB", m3_FRTB.Trim())
				.WithQueryParameter("FRIA", m3_FRIA.Trim())
				.WithQueryParameter("TOTB", m3_TOTB.Trim())
				.WithQueryParameter("TOIA", m3_TOIA.Trim());

			// Execute the request
			var result = await Execute<ConvertByRefResponse>(
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
		/// Name ConvertByTIZO
		/// Description Convert by time zone
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_FRTM">From time (Required)</param>
		/// <param name="m3_FRTZ">From time zone</param>
		/// <param name="m3_TOTZ">To time zone</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ConvertByTIZOResponse></returns>
		/// <exception cref="M3Exception<ConvertByTIZOResponse>"></exception>
		public async Task<M3Response<ConvertByTIZOResponse>> ConvertByTIZO(
			DateTime m3_FRDT, 
			string m3_FRTM, 
			string m3_FRTZ = null, 
			string m3_TOTZ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ConvertByTIZO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FRTM))
				throw new ArgumentNullException("m3_FRTM");

			// Set mandatory parameters
			request
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String())
				.WithQueryParameter("FRTM", m3_FRTM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FRTZ))
				request.WithQueryParameter("FRTZ", m3_FRTZ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOTZ))
				request.WithQueryParameter("TOTZ", m3_TOTZ.Trim());

			// Execute the request
			var result = await Execute<ConvertByTIZOResponse>(
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
		/// Name GetDIVIData
		/// Description Get Division Data
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_DATE">Date</param>
		/// <param name="m3_TIME">Time</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDIVIDataResponse></returns>
		/// <exception cref="M3Exception<GetDIVIDataResponse>"></exception>
		public async Task<M3Response<GetDIVIDataResponse>> GetDIVIData(
			string m3_DIVI = null, 
			DateTime? m3_DATE = null, 
			string m3_TIME = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDIVIData",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_DATE.HasValue)
				request.WithQueryParameter("DATE", m3_DATE.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TIME))
				request.WithQueryParameter("TIME", m3_TIME.Trim());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<GetDIVIDataResponse>(
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
		/// Name GetEDESData
		/// Description Get Place Data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_EDES">Place (Required)</param>
		/// <param name="m3_DATE">Date</param>
		/// <param name="m3_TIME">Time</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetEDESDataResponse></returns>
		/// <exception cref="M3Exception<GetEDESDataResponse>"></exception>
		public async Task<M3Response<GetEDESDataResponse>> GetEDESData(
			string m3_EDES, 
			DateTime? m3_DATE = null, 
			string m3_TIME = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetEDESData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_EDES))
				throw new ArgumentNullException("m3_EDES");

			// Set mandatory parameters
			request
				.WithQueryParameter("EDES", m3_EDES.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DATE.HasValue)
				request.WithQueryParameter("DATE", m3_DATE.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TIME))
				request.WithQueryParameter("TIME", m3_TIME.Trim());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<GetEDESDataResponse>(
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
		/// Name GetFACIData
		/// Description Get Facility Data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_DATE">Date</param>
		/// <param name="m3_TIME">Time</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFACIDataResponse></returns>
		/// <exception cref="M3Exception<GetFACIDataResponse>"></exception>
		public async Task<M3Response<GetFACIDataResponse>> GetFACIData(
			string m3_FACI, 
			DateTime? m3_DATE = null, 
			string m3_TIME = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetFACIData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DATE.HasValue)
				request.WithQueryParameter("DATE", m3_DATE.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TIME))
				request.WithQueryParameter("TIME", m3_TIME.Trim());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<GetFACIDataResponse>(
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
		/// Name GetUSIDData
		/// Description Get User Data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_USID">User (Required)</param>
		/// <param name="m3_DATE">Date</param>
		/// <param name="m3_TIME">Time</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetUSIDDataResponse></returns>
		/// <exception cref="M3Exception<GetUSIDDataResponse>"></exception>
		public async Task<M3Response<GetUSIDDataResponse>> GetUSIDData(
			string m3_USID, 
			DateTime? m3_DATE = null, 
			string m3_TIME = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetUSIDData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3_USID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DATE.HasValue)
				request.WithQueryParameter("DATE", m3_DATE.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TIME))
				request.WithQueryParameter("TIME", m3_TIME.Trim());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<GetUSIDDataResponse>(
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
		/// Name GetWHLOData
		/// Description Get Warehouse Data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_DATE">Date</param>
		/// <param name="m3_TIME">Time</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetWHLODataResponse></returns>
		/// <exception cref="M3Exception<GetWHLODataResponse>"></exception>
		public async Task<M3Response<GetWHLODataResponse>> GetWHLOData(
			string m3_WHLO, 
			DateTime? m3_DATE = null, 
			string m3_TIME = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetWHLOData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DATE.HasValue)
				request.WithQueryParameter("DATE", m3_DATE.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TIME))
				request.WithQueryParameter("TIME", m3_TIME.Trim());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<GetWHLODataResponse>(
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
		/// Name LstTimeZones
		/// Description Lists time zone information
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTimeZonesResponse></returns>
		/// <exception cref="M3Exception<LstTimeZonesResponse>"></exception>
		public async Task<M3Response<LstTimeZonesResponse>> LstTimeZones(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTimeZones",
			};

			// Execute the request
			var result = await Execute<LstTimeZonesResponse>(
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
