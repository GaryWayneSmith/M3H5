/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.STS123MI;
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
	/// Name: STS123MI
	/// Component Name: STR Rates: Stepped Price
	/// Description: API: STR Rates:Stepped Price
	/// Version Release: 5ea2
	///</summary>
	public partial class STS123MIResource : M3BaseResourceEndpoint
	{
		public STS123MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "STS123MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddSteppedPrice
		/// Description AddSteppedPrice
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_PRRF">Price list (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_CCAP">Rental rate type (Required)</param>
		/// <param name="m3_ADPW">Days per week (Required)</param>
		/// <param name="m3_LIMT">Limit value (Required)</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_HPS1">Rate 1</param>
		/// <param name="m3_HPS2">Rate 2</param>
		/// <param name="m3_HPS3">Rate 3</param>
		/// <param name="m3_HPS0">Rate 0</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSteppedPrice(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_STDT, 
			string m3_CCAP, 
			int m3_ADPW, 
			decimal m3_LIMT, 
			string m3_CUNO = null, 
			string m3_ITNO = null, 
			string m3_ITGR = null, 
			decimal? m3_HPS1 = null, 
			decimal? m3_HPS2 = null, 
			decimal? m3_HPS3 = null, 
			decimal? m3_HPS0 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSteppedPrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_CCAP))
				throw new ArgumentNullException("m3_CCAP");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("CCAP", m3_CCAP.Trim())
				.WithQueryParameter("ADPW", m3_ADPW.ToString())
				.WithQueryParameter("LIMT", m3_LIMT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (m3_HPS1.HasValue)
				request.WithQueryParameter("HPS1", m3_HPS1.Value.ToString());
			if (m3_HPS2.HasValue)
				request.WithQueryParameter("HPS2", m3_HPS2.Value.ToString());
			if (m3_HPS3.HasValue)
				request.WithQueryParameter("HPS3", m3_HPS3.Value.ToString());
			if (m3_HPS0.HasValue)
				request.WithQueryParameter("HPS0", m3_HPS0.Value.ToString());

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
		/// Name DelSteppedPrice
		/// Description DelSteppedPrice
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRRF">Price list (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_CCAP">Rental rate type (Required)</param>
		/// <param name="m3_ADPW">Days per week (Required)</param>
		/// <param name="m3_LIMT">New field description (Required)</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelSteppedPrice(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_STDT, 
			string m3_CCAP, 
			int m3_ADPW, 
			decimal m3_LIMT, 
			string m3_CUNO = null, 
			string m3_ITNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelSteppedPrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_CCAP))
				throw new ArgumentNullException("m3_CCAP");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("CCAP", m3_CCAP.Trim())
				.WithQueryParameter("ADPW", m3_ADPW.ToString())
				.WithQueryParameter("LIMT", m3_LIMT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
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
		/// Name GetSteppedPrice
		/// Description GetSteppedPrice
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_PRRF">Price list (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_CCAP">Rental rate type (Required)</param>
		/// <param name="m3_ADPW">Days per week (Required)</param>
		/// <param name="m3_LIMT">New field description (Required)</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BRAN">Brand</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSteppedPriceResponse></returns>
		/// <exception cref="M3Exception<GetSteppedPriceResponse>"></exception>
		public async Task<M3Response<GetSteppedPriceResponse>> GetSteppedPrice(
			string m3_PRRF, 
			string m3_CUCD, 
			string m3_CCAP, 
			int m3_ADPW, 
			decimal m3_LIMT, 
			string m3_CUNO = null, 
			DateTime? m3_STDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSteppedPrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_CCAP))
				throw new ArgumentNullException("m3_CCAP");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("CCAP", m3_CCAP.Trim())
				.WithQueryParameter("ADPW", m3_ADPW.ToString())
				.WithQueryParameter("LIMT", m3_LIMT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRAN))
				request.WithQueryParameter("BRAN", m3_BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());

			// Execute the request
			var result = await Execute<GetSteppedPriceResponse>(
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
		/// Name LstSteppedPrice
		/// Description LstSteppedPrice
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_PRRF">Price list</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_CCAP">Rental rate type</param>
		/// <param name="m3_ADPW">Days per week</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSteppedPriceResponse></returns>
		/// <exception cref="M3Exception<LstSteppedPriceResponse>"></exception>
		public async Task<M3Response<LstSteppedPriceResponse>> LstSteppedPrice(
			string m3_PRRF = null, 
			string m3_CUCD = null, 
			string m3_CUNO = null, 
			DateTime? m3_STDT = null, 
			string m3_ITNO = null, 
			string m3_ITGR = null, 
			string m3_CCAP = null, 
			int? m3_ADPW = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSteppedPrice",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRRF))
				request.WithQueryParameter("PRRF", m3_PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CCAP))
				request.WithQueryParameter("CCAP", m3_CCAP.Trim());
			if (m3_ADPW.HasValue)
				request.WithQueryParameter("ADPW", m3_ADPW.Value.ToString());

			// Execute the request
			var result = await Execute<LstSteppedPriceResponse>(
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
		/// Name UpdSteppedPrice
		/// Description UpdSteppedPrice
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_PRRF">Price list (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_CCAP">Rental rate type (Required)</param>
		/// <param name="m3_ADPW">Days per week (Required)</param>
		/// <param name="m3_LIMT">Limit value (Required)</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_NLMT">New limit value</param>
		/// <param name="m3_HPS1">Rate 1</param>
		/// <param name="m3_HPS2">Rate 2</param>
		/// <param name="m3_HPS3">Rate 3</param>
		/// <param name="m3_HPS0">Rate 0</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSteppedPrice(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_STDT, 
			string m3_CCAP, 
			int m3_ADPW, 
			decimal m3_LIMT, 
			string m3_CUNO = null, 
			string m3_ITNO = null, 
			string m3_ITGR = null, 
			decimal? m3_NLMT = null, 
			decimal? m3_HPS1 = null, 
			decimal? m3_HPS2 = null, 
			decimal? m3_HPS3 = null, 
			decimal? m3_HPS0 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdSteppedPrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_CCAP))
				throw new ArgumentNullException("m3_CCAP");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("CCAP", m3_CCAP.Trim())
				.WithQueryParameter("ADPW", m3_ADPW.ToString())
				.WithQueryParameter("LIMT", m3_LIMT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (m3_NLMT.HasValue)
				request.WithQueryParameter("NLMT", m3_NLMT.Value.ToString());
			if (m3_HPS1.HasValue)
				request.WithQueryParameter("HPS1", m3_HPS1.Value.ToString());
			if (m3_HPS2.HasValue)
				request.WithQueryParameter("HPS2", m3_HPS2.Value.ToString());
			if (m3_HPS3.HasValue)
				request.WithQueryParameter("HPS3", m3_HPS3.Value.ToString());
			if (m3_HPS0.HasValue)
				request.WithQueryParameter("HPS0", m3_HPS0.Value.ToString());

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
