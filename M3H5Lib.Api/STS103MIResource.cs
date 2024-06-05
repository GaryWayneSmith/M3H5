/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAddChrg
		/// Description Add Additional Charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="m3RTYP">Record type (Required)</param>
		/// <param name="m3AGRS">Contract item (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CHRG">Charge</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3COQT">Material usage</param>
		/// <param name="m3CIQT">Material usage</param>
		/// <param name="m3UNMS">Basic unit of measure</param>
		/// <param name="m3ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3ADPW">Days per week</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAddChrg(
			string m3AGNB, 
			int m3VERS, 
			int m3PONR, 
			int m3POSX, 
			string m3RTYP, 
			string m3AGRS, 
			int? m3CONO = null, 
			decimal? m3CHRG = null, 
			string m3ITDS = null, 
			string m3PYNO = null, 
			decimal? m3COQT = null, 
			decimal? m3CIQT = null, 
			string m3UNMS = null, 
			decimal? m3ORQT = null, 
			DateTime? m3FVDT = null, 
			DateTime? m3LVDT = null, 
			int? m3ADPW = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddAddChrg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));
			if (string.IsNullOrWhiteSpace(m3RTYP))
				throw new ArgumentNullException(nameof(m3RTYP));
			if (string.IsNullOrWhiteSpace(m3AGRS))
				throw new ArgumentNullException(nameof(m3AGRS));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("POSX", m3POSX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RTYP", m3RTYP.Trim())
				.WithQueryParameter("AGRS", m3AGRS.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHRG.HasValue)
				request.WithQueryParameter("CHRG", m3CHRG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (m3COQT.HasValue)
				request.WithQueryParameter("COQT", m3COQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CIQT.HasValue)
				request.WithQueryParameter("CIQT", m3CIQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3UNMS))
				request.WithQueryParameter("UNMS", m3UNMS.Trim());
			if (m3ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3ORQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (m3ADPW.HasValue)
				request.WithQueryParameter("ADPW", m3ADPW.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgAddChrg
		/// Description Change Additional Charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CHRG">Charge</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3COQT">Material usage</param>
		/// <param name="m3CIQT">Material usage</param>
		/// <param name="m3UNMS">Basic unit of measure</param>
		/// <param name="m3ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3ADPW">Days per week</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgAddChrg(
			string m3AGNB, 
			int m3VERS, 
			int m3PONR, 
			int m3POSX, 
			int? m3CONO = null, 
			decimal? m3CHRG = null, 
			string m3ITDS = null, 
			string m3PYNO = null, 
			decimal? m3COQT = null, 
			decimal? m3CIQT = null, 
			string m3UNMS = null, 
			decimal? m3ORQT = null, 
			DateTime? m3FVDT = null, 
			DateTime? m3LVDT = null, 
			int? m3ADPW = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgAddChrg",
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

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHRG.HasValue)
				request.WithQueryParameter("CHRG", m3CHRG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (m3COQT.HasValue)
				request.WithQueryParameter("COQT", m3COQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CIQT.HasValue)
				request.WithQueryParameter("CIQT", m3CIQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3UNMS))
				request.WithQueryParameter("UNMS", m3UNMS.Trim());
			if (m3ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3ORQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (m3ADPW.HasValue)
				request.WithQueryParameter("ADPW", m3ADPW.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelAddChrg
		/// Description Delete Additional Charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAddChrg(
			string m3AGNB, 
			int m3VERS, 
			int m3PONR, 
			int m3POSX, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelAddChrg",
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

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetAddChrg
		/// Description Get Additional Charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAddChrgResponse></returns>
		/// <exception cref="M3Exception<GetAddChrgResponse>"></exception>
		public async Task<M3Response<GetAddChrgResponse>> GetAddChrg(
			string m3AGNB, 
			int m3VERS, 
			int m3PONR, 
			int m3POSX, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetAddChrg",
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

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetAddChrgResponse>(
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
		/// Name LstAddChrg
		/// Description List Additional Charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAddChrgResponse></returns>
		/// <exception cref="M3Exception<LstAddChrgResponse>"></exception>
		public async Task<M3Response<LstAddChrgResponse>> LstAddChrg(
			string m3AGNB, 
			int m3VERS, 
			int m3PONR, 
			int m3POSX, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAddChrg",
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

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAddChrgResponse>(
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
