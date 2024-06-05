/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.MHS800MI;
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
	/// Name: MHS800MI
	/// Component Name: ExpectedReceiptsDownload
	/// Description: Expected receipts download interface
	/// Version Release: 5ea0
	///</summary>
	public partial class MHS800MIResource : M3BaseResourceEndpoint
	{
		public MHS800MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MHS800MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstExpPOPac
		/// Description List Expected Rec. PO Packages
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3DNDT">Delivery note date</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3SUTY">Supplier type</param>
		/// <param name="m3PANR">Package number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstExpPOPacResponse></returns>
		/// <exception cref="M3Exception<LstExpPOPacResponse>"></exception>
		public async Task<M3Response<LstExpPOPacResponse>> LstExpPOPac(
			string m3E0PA, 
			string m3WHLO, 
			string m3SUDO = null, 
			DateTime? m3DNDT = null, 
			string m3SUNO = null, 
			int? m3SUTY = null, 
			string m3PANR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstExpPOPac",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (m3DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3DNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3SUTY.HasValue)
				request.WithQueryParameter("SUTY", m3SUTY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PANR))
				request.WithQueryParameter("PANR", m3PANR.Trim());

			// Execute the request
			var result = await Execute<LstExpPOPacResponse>(
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
		/// Name LstExpPOPacDet
		/// Description List Expected Rec. PO Package  Details
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3DNDT">Delivery note date</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3SUTY">Supplier type</param>
		/// <param name="m3PANR">Package number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstExpPOPacDetResponse></returns>
		/// <exception cref="M3Exception<LstExpPOPacDetResponse>"></exception>
		public async Task<M3Response<LstExpPOPacDetResponse>> LstExpPOPacDet(
			string m3E0PA, 
			string m3WHLO, 
			string m3SUDO = null, 
			DateTime? m3DNDT = null, 
			string m3SUNO = null, 
			int? m3SUTY = null, 
			string m3PANR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstExpPOPacDet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (m3DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3DNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3SUTY.HasValue)
				request.WithQueryParameter("SUTY", m3SUTY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PANR))
				request.WithQueryParameter("PANR", m3PANR.Trim());

			// Execute the request
			var result = await Execute<LstExpPOPacDetResponse>(
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
		/// Name LstExpRec
		/// Description List Expected Receipts
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3TTYP">Stock transaction type</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3DOWN">0/blank=Unprocessed, 1=Processed</param>
		/// <param name="m3EXPR">Exclude prc before</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstExpRecResponse></returns>
		/// <exception cref="M3Exception<LstExpRecResponse>"></exception>
		public async Task<M3Response<LstExpRecResponse>> LstExpRec(
			string m3E0PA, 
			int? m3CONO = null, 
			string m3WHLO = null, 
			int? m3TTYP = null, 
			string m3RIDN = null, 
			int? m3DOWN = null, 
			int? m3EXPR = null, 
			long? m3REPN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstExpRec",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3TTYP.HasValue)
				request.WithQueryParameter("TTYP", m3TTYP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3DOWN.HasValue)
				request.WithQueryParameter("DOWN", m3DOWN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXPR.HasValue)
				request.WithQueryParameter("EXPR", m3EXPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstExpRecResponse>(
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
		/// Name LstExpRecDetail
		/// Description List Expected Receipts Detail
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3TTYP">Stock transaction type</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3RIDI">Order index</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3DOWN">0/blank=Unprocessed, 1=Processed</param>
		/// <param name="m3EXPR">xclude prc before</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstExpRecDetailResponse></returns>
		/// <exception cref="M3Exception<LstExpRecDetailResponse>"></exception>
		public async Task<M3Response<LstExpRecDetailResponse>> LstExpRecDetail(
			string m3E0PA, 
			int? m3CONO = null, 
			string m3WHLO = null, 
			int? m3TTYP = null, 
			string m3RIDN = null, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
			decimal? m3RIDI = null, 
			long? m3REPN = null, 
			int? m3DOWN = null, 
			int? m3EXPR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstExpRecDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
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
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DOWN.HasValue)
				request.WithQueryParameter("DOWN", m3DOWN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXPR.HasValue)
				request.WithQueryParameter("EXPR", m3EXPR.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstExpRecDetailResponse>(
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
		/// Name LstExpRecPac
		/// Description List Expected Rec. Packages
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3E0PA">Partner</param>
		/// <param name="m3INOU">Direction</param>
		/// <param name="m3DIPA">Dissconnected Package</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="m3PANR">Package number</param>
		/// <param name="m3PACO">Package level</param>
		/// <param name="m3DOWN">Download</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="m3TTYP">Stock transaction type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstExpRecPacResponse></returns>
		/// <exception cref="M3Exception<LstExpRecPacResponse>"></exception>
		public async Task<M3Response<LstExpRecPacResponse>> LstExpRecPac(
			int? m3CONO = null, 
			string m3E0PA = null, 
			int? m3INOU = null, 
			int? m3DIPA = null, 
			string m3WHLO = null, 
			decimal? m3DLIX = null, 
			string m3PANR = null, 
			int? m3PACO = null, 
			int? m3DOWN = null, 
			string m3SSCC = null, 
			int? m3TTYP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstExpRecPac",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3E0PA))
				request.WithQueryParameter("E0PA", m3E0PA.Trim());
			if (m3INOU.HasValue)
				request.WithQueryParameter("INOU", m3INOU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIPA.HasValue)
				request.WithQueryParameter("DIPA", m3DIPA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PANR))
				request.WithQueryParameter("PANR", m3PANR.Trim());
			if (m3PACO.HasValue)
				request.WithQueryParameter("PACO", m3PACO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DOWN.HasValue)
				request.WithQueryParameter("DOWN", m3DOWN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());
			if (m3TTYP.HasValue)
				request.WithQueryParameter("TTYP", m3TTYP.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstExpRecPacResponse>(
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
		/// Name LstExpRecPacDet
		/// Description List Expected Rec. Package  Details
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company number</param>
		/// <param name="m3E0PA">Partner</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="m3PANR">Package number</param>
		/// <param name="m3RORC">Ref. order category</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3DOWN">0/Blank = Unprocessed 1=Processed</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="m3TTYP">Stock transaction type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstExpRecPacDetResponse></returns>
		/// <exception cref="M3Exception<LstExpRecPacDetResponse>"></exception>
		public async Task<M3Response<LstExpRecPacDetResponse>> LstExpRecPacDet(
			int? m3CONO = null, 
			string m3E0PA = null, 
			string m3WHLO = null, 
			decimal? m3DLIX = null, 
			string m3PANR = null, 
			int? m3RORC = null, 
			string m3RIDN = null, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			int? m3DOWN = null, 
			string m3SSCC = null, 
			int? m3TTYP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstExpRecPacDet",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3E0PA))
				request.WithQueryParameter("E0PA", m3E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PANR))
				request.WithQueryParameter("PANR", m3PANR.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3DOWN.HasValue)
				request.WithQueryParameter("DOWN", m3DOWN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());
			if (m3TTYP.HasValue)
				request.WithQueryParameter("TTYP", m3TTYP.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstExpRecPacDetResponse>(
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
		/// Name LstPacStructDet
		/// Description List Package Structure Detail
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3INOU">Direction (Required)</param>
		/// <param name="m3DIPA">Disconnected package (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3PANR">Package number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="m3DOWN">Process flag - download</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPacStructDetResponse></returns>
		/// <exception cref="M3Exception<LstPacStructDetResponse>"></exception>
		public async Task<M3Response<LstPacStructDetResponse>> LstPacStructDet(
			string m3E0PA, 
			int m3INOU, 
			int m3DIPA, 
			string m3WHLO, 
			string m3PANR, 
			int? m3CONO = null, 
			decimal? m3DLIX = null, 
			int? m3DOWN = null, 
			string m3SSCC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPacStructDet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3PANR))
				throw new ArgumentNullException(nameof(m3PANR));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("INOU", m3INOU.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DIPA", m3DIPA.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("PANR", m3PANR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DOWN.HasValue)
				request.WithQueryParameter("DOWN", m3DOWN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());

			// Execute the request
			var result = await Execute<LstPacStructDetResponse>(
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
		/// Name PrcExpRec
		/// Description Process Expected Receipts
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3TTYP">Stock transaction type (Required)</param>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3REPN">Receiving number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DOWN">0/blank=Unprocessed, 1=Processed</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrcExpRec(
			string m3E0PA, 
			string m3WHLO, 
			int m3TTYP, 
			string m3RIDN, 
			long m3REPN, 
			int? m3CONO = null, 
			int? m3DOWN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrcExpRec",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("TTYP", m3TTYP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RIDN", m3RIDN.Trim())
				.WithQueryParameter("REPN", m3REPN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DOWN.HasValue)
				request.WithQueryParameter("DOWN", m3DOWN.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name PrcExpRecDetail
		/// Description List Expected Receipts Detail
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3TTYP">Stock transaction type (Required)</param>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3RIDL">Order line (Required)</param>
		/// <param name="m3RIDI">Order index (Required)</param>
		/// <param name="m3REPN">Receiving number (Required)</param>
		/// <param name="m3RELI">Receiving number line (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3DOWN">0/Blank = unprocessed/1 = processed</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrcExpRecDetail(
			string m3E0PA, 
			string m3WHLO, 
			int m3TTYP, 
			string m3RIDN, 
			int m3RIDL, 
			decimal m3RIDI, 
			long m3REPN, 
			int m3RELI, 
			int? m3CONO = null, 
			int? m3RIDX = null, 
			int? m3DOWN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrcExpRecDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("TTYP", m3TTYP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RIDN", m3RIDN.Trim())
				.WithQueryParameter("RIDL", m3RIDL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RIDI", m3RIDI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("REPN", m3REPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RELI", m3RELI.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DOWN.HasValue)
				request.WithQueryParameter("DOWN", m3DOWN.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name PrcExpRecPac
		/// Description Process Expected Receipts Package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3INOU">Direction (Required)</param>
		/// <param name="m3DIPA">Disconnected package (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PANR">Package number</param>
		/// <param name="m3DOWN">0/blank=Unprocessed,  1= Processed</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrcExpRecPac(
			string m3E0PA, 
			int m3INOU, 
			int m3DIPA, 
			string m3WHLO, 
			decimal m3DLIX, 
			int? m3CONO = null, 
			string m3PANR = null, 
			int? m3DOWN = null, 
			string m3SSCC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrcExpRecPac",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("INOU", m3INOU.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DIPA", m3DIPA.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PANR))
				request.WithQueryParameter("PANR", m3PANR.Trim());
			if (m3DOWN.HasValue)
				request.WithQueryParameter("DOWN", m3DOWN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());

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
