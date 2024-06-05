/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CMS081MI;
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
	/// Name: CMS081MI
	/// Component Name: Customer extension value map
	/// Description: Customer extension value map interface
	/// Version Release: 5ea2
	///</summary>
	public partial class CMS081MIResource : M3BaseResourceEndpoint
	{
		public CMS081MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS081MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddCustExtVaMap
		/// Description Add Field Value Map
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_AL30">Alpha field 30 positions (Required)</param>
		/// <param name="m3_CUER">Customer extension reference</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="m3_TX05">Name</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_MSID">Message ID</param>
		/// <param name="m3_CFID">Formula</param>
		/// <param name="m3_CFRI">Formula result</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCustExtVaMap(
			string m3_FILE, 
			string m3_FLDI, 
			string m3_AL30, 
			string m3_CUER = null, 
			int? m3_SEQN = null, 
			string m3_TX05 = null, 
			string m3_TX15 = null, 
			string m3_TX40 = null, 
			string m3_MSID = null, 
			string m3_CFID = null, 
			string m3_CFRI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCustExtVaMap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");
			if (string.IsNullOrWhiteSpace(m3_AL30))
				throw new ArgumentNullException("m3_AL30");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim())
				.WithQueryParameter("AL30", m3_AL30.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUER))
				request.WithQueryParameter("CUER", m3_CUER.Trim());
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX05))
				request.WithQueryParameter("TX05", m3_TX05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSID))
				request.WithQueryParameter("MSID", m3_MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFID))
				request.WithQueryParameter("CFID", m3_CFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFRI))
				request.WithQueryParameter("CFRI", m3_CFRI.Trim());

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
		/// Name DltCustExtVaMap
		/// Description Delete Field Value Map
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_AL30">Alpha field 30 positions (Required)</param>
		/// <param name="m3_CUER">Customer extension reference</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltCustExtVaMap(
			string m3_FILE, 
			string m3_FLDI, 
			string m3_AL30, 
			string m3_CUER = null, 
			int? m3_SEQN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltCustExtVaMap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");
			if (string.IsNullOrWhiteSpace(m3_AL30))
				throw new ArgumentNullException("m3_AL30");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim())
				.WithQueryParameter("AL30", m3_AL30.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUER))
				request.WithQueryParameter("CUER", m3_CUER.Trim());
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());

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
		/// Name GetCustExtVaMap
		/// Description Get Field Value Map
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_AL30">Alpha field 30 positions (Required)</param>
		/// <param name="m3_CUER">Customer extension reference</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCustExtVaMapResponse></returns>
		/// <exception cref="M3Exception<GetCustExtVaMapResponse>"></exception>
		public async Task<M3Response<GetCustExtVaMapResponse>> GetCustExtVaMap(
			string m3_FILE, 
			string m3_FLDI, 
			string m3_AL30, 
			string m3_CUER = null, 
			int? m3_SEQN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetCustExtVaMap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");
			if (string.IsNullOrWhiteSpace(m3_AL30))
				throw new ArgumentNullException("m3_AL30");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim())
				.WithQueryParameter("AL30", m3_AL30.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUER))
				request.WithQueryParameter("CUER", m3_CUER.Trim());
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());

			// Execute the request
			var result = await Execute<GetCustExtVaMapResponse>(
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
		/// Name LstCustExtVaMap
		/// Description List Field Value Map
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_FILE">File</param>
		/// <param name="m3_CUER">Customer extension reference</param>
		/// <param name="m3_FLDI">Field</param>
		/// <param name="m3_AL30">Alpha field 30 positions</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCustExtVaMapResponse></returns>
		/// <exception cref="M3Exception<LstCustExtVaMapResponse>"></exception>
		public async Task<M3Response<LstCustExtVaMapResponse>> LstCustExtVaMap(
			string m3_FILE = null, 
			string m3_CUER = null, 
			string m3_FLDI = null, 
			string m3_AL30 = null, 
			int? m3_SEQN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCustExtVaMap",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUER))
				request.WithQueryParameter("CUER", m3_CUER.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLDI))
				request.WithQueryParameter("FLDI", m3_FLDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AL30))
				request.WithQueryParameter("AL30", m3_AL30.Trim());
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());

			// Execute the request
			var result = await Execute<LstCustExtVaMapResponse>(
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
		/// Name UpdCustExtVaMap
		/// Description Change Field Value Map
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_AL30">Alpha field 30 positions (Required)</param>
		/// <param name="m3_CUER">Customer extension reference</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="m3_TX05">Name</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_MSID">Message ID</param>
		/// <param name="m3_CFID">Formula</param>
		/// <param name="m3_CFRI">Formula result</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdCustExtVaMap(
			string m3_FILE, 
			string m3_FLDI, 
			string m3_AL30, 
			string m3_CUER = null, 
			int? m3_SEQN = null, 
			string m3_TX05 = null, 
			string m3_TX15 = null, 
			string m3_TX40 = null, 
			string m3_MSID = null, 
			string m3_CFID = null, 
			string m3_CFRI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdCustExtVaMap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");
			if (string.IsNullOrWhiteSpace(m3_AL30))
				throw new ArgumentNullException("m3_AL30");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim())
				.WithQueryParameter("AL30", m3_AL30.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUER))
				request.WithQueryParameter("CUER", m3_CUER.Trim());
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX05))
				request.WithQueryParameter("TX05", m3_TX05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSID))
				request.WithQueryParameter("MSID", m3_MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFID))
				request.WithQueryParameter("CFID", m3_CFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFRI))
				request.WithQueryParameter("CFRI", m3_CFRI.Trim());

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
