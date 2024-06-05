/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.STS124MI;
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
	/// Name: STS124MI
	/// Component Name: STR Rates, Meter Prices
	/// Description: API: STR Rates, Meter Prices
	/// Version Release: 5ea1
	///</summary>
	public partial class STS124MIResource : M3BaseResourceEndpoint
	{
		public STS124MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "STS124MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddMeterPrice
		/// Description AddMeterPrice
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3PRRF">Price list (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3AGRS">Contract item (Required)</param>
		/// <param name="m3PSCT">Price schedule type (Required)</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BRAN">Brand</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3ATD1">Agr qty per day 1</param>
		/// <param name="m3ATD2">Agr qty per day 2</param>
		/// <param name="m3ATD3">Agr qty per day 3</param>
		/// <param name="m3ATD0">Agr qty per day 0</param>
		/// <param name="m3AW15">Agr qty per week(5) 1</param>
		/// <param name="m3AW25">Agr qty per week(5) 2</param>
		/// <param name="m3AW35">Agr qty per week(5) 3</param>
		/// <param name="m3AW05">Agr qty per week(5) 0</param>
		/// <param name="m3AW16">Agr qty per week(6) 1</param>
		/// <param name="m3AW26">Agr qty per week(6) 2</param>
		/// <param name="m3AW36">Agr qty per week(6) 3</param>
		/// <param name="m3AW06">Agr qty per week(6) 0</param>
		/// <param name="m3AW17">Agr qty per week(7) 1</param>
		/// <param name="m3AW27">Agr qty per week(7) 2</param>
		/// <param name="m3AW37">Agr qty per week(7) 3</param>
		/// <param name="m3AW07">Agr qty per week(7) 0</param>
		/// <param name="m3AM15">Agr qty per month(5) 1</param>
		/// <param name="m3AM25">Agr qty per month(5) 2</param>
		/// <param name="m3AM35">Agr qty per month(5) 3</param>
		/// <param name="m3AM05">Agr qty per month(5) 0</param>
		/// <param name="m3AM16">Agr qty per month(6) 1</param>
		/// <param name="m3AM26">Agr qty per month(6) 2</param>
		/// <param name="m3AM36">Agr qty per month(6) 3</param>
		/// <param name="m3AM06">Agr qty per month(6) 0</param>
		/// <param name="m3AM17">Agr qty per month(7) 1</param>
		/// <param name="m3AM27">Agr qty per month(7) 2</param>
		/// <param name="m3AM37">Agr qty per month(7) 3</param>
		/// <param name="m3AM07">Agr qty per month(7) 0</param>
		/// <param name="m3OMP1">Overusage price 1</param>
		/// <param name="m3OMP2">Overusage price 2</param>
		/// <param name="m3OMP3">Overusage price 3</param>
		/// <param name="m3OMP0">Overusage price 0</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddMeterPrice(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3STDT, 
			string m3AGRS, 
			int m3PSCT, 
			string m3CUNO = null, 
			string m3ITNO = null, 
			string m3BRAN = null, 
			string m3ITGR = null, 
			decimal? m3ATD1 = null, 
			decimal? m3ATD2 = null, 
			decimal? m3ATD3 = null, 
			decimal? m3ATD0 = null, 
			decimal? m3AW15 = null, 
			decimal? m3AW25 = null, 
			decimal? m3AW35 = null, 
			decimal? m3AW05 = null, 
			decimal? m3AW16 = null, 
			decimal? m3AW26 = null, 
			decimal? m3AW36 = null, 
			decimal? m3AW06 = null, 
			decimal? m3AW17 = null, 
			decimal? m3AW27 = null, 
			decimal? m3AW37 = null, 
			decimal? m3AW07 = null, 
			decimal? m3AM15 = null, 
			decimal? m3AM25 = null, 
			decimal? m3AM35 = null, 
			decimal? m3AM05 = null, 
			decimal? m3AM16 = null, 
			decimal? m3AM26 = null, 
			decimal? m3AM36 = null, 
			decimal? m3AM06 = null, 
			decimal? m3AM17 = null, 
			decimal? m3AM27 = null, 
			decimal? m3AM37 = null, 
			decimal? m3AM07 = null, 
			decimal? m3OMP1 = null, 
			decimal? m3OMP2 = null, 
			decimal? m3OMP3 = null, 
			decimal? m3OMP0 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddMeterPrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3AGRS))
				throw new ArgumentNullException(nameof(m3AGRS));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String())
				.WithQueryParameter("AGRS", m3AGRS.Trim())
				.WithQueryParameter("PSCT", m3PSCT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRAN))
				request.WithQueryParameter("BRAN", m3BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (m3ATD1.HasValue)
				request.WithQueryParameter("ATD1", m3ATD1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATD2.HasValue)
				request.WithQueryParameter("ATD2", m3ATD2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATD3.HasValue)
				request.WithQueryParameter("ATD3", m3ATD3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATD0.HasValue)
				request.WithQueryParameter("ATD0", m3ATD0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AW15.HasValue)
				request.WithQueryParameter("AW15", m3AW15.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AW25.HasValue)
				request.WithQueryParameter("AW25", m3AW25.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AW35.HasValue)
				request.WithQueryParameter("AW35", m3AW35.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AW05.HasValue)
				request.WithQueryParameter("AW05", m3AW05.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AW16.HasValue)
				request.WithQueryParameter("AW16", m3AW16.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AW26.HasValue)
				request.WithQueryParameter("AW26", m3AW26.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AW36.HasValue)
				request.WithQueryParameter("AW36", m3AW36.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AW06.HasValue)
				request.WithQueryParameter("AW06", m3AW06.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AW17.HasValue)
				request.WithQueryParameter("AW17", m3AW17.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AW27.HasValue)
				request.WithQueryParameter("AW27", m3AW27.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AW37.HasValue)
				request.WithQueryParameter("AW37", m3AW37.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AW07.HasValue)
				request.WithQueryParameter("AW07", m3AW07.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AM15.HasValue)
				request.WithQueryParameter("AM15", m3AM15.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AM25.HasValue)
				request.WithQueryParameter("AM25", m3AM25.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AM35.HasValue)
				request.WithQueryParameter("AM35", m3AM35.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AM05.HasValue)
				request.WithQueryParameter("AM05", m3AM05.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AM16.HasValue)
				request.WithQueryParameter("AM16", m3AM16.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AM26.HasValue)
				request.WithQueryParameter("AM26", m3AM26.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AM36.HasValue)
				request.WithQueryParameter("AM36", m3AM36.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AM06.HasValue)
				request.WithQueryParameter("AM06", m3AM06.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AM17.HasValue)
				request.WithQueryParameter("AM17", m3AM17.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AM27.HasValue)
				request.WithQueryParameter("AM27", m3AM27.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AM37.HasValue)
				request.WithQueryParameter("AM37", m3AM37.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AM07.HasValue)
				request.WithQueryParameter("AM07", m3AM07.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OMP1.HasValue)
				request.WithQueryParameter("OMP1", m3OMP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OMP2.HasValue)
				request.WithQueryParameter("OMP2", m3OMP2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OMP3.HasValue)
				request.WithQueryParameter("OMP3", m3OMP3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OMP0.HasValue)
				request.WithQueryParameter("OMP0", m3OMP0.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelMeterPrice
		/// Description DelMeterPrice
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3PRRF">Price list (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BRAN">Brand</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelMeterPrice(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3STDT, 
			string m3CUNO = null, 
			string m3ITNO = null, 
			string m3BRAN = null, 
			string m3ITGR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelMeterPrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRAN))
				request.WithQueryParameter("BRAN", m3BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());

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
		/// Name GetMeterPrice
		/// Description GetMeterPrice
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3PRRF">Price list (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BRAN">Brand</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMeterPriceResponse></returns>
		/// <exception cref="M3Exception<GetMeterPriceResponse>"></exception>
		public async Task<M3Response<GetMeterPriceResponse>> GetMeterPrice(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3STDT, 
			string m3CUNO = null, 
			string m3ITNO = null, 
			string m3BRAN = null, 
			string m3ITGR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetMeterPrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRAN))
				request.WithQueryParameter("BRAN", m3BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());

			// Execute the request
			var result = await Execute<GetMeterPriceResponse>(
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
		/// Name GetMeterPrice2
		/// Description GetMeterPrice2
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3PRRF">Price list</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMeterPrice2Response></returns>
		/// <exception cref="M3Exception<GetMeterPrice2Response>"></exception>
		public async Task<M3Response<GetMeterPrice2Response>> GetMeterPrice2(
			string m3ITNO, 
			string m3PRRF = null, 
			string m3CUCD = null, 
			string m3CUNO = null, 
			DateTime? m3STDT = null, 
			string m3WHLO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetMeterPrice2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRRF))
				request.WithQueryParameter("PRRF", m3PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Execute the request
			var result = await Execute<GetMeterPrice2Response>(
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
		/// Name LstMeterPrice
		/// Description LstMeterPrice
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3PRRF">Price list (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BRAN">Brand</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMeterPriceResponse></returns>
		/// <exception cref="M3Exception<LstMeterPriceResponse>"></exception>
		public async Task<M3Response<LstMeterPriceResponse>> LstMeterPrice(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3STDT, 
			string m3CUNO = null, 
			string m3ITNO = null, 
			string m3BRAN = null, 
			string m3ITGR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMeterPrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRAN))
				request.WithQueryParameter("BRAN", m3BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());

			// Execute the request
			var result = await Execute<LstMeterPriceResponse>(
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
		/// Name UpdMeterPrice
		/// Description UpdMeterPrice
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3PRRF">Price list (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BRAN">Brand</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3AGRS">Contract item</param>
		/// <param name="m3PSCT">Price schedule type</param>
		/// <param name="m3ATD1">Agr qty per day 1</param>
		/// <param name="m3ATD2">Agr qty per day 2</param>
		/// <param name="m3ATD3">Agr qty per day 3</param>
		/// <param name="m3ATD0">Agr qty per day 0</param>
		/// <param name="m3AW15">Agr qty per week(5) 1</param>
		/// <param name="m3AW25">Agr qty per week(5) 2</param>
		/// <param name="m3AW35">Agr qty per week(5) 3</param>
		/// <param name="m3AW05">Agr qty per week(5) 0</param>
		/// <param name="m3AW16">Agr qty per week(6) 1</param>
		/// <param name="m3AW26">Agr qty per week(6) 2</param>
		/// <param name="m3AW36">Agr qty per week(6) 3</param>
		/// <param name="m3AW06">Agr qty per week(6) 0</param>
		/// <param name="m3AW17">Agr qty per week(7) 1</param>
		/// <param name="m3AW27">Agr qty per week(7) 2</param>
		/// <param name="m3AW37">Agr qty per week(7) 3</param>
		/// <param name="m3AW07">Agr qty per week(7) 0</param>
		/// <param name="m3AM15">Agr qty per month(5) 1</param>
		/// <param name="m3AM25">Agr qty per month(5) 2</param>
		/// <param name="m3AM35">Agr qty per month(5) 3</param>
		/// <param name="m3AM05">Agr qty per month(5) 0</param>
		/// <param name="m3AM16">Agr qty per month(6) 1</param>
		/// <param name="m3AM26">Agr qty per month(6) 2</param>
		/// <param name="m3AM36">Agr qty per month(6) 3</param>
		/// <param name="m3AM06">Agr qty per month(6) 0</param>
		/// <param name="m3AM17">Agr qty per month(7) 1</param>
		/// <param name="m3AM27">Agr qty per month(7) 2</param>
		/// <param name="m3AM37">Agr qty per month(7) 3</param>
		/// <param name="m3AM07">Agr qty per month(7) 0</param>
		/// <param name="m3OMP1">Overusage price 1</param>
		/// <param name="m3OMP2">Overusage price 2</param>
		/// <param name="m3OMP3">Overusage price 3</param>
		/// <param name="m3OMP0">Overusage price 0</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdMeterPrice(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3STDT, 
			string m3CUNO = null, 
			string m3ITNO = null, 
			string m3BRAN = null, 
			string m3ITGR = null, 
			string m3AGRS = null, 
			int? m3PSCT = null, 
			decimal? m3ATD1 = null, 
			decimal? m3ATD2 = null, 
			decimal? m3ATD3 = null, 
			decimal? m3ATD0 = null, 
			decimal? m3AW15 = null, 
			decimal? m3AW25 = null, 
			decimal? m3AW35 = null, 
			decimal? m3AW05 = null, 
			decimal? m3AW16 = null, 
			decimal? m3AW26 = null, 
			decimal? m3AW36 = null, 
			decimal? m3AW06 = null, 
			decimal? m3AW17 = null, 
			decimal? m3AW27 = null, 
			decimal? m3AW37 = null, 
			decimal? m3AW07 = null, 
			decimal? m3AM15 = null, 
			decimal? m3AM25 = null, 
			decimal? m3AM35 = null, 
			decimal? m3AM05 = null, 
			decimal? m3AM16 = null, 
			decimal? m3AM26 = null, 
			decimal? m3AM36 = null, 
			decimal? m3AM06 = null, 
			decimal? m3AM17 = null, 
			decimal? m3AM27 = null, 
			decimal? m3AM37 = null, 
			decimal? m3AM07 = null, 
			decimal? m3OMP1 = null, 
			decimal? m3OMP2 = null, 
			decimal? m3OMP3 = null, 
			decimal? m3OMP0 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdMeterPrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRAN))
				request.WithQueryParameter("BRAN", m3BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGRS))
				request.WithQueryParameter("AGRS", m3AGRS.Trim());
			if (m3PSCT.HasValue)
				request.WithQueryParameter("PSCT", m3PSCT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATD1.HasValue)
				request.WithQueryParameter("ATD1", m3ATD1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATD2.HasValue)
				request.WithQueryParameter("ATD2", m3ATD2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATD3.HasValue)
				request.WithQueryParameter("ATD3", m3ATD3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATD0.HasValue)
				request.WithQueryParameter("ATD0", m3ATD0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AW15.HasValue)
				request.WithQueryParameter("AW15", m3AW15.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AW25.HasValue)
				request.WithQueryParameter("AW25", m3AW25.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AW35.HasValue)
				request.WithQueryParameter("AW35", m3AW35.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AW05.HasValue)
				request.WithQueryParameter("AW05", m3AW05.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AW16.HasValue)
				request.WithQueryParameter("AW16", m3AW16.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AW26.HasValue)
				request.WithQueryParameter("AW26", m3AW26.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AW36.HasValue)
				request.WithQueryParameter("AW36", m3AW36.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AW06.HasValue)
				request.WithQueryParameter("AW06", m3AW06.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AW17.HasValue)
				request.WithQueryParameter("AW17", m3AW17.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AW27.HasValue)
				request.WithQueryParameter("AW27", m3AW27.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AW37.HasValue)
				request.WithQueryParameter("AW37", m3AW37.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AW07.HasValue)
				request.WithQueryParameter("AW07", m3AW07.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AM15.HasValue)
				request.WithQueryParameter("AM15", m3AM15.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AM25.HasValue)
				request.WithQueryParameter("AM25", m3AM25.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AM35.HasValue)
				request.WithQueryParameter("AM35", m3AM35.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AM05.HasValue)
				request.WithQueryParameter("AM05", m3AM05.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AM16.HasValue)
				request.WithQueryParameter("AM16", m3AM16.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AM26.HasValue)
				request.WithQueryParameter("AM26", m3AM26.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AM36.HasValue)
				request.WithQueryParameter("AM36", m3AM36.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AM06.HasValue)
				request.WithQueryParameter("AM06", m3AM06.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AM17.HasValue)
				request.WithQueryParameter("AM17", m3AM17.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AM27.HasValue)
				request.WithQueryParameter("AM27", m3AM27.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AM37.HasValue)
				request.WithQueryParameter("AM37", m3AM37.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AM07.HasValue)
				request.WithQueryParameter("AM07", m3AM07.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OMP1.HasValue)
				request.WithQueryParameter("OMP1", m3OMP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OMP2.HasValue)
				request.WithQueryParameter("OMP2", m3OMP2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OMP3.HasValue)
				request.WithQueryParameter("OMP3", m3OMP3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OMP0.HasValue)
				request.WithQueryParameter("OMP0", m3OMP0.Value.ToString(CultureInfo.CurrentCulture));

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
