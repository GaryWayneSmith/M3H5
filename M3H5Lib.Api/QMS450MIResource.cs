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
	/// Name: QMS450MI
	/// Component Name: QI Copy test results
	/// Description: Api: QI Copy test results interface
	/// Version Release: 14.x
	///</summary>
	public partial class QMS450MIResource : M3BaseResourceEndpoint
	{
		public QMS450MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QMS450MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name UpdTestResults
		/// Description Copy test results from an item to another given item
		/// Version Release: 
		/// </summary>
		/// <param name="m3QRID">Request ID (Required)</param>
		/// <param name="m3TOID">Request ID (Required)</param>
		/// <param name="m3SPEC">Specification</param>
		/// <param name="m3QSE1">Effective date</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdTestResults(
			string m3QRID, 
			string m3TOID, 
			string m3SPEC = null, 
			DateTime? m3QSE1 = null, 
			int? m3QSE2 = null, 
			string m3FACI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdTestResults",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3QRID))
				throw new ArgumentNullException(nameof(m3QRID));
			if (string.IsNullOrWhiteSpace(m3TOID))
				throw new ArgumentNullException(nameof(m3TOID));

			// Set mandatory parameters
			request
				.WithQueryParameter("QRID", m3QRID.Trim())
				.WithQueryParameter("TOID", m3TOID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SPEC))
				request.WithQueryParameter("SPEC", m3SPEC.Trim());
			if (m3QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3QSE1.Value.ToM3String());
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());

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
