/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3SCMO">Costing model - sales price</param>
		/// <param name="m3ACGR">Object access group</param>
		/// <param name="m3ROPP">Rounding-off category</param>
		/// <param name="m3CRTP">Exchange rate type</param>
		/// <param name="m3NTCD">Net price used</param>
		/// <param name="m3BNCD">Bonus generating</param>
		/// <param name="m3PRAC">Commission generating</param>
		/// <param name="m3MES1">Meter 1</param>
		/// <param name="m3MVA1">Meter value 1</param>
		/// <param name="m3MES2">Meter 2</param>
		/// <param name="m3MVA2">Meter value 2</param>
		/// <param name="m3MES3">Meter 3</param>
		/// <param name="m3MVA3">Meter value 3</param>
		/// <param name="m3MES4">Meter 4</param>
		/// <param name="m3MVA4">Meter value 4</param>
		/// <param name="m3FMPR">Fair market price</param>
		/// <param name="m3RPVA">Replacement cost</param>
		/// <param name="m3EVAV">Evaluation value</param>
		/// <param name="m3BVAL">Base value for calculation</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3ITNO, 
			string m3SERN, 
			string m3CUCD, 
			DateTime m3FVDT, 
			DateTime? m3LVDT = null, 
			string m3STAT = null, 
			string m3SCMO = null, 
			string m3ACGR = null, 
			int? m3ROPP = null, 
			int? m3CRTP = null, 
			int? m3NTCD = null, 
			int? m3BNCD = null, 
			int? m3PRAC = null, 
			string m3MES1 = null, 
			decimal? m3MVA1 = null, 
			string m3MES2 = null, 
			decimal? m3MVA2 = null, 
			string m3MES3 = null, 
			decimal? m3MVA3 = null, 
			string m3MES4 = null, 
			decimal? m3MVA4 = null, 
			decimal? m3FMPR = null, 
			decimal? m3RPVA = null, 
			decimal? m3EVAV = null, 
			decimal? m3BVAL = null, 
			decimal? m3SAPR = null, 
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
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SCMO))
				request.WithQueryParameter("SCMO", m3SCMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACGR))
				request.WithQueryParameter("ACGR", m3ACGR.Trim());
			if (m3ROPP.HasValue)
				request.WithQueryParameter("ROPP", m3ROPP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3CRTP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NTCD.HasValue)
				request.WithQueryParameter("NTCD", m3NTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BNCD.HasValue)
				request.WithQueryParameter("BNCD", m3BNCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRAC.HasValue)
				request.WithQueryParameter("PRAC", m3PRAC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MES1))
				request.WithQueryParameter("MES1", m3MES1.Trim());
			if (m3MVA1.HasValue)
				request.WithQueryParameter("MVA1", m3MVA1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MES2))
				request.WithQueryParameter("MES2", m3MES2.Trim());
			if (m3MVA2.HasValue)
				request.WithQueryParameter("MVA2", m3MVA2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MES3))
				request.WithQueryParameter("MES3", m3MES3.Trim());
			if (m3MVA3.HasValue)
				request.WithQueryParameter("MVA3", m3MVA3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MES4))
				request.WithQueryParameter("MES4", m3MES4.Trim());
			if (m3MVA4.HasValue)
				request.WithQueryParameter("MVA4", m3MVA4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FMPR.HasValue)
				request.WithQueryParameter("FMPR", m3FMPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPVA.HasValue)
				request.WithQueryParameter("RPVA", m3RPVA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EVAV.HasValue)
				request.WithQueryParameter("EVAV", m3EVAV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BVAL.HasValue)
				request.WithQueryParameter("BVAL", m3BVAL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Del
		/// Description Delete
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			string m3ITNO, 
			string m3SERN, 
			string m3CUCD, 
			DateTime m3FVDT, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

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
		/// Name GetSerialPrice
		/// Description Get Serialized based price.
		/// Version Release: 
		/// </summary>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSerialPriceResponse></returns>
		/// <exception cref="M3Exception<GetSerialPriceResponse>"></exception>
		public async Task<M3Response<GetSerialPriceResponse>> GetSerialPrice(
			string m3ITNO = null, 
			string m3SERN = null, 
			string m3CUCD = null, 
			DateTime? m3FVDT = null, 
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
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetSerialPriceResponse>(
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
		/// Name LstItem
		/// Description List Serialized based price by item
		/// Version Release: 
		/// </summary>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemResponse></returns>
		/// <exception cref="M3Exception<LstItemResponse>"></exception>
		public async Task<M3Response<LstItemResponse>> LstItem(
			string m3ITNO = null, 
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
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<LstItemResponse>(
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
		/// Name LstItemSerCurr
		/// Description List Serialized based price by item serial number currency
		/// Version Release: 
		/// </summary>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemSerCurrResponse></returns>
		/// <exception cref="M3Exception<LstItemSerCurrResponse>"></exception>
		public async Task<M3Response<LstItemSerCurrResponse>> LstItemSerCurr(
			string m3ITNO = null, 
			string m3SERN = null, 
			string m3CUCD = null, 
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
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());

			// Execute the request
			var result = await Execute<LstItemSerCurrResponse>(
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
		/// Name LstItemSerial
		/// Description List Serialized based price by item serial number
		/// Version Release: 
		/// </summary>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemSerialResponse></returns>
		/// <exception cref="M3Exception<LstItemSerialResponse>"></exception>
		public async Task<M3Response<LstItemSerialResponse>> LstItemSerial(
			string m3ITNO = null, 
			string m3SERN = null, 
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
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());

			// Execute the request
			var result = await Execute<LstItemSerialResponse>(
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
		/// Description Update
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3SCMO">Costing model - sales price</param>
		/// <param name="m3ACGR">Object access group</param>
		/// <param name="m3ROPP">Rounding-off category</param>
		/// <param name="m3CRTP">Exchange rate type</param>
		/// <param name="m3NTCD">Net price used</param>
		/// <param name="m3BNCD">Bonus generating</param>
		/// <param name="m3PRAC">Commission generating</param>
		/// <param name="m3MES1">Meter 1</param>
		/// <param name="m3MVA1">Meter value 1</param>
		/// <param name="m3MES2">Meter 2</param>
		/// <param name="m3MVA2">Meter value 2</param>
		/// <param name="m3MES3">Meter 3</param>
		/// <param name="m3MVA3">Meter value 3</param>
		/// <param name="m3MES4">Meter 4</param>
		/// <param name="m3MVA4">Meter value 4</param>
		/// <param name="m3FMPR">Fair market price</param>
		/// <param name="m3RPVA">Replacement cost</param>
		/// <param name="m3EVAV">Evaluation value</param>
		/// <param name="m3BVAL">Base value for calculation</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3ITNO, 
			string m3SERN, 
			string m3CUCD, 
			DateTime m3FVDT, 
			DateTime? m3LVDT = null, 
			string m3STAT = null, 
			string m3SCMO = null, 
			string m3ACGR = null, 
			int? m3ROPP = null, 
			int? m3CRTP = null, 
			int? m3NTCD = null, 
			int? m3BNCD = null, 
			int? m3PRAC = null, 
			string m3MES1 = null, 
			decimal? m3MVA1 = null, 
			string m3MES2 = null, 
			decimal? m3MVA2 = null, 
			string m3MES3 = null, 
			decimal? m3MVA3 = null, 
			string m3MES4 = null, 
			decimal? m3MVA4 = null, 
			decimal? m3FMPR = null, 
			decimal? m3RPVA = null, 
			decimal? m3EVAV = null, 
			decimal? m3BVAL = null, 
			decimal? m3SAPR = null, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SCMO))
				request.WithQueryParameter("SCMO", m3SCMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACGR))
				request.WithQueryParameter("ACGR", m3ACGR.Trim());
			if (m3ROPP.HasValue)
				request.WithQueryParameter("ROPP", m3ROPP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3CRTP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NTCD.HasValue)
				request.WithQueryParameter("NTCD", m3NTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BNCD.HasValue)
				request.WithQueryParameter("BNCD", m3BNCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRAC.HasValue)
				request.WithQueryParameter("PRAC", m3PRAC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MES1))
				request.WithQueryParameter("MES1", m3MES1.Trim());
			if (m3MVA1.HasValue)
				request.WithQueryParameter("MVA1", m3MVA1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MES2))
				request.WithQueryParameter("MES2", m3MES2.Trim());
			if (m3MVA2.HasValue)
				request.WithQueryParameter("MVA2", m3MVA2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MES3))
				request.WithQueryParameter("MES3", m3MES3.Trim());
			if (m3MVA3.HasValue)
				request.WithQueryParameter("MVA3", m3MVA3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MES4))
				request.WithQueryParameter("MES4", m3MES4.Trim());
			if (m3MVA4.HasValue)
				request.WithQueryParameter("MVA4", m3MVA4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FMPR.HasValue)
				request.WithQueryParameter("FMPR", m3FMPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPVA.HasValue)
				request.WithQueryParameter("RPVA", m3RPVA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EVAV.HasValue)
				request.WithQueryParameter("EVAV", m3EVAV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BVAL.HasValue)
				request.WithQueryParameter("BVAL", m3BVAL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));

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
