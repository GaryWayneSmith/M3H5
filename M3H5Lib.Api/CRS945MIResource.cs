/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddPartnerRef
		/// Description Add new document/partner reference
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DONR">Document number (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="m3MEPF">Media profile</param>
		/// <param name="m3PRF1">Document/media controlling object 1</param>
		/// <param name="m3PRF2">Document/media control object 2</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPartnerRef(
			string m3DONR, 
			string m3DIVI = null, 
			string m3DOVA = null, 
			string m3MEPF = null, 
			string m3PRF1 = null, 
			string m3PRF2 = null, 
			string m3TX15 = null, 
			string m3TX40 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddPartnerRef",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DONR))
				throw new ArgumentNullException(nameof(m3DONR));

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3DONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEPF))
				request.WithQueryParameter("MEPF", m3MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF1))
				request.WithQueryParameter("PRF1", m3PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF2))
				request.WithQueryParameter("PRF2", m3PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());

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
		/// Name DltPartnerRef
		/// Description Delete document/partner reference
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DONR">Document number (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="m3MEPF">Media profile</param>
		/// <param name="m3PRF1">Document/media controlling object 1</param>
		/// <param name="m3PRF2">Document/media control object 2</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltPartnerRef(
			string m3DONR, 
			string m3DIVI = null, 
			string m3DOVA = null, 
			string m3MEPF = null, 
			string m3PRF1 = null, 
			string m3PRF2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltPartnerRef",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DONR))
				throw new ArgumentNullException(nameof(m3DONR));

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3DONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEPF))
				request.WithQueryParameter("MEPF", m3MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF1))
				request.WithQueryParameter("PRF1", m3PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF2))
				request.WithQueryParameter("PRF2", m3PRF2.Trim());

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
		/// Name GetPartnerRef
		/// Description Get document/partner reference
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3DONR">Document number</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="m3MEPF">Media profile</param>
		/// <param name="m3PRF1">Document/media controlling object 1</param>
		/// <param name="m3PRF2">Document/media control object 2</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPartnerRefResponse></returns>
		/// <exception cref="M3Exception<GetPartnerRefResponse>"></exception>
		public async Task<M3Response<GetPartnerRefResponse>> GetPartnerRef(
			string m3DIVI = null, 
			string m3DONR = null, 
			string m3DOVA = null, 
			string m3MEPF = null, 
			string m3PRF1 = null, 
			string m3PRF2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetPartnerRef",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3DONR))
				request.WithQueryParameter("DONR", m3DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEPF))
				request.WithQueryParameter("MEPF", m3MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF1))
				request.WithQueryParameter("PRF1", m3PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF2))
				request.WithQueryParameter("PRF2", m3PRF2.Trim());

			// Execute the request
			var result = await Execute<GetPartnerRefResponse>(
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
		/// Name LstPartnerRef
		/// Description List documents/partner reference records
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3DONR">Document number</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="m3MEPF">Media profile</param>
		/// <param name="m3PRF1">Document/media controlling object 1</param>
		/// <param name="m3PRF2">Document/media control object 2</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPartnerRefResponse></returns>
		/// <exception cref="M3Exception<LstPartnerRefResponse>"></exception>
		public async Task<M3Response<LstPartnerRefResponse>> LstPartnerRef(
			string m3DIVI = null, 
			string m3DONR = null, 
			string m3DOVA = null, 
			string m3MEPF = null, 
			string m3PRF1 = null, 
			string m3PRF2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPartnerRef",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3DONR))
				request.WithQueryParameter("DONR", m3DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEPF))
				request.WithQueryParameter("MEPF", m3MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF1))
				request.WithQueryParameter("PRF1", m3PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF2))
				request.WithQueryParameter("PRF2", m3PRF2.Trim());

			// Execute the request
			var result = await Execute<LstPartnerRefResponse>(
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
		/// Name UpdPartnerRef
		/// Description Update document/partner reference
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DONR">Document number (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="m3MEPF">Media profile</param>
		/// <param name="m3PRF1">Document/media controlling object 1</param>
		/// <param name="m3PRF2">Document/media control object 2</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPartnerRef(
			string m3DONR, 
			string m3DIVI = null, 
			string m3DOVA = null, 
			string m3MEPF = null, 
			string m3PRF1 = null, 
			string m3PRF2 = null, 
			string m3TX15 = null, 
			string m3TX40 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdPartnerRef",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DONR))
				throw new ArgumentNullException(nameof(m3DONR));

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3DONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEPF))
				request.WithQueryParameter("MEPF", m3MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF1))
				request.WithQueryParameter("PRF1", m3PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF2))
				request.WithQueryParameter("PRF2", m3PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());

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
