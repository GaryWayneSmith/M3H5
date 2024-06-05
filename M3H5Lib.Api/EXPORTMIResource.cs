/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.EXPORTMI;
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
	/// Name: EXPORTMI
	/// Component Name: DataExport
	/// Description: Data export
	/// Version Release: 5ea1
	///</summary>
	public partial class EXPORTMIResource : M3BaseResourceEndpoint
	{
		public EXPORTMIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "EXPORTMI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstFields
		/// Description List table fields
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFieldsResponse></returns>
		/// <exception cref="M3Exception<LstFieldsResponse>"></exception>
		public async Task<M3Response<LstFieldsResponse>> LstFields(
			string m3FILE, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFields",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim());

			// Execute the request
			var result = await Execute<LstFieldsResponse>(
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
		/// Name Select
		/// Description Select
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3QERY">Query statement (Required)</param>
		/// <param name="m3SEPC">Separator character</param>
		/// <param name="m3HDRS">Include headers, 1 or 0 or blank</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectResponse></returns>
		/// <exception cref="M3Exception<SelectResponse>"></exception>
		public async Task<M3Response<SelectResponse>> Select(
			string m3QERY, 
			string m3SEPC = null, 
			int? m3HDRS = null, 
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
			if (string.IsNullOrWhiteSpace(m3QERY))
				throw new ArgumentNullException(nameof(m3QERY));

			// Set mandatory parameters
			request
				.WithQueryParameter("QERY", m3QERY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SEPC))
				request.WithQueryParameter("SEPC", m3SEPC.Trim());
			if (m3HDRS.HasValue)
				request.WithQueryParameter("HDRS", m3HDRS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelectResponse>(
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
		/// Name SelectPad
		/// Description Select with reply string fully blank padded
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3QERY">Query statement (Required)</param>
		/// <param name="m3SEPC">Separator character</param>
		/// <param name="m3HDRS">Include headers, 1 or 0 or blank</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectPadResponse></returns>
		/// <exception cref="M3Exception<SelectPadResponse>"></exception>
		public async Task<M3Response<SelectPadResponse>> SelectPad(
			string m3QERY, 
			string m3SEPC = null, 
			int? m3HDRS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelectPad",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3QERY))
				throw new ArgumentNullException(nameof(m3QERY));

			// Set mandatory parameters
			request
				.WithQueryParameter("QERY", m3QERY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SEPC))
				request.WithQueryParameter("SEPC", m3SEPC.Trim());
			if (m3HDRS.HasValue)
				request.WithQueryParameter("HDRS", m3HDRS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelectPadResponse>(
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
