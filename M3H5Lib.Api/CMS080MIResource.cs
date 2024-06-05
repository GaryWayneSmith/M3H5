/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.CMS080MI;
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
	/// Name: CMS080MI
	/// Component Name: Customer extension metadata
	/// Description: Customer extension metadata interface
	/// Version Release: 5ea3
	///</summary>
	public partial class CMS080MIResource : M3BaseResourceEndpoint
	{
		public CMS080MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS080MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddCustExtMetad
		/// Description Add Customer extension metadata
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3CTGY">Category (Required)</param>
		/// <param name="m3CUER">Customer extension reference</param>
		/// <param name="m3TX05">Name</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3MSID">Message ID</param>
		/// <param name="m3FLTE">Field type</param>
		/// <param name="m3FLDB">Field length</param>
		/// <param name="m3FLDP">Number of decimal places</param>
		/// <param name="m3FLUC">Uppercase</param>
		/// <param name="m3FLLL">Field - lower limit</param>
		/// <param name="m3FLUL">Field - upper limit</param>
		/// <param name="m3FLLM">Field - limit multiple</param>
		/// <param name="m3ECDE">Edit code</param>
		/// <param name="m3NBMO">Check digit method</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCustExtMetad(
			string m3FILE, 
			string m3FLDI, 
			string m3CTGY, 
			string m3CUER = null, 
			string m3TX05 = null, 
			string m3TX15 = null, 
			string m3TX40 = null, 
			string m3MSID = null, 
			string m3FLTE = null, 
			int? m3FLDB = null, 
			int? m3FLDP = null, 
			int? m3FLUC = null, 
			decimal? m3FLLL = null, 
			decimal? m3FLUL = null, 
			decimal? m3FLLM = null, 
			string m3ECDE = null, 
			int? m3NBMO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCustExtMetad",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));
			if (string.IsNullOrWhiteSpace(m3CTGY))
				throw new ArgumentNullException(nameof(m3CTGY));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim())
				.WithQueryParameter("CTGY", m3CTGY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUER))
				request.WithQueryParameter("CUER", m3CUER.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX05))
				request.WithQueryParameter("TX05", m3TX05.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSID))
				request.WithQueryParameter("MSID", m3MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLTE))
				request.WithQueryParameter("FLTE", m3FLTE.Trim());
			if (m3FLDB.HasValue)
				request.WithQueryParameter("FLDB", m3FLDB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLDP.HasValue)
				request.WithQueryParameter("FLDP", m3FLDP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLUC.HasValue)
				request.WithQueryParameter("FLUC", m3FLUC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLLL.HasValue)
				request.WithQueryParameter("FLLL", m3FLLL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLUL.HasValue)
				request.WithQueryParameter("FLUL", m3FLUL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLLM.HasValue)
				request.WithQueryParameter("FLLM", m3FLLM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECDE))
				request.WithQueryParameter("ECDE", m3ECDE.Trim());
			if (m3NBMO.HasValue)
				request.WithQueryParameter("NBMO", m3NBMO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltCustExtMetad
		/// Description Delete customer extension metadata
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3CUER">Customer extension reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltCustExtMetad(
			string m3FILE, 
			string m3FLDI, 
			string m3CUER = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltCustExtMetad",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUER))
				request.WithQueryParameter("CUER", m3CUER.Trim());

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
		/// Name GetCustExtMetad
		/// Description Get customer extension metadata
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3CUER">Customer extension reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCustExtMetadResponse></returns>
		/// <exception cref="M3Exception<GetCustExtMetadResponse>"></exception>
		public async Task<M3Response<GetCustExtMetadResponse>> GetCustExtMetad(
			string m3FILE, 
			string m3FLDI, 
			string m3CUER = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetCustExtMetad",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUER))
				request.WithQueryParameter("CUER", m3CUER.Trim());

			// Execute the request
			var result = await Execute<GetCustExtMetadResponse>(
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
		/// Name LstCustExtMetad
		/// Description List customer extension metadata
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3FILE">File</param>
		/// <param name="m3CUER">Customer extension reference</param>
		/// <param name="m3FLDI">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCustExtMetadResponse></returns>
		/// <exception cref="M3Exception<LstCustExtMetadResponse>"></exception>
		public async Task<M3Response<LstCustExtMetadResponse>> LstCustExtMetad(
			string m3FILE = null, 
			string m3CUER = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCustExtMetad",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUER))
				request.WithQueryParameter("CUER", m3CUER.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLDI))
				request.WithQueryParameter("FLDI", m3FLDI.Trim());

			// Execute the request
			var result = await Execute<LstCustExtMetadResponse>(
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
		/// Name UpdCustExtMetad
		/// Description Update customer extension metadata
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3CUER">Customer extension reference</param>
		/// <param name="m3TX05">Name</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3MSID">Message ID</param>
		/// <param name="m3FLTE">Field type</param>
		/// <param name="m3CTGY">Category</param>
		/// <param name="m3FLDB">Field length</param>
		/// <param name="m3FLDP">Number of decimal places</param>
		/// <param name="m3FLUC">Uppercase</param>
		/// <param name="m3FLLL">Field - lower limit</param>
		/// <param name="m3FLUL">Field - upper limit</param>
		/// <param name="m3FLLM">Field - limit multiple</param>
		/// <param name="m3ECDE">Edit code</param>
		/// <param name="m3NBMO">Check digit method</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdCustExtMetad(
			string m3FILE, 
			string m3FLDI, 
			string m3CUER = null, 
			string m3TX05 = null, 
			string m3TX15 = null, 
			string m3TX40 = null, 
			string m3MSID = null, 
			string m3FLTE = null, 
			string m3CTGY = null, 
			int? m3FLDB = null, 
			int? m3FLDP = null, 
			int? m3FLUC = null, 
			decimal? m3FLLL = null, 
			decimal? m3FLUL = null, 
			decimal? m3FLLM = null, 
			string m3ECDE = null, 
			int? m3NBMO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdCustExtMetad",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUER))
				request.WithQueryParameter("CUER", m3CUER.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX05))
				request.WithQueryParameter("TX05", m3TX05.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSID))
				request.WithQueryParameter("MSID", m3MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLTE))
				request.WithQueryParameter("FLTE", m3FLTE.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTGY))
				request.WithQueryParameter("CTGY", m3CTGY.Trim());
			if (m3FLDB.HasValue)
				request.WithQueryParameter("FLDB", m3FLDB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLDP.HasValue)
				request.WithQueryParameter("FLDP", m3FLDP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLUC.HasValue)
				request.WithQueryParameter("FLUC", m3FLUC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLLL.HasValue)
				request.WithQueryParameter("FLLL", m3FLLL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLUL.HasValue)
				request.WithQueryParameter("FLUL", m3FLUL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLLM.HasValue)
				request.WithQueryParameter("FLLM", m3FLLM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECDE))
				request.WithQueryParameter("ECDE", m3ECDE.Trim());
			if (m3NBMO.HasValue)
				request.WithQueryParameter("NBMO", m3NBMO.Value.ToString(CultureInfo.CurrentCulture));

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
