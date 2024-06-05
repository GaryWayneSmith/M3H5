/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS945MI;
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
	/// Name: CRS945MI
	/// Component Name: Partner Reference
	/// Description: Api: Partner Reference
	/// Version Release: 5ea0
	///</summary>
	public partial class CRS945MIResource : M3BaseResourceEndpoint
	{
		public CRS945MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS945MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddPartnerRef
		/// Description Add new document/partner reference
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DONR">Document number (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="m3_MEPF">Media profile</param>
		/// <param name="m3_PRF1">Document/media controlling object 1</param>
		/// <param name="m3_PRF2">Document/media control object 2</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPartnerRef(
			string m3_DONR, 
			string m3_DIVI = null, 
			string m3_DOVA = null, 
			string m3_MEPF = null, 
			string m3_PRF1 = null, 
			string m3_PRF2 = null, 
			string m3_TX15 = null, 
			string m3_TX40 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPartnerRef",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DONR))
				throw new ArgumentNullException("m3_DONR");

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3_DONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEPF))
				request.WithQueryParameter("MEPF", m3_MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF1))
				request.WithQueryParameter("PRF1", m3_PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF2))
				request.WithQueryParameter("PRF2", m3_PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());

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
		/// Name DltPartnerRef
		/// Description Delete document/partner reference
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DONR">Document number (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="m3_MEPF">Media profile</param>
		/// <param name="m3_PRF1">Document/media controlling object 1</param>
		/// <param name="m3_PRF2">Document/media control object 2</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltPartnerRef(
			string m3_DONR, 
			string m3_DIVI = null, 
			string m3_DOVA = null, 
			string m3_MEPF = null, 
			string m3_PRF1 = null, 
			string m3_PRF2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltPartnerRef",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DONR))
				throw new ArgumentNullException("m3_DONR");

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3_DONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEPF))
				request.WithQueryParameter("MEPF", m3_MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF1))
				request.WithQueryParameter("PRF1", m3_PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF2))
				request.WithQueryParameter("PRF2", m3_PRF2.Trim());

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
		/// Name GetPartnerRef
		/// Description Get document/partner reference
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_DONR">Document number</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="m3_MEPF">Media profile</param>
		/// <param name="m3_PRF1">Document/media controlling object 1</param>
		/// <param name="m3_PRF2">Document/media control object 2</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPartnerRefResponse></returns>
		/// <exception cref="M3Exception<GetPartnerRefResponse>"></exception>
		public async Task<M3Response<GetPartnerRefResponse>> GetPartnerRef(
			string m3_DIVI = null, 
			string m3_DONR = null, 
			string m3_DOVA = null, 
			string m3_MEPF = null, 
			string m3_PRF1 = null, 
			string m3_PRF2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPartnerRef",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DONR))
				request.WithQueryParameter("DONR", m3_DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEPF))
				request.WithQueryParameter("MEPF", m3_MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF1))
				request.WithQueryParameter("PRF1", m3_PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF2))
				request.WithQueryParameter("PRF2", m3_PRF2.Trim());

			// Execute the request
			var result = await Execute<GetPartnerRefResponse>(
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
		/// Name LstPartnerRef
		/// Description List documents/partner reference records
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_DONR">Document number</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="m3_MEPF">Media profile</param>
		/// <param name="m3_PRF1">Document/media controlling object 1</param>
		/// <param name="m3_PRF2">Document/media control object 2</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPartnerRefResponse></returns>
		/// <exception cref="M3Exception<LstPartnerRefResponse>"></exception>
		public async Task<M3Response<LstPartnerRefResponse>> LstPartnerRef(
			string m3_DIVI = null, 
			string m3_DONR = null, 
			string m3_DOVA = null, 
			string m3_MEPF = null, 
			string m3_PRF1 = null, 
			string m3_PRF2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPartnerRef",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DONR))
				request.WithQueryParameter("DONR", m3_DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEPF))
				request.WithQueryParameter("MEPF", m3_MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF1))
				request.WithQueryParameter("PRF1", m3_PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF2))
				request.WithQueryParameter("PRF2", m3_PRF2.Trim());

			// Execute the request
			var result = await Execute<LstPartnerRefResponse>(
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
		/// Name UpdPartnerRef
		/// Description Update document/partner reference
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DONR">Document number (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="m3_MEPF">Media profile</param>
		/// <param name="m3_PRF1">Document/media controlling object 1</param>
		/// <param name="m3_PRF2">Document/media control object 2</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPartnerRef(
			string m3_DONR, 
			string m3_DIVI = null, 
			string m3_DOVA = null, 
			string m3_MEPF = null, 
			string m3_PRF1 = null, 
			string m3_PRF2 = null, 
			string m3_TX15 = null, 
			string m3_TX40 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdPartnerRef",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DONR))
				throw new ArgumentNullException("m3_DONR");

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3_DONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEPF))
				request.WithQueryParameter("MEPF", m3_MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF1))
				request.WithQueryParameter("PRF1", m3_PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF2))
				request.WithQueryParameter("PRF2", m3_PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());

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
