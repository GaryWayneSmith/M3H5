/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PMS050MI;
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
	/// Name: PMS050MI
	/// Component Name: ManufacturingOrderRptReceipt
	/// Description: Manufacturing order. Report receipt interface
	/// Version Release: 5ea1
	///</summary>
	public partial class PMS050MIResource : M3BaseResourceEndpoint
	{
		public PMS050MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PMS050MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ConfirmAll
		/// Description Confirm All
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_MFNO">Manufacturing order number</param>
		/// <param name="m3_WOSQ">Reporting number</param>
		/// <param name="m3_SCHN">Schedule number</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_LIRR">LI request rule</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ConfirmAll(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_MFNO = null, 
			decimal? m3_WOSQ = null, 
			decimal? m3_SCHN = null, 
			DateTime? m3_RPDT = null, 
			int? m3_RPTM = null, 
			int? m3_LIRR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ConfirmAll",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MFNO))
				request.WithQueryParameter("MFNO", m3_MFNO.Trim());
			if (m3_WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3_WOSQ.Value.ToString());
			if (m3_SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3_SCHN.Value.ToString());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (m3_LIRR.HasValue)
				request.WithQueryParameter("LIRR", m3_LIRR.Value.ToString());

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
		/// Name RptReceipt
		/// Description Report receipt
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_MFNO">Manufacturing order number</param>
		/// <param name="m3_WOSQ">Reporting number</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TRTM">Transaction time</param>
		/// <param name="m3_PRDT">Priority date</param>
		/// <param name="m3_POCY">Potency</param>
		/// <param name="m3_RPQA">Reported quantity in alternative unit</param>
		/// <param name="m3_MAUN">Manufacturing U/M</param>
		/// <param name="m3_STAS">Status - balance ID</param>
		/// <param name="m3_REND">Manual completion flag</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_PAC2">Packaging</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_TRPR">Inventory accounting price</param>
		/// <param name="m3_TRPC">Inventory accounting price quantity</param>
		/// <param name="m3_CHID">Changed by</param>
		/// <param name="m3_DSP1">Warning indicator 1</param>
		/// <param name="m3_DSP2">Warning indicator 2</param>
		/// <param name="m3_DSP3">Warning indicator 3</param>
		/// <param name="m3_DSP4">Warning indicator 4</param>
		/// <param name="m3_DSP5">Warning indicator 5</param>
		/// <param name="m3_DSP6">Warning indicator 6</param>
		/// <param name="m3_DSP7">Warning indicator 7</param>
		/// <param name="m3_DSP8">Warning indicator 8</param>
		/// <param name="m3_PLNO">Production lot number</param>
		/// <param name="m3_AT01">Attribute id 1</param>
		/// <param name="m3_AV01">Attribute value 1</param>
		/// <param name="m3_AT02">Attribute id 2</param>
		/// <param name="m3_AV02">Attribute value 2</param>
		/// <param name="m3_AT03">Attribute id 3</param>
		/// <param name="m3_AV03">Attribute value 3</param>
		/// <param name="m3_AT04">Attribute id 4</param>
		/// <param name="m3_AV04">Attribute value 4</param>
		/// <param name="m3_AT05">Attribute id 5</param>
		/// <param name="m3_AV05">Attribute value 5</param>
		/// <param name="m3_AT06">Attribute id 6</param>
		/// <param name="m3_AV06">Attribute value 6</param>
		/// <param name="m3_AT07">Attribute id 7</param>
		/// <param name="m3_AV07">Attribute value 7</param>
		/// <param name="m3_AT08">Attribute id 8</param>
		/// <param name="m3_AV08">Attribute value 8</param>
		/// <param name="m3_AT09">Attribute id 9</param>
		/// <param name="m3_AV09">Attribute value 9</param>
		/// <param name="m3_AT10">Attribute id 10</param>
		/// <param name="m3_AV10">Attribute value 10</param>
		/// <param name="m3_PAII">Included in package number</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_LIRR">LI request rule</param>
		/// <param name="m3_EXPI">Expiration date</param>
		/// <param name="m3_HVDT">Harvested date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<RptReceiptResponse></returns>
		/// <exception cref="M3Exception<RptReceiptResponse>"></exception>
		public async Task<M3Response<RptReceiptResponse>> RptReceipt(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_MFNO = null, 
			decimal? m3_WOSQ = null, 
			DateTime? m3_RPDT = null, 
			int? m3_RPTM = null, 
			DateTime? m3_TRDT = null, 
			int? m3_TRTM = null, 
			DateTime? m3_PRDT = null, 
			int? m3_POCY = null, 
			decimal? m3_RPQA = null, 
			string m3_MAUN = null, 
			string m3_STAS = null, 
			int? m3_REND = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			string m3_PAC2 = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			decimal? m3_CAWE = null, 
			decimal? m3_TRPR = null, 
			int? m3_TRPC = null, 
			string m3_CHID = null, 
			string m3_DSP1 = null, 
			string m3_DSP2 = null, 
			string m3_DSP3 = null, 
			string m3_DSP4 = null, 
			string m3_DSP5 = null, 
			string m3_DSP6 = null, 
			string m3_DSP7 = null, 
			string m3_DSP8 = null, 
			long? m3_PLNO = null, 
			string m3_AT01 = null, 
			string m3_AV01 = null, 
			string m3_AT02 = null, 
			string m3_AV02 = null, 
			string m3_AT03 = null, 
			string m3_AV03 = null, 
			string m3_AT04 = null, 
			string m3_AV04 = null, 
			string m3_AT05 = null, 
			string m3_AV05 = null, 
			string m3_AT06 = null, 
			string m3_AV06 = null, 
			string m3_AT07 = null, 
			string m3_AV07 = null, 
			string m3_AT08 = null, 
			string m3_AV08 = null, 
			string m3_AT09 = null, 
			string m3_AV09 = null, 
			string m3_AT10 = null, 
			string m3_AV10 = null, 
			string m3_PAII = null, 
			string m3_PACT = null, 
			int? m3_LIRR = null, 
			DateTime? m3_EXPI = null, 
			DateTime? m3_HVDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RptReceipt",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MFNO))
				request.WithQueryParameter("MFNO", m3_MFNO.Trim());
			if (m3_WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3_WOSQ.Value.ToString());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());
			if (m3_PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3_PRDT.Value.ToM3String());
			if (m3_POCY.HasValue)
				request.WithQueryParameter("POCY", m3_POCY.Value.ToString());
			if (m3_RPQA.HasValue)
				request.WithQueryParameter("RPQA", m3_RPQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MAUN))
				request.WithQueryParameter("MAUN", m3_MAUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAS))
				request.WithQueryParameter("STAS", m3_STAS.Trim());
			if (m3_REND.HasValue)
				request.WithQueryParameter("REND", m3_REND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAC2))
				request.WithQueryParameter("PAC2", m3_PAC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (m3_TRPR.HasValue)
				request.WithQueryParameter("TRPR", m3_TRPR.Value.ToString());
			if (m3_TRPC.HasValue)
				request.WithQueryParameter("TRPC", m3_TRPC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSP1))
				request.WithQueryParameter("DSP1", m3_DSP1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSP2))
				request.WithQueryParameter("DSP2", m3_DSP2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSP3))
				request.WithQueryParameter("DSP3", m3_DSP3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSP4))
				request.WithQueryParameter("DSP4", m3_DSP4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSP5))
				request.WithQueryParameter("DSP5", m3_DSP5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSP6))
				request.WithQueryParameter("DSP6", m3_DSP6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSP7))
				request.WithQueryParameter("DSP7", m3_DSP7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSP8))
				request.WithQueryParameter("DSP8", m3_DSP8.Trim());
			if (m3_PLNO.HasValue)
				request.WithQueryParameter("PLNO", m3_PLNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AT01))
				request.WithQueryParameter("AT01", m3_AT01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AV01))
				request.WithQueryParameter("AV01", m3_AV01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AT02))
				request.WithQueryParameter("AT02", m3_AT02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AV02))
				request.WithQueryParameter("AV02", m3_AV02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AT03))
				request.WithQueryParameter("AT03", m3_AT03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AV03))
				request.WithQueryParameter("AV03", m3_AV03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AT04))
				request.WithQueryParameter("AT04", m3_AT04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AV04))
				request.WithQueryParameter("AV04", m3_AV04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AT05))
				request.WithQueryParameter("AT05", m3_AT05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AV05))
				request.WithQueryParameter("AV05", m3_AV05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AT06))
				request.WithQueryParameter("AT06", m3_AT06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AV06))
				request.WithQueryParameter("AV06", m3_AV06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AT07))
				request.WithQueryParameter("AT07", m3_AT07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AV07))
				request.WithQueryParameter("AV07", m3_AV07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AT08))
				request.WithQueryParameter("AT08", m3_AT08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AV08))
				request.WithQueryParameter("AV08", m3_AV08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AT09))
				request.WithQueryParameter("AT09", m3_AT09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AV09))
				request.WithQueryParameter("AV09", m3_AV09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AT10))
				request.WithQueryParameter("AT10", m3_AT10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AV10))
				request.WithQueryParameter("AV10", m3_AV10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAII))
				request.WithQueryParameter("PAII", m3_PAII.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (m3_LIRR.HasValue)
				request.WithQueryParameter("LIRR", m3_LIRR.Value.ToString());
			if (m3_EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3_EXPI.Value.ToM3String());
			if (m3_HVDT.HasValue)
				request.WithQueryParameter("HVDT", m3_HVDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<RptReceiptResponse>(
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
		/// Name UpdProcess
		/// Description Update Process
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MAQA">Manufactured quantity</param>
		/// <param name="m3_REND">Manual completion flag</param>
		/// <param name="m3_DSP1">Warning indicator 1</param>
		/// <param name="m3_DSP2">Warning indicator 2</param>
		/// <param name="m3_DSP3">Warning indicator 3</param>
		/// <param name="m3_DSP4">Warning indicator 4</param>
		/// <param name="m3_DSP5">Warning indicator 5</param>
		/// <param name="m3_DSP6">Warning indicator 6</param>
		/// <param name="m3_DSP7">Warning indicator 7</param>
		/// <param name="m3_DSP8">Warning indicator 8</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdProcess(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_MFNO, 
			int? m3_CONO = null, 
			decimal? m3_MAQA = null, 
			int? m3_REND = null, 
			string m3_DSP1 = null, 
			string m3_DSP2 = null, 
			string m3_DSP3 = null, 
			string m3_DSP4 = null, 
			string m3_DSP5 = null, 
			string m3_DSP6 = null, 
			string m3_DSP7 = null, 
			string m3_DSP8 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdProcess",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_MFNO))
				throw new ArgumentNullException("m3_MFNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("MFNO", m3_MFNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_MAQA.HasValue)
				request.WithQueryParameter("MAQA", m3_MAQA.Value.ToString());
			if (m3_REND.HasValue)
				request.WithQueryParameter("REND", m3_REND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DSP1))
				request.WithQueryParameter("DSP1", m3_DSP1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSP2))
				request.WithQueryParameter("DSP2", m3_DSP2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSP3))
				request.WithQueryParameter("DSP3", m3_DSP3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSP4))
				request.WithQueryParameter("DSP4", m3_DSP4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSP5))
				request.WithQueryParameter("DSP5", m3_DSP5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSP6))
				request.WithQueryParameter("DSP6", m3_DSP6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSP7))
				request.WithQueryParameter("DSP7", m3_DSP7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSP8))
				request.WithQueryParameter("DSP8", m3_DSP8.Trim());

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
