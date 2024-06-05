/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAdvSelection
		/// Description Add advanced selection
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3REPO">Ad-hoc report (Required)</param>
		/// <param name="m3REPV">Ad-hoc report version (Required)</param>
		/// <param name="m3SNNO">Sequence number (Required)</param>
		/// <param name="m3OBJC">Field (Required)</param>
		/// <param name="m3CODI">Condition (Required)</param>
		/// <param name="m3ACTF">Active</param>
		/// <param name="m3VALF">Value field</param>
		/// <param name="m3SEBL">Selection block</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAdvSelection(
			string m3REPO, 
			string m3REPV, 
			int m3SNNO, 
			string m3OBJC, 
			int m3CODI, 
			int? m3ACTF = null, 
			string m3VALF = null, 
			int? m3SEBL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddAdvSelection",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3REPO))
				throw new ArgumentNullException(nameof(m3REPO));
			if (string.IsNullOrWhiteSpace(m3REPV))
				throw new ArgumentNullException(nameof(m3REPV));
			if (string.IsNullOrWhiteSpace(m3OBJC))
				throw new ArgumentNullException(nameof(m3OBJC));

			// Set mandatory parameters
			request
				.WithQueryParameter("REPO", m3REPO.Trim())
				.WithQueryParameter("REPV", m3REPV.Trim())
				.WithQueryParameter("SNNO", m3SNNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OBJC", m3OBJC.Trim())
				.WithQueryParameter("CODI", m3CODI.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3ACTF.HasValue)
				request.WithQueryParameter("ACTF", m3ACTF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3VALF))
				request.WithQueryParameter("VALF", m3VALF.Trim());
			if (m3SEBL.HasValue)
				request.WithQueryParameter("SEBL", m3SEBL.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelAdvSelection
		/// Description Delete advanced selection
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3REPO">Ad-hoc report (Required)</param>
		/// <param name="m3REPV">Ad-hoc report version (Required)</param>
		/// <param name="m3SNNO">Sequence number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAdvSelection(
			string m3REPO, 
			string m3REPV, 
			int m3SNNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelAdvSelection",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3REPO))
				throw new ArgumentNullException(nameof(m3REPO));
			if (string.IsNullOrWhiteSpace(m3REPV))
				throw new ArgumentNullException(nameof(m3REPV));

			// Set mandatory parameters
			request
				.WithQueryParameter("REPO", m3REPO.Trim())
				.WithQueryParameter("REPV", m3REPV.Trim())
				.WithQueryParameter("SNNO", m3SNNO.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetAdvSelection
		/// Description Get advanced selection
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3REPO">Ad-hoc report (Required)</param>
		/// <param name="m3REPV">Ad-hoc report version (Required)</param>
		/// <param name="m3SNNO">Sequence number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAdvSelectionResponse></returns>
		/// <exception cref="M3Exception<GetAdvSelectionResponse>"></exception>
		public async Task<M3Response<GetAdvSelectionResponse>> GetAdvSelection(
			string m3REPO, 
			string m3REPV, 
			int m3SNNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetAdvSelection",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3REPO))
				throw new ArgumentNullException(nameof(m3REPO));
			if (string.IsNullOrWhiteSpace(m3REPV))
				throw new ArgumentNullException(nameof(m3REPV));

			// Set mandatory parameters
			request
				.WithQueryParameter("REPO", m3REPO.Trim())
				.WithQueryParameter("REPV", m3REPV.Trim())
				.WithQueryParameter("SNNO", m3SNNO.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetAdvSelectionResponse>(
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
		/// Name LstAdvSelection
		/// Description List advanced selection
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3REPO">Ad-hoc report</param>
		/// <param name="m3REPV">Ad-hoc report version</param>
		/// <param name="m3SNNO">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAdvSelectionResponse></returns>
		/// <exception cref="M3Exception<LstAdvSelectionResponse>"></exception>
		public async Task<M3Response<LstAdvSelectionResponse>> LstAdvSelection(
			string m3REPO = null, 
			string m3REPV = null, 
			int? m3SNNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAdvSelection",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3REPO))
				request.WithQueryParameter("REPO", m3REPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3REPV))
				request.WithQueryParameter("REPV", m3REPV.Trim());
			if (m3SNNO.HasValue)
				request.WithQueryParameter("SNNO", m3SNNO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAdvSelectionResponse>(
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
		/// Name UpdAdvSelection
		/// Description Update advanced selection
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3REPO">Ad-hoc report (Required)</param>
		/// <param name="m3REPV">Ad-hoc report version (Required)</param>
		/// <param name="m3SNNO">Sequence number (Required)</param>
		/// <param name="m3OBJC">Field (Required)</param>
		/// <param name="m3CODI">Condition (Required)</param>
		/// <param name="m3ACTF">Active</param>
		/// <param name="m3VALF">Value field</param>
		/// <param name="m3SEBL">Selection block</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAdvSelection(
			string m3REPO, 
			string m3REPV, 
			int m3SNNO, 
			string m3OBJC, 
			int m3CODI, 
			int? m3ACTF = null, 
			string m3VALF = null, 
			int? m3SEBL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdAdvSelection",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3REPO))
				throw new ArgumentNullException(nameof(m3REPO));
			if (string.IsNullOrWhiteSpace(m3REPV))
				throw new ArgumentNullException(nameof(m3REPV));
			if (string.IsNullOrWhiteSpace(m3OBJC))
				throw new ArgumentNullException(nameof(m3OBJC));

			// Set mandatory parameters
			request
				.WithQueryParameter("REPO", m3REPO.Trim())
				.WithQueryParameter("REPV", m3REPV.Trim())
				.WithQueryParameter("SNNO", m3SNNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OBJC", m3OBJC.Trim())
				.WithQueryParameter("CODI", m3CODI.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3ACTF.HasValue)
				request.WithQueryParameter("ACTF", m3ACTF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3VALF))
				request.WithQueryParameter("VALF", m3VALF.Trim());
			if (m3SEBL.HasValue)
				request.WithQueryParameter("SEBL", m3SEBL.Value.ToString(CultureInfo.CurrentCulture));

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
