/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name QuickAddAttrib
		/// Description Quick add of attribute
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ATTE">Attribute template (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_ATID">Attribute identity (Required)</param>
		/// <param name="m3_ATVA">Attribute value (Required)</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_TX30">Text</param>
		/// <param name="m3_ANSQ">Attribute sequence number</param>
		/// <param name="m3_DSPG">Display group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> QuickAddAttrib(
			string m3_ATTE, 
			string m3_ITNO, 
			string m3_ATID, 
			string m3_ATVA, 
			string m3_ITDS = null, 
			string m3_TX30 = null, 
			int? m3_ANSQ = null, 
			string m3_DSPG = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/QuickAddAttrib",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ATTE))
				throw new ArgumentNullException("m3_ATTE");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_ATID))
				throw new ArgumentNullException("m3_ATID");
			if (string.IsNullOrWhiteSpace(m3_ATVA))
				throw new ArgumentNullException("m3_ATVA");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATTE", m3_ATTE.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("ATID", m3_ATID.Trim())
				.WithQueryParameter("ATVA", m3_ATVA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX30))
				request.WithQueryParameter("TX30", m3_TX30.Trim());
			if (m3_ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3_ANSQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DSPG))
				request.WithQueryParameter("DSPG", m3_DSPG.Trim());

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
