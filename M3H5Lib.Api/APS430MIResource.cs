/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3JBNO">Job number (Required)</param>
		/// <param name="m3JBDT">Job date (Required)</param>
		/// <param name="m3JBTM">Job time (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTaxHeadResponse></returns>
		/// <exception cref="M3Exception<GetTaxHeadResponse>"></exception>
		public async Task<M3Response<GetTaxHeadResponse>> GetTaxHead(
			string m3DIVI, 
			int m3JBNO, 
			DateTime m3JBDT, 
			int m3JBTM, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetTaxHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("JBNO", m3JBNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBDT", m3JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3JBTM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetTaxHeadResponse>(
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
		/// Name GetTaxTotSer
		/// Description Get tax total per Service code
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3JBNO">Job number</param>
		/// <param name="m3JBDT">Job date</param>
		/// <param name="m3JBTM">Job time</param>
		/// <param name="m3SERS">Service code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTaxTotSerResponse></returns>
		/// <exception cref="M3Exception<GetTaxTotSerResponse>"></exception>
		public async Task<M3Response<GetTaxTotSerResponse>> GetTaxTotSer(
			int? m3CONO = null, 
			string m3DIVI = null, 
			int? m3JBNO = null, 
			DateTime? m3JBDT = null, 
			int? m3JBTM = null, 
			int? m3SERS = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3JBNO.HasValue)
				request.WithQueryParameter("JBNO", m3JBNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3JBDT.HasValue)
				request.WithQueryParameter("JBDT", m3JBDT.Value.ToM3String());
			if (m3JBTM.HasValue)
				request.WithQueryParameter("JBTM", m3JBTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SERS.HasValue)
				request.WithQueryParameter("SERS", m3SERS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetTaxTotSerResponse>(
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
		/// Name GetTaxTotStaSer
		/// Description Get tax total per supplier state and service code
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3JBNO">Job number (Required)</param>
		/// <param name="m3JBDT">Job date (Required)</param>
		/// <param name="m3JBTM">Job time (Required)</param>
		/// <param name="m3ECAR">Area/state (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTaxTotStaSerResponse></returns>
		/// <exception cref="M3Exception<GetTaxTotStaSerResponse>"></exception>
		public async Task<M3Response<GetTaxTotStaSerResponse>> GetTaxTotStaSer(
			string m3DIVI, 
			int m3JBNO, 
			DateTime m3JBDT, 
			int m3JBTM, 
			string m3ECAR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetTaxTotStaSer",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3ECAR))
				throw new ArgumentNullException(nameof(m3ECAR));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("JBNO", m3JBNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBDT", m3JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3JBTM.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ECAR", m3ECAR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetTaxTotStaSerResponse>(
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
		/// Name GetTaxTotSupSer
		/// Description Get Tax Total per Supplier and Service code
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3JBNO">Job number (Required)</param>
		/// <param name="m3JBDT">Job date (Required)</param>
		/// <param name="m3JBTM">Job time (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SERS">Service code (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTaxTotSupSerResponse></returns>
		/// <exception cref="M3Exception<GetTaxTotSupSerResponse>"></exception>
		public async Task<M3Response<GetTaxTotSupSerResponse>> GetTaxTotSupSer(
			string m3DIVI, 
			int m3JBNO, 
			DateTime m3JBDT, 
			int m3JBTM, 
			string m3SUNO, 
			int m3SERS, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetTaxTotSupSer",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("JBNO", m3JBNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBDT", m3JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3JBTM.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SERS", m3SERS.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetTaxTotSupSerResponse>(
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
		/// Name LstTaxArLine
		/// Description List Tax Argentina Line Level
		/// Version Release: 
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3JBNO">Job number (Required)</param>
		/// <param name="m3JBDT">Job date (Required)</param>
		/// <param name="m3JBTM">Job time (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3RESE">Related service code</param>
		/// <param name="m3SINO">Supplier invoice number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTaxArLineResponse></returns>
		/// <exception cref="M3Exception<LstTaxArLineResponse>"></exception>
		public async Task<M3Response<LstTaxArLineResponse>> LstTaxArLine(
			string m3DIVI, 
			int m3JBNO, 
			DateTime m3JBDT, 
			int m3JBTM, 
			int? m3CONO = null, 
			string m3SUNO = null, 
			int? m3RESE = null, 
			string m3SINO = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("JBNO", m3JBNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBDT", m3JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3JBTM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3RESE.HasValue)
				request.WithQueryParameter("RESE", m3RESE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SINO))
				request.WithQueryParameter("SINO", m3SINO.Trim());

			// Execute the request
			var result = await Execute<LstTaxArLineResponse>(
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
		/// Name LstTaxTotStaSer
		/// Description List tax total per supplier state and service code
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3JBNO">Job number (Required)</param>
		/// <param name="m3JBDT">Job date (Required)</param>
		/// <param name="m3JBTM">Job time (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ECAR">Area/state</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTaxTotStaSerResponse></returns>
		/// <exception cref="M3Exception<LstTaxTotStaSerResponse>"></exception>
		public async Task<M3Response<LstTaxTotStaSerResponse>> LstTaxTotStaSer(
			string m3DIVI, 
			int m3JBNO, 
			DateTime m3JBDT, 
			int m3JBTM, 
			int? m3CONO = null, 
			string m3ECAR = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("JBNO", m3JBNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBDT", m3JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3JBTM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());

			// Execute the request
			var result = await Execute<LstTaxTotStaSerResponse>(
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
		/// Name LstTaxTotSupSer
		/// Description List Tax Total per Supplier and Service code
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3JBNO">Job number (Required)</param>
		/// <param name="m3JBDT">Job date (Required)</param>
		/// <param name="m3JBTM">Job time (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SERS">Service code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTaxTotSupSerResponse></returns>
		/// <exception cref="M3Exception<LstTaxTotSupSerResponse>"></exception>
		public async Task<M3Response<LstTaxTotSupSerResponse>> LstTaxTotSupSer(
			string m3DIVI, 
			int m3JBNO, 
			DateTime m3JBDT, 
			int m3JBTM, 
			int? m3CONO = null, 
			string m3SUNO = null, 
			int? m3SERS = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("JBNO", m3JBNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBDT", m3JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3JBTM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3SERS.HasValue)
				request.WithQueryParameter("SERS", m3SERS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstTaxTotSupSerResponse>(
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
