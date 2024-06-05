/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.ENS100MI;
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
	/// Name: ENS100MI
	/// Component Name: Sales
	/// Description: Api: Eco Transaction
	/// Version Release: 5ea0
	///</summary>
	public partial class ENS100MIResource : M3BaseResourceEndpoint
	{
		public ENS100MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "ENS100MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstDetailsByJob
		/// Description List detailed transactions per job number
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3BJNO">Job number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDetailsByJobResponse></returns>
		/// <exception cref="M3Exception<LstDetailsByJobResponse>"></exception>
		public async Task<M3Response<LstDetailsByJobResponse>> LstDetailsByJob(
			string m3DIVI = null, 
			string m3BJNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDetailsByJob",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3BJNO))
				request.WithQueryParameter("BJNO", m3BJNO.Trim());

			// Execute the request
			var result = await Execute<LstDetailsByJobResponse>(
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
		/// Name LstTotalsByProd
		/// Description List totals per Eco-product code
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3BJNO">Job number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTotalsByProdResponse></returns>
		/// <exception cref="M3Exception<LstTotalsByProdResponse>"></exception>
		public async Task<M3Response<LstTotalsByProdResponse>> LstTotalsByProd(
			string m3DIVI = null, 
			string m3BJNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTotalsByProd",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3BJNO))
				request.WithQueryParameter("BJNO", m3BJNO.Trim());

			// Execute the request
			var result = await Execute<LstTotalsByProdResponse>(
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
