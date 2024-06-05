/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.MMS020MI;
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
	/// Name: MMS020MI
	/// Component Name: ItemRelation
	/// Description: Related items interface
	/// Version Release: 14.x
	///</summary>
	public partial class MMS020MIResource : M3BaseResourceEndpoint
	{
		public MMS020MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS020MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddRelatedItem
		/// Description Add Related Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3RPTY">Replacement type (Required)</param>
		/// <param name="m3ALIT">Related item (Required)</param>
		/// <param name="m3INTC">Interchangeability (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3RATY">Reference type</param>
		/// <param name="m3RAID">Reference identity</param>
		/// <param name="m3PUPN">Preferred item</param>
		/// <param name="m3DSP1">Flag - Basic U/M is different for the items</param>
		/// <param name="m3DSP2">Flag - The related item has status of &1</param>
		/// <param name="m3CPYS">Copy statistics</param>
		/// <param name="m3CNRE">Cond replacement</param>
		/// <param name="m3CNDN">Condition</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddRelatedItem(
			string m3ITNO, 
			int m3RPTY, 
			string m3ALIT, 
			int m3INTC, 
			DateTime m3STDT, 
			int? m3CONO = null, 
			int? m3RATY = null, 
			string m3RAID = null, 
			int? m3PUPN = null, 
			int? m3DSP1 = null, 
			int? m3DSP2 = null, 
			int? m3CPYS = null, 
			int? m3CNRE = null, 
			string m3CNDN = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddRelatedItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3ALIT))
				throw new ArgumentNullException(nameof(m3ALIT));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("RPTY", m3RPTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ALIT", m3ALIT.Trim())
				.WithQueryParameter("INTC", m3INTC.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STDT", m3STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RATY.HasValue)
				request.WithQueryParameter("RATY", m3RATY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RAID))
				request.WithQueryParameter("RAID", m3RAID.Trim());
			if (m3PUPN.HasValue)
				request.WithQueryParameter("PUPN", m3PUPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3DSP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP2.HasValue)
				request.WithQueryParameter("DSP2", m3DSP2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CPYS.HasValue)
				request.WithQueryParameter("CPYS", m3CPYS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CNRE.HasValue)
				request.WithQueryParameter("CNRE", m3CNRE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CNDN))
				request.WithQueryParameter("CNDN", m3CNDN.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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

		/// <summary>
		/// Name LstItemRelation
		/// Description List item relations
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3RPTY">Replacement type</param>
		/// <param name="m3ALIT">Related item</param>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemRelationResponse></returns>
		/// <exception cref="M3Exception<LstItemRelationResponse>"></exception>
		public async Task<M3Response<LstItemRelationResponse>> LstItemRelation(
			int? m3CONO = null, 
			string m3ITNO = null, 
			int? m3RPTY = null, 
			string m3ALIT = null, 
			decimal? m3LMTS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstItemRelation",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3RPTY.HasValue)
				request.WithQueryParameter("RPTY", m3RPTY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALIT))
				request.WithQueryParameter("ALIT", m3ALIT.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstItemRelationResponse>(
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
