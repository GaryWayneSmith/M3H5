/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_USTI">Hours used</param>
		/// <param name="m3_SPHO">Hourly price</param>
		/// <param name="m3_CPHO">Hourly cost</param>
		/// <param name="m3_ADF2">Price in material currency</param>
		/// <param name="m3_ADF3">Price in subcontracting currency</param>
		/// <param name="m3_ADF4">Price in miscellaneous currency</param>
		/// <param name="m3_CDF2">Cost in material currency</param>
		/// <param name="m3_CDF3">Cost in subcontracting currency</param>
		/// <param name="m3_CDF4">Cost in miscellaneous currency</param>
		/// <param name="m3_SMC0">OEM code</param>
		/// <param name="m3_SMC1">OEM code</param>
		/// <param name="m3_SMC2">OEM code</param>
		/// <param name="m3_SMC3">OEM code</param>
		/// <param name="m3_SMC4">OEM code</param>
		/// <param name="m3_SMC5">OEM code</param>
		/// <param name="m3_SMC6">OEM code</param>
		/// <param name="m3_SMC7">OEM code</param>
		/// <param name="m3_SMC8">OEM code</param>
		/// <param name="m3_SMC9">OEM code</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_CRSE">Create service</param>
		/// <param name="m3_RSUF">Service</param>
		/// <param name="m3_AAGN">Agreement</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCustomerVar(
			string m3_PRNO = null, 
			string m3_CUNO = null, 
			string m3_TX40 = null, 
			int? m3_USTI = null, 
			decimal? m3_SPHO = null, 
			decimal? m3_CPHO = null, 
			decimal? m3_ADF2 = null, 
			decimal? m3_ADF3 = null, 
			decimal? m3_ADF4 = null, 
			decimal? m3_CDF2 = null, 
			decimal? m3_CDF3 = null, 
			decimal? m3_CDF4 = null, 
			string m3_SMC0 = null, 
			string m3_SMC1 = null, 
			string m3_SMC2 = null, 
			string m3_SMC3 = null, 
			string m3_SMC4 = null, 
			string m3_SMC5 = null, 
			string m3_SMC6 = null, 
			string m3_SMC7 = null, 
			string m3_SMC8 = null, 
			string m3_SMC9 = null, 
			string m3_SUFI = null, 
			string m3_STRT = null, 
			int? m3_CRSE = null, 
			string m3_RSUF = null, 
			string m3_AAGN = null, 
			string m3_RESP = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (m3_USTI.HasValue)
				request.WithQueryParameter("USTI", m3_USTI.Value.ToString());
			if (m3_SPHO.HasValue)
				request.WithQueryParameter("SPHO", m3_SPHO.Value.ToString());
			if (m3_CPHO.HasValue)
				request.WithQueryParameter("CPHO", m3_CPHO.Value.ToString());
			if (m3_ADF2.HasValue)
				request.WithQueryParameter("ADF2", m3_ADF2.Value.ToString());
			if (m3_ADF3.HasValue)
				request.WithQueryParameter("ADF3", m3_ADF3.Value.ToString());
			if (m3_ADF4.HasValue)
				request.WithQueryParameter("ADF4", m3_ADF4.Value.ToString());
			if (m3_CDF2.HasValue)
				request.WithQueryParameter("CDF2", m3_CDF2.Value.ToString());
			if (m3_CDF3.HasValue)
				request.WithQueryParameter("CDF3", m3_CDF3.Value.ToString());
			if (m3_CDF4.HasValue)
				request.WithQueryParameter("CDF4", m3_CDF4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SMC0))
				request.WithQueryParameter("SMC0", m3_SMC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC1))
				request.WithQueryParameter("SMC1", m3_SMC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC2))
				request.WithQueryParameter("SMC2", m3_SMC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC3))
				request.WithQueryParameter("SMC3", m3_SMC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC4))
				request.WithQueryParameter("SMC4", m3_SMC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC5))
				request.WithQueryParameter("SMC5", m3_SMC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC6))
				request.WithQueryParameter("SMC6", m3_SMC6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC7))
				request.WithQueryParameter("SMC7", m3_SMC7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC8))
				request.WithQueryParameter("SMC8", m3_SMC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC9))
				request.WithQueryParameter("SMC9", m3_SMC9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_CRSE.HasValue)
				request.WithQueryParameter("CRSE", m3_CRSE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RSUF))
				request.WithQueryParameter("RSUF", m3_RSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AAGN))
				request.WithQueryParameter("AAGN", m3_AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());

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
		/// Name ChgCustomerVar
		/// Description Change Customer Variations
		/// Version Release: 
		/// </summary>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_USTI">Hours used</param>
		/// <param name="m3_SPHO">Hourly price</param>
		/// <param name="m3_CPHO">Hourly cost</param>
		/// <param name="m3_ADF2">Price in material currency</param>
		/// <param name="m3_ADF3">Price in subcontracting currency</param>
		/// <param name="m3_ADF4">Price in miscellaneous currency</param>
		/// <param name="m3_CDF2">Cost in material currency</param>
		/// <param name="m3_CDF3">Cost in subcontracting currency</param>
		/// <param name="m3_CDF4">Cost in miscellaneous currency</param>
		/// <param name="m3_SMC0">OEM code</param>
		/// <param name="m3_SMC1">OEM code</param>
		/// <param name="m3_SMC2">OEM code</param>
		/// <param name="m3_SMC3">OEM code</param>
		/// <param name="m3_SMC4">OEM code</param>
		/// <param name="m3_SMC5">OEM code</param>
		/// <param name="m3_SMC6">OEM code</param>
		/// <param name="m3_SMC7">OEM code</param>
		/// <param name="m3_SMC8">OEM code</param>
		/// <param name="m3_SMC9">OEM code</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_CRSE">Create service</param>
		/// <param name="m3_RSUF">Service</param>
		/// <param name="m3_AAGN">Agreement</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgCustomerVar(
			string m3_TX40, 
			string m3_PRNO = null, 
			string m3_CUNO = null, 
			int? m3_USTI = null, 
			decimal? m3_SPHO = null, 
			decimal? m3_CPHO = null, 
			decimal? m3_ADF2 = null, 
			decimal? m3_ADF3 = null, 
			decimal? m3_ADF4 = null, 
			decimal? m3_CDF2 = null, 
			decimal? m3_CDF3 = null, 
			decimal? m3_CDF4 = null, 
			string m3_SMC0 = null, 
			string m3_SMC1 = null, 
			string m3_SMC2 = null, 
			string m3_SMC3 = null, 
			string m3_SMC4 = null, 
			string m3_SMC5 = null, 
			string m3_SMC6 = null, 
			string m3_SMC7 = null, 
			string m3_SMC8 = null, 
			string m3_SMC9 = null, 
			string m3_SUFI = null, 
			string m3_STRT = null, 
			int? m3_CRSE = null, 
			string m3_RSUF = null, 
			string m3_AAGN = null, 
			string m3_RESP = null, 
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
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("TX40", m3_TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_USTI.HasValue)
				request.WithQueryParameter("USTI", m3_USTI.Value.ToString());
			if (m3_SPHO.HasValue)
				request.WithQueryParameter("SPHO", m3_SPHO.Value.ToString());
			if (m3_CPHO.HasValue)
				request.WithQueryParameter("CPHO", m3_CPHO.Value.ToString());
			if (m3_ADF2.HasValue)
				request.WithQueryParameter("ADF2", m3_ADF2.Value.ToString());
			if (m3_ADF3.HasValue)
				request.WithQueryParameter("ADF3", m3_ADF3.Value.ToString());
			if (m3_ADF4.HasValue)
				request.WithQueryParameter("ADF4", m3_ADF4.Value.ToString());
			if (m3_CDF2.HasValue)
				request.WithQueryParameter("CDF2", m3_CDF2.Value.ToString());
			if (m3_CDF3.HasValue)
				request.WithQueryParameter("CDF3", m3_CDF3.Value.ToString());
			if (m3_CDF4.HasValue)
				request.WithQueryParameter("CDF4", m3_CDF4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SMC0))
				request.WithQueryParameter("SMC0", m3_SMC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC1))
				request.WithQueryParameter("SMC1", m3_SMC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC2))
				request.WithQueryParameter("SMC2", m3_SMC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC3))
				request.WithQueryParameter("SMC3", m3_SMC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC4))
				request.WithQueryParameter("SMC4", m3_SMC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC5))
				request.WithQueryParameter("SMC5", m3_SMC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC6))
				request.WithQueryParameter("SMC6", m3_SMC6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC7))
				request.WithQueryParameter("SMC7", m3_SMC7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC8))
				request.WithQueryParameter("SMC8", m3_SMC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC9))
				request.WithQueryParameter("SMC9", m3_SMC9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_CRSE.HasValue)
				request.WithQueryParameter("CRSE", m3_CRSE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RSUF))
				request.WithQueryParameter("RSUF", m3_RSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AAGN))
				request.WithQueryParameter("AAGN", m3_AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());

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
		/// Name DltCustomerVar
		/// Description Deletet Customer Variations
		/// Version Release: 
		/// </summary>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltCustomerVar(
			string m3_TX40, 
			string m3_PRNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltCustomerVar",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("TX40", m3_TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
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
		/// Name GetCustomerVar
		/// Description Get Customer Variations
		/// Version Release: 
		/// </summary>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCustomerVarResponse></returns>
		/// <exception cref="M3Exception<GetCustomerVarResponse>"></exception>
		public async Task<M3Response<GetCustomerVarResponse>> GetCustomerVar(
			string m3_TX40, 
			string m3_PRNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetCustomerVar",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("TX40", m3_TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Execute the request
			var result = await Execute<GetCustomerVarResponse>(
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
		/// Name LstCustomerVar
		/// Description List Customer Variations
		/// Version Release: 
		/// </summary>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCustomerVarResponse></returns>
		/// <exception cref="M3Exception<LstCustomerVarResponse>"></exception>
		public async Task<M3Response<LstCustomerVarResponse>> LstCustomerVar(
			string m3_PRNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCustomerVar",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Execute the request
			var result = await Execute<LstCustomerVarResponse>(
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
