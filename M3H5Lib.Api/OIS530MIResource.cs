/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetHead
		/// Description Retrieve Pricelist Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3RPID">Report</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadResponse></returns>
		/// <exception cref="M3Exception<GetHeadResponse>"></exception>
		public async Task<M3Response<GetHeadResponse>> GetHead(
			int? m3CONO = null, 
			string m3RPID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RPID))
				request.WithQueryParameter("RPID", m3RPID.Trim());

			// Execute the request
			var result = await Execute<GetHeadResponse>(
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
		/// Name GetLine
		/// Description Retrieve Pricelist Report information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3RPID">Report (Required)</param>
		/// <param name="m3SSTT">Transaction type (Required)</param>
		/// <param name="m3TTID">Transaction identity (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3OBV2">Start value 2 (Required)</param>
		/// <param name="m3OBV3">Start value 3 (Required)</param>
		/// <param name="m3POPN">Alias number (Required)</param>
		/// <param name="m3SEQN">Sequence (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3LEVL">Lowest level (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLineResponse></returns>
		/// <exception cref="M3Exception<GetLineResponse>"></exception>
		public async Task<M3Response<GetLineResponse>> GetLine(
			string m3RPID, 
			int m3SSTT, 
			string m3TTID, 
			string m3OBV1, 
			string m3OBV2, 
			string m3OBV3, 
			string m3POPN, 
			int m3SEQN, 
			string m3ITNO, 
			int m3LEVL, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RPID))
				throw new ArgumentNullException(nameof(m3RPID));
			if (string.IsNullOrWhiteSpace(m3TTID))
				throw new ArgumentNullException(nameof(m3TTID));
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));
			if (string.IsNullOrWhiteSpace(m3OBV2))
				throw new ArgumentNullException(nameof(m3OBV2));
			if (string.IsNullOrWhiteSpace(m3OBV3))
				throw new ArgumentNullException(nameof(m3OBV3));
			if (string.IsNullOrWhiteSpace(m3POPN))
				throw new ArgumentNullException(nameof(m3POPN));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("RPID", m3RPID.Trim())
				.WithQueryParameter("SSTT", m3SSTT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TTID", m3TTID.Trim())
				.WithQueryParameter("OBV1", m3OBV1.Trim())
				.WithQueryParameter("OBV2", m3OBV2.Trim())
				.WithQueryParameter("OBV3", m3OBV3.Trim())
				.WithQueryParameter("POPN", m3POPN.Trim())
				.WithQueryParameter("SEQN", m3SEQN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("LEVL", m3LEVL.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetLineResponse>(
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
		/// Name LstLine
		/// Description List Pricelist Report information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3RPID">Report (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SSTT">Transaction type</param>
		/// <param name="m3TTID">Transaction identity</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3SEQN">Sequence</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3LEVL">Lowest level</param>
		/// <param name="m3NFTR">Number of filters</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineResponse></returns>
		/// <exception cref="M3Exception<LstLineResponse>"></exception>
		public async Task<M3Response<LstLineResponse>> LstLine(
			string m3RPID, 
			int? m3CONO = null, 
			int? m3SSTT = null, 
			string m3TTID = null, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3POPN = null, 
			int? m3SEQN = null, 
			string m3ITNO = null, 
			int? m3LEVL = null, 
			int? m3NFTR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RPID))
				throw new ArgumentNullException(nameof(m3RPID));

			// Set mandatory parameters
			request
				.WithQueryParameter("RPID", m3RPID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SSTT.HasValue)
				request.WithQueryParameter("SSTT", m3SSTT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TTID))
				request.WithQueryParameter("TTID", m3TTID.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (m3SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3SEQN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3LEVL.HasValue)
				request.WithQueryParameter("LEVL", m3LEVL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3NFTR.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstLineResponse>(
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
