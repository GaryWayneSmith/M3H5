/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.OIS340MI;
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
	/// Name: OIS340MI
	/// Component Name: Supply Model simulation
	/// Description: Api: Supply Model simulation
	/// Version Release: 14.x
	///</summary>
	public partial class OIS340MIResource : M3BaseResourceEndpoint
	{
		public OIS340MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS340MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstSupplSummary
		/// Description Lst suppl summary
		/// Version Release: 
		/// </summary>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3POPN">Alias number (Required)</param>
		/// <param name="m3ORQA">Ordered quantity - alternate U/M (Required)</param>
		/// <param name="m3ORTP">Customer order type</param>
		/// <param name="m3DWDZ">Requested delivery date</param>
		/// <param name="m3DWHZ">Requested delivery time</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3DECU">Delivery customer</param>
		/// <param name="m3SPLM">Supply model</param>
		/// <param name="m3FTSC">Search for supply options</param>
		/// <param name="m3BCKO">Backorder</param>
		/// <param name="m3PADL">Partial delivery</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3LTYP">Line type</param>
		/// <param name="m3ALUN">Alternate U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSupplSummaryResponse></returns>
		/// <exception cref="M3Exception<LstSupplSummaryResponse>"></exception>
		public async Task<M3Response<LstSupplSummaryResponse>> LstSupplSummary(
			string m3CUNO, 
			string m3FACI, 
			string m3POPN, 
			decimal m3ORQA, 
			string m3ORTP = null, 
			DateTime? m3DWDZ = null, 
			int? m3DWHZ = null, 
			string m3ADID = null, 
			string m3DECU = null, 
			string m3SPLM = null, 
			int? m3FTSC = null, 
			int? m3BCKO = null, 
			int? m3PADL = null, 
			string m3WHLO = null, 
			string m3LTYP = null, 
			string m3ALUN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstSupplSummary",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3POPN))
				throw new ArgumentNullException(nameof(m3POPN));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("POPN", m3POPN.Trim())
				.WithQueryParameter("ORQA", m3ORQA.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ORTP))
				request.WithQueryParameter("ORTP", m3ORTP.Trim());
			if (m3DWDZ.HasValue)
				request.WithQueryParameter("DWDZ", m3DWDZ.Value.ToM3String());
			if (m3DWHZ.HasValue)
				request.WithQueryParameter("DWHZ", m3DWHZ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3DECU))
				request.WithQueryParameter("DECU", m3DECU.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPLM))
				request.WithQueryParameter("SPLM", m3SPLM.Trim());
			if (m3FTSC.HasValue)
				request.WithQueryParameter("FTSC", m3FTSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCKO.HasValue)
				request.WithQueryParameter("BCKO", m3BCKO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PADL.HasValue)
				request.WithQueryParameter("PADL", m3PADL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3LTYP))
				request.WithQueryParameter("LTYP", m3LTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALUN))
				request.WithQueryParameter("ALUN", m3ALUN.Trim());

			// Execute the request
			var result = await Execute<LstSupplSummaryResponse>(
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
