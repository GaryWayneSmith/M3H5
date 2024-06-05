/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.CSS720MI;
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
	/// Name: CSS720MI
	/// Component Name: Sales
	/// Description: Api: Sup Related Process.Connect Ref Type
	/// Version Release: 
	///</summary>
	public partial class CSS720MIResource : M3BaseResourceEndpoint
	{
		public CSS720MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CSS720MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddRefType
		/// Description Add Reference Type For Process
		/// Version Release: 
		/// </summary>
		/// <param name="m3EIPI">Process id (Required)</param>
		/// <param name="m3CSRT">Supplier reference type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddRefType(
			string m3EIPI, 
			int m3CSRT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddRefType",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EIPI))
				throw new ArgumentNullException(nameof(m3EIPI));

			// Set mandatory parameters
			request
				.WithQueryParameter("EIPI", m3EIPI.Trim())
				.WithQueryParameter("CSRT", m3CSRT.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltRefType
		/// Description Delete Reference Type
		/// Version Release: 
		/// </summary>
		/// <param name="m3EIPI">Process id</param>
		/// <param name="m3CSRT">Supplier reference type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltRefType(
			string m3EIPI = null, 
			int? m3CSRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltRefType",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EIPI))
				request.WithQueryParameter("EIPI", m3EIPI.Trim());
			if (m3CSRT.HasValue)
				request.WithQueryParameter("CSRT", m3CSRT.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name LstByProcess
		/// Description List Reference Type By Process
		/// Version Release: 
		/// </summary>
		/// <param name="m3EIPI">Process id (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByProcessResponse></returns>
		/// <exception cref="M3Exception<LstByProcessResponse>"></exception>
		public async Task<M3Response<LstByProcessResponse>> LstByProcess(
			string m3EIPI, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByProcess",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EIPI))
				throw new ArgumentNullException(nameof(m3EIPI));

			// Set mandatory parameters
			request
				.WithQueryParameter("EIPI", m3EIPI.Trim());

			// Execute the request
			var result = await Execute<LstByProcessResponse>(
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
