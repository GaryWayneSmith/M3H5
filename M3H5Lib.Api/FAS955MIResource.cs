/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3DPTP">Depreciation type (Required)</param>
		/// <param name="m3CVTP">Cost adjustment value type (Required)</param>
		/// <param name="m3PDVT">Previous years depreciation (Required)</param>
		/// <param name="m3YVTP">Year-to-date depciation value (Required)</param>
		/// <param name="m3IXTB">Index table (Required)</param>
		/// <param name="m3UPFC">Update factor</param>
		/// <param name="m3ADCS">Adjust cost</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDepTpNCPI(
			string m3DIVI, 
			int m3DPTP, 
			int m3CVTP, 
			int m3PDVT, 
			int m3YVTP, 
			string m3IXTB, 
			int? m3UPFC = null, 
			int? m3ADCS = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3IXTB))
				throw new ArgumentNullException(nameof(m3IXTB));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("DPTP", m3DPTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CVTP", m3CVTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PDVT", m3PDVT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("YVTP", m3YVTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("IXTB", m3IXTB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3UPFC.HasValue)
				request.WithQueryParameter("UPFC", m3UPFC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADCS.HasValue)
				request.WithQueryParameter("ADCS", m3ADCS.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name CpyDepTpNCPI
		/// Description Copy data for a depreciation type NCPI
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3DPTP">Depreciation type (Required)</param>
		/// <param name="m3CPDT">Depreciation type - copy to (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyDepTpNCPI(
			string m3DIVI, 
			int m3DPTP, 
			int m3CPDT, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("DPTP", m3DPTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CPDT", m3CPDT.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltDepTpNCPI
		/// Description delets data for a depreciation type NCPI
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3DPTP">Depreciation type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltDepTpNCPI(
			string m3DIVI, 
			int m3DPTP, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("DPTP", m3DPTP.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetDepTpNCPI
		/// Description Gets data for a depreciation type NCPI
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3DPTP">Depreciation type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDepTpNCPIResponse></returns>
		/// <exception cref="M3Exception<GetDepTpNCPIResponse>"></exception>
		public async Task<M3Response<GetDepTpNCPIResponse>> GetDepTpNCPI(
			string m3DIVI, 
			int m3DPTP, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("DPTP", m3DPTP.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetDepTpNCPIResponse>(
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
		/// Name LstDepTpNCPI
		/// Description Lists data for depreciation types
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3DPTP">Depreciation type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDepTpNCPIResponse></returns>
		/// <exception cref="M3Exception<LstDepTpNCPIResponse>"></exception>
		public async Task<M3Response<LstDepTpNCPIResponse>> LstDepTpNCPI(
			string m3DIVI, 
			int? m3DPTP = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3DPTP.HasValue)
				request.WithQueryParameter("DPTP", m3DPTP.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstDepTpNCPIResponse>(
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
		/// Name UpdDepTpNCPI
		/// Description Updates data for a value deciation type setup for NCPI
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3DPTP">Depreciation type (Required)</param>
		/// <param name="m3CVTP">Cost adjustment value type (Required)</param>
		/// <param name="m3PDVT">Previous years depreciation (Required)</param>
		/// <param name="m3YVTP">Year-to-date depciation value (Required)</param>
		/// <param name="m3IXTB">Index table (Required)</param>
		/// <param name="m3UPFC">Update factor</param>
		/// <param name="m3ADCS">Adjust cost</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdDepTpNCPI(
			string m3DIVI, 
			int m3DPTP, 
			int m3CVTP, 
			int m3PDVT, 
			int m3YVTP, 
			string m3IXTB, 
			int? m3UPFC = null, 
			int? m3ADCS = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3IXTB))
				throw new ArgumentNullException(nameof(m3IXTB));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("DPTP", m3DPTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CVTP", m3CVTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PDVT", m3PDVT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("YVTP", m3YVTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("IXTB", m3IXTB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3UPFC.HasValue)
				request.WithQueryParameter("UPFC", m3UPFC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADCS.HasValue)
				request.WithQueryParameter("ADCS", m3ADCS.Value.ToString(CultureInfo.CurrentCulture));

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
