/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.STS109MI;
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
	/// Name: STS109MI
	/// Component Name: STRAgreements
	/// Description: API: STR Agreement - Create
	/// Version Release: 12.5
	///</summary>
	public partial class STS109MIResource : M3BaseResourceEndpoint
	{
		public STS109MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "STS109MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name CrtRentalAgrmnt
		/// Description Create Rental Agreement
		/// Version Release: 12
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_CRCD">Create agreement (Required)</param>
		/// <param name="m3_ARCC">Reason code - created agreement (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRQA">Yes/no</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CrtRentalAgrmntResponse></returns>
		/// <exception cref="M3Exception<CrtRentalAgrmntResponse>"></exception>
		public async Task<M3Response<CrtRentalAgrmntResponse>> CrtRentalAgrmnt(
			string m3_AGNB, 
			int m3_VERS, 
			int m3_CRCD, 
			string m3_ARCC, 
			int? m3_CONO = null, 
			int? m3_PRQA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CrtRentalAgrmnt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_ARCC))
				throw new ArgumentNullException("m3_ARCC");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString())
				.WithQueryParameter("CRCD", m3_CRCD.ToString())
				.WithQueryParameter("ARCC", m3_ARCC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PRQA.HasValue)
				request.WithQueryParameter("PRQA", m3_PRQA.Value.ToString());

			// Execute the request
			var result = await Execute<CrtRentalAgrmntResponse>(
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
