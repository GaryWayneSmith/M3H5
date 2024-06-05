/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.FAS001MI;
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
	/// Name: FAS001MI
	/// Component Name: Financials
	/// Description: Api: Fixed assets
	/// Version Release: 5ea0
	///</summary>
	public partial class FAS001MIResource : M3BaseResourceEndpoint
	{
		public FAS001MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "FAS001MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAsset
		/// Description AddAsset
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3ASID">Fixed asset (Required)</param>
		/// <param name="m3SBNO">Subnumber (Required)</param>
		/// <param name="m3FADS">Name (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3ARAT">Exchange rate (Required)</param>
		/// <param name="m3PPER">Acquisition date (Required)</param>
		/// <param name="m3FAQT">Fixed asset quantity (Required)</param>
		/// <param name="m3TXT1">Text line 1</param>
		/// <param name="m3TXT2">Text line 2</param>
		/// <param name="m3FATP">Fixed asset type</param>
		/// <param name="m3ACAT">Fixed asset group</param>
		/// <param name="m3LOC1">Location type 1</param>
		/// <param name="m3LOC2">Location type 2</param>
		/// <param name="m3LOC3">Location type 3</param>
		/// <param name="m3SRNO">Serial number</param>
		/// <param name="m3PINO">GUI picture</param>
		/// <param name="m3WADT">Warranty date</param>
		/// <param name="m3SECN">Service agreement</param>
		/// <param name="m3SECS">Service company</param>
		/// <param name="m3LCNO">Leasing agreement</param>
		/// <param name="m3LCCO">Leasing company</param>
		/// <param name="m3MPER">Manufacturing date</param>
		/// <param name="m3APER">Activation date</param>
		/// <param name="m3BPER">Building permit date</param>
		/// <param name="m3SPYN">Payee</param>
		/// <param name="m3VSER">Voucher number series</param>
		/// <param name="m3VONO">Voucher number</param>
		/// <param name="m3CCCO">Cost of capital method</param>
		/// <param name="m3AIT2">Accounting dimension 2</param>
		/// <param name="m3AIT3">Accounting dimension 3</param>
		/// <param name="m3AIT4">Accounting dimension 4</param>
		/// <param name="m3AIT5">Accounting dimension 5</param>
		/// <param name="m3AIT6">Accounting dimension 6</param>
		/// <param name="m3AIT7">Accounting dimension 7</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3PCDA">Last physical inventory date</param>
		/// <param name="m3PHCN">Physical inventory number</param>
		/// <param name="m3PHSN">Physical inventory run number</param>
		/// <param name="m3PHCT">Physical inventory text</param>
		/// <param name="m3PHCD">Physical inventory code</param>
		/// <param name="m3SPER">Sales date</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3CINO">Invoice number</param>
		/// <param name="m3SCUC">Currency</param>
		/// <param name="m3SRAT">Exchange rate</param>
		/// <param name="m3INNO">Individual item number</param>
		/// <param name="m3FRF1">User-defined field 1 - fixed asset</param>
		/// <param name="m3FRF2">User-defined field 2 - fixed asset</param>
		/// <param name="m3FRF3">User-defined field 3 - fixed asset</param>
		/// <param name="m3FRF4">User-defined field 4 - fixed asset</param>
		/// <param name="m3FRF5">User-defined field 5 - fixed asset</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3LRVD">Last revaluation date</param>
		/// <param name="m3REDA">Receipt date</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3EQGR">Equipment group</param>
		/// <param name="m3GEOX">Geographic code X</param>
		/// <param name="m3GEOY">Geographic code Y</param>
		/// <param name="m3GEOZ">Geographic code Z</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAsset(
			string m3DIVI, 
			string m3ASID, 
			string m3SBNO, 
			string m3FADS, 
			string m3CUCD, 
			decimal m3ARAT, 
			DateTime m3PPER, 
			decimal m3FAQT, 
			string m3TXT1 = null, 
			string m3TXT2 = null, 
			string m3FATP = null, 
			string m3ACAT = null, 
			string m3LOC1 = null, 
			string m3LOC2 = null, 
			string m3LOC3 = null, 
			string m3SRNO = null, 
			string m3PINO = null, 
			DateTime? m3WADT = null, 
			string m3SECN = null, 
			string m3SECS = null, 
			string m3LCNO = null, 
			string m3LCCO = null, 
			DateTime? m3MPER = null, 
			DateTime? m3APER = null, 
			DateTime? m3BPER = null, 
			string m3SPYN = null, 
			string m3VSER = null, 
			int? m3VONO = null, 
			string m3CCCO = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
			string m3REAR = null, 
			DateTime? m3PCDA = null, 
			long? m3PHCN = null, 
			int? m3PHSN = null, 
			string m3PHCT = null, 
			int? m3PHCD = null, 
			DateTime? m3SPER = null, 
			string m3PYNO = null, 
			string m3CINO = null, 
			string m3SCUC = null, 
			decimal? m3SRAT = null, 
			string m3INNO = null, 
			string m3FRF1 = null, 
			string m3FRF2 = null, 
			string m3FRF3 = null, 
			string m3FRF4 = null, 
			string m3FRF5 = null, 
			decimal? m3TXID = null, 
			DateTime? m3LRVD = null, 
			DateTime? m3REDA = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3EQGR = null, 
			decimal? m3GEOX = null, 
			decimal? m3GEOY = null, 
			decimal? m3GEOZ = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddAsset",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3ASID))
				throw new ArgumentNullException(nameof(m3ASID));
			if (string.IsNullOrWhiteSpace(m3SBNO))
				throw new ArgumentNullException(nameof(m3SBNO));
			if (string.IsNullOrWhiteSpace(m3FADS))
				throw new ArgumentNullException(nameof(m3FADS));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("ASID", m3ASID.Trim())
				.WithQueryParameter("SBNO", m3SBNO.Trim())
				.WithQueryParameter("FADS", m3FADS.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("ARAT", m3ARAT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PPER", m3PPER.ToM3String())
				.WithQueryParameter("FAQT", m3FAQT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TXT1))
				request.WithQueryParameter("TXT1", m3TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT2))
				request.WithQueryParameter("TXT2", m3TXT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FATP))
				request.WithQueryParameter("FATP", m3FATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACAT))
				request.WithQueryParameter("ACAT", m3ACAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3LOC1))
				request.WithQueryParameter("LOC1", m3LOC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3LOC2))
				request.WithQueryParameter("LOC2", m3LOC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3LOC3))
				request.WithQueryParameter("LOC3", m3LOC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRNO))
				request.WithQueryParameter("SRNO", m3SRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PINO))
				request.WithQueryParameter("PINO", m3PINO.Trim());
			if (m3WADT.HasValue)
				request.WithQueryParameter("WADT", m3WADT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3SECN))
				request.WithQueryParameter("SECN", m3SECN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SECS))
				request.WithQueryParameter("SECS", m3SECS.Trim());
			if (!string.IsNullOrWhiteSpace(m3LCNO))
				request.WithQueryParameter("LCNO", m3LCNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3LCCO))
				request.WithQueryParameter("LCCO", m3LCCO.Trim());
			if (m3MPER.HasValue)
				request.WithQueryParameter("MPER", m3MPER.Value.ToM3String());
			if (m3APER.HasValue)
				request.WithQueryParameter("APER", m3APER.Value.ToM3String());
			if (m3BPER.HasValue)
				request.WithQueryParameter("BPER", m3BPER.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3SPYN))
				request.WithQueryParameter("SPYN", m3SPYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3VSER))
				request.WithQueryParameter("VSER", m3VSER.Trim());
			if (m3VONO.HasValue)
				request.WithQueryParameter("VONO", m3VONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CCCO))
				request.WithQueryParameter("CCCO", m3CCCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT2))
				request.WithQueryParameter("AIT2", m3AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT3))
				request.WithQueryParameter("AIT3", m3AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT4))
				request.WithQueryParameter("AIT4", m3AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT5))
				request.WithQueryParameter("AIT5", m3AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT6))
				request.WithQueryParameter("AIT6", m3AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT7))
				request.WithQueryParameter("AIT7", m3AIT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (m3PCDA.HasValue)
				request.WithQueryParameter("PCDA", m3PCDA.Value.ToM3String());
			if (m3PHCN.HasValue)
				request.WithQueryParameter("PHCN", m3PHCN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PHSN.HasValue)
				request.WithQueryParameter("PHSN", m3PHSN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PHCT))
				request.WithQueryParameter("PHCT", m3PHCT.Trim());
			if (m3PHCD.HasValue)
				request.WithQueryParameter("PHCD", m3PHCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPER.HasValue)
				request.WithQueryParameter("SPER", m3SPER.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CINO))
				request.WithQueryParameter("CINO", m3CINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SCUC))
				request.WithQueryParameter("SCUC", m3SCUC.Trim());
			if (m3SRAT.HasValue)
				request.WithQueryParameter("SRAT", m3SRAT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INNO))
				request.WithQueryParameter("INNO", m3INNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRF1))
				request.WithQueryParameter("FRF1", m3FRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRF2))
				request.WithQueryParameter("FRF2", m3FRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRF3))
				request.WithQueryParameter("FRF3", m3FRF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRF4))
				request.WithQueryParameter("FRF4", m3FRF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRF5))
				request.WithQueryParameter("FRF5", m3FRF5.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LRVD.HasValue)
				request.WithQueryParameter("LRVD", m3LRVD.Value.ToM3String());
			if (m3REDA.HasValue)
				request.WithQueryParameter("REDA", m3REDA.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQGR))
				request.WithQueryParameter("EQGR", m3EQGR.Trim());
			if (m3GEOX.HasValue)
				request.WithQueryParameter("GEOX", m3GEOX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEOY.HasValue)
				request.WithQueryParameter("GEOY", m3GEOY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEOZ.HasValue)
				request.WithQueryParameter("GEOZ", m3GEOZ.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetAsset
		/// Description Get Asset
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3ASID">Fixed asset (Required)</param>
		/// <param name="m3SBNO">Subnumber (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAssetResponse></returns>
		/// <exception cref="M3Exception<GetAssetResponse>"></exception>
		public async Task<M3Response<GetAssetResponse>> GetAsset(
			string m3DIVI, 
			string m3ASID, 
			int m3SBNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetAsset",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3ASID))
				throw new ArgumentNullException(nameof(m3ASID));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("ASID", m3ASID.Trim())
				.WithQueryParameter("SBNO", m3SBNO.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetAssetResponse>(
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
		/// Name GetDeprType
		/// Description Get Depreciation Type
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3ASID">Fixed asset (Required)</param>
		/// <param name="m3SBNO">Subnumber (Required)</param>
		/// <param name="m3DPTP">Depreciation type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDeprTypeResponse></returns>
		/// <exception cref="M3Exception<GetDeprTypeResponse>"></exception>
		public async Task<M3Response<GetDeprTypeResponse>> GetDeprType(
			string m3DIVI, 
			string m3ASID, 
			int m3SBNO, 
			int m3DPTP, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetDeprType",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3ASID))
				throw new ArgumentNullException(nameof(m3ASID));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("ASID", m3ASID.Trim())
				.WithQueryParameter("SBNO", m3SBNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DPTP", m3DPTP.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetDeprTypeResponse>(
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
		/// Name LstAsset
		/// Description Lst Asset
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3ASID">Fixed asset</param>
		/// <param name="m3SBNO">Subnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAssetResponse></returns>
		/// <exception cref="M3Exception<LstAssetResponse>"></exception>
		public async Task<M3Response<LstAssetResponse>> LstAsset(
			string m3DIVI, 
			string m3ASID = null, 
			int? m3SBNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAsset",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ASID))
				request.WithQueryParameter("ASID", m3ASID.Trim());
			if (m3SBNO.HasValue)
				request.WithQueryParameter("SBNO", m3SBNO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAssetResponse>(
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
		/// Name LstDeprTypes
		/// Description List Depreciation Types
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3ASID">Fixed asset (Required)</param>
		/// <param name="m3SBNO">Subnumber (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDeprTypesResponse></returns>
		/// <exception cref="M3Exception<LstDeprTypesResponse>"></exception>
		public async Task<M3Response<LstDeprTypesResponse>> LstDeprTypes(
			string m3DIVI, 
			string m3ASID, 
			int m3SBNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstDeprTypes",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3ASID))
				throw new ArgumentNullException(nameof(m3ASID));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("ASID", m3ASID.Trim())
				.WithQueryParameter("SBNO", m3SBNO.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstDeprTypesResponse>(
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
		/// Name UpdateAsset
		/// Description UpdateAsset
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3ASID">Fixed asset (Required)</param>
		/// <param name="m3SBNO">Subnumber (Required)</param>
		/// <param name="m3FAST">Status - fixed asset</param>
		/// <param name="m3FADS">Name</param>
		/// <param name="m3TXT1">Text line 1</param>
		/// <param name="m3TXT2">Text line 2</param>
		/// <param name="m3FATP">Fixed asset type</param>
		/// <param name="m3ACAT">Fixed asset group</param>
		/// <param name="m3LOC1">Location type 1</param>
		/// <param name="m3LOC2">Location type 2</param>
		/// <param name="m3LOC3">Location type 3</param>
		/// <param name="m3SRNO">Serial number</param>
		/// <param name="m3PINO">GUI picture</param>
		/// <param name="m3WADT">Warranty date</param>
		/// <param name="m3SECN">Service agreement</param>
		/// <param name="m3SECS">Service company</param>
		/// <param name="m3LCNO">Service company</param>
		/// <param name="m3LCCO">Leasing company</param>
		/// <param name="m3MPER">Leasing company</param>
		/// <param name="m3APER">Activation date</param>
		/// <param name="m3BPER">Building permit date</param>
		/// <param name="m3SPYN">Payee</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3ARAT">Exchange rate</param>
		/// <param name="m3PPER">Acquisition date</param>
		/// <param name="m3CCCO">Cost of capital method</param>
		/// <param name="m3AIT2">Accounting dimension 2</param>
		/// <param name="m3AIT3">Accounting dimension 3</param>
		/// <param name="m3AIT4">Accounting dimension 4</param>
		/// <param name="m3AIT5">Accounting dimension 5</param>
		/// <param name="m3AIT6">Accounting dimension 6</param>
		/// <param name="m3AIT7">Accounting dimension 7</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3PCDA">Last physical inventory date</param>
		/// <param name="m3PHCN">Physical inventory number</param>
		/// <param name="m3PHSN">Physical inventory run number</param>
		/// <param name="m3PHCT">Physical inventory text</param>
		/// <param name="m3PHCD">Physical inventory code</param>
		/// <param name="m3SPER">Sales date</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3CINO">Invoice number</param>
		/// <param name="m3SCUC">Currency</param>
		/// <param name="m3SRAT">Exchange rate</param>
		/// <param name="m3INNO">Individual item number</param>
		/// <param name="m3FRF1">User-defined field 1 - fixed asset</param>
		/// <param name="m3FRF2">User-defined field 2 - fixed asset</param>
		/// <param name="m3FRF3">User-defined field 3 - fixed asset</param>
		/// <param name="m3FRF4">User-defined field 4 - fixed asset</param>
		/// <param name="m3FRF5">User-defined field 5 - fixed asset</param>
		/// <param name="m3FAQT">Fixed asset quantity</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3LRVD">Last revaluation date</param>
		/// <param name="m3REDA">Receipt date</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3EQGR">Equipment group</param>
		/// <param name="m3GEOX">Geographic code X</param>
		/// <param name="m3GEOY">Geographic code Y</param>
		/// <param name="m3GEOZ">Geographic code Z</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdateAsset(
			string m3DIVI, 
			string m3ASID, 
			int m3SBNO, 
			int? m3FAST = null, 
			string m3FADS = null, 
			string m3TXT1 = null, 
			string m3TXT2 = null, 
			string m3FATP = null, 
			string m3ACAT = null, 
			string m3LOC1 = null, 
			string m3LOC2 = null, 
			string m3LOC3 = null, 
			string m3SRNO = null, 
			string m3PINO = null, 
			DateTime? m3WADT = null, 
			string m3SECN = null, 
			string m3SECS = null, 
			string m3LCNO = null, 
			string m3LCCO = null, 
			DateTime? m3MPER = null, 
			DateTime? m3APER = null, 
			DateTime? m3BPER = null, 
			string m3SPYN = null, 
			string m3CUCD = null, 
			decimal? m3ARAT = null, 
			DateTime? m3PPER = null, 
			string m3CCCO = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
			string m3REAR = null, 
			DateTime? m3PCDA = null, 
			string m3PHCN = null, 
			string m3PHSN = null, 
			string m3PHCT = null, 
			string m3PHCD = null, 
			DateTime? m3SPER = null, 
			string m3PYNO = null, 
			string m3CINO = null, 
			string m3SCUC = null, 
			string m3SRAT = null, 
			string m3INNO = null, 
			string m3FRF1 = null, 
			string m3FRF2 = null, 
			string m3FRF3 = null, 
			string m3FRF4 = null, 
			string m3FRF5 = null, 
			string m3FAQT = null, 
			string m3TXID = null, 
			DateTime? m3LRVD = null, 
			DateTime? m3REDA = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3EQGR = null, 
			string m3GEOX = null, 
			string m3GEOY = null, 
			string m3GEOZ = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdateAsset",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3ASID))
				throw new ArgumentNullException(nameof(m3ASID));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("ASID", m3ASID.Trim())
				.WithQueryParameter("SBNO", m3SBNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3FAST.HasValue)
				request.WithQueryParameter("FAST", m3FAST.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FADS))
				request.WithQueryParameter("FADS", m3FADS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT1))
				request.WithQueryParameter("TXT1", m3TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT2))
				request.WithQueryParameter("TXT2", m3TXT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FATP))
				request.WithQueryParameter("FATP", m3FATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACAT))
				request.WithQueryParameter("ACAT", m3ACAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3LOC1))
				request.WithQueryParameter("LOC1", m3LOC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3LOC2))
				request.WithQueryParameter("LOC2", m3LOC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3LOC3))
				request.WithQueryParameter("LOC3", m3LOC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRNO))
				request.WithQueryParameter("SRNO", m3SRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PINO))
				request.WithQueryParameter("PINO", m3PINO.Trim());
			if (m3WADT.HasValue)
				request.WithQueryParameter("WADT", m3WADT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3SECN))
				request.WithQueryParameter("SECN", m3SECN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SECS))
				request.WithQueryParameter("SECS", m3SECS.Trim());
			if (!string.IsNullOrWhiteSpace(m3LCNO))
				request.WithQueryParameter("LCNO", m3LCNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3LCCO))
				request.WithQueryParameter("LCCO", m3LCCO.Trim());
			if (m3MPER.HasValue)
				request.WithQueryParameter("MPER", m3MPER.Value.ToM3String());
			if (m3APER.HasValue)
				request.WithQueryParameter("APER", m3APER.Value.ToM3String());
			if (m3BPER.HasValue)
				request.WithQueryParameter("BPER", m3BPER.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3SPYN))
				request.WithQueryParameter("SPYN", m3SPYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3ARAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PPER.HasValue)
				request.WithQueryParameter("PPER", m3PPER.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CCCO))
				request.WithQueryParameter("CCCO", m3CCCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT2))
				request.WithQueryParameter("AIT2", m3AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT3))
				request.WithQueryParameter("AIT3", m3AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT4))
				request.WithQueryParameter("AIT4", m3AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT5))
				request.WithQueryParameter("AIT5", m3AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT6))
				request.WithQueryParameter("AIT6", m3AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT7))
				request.WithQueryParameter("AIT7", m3AIT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (m3PCDA.HasValue)
				request.WithQueryParameter("PCDA", m3PCDA.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PHCN))
				request.WithQueryParameter("PHCN", m3PHCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHSN))
				request.WithQueryParameter("PHSN", m3PHSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHCT))
				request.WithQueryParameter("PHCT", m3PHCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHCD))
				request.WithQueryParameter("PHCD", m3PHCD.Trim());
			if (m3SPER.HasValue)
				request.WithQueryParameter("SPER", m3SPER.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CINO))
				request.WithQueryParameter("CINO", m3CINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SCUC))
				request.WithQueryParameter("SCUC", m3SCUC.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRAT))
				request.WithQueryParameter("SRAT", m3SRAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3INNO))
				request.WithQueryParameter("INNO", m3INNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRF1))
				request.WithQueryParameter("FRF1", m3FRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRF2))
				request.WithQueryParameter("FRF2", m3FRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRF3))
				request.WithQueryParameter("FRF3", m3FRF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRF4))
				request.WithQueryParameter("FRF4", m3FRF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRF5))
				request.WithQueryParameter("FRF5", m3FRF5.Trim());
			if (!string.IsNullOrWhiteSpace(m3FAQT))
				request.WithQueryParameter("FAQT", m3FAQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXID))
				request.WithQueryParameter("TXID", m3TXID.Trim());
			if (m3LRVD.HasValue)
				request.WithQueryParameter("LRVD", m3LRVD.Value.ToM3String());
			if (m3REDA.HasValue)
				request.WithQueryParameter("REDA", m3REDA.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQGR))
				request.WithQueryParameter("EQGR", m3EQGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3GEOX))
				request.WithQueryParameter("GEOX", m3GEOX.Trim());
			if (!string.IsNullOrWhiteSpace(m3GEOY))
				request.WithQueryParameter("GEOY", m3GEOY.Trim());
			if (!string.IsNullOrWhiteSpace(m3GEOZ))
				request.WithQueryParameter("GEOZ", m3GEOZ.Trim());

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
