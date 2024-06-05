/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.COS406MI;
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
	/// Name: COS406MI
	/// Component Name: Agreement type
	/// Description: Agreement type interface
	/// Version Release: 5e90
	///</summary>
	public partial class COS406MIResource : M3BaseResourceEndpoint
	{
		public COS406MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "COS406MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAgrType
		/// Description AddAgrType
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3AGTP">Agreement type (Required)</param>
		/// <param name="m3LSCD">Service stop</param>
		/// <param name="m3ILCD">Invoice block</param>
		/// <param name="m3IIYR">Invoicing interval - years</param>
		/// <param name="m3IIMO">Invoicing interval - months</param>
		/// <param name="m3IIDA">Invoicing interval - days</param>
		/// <param name="m3INVM">Invoicing method</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAgrType(
			string m3AGTP, 
			int? m3LSCD = null, 
			int? m3ILCD = null, 
			int? m3IIYR = null, 
			int? m3IIMO = null, 
			int? m3IIDA = null, 
			string m3INVM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAgrType",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGTP))
				throw new ArgumentNullException(nameof(m3AGTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGTP", m3AGTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3LSCD.HasValue)
				request.WithQueryParameter("LSCD", m3LSCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ILCD.HasValue)
				request.WithQueryParameter("ILCD", m3ILCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIYR.HasValue)
				request.WithQueryParameter("IIYR", m3IIYR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIMO.HasValue)
				request.WithQueryParameter("IIMO", m3IIMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIDA.HasValue)
				request.WithQueryParameter("IIDA", m3IIDA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INVM))
				request.WithQueryParameter("INVM", m3INVM.Trim());

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
		/// Name DltAgrType
		/// Description DltAgrType
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3AGTP">Agreement type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAgrType(
			string m3AGTP, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltAgrType",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGTP))
				throw new ArgumentNullException(nameof(m3AGTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGTP", m3AGTP.Trim());

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
		/// Name GetAgrType
		/// Description GetAgrType
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3AGTP">Agreement type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgrTypeResponse></returns>
		/// <exception cref="M3Exception<GetAgrTypeResponse>"></exception>
		public async Task<M3Response<GetAgrTypeResponse>> GetAgrType(
			string m3AGTP, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAgrType",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGTP))
				throw new ArgumentNullException(nameof(m3AGTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGTP", m3AGTP.Trim());

			// Execute the request
			var result = await Execute<GetAgrTypeResponse>(
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
		/// Name LstAgrType
		/// Description LstAgrType
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3AGTP">Agreement type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrTypeResponse></returns>
		/// <exception cref="M3Exception<LstAgrTypeResponse>"></exception>
		public async Task<M3Response<LstAgrTypeResponse>> LstAgrType(
			string m3AGTP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgrType",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AGTP))
				request.WithQueryParameter("AGTP", m3AGTP.Trim());

			// Execute the request
			var result = await Execute<LstAgrTypeResponse>(
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
		/// Name UpdAgrType
		/// Description UpdAgrType
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3AGTP">Agreement type</param>
		/// <param name="m3LSCD">Service stop</param>
		/// <param name="m3ILCD">Invoice block</param>
		/// <param name="m3IIYR">Invoicing interval - years</param>
		/// <param name="m3IIMO">Invoicing interval - months</param>
		/// <param name="m3IIDA">Invoicing interval - days</param>
		/// <param name="m3INVM">Invoicing method</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAgrType(
			string m3AGTP = null, 
			int? m3LSCD = null, 
			int? m3ILCD = null, 
			int? m3IIYR = null, 
			int? m3IIMO = null, 
			int? m3IIDA = null, 
			string m3INVM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdAgrType",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AGTP))
				request.WithQueryParameter("AGTP", m3AGTP.Trim());
			if (m3LSCD.HasValue)
				request.WithQueryParameter("LSCD", m3LSCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ILCD.HasValue)
				request.WithQueryParameter("ILCD", m3ILCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIYR.HasValue)
				request.WithQueryParameter("IIYR", m3IIYR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIMO.HasValue)
				request.WithQueryParameter("IIMO", m3IIMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIDA.HasValue)
				request.WithQueryParameter("IIDA", m3IIDA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INVM))
				request.WithQueryParameter("INVM", m3INVM.Trim());

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
