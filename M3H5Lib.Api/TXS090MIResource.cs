/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.TXS090MI;
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
	/// Name: TXS090MI
	/// Component Name: Tax Invoice Settings
	/// Description: Tax Invoice Settings
	/// Version Release: 5ea1
	///</summary>
	public partial class TXS090MIResource : M3BaseResourceEndpoint
	{
		public TXS090MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "TXS090MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddTaxInvSet
		/// Description Add tax invoice settings
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3BSCD">Base country (Required)</param>
		/// <param name="m3ARTX">Include in tax invoice (Required)</param>
		/// <param name="m3GRFQ">Group frequency (Required)</param>
		/// <param name="m3GRDC">Group debit/credit (Required)</param>
		/// <param name="m3APBL">Payment stop rule (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3IVCL">Invoice class</param>
		/// <param name="m3IVBL">Payment stop</param>
		/// <param name="m3BLBY">Stopped by</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddTaxInvSet(
			string m3BSCD, 
			int m3ARTX, 
			int m3GRFQ, 
			int m3GRDC, 
			int m3APBL, 
			string m3DIVI = null, 
			string m3IVCL = null, 
			int? m3IVBL = null, 
			string m3BLBY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddTaxInvSet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BSCD))
				throw new ArgumentNullException(nameof(m3BSCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("BSCD", m3BSCD.Trim())
				.WithQueryParameter("ARTX", m3ARTX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("GRFQ", m3GRFQ.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("GRDC", m3GRDC.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("APBL", m3APBL.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3IVCL))
				request.WithQueryParameter("IVCL", m3IVCL.Trim());
			if (m3IVBL.HasValue)
				request.WithQueryParameter("IVBL", m3IVBL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BLBY))
				request.WithQueryParameter("BLBY", m3BLBY.Trim());

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
		/// Name CpyTaxInvSet
		/// Description Copy tax invoice settings
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3BSCD">Base country (Required)</param>
		/// <param name="m3CBSC">Base country - copy to (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyTaxInvSet(
			string m3BSCD, 
			string m3CBSC, 
			string m3DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyTaxInvSet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BSCD))
				throw new ArgumentNullException(nameof(m3BSCD));
			if (string.IsNullOrWhiteSpace(m3CBSC))
				throw new ArgumentNullException(nameof(m3CBSC));

			// Set mandatory parameters
			request
				.WithQueryParameter("BSCD", m3BSCD.Trim())
				.WithQueryParameter("CBSC", m3CBSC.Trim());

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
		/// Name DelTaxInvSet
		/// Description Delete tax invoice settings
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3BSCD">Base country (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelTaxInvSet(
			string m3BSCD, 
			string m3DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelTaxInvSet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BSCD))
				throw new ArgumentNullException(nameof(m3BSCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("BSCD", m3BSCD.Trim());

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
		/// Name GetTaxInvSet
		/// Description Get tax invoice settings
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3BSCD">Base country (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTaxInvSetResponse></returns>
		/// <exception cref="M3Exception<GetTaxInvSetResponse>"></exception>
		public async Task<M3Response<GetTaxInvSetResponse>> GetTaxInvSet(
			string m3BSCD, 
			string m3DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetTaxInvSet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BSCD))
				throw new ArgumentNullException(nameof(m3BSCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("BSCD", m3BSCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<GetTaxInvSetResponse>(
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
		/// Name LstTaxInvSet
		/// Description List tax invoice settings
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3BSCD">Base country</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTaxInvSetResponse></returns>
		/// <exception cref="M3Exception<LstTaxInvSetResponse>"></exception>
		public async Task<M3Response<LstTaxInvSetResponse>> LstTaxInvSet(
			string m3DIVI = null, 
			string m3BSCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTaxInvSet",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3BSCD))
				request.WithQueryParameter("BSCD", m3BSCD.Trim());

			// Execute the request
			var result = await Execute<LstTaxInvSetResponse>(
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
		/// Name UpdTaxInvSet
		/// Description Update tax invoice settings
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3BSCD">Base country (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3ARTX">Include in tax invoice</param>
		/// <param name="m3GRFQ">Group frequency</param>
		/// <param name="m3GRDC">Group debit/credit</param>
		/// <param name="m3IVCL">Invoice class</param>
		/// <param name="m3APBL">Payment stop rule</param>
		/// <param name="m3IVBL">Payment stop</param>
		/// <param name="m3BLBY">Stopped by</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdTaxInvSet(
			string m3BSCD, 
			string m3DIVI = null, 
			int? m3ARTX = null, 
			int? m3GRFQ = null, 
			int? m3GRDC = null, 
			string m3IVCL = null, 
			int? m3APBL = null, 
			int? m3IVBL = null, 
			string m3BLBY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdTaxInvSet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BSCD))
				throw new ArgumentNullException(nameof(m3BSCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("BSCD", m3BSCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3ARTX.HasValue)
				request.WithQueryParameter("ARTX", m3ARTX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRFQ.HasValue)
				request.WithQueryParameter("GRFQ", m3GRFQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRDC.HasValue)
				request.WithQueryParameter("GRDC", m3GRDC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3IVCL))
				request.WithQueryParameter("IVCL", m3IVCL.Trim());
			if (m3APBL.HasValue)
				request.WithQueryParameter("APBL", m3APBL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IVBL.HasValue)
				request.WithQueryParameter("IVBL", m3IVBL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BLBY))
				request.WithQueryParameter("BLBY", m3BLBY.Trim());

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
