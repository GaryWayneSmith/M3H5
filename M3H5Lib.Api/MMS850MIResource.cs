/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.MMS850MI;
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
	/// Name: MMS850MI
	/// Component Name: InternalStockTransaction
	/// Description: Internal stock transaction interface
	/// Version Release: 5ea1
	///</summary>
	public partial class MMS850MIResource : M3BaseResourceEndpoint
	{
		public MMS850MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS850MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAdjust
		/// Description Add Stock Adjustment Transaction (update with +/- qty)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3PRFL">Process flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSNR">Message number</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3MSGS">Sequence number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3QLQT">Quantity</param>
		/// <param name="m3QLUN">Qualifier unit of measure</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3USD1">User defined 1</param>
		/// <param name="m3USD2">User defined 2</param>
		/// <param name="m3USD3">User defined 3</param>
		/// <param name="m3USD4">User defined 4</param>
		/// <param name="m3USD5">User defined 5</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3QLDT">Qualifier date</param>
		/// <param name="m3QLTM">Qualifier time</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3STAG">Status - physical inv</param>
		/// <param name="m3PRDT">Priority date</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddAdjustResponse></returns>
		/// <exception cref="M3Exception<AddAdjustResponse>"></exception>
		public async Task<M3Response<AddAdjustResponse>> AddAdjust(
			string m3E0PA, 
			string m3E065, 
			string m3WHLO, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSNR = null, 
			int? m3MSLN = null, 
			int? m3MSGS = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3WHSL = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			long? m3REPN = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			decimal? m3QLQT = null, 
			string m3QLUN = null, 
			string m3BREM = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			string m3RSCD = null, 
			DateTime? m3QLDT = null, 
			int? m3QLTM = null, 
			decimal? m3CAWE = null, 
			string m3PMSN = null, 
			int? m3STAG = null, 
			DateTime? m3PRDT = null, 
			string m3RESP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAdjust",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSNR))
				request.WithQueryParameter("MSNR", m3MSNR.Trim());
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3MSGS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QLQT.HasValue)
				request.WithQueryParameter("QLQT", m3QLQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QLUN))
				request.WithQueryParameter("QLUN", m3QLUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (m3QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3QLDT.Value.ToM3String());
			if (m3QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3QLTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (m3STAG.HasValue)
				request.WithQueryParameter("STAG", m3STAG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());

			// Execute the request
			var result = await Execute<AddAdjustResponse>(
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
		/// Name AddLocClean
		/// Description Add location clean transaction
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3WHSL">Location (Required)</param>
		/// <param name="m3QLDT">Qualifier date (Required)</param>
		/// <param name="m3QLTM">Qualifier time (Required)</param>
		/// <param name="m3PRFL">Process flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSNR">Message number</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3MSGS">Sequence number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3USD1">User defined 1</param>
		/// <param name="m3USD2">User defined 2</param>
		/// <param name="m3USD3">User defined 3</param>
		/// <param name="m3USD4">User defined 4</param>
		/// <param name="m3USD5">User defined 5</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddLocCleanResponse></returns>
		/// <exception cref="M3Exception<AddLocCleanResponse>"></exception>
		public async Task<M3Response<AddLocCleanResponse>> AddLocClean(
			string m3E0PA, 
			string m3E065, 
			string m3WHLO, 
			string m3WHSL, 
			DateTime m3QLDT, 
			int m3QLTM, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSNR = null, 
			int? m3MSLN = null, 
			int? m3MSGS = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3ITNO = null, 
			long? m3REPN = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			string m3BREM = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			string m3RSCD = null, 
			string m3PMSN = null, 
			string m3RESP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLocClean",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3WHSL))
				throw new ArgumentNullException(nameof(m3WHSL));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("WHSL", m3WHSL.Trim())
				.WithQueryParameter("QLDT", m3QLDT.ToM3String())
				.WithQueryParameter("QLTM", m3QLTM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSNR))
				request.WithQueryParameter("MSNR", m3MSNR.Trim());
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3MSGS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());

			// Execute the request
			var result = await Execute<AddLocCleanResponse>(
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
		/// Name AddLotBlend
		/// Description Add Lot Blend Transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3PRFL">Process flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSNR">Message number</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3MSGS">Sequence number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3QLQT">Quantity</param>
		/// <param name="m3QLUN">Qualifier unit of measure</param>
		/// <param name="m3QLDT">Qualifier date</param>
		/// <param name="m3TWSL">To Location</param>
		/// <param name="m3TOCA">To Container</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3USD1">User defined 1</param>
		/// <param name="m3USD2">User defined 2</param>
		/// <param name="m3USD3">User defined 3</param>
		/// <param name="m3USD4">User defined 4</param>
		/// <param name="m3USD5">User defined 5</param>
		/// <param name="m3TASN">Task number</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3QLTM">Qualifier time</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddLotBlendResponse></returns>
		/// <exception cref="M3Exception<AddLotBlendResponse>"></exception>
		public async Task<M3Response<AddLotBlendResponse>> AddLotBlend(
			string m3E0PA, 
			string m3E065, 
			string m3WHLO, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSNR = null, 
			int? m3MSLN = null, 
			int? m3MSGS = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3WHSL = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			long? m3REPN = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			decimal? m3QLQT = null, 
			string m3QLUN = null, 
			DateTime? m3QLDT = null, 
			string m3TWSL = null, 
			string m3TOCA = null, 
			decimal? m3CAWE = null, 
			string m3BREM = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			long? m3TASN = null, 
			string m3PMSN = null, 
			int? m3QLTM = null, 
			string m3RESP = null, 
			string m3RSCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLotBlend",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSNR))
				request.WithQueryParameter("MSNR", m3MSNR.Trim());
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3MSGS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QLQT.HasValue)
				request.WithQueryParameter("QLQT", m3QLQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QLUN))
				request.WithQueryParameter("QLUN", m3QLUN.Trim());
			if (m3QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3QLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOCA))
				request.WithQueryParameter("TOCA", m3TOCA.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3TASN.HasValue)
				request.WithQueryParameter("TASN", m3TASN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (m3QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3QLTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());

			// Execute the request
			var result = await Execute<AddLotBlendResponse>(
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
		/// Name AddMOOrdLess
		/// Description Orderless manufacturing
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3STRT">Product stucture type (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSNR">Message number</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3MSGS">Sequence number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3POCY">Normal potency</param>
		/// <param name="m3MAUN">Manufacturing U/M</param>
		/// <param name="m3STAS">Status - balance ID</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddMOOrdLessResponse></returns>
		/// <exception cref="M3Exception<AddMOOrdLessResponse>"></exception>
		public async Task<M3Response<AddMOOrdLessResponse>> AddMOOrdLess(
			string m3E0PA, 
			string m3E065, 
			string m3WHLO, 
			string m3PRNO, 
			string m3STRT, 
			string m3PRMD = null, 
			int? m3CONO = null, 
			string m3MSNR = null, 
			int? m3MSLN = null, 
			int? m3MSGS = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			decimal? m3ORQT = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			decimal? m3CAWE = null, 
			int? m3POCY = null, 
			string m3MAUN = null, 
			string m3STAS = null, 
			DateTime? m3TRDT = null, 
			string m3RESP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddMOOrdLess",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3STRT))
				throw new ArgumentNullException(nameof(m3STRT));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("STRT", m3STRT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSNR))
				request.WithQueryParameter("MSNR", m3MSNR.Trim());
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3MSGS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3ORQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POCY.HasValue)
				request.WithQueryParameter("POCY", m3POCY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MAUN))
				request.WithQueryParameter("MAUN", m3MAUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAS))
				request.WithQueryParameter("STAS", m3STAS.Trim());
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());

			// Execute the request
			var result = await Execute<AddMOOrdLessResponse>(
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
		/// Name AddMove
		/// Description Add Stock Movement Transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3PRFL">Process flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSNR">Message number</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3MSGS">Sequence number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3QLQT">Quantity</param>
		/// <param name="m3QLUN">Qualifier unit of measure</param>
		/// <param name="m3QLDT">Qualifier date</param>
		/// <param name="m3TWSL">To Location</param>
		/// <param name="m3TOCA">To Container</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3USD1">User defined 1</param>
		/// <param name="m3USD2">User defined 2</param>
		/// <param name="m3USD3">User defined 3</param>
		/// <param name="m3USD4">User defined 4</param>
		/// <param name="m3USD5">User defined 5</param>
		/// <param name="m3TASN">Task number</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3QLTM">Qualifier time</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddMoveResponse></returns>
		/// <exception cref="M3Exception<AddMoveResponse>"></exception>
		public async Task<M3Response<AddMoveResponse>> AddMove(
			string m3E0PA, 
			string m3E065, 
			string m3WHLO, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSNR = null, 
			int? m3MSLN = null, 
			int? m3MSGS = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3WHSL = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			long? m3REPN = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			decimal? m3QLQT = null, 
			string m3QLUN = null, 
			DateTime? m3QLDT = null, 
			string m3TWSL = null, 
			string m3TOCA = null, 
			decimal? m3CAWE = null, 
			string m3BREM = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			long? m3TASN = null, 
			string m3PMSN = null, 
			int? m3QLTM = null, 
			string m3RESP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddMove",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSNR))
				request.WithQueryParameter("MSNR", m3MSNR.Trim());
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3MSGS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QLQT.HasValue)
				request.WithQueryParameter("QLQT", m3QLQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QLUN))
				request.WithQueryParameter("QLUN", m3QLUN.Trim());
			if (m3QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3QLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOCA))
				request.WithQueryParameter("TOCA", m3TOCA.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3TASN.HasValue)
				request.WithQueryParameter("TASN", m3TASN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (m3QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3QLTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());

			// Execute the request
			var result = await Execute<AddMoveResponse>(
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
		/// Name AddMoveAll
		/// Description Add Stock Movement Transaction
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3PRFL">Process flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSNR">Message number</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3MSGS">Sequence number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3QLUN">Qualifier unit of measure</param>
		/// <param name="m3QLDT">Qualifier date</param>
		/// <param name="m3TWSL">To Location</param>
		/// <param name="m3TOCA">To Container</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3USD1">User defined 1</param>
		/// <param name="m3USD2">User defined 2</param>
		/// <param name="m3USD3">User defined 3</param>
		/// <param name="m3USD4">User defined 4</param>
		/// <param name="m3USD5">User defined 5</param>
		/// <param name="m3TASN">Task number</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3QLTM">Qualifier time</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddMoveAllResponse></returns>
		/// <exception cref="M3Exception<AddMoveAllResponse>"></exception>
		public async Task<M3Response<AddMoveAllResponse>> AddMoveAll(
			string m3E0PA, 
			string m3E065, 
			string m3WHLO, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSNR = null, 
			int? m3MSLN = null, 
			int? m3MSGS = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3WHSL = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			long? m3REPN = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			string m3QLUN = null, 
			DateTime? m3QLDT = null, 
			string m3TWSL = null, 
			string m3TOCA = null, 
			decimal? m3CAWE = null, 
			string m3BREM = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			long? m3TASN = null, 
			string m3PMSN = null, 
			int? m3QLTM = null, 
			string m3RESP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddMoveAll",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSNR))
				request.WithQueryParameter("MSNR", m3MSNR.Trim());
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3MSGS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QLUN))
				request.WithQueryParameter("QLUN", m3QLUN.Trim());
			if (m3QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3QLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOCA))
				request.WithQueryParameter("TOCA", m3TOCA.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3TASN.HasValue)
				request.WithQueryParameter("TASN", m3TASN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (m3QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3QLTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());

			// Execute the request
			var result = await Execute<AddMoveAllResponse>(
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
		/// Name AddPackMove
		/// Description Add Package movement transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3PANR">Package number (Required)</param>
		/// <param name="m3PRFL">Process flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSNR">Message Number</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3MSGS">Sequence number</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="m3TOCA">To container</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3QLDT">Qualifier date</param>
		/// <param name="m3QLTM">Qualifier time</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPackMoveResponse></returns>
		/// <exception cref="M3Exception<AddPackMoveResponse>"></exception>
		public async Task<M3Response<AddPackMoveResponse>> AddPackMove(
			string m3E0PA, 
			string m3E065, 
			string m3WHLO, 
			string m3PANR, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSNR = null, 
			int? m3MSLN = null, 
			int? m3MSGS = null, 
			string m3TWSL = null, 
			string m3TOCA = null, 
			string m3PMSN = null, 
			DateTime? m3QLDT = null, 
			int? m3QLTM = null, 
			string m3RESP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPackMove",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3PANR))
				throw new ArgumentNullException(nameof(m3PANR));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("PANR", m3PANR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSNR))
				request.WithQueryParameter("MSNR", m3MSNR.Trim());
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3MSGS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOCA))
				request.WithQueryParameter("TOCA", m3TOCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (m3QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3QLDT.Value.ToM3String());
			if (m3QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3QLTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());

			// Execute the request
			var result = await Execute<AddPackMoveResponse>(
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
		/// Name AddPartialCount
		/// Description Partial counts for physical inventory
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3STNB">Physical inventory number (Required)</param>
		/// <param name="m3PRFL">Process flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSNR">Message Number</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3MSGS">Sequence number</param>
		/// <param name="m3STRN">Physical inventory line</param>
		/// <param name="m3STQI">Physical inventory quantity</param>
		/// <param name="m3QLDT">Qualifier date</param>
		/// <param name="m3QLTM">Qualifier time</param>
		/// <param name="m3QLUN">Qualifier unit of measure</param>
		/// <param name="m3SAQI">Physical inventory quantity - Main U/M</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias category</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3STAG">Status - physical inventory</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3RENU">Recount number</param>
		/// <param name="m3STBT">On-hand balance to compare</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPartialCountResponse></returns>
		/// <exception cref="M3Exception<AddPartialCountResponse>"></exception>
		public async Task<M3Response<AddPartialCountResponse>> AddPartialCount(
			string m3E0PA, 
			string m3E065, 
			string m3WHLO, 
			long m3STNB, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSNR = null, 
			int? m3MSLN = null, 
			int? m3MSGS = null, 
			int? m3STRN = null, 
			decimal? m3STQI = null, 
			DateTime? m3QLDT = null, 
			int? m3QLTM = null, 
			string m3QLUN = null, 
			decimal? m3SAQI = null, 
			string m3ITNO = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			long? m3REPN = null, 
			string m3BREM = null, 
			string m3RESP = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			decimal? m3CAWE = null, 
			int? m3STAG = null, 
			string m3PMSN = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			int? m3RENU = null, 
			int? m3STBT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPartialCount",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("STNB", m3STNB.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSNR))
				request.WithQueryParameter("MSNR", m3MSNR.Trim());
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3MSGS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STRN.HasValue)
				request.WithQueryParameter("STRN", m3STRN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STQI.HasValue)
				request.WithQueryParameter("STQI", m3STQI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3QLDT.Value.ToM3String());
			if (m3QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3QLTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QLUN))
				request.WithQueryParameter("QLUN", m3QLUN.Trim());
			if (m3SAQI.HasValue)
				request.WithQueryParameter("SAQI", m3SAQI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STAG.HasValue)
				request.WithQueryParameter("STAG", m3STAG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3RENU.HasValue)
				request.WithQueryParameter("RENU", m3RENU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STBT.HasValue)
				request.WithQueryParameter("STBT", m3STBT.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddPartialCountResponse>(
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
		/// Name AddPrtFrstCount
		/// Description Partial counts for physical inventory first count
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3STNB">Physical inventory number (Required)</param>
		/// <param name="m3PRFL">Process flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSNR">Message Number</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3MSGS">Sequence number</param>
		/// <param name="m3STRN">Physical inventory line</param>
		/// <param name="m3STQI">Physical inventory quantity</param>
		/// <param name="m3QLDT">Qualifier date</param>
		/// <param name="m3QLTM">Qualifier time</param>
		/// <param name="m3QLUN">Qualifier unit of measure</param>
		/// <param name="m3SAQI">Physical inventory quantity - Main U/M</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias category</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3STAG">Status - physical inventory</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPrtFrstCountResponse></returns>
		/// <exception cref="M3Exception<AddPrtFrstCountResponse>"></exception>
		public async Task<M3Response<AddPrtFrstCountResponse>> AddPrtFrstCount(
			string m3E0PA, 
			string m3E065, 
			string m3WHLO, 
			long m3STNB, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSNR = null, 
			int? m3MSLN = null, 
			int? m3MSGS = null, 
			int? m3STRN = null, 
			decimal? m3STQI = null, 
			DateTime? m3QLDT = null, 
			int? m3QLTM = null, 
			string m3QLUN = null, 
			decimal? m3SAQI = null, 
			string m3ITNO = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			long? m3REPN = null, 
			string m3BREM = null, 
			string m3RESP = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			decimal? m3CAWE = null, 
			int? m3STAG = null, 
			string m3PMSN = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPrtFrstCount",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("STNB", m3STNB.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSNR))
				request.WithQueryParameter("MSNR", m3MSNR.Trim());
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3MSGS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STRN.HasValue)
				request.WithQueryParameter("STRN", m3STRN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STQI.HasValue)
				request.WithQueryParameter("STQI", m3STQI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3QLDT.Value.ToM3String());
			if (m3QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3QLTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QLUN))
				request.WithQueryParameter("QLUN", m3QLUN.Trim());
			if (m3SAQI.HasValue)
				request.WithQueryParameter("SAQI", m3SAQI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STAG.HasValue)
				request.WithQueryParameter("STAG", m3STAG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());

			// Execute the request
			var result = await Execute<AddPrtFrstCountResponse>(
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
		/// Name AddPrtFrstRecnt
		/// Description Partial counts for physical inventory first recount
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3STNB">Physical inventory number (Required)</param>
		/// <param name="m3PRFL">Process flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSNR">Message Number</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3MSGS">Sequence number</param>
		/// <param name="m3STRN">Physical inventory line</param>
		/// <param name="m3STQI">Physical inventory quantity</param>
		/// <param name="m3QLDT">Qualifier date</param>
		/// <param name="m3QLTM">Qualifier time</param>
		/// <param name="m3QLUN">Qualifier unit of measure</param>
		/// <param name="m3SAQI">Physical inventory quantity - Main U/M</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias category</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3STAG">Status - physical inventory</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPrtFrstRecntResponse></returns>
		/// <exception cref="M3Exception<AddPrtFrstRecntResponse>"></exception>
		public async Task<M3Response<AddPrtFrstRecntResponse>> AddPrtFrstRecnt(
			string m3E0PA, 
			string m3E065, 
			string m3WHLO, 
			long m3STNB, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSNR = null, 
			int? m3MSLN = null, 
			int? m3MSGS = null, 
			int? m3STRN = null, 
			decimal? m3STQI = null, 
			DateTime? m3QLDT = null, 
			int? m3QLTM = null, 
			string m3QLUN = null, 
			decimal? m3SAQI = null, 
			string m3ITNO = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			long? m3REPN = null, 
			string m3BREM = null, 
			string m3RESP = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			decimal? m3CAWE = null, 
			int? m3STAG = null, 
			string m3PMSN = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPrtFrstRecnt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("STNB", m3STNB.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSNR))
				request.WithQueryParameter("MSNR", m3MSNR.Trim());
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3MSGS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STRN.HasValue)
				request.WithQueryParameter("STRN", m3STRN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STQI.HasValue)
				request.WithQueryParameter("STQI", m3STQI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3QLDT.Value.ToM3String());
			if (m3QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3QLTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QLUN))
				request.WithQueryParameter("QLUN", m3QLUN.Trim());
			if (m3SAQI.HasValue)
				request.WithQueryParameter("SAQI", m3SAQI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STAG.HasValue)
				request.WithQueryParameter("STAG", m3STAG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());

			// Execute the request
			var result = await Execute<AddPrtFrstRecntResponse>(
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
		/// Name AddPrtScndRecnt
		/// Description Partial counts for physical inventory second count
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3STNB">Physical inventory number (Required)</param>
		/// <param name="m3PRFL">Process flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSNR">Message Number</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3MSGS">Sequence number</param>
		/// <param name="m3STRN">Physical inventory line</param>
		/// <param name="m3STQI">Physical inventory quantity</param>
		/// <param name="m3QLDT">Qualifier date</param>
		/// <param name="m3QLTM">Qualifier time</param>
		/// <param name="m3QLUN">Qualifier unit of measure</param>
		/// <param name="m3SAQI">Physical inventory quantity - Main U/M</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias category</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3STAG">Status - physical inventory</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPrtScndRecntResponse></returns>
		/// <exception cref="M3Exception<AddPrtScndRecntResponse>"></exception>
		public async Task<M3Response<AddPrtScndRecntResponse>> AddPrtScndRecnt(
			string m3E0PA, 
			string m3E065, 
			string m3WHLO, 
			long m3STNB, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSNR = null, 
			int? m3MSLN = null, 
			int? m3MSGS = null, 
			int? m3STRN = null, 
			decimal? m3STQI = null, 
			DateTime? m3QLDT = null, 
			int? m3QLTM = null, 
			string m3QLUN = null, 
			decimal? m3SAQI = null, 
			string m3ITNO = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			long? m3REPN = null, 
			string m3BREM = null, 
			string m3RESP = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			decimal? m3CAWE = null, 
			int? m3STAG = null, 
			string m3PMSN = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPrtScndRecnt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("STNB", m3STNB.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSNR))
				request.WithQueryParameter("MSNR", m3MSNR.Trim());
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3MSGS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STRN.HasValue)
				request.WithQueryParameter("STRN", m3STRN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STQI.HasValue)
				request.WithQueryParameter("STQI", m3STQI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3QLDT.Value.ToM3String());
			if (m3QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3QLTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QLUN))
				request.WithQueryParameter("QLUN", m3QLUN.Trim());
			if (m3SAQI.HasValue)
				request.WithQueryParameter("SAQI", m3SAQI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STAG.HasValue)
				request.WithQueryParameter("STAG", m3STAG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());

			// Execute the request
			var result = await Execute<AddPrtScndRecntResponse>(
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
		/// Name AddQty
		/// Description Add Stock Quantity Transaction (set to quantity)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3PRFL">Process flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSNR">Message number</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3MSGS">Sequence number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3QLQT">Quantity</param>
		/// <param name="m3QLUN">Qualifier unit of measure</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3USD1">User defined 1</param>
		/// <param name="m3USD2">User defined 2</param>
		/// <param name="m3USD3">User defined 3</param>
		/// <param name="m3USD4">User defined 4</param>
		/// <param name="m3USD5">User defined 5</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3QLDT">Qualifier date</param>
		/// <param name="m3QLTM">Qualifier time</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3STAG">Status - physical inventory</param>
		/// <param name="m3PRDT">Priority date</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddQtyResponse></returns>
		/// <exception cref="M3Exception<AddQtyResponse>"></exception>
		public async Task<M3Response<AddQtyResponse>> AddQty(
			string m3E0PA, 
			string m3E065, 
			string m3WHLO, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSNR = null, 
			int? m3MSLN = null, 
			int? m3MSGS = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3WHSL = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			long? m3REPN = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			decimal? m3QLQT = null, 
			string m3QLUN = null, 
			string m3BREM = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			string m3RSCD = null, 
			DateTime? m3QLDT = null, 
			int? m3QLTM = null, 
			decimal? m3CAWE = null, 
			string m3PMSN = null, 
			int? m3STAG = null, 
			DateTime? m3PRDT = null, 
			string m3RESP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddQty",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSNR))
				request.WithQueryParameter("MSNR", m3MSNR.Trim());
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3MSGS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QLQT.HasValue)
				request.WithQueryParameter("QLQT", m3QLQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QLUN))
				request.WithQueryParameter("QLUN", m3QLUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (m3QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3QLDT.Value.ToM3String());
			if (m3QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3QLTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (m3STAG.HasValue)
				request.WithQueryParameter("STAG", m3STAG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());

			// Execute the request
			var result = await Execute<AddQtyResponse>(
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
		/// Name AddRclLotSts
		/// Description Add Reclassification Of Lot Status
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3ALOC">Allocatable (Required)</param>
		/// <param name="m3PRFL">Process flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSNR">Message number</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3MSGS">Sequence number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3QLQT">Quantity</param>
		/// <param name="m3QLUN">Qualifier unit of measure</param>
		/// <param name="m3QLDT">Transaction date</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3STAS">Status - balance ID</param>
		/// <param name="m3USD1">User defined 1</param>
		/// <param name="m3USD2">User defined 2</param>
		/// <param name="m3USD3">User defined 3</param>
		/// <param name="m3USD4">User defined 4</param>
		/// <param name="m3USD5">User defined 5</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3EXPI">Expiration date</param>
		/// <param name="m3LPCY">Potency</param>
		/// <param name="m3CNDT">Follow-up date</param>
		/// <param name="m3SEDT">Sales date</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddRclLotStsResponse></returns>
		/// <exception cref="M3Exception<AddRclLotStsResponse>"></exception>
		public async Task<M3Response<AddRclLotStsResponse>> AddRclLotSts(
			string m3E0PA, 
			string m3E065, 
			string m3WHLO, 
			int m3ALOC, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSNR = null, 
			int? m3MSLN = null, 
			int? m3MSGS = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			string m3BREM = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			decimal? m3QLQT = null, 
			string m3QLUN = null, 
			DateTime? m3QLDT = null, 
			decimal? m3CAWE = null, 
			string m3RSCD = null, 
			string m3STAS = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			string m3PMSN = null, 
			DateTime? m3EXPI = null, 
			int? m3LPCY = null, 
			DateTime? m3CNDT = null, 
			DateTime? m3SEDT = null, 
			string m3RESP = null, 
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
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddRclLotSts",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("ALOC", m3ALOC.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSNR))
				request.WithQueryParameter("MSNR", m3MSNR.Trim());
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3MSGS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QLQT.HasValue)
				request.WithQueryParameter("QLQT", m3QLQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QLUN))
				request.WithQueryParameter("QLUN", m3QLUN.Trim());
			if (m3QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3QLDT.Value.ToM3String());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAS))
				request.WithQueryParameter("STAS", m3STAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (m3EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3EXPI.Value.ToM3String());
			if (m3LPCY.HasValue)
				request.WithQueryParameter("LPCY", m3LPCY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CNDT.HasValue)
				request.WithQueryParameter("CNDT", m3CNDT.Value.ToM3String());
			if (m3SEDT.HasValue)
				request.WithQueryParameter("SEDT", m3SEDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());

			// Execute the request
			var result = await Execute<AddRclLotStsResponse>(
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
		/// Name AddReclass
		/// Description Add Stock Reclassification Transaction
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3PRFL">Process flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSNR">Message number</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3MSGS">Sequence number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3QLQT">Quantity</param>
		/// <param name="m3QLUN">Qualifier unit of measure</param>
		/// <param name="m3QLDT">Transaction date</param>
		/// <param name="m3NITN">New item number</param>
		/// <param name="m3NBAN">New lot number</param>
		/// <param name="m3ALOC">Allocatable</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3STAS">Status - balance ID</param>
		/// <param name="m3USD1">User defined 1</param>
		/// <param name="m3USD2">User defined 2</param>
		/// <param name="m3USD3">User defined 3</param>
		/// <param name="m3USD4">User defined 4</param>
		/// <param name="m3USD5">User defined 5</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3CALT">Calculation method</param>
		/// <param name="m3QRBS">QI request basis</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddReclassResponse></returns>
		/// <exception cref="M3Exception<AddReclassResponse>"></exception>
		public async Task<M3Response<AddReclassResponse>> AddReclass(
			string m3E0PA, 
			string m3E065, 
			string m3WHLO, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSNR = null, 
			int? m3MSLN = null, 
			int? m3MSGS = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3WHSL = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			long? m3REPN = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			string m3BREM = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			decimal? m3QLQT = null, 
			string m3QLUN = null, 
			DateTime? m3QLDT = null, 
			string m3NITN = null, 
			string m3NBAN = null, 
			int? m3ALOC = null, 
			decimal? m3CAWE = null, 
			string m3RSCD = null, 
			string m3STAS = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			string m3PMSN = null, 
			string m3RESP = null, 
			int? m3CALT = null, 
			int? m3QRBS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddReclass",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSNR))
				request.WithQueryParameter("MSNR", m3MSNR.Trim());
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3MSGS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QLQT.HasValue)
				request.WithQueryParameter("QLQT", m3QLQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QLUN))
				request.WithQueryParameter("QLUN", m3QLUN.Trim());
			if (m3QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3QLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3NITN))
				request.WithQueryParameter("NITN", m3NITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3NBAN))
				request.WithQueryParameter("NBAN", m3NBAN.Trim());
			if (m3ALOC.HasValue)
				request.WithQueryParameter("ALOC", m3ALOC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAS))
				request.WithQueryParameter("STAS", m3STAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3CALT.HasValue)
				request.WithQueryParameter("CALT", m3CALT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QRBS.HasValue)
				request.WithQueryParameter("QRBS", m3QRBS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddReclassResponse>(
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
		/// Name AddStkHead
		/// Description Add Internal Stock Header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E0PB">Partner ID (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSNR">Message number</param>
		/// <param name="m3E0IO">Message direction</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3STLO">Lowest status</param>
		/// <param name="m3STHI">Highest status</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3CHGD">Date changed</param>
		/// <param name="m3E004">Sender/receiver ID</param>
		/// <param name="m3E007">Qualifier</param>
		/// <param name="m3E014">Routing address</param>
		/// <param name="m3E026">Application reference</param>
		/// <param name="m3E035">Test indicator</param>
		/// <param name="m3E052">Message version</param>
		/// <param name="m3E054">Message release</param>
		/// <param name="m3E051">Controlling organization</param>
		/// <param name="m3E057">Organization assigned code</param>
		/// <param name="m3E0QA">Code list qualifier</param>
		/// <param name="m3E0QB">Code list qualifier</param>
		/// <param name="m3DONR">Document number</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3EDFR">EDI reference</param>
		/// <param name="m3ID01">Message identity 1</param>
		/// <param name="m3ID02">Message identity 2</param>
		/// <param name="m3ID03">Message identity 3</param>
		/// <param name="m3ID04">Message identity 4</param>
		/// <param name="m3ID05">Message identity 5</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3CUDT">Customer´s purchase order date</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3DLSP">Delivery specification</param>
		/// <param name="m3RSAG">Delivery contract number</param>
		/// <param name="m3CARR">Carrier</param>
		/// <param name="m3CCAR">Customer´s carrier name</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3DTID">Data identity</param>
		/// <param name="m3LOCD">Local currency</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3ARAT">Exchange rate</param>
		/// <param name="m3RGDT">Not used!</param>
		/// <param name="m3RGTM">Not used!</param>
		/// <param name="m3LMDT">Not used!</param>
		/// <param name="m3CHNO">Not used!</param>
		/// <param name="m3CHID">Not used!</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddStkHeadResponse></returns>
		/// <exception cref="M3Exception<AddStkHeadResponse>"></exception>
		public async Task<M3Response<AddStkHeadResponse>> AddStkHead(
			string m3WHLO, 
			string m3E065, 
			string m3E0PA, 
			string m3E0PB, 
			int? m3CONO = null, 
			string m3MSNR = null, 
			string m3E0IO = null, 
			string m3FACI = null, 
			string m3CUNO = null, 
			string m3PMSN = null, 
			string m3STAT = null, 
			string m3STLO = null, 
			string m3STHI = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			DateTime? m3CHGD = null, 
			string m3E004 = null, 
			string m3E007 = null, 
			string m3E014 = null, 
			string m3E026 = null, 
			int? m3E035 = null, 
			string m3E052 = null, 
			string m3E054 = null, 
			string m3E051 = null, 
			string m3E057 = null, 
			string m3E0QA = null, 
			string m3E0QB = null, 
			string m3DONR = null, 
			string m3RESP = null, 
			string m3EDFR = null, 
			string m3ID01 = null, 
			string m3ID02 = null, 
			string m3ID03 = null, 
			string m3ID04 = null, 
			string m3ID05 = null, 
			string m3CUOR = null, 
			DateTime? m3CUDT = null, 
			string m3ADID = null, 
			string m3DLSP = null, 
			string m3RSAG = null, 
			string m3CARR = null, 
			string m3CCAR = null, 
			decimal? m3TXID = null, 
			decimal? m3DTID = null, 
			string m3LOCD = null, 
			string m3CUCD = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			decimal? m3ARAT = null, 
			DateTime? m3RGDT = null, 
			int? m3RGTM = null, 
			DateTime? m3LMDT = null, 
			int? m3CHNO = null, 
			string m3CHID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddStkHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E0PB))
				throw new ArgumentNullException(nameof(m3E0PB));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E0PB", m3E0PB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSNR))
				request.WithQueryParameter("MSNR", m3MSNR.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0IO))
				request.WithQueryParameter("E0IO", m3E0IO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STLO))
				request.WithQueryParameter("STLO", m3STLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STHI))
				request.WithQueryParameter("STHI", m3STHI.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3E004))
				request.WithQueryParameter("E004", m3E004.Trim());
			if (!string.IsNullOrWhiteSpace(m3E007))
				request.WithQueryParameter("E007", m3E007.Trim());
			if (!string.IsNullOrWhiteSpace(m3E014))
				request.WithQueryParameter("E014", m3E014.Trim());
			if (!string.IsNullOrWhiteSpace(m3E026))
				request.WithQueryParameter("E026", m3E026.Trim());
			if (m3E035.HasValue)
				request.WithQueryParameter("E035", m3E035.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3E052))
				request.WithQueryParameter("E052", m3E052.Trim());
			if (!string.IsNullOrWhiteSpace(m3E054))
				request.WithQueryParameter("E054", m3E054.Trim());
			if (!string.IsNullOrWhiteSpace(m3E051))
				request.WithQueryParameter("E051", m3E051.Trim());
			if (!string.IsNullOrWhiteSpace(m3E057))
				request.WithQueryParameter("E057", m3E057.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0QA))
				request.WithQueryParameter("E0QA", m3E0QA.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0QB))
				request.WithQueryParameter("E0QB", m3E0QB.Trim());
			if (!string.IsNullOrWhiteSpace(m3DONR))
				request.WithQueryParameter("DONR", m3DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDFR))
				request.WithQueryParameter("EDFR", m3EDFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ID01))
				request.WithQueryParameter("ID01", m3ID01.Trim());
			if (!string.IsNullOrWhiteSpace(m3ID02))
				request.WithQueryParameter("ID02", m3ID02.Trim());
			if (!string.IsNullOrWhiteSpace(m3ID03))
				request.WithQueryParameter("ID03", m3ID03.Trim());
			if (!string.IsNullOrWhiteSpace(m3ID04))
				request.WithQueryParameter("ID04", m3ID04.Trim());
			if (!string.IsNullOrWhiteSpace(m3ID05))
				request.WithQueryParameter("ID05", m3ID05.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (m3CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3CUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLSP))
				request.WithQueryParameter("DLSP", m3DLSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSAG))
				request.WithQueryParameter("RSAG", m3RSAG.Trim());
			if (!string.IsNullOrWhiteSpace(m3CARR))
				request.WithQueryParameter("CARR", m3CARR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CCAR))
				request.WithQueryParameter("CCAR", m3CCAR.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTID.HasValue)
				request.WithQueryParameter("DTID", m3DTID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LOCD))
				request.WithQueryParameter("LOCD", m3LOCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3ARAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3RGTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());
			if (m3CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3CHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());

			// Execute the request
			var result = await Execute<AddStkHeadResponse>(
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
		/// Name AddStkId
		/// Description Add Internal Stock Identity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSNR">Message number (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3WHSL">Location (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3PMSL">External message line number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3CHGD">Date changed</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3FUDS">Description 2</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3UNIT">Unit of measure</param>
		/// <param name="m3STLO">Lowest status</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3STHI">Highest status</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3RES2">Responsible</param>
		/// <param name="m3RES3">Responsible</param>
		/// <param name="m3RES4">Responsible</param>
		/// <param name="m3EDFR">EDI reference</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3RGDT">Not used!</param>
		/// <param name="m3RGTM">Not used!</param>
		/// <param name="m3LMDT">Not used!</param>
		/// <param name="m3CHNO">Not used!</param>
		/// <param name="m3CHID">Not used!</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddStkIdResponse></returns>
		/// <exception cref="M3Exception<AddStkIdResponse>"></exception>
		public async Task<M3Response<AddStkIdResponse>> AddStkId(
			string m3MSNR, 
			string m3WHLO, 
			string m3WHSL, 
			int? m3CONO = null, 
			int? m3MSLN = null, 
			string m3PMSN = null, 
			int? m3PMSL = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			DateTime? m3CHGD = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			long? m3REPN = null, 
			string m3FACI = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			string m3ITDS = null, 
			string m3FUDS = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			string m3BREM = null, 
			string m3UNIT = null, 
			string m3STLO = null, 
			string m3STAT = null, 
			string m3STHI = null, 
			decimal? m3TXID = null, 
			string m3RESP = null, 
			string m3RES2 = null, 
			string m3RES3 = null, 
			string m3RES4 = null, 
			string m3EDFR = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			DateTime? m3RGDT = null, 
			int? m3RGTM = null, 
			DateTime? m3LMDT = null, 
			int? m3CHNO = null, 
			string m3CHID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddStkId",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSNR))
				throw new ArgumentNullException(nameof(m3MSNR));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3WHSL))
				throw new ArgumentNullException(nameof(m3WHSL));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3MSNR.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("WHSL", m3WHSL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (m3PMSL.HasValue)
				request.WithQueryParameter("PMSL", m3PMSL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3FUDS))
				request.WithQueryParameter("FUDS", m3FUDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3UNIT))
				request.WithQueryParameter("UNIT", m3UNIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STLO))
				request.WithQueryParameter("STLO", m3STLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STHI))
				request.WithQueryParameter("STHI", m3STHI.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3RES2))
				request.WithQueryParameter("RES2", m3RES2.Trim());
			if (!string.IsNullOrWhiteSpace(m3RES3))
				request.WithQueryParameter("RES3", m3RES3.Trim());
			if (!string.IsNullOrWhiteSpace(m3RES4))
				request.WithQueryParameter("RES4", m3RES4.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDFR))
				request.WithQueryParameter("EDFR", m3EDFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3RGTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());
			if (m3CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3CHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());

			// Execute the request
			var result = await Execute<AddStkIdResponse>(
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
		/// Name AddStkIns
		/// Description Add Internal Stock Instruction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSNR">Message number (Required)</param>
		/// <param name="m3MSLN">Message line number (Required)</param>
		/// <param name="m3QLFR">Qualifier (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSGS">Sequence number</param>
		/// <param name="m3QLFS">Sequence number</param>
		/// <param name="m3QLFT">Qualifier type</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3PLFD">Planned finish date</param>
		/// <param name="m3PLFT">Time generated</param>
		/// <param name="m3FIDT">Finish date</param>
		/// <param name="m3FITE">Execution time</param>
		/// <param name="m3QLQT">Quantity</param>
		/// <param name="m3QLUN">Qualifier unit of measure</param>
		/// <param name="m3QLDT">Qualifier date</param>
		/// <param name="m3E0D5">Item price</param>
		/// <param name="m3E0CB">Currency</param>
		/// <param name="m3COCD">Costing price quantity</param>
		/// <param name="m3MSID">Message ID</param>
		/// <param name="m3MSGF">Message file</param>
		/// <param name="m3MSGD">Message</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3TWLO">To warehouse</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="m3NITN">New item number</param>
		/// <param name="m3NBAN">New lot number</param>
		/// <param name="m3TOCA">To container</param>
		/// <param name="m3ALOC">Allocatable</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3STAS">Status - balance ID</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3REMK">Remark</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3TRTP">Order type</param>
		/// <param name="m3TRQT">Transaction quantity - basic U/M</param>
		/// <param name="m3TRUN">Free trade association</param>
		/// <param name="m3POCY">Normal potency</param>
		/// <param name="m3PRDT">Priority date</param>
		/// <param name="m3REFE">Reference</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3RGDT">Not used!</param>
		/// <param name="m3RGTM">Not used!</param>
		/// <param name="m3LMDT">Not used!</param>
		/// <param name="m3CHNO">Not used!</param>
		/// <param name="m3CHID">Not used!</param>
		/// <param name="m3TASN">Task number</param>
		/// <param name="m3QLTM">Qualifier time</param>
		/// <param name="m3STAG">Status physical inv.</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddStkInsResponse></returns>
		/// <exception cref="M3Exception<AddStkInsResponse>"></exception>
		public async Task<M3Response<AddStkInsResponse>> AddStkIns(
			string m3MSNR, 
			int m3MSLN, 
			string m3QLFR, 
			int? m3CONO = null, 
			int? m3MSGS = null, 
			int? m3QLFS = null, 
			int? m3QLFT = null, 
			string m3STAT = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			DateTime? m3PLFD = null, 
			int? m3PLFT = null, 
			DateTime? m3FIDT = null, 
			int? m3FITE = null, 
			decimal? m3QLQT = null, 
			string m3QLUN = null, 
			DateTime? m3QLDT = null, 
			decimal? m3E0D5 = null, 
			string m3E0CB = null, 
			int? m3COCD = null, 
			string m3MSID = null, 
			string m3MSGF = null, 
			string m3MSGD = null, 
			decimal? m3TXID = null, 
			string m3TWLO = null, 
			string m3TWSL = null, 
			string m3NITN = null, 
			string m3NBAN = null, 
			string m3TOCA = null, 
			int? m3ALOC = null, 
			decimal? m3CAWE = null, 
			string m3STAS = null, 
			string m3RSCD = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			string m3REMK = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3WHLO = null, 
			string m3RORN = null, 
			string m3TRTP = null, 
			decimal? m3TRQT = null, 
			string m3TRUN = null, 
			int? m3POCY = null, 
			DateTime? m3PRDT = null, 
			string m3REFE = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			DateTime? m3RGDT = null, 
			int? m3RGTM = null, 
			DateTime? m3LMDT = null, 
			int? m3CHNO = null, 
			string m3CHID = null, 
			long? m3TASN = null, 
			int? m3QLTM = null, 
			int? m3STAG = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddStkIns",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSNR))
				throw new ArgumentNullException(nameof(m3MSNR));
			if (string.IsNullOrWhiteSpace(m3QLFR))
				throw new ArgumentNullException(nameof(m3QLFR));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3MSNR.Trim())
				.WithQueryParameter("MSLN", m3MSLN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QLFR", m3QLFR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3MSGS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QLFS.HasValue)
				request.WithQueryParameter("QLFS", m3QLFS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QLFT.HasValue)
				request.WithQueryParameter("QLFT", m3QLFT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLFD.HasValue)
				request.WithQueryParameter("PLFD", m3PLFD.Value.ToM3String());
			if (m3PLFT.HasValue)
				request.WithQueryParameter("PLFT", m3PLFT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3FIDT.Value.ToM3String());
			if (m3FITE.HasValue)
				request.WithQueryParameter("FITE", m3FITE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QLQT.HasValue)
				request.WithQueryParameter("QLQT", m3QLQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QLUN))
				request.WithQueryParameter("QLUN", m3QLUN.Trim());
			if (m3QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3QLDT.Value.ToM3String());
			if (m3E0D5.HasValue)
				request.WithQueryParameter("E0D5", m3E0D5.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3E0CB))
				request.WithQueryParameter("E0CB", m3E0CB.Trim());
			if (m3COCD.HasValue)
				request.WithQueryParameter("COCD", m3COCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSID))
				request.WithQueryParameter("MSID", m3MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSGF))
				request.WithQueryParameter("MSGF", m3MSGF.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSGD))
				request.WithQueryParameter("MSGD", m3MSGD.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TWLO))
				request.WithQueryParameter("TWLO", m3TWLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3NITN))
				request.WithQueryParameter("NITN", m3NITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3NBAN))
				request.WithQueryParameter("NBAN", m3NBAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOCA))
				request.WithQueryParameter("TOCA", m3TOCA.Trim());
			if (m3ALOC.HasValue)
				request.WithQueryParameter("ALOC", m3ALOC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAS))
				request.WithQueryParameter("STAS", m3STAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3REMK))
				request.WithQueryParameter("REMK", m3REMK.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRTP))
				request.WithQueryParameter("TRTP", m3TRTP.Trim());
			if (m3TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3TRQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TRUN))
				request.WithQueryParameter("TRUN", m3TRUN.Trim());
			if (m3POCY.HasValue)
				request.WithQueryParameter("POCY", m3POCY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3REFE))
				request.WithQueryParameter("REFE", m3REFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3RGTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());
			if (m3CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3CHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());
			if (m3TASN.HasValue)
				request.WithQueryParameter("TASN", m3TASN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3QLTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STAG.HasValue)
				request.WithQueryParameter("STAG", m3STAG.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddStkInsResponse>(
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
		/// Name AddSubline
		/// Description Add Subline to Internal Stock Transaction
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3MSNR">Message Number (Required)</param>
		/// <param name="m3MSLN">Message line number (Required)</param>
		/// <param name="m3MSGS">Sequence number (Required)</param>
		/// <param name="m3SUBL">Subline number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3BANT">Reference sublot ID</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSubline(
			string m3MSNR, 
			int m3MSLN, 
			int m3MSGS, 
			int m3SUBL, 
			int? m3CONO = null, 
			string m3BANT = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			decimal? m3CAWE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSubline",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSNR))
				throw new ArgumentNullException(nameof(m3MSNR));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3MSNR.Trim())
				.WithQueryParameter("MSLN", m3MSLN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("MSGS", m3MSGS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SUBL", m3SUBL.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BANT))
				request.WithQueryParameter("BANT", m3BANT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
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
		/// Name ChgStkHead
		/// Description Change Internal Stock Header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSNR">Message number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3E0IO">Message direction</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3STLO">Lowest status</param>
		/// <param name="m3STHI">Highest status</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3CHGD">Date changed</param>
		/// <param name="m3E004">Sender/receiver ID</param>
		/// <param name="m3E007">Qualifier</param>
		/// <param name="m3E014">Routing address</param>
		/// <param name="m3E026">Application reference</param>
		/// <param name="m3E035">Test indicator</param>
		/// <param name="m3E065">Message type</param>
		/// <param name="m3E052">Message version</param>
		/// <param name="m3E054">Message release</param>
		/// <param name="m3E051">Controlling organization</param>
		/// <param name="m3E057">Organization assigned code</param>
		/// <param name="m3E0PA">Partner</param>
		/// <param name="m3E0QA">Code list qualifier</param>
		/// <param name="m3E0PB">Partner ID</param>
		/// <param name="m3E0QB">Code list qualifier</param>
		/// <param name="m3DONR">Document number</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3EDFR">EDI reference</param>
		/// <param name="m3ID01">Message identity 1</param>
		/// <param name="m3ID02">Message identity 2</param>
		/// <param name="m3ID03">Message identity 3</param>
		/// <param name="m3ID04">Message identity 4</param>
		/// <param name="m3ID05">Message identity 5</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3CUDT">Customer´s purchase order date</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3DLSP">Delivery specification</param>
		/// <param name="m3RSAG">Delivery contract number</param>
		/// <param name="m3CARR">Carrier</param>
		/// <param name="m3CCAR">Customer´s carrier name</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3DTID">Data identity</param>
		/// <param name="m3LOCD">Local currency</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3ARAT">Exchange rate</param>
		/// <param name="m3RGDT">Not used!</param>
		/// <param name="m3RGTM">Not used!</param>
		/// <param name="m3LMDT">Not used!</param>
		/// <param name="m3CHNO">Not used!</param>
		/// <param name="m3CHID">Not used!</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgStkHead(
			string m3MSNR, 
			int? m3CONO = null, 
			string m3E0IO = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
			string m3CUNO = null, 
			string m3PMSN = null, 
			string m3STAT = null, 
			string m3STLO = null, 
			string m3STHI = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			DateTime? m3CHGD = null, 
			string m3E004 = null, 
			string m3E007 = null, 
			string m3E014 = null, 
			string m3E026 = null, 
			int? m3E035 = null, 
			string m3E065 = null, 
			string m3E052 = null, 
			string m3E054 = null, 
			string m3E051 = null, 
			string m3E057 = null, 
			string m3E0PA = null, 
			string m3E0QA = null, 
			string m3E0PB = null, 
			string m3E0QB = null, 
			string m3DONR = null, 
			string m3RESP = null, 
			string m3EDFR = null, 
			string m3ID01 = null, 
			string m3ID02 = null, 
			string m3ID03 = null, 
			string m3ID04 = null, 
			string m3ID05 = null, 
			string m3CUOR = null, 
			DateTime? m3CUDT = null, 
			string m3ADID = null, 
			string m3DLSP = null, 
			string m3RSAG = null, 
			string m3CARR = null, 
			string m3CCAR = null, 
			decimal? m3TXID = null, 
			decimal? m3DTID = null, 
			string m3LOCD = null, 
			string m3CUCD = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			decimal? m3ARAT = null, 
			DateTime? m3RGDT = null, 
			int? m3RGTM = null, 
			DateTime? m3LMDT = null, 
			int? m3CHNO = null, 
			string m3CHID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgStkHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSNR))
				throw new ArgumentNullException(nameof(m3MSNR));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3MSNR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3E0IO))
				request.WithQueryParameter("E0IO", m3E0IO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STLO))
				request.WithQueryParameter("STLO", m3STLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STHI))
				request.WithQueryParameter("STHI", m3STHI.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3E004))
				request.WithQueryParameter("E004", m3E004.Trim());
			if (!string.IsNullOrWhiteSpace(m3E007))
				request.WithQueryParameter("E007", m3E007.Trim());
			if (!string.IsNullOrWhiteSpace(m3E014))
				request.WithQueryParameter("E014", m3E014.Trim());
			if (!string.IsNullOrWhiteSpace(m3E026))
				request.WithQueryParameter("E026", m3E026.Trim());
			if (m3E035.HasValue)
				request.WithQueryParameter("E035", m3E035.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3E065))
				request.WithQueryParameter("E065", m3E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3E052))
				request.WithQueryParameter("E052", m3E052.Trim());
			if (!string.IsNullOrWhiteSpace(m3E054))
				request.WithQueryParameter("E054", m3E054.Trim());
			if (!string.IsNullOrWhiteSpace(m3E051))
				request.WithQueryParameter("E051", m3E051.Trim());
			if (!string.IsNullOrWhiteSpace(m3E057))
				request.WithQueryParameter("E057", m3E057.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0PA))
				request.WithQueryParameter("E0PA", m3E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0QA))
				request.WithQueryParameter("E0QA", m3E0QA.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0PB))
				request.WithQueryParameter("E0PB", m3E0PB.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0QB))
				request.WithQueryParameter("E0QB", m3E0QB.Trim());
			if (!string.IsNullOrWhiteSpace(m3DONR))
				request.WithQueryParameter("DONR", m3DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDFR))
				request.WithQueryParameter("EDFR", m3EDFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ID01))
				request.WithQueryParameter("ID01", m3ID01.Trim());
			if (!string.IsNullOrWhiteSpace(m3ID02))
				request.WithQueryParameter("ID02", m3ID02.Trim());
			if (!string.IsNullOrWhiteSpace(m3ID03))
				request.WithQueryParameter("ID03", m3ID03.Trim());
			if (!string.IsNullOrWhiteSpace(m3ID04))
				request.WithQueryParameter("ID04", m3ID04.Trim());
			if (!string.IsNullOrWhiteSpace(m3ID05))
				request.WithQueryParameter("ID05", m3ID05.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (m3CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3CUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLSP))
				request.WithQueryParameter("DLSP", m3DLSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSAG))
				request.WithQueryParameter("RSAG", m3RSAG.Trim());
			if (!string.IsNullOrWhiteSpace(m3CARR))
				request.WithQueryParameter("CARR", m3CARR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CCAR))
				request.WithQueryParameter("CCAR", m3CCAR.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTID.HasValue)
				request.WithQueryParameter("DTID", m3DTID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LOCD))
				request.WithQueryParameter("LOCD", m3LOCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3ARAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3RGTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());
			if (m3CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3CHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());

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
		/// Name ChgStkId
		/// Description Change Internal Stock Identity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSNR">Message number (Required)</param>
		/// <param name="m3MSLN">Message line number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3PMSL">External message line number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3CHGD">Date changed</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3FUDS">Description 2</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3UNIT">Unit of measure</param>
		/// <param name="m3STLO">Lowest status</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3STHI">Highest status</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3RES2">Responsible</param>
		/// <param name="m3RES3">Responsible</param>
		/// <param name="m3RES4">Responsible</param>
		/// <param name="m3EDFR">EDI reference</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3RGDT">Not used!</param>
		/// <param name="m3RGTM">Not used!</param>
		/// <param name="m3LMDT">Not used!</param>
		/// <param name="m3CHNO">Not used!</param>
		/// <param name="m3CHID">Not used!</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgStkId(
			string m3MSNR, 
			int m3MSLN, 
			int? m3CONO = null, 
			string m3PMSN = null, 
			int? m3PMSL = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			DateTime? m3CHGD = null, 
			string m3WHLO = null, 
			string m3ITNO = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			long? m3REPN = null, 
			string m3FACI = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			string m3ITDS = null, 
			string m3FUDS = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			string m3BREM = null, 
			string m3UNIT = null, 
			string m3STLO = null, 
			string m3STAT = null, 
			string m3STHI = null, 
			decimal? m3TXID = null, 
			string m3RESP = null, 
			string m3RES2 = null, 
			string m3RES3 = null, 
			string m3RES4 = null, 
			string m3EDFR = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			DateTime? m3RGDT = null, 
			int? m3RGTM = null, 
			DateTime? m3LMDT = null, 
			int? m3CHNO = null, 
			string m3CHID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgStkId",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSNR))
				throw new ArgumentNullException(nameof(m3MSNR));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3MSNR.Trim())
				.WithQueryParameter("MSLN", m3MSLN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (m3PMSL.HasValue)
				request.WithQueryParameter("PMSL", m3PMSL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3FUDS))
				request.WithQueryParameter("FUDS", m3FUDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3UNIT))
				request.WithQueryParameter("UNIT", m3UNIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STLO))
				request.WithQueryParameter("STLO", m3STLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STHI))
				request.WithQueryParameter("STHI", m3STHI.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3RES2))
				request.WithQueryParameter("RES2", m3RES2.Trim());
			if (!string.IsNullOrWhiteSpace(m3RES3))
				request.WithQueryParameter("RES3", m3RES3.Trim());
			if (!string.IsNullOrWhiteSpace(m3RES4))
				request.WithQueryParameter("RES4", m3RES4.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDFR))
				request.WithQueryParameter("EDFR", m3EDFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3RGTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());
			if (m3CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3CHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());

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
		/// Name ChgStkIns
		/// Description Change Internal Stock Instruction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSNR">Message number (Required)</param>
		/// <param name="m3MSLN">Message line number (Required)</param>
		/// <param name="m3MSGS">Sequence number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3QLFR">Qualifier</param>
		/// <param name="m3QLFS">Sequence number</param>
		/// <param name="m3QLFT">Qualifier type</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3PLFD">Planned finish date</param>
		/// <param name="m3PLFT">Time generated</param>
		/// <param name="m3FIDT">Finish date</param>
		/// <param name="m3FITE">Execution time</param>
		/// <param name="m3QLQT">Qualifier unit of measure</param>
		/// <param name="m3QLUN">Qualifier unit of measure</param>
		/// <param name="m3QLDT">Qualifier date</param>
		/// <param name="m3E0D5">Item price</param>
		/// <param name="m3E0CB">Currency</param>
		/// <param name="m3COCD">Costing price quantity</param>
		/// <param name="m3MSID">Message ID</param>
		/// <param name="m3MSGF">Message file</param>
		/// <param name="m3MSGD">Message</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3TWLO">To warehouse</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="m3NITN">New item number</param>
		/// <param name="m3NBAN">New lot number</param>
		/// <param name="m3TOCA">To container</param>
		/// <param name="m3ALOC">Allocatable</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3STAS">Status - balance ID</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3REMK">Remark</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3TRTP">Order type</param>
		/// <param name="m3TRQT">Transaction quantity - basic U/M</param>
		/// <param name="m3TRUN">Free trade association</param>
		/// <param name="m3POCY">Normal potency</param>
		/// <param name="m3PRDT">Priority date</param>
		/// <param name="m3REFE">Reference</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3RGDT">Not used!</param>
		/// <param name="m3RGTM">Not used!</param>
		/// <param name="m3LMDT">Not used!</param>
		/// <param name="m3CHNO">Not used!</param>
		/// <param name="m3CHID">Not used!</param>
		/// <param name="m3TASN">Task number</param>
		/// <param name="m3QLTM">Qualifier time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgStkIns(
			string m3MSNR, 
			int m3MSLN, 
			int m3MSGS, 
			int? m3CONO = null, 
			string m3QLFR = null, 
			int? m3QLFS = null, 
			int? m3QLFT = null, 
			string m3STAT = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			DateTime? m3PLFD = null, 
			int? m3PLFT = null, 
			DateTime? m3FIDT = null, 
			int? m3FITE = null, 
			decimal? m3QLQT = null, 
			string m3QLUN = null, 
			DateTime? m3QLDT = null, 
			decimal? m3E0D5 = null, 
			string m3E0CB = null, 
			int? m3COCD = null, 
			string m3MSID = null, 
			string m3MSGF = null, 
			string m3MSGD = null, 
			decimal? m3TXID = null, 
			string m3TWLO = null, 
			string m3TWSL = null, 
			string m3NITN = null, 
			string m3NBAN = null, 
			string m3TOCA = null, 
			int? m3ALOC = null, 
			decimal? m3CAWE = null, 
			string m3STAS = null, 
			string m3RSCD = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			string m3REMK = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3WHLO = null, 
			string m3RORN = null, 
			string m3TRTP = null, 
			decimal? m3TRQT = null, 
			string m3TRUN = null, 
			int? m3POCY = null, 
			DateTime? m3PRDT = null, 
			string m3REFE = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			DateTime? m3RGDT = null, 
			int? m3RGTM = null, 
			DateTime? m3LMDT = null, 
			int? m3CHNO = null, 
			string m3CHID = null, 
			long? m3TASN = null, 
			int? m3QLTM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgStkIns",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSNR))
				throw new ArgumentNullException(nameof(m3MSNR));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3MSNR.Trim())
				.WithQueryParameter("MSLN", m3MSLN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("MSGS", m3MSGS.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QLFR))
				request.WithQueryParameter("QLFR", m3QLFR.Trim());
			if (m3QLFS.HasValue)
				request.WithQueryParameter("QLFS", m3QLFS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QLFT.HasValue)
				request.WithQueryParameter("QLFT", m3QLFT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLFD.HasValue)
				request.WithQueryParameter("PLFD", m3PLFD.Value.ToM3String());
			if (m3PLFT.HasValue)
				request.WithQueryParameter("PLFT", m3PLFT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3FIDT.Value.ToM3String());
			if (m3FITE.HasValue)
				request.WithQueryParameter("FITE", m3FITE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QLQT.HasValue)
				request.WithQueryParameter("QLQT", m3QLQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QLUN))
				request.WithQueryParameter("QLUN", m3QLUN.Trim());
			if (m3QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3QLDT.Value.ToM3String());
			if (m3E0D5.HasValue)
				request.WithQueryParameter("E0D5", m3E0D5.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3E0CB))
				request.WithQueryParameter("E0CB", m3E0CB.Trim());
			if (m3COCD.HasValue)
				request.WithQueryParameter("COCD", m3COCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSID))
				request.WithQueryParameter("MSID", m3MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSGF))
				request.WithQueryParameter("MSGF", m3MSGF.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSGD))
				request.WithQueryParameter("MSGD", m3MSGD.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TWLO))
				request.WithQueryParameter("TWLO", m3TWLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3NITN))
				request.WithQueryParameter("NITN", m3NITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3NBAN))
				request.WithQueryParameter("NBAN", m3NBAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOCA))
				request.WithQueryParameter("TOCA", m3TOCA.Trim());
			if (m3ALOC.HasValue)
				request.WithQueryParameter("ALOC", m3ALOC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAS))
				request.WithQueryParameter("STAS", m3STAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3REMK))
				request.WithQueryParameter("REMK", m3REMK.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRTP))
				request.WithQueryParameter("TRTP", m3TRTP.Trim());
			if (m3TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3TRQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TRUN))
				request.WithQueryParameter("TRUN", m3TRUN.Trim());
			if (m3POCY.HasValue)
				request.WithQueryParameter("POCY", m3POCY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3REFE))
				request.WithQueryParameter("REFE", m3REFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3RGTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());
			if (m3CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3CHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());
			if (m3TASN.HasValue)
				request.WithQueryParameter("TASN", m3TASN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3QLTM.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgSubline
		/// Description Chg Subline Information
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3MSNR">Message Number (Required)</param>
		/// <param name="m3MSLN">Message line number (Required)</param>
		/// <param name="m3MSGS">Sequence number (Required)</param>
		/// <param name="m3SUBL">Subline number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3BANT">Reference sublot ID</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgSubline(
			string m3MSNR, 
			int m3MSLN, 
			int m3MSGS, 
			int m3SUBL, 
			int? m3CONO = null, 
			string m3BANT = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			decimal? m3CAWE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgSubline",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSNR))
				throw new ArgumentNullException(nameof(m3MSNR));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3MSNR.Trim())
				.WithQueryParameter("MSLN", m3MSLN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("MSGS", m3MSGS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SUBL", m3SUBL.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BANT))
				request.WithQueryParameter("BANT", m3BANT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
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
		/// Name DeleteStkTran
		/// Description Delete Internal Stock Transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSNR">Message number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3MSGS">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteStkTran(
			string m3MSNR, 
			int? m3CONO = null, 
			int? m3MSLN = null, 
			int? m3MSGS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeleteStkTran",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSNR))
				throw new ArgumentNullException(nameof(m3MSNR));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3MSNR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3MSGS.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DeleteSubline
		/// Description Delete  Subline Information
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3MSNR">Message Number (Required)</param>
		/// <param name="m3MSLN">Message line number (Required)</param>
		/// <param name="m3MSGS">Sequence number (Required)</param>
		/// <param name="m3SUBL">Subline number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteSubline(
			string m3MSNR, 
			int m3MSLN, 
			int m3MSGS, 
			int m3SUBL, 
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeleteSubline",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSNR))
				throw new ArgumentNullException(nameof(m3MSNR));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3MSNR.Trim())
				.WithQueryParameter("MSLN", m3MSLN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("MSGS", m3MSGS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SUBL", m3SUBL.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetMvxMsg
		/// Description Get Movex Message ID
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PB">Partner (Required)</param>
		/// <param name="m3PMSN">External message number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMvxMsgResponse></returns>
		/// <exception cref="M3Exception<GetMvxMsgResponse>"></exception>
		public async Task<M3Response<GetMvxMsgResponse>> GetMvxMsg(
			string m3E0PB, 
			string m3PMSN, 
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMvxMsg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PB))
				throw new ArgumentNullException(nameof(m3E0PB));
			if (string.IsNullOrWhiteSpace(m3PMSN))
				throw new ArgumentNullException(nameof(m3PMSN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PB", m3E0PB.Trim())
				.WithQueryParameter("PMSN", m3PMSN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetMvxMsgResponse>(
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
		/// Name GetStkHead
		/// Description Get Internal Stock Header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSNR">Message number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetStkHeadResponse></returns>
		/// <exception cref="M3Exception<GetStkHeadResponse>"></exception>
		public async Task<M3Response<GetStkHeadResponse>> GetStkHead(
			string m3MSNR, 
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetStkHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSNR))
				throw new ArgumentNullException(nameof(m3MSNR));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3MSNR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetStkHeadResponse>(
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
		/// Name GetStkId
		/// Description Get Internal Stock Identity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSNR">Message number (Required)</param>
		/// <param name="m3MSLN">Message line number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetStkIdResponse></returns>
		/// <exception cref="M3Exception<GetStkIdResponse>"></exception>
		public async Task<M3Response<GetStkIdResponse>> GetStkId(
			string m3MSNR, 
			int m3MSLN, 
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetStkId",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSNR))
				throw new ArgumentNullException(nameof(m3MSNR));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3MSNR.Trim())
				.WithQueryParameter("MSLN", m3MSLN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetStkIdResponse>(
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
		/// Name GetStkIns
		/// Description Get Internal Stock Instruction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSNR">Message number (Required)</param>
		/// <param name="m3MSLN">Message line number (Required)</param>
		/// <param name="m3MSGS">Sequence number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetStkInsResponse></returns>
		/// <exception cref="M3Exception<GetStkInsResponse>"></exception>
		public async Task<M3Response<GetStkInsResponse>> GetStkIns(
			string m3MSNR, 
			int m3MSLN, 
			int m3MSGS, 
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetStkIns",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSNR))
				throw new ArgumentNullException(nameof(m3MSNR));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3MSNR.Trim())
				.WithQueryParameter("MSLN", m3MSLN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("MSGS", m3MSGS.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetStkInsResponse>(
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
		/// Name LstMvxMsg
		/// Description List Movex Message ID
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PB">Partner (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMvxMsgResponse></returns>
		/// <exception cref="M3Exception<LstMvxMsgResponse>"></exception>
		public async Task<M3Response<LstMvxMsgResponse>> LstMvxMsg(
			string m3E0PB, 
			int? m3CONO = null, 
			string m3PMSN = null, 
			string m3STAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMvxMsg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PB))
				throw new ArgumentNullException(nameof(m3E0PB));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PB", m3E0PB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());

			// Execute the request
			var result = await Execute<LstMvxMsgResponse>(
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
		/// Name LstSubline
		/// Description List SubLines
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3MSNR">Message Number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3MSGS">Sequence number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSublineResponse></returns>
		/// <exception cref="M3Exception<LstSublineResponse>"></exception>
		public async Task<M3Response<LstSublineResponse>> LstSubline(
			string m3MSNR, 
			int? m3CONO = null, 
			int? m3MSLN = null, 
			int? m3MSGS = null, 
			string m3ITNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSubline",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSNR))
				throw new ArgumentNullException(nameof(m3MSNR));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3MSNR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3MSGS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());

			// Execute the request
			var result = await Execute<LstSublineResponse>(
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
		/// Name PrcStkTran
		/// Description Process Internal Stock Transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSNR">Message number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3MSGS">Sequence number</param>
		/// <param name="m3PRFL">Process flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrcStkTran(
			string m3MSNR, 
			int? m3CONO = null, 
			int? m3MSLN = null, 
			int? m3MSGS = null, 
			string m3PRFL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrcStkTran",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSNR))
				throw new ArgumentNullException(nameof(m3MSNR));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3MSNR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3MSGS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());

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
		/// Name SndAdjust
		/// Description Add Stock Adjustment Transaction (update with +/- qty)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3PRFL">Process flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSNR">Message number</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3MSGS">Sequence number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3QLQT">Quantity</param>
		/// <param name="m3QLUN">Qualifier unit of measure</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3USD1">User defined 1</param>
		/// <param name="m3USD2">User defined 2</param>
		/// <param name="m3USD3">User defined 3</param>
		/// <param name="m3USD4">User defined 4</param>
		/// <param name="m3USD5">User defined 5</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3QLDT">Qualifier date</param>
		/// <param name="m3QLTM">Qualifier time</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3STAG">Status - physical inv</param>
		/// <param name="m3PRDT">Priority date</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndAdjust(
			string m3E0PA, 
			string m3E065, 
			string m3WHLO, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSNR = null, 
			int? m3MSLN = null, 
			int? m3MSGS = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3WHSL = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			long? m3REPN = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			decimal? m3QLQT = null, 
			string m3QLUN = null, 
			string m3BREM = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			string m3RSCD = null, 
			DateTime? m3QLDT = null, 
			int? m3QLTM = null, 
			decimal? m3CAWE = null, 
			string m3PMSN = null, 
			int? m3STAG = null, 
			DateTime? m3PRDT = null, 
			string m3RESP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndAdjust",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSNR))
				request.WithQueryParameter("MSNR", m3MSNR.Trim());
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3MSGS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QLQT.HasValue)
				request.WithQueryParameter("QLQT", m3QLQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QLUN))
				request.WithQueryParameter("QLUN", m3QLUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (m3QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3QLDT.Value.ToM3String());
			if (m3QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3QLTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (m3STAG.HasValue)
				request.WithQueryParameter("STAG", m3STAG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());

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
		/// Name SndPartialCount
		/// Description Send Partial counts for physical inventory
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3STNB">Physical inventory number (Required)</param>
		/// <param name="m3PRFL">Process flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSNR">Message Number</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3MSGS">Sequence number</param>
		/// <param name="m3STRN">Physical inventory line</param>
		/// <param name="m3STQI">Physical inventory quantity</param>
		/// <param name="m3QLDT">Qualifier date</param>
		/// <param name="m3QLTM">Qualifier time</param>
		/// <param name="m3QLUN">Qualifier unit of measure</param>
		/// <param name="m3SAQI">Physical inventory quantity - Main U/M</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias category</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3STAG">Status - physical inventory</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3RENU">Recount number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndPartialCount(
			string m3E0PA, 
			string m3E065, 
			string m3WHLO, 
			long m3STNB, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			string m3MSNR = null, 
			int? m3MSLN = null, 
			int? m3MSGS = null, 
			int? m3STRN = null, 
			decimal? m3STQI = null, 
			DateTime? m3QLDT = null, 
			int? m3QLTM = null, 
			string m3QLUN = null, 
			decimal? m3SAQI = null, 
			string m3ITNO = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			long? m3REPN = null, 
			string m3BREM = null, 
			string m3RESP = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			decimal? m3CAWE = null, 
			int? m3STAG = null, 
			string m3PMSN = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			int? m3RENU = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndPartialCount",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("STNB", m3STNB.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSNR))
				request.WithQueryParameter("MSNR", m3MSNR.Trim());
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3MSGS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STRN.HasValue)
				request.WithQueryParameter("STRN", m3STRN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STQI.HasValue)
				request.WithQueryParameter("STQI", m3STQI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3QLDT.Value.ToM3String());
			if (m3QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3QLTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QLUN))
				request.WithQueryParameter("QLUN", m3QLUN.Trim());
			if (m3SAQI.HasValue)
				request.WithQueryParameter("SAQI", m3SAQI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STAG.HasValue)
				request.WithQueryParameter("STAG", m3STAG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
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
		/// Name SndStkId
		/// Description Send Internal Stock Identity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSNR">Message number (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3WHSL">Location (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3PMSN">External message number</param>
		/// <param name="m3PMSL">External message line number</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3CHGD">Date changed</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias type</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3FUDS">Description 2</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3UNIT">Unit of measure</param>
		/// <param name="m3STLO">Lowest status</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3STHI">Highest status</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3RES2">Responsible</param>
		/// <param name="m3RES3">Responsible</param>
		/// <param name="m3RES4">Responsible</param>
		/// <param name="m3EDFR">EDI reference</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3RGDT">Not used!</param>
		/// <param name="m3RGTM">Not used!</param>
		/// <param name="m3LMDT">Not used!</param>
		/// <param name="m3CHNO">Not used!</param>
		/// <param name="m3CHID">Not used!</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndStkId(
			string m3MSNR, 
			string m3WHLO, 
			string m3WHSL, 
			int? m3CONO = null, 
			int? m3MSLN = null, 
			string m3PMSN = null, 
			int? m3PMSL = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			DateTime? m3CHGD = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			long? m3REPN = null, 
			string m3FACI = null, 
			string m3POPN = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			string m3ITDS = null, 
			string m3FUDS = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			string m3BREM = null, 
			string m3UNIT = null, 
			string m3STLO = null, 
			string m3STAT = null, 
			string m3STHI = null, 
			decimal? m3TXID = null, 
			string m3RESP = null, 
			string m3RES2 = null, 
			string m3RES3 = null, 
			string m3RES4 = null, 
			string m3EDFR = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			DateTime? m3RGDT = null, 
			int? m3RGTM = null, 
			DateTime? m3LMDT = null, 
			int? m3CHNO = null, 
			string m3CHID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndStkId",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSNR))
				throw new ArgumentNullException(nameof(m3MSNR));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3WHSL))
				throw new ArgumentNullException(nameof(m3WHSL));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3MSNR.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("WHSL", m3WHSL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PMSN))
				request.WithQueryParameter("PMSN", m3PMSN.Trim());
			if (m3PMSL.HasValue)
				request.WithQueryParameter("PMSL", m3PMSL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3FUDS))
				request.WithQueryParameter("FUDS", m3FUDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3UNIT))
				request.WithQueryParameter("UNIT", m3UNIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STLO))
				request.WithQueryParameter("STLO", m3STLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STHI))
				request.WithQueryParameter("STHI", m3STHI.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3RES2))
				request.WithQueryParameter("RES2", m3RES2.Trim());
			if (!string.IsNullOrWhiteSpace(m3RES3))
				request.WithQueryParameter("RES3", m3RES3.Trim());
			if (!string.IsNullOrWhiteSpace(m3RES4))
				request.WithQueryParameter("RES4", m3RES4.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDFR))
				request.WithQueryParameter("EDFR", m3EDFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3RGTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());
			if (m3CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3CHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());

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
		/// Name SndStkIns
		/// Description Send Internal Stock Instruction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSNR">Message number (Required)</param>
		/// <param name="m3MSLN">Message line number (Required)</param>
		/// <param name="m3QLFR">Qualifier (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSGS">Sequence number</param>
		/// <param name="m3QLFS">Sequence number</param>
		/// <param name="m3QLFT">Qualifier type</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3PLFD">Planned finish date</param>
		/// <param name="m3PLFT">Time generated</param>
		/// <param name="m3FIDT">Finish date</param>
		/// <param name="m3FITE">Execution time</param>
		/// <param name="m3QLQT">Quantity</param>
		/// <param name="m3QLUN">Qualifier unit of measure</param>
		/// <param name="m3QLDT">Qualifier date</param>
		/// <param name="m3E0D5">Item price</param>
		/// <param name="m3E0CB">Currency</param>
		/// <param name="m3COCD">Costing price quantity</param>
		/// <param name="m3MSID">Message ID</param>
		/// <param name="m3MSGF">Message file</param>
		/// <param name="m3MSGD">Message</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3TWLO">To warehouse</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="m3NITN">New item number</param>
		/// <param name="m3NBAN">New lot number</param>
		/// <param name="m3TOCA">To container</param>
		/// <param name="m3ALOC">Allocatable</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3STAS">Status - balance ID</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3REMK">Remark</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3TRTP">Order type</param>
		/// <param name="m3TRQT">Transaction quantity - basic U/M</param>
		/// <param name="m3TRUN">Free trade association</param>
		/// <param name="m3POCY">Normal potency</param>
		/// <param name="m3PRDT">Priority date</param>
		/// <param name="m3REFE">Reference</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3RGDT">Not used!</param>
		/// <param name="m3RGTM">Not used!</param>
		/// <param name="m3LMDT">Not used!</param>
		/// <param name="m3CHNO">Not used!</param>
		/// <param name="m3CHID">Not used!</param>
		/// <param name="m3TASN">Task number</param>
		/// <param name="m3QLTM">Qualifier time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndStkIns(
			string m3MSNR, 
			int m3MSLN, 
			string m3QLFR, 
			int? m3CONO = null, 
			int? m3MSGS = null, 
			int? m3QLFS = null, 
			int? m3QLFT = null, 
			string m3STAT = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			DateTime? m3PLFD = null, 
			int? m3PLFT = null, 
			DateTime? m3FIDT = null, 
			int? m3FITE = null, 
			decimal? m3QLQT = null, 
			string m3QLUN = null, 
			DateTime? m3QLDT = null, 
			decimal? m3E0D5 = null, 
			string m3E0CB = null, 
			int? m3COCD = null, 
			string m3MSID = null, 
			string m3MSGF = null, 
			string m3MSGD = null, 
			decimal? m3TXID = null, 
			string m3TWLO = null, 
			string m3TWSL = null, 
			string m3NITN = null, 
			string m3NBAN = null, 
			string m3TOCA = null, 
			int? m3ALOC = null, 
			decimal? m3CAWE = null, 
			string m3STAS = null, 
			string m3RSCD = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			string m3REMK = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3WHLO = null, 
			string m3RORN = null, 
			string m3TRTP = null, 
			decimal? m3TRQT = null, 
			string m3TRUN = null, 
			int? m3POCY = null, 
			DateTime? m3PRDT = null, 
			string m3REFE = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			DateTime? m3RGDT = null, 
			int? m3RGTM = null, 
			DateTime? m3LMDT = null, 
			int? m3CHNO = null, 
			string m3CHID = null, 
			long? m3TASN = null, 
			int? m3QLTM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndStkIns",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSNR))
				throw new ArgumentNullException(nameof(m3MSNR));
			if (string.IsNullOrWhiteSpace(m3QLFR))
				throw new ArgumentNullException(nameof(m3QLFR));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3MSNR.Trim())
				.WithQueryParameter("MSLN", m3MSLN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QLFR", m3QLFR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3MSGS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QLFS.HasValue)
				request.WithQueryParameter("QLFS", m3QLFS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QLFT.HasValue)
				request.WithQueryParameter("QLFT", m3QLFT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLFD.HasValue)
				request.WithQueryParameter("PLFD", m3PLFD.Value.ToM3String());
			if (m3PLFT.HasValue)
				request.WithQueryParameter("PLFT", m3PLFT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3FIDT.Value.ToM3String());
			if (m3FITE.HasValue)
				request.WithQueryParameter("FITE", m3FITE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QLQT.HasValue)
				request.WithQueryParameter("QLQT", m3QLQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QLUN))
				request.WithQueryParameter("QLUN", m3QLUN.Trim());
			if (m3QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3QLDT.Value.ToM3String());
			if (m3E0D5.HasValue)
				request.WithQueryParameter("E0D5", m3E0D5.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3E0CB))
				request.WithQueryParameter("E0CB", m3E0CB.Trim());
			if (m3COCD.HasValue)
				request.WithQueryParameter("COCD", m3COCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSID))
				request.WithQueryParameter("MSID", m3MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSGF))
				request.WithQueryParameter("MSGF", m3MSGF.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSGD))
				request.WithQueryParameter("MSGD", m3MSGD.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TWLO))
				request.WithQueryParameter("TWLO", m3TWLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3NITN))
				request.WithQueryParameter("NITN", m3NITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3NBAN))
				request.WithQueryParameter("NBAN", m3NBAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOCA))
				request.WithQueryParameter("TOCA", m3TOCA.Trim());
			if (m3ALOC.HasValue)
				request.WithQueryParameter("ALOC", m3ALOC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAS))
				request.WithQueryParameter("STAS", m3STAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3REMK))
				request.WithQueryParameter("REMK", m3REMK.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRTP))
				request.WithQueryParameter("TRTP", m3TRTP.Trim());
			if (m3TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3TRQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TRUN))
				request.WithQueryParameter("TRUN", m3TRUN.Trim());
			if (m3POCY.HasValue)
				request.WithQueryParameter("POCY", m3POCY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3REFE))
				request.WithQueryParameter("REFE", m3REFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3RGTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());
			if (m3CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3CHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());
			if (m3TASN.HasValue)
				request.WithQueryParameter("TASN", m3TASN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3QLTM.Value.ToString(CultureInfo.CurrentCulture));

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
