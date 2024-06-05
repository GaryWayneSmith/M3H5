/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.OIS530MI;
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
	/// Name: OIS530MI
	/// Component Name: SalesPriceReport
	/// Description: Sales price report interface
	/// Version Release: 5ea0
	///</summary>
	public partial class OIS530MIResource : M3BaseResourceEndpoint
	{
		public OIS530MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS530MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetHead
		/// Description Retrieve Pricelist Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_RPID">Report</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadResponse></returns>
		/// <exception cref="M3Exception<GetHeadResponse>"></exception>
		public async Task<M3Response<GetHeadResponse>> GetHead(
			int? m3_CONO = null, 
			string m3_RPID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RPID))
				request.WithQueryParameter("RPID", m3_RPID.Trim());

			// Execute the request
			var result = await Execute<GetHeadResponse>(
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
		/// Name GetLine
		/// Description Retrieve Pricelist Report information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RPID">Report (Required)</param>
		/// <param name="m3_SSTT">Transaction type (Required)</param>
		/// <param name="m3_TTID">Transaction identity (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_OBV2">Start value 2 (Required)</param>
		/// <param name="m3_OBV3">Start value 3 (Required)</param>
		/// <param name="m3_POPN">Alias number (Required)</param>
		/// <param name="m3_SEQN">Sequence (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_LEVL">Lowest level (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLineResponse></returns>
		/// <exception cref="M3Exception<GetLineResponse>"></exception>
		public async Task<M3Response<GetLineResponse>> GetLine(
			string m3_RPID, 
			int m3_SSTT, 
			string m3_TTID, 
			string m3_OBV1, 
			string m3_OBV2, 
			string m3_OBV3, 
			string m3_POPN, 
			int m3_SEQN, 
			string m3_ITNO, 
			int m3_LEVL, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RPID))
				throw new ArgumentNullException("m3_RPID");
			if (string.IsNullOrWhiteSpace(m3_TTID))
				throw new ArgumentNullException("m3_TTID");
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");
			if (string.IsNullOrWhiteSpace(m3_OBV2))
				throw new ArgumentNullException("m3_OBV2");
			if (string.IsNullOrWhiteSpace(m3_OBV3))
				throw new ArgumentNullException("m3_OBV3");
			if (string.IsNullOrWhiteSpace(m3_POPN))
				throw new ArgumentNullException("m3_POPN");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("RPID", m3_RPID.Trim())
				.WithQueryParameter("SSTT", m3_SSTT.ToString())
				.WithQueryParameter("TTID", m3_TTID.Trim())
				.WithQueryParameter("OBV1", m3_OBV1.Trim())
				.WithQueryParameter("OBV2", m3_OBV2.Trim())
				.WithQueryParameter("OBV3", m3_OBV3.Trim())
				.WithQueryParameter("POPN", m3_POPN.Trim())
				.WithQueryParameter("SEQN", m3_SEQN.ToString())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("LEVL", m3_LEVL.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetLineResponse>(
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
		/// Name LstLine
		/// Description List Pricelist Report information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RPID">Report (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SSTT">Transaction type</param>
		/// <param name="m3_TTID">Transaction identity</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_SEQN">Sequence</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_LEVL">Lowest level</param>
		/// <param name="m3_NFTR">Number of filters</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineResponse></returns>
		/// <exception cref="M3Exception<LstLineResponse>"></exception>
		public async Task<M3Response<LstLineResponse>> LstLine(
			string m3_RPID, 
			int? m3_CONO = null, 
			int? m3_SSTT = null, 
			string m3_TTID = null, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_POPN = null, 
			int? m3_SEQN = null, 
			string m3_ITNO = null, 
			int? m3_LEVL = null, 
			int? m3_NFTR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RPID))
				throw new ArgumentNullException("m3_RPID");

			// Set mandatory parameters
			request
				.WithQueryParameter("RPID", m3_RPID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_SSTT.HasValue)
				request.WithQueryParameter("SSTT", m3_SSTT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TTID))
				request.WithQueryParameter("TTID", m3_TTID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_LEVL.HasValue)
				request.WithQueryParameter("LEVL", m3_LEVL.Value.ToString());
			if (m3_NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3_NFTR.Value.ToString());

			// Execute the request
			var result = await Execute<LstLineResponse>(
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
