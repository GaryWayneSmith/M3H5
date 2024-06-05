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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name UpdTestResults
		/// Description Copy test results from an item to another given item
		/// Version Release: 
		/// </summary>
		/// <param name="m3_QRID">Request ID (Required)</param>
		/// <param name="m3_TOID">Request ID (Required)</param>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdTestResults(
			string m3_QRID, 
			string m3_TOID, 
			string m3_SPEC = null, 
			DateTime? m3_QSE1 = null, 
			int? m3_QSE2 = null, 
			string m3_FACI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdTestResults",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_QRID))
				throw new ArgumentNullException("m3_QRID");
			if (string.IsNullOrWhiteSpace(m3_TOID))
				throw new ArgumentNullException("m3_TOID");

			// Set mandatory parameters
			request
				.WithQueryParameter("QRID", m3_QRID.Trim())
				.WithQueryParameter("TOID", m3_TOID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());

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
