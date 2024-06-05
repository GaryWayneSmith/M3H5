/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddField
		/// Description Add field details
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MINM">Program name (Required)</param>
		/// <param name="m3TRNM">Transaction name (Required)</param>
		/// <param name="m3TRTP">Input/Output (Required)</param>
		/// <param name="m3FLNM">Field name (Required)</param>
		/// <param name="m3FRPO">From position (Required)</param>
		/// <param name="m3LENG">Length (Required)</param>
		/// <param name="m3TYPE">Field type A=Alphanumeric, N=Numeric (Required)</param>
		/// <param name="m3FLDS">Description</param>
		/// <param name="m3TXT1">Text ID</param>
		/// <param name="m3TOPO">To position</param>
		/// <param name="m3MAND">Mandatory</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddField(
			string m3MINM, 
			string m3TRNM, 
			string m3TRTP, 
			string m3FLNM, 
			int m3FRPO, 
			int m3LENG, 
			string m3TYPE, 
			string m3FLDS = null, 
			decimal? m3TXT1 = null, 
			int? m3TOPO = null, 
			string m3MAND = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddField",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MINM))
				throw new ArgumentNullException(nameof(m3MINM));
			if (string.IsNullOrWhiteSpace(m3TRNM))
				throw new ArgumentNullException(nameof(m3TRNM));
			if (string.IsNullOrWhiteSpace(m3TRTP))
				throw new ArgumentNullException(nameof(m3TRTP));
			if (string.IsNullOrWhiteSpace(m3FLNM))
				throw new ArgumentNullException(nameof(m3FLNM));
			if (string.IsNullOrWhiteSpace(m3TYPE))
				throw new ArgumentNullException(nameof(m3TYPE));

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3MINM.Trim())
				.WithQueryParameter("TRNM", m3TRNM.Trim())
				.WithQueryParameter("TRTP", m3TRTP.Trim())
				.WithQueryParameter("FLNM", m3FLNM.Trim())
				.WithQueryParameter("FRPO", m3FRPO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("LENG", m3LENG.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TYPE", m3TYPE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FLDS))
				request.WithQueryParameter("FLDS", m3FLDS.Trim());
			if (m3TXT1.HasValue)
				request.WithQueryParameter("TXT1", m3TXT1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOPO.HasValue)
				request.WithQueryParameter("TOPO", m3TOPO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MAND))
				request.WithQueryParameter("MAND", m3MAND.Trim());

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
		/// Name AddProgram
		/// Description Add program details
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MINM">Associated MI-program (Required)</param>
		/// <param name="m3OBNM">Object (Required)</param>
		/// <param name="m3MIDS">Description (Required)</param>
		/// <param name="m3TXT1">Text ID for leading description</param>
		/// <param name="m3TXT2">Text ID for trailing description</param>
		/// <param name="m3RGDT">Not used!</param>
		/// <param name="m3RGTM">Not used!</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="m3MNID">Classification</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddProgram(
			string m3MINM, 
			string m3OBNM, 
			string m3MIDS, 
			decimal? m3TXT1 = null, 
			decimal? m3TXT2 = null, 
			int? m3RGDT = null, 
			int? m3RGTM = null, 
			string m3VERS = null, 
			string m3MNID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddProgram",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MINM))
				throw new ArgumentNullException(nameof(m3MINM));
			if (string.IsNullOrWhiteSpace(m3OBNM))
				throw new ArgumentNullException(nameof(m3OBNM));
			if (string.IsNullOrWhiteSpace(m3MIDS))
				throw new ArgumentNullException(nameof(m3MIDS));

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3MINM.Trim())
				.WithQueryParameter("OBNM", m3OBNM.Trim())
				.WithQueryParameter("MIDS", m3MIDS.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3TXT1.HasValue)
				request.WithQueryParameter("TXT1", m3TXT1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXT2.HasValue)
				request.WithQueryParameter("TXT2", m3TXT2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3RGTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3VERS))
				request.WithQueryParameter("VERS", m3VERS.Trim());
			if (!string.IsNullOrWhiteSpace(m3MNID))
				request.WithQueryParameter("MNID", m3MNID.Trim());

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
		/// Name AddText
		/// Description Add text to components
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MINM">Program name (Required)</param>
		/// <param name="m3TXTP">0 = Pre-text/1 = Post-text</param>
		/// <param name="m3TRNM">Transaction name</param>
		/// <param name="m3TRTP">Input/Output</param>
		/// <param name="m3FLNM">Field name</param>
		/// <param name="m3TX60">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddText(
			string m3MINM, 
			int? m3TXTP = null, 
			string m3TRNM = null, 
			string m3TRTP = null, 
			string m3FLNM = null, 
			string m3TX60 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MINM))
				throw new ArgumentNullException(nameof(m3MINM));

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3MINM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3TXTP.HasValue)
				request.WithQueryParameter("TXTP", m3TXTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TRNM))
				request.WithQueryParameter("TRNM", m3TRNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRTP))
				request.WithQueryParameter("TRTP", m3TRTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLNM))
				request.WithQueryParameter("FLNM", m3FLNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX60))
				request.WithQueryParameter("TX60", m3TX60.Trim());

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
		/// Name AddTransaction
		/// Description Add transaction details
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MINM">Program name (Required)</param>
		/// <param name="m3TRNM">Transaction name (Required)</param>
		/// <param name="m3TRDS">Transaction description (Required)</param>
		/// <param name="m3SIMU">Transaction type, Single/Multiple (Required)</param>
		/// <param name="m3TXT1">Text ID of leading description</param>
		/// <param name="m3TXT2">Text ID of trailing description</param>
		/// <param name="m3VERS">Movex version/release</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3PRFI">Prefix input</param>
		/// <param name="m3PRFO">Prefix output</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddTransaction(
			string m3MINM, 
			string m3TRNM, 
			string m3TRDS, 
			string m3SIMU, 
			decimal? m3TXT1 = null, 
			decimal? m3TXT2 = null, 
			string m3VERS = null, 
			int? m3STAT = null, 
			string m3PRFI = null, 
			string m3PRFO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddTransaction",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MINM))
				throw new ArgumentNullException(nameof(m3MINM));
			if (string.IsNullOrWhiteSpace(m3TRNM))
				throw new ArgumentNullException(nameof(m3TRNM));
			if (string.IsNullOrWhiteSpace(m3TRDS))
				throw new ArgumentNullException(nameof(m3TRDS));
			if (string.IsNullOrWhiteSpace(m3SIMU))
				throw new ArgumentNullException(nameof(m3SIMU));

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3MINM.Trim())
				.WithQueryParameter("TRNM", m3TRNM.Trim())
				.WithQueryParameter("TRDS", m3TRDS.Trim())
				.WithQueryParameter("SIMU", m3SIMU.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3TXT1.HasValue)
				request.WithQueryParameter("TXT1", m3TXT1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXT2.HasValue)
				request.WithQueryParameter("TXT2", m3TXT2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3VERS))
				request.WithQueryParameter("VERS", m3VERS.Trim());
			if (m3STAT.HasValue)
				request.WithQueryParameter("STAT", m3STAT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRFI))
				request.WithQueryParameter("PRFI", m3PRFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRFO))
				request.WithQueryParameter("PRFO", m3PRFO.Trim());

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
		/// Name ClearCache
		/// Description Clear MIWS Cache
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3MINM">MI Program name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ClearCache(
			string m3MINM, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ClearCache",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MINM))
				throw new ArgumentNullException(nameof(m3MINM));

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3MINM.Trim());

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
		/// Name CpyTransaction
		/// Description Copy a transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FRMI">From program (Required)</param>
		/// <param name="m3FRTR">From transaction (Required)</param>
		/// <param name="m3TOMI">To program (Required)</param>
		/// <param name="m3TOTR">To transaction</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyTransaction(
			string m3FRMI, 
			string m3FRTR, 
			string m3TOMI, 
			string m3TOTR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CpyTransaction",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FRMI))
				throw new ArgumentNullException(nameof(m3FRMI));
			if (string.IsNullOrWhiteSpace(m3FRTR))
				throw new ArgumentNullException(nameof(m3FRTR));
			if (string.IsNullOrWhiteSpace(m3TOMI))
				throw new ArgumentNullException(nameof(m3TOMI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FRMI", m3FRMI.Trim())
				.WithQueryParameter("FRTR", m3FRTR.Trim())
				.WithQueryParameter("TOMI", m3TOMI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TOTR))
				request.WithQueryParameter("TOTR", m3TOTR.Trim());

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
		/// Name DelField
		/// Description Delete a field from a program/transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MINM">Program name (Required)</param>
		/// <param name="m3TRNM">Transaction name (Required)</param>
		/// <param name="m3TRTP">Layout type, Input/Output (Required)</param>
		/// <param name="m3FLNM">Field name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelField(
			string m3MINM, 
			string m3TRNM, 
			string m3TRTP, 
			string m3FLNM, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelField",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MINM))
				throw new ArgumentNullException(nameof(m3MINM));
			if (string.IsNullOrWhiteSpace(m3TRNM))
				throw new ArgumentNullException(nameof(m3TRNM));
			if (string.IsNullOrWhiteSpace(m3TRTP))
				throw new ArgumentNullException(nameof(m3TRTP));
			if (string.IsNullOrWhiteSpace(m3FLNM))
				throw new ArgumentNullException(nameof(m3FLNM));

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3MINM.Trim())
				.WithQueryParameter("TRNM", m3TRNM.Trim())
				.WithQueryParameter("TRTP", m3TRTP.Trim())
				.WithQueryParameter("FLNM", m3FLNM.Trim());

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
		/// Name DelProgram
		/// Description Delete complete program
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MINM">Program name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelProgram(
			string m3MINM, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelProgram",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MINM))
				throw new ArgumentNullException(nameof(m3MINM));

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3MINM.Trim());

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
		/// Name DelText
		/// Description Delete text
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MINM">Program name (Required)</param>
		/// <param name="m3TXTP">0 = Pre-text/1 = Post-text</param>
		/// <param name="m3TRNM">Transaction name</param>
		/// <param name="m3TRTP">Input/Output</param>
		/// <param name="m3FLNM">Field name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelText(
			string m3MINM, 
			int? m3TXTP = null, 
			string m3TRNM = null, 
			string m3TRTP = null, 
			string m3FLNM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MINM))
				throw new ArgumentNullException(nameof(m3MINM));

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3MINM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3TXTP.HasValue)
				request.WithQueryParameter("TXTP", m3TXTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TRNM))
				request.WithQueryParameter("TRNM", m3TRNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRTP))
				request.WithQueryParameter("TRTP", m3TRTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLNM))
				request.WithQueryParameter("FLNM", m3FLNM.Trim());

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
		/// Name DelTransaction
		/// Description Delete complete transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MINM">Program name (Required)</param>
		/// <param name="m3TRNM">Transaction name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelTransaction(
			string m3MINM, 
			string m3TRNM, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelTransaction",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MINM))
				throw new ArgumentNullException(nameof(m3MINM));
			if (string.IsNullOrWhiteSpace(m3TRNM))
				throw new ArgumentNullException(nameof(m3TRNM));

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3MINM.Trim())
				.WithQueryParameter("TRNM", m3TRNM.Trim());

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
		/// Name GetField
		/// Description Retrieve detailed information about given field
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MINM">Program name (Required)</param>
		/// <param name="m3TRNM">Transaction name (Required)</param>
		/// <param name="m3TRTP">Layout type, Input/Output (Required)</param>
		/// <param name="m3FLNM">Field name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFieldResponse></returns>
		/// <exception cref="M3Exception<GetFieldResponse>"></exception>
		public async Task<M3Response<GetFieldResponse>> GetField(
			string m3MINM, 
			string m3TRNM, 
			string m3TRTP, 
			string m3FLNM, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetField",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MINM))
				throw new ArgumentNullException(nameof(m3MINM));
			if (string.IsNullOrWhiteSpace(m3TRNM))
				throw new ArgumentNullException(nameof(m3TRNM));
			if (string.IsNullOrWhiteSpace(m3TRTP))
				throw new ArgumentNullException(nameof(m3TRTP));
			if (string.IsNullOrWhiteSpace(m3FLNM))
				throw new ArgumentNullException(nameof(m3FLNM));

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3MINM.Trim())
				.WithQueryParameter("TRNM", m3TRNM.Trim())
				.WithQueryParameter("TRTP", m3TRTP.Trim())
				.WithQueryParameter("FLNM", m3FLNM.Trim());

			// Execute the request
			var result = await Execute<GetFieldResponse>(
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
		/// Name GetFieldInfo
		/// Description Info for a specific table and field
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3FLNA">Field name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFieldInfoResponse></returns>
		/// <exception cref="M3Exception<GetFieldInfoResponse>"></exception>
		public async Task<M3Response<GetFieldInfoResponse>> GetFieldInfo(
			string m3FILE, 
			string m3FLNA, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetFieldInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLNA))
				throw new ArgumentNullException(nameof(m3FLNA));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FLNA", m3FLNA.Trim());

			// Execute the request
			var result = await Execute<GetFieldInfoResponse>(
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
		/// Name GetProgram
		/// Description Get program details
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MINM">Program name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetProgramResponse></returns>
		/// <exception cref="M3Exception<GetProgramResponse>"></exception>
		public async Task<M3Response<GetProgramResponse>> GetProgram(
			string m3MINM, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetProgram",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MINM))
				throw new ArgumentNullException(nameof(m3MINM));

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3MINM.Trim());

			// Execute the request
			var result = await Execute<GetProgramResponse>(
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
		/// Name GetText
		/// Description Not to be used - See LstText
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TXID">Text identity (Required)</param>
		/// <param name="m3TXVR">Text block</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTextResponse></returns>
		/// <exception cref="M3Exception<GetTextResponse>"></exception>
		public async Task<M3Response<GetTextResponse>> GetText(
			decimal m3TXID, 
			string m3TXVR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetText",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("TXID", m3TXID.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TXVR))
				request.WithQueryParameter("TXVR", m3TXVR.Trim());

			// Execute the request
			var result = await Execute<GetTextResponse>(
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
		/// Name GetTransaction
		/// Description Get transaction details
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MINM">Program name (Required)</param>
		/// <param name="m3TRNM">Transaction name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTransactionResponse></returns>
		/// <exception cref="M3Exception<GetTransactionResponse>"></exception>
		public async Task<M3Response<GetTransactionResponse>> GetTransaction(
			string m3MINM, 
			string m3TRNM, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetTransaction",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MINM))
				throw new ArgumentNullException(nameof(m3MINM));
			if (string.IsNullOrWhiteSpace(m3TRNM))
				throw new ArgumentNullException(nameof(m3TRNM));

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3MINM.Trim())
				.WithQueryParameter("TRNM", m3TRNM.Trim());

			// Execute the request
			var result = await Execute<GetTransactionResponse>(
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
		/// Name LstAdtFieldInf
		/// Description List additional field information
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3MINM">Program name (Required)</param>
		/// <param name="m3TRNM">Transaction name (Required)</param>
		/// <param name="m3TRTP">Layout type, Input/Output (Required)</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAdtFieldInfResponse></returns>
		/// <exception cref="M3Exception<LstAdtFieldInfResponse>"></exception>
		public async Task<M3Response<LstAdtFieldInfResponse>> LstAdtFieldInf(
			string m3MINM, 
			string m3TRNM, 
			string m3TRTP, 
			string m3LNCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAdtFieldInf",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MINM))
				throw new ArgumentNullException(nameof(m3MINM));
			if (string.IsNullOrWhiteSpace(m3TRNM))
				throw new ArgumentNullException(nameof(m3TRNM));
			if (string.IsNullOrWhiteSpace(m3TRTP))
				throw new ArgumentNullException(nameof(m3TRTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3MINM.Trim())
				.WithQueryParameter("TRNM", m3TRNM.Trim())
				.WithQueryParameter("TRTP", m3TRTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<LstAdtFieldInfResponse>(
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
		/// Name LstAllTrans
		/// Description List transactions from all programs
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TRNM">Transaction prefix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAllTransResponse></returns>
		/// <exception cref="M3Exception<LstAllTransResponse>"></exception>
		public async Task<M3Response<LstAllTransResponse>> LstAllTrans(
			string m3TRNM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAllTrans",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TRNM))
				request.WithQueryParameter("TRNM", m3TRNM.Trim());

			// Execute the request
			var result = await Execute<LstAllTransResponse>(
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
		/// Name LstClasses
		/// Description List classes
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3MNID">Parent classification</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstClassesResponse></returns>
		/// <exception cref="M3Exception<LstClassesResponse>"></exception>
		public async Task<M3Response<LstClassesResponse>> LstClasses(
			string m3MNID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstClasses",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MNID))
				request.WithQueryParameter("MNID", m3MNID.Trim());

			// Execute the request
			var result = await Execute<LstClassesResponse>(
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstComponents",
			};

			// Execute the request
			var result = await Execute<LstComponentsResponse>(
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
		/// Name LstFieldInfo
		/// Description Retrieve field info for a table
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFieldInfoResponse></returns>
		/// <exception cref="M3Exception<LstFieldInfoResponse>"></exception>
		public async Task<M3Response<LstFieldInfoResponse>> LstFieldInfo(
			string m3FILE, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstFieldInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim());

			// Execute the request
			var result = await Execute<LstFieldInfoResponse>(
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
		/// Name LstFields
		/// Description List all fields for a transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MINM">Program name (Required)</param>
		/// <param name="m3TRNM">Transaction name (Required)</param>
		/// <param name="m3TRTP">Layout type, Input/Output (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFieldsResponse></returns>
		/// <exception cref="M3Exception<LstFieldsResponse>"></exception>
		public async Task<M3Response<LstFieldsResponse>> LstFields(
			string m3MINM, 
			string m3TRNM, 
			string m3TRTP, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstFields",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MINM))
				throw new ArgumentNullException(nameof(m3MINM));
			if (string.IsNullOrWhiteSpace(m3TRNM))
				throw new ArgumentNullException(nameof(m3TRNM));
			if (string.IsNullOrWhiteSpace(m3TRTP))
				throw new ArgumentNullException(nameof(m3TRTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3MINM.Trim())
				.WithQueryParameter("TRNM", m3TRNM.Trim())
				.WithQueryParameter("TRTP", m3TRTP.Trim());

			// Execute the request
			var result = await Execute<LstFieldsResponse>(
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
		/// Name LstFldHeadings
		/// Description List field headings in user or specified language.
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MINM">Program name (Required)</param>
		/// <param name="m3TRNM">Transaction name (Required)</param>
		/// <param name="m3TRTP">Layout type, Input/Output (Required)</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFldHeadingsResponse></returns>
		/// <exception cref="M3Exception<LstFldHeadingsResponse>"></exception>
		public async Task<M3Response<LstFldHeadingsResponse>> LstFldHeadings(
			string m3MINM, 
			string m3TRNM, 
			string m3TRTP, 
			string m3LNCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstFldHeadings",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MINM))
				throw new ArgumentNullException(nameof(m3MINM));
			if (string.IsNullOrWhiteSpace(m3TRNM))
				throw new ArgumentNullException(nameof(m3TRNM));
			if (string.IsNullOrWhiteSpace(m3TRTP))
				throw new ArgumentNullException(nameof(m3TRTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3MINM.Trim())
				.WithQueryParameter("TRNM", m3TRNM.Trim())
				.WithQueryParameter("TRTP", m3TRTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<LstFldHeadingsResponse>(
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
		/// Name LstLFFields
		/// Description List logical file fields
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3INDX">File index number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLFFieldsResponse></returns>
		/// <exception cref="M3Exception<LstLFFieldsResponse>"></exception>
		public async Task<M3Response<LstLFFieldsResponse>> LstLFFields(
			string m3FILE, 
			string m3INDX, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstLFFields",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3INDX))
				throw new ArgumentNullException(nameof(m3INDX));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("INDX", m3INDX.Trim());

			// Execute the request
			var result = await Execute<LstLFFieldsResponse>(
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
		/// Name LstLogicalFiles
		/// Description LstLogicalFiles
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FILE">Physical file name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLogicalFilesResponse></returns>
		/// <exception cref="M3Exception<LstLogicalFilesResponse>"></exception>
		public async Task<M3Response<LstLogicalFilesResponse>> LstLogicalFiles(
			string m3FILE, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstLogicalFiles",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim());

			// Execute the request
			var result = await Execute<LstLogicalFilesResponse>(
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
		/// Name LstProgramClass
		/// Description List MI programs for given a classification
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3MNID">Classification</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstProgramClassResponse></returns>
		/// <exception cref="M3Exception<LstProgramClassResponse>"></exception>
		public async Task<M3Response<LstProgramClassResponse>> LstProgramClass(
			string m3MNID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstProgramClass",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MNID))
				request.WithQueryParameter("MNID", m3MNID.Trim());

			// Execute the request
			var result = await Execute<LstProgramClassResponse>(
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPrograms",
			};

			// Execute the request
			var result = await Execute<LstProgramsResponse>(
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
		/// Name LstText
		/// Description List text connected to program, transaction or field
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TXID">Text identity (Required)</param>
		/// <param name="m3TXVR">Text block</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTextResponse></returns>
		/// <exception cref="M3Exception<LstTextResponse>"></exception>
		public async Task<M3Response<LstTextResponse>> LstText(
			decimal m3TXID, 
			string m3TXVR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstText",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("TXID", m3TXID.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TXVR))
				request.WithQueryParameter("TXVR", m3TXVR.Trim());

			// Execute the request
			var result = await Execute<LstTextResponse>(
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
		/// Name LstTransactions
		/// Description List available transactions for given program
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MINM">Program name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTransactionsResponse></returns>
		/// <exception cref="M3Exception<LstTransactionsResponse>"></exception>
		public async Task<M3Response<LstTransactionsResponse>> LstTransactions(
			string m3MINM, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstTransactions",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MINM))
				throw new ArgumentNullException(nameof(m3MINM));

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3MINM.Trim());

			// Execute the request
			var result = await Execute<LstTransactionsResponse>(
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
		/// Name Recalculate
		/// Description Recalculate transaction layout based on lengths
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3MINM">MI Program name (Required)</param>
		/// <param name="m3TRNM">Transaction (Required)</param>
		/// <param name="m3TRTP">Transaction type I/O (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Recalculate(
			string m3MINM, 
			string m3TRNM, 
			string m3TRTP, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Recalculate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MINM))
				throw new ArgumentNullException(nameof(m3MINM));
			if (string.IsNullOrWhiteSpace(m3TRNM))
				throw new ArgumentNullException(nameof(m3TRNM));
			if (string.IsNullOrWhiteSpace(m3TRTP))
				throw new ArgumentNullException(nameof(m3TRTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3MINM.Trim())
				.WithQueryParameter("TRNM", m3TRNM.Trim())
				.WithQueryParameter("TRTP", m3TRTP.Trim());

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
		/// Name UpdField
		/// Description Update field information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MINM">Program name (Required)</param>
		/// <param name="m3TRNM">Transaction name (Required)</param>
		/// <param name="m3TRTP">Input/Output (Required)</param>
		/// <param name="m3FLNM">Field name (Required)</param>
		/// <param name="m3FLDS">Description</param>
		/// <param name="m3TXT1">Text ID</param>
		/// <param name="m3FRPO">From position</param>
		/// <param name="m3TOPO">To position</param>
		/// <param name="m3LENG">Length</param>
		/// <param name="m3TYPE">Field type A=Alphanumeric, N=Numeric</param>
		/// <param name="m3MAND">Mandatory</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdField(
			string m3MINM, 
			string m3TRNM, 
			string m3TRTP, 
			string m3FLNM, 
			string m3FLDS = null, 
			decimal? m3TXT1 = null, 
			int? m3FRPO = null, 
			int? m3TOPO = null, 
			int? m3LENG = null, 
			string m3TYPE = null, 
			string m3MAND = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdField",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MINM))
				throw new ArgumentNullException(nameof(m3MINM));
			if (string.IsNullOrWhiteSpace(m3TRNM))
				throw new ArgumentNullException(nameof(m3TRNM));
			if (string.IsNullOrWhiteSpace(m3TRTP))
				throw new ArgumentNullException(nameof(m3TRTP));
			if (string.IsNullOrWhiteSpace(m3FLNM))
				throw new ArgumentNullException(nameof(m3FLNM));

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3MINM.Trim())
				.WithQueryParameter("TRNM", m3TRNM.Trim())
				.WithQueryParameter("TRTP", m3TRTP.Trim())
				.WithQueryParameter("FLNM", m3FLNM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FLDS))
				request.WithQueryParameter("FLDS", m3FLDS.Trim());
			if (m3TXT1.HasValue)
				request.WithQueryParameter("TXT1", m3TXT1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRPO.HasValue)
				request.WithQueryParameter("FRPO", m3FRPO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOPO.HasValue)
				request.WithQueryParameter("TOPO", m3TOPO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LENG.HasValue)
				request.WithQueryParameter("LENG", m3LENG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TYPE))
				request.WithQueryParameter("TYPE", m3TYPE.Trim());
			if (!string.IsNullOrWhiteSpace(m3MAND))
				request.WithQueryParameter("MAND", m3MAND.Trim());

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
		/// Name UpdProgram
		/// Description Change values on a program
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MINM">Associated MI-program (Required)</param>
		/// <param name="m3OBNM">Object</param>
		/// <param name="m3MIDS">Description</param>
		/// <param name="m3TXT1">Text ID for leading description</param>
		/// <param name="m3TXT2">Text ID for trailing description</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="m3MNID">Classification</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdProgram(
			string m3MINM, 
			string m3OBNM = null, 
			string m3MIDS = null, 
			decimal? m3TXT1 = null, 
			decimal? m3TXT2 = null, 
			string m3VERS = null, 
			string m3MNID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdProgram",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MINM))
				throw new ArgumentNullException(nameof(m3MINM));

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3MINM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBNM))
				request.WithQueryParameter("OBNM", m3OBNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3MIDS))
				request.WithQueryParameter("MIDS", m3MIDS.Trim());
			if (m3TXT1.HasValue)
				request.WithQueryParameter("TXT1", m3TXT1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXT2.HasValue)
				request.WithQueryParameter("TXT2", m3TXT2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3VERS))
				request.WithQueryParameter("VERS", m3VERS.Trim());
			if (!string.IsNullOrWhiteSpace(m3MNID))
				request.WithQueryParameter("MNID", m3MNID.Trim());

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
		/// Name UpdTransaction
		/// Description Change values in a transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MINM">Program name (Required)</param>
		/// <param name="m3TRNM">Transaction name (Required)</param>
		/// <param name="m3TRDS">Transaction description</param>
		/// <param name="m3TXT1">Text ID of leading description</param>
		/// <param name="m3TXT2">Text ID of trailing description</param>
		/// <param name="m3VERS">Movex version/release</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3PRFI">Prefix input</param>
		/// <param name="m3PRFO">Prefix output</param>
		/// <param name="m3SIMU">Transaction type, Single/Multiple</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdTransaction(
			string m3MINM, 
			string m3TRNM, 
			string m3TRDS = null, 
			decimal? m3TXT1 = null, 
			decimal? m3TXT2 = null, 
			string m3VERS = null, 
			int? m3STAT = null, 
			string m3PRFI = null, 
			string m3PRFO = null, 
			string m3SIMU = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdTransaction",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MINM))
				throw new ArgumentNullException(nameof(m3MINM));
			if (string.IsNullOrWhiteSpace(m3TRNM))
				throw new ArgumentNullException(nameof(m3TRNM));

			// Set mandatory parameters
			request
				.WithQueryParameter("MINM", m3MINM.Trim())
				.WithQueryParameter("TRNM", m3TRNM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TRDS))
				request.WithQueryParameter("TRDS", m3TRDS.Trim());
			if (m3TXT1.HasValue)
				request.WithQueryParameter("TXT1", m3TXT1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXT2.HasValue)
				request.WithQueryParameter("TXT2", m3TXT2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3VERS))
				request.WithQueryParameter("VERS", m3VERS.Trim());
			if (m3STAT.HasValue)
				request.WithQueryParameter("STAT", m3STAT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRFI))
				request.WithQueryParameter("PRFI", m3PRFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRFO))
				request.WithQueryParameter("PRFO", m3PRFO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SIMU))
				request.WithQueryParameter("SIMU", m3SIMU.Trim());

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
