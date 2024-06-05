/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.QUS114MI;
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
	/// Name: QUS114MI
	/// Component Name: Warranty
	/// Description: Api: Add Service
	/// Version Release: 5ea0
	///</summary>
	public partial class QUS114MIResource : M3BaseResourceEndpoint
	{
		public QUS114MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QUS114MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddService
		/// Description Add Service
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_AAGN">Agreement number</param>
		/// <param name="m3_ICUN">Internal customer</param>
		/// <param name="m3_SPRL">Service price list</param>
		/// <param name="m3_CSER">Configuration service</param>
		/// <param name="m3_DERE">Default record</param>
		/// <param name="m3_AOTY">Order type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddServiceResponse></returns>
		/// <exception cref="M3Exception<AddServiceResponse>"></exception>
		public async Task<M3Response<AddServiceResponse>> AddService(
			string m3_SUFI, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_STAT = null, 
			string m3_RESP = null, 
			string m3_AAGN = null, 
			string m3_ICUN = null, 
			string m3_SPRL = null, 
			int? m3_CSER = null, 
			int? m3_DERE = null, 
			string m3_AOTY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddService",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3_SUFI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AAGN))
				request.WithQueryParameter("AAGN", m3_AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ICUN))
				request.WithQueryParameter("ICUN", m3_ICUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPRL))
				request.WithQueryParameter("SPRL", m3_SPRL.Trim());
			if (m3_CSER.HasValue)
				request.WithQueryParameter("CSER", m3_CSER.Value.ToString());
			if (m3_DERE.HasValue)
				request.WithQueryParameter("DERE", m3_DERE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AOTY))
				request.WithQueryParameter("AOTY", m3_AOTY.Trim());

			// Execute the request
			var result = await Execute<AddServiceResponse>(
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
		/// Name ChgService
		/// Description Change Service
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_AAGN">Agreement number</param>
		/// <param name="m3_ICUN">Internal customer</param>
		/// <param name="m3_SPRL">Service price list</param>
		/// <param name="m3_CSER">Configuration service</param>
		/// <param name="m3_DERE">Default record</param>
		/// <param name="m3_AOTY">Order type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgService(
			string m3_SUFI, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_STAT = null, 
			string m3_RESP = null, 
			string m3_AAGN = null, 
			string m3_ICUN = null, 
			string m3_SPRL = null, 
			int? m3_CSER = null, 
			int? m3_DERE = null, 
			string m3_AOTY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgService",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3_SUFI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AAGN))
				request.WithQueryParameter("AAGN", m3_AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ICUN))
				request.WithQueryParameter("ICUN", m3_ICUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPRL))
				request.WithQueryParameter("SPRL", m3_SPRL.Trim());
			if (m3_CSER.HasValue)
				request.WithQueryParameter("CSER", m3_CSER.Value.ToString());
			if (m3_DERE.HasValue)
				request.WithQueryParameter("DERE", m3_DERE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AOTY))
				request.WithQueryParameter("AOTY", m3_AOTY.Trim());

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
		/// Name DltService
		/// Description Delete Service
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltService(
			string m3_SUFI, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltService",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3_SUFI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());

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
		/// Name GetService
		/// Description Get  Service
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetServiceResponse></returns>
		/// <exception cref="M3Exception<GetServiceResponse>"></exception>
		public async Task<M3Response<GetServiceResponse>> GetService(
			string m3_SUFI, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetService",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3_SUFI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());

			// Execute the request
			var result = await Execute<GetServiceResponse>(
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
		/// Name LstService
		/// Description List  Service
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstServiceResponse></returns>
		/// <exception cref="M3Exception<LstServiceResponse>"></exception>
		public async Task<M3Response<LstServiceResponse>> LstService(
			string m3_SUFI, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstService",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3_SUFI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());

			// Execute the request
			var result = await Execute<LstServiceResponse>(
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
