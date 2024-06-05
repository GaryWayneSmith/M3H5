/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PPS106MI;
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
	/// Name: PPS106MI
	/// Component Name: PurchasePriceDiscount
	/// Description: Purchase price and discount maintenance interface
	/// Version Release: 5e90
	///</summary>
	public partial class PPS106MIResource : M3BaseResourceEndpoint
	{
		public PPS106MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PPS106MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetPrice
		/// Description Retrieve purchase price
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_PRGP">Procurement group</param>
		/// <param name="m3_PRCS">Service process</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_PUDT">Order date</param>
		/// <param name="m3_DWDT">Requested delivery date</param>
		/// <param name="m3_ORQA">Ordered quantity - alternate U/M</param>
		/// <param name="m3_CUTE">Currency terms</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_OURR">Our reference number</param>
		/// <param name="m3_POTC">Purchase order category</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_OPTX">X-option</param>
		/// <param name="m3_OPTY">Y-option</param>
		/// <param name="m3_OPTZ">Z-option</param>
		/// <param name="m3_HDPR">Main product</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_COBI">Group of companies</param>
		/// <param name="m3_ATMO">Attribute model</param>
		/// <param name="m3_ORAD">Origin address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPriceResponse></returns>
		/// <exception cref="M3Exception<GetPriceResponse>"></exception>
		public async Task<M3Response<GetPriceResponse>> GetPrice(
			int? m3_CONO = null, 
			string m3_ITNO = null, 
			string m3_ITGR = null, 
			string m3_PRGP = null, 
			string m3_PRCS = null, 
			string m3_SUFI = null, 
			string m3_SUNO = null, 
			DateTime? m3_PUDT = null, 
			DateTime? m3_DWDT = null, 
			decimal? m3_ORQA = null, 
			int? m3_CUTE = null, 
			string m3_CUCD = null, 
			string m3_OURR = null, 
			string m3_POTC = null, 
			string m3_ORTY = null, 
			string m3_WHLO = null, 
			string m3_DIVI = null, 
			string m3_FACI = null, 
			string m3_OPTX = null, 
			string m3_OPTY = null, 
			string m3_OPTZ = null, 
			string m3_HDPR = null, 
			string m3_PROJ = null, 
			string m3_COBI = null, 
			string m3_ATMO = null, 
			string m3_ORAD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPrice",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRGP))
				request.WithQueryParameter("PRGP", m3_PRGP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRCS))
				request.WithQueryParameter("PRCS", m3_PRCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_PUDT.HasValue)
				request.WithQueryParameter("PUDT", m3_PUDT.Value.ToM3String());
			if (m3_DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3_DWDT.Value.ToM3String());
			if (m3_ORQA.HasValue)
				request.WithQueryParameter("ORQA", m3_ORQA.Value.ToString());
			if (m3_CUTE.HasValue)
				request.WithQueryParameter("CUTE", m3_CUTE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OURR))
				request.WithQueryParameter("OURR", m3_OURR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POTC))
				request.WithQueryParameter("POTC", m3_POTC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTX))
				request.WithQueryParameter("OPTX", m3_OPTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTY))
				request.WithQueryParameter("OPTY", m3_OPTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTZ))
				request.WithQueryParameter("OPTZ", m3_OPTZ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HDPR))
				request.WithQueryParameter("HDPR", m3_HDPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COBI))
				request.WithQueryParameter("COBI", m3_COBI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATMO))
				request.WithQueryParameter("ATMO", m3_ATMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORAD))
				request.WithQueryParameter("ORAD", m3_ORAD.Trim());

			// Execute the request
			var result = await Execute<GetPriceResponse>(
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
