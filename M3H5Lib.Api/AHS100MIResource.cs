/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.AHS100MI;
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
	/// Name: AHS100MI
	/// Component Name: Ad-hoc Report
	/// Description: Api: Ad-hoc report group
	/// Version Release: 15.0
	///</summary>
	public partial class AHS100MIResource : M3BaseResourceEndpoint
	{
		public AHS100MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "AHS100MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddReportGroup
		/// Description Add report group
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_REPO">Ad-hoc report (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_ARLI">Archiving library</param>
		/// <param name="m3_SNDU">Single division used</param>
		/// <param name="m3_ACGR">Object access group</param>
		/// <param name="m3_APLI">Application area</param>
		/// <param name="m3_MXNY">Maximum number of records</param>
		/// <param name="m3_ADRP">Advanced report</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddReportGroup(
			string m3_REPO, 
			string m3_TX40, 
			string m3_FILE, 
			string m3_TX15 = null, 
			string m3_ARLI = null, 
			int? m3_SNDU = null, 
			string m3_ACGR = null, 
			string m3_APLI = null, 
			int? m3_MXNY = null, 
			int? m3_ADRP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddReportGroup",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_REPO))
				throw new ArgumentNullException("m3_REPO");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");

			// Set mandatory parameters
			request
				.WithQueryParameter("REPO", m3_REPO.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARLI))
				request.WithQueryParameter("ARLI", m3_ARLI.Trim());
			if (m3_SNDU.HasValue)
				request.WithQueryParameter("SNDU", m3_SNDU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACGR))
				request.WithQueryParameter("ACGR", m3_ACGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APLI))
				request.WithQueryParameter("APLI", m3_APLI.Trim());
			if (m3_MXNY.HasValue)
				request.WithQueryParameter("MXNY", m3_MXNY.Value.ToString());
			if (m3_ADRP.HasValue)
				request.WithQueryParameter("ADRP", m3_ADRP.Value.ToString());

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
		/// Name DelReportGroup
		/// Description Delete report group
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_REPO">Ad-hoc report (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelReportGroup(
			string m3_REPO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelReportGroup",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_REPO))
				throw new ArgumentNullException("m3_REPO");

			// Set mandatory parameters
			request
				.WithQueryParameter("REPO", m3_REPO.Trim());

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
		/// Name GetReportGroup
		/// Description Get report group
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_REPO">Ad-hoc report (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetReportGroupResponse></returns>
		/// <exception cref="M3Exception<GetReportGroupResponse>"></exception>
		public async Task<M3Response<GetReportGroupResponse>> GetReportGroup(
			string m3_REPO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetReportGroup",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_REPO))
				throw new ArgumentNullException("m3_REPO");

			// Set mandatory parameters
			request
				.WithQueryParameter("REPO", m3_REPO.Trim());

			// Execute the request
			var result = await Execute<GetReportGroupResponse>(
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
		/// Name ImportRepGroup
		/// Description Import report group
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_REPO">Ad-hoc report</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_FILE">File</param>
		/// <param name="m3_ARLI">Archiving library</param>
		/// <param name="m3_SNDU">Single division used</param>
		/// <param name="m3_ACGR">Object access group</param>
		/// <param name="m3_APLI">Application area</param>
		/// <param name="m3_MXNY">Maximum number of records</param>
		/// <param name="m3_ADRP">Advanced report</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ImportRepGroup(
			string m3_REPO = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_FILE = null, 
			string m3_ARLI = null, 
			int? m3_SNDU = null, 
			string m3_ACGR = null, 
			string m3_APLI = null, 
			int? m3_MXNY = null, 
			int? m3_ADRP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ImportRepGroup",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_REPO))
				request.WithQueryParameter("REPO", m3_REPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARLI))
				request.WithQueryParameter("ARLI", m3_ARLI.Trim());
			if (m3_SNDU.HasValue)
				request.WithQueryParameter("SNDU", m3_SNDU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACGR))
				request.WithQueryParameter("ACGR", m3_ACGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APLI))
				request.WithQueryParameter("APLI", m3_APLI.Trim());
			if (m3_MXNY.HasValue)
				request.WithQueryParameter("MXNY", m3_MXNY.Value.ToString());
			if (m3_ADRP.HasValue)
				request.WithQueryParameter("ADRP", m3_ADRP.Value.ToString());

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
		/// Name LstReportGroup
		/// Description List data for report group
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_REPO">Ad-hoc report</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstReportGroupResponse></returns>
		/// <exception cref="M3Exception<LstReportGroupResponse>"></exception>
		public async Task<M3Response<LstReportGroupResponse>> LstReportGroup(
			string m3_REPO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstReportGroup",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_REPO))
				request.WithQueryParameter("REPO", m3_REPO.Trim());

			// Execute the request
			var result = await Execute<LstReportGroupResponse>(
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
		/// Name UpdReportGroup
		/// Description Update report group
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_REPO">Ad-hoc report</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_FILE">File</param>
		/// <param name="m3_ARLI">Archiving library</param>
		/// <param name="m3_SNDU">Single division used</param>
		/// <param name="m3_ACGR">Object access group</param>
		/// <param name="m3_APLI">Application area</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdReportGroup(
			string m3_REPO = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_FILE = null, 
			string m3_ARLI = null, 
			int? m3_SNDU = null, 
			string m3_ACGR = null, 
			string m3_APLI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdReportGroup",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_REPO))
				request.WithQueryParameter("REPO", m3_REPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARLI))
				request.WithQueryParameter("ARLI", m3_ARLI.Trim());
			if (m3_SNDU.HasValue)
				request.WithQueryParameter("SNDU", m3_SNDU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACGR))
				request.WithQueryParameter("ACGR", m3_ACGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APLI))
				request.WithQueryParameter("APLI", m3_APLI.Trim());

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
