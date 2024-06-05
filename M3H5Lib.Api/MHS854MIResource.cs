/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddSublot
		/// Description AddSublot
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3PACN">Package number (Required)</param>
		/// <param name="m3MSLN">Message line number (Required)</param>
		/// <param name="m3SUBL">Subline number (Required)</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3BANT">Reference sublot ID</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3QLFR">Qualifier</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSublot(
			string m3MSGN, 
			string m3PACN, 
			int m3MSLN, 
			int m3SUBL, 
			string m3BANO = null, 
			string m3BANT = null, 
			string m3ITNO = null, 
			decimal? m3CAWE = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3QLFR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddSublot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));
			if (string.IsNullOrWhiteSpace(m3PACN))
				throw new ArgumentNullException(nameof(m3PACN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim())
				.WithQueryParameter("PACN", m3PACN.Trim())
				.WithQueryParameter("MSLN", m3MSLN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SUBL", m3SUBL.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANT))
				request.WithQueryParameter("BANT", m3BANT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QLFR))
				request.WithQueryParameter("QLFR", m3QLFR.Trim());

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
		/// Name DltSublot
		/// Description DltSublot
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3PACN">Package number (Required)</param>
		/// <param name="m3MSLN">Message line number (Required)</param>
		/// <param name="m3SUBL">Subline number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltSublot(
			string m3MSGN, 
			string m3PACN, 
			int m3MSLN, 
			int m3SUBL, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltSublot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));
			if (string.IsNullOrWhiteSpace(m3PACN))
				throw new ArgumentNullException(nameof(m3PACN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim())
				.WithQueryParameter("PACN", m3PACN.Trim())
				.WithQueryParameter("MSLN", m3MSLN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SUBL", m3SUBL.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetSublot
		/// Description GetSublot
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3PACN">Package number (Required)</param>
		/// <param name="m3MSLN">Message line number (Required)</param>
		/// <param name="m3SUBL">Subline number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSublotResponse></returns>
		/// <exception cref="M3Exception<GetSublotResponse>"></exception>
		public async Task<M3Response<GetSublotResponse>> GetSublot(
			string m3MSGN, 
			string m3PACN, 
			int m3MSLN, 
			int m3SUBL, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetSublot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));
			if (string.IsNullOrWhiteSpace(m3PACN))
				throw new ArgumentNullException(nameof(m3PACN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim())
				.WithQueryParameter("PACN", m3PACN.Trim())
				.WithQueryParameter("MSLN", m3MSLN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SUBL", m3SUBL.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetSublotResponse>(
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
		/// Name LstSublots
		/// Description LstSublots
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3MSLN">Message line number</param>
		/// <param name="m3SUBL">Subline number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSublotsResponse></returns>
		/// <exception cref="M3Exception<LstSublotsResponse>"></exception>
		public async Task<M3Response<LstSublotsResponse>> LstSublots(
			string m3MSGN = null, 
			string m3PACN = null, 
			int? m3MSLN = null, 
			int? m3SUBL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstSublots",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (m3MSLN.HasValue)
				request.WithQueryParameter("MSLN", m3MSLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUBL.HasValue)
				request.WithQueryParameter("SUBL", m3SUBL.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstSublotsResponse>(
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
		/// Name SetCurrentDate
		/// Description Sets the date of the record(s) to todays date
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3PACN">Package number (Required)</param>
		/// <param name="m3MSLN">Message line number (Required)</param>
		/// <param name="m3SUBL">Subline number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SetCurrentDateResponse></returns>
		/// <exception cref="M3Exception<SetCurrentDateResponse>"></exception>
		public async Task<M3Response<SetCurrentDateResponse>> SetCurrentDate(
			string m3MSGN, 
			string m3PACN, 
			int m3MSLN, 
			int m3SUBL, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SetCurrentDate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));
			if (string.IsNullOrWhiteSpace(m3PACN))
				throw new ArgumentNullException(nameof(m3PACN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim())
				.WithQueryParameter("PACN", m3PACN.Trim())
				.WithQueryParameter("MSLN", m3MSLN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SUBL", m3SUBL.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SetCurrentDateResponse>(
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
		/// Name UpdSublot
		/// Description UpdSublot
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3PACN">Package number (Required)</param>
		/// <param name="m3MSLN">Message line number (Required)</param>
		/// <param name="m3SUBL">Subline number (Required)</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3BANT">Reference sublot ID</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3QLFR">Qualifier</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSublot(
			string m3MSGN, 
			string m3PACN, 
			int m3MSLN, 
			int m3SUBL, 
			string m3BANO = null, 
			string m3BANT = null, 
			string m3ITNO = null, 
			decimal? m3CAWE = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			string m3QLFR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdSublot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));
			if (string.IsNullOrWhiteSpace(m3PACN))
				throw new ArgumentNullException(nameof(m3PACN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim())
				.WithQueryParameter("PACN", m3PACN.Trim())
				.WithQueryParameter("MSLN", m3MSLN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SUBL", m3SUBL.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANT))
				request.WithQueryParameter("BANT", m3BANT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QLFR))
				request.WithQueryParameter("QLFR", m3QLFR.Trim());

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
