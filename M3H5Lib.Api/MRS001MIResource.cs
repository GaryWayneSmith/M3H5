/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MRS001MI;
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
	/// Name: MRS001MI
	/// Component Name: MIRepository
	/// Description: MI-Repository interface
	/// Version Release: 5ea2
	///</summary>
	public partial class MRS001MIResource : M3BaseResourceEndpoint
	{
		public MRS001MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MRS001MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddField
		/// Description Add field details
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MINM">Program name (Required)</param>
		/// <param name="m3_TRNM">Transaction name (Required)</param>
		/// <param name="m3_TRTP">Input/Output (Required)</param>
		/// <param name="m3_FLNM">Field name (Required)</param>
		/// <param name="m3_FRPO">From position (Required)</param>
		/// <param name="m3_LENG">Length (Required)</param>
		/// <param name="m3_TYPE">Field type A=Alphanumeric, N=Numeric (Required)</param>
		/// <param name="m3_FLDS">Description</param>
		/// <param name="m3_TXT1">Text ID</param>
		/// <param name="m3_TOPO">To position</param>
		/// <param name="m3_MAND">Mandatory</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddField(
			string m3_MINM, 
			string m3_TRNM, 
			string m3_TRTP, 
			string m3_FLNM, 
			int m3_FRPO, 
			int m3_LENG, 
			string m3_TYPE, 
			string m3_FLDS = null, 
			decimal? m3_TXT1 = null, 
			int? m3_TOPO = null, 
			string m3_MAND = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddField",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MINM))
				throw new ArgumentNullException("m3_MINM");
			if (string.IsNullOrWhiteSpace(m3_TRNM))
				throw new ArgumentNullException("m3_TRNM");
			if (string.IsNullOrWhiteSpace(m3_TRTP))
				throw new ArgumentNullException("m3_TRTP");
			if (string.IsNullOrWhiteSpace(m3_FLNM))
				throw new ArgumentNullException("m3_FLNM");
			if (string.IsNullOrWhiteSpace(m3_TYPE))
				throw new ArgumentNullException("m3_TYPE");

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3_MINM.Trim())
				.WithQueryParameter("TRNM", m3_TRNM.Trim())
				.WithQueryParameter("TRTP", m3_TRTP.Trim())
				.WithQueryParameter("FLNM", m3_FLNM.Trim())
				.WithQueryParameter("FRPO", m3_FRPO.ToString())
				.WithQueryParameter("LENG", m3_LENG.ToString())
				.WithQueryParameter("TYPE", m3_TYPE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FLDS))
				request.WithQueryParameter("FLDS", m3_FLDS.Trim());
			if (m3_TXT1.HasValue)
				request.WithQueryParameter("TXT1", m3_TXT1.Value.ToString());
			if (m3_TOPO.HasValue)
				request.WithQueryParameter("TOPO", m3_TOPO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MAND))
				request.WithQueryParameter("MAND", m3_MAND.Trim());

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
		/// Name AddProgram
		/// Description Add program details
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MINM">Associated MI-program (Required)</param>
		/// <param name="m3_OBNM">Object (Required)</param>
		/// <param name="m3_MIDS">Description (Required)</param>
		/// <param name="m3_TXT1">Text ID for leading description</param>
		/// <param name="m3_TXT2">Text ID for trailing description</param>
		/// <param name="m3_RGDT">Not used!</param>
		/// <param name="m3_RGTM">Not used!</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="m3_MNID">Classification</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddProgram(
			string m3_MINM, 
			string m3_OBNM, 
			string m3_MIDS, 
			decimal? m3_TXT1 = null, 
			decimal? m3_TXT2 = null, 
			int? m3_RGDT = null, 
			int? m3_RGTM = null, 
			string m3_VERS = null, 
			string m3_MNID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddProgram",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MINM))
				throw new ArgumentNullException("m3_MINM");
			if (string.IsNullOrWhiteSpace(m3_OBNM))
				throw new ArgumentNullException("m3_OBNM");
			if (string.IsNullOrWhiteSpace(m3_MIDS))
				throw new ArgumentNullException("m3_MIDS");

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3_MINM.Trim())
				.WithQueryParameter("OBNM", m3_OBNM.Trim())
				.WithQueryParameter("MIDS", m3_MIDS.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_TXT1.HasValue)
				request.WithQueryParameter("TXT1", m3_TXT1.Value.ToString());
			if (m3_TXT2.HasValue)
				request.WithQueryParameter("TXT2", m3_TXT2.Value.ToString());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToString());
			if (m3_RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3_RGTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_VERS))
				request.WithQueryParameter("VERS", m3_VERS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MNID))
				request.WithQueryParameter("MNID", m3_MNID.Trim());

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
		/// Name AddText
		/// Description Add text to components
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MINM">Program name (Required)</param>
		/// <param name="m3_TXTP">0 = Pre-text/1 = Post-text</param>
		/// <param name="m3_TRNM">Transaction name</param>
		/// <param name="m3_TRTP">Input/Output</param>
		/// <param name="m3_FLNM">Field name</param>
		/// <param name="m3_TX60">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddText(
			string m3_MINM, 
			int? m3_TXTP = null, 
			string m3_TRNM = null, 
			string m3_TRTP = null, 
			string m3_FLNM = null, 
			string m3_TX60 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MINM))
				throw new ArgumentNullException("m3_MINM");

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3_MINM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_TXTP.HasValue)
				request.WithQueryParameter("TXTP", m3_TXTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TRNM))
				request.WithQueryParameter("TRNM", m3_TRNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRTP))
				request.WithQueryParameter("TRTP", m3_TRTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLNM))
				request.WithQueryParameter("FLNM", m3_FLNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX60))
				request.WithQueryParameter("TX60", m3_TX60.Trim());

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
		/// Name AddTransaction
		/// Description Add transaction details
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MINM">Program name (Required)</param>
		/// <param name="m3_TRNM">Transaction name (Required)</param>
		/// <param name="m3_TRDS">Transaction description (Required)</param>
		/// <param name="m3_SIMU">Transaction type, Single/Multiple (Required)</param>
		/// <param name="m3_TXT1">Text ID of leading description</param>
		/// <param name="m3_TXT2">Text ID of trailing description</param>
		/// <param name="m3_VERS">Movex version/release</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_PRFI">Prefix input</param>
		/// <param name="m3_PRFO">Prefix output</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddTransaction(
			string m3_MINM, 
			string m3_TRNM, 
			string m3_TRDS, 
			string m3_SIMU, 
			decimal? m3_TXT1 = null, 
			decimal? m3_TXT2 = null, 
			string m3_VERS = null, 
			int? m3_STAT = null, 
			string m3_PRFI = null, 
			string m3_PRFO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddTransaction",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MINM))
				throw new ArgumentNullException("m3_MINM");
			if (string.IsNullOrWhiteSpace(m3_TRNM))
				throw new ArgumentNullException("m3_TRNM");
			if (string.IsNullOrWhiteSpace(m3_TRDS))
				throw new ArgumentNullException("m3_TRDS");
			if (string.IsNullOrWhiteSpace(m3_SIMU))
				throw new ArgumentNullException("m3_SIMU");

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3_MINM.Trim())
				.WithQueryParameter("TRNM", m3_TRNM.Trim())
				.WithQueryParameter("TRDS", m3_TRDS.Trim())
				.WithQueryParameter("SIMU", m3_SIMU.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_TXT1.HasValue)
				request.WithQueryParameter("TXT1", m3_TXT1.Value.ToString());
			if (m3_TXT2.HasValue)
				request.WithQueryParameter("TXT2", m3_TXT2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_VERS))
				request.WithQueryParameter("VERS", m3_VERS.Trim());
			if (m3_STAT.HasValue)
				request.WithQueryParameter("STAT", m3_STAT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRFI))
				request.WithQueryParameter("PRFI", m3_PRFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRFO))
				request.WithQueryParameter("PRFO", m3_PRFO.Trim());

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
		/// Name ClearCache
		/// Description Clear MIWS Cache
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_MINM">MI Program name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ClearCache(
			string m3_MINM, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ClearCache",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MINM))
				throw new ArgumentNullException("m3_MINM");

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3_MINM.Trim());

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
		/// Name CpyTransaction
		/// Description Copy a transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FRMI">From program (Required)</param>
		/// <param name="m3_FRTR">From transaction (Required)</param>
		/// <param name="m3_TOMI">To program (Required)</param>
		/// <param name="m3_TOTR">To transaction</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyTransaction(
			string m3_FRMI, 
			string m3_FRTR, 
			string m3_TOMI, 
			string m3_TOTR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyTransaction",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FRMI))
				throw new ArgumentNullException("m3_FRMI");
			if (string.IsNullOrWhiteSpace(m3_FRTR))
				throw new ArgumentNullException("m3_FRTR");
			if (string.IsNullOrWhiteSpace(m3_TOMI))
				throw new ArgumentNullException("m3_TOMI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FRMI", m3_FRMI.Trim())
				.WithQueryParameter("FRTR", m3_FRTR.Trim())
				.WithQueryParameter("TOMI", m3_TOMI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TOTR))
				request.WithQueryParameter("TOTR", m3_TOTR.Trim());

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
		/// Name DelField
		/// Description Delete a field from a program/transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MINM">Program name (Required)</param>
		/// <param name="m3_TRNM">Transaction name (Required)</param>
		/// <param name="m3_TRTP">Layout type, Input/Output (Required)</param>
		/// <param name="m3_FLNM">Field name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelField(
			string m3_MINM, 
			string m3_TRNM, 
			string m3_TRTP, 
			string m3_FLNM, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelField",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MINM))
				throw new ArgumentNullException("m3_MINM");
			if (string.IsNullOrWhiteSpace(m3_TRNM))
				throw new ArgumentNullException("m3_TRNM");
			if (string.IsNullOrWhiteSpace(m3_TRTP))
				throw new ArgumentNullException("m3_TRTP");
			if (string.IsNullOrWhiteSpace(m3_FLNM))
				throw new ArgumentNullException("m3_FLNM");

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3_MINM.Trim())
				.WithQueryParameter("TRNM", m3_TRNM.Trim())
				.WithQueryParameter("TRTP", m3_TRTP.Trim())
				.WithQueryParameter("FLNM", m3_FLNM.Trim());

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
		/// Name DelProgram
		/// Description Delete complete program
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MINM">Program name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelProgram(
			string m3_MINM, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelProgram",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MINM))
				throw new ArgumentNullException("m3_MINM");

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3_MINM.Trim());

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
		/// Name DelText
		/// Description Delete text
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MINM">Program name (Required)</param>
		/// <param name="m3_TXTP">0 = Pre-text/1 = Post-text</param>
		/// <param name="m3_TRNM">Transaction name</param>
		/// <param name="m3_TRTP">Input/Output</param>
		/// <param name="m3_FLNM">Field name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelText(
			string m3_MINM, 
			int? m3_TXTP = null, 
			string m3_TRNM = null, 
			string m3_TRTP = null, 
			string m3_FLNM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MINM))
				throw new ArgumentNullException("m3_MINM");

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3_MINM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_TXTP.HasValue)
				request.WithQueryParameter("TXTP", m3_TXTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TRNM))
				request.WithQueryParameter("TRNM", m3_TRNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRTP))
				request.WithQueryParameter("TRTP", m3_TRTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLNM))
				request.WithQueryParameter("FLNM", m3_FLNM.Trim());

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
		/// Name DelTransaction
		/// Description Delete complete transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MINM">Program name (Required)</param>
		/// <param name="m3_TRNM">Transaction name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelTransaction(
			string m3_MINM, 
			string m3_TRNM, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelTransaction",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MINM))
				throw new ArgumentNullException("m3_MINM");
			if (string.IsNullOrWhiteSpace(m3_TRNM))
				throw new ArgumentNullException("m3_TRNM");

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3_MINM.Trim())
				.WithQueryParameter("TRNM", m3_TRNM.Trim());

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
		/// Name GetField
		/// Description Retrieve detailed information about given field
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MINM">Program name (Required)</param>
		/// <param name="m3_TRNM">Transaction name (Required)</param>
		/// <param name="m3_TRTP">Layout type, Input/Output (Required)</param>
		/// <param name="m3_FLNM">Field name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFieldResponse></returns>
		/// <exception cref="M3Exception<GetFieldResponse>"></exception>
		public async Task<M3Response<GetFieldResponse>> GetField(
			string m3_MINM, 
			string m3_TRNM, 
			string m3_TRTP, 
			string m3_FLNM, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetField",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MINM))
				throw new ArgumentNullException("m3_MINM");
			if (string.IsNullOrWhiteSpace(m3_TRNM))
				throw new ArgumentNullException("m3_TRNM");
			if (string.IsNullOrWhiteSpace(m3_TRTP))
				throw new ArgumentNullException("m3_TRTP");
			if (string.IsNullOrWhiteSpace(m3_FLNM))
				throw new ArgumentNullException("m3_FLNM");

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3_MINM.Trim())
				.WithQueryParameter("TRNM", m3_TRNM.Trim())
				.WithQueryParameter("TRTP", m3_TRTP.Trim())
				.WithQueryParameter("FLNM", m3_FLNM.Trim());

			// Execute the request
			var result = await Execute<GetFieldResponse>(
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
		/// Name GetFieldInfo
		/// Description Info for a specific table and field
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_FLNA">Field name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFieldInfoResponse></returns>
		/// <exception cref="M3Exception<GetFieldInfoResponse>"></exception>
		public async Task<M3Response<GetFieldInfoResponse>> GetFieldInfo(
			string m3_FILE, 
			string m3_FLNA, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetFieldInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FLNA))
				throw new ArgumentNullException("m3_FLNA");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FLNA", m3_FLNA.Trim());

			// Execute the request
			var result = await Execute<GetFieldInfoResponse>(
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
		/// Name GetProgram
		/// Description Get program details
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MINM">Program name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetProgramResponse></returns>
		/// <exception cref="M3Exception<GetProgramResponse>"></exception>
		public async Task<M3Response<GetProgramResponse>> GetProgram(
			string m3_MINM, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetProgram",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MINM))
				throw new ArgumentNullException("m3_MINM");

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3_MINM.Trim());

			// Execute the request
			var result = await Execute<GetProgramResponse>(
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
		/// Name GetText
		/// Description Not to be used - See LstText
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TXID">Text identity (Required)</param>
		/// <param name="m3_TXVR">Text block</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTextResponse></returns>
		/// <exception cref="M3Exception<GetTextResponse>"></exception>
		public async Task<M3Response<GetTextResponse>> GetText(
			decimal m3_TXID, 
			string m3_TXVR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetText",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("TXID", m3_TXID.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TXVR))
				request.WithQueryParameter("TXVR", m3_TXVR.Trim());

			// Execute the request
			var result = await Execute<GetTextResponse>(
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
		/// Name GetTransaction
		/// Description Get transaction details
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MINM">Program name (Required)</param>
		/// <param name="m3_TRNM">Transaction name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTransactionResponse></returns>
		/// <exception cref="M3Exception<GetTransactionResponse>"></exception>
		public async Task<M3Response<GetTransactionResponse>> GetTransaction(
			string m3_MINM, 
			string m3_TRNM, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetTransaction",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MINM))
				throw new ArgumentNullException("m3_MINM");
			if (string.IsNullOrWhiteSpace(m3_TRNM))
				throw new ArgumentNullException("m3_TRNM");

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3_MINM.Trim())
				.WithQueryParameter("TRNM", m3_TRNM.Trim());

			// Execute the request
			var result = await Execute<GetTransactionResponse>(
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
		/// Name LstAdtFieldInf
		/// Description List additional field information
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_MINM">Program name (Required)</param>
		/// <param name="m3_TRNM">Transaction name (Required)</param>
		/// <param name="m3_TRTP">Layout type, Input/Output (Required)</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAdtFieldInfResponse></returns>
		/// <exception cref="M3Exception<LstAdtFieldInfResponse>"></exception>
		public async Task<M3Response<LstAdtFieldInfResponse>> LstAdtFieldInf(
			string m3_MINM, 
			string m3_TRNM, 
			string m3_TRTP, 
			string m3_LNCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAdtFieldInf",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MINM))
				throw new ArgumentNullException("m3_MINM");
			if (string.IsNullOrWhiteSpace(m3_TRNM))
				throw new ArgumentNullException("m3_TRNM");
			if (string.IsNullOrWhiteSpace(m3_TRTP))
				throw new ArgumentNullException("m3_TRTP");

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3_MINM.Trim())
				.WithQueryParameter("TRNM", m3_TRNM.Trim())
				.WithQueryParameter("TRTP", m3_TRTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<LstAdtFieldInfResponse>(
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
		/// Name LstAllTrans
		/// Description List transactions from all programs
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TRNM">Transaction prefix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAllTransResponse></returns>
		/// <exception cref="M3Exception<LstAllTransResponse>"></exception>
		public async Task<M3Response<LstAllTransResponse>> LstAllTrans(
			string m3_TRNM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAllTrans",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TRNM))
				request.WithQueryParameter("TRNM", m3_TRNM.Trim());

			// Execute the request
			var result = await Execute<LstAllTransResponse>(
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
		/// Name LstClasses
		/// Description List classes
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_MNID">Parent classification</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstClassesResponse></returns>
		/// <exception cref="M3Exception<LstClassesResponse>"></exception>
		public async Task<M3Response<LstClassesResponse>> LstClasses(
			string m3_MNID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstClasses",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MNID))
				request.WithQueryParameter("MNID", m3_MNID.Trim());

			// Execute the request
			var result = await Execute<LstClassesResponse>(
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
		/// Name LstComponents
		/// Description List all components
		/// Version Release: 14.x
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstComponentsResponse></returns>
		/// <exception cref="M3Exception<LstComponentsResponse>"></exception>
		public async Task<M3Response<LstComponentsResponse>> LstComponents(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstComponents",
			};

			// Execute the request
			var result = await Execute<LstComponentsResponse>(
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
		/// Name LstFieldInfo
		/// Description Retrieve field info for a table
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFieldInfoResponse></returns>
		/// <exception cref="M3Exception<LstFieldInfoResponse>"></exception>
		public async Task<M3Response<LstFieldInfoResponse>> LstFieldInfo(
			string m3_FILE, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFieldInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim());

			// Execute the request
			var result = await Execute<LstFieldInfoResponse>(
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
		/// Name LstFields
		/// Description List all fields for a transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MINM">Program name (Required)</param>
		/// <param name="m3_TRNM">Transaction name (Required)</param>
		/// <param name="m3_TRTP">Layout type, Input/Output (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFieldsResponse></returns>
		/// <exception cref="M3Exception<LstFieldsResponse>"></exception>
		public async Task<M3Response<LstFieldsResponse>> LstFields(
			string m3_MINM, 
			string m3_TRNM, 
			string m3_TRTP, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFields",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MINM))
				throw new ArgumentNullException("m3_MINM");
			if (string.IsNullOrWhiteSpace(m3_TRNM))
				throw new ArgumentNullException("m3_TRNM");
			if (string.IsNullOrWhiteSpace(m3_TRTP))
				throw new ArgumentNullException("m3_TRTP");

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3_MINM.Trim())
				.WithQueryParameter("TRNM", m3_TRNM.Trim())
				.WithQueryParameter("TRTP", m3_TRTP.Trim());

			// Execute the request
			var result = await Execute<LstFieldsResponse>(
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
		/// Name LstFldHeadings
		/// Description List field headings in user or specified language.
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MINM">Program name (Required)</param>
		/// <param name="m3_TRNM">Transaction name (Required)</param>
		/// <param name="m3_TRTP">Layout type, Input/Output (Required)</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFldHeadingsResponse></returns>
		/// <exception cref="M3Exception<LstFldHeadingsResponse>"></exception>
		public async Task<M3Response<LstFldHeadingsResponse>> LstFldHeadings(
			string m3_MINM, 
			string m3_TRNM, 
			string m3_TRTP, 
			string m3_LNCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFldHeadings",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MINM))
				throw new ArgumentNullException("m3_MINM");
			if (string.IsNullOrWhiteSpace(m3_TRNM))
				throw new ArgumentNullException("m3_TRNM");
			if (string.IsNullOrWhiteSpace(m3_TRTP))
				throw new ArgumentNullException("m3_TRTP");

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3_MINM.Trim())
				.WithQueryParameter("TRNM", m3_TRNM.Trim())
				.WithQueryParameter("TRTP", m3_TRTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<LstFldHeadingsResponse>(
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
		/// Name LstLFFields
		/// Description List logical file fields
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_INDX">File index number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLFFieldsResponse></returns>
		/// <exception cref="M3Exception<LstLFFieldsResponse>"></exception>
		public async Task<M3Response<LstLFFieldsResponse>> LstLFFields(
			string m3_FILE, 
			string m3_INDX, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLFFields",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_INDX))
				throw new ArgumentNullException("m3_INDX");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("INDX", m3_INDX.Trim());

			// Execute the request
			var result = await Execute<LstLFFieldsResponse>(
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
		/// Name LstLogicalFiles
		/// Description LstLogicalFiles
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FILE">Physical file name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLogicalFilesResponse></returns>
		/// <exception cref="M3Exception<LstLogicalFilesResponse>"></exception>
		public async Task<M3Response<LstLogicalFilesResponse>> LstLogicalFiles(
			string m3_FILE, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLogicalFiles",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim());

			// Execute the request
			var result = await Execute<LstLogicalFilesResponse>(
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
		/// Name LstProgramClass
		/// Description List MI programs for given a classification
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_MNID">Classification</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstProgramClassResponse></returns>
		/// <exception cref="M3Exception<LstProgramClassResponse>"></exception>
		public async Task<M3Response<LstProgramClassResponse>> LstProgramClass(
			string m3_MNID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstProgramClass",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MNID))
				request.WithQueryParameter("MNID", m3_MNID.Trim());

			// Execute the request
			var result = await Execute<LstProgramClassResponse>(
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
		/// Name LstPrograms
		/// Description List all programs
		/// Version Release: 14.x
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstProgramsResponse></returns>
		/// <exception cref="M3Exception<LstProgramsResponse>"></exception>
		public async Task<M3Response<LstProgramsResponse>> LstPrograms(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPrograms",
			};

			// Execute the request
			var result = await Execute<LstProgramsResponse>(
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
		/// Name LstText
		/// Description List text connected to program, transaction or field
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TXID">Text identity (Required)</param>
		/// <param name="m3_TXVR">Text block</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTextResponse></returns>
		/// <exception cref="M3Exception<LstTextResponse>"></exception>
		public async Task<M3Response<LstTextResponse>> LstText(
			decimal m3_TXID, 
			string m3_TXVR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstText",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("TXID", m3_TXID.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TXVR))
				request.WithQueryParameter("TXVR", m3_TXVR.Trim());

			// Execute the request
			var result = await Execute<LstTextResponse>(
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
		/// Name LstTransactions
		/// Description List available transactions for given program
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MINM">Program name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTransactionsResponse></returns>
		/// <exception cref="M3Exception<LstTransactionsResponse>"></exception>
		public async Task<M3Response<LstTransactionsResponse>> LstTransactions(
			string m3_MINM, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTransactions",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MINM))
				throw new ArgumentNullException("m3_MINM");

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3_MINM.Trim());

			// Execute the request
			var result = await Execute<LstTransactionsResponse>(
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
		/// Name Recalculate
		/// Description Recalculate transaction layout based on lengths
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_MINM">MI Program name (Required)</param>
		/// <param name="m3_TRNM">Transaction (Required)</param>
		/// <param name="m3_TRTP">Transaction type I/O (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Recalculate(
			string m3_MINM, 
			string m3_TRNM, 
			string m3_TRTP, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Recalculate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MINM))
				throw new ArgumentNullException("m3_MINM");
			if (string.IsNullOrWhiteSpace(m3_TRNM))
				throw new ArgumentNullException("m3_TRNM");
			if (string.IsNullOrWhiteSpace(m3_TRTP))
				throw new ArgumentNullException("m3_TRTP");

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3_MINM.Trim())
				.WithQueryParameter("TRNM", m3_TRNM.Trim())
				.WithQueryParameter("TRTP", m3_TRTP.Trim());

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
		/// Name UpdField
		/// Description Update field information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MINM">Program name (Required)</param>
		/// <param name="m3_TRNM">Transaction name (Required)</param>
		/// <param name="m3_TRTP">Input/Output (Required)</param>
		/// <param name="m3_FLNM">Field name (Required)</param>
		/// <param name="m3_FLDS">Description</param>
		/// <param name="m3_TXT1">Text ID</param>
		/// <param name="m3_FRPO">From position</param>
		/// <param name="m3_TOPO">To position</param>
		/// <param name="m3_LENG">Length</param>
		/// <param name="m3_TYPE">Field type A=Alphanumeric, N=Numeric</param>
		/// <param name="m3_MAND">Mandatory</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdField(
			string m3_MINM, 
			string m3_TRNM, 
			string m3_TRTP, 
			string m3_FLNM, 
			string m3_FLDS = null, 
			decimal? m3_TXT1 = null, 
			int? m3_FRPO = null, 
			int? m3_TOPO = null, 
			int? m3_LENG = null, 
			string m3_TYPE = null, 
			string m3_MAND = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdField",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MINM))
				throw new ArgumentNullException("m3_MINM");
			if (string.IsNullOrWhiteSpace(m3_TRNM))
				throw new ArgumentNullException("m3_TRNM");
			if (string.IsNullOrWhiteSpace(m3_TRTP))
				throw new ArgumentNullException("m3_TRTP");
			if (string.IsNullOrWhiteSpace(m3_FLNM))
				throw new ArgumentNullException("m3_FLNM");

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3_MINM.Trim())
				.WithQueryParameter("TRNM", m3_TRNM.Trim())
				.WithQueryParameter("TRTP", m3_TRTP.Trim())
				.WithQueryParameter("FLNM", m3_FLNM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FLDS))
				request.WithQueryParameter("FLDS", m3_FLDS.Trim());
			if (m3_TXT1.HasValue)
				request.WithQueryParameter("TXT1", m3_TXT1.Value.ToString());
			if (m3_FRPO.HasValue)
				request.WithQueryParameter("FRPO", m3_FRPO.Value.ToString());
			if (m3_TOPO.HasValue)
				request.WithQueryParameter("TOPO", m3_TOPO.Value.ToString());
			if (m3_LENG.HasValue)
				request.WithQueryParameter("LENG", m3_LENG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TYPE))
				request.WithQueryParameter("TYPE", m3_TYPE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MAND))
				request.WithQueryParameter("MAND", m3_MAND.Trim());

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
		/// Name UpdProgram
		/// Description Change values on a program
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MINM">Associated MI-program (Required)</param>
		/// <param name="m3_OBNM">Object</param>
		/// <param name="m3_MIDS">Description</param>
		/// <param name="m3_TXT1">Text ID for leading description</param>
		/// <param name="m3_TXT2">Text ID for trailing description</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="m3_MNID">Classification</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdProgram(
			string m3_MINM, 
			string m3_OBNM = null, 
			string m3_MIDS = null, 
			decimal? m3_TXT1 = null, 
			decimal? m3_TXT2 = null, 
			string m3_VERS = null, 
			string m3_MNID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdProgram",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MINM))
				throw new ArgumentNullException("m3_MINM");

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3_MINM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBNM))
				request.WithQueryParameter("OBNM", m3_OBNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MIDS))
				request.WithQueryParameter("MIDS", m3_MIDS.Trim());
			if (m3_TXT1.HasValue)
				request.WithQueryParameter("TXT1", m3_TXT1.Value.ToString());
			if (m3_TXT2.HasValue)
				request.WithQueryParameter("TXT2", m3_TXT2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_VERS))
				request.WithQueryParameter("VERS", m3_VERS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MNID))
				request.WithQueryParameter("MNID", m3_MNID.Trim());

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
		/// Name UpdTransaction
		/// Description Change values in a transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MINM">Program name (Required)</param>
		/// <param name="m3_TRNM">Transaction name (Required)</param>
		/// <param name="m3_TRDS">Transaction description</param>
		/// <param name="m3_TXT1">Text ID of leading description</param>
		/// <param name="m3_TXT2">Text ID of trailing description</param>
		/// <param name="m3_VERS">Movex version/release</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_PRFI">Prefix input</param>
		/// <param name="m3_PRFO">Prefix output</param>
		/// <param name="m3_SIMU">Transaction type, Single/Multiple</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdTransaction(
			string m3_MINM, 
			string m3_TRNM, 
			string m3_TRDS = null, 
			decimal? m3_TXT1 = null, 
			decimal? m3_TXT2 = null, 
			string m3_VERS = null, 
			int? m3_STAT = null, 
			string m3_PRFI = null, 
			string m3_PRFO = null, 
			string m3_SIMU = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdTransaction",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MINM))
				throw new ArgumentNullException("m3_MINM");
			if (string.IsNullOrWhiteSpace(m3_TRNM))
				throw new ArgumentNullException("m3_TRNM");

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3_MINM.Trim())
				.WithQueryParameter("TRNM", m3_TRNM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TRDS))
				request.WithQueryParameter("TRDS", m3_TRDS.Trim());
			if (m3_TXT1.HasValue)
				request.WithQueryParameter("TXT1", m3_TXT1.Value.ToString());
			if (m3_TXT2.HasValue)
				request.WithQueryParameter("TXT2", m3_TXT2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_VERS))
				request.WithQueryParameter("VERS", m3_VERS.Trim());
			if (m3_STAT.HasValue)
				request.WithQueryParameter("STAT", m3_STAT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRFI))
				request.WithQueryParameter("PRFI", m3_PRFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRFO))
				request.WithQueryParameter("PRFO", m3_PRFO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SIMU))
				request.WithQueryParameter("SIMU", m3_SIMU.Trim());

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
