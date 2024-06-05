/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddRelatedItem
		/// Description Add Related Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_RPTY">Replacement type (Required)</param>
		/// <param name="m3_ALIT">Related item (Required)</param>
		/// <param name="m3_INTC">Interchangeability (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_RATY">Reference type</param>
		/// <param name="m3_RAID">Reference identity</param>
		/// <param name="m3_PUPN">Preferred item</param>
		/// <param name="m3_DSP1">Flag - Basic U/M is different for the items</param>
		/// <param name="m3_DSP2">Flag - The related item has status of &1</param>
		/// <param name="m3_CPYS">Copy statistics</param>
		/// <param name="m3_CNRE">Cond replacement</param>
		/// <param name="m3_CNDN">Condition</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddRelatedItem(
			string m3_ITNO, 
			int m3_RPTY, 
			string m3_ALIT, 
			int m3_INTC, 
			DateTime m3_STDT, 
			int? m3_CONO = null, 
			int? m3_RATY = null, 
			string m3_RAID = null, 
			int? m3_PUPN = null, 
			int? m3_DSP1 = null, 
			int? m3_DSP2 = null, 
			int? m3_CPYS = null, 
			int? m3_CNRE = null, 
			string m3_CNDN = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddRelatedItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_ALIT))
				throw new ArgumentNullException("m3_ALIT");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("RPTY", m3_RPTY.ToString())
				.WithQueryParameter("ALIT", m3_ALIT.Trim())
				.WithQueryParameter("INTC", m3_INTC.ToString())
				.WithQueryParameter("STDT", m3_STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_RATY.HasValue)
				request.WithQueryParameter("RATY", m3_RATY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RAID))
				request.WithQueryParameter("RAID", m3_RAID.Trim());
			if (m3_PUPN.HasValue)
				request.WithQueryParameter("PUPN", m3_PUPN.Value.ToString());
			if (m3_DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3_DSP1.Value.ToString());
			if (m3_DSP2.HasValue)
				request.WithQueryParameter("DSP2", m3_DSP2.Value.ToString());
			if (m3_CPYS.HasValue)
				request.WithQueryParameter("CPYS", m3_CPYS.Value.ToString());
			if (m3_CNRE.HasValue)
				request.WithQueryParameter("CNRE", m3_CNRE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CNDN))
				request.WithQueryParameter("CNDN", m3_CNDN.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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

		/// <summary>
		/// Name LstItemRelation
		/// Description List item relations
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_RPTY">Replacement type</param>
		/// <param name="m3_ALIT">Related item</param>
		/// <param name="m3_LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemRelationResponse></returns>
		/// <exception cref="M3Exception<LstItemRelationResponse>"></exception>
		public async Task<M3Response<LstItemRelationResponse>> LstItemRelation(
			int? m3_CONO = null, 
			string m3_ITNO = null, 
			int? m3_RPTY = null, 
			string m3_ALIT = null, 
			decimal? m3_LMTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItemRelation",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_RPTY.HasValue)
				request.WithQueryParameter("RPTY", m3_RPTY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALIT))
				request.WithQueryParameter("ALIT", m3_ALIT.Trim());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstItemRelationResponse>(
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
