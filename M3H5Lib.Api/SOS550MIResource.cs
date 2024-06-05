/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.SOS550MI;
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
	/// Name: SOS550MI
	/// Component Name: ServiceOrder
	/// Description: Api: List and Get Transactions
	/// Version Release: 14.x
	///</summary>
	public partial class SOS550MIResource : M3BaseResourceEndpoint
	{
		public SOS550MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "SOS550MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetRntlEquipmnt
		/// Description Get Rental Equipment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_INTY">Individual item type (Required)</param>
		/// <param name="m3_INNO">Individual item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetRntlEquipmntResponse></returns>
		/// <exception cref="M3Exception<GetRntlEquipmntResponse>"></exception>
		public async Task<M3Response<GetRntlEquipmntResponse>> GetRntlEquipmnt(
			int m3_INTY, 
			string m3_INNO, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetRntlEquipmnt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_INNO))
				throw new ArgumentNullException("m3_INNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("INTY", m3_INTY.ToString())
				.WithQueryParameter("INNO", m3_INNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetRntlEquipmntResponse>(
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

		/// <summary>
		/// Name LstRntlEquipmnt
		/// Description Api: List Rental Equipment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_INTY">Individual item type (Required)</param>
		/// <param name="m3_ISTS">Status - individual item (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ISTE">Status - individual item</param>
		/// <param name="m3_INGR">Individual item group</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_WHLF">Warehouse</param>
		/// <param name="m3_WHLT">Warehouse</param>
		/// <param name="m3_BRAN">Brand</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_MODE">Model description</param>
		/// <param name="m3_CUOW">Owner</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_ITCL">Product group</param>
		/// <param name="m3_INNO">Individual item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRntlEquipmntResponse></returns>
		/// <exception cref="M3Exception<LstRntlEquipmntResponse>"></exception>
		public async Task<M3Response<LstRntlEquipmntResponse>> LstRntlEquipmnt(
			int m3_INTY, 
			string m3_ISTS, 
			int? m3_CONO = null, 
			string m3_ISTE = null, 
			string m3_INGR = null, 
			string m3_ITGR = null, 
			string m3_WHLF = null, 
			string m3_WHLT = null, 
			string m3_BRAN = null, 
			string m3_ITNO = null, 
			string m3_MODE = null, 
			string m3_CUOW = null, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_LVDT = null, 
			string m3_ITCL = null, 
			string m3_INNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstRntlEquipmnt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ISTS))
				throw new ArgumentNullException("m3_ISTS");

			// Set mandatory parameters
			request
				.WithQueryParameter("INTY", m3_INTY.ToString())
				.WithQueryParameter("ISTS", m3_ISTS.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ISTE))
				request.WithQueryParameter("ISTE", m3_ISTE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INGR))
				request.WithQueryParameter("INGR", m3_INGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLF))
				request.WithQueryParameter("WHLF", m3_WHLF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLT))
				request.WithQueryParameter("WHLT", m3_WHLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRAN))
				request.WithQueryParameter("BRAN", m3_BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODE))
				request.WithQueryParameter("MODE", m3_MODE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUOW))
				request.WithQueryParameter("CUOW", m3_CUOW.Trim());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ITCL))
				request.WithQueryParameter("ITCL", m3_ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INNO))
				request.WithQueryParameter("INNO", m3_INNO.Trim());

			// Execute the request
			var result = await Execute<LstRntlEquipmntResponse>(
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
