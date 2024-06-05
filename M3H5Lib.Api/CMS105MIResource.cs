/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CMS105MI;
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
	/// Name: CMS105MI
	/// Component Name: AdvancedSelection
	/// Description: Api: Advanced selection
	/// Version Release: 15.0
	///</summary>
	public partial class CMS105MIResource : M3BaseResourceEndpoint
	{
		public CMS105MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS105MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAdvSelection
		/// Description Add advanced selection
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_REPO">Ad-hoc report (Required)</param>
		/// <param name="m3_REPV">Ad-hoc report version (Required)</param>
		/// <param name="m3_SNNO">Sequence number (Required)</param>
		/// <param name="m3_OBJC">Field (Required)</param>
		/// <param name="m3_CODI">Condition (Required)</param>
		/// <param name="m3_ACTF">Active</param>
		/// <param name="m3_VALF">Value field</param>
		/// <param name="m3_SEBL">Selection block</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAdvSelection(
			string m3_REPO, 
			string m3_REPV, 
			int m3_SNNO, 
			string m3_OBJC, 
			int m3_CODI, 
			int? m3_ACTF = null, 
			string m3_VALF = null, 
			int? m3_SEBL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAdvSelection",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_REPO))
				throw new ArgumentNullException("m3_REPO");
			if (string.IsNullOrWhiteSpace(m3_REPV))
				throw new ArgumentNullException("m3_REPV");
			if (string.IsNullOrWhiteSpace(m3_OBJC))
				throw new ArgumentNullException("m3_OBJC");

			// Set mandatory parameters
			request
				.WithQueryParameter("REPO", m3_REPO.Trim())
				.WithQueryParameter("REPV", m3_REPV.Trim())
				.WithQueryParameter("SNNO", m3_SNNO.ToString())
				.WithQueryParameter("OBJC", m3_OBJC.Trim())
				.WithQueryParameter("CODI", m3_CODI.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_ACTF.HasValue)
				request.WithQueryParameter("ACTF", m3_ACTF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_VALF))
				request.WithQueryParameter("VALF", m3_VALF.Trim());
			if (m3_SEBL.HasValue)
				request.WithQueryParameter("SEBL", m3_SEBL.Value.ToString());

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
		/// Name DelAdvSelection
		/// Description Delete advanced selection
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_REPO">Ad-hoc report (Required)</param>
		/// <param name="m3_REPV">Ad-hoc report version (Required)</param>
		/// <param name="m3_SNNO">Sequence number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAdvSelection(
			string m3_REPO, 
			string m3_REPV, 
			int m3_SNNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelAdvSelection",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_REPO))
				throw new ArgumentNullException("m3_REPO");
			if (string.IsNullOrWhiteSpace(m3_REPV))
				throw new ArgumentNullException("m3_REPV");

			// Set mandatory parameters
			request
				.WithQueryParameter("REPO", m3_REPO.Trim())
				.WithQueryParameter("REPV", m3_REPV.Trim())
				.WithQueryParameter("SNNO", m3_SNNO.ToString());

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
		/// Name GetAdvSelection
		/// Description Get advanced selection
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_REPO">Ad-hoc report (Required)</param>
		/// <param name="m3_REPV">Ad-hoc report version (Required)</param>
		/// <param name="m3_SNNO">Sequence number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAdvSelectionResponse></returns>
		/// <exception cref="M3Exception<GetAdvSelectionResponse>"></exception>
		public async Task<M3Response<GetAdvSelectionResponse>> GetAdvSelection(
			string m3_REPO, 
			string m3_REPV, 
			int m3_SNNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAdvSelection",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_REPO))
				throw new ArgumentNullException("m3_REPO");
			if (string.IsNullOrWhiteSpace(m3_REPV))
				throw new ArgumentNullException("m3_REPV");

			// Set mandatory parameters
			request
				.WithQueryParameter("REPO", m3_REPO.Trim())
				.WithQueryParameter("REPV", m3_REPV.Trim())
				.WithQueryParameter("SNNO", m3_SNNO.ToString());

			// Execute the request
			var result = await Execute<GetAdvSelectionResponse>(
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
		/// Name LstAdvSelection
		/// Description List advanced selection
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_REPO">Ad-hoc report</param>
		/// <param name="m3_REPV">Ad-hoc report version</param>
		/// <param name="m3_SNNO">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAdvSelectionResponse></returns>
		/// <exception cref="M3Exception<LstAdvSelectionResponse>"></exception>
		public async Task<M3Response<LstAdvSelectionResponse>> LstAdvSelection(
			string m3_REPO = null, 
			string m3_REPV = null, 
			int? m3_SNNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAdvSelection",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_REPO))
				request.WithQueryParameter("REPO", m3_REPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REPV))
				request.WithQueryParameter("REPV", m3_REPV.Trim());
			if (m3_SNNO.HasValue)
				request.WithQueryParameter("SNNO", m3_SNNO.Value.ToString());

			// Execute the request
			var result = await Execute<LstAdvSelectionResponse>(
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
		/// Name UpdAdvSelection
		/// Description Update advanced selection
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_REPO">Ad-hoc report (Required)</param>
		/// <param name="m3_REPV">Ad-hoc report version (Required)</param>
		/// <param name="m3_SNNO">Sequence number (Required)</param>
		/// <param name="m3_OBJC">Field (Required)</param>
		/// <param name="m3_CODI">Condition (Required)</param>
		/// <param name="m3_ACTF">Active</param>
		/// <param name="m3_VALF">Value field</param>
		/// <param name="m3_SEBL">Selection block</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAdvSelection(
			string m3_REPO, 
			string m3_REPV, 
			int m3_SNNO, 
			string m3_OBJC, 
			int m3_CODI, 
			int? m3_ACTF = null, 
			string m3_VALF = null, 
			int? m3_SEBL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdAdvSelection",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_REPO))
				throw new ArgumentNullException("m3_REPO");
			if (string.IsNullOrWhiteSpace(m3_REPV))
				throw new ArgumentNullException("m3_REPV");
			if (string.IsNullOrWhiteSpace(m3_OBJC))
				throw new ArgumentNullException("m3_OBJC");

			// Set mandatory parameters
			request
				.WithQueryParameter("REPO", m3_REPO.Trim())
				.WithQueryParameter("REPV", m3_REPV.Trim())
				.WithQueryParameter("SNNO", m3_SNNO.ToString())
				.WithQueryParameter("OBJC", m3_OBJC.Trim())
				.WithQueryParameter("CODI", m3_CODI.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_ACTF.HasValue)
				request.WithQueryParameter("ACTF", m3_ACTF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_VALF))
				request.WithQueryParameter("VALF", m3_VALF.Trim());
			if (m3_SEBL.HasValue)
				request.WithQueryParameter("SEBL", m3_SEBL.Value.ToString());

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
