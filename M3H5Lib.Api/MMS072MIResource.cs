/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MMS072MI;
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
	/// Name: MMS072MI
	/// Component Name: CumQuantityInterface
	/// Description: Cumulative quantity interface
	/// Version Release: 14.x
	///</summary>
	public partial class MMS072MIResource : M3BaseResourceEndpoint
	{
		public MMS072MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS072MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetCumulative
		/// Description Get cumulative detailed record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_IRTY">Internal reference type (Required)</param>
		/// <param name="m3_INRF">Internal reference (Required)</param>
		/// <param name="m3_CUML">Cumulative level (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_IECD">Include/exclude current delivery</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_PUNO">Purchase order number</param>
		/// <param name="m3_PNLI">Purchase order line</param>
		/// <param name="m3_PNLS">Purchase order line subnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCumulativeResponse></returns>
		/// <exception cref="M3Exception<GetCumulativeResponse>"></exception>
		public async Task<M3Response<GetCumulativeResponse>> GetCumulative(
			string m3_ITNO, 
			int m3_IRTY, 
			string m3_INRF, 
			int m3_CUML, 
			int? m3_CONO = null, 
			int? m3_IECD = null, 
			decimal? m3_DLIX = null, 
			string m3_PUNO = null, 
			int? m3_PNLI = null, 
			int? m3_PNLS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetCumulative",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_INRF))
				throw new ArgumentNullException("m3_INRF");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("IRTY", m3_IRTY.ToString())
				.WithQueryParameter("INRF", m3_INRF.Trim())
				.WithQueryParameter("CUML", m3_CUML.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_IECD.HasValue)
				request.WithQueryParameter("IECD", m3_IECD.Value.ToString());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PUNO))
				request.WithQueryParameter("PUNO", m3_PUNO.Trim());
			if (m3_PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3_PNLI.Value.ToString());
			if (m3_PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3_PNLS.Value.ToString());

			// Execute the request
			var result = await Execute<GetCumulativeResponse>(
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

		/// <summary>
		/// Name LstCumulative
		/// Description List cumulative detailed records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_IRTY">Internal reference type (Required)</param>
		/// <param name="m3_INRF">Internal reference (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCumulativeResponse></returns>
		/// <exception cref="M3Exception<LstCumulativeResponse>"></exception>
		public async Task<M3Response<LstCumulativeResponse>> LstCumulative(
			string m3_ITNO, 
			int m3_IRTY, 
			string m3_INRF, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCumulative",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_INRF))
				throw new ArgumentNullException("m3_INRF");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("IRTY", m3_IRTY.ToString())
				.WithQueryParameter("INRF", m3_INRF.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstCumulativeResponse>(
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
