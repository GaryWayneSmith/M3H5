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
	/// Name: PDS071MI
	/// Component Name: Feature Distribute Option
	/// Description: Api: Feature Distribute Option
	/// Version Release: 14.x
	///</summary>
	public partial class PDS071MIResource : M3BaseResourceEndpoint
	{
		public PDS071MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PDS071MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name FeatDistOpChk
		/// Description Feature Distribution Option Check
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3CURV">Distribution template (Required)</param>
		/// <param name="m3FTID">Feature (Required)</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> FeatDistOpChk(
			string m3CURV, 
			string m3FTID, 
			string m3FACI = null, 
			string m3WHLO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/FeatDistOpChk",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CURV))
				throw new ArgumentNullException(nameof(m3CURV));
			if (string.IsNullOrWhiteSpace(m3FTID))
				throw new ArgumentNullException(nameof(m3FTID));

			// Set mandatory parameters
			request
				.WithQueryParameter("CURV", m3CURV.Trim())
				.WithQueryParameter("FTID", m3FTID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());

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
		/// Name FeatDistOpUpd
		/// Description Feature Distribution Option Update
		/// Version Release: 14.
		/// </summary>
		/// <param name="m3CURV">Distribution template (Required)</param>
		/// <param name="m3FTID">Feature (Required)</param>
		/// <param name="m3OPTN">Option (Required)</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3SHAR">Percentage</param>
		/// <param name="m3BQ10">Ref field for base quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> FeatDistOpUpd(
			string m3CURV, 
			string m3FTID, 
			string m3OPTN, 
			string m3FACI = null, 
			string m3WHLO = null, 
			int? m3SHAR = null, 
			long? m3BQ10 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/FeatDistOpUpd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CURV))
				throw new ArgumentNullException(nameof(m3CURV));
			if (string.IsNullOrWhiteSpace(m3FTID))
				throw new ArgumentNullException(nameof(m3FTID));
			if (string.IsNullOrWhiteSpace(m3OPTN))
				throw new ArgumentNullException(nameof(m3OPTN));

			// Set mandatory parameters
			request
				.WithQueryParameter("CURV", m3CURV.Trim())
				.WithQueryParameter("FTID", m3FTID.Trim())
				.WithQueryParameter("OPTN", m3OPTN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3SHAR.HasValue)
				request.WithQueryParameter("SHAR", m3SHAR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BQ10.HasValue)
				request.WithQueryParameter("BQ10", m3BQ10.Value.ToString(CultureInfo.CurrentCulture));

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
