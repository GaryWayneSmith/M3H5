/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add new limit for a scaled promotion
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3PIDE">Promotion</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3LIMT">Limit value</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3DISP">Discount percentage</param>
		/// <param name="m3DIAM">Discount amount</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3ITNR">Item number</param>
		/// <param name="m3ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3SAPX">Sales price</param>
		/// <param name="m3SCLA">SPA claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3DIVI = null, 
			string m3PIDE = null, 
			string m3ITNO = null, 
			decimal? m3LIMT = null, 
			decimal? m3SAPR = null, 
			int? m3DISP = null, 
			decimal? m3DIAM = null, 
			string m3TEPY = null, 
			string m3ITNR = null, 
			decimal? m3ORQT = null, 
			decimal? m3SAPX = null, 
			decimal? m3SCLA = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PIDE))
				request.WithQueryParameter("PIDE", m3PIDE.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3LIMT.HasValue)
				request.WithQueryParameter("LIMT", m3LIMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DISP.HasValue)
				request.WithQueryParameter("DISP", m3DISP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIAM.HasValue)
				request.WithQueryParameter("DIAM", m3DIAM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNR))
				request.WithQueryParameter("ITNR", m3ITNR.Trim());
			if (m3ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3ORQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAPX.HasValue)
				request.WithQueryParameter("SAPX", m3SAPX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCLA.HasValue)
				request.WithQueryParameter("SCLA", m3SCLA.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Change
		/// Description Change limit for a scaled promotion
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3PIDE">Promotion</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3LIMT">Limit value</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3DISP">Discount percentage</param>
		/// <param name="m3DIAM">Discount amount</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3ITNR">Item number</param>
		/// <param name="m3ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3SAPX">Sales price</param>
		/// <param name="m3SCLA">SPA claim</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Change(
			string m3DIVI = null, 
			string m3PIDE = null, 
			string m3ITNO = null, 
			decimal? m3LIMT = null, 
			decimal? m3SAPR = null, 
			int? m3DISP = null, 
			decimal? m3DIAM = null, 
			string m3TEPY = null, 
			string m3ITNR = null, 
			decimal? m3ORQT = null, 
			decimal? m3SAPX = null, 
			decimal? m3SCLA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Change",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PIDE))
				request.WithQueryParameter("PIDE", m3PIDE.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3LIMT.HasValue)
				request.WithQueryParameter("LIMT", m3LIMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DISP.HasValue)
				request.WithQueryParameter("DISP", m3DISP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIAM.HasValue)
				request.WithQueryParameter("DIAM", m3DIAM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNR))
				request.WithQueryParameter("ITNR", m3ITNR.Trim());
			if (m3ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3ORQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAPX.HasValue)
				request.WithQueryParameter("SAPX", m3SAPX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCLA.HasValue)
				request.WithQueryParameter("SCLA", m3SCLA.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Delet
		/// Description Delete limit for a scaled promotion
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3PIDE">Promotion</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3LIMT">Limit value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delet(
			string m3DIVI = null, 
			string m3PIDE = null, 
			string m3ITNO = null, 
			decimal? m3LIMT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Delet",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PIDE))
				request.WithQueryParameter("PIDE", m3PIDE.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3LIMT.HasValue)
				request.WithQueryParameter("LIMT", m3LIMT.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Description List all limit records for a scaled promotion
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3PIDE">Promotion</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3DIVI = null, 
			string m3PIDE = null, 
			string m3ITNO = null, 
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
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PIDE))
				request.WithQueryParameter("PIDE", m3PIDE.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());

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
	}
}
// EOF
