/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS682MI;
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
	/// Name: CRS682MI
	/// Component Name: Insurance ID
	/// Description: Insurance ID
	/// Version Release: 5ea0
	///</summary>
	public partial class CRS682MIResource : M3BaseResourceEndpoint
	{
		public CRS682MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS682MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Enter Insurance data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CUNO">Customer (Required)</param>
		/// <param name="m3_ITRQ">Insurance type (Required)</param>
		/// <param name="m3_CIID">Insurance ID (Required)</param>
		/// <param name="m3_INFD">Insured from date (Required)</param>
		/// <param name="m3_INTD">Insured to date (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_INRQ">Insurance required</param>
		/// <param name="m3_INFA">Insured for amount</param>
		/// <param name="m3_IPOL">Insurance policy no</param>
		/// <param name="m3_IVEN">Insurance vendor</param>
		/// <param name="m3_NOT1">Note</param>
		/// <param name="m3_NOT2">Note</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_CUNO, 
			int m3_ITRQ, 
			string m3_CIID, 
			DateTime m3_INFD, 
			DateTime m3_INTD, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			int? m3_INRQ = null, 
			decimal? m3_INFA = null, 
			string m3_IPOL = null, 
			string m3_IVEN = null, 
			string m3_NOT1 = null, 
			string m3_NOT2 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_CIID))
				throw new ArgumentNullException("m3_CIID");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("ITRQ", m3_ITRQ.ToString())
				.WithQueryParameter("CIID", m3_CIID.Trim())
				.WithQueryParameter("INFD", m3_INFD.ToM3String())
				.WithQueryParameter("INTD", m3_INTD.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_INRQ.HasValue)
				request.WithQueryParameter("INRQ", m3_INRQ.Value.ToString());
			if (m3_INFA.HasValue)
				request.WithQueryParameter("INFA", m3_INFA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_IPOL))
				request.WithQueryParameter("IPOL", m3_IPOL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IVEN))
				request.WithQueryParameter("IVEN", m3_IVEN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NOT1))
				request.WithQueryParameter("NOT1", m3_NOT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NOT2))
				request.WithQueryParameter("NOT2", m3_NOT2.Trim());

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
		/// Description Delete  Insurance data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CUNO">Customer (Required)</param>
		/// <param name="m3_ITRQ">Insurance type (Required)</param>
		/// <param name="m3_CIID">Insurance ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3_CUNO, 
			int m3_ITRQ, 
			string m3_CIID, 
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
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_CIID))
				throw new ArgumentNullException("m3_CIID");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("ITRQ", m3_ITRQ.ToString())
				.WithQueryParameter("CIID", m3_CIID.Trim());

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
		/// Description Get  Insurance data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CUNO">Customer (Required)</param>
		/// <param name="m3_ITRQ">Insurance type (Required)</param>
		/// <param name="m3_CIID">Insurance ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_CUNO, 
			int m3_ITRQ, 
			string m3_CIID, 
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
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_CIID))
				throw new ArgumentNullException("m3_CIID");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("ITRQ", m3_ITRQ.ToString())
				.WithQueryParameter("CIID", m3_CIID.Trim());

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
		/// Description List  Insurance data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CUNO">Customer (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3_CUNO, 
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

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

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
		/// Name Upd
		/// Description Update Insurance data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CUNO">Customer (Required)</param>
		/// <param name="m3_ITRQ">Insurance type (Required)</param>
		/// <param name="m3_CIID">Insurance ID (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_INRQ">Insurance required</param>
		/// <param name="m3_INFD">Insured from date</param>
		/// <param name="m3_INTD">Insured to date</param>
		/// <param name="m3_INFA">Insured for amount</param>
		/// <param name="m3_IPOL">Insurance policy no</param>
		/// <param name="m3_IVEN">Insurance vendor</param>
		/// <param name="m3_NOT1">Note</param>
		/// <param name="m3_NOT2">Note</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3_CUNO, 
			int m3_ITRQ, 
			string m3_CIID, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			int? m3_INRQ = null, 
			DateTime? m3_INFD = null, 
			DateTime? m3_INTD = null, 
			decimal? m3_INFA = null, 
			string m3_IPOL = null, 
			string m3_IVEN = null, 
			string m3_NOT1 = null, 
			string m3_NOT2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Upd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_CIID))
				throw new ArgumentNullException("m3_CIID");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("ITRQ", m3_ITRQ.ToString())
				.WithQueryParameter("CIID", m3_CIID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_INRQ.HasValue)
				request.WithQueryParameter("INRQ", m3_INRQ.Value.ToString());
			if (m3_INFD.HasValue)
				request.WithQueryParameter("INFD", m3_INFD.Value.ToM3String());
			if (m3_INTD.HasValue)
				request.WithQueryParameter("INTD", m3_INTD.Value.ToM3String());
			if (m3_INFA.HasValue)
				request.WithQueryParameter("INFA", m3_INFA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_IPOL))
				request.WithQueryParameter("IPOL", m3_IPOL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IVEN))
				request.WithQueryParameter("IVEN", m3_IVEN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NOT1))
				request.WithQueryParameter("NOT1", m3_NOT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NOT2))
				request.WithQueryParameter("NOT2", m3_NOT2.Trim());

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
