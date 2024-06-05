/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.TXS130MI;
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
	/// Name: TXS130MI
	/// Component Name: SalesPurchaseProp
	/// Description: Api: EU Sales/Purchase Proposal
	/// Version Release: 5ea1
	///</summary>
	public partial class TXS130MIResource : M3BaseResourceEndpoint
	{
		public TXS130MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "TXS130MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetHeadInfo
		/// Description Get header information
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_ESSU">EU proposal (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadInfoResponse></returns>
		/// <exception cref="M3Exception<GetHeadInfoResponse>"></exception>
		public async Task<M3Response<GetHeadInfoResponse>> GetHeadInfo(
			string m3_DIVI, 
			string m3_ESSU, 
			int? m3_CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ESSU))
				throw new ArgumentNullException("m3_ESSU");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("ESSU", m3_ESSU.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name LstAmountEUSale
		/// Description List Amount EU Sale
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_ESSU">EU proposal (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAmountEUSaleResponse></returns>
		/// <exception cref="M3Exception<LstAmountEUSaleResponse>"></exception>
		public async Task<M3Response<LstAmountEUSaleResponse>> LstAmountEUSale(
			string m3_DIVI, 
			string m3_ESSU, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAmountEUSale",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_ESSU))
				throw new ArgumentNullException("m3_ESSU");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("ESSU", m3_ESSU.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstAmountEUSaleResponse>(
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
		/// Name LstInvEUSale
		/// Description List Invoices EU Sale
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_ESSU">EU sales or purchase proposal (Required)</param>
		/// <param name="m3_FTCO">From/to country (Required)</param>
		/// <param name="m3_YVRN">VAT registration number (Required)</param>
		/// <param name="m3_TRIA">Triangular trade (Required)</param>
		/// <param name="m3_SERV">VAT report type (Required)</param>
		/// <param name="m3_CORP">Correction (Required)</param>
		/// <param name="m3_CVOP">Customer/supplier code (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvEUSaleResponse></returns>
		/// <exception cref="M3Exception<LstInvEUSaleResponse>"></exception>
		public async Task<M3Response<LstInvEUSaleResponse>> LstInvEUSale(
			int m3_CONO, 
			string m3_DIVI, 
			string m3_ESSU, 
			string m3_FTCO, 
			string m3_YVRN, 
			int m3_TRIA, 
			int m3_SERV, 
			int m3_CORP, 
			int m3_CVOP, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInvEUSale",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_ESSU))
				throw new ArgumentNullException("m3_ESSU");
			if (string.IsNullOrWhiteSpace(m3_FTCO))
				throw new ArgumentNullException("m3_FTCO");
			if (string.IsNullOrWhiteSpace(m3_YVRN))
				throw new ArgumentNullException("m3_YVRN");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("ESSU", m3_ESSU.Trim())
				.WithQueryParameter("FTCO", m3_FTCO.Trim())
				.WithQueryParameter("YVRN", m3_YVRN.Trim())
				.WithQueryParameter("TRIA", m3_TRIA.ToString())
				.WithQueryParameter("SERV", m3_SERV.ToString())
				.WithQueryParameter("CORP", m3_CORP.ToString())
				.WithQueryParameter("CVOP", m3_CVOP.ToString());

			// Execute the request
			var result = await Execute<LstInvEUSaleResponse>(
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
