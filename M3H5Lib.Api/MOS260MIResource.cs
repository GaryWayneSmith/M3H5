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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add equipment status
		/// Version Release: 
		/// </summary>
		/// <param name="m3DOID">Document identity (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3STEO">Status (Required)</param>
		/// <param name="m3RNAP">N/A reason (Required)</param>
		/// <param name="m3AABY">Approved by (Required)</param>
		/// <param name="m3ACDA">Actual finish date</param>
		/// <param name="m3MODM">Mod marking</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3DOID, 
			string m3ITNO, 
			string m3SERN, 
			string m3STEO, 
			string m3RNAP, 
			string m3AABY, 
			DateTime? m3ACDA = null, 
			string m3MODM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DOID))
				throw new ArgumentNullException(nameof(m3DOID));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));
			if (string.IsNullOrWhiteSpace(m3STEO))
				throw new ArgumentNullException(nameof(m3STEO));
			if (string.IsNullOrWhiteSpace(m3RNAP))
				throw new ArgumentNullException(nameof(m3RNAP));
			if (string.IsNullOrWhiteSpace(m3AABY))
				throw new ArgumentNullException(nameof(m3AABY));

			// Set mandatory parameters
			request
				.WithQueryParameter("DOID", m3DOID.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim())
				.WithQueryParameter("STEO", m3STEO.Trim())
				.WithQueryParameter("RNAP", m3RNAP.Trim())
				.WithQueryParameter("AABY", m3AABY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3ACDA.HasValue)
				request.WithQueryParameter("ACDA", m3ACDA.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3MODM))
				request.WithQueryParameter("MODM", m3MODM.Trim());

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
