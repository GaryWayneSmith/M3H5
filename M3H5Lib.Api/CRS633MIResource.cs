/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.CRS633MI;
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
	/// Name: CRS633MI
	/// Component Name: Account groups
	/// Description: Account groups interface
	/// Version Release: 5e90
	///</summary>
	public partial class CRS633MIResource : M3BaseResourceEndpoint
	{
		public CRS633MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS633MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetAccountGroup
		/// Description Retrieve account group information
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3AICL">Account group (Required)</param>
		/// <param name="m3LVEL">Level (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAccountGroupResponse></returns>
		/// <exception cref="M3Exception<GetAccountGroupResponse>"></exception>
		public async Task<M3Response<GetAccountGroupResponse>> GetAccountGroup(
			string m3AICL, 
			int m3LVEL, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAccountGroup",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AICL))
				throw new ArgumentNullException(nameof(m3AICL));

			// Set mandatory parameters
			request
				.WithQueryParameter("AICL", m3AICL.Trim())
				.WithQueryParameter("LVEL", m3LVEL.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<GetAccountGroupResponse>(
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
		/// Name LstAccGroups
		/// Description List Account groups
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3AICL">Account group</param>
		/// <param name="m3LVEL">Level</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAccGroupsResponse></returns>
		/// <exception cref="M3Exception<LstAccGroupsResponse>"></exception>
		public async Task<M3Response<LstAccGroupsResponse>> LstAccGroups(
			string m3DIVI = null, 
			string m3AICL = null, 
			int? m3LVEL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAccGroups",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3AICL))
				request.WithQueryParameter("AICL", m3AICL.Trim());
			if (m3LVEL.HasValue)
				request.WithQueryParameter("LVEL", m3LVEL.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAccGroupsResponse>(
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
