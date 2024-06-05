/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetRntlEquipmnt
		/// Description Get Rental Equipment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3INTY">Individual item type (Required)</param>
		/// <param name="m3INNO">Individual item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetRntlEquipmntResponse></returns>
		/// <exception cref="M3Exception<GetRntlEquipmntResponse>"></exception>
		public async Task<M3Response<GetRntlEquipmntResponse>> GetRntlEquipmnt(
			int m3INTY, 
			string m3INNO, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetRntlEquipmnt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3INNO))
				throw new ArgumentNullException(nameof(m3INNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("INTY", m3INTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("INNO", m3INNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetRntlEquipmntResponse>(
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

		/// <summary>
		/// Name LstRntlEquipmnt
		/// Description Api: List Rental Equipment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3INTY">Individual item type (Required)</param>
		/// <param name="m3ISTS">Status - individual item (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ISTE">Status - individual item</param>
		/// <param name="m3INGR">Individual item group</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3WHLF">Warehouse</param>
		/// <param name="m3WHLT">Warehouse</param>
		/// <param name="m3BRAN">Brand</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3MODE">Model description</param>
		/// <param name="m3CUOW">Owner</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3ITCL">Product group</param>
		/// <param name="m3INNO">Individual item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRntlEquipmntResponse></returns>
		/// <exception cref="M3Exception<LstRntlEquipmntResponse>"></exception>
		public async Task<M3Response<LstRntlEquipmntResponse>> LstRntlEquipmnt(
			int m3INTY, 
			string m3ISTS, 
			int? m3CONO = null, 
			string m3ISTE = null, 
			string m3INGR = null, 
			string m3ITGR = null, 
			string m3WHLF = null, 
			string m3WHLT = null, 
			string m3BRAN = null, 
			string m3ITNO = null, 
			string m3MODE = null, 
			string m3CUOW = null, 
			DateTime? m3FVDT = null, 
			DateTime? m3LVDT = null, 
			string m3ITCL = null, 
			string m3INNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstRntlEquipmnt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ISTS))
				throw new ArgumentNullException(nameof(m3ISTS));

			// Set mandatory parameters
			request
				.WithQueryParameter("INTY", m3INTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ISTS", m3ISTS.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ISTE))
				request.WithQueryParameter("ISTE", m3ISTE.Trim());
			if (!string.IsNullOrWhiteSpace(m3INGR))
				request.WithQueryParameter("INGR", m3INGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLF))
				request.WithQueryParameter("WHLF", m3WHLF.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLT))
				request.WithQueryParameter("WHLT", m3WHLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRAN))
				request.WithQueryParameter("BRAN", m3BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODE))
				request.WithQueryParameter("MODE", m3MODE.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUOW))
				request.WithQueryParameter("CUOW", m3CUOW.Trim());
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ITCL))
				request.WithQueryParameter("ITCL", m3ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3INNO))
				request.WithQueryParameter("INNO", m3INNO.Trim());

			// Execute the request
			var result = await Execute<LstRntlEquipmntResponse>(
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
