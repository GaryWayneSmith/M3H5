/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddRentalLine
		/// Description Add Rental Line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_FWHL">From warehouse (Required)</param>
		/// <param name="m3_LTYP">Line type (Required)</param>
		/// <param name="m3_INNO">Individual item number (Required)</param>
		/// <param name="m3_ORQT">Ordered quantity - basic U/M (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_LVDT">Valid to (Required)</param>
		/// <param name="m3_CCAP">Rental rate type (Required)</param>
		/// <param name="m3_ANOS">Number of shifts (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_CUPL">Customer site</param>
		/// <param name="m3_SAID">Address number</param>
		/// <param name="m3_DLDT">Planned delivery date</param>
		/// <param name="m3_DLTM">Planned delivery time</param>
		/// <param name="m3_COLD">Planned pick - up date</param>
		/// <param name="m3_COTM">Planned pick - up time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddRentalLineResponse></returns>
		/// <exception cref="M3Exception<AddRentalLineResponse>"></exception>
		public async Task<M3Response<AddRentalLineResponse>> AddRentalLine(
			string m3_AGNB, 
			string m3_FWHL, 
			string m3_LTYP, 
			string m3_INNO, 
			decimal m3_ORQT, 
			DateTime m3_FVDT, 
			DateTime m3_LVDT, 
			string m3_CCAP, 
			int m3_ANOS, 
			int? m3_CONO = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			int? m3_VERS = null, 
			string m3_SUNO = null, 
			string m3_CUPL = null, 
			string m3_SAID = null, 
			DateTime? m3_DLDT = null, 
			int? m3_DLTM = null, 
			DateTime? m3_COLD = null, 
			int? m3_COTM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddRentalLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_FWHL))
				throw new ArgumentNullException("m3_FWHL");
			if (string.IsNullOrWhiteSpace(m3_LTYP))
				throw new ArgumentNullException("m3_LTYP");
			if (string.IsNullOrWhiteSpace(m3_INNO))
				throw new ArgumentNullException("m3_INNO");
			if (string.IsNullOrWhiteSpace(m3_CCAP))
				throw new ArgumentNullException("m3_CCAP");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("FWHL", m3_FWHL.Trim())
				.WithQueryParameter("LTYP", m3_LTYP.Trim())
				.WithQueryParameter("INNO", m3_INNO.Trim())
				.WithQueryParameter("ORQT", m3_ORQT.ToString())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String())
				.WithQueryParameter("LVDT", m3_LVDT.ToM3String())
				.WithQueryParameter("CCAP", m3_CCAP.Trim())
				.WithQueryParameter("ANOS", m3_ANOS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUPL))
				request.WithQueryParameter("CUPL", m3_CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SAID))
				request.WithQueryParameter("SAID", m3_SAID.Trim());
			if (m3_DLDT.HasValue)
				request.WithQueryParameter("DLDT", m3_DLDT.Value.ToM3String());
			if (m3_DLTM.HasValue)
				request.WithQueryParameter("DLTM", m3_DLTM.Value.ToString());
			if (m3_COLD.HasValue)
				request.WithQueryParameter("COLD", m3_COLD.Value.ToM3String());
			if (m3_COTM.HasValue)
				request.WithQueryParameter("COTM", m3_COTM.Value.ToString());

			// Execute the request
			var result = await Execute<AddRentalLineResponse>(
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
		/// Name DltRentalLine
		/// Description Delete Rental Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltRentalLine(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_AGNB = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			int? m3_VERS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltRentalLine",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());

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
		/// Name GetRentalLine
		/// Description Get Rental Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetRentalLineResponse></returns>
		/// <exception cref="M3Exception<GetRentalLineResponse>"></exception>
		public async Task<M3Response<GetRentalLineResponse>> GetRentalLine(
			string m3_DIVI, 
			string m3_AGNB, 
			int m3_PONR, 
			int m3_POSX, 
			int m3_VERS, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetRentalLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString())
				.WithQueryParameter("VERS", m3_VERS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetRentalLineResponse>(
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
		/// Name LstRentActivity
		/// Description List rental activity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_LVDT">Valid to (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRentActivityResponse></returns>
		/// <exception cref="M3Exception<LstRentActivityResponse>"></exception>
		public async Task<M3Response<LstRentActivityResponse>> LstRentActivity(
			string m3_WHLO, 
			DateTime m3_FVDT, 
			DateTime m3_LVDT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstRentActivity",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String())
				.WithQueryParameter("LVDT", m3_LVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstRentActivityResponse>(
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
		/// Name LstRentalLine
		/// Description List Rental Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="m3_INNO">Individual item number</param>
		/// <param name="m3_SAID">Address number</param>
		/// <param name="m3_CUPL">Customer site</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRentalLineResponse></returns>
		/// <exception cref="M3Exception<LstRentalLineResponse>"></exception>
		public async Task<M3Response<LstRentalLineResponse>> LstRentalLine(
			string m3_AGNB, 
			int? m3_CONO = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			int? m3_VERS = null, 
			string m3_INNO = null, 
			string m3_SAID = null, 
			string m3_CUPL = null, 
			string m3_PYNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstRentalLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INNO))
				request.WithQueryParameter("INNO", m3_INNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SAID))
				request.WithQueryParameter("SAID", m3_SAID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUPL))
				request.WithQueryParameter("CUPL", m3_CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());

			// Execute the request
			var result = await Execute<LstRentalLineResponse>(
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
		/// Name UpdRentalLine
		/// Description Update Rental Line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_CUPL">Customer site</param>
		/// <param name="m3_IVAD">Address number</param>
		/// <param name="m3_SAID">Address number</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_IYRF">Your reference 1</param>
		/// <param name="m3_IPHN">Internal telephone number</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_TEDA">Termination date</param>
		/// <param name="m3_IIDF">Start date - invoicing range</param>
		/// <param name="m3_IIDT">End date - invoicing range</param>
		/// <param name="m3_ADPW">Days per week</param>
		/// <param name="m3_ASOC">Create service order automatic</param>
		/// <param name="m3_ANOS">Number of shifts</param>
		/// <param name="m3_CCAP">Rental rate type</param>
		/// <param name="m3_AMAI">Hold invoicing</param>
		/// <param name="m3_PDAN">Net daily rate</param>
		/// <param name="m3_PNCA">Net rate/rental rate type</param>
		/// <param name="m3_DLDT">Planned delivery date</param>
		/// <param name="m3_COLD">Planned pick - up date</param>
		/// <param name="m3_FWHL">From warehouse</param>
		/// <param name="m3_TWHL">To warehouse</param>
		/// <param name="m3_ARCT">Reason code - terminated agreement</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_ORQA">Ordered quantity - alternate U/M</param>
		/// <param name="m3_ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3_AGTP">Agreement type</param>
		/// <param name="m3_INVM">Invoicing method</param>
		/// <param name="m3_DLTM">Planned delivery time</param>
		/// <param name="m3_COTM">Planned pick - up time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<UpdRentalLineResponse></returns>
		/// <exception cref="M3Exception<UpdRentalLineResponse>"></exception>
		public async Task<M3Response<UpdRentalLineResponse>> UpdRentalLine(
			string m3_DIVI, 
			string m3_AGNB, 
			int m3_PONR, 
			int m3_POSX, 
			int m3_VERS, 
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_CUPL = null, 
			string m3_IVAD = null, 
			string m3_SAID = null, 
			string m3_PYNO = null, 
			string m3_IYRF = null, 
			string m3_IPHN = null, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_LVDT = null, 
			DateTime? m3_TEDA = null, 
			DateTime? m3_IIDF = null, 
			DateTime? m3_IIDT = null, 
			int? m3_ADPW = null, 
			int? m3_ASOC = null, 
			int? m3_ANOS = null, 
			string m3_CCAP = null, 
			string m3_AMAI = null, 
			decimal? m3_PDAN = null, 
			decimal? m3_PNCA = null, 
			DateTime? m3_DLDT = null, 
			DateTime? m3_COLD = null, 
			string m3_FWHL = null, 
			string m3_TWHL = null, 
			string m3_ARCT = null, 
			decimal? m3_SAPR = null, 
			decimal? m3_ORQA = null, 
			decimal? m3_ORQT = null, 
			string m3_AGTP = null, 
			string m3_INVM = null, 
			int? m3_DLTM = null, 
			int? m3_COTM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdRentalLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString())
				.WithQueryParameter("VERS", m3_VERS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUPL))
				request.WithQueryParameter("CUPL", m3_CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IVAD))
				request.WithQueryParameter("IVAD", m3_IVAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SAID))
				request.WithQueryParameter("SAID", m3_SAID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IYRF))
				request.WithQueryParameter("IYRF", m3_IYRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IPHN))
				request.WithQueryParameter("IPHN", m3_IPHN.Trim());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (m3_TEDA.HasValue)
				request.WithQueryParameter("TEDA", m3_TEDA.Value.ToM3String());
			if (m3_IIDF.HasValue)
				request.WithQueryParameter("IIDF", m3_IIDF.Value.ToM3String());
			if (m3_IIDT.HasValue)
				request.WithQueryParameter("IIDT", m3_IIDT.Value.ToM3String());
			if (m3_ADPW.HasValue)
				request.WithQueryParameter("ADPW", m3_ADPW.Value.ToString());
			if (m3_ASOC.HasValue)
				request.WithQueryParameter("ASOC", m3_ASOC.Value.ToString());
			if (m3_ANOS.HasValue)
				request.WithQueryParameter("ANOS", m3_ANOS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CCAP))
				request.WithQueryParameter("CCAP", m3_CCAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AMAI))
				request.WithQueryParameter("AMAI", m3_AMAI.Trim());
			if (m3_PDAN.HasValue)
				request.WithQueryParameter("PDAN", m3_PDAN.Value.ToString());
			if (m3_PNCA.HasValue)
				request.WithQueryParameter("PNCA", m3_PNCA.Value.ToString());
			if (m3_DLDT.HasValue)
				request.WithQueryParameter("DLDT", m3_DLDT.Value.ToM3String());
			if (m3_COLD.HasValue)
				request.WithQueryParameter("COLD", m3_COLD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_FWHL))
				request.WithQueryParameter("FWHL", m3_FWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWHL))
				request.WithQueryParameter("TWHL", m3_TWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARCT))
				request.WithQueryParameter("ARCT", m3_ARCT.Trim());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_ORQA.HasValue)
				request.WithQueryParameter("ORQA", m3_ORQA.Value.ToString());
			if (m3_ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3_ORQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AGTP))
				request.WithQueryParameter("AGTP", m3_AGTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INVM))
				request.WithQueryParameter("INVM", m3_INVM.Trim());
			if (m3_DLTM.HasValue)
				request.WithQueryParameter("DLTM", m3_DLTM.Value.ToString());
			if (m3_COTM.HasValue)
				request.WithQueryParameter("COTM", m3_COTM.Value.ToString());

			// Execute the request
			var result = await Execute<UpdRentalLineResponse>(
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
