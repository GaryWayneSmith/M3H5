/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3FRTM">From time (Required)</param>
		/// <param name="m3FRTB">From reference (Required)</param>
		/// <param name="m3FRIA">From ID (Required)</param>
		/// <param name="m3TOTB">To reference (Required)</param>
		/// <param name="m3TOIA">To ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ConvertByRefResponse></returns>
		/// <exception cref="M3Exception<ConvertByRefResponse>"></exception>
		public async Task<M3Response<ConvertByRefResponse>> ConvertByRef(
			DateTime m3FRDT, 
			string m3FRTM, 
			string m3FRTB, 
			string m3FRIA, 
			string m3TOTB, 
			string m3TOIA, 
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
			if (string.IsNullOrWhiteSpace(m3FRTM))
				throw new ArgumentNullException(nameof(m3FRTM));
			if (string.IsNullOrWhiteSpace(m3FRTB))
				throw new ArgumentNullException(nameof(m3FRTB));
			if (string.IsNullOrWhiteSpace(m3FRIA))
				throw new ArgumentNullException(nameof(m3FRIA));
			if (string.IsNullOrWhiteSpace(m3TOTB))
				throw new ArgumentNullException(nameof(m3TOTB));
			if (string.IsNullOrWhiteSpace(m3TOIA))
				throw new ArgumentNullException(nameof(m3TOIA));

			// Set mandatory parameters
			request
				.WithQueryParameter("FRDT", m3FRDT.ToM3String())
				.WithQueryParameter("FRTM", m3FRTM.Trim())
				.WithQueryParameter("FRTB", m3FRTB.Trim())
				.WithQueryParameter("FRIA", m3FRIA.Trim())
				.WithQueryParameter("TOTB", m3TOTB.Trim())
				.WithQueryParameter("TOIA", m3TOIA.Trim());

			// Execute the request
			var result = await Execute<ConvertByRefResponse>(
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
		/// Name ConvertByTIZO
		/// Description Convert by time zone
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3FRTM">From time (Required)</param>
		/// <param name="m3FRTZ">From time zone</param>
		/// <param name="m3TOTZ">To time zone</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ConvertByTIZOResponse></returns>
		/// <exception cref="M3Exception<ConvertByTIZOResponse>"></exception>
		public async Task<M3Response<ConvertByTIZOResponse>> ConvertByTIZO(
			DateTime m3FRDT, 
			string m3FRTM, 
			string m3FRTZ = null, 
			string m3TOTZ = null, 
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
			if (string.IsNullOrWhiteSpace(m3FRTM))
				throw new ArgumentNullException(nameof(m3FRTM));

			// Set mandatory parameters
			request
				.WithQueryParameter("FRDT", m3FRDT.ToM3String())
				.WithQueryParameter("FRTM", m3FRTM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FRTZ))
				request.WithQueryParameter("FRTZ", m3FRTZ.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOTZ))
				request.WithQueryParameter("TOTZ", m3TOTZ.Trim());

			// Execute the request
			var result = await Execute<ConvertByTIZOResponse>(
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
		/// Name GetDIVIData
		/// Description Get Division Data
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3DATE">Date</param>
		/// <param name="m3TIME">Time</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDIVIDataResponse></returns>
		/// <exception cref="M3Exception<GetDIVIDataResponse>"></exception>
		public async Task<M3Response<GetDIVIDataResponse>> GetDIVIData(
			string m3DIVI = null, 
			DateTime? m3DATE = null, 
			string m3TIME = null, 
			int? m3UTCM = null, 
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
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3DATE.HasValue)
				request.WithQueryParameter("DATE", m3DATE.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TIME))
				request.WithQueryParameter("TIME", m3TIME.Trim());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetDIVIDataResponse>(
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
		/// Name GetEDESData
		/// Description Get Place Data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3EDES">Place (Required)</param>
		/// <param name="m3DATE">Date</param>
		/// <param name="m3TIME">Time</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetEDESDataResponse></returns>
		/// <exception cref="M3Exception<GetEDESDataResponse>"></exception>
		public async Task<M3Response<GetEDESDataResponse>> GetEDESData(
			string m3EDES, 
			DateTime? m3DATE = null, 
			string m3TIME = null, 
			int? m3UTCM = null, 
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
			if (string.IsNullOrWhiteSpace(m3EDES))
				throw new ArgumentNullException(nameof(m3EDES));

			// Set mandatory parameters
			request
				.WithQueryParameter("EDES", m3EDES.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3DATE.HasValue)
				request.WithQueryParameter("DATE", m3DATE.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TIME))
				request.WithQueryParameter("TIME", m3TIME.Trim());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetEDESDataResponse>(
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
		/// Name GetFACIData
		/// Description Get Facility Data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3DATE">Date</param>
		/// <param name="m3TIME">Time</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFACIDataResponse></returns>
		/// <exception cref="M3Exception<GetFACIDataResponse>"></exception>
		public async Task<M3Response<GetFACIDataResponse>> GetFACIData(
			string m3FACI, 
			DateTime? m3DATE = null, 
			string m3TIME = null, 
			int? m3UTCM = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3DATE.HasValue)
				request.WithQueryParameter("DATE", m3DATE.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TIME))
				request.WithQueryParameter("TIME", m3TIME.Trim());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetFACIDataResponse>(
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
		/// Name GetUSIDData
		/// Description Get User Data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3USID">User (Required)</param>
		/// <param name="m3DATE">Date</param>
		/// <param name="m3TIME">Time</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetUSIDDataResponse></returns>
		/// <exception cref="M3Exception<GetUSIDDataResponse>"></exception>
		public async Task<M3Response<GetUSIDDataResponse>> GetUSIDData(
			string m3USID, 
			DateTime? m3DATE = null, 
			string m3TIME = null, 
			int? m3UTCM = null, 
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
			if (string.IsNullOrWhiteSpace(m3USID))
				throw new ArgumentNullException(nameof(m3USID));

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3USID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3DATE.HasValue)
				request.WithQueryParameter("DATE", m3DATE.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TIME))
				request.WithQueryParameter("TIME", m3TIME.Trim());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetUSIDDataResponse>(
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
		/// Name GetWHLOData
		/// Description Get Warehouse Data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3DATE">Date</param>
		/// <param name="m3TIME">Time</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetWHLODataResponse></returns>
		/// <exception cref="M3Exception<GetWHLODataResponse>"></exception>
		public async Task<M3Response<GetWHLODataResponse>> GetWHLOData(
			string m3WHLO, 
			DateTime? m3DATE = null, 
			string m3TIME = null, 
			int? m3UTCM = null, 
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
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3DATE.HasValue)
				request.WithQueryParameter("DATE", m3DATE.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TIME))
				request.WithQueryParameter("TIME", m3TIME.Trim());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetWHLODataResponse>(
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
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}
	}
}
// EOF
