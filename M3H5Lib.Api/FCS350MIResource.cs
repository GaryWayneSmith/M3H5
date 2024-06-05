/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.FCS350MI;
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
	/// Name: FCS350MI
	/// Component Name: Forecast
	/// Description: Api: Forecast
	/// Version Release: 14.x
	///</summary>
	public partial class FCS350MIResource : M3BaseResourceEndpoint
	{
		public FCS350MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "FCS350MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstForQty
		/// Description List Forecast quantity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3MDVR">Master demand schedule version</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3SULF">Summary level</param>
		/// <param name="m3SWHG">Sum warehousegroup</param>
		/// <param name="m3APIP">APS - policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstForQtyResponse></returns>
		/// <exception cref="M3Exception<LstForQtyResponse>"></exception>
		public async Task<M3Response<LstForQtyResponse>> LstForQty(
			string m3WHLO = null, 
			string m3WHGR = null, 
			string m3ITNO = null, 
			string m3MDVR = null, 
			DateTime? m3FDAT = null, 
			DateTime? m3TDAT = null, 
			int? m3SULF = null, 
			int? m3SWHG = null, 
			string m3APIP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstForQty",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MDVR))
				request.WithQueryParameter("MDVR", m3MDVR.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());
			if (m3SULF.HasValue)
				request.WithQueryParameter("SULF", m3SULF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SWHG.HasValue)
				request.WithQueryParameter("SWHG", m3SWHG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());

			// Execute the request
			var result = await Execute<LstForQtyResponse>(
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
		/// Name UpdForQty
		/// Description Update Forecast quantity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3MDVR">Master demand schedule version</param>
		/// <param name="m3FOQT">Forecast quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdForQty(
			string m3WHLO = null, 
			string m3ITNO = null, 
			DateTime? m3FDAT = null, 
			DateTime? m3TDAT = null, 
			string m3MDVR = null, 
			decimal? m3FOQT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdForQty",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3MDVR))
				request.WithQueryParameter("MDVR", m3MDVR.Trim());
			if (m3FOQT.HasValue)
				request.WithQueryParameter("FOQT", m3FOQT.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<M3Record>(
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
