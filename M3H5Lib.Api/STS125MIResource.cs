/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3PRRF">Price list (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3PKID">Package ID (Required)</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3HPS1">Hourly rate 1</param>
		/// <param name="m3HPS2">Hourly rate 2</param>
		/// <param name="m3HPS3">Hourly rate 3</param>
		/// <param name="m3HPS0">Hourly rate 0</param>
		/// <param name="m3DPS1">Daily rate 1</param>
		/// <param name="m3DPS2">Daily rate 2</param>
		/// <param name="m3DPS3">Daily rate 3</param>
		/// <param name="m3DPS0">Daily rate 0</param>
		/// <param name="m3WP15">Week rate(5) 1</param>
		/// <param name="m3WP25">Week rate(5) 2</param>
		/// <param name="m3WP35">Week rate(5) 3</param>
		/// <param name="m3WP05">Week rate(5) 0</param>
		/// <param name="m3WP16">Week rate(6) 1</param>
		/// <param name="m3WP26">Week rate(6) 2</param>
		/// <param name="m3WP36">Week rate(6) 3</param>
		/// <param name="m3WP06">Week rate(6) 0</param>
		/// <param name="m3WP17">Week rate(7) 1</param>
		/// <param name="m3WP27">Week rate(7) 2</param>
		/// <param name="m3WP37">Week rate(7) 3</param>
		/// <param name="m3WP07">Week rate(7) 0</param>
		/// <param name="m3MP15">Monthly rate(5) 1</param>
		/// <param name="m3MP25">Monthly rate(5) 2</param>
		/// <param name="m3MP35">Monthly rate(5) 3</param>
		/// <param name="m3MP05">Monthly rate(5) 0</param>
		/// <param name="m3MP16">Monthly rate(6) 1</param>
		/// <param name="m3MP26">Monthly rate(6) 2</param>
		/// <param name="m3MP36">Monthly rate(6) 3</param>
		/// <param name="m3MP06">Monthly rate(6) 0</param>
		/// <param name="m3MP17">Monthly rate(7) 1</param>
		/// <param name="m3MP27">Monthly rate(7) 2</param>
		/// <param name="m3MP37">Monthly rate(7) 3</param>
		/// <param name="m3MP07">Monthly rate(7) 0</param>
		/// <param name="m3DECH">Delivery charge</param>
		/// <param name="m3DECO">Delivery cost</param>
		/// <param name="m3CPER">Cost percentage</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPckgRate(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3STDT, 
			string m3PKID, 
			string m3CUNO = null, 
			decimal? m3HPS1 = null, 
			decimal? m3HPS2 = null, 
			decimal? m3HPS3 = null, 
			decimal? m3HPS0 = null, 
			decimal? m3DPS1 = null, 
			decimal? m3DPS2 = null, 
			decimal? m3DPS3 = null, 
			decimal? m3DPS0 = null, 
			decimal? m3WP15 = null, 
			decimal? m3WP25 = null, 
			decimal? m3WP35 = null, 
			decimal? m3WP05 = null, 
			decimal? m3WP16 = null, 
			decimal? m3WP26 = null, 
			decimal? m3WP36 = null, 
			decimal? m3WP06 = null, 
			decimal? m3WP17 = null, 
			decimal? m3WP27 = null, 
			decimal? m3WP37 = null, 
			decimal? m3WP07 = null, 
			decimal? m3MP15 = null, 
			decimal? m3MP25 = null, 
			decimal? m3MP35 = null, 
			decimal? m3MP05 = null, 
			decimal? m3MP16 = null, 
			decimal? m3MP26 = null, 
			decimal? m3MP36 = null, 
			decimal? m3MP06 = null, 
			decimal? m3MP17 = null, 
			decimal? m3MP27 = null, 
			decimal? m3MP37 = null, 
			decimal? m3MP07 = null, 
			decimal? m3DECH = null, 
			decimal? m3DECO = null, 
			int? m3CPER = null, 
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
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3PKID))
				throw new ArgumentNullException(nameof(m3PKID));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String())
				.WithQueryParameter("PKID", m3PKID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3HPS1.HasValue)
				request.WithQueryParameter("HPS1", m3HPS1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HPS2.HasValue)
				request.WithQueryParameter("HPS2", m3HPS2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HPS3.HasValue)
				request.WithQueryParameter("HPS3", m3HPS3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HPS0.HasValue)
				request.WithQueryParameter("HPS0", m3HPS0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DPS1.HasValue)
				request.WithQueryParameter("DPS1", m3DPS1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DPS2.HasValue)
				request.WithQueryParameter("DPS2", m3DPS2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DPS3.HasValue)
				request.WithQueryParameter("DPS3", m3DPS3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DPS0.HasValue)
				request.WithQueryParameter("DPS0", m3DPS0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WP15.HasValue)
				request.WithQueryParameter("WP15", m3WP15.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WP25.HasValue)
				request.WithQueryParameter("WP25", m3WP25.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WP35.HasValue)
				request.WithQueryParameter("WP35", m3WP35.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WP05.HasValue)
				request.WithQueryParameter("WP05", m3WP05.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WP16.HasValue)
				request.WithQueryParameter("WP16", m3WP16.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WP26.HasValue)
				request.WithQueryParameter("WP26", m3WP26.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WP36.HasValue)
				request.WithQueryParameter("WP36", m3WP36.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WP06.HasValue)
				request.WithQueryParameter("WP06", m3WP06.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WP17.HasValue)
				request.WithQueryParameter("WP17", m3WP17.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WP27.HasValue)
				request.WithQueryParameter("WP27", m3WP27.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WP37.HasValue)
				request.WithQueryParameter("WP37", m3WP37.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WP07.HasValue)
				request.WithQueryParameter("WP07", m3WP07.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MP15.HasValue)
				request.WithQueryParameter("MP15", m3MP15.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MP25.HasValue)
				request.WithQueryParameter("MP25", m3MP25.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MP35.HasValue)
				request.WithQueryParameter("MP35", m3MP35.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MP05.HasValue)
				request.WithQueryParameter("MP05", m3MP05.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MP16.HasValue)
				request.WithQueryParameter("MP16", m3MP16.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MP26.HasValue)
				request.WithQueryParameter("MP26", m3MP26.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MP36.HasValue)
				request.WithQueryParameter("MP36", m3MP36.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MP06.HasValue)
				request.WithQueryParameter("MP06", m3MP06.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MP17.HasValue)
				request.WithQueryParameter("MP17", m3MP17.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MP27.HasValue)
				request.WithQueryParameter("MP27", m3MP27.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MP37.HasValue)
				request.WithQueryParameter("MP37", m3MP37.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MP07.HasValue)
				request.WithQueryParameter("MP07", m3MP07.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DECH.HasValue)
				request.WithQueryParameter("DECH", m3DECH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DECO.HasValue)
				request.WithQueryParameter("DECO", m3DECO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CPER.HasValue)
				request.WithQueryParameter("CPER", m3CPER.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelPckgRate
		/// Description DelPckgRate
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3PRRF">Price list (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3PKID">Package ID (Required)</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelPckgRate(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3STDT, 
			string m3PKID, 
			string m3CUNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3PKID))
				throw new ArgumentNullException(nameof(m3PKID));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String())
				.WithQueryParameter("PKID", m3PKID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());

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
		/// Name GetPckgRate
		/// Description GetPckgRate
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3PRRF">Price list (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3PKID">Package ID (Required)</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPckgRateResponse></returns>
		/// <exception cref="M3Exception<GetPckgRateResponse>"></exception>
		public async Task<M3Response<GetPckgRateResponse>> GetPckgRate(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3STDT, 
			string m3PKID, 
			string m3CUNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3PKID))
				throw new ArgumentNullException(nameof(m3PKID));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String())
				.WithQueryParameter("PKID", m3PKID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Execute the request
			var result = await Execute<GetPckgRateResponse>(
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
		/// Name LstPckgRate
		/// Description LstPckgRate
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3PRRF">Price list (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3PKID">Package ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPckgRateResponse></returns>
		/// <exception cref="M3Exception<LstPckgRateResponse>"></exception>
		public async Task<M3Response<LstPckgRateResponse>> LstPckgRate(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3STDT, 
			string m3CUNO = null, 
			string m3PKID = null, 
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
			if (!string.IsNullOrWhiteSpace(m3PKID))
				request.WithQueryParameter("PKID", m3PKID.Trim());

			// Execute the request
			var result = await Execute<LstPckgRateResponse>(
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
		/// Name UpdPckgRate
		/// Description UpdPckgRate
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3PRRF">Price list (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3PKID">Package ID (Required)</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3HPS1">Hourly rate 1</param>
		/// <param name="m3HPS2">Hourly rate 2</param>
		/// <param name="m3HPS3">Hourly rate 3</param>
		/// <param name="m3HPS0">Hourly rate 0</param>
		/// <param name="m3DPS1">Daily rate 1</param>
		/// <param name="m3DPS2">Daily rate 2</param>
		/// <param name="m3DPS3">Daily rate 3</param>
		/// <param name="m3DPS0">Daily rate 0</param>
		/// <param name="m3WP15">Weekly rate(5) 1</param>
		/// <param name="m3WP25">Weekly rate(5) 2</param>
		/// <param name="m3WP35">Weekly rate(5) 3</param>
		/// <param name="m3WP05">Weekly rate(5) 0</param>
		/// <param name="m3WP16">Weekly rate(6) 1</param>
		/// <param name="m3WP26">Weekly rate(6) 2</param>
		/// <param name="m3WP36">Weekly rate(6) 3</param>
		/// <param name="m3WP06">Weekly rate(6) 0</param>
		/// <param name="m3WP17">Weekly rate(7) 1</param>
		/// <param name="m3WP27">Weekly rate(7) 2</param>
		/// <param name="m3WP37">Weekly rate(7) 3</param>
		/// <param name="m3WP07">Weekly rate(7) 0</param>
		/// <param name="m3MP15">Monthly rate(5) 1</param>
		/// <param name="m3MP25">Monthly rate(5) 2</param>
		/// <param name="m3MP35">Monthly rate(5) 3</param>
		/// <param name="m3MP05">Monthly rate(5) 0</param>
		/// <param name="m3MP16">Monthly rate(6) 1</param>
		/// <param name="m3MP26">Monthly rate(6) 2</param>
		/// <param name="m3MP36">Monthly rate(6) 3</param>
		/// <param name="m3MP06">Monthly rate(6) 0</param>
		/// <param name="m3MP17">Monthly rate(7) 1</param>
		/// <param name="m3MP27">Monthly rate(7) 2</param>
		/// <param name="m3MP37">Monthly rate(7) 3</param>
		/// <param name="m3MP07">Monthly rate(7) 0</param>
		/// <param name="m3DECH">Delivery charge</param>
		/// <param name="m3DECO">Delivery cost</param>
		/// <param name="m3CPER">Cost percentage</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPckgRate(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3STDT, 
			string m3PKID, 
			string m3CUNO = null, 
			decimal? m3HPS1 = null, 
			decimal? m3HPS2 = null, 
			decimal? m3HPS3 = null, 
			decimal? m3HPS0 = null, 
			decimal? m3DPS1 = null, 
			decimal? m3DPS2 = null, 
			decimal? m3DPS3 = null, 
			decimal? m3DPS0 = null, 
			decimal? m3WP15 = null, 
			decimal? m3WP25 = null, 
			decimal? m3WP35 = null, 
			decimal? m3WP05 = null, 
			decimal? m3WP16 = null, 
			decimal? m3WP26 = null, 
			decimal? m3WP36 = null, 
			decimal? m3WP06 = null, 
			decimal? m3WP17 = null, 
			decimal? m3WP27 = null, 
			decimal? m3WP37 = null, 
			decimal? m3WP07 = null, 
			decimal? m3MP15 = null, 
			decimal? m3MP25 = null, 
			decimal? m3MP35 = null, 
			decimal? m3MP05 = null, 
			decimal? m3MP16 = null, 
			decimal? m3MP26 = null, 
			decimal? m3MP36 = null, 
			decimal? m3MP06 = null, 
			decimal? m3MP17 = null, 
			decimal? m3MP27 = null, 
			decimal? m3MP37 = null, 
			decimal? m3MP07 = null, 
			decimal? m3DECH = null, 
			decimal? m3DECO = null, 
			int? m3CPER = null, 
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
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3PKID))
				throw new ArgumentNullException(nameof(m3PKID));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String())
				.WithQueryParameter("PKID", m3PKID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3HPS1.HasValue)
				request.WithQueryParameter("HPS1", m3HPS1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HPS2.HasValue)
				request.WithQueryParameter("HPS2", m3HPS2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HPS3.HasValue)
				request.WithQueryParameter("HPS3", m3HPS3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HPS0.HasValue)
				request.WithQueryParameter("HPS0", m3HPS0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DPS1.HasValue)
				request.WithQueryParameter("DPS1", m3DPS1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DPS2.HasValue)
				request.WithQueryParameter("DPS2", m3DPS2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DPS3.HasValue)
				request.WithQueryParameter("DPS3", m3DPS3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DPS0.HasValue)
				request.WithQueryParameter("DPS0", m3DPS0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WP15.HasValue)
				request.WithQueryParameter("WP15", m3WP15.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WP25.HasValue)
				request.WithQueryParameter("WP25", m3WP25.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WP35.HasValue)
				request.WithQueryParameter("WP35", m3WP35.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WP05.HasValue)
				request.WithQueryParameter("WP05", m3WP05.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WP16.HasValue)
				request.WithQueryParameter("WP16", m3WP16.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WP26.HasValue)
				request.WithQueryParameter("WP26", m3WP26.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WP36.HasValue)
				request.WithQueryParameter("WP36", m3WP36.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WP06.HasValue)
				request.WithQueryParameter("WP06", m3WP06.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WP17.HasValue)
				request.WithQueryParameter("WP17", m3WP17.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WP27.HasValue)
				request.WithQueryParameter("WP27", m3WP27.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WP37.HasValue)
				request.WithQueryParameter("WP37", m3WP37.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WP07.HasValue)
				request.WithQueryParameter("WP07", m3WP07.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MP15.HasValue)
				request.WithQueryParameter("MP15", m3MP15.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MP25.HasValue)
				request.WithQueryParameter("MP25", m3MP25.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MP35.HasValue)
				request.WithQueryParameter("MP35", m3MP35.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MP05.HasValue)
				request.WithQueryParameter("MP05", m3MP05.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MP16.HasValue)
				request.WithQueryParameter("MP16", m3MP16.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MP26.HasValue)
				request.WithQueryParameter("MP26", m3MP26.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MP36.HasValue)
				request.WithQueryParameter("MP36", m3MP36.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MP06.HasValue)
				request.WithQueryParameter("MP06", m3MP06.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MP17.HasValue)
				request.WithQueryParameter("MP17", m3MP17.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MP27.HasValue)
				request.WithQueryParameter("MP27", m3MP27.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MP37.HasValue)
				request.WithQueryParameter("MP37", m3MP37.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MP07.HasValue)
				request.WithQueryParameter("MP07", m3MP07.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DECH.HasValue)
				request.WithQueryParameter("DECH", m3DECH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DECO.HasValue)
				request.WithQueryParameter("DECO", m3DECO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CPER.HasValue)
				request.WithQueryParameter("CPER", m3CPER.Value.ToString(CultureInfo.CurrentCulture));

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
