/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MMS250MI;
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
	/// Name: MMS250MI
	/// Component Name: SerNoPricing
	/// Description: Serialnumber based pricing
	/// Version Release: 5ea0
	///</summary>
	public partial class MMS250MIResource : M3BaseResourceEndpoint
	{
		public MMS250MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS250MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_SCMO">Costing model - sales price</param>
		/// <param name="m3_ACGR">Object access group</param>
		/// <param name="m3_ROPP">Rounding-off category</param>
		/// <param name="m3_CRTP">Exchange rate type</param>
		/// <param name="m3_NTCD">Net price used</param>
		/// <param name="m3_BNCD">Bonus generating</param>
		/// <param name="m3_PRAC">Commission generating</param>
		/// <param name="m3_MES1">Meter 1</param>
		/// <param name="m3_MVA1">Meter value 1</param>
		/// <param name="m3_MES2">Meter 2</param>
		/// <param name="m3_MVA2">Meter value 2</param>
		/// <param name="m3_MES3">Meter 3</param>
		/// <param name="m3_MVA3">Meter value 3</param>
		/// <param name="m3_MES4">Meter 4</param>
		/// <param name="m3_MVA4">Meter value 4</param>
		/// <param name="m3_FMPR">Fair market price</param>
		/// <param name="m3_RPVA">Replacement cost</param>
		/// <param name="m3_EVAV">Evaluation value</param>
		/// <param name="m3_BVAL">Base value for calculation</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_ITNO, 
			string m3_SERN, 
			string m3_CUCD, 
			DateTime m3_FVDT, 
			DateTime? m3_LVDT = null, 
			string m3_STAT = null, 
			string m3_SCMO = null, 
			string m3_ACGR = null, 
			int? m3_ROPP = null, 
			int? m3_CRTP = null, 
			int? m3_NTCD = null, 
			int? m3_BNCD = null, 
			int? m3_PRAC = null, 
			string m3_MES1 = null, 
			decimal? m3_MVA1 = null, 
			string m3_MES2 = null, 
			decimal? m3_MVA2 = null, 
			string m3_MES3 = null, 
			decimal? m3_MVA3 = null, 
			string m3_MES4 = null, 
			decimal? m3_MVA4 = null, 
			decimal? m3_FMPR = null, 
			decimal? m3_RPVA = null, 
			decimal? m3_EVAV = null, 
			decimal? m3_BVAL = null, 
			decimal? m3_SAPR = null, 
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
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCMO))
				request.WithQueryParameter("SCMO", m3_SCMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACGR))
				request.WithQueryParameter("ACGR", m3_ACGR.Trim());
			if (m3_ROPP.HasValue)
				request.WithQueryParameter("ROPP", m3_ROPP.Value.ToString());
			if (m3_CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3_CRTP.Value.ToString());
			if (m3_NTCD.HasValue)
				request.WithQueryParameter("NTCD", m3_NTCD.Value.ToString());
			if (m3_BNCD.HasValue)
				request.WithQueryParameter("BNCD", m3_BNCD.Value.ToString());
			if (m3_PRAC.HasValue)
				request.WithQueryParameter("PRAC", m3_PRAC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MES1))
				request.WithQueryParameter("MES1", m3_MES1.Trim());
			if (m3_MVA1.HasValue)
				request.WithQueryParameter("MVA1", m3_MVA1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MES2))
				request.WithQueryParameter("MES2", m3_MES2.Trim());
			if (m3_MVA2.HasValue)
				request.WithQueryParameter("MVA2", m3_MVA2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MES3))
				request.WithQueryParameter("MES3", m3_MES3.Trim());
			if (m3_MVA3.HasValue)
				request.WithQueryParameter("MVA3", m3_MVA3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MES4))
				request.WithQueryParameter("MES4", m3_MES4.Trim());
			if (m3_MVA4.HasValue)
				request.WithQueryParameter("MVA4", m3_MVA4.Value.ToString());
			if (m3_FMPR.HasValue)
				request.WithQueryParameter("FMPR", m3_FMPR.Value.ToString());
			if (m3_RPVA.HasValue)
				request.WithQueryParameter("RPVA", m3_RPVA.Value.ToString());
			if (m3_EVAV.HasValue)
				request.WithQueryParameter("EVAV", m3_EVAV.Value.ToString());
			if (m3_BVAL.HasValue)
				request.WithQueryParameter("BVAL", m3_BVAL.Value.ToString());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());

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
		/// Name Del
		/// Description Delete
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			string m3_ITNO, 
			string m3_SERN, 
			string m3_CUCD, 
			DateTime m3_FVDT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Del",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

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
		/// Name GetSerialPrice
		/// Description Get Serialized based price.
		/// Version Release: 
		/// </summary>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSerialPriceResponse></returns>
		/// <exception cref="M3Exception<GetSerialPriceResponse>"></exception>
		public async Task<M3Response<GetSerialPriceResponse>> GetSerialPrice(
			string m3_ITNO = null, 
			string m3_SERN = null, 
			string m3_CUCD = null, 
			DateTime? m3_FVDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSerialPrice",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetSerialPriceResponse>(
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
		/// Name LstItem
		/// Description List Serialized based price by item
		/// Version Release: 
		/// </summary>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemResponse></returns>
		/// <exception cref="M3Exception<LstItemResponse>"></exception>
		public async Task<M3Response<LstItemResponse>> LstItem(
			string m3_ITNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItem",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<LstItemResponse>(
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
		/// Name LstItemSerCurr
		/// Description List Serialized based price by item serial number currency
		/// Version Release: 
		/// </summary>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemSerCurrResponse></returns>
		/// <exception cref="M3Exception<LstItemSerCurrResponse>"></exception>
		public async Task<M3Response<LstItemSerCurrResponse>> LstItemSerCurr(
			string m3_ITNO = null, 
			string m3_SERN = null, 
			string m3_CUCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItemSerCurr",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());

			// Execute the request
			var result = await Execute<LstItemSerCurrResponse>(
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
		/// Name LstItemSerial
		/// Description List Serialized based price by item serial number
		/// Version Release: 
		/// </summary>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemSerialResponse></returns>
		/// <exception cref="M3Exception<LstItemSerialResponse>"></exception>
		public async Task<M3Response<LstItemSerialResponse>> LstItemSerial(
			string m3_ITNO = null, 
			string m3_SERN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItemSerial",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());

			// Execute the request
			var result = await Execute<LstItemSerialResponse>(
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
		/// Description Update
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_SCMO">Costing model - sales price</param>
		/// <param name="m3_ACGR">Object access group</param>
		/// <param name="m3_ROPP">Rounding-off category</param>
		/// <param name="m3_CRTP">Exchange rate type</param>
		/// <param name="m3_NTCD">Net price used</param>
		/// <param name="m3_BNCD">Bonus generating</param>
		/// <param name="m3_PRAC">Commission generating</param>
		/// <param name="m3_MES1">Meter 1</param>
		/// <param name="m3_MVA1">Meter value 1</param>
		/// <param name="m3_MES2">Meter 2</param>
		/// <param name="m3_MVA2">Meter value 2</param>
		/// <param name="m3_MES3">Meter 3</param>
		/// <param name="m3_MVA3">Meter value 3</param>
		/// <param name="m3_MES4">Meter 4</param>
		/// <param name="m3_MVA4">Meter value 4</param>
		/// <param name="m3_FMPR">Fair market price</param>
		/// <param name="m3_RPVA">Replacement cost</param>
		/// <param name="m3_EVAV">Evaluation value</param>
		/// <param name="m3_BVAL">Base value for calculation</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3_ITNO, 
			string m3_SERN, 
			string m3_CUCD, 
			DateTime m3_FVDT, 
			DateTime? m3_LVDT = null, 
			string m3_STAT = null, 
			string m3_SCMO = null, 
			string m3_ACGR = null, 
			int? m3_ROPP = null, 
			int? m3_CRTP = null, 
			int? m3_NTCD = null, 
			int? m3_BNCD = null, 
			int? m3_PRAC = null, 
			string m3_MES1 = null, 
			decimal? m3_MVA1 = null, 
			string m3_MES2 = null, 
			decimal? m3_MVA2 = null, 
			string m3_MES3 = null, 
			decimal? m3_MVA3 = null, 
			string m3_MES4 = null, 
			decimal? m3_MVA4 = null, 
			decimal? m3_FMPR = null, 
			decimal? m3_RPVA = null, 
			decimal? m3_EVAV = null, 
			decimal? m3_BVAL = null, 
			decimal? m3_SAPR = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCMO))
				request.WithQueryParameter("SCMO", m3_SCMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACGR))
				request.WithQueryParameter("ACGR", m3_ACGR.Trim());
			if (m3_ROPP.HasValue)
				request.WithQueryParameter("ROPP", m3_ROPP.Value.ToString());
			if (m3_CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3_CRTP.Value.ToString());
			if (m3_NTCD.HasValue)
				request.WithQueryParameter("NTCD", m3_NTCD.Value.ToString());
			if (m3_BNCD.HasValue)
				request.WithQueryParameter("BNCD", m3_BNCD.Value.ToString());
			if (m3_PRAC.HasValue)
				request.WithQueryParameter("PRAC", m3_PRAC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MES1))
				request.WithQueryParameter("MES1", m3_MES1.Trim());
			if (m3_MVA1.HasValue)
				request.WithQueryParameter("MVA1", m3_MVA1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MES2))
				request.WithQueryParameter("MES2", m3_MES2.Trim());
			if (m3_MVA2.HasValue)
				request.WithQueryParameter("MVA2", m3_MVA2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MES3))
				request.WithQueryParameter("MES3", m3_MES3.Trim());
			if (m3_MVA3.HasValue)
				request.WithQueryParameter("MVA3", m3_MVA3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MES4))
				request.WithQueryParameter("MES4", m3_MES4.Trim());
			if (m3_MVA4.HasValue)
				request.WithQueryParameter("MVA4", m3_MVA4.Value.ToString());
			if (m3_FMPR.HasValue)
				request.WithQueryParameter("FMPR", m3_FMPR.Value.ToString());
			if (m3_RPVA.HasValue)
				request.WithQueryParameter("RPVA", m3_RPVA.Value.ToString());
			if (m3_EVAV.HasValue)
				request.WithQueryParameter("EVAV", m3_EVAV.Value.ToString());
			if (m3_BVAL.HasValue)
				request.WithQueryParameter("BVAL", m3_BVAL.Value.ToString());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());

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
