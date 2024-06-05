/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_QRDT">QI request reqd date (Required)</param>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="m3_ITNO">Item</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddQIRequestResponse></returns>
		/// <exception cref="M3Exception<AddQIRequestResponse>"></exception>
		public async Task<M3Response<AddQIRequestResponse>> AddQIRequest(
			DateTime m3_QRDT, 
			string m3_SPEC = null, 
			string m3_SUNO = null, 
			string m3_AGNB = null, 
			int? m3_SEQN = null, 
			string m3_ITNO = null, 
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
				.WithQueryParameter("QRDT", m3_QRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<AddQIRequestResponse>(
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
		/// Name LstSpec
		/// Description LstSpec
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ITNO">Item</param>
		/// <param name="m3_QRDT">QI request date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSpecResponse></returns>
		/// <exception cref="M3Exception<LstSpecResponse>"></exception>
		public async Task<M3Response<LstSpecResponse>> LstSpec(
			string m3_ITNO = null, 
			DateTime? m3_QRDT = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_QRDT.HasValue)
				request.WithQueryParameter("QRDT", m3_QRDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstSpecResponse>(
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
