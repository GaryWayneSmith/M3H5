/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MOS250MI;
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
	/// Name: MOS250MI
	/// Component Name: ModelIndividual
	/// Description: Model individual interface
	/// Version Release: 13.1
	///</summary>
	public partial class MOS250MIResource : M3BaseResourceEndpoint
	{
		public MOS250MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS250MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name SelRelations
		/// Description Select work center relationships
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_FFAC">From facility (Required)</param>
		/// <param name="m3_TFAC">To facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PLTP">Resource type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelRelationsResponse></returns>
		/// <exception cref="M3Exception<SelRelationsResponse>"></exception>
		public async Task<M3Response<SelRelationsResponse>> SelRelations(
			string m3_FFAC, 
			string m3_TFAC, 
			int? m3_CONO = null, 
			int? m3_PLTP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelRelations",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FFAC))
				throw new ArgumentNullException("m3_FFAC");
			if (string.IsNullOrWhiteSpace(m3_TFAC))
				throw new ArgumentNullException("m3_TFAC");

			// Set mandatory parameters
			request
				.WithQueryParameter("FFAC", m3_FFAC.Trim())
				.WithQueryParameter("TFAC", m3_TFAC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PLTP.HasValue)
				request.WithQueryParameter("PLTP", m3_PLTP.Value.ToString());

			// Execute the request
			var result = await Execute<SelRelationsResponse>(
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
		/// Name SelShiftInfo
		/// Description Select work center - shift records
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_FFAC">From facility (Required)</param>
		/// <param name="m3_TFAC">To facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PLTP">Resource type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelShiftInfoResponse></returns>
		/// <exception cref="M3Exception<SelShiftInfoResponse>"></exception>
		public async Task<M3Response<SelShiftInfoResponse>> SelShiftInfo(
			string m3_FFAC, 
			string m3_TFAC, 
			int? m3_CONO = null, 
			int? m3_PLTP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelShiftInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FFAC))
				throw new ArgumentNullException("m3_FFAC");
			if (string.IsNullOrWhiteSpace(m3_TFAC))
				throw new ArgumentNullException("m3_TFAC");

			// Set mandatory parameters
			request
				.WithQueryParameter("FFAC", m3_FFAC.Trim())
				.WithQueryParameter("TFAC", m3_TFAC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PLTP.HasValue)
				request.WithQueryParameter("PLTP", m3_PLTP.Value.ToString());

			// Execute the request
			var result = await Execute<SelShiftInfoResponse>(
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
		/// Name Select
		/// Description Select work centers
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_FFAC">From facility (Required)</param>
		/// <param name="m3_TFAC">To facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PLTP">Resource type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectResponse></returns>
		/// <exception cref="M3Exception<SelectResponse>"></exception>
		public async Task<M3Response<SelectResponse>> Select(
			string m3_FFAC, 
			string m3_TFAC, 
			int? m3_CONO = null, 
			string m3_PLTP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Select",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FFAC))
				throw new ArgumentNullException("m3_FFAC");
			if (string.IsNullOrWhiteSpace(m3_TFAC))
				throw new ArgumentNullException("m3_TFAC");

			// Set mandatory parameters
			request
				.WithQueryParameter("FFAC", m3_FFAC.Trim())
				.WithQueryParameter("TFAC", m3_TFAC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLTP))
				request.WithQueryParameter("PLTP", m3_PLTP.Trim());

			// Execute the request
			var result = await Execute<SelectResponse>(
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
