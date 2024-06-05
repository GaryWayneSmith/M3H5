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
	/// Name: MOS380MI
	/// Component Name: Add Operation Plan
	/// Description: Add Operation Plan
	/// Version Release: 
	///</summary>
	public partial class MOS380MIResource : M3BaseResourceEndpoint
	{
		public MOS380MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS380MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddOpPlan
		/// Description Adds Operation Plan
		/// Version Release: 
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_DICU">Distribution curve (Required)</param>
		/// <param name="m3_CYP6">From Period (Required)</param>
		/// <param name="m3_OPVR">Operation plan version</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_MES0">Meter</param>
		/// <param name="m3_QTYA">Total F/C</param>
		/// <param name="m3_PERI">No of Periods</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddOpPlan(
			string m3_ITNO, 
			int m3_DICU, 
			int m3_CYP6, 
			string m3_OPVR = null, 
			string m3_SERN = null, 
			string m3_MES0 = null, 
			decimal? m3_QTYA = null, 
			int? m3_PERI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddOpPlan",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("DICU", m3_DICU.ToString())
				.WithQueryParameter("CYP6", m3_CYP6.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OPVR))
				request.WithQueryParameter("OPVR", m3_OPVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES0))
				request.WithQueryParameter("MES0", m3_MES0.Trim());
			if (m3_QTYA.HasValue)
				request.WithQueryParameter("QTYA", m3_QTYA.Value.ToString());
			if (m3_PERI.HasValue)
				request.WithQueryParameter("PERI", m3_PERI.Value.ToString());

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
