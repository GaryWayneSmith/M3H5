/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MNTAGRMI;
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
	/// Name: MNTAGRMI
	/// Component Name: EquipmentInfo
	/// Description: Api: Agreement Line
	/// Version Release: 13.1
	///</summary>
	public partial class MNTAGRMIResource : M3BaseResourceEndpoint
	{
		public MNTAGRMIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MNTAGRMI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetAgrContent
		/// Description Displays Agreement Content
		/// Version Release: 
		/// </summary>
		/// <param name="m3_AAGN">Agreement number (Required)</param>
		/// <param name="m3_ALNT">Line type (Required)</param>
		/// <param name="m3_IDEN">Item ID (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_EXCL">Excluded</param>
		/// <param name="m3_IDTP">Item ID type</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgrContentResponse></returns>
		/// <exception cref="M3Exception<GetAgrContentResponse>"></exception>
		public async Task<M3Response<GetAgrContentResponse>> GetAgrContent(
			string m3_AAGN, 
			int m3_ALNT, 
			string m3_IDEN, 
			string m3_PRNO = null, 
			string m3_SERN = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			int? m3_EXCL = null, 
			int? m3_IDTP = null, 
			string m3_ITNO = null, 
			string m3_CFGL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAgrContent",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");
			if (string.IsNullOrWhiteSpace(m3_IDEN))
				throw new ArgumentNullException("m3_IDEN");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim())
				.WithQueryParameter("ALNT", m3_ALNT.ToString())
				.WithQueryParameter("IDEN", m3_IDEN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_EXCL.HasValue)
				request.WithQueryParameter("EXCL", m3_EXCL.Value.ToString());
			if (m3_IDTP.HasValue)
				request.WithQueryParameter("IDTP", m3_IDTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());

			// Execute the request
			var result = await Execute<GetAgrContentResponse>(
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
		/// Name GetAgrLnDetail
		/// Description Displays Agreement Line Details
		/// Version Release: 
		/// </summary>
		/// <param name="m3_AAGN">Agreement number (Required)</param>
		/// <param name="m3_SRVP">Service price method (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgrLnDetailResponse></returns>
		/// <exception cref="M3Exception<GetAgrLnDetailResponse>"></exception>
		public async Task<M3Response<GetAgrLnDetailResponse>> GetAgrLnDetail(
			string m3_AAGN, 
			int m3_SRVP, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			DateTime? m3_STDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAgrLnDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim())
				.WithQueryParameter("SRVP", m3_SRVP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetAgrLnDetailResponse>(
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
		/// Name GetMCOLineTotal
		/// Description Displays MCO Line Total
		/// Version Release: 
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_AQUO">Quotation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMCOLineTotalResponse></returns>
		/// <exception cref="M3Exception<GetMCOLineTotalResponse>"></exception>
		public async Task<M3Response<GetMCOLineTotalResponse>> GetMCOLineTotal(
			string m3_ORNO, 
			int? m3_PONR = null, 
			int? m3_AQUO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMCOLineTotal",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_AQUO.HasValue)
				request.WithQueryParameter("AQUO", m3_AQUO.Value.ToString());

			// Execute the request
			var result = await Execute<GetMCOLineTotalResponse>(
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
		/// Name SelAgrContent
		/// Description Selects Agreement Content
		/// Version Release: 
		/// </summary>
		/// <param name="m3_AAGN">Agreement number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelAgrContentResponse></returns>
		/// <exception cref="M3Exception<SelAgrContentResponse>"></exception>
		public async Task<M3Response<SelAgrContentResponse>> SelAgrContent(
			string m3_AAGN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelAgrContent",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim());

			// Execute the request
			var result = await Execute<SelAgrContentResponse>(
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
		/// Name SelAgrLine
		/// Description Selects Agreement Line
		/// Version Release: 
		/// </summary>
		/// <param name="m3_AAGN">Agreement number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelAgrLineResponse></returns>
		/// <exception cref="M3Exception<SelAgrLineResponse>"></exception>
		public async Task<M3Response<SelAgrLineResponse>> SelAgrLine(
			string m3_AAGN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelAgrLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim());

			// Execute the request
			var result = await Execute<SelAgrLineResponse>(
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
		/// Name SelMCOLineTotal
		/// Description Selects MCO Line Total
		/// Version Release: 
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelMCOLineTotalResponse></returns>
		/// <exception cref="M3Exception<SelMCOLineTotalResponse>"></exception>
		public async Task<M3Response<SelMCOLineTotalResponse>> SelMCOLineTotal(
			string m3_ORNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelMCOLineTotal",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Execute the request
			var result = await Execute<SelMCOLineTotalResponse>(
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
