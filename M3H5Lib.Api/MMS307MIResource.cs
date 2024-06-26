/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.MMS307MI;
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
	/// Name: MMS307MI
	/// Component Name: PhysicalInventory
	/// Description: Physical Inventory Variance
	/// Version Release: 14.x
	///</summary>
	public partial class MMS307MIResource : M3BaseResourceEndpoint
	{
		public MMS307MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS307MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetPhysInvVar
		/// Description Get Physcial Inventory Variance record
		/// Version Release: 15
		/// </summary>
		/// <param name="m3STNB">Physical inventory number (Required)</param>
		/// <param name="m3STRN">Physical inventory line (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPhysInvVarResponse></returns>
		/// <exception cref="M3Exception<GetPhysInvVarResponse>"></exception>
		public async Task<M3Response<GetPhysInvVarResponse>> GetPhysInvVar(
			long m3STNB, 
			int m3STRN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetPhysInvVar",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("STNB", m3STNB.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STRN", m3STRN.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetPhysInvVarResponse>(
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
		/// Name LstPhysInvVar
		/// Description List Physcial Inventory Variance records
		/// Version Release: 15
		/// </summary>
		/// <param name="m3STNB">Physical inventory number (Required)</param>
		/// <param name="m3STRN">Physical inventory line</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPhysInvVarResponse></returns>
		/// <exception cref="M3Exception<LstPhysInvVarResponse>"></exception>
		public async Task<M3Response<LstPhysInvVarResponse>> LstPhysInvVar(
			long m3STNB, 
			int? m3STRN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPhysInvVar",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("STNB", m3STNB.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3STRN.HasValue)
				request.WithQueryParameter("STRN", m3STRN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPhysInvVarResponse>(
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
