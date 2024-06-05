/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.PDS028MI;
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
	/// Name: PDS028MI
	/// Component Name: Product version
	/// Description: Product version interface
	/// Version Release: 5ea1
	///</summary>
	public partial class PDS028MIResource : M3BaseResourceEndpoint
	{
		public PDS028MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PDS028MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddVersion
		/// Description AddVersion
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3STRT">Product structure type (Required)</param>
		/// <param name="m3VRSN">Version (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3TDAT">To date (Required)</param>
		/// <param name="m3LEAA">Lead time 5 production time all levels</param>
		/// <param name="m3LEAL">Lead time this level</param>
		/// <param name="m3BACO">Batch recalculation</param>
		/// <param name="m3BAQT">Yield quantity</param>
		/// <param name="m3EXPC">Yield percentage</param>
		/// <param name="m3TEXQ">Batch quantity</param>
		/// <param name="m3NUMA">Number of components</param>
		/// <param name="m3NUOP">Number of operations</param>
		/// <param name="m3NUSC">Number of subcontract operations</param>
		/// <param name="m3NUPH">Number of phantom items</param>
		/// <param name="m3NUEX">Number of yield components</param>
		/// <param name="m3ASPC">Cumulative scrap percentage</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddVersion(
			string m3FACI, 
			string m3PRNO, 
			string m3STRT, 
			int m3VRSN, 
			string m3TX40, 
			DateTime m3FDAT, 
			DateTime m3TDAT, 
			int? m3LEAA = null, 
			int? m3LEAL = null, 
			int? m3BACO = null, 
			decimal? m3BAQT = null, 
			int? m3EXPC = null, 
			decimal? m3TEXQ = null, 
			int? m3NUMA = null, 
			int? m3NUOP = null, 
			int? m3NUSC = null, 
			int? m3NUPH = null, 
			int? m3NUEX = null, 
			int? m3ASPC = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddVersion",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3STRT))
				throw new ArgumentNullException(nameof(m3STRT));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("STRT", m3STRT.Trim())
				.WithQueryParameter("VRSN", m3VRSN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TX40", m3TX40.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String())
				.WithQueryParameter("TDAT", m3TDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3LEAA.HasValue)
				request.WithQueryParameter("LEAA", m3LEAA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEAL.HasValue)
				request.WithQueryParameter("LEAL", m3LEAL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BACO.HasValue)
				request.WithQueryParameter("BACO", m3BACO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BAQT.HasValue)
				request.WithQueryParameter("BAQT", m3BAQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXPC.HasValue)
				request.WithQueryParameter("EXPC", m3EXPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TEXQ.HasValue)
				request.WithQueryParameter("TEXQ", m3TEXQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUMA.HasValue)
				request.WithQueryParameter("NUMA", m3NUMA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUOP.HasValue)
				request.WithQueryParameter("NUOP", m3NUOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUSC.HasValue)
				request.WithQueryParameter("NUSC", m3NUSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUPH.HasValue)
				request.WithQueryParameter("NUPH", m3NUPH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUEX.HasValue)
				request.WithQueryParameter("NUEX", m3NUEX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ASPC.HasValue)
				request.WithQueryParameter("ASPC", m3ASPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name CpyVersion
		/// Description CpyVersion
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3STRT">Product structure type (Required)</param>
		/// <param name="m3VRSN">Version (Required)</param>
		/// <param name="m3CVRN">Version (Required)</param>
		/// <param name="m3CFDT">From date (Required)</param>
		/// <param name="m3CTDT">To date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyVersion(
			string m3FACI, 
			string m3PRNO, 
			string m3STRT, 
			int m3VRSN, 
			int m3CVRN, 
			DateTime m3CFDT, 
			DateTime m3CTDT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyVersion",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3STRT))
				throw new ArgumentNullException(nameof(m3STRT));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("STRT", m3STRT.Trim())
				.WithQueryParameter("VRSN", m3VRSN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CVRN", m3CVRN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CFDT", m3CFDT.ToM3String())
				.WithQueryParameter("CTDT", m3CTDT.ToM3String());

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
		/// Name DltVersion
		/// Description DltVersion
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3STRT">Product structure type (Required)</param>
		/// <param name="m3VRSN">Version (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltVersion(
			string m3FACI, 
			string m3PRNO, 
			string m3STRT, 
			int m3VRSN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltVersion",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3STRT))
				throw new ArgumentNullException(nameof(m3STRT));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("STRT", m3STRT.Trim())
				.WithQueryParameter("VRSN", m3VRSN.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetVersion
		/// Description GetVersion
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3STRT">Product structure type (Required)</param>
		/// <param name="m3VRSN">Version</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetVersionResponse></returns>
		/// <exception cref="M3Exception<GetVersionResponse>"></exception>
		public async Task<M3Response<GetVersionResponse>> GetVersion(
			string m3FACI, 
			string m3PRNO, 
			string m3STRT, 
			int? m3VRSN = null, 
			DateTime? m3FDAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetVersion",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3STRT))
				throw new ArgumentNullException(nameof(m3STRT));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("STRT", m3STRT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3VRSN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetVersionResponse>(
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
		/// Name LstVersions
		/// Description LstVersions
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3VRSN">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstVersionsResponse></returns>
		/// <exception cref="M3Exception<LstVersionsResponse>"></exception>
		public async Task<M3Response<LstVersionsResponse>> LstVersions(
			string m3FACI, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3VRSN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstVersions",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3VRSN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstVersionsResponse>(
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
		/// Name UpdVersion
		/// Description UpdVersion
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3STRT">Product structure type (Required)</param>
		/// <param name="m3VRSN">Version (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3LEAA">Lead time 5 production time all levels</param>
		/// <param name="m3LEAL">Lead time this level</param>
		/// <param name="m3BACO">Batch recalculation</param>
		/// <param name="m3BAQT">Yield quantity</param>
		/// <param name="m3EXPC">Yield percentage</param>
		/// <param name="m3TEXQ">Batch quantity</param>
		/// <param name="m3WLDE">Infinite/finite</param>
		/// <param name="m3NUMA">Number of components</param>
		/// <param name="m3NUOP">Number of operations</param>
		/// <param name="m3NUSC">Number of subcontract operations</param>
		/// <param name="m3NUPH">Number of phantom items</param>
		/// <param name="m3NUEX">Number of yield components</param>
		/// <param name="m3NUCM">Number of lot controlling components</param>
		/// <param name="m3ASLA">Accumulated queue time</param>
		/// <param name="m3ASPC">Cumulative scrap percentage</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdVersion(
			string m3FACI, 
			string m3PRNO, 
			string m3STRT, 
			int m3VRSN, 
			string m3TX40, 
			DateTime? m3FDAT = null, 
			DateTime? m3TDAT = null, 
			int? m3LEAA = null, 
			int? m3LEAL = null, 
			int? m3BACO = null, 
			decimal? m3BAQT = null, 
			int? m3EXPC = null, 
			decimal? m3TEXQ = null, 
			int? m3WLDE = null, 
			int? m3NUMA = null, 
			int? m3NUOP = null, 
			int? m3NUSC = null, 
			int? m3NUPH = null, 
			int? m3NUEX = null, 
			int? m3NUCM = null, 
			int? m3ASLA = null, 
			int? m3ASPC = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdVersion",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3STRT))
				throw new ArgumentNullException(nameof(m3STRT));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("STRT", m3STRT.Trim())
				.WithQueryParameter("VRSN", m3VRSN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TX40", m3TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());
			if (m3LEAA.HasValue)
				request.WithQueryParameter("LEAA", m3LEAA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEAL.HasValue)
				request.WithQueryParameter("LEAL", m3LEAL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BACO.HasValue)
				request.WithQueryParameter("BACO", m3BACO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BAQT.HasValue)
				request.WithQueryParameter("BAQT", m3BAQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXPC.HasValue)
				request.WithQueryParameter("EXPC", m3EXPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TEXQ.HasValue)
				request.WithQueryParameter("TEXQ", m3TEXQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WLDE.HasValue)
				request.WithQueryParameter("WLDE", m3WLDE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUMA.HasValue)
				request.WithQueryParameter("NUMA", m3NUMA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUOP.HasValue)
				request.WithQueryParameter("NUOP", m3NUOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUSC.HasValue)
				request.WithQueryParameter("NUSC", m3NUSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUPH.HasValue)
				request.WithQueryParameter("NUPH", m3NUPH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUEX.HasValue)
				request.WithQueryParameter("NUEX", m3NUEX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUCM.HasValue)
				request.WithQueryParameter("NUCM", m3NUCM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ASLA.HasValue)
				request.WithQueryParameter("ASLA", m3ASLA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ASPC.HasValue)
				request.WithQueryParameter("ASPC", m3ASPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
