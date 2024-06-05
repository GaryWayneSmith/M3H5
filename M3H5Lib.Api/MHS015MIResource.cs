/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MHS015MI;
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
	/// Name: MHS015MI
	/// Component Name: Interface Item/Alt U/M
	/// Description: Api: Interface Item/Alt U/M
	/// Version Release: 5ea0
	///</summary>
	public partial class MHS015MIResource : M3BaseResourceEndpoint
	{
		public MHS015MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MHS015MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddIntItmAum
		/// Description Add Interface Item  Alt U/M
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_AUTP">Alternate U/M type (Required)</param>
		/// <param name="m3_ALUN">Alternate U/M (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_COFA">Conversion factor</param>
		/// <param name="m3_DMCF">Conversion form</param>
		/// <param name="m3_DCCD">Number of decimal places</param>
		/// <param name="m3_UNMU">Order multiple</param>
		/// <param name="m3_PCOF">Price adjustment factor</param>
		/// <param name="m3_AUS1">Standard U/M - purchase order</param>
		/// <param name="m3_AUS2">Standard U/M - customer order sales</param>
		/// <param name="m3_AUS3">Standard U/M - manufacturing</param>
		/// <param name="m3_AUS4">Standard U/M - production engineering</param>
		/// <param name="m3_AUS6">Standard U/M - statistics</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_AUS5">Standard U/M - purchase price</param>
		/// <param name="m3_AUS9">Standard U/M - sales price</param>
		/// <param name="m3_ITFL">Item number flag</param>
		/// <param name="m3_ITAB">Item selection table</param>
		/// <param name="m3_CWPU">Catch weight price U/M</param>
		/// <param name="m3_AUSB">Standard U/M - cost</param>
		/// <param name="m3_AUSC">Standard U/M - catch weight</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddIntItmAum(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			int m3_AUTP, 
			string m3_ALUN, 
			string m3_PRMD = null, 
			decimal? m3_COFA = null, 
			int? m3_DMCF = null, 
			int? m3_DCCD = null, 
			decimal? m3_UNMU = null, 
			decimal? m3_PCOF = null, 
			int? m3_AUS1 = null, 
			int? m3_AUS2 = null, 
			int? m3_AUS3 = null, 
			int? m3_AUS4 = null, 
			int? m3_AUS6 = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_TXID = null, 
			int? m3_AUS5 = null, 
			int? m3_AUS9 = null, 
			int? m3_ITFL = null, 
			string m3_ITAB = null, 
			int? m3_CWPU = null, 
			int? m3_AUSB = null, 
			int? m3_AUSC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddIntItmAum",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");
			if (string.IsNullOrWhiteSpace(m3_ALUN))
				throw new ArgumentNullException("m3_ALUN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("AUTP", m3_AUTP.ToString())
				.WithQueryParameter("ALUN", m3_ALUN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (m3_COFA.HasValue)
				request.WithQueryParameter("COFA", m3_COFA.Value.ToString());
			if (m3_DMCF.HasValue)
				request.WithQueryParameter("DMCF", m3_DMCF.Value.ToString());
			if (m3_DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3_DCCD.Value.ToString());
			if (m3_UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3_UNMU.Value.ToString());
			if (m3_PCOF.HasValue)
				request.WithQueryParameter("PCOF", m3_PCOF.Value.ToString());
			if (m3_AUS1.HasValue)
				request.WithQueryParameter("AUS1", m3_AUS1.Value.ToString());
			if (m3_AUS2.HasValue)
				request.WithQueryParameter("AUS2", m3_AUS2.Value.ToString());
			if (m3_AUS3.HasValue)
				request.WithQueryParameter("AUS3", m3_AUS3.Value.ToString());
			if (m3_AUS4.HasValue)
				request.WithQueryParameter("AUS4", m3_AUS4.Value.ToString());
			if (m3_AUS6.HasValue)
				request.WithQueryParameter("AUS6", m3_AUS6.Value.ToString());
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
			if (m3_AUS5.HasValue)
				request.WithQueryParameter("AUS5", m3_AUS5.Value.ToString());
			if (m3_AUS9.HasValue)
				request.WithQueryParameter("AUS9", m3_AUS9.Value.ToString());
			if (m3_ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3_ITFL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITAB))
				request.WithQueryParameter("ITAB", m3_ITAB.Trim());
			if (m3_CWPU.HasValue)
				request.WithQueryParameter("CWPU", m3_CWPU.Value.ToString());
			if (m3_AUSB.HasValue)
				request.WithQueryParameter("AUSB", m3_AUSB.Value.ToString());
			if (m3_AUSC.HasValue)
				request.WithQueryParameter("AUSC", m3_AUSC.Value.ToString());

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
		/// Name ChgIntItmAum
		/// Description Change Interface Item Alt U/M
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_AUTP">Alternate U/M type (Required)</param>
		/// <param name="m3_ALUN">Alternate U/M (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_COFA">Conversion factor</param>
		/// <param name="m3_DMCF">Conversion form</param>
		/// <param name="m3_DCCD">Number of decimal places</param>
		/// <param name="m3_UNMU">Order multiple</param>
		/// <param name="m3_PCOF">Price adjustment factor</param>
		/// <param name="m3_AUS1">Standard U/M - purchase order</param>
		/// <param name="m3_AUS2">Standard U/M - customer order sales</param>
		/// <param name="m3_AUS3">Standard U/M - manufacturing</param>
		/// <param name="m3_AUS4">Standard U/M - production engineering</param>
		/// <param name="m3_AUS6">Standard U/M - statistics</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STIM">Start time</param>
		/// <param name="m3_AUS5">Standard U/M - purchase price</param>
		/// <param name="m3_AUS9">Standard U/M - sales price</param>
		/// <param name="m3_ITFL">Item number flag</param>
		/// <param name="m3_ACFL">Add/change flag</param>
		/// <param name="m3_ITAB">Item selection table</param>
		/// <param name="m3_CWPU">Catch weight price U/M</param>
		/// <param name="m3_AUSB">Standard U/M - cost</param>
		/// <param name="m3_AUSC">Standard U/M - catch weight</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgIntItmAum(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			int m3_AUTP, 
			string m3_ALUN, 
			string m3_PRMD = null, 
			decimal? m3_COFA = null, 
			int? m3_DMCF = null, 
			int? m3_DCCD = null, 
			decimal? m3_UNMU = null, 
			decimal? m3_PCOF = null, 
			int? m3_AUS1 = null, 
			int? m3_AUS2 = null, 
			int? m3_AUS3 = null, 
			int? m3_AUS4 = null, 
			int? m3_AUS6 = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_TXID = null, 
			DateTime? m3_STDT = null, 
			int? m3_STIM = null, 
			int? m3_AUS5 = null, 
			int? m3_AUS9 = null, 
			int? m3_ITFL = null, 
			int? m3_ACFL = null, 
			string m3_ITAB = null, 
			int? m3_CWPU = null, 
			int? m3_AUSB = null, 
			int? m3_AUSC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgIntItmAum",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");
			if (string.IsNullOrWhiteSpace(m3_ALUN))
				throw new ArgumentNullException("m3_ALUN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("AUTP", m3_AUTP.ToString())
				.WithQueryParameter("ALUN", m3_ALUN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (m3_COFA.HasValue)
				request.WithQueryParameter("COFA", m3_COFA.Value.ToString());
			if (m3_DMCF.HasValue)
				request.WithQueryParameter("DMCF", m3_DMCF.Value.ToString());
			if (m3_DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3_DCCD.Value.ToString());
			if (m3_UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3_UNMU.Value.ToString());
			if (m3_PCOF.HasValue)
				request.WithQueryParameter("PCOF", m3_PCOF.Value.ToString());
			if (m3_AUS1.HasValue)
				request.WithQueryParameter("AUS1", m3_AUS1.Value.ToString());
			if (m3_AUS2.HasValue)
				request.WithQueryParameter("AUS2", m3_AUS2.Value.ToString());
			if (m3_AUS3.HasValue)
				request.WithQueryParameter("AUS3", m3_AUS3.Value.ToString());
			if (m3_AUS4.HasValue)
				request.WithQueryParameter("AUS4", m3_AUS4.Value.ToString());
			if (m3_AUS6.HasValue)
				request.WithQueryParameter("AUS6", m3_AUS6.Value.ToString());
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
			if (m3_AUS5.HasValue)
				request.WithQueryParameter("AUS5", m3_AUS5.Value.ToString());
			if (m3_AUS9.HasValue)
				request.WithQueryParameter("AUS9", m3_AUS9.Value.ToString());
			if (m3_ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3_ITFL.Value.ToString());
			if (m3_ACFL.HasValue)
				request.WithQueryParameter("ACFL", m3_ACFL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITAB))
				request.WithQueryParameter("ITAB", m3_ITAB.Trim());
			if (m3_CWPU.HasValue)
				request.WithQueryParameter("CWPU", m3_CWPU.Value.ToString());
			if (m3_AUSB.HasValue)
				request.WithQueryParameter("AUSB", m3_AUSB.Value.ToString());
			if (m3_AUSC.HasValue)
				request.WithQueryParameter("AUSC", m3_AUSC.Value.ToString());

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
		/// Name CpyIntItmAum
		/// Description Copy Interface Item Alt U/M
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_AUTP">Alternate U/M type (Required)</param>
		/// <param name="m3_ALUN">Alternate U/M (Required)</param>
		/// <param name="m3_TE0P">Partner (Required)</param>
		/// <param name="m3_TE06">Message type (Required)</param>
		/// <param name="m3_TFIN">Interface item number (Required)</param>
		/// <param name="m3_TAUT">Alternate U/M type (Required)</param>
		/// <param name="m3_TALU">Alternate U/M (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyIntItmAum(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			int m3_AUTP, 
			string m3_ALUN, 
			string m3_TE0P, 
			string m3_TE06, 
			string m3_TFIN, 
			int m3_TAUT, 
			string m3_TALU, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyIntItmAum",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");
			if (string.IsNullOrWhiteSpace(m3_ALUN))
				throw new ArgumentNullException("m3_ALUN");
			if (string.IsNullOrWhiteSpace(m3_TE0P))
				throw new ArgumentNullException("m3_TE0P");
			if (string.IsNullOrWhiteSpace(m3_TE06))
				throw new ArgumentNullException("m3_TE06");
			if (string.IsNullOrWhiteSpace(m3_TFIN))
				throw new ArgumentNullException("m3_TFIN");
			if (string.IsNullOrWhiteSpace(m3_TALU))
				throw new ArgumentNullException("m3_TALU");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("AUTP", m3_AUTP.ToString())
				.WithQueryParameter("ALUN", m3_ALUN.Trim())
				.WithQueryParameter("TE0P", m3_TE0P.Trim())
				.WithQueryParameter("TE06", m3_TE06.Trim())
				.WithQueryParameter("TFIN", m3_TFIN.Trim())
				.WithQueryParameter("TAUT", m3_TAUT.ToString())
				.WithQueryParameter("TALU", m3_TALU.Trim());

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
		/// Name DelIntItmAum
		/// Description Delete Interface Item Alt U/M
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_AUTP">Alternate U/M type (Required)</param>
		/// <param name="m3_ALUN">Alternate U/M (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelIntItmAum(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			int m3_AUTP, 
			string m3_ALUN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelIntItmAum",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");
			if (string.IsNullOrWhiteSpace(m3_ALUN))
				throw new ArgumentNullException("m3_ALUN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("AUTP", m3_AUTP.ToString())
				.WithQueryParameter("ALUN", m3_ALUN.Trim());

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
		/// Name GetIntItmAum
		/// Description Get Interface Item Alt U/M
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_AUTP">Alternate U/M type (Required)</param>
		/// <param name="m3_ALUN">Alternate U/M (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetIntItmAumResponse></returns>
		/// <exception cref="M3Exception<GetIntItmAumResponse>"></exception>
		public async Task<M3Response<GetIntItmAumResponse>> GetIntItmAum(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			int m3_AUTP, 
			string m3_ALUN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetIntItmAum",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");
			if (string.IsNullOrWhiteSpace(m3_ALUN))
				throw new ArgumentNullException("m3_ALUN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("AUTP", m3_AUTP.ToString())
				.WithQueryParameter("ALUN", m3_ALUN.Trim());

			// Execute the request
			var result = await Execute<GetIntItmAumResponse>(
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
		/// Name LstIntItmAum
		/// Description List Interface Item Alt U/M
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner</param>
		/// <param name="m3_E065">Message type</param>
		/// <param name="m3_IFIN">Interface item number</param>
		/// <param name="m3_AUTP">Alternate U/M type</param>
		/// <param name="m3_ALUN">Alternate U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstIntItmAumResponse></returns>
		/// <exception cref="M3Exception<LstIntItmAumResponse>"></exception>
		public async Task<M3Response<LstIntItmAumResponse>> LstIntItmAum(
			string m3_E0PA = null, 
			string m3_E065 = null, 
			string m3_IFIN = null, 
			int? m3_AUTP = null, 
			string m3_ALUN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstIntItmAum",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_E0PA))
				request.WithQueryParameter("E0PA", m3_E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E065))
				request.WithQueryParameter("E065", m3_E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IFIN))
				request.WithQueryParameter("IFIN", m3_IFIN.Trim());
			if (m3_AUTP.HasValue)
				request.WithQueryParameter("AUTP", m3_AUTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());

			// Execute the request
			var result = await Execute<LstIntItmAumResponse>(
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
		/// Name SndAddIntItmAum
		/// Description Send Add Interface Item  Alt U/M
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_AUTP">Alternate U/M type (Required)</param>
		/// <param name="m3_ALUN">Alternate U/M (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_COFA">Conversion factor</param>
		/// <param name="m3_DMCF">Conversion form</param>
		/// <param name="m3_DCCD">Number of decimal places</param>
		/// <param name="m3_UNMU">Order multiple</param>
		/// <param name="m3_PCOF">Price adjustment factor</param>
		/// <param name="m3_AUS1">Standard U/M - purchase order</param>
		/// <param name="m3_AUS2">Standard U/M - customer order sales</param>
		/// <param name="m3_AUS3">Standard U/M - manufacturing</param>
		/// <param name="m3_AUS4">Standard U/M - production engineering</param>
		/// <param name="m3_AUS6">Standard U/M - statistics</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_AUS5">Standard U/M - purchase price</param>
		/// <param name="m3_AUS9">Standard U/M - sales price</param>
		/// <param name="m3_ITFL">Item number flag</param>
		/// <param name="m3_ITAB">Item selection table</param>
		/// <param name="m3_CWPU">Catch weight price U/M</param>
		/// <param name="m3_AUSB">Standard U/M - cost</param>
		/// <param name="m3_AUSC">Standard U/M - catch weight</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndAddIntItmAum(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			int m3_AUTP, 
			string m3_ALUN, 
			string m3_PRMD = null, 
			decimal? m3_COFA = null, 
			int? m3_DMCF = null, 
			int? m3_DCCD = null, 
			decimal? m3_UNMU = null, 
			decimal? m3_PCOF = null, 
			int? m3_AUS1 = null, 
			int? m3_AUS2 = null, 
			int? m3_AUS3 = null, 
			int? m3_AUS4 = null, 
			int? m3_AUS6 = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_TXID = null, 
			int? m3_AUS5 = null, 
			int? m3_AUS9 = null, 
			int? m3_ITFL = null, 
			string m3_ITAB = null, 
			int? m3_CWPU = null, 
			int? m3_AUSB = null, 
			int? m3_AUSC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndAddIntItmAum",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");
			if (string.IsNullOrWhiteSpace(m3_ALUN))
				throw new ArgumentNullException("m3_ALUN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("AUTP", m3_AUTP.ToString())
				.WithQueryParameter("ALUN", m3_ALUN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (m3_COFA.HasValue)
				request.WithQueryParameter("COFA", m3_COFA.Value.ToString());
			if (m3_DMCF.HasValue)
				request.WithQueryParameter("DMCF", m3_DMCF.Value.ToString());
			if (m3_DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3_DCCD.Value.ToString());
			if (m3_UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3_UNMU.Value.ToString());
			if (m3_PCOF.HasValue)
				request.WithQueryParameter("PCOF", m3_PCOF.Value.ToString());
			if (m3_AUS1.HasValue)
				request.WithQueryParameter("AUS1", m3_AUS1.Value.ToString());
			if (m3_AUS2.HasValue)
				request.WithQueryParameter("AUS2", m3_AUS2.Value.ToString());
			if (m3_AUS3.HasValue)
				request.WithQueryParameter("AUS3", m3_AUS3.Value.ToString());
			if (m3_AUS4.HasValue)
				request.WithQueryParameter("AUS4", m3_AUS4.Value.ToString());
			if (m3_AUS6.HasValue)
				request.WithQueryParameter("AUS6", m3_AUS6.Value.ToString());
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
			if (m3_AUS5.HasValue)
				request.WithQueryParameter("AUS5", m3_AUS5.Value.ToString());
			if (m3_AUS9.HasValue)
				request.WithQueryParameter("AUS9", m3_AUS9.Value.ToString());
			if (m3_ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3_ITFL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITAB))
				request.WithQueryParameter("ITAB", m3_ITAB.Trim());
			if (m3_CWPU.HasValue)
				request.WithQueryParameter("CWPU", m3_CWPU.Value.ToString());
			if (m3_AUSB.HasValue)
				request.WithQueryParameter("AUSB", m3_AUSB.Value.ToString());
			if (m3_AUSC.HasValue)
				request.WithQueryParameter("AUSC", m3_AUSC.Value.ToString());

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
		/// Name SndChgIntItmAum
		/// Description Send Change Interface Item Alt U/M
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_AUTP">Alternate U/M type (Required)</param>
		/// <param name="m3_ALUN">Alternate U/M (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_COFA">Conversion factor</param>
		/// <param name="m3_DMCF">Conversion form</param>
		/// <param name="m3_DCCD">Number of decimal places</param>
		/// <param name="m3_UNMU">Order multiple</param>
		/// <param name="m3_PCOF">Price adjustment factor</param>
		/// <param name="m3_AUS1">Standard U/M - purchase order</param>
		/// <param name="m3_AUS2">Standard U/M - customer order sales</param>
		/// <param name="m3_AUS3">Standard U/M - manufacturing</param>
		/// <param name="m3_AUS4">Standard U/M - production engineering</param>
		/// <param name="m3_AUS6">Standard U/M - statistics</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STIM">Start time</param>
		/// <param name="m3_AUS5">Standard U/M - purchase price</param>
		/// <param name="m3_AUS9">Standard U/M - sales price</param>
		/// <param name="m3_ITFL">Item number flag</param>
		/// <param name="m3_ACFL">Add/change flag</param>
		/// <param name="m3_ITAB">Item selection table</param>
		/// <param name="m3_CWPU">Catch weight price U/M</param>
		/// <param name="m3_AUSB">Standard U/M - cost</param>
		/// <param name="m3_AUSC">Standard U/M - catch weight</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndChgIntItmAum(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			int m3_AUTP, 
			string m3_ALUN, 
			string m3_PRMD = null, 
			decimal? m3_COFA = null, 
			int? m3_DMCF = null, 
			int? m3_DCCD = null, 
			decimal? m3_UNMU = null, 
			decimal? m3_PCOF = null, 
			int? m3_AUS1 = null, 
			int? m3_AUS2 = null, 
			int? m3_AUS3 = null, 
			int? m3_AUS4 = null, 
			int? m3_AUS6 = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_TXID = null, 
			DateTime? m3_STDT = null, 
			int? m3_STIM = null, 
			int? m3_AUS5 = null, 
			int? m3_AUS9 = null, 
			int? m3_ITFL = null, 
			int? m3_ACFL = null, 
			string m3_ITAB = null, 
			int? m3_CWPU = null, 
			int? m3_AUSB = null, 
			int? m3_AUSC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndChgIntItmAum",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");
			if (string.IsNullOrWhiteSpace(m3_ALUN))
				throw new ArgumentNullException("m3_ALUN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("AUTP", m3_AUTP.ToString())
				.WithQueryParameter("ALUN", m3_ALUN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (m3_COFA.HasValue)
				request.WithQueryParameter("COFA", m3_COFA.Value.ToString());
			if (m3_DMCF.HasValue)
				request.WithQueryParameter("DMCF", m3_DMCF.Value.ToString());
			if (m3_DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3_DCCD.Value.ToString());
			if (m3_UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3_UNMU.Value.ToString());
			if (m3_PCOF.HasValue)
				request.WithQueryParameter("PCOF", m3_PCOF.Value.ToString());
			if (m3_AUS1.HasValue)
				request.WithQueryParameter("AUS1", m3_AUS1.Value.ToString());
			if (m3_AUS2.HasValue)
				request.WithQueryParameter("AUS2", m3_AUS2.Value.ToString());
			if (m3_AUS3.HasValue)
				request.WithQueryParameter("AUS3", m3_AUS3.Value.ToString());
			if (m3_AUS4.HasValue)
				request.WithQueryParameter("AUS4", m3_AUS4.Value.ToString());
			if (m3_AUS6.HasValue)
				request.WithQueryParameter("AUS6", m3_AUS6.Value.ToString());
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
			if (m3_AUS5.HasValue)
				request.WithQueryParameter("AUS5", m3_AUS5.Value.ToString());
			if (m3_AUS9.HasValue)
				request.WithQueryParameter("AUS9", m3_AUS9.Value.ToString());
			if (m3_ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3_ITFL.Value.ToString());
			if (m3_ACFL.HasValue)
				request.WithQueryParameter("ACFL", m3_ACFL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITAB))
				request.WithQueryParameter("ITAB", m3_ITAB.Trim());
			if (m3_CWPU.HasValue)
				request.WithQueryParameter("CWPU", m3_CWPU.Value.ToString());
			if (m3_AUSB.HasValue)
				request.WithQueryParameter("AUSB", m3_AUSB.Value.ToString());
			if (m3_AUSC.HasValue)
				request.WithQueryParameter("AUSC", m3_AUSC.Value.ToString());

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
