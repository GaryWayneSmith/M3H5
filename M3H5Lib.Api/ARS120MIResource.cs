/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.ARS120MI;
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
	/// Name: ARS120MI
	/// Component Name: Financials
	/// Description: Api: Manual invoices
	/// Version Release: 5ea0
	///</summary>
	public partial class ARS120MIResource : M3BaseResourceEndpoint
	{
		public ARS120MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "ARS120MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetHeadText
		/// Description Get invoice header text fields
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_CINO">Invoice number (Required)</param>
		/// <param name="m3_INYR">Invoice year (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadTextResponse></returns>
		/// <exception cref="M3Exception<GetHeadTextResponse>"></exception>
		public async Task<M3Response<GetHeadTextResponse>> GetHeadText(
			string m3_CINO, 
			int m3_INYR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHeadText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CINO))
				throw new ArgumentNullException("m3_CINO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CINO", m3_CINO.Trim())
				.WithQueryParameter("INYR", m3_INYR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<GetHeadTextResponse>(
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
		/// Name GetInvHead
		/// Description Get invoice header information
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_CINO">Invoice number (Required)</param>
		/// <param name="m3_INYR">Invoice year (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInvHeadResponse></returns>
		/// <exception cref="M3Exception<GetInvHeadResponse>"></exception>
		public async Task<M3Response<GetInvHeadResponse>> GetInvHead(
			string m3_CINO, 
			int m3_INYR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetInvHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CINO))
				throw new ArgumentNullException("m3_CINO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CINO", m3_CINO.Trim())
				.WithQueryParameter("INYR", m3_INYR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<GetInvHeadResponse>(
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
		/// Name LstInvLines
		/// Description List invoice line information
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_JBNO">Job number (Required)</param>
		/// <param name="m3_JBDT">Job date (Required)</param>
		/// <param name="m3_JBTM">Job time (Required)</param>
		/// <param name="m3_CUNO">Customer (Required)</param>
		/// <param name="m3_CINO">Invoice number (Required)</param>
		/// <param name="m3_INYR">Invoice year (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_ILNO">Line number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvLinesResponse></returns>
		/// <exception cref="M3Exception<LstInvLinesResponse>"></exception>
		public async Task<M3Response<LstInvLinesResponse>> LstInvLines(
			int m3_JBNO, 
			DateTime m3_JBDT, 
			int m3_JBTM, 
			string m3_CUNO, 
			string m3_CINO, 
			int m3_INYR, 
			string m3_DIVI = null, 
			int? m3_ILNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInvLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_CINO))
				throw new ArgumentNullException("m3_CINO");

			// Set mandatory parameters
			request
				.WithQueryParameter("JBNO", m3_JBNO.ToString())
				.WithQueryParameter("JBDT", m3_JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3_JBTM.ToString())
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("CINO", m3_CINO.Trim())
				.WithQueryParameter("INYR", m3_INYR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_ILNO.HasValue)
				request.WithQueryParameter("ILNO", m3_ILNO.Value.ToString());

			// Execute the request
			var result = await Execute<LstInvLinesResponse>(
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
		/// Name LstSalesTaxInfo
		/// Description List Sales Tax information
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_JBNO">Job number (Required)</param>
		/// <param name="m3_JBDT">Job date (Required)</param>
		/// <param name="m3_JBTM">Job time (Required)</param>
		/// <param name="m3_CINO">Invoice number (Required)</param>
		/// <param name="m3_INYR">Invoice year (Required)</param>
		/// <param name="m3_CUNO">Customer (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSalesTaxInfoResponse></returns>
		/// <exception cref="M3Exception<LstSalesTaxInfoResponse>"></exception>
		public async Task<M3Response<LstSalesTaxInfoResponse>> LstSalesTaxInfo(
			int m3_JBNO, 
			DateTime m3_JBDT, 
			int m3_JBTM, 
			string m3_CINO, 
			int m3_INYR, 
			string m3_CUNO, 
			string m3_DIVI = null, 
			int? m3_SEQN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSalesTaxInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CINO))
				throw new ArgumentNullException("m3_CINO");
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("JBNO", m3_JBNO.ToString())
				.WithQueryParameter("JBDT", m3_JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3_JBTM.ToString())
				.WithQueryParameter("CINO", m3_CINO.Trim())
				.WithQueryParameter("INYR", m3_INYR.ToString())
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());

			// Execute the request
			var result = await Execute<LstSalesTaxInfoResponse>(
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
		/// Name LstTxExmpTxtVAT
		/// Description List Tax exemption text per VAT code
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CINO">Invoice number (Required)</param>
		/// <param name="m3_INYR">Invoice year (Required)</param>
		/// <param name="m3_VTCD">VAT code (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTxExmpTxtVATResponse></returns>
		/// <exception cref="M3Exception<LstTxExmpTxtVATResponse>"></exception>
		public async Task<M3Response<LstTxExmpTxtVATResponse>> LstTxExmpTxtVAT(
			string m3_CINO, 
			int m3_INYR, 
			int m3_VTCD, 
			string m3_DIVI = null, 
			string m3_LNCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTxExmpTxtVAT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CINO))
				throw new ArgumentNullException("m3_CINO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CINO", m3_CINO.Trim())
				.WithQueryParameter("INYR", m3_INYR.ToString())
				.WithQueryParameter("VTCD", m3_VTCD.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<LstTxExmpTxtVATResponse>(
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
