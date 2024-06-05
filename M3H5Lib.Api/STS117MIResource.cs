/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.STS117MI;
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
	/// Name: STS117MI
	/// Component Name: RentalAgreements
	/// Description: API: Rental agreement line charges
	/// Version Release: 14.x
	///</summary>
	public partial class STS117MIResource : M3BaseResourceEndpoint
	{
		public STS117MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "STS117MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddLineChrg
		/// Description Add Line Charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_CRID">Charge (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CRAM">Charge</param>
		/// <param name="m3_CRFA">Calculation factor</param>
		/// <param name="m3_CRD0">Description language 0</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLineChrg(
			string m3_AGNB, 
			int m3_VERS, 
			int m3_PONR, 
			int m3_POSX, 
			string m3_CRID, 
			int? m3_CONO = null, 
			decimal? m3_CRAM = null, 
			decimal? m3_CRFA = null, 
			string m3_CRD0 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLineChrg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_CRID))
				throw new ArgumentNullException("m3_CRID");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString())
				.WithQueryParameter("CRID", m3_CRID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_CRAM.HasValue)
				request.WithQueryParameter("CRAM", m3_CRAM.Value.ToString());
			if (m3_CRFA.HasValue)
				request.WithQueryParameter("CRFA", m3_CRFA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CRD0))
				request.WithQueryParameter("CRD0", m3_CRD0.Trim());

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
		/// Name ChgLineChrg
		/// Description Change Line Charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_CRID">Charge (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CRAM">Charge</param>
		/// <param name="m3_CRFA">Calculation factor</param>
		/// <param name="m3_CRD0">Description language 0</param>
		/// <param name="m3_HACD">Debit frequency</param>
		/// <param name="m3_CHST">Status - charge</param>
		/// <param name="m3_CHPR">Presentation code - item charges</param>
		/// <param name="m3_VTCD">VAT code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgLineChrg(
			string m3_AGNB, 
			int m3_VERS, 
			int m3_PONR, 
			int m3_POSX, 
			string m3_CRID, 
			int? m3_CONO = null, 
			decimal? m3_CRAM = null, 
			decimal? m3_CRFA = null, 
			string m3_CRD0 = null, 
			int? m3_HACD = null, 
			string m3_CHST = null, 
			int? m3_CHPR = null, 
			int? m3_VTCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgLineChrg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_CRID))
				throw new ArgumentNullException("m3_CRID");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString())
				.WithQueryParameter("CRID", m3_CRID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_CRAM.HasValue)
				request.WithQueryParameter("CRAM", m3_CRAM.Value.ToString());
			if (m3_CRFA.HasValue)
				request.WithQueryParameter("CRFA", m3_CRFA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CRD0))
				request.WithQueryParameter("CRD0", m3_CRD0.Trim());
			if (m3_HACD.HasValue)
				request.WithQueryParameter("HACD", m3_HACD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHST))
				request.WithQueryParameter("CHST", m3_CHST.Trim());
			if (m3_CHPR.HasValue)
				request.WithQueryParameter("CHPR", m3_CHPR.Value.ToString());
			if (m3_VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3_VTCD.Value.ToString());

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
		/// Name DelLineChrg
		/// Description Delete Line Charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_CRID">Charge (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelLineChrg(
			string m3_AGNB, 
			int m3_VERS, 
			int m3_PONR, 
			int m3_POSX, 
			string m3_CRID, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelLineChrg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_CRID))
				throw new ArgumentNullException("m3_CRID");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString())
				.WithQueryParameter("CRID", m3_CRID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name GetLineChrg
		/// Description Get Line Charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_CRID">Charge (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLineChrgResponse></returns>
		/// <exception cref="M3Exception<GetLineChrgResponse>"></exception>
		public async Task<M3Response<GetLineChrgResponse>> GetLineChrg(
			string m3_AGNB, 
			int m3_VERS, 
			int m3_PONR, 
			int m3_POSX, 
			string m3_CRID, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetLineChrg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_CRID))
				throw new ArgumentNullException("m3_CRID");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString())
				.WithQueryParameter("CRID", m3_CRID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetLineChrgResponse>(
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
		/// Name LstLineChrg
		/// Description List Line Charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CRID">Charge</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineChrgResponse></returns>
		/// <exception cref="M3Exception<LstLineChrgResponse>"></exception>
		public async Task<M3Response<LstLineChrgResponse>> LstLineChrg(
			string m3_AGNB, 
			int m3_VERS, 
			int m3_PONR, 
			int m3_POSX, 
			int? m3_CONO = null, 
			string m3_CRID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLineChrg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CRID))
				request.WithQueryParameter("CRID", m3_CRID.Trim());

			// Execute the request
			var result = await Execute<LstLineChrgResponse>(
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