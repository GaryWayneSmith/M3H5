/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.QMS210MI;
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
	/// Name: QMS210MI
	/// Component Name: Specification entities
	/// Description: Api: Specification entities Interface
	/// Version Release: 5ea0
	///</summary>
	public partial class QMS210MIResource : M3BaseResourceEndpoint
	{
		public QMS210MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QMS210MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddSpecEntity
		/// Description Add Specification entity
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_QMGP">Quality group</param>
		/// <param name="m3_ETTP">Entity type</param>
		/// <param name="m3_ETID">Entity ID</param>
		/// <param name="m3_AUAT">Auto attach</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSpecEntity(
			string m3_SPEC = null, 
			DateTime? m3_QSE1 = null, 
			int? m3_QSE2 = null, 
			string m3_ITNO = null, 
			string m3_QMGP = null, 
			int? m3_ETTP = null, 
			string m3_ETID = null, 
			int? m3_AUAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSpecEntity",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QMGP))
				request.WithQueryParameter("QMGP", m3_QMGP.Trim());
			if (m3_ETTP.HasValue)
				request.WithQueryParameter("ETTP", m3_ETTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ETID))
				request.WithQueryParameter("ETID", m3_ETID.Trim());
			if (m3_AUAT.HasValue)
				request.WithQueryParameter("AUAT", m3_AUAT.Value.ToString());

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
		/// Name DltSpecEntity
		/// Description Delete Specification Entity
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_QMGP">Quality group</param>
		/// <param name="m3_ETTP">Entity type</param>
		/// <param name="m3_ETID">Entity ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltSpecEntity(
			string m3_SPEC = null, 
			DateTime? m3_QSE1 = null, 
			int? m3_QSE2 = null, 
			string m3_ITNO = null, 
			string m3_QMGP = null, 
			int? m3_ETTP = null, 
			string m3_ETID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltSpecEntity",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QMGP))
				request.WithQueryParameter("QMGP", m3_QMGP.Trim());
			if (m3_ETTP.HasValue)
				request.WithQueryParameter("ETTP", m3_ETTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ETID))
				request.WithQueryParameter("ETID", m3_ETID.Trim());

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
		/// Name GetSpecEntity
		/// Description Get Specification Entity
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_QMGP">Quality group</param>
		/// <param name="m3_ETTP">Entity type</param>
		/// <param name="m3_ETID">Entity ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSpecEntityResponse></returns>
		/// <exception cref="M3Exception<GetSpecEntityResponse>"></exception>
		public async Task<M3Response<GetSpecEntityResponse>> GetSpecEntity(
			string m3_SPEC = null, 
			DateTime? m3_QSE1 = null, 
			int? m3_QSE2 = null, 
			string m3_ITNO = null, 
			string m3_QMGP = null, 
			int? m3_ETTP = null, 
			string m3_ETID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSpecEntity",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QMGP))
				request.WithQueryParameter("QMGP", m3_QMGP.Trim());
			if (m3_ETTP.HasValue)
				request.WithQueryParameter("ETTP", m3_ETTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ETID))
				request.WithQueryParameter("ETID", m3_ETID.Trim());

			// Execute the request
			var result = await Execute<GetSpecEntityResponse>(
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
		/// Name LstSpecEntity
		/// Description Liist Specification Entity
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_QMGP">Quality group</param>
		/// <param name="m3_ETTP">Entity type</param>
		/// <param name="m3_ETID">Entity ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSpecEntityResponse></returns>
		/// <exception cref="M3Exception<LstSpecEntityResponse>"></exception>
		public async Task<M3Response<LstSpecEntityResponse>> LstSpecEntity(
			string m3_SPEC = null, 
			DateTime? m3_QSE1 = null, 
			int? m3_QSE2 = null, 
			string m3_ITNO = null, 
			string m3_QMGP = null, 
			int? m3_ETTP = null, 
			string m3_ETID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSpecEntity",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QMGP))
				request.WithQueryParameter("QMGP", m3_QMGP.Trim());
			if (m3_ETTP.HasValue)
				request.WithQueryParameter("ETTP", m3_ETTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ETID))
				request.WithQueryParameter("ETID", m3_ETID.Trim());

			// Execute the request
			var result = await Execute<LstSpecEntityResponse>(
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
		/// Name UpdSpecEntity
		/// Description Update Specification Entity
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_QMGP">Quality group</param>
		/// <param name="m3_ETTP">Entity type</param>
		/// <param name="m3_ETID">Entity ID</param>
		/// <param name="m3_AUAT">Auto attach</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSpecEntity(
			string m3_SPEC = null, 
			DateTime? m3_QSE1 = null, 
			int? m3_QSE2 = null, 
			string m3_ITNO = null, 
			string m3_QMGP = null, 
			int? m3_ETTP = null, 
			string m3_ETID = null, 
			int? m3_AUAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdSpecEntity",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QMGP))
				request.WithQueryParameter("QMGP", m3_QMGP.Trim());
			if (m3_ETTP.HasValue)
				request.WithQueryParameter("ETTP", m3_ETTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ETID))
				request.WithQueryParameter("ETID", m3_ETID.Trim());
			if (m3_AUAT.HasValue)
				request.WithQueryParameter("AUAT", m3_AUAT.Value.ToString());

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
