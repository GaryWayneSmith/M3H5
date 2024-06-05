/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstNodeRelation
		/// Description Transfer Planning Node Distribution relation data
		/// Version Release: 12.6
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FPND">From Planning Node</param>
		/// <param name="m3_TPND">To Planning Node</param>
		/// <param name="m3_DDMT">Default distribution method</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstNodeRelationResponse></returns>
		/// <exception cref="M3Exception<LstNodeRelationResponse>"></exception>
		public async Task<M3Response<LstNodeRelationResponse>> LstNodeRelation(
			int? m3_CONO = null, 
			string m3_FPND = null, 
			string m3_TPND = null, 
			int? m3_DDMT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstNodeRelation",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FPND))
				request.WithQueryParameter("FPND", m3_FPND.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TPND))
				request.WithQueryParameter("TPND", m3_TPND.Trim());
			if (m3_DDMT.HasValue)
				request.WithQueryParameter("DDMT", m3_DDMT.Value.ToString());

			// Execute the request
			var result = await Execute<LstNodeRelationResponse>(
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
		/// Name LstRelation
		/// Description Transfer Distribution relation data from Movex BE
		/// Version Release: 12.6
		/// </summary>
		/// <param name="m3_RLTY">Relation Type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FWLO">From Warehouse</param>
		/// <param name="m3_TWLO">To Warehouse</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRelationResponse></returns>
		/// <exception cref="M3Exception<LstRelationResponse>"></exception>
		public async Task<M3Response<LstRelationResponse>> LstRelation(
			int m3_RLTY, 
			int? m3_CONO = null, 
			string m3_FWLO = null, 
			string m3_TWLO = null, 
			string m3_WHGR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstRelation",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("RLTY", m3_RLTY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FWLO))
				request.WithQueryParameter("FWLO", m3_FWLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWLO))
				request.WithQueryParameter("TWLO", m3_TWLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());

			// Execute the request
			var result = await Execute<LstRelationResponse>(
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
