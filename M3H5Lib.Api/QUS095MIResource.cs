/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
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
	/// Name: QUS095MI
	/// Component Name: EQMStatus
	/// Description: EQM Status handling
	/// Version Release: 
	///</summary>
	public partial class QUS095MIResource : M3BaseResourceEndpoint
	{
		public QUS095MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QUS095MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ApproveHead
		/// Description Approve a complete quotation
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3OFNO">Quotation number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ApproveHead(
			string m3OFNO, 
			int m3VERS, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ApproveHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3OFNO))
				throw new ArgumentNullException(nameof(m3OFNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("OFNO", m3OFNO.Trim())
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture));

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
		/// Name ApproveLine
		/// Description Approve line
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3OFNO">Quotation number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3PONR">Order line number (Required)</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ApproveLine(
			string m3OFNO, 
			int m3VERS, 
			int m3PONR, 
			int? m3POSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ApproveLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3OFNO))
				throw new ArgumentNullException(nameof(m3OFNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("OFNO", m3OFNO.Trim())
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChangeQuoteSts
		/// Description Change quotation status
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3OFNO">Quotation number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3STAT">Status (Required)</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3DSP2">Flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChangeQuoteSts(
			string m3OFNO, 
			int m3VERS, 
			string m3STAT, 
			string m3RSCD = null, 
			int? m3DSP2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChangeQuoteSts",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3OFNO))
				throw new ArgumentNullException(nameof(m3OFNO));
			if (string.IsNullOrWhiteSpace(m3STAT))
				throw new ArgumentNullException(nameof(m3STAT));

			// Set mandatory parameters
			request
				.WithQueryParameter("OFNO", m3OFNO.Trim())
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STAT", m3STAT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (m3DSP2.HasValue)
				request.WithQueryParameter("DSP2", m3DSP2.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ReadyLine
		/// Description Set line in a ready state
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3OFNO">Quotation number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3PONR">Order line number (Required)</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ReadyLine(
			string m3OFNO, 
			int m3VERS, 
			int m3PONR, 
			int? m3POSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ReadyLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3OFNO))
				throw new ArgumentNullException(nameof(m3OFNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("OFNO", m3OFNO.Trim())
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name RejectHead
		/// Description Reject a complete quotation
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3OFNO">Quotation number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3TX01">Text</param>
		/// <param name="m3TX02">Text</param>
		/// <param name="m3TX03">Text</param>
		/// <param name="m3TX04">Text</param>
		/// <param name="m3TX05">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RejectHead(
			string m3OFNO, 
			int m3VERS, 
			string m3TX01 = null, 
			string m3TX02 = null, 
			string m3TX03 = null, 
			string m3TX04 = null, 
			string m3TX05 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RejectHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3OFNO))
				throw new ArgumentNullException(nameof(m3OFNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("OFNO", m3OFNO.Trim())
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX01))
				request.WithQueryParameter("TX01", m3TX01.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX02))
				request.WithQueryParameter("TX02", m3TX02.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX03))
				request.WithQueryParameter("TX03", m3TX03.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX04))
				request.WithQueryParameter("TX04", m3TX04.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX05))
				request.WithQueryParameter("TX05", m3TX05.Trim());

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
		/// Name RejectLine
		/// Description Reject a single quotation line
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3OFNO">Quotation number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3PONR">Order line number (Required)</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3TX01">Text</param>
		/// <param name="m3TX02">Text</param>
		/// <param name="m3TX03">Text</param>
		/// <param name="m3TX04">Text</param>
		/// <param name="m3TX05">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RejectLine(
			string m3OFNO, 
			int m3VERS, 
			int m3PONR, 
			int? m3POSX = null, 
			string m3TX01 = null, 
			string m3TX02 = null, 
			string m3TX03 = null, 
			string m3TX04 = null, 
			string m3TX05 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RejectLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3OFNO))
				throw new ArgumentNullException(nameof(m3OFNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("OFNO", m3OFNO.Trim())
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX01))
				request.WithQueryParameter("TX01", m3TX01.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX02))
				request.WithQueryParameter("TX02", m3TX02.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX03))
				request.WithQueryParameter("TX03", m3TX03.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX04))
				request.WithQueryParameter("TX04", m3TX04.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX05))
				request.WithQueryParameter("TX05", m3TX05.Trim());

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
