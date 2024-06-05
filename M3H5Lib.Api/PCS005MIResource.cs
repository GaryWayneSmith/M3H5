/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.PCS005MI;
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
	/// Name: PCS005MI
	/// Component Name: MAI
	/// Description: Cost Types
	/// Version Release: 14.x
	///</summary>
	public partial class PCS005MIResource : M3BaseResourceEndpoint
	{
		public PCS005MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PCS005MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 14
		/// </summary>
		/// <param name="m3PCTP">Costing type (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3REUP">Update permitted</param>
		/// <param name="m3SIMA">Permit simulation</param>
		/// <param name="m3RECI">Recalculation at inquiry</param>
		/// <param name="m3CSUR">Distribute order costs on order qty</param>
		/// <param name="m3SCOT">Substituting costing type</param>
		/// <param name="m3OCRT">Exchange rate type</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3PCTP, 
			string m3TX40, 
			string m3TX15 = null, 
			int? m3REUP = null, 
			int? m3SIMA = null, 
			int? m3RECI = null, 
			int? m3CSUR = null, 
			string m3SCOT = null, 
			int? m3OCRT = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PCTP))
				throw new ArgumentNullException(nameof(m3PCTP));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("PCTP", m3PCTP.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3REUP.HasValue)
				request.WithQueryParameter("REUP", m3REUP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SIMA.HasValue)
				request.WithQueryParameter("SIMA", m3SIMA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RECI.HasValue)
				request.WithQueryParameter("RECI", m3RECI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CSUR.HasValue)
				request.WithQueryParameter("CSUR", m3CSUR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCOT))
				request.WithQueryParameter("SCOT", m3SCOT.Trim());
			if (m3OCRT.HasValue)
				request.WithQueryParameter("OCRT", m3OCRT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Del
		/// Description Delete
		/// Version Release: 14
		/// </summary>
		/// <param name="m3PCTP">Costing type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			string m3PCTP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Del",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PCTP))
				request.WithQueryParameter("PCTP", m3PCTP.Trim());

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
		/// Name Get
		/// Description Get
		/// Version Release: 14
		/// </summary>
		/// <param name="m3PCTP">Costing type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3PCTP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Get",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PCTP))
				request.WithQueryParameter("PCTP", m3PCTP.Trim());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name Lst
		/// Description List
		/// Version Release: 14
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Lst",
			};

			// Execute the request
			var result = await Execute<LstResponse>(
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
		/// Name Upd
		/// Description Update
		/// Version Release: 14
		/// </summary>
		/// <param name="m3PCTP">Costing type</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3REUP">Update permitted</param>
		/// <param name="m3SIMA">Permit simulation</param>
		/// <param name="m3RECI">Recalculation at inquiry</param>
		/// <param name="m3CSUR">Distribute order costs on order qty</param>
		/// <param name="m3SCOT">Substituting costing type</param>
		/// <param name="m3OCRT">Exchange rate type</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3PCTP = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			int? m3REUP = null, 
			int? m3SIMA = null, 
			int? m3RECI = null, 
			int? m3CSUR = null, 
			string m3SCOT = null, 
			int? m3OCRT = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Upd",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PCTP))
				request.WithQueryParameter("PCTP", m3PCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3REUP.HasValue)
				request.WithQueryParameter("REUP", m3REUP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SIMA.HasValue)
				request.WithQueryParameter("SIMA", m3SIMA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RECI.HasValue)
				request.WithQueryParameter("RECI", m3RECI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CSUR.HasValue)
				request.WithQueryParameter("CSUR", m3CSUR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCOT))
				request.WithQueryParameter("SCOT", m3SCOT.Trim());
			if (m3OCRT.HasValue)
				request.WithQueryParameter("OCRT", m3OCRT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
