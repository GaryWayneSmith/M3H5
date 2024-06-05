/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3AAGN">Agreement number (Required)</param>
		/// <param name="m3ALNT">Line type (Required)</param>
		/// <param name="m3IDEN">Item ID (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3EXCL">Excluded</param>
		/// <param name="m3IDTP">Item ID type</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgrContentResponse></returns>
		/// <exception cref="M3Exception<GetAgrContentResponse>"></exception>
		public async Task<M3Response<GetAgrContentResponse>> GetAgrContent(
			string m3AAGN, 
			int m3ALNT, 
			string m3IDEN, 
			string m3PRNO = null, 
			string m3SERN = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			int? m3EXCL = null, 
			int? m3IDTP = null, 
			string m3ITNO = null, 
			string m3CFGL = null, 
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
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));
			if (string.IsNullOrWhiteSpace(m3IDEN))
				throw new ArgumentNullException(nameof(m3IDEN));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim())
				.WithQueryParameter("ALNT", m3ALNT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("IDEN", m3IDEN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (m3EXCL.HasValue)
				request.WithQueryParameter("EXCL", m3EXCL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IDTP.HasValue)
				request.WithQueryParameter("IDTP", m3IDTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());

			// Execute the request
			var result = await Execute<GetAgrContentResponse>(
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
		/// Name GetAgrLnDetail
		/// Description Displays Agreement Line Details
		/// Version Release: 
		/// </summary>
		/// <param name="m3AAGN">Agreement number (Required)</param>
		/// <param name="m3SRVP">Service price method (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgrLnDetailResponse></returns>
		/// <exception cref="M3Exception<GetAgrLnDetailResponse>"></exception>
		public async Task<M3Response<GetAgrLnDetailResponse>> GetAgrLnDetail(
			string m3AAGN, 
			int m3SRVP, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			DateTime? m3STDT = null, 
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
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim())
				.WithQueryParameter("SRVP", m3SRVP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetAgrLnDetailResponse>(
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
		/// Name GetMCOLineTotal
		/// Description Displays MCO Line Total
		/// Version Release: 
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3AQUO">Quotation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMCOLineTotalResponse></returns>
		/// <exception cref="M3Exception<GetMCOLineTotalResponse>"></exception>
		public async Task<M3Response<GetMCOLineTotalResponse>> GetMCOLineTotal(
			string m3ORNO, 
			int? m3PONR = null, 
			int? m3AQUO = null, 
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
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AQUO.HasValue)
				request.WithQueryParameter("AQUO", m3AQUO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetMCOLineTotalResponse>(
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
		/// Name SelAgrContent
		/// Description Selects Agreement Content
		/// Version Release: 
		/// </summary>
		/// <param name="m3AAGN">Agreement number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelAgrContentResponse></returns>
		/// <exception cref="M3Exception<SelAgrContentResponse>"></exception>
		public async Task<M3Response<SelAgrContentResponse>> SelAgrContent(
			string m3AAGN, 
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
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim());

			// Execute the request
			var result = await Execute<SelAgrContentResponse>(
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
		/// Name SelAgrLine
		/// Description Selects Agreement Line
		/// Version Release: 
		/// </summary>
		/// <param name="m3AAGN">Agreement number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelAgrLineResponse></returns>
		/// <exception cref="M3Exception<SelAgrLineResponse>"></exception>
		public async Task<M3Response<SelAgrLineResponse>> SelAgrLine(
			string m3AAGN, 
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
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim());

			// Execute the request
			var result = await Execute<SelAgrLineResponse>(
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
		/// Name SelMCOLineTotal
		/// Description Selects MCO Line Total
		/// Version Release: 
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelMCOLineTotalResponse></returns>
		/// <exception cref="M3Exception<SelMCOLineTotalResponse>"></exception>
		public async Task<M3Response<SelMCOLineTotalResponse>> SelMCOLineTotal(
			string m3ORNO, 
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
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Execute the request
			var result = await Execute<SelMCOLineTotalResponse>(
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
