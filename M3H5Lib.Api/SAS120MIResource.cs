/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.SAS120MI;
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
	/// Name: SAS120MI
	/// Component Name: Agreement Item Lines
	/// Description: Api: Agreement Item Lines
	/// Version Release: 5e90
	///</summary>
	public partial class SAS120MIResource : M3BaseResourceEndpoint
	{
		public SAS120MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "SAS120MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAgreementLn
		/// Description This transaction adds agreement lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CTNO">Agreement number (Required)</param>
		/// <param name="m3CUPL">Customer site (Required)</param>
		/// <param name="m3POPN">Ind item no (Required)</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3VADF">Valid from</param>
		/// <param name="m3VLCD">Validity type</param>
		/// <param name="m3AGTP">Agreement type</param>
		/// <param name="m3APTM">Response time</param>
		/// <param name="m3AGQT">Agreed quantity</param>
		/// <param name="m3AGRS">Contract item</param>
		/// <param name="m3VADT">Valid to</param>
		/// <param name="m3IIDF">Invoicing range</param>
		/// <param name="m3IIDT">End date - invoice range</param>
		/// <param name="m3NODT">Next order date</param>
		/// <param name="m3IIYR">Invoicing interval - years</param>
		/// <param name="m3IIMO">Invoicing interval - months</param>
		/// <param name="m3IIDA">Invoicing interval - days</param>
		/// <param name="m3INVM">Invoicing method</param>
		/// <param name="m3ILCD">Invoice block</param>
		/// <param name="m3LSCD">Service stop</param>
		/// <param name="m3ADDI">Higher level</param>
		/// <param name="m3SAPR">Agreement price</param>
		/// <param name="m3SACD">Agreement price quantity</param>
		/// <param name="m3IXAV">Current ndex value</param>
		/// <param name="m3PRS1">Price list</param>
		/// <param name="m3PLSO">Price list Serv</param>
		/// <param name="m3WADP">Discount percentage warranty</param>
		/// <param name="m3DIDA">Valid to</param>
		/// <param name="m3DISY">Discount model</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3AIT1">Revenue-Account</param>
		/// <param name="m3AIT2">Revenue-Project</param>
		/// <param name="m3AIT3">Revenue-Element</param>
		/// <param name="m3AIT4">Revenue-Dim 4</param>
		/// <param name="m3AIT5">Revenue-Dim 5</param>
		/// <param name="m3AIT6">Revenue-Dim 6</param>
		/// <param name="m3AIT7">Revenue-Dim 7</param>
		/// <param name="m3AIC1">Cost-Account</param>
		/// <param name="m3AIC2">Cost-Project</param>
		/// <param name="m3AIC3">Cost-Element</param>
		/// <param name="m3AIC4">Cost-Dim 4</param>
		/// <param name="m3AIC5">Cost-Dim 5</param>
		/// <param name="m3AIC6">Cost-Dim 6</param>
		/// <param name="m3AIC7">Cost-Dim 7</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3ACRF">Acc control object</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3CFJ1">User-defined field 1</param>
		/// <param name="m3CFJ2">User-defined field 2</param>
		/// <param name="m3CFJ3">User-defined field 3</param>
		/// <param name="m3CFJ4">User-defined field 4</param>
		/// <param name="m3CFJ5">User-defined field 5</param>
		/// <param name="m3CFJ6">User-defined field 6</param>
		/// <param name="m3CFJ7">User-defined field 7</param>
		/// <param name="m3CFJ8">User-defined field 8</param>
		/// <param name="m3CFJ9">User-defined field 9</param>
		/// <param name="m3CFJ0">User-defined field 10</param>
		/// <param name="m3SRES">Service manager</param>
		/// <param name="m3WOSC">Work schedule</param>
		/// <param name="m3TEC1">Technician 1</param>
		/// <param name="m3TEC2">Technician 2</param>
		/// <param name="m3PSCO">Preventive service order</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAgreementLn(
			string m3CTNO, 
			string m3CUPL, 
			string m3POPN, 
			int? m3PONR = null, 
			int? m3POSX = null, 
			DateTime? m3VADF = null, 
			string m3VLCD = null, 
			string m3AGTP = null, 
			int? m3APTM = null, 
			int? m3AGQT = null, 
			string m3AGRS = null, 
			DateTime? m3VADT = null, 
			DateTime? m3IIDF = null, 
			DateTime? m3IIDT = null, 
			DateTime? m3NODT = null, 
			int? m3IIYR = null, 
			int? m3IIMO = null, 
			int? m3IIDA = null, 
			string m3INVM = null, 
			int? m3ILCD = null, 
			int? m3LSCD = null, 
			int? m3ADDI = null, 
			decimal? m3SAPR = null, 
			int? m3SACD = null, 
			decimal? m3IXAV = null, 
			string m3PRS1 = null, 
			string m3PLSO = null, 
			int? m3WADP = null, 
			DateTime? m3DIDA = null, 
			string m3DISY = null, 
			string m3PYNO = null, 
			string m3AIT1 = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
			string m3AIC1 = null, 
			string m3AIC2 = null, 
			string m3AIC3 = null, 
			string m3AIC4 = null, 
			string m3AIC5 = null, 
			string m3AIC6 = null, 
			string m3AIC7 = null, 
			string m3PROJ = null, 
			string m3RORN = null, 
			string m3ELNO = null, 
			int? m3RORL = null, 
			string m3ACRF = null, 
			int? m3RORX = null, 
			string m3CFJ1 = null, 
			decimal? m3CFJ2 = null, 
			string m3CFJ3 = null, 
			string m3CFJ4 = null, 
			string m3CFJ5 = null, 
			string m3CFJ6 = null, 
			decimal? m3CFJ7 = null, 
			string m3CFJ8 = null, 
			string m3CFJ9 = null, 
			string m3CFJ0 = null, 
			string m3SRES = null, 
			int? m3WOSC = null, 
			string m3TEC1 = null, 
			string m3TEC2 = null, 
			int? m3PSCO = null, 
			string m3ADID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddAgreementLn",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CTNO))
				throw new ArgumentNullException(nameof(m3CTNO));
			if (string.IsNullOrWhiteSpace(m3CUPL))
				throw new ArgumentNullException(nameof(m3CUPL));
			if (string.IsNullOrWhiteSpace(m3POPN))
				throw new ArgumentNullException(nameof(m3POPN));

			// Set mandatory parameters
			request
				.WithQueryParameter("CTNO", m3CTNO.Trim())
				.WithQueryParameter("CUPL", m3CUPL.Trim())
				.WithQueryParameter("POPN", m3POPN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VADF.HasValue)
				request.WithQueryParameter("VADF", m3VADF.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3VLCD))
				request.WithQueryParameter("VLCD", m3VLCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGTP))
				request.WithQueryParameter("AGTP", m3AGTP.Trim());
			if (m3APTM.HasValue)
				request.WithQueryParameter("APTM", m3APTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGQT.HasValue)
				request.WithQueryParameter("AGQT", m3AGQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AGRS))
				request.WithQueryParameter("AGRS", m3AGRS.Trim());
			if (m3VADT.HasValue)
				request.WithQueryParameter("VADT", m3VADT.Value.ToM3String());
			if (m3IIDF.HasValue)
				request.WithQueryParameter("IIDF", m3IIDF.Value.ToM3String());
			if (m3IIDT.HasValue)
				request.WithQueryParameter("IIDT", m3IIDT.Value.ToM3String());
			if (m3NODT.HasValue)
				request.WithQueryParameter("NODT", m3NODT.Value.ToM3String());
			if (m3IIYR.HasValue)
				request.WithQueryParameter("IIYR", m3IIYR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIMO.HasValue)
				request.WithQueryParameter("IIMO", m3IIMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIDA.HasValue)
				request.WithQueryParameter("IIDA", m3IIDA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INVM))
				request.WithQueryParameter("INVM", m3INVM.Trim());
			if (m3ILCD.HasValue)
				request.WithQueryParameter("ILCD", m3ILCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LSCD.HasValue)
				request.WithQueryParameter("LSCD", m3LSCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADDI.HasValue)
				request.WithQueryParameter("ADDI", m3ADDI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SACD.HasValue)
				request.WithQueryParameter("SACD", m3SACD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IXAV.HasValue)
				request.WithQueryParameter("IXAV", m3IXAV.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRS1))
				request.WithQueryParameter("PRS1", m3PRS1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLSO))
				request.WithQueryParameter("PLSO", m3PLSO.Trim());
			if (m3WADP.HasValue)
				request.WithQueryParameter("WADP", m3WADP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIDA.HasValue)
				request.WithQueryParameter("DIDA", m3DIDA.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3DISY))
				request.WithQueryParameter("DISY", m3DISY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT1))
				request.WithQueryParameter("AIT1", m3AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT2))
				request.WithQueryParameter("AIT2", m3AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT3))
				request.WithQueryParameter("AIT3", m3AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT4))
				request.WithQueryParameter("AIT4", m3AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT5))
				request.WithQueryParameter("AIT5", m3AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT6))
				request.WithQueryParameter("AIT6", m3AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT7))
				request.WithQueryParameter("AIT7", m3AIT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIC1))
				request.WithQueryParameter("AIC1", m3AIC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIC2))
				request.WithQueryParameter("AIC2", m3AIC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIC3))
				request.WithQueryParameter("AIC3", m3AIC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIC4))
				request.WithQueryParameter("AIC4", m3AIC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIC5))
				request.WithQueryParameter("AIC5", m3AIC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIC6))
				request.WithQueryParameter("AIC6", m3AIC6.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIC7))
				request.WithQueryParameter("AIC7", m3AIC7.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFJ1))
				request.WithQueryParameter("CFJ1", m3CFJ1.Trim());
			if (m3CFJ2.HasValue)
				request.WithQueryParameter("CFJ2", m3CFJ2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFJ3))
				request.WithQueryParameter("CFJ3", m3CFJ3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFJ4))
				request.WithQueryParameter("CFJ4", m3CFJ4.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFJ5))
				request.WithQueryParameter("CFJ5", m3CFJ5.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFJ6))
				request.WithQueryParameter("CFJ6", m3CFJ6.Trim());
			if (m3CFJ7.HasValue)
				request.WithQueryParameter("CFJ7", m3CFJ7.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFJ8))
				request.WithQueryParameter("CFJ8", m3CFJ8.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFJ9))
				request.WithQueryParameter("CFJ9", m3CFJ9.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFJ0))
				request.WithQueryParameter("CFJ0", m3CFJ0.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRES))
				request.WithQueryParameter("SRES", m3SRES.Trim());
			if (m3WOSC.HasValue)
				request.WithQueryParameter("WOSC", m3WOSC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEC1))
				request.WithQueryParameter("TEC1", m3TEC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEC2))
				request.WithQueryParameter("TEC2", m3TEC2.Trim());
			if (m3PSCO.HasValue)
				request.WithQueryParameter("PSCO", m3PSCO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());

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
		/// Name DelAgreementLn
		/// Description This transaction deletes agreement lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CTNO">Agreement number (Required)</param>
		/// <param name="m3CUPL">Customer site (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAgreementLn(
			string m3CTNO, 
			string m3CUPL, 
			int m3PONR, 
			string m3ADID = null, 
			int? m3POSX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelAgreementLn",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CTNO))
				throw new ArgumentNullException(nameof(m3CTNO));
			if (string.IsNullOrWhiteSpace(m3CUPL))
				throw new ArgumentNullException(nameof(m3CUPL));

			// Set mandatory parameters
			request
				.WithQueryParameter("CTNO", m3CTNO.Trim())
				.WithQueryParameter("CUPL", m3CUPL.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
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
		/// Name GetAgreementLn
		/// Description This transaction displays agreement lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CTNO">Agreement number (Required)</param>
		/// <param name="m3CUPL">Customer site (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgreementLnResponse></returns>
		/// <exception cref="M3Exception<GetAgreementLnResponse>"></exception>
		public async Task<M3Response<GetAgreementLnResponse>> GetAgreementLn(
			string m3CTNO, 
			string m3CUPL, 
			int m3PONR, 
			string m3ADID = null, 
			int? m3POSX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetAgreementLn",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CTNO))
				throw new ArgumentNullException(nameof(m3CTNO));
			if (string.IsNullOrWhiteSpace(m3CUPL))
				throw new ArgumentNullException(nameof(m3CUPL));

			// Set mandatory parameters
			request
				.WithQueryParameter("CTNO", m3CTNO.Trim())
				.WithQueryParameter("CUPL", m3CUPL.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetAgreementLnResponse>(
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
		/// Name LstAgreementLn
		/// Description This transaction lists agreement lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CTNO">Agreement number (Required)</param>
		/// <param name="m3CUPL">Customer site (Required)</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgreementLnResponse></returns>
		/// <exception cref="M3Exception<LstAgreementLnResponse>"></exception>
		public async Task<M3Response<LstAgreementLnResponse>> LstAgreementLn(
			string m3CTNO, 
			string m3CUPL, 
			string m3ADID = null, 
			int? m3PONR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAgreementLn",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CTNO))
				throw new ArgumentNullException(nameof(m3CTNO));
			if (string.IsNullOrWhiteSpace(m3CUPL))
				throw new ArgumentNullException(nameof(m3CUPL));

			// Set mandatory parameters
			request
				.WithQueryParameter("CTNO", m3CTNO.Trim())
				.WithQueryParameter("CUPL", m3CUPL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAgreementLnResponse>(
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
		/// Name UpdAgreementLn
		/// Description This transaction updates agreement lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CTNO">Agreement number (Required)</param>
		/// <param name="m3CUPL">Customer site (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3VADF">Valid from</param>
		/// <param name="m3VLCD">Validity type</param>
		/// <param name="m3AGTP">Agreement type</param>
		/// <param name="m3APTM">Response time</param>
		/// <param name="m3AGQT">Agreed quantity</param>
		/// <param name="m3AGRS">Contract item</param>
		/// <param name="m3VADT">Valid to</param>
		/// <param name="m3IIDF">Invoicing range</param>
		/// <param name="m3IIDT">End date - invoicing range</param>
		/// <param name="m3NODT">Next Invoice date</param>
		/// <param name="m3IIYR">Invoicing interval - years</param>
		/// <param name="m3IIMO">Invoicing interval - months</param>
		/// <param name="m3IIDA">Invoicing interval - days</param>
		/// <param name="m3INVM">Invoicing method</param>
		/// <param name="m3ILCD">Invoice block</param>
		/// <param name="m3LSCD">Service stop</param>
		/// <param name="m3ADDI">Higher level</param>
		/// <param name="m3SAPR">Agreement price</param>
		/// <param name="m3SACD">Agreement price quantity</param>
		/// <param name="m3IXAV">Current index value</param>
		/// <param name="m3PRS1">Price list</param>
		/// <param name="m3PLSO">Price list Serv</param>
		/// <param name="m3WADP">Disc % warranty</param>
		/// <param name="m3DIDA">Valid to</param>
		/// <param name="m3DISY">Discount model</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3AIT1">Revenue-Account</param>
		/// <param name="m3AIT2">Revenue-Project</param>
		/// <param name="m3AIT3">Revenue-Element</param>
		/// <param name="m3AIT4">Revenue-Dim 4</param>
		/// <param name="m3AIT5">Revenue-Dim 5</param>
		/// <param name="m3AIT6">Revenue-Dim 6</param>
		/// <param name="m3AIT7">Revenue-Dim 7</param>
		/// <param name="m3AIC1">Cost -Account</param>
		/// <param name="m3AIC2">Cost -Project</param>
		/// <param name="m3AIC3">Cost-Element</param>
		/// <param name="m3AIC4">Cost -Dim 4</param>
		/// <param name="m3AIC5">Cost -Dim 5</param>
		/// <param name="m3AIC6">Cost -Dim 6</param>
		/// <param name="m3AIC7">Cost -Dim 7</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3ACRF">Acc control object</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3CFJ1">User-defined field 1</param>
		/// <param name="m3CFJ2">User-defined field 2</param>
		/// <param name="m3CFJ3">User-defined field 3</param>
		/// <param name="m3CFJ4">User-defined field 4</param>
		/// <param name="m3CFJ5">User-defined field 5</param>
		/// <param name="m3CFJ6">User-defined field 6</param>
		/// <param name="m3CFJ7">User-defined field 7</param>
		/// <param name="m3CFJ8">User-defined field 8</param>
		/// <param name="m3CFJ9">User-defined field 9</param>
		/// <param name="m3CFJ0">User-defined field 10</param>
		/// <param name="m3SRES">Service manager</param>
		/// <param name="m3WOSC">Work schedule</param>
		/// <param name="m3TEC1">Technician 1</param>
		/// <param name="m3TEC2">Technician 2</param>
		/// <param name="m3PSCO">Preventive service order</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAgreementLn(
			string m3CTNO, 
			string m3CUPL, 
			int m3PONR, 
			int? m3POSX = null, 
			DateTime? m3VADF = null, 
			string m3VLCD = null, 
			string m3AGTP = null, 
			int? m3APTM = null, 
			int? m3AGQT = null, 
			string m3AGRS = null, 
			DateTime? m3VADT = null, 
			DateTime? m3IIDF = null, 
			DateTime? m3IIDT = null, 
			DateTime? m3NODT = null, 
			int? m3IIYR = null, 
			int? m3IIMO = null, 
			int? m3IIDA = null, 
			string m3INVM = null, 
			int? m3ILCD = null, 
			int? m3LSCD = null, 
			int? m3ADDI = null, 
			decimal? m3SAPR = null, 
			int? m3SACD = null, 
			decimal? m3IXAV = null, 
			string m3PRS1 = null, 
			string m3PLSO = null, 
			int? m3WADP = null, 
			DateTime? m3DIDA = null, 
			string m3DISY = null, 
			string m3PYNO = null, 
			string m3AIT1 = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
			string m3AIC1 = null, 
			string m3AIC2 = null, 
			string m3AIC3 = null, 
			string m3AIC4 = null, 
			string m3AIC5 = null, 
			string m3AIC6 = null, 
			string m3AIC7 = null, 
			string m3PROJ = null, 
			string m3RORN = null, 
			string m3ELNO = null, 
			int? m3RORL = null, 
			string m3ACRF = null, 
			int? m3RORX = null, 
			string m3CFJ1 = null, 
			decimal? m3CFJ2 = null, 
			string m3CFJ3 = null, 
			string m3CFJ4 = null, 
			string m3CFJ5 = null, 
			string m3CFJ6 = null, 
			decimal? m3CFJ7 = null, 
			string m3CFJ8 = null, 
			string m3CFJ9 = null, 
			string m3CFJ0 = null, 
			string m3SRES = null, 
			int? m3WOSC = null, 
			string m3TEC1 = null, 
			string m3TEC2 = null, 
			int? m3PSCO = null, 
			string m3ADID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdAgreementLn",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CTNO))
				throw new ArgumentNullException(nameof(m3CTNO));
			if (string.IsNullOrWhiteSpace(m3CUPL))
				throw new ArgumentNullException(nameof(m3CUPL));

			// Set mandatory parameters
			request
				.WithQueryParameter("CTNO", m3CTNO.Trim())
				.WithQueryParameter("CUPL", m3CUPL.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VADF.HasValue)
				request.WithQueryParameter("VADF", m3VADF.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3VLCD))
				request.WithQueryParameter("VLCD", m3VLCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGTP))
				request.WithQueryParameter("AGTP", m3AGTP.Trim());
			if (m3APTM.HasValue)
				request.WithQueryParameter("APTM", m3APTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGQT.HasValue)
				request.WithQueryParameter("AGQT", m3AGQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AGRS))
				request.WithQueryParameter("AGRS", m3AGRS.Trim());
			if (m3VADT.HasValue)
				request.WithQueryParameter("VADT", m3VADT.Value.ToM3String());
			if (m3IIDF.HasValue)
				request.WithQueryParameter("IIDF", m3IIDF.Value.ToM3String());
			if (m3IIDT.HasValue)
				request.WithQueryParameter("IIDT", m3IIDT.Value.ToM3String());
			if (m3NODT.HasValue)
				request.WithQueryParameter("NODT", m3NODT.Value.ToM3String());
			if (m3IIYR.HasValue)
				request.WithQueryParameter("IIYR", m3IIYR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIMO.HasValue)
				request.WithQueryParameter("IIMO", m3IIMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIDA.HasValue)
				request.WithQueryParameter("IIDA", m3IIDA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INVM))
				request.WithQueryParameter("INVM", m3INVM.Trim());
			if (m3ILCD.HasValue)
				request.WithQueryParameter("ILCD", m3ILCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LSCD.HasValue)
				request.WithQueryParameter("LSCD", m3LSCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADDI.HasValue)
				request.WithQueryParameter("ADDI", m3ADDI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SACD.HasValue)
				request.WithQueryParameter("SACD", m3SACD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IXAV.HasValue)
				request.WithQueryParameter("IXAV", m3IXAV.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRS1))
				request.WithQueryParameter("PRS1", m3PRS1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLSO))
				request.WithQueryParameter("PLSO", m3PLSO.Trim());
			if (m3WADP.HasValue)
				request.WithQueryParameter("WADP", m3WADP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIDA.HasValue)
				request.WithQueryParameter("DIDA", m3DIDA.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3DISY))
				request.WithQueryParameter("DISY", m3DISY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT1))
				request.WithQueryParameter("AIT1", m3AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT2))
				request.WithQueryParameter("AIT2", m3AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT3))
				request.WithQueryParameter("AIT3", m3AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT4))
				request.WithQueryParameter("AIT4", m3AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT5))
				request.WithQueryParameter("AIT5", m3AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT6))
				request.WithQueryParameter("AIT6", m3AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT7))
				request.WithQueryParameter("AIT7", m3AIT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIC1))
				request.WithQueryParameter("AIC1", m3AIC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIC2))
				request.WithQueryParameter("AIC2", m3AIC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIC3))
				request.WithQueryParameter("AIC3", m3AIC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIC4))
				request.WithQueryParameter("AIC4", m3AIC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIC5))
				request.WithQueryParameter("AIC5", m3AIC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIC6))
				request.WithQueryParameter("AIC6", m3AIC6.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIC7))
				request.WithQueryParameter("AIC7", m3AIC7.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFJ1))
				request.WithQueryParameter("CFJ1", m3CFJ1.Trim());
			if (m3CFJ2.HasValue)
				request.WithQueryParameter("CFJ2", m3CFJ2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFJ3))
				request.WithQueryParameter("CFJ3", m3CFJ3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFJ4))
				request.WithQueryParameter("CFJ4", m3CFJ4.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFJ5))
				request.WithQueryParameter("CFJ5", m3CFJ5.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFJ6))
				request.WithQueryParameter("CFJ6", m3CFJ6.Trim());
			if (m3CFJ7.HasValue)
				request.WithQueryParameter("CFJ7", m3CFJ7.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFJ8))
				request.WithQueryParameter("CFJ8", m3CFJ8.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFJ9))
				request.WithQueryParameter("CFJ9", m3CFJ9.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFJ0))
				request.WithQueryParameter("CFJ0", m3CFJ0.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRES))
				request.WithQueryParameter("SRES", m3SRES.Trim());
			if (m3WOSC.HasValue)
				request.WithQueryParameter("WOSC", m3WOSC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEC1))
				request.WithQueryParameter("TEC1", m3TEC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEC2))
				request.WithQueryParameter("TEC2", m3TEC2.Trim());
			if (m3PSCO.HasValue)
				request.WithQueryParameter("PSCO", m3PSCO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());

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
