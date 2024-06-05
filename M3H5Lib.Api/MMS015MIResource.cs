/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_AUTP">Alternate U/M type (Required)</param>
		/// <param name="m3_ALUN">Alternate U/M (Required)</param>
		/// <param name="m3_DCCD">Number of decimal places</param>
		/// <param name="m3_COFA">Conversion factor</param>
		/// <param name="m3_DMCF">Conversion form</param>
		/// <param name="m3_PCOF">Price adjustment factor</param>
		/// <param name="m3_AUS1">Standard U/M - purchase order</param>
		/// <param name="m3_AUS2">Standard U/M - customer order sales</param>
		/// <param name="m3_AUS3">Standard U/M - manufacturing</param>
		/// <param name="m3_AUS4">Standard U/M - production engineering</param>
		/// <param name="m3_AUS5">Standard U/M - purchase price</param>
		/// <param name="m3_AUS6">Standard U/M - statistics</param>
		/// <param name="m3_AUS9">Default U/M - sales price</param>
		/// <param name="m3_UNMU">Order multiple</param>
		/// <param name="m3_FMID">Formula</param>
		/// <param name="m3_RESI">Result identity</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_AUSC">Standard U/M - catch weight</param>
		/// <param name="m3_AUSB">Standard U/M - cost</param>
		/// <param name="m3_LGUN">Logistics U/M</param>
		/// <param name="m3_CWPU">Catch weight price U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_ITNO, 
			int m3_AUTP, 
			string m3_ALUN, 
			int? m3_DCCD = null, 
			decimal? m3_COFA = null, 
			int? m3_DMCF = null, 
			decimal? m3_PCOF = null, 
			int? m3_AUS1 = null, 
			int? m3_AUS2 = null, 
			int? m3_AUS3 = null, 
			int? m3_AUS4 = null, 
			int? m3_AUS5 = null, 
			int? m3_AUS6 = null, 
			int? m3_AUS9 = null, 
			decimal? m3_UNMU = null, 
			string m3_FMID = null, 
			string m3_RESI = null, 
			string m3_PACT = null, 
			int? m3_AUSC = null, 
			int? m3_AUSB = null, 
			int? m3_LGUN = null, 
			int? m3_CWPU = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_ALUN))
				throw new ArgumentNullException("m3_ALUN");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("AUTP", m3_AUTP.ToString())
				.WithQueryParameter("ALUN", m3_ALUN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3_DCCD.Value.ToString());
			if (m3_COFA.HasValue)
				request.WithQueryParameter("COFA", m3_COFA.Value.ToString());
			if (m3_DMCF.HasValue)
				request.WithQueryParameter("DMCF", m3_DMCF.Value.ToString());
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
			if (m3_AUS5.HasValue)
				request.WithQueryParameter("AUS5", m3_AUS5.Value.ToString());
			if (m3_AUS6.HasValue)
				request.WithQueryParameter("AUS6", m3_AUS6.Value.ToString());
			if (m3_AUS9.HasValue)
				request.WithQueryParameter("AUS9", m3_AUS9.Value.ToString());
			if (m3_UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3_UNMU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FMID))
				request.WithQueryParameter("FMID", m3_FMID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESI))
				request.WithQueryParameter("RESI", m3_RESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (m3_AUSC.HasValue)
				request.WithQueryParameter("AUSC", m3_AUSC.Value.ToString());
			if (m3_AUSB.HasValue)
				request.WithQueryParameter("AUSB", m3_AUSB.Value.ToString());
			if (m3_LGUN.HasValue)
				request.WithQueryParameter("LGUN", m3_LGUN.Value.ToString());
			if (m3_CWPU.HasValue)
				request.WithQueryParameter("CWPU", m3_CWPU.Value.ToString());

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
		/// Description Delete an alterative unit
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_AUTP">Alternate U/M type (Required)</param>
		/// <param name="m3_ALUN">Alternate U/M (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Dlt(
			string m3_ITNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Dlt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_ALUN))
				throw new ArgumentNullException("m3_ALUN");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
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
		/// Name Get
		/// Description Get an alterative unit
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_AUTP">Alternate U/M type (Required)</param>
		/// <param name="m3_ALUN">Alternate U/M (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_ITNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_ALUN))
				throw new ArgumentNullException("m3_ALUN");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("AUTP", m3_AUTP.ToString())
				.WithQueryParameter("ALUN", m3_ALUN.Trim());

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
		/// Description List data for alterative units
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_AUTP">Alternate U/M type</param>
		/// <param name="m3_ALUN">Alternate U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3_ITNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Lst",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_AUTP.HasValue)
				request.WithQueryParameter("AUTP", m3_AUTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());

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
		/// Description Update data for an alternative unit
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_AUTP">Alternate U/M type</param>
		/// <param name="m3_ALUN">Alternate U/M</param>
		/// <param name="m3_DCCD">Number of decimal places</param>
		/// <param name="m3_COFA">Conversion factor</param>
		/// <param name="m3_DMCF">Conversion form</param>
		/// <param name="m3_PCOF">Price adjustment factor</param>
		/// <param name="m3_AUS1">Standard U/M - purchase order</param>
		/// <param name="m3_AUS2">Standard U/M - customer order sales</param>
		/// <param name="m3_AUS3">Standard U/M - manufacturing</param>
		/// <param name="m3_AUS4">Standard U/M - production engineering</param>
		/// <param name="m3_AUS5">Standard U/M - purchase price</param>
		/// <param name="m3_AUS6">Standard U/M - statistics</param>
		/// <param name="m3_AUS9">Default U/M - sales price</param>
		/// <param name="m3_UNMU">Order multiple</param>
		/// <param name="m3_FMID">Formula</param>
		/// <param name="m3_RESI">Result identity</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_AUSC">Standard U/M - catch weight</param>
		/// <param name="m3_AUSB">Standard U/M - cost</param>
		/// <param name="m3_LGUN">Logistics U/M</param>
		/// <param name="m3_CWPU">Catch weight price U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3_ITNO = null, 
			int? m3_AUTP = null, 
			string m3_ALUN = null, 
			int? m3_DCCD = null, 
			decimal? m3_COFA = null, 
			int? m3_DMCF = null, 
			decimal? m3_PCOF = null, 
			int? m3_AUS1 = null, 
			int? m3_AUS2 = null, 
			int? m3_AUS3 = null, 
			int? m3_AUS4 = null, 
			int? m3_AUS5 = null, 
			int? m3_AUS6 = null, 
			int? m3_AUS9 = null, 
			decimal? m3_UNMU = null, 
			string m3_FMID = null, 
			string m3_RESI = null, 
			string m3_PACT = null, 
			int? m3_AUSC = null, 
			int? m3_AUSB = null, 
			int? m3_LGUN = null, 
			int? m3_CWPU = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_AUTP.HasValue)
				request.WithQueryParameter("AUTP", m3_AUTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());
			if (m3_DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3_DCCD.Value.ToString());
			if (m3_COFA.HasValue)
				request.WithQueryParameter("COFA", m3_COFA.Value.ToString());
			if (m3_DMCF.HasValue)
				request.WithQueryParameter("DMCF", m3_DMCF.Value.ToString());
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
			if (m3_AUS5.HasValue)
				request.WithQueryParameter("AUS5", m3_AUS5.Value.ToString());
			if (m3_AUS6.HasValue)
				request.WithQueryParameter("AUS6", m3_AUS6.Value.ToString());
			if (m3_AUS9.HasValue)
				request.WithQueryParameter("AUS9", m3_AUS9.Value.ToString());
			if (m3_UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3_UNMU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FMID))
				request.WithQueryParameter("FMID", m3_FMID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESI))
				request.WithQueryParameter("RESI", m3_RESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (m3_AUSC.HasValue)
				request.WithQueryParameter("AUSC", m3_AUSC.Value.ToString());
			if (m3_AUSB.HasValue)
				request.WithQueryParameter("AUSB", m3_AUSB.Value.ToString());
			if (m3_LGUN.HasValue)
				request.WithQueryParameter("LGUN", m3_LGUN.Value.ToString());
			if (m3_CWPU.HasValue)
				request.WithQueryParameter("CWPU", m3_CWPU.Value.ToString());

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
