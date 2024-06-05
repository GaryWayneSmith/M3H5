/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddTaxInvCusEx
		/// Description Add tax invoice settings customer exemption
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3BSCD">Base country (Required)</param>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3ARRV">Reversed reporting (Required)</param>
		/// <param name="m3ARTX">Include in tax invoice (Required)</param>
		/// <param name="m3GRFQ">Group frequency (Required)</param>
		/// <param name="m3GRDC">Group debit/credit (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3IVCL">Invoice class</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddTaxInvCusEx(
			string m3BSCD, 
			string m3CUNO, 
			int m3ARRV, 
			int m3ARTX, 
			int m3GRFQ, 
			int m3GRDC, 
			string m3DIVI = null, 
			string m3IVCL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddTaxInvCusEx",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BSCD))
				throw new ArgumentNullException(nameof(m3BSCD));
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("BSCD", m3BSCD.Trim())
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("ARRV", m3ARRV.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ARTX", m3ARTX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("GRFQ", m3GRFQ.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("GRDC", m3GRDC.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3IVCL))
				request.WithQueryParameter("IVCL", m3IVCL.Trim());

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
		/// Name CpyTaxInvCusEx
		/// Description Copy tax invoice settings customer exemption
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3BSCD">Base country (Required)</param>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3CBSC">Base country - copy to (Required)</param>
		/// <param name="m3CCUN">Customer - copy to (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyTaxInvCusEx(
			string m3BSCD, 
			string m3CUNO, 
			string m3CBSC, 
			string m3CCUN, 
			string m3DIVI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CpyTaxInvCusEx",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BSCD))
				throw new ArgumentNullException(nameof(m3BSCD));
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3CBSC))
				throw new ArgumentNullException(nameof(m3CBSC));
			if (string.IsNullOrWhiteSpace(m3CCUN))
				throw new ArgumentNullException(nameof(m3CCUN));

			// Set mandatory parameters
			request
				.WithQueryParameter("BSCD", m3BSCD.Trim())
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("CBSC", m3CBSC.Trim())
				.WithQueryParameter("CCUN", m3CCUN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

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
		/// Name DelTaxInvCusEx
		/// Description Delete tax invoice settings customer exemption
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3BSCD">Base country (Required)</param>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelTaxInvCusEx(
			string m3BSCD, 
			string m3CUNO, 
			string m3DIVI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelTaxInvCusEx",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BSCD))
				throw new ArgumentNullException(nameof(m3BSCD));
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("BSCD", m3BSCD.Trim())
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

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
		/// Name GetTaxInvCusEx
		/// Description Get tax invoice settings customer exemption
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3BSCD">Base country (Required)</param>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTaxInvCusExResponse></returns>
		/// <exception cref="M3Exception<GetTaxInvCusExResponse>"></exception>
		public async Task<M3Response<GetTaxInvCusExResponse>> GetTaxInvCusEx(
			string m3BSCD, 
			string m3CUNO, 
			string m3DIVI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetTaxInvCusEx",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BSCD))
				throw new ArgumentNullException(nameof(m3BSCD));
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("BSCD", m3BSCD.Trim())
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<GetTaxInvCusExResponse>(
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
		/// Name LstTaxInvCusEx
		/// Description List tax invoice settings customer exemption
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3BSCD">Base country</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTaxInvCusExResponse></returns>
		/// <exception cref="M3Exception<LstTaxInvCusExResponse>"></exception>
		public async Task<M3Response<LstTaxInvCusExResponse>> LstTaxInvCusEx(
			string m3DIVI = null, 
			string m3BSCD = null, 
			string m3CUNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstTaxInvCusEx",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3BSCD))
				request.WithQueryParameter("BSCD", m3BSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Execute the request
			var result = await Execute<LstTaxInvCusExResponse>(
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
		/// Name UpdTaxInvCusEx
		/// Description Update tax invoice settings customer exemption
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3BSCD">Base country (Required)</param>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3ARRV">Reversed reporting</param>
		/// <param name="m3ARTX">Include in tax invoice</param>
		/// <param name="m3GRFQ">Group frequency</param>
		/// <param name="m3GRDC">Group debit/credit</param>
		/// <param name="m3IVCL">Invoice class</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdTaxInvCusEx(
			string m3BSCD, 
			string m3CUNO, 
			string m3DIVI = null, 
			int? m3ARRV = null, 
			int? m3ARTX = null, 
			int? m3GRFQ = null, 
			int? m3GRDC = null, 
			string m3IVCL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdTaxInvCusEx",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BSCD))
				throw new ArgumentNullException(nameof(m3BSCD));
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("BSCD", m3BSCD.Trim())
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3ARRV.HasValue)
				request.WithQueryParameter("ARRV", m3ARRV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ARTX.HasValue)
				request.WithQueryParameter("ARTX", m3ARTX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRFQ.HasValue)
				request.WithQueryParameter("GRFQ", m3GRFQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRDC.HasValue)
				request.WithQueryParameter("GRDC", m3GRDC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3IVCL))
				request.WithQueryParameter("IVCL", m3IVCL.Trim());

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
