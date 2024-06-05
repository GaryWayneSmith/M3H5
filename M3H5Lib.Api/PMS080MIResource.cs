/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
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
	/// Name: PMS080MI
	/// Component Name: ManufacturingOrderRptByProduct
	/// Description: Manufacturing Order. Report by-product interface
	/// Version Release: 5ea1
	///</summary>
	public partial class PMS080MIResource : M3BaseResourceEndpoint
	{
		public PMS080MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PMS080MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Confirm
		/// Description Manufacturing Order. Confirm by-product
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_MFNO">Manufacturing order number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_WOSQ">Reporting number</param>
		/// <param name="m3_MTNO">Component number</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TRTM">Transaction time</param>
		/// <param name="m3_CHID">Changed by</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Confirm(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_MFNO = null, 
			int? m3_OPNO = null, 
			int? m3_MSEQ = null, 
			decimal? m3_WOSQ = null, 
			string m3_MTNO = null, 
			DateTime? m3_RPDT = null, 
			int? m3_RPTM = null, 
			DateTime? m3_TRDT = null, 
			int? m3_TRTM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Confirm",
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
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (m3_WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3_WOSQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MTNO))
				request.WithQueryParameter("MTNO", m3_MTNO.Trim());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());
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
		/// Name DltByProduct
		/// Description Manufacturing Order. Delete by-product
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_MFNO">Manufacturing order number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_WOSQ">Reporting number</param>
		/// <param name="m3_MTNO">Component number</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TRTM">Transaction time</param>
		/// <param name="m3_CHID">Changed by</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltByProduct(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_MFNO = null, 
			int? m3_OPNO = null, 
			int? m3_MSEQ = null, 
			decimal? m3_WOSQ = null, 
			string m3_MTNO = null, 
			DateTime? m3_RPDT = null, 
			int? m3_RPTM = null, 
			DateTime? m3_TRDT = null, 
			int? m3_TRTM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltByProduct",
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
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (m3_WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3_WOSQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MTNO))
				request.WithQueryParameter("MTNO", m3_MTNO.Trim());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());
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
		/// Name RptByProduct
		/// Description Manufacturing Order. Report by-product
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_MFNO">Manufacturing order number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_WOSQ">Reporting number</param>
		/// <param name="m3_MTNO">Component number</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TRTM">Transaction time</param>
		/// <param name="m3_PRDT">Priority date</param>
		/// <param name="m3_RPQA">Reported quantity in alternative unit</param>
		/// <param name="m3_PEUN">Product engineering U/M</param>
		/// <param name="m3_REND">Manual completion flag</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_STAS">Status - balance ID</param>
		/// <param name="m3_POCY">Normal potency</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_TRPR">Inventory accounting price</param>
		/// <param name="m3_TRPC">Inventory accounting price quantity</param>
		/// <param name="m3_CHID">Changed by</param>
		/// <param name="m3_DSP1">Warning indicator 1</param>
		/// <param name="m3_DSP2">Warning indicator 2</param>
		/// <param name="m3_DSP3">Warning indicator 3</param>
		/// <param name="m3_DSP6">Warning indicator 6</param>
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
		/// <param name="m3_EXPI">Expiration date</param>
		/// <param name="m3_HVDT">Harvested date</param>
		/// <param name="m3_PAC2">Packaging</param>
		/// <param name="m3_PACT">Packaging (Included in)</param>
		/// <param name="m3_PAII">Included in package number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RptByProduct(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_MFNO = null, 
			int? m3_OPNO = null, 
			int? m3_MSEQ = null, 
			decimal? m3_WOSQ = null, 
			string m3_MTNO = null, 
			DateTime? m3_RPDT = null, 
			int? m3_RPTM = null, 
			DateTime? m3_TRDT = null, 
			int? m3_TRTM = null, 
			DateTime? m3_PRDT = null, 
			decimal? m3_RPQA = null, 
			string m3_PEUN = null, 
			int? m3_REND = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			string m3_STAS = null, 
			int? m3_POCY = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			decimal? m3_CAWE = null, 
			decimal? m3_TRPR = null, 
			int? m3_TRPC = null, 
			string m3_CHID = null, 
			int? m3_DSP1 = null, 
			int? m3_DSP2 = null, 
			int? m3_DSP3 = null, 
			int? m3_DSP6 = null, 
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
			DateTime? m3_EXPI = null, 
			DateTime? m3_HVDT = null, 
			string m3_PAC2 = null, 
			string m3_PACT = null, 
			string m3_PAII = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RptByProduct",
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
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (m3_WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3_WOSQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MTNO))
				request.WithQueryParameter("MTNO", m3_MTNO.Trim());
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
			if (m3_RPQA.HasValue)
				request.WithQueryParameter("RPQA", m3_RPQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PEUN))
				request.WithQueryParameter("PEUN", m3_PEUN.Trim());
			if (m3_REND.HasValue)
				request.WithQueryParameter("REND", m3_REND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAS))
				request.WithQueryParameter("STAS", m3_STAS.Trim());
			if (m3_POCY.HasValue)
				request.WithQueryParameter("POCY", m3_POCY.Value.ToString());
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
			if (m3_DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3_DSP1.Value.ToString());
			if (m3_DSP2.HasValue)
				request.WithQueryParameter("DSP2", m3_DSP2.Value.ToString());
			if (m3_DSP3.HasValue)
				request.WithQueryParameter("DSP3", m3_DSP3.Value.ToString());
			if (m3_DSP6.HasValue)
				request.WithQueryParameter("DSP6", m3_DSP6.Value.ToString());
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
			if (m3_EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3_EXPI.Value.ToM3String());
			if (m3_HVDT.HasValue)
				request.WithQueryParameter("HVDT", m3_HVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PAC2))
				request.WithQueryParameter("PAC2", m3_PAC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAII))
				request.WithQueryParameter("PAII", m3_PAII.Trim());

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
