/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MOS306MI;
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
	/// Name: MOS306MI
	/// Component Name: ItemSerialNumber
	/// Description: Equipment class
	/// Version Release: 5e90
	///</summary>
	public partial class MOS306MIResource : M3BaseResourceEndpoint
	{
		public MOS306MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS306MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_PRNO">Product (Required)</param>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_SPRL">Service price list (Required)</param>
		/// <param name="m3_SRVP">Service price method (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SERP">Service price</param>
		/// <param name="m3_CRTP">Exchange rate type</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_ADF1">Price in labor currency</param>
		/// <param name="m3_ADF2">Price in material currency</param>
		/// <param name="m3_ADF3">Price in subcontracting currency</param>
		/// <param name="m3_ADF4">Price in miscellaneous currency</param>
		/// <param name="m3_ADY1">Fixed amount</param>
		/// <param name="m3_ADY2">Fixed amount</param>
		/// <param name="m3_ADY3">Fixed amount</param>
		/// <param name="m3_ADY4">Fixed amount</param>
		/// <param name="m3_ADX1">Tax code customer/address</param>
		/// <param name="m3_ADX2">Tax code customer/address</param>
		/// <param name="m3_ADX3">Tax code customer/address</param>
		/// <param name="m3_ADX4">Tax code customer/address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_PRNO, 
			string m3_SUFI, 
			string m3_SPRL, 
			int m3_SRVP, 
			string m3_FACI, 
			DateTime m3_FRDT, 
			string m3_CUCD, 
			string m3_STRT = null, 
			decimal? m3_SERP = null, 
			int? m3_CRTP = null, 
			decimal? m3_TXID = null, 
			decimal? m3_ADF1 = null, 
			decimal? m3_ADF2 = null, 
			decimal? m3_ADF3 = null, 
			decimal? m3_ADF4 = null, 
			int? m3_ADY1 = null, 
			int? m3_ADY2 = null, 
			int? m3_ADY3 = null, 
			int? m3_ADY4 = null, 
			string m3_ADX1 = null, 
			string m3_ADX2 = null, 
			string m3_ADX3 = null, 
			string m3_ADX4 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");
			if (string.IsNullOrWhiteSpace(m3_SPRL))
				throw new ArgumentNullException("m3_SPRL");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("SPRL", m3_SPRL.Trim())
				.WithQueryParameter("SRVP", m3_SRVP.ToString())
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String())
				.WithQueryParameter("CUCD", m3_CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_SERP.HasValue)
				request.WithQueryParameter("SERP", m3_SERP.Value.ToString());
			if (m3_CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3_CRTP.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_ADF1.HasValue)
				request.WithQueryParameter("ADF1", m3_ADF1.Value.ToString());
			if (m3_ADF2.HasValue)
				request.WithQueryParameter("ADF2", m3_ADF2.Value.ToString());
			if (m3_ADF3.HasValue)
				request.WithQueryParameter("ADF3", m3_ADF3.Value.ToString());
			if (m3_ADF4.HasValue)
				request.WithQueryParameter("ADF4", m3_ADF4.Value.ToString());
			if (m3_ADY1.HasValue)
				request.WithQueryParameter("ADY1", m3_ADY1.Value.ToString());
			if (m3_ADY2.HasValue)
				request.WithQueryParameter("ADY2", m3_ADY2.Value.ToString());
			if (m3_ADY3.HasValue)
				request.WithQueryParameter("ADY3", m3_ADY3.Value.ToString());
			if (m3_ADY4.HasValue)
				request.WithQueryParameter("ADY4", m3_ADY4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADX1))
				request.WithQueryParameter("ADX1", m3_ADX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADX2))
				request.WithQueryParameter("ADX2", m3_ADX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADX3))
				request.WithQueryParameter("ADX3", m3_ADX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADX4))
				request.WithQueryParameter("ADX4", m3_ADX4.Trim());

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
		/// Description Get
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_PRNO">Product (Required)</param>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_SPRL">Service price list (Required)</param>
		/// <param name="m3_SRVP">Service price method (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_PRNO, 
			string m3_SUFI, 
			string m3_SPRL, 
			int m3_SRVP, 
			string m3_CUCD, 
			string m3_FACI, 
			DateTime m3_FRDT, 
			string m3_STRT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");
			if (string.IsNullOrWhiteSpace(m3_SPRL))
				throw new ArgumentNullException("m3_SPRL");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("SPRL", m3_SPRL.Trim())
				.WithQueryParameter("SRVP", m3_SRVP.ToString())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());

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
		/// Name List
		/// Description List
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_SPRL">Service price list</param>
		/// <param name="m3_SRVP">Service price method</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_FRDT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			string m3_SPRL = null, 
			int? m3_SRVP = null, 
			string m3_CUCD = null, 
			string m3_FACI = null, 
			DateTime? m3_FRDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/List",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPRL))
				request.WithQueryParameter("SPRL", m3_SPRL.Trim());
			if (m3_SRVP.HasValue)
				request.WithQueryParameter("SRVP", m3_SRVP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (m3_FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3_FRDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<ListResponse>(
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
		/// Description Upd
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_PRNO">Product (Required)</param>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_SPRL">Service price list (Required)</param>
		/// <param name="m3_SRVP">Service price method (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_CRTP">Exchange rate type</param>
		/// <param name="m3_ADF1">Price in labor currency</param>
		/// <param name="m3_ADF2">Price in material currency</param>
		/// <param name="m3_ADF3">Price in subcontracting currency</param>
		/// <param name="m3_ADF4">Price in miscellaneous currency</param>
		/// <param name="m3_ADY1">Fixed amount</param>
		/// <param name="m3_ADY2">Fixed amount</param>
		/// <param name="m3_ADY3">Fixed amount</param>
		/// <param name="m3_ADY4">Fixed amount</param>
		/// <param name="m3_ADX1">Tax code customer/address</param>
		/// <param name="m3_ADX2">Tax code customer/address</param>
		/// <param name="m3_ADX3">Tax code customer/address</param>
		/// <param name="m3_ADX4">Tax code customer/address</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3_PRNO, 
			string m3_SUFI, 
			string m3_SPRL, 
			int m3_SRVP, 
			string m3_CUCD, 
			string m3_FACI, 
			DateTime m3_FRDT, 
			string m3_STRT = null, 
			int? m3_CRTP = null, 
			decimal? m3_ADF1 = null, 
			decimal? m3_ADF2 = null, 
			decimal? m3_ADF3 = null, 
			decimal? m3_ADF4 = null, 
			int? m3_ADY1 = null, 
			int? m3_ADY2 = null, 
			int? m3_ADY3 = null, 
			int? m3_ADY4 = null, 
			string m3_ADX1 = null, 
			string m3_ADX2 = null, 
			string m3_ADX3 = null, 
			string m3_ADX4 = null, 
			decimal? m3_TXID = null, 
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
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");
			if (string.IsNullOrWhiteSpace(m3_SPRL))
				throw new ArgumentNullException("m3_SPRL");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("SPRL", m3_SPRL.Trim())
				.WithQueryParameter("SRVP", m3_SRVP.ToString())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3_CRTP.Value.ToString());
			if (m3_ADF1.HasValue)
				request.WithQueryParameter("ADF1", m3_ADF1.Value.ToString());
			if (m3_ADF2.HasValue)
				request.WithQueryParameter("ADF2", m3_ADF2.Value.ToString());
			if (m3_ADF3.HasValue)
				request.WithQueryParameter("ADF3", m3_ADF3.Value.ToString());
			if (m3_ADF4.HasValue)
				request.WithQueryParameter("ADF4", m3_ADF4.Value.ToString());
			if (m3_ADY1.HasValue)
				request.WithQueryParameter("ADY1", m3_ADY1.Value.ToString());
			if (m3_ADY2.HasValue)
				request.WithQueryParameter("ADY2", m3_ADY2.Value.ToString());
			if (m3_ADY3.HasValue)
				request.WithQueryParameter("ADY3", m3_ADY3.Value.ToString());
			if (m3_ADY4.HasValue)
				request.WithQueryParameter("ADY4", m3_ADY4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADX1))
				request.WithQueryParameter("ADX1", m3_ADX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADX2))
				request.WithQueryParameter("ADX2", m3_ADX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADX3))
				request.WithQueryParameter("ADX3", m3_ADX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADX4))
				request.WithQueryParameter("ADX4", m3_ADX4.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
