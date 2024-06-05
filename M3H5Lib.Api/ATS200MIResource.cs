/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.ATS200MI;
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
	/// Name: ATS200MI
	/// Component Name: Additional Information
	/// Description: Additional Information interface
	/// Version Release: 5ea0
	///</summary>
	public partial class ATS200MIResource : M3BaseResourceEndpoint
	{
		public ATS200MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "ATS200MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAddInf
		/// Description Add additional information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3IFGR">Information group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAddInf(
			string m3ORCA = null, 
			string m3RIDN = null, 
			string m3IFGR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddAddInf",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (!string.IsNullOrWhiteSpace(m3IFGR))
				request.WithQueryParameter("IFGR", m3IFGR.Trim());

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
		/// Name CopyAddInf
		/// Description Copy additional information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RID2">Order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CopyAddInf(
			string m3ORCA = null, 
			string m3RIDN = null, 
			string m3RID2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CopyAddInf",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (!string.IsNullOrWhiteSpace(m3RID2))
				request.WithQueryParameter("RID2", m3RID2.Trim());

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
		/// Name DltAddInf
		/// Description Delete additional information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3IFGR">Information group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAddInf(
			string m3ORCA = null, 
			string m3RIDN = null, 
			string m3IFGR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltAddInf",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (!string.IsNullOrWhiteSpace(m3IFGR))
				request.WithQueryParameter("IFGR", m3IFGR.Trim());

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
		/// Name LstAddInfo
		/// Description List Additional Information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3IFGR">Info group</param>
		/// <param name="m3SALV">Search all levels</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAddInfoResponse></returns>
		/// <exception cref="M3Exception<LstAddInfoResponse>"></exception>
		public async Task<M3Response<LstAddInfoResponse>> LstAddInfo(
			string m3ORCA = null, 
			string m3RIDN = null, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
			string m3IFGR = null, 
			int? m3SALV = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAddInfo",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3IFGR))
				request.WithQueryParameter("IFGR", m3IFGR.Trim());
			if (m3SALV.HasValue)
				request.WithQueryParameter("SALV", m3SALV.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAddInfoResponse>(
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
