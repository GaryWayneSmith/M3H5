/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.OIS210MI;
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
	/// Name: OIS210MI
	/// Component Name: OIS215
	/// Description: Cash sales open
	/// Version Release: 5e90
	///</summary>
	public partial class OIS210MIResource : M3BaseResourceEndpoint
	{
		public OIS210MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS210MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstAuthCashDesk
		/// Description List authorized cash desks
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_USID">User</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAuthCashDeskResponse></returns>
		/// <exception cref="M3Exception<LstAuthCashDeskResponse>"></exception>
		public async Task<M3Response<LstAuthCashDeskResponse>> LstAuthCashDesk(
			string m3_FACI = null, 
			string m3_USID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAuthCashDesk",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());

			// Execute the request
			var result = await Execute<LstAuthCashDeskResponse>(
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
		/// Name LstPayMethods
		/// Description LstPayMethods
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_CSHD">Cash desk</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPayMethodsResponse></returns>
		/// <exception cref="M3Exception<LstPayMethodsResponse>"></exception>
		public async Task<M3Response<LstPayMethodsResponse>> LstPayMethods(
			string m3_FACI = null, 
			string m3_CSHD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPayMethods",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSHD))
				request.WithQueryParameter("CSHD", m3_CSHD.Trim());

			// Execute the request
			var result = await Execute<LstPayMethodsResponse>(
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
