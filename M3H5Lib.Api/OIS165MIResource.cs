/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.OIS165MI;
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
	/// Name: OIS165MI
	/// Component Name: CustomerOrderInquiry
	/// Description: Order Entry Messages
	/// Version Release: 13.1
	///</summary>
	public partial class OIS165MIResource : M3BaseResourceEndpoint
	{
		public OIS165MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS165MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstCusMsg
		/// Description List customer messages
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_TRDT">Transaction date (Required)</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_CHL1">Business chain - level 1</param>
		/// <param name="m3_CHL2">Business chain - level 2</param>
		/// <param name="m3_CHL3">Business chain - level 3</param>
		/// <param name="m3_CHL4">Business chain - level 4</param>
		/// <param name="m3_LMDT">Change date</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCusMsgResponse></returns>
		/// <exception cref="M3Exception<LstCusMsgResponse>"></exception>
		public async Task<M3Response<LstCusMsgResponse>> LstCusMsg(
			DateTime m3_TRDT, 
			string m3_CUNO = null, 
			string m3_CHL1 = null, 
			string m3_CHL2 = null, 
			string m3_CHL3 = null, 
			string m3_CHL4 = null, 
			DateTime? m3_LMDT = null, 
			string m3_STAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCusMsg",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("TRDT", m3_TRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHL1))
				request.WithQueryParameter("CHL1", m3_CHL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHL2))
				request.WithQueryParameter("CHL2", m3_CHL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHL3))
				request.WithQueryParameter("CHL3", m3_CHL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHL4))
				request.WithQueryParameter("CHL4", m3_CHL4.Trim());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());

			// Execute the request
			var result = await Execute<LstCusMsgResponse>(
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
