/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.OSS450MI;
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
	/// Name: OSS450MI
	/// Component Name: Customer Variations
	/// Description: Api: Enter Lost Sales
	/// Version Release: 5ea0
	///</summary>
	public partial class OSS450MIResource : M3BaseResourceEndpoint
	{
		public OSS450MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OSS450MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddLostSales
		/// Description Add Lost Sales
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3ORQA">Order qty (Required)</param>
		/// <param name="m3DWDT">Requested delivery date (Required)</param>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3ORTP">Customer order type</param>
		/// <param name="m3DEFC">Demand factor</param>
		/// <param name="m3ALUN">Alternate U/M</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3SPUN">Sales price unit of measure</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddLostSalesResponse></returns>
		/// <exception cref="M3Exception<AddLostSalesResponse>"></exception>
		public async Task<M3Response<AddLostSalesResponse>> AddLostSales(
			string m3FACI, 
			string m3ITNO, 
			string m3WHLO, 
			string m3ORQA, 
			DateTime m3DWDT, 
			string m3ORNO = null, 
			string m3CUNO = null, 
			string m3ADID = null, 
			string m3ORTP = null, 
			int? m3DEFC = null, 
			string m3ALUN = null, 
			string m3SAPR = null, 
			string m3SPUN = null, 
			string m3RSCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLostSales",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3ORQA))
				throw new ArgumentNullException(nameof(m3ORQA));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("ORQA", m3ORQA.Trim())
				.WithQueryParameter("DWDT", m3DWDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTP))
				request.WithQueryParameter("ORTP", m3ORTP.Trim());
			if (m3DEFC.HasValue)
				request.WithQueryParameter("DEFC", m3DEFC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALUN))
				request.WithQueryParameter("ALUN", m3ALUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SAPR))
				request.WithQueryParameter("SAPR", m3SAPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPUN))
				request.WithQueryParameter("SPUN", m3SPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());

			// Execute the request
			var result = await Execute<AddLostSalesResponse>(
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
