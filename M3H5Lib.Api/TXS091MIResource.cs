/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.TXS091MI;
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
	/// Name: TXS091MI
	/// Component Name: Tax Invoice Settings. Cust Exe
	/// Description: Tax Invoice Settings. Customer exemption
	/// Version Release: 5ea1
	///</summary>
	public partial class TXS091MIResource : M3BaseResourceEndpoint
	{
		public TXS091MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "TXS091MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddTaxInvCusEx
		/// Description Add tax invoice settings customer exemption
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_BSCD">Base country (Required)</param>
		/// <param name="m3_CUNO">Customer (Required)</param>
		/// <param name="m3_ARRV">Reversed reporting (Required)</param>
		/// <param name="m3_ARTX">Include in tax invoice (Required)</param>
		/// <param name="m3_GRFQ">Group frequency (Required)</param>
		/// <param name="m3_GRDC">Group debit/credit (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_IVCL">Invoice class</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddTaxInvCusEx(
			string m3_BSCD, 
			string m3_CUNO, 
			int m3_ARRV, 
			int m3_ARTX, 
			int m3_GRFQ, 
			int m3_GRDC, 
			string m3_DIVI = null, 
			string m3_IVCL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddTaxInvCusEx",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BSCD))
				throw new ArgumentNullException("m3_BSCD");
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("BSCD", m3_BSCD.Trim())
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("ARRV", m3_ARRV.ToString())
				.WithQueryParameter("ARTX", m3_ARTX.ToString())
				.WithQueryParameter("GRFQ", m3_GRFQ.ToString())
				.WithQueryParameter("GRDC", m3_GRDC.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IVCL))
				request.WithQueryParameter("IVCL", m3_IVCL.Trim());

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
		/// Name CpyTaxInvCusEx
		/// Description Copy tax invoice settings customer exemption
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_BSCD">Base country (Required)</param>
		/// <param name="m3_CUNO">Customer (Required)</param>
		/// <param name="m3_CBSC">Base country - copy to (Required)</param>
		/// <param name="m3_CCUN">Customer - copy to (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyTaxInvCusEx(
			string m3_BSCD, 
			string m3_CUNO, 
			string m3_CBSC, 
			string m3_CCUN, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyTaxInvCusEx",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BSCD))
				throw new ArgumentNullException("m3_BSCD");
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_CBSC))
				throw new ArgumentNullException("m3_CBSC");
			if (string.IsNullOrWhiteSpace(m3_CCUN))
				throw new ArgumentNullException("m3_CCUN");

			// Set mandatory parameters
			request
				.WithQueryParameter("BSCD", m3_BSCD.Trim())
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("CBSC", m3_CBSC.Trim())
				.WithQueryParameter("CCUN", m3_CCUN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

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
		/// Name DelTaxInvCusEx
		/// Description Delete tax invoice settings customer exemption
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_BSCD">Base country (Required)</param>
		/// <param name="m3_CUNO">Customer (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelTaxInvCusEx(
			string m3_BSCD, 
			string m3_CUNO, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelTaxInvCusEx",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BSCD))
				throw new ArgumentNullException("m3_BSCD");
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("BSCD", m3_BSCD.Trim())
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

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
		/// Name GetTaxInvCusEx
		/// Description Get tax invoice settings customer exemption
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_BSCD">Base country (Required)</param>
		/// <param name="m3_CUNO">Customer (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTaxInvCusExResponse></returns>
		/// <exception cref="M3Exception<GetTaxInvCusExResponse>"></exception>
		public async Task<M3Response<GetTaxInvCusExResponse>> GetTaxInvCusEx(
			string m3_BSCD, 
			string m3_CUNO, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetTaxInvCusEx",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BSCD))
				throw new ArgumentNullException("m3_BSCD");
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("BSCD", m3_BSCD.Trim())
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<GetTaxInvCusExResponse>(
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
		/// Name LstTaxInvCusEx
		/// Description List tax invoice settings customer exemption
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_BSCD">Base country</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTaxInvCusExResponse></returns>
		/// <exception cref="M3Exception<LstTaxInvCusExResponse>"></exception>
		public async Task<M3Response<LstTaxInvCusExResponse>> LstTaxInvCusEx(
			string m3_DIVI = null, 
			string m3_BSCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTaxInvCusEx",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BSCD))
				request.WithQueryParameter("BSCD", m3_BSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Execute the request
			var result = await Execute<LstTaxInvCusExResponse>(
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
		/// Name UpdTaxInvCusEx
		/// Description Update tax invoice settings customer exemption
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_BSCD">Base country (Required)</param>
		/// <param name="m3_CUNO">Customer (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_ARRV">Reversed reporting</param>
		/// <param name="m3_ARTX">Include in tax invoice</param>
		/// <param name="m3_GRFQ">Group frequency</param>
		/// <param name="m3_GRDC">Group debit/credit</param>
		/// <param name="m3_IVCL">Invoice class</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdTaxInvCusEx(
			string m3_BSCD, 
			string m3_CUNO, 
			string m3_DIVI = null, 
			int? m3_ARRV = null, 
			int? m3_ARTX = null, 
			int? m3_GRFQ = null, 
			int? m3_GRDC = null, 
			string m3_IVCL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdTaxInvCusEx",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BSCD))
				throw new ArgumentNullException("m3_BSCD");
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("BSCD", m3_BSCD.Trim())
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_ARRV.HasValue)
				request.WithQueryParameter("ARRV", m3_ARRV.Value.ToString());
			if (m3_ARTX.HasValue)
				request.WithQueryParameter("ARTX", m3_ARTX.Value.ToString());
			if (m3_GRFQ.HasValue)
				request.WithQueryParameter("GRFQ", m3_GRFQ.Value.ToString());
			if (m3_GRDC.HasValue)
				request.WithQueryParameter("GRDC", m3_GRDC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_IVCL))
				request.WithQueryParameter("IVCL", m3_IVCL.Trim());

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
