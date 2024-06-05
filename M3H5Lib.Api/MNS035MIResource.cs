/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MNS035MI;
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
	/// Name: MNS035MI
	/// Component Name: WorkSpaceEntities
	/// Description: Workspace entities
	/// Version Release: 15.1
	///</summary>
	public partial class MNS035MIResource : M3BaseResourceEndpoint
	{
		public MNS035MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MNS035MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddEntityMap
		/// Description Add entity map
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_SQNR">Sequence number (Required)</param>
		/// <param name="m3_ISEC">Infor standard entity code (Required)</param>
		/// <param name="m3_PGNM">Program name</param>
		/// <param name="m3_VFLD">Validate field name</param>
		/// <param name="m3_VFVA">Validate field value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddEntityMap(
			string m3_FLDI, 
			int m3_SQNR, 
			string m3_ISEC, 
			string m3_PGNM = null, 
			string m3_VFLD = null, 
			string m3_VFVA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddEntityMap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");
			if (string.IsNullOrWhiteSpace(m3_ISEC))
				throw new ArgumentNullException("m3_ISEC");

			// Set mandatory parameters
			request
				.WithQueryParameter("FLDI", m3_FLDI.Trim())
				.WithQueryParameter("SQNR", m3_SQNR.ToString())
				.WithQueryParameter("ISEC", m3_ISEC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PGNM))
				request.WithQueryParameter("PGNM", m3_PGNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VFLD))
				request.WithQueryParameter("VFLD", m3_VFLD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VFVA))
				request.WithQueryParameter("VFVA", m3_VFVA.Trim());

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
		/// Name DelEntityMap
		/// Description Delete entity map
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_SQNR">Sequence number (Required)</param>
		/// <param name="m3_PGNM">Program name</param>
		/// <param name="m3_VFLD">Validate field name</param>
		/// <param name="m3_VFVA">Validate field value</param>
		/// <param name="m3_ISEC">Infor standard entity code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelEntityMap(
			string m3_FLDI, 
			int m3_SQNR, 
			string m3_PGNM = null, 
			string m3_VFLD = null, 
			string m3_VFVA = null, 
			string m3_ISEC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelEntityMap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FLDI", m3_FLDI.Trim())
				.WithQueryParameter("SQNR", m3_SQNR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PGNM))
				request.WithQueryParameter("PGNM", m3_PGNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VFLD))
				request.WithQueryParameter("VFLD", m3_VFLD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VFVA))
				request.WithQueryParameter("VFVA", m3_VFVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ISEC))
				request.WithQueryParameter("ISEC", m3_ISEC.Trim());

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
		/// Name GetEntityMap
		/// Description Get an entity map
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_SQNR">Sequence number (Required)</param>
		/// <param name="m3_PGNM">Program name</param>
		/// <param name="m3_VFLD">Validate field name</param>
		/// <param name="m3_VFVA">Validate field value</param>
		/// <param name="m3_ISEC">Infor standard entity code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetEntityMapResponse></returns>
		/// <exception cref="M3Exception<GetEntityMapResponse>"></exception>
		public async Task<M3Response<GetEntityMapResponse>> GetEntityMap(
			string m3_FLDI, 
			int m3_SQNR, 
			string m3_PGNM = null, 
			string m3_VFLD = null, 
			string m3_VFVA = null, 
			string m3_ISEC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetEntityMap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FLDI", m3_FLDI.Trim())
				.WithQueryParameter("SQNR", m3_SQNR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PGNM))
				request.WithQueryParameter("PGNM", m3_PGNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VFLD))
				request.WithQueryParameter("VFLD", m3_VFLD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VFVA))
				request.WithQueryParameter("VFVA", m3_VFVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ISEC))
				request.WithQueryParameter("ISEC", m3_ISEC.Trim());

			// Execute the request
			var result = await Execute<GetEntityMapResponse>(
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
		/// Name LstByEntity
		/// Description List by entity
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_ISEC">Infor standard entity code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByEntityResponse></returns>
		/// <exception cref="M3Exception<LstByEntityResponse>"></exception>
		public async Task<M3Response<LstByEntityResponse>> LstByEntity(
			string m3_ISEC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByEntity",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ISEC))
				request.WithQueryParameter("ISEC", m3_ISEC.Trim());

			// Execute the request
			var result = await Execute<LstByEntityResponse>(
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
		/// Name LstByField
		/// Description List by field
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_FLDI">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByFieldResponse></returns>
		/// <exception cref="M3Exception<LstByFieldResponse>"></exception>
		public async Task<M3Response<LstByFieldResponse>> LstByField(
			string m3_FLDI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByField",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FLDI))
				request.WithQueryParameter("FLDI", m3_FLDI.Trim());

			// Execute the request
			var result = await Execute<LstByFieldResponse>(
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
		/// Name UpdEntityMap
		/// Description Update existing Entity map
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_SQNR">Sequence number (Required)</param>
		/// <param name="m3_PGNM">Program name</param>
		/// <param name="m3_VFLD">Validate field name</param>
		/// <param name="m3_VFVA">Validate field value</param>
		/// <param name="m3_ISEC">Infor standard entity code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdEntityMap(
			string m3_FLDI, 
			int m3_SQNR, 
			string m3_PGNM = null, 
			string m3_VFLD = null, 
			string m3_VFVA = null, 
			string m3_ISEC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdEntityMap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FLDI", m3_FLDI.Trim())
				.WithQueryParameter("SQNR", m3_SQNR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PGNM))
				request.WithQueryParameter("PGNM", m3_PGNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VFLD))
				request.WithQueryParameter("VFLD", m3_VFLD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VFVA))
				request.WithQueryParameter("VFVA", m3_VFVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ISEC))
				request.WithQueryParameter("ISEC", m3_ISEC.Trim());

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
