/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.MMS015MI;
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
	/// Name: MMS015MI
	/// Component Name: Alterative units
	/// Description: Alterative units
	/// Version Release: 5ea0
	///</summary>
	public partial class MMS015MIResource : M3BaseResourceEndpoint
	{
		public MMS015MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS015MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add an alterative unit
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3AUTP">Alternate U/M type (Required)</param>
		/// <param name="m3ALUN">Alternate U/M (Required)</param>
		/// <param name="m3DCCD">Number of decimal places</param>
		/// <param name="m3COFA">Conversion factor</param>
		/// <param name="m3DMCF">Conversion form</param>
		/// <param name="m3PCOF">Price adjustment factor</param>
		/// <param name="m3AUS1">Standard U/M - purchase order</param>
		/// <param name="m3AUS2">Standard U/M - customer order sales</param>
		/// <param name="m3AUS3">Standard U/M - manufacturing</param>
		/// <param name="m3AUS4">Standard U/M - production engineering</param>
		/// <param name="m3AUS5">Standard U/M - purchase price</param>
		/// <param name="m3AUS6">Standard U/M - statistics</param>
		/// <param name="m3AUS9">Default U/M - sales price</param>
		/// <param name="m3UNMU">Order multiple</param>
		/// <param name="m3FMID">Formula</param>
		/// <param name="m3RESI">Result identity</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3AUSC">Standard U/M - catch weight</param>
		/// <param name="m3AUSB">Standard U/M - cost</param>
		/// <param name="m3LGUN">Logistics U/M</param>
		/// <param name="m3CWPU">Catch weight price U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3ITNO, 
			int m3AUTP, 
			string m3ALUN, 
			int? m3DCCD = null, 
			decimal? m3COFA = null, 
			int? m3DMCF = null, 
			decimal? m3PCOF = null, 
			int? m3AUS1 = null, 
			int? m3AUS2 = null, 
			int? m3AUS3 = null, 
			int? m3AUS4 = null, 
			int? m3AUS5 = null, 
			int? m3AUS6 = null, 
			int? m3AUS9 = null, 
			decimal? m3UNMU = null, 
			string m3FMID = null, 
			string m3RESI = null, 
			string m3PACT = null, 
			int? m3AUSC = null, 
			int? m3AUSB = null, 
			int? m3LGUN = null, 
			int? m3CWPU = null, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3ALUN))
				throw new ArgumentNullException(nameof(m3ALUN));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("AUTP", m3AUTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ALUN", m3ALUN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3DCCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COFA.HasValue)
				request.WithQueryParameter("COFA", m3COFA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DMCF.HasValue)
				request.WithQueryParameter("DMCF", m3DMCF.Value.ToString(CultureInfo.CurrentCulture));
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
			if (m3AUS5.HasValue)
				request.WithQueryParameter("AUS5", m3AUS5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS6.HasValue)
				request.WithQueryParameter("AUS6", m3AUS6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS9.HasValue)
				request.WithQueryParameter("AUS9", m3AUS9.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3UNMU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FMID))
				request.WithQueryParameter("FMID", m3FMID.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESI))
				request.WithQueryParameter("RESI", m3RESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (m3AUSC.HasValue)
				request.WithQueryParameter("AUSC", m3AUSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUSB.HasValue)
				request.WithQueryParameter("AUSB", m3AUSB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LGUN.HasValue)
				request.WithQueryParameter("LGUN", m3LGUN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CWPU.HasValue)
				request.WithQueryParameter("CWPU", m3CWPU.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Description Delete an alterative unit
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3AUTP">Alternate U/M type (Required)</param>
		/// <param name="m3ALUN">Alternate U/M (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Dlt(
			string m3ITNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Dlt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3ALUN))
				throw new ArgumentNullException(nameof(m3ALUN));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
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
		/// Name Get
		/// Description Get an alterative unit
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3AUTP">Alternate U/M type (Required)</param>
		/// <param name="m3ALUN">Alternate U/M (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3ITNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3ALUN))
				throw new ArgumentNullException(nameof(m3ALUN));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("AUTP", m3AUTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ALUN", m3ALUN.Trim());

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
		/// Description List data for alterative units
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3AUTP">Alternate U/M type</param>
		/// <param name="m3ALUN">Alternate U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3ITNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Lst",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3AUTP.HasValue)
				request.WithQueryParameter("AUTP", m3AUTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALUN))
				request.WithQueryParameter("ALUN", m3ALUN.Trim());

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
		/// Description Update data for an alternative unit
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3AUTP">Alternate U/M type</param>
		/// <param name="m3ALUN">Alternate U/M</param>
		/// <param name="m3DCCD">Number of decimal places</param>
		/// <param name="m3COFA">Conversion factor</param>
		/// <param name="m3DMCF">Conversion form</param>
		/// <param name="m3PCOF">Price adjustment factor</param>
		/// <param name="m3AUS1">Standard U/M - purchase order</param>
		/// <param name="m3AUS2">Standard U/M - customer order sales</param>
		/// <param name="m3AUS3">Standard U/M - manufacturing</param>
		/// <param name="m3AUS4">Standard U/M - production engineering</param>
		/// <param name="m3AUS5">Standard U/M - purchase price</param>
		/// <param name="m3AUS6">Standard U/M - statistics</param>
		/// <param name="m3AUS9">Default U/M - sales price</param>
		/// <param name="m3UNMU">Order multiple</param>
		/// <param name="m3FMID">Formula</param>
		/// <param name="m3RESI">Result identity</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3AUSC">Standard U/M - catch weight</param>
		/// <param name="m3AUSB">Standard U/M - cost</param>
		/// <param name="m3LGUN">Logistics U/M</param>
		/// <param name="m3CWPU">Catch weight price U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3ITNO = null, 
			int? m3AUTP = null, 
			string m3ALUN = null, 
			int? m3DCCD = null, 
			decimal? m3COFA = null, 
			int? m3DMCF = null, 
			decimal? m3PCOF = null, 
			int? m3AUS1 = null, 
			int? m3AUS2 = null, 
			int? m3AUS3 = null, 
			int? m3AUS4 = null, 
			int? m3AUS5 = null, 
			int? m3AUS6 = null, 
			int? m3AUS9 = null, 
			decimal? m3UNMU = null, 
			string m3FMID = null, 
			string m3RESI = null, 
			string m3PACT = null, 
			int? m3AUSC = null, 
			int? m3AUSB = null, 
			int? m3LGUN = null, 
			int? m3CWPU = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3AUTP.HasValue)
				request.WithQueryParameter("AUTP", m3AUTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALUN))
				request.WithQueryParameter("ALUN", m3ALUN.Trim());
			if (m3DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3DCCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COFA.HasValue)
				request.WithQueryParameter("COFA", m3COFA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DMCF.HasValue)
				request.WithQueryParameter("DMCF", m3DMCF.Value.ToString(CultureInfo.CurrentCulture));
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
			if (m3AUS5.HasValue)
				request.WithQueryParameter("AUS5", m3AUS5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS6.HasValue)
				request.WithQueryParameter("AUS6", m3AUS6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUS9.HasValue)
				request.WithQueryParameter("AUS9", m3AUS9.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3UNMU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FMID))
				request.WithQueryParameter("FMID", m3FMID.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESI))
				request.WithQueryParameter("RESI", m3RESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (m3AUSC.HasValue)
				request.WithQueryParameter("AUSC", m3AUSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUSB.HasValue)
				request.WithQueryParameter("AUSB", m3AUSB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LGUN.HasValue)
				request.WithQueryParameter("LGUN", m3LGUN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CWPU.HasValue)
				request.WithQueryParameter("CWPU", m3CWPU.Value.ToString(CultureInfo.CurrentCulture));

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
