/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.SES415MI;
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
	/// Name: SES415MI
	/// Component Name: Signatory
	/// Description: eSign Object. connect Signatory interface
	/// Version Release: 5ea0
	///</summary>
	public partial class SES415MIResource : M3BaseResourceEndpoint
	{
		public SES415MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "SES415MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddSignatory
		/// Description Add a signatory
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PGNM">Program (Required)</param>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_WORK">Workflow (Required)</param>
		/// <param name="m3_USID">Signatory (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSignatory(
			string m3_PGNM, 
			string m3_FILE, 
			string m3_FLDI, 
			int m3_WORK, 
			string m3_USID, 
			DateTime m3_FVDT, 
			DateTime? m3_LVDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSignatory",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim())
				.WithQueryParameter("WORK", m3_WORK.ToString())
				.WithQueryParameter("USID", m3_USID.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());

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
		/// Name DltSignatory
		/// Description Delete a signatory
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PGNM">Program (Required)</param>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_USID">Signatory (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_WORK">Workflow</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltSignatory(
			string m3_PGNM, 
			string m3_FILE, 
			string m3_FLDI, 
			string m3_USID, 
			DateTime m3_FVDT, 
			int? m3_WORK = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltSignatory",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim())
				.WithQueryParameter("USID", m3_USID.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_WORK.HasValue)
				request.WithQueryParameter("WORK", m3_WORK.Value.ToString());

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
		/// Name GetSignatory
		/// Description Get data for a signatory
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PGNM">Program (Required)</param>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_WORK">Workflow (Required)</param>
		/// <param name="m3_USID">Signatory (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSignatoryResponse></returns>
		/// <exception cref="M3Exception<GetSignatoryResponse>"></exception>
		public async Task<M3Response<GetSignatoryResponse>> GetSignatory(
			string m3_PGNM, 
			string m3_FILE, 
			string m3_FLDI, 
			int m3_WORK, 
			string m3_USID, 
			DateTime m3_FVDT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSignatory",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim())
				.WithQueryParameter("WORK", m3_WORK.ToString())
				.WithQueryParameter("USID", m3_USID.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Execute the request
			var result = await Execute<GetSignatoryResponse>(
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
		/// Name LstSignatories
		/// Description List data for Signatories
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PGNM">Program</param>
		/// <param name="m3_FILE">File</param>
		/// <param name="m3_FLDI">Field</param>
		/// <param name="m3_WORK">Workflow</param>
		/// <param name="m3_USID">User</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSignatoriesResponse></returns>
		/// <exception cref="M3Exception<LstSignatoriesResponse>"></exception>
		public async Task<M3Response<LstSignatoriesResponse>> LstSignatories(
			string m3_PGNM = null, 
			string m3_FILE = null, 
			string m3_FLDI = null, 
			int? m3_WORK = null, 
			string m3_USID = null, 
			DateTime? m3_FVDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSignatories",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PGNM))
				request.WithQueryParameter("PGNM", m3_PGNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLDI))
				request.WithQueryParameter("FLDI", m3_FLDI.Trim());
			if (m3_WORK.HasValue)
				request.WithQueryParameter("WORK", m3_WORK.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstSignatoriesResponse>(
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
		/// Name UpdSignatory
		/// Description Update data for a Signatory
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PGNM">Program (Required)</param>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_WORK">Workflow (Required)</param>
		/// <param name="m3_USID">Signatory (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSignatory(
			string m3_PGNM, 
			string m3_FILE, 
			string m3_FLDI, 
			int m3_WORK, 
			string m3_USID, 
			DateTime m3_FVDT, 
			DateTime? m3_LVDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdSignatory",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim())
				.WithQueryParameter("WORK", m3_WORK.ToString())
				.WithQueryParameter("USID", m3_USID.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());

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
