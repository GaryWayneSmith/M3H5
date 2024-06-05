/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.ECS420MI;
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
	/// Name: ECS420MI
	/// Component Name: Engineering change order head
	/// Description: Engineering change order head
	/// Version Release: 14.x
	///</summary>
	public partial class ECS420MIResource : M3BaseResourceEndpoint
	{
		public ECS420MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "ECS420MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Activate
		/// Description Activate
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ECON">ECO number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Activate(
			long m3_ECON, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Activate",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("ECON", m3_ECON.ToString());

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
		/// Name Add
		/// Description Add
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ECAC">ECO type (Required)</param>
		/// <param name="m3_ECT1">Change text 1 (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TX01">Description</param>
		/// <param name="m3_ECON">ECO number</param>
		/// <param name="m3_ISBY">Issuer</param>
		/// <param name="m3_DATE">Entry date</param>
		/// <param name="m3_ECEX">Change type</param>
		/// <param name="m3_PRIO">Priority</param>
		/// <param name="m3_ECT2">Change text 2</param>
		/// <param name="m3_TX03">Description</param>
		/// <param name="m3_ECST">Status</param>
		/// <param name="m3_ECVA">Financial evaluation</param>
		/// <param name="m3_COAN">Consequense analysis</param>
		/// <param name="m3_WIOR">Withdrawal order</param>
		/// <param name="m3_CUAP">Customer approval</param>
		/// <param name="m3_AIDT">Implement date</param>
		/// <param name="m3_FSQT">From on-hand balance</param>
		/// <param name="m3_FSNO">From serial number</param>
		/// <param name="m3_TX02">Description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddResponse></returns>
		/// <exception cref="M3Exception<AddResponse>"></exception>
		public async Task<M3Response<AddResponse>> Add(
			string m3_ECAC, 
			string m3_ECT1, 
			DateTime m3_FDAT, 
			int? m3_CONO = null, 
			string m3_TX01 = null, 
			string m3_ECON = null, 
			string m3_ISBY = null, 
			DateTime? m3_DATE = null, 
			string m3_ECEX = null, 
			int? m3_PRIO = null, 
			string m3_ECT2 = null, 
			string m3_TX03 = null, 
			string m3_ECST = null, 
			int? m3_ECVA = null, 
			int? m3_COAN = null, 
			int? m3_WIOR = null, 
			int? m3_CUAP = null, 
			DateTime? m3_AIDT = null, 
			string m3_FSQT = null, 
			string m3_FSNO = null, 
			string m3_TX02 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ECAC))
				throw new ArgumentNullException("m3_ECAC");
			if (string.IsNullOrWhiteSpace(m3_ECT1))
				throw new ArgumentNullException("m3_ECT1");

			// Set mandatory parameters
			request
				.WithQueryParameter("ECAC", m3_ECAC.Trim())
				.WithQueryParameter("ECT1", m3_ECT1.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX01))
				request.WithQueryParameter("TX01", m3_TX01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECON))
				request.WithQueryParameter("ECON", m3_ECON.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ISBY))
				request.WithQueryParameter("ISBY", m3_ISBY.Trim());
			if (m3_DATE.HasValue)
				request.WithQueryParameter("DATE", m3_DATE.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ECEX))
				request.WithQueryParameter("ECEX", m3_ECEX.Trim());
			if (m3_PRIO.HasValue)
				request.WithQueryParameter("PRIO", m3_PRIO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECT2))
				request.WithQueryParameter("ECT2", m3_ECT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX03))
				request.WithQueryParameter("TX03", m3_TX03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECST))
				request.WithQueryParameter("ECST", m3_ECST.Trim());
			if (m3_ECVA.HasValue)
				request.WithQueryParameter("ECVA", m3_ECVA.Value.ToString());
			if (m3_COAN.HasValue)
				request.WithQueryParameter("COAN", m3_COAN.Value.ToString());
			if (m3_WIOR.HasValue)
				request.WithQueryParameter("WIOR", m3_WIOR.Value.ToString());
			if (m3_CUAP.HasValue)
				request.WithQueryParameter("CUAP", m3_CUAP.Value.ToString());
			if (m3_AIDT.HasValue)
				request.WithQueryParameter("AIDT", m3_AIDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_FSQT))
				request.WithQueryParameter("FSQT", m3_FSQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FSNO))
				request.WithQueryParameter("FSNO", m3_FSNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX02))
				request.WithQueryParameter("TX02", m3_TX02.Trim());

			// Execute the request
			var result = await Execute<AddResponse>(
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
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ECON">From ECO number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CCON">To ECO number</param>
		/// <param name="m3_CINE">Copy order line</param>
		/// <param name="m3_CXTL">Copy text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Copy(
			string m3_ECON, 
			int? m3_CONO = null, 
			string m3_CCON = null, 
			int? m3_CINE = null, 
			int? m3_CXTL = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ECON))
				throw new ArgumentNullException("m3_ECON");

			// Set mandatory parameters
			request
				.WithQueryParameter("ECON", m3_ECON.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CCON))
				request.WithQueryParameter("CCON", m3_CCON.Trim());
			if (m3_CINE.HasValue)
				request.WithQueryParameter("CINE", m3_CINE.Value.ToString());
			if (m3_CXTL.HasValue)
				request.WithQueryParameter("CXTL", m3_CXTL.Value.ToString());

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
		/// Name Deactivate
		/// Description Deactivate
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ECON">ECO number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Deactivate(
			long m3_ECON, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Deactivate",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("ECON", m3_ECON.ToString());

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
		/// Name Delete
		/// Description Delete
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ECON">ECO number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			long m3_ECON, 
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

			// Set mandatory parameters
			request
				.WithQueryParameter("ECON", m3_ECON.ToString());

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
		/// Name Get
		/// Description Get
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ECON">ECO number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			long m3_ECON, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("ECON", m3_ECON.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name List
		/// Description List
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ECST">Status</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			int? m3_CONO = null, 
			string m3_ECST = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/List",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECST))
				request.WithQueryParameter("ECST", m3_ECST.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());

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
		/// Name Update
		/// Description Update
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ECON">ECO number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ECAC">ECO type</param>
		/// <param name="m3_ECT1">Change text 1</param>
		/// <param name="m3_TX01">Description</param>
		/// <param name="m3_ECT2">Change text 2</param>
		/// <param name="m3_ISBY">Issuer</param>
		/// <param name="m3_DATE">Entry date</param>
		/// <param name="m3_ECST">Status</param>
		/// <param name="m3_TX03">Description</param>
		/// <param name="m3_ECEX">Change type</param>
		/// <param name="m3_PRIO">Priority</param>
		/// <param name="m3_ECVA">Financial evaluation</param>
		/// <param name="m3_COAN">Consequense analysis</param>
		/// <param name="m3_WIOR">Withdrawal order</param>
		/// <param name="m3_CUAP">Customer approval</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_AIDT">Implement date</param>
		/// <param name="m3_FSQT">From on-hand balance</param>
		/// <param name="m3_FSNO">From serial number</param>
		/// <param name="m3_TX02">Description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Update(
			string m3_ECON, 
			int? m3_CONO = null, 
			string m3_ECAC = null, 
			string m3_ECT1 = null, 
			string m3_TX01 = null, 
			string m3_ECT2 = null, 
			string m3_ISBY = null, 
			DateTime? m3_DATE = null, 
			string m3_ECST = null, 
			string m3_TX03 = null, 
			string m3_ECEX = null, 
			int? m3_PRIO = null, 
			int? m3_ECVA = null, 
			int? m3_COAN = null, 
			int? m3_WIOR = null, 
			int? m3_CUAP = null, 
			DateTime? m3_FDAT = null, 
			DateTime? m3_AIDT = null, 
			string m3_FSQT = null, 
			string m3_FSNO = null, 
			string m3_TX02 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Update",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ECON))
				throw new ArgumentNullException("m3_ECON");

			// Set mandatory parameters
			request
				.WithQueryParameter("ECON", m3_ECON.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECAC))
				request.WithQueryParameter("ECAC", m3_ECAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECT1))
				request.WithQueryParameter("ECT1", m3_ECT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX01))
				request.WithQueryParameter("TX01", m3_TX01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECT2))
				request.WithQueryParameter("ECT2", m3_ECT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ISBY))
				request.WithQueryParameter("ISBY", m3_ISBY.Trim());
			if (m3_DATE.HasValue)
				request.WithQueryParameter("DATE", m3_DATE.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ECST))
				request.WithQueryParameter("ECST", m3_ECST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX03))
				request.WithQueryParameter("TX03", m3_TX03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECEX))
				request.WithQueryParameter("ECEX", m3_ECEX.Trim());
			if (m3_PRIO.HasValue)
				request.WithQueryParameter("PRIO", m3_PRIO.Value.ToString());
			if (m3_ECVA.HasValue)
				request.WithQueryParameter("ECVA", m3_ECVA.Value.ToString());
			if (m3_COAN.HasValue)
				request.WithQueryParameter("COAN", m3_COAN.Value.ToString());
			if (m3_WIOR.HasValue)
				request.WithQueryParameter("WIOR", m3_WIOR.Value.ToString());
			if (m3_CUAP.HasValue)
				request.WithQueryParameter("CUAP", m3_CUAP.Value.ToString());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (m3_AIDT.HasValue)
				request.WithQueryParameter("AIDT", m3_AIDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_FSQT))
				request.WithQueryParameter("FSQT", m3_FSQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FSNO))
				request.WithQueryParameter("FSNO", m3_FSNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX02))
				request.WithQueryParameter("TX02", m3_TX02.Trim());

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
