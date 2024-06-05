/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PMS130MI;
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
	/// Name: PMS130MI
	/// Component Name: Reciept inspection coded items
	/// Description: Reciept inspection coded items
	/// Version Release: 5ea0
	///</summary>
	public partial class PMS130MIResource : M3BaseResourceEndpoint
	{
		public PMS130MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PMS130MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstOpenQI
		/// Description List Open QI
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item Number (Required)</param>
		/// <param name="m3_BANO">Lot number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOpenQIResponse></returns>
		/// <exception cref="M3Exception<LstOpenQIResponse>"></exception>
		public async Task<M3Response<LstOpenQIResponse>> LstOpenQI(
			string m3_ITNO, 
			string m3_BANO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstOpenQI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("BANO", m3_BANO.Trim());

			// Execute the request
			var result = await Execute<LstOpenQIResponse>(
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
		/// Name SetQIItmPutAway
		/// Description Set Receipt Inspection Item Put Away
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_BANO">Lot number (Required)</param>
		/// <param name="m3_STAS">Status - balance ID (Required)</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TRTM">Entry time</param>
		/// <param name="m3_EXPI">Expiration date</param>
		/// <param name="m3_CNDT">Follow-up date</param>
		/// <param name="m3_SEDT">Sales date</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_POCY">Normal potency</param>
		/// <param name="m3_LPCY">Potency</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_ALOC">Allocatable</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_BBDT">Best before date</param>
		/// <param name="m3_HVDT">Harvested date</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_ANNO">LI specification number</param>
		/// <param name="m3_SEMO">Sequence number</param>
		/// <param name="m3_QRID">QI request ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetQIItmPutAway(
			string m3_ITNO, 
			string m3_BANO, 
			string m3_STAS, 
			DateTime? m3_TRDT = null, 
			int? m3_TRTM = null, 
			DateTime? m3_EXPI = null, 
			DateTime? m3_CNDT = null, 
			DateTime? m3_SEDT = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			int? m3_POCY = null, 
			int? m3_LPCY = null, 
			string m3_BREM = null, 
			int? m3_ALOC = null, 
			string m3_RSCD = null, 
			DateTime? m3_BBDT = null, 
			DateTime? m3_HVDT = null, 
			string m3_WHLO = null, 
			string m3_WHSL = null, 
			string m3_CAMU = null, 
			int? m3_ANNO = null, 
			int? m3_SEMO = null, 
			string m3_QRID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SetQIItmPutAway",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");
			if (string.IsNullOrWhiteSpace(m3_STAS))
				throw new ArgumentNullException("m3_STAS");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("BANO", m3_BANO.Trim())
				.WithQueryParameter("STAS", m3_STAS.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());
			if (m3_EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3_EXPI.Value.ToM3String());
			if (m3_CNDT.HasValue)
				request.WithQueryParameter("CNDT", m3_CNDT.Value.ToM3String());
			if (m3_SEDT.HasValue)
				request.WithQueryParameter("SEDT", m3_SEDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (m3_POCY.HasValue)
				request.WithQueryParameter("POCY", m3_POCY.Value.ToString());
			if (m3_LPCY.HasValue)
				request.WithQueryParameter("LPCY", m3_LPCY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (m3_ALOC.HasValue)
				request.WithQueryParameter("ALOC", m3_ALOC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (m3_BBDT.HasValue)
				request.WithQueryParameter("BBDT", m3_BBDT.Value.ToM3String());
			if (m3_HVDT.HasValue)
				request.WithQueryParameter("HVDT", m3_HVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_ANNO.HasValue)
				request.WithQueryParameter("ANNO", m3_ANNO.Value.ToString());
			if (m3_SEMO.HasValue)
				request.WithQueryParameter("SEMO", m3_SEMO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QRID))
				request.WithQueryParameter("QRID", m3_QRID.Trim());

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
