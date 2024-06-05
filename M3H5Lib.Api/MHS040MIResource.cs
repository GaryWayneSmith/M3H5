/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MHS040MI;
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
	/// Name: MHS040MI
	/// Component Name: Interface Item/Supplier
	/// Description: Api: Interface Item/Supplier
	/// Version Release: 14.x
	///</summary>
	public partial class MHS040MIResource : M3BaseResourceEndpoint
	{
		public MHS040MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MHS040MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddIntItmVen
		/// Description Add Interface Item Supplier
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_SITE">Supplier item number</param>
		/// <param name="m3_SITD">Supplier item name</param>
		/// <param name="m3_SITT">Supplier item description</param>
		/// <param name="m3_ISRS">Status - item/supplier</param>
		/// <param name="m3_LEA1">Supply lead time</param>
		/// <param name="m3_RFID">Reference</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_LOQT">Minimum order quantity</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_UVDT">Valid to</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_PUCD">Purchase price quantity</param>
		/// <param name="m3_SUPR">Setup price</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_ORCO">Country of origin</param>
		/// <param name="m3_ITFL">Item number flag</param>
		/// <param name="m3_ITAB">Item selection table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddIntItmVen(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			string m3_SUNO, 
			string m3_PRMD = null, 
			string m3_SITE = null, 
			string m3_SITD = null, 
			string m3_SITT = null, 
			string m3_ISRS = null, 
			int? m3_LEA1 = null, 
			string m3_RFID = null, 
			string m3_RESP = null, 
			decimal? m3_LOQT = null, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_UVDT = null, 
			decimal? m3_PUPR = null, 
			int? m3_PUCD = null, 
			decimal? m3_SUPR = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_TXID = null, 
			string m3_ORCO = null, 
			int? m3_ITFL = null, 
			string m3_ITAB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddIntItmVen",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SITE))
				request.WithQueryParameter("SITE", m3_SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SITD))
				request.WithQueryParameter("SITD", m3_SITD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SITT))
				request.WithQueryParameter("SITT", m3_SITT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ISRS))
				request.WithQueryParameter("ISRS", m3_ISRS.Trim());
			if (m3_LEA1.HasValue)
				request.WithQueryParameter("LEA1", m3_LEA1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RFID))
				request.WithQueryParameter("RFID", m3_RFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_LOQT.HasValue)
				request.WithQueryParameter("LOQT", m3_LOQT.Value.ToString());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_UVDT.HasValue)
				request.WithQueryParameter("UVDT", m3_UVDT.Value.ToM3String());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (m3_PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3_PUCD.Value.ToString());
			if (m3_SUPR.HasValue)
				request.WithQueryParameter("SUPR", m3_SUPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (m3_ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3_ITFL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITAB))
				request.WithQueryParameter("ITAB", m3_ITAB.Trim());

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
		/// Name ChgIntItmVen
		/// Description Change Interface Item Supplier
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_SITE">Supplier item number</param>
		/// <param name="m3_SITD">Supplier item name</param>
		/// <param name="m3_SITT">Supplier item description</param>
		/// <param name="m3_ISRS">Status - item/supplier</param>
		/// <param name="m3_LEA1">Supply lead time</param>
		/// <param name="m3_RFID">Reference</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_LOQT">Minimum order quantity</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_UVDT">Valid to</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_PUCD">Purchase price quantity</param>
		/// <param name="m3_SUPR">Setup price</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_ORCO">Country of origin</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STIM">Start time</param>
		/// <param name="m3_ITFL">Item number flag</param>
		/// <param name="m3_ACFL">Add/change flag</param>
		/// <param name="m3_ITAB">Item selection table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgIntItmVen(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			string m3_SUNO, 
			string m3_PRMD = null, 
			string m3_SITE = null, 
			string m3_SITD = null, 
			string m3_SITT = null, 
			string m3_ISRS = null, 
			int? m3_LEA1 = null, 
			string m3_RFID = null, 
			string m3_RESP = null, 
			decimal? m3_LOQT = null, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_UVDT = null, 
			decimal? m3_PUPR = null, 
			int? m3_PUCD = null, 
			decimal? m3_SUPR = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_TXID = null, 
			string m3_ORCO = null, 
			DateTime? m3_STDT = null, 
			int? m3_STIM = null, 
			int? m3_ITFL = null, 
			int? m3_ACFL = null, 
			string m3_ITAB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgIntItmVen",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SITE))
				request.WithQueryParameter("SITE", m3_SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SITD))
				request.WithQueryParameter("SITD", m3_SITD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SITT))
				request.WithQueryParameter("SITT", m3_SITT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ISRS))
				request.WithQueryParameter("ISRS", m3_ISRS.Trim());
			if (m3_LEA1.HasValue)
				request.WithQueryParameter("LEA1", m3_LEA1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RFID))
				request.WithQueryParameter("RFID", m3_RFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_LOQT.HasValue)
				request.WithQueryParameter("LOQT", m3_LOQT.Value.ToString());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_UVDT.HasValue)
				request.WithQueryParameter("UVDT", m3_UVDT.Value.ToM3String());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (m3_PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3_PUCD.Value.ToString());
			if (m3_SUPR.HasValue)
				request.WithQueryParameter("SUPR", m3_SUPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STIM.HasValue)
				request.WithQueryParameter("STIM", m3_STIM.Value.ToString());
			if (m3_ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3_ITFL.Value.ToString());
			if (m3_ACFL.HasValue)
				request.WithQueryParameter("ACFL", m3_ACFL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITAB))
				request.WithQueryParameter("ITAB", m3_ITAB.Trim());

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
		/// Name CpyIntItmVen
		/// Description Copy Interface Item Supplier
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_TE0P">Partner (Required)</param>
		/// <param name="m3_TE06">Message type (Required)</param>
		/// <param name="m3_TFIN">Interface item number (Required)</param>
		/// <param name="m3_TSUN">Supplier number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyIntItmVen(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			string m3_SUNO, 
			string m3_TE0P, 
			string m3_TE06, 
			string m3_TFIN, 
			string m3_TSUN, 
			string m3_PRMD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyIntItmVen",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_TE0P))
				throw new ArgumentNullException("m3_TE0P");
			if (string.IsNullOrWhiteSpace(m3_TE06))
				throw new ArgumentNullException("m3_TE06");
			if (string.IsNullOrWhiteSpace(m3_TFIN))
				throw new ArgumentNullException("m3_TFIN");
			if (string.IsNullOrWhiteSpace(m3_TSUN))
				throw new ArgumentNullException("m3_TSUN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("TE0P", m3_TE0P.Trim())
				.WithQueryParameter("TE06", m3_TE06.Trim())
				.WithQueryParameter("TFIN", m3_TFIN.Trim())
				.WithQueryParameter("TSUN", m3_TSUN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());

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
		/// Name DelIntItmVen
		/// Description Delete Interface Item Supplier
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelIntItmVen(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			string m3_SUNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelIntItmVen",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

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
		/// Name GetIntItmVen
		/// Description Get Interface Item Supplier
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetIntItmVenResponse></returns>
		/// <exception cref="M3Exception<GetIntItmVenResponse>"></exception>
		public async Task<M3Response<GetIntItmVenResponse>> GetIntItmVen(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			string m3_SUNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetIntItmVen",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Execute the request
			var result = await Execute<GetIntItmVenResponse>(
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
		/// Name LstIntItmVen
		/// Description List Interface Item Supplier
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner</param>
		/// <param name="m3_E065">Message type</param>
		/// <param name="m3_IFIN">Interface item number</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstIntItmVenResponse></returns>
		/// <exception cref="M3Exception<LstIntItmVenResponse>"></exception>
		public async Task<M3Response<LstIntItmVenResponse>> LstIntItmVen(
			string m3_E0PA = null, 
			string m3_E065 = null, 
			string m3_IFIN = null, 
			string m3_SUNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstIntItmVen",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_E0PA))
				request.WithQueryParameter("E0PA", m3_E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E065))
				request.WithQueryParameter("E065", m3_E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IFIN))
				request.WithQueryParameter("IFIN", m3_IFIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Execute the request
			var result = await Execute<LstIntItmVenResponse>(
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
		/// Name SndAddIntItmVen
		/// Description Send Add Interface Item Supplier
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_SITE">Supplier item number</param>
		/// <param name="m3_SITD">Supplier item name</param>
		/// <param name="m3_SITT">Supplier item description</param>
		/// <param name="m3_ISRS">Status - item/supplier</param>
		/// <param name="m3_LEA1">Supply lead time</param>
		/// <param name="m3_RFID">Reference</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_LOQT">Minimum order quantity</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_UVDT">Valid to</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_PUCD">Purchase price quantity</param>
		/// <param name="m3_SUPR">Setup price</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_ORCO">Country of origin</param>
		/// <param name="m3_ITFL">Item number flag</param>
		/// <param name="m3_ITAB">Item selection table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndAddIntItmVen(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			string m3_SUNO, 
			string m3_PRMD = null, 
			string m3_SITE = null, 
			string m3_SITD = null, 
			string m3_SITT = null, 
			string m3_ISRS = null, 
			int? m3_LEA1 = null, 
			string m3_RFID = null, 
			string m3_RESP = null, 
			decimal? m3_LOQT = null, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_UVDT = null, 
			decimal? m3_PUPR = null, 
			int? m3_PUCD = null, 
			decimal? m3_SUPR = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_TXID = null, 
			string m3_ORCO = null, 
			int? m3_ITFL = null, 
			string m3_ITAB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndAddIntItmVen",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SITE))
				request.WithQueryParameter("SITE", m3_SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SITD))
				request.WithQueryParameter("SITD", m3_SITD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SITT))
				request.WithQueryParameter("SITT", m3_SITT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ISRS))
				request.WithQueryParameter("ISRS", m3_ISRS.Trim());
			if (m3_LEA1.HasValue)
				request.WithQueryParameter("LEA1", m3_LEA1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RFID))
				request.WithQueryParameter("RFID", m3_RFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_LOQT.HasValue)
				request.WithQueryParameter("LOQT", m3_LOQT.Value.ToString());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_UVDT.HasValue)
				request.WithQueryParameter("UVDT", m3_UVDT.Value.ToM3String());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (m3_PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3_PUCD.Value.ToString());
			if (m3_SUPR.HasValue)
				request.WithQueryParameter("SUPR", m3_SUPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (m3_ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3_ITFL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITAB))
				request.WithQueryParameter("ITAB", m3_ITAB.Trim());

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
		/// Name SndChgIntItmVen
		/// Description Send Change Interface Item Supplier
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_SITE">Supplier item number</param>
		/// <param name="m3_SITD">Supplier item name</param>
		/// <param name="m3_SITT">Supplier item description</param>
		/// <param name="m3_ISRS">Status - item/supplier</param>
		/// <param name="m3_LEA1">Supply lead time</param>
		/// <param name="m3_RFID">Reference</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_LOQT">Minimum order quantity</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_UVDT">Valid to</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_PUCD">Purchase price quantity</param>
		/// <param name="m3_SUPR">Setup price</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_ORCO">Country of origin</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STIM">Start time</param>
		/// <param name="m3_ITFL">Item number flag</param>
		/// <param name="m3_ACFL">Add/change flag</param>
		/// <param name="m3_ITAB">Item selection table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndChgIntItmVen(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			string m3_SUNO, 
			string m3_PRMD = null, 
			string m3_SITE = null, 
			string m3_SITD = null, 
			string m3_SITT = null, 
			string m3_ISRS = null, 
			int? m3_LEA1 = null, 
			string m3_RFID = null, 
			string m3_RESP = null, 
			decimal? m3_LOQT = null, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_UVDT = null, 
			decimal? m3_PUPR = null, 
			int? m3_PUCD = null, 
			decimal? m3_SUPR = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_TXID = null, 
			string m3_ORCO = null, 
			DateTime? m3_STDT = null, 
			int? m3_STIM = null, 
			int? m3_ITFL = null, 
			int? m3_ACFL = null, 
			string m3_ITAB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndChgIntItmVen",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SITE))
				request.WithQueryParameter("SITE", m3_SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SITD))
				request.WithQueryParameter("SITD", m3_SITD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SITT))
				request.WithQueryParameter("SITT", m3_SITT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ISRS))
				request.WithQueryParameter("ISRS", m3_ISRS.Trim());
			if (m3_LEA1.HasValue)
				request.WithQueryParameter("LEA1", m3_LEA1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RFID))
				request.WithQueryParameter("RFID", m3_RFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_LOQT.HasValue)
				request.WithQueryParameter("LOQT", m3_LOQT.Value.ToString());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_UVDT.HasValue)
				request.WithQueryParameter("UVDT", m3_UVDT.Value.ToM3String());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (m3_PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3_PUCD.Value.ToString());
			if (m3_SUPR.HasValue)
				request.WithQueryParameter("SUPR", m3_SUPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STIM.HasValue)
				request.WithQueryParameter("STIM", m3_STIM.Value.ToString());
			if (m3_ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3_ITFL.Value.ToString());
			if (m3_ACFL.HasValue)
				request.WithQueryParameter("ACFL", m3_ACFL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITAB))
				request.WithQueryParameter("ITAB", m3_ITAB.Trim());

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
