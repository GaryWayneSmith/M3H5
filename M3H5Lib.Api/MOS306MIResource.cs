/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3SPRL">Service price list (Required)</param>
		/// <param name="m3SRVP">Service price method (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SERP">Service price</param>
		/// <param name="m3CRTP">Exchange rate type</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3ADF1">Price in labor currency</param>
		/// <param name="m3ADF2">Price in material currency</param>
		/// <param name="m3ADF3">Price in subcontracting currency</param>
		/// <param name="m3ADF4">Price in miscellaneous currency</param>
		/// <param name="m3ADY1">Fixed amount</param>
		/// <param name="m3ADY2">Fixed amount</param>
		/// <param name="m3ADY3">Fixed amount</param>
		/// <param name="m3ADY4">Fixed amount</param>
		/// <param name="m3ADX1">Tax code customer/address</param>
		/// <param name="m3ADX2">Tax code customer/address</param>
		/// <param name="m3ADX3">Tax code customer/address</param>
		/// <param name="m3ADX4">Tax code customer/address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3PRNO, 
			string m3SUFI, 
			string m3SPRL, 
			int m3SRVP, 
			string m3FACI, 
			DateTime m3FRDT, 
			string m3CUCD, 
			string m3STRT = null, 
			decimal? m3SERP = null, 
			int? m3CRTP = null, 
			decimal? m3TXID = null, 
			decimal? m3ADF1 = null, 
			decimal? m3ADF2 = null, 
			decimal? m3ADF3 = null, 
			decimal? m3ADF4 = null, 
			int? m3ADY1 = null, 
			int? m3ADY2 = null, 
			int? m3ADY3 = null, 
			int? m3ADY4 = null, 
			string m3ADX1 = null, 
			string m3ADX2 = null, 
			string m3ADX3 = null, 
			string m3ADX4 = null, 
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
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));
			if (string.IsNullOrWhiteSpace(m3SPRL))
				throw new ArgumentNullException(nameof(m3SPRL));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("SPRL", m3SPRL.Trim())
				.WithQueryParameter("SRVP", m3SRVP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("FRDT", m3FRDT.ToM3String())
				.WithQueryParameter("CUCD", m3CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3SERP.HasValue)
				request.WithQueryParameter("SERP", m3SERP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3CRTP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADF1.HasValue)
				request.WithQueryParameter("ADF1", m3ADF1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADF2.HasValue)
				request.WithQueryParameter("ADF2", m3ADF2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADF3.HasValue)
				request.WithQueryParameter("ADF3", m3ADF3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADF4.HasValue)
				request.WithQueryParameter("ADF4", m3ADF4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADY1.HasValue)
				request.WithQueryParameter("ADY1", m3ADY1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADY2.HasValue)
				request.WithQueryParameter("ADY2", m3ADY2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADY3.HasValue)
				request.WithQueryParameter("ADY3", m3ADY3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADY4.HasValue)
				request.WithQueryParameter("ADY4", m3ADY4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADX1))
				request.WithQueryParameter("ADX1", m3ADX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADX2))
				request.WithQueryParameter("ADX2", m3ADX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADX3))
				request.WithQueryParameter("ADX3", m3ADX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADX4))
				request.WithQueryParameter("ADX4", m3ADX4.Trim());

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
		/// Description Get
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3SPRL">Service price list (Required)</param>
		/// <param name="m3SRVP">Service price method (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3PRNO, 
			string m3SUFI, 
			string m3SPRL, 
			int m3SRVP, 
			string m3CUCD, 
			string m3FACI, 
			DateTime m3FRDT, 
			string m3STRT = null, 
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
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));
			if (string.IsNullOrWhiteSpace(m3SPRL))
				throw new ArgumentNullException(nameof(m3SPRL));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("SPRL", m3SPRL.Trim())
				.WithQueryParameter("SRVP", m3SRVP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("FRDT", m3FRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());

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
		/// Name List
		/// Description List
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3SPRL">Service price list</param>
		/// <param name="m3SRVP">Service price method</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3FRDT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			string m3SPRL = null, 
			int? m3SRVP = null, 
			string m3CUCD = null, 
			string m3FACI = null, 
			DateTime? m3FRDT = null, 
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
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPRL))
				request.WithQueryParameter("SPRL", m3SPRL.Trim());
			if (m3SRVP.HasValue)
				request.WithQueryParameter("SRVP", m3SRVP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (m3FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3FRDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<ListResponse>(
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
		/// Description Upd
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3SPRL">Service price list (Required)</param>
		/// <param name="m3SRVP">Service price method (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3CRTP">Exchange rate type</param>
		/// <param name="m3ADF1">Price in labor currency</param>
		/// <param name="m3ADF2">Price in material currency</param>
		/// <param name="m3ADF3">Price in subcontracting currency</param>
		/// <param name="m3ADF4">Price in miscellaneous currency</param>
		/// <param name="m3ADY1">Fixed amount</param>
		/// <param name="m3ADY2">Fixed amount</param>
		/// <param name="m3ADY3">Fixed amount</param>
		/// <param name="m3ADY4">Fixed amount</param>
		/// <param name="m3ADX1">Tax code customer/address</param>
		/// <param name="m3ADX2">Tax code customer/address</param>
		/// <param name="m3ADX3">Tax code customer/address</param>
		/// <param name="m3ADX4">Tax code customer/address</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3PRNO, 
			string m3SUFI, 
			string m3SPRL, 
			int m3SRVP, 
			string m3CUCD, 
			string m3FACI, 
			DateTime m3FRDT, 
			string m3STRT = null, 
			int? m3CRTP = null, 
			decimal? m3ADF1 = null, 
			decimal? m3ADF2 = null, 
			decimal? m3ADF3 = null, 
			decimal? m3ADF4 = null, 
			int? m3ADY1 = null, 
			int? m3ADY2 = null, 
			int? m3ADY3 = null, 
			int? m3ADY4 = null, 
			string m3ADX1 = null, 
			string m3ADX2 = null, 
			string m3ADX3 = null, 
			string m3ADX4 = null, 
			decimal? m3TXID = null, 
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
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));
			if (string.IsNullOrWhiteSpace(m3SPRL))
				throw new ArgumentNullException(nameof(m3SPRL));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("SPRL", m3SPRL.Trim())
				.WithQueryParameter("SRVP", m3SRVP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("FRDT", m3FRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3CRTP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADF1.HasValue)
				request.WithQueryParameter("ADF1", m3ADF1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADF2.HasValue)
				request.WithQueryParameter("ADF2", m3ADF2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADF3.HasValue)
				request.WithQueryParameter("ADF3", m3ADF3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADF4.HasValue)
				request.WithQueryParameter("ADF4", m3ADF4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADY1.HasValue)
				request.WithQueryParameter("ADY1", m3ADY1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADY2.HasValue)
				request.WithQueryParameter("ADY2", m3ADY2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADY3.HasValue)
				request.WithQueryParameter("ADY3", m3ADY3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADY4.HasValue)
				request.WithQueryParameter("ADY4", m3ADY4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADX1))
				request.WithQueryParameter("ADX1", m3ADX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADX2))
				request.WithQueryParameter("ADX2", m3ADX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADX3))
				request.WithQueryParameter("ADX3", m3ADX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADX4))
				request.WithQueryParameter("ADX4", m3ADX4.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
