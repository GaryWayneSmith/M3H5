/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PROJ">Project number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DTUM">Date</param>
		/// <param name="m3_KLEN">Key length</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadResponse></returns>
		/// <exception cref="M3Exception<LstHeadResponse>"></exception>
		public async Task<M3Response<LstHeadResponse>> LstHead(
			string m3_DIVI, 
			string m3_PROJ, 
			int m3_VERS, 
			int? m3_CONO = null, 
			DateTime? m3_DTUM = null, 
			string m3_KLEN = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PROJ))
				throw new ArgumentNullException("m3_PROJ");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PROJ", m3_PROJ.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_DTUM.HasValue)
				request.WithQueryParameter("DTUM", m3_DTUM.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_KLEN))
				request.WithQueryParameter("KLEN", m3_KLEN.Trim());

			// Execute the request
			var result = await Execute<LstHeadResponse>(
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
		/// Name LstTotal1
		/// Description List totals. Order by project element, budget item
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PROJ">Project number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_CHDA">Change date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_IDEN">Budget item ID</param>
		/// <param name="m3_KLEN">Key length</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTotal1Response></returns>
		/// <exception cref="M3Exception<LstTotal1Response>"></exception>
		public async Task<M3Response<LstTotal1Response>> LstTotal1(
			string m3_DIVI, 
			string m3_PROJ, 
			int m3_VERS, 
			DateTime m3_CHDA, 
			int? m3_CONO = null, 
			string m3_ELNO = null, 
			string m3_IDEN = null, 
			string m3_KLEN = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PROJ))
				throw new ArgumentNullException("m3_PROJ");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PROJ", m3_PROJ.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString())
				.WithQueryParameter("CHDA", m3_CHDA.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IDEN))
				request.WithQueryParameter("IDEN", m3_IDEN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KLEN))
				request.WithQueryParameter("KLEN", m3_KLEN.Trim());

			// Execute the request
			var result = await Execute<LstTotal1Response>(
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
