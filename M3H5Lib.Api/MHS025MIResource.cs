/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MHS025MI;
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
	/// Name: MHS025MI
	/// Component Name: Interface Item/Alias
	/// Description: Api: Interface Item/Alias
	/// Version Release: 5ea0
	///</summary>
	public partial class MHS025MIResource : M3BaseResourceEndpoint
	{
		public MHS025MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MHS025MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddIntItmAli
		/// Description Add Interface Item Alias
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_ALWT">Alias category (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_POPN">Alias number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_SEA1">Season</param>
		/// <param name="m3_VFDT">Valid from</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_ALUN">Alternate U/M</param>
		/// <param name="m3_CNQT">Quantity</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_ORCO">Country of origin</param>
		/// <param name="m3_E0PB">Partner ID</param>
		/// <param name="m3_ITFL">Item number flag</param>
		/// <param name="m3_ITAB">Item selection table</param>
		/// <param name="m3_PRNA">Classification per season</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddIntItmAli(
			string m3_E0PA, 
			string m3_E065, 
			int m3_ALWT, 
			string m3_IFIN, 
			string m3_POPN, 
			string m3_PRMD = null, 
			string m3_ALWQ = null, 
			string m3_SEA1 = null, 
			DateTime? m3_VFDT = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_TXID = null, 
			string m3_ALUN = null, 
			decimal? m3_CNQT = null, 
			DateTime? m3_LVDT = null, 
			string m3_ORCO = null, 
			string m3_E0PB = null, 
			int? m3_ITFL = null, 
			string m3_ITAB = null, 
			string m3_PRNA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddIntItmAli",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");
			if (string.IsNullOrWhiteSpace(m3_POPN))
				throw new ArgumentNullException("m3_POPN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("ALWT", m3_ALWT.ToString())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("POPN", m3_POPN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SEA1))
				request.WithQueryParameter("SEA1", m3_SEA1.Trim());
			if (m3_VFDT.HasValue)
				request.WithQueryParameter("VFDT", m3_VFDT.Value.ToM3String());
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
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());
			if (m3_CNQT.HasValue)
				request.WithQueryParameter("CNQT", m3_CNQT.Value.ToString());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0PB))
				request.WithQueryParameter("E0PB", m3_E0PB.Trim());
			if (m3_ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3_ITFL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITAB))
				request.WithQueryParameter("ITAB", m3_ITAB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNA))
				request.WithQueryParameter("PRNA", m3_PRNA.Trim());

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
		/// Name ChgIntItmAli
		/// Description Change Interface Item Alias
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_ALWT">Alias category (Required)</param>
		/// <param name="m3_ALWQ">Alias qualifier (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_POPN">Alias number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_SEA1">Season</param>
		/// <param name="m3_VFDT">Valid from</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STIM">Start time</param>
		/// <param name="m3_ALUN">Alternate U/M</param>
		/// <param name="m3_CNQT">Quantity</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_ORCO">Country of origin</param>
		/// <param name="m3_E0PB">Partner ID</param>
		/// <param name="m3_ITFL">Item number flag</param>
		/// <param name="m3_ACFL">Add/change flag</param>
		/// <param name="m3_ITAB">Item selection table</param>
		/// <param name="m3_PRNA">Classification per season</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgIntItmAli(
			string m3_E0PA, 
			string m3_E065, 
			int m3_ALWT, 
			string m3_ALWQ, 
			string m3_IFIN, 
			string m3_POPN, 
			string m3_PRMD = null, 
			string m3_SEA1 = null, 
			DateTime? m3_VFDT = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_TXID = null, 
			DateTime? m3_STDT = null, 
			int? m3_STIM = null, 
			string m3_ALUN = null, 
			decimal? m3_CNQT = null, 
			DateTime? m3_LVDT = null, 
			string m3_ORCO = null, 
			string m3_E0PB = null, 
			int? m3_ITFL = null, 
			int? m3_ACFL = null, 
			string m3_ITAB = null, 
			string m3_PRNA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgIntItmAli",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_ALWQ))
				throw new ArgumentNullException("m3_ALWQ");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");
			if (string.IsNullOrWhiteSpace(m3_POPN))
				throw new ArgumentNullException("m3_POPN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("ALWT", m3_ALWT.ToString())
				.WithQueryParameter("ALWQ", m3_ALWQ.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("POPN", m3_POPN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SEA1))
				request.WithQueryParameter("SEA1", m3_SEA1.Trim());
			if (m3_VFDT.HasValue)
				request.WithQueryParameter("VFDT", m3_VFDT.Value.ToM3String());
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
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STIM.HasValue)
				request.WithQueryParameter("STIM", m3_STIM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());
			if (m3_CNQT.HasValue)
				request.WithQueryParameter("CNQT", m3_CNQT.Value.ToString());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0PB))
				request.WithQueryParameter("E0PB", m3_E0PB.Trim());
			if (m3_ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3_ITFL.Value.ToString());
			if (m3_ACFL.HasValue)
				request.WithQueryParameter("ACFL", m3_ACFL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITAB))
				request.WithQueryParameter("ITAB", m3_ITAB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNA))
				request.WithQueryParameter("PRNA", m3_PRNA.Trim());

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
		/// Name CpyIntItmAli
		/// Description Copy Interface Item Alias
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_ALWT">Alias category (Required)</param>
		/// <param name="m3_ALWQ">Alias qualifier (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_POPN">Alias number (Required)</param>
		/// <param name="m3_TE0P">Partner (Required)</param>
		/// <param name="m3_TE06">Message type (Required)</param>
		/// <param name="m3_TALT">Alias category (Required)</param>
		/// <param name="m3_TALQ">Alias qualifier (Required)</param>
		/// <param name="m3_TFIN">Interface item number (Required)</param>
		/// <param name="m3_TPOP">Alias number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyIntItmAli(
			string m3_E0PA, 
			string m3_E065, 
			int m3_ALWT, 
			string m3_ALWQ, 
			string m3_IFIN, 
			string m3_POPN, 
			string m3_TE0P, 
			string m3_TE06, 
			int m3_TALT, 
			string m3_TALQ, 
			string m3_TFIN, 
			string m3_TPOP, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyIntItmAli",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_ALWQ))
				throw new ArgumentNullException("m3_ALWQ");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");
			if (string.IsNullOrWhiteSpace(m3_POPN))
				throw new ArgumentNullException("m3_POPN");
			if (string.IsNullOrWhiteSpace(m3_TE0P))
				throw new ArgumentNullException("m3_TE0P");
			if (string.IsNullOrWhiteSpace(m3_TE06))
				throw new ArgumentNullException("m3_TE06");
			if (string.IsNullOrWhiteSpace(m3_TALQ))
				throw new ArgumentNullException("m3_TALQ");
			if (string.IsNullOrWhiteSpace(m3_TFIN))
				throw new ArgumentNullException("m3_TFIN");
			if (string.IsNullOrWhiteSpace(m3_TPOP))
				throw new ArgumentNullException("m3_TPOP");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("ALWT", m3_ALWT.ToString())
				.WithQueryParameter("ALWQ", m3_ALWQ.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("POPN", m3_POPN.Trim())
				.WithQueryParameter("TE0P", m3_TE0P.Trim())
				.WithQueryParameter("TE06", m3_TE06.Trim())
				.WithQueryParameter("TALT", m3_TALT.ToString())
				.WithQueryParameter("TALQ", m3_TALQ.Trim())
				.WithQueryParameter("TFIN", m3_TFIN.Trim())
				.WithQueryParameter("TPOP", m3_TPOP.Trim());

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
		/// Name DelIntItmAli
		/// Description Delete Interface Item Alias
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_ALWT">Alias category (Required)</param>
		/// <param name="m3_ALWQ">Alias qualifier (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_POPN">Alias number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelIntItmAli(
			string m3_E0PA, 
			string m3_E065, 
			int m3_ALWT, 
			string m3_ALWQ, 
			string m3_IFIN, 
			string m3_POPN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelIntItmAli",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_ALWQ))
				throw new ArgumentNullException("m3_ALWQ");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");
			if (string.IsNullOrWhiteSpace(m3_POPN))
				throw new ArgumentNullException("m3_POPN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("ALWT", m3_ALWT.ToString())
				.WithQueryParameter("ALWQ", m3_ALWQ.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("POPN", m3_POPN.Trim());

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
		/// Name GetIntItmAli
		/// Description Get Interface Item Alias
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_ALWT">Alias category (Required)</param>
		/// <param name="m3_ALWQ">Alias qualifier (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_POPN">Alias number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetIntItmAliResponse></returns>
		/// <exception cref="M3Exception<GetIntItmAliResponse>"></exception>
		public async Task<M3Response<GetIntItmAliResponse>> GetIntItmAli(
			string m3_E0PA, 
			string m3_E065, 
			int m3_ALWT, 
			string m3_ALWQ, 
			string m3_IFIN, 
			string m3_POPN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetIntItmAli",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_ALWQ))
				throw new ArgumentNullException("m3_ALWQ");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");
			if (string.IsNullOrWhiteSpace(m3_POPN))
				throw new ArgumentNullException("m3_POPN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("ALWT", m3_ALWT.ToString())
				.WithQueryParameter("ALWQ", m3_ALWQ.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("POPN", m3_POPN.Trim());

			// Execute the request
			var result = await Execute<GetIntItmAliResponse>(
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
		/// Name LstIntItmAli
		/// Description List Interface Item Alias
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_E0PA">Partner</param>
		/// <param name="m3_E065">Message type</param>
		/// <param name="m3_ALWT">Alias category</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_IFIN">Interface item number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstIntItmAliResponse></returns>
		/// <exception cref="M3Exception<LstIntItmAliResponse>"></exception>
		public async Task<M3Response<LstIntItmAliResponse>> LstIntItmAli(
			string m3_E0PA = null, 
			string m3_E065 = null, 
			int? m3_ALWT = null, 
			string m3_ALWQ = null, 
			string m3_IFIN = null, 
			string m3_POPN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstIntItmAli",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_E0PA))
				request.WithQueryParameter("E0PA", m3_E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E065))
				request.WithQueryParameter("E065", m3_E065.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IFIN))
				request.WithQueryParameter("IFIN", m3_IFIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());

			// Execute the request
			var result = await Execute<LstIntItmAliResponse>(
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
		/// Name SndAddIntItmAli
		/// Description Send Add Interface Item Alias
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_ALWT">Alias category (Required)</param>
		/// <param name="m3_ALWQ">Alias qualifier (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_POPN">Alias number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_SEA1">Season</param>
		/// <param name="m3_VFDT">Valid from</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_ALUN">Alternate U/M</param>
		/// <param name="m3_CNQT">Quantity</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_ORCO">Country of origin</param>
		/// <param name="m3_E0PB">Partner ID</param>
		/// <param name="m3_ITFL">Item number flag</param>
		/// <param name="m3_ITAB">Item selection table</param>
		/// <param name="m3_PRNA">Classification per season</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndAddIntItmAli(
			string m3_E0PA, 
			string m3_E065, 
			int m3_ALWT, 
			string m3_ALWQ, 
			string m3_IFIN, 
			string m3_POPN, 
			string m3_PRMD = null, 
			string m3_SEA1 = null, 
			DateTime? m3_VFDT = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_TXID = null, 
			string m3_ALUN = null, 
			decimal? m3_CNQT = null, 
			DateTime? m3_LVDT = null, 
			string m3_ORCO = null, 
			string m3_E0PB = null, 
			int? m3_ITFL = null, 
			string m3_ITAB = null, 
			string m3_PRNA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndAddIntItmAli",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_ALWQ))
				throw new ArgumentNullException("m3_ALWQ");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");
			if (string.IsNullOrWhiteSpace(m3_POPN))
				throw new ArgumentNullException("m3_POPN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("ALWT", m3_ALWT.ToString())
				.WithQueryParameter("ALWQ", m3_ALWQ.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("POPN", m3_POPN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SEA1))
				request.WithQueryParameter("SEA1", m3_SEA1.Trim());
			if (m3_VFDT.HasValue)
				request.WithQueryParameter("VFDT", m3_VFDT.Value.ToM3String());
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
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());
			if (m3_CNQT.HasValue)
				request.WithQueryParameter("CNQT", m3_CNQT.Value.ToString());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0PB))
				request.WithQueryParameter("E0PB", m3_E0PB.Trim());
			if (m3_ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3_ITFL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITAB))
				request.WithQueryParameter("ITAB", m3_ITAB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNA))
				request.WithQueryParameter("PRNA", m3_PRNA.Trim());

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
		/// Name SndChgIntItmAli
		/// Description Send Change Interface Item Alias
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_ALWT">Alias category (Required)</param>
		/// <param name="m3_ALWQ">Alias qualifier (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_POPN">Alias number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_SEA1">Season</param>
		/// <param name="m3_VFDT">Valid from</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STIM">Start time</param>
		/// <param name="m3_ALUN">Alternate U/M</param>
		/// <param name="m3_CNQT">Quantity</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_ORCO">Country of origin</param>
		/// <param name="m3_E0PB">Partner ID</param>
		/// <param name="m3_ITFL">Item number flag</param>
		/// <param name="m3_ACFL">Add/change flag</param>
		/// <param name="m3_ITAB">Item selection table</param>
		/// <param name="m3_PRNA">Classification per season</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndChgIntItmAli(
			string m3_E0PA, 
			string m3_E065, 
			int m3_ALWT, 
			string m3_ALWQ, 
			string m3_IFIN, 
			string m3_POPN, 
			string m3_PRMD = null, 
			string m3_SEA1 = null, 
			DateTime? m3_VFDT = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_TXID = null, 
			DateTime? m3_STDT = null, 
			int? m3_STIM = null, 
			string m3_ALUN = null, 
			decimal? m3_CNQT = null, 
			DateTime? m3_LVDT = null, 
			string m3_ORCO = null, 
			string m3_E0PB = null, 
			int? m3_ITFL = null, 
			int? m3_ACFL = null, 
			string m3_ITAB = null, 
			string m3_PRNA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndChgIntItmAli",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_ALWQ))
				throw new ArgumentNullException("m3_ALWQ");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");
			if (string.IsNullOrWhiteSpace(m3_POPN))
				throw new ArgumentNullException("m3_POPN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("ALWT", m3_ALWT.ToString())
				.WithQueryParameter("ALWQ", m3_ALWQ.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("POPN", m3_POPN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SEA1))
				request.WithQueryParameter("SEA1", m3_SEA1.Trim());
			if (m3_VFDT.HasValue)
				request.WithQueryParameter("VFDT", m3_VFDT.Value.ToM3String());
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
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STIM.HasValue)
				request.WithQueryParameter("STIM", m3_STIM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());
			if (m3_CNQT.HasValue)
				request.WithQueryParameter("CNQT", m3_CNQT.Value.ToString());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0PB))
				request.WithQueryParameter("E0PB", m3_E0PB.Trim());
			if (m3_ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3_ITFL.Value.ToString());
			if (m3_ACFL.HasValue)
				request.WithQueryParameter("ACFL", m3_ACFL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITAB))
				request.WithQueryParameter("ITAB", m3_ITAB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNA))
				request.WithQueryParameter("PRNA", m3_PRNA.Trim());

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
