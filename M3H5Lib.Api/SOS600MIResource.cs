/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.SOS600MI;
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
	/// Name: SOS600MI
	/// Component Name: Service order entry
	/// Description: Service order entry - Charges
	/// Version Release: 14.x
	///</summary>
	public partial class SOS600MIResource : M3BaseResourceEndpoint
	{
		public SOS600MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "SOS600MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetAssignmChrg
		/// Description Get chrg connected to a SO, assignmnt no and sf
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_JOBN">Service order job number (Required)</param>
		/// <param name="m3_CRID">Charge (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_JBSX">Assignment suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAssignmChrgResponse></returns>
		/// <exception cref="M3Exception<GetAssignmChrgResponse>"></exception>
		public async Task<M3Response<GetAssignmChrgResponse>> GetAssignmChrg(
			string m3_ORNO, 
			int m3_JOBN, 
			string m3_CRID, 
			int? m3_CONO = null, 
			int? m3_JBSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAssignmChrg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_CRID))
				throw new ArgumentNullException("m3_CRID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("JOBN", m3_JOBN.ToString())
				.WithQueryParameter("CRID", m3_CRID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_JBSX.HasValue)
				request.WithQueryParameter("JBSX", m3_JBSX.Value.ToString());

			// Execute the request
			var result = await Execute<GetAssignmChrgResponse>(
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
		/// Name GetSOLineChrg
		/// Description Get charge connected to a service order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_CRID">Charge (Required)</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSOLineChrgResponse></returns>
		/// <exception cref="M3Exception<GetSOLineChrgResponse>"></exception>
		public async Task<M3Response<GetSOLineChrgResponse>> GetSOLineChrg(
			int m3_CONO, 
			string m3_ORNO, 
			int m3_PONR, 
			string m3_CRID, 
			int? m3_POSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSOLineChrg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_CRID))
				throw new ArgumentNullException("m3_CRID");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("CRID", m3_CRID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());

			// Execute the request
			var result = await Execute<GetSOLineChrgResponse>(
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
		/// Name LstAssignmChrg
		/// Description List assignment charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_JOBN">Service order job number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_JBSX">Assignment suffix</param>
		/// <param name="m3_CRID">Charge</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAssignmChrgResponse></returns>
		/// <exception cref="M3Exception<LstAssignmChrgResponse>"></exception>
		public async Task<M3Response<LstAssignmChrgResponse>> LstAssignmChrg(
			string m3_ORNO, 
			int m3_JOBN, 
			int? m3_CONO = null, 
			int? m3_JBSX = null, 
			string m3_CRID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAssignmChrg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("JOBN", m3_JOBN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_JBSX.HasValue)
				request.WithQueryParameter("JBSX", m3_JBSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CRID))
				request.WithQueryParameter("CRID", m3_CRID.Trim());

			// Execute the request
			var result = await Execute<LstAssignmChrgResponse>(
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
		/// Name LstSOLineChrg
		/// Description List service order line charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_CRID">Charge</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSOLineChrgResponse></returns>
		/// <exception cref="M3Exception<LstSOLineChrgResponse>"></exception>
		public async Task<M3Response<LstSOLineChrgResponse>> LstSOLineChrg(
			string m3_ORNO, 
			int m3_PONR, 
			int? m3_CONO = null, 
			int? m3_POSX = null, 
			string m3_CRID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSOLineChrg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CRID))
				request.WithQueryParameter("CRID", m3_CRID.Trim());

			// Execute the request
			var result = await Execute<LstSOLineChrgResponse>(
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
