/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.QUS119MI;
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
	/// Name: QUS119MI
	/// Component Name: Customer Variations
	/// Description: Api: Add Customer Variations
	/// Version Release: 14.x
	///</summary>
	public partial class QUS119MIResource : M3BaseResourceEndpoint
	{
		public QUS119MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QUS119MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddCustomerVar
		/// Description Add Customer Variations
		/// Version Release: 
		/// </summary>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3USTI">Hours used</param>
		/// <param name="m3SPHO">Hourly price</param>
		/// <param name="m3CPHO">Hourly cost</param>
		/// <param name="m3ADF2">Price in material currency</param>
		/// <param name="m3ADF3">Price in subcontracting currency</param>
		/// <param name="m3ADF4">Price in miscellaneous currency</param>
		/// <param name="m3CDF2">Cost in material currency</param>
		/// <param name="m3CDF3">Cost in subcontracting currency</param>
		/// <param name="m3CDF4">Cost in miscellaneous currency</param>
		/// <param name="m3SMC0">OEM code</param>
		/// <param name="m3SMC1">OEM code</param>
		/// <param name="m3SMC2">OEM code</param>
		/// <param name="m3SMC3">OEM code</param>
		/// <param name="m3SMC4">OEM code</param>
		/// <param name="m3SMC5">OEM code</param>
		/// <param name="m3SMC6">OEM code</param>
		/// <param name="m3SMC7">OEM code</param>
		/// <param name="m3SMC8">OEM code</param>
		/// <param name="m3SMC9">OEM code</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3CRSE">Create service</param>
		/// <param name="m3RSUF">Service</param>
		/// <param name="m3AAGN">Agreement</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCustomerVar(
			string m3PRNO = null, 
			string m3CUNO = null, 
			string m3TX40 = null, 
			int? m3USTI = null, 
			decimal? m3SPHO = null, 
			decimal? m3CPHO = null, 
			decimal? m3ADF2 = null, 
			decimal? m3ADF3 = null, 
			decimal? m3ADF4 = null, 
			decimal? m3CDF2 = null, 
			decimal? m3CDF3 = null, 
			decimal? m3CDF4 = null, 
			string m3SMC0 = null, 
			string m3SMC1 = null, 
			string m3SMC2 = null, 
			string m3SMC3 = null, 
			string m3SMC4 = null, 
			string m3SMC5 = null, 
			string m3SMC6 = null, 
			string m3SMC7 = null, 
			string m3SMC8 = null, 
			string m3SMC9 = null, 
			string m3SUFI = null, 
			string m3STRT = null, 
			int? m3CRSE = null, 
			string m3RSUF = null, 
			string m3AAGN = null, 
			string m3RESP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCustomerVar",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (m3USTI.HasValue)
				request.WithQueryParameter("USTI", m3USTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPHO.HasValue)
				request.WithQueryParameter("SPHO", m3SPHO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CPHO.HasValue)
				request.WithQueryParameter("CPHO", m3CPHO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADF2.HasValue)
				request.WithQueryParameter("ADF2", m3ADF2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADF3.HasValue)
				request.WithQueryParameter("ADF3", m3ADF3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADF4.HasValue)
				request.WithQueryParameter("ADF4", m3ADF4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CDF2.HasValue)
				request.WithQueryParameter("CDF2", m3CDF2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CDF3.HasValue)
				request.WithQueryParameter("CDF3", m3CDF3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CDF4.HasValue)
				request.WithQueryParameter("CDF4", m3CDF4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SMC0))
				request.WithQueryParameter("SMC0", m3SMC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC1))
				request.WithQueryParameter("SMC1", m3SMC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC2))
				request.WithQueryParameter("SMC2", m3SMC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC3))
				request.WithQueryParameter("SMC3", m3SMC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC4))
				request.WithQueryParameter("SMC4", m3SMC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC5))
				request.WithQueryParameter("SMC5", m3SMC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC6))
				request.WithQueryParameter("SMC6", m3SMC6.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC7))
				request.WithQueryParameter("SMC7", m3SMC7.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC8))
				request.WithQueryParameter("SMC8", m3SMC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC9))
				request.WithQueryParameter("SMC9", m3SMC9.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3CRSE.HasValue)
				request.WithQueryParameter("CRSE", m3CRSE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RSUF))
				request.WithQueryParameter("RSUF", m3RSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3AAGN))
				request.WithQueryParameter("AAGN", m3AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());

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
		/// Name ChgCustomerVar
		/// Description Change Customer Variations
		/// Version Release: 
		/// </summary>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3USTI">Hours used</param>
		/// <param name="m3SPHO">Hourly price</param>
		/// <param name="m3CPHO">Hourly cost</param>
		/// <param name="m3ADF2">Price in material currency</param>
		/// <param name="m3ADF3">Price in subcontracting currency</param>
		/// <param name="m3ADF4">Price in miscellaneous currency</param>
		/// <param name="m3CDF2">Cost in material currency</param>
		/// <param name="m3CDF3">Cost in subcontracting currency</param>
		/// <param name="m3CDF4">Cost in miscellaneous currency</param>
		/// <param name="m3SMC0">OEM code</param>
		/// <param name="m3SMC1">OEM code</param>
		/// <param name="m3SMC2">OEM code</param>
		/// <param name="m3SMC3">OEM code</param>
		/// <param name="m3SMC4">OEM code</param>
		/// <param name="m3SMC5">OEM code</param>
		/// <param name="m3SMC6">OEM code</param>
		/// <param name="m3SMC7">OEM code</param>
		/// <param name="m3SMC8">OEM code</param>
		/// <param name="m3SMC9">OEM code</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3CRSE">Create service</param>
		/// <param name="m3RSUF">Service</param>
		/// <param name="m3AAGN">Agreement</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgCustomerVar(
			string m3TX40, 
			string m3PRNO = null, 
			string m3CUNO = null, 
			int? m3USTI = null, 
			decimal? m3SPHO = null, 
			decimal? m3CPHO = null, 
			decimal? m3ADF2 = null, 
			decimal? m3ADF3 = null, 
			decimal? m3ADF4 = null, 
			decimal? m3CDF2 = null, 
			decimal? m3CDF3 = null, 
			decimal? m3CDF4 = null, 
			string m3SMC0 = null, 
			string m3SMC1 = null, 
			string m3SMC2 = null, 
			string m3SMC3 = null, 
			string m3SMC4 = null, 
			string m3SMC5 = null, 
			string m3SMC6 = null, 
			string m3SMC7 = null, 
			string m3SMC8 = null, 
			string m3SMC9 = null, 
			string m3SUFI = null, 
			string m3STRT = null, 
			int? m3CRSE = null, 
			string m3RSUF = null, 
			string m3AAGN = null, 
			string m3RESP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgCustomerVar",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("TX40", m3TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3USTI.HasValue)
				request.WithQueryParameter("USTI", m3USTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPHO.HasValue)
				request.WithQueryParameter("SPHO", m3SPHO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CPHO.HasValue)
				request.WithQueryParameter("CPHO", m3CPHO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADF2.HasValue)
				request.WithQueryParameter("ADF2", m3ADF2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADF3.HasValue)
				request.WithQueryParameter("ADF3", m3ADF3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADF4.HasValue)
				request.WithQueryParameter("ADF4", m3ADF4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CDF2.HasValue)
				request.WithQueryParameter("CDF2", m3CDF2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CDF3.HasValue)
				request.WithQueryParameter("CDF3", m3CDF3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CDF4.HasValue)
				request.WithQueryParameter("CDF4", m3CDF4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SMC0))
				request.WithQueryParameter("SMC0", m3SMC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC1))
				request.WithQueryParameter("SMC1", m3SMC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC2))
				request.WithQueryParameter("SMC2", m3SMC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC3))
				request.WithQueryParameter("SMC3", m3SMC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC4))
				request.WithQueryParameter("SMC4", m3SMC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC5))
				request.WithQueryParameter("SMC5", m3SMC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC6))
				request.WithQueryParameter("SMC6", m3SMC6.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC7))
				request.WithQueryParameter("SMC7", m3SMC7.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC8))
				request.WithQueryParameter("SMC8", m3SMC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC9))
				request.WithQueryParameter("SMC9", m3SMC9.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3CRSE.HasValue)
				request.WithQueryParameter("CRSE", m3CRSE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RSUF))
				request.WithQueryParameter("RSUF", m3RSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3AAGN))
				request.WithQueryParameter("AAGN", m3AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());

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
		/// Name DltCustomerVar
		/// Description Deletet Customer Variations
		/// Version Release: 
		/// </summary>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltCustomerVar(
			string m3TX40, 
			string m3PRNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltCustomerVar",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("TX40", m3TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
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
		/// Name GetCustomerVar
		/// Description Get Customer Variations
		/// Version Release: 
		/// </summary>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCustomerVarResponse></returns>
		/// <exception cref="M3Exception<GetCustomerVarResponse>"></exception>
		public async Task<M3Response<GetCustomerVarResponse>> GetCustomerVar(
			string m3TX40, 
			string m3PRNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetCustomerVar",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("TX40", m3TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Execute the request
			var result = await Execute<GetCustomerVarResponse>(
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
		/// Name LstCustomerVar
		/// Description List Customer Variations
		/// Version Release: 
		/// </summary>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCustomerVarResponse></returns>
		/// <exception cref="M3Exception<LstCustomerVarResponse>"></exception>
		public async Task<M3Response<LstCustomerVarResponse>> LstCustomerVar(
			string m3PRNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCustomerVar",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Execute the request
			var result = await Execute<LstCustomerVarResponse>(
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
