/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MHS854MI;
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
	/// Name: MHS854MI
	/// Component Name: SubLine
	/// Description: SubLine  interface
	/// Version Release: 5ea0
	///</summary>
	public partial class MHS854MIResource : M3BaseResourceEndpoint
	{
		public MHS854MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MHS854MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddSublot
		/// Description AddSublot
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_PACN">Package number (Required)</param>
		/// <param name="m3_MSLN">Message line number (Required)</param>
		/// <param name="m3_SUBL">Subline number (Required)</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_BANT">Reference sublot ID</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_QLFR">Qualifier</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSublot(
			string m3_MSGN, 
			string m3_PACN, 
			int m3_MSLN, 
			int m3_SUBL, 
			string m3_BANO = null, 
			string m3_BANT = null, 
			string m3_ITNO = null, 
			decimal? m3_CAWE = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_QLFR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSublot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");
			if (string.IsNullOrWhiteSpace(m3_PACN))
				throw new ArgumentNullException("m3_PACN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim())
				.WithQueryParameter("PACN", m3_PACN.Trim())
				.WithQueryParameter("MSLN", m3_MSLN.ToString())
				.WithQueryParameter("SUBL", m3_SUBL.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANT))
				request.WithQueryParameter("BANT", m3_BANT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QLFR))
				request.WithQueryParameter("QLFR", m3_QLFR.Trim());

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
		/// Name DltSublot
		/// Description DltSublot
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_PACN">Package number (Required)</param>
		/// <param name="m3_MSLN">Message line number (Required)</param>
		/// <param name="m3_SUBL">Subline number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltSublot(
			string m3_MSGN, 
			string m3_PACN, 
			int m3_MSLN, 
			int m3_SUBL, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltSublot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");
			if (string.IsNullOrWhiteSpace(m3_PACN))
				throw new ArgumentNullException("m3_PACN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim())
				.WithQueryParameter("PACN", m3_PACN.Trim())
				.WithQueryParameter("MSLN", m3_MSLN.ToString())
				.WithQueryParameter("SUBL", m3_SUBL.ToString());

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
		/// Name GetSublot
		/// Description GetSublot
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_PACN">Package number (Required)</param>
		/// <param name="m3_MSLN">Message line number (Required)</param>
		/// <param name="m3_SUBL">Subline number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSublotResponse></returns>
		/// <exception cref="M3Exception<GetSublotResponse>"></exception>
		public async Task<M3Response<GetSublotResponse>> GetSublot(
			string m3_MSGN, 
			string m3_PACN, 
			int m3_MSLN, 
			int m3_SUBL, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSublot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");
			if (string.IsNullOrWhiteSpace(m3_PACN))
				throw new ArgumentNullException("m3_PACN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim())
				.WithQueryParameter("PACN", m3_PACN.Trim())
				.WithQueryParameter("MSLN", m3_MSLN.ToString())
				.WithQueryParameter("SUBL", m3_SUBL.ToString());

			// Execute the request
			var result = await Execute<GetSublotResponse>(
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
		/// Name LstSublots
		/// Description LstSublots
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_MSLN">Message line number</param>
		/// <param name="m3_SUBL">Subline number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSublotsResponse></returns>
		/// <exception cref="M3Exception<LstSublotsResponse>"></exception>
		public async Task<M3Response<LstSublotsResponse>> LstSublots(
			string m3_MSGN = null, 
			string m3_PACN = null, 
			int? m3_MSLN = null, 
			int? m3_SUBL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSublots",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (m3_MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3_MSLN.Value.ToString());
			if (m3_SUBL.HasValue)
				request.WithQueryParameter("SUBL", m3_SUBL.Value.ToString());

			// Execute the request
			var result = await Execute<LstSublotsResponse>(
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
		/// Name SetCurrentDate
		/// Description Sets the date of the record(s) to todays date
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_PACN">Package number (Required)</param>
		/// <param name="m3_MSLN">Message line number (Required)</param>
		/// <param name="m3_SUBL">Subline number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SetCurrentDateResponse></returns>
		/// <exception cref="M3Exception<SetCurrentDateResponse>"></exception>
		public async Task<M3Response<SetCurrentDateResponse>> SetCurrentDate(
			string m3_MSGN, 
			string m3_PACN, 
			int m3_MSLN, 
			int m3_SUBL, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SetCurrentDate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");
			if (string.IsNullOrWhiteSpace(m3_PACN))
				throw new ArgumentNullException("m3_PACN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim())
				.WithQueryParameter("PACN", m3_PACN.Trim())
				.WithQueryParameter("MSLN", m3_MSLN.ToString())
				.WithQueryParameter("SUBL", m3_SUBL.ToString());

			// Execute the request
			var result = await Execute<SetCurrentDateResponse>(
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
		/// Name UpdSublot
		/// Description UpdSublot
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_PACN">Package number (Required)</param>
		/// <param name="m3_MSLN">Message line number (Required)</param>
		/// <param name="m3_SUBL">Subline number (Required)</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_BANT">Reference sublot ID</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_QLFR">Qualifier</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSublot(
			string m3_MSGN, 
			string m3_PACN, 
			int m3_MSLN, 
			int m3_SUBL, 
			string m3_BANO = null, 
			string m3_BANT = null, 
			string m3_ITNO = null, 
			decimal? m3_CAWE = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			string m3_QLFR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdSublot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");
			if (string.IsNullOrWhiteSpace(m3_PACN))
				throw new ArgumentNullException("m3_PACN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim())
				.WithQueryParameter("PACN", m3_PACN.Trim())
				.WithQueryParameter("MSLN", m3_MSLN.ToString())
				.WithQueryParameter("SUBL", m3_SUBL.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANT))
				request.WithQueryParameter("BANT", m3_BANT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QLFR))
				request.WithQueryParameter("QLFR", m3_QLFR.Trim());

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
