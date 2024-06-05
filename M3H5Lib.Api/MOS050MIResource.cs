/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name RptReceipt
		/// Description Report receipt
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3MWNO">Maintenance order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WOSQ">Reporting number</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3RTM1">Reporting time</param>
		/// <param name="m3TRDT">Transaction date (not used)</param>
		/// <param name="m3TRTM">Transaction time (not used)</param>
		/// <param name="m3PRDT">Priority date</param>
		/// <param name="m3POCY">Normal potency</param>
		/// <param name="m3RPQA">Reported quantity in alternative unit</param>
		/// <param name="m3MAUN">Manufacturing U/M</param>
		/// <param name="m3STAS">Status - balance ID</param>
		/// <param name="m3REND">Manual completion flag</param>
		/// <param name="m3TWLO">To warehouse</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3TRPR">Inventory accounting price</param>
		/// <param name="m3TRPC">Inventory accounting price quantity</param>
		/// <param name="m3CHID">Changed by</param>
		/// <param name="m3MOSC">Scrap</param>
		/// <param name="m3FWSL">From location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RptReceipt(
			string m3FACI, 
			string m3PRNO, 
			string m3MWNO, 
			int? m3CONO = null, 
			decimal? m3WOSQ = null, 
			DateTime? m3RPDT = null, 
			int? m3RTM1 = null, 
			DateTime? m3TRDT = null, 
			int? m3TRTM = null, 
			DateTime? m3PRDT = null, 
			int? m3POCY = null, 
			decimal? m3RPQA = null, 
			string m3MAUN = null, 
			string m3STAS = null, 
			int? m3REND = null, 
			string m3TWLO = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			string m3BREM = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			decimal? m3TRPR = null, 
			int? m3TRPC = null, 
			string m3CHID = null, 
			int? m3MOSC = null, 
			string m3FWSL = null, 
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

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("MWNO", m3MWNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3WOSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3RTM1.HasValue)
				request.WithQueryParameter("RTM1", m3RTM1.Value.ToString(CultureInfo.CurrentCulture));
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
			if (!string.IsNullOrWhiteSpace(m3TWLO))
				request.WithQueryParameter("TWLO", m3TWLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3TRPR.HasValue)
				request.WithQueryParameter("TRPR", m3TRPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRPC.HasValue)
				request.WithQueryParameter("TRPC", m3TRPC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());
			if (m3MOSC.HasValue)
				request.WithQueryParameter("MOSC", m3MOSC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FWSL))
				request.WithQueryParameter("FWSL", m3FWSL.Trim());

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
