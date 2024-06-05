/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.AAS640MI;
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
	/// Name: AAS640MI
	/// Component Name: Electronic chart of account
	/// Description: Api : Electronic chart of account
	/// Version Release: 5e90
	///</summary>
	public partial class AAS640MIResource : M3BaseResourceEndpoint
	{
		public AAS640MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "AAS640MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name DelHeader
		/// Description DelHeader
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3JBNO">Job number (Required)</param>
		/// <param name="m3JBDT">Job date (Required)</param>
		/// <param name="m3JBTM">Job time (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelHeader(
			int m3JBNO, 
			DateTime m3JBDT, 
			int m3JBTM, 
			string m3DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelHeader",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("JBNO", m3JBNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBDT", m3JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3JBTM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

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
		/// Name GetHeader
		/// Description GetHeader
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3JBNO">Job number (Required)</param>
		/// <param name="m3JBDT">Job date (Required)</param>
		/// <param name="m3JBTM">Job time (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeaderResponse></returns>
		/// <exception cref="M3Exception<GetHeaderResponse>"></exception>
		public async Task<M3Response<GetHeaderResponse>> GetHeader(
			int m3JBNO, 
			DateTime m3JBDT, 
			int m3JBTM, 
			string m3DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHeader",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("JBNO", m3JBNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBDT", m3JBDT.ToM3String())
				.WithQueryParameter("JBTM", m3JBTM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<GetHeaderResponse>(
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
		/// Name UpdStatus
		/// Description UpdStatus
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3JBNO">Job number</param>
		/// <param name="m3JBDT">Job date</param>
		/// <param name="m3JBTM">Job time</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdStatus(
			string m3DIVI = null, 
			int? m3JBNO = null, 
			DateTime? m3JBDT = null, 
			int? m3JBTM = null, 
			string m3STAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdStatus",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3JBNO.HasValue)
				request.WithQueryParameter("JBNO", m3JBNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3JBDT.HasValue)
				request.WithQueryParameter("JBDT", m3JBDT.Value.ToM3String());
			if (m3JBTM.HasValue)
				request.WithQueryParameter("JBTM", m3JBTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());

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
