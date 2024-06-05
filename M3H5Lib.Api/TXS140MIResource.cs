/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.TXS140MI;
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
	/// Name: TXS140MI
	/// Component Name: AnnualVATReport
	/// Description: Api: Annual VAT reporting
	/// Version Release: 5ea0
	///</summary>
	public partial class TXS140MIResource : M3BaseResourceEndpoint
	{
		public TXS140MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "TXS140MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetHeadInfo
		/// Description Get header information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3VRUN">VAT run (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadInfoResponse></returns>
		/// <exception cref="M3Exception<GetHeadInfoResponse>"></exception>
		public async Task<M3Response<GetHeadInfoResponse>> GetHeadInfo(
			int m3CONO, 
			string m3DIVI, 
			string m3VRUN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetHeadInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3VRUN))
				throw new ArgumentNullException(nameof(m3VRUN));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("VRUN", m3VRUN.Trim());

			// Execute the request
			var result = await Execute<GetHeadInfoResponse>(
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
		/// Name LstCusSupVATLin
		/// Description List Customer/Supplier VAT line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3VRUN">VAT run (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCusSupVATLinResponse></returns>
		/// <exception cref="M3Exception<LstCusSupVATLinResponse>"></exception>
		public async Task<M3Response<LstCusSupVATLinResponse>> LstCusSupVATLin(
			int m3CONO, 
			string m3DIVI, 
			string m3VRUN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstCusSupVATLin",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3VRUN))
				throw new ArgumentNullException(nameof(m3VRUN));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("VRUN", m3VRUN.Trim());

			// Execute the request
			var result = await Execute<LstCusSupVATLinResponse>(
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
		/// Name LstTotalPerInv
		/// Description List totals per invoice
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3VRUN">VAT run</param>
		/// <param name="m3YVRN">VAT registration number</param>
		/// <param name="m3FTCO">From/to country</param>
		/// <param name="m3CVOP">Customer/supplier code</param>
		/// <param name="m3CUSP">Customer/supplier</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTotalPerInvResponse></returns>
		/// <exception cref="M3Exception<LstTotalPerInvResponse>"></exception>
		public async Task<M3Response<LstTotalPerInvResponse>> LstTotalPerInv(
			string m3DIVI, 
			string m3VRUN = null, 
			string m3YVRN = null, 
			string m3FTCO = null, 
			int? m3CVOP = null, 
			string m3CUSP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstTotalPerInv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3VRUN))
				request.WithQueryParameter("VRUN", m3VRUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3YVRN))
				request.WithQueryParameter("YVRN", m3YVRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FTCO))
				request.WithQueryParameter("FTCO", m3FTCO.Trim());
			if (m3CVOP.HasValue)
				request.WithQueryParameter("CVOP", m3CVOP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUSP))
				request.WithQueryParameter("CUSP", m3CUSP.Trim());

			// Execute the request
			var result = await Execute<LstTotalPerInvResponse>(
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
		/// Name LstVATRegNoLine
		/// Description List VAT registration no line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3VRUN">VAT run (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstVATRegNoLineResponse></returns>
		/// <exception cref="M3Exception<LstVATRegNoLineResponse>"></exception>
		public async Task<M3Response<LstVATRegNoLineResponse>> LstVATRegNoLine(
			int m3CONO, 
			string m3DIVI, 
			string m3VRUN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstVATRegNoLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3VRUN))
				throw new ArgumentNullException(nameof(m3VRUN));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("VRUN", m3VRUN.Trim());

			// Execute the request
			var result = await Execute<LstVATRegNoLineResponse>(
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
