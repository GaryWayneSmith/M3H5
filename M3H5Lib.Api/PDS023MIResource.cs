/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.PDS023MI;
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
	/// Name: PDS023MI
	/// Component Name: Alternate structures
	/// Description: Alternate structures interface
	/// Version Release: 5ea0
	///</summary>
	public partial class PDS023MIResource : M3BaseResourceEndpoint
	{
		public PDS023MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PDS023MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAltStructure
		/// Description Add alternate structure detail
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3OTNO">Output item (Required)</param>
		/// <param name="m3STRT">Product structure type (Required)</param>
		/// <param name="m3MFPC">Process (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3TDAT">To date (Required)</param>
		/// <param name="m3PFLG">Primary flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAltStructure(
			string m3FACI, 
			string m3OTNO, 
			string m3STRT, 
			string m3MFPC, 
			DateTime m3FDAT, 
			DateTime m3TDAT, 
			int? m3PFLG = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddAltStructure",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3OTNO))
				throw new ArgumentNullException(nameof(m3OTNO));
			if (string.IsNullOrWhiteSpace(m3STRT))
				throw new ArgumentNullException(nameof(m3STRT));
			if (string.IsNullOrWhiteSpace(m3MFPC))
				throw new ArgumentNullException(nameof(m3MFPC));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("OTNO", m3OTNO.Trim())
				.WithQueryParameter("STRT", m3STRT.Trim())
				.WithQueryParameter("MFPC", m3MFPC.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String())
				.WithQueryParameter("TDAT", m3TDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3PFLG.HasValue)
				request.WithQueryParameter("PFLG", m3PFLG.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name CpyAltStructure
		/// Description CpyAltStructure
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3OTNO">Output item (Required)</param>
		/// <param name="m3STRT">Product structure type (Required)</param>
		/// <param name="m3MFPC">Process (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3TMFP">Process (Required)</param>
		/// <param name="m3TFDT">From date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyAltStructure(
			string m3FACI, 
			string m3OTNO, 
			string m3STRT, 
			string m3MFPC, 
			DateTime m3FDAT, 
			string m3TMFP, 
			DateTime m3TFDT, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CpyAltStructure",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3OTNO))
				throw new ArgumentNullException(nameof(m3OTNO));
			if (string.IsNullOrWhiteSpace(m3STRT))
				throw new ArgumentNullException(nameof(m3STRT));
			if (string.IsNullOrWhiteSpace(m3MFPC))
				throw new ArgumentNullException(nameof(m3MFPC));
			if (string.IsNullOrWhiteSpace(m3TMFP))
				throw new ArgumentNullException(nameof(m3TMFP));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("OTNO", m3OTNO.Trim())
				.WithQueryParameter("STRT", m3STRT.Trim())
				.WithQueryParameter("MFPC", m3MFPC.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String())
				.WithQueryParameter("TMFP", m3TMFP.Trim())
				.WithQueryParameter("TFDT", m3TFDT.ToM3String());

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
		/// Name DltAltStructure
		/// Description Delete alternate structure detail
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3OTNO">Output item (Required)</param>
		/// <param name="m3STRT">Product structure type (Required)</param>
		/// <param name="m3MFPC">Process (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3PFLG">Primary flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAltStructure(
			string m3FACI, 
			string m3OTNO, 
			string m3STRT, 
			string m3MFPC, 
			DateTime m3FDAT, 
			DateTime? m3TDAT = null, 
			int? m3PFLG = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltAltStructure",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3OTNO))
				throw new ArgumentNullException(nameof(m3OTNO));
			if (string.IsNullOrWhiteSpace(m3STRT))
				throw new ArgumentNullException(nameof(m3STRT));
			if (string.IsNullOrWhiteSpace(m3MFPC))
				throw new ArgumentNullException(nameof(m3MFPC));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("OTNO", m3OTNO.Trim())
				.WithQueryParameter("STRT", m3STRT.Trim())
				.WithQueryParameter("MFPC", m3MFPC.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());
			if (m3PFLG.HasValue)
				request.WithQueryParameter("PFLG", m3PFLG.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetAltStructure
		/// Description Get alternate structure detail
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3OTNO">Output item (Required)</param>
		/// <param name="m3STRT">Product structure type (Required)</param>
		/// <param name="m3MFPC">Process (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAltStructureResponse></returns>
		/// <exception cref="M3Exception<GetAltStructureResponse>"></exception>
		public async Task<M3Response<GetAltStructureResponse>> GetAltStructure(
			string m3FACI, 
			string m3OTNO, 
			string m3STRT, 
			string m3MFPC, 
			DateTime m3FDAT, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetAltStructure",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3OTNO))
				throw new ArgumentNullException(nameof(m3OTNO));
			if (string.IsNullOrWhiteSpace(m3STRT))
				throw new ArgumentNullException(nameof(m3STRT));
			if (string.IsNullOrWhiteSpace(m3MFPC))
				throw new ArgumentNullException(nameof(m3MFPC));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("OTNO", m3OTNO.Trim())
				.WithQueryParameter("STRT", m3STRT.Trim())
				.WithQueryParameter("MFPC", m3MFPC.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String());

			// Execute the request
			var result = await Execute<GetAltStructureResponse>(
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
		/// Name LstAltStructure
		/// Description List alternate structure detail
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3OTNO">Output item</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3MFPC">Process</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3PFLG">Primary flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAltStructureResponse></returns>
		/// <exception cref="M3Exception<LstAltStructureResponse>"></exception>
		public async Task<M3Response<LstAltStructureResponse>> LstAltStructure(
			string m3FACI, 
			string m3OTNO = null, 
			string m3STRT = null, 
			string m3MFPC = null, 
			DateTime? m3FDAT = null, 
			DateTime? m3TDAT = null, 
			int? m3PFLG = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAltStructure",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OTNO))
				request.WithQueryParameter("OTNO", m3OTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3MFPC))
				request.WithQueryParameter("MFPC", m3MFPC.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());
			if (m3PFLG.HasValue)
				request.WithQueryParameter("PFLG", m3PFLG.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAltStructureResponse>(
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
		/// Name UpdAltStructure
		/// Description Update alternate structure detail
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3OTNO">Output item (Required)</param>
		/// <param name="m3STRT">Product structure type (Required)</param>
		/// <param name="m3MFPC">Process (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3PFLG">Primary flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAltStructure(
			string m3FACI, 
			string m3OTNO, 
			string m3STRT, 
			string m3MFPC, 
			DateTime m3FDAT, 
			DateTime? m3TDAT = null, 
			int? m3PFLG = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdAltStructure",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3OTNO))
				throw new ArgumentNullException(nameof(m3OTNO));
			if (string.IsNullOrWhiteSpace(m3STRT))
				throw new ArgumentNullException(nameof(m3STRT));
			if (string.IsNullOrWhiteSpace(m3MFPC))
				throw new ArgumentNullException(nameof(m3MFPC));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("OTNO", m3OTNO.Trim())
				.WithQueryParameter("STRT", m3STRT.Trim())
				.WithQueryParameter("MFPC", m3MFPC.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());
			if (m3PFLG.HasValue)
				request.WithQueryParameter("PFLG", m3PFLG.Value.ToString(CultureInfo.CurrentCulture));

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
