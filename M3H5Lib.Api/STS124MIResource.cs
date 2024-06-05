/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddMeterPrice
		/// Description AddMeterPrice
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_PRRF">Price list (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_AGRS">Contract item (Required)</param>
		/// <param name="m3_PSCT">Price schedule type (Required)</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BRAN">Brand</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_ATD1">Agr qty per day 1</param>
		/// <param name="m3_ATD2">Agr qty per day 2</param>
		/// <param name="m3_ATD3">Agr qty per day 3</param>
		/// <param name="m3_ATD0">Agr qty per day 0</param>
		/// <param name="m3_AW15">Agr qty per week(5) 1</param>
		/// <param name="m3_AW25">Agr qty per week(5) 2</param>
		/// <param name="m3_AW35">Agr qty per week(5) 3</param>
		/// <param name="m3_AW05">Agr qty per week(5) 0</param>
		/// <param name="m3_AW16">Agr qty per week(6) 1</param>
		/// <param name="m3_AW26">Agr qty per week(6) 2</param>
		/// <param name="m3_AW36">Agr qty per week(6) 3</param>
		/// <param name="m3_AW06">Agr qty per week(6) 0</param>
		/// <param name="m3_AW17">Agr qty per week(7) 1</param>
		/// <param name="m3_AW27">Agr qty per week(7) 2</param>
		/// <param name="m3_AW37">Agr qty per week(7) 3</param>
		/// <param name="m3_AW07">Agr qty per week(7) 0</param>
		/// <param name="m3_AM15">Agr qty per month(5) 1</param>
		/// <param name="m3_AM25">Agr qty per month(5) 2</param>
		/// <param name="m3_AM35">Agr qty per month(5) 3</param>
		/// <param name="m3_AM05">Agr qty per month(5) 0</param>
		/// <param name="m3_AM16">Agr qty per month(6) 1</param>
		/// <param name="m3_AM26">Agr qty per month(6) 2</param>
		/// <param name="m3_AM36">Agr qty per month(6) 3</param>
		/// <param name="m3_AM06">Agr qty per month(6) 0</param>
		/// <param name="m3_AM17">Agr qty per month(7) 1</param>
		/// <param name="m3_AM27">Agr qty per month(7) 2</param>
		/// <param name="m3_AM37">Agr qty per month(7) 3</param>
		/// <param name="m3_AM07">Agr qty per month(7) 0</param>
		/// <param name="m3_OMP1">Overusage price 1</param>
		/// <param name="m3_OMP2">Overusage price 2</param>
		/// <param name="m3_OMP3">Overusage price 3</param>
		/// <param name="m3_OMP0">Overusage price 0</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddMeterPrice(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_STDT, 
			string m3_AGRS, 
			int m3_PSCT, 
			string m3_CUNO = null, 
			string m3_ITNO = null, 
			string m3_BRAN = null, 
			string m3_ITGR = null, 
			decimal? m3_ATD1 = null, 
			decimal? m3_ATD2 = null, 
			decimal? m3_ATD3 = null, 
			decimal? m3_ATD0 = null, 
			decimal? m3_AW15 = null, 
			decimal? m3_AW25 = null, 
			decimal? m3_AW35 = null, 
			decimal? m3_AW05 = null, 
			decimal? m3_AW16 = null, 
			decimal? m3_AW26 = null, 
			decimal? m3_AW36 = null, 
			decimal? m3_AW06 = null, 
			decimal? m3_AW17 = null, 
			decimal? m3_AW27 = null, 
			decimal? m3_AW37 = null, 
			decimal? m3_AW07 = null, 
			decimal? m3_AM15 = null, 
			decimal? m3_AM25 = null, 
			decimal? m3_AM35 = null, 
			decimal? m3_AM05 = null, 
			decimal? m3_AM16 = null, 
			decimal? m3_AM26 = null, 
			decimal? m3_AM36 = null, 
			decimal? m3_AM06 = null, 
			decimal? m3_AM17 = null, 
			decimal? m3_AM27 = null, 
			decimal? m3_AM37 = null, 
			decimal? m3_AM07 = null, 
			decimal? m3_OMP1 = null, 
			decimal? m3_OMP2 = null, 
			decimal? m3_OMP3 = null, 
			decimal? m3_OMP0 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddMeterPrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_AGRS))
				throw new ArgumentNullException("m3_AGRS");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("AGRS", m3_AGRS.Trim())
				.WithQueryParameter("PSCT", m3_PSCT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRAN))
				request.WithQueryParameter("BRAN", m3_BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (m3_ATD1.HasValue)
				request.WithQueryParameter("ATD1", m3_ATD1.Value.ToString());
			if (m3_ATD2.HasValue)
				request.WithQueryParameter("ATD2", m3_ATD2.Value.ToString());
			if (m3_ATD3.HasValue)
				request.WithQueryParameter("ATD3", m3_ATD3.Value.ToString());
			if (m3_ATD0.HasValue)
				request.WithQueryParameter("ATD0", m3_ATD0.Value.ToString());
			if (m3_AW15.HasValue)
				request.WithQueryParameter("AW15", m3_AW15.Value.ToString());
			if (m3_AW25.HasValue)
				request.WithQueryParameter("AW25", m3_AW25.Value.ToString());
			if (m3_AW35.HasValue)
				request.WithQueryParameter("AW35", m3_AW35.Value.ToString());
			if (m3_AW05.HasValue)
				request.WithQueryParameter("AW05", m3_AW05.Value.ToString());
			if (m3_AW16.HasValue)
				request.WithQueryParameter("AW16", m3_AW16.Value.ToString());
			if (m3_AW26.HasValue)
				request.WithQueryParameter("AW26", m3_AW26.Value.ToString());
			if (m3_AW36.HasValue)
				request.WithQueryParameter("AW36", m3_AW36.Value.ToString());
			if (m3_AW06.HasValue)
				request.WithQueryParameter("AW06", m3_AW06.Value.ToString());
			if (m3_AW17.HasValue)
				request.WithQueryParameter("AW17", m3_AW17.Value.ToString());
			if (m3_AW27.HasValue)
				request.WithQueryParameter("AW27", m3_AW27.Value.ToString());
			if (m3_AW37.HasValue)
				request.WithQueryParameter("AW37", m3_AW37.Value.ToString());
			if (m3_AW07.HasValue)
				request.WithQueryParameter("AW07", m3_AW07.Value.ToString());
			if (m3_AM15.HasValue)
				request.WithQueryParameter("AM15", m3_AM15.Value.ToString());
			if (m3_AM25.HasValue)
				request.WithQueryParameter("AM25", m3_AM25.Value.ToString());
			if (m3_AM35.HasValue)
				request.WithQueryParameter("AM35", m3_AM35.Value.ToString());
			if (m3_AM05.HasValue)
				request.WithQueryParameter("AM05", m3_AM05.Value.ToString());
			if (m3_AM16.HasValue)
				request.WithQueryParameter("AM16", m3_AM16.Value.ToString());
			if (m3_AM26.HasValue)
				request.WithQueryParameter("AM26", m3_AM26.Value.ToString());
			if (m3_AM36.HasValue)
				request.WithQueryParameter("AM36", m3_AM36.Value.ToString());
			if (m3_AM06.HasValue)
				request.WithQueryParameter("AM06", m3_AM06.Value.ToString());
			if (m3_AM17.HasValue)
				request.WithQueryParameter("AM17", m3_AM17.Value.ToString());
			if (m3_AM27.HasValue)
				request.WithQueryParameter("AM27", m3_AM27.Value.ToString());
			if (m3_AM37.HasValue)
				request.WithQueryParameter("AM37", m3_AM37.Value.ToString());
			if (m3_AM07.HasValue)
				request.WithQueryParameter("AM07", m3_AM07.Value.ToString());
			if (m3_OMP1.HasValue)
				request.WithQueryParameter("OMP1", m3_OMP1.Value.ToString());
			if (m3_OMP2.HasValue)
				request.WithQueryParameter("OMP2", m3_OMP2.Value.ToString());
			if (m3_OMP3.HasValue)
				request.WithQueryParameter("OMP3", m3_OMP3.Value.ToString());
			if (m3_OMP0.HasValue)
				request.WithQueryParameter("OMP0", m3_OMP0.Value.ToString());

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
		/// Name DelMeterPrice
		/// Description DelMeterPrice
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_PRRF">Price list (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BRAN">Brand</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelMeterPrice(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_STDT, 
			string m3_CUNO = null, 
			string m3_ITNO = null, 
			string m3_BRAN = null, 
			string m3_ITGR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelMeterPrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRAN))
				request.WithQueryParameter("BRAN", m3_BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());

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
		/// Name GetMeterPrice
		/// Description GetMeterPrice
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_PRRF">Price list (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BRAN">Brand</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMeterPriceResponse></returns>
		/// <exception cref="M3Exception<GetMeterPriceResponse>"></exception>
		public async Task<M3Response<GetMeterPriceResponse>> GetMeterPrice(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_STDT, 
			string m3_CUNO = null, 
			string m3_ITNO = null, 
			string m3_BRAN = null, 
			string m3_ITGR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMeterPrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRAN))
				request.WithQueryParameter("BRAN", m3_BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());

			// Execute the request
			var result = await Execute<GetMeterPriceResponse>(
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
		/// Name GetMeterPrice2
		/// Description GetMeterPrice2
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_PRRF">Price list</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMeterPrice2Response></returns>
		/// <exception cref="M3Exception<GetMeterPrice2Response>"></exception>
		public async Task<M3Response<GetMeterPrice2Response>> GetMeterPrice2(
			string m3_ITNO, 
			string m3_PRRF = null, 
			string m3_CUCD = null, 
			string m3_CUNO = null, 
			DateTime? m3_STDT = null, 
			string m3_WHLO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMeterPrice2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRRF))
				request.WithQueryParameter("PRRF", m3_PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Execute the request
			var result = await Execute<GetMeterPrice2Response>(
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
		/// Name LstMeterPrice
		/// Description LstMeterPrice
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_PRRF">Price list (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BRAN">Brand</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMeterPriceResponse></returns>
		/// <exception cref="M3Exception<LstMeterPriceResponse>"></exception>
		public async Task<M3Response<LstMeterPriceResponse>> LstMeterPrice(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_STDT, 
			string m3_CUNO = null, 
			string m3_ITNO = null, 
			string m3_BRAN = null, 
			string m3_ITGR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMeterPrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRAN))
				request.WithQueryParameter("BRAN", m3_BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());

			// Execute the request
			var result = await Execute<LstMeterPriceResponse>(
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
		/// Name UpdMeterPrice
		/// Description UpdMeterPrice
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_PRRF">Price list (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BRAN">Brand</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_AGRS">Contract item</param>
		/// <param name="m3_PSCT">Price schedule type</param>
		/// <param name="m3_ATD1">Agr qty per day 1</param>
		/// <param name="m3_ATD2">Agr qty per day 2</param>
		/// <param name="m3_ATD3">Agr qty per day 3</param>
		/// <param name="m3_ATD0">Agr qty per day 0</param>
		/// <param name="m3_AW15">Agr qty per week(5) 1</param>
		/// <param name="m3_AW25">Agr qty per week(5) 2</param>
		/// <param name="m3_AW35">Agr qty per week(5) 3</param>
		/// <param name="m3_AW05">Agr qty per week(5) 0</param>
		/// <param name="m3_AW16">Agr qty per week(6) 1</param>
		/// <param name="m3_AW26">Agr qty per week(6) 2</param>
		/// <param name="m3_AW36">Agr qty per week(6) 3</param>
		/// <param name="m3_AW06">Agr qty per week(6) 0</param>
		/// <param name="m3_AW17">Agr qty per week(7) 1</param>
		/// <param name="m3_AW27">Agr qty per week(7) 2</param>
		/// <param name="m3_AW37">Agr qty per week(7) 3</param>
		/// <param name="m3_AW07">Agr qty per week(7) 0</param>
		/// <param name="m3_AM15">Agr qty per month(5) 1</param>
		/// <param name="m3_AM25">Agr qty per month(5) 2</param>
		/// <param name="m3_AM35">Agr qty per month(5) 3</param>
		/// <param name="m3_AM05">Agr qty per month(5) 0</param>
		/// <param name="m3_AM16">Agr qty per month(6) 1</param>
		/// <param name="m3_AM26">Agr qty per month(6) 2</param>
		/// <param name="m3_AM36">Agr qty per month(6) 3</param>
		/// <param name="m3_AM06">Agr qty per month(6) 0</param>
		/// <param name="m3_AM17">Agr qty per month(7) 1</param>
		/// <param name="m3_AM27">Agr qty per month(7) 2</param>
		/// <param name="m3_AM37">Agr qty per month(7) 3</param>
		/// <param name="m3_AM07">Agr qty per month(7) 0</param>
		/// <param name="m3_OMP1">Overusage price 1</param>
		/// <param name="m3_OMP2">Overusage price 2</param>
		/// <param name="m3_OMP3">Overusage price 3</param>
		/// <param name="m3_OMP0">Overusage price 0</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdMeterPrice(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_STDT, 
			string m3_CUNO = null, 
			string m3_ITNO = null, 
			string m3_BRAN = null, 
			string m3_ITGR = null, 
			string m3_AGRS = null, 
			int? m3_PSCT = null, 
			decimal? m3_ATD1 = null, 
			decimal? m3_ATD2 = null, 
			decimal? m3_ATD3 = null, 
			decimal? m3_ATD0 = null, 
			decimal? m3_AW15 = null, 
			decimal? m3_AW25 = null, 
			decimal? m3_AW35 = null, 
			decimal? m3_AW05 = null, 
			decimal? m3_AW16 = null, 
			decimal? m3_AW26 = null, 
			decimal? m3_AW36 = null, 
			decimal? m3_AW06 = null, 
			decimal? m3_AW17 = null, 
			decimal? m3_AW27 = null, 
			decimal? m3_AW37 = null, 
			decimal? m3_AW07 = null, 
			decimal? m3_AM15 = null, 
			decimal? m3_AM25 = null, 
			decimal? m3_AM35 = null, 
			decimal? m3_AM05 = null, 
			decimal? m3_AM16 = null, 
			decimal? m3_AM26 = null, 
			decimal? m3_AM36 = null, 
			decimal? m3_AM06 = null, 
			decimal? m3_AM17 = null, 
			decimal? m3_AM27 = null, 
			decimal? m3_AM37 = null, 
			decimal? m3_AM07 = null, 
			decimal? m3_OMP1 = null, 
			decimal? m3_OMP2 = null, 
			decimal? m3_OMP3 = null, 
			decimal? m3_OMP0 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdMeterPrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRAN))
				request.WithQueryParameter("BRAN", m3_BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGRS))
				request.WithQueryParameter("AGRS", m3_AGRS.Trim());
			if (m3_PSCT.HasValue)
				request.WithQueryParameter("PSCT", m3_PSCT.Value.ToString());
			if (m3_ATD1.HasValue)
				request.WithQueryParameter("ATD1", m3_ATD1.Value.ToString());
			if (m3_ATD2.HasValue)
				request.WithQueryParameter("ATD2", m3_ATD2.Value.ToString());
			if (m3_ATD3.HasValue)
				request.WithQueryParameter("ATD3", m3_ATD3.Value.ToString());
			if (m3_ATD0.HasValue)
				request.WithQueryParameter("ATD0", m3_ATD0.Value.ToString());
			if (m3_AW15.HasValue)
				request.WithQueryParameter("AW15", m3_AW15.Value.ToString());
			if (m3_AW25.HasValue)
				request.WithQueryParameter("AW25", m3_AW25.Value.ToString());
			if (m3_AW35.HasValue)
				request.WithQueryParameter("AW35", m3_AW35.Value.ToString());
			if (m3_AW05.HasValue)
				request.WithQueryParameter("AW05", m3_AW05.Value.ToString());
			if (m3_AW16.HasValue)
				request.WithQueryParameter("AW16", m3_AW16.Value.ToString());
			if (m3_AW26.HasValue)
				request.WithQueryParameter("AW26", m3_AW26.Value.ToString());
			if (m3_AW36.HasValue)
				request.WithQueryParameter("AW36", m3_AW36.Value.ToString());
			if (m3_AW06.HasValue)
				request.WithQueryParameter("AW06", m3_AW06.Value.ToString());
			if (m3_AW17.HasValue)
				request.WithQueryParameter("AW17", m3_AW17.Value.ToString());
			if (m3_AW27.HasValue)
				request.WithQueryParameter("AW27", m3_AW27.Value.ToString());
			if (m3_AW37.HasValue)
				request.WithQueryParameter("AW37", m3_AW37.Value.ToString());
			if (m3_AW07.HasValue)
				request.WithQueryParameter("AW07", m3_AW07.Value.ToString());
			if (m3_AM15.HasValue)
				request.WithQueryParameter("AM15", m3_AM15.Value.ToString());
			if (m3_AM25.HasValue)
				request.WithQueryParameter("AM25", m3_AM25.Value.ToString());
			if (m3_AM35.HasValue)
				request.WithQueryParameter("AM35", m3_AM35.Value.ToString());
			if (m3_AM05.HasValue)
				request.WithQueryParameter("AM05", m3_AM05.Value.ToString());
			if (m3_AM16.HasValue)
				request.WithQueryParameter("AM16", m3_AM16.Value.ToString());
			if (m3_AM26.HasValue)
				request.WithQueryParameter("AM26", m3_AM26.Value.ToString());
			if (m3_AM36.HasValue)
				request.WithQueryParameter("AM36", m3_AM36.Value.ToString());
			if (m3_AM06.HasValue)
				request.WithQueryParameter("AM06", m3_AM06.Value.ToString());
			if (m3_AM17.HasValue)
				request.WithQueryParameter("AM17", m3_AM17.Value.ToString());
			if (m3_AM27.HasValue)
				request.WithQueryParameter("AM27", m3_AM27.Value.ToString());
			if (m3_AM37.HasValue)
				request.WithQueryParameter("AM37", m3_AM37.Value.ToString());
			if (m3_AM07.HasValue)
				request.WithQueryParameter("AM07", m3_AM07.Value.ToString());
			if (m3_OMP1.HasValue)
				request.WithQueryParameter("OMP1", m3_OMP1.Value.ToString());
			if (m3_OMP2.HasValue)
				request.WithQueryParameter("OMP2", m3_OMP2.Value.ToString());
			if (m3_OMP3.HasValue)
				request.WithQueryParameter("OMP3", m3_OMP3.Value.ToString());
			if (m3_OMP0.HasValue)
				request.WithQueryParameter("OMP0", m3_OMP0.Value.ToString());

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
