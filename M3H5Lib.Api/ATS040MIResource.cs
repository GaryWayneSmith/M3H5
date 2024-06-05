/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.ATS040MI;
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
	/// Name: ATS040MI
	/// Component Name: Planning and Manufacturing
	/// Description: Api: Attribute Depended Values
	/// Version Release: 13.1
	///</summary>
	public partial class ATS040MIResource : M3BaseResourceEndpoint
	{
		public ATS040MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "ATS040MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstDepAttrValue
		/// Description This transaction displays Attribute Value
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FATM">From Attribute model</param>
		/// <param name="m3_TATM">To Attribute Model</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDepAttrValueResponse></returns>
		/// <exception cref="M3Exception<LstDepAttrValueResponse>"></exception>
		public async Task<M3Response<LstDepAttrValueResponse>> LstDepAttrValue(
			string m3_FATM = null, 
			string m3_TATM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDepAttrValue",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FATM))
				request.WithQueryParameter("FATM", m3_FATM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TATM))
				request.WithQueryParameter("TATM", m3_TATM.Trim());

			// Execute the request
			var result = await Execute<LstDepAttrValueResponse>(
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
