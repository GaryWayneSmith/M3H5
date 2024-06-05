/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.QUS118MI;
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
	/// Name: QUS118MI
	/// Component Name: Miscellaneous Costs
	/// Description: Api: Add Miscellaneous Costs
	/// Version Release: 5ea0
	///</summary>
	public partial class QUS118MIResource : M3BaseResourceEndpoint
	{
		public QUS118MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QUS118MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddMiscellaneou
		/// Description Add Miscellaneous Costs
		/// Version Release: 
		/// </summary>
		/// <param name="m3_QADD">Additions (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_CRID">Charge</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_DERE">Default record</param>
		/// <param name="m3_EXCL">Excluded</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddMiscellaneou(
			string m3_QADD, 
			string m3_TX40, 
			string m3_PRNO = null, 
			string m3_TX15 = null, 
			string m3_STAT = null, 
			string m3_RESP = null, 
			string m3_CRID = null, 
			string m3_ITNO = null, 
			string m3_ITDS = null, 
			int? m3_DERE = null, 
			int? m3_EXCL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddMiscellaneou",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_QADD))
				throw new ArgumentNullException("m3_QADD");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("QADD", m3_QADD.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CRID))
				request.WithQueryParameter("CRID", m3_CRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (m3_DERE.HasValue)
				request.WithQueryParameter("DERE", m3_DERE.Value.ToString());
			if (m3_EXCL.HasValue)
				request.WithQueryParameter("EXCL", m3_EXCL.Value.ToString());

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
		/// Name ChgMiscellaneou
		/// Description ChangeMiscellaneous Costs
		/// Version Release: 
		/// </summary>
		/// <param name="m3_QADD">Additions (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_CRID">Charge</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_DERE">Default record</param>
		/// <param name="m3_EXCL">Excluded</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgMiscellaneou(
			string m3_QADD, 
			string m3_PRNO = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_STAT = null, 
			string m3_RESP = null, 
			string m3_CRID = null, 
			string m3_ITNO = null, 
			string m3_ITDS = null, 
			int? m3_DERE = null, 
			int? m3_EXCL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgMiscellaneou",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_QADD))
				throw new ArgumentNullException("m3_QADD");

			// Set mandatory parameters
			request
				.WithQueryParameter("QADD", m3_QADD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CRID))
				request.WithQueryParameter("CRID", m3_CRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (m3_DERE.HasValue)
				request.WithQueryParameter("DERE", m3_DERE.Value.ToString());
			if (m3_EXCL.HasValue)
				request.WithQueryParameter("EXCL", m3_EXCL.Value.ToString());

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
		/// Name DltMiscellaneou
		/// Description Deletet Miscellaneous Costs
		/// Version Release: 
		/// </summary>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_QADD">Additions</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltMiscellaneou(
			string m3_PRNO = null, 
			string m3_QADD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltMiscellaneou",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QADD))
				request.WithQueryParameter("QADD", m3_QADD.Trim());

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
		/// Name GetMiscellaneou
		/// Description Get Miscellaneous Costs
		/// Version Release: 
		/// </summary>
		/// <param name="m3_QADD">Additions (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMiscellaneouResponse></returns>
		/// <exception cref="M3Exception<GetMiscellaneouResponse>"></exception>
		public async Task<M3Response<GetMiscellaneouResponse>> GetMiscellaneou(
			string m3_QADD, 
			string m3_PRNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMiscellaneou",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_QADD))
				throw new ArgumentNullException("m3_QADD");

			// Set mandatory parameters
			request
				.WithQueryParameter("QADD", m3_QADD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());

			// Execute the request
			var result = await Execute<GetMiscellaneouResponse>(
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
		/// Name LstMiscellaneou
		/// Description List Miscellaneous Costs
		/// Version Release: 
		/// </summary>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_QADD">Additions</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMiscellaneouResponse></returns>
		/// <exception cref="M3Exception<LstMiscellaneouResponse>"></exception>
		public async Task<M3Response<LstMiscellaneouResponse>> LstMiscellaneou(
			string m3_PRNO = null, 
			string m3_QADD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMiscellaneou",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QADD))
				request.WithQueryParameter("QADD", m3_QADD.Trim());

			// Execute the request
			var result = await Execute<LstMiscellaneouResponse>(
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
