/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.MWS070MI;
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
	/// Name: MWS070MI
	/// Component Name: StockTransHist
	/// Description: Stock transaction history interface
	/// Version Release: 5ea1
	///</summary>
	public partial class MWS070MIResource : M3BaseResourceEndpoint
	{
		public MWS070MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MWS070MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetStockTrans
		/// Description Get Stock Transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3RGDT">Entry date (Required)</param>
		/// <param name="m3RGTM">Entry time (Required)</param>
		/// <param name="m3TMSX">Time suffix (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetStockTransResponse></returns>
		/// <exception cref="M3Exception<GetStockTransResponse>"></exception>
		public async Task<M3Response<GetStockTransResponse>> GetStockTrans(
			string m3WHLO, 
			string m3ITNO, 
			DateTime m3RGDT, 
			int m3RGTM, 
			int m3TMSX, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetStockTrans",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("RGDT", m3RGDT.ToM3String())
				.WithQueryParameter("RGTM", m3RGTM.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TMSX", m3TMSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetStockTransResponse>(
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
		/// Name ListTransByDate
		/// Description List stock transactions by date
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3RGDT">Entry date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3RGTM">Entry time</param>
		/// <param name="m3ITNO">Item</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListTransByDateResponse></returns>
		/// <exception cref="M3Exception<ListTransByDateResponse>"></exception>
		public async Task<M3Response<ListTransByDateResponse>> ListTransByDate(
			string m3WHLO, 
			DateTime m3RGDT, 
			int? m3CONO = null, 
			int? m3RGTM = null, 
			string m3ITNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ListTransByDate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("RGDT", m3RGDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3RGTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<ListTransByDateResponse>(
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
		/// Name ListTransByRef
		/// Description List stock transactions by reference
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3RIDL">Order line (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3RIDI">Delivery number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListTransByRefResponse></returns>
		/// <exception cref="M3Exception<ListTransByRefResponse>"></exception>
		public async Task<M3Response<ListTransByRefResponse>> ListTransByRef(
			string m3RIDN, 
			int m3RIDL, 
			int? m3CONO = null, 
			int? m3RIDX = null, 
			decimal? m3RIDI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ListTransByRef",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("RIDN", m3RIDN.Trim())
				.WithQueryParameter("RIDL", m3RIDL.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3RIDI.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ListTransByRefResponse>(
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
		/// Name LstTransBalID
		/// Description List Transactions by Balance iD
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3TTYP">Stock transaction type (Required)</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3RIDI">Delivery number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3SLTP">Stock zone</param>
		/// <param name="m3XQT0">Exclude if TRQT GE 0</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTransBalIDResponse></returns>
		/// <exception cref="M3Exception<LstTransBalIDResponse>"></exception>
		public async Task<M3Response<LstTransBalIDResponse>> LstTransBalID(
			int m3TTYP, 
			string m3RIDN = null, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
			decimal? m3RIDI = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3WHSL = null, 
			string m3CAMU = null, 
			string m3WHLO = null, 
			string m3SLTP = null, 
			int? m3XQT0 = null, 
			int? m3OPNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstTransBalID",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("TTYP", m3TTYP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3RIDI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLTP))
				request.WithQueryParameter("SLTP", m3SLTP.Trim());
			if (m3XQT0.HasValue)
				request.WithQueryParameter("XQT0", m3XQT0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstTransBalIDResponse>(
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
		/// Name LstTransByOrder
		/// Description List Transactions by Order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TTYP">Stock transaction type (Required)</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3RIDI">Delivery number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTransByOrderResponse></returns>
		/// <exception cref="M3Exception<LstTransByOrderResponse>"></exception>
		public async Task<M3Response<LstTransByOrderResponse>> LstTransByOrder(
			int m3TTYP, 
			string m3RIDN = null, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
			decimal? m3RIDI = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3WHSL = null, 
			string m3CAMU = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstTransByOrder",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("TTYP", m3TTYP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3RIDI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());

			// Execute the request
			var result = await Execute<LstTransByOrderResponse>(
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
		/// Name LstTransByUser
		/// Description LstTransByUser
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3RESP">Responsible (Required)</param>
		/// <param name="m3TTYP">Stock transaction type</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3RIDI">Delivery number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3SLTP">Stock zone</param>
		/// <param name="m3XQT0">Exclude if TRQT GE 0</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3FTRD">Transaction date from</param>
		/// <param name="m3FTTM">Transaction time from</param>
		/// <param name="m3TRDT">Transaction date to</param>
		/// <param name="m3TTTM">Transaction time to</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTransByUserResponse></returns>
		/// <exception cref="M3Exception<LstTransByUserResponse>"></exception>
		public async Task<M3Response<LstTransByUserResponse>> LstTransByUser(
			string m3RESP, 
			int? m3TTYP = null, 
			string m3RIDN = null, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
			decimal? m3RIDI = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3WHSL = null, 
			string m3CAMU = null, 
			string m3WHLO = null, 
			string m3SLTP = null, 
			int? m3XQT0 = null, 
			int? m3OPNO = null, 
			DateTime? m3FTRD = null, 
			int? m3FTTM = null, 
			DateTime? m3TRDT = null, 
			int? m3TTTM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstTransByUser",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RESP))
				throw new ArgumentNullException(nameof(m3RESP));

			// Set mandatory parameters
			request
				.WithQueryParameter("RESP", m3RESP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3TTYP.HasValue)
				request.WithQueryParameter("TTYP", m3TTYP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3RIDI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLTP))
				request.WithQueryParameter("SLTP", m3SLTP.Trim());
			if (m3XQT0.HasValue)
				request.WithQueryParameter("XQT0", m3XQT0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FTRD.HasValue)
				request.WithQueryParameter("FTRD", m3FTRD.Value.ToM3String());
			if (m3FTTM.HasValue)
				request.WithQueryParameter("FTTM", m3FTTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (m3TTTM.HasValue)
				request.WithQueryParameter("TTTM", m3TTTM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstTransByUserResponse>(
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
		/// Name LstTrnByDateAPS
		/// Description List transactions by date, filter by warehouse grp and APS
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3TRTM">Transaction time</param>
		/// <param name="m3ITNO">Item</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3APIP">APS - policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTrnByDateAPSResponse></returns>
		/// <exception cref="M3Exception<LstTrnByDateAPSResponse>"></exception>
		public async Task<M3Response<LstTrnByDateAPSResponse>> LstTrnByDateAPS(
			string m3WHLO = null, 
			DateTime? m3TRDT = null, 
			int? m3TRTM = null, 
			string m3ITNO = null, 
			string m3WHGR = null, 
			string m3APIP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstTrnByDateAPS",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (m3TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3TRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());

			// Execute the request
			var result = await Execute<LstTrnByDateAPSResponse>(
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
		/// Name SelStockTran
		/// Description Select stock transactions
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3TTYP">Stock transaction type (Required)</param>
		/// <param name="m3FTRD">Transaction date from (Required)</param>
		/// <param name="m3TRDT">Transaction date to (Required)</param>
		/// <param name="m3FTTM">Transaction time</param>
		/// <param name="m3TTTM">Transaction time  to</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3ITTY">Item type</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3ENNO">Include Entitlement number(Y)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelStockTranResponse></returns>
		/// <exception cref="M3Exception<SelStockTranResponse>"></exception>
		public async Task<M3Response<SelStockTranResponse>> SelStockTran(
			int m3TTYP, 
			DateTime m3FTRD, 
			DateTime m3TRDT, 
			int? m3FTTM = null, 
			int? m3TTTM = null, 
			string m3WHLO = null, 
			string m3ITNO = null, 
			string m3ITTY = null, 
			string m3SUNO = null, 
			string m3ENNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelStockTran",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("TTYP", m3TTYP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FTRD", m3FTRD.ToM3String())
				.WithQueryParameter("TRDT", m3TRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3FTTM.HasValue)
				request.WithQueryParameter("FTTM", m3FTTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TTTM.HasValue)
				request.WithQueryParameter("TTTM", m3TTTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITTY))
				request.WithQueryParameter("ITTY", m3ITTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ENNO))
				request.WithQueryParameter("ENNO", m3ENNO.Trim());

			// Execute the request
			var result = await Execute<SelStockTranResponse>(
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
