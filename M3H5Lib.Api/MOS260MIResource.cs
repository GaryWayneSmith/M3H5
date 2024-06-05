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
	/// Name: MOS260MI
	/// Component Name: Modifications
	/// Description: Api: Modifications
	/// Version Release: 
	///</summary>
	public partial class MOS260MIResource : M3BaseResourceEndpoint
	{
		public MOS260MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS260MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add equipment status
		/// Version Release: 
		/// </summary>
		/// <param name="m3_DOID">Document identity (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_STEO">Status (Required)</param>
		/// <param name="m3_RNAP">N/A reason (Required)</param>
		/// <param name="m3_AABY">Approved by (Required)</param>
		/// <param name="m3_ACDA">Actual finish date</param>
		/// <param name="m3_MODM">Mod marking</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_DOID, 
			string m3_ITNO, 
			string m3_SERN, 
			string m3_STEO, 
			string m3_RNAP, 
			string m3_AABY, 
			DateTime? m3_ACDA = null, 
			string m3_MODM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DOID))
				throw new ArgumentNullException("m3_DOID");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_STEO))
				throw new ArgumentNullException("m3_STEO");
			if (string.IsNullOrWhiteSpace(m3_RNAP))
				throw new ArgumentNullException("m3_RNAP");
			if (string.IsNullOrWhiteSpace(m3_AABY))
				throw new ArgumentNullException("m3_AABY");

			// Set mandatory parameters
			request
				.WithQueryParameter("DOID", m3_DOID.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("STEO", m3_STEO.Trim())
				.WithQueryParameter("RNAP", m3_RNAP.Trim())
				.WithQueryParameter("AABY", m3_AABY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_ACDA.HasValue)
				request.WithQueryParameter("ACDA", m3_ACDA.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_MODM))
				request.WithQueryParameter("MODM", m3_MODM.Trim());

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
