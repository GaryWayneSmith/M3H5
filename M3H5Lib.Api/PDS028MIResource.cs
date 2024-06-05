/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product (Required)</param>
		/// <param name="m3_STRT">Product structure type (Required)</param>
		/// <param name="m3_VRSN">Version (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_TDAT">To date (Required)</param>
		/// <param name="m3_LEAA">Lead time 5 production time all levels</param>
		/// <param name="m3_LEAL">Lead time this level</param>
		/// <param name="m3_BACO">Batch recalculation</param>
		/// <param name="m3_BAQT">Yield quantity</param>
		/// <param name="m3_EXPC">Yield percentage</param>
		/// <param name="m3_TEXQ">Batch quantity</param>
		/// <param name="m3_NUMA">Number of components</param>
		/// <param name="m3_NUOP">Number of operations</param>
		/// <param name="m3_NUSC">Number of subcontract operations</param>
		/// <param name="m3_NUPH">Number of phantom items</param>
		/// <param name="m3_NUEX">Number of yield components</param>
		/// <param name="m3_ASPC">Cumulative scrap percentage</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddVersion(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_STRT, 
			int m3_VRSN, 
			string m3_TX40, 
			DateTime m3_FDAT, 
			DateTime m3_TDAT, 
			int? m3_LEAA = null, 
			int? m3_LEAL = null, 
			int? m3_BACO = null, 
			decimal? m3_BAQT = null, 
			int? m3_EXPC = null, 
			decimal? m3_TEXQ = null, 
			int? m3_NUMA = null, 
			int? m3_NUOP = null, 
			int? m3_NUSC = null, 
			int? m3_NUPH = null, 
			int? m3_NUEX = null, 
			int? m3_ASPC = null, 
			decimal? m3_TXID = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_STRT))
				throw new ArgumentNullException("m3_STRT");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("STRT", m3_STRT.Trim())
				.WithQueryParameter("VRSN", m3_VRSN.ToString())
				.WithQueryParameter("TX40", m3_TX40.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String())
				.WithQueryParameter("TDAT", m3_TDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_LEAA.HasValue)
				request.WithQueryParameter("LEAA", m3_LEAA.Value.ToString());
			if (m3_LEAL.HasValue)
				request.WithQueryParameter("LEAL", m3_LEAL.Value.ToString());
			if (m3_BACO.HasValue)
				request.WithQueryParameter("BACO", m3_BACO.Value.ToString());
			if (m3_BAQT.HasValue)
				request.WithQueryParameter("BAQT", m3_BAQT.Value.ToString());
			if (m3_EXPC.HasValue)
				request.WithQueryParameter("EXPC", m3_EXPC.Value.ToString());
			if (m3_TEXQ.HasValue)
				request.WithQueryParameter("TEXQ", m3_TEXQ.Value.ToString());
			if (m3_NUMA.HasValue)
				request.WithQueryParameter("NUMA", m3_NUMA.Value.ToString());
			if (m3_NUOP.HasValue)
				request.WithQueryParameter("NUOP", m3_NUOP.Value.ToString());
			if (m3_NUSC.HasValue)
				request.WithQueryParameter("NUSC", m3_NUSC.Value.ToString());
			if (m3_NUPH.HasValue)
				request.WithQueryParameter("NUPH", m3_NUPH.Value.ToString());
			if (m3_NUEX.HasValue)
				request.WithQueryParameter("NUEX", m3_NUEX.Value.ToString());
			if (m3_ASPC.HasValue)
				request.WithQueryParameter("ASPC", m3_ASPC.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
		/// Name CpyVersion
		/// Description CpyVersion
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product (Required)</param>
		/// <param name="m3_STRT">Product structure type (Required)</param>
		/// <param name="m3_VRSN">Version (Required)</param>
		/// <param name="m3_CVRN">Version (Required)</param>
		/// <param name="m3_CFDT">From date (Required)</param>
		/// <param name="m3_CTDT">To date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyVersion(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_STRT, 
			int m3_VRSN, 
			int m3_CVRN, 
			DateTime m3_CFDT, 
			DateTime m3_CTDT, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_STRT))
				throw new ArgumentNullException("m3_STRT");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("STRT", m3_STRT.Trim())
				.WithQueryParameter("VRSN", m3_VRSN.ToString())
				.WithQueryParameter("CVRN", m3_CVRN.ToString())
				.WithQueryParameter("CFDT", m3_CFDT.ToM3String())
				.WithQueryParameter("CTDT", m3_CTDT.ToM3String());

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
		/// Name DltVersion
		/// Description DltVersion
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product (Required)</param>
		/// <param name="m3_STRT">Product structure type (Required)</param>
		/// <param name="m3_VRSN">Version (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltVersion(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_STRT, 
			int m3_VRSN, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_STRT))
				throw new ArgumentNullException("m3_STRT");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("STRT", m3_STRT.Trim())
				.WithQueryParameter("VRSN", m3_VRSN.ToString());

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
		/// Name GetVersion
		/// Description GetVersion
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product (Required)</param>
		/// <param name="m3_STRT">Product structure type (Required)</param>
		/// <param name="m3_VRSN">Version</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetVersionResponse></returns>
		/// <exception cref="M3Exception<GetVersionResponse>"></exception>
		public async Task<M3Response<GetVersionResponse>> GetVersion(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_STRT, 
			int? m3_VRSN = null, 
			DateTime? m3_FDAT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_STRT))
				throw new ArgumentNullException("m3_STRT");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("STRT", m3_STRT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3_VRSN.Value.ToString());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetVersionResponse>(
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
		/// Name LstVersions
		/// Description LstVersions
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_VRSN">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstVersionsResponse></returns>
		/// <exception cref="M3Exception<LstVersionsResponse>"></exception>
		public async Task<M3Response<LstVersionsResponse>> LstVersions(
			string m3_FACI, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_VRSN = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3_VRSN.Value.ToString());

			// Execute the request
			var result = await Execute<LstVersionsResponse>(
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
		/// Name UpdVersion
		/// Description UpdVersion
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product (Required)</param>
		/// <param name="m3_STRT">Product structure type (Required)</param>
		/// <param name="m3_VRSN">Version (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_LEAA">Lead time 5 production time all levels</param>
		/// <param name="m3_LEAL">Lead time this level</param>
		/// <param name="m3_BACO">Batch recalculation</param>
		/// <param name="m3_BAQT">Yield quantity</param>
		/// <param name="m3_EXPC">Yield percentage</param>
		/// <param name="m3_TEXQ">Batch quantity</param>
		/// <param name="m3_WLDE">Infinite/finite</param>
		/// <param name="m3_NUMA">Number of components</param>
		/// <param name="m3_NUOP">Number of operations</param>
		/// <param name="m3_NUSC">Number of subcontract operations</param>
		/// <param name="m3_NUPH">Number of phantom items</param>
		/// <param name="m3_NUEX">Number of yield components</param>
		/// <param name="m3_NUCM">Number of lot controlling components</param>
		/// <param name="m3_ASLA">Accumulated queue time</param>
		/// <param name="m3_ASPC">Cumulative scrap percentage</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdVersion(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_STRT, 
			int m3_VRSN, 
			string m3_TX40, 
			DateTime? m3_FDAT = null, 
			DateTime? m3_TDAT = null, 
			int? m3_LEAA = null, 
			int? m3_LEAL = null, 
			int? m3_BACO = null, 
			decimal? m3_BAQT = null, 
			int? m3_EXPC = null, 
			decimal? m3_TEXQ = null, 
			int? m3_WLDE = null, 
			int? m3_NUMA = null, 
			int? m3_NUOP = null, 
			int? m3_NUSC = null, 
			int? m3_NUPH = null, 
			int? m3_NUEX = null, 
			int? m3_NUCM = null, 
			int? m3_ASLA = null, 
			int? m3_ASPC = null, 
			decimal? m3_TXID = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_STRT))
				throw new ArgumentNullException("m3_STRT");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("STRT", m3_STRT.Trim())
				.WithQueryParameter("VRSN", m3_VRSN.ToString())
				.WithQueryParameter("TX40", m3_TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());
			if (m3_LEAA.HasValue)
				request.WithQueryParameter("LEAA", m3_LEAA.Value.ToString());
			if (m3_LEAL.HasValue)
				request.WithQueryParameter("LEAL", m3_LEAL.Value.ToString());
			if (m3_BACO.HasValue)
				request.WithQueryParameter("BACO", m3_BACO.Value.ToString());
			if (m3_BAQT.HasValue)
				request.WithQueryParameter("BAQT", m3_BAQT.Value.ToString());
			if (m3_EXPC.HasValue)
				request.WithQueryParameter("EXPC", m3_EXPC.Value.ToString());
			if (m3_TEXQ.HasValue)
				request.WithQueryParameter("TEXQ", m3_TEXQ.Value.ToString());
			if (m3_WLDE.HasValue)
				request.WithQueryParameter("WLDE", m3_WLDE.Value.ToString());
			if (m3_NUMA.HasValue)
				request.WithQueryParameter("NUMA", m3_NUMA.Value.ToString());
			if (m3_NUOP.HasValue)
				request.WithQueryParameter("NUOP", m3_NUOP.Value.ToString());
			if (m3_NUSC.HasValue)
				request.WithQueryParameter("NUSC", m3_NUSC.Value.ToString());
			if (m3_NUPH.HasValue)
				request.WithQueryParameter("NUPH", m3_NUPH.Value.ToString());
			if (m3_NUEX.HasValue)
				request.WithQueryParameter("NUEX", m3_NUEX.Value.ToString());
			if (m3_NUCM.HasValue)
				request.WithQueryParameter("NUCM", m3_NUCM.Value.ToString());
			if (m3_ASLA.HasValue)
				request.WithQueryParameter("ASLA", m3_ASLA.Value.ToString());
			if (m3_ASPC.HasValue)
				request.WithQueryParameter("ASPC", m3_ASPC.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
