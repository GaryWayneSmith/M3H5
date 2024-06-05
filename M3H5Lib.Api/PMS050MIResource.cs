/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ConfirmAll
		/// Description Confirm All
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3MFNO">Manufacturing order number</param>
		/// <param name="m3WOSQ">Reporting number</param>
		/// <param name="m3SCHN">Schedule number</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3LIRR">LI request rule</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ConfirmAll(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3MFNO = null, 
			decimal? m3WOSQ = null, 
			decimal? m3SCHN = null, 
			DateTime? m3RPDT = null, 
			int? m3RPTM = null, 
			int? m3LIRR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ConfirmAll",
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
			if (m3WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3WOSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3SCHN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LIRR.HasValue)
				request.WithQueryParameter("LIRR", m3LIRR.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name RptReceipt
		/// Description Report receipt
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3MFNO">Manufacturing order number</param>
		/// <param name="m3WOSQ">Reporting number</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3TRTM">Transaction time</param>
		/// <param name="m3PRDT">Priority date</param>
		/// <param name="m3POCY">Potency</param>
		/// <param name="m3RPQA">Reported quantity in alternative unit</param>
		/// <param name="m3MAUN">Manufacturing U/M</param>
		/// <param name="m3STAS">Status - balance ID</param>
		/// <param name="m3REND">Manual completion flag</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3PAC2">Packaging</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3TRPR">Inventory accounting price</param>
		/// <param name="m3TRPC">Inventory accounting price quantity</param>
		/// <param name="m3CHID">Changed by</param>
		/// <param name="m3DSP1">Warning indicator 1</param>
		/// <param name="m3DSP2">Warning indicator 2</param>
		/// <param name="m3DSP3">Warning indicator 3</param>
		/// <param name="m3DSP4">Warning indicator 4</param>
		/// <param name="m3DSP5">Warning indicator 5</param>
		/// <param name="m3DSP6">Warning indicator 6</param>
		/// <param name="m3DSP7">Warning indicator 7</param>
		/// <param name="m3DSP8">Warning indicator 8</param>
		/// <param name="m3PLNO">Production lot number</param>
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
		/// <param name="m3PAII">Included in package number</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3LIRR">LI request rule</param>
		/// <param name="m3EXPI">Expiration date</param>
		/// <param name="m3HVDT">Harvested date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<RptReceiptResponse></returns>
		/// <exception cref="M3Exception<RptReceiptResponse>"></exception>
		public async Task<M3Response<RptReceiptResponse>> RptReceipt(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3MFNO = null, 
			decimal? m3WOSQ = null, 
			DateTime? m3RPDT = null, 
			int? m3RPTM = null, 
			DateTime? m3TRDT = null, 
			int? m3TRTM = null, 
			DateTime? m3PRDT = null, 
			int? m3POCY = null, 
			decimal? m3RPQA = null, 
			string m3MAUN = null, 
			string m3STAS = null, 
			int? m3REND = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			string m3PAC2 = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			decimal? m3CAWE = null, 
			decimal? m3TRPR = null, 
			int? m3TRPC = null, 
			string m3CHID = null, 
			string m3DSP1 = null, 
			string m3DSP2 = null, 
			string m3DSP3 = null, 
			string m3DSP4 = null, 
			string m3DSP5 = null, 
			string m3DSP6 = null, 
			string m3DSP7 = null, 
			string m3DSP8 = null, 
			long? m3PLNO = null, 
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
			string m3PAII = null, 
			string m3PACT = null, 
			int? m3LIRR = null, 
			DateTime? m3EXPI = null, 
			DateTime? m3HVDT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/RptReceipt",
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
			if (m3WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3WOSQ.Value.ToString(CultureInfo.CurrentCulture));
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
			if (m3POCY.HasValue)
				request.WithQueryParameter("POCY", m3POCY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPQA.HasValue)
				request.WithQueryParameter("RPQA", m3RPQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MAUN))
				request.WithQueryParameter("MAUN", m3MAUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAS))
				request.WithQueryParameter("STAS", m3STAS.Trim());
			if (m3REND.HasValue)
				request.WithQueryParameter("REND", m3REND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAC2))
				request.WithQueryParameter("PAC2", m3PAC2.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3DSP1))
				request.WithQueryParameter("DSP1", m3DSP1.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSP2))
				request.WithQueryParameter("DSP2", m3DSP2.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSP3))
				request.WithQueryParameter("DSP3", m3DSP3.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSP4))
				request.WithQueryParameter("DSP4", m3DSP4.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSP5))
				request.WithQueryParameter("DSP5", m3DSP5.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSP6))
				request.WithQueryParameter("DSP6", m3DSP6.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSP7))
				request.WithQueryParameter("DSP7", m3DSP7.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSP8))
				request.WithQueryParameter("DSP8", m3DSP8.Trim());
			if (m3PLNO.HasValue)
				request.WithQueryParameter("PLNO", m3PLNO.Value.ToString(CultureInfo.CurrentCulture));
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
			if (!string.IsNullOrWhiteSpace(m3PAII))
				request.WithQueryParameter("PAII", m3PAII.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (m3LIRR.HasValue)
				request.WithQueryParameter("LIRR", m3LIRR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3EXPI.Value.ToM3String());
			if (m3HVDT.HasValue)
				request.WithQueryParameter("HVDT", m3HVDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<RptReceiptResponse>(
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
		/// Name UpdProcess
		/// Description Update Process
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MAQA">Manufactured quantity</param>
		/// <param name="m3REND">Manual completion flag</param>
		/// <param name="m3DSP1">Warning indicator 1</param>
		/// <param name="m3DSP2">Warning indicator 2</param>
		/// <param name="m3DSP3">Warning indicator 3</param>
		/// <param name="m3DSP4">Warning indicator 4</param>
		/// <param name="m3DSP5">Warning indicator 5</param>
		/// <param name="m3DSP6">Warning indicator 6</param>
		/// <param name="m3DSP7">Warning indicator 7</param>
		/// <param name="m3DSP8">Warning indicator 8</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdProcess(
			string m3FACI, 
			string m3PRNO, 
			string m3MFNO, 
			int? m3CONO = null, 
			decimal? m3MAQA = null, 
			int? m3REND = null, 
			string m3DSP1 = null, 
			string m3DSP2 = null, 
			string m3DSP3 = null, 
			string m3DSP4 = null, 
			string m3DSP5 = null, 
			string m3DSP6 = null, 
			string m3DSP7 = null, 
			string m3DSP8 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdProcess",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3MFNO))
				throw new ArgumentNullException(nameof(m3MFNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("MFNO", m3MFNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MAQA.HasValue)
				request.WithQueryParameter("MAQA", m3MAQA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REND.HasValue)
				request.WithQueryParameter("REND", m3REND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DSP1))
				request.WithQueryParameter("DSP1", m3DSP1.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSP2))
				request.WithQueryParameter("DSP2", m3DSP2.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSP3))
				request.WithQueryParameter("DSP3", m3DSP3.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSP4))
				request.WithQueryParameter("DSP4", m3DSP4.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSP5))
				request.WithQueryParameter("DSP5", m3DSP5.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSP6))
				request.WithQueryParameter("DSP6", m3DSP6.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSP7))
				request.WithQueryParameter("DSP7", m3DSP7.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSP8))
				request.WithQueryParameter("DSP8", m3DSP8.Trim());

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
