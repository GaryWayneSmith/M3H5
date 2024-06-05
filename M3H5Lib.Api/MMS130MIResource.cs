/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
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
	/// Name: MMS130MI
	/// Component Name: RclLotSts
	/// Description: Reclassification of lot
	/// Version Release: 5ea0
	///</summary>
	public partial class MMS130MIResource : M3BaseResourceEndpoint
	{
		public MMS130MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS130MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name RclLotSts
		/// Description RclLotSts
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_STAS">Status - balance ID</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_OWNC">Owner</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_LPCY">Potency</param>
		/// <param name="m3_ALOC">Allocatable</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RclLotSts(
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_STAS = null, 
			string m3_RSCD = null, 
			string m3_OWNC = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			string m3_BREM = null, 
			int? m3_LPCY = null, 
			int? m3_ALOC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RclLotSts",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAS))
				request.WithQueryParameter("STAS", m3_STAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OWNC))
				request.WithQueryParameter("OWNC", m3_OWNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (m3_LPCY.HasValue)
				request.WithQueryParameter("LPCY", m3_LPCY.Value.ToString());
			if (m3_ALOC.HasValue)
				request.WithQueryParameter("ALOC", m3_ALOC.Value.ToString());

			// Execute the request
			var result = await Execute<M3Record>(
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
