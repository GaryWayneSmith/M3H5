/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.OIS847MI;
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
	/// Name: OIS847MI
	/// Component Name: Promotion Enter Scaled Prices
	/// Description: API: Promotion Enter Scaled Prices
	/// Version Release: 14.x
	///</summary>
	public partial class OIS847MIResource : M3BaseResourceEndpoint
	{
		public OIS847MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS847MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add new limit for a scaled promotion
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_PIDE">Promotion</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_LIMT">Limit value</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_DISP">Discount percentage</param>
		/// <param name="m3_DIAM">Discount amount</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_ITNR">Item number</param>
		/// <param name="m3_ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3_SAPX">Sales price</param>
		/// <param name="m3_SCLA">SPA claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_DIVI = null, 
			string m3_PIDE = null, 
			string m3_ITNO = null, 
			decimal? m3_LIMT = null, 
			decimal? m3_SAPR = null, 
			int? m3_DISP = null, 
			decimal? m3_DIAM = null, 
			string m3_TEPY = null, 
			string m3_ITNR = null, 
			decimal? m3_ORQT = null, 
			decimal? m3_SAPX = null, 
			decimal? m3_SCLA = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PIDE))
				request.WithQueryParameter("PIDE", m3_PIDE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_LIMT.HasValue)
				request.WithQueryParameter("LIMT", m3_LIMT.Value.ToString());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_DISP.HasValue)
				request.WithQueryParameter("DISP", m3_DISP.Value.ToString());
			if (m3_DIAM.HasValue)
				request.WithQueryParameter("DIAM", m3_DIAM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNR))
				request.WithQueryParameter("ITNR", m3_ITNR.Trim());
			if (m3_ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3_ORQT.Value.ToString());
			if (m3_SAPX.HasValue)
				request.WithQueryParameter("SAPX", m3_SAPX.Value.ToString());
			if (m3_SCLA.HasValue)
				request.WithQueryParameter("SCLA", m3_SCLA.Value.ToString());

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
		/// Name Change
		/// Description Change limit for a scaled promotion
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_PIDE">Promotion</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_LIMT">Limit value</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_DISP">Discount percentage</param>
		/// <param name="m3_DIAM">Discount amount</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_ITNR">Item number</param>
		/// <param name="m3_ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3_SAPX">Sales price</param>
		/// <param name="m3_SCLA">SPA claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Change(
			string m3_DIVI = null, 
			string m3_PIDE = null, 
			string m3_ITNO = null, 
			decimal? m3_LIMT = null, 
			decimal? m3_SAPR = null, 
			int? m3_DISP = null, 
			decimal? m3_DIAM = null, 
			string m3_TEPY = null, 
			string m3_ITNR = null, 
			decimal? m3_ORQT = null, 
			decimal? m3_SAPX = null, 
			decimal? m3_SCLA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Change",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PIDE))
				request.WithQueryParameter("PIDE", m3_PIDE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_LIMT.HasValue)
				request.WithQueryParameter("LIMT", m3_LIMT.Value.ToString());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_DISP.HasValue)
				request.WithQueryParameter("DISP", m3_DISP.Value.ToString());
			if (m3_DIAM.HasValue)
				request.WithQueryParameter("DIAM", m3_DIAM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNR))
				request.WithQueryParameter("ITNR", m3_ITNR.Trim());
			if (m3_ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3_ORQT.Value.ToString());
			if (m3_SAPX.HasValue)
				request.WithQueryParameter("SAPX", m3_SAPX.Value.ToString());
			if (m3_SCLA.HasValue)
				request.WithQueryParameter("SCLA", m3_SCLA.Value.ToString());

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
		/// Name Delet
		/// Description Delete limit for a scaled promotion
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_PIDE">Promotion</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_LIMT">Limit value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delet(
			string m3_DIVI = null, 
			string m3_PIDE = null, 
			string m3_ITNO = null, 
			decimal? m3_LIMT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Delet",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PIDE))
				request.WithQueryParameter("PIDE", m3_PIDE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_LIMT.HasValue)
				request.WithQueryParameter("LIMT", m3_LIMT.Value.ToString());

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
		/// Name List
		/// Description List all limit records for a scaled promotion
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_PIDE">Promotion</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3_DIVI = null, 
			string m3_PIDE = null, 
			string m3_ITNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/List",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PIDE))
				request.WithQueryParameter("PIDE", m3_PIDE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<ListResponse>(
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
