/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.SPS100MI;
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
	/// Name: SPS100MI
	/// Component Name: SupplyChainPlannerVersions
	/// Description: SCP versions interface
	/// Version Release: 12.0
	///</summary>
	public partial class SPS100MIResource : M3BaseResourceEndpoint
	{
		public SPS100MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "SPS100MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Select
		/// Description Select SCP Versions per Company
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3FCON">From Company (Required)</param>
		/// <param name="m3TCON">To Company (Required)</param>
		/// <param name="m3FSCV">From SCP Version (Required)</param>
		/// <param name="m3TSCV">To SCP Version (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectResponse></returns>
		/// <exception cref="M3Exception<SelectResponse>"></exception>
		public async Task<M3Response<SelectResponse>> Select(
			int m3FCON, 
			int m3TCON, 
			string m3FSCV, 
			string m3TSCV, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Select",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FSCV))
				throw new ArgumentNullException(nameof(m3FSCV));
			if (string.IsNullOrWhiteSpace(m3TSCV))
				throw new ArgumentNullException(nameof(m3TSCV));

			// Set mandatory parameters
			request
				.WithQueryParameter("FCON", m3FCON.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TCON", m3TCON.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FSCV", m3FSCV.Trim())
				.WithQueryParameter("TSCV", m3TSCV.Trim());

			// Execute the request
			var result = await Execute<SelectResponse>(
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
		/// Name SelectYOP
		/// Description Select YOP Versions per Company
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3FCON">From Company (Required)</param>
		/// <param name="m3TCON">To Company (Required)</param>
		/// <param name="m3FSCV">From YOP Version (Required)</param>
		/// <param name="m3TSCV">To YOP Version (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectYOPResponse></returns>
		/// <exception cref="M3Exception<SelectYOPResponse>"></exception>
		public async Task<M3Response<SelectYOPResponse>> SelectYOP(
			int m3FCON, 
			int m3TCON, 
			string m3FSCV, 
			string m3TSCV, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelectYOP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FSCV))
				throw new ArgumentNullException(nameof(m3FSCV));
			if (string.IsNullOrWhiteSpace(m3TSCV))
				throw new ArgumentNullException(nameof(m3TSCV));

			// Set mandatory parameters
			request
				.WithQueryParameter("FCON", m3FCON.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TCON", m3TCON.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FSCV", m3FSCV.Trim())
				.WithQueryParameter("TSCV", m3TSCV.Trim());

			// Execute the request
			var result = await Execute<SelectYOPResponse>(
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
