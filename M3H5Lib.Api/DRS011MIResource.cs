/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.DRS011MI;
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
	/// Name: DRS011MI
	/// Component Name: RouteSelection
	/// Description: Route selection table interface
	/// Version Release: 5ea0
	///</summary>
	public partial class DRS011MIResource : M3BaseResourceEndpoint
	{
		public DRS011MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "DRS011MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3EDES">Place of load (Required)</param>
		/// <param name="m3PREX">Priority (Required)</param>
		/// <param name="m3ROUT">Route (Required)</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3RODN">Route departure</param>
		/// <param name="m3SEFB">Selection method for departures</param>
		/// <param name="m3SELP">Try lower priority</param>
		/// <param name="m3DDOW">Departure days</param>
		/// <param name="m3FWNO">Forwarding agent</param>
		/// <param name="m3TRCA">Transportation equipment</param>
		/// <param name="m3RFID">Reference</param>
		/// <param name="m3PAL1">Pallet registration number</param>
		/// <param name="m3PRRO">Preliminary route selection</param>
		/// <param name="m3LOLD">Local transportation lead time - days</param>
		/// <param name="m3LOLH">Local transportation lead time - hours</param>
		/// <param name="m3LOLM">Local transportation lead time - minutes</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3EDES, 
			string m3PREX, 
			string m3ROUT, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
			int? m3RODN = null, 
			int? m3SEFB = null, 
			int? m3SELP = null, 
			string m3DDOW = null, 
			string m3FWNO = null, 
			string m3TRCA = null, 
			string m3RFID = null, 
			string m3PAL1 = null, 
			int? m3PRRO = null, 
			int? m3LOLD = null, 
			int? m3LOLH = null, 
			int? m3LOLM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EDES))
				throw new ArgumentNullException(nameof(m3EDES));
			if (string.IsNullOrWhiteSpace(m3PREX))
				throw new ArgumentNullException(nameof(m3PREX));
			if (string.IsNullOrWhiteSpace(m3ROUT))
				throw new ArgumentNullException(nameof(m3ROUT));

			// Set mandatory parameters
			request
				.WithQueryParameter("EDES", m3EDES.Trim())
				.WithQueryParameter("PREX", m3PREX.Trim())
				.WithQueryParameter("ROUT", m3ROUT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (m3RODN.HasValue)
				request.WithQueryParameter("RODN", m3RODN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SEFB.HasValue)
				request.WithQueryParameter("SEFB", m3SEFB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SELP.HasValue)
				request.WithQueryParameter("SELP", m3SELP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DDOW))
				request.WithQueryParameter("DDOW", m3DDOW.Trim());
			if (!string.IsNullOrWhiteSpace(m3FWNO))
				request.WithQueryParameter("FWNO", m3FWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRCA))
				request.WithQueryParameter("TRCA", m3TRCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFID))
				request.WithQueryParameter("RFID", m3RFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAL1))
				request.WithQueryParameter("PAL1", m3PAL1.Trim());
			if (m3PRRO.HasValue)
				request.WithQueryParameter("PRRO", m3PRRO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LOLD.HasValue)
				request.WithQueryParameter("LOLD", m3LOLD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LOLH.HasValue)
				request.WithQueryParameter("LOLH", m3LOLH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LOLM.HasValue)
				request.WithQueryParameter("LOLM", m3LOLM.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Dlt
		/// Description Dlt
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3EDES">Place of load (Required)</param>
		/// <param name="m3PREX">Priority (Required)</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Dlt(
			string m3EDES, 
			string m3PREX, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Dlt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EDES))
				throw new ArgumentNullException(nameof(m3EDES));
			if (string.IsNullOrWhiteSpace(m3PREX))
				throw new ArgumentNullException(nameof(m3PREX));

			// Set mandatory parameters
			request
				.WithQueryParameter("EDES", m3EDES.Trim())
				.WithQueryParameter("PREX", m3PREX.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());

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
		/// Name Get
		/// Description Get a record
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3EDES">Place of load (Required)</param>
		/// <param name="m3PREX">Priority (Required)</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3EDES, 
			string m3PREX, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EDES))
				throw new ArgumentNullException(nameof(m3EDES));
			if (string.IsNullOrWhiteSpace(m3PREX))
				throw new ArgumentNullException(nameof(m3PREX));

			// Set mandatory parameters
			request
				.WithQueryParameter("EDES", m3EDES.Trim())
				.WithQueryParameter("PREX", m3PREX.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name Lst
		/// Description List records
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3EDES">Place of load (Required)</param>
		/// <param name="m3PREX">Priority (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3EDES, 
			string m3PREX, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Lst",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EDES))
				throw new ArgumentNullException(nameof(m3EDES));
			if (string.IsNullOrWhiteSpace(m3PREX))
				throw new ArgumentNullException(nameof(m3PREX));

			// Set mandatory parameters
			request
				.WithQueryParameter("EDES", m3EDES.Trim())
				.WithQueryParameter("PREX", m3PREX.Trim());

			// Execute the request
			var result = await Execute<LstResponse>(
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
		/// Name Upd
		/// Description Update a record
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3EDES">Place of load (Required)</param>
		/// <param name="m3PREX">Priority (Required)</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3ROUT">Route</param>
		/// <param name="m3RODN">Route departure</param>
		/// <param name="m3SEFB">Selection method for departures</param>
		/// <param name="m3SELP">Try lower priority</param>
		/// <param name="m3DDOW">Departure days</param>
		/// <param name="m3FWNO">Forwarding agent</param>
		/// <param name="m3TRCA">Transportation equipment</param>
		/// <param name="m3RFID">Reference</param>
		/// <param name="m3PAL1">Pallet registration number</param>
		/// <param name="m3PRRO">Preliminary route selection</param>
		/// <param name="m3LOLD">Local transportation lead time - days</param>
		/// <param name="m3LOLH">Local transportation lead time - hours</param>
		/// <param name="m3LOLM">Local transportation lead time - minutes</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3EDES, 
			string m3PREX, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
			string m3ROUT = null, 
			int? m3RODN = null, 
			int? m3SEFB = null, 
			int? m3SELP = null, 
			string m3DDOW = null, 
			string m3FWNO = null, 
			string m3TRCA = null, 
			string m3RFID = null, 
			string m3PAL1 = null, 
			int? m3PRRO = null, 
			int? m3LOLD = null, 
			int? m3LOLH = null, 
			int? m3LOLM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Upd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EDES))
				throw new ArgumentNullException(nameof(m3EDES));
			if (string.IsNullOrWhiteSpace(m3PREX))
				throw new ArgumentNullException(nameof(m3PREX));

			// Set mandatory parameters
			request
				.WithQueryParameter("EDES", m3EDES.Trim())
				.WithQueryParameter("PREX", m3PREX.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3ROUT))
				request.WithQueryParameter("ROUT", m3ROUT.Trim());
			if (m3RODN.HasValue)
				request.WithQueryParameter("RODN", m3RODN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SEFB.HasValue)
				request.WithQueryParameter("SEFB", m3SEFB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SELP.HasValue)
				request.WithQueryParameter("SELP", m3SELP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DDOW))
				request.WithQueryParameter("DDOW", m3DDOW.Trim());
			if (!string.IsNullOrWhiteSpace(m3FWNO))
				request.WithQueryParameter("FWNO", m3FWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRCA))
				request.WithQueryParameter("TRCA", m3TRCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFID))
				request.WithQueryParameter("RFID", m3RFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAL1))
				request.WithQueryParameter("PAL1", m3PAL1.Trim());
			if (m3PRRO.HasValue)
				request.WithQueryParameter("PRRO", m3PRRO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LOLD.HasValue)
				request.WithQueryParameter("LOLD", m3LOLD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LOLH.HasValue)
				request.WithQueryParameter("LOLH", m3LOLH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LOLM.HasValue)
				request.WithQueryParameter("LOLM", m3LOLM.Value.ToString(CultureInfo.CurrentCulture));

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
