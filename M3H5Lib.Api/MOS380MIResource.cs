/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3DICU">Distribution curve (Required)</param>
		/// <param name="m3CYP6">From Period (Required)</param>
		/// <param name="m3OPVR">Operation plan version</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3MES0">Meter</param>
		/// <param name="m3QTYA">Total F/C</param>
		/// <param name="m3PERI">No of Periods</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddOpPlan(
			string m3ITNO, 
			int m3DICU, 
			int m3CYP6, 
			string m3OPVR = null, 
			string m3SERN = null, 
			string m3MES0 = null, 
			decimal? m3QTYA = null, 
			int? m3PERI = null, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("DICU", m3DICU.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CYP6", m3CYP6.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OPVR))
				request.WithQueryParameter("OPVR", m3OPVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES0))
				request.WithQueryParameter("MES0", m3MES0.Trim());
			if (m3QTYA.HasValue)
				request.WithQueryParameter("QTYA", m3QTYA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PERI.HasValue)
				request.WithQueryParameter("PERI", m3PERI.Value.ToString(CultureInfo.CurrentCulture));

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
