/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.OIS175MI;
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
	/// Name: OIS175MI
	/// Component Name: CustomerOrderInquiry
	/// Description: Customer order inquiry interface
	/// Version Release: 5ea0
	///</summary>
	public partial class OIS175MIResource : M3BaseResourceEndpoint
	{
		public OIS175MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS175MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstBySortOption
		/// Description List by user-defined sorting option.
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SOPT">Sorting option</param>
		/// <param name="m3CDNO">Day number YYYYNNN</param>
		/// <param name="m3ORSL">Lowest status - customer order</param>
		/// <param name="m3ORST">Highest status - customer order</param>
		/// <param name="m3PREV">Previous reading</param>
		/// <param name="m3NFTR">Number of filters</param>
		/// <param name="m3OBK1">Key value 1 for filter</param>
		/// <param name="m3OBK2">Key value 2 for filter</param>
		/// <param name="m3OBK3">Key value 3 for filter</param>
		/// <param name="m3OBK4">Key value 4 for filter</param>
		/// <param name="m3OBK5">Key value 5 for filter</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBySortOptionResponse></returns>
		/// <exception cref="M3Exception<LstBySortOptionResponse>"></exception>
		public async Task<M3Response<LstBySortOptionResponse>> LstBySortOption(
			string m3CUNO, 
			int? m3CONO = null, 
			string m3SOPT = null, 
			int? m3CDNO = null, 
			string m3ORSL = null, 
			string m3ORST = null, 
			string m3PREV = null, 
			int? m3NFTR = null, 
			string m3OBK1 = null, 
			string m3OBK2 = null, 
			string m3OBK3 = null, 
			string m3OBK4 = null, 
			string m3OBK5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBySortOption",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SOPT))
				request.WithQueryParameter("SOPT", m3SOPT.Trim());
			if (m3CDNO.HasValue)
				request.WithQueryParameter("CDNO", m3CDNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORSL))
				request.WithQueryParameter("ORSL", m3ORSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORST))
				request.WithQueryParameter("ORST", m3ORST.Trim());
			if (!string.IsNullOrWhiteSpace(m3PREV))
				request.WithQueryParameter("PREV", m3PREV.Trim());
			if (m3NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3NFTR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OBK1))
				request.WithQueryParameter("OBK1", m3OBK1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBK2))
				request.WithQueryParameter("OBK2", m3OBK2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBK3))
				request.WithQueryParameter("OBK3", m3OBK3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBK4))
				request.WithQueryParameter("OBK4", m3OBK4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBK5))
				request.WithQueryParameter("OBK5", m3OBK5.Trim());

			// Execute the request
			var result = await Execute<LstBySortOptionResponse>(
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
		/// Name LstHeadByCust
		/// Description List head by customer order numbers
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3ORSL">Lowest status - customer order</param>
		/// <param name="m3ORST">Highest status - customer order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadByCustResponse></returns>
		/// <exception cref="M3Exception<LstHeadByCustResponse>"></exception>
		public async Task<M3Response<LstHeadByCustResponse>> LstHeadByCust(
			int? m3CONO = null, 
			string m3CUNO = null, 
			string m3ORSL = null, 
			string m3ORST = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstHeadByCust",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORSL))
				request.WithQueryParameter("ORSL", m3ORSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORST))
				request.WithQueryParameter("ORST", m3ORST.Trim());

			// Execute the request
			var result = await Execute<LstHeadByCustResponse>(
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
		/// Name LstHeadByDate
		/// Description List by order date
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3ORDT">Order date</param>
		/// <param name="m3ORSL">Lowest status - customer order</param>
		/// <param name="m3ORST">Highest status - customer order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadByDateResponse></returns>
		/// <exception cref="M3Exception<LstHeadByDateResponse>"></exception>
		public async Task<M3Response<LstHeadByDateResponse>> LstHeadByDate(
			int? m3CONO = null, 
			string m3CUNO = null, 
			DateTime? m3ORDT = null, 
			string m3ORSL = null, 
			string m3ORST = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstHeadByDate",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3ORDT.HasValue)
				request.WithQueryParameter("ORDT", m3ORDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ORSL))
				request.WithQueryParameter("ORSL", m3ORSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORST))
				request.WithQueryParameter("ORST", m3ORST.Trim());

			// Execute the request
			var result = await Execute<LstHeadByDateResponse>(
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
		/// Name LstHeadByRef
		/// Description List by your reference
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3ORSL">Lowest status - customer order</param>
		/// <param name="m3ORST">Highest status - customer order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadByRefResponse></returns>
		/// <exception cref="M3Exception<LstHeadByRefResponse>"></exception>
		public async Task<M3Response<LstHeadByRefResponse>> LstHeadByRef(
			int? m3CONO = null, 
			string m3CUNO = null, 
			string m3YREF = null, 
			string m3ORSL = null, 
			string m3ORST = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstHeadByRef",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORSL))
				request.WithQueryParameter("ORSL", m3ORSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORST))
				request.WithQueryParameter("ORST", m3ORST.Trim());

			// Execute the request
			var result = await Execute<LstHeadByRefResponse>(
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
		/// Name LstSortOptions
		/// Description List sorting options
		/// Version Release: 14.x
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSortOptionsResponse></returns>
		/// <exception cref="M3Exception<LstSortOptionsResponse>"></exception>
		public async Task<M3Response<LstSortOptionsResponse>> LstSortOptions(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSortOptions",
			};

			// Execute the request
			var result = await Execute<LstSortOptionsResponse>(
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
		/// Name SearchCOHead
		/// Description Search customer orders via LES
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchCOHeadResponse></returns>
		/// <exception cref="M3Exception<SearchCOHeadResponse>"></exception>
		public async Task<M3Response<SearchCOHeadResponse>> SearchCOHead(
			string m3SQRY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchCOHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SQRY))
				throw new ArgumentNullException(nameof(m3SQRY));

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchCOHeadResponse>(
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
		/// Name SearchCOLine
		/// Description Search customer order lines via LES
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchCOLineResponse></returns>
		/// <exception cref="M3Exception<SearchCOLineResponse>"></exception>
		public async Task<M3Response<SearchCOLineResponse>> SearchCOLine(
			string m3SQRY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchCOLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SQRY))
				throw new ArgumentNullException(nameof(m3SQRY));

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchCOLineResponse>(
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
