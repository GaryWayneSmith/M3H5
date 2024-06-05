/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS128MI;
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
	/// Name: CRS128MI
	/// Component Name: Intrastat
	/// Description: Intrastat reporting
	/// Version Release: 5ea0
	///</summary>
	public partial class CRS128MIResource : M3BaseResourceEndpoint
	{
		public CRS128MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS128MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddBasicData
		/// Description Add Intrastat report data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CSNO">Customs statistical number (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_INYN">INTRASTAT generating</param>
		/// <param name="m3_SUPL">Supplementary U/M</param>
		/// <param name="m3_SPFA">Conversion factor supplementary U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBasicData(
			string m3_CSNO, 
			string m3_TX40, 
			string m3_TX15 = null, 
			int? m3_INYN = null, 
			string m3_SUPL = null, 
			decimal? m3_SPFA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CSNO))
				throw new ArgumentNullException("m3_CSNO");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("CSNO", m3_CSNO.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_INYN.HasValue)
				request.WithQueryParameter("INYN", m3_INYN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUPL))
				request.WithQueryParameter("SUPL", m3_SUPL.Trim());
			if (m3_SPFA.HasValue)
				request.WithQueryParameter("SPFA", m3_SPFA.Value.ToString());

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
		/// Name DltBasicData
		/// Description Delete Intrastat report data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CSNO">Customs statistical number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltBasicData(
			string m3_CSNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CSNO))
				throw new ArgumentNullException("m3_CSNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CSNO", m3_CSNO.Trim());

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
		/// Name GetBasicData
		/// Description Retrieve Intrastat report data
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CSNO">Customs statistical number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicDataResponse></returns>
		/// <exception cref="M3Exception<GetBasicDataResponse>"></exception>
		public async Task<M3Response<GetBasicDataResponse>> GetBasicData(
			int? m3_CONO = null, 
			string m3_CSNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBasicData",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CSNO))
				request.WithQueryParameter("CSNO", m3_CSNO.Trim());

			// Execute the request
			var result = await Execute<GetBasicDataResponse>(
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
		/// Name LstByNumber
		/// Description List Intrastat report data by cust stat number
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CSNO">Customs statistical number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByNumberResponse></returns>
		/// <exception cref="M3Exception<LstByNumberResponse>"></exception>
		public async Task<M3Response<LstByNumberResponse>> LstByNumber(
			int? m3_CONO = null, 
			string m3_CSNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByNumber",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CSNO))
				request.WithQueryParameter("CSNO", m3_CSNO.Trim());

			// Execute the request
			var result = await Execute<LstByNumberResponse>(
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
		/// Name UpdBasicData
		/// Description Update Intrastat report data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CSNO">Customs statistical number (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_INYN">INTRASTAT generating</param>
		/// <param name="m3_SUPL">Supplementary U/M</param>
		/// <param name="m3_SPFA">Conversion factor supplementary U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdBasicData(
			string m3_CSNO, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			int? m3_INYN = null, 
			string m3_SUPL = null, 
			decimal? m3_SPFA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CSNO))
				throw new ArgumentNullException("m3_CSNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CSNO", m3_CSNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_INYN.HasValue)
				request.WithQueryParameter("INYN", m3_INYN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUPL))
				request.WithQueryParameter("SUPL", m3_SUPL.Trim());
			if (m3_SPFA.HasValue)
				request.WithQueryParameter("SPFA", m3_SPFA.Value.ToString());

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
