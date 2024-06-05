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
	/// Name: QUS050MI
	/// Component Name: Attribute
	/// Description: Quick add of attribute
	/// Version Release: 5e90
	///</summary>
	public partial class QUS050MIResource : M3BaseResourceEndpoint
	{
		public QUS050MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QUS050MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name QuickAddAttrib
		/// Description Quick add of attribute
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3ATTE">Attribute template (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3ATID">Attribute identity (Required)</param>
		/// <param name="m3ATVA">Attribute value (Required)</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3TX30">Text</param>
		/// <param name="m3ANSQ">Attribute sequence number</param>
		/// <param name="m3DSPG">Display group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> QuickAddAttrib(
			string m3ATTE, 
			string m3ITNO, 
			string m3ATID, 
			string m3ATVA, 
			string m3ITDS = null, 
			string m3TX30 = null, 
			int? m3ANSQ = null, 
			string m3DSPG = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/QuickAddAttrib",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ATTE))
				throw new ArgumentNullException(nameof(m3ATTE));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3ATID))
				throw new ArgumentNullException(nameof(m3ATID));
			if (string.IsNullOrWhiteSpace(m3ATVA))
				throw new ArgumentNullException(nameof(m3ATVA));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATTE", m3ATTE.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("ATID", m3ATID.Trim())
				.WithQueryParameter("ATVA", m3ATVA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX30))
				request.WithQueryParameter("TX30", m3TX30.Trim());
			if (m3ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3ANSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DSPG))
				request.WithQueryParameter("DSPG", m3DSPG.Trim());

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
