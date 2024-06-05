/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddMiscellaneou
		/// Description Add Miscellaneous Costs
		/// Version Release: 
		/// </summary>
		/// <param name="m3QADD">Additions (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3CRID">Charge</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3DERE">Default record</param>
		/// <param name="m3EXCL">Excluded</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddMiscellaneou(
			string m3QADD, 
			string m3TX40, 
			string m3PRNO = null, 
			string m3TX15 = null, 
			string m3STAT = null, 
			string m3RESP = null, 
			string m3CRID = null, 
			string m3ITNO = null, 
			string m3ITDS = null, 
			int? m3DERE = null, 
			int? m3EXCL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddMiscellaneou",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3QADD))
				throw new ArgumentNullException(nameof(m3QADD));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("QADD", m3QADD.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CRID))
				request.WithQueryParameter("CRID", m3CRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (m3DERE.HasValue)
				request.WithQueryParameter("DERE", m3DERE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXCL.HasValue)
				request.WithQueryParameter("EXCL", m3EXCL.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgMiscellaneou
		/// Description ChangeMiscellaneous Costs
		/// Version Release: 
		/// </summary>
		/// <param name="m3QADD">Additions (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3CRID">Charge</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3DERE">Default record</param>
		/// <param name="m3EXCL">Excluded</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgMiscellaneou(
			string m3QADD, 
			string m3PRNO = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3STAT = null, 
			string m3RESP = null, 
			string m3CRID = null, 
			string m3ITNO = null, 
			string m3ITDS = null, 
			int? m3DERE = null, 
			int? m3EXCL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgMiscellaneou",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3QADD))
				throw new ArgumentNullException(nameof(m3QADD));

			// Set mandatory parameters
			request
				.WithQueryParameter("QADD", m3QADD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CRID))
				request.WithQueryParameter("CRID", m3CRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (m3DERE.HasValue)
				request.WithQueryParameter("DERE", m3DERE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXCL.HasValue)
				request.WithQueryParameter("EXCL", m3EXCL.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltMiscellaneou
		/// Description Deletet Miscellaneous Costs
		/// Version Release: 
		/// </summary>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3QADD">Additions</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltMiscellaneou(
			string m3PRNO = null, 
			string m3QADD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltMiscellaneou",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QADD))
				request.WithQueryParameter("QADD", m3QADD.Trim());

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
		/// Name GetMiscellaneou
		/// Description Get Miscellaneous Costs
		/// Version Release: 
		/// </summary>
		/// <param name="m3QADD">Additions (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMiscellaneouResponse></returns>
		/// <exception cref="M3Exception<GetMiscellaneouResponse>"></exception>
		public async Task<M3Response<GetMiscellaneouResponse>> GetMiscellaneou(
			string m3QADD, 
			string m3PRNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetMiscellaneou",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3QADD))
				throw new ArgumentNullException(nameof(m3QADD));

			// Set mandatory parameters
			request
				.WithQueryParameter("QADD", m3QADD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());

			// Execute the request
			var result = await Execute<GetMiscellaneouResponse>(
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
		/// Name LstMiscellaneou
		/// Description List Miscellaneous Costs
		/// Version Release: 
		/// </summary>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3QADD">Additions</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMiscellaneouResponse></returns>
		/// <exception cref="M3Exception<LstMiscellaneouResponse>"></exception>
		public async Task<M3Response<LstMiscellaneouResponse>> LstMiscellaneou(
			string m3PRNO = null, 
			string m3QADD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMiscellaneou",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QADD))
				request.WithQueryParameter("QADD", m3QADD.Trim());

			// Execute the request
			var result = await Execute<LstMiscellaneouResponse>(
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
