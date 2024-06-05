/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddReportGroup
		/// Description Add report group
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3REPO">Ad-hoc report (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3ARLI">Archiving library</param>
		/// <param name="m3SNDU">Single division used</param>
		/// <param name="m3ACGR">Object access group</param>
		/// <param name="m3APLI">Application area</param>
		/// <param name="m3MXNY">Maximum number of records</param>
		/// <param name="m3ADRP">Advanced report</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddReportGroup(
			string m3REPO, 
			string m3TX40, 
			string m3FILE, 
			string m3TX15 = null, 
			string m3ARLI = null, 
			int? m3SNDU = null, 
			string m3ACGR = null, 
			string m3APLI = null, 
			int? m3MXNY = null, 
			int? m3ADRP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddReportGroup",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3REPO))
				throw new ArgumentNullException(nameof(m3REPO));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));

			// Set mandatory parameters
			request
				.WithQueryParameter("REPO", m3REPO.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARLI))
				request.WithQueryParameter("ARLI", m3ARLI.Trim());
			if (m3SNDU.HasValue)
				request.WithQueryParameter("SNDU", m3SNDU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACGR))
				request.WithQueryParameter("ACGR", m3ACGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3APLI))
				request.WithQueryParameter("APLI", m3APLI.Trim());
			if (m3MXNY.HasValue)
				request.WithQueryParameter("MXNY", m3MXNY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADRP.HasValue)
				request.WithQueryParameter("ADRP", m3ADRP.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelReportGroup
		/// Description Delete report group
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3REPO">Ad-hoc report (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelReportGroup(
			string m3REPO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelReportGroup",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3REPO))
				throw new ArgumentNullException(nameof(m3REPO));

			// Set mandatory parameters
			request
				.WithQueryParameter("REPO", m3REPO.Trim());

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
		/// Name GetReportGroup
		/// Description Get report group
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3REPO">Ad-hoc report (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetReportGroupResponse></returns>
		/// <exception cref="M3Exception<GetReportGroupResponse>"></exception>
		public async Task<M3Response<GetReportGroupResponse>> GetReportGroup(
			string m3REPO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetReportGroup",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3REPO))
				throw new ArgumentNullException(nameof(m3REPO));

			// Set mandatory parameters
			request
				.WithQueryParameter("REPO", m3REPO.Trim());

			// Execute the request
			var result = await Execute<GetReportGroupResponse>(
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
		/// Name ImportRepGroup
		/// Description Import report group
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3REPO">Ad-hoc report</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3FILE">File</param>
		/// <param name="m3ARLI">Archiving library</param>
		/// <param name="m3SNDU">Single division used</param>
		/// <param name="m3ACGR">Object access group</param>
		/// <param name="m3APLI">Application area</param>
		/// <param name="m3MXNY">Maximum number of records</param>
		/// <param name="m3ADRP">Advanced report</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ImportRepGroup(
			string m3REPO = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3FILE = null, 
			string m3ARLI = null, 
			int? m3SNDU = null, 
			string m3ACGR = null, 
			string m3APLI = null, 
			int? m3MXNY = null, 
			int? m3ADRP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ImportRepGroup",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3REPO))
				request.WithQueryParameter("REPO", m3REPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARLI))
				request.WithQueryParameter("ARLI", m3ARLI.Trim());
			if (m3SNDU.HasValue)
				request.WithQueryParameter("SNDU", m3SNDU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACGR))
				request.WithQueryParameter("ACGR", m3ACGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3APLI))
				request.WithQueryParameter("APLI", m3APLI.Trim());
			if (m3MXNY.HasValue)
				request.WithQueryParameter("MXNY", m3MXNY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADRP.HasValue)
				request.WithQueryParameter("ADRP", m3ADRP.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name LstReportGroup
		/// Description List data for report group
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3REPO">Ad-hoc report</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstReportGroupResponse></returns>
		/// <exception cref="M3Exception<LstReportGroupResponse>"></exception>
		public async Task<M3Response<LstReportGroupResponse>> LstReportGroup(
			string m3REPO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstReportGroup",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3REPO))
				request.WithQueryParameter("REPO", m3REPO.Trim());

			// Execute the request
			var result = await Execute<LstReportGroupResponse>(
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
		/// Name UpdReportGroup
		/// Description Update report group
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3REPO">Ad-hoc report</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3FILE">File</param>
		/// <param name="m3ARLI">Archiving library</param>
		/// <param name="m3SNDU">Single division used</param>
		/// <param name="m3ACGR">Object access group</param>
		/// <param name="m3APLI">Application area</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdReportGroup(
			string m3REPO = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3FILE = null, 
			string m3ARLI = null, 
			int? m3SNDU = null, 
			string m3ACGR = null, 
			string m3APLI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdReportGroup",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3REPO))
				request.WithQueryParameter("REPO", m3REPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARLI))
				request.WithQueryParameter("ARLI", m3ARLI.Trim());
			if (m3SNDU.HasValue)
				request.WithQueryParameter("SNDU", m3SNDU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACGR))
				request.WithQueryParameter("ACGR", m3ACGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3APLI))
				request.WithQueryParameter("APLI", m3APLI.Trim());

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
	}
}
// EOF
