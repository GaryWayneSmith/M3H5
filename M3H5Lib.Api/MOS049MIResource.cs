/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name PutAway
		/// Description Put Away and Withdrawal
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3STRT">Structure type (Required)</param>
		/// <param name="m3ORQT">Order quantity (Required)</param>
		/// <param name="m3CONO">Company Number</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3PAC2">Packaging</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3POCY">Potency</param>
		/// <param name="m3MAUN">Alternate unit of measure</param>
		/// <param name="m3STAS">Balance status</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3SHFC">Shift</param>
		/// <param name="m3PAII">Included in package number</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3TDT2">Transaction date</param>
		/// <param name="m3LIRR">LI request rule</param>
		/// <param name="m3HVDT">Harvested date</param>
		/// <param name="m3EXPI">Expiration date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<PutAwayResponse></returns>
		/// <exception cref="M3Exception<PutAwayResponse>"></exception>
		public async Task<M3Response<PutAwayResponse>> PutAway(
			string m3WHLO, 
			string m3PRNO, 
			string m3STRT, 
			string m3ORQT, 
			int? m3CONO = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			string m3PAC2 = null, 
			string m3CAWE = null, 
			int? m3POCY = null, 
			string m3MAUN = null, 
			string m3STAS = null, 
			DateTime? m3TRDT = null, 
			string m3SHFC = null, 
			string m3PAII = null, 
			string m3PACT = null, 
			DateTime? m3TDT2 = null, 
			int? m3LIRR = null, 
			DateTime? m3HVDT = null, 
			DateTime? m3EXPI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/PutAway",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3STRT))
				throw new ArgumentNullException(nameof(m3STRT));
			if (string.IsNullOrWhiteSpace(m3ORQT))
				throw new ArgumentNullException(nameof(m3ORQT));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("STRT", m3STRT.Trim())
				.WithQueryParameter("ORQT", m3ORQT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAC2))
				request.WithQueryParameter("PAC2", m3PAC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAWE))
				request.WithQueryParameter("CAWE", m3CAWE.Trim());
			if (m3POCY.HasValue)
				request.WithQueryParameter("POCY", m3POCY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MAUN))
				request.WithQueryParameter("MAUN", m3MAUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAS))
				request.WithQueryParameter("STAS", m3STAS.Trim());
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3SHFC))
				request.WithQueryParameter("SHFC", m3SHFC.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAII))
				request.WithQueryParameter("PAII", m3PAII.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (m3TDT2.HasValue)
				request.WithQueryParameter("TDT2", m3TDT2.Value.ToM3String());
			if (m3LIRR.HasValue)
				request.WithQueryParameter("LIRR", m3LIRR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HVDT.HasValue)
				request.WithQueryParameter("HVDT", m3HVDT.Value.ToM3String());
			if (m3EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3EXPI.Value.ToM3String());

			// Execute the request
			var result = await Execute<PutAwayResponse>(
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
		/// Name RepEndProd
		/// Description Report end-items in orderless reporting interface
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3ENDP">End product (Required)</param>
		/// <param name="m3STRT">Product structure type (Required)</param>
		/// <param name="m3STAS">Status - balance ID (Required)</param>
		/// <param name="m3ORQT">Ordered quantity - basic U/M (Required)</param>
		/// <param name="m3MAQA">Manufactured quantity (Required)</param>
		/// <param name="m3MAUN">Manufacturing U/M (Required)</param>
		/// <param name="m3EPCA">End product calc Y/N (Required)</param>
		/// <param name="m3CWUN">Catch weight unit of measure</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3PAC2">Packaging</param>
		/// <param name="m3POCY">Normal potency</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3SHFC">Shift</param>
		/// <param name="m3PAII">Included in package number</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3TDT2">Transaction date</param>
		/// <param name="m3PRMF">Process manufacturing order number</param>
		/// <param name="m3HVDT">Harvested date</param>
		/// <param name="m3EXPI">Expiration date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RepEndProd(
			string m3WHLO, 
			string m3PRNO, 
			string m3ENDP, 
			string m3STRT, 
			string m3STAS, 
			decimal m3ORQT, 
			decimal m3MAQA, 
			string m3MAUN, 
			string m3EPCA, 
			string m3CWUN = null, 
			decimal? m3CAWE = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			string m3PAC2 = null, 
			int? m3POCY = null, 
			DateTime? m3TRDT = null, 
			string m3SHFC = null, 
			string m3PAII = null, 
			string m3PACT = null, 
			DateTime? m3TDT2 = null, 
			string m3PRMF = null, 
			DateTime? m3HVDT = null, 
			DateTime? m3EXPI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/RepEndProd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3ENDP))
				throw new ArgumentNullException(nameof(m3ENDP));
			if (string.IsNullOrWhiteSpace(m3STRT))
				throw new ArgumentNullException(nameof(m3STRT));
			if (string.IsNullOrWhiteSpace(m3STAS))
				throw new ArgumentNullException(nameof(m3STAS));
			if (string.IsNullOrWhiteSpace(m3MAUN))
				throw new ArgumentNullException(nameof(m3MAUN));
			if (string.IsNullOrWhiteSpace(m3EPCA))
				throw new ArgumentNullException(nameof(m3EPCA));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("ENDP", m3ENDP.Trim())
				.WithQueryParameter("STRT", m3STRT.Trim())
				.WithQueryParameter("STAS", m3STAS.Trim())
				.WithQueryParameter("ORQT", m3ORQT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("MAQA", m3MAQA.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("MAUN", m3MAUN.Trim())
				.WithQueryParameter("EPCA", m3EPCA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CWUN))
				request.WithQueryParameter("CWUN", m3CWUN.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAC2))
				request.WithQueryParameter("PAC2", m3PAC2.Trim());
			if (m3POCY.HasValue)
				request.WithQueryParameter("POCY", m3POCY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3SHFC))
				request.WithQueryParameter("SHFC", m3SHFC.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAII))
				request.WithQueryParameter("PAII", m3PAII.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (m3TDT2.HasValue)
				request.WithQueryParameter("TDT2", m3TDT2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PRMF))
				request.WithQueryParameter("PRMF", m3PRMF.Trim());
			if (m3HVDT.HasValue)
				request.WithQueryParameter("HVDT", m3HVDT.Value.ToM3String());
			if (m3EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3EXPI.Value.ToM3String());

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
