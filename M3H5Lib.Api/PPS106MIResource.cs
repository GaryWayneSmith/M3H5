/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3PRGP">Procurement group</param>
		/// <param name="m3PRCS">Service process</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3PUDT">Order date</param>
		/// <param name="m3DWDT">Requested delivery date</param>
		/// <param name="m3ORQA">Ordered quantity - alternate U/M</param>
		/// <param name="m3CUTE">Currency terms</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3OURR">Our reference number</param>
		/// <param name="m3POTC">Purchase order category</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3OPTX">X-option</param>
		/// <param name="m3OPTY">Y-option</param>
		/// <param name="m3OPTZ">Z-option</param>
		/// <param name="m3HDPR">Main product</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3COBI">Group of companies</param>
		/// <param name="m3ATMO">Attribute model</param>
		/// <param name="m3ORAD">Origin address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPriceResponse></returns>
		/// <exception cref="M3Exception<GetPriceResponse>"></exception>
		public async Task<M3Response<GetPriceResponse>> GetPrice(
			int? m3CONO = null, 
			string m3ITNO = null, 
			string m3ITGR = null, 
			string m3PRGP = null, 
			string m3PRCS = null, 
			string m3SUFI = null, 
			string m3SUNO = null, 
			DateTime? m3PUDT = null, 
			DateTime? m3DWDT = null, 
			decimal? m3ORQA = null, 
			int? m3CUTE = null, 
			string m3CUCD = null, 
			string m3OURR = null, 
			string m3POTC = null, 
			string m3ORTY = null, 
			string m3WHLO = null, 
			string m3DIVI = null, 
			string m3FACI = null, 
			string m3OPTX = null, 
			string m3OPTY = null, 
			string m3OPTZ = null, 
			string m3HDPR = null, 
			string m3PROJ = null, 
			string m3COBI = null, 
			string m3ATMO = null, 
			string m3ORAD = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRGP))
				request.WithQueryParameter("PRGP", m3PRGP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRCS))
				request.WithQueryParameter("PRCS", m3PRCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3PUDT.HasValue)
				request.WithQueryParameter("PUDT", m3PUDT.Value.ToM3String());
			if (m3DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3DWDT.Value.ToM3String());
			if (m3ORQA.HasValue)
				request.WithQueryParameter("ORQA", m3ORQA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CUTE.HasValue)
				request.WithQueryParameter("CUTE", m3CUTE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3OURR))
				request.WithQueryParameter("OURR", m3OURR.Trim());
			if (!string.IsNullOrWhiteSpace(m3POTC))
				request.WithQueryParameter("POTC", m3POTC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTX))
				request.WithQueryParameter("OPTX", m3OPTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTY))
				request.WithQueryParameter("OPTY", m3OPTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTZ))
				request.WithQueryParameter("OPTZ", m3OPTZ.Trim());
			if (!string.IsNullOrWhiteSpace(m3HDPR))
				request.WithQueryParameter("HDPR", m3HDPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3COBI))
				request.WithQueryParameter("COBI", m3COBI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATMO))
				request.WithQueryParameter("ATMO", m3ATMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORAD))
				request.WithQueryParameter("ORAD", m3ORAD.Trim());

			// Execute the request
			var result = await Execute<GetPriceResponse>(
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
