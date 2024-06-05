/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PMS055MI;
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
	/// Name: PMS055MI
	/// Component Name: GetBackFlushQty
	/// Description: Manufactoring order. Back-flush functions
	/// Version Release: 14.x
	///</summary>
	public partial class PMS055MIResource : M3BaseResourceEndpoint
	{
		public PMS055MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PMS055MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetBackFlushQty
		/// Description Get Back Flush Quantity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3_RPQA">Reported quantity in alternative unit</param>
		/// <param name="m3_MAUN">Manufacturing U/M</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_MTNO">Component number</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBackFlushQtyResponse></returns>
		/// <exception cref="M3Exception<GetBackFlushQtyResponse>"></exception>
		public async Task<M3Response<GetBackFlushQtyResponse>> GetBackFlushQty(
			int m3_CONO, 
			string m3_FACI, 
			string m3_PRNO, 
			string m3_MFNO, 
			decimal? m3_RPQA = null, 
			string m3_MAUN = null, 
			decimal? m3_CAWE = null, 
			string m3_RORN = null, 
			string m3_MTNO = null, 
			int? m3_MSEQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBackFlushQty",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_MFNO))
				throw new ArgumentNullException("m3_MFNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("MFNO", m3_MFNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RPQA.HasValue)
				request.WithQueryParameter("RPQA", m3_RPQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MAUN))
				request.WithQueryParameter("MAUN", m3_MAUN.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTNO))
				request.WithQueryParameter("MTNO", m3_MTNO.Trim());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());

			// Execute the request
			var result = await Execute<GetBackFlushQtyResponse>(
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
