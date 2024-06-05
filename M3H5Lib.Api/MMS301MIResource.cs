/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MMS301MI;
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
	/// Name: MMS301MI
	/// Component Name: ReportStocktake
	/// Description: Report stocktake interface
	/// Version Release: 5ea1
	///</summary>
	public partial class MMS301MIResource : M3BaseResourceEndpoint
	{
		public MMS301MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS301MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddStockTakeDet
		/// Description Add new record to MITTKD
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_STNB">Physical inventory number (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_WHSL">Location (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_STQI">Physical inventory quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddStockTakeDetResponse></returns>
		/// <exception cref="M3Exception<AddStockTakeDetResponse>"></exception>
		public async Task<M3Response<AddStockTakeDetResponse>> AddStockTakeDet(
			string m3_WHLO, 
			long m3_STNB, 
			string m3_ITNO, 
			string m3_WHSL, 
			int? m3_CONO = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			long? m3_REPN = null, 
			string m3_RESP = null, 
			decimal? m3_STQI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddStockTakeDet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_WHSL))
				throw new ArgumentNullException("m3_WHSL");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("STNB", m3_STNB.ToString())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("WHSL", m3_WHSL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_STQI.HasValue)
				request.WithQueryParameter("STQI", m3_STQI.Value.ToString());

			// Execute the request
			var result = await Execute<AddStockTakeDetResponse>(
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
		/// Name AddStockTakeHea
		/// Description Add new record to MITTKH
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_STPD">Planned physical inventory date (Required)</param>
		/// <param name="m3_TX30">Name (Required)</param>
		/// <param name="m3_STMD">Physical inventory method (Required)</param>
		/// <param name="m3_SBOL">Print on-hand balance (Required)</param>
		/// <param name="m3_NPTP">Print next planned transaction (Required)</param>
		/// <param name="m3_CCYC">Consider cycle time (Required)</param>
		/// <param name="m3_LSTO">Selection (Required)</param>
		/// <param name="m3_OT19">Display alias (Required)</param>
		/// <param name="m3_STNB">Physical inventory number</param>
		/// <param name="m3_SPTM">Planned physical inventory time</param>
		/// <param name="m3_STWR">Desired number of phys inventory lines</param>
		/// <param name="m3_OT73">Search sequence</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddStockTakeHeaResponse></returns>
		/// <exception cref="M3Exception<AddStockTakeHeaResponse>"></exception>
		public async Task<M3Response<AddStockTakeHeaResponse>> AddStockTakeHea(
			string m3_STPD, 
			string m3_TX30, 
			int m3_STMD, 
			int m3_SBOL, 
			int m3_NPTP, 
			int m3_CCYC, 
			int m3_LSTO, 
			string m3_OT19, 
			long? m3_STNB = null, 
			int? m3_SPTM = null, 
			int? m3_STWR = null, 
			string m3_OT73 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddStockTakeHea",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STPD))
				throw new ArgumentNullException("m3_STPD");
			if (string.IsNullOrWhiteSpace(m3_TX30))
				throw new ArgumentNullException("m3_TX30");
			if (string.IsNullOrWhiteSpace(m3_OT19))
				throw new ArgumentNullException("m3_OT19");

			// Set mandatory parameters
			request
				.WithQueryParameter("STPD", m3_STPD.Trim())
				.WithQueryParameter("TX30", m3_TX30.Trim())
				.WithQueryParameter("STMD", m3_STMD.ToString())
				.WithQueryParameter("SBOL", m3_SBOL.ToString())
				.WithQueryParameter("NPTP", m3_NPTP.ToString())
				.WithQueryParameter("CCYC", m3_CCYC.ToString())
				.WithQueryParameter("LSTO", m3_LSTO.ToString())
				.WithQueryParameter("OT19", m3_OT19.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_STNB.HasValue)
				request.WithQueryParameter("STNB", m3_STNB.Value.ToString());
			if (m3_SPTM.HasValue)
				request.WithQueryParameter("SPTM", m3_SPTM.Value.ToString());
			if (m3_STWR.HasValue)
				request.WithQueryParameter("STWR", m3_STWR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OT73))
				request.WithQueryParameter("OT73", m3_OT73.Trim());

			// Execute the request
			var result = await Execute<AddStockTakeHeaResponse>(
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
		/// Name ConfirmStockBal
		/// Description Comfirm Stock Balance
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_STNB">Stock take number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ConfirmStockBal(
			long m3_STNB, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ConfirmStockBal",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("STNB", m3_STNB.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name GetStockTakeDet
		/// Description Get info from MITTKD
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_STNB">Physical inventory number (Required)</param>
		/// <param name="m3_STRN">Physical inventory line (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_RENU">Recount number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetStockTakeDetResponse></returns>
		/// <exception cref="M3Exception<GetStockTakeDetResponse>"></exception>
		public async Task<M3Response<GetStockTakeDetResponse>> GetStockTakeDet(
			string m3_WHLO, 
			long m3_STNB, 
			int m3_STRN, 
			int? m3_CONO = null, 
			int? m3_RENU = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetStockTakeDet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("STNB", m3_STNB.ToString())
				.WithQueryParameter("STRN", m3_STRN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_RENU.HasValue)
				request.WithQueryParameter("RENU", m3_RENU.Value.ToString());

			// Execute the request
			var result = await Execute<GetStockTakeDetResponse>(
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
		/// Name LstLocation
		/// Description Lists the physical inventory request under loc
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_FWSL">From Location (Required)</param>
		/// <param name="m3_STNB">Physical inventory number</param>
		/// <param name="m3_TWSL">To Location</param>
		/// <param name="m3_RENU">Recount number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLocationResponse></returns>
		/// <exception cref="M3Exception<LstLocationResponse>"></exception>
		public async Task<M3Response<LstLocationResponse>> LstLocation(
			string m3_WHLO, 
			string m3_FWSL, 
			long? m3_STNB = null, 
			string m3_TWSL = null, 
			int? m3_RENU = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLocation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_FWSL))
				throw new ArgumentNullException("m3_FWSL");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("FWSL", m3_FWSL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_STNB.HasValue)
				request.WithQueryParameter("STNB", m3_STNB.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (m3_RENU.HasValue)
				request.WithQueryParameter("RENU", m3_RENU.Value.ToString());

			// Execute the request
			var result = await Execute<LstLocationResponse>(
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
		/// Name LstPhysInv
		/// Description Lists the physical inventory request by status
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_FSTA">From Status (Required)</param>
		/// <param name="m3_TSTA">To Status (Required)</param>
		/// <param name="m3_STNB">Physical inventory number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPhysInvResponse></returns>
		/// <exception cref="M3Exception<LstPhysInvResponse>"></exception>
		public async Task<M3Response<LstPhysInvResponse>> LstPhysInv(
			string m3_WHLO, 
			string m3_FSTA, 
			string m3_TSTA, 
			long? m3_STNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPhysInv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_FSTA))
				throw new ArgumentNullException("m3_FSTA");
			if (string.IsNullOrWhiteSpace(m3_TSTA))
				throw new ArgumentNullException("m3_TSTA");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("FSTA", m3_FSTA.Trim())
				.WithQueryParameter("TSTA", m3_TSTA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_STNB.HasValue)
				request.WithQueryParameter("STNB", m3_STNB.Value.ToString());

			// Execute the request
			var result = await Execute<LstPhysInvResponse>(
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
		/// Name LstStatus
		/// Description Lists the physical inventory by inventory status
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_STNB">Physical inventory number</param>
		/// <param name="m3_STAG">Status - physical inventory</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstStatusResponse></returns>
		/// <exception cref="M3Exception<LstStatusResponse>"></exception>
		public async Task<M3Response<LstStatusResponse>> LstStatus(
			string m3_WHLO, 
			long? m3_STNB = null, 
			int? m3_STAG = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstStatus",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_STNB.HasValue)
				request.WithQueryParameter("STNB", m3_STNB.Value.ToString());
			if (m3_STAG.HasValue)
				request.WithQueryParameter("STAG", m3_STAG.Value.ToString());

			// Execute the request
			var result = await Execute<LstStatusResponse>(
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
		/// Name LstStockTake
		/// Description List info from MITTKH
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STNB">Physical inventory number</param>
		/// <param name="m3_STPD">Planned physical inventory date</param>
		/// <param name="m3_STOD">Printout date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstStockTakeResponse></returns>
		/// <exception cref="M3Exception<LstStockTakeResponse>"></exception>
		public async Task<M3Response<LstStockTakeResponse>> LstStockTake(
			string m3_WHLO, 
			int? m3_CONO = null, 
			long? m3_STNB = null, 
			DateTime? m3_STPD = null, 
			DateTime? m3_STOD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstStockTake",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_STNB.HasValue)
				request.WithQueryParameter("STNB", m3_STNB.Value.ToString());
			if (m3_STPD.HasValue)
				request.WithQueryParameter("STPD", m3_STPD.Value.ToM3String());
			if (m3_STOD.HasValue)
				request.WithQueryParameter("STOD", m3_STOD.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstStockTakeResponse>(
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
		/// Name LstStockTakeAll
		/// Description List info from MITTKH with status between 40 and 59
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STNB">Physical inventory number</param>
		/// <param name="m3_STPD">Planned physical inventory date</param>
		/// <param name="m3_STOD">Printout date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstStockTakeAllResponse></returns>
		/// <exception cref="M3Exception<LstStockTakeAllResponse>"></exception>
		public async Task<M3Response<LstStockTakeAllResponse>> LstStockTakeAll(
			string m3_WHLO, 
			int? m3_CONO = null, 
			long? m3_STNB = null, 
			DateTime? m3_STPD = null, 
			DateTime? m3_STOD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstStockTakeAll",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_STNB.HasValue)
				request.WithQueryParameter("STNB", m3_STNB.Value.ToString());
			if (m3_STPD.HasValue)
				request.WithQueryParameter("STPD", m3_STPD.Value.ToM3String());
			if (m3_STOD.HasValue)
				request.WithQueryParameter("STOD", m3_STOD.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstStockTakeAllResponse>(
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
		/// Name LstStockTakeDet
		/// Description List info from MITTKD
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STNB">Physical inventory number</param>
		/// <param name="m3_STAG">Status - physical inventory</param>
		/// <param name="m3_RENU">Recount number</param>
		/// <param name="m3_ISTA">Include status</param>
		/// <param name="m3_IREN">Include recount number</param>
		/// <param name="m3_STRN">Physical inventory line</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_SLTP">Stock zone</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstStockTakeDetResponse></returns>
		/// <exception cref="M3Exception<LstStockTakeDetResponse>"></exception>
		public async Task<M3Response<LstStockTakeDetResponse>> LstStockTakeDet(
			string m3_WHLO, 
			int? m3_CONO = null, 
			long? m3_STNB = null, 
			int? m3_STAG = null, 
			int? m3_RENU = null, 
			long? m3_ISTA = null, 
			long? m3_IREN = null, 
			int? m3_STRN = null, 
			string m3_WHSL = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			string m3_SLTP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstStockTakeDet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_STNB.HasValue)
				request.WithQueryParameter("STNB", m3_STNB.Value.ToString());
			if (m3_STAG.HasValue)
				request.WithQueryParameter("STAG", m3_STAG.Value.ToString());
			if (m3_RENU.HasValue)
				request.WithQueryParameter("RENU", m3_RENU.Value.ToString());
			if (m3_ISTA.HasValue)
				request.WithQueryParameter("ISTA", m3_ISTA.Value.ToString());
			if (m3_IREN.HasValue)
				request.WithQueryParameter("IREN", m3_IREN.Value.ToString());
			if (m3_STRN.HasValue)
				request.WithQueryParameter("STRN", m3_STRN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLTP))
				request.WithQueryParameter("SLTP", m3_SLTP.Trim());

			// Execute the request
			var result = await Execute<LstStockTakeDetResponse>(
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
		/// Name PerfPhysInv
		/// Description Perform Physical Inventory
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_STNB">Physical inventory number (Required)</param>
		/// <param name="m3_FSTA">From Status - physical inventory (Required)</param>
		/// <param name="m3_TSTA">To Status - physical inventory (Required)</param>
		/// <param name="m3_STBT">On-hand balance to compare (Required)</param>
		/// <param name="m3_DTTP">Date type (Required)</param>
		/// <param name="m3_VAMT">Inventory accounting price (Required)</param>
		/// <param name="m3_STUP">Update physical inventory result (Required)</param>
		/// <param name="m3_SMED">Select media (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PerfPhysInv(
			long m3_STNB, 
			int m3_FSTA, 
			int m3_TSTA, 
			int m3_STBT, 
			int m3_DTTP, 
			int m3_VAMT, 
			int m3_STUP, 
			int m3_SMED, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PerfPhysInv",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("STNB", m3_STNB.ToString())
				.WithQueryParameter("FSTA", m3_FSTA.ToString())
				.WithQueryParameter("TSTA", m3_TSTA.ToString())
				.WithQueryParameter("STBT", m3_STBT.ToString())
				.WithQueryParameter("DTTP", m3_DTTP.ToString())
				.WithQueryParameter("VAMT", m3_VAMT.ToString())
				.WithQueryParameter("STUP", m3_STUP.ToString())
				.WithQueryParameter("SMED", m3_SMED.ToString());

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
		/// Name RepFirstCount
		/// Description Report First Count
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_STNB">Physical inventory number (Required)</param>
		/// <param name="m3_STRN">Physical inventory line (Required)</param>
		/// <param name="m3_STQI">Physical inventory quantity (Required)</param>
		/// <param name="m3_STBT">On-hand balance to compare (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_RENU">Recount number</param>
		/// <param name="m3_STDI">Physical inventory date</param>
		/// <param name="m3_STTM">Physical inventory time</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RepFirstCount(
			string m3_WHLO, 
			long m3_STNB, 
			int m3_STRN, 
			decimal m3_STQI, 
			int m3_STBT, 
			int? m3_CONO = null, 
			int? m3_RENU = null, 
			DateTime? m3_STDI = null, 
			int? m3_STTM = null, 
			string m3_BREM = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			decimal? m3_CAWE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RepFirstCount",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("STNB", m3_STNB.ToString())
				.WithQueryParameter("STRN", m3_STRN.ToString())
				.WithQueryParameter("STQI", m3_STQI.ToString())
				.WithQueryParameter("STBT", m3_STBT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_RENU.HasValue)
				request.WithQueryParameter("RENU", m3_RENU.Value.ToString());
			if (m3_STDI.HasValue)
				request.WithQueryParameter("STDI", m3_STDI.Value.ToM3String());
			if (m3_STTM.HasValue)
				request.WithQueryParameter("STTM", m3_STTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());

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
		/// Name RepFirstRecount
		/// Description Report First Recount
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_STNB">Physical inventory number (Required)</param>
		/// <param name="m3_STRN">Physical inventory line (Required)</param>
		/// <param name="m3_STQI">Physical inventory quantity (Required)</param>
		/// <param name="m3_STBT">On-hand balance to compare (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_RENU">Recount number</param>
		/// <param name="m3_STDI">Physical inventory date</param>
		/// <param name="m3_STTM">Physical inventory time</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RepFirstRecount(
			string m3_WHLO, 
			long m3_STNB, 
			int m3_STRN, 
			decimal m3_STQI, 
			int m3_STBT, 
			int? m3_CONO = null, 
			int? m3_RENU = null, 
			DateTime? m3_STDI = null, 
			int? m3_STTM = null, 
			string m3_BREM = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			decimal? m3_CAWE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RepFirstRecount",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("STNB", m3_STNB.ToString())
				.WithQueryParameter("STRN", m3_STRN.ToString())
				.WithQueryParameter("STQI", m3_STQI.ToString())
				.WithQueryParameter("STBT", m3_STBT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_RENU.HasValue)
				request.WithQueryParameter("RENU", m3_RENU.Value.ToString());
			if (m3_STDI.HasValue)
				request.WithQueryParameter("STDI", m3_STDI.Value.ToM3String());
			if (m3_STTM.HasValue)
				request.WithQueryParameter("STTM", m3_STTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());

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
		/// Name RepSecndRecount
		/// Description Report Second Recount
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_STNB">Physical inventory number (Required)</param>
		/// <param name="m3_STRN">Physical inventory line (Required)</param>
		/// <param name="m3_STQI">Physical inventory quantity (Required)</param>
		/// <param name="m3_STBT">On-hand balance to compare (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_RENU">Recount number</param>
		/// <param name="m3_STDI">Physical inventory date</param>
		/// <param name="m3_STTM">Physical inventory time</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RepSecndRecount(
			string m3_WHLO, 
			long m3_STNB, 
			int m3_STRN, 
			decimal m3_STQI, 
			int m3_STBT, 
			int? m3_CONO = null, 
			int? m3_RENU = null, 
			DateTime? m3_STDI = null, 
			int? m3_STTM = null, 
			string m3_BREM = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			decimal? m3_CAWE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RepSecndRecount",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("STNB", m3_STNB.ToString())
				.WithQueryParameter("STRN", m3_STRN.ToString())
				.WithQueryParameter("STQI", m3_STQI.ToString())
				.WithQueryParameter("STBT", m3_STBT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_RENU.HasValue)
				request.WithQueryParameter("RENU", m3_RENU.Value.ToString());
			if (m3_STDI.HasValue)
				request.WithQueryParameter("STDI", m3_STDI.Value.ToM3String());
			if (m3_STTM.HasValue)
				request.WithQueryParameter("STTM", m3_STTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());

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
		/// Name ReportPackage
		/// Description ReportPackage
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_STNB">Physical inventory number (Required)</param>
		/// <param name="m3_WHSL">Location (Required)</param>
		/// <param name="m3_STDI">Physical inventory date (Required)</param>
		/// <param name="m3_STTM">Physical inventory time (Required)</param>
		/// <param name="m3_STBT">On-hand balance to compare (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_STAG">Status - physical inventory</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="m3_RENU">Recount number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ReportPackage(
			string m3_WHLO, 
			long m3_STNB, 
			string m3_WHSL, 
			DateTime m3_STDI, 
			int m3_STTM, 
			int m3_STBT, 
			int? m3_CONO = null, 
			string m3_PANR = null, 
			string m3_RESP = null, 
			int? m3_STAG = null, 
			string m3_SSCC = null, 
			int? m3_RENU = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ReportPackage",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_WHSL))
				throw new ArgumentNullException("m3_WHSL");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("STNB", m3_STNB.ToString())
				.WithQueryParameter("WHSL", m3_WHSL.Trim())
				.WithQueryParameter("STDI", m3_STDI.ToM3String())
				.WithQueryParameter("STTM", m3_STTM.ToString())
				.WithQueryParameter("STBT", m3_STBT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_STAG.HasValue)
				request.WithQueryParameter("STAG", m3_STAG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());
			if (m3_RENU.HasValue)
				request.WithQueryParameter("RENU", m3_RENU.Value.ToString());

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
		/// Name UpdStockBal
		/// Description Update Stock Balance
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_STNB">Physical inventory number (Required)</param>
		/// <param name="m3_STRN">Physical inventory line (Required)</param>
		/// <param name="m3_STQI">Physical inventory quantity (Required)</param>
		/// <param name="m3_STDI">Physical inventory date (Required)</param>
		/// <param name="m3_STTM">Physical inventory time (Required)</param>
		/// <param name="m3_STBT">On-hand balance to compare (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_SAQI">Physical inventory quantity - Main U/M</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_STAG">Status - physical inventory</param>
		/// <param name="m3_RENU">Recount number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<UpdStockBalResponse></returns>
		/// <exception cref="M3Exception<UpdStockBalResponse>"></exception>
		public async Task<M3Response<UpdStockBalResponse>> UpdStockBal(
			string m3_WHLO, 
			long m3_STNB, 
			int m3_STRN, 
			decimal m3_STQI, 
			DateTime m3_STDI, 
			int m3_STTM, 
			int m3_STBT, 
			int? m3_CONO = null, 
			string m3_BREM = null, 
			string m3_RESP = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			decimal? m3_SAQI = null, 
			decimal? m3_CAWE = null, 
			int? m3_STAG = null, 
			int? m3_RENU = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdStockBal",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("STNB", m3_STNB.ToString())
				.WithQueryParameter("STRN", m3_STRN.ToString())
				.WithQueryParameter("STQI", m3_STQI.ToString())
				.WithQueryParameter("STDI", m3_STDI.ToM3String())
				.WithQueryParameter("STTM", m3_STTM.ToString())
				.WithQueryParameter("STBT", m3_STBT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (m3_SAQI.HasValue)
				request.WithQueryParameter("SAQI", m3_SAQI.Value.ToString());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (m3_STAG.HasValue)
				request.WithQueryParameter("STAG", m3_STAG.Value.ToString());
			if (m3_RENU.HasValue)
				request.WithQueryParameter("RENU", m3_RENU.Value.ToString());

			// Execute the request
			var result = await Execute<UpdStockBalResponse>(
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
		/// Name UpdStockTake
		/// Description Report Stock Take
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_STNB">Physical inventory number (Required)</param>
		/// <param name="m3_STRN">Physical inventory line (Required)</param>
		/// <param name="m3_STQI">Physical inventory quantity (Required)</param>
		/// <param name="m3_STBT">On-hand balance to compare (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STDI">Physical inventory date</param>
		/// <param name="m3_STTM">Physical inventory time</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_SAQI">Physical inventory quantity - Main U/M</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_STAG">Status - physical inventory</param>
		/// <param name="m3_RENU">Recount number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<UpdStockTakeResponse></returns>
		/// <exception cref="M3Exception<UpdStockTakeResponse>"></exception>
		public async Task<M3Response<UpdStockTakeResponse>> UpdStockTake(
			string m3_WHLO, 
			long m3_STNB, 
			int m3_STRN, 
			decimal m3_STQI, 
			int m3_STBT, 
			int? m3_CONO = null, 
			DateTime? m3_STDI = null, 
			int? m3_STTM = null, 
			string m3_ITNO = null, 
			string m3_BREM = null, 
			string m3_RESP = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			decimal? m3_SAQI = null, 
			decimal? m3_CAWE = null, 
			int? m3_STAG = null, 
			int? m3_RENU = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdStockTake",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("STNB", m3_STNB.ToString())
				.WithQueryParameter("STRN", m3_STRN.ToString())
				.WithQueryParameter("STQI", m3_STQI.ToString())
				.WithQueryParameter("STBT", m3_STBT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_STDI.HasValue)
				request.WithQueryParameter("STDI", m3_STDI.Value.ToM3String());
			if (m3_STTM.HasValue)
				request.WithQueryParameter("STTM", m3_STTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (m3_SAQI.HasValue)
				request.WithQueryParameter("SAQI", m3_SAQI.Value.ToString());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (m3_STAG.HasValue)
				request.WithQueryParameter("STAG", m3_STAG.Value.ToString());
			if (m3_RENU.HasValue)
				request.WithQueryParameter("RENU", m3_RENU.Value.ToString());

			// Execute the request
			var result = await Execute<UpdStockTakeResponse>(
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
