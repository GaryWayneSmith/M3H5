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
	/// Name: MOS050MI
	/// Component Name: MaintenanceOrderReceipt
	/// Description: Maintenance order receipt interface
	/// Version Release: 5e90
	///</summary>
	public partial class MOS050MIResource : M3BaseResourceEndpoint
	{
		public MOS050MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS050MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name RptReceipt
		/// Description Report receipt
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_MWNO">Maintenance order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WOSQ">Reporting number</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_RTM1">Reporting time</param>
		/// <param name="m3_TRDT">Transaction date (not used)</param>
		/// <param name="m3_TRTM">Transaction time (not used)</param>
		/// <param name="m3_PRDT">Priority date</param>
		/// <param name="m3_POCY">Normal potency</param>
		/// <param name="m3_RPQA">Reported quantity in alternative unit</param>
		/// <param name="m3_MAUN">Manufacturing U/M</param>
		/// <param name="m3_STAS">Status - balance ID</param>
		/// <param name="m3_REND">Manual completion flag</param>
		/// <param name="m3_TWLO">To warehouse</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_TRPR">Inventory accounting price</param>
		/// <param name="m3_TRPC">Inventory accounting price quantity</param>
		/// <param name="m3_CHID">Changed by</param>
		/// <param name="m3_MOSC">Scrap</param>
		/// <param name="m3_FWSL">From location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RptReceipt(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_MWNO, 
			int? m3_CONO = null, 
			decimal? m3_WOSQ = null, 
			DateTime? m3_RPDT = null, 
			int? m3_RTM1 = null, 
			DateTime? m3_TRDT = null, 
			int? m3_TRTM = null, 
			DateTime? m3_PRDT = null, 
			int? m3_POCY = null, 
			decimal? m3_RPQA = null, 
			string m3_MAUN = null, 
			string m3_STAS = null, 
			int? m3_REND = null, 
			string m3_TWLO = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			string m3_BREM = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			decimal? m3_TRPR = null, 
			int? m3_TRPC = null, 
			string m3_CHID = null, 
			int? m3_MOSC = null, 
			string m3_FWSL = null, 
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

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("MWNO", m3_MWNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3_WOSQ.Value.ToString());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_RTM1.HasValue)
				request.WithQueryParameter("RTM1", m3_RTM1.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_TWLO))
				request.WithQueryParameter("TWLO", m3_TWLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (m3_TRPR.HasValue)
				request.WithQueryParameter("TRPR", m3_TRPR.Value.ToString());
			if (m3_TRPC.HasValue)
				request.WithQueryParameter("TRPC", m3_TRPC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());
			if (m3_MOSC.HasValue)
				request.WithQueryParameter("MOSC", m3_MOSC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FWSL))
				request.WithQueryParameter("FWSL", m3_FWSL.Trim());

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
