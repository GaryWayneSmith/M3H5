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
	/// Name: STS106MI
	/// Component Name: STRAgreements
	/// Description: API: STR Agreement - Contact person
	/// Version Release: 5e90
	///</summary>
	public partial class STS106MIResource : M3BaseResourceEndpoint
	{
		public STS106MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "STS106MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddCalcRPO
		/// Description AddCalcRPO
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3PONR">Order line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="m3NOPR">Number of periods (Required)</param>
		/// <param name="m3INTT">Interest type (Required)</param>
		/// <param name="m3REPE">Residual percent (Required)</param>
		/// <param name="m3INPE">Interest rate</param>
		/// <param name="m3RESV">Residual value</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3RECH">Rental charges</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCalcRPO(
			string m3AGNB, 
			int m3VERS, 
			int m3PONR, 
			int m3POSX, 
			int m3NOPR, 
			string m3INTT, 
			int m3REPE, 
			decimal? m3INPE = null, 
			decimal? m3RESV = null, 
			decimal? m3SAPR = null, 
			decimal? m3RECH = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCalcRPO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));
			if (string.IsNullOrWhiteSpace(m3INTT))
				throw new ArgumentNullException(nameof(m3INTT));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("POSX", m3POSX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("NOPR", m3NOPR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("INTT", m3INTT.Trim())
				.WithQueryParameter("REPE", m3REPE.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3INPE.HasValue)
				request.WithQueryParameter("INPE", m3INPE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RESV.HasValue)
				request.WithQueryParameter("RESV", m3RESV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RECH.HasValue)
				request.WithQueryParameter("RECH", m3RECH.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelRPO
		/// Description DelRPO
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3PONR">Order line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelRPO(
			string m3AGNB, 
			int m3VERS, 
			int m3PONR, 
			int m3POSX, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelRPO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("POSX", m3POSX.ToString(CultureInfo.CurrentCulture));

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
