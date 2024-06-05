/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3TRDT">Transaction date (Required)</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3CHL1">Business chain - level 1</param>
		/// <param name="m3CHL2">Business chain - level 2</param>
		/// <param name="m3CHL3">Business chain - level 3</param>
		/// <param name="m3CHL4">Business chain - level 4</param>
		/// <param name="m3LMDT">Change date</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCusMsgResponse></returns>
		/// <exception cref="M3Exception<LstCusMsgResponse>"></exception>
		public async Task<M3Response<LstCusMsgResponse>> LstCusMsg(
			DateTime m3TRDT, 
			string m3CUNO = null, 
			string m3CHL1 = null, 
			string m3CHL2 = null, 
			string m3CHL3 = null, 
			string m3CHL4 = null, 
			DateTime? m3LMDT = null, 
			string m3STAT = null, 
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
				.WithQueryParameter("TRDT", m3TRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHL1))
				request.WithQueryParameter("CHL1", m3CHL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHL2))
				request.WithQueryParameter("CHL2", m3CHL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHL3))
				request.WithQueryParameter("CHL3", m3CHL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHL4))
				request.WithQueryParameter("CHL4", m3CHL4.Trim());
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());

			// Execute the request
			var result = await Execute<LstCusMsgResponse>(
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
