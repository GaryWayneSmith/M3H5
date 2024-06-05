/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddErrorCode1
		/// Description AddErrorCode1
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FCL0">Error code 1 (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3WACL">Warranty class</param>
		/// <param name="m3SCHR">Scheduled removal</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddErrorCode1(
			string m3FCL0, 
			string m3TX40, 
			string m3TX15 = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			string m3WACL = null, 
			int? m3SCHR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddErrorCode1",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FCL0))
				throw new ArgumentNullException(nameof(m3FCL0));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("FCL0", m3FCL0.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WACL))
				request.WithQueryParameter("WACL", m3WACL.Trim());
			if (m3SCHR.HasValue)
				request.WithQueryParameter("SCHR", m3SCHR.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddErrorCode2
		/// Description AddErrorCode2
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FCL2">Error code 2 (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddErrorCode2(
			string m3FCL2, 
			string m3TX40, 
			string m3TX15 = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddErrorCode2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FCL2))
				throw new ArgumentNullException(nameof(m3FCL2));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("FCL2", m3FCL2.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());

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
		/// Name AddErrorCode3
		/// Description AddErrorCode3
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FCL3">Error code 3 (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddErrorCode3(
			string m3FCL3, 
			string m3TX40, 
			string m3TX15 = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddErrorCode3",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FCL3))
				throw new ArgumentNullException(nameof(m3FCL3));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("FCL3", m3FCL3.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());

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
		/// Name BrwsErrCde1
		/// Description Initiate Browse on error code 1
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MOTP">Model/site</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3FCLA">Error code 1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<BrwsErrCde1Response></returns>
		/// <exception cref="M3Exception<BrwsErrCde1Response>"></exception>
		public async Task<M3Response<BrwsErrCde1Response>> BrwsErrCde1(
			int? m3CONO = null, 
			string m3MOTP = null, 
			string m3CFGL = null, 
			string m3ITNO = null, 
			string m3SERN = null, 
			string m3FCLA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/BrwsErrCde1",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MOTP))
				request.WithQueryParameter("MOTP", m3MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCLA))
				request.WithQueryParameter("FCLA", m3FCLA.Trim());

			// Execute the request
			var result = await Execute<BrwsErrCde1Response>(
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
		/// Name BrwsErrCde2
		/// Description Initiate Browse on error code 2
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MOTP">Model/site</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3FCLA">Error code 1</param>
		/// <param name="m3FCL2">Error code 2</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<BrwsErrCde2Response></returns>
		/// <exception cref="M3Exception<BrwsErrCde2Response>"></exception>
		public async Task<M3Response<BrwsErrCde2Response>> BrwsErrCde2(
			int? m3CONO = null, 
			string m3MOTP = null, 
			string m3CFGL = null, 
			string m3ITNO = null, 
			string m3SERN = null, 
			string m3FCLA = null, 
			string m3FCL2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/BrwsErrCde2",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MOTP))
				request.WithQueryParameter("MOTP", m3MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCLA))
				request.WithQueryParameter("FCLA", m3FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL2))
				request.WithQueryParameter("FCL2", m3FCL2.Trim());

			// Execute the request
			var result = await Execute<BrwsErrCde2Response>(
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
		/// Name BrwsErrCde3
		/// Description Initiate Browse on error code 3
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MOTP">Model/site</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3FCLA">Error code 1</param>
		/// <param name="m3FCL2">Error code 2</param>
		/// <param name="m3FCL3">Error code 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<BrwsErrCde3Response></returns>
		/// <exception cref="M3Exception<BrwsErrCde3Response>"></exception>
		public async Task<M3Response<BrwsErrCde3Response>> BrwsErrCde3(
			int? m3CONO = null, 
			string m3MOTP = null, 
			string m3CFGL = null, 
			string m3ITNO = null, 
			string m3SERN = null, 
			string m3FCLA = null, 
			string m3FCL2 = null, 
			string m3FCL3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/BrwsErrCde3",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MOTP))
				request.WithQueryParameter("MOTP", m3MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCLA))
				request.WithQueryParameter("FCLA", m3FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL2))
				request.WithQueryParameter("FCL2", m3FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL3))
				request.WithQueryParameter("FCL3", m3FCL3.Trim());

			// Execute the request
			var result = await Execute<BrwsErrCde3Response>(
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
		/// Name LstErrCde
		/// Description Browse on error code
		/// Version Release: 
		/// </summary>
		/// <param name="m3CODE">Error code to be listed (Required)</param>
		/// <param name="m3MOTP">Model/site</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3FCLA">Error code 1</param>
		/// <param name="m3FCL2">Error code 2</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstErrCdeResponse></returns>
		/// <exception cref="M3Exception<LstErrCdeResponse>"></exception>
		public async Task<M3Response<LstErrCdeResponse>> LstErrCde(
			int m3CODE, 
			string m3MOTP = null, 
			string m3CFGL = null, 
			string m3ITNO = null, 
			string m3SERN = null, 
			string m3FCLA = null, 
			string m3FCL2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstErrCde",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CODE", m3CODE.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MOTP))
				request.WithQueryParameter("MOTP", m3MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCLA))
				request.WithQueryParameter("FCLA", m3FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL2))
				request.WithQueryParameter("FCL2", m3FCL2.Trim());

			// Execute the request
			var result = await Execute<LstErrCdeResponse>(
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
		/// Name LstErrCde1
		/// Description Browse on error code 1
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3MOTP">Model/site</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3FCLA">Error code 1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstErrCde1Response></returns>
		/// <exception cref="M3Exception<LstErrCde1Response>"></exception>
		public async Task<M3Response<LstErrCde1Response>> LstErrCde1(
			string m3MOTP = null, 
			string m3CFGL = null, 
			string m3ITNO = null, 
			string m3SERN = null, 
			string m3FCLA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstErrCde1",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MOTP))
				request.WithQueryParameter("MOTP", m3MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCLA))
				request.WithQueryParameter("FCLA", m3FCLA.Trim());

			// Execute the request
			var result = await Execute<LstErrCde1Response>(
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
		/// Name LstErrCde2
		/// Description Browse on error code 2
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3MOTP">Model/site</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3FCLA">Error code 1</param>
		/// <param name="m3FCL2">Error code 2</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstErrCde2Response></returns>
		/// <exception cref="M3Exception<LstErrCde2Response>"></exception>
		public async Task<M3Response<LstErrCde2Response>> LstErrCde2(
			string m3MOTP = null, 
			string m3CFGL = null, 
			string m3ITNO = null, 
			string m3SERN = null, 
			string m3FCLA = null, 
			string m3FCL2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstErrCde2",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MOTP))
				request.WithQueryParameter("MOTP", m3MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCLA))
				request.WithQueryParameter("FCLA", m3FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL2))
				request.WithQueryParameter("FCL2", m3FCL2.Trim());

			// Execute the request
			var result = await Execute<LstErrCde2Response>(
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
		/// Name LstErrCde3
		/// Description Browse on error code 3
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3MOTP">Model/site</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3FCLA">Error code 1</param>
		/// <param name="m3FCL2">Error code 2</param>
		/// <param name="m3FCL3">Error code 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstErrCde3Response></returns>
		/// <exception cref="M3Exception<LstErrCde3Response>"></exception>
		public async Task<M3Response<LstErrCde3Response>> LstErrCde3(
			string m3MOTP = null, 
			string m3CFGL = null, 
			string m3ITNO = null, 
			string m3SERN = null, 
			string m3FCLA = null, 
			string m3FCL2 = null, 
			string m3FCL3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstErrCde3",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MOTP))
				request.WithQueryParameter("MOTP", m3MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCLA))
				request.WithQueryParameter("FCLA", m3FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL2))
				request.WithQueryParameter("FCL2", m3FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL3))
				request.WithQueryParameter("FCL3", m3FCL3.Trim());

			// Execute the request
			var result = await Execute<LstErrCde3Response>(
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
		/// Name LstRowsWPos
		/// Description Set Start and return rows
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3KV01">Key value 1</param>
		/// <param name="m3KV02">Key value 2</param>
		/// <param name="m3KV03">Key value 3</param>
		/// <param name="m3KV04">Key value 4</param>
		/// <param name="m3KV05">Key value 5</param>
		/// <param name="m3KV06">Key value 6</param>
		/// <param name="m3KV07">Key value 7</param>
		/// <param name="m3KV08">Key value</param>
		/// <param name="m3KV09">Key value</param>
		/// <param name="m3KV10">Key value</param>
		/// <param name="m3KV11">Key value</param>
		/// <param name="m3KV12">Key value</param>
		/// <param name="m3KV13">Key value</param>
		/// <param name="m3KV14">Key value</param>
		/// <param name="m3KV15">Key value</param>
		/// <param name="m3KV16">Key value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRowsWPosResponse></returns>
		/// <exception cref="M3Exception<LstRowsWPosResponse>"></exception>
		public async Task<M3Response<LstRowsWPosResponse>> LstRowsWPos(
			string m3KV01 = null, 
			string m3KV02 = null, 
			string m3KV03 = null, 
			string m3KV04 = null, 
			string m3KV05 = null, 
			string m3KV06 = null, 
			string m3KV07 = null, 
			string m3KV08 = null, 
			string m3KV09 = null, 
			string m3KV10 = null, 
			string m3KV11 = null, 
			string m3KV12 = null, 
			string m3KV13 = null, 
			string m3KV14 = null, 
			string m3KV15 = null, 
			string m3KV16 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstRowsWPos",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3KV01))
				request.WithQueryParameter("KV01", m3KV01.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV02))
				request.WithQueryParameter("KV02", m3KV02.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV03))
				request.WithQueryParameter("KV03", m3KV03.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV04))
				request.WithQueryParameter("KV04", m3KV04.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV05))
				request.WithQueryParameter("KV05", m3KV05.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV06))
				request.WithQueryParameter("KV06", m3KV06.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV07))
				request.WithQueryParameter("KV07", m3KV07.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV08))
				request.WithQueryParameter("KV08", m3KV08.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV09))
				request.WithQueryParameter("KV09", m3KV09.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV10))
				request.WithQueryParameter("KV10", m3KV10.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV11))
				request.WithQueryParameter("KV11", m3KV11.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV12))
				request.WithQueryParameter("KV12", m3KV12.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV13))
				request.WithQueryParameter("KV13", m3KV13.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV14))
				request.WithQueryParameter("KV14", m3KV14.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV15))
				request.WithQueryParameter("KV15", m3KV15.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV16))
				request.WithQueryParameter("KV16", m3KV16.Trim());

			// Execute the request
			var result = await Execute<LstRowsWPosResponse>(
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
