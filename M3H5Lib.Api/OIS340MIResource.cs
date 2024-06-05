/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstSupplSummary
		/// Description Lst suppl summary
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CUNO">Customer (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_POPN">Alias number (Required)</param>
		/// <param name="m3_ORQA">Ordered quantity - alternate U/M (Required)</param>
		/// <param name="m3_ORTP">Customer order type</param>
		/// <param name="m3_DWDZ">Requested delivery date</param>
		/// <param name="m3_DWHZ">Requested delivery time</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_DECU">Delivery customer</param>
		/// <param name="m3_SPLM">Supply model</param>
		/// <param name="m3_FTSC">Search for supply options</param>
		/// <param name="m3_BCKO">Backorder</param>
		/// <param name="m3_PADL">Partial delivery</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_LTYP">Line type</param>
		/// <param name="m3_ALUN">Alternate U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSupplSummaryResponse></returns>
		/// <exception cref="M3Exception<LstSupplSummaryResponse>"></exception>
		public async Task<M3Response<LstSupplSummaryResponse>> LstSupplSummary(
			string m3_CUNO, 
			string m3_FACI, 
			string m3_POPN, 
			decimal m3_ORQA, 
			string m3_ORTP = null, 
			DateTime? m3_DWDZ = null, 
			int? m3_DWHZ = null, 
			string m3_ADID = null, 
			string m3_DECU = null, 
			string m3_SPLM = null, 
			int? m3_FTSC = null, 
			int? m3_BCKO = null, 
			int? m3_PADL = null, 
			string m3_WHLO = null, 
			string m3_LTYP = null, 
			string m3_ALUN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSupplSummary",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_POPN))
				throw new ArgumentNullException("m3_POPN");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("POPN", m3_POPN.Trim())
				.WithQueryParameter("ORQA", m3_ORQA.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ORTP))
				request.WithQueryParameter("ORTP", m3_ORTP.Trim());
			if (m3_DWDZ.HasValue)
				request.WithQueryParameter("DWDZ", m3_DWDZ.Value.ToM3String());
			if (m3_DWHZ.HasValue)
				request.WithQueryParameter("DWHZ", m3_DWHZ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DECU))
				request.WithQueryParameter("DECU", m3_DECU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPLM))
				request.WithQueryParameter("SPLM", m3_SPLM.Trim());
			if (m3_FTSC.HasValue)
				request.WithQueryParameter("FTSC", m3_FTSC.Value.ToString());
			if (m3_BCKO.HasValue)
				request.WithQueryParameter("BCKO", m3_BCKO.Value.ToString());
			if (m3_PADL.HasValue)
				request.WithQueryParameter("PADL", m3_PADL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LTYP))
				request.WithQueryParameter("LTYP", m3_LTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());

			// Execute the request
			var result = await Execute<LstSupplSummaryResponse>(
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
