/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3AAGN">Agreement number</param>
		/// <param name="m3ICUN">Internal customer</param>
		/// <param name="m3SPRL">Service price list</param>
		/// <param name="m3CSER">Configuration service</param>
		/// <param name="m3DERE">Default record</param>
		/// <param name="m3AOTY">Order type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddServiceResponse></returns>
		/// <exception cref="M3Exception<AddServiceResponse>"></exception>
		public async Task<M3Response<AddServiceResponse>> AddService(
			string m3SUFI, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3STAT = null, 
			string m3RESP = null, 
			string m3AAGN = null, 
			string m3ICUN = null, 
			string m3SPRL = null, 
			int? m3CSER = null, 
			int? m3DERE = null, 
			string m3AOTY = null, 
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
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3SUFI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3AAGN))
				request.WithQueryParameter("AAGN", m3AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ICUN))
				request.WithQueryParameter("ICUN", m3ICUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPRL))
				request.WithQueryParameter("SPRL", m3SPRL.Trim());
			if (m3CSER.HasValue)
				request.WithQueryParameter("CSER", m3CSER.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DERE.HasValue)
				request.WithQueryParameter("DERE", m3DERE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AOTY))
				request.WithQueryParameter("AOTY", m3AOTY.Trim());

			// Execute the request
			var result = await Execute<AddServiceResponse>(
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
		/// Name ChgService
		/// Description Change Service
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3AAGN">Agreement number</param>
		/// <param name="m3ICUN">Internal customer</param>
		/// <param name="m3SPRL">Service price list</param>
		/// <param name="m3CSER">Configuration service</param>
		/// <param name="m3DERE">Default record</param>
		/// <param name="m3AOTY">Order type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgService(
			string m3SUFI, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3STAT = null, 
			string m3RESP = null, 
			string m3AAGN = null, 
			string m3ICUN = null, 
			string m3SPRL = null, 
			int? m3CSER = null, 
			int? m3DERE = null, 
			string m3AOTY = null, 
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
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3SUFI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3AAGN))
				request.WithQueryParameter("AAGN", m3AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ICUN))
				request.WithQueryParameter("ICUN", m3ICUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPRL))
				request.WithQueryParameter("SPRL", m3SPRL.Trim());
			if (m3CSER.HasValue)
				request.WithQueryParameter("CSER", m3CSER.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DERE.HasValue)
				request.WithQueryParameter("DERE", m3DERE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AOTY))
				request.WithQueryParameter("AOTY", m3AOTY.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
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
		/// Name DltService
		/// Description Delete Service
		/// Version Release: 
		/// </summary>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltService(
			string m3SUFI, 
			string m3PRNO = null, 
			string m3STRT = null, 
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
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3SUFI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
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
		/// Name GetService
		/// Description Get  Service
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetServiceResponse></returns>
		/// <exception cref="M3Exception<GetServiceResponse>"></exception>
		public async Task<M3Response<GetServiceResponse>> GetService(
			string m3SUFI, 
			string m3PRNO = null, 
			string m3STRT = null, 
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
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3SUFI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());

			// Execute the request
			var result = await Execute<GetServiceResponse>(
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
		/// Name LstService
		/// Description List  Service
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstServiceResponse></returns>
		/// <exception cref="M3Exception<LstServiceResponse>"></exception>
		public async Task<M3Response<LstServiceResponse>> LstService(
			string m3SUFI, 
			string m3PRNO = null, 
			string m3STRT = null, 
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
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3SUFI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());

			// Execute the request
			var result = await Execute<LstServiceResponse>(
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
