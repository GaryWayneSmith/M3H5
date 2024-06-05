/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.PPS010MI;
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
	/// Name: PPS010MI
	/// Component Name: Purchasing
	/// Description: Vendor transportation lead time interface
	/// Version Release: 5e90
	///</summary>
	public partial class PPS010MIResource : M3BaseResourceEndpoint
	{
		public PPS010MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PPS010MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddConnTranspLT
		/// Description Add Vendor transportation lead time
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3SUNO">Suppliernumber (Required)</param>
		/// <param name="m3TEDL">Deliveryterms (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3MODL">Deliverymethod</param>
		/// <param name="m3DELT">*** Not in use *** Goodsresponsibility</param>
		/// <param name="m3TLE1">Transportationleadtime1</param>
		/// <param name="m3TLE2">Transportationleadtime2</param>
		/// <param name="m3SDES">Place of loading</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddConnTranspLT(
			string m3SUNO, 
			string m3TEDL, 
			string m3WHLO, 
			string m3MODL = null, 
			int? m3DELT = null, 
			int? m3TLE1 = null, 
			int? m3TLE2 = null, 
			string m3SDES = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddConnTranspLT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3TEDL))
				throw new ArgumentNullException(nameof(m3TEDL));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("TEDL", m3TEDL.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (m3DELT.HasValue)
				request.WithQueryParameter("DELT", m3DELT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TLE1.HasValue)
				request.WithQueryParameter("TLE1", m3TLE1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TLE2.HasValue)
				request.WithQueryParameter("TLE2", m3TLE2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SDES))
				request.WithQueryParameter("SDES", m3SDES.Trim());

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
		/// Name DelConnTranspLT
		/// Description Delete Vendor transportation lead time
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3SUNO">Suppliernumber (Required)</param>
		/// <param name="m3TEDL">Deliveryterms (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3MODL">Deliverymethod</param>
		/// <param name="m3SDES">Place of loading</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelConnTranspLT(
			string m3SUNO, 
			string m3TEDL, 
			string m3WHLO, 
			string m3MODL = null, 
			string m3SDES = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelConnTranspLT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3TEDL))
				throw new ArgumentNullException(nameof(m3TEDL));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("TEDL", m3TEDL.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDES))
				request.WithQueryParameter("SDES", m3SDES.Trim());

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
		/// Name GetConnTranspLT
		/// Description Get Vendor transportation lead time
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3SUNO">Suppliernumber (Required)</param>
		/// <param name="m3TEDL">Deliveryterms (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3MODL">Deliverymethod</param>
		/// <param name="m3SDES">Place of loading</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetConnTranspLTResponse></returns>
		/// <exception cref="M3Exception<GetConnTranspLTResponse>"></exception>
		public async Task<M3Response<GetConnTranspLTResponse>> GetConnTranspLT(
			string m3SUNO, 
			string m3TEDL, 
			string m3WHLO, 
			string m3MODL = null, 
			string m3SDES = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetConnTranspLT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3TEDL))
				throw new ArgumentNullException(nameof(m3TEDL));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("TEDL", m3TEDL.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDES))
				request.WithQueryParameter("SDES", m3SDES.Trim());

			// Execute the request
			var result = await Execute<GetConnTranspLTResponse>(
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
		/// Name LstConnTranspLT
		/// Description List Vendor transportation lead time
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3SUNO">Suppliernumber (Required)</param>
		/// <param name="m3TEDL">Deliveryterms</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3MODL">Deliverymethod</param>
		/// <param name="m3SDES">Place of loading</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstConnTranspLTResponse></returns>
		/// <exception cref="M3Exception<LstConnTranspLTResponse>"></exception>
		public async Task<M3Response<LstConnTranspLTResponse>> LstConnTranspLT(
			string m3SUNO, 
			string m3TEDL = null, 
			string m3WHLO = null, 
			string m3MODL = null, 
			string m3SDES = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstConnTranspLT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDES))
				request.WithQueryParameter("SDES", m3SDES.Trim());

			// Execute the request
			var result = await Execute<LstConnTranspLTResponse>(
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
		/// Name UpdConnTranspLT
		/// Description Update Vendor transportation lead time
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3SUNO">Suppliernumber (Required)</param>
		/// <param name="m3TEDL">Deliveryterms (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3MODL">Deliverymethod</param>
		/// <param name="m3DELT">*** Not in use *** Goodsresponsibility</param>
		/// <param name="m3TLE1">Transportationleadtime1</param>
		/// <param name="m3TLE2">Transportationleadtime2</param>
		/// <param name="m3SDES">Place of loading</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdConnTranspLT(
			string m3SUNO, 
			string m3TEDL, 
			string m3WHLO, 
			string m3MODL = null, 
			int? m3DELT = null, 
			int? m3TLE1 = null, 
			int? m3TLE2 = null, 
			string m3SDES = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdConnTranspLT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3TEDL))
				throw new ArgumentNullException(nameof(m3TEDL));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("TEDL", m3TEDL.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (m3DELT.HasValue)
				request.WithQueryParameter("DELT", m3DELT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TLE1.HasValue)
				request.WithQueryParameter("TLE1", m3TLE1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TLE2.HasValue)
				request.WithQueryParameter("TLE2", m3TLE2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SDES))
				request.WithQueryParameter("SDES", m3SDES.Trim());

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
