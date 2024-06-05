/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_CTGY">Category (Required)</param>
		/// <param name="m3_CUER">Customer extension reference</param>
		/// <param name="m3_TX05">Name</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_MSID">Message ID</param>
		/// <param name="m3_FLTE">Field type</param>
		/// <param name="m3_FLDB">Field length</param>
		/// <param name="m3_FLDP">Number of decimal places</param>
		/// <param name="m3_FLUC">Uppercase</param>
		/// <param name="m3_FLLL">Field - lower limit</param>
		/// <param name="m3_FLUL">Field - upper limit</param>
		/// <param name="m3_FLLM">Field - limit multiple</param>
		/// <param name="m3_ECDE">Edit code</param>
		/// <param name="m3_NBMO">Check digit method</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCustExtMetad(
			string m3_FILE, 
			string m3_FLDI, 
			string m3_CTGY, 
			string m3_CUER = null, 
			string m3_TX05 = null, 
			string m3_TX15 = null, 
			string m3_TX40 = null, 
			string m3_MSID = null, 
			string m3_FLTE = null, 
			int? m3_FLDB = null, 
			int? m3_FLDP = null, 
			int? m3_FLUC = null, 
			decimal? m3_FLLL = null, 
			decimal? m3_FLUL = null, 
			decimal? m3_FLLM = null, 
			string m3_ECDE = null, 
			int? m3_NBMO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");
			if (string.IsNullOrWhiteSpace(m3_CTGY))
				throw new ArgumentNullException("m3_CTGY");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim())
				.WithQueryParameter("CTGY", m3_CTGY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUER))
				request.WithQueryParameter("CUER", m3_CUER.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX05))
				request.WithQueryParameter("TX05", m3_TX05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSID))
				request.WithQueryParameter("MSID", m3_MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLTE))
				request.WithQueryParameter("FLTE", m3_FLTE.Trim());
			if (m3_FLDB.HasValue)
				request.WithQueryParameter("FLDB", m3_FLDB.Value.ToString());
			if (m3_FLDP.HasValue)
				request.WithQueryParameter("FLDP", m3_FLDP.Value.ToString());
			if (m3_FLUC.HasValue)
				request.WithQueryParameter("FLUC", m3_FLUC.Value.ToString());
			if (m3_FLLL.HasValue)
				request.WithQueryParameter("FLLL", m3_FLLL.Value.ToString());
			if (m3_FLUL.HasValue)
				request.WithQueryParameter("FLUL", m3_FLUL.Value.ToString());
			if (m3_FLLM.HasValue)
				request.WithQueryParameter("FLLM", m3_FLLM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECDE))
				request.WithQueryParameter("ECDE", m3_ECDE.Trim());
			if (m3_NBMO.HasValue)
				request.WithQueryParameter("NBMO", m3_NBMO.Value.ToString());

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
		/// Name DltCustExtMetad
		/// Description Delete customer extension metadata
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_CUER">Customer extension reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltCustExtMetad(
			string m3_FILE, 
			string m3_FLDI, 
			string m3_CUER = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUER))
				request.WithQueryParameter("CUER", m3_CUER.Trim());

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
		/// Name GetCustExtMetad
		/// Description Get customer extension metadata
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_CUER">Customer extension reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCustExtMetadResponse></returns>
		/// <exception cref="M3Exception<GetCustExtMetadResponse>"></exception>
		public async Task<M3Response<GetCustExtMetadResponse>> GetCustExtMetad(
			string m3_FILE, 
			string m3_FLDI, 
			string m3_CUER = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUER))
				request.WithQueryParameter("CUER", m3_CUER.Trim());

			// Execute the request
			var result = await Execute<GetCustExtMetadResponse>(
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
		/// Name LstCustExtMetad
		/// Description List customer extension metadata
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_FILE">File</param>
		/// <param name="m3_CUER">Customer extension reference</param>
		/// <param name="m3_FLDI">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCustExtMetadResponse></returns>
		/// <exception cref="M3Exception<LstCustExtMetadResponse>"></exception>
		public async Task<M3Response<LstCustExtMetadResponse>> LstCustExtMetad(
			string m3_FILE = null, 
			string m3_CUER = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCustExtMetad",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUER))
				request.WithQueryParameter("CUER", m3_CUER.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLDI))
				request.WithQueryParameter("FLDI", m3_FLDI.Trim());

			// Execute the request
			var result = await Execute<LstCustExtMetadResponse>(
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
		/// Name UpdCustExtMetad
		/// Description Update customer extension metadata
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_CUER">Customer extension reference</param>
		/// <param name="m3_TX05">Name</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_MSID">Message ID</param>
		/// <param name="m3_FLTE">Field type</param>
		/// <param name="m3_CTGY">Category</param>
		/// <param name="m3_FLDB">Field length</param>
		/// <param name="m3_FLDP">Number of decimal places</param>
		/// <param name="m3_FLUC">Uppercase</param>
		/// <param name="m3_FLLL">Field - lower limit</param>
		/// <param name="m3_FLUL">Field - upper limit</param>
		/// <param name="m3_FLLM">Field - limit multiple</param>
		/// <param name="m3_ECDE">Edit code</param>
		/// <param name="m3_NBMO">Check digit method</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdCustExtMetad(
			string m3_FILE, 
			string m3_FLDI, 
			string m3_CUER = null, 
			string m3_TX05 = null, 
			string m3_TX15 = null, 
			string m3_TX40 = null, 
			string m3_MSID = null, 
			string m3_FLTE = null, 
			string m3_CTGY = null, 
			int? m3_FLDB = null, 
			int? m3_FLDP = null, 
			int? m3_FLUC = null, 
			decimal? m3_FLLL = null, 
			decimal? m3_FLUL = null, 
			decimal? m3_FLLM = null, 
			string m3_ECDE = null, 
			int? m3_NBMO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUER))
				request.WithQueryParameter("CUER", m3_CUER.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX05))
				request.WithQueryParameter("TX05", m3_TX05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSID))
				request.WithQueryParameter("MSID", m3_MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLTE))
				request.WithQueryParameter("FLTE", m3_FLTE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTGY))
				request.WithQueryParameter("CTGY", m3_CTGY.Trim());
			if (m3_FLDB.HasValue)
				request.WithQueryParameter("FLDB", m3_FLDB.Value.ToString());
			if (m3_FLDP.HasValue)
				request.WithQueryParameter("FLDP", m3_FLDP.Value.ToString());
			if (m3_FLUC.HasValue)
				request.WithQueryParameter("FLUC", m3_FLUC.Value.ToString());
			if (m3_FLLL.HasValue)
				request.WithQueryParameter("FLLL", m3_FLLL.Value.ToString());
			if (m3_FLUL.HasValue)
				request.WithQueryParameter("FLUL", m3_FLUL.Value.ToString());
			if (m3_FLLM.HasValue)
				request.WithQueryParameter("FLLM", m3_FLLM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECDE))
				request.WithQueryParameter("ECDE", m3_ECDE.Trim());
			if (m3_NBMO.HasValue)
				request.WithQueryParameter("NBMO", m3_NBMO.Value.ToString());

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
