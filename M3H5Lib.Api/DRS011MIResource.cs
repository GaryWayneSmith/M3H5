/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_EDES">Place of load (Required)</param>
		/// <param name="m3_PREX">Priority (Required)</param>
		/// <param name="m3_ROUT">Route (Required)</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_RODN">Route departure</param>
		/// <param name="m3_SEFB">Selection method for departures</param>
		/// <param name="m3_SELP">Try lower priority</param>
		/// <param name="m3_DDOW">Departure days</param>
		/// <param name="m3_FWNO">Forwarding agent</param>
		/// <param name="m3_TRCA">Transportation equipment</param>
		/// <param name="m3_RFID">Reference</param>
		/// <param name="m3_PAL1">Pallet registration number</param>
		/// <param name="m3_PRRO">Preliminary route selection</param>
		/// <param name="m3_LOLD">Local transportation lead time - days</param>
		/// <param name="m3_LOLH">Local transportation lead time - hours</param>
		/// <param name="m3_LOLM">Local transportation lead time - minutes</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_EDES, 
			string m3_PREX, 
			string m3_ROUT, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
			int? m3_RODN = null, 
			int? m3_SEFB = null, 
			int? m3_SELP = null, 
			string m3_DDOW = null, 
			string m3_FWNO = null, 
			string m3_TRCA = null, 
			string m3_RFID = null, 
			string m3_PAL1 = null, 
			int? m3_PRRO = null, 
			int? m3_LOLD = null, 
			int? m3_LOLH = null, 
			int? m3_LOLM = null, 
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
			if (string.IsNullOrWhiteSpace(m3_EDES))
				throw new ArgumentNullException("m3_EDES");
			if (string.IsNullOrWhiteSpace(m3_PREX))
				throw new ArgumentNullException("m3_PREX");
			if (string.IsNullOrWhiteSpace(m3_ROUT))
				throw new ArgumentNullException("m3_ROUT");

			// Set mandatory parameters
			request
				.WithQueryParameter("EDES", m3_EDES.Trim())
				.WithQueryParameter("PREX", m3_PREX.Trim())
				.WithQueryParameter("ROUT", m3_ROUT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (m3_RODN.HasValue)
				request.WithQueryParameter("RODN", m3_RODN.Value.ToString());
			if (m3_SEFB.HasValue)
				request.WithQueryParameter("SEFB", m3_SEFB.Value.ToString());
			if (m3_SELP.HasValue)
				request.WithQueryParameter("SELP", m3_SELP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DDOW))
				request.WithQueryParameter("DDOW", m3_DDOW.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FWNO))
				request.WithQueryParameter("FWNO", m3_FWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRCA))
				request.WithQueryParameter("TRCA", m3_TRCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFID))
				request.WithQueryParameter("RFID", m3_RFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAL1))
				request.WithQueryParameter("PAL1", m3_PAL1.Trim());
			if (m3_PRRO.HasValue)
				request.WithQueryParameter("PRRO", m3_PRRO.Value.ToString());
			if (m3_LOLD.HasValue)
				request.WithQueryParameter("LOLD", m3_LOLD.Value.ToString());
			if (m3_LOLH.HasValue)
				request.WithQueryParameter("LOLH", m3_LOLH.Value.ToString());
			if (m3_LOLM.HasValue)
				request.WithQueryParameter("LOLM", m3_LOLM.Value.ToString());

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
		/// Name Dlt
		/// Description Dlt
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_EDES">Place of load (Required)</param>
		/// <param name="m3_PREX">Priority (Required)</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Dlt(
			string m3_EDES, 
			string m3_PREX, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_EDES))
				throw new ArgumentNullException("m3_EDES");
			if (string.IsNullOrWhiteSpace(m3_PREX))
				throw new ArgumentNullException("m3_PREX");

			// Set mandatory parameters
			request
				.WithQueryParameter("EDES", m3_EDES.Trim())
				.WithQueryParameter("PREX", m3_PREX.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());

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
		/// Name Get
		/// Description Get a record
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_EDES">Place of load (Required)</param>
		/// <param name="m3_PREX">Priority (Required)</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_EDES, 
			string m3_PREX, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_EDES))
				throw new ArgumentNullException("m3_EDES");
			if (string.IsNullOrWhiteSpace(m3_PREX))
				throw new ArgumentNullException("m3_PREX");

			// Set mandatory parameters
			request
				.WithQueryParameter("EDES", m3_EDES.Trim())
				.WithQueryParameter("PREX", m3_PREX.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name Lst
		/// Description List records
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_EDES">Place of load (Required)</param>
		/// <param name="m3_PREX">Priority (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3_EDES, 
			string m3_PREX, 
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
			if (string.IsNullOrWhiteSpace(m3_EDES))
				throw new ArgumentNullException("m3_EDES");
			if (string.IsNullOrWhiteSpace(m3_PREX))
				throw new ArgumentNullException("m3_PREX");

			// Set mandatory parameters
			request
				.WithQueryParameter("EDES", m3_EDES.Trim())
				.WithQueryParameter("PREX", m3_PREX.Trim());

			// Execute the request
			var result = await Execute<LstResponse>(
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
		/// Name Upd
		/// Description Update a record
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_EDES">Place of load (Required)</param>
		/// <param name="m3_PREX">Priority (Required)</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_ROUT">Route</param>
		/// <param name="m3_RODN">Route departure</param>
		/// <param name="m3_SEFB">Selection method for departures</param>
		/// <param name="m3_SELP">Try lower priority</param>
		/// <param name="m3_DDOW">Departure days</param>
		/// <param name="m3_FWNO">Forwarding agent</param>
		/// <param name="m3_TRCA">Transportation equipment</param>
		/// <param name="m3_RFID">Reference</param>
		/// <param name="m3_PAL1">Pallet registration number</param>
		/// <param name="m3_PRRO">Preliminary route selection</param>
		/// <param name="m3_LOLD">Local transportation lead time - days</param>
		/// <param name="m3_LOLH">Local transportation lead time - hours</param>
		/// <param name="m3_LOLM">Local transportation lead time - minutes</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3_EDES, 
			string m3_PREX, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
			string m3_ROUT = null, 
			int? m3_RODN = null, 
			int? m3_SEFB = null, 
			int? m3_SELP = null, 
			string m3_DDOW = null, 
			string m3_FWNO = null, 
			string m3_TRCA = null, 
			string m3_RFID = null, 
			string m3_PAL1 = null, 
			int? m3_PRRO = null, 
			int? m3_LOLD = null, 
			int? m3_LOLH = null, 
			int? m3_LOLM = null, 
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
			if (string.IsNullOrWhiteSpace(m3_EDES))
				throw new ArgumentNullException("m3_EDES");
			if (string.IsNullOrWhiteSpace(m3_PREX))
				throw new ArgumentNullException("m3_PREX");

			// Set mandatory parameters
			request
				.WithQueryParameter("EDES", m3_EDES.Trim())
				.WithQueryParameter("PREX", m3_PREX.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ROUT))
				request.WithQueryParameter("ROUT", m3_ROUT.Trim());
			if (m3_RODN.HasValue)
				request.WithQueryParameter("RODN", m3_RODN.Value.ToString());
			if (m3_SEFB.HasValue)
				request.WithQueryParameter("SEFB", m3_SEFB.Value.ToString());
			if (m3_SELP.HasValue)
				request.WithQueryParameter("SELP", m3_SELP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DDOW))
				request.WithQueryParameter("DDOW", m3_DDOW.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FWNO))
				request.WithQueryParameter("FWNO", m3_FWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRCA))
				request.WithQueryParameter("TRCA", m3_TRCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFID))
				request.WithQueryParameter("RFID", m3_RFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAL1))
				request.WithQueryParameter("PAL1", m3_PAL1.Trim());
			if (m3_PRRO.HasValue)
				request.WithQueryParameter("PRRO", m3_PRRO.Value.ToString());
			if (m3_LOLD.HasValue)
				request.WithQueryParameter("LOLD", m3_LOLD.Value.ToString());
			if (m3_LOLH.HasValue)
				request.WithQueryParameter("LOLH", m3_LOLH.Value.ToString());
			if (m3_LOLM.HasValue)
				request.WithQueryParameter("LOLM", m3_LOLM.Value.ToString());

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
