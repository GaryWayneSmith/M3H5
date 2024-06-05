/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.AAS390MI;
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
	/// Name: AAS390MI
	/// Component Name: OnlineInvoice
	/// Description: Online Invoicing Transaction
	/// Version Release: 5ea3
	///</summary>
	public partial class AAS390MIResource : M3BaseResourceEndpoint
	{
		public AAS390MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "AAS390MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 6400
		/// </summary>
		/// <param name="m3_CINO">Invoice number (Required)</param>
		/// <param name="m3_INYR">Invoice year (Required)</param>
		/// <param name="m3_FEID">FAM function (Required)</param>
		/// <param name="m3_VONO">Voucher number (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_CINO, 
			int m3_INYR, 
			string m3_FEID, 
			int m3_VONO, 
			string m3_DIVI = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CINO))
				throw new ArgumentNullException("m3_CINO");
			if (string.IsNullOrWhiteSpace(m3_FEID))
				throw new ArgumentNullException("m3_FEID");

			// Set mandatory parameters
			request
				.WithQueryParameter("CINO", m3_CINO.Trim())
				.WithQueryParameter("INYR", m3_INYR.ToString())
				.WithQueryParameter("FEID", m3_FEID.Trim())
				.WithQueryParameter("VONO", m3_VONO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

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
		/// Name Dlt
		/// Description Dlt
		/// Version Release: 6400
		/// </summary>
		/// <param name="m3_CINO">Invoice number (Required)</param>
		/// <param name="m3_INYR">Invoice year (Required)</param>
		/// <param name="m3_BJNO">Job number (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Dlt(
			string m3_CINO, 
			int m3_INYR, 
			string m3_BJNO, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Dlt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CINO))
				throw new ArgumentNullException("m3_CINO");
			if (string.IsNullOrWhiteSpace(m3_BJNO))
				throw new ArgumentNullException("m3_BJNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CINO", m3_CINO.Trim())
				.WithQueryParameter("INYR", m3_INYR.ToString())
				.WithQueryParameter("BJNO", m3_BJNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

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
		/// Version Release: 6400
		/// </summary>
		/// <param name="m3_CINO">Invoice number (Required)</param>
		/// <param name="m3_INYR">Invoice year (Required)</param>
		/// <param name="m3_BJNO">Job number (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_CINO, 
			int m3_INYR, 
			string m3_BJNO, 
			string m3_DIVI = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CINO))
				throw new ArgumentNullException("m3_CINO");
			if (string.IsNullOrWhiteSpace(m3_BJNO))
				throw new ArgumentNullException("m3_BJNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CINO", m3_CINO.Trim())
				.WithQueryParameter("INYR", m3_INYR.ToString())
				.WithQueryParameter("BJNO", m3_BJNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

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
		/// Name Lst
		/// Description Lst
		/// Version Release: 6400
		/// </summary>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_CINO">Invoice number</param>
		/// <param name="m3_INYR">Invoice year</param>
		/// <param name="m3_BJNO">Job number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3_DIVI = null, 
			string m3_CINO = null, 
			int? m3_INYR = null, 
			string m3_BJNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Lst",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CINO))
				request.WithQueryParameter("CINO", m3_CINO.Trim());
			if (m3_INYR.HasValue)
				request.WithQueryParameter("INYR", m3_INYR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BJNO))
				request.WithQueryParameter("BJNO", m3_BJNO.Trim());

			// Execute the request
			var result = await Execute<LstResponse>(
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
		/// Name UpdInvResponse
		/// Description Update invoice response per Invoice number and year
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_CINO">Invoice number (Required)</param>
		/// <param name="m3_INYR">Invoice year (Required)</param>
		/// <param name="m3_STAT">Status (Required)</param>
		/// <param name="m3_BVEC">Blocking validation error code</param>
		/// <param name="m3_TRNI">Transaction ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdInvResponse(
			string m3_DIVI, 
			string m3_CINO, 
			int m3_INYR, 
			string m3_STAT, 
			string m3_BVEC = null, 
			string m3_TRNI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdInvResponse",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_CINO))
				throw new ArgumentNullException("m3_CINO");
			if (string.IsNullOrWhiteSpace(m3_STAT))
				throw new ArgumentNullException("m3_STAT");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("CINO", m3_CINO.Trim())
				.WithQueryParameter("INYR", m3_INYR.ToString())
				.WithQueryParameter("STAT", m3_STAT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BVEC))
				request.WithQueryParameter("BVEC", m3_BVEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRNI))
				request.WithQueryParameter("TRNI", m3_TRNI.Trim());

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
		/// Name UpdInvStatus
		/// Description UpdInvStatus
		/// Version Release: 6400
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BSCD">Base country (Required)</param>
		/// <param name="m3_BJNO">Job number (Required)</param>
		/// <param name="m3_TRNO">Transaction number (Required)</param>
		/// <param name="m3_BSBF">Message indicator</param>
		/// <param name="m3_BVEC">Blocking validation error code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdInvStatus(
			string m3_DIVI, 
			string m3_BSCD, 
			string m3_BJNO, 
			int m3_TRNO, 
			string m3_BSBF = null, 
			string m3_BVEC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdInvStatus",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BSCD))
				throw new ArgumentNullException("m3_BSCD");
			if (string.IsNullOrWhiteSpace(m3_BJNO))
				throw new ArgumentNullException("m3_BJNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BSCD", m3_BSCD.Trim())
				.WithQueryParameter("BJNO", m3_BJNO.Trim())
				.WithQueryParameter("TRNO", m3_TRNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BSBF))
				request.WithQueryParameter("BSBF", m3_BSBF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BVEC))
				request.WithQueryParameter("BVEC", m3_BVEC.Trim());

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
		/// Name UpdTransID
		/// Description UpdTransID
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_BSCD">Base country (Required)</param>
		/// <param name="m3_BJNO">Job number (Required)</param>
		/// <param name="m3_TRNO">Transaction number (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_TRNI">Transaction ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdTransID(
			string m3_BSCD, 
			string m3_BJNO, 
			int m3_TRNO, 
			string m3_DIVI = null, 
			string m3_TRNI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdTransID",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BSCD))
				throw new ArgumentNullException("m3_BSCD");
			if (string.IsNullOrWhiteSpace(m3_BJNO))
				throw new ArgumentNullException("m3_BJNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("BSCD", m3_BSCD.Trim())
				.WithQueryParameter("BJNO", m3_BJNO.Trim())
				.WithQueryParameter("TRNO", m3_TRNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRNI))
				request.WithQueryParameter("TRNI", m3_TRNI.Trim());

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
