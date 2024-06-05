/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.CMS470MI;
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
	/// Name: CMS470MI
	/// Component Name: Custom fields
	/// Description: Custom fields
	/// Version Release: 5ea0
	///</summary>
	public partial class CMS470MIResource : M3BaseResourceEndpoint
	{
		public CMS470MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS470MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddCustomField
		/// Description Add custom field
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CFMF">Custom field (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3FLDM">Field type (Required)</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3CFML">Heading - custom field</param>
		/// <param name="m3FLDB">Field length</param>
		/// <param name="m3DCCD">Number of decimal places</param>
		/// <param name="m3MES0">Meter</param>
		/// <param name="m3FLCT">Field category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCustomField(
			string m3CFMF, 
			string m3TX40, 
			string m3FLDM, 
			string m3TX15 = null, 
			string m3CFML = null, 
			int? m3FLDB = null, 
			int? m3DCCD = null, 
			string m3MES0 = null, 
			int? m3FLCT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddCustomField",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CFMF))
				throw new ArgumentNullException(nameof(m3CFMF));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));
			if (string.IsNullOrWhiteSpace(m3FLDM))
				throw new ArgumentNullException(nameof(m3FLDM));

			// Set mandatory parameters
			request
				.WithQueryParameter("CFMF", m3CFMF.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim())
				.WithQueryParameter("FLDM", m3FLDM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFML))
				request.WithQueryParameter("CFML", m3CFML.Trim());
			if (m3FLDB.HasValue)
				request.WithQueryParameter("FLDB", m3FLDB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3DCCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MES0))
				request.WithQueryParameter("MES0", m3MES0.Trim());
			if (m3FLCT.HasValue)
				request.WithQueryParameter("FLCT", m3FLCT.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltCustomField
		/// Description Delete custom field
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CFMF">Custom field (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltCustomField(
			string m3CFMF, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltCustomField",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CFMF))
				throw new ArgumentNullException(nameof(m3CFMF));

			// Set mandatory parameters
			request
				.WithQueryParameter("CFMF", m3CFMF.Trim());

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
		/// Name GetCustomField
		/// Description Get custom field
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CFMF">Custom field (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCustomFieldResponse></returns>
		/// <exception cref="M3Exception<GetCustomFieldResponse>"></exception>
		public async Task<M3Response<GetCustomFieldResponse>> GetCustomField(
			string m3CFMF, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetCustomField",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CFMF))
				throw new ArgumentNullException(nameof(m3CFMF));

			// Set mandatory parameters
			request
				.WithQueryParameter("CFMF", m3CFMF.Trim());

			// Execute the request
			var result = await Execute<GetCustomFieldResponse>(
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
		/// Name LstCustomField
		/// Description List custom field
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CFMF">Custom field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCustomFieldResponse></returns>
		/// <exception cref="M3Exception<LstCustomFieldResponse>"></exception>
		public async Task<M3Response<LstCustomFieldResponse>> LstCustomField(
			string m3CFMF = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstCustomField",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CFMF))
				request.WithQueryParameter("CFMF", m3CFMF.Trim());

			// Execute the request
			var result = await Execute<LstCustomFieldResponse>(
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
		/// Name UpdCustomField
		/// Description Update custom field
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CFMF">Custom field (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3CFML">Heading - custom field</param>
		/// <param name="m3FLDM">Field type</param>
		/// <param name="m3FLDB">Field length</param>
		/// <param name="m3DCCD">Number of decimal places</param>
		/// <param name="m3MES0">Meter</param>
		/// <param name="m3FLCT">Field category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdCustomField(
			string m3CFMF, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3CFML = null, 
			string m3FLDM = null, 
			int? m3FLDB = null, 
			int? m3DCCD = null, 
			string m3MES0 = null, 
			int? m3FLCT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdCustomField",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CFMF))
				throw new ArgumentNullException(nameof(m3CFMF));

			// Set mandatory parameters
			request
				.WithQueryParameter("CFMF", m3CFMF.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFML))
				request.WithQueryParameter("CFML", m3CFML.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLDM))
				request.WithQueryParameter("FLDM", m3FLDM.Trim());
			if (m3FLDB.HasValue)
				request.WithQueryParameter("FLDB", m3FLDB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3DCCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MES0))
				request.WithQueryParameter("MES0", m3MES0.Trim());
			if (m3FLCT.HasValue)
				request.WithQueryParameter("FLCT", m3FLCT.Value.ToString(CultureInfo.CurrentCulture));

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
