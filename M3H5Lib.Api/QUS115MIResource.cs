/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.QUS115MI;
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
	/// Name: QUS115MI
	/// Component Name: Warranty
	/// Description: Api: Add Agreement
	/// Version Release: 14.x
	///</summary>
	public partial class QUS115MIResource : M3BaseResourceEndpoint
	{
		public QUS115MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QUS115MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAgreement
		/// Description Add Agreement
		/// Version Release: 
		/// </summary>
		/// <param name="m3_AAGN">Agreement number (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_NOPR">Number of periods</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_DERE">Default record</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAgreement(
			string m3_AAGN, 
			string m3_PRNO = null, 
			string m3_STAT = null, 
			string m3_RESP = null, 
			int? m3_NOPR = null, 
			string m3_ITNO = null, 
			int? m3_DERE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAgreement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_NOPR.HasValue)
				request.WithQueryParameter("NOPR", m3_NOPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_DERE.HasValue)
				request.WithQueryParameter("DERE", m3_DERE.Value.ToString());

			// Execute the request
			var result = await Execute<M3Record>(
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
		/// Name ChgAgreement
		/// Description Change Agreement
		/// Version Release: 
		/// </summary>
		/// <param name="m3_AAGN">Agreement number (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_NOPR">Number of periods</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_DERE">Default record</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgAgreement(
			string m3_AAGN, 
			string m3_PRNO = null, 
			string m3_STAT = null, 
			string m3_RESP = null, 
			int? m3_NOPR = null, 
			string m3_ITNO = null, 
			int? m3_DERE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgAgreement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_NOPR.HasValue)
				request.WithQueryParameter("NOPR", m3_NOPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_DERE.HasValue)
				request.WithQueryParameter("DERE", m3_DERE.Value.ToString());

			// Execute the request
			var result = await Execute<M3Record>(
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
		/// Name DltAgreement
		/// Description Delete Agreement
		/// Version Release: 
		/// </summary>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_AAGN">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAgreement(
			string m3_PRNO = null, 
			string m3_AAGN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltAgreement",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AAGN))
				request.WithQueryParameter("AAGN", m3_AAGN.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
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
		/// Name GetAgreement
		/// Description Get Agreement
		/// Version Release: 
		/// </summary>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_AAGN">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgreementResponse></returns>
		/// <exception cref="M3Exception<GetAgreementResponse>"></exception>
		public async Task<M3Response<GetAgreementResponse>> GetAgreement(
			string m3_PRNO = null, 
			string m3_AAGN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAgreement",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AAGN))
				request.WithQueryParameter("AAGN", m3_AAGN.Trim());

			// Execute the request
			var result = await Execute<GetAgreementResponse>(
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
		/// Name LstAgreement
		/// Description List  Agreement
		/// Version Release: 
		/// </summary>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_AAGN">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgreementResponse></returns>
		/// <exception cref="M3Exception<LstAgreementResponse>"></exception>
		public async Task<M3Response<LstAgreementResponse>> LstAgreement(
			string m3_PRNO = null, 
			string m3_AAGN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgreement",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AAGN))
				request.WithQueryParameter("AAGN", m3_AAGN.Trim());

			// Execute the request
			var result = await Execute<LstAgreementResponse>(
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
