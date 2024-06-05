/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.DPS001MI;
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
	/// Name: DPS001MI
	/// Component Name: Distribution relations
	/// Description: Distribution relation interface
	/// Version Release: 12.6
	///</summary>
	public partial class DPS001MIResource : M3BaseResourceEndpoint
	{
		public DPS001MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "DPS001MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstNodeRelation
		/// Description Transfer Planning Node Distribution relation data
		/// Version Release: 12.6
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FPND">From Planning Node</param>
		/// <param name="m3TPND">To Planning Node</param>
		/// <param name="m3DDMT">Default distribution method</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstNodeRelationResponse></returns>
		/// <exception cref="M3Exception<LstNodeRelationResponse>"></exception>
		public async Task<M3Response<LstNodeRelationResponse>> LstNodeRelation(
			int? m3CONO = null, 
			string m3FPND = null, 
			string m3TPND = null, 
			int? m3DDMT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstNodeRelation",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FPND))
				request.WithQueryParameter("FPND", m3FPND.Trim());
			if (!string.IsNullOrWhiteSpace(m3TPND))
				request.WithQueryParameter("TPND", m3TPND.Trim());
			if (m3DDMT.HasValue)
				request.WithQueryParameter("DDMT", m3DDMT.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstNodeRelationResponse>(
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
		/// Name LstRelation
		/// Description Transfer Distribution relation data from Movex BE
		/// Version Release: 12.6
		/// </summary>
		/// <param name="m3RLTY">Relation Type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FWLO">From Warehouse</param>
		/// <param name="m3TWLO">To Warehouse</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRelationResponse></returns>
		/// <exception cref="M3Exception<LstRelationResponse>"></exception>
		public async Task<M3Response<LstRelationResponse>> LstRelation(
			int m3RLTY, 
			int? m3CONO = null, 
			string m3FWLO = null, 
			string m3TWLO = null, 
			string m3WHGR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstRelation",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("RLTY", m3RLTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FWLO))
				request.WithQueryParameter("FWLO", m3FWLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWLO))
				request.WithQueryParameter("TWLO", m3TWLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());

			// Execute the request
			var result = await Execute<LstRelationResponse>(
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
