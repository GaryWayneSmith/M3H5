/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PCS115MI;
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
	/// Name: PCS115MI
	/// Component Name: MaterialSubcontractOverhead
	/// Description: Material and subcontract overhead interface
	/// Version Release: 11.0
	///</summary>
	public partial class PCS115MIResource : M3BaseResourceEndpoint
	{
		public PCS115MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PCS115MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 11.0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CCOM">Costing component (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_OBV2">Start value 2 (Required)</param>
		/// <param name="m3_OBV3">Start value 3 (Required)</param>
		/// <param name="m3_PCTP">Costing type (Required)</param>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MOPE">Material overhead</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_FACI, 
			string m3_CCOM, 
			string m3_OBV1, 
			string m3_OBV2, 
			string m3_OBV3, 
			string m3_PCTP, 
			DateTime m3_FRDT, 
			int? m3_CONO = null, 
			string m3_MOPE = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_CCOM))
				throw new ArgumentNullException("m3_CCOM");
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");
			if (string.IsNullOrWhiteSpace(m3_OBV2))
				throw new ArgumentNullException("m3_OBV2");
			if (string.IsNullOrWhiteSpace(m3_OBV3))
				throw new ArgumentNullException("m3_OBV3");
			if (string.IsNullOrWhiteSpace(m3_PCTP))
				throw new ArgumentNullException("m3_PCTP");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("CCOM", m3_CCOM.Trim())
				.WithQueryParameter("OBV1", m3_OBV1.Trim())
				.WithQueryParameter("OBV2", m3_OBV2.Trim())
				.WithQueryParameter("OBV3", m3_OBV3.Trim())
				.WithQueryParameter("PCTP", m3_PCTP.Trim())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MOPE))
				request.WithQueryParameter("MOPE", m3_MOPE.Trim());

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
		/// Version Release: 11.0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CCOM">Costing component (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_OBV2">Start value 2 (Required)</param>
		/// <param name="m3_OBV3">Start value 3 (Required)</param>
		/// <param name="m3_PCTP">Costing type (Required)</param>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_CFAC">Facility (Required)</param>
		/// <param name="m3_CCCM">Costing component (Required)</param>
		/// <param name="m3_COB1">Start value 1 (Required)</param>
		/// <param name="m3_COB2">Start value 2 (Required)</param>
		/// <param name="m3_COB3">Start value 3 (Required)</param>
		/// <param name="m3_CPCT">Costing type (Required)</param>
		/// <param name="m3_CFRD">From date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MOPE">Material overhead</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Copy(
			string m3_FACI, 
			string m3_CCOM, 
			string m3_OBV1, 
			string m3_OBV2, 
			string m3_OBV3, 
			string m3_PCTP, 
			DateTime m3_FRDT, 
			string m3_CFAC, 
			string m3_CCCM, 
			string m3_COB1, 
			string m3_COB2, 
			string m3_COB3, 
			string m3_CPCT, 
			int m3_CFRD, 
			int? m3_CONO = null, 
			string m3_MOPE = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_CCOM))
				throw new ArgumentNullException("m3_CCOM");
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");
			if (string.IsNullOrWhiteSpace(m3_OBV2))
				throw new ArgumentNullException("m3_OBV2");
			if (string.IsNullOrWhiteSpace(m3_OBV3))
				throw new ArgumentNullException("m3_OBV3");
			if (string.IsNullOrWhiteSpace(m3_PCTP))
				throw new ArgumentNullException("m3_PCTP");
			if (string.IsNullOrWhiteSpace(m3_CFAC))
				throw new ArgumentNullException("m3_CFAC");
			if (string.IsNullOrWhiteSpace(m3_CCCM))
				throw new ArgumentNullException("m3_CCCM");
			if (string.IsNullOrWhiteSpace(m3_COB1))
				throw new ArgumentNullException("m3_COB1");
			if (string.IsNullOrWhiteSpace(m3_COB2))
				throw new ArgumentNullException("m3_COB2");
			if (string.IsNullOrWhiteSpace(m3_COB3))
				throw new ArgumentNullException("m3_COB3");
			if (string.IsNullOrWhiteSpace(m3_CPCT))
				throw new ArgumentNullException("m3_CPCT");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("CCOM", m3_CCOM.Trim())
				.WithQueryParameter("OBV1", m3_OBV1.Trim())
				.WithQueryParameter("OBV2", m3_OBV2.Trim())
				.WithQueryParameter("OBV3", m3_OBV3.Trim())
				.WithQueryParameter("PCTP", m3_PCTP.Trim())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String())
				.WithQueryParameter("CFAC", m3_CFAC.Trim())
				.WithQueryParameter("CCCM", m3_CCCM.Trim())
				.WithQueryParameter("COB1", m3_COB1.Trim())
				.WithQueryParameter("COB2", m3_COB2.Trim())
				.WithQueryParameter("COB3", m3_COB3.Trim())
				.WithQueryParameter("CPCT", m3_CPCT.Trim())
				.WithQueryParameter("CFRD", m3_CFRD.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MOPE))
				request.WithQueryParameter("MOPE", m3_MOPE.Trim());

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
		/// Version Release: 11.0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CCOM">Costing component (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_OBV2">Start value 2 (Required)</param>
		/// <param name="m3_OBV3">Start value 3 (Required)</param>
		/// <param name="m3_PCTP">Costing type (Required)</param>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3_FACI, 
			string m3_CCOM, 
			string m3_OBV1, 
			string m3_OBV2, 
			string m3_OBV3, 
			string m3_PCTP, 
			DateTime m3_FRDT, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_CCOM))
				throw new ArgumentNullException("m3_CCOM");
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");
			if (string.IsNullOrWhiteSpace(m3_OBV2))
				throw new ArgumentNullException("m3_OBV2");
			if (string.IsNullOrWhiteSpace(m3_OBV3))
				throw new ArgumentNullException("m3_OBV3");
			if (string.IsNullOrWhiteSpace(m3_PCTP))
				throw new ArgumentNullException("m3_PCTP");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("CCOM", m3_CCOM.Trim())
				.WithQueryParameter("OBV1", m3_OBV1.Trim())
				.WithQueryParameter("OBV2", m3_OBV2.Trim())
				.WithQueryParameter("OBV3", m3_OBV3.Trim())
				.WithQueryParameter("PCTP", m3_PCTP.Trim())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String());

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
		/// Version Release: 11.0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CCOM">Costing component (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_OBV2">Start value 2 (Required)</param>
		/// <param name="m3_OBV3">Start value 3 (Required)</param>
		/// <param name="m3_PCTP">Costing type (Required)</param>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3_FACI, 
			string m3_CCOM, 
			string m3_OBV1, 
			string m3_OBV2, 
			string m3_OBV3, 
			string m3_PCTP, 
			DateTime m3_FRDT, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_CCOM))
				throw new ArgumentNullException("m3_CCOM");
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");
			if (string.IsNullOrWhiteSpace(m3_OBV2))
				throw new ArgumentNullException("m3_OBV2");
			if (string.IsNullOrWhiteSpace(m3_OBV3))
				throw new ArgumentNullException("m3_OBV3");
			if (string.IsNullOrWhiteSpace(m3_PCTP))
				throw new ArgumentNullException("m3_PCTP");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("CCOM", m3_CCOM.Trim())
				.WithQueryParameter("OBV1", m3_OBV1.Trim())
				.WithQueryParameter("OBV2", m3_OBV2.Trim())
				.WithQueryParameter("OBV3", m3_OBV3.Trim())
				.WithQueryParameter("PCTP", m3_PCTP.Trim())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String());

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
		/// Version Release: 11.0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CCOM">Costing component (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_OBV2">Start value 2 (Required)</param>
		/// <param name="m3_OBV3">Start value 3 (Required)</param>
		/// <param name="m3_PCTP">Costing type (Required)</param>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<RetrieveResponse></returns>
		/// <exception cref="M3Exception<RetrieveResponse>"></exception>
		public async Task<M3Response<RetrieveResponse>> Retrieve(
			string m3_FACI, 
			string m3_CCOM, 
			string m3_OBV1, 
			string m3_OBV2, 
			string m3_OBV3, 
			string m3_PCTP, 
			DateTime m3_FRDT, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_CCOM))
				throw new ArgumentNullException("m3_CCOM");
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");
			if (string.IsNullOrWhiteSpace(m3_OBV2))
				throw new ArgumentNullException("m3_OBV2");
			if (string.IsNullOrWhiteSpace(m3_OBV3))
				throw new ArgumentNullException("m3_OBV3");
			if (string.IsNullOrWhiteSpace(m3_PCTP))
				throw new ArgumentNullException("m3_PCTP");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("CCOM", m3_CCOM.Trim())
				.WithQueryParameter("OBV1", m3_OBV1.Trim())
				.WithQueryParameter("OBV2", m3_OBV2.Trim())
				.WithQueryParameter("OBV3", m3_OBV3.Trim())
				.WithQueryParameter("PCTP", m3_PCTP.Trim())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String());

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
		/// Version Release: 11.0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CCOM">Costing component (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_OBV2">Start value 2 (Required)</param>
		/// <param name="m3_OBV3">Start value 3 (Required)</param>
		/// <param name="m3_PCTP">Costing type (Required)</param>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MOPE">Material overhead</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Revise(
			string m3_FACI, 
			string m3_CCOM, 
			string m3_OBV1, 
			string m3_OBV2, 
			string m3_OBV3, 
			string m3_PCTP, 
			DateTime m3_FRDT, 
			int? m3_CONO = null, 
			string m3_MOPE = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_CCOM))
				throw new ArgumentNullException("m3_CCOM");
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");
			if (string.IsNullOrWhiteSpace(m3_OBV2))
				throw new ArgumentNullException("m3_OBV2");
			if (string.IsNullOrWhiteSpace(m3_OBV3))
				throw new ArgumentNullException("m3_OBV3");
			if (string.IsNullOrWhiteSpace(m3_PCTP))
				throw new ArgumentNullException("m3_PCTP");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("CCOM", m3_CCOM.Trim())
				.WithQueryParameter("OBV1", m3_OBV1.Trim())
				.WithQueryParameter("OBV2", m3_OBV2.Trim())
				.WithQueryParameter("OBV3", m3_OBV3.Trim())
				.WithQueryParameter("PCTP", m3_PCTP.Trim())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MOPE))
				request.WithQueryParameter("MOPE", m3_MOPE.Trim());

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
