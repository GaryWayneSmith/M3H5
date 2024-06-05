/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.PMS055MI;
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
	/// Name: PMS055MI
	/// Component Name: GetBackFlushQty
	/// Description: Manufactoring order. Back-flush functions
	/// Version Release: 14.x
	///</summary>
	public partial class PMS055MIResource : M3BaseResourceEndpoint
	{
		public PMS055MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PMS055MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetBackFlushQty
		/// Description Get Back Flush Quantity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3RPQA">Reported quantity in alternative unit</param>
		/// <param name="m3MAUN">Manufacturing U/M</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3MTNO">Component number</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBackFlushQtyResponse></returns>
		/// <exception cref="M3Exception<GetBackFlushQtyResponse>"></exception>
		public async Task<M3Response<GetBackFlushQtyResponse>> GetBackFlushQty(
			int m3CONO, 
			string m3FACI, 
			string m3PRNO, 
			string m3MFNO, 
			decimal? m3RPQA = null, 
			string m3MAUN = null, 
			decimal? m3CAWE = null, 
			string m3RORN = null, 
			string m3MTNO = null, 
			int? m3MSEQ = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetBackFlushQty",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3MFNO))
				throw new ArgumentNullException(nameof(m3MFNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("MFNO", m3MFNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3RPQA.HasValue)
				request.WithQueryParameter("RPQA", m3RPQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MAUN))
				request.WithQueryParameter("MAUN", m3MAUN.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTNO))
				request.WithQueryParameter("MTNO", m3MTNO.Trim());
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetBackFlushQtyResponse>(
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
