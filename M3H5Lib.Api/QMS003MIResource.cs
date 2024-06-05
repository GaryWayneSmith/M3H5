/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.QMS003MI;
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
	/// Name: QMS003MI
	/// Component Name: Numeric qualitative value
	/// Description: Api: Numeric qualitative value inteface
	/// Version Release: 
	///</summary>
	public partial class QMS003MIResource : M3BaseResourceEndpoint
	{
		public QMS003MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QMS003MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddNumericQualV
		/// Description Add a numeric qualitative value
		/// Version Release: 
		/// </summary>
		/// <param name="m3QTCD">Numeric qualitative</param>
		/// <param name="m3QTVL">Numeric qualitative value</param>
		/// <param name="m3DSCR">Description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddNumericQualV(
			string m3QTCD = null, 
			int? m3QTVL = null, 
			string m3DSCR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddNumericQualV",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3QTCD))
				request.WithQueryParameter("QTCD", m3QTCD.Trim());
			if (m3QTVL.HasValue)
				request.WithQueryParameter("QTVL", m3QTVL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DSCR))
				request.WithQueryParameter("DSCR", m3DSCR.Trim());

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
		/// Name DltNumericQualV
		/// Description Delete a numeric qualitative value
		/// Version Release: 
		/// </summary>
		/// <param name="m3QTCD">Numeric qualitative</param>
		/// <param name="m3QTVL">Numeric qualitative value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltNumericQualV(
			string m3QTCD = null, 
			int? m3QTVL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltNumericQualV",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3QTCD))
				request.WithQueryParameter("QTCD", m3QTCD.Trim());
			if (m3QTVL.HasValue)
				request.WithQueryParameter("QTVL", m3QTVL.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetNumericQualV
		/// Description Get numeric qualitative value data
		/// Version Release: 
		/// </summary>
		/// <param name="m3QTCD">Numeric qualitative</param>
		/// <param name="m3QTVL">Numeric qualitative value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetNumericQualVResponse></returns>
		/// <exception cref="M3Exception<GetNumericQualVResponse>"></exception>
		public async Task<M3Response<GetNumericQualVResponse>> GetNumericQualV(
			string m3QTCD = null, 
			int? m3QTVL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetNumericQualV",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3QTCD))
				request.WithQueryParameter("QTCD", m3QTCD.Trim());
			if (m3QTVL.HasValue)
				request.WithQueryParameter("QTVL", m3QTVL.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetNumericQualVResponse>(
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
		/// Name LstNumericQualV
		/// Description List numeric qualitative values
		/// Version Release: 
		/// </summary>
		/// <param name="m3QTCD">Numeric qualitative</param>
		/// <param name="m3QTVL">Numeric qualitative value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstNumericQualVResponse></returns>
		/// <exception cref="M3Exception<LstNumericQualVResponse>"></exception>
		public async Task<M3Response<LstNumericQualVResponse>> LstNumericQualV(
			string m3QTCD = null, 
			int? m3QTVL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstNumericQualV",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3QTCD))
				request.WithQueryParameter("QTCD", m3QTCD.Trim());
			if (m3QTVL.HasValue)
				request.WithQueryParameter("QTVL", m3QTVL.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstNumericQualVResponse>(
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
		/// Name UpdNumericQualV
		/// Description Update numeric qualitative value
		/// Version Release: 
		/// </summary>
		/// <param name="m3QTCD">Numeric qualitative</param>
		/// <param name="m3QTVL">Numeric qualitative value</param>
		/// <param name="m3DSCR">Description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdNumericQualV(
			string m3QTCD = null, 
			int? m3QTVL = null, 
			string m3DSCR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdNumericQualV",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3QTCD))
				request.WithQueryParameter("QTCD", m3QTCD.Trim());
			if (m3QTVL.HasValue)
				request.WithQueryParameter("QTVL", m3QTVL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DSCR))
				request.WithQueryParameter("DSCR", m3DSCR.Trim());

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
	}
}
// EOF
