/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAgreementLn
		/// Description This transaction adds agreement lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CTNO">Agreement number (Required)</param>
		/// <param name="m3_CUPL">Customer site (Required)</param>
		/// <param name="m3_POPN">Ind item no (Required)</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_VADF">Valid from</param>
		/// <param name="m3_VLCD">Validity type</param>
		/// <param name="m3_AGTP">Agreement type</param>
		/// <param name="m3_APTM">Response time</param>
		/// <param name="m3_AGQT">Agreed quantity</param>
		/// <param name="m3_AGRS">Contract item</param>
		/// <param name="m3_VADT">Valid to</param>
		/// <param name="m3_IIDF">Invoicing range</param>
		/// <param name="m3_IIDT">End date - invoice range</param>
		/// <param name="m3_NODT">Next order date</param>
		/// <param name="m3_IIYR">Invoicing interval - years</param>
		/// <param name="m3_IIMO">Invoicing interval - months</param>
		/// <param name="m3_IIDA">Invoicing interval - days</param>
		/// <param name="m3_INVM">Invoicing method</param>
		/// <param name="m3_ILCD">Invoice block</param>
		/// <param name="m3_LSCD">Service stop</param>
		/// <param name="m3_ADDI">Higher level</param>
		/// <param name="m3_SAPR">Agreement price</param>
		/// <param name="m3_SACD">Agreement price quantity</param>
		/// <param name="m3_IXAV">Current ndex value</param>
		/// <param name="m3_PRS1">Price list</param>
		/// <param name="m3_PLSO">Price list Serv</param>
		/// <param name="m3_WADP">Discount percentage warranty</param>
		/// <param name="m3_DIDA">Valid to</param>
		/// <param name="m3_DISY">Discount model</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_AIT1">Revenue-Account</param>
		/// <param name="m3_AIT2">Revenue-Project</param>
		/// <param name="m3_AIT3">Revenue-Element</param>
		/// <param name="m3_AIT4">Revenue-Dim 4</param>
		/// <param name="m3_AIT5">Revenue-Dim 5</param>
		/// <param name="m3_AIT6">Revenue-Dim 6</param>
		/// <param name="m3_AIT7">Revenue-Dim 7</param>
		/// <param name="m3_AIC1">Cost-Account</param>
		/// <param name="m3_AIC2">Cost-Project</param>
		/// <param name="m3_AIC3">Cost-Element</param>
		/// <param name="m3_AIC4">Cost-Dim 4</param>
		/// <param name="m3_AIC5">Cost-Dim 5</param>
		/// <param name="m3_AIC6">Cost-Dim 6</param>
		/// <param name="m3_AIC7">Cost-Dim 7</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_ACRF">Acc control object</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_CFJ1">User-defined field 1</param>
		/// <param name="m3_CFJ2">User-defined field 2</param>
		/// <param name="m3_CFJ3">User-defined field 3</param>
		/// <param name="m3_CFJ4">User-defined field 4</param>
		/// <param name="m3_CFJ5">User-defined field 5</param>
		/// <param name="m3_CFJ6">User-defined field 6</param>
		/// <param name="m3_CFJ7">User-defined field 7</param>
		/// <param name="m3_CFJ8">User-defined field 8</param>
		/// <param name="m3_CFJ9">User-defined field 9</param>
		/// <param name="m3_CFJ0">User-defined field 10</param>
		/// <param name="m3_SRES">Service manager</param>
		/// <param name="m3_WOSC">Work schedule</param>
		/// <param name="m3_TEC1">Technician 1</param>
		/// <param name="m3_TEC2">Technician 2</param>
		/// <param name="m3_PSCO">Preventive service order</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAgreementLn(
			string m3_CTNO, 
			string m3_CUPL, 
			string m3_POPN, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			DateTime? m3_VADF = null, 
			string m3_VLCD = null, 
			string m3_AGTP = null, 
			int? m3_APTM = null, 
			int? m3_AGQT = null, 
			string m3_AGRS = null, 
			DateTime? m3_VADT = null, 
			DateTime? m3_IIDF = null, 
			DateTime? m3_IIDT = null, 
			DateTime? m3_NODT = null, 
			int? m3_IIYR = null, 
			int? m3_IIMO = null, 
			int? m3_IIDA = null, 
			string m3_INVM = null, 
			int? m3_ILCD = null, 
			int? m3_LSCD = null, 
			int? m3_ADDI = null, 
			decimal? m3_SAPR = null, 
			int? m3_SACD = null, 
			decimal? m3_IXAV = null, 
			string m3_PRS1 = null, 
			string m3_PLSO = null, 
			int? m3_WADP = null, 
			DateTime? m3_DIDA = null, 
			string m3_DISY = null, 
			string m3_PYNO = null, 
			string m3_AIT1 = null, 
			string m3_AIT2 = null, 
			string m3_AIT3 = null, 
			string m3_AIT4 = null, 
			string m3_AIT5 = null, 
			string m3_AIT6 = null, 
			string m3_AIT7 = null, 
			string m3_AIC1 = null, 
			string m3_AIC2 = null, 
			string m3_AIC3 = null, 
			string m3_AIC4 = null, 
			string m3_AIC5 = null, 
			string m3_AIC6 = null, 
			string m3_AIC7 = null, 
			string m3_PROJ = null, 
			string m3_RORN = null, 
			string m3_ELNO = null, 
			int? m3_RORL = null, 
			string m3_ACRF = null, 
			int? m3_RORX = null, 
			string m3_CFJ1 = null, 
			decimal? m3_CFJ2 = null, 
			string m3_CFJ3 = null, 
			string m3_CFJ4 = null, 
			string m3_CFJ5 = null, 
			string m3_CFJ6 = null, 
			decimal? m3_CFJ7 = null, 
			string m3_CFJ8 = null, 
			string m3_CFJ9 = null, 
			string m3_CFJ0 = null, 
			string m3_SRES = null, 
			int? m3_WOSC = null, 
			string m3_TEC1 = null, 
			string m3_TEC2 = null, 
			int? m3_PSCO = null, 
			string m3_ADID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAgreementLn",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CTNO))
				throw new ArgumentNullException("m3_CTNO");
			if (string.IsNullOrWhiteSpace(m3_CUPL))
				throw new ArgumentNullException("m3_CUPL");
			if (string.IsNullOrWhiteSpace(m3_POPN))
				throw new ArgumentNullException("m3_POPN");

			// Set mandatory parameters
			request
				.WithQueryParameter("CTNO", m3_CTNO.Trim())
				.WithQueryParameter("CUPL", m3_CUPL.Trim())
				.WithQueryParameter("POPN", m3_POPN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (m3_VADF.HasValue)
				request.WithQueryParameter("VADF", m3_VADF.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_VLCD))
				request.WithQueryParameter("VLCD", m3_VLCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGTP))
				request.WithQueryParameter("AGTP", m3_AGTP.Trim());
			if (m3_APTM.HasValue)
				request.WithQueryParameter("APTM", m3_APTM.Value.ToString());
			if (m3_AGQT.HasValue)
				request.WithQueryParameter("AGQT", m3_AGQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AGRS))
				request.WithQueryParameter("AGRS", m3_AGRS.Trim());
			if (m3_VADT.HasValue)
				request.WithQueryParameter("VADT", m3_VADT.Value.ToM3String());
			if (m3_IIDF.HasValue)
				request.WithQueryParameter("IIDF", m3_IIDF.Value.ToM3String());
			if (m3_IIDT.HasValue)
				request.WithQueryParameter("IIDT", m3_IIDT.Value.ToM3String());
			if (m3_NODT.HasValue)
				request.WithQueryParameter("NODT", m3_NODT.Value.ToM3String());
			if (m3_IIYR.HasValue)
				request.WithQueryParameter("IIYR", m3_IIYR.Value.ToString());
			if (m3_IIMO.HasValue)
				request.WithQueryParameter("IIMO", m3_IIMO.Value.ToString());
			if (m3_IIDA.HasValue)
				request.WithQueryParameter("IIDA", m3_IIDA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INVM))
				request.WithQueryParameter("INVM", m3_INVM.Trim());
			if (m3_ILCD.HasValue)
				request.WithQueryParameter("ILCD", m3_ILCD.Value.ToString());
			if (m3_LSCD.HasValue)
				request.WithQueryParameter("LSCD", m3_LSCD.Value.ToString());
			if (m3_ADDI.HasValue)
				request.WithQueryParameter("ADDI", m3_ADDI.Value.ToString());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_SACD.HasValue)
				request.WithQueryParameter("SACD", m3_SACD.Value.ToString());
			if (m3_IXAV.HasValue)
				request.WithQueryParameter("IXAV", m3_IXAV.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRS1))
				request.WithQueryParameter("PRS1", m3_PRS1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLSO))
				request.WithQueryParameter("PLSO", m3_PLSO.Trim());
			if (m3_WADP.HasValue)
				request.WithQueryParameter("WADP", m3_WADP.Value.ToString());
			if (m3_DIDA.HasValue)
				request.WithQueryParameter("DIDA", m3_DIDA.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_DISY))
				request.WithQueryParameter("DISY", m3_DISY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT1))
				request.WithQueryParameter("AIT1", m3_AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT2))
				request.WithQueryParameter("AIT2", m3_AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT3))
				request.WithQueryParameter("AIT3", m3_AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT4))
				request.WithQueryParameter("AIT4", m3_AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT5))
				request.WithQueryParameter("AIT5", m3_AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT6))
				request.WithQueryParameter("AIT6", m3_AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT7))
				request.WithQueryParameter("AIT7", m3_AIT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIC1))
				request.WithQueryParameter("AIC1", m3_AIC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIC2))
				request.WithQueryParameter("AIC2", m3_AIC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIC3))
				request.WithQueryParameter("AIC3", m3_AIC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIC4))
				request.WithQueryParameter("AIC4", m3_AIC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIC5))
				request.WithQueryParameter("AIC5", m3_AIC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIC6))
				request.WithQueryParameter("AIC6", m3_AIC6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIC7))
				request.WithQueryParameter("AIC7", m3_AIC7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFJ1))
				request.WithQueryParameter("CFJ1", m3_CFJ1.Trim());
			if (m3_CFJ2.HasValue)
				request.WithQueryParameter("CFJ2", m3_CFJ2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFJ3))
				request.WithQueryParameter("CFJ3", m3_CFJ3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFJ4))
				request.WithQueryParameter("CFJ4", m3_CFJ4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFJ5))
				request.WithQueryParameter("CFJ5", m3_CFJ5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFJ6))
				request.WithQueryParameter("CFJ6", m3_CFJ6.Trim());
			if (m3_CFJ7.HasValue)
				request.WithQueryParameter("CFJ7", m3_CFJ7.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFJ8))
				request.WithQueryParameter("CFJ8", m3_CFJ8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFJ9))
				request.WithQueryParameter("CFJ9", m3_CFJ9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFJ0))
				request.WithQueryParameter("CFJ0", m3_CFJ0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRES))
				request.WithQueryParameter("SRES", m3_SRES.Trim());
			if (m3_WOSC.HasValue)
				request.WithQueryParameter("WOSC", m3_WOSC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEC1))
				request.WithQueryParameter("TEC1", m3_TEC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEC2))
				request.WithQueryParameter("TEC2", m3_TEC2.Trim());
			if (m3_PSCO.HasValue)
				request.WithQueryParameter("PSCO", m3_PSCO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());

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
		/// Name DelAgreementLn
		/// Description This transaction deletes agreement lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CTNO">Agreement number (Required)</param>
		/// <param name="m3_CUPL">Customer site (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAgreementLn(
			string m3_CTNO, 
			string m3_CUPL, 
			int m3_PONR, 
			string m3_ADID = null, 
			int? m3_POSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelAgreementLn",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CTNO))
				throw new ArgumentNullException("m3_CTNO");
			if (string.IsNullOrWhiteSpace(m3_CUPL))
				throw new ArgumentNullException("m3_CUPL");

			// Set mandatory parameters
			request
				.WithQueryParameter("CTNO", m3_CTNO.Trim())
				.WithQueryParameter("CUPL", m3_CUPL.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());

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
		/// Name GetAgreementLn
		/// Description This transaction displays agreement lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CTNO">Agreement number (Required)</param>
		/// <param name="m3_CUPL">Customer site (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgreementLnResponse></returns>
		/// <exception cref="M3Exception<GetAgreementLnResponse>"></exception>
		public async Task<M3Response<GetAgreementLnResponse>> GetAgreementLn(
			string m3_CTNO, 
			string m3_CUPL, 
			int m3_PONR, 
			string m3_ADID = null, 
			int? m3_POSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAgreementLn",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CTNO))
				throw new ArgumentNullException("m3_CTNO");
			if (string.IsNullOrWhiteSpace(m3_CUPL))
				throw new ArgumentNullException("m3_CUPL");

			// Set mandatory parameters
			request
				.WithQueryParameter("CTNO", m3_CTNO.Trim())
				.WithQueryParameter("CUPL", m3_CUPL.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());

			// Execute the request
			var result = await Execute<GetAgreementLnResponse>(
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
		/// Name LstAgreementLn
		/// Description This transaction lists agreement lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CTNO">Agreement number (Required)</param>
		/// <param name="m3_CUPL">Customer site (Required)</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgreementLnResponse></returns>
		/// <exception cref="M3Exception<LstAgreementLnResponse>"></exception>
		public async Task<M3Response<LstAgreementLnResponse>> LstAgreementLn(
			string m3_CTNO, 
			string m3_CUPL, 
			string m3_ADID = null, 
			int? m3_PONR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgreementLn",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CTNO))
				throw new ArgumentNullException("m3_CTNO");
			if (string.IsNullOrWhiteSpace(m3_CUPL))
				throw new ArgumentNullException("m3_CUPL");

			// Set mandatory parameters
			request
				.WithQueryParameter("CTNO", m3_CTNO.Trim())
				.WithQueryParameter("CUPL", m3_CUPL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());

			// Execute the request
			var result = await Execute<LstAgreementLnResponse>(
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
		/// Name UpdAgreementLn
		/// Description This transaction updates agreement lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CTNO">Agreement number (Required)</param>
		/// <param name="m3_CUPL">Customer site (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_VADF">Valid from</param>
		/// <param name="m3_VLCD">Validity type</param>
		/// <param name="m3_AGTP">Agreement type</param>
		/// <param name="m3_APTM">Response time</param>
		/// <param name="m3_AGQT">Agreed quantity</param>
		/// <param name="m3_AGRS">Contract item</param>
		/// <param name="m3_VADT">Valid to</param>
		/// <param name="m3_IIDF">Invoicing range</param>
		/// <param name="m3_IIDT">End date - invoicing range</param>
		/// <param name="m3_NODT">Next Invoice date</param>
		/// <param name="m3_IIYR">Invoicing interval - years</param>
		/// <param name="m3_IIMO">Invoicing interval - months</param>
		/// <param name="m3_IIDA">Invoicing interval - days</param>
		/// <param name="m3_INVM">Invoicing method</param>
		/// <param name="m3_ILCD">Invoice block</param>
		/// <param name="m3_LSCD">Service stop</param>
		/// <param name="m3_ADDI">Higher level</param>
		/// <param name="m3_SAPR">Agreement price</param>
		/// <param name="m3_SACD">Agreement price quantity</param>
		/// <param name="m3_IXAV">Current index value</param>
		/// <param name="m3_PRS1">Price list</param>
		/// <param name="m3_PLSO">Price list Serv</param>
		/// <param name="m3_WADP">Disc % warranty</param>
		/// <param name="m3_DIDA">Valid to</param>
		/// <param name="m3_DISY">Discount model</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_AIT1">Revenue-Account</param>
		/// <param name="m3_AIT2">Revenue-Project</param>
		/// <param name="m3_AIT3">Revenue-Element</param>
		/// <param name="m3_AIT4">Revenue-Dim 4</param>
		/// <param name="m3_AIT5">Revenue-Dim 5</param>
		/// <param name="m3_AIT6">Revenue-Dim 6</param>
		/// <param name="m3_AIT7">Revenue-Dim 7</param>
		/// <param name="m3_AIC1">Cost -Account</param>
		/// <param name="m3_AIC2">Cost -Project</param>
		/// <param name="m3_AIC3">Cost-Element</param>
		/// <param name="m3_AIC4">Cost -Dim 4</param>
		/// <param name="m3_AIC5">Cost -Dim 5</param>
		/// <param name="m3_AIC6">Cost -Dim 6</param>
		/// <param name="m3_AIC7">Cost -Dim 7</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_ACRF">Acc control object</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_CFJ1">User-defined field 1</param>
		/// <param name="m3_CFJ2">User-defined field 2</param>
		/// <param name="m3_CFJ3">User-defined field 3</param>
		/// <param name="m3_CFJ4">User-defined field 4</param>
		/// <param name="m3_CFJ5">User-defined field 5</param>
		/// <param name="m3_CFJ6">User-defined field 6</param>
		/// <param name="m3_CFJ7">User-defined field 7</param>
		/// <param name="m3_CFJ8">User-defined field 8</param>
		/// <param name="m3_CFJ9">User-defined field 9</param>
		/// <param name="m3_CFJ0">User-defined field 10</param>
		/// <param name="m3_SRES">Service manager</param>
		/// <param name="m3_WOSC">Work schedule</param>
		/// <param name="m3_TEC1">Technician 1</param>
		/// <param name="m3_TEC2">Technician 2</param>
		/// <param name="m3_PSCO">Preventive service order</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAgreementLn(
			string m3_CTNO, 
			string m3_CUPL, 
			int m3_PONR, 
			int? m3_POSX = null, 
			DateTime? m3_VADF = null, 
			string m3_VLCD = null, 
			string m3_AGTP = null, 
			int? m3_APTM = null, 
			int? m3_AGQT = null, 
			string m3_AGRS = null, 
			DateTime? m3_VADT = null, 
			DateTime? m3_IIDF = null, 
			DateTime? m3_IIDT = null, 
			DateTime? m3_NODT = null, 
			int? m3_IIYR = null, 
			int? m3_IIMO = null, 
			int? m3_IIDA = null, 
			string m3_INVM = null, 
			int? m3_ILCD = null, 
			int? m3_LSCD = null, 
			int? m3_ADDI = null, 
			decimal? m3_SAPR = null, 
			int? m3_SACD = null, 
			decimal? m3_IXAV = null, 
			string m3_PRS1 = null, 
			string m3_PLSO = null, 
			int? m3_WADP = null, 
			DateTime? m3_DIDA = null, 
			string m3_DISY = null, 
			string m3_PYNO = null, 
			string m3_AIT1 = null, 
			string m3_AIT2 = null, 
			string m3_AIT3 = null, 
			string m3_AIT4 = null, 
			string m3_AIT5 = null, 
			string m3_AIT6 = null, 
			string m3_AIT7 = null, 
			string m3_AIC1 = null, 
			string m3_AIC2 = null, 
			string m3_AIC3 = null, 
			string m3_AIC4 = null, 
			string m3_AIC5 = null, 
			string m3_AIC6 = null, 
			string m3_AIC7 = null, 
			string m3_PROJ = null, 
			string m3_RORN = null, 
			string m3_ELNO = null, 
			int? m3_RORL = null, 
			string m3_ACRF = null, 
			int? m3_RORX = null, 
			string m3_CFJ1 = null, 
			decimal? m3_CFJ2 = null, 
			string m3_CFJ3 = null, 
			string m3_CFJ4 = null, 
			string m3_CFJ5 = null, 
			string m3_CFJ6 = null, 
			decimal? m3_CFJ7 = null, 
			string m3_CFJ8 = null, 
			string m3_CFJ9 = null, 
			string m3_CFJ0 = null, 
			string m3_SRES = null, 
			int? m3_WOSC = null, 
			string m3_TEC1 = null, 
			string m3_TEC2 = null, 
			int? m3_PSCO = null, 
			string m3_ADID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdAgreementLn",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CTNO))
				throw new ArgumentNullException("m3_CTNO");
			if (string.IsNullOrWhiteSpace(m3_CUPL))
				throw new ArgumentNullException("m3_CUPL");

			// Set mandatory parameters
			request
				.WithQueryParameter("CTNO", m3_CTNO.Trim())
				.WithQueryParameter("CUPL", m3_CUPL.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (m3_VADF.HasValue)
				request.WithQueryParameter("VADF", m3_VADF.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_VLCD))
				request.WithQueryParameter("VLCD", m3_VLCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGTP))
				request.WithQueryParameter("AGTP", m3_AGTP.Trim());
			if (m3_APTM.HasValue)
				request.WithQueryParameter("APTM", m3_APTM.Value.ToString());
			if (m3_AGQT.HasValue)
				request.WithQueryParameter("AGQT", m3_AGQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AGRS))
				request.WithQueryParameter("AGRS", m3_AGRS.Trim());
			if (m3_VADT.HasValue)
				request.WithQueryParameter("VADT", m3_VADT.Value.ToM3String());
			if (m3_IIDF.HasValue)
				request.WithQueryParameter("IIDF", m3_IIDF.Value.ToM3String());
			if (m3_IIDT.HasValue)
				request.WithQueryParameter("IIDT", m3_IIDT.Value.ToM3String());
			if (m3_NODT.HasValue)
				request.WithQueryParameter("NODT", m3_NODT.Value.ToM3String());
			if (m3_IIYR.HasValue)
				request.WithQueryParameter("IIYR", m3_IIYR.Value.ToString());
			if (m3_IIMO.HasValue)
				request.WithQueryParameter("IIMO", m3_IIMO.Value.ToString());
			if (m3_IIDA.HasValue)
				request.WithQueryParameter("IIDA", m3_IIDA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INVM))
				request.WithQueryParameter("INVM", m3_INVM.Trim());
			if (m3_ILCD.HasValue)
				request.WithQueryParameter("ILCD", m3_ILCD.Value.ToString());
			if (m3_LSCD.HasValue)
				request.WithQueryParameter("LSCD", m3_LSCD.Value.ToString());
			if (m3_ADDI.HasValue)
				request.WithQueryParameter("ADDI", m3_ADDI.Value.ToString());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_SACD.HasValue)
				request.WithQueryParameter("SACD", m3_SACD.Value.ToString());
			if (m3_IXAV.HasValue)
				request.WithQueryParameter("IXAV", m3_IXAV.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRS1))
				request.WithQueryParameter("PRS1", m3_PRS1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLSO))
				request.WithQueryParameter("PLSO", m3_PLSO.Trim());
			if (m3_WADP.HasValue)
				request.WithQueryParameter("WADP", m3_WADP.Value.ToString());
			if (m3_DIDA.HasValue)
				request.WithQueryParameter("DIDA", m3_DIDA.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_DISY))
				request.WithQueryParameter("DISY", m3_DISY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT1))
				request.WithQueryParameter("AIT1", m3_AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT2))
				request.WithQueryParameter("AIT2", m3_AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT3))
				request.WithQueryParameter("AIT3", m3_AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT4))
				request.WithQueryParameter("AIT4", m3_AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT5))
				request.WithQueryParameter("AIT5", m3_AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT6))
				request.WithQueryParameter("AIT6", m3_AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT7))
				request.WithQueryParameter("AIT7", m3_AIT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIC1))
				request.WithQueryParameter("AIC1", m3_AIC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIC2))
				request.WithQueryParameter("AIC2", m3_AIC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIC3))
				request.WithQueryParameter("AIC3", m3_AIC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIC4))
				request.WithQueryParameter("AIC4", m3_AIC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIC5))
				request.WithQueryParameter("AIC5", m3_AIC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIC6))
				request.WithQueryParameter("AIC6", m3_AIC6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIC7))
				request.WithQueryParameter("AIC7", m3_AIC7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFJ1))
				request.WithQueryParameter("CFJ1", m3_CFJ1.Trim());
			if (m3_CFJ2.HasValue)
				request.WithQueryParameter("CFJ2", m3_CFJ2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFJ3))
				request.WithQueryParameter("CFJ3", m3_CFJ3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFJ4))
				request.WithQueryParameter("CFJ4", m3_CFJ4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFJ5))
				request.WithQueryParameter("CFJ5", m3_CFJ5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFJ6))
				request.WithQueryParameter("CFJ6", m3_CFJ6.Trim());
			if (m3_CFJ7.HasValue)
				request.WithQueryParameter("CFJ7", m3_CFJ7.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFJ8))
				request.WithQueryParameter("CFJ8", m3_CFJ8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFJ9))
				request.WithQueryParameter("CFJ9", m3_CFJ9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFJ0))
				request.WithQueryParameter("CFJ0", m3_CFJ0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRES))
				request.WithQueryParameter("SRES", m3_SRES.Trim());
			if (m3_WOSC.HasValue)
				request.WithQueryParameter("WOSC", m3_WOSC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEC1))
				request.WithQueryParameter("TEC1", m3_TEC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEC2))
				request.WithQueryParameter("TEC2", m3_TEC2.Trim());
			if (m3_PSCO.HasValue)
				request.WithQueryParameter("PSCO", m3_PSCO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());

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
	}
}
// EOF
