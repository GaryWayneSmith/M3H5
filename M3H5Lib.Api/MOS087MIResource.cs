/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MOS087MI;
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
	/// Name: MOS087MI
	/// Component Name: MaintenancePermits
	/// Description: Maintenance permits interface
	/// Version Release: 14.x
	///</summary>
	public partial class MOS087MIResource : M3BaseResourceEndpoint
	{
		public MOS087MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS087MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstPermits
		/// Description List permits
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPermitsResponse></returns>
		/// <exception cref="M3Exception<LstPermitsResponse>"></exception>
		public async Task<M3Response<LstPermitsResponse>> LstPermits(
			string m3_FACI, 
			string m3_MWNO, 
			int? m3_CONO = null, 
			int? m3_OPNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPermits",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("MWNO", m3_MWNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());

			// Execute the request
			var result = await Execute<LstPermitsResponse>(
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
		/// Name RptPermits
		/// Description Report permits
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_ACTS">Task element number (Required)</param>
		/// <param name="m3_MSEQ">Sequence number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_LOCK">Lock identity</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_USID">User</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RptPermits(
			string m3_FACI, 
			string m3_MWNO, 
			int m3_OPNO, 
			int m3_ACTS, 
			int m3_MSEQ, 
			int? m3_CONO = null, 
			string m3_PRNO = null, 
			string m3_LOCK = null, 
			string m3_STAT = null, 
			DateTime? m3_RPDT = null, 
			string m3_USID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RptPermits",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString())
				.WithQueryParameter("ACTS", m3_ACTS.ToString())
				.WithQueryParameter("MSEQ", m3_MSEQ.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LOCK))
				request.WithQueryParameter("LOCK", m3_LOCK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());

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
	}
}
// EOF
