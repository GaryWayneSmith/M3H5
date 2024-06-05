/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstDelivLots
		/// Description List by order date
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3FRDT">From date</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="m3FRGR">Item group</param>
		/// <param name="m3TOGR">Item group</param>
		/// <param name="m3FRCL">Product group</param>
		/// <param name="m3TOCL">Product group</param>
		/// <param name="m3FRGP">Procurement group</param>
		/// <param name="m3TOGP">Procurement group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDelivLotsResponse></returns>
		/// <exception cref="M3Exception<LstDelivLotsResponse>"></exception>
		public async Task<M3Response<LstDelivLotsResponse>> LstDelivLots(
			string m3CUNO = null, 
			DateTime? m3FRDT = null, 
			DateTime? m3TODT = null, 
			string m3FRGR = null, 
			string m3TOGR = null, 
			string m3FRCL = null, 
			string m3TOCL = null, 
			string m3FRGP = null, 
			string m3TOGP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstDelivLots",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3FRDT.Value.ToM3String());
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3FRGR))
				request.WithQueryParameter("FRGR", m3FRGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOGR))
				request.WithQueryParameter("TOGR", m3TOGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRCL))
				request.WithQueryParameter("FRCL", m3FRCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOCL))
				request.WithQueryParameter("TOCL", m3TOCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRGP))
				request.WithQueryParameter("FRGP", m3FRGP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOGP))
				request.WithQueryParameter("TOGP", m3TOGP.Trim());

			// Execute the request
			var result = await Execute<LstDelivLotsResponse>(
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
