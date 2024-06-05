/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_ORCA">Order category (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line (Required)</param>
		/// <param name="m3_RIDX">Line suffix (Required)</param>
		/// <param name="m3_ENNO">Entitlement number</param>
		/// <param name="m3_RIDI">Delivery number</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_TRQT">Transaction quantity - basic U/M</param>
		/// <param name="m3_RNQT">Remaining quantity - basic U/M</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_ENSD">Entitlement start date</param>
		/// <param name="m3_RETD">Planned return date</param>
		/// <param name="m3_FATD">Final attrition date</param>
		/// <param name="m3_SPLT">Split code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddEntitlementResponse></returns>
		/// <exception cref="M3Exception<AddEntitlementResponse>"></exception>
		public async Task<M3Response<AddEntitlementResponse>> AddEntitlement(
			string m3_ORCA, 
			string m3_RIDN, 
			int m3_RIDL, 
			int m3_RIDX, 
			string m3_ENNO = null, 
			decimal? m3_RIDI = null, 
			long? m3_REPN = null, 
			decimal? m3_TRQT = null, 
			decimal? m3_RNQT = null, 
			string m3_STAT = null, 
			DateTime? m3_ENSD = null, 
			DateTime? m3_RETD = null, 
			DateTime? m3_FATD = null, 
			int? m3_SPLT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ORCA))
				throw new ArgumentNullException("m3_ORCA");
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORCA", m3_ORCA.Trim())
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("RIDL", m3_RIDL.ToString())
				.WithQueryParameter("RIDX", m3_RIDX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ENNO))
				request.WithQueryParameter("ENNO", m3_ENNO.Trim());
			if (m3_RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3_RIDI.Value.ToString());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (m3_TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3_TRQT.Value.ToString());
			if (m3_RNQT.HasValue)
				request.WithQueryParameter("RNQT", m3_RNQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_ENSD.HasValue)
				request.WithQueryParameter("ENSD", m3_ENSD.Value.ToM3String());
			if (m3_RETD.HasValue)
				request.WithQueryParameter("RETD", m3_RETD.Value.ToM3String());
			if (m3_FATD.HasValue)
				request.WithQueryParameter("FATD", m3_FATD.Value.ToM3String());
			if (m3_SPLT.HasValue)
				request.WithQueryParameter("SPLT", m3_SPLT.Value.ToString());

			// Execute the request
			var result = await Execute<AddEntitlementResponse>(
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
		/// Name ChgEntitlement
		/// Description Change Entitlement
		/// Version Release: 
		/// </summary>
		/// <param name="m3_ENNO">Entitlement number (Required)</param>
		/// <param name="m3_RIDI">Delivery number</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_ACCG">Acceptance group</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_TRQT">Transaction quantity - basic U/M</param>
		/// <param name="m3_RNQT">Remaining quantity - basic U/M</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_ENSD">Entitlement start date</param>
		/// <param name="m3_RETD">Planned return date</param>
		/// <param name="m3_FATD">Final attrition date</param>
		/// <param name="m3_CPOL">Core policy</param>
		/// <param name="m3_TECR">Core terms</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_SPLT">Split code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgEntitlement(
			string m3_ENNO, 
			decimal? m3_RIDI = null, 
			long? m3_REPN = null, 
			string m3_DIVI = null, 
			string m3_FACI = null, 
			string m3_CUNO = null, 
			string m3_SUNO = null, 
			string m3_ACCG = null, 
			string m3_ITNO = null, 
			string m3_WHLO = null, 
			decimal? m3_TRQT = null, 
			decimal? m3_RNQT = null, 
			string m3_STAT = null, 
			DateTime? m3_ENSD = null, 
			DateTime? m3_RETD = null, 
			DateTime? m3_FATD = null, 
			string m3_CPOL = null, 
			string m3_TECR = null, 
			string m3_LNCD = null, 
			int? m3_SPLT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ENNO))
				throw new ArgumentNullException("m3_ENNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ENNO", m3_ENNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3_RIDI.Value.ToString());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACCG))
				request.WithQueryParameter("ACCG", m3_ACCG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3_TRQT.Value.ToString());
			if (m3_RNQT.HasValue)
				request.WithQueryParameter("RNQT", m3_RNQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_ENSD.HasValue)
				request.WithQueryParameter("ENSD", m3_ENSD.Value.ToM3String());
			if (m3_RETD.HasValue)
				request.WithQueryParameter("RETD", m3_RETD.Value.ToM3String());
			if (m3_FATD.HasValue)
				request.WithQueryParameter("FATD", m3_FATD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CPOL))
				request.WithQueryParameter("CPOL", m3_CPOL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECR))
				request.WithQueryParameter("TECR", m3_TECR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (m3_SPLT.HasValue)
				request.WithQueryParameter("SPLT", m3_SPLT.Value.ToString());

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
		/// Name CoreTracking
		/// Description Core tracking
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CUNO">Customer (Required)</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_CUOR">Customer´s order number</param>
		/// <param name="m3_FRDT">From date</param>
		/// <param name="m3_TODT">To date</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CoreTrackingResponse></returns>
		/// <exception cref="M3Exception<CoreTrackingResponse>"></exception>
		public async Task<M3Response<CoreTrackingResponse>> CoreTracking(
			string m3_CUNO, 
			string m3_RIDN = null, 
			string m3_FACI = null, 
			string m3_ITNO = null, 
			string m3_CUOR = null, 
			DateTime? m3_FRDT = null, 
			DateTime? m3_TODT = null, 
			string m3_BANO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (m3_FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3_FRDT.Value.ToM3String());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());

			// Execute the request
			var result = await Execute<CoreTrackingResponse>(
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
		/// Name DelEntitlement
		/// Description Delete Entitlement
		/// Version Release: 
		/// </summary>
		/// <param name="m3_ENNO">Entitlement number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DelEntitlementResponse></returns>
		/// <exception cref="M3Exception<DelEntitlementResponse>"></exception>
		public async Task<M3Response<DelEntitlementResponse>> DelEntitlement(
			string m3_ENNO, 
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
			if (string.IsNullOrWhiteSpace(m3_ENNO))
				throw new ArgumentNullException("m3_ENNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ENNO", m3_ENNO.Trim());

			// Execute the request
			var result = await Execute<DelEntitlementResponse>(
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
		/// Name GetEntitlement
		/// Description Get Entitlement
		/// Version Release: 
		/// </summary>
		/// <param name="m3_ENNO">Entitlement number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetEntitlementResponse></returns>
		/// <exception cref="M3Exception<GetEntitlementResponse>"></exception>
		public async Task<M3Response<GetEntitlementResponse>> GetEntitlement(
			string m3_ENNO, 
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
			if (string.IsNullOrWhiteSpace(m3_ENNO))
				throw new ArgumentNullException("m3_ENNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ENNO", m3_ENNO.Trim());

			// Execute the request
			var result = await Execute<GetEntitlementResponse>(
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
		/// Name LstEntByCust
		/// Description List Entitlement By Customer
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstEntByCustResponse></returns>
		/// <exception cref="M3Exception<LstEntByCustResponse>"></exception>
		public async Task<M3Response<LstEntByCustResponse>> LstEntByCust(
			string m3_CUNO = null, 
			string m3_ITNO = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<LstEntByCustResponse>(
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
		/// Name LstEntByItno
		/// Description List Entitlement By Itno
		/// Version Release: 
		/// </summary>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstEntByItnoResponse></returns>
		/// <exception cref="M3Exception<LstEntByItnoResponse>"></exception>
		public async Task<M3Response<LstEntByItnoResponse>> LstEntByItno(
			string m3_ITNO = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<LstEntByItnoResponse>(
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
		/// Name LstEntByOrder
		/// Description List Entitlement By Order
		/// Version Release: 
		/// </summary>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstEntByOrderResponse></returns>
		/// <exception cref="M3Exception<LstEntByOrderResponse>"></exception>
		public async Task<M3Response<LstEntByOrderResponse>> LstEntByOrder(
			string m3_ORCA = null, 
			string m3_RIDN = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());

			// Execute the request
			var result = await Execute<LstEntByOrderResponse>(
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
		/// Name LstEntBySuppl
		/// Description List Entitlement By Supplier
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstEntBySupplResponse></returns>
		/// <exception cref="M3Exception<LstEntBySupplResponse>"></exception>
		public async Task<M3Response<LstEntBySupplResponse>> LstEntBySuppl(
			string m3_SUNO = null, 
			string m3_ITNO = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<LstEntBySupplResponse>(
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
		/// Name LstEntitlement
		/// Description List Entitlement
		/// Version Release: 
		/// </summary>
		/// <param name="m3_ENNO">Entitlement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstEntitlementResponse></returns>
		/// <exception cref="M3Exception<LstEntitlementResponse>"></exception>
		public async Task<M3Response<LstEntitlementResponse>> LstEntitlement(
			string m3_ENNO = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_ENNO))
				request.WithQueryParameter("ENNO", m3_ENNO.Trim());

			// Execute the request
			var result = await Execute<LstEntitlementResponse>(
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
