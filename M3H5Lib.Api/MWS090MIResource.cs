/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.MWS090MI;
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
	/// Name: MWS090MI
	/// Component Name: Customer Variations
	/// Description: Api: Entitlement
	/// Version Release: 14.x
	///</summary>
	public partial class MWS090MIResource : M3BaseResourceEndpoint
	{
		public MWS090MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MWS090MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddEntitlement
		/// Description Add Entitlement
		/// Version Release: 
		/// </summary>
		/// <param name="m3ORCA">Order category (Required)</param>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3RIDL">Order line (Required)</param>
		/// <param name="m3RIDX">Line suffix (Required)</param>
		/// <param name="m3ENNO">Entitlement number</param>
		/// <param name="m3RIDI">Delivery number</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3TRQT">Transaction quantity - basic U/M</param>
		/// <param name="m3RNQT">Remaining quantity - basic U/M</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3ENSD">Entitlement start date</param>
		/// <param name="m3RETD">Planned return date</param>
		/// <param name="m3FATD">Final attrition date</param>
		/// <param name="m3SPLT">Split code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddEntitlementResponse></returns>
		/// <exception cref="M3Exception<AddEntitlementResponse>"></exception>
		public async Task<M3Response<AddEntitlementResponse>> AddEntitlement(
			string m3ORCA, 
			string m3RIDN, 
			int m3RIDL, 
			int m3RIDX, 
			string m3ENNO = null, 
			decimal? m3RIDI = null, 
			long? m3REPN = null, 
			decimal? m3TRQT = null, 
			decimal? m3RNQT = null, 
			string m3STAT = null, 
			DateTime? m3ENSD = null, 
			DateTime? m3RETD = null, 
			DateTime? m3FATD = null, 
			int? m3SPLT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddEntitlement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORCA))
				throw new ArgumentNullException(nameof(m3ORCA));
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORCA", m3ORCA.Trim())
				.WithQueryParameter("RIDN", m3RIDN.Trim())
				.WithQueryParameter("RIDL", m3RIDL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RIDX", m3RIDX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ENNO))
				request.WithQueryParameter("ENNO", m3ENNO.Trim());
			if (m3RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3RIDI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3TRQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RNQT.HasValue)
				request.WithQueryParameter("RNQT", m3RNQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3ENSD.HasValue)
				request.WithQueryParameter("ENSD", m3ENSD.Value.ToM3String());
			if (m3RETD.HasValue)
				request.WithQueryParameter("RETD", m3RETD.Value.ToM3String());
			if (m3FATD.HasValue)
				request.WithQueryParameter("FATD", m3FATD.Value.ToM3String());
			if (m3SPLT.HasValue)
				request.WithQueryParameter("SPLT", m3SPLT.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddEntitlementResponse>(
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
		/// Name ChgEntitlement
		/// Description Change Entitlement
		/// Version Release: 
		/// </summary>
		/// <param name="m3ENNO">Entitlement number (Required)</param>
		/// <param name="m3RIDI">Delivery number</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3ACCG">Acceptance group</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3TRQT">Transaction quantity - basic U/M</param>
		/// <param name="m3RNQT">Remaining quantity - basic U/M</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3ENSD">Entitlement start date</param>
		/// <param name="m3RETD">Planned return date</param>
		/// <param name="m3FATD">Final attrition date</param>
		/// <param name="m3CPOL">Core policy</param>
		/// <param name="m3TECR">Core terms</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3SPLT">Split code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgEntitlement(
			string m3ENNO, 
			decimal? m3RIDI = null, 
			long? m3REPN = null, 
			string m3DIVI = null, 
			string m3FACI = null, 
			string m3CUNO = null, 
			string m3SUNO = null, 
			string m3ACCG = null, 
			string m3ITNO = null, 
			string m3WHLO = null, 
			decimal? m3TRQT = null, 
			decimal? m3RNQT = null, 
			string m3STAT = null, 
			DateTime? m3ENSD = null, 
			DateTime? m3RETD = null, 
			DateTime? m3FATD = null, 
			string m3CPOL = null, 
			string m3TECR = null, 
			string m3LNCD = null, 
			int? m3SPLT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgEntitlement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ENNO))
				throw new ArgumentNullException(nameof(m3ENNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ENNO", m3ENNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3RIDI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACCG))
				request.WithQueryParameter("ACCG", m3ACCG.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3TRQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RNQT.HasValue)
				request.WithQueryParameter("RNQT", m3RNQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3ENSD.HasValue)
				request.WithQueryParameter("ENSD", m3ENSD.Value.ToM3String());
			if (m3RETD.HasValue)
				request.WithQueryParameter("RETD", m3RETD.Value.ToM3String());
			if (m3FATD.HasValue)
				request.WithQueryParameter("FATD", m3FATD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CPOL))
				request.WithQueryParameter("CPOL", m3CPOL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TECR))
				request.WithQueryParameter("TECR", m3TECR.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (m3SPLT.HasValue)
				request.WithQueryParameter("SPLT", m3SPLT.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name CoreTracking
		/// Description Core tracking
		/// Version Release: 
		/// </summary>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3CUOR">Customer´s order number</param>
		/// <param name="m3FRDT">From date</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CoreTrackingResponse></returns>
		/// <exception cref="M3Exception<CoreTrackingResponse>"></exception>
		public async Task<M3Response<CoreTrackingResponse>> CoreTracking(
			string m3CUNO, 
			string m3RIDN = null, 
			string m3FACI = null, 
			string m3ITNO = null, 
			string m3CUOR = null, 
			DateTime? m3FRDT = null, 
			DateTime? m3TODT = null, 
			string m3BANO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CoreTracking",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (m3FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3FRDT.Value.ToM3String());
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());

			// Execute the request
			var result = await Execute<CoreTrackingResponse>(
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
		/// Name DelEntitlement
		/// Description Delete Entitlement
		/// Version Release: 
		/// </summary>
		/// <param name="m3ENNO">Entitlement number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DelEntitlementResponse></returns>
		/// <exception cref="M3Exception<DelEntitlementResponse>"></exception>
		public async Task<M3Response<DelEntitlementResponse>> DelEntitlement(
			string m3ENNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelEntitlement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ENNO))
				throw new ArgumentNullException(nameof(m3ENNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ENNO", m3ENNO.Trim());

			// Execute the request
			var result = await Execute<DelEntitlementResponse>(
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
		/// Name GetEntitlement
		/// Description Get Entitlement
		/// Version Release: 
		/// </summary>
		/// <param name="m3ENNO">Entitlement number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetEntitlementResponse></returns>
		/// <exception cref="M3Exception<GetEntitlementResponse>"></exception>
		public async Task<M3Response<GetEntitlementResponse>> GetEntitlement(
			string m3ENNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetEntitlement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ENNO))
				throw new ArgumentNullException(nameof(m3ENNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ENNO", m3ENNO.Trim());

			// Execute the request
			var result = await Execute<GetEntitlementResponse>(
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
		/// Name LstEntByCust
		/// Description List Entitlement By Customer
		/// Version Release: 
		/// </summary>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstEntByCustResponse></returns>
		/// <exception cref="M3Exception<LstEntByCustResponse>"></exception>
		public async Task<M3Response<LstEntByCustResponse>> LstEntByCust(
			string m3CUNO = null, 
			string m3ITNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstEntByCust",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<LstEntByCustResponse>(
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
		/// Name LstEntByItno
		/// Description List Entitlement By Itno
		/// Version Release: 
		/// </summary>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstEntByItnoResponse></returns>
		/// <exception cref="M3Exception<LstEntByItnoResponse>"></exception>
		public async Task<M3Response<LstEntByItnoResponse>> LstEntByItno(
			string m3ITNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstEntByItno",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<LstEntByItnoResponse>(
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
		/// Name LstEntByOrder
		/// Description List Entitlement By Order
		/// Version Release: 
		/// </summary>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstEntByOrderResponse></returns>
		/// <exception cref="M3Exception<LstEntByOrderResponse>"></exception>
		public async Task<M3Response<LstEntByOrderResponse>> LstEntByOrder(
			string m3ORCA = null, 
			string m3RIDN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstEntByOrder",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());

			// Execute the request
			var result = await Execute<LstEntByOrderResponse>(
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
		/// Name LstEntBySuppl
		/// Description List Entitlement By Supplier
		/// Version Release: 
		/// </summary>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstEntBySupplResponse></returns>
		/// <exception cref="M3Exception<LstEntBySupplResponse>"></exception>
		public async Task<M3Response<LstEntBySupplResponse>> LstEntBySuppl(
			string m3SUNO = null, 
			string m3ITNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstEntBySuppl",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<LstEntBySupplResponse>(
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
		/// Name LstEntitlement
		/// Description List Entitlement
		/// Version Release: 
		/// </summary>
		/// <param name="m3ENNO">Entitlement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstEntitlementResponse></returns>
		/// <exception cref="M3Exception<LstEntitlementResponse>"></exception>
		public async Task<M3Response<LstEntitlementResponse>> LstEntitlement(
			string m3ENNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstEntitlement",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ENNO))
				request.WithQueryParameter("ENNO", m3ENNO.Trim());

			// Execute the request
			var result = await Execute<LstEntitlementResponse>(
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
