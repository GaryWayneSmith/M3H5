/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3MFNO">Manufacturing order number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3WOSQ">Reporting number</param>
		/// <param name="m3MTNO">Component number</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3TRTM">Transaction time</param>
		/// <param name="m3CHID">Changed by</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Confirm(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3MFNO = null, 
			int? m3OPNO = null, 
			int? m3MSEQ = null, 
			decimal? m3WOSQ = null, 
			string m3MTNO = null, 
			DateTime? m3RPDT = null, 
			int? m3RPTM = null, 
			DateTime? m3TRDT = null, 
			int? m3TRTM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Confirm",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MFNO))
				request.WithQueryParameter("MFNO", m3MFNO.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3WOSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MTNO))
				request.WithQueryParameter("MTNO", m3MTNO.Trim());
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (m3TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3TRTM.Value.ToString(CultureInfo.CurrentCulture));
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
		/// Name DltByProduct
		/// Description Manufacturing Order. Delete by-product
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3MFNO">Manufacturing order number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3WOSQ">Reporting number</param>
		/// <param name="m3MTNO">Component number</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3TRTM">Transaction time</param>
		/// <param name="m3CHID">Changed by</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltByProduct(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3MFNO = null, 
			int? m3OPNO = null, 
			int? m3MSEQ = null, 
			decimal? m3WOSQ = null, 
			string m3MTNO = null, 
			DateTime? m3RPDT = null, 
			int? m3RPTM = null, 
			DateTime? m3TRDT = null, 
			int? m3TRTM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltByProduct",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MFNO))
				request.WithQueryParameter("MFNO", m3MFNO.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3WOSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MTNO))
				request.WithQueryParameter("MTNO", m3MTNO.Trim());
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (m3TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3TRTM.Value.ToString(CultureInfo.CurrentCulture));
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
		/// Name RptByProduct
		/// Description Manufacturing Order. Report by-product
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3MFNO">Manufacturing order number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3WOSQ">Reporting number</param>
		/// <param name="m3MTNO">Component number</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3TRTM">Transaction time</param>
		/// <param name="m3PRDT">Priority date</param>
		/// <param name="m3RPQA">Reported quantity in alternative unit</param>
		/// <param name="m3PEUN">Product engineering U/M</param>
		/// <param name="m3REND">Manual completion flag</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3STAS">Status - balance ID</param>
		/// <param name="m3POCY">Normal potency</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3TRPR">Inventory accounting price</param>
		/// <param name="m3TRPC">Inventory accounting price quantity</param>
		/// <param name="m3CHID">Changed by</param>
		/// <param name="m3DSP1">Warning indicator 1</param>
		/// <param name="m3DSP2">Warning indicator 2</param>
		/// <param name="m3DSP3">Warning indicator 3</param>
		/// <param name="m3DSP6">Warning indicator 6</param>
		/// <param name="m3AT01">Attribute id 1</param>
		/// <param name="m3AV01">Attribute value 1</param>
		/// <param name="m3AT02">Attribute id 2</param>
		/// <param name="m3AV02">Attribute value 2</param>
		/// <param name="m3AT03">Attribute id 3</param>
		/// <param name="m3AV03">Attribute value 3</param>
		/// <param name="m3AT04">Attribute id 4</param>
		/// <param name="m3AV04">Attribute value 4</param>
		/// <param name="m3AT05">Attribute id 5</param>
		/// <param name="m3AV05">Attribute value 5</param>
		/// <param name="m3AT06">Attribute id 6</param>
		/// <param name="m3AV06">Attribute value 6</param>
		/// <param name="m3AT07">Attribute id 7</param>
		/// <param name="m3AV07">Attribute value 7</param>
		/// <param name="m3AT08">Attribute id 8</param>
		/// <param name="m3AV08">Attribute value 8</param>
		/// <param name="m3AT09">Attribute id 9</param>
		/// <param name="m3AV09">Attribute value 9</param>
		/// <param name="m3AT10">Attribute id 10</param>
		/// <param name="m3AV10">Attribute value 10</param>
		/// <param name="m3EXPI">Expiration date</param>
		/// <param name="m3HVDT">Harvested date</param>
		/// <param name="m3PAC2">Packaging</param>
		/// <param name="m3PACT">Packaging (Included in)</param>
		/// <param name="m3PAII">Included in package number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RptByProduct(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3MFNO = null, 
			int? m3OPNO = null, 
			int? m3MSEQ = null, 
			decimal? m3WOSQ = null, 
			string m3MTNO = null, 
			DateTime? m3RPDT = null, 
			int? m3RPTM = null, 
			DateTime? m3TRDT = null, 
			int? m3TRTM = null, 
			DateTime? m3PRDT = null, 
			decimal? m3RPQA = null, 
			string m3PEUN = null, 
			int? m3REND = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			string m3STAS = null, 
			int? m3POCY = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			decimal? m3CAWE = null, 
			decimal? m3TRPR = null, 
			int? m3TRPC = null, 
			string m3CHID = null, 
			int? m3DSP1 = null, 
			int? m3DSP2 = null, 
			int? m3DSP3 = null, 
			int? m3DSP6 = null, 
			string m3AT01 = null, 
			string m3AV01 = null, 
			string m3AT02 = null, 
			string m3AV02 = null, 
			string m3AT03 = null, 
			string m3AV03 = null, 
			string m3AT04 = null, 
			string m3AV04 = null, 
			string m3AT05 = null, 
			string m3AV05 = null, 
			string m3AT06 = null, 
			string m3AV06 = null, 
			string m3AT07 = null, 
			string m3AV07 = null, 
			string m3AT08 = null, 
			string m3AV08 = null, 
			string m3AT09 = null, 
			string m3AV09 = null, 
			string m3AT10 = null, 
			string m3AV10 = null, 
			DateTime? m3EXPI = null, 
			DateTime? m3HVDT = null, 
			string m3PAC2 = null, 
			string m3PACT = null, 
			string m3PAII = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MFNO))
				request.WithQueryParameter("MFNO", m3MFNO.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3WOSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MTNO))
				request.WithQueryParameter("MTNO", m3MTNO.Trim());
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (m3TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3TRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3PRDT.Value.ToM3String());
			if (m3RPQA.HasValue)
				request.WithQueryParameter("RPQA", m3RPQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PEUN))
				request.WithQueryParameter("PEUN", m3PEUN.Trim());
			if (m3REND.HasValue)
				request.WithQueryParameter("REND", m3REND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAS))
				request.WithQueryParameter("STAS", m3STAS.Trim());
			if (m3POCY.HasValue)
				request.WithQueryParameter("POCY", m3POCY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRPR.HasValue)
				request.WithQueryParameter("TRPR", m3TRPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRPC.HasValue)
				request.WithQueryParameter("TRPC", m3TRPC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());
			if (m3DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3DSP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP2.HasValue)
				request.WithQueryParameter("DSP2", m3DSP2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP3.HasValue)
				request.WithQueryParameter("DSP3", m3DSP3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP6.HasValue)
				request.WithQueryParameter("DSP6", m3DSP6.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AT01))
				request.WithQueryParameter("AT01", m3AT01.Trim());
			if (!string.IsNullOrWhiteSpace(m3AV01))
				request.WithQueryParameter("AV01", m3AV01.Trim());
			if (!string.IsNullOrWhiteSpace(m3AT02))
				request.WithQueryParameter("AT02", m3AT02.Trim());
			if (!string.IsNullOrWhiteSpace(m3AV02))
				request.WithQueryParameter("AV02", m3AV02.Trim());
			if (!string.IsNullOrWhiteSpace(m3AT03))
				request.WithQueryParameter("AT03", m3AT03.Trim());
			if (!string.IsNullOrWhiteSpace(m3AV03))
				request.WithQueryParameter("AV03", m3AV03.Trim());
			if (!string.IsNullOrWhiteSpace(m3AT04))
				request.WithQueryParameter("AT04", m3AT04.Trim());
			if (!string.IsNullOrWhiteSpace(m3AV04))
				request.WithQueryParameter("AV04", m3AV04.Trim());
			if (!string.IsNullOrWhiteSpace(m3AT05))
				request.WithQueryParameter("AT05", m3AT05.Trim());
			if (!string.IsNullOrWhiteSpace(m3AV05))
				request.WithQueryParameter("AV05", m3AV05.Trim());
			if (!string.IsNullOrWhiteSpace(m3AT06))
				request.WithQueryParameter("AT06", m3AT06.Trim());
			if (!string.IsNullOrWhiteSpace(m3AV06))
				request.WithQueryParameter("AV06", m3AV06.Trim());
			if (!string.IsNullOrWhiteSpace(m3AT07))
				request.WithQueryParameter("AT07", m3AT07.Trim());
			if (!string.IsNullOrWhiteSpace(m3AV07))
				request.WithQueryParameter("AV07", m3AV07.Trim());
			if (!string.IsNullOrWhiteSpace(m3AT08))
				request.WithQueryParameter("AT08", m3AT08.Trim());
			if (!string.IsNullOrWhiteSpace(m3AV08))
				request.WithQueryParameter("AV08", m3AV08.Trim());
			if (!string.IsNullOrWhiteSpace(m3AT09))
				request.WithQueryParameter("AT09", m3AT09.Trim());
			if (!string.IsNullOrWhiteSpace(m3AV09))
				request.WithQueryParameter("AV09", m3AV09.Trim());
			if (!string.IsNullOrWhiteSpace(m3AT10))
				request.WithQueryParameter("AT10", m3AT10.Trim());
			if (!string.IsNullOrWhiteSpace(m3AV10))
				request.WithQueryParameter("AV10", m3AV10.Trim());
			if (m3EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3EXPI.Value.ToM3String());
			if (m3HVDT.HasValue)
				request.WithQueryParameter("HVDT", m3HVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PAC2))
				request.WithQueryParameter("PAC2", m3PAC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAII))
				request.WithQueryParameter("PAII", m3PAII.Trim());

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
