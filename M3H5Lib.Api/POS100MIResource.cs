/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.POS100MI;
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
	/// Name: POS100MI
	/// Component Name: ProjectStructure
	/// Description: Project structure interface
	/// Version Release: 12.3
	///</summary>
	public partial class POS100MIResource : M3BaseResourceEndpoint
	{
		public POS100MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "POS100MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstElement1
		/// Description List elements in project. Order by position in structure
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PROJ">Project number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_POSI">Position number</param>
		/// <param name="m3_ELST">Element status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstElement1Response></returns>
		/// <exception cref="M3Exception<LstElement1Response>"></exception>
		public async Task<M3Response<LstElement1Response>> LstElement1(
			string m3_DIVI, 
			string m3_PROJ, 
			int m3_VERS, 
			int? m3_CONO = null, 
			long? m3_POSI = null, 
			string m3_ELST = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstElement1",
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
			if (m3_POSI.HasValue)
				request.WithQueryParameter("POSI", m3_POSI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ELST))
				request.WithQueryParameter("ELST", m3_ELST.Trim());

			// Execute the request
			var result = await Execute<LstElement1Response>(
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
		/// Name LstTextPerElem
		/// Description List text per element
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PROJ">Project number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_ELNO">Project element (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TXVR">Text block</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_LINO">Line number</param>
		/// <param name="m3_KLEN">Key length</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTextPerElemResponse></returns>
		/// <exception cref="M3Exception<LstTextPerElemResponse>"></exception>
		public async Task<M3Response<LstTextPerElemResponse>> LstTextPerElem(
			string m3_DIVI, 
			string m3_PROJ, 
			int m3_VERS, 
			string m3_ELNO, 
			int? m3_CONO = null, 
			string m3_TXVR = null, 
			string m3_LNCD = null, 
			int? m3_LINO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTextPerElem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PROJ))
				throw new ArgumentNullException("m3_PROJ");
			if (string.IsNullOrWhiteSpace(m3_ELNO))
				throw new ArgumentNullException("m3_ELNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PROJ", m3_PROJ.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString())
				.WithQueryParameter("ELNO", m3_ELNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TXVR))
				request.WithQueryParameter("TXVR", m3_TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (m3_LINO.HasValue)
				request.WithQueryParameter("LINO", m3_LINO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_KLEN))
				request.WithQueryParameter("KLEN", m3_KLEN.Trim());

			// Execute the request
			var result = await Execute<LstTextPerElemResponse>(
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
