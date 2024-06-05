/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.STS103MI;
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
	/// Name: STS103MI
	/// Component Name: STRAgreementAdditionalCharges
	/// Description: API: Additional charges (STR)
	/// Version Release: 14.x
	///</summary>
	public partial class STS103MIResource : M3BaseResourceEndpoint
	{
		public STS103MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "STS103MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAddChrg
		/// Description Add Additional Charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_RTYP">Record type (Required)</param>
		/// <param name="m3_AGRS">Contract item (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CHRG">Charge</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_COQT">Material usage</param>
		/// <param name="m3_CIQT">Material usage</param>
		/// <param name="m3_UNMS">Basic unit of measure</param>
		/// <param name="m3_ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_ADPW">Days per week</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAddChrg(
			string m3_AGNB, 
			int m3_VERS, 
			int m3_PONR, 
			int m3_POSX, 
			string m3_RTYP, 
			string m3_AGRS, 
			int? m3_CONO = null, 
			decimal? m3_CHRG = null, 
			string m3_ITDS = null, 
			string m3_PYNO = null, 
			decimal? m3_COQT = null, 
			decimal? m3_CIQT = null, 
			string m3_UNMS = null, 
			decimal? m3_ORQT = null, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_LVDT = null, 
			int? m3_ADPW = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAddChrg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_RTYP))
				throw new ArgumentNullException("m3_RTYP");
			if (string.IsNullOrWhiteSpace(m3_AGRS))
				throw new ArgumentNullException("m3_AGRS");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString())
				.WithQueryParameter("RTYP", m3_RTYP.Trim())
				.WithQueryParameter("AGRS", m3_AGRS.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_CHRG.HasValue)
				request.WithQueryParameter("CHRG", m3_CHRG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (m3_COQT.HasValue)
				request.WithQueryParameter("COQT", m3_COQT.Value.ToString());
			if (m3_CIQT.HasValue)
				request.WithQueryParameter("CIQT", m3_CIQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNMS))
				request.WithQueryParameter("UNMS", m3_UNMS.Trim());
			if (m3_ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3_ORQT.Value.ToString());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (m3_ADPW.HasValue)
				request.WithQueryParameter("ADPW", m3_ADPW.Value.ToString());

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
		/// Name ChgAddChrg
		/// Description Change Additional Charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CHRG">Charge</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_COQT">Material usage</param>
		/// <param name="m3_CIQT">Material usage</param>
		/// <param name="m3_UNMS">Basic unit of measure</param>
		/// <param name="m3_ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_ADPW">Days per week</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgAddChrg(
			string m3_AGNB, 
			int m3_VERS, 
			int m3_PONR, 
			int m3_POSX, 
			int? m3_CONO = null, 
			decimal? m3_CHRG = null, 
			string m3_ITDS = null, 
			string m3_PYNO = null, 
			decimal? m3_COQT = null, 
			decimal? m3_CIQT = null, 
			string m3_UNMS = null, 
			decimal? m3_ORQT = null, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_LVDT = null, 
			int? m3_ADPW = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgAddChrg",
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
			if (m3_CHRG.HasValue)
				request.WithQueryParameter("CHRG", m3_CHRG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (m3_COQT.HasValue)
				request.WithQueryParameter("COQT", m3_COQT.Value.ToString());
			if (m3_CIQT.HasValue)
				request.WithQueryParameter("CIQT", m3_CIQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNMS))
				request.WithQueryParameter("UNMS", m3_UNMS.Trim());
			if (m3_ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3_ORQT.Value.ToString());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (m3_ADPW.HasValue)
				request.WithQueryParameter("ADPW", m3_ADPW.Value.ToString());

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
		/// Name DelAddChrg
		/// Description Delete Additional Charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAddChrg(
			string m3_AGNB, 
			int m3_VERS, 
			int m3_PONR, 
			int m3_POSX, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelAddChrg",
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
		/// Name GetAddChrg
		/// Description Get Additional Charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAddChrgResponse></returns>
		/// <exception cref="M3Exception<GetAddChrgResponse>"></exception>
		public async Task<M3Response<GetAddChrgResponse>> GetAddChrg(
			string m3_AGNB, 
			int m3_VERS, 
			int m3_PONR, 
			int m3_POSX, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAddChrg",
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

			// Execute the request
			var result = await Execute<GetAddChrgResponse>(
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
		/// Name LstAddChrg
		/// Description List Additional Charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAddChrgResponse></returns>
		/// <exception cref="M3Exception<LstAddChrgResponse>"></exception>
		public async Task<M3Response<LstAddChrgResponse>> LstAddChrg(
			string m3_AGNB, 
			int m3_VERS, 
			int m3_PONR, 
			int m3_POSX, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAddChrg",
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

			// Execute the request
			var result = await Execute<LstAddChrgResponse>(
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
