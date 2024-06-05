/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MYS500MI;
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
	/// Name: MYS500MI
	/// Component Name: TEI
	/// Description: Api: TEI Transfer
	/// Version Release: 
	///</summary>
	public partial class MYS500MIResource : M3BaseResourceEndpoint
	{
		public MYS500MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MYS500MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ChgHead
		/// Description Change TEI transfer head
		/// Version Release: 12.5
		/// </summary>
		/// <param name="m3_E0IO">Message direction (Required)</param>
		/// <param name="m3_INOU">Direction (Required)</param>
		/// <param name="m3_TINR">TEI Transfer ID (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_MBDT">Message broker date</param>
		/// <param name="m3_MBTM">Message broker time</param>
		/// <param name="m3_TRR1">Transaction reference 1</param>
		/// <param name="m3_TRR2">Transaction reference 2</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgHead(
			string m3_E0IO, 
			int m3_INOU, 
			string m3_TINR, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_STAT = null, 
			DateTime? m3_MBDT = null, 
			int? m3_MBTM = null, 
			string m3_TRR1 = null, 
			string m3_TRR2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0IO))
				throw new ArgumentNullException("m3_E0IO");
			if (string.IsNullOrWhiteSpace(m3_TINR))
				throw new ArgumentNullException("m3_TINR");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0IO", m3_E0IO.Trim())
				.WithQueryParameter("INOU", m3_INOU.ToString())
				.WithQueryParameter("TINR", m3_TINR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_MBDT.HasValue)
				request.WithQueryParameter("MBDT", m3_MBDT.Value.ToM3String());
			if (m3_MBTM.HasValue)
				request.WithQueryParameter("MBTM", m3_MBTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TRR1))
				request.WithQueryParameter("TRR1", m3_TRR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRR2))
				request.WithQueryParameter("TRR2", m3_TRR2.Trim());

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
		/// Name GetHead
		/// Description Get header information
		/// Version Release: 12.5
		/// </summary>
		/// <param name="m3_E0IO">Message direction (Required)</param>
		/// <param name="m3_INOU">Direction (Required)</param>
		/// <param name="m3_TINR">TEI Transfer ID (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadResponse></returns>
		/// <exception cref="M3Exception<GetHeadResponse>"></exception>
		public async Task<M3Response<GetHeadResponse>> GetHead(
			string m3_E0IO, 
			int m3_INOU, 
			string m3_TINR, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
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

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0IO))
				throw new ArgumentNullException("m3_E0IO");
			if (string.IsNullOrWhiteSpace(m3_TINR))
				throw new ArgumentNullException("m3_TINR");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0IO", m3_E0IO.Trim())
				.WithQueryParameter("INOU", m3_INOU.ToString())
				.WithQueryParameter("TINR", m3_TINR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

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
		/// Name LstDetail
		/// Description Lst Detail information
		/// Version Release: 12.5
		/// </summary>
		/// <param name="m3_E0IO">Message direction (Required)</param>
		/// <param name="m3_INOU">Direction (Required)</param>
		/// <param name="m3_TINR">TEI Transfer ID (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDetailResponse></returns>
		/// <exception cref="M3Exception<LstDetailResponse>"></exception>
		public async Task<M3Response<LstDetailResponse>> LstDetail(
			string m3_E0IO, 
			int m3_INOU, 
			string m3_TINR, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0IO))
				throw new ArgumentNullException("m3_E0IO");
			if (string.IsNullOrWhiteSpace(m3_TINR))
				throw new ArgumentNullException("m3_TINR");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0IO", m3_E0IO.Trim())
				.WithQueryParameter("INOU", m3_INOU.ToString())
				.WithQueryParameter("TINR", m3_TINR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstDetailResponse>(
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
		/// Name LstPackGrp
		/// Description List package groups for one TEI Transfer ID
		/// Version Release: 12.5
		/// </summary>
		/// <param name="m3_E0IO">Message direction (Required)</param>
		/// <param name="m3_INOU">Direction (Required)</param>
		/// <param name="m3_TINR">TEI Transfer ID (Required)</param>
		/// <param name="m3_PACO">Package level (Required)</param>
		/// <param name="m3_PAGL">Package aggregation level (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPackGrpResponse></returns>
		/// <exception cref="M3Exception<LstPackGrpResponse>"></exception>
		public async Task<M3Response<LstPackGrpResponse>> LstPackGrp(
			string m3_E0IO, 
			int m3_INOU, 
			string m3_TINR, 
			int m3_PACO, 
			int m3_PAGL, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPackGrp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0IO))
				throw new ArgumentNullException("m3_E0IO");
			if (string.IsNullOrWhiteSpace(m3_TINR))
				throw new ArgumentNullException("m3_TINR");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0IO", m3_E0IO.Trim())
				.WithQueryParameter("INOU", m3_INOU.ToString())
				.WithQueryParameter("TINR", m3_TINR.Trim())
				.WithQueryParameter("PACO", m3_PACO.ToString())
				.WithQueryParameter("PAGL", m3_PAGL.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstPackGrpResponse>(
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
		/// Name LstPackages
		/// Description List packages for one TEI Transfer ID
		/// Version Release: 12.5
		/// </summary>
		/// <param name="m3_E0IO">Message direction (Required)</param>
		/// <param name="m3_INOU">Direction (Required)</param>
		/// <param name="m3_TINR">TEI Transfer ID (Required)</param>
		/// <param name="m3_PACO">Package level (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_PACK">Packaging type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPackagesResponse></returns>
		/// <exception cref="M3Exception<LstPackagesResponse>"></exception>
		public async Task<M3Response<LstPackagesResponse>> LstPackages(
			string m3_E0IO, 
			int m3_INOU, 
			string m3_TINR, 
			int m3_PACO, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_PACT = null, 
			string m3_PACK = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPackages",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0IO))
				throw new ArgumentNullException("m3_E0IO");
			if (string.IsNullOrWhiteSpace(m3_TINR))
				throw new ArgumentNullException("m3_TINR");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0IO", m3_E0IO.Trim())
				.WithQueryParameter("INOU", m3_INOU.ToString())
				.WithQueryParameter("TINR", m3_TINR.Trim())
				.WithQueryParameter("PACO", m3_PACO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACK))
				request.WithQueryParameter("PACK", m3_PACK.Trim());

			// Execute the request
			var result = await Execute<LstPackagesResponse>(
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
		/// Name LstStatNo
		/// Description List custom statistical information for one TEI Traansfer ID
		/// Version Release: 12.5
		/// </summary>
		/// <param name="m3_E0IO">Message direction (Required)</param>
		/// <param name="m3_INOU">Direction (Required)</param>
		/// <param name="m3_TINR">TEI Transfer ID (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstStatNoResponse></returns>
		/// <exception cref="M3Exception<LstStatNoResponse>"></exception>
		public async Task<M3Response<LstStatNoResponse>> LstStatNo(
			string m3_E0IO, 
			int m3_INOU, 
			string m3_TINR, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstStatNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0IO))
				throw new ArgumentNullException("m3_E0IO");
			if (string.IsNullOrWhiteSpace(m3_TINR))
				throw new ArgumentNullException("m3_TINR");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0IO", m3_E0IO.Trim())
				.WithQueryParameter("INOU", m3_INOU.ToString())
				.WithQueryParameter("TINR", m3_TINR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstStatNoResponse>(
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
