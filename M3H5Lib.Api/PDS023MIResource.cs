/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAltStructure
		/// Description Add alternate structure detail
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_OTNO">Output item (Required)</param>
		/// <param name="m3_STRT">Product structure type (Required)</param>
		/// <param name="m3_MFPC">Process (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_TDAT">To date (Required)</param>
		/// <param name="m3_PFLG">Primary flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAltStructure(
			string m3_FACI, 
			string m3_OTNO, 
			string m3_STRT, 
			string m3_MFPC, 
			DateTime m3_FDAT, 
			DateTime m3_TDAT, 
			int? m3_PFLG = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAltStructure",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_OTNO))
				throw new ArgumentNullException("m3_OTNO");
			if (string.IsNullOrWhiteSpace(m3_STRT))
				throw new ArgumentNullException("m3_STRT");
			if (string.IsNullOrWhiteSpace(m3_MFPC))
				throw new ArgumentNullException("m3_MFPC");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("OTNO", m3_OTNO.Trim())
				.WithQueryParameter("STRT", m3_STRT.Trim())
				.WithQueryParameter("MFPC", m3_MFPC.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String())
				.WithQueryParameter("TDAT", m3_TDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_PFLG.HasValue)
				request.WithQueryParameter("PFLG", m3_PFLG.Value.ToString());

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
		/// Name CpyAltStructure
		/// Description CpyAltStructure
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_OTNO">Output item (Required)</param>
		/// <param name="m3_STRT">Product structure type (Required)</param>
		/// <param name="m3_MFPC">Process (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_TMFP">Process (Required)</param>
		/// <param name="m3_TFDT">From date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyAltStructure(
			string m3_FACI, 
			string m3_OTNO, 
			string m3_STRT, 
			string m3_MFPC, 
			DateTime m3_FDAT, 
			string m3_TMFP, 
			DateTime m3_TFDT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyAltStructure",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_OTNO))
				throw new ArgumentNullException("m3_OTNO");
			if (string.IsNullOrWhiteSpace(m3_STRT))
				throw new ArgumentNullException("m3_STRT");
			if (string.IsNullOrWhiteSpace(m3_MFPC))
				throw new ArgumentNullException("m3_MFPC");
			if (string.IsNullOrWhiteSpace(m3_TMFP))
				throw new ArgumentNullException("m3_TMFP");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("OTNO", m3_OTNO.Trim())
				.WithQueryParameter("STRT", m3_STRT.Trim())
				.WithQueryParameter("MFPC", m3_MFPC.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String())
				.WithQueryParameter("TMFP", m3_TMFP.Trim())
				.WithQueryParameter("TFDT", m3_TFDT.ToM3String());

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
		/// Name DltAltStructure
		/// Description Delete alternate structure detail
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_OTNO">Output item (Required)</param>
		/// <param name="m3_STRT">Product structure type (Required)</param>
		/// <param name="m3_MFPC">Process (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_PFLG">Primary flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAltStructure(
			string m3_FACI, 
			string m3_OTNO, 
			string m3_STRT, 
			string m3_MFPC, 
			DateTime m3_FDAT, 
			DateTime? m3_TDAT = null, 
			int? m3_PFLG = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltAltStructure",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_OTNO))
				throw new ArgumentNullException("m3_OTNO");
			if (string.IsNullOrWhiteSpace(m3_STRT))
				throw new ArgumentNullException("m3_STRT");
			if (string.IsNullOrWhiteSpace(m3_MFPC))
				throw new ArgumentNullException("m3_MFPC");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("OTNO", m3_OTNO.Trim())
				.WithQueryParameter("STRT", m3_STRT.Trim())
				.WithQueryParameter("MFPC", m3_MFPC.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());
			if (m3_PFLG.HasValue)
				request.WithQueryParameter("PFLG", m3_PFLG.Value.ToString());

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
		/// Name GetAltStructure
		/// Description Get alternate structure detail
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_OTNO">Output item (Required)</param>
		/// <param name="m3_STRT">Product structure type (Required)</param>
		/// <param name="m3_MFPC">Process (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAltStructureResponse></returns>
		/// <exception cref="M3Exception<GetAltStructureResponse>"></exception>
		public async Task<M3Response<GetAltStructureResponse>> GetAltStructure(
			string m3_FACI, 
			string m3_OTNO, 
			string m3_STRT, 
			string m3_MFPC, 
			DateTime m3_FDAT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAltStructure",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_OTNO))
				throw new ArgumentNullException("m3_OTNO");
			if (string.IsNullOrWhiteSpace(m3_STRT))
				throw new ArgumentNullException("m3_STRT");
			if (string.IsNullOrWhiteSpace(m3_MFPC))
				throw new ArgumentNullException("m3_MFPC");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("OTNO", m3_OTNO.Trim())
				.WithQueryParameter("STRT", m3_STRT.Trim())
				.WithQueryParameter("MFPC", m3_MFPC.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String());

			// Execute the request
			var result = await Execute<GetAltStructureResponse>(
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
		/// Name LstAltStructure
		/// Description List alternate structure detail
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_OTNO">Output item</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_MFPC">Process</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_PFLG">Primary flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAltStructureResponse></returns>
		/// <exception cref="M3Exception<LstAltStructureResponse>"></exception>
		public async Task<M3Response<LstAltStructureResponse>> LstAltStructure(
			string m3_FACI, 
			string m3_OTNO = null, 
			string m3_STRT = null, 
			string m3_MFPC = null, 
			DateTime? m3_FDAT = null, 
			DateTime? m3_TDAT = null, 
			int? m3_PFLG = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAltStructure",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OTNO))
				request.WithQueryParameter("OTNO", m3_OTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MFPC))
				request.WithQueryParameter("MFPC", m3_MFPC.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());
			if (m3_PFLG.HasValue)
				request.WithQueryParameter("PFLG", m3_PFLG.Value.ToString());

			// Execute the request
			var result = await Execute<LstAltStructureResponse>(
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
		/// Name UpdAltStructure
		/// Description Update alternate structure detail
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_OTNO">Output item (Required)</param>
		/// <param name="m3_STRT">Product structure type (Required)</param>
		/// <param name="m3_MFPC">Process (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_PFLG">Primary flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAltStructure(
			string m3_FACI, 
			string m3_OTNO, 
			string m3_STRT, 
			string m3_MFPC, 
			DateTime m3_FDAT, 
			DateTime? m3_TDAT = null, 
			int? m3_PFLG = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdAltStructure",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_OTNO))
				throw new ArgumentNullException("m3_OTNO");
			if (string.IsNullOrWhiteSpace(m3_STRT))
				throw new ArgumentNullException("m3_STRT");
			if (string.IsNullOrWhiteSpace(m3_MFPC))
				throw new ArgumentNullException("m3_MFPC");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("OTNO", m3_OTNO.Trim())
				.WithQueryParameter("STRT", m3_STRT.Trim())
				.WithQueryParameter("MFPC", m3_MFPC.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());
			if (m3_PFLG.HasValue)
				request.WithQueryParameter("PFLG", m3_PFLG.Value.ToString());

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
