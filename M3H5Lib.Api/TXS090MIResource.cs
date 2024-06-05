/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_BSCD">Base country (Required)</param>
		/// <param name="m3_ARTX">Include in tax invoice (Required)</param>
		/// <param name="m3_GRFQ">Group frequency (Required)</param>
		/// <param name="m3_GRDC">Group debit/credit (Required)</param>
		/// <param name="m3_APBL">Payment stop rule (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_IVCL">Invoice class</param>
		/// <param name="m3_IVBL">Payment stop</param>
		/// <param name="m3_BLBY">Stopped by</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddTaxInvSet(
			string m3_BSCD, 
			int m3_ARTX, 
			int m3_GRFQ, 
			int m3_GRDC, 
			int m3_APBL, 
			string m3_DIVI = null, 
			string m3_IVCL = null, 
			int? m3_IVBL = null, 
			string m3_BLBY = null, 
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
			if (string.IsNullOrWhiteSpace(m3_BSCD))
				throw new ArgumentNullException("m3_BSCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("BSCD", m3_BSCD.Trim())
				.WithQueryParameter("ARTX", m3_ARTX.ToString())
				.WithQueryParameter("GRFQ", m3_GRFQ.ToString())
				.WithQueryParameter("GRDC", m3_GRDC.ToString())
				.WithQueryParameter("APBL", m3_APBL.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IVCL))
				request.WithQueryParameter("IVCL", m3_IVCL.Trim());
			if (m3_IVBL.HasValue)
				request.WithQueryParameter("IVBL", m3_IVBL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BLBY))
				request.WithQueryParameter("BLBY", m3_BLBY.Trim());

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
		/// Name CpyTaxInvSet
		/// Description Copy tax invoice settings
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_BSCD">Base country (Required)</param>
		/// <param name="m3_CBSC">Base country - copy to (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyTaxInvSet(
			string m3_BSCD, 
			string m3_CBSC, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyTaxInvSet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BSCD))
				throw new ArgumentNullException("m3_BSCD");
			if (string.IsNullOrWhiteSpace(m3_CBSC))
				throw new ArgumentNullException("m3_CBSC");

			// Set mandatory parameters
			request
				.WithQueryParameter("BSCD", m3_BSCD.Trim())
				.WithQueryParameter("CBSC", m3_CBSC.Trim());

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
		/// Name DelTaxInvSet
		/// Description Delete tax invoice settings
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_BSCD">Base country (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelTaxInvSet(
			string m3_BSCD, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelTaxInvSet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BSCD))
				throw new ArgumentNullException("m3_BSCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("BSCD", m3_BSCD.Trim());

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
		/// Name GetTaxInvSet
		/// Description Get tax invoice settings
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_BSCD">Base country (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTaxInvSetResponse></returns>
		/// <exception cref="M3Exception<GetTaxInvSetResponse>"></exception>
		public async Task<M3Response<GetTaxInvSetResponse>> GetTaxInvSet(
			string m3_BSCD, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetTaxInvSet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BSCD))
				throw new ArgumentNullException("m3_BSCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("BSCD", m3_BSCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<GetTaxInvSetResponse>(
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
		/// Name LstTaxInvSet
		/// Description List tax invoice settings
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_BSCD">Base country</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTaxInvSetResponse></returns>
		/// <exception cref="M3Exception<LstTaxInvSetResponse>"></exception>
		public async Task<M3Response<LstTaxInvSetResponse>> LstTaxInvSet(
			string m3_DIVI = null, 
			string m3_BSCD = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BSCD))
				request.WithQueryParameter("BSCD", m3_BSCD.Trim());

			// Execute the request
			var result = await Execute<LstTaxInvSetResponse>(
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
		/// Name UpdTaxInvSet
		/// Description Update tax invoice settings
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_BSCD">Base country (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_ARTX">Include in tax invoice</param>
		/// <param name="m3_GRFQ">Group frequency</param>
		/// <param name="m3_GRDC">Group debit/credit</param>
		/// <param name="m3_IVCL">Invoice class</param>
		/// <param name="m3_APBL">Payment stop rule</param>
		/// <param name="m3_IVBL">Payment stop</param>
		/// <param name="m3_BLBY">Stopped by</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdTaxInvSet(
			string m3_BSCD, 
			string m3_DIVI = null, 
			int? m3_ARTX = null, 
			int? m3_GRFQ = null, 
			int? m3_GRDC = null, 
			string m3_IVCL = null, 
			int? m3_APBL = null, 
			int? m3_IVBL = null, 
			string m3_BLBY = null, 
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
			if (string.IsNullOrWhiteSpace(m3_BSCD))
				throw new ArgumentNullException("m3_BSCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("BSCD", m3_BSCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_ARTX.HasValue)
				request.WithQueryParameter("ARTX", m3_ARTX.Value.ToString());
			if (m3_GRFQ.HasValue)
				request.WithQueryParameter("GRFQ", m3_GRFQ.Value.ToString());
			if (m3_GRDC.HasValue)
				request.WithQueryParameter("GRDC", m3_GRDC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_IVCL))
				request.WithQueryParameter("IVCL", m3_IVCL.Trim());
			if (m3_APBL.HasValue)
				request.WithQueryParameter("APBL", m3_APBL.Value.ToString());
			if (m3_IVBL.HasValue)
				request.WithQueryParameter("IVBL", m3_IVBL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BLBY))
				request.WithQueryParameter("BLBY", m3_BLBY.Trim());

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
