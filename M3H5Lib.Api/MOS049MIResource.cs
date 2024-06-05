/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MOS049MI;
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
	/// Name: MOS049MI
	/// Component Name: OrderlessReporting
	/// Description: Orderless reporting WO interface
	/// Version Release: 5e90
	///</summary>
	public partial class MOS049MIResource : M3BaseResourceEndpoint
	{
		public MOS049MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS049MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name PutAway
		/// Description Put Away and Withdrawal
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_STRT">Structure type (Required)</param>
		/// <param name="m3_ORQT">Order quantity (Required)</param>
		/// <param name="m3_CONO">Company Number</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_PAC2">Packaging</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_POCY">Potency</param>
		/// <param name="m3_MAUN">Alternate unit of measure</param>
		/// <param name="m3_STAS">Balance status</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_SHFC">Shift</param>
		/// <param name="m3_PAII">Included in package number</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_TDT2">Transaction date</param>
		/// <param name="m3_LIRR">LI request rule</param>
		/// <param name="m3_HVDT">Harvested date</param>
		/// <param name="m3_EXPI">Expiration date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<PutAwayResponse></returns>
		/// <exception cref="M3Exception<PutAwayResponse>"></exception>
		public async Task<M3Response<PutAwayResponse>> PutAway(
			string m3_WHLO, 
			string m3_PRNO, 
			string m3_STRT, 
			string m3_ORQT, 
			int? m3_CONO = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			string m3_PAC2 = null, 
			string m3_CAWE = null, 
			int? m3_POCY = null, 
			string m3_MAUN = null, 
			string m3_STAS = null, 
			DateTime? m3_TRDT = null, 
			string m3_SHFC = null, 
			string m3_PAII = null, 
			string m3_PACT = null, 
			DateTime? m3_TDT2 = null, 
			int? m3_LIRR = null, 
			DateTime? m3_HVDT = null, 
			DateTime? m3_EXPI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PutAway",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_STRT))
				throw new ArgumentNullException("m3_STRT");
			if (string.IsNullOrWhiteSpace(m3_ORQT))
				throw new ArgumentNullException("m3_ORQT");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("STRT", m3_STRT.Trim())
				.WithQueryParameter("ORQT", m3_ORQT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAC2))
				request.WithQueryParameter("PAC2", m3_PAC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAWE))
				request.WithQueryParameter("CAWE", m3_CAWE.Trim());
			if (m3_POCY.HasValue)
				request.WithQueryParameter("POCY", m3_POCY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MAUN))
				request.WithQueryParameter("MAUN", m3_MAUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAS))
				request.WithQueryParameter("STAS", m3_STAS.Trim());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_SHFC))
				request.WithQueryParameter("SHFC", m3_SHFC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAII))
				request.WithQueryParameter("PAII", m3_PAII.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (m3_TDT2.HasValue)
				request.WithQueryParameter("TDT2", m3_TDT2.Value.ToM3String());
			if (m3_LIRR.HasValue)
				request.WithQueryParameter("LIRR", m3_LIRR.Value.ToString());
			if (m3_HVDT.HasValue)
				request.WithQueryParameter("HVDT", m3_HVDT.Value.ToM3String());
			if (m3_EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3_EXPI.Value.ToM3String());

			// Execute the request
			var result = await Execute<PutAwayResponse>(
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
		/// Name RepEndProd
		/// Description Report end-items in orderless reporting interface
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_ENDP">End product (Required)</param>
		/// <param name="m3_STRT">Product structure type (Required)</param>
		/// <param name="m3_STAS">Status - balance ID (Required)</param>
		/// <param name="m3_ORQT">Ordered quantity - basic U/M (Required)</param>
		/// <param name="m3_MAQA">Manufactured quantity (Required)</param>
		/// <param name="m3_MAUN">Manufacturing U/M (Required)</param>
		/// <param name="m3_EPCA">End product calc Y/N (Required)</param>
		/// <param name="m3_CWUN">Catch weight unit of measure</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_PAC2">Packaging</param>
		/// <param name="m3_POCY">Normal potency</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_SHFC">Shift</param>
		/// <param name="m3_PAII">Included in package number</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_TDT2">Transaction date</param>
		/// <param name="m3_PRMF">Process manufacturing order number</param>
		/// <param name="m3_HVDT">Harvested date</param>
		/// <param name="m3_EXPI">Expiration date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RepEndProd(
			string m3_WHLO, 
			string m3_PRNO, 
			string m3_ENDP, 
			string m3_STRT, 
			string m3_STAS, 
			decimal m3_ORQT, 
			decimal m3_MAQA, 
			string m3_MAUN, 
			string m3_EPCA, 
			string m3_CWUN = null, 
			decimal? m3_CAWE = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			string m3_PAC2 = null, 
			int? m3_POCY = null, 
			DateTime? m3_TRDT = null, 
			string m3_SHFC = null, 
			string m3_PAII = null, 
			string m3_PACT = null, 
			DateTime? m3_TDT2 = null, 
			string m3_PRMF = null, 
			DateTime? m3_HVDT = null, 
			DateTime? m3_EXPI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RepEndProd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_ENDP))
				throw new ArgumentNullException("m3_ENDP");
			if (string.IsNullOrWhiteSpace(m3_STRT))
				throw new ArgumentNullException("m3_STRT");
			if (string.IsNullOrWhiteSpace(m3_STAS))
				throw new ArgumentNullException("m3_STAS");
			if (string.IsNullOrWhiteSpace(m3_MAUN))
				throw new ArgumentNullException("m3_MAUN");
			if (string.IsNullOrWhiteSpace(m3_EPCA))
				throw new ArgumentNullException("m3_EPCA");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("ENDP", m3_ENDP.Trim())
				.WithQueryParameter("STRT", m3_STRT.Trim())
				.WithQueryParameter("STAS", m3_STAS.Trim())
				.WithQueryParameter("ORQT", m3_ORQT.ToString())
				.WithQueryParameter("MAQA", m3_MAQA.ToString())
				.WithQueryParameter("MAUN", m3_MAUN.Trim())
				.WithQueryParameter("EPCA", m3_EPCA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CWUN))
				request.WithQueryParameter("CWUN", m3_CWUN.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAC2))
				request.WithQueryParameter("PAC2", m3_PAC2.Trim());
			if (m3_POCY.HasValue)
				request.WithQueryParameter("POCY", m3_POCY.Value.ToString());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_SHFC))
				request.WithQueryParameter("SHFC", m3_SHFC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAII))
				request.WithQueryParameter("PAII", m3_PAII.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (m3_TDT2.HasValue)
				request.WithQueryParameter("TDT2", m3_TDT2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PRMF))
				request.WithQueryParameter("PRMF", m3_PRMF.Trim());
			if (m3_HVDT.HasValue)
				request.WithQueryParameter("HVDT", m3_HVDT.Value.ToM3String());
			if (m3_EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3_EXPI.Value.ToM3String());

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
