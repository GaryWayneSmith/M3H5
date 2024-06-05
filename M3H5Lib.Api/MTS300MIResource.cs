/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MTS300MI;
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
	/// Name: MTS300MI
	/// Component Name: Template item
	/// Description: Template item interface
	/// Version Release: 5ea0
	///</summary>
	public partial class MTS300MIResource : M3BaseResourceEndpoint
	{
		public MTS300MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MTS300MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Adds a reference transaction
		/// Version Release: 6400
		/// </summary>
		/// <param name="m3_TPLI">Template item number (Required)</param>
		/// <param name="m3_ITDS">Name (Required)</param>
		/// <param name="m3_TPIS">Status (Required)</param>
		/// <param name="m3_LVDT">Valid to (Required)</param>
		/// <param name="m3_NAQT">Normal call-off quantity (Required)</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_BNCD">Bonus generating</param>
		/// <param name="m3_ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3_TRQT">Transaction quantity - basic U/M</param>
		/// <param name="m3_STQT">On-hand balance approved</param>
		/// <param name="m3_ALQT">Allocated quantity - basic U/M</param>
		/// <param name="m3_TRPR">Inventory accounting price</param>
		/// <param name="m3_INPR">Internal transfer price</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX60">Text</param>
		/// <param name="m3_TX70">Text</param>
		/// <param name="m3_TX90">Description</param>
		/// <param name="m3_DIA1">Discount amount 1</param>
		/// <param name="m3_DIA2">Discount amount 2</param>
		/// <param name="m3_DIA3">Discount amount 3</param>
		/// <param name="m3_DIA4">Discount amount 4</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_TPLI, 
			string m3_ITDS, 
			string m3_TPIS, 
			DateTime m3_LVDT, 
			decimal m3_NAQT, 
			string m3_RESP = null, 
			int? m3_BNCD = null, 
			decimal? m3_ORQT = null, 
			decimal? m3_TRQT = null, 
			decimal? m3_STQT = null, 
			decimal? m3_ALQT = null, 
			decimal? m3_TRPR = null, 
			decimal? m3_INPR = null, 
			string m3_TX15 = null, 
			string m3_TX40 = null, 
			string m3_TX60 = null, 
			string m3_TX70 = null, 
			string m3_TX90 = null, 
			decimal? m3_DIA1 = null, 
			decimal? m3_DIA2 = null, 
			decimal? m3_DIA3 = null, 
			decimal? m3_DIA4 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_TPLI))
				throw new ArgumentNullException("m3_TPLI");
			if (string.IsNullOrWhiteSpace(m3_ITDS))
				throw new ArgumentNullException("m3_ITDS");
			if (string.IsNullOrWhiteSpace(m3_TPIS))
				throw new ArgumentNullException("m3_TPIS");

			// Set mandatory parameters
			request
				.WithQueryParameter("TPLI", m3_TPLI.Trim())
				.WithQueryParameter("ITDS", m3_ITDS.Trim())
				.WithQueryParameter("TPIS", m3_TPIS.Trim())
				.WithQueryParameter("LVDT", m3_LVDT.ToM3String())
				.WithQueryParameter("NAQT", m3_NAQT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_BNCD.HasValue)
				request.WithQueryParameter("BNCD", m3_BNCD.Value.ToString());
			if (m3_ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3_ORQT.Value.ToString());
			if (m3_TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3_TRQT.Value.ToString());
			if (m3_STQT.HasValue)
				request.WithQueryParameter("STQT", m3_STQT.Value.ToString());
			if (m3_ALQT.HasValue)
				request.WithQueryParameter("ALQT", m3_ALQT.Value.ToString());
			if (m3_TRPR.HasValue)
				request.WithQueryParameter("TRPR", m3_TRPR.Value.ToString());
			if (m3_INPR.HasValue)
				request.WithQueryParameter("INPR", m3_INPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX60))
				request.WithQueryParameter("TX60", m3_TX60.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX70))
				request.WithQueryParameter("TX70", m3_TX70.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX90))
				request.WithQueryParameter("TX90", m3_TX90.Trim());
			if (m3_DIA1.HasValue)
				request.WithQueryParameter("DIA1", m3_DIA1.Value.ToString());
			if (m3_DIA2.HasValue)
				request.WithQueryParameter("DIA2", m3_DIA2.Value.ToString());
			if (m3_DIA3.HasValue)
				request.WithQueryParameter("DIA3", m3_DIA3.Value.ToString());
			if (m3_DIA4.HasValue)
				request.WithQueryParameter("DIA4", m3_DIA4.Value.ToString());

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
		/// Name DeleteAll
		/// Description DeleteAll
		/// Version Release: 6400
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteAll(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeleteAll",
			};

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
		/// Name DeleteRelated
		/// Description DeleteRelated
		/// Version Release: 6400
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteRelated(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeleteRelated",
			};

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
		/// Description Deletes a reference transaction
		/// Version Release: 6400
		/// </summary>
		/// <param name="m3_TPLI">Template item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Dlt(
			string m3_TPLI, 
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
			if (string.IsNullOrWhiteSpace(m3_TPLI))
				throw new ArgumentNullException("m3_TPLI");

			// Set mandatory parameters
			request
				.WithQueryParameter("TPLI", m3_TPLI.Trim());

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
		/// Name GenerateData
		/// Description GenerateData
		/// Version Release: 6400
		/// </summary>
		/// <param name="m3_STNM">Starting number - RESP</param>
		/// <param name="m3_ARTO">Number of records - RESP</param>
		/// <param name="m3_NBLO">Start number - TPLI</param>
		/// <param name="m3_NRCD">Number of records - TPLI</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> GenerateData(
			int? m3_STNM = null, 
			int? m3_ARTO = null, 
			long? m3_NBLO = null, 
			int? m3_NRCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GenerateData",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_STNM.HasValue)
				request.WithQueryParameter("STNM", m3_STNM.Value.ToString());
			if (m3_ARTO.HasValue)
				request.WithQueryParameter("ARTO", m3_ARTO.Value.ToString());
			if (m3_NBLO.HasValue)
				request.WithQueryParameter("NBLO", m3_NBLO.Value.ToString());
			if (m3_NRCD.HasValue)
				request.WithQueryParameter("NRCD", m3_NRCD.Value.ToString());

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
		/// Description Gets data for a reference transaction
		/// Version Release: 6400
		/// </summary>
		/// <param name="m3_TPLI">Template item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_TPLI, 
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
			if (string.IsNullOrWhiteSpace(m3_TPLI))
				throw new ArgumentNullException("m3_TPLI");

			// Set mandatory parameters
			request
				.WithQueryParameter("TPLI", m3_TPLI.Trim());

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
		/// Description List data for reference transaction
		/// Version Release: 6400
		/// </summary>
		/// <param name="m3_TPLI">Template item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3_TPLI = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_TPLI))
				request.WithQueryParameter("TPLI", m3_TPLI.Trim());

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
		/// Description Update data for a reference transaction
		/// Version Release: 6400
		/// </summary>
		/// <param name="m3_TPLI">Template item number (Required)</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_TPIS">Status</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_BNCD">Bonus generating</param>
		/// <param name="m3_NAQT">Normal call-off quantity</param>
		/// <param name="m3_ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3_TRQT">Transaction quantity - basic U/M</param>
		/// <param name="m3_STQT">On-hand balance approved</param>
		/// <param name="m3_ALQT">Allocated quantity - basic U/M</param>
		/// <param name="m3_TRPR">Inventory accounting price</param>
		/// <param name="m3_INPR">Internal transfer price</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX60">Text</param>
		/// <param name="m3_TX70">Text</param>
		/// <param name="m3_TX90">Description</param>
		/// <param name="m3_DIA1">Discount amount 1</param>
		/// <param name="m3_DIA2">Discount amount 2</param>
		/// <param name="m3_DIA3">Discount amount 3</param>
		/// <param name="m3_DIA4">Discount amount 4</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3_TPLI, 
			string m3_ITDS = null, 
			string m3_TPIS = null, 
			string m3_RESP = null, 
			DateTime? m3_LVDT = null, 
			int? m3_BNCD = null, 
			decimal? m3_NAQT = null, 
			decimal? m3_ORQT = null, 
			decimal? m3_TRQT = null, 
			decimal? m3_STQT = null, 
			decimal? m3_ALQT = null, 
			decimal? m3_TRPR = null, 
			decimal? m3_INPR = null, 
			string m3_TX15 = null, 
			string m3_TX40 = null, 
			string m3_TX60 = null, 
			string m3_TX70 = null, 
			string m3_TX90 = null, 
			decimal? m3_DIA1 = null, 
			decimal? m3_DIA2 = null, 
			decimal? m3_DIA3 = null, 
			decimal? m3_DIA4 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_TPLI))
				throw new ArgumentNullException("m3_TPLI");

			// Set mandatory parameters
			request
				.WithQueryParameter("TPLI", m3_TPLI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TPIS))
				request.WithQueryParameter("TPIS", m3_TPIS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (m3_BNCD.HasValue)
				request.WithQueryParameter("BNCD", m3_BNCD.Value.ToString());
			if (m3_NAQT.HasValue)
				request.WithQueryParameter("NAQT", m3_NAQT.Value.ToString());
			if (m3_ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3_ORQT.Value.ToString());
			if (m3_TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3_TRQT.Value.ToString());
			if (m3_STQT.HasValue)
				request.WithQueryParameter("STQT", m3_STQT.Value.ToString());
			if (m3_ALQT.HasValue)
				request.WithQueryParameter("ALQT", m3_ALQT.Value.ToString());
			if (m3_TRPR.HasValue)
				request.WithQueryParameter("TRPR", m3_TRPR.Value.ToString());
			if (m3_INPR.HasValue)
				request.WithQueryParameter("INPR", m3_INPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX60))
				request.WithQueryParameter("TX60", m3_TX60.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX70))
				request.WithQueryParameter("TX70", m3_TX70.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX90))
				request.WithQueryParameter("TX90", m3_TX90.Trim());
			if (m3_DIA1.HasValue)
				request.WithQueryParameter("DIA1", m3_DIA1.Value.ToString());
			if (m3_DIA2.HasValue)
				request.WithQueryParameter("DIA2", m3_DIA2.Value.ToString());
			if (m3_DIA3.HasValue)
				request.WithQueryParameter("DIA3", m3_DIA3.Value.ToString());
			if (m3_DIA4.HasValue)
				request.WithQueryParameter("DIA4", m3_DIA4.Value.ToString());

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
