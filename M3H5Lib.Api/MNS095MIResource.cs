/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MNS095MI;
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
	/// Name: MNS095MI
	/// Component Name: Company
	/// Description: Company interface
	/// Version Release: 13.1
	///</summary>
	public partial class MNS095MIResource : M3BaseResourceEndpoint
	{
		public MNS095MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MNS095MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add Company
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_MNVR">Menu version</param>
		/// <param name="m3_DFMN">Start menu</param>
		/// <param name="m3_MNMN">Menu maintenance</param>
		/// <param name="m3_STMN">Statement number</param>
		/// <param name="m3_CMTP">Company type</param>
		/// <param name="m3_CCUC">Central currency</param>
		/// <param name="m3_CCRT">Central rate type</param>
		/// <param name="m3_DBAS">Database</param>
		/// <param name="m3_LIB1">Library 1</param>
		/// <param name="m3_LIB2">Library 2</param>
		/// <param name="m3_LIB3">Library 3</param>
		/// <param name="m3_LIB4">Library 4</param>
		/// <param name="m3_LIB5">Library 5</param>
		/// <param name="m3_LIB6">Library 6</param>
		/// <param name="m3_LIB7">Library 7</param>
		/// <param name="m3_LIB8">Library 8</param>
		/// <param name="m3_LIB9">Library 9</param>
		/// <param name="m3_LIB0">Library 10</param>
		/// <param name="m3_DCFM">Decimal format</param>
		/// <param name="m3_MXV1">I-SWITCH</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			int m3_CONO, 
			string m3_TX40 = null, 
			string m3_MNVR = null, 
			string m3_DFMN = null, 
			int? m3_MNMN = null, 
			string m3_STMN = null, 
			int? m3_CMTP = null, 
			string m3_CCUC = null, 
			int? m3_CCRT = null, 
			string m3_DBAS = null, 
			string m3_LIB1 = null, 
			string m3_LIB2 = null, 
			string m3_LIB3 = null, 
			string m3_LIB4 = null, 
			string m3_LIB5 = null, 
			string m3_LIB6 = null, 
			string m3_LIB7 = null, 
			string m3_LIB8 = null, 
			string m3_LIB9 = null, 
			string m3_LIB0 = null, 
			string m3_DCFM = null, 
			string m3_MXV1 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MNVR))
				request.WithQueryParameter("MNVR", m3_MNVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DFMN))
				request.WithQueryParameter("DFMN", m3_DFMN.Trim());
			if (m3_MNMN.HasValue)
				request.WithQueryParameter("MNMN", m3_MNMN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STMN))
				request.WithQueryParameter("STMN", m3_STMN.Trim());
			if (m3_CMTP.HasValue)
				request.WithQueryParameter("CMTP", m3_CMTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CCUC))
				request.WithQueryParameter("CCUC", m3_CCUC.Trim());
			if (m3_CCRT.HasValue)
				request.WithQueryParameter("CCRT", m3_CCRT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DBAS))
				request.WithQueryParameter("DBAS", m3_DBAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LIB1))
				request.WithQueryParameter("LIB1", m3_LIB1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LIB2))
				request.WithQueryParameter("LIB2", m3_LIB2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LIB3))
				request.WithQueryParameter("LIB3", m3_LIB3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LIB4))
				request.WithQueryParameter("LIB4", m3_LIB4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LIB5))
				request.WithQueryParameter("LIB5", m3_LIB5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LIB6))
				request.WithQueryParameter("LIB6", m3_LIB6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LIB7))
				request.WithQueryParameter("LIB7", m3_LIB7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LIB8))
				request.WithQueryParameter("LIB8", m3_LIB8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LIB9))
				request.WithQueryParameter("LIB9", m3_LIB9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LIB0))
				request.WithQueryParameter("LIB0", m3_LIB0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DCFM))
				request.WithQueryParameter("DCFM", m3_DCFM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MXV1))
				request.WithQueryParameter("MXV1", m3_MXV1.Trim());

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
		/// Name Del
		/// Description Delete Company
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			int m3_CONO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Del",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString());

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
		/// Name Get
		/// Description Get Company
		/// Version Release: 13.
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			int m3_CONO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name Lst
		/// Description List Company
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Lst",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstResponse>(
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
		/// Name Upd
		/// Description Update Company
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_MNVR">Menu version</param>
		/// <param name="m3_DFMN">Start menu</param>
		/// <param name="m3_MNMN">Menu maintenance</param>
		/// <param name="m3_STMN">Statement number</param>
		/// <param name="m3_CMTP">Company type</param>
		/// <param name="m3_CCUC">Central currency</param>
		/// <param name="m3_CCRT">Central rate type</param>
		/// <param name="m3_DBAS">Database</param>
		/// <param name="m3_LIB1">Library 1</param>
		/// <param name="m3_LIB2">Library 2</param>
		/// <param name="m3_LIB3">Library 3</param>
		/// <param name="m3_LIB4">Library 4</param>
		/// <param name="m3_LIB5">Library 5</param>
		/// <param name="m3_LIB6">Library 6</param>
		/// <param name="m3_LIB7">Library 7</param>
		/// <param name="m3_LIB8">Library 8</param>
		/// <param name="m3_LIB9">Library 9</param>
		/// <param name="m3_LIB0">Library 10</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_DCFM">Decimal format</param>
		/// <param name="m3_MXV1">I-SWITCH</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			int m3_CONO, 
			string m3_TX40 = null, 
			string m3_MNVR = null, 
			string m3_DFMN = null, 
			int? m3_MNMN = null, 
			string m3_STMN = null, 
			int? m3_CMTP = null, 
			string m3_CCUC = null, 
			int? m3_CCRT = null, 
			string m3_DBAS = null, 
			string m3_LIB1 = null, 
			string m3_LIB2 = null, 
			string m3_LIB3 = null, 
			string m3_LIB4 = null, 
			string m3_LIB5 = null, 
			string m3_LIB6 = null, 
			string m3_LIB7 = null, 
			string m3_LIB8 = null, 
			string m3_LIB9 = null, 
			string m3_LIB0 = null, 
			decimal? m3_TXID = null, 
			string m3_DCFM = null, 
			string m3_MXV1 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Upd",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MNVR))
				request.WithQueryParameter("MNVR", m3_MNVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DFMN))
				request.WithQueryParameter("DFMN", m3_DFMN.Trim());
			if (m3_MNMN.HasValue)
				request.WithQueryParameter("MNMN", m3_MNMN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STMN))
				request.WithQueryParameter("STMN", m3_STMN.Trim());
			if (m3_CMTP.HasValue)
				request.WithQueryParameter("CMTP", m3_CMTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CCUC))
				request.WithQueryParameter("CCUC", m3_CCUC.Trim());
			if (m3_CCRT.HasValue)
				request.WithQueryParameter("CCRT", m3_CCRT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DBAS))
				request.WithQueryParameter("DBAS", m3_DBAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LIB1))
				request.WithQueryParameter("LIB1", m3_LIB1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LIB2))
				request.WithQueryParameter("LIB2", m3_LIB2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LIB3))
				request.WithQueryParameter("LIB3", m3_LIB3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LIB4))
				request.WithQueryParameter("LIB4", m3_LIB4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LIB5))
				request.WithQueryParameter("LIB5", m3_LIB5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LIB6))
				request.WithQueryParameter("LIB6", m3_LIB6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LIB7))
				request.WithQueryParameter("LIB7", m3_LIB7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LIB8))
				request.WithQueryParameter("LIB8", m3_LIB8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LIB9))
				request.WithQueryParameter("LIB9", m3_LIB9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LIB0))
				request.WithQueryParameter("LIB0", m3_LIB0.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DCFM))
				request.WithQueryParameter("DCFM", m3_DCFM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MXV1))
				request.WithQueryParameter("MXV1", m3_MXV1.Trim());

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
