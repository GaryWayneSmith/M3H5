/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 11.0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CCOM">Costing component (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3OBV2">Start value 2 (Required)</param>
		/// <param name="m3OBV3">Start value 3 (Required)</param>
		/// <param name="m3PCTP">Costing type (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MOPE">Material overhead</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3FACI, 
			string m3CCOM, 
			string m3OBV1, 
			string m3OBV2, 
			string m3OBV3, 
			string m3PCTP, 
			DateTime m3FRDT, 
			int? m3CONO = null, 
			string m3MOPE = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3CCOM))
				throw new ArgumentNullException(nameof(m3CCOM));
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));
			if (string.IsNullOrWhiteSpace(m3OBV2))
				throw new ArgumentNullException(nameof(m3OBV2));
			if (string.IsNullOrWhiteSpace(m3OBV3))
				throw new ArgumentNullException(nameof(m3OBV3));
			if (string.IsNullOrWhiteSpace(m3PCTP))
				throw new ArgumentNullException(nameof(m3PCTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("CCOM", m3CCOM.Trim())
				.WithQueryParameter("OBV1", m3OBV1.Trim())
				.WithQueryParameter("OBV2", m3OBV2.Trim())
				.WithQueryParameter("OBV3", m3OBV3.Trim())
				.WithQueryParameter("PCTP", m3PCTP.Trim())
				.WithQueryParameter("FRDT", m3FRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MOPE))
				request.WithQueryParameter("MOPE", m3MOPE.Trim());

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
		/// Name Copy
		/// Description Copy
		/// Version Release: 11.0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CCOM">Costing component (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3OBV2">Start value 2 (Required)</param>
		/// <param name="m3OBV3">Start value 3 (Required)</param>
		/// <param name="m3PCTP">Costing type (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3CFAC">Facility (Required)</param>
		/// <param name="m3CCCM">Costing component (Required)</param>
		/// <param name="m3COB1">Start value 1 (Required)</param>
		/// <param name="m3COB2">Start value 2 (Required)</param>
		/// <param name="m3COB3">Start value 3 (Required)</param>
		/// <param name="m3CPCT">Costing type (Required)</param>
		/// <param name="m3CFRD">From date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MOPE">Material overhead</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Copy(
			string m3FACI, 
			string m3CCOM, 
			string m3OBV1, 
			string m3OBV2, 
			string m3OBV3, 
			string m3PCTP, 
			DateTime m3FRDT, 
			string m3CFAC, 
			string m3CCCM, 
			string m3COB1, 
			string m3COB2, 
			string m3COB3, 
			string m3CPCT, 
			int m3CFRD, 
			int? m3CONO = null, 
			string m3MOPE = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3CCOM))
				throw new ArgumentNullException(nameof(m3CCOM));
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));
			if (string.IsNullOrWhiteSpace(m3OBV2))
				throw new ArgumentNullException(nameof(m3OBV2));
			if (string.IsNullOrWhiteSpace(m3OBV3))
				throw new ArgumentNullException(nameof(m3OBV3));
			if (string.IsNullOrWhiteSpace(m3PCTP))
				throw new ArgumentNullException(nameof(m3PCTP));
			if (string.IsNullOrWhiteSpace(m3CFAC))
				throw new ArgumentNullException(nameof(m3CFAC));
			if (string.IsNullOrWhiteSpace(m3CCCM))
				throw new ArgumentNullException(nameof(m3CCCM));
			if (string.IsNullOrWhiteSpace(m3COB1))
				throw new ArgumentNullException(nameof(m3COB1));
			if (string.IsNullOrWhiteSpace(m3COB2))
				throw new ArgumentNullException(nameof(m3COB2));
			if (string.IsNullOrWhiteSpace(m3COB3))
				throw new ArgumentNullException(nameof(m3COB3));
			if (string.IsNullOrWhiteSpace(m3CPCT))
				throw new ArgumentNullException(nameof(m3CPCT));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("CCOM", m3CCOM.Trim())
				.WithQueryParameter("OBV1", m3OBV1.Trim())
				.WithQueryParameter("OBV2", m3OBV2.Trim())
				.WithQueryParameter("OBV3", m3OBV3.Trim())
				.WithQueryParameter("PCTP", m3PCTP.Trim())
				.WithQueryParameter("FRDT", m3FRDT.ToM3String())
				.WithQueryParameter("CFAC", m3CFAC.Trim())
				.WithQueryParameter("CCCM", m3CCCM.Trim())
				.WithQueryParameter("COB1", m3COB1.Trim())
				.WithQueryParameter("COB2", m3COB2.Trim())
				.WithQueryParameter("COB3", m3COB3.Trim())
				.WithQueryParameter("CPCT", m3CPCT.Trim())
				.WithQueryParameter("CFRD", m3CFRD.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MOPE))
				request.WithQueryParameter("MOPE", m3MOPE.Trim());

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
		/// Version Release: 11.0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CCOM">Costing component (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3OBV2">Start value 2 (Required)</param>
		/// <param name="m3OBV3">Start value 3 (Required)</param>
		/// <param name="m3PCTP">Costing type (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3FACI, 
			string m3CCOM, 
			string m3OBV1, 
			string m3OBV2, 
			string m3OBV3, 
			string m3PCTP, 
			DateTime m3FRDT, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3CCOM))
				throw new ArgumentNullException(nameof(m3CCOM));
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));
			if (string.IsNullOrWhiteSpace(m3OBV2))
				throw new ArgumentNullException(nameof(m3OBV2));
			if (string.IsNullOrWhiteSpace(m3OBV3))
				throw new ArgumentNullException(nameof(m3OBV3));
			if (string.IsNullOrWhiteSpace(m3PCTP))
				throw new ArgumentNullException(nameof(m3PCTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("CCOM", m3CCOM.Trim())
				.WithQueryParameter("OBV1", m3OBV1.Trim())
				.WithQueryParameter("OBV2", m3OBV2.Trim())
				.WithQueryParameter("OBV3", m3OBV3.Trim())
				.WithQueryParameter("PCTP", m3PCTP.Trim())
				.WithQueryParameter("FRDT", m3FRDT.ToM3String());

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
		/// Name List
		/// Description List
		/// Version Release: 11.0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CCOM">Costing component (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3OBV2">Start value 2 (Required)</param>
		/// <param name="m3OBV3">Start value 3 (Required)</param>
		/// <param name="m3PCTP">Costing type (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3FACI, 
			string m3CCOM, 
			string m3OBV1, 
			string m3OBV2, 
			string m3OBV3, 
			string m3PCTP, 
			DateTime m3FRDT, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/List",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3CCOM))
				throw new ArgumentNullException(nameof(m3CCOM));
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));
			if (string.IsNullOrWhiteSpace(m3OBV2))
				throw new ArgumentNullException(nameof(m3OBV2));
			if (string.IsNullOrWhiteSpace(m3OBV3))
				throw new ArgumentNullException(nameof(m3OBV3));
			if (string.IsNullOrWhiteSpace(m3PCTP))
				throw new ArgumentNullException(nameof(m3PCTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("CCOM", m3CCOM.Trim())
				.WithQueryParameter("OBV1", m3OBV1.Trim())
				.WithQueryParameter("OBV2", m3OBV2.Trim())
				.WithQueryParameter("OBV3", m3OBV3.Trim())
				.WithQueryParameter("PCTP", m3PCTP.Trim())
				.WithQueryParameter("FRDT", m3FRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Retrieve
		/// Description Retrieve
		/// Version Release: 11.0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CCOM">Costing component (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3OBV2">Start value 2 (Required)</param>
		/// <param name="m3OBV3">Start value 3 (Required)</param>
		/// <param name="m3PCTP">Costing type (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<RetrieveResponse></returns>
		/// <exception cref="M3Exception<RetrieveResponse>"></exception>
		public async Task<M3Response<RetrieveResponse>> Retrieve(
			string m3FACI, 
			string m3CCOM, 
			string m3OBV1, 
			string m3OBV2, 
			string m3OBV3, 
			string m3PCTP, 
			DateTime m3FRDT, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Retrieve",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3CCOM))
				throw new ArgumentNullException(nameof(m3CCOM));
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));
			if (string.IsNullOrWhiteSpace(m3OBV2))
				throw new ArgumentNullException(nameof(m3OBV2));
			if (string.IsNullOrWhiteSpace(m3OBV3))
				throw new ArgumentNullException(nameof(m3OBV3));
			if (string.IsNullOrWhiteSpace(m3PCTP))
				throw new ArgumentNullException(nameof(m3PCTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("CCOM", m3CCOM.Trim())
				.WithQueryParameter("OBV1", m3OBV1.Trim())
				.WithQueryParameter("OBV2", m3OBV2.Trim())
				.WithQueryParameter("OBV3", m3OBV3.Trim())
				.WithQueryParameter("PCTP", m3PCTP.Trim())
				.WithQueryParameter("FRDT", m3FRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<RetrieveResponse>(
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
		/// Name Revise
		/// Description Revise
		/// Version Release: 11.0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CCOM">Costing component (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3OBV2">Start value 2 (Required)</param>
		/// <param name="m3OBV3">Start value 3 (Required)</param>
		/// <param name="m3PCTP">Costing type (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MOPE">Material overhead</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Revise(
			string m3FACI, 
			string m3CCOM, 
			string m3OBV1, 
			string m3OBV2, 
			string m3OBV3, 
			string m3PCTP, 
			DateTime m3FRDT, 
			int? m3CONO = null, 
			string m3MOPE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Revise",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3CCOM))
				throw new ArgumentNullException(nameof(m3CCOM));
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));
			if (string.IsNullOrWhiteSpace(m3OBV2))
				throw new ArgumentNullException(nameof(m3OBV2));
			if (string.IsNullOrWhiteSpace(m3OBV3))
				throw new ArgumentNullException(nameof(m3OBV3));
			if (string.IsNullOrWhiteSpace(m3PCTP))
				throw new ArgumentNullException(nameof(m3PCTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("CCOM", m3CCOM.Trim())
				.WithQueryParameter("OBV1", m3OBV1.Trim())
				.WithQueryParameter("OBV2", m3OBV2.Trim())
				.WithQueryParameter("OBV3", m3OBV3.Trim())
				.WithQueryParameter("PCTP", m3PCTP.Trim())
				.WithQueryParameter("FRDT", m3FRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MOPE))
				request.WithQueryParameter("MOPE", m3MOPE.Trim());

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
