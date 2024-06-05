/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_PRFL">Process flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSNR">Message number</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_MSGS">Sequence number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_QLQT">Quantity</param>
		/// <param name="m3_QLUN">Qualifier unit of measure</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_USD1">User defined 1</param>
		/// <param name="m3_USD2">User defined 2</param>
		/// <param name="m3_USD3">User defined 3</param>
		/// <param name="m3_USD4">User defined 4</param>
		/// <param name="m3_USD5">User defined 5</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_QLDT">Qualifier date</param>
		/// <param name="m3_QLTM">Qualifier time</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_STAG">Status - physical inv</param>
		/// <param name="m3_PRDT">Priority date</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddAdjustResponse></returns>
		/// <exception cref="M3Exception<AddAdjustResponse>"></exception>
		public async Task<M3Response<AddAdjustResponse>> AddAdjust(
			string m3_E0PA, 
			string m3_E065, 
			string m3_WHLO, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSNR = null, 
			int? m3_MSLN = null, 
			int? m3_MSGS = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_WHSL = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			long? m3_REPN = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			decimal? m3_QLQT = null, 
			string m3_QLUN = null, 
			string m3_BREM = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			string m3_RSCD = null, 
			DateTime? m3_QLDT = null, 
			int? m3_QLTM = null, 
			decimal? m3_CAWE = null, 
			string m3_PMSN = null, 
			int? m3_STAG = null, 
			DateTime? m3_PRDT = null, 
			string m3_RESP = null, 
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
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSNR))
				request.WithQueryParameter("MSNR", m3_MSNR.Trim());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (m3_MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3_MSGS.Value.ToString());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (m3_QLQT.HasValue)
				request.WithQueryParameter("QLQT", m3_QLQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QLUN))
				request.WithQueryParameter("QLUN", m3_QLUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (m3_QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3_QLDT.Value.ToM3String());
			if (m3_QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3_QLTM.Value.ToString());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (m3_STAG.HasValue)
				request.WithQueryParameter("STAG", m3_STAG.Value.ToString());
			if (m3_PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3_PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());

			// Execute the request
			var result = await Execute<AddAdjustResponse>(
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
		/// Name AddLocClean
		/// Description Add location clean transaction
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_WHSL">Location (Required)</param>
		/// <param name="m3_QLDT">Qualifier date (Required)</param>
		/// <param name="m3_QLTM">Qualifier time (Required)</param>
		/// <param name="m3_PRFL">Process flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSNR">Message number</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_MSGS">Sequence number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_USD1">User defined 1</param>
		/// <param name="m3_USD2">User defined 2</param>
		/// <param name="m3_USD3">User defined 3</param>
		/// <param name="m3_USD4">User defined 4</param>
		/// <param name="m3_USD5">User defined 5</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddLocCleanResponse></returns>
		/// <exception cref="M3Exception<AddLocCleanResponse>"></exception>
		public async Task<M3Response<AddLocCleanResponse>> AddLocClean(
			string m3_E0PA, 
			string m3_E065, 
			string m3_WHLO, 
			string m3_WHSL, 
			DateTime m3_QLDT, 
			int m3_QLTM, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSNR = null, 
			int? m3_MSLN = null, 
			int? m3_MSGS = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_ITNO = null, 
			long? m3_REPN = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			string m3_BREM = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			string m3_RSCD = null, 
			string m3_PMSN = null, 
			string m3_RESP = null, 
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
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_WHSL))
				throw new ArgumentNullException("m3_WHSL");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("WHSL", m3_WHSL.Trim())
				.WithQueryParameter("QLDT", m3_QLDT.ToM3String())
				.WithQueryParameter("QLTM", m3_QLTM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSNR))
				request.WithQueryParameter("MSNR", m3_MSNR.Trim());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (m3_MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3_MSGS.Value.ToString());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());

			// Execute the request
			var result = await Execute<AddLocCleanResponse>(
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
		/// Name AddLotBlend
		/// Description Add Lot Blend Transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_PRFL">Process flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSNR">Message number</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_MSGS">Sequence number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_QLQT">Quantity</param>
		/// <param name="m3_QLUN">Qualifier unit of measure</param>
		/// <param name="m3_QLDT">Qualifier date</param>
		/// <param name="m3_TWSL">To Location</param>
		/// <param name="m3_TOCA">To Container</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_USD1">User defined 1</param>
		/// <param name="m3_USD2">User defined 2</param>
		/// <param name="m3_USD3">User defined 3</param>
		/// <param name="m3_USD4">User defined 4</param>
		/// <param name="m3_USD5">User defined 5</param>
		/// <param name="m3_TASN">Task number</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_QLTM">Qualifier time</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddLotBlendResponse></returns>
		/// <exception cref="M3Exception<AddLotBlendResponse>"></exception>
		public async Task<M3Response<AddLotBlendResponse>> AddLotBlend(
			string m3_E0PA, 
			string m3_E065, 
			string m3_WHLO, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSNR = null, 
			int? m3_MSLN = null, 
			int? m3_MSGS = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_WHSL = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			long? m3_REPN = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			decimal? m3_QLQT = null, 
			string m3_QLUN = null, 
			DateTime? m3_QLDT = null, 
			string m3_TWSL = null, 
			string m3_TOCA = null, 
			decimal? m3_CAWE = null, 
			string m3_BREM = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			long? m3_TASN = null, 
			string m3_PMSN = null, 
			int? m3_QLTM = null, 
			string m3_RESP = null, 
			string m3_RSCD = null, 
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
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSNR))
				request.WithQueryParameter("MSNR", m3_MSNR.Trim());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (m3_MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3_MSGS.Value.ToString());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (m3_QLQT.HasValue)
				request.WithQueryParameter("QLQT", m3_QLQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QLUN))
				request.WithQueryParameter("QLUN", m3_QLUN.Trim());
			if (m3_QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3_QLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOCA))
				request.WithQueryParameter("TOCA", m3_TOCA.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_TASN.HasValue)
				request.WithQueryParameter("TASN", m3_TASN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (m3_QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3_QLTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());

			// Execute the request
			var result = await Execute<AddLotBlendResponse>(
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
		/// Name AddMOOrdLess
		/// Description Orderless manufacturing
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_STRT">Product stucture type (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSNR">Message number</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_MSGS">Sequence number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_POCY">Normal potency</param>
		/// <param name="m3_MAUN">Manufacturing U/M</param>
		/// <param name="m3_STAS">Status - balance ID</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddMOOrdLessResponse></returns>
		/// <exception cref="M3Exception<AddMOOrdLessResponse>"></exception>
		public async Task<M3Response<AddMOOrdLessResponse>> AddMOOrdLess(
			string m3_E0PA, 
			string m3_E065, 
			string m3_WHLO, 
			string m3_PRNO, 
			string m3_STRT, 
			string m3_PRMD = null, 
			int? m3_CONO = null, 
			string m3_MSNR = null, 
			int? m3_MSLN = null, 
			int? m3_MSGS = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			decimal? m3_ORQT = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			decimal? m3_CAWE = null, 
			int? m3_POCY = null, 
			string m3_MAUN = null, 
			string m3_STAS = null, 
			DateTime? m3_TRDT = null, 
			string m3_RESP = null, 
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
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_STRT))
				throw new ArgumentNullException("m3_STRT");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("STRT", m3_STRT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSNR))
				request.WithQueryParameter("MSNR", m3_MSNR.Trim());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (m3_MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3_MSGS.Value.ToString());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (m3_ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3_ORQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (m3_POCY.HasValue)
				request.WithQueryParameter("POCY", m3_POCY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MAUN))
				request.WithQueryParameter("MAUN", m3_MAUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAS))
				request.WithQueryParameter("STAS", m3_STAS.Trim());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());

			// Execute the request
			var result = await Execute<AddMOOrdLessResponse>(
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
		/// Name AddMove
		/// Description Add Stock Movement Transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_PRFL">Process flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSNR">Message number</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_MSGS">Sequence number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_QLQT">Quantity</param>
		/// <param name="m3_QLUN">Qualifier unit of measure</param>
		/// <param name="m3_QLDT">Qualifier date</param>
		/// <param name="m3_TWSL">To Location</param>
		/// <param name="m3_TOCA">To Container</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_USD1">User defined 1</param>
		/// <param name="m3_USD2">User defined 2</param>
		/// <param name="m3_USD3">User defined 3</param>
		/// <param name="m3_USD4">User defined 4</param>
		/// <param name="m3_USD5">User defined 5</param>
		/// <param name="m3_TASN">Task number</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_QLTM">Qualifier time</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddMoveResponse></returns>
		/// <exception cref="M3Exception<AddMoveResponse>"></exception>
		public async Task<M3Response<AddMoveResponse>> AddMove(
			string m3_E0PA, 
			string m3_E065, 
			string m3_WHLO, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSNR = null, 
			int? m3_MSLN = null, 
			int? m3_MSGS = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_WHSL = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			long? m3_REPN = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			decimal? m3_QLQT = null, 
			string m3_QLUN = null, 
			DateTime? m3_QLDT = null, 
			string m3_TWSL = null, 
			string m3_TOCA = null, 
			decimal? m3_CAWE = null, 
			string m3_BREM = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			long? m3_TASN = null, 
			string m3_PMSN = null, 
			int? m3_QLTM = null, 
			string m3_RESP = null, 
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
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSNR))
				request.WithQueryParameter("MSNR", m3_MSNR.Trim());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (m3_MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3_MSGS.Value.ToString());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (m3_QLQT.HasValue)
				request.WithQueryParameter("QLQT", m3_QLQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QLUN))
				request.WithQueryParameter("QLUN", m3_QLUN.Trim());
			if (m3_QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3_QLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOCA))
				request.WithQueryParameter("TOCA", m3_TOCA.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_TASN.HasValue)
				request.WithQueryParameter("TASN", m3_TASN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (m3_QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3_QLTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());

			// Execute the request
			var result = await Execute<AddMoveResponse>(
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
		/// Name AddMoveAll
		/// Description Add Stock Movement Transaction
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_PRFL">Process flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSNR">Message number</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_MSGS">Sequence number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_QLUN">Qualifier unit of measure</param>
		/// <param name="m3_QLDT">Qualifier date</param>
		/// <param name="m3_TWSL">To Location</param>
		/// <param name="m3_TOCA">To Container</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_USD1">User defined 1</param>
		/// <param name="m3_USD2">User defined 2</param>
		/// <param name="m3_USD3">User defined 3</param>
		/// <param name="m3_USD4">User defined 4</param>
		/// <param name="m3_USD5">User defined 5</param>
		/// <param name="m3_TASN">Task number</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_QLTM">Qualifier time</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddMoveAllResponse></returns>
		/// <exception cref="M3Exception<AddMoveAllResponse>"></exception>
		public async Task<M3Response<AddMoveAllResponse>> AddMoveAll(
			string m3_E0PA, 
			string m3_E065, 
			string m3_WHLO, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSNR = null, 
			int? m3_MSLN = null, 
			int? m3_MSGS = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_WHSL = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			long? m3_REPN = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			string m3_QLUN = null, 
			DateTime? m3_QLDT = null, 
			string m3_TWSL = null, 
			string m3_TOCA = null, 
			decimal? m3_CAWE = null, 
			string m3_BREM = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			long? m3_TASN = null, 
			string m3_PMSN = null, 
			int? m3_QLTM = null, 
			string m3_RESP = null, 
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
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSNR))
				request.WithQueryParameter("MSNR", m3_MSNR.Trim());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (m3_MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3_MSGS.Value.ToString());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QLUN))
				request.WithQueryParameter("QLUN", m3_QLUN.Trim());
			if (m3_QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3_QLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOCA))
				request.WithQueryParameter("TOCA", m3_TOCA.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_TASN.HasValue)
				request.WithQueryParameter("TASN", m3_TASN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (m3_QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3_QLTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());

			// Execute the request
			var result = await Execute<AddMoveAllResponse>(
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
		/// Name AddPackMove
		/// Description Add Package movement transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_PANR">Package number (Required)</param>
		/// <param name="m3_PRFL">Process flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSNR">Message Number</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_MSGS">Sequence number</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="m3_TOCA">To container</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_QLDT">Qualifier date</param>
		/// <param name="m3_QLTM">Qualifier time</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPackMoveResponse></returns>
		/// <exception cref="M3Exception<AddPackMoveResponse>"></exception>
		public async Task<M3Response<AddPackMoveResponse>> AddPackMove(
			string m3_E0PA, 
			string m3_E065, 
			string m3_WHLO, 
			string m3_PANR, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSNR = null, 
			int? m3_MSLN = null, 
			int? m3_MSGS = null, 
			string m3_TWSL = null, 
			string m3_TOCA = null, 
			string m3_PMSN = null, 
			DateTime? m3_QLDT = null, 
			int? m3_QLTM = null, 
			string m3_RESP = null, 
			string m3_SSCC = null, 
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
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_PANR))
				throw new ArgumentNullException("m3_PANR");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("PANR", m3_PANR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSNR))
				request.WithQueryParameter("MSNR", m3_MSNR.Trim());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (m3_MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3_MSGS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOCA))
				request.WithQueryParameter("TOCA", m3_TOCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (m3_QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3_QLDT.Value.ToM3String());
			if (m3_QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3_QLTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());

			// Execute the request
			var result = await Execute<AddPackMoveResponse>(
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
		/// Name AddPartialCount
		/// Description Partial counts for physical inventory
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_STNB">Physical inventory number (Required)</param>
		/// <param name="m3_PRFL">Process flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSNR">Message Number</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_MSGS">Sequence number</param>
		/// <param name="m3_STRN">Physical inventory line</param>
		/// <param name="m3_STQI">Physical inventory quantity</param>
		/// <param name="m3_QLDT">Qualifier date</param>
		/// <param name="m3_QLTM">Qualifier time</param>
		/// <param name="m3_QLUN">Qualifier unit of measure</param>
		/// <param name="m3_SAQI">Physical inventory quantity - Main U/M</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias category</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_STAG">Status - physical inventory</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_RENU">Recount number</param>
		/// <param name="m3_STBT">On-hand balance to compare</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPartialCountResponse></returns>
		/// <exception cref="M3Exception<AddPartialCountResponse>"></exception>
		public async Task<M3Response<AddPartialCountResponse>> AddPartialCount(
			string m3_E0PA, 
			string m3_E065, 
			string m3_WHLO, 
			long m3_STNB, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSNR = null, 
			int? m3_MSLN = null, 
			int? m3_MSGS = null, 
			int? m3_STRN = null, 
			decimal? m3_STQI = null, 
			DateTime? m3_QLDT = null, 
			int? m3_QLTM = null, 
			string m3_QLUN = null, 
			decimal? m3_SAQI = null, 
			string m3_ITNO = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			long? m3_REPN = null, 
			string m3_BREM = null, 
			string m3_RESP = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			decimal? m3_CAWE = null, 
			int? m3_STAG = null, 
			string m3_PMSN = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			int? m3_RENU = null, 
			int? m3_STBT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("STNB", m3_STNB.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSNR))
				request.WithQueryParameter("MSNR", m3_MSNR.Trim());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (m3_MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3_MSGS.Value.ToString());
			if (m3_STRN.HasValue)
				request.WithQueryParameter("STRN", m3_STRN.Value.ToString());
			if (m3_STQI.HasValue)
				request.WithQueryParameter("STQI", m3_STQI.Value.ToString());
			if (m3_QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3_QLDT.Value.ToM3String());
			if (m3_QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3_QLTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QLUN))
				request.WithQueryParameter("QLUN", m3_QLUN.Trim());
			if (m3_SAQI.HasValue)
				request.WithQueryParameter("SAQI", m3_SAQI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (m3_STAG.HasValue)
				request.WithQueryParameter("STAG", m3_STAG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_RENU.HasValue)
				request.WithQueryParameter("RENU", m3_RENU.Value.ToString());
			if (m3_STBT.HasValue)
				request.WithQueryParameter("STBT", m3_STBT.Value.ToString());

			// Execute the request
			var result = await Execute<AddPartialCountResponse>(
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
		/// Name AddPrtFrstCount
		/// Description Partial counts for physical inventory first count
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_STNB">Physical inventory number (Required)</param>
		/// <param name="m3_PRFL">Process flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSNR">Message Number</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_MSGS">Sequence number</param>
		/// <param name="m3_STRN">Physical inventory line</param>
		/// <param name="m3_STQI">Physical inventory quantity</param>
		/// <param name="m3_QLDT">Qualifier date</param>
		/// <param name="m3_QLTM">Qualifier time</param>
		/// <param name="m3_QLUN">Qualifier unit of measure</param>
		/// <param name="m3_SAQI">Physical inventory quantity - Main U/M</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias category</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_STAG">Status - physical inventory</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPrtFrstCountResponse></returns>
		/// <exception cref="M3Exception<AddPrtFrstCountResponse>"></exception>
		public async Task<M3Response<AddPrtFrstCountResponse>> AddPrtFrstCount(
			string m3_E0PA, 
			string m3_E065, 
			string m3_WHLO, 
			long m3_STNB, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSNR = null, 
			int? m3_MSLN = null, 
			int? m3_MSGS = null, 
			int? m3_STRN = null, 
			decimal? m3_STQI = null, 
			DateTime? m3_QLDT = null, 
			int? m3_QLTM = null, 
			string m3_QLUN = null, 
			decimal? m3_SAQI = null, 
			string m3_ITNO = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			long? m3_REPN = null, 
			string m3_BREM = null, 
			string m3_RESP = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			decimal? m3_CAWE = null, 
			int? m3_STAG = null, 
			string m3_PMSN = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("STNB", m3_STNB.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSNR))
				request.WithQueryParameter("MSNR", m3_MSNR.Trim());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (m3_MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3_MSGS.Value.ToString());
			if (m3_STRN.HasValue)
				request.WithQueryParameter("STRN", m3_STRN.Value.ToString());
			if (m3_STQI.HasValue)
				request.WithQueryParameter("STQI", m3_STQI.Value.ToString());
			if (m3_QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3_QLDT.Value.ToM3String());
			if (m3_QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3_QLTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QLUN))
				request.WithQueryParameter("QLUN", m3_QLUN.Trim());
			if (m3_SAQI.HasValue)
				request.WithQueryParameter("SAQI", m3_SAQI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (m3_STAG.HasValue)
				request.WithQueryParameter("STAG", m3_STAG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());

			// Execute the request
			var result = await Execute<AddPrtFrstCountResponse>(
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
		/// Name AddPrtFrstRecnt
		/// Description Partial counts for physical inventory first recount
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_STNB">Physical inventory number (Required)</param>
		/// <param name="m3_PRFL">Process flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSNR">Message Number</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_MSGS">Sequence number</param>
		/// <param name="m3_STRN">Physical inventory line</param>
		/// <param name="m3_STQI">Physical inventory quantity</param>
		/// <param name="m3_QLDT">Qualifier date</param>
		/// <param name="m3_QLTM">Qualifier time</param>
		/// <param name="m3_QLUN">Qualifier unit of measure</param>
		/// <param name="m3_SAQI">Physical inventory quantity - Main U/M</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias category</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_STAG">Status - physical inventory</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPrtFrstRecntResponse></returns>
		/// <exception cref="M3Exception<AddPrtFrstRecntResponse>"></exception>
		public async Task<M3Response<AddPrtFrstRecntResponse>> AddPrtFrstRecnt(
			string m3_E0PA, 
			string m3_E065, 
			string m3_WHLO, 
			long m3_STNB, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSNR = null, 
			int? m3_MSLN = null, 
			int? m3_MSGS = null, 
			int? m3_STRN = null, 
			decimal? m3_STQI = null, 
			DateTime? m3_QLDT = null, 
			int? m3_QLTM = null, 
			string m3_QLUN = null, 
			decimal? m3_SAQI = null, 
			string m3_ITNO = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			long? m3_REPN = null, 
			string m3_BREM = null, 
			string m3_RESP = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			decimal? m3_CAWE = null, 
			int? m3_STAG = null, 
			string m3_PMSN = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("STNB", m3_STNB.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSNR))
				request.WithQueryParameter("MSNR", m3_MSNR.Trim());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (m3_MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3_MSGS.Value.ToString());
			if (m3_STRN.HasValue)
				request.WithQueryParameter("STRN", m3_STRN.Value.ToString());
			if (m3_STQI.HasValue)
				request.WithQueryParameter("STQI", m3_STQI.Value.ToString());
			if (m3_QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3_QLDT.Value.ToM3String());
			if (m3_QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3_QLTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QLUN))
				request.WithQueryParameter("QLUN", m3_QLUN.Trim());
			if (m3_SAQI.HasValue)
				request.WithQueryParameter("SAQI", m3_SAQI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (m3_STAG.HasValue)
				request.WithQueryParameter("STAG", m3_STAG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());

			// Execute the request
			var result = await Execute<AddPrtFrstRecntResponse>(
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
		/// Name AddPrtScndRecnt
		/// Description Partial counts for physical inventory second count
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_STNB">Physical inventory number (Required)</param>
		/// <param name="m3_PRFL">Process flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSNR">Message Number</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_MSGS">Sequence number</param>
		/// <param name="m3_STRN">Physical inventory line</param>
		/// <param name="m3_STQI">Physical inventory quantity</param>
		/// <param name="m3_QLDT">Qualifier date</param>
		/// <param name="m3_QLTM">Qualifier time</param>
		/// <param name="m3_QLUN">Qualifier unit of measure</param>
		/// <param name="m3_SAQI">Physical inventory quantity - Main U/M</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias category</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_STAG">Status - physical inventory</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPrtScndRecntResponse></returns>
		/// <exception cref="M3Exception<AddPrtScndRecntResponse>"></exception>
		public async Task<M3Response<AddPrtScndRecntResponse>> AddPrtScndRecnt(
			string m3_E0PA, 
			string m3_E065, 
			string m3_WHLO, 
			long m3_STNB, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSNR = null, 
			int? m3_MSLN = null, 
			int? m3_MSGS = null, 
			int? m3_STRN = null, 
			decimal? m3_STQI = null, 
			DateTime? m3_QLDT = null, 
			int? m3_QLTM = null, 
			string m3_QLUN = null, 
			decimal? m3_SAQI = null, 
			string m3_ITNO = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			long? m3_REPN = null, 
			string m3_BREM = null, 
			string m3_RESP = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			decimal? m3_CAWE = null, 
			int? m3_STAG = null, 
			string m3_PMSN = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("STNB", m3_STNB.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSNR))
				request.WithQueryParameter("MSNR", m3_MSNR.Trim());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (m3_MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3_MSGS.Value.ToString());
			if (m3_STRN.HasValue)
				request.WithQueryParameter("STRN", m3_STRN.Value.ToString());
			if (m3_STQI.HasValue)
				request.WithQueryParameter("STQI", m3_STQI.Value.ToString());
			if (m3_QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3_QLDT.Value.ToM3String());
			if (m3_QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3_QLTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QLUN))
				request.WithQueryParameter("QLUN", m3_QLUN.Trim());
			if (m3_SAQI.HasValue)
				request.WithQueryParameter("SAQI", m3_SAQI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (m3_STAG.HasValue)
				request.WithQueryParameter("STAG", m3_STAG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());

			// Execute the request
			var result = await Execute<AddPrtScndRecntResponse>(
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
		/// Name AddQty
		/// Description Add Stock Quantity Transaction (set to quantity)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_PRFL">Process flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSNR">Message number</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_MSGS">Sequence number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_QLQT">Quantity</param>
		/// <param name="m3_QLUN">Qualifier unit of measure</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_USD1">User defined 1</param>
		/// <param name="m3_USD2">User defined 2</param>
		/// <param name="m3_USD3">User defined 3</param>
		/// <param name="m3_USD4">User defined 4</param>
		/// <param name="m3_USD5">User defined 5</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_QLDT">Qualifier date</param>
		/// <param name="m3_QLTM">Qualifier time</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_STAG">Status - physical inventory</param>
		/// <param name="m3_PRDT">Priority date</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddQtyResponse></returns>
		/// <exception cref="M3Exception<AddQtyResponse>"></exception>
		public async Task<M3Response<AddQtyResponse>> AddQty(
			string m3_E0PA, 
			string m3_E065, 
			string m3_WHLO, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSNR = null, 
			int? m3_MSLN = null, 
			int? m3_MSGS = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_WHSL = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			long? m3_REPN = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			decimal? m3_QLQT = null, 
			string m3_QLUN = null, 
			string m3_BREM = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			string m3_RSCD = null, 
			DateTime? m3_QLDT = null, 
			int? m3_QLTM = null, 
			decimal? m3_CAWE = null, 
			string m3_PMSN = null, 
			int? m3_STAG = null, 
			DateTime? m3_PRDT = null, 
			string m3_RESP = null, 
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
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSNR))
				request.WithQueryParameter("MSNR", m3_MSNR.Trim());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (m3_MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3_MSGS.Value.ToString());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (m3_QLQT.HasValue)
				request.WithQueryParameter("QLQT", m3_QLQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QLUN))
				request.WithQueryParameter("QLUN", m3_QLUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (m3_QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3_QLDT.Value.ToM3String());
			if (m3_QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3_QLTM.Value.ToString());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (m3_STAG.HasValue)
				request.WithQueryParameter("STAG", m3_STAG.Value.ToString());
			if (m3_PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3_PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());

			// Execute the request
			var result = await Execute<AddQtyResponse>(
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
		/// Name AddRclLotSts
		/// Description Add Reclassification Of Lot Status
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_ALOC">Allocatable (Required)</param>
		/// <param name="m3_PRFL">Process flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSNR">Message number</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_MSGS">Sequence number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_QLQT">Quantity</param>
		/// <param name="m3_QLUN">Qualifier unit of measure</param>
		/// <param name="m3_QLDT">Transaction date</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_STAS">Status - balance ID</param>
		/// <param name="m3_USD1">User defined 1</param>
		/// <param name="m3_USD2">User defined 2</param>
		/// <param name="m3_USD3">User defined 3</param>
		/// <param name="m3_USD4">User defined 4</param>
		/// <param name="m3_USD5">User defined 5</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_EXPI">Expiration date</param>
		/// <param name="m3_LPCY">Potency</param>
		/// <param name="m3_CNDT">Follow-up date</param>
		/// <param name="m3_SEDT">Sales date</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddRclLotStsResponse></returns>
		/// <exception cref="M3Exception<AddRclLotStsResponse>"></exception>
		public async Task<M3Response<AddRclLotStsResponse>> AddRclLotSts(
			string m3_E0PA, 
			string m3_E065, 
			string m3_WHLO, 
			int m3_ALOC, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSNR = null, 
			int? m3_MSLN = null, 
			int? m3_MSGS = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			string m3_BREM = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			decimal? m3_QLQT = null, 
			string m3_QLUN = null, 
			DateTime? m3_QLDT = null, 
			decimal? m3_CAWE = null, 
			string m3_RSCD = null, 
			string m3_STAS = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			string m3_PMSN = null, 
			DateTime? m3_EXPI = null, 
			int? m3_LPCY = null, 
			DateTime? m3_CNDT = null, 
			DateTime? m3_SEDT = null, 
			string m3_RESP = null, 
			string m3_WHSL = null, 
			string m3_CAMU = null, 
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
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("ALOC", m3_ALOC.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSNR))
				request.WithQueryParameter("MSNR", m3_MSNR.Trim());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (m3_MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3_MSGS.Value.ToString());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (m3_QLQT.HasValue)
				request.WithQueryParameter("QLQT", m3_QLQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QLUN))
				request.WithQueryParameter("QLUN", m3_QLUN.Trim());
			if (m3_QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3_QLDT.Value.ToM3String());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAS))
				request.WithQueryParameter("STAS", m3_STAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (m3_EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3_EXPI.Value.ToM3String());
			if (m3_LPCY.HasValue)
				request.WithQueryParameter("LPCY", m3_LPCY.Value.ToString());
			if (m3_CNDT.HasValue)
				request.WithQueryParameter("CNDT", m3_CNDT.Value.ToM3String());
			if (m3_SEDT.HasValue)
				request.WithQueryParameter("SEDT", m3_SEDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());

			// Execute the request
			var result = await Execute<AddRclLotStsResponse>(
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
		/// Name AddReclass
		/// Description Add Stock Reclassification Transaction
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_PRFL">Process flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSNR">Message number</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_MSGS">Sequence number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_QLQT">Quantity</param>
		/// <param name="m3_QLUN">Qualifier unit of measure</param>
		/// <param name="m3_QLDT">Transaction date</param>
		/// <param name="m3_NITN">New item number</param>
		/// <param name="m3_NBAN">New lot number</param>
		/// <param name="m3_ALOC">Allocatable</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_STAS">Status - balance ID</param>
		/// <param name="m3_USD1">User defined 1</param>
		/// <param name="m3_USD2">User defined 2</param>
		/// <param name="m3_USD3">User defined 3</param>
		/// <param name="m3_USD4">User defined 4</param>
		/// <param name="m3_USD5">User defined 5</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_CALT">Calculation method</param>
		/// <param name="m3_QRBS">QI request basis</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddReclassResponse></returns>
		/// <exception cref="M3Exception<AddReclassResponse>"></exception>
		public async Task<M3Response<AddReclassResponse>> AddReclass(
			string m3_E0PA, 
			string m3_E065, 
			string m3_WHLO, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSNR = null, 
			int? m3_MSLN = null, 
			int? m3_MSGS = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_WHSL = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			long? m3_REPN = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			string m3_BREM = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			decimal? m3_QLQT = null, 
			string m3_QLUN = null, 
			DateTime? m3_QLDT = null, 
			string m3_NITN = null, 
			string m3_NBAN = null, 
			int? m3_ALOC = null, 
			decimal? m3_CAWE = null, 
			string m3_RSCD = null, 
			string m3_STAS = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			string m3_PMSN = null, 
			string m3_RESP = null, 
			int? m3_CALT = null, 
			int? m3_QRBS = null, 
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
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSNR))
				request.WithQueryParameter("MSNR", m3_MSNR.Trim());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (m3_MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3_MSGS.Value.ToString());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (m3_QLQT.HasValue)
				request.WithQueryParameter("QLQT", m3_QLQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QLUN))
				request.WithQueryParameter("QLUN", m3_QLUN.Trim());
			if (m3_QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3_QLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_NITN))
				request.WithQueryParameter("NITN", m3_NITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NBAN))
				request.WithQueryParameter("NBAN", m3_NBAN.Trim());
			if (m3_ALOC.HasValue)
				request.WithQueryParameter("ALOC", m3_ALOC.Value.ToString());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAS))
				request.WithQueryParameter("STAS", m3_STAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_CALT.HasValue)
				request.WithQueryParameter("CALT", m3_CALT.Value.ToString());
			if (m3_QRBS.HasValue)
				request.WithQueryParameter("QRBS", m3_QRBS.Value.ToString());

			// Execute the request
			var result = await Execute<AddReclassResponse>(
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
		/// Name AddStkHead
		/// Description Add Internal Stock Header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E0PB">Partner ID (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSNR">Message number</param>
		/// <param name="m3_E0IO">Message direction</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_STLO">Lowest status</param>
		/// <param name="m3_STHI">Highest status</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_CHGD">Date changed</param>
		/// <param name="m3_E004">Sender/receiver ID</param>
		/// <param name="m3_E007">Qualifier</param>
		/// <param name="m3_E014">Routing address</param>
		/// <param name="m3_E026">Application reference</param>
		/// <param name="m3_E035">Test indicator</param>
		/// <param name="m3_E052">Message version</param>
		/// <param name="m3_E054">Message release</param>
		/// <param name="m3_E051">Controlling organization</param>
		/// <param name="m3_E057">Organization assigned code</param>
		/// <param name="m3_E0QA">Code list qualifier</param>
		/// <param name="m3_E0QB">Code list qualifier</param>
		/// <param name="m3_DONR">Document number</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_EDFR">EDI reference</param>
		/// <param name="m3_ID01">Message identity 1</param>
		/// <param name="m3_ID02">Message identity 2</param>
		/// <param name="m3_ID03">Message identity 3</param>
		/// <param name="m3_ID04">Message identity 4</param>
		/// <param name="m3_ID05">Message identity 5</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_CUDT">Customer´s purchase order date</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_DLSP">Delivery specification</param>
		/// <param name="m3_RSAG">Delivery contract number</param>
		/// <param name="m3_CARR">Carrier</param>
		/// <param name="m3_CCAR">Customer´s carrier name</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_DTID">Data identity</param>
		/// <param name="m3_LOCD">Local currency</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_ARAT">Exchange rate</param>
		/// <param name="m3_RGDT">Not used!</param>
		/// <param name="m3_RGTM">Not used!</param>
		/// <param name="m3_LMDT">Not used!</param>
		/// <param name="m3_CHNO">Not used!</param>
		/// <param name="m3_CHID">Not used!</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddStkHeadResponse></returns>
		/// <exception cref="M3Exception<AddStkHeadResponse>"></exception>
		public async Task<M3Response<AddStkHeadResponse>> AddStkHead(
			string m3_WHLO, 
			string m3_E065, 
			string m3_E0PA, 
			string m3_E0PB, 
			int? m3_CONO = null, 
			string m3_MSNR = null, 
			string m3_E0IO = null, 
			string m3_FACI = null, 
			string m3_CUNO = null, 
			string m3_PMSN = null, 
			string m3_STAT = null, 
			string m3_STLO = null, 
			string m3_STHI = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			DateTime? m3_CHGD = null, 
			string m3_E004 = null, 
			string m3_E007 = null, 
			string m3_E014 = null, 
			string m3_E026 = null, 
			int? m3_E035 = null, 
			string m3_E052 = null, 
			string m3_E054 = null, 
			string m3_E051 = null, 
			string m3_E057 = null, 
			string m3_E0QA = null, 
			string m3_E0QB = null, 
			string m3_DONR = null, 
			string m3_RESP = null, 
			string m3_EDFR = null, 
			string m3_ID01 = null, 
			string m3_ID02 = null, 
			string m3_ID03 = null, 
			string m3_ID04 = null, 
			string m3_ID05 = null, 
			string m3_CUOR = null, 
			DateTime? m3_CUDT = null, 
			string m3_ADID = null, 
			string m3_DLSP = null, 
			string m3_RSAG = null, 
			string m3_CARR = null, 
			string m3_CCAR = null, 
			decimal? m3_TXID = null, 
			decimal? m3_DTID = null, 
			string m3_LOCD = null, 
			string m3_CUCD = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_ARAT = null, 
			DateTime? m3_RGDT = null, 
			int? m3_RGTM = null, 
			DateTime? m3_LMDT = null, 
			int? m3_CHNO = null, 
			string m3_CHID = null, 
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
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E0PB))
				throw new ArgumentNullException("m3_E0PB");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E0PB", m3_E0PB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSNR))
				request.WithQueryParameter("MSNR", m3_MSNR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0IO))
				request.WithQueryParameter("E0IO", m3_E0IO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STLO))
				request.WithQueryParameter("STLO", m3_STLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STHI))
				request.WithQueryParameter("STHI", m3_STHI.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (m3_CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3_CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_E004))
				request.WithQueryParameter("E004", m3_E004.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E007))
				request.WithQueryParameter("E007", m3_E007.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E014))
				request.WithQueryParameter("E014", m3_E014.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E026))
				request.WithQueryParameter("E026", m3_E026.Trim());
			if (m3_E035.HasValue)
				request.WithQueryParameter("E035", m3_E035.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_E052))
				request.WithQueryParameter("E052", m3_E052.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E054))
				request.WithQueryParameter("E054", m3_E054.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E051))
				request.WithQueryParameter("E051", m3_E051.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E057))
				request.WithQueryParameter("E057", m3_E057.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0QA))
				request.WithQueryParameter("E0QA", m3_E0QA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0QB))
				request.WithQueryParameter("E0QB", m3_E0QB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DONR))
				request.WithQueryParameter("DONR", m3_DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDFR))
				request.WithQueryParameter("EDFR", m3_EDFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ID01))
				request.WithQueryParameter("ID01", m3_ID01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ID02))
				request.WithQueryParameter("ID02", m3_ID02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ID03))
				request.WithQueryParameter("ID03", m3_ID03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ID04))
				request.WithQueryParameter("ID04", m3_ID04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ID05))
				request.WithQueryParameter("ID05", m3_ID05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (m3_CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3_CUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLSP))
				request.WithQueryParameter("DLSP", m3_DLSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSAG))
				request.WithQueryParameter("RSAG", m3_RSAG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CARR))
				request.WithQueryParameter("CARR", m3_CARR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CCAR))
				request.WithQueryParameter("CCAR", m3_CCAR.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_DTID.HasValue)
				request.WithQueryParameter("DTID", m3_DTID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LOCD))
				request.WithQueryParameter("LOCD", m3_LOCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3_ARAT.Value.ToString());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3_RGTM.Value.ToString());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());
			if (m3_CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3_CHNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());

			// Execute the request
			var result = await Execute<AddStkHeadResponse>(
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
		/// Name AddStkId
		/// Description Add Internal Stock Identity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSNR">Message number (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_WHSL">Location (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_PMSL">External message line number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_CHGD">Date changed</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_FUDS">Description 2</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_UNIT">Unit of measure</param>
		/// <param name="m3_STLO">Lowest status</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_STHI">Highest status</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_RES2">Responsible</param>
		/// <param name="m3_RES3">Responsible</param>
		/// <param name="m3_RES4">Responsible</param>
		/// <param name="m3_EDFR">EDI reference</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_RGDT">Not used!</param>
		/// <param name="m3_RGTM">Not used!</param>
		/// <param name="m3_LMDT">Not used!</param>
		/// <param name="m3_CHNO">Not used!</param>
		/// <param name="m3_CHID">Not used!</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddStkIdResponse></returns>
		/// <exception cref="M3Exception<AddStkIdResponse>"></exception>
		public async Task<M3Response<AddStkIdResponse>> AddStkId(
			string m3_MSNR, 
			string m3_WHLO, 
			string m3_WHSL, 
			int? m3_CONO = null, 
			int? m3_MSLN = null, 
			string m3_PMSN = null, 
			int? m3_PMSL = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			DateTime? m3_CHGD = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			long? m3_REPN = null, 
			string m3_FACI = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			string m3_ITDS = null, 
			string m3_FUDS = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			string m3_BREM = null, 
			string m3_UNIT = null, 
			string m3_STLO = null, 
			string m3_STAT = null, 
			string m3_STHI = null, 
			decimal? m3_TXID = null, 
			string m3_RESP = null, 
			string m3_RES2 = null, 
			string m3_RES3 = null, 
			string m3_RES4 = null, 
			string m3_EDFR = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			DateTime? m3_RGDT = null, 
			int? m3_RGTM = null, 
			DateTime? m3_LMDT = null, 
			int? m3_CHNO = null, 
			string m3_CHID = null, 
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
			if (string.IsNullOrWhiteSpace(m3_MSNR))
				throw new ArgumentNullException("m3_MSNR");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_WHSL))
				throw new ArgumentNullException("m3_WHSL");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3_MSNR.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("WHSL", m3_WHSL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (m3_PMSL.HasValue)
				request.WithQueryParameter("PMSL", m3_PMSL.Value.ToString());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (m3_CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3_CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FUDS))
				request.WithQueryParameter("FUDS", m3_FUDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UNIT))
				request.WithQueryParameter("UNIT", m3_UNIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STLO))
				request.WithQueryParameter("STLO", m3_STLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STHI))
				request.WithQueryParameter("STHI", m3_STHI.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RES2))
				request.WithQueryParameter("RES2", m3_RES2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RES3))
				request.WithQueryParameter("RES3", m3_RES3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RES4))
				request.WithQueryParameter("RES4", m3_RES4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDFR))
				request.WithQueryParameter("EDFR", m3_EDFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3_RGTM.Value.ToString());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());
			if (m3_CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3_CHNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());

			// Execute the request
			var result = await Execute<AddStkIdResponse>(
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
		/// Name AddStkIns
		/// Description Add Internal Stock Instruction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSNR">Message number (Required)</param>
		/// <param name="m3_MSLN">Message line number (Required)</param>
		/// <param name="m3_QLFR">Qualifier (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSGS">Sequence number</param>
		/// <param name="m3_QLFS">Sequence number</param>
		/// <param name="m3_QLFT">Qualifier type</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_PLFD">Planned finish date</param>
		/// <param name="m3_PLFT">Time generated</param>
		/// <param name="m3_FIDT">Finish date</param>
		/// <param name="m3_FITE">Execution time</param>
		/// <param name="m3_QLQT">Quantity</param>
		/// <param name="m3_QLUN">Qualifier unit of measure</param>
		/// <param name="m3_QLDT">Qualifier date</param>
		/// <param name="m3_E0D5">Item price</param>
		/// <param name="m3_E0CB">Currency</param>
		/// <param name="m3_COCD">Costing price quantity</param>
		/// <param name="m3_MSID">Message ID</param>
		/// <param name="m3_MSGF">Message file</param>
		/// <param name="m3_MSGD">Message</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_TWLO">To warehouse</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="m3_NITN">New item number</param>
		/// <param name="m3_NBAN">New lot number</param>
		/// <param name="m3_TOCA">To container</param>
		/// <param name="m3_ALOC">Allocatable</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_STAS">Status - balance ID</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_REMK">Remark</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_TRTP">Order type</param>
		/// <param name="m3_TRQT">Transaction quantity - basic U/M</param>
		/// <param name="m3_TRUN">Free trade association</param>
		/// <param name="m3_POCY">Normal potency</param>
		/// <param name="m3_PRDT">Priority date</param>
		/// <param name="m3_REFE">Reference</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_RGDT">Not used!</param>
		/// <param name="m3_RGTM">Not used!</param>
		/// <param name="m3_LMDT">Not used!</param>
		/// <param name="m3_CHNO">Not used!</param>
		/// <param name="m3_CHID">Not used!</param>
		/// <param name="m3_TASN">Task number</param>
		/// <param name="m3_QLTM">Qualifier time</param>
		/// <param name="m3_STAG">Status physical inv.</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddStkInsResponse></returns>
		/// <exception cref="M3Exception<AddStkInsResponse>"></exception>
		public async Task<M3Response<AddStkInsResponse>> AddStkIns(
			string m3_MSNR, 
			int m3_MSLN, 
			string m3_QLFR, 
			int? m3_CONO = null, 
			int? m3_MSGS = null, 
			int? m3_QLFS = null, 
			int? m3_QLFT = null, 
			string m3_STAT = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			DateTime? m3_PLFD = null, 
			int? m3_PLFT = null, 
			DateTime? m3_FIDT = null, 
			int? m3_FITE = null, 
			decimal? m3_QLQT = null, 
			string m3_QLUN = null, 
			DateTime? m3_QLDT = null, 
			decimal? m3_E0D5 = null, 
			string m3_E0CB = null, 
			int? m3_COCD = null, 
			string m3_MSID = null, 
			string m3_MSGF = null, 
			string m3_MSGD = null, 
			decimal? m3_TXID = null, 
			string m3_TWLO = null, 
			string m3_TWSL = null, 
			string m3_NITN = null, 
			string m3_NBAN = null, 
			string m3_TOCA = null, 
			int? m3_ALOC = null, 
			decimal? m3_CAWE = null, 
			string m3_STAS = null, 
			string m3_RSCD = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			string m3_REMK = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_WHLO = null, 
			string m3_RORN = null, 
			string m3_TRTP = null, 
			decimal? m3_TRQT = null, 
			string m3_TRUN = null, 
			int? m3_POCY = null, 
			DateTime? m3_PRDT = null, 
			string m3_REFE = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			DateTime? m3_RGDT = null, 
			int? m3_RGTM = null, 
			DateTime? m3_LMDT = null, 
			int? m3_CHNO = null, 
			string m3_CHID = null, 
			long? m3_TASN = null, 
			int? m3_QLTM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddStkIns",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSNR))
				throw new ArgumentNullException("m3_MSNR");
			if (string.IsNullOrWhiteSpace(m3_QLFR))
				throw new ArgumentNullException("m3_QLFR");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3_MSNR.Trim())
				.WithQueryParameter("MSLN", m3_MSLN.ToString())
				.WithQueryParameter("QLFR", m3_QLFR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3_MSGS.Value.ToString());
			if (m3_QLFS.HasValue)
				request.WithQueryParameter("QLFS", m3_QLFS.Value.ToString());
			if (m3_QLFT.HasValue)
				request.WithQueryParameter("QLFT", m3_QLFT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (m3_PLFD.HasValue)
				request.WithQueryParameter("PLFD", m3_PLFD.Value.ToM3String());
			if (m3_PLFT.HasValue)
				request.WithQueryParameter("PLFT", m3_PLFT.Value.ToString());
			if (m3_FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3_FIDT.Value.ToM3String());
			if (m3_FITE.HasValue)
				request.WithQueryParameter("FITE", m3_FITE.Value.ToString());
			if (m3_QLQT.HasValue)
				request.WithQueryParameter("QLQT", m3_QLQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QLUN))
				request.WithQueryParameter("QLUN", m3_QLUN.Trim());
			if (m3_QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3_QLDT.Value.ToM3String());
			if (m3_E0D5.HasValue)
				request.WithQueryParameter("E0D5", m3_E0D5.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_E0CB))
				request.WithQueryParameter("E0CB", m3_E0CB.Trim());
			if (m3_COCD.HasValue)
				request.WithQueryParameter("COCD", m3_COCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSID))
				request.WithQueryParameter("MSID", m3_MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSGF))
				request.WithQueryParameter("MSGF", m3_MSGF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSGD))
				request.WithQueryParameter("MSGD", m3_MSGD.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TWLO))
				request.WithQueryParameter("TWLO", m3_TWLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NITN))
				request.WithQueryParameter("NITN", m3_NITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NBAN))
				request.WithQueryParameter("NBAN", m3_NBAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOCA))
				request.WithQueryParameter("TOCA", m3_TOCA.Trim());
			if (m3_ALOC.HasValue)
				request.WithQueryParameter("ALOC", m3_ALOC.Value.ToString());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAS))
				request.WithQueryParameter("STAS", m3_STAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REMK))
				request.WithQueryParameter("REMK", m3_REMK.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRTP))
				request.WithQueryParameter("TRTP", m3_TRTP.Trim());
			if (m3_TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3_TRQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TRUN))
				request.WithQueryParameter("TRUN", m3_TRUN.Trim());
			if (m3_POCY.HasValue)
				request.WithQueryParameter("POCY", m3_POCY.Value.ToString());
			if (m3_PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3_PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_REFE))
				request.WithQueryParameter("REFE", m3_REFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3_RGTM.Value.ToString());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());
			if (m3_CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3_CHNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());
			if (m3_TASN.HasValue)
				request.WithQueryParameter("TASN", m3_TASN.Value.ToString());
			if (m3_QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3_QLTM.Value.ToString());
			if (m3_STAG.HasValue)
				request.WithQueryParameter("STAG", m3_STAG.Value.ToString());

			// Execute the request
			var result = await Execute<AddStkInsResponse>(
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
		/// Name AddSubline
		/// Description Add Subline to Internal Stock Transaction
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_MSNR">Message Number (Required)</param>
		/// <param name="m3_MSLN">Message line number (Required)</param>
		/// <param name="m3_MSGS">Sequence number (Required)</param>
		/// <param name="m3_SUBL">Subline number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_BANT">Reference sublot ID</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSubline(
			string m3_MSNR, 
			int m3_MSLN, 
			int m3_MSGS, 
			int m3_SUBL, 
			int? m3_CONO = null, 
			string m3_BANT = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSubline",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSNR))
				throw new ArgumentNullException("m3_MSNR");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3_MSNR.Trim())
				.WithQueryParameter("MSLN", m3_MSLN.ToString())
				.WithQueryParameter("MSGS", m3_MSGS.ToString())
				.WithQueryParameter("SUBL", m3_SUBL.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANT))
				request.WithQueryParameter("BANT", m3_BANT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
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
		/// Name ChgStkHead
		/// Description Change Internal Stock Header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSNR">Message number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_E0IO">Message direction</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_STLO">Lowest status</param>
		/// <param name="m3_STHI">Highest status</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_CHGD">Date changed</param>
		/// <param name="m3_E004">Sender/receiver ID</param>
		/// <param name="m3_E007">Qualifier</param>
		/// <param name="m3_E014">Routing address</param>
		/// <param name="m3_E026">Application reference</param>
		/// <param name="m3_E035">Test indicator</param>
		/// <param name="m3_E065">Message type</param>
		/// <param name="m3_E052">Message version</param>
		/// <param name="m3_E054">Message release</param>
		/// <param name="m3_E051">Controlling organization</param>
		/// <param name="m3_E057">Organization assigned code</param>
		/// <param name="m3_E0PA">Partner</param>
		/// <param name="m3_E0QA">Code list qualifier</param>
		/// <param name="m3_E0PB">Partner ID</param>
		/// <param name="m3_E0QB">Code list qualifier</param>
		/// <param name="m3_DONR">Document number</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_EDFR">EDI reference</param>
		/// <param name="m3_ID01">Message identity 1</param>
		/// <param name="m3_ID02">Message identity 2</param>
		/// <param name="m3_ID03">Message identity 3</param>
		/// <param name="m3_ID04">Message identity 4</param>
		/// <param name="m3_ID05">Message identity 5</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_CUDT">Customer´s purchase order date</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_DLSP">Delivery specification</param>
		/// <param name="m3_RSAG">Delivery contract number</param>
		/// <param name="m3_CARR">Carrier</param>
		/// <param name="m3_CCAR">Customer´s carrier name</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_DTID">Data identity</param>
		/// <param name="m3_LOCD">Local currency</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_ARAT">Exchange rate</param>
		/// <param name="m3_RGDT">Not used!</param>
		/// <param name="m3_RGTM">Not used!</param>
		/// <param name="m3_LMDT">Not used!</param>
		/// <param name="m3_CHNO">Not used!</param>
		/// <param name="m3_CHID">Not used!</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgStkHead(
			string m3_MSNR, 
			int? m3_CONO = null, 
			string m3_E0IO = null, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			string m3_CUNO = null, 
			string m3_PMSN = null, 
			string m3_STAT = null, 
			string m3_STLO = null, 
			string m3_STHI = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			DateTime? m3_CHGD = null, 
			string m3_E004 = null, 
			string m3_E007 = null, 
			string m3_E014 = null, 
			string m3_E026 = null, 
			int? m3_E035 = null, 
			string m3_E065 = null, 
			string m3_E052 = null, 
			string m3_E054 = null, 
			string m3_E051 = null, 
			string m3_E057 = null, 
			string m3_E0PA = null, 
			string m3_E0QA = null, 
			string m3_E0PB = null, 
			string m3_E0QB = null, 
			string m3_DONR = null, 
			string m3_RESP = null, 
			string m3_EDFR = null, 
			string m3_ID01 = null, 
			string m3_ID02 = null, 
			string m3_ID03 = null, 
			string m3_ID04 = null, 
			string m3_ID05 = null, 
			string m3_CUOR = null, 
			DateTime? m3_CUDT = null, 
			string m3_ADID = null, 
			string m3_DLSP = null, 
			string m3_RSAG = null, 
			string m3_CARR = null, 
			string m3_CCAR = null, 
			decimal? m3_TXID = null, 
			decimal? m3_DTID = null, 
			string m3_LOCD = null, 
			string m3_CUCD = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_ARAT = null, 
			DateTime? m3_RGDT = null, 
			int? m3_RGTM = null, 
			DateTime? m3_LMDT = null, 
			int? m3_CHNO = null, 
			string m3_CHID = null, 
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
			if (string.IsNullOrWhiteSpace(m3_MSNR))
				throw new ArgumentNullException("m3_MSNR");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3_MSNR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_E0IO))
				request.WithQueryParameter("E0IO", m3_E0IO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STLO))
				request.WithQueryParameter("STLO", m3_STLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STHI))
				request.WithQueryParameter("STHI", m3_STHI.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (m3_CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3_CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_E004))
				request.WithQueryParameter("E004", m3_E004.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E007))
				request.WithQueryParameter("E007", m3_E007.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E014))
				request.WithQueryParameter("E014", m3_E014.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E026))
				request.WithQueryParameter("E026", m3_E026.Trim());
			if (m3_E035.HasValue)
				request.WithQueryParameter("E035", m3_E035.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_E065))
				request.WithQueryParameter("E065", m3_E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E052))
				request.WithQueryParameter("E052", m3_E052.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E054))
				request.WithQueryParameter("E054", m3_E054.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E051))
				request.WithQueryParameter("E051", m3_E051.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E057))
				request.WithQueryParameter("E057", m3_E057.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0PA))
				request.WithQueryParameter("E0PA", m3_E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0QA))
				request.WithQueryParameter("E0QA", m3_E0QA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0PB))
				request.WithQueryParameter("E0PB", m3_E0PB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0QB))
				request.WithQueryParameter("E0QB", m3_E0QB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DONR))
				request.WithQueryParameter("DONR", m3_DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDFR))
				request.WithQueryParameter("EDFR", m3_EDFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ID01))
				request.WithQueryParameter("ID01", m3_ID01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ID02))
				request.WithQueryParameter("ID02", m3_ID02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ID03))
				request.WithQueryParameter("ID03", m3_ID03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ID04))
				request.WithQueryParameter("ID04", m3_ID04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ID05))
				request.WithQueryParameter("ID05", m3_ID05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (m3_CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3_CUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLSP))
				request.WithQueryParameter("DLSP", m3_DLSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSAG))
				request.WithQueryParameter("RSAG", m3_RSAG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CARR))
				request.WithQueryParameter("CARR", m3_CARR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CCAR))
				request.WithQueryParameter("CCAR", m3_CCAR.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_DTID.HasValue)
				request.WithQueryParameter("DTID", m3_DTID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LOCD))
				request.WithQueryParameter("LOCD", m3_LOCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3_ARAT.Value.ToString());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3_RGTM.Value.ToString());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());
			if (m3_CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3_CHNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());

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
		/// Name ChgStkId
		/// Description Change Internal Stock Identity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSNR">Message number (Required)</param>
		/// <param name="m3_MSLN">Message line number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_PMSL">External message line number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_CHGD">Date changed</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_FUDS">Description 2</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_UNIT">Unit of measure</param>
		/// <param name="m3_STLO">Lowest status</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_STHI">Highest status</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_RES2">Responsible</param>
		/// <param name="m3_RES3">Responsible</param>
		/// <param name="m3_RES4">Responsible</param>
		/// <param name="m3_EDFR">EDI reference</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_RGDT">Not used!</param>
		/// <param name="m3_RGTM">Not used!</param>
		/// <param name="m3_LMDT">Not used!</param>
		/// <param name="m3_CHNO">Not used!</param>
		/// <param name="m3_CHID">Not used!</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgStkId(
			string m3_MSNR, 
			int m3_MSLN, 
			int? m3_CONO = null, 
			string m3_PMSN = null, 
			int? m3_PMSL = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			DateTime? m3_CHGD = null, 
			string m3_WHLO = null, 
			string m3_ITNO = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			long? m3_REPN = null, 
			string m3_FACI = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			string m3_ITDS = null, 
			string m3_FUDS = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			string m3_BREM = null, 
			string m3_UNIT = null, 
			string m3_STLO = null, 
			string m3_STAT = null, 
			string m3_STHI = null, 
			decimal? m3_TXID = null, 
			string m3_RESP = null, 
			string m3_RES2 = null, 
			string m3_RES3 = null, 
			string m3_RES4 = null, 
			string m3_EDFR = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			DateTime? m3_RGDT = null, 
			int? m3_RGTM = null, 
			DateTime? m3_LMDT = null, 
			int? m3_CHNO = null, 
			string m3_CHID = null, 
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
			if (string.IsNullOrWhiteSpace(m3_MSNR))
				throw new ArgumentNullException("m3_MSNR");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3_MSNR.Trim())
				.WithQueryParameter("MSLN", m3_MSLN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (m3_PMSL.HasValue)
				request.WithQueryParameter("PMSL", m3_PMSL.Value.ToString());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (m3_CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3_CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FUDS))
				request.WithQueryParameter("FUDS", m3_FUDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UNIT))
				request.WithQueryParameter("UNIT", m3_UNIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STLO))
				request.WithQueryParameter("STLO", m3_STLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STHI))
				request.WithQueryParameter("STHI", m3_STHI.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RES2))
				request.WithQueryParameter("RES2", m3_RES2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RES3))
				request.WithQueryParameter("RES3", m3_RES3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RES4))
				request.WithQueryParameter("RES4", m3_RES4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDFR))
				request.WithQueryParameter("EDFR", m3_EDFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3_RGTM.Value.ToString());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());
			if (m3_CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3_CHNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());

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
		/// Name ChgStkIns
		/// Description Change Internal Stock Instruction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSNR">Message number (Required)</param>
		/// <param name="m3_MSLN">Message line number (Required)</param>
		/// <param name="m3_MSGS">Sequence number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_QLFR">Qualifier</param>
		/// <param name="m3_QLFS">Sequence number</param>
		/// <param name="m3_QLFT">Qualifier type</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_PLFD">Planned finish date</param>
		/// <param name="m3_PLFT">Time generated</param>
		/// <param name="m3_FIDT">Finish date</param>
		/// <param name="m3_FITE">Execution time</param>
		/// <param name="m3_QLQT">Qualifier unit of measure</param>
		/// <param name="m3_QLUN">Qualifier unit of measure</param>
		/// <param name="m3_QLDT">Qualifier date</param>
		/// <param name="m3_E0D5">Item price</param>
		/// <param name="m3_E0CB">Currency</param>
		/// <param name="m3_COCD">Costing price quantity</param>
		/// <param name="m3_MSID">Message ID</param>
		/// <param name="m3_MSGF">Message file</param>
		/// <param name="m3_MSGD">Message</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_TWLO">To warehouse</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="m3_NITN">New item number</param>
		/// <param name="m3_NBAN">New lot number</param>
		/// <param name="m3_TOCA">To container</param>
		/// <param name="m3_ALOC">Allocatable</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_STAS">Status - balance ID</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_REMK">Remark</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_TRTP">Order type</param>
		/// <param name="m3_TRQT">Transaction quantity - basic U/M</param>
		/// <param name="m3_TRUN">Free trade association</param>
		/// <param name="m3_POCY">Normal potency</param>
		/// <param name="m3_PRDT">Priority date</param>
		/// <param name="m3_REFE">Reference</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_RGDT">Not used!</param>
		/// <param name="m3_RGTM">Not used!</param>
		/// <param name="m3_LMDT">Not used!</param>
		/// <param name="m3_CHNO">Not used!</param>
		/// <param name="m3_CHID">Not used!</param>
		/// <param name="m3_TASN">Task number</param>
		/// <param name="m3_QLTM">Qualifier time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgStkIns(
			string m3_MSNR, 
			int m3_MSLN, 
			int m3_MSGS, 
			int? m3_CONO = null, 
			string m3_QLFR = null, 
			int? m3_QLFS = null, 
			int? m3_QLFT = null, 
			string m3_STAT = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			DateTime? m3_PLFD = null, 
			int? m3_PLFT = null, 
			DateTime? m3_FIDT = null, 
			int? m3_FITE = null, 
			decimal? m3_QLQT = null, 
			string m3_QLUN = null, 
			DateTime? m3_QLDT = null, 
			decimal? m3_E0D5 = null, 
			string m3_E0CB = null, 
			int? m3_COCD = null, 
			string m3_MSID = null, 
			string m3_MSGF = null, 
			string m3_MSGD = null, 
			decimal? m3_TXID = null, 
			string m3_TWLO = null, 
			string m3_TWSL = null, 
			string m3_NITN = null, 
			string m3_NBAN = null, 
			string m3_TOCA = null, 
			int? m3_ALOC = null, 
			decimal? m3_CAWE = null, 
			string m3_STAS = null, 
			string m3_RSCD = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			string m3_REMK = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_WHLO = null, 
			string m3_RORN = null, 
			string m3_TRTP = null, 
			decimal? m3_TRQT = null, 
			string m3_TRUN = null, 
			int? m3_POCY = null, 
			DateTime? m3_PRDT = null, 
			string m3_REFE = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			DateTime? m3_RGDT = null, 
			int? m3_RGTM = null, 
			DateTime? m3_LMDT = null, 
			int? m3_CHNO = null, 
			string m3_CHID = null, 
			long? m3_TASN = null, 
			int? m3_QLTM = null, 
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
			if (string.IsNullOrWhiteSpace(m3_MSNR))
				throw new ArgumentNullException("m3_MSNR");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3_MSNR.Trim())
				.WithQueryParameter("MSLN", m3_MSLN.ToString())
				.WithQueryParameter("MSGS", m3_MSGS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QLFR))
				request.WithQueryParameter("QLFR", m3_QLFR.Trim());
			if (m3_QLFS.HasValue)
				request.WithQueryParameter("QLFS", m3_QLFS.Value.ToString());
			if (m3_QLFT.HasValue)
				request.WithQueryParameter("QLFT", m3_QLFT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (m3_PLFD.HasValue)
				request.WithQueryParameter("PLFD", m3_PLFD.Value.ToM3String());
			if (m3_PLFT.HasValue)
				request.WithQueryParameter("PLFT", m3_PLFT.Value.ToString());
			if (m3_FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3_FIDT.Value.ToM3String());
			if (m3_FITE.HasValue)
				request.WithQueryParameter("FITE", m3_FITE.Value.ToString());
			if (m3_QLQT.HasValue)
				request.WithQueryParameter("QLQT", m3_QLQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QLUN))
				request.WithQueryParameter("QLUN", m3_QLUN.Trim());
			if (m3_QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3_QLDT.Value.ToM3String());
			if (m3_E0D5.HasValue)
				request.WithQueryParameter("E0D5", m3_E0D5.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_E0CB))
				request.WithQueryParameter("E0CB", m3_E0CB.Trim());
			if (m3_COCD.HasValue)
				request.WithQueryParameter("COCD", m3_COCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSID))
				request.WithQueryParameter("MSID", m3_MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSGF))
				request.WithQueryParameter("MSGF", m3_MSGF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSGD))
				request.WithQueryParameter("MSGD", m3_MSGD.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TWLO))
				request.WithQueryParameter("TWLO", m3_TWLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NITN))
				request.WithQueryParameter("NITN", m3_NITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NBAN))
				request.WithQueryParameter("NBAN", m3_NBAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOCA))
				request.WithQueryParameter("TOCA", m3_TOCA.Trim());
			if (m3_ALOC.HasValue)
				request.WithQueryParameter("ALOC", m3_ALOC.Value.ToString());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAS))
				request.WithQueryParameter("STAS", m3_STAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REMK))
				request.WithQueryParameter("REMK", m3_REMK.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRTP))
				request.WithQueryParameter("TRTP", m3_TRTP.Trim());
			if (m3_TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3_TRQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TRUN))
				request.WithQueryParameter("TRUN", m3_TRUN.Trim());
			if (m3_POCY.HasValue)
				request.WithQueryParameter("POCY", m3_POCY.Value.ToString());
			if (m3_PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3_PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_REFE))
				request.WithQueryParameter("REFE", m3_REFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3_RGTM.Value.ToString());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());
			if (m3_CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3_CHNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());
			if (m3_TASN.HasValue)
				request.WithQueryParameter("TASN", m3_TASN.Value.ToString());
			if (m3_QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3_QLTM.Value.ToString());

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
		/// Name ChgSubline
		/// Description Chg Subline Information
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_MSNR">Message Number (Required)</param>
		/// <param name="m3_MSLN">Message line number (Required)</param>
		/// <param name="m3_MSGS">Sequence number (Required)</param>
		/// <param name="m3_SUBL">Subline number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_BANT">Reference sublot ID</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgSubline(
			string m3_MSNR, 
			int m3_MSLN, 
			int m3_MSGS, 
			int m3_SUBL, 
			int? m3_CONO = null, 
			string m3_BANT = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgSubline",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSNR))
				throw new ArgumentNullException("m3_MSNR");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3_MSNR.Trim())
				.WithQueryParameter("MSLN", m3_MSLN.ToString())
				.WithQueryParameter("MSGS", m3_MSGS.ToString())
				.WithQueryParameter("SUBL", m3_SUBL.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANT))
				request.WithQueryParameter("BANT", m3_BANT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
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
		/// Name DeleteStkTran
		/// Description Delete Internal Stock Transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSNR">Message number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_MSGS">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteStkTran(
			string m3_MSNR, 
			int? m3_CONO = null, 
			int? m3_MSLN = null, 
			int? m3_MSGS = null, 
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
			if (string.IsNullOrWhiteSpace(m3_MSNR))
				throw new ArgumentNullException("m3_MSNR");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3_MSNR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (m3_MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3_MSGS.Value.ToString());

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
		/// Name DeleteSubline
		/// Description Delete  Subline Information
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_MSNR">Message Number (Required)</param>
		/// <param name="m3_MSLN">Message line number (Required)</param>
		/// <param name="m3_MSGS">Sequence number (Required)</param>
		/// <param name="m3_SUBL">Subline number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteSubline(
			string m3_MSNR, 
			int m3_MSLN, 
			int m3_MSGS, 
			int m3_SUBL, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeleteSubline",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSNR))
				throw new ArgumentNullException("m3_MSNR");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3_MSNR.Trim())
				.WithQueryParameter("MSLN", m3_MSLN.ToString())
				.WithQueryParameter("MSGS", m3_MSGS.ToString())
				.WithQueryParameter("SUBL", m3_SUBL.ToString());

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
		/// Name GetMvxMsg
		/// Description Get Movex Message ID
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PB">Partner (Required)</param>
		/// <param name="m3_PMSN">External message number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMvxMsgResponse></returns>
		/// <exception cref="M3Exception<GetMvxMsgResponse>"></exception>
		public async Task<M3Response<GetMvxMsgResponse>> GetMvxMsg(
			string m3_E0PB, 
			string m3_PMSN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMvxMsg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PB))
				throw new ArgumentNullException("m3_E0PB");
			if (string.IsNullOrWhiteSpace(m3_PMSN))
				throw new ArgumentNullException("m3_PMSN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PB", m3_E0PB.Trim())
				.WithQueryParameter("PMSN", m3_PMSN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetMvxMsgResponse>(
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
		/// Name GetStkHead
		/// Description Get Internal Stock Header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSNR">Message number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetStkHeadResponse></returns>
		/// <exception cref="M3Exception<GetStkHeadResponse>"></exception>
		public async Task<M3Response<GetStkHeadResponse>> GetStkHead(
			string m3_MSNR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetStkHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSNR))
				throw new ArgumentNullException("m3_MSNR");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3_MSNR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetStkHeadResponse>(
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
		/// Name GetStkId
		/// Description Get Internal Stock Identity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSNR">Message number (Required)</param>
		/// <param name="m3_MSLN">Message line number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetStkIdResponse></returns>
		/// <exception cref="M3Exception<GetStkIdResponse>"></exception>
		public async Task<M3Response<GetStkIdResponse>> GetStkId(
			string m3_MSNR, 
			int m3_MSLN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetStkId",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSNR))
				throw new ArgumentNullException("m3_MSNR");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3_MSNR.Trim())
				.WithQueryParameter("MSLN", m3_MSLN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetStkIdResponse>(
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
		/// Name GetStkIns
		/// Description Get Internal Stock Instruction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSNR">Message number (Required)</param>
		/// <param name="m3_MSLN">Message line number (Required)</param>
		/// <param name="m3_MSGS">Sequence number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetStkInsResponse></returns>
		/// <exception cref="M3Exception<GetStkInsResponse>"></exception>
		public async Task<M3Response<GetStkInsResponse>> GetStkIns(
			string m3_MSNR, 
			int m3_MSLN, 
			int m3_MSGS, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetStkIns",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSNR))
				throw new ArgumentNullException("m3_MSNR");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3_MSNR.Trim())
				.WithQueryParameter("MSLN", m3_MSLN.ToString())
				.WithQueryParameter("MSGS", m3_MSGS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetStkInsResponse>(
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
		/// Name LstMvxMsg
		/// Description List Movex Message ID
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PB">Partner (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMvxMsgResponse></returns>
		/// <exception cref="M3Exception<LstMvxMsgResponse>"></exception>
		public async Task<M3Response<LstMvxMsgResponse>> LstMvxMsg(
			string m3_E0PB, 
			int? m3_CONO = null, 
			string m3_PMSN = null, 
			string m3_STAT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_E0PB))
				throw new ArgumentNullException("m3_E0PB");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PB", m3_E0PB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());

			// Execute the request
			var result = await Execute<LstMvxMsgResponse>(
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
		/// Name LstSubline
		/// Description List SubLines
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_MSNR">Message Number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_MSGS">Sequence number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSublineResponse></returns>
		/// <exception cref="M3Exception<LstSublineResponse>"></exception>
		public async Task<M3Response<LstSublineResponse>> LstSubline(
			string m3_MSNR, 
			int? m3_CONO = null, 
			int? m3_MSLN = null, 
			int? m3_MSGS = null, 
			string m3_ITNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSubline",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSNR))
				throw new ArgumentNullException("m3_MSNR");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3_MSNR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (m3_MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3_MSGS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());

			// Execute the request
			var result = await Execute<LstSublineResponse>(
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
		/// Name PrcStkTran
		/// Description Process Internal Stock Transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSNR">Message number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_MSGS">Sequence number</param>
		/// <param name="m3_PRFL">Process flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrcStkTran(
			string m3_MSNR, 
			int? m3_CONO = null, 
			int? m3_MSLN = null, 
			int? m3_MSGS = null, 
			string m3_PRFL = null, 
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
			if (string.IsNullOrWhiteSpace(m3_MSNR))
				throw new ArgumentNullException("m3_MSNR");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3_MSNR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (m3_MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3_MSGS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());

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
		/// Name SndAdjust
		/// Description Add Stock Adjustment Transaction (update with +/- qty)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_PRFL">Process flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSNR">Message number</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_MSGS">Sequence number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_QLQT">Quantity</param>
		/// <param name="m3_QLUN">Qualifier unit of measure</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_USD1">User defined 1</param>
		/// <param name="m3_USD2">User defined 2</param>
		/// <param name="m3_USD3">User defined 3</param>
		/// <param name="m3_USD4">User defined 4</param>
		/// <param name="m3_USD5">User defined 5</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_QLDT">Qualifier date</param>
		/// <param name="m3_QLTM">Qualifier time</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_STAG">Status - physical inv</param>
		/// <param name="m3_PRDT">Priority date</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndAdjust(
			string m3_E0PA, 
			string m3_E065, 
			string m3_WHLO, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSNR = null, 
			int? m3_MSLN = null, 
			int? m3_MSGS = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_WHSL = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			long? m3_REPN = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			decimal? m3_QLQT = null, 
			string m3_QLUN = null, 
			string m3_BREM = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			string m3_RSCD = null, 
			DateTime? m3_QLDT = null, 
			int? m3_QLTM = null, 
			decimal? m3_CAWE = null, 
			string m3_PMSN = null, 
			int? m3_STAG = null, 
			DateTime? m3_PRDT = null, 
			string m3_RESP = null, 
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
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSNR))
				request.WithQueryParameter("MSNR", m3_MSNR.Trim());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (m3_MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3_MSGS.Value.ToString());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (m3_QLQT.HasValue)
				request.WithQueryParameter("QLQT", m3_QLQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QLUN))
				request.WithQueryParameter("QLUN", m3_QLUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (m3_QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3_QLDT.Value.ToM3String());
			if (m3_QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3_QLTM.Value.ToString());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (m3_STAG.HasValue)
				request.WithQueryParameter("STAG", m3_STAG.Value.ToString());
			if (m3_PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3_PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());

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
		/// Name SndPartialCount
		/// Description Send Partial counts for physical inventory
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_STNB">Physical inventory number (Required)</param>
		/// <param name="m3_PRFL">Process flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSNR">Message Number</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_MSGS">Sequence number</param>
		/// <param name="m3_STRN">Physical inventory line</param>
		/// <param name="m3_STQI">Physical inventory quantity</param>
		/// <param name="m3_QLDT">Qualifier date</param>
		/// <param name="m3_QLTM">Qualifier time</param>
		/// <param name="m3_QLUN">Qualifier unit of measure</param>
		/// <param name="m3_SAQI">Physical inventory quantity - Main U/M</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias category</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_STAG">Status - physical inventory</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_RENU">Recount number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndPartialCount(
			string m3_E0PA, 
			string m3_E065, 
			string m3_WHLO, 
			long m3_STNB, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			string m3_MSNR = null, 
			int? m3_MSLN = null, 
			int? m3_MSGS = null, 
			int? m3_STRN = null, 
			decimal? m3_STQI = null, 
			DateTime? m3_QLDT = null, 
			int? m3_QLTM = null, 
			string m3_QLUN = null, 
			decimal? m3_SAQI = null, 
			string m3_ITNO = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			long? m3_REPN = null, 
			string m3_BREM = null, 
			string m3_RESP = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			decimal? m3_CAWE = null, 
			int? m3_STAG = null, 
			string m3_PMSN = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndPartialCount",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("STNB", m3_STNB.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSNR))
				request.WithQueryParameter("MSNR", m3_MSNR.Trim());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (m3_MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3_MSGS.Value.ToString());
			if (m3_STRN.HasValue)
				request.WithQueryParameter("STRN", m3_STRN.Value.ToString());
			if (m3_STQI.HasValue)
				request.WithQueryParameter("STQI", m3_STQI.Value.ToString());
			if (m3_QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3_QLDT.Value.ToM3String());
			if (m3_QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3_QLTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QLUN))
				request.WithQueryParameter("QLUN", m3_QLUN.Trim());
			if (m3_SAQI.HasValue)
				request.WithQueryParameter("SAQI", m3_SAQI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (m3_STAG.HasValue)
				request.WithQueryParameter("STAG", m3_STAG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
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
		/// Name SndStkId
		/// Description Send Internal Stock Identity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSNR">Message number (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_WHSL">Location (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_PMSN">External message number</param>
		/// <param name="m3_PMSL">External message line number</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_CHGD">Date changed</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias type</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_FUDS">Description 2</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_UNIT">Unit of measure</param>
		/// <param name="m3_STLO">Lowest status</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_STHI">Highest status</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_RES2">Responsible</param>
		/// <param name="m3_RES3">Responsible</param>
		/// <param name="m3_RES4">Responsible</param>
		/// <param name="m3_EDFR">EDI reference</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_RGDT">Not used!</param>
		/// <param name="m3_RGTM">Not used!</param>
		/// <param name="m3_LMDT">Not used!</param>
		/// <param name="m3_CHNO">Not used!</param>
		/// <param name="m3_CHID">Not used!</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndStkId(
			string m3_MSNR, 
			string m3_WHLO, 
			string m3_WHSL, 
			int? m3_CONO = null, 
			int? m3_MSLN = null, 
			string m3_PMSN = null, 
			int? m3_PMSL = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			DateTime? m3_CHGD = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			long? m3_REPN = null, 
			string m3_FACI = null, 
			string m3_POPN = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			string m3_ITDS = null, 
			string m3_FUDS = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			string m3_BREM = null, 
			string m3_UNIT = null, 
			string m3_STLO = null, 
			string m3_STAT = null, 
			string m3_STHI = null, 
			decimal? m3_TXID = null, 
			string m3_RESP = null, 
			string m3_RES2 = null, 
			string m3_RES3 = null, 
			string m3_RES4 = null, 
			string m3_EDFR = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			DateTime? m3_RGDT = null, 
			int? m3_RGTM = null, 
			DateTime? m3_LMDT = null, 
			int? m3_CHNO = null, 
			string m3_CHID = null, 
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
			if (string.IsNullOrWhiteSpace(m3_MSNR))
				throw new ArgumentNullException("m3_MSNR");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_WHSL))
				throw new ArgumentNullException("m3_WHSL");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3_MSNR.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("WHSL", m3_WHSL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PMSN))
				request.WithQueryParameter("PMSN", m3_PMSN.Trim());
			if (m3_PMSL.HasValue)
				request.WithQueryParameter("PMSL", m3_PMSL.Value.ToString());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (m3_CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3_CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FUDS))
				request.WithQueryParameter("FUDS", m3_FUDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UNIT))
				request.WithQueryParameter("UNIT", m3_UNIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STLO))
				request.WithQueryParameter("STLO", m3_STLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STHI))
				request.WithQueryParameter("STHI", m3_STHI.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RES2))
				request.WithQueryParameter("RES2", m3_RES2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RES3))
				request.WithQueryParameter("RES3", m3_RES3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RES4))
				request.WithQueryParameter("RES4", m3_RES4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDFR))
				request.WithQueryParameter("EDFR", m3_EDFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3_RGTM.Value.ToString());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());
			if (m3_CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3_CHNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());

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
		/// Name SndStkIns
		/// Description Send Internal Stock Instruction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSNR">Message number (Required)</param>
		/// <param name="m3_MSLN">Message line number (Required)</param>
		/// <param name="m3_QLFR">Qualifier (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSGS">Sequence number</param>
		/// <param name="m3_QLFS">Sequence number</param>
		/// <param name="m3_QLFT">Qualifier type</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_PLFD">Planned finish date</param>
		/// <param name="m3_PLFT">Time generated</param>
		/// <param name="m3_FIDT">Finish date</param>
		/// <param name="m3_FITE">Execution time</param>
		/// <param name="m3_QLQT">Quantity</param>
		/// <param name="m3_QLUN">Qualifier unit of measure</param>
		/// <param name="m3_QLDT">Qualifier date</param>
		/// <param name="m3_E0D5">Item price</param>
		/// <param name="m3_E0CB">Currency</param>
		/// <param name="m3_COCD">Costing price quantity</param>
		/// <param name="m3_MSID">Message ID</param>
		/// <param name="m3_MSGF">Message file</param>
		/// <param name="m3_MSGD">Message</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_TWLO">To warehouse</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="m3_NITN">New item number</param>
		/// <param name="m3_NBAN">New lot number</param>
		/// <param name="m3_TOCA">To container</param>
		/// <param name="m3_ALOC">Allocatable</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_STAS">Status - balance ID</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_REMK">Remark</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_TRTP">Order type</param>
		/// <param name="m3_TRQT">Transaction quantity - basic U/M</param>
		/// <param name="m3_TRUN">Free trade association</param>
		/// <param name="m3_POCY">Normal potency</param>
		/// <param name="m3_PRDT">Priority date</param>
		/// <param name="m3_REFE">Reference</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_RGDT">Not used!</param>
		/// <param name="m3_RGTM">Not used!</param>
		/// <param name="m3_LMDT">Not used!</param>
		/// <param name="m3_CHNO">Not used!</param>
		/// <param name="m3_CHID">Not used!</param>
		/// <param name="m3_TASN">Task number</param>
		/// <param name="m3_QLTM">Qualifier time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndStkIns(
			string m3_MSNR, 
			int m3_MSLN, 
			string m3_QLFR, 
			int? m3_CONO = null, 
			int? m3_MSGS = null, 
			int? m3_QLFS = null, 
			int? m3_QLFT = null, 
			string m3_STAT = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			DateTime? m3_PLFD = null, 
			int? m3_PLFT = null, 
			DateTime? m3_FIDT = null, 
			int? m3_FITE = null, 
			decimal? m3_QLQT = null, 
			string m3_QLUN = null, 
			DateTime? m3_QLDT = null, 
			decimal? m3_E0D5 = null, 
			string m3_E0CB = null, 
			int? m3_COCD = null, 
			string m3_MSID = null, 
			string m3_MSGF = null, 
			string m3_MSGD = null, 
			decimal? m3_TXID = null, 
			string m3_TWLO = null, 
			string m3_TWSL = null, 
			string m3_NITN = null, 
			string m3_NBAN = null, 
			string m3_TOCA = null, 
			int? m3_ALOC = null, 
			decimal? m3_CAWE = null, 
			string m3_STAS = null, 
			string m3_RSCD = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			string m3_REMK = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_WHLO = null, 
			string m3_RORN = null, 
			string m3_TRTP = null, 
			decimal? m3_TRQT = null, 
			string m3_TRUN = null, 
			int? m3_POCY = null, 
			DateTime? m3_PRDT = null, 
			string m3_REFE = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			DateTime? m3_RGDT = null, 
			int? m3_RGTM = null, 
			DateTime? m3_LMDT = null, 
			int? m3_CHNO = null, 
			string m3_CHID = null, 
			long? m3_TASN = null, 
			int? m3_QLTM = null, 
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
			if (string.IsNullOrWhiteSpace(m3_MSNR))
				throw new ArgumentNullException("m3_MSNR");
			if (string.IsNullOrWhiteSpace(m3_QLFR))
				throw new ArgumentNullException("m3_QLFR");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSNR", m3_MSNR.Trim())
				.WithQueryParameter("MSLN", m3_MSLN.ToString())
				.WithQueryParameter("QLFR", m3_QLFR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_MSGS.HasValue)
				request.WithQueryParameter("MSGS", m3_MSGS.Value.ToString());
			if (m3_QLFS.HasValue)
				request.WithQueryParameter("QLFS", m3_QLFS.Value.ToString());
			if (m3_QLFT.HasValue)
				request.WithQueryParameter("QLFT", m3_QLFT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (m3_PLFD.HasValue)
				request.WithQueryParameter("PLFD", m3_PLFD.Value.ToM3String());
			if (m3_PLFT.HasValue)
				request.WithQueryParameter("PLFT", m3_PLFT.Value.ToString());
			if (m3_FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3_FIDT.Value.ToM3String());
			if (m3_FITE.HasValue)
				request.WithQueryParameter("FITE", m3_FITE.Value.ToString());
			if (m3_QLQT.HasValue)
				request.WithQueryParameter("QLQT", m3_QLQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QLUN))
				request.WithQueryParameter("QLUN", m3_QLUN.Trim());
			if (m3_QLDT.HasValue)
				request.WithQueryParameter("QLDT", m3_QLDT.Value.ToM3String());
			if (m3_E0D5.HasValue)
				request.WithQueryParameter("E0D5", m3_E0D5.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_E0CB))
				request.WithQueryParameter("E0CB", m3_E0CB.Trim());
			if (m3_COCD.HasValue)
				request.WithQueryParameter("COCD", m3_COCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSID))
				request.WithQueryParameter("MSID", m3_MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSGF))
				request.WithQueryParameter("MSGF", m3_MSGF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSGD))
				request.WithQueryParameter("MSGD", m3_MSGD.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TWLO))
				request.WithQueryParameter("TWLO", m3_TWLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NITN))
				request.WithQueryParameter("NITN", m3_NITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NBAN))
				request.WithQueryParameter("NBAN", m3_NBAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOCA))
				request.WithQueryParameter("TOCA", m3_TOCA.Trim());
			if (m3_ALOC.HasValue)
				request.WithQueryParameter("ALOC", m3_ALOC.Value.ToString());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAS))
				request.WithQueryParameter("STAS", m3_STAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REMK))
				request.WithQueryParameter("REMK", m3_REMK.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRTP))
				request.WithQueryParameter("TRTP", m3_TRTP.Trim());
			if (m3_TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3_TRQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TRUN))
				request.WithQueryParameter("TRUN", m3_TRUN.Trim());
			if (m3_POCY.HasValue)
				request.WithQueryParameter("POCY", m3_POCY.Value.ToString());
			if (m3_PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3_PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_REFE))
				request.WithQueryParameter("REFE", m3_REFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3_RGTM.Value.ToString());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());
			if (m3_CHNO.HasValue)
				request.WithQueryParameter("CHNO", m3_CHNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());
			if (m3_TASN.HasValue)
				request.WithQueryParameter("TASN", m3_TASN.Value.ToString());
			if (m3_QLTM.HasValue)
				request.WithQueryParameter("QLTM", m3_QLTM.Value.ToString());

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
