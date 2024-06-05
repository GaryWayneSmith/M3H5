/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddSublot
		/// Description AddSublot
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3BANO">Lot number (Required)</param>
		/// <param name="m3BANS">Sublot ID (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3BANT">Reference sublot id (Required)</param>
		/// <param name="m3DIPA">Disconnected package</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3SSTS">Sublot status</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3CRDT">Creation date</param>
		/// <param name="m3CRTE">Creation time</param>
		/// <param name="m3SBBN">Sublot batch number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddSublotResponse></returns>
		/// <exception cref="M3Exception<AddSublotResponse>"></exception>
		public async Task<M3Response<AddSublotResponse>> AddSublot(
			string m3ITNO, 
			string m3BANO, 
			int m3BANS, 
			string m3WHLO, 
			string m3BANT, 
			int? m3DIPA = null, 
			string m3WHSL = null, 
			decimal? m3DLIX = null, 
			string m3CAMU = null, 
			string m3SSTS = null, 
			decimal? m3CAWE = null, 
			DateTime? m3CRDT = null, 
			int? m3CRTE = null, 
			string m3SBBN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddSublot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3BANO))
				throw new ArgumentNullException(nameof(m3BANO));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3BANT))
				throw new ArgumentNullException(nameof(m3BANT));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("BANO", m3BANO.Trim())
				.WithQueryParameter("BANS", m3BANS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("BANT", m3BANT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3DIPA.HasValue)
				request.WithQueryParameter("DIPA", m3DIPA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3SSTS))
				request.WithQueryParameter("SSTS", m3SSTS.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRDT.HasValue)
				request.WithQueryParameter("CRDT", m3CRDT.Value.ToM3String());
			if (m3CRTE.HasValue)
				request.WithQueryParameter("CRTE", m3CRTE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SBBN))
				request.WithQueryParameter("SBBN", m3SBBN.Trim());

			// Execute the request
			var result = await Execute<AddSublotResponse>(
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
		/// Name DltSublot
		/// Description DltSublot
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3BANO">Lot number (Required)</param>
		/// <param name="m3BANS">Sublot ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltSublot(
			string m3ITNO, 
			string m3BANO, 
			int m3BANS, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltSublot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3BANO))
				throw new ArgumentNullException(nameof(m3BANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("BANO", m3BANO.Trim())
				.WithQueryParameter("BANS", m3BANS.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetSublot
		/// Description GetSublot
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3BANO">Lot number (Required)</param>
		/// <param name="m3BANS">Sublot ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSublotResponse></returns>
		/// <exception cref="M3Exception<GetSublotResponse>"></exception>
		public async Task<M3Response<GetSublotResponse>> GetSublot(
			string m3ITNO, 
			string m3BANO, 
			int m3BANS, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetSublot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3BANO))
				throw new ArgumentNullException(nameof(m3BANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("BANO", m3BANO.Trim())
				.WithQueryParameter("BANS", m3BANS.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetSublotResponse>(
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
		/// Name LstSelect
		/// Description LstSelect
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3BANS">Sublot ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSelectResponse></returns>
		/// <exception cref="M3Exception<LstSelectResponse>"></exception>
		public async Task<M3Response<LstSelectResponse>> LstSelect(
			string m3WHLO, 
			string m3ITNO, 
			string m3BANO = null, 
			int? m3BANS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstSelect",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3BANS.HasValue)
				request.WithQueryParameter("BANS", m3BANS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstSelectResponse>(
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
		/// Name LstSublot
		/// Description LstSublot
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3BANO">Lot number (Required)</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANS">Sublot ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSublotResponse></returns>
		/// <exception cref="M3Exception<LstSublotResponse>"></exception>
		public async Task<M3Response<LstSublotResponse>> LstSublot(
			string m3BANO, 
			string m3ITNO = null, 
			int? m3BANS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstSublot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BANO))
				throw new ArgumentNullException(nameof(m3BANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("BANO", m3BANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3BANS.HasValue)
				request.WithQueryParameter("BANS", m3BANS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstSublotResponse>(
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
		/// Name UpdSublot
		/// Description UpdSublot
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3BANO">Lot number (Required)</param>
		/// <param name="m3BANS">Sublot ID (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3DIPA">Disconnected package</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3BANT">Reference sublot id</param>
		/// <param name="m3SSTS">Sublot status</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3CRDT">Creation date</param>
		/// <param name="m3CRTE">Creation time</param>
		/// <param name="m3SBBN">WSBBN</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSublot(
			string m3ITNO, 
			string m3BANO, 
			int m3BANS, 
			string m3WHLO, 
			int? m3DIPA = null, 
			string m3WHSL = null, 
			decimal? m3DLIX = null, 
			string m3CAMU = null, 
			string m3BANT = null, 
			string m3SSTS = null, 
			decimal? m3CAWE = null, 
			DateTime? m3CRDT = null, 
			int? m3CRTE = null, 
			string m3SBBN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdSublot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3BANO))
				throw new ArgumentNullException(nameof(m3BANO));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("BANO", m3BANO.Trim())
				.WithQueryParameter("BANS", m3BANS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3DIPA.HasValue)
				request.WithQueryParameter("DIPA", m3DIPA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANT))
				request.WithQueryParameter("BANT", m3BANT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SSTS))
				request.WithQueryParameter("SSTS", m3SSTS.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRDT.HasValue)
				request.WithQueryParameter("CRDT", m3CRDT.Value.ToM3String());
			if (m3CRTE.HasValue)
				request.WithQueryParameter("CRTE", m3CRTE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SBBN))
				request.WithQueryParameter("SBBN", m3SBBN.Trim());

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
