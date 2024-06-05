/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_ORQA">Order qty (Required)</param>
		/// <param name="m3_DWDT">Requested delivery date (Required)</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_ORTP">Customer order type</param>
		/// <param name="m3_DEFC">Demand factor</param>
		/// <param name="m3_ALUN">Alternate U/M</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_SPUN">Sales price unit of measure</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddLostSalesResponse></returns>
		/// <exception cref="M3Exception<AddLostSalesResponse>"></exception>
		public async Task<M3Response<AddLostSalesResponse>> AddLostSales(
			string m3_FACI, 
			string m3_ITNO, 
			string m3_WHLO, 
			string m3_ORQA, 
			DateTime m3_DWDT, 
			string m3_ORNO = null, 
			string m3_CUNO = null, 
			string m3_ADID = null, 
			string m3_ORTP = null, 
			int? m3_DEFC = null, 
			string m3_ALUN = null, 
			string m3_SAPR = null, 
			string m3_SPUN = null, 
			string m3_RSCD = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_ORQA))
				throw new ArgumentNullException("m3_ORQA");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("ORQA", m3_ORQA.Trim())
				.WithQueryParameter("DWDT", m3_DWDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTP))
				request.WithQueryParameter("ORTP", m3_ORTP.Trim());
			if (m3_DEFC.HasValue)
				request.WithQueryParameter("DEFC", m3_DEFC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SAPR))
				request.WithQueryParameter("SAPR", m3_SAPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPUN))
				request.WithQueryParameter("SPUN", m3_SPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());

			// Execute the request
			var result = await Execute<AddLostSalesResponse>(
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
