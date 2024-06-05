/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name SimRentalPrc
		/// Description Simulate rental price
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3AGCN">Agreement customer (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3ORQT">Ordered quantity - basic U/M (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3AOTP">Agreement order type (Required)</param>
		/// <param name="m3DPOT">Rental depot (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3LTYP">Line type</param>
		/// <param name="m3CCAP">Rental rate type</param>
		/// <param name="m3PRRF">Price list</param>
		/// <param name="m3RAFA">Rate factor</param>
		/// <param name="m3ADPW">Days per week</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SimRentalPrcResponse></returns>
		/// <exception cref="M3Exception<SimRentalPrcResponse>"></exception>
		public async Task<M3Response<SimRentalPrcResponse>> SimRentalPrc(
			string m3AGCN, 
			string m3ITNO, 
			decimal m3ORQT, 
			DateTime m3FVDT, 
			string m3AOTP, 
			string m3DPOT, 
			string m3FACI, 
			DateTime? m3LVDT = null, 
			string m3LTYP = null, 
			string m3CCAP = null, 
			string m3PRRF = null, 
			int? m3RAFA = null, 
			int? m3ADPW = null, 
			string m3CUCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SimRentalPrc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGCN))
				throw new ArgumentNullException(nameof(m3AGCN));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3AOTP))
				throw new ArgumentNullException(nameof(m3AOTP));
			if (string.IsNullOrWhiteSpace(m3DPOT))
				throw new ArgumentNullException(nameof(m3DPOT));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGCN", m3AGCN.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("ORQT", m3ORQT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FVDT", m3FVDT.ToM3String())
				.WithQueryParameter("AOTP", m3AOTP.Trim())
				.WithQueryParameter("DPOT", m3DPOT.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3LTYP))
				request.WithQueryParameter("LTYP", m3LTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CCAP))
				request.WithQueryParameter("CCAP", m3CCAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRRF))
				request.WithQueryParameter("PRRF", m3PRRF.Trim());
			if (m3RAFA.HasValue)
				request.WithQueryParameter("RAFA", m3RAFA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADPW.HasValue)
				request.WithQueryParameter("ADPW", m3ADPW.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());

			// Execute the request
			var result = await Execute<SimRentalPrcResponse>(
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
