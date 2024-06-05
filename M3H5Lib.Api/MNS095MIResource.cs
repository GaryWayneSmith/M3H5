/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3MNVR">Menu version</param>
		/// <param name="m3DFMN">Start menu</param>
		/// <param name="m3MNMN">Menu maintenance</param>
		/// <param name="m3STMN">Statement number</param>
		/// <param name="m3CMTP">Company type</param>
		/// <param name="m3CCUC">Central currency</param>
		/// <param name="m3CCRT">Central rate type</param>
		/// <param name="m3DBAS">Database</param>
		/// <param name="m3LIB1">Library 1</param>
		/// <param name="m3LIB2">Library 2</param>
		/// <param name="m3LIB3">Library 3</param>
		/// <param name="m3LIB4">Library 4</param>
		/// <param name="m3LIB5">Library 5</param>
		/// <param name="m3LIB6">Library 6</param>
		/// <param name="m3LIB7">Library 7</param>
		/// <param name="m3LIB8">Library 8</param>
		/// <param name="m3LIB9">Library 9</param>
		/// <param name="m3LIB0">Library 10</param>
		/// <param name="m3DCFM">Decimal format</param>
		/// <param name="m3MXV1">I-SWITCH</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			int m3CONO, 
			string m3TX40 = null, 
			string m3MNVR = null, 
			string m3DFMN = null, 
			int? m3MNMN = null, 
			string m3STMN = null, 
			int? m3CMTP = null, 
			string m3CCUC = null, 
			int? m3CCRT = null, 
			string m3DBAS = null, 
			string m3LIB1 = null, 
			string m3LIB2 = null, 
			string m3LIB3 = null, 
			string m3LIB4 = null, 
			string m3LIB5 = null, 
			string m3LIB6 = null, 
			string m3LIB7 = null, 
			string m3LIB8 = null, 
			string m3LIB9 = null, 
			string m3LIB0 = null, 
			string m3DCFM = null, 
			string m3MXV1 = null, 
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
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3MNVR))
				request.WithQueryParameter("MNVR", m3MNVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DFMN))
				request.WithQueryParameter("DFMN", m3DFMN.Trim());
			if (m3MNMN.HasValue)
				request.WithQueryParameter("MNMN", m3MNMN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STMN))
				request.WithQueryParameter("STMN", m3STMN.Trim());
			if (m3CMTP.HasValue)
				request.WithQueryParameter("CMTP", m3CMTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CCUC))
				request.WithQueryParameter("CCUC", m3CCUC.Trim());
			if (m3CCRT.HasValue)
				request.WithQueryParameter("CCRT", m3CCRT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DBAS))
				request.WithQueryParameter("DBAS", m3DBAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3LIB1))
				request.WithQueryParameter("LIB1", m3LIB1.Trim());
			if (!string.IsNullOrWhiteSpace(m3LIB2))
				request.WithQueryParameter("LIB2", m3LIB2.Trim());
			if (!string.IsNullOrWhiteSpace(m3LIB3))
				request.WithQueryParameter("LIB3", m3LIB3.Trim());
			if (!string.IsNullOrWhiteSpace(m3LIB4))
				request.WithQueryParameter("LIB4", m3LIB4.Trim());
			if (!string.IsNullOrWhiteSpace(m3LIB5))
				request.WithQueryParameter("LIB5", m3LIB5.Trim());
			if (!string.IsNullOrWhiteSpace(m3LIB6))
				request.WithQueryParameter("LIB6", m3LIB6.Trim());
			if (!string.IsNullOrWhiteSpace(m3LIB7))
				request.WithQueryParameter("LIB7", m3LIB7.Trim());
			if (!string.IsNullOrWhiteSpace(m3LIB8))
				request.WithQueryParameter("LIB8", m3LIB8.Trim());
			if (!string.IsNullOrWhiteSpace(m3LIB9))
				request.WithQueryParameter("LIB9", m3LIB9.Trim());
			if (!string.IsNullOrWhiteSpace(m3LIB0))
				request.WithQueryParameter("LIB0", m3LIB0.Trim());
			if (!string.IsNullOrWhiteSpace(m3DCFM))
				request.WithQueryParameter("DCFM", m3DCFM.Trim());
			if (!string.IsNullOrWhiteSpace(m3MXV1))
				request.WithQueryParameter("MXV1", m3MXV1.Trim());

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
		/// Name Del
		/// Description Delete Company
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			int m3CONO, 
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
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture));

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
		/// Name Get
		/// Description Get Company
		/// Version Release: 13.
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			int m3CONO, 
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
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name Lst
		/// Description List Company
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			int? m3CONO = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstResponse>(
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
		/// Name Upd
		/// Description Update Company
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3MNVR">Menu version</param>
		/// <param name="m3DFMN">Start menu</param>
		/// <param name="m3MNMN">Menu maintenance</param>
		/// <param name="m3STMN">Statement number</param>
		/// <param name="m3CMTP">Company type</param>
		/// <param name="m3CCUC">Central currency</param>
		/// <param name="m3CCRT">Central rate type</param>
		/// <param name="m3DBAS">Database</param>
		/// <param name="m3LIB1">Library 1</param>
		/// <param name="m3LIB2">Library 2</param>
		/// <param name="m3LIB3">Library 3</param>
		/// <param name="m3LIB4">Library 4</param>
		/// <param name="m3LIB5">Library 5</param>
		/// <param name="m3LIB6">Library 6</param>
		/// <param name="m3LIB7">Library 7</param>
		/// <param name="m3LIB8">Library 8</param>
		/// <param name="m3LIB9">Library 9</param>
		/// <param name="m3LIB0">Library 10</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3DCFM">Decimal format</param>
		/// <param name="m3MXV1">I-SWITCH</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			int m3CONO, 
			string m3TX40 = null, 
			string m3MNVR = null, 
			string m3DFMN = null, 
			int? m3MNMN = null, 
			string m3STMN = null, 
			int? m3CMTP = null, 
			string m3CCUC = null, 
			int? m3CCRT = null, 
			string m3DBAS = null, 
			string m3LIB1 = null, 
			string m3LIB2 = null, 
			string m3LIB3 = null, 
			string m3LIB4 = null, 
			string m3LIB5 = null, 
			string m3LIB6 = null, 
			string m3LIB7 = null, 
			string m3LIB8 = null, 
			string m3LIB9 = null, 
			string m3LIB0 = null, 
			decimal? m3TXID = null, 
			string m3DCFM = null, 
			string m3MXV1 = null, 
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
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3MNVR))
				request.WithQueryParameter("MNVR", m3MNVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DFMN))
				request.WithQueryParameter("DFMN", m3DFMN.Trim());
			if (m3MNMN.HasValue)
				request.WithQueryParameter("MNMN", m3MNMN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STMN))
				request.WithQueryParameter("STMN", m3STMN.Trim());
			if (m3CMTP.HasValue)
				request.WithQueryParameter("CMTP", m3CMTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CCUC))
				request.WithQueryParameter("CCUC", m3CCUC.Trim());
			if (m3CCRT.HasValue)
				request.WithQueryParameter("CCRT", m3CCRT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DBAS))
				request.WithQueryParameter("DBAS", m3DBAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3LIB1))
				request.WithQueryParameter("LIB1", m3LIB1.Trim());
			if (!string.IsNullOrWhiteSpace(m3LIB2))
				request.WithQueryParameter("LIB2", m3LIB2.Trim());
			if (!string.IsNullOrWhiteSpace(m3LIB3))
				request.WithQueryParameter("LIB3", m3LIB3.Trim());
			if (!string.IsNullOrWhiteSpace(m3LIB4))
				request.WithQueryParameter("LIB4", m3LIB4.Trim());
			if (!string.IsNullOrWhiteSpace(m3LIB5))
				request.WithQueryParameter("LIB5", m3LIB5.Trim());
			if (!string.IsNullOrWhiteSpace(m3LIB6))
				request.WithQueryParameter("LIB6", m3LIB6.Trim());
			if (!string.IsNullOrWhiteSpace(m3LIB7))
				request.WithQueryParameter("LIB7", m3LIB7.Trim());
			if (!string.IsNullOrWhiteSpace(m3LIB8))
				request.WithQueryParameter("LIB8", m3LIB8.Trim());
			if (!string.IsNullOrWhiteSpace(m3LIB9))
				request.WithQueryParameter("LIB9", m3LIB9.Trim());
			if (!string.IsNullOrWhiteSpace(m3LIB0))
				request.WithQueryParameter("LIB0", m3LIB0.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DCFM))
				request.WithQueryParameter("DCFM", m3DCFM.Trim());
			if (!string.IsNullOrWhiteSpace(m3MXV1))
				request.WithQueryParameter("MXV1", m3MXV1.Trim());

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
