/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3AUTP">Alternate U/M type (Required)</param>
		/// <param name="m3ALUN">Alternate U/M (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3COFA">Conversion factor</param>
		/// <param name="m3DMCF">Conversion form</param>
		/// <param name="m3DCCD">Number of decimal places</param>
		/// <param name="m3UNMU">Order multiple</param>
		/// <param name="m3PCOF">Price adjustment factor</param>
		/// <param name="m3AUS1">Standard U/M - purchase order</param>
		/// <param name="m3AUS2">Standard U/M - customer order sales</param>
		/// <param name="m3AUS3">Standard U/M - manufacturing</param>
		/// <param name="m3AUS4">Standard U/M - production engineering</param>
		/// <param name="m3AUS6">Standard U/M - statistics</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3AUS5">Standard U/M - purchase price</param>
		/// <param name="m3AUS9">Standard U/M - sales price</param>
		/// <param name="m3ITFL">Item number flag</param>
		/// <param name="m3ITAB">Item selection table</param>
		/// <param name="m3CWPU">Catch weight price U/M</param>
		/// <param name="m3AUSB">Standard U/M - cost</param>
		/// <param name="m3AUSC">Standard U/M - catch weight</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddIntItmAum(
			string m3E0PA, 
			string m3E065, 
			string m3IFIN, 
			int m3AUTP, 
			string m3ALUN, 
			string m3PRMD = null, 
			decimal? m3COFA = null, 
			int? m3DMCF = null, 
			int? m3DCCD = null, 
			decimal? m3UNMU = null, 
			decimal? m3PCOF = null, 
			int? m3AUS1 = null, 
			int? m3AUS2 = null, 
			int? m3AUS3 = null, 
			int? m3AUS4 = null, 
			int? m3AUS6 = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			decimal? m3TXID = null, 
			int? m3AUS5 = null, 
			int? m3AUS9 = null, 
			int? m3ITFL = null, 
			string m3ITAB = null, 
			int? m3CWPU = null, 
			int? m3AUSB = null, 
			int? m3AUSC = null, 
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
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));
			if (string.IsNullOrWhiteSpace(m3ALUN))
				throw new ArgumentNullException(nameof(m3ALUN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim())
				.WithQueryParameter("AUTP", m3AUTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ALUN", m3ALUN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (m3COFA.HasValue)
				request.WithQueryParameter("COFA", m3COFA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DMCF.HasValue)
				request.WithQueryParameter("DMCF", m3DMCF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3DCCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3UNMU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PCOF.HasValue)
				request.WithQueryParameter("PCOF", m3PCOF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS1.HasValue)
				request.WithQueryParameter("AUS1", m3AUS1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS2.HasValue)
				request.WithQueryParameter("AUS2", m3AUS2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS3.HasValue)
				request.WithQueryParameter("AUS3", m3AUS3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS4.HasValue)
				request.WithQueryParameter("AUS4", m3AUS4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS6.HasValue)
				request.WithQueryParameter("AUS6", m3AUS6.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS5.HasValue)
				request.WithQueryParameter("AUS5", m3AUS5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS9.HasValue)
				request.WithQueryParameter("AUS9", m3AUS9.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3ITFL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITAB))
				request.WithQueryParameter("ITAB", m3ITAB.Trim());
			if (m3CWPU.HasValue)
				request.WithQueryParameter("CWPU", m3CWPU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUSB.HasValue)
				request.WithQueryParameter("AUSB", m3AUSB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUSC.HasValue)
				request.WithQueryParameter("AUSC", m3AUSC.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgIntItmAum
		/// Description Change Interface Item Alt U/M
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3AUTP">Alternate U/M type (Required)</param>
		/// <param name="m3ALUN">Alternate U/M (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3COFA">Conversion factor</param>
		/// <param name="m3DMCF">Conversion form</param>
		/// <param name="m3DCCD">Number of decimal places</param>
		/// <param name="m3UNMU">Order multiple</param>
		/// <param name="m3PCOF">Price adjustment factor</param>
		/// <param name="m3AUS1">Standard U/M - purchase order</param>
		/// <param name="m3AUS2">Standard U/M - customer order sales</param>
		/// <param name="m3AUS3">Standard U/M - manufacturing</param>
		/// <param name="m3AUS4">Standard U/M - production engineering</param>
		/// <param name="m3AUS6">Standard U/M - statistics</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3STIM">Start time</param>
		/// <param name="m3AUS5">Standard U/M - purchase price</param>
		/// <param name="m3AUS9">Standard U/M - sales price</param>
		/// <param name="m3ITFL">Item number flag</param>
		/// <param name="m3ACFL">Add/change flag</param>
		/// <param name="m3ITAB">Item selection table</param>
		/// <param name="m3CWPU">Catch weight price U/M</param>
		/// <param name="m3AUSB">Standard U/M - cost</param>
		/// <param name="m3AUSC">Standard U/M - catch weight</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgIntItmAum(
			string m3E0PA, 
			string m3E065, 
			string m3IFIN, 
			int m3AUTP, 
			string m3ALUN, 
			string m3PRMD = null, 
			decimal? m3COFA = null, 
			int? m3DMCF = null, 
			int? m3DCCD = null, 
			decimal? m3UNMU = null, 
			decimal? m3PCOF = null, 
			int? m3AUS1 = null, 
			int? m3AUS2 = null, 
			int? m3AUS3 = null, 
			int? m3AUS4 = null, 
			int? m3AUS6 = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			decimal? m3TXID = null, 
			DateTime? m3STDT = null, 
			int? m3STIM = null, 
			int? m3AUS5 = null, 
			int? m3AUS9 = null, 
			int? m3ITFL = null, 
			int? m3ACFL = null, 
			string m3ITAB = null, 
			int? m3CWPU = null, 
			int? m3AUSB = null, 
			int? m3AUSC = null, 
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
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));
			if (string.IsNullOrWhiteSpace(m3ALUN))
				throw new ArgumentNullException(nameof(m3ALUN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim())
				.WithQueryParameter("AUTP", m3AUTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ALUN", m3ALUN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (m3COFA.HasValue)
				request.WithQueryParameter("COFA", m3COFA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DMCF.HasValue)
				request.WithQueryParameter("DMCF", m3DMCF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3DCCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3UNMU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PCOF.HasValue)
				request.WithQueryParameter("PCOF", m3PCOF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS1.HasValue)
				request.WithQueryParameter("AUS1", m3AUS1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS2.HasValue)
				request.WithQueryParameter("AUS2", m3AUS2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS3.HasValue)
				request.WithQueryParameter("AUS3", m3AUS3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS4.HasValue)
				request.WithQueryParameter("AUS4", m3AUS4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS6.HasValue)
				request.WithQueryParameter("AUS6", m3AUS6.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3STIM.HasValue)
				request.WithQueryParameter("STIM", m3STIM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS5.HasValue)
				request.WithQueryParameter("AUS5", m3AUS5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS9.HasValue)
				request.WithQueryParameter("AUS9", m3AUS9.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3ITFL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACFL.HasValue)
				request.WithQueryParameter("ACFL", m3ACFL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITAB))
				request.WithQueryParameter("ITAB", m3ITAB.Trim());
			if (m3CWPU.HasValue)
				request.WithQueryParameter("CWPU", m3CWPU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUSB.HasValue)
				request.WithQueryParameter("AUSB", m3AUSB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUSC.HasValue)
				request.WithQueryParameter("AUSC", m3AUSC.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name CpyIntItmAum
		/// Description Copy Interface Item Alt U/M
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3AUTP">Alternate U/M type (Required)</param>
		/// <param name="m3ALUN">Alternate U/M (Required)</param>
		/// <param name="m3TE0P">Partner (Required)</param>
		/// <param name="m3TE06">Message type (Required)</param>
		/// <param name="m3TFIN">Interface item number (Required)</param>
		/// <param name="m3TAUT">Alternate U/M type (Required)</param>
		/// <param name="m3TALU">Alternate U/M (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyIntItmAum(
			string m3E0PA, 
			string m3E065, 
			string m3IFIN, 
			int m3AUTP, 
			string m3ALUN, 
			string m3TE0P, 
			string m3TE06, 
			string m3TFIN, 
			int m3TAUT, 
			string m3TALU, 
			string m3PRMD = null, 
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
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));
			if (string.IsNullOrWhiteSpace(m3ALUN))
				throw new ArgumentNullException(nameof(m3ALUN));
			if (string.IsNullOrWhiteSpace(m3TE0P))
				throw new ArgumentNullException(nameof(m3TE0P));
			if (string.IsNullOrWhiteSpace(m3TE06))
				throw new ArgumentNullException(nameof(m3TE06));
			if (string.IsNullOrWhiteSpace(m3TFIN))
				throw new ArgumentNullException(nameof(m3TFIN));
			if (string.IsNullOrWhiteSpace(m3TALU))
				throw new ArgumentNullException(nameof(m3TALU));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim())
				.WithQueryParameter("AUTP", m3AUTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ALUN", m3ALUN.Trim())
				.WithQueryParameter("TE0P", m3TE0P.Trim())
				.WithQueryParameter("TE06", m3TE06.Trim())
				.WithQueryParameter("TFIN", m3TFIN.Trim())
				.WithQueryParameter("TAUT", m3TAUT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TALU", m3TALU.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());

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
		/// Name DelIntItmAum
		/// Description Delete Interface Item Alt U/M
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3AUTP">Alternate U/M type (Required)</param>
		/// <param name="m3ALUN">Alternate U/M (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelIntItmAum(
			string m3E0PA, 
			string m3E065, 
			string m3IFIN, 
			int m3AUTP, 
			string m3ALUN, 
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
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));
			if (string.IsNullOrWhiteSpace(m3ALUN))
				throw new ArgumentNullException(nameof(m3ALUN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim())
				.WithQueryParameter("AUTP", m3AUTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ALUN", m3ALUN.Trim());

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
		/// Name GetIntItmAum
		/// Description Get Interface Item Alt U/M
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3AUTP">Alternate U/M type (Required)</param>
		/// <param name="m3ALUN">Alternate U/M (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetIntItmAumResponse></returns>
		/// <exception cref="M3Exception<GetIntItmAumResponse>"></exception>
		public async Task<M3Response<GetIntItmAumResponse>> GetIntItmAum(
			string m3E0PA, 
			string m3E065, 
			string m3IFIN, 
			int m3AUTP, 
			string m3ALUN, 
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
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));
			if (string.IsNullOrWhiteSpace(m3ALUN))
				throw new ArgumentNullException(nameof(m3ALUN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim())
				.WithQueryParameter("AUTP", m3AUTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ALUN", m3ALUN.Trim());

			// Execute the request
			var result = await Execute<GetIntItmAumResponse>(
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
		/// Name LstIntItmAum
		/// Description List Interface Item Alt U/M
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner</param>
		/// <param name="m3E065">Message type</param>
		/// <param name="m3IFIN">Interface item number</param>
		/// <param name="m3AUTP">Alternate U/M type</param>
		/// <param name="m3ALUN">Alternate U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstIntItmAumResponse></returns>
		/// <exception cref="M3Exception<LstIntItmAumResponse>"></exception>
		public async Task<M3Response<LstIntItmAumResponse>> LstIntItmAum(
			string m3E0PA = null, 
			string m3E065 = null, 
			string m3IFIN = null, 
			int? m3AUTP = null, 
			string m3ALUN = null, 
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
			if (!string.IsNullOrWhiteSpace(m3E0PA))
				request.WithQueryParameter("E0PA", m3E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3E065))
				request.WithQueryParameter("E065", m3E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3IFIN))
				request.WithQueryParameter("IFIN", m3IFIN.Trim());
			if (m3AUTP.HasValue)
				request.WithQueryParameter("AUTP", m3AUTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALUN))
				request.WithQueryParameter("ALUN", m3ALUN.Trim());

			// Execute the request
			var result = await Execute<LstIntItmAumResponse>(
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
		/// Name SndAddIntItmAum
		/// Description Send Add Interface Item  Alt U/M
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3AUTP">Alternate U/M type (Required)</param>
		/// <param name="m3ALUN">Alternate U/M (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3COFA">Conversion factor</param>
		/// <param name="m3DMCF">Conversion form</param>
		/// <param name="m3DCCD">Number of decimal places</param>
		/// <param name="m3UNMU">Order multiple</param>
		/// <param name="m3PCOF">Price adjustment factor</param>
		/// <param name="m3AUS1">Standard U/M - purchase order</param>
		/// <param name="m3AUS2">Standard U/M - customer order sales</param>
		/// <param name="m3AUS3">Standard U/M - manufacturing</param>
		/// <param name="m3AUS4">Standard U/M - production engineering</param>
		/// <param name="m3AUS6">Standard U/M - statistics</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3AUS5">Standard U/M - purchase price</param>
		/// <param name="m3AUS9">Standard U/M - sales price</param>
		/// <param name="m3ITFL">Item number flag</param>
		/// <param name="m3ITAB">Item selection table</param>
		/// <param name="m3CWPU">Catch weight price U/M</param>
		/// <param name="m3AUSB">Standard U/M - cost</param>
		/// <param name="m3AUSC">Standard U/M - catch weight</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndAddIntItmAum(
			string m3E0PA, 
			string m3E065, 
			string m3IFIN, 
			int m3AUTP, 
			string m3ALUN, 
			string m3PRMD = null, 
			decimal? m3COFA = null, 
			int? m3DMCF = null, 
			int? m3DCCD = null, 
			decimal? m3UNMU = null, 
			decimal? m3PCOF = null, 
			int? m3AUS1 = null, 
			int? m3AUS2 = null, 
			int? m3AUS3 = null, 
			int? m3AUS4 = null, 
			int? m3AUS6 = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			decimal? m3TXID = null, 
			int? m3AUS5 = null, 
			int? m3AUS9 = null, 
			int? m3ITFL = null, 
			string m3ITAB = null, 
			int? m3CWPU = null, 
			int? m3AUSB = null, 
			int? m3AUSC = null, 
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
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));
			if (string.IsNullOrWhiteSpace(m3ALUN))
				throw new ArgumentNullException(nameof(m3ALUN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim())
				.WithQueryParameter("AUTP", m3AUTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ALUN", m3ALUN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (m3COFA.HasValue)
				request.WithQueryParameter("COFA", m3COFA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DMCF.HasValue)
				request.WithQueryParameter("DMCF", m3DMCF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3DCCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3UNMU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PCOF.HasValue)
				request.WithQueryParameter("PCOF", m3PCOF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS1.HasValue)
				request.WithQueryParameter("AUS1", m3AUS1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS2.HasValue)
				request.WithQueryParameter("AUS2", m3AUS2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS3.HasValue)
				request.WithQueryParameter("AUS3", m3AUS3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS4.HasValue)
				request.WithQueryParameter("AUS4", m3AUS4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS6.HasValue)
				request.WithQueryParameter("AUS6", m3AUS6.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS5.HasValue)
				request.WithQueryParameter("AUS5", m3AUS5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS9.HasValue)
				request.WithQueryParameter("AUS9", m3AUS9.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3ITFL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITAB))
				request.WithQueryParameter("ITAB", m3ITAB.Trim());
			if (m3CWPU.HasValue)
				request.WithQueryParameter("CWPU", m3CWPU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUSB.HasValue)
				request.WithQueryParameter("AUSB", m3AUSB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUSC.HasValue)
				request.WithQueryParameter("AUSC", m3AUSC.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name SndChgIntItmAum
		/// Description Send Change Interface Item Alt U/M
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3AUTP">Alternate U/M type (Required)</param>
		/// <param name="m3ALUN">Alternate U/M (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3COFA">Conversion factor</param>
		/// <param name="m3DMCF">Conversion form</param>
		/// <param name="m3DCCD">Number of decimal places</param>
		/// <param name="m3UNMU">Order multiple</param>
		/// <param name="m3PCOF">Price adjustment factor</param>
		/// <param name="m3AUS1">Standard U/M - purchase order</param>
		/// <param name="m3AUS2">Standard U/M - customer order sales</param>
		/// <param name="m3AUS3">Standard U/M - manufacturing</param>
		/// <param name="m3AUS4">Standard U/M - production engineering</param>
		/// <param name="m3AUS6">Standard U/M - statistics</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3STIM">Start time</param>
		/// <param name="m3AUS5">Standard U/M - purchase price</param>
		/// <param name="m3AUS9">Standard U/M - sales price</param>
		/// <param name="m3ITFL">Item number flag</param>
		/// <param name="m3ACFL">Add/change flag</param>
		/// <param name="m3ITAB">Item selection table</param>
		/// <param name="m3CWPU">Catch weight price U/M</param>
		/// <param name="m3AUSB">Standard U/M - cost</param>
		/// <param name="m3AUSC">Standard U/M - catch weight</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndChgIntItmAum(
			string m3E0PA, 
			string m3E065, 
			string m3IFIN, 
			int m3AUTP, 
			string m3ALUN, 
			string m3PRMD = null, 
			decimal? m3COFA = null, 
			int? m3DMCF = null, 
			int? m3DCCD = null, 
			decimal? m3UNMU = null, 
			decimal? m3PCOF = null, 
			int? m3AUS1 = null, 
			int? m3AUS2 = null, 
			int? m3AUS3 = null, 
			int? m3AUS4 = null, 
			int? m3AUS6 = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			decimal? m3TXID = null, 
			DateTime? m3STDT = null, 
			int? m3STIM = null, 
			int? m3AUS5 = null, 
			int? m3AUS9 = null, 
			int? m3ITFL = null, 
			int? m3ACFL = null, 
			string m3ITAB = null, 
			int? m3CWPU = null, 
			int? m3AUSB = null, 
			int? m3AUSC = null, 
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
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));
			if (string.IsNullOrWhiteSpace(m3ALUN))
				throw new ArgumentNullException(nameof(m3ALUN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim())
				.WithQueryParameter("AUTP", m3AUTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ALUN", m3ALUN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (m3COFA.HasValue)
				request.WithQueryParameter("COFA", m3COFA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DMCF.HasValue)
				request.WithQueryParameter("DMCF", m3DMCF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3DCCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3UNMU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PCOF.HasValue)
				request.WithQueryParameter("PCOF", m3PCOF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS1.HasValue)
				request.WithQueryParameter("AUS1", m3AUS1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS2.HasValue)
				request.WithQueryParameter("AUS2", m3AUS2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS3.HasValue)
				request.WithQueryParameter("AUS3", m3AUS3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS4.HasValue)
				request.WithQueryParameter("AUS4", m3AUS4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS6.HasValue)
				request.WithQueryParameter("AUS6", m3AUS6.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3STIM.HasValue)
				request.WithQueryParameter("STIM", m3STIM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS5.HasValue)
				request.WithQueryParameter("AUS5", m3AUS5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS9.HasValue)
				request.WithQueryParameter("AUS9", m3AUS9.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3ITFL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACFL.HasValue)
				request.WithQueryParameter("ACFL", m3ACFL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITAB))
				request.WithQueryParameter("ITAB", m3ITAB.Trim());
			if (m3CWPU.HasValue)
				request.WithQueryParameter("CWPU", m3CWPU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUSB.HasValue)
				request.WithQueryParameter("AUSB", m3AUSB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUSC.HasValue)
				request.WithQueryParameter("AUSC", m3AUSC.Value.ToString(CultureInfo.CurrentCulture));

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
