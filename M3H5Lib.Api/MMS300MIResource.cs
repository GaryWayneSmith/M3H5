/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MMS300MI;
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
	/// Name: MMS300MI
	/// Component Name: Stocktake
	/// Description: Stocktake - head
	/// Version Release: 5ea2
	///</summary>
	public partial class MMS300MIResource : M3BaseResourceEndpoint
	{
		public MMS300MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS300MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name CrtReqLines
		/// Description Create Request Lines
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_STNB">Physical inventory number (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_FWHS">From location</param>
		/// <param name="m3_TWHS">Location</param>
		/// <param name="m3_ITAB">Item selection table</param>
		/// <param name="m3_FNDT">From latest physical inventory date</param>
		/// <param name="m3_TNDT">To latest physical inventory date</param>
		/// <param name="m3_FSLT">From stock zone</param>
		/// <param name="m3_TSLT">To stock zone</param>
		/// <param name="m3_REN0">First count</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CrtReqLines(
			long m3_STNB, 
			string m3_WHLO, 
			string m3_FWHS = null, 
			string m3_TWHS = null, 
			string m3_ITAB = null, 
			DateTime? m3_FNDT = null, 
			DateTime? m3_TNDT = null, 
			string m3_FSLT = null, 
			string m3_TSLT = null, 
			int? m3_REN0 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CrtReqLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("STNB", m3_STNB.ToString())
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FWHS))
				request.WithQueryParameter("FWHS", m3_FWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWHS))
				request.WithQueryParameter("TWHS", m3_TWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITAB))
				request.WithQueryParameter("ITAB", m3_ITAB.Trim());
			if (m3_FNDT.HasValue)
				request.WithQueryParameter("FNDT", m3_FNDT.Value.ToM3String());
			if (m3_TNDT.HasValue)
				request.WithQueryParameter("TNDT", m3_TNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_FSLT))
				request.WithQueryParameter("FSLT", m3_FSLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSLT))
				request.WithQueryParameter("TSLT", m3_TSLT.Trim());
			if (m3_REN0.HasValue)
				request.WithQueryParameter("REN0", m3_REN0.Value.ToString());

			// Execute the request
			var result = await Execute<M3Record>(
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
		/// Name LstPhysInvHead
		/// Description List physical inventory head
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_STMD">Physical inventory method (Required)</param>
		/// <param name="m3_RENU">Recount number (Required)</param>
		/// <param name="m3_STAG">Status - physical inventory (Required)</param>
		/// <param name="m3_LVPS">Reporting level (Required)</param>
		/// <param name="m3_STNB">Physical inventory number</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_SLTP">Stock zone</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPhysInvHeadResponse></returns>
		/// <exception cref="M3Exception<LstPhysInvHeadResponse>"></exception>
		public async Task<M3Response<LstPhysInvHeadResponse>> LstPhysInvHead(
			string m3_WHLO, 
			long m3_STMD, 
			long m3_RENU, 
			long m3_STAG, 
			int m3_LVPS, 
			long? m3_STNB = null, 
			string m3_WHSL = null, 
			string m3_SLTP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPhysInvHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("STMD", m3_STMD.ToString())
				.WithQueryParameter("RENU", m3_RENU.ToString())
				.WithQueryParameter("STAG", m3_STAG.ToString())
				.WithQueryParameter("LVPS", m3_LVPS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_STNB.HasValue)
				request.WithQueryParameter("STNB", m3_STNB.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLTP))
				request.WithQueryParameter("SLTP", m3_SLTP.Trim());

			// Execute the request
			var result = await Execute<LstPhysInvHeadResponse>(
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
