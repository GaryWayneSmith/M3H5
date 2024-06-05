/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddCustExtVaMap
		/// Description Add Field Value Map
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3AL30">Alpha field 30 positions (Required)</param>
		/// <param name="m3CUER">Customer extension reference</param>
		/// <param name="m3SEQN">Sequence number</param>
		/// <param name="m3TX05">Name</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3MSID">Message ID</param>
		/// <param name="m3CFID">Formula</param>
		/// <param name="m3CFRI">Formula result</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCustExtVaMap(
			string m3FILE, 
			string m3FLDI, 
			string m3AL30, 
			string m3CUER = null, 
			int? m3SEQN = null, 
			string m3TX05 = null, 
			string m3TX15 = null, 
			string m3TX40 = null, 
			string m3MSID = null, 
			string m3CFID = null, 
			string m3CFRI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddCustExtVaMap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));
			if (string.IsNullOrWhiteSpace(m3AL30))
				throw new ArgumentNullException(nameof(m3AL30));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim())
				.WithQueryParameter("AL30", m3AL30.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUER))
				request.WithQueryParameter("CUER", m3CUER.Trim());
			if (m3SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3SEQN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX05))
				request.WithQueryParameter("TX05", m3TX05.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSID))
				request.WithQueryParameter("MSID", m3MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFID))
				request.WithQueryParameter("CFID", m3CFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFRI))
				request.WithQueryParameter("CFRI", m3CFRI.Trim());

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
		/// Name DltCustExtVaMap
		/// Description Delete Field Value Map
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3AL30">Alpha field 30 positions (Required)</param>
		/// <param name="m3CUER">Customer extension reference</param>
		/// <param name="m3SEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltCustExtVaMap(
			string m3FILE, 
			string m3FLDI, 
			string m3AL30, 
			string m3CUER = null, 
			int? m3SEQN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltCustExtVaMap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));
			if (string.IsNullOrWhiteSpace(m3AL30))
				throw new ArgumentNullException(nameof(m3AL30));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim())
				.WithQueryParameter("AL30", m3AL30.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUER))
				request.WithQueryParameter("CUER", m3CUER.Trim());
			if (m3SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3SEQN.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetCustExtVaMap
		/// Description Get Field Value Map
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3AL30">Alpha field 30 positions (Required)</param>
		/// <param name="m3CUER">Customer extension reference</param>
		/// <param name="m3SEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCustExtVaMapResponse></returns>
		/// <exception cref="M3Exception<GetCustExtVaMapResponse>"></exception>
		public async Task<M3Response<GetCustExtVaMapResponse>> GetCustExtVaMap(
			string m3FILE, 
			string m3FLDI, 
			string m3AL30, 
			string m3CUER = null, 
			int? m3SEQN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetCustExtVaMap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));
			if (string.IsNullOrWhiteSpace(m3AL30))
				throw new ArgumentNullException(nameof(m3AL30));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim())
				.WithQueryParameter("AL30", m3AL30.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUER))
				request.WithQueryParameter("CUER", m3CUER.Trim());
			if (m3SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3SEQN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetCustExtVaMapResponse>(
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
		/// Name LstCustExtVaMap
		/// Description List Field Value Map
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3FILE">File</param>
		/// <param name="m3CUER">Customer extension reference</param>
		/// <param name="m3FLDI">Field</param>
		/// <param name="m3AL30">Alpha field 30 positions</param>
		/// <param name="m3SEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCustExtVaMapResponse></returns>
		/// <exception cref="M3Exception<LstCustExtVaMapResponse>"></exception>
		public async Task<M3Response<LstCustExtVaMapResponse>> LstCustExtVaMap(
			string m3FILE = null, 
			string m3CUER = null, 
			string m3FLDI = null, 
			string m3AL30 = null, 
			int? m3SEQN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstCustExtVaMap",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUER))
				request.WithQueryParameter("CUER", m3CUER.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLDI))
				request.WithQueryParameter("FLDI", m3FLDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3AL30))
				request.WithQueryParameter("AL30", m3AL30.Trim());
			if (m3SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3SEQN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstCustExtVaMapResponse>(
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
		/// Name UpdCustExtVaMap
		/// Description Change Field Value Map
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3AL30">Alpha field 30 positions (Required)</param>
		/// <param name="m3CUER">Customer extension reference</param>
		/// <param name="m3SEQN">Sequence number</param>
		/// <param name="m3TX05">Name</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3MSID">Message ID</param>
		/// <param name="m3CFID">Formula</param>
		/// <param name="m3CFRI">Formula result</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdCustExtVaMap(
			string m3FILE, 
			string m3FLDI, 
			string m3AL30, 
			string m3CUER = null, 
			int? m3SEQN = null, 
			string m3TX05 = null, 
			string m3TX15 = null, 
			string m3TX40 = null, 
			string m3MSID = null, 
			string m3CFID = null, 
			string m3CFRI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdCustExtVaMap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));
			if (string.IsNullOrWhiteSpace(m3AL30))
				throw new ArgumentNullException(nameof(m3AL30));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim())
				.WithQueryParameter("AL30", m3AL30.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUER))
				request.WithQueryParameter("CUER", m3CUER.Trim());
			if (m3SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3SEQN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX05))
				request.WithQueryParameter("TX05", m3TX05.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSID))
				request.WithQueryParameter("MSID", m3MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFID))
				request.WithQueryParameter("CFID", m3CFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFRI))
				request.WithQueryParameter("CFRI", m3CFRI.Trim());

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
