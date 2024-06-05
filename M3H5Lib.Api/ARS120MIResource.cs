/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetHeadText
		/// Description Get invoice header text fields
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3CINO">Invoice number (Required)</param>
		/// <param name="m3INYR">Invoice year (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadTextResponse></returns>
		/// <exception cref="M3Exception<GetHeadTextResponse>"></exception>
		public async Task<M3Response<GetHeadTextResponse>> GetHeadText(
			string m3CINO, 
			int m3INYR, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetHeadText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CINO))
				throw new ArgumentNullException(nameof(m3CINO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CINO", m3CINO.Trim())
				.WithQueryParameter("INYR", m3INYR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<GetHeadTextResponse>(
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
		/// Name GetInvHead
		/// Description Get invoice header information
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3CINO">Invoice number (Required)</param>
		/// <param name="m3INYR">Invoice year (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInvHeadResponse></returns>
		/// <exception cref="M3Exception<GetInvHeadResponse>"></exception>
		public async Task<M3Response<GetInvHeadResponse>> GetInvHead(
			string m3CINO, 
			int m3INYR, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetInvHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CINO))
				throw new ArgumentNullException(nameof(m3CINO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CINO", m3CINO.Trim())
				.WithQueryParameter("INYR", m3INYR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<GetInvHeadResponse>(
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
		/// Name LstInvLines
		/// Description List invoice line information
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3JBNO">Job number (Required)</param>
		/// <param name="m3JBDT">Job date (Required)</param>
		/// <param name="m3JBTM">Job time (Required)</param>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3CINO">Invoice number (Required)</param>
		/// <param name="m3INYR">Invoice year (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3ILNO">Line number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvLinesResponse></returns>
		/// <exception cref="M3Exception<LstInvLinesResponse>"></exception>
		public async Task<M3Response<LstInvLinesResponse>> LstInvLines(
			int m3JBNO, 
			DateTime m3JBDT, 
			int m3JBTM, 
			string m3CUNO, 
			string m3CINO, 
			int m3INYR, 
			string m3DIVI = null, 
			int? m3ILNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstInvLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3CINO))
				throw new ArgumentNullException(nameof(m3CINO));

			// Set mandatory parameters
			request
				.WithQueryParameter("JBNO", m3JBNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBDT", m3JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3JBTM.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("CINO", m3CINO.Trim())
				.WithQueryParameter("INYR", m3INYR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3ILNO.HasValue)
				request.WithQueryParameter("ILNO", m3ILNO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstInvLinesResponse>(
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
		/// Name LstSalesTaxInfo
		/// Description List Sales Tax information
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3JBNO">Job number (Required)</param>
		/// <param name="m3JBDT">Job date (Required)</param>
		/// <param name="m3JBTM">Job time (Required)</param>
		/// <param name="m3CINO">Invoice number (Required)</param>
		/// <param name="m3INYR">Invoice year (Required)</param>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3SEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSalesTaxInfoResponse></returns>
		/// <exception cref="M3Exception<LstSalesTaxInfoResponse>"></exception>
		public async Task<M3Response<LstSalesTaxInfoResponse>> LstSalesTaxInfo(
			int m3JBNO, 
			DateTime m3JBDT, 
			int m3JBTM, 
			string m3CINO, 
			int m3INYR, 
			string m3CUNO, 
			string m3DIVI = null, 
			int? m3SEQN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstSalesTaxInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CINO))
				throw new ArgumentNullException(nameof(m3CINO));
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("JBNO", m3JBNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBDT", m3JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3JBTM.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CINO", m3CINO.Trim())
				.WithQueryParameter("INYR", m3INYR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3SEQN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstSalesTaxInfoResponse>(
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
		/// Name LstTxExmpTxtVAT
		/// Description List Tax exemption text per VAT code
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CINO">Invoice number (Required)</param>
		/// <param name="m3INYR">Invoice year (Required)</param>
		/// <param name="m3VTCD">VAT code (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTxExmpTxtVATResponse></returns>
		/// <exception cref="M3Exception<LstTxExmpTxtVATResponse>"></exception>
		public async Task<M3Response<LstTxExmpTxtVATResponse>> LstTxExmpTxtVAT(
			string m3CINO, 
			int m3INYR, 
			int m3VTCD, 
			string m3DIVI = null, 
			string m3LNCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstTxExmpTxtVAT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CINO))
				throw new ArgumentNullException(nameof(m3CINO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CINO", m3CINO.Trim())
				.WithQueryParameter("INYR", m3INYR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("VTCD", m3VTCD.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<LstTxExmpTxtVATResponse>(
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
