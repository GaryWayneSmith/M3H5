/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.STS107MI;
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
	/// Name: STS107MI
	/// Component Name: Rental
	/// Description: Simulate Rental Price
	/// Version Release: 5ea0
	///</summary>
	public partial class STS107MIResource : M3BaseResourceEndpoint
	{
		public STS107MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "STS107MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name SimRentalPrc
		/// Description Simulate rental price
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_AGCN">Agreement customer (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_ORQT">Ordered quantity - basic U/M (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_AOTP">Agreement order type (Required)</param>
		/// <param name="m3_DPOT">Rental depot (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_LTYP">Line type</param>
		/// <param name="m3_CCAP">Rental rate type</param>
		/// <param name="m3_PRRF">Price list</param>
		/// <param name="m3_RAFA">Rate factor</param>
		/// <param name="m3_ADPW">Days per week</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SimRentalPrcResponse></returns>
		/// <exception cref="M3Exception<SimRentalPrcResponse>"></exception>
		public async Task<M3Response<SimRentalPrcResponse>> SimRentalPrc(
			string m3_AGCN, 
			string m3_ITNO, 
			decimal m3_ORQT, 
			DateTime m3_FVDT, 
			string m3_AOTP, 
			string m3_DPOT, 
			string m3_FACI, 
			DateTime? m3_LVDT = null, 
			string m3_LTYP = null, 
			string m3_CCAP = null, 
			string m3_PRRF = null, 
			int? m3_RAFA = null, 
			int? m3_ADPW = null, 
			string m3_CUCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SimRentalPrc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AGCN))
				throw new ArgumentNullException("m3_AGCN");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_AOTP))
				throw new ArgumentNullException("m3_AOTP");
			if (string.IsNullOrWhiteSpace(m3_DPOT))
				throw new ArgumentNullException("m3_DPOT");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGCN", m3_AGCN.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("ORQT", m3_ORQT.ToString())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String())
				.WithQueryParameter("AOTP", m3_AOTP.Trim())
				.WithQueryParameter("DPOT", m3_DPOT.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_LTYP))
				request.WithQueryParameter("LTYP", m3_LTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CCAP))
				request.WithQueryParameter("CCAP", m3_CCAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRRF))
				request.WithQueryParameter("PRRF", m3_PRRF.Trim());
			if (m3_RAFA.HasValue)
				request.WithQueryParameter("RAFA", m3_RAFA.Value.ToString());
			if (m3_ADPW.HasValue)
				request.WithQueryParameter("ADPW", m3_ADPW.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());

			// Execute the request
			var result = await Execute<SimRentalPrcResponse>(
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
