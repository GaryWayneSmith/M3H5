/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.SAS018MI;
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
	/// Name: SAS018MI
	/// Component Name: STR Rates: Contract Item Price
	/// Description: API: STR Rates:Contract Item Price
	/// Version Release: 5e90
	///</summary>
	public partial class SAS018MIResource : M3BaseResourceEndpoint
	{
		public SAS018MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "SAS018MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddServPrcList
		/// Description AddServPrcList
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3PRS1">Price list SO (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3AGRS">Contract item (Required)</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3QTYL">Lowest quantity limit</param>
		/// <param name="m3NTCD">Net price used</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3SACD">Sales price quantity</param>
		/// <param name="m3DIPR">Discount amount per unit</param>
		/// <param name="m3DIPC">Discount</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddServPrcList(
			string m3PRS1, 
			string m3CUCD, 
			DateTime m3STDT, 
			string m3AGRS, 
			string m3CUNO = null, 
			decimal? m3QTYL = null, 
			int? m3NTCD = null, 
			decimal? m3SAPR = null, 
			int? m3SACD = null, 
			decimal? m3DIPR = null, 
			int? m3DIPC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddServPrcList",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRS1))
				throw new ArgumentNullException(nameof(m3PRS1));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3AGRS))
				throw new ArgumentNullException(nameof(m3AGRS));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRS1", m3PRS1.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String())
				.WithQueryParameter("AGRS", m3AGRS.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3QTYL.HasValue)
				request.WithQueryParameter("QTYL", m3QTYL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NTCD.HasValue)
				request.WithQueryParameter("NTCD", m3NTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SACD.HasValue)
				request.WithQueryParameter("SACD", m3SACD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIPR.HasValue)
				request.WithQueryParameter("DIPR", m3DIPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIPC.HasValue)
				request.WithQueryParameter("DIPC", m3DIPC.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelServPrcList
		/// Description DelServPrcList
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3PRS1">Price list SO (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3AGRS">Contract item (Required)</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelServPrcList(
			string m3PRS1, 
			string m3CUCD, 
			DateTime m3STDT, 
			string m3AGRS, 
			string m3CUNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelServPrcList",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRS1))
				throw new ArgumentNullException(nameof(m3PRS1));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3AGRS))
				throw new ArgumentNullException(nameof(m3AGRS));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRS1", m3PRS1.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String())
				.WithQueryParameter("AGRS", m3AGRS.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());

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
		/// Name GetServPrcList
		/// Description GetServPrcList
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3PRS1">Price list SO (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3AGRS">Contract item (Required)</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetServPrcListResponse></returns>
		/// <exception cref="M3Exception<GetServPrcListResponse>"></exception>
		public async Task<M3Response<GetServPrcListResponse>> GetServPrcList(
			string m3PRS1, 
			string m3CUCD, 
			DateTime m3STDT, 
			string m3AGRS, 
			string m3CUNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetServPrcList",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRS1))
				throw new ArgumentNullException(nameof(m3PRS1));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3AGRS))
				throw new ArgumentNullException(nameof(m3AGRS));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRS1", m3PRS1.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String())
				.WithQueryParameter("AGRS", m3AGRS.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Execute the request
			var result = await Execute<GetServPrcListResponse>(
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
		/// Name LstServPrcList
		/// Description LstServPrcList
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3PRS1">Price list SO (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3AGRS">Contract item</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstServPrcListResponse></returns>
		/// <exception cref="M3Exception<LstServPrcListResponse>"></exception>
		public async Task<M3Response<LstServPrcListResponse>> LstServPrcList(
			string m3PRS1, 
			string m3CUCD, 
			DateTime m3STDT, 
			string m3CUNO = null, 
			string m3AGRS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstServPrcList",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRS1))
				throw new ArgumentNullException(nameof(m3PRS1));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRS1", m3PRS1.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGRS))
				request.WithQueryParameter("AGRS", m3AGRS.Trim());

			// Execute the request
			var result = await Execute<LstServPrcListResponse>(
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
		/// Name UpdServPrcList
		/// Description UpdServPrcList
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3PRS1">Price list SO (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3AGRS">Contract item (Required)</param>
		/// <param name="m3QTYL">Lowest quantity limit (Required)</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3NQTY">New lowest quantity limit</param>
		/// <param name="m3NTCD">Net price used</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3SACD">Sales price quantity</param>
		/// <param name="m3DIPR">Discount amount per unit</param>
		/// <param name="m3DIPC">Discount</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdServPrcList(
			string m3PRS1, 
			string m3CUCD, 
			DateTime m3STDT, 
			string m3AGRS, 
			decimal m3QTYL, 
			string m3CUNO = null, 
			decimal? m3NQTY = null, 
			int? m3NTCD = null, 
			decimal? m3SAPR = null, 
			int? m3SACD = null, 
			decimal? m3DIPR = null, 
			int? m3DIPC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdServPrcList",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRS1))
				throw new ArgumentNullException(nameof(m3PRS1));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3AGRS))
				throw new ArgumentNullException(nameof(m3AGRS));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRS1", m3PRS1.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String())
				.WithQueryParameter("AGRS", m3AGRS.Trim())
				.WithQueryParameter("QTYL", m3QTYL.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3NQTY.HasValue)
				request.WithQueryParameter("NQTY", m3NQTY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NTCD.HasValue)
				request.WithQueryParameter("NTCD", m3NTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SACD.HasValue)
				request.WithQueryParameter("SACD", m3SACD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIPR.HasValue)
				request.WithQueryParameter("DIPR", m3DIPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIPC.HasValue)
				request.WithQueryParameter("DIPC", m3DIPC.Value.ToString(CultureInfo.CurrentCulture));

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
	}
}
// EOF
