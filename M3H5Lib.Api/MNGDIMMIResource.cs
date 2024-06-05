/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MNGDIMMI;
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
	/// Name: MNGDIMMI
	/// Component Name: MNGDIM
	/// Description: Api: Initiate Browse on error codes
	/// Version Release: 5ea0
	///</summary>
	public partial class MNGDIMMIResource : M3BaseResourceEndpoint
	{
		public MNGDIMMIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MNGDIMMI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddErrorCode1
		/// Description AddErrorCode1
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FCL0">Error code 1 (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_WACL">Warranty class</param>
		/// <param name="m3_SCHR">Scheduled removal</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddErrorCode1(
			string m3_FCL0, 
			string m3_TX40, 
			string m3_TX15 = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			string m3_WACL = null, 
			int? m3_SCHR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddErrorCode1",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FCL0))
				throw new ArgumentNullException("m3_FCL0");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("FCL0", m3_FCL0.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WACL))
				request.WithQueryParameter("WACL", m3_WACL.Trim());
			if (m3_SCHR.HasValue)
				request.WithQueryParameter("SCHR", m3_SCHR.Value.ToString());

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
		/// Name AddErrorCode2
		/// Description AddErrorCode2
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FCL2">Error code 2 (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddErrorCode2(
			string m3_FCL2, 
			string m3_TX40, 
			string m3_TX15 = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddErrorCode2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FCL2))
				throw new ArgumentNullException("m3_FCL2");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("FCL2", m3_FCL2.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());

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
		/// Name AddErrorCode3
		/// Description AddErrorCode3
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FCL3">Error code 3 (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddErrorCode3(
			string m3_FCL3, 
			string m3_TX40, 
			string m3_TX15 = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddErrorCode3",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FCL3))
				throw new ArgumentNullException("m3_FCL3");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("FCL3", m3_FCL3.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());

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
		/// Name BrwsErrCde1
		/// Description Initiate Browse on error code 1
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MOTP">Model/site</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_FCLA">Error code 1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<BrwsErrCde1Response></returns>
		/// <exception cref="M3Exception<BrwsErrCde1Response>"></exception>
		public async Task<M3Response<BrwsErrCde1Response>> BrwsErrCde1(
			int? m3_CONO = null, 
			string m3_MOTP = null, 
			string m3_CFGL = null, 
			string m3_ITNO = null, 
			string m3_SERN = null, 
			string m3_FCLA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/BrwsErrCde1",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MOTP))
				request.WithQueryParameter("MOTP", m3_MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCLA))
				request.WithQueryParameter("FCLA", m3_FCLA.Trim());

			// Execute the request
			var result = await Execute<BrwsErrCde1Response>(
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
		/// Name BrwsErrCde2
		/// Description Initiate Browse on error code 2
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MOTP">Model/site</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_FCLA">Error code 1</param>
		/// <param name="m3_FCL2">Error code 2</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<BrwsErrCde2Response></returns>
		/// <exception cref="M3Exception<BrwsErrCde2Response>"></exception>
		public async Task<M3Response<BrwsErrCde2Response>> BrwsErrCde2(
			int? m3_CONO = null, 
			string m3_MOTP = null, 
			string m3_CFGL = null, 
			string m3_ITNO = null, 
			string m3_SERN = null, 
			string m3_FCLA = null, 
			string m3_FCL2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/BrwsErrCde2",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MOTP))
				request.WithQueryParameter("MOTP", m3_MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCLA))
				request.WithQueryParameter("FCLA", m3_FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL2))
				request.WithQueryParameter("FCL2", m3_FCL2.Trim());

			// Execute the request
			var result = await Execute<BrwsErrCde2Response>(
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
		/// Name BrwsErrCde3
		/// Description Initiate Browse on error code 3
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MOTP">Model/site</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_FCLA">Error code 1</param>
		/// <param name="m3_FCL2">Error code 2</param>
		/// <param name="m3_FCL3">Error code 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<BrwsErrCde3Response></returns>
		/// <exception cref="M3Exception<BrwsErrCde3Response>"></exception>
		public async Task<M3Response<BrwsErrCde3Response>> BrwsErrCde3(
			int? m3_CONO = null, 
			string m3_MOTP = null, 
			string m3_CFGL = null, 
			string m3_ITNO = null, 
			string m3_SERN = null, 
			string m3_FCLA = null, 
			string m3_FCL2 = null, 
			string m3_FCL3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/BrwsErrCde3",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MOTP))
				request.WithQueryParameter("MOTP", m3_MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCLA))
				request.WithQueryParameter("FCLA", m3_FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL2))
				request.WithQueryParameter("FCL2", m3_FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL3))
				request.WithQueryParameter("FCL3", m3_FCL3.Trim());

			// Execute the request
			var result = await Execute<BrwsErrCde3Response>(
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
		/// Name LstErrCde
		/// Description Browse on error code
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CODE">Error code to be listed (Required)</param>
		/// <param name="m3_MOTP">Model/site</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_FCLA">Error code 1</param>
		/// <param name="m3_FCL2">Error code 2</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstErrCdeResponse></returns>
		/// <exception cref="M3Exception<LstErrCdeResponse>"></exception>
		public async Task<M3Response<LstErrCdeResponse>> LstErrCde(
			int m3_CODE, 
			string m3_MOTP = null, 
			string m3_CFGL = null, 
			string m3_ITNO = null, 
			string m3_SERN = null, 
			string m3_FCLA = null, 
			string m3_FCL2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstErrCde",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CODE", m3_CODE.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MOTP))
				request.WithQueryParameter("MOTP", m3_MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCLA))
				request.WithQueryParameter("FCLA", m3_FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL2))
				request.WithQueryParameter("FCL2", m3_FCL2.Trim());

			// Execute the request
			var result = await Execute<LstErrCdeResponse>(
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
		/// Name LstErrCde1
		/// Description Browse on error code 1
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_MOTP">Model/site</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_FCLA">Error code 1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstErrCde1Response></returns>
		/// <exception cref="M3Exception<LstErrCde1Response>"></exception>
		public async Task<M3Response<LstErrCde1Response>> LstErrCde1(
			string m3_MOTP = null, 
			string m3_CFGL = null, 
			string m3_ITNO = null, 
			string m3_SERN = null, 
			string m3_FCLA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstErrCde1",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MOTP))
				request.WithQueryParameter("MOTP", m3_MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCLA))
				request.WithQueryParameter("FCLA", m3_FCLA.Trim());

			// Execute the request
			var result = await Execute<LstErrCde1Response>(
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
		/// Name LstErrCde2
		/// Description Browse on error code 2
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_MOTP">Model/site</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_FCLA">Error code 1</param>
		/// <param name="m3_FCL2">Error code 2</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstErrCde2Response></returns>
		/// <exception cref="M3Exception<LstErrCde2Response>"></exception>
		public async Task<M3Response<LstErrCde2Response>> LstErrCde2(
			string m3_MOTP = null, 
			string m3_CFGL = null, 
			string m3_ITNO = null, 
			string m3_SERN = null, 
			string m3_FCLA = null, 
			string m3_FCL2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstErrCde2",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MOTP))
				request.WithQueryParameter("MOTP", m3_MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCLA))
				request.WithQueryParameter("FCLA", m3_FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL2))
				request.WithQueryParameter("FCL2", m3_FCL2.Trim());

			// Execute the request
			var result = await Execute<LstErrCde2Response>(
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
		/// Name LstErrCde3
		/// Description Browse on error code 3
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_MOTP">Model/site</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_FCLA">Error code 1</param>
		/// <param name="m3_FCL2">Error code 2</param>
		/// <param name="m3_FCL3">Error code 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstErrCde3Response></returns>
		/// <exception cref="M3Exception<LstErrCde3Response>"></exception>
		public async Task<M3Response<LstErrCde3Response>> LstErrCde3(
			string m3_MOTP = null, 
			string m3_CFGL = null, 
			string m3_ITNO = null, 
			string m3_SERN = null, 
			string m3_FCLA = null, 
			string m3_FCL2 = null, 
			string m3_FCL3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstErrCde3",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MOTP))
				request.WithQueryParameter("MOTP", m3_MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCLA))
				request.WithQueryParameter("FCLA", m3_FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL2))
				request.WithQueryParameter("FCL2", m3_FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL3))
				request.WithQueryParameter("FCL3", m3_FCL3.Trim());

			// Execute the request
			var result = await Execute<LstErrCde3Response>(
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
		/// Name LstRowsWPos
		/// Description Set Start and return rows
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_KV01">Key value 1</param>
		/// <param name="m3_KV02">Key value 2</param>
		/// <param name="m3_KV03">Key value 3</param>
		/// <param name="m3_KV04">Key value 4</param>
		/// <param name="m3_KV05">Key value 5</param>
		/// <param name="m3_KV06">Key value 6</param>
		/// <param name="m3_KV07">Key value 7</param>
		/// <param name="m3_KV08">Key value</param>
		/// <param name="m3_KV09">Key value</param>
		/// <param name="m3_KV10">Key value</param>
		/// <param name="m3_KV11">Key value</param>
		/// <param name="m3_KV12">Key value</param>
		/// <param name="m3_KV13">Key value</param>
		/// <param name="m3_KV14">Key value</param>
		/// <param name="m3_KV15">Key value</param>
		/// <param name="m3_KV16">Key value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRowsWPosResponse></returns>
		/// <exception cref="M3Exception<LstRowsWPosResponse>"></exception>
		public async Task<M3Response<LstRowsWPosResponse>> LstRowsWPos(
			string m3_KV01 = null, 
			string m3_KV02 = null, 
			string m3_KV03 = null, 
			string m3_KV04 = null, 
			string m3_KV05 = null, 
			string m3_KV06 = null, 
			string m3_KV07 = null, 
			string m3_KV08 = null, 
			string m3_KV09 = null, 
			string m3_KV10 = null, 
			string m3_KV11 = null, 
			string m3_KV12 = null, 
			string m3_KV13 = null, 
			string m3_KV14 = null, 
			string m3_KV15 = null, 
			string m3_KV16 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstRowsWPos",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_KV01))
				request.WithQueryParameter("KV01", m3_KV01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV02))
				request.WithQueryParameter("KV02", m3_KV02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV03))
				request.WithQueryParameter("KV03", m3_KV03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV04))
				request.WithQueryParameter("KV04", m3_KV04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV05))
				request.WithQueryParameter("KV05", m3_KV05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV06))
				request.WithQueryParameter("KV06", m3_KV06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV07))
				request.WithQueryParameter("KV07", m3_KV07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV08))
				request.WithQueryParameter("KV08", m3_KV08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV09))
				request.WithQueryParameter("KV09", m3_KV09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV10))
				request.WithQueryParameter("KV10", m3_KV10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV11))
				request.WithQueryParameter("KV11", m3_KV11.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV12))
				request.WithQueryParameter("KV12", m3_KV12.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV13))
				request.WithQueryParameter("KV13", m3_KV13.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV14))
				request.WithQueryParameter("KV14", m3_KV14.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV15))
				request.WithQueryParameter("KV15", m3_KV15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV16))
				request.WithQueryParameter("KV16", m3_KV16.Trim());

			// Execute the request
			var result = await Execute<LstRowsWPosResponse>(
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
