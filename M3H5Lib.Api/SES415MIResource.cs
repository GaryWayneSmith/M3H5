/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3PGNM">Program (Required)</param>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3WORK">Workflow (Required)</param>
		/// <param name="m3USID">Signatory (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSignatory(
			string m3PGNM, 
			string m3FILE, 
			string m3FLDI, 
			int m3WORK, 
			string m3USID, 
			DateTime m3FVDT, 
			DateTime? m3LVDT = null, 
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
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));
			if (string.IsNullOrWhiteSpace(m3USID))
				throw new ArgumentNullException(nameof(m3USID));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim())
				.WithQueryParameter("WORK", m3WORK.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("USID", m3USID.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());

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
		/// Name DltSignatory
		/// Description Delete a signatory
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PGNM">Program (Required)</param>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3USID">Signatory (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3WORK">Workflow</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltSignatory(
			string m3PGNM, 
			string m3FILE, 
			string m3FLDI, 
			string m3USID, 
			DateTime m3FVDT, 
			int? m3WORK = null, 
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
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));
			if (string.IsNullOrWhiteSpace(m3USID))
				throw new ArgumentNullException(nameof(m3USID));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim())
				.WithQueryParameter("USID", m3USID.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3WORK.HasValue)
				request.WithQueryParameter("WORK", m3WORK.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetSignatory
		/// Description Get data for a signatory
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PGNM">Program (Required)</param>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3WORK">Workflow (Required)</param>
		/// <param name="m3USID">Signatory (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSignatoryResponse></returns>
		/// <exception cref="M3Exception<GetSignatoryResponse>"></exception>
		public async Task<M3Response<GetSignatoryResponse>> GetSignatory(
			string m3PGNM, 
			string m3FILE, 
			string m3FLDI, 
			int m3WORK, 
			string m3USID, 
			DateTime m3FVDT, 
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
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));
			if (string.IsNullOrWhiteSpace(m3USID))
				throw new ArgumentNullException(nameof(m3USID));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim())
				.WithQueryParameter("WORK", m3WORK.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("USID", m3USID.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Execute the request
			var result = await Execute<GetSignatoryResponse>(
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
		/// Name LstSignatories
		/// Description List data for Signatories
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PGNM">Program</param>
		/// <param name="m3FILE">File</param>
		/// <param name="m3FLDI">Field</param>
		/// <param name="m3WORK">Workflow</param>
		/// <param name="m3USID">User</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSignatoriesResponse></returns>
		/// <exception cref="M3Exception<LstSignatoriesResponse>"></exception>
		public async Task<M3Response<LstSignatoriesResponse>> LstSignatories(
			string m3PGNM = null, 
			string m3FILE = null, 
			string m3FLDI = null, 
			int? m3WORK = null, 
			string m3USID = null, 
			DateTime? m3FVDT = null, 
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
			if (!string.IsNullOrWhiteSpace(m3PGNM))
				request.WithQueryParameter("PGNM", m3PGNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLDI))
				request.WithQueryParameter("FLDI", m3FLDI.Trim());
			if (m3WORK.HasValue)
				request.WithQueryParameter("WORK", m3WORK.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstSignatoriesResponse>(
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
		/// Name UpdSignatory
		/// Description Update data for a Signatory
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PGNM">Program (Required)</param>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3WORK">Workflow (Required)</param>
		/// <param name="m3USID">Signatory (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSignatory(
			string m3PGNM, 
			string m3FILE, 
			string m3FLDI, 
			int m3WORK, 
			string m3USID, 
			DateTime m3FVDT, 
			DateTime? m3LVDT = null, 
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
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));
			if (string.IsNullOrWhiteSpace(m3USID))
				throw new ArgumentNullException(nameof(m3USID));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim())
				.WithQueryParameter("WORK", m3WORK.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("USID", m3USID.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());

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
