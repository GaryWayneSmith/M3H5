/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddStockTakeDet
		/// Description Add new record to MITTKD
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3STNB">Physical inventory number (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3WHSL">Location (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3STQI">Physical inventory quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddStockTakeDetResponse></returns>
		/// <exception cref="M3Exception<AddStockTakeDetResponse>"></exception>
		public async Task<M3Response<AddStockTakeDetResponse>> AddStockTakeDet(
			string m3WHLO, 
			long m3STNB, 
			string m3ITNO, 
			string m3WHSL, 
			int? m3CONO = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			long? m3REPN = null, 
			string m3RESP = null, 
			decimal? m3STQI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddStockTakeDet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3WHSL))
				throw new ArgumentNullException(nameof(m3WHSL));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("STNB", m3STNB.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("WHSL", m3WHSL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3STQI.HasValue)
				request.WithQueryParameter("STQI", m3STQI.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddStockTakeDetResponse>(
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
		/// Name AddStockTakeHea
		/// Description Add new record to MITTKH
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3STPD">Planned physical inventory date (Required)</param>
		/// <param name="m3TX30">Name (Required)</param>
		/// <param name="m3STMD">Physical inventory method (Required)</param>
		/// <param name="m3SBOL">Print on-hand balance (Required)</param>
		/// <param name="m3NPTP">Print next planned transaction (Required)</param>
		/// <param name="m3CCYC">Consider cycle time (Required)</param>
		/// <param name="m3LSTO">Selection (Required)</param>
		/// <param name="m3OT19">Display alias (Required)</param>
		/// <param name="m3STNB">Physical inventory number</param>
		/// <param name="m3SPTM">Planned physical inventory time</param>
		/// <param name="m3STWR">Desired number of phys inventory lines</param>
		/// <param name="m3OT73">Search sequence</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddStockTakeHeaResponse></returns>
		/// <exception cref="M3Exception<AddStockTakeHeaResponse>"></exception>
		public async Task<M3Response<AddStockTakeHeaResponse>> AddStockTakeHea(
			string m3STPD, 
			string m3TX30, 
			int m3STMD, 
			int m3SBOL, 
			int m3NPTP, 
			int m3CCYC, 
			int m3LSTO, 
			string m3OT19, 
			long? m3STNB = null, 
			int? m3SPTM = null, 
			int? m3STWR = null, 
			string m3OT73 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddStockTakeHea",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STPD))
				throw new ArgumentNullException(nameof(m3STPD));
			if (string.IsNullOrWhiteSpace(m3TX30))
				throw new ArgumentNullException(nameof(m3TX30));
			if (string.IsNullOrWhiteSpace(m3OT19))
				throw new ArgumentNullException(nameof(m3OT19));

			// Set mandatory parameters
			request
				.WithQueryParameter("STPD", m3STPD.Trim())
				.WithQueryParameter("TX30", m3TX30.Trim())
				.WithQueryParameter("STMD", m3STMD.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SBOL", m3SBOL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("NPTP", m3NPTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CCYC", m3CCYC.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("LSTO", m3LSTO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OT19", m3OT19.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3STNB.HasValue)
				request.WithQueryParameter("STNB", m3STNB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPTM.HasValue)
				request.WithQueryParameter("SPTM", m3SPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STWR.HasValue)
				request.WithQueryParameter("STWR", m3STWR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OT73))
				request.WithQueryParameter("OT73", m3OT73.Trim());

			// Execute the request
			var result = await Execute<AddStockTakeHeaResponse>(
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
		/// Name ConfirmStockBal
		/// Description Comfirm Stock Balance
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3STNB">Stock take number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ConfirmStockBal(
			long m3STNB, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ConfirmStockBal",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("STNB", m3STNB.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetStockTakeDet
		/// Description Get info from MITTKD
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3STNB">Physical inventory number (Required)</param>
		/// <param name="m3STRN">Physical inventory line (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3RENU">Recount number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetStockTakeDetResponse></returns>
		/// <exception cref="M3Exception<GetStockTakeDetResponse>"></exception>
		public async Task<M3Response<GetStockTakeDetResponse>> GetStockTakeDet(
			string m3WHLO, 
			long m3STNB, 
			int m3STRN, 
			int? m3CONO = null, 
			int? m3RENU = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetStockTakeDet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("STNB", m3STNB.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STRN", m3STRN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RENU.HasValue)
				request.WithQueryParameter("RENU", m3RENU.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetStockTakeDetResponse>(
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
		/// Name LstLocation
		/// Description Lists the physical inventory request under loc
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3FWSL">From Location (Required)</param>
		/// <param name="m3STNB">Physical inventory number</param>
		/// <param name="m3TWSL">To Location</param>
		/// <param name="m3RENU">Recount number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLocationResponse></returns>
		/// <exception cref="M3Exception<LstLocationResponse>"></exception>
		public async Task<M3Response<LstLocationResponse>> LstLocation(
			string m3WHLO, 
			string m3FWSL, 
			long? m3STNB = null, 
			string m3TWSL = null, 
			int? m3RENU = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstLocation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3FWSL))
				throw new ArgumentNullException(nameof(m3FWSL));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("FWSL", m3FWSL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3STNB.HasValue)
				request.WithQueryParameter("STNB", m3STNB.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (m3RENU.HasValue)
				request.WithQueryParameter("RENU", m3RENU.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstLocationResponse>(
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
		/// Name LstPhysInv
		/// Description Lists the physical inventory request by status
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3FSTA">From Status (Required)</param>
		/// <param name="m3TSTA">To Status (Required)</param>
		/// <param name="m3STNB">Physical inventory number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPhysInvResponse></returns>
		/// <exception cref="M3Exception<LstPhysInvResponse>"></exception>
		public async Task<M3Response<LstPhysInvResponse>> LstPhysInv(
			string m3WHLO, 
			string m3FSTA, 
			string m3TSTA, 
			long? m3STNB = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPhysInv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3FSTA))
				throw new ArgumentNullException(nameof(m3FSTA));
			if (string.IsNullOrWhiteSpace(m3TSTA))
				throw new ArgumentNullException(nameof(m3TSTA));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("FSTA", m3FSTA.Trim())
				.WithQueryParameter("TSTA", m3TSTA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3STNB.HasValue)
				request.WithQueryParameter("STNB", m3STNB.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPhysInvResponse>(
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
		/// Name LstStatus
		/// Description Lists the physical inventory by inventory status
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3STNB">Physical inventory number</param>
		/// <param name="m3STAG">Status - physical inventory</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstStatusResponse></returns>
		/// <exception cref="M3Exception<LstStatusResponse>"></exception>
		public async Task<M3Response<LstStatusResponse>> LstStatus(
			string m3WHLO, 
			long? m3STNB = null, 
			int? m3STAG = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstStatus",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3STNB.HasValue)
				request.WithQueryParameter("STNB", m3STNB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STAG.HasValue)
				request.WithQueryParameter("STAG", m3STAG.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstStatusResponse>(
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
		/// Name LstStockTake
		/// Description List info from MITTKH
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STNB">Physical inventory number</param>
		/// <param name="m3STPD">Planned physical inventory date</param>
		/// <param name="m3STOD">Printout date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstStockTakeResponse></returns>
		/// <exception cref="M3Exception<LstStockTakeResponse>"></exception>
		public async Task<M3Response<LstStockTakeResponse>> LstStockTake(
			string m3WHLO, 
			int? m3CONO = null, 
			long? m3STNB = null, 
			DateTime? m3STPD = null, 
			DateTime? m3STOD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstStockTake",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STNB.HasValue)
				request.WithQueryParameter("STNB", m3STNB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STPD.HasValue)
				request.WithQueryParameter("STPD", m3STPD.Value.ToM3String());
			if (m3STOD.HasValue)
				request.WithQueryParameter("STOD", m3STOD.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstStockTakeResponse>(
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
		/// Name LstStockTakeAll
		/// Description List info from MITTKH with status between 40 and 59
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STNB">Physical inventory number</param>
		/// <param name="m3STPD">Planned physical inventory date</param>
		/// <param name="m3STOD">Printout date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstStockTakeAllResponse></returns>
		/// <exception cref="M3Exception<LstStockTakeAllResponse>"></exception>
		public async Task<M3Response<LstStockTakeAllResponse>> LstStockTakeAll(
			string m3WHLO, 
			int? m3CONO = null, 
			long? m3STNB = null, 
			DateTime? m3STPD = null, 
			DateTime? m3STOD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstStockTakeAll",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STNB.HasValue)
				request.WithQueryParameter("STNB", m3STNB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STPD.HasValue)
				request.WithQueryParameter("STPD", m3STPD.Value.ToM3String());
			if (m3STOD.HasValue)
				request.WithQueryParameter("STOD", m3STOD.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstStockTakeAllResponse>(
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
		/// Name LstStockTakeDet
		/// Description List info from MITTKD
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STNB">Physical inventory number</param>
		/// <param name="m3STAG">Status - physical inventory</param>
		/// <param name="m3RENU">Recount number</param>
		/// <param name="m3ISTA">Include status</param>
		/// <param name="m3IREN">Include recount number</param>
		/// <param name="m3STRN">Physical inventory line</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3SLTP">Stock zone</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstStockTakeDetResponse></returns>
		/// <exception cref="M3Exception<LstStockTakeDetResponse>"></exception>
		public async Task<M3Response<LstStockTakeDetResponse>> LstStockTakeDet(
			string m3WHLO, 
			int? m3CONO = null, 
			long? m3STNB = null, 
			int? m3STAG = null, 
			int? m3RENU = null, 
			long? m3ISTA = null, 
			long? m3IREN = null, 
			int? m3STRN = null, 
			string m3WHSL = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			string m3SLTP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstStockTakeDet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STNB.HasValue)
				request.WithQueryParameter("STNB", m3STNB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STAG.HasValue)
				request.WithQueryParameter("STAG", m3STAG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RENU.HasValue)
				request.WithQueryParameter("RENU", m3RENU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ISTA.HasValue)
				request.WithQueryParameter("ISTA", m3ISTA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IREN.HasValue)
				request.WithQueryParameter("IREN", m3IREN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STRN.HasValue)
				request.WithQueryParameter("STRN", m3STRN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLTP))
				request.WithQueryParameter("SLTP", m3SLTP.Trim());

			// Execute the request
			var result = await Execute<LstStockTakeDetResponse>(
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
		/// Name PerfPhysInv
		/// Description Perform Physical Inventory
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3STNB">Physical inventory number (Required)</param>
		/// <param name="m3FSTA">From Status - physical inventory (Required)</param>
		/// <param name="m3TSTA">To Status - physical inventory (Required)</param>
		/// <param name="m3STBT">On-hand balance to compare (Required)</param>
		/// <param name="m3DTTP">Date type (Required)</param>
		/// <param name="m3VAMT">Inventory accounting price (Required)</param>
		/// <param name="m3STUP">Update physical inventory result (Required)</param>
		/// <param name="m3SMED">Select media (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PerfPhysInv(
			long m3STNB, 
			int m3FSTA, 
			int m3TSTA, 
			int m3STBT, 
			int m3DTTP, 
			int m3VAMT, 
			int m3STUP, 
			int m3SMED, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/PerfPhysInv",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("STNB", m3STNB.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FSTA", m3FSTA.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TSTA", m3TSTA.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STBT", m3STBT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DTTP", m3DTTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("VAMT", m3VAMT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STUP", m3STUP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SMED", m3SMED.ToString(CultureInfo.CurrentCulture));

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
		/// Name RepFirstCount
		/// Description Report First Count
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3STNB">Physical inventory number (Required)</param>
		/// <param name="m3STRN">Physical inventory line (Required)</param>
		/// <param name="m3STQI">Physical inventory quantity (Required)</param>
		/// <param name="m3STBT">On-hand balance to compare (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3RENU">Recount number</param>
		/// <param name="m3STDI">Physical inventory date</param>
		/// <param name="m3STTM">Physical inventory time</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RepFirstCount(
			string m3WHLO, 
			long m3STNB, 
			int m3STRN, 
			decimal m3STQI, 
			int m3STBT, 
			int? m3CONO = null, 
			int? m3RENU = null, 
			DateTime? m3STDI = null, 
			int? m3STTM = null, 
			string m3BREM = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			decimal? m3CAWE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/RepFirstCount",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("STNB", m3STNB.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STRN", m3STRN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STQI", m3STQI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STBT", m3STBT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RENU.HasValue)
				request.WithQueryParameter("RENU", m3RENU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STDI.HasValue)
				request.WithQueryParameter("STDI", m3STDI.Value.ToM3String());
			if (m3STTM.HasValue)
				request.WithQueryParameter("STTM", m3STTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name RepFirstRecount
		/// Description Report First Recount
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3STNB">Physical inventory number (Required)</param>
		/// <param name="m3STRN">Physical inventory line (Required)</param>
		/// <param name="m3STQI">Physical inventory quantity (Required)</param>
		/// <param name="m3STBT">On-hand balance to compare (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3RENU">Recount number</param>
		/// <param name="m3STDI">Physical inventory date</param>
		/// <param name="m3STTM">Physical inventory time</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RepFirstRecount(
			string m3WHLO, 
			long m3STNB, 
			int m3STRN, 
			decimal m3STQI, 
			int m3STBT, 
			int? m3CONO = null, 
			int? m3RENU = null, 
			DateTime? m3STDI = null, 
			int? m3STTM = null, 
			string m3BREM = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			decimal? m3CAWE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/RepFirstRecount",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("STNB", m3STNB.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STRN", m3STRN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STQI", m3STQI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STBT", m3STBT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RENU.HasValue)
				request.WithQueryParameter("RENU", m3RENU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STDI.HasValue)
				request.WithQueryParameter("STDI", m3STDI.Value.ToM3String());
			if (m3STTM.HasValue)
				request.WithQueryParameter("STTM", m3STTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name RepSecndRecount
		/// Description Report Second Recount
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3STNB">Physical inventory number (Required)</param>
		/// <param name="m3STRN">Physical inventory line (Required)</param>
		/// <param name="m3STQI">Physical inventory quantity (Required)</param>
		/// <param name="m3STBT">On-hand balance to compare (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3RENU">Recount number</param>
		/// <param name="m3STDI">Physical inventory date</param>
		/// <param name="m3STTM">Physical inventory time</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RepSecndRecount(
			string m3WHLO, 
			long m3STNB, 
			int m3STRN, 
			decimal m3STQI, 
			int m3STBT, 
			int? m3CONO = null, 
			int? m3RENU = null, 
			DateTime? m3STDI = null, 
			int? m3STTM = null, 
			string m3BREM = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			decimal? m3CAWE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/RepSecndRecount",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("STNB", m3STNB.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STRN", m3STRN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STQI", m3STQI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STBT", m3STBT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RENU.HasValue)
				request.WithQueryParameter("RENU", m3RENU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STDI.HasValue)
				request.WithQueryParameter("STDI", m3STDI.Value.ToM3String());
			if (m3STTM.HasValue)
				request.WithQueryParameter("STTM", m3STTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ReportPackage
		/// Description ReportPackage
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3STNB">Physical inventory number (Required)</param>
		/// <param name="m3WHSL">Location (Required)</param>
		/// <param name="m3STDI">Physical inventory date (Required)</param>
		/// <param name="m3STTM">Physical inventory time (Required)</param>
		/// <param name="m3STBT">On-hand balance to compare (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PANR">Package number</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3STAG">Status - physical inventory</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="m3RENU">Recount number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ReportPackage(
			string m3WHLO, 
			long m3STNB, 
			string m3WHSL, 
			DateTime m3STDI, 
			int m3STTM, 
			int m3STBT, 
			int? m3CONO = null, 
			string m3PANR = null, 
			string m3RESP = null, 
			int? m3STAG = null, 
			string m3SSCC = null, 
			int? m3RENU = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ReportPackage",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3WHSL))
				throw new ArgumentNullException(nameof(m3WHSL));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("STNB", m3STNB.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("WHSL", m3WHSL.Trim())
				.WithQueryParameter("STDI", m3STDI.ToM3String())
				.WithQueryParameter("STTM", m3STTM.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STBT", m3STBT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PANR))
				request.WithQueryParameter("PANR", m3PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3STAG.HasValue)
				request.WithQueryParameter("STAG", m3STAG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());
			if (m3RENU.HasValue)
				request.WithQueryParameter("RENU", m3RENU.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdStockBal
		/// Description Update Stock Balance
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3STNB">Physical inventory number (Required)</param>
		/// <param name="m3STRN">Physical inventory line (Required)</param>
		/// <param name="m3STQI">Physical inventory quantity (Required)</param>
		/// <param name="m3STDI">Physical inventory date (Required)</param>
		/// <param name="m3STTM">Physical inventory time (Required)</param>
		/// <param name="m3STBT">On-hand balance to compare (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3SAQI">Physical inventory quantity - Main U/M</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3STAG">Status - physical inventory</param>
		/// <param name="m3RENU">Recount number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<UpdStockBalResponse></returns>
		/// <exception cref="M3Exception<UpdStockBalResponse>"></exception>
		public async Task<M3Response<UpdStockBalResponse>> UpdStockBal(
			string m3WHLO, 
			long m3STNB, 
			int m3STRN, 
			decimal m3STQI, 
			DateTime m3STDI, 
			int m3STTM, 
			int m3STBT, 
			int? m3CONO = null, 
			string m3BREM = null, 
			string m3RESP = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			decimal? m3SAQI = null, 
			decimal? m3CAWE = null, 
			int? m3STAG = null, 
			int? m3RENU = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdStockBal",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("STNB", m3STNB.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STRN", m3STRN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STQI", m3STQI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STDI", m3STDI.ToM3String())
				.WithQueryParameter("STTM", m3STTM.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STBT", m3STBT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3SAQI.HasValue)
				request.WithQueryParameter("SAQI", m3SAQI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STAG.HasValue)
				request.WithQueryParameter("STAG", m3STAG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RENU.HasValue)
				request.WithQueryParameter("RENU", m3RENU.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<UpdStockBalResponse>(
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
		/// Name UpdStockTake
		/// Description Report Stock Take
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3STNB">Physical inventory number (Required)</param>
		/// <param name="m3STRN">Physical inventory line (Required)</param>
		/// <param name="m3STQI">Physical inventory quantity (Required)</param>
		/// <param name="m3STBT">On-hand balance to compare (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STDI">Physical inventory date</param>
		/// <param name="m3STTM">Physical inventory time</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3SAQI">Physical inventory quantity - Main U/M</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3STAG">Status - physical inventory</param>
		/// <param name="m3RENU">Recount number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<UpdStockTakeResponse></returns>
		/// <exception cref="M3Exception<UpdStockTakeResponse>"></exception>
		public async Task<M3Response<UpdStockTakeResponse>> UpdStockTake(
			string m3WHLO, 
			long m3STNB, 
			int m3STRN, 
			decimal m3STQI, 
			int m3STBT, 
			int? m3CONO = null, 
			DateTime? m3STDI = null, 
			int? m3STTM = null, 
			string m3ITNO = null, 
			string m3BREM = null, 
			string m3RESP = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			decimal? m3SAQI = null, 
			decimal? m3CAWE = null, 
			int? m3STAG = null, 
			int? m3RENU = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdStockTake",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("STNB", m3STNB.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STRN", m3STRN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STQI", m3STQI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STBT", m3STBT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STDI.HasValue)
				request.WithQueryParameter("STDI", m3STDI.Value.ToM3String());
			if (m3STTM.HasValue)
				request.WithQueryParameter("STTM", m3STTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3SAQI.HasValue)
				request.WithQueryParameter("SAQI", m3SAQI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STAG.HasValue)
				request.WithQueryParameter("STAG", m3STAG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RENU.HasValue)
				request.WithQueryParameter("RENU", m3RENU.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<UpdStockTakeResponse>(
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
