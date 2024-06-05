/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddSpecEntity
		/// Description Add Specification entity
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3SPEC">Specification</param>
		/// <param name="m3QSE1">Effective date</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3QMGP">Quality group</param>
		/// <param name="m3ETTP">Entity type</param>
		/// <param name="m3ETID">Entity ID</param>
		/// <param name="m3AUAT">Auto attach</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSpecEntity(
			string m3SPEC = null, 
			DateTime? m3QSE1 = null, 
			int? m3QSE2 = null, 
			string m3ITNO = null, 
			string m3QMGP = null, 
			int? m3ETTP = null, 
			string m3ETID = null, 
			int? m3AUAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddSpecEntity",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SPEC))
				request.WithQueryParameter("SPEC", m3SPEC.Trim());
			if (m3QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3QSE1.Value.ToM3String());
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QMGP))
				request.WithQueryParameter("QMGP", m3QMGP.Trim());
			if (m3ETTP.HasValue)
				request.WithQueryParameter("ETTP", m3ETTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ETID))
				request.WithQueryParameter("ETID", m3ETID.Trim());
			if (m3AUAT.HasValue)
				request.WithQueryParameter("AUAT", m3AUAT.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltSpecEntity
		/// Description Delete Specification Entity
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3SPEC">Specification</param>
		/// <param name="m3QSE1">Effective date</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3QMGP">Quality group</param>
		/// <param name="m3ETTP">Entity type</param>
		/// <param name="m3ETID">Entity ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltSpecEntity(
			string m3SPEC = null, 
			DateTime? m3QSE1 = null, 
			int? m3QSE2 = null, 
			string m3ITNO = null, 
			string m3QMGP = null, 
			int? m3ETTP = null, 
			string m3ETID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltSpecEntity",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SPEC))
				request.WithQueryParameter("SPEC", m3SPEC.Trim());
			if (m3QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3QSE1.Value.ToM3String());
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QMGP))
				request.WithQueryParameter("QMGP", m3QMGP.Trim());
			if (m3ETTP.HasValue)
				request.WithQueryParameter("ETTP", m3ETTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ETID))
				request.WithQueryParameter("ETID", m3ETID.Trim());

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
		/// Name GetSpecEntity
		/// Description Get Specification Entity
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3SPEC">Specification</param>
		/// <param name="m3QSE1">Effective date</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3QMGP">Quality group</param>
		/// <param name="m3ETTP">Entity type</param>
		/// <param name="m3ETID">Entity ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSpecEntityResponse></returns>
		/// <exception cref="M3Exception<GetSpecEntityResponse>"></exception>
		public async Task<M3Response<GetSpecEntityResponse>> GetSpecEntity(
			string m3SPEC = null, 
			DateTime? m3QSE1 = null, 
			int? m3QSE2 = null, 
			string m3ITNO = null, 
			string m3QMGP = null, 
			int? m3ETTP = null, 
			string m3ETID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetSpecEntity",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SPEC))
				request.WithQueryParameter("SPEC", m3SPEC.Trim());
			if (m3QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3QSE1.Value.ToM3String());
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QMGP))
				request.WithQueryParameter("QMGP", m3QMGP.Trim());
			if (m3ETTP.HasValue)
				request.WithQueryParameter("ETTP", m3ETTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ETID))
				request.WithQueryParameter("ETID", m3ETID.Trim());

			// Execute the request
			var result = await Execute<GetSpecEntityResponse>(
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
		/// Name LstSpecEntity
		/// Description Liist Specification Entity
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3SPEC">Specification</param>
		/// <param name="m3QSE1">Effective date</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3QMGP">Quality group</param>
		/// <param name="m3ETTP">Entity type</param>
		/// <param name="m3ETID">Entity ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSpecEntityResponse></returns>
		/// <exception cref="M3Exception<LstSpecEntityResponse>"></exception>
		public async Task<M3Response<LstSpecEntityResponse>> LstSpecEntity(
			string m3SPEC = null, 
			DateTime? m3QSE1 = null, 
			int? m3QSE2 = null, 
			string m3ITNO = null, 
			string m3QMGP = null, 
			int? m3ETTP = null, 
			string m3ETID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstSpecEntity",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SPEC))
				request.WithQueryParameter("SPEC", m3SPEC.Trim());
			if (m3QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3QSE1.Value.ToM3String());
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QMGP))
				request.WithQueryParameter("QMGP", m3QMGP.Trim());
			if (m3ETTP.HasValue)
				request.WithQueryParameter("ETTP", m3ETTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ETID))
				request.WithQueryParameter("ETID", m3ETID.Trim());

			// Execute the request
			var result = await Execute<LstSpecEntityResponse>(
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
		/// Name UpdSpecEntity
		/// Description Update Specification Entity
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3SPEC">Specification</param>
		/// <param name="m3QSE1">Effective date</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3QMGP">Quality group</param>
		/// <param name="m3ETTP">Entity type</param>
		/// <param name="m3ETID">Entity ID</param>
		/// <param name="m3AUAT">Auto attach</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSpecEntity(
			string m3SPEC = null, 
			DateTime? m3QSE1 = null, 
			int? m3QSE2 = null, 
			string m3ITNO = null, 
			string m3QMGP = null, 
			int? m3ETTP = null, 
			string m3ETID = null, 
			int? m3AUAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdSpecEntity",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SPEC))
				request.WithQueryParameter("SPEC", m3SPEC.Trim());
			if (m3QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3QSE1.Value.ToM3String());
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QMGP))
				request.WithQueryParameter("QMGP", m3QMGP.Trim());
			if (m3ETTP.HasValue)
				request.WithQueryParameter("ETTP", m3ETTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ETID))
				request.WithQueryParameter("ETID", m3ETID.Trim());
			if (m3AUAT.HasValue)
				request.WithQueryParameter("AUAT", m3AUAT.Value.ToString(CultureInfo.CurrentCulture));

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
