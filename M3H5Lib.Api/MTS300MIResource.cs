/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Adds a reference transaction
		/// Version Release: 6400
		/// </summary>
		/// <param name="m3TPLI">Template item number (Required)</param>
		/// <param name="m3ITDS">Name (Required)</param>
		/// <param name="m3TPIS">Status (Required)</param>
		/// <param name="m3LVDT">Valid to (Required)</param>
		/// <param name="m3NAQT">Normal call-off quantity (Required)</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3BNCD">Bonus generating</param>
		/// <param name="m3ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3TRQT">Transaction quantity - basic U/M</param>
		/// <param name="m3STQT">On-hand balance approved</param>
		/// <param name="m3ALQT">Allocated quantity - basic U/M</param>
		/// <param name="m3TRPR">Inventory accounting price</param>
		/// <param name="m3INPR">Internal transfer price</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX60">Text</param>
		/// <param name="m3TX70">Text</param>
		/// <param name="m3TX90">Description</param>
		/// <param name="m3DIA1">Discount amount 1</param>
		/// <param name="m3DIA2">Discount amount 2</param>
		/// <param name="m3DIA3">Discount amount 3</param>
		/// <param name="m3DIA4">Discount amount 4</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3TPLI, 
			string m3ITDS, 
			string m3TPIS, 
			DateTime m3LVDT, 
			decimal m3NAQT, 
			string m3RESP = null, 
			int? m3BNCD = null, 
			decimal? m3ORQT = null, 
			decimal? m3TRQT = null, 
			decimal? m3STQT = null, 
			decimal? m3ALQT = null, 
			decimal? m3TRPR = null, 
			decimal? m3INPR = null, 
			string m3TX15 = null, 
			string m3TX40 = null, 
			string m3TX60 = null, 
			string m3TX70 = null, 
			string m3TX90 = null, 
			decimal? m3DIA1 = null, 
			decimal? m3DIA2 = null, 
			decimal? m3DIA3 = null, 
			decimal? m3DIA4 = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TPLI))
				throw new ArgumentNullException(nameof(m3TPLI));
			if (string.IsNullOrWhiteSpace(m3ITDS))
				throw new ArgumentNullException(nameof(m3ITDS));
			if (string.IsNullOrWhiteSpace(m3TPIS))
				throw new ArgumentNullException(nameof(m3TPIS));

			// Set mandatory parameters
			request
				.WithQueryParameter("TPLI", m3TPLI.Trim())
				.WithQueryParameter("ITDS", m3ITDS.Trim())
				.WithQueryParameter("TPIS", m3TPIS.Trim())
				.WithQueryParameter("LVDT", m3LVDT.ToM3String())
				.WithQueryParameter("NAQT", m3NAQT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3BNCD.HasValue)
				request.WithQueryParameter("BNCD", m3BNCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3ORQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3TRQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STQT.HasValue)
				request.WithQueryParameter("STQT", m3STQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALQT.HasValue)
				request.WithQueryParameter("ALQT", m3ALQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRPR.HasValue)
				request.WithQueryParameter("TRPR", m3TRPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INPR.HasValue)
				request.WithQueryParameter("INPR", m3INPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX60))
				request.WithQueryParameter("TX60", m3TX60.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX70))
				request.WithQueryParameter("TX70", m3TX70.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX90))
				request.WithQueryParameter("TX90", m3TX90.Trim());
			if (m3DIA1.HasValue)
				request.WithQueryParameter("DIA1", m3DIA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIA2.HasValue)
				request.WithQueryParameter("DIA2", m3DIA2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIA3.HasValue)
				request.WithQueryParameter("DIA3", m3DIA3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIA4.HasValue)
				request.WithQueryParameter("DIA4", m3DIA4.Value.ToString(CultureInfo.CurrentCulture));

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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DeleteAll",
			};

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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DeleteRelated",
			};

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
		/// Description Deletes a reference transaction
		/// Version Release: 6400
		/// </summary>
		/// <param name="m3TPLI">Template item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Dlt(
			string m3TPLI, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Dlt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TPLI))
				throw new ArgumentNullException(nameof(m3TPLI));

			// Set mandatory parameters
			request
				.WithQueryParameter("TPLI", m3TPLI.Trim());

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
		/// Name GenerateData
		/// Description GenerateData
		/// Version Release: 6400
		/// </summary>
		/// <param name="m3STNM">Starting number - RESP</param>
		/// <param name="m3ARTO">Number of records - RESP</param>
		/// <param name="m3NBLO">Start number - TPLI</param>
		/// <param name="m3NRCD">Number of records - TPLI</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> GenerateData(
			int? m3STNM = null, 
			int? m3ARTO = null, 
			long? m3NBLO = null, 
			int? m3NRCD = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GenerateData",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3STNM.HasValue)
				request.WithQueryParameter("STNM", m3STNM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ARTO.HasValue)
				request.WithQueryParameter("ARTO", m3ARTO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NBLO.HasValue)
				request.WithQueryParameter("NBLO", m3NBLO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NRCD.HasValue)
				request.WithQueryParameter("NRCD", m3NRCD.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Description Gets data for a reference transaction
		/// Version Release: 6400
		/// </summary>
		/// <param name="m3TPLI">Template item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3TPLI, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TPLI))
				throw new ArgumentNullException(nameof(m3TPLI));

			// Set mandatory parameters
			request
				.WithQueryParameter("TPLI", m3TPLI.Trim());

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
		/// Description List data for reference transaction
		/// Version Release: 6400
		/// </summary>
		/// <param name="m3TPLI">Template item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3TPLI = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Lst",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TPLI))
				request.WithQueryParameter("TPLI", m3TPLI.Trim());

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
		/// Description Update data for a reference transaction
		/// Version Release: 6400
		/// </summary>
		/// <param name="m3TPLI">Template item number (Required)</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3TPIS">Status</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3BNCD">Bonus generating</param>
		/// <param name="m3NAQT">Normal call-off quantity</param>
		/// <param name="m3ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3TRQT">Transaction quantity - basic U/M</param>
		/// <param name="m3STQT">On-hand balance approved</param>
		/// <param name="m3ALQT">Allocated quantity - basic U/M</param>
		/// <param name="m3TRPR">Inventory accounting price</param>
		/// <param name="m3INPR">Internal transfer price</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX60">Text</param>
		/// <param name="m3TX70">Text</param>
		/// <param name="m3TX90">Description</param>
		/// <param name="m3DIA1">Discount amount 1</param>
		/// <param name="m3DIA2">Discount amount 2</param>
		/// <param name="m3DIA3">Discount amount 3</param>
		/// <param name="m3DIA4">Discount amount 4</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3TPLI, 
			string m3ITDS = null, 
			string m3TPIS = null, 
			string m3RESP = null, 
			DateTime? m3LVDT = null, 
			int? m3BNCD = null, 
			decimal? m3NAQT = null, 
			decimal? m3ORQT = null, 
			decimal? m3TRQT = null, 
			decimal? m3STQT = null, 
			decimal? m3ALQT = null, 
			decimal? m3TRPR = null, 
			decimal? m3INPR = null, 
			string m3TX15 = null, 
			string m3TX40 = null, 
			string m3TX60 = null, 
			string m3TX70 = null, 
			string m3TX90 = null, 
			decimal? m3DIA1 = null, 
			decimal? m3DIA2 = null, 
			decimal? m3DIA3 = null, 
			decimal? m3DIA4 = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Upd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TPLI))
				throw new ArgumentNullException(nameof(m3TPLI));

			// Set mandatory parameters
			request
				.WithQueryParameter("TPLI", m3TPLI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TPIS))
				request.WithQueryParameter("TPIS", m3TPIS.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (m3BNCD.HasValue)
				request.WithQueryParameter("BNCD", m3BNCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NAQT.HasValue)
				request.WithQueryParameter("NAQT", m3NAQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3ORQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3TRQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STQT.HasValue)
				request.WithQueryParameter("STQT", m3STQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALQT.HasValue)
				request.WithQueryParameter("ALQT", m3ALQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRPR.HasValue)
				request.WithQueryParameter("TRPR", m3TRPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INPR.HasValue)
				request.WithQueryParameter("INPR", m3INPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX60))
				request.WithQueryParameter("TX60", m3TX60.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX70))
				request.WithQueryParameter("TX70", m3TX70.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX90))
				request.WithQueryParameter("TX90", m3TX90.Trim());
			if (m3DIA1.HasValue)
				request.WithQueryParameter("DIA1", m3DIA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIA2.HasValue)
				request.WithQueryParameter("DIA2", m3DIA2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIA3.HasValue)
				request.WithQueryParameter("DIA3", m3DIA3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIA4.HasValue)
				request.WithQueryParameter("DIA4", m3DIA4.Value.ToString(CultureInfo.CurrentCulture));

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
