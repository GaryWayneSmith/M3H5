/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.APS430MI;
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
	/// Name: APS430MI
	/// Component Name: SupplierTax
	/// Description: Supplier tax interface
	/// Version Release: 5e90
	///</summary>
	public partial class APS430MIResource : M3BaseResourceEndpoint
	{
		public APS430MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "APS430MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetTaxHead
		/// Description Get Tax Header information
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_JBNO">Job number (Required)</param>
		/// <param name="m3_JBDT">Job date (Required)</param>
		/// <param name="m3_JBTM">Job time (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTaxHeadResponse></returns>
		/// <exception cref="M3Exception<GetTaxHeadResponse>"></exception>
		public async Task<M3Response<GetTaxHeadResponse>> GetTaxHead(
			string m3_DIVI, 
			int m3_JBNO, 
			DateTime m3_JBDT, 
			int m3_JBTM, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetTaxHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("JBNO", m3_JBNO.ToString())
				.WithQueryParameter("JBDT", m3_JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3_JBTM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetTaxHeadResponse>(
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
		/// Name GetTaxTotSer
		/// Description Get tax total per Service code
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_JBNO">Job number</param>
		/// <param name="m3_JBDT">Job date</param>
		/// <param name="m3_JBTM">Job time</param>
		/// <param name="m3_SERS">Service code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTaxTotSerResponse></returns>
		/// <exception cref="M3Exception<GetTaxTotSerResponse>"></exception>
		public async Task<M3Response<GetTaxTotSerResponse>> GetTaxTotSer(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			int? m3_JBNO = null, 
			DateTime? m3_JBDT = null, 
			int? m3_JBTM = null, 
			int? m3_SERS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetTaxTotSer",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_JBNO.HasValue)
				request.WithQueryParameter("JBNO", m3_JBNO.Value.ToString());
			if (m3_JBDT.HasValue)
				request.WithQueryParameter("JBDT", m3_JBDT.Value.ToM3String());
			if (m3_JBTM.HasValue)
				request.WithQueryParameter("JBTM", m3_JBTM.Value.ToString());
			if (m3_SERS.HasValue)
				request.WithQueryParameter("SERS", m3_SERS.Value.ToString());

			// Execute the request
			var result = await Execute<GetTaxTotSerResponse>(
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
		/// Name GetTaxTotStaSer
		/// Description Get tax total per supplier state and service code
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_JBNO">Job number (Required)</param>
		/// <param name="m3_JBDT">Job date (Required)</param>
		/// <param name="m3_JBTM">Job time (Required)</param>
		/// <param name="m3_ECAR">Area/state (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTaxTotStaSerResponse></returns>
		/// <exception cref="M3Exception<GetTaxTotStaSerResponse>"></exception>
		public async Task<M3Response<GetTaxTotStaSerResponse>> GetTaxTotStaSer(
			string m3_DIVI, 
			int m3_JBNO, 
			DateTime m3_JBDT, 
			int m3_JBTM, 
			string m3_ECAR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetTaxTotStaSer",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_ECAR))
				throw new ArgumentNullException("m3_ECAR");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("JBNO", m3_JBNO.ToString())
				.WithQueryParameter("JBDT", m3_JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3_JBTM.ToString())
				.WithQueryParameter("ECAR", m3_ECAR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetTaxTotStaSerResponse>(
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
		/// Name GetTaxTotSupSer
		/// Description Get Tax Total per Supplier and Service code
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_JBNO">Job number (Required)</param>
		/// <param name="m3_JBDT">Job date (Required)</param>
		/// <param name="m3_JBTM">Job time (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SERS">Service code (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTaxTotSupSerResponse></returns>
		/// <exception cref="M3Exception<GetTaxTotSupSerResponse>"></exception>
		public async Task<M3Response<GetTaxTotSupSerResponse>> GetTaxTotSupSer(
			string m3_DIVI, 
			int m3_JBNO, 
			DateTime m3_JBDT, 
			int m3_JBTM, 
			string m3_SUNO, 
			int m3_SERS, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetTaxTotSupSer",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("JBNO", m3_JBNO.ToString())
				.WithQueryParameter("JBDT", m3_JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3_JBTM.ToString())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SERS", m3_SERS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetTaxTotSupSerResponse>(
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
		/// Name LstTaxArLine
		/// Description List Tax Argentina Line Level
		/// Version Release: 
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_JBNO">Job number (Required)</param>
		/// <param name="m3_JBDT">Job date (Required)</param>
		/// <param name="m3_JBTM">Job time (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_RESE">Related service code</param>
		/// <param name="m3_SINO">Supplier invoice number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTaxArLineResponse></returns>
		/// <exception cref="M3Exception<LstTaxArLineResponse>"></exception>
		public async Task<M3Response<LstTaxArLineResponse>> LstTaxArLine(
			string m3_DIVI, 
			int m3_JBNO, 
			DateTime m3_JBDT, 
			int m3_JBTM, 
			int? m3_CONO = null, 
			string m3_SUNO = null, 
			int? m3_RESE = null, 
			string m3_SINO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTaxArLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("JBNO", m3_JBNO.ToString())
				.WithQueryParameter("JBDT", m3_JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3_JBTM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_RESE.HasValue)
				request.WithQueryParameter("RESE", m3_RESE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SINO))
				request.WithQueryParameter("SINO", m3_SINO.Trim());

			// Execute the request
			var result = await Execute<LstTaxArLineResponse>(
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
		/// Name LstTaxTotStaSer
		/// Description List tax total per supplier state and service code
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_JBNO">Job number (Required)</param>
		/// <param name="m3_JBDT">Job date (Required)</param>
		/// <param name="m3_JBTM">Job time (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ECAR">Area/state</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTaxTotStaSerResponse></returns>
		/// <exception cref="M3Exception<LstTaxTotStaSerResponse>"></exception>
		public async Task<M3Response<LstTaxTotStaSerResponse>> LstTaxTotStaSer(
			string m3_DIVI, 
			int m3_JBNO, 
			DateTime m3_JBDT, 
			int m3_JBTM, 
			int? m3_CONO = null, 
			string m3_ECAR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTaxTotStaSer",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("JBNO", m3_JBNO.ToString())
				.WithQueryParameter("JBDT", m3_JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3_JBTM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());

			// Execute the request
			var result = await Execute<LstTaxTotStaSerResponse>(
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
		/// Name LstTaxTotSupSer
		/// Description List Tax Total per Supplier and Service code
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_JBNO">Job number (Required)</param>
		/// <param name="m3_JBDT">Job date (Required)</param>
		/// <param name="m3_JBTM">Job time (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_SERS">Service code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTaxTotSupSerResponse></returns>
		/// <exception cref="M3Exception<LstTaxTotSupSerResponse>"></exception>
		public async Task<M3Response<LstTaxTotSupSerResponse>> LstTaxTotSupSer(
			string m3_DIVI, 
			int m3_JBNO, 
			DateTime m3_JBDT, 
			int m3_JBTM, 
			int? m3_CONO = null, 
			string m3_SUNO = null, 
			int? m3_SERS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTaxTotSupSer",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("JBNO", m3_JBNO.ToString())
				.WithQueryParameter("JBDT", m3_JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3_JBTM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_SERS.HasValue)
				request.WithQueryParameter("SERS", m3_SERS.Value.ToString());

			// Execute the request
			var result = await Execute<LstTaxTotSupSerResponse>(
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
