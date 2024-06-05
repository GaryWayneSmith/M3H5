/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.SOS500MI;
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
	/// Name: SOS500MI
	/// Component Name: ServiceOrderEntry
	/// Description: Service order entry interface
	/// Version Release: 5e90
	///</summary>
	public partial class SOS500MIResource : M3BaseResourceEndpoint
	{
		public SOS500MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "SOS500MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetFixedPrAssig
		/// Description Get fixed price assignment
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3JOBN">Service order job number (Required)</param>
		/// <param name="m3JBSX">Assignment suffix (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFixedPrAssigResponse></returns>
		/// <exception cref="M3Exception<GetFixedPrAssigResponse>"></exception>
		public async Task<M3Response<GetFixedPrAssigResponse>> GetFixedPrAssig(
			string m3ORNO, 
			int m3JOBN, 
			int m3JBSX, 
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetFixedPrAssig",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("JOBN", m3JOBN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBSX", m3JBSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetFixedPrAssigResponse>(
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

		/// <summary>
		/// Name LstAssignSOText
		/// Description List assignment per service ordert text
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3JOBN">Service order job number</param>
		/// <param name="m3JBSX">Assignment suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAssignSOTextResponse></returns>
		/// <exception cref="M3Exception<LstAssignSOTextResponse>"></exception>
		public async Task<M3Response<LstAssignSOTextResponse>> LstAssignSOText(
			int? m3CONO = null, 
			string m3ORNO = null, 
			int? m3JOBN = null, 
			int? m3JBSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAssignSOText",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (m3JOBN.HasValue)
				request.WithQueryParameter("JOBN", m3JOBN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3JBSX.HasValue)
				request.WithQueryParameter("JBSX", m3JBSX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAssignSOTextResponse>(
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

		/// <summary>
		/// Name LstAssignmPerSO
		/// Description List assignment per service order
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3JOBN">Service order job number</param>
		/// <param name="m3JBSX">Assignment suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAssignmPerSOResponse></returns>
		/// <exception cref="M3Exception<LstAssignmPerSOResponse>"></exception>
		public async Task<M3Response<LstAssignmPerSOResponse>> LstAssignmPerSO(
			string m3ORNO, 
			int? m3CONO = null, 
			int? m3JOBN = null, 
			int? m3JBSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAssignmPerSO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3JOBN.HasValue)
				request.WithQueryParameter("JOBN", m3JOBN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3JBSX.HasValue)
				request.WithQueryParameter("JBSX", m3JBSX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAssignmPerSOResponse>(
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

		/// <summary>
		/// Name LstFixedPrAssig
		/// Description List fixed price assignment
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3JOBN">Service order job number</param>
		/// <param name="m3JBSX">Assignment suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFixedPrAssigResponse></returns>
		/// <exception cref="M3Exception<LstFixedPrAssigResponse>"></exception>
		public async Task<M3Response<LstFixedPrAssigResponse>> LstFixedPrAssig(
			string m3ORNO, 
			int? m3CONO = null, 
			int? m3JOBN = null, 
			int? m3JBSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFixedPrAssig",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3JOBN.HasValue)
				request.WithQueryParameter("JOBN", m3JOBN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3JBSX.HasValue)
				request.WithQueryParameter("JBSX", m3JBSX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstFixedPrAssigResponse>(
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
