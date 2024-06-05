/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MMS472MI;
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
	/// Name: MMS472MI
	/// Component Name: Sublot
	/// Description: Sublot interface
	/// Version Release: 5ea1
	///</summary>
	public partial class MMS472MIResource : M3BaseResourceEndpoint
	{
		public MMS472MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS472MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddSublot
		/// Description AddSublot
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_BANO">Lot number (Required)</param>
		/// <param name="m3_BANS">Sublot ID (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_BANT">Reference sublot id (Required)</param>
		/// <param name="m3_DIPA">Disconnected package</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_SSTS">Sublot status</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_CRDT">Creation date</param>
		/// <param name="m3_CRTE">Creation time</param>
		/// <param name="m3_SBBN">Sublot batch number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddSublotResponse></returns>
		/// <exception cref="M3Exception<AddSublotResponse>"></exception>
		public async Task<M3Response<AddSublotResponse>> AddSublot(
			string m3_ITNO, 
			string m3_BANO, 
			int m3_BANS, 
			string m3_WHLO, 
			string m3_BANT, 
			int? m3_DIPA = null, 
			string m3_WHSL = null, 
			decimal? m3_DLIX = null, 
			string m3_CAMU = null, 
			string m3_SSTS = null, 
			decimal? m3_CAWE = null, 
			DateTime? m3_CRDT = null, 
			int? m3_CRTE = null, 
			string m3_SBBN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSublot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_BANT))
				throw new ArgumentNullException("m3_BANT");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("BANO", m3_BANO.Trim())
				.WithQueryParameter("BANS", m3_BANS.ToString())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("BANT", m3_BANT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DIPA.HasValue)
				request.WithQueryParameter("DIPA", m3_DIPA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSTS))
				request.WithQueryParameter("SSTS", m3_SSTS.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (m3_CRDT.HasValue)
				request.WithQueryParameter("CRDT", m3_CRDT.Value.ToM3String());
			if (m3_CRTE.HasValue)
				request.WithQueryParameter("CRTE", m3_CRTE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SBBN))
				request.WithQueryParameter("SBBN", m3_SBBN.Trim());

			// Execute the request
			var result = await Execute<AddSublotResponse>(
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
		/// Name DltSublot
		/// Description DltSublot
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_BANO">Lot number (Required)</param>
		/// <param name="m3_BANS">Sublot ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltSublot(
			string m3_ITNO, 
			string m3_BANO, 
			int m3_BANS, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltSublot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("BANO", m3_BANO.Trim())
				.WithQueryParameter("BANS", m3_BANS.ToString());

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
		/// Name GetSublot
		/// Description GetSublot
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_BANO">Lot number (Required)</param>
		/// <param name="m3_BANS">Sublot ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSublotResponse></returns>
		/// <exception cref="M3Exception<GetSublotResponse>"></exception>
		public async Task<M3Response<GetSublotResponse>> GetSublot(
			string m3_ITNO, 
			string m3_BANO, 
			int m3_BANS, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSublot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("BANO", m3_BANO.Trim())
				.WithQueryParameter("BANS", m3_BANS.ToString());

			// Execute the request
			var result = await Execute<GetSublotResponse>(
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
		/// Name LstSelect
		/// Description LstSelect
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_BANS">Sublot ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSelectResponse></returns>
		/// <exception cref="M3Exception<LstSelectResponse>"></exception>
		public async Task<M3Response<LstSelectResponse>> LstSelect(
			string m3_WHLO, 
			string m3_ITNO, 
			string m3_BANO = null, 
			int? m3_BANS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSelect",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_BANS.HasValue)
				request.WithQueryParameter("BANS", m3_BANS.Value.ToString());

			// Execute the request
			var result = await Execute<LstSelectResponse>(
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
		/// Name LstSublot
		/// Description LstSublot
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_BANO">Lot number (Required)</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANS">Sublot ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSublotResponse></returns>
		/// <exception cref="M3Exception<LstSublotResponse>"></exception>
		public async Task<M3Response<LstSublotResponse>> LstSublot(
			string m3_BANO, 
			string m3_ITNO = null, 
			int? m3_BANS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSublot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("BANO", m3_BANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_BANS.HasValue)
				request.WithQueryParameter("BANS", m3_BANS.Value.ToString());

			// Execute the request
			var result = await Execute<LstSublotResponse>(
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
		/// Name UpdSublot
		/// Description UpdSublot
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_BANO">Lot number (Required)</param>
		/// <param name="m3_BANS">Sublot ID (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_DIPA">Disconnected package</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_BANT">Reference sublot id</param>
		/// <param name="m3_SSTS">Sublot status</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_CRDT">Creation date</param>
		/// <param name="m3_CRTE">Creation time</param>
		/// <param name="m3_SBBN">WSBBN</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSublot(
			string m3_ITNO, 
			string m3_BANO, 
			int m3_BANS, 
			string m3_WHLO, 
			int? m3_DIPA = null, 
			string m3_WHSL = null, 
			decimal? m3_DLIX = null, 
			string m3_CAMU = null, 
			string m3_BANT = null, 
			string m3_SSTS = null, 
			decimal? m3_CAWE = null, 
			DateTime? m3_CRDT = null, 
			int? m3_CRTE = null, 
			string m3_SBBN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdSublot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("BANO", m3_BANO.Trim())
				.WithQueryParameter("BANS", m3_BANS.ToString())
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DIPA.HasValue)
				request.WithQueryParameter("DIPA", m3_DIPA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANT))
				request.WithQueryParameter("BANT", m3_BANT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSTS))
				request.WithQueryParameter("SSTS", m3_SSTS.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (m3_CRDT.HasValue)
				request.WithQueryParameter("CRDT", m3_CRDT.Value.ToM3String());
			if (m3_CRTE.HasValue)
				request.WithQueryParameter("CRTE", m3_CRTE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SBBN))
				request.WithQueryParameter("SBBN", m3_SBBN.Trim());

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
