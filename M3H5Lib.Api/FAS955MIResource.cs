/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.FAS955MI;
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
	/// Name: FAS955MI
	/// Component Name: Financials
	/// Description: Api: depreication type IPNC
	/// Version Release: 5ea0
	///</summary>
	public partial class FAS955MIResource : M3BaseResourceEndpoint
	{
		public FAS955MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "FAS955MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddDepTpNCPI
		/// Description Creates depreciation type for NCPI
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_DPTP">Depreciation type (Required)</param>
		/// <param name="m3_CVTP">Cost adjustment value type (Required)</param>
		/// <param name="m3_PDVT">Previous years depreciation (Required)</param>
		/// <param name="m3_YVTP">Year-to-date depciation value (Required)</param>
		/// <param name="m3_IXTB">Index table (Required)</param>
		/// <param name="m3_UPFC">Update factor</param>
		/// <param name="m3_ADCS">Adjust cost</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDepTpNCPI(
			string m3_DIVI, 
			int m3_DPTP, 
			int m3_CVTP, 
			int m3_PDVT, 
			int m3_YVTP, 
			string m3_IXTB, 
			int? m3_UPFC = null, 
			int? m3_ADCS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddDepTpNCPI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_IXTB))
				throw new ArgumentNullException("m3_IXTB");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("DPTP", m3_DPTP.ToString())
				.WithQueryParameter("CVTP", m3_CVTP.ToString())
				.WithQueryParameter("PDVT", m3_PDVT.ToString())
				.WithQueryParameter("YVTP", m3_YVTP.ToString())
				.WithQueryParameter("IXTB", m3_IXTB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_UPFC.HasValue)
				request.WithQueryParameter("UPFC", m3_UPFC.Value.ToString());
			if (m3_ADCS.HasValue)
				request.WithQueryParameter("ADCS", m3_ADCS.Value.ToString());

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
		/// Name CpyDepTpNCPI
		/// Description Copy data for a depreciation type NCPI
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_DPTP">Depreciation type (Required)</param>
		/// <param name="m3_CPDT">Depreciation type - copy to (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyDepTpNCPI(
			string m3_DIVI, 
			int m3_DPTP, 
			int m3_CPDT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyDepTpNCPI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("DPTP", m3_DPTP.ToString())
				.WithQueryParameter("CPDT", m3_CPDT.ToString());

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
		/// Name DltDepTpNCPI
		/// Description delets data for a depreciation type NCPI
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_DPTP">Depreciation type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltDepTpNCPI(
			string m3_DIVI, 
			int m3_DPTP, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltDepTpNCPI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("DPTP", m3_DPTP.ToString());

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
		/// Name GetDepTpNCPI
		/// Description Gets data for a depreciation type NCPI
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_DPTP">Depreciation type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDepTpNCPIResponse></returns>
		/// <exception cref="M3Exception<GetDepTpNCPIResponse>"></exception>
		public async Task<M3Response<GetDepTpNCPIResponse>> GetDepTpNCPI(
			string m3_DIVI, 
			int m3_DPTP, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDepTpNCPI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("DPTP", m3_DPTP.ToString());

			// Execute the request
			var result = await Execute<GetDepTpNCPIResponse>(
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
		/// Name LstDepTpNCPI
		/// Description Lists data for depreciation types
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_DPTP">Depreciation type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDepTpNCPIResponse></returns>
		/// <exception cref="M3Exception<LstDepTpNCPIResponse>"></exception>
		public async Task<M3Response<LstDepTpNCPIResponse>> LstDepTpNCPI(
			string m3_DIVI, 
			int? m3_DPTP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDepTpNCPI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DPTP.HasValue)
				request.WithQueryParameter("DPTP", m3_DPTP.Value.ToString());

			// Execute the request
			var result = await Execute<LstDepTpNCPIResponse>(
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
		/// Name UpdDepTpNCPI
		/// Description Updates data for a value deciation type setup for NCPI
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_DPTP">Depreciation type (Required)</param>
		/// <param name="m3_CVTP">Cost adjustment value type (Required)</param>
		/// <param name="m3_PDVT">Previous years depreciation (Required)</param>
		/// <param name="m3_YVTP">Year-to-date depciation value (Required)</param>
		/// <param name="m3_IXTB">Index table (Required)</param>
		/// <param name="m3_UPFC">Update factor</param>
		/// <param name="m3_ADCS">Adjust cost</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdDepTpNCPI(
			string m3_DIVI, 
			int m3_DPTP, 
			int m3_CVTP, 
			int m3_PDVT, 
			int m3_YVTP, 
			string m3_IXTB, 
			int? m3_UPFC = null, 
			int? m3_ADCS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdDepTpNCPI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_IXTB))
				throw new ArgumentNullException("m3_IXTB");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("DPTP", m3_DPTP.ToString())
				.WithQueryParameter("CVTP", m3_CVTP.ToString())
				.WithQueryParameter("PDVT", m3_PDVT.ToString())
				.WithQueryParameter("YVTP", m3_YVTP.ToString())
				.WithQueryParameter("IXTB", m3_IXTB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_UPFC.HasValue)
				request.WithQueryParameter("UPFC", m3_UPFC.Value.ToString());
			if (m3_ADCS.HasValue)
				request.WithQueryParameter("ADCS", m3_ADCS.Value.ToString());

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
	}
}
// EOF
