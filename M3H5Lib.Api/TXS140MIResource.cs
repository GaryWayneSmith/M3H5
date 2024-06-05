/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetHeadInfo
		/// Description Get header information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_VRUN">VAT run (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadInfoResponse></returns>
		/// <exception cref="M3Exception<GetHeadInfoResponse>"></exception>
		public async Task<M3Response<GetHeadInfoResponse>> GetHeadInfo(
			int m3_CONO, 
			string m3_DIVI, 
			string m3_VRUN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHeadInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_VRUN))
				throw new ArgumentNullException("m3_VRUN");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("VRUN", m3_VRUN.Trim());

			// Execute the request
			var result = await Execute<GetHeadInfoResponse>(
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
		/// Name LstCusSupVATLin
		/// Description List Customer/Supplier VAT line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_VRUN">VAT run (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCusSupVATLinResponse></returns>
		/// <exception cref="M3Exception<LstCusSupVATLinResponse>"></exception>
		public async Task<M3Response<LstCusSupVATLinResponse>> LstCusSupVATLin(
			int m3_CONO, 
			string m3_DIVI, 
			string m3_VRUN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCusSupVATLin",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_VRUN))
				throw new ArgumentNullException("m3_VRUN");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("VRUN", m3_VRUN.Trim());

			// Execute the request
			var result = await Execute<LstCusSupVATLinResponse>(
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
		/// Name LstTotalPerInv
		/// Description List totals per invoice
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_VRUN">VAT run</param>
		/// <param name="m3_YVRN">VAT registration number</param>
		/// <param name="m3_FTCO">From/to country</param>
		/// <param name="m3_CVOP">Customer/supplier code</param>
		/// <param name="m3_CUSP">Customer/supplier</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTotalPerInvResponse></returns>
		/// <exception cref="M3Exception<LstTotalPerInvResponse>"></exception>
		public async Task<M3Response<LstTotalPerInvResponse>> LstTotalPerInv(
			string m3_DIVI, 
			string m3_VRUN = null, 
			string m3_YVRN = null, 
			string m3_FTCO = null, 
			int? m3_CVOP = null, 
			string m3_CUSP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTotalPerInv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_VRUN))
				request.WithQueryParameter("VRUN", m3_VRUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YVRN))
				request.WithQueryParameter("YVRN", m3_YVRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FTCO))
				request.WithQueryParameter("FTCO", m3_FTCO.Trim());
			if (m3_CVOP.HasValue)
				request.WithQueryParameter("CVOP", m3_CVOP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUSP))
				request.WithQueryParameter("CUSP", m3_CUSP.Trim());

			// Execute the request
			var result = await Execute<LstTotalPerInvResponse>(
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
		/// Name LstVATRegNoLine
		/// Description List VAT registration no line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_VRUN">VAT run (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstVATRegNoLineResponse></returns>
		/// <exception cref="M3Exception<LstVATRegNoLineResponse>"></exception>
		public async Task<M3Response<LstVATRegNoLineResponse>> LstVATRegNoLine(
			int m3_CONO, 
			string m3_DIVI, 
			string m3_VRUN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstVATRegNoLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_VRUN))
				throw new ArgumentNullException("m3_VRUN");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("VRUN", m3_VRUN.Trim());

			// Execute the request
			var result = await Execute<LstVATRegNoLineResponse>(
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
