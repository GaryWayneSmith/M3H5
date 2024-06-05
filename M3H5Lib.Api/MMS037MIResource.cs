/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.MMS037MI;
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
	/// Name: MMS037MI
	/// Component Name: Wrk: Planning Policy
	/// Description: Planning Policy
	/// Version Release: 5ea0
	///</summary>
	public partial class MMS037MIResource : M3BaseResourceEndpoint
	{
		public MMS037MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS037MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstPlanPolicy
		/// Description Lists Planning Policy
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3PLCD">Planning policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPlanPolicyResponse></returns>
		/// <exception cref="M3Exception<LstPlanPolicyResponse>"></exception>
		public async Task<M3Response<LstPlanPolicyResponse>> LstPlanPolicy(
			string m3PLCD = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPlanPolicy",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PLCD))
				request.WithQueryParameter("PLCD", m3PLCD.Trim());

			// Execute the request
			var result = await Execute<LstPlanPolicyResponse>(
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
