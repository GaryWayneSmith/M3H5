/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.QMS150MI;
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
	/// Name: QMS150MI
	/// Component Name: Set
	/// Description: Set interface
	/// Version Release: 5e90
	///</summary>
	public partial class QMS150MIResource : M3BaseResourceEndpoint
	{
		public QMS150MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QMS150MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddSet
		/// Description Add set
		/// Version Release: 
		/// </summary>
		/// <param name="m3_QSET">Set (Required)</param>
		/// <param name="m3_QTST">Test (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSet(
			string m3_QSET, 
			string m3_QTST, 
			string m3_TX40, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_QSET))
				throw new ArgumentNullException("m3_QSET");
			if (string.IsNullOrWhiteSpace(m3_QTST))
				throw new ArgumentNullException("m3_QTST");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("QSET", m3_QSET.Trim())
				.WithQueryParameter("QTST", m3_QTST.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim());

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
		/// Name DltSet
		/// Description Delete set
		/// Version Release: 
		/// </summary>
		/// <param name="m3_QSET">Set (Required)</param>
		/// <param name="m3_QTST">Test (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltSet(
			string m3_QSET, 
			string m3_QTST, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltSet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_QSET))
				throw new ArgumentNullException("m3_QSET");
			if (string.IsNullOrWhiteSpace(m3_QTST))
				throw new ArgumentNullException("m3_QTST");

			// Set mandatory parameters
			request
				.WithQueryParameter("QSET", m3_QSET.Trim())
				.WithQueryParameter("QTST", m3_QTST.Trim());

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
		/// Name GetSet
		/// Description Get set
		/// Version Release: 
		/// </summary>
		/// <param name="m3_QSET">Set (Required)</param>
		/// <param name="m3_QTST">Test (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSetResponse></returns>
		/// <exception cref="M3Exception<GetSetResponse>"></exception>
		public async Task<M3Response<GetSetResponse>> GetSet(
			string m3_QSET, 
			string m3_QTST, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_QSET))
				throw new ArgumentNullException("m3_QSET");
			if (string.IsNullOrWhiteSpace(m3_QTST))
				throw new ArgumentNullException("m3_QTST");

			// Set mandatory parameters
			request
				.WithQueryParameter("QSET", m3_QSET.Trim())
				.WithQueryParameter("QTST", m3_QTST.Trim());

			// Execute the request
			var result = await Execute<GetSetResponse>(
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
		/// Name LstSet
		/// Description List set
		/// Version Release: 
		/// </summary>
		/// <param name="m3_QSET">Set (Required)</param>
		/// <param name="m3_QTST">Test (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSetResponse></returns>
		/// <exception cref="M3Exception<LstSetResponse>"></exception>
		public async Task<M3Response<LstSetResponse>> LstSet(
			string m3_QSET, 
			string m3_QTST, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_QSET))
				throw new ArgumentNullException("m3_QSET");
			if (string.IsNullOrWhiteSpace(m3_QTST))
				throw new ArgumentNullException("m3_QTST");

			// Set mandatory parameters
			request
				.WithQueryParameter("QSET", m3_QSET.Trim())
				.WithQueryParameter("QTST", m3_QTST.Trim());

			// Execute the request
			var result = await Execute<LstSetResponse>(
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
		/// Name UpdSet
		/// Description Update set
		/// Version Release: 
		/// </summary>
		/// <param name="m3_QSET">Set (Required)</param>
		/// <param name="m3_QTST">Test (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSet(
			string m3_QSET, 
			string m3_QTST, 
			string m3_TX40, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdSet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_QSET))
				throw new ArgumentNullException("m3_QSET");
			if (string.IsNullOrWhiteSpace(m3_QTST))
				throw new ArgumentNullException("m3_QTST");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("QSET", m3_QSET.Trim())
				.WithQueryParameter("QTST", m3_QTST.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim());

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
	}
}
// EOF
