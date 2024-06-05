/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Activate
		/// Description Activate
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ECON">ECO number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Activate(
			long m3ECON, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Activate",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("ECON", m3ECON.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Add
		/// Description Add
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ECAC">ECO type (Required)</param>
		/// <param name="m3ECT1">Change text 1 (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TX01">Description</param>
		/// <param name="m3ECON">ECO number</param>
		/// <param name="m3ISBY">Issuer</param>
		/// <param name="m3DATE">Entry date</param>
		/// <param name="m3ECEX">Change type</param>
		/// <param name="m3PRIO">Priority</param>
		/// <param name="m3ECT2">Change text 2</param>
		/// <param name="m3TX03">Description</param>
		/// <param name="m3ECST">Status</param>
		/// <param name="m3ECVA">Financial evaluation</param>
		/// <param name="m3COAN">Consequense analysis</param>
		/// <param name="m3WIOR">Withdrawal order</param>
		/// <param name="m3CUAP">Customer approval</param>
		/// <param name="m3AIDT">Implement date</param>
		/// <param name="m3FSQT">From on-hand balance</param>
		/// <param name="m3FSNO">From serial number</param>
		/// <param name="m3TX02">Description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddResponse></returns>
		/// <exception cref="M3Exception<AddResponse>"></exception>
		public async Task<M3Response<AddResponse>> Add(
			string m3ECAC, 
			string m3ECT1, 
			DateTime m3FDAT, 
			int? m3CONO = null, 
			string m3TX01 = null, 
			string m3ECON = null, 
			string m3ISBY = null, 
			DateTime? m3DATE = null, 
			string m3ECEX = null, 
			int? m3PRIO = null, 
			string m3ECT2 = null, 
			string m3TX03 = null, 
			string m3ECST = null, 
			int? m3ECVA = null, 
			int? m3COAN = null, 
			int? m3WIOR = null, 
			int? m3CUAP = null, 
			DateTime? m3AIDT = null, 
			string m3FSQT = null, 
			string m3FSNO = null, 
			string m3TX02 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ECAC))
				throw new ArgumentNullException(nameof(m3ECAC));
			if (string.IsNullOrWhiteSpace(m3ECT1))
				throw new ArgumentNullException(nameof(m3ECT1));

			// Set mandatory parameters
			request
				.WithQueryParameter("ECAC", m3ECAC.Trim())
				.WithQueryParameter("ECT1", m3ECT1.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX01))
				request.WithQueryParameter("TX01", m3TX01.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECON))
				request.WithQueryParameter("ECON", m3ECON.Trim());
			if (!string.IsNullOrWhiteSpace(m3ISBY))
				request.WithQueryParameter("ISBY", m3ISBY.Trim());
			if (m3DATE.HasValue)
				request.WithQueryParameter("DATE", m3DATE.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ECEX))
				request.WithQueryParameter("ECEX", m3ECEX.Trim());
			if (m3PRIO.HasValue)
				request.WithQueryParameter("PRIO", m3PRIO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECT2))
				request.WithQueryParameter("ECT2", m3ECT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX03))
				request.WithQueryParameter("TX03", m3TX03.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECST))
				request.WithQueryParameter("ECST", m3ECST.Trim());
			if (m3ECVA.HasValue)
				request.WithQueryParameter("ECVA", m3ECVA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COAN.HasValue)
				request.WithQueryParameter("COAN", m3COAN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WIOR.HasValue)
				request.WithQueryParameter("WIOR", m3WIOR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CUAP.HasValue)
				request.WithQueryParameter("CUAP", m3CUAP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AIDT.HasValue)
				request.WithQueryParameter("AIDT", m3AIDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3FSQT))
				request.WithQueryParameter("FSQT", m3FSQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3FSNO))
				request.WithQueryParameter("FSNO", m3FSNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX02))
				request.WithQueryParameter("TX02", m3TX02.Trim());

			// Execute the request
			var result = await Execute<AddResponse>(
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
		/// Name Copy
		/// Description Copy
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ECON">From ECO number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CCON">To ECO number</param>
		/// <param name="m3CINE">Copy order line</param>
		/// <param name="m3CXTL">Copy text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Copy(
			string m3ECON, 
			int? m3CONO = null, 
			string m3CCON = null, 
			int? m3CINE = null, 
			int? m3CXTL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Copy",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ECON))
				throw new ArgumentNullException(nameof(m3ECON));

			// Set mandatory parameters
			request
				.WithQueryParameter("ECON", m3ECON.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CCON))
				request.WithQueryParameter("CCON", m3CCON.Trim());
			if (m3CINE.HasValue)
				request.WithQueryParameter("CINE", m3CINE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CXTL.HasValue)
				request.WithQueryParameter("CXTL", m3CXTL.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Deactivate
		/// Description Deactivate
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ECON">ECO number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Deactivate(
			long m3ECON, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Deactivate",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("ECON", m3ECON.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Delete
		/// Description Delete
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ECON">ECO number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			long m3ECON, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Delete",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("ECON", m3ECON.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Description Get
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ECON">ECO number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			long m3ECON, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("ECON", m3ECON.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name List
		/// Description List
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ECST">Status</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			int? m3CONO = null, 
			string m3ECST = null, 
			DateTime? m3FDAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/List",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECST))
				request.WithQueryParameter("ECST", m3ECST.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());

			// Execute the request
			var result = await Execute<ListResponse>(
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
		/// Name Update
		/// Description Update
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ECON">ECO number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ECAC">ECO type</param>
		/// <param name="m3ECT1">Change text 1</param>
		/// <param name="m3TX01">Description</param>
		/// <param name="m3ECT2">Change text 2</param>
		/// <param name="m3ISBY">Issuer</param>
		/// <param name="m3DATE">Entry date</param>
		/// <param name="m3ECST">Status</param>
		/// <param name="m3TX03">Description</param>
		/// <param name="m3ECEX">Change type</param>
		/// <param name="m3PRIO">Priority</param>
		/// <param name="m3ECVA">Financial evaluation</param>
		/// <param name="m3COAN">Consequense analysis</param>
		/// <param name="m3WIOR">Withdrawal order</param>
		/// <param name="m3CUAP">Customer approval</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3AIDT">Implement date</param>
		/// <param name="m3FSQT">From on-hand balance</param>
		/// <param name="m3FSNO">From serial number</param>
		/// <param name="m3TX02">Description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Update(
			string m3ECON, 
			int? m3CONO = null, 
			string m3ECAC = null, 
			string m3ECT1 = null, 
			string m3TX01 = null, 
			string m3ECT2 = null, 
			string m3ISBY = null, 
			DateTime? m3DATE = null, 
			string m3ECST = null, 
			string m3TX03 = null, 
			string m3ECEX = null, 
			int? m3PRIO = null, 
			int? m3ECVA = null, 
			int? m3COAN = null, 
			int? m3WIOR = null, 
			int? m3CUAP = null, 
			DateTime? m3FDAT = null, 
			DateTime? m3AIDT = null, 
			string m3FSQT = null, 
			string m3FSNO = null, 
			string m3TX02 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Update",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ECON))
				throw new ArgumentNullException(nameof(m3ECON));

			// Set mandatory parameters
			request
				.WithQueryParameter("ECON", m3ECON.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECAC))
				request.WithQueryParameter("ECAC", m3ECAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECT1))
				request.WithQueryParameter("ECT1", m3ECT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX01))
				request.WithQueryParameter("TX01", m3TX01.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECT2))
				request.WithQueryParameter("ECT2", m3ECT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ISBY))
				request.WithQueryParameter("ISBY", m3ISBY.Trim());
			if (m3DATE.HasValue)
				request.WithQueryParameter("DATE", m3DATE.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ECST))
				request.WithQueryParameter("ECST", m3ECST.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX03))
				request.WithQueryParameter("TX03", m3TX03.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECEX))
				request.WithQueryParameter("ECEX", m3ECEX.Trim());
			if (m3PRIO.HasValue)
				request.WithQueryParameter("PRIO", m3PRIO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ECVA.HasValue)
				request.WithQueryParameter("ECVA", m3ECVA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COAN.HasValue)
				request.WithQueryParameter("COAN", m3COAN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WIOR.HasValue)
				request.WithQueryParameter("WIOR", m3WIOR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CUAP.HasValue)
				request.WithQueryParameter("CUAP", m3CUAP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3AIDT.HasValue)
				request.WithQueryParameter("AIDT", m3AIDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3FSQT))
				request.WithQueryParameter("FSQT", m3FSQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3FSNO))
				request.WithQueryParameter("FSNO", m3FSNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX02))
				request.WithQueryParameter("TX02", m3TX02.Trim());

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
