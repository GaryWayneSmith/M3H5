/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.GLS840MI;
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
	/// Name: GLS840MI
	/// Component Name: GL interface
	/// Description: Generic GL interface
	/// Version Release: 15.x
	///</summary>
	public partial class GLS840MIResource : M3BaseResourceEndpoint
	{
		public GLS840MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "GLS840MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddBatchHead
		/// Description Add data to FGLINH
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3KEY1">Key value (Required)</param>
		/// <param name="m3INTN">Interface (Required)</param>
		/// <param name="m3DESC">Description (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3USID">User</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddBatchHeadResponse></returns>
		/// <exception cref="M3Exception<AddBatchHeadResponse>"></exception>
		public async Task<M3Response<AddBatchHeadResponse>> AddBatchHead(
			int m3CONO, 
			string m3KEY1, 
			string m3INTN, 
			string m3DESC, 
			string m3DIVI = null, 
			string m3USID = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddBatchHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3KEY1))
				throw new ArgumentNullException(nameof(m3KEY1));
			if (string.IsNullOrWhiteSpace(m3INTN))
				throw new ArgumentNullException(nameof(m3INTN));
			if (string.IsNullOrWhiteSpace(m3DESC))
				throw new ArgumentNullException(nameof(m3DESC));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("KEY1", m3KEY1.Trim())
				.WithQueryParameter("INTN", m3INTN.Trim())
				.WithQueryParameter("DESC", m3DESC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());

			// Execute the request
			var result = await Execute<AddBatchHeadResponse>(
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
		/// Name AddBatchLine
		/// Description Add data to FGLINL
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3KEY1">Key value (Required)</param>
		/// <param name="m3LINE">Line number (Required)</param>
		/// <param name="m3PARM">Parameter value (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddBatchLineResponse></returns>
		/// <exception cref="M3Exception<AddBatchLineResponse>"></exception>
		public async Task<M3Response<AddBatchLineResponse>> AddBatchLine(
			int m3CONO, 
			string m3KEY1, 
			int m3LINE, 
			string m3PARM, 
			string m3DIVI = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddBatchLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3KEY1))
				throw new ArgumentNullException(nameof(m3KEY1));
			if (string.IsNullOrWhiteSpace(m3PARM))
				throw new ArgumentNullException(nameof(m3PARM));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("KEY1", m3KEY1.Trim())
				.WithQueryParameter("LINE", m3LINE.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PARM", m3PARM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<AddBatchLineResponse>(
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
		/// Name CtrlBatch
		/// Description Run option 6 from GLS840
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3KEY1">Key value (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CtrlBatchResponse></returns>
		/// <exception cref="M3Exception<CtrlBatchResponse>"></exception>
		public async Task<M3Response<CtrlBatchResponse>> CtrlBatch(
			int m3CONO, 
			string m3KEY1, 
			string m3DIVI = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CtrlBatch",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3KEY1))
				throw new ArgumentNullException(nameof(m3KEY1));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("KEY1", m3KEY1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<CtrlBatchResponse>(
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
		/// Name UpdBatch
		/// Description Run option 9 from GLS840
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3KEY1">Key value (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<UpdBatchResponse></returns>
		/// <exception cref="M3Exception<UpdBatchResponse>"></exception>
		public async Task<M3Response<UpdBatchResponse>> UpdBatch(
			int m3CONO, 
			string m3KEY1, 
			string m3DIVI = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdBatch",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3KEY1))
				throw new ArgumentNullException(nameof(m3KEY1));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("KEY1", m3KEY1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<UpdBatchResponse>(
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
