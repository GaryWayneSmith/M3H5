/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.MNS096MI;
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
	/// Name: MNS096MI
	/// Component Name: IEP
	/// Description: Api: IEP interface
	/// Version Release: 15.0
	///</summary>
	public partial class MNS096MIResource : M3BaseResourceEndpoint
	{
		public MNS096MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MNS096MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetIEPStatus
		/// Description Get status for IEP business functionality
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3LEPB">Lep business function (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetIEPStatusResponse></returns>
		/// <exception cref="M3Exception<GetIEPStatusResponse>"></exception>
		public async Task<M3Response<GetIEPStatusResponse>> GetIEPStatus(
			string m3LEPB, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetIEPStatus",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3LEPB))
				throw new ArgumentNullException(nameof(m3LEPB));

			// Set mandatory parameters
			request
				.WithQueryParameter("LEPB", m3LEPB.Trim());

			// Execute the request
			var result = await Execute<GetIEPStatusResponse>(
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
		/// Name LstIEPStatus
		/// Description List all IEP functionality
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3LEPB">Lep business function</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstIEPStatusResponse></returns>
		/// <exception cref="M3Exception<LstIEPStatusResponse>"></exception>
		public async Task<M3Response<LstIEPStatusResponse>> LstIEPStatus(
			string m3LEPB = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstIEPStatus",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3LEPB))
				request.WithQueryParameter("LEPB", m3LEPB.Trim());

			// Execute the request
			var result = await Execute<LstIEPStatusResponse>(
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
