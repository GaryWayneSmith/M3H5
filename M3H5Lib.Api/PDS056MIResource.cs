/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PDS056MI;
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
	/// Name: PDS056MI
	/// Component Name: ProductFeatureConnectOptions
	/// Description: Product features. Connect options interface
	/// Version Release: 5ea0
	///</summary>
	public partial class PDS056MIResource : M3BaseResourceEndpoint
	{
		public PDS056MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PDS056MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FTID">Feature (Required)</param>
		/// <param name="m3_SQNU">Sequence number for sorting (Required)</param>
		/// <param name="m3_OPTN">Option (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRII">Print option information</param>
		/// <param name="m3_PRFI">Print feature information</param>
		/// <param name="m3_PSPR">Print separator prefix</param>
		/// <param name="m3_PSES">Print separator suffix</param>
		/// <param name="m3_PSEP">Print separator</param>
		/// <param name="m3_PRNL">Print on new line</param>
		/// <param name="m3_RGBR">RGB-code red</param>
		/// <param name="m3_RGBG">RGB-code green</param>
		/// <param name="m3_RGBB">RGB-code blue</param>
		/// <param name="m3_MTCT">Material category</param>
		/// <param name="m3_PINO">GUI picture</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_FTID, 
			int m3_SQNU, 
			string m3_OPTN, 
			int? m3_CONO = null, 
			int? m3_PRII = null, 
			int? m3_PRFI = null, 
			string m3_PSPR = null, 
			string m3_PSES = null, 
			string m3_PSEP = null, 
			int? m3_PRNL = null, 
			int? m3_RGBR = null, 
			int? m3_RGBG = null, 
			int? m3_RGBB = null, 
			string m3_MTCT = null, 
			string m3_PINO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FTID))
				throw new ArgumentNullException("m3_FTID");
			if (string.IsNullOrWhiteSpace(m3_OPTN))
				throw new ArgumentNullException("m3_OPTN");

			// Set mandatory parameters
			request
				.WithQueryParameter("FTID", m3_FTID.Trim())
				.WithQueryParameter("SQNU", m3_SQNU.ToString())
				.WithQueryParameter("OPTN", m3_OPTN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PRII.HasValue)
				request.WithQueryParameter("PRII", m3_PRII.Value.ToString());
			if (m3_PRFI.HasValue)
				request.WithQueryParameter("PRFI", m3_PRFI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PSPR))
				request.WithQueryParameter("PSPR", m3_PSPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PSES))
				request.WithQueryParameter("PSES", m3_PSES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PSEP))
				request.WithQueryParameter("PSEP", m3_PSEP.Trim());
			if (m3_PRNL.HasValue)
				request.WithQueryParameter("PRNL", m3_PRNL.Value.ToString());
			if (m3_RGBR.HasValue)
				request.WithQueryParameter("RGBR", m3_RGBR.Value.ToString());
			if (m3_RGBG.HasValue)
				request.WithQueryParameter("RGBG", m3_RGBG.Value.ToString());
			if (m3_RGBB.HasValue)
				request.WithQueryParameter("RGBB", m3_RGBB.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MTCT))
				request.WithQueryParameter("MTCT", m3_MTCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PINO))
				request.WithQueryParameter("PINO", m3_PINO.Trim());

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
		/// Name Copy
		/// Description Copy
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FTID">Feature (Required)</param>
		/// <param name="m3_SQNU">Sequence number for sorting (Required)</param>
		/// <param name="m3_OPTN">Option (Required)</param>
		/// <param name="m3_CFTI">Feature (Required)</param>
		/// <param name="m3_CSQN">Sequence number for sorting (Required)</param>
		/// <param name="m3_COPT">Option (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRII">Print option information</param>
		/// <param name="m3_PRFI">Print feature information</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Copy(
			string m3_FTID, 
			int m3_SQNU, 
			string m3_OPTN, 
			string m3_CFTI, 
			int m3_CSQN, 
			string m3_COPT, 
			int? m3_CONO = null, 
			int? m3_PRII = null, 
			int? m3_PRFI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Copy",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FTID))
				throw new ArgumentNullException("m3_FTID");
			if (string.IsNullOrWhiteSpace(m3_OPTN))
				throw new ArgumentNullException("m3_OPTN");
			if (string.IsNullOrWhiteSpace(m3_CFTI))
				throw new ArgumentNullException("m3_CFTI");
			if (string.IsNullOrWhiteSpace(m3_COPT))
				throw new ArgumentNullException("m3_COPT");

			// Set mandatory parameters
			request
				.WithQueryParameter("FTID", m3_FTID.Trim())
				.WithQueryParameter("SQNU", m3_SQNU.ToString())
				.WithQueryParameter("OPTN", m3_OPTN.Trim())
				.WithQueryParameter("CFTI", m3_CFTI.Trim())
				.WithQueryParameter("CSQN", m3_CSQN.ToString())
				.WithQueryParameter("COPT", m3_COPT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PRII.HasValue)
				request.WithQueryParameter("PRII", m3_PRII.Value.ToString());
			if (m3_PRFI.HasValue)
				request.WithQueryParameter("PRFI", m3_PRFI.Value.ToString());

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
		/// Name Delete
		/// Description Delete
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FTID">Feature (Required)</param>
		/// <param name="m3_SQNU">Sequence number for sorting (Required)</param>
		/// <param name="m3_OPTN">Option (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3_FTID, 
			int m3_SQNU, 
			string m3_OPTN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Delete",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FTID))
				throw new ArgumentNullException("m3_FTID");
			if (string.IsNullOrWhiteSpace(m3_OPTN))
				throw new ArgumentNullException("m3_OPTN");

			// Set mandatory parameters
			request
				.WithQueryParameter("FTID", m3_FTID.Trim())
				.WithQueryParameter("SQNU", m3_SQNU.ToString())
				.WithQueryParameter("OPTN", m3_OPTN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name List
		/// Description List
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FTID">Feature (Required)</param>
		/// <param name="m3_SQNU">Sequence number for sorting (Required)</param>
		/// <param name="m3_OPTN">Option (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3_FTID, 
			int m3_SQNU, 
			string m3_OPTN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/List",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FTID))
				throw new ArgumentNullException("m3_FTID");
			if (string.IsNullOrWhiteSpace(m3_OPTN))
				throw new ArgumentNullException("m3_OPTN");

			// Set mandatory parameters
			request
				.WithQueryParameter("FTID", m3_FTID.Trim())
				.WithQueryParameter("SQNU", m3_SQNU.ToString())
				.WithQueryParameter("OPTN", m3_OPTN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<ListResponse>(
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
		/// Name Retrieve
		/// Description Retrieve
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FTID">Feature (Required)</param>
		/// <param name="m3_SQNU">Sequence number for sorting (Required)</param>
		/// <param name="m3_OPTN">Option (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<RetrieveResponse></returns>
		/// <exception cref="M3Exception<RetrieveResponse>"></exception>
		public async Task<M3Response<RetrieveResponse>> Retrieve(
			string m3_FTID, 
			int m3_SQNU, 
			string m3_OPTN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Retrieve",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FTID))
				throw new ArgumentNullException("m3_FTID");
			if (string.IsNullOrWhiteSpace(m3_OPTN))
				throw new ArgumentNullException("m3_OPTN");

			// Set mandatory parameters
			request
				.WithQueryParameter("FTID", m3_FTID.Trim())
				.WithQueryParameter("SQNU", m3_SQNU.ToString())
				.WithQueryParameter("OPTN", m3_OPTN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<RetrieveResponse>(
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
		/// Name Revise
		/// Description Revise
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FTID">Feature (Required)</param>
		/// <param name="m3_SQNU">Sequence number for sorting (Required)</param>
		/// <param name="m3_OPTN">Option (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRII">Print option information</param>
		/// <param name="m3_PRFI">Print feature information</param>
		/// <param name="m3_PSPR">Print separator prefix</param>
		/// <param name="m3_PSES">Print separator suffix</param>
		/// <param name="m3_PSEP">Print separator</param>
		/// <param name="m3_PRNL">Print on new line</param>
		/// <param name="m3_RGBR">RGB-code red</param>
		/// <param name="m3_RGBG">RGB-code green</param>
		/// <param name="m3_RGBB">RGB-code blue</param>
		/// <param name="m3_MTCT">Material category</param>
		/// <param name="m3_PINO">GUI picture</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Revise(
			string m3_FTID, 
			int m3_SQNU, 
			string m3_OPTN, 
			int? m3_CONO = null, 
			int? m3_PRII = null, 
			int? m3_PRFI = null, 
			string m3_PSPR = null, 
			string m3_PSES = null, 
			string m3_PSEP = null, 
			int? m3_PRNL = null, 
			int? m3_RGBR = null, 
			int? m3_RGBG = null, 
			int? m3_RGBB = null, 
			string m3_MTCT = null, 
			string m3_PINO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Revise",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FTID))
				throw new ArgumentNullException("m3_FTID");
			if (string.IsNullOrWhiteSpace(m3_OPTN))
				throw new ArgumentNullException("m3_OPTN");

			// Set mandatory parameters
			request
				.WithQueryParameter("FTID", m3_FTID.Trim())
				.WithQueryParameter("SQNU", m3_SQNU.ToString())
				.WithQueryParameter("OPTN", m3_OPTN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PRII.HasValue)
				request.WithQueryParameter("PRII", m3_PRII.Value.ToString());
			if (m3_PRFI.HasValue)
				request.WithQueryParameter("PRFI", m3_PRFI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PSPR))
				request.WithQueryParameter("PSPR", m3_PSPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PSES))
				request.WithQueryParameter("PSES", m3_PSES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PSEP))
				request.WithQueryParameter("PSEP", m3_PSEP.Trim());
			if (m3_PRNL.HasValue)
				request.WithQueryParameter("PRNL", m3_PRNL.Value.ToString());
			if (m3_RGBR.HasValue)
				request.WithQueryParameter("RGBR", m3_RGBR.Value.ToString());
			if (m3_RGBG.HasValue)
				request.WithQueryParameter("RGBG", m3_RGBG.Value.ToString());
			if (m3_RGBB.HasValue)
				request.WithQueryParameter("RGBB", m3_RGBB.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MTCT))
				request.WithQueryParameter("MTCT", m3_MTCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PINO))
				request.WithQueryParameter("PINO", m3_PINO.Trim());

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
