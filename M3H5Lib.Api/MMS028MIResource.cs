/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MMS028MI;
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
	/// Name: MMS028MI
	/// Component Name: Composition
	/// Description: Composition interface
	/// Version Release: 5ea0
	///</summary>
	public partial class MMS028MIResource : M3BaseResourceEndpoint
	{
		public MMS028MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS028MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddComposition
		/// Description Add a composition
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_XCDE">Composition (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_SCNM">Scientific name</param>
		/// <param name="m3_MISC">Miscellaneous</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddComposition(
			string m3_XCDE, 
			string m3_TX40, 
			string m3_LNCD = null, 
			string m3_TX15 = null, 
			string m3_SCNM = null, 
			string m3_MISC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddComposition",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_XCDE))
				throw new ArgumentNullException("m3_XCDE");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("XCDE", m3_XCDE.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCNM))
				request.WithQueryParameter("SCNM", m3_SCNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MISC))
				request.WithQueryParameter("MISC", m3_MISC.Trim());

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
		/// Name DltComposition
		/// Description Delete a composition
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_XCDE">Composition (Required)</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltComposition(
			string m3_XCDE, 
			string m3_LNCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltComposition",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_XCDE))
				throw new ArgumentNullException("m3_XCDE");

			// Set mandatory parameters
			request
				.WithQueryParameter("XCDE", m3_XCDE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

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
		/// Name GetComposition
		/// Description Get data for a composition
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_XCDE">Composition (Required)</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCompositionResponse></returns>
		/// <exception cref="M3Exception<GetCompositionResponse>"></exception>
		public async Task<M3Response<GetCompositionResponse>> GetComposition(
			string m3_XCDE, 
			string m3_LNCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetComposition",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_XCDE))
				throw new ArgumentNullException("m3_XCDE");

			// Set mandatory parameters
			request
				.WithQueryParameter("XCDE", m3_XCDE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<GetCompositionResponse>(
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
		/// Name LstComposition
		/// Description List data for composition
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_XCDE">Composition (Required)</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCompositionResponse></returns>
		/// <exception cref="M3Exception<LstCompositionResponse>"></exception>
		public async Task<M3Response<LstCompositionResponse>> LstComposition(
			string m3_XCDE, 
			string m3_LNCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstComposition",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_XCDE))
				throw new ArgumentNullException("m3_XCDE");

			// Set mandatory parameters
			request
				.WithQueryParameter("XCDE", m3_XCDE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<LstCompositionResponse>(
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
		/// Name UpdComposition
		/// Description Update data for a composition
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_XCDE">Composition (Required)</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_SCNM">Scientific name</param>
		/// <param name="m3_MISC">Miscellaneous</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdComposition(
			string m3_XCDE, 
			string m3_LNCD = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_SCNM = null, 
			string m3_MISC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdComposition",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_XCDE))
				throw new ArgumentNullException("m3_XCDE");

			// Set mandatory parameters
			request
				.WithQueryParameter("XCDE", m3_XCDE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCNM))
				request.WithQueryParameter("SCNM", m3_SCNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MISC))
				request.WithQueryParameter("MISC", m3_MISC.Trim());

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
