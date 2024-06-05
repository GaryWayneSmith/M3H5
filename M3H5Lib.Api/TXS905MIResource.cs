/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.TXS905MI;
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
	/// Name: TXS905MI
	/// Component Name: Template item
	/// Description: Template item interface
	/// Version Release: 5ea1
	///</summary>
	public partial class TXS905MIResource : M3BaseResourceEndpoint
	{
		public TXS905MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "TXS905MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Approve
		/// Description Approve
		/// Version Release: 6400
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BSCD">Base country (Required)</param>
		/// <param name="m3PTIN">Preliminary tax invoice number (Required)</param>
		/// <param name="m3PTIY">Preliminary tax invoice year (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Approve(
			string m3DIVI, 
			string m3BSCD, 
			decimal m3PTIN, 
			int m3PTIY, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Approve",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BSCD))
				throw new ArgumentNullException(nameof(m3BSCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BSCD", m3BSCD.Trim())
				.WithQueryParameter("PTIN", m3PTIN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PTIY", m3PTIY.ToString(CultureInfo.CurrentCulture));

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
		/// Name Confirm
		/// Description Confirm
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BSCD">Base country (Required)</param>
		/// <param name="m3TXIV">Tax invoice number (Required)</param>
		/// <param name="m3TXIY">Tax invoice year (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Confirm(
			string m3DIVI, 
			string m3BSCD, 
			string m3TXIV, 
			int m3TXIY, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Confirm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BSCD))
				throw new ArgumentNullException(nameof(m3BSCD));
			if (string.IsNullOrWhiteSpace(m3TXIV))
				throw new ArgumentNullException(nameof(m3TXIV));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BSCD", m3BSCD.Trim())
				.WithQueryParameter("TXIV", m3TXIV.Trim())
				.WithQueryParameter("TXIY", m3TXIY.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetDefTaxInv
		/// Description Gets data for a Invoice - Online Invoicing
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BSCD">Base country (Required)</param>
		/// <param name="m3TXIV">Tax invoice number (Required)</param>
		/// <param name="m3TXIY">Tax invoice year (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDefTaxInvResponse></returns>
		/// <exception cref="M3Exception<GetDefTaxInvResponse>"></exception>
		public async Task<M3Response<GetDefTaxInvResponse>> GetDefTaxInv(
			string m3DIVI, 
			string m3BSCD, 
			string m3TXIV, 
			int m3TXIY, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetDefTaxInv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BSCD))
				throw new ArgumentNullException(nameof(m3BSCD));
			if (string.IsNullOrWhiteSpace(m3TXIV))
				throw new ArgumentNullException(nameof(m3TXIV));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BSCD", m3BSCD.Trim())
				.WithQueryParameter("TXIV", m3TXIV.Trim())
				.WithQueryParameter("TXIY", m3TXIY.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetDefTaxInvResponse>(
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
		/// Name GetPrelTaxInv
		/// Description Gets data for a Invoice - Online Invoicing
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BSCD">Base country (Required)</param>
		/// <param name="m3PTIN">Preliminary tax invoice number (Required)</param>
		/// <param name="m3PTIY">Preliminary tax invoice year (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPrelTaxInvResponse></returns>
		/// <exception cref="M3Exception<GetPrelTaxInvResponse>"></exception>
		public async Task<M3Response<GetPrelTaxInvResponse>> GetPrelTaxInv(
			string m3DIVI, 
			string m3BSCD, 
			decimal m3PTIN, 
			int m3PTIY, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetPrelTaxInv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BSCD))
				throw new ArgumentNullException(nameof(m3BSCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BSCD", m3BSCD.Trim())
				.WithQueryParameter("PTIN", m3PTIN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PTIY", m3PTIY.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetPrelTaxInvResponse>(
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
		/// Name LstDefTaxInv
		/// Description Gets data for a Invoice - Online Invoicing
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BSCD">Base country (Required)</param>
		/// <param name="m3TXIV">Tax invoice number</param>
		/// <param name="m3TXIY">Tax invoice year</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDefTaxInvResponse></returns>
		/// <exception cref="M3Exception<LstDefTaxInvResponse>"></exception>
		public async Task<M3Response<LstDefTaxInvResponse>> LstDefTaxInv(
			string m3DIVI, 
			string m3BSCD, 
			string m3TXIV = null, 
			int? m3TXIY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstDefTaxInv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BSCD))
				throw new ArgumentNullException(nameof(m3BSCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BSCD", m3BSCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TXIV))
				request.WithQueryParameter("TXIV", m3TXIV.Trim());
			if (m3TXIY.HasValue)
				request.WithQueryParameter("TXIY", m3TXIY.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstDefTaxInvResponse>(
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
		/// Name LstPrelTaxInv
		/// Description Gets data for a Invoice - Online Invoicing
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BSCD">Base country (Required)</param>
		/// <param name="m3PTIN">Preliminary tax invoice number</param>
		/// <param name="m3PTIY">Preliminary tax invoice year</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPrelTaxInvResponse></returns>
		/// <exception cref="M3Exception<LstPrelTaxInvResponse>"></exception>
		public async Task<M3Response<LstPrelTaxInvResponse>> LstPrelTaxInv(
			string m3DIVI, 
			string m3BSCD, 
			decimal? m3PTIN = null, 
			int? m3PTIY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPrelTaxInv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BSCD))
				throw new ArgumentNullException(nameof(m3BSCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BSCD", m3BSCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3PTIN.HasValue)
				request.WithQueryParameter("PTIN", m3PTIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PTIY.HasValue)
				request.WithQueryParameter("PTIY", m3PTIY.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPrelTaxInvResponse>(
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
		/// Name Send
		/// Description Send
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BSCD">Base country (Required)</param>
		/// <param name="m3PTIN">Preliminary tax invoice number (Required)</param>
		/// <param name="m3PTIY">Preliminary tax invoice year (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Send(
			string m3DIVI, 
			string m3BSCD, 
			decimal m3PTIN, 
			int m3PTIY, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Send",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BSCD))
				throw new ArgumentNullException(nameof(m3BSCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BSCD", m3BSCD.Trim())
				.WithQueryParameter("PTIN", m3PTIN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PTIY", m3PTIY.ToString(CultureInfo.CurrentCulture));

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
