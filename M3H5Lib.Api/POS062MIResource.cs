/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
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
	/// Name: POS062MI
	/// Component Name: ProjectOpenClose
	/// Description: Open/close project interface
	/// Version Release: 12.4
	///</summary>
	public partial class POS062MIResource : M3BaseResourceEndpoint
	{
		public POS062MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "POS062MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name SetStatus
		/// Description Set status on project
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3PROJ">Project number (Required)</param>
		/// <param name="m3ELNO">Project element (Required)</param>
		/// <param name="m3STAT">Project status (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetStatus(
			string m3PROJ, 
			string m3ELNO, 
			string m3STAT, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			int? m3VERS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SetStatus",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PROJ))
				throw new ArgumentNullException(nameof(m3PROJ));
			if (string.IsNullOrWhiteSpace(m3ELNO))
				throw new ArgumentNullException(nameof(m3ELNO));
			if (string.IsNullOrWhiteSpace(m3STAT))
				throw new ArgumentNullException(nameof(m3STAT));

			// Set mandatory parameters
			request
				.WithQueryParameter("PROJ", m3PROJ.Trim())
				.WithQueryParameter("ELNO", m3ELNO.Trim())
				.WithQueryParameter("STAT", m3STAT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3VERS.HasValue)
				request.WithQueryParameter("VERS", m3VERS.Value.ToString(CultureInfo.CurrentCulture));

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
