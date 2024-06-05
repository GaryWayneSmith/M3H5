/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.CRS105MI;
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
	/// Name: CRS105MI
	/// Component Name: COP
	/// Description: Assortment
	/// Version Release: 12
	///</summary>
	public partial class CRS105MIResource : M3BaseResourceEndpoint
	{
		public CRS105MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS105MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstAssmCust
		/// Description List Assortment Customer
		/// Version Release: 12
		/// </summary>
		/// <param name="m3ASCD">Assortment (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FCUN">From customer number</param>
		/// <param name="m3TCUN">To customer number</param>
		/// <param name="m3LMDT">Change date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAssmCustResponse></returns>
		/// <exception cref="M3Exception<LstAssmCustResponse>"></exception>
		public async Task<M3Response<LstAssmCustResponse>> LstAssmCust(
			string m3ASCD, 
			int? m3CONO = null, 
			string m3FCUN = null, 
			string m3TCUN = null, 
			DateTime? m3LMDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAssmCust",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ASCD))
				throw new ArgumentNullException(nameof(m3ASCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("ASCD", m3ASCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FCUN))
				request.WithQueryParameter("FCUN", m3FCUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TCUN))
				request.WithQueryParameter("TCUN", m3TCUN.Trim());
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstAssmCustResponse>(
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
		/// Name LstAssmHead
		/// Description List Assortment Head
		/// Version Release: 12
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FASC">From Assortment</param>
		/// <param name="m3TASC">To Assortment</param>
		/// <param name="m3LMDT">Change date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAssmHeadResponse></returns>
		/// <exception cref="M3Exception<LstAssmHeadResponse>"></exception>
		public async Task<M3Response<LstAssmHeadResponse>> LstAssmHead(
			int? m3CONO = null, 
			string m3FASC = null, 
			string m3TASC = null, 
			DateTime? m3LMDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAssmHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FASC))
				request.WithQueryParameter("FASC", m3FASC.Trim());
			if (!string.IsNullOrWhiteSpace(m3TASC))
				request.WithQueryParameter("TASC", m3TASC.Trim());
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstAssmHeadResponse>(
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
		/// Name LstAssmItem
		/// Description List Assortment Item
		/// Version Release: 12
		/// </summary>
		/// <param name="m3ASCD">Assortment (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FITN">From item number</param>
		/// <param name="m3TITN">To item number</param>
		/// <param name="m3LMDT">Change date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAssmItemResponse></returns>
		/// <exception cref="M3Exception<LstAssmItemResponse>"></exception>
		public async Task<M3Response<LstAssmItemResponse>> LstAssmItem(
			string m3ASCD, 
			int? m3CONO = null, 
			string m3FITN = null, 
			string m3TITN = null, 
			DateTime? m3LMDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAssmItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ASCD))
				throw new ArgumentNullException(nameof(m3ASCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("ASCD", m3ASCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FITN))
				request.WithQueryParameter("FITN", m3FITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TITN))
				request.WithQueryParameter("TITN", m3TITN.Trim());
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstAssmItemResponse>(
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
