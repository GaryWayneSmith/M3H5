/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ChgHead
		/// Description Change TEI transfer head
		/// Version Release: 12.5
		/// </summary>
		/// <param name="m3E0IO">Message direction (Required)</param>
		/// <param name="m3INOU">Direction (Required)</param>
		/// <param name="m3TINR">TEI Transfer ID (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3MBDT">Message broker date</param>
		/// <param name="m3MBTM">Message broker time</param>
		/// <param name="m3TRR1">Transaction reference 1</param>
		/// <param name="m3TRR2">Transaction reference 2</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgHead(
			string m3E0IO, 
			int m3INOU, 
			string m3TINR, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3STAT = null, 
			DateTime? m3MBDT = null, 
			int? m3MBTM = null, 
			string m3TRR1 = null, 
			string m3TRR2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0IO))
				throw new ArgumentNullException(nameof(m3E0IO));
			if (string.IsNullOrWhiteSpace(m3TINR))
				throw new ArgumentNullException(nameof(m3TINR));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0IO", m3E0IO.Trim())
				.WithQueryParameter("INOU", m3INOU.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TINR", m3TINR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3MBDT.HasValue)
				request.WithQueryParameter("MBDT", m3MBDT.Value.ToM3String());
			if (m3MBTM.HasValue)
				request.WithQueryParameter("MBTM", m3MBTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TRR1))
				request.WithQueryParameter("TRR1", m3TRR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRR2))
				request.WithQueryParameter("TRR2", m3TRR2.Trim());

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
		/// Name GetHead
		/// Description Get header information
		/// Version Release: 12.5
		/// </summary>
		/// <param name="m3E0IO">Message direction (Required)</param>
		/// <param name="m3INOU">Direction (Required)</param>
		/// <param name="m3TINR">TEI Transfer ID (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadResponse></returns>
		/// <exception cref="M3Exception<GetHeadResponse>"></exception>
		public async Task<M3Response<GetHeadResponse>> GetHead(
			string m3E0IO, 
			int m3INOU, 
			string m3TINR, 
			int? m3CONO = null, 
			string m3DIVI = null, 
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

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0IO))
				throw new ArgumentNullException(nameof(m3E0IO));
			if (string.IsNullOrWhiteSpace(m3TINR))
				throw new ArgumentNullException(nameof(m3TINR));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0IO", m3E0IO.Trim())
				.WithQueryParameter("INOU", m3INOU.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TINR", m3TINR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

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
		/// Name LstDetail
		/// Description Lst Detail information
		/// Version Release: 12.5
		/// </summary>
		/// <param name="m3E0IO">Message direction (Required)</param>
		/// <param name="m3INOU">Direction (Required)</param>
		/// <param name="m3TINR">TEI Transfer ID (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDetailResponse></returns>
		/// <exception cref="M3Exception<LstDetailResponse>"></exception>
		public async Task<M3Response<LstDetailResponse>> LstDetail(
			string m3E0IO, 
			int m3INOU, 
			string m3TINR, 
			int? m3CONO = null, 
			string m3DIVI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0IO))
				throw new ArgumentNullException(nameof(m3E0IO));
			if (string.IsNullOrWhiteSpace(m3TINR))
				throw new ArgumentNullException(nameof(m3TINR));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0IO", m3E0IO.Trim())
				.WithQueryParameter("INOU", m3INOU.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TINR", m3TINR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<LstDetailResponse>(
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
		/// Name LstPackGrp
		/// Description List package groups for one TEI Transfer ID
		/// Version Release: 12.5
		/// </summary>
		/// <param name="m3E0IO">Message direction (Required)</param>
		/// <param name="m3INOU">Direction (Required)</param>
		/// <param name="m3TINR">TEI Transfer ID (Required)</param>
		/// <param name="m3PACO">Package level (Required)</param>
		/// <param name="m3PAGL">Package aggregation level (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPackGrpResponse></returns>
		/// <exception cref="M3Exception<LstPackGrpResponse>"></exception>
		public async Task<M3Response<LstPackGrpResponse>> LstPackGrp(
			string m3E0IO, 
			int m3INOU, 
			string m3TINR, 
			int m3PACO, 
			int m3PAGL, 
			int? m3CONO = null, 
			string m3DIVI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPackGrp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0IO))
				throw new ArgumentNullException(nameof(m3E0IO));
			if (string.IsNullOrWhiteSpace(m3TINR))
				throw new ArgumentNullException(nameof(m3TINR));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0IO", m3E0IO.Trim())
				.WithQueryParameter("INOU", m3INOU.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TINR", m3TINR.Trim())
				.WithQueryParameter("PACO", m3PACO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PAGL", m3PAGL.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<LstPackGrpResponse>(
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
		/// Name LstPackages
		/// Description List packages for one TEI Transfer ID
		/// Version Release: 12.5
		/// </summary>
		/// <param name="m3E0IO">Message direction (Required)</param>
		/// <param name="m3INOU">Direction (Required)</param>
		/// <param name="m3TINR">TEI Transfer ID (Required)</param>
		/// <param name="m3PACO">Package level (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3PACK">Packaging type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPackagesResponse></returns>
		/// <exception cref="M3Exception<LstPackagesResponse>"></exception>
		public async Task<M3Response<LstPackagesResponse>> LstPackages(
			string m3E0IO, 
			int m3INOU, 
			string m3TINR, 
			int m3PACO, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3PACT = null, 
			string m3PACK = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPackages",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0IO))
				throw new ArgumentNullException(nameof(m3E0IO));
			if (string.IsNullOrWhiteSpace(m3TINR))
				throw new ArgumentNullException(nameof(m3TINR));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0IO", m3E0IO.Trim())
				.WithQueryParameter("INOU", m3INOU.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TINR", m3TINR.Trim())
				.WithQueryParameter("PACO", m3PACO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACK))
				request.WithQueryParameter("PACK", m3PACK.Trim());

			// Execute the request
			var result = await Execute<LstPackagesResponse>(
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
		/// Name LstStatNo
		/// Description List custom statistical information for one TEI Traansfer ID
		/// Version Release: 12.5
		/// </summary>
		/// <param name="m3E0IO">Message direction (Required)</param>
		/// <param name="m3INOU">Direction (Required)</param>
		/// <param name="m3TINR">TEI Transfer ID (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstStatNoResponse></returns>
		/// <exception cref="M3Exception<LstStatNoResponse>"></exception>
		public async Task<M3Response<LstStatNoResponse>> LstStatNo(
			string m3E0IO, 
			int m3INOU, 
			string m3TINR, 
			int? m3CONO = null, 
			string m3DIVI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstStatNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0IO))
				throw new ArgumentNullException(nameof(m3E0IO));
			if (string.IsNullOrWhiteSpace(m3TINR))
				throw new ArgumentNullException(nameof(m3TINR));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0IO", m3E0IO.Trim())
				.WithQueryParameter("INOU", m3INOU.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TINR", m3TINR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<LstStatNoResponse>(
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
