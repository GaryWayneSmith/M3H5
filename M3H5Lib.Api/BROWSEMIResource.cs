/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.BROWSEMI;
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
	/// Name: BROWSEMI
	/// Component Name: Browse
	/// Description: Browse functionality for clients
	/// Version Release: 6400
	///</summary>
	public partial class BROWSEMIResource : M3BaseResourceEndpoint
	{
		public BROWSEMIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "BROWSEMI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetBrowseParms
		/// Description Get browse parameters
		/// Version Release: 6400
		/// </summary>
		/// <param name="m3_RFLD">Reference field (Required)</param>
		/// <param name="m3_VARI">Browse variant</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBrowseParmsResponse></returns>
		/// <exception cref="M3Exception<GetBrowseParmsResponse>"></exception>
		public async Task<M3Response<GetBrowseParmsResponse>> GetBrowseParms(
			string m3_RFLD, 
			string m3_VARI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBrowseParms",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RFLD))
				throw new ArgumentNullException("m3_RFLD");

			// Set mandatory parameters
			request
				.WithQueryParameter("RFLD", m3_RFLD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_VARI))
				request.WithQueryParameter("VARI", m3_VARI.Trim());

			// Execute the request
			var result = await Execute<GetBrowseParmsResponse>(
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
		/// Name LstBrowseParms
		/// Description Listbrowse parameters
		/// Version Release: 6400
		/// </summary>
		/// <param name="m3_RFLD">Reference field (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBrowseParmsResponse></returns>
		/// <exception cref="M3Exception<LstBrowseParmsResponse>"></exception>
		public async Task<M3Response<LstBrowseParmsResponse>> LstBrowseParms(
			string m3_RFLD, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBrowseParms",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RFLD))
				throw new ArgumentNullException("m3_RFLD");

			// Set mandatory parameters
			request
				.WithQueryParameter("RFLD", m3_RFLD.Trim());

			// Execute the request
			var result = await Execute<LstBrowseParmsResponse>(
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
		/// Name LstBrowseVals
		/// Description List the browse values
		/// Version Release: 6400
		/// </summary>
		/// <param name="m3_RFLD">Reference field (Required)</param>
		/// <param name="m3_VARI">Optional browse variant</param>
		/// <param name="m3_DIVI">Possible filter on Division</param>
		/// <param name="m3_ITNO">Possible filter on Item number</param>
		/// <param name="m3_LNCD">Possible filter on Language (CSYTAB)</param>
		/// <param name="m3_KEY3">Possible third key</param>
		/// <param name="m3_POSN">Optional positional value (Alpha or Numeric)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBrowseValsResponse></returns>
		/// <exception cref="M3Exception<LstBrowseValsResponse>"></exception>
		public async Task<M3Response<LstBrowseValsResponse>> LstBrowseVals(
			string m3_RFLD, 
			string m3_VARI = null, 
			string m3_DIVI = null, 
			string m3_ITNO = null, 
			string m3_LNCD = null, 
			string m3_KEY3 = null, 
			string m3_POSN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBrowseVals",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RFLD))
				throw new ArgumentNullException("m3_RFLD");

			// Set mandatory parameters
			request
				.WithQueryParameter("RFLD", m3_RFLD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_VARI))
				request.WithQueryParameter("VARI", m3_VARI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY3))
				request.WithQueryParameter("KEY3", m3_KEY3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POSN))
				request.WithQueryParameter("POSN", m3_POSN.Trim());

			// Execute the request
			var result = await Execute<LstBrowseValsResponse>(
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
		/// Name LstRefFields
		/// Description List reference fields
		/// Version Release: 6400
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRefFieldsResponse></returns>
		/// <exception cref="M3Exception<LstRefFieldsResponse>"></exception>
		public async Task<M3Response<LstRefFieldsResponse>> LstRefFields(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstRefFields",
			};

			// Execute the request
			var result = await Execute<LstRefFieldsResponse>(
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
