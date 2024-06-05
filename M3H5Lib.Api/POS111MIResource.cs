/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.POS111MI;
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
	/// Name: POS111MI
	/// Component Name: ProjectBudget
	/// Description: Project budget interface
	/// Version Release: 12.3
	///</summary>
	public partial class POS111MIResource : M3BaseResourceEndpoint
	{
		public POS111MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "POS111MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstHead
		/// Description List budget head
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PROJ">Project number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DTUM">Date</param>
		/// <param name="m3KLEN">Key length</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadResponse></returns>
		/// <exception cref="M3Exception<LstHeadResponse>"></exception>
		public async Task<M3Response<LstHeadResponse>> LstHead(
			string m3DIVI, 
			string m3PROJ, 
			int m3VERS, 
			int? m3CONO = null, 
			DateTime? m3DTUM = null, 
			string m3KLEN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PROJ))
				throw new ArgumentNullException(nameof(m3PROJ));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PROJ", m3PROJ.Trim())
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTUM.HasValue)
				request.WithQueryParameter("DTUM", m3DTUM.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3KLEN))
				request.WithQueryParameter("KLEN", m3KLEN.Trim());

			// Execute the request
			var result = await Execute<LstHeadResponse>(
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
		/// Name LstTotal1
		/// Description List totals. Order by project element, budget item
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PROJ">Project number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3CHDA">Change date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3IDEN">Budget item ID</param>
		/// <param name="m3KLEN">Key length</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTotal1Response></returns>
		/// <exception cref="M3Exception<LstTotal1Response>"></exception>
		public async Task<M3Response<LstTotal1Response>> LstTotal1(
			string m3DIVI, 
			string m3PROJ, 
			int m3VERS, 
			DateTime m3CHDA, 
			int? m3CONO = null, 
			string m3ELNO = null, 
			string m3IDEN = null, 
			string m3KLEN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTotal1",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PROJ))
				throw new ArgumentNullException(nameof(m3PROJ));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PROJ", m3PROJ.Trim())
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CHDA", m3CHDA.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3IDEN))
				request.WithQueryParameter("IDEN", m3IDEN.Trim());
			if (!string.IsNullOrWhiteSpace(m3KLEN))
				request.WithQueryParameter("KLEN", m3KLEN.Trim());

			// Execute the request
			var result = await Execute<LstTotal1Response>(
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
