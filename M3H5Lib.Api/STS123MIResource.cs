/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3PRRF">Price list (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3CCAP">Rental rate type (Required)</param>
		/// <param name="m3ADPW">Days per week (Required)</param>
		/// <param name="m3LIMT">Limit value (Required)</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3HPS1">Rate 1</param>
		/// <param name="m3HPS2">Rate 2</param>
		/// <param name="m3HPS3">Rate 3</param>
		/// <param name="m3HPS0">Rate 0</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSteppedPrice(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3STDT, 
			string m3CCAP, 
			int m3ADPW, 
			decimal m3LIMT, 
			string m3CUNO = null, 
			string m3ITNO = null, 
			string m3ITGR = null, 
			decimal? m3HPS1 = null, 
			decimal? m3HPS2 = null, 
			decimal? m3HPS3 = null, 
			decimal? m3HPS0 = null, 
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
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3CCAP))
				throw new ArgumentNullException(nameof(m3CCAP));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String())
				.WithQueryParameter("CCAP", m3CCAP.Trim())
				.WithQueryParameter("ADPW", m3ADPW.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("LIMT", m3LIMT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (m3HPS1.HasValue)
				request.WithQueryParameter("HPS1", m3HPS1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HPS2.HasValue)
				request.WithQueryParameter("HPS2", m3HPS2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HPS3.HasValue)
				request.WithQueryParameter("HPS3", m3HPS3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HPS0.HasValue)
				request.WithQueryParameter("HPS0", m3HPS0.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelSteppedPrice
		/// Description DelSteppedPrice
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRRF">Price list (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3CCAP">Rental rate type (Required)</param>
		/// <param name="m3ADPW">Days per week (Required)</param>
		/// <param name="m3LIMT">New field description (Required)</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelSteppedPrice(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3STDT, 
			string m3CCAP, 
			int m3ADPW, 
			decimal m3LIMT, 
			string m3CUNO = null, 
			string m3ITNO = null, 
			string m3ITGR = null, 
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
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3CCAP))
				throw new ArgumentNullException(nameof(m3CCAP));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String())
				.WithQueryParameter("CCAP", m3CCAP.Trim())
				.WithQueryParameter("ADPW", m3ADPW.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("LIMT", m3LIMT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
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
		/// Name GetSteppedPrice
		/// Description GetSteppedPrice
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3PRRF">Price list (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3CCAP">Rental rate type (Required)</param>
		/// <param name="m3ADPW">Days per week (Required)</param>
		/// <param name="m3LIMT">New field description (Required)</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BRAN">Brand</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSteppedPriceResponse></returns>
		/// <exception cref="M3Exception<GetSteppedPriceResponse>"></exception>
		public async Task<M3Response<GetSteppedPriceResponse>> GetSteppedPrice(
			string m3PRRF, 
			string m3CUCD, 
			string m3CCAP, 
			int m3ADPW, 
			decimal m3LIMT, 
			string m3CUNO = null, 
			DateTime? m3STDT = null, 
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
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSteppedPrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3CCAP))
				throw new ArgumentNullException(nameof(m3CCAP));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("CCAP", m3CCAP.Trim())
				.WithQueryParameter("ADPW", m3ADPW.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("LIMT", m3LIMT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRAN))
				request.WithQueryParameter("BRAN", m3BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());

			// Execute the request
			var result = await Execute<GetSteppedPriceResponse>(
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
		/// Name LstSteppedPrice
		/// Description LstSteppedPrice
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3PRRF">Price list</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3CCAP">Rental rate type</param>
		/// <param name="m3ADPW">Days per week</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSteppedPriceResponse></returns>
		/// <exception cref="M3Exception<LstSteppedPriceResponse>"></exception>
		public async Task<M3Response<LstSteppedPriceResponse>> LstSteppedPrice(
			string m3PRRF = null, 
			string m3CUCD = null, 
			string m3CUNO = null, 
			DateTime? m3STDT = null, 
			string m3ITNO = null, 
			string m3ITGR = null, 
			string m3CCAP = null, 
			int? m3ADPW = null, 
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
			if (!string.IsNullOrWhiteSpace(m3PRRF))
				request.WithQueryParameter("PRRF", m3PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CCAP))
				request.WithQueryParameter("CCAP", m3CCAP.Trim());
			if (m3ADPW.HasValue)
				request.WithQueryParameter("ADPW", m3ADPW.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstSteppedPriceResponse>(
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
		/// Name UpdSteppedPrice
		/// Description UpdSteppedPrice
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3PRRF">Price list (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3CCAP">Rental rate type (Required)</param>
		/// <param name="m3ADPW">Days per week (Required)</param>
		/// <param name="m3LIMT">Limit value (Required)</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3NLMT">New limit value</param>
		/// <param name="m3HPS1">Rate 1</param>
		/// <param name="m3HPS2">Rate 2</param>
		/// <param name="m3HPS3">Rate 3</param>
		/// <param name="m3HPS0">Rate 0</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSteppedPrice(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3STDT, 
			string m3CCAP, 
			int m3ADPW, 
			decimal m3LIMT, 
			string m3CUNO = null, 
			string m3ITNO = null, 
			string m3ITGR = null, 
			decimal? m3NLMT = null, 
			decimal? m3HPS1 = null, 
			decimal? m3HPS2 = null, 
			decimal? m3HPS3 = null, 
			decimal? m3HPS0 = null, 
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
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3CCAP))
				throw new ArgumentNullException(nameof(m3CCAP));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String())
				.WithQueryParameter("CCAP", m3CCAP.Trim())
				.WithQueryParameter("ADPW", m3ADPW.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("LIMT", m3LIMT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (m3NLMT.HasValue)
				request.WithQueryParameter("NLMT", m3NLMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HPS1.HasValue)
				request.WithQueryParameter("HPS1", m3HPS1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HPS2.HasValue)
				request.WithQueryParameter("HPS2", m3HPS2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HPS3.HasValue)
				request.WithQueryParameter("HPS3", m3HPS3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HPS0.HasValue)
				request.WithQueryParameter("HPS0", m3HPS0.Value.ToString(CultureInfo.CurrentCulture));

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
