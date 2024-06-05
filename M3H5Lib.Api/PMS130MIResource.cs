/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3ITNO">Item Number (Required)</param>
		/// <param name="m3BANO">Lot number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOpenQIResponse></returns>
		/// <exception cref="M3Exception<LstOpenQIResponse>"></exception>
		public async Task<M3Response<LstOpenQIResponse>> LstOpenQI(
			string m3ITNO, 
			string m3BANO, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3BANO))
				throw new ArgumentNullException(nameof(m3BANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("BANO", m3BANO.Trim());

			// Execute the request
			var result = await Execute<LstOpenQIResponse>(
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
		/// Name SetQIItmPutAway
		/// Description Set Receipt Inspection Item Put Away
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3BANO">Lot number (Required)</param>
		/// <param name="m3STAS">Status - balance ID (Required)</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3TRTM">Entry time</param>
		/// <param name="m3EXPI">Expiration date</param>
		/// <param name="m3CNDT">Follow-up date</param>
		/// <param name="m3SEDT">Sales date</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3POCY">Normal potency</param>
		/// <param name="m3LPCY">Potency</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3ALOC">Allocatable</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3BBDT">Best before date</param>
		/// <param name="m3HVDT">Harvested date</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3ANNO">LI specification number</param>
		/// <param name="m3SEMO">Sequence number</param>
		/// <param name="m3QRID">QI request ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetQIItmPutAway(
			string m3ITNO, 
			string m3BANO, 
			string m3STAS, 
			DateTime? m3TRDT = null, 
			int? m3TRTM = null, 
			DateTime? m3EXPI = null, 
			DateTime? m3CNDT = null, 
			DateTime? m3SEDT = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			int? m3POCY = null, 
			int? m3LPCY = null, 
			string m3BREM = null, 
			int? m3ALOC = null, 
			string m3RSCD = null, 
			DateTime? m3BBDT = null, 
			DateTime? m3HVDT = null, 
			string m3WHLO = null, 
			string m3WHSL = null, 
			string m3CAMU = null, 
			int? m3ANNO = null, 
			int? m3SEMO = null, 
			string m3QRID = null, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3BANO))
				throw new ArgumentNullException(nameof(m3BANO));
			if (string.IsNullOrWhiteSpace(m3STAS))
				throw new ArgumentNullException(nameof(m3STAS));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("BANO", m3BANO.Trim())
				.WithQueryParameter("STAS", m3STAS.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (m3TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3TRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3EXPI.Value.ToM3String());
			if (m3CNDT.HasValue)
				request.WithQueryParameter("CNDT", m3CNDT.Value.ToM3String());
			if (m3SEDT.HasValue)
				request.WithQueryParameter("SEDT", m3SEDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3POCY.HasValue)
				request.WithQueryParameter("POCY", m3POCY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LPCY.HasValue)
				request.WithQueryParameter("LPCY", m3LPCY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (m3ALOC.HasValue)
				request.WithQueryParameter("ALOC", m3ALOC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (m3BBDT.HasValue)
				request.WithQueryParameter("BBDT", m3BBDT.Value.ToM3String());
			if (m3HVDT.HasValue)
				request.WithQueryParameter("HVDT", m3HVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3ANNO.HasValue)
				request.WithQueryParameter("ANNO", m3ANNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SEMO.HasValue)
				request.WithQueryParameter("SEMO", m3SEMO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QRID))
				request.WithQueryParameter("QRID", m3QRID.Trim());

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
