/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3SQNR">Sequence number (Required)</param>
		/// <param name="m3ISEC">Infor standard entity code (Required)</param>
		/// <param name="m3PGNM">Program name</param>
		/// <param name="m3VFLD">Validate field name</param>
		/// <param name="m3VFVA">Validate field value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddEntityMap(
			string m3FLDI, 
			int m3SQNR, 
			string m3ISEC, 
			string m3PGNM = null, 
			string m3VFLD = null, 
			string m3VFVA = null, 
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
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));
			if (string.IsNullOrWhiteSpace(m3ISEC))
				throw new ArgumentNullException(nameof(m3ISEC));

			// Set mandatory parameters
			request
				.WithQueryParameter("FLDI", m3FLDI.Trim())
				.WithQueryParameter("SQNR", m3SQNR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ISEC", m3ISEC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PGNM))
				request.WithQueryParameter("PGNM", m3PGNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3VFLD))
				request.WithQueryParameter("VFLD", m3VFLD.Trim());
			if (!string.IsNullOrWhiteSpace(m3VFVA))
				request.WithQueryParameter("VFVA", m3VFVA.Trim());

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
		/// Name DelEntityMap
		/// Description Delete entity map
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3SQNR">Sequence number (Required)</param>
		/// <param name="m3PGNM">Program name</param>
		/// <param name="m3VFLD">Validate field name</param>
		/// <param name="m3VFVA">Validate field value</param>
		/// <param name="m3ISEC">Infor standard entity code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelEntityMap(
			string m3FLDI, 
			int m3SQNR, 
			string m3PGNM = null, 
			string m3VFLD = null, 
			string m3VFVA = null, 
			string m3ISEC = null, 
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
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FLDI", m3FLDI.Trim())
				.WithQueryParameter("SQNR", m3SQNR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PGNM))
				request.WithQueryParameter("PGNM", m3PGNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3VFLD))
				request.WithQueryParameter("VFLD", m3VFLD.Trim());
			if (!string.IsNullOrWhiteSpace(m3VFVA))
				request.WithQueryParameter("VFVA", m3VFVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3ISEC))
				request.WithQueryParameter("ISEC", m3ISEC.Trim());

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
		/// Name GetEntityMap
		/// Description Get an entity map
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3SQNR">Sequence number (Required)</param>
		/// <param name="m3PGNM">Program name</param>
		/// <param name="m3VFLD">Validate field name</param>
		/// <param name="m3VFVA">Validate field value</param>
		/// <param name="m3ISEC">Infor standard entity code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetEntityMapResponse></returns>
		/// <exception cref="M3Exception<GetEntityMapResponse>"></exception>
		public async Task<M3Response<GetEntityMapResponse>> GetEntityMap(
			string m3FLDI, 
			int m3SQNR, 
			string m3PGNM = null, 
			string m3VFLD = null, 
			string m3VFVA = null, 
			string m3ISEC = null, 
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
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FLDI", m3FLDI.Trim())
				.WithQueryParameter("SQNR", m3SQNR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PGNM))
				request.WithQueryParameter("PGNM", m3PGNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3VFLD))
				request.WithQueryParameter("VFLD", m3VFLD.Trim());
			if (!string.IsNullOrWhiteSpace(m3VFVA))
				request.WithQueryParameter("VFVA", m3VFVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3ISEC))
				request.WithQueryParameter("ISEC", m3ISEC.Trim());

			// Execute the request
			var result = await Execute<GetEntityMapResponse>(
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
		/// Name LstByEntity
		/// Description List by entity
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3ISEC">Infor standard entity code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByEntityResponse></returns>
		/// <exception cref="M3Exception<LstByEntityResponse>"></exception>
		public async Task<M3Response<LstByEntityResponse>> LstByEntity(
			string m3ISEC = null, 
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
			if (!string.IsNullOrWhiteSpace(m3ISEC))
				request.WithQueryParameter("ISEC", m3ISEC.Trim());

			// Execute the request
			var result = await Execute<LstByEntityResponse>(
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
		/// Name LstByField
		/// Description List by field
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3FLDI">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByFieldResponse></returns>
		/// <exception cref="M3Exception<LstByFieldResponse>"></exception>
		public async Task<M3Response<LstByFieldResponse>> LstByField(
			string m3FLDI = null, 
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
			if (!string.IsNullOrWhiteSpace(m3FLDI))
				request.WithQueryParameter("FLDI", m3FLDI.Trim());

			// Execute the request
			var result = await Execute<LstByFieldResponse>(
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
		/// Name UpdEntityMap
		/// Description Update existing Entity map
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3SQNR">Sequence number (Required)</param>
		/// <param name="m3PGNM">Program name</param>
		/// <param name="m3VFLD">Validate field name</param>
		/// <param name="m3VFVA">Validate field value</param>
		/// <param name="m3ISEC">Infor standard entity code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdEntityMap(
			string m3FLDI, 
			int m3SQNR, 
			string m3PGNM = null, 
			string m3VFLD = null, 
			string m3VFVA = null, 
			string m3ISEC = null, 
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
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FLDI", m3FLDI.Trim())
				.WithQueryParameter("SQNR", m3SQNR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PGNM))
				request.WithQueryParameter("PGNM", m3PGNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3VFLD))
				request.WithQueryParameter("VFLD", m3VFLD.Trim());
			if (!string.IsNullOrWhiteSpace(m3VFVA))
				request.WithQueryParameter("VFVA", m3VFVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3ISEC))
				request.WithQueryParameter("ISEC", m3ISEC.Trim());

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
