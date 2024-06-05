/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.STS125MI;
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
	/// Name: STS125MI
	/// Component Name: STR Rates: Enter Package Price
	/// Description: API: STR Rates: Enter Package Price
	/// Version Release: 5e90
	///</summary>
	public partial class STS125MIResource : M3BaseResourceEndpoint
	{
		public STS125MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "STS125MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddPckgRate
		/// Description AddPckgRate
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_PRRF">Price list (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_PKID">Package ID (Required)</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_HPS1">Hourly rate 1</param>
		/// <param name="m3_HPS2">Hourly rate 2</param>
		/// <param name="m3_HPS3">Hourly rate 3</param>
		/// <param name="m3_HPS0">Hourly rate 0</param>
		/// <param name="m3_DPS1">Daily rate 1</param>
		/// <param name="m3_DPS2">Daily rate 2</param>
		/// <param name="m3_DPS3">Daily rate 3</param>
		/// <param name="m3_DPS0">Daily rate 0</param>
		/// <param name="m3_WP15">Week rate(5) 1</param>
		/// <param name="m3_WP25">Week rate(5) 2</param>
		/// <param name="m3_WP35">Week rate(5) 3</param>
		/// <param name="m3_WP05">Week rate(5) 0</param>
		/// <param name="m3_WP16">Week rate(6) 1</param>
		/// <param name="m3_WP26">Week rate(6) 2</param>
		/// <param name="m3_WP36">Week rate(6) 3</param>
		/// <param name="m3_WP06">Week rate(6) 0</param>
		/// <param name="m3_WP17">Week rate(7) 1</param>
		/// <param name="m3_WP27">Week rate(7) 2</param>
		/// <param name="m3_WP37">Week rate(7) 3</param>
		/// <param name="m3_WP07">Week rate(7) 0</param>
		/// <param name="m3_MP15">Monthly rate(5) 1</param>
		/// <param name="m3_MP25">Monthly rate(5) 2</param>
		/// <param name="m3_MP35">Monthly rate(5) 3</param>
		/// <param name="m3_MP05">Monthly rate(5) 0</param>
		/// <param name="m3_MP16">Monthly rate(6) 1</param>
		/// <param name="m3_MP26">Monthly rate(6) 2</param>
		/// <param name="m3_MP36">Monthly rate(6) 3</param>
		/// <param name="m3_MP06">Monthly rate(6) 0</param>
		/// <param name="m3_MP17">Monthly rate(7) 1</param>
		/// <param name="m3_MP27">Monthly rate(7) 2</param>
		/// <param name="m3_MP37">Monthly rate(7) 3</param>
		/// <param name="m3_MP07">Monthly rate(7) 0</param>
		/// <param name="m3_DECH">Delivery charge</param>
		/// <param name="m3_DECO">Delivery cost</param>
		/// <param name="m3_CPER">Cost percentage</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPckgRate(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_STDT, 
			string m3_PKID, 
			string m3_CUNO = null, 
			decimal? m3_HPS1 = null, 
			decimal? m3_HPS2 = null, 
			decimal? m3_HPS3 = null, 
			decimal? m3_HPS0 = null, 
			decimal? m3_DPS1 = null, 
			decimal? m3_DPS2 = null, 
			decimal? m3_DPS3 = null, 
			decimal? m3_DPS0 = null, 
			decimal? m3_WP15 = null, 
			decimal? m3_WP25 = null, 
			decimal? m3_WP35 = null, 
			decimal? m3_WP05 = null, 
			decimal? m3_WP16 = null, 
			decimal? m3_WP26 = null, 
			decimal? m3_WP36 = null, 
			decimal? m3_WP06 = null, 
			decimal? m3_WP17 = null, 
			decimal? m3_WP27 = null, 
			decimal? m3_WP37 = null, 
			decimal? m3_WP07 = null, 
			decimal? m3_MP15 = null, 
			decimal? m3_MP25 = null, 
			decimal? m3_MP35 = null, 
			decimal? m3_MP05 = null, 
			decimal? m3_MP16 = null, 
			decimal? m3_MP26 = null, 
			decimal? m3_MP36 = null, 
			decimal? m3_MP06 = null, 
			decimal? m3_MP17 = null, 
			decimal? m3_MP27 = null, 
			decimal? m3_MP37 = null, 
			decimal? m3_MP07 = null, 
			decimal? m3_DECH = null, 
			decimal? m3_DECO = null, 
			int? m3_CPER = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPckgRate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_PKID))
				throw new ArgumentNullException("m3_PKID");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("PKID", m3_PKID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_HPS1.HasValue)
				request.WithQueryParameter("HPS1", m3_HPS1.Value.ToString());
			if (m3_HPS2.HasValue)
				request.WithQueryParameter("HPS2", m3_HPS2.Value.ToString());
			if (m3_HPS3.HasValue)
				request.WithQueryParameter("HPS3", m3_HPS3.Value.ToString());
			if (m3_HPS0.HasValue)
				request.WithQueryParameter("HPS0", m3_HPS0.Value.ToString());
			if (m3_DPS1.HasValue)
				request.WithQueryParameter("DPS1", m3_DPS1.Value.ToString());
			if (m3_DPS2.HasValue)
				request.WithQueryParameter("DPS2", m3_DPS2.Value.ToString());
			if (m3_DPS3.HasValue)
				request.WithQueryParameter("DPS3", m3_DPS3.Value.ToString());
			if (m3_DPS0.HasValue)
				request.WithQueryParameter("DPS0", m3_DPS0.Value.ToString());
			if (m3_WP15.HasValue)
				request.WithQueryParameter("WP15", m3_WP15.Value.ToString());
			if (m3_WP25.HasValue)
				request.WithQueryParameter("WP25", m3_WP25.Value.ToString());
			if (m3_WP35.HasValue)
				request.WithQueryParameter("WP35", m3_WP35.Value.ToString());
			if (m3_WP05.HasValue)
				request.WithQueryParameter("WP05", m3_WP05.Value.ToString());
			if (m3_WP16.HasValue)
				request.WithQueryParameter("WP16", m3_WP16.Value.ToString());
			if (m3_WP26.HasValue)
				request.WithQueryParameter("WP26", m3_WP26.Value.ToString());
			if (m3_WP36.HasValue)
				request.WithQueryParameter("WP36", m3_WP36.Value.ToString());
			if (m3_WP06.HasValue)
				request.WithQueryParameter("WP06", m3_WP06.Value.ToString());
			if (m3_WP17.HasValue)
				request.WithQueryParameter("WP17", m3_WP17.Value.ToString());
			if (m3_WP27.HasValue)
				request.WithQueryParameter("WP27", m3_WP27.Value.ToString());
			if (m3_WP37.HasValue)
				request.WithQueryParameter("WP37", m3_WP37.Value.ToString());
			if (m3_WP07.HasValue)
				request.WithQueryParameter("WP07", m3_WP07.Value.ToString());
			if (m3_MP15.HasValue)
				request.WithQueryParameter("MP15", m3_MP15.Value.ToString());
			if (m3_MP25.HasValue)
				request.WithQueryParameter("MP25", m3_MP25.Value.ToString());
			if (m3_MP35.HasValue)
				request.WithQueryParameter("MP35", m3_MP35.Value.ToString());
			if (m3_MP05.HasValue)
				request.WithQueryParameter("MP05", m3_MP05.Value.ToString());
			if (m3_MP16.HasValue)
				request.WithQueryParameter("MP16", m3_MP16.Value.ToString());
			if (m3_MP26.HasValue)
				request.WithQueryParameter("MP26", m3_MP26.Value.ToString());
			if (m3_MP36.HasValue)
				request.WithQueryParameter("MP36", m3_MP36.Value.ToString());
			if (m3_MP06.HasValue)
				request.WithQueryParameter("MP06", m3_MP06.Value.ToString());
			if (m3_MP17.HasValue)
				request.WithQueryParameter("MP17", m3_MP17.Value.ToString());
			if (m3_MP27.HasValue)
				request.WithQueryParameter("MP27", m3_MP27.Value.ToString());
			if (m3_MP37.HasValue)
				request.WithQueryParameter("MP37", m3_MP37.Value.ToString());
			if (m3_MP07.HasValue)
				request.WithQueryParameter("MP07", m3_MP07.Value.ToString());
			if (m3_DECH.HasValue)
				request.WithQueryParameter("DECH", m3_DECH.Value.ToString());
			if (m3_DECO.HasValue)
				request.WithQueryParameter("DECO", m3_DECO.Value.ToString());
			if (m3_CPER.HasValue)
				request.WithQueryParameter("CPER", m3_CPER.Value.ToString());

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
		/// Name DelPckgRate
		/// Description DelPckgRate
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_PRRF">Price list (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_PKID">Package ID (Required)</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelPckgRate(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_STDT, 
			string m3_PKID, 
			string m3_CUNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelPckgRate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_PKID))
				throw new ArgumentNullException("m3_PKID");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("PKID", m3_PKID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());

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
		/// Name GetPckgRate
		/// Description GetPckgRate
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_PRRF">Price list (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_PKID">Package ID (Required)</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPckgRateResponse></returns>
		/// <exception cref="M3Exception<GetPckgRateResponse>"></exception>
		public async Task<M3Response<GetPckgRateResponse>> GetPckgRate(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_STDT, 
			string m3_PKID, 
			string m3_CUNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPckgRate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_PKID))
				throw new ArgumentNullException("m3_PKID");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("PKID", m3_PKID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Execute the request
			var result = await Execute<GetPckgRateResponse>(
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
		/// Name LstPckgRate
		/// Description LstPckgRate
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_PRRF">Price list (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_PKID">Package ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPckgRateResponse></returns>
		/// <exception cref="M3Exception<LstPckgRateResponse>"></exception>
		public async Task<M3Response<LstPckgRateResponse>> LstPckgRate(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_STDT, 
			string m3_CUNO = null, 
			string m3_PKID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPckgRate",
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
			if (!string.IsNullOrWhiteSpace(m3_PKID))
				request.WithQueryParameter("PKID", m3_PKID.Trim());

			// Execute the request
			var result = await Execute<LstPckgRateResponse>(
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
		/// Name UpdPckgRate
		/// Description UpdPckgRate
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_PRRF">Price list (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_PKID">Package ID (Required)</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_HPS1">Hourly rate 1</param>
		/// <param name="m3_HPS2">Hourly rate 2</param>
		/// <param name="m3_HPS3">Hourly rate 3</param>
		/// <param name="m3_HPS0">Hourly rate 0</param>
		/// <param name="m3_DPS1">Daily rate 1</param>
		/// <param name="m3_DPS2">Daily rate 2</param>
		/// <param name="m3_DPS3">Daily rate 3</param>
		/// <param name="m3_DPS0">Daily rate 0</param>
		/// <param name="m3_WP15">Weekly rate(5) 1</param>
		/// <param name="m3_WP25">Weekly rate(5) 2</param>
		/// <param name="m3_WP35">Weekly rate(5) 3</param>
		/// <param name="m3_WP05">Weekly rate(5) 0</param>
		/// <param name="m3_WP16">Weekly rate(6) 1</param>
		/// <param name="m3_WP26">Weekly rate(6) 2</param>
		/// <param name="m3_WP36">Weekly rate(6) 3</param>
		/// <param name="m3_WP06">Weekly rate(6) 0</param>
		/// <param name="m3_WP17">Weekly rate(7) 1</param>
		/// <param name="m3_WP27">Weekly rate(7) 2</param>
		/// <param name="m3_WP37">Weekly rate(7) 3</param>
		/// <param name="m3_WP07">Weekly rate(7) 0</param>
		/// <param name="m3_MP15">Monthly rate(5) 1</param>
		/// <param name="m3_MP25">Monthly rate(5) 2</param>
		/// <param name="m3_MP35">Monthly rate(5) 3</param>
		/// <param name="m3_MP05">Monthly rate(5) 0</param>
		/// <param name="m3_MP16">Monthly rate(6) 1</param>
		/// <param name="m3_MP26">Monthly rate(6) 2</param>
		/// <param name="m3_MP36">Monthly rate(6) 3</param>
		/// <param name="m3_MP06">Monthly rate(6) 0</param>
		/// <param name="m3_MP17">Monthly rate(7) 1</param>
		/// <param name="m3_MP27">Monthly rate(7) 2</param>
		/// <param name="m3_MP37">Monthly rate(7) 3</param>
		/// <param name="m3_MP07">Monthly rate(7) 0</param>
		/// <param name="m3_DECH">Delivery charge</param>
		/// <param name="m3_DECO">Delivery cost</param>
		/// <param name="m3_CPER">Cost percentage</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPckgRate(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_STDT, 
			string m3_PKID, 
			string m3_CUNO = null, 
			decimal? m3_HPS1 = null, 
			decimal? m3_HPS2 = null, 
			decimal? m3_HPS3 = null, 
			decimal? m3_HPS0 = null, 
			decimal? m3_DPS1 = null, 
			decimal? m3_DPS2 = null, 
			decimal? m3_DPS3 = null, 
			decimal? m3_DPS0 = null, 
			decimal? m3_WP15 = null, 
			decimal? m3_WP25 = null, 
			decimal? m3_WP35 = null, 
			decimal? m3_WP05 = null, 
			decimal? m3_WP16 = null, 
			decimal? m3_WP26 = null, 
			decimal? m3_WP36 = null, 
			decimal? m3_WP06 = null, 
			decimal? m3_WP17 = null, 
			decimal? m3_WP27 = null, 
			decimal? m3_WP37 = null, 
			decimal? m3_WP07 = null, 
			decimal? m3_MP15 = null, 
			decimal? m3_MP25 = null, 
			decimal? m3_MP35 = null, 
			decimal? m3_MP05 = null, 
			decimal? m3_MP16 = null, 
			decimal? m3_MP26 = null, 
			decimal? m3_MP36 = null, 
			decimal? m3_MP06 = null, 
			decimal? m3_MP17 = null, 
			decimal? m3_MP27 = null, 
			decimal? m3_MP37 = null, 
			decimal? m3_MP07 = null, 
			decimal? m3_DECH = null, 
			decimal? m3_DECO = null, 
			int? m3_CPER = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdPckgRate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_PKID))
				throw new ArgumentNullException("m3_PKID");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("PKID", m3_PKID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_HPS1.HasValue)
				request.WithQueryParameter("HPS1", m3_HPS1.Value.ToString());
			if (m3_HPS2.HasValue)
				request.WithQueryParameter("HPS2", m3_HPS2.Value.ToString());
			if (m3_HPS3.HasValue)
				request.WithQueryParameter("HPS3", m3_HPS3.Value.ToString());
			if (m3_HPS0.HasValue)
				request.WithQueryParameter("HPS0", m3_HPS0.Value.ToString());
			if (m3_DPS1.HasValue)
				request.WithQueryParameter("DPS1", m3_DPS1.Value.ToString());
			if (m3_DPS2.HasValue)
				request.WithQueryParameter("DPS2", m3_DPS2.Value.ToString());
			if (m3_DPS3.HasValue)
				request.WithQueryParameter("DPS3", m3_DPS3.Value.ToString());
			if (m3_DPS0.HasValue)
				request.WithQueryParameter("DPS0", m3_DPS0.Value.ToString());
			if (m3_WP15.HasValue)
				request.WithQueryParameter("WP15", m3_WP15.Value.ToString());
			if (m3_WP25.HasValue)
				request.WithQueryParameter("WP25", m3_WP25.Value.ToString());
			if (m3_WP35.HasValue)
				request.WithQueryParameter("WP35", m3_WP35.Value.ToString());
			if (m3_WP05.HasValue)
				request.WithQueryParameter("WP05", m3_WP05.Value.ToString());
			if (m3_WP16.HasValue)
				request.WithQueryParameter("WP16", m3_WP16.Value.ToString());
			if (m3_WP26.HasValue)
				request.WithQueryParameter("WP26", m3_WP26.Value.ToString());
			if (m3_WP36.HasValue)
				request.WithQueryParameter("WP36", m3_WP36.Value.ToString());
			if (m3_WP06.HasValue)
				request.WithQueryParameter("WP06", m3_WP06.Value.ToString());
			if (m3_WP17.HasValue)
				request.WithQueryParameter("WP17", m3_WP17.Value.ToString());
			if (m3_WP27.HasValue)
				request.WithQueryParameter("WP27", m3_WP27.Value.ToString());
			if (m3_WP37.HasValue)
				request.WithQueryParameter("WP37", m3_WP37.Value.ToString());
			if (m3_WP07.HasValue)
				request.WithQueryParameter("WP07", m3_WP07.Value.ToString());
			if (m3_MP15.HasValue)
				request.WithQueryParameter("MP15", m3_MP15.Value.ToString());
			if (m3_MP25.HasValue)
				request.WithQueryParameter("MP25", m3_MP25.Value.ToString());
			if (m3_MP35.HasValue)
				request.WithQueryParameter("MP35", m3_MP35.Value.ToString());
			if (m3_MP05.HasValue)
				request.WithQueryParameter("MP05", m3_MP05.Value.ToString());
			if (m3_MP16.HasValue)
				request.WithQueryParameter("MP16", m3_MP16.Value.ToString());
			if (m3_MP26.HasValue)
				request.WithQueryParameter("MP26", m3_MP26.Value.ToString());
			if (m3_MP36.HasValue)
				request.WithQueryParameter("MP36", m3_MP36.Value.ToString());
			if (m3_MP06.HasValue)
				request.WithQueryParameter("MP06", m3_MP06.Value.ToString());
			if (m3_MP17.HasValue)
				request.WithQueryParameter("MP17", m3_MP17.Value.ToString());
			if (m3_MP27.HasValue)
				request.WithQueryParameter("MP27", m3_MP27.Value.ToString());
			if (m3_MP37.HasValue)
				request.WithQueryParameter("MP37", m3_MP37.Value.ToString());
			if (m3_MP07.HasValue)
				request.WithQueryParameter("MP07", m3_MP07.Value.ToString());
			if (m3_DECH.HasValue)
				request.WithQueryParameter("DECH", m3_DECH.Value.ToString());
			if (m3_DECO.HasValue)
				request.WithQueryParameter("DECO", m3_DECO.Value.ToString());
			if (m3_CPER.HasValue)
				request.WithQueryParameter("CPER", m3_CPER.Value.ToString());

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
