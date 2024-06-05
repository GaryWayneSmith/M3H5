/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS693MI;
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
	/// Name: CRS693MI
	/// Component Name: BankAccountAdditional
	/// Description: Bank account additional values interface
	/// Version Release: 12.2
	///</summary>
	public partial class CRS693MIResource : M3BaseResourceEndpoint
	{
		public CRS693MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS693MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetBasicData
		/// Description Retrieve bank account additional values
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3_BKTP">Bank account type (Required)</param>
		/// <param name="m3_ACHO">Account holder (Required)</param>
		/// <param name="m3_BKID">Bank account identity (Required)</param>
		/// <param name="m3_BVTP">Bank account value type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicDataResponse></returns>
		/// <exception cref="M3Exception<GetBasicDataResponse>"></exception>
		public async Task<M3Response<GetBasicDataResponse>> GetBasicData(
			int m3_BKTP, 
			string m3_ACHO, 
			string m3_BKID, 
			int m3_BVTP, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ACHO))
				throw new ArgumentNullException("m3_ACHO");
			if (string.IsNullOrWhiteSpace(m3_BKID))
				throw new ArgumentNullException("m3_BKID");

			// Set mandatory parameters
			request
				.WithQueryParameter("BKTP", m3_BKTP.ToString())
				.WithQueryParameter("ACHO", m3_ACHO.Trim())
				.WithQueryParameter("BKID", m3_BKID.Trim())
				.WithQueryParameter("BVTP", m3_BVTP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<GetBasicDataResponse>(
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
		/// Name LstByAccHolder
		/// Description List Bank account additional values by account holder
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3_BKTP">Bank account type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_ACHO">Account holder</param>
		/// <param name="m3_BKID">Bank account identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByAccHolderResponse></returns>
		/// <exception cref="M3Exception<LstByAccHolderResponse>"></exception>
		public async Task<M3Response<LstByAccHolderResponse>> LstByAccHolder(
			int m3_BKTP, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_ACHO = null, 
			string m3_BKID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByAccHolder",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("BKTP", m3_BKTP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACHO))
				request.WithQueryParameter("ACHO", m3_ACHO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKID))
				request.WithQueryParameter("BKID", m3_BKID.Trim());

			// Execute the request
			var result = await Execute<LstByAccHolderResponse>(
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
		/// Name LstByValueType
		/// Description List Bank account additional values by value type
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_BVTP">Bank account value type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByValueTypeResponse></returns>
		/// <exception cref="M3Exception<LstByValueTypeResponse>"></exception>
		public async Task<M3Response<LstByValueTypeResponse>> LstByValueType(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			int? m3_BVTP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByValueType",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_BVTP.HasValue)
				request.WithQueryParameter("BVTP", m3_BVTP.Value.ToString());

			// Execute the request
			var result = await Execute<LstByValueTypeResponse>(
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
