/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name CrtReqLines
		/// Description Create Request Lines
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3STNB">Physical inventory number (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3FWHS">From location</param>
		/// <param name="m3TWHS">Location</param>
		/// <param name="m3ITAB">Item selection table</param>
		/// <param name="m3FNDT">From latest physical inventory date</param>
		/// <param name="m3TNDT">To latest physical inventory date</param>
		/// <param name="m3FSLT">From stock zone</param>
		/// <param name="m3TSLT">To stock zone</param>
		/// <param name="m3REN0">First count</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CrtReqLines(
			long m3STNB, 
			string m3WHLO, 
			string m3FWHS = null, 
			string m3TWHS = null, 
			string m3ITAB = null, 
			DateTime? m3FNDT = null, 
			DateTime? m3TNDT = null, 
			string m3FSLT = null, 
			string m3TSLT = null, 
			int? m3REN0 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CrtReqLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("STNB", m3STNB.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FWHS))
				request.WithQueryParameter("FWHS", m3FWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWHS))
				request.WithQueryParameter("TWHS", m3TWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITAB))
				request.WithQueryParameter("ITAB", m3ITAB.Trim());
			if (m3FNDT.HasValue)
				request.WithQueryParameter("FNDT", m3FNDT.Value.ToM3String());
			if (m3TNDT.HasValue)
				request.WithQueryParameter("TNDT", m3TNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3FSLT))
				request.WithQueryParameter("FSLT", m3FSLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSLT))
				request.WithQueryParameter("TSLT", m3TSLT.Trim());
			if (m3REN0.HasValue)
				request.WithQueryParameter("REN0", m3REN0.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<M3Record>(
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
		/// Name LstPhysInvHead
		/// Description List physical inventory head
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3STMD">Physical inventory method (Required)</param>
		/// <param name="m3RENU">Recount number (Required)</param>
		/// <param name="m3STAG">Status - physical inventory (Required)</param>
		/// <param name="m3LVPS">Reporting level (Required)</param>
		/// <param name="m3STNB">Physical inventory number</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3SLTP">Stock zone</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPhysInvHeadResponse></returns>
		/// <exception cref="M3Exception<LstPhysInvHeadResponse>"></exception>
		public async Task<M3Response<LstPhysInvHeadResponse>> LstPhysInvHead(
			string m3WHLO, 
			long m3STMD, 
			long m3RENU, 
			long m3STAG, 
			int m3LVPS, 
			long? m3STNB = null, 
			string m3WHSL = null, 
			string m3SLTP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPhysInvHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("STMD", m3STMD.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RENU", m3RENU.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STAG", m3STAG.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("LVPS", m3LVPS.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3STNB.HasValue)
				request.WithQueryParameter("STNB", m3STNB.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLTP))
				request.WithQueryParameter("SLTP", m3SLTP.Trim());

			// Execute the request
			var result = await Execute<LstPhysInvHeadResponse>(
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
