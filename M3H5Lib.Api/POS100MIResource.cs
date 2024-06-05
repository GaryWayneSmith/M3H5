/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PROJ">Project number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3POSI">Position number</param>
		/// <param name="m3ELST">Element status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstElement1Response></returns>
		/// <exception cref="M3Exception<LstElement1Response>"></exception>
		public async Task<M3Response<LstElement1Response>> LstElement1(
			string m3DIVI, 
			string m3PROJ, 
			int m3VERS, 
			int? m3CONO = null, 
			long? m3POSI = null, 
			string m3ELST = null, 
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
			if (m3POSI.HasValue)
				request.WithQueryParameter("POSI", m3POSI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ELST))
				request.WithQueryParameter("ELST", m3ELST.Trim());

			// Execute the request
			var result = await Execute<LstElement1Response>(
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
		/// Name LstTextPerElem
		/// Description List text per element
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PROJ">Project number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3ELNO">Project element (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TXVR">Text block</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3LINO">Line number</param>
		/// <param name="m3KLEN">Key length</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTextPerElemResponse></returns>
		/// <exception cref="M3Exception<LstTextPerElemResponse>"></exception>
		public async Task<M3Response<LstTextPerElemResponse>> LstTextPerElem(
			string m3DIVI, 
			string m3PROJ, 
			int m3VERS, 
			string m3ELNO, 
			int? m3CONO = null, 
			string m3TXVR = null, 
			string m3LNCD = null, 
			int? m3LINO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTextPerElem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PROJ))
				throw new ArgumentNullException(nameof(m3PROJ));
			if (string.IsNullOrWhiteSpace(m3ELNO))
				throw new ArgumentNullException(nameof(m3ELNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PROJ", m3PROJ.Trim())
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ELNO", m3ELNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TXVR))
				request.WithQueryParameter("TXVR", m3TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (m3LINO.HasValue)
				request.WithQueryParameter("LINO", m3LINO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3KLEN))
				request.WithQueryParameter("KLEN", m3KLEN.Trim());

			// Execute the request
			var result = await Execute<LstTextPerElemResponse>(
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
