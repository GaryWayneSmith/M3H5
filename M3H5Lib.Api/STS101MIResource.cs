/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.STS101MI;
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
	/// Name: STS101MI
	/// Component Name: ShortTermRentalAgreement
	/// Description: API: Short term rental agreement Line
	/// Version Release: 5ea0
	///</summary>
	public partial class STS101MIResource : M3BaseResourceEndpoint
	{
		public STS101MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "STS101MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddRentalLine
		/// Description Add Rental Line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3FWHL">From warehouse (Required)</param>
		/// <param name="m3LTYP">Line type (Required)</param>
		/// <param name="m3INNO">Individual item number (Required)</param>
		/// <param name="m3ORQT">Ordered quantity - basic U/M (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3LVDT">Valid to (Required)</param>
		/// <param name="m3CCAP">Rental rate type (Required)</param>
		/// <param name="m3ANOS">Number of shifts (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3CUPL">Customer site</param>
		/// <param name="m3SAID">Address number</param>
		/// <param name="m3DLDT">Planned delivery date</param>
		/// <param name="m3DLTM">Planned delivery time</param>
		/// <param name="m3COLD">Planned pick - up date</param>
		/// <param name="m3COTM">Planned pick - up time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddRentalLineResponse></returns>
		/// <exception cref="M3Exception<AddRentalLineResponse>"></exception>
		public async Task<M3Response<AddRentalLineResponse>> AddRentalLine(
			string m3AGNB, 
			string m3FWHL, 
			string m3LTYP, 
			string m3INNO, 
			decimal m3ORQT, 
			DateTime m3FVDT, 
			DateTime m3LVDT, 
			string m3CCAP, 
			int m3ANOS, 
			int? m3CONO = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
			int? m3VERS = null, 
			string m3SUNO = null, 
			string m3CUPL = null, 
			string m3SAID = null, 
			DateTime? m3DLDT = null, 
			int? m3DLTM = null, 
			DateTime? m3COLD = null, 
			int? m3COTM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddRentalLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));
			if (string.IsNullOrWhiteSpace(m3FWHL))
				throw new ArgumentNullException(nameof(m3FWHL));
			if (string.IsNullOrWhiteSpace(m3LTYP))
				throw new ArgumentNullException(nameof(m3LTYP));
			if (string.IsNullOrWhiteSpace(m3INNO))
				throw new ArgumentNullException(nameof(m3INNO));
			if (string.IsNullOrWhiteSpace(m3CCAP))
				throw new ArgumentNullException(nameof(m3CCAP));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("FWHL", m3FWHL.Trim())
				.WithQueryParameter("LTYP", m3LTYP.Trim())
				.WithQueryParameter("INNO", m3INNO.Trim())
				.WithQueryParameter("ORQT", m3ORQT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FVDT", m3FVDT.ToM3String())
				.WithQueryParameter("LVDT", m3LVDT.ToM3String())
				.WithQueryParameter("CCAP", m3CCAP.Trim())
				.WithQueryParameter("ANOS", m3ANOS.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VERS.HasValue)
				request.WithQueryParameter("VERS", m3VERS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUPL))
				request.WithQueryParameter("CUPL", m3CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SAID))
				request.WithQueryParameter("SAID", m3SAID.Trim());
			if (m3DLDT.HasValue)
				request.WithQueryParameter("DLDT", m3DLDT.Value.ToM3String());
			if (m3DLTM.HasValue)
				request.WithQueryParameter("DLTM", m3DLTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COLD.HasValue)
				request.WithQueryParameter("COLD", m3COLD.Value.ToM3String());
			if (m3COTM.HasValue)
				request.WithQueryParameter("COTM", m3COTM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddRentalLineResponse>(
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
		/// Name DltRentalLine
		/// Description Delete Rental Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltRentalLine(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3AGNB = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
			int? m3VERS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltRentalLine",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VERS.HasValue)
				request.WithQueryParameter("VERS", m3VERS.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetRentalLine
		/// Description Get Rental Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetRentalLineResponse></returns>
		/// <exception cref="M3Exception<GetRentalLineResponse>"></exception>
		public async Task<M3Response<GetRentalLineResponse>> GetRentalLine(
			string m3DIVI, 
			string m3AGNB, 
			int m3PONR, 
			int m3POSX, 
			int m3VERS, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetRentalLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("POSX", m3POSX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetRentalLineResponse>(
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
		/// Name LstRentActivity
		/// Description List rental activity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3LVDT">Valid to (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRentActivityResponse></returns>
		/// <exception cref="M3Exception<LstRentActivityResponse>"></exception>
		public async Task<M3Response<LstRentActivityResponse>> LstRentActivity(
			string m3WHLO, 
			DateTime m3FVDT, 
			DateTime m3LVDT, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstRentActivity",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String())
				.WithQueryParameter("LVDT", m3LVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstRentActivityResponse>(
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
		/// Name LstRentalLine
		/// Description List Rental Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="m3INNO">Individual item number</param>
		/// <param name="m3SAID">Address number</param>
		/// <param name="m3CUPL">Customer site</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRentalLineResponse></returns>
		/// <exception cref="M3Exception<LstRentalLineResponse>"></exception>
		public async Task<M3Response<LstRentalLineResponse>> LstRentalLine(
			string m3AGNB, 
			int? m3CONO = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
			int? m3VERS = null, 
			string m3INNO = null, 
			string m3SAID = null, 
			string m3CUPL = null, 
			string m3PYNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstRentalLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3AGNB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VERS.HasValue)
				request.WithQueryParameter("VERS", m3VERS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INNO))
				request.WithQueryParameter("INNO", m3INNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SAID))
				request.WithQueryParameter("SAID", m3SAID.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUPL))
				request.WithQueryParameter("CUPL", m3CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());

			// Execute the request
			var result = await Execute<LstRentalLineResponse>(
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
		/// Name UpdRentalLine
		/// Description Update Rental Line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3CUPL">Customer site</param>
		/// <param name="m3IVAD">Address number</param>
		/// <param name="m3SAID">Address number</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3IYRF">Your reference 1</param>
		/// <param name="m3IPHN">Internal telephone number</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3TEDA">Termination date</param>
		/// <param name="m3IIDF">Start date - invoicing range</param>
		/// <param name="m3IIDT">End date - invoicing range</param>
		/// <param name="m3ADPW">Days per week</param>
		/// <param name="m3ASOC">Create service order automatic</param>
		/// <param name="m3ANOS">Number of shifts</param>
		/// <param name="m3CCAP">Rental rate type</param>
		/// <param name="m3AMAI">Hold invoicing</param>
		/// <param name="m3PDAN">Net daily rate</param>
		/// <param name="m3PNCA">Net rate/rental rate type</param>
		/// <param name="m3DLDT">Planned delivery date</param>
		/// <param name="m3COLD">Planned pick - up date</param>
		/// <param name="m3FWHL">From warehouse</param>
		/// <param name="m3TWHL">To warehouse</param>
		/// <param name="m3ARCT">Reason code - terminated agreement</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3ORQA">Ordered quantity - alternate U/M</param>
		/// <param name="m3ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3AGTP">Agreement type</param>
		/// <param name="m3INVM">Invoicing method</param>
		/// <param name="m3DLTM">Planned delivery time</param>
		/// <param name="m3COTM">Planned pick - up time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<UpdRentalLineResponse></returns>
		/// <exception cref="M3Exception<UpdRentalLineResponse>"></exception>
		public async Task<M3Response<UpdRentalLineResponse>> UpdRentalLine(
			string m3DIVI, 
			string m3AGNB, 
			int m3PONR, 
			int m3POSX, 
			int m3VERS, 
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3CUPL = null, 
			string m3IVAD = null, 
			string m3SAID = null, 
			string m3PYNO = null, 
			string m3IYRF = null, 
			string m3IPHN = null, 
			DateTime? m3FVDT = null, 
			DateTime? m3LVDT = null, 
			DateTime? m3TEDA = null, 
			DateTime? m3IIDF = null, 
			DateTime? m3IIDT = null, 
			int? m3ADPW = null, 
			int? m3ASOC = null, 
			int? m3ANOS = null, 
			string m3CCAP = null, 
			string m3AMAI = null, 
			decimal? m3PDAN = null, 
			decimal? m3PNCA = null, 
			DateTime? m3DLDT = null, 
			DateTime? m3COLD = null, 
			string m3FWHL = null, 
			string m3TWHL = null, 
			string m3ARCT = null, 
			decimal? m3SAPR = null, 
			decimal? m3ORQA = null, 
			decimal? m3ORQT = null, 
			string m3AGTP = null, 
			string m3INVM = null, 
			int? m3DLTM = null, 
			int? m3COTM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdRentalLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("POSX", m3POSX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUPL))
				request.WithQueryParameter("CUPL", m3CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3IVAD))
				request.WithQueryParameter("IVAD", m3IVAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SAID))
				request.WithQueryParameter("SAID", m3SAID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3IYRF))
				request.WithQueryParameter("IYRF", m3IYRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3IPHN))
				request.WithQueryParameter("IPHN", m3IPHN.Trim());
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (m3TEDA.HasValue)
				request.WithQueryParameter("TEDA", m3TEDA.Value.ToM3String());
			if (m3IIDF.HasValue)
				request.WithQueryParameter("IIDF", m3IIDF.Value.ToM3String());
			if (m3IIDT.HasValue)
				request.WithQueryParameter("IIDT", m3IIDT.Value.ToM3String());
			if (m3ADPW.HasValue)
				request.WithQueryParameter("ADPW", m3ADPW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ASOC.HasValue)
				request.WithQueryParameter("ASOC", m3ASOC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ANOS.HasValue)
				request.WithQueryParameter("ANOS", m3ANOS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CCAP))
				request.WithQueryParameter("CCAP", m3CCAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3AMAI))
				request.WithQueryParameter("AMAI", m3AMAI.Trim());
			if (m3PDAN.HasValue)
				request.WithQueryParameter("PDAN", m3PDAN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PNCA.HasValue)
				request.WithQueryParameter("PNCA", m3PNCA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLDT.HasValue)
				request.WithQueryParameter("DLDT", m3DLDT.Value.ToM3String());
			if (m3COLD.HasValue)
				request.WithQueryParameter("COLD", m3COLD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3FWHL))
				request.WithQueryParameter("FWHL", m3FWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWHL))
				request.WithQueryParameter("TWHL", m3TWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARCT))
				request.WithQueryParameter("ARCT", m3ARCT.Trim());
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORQA.HasValue)
				request.WithQueryParameter("ORQA", m3ORQA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3ORQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AGTP))
				request.WithQueryParameter("AGTP", m3AGTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3INVM))
				request.WithQueryParameter("INVM", m3INVM.Trim());
			if (m3DLTM.HasValue)
				request.WithQueryParameter("DLTM", m3DLTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COTM.HasValue)
				request.WithQueryParameter("COTM", m3COTM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<UpdRentalLineResponse>(
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
