/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.OIS358MI;
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
	/// Name: OIS358MI
	/// Component Name: CustomerOrder
	/// Description: List delivered lots per customer
	/// Version Release: 5e90
	///</summary>
	public partial class OIS358MIResource : M3BaseResourceEndpoint
	{
		public OIS358MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS358MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstDelivLots
		/// Description List by order date
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_FRDT">From date</param>
		/// <param name="m3_TODT">To date</param>
		/// <param name="m3_FRGR">Item group</param>
		/// <param name="m3_TOGR">Item group</param>
		/// <param name="m3_FRCL">Product group</param>
		/// <param name="m3_TOCL">Product group</param>
		/// <param name="m3_FRGP">Procurement group</param>
		/// <param name="m3_TOGP">Procurement group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDelivLotsResponse></returns>
		/// <exception cref="M3Exception<LstDelivLotsResponse>"></exception>
		public async Task<M3Response<LstDelivLotsResponse>> LstDelivLots(
			string m3_CUNO = null, 
			DateTime? m3_FRDT = null, 
			DateTime? m3_TODT = null, 
			string m3_FRGR = null, 
			string m3_TOGR = null, 
			string m3_FRCL = null, 
			string m3_TOCL = null, 
			string m3_FRGP = null, 
			string m3_TOGP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDelivLots",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3_FRDT.Value.ToM3String());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_FRGR))
				request.WithQueryParameter("FRGR", m3_FRGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOGR))
				request.WithQueryParameter("TOGR", m3_TOGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRCL))
				request.WithQueryParameter("FRCL", m3_FRCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOCL))
				request.WithQueryParameter("TOCL", m3_TOCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRGP))
				request.WithQueryParameter("FRGP", m3_FRGP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOGP))
				request.WithQueryParameter("TOGP", m3_TOGP.Trim());

			// Execute the request
			var result = await Execute<LstDelivLotsResponse>(
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
