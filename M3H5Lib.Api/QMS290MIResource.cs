/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.QMS290MI;
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
	/// Name: QMS290MI
	/// Component Name: QI Request
	/// Description: Api: QI request interface
	/// Version Release: 5e90
	///</summary>
	public partial class QMS290MIResource : M3BaseResourceEndpoint
	{
		public QMS290MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QMS290MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddQIRequest
		/// Description Add a QI Request
		/// Version Release: 
		/// </summary>
		/// <param name="m3QRDT">QI request reqd date (Required)</param>
		/// <param name="m3SPEC">Specification</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3SEQN">Sequence number</param>
		/// <param name="m3ITNO">Item</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddQIRequestResponse></returns>
		/// <exception cref="M3Exception<AddQIRequestResponse>"></exception>
		public async Task<M3Response<AddQIRequestResponse>> AddQIRequest(
			DateTime m3QRDT, 
			string m3SPEC = null, 
			string m3SUNO = null, 
			string m3AGNB = null, 
			int? m3SEQN = null, 
			string m3ITNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddQIRequest",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("QRDT", m3QRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SPEC))
				request.WithQueryParameter("SPEC", m3SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (m3SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3SEQN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<AddQIRequestResponse>(
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
		/// Name LstSpec
		/// Description LstSpec
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3ITNO">Item</param>
		/// <param name="m3QRDT">QI request date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSpecResponse></returns>
		/// <exception cref="M3Exception<LstSpecResponse>"></exception>
		public async Task<M3Response<LstSpecResponse>> LstSpec(
			string m3ITNO = null, 
			DateTime? m3QRDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSpec",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3QRDT.HasValue)
				request.WithQueryParameter("QRDT", m3QRDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstSpecResponse>(
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
