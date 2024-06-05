/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.SAS100MI;
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
	/// Name: SAS100MI
	/// Component Name: Agreement Head
	/// Description: Api: Agreement Head
	/// Version Release: 14.x
	///</summary>
	public partial class SAS100MIResource : M3BaseResourceEndpoint
	{
		public SAS100MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "SAS100MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddServiceAgrmt
		/// Description This transaction adds service agreement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CUPL">Customer site (Required)</param>
		/// <param name="m3_AOTP">Agreement order type (Required)</param>
		/// <param name="m3_AGTP">Agreement type (Required)</param>
		/// <param name="m3_CTNO">Agreement number</param>
		/// <param name="m3_VLCD">Validity type</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_VADF">Valid from</param>
		/// <param name="m3_IIDF">Invoicing range</param>
		/// <param name="m3_VADT">Valid to</param>
		/// <param name="m3_IIDT">End inv</param>
		/// <param name="m3_NODT">Next order date</param>
		/// <param name="m3_IIYR">Invoicing interval - years</param>
		/// <param name="m3_IIMO">Invoicing interval - months</param>
		/// <param name="m3_IIDA">Invoicing interval - days</param>
		/// <param name="m3_INVM">Invoicing method</param>
		/// <param name="m3_ILCD">Invoice block</param>
		/// <param name="m3_LSCD">Service stop</param>
		/// <param name="m3_DBCO">Payer control</param>
		/// <param name="m3_MAIV">Aggregated meter invoicing</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_AICD">Summary invoice</param>
		/// <param name="m3_AMTN">Curve</param>
		/// <param name="m3_ADDI">Higher level</param>
		/// <param name="m3_OREF">Our reference</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_AINF">Agreement info</param>
		/// <param name="m3_AGPC">Agreed discount</param>
		/// <param name="m3_APTM">Response time</param>
		/// <param name="m3_IXCD">Price index</param>
		/// <param name="m3_IXVA">Quantity</param>
		/// <param name="m3_NTYR">Period of notice years</param>
		/// <param name="m3_NTMO">Period of notice months</param>
		/// <param name="m3_NTDA">Period of notice days</param>
		/// <param name="m3_RNCD">Agreement update/renewal</param>
		/// <param name="m3_RADJ">Audit</param>
		/// <param name="m3_LOCP">Fixed price</param>
		/// <param name="m3_LODT">Fixed price to</param>
		/// <param name="m3_FUDT">Follow-up date</param>
		/// <param name="m3_FUCD">Follow-up code</param>
		/// <param name="m3_RORC">Reference order cat</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_ACRF">Accounting control object</param>
		/// <param name="m3_AIT1">Accounting dimension 1</param>
		/// <param name="m3_AIT2">Accounting dimension 2</param>
		/// <param name="m3_AIT3">Accounting dimension 3</param>
		/// <param name="m3_AIT4">Accounting dimension 4</param>
		/// <param name="m3_AIT5">Accounting dimension 5</param>
		/// <param name="m3_AIT6">Accounting dimension 6</param>
		/// <param name="m3_AIT7">Accounting dimension 7</param>
		/// <param name="m3_FRE1">Statistics identity 1</param>
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
		/// <param name="m3_LHCD">Language</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_CRTP">Exchange rate type</param>
		/// <param name="m3_PRS1">Price list</param>
		/// <param name="m3_OPRI">Priority</param>
		/// <param name="m3_SDST">District</param>
		/// <param name="m3_SMCD">Salesperson</param>
		/// <param name="m3_PLSO">Price list service</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_CUCL">Customer group</param>
		/// <param name="m3_EXCD">Service charge</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddServiceAgrmtResponse></returns>
		/// <exception cref="M3Exception<AddServiceAgrmtResponse>"></exception>
		public async Task<M3Response<AddServiceAgrmtResponse>> AddServiceAgrmt(
			string m3_FACI, 
			string m3_CUPL, 
			string m3_AOTP, 
			string m3_AGTP, 
			string m3_CTNO = null, 
			string m3_VLCD = null, 
			string m3_CUOR = null, 
			DateTime? m3_VADF = null, 
			DateTime? m3_IIDF = null, 
			DateTime? m3_VADT = null, 
			DateTime? m3_IIDT = null, 
			DateTime? m3_NODT = null, 
			int? m3_IIYR = null, 
			int? m3_IIMO = null, 
			int? m3_IIDA = null, 
			string m3_INVM = null, 
			int? m3_ILCD = null, 
			int? m3_LSCD = null, 
			string m3_DBCO = null, 
			int? m3_MAIV = null, 
			string m3_TEPY = null, 
			int? m3_AICD = null, 
			int? m3_AMTN = null, 
			int? m3_ADDI = null, 
			string m3_OREF = null, 
			string m3_YREF = null, 
			string m3_AINF = null, 
			int? m3_AGPC = null, 
			int? m3_APTM = null, 
			string m3_IXCD = null, 
			decimal? m3_IXVA = null, 
			int? m3_NTYR = null, 
			int? m3_NTMO = null, 
			int? m3_NTDA = null, 
			int? m3_RNCD = null, 
			string m3_RADJ = null, 
			int? m3_LOCP = null, 
			DateTime? m3_LODT = null, 
			DateTime? m3_FUDT = null, 
			string m3_FUCD = null, 
			int? m3_RORC = null, 
			string m3_PROJ = null, 
			string m3_RORN = null, 
			string m3_ELNO = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_ACRF = null, 
			string m3_AIT1 = null, 
			string m3_AIT2 = null, 
			string m3_AIT3 = null, 
			string m3_AIT4 = null, 
			string m3_AIT5 = null, 
			string m3_AIT6 = null, 
			string m3_AIT7 = null, 
			string m3_FRE1 = null, 
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
			string m3_LHCD = null, 
			string m3_CUCD = null, 
			int? m3_CRTP = null, 
			string m3_PRS1 = null, 
			int? m3_OPRI = null, 
			string m3_SDST = null, 
			string m3_SMCD = null, 
			string m3_PLSO = null, 
			string m3_CSCD = null, 
			string m3_CUCL = null, 
			string m3_EXCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddServiceAgrmt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_CUPL))
				throw new ArgumentNullException("m3_CUPL");
			if (string.IsNullOrWhiteSpace(m3_AOTP))
				throw new ArgumentNullException("m3_AOTP");
			if (string.IsNullOrWhiteSpace(m3_AGTP))
				throw new ArgumentNullException("m3_AGTP");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("CUPL", m3_CUPL.Trim())
				.WithQueryParameter("AOTP", m3_AOTP.Trim())
				.WithQueryParameter("AGTP", m3_AGTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CTNO))
				request.WithQueryParameter("CTNO", m3_CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VLCD))
				request.WithQueryParameter("VLCD", m3_VLCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (m3_VADF.HasValue)
				request.WithQueryParameter("VADF", m3_VADF.Value.ToM3String());
			if (m3_IIDF.HasValue)
				request.WithQueryParameter("IIDF", m3_IIDF.Value.ToM3String());
			if (m3_VADT.HasValue)
				request.WithQueryParameter("VADT", m3_VADT.Value.ToM3String());
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
			if (!string.IsNullOrWhiteSpace(m3_DBCO))
				request.WithQueryParameter("DBCO", m3_DBCO.Trim());
			if (m3_MAIV.HasValue)
				request.WithQueryParameter("MAIV", m3_MAIV.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (m3_AICD.HasValue)
				request.WithQueryParameter("AICD", m3_AICD.Value.ToString());
			if (m3_AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3_AMTN.Value.ToString());
			if (m3_ADDI.HasValue)
				request.WithQueryParameter("ADDI", m3_ADDI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OREF))
				request.WithQueryParameter("OREF", m3_OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AINF))
				request.WithQueryParameter("AINF", m3_AINF.Trim());
			if (m3_AGPC.HasValue)
				request.WithQueryParameter("AGPC", m3_AGPC.Value.ToString());
			if (m3_APTM.HasValue)
				request.WithQueryParameter("APTM", m3_APTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_IXCD))
				request.WithQueryParameter("IXCD", m3_IXCD.Trim());
			if (m3_IXVA.HasValue)
				request.WithQueryParameter("IXVA", m3_IXVA.Value.ToString());
			if (m3_NTYR.HasValue)
				request.WithQueryParameter("NTYR", m3_NTYR.Value.ToString());
			if (m3_NTMO.HasValue)
				request.WithQueryParameter("NTMO", m3_NTMO.Value.ToString());
			if (m3_NTDA.HasValue)
				request.WithQueryParameter("NTDA", m3_NTDA.Value.ToString());
			if (m3_RNCD.HasValue)
				request.WithQueryParameter("RNCD", m3_RNCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RADJ))
				request.WithQueryParameter("RADJ", m3_RADJ.Trim());
			if (m3_LOCP.HasValue)
				request.WithQueryParameter("LOCP", m3_LOCP.Value.ToString());
			if (m3_LODT.HasValue)
				request.WithQueryParameter("LODT", m3_LODT.Value.ToM3String());
			if (m3_FUDT.HasValue)
				request.WithQueryParameter("FUDT", m3_FUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_FUCD))
				request.WithQueryParameter("FUCD", m3_FUCD.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_FRE1))
				request.WithQueryParameter("FRE1", m3_FRE1.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_LHCD))
				request.WithQueryParameter("LHCD", m3_LHCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3_CRTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRS1))
				request.WithQueryParameter("PRS1", m3_PRS1.Trim());
			if (m3_OPRI.HasValue)
				request.WithQueryParameter("OPRI", m3_OPRI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SDST))
				request.WithQueryParameter("SDST", m3_SDST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMCD))
				request.WithQueryParameter("SMCD", m3_SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLSO))
				request.WithQueryParameter("PLSO", m3_PLSO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCL))
				request.WithQueryParameter("CUCL", m3_CUCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXCD))
				request.WithQueryParameter("EXCD", m3_EXCD.Trim());

			// Execute the request
			var result = await Execute<AddServiceAgrmtResponse>(
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
		/// Name DelServiceAgrmt
		/// Description This transaction deletes service agreement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CTNO">Agreement number (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelServiceAgrmt(
			string m3_CTNO, 
			string m3_FACI, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelServiceAgrmt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CTNO))
				throw new ArgumentNullException("m3_CTNO");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("CTNO", m3_CTNO.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim());

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
		/// Name GetServiceAgrmt
		/// Description This transaction displays service agreement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CTNO">Agreement number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetServiceAgrmtResponse></returns>
		/// <exception cref="M3Exception<GetServiceAgrmtResponse>"></exception>
		public async Task<M3Response<GetServiceAgrmtResponse>> GetServiceAgrmt(
			string m3_CTNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetServiceAgrmt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CTNO))
				throw new ArgumentNullException("m3_CTNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CTNO", m3_CTNO.Trim());

			// Execute the request
			var result = await Execute<GetServiceAgrmtResponse>(
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
		/// Name LstServiceAgrmt
		/// Description This transaction lists service agreement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_CUPL">Customer site</param>
		/// <param name="m3_CTNO">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstServiceAgrmtResponse></returns>
		/// <exception cref="M3Exception<LstServiceAgrmtResponse>"></exception>
		public async Task<M3Response<LstServiceAgrmtResponse>> LstServiceAgrmt(
			string m3_FACI = null, 
			string m3_CUPL = null, 
			string m3_CTNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstServiceAgrmt",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUPL))
				request.WithQueryParameter("CUPL", m3_CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTNO))
				request.WithQueryParameter("CTNO", m3_CTNO.Trim());

			// Execute the request
			var result = await Execute<LstServiceAgrmtResponse>(
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
		/// Name UpdServiceAgrmt
		/// Description This transaction updates service agreement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CTNO">Agreement number (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_AGTP">Agreement type</param>
		/// <param name="m3_VLCD">Validity type</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_VADF">Valid from</param>
		/// <param name="m3_IIDF">Invoicing range</param>
		/// <param name="m3_VADT">Valid to</param>
		/// <param name="m3_IIDT">End inv</param>
		/// <param name="m3_NODT">Next invoice date</param>
		/// <param name="m3_IIYR">Invoicing interval - years</param>
		/// <param name="m3_IIMO">Invoicing interval - months</param>
		/// <param name="m3_IIDA">Invoicing interval - days</param>
		/// <param name="m3_INVM">Invoicing method</param>
		/// <param name="m3_ILCD">Invoice block</param>
		/// <param name="m3_LSCD">Service stop</param>
		/// <param name="m3_DBCO">Payer control</param>
		/// <param name="m3_MAIV">Aggregated meter invoicing</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_AICD">Summary invoice</param>
		/// <param name="m3_AMTN">Curve</param>
		/// <param name="m3_ADDI">Higher level</param>
		/// <param name="m3_OREF">Our reference</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_AINF">Agreement info</param>
		/// <param name="m3_AGPC">Agreed discount</param>
		/// <param name="m3_APTM">Response time</param>
		/// <param name="m3_IXCD">Price index</param>
		/// <param name="m3_IXVA">Quantity</param>
		/// <param name="m3_NTYR">Period of notice years</param>
		/// <param name="m3_NTMO">Period of notice months</param>
		/// <param name="m3_NTDA">Period of notice days</param>
		/// <param name="m3_RNCD">Agreement update/renewal</param>
		/// <param name="m3_RADJ">Audit</param>
		/// <param name="m3_LOCP">Fixed price</param>
		/// <param name="m3_LODT">Fixed price to</param>
		/// <param name="m3_FUDT">Follow-up date</param>
		/// <param name="m3_FUCD">Follow-up code</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_ACRF">Accounting control object</param>
		/// <param name="m3_AIT1">Accounting dimension 1</param>
		/// <param name="m3_AIT2">Accounting dimension 2</param>
		/// <param name="m3_AIT3">Accounting dimension 3</param>
		/// <param name="m3_AIT4">Accounting dimension 4</param>
		/// <param name="m3_AIT5">Accounting dimension 5</param>
		/// <param name="m3_AIT6">Accounting dimension 6</param>
		/// <param name="m3_AIT7">Accounting dimension 7</param>
		/// <param name="m3_FRE1">Statistics identity 1 customer</param>
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
		/// <param name="m3_LHCD">Language</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_CRTP">Exchange rate type</param>
		/// <param name="m3_PRS1">Price list</param>
		/// <param name="m3_OPRI">Priority</param>
		/// <param name="m3_SDST">District</param>
		/// <param name="m3_SMCD">Salesperson</param>
		/// <param name="m3_PLSO">Price list service</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_CUCL">Customer group</param>
		/// <param name="m3_EXCD">Service charge</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdServiceAgrmt(
			string m3_CTNO, 
			string m3_FACI, 
			string m3_AGTP = null, 
			string m3_VLCD = null, 
			string m3_CUOR = null, 
			DateTime? m3_VADF = null, 
			DateTime? m3_IIDF = null, 
			DateTime? m3_VADT = null, 
			DateTime? m3_IIDT = null, 
			DateTime? m3_NODT = null, 
			int? m3_IIYR = null, 
			int? m3_IIMO = null, 
			int? m3_IIDA = null, 
			string m3_INVM = null, 
			int? m3_ILCD = null, 
			int? m3_LSCD = null, 
			string m3_DBCO = null, 
			int? m3_MAIV = null, 
			string m3_TEPY = null, 
			int? m3_AICD = null, 
			int? m3_AMTN = null, 
			int? m3_ADDI = null, 
			string m3_OREF = null, 
			string m3_YREF = null, 
			string m3_AINF = null, 
			int? m3_AGPC = null, 
			int? m3_APTM = null, 
			string m3_IXCD = null, 
			decimal? m3_IXVA = null, 
			int? m3_NTYR = null, 
			int? m3_NTMO = null, 
			int? m3_NTDA = null, 
			int? m3_RNCD = null, 
			string m3_RADJ = null, 
			int? m3_LOCP = null, 
			DateTime? m3_LODT = null, 
			DateTime? m3_FUDT = null, 
			string m3_FUCD = null, 
			int? m3_RORC = null, 
			string m3_PROJ = null, 
			string m3_RORN = null, 
			string m3_ELNO = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_ACRF = null, 
			string m3_AIT1 = null, 
			string m3_AIT2 = null, 
			string m3_AIT3 = null, 
			string m3_AIT4 = null, 
			string m3_AIT5 = null, 
			string m3_AIT6 = null, 
			string m3_AIT7 = null, 
			string m3_FRE1 = null, 
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
			string m3_LHCD = null, 
			string m3_CUCD = null, 
			int? m3_CRTP = null, 
			string m3_PRS1 = null, 
			int? m3_OPRI = null, 
			string m3_SDST = null, 
			string m3_SMCD = null, 
			string m3_PLSO = null, 
			string m3_CSCD = null, 
			string m3_CUCL = null, 
			string m3_EXCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdServiceAgrmt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CTNO))
				throw new ArgumentNullException("m3_CTNO");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("CTNO", m3_CTNO.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_AGTP))
				request.WithQueryParameter("AGTP", m3_AGTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VLCD))
				request.WithQueryParameter("VLCD", m3_VLCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (m3_VADF.HasValue)
				request.WithQueryParameter("VADF", m3_VADF.Value.ToM3String());
			if (m3_IIDF.HasValue)
				request.WithQueryParameter("IIDF", m3_IIDF.Value.ToM3String());
			if (m3_VADT.HasValue)
				request.WithQueryParameter("VADT", m3_VADT.Value.ToM3String());
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
			if (!string.IsNullOrWhiteSpace(m3_DBCO))
				request.WithQueryParameter("DBCO", m3_DBCO.Trim());
			if (m3_MAIV.HasValue)
				request.WithQueryParameter("MAIV", m3_MAIV.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (m3_AICD.HasValue)
				request.WithQueryParameter("AICD", m3_AICD.Value.ToString());
			if (m3_AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3_AMTN.Value.ToString());
			if (m3_ADDI.HasValue)
				request.WithQueryParameter("ADDI", m3_ADDI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OREF))
				request.WithQueryParameter("OREF", m3_OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AINF))
				request.WithQueryParameter("AINF", m3_AINF.Trim());
			if (m3_AGPC.HasValue)
				request.WithQueryParameter("AGPC", m3_AGPC.Value.ToString());
			if (m3_APTM.HasValue)
				request.WithQueryParameter("APTM", m3_APTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_IXCD))
				request.WithQueryParameter("IXCD", m3_IXCD.Trim());
			if (m3_IXVA.HasValue)
				request.WithQueryParameter("IXVA", m3_IXVA.Value.ToString());
			if (m3_NTYR.HasValue)
				request.WithQueryParameter("NTYR", m3_NTYR.Value.ToString());
			if (m3_NTMO.HasValue)
				request.WithQueryParameter("NTMO", m3_NTMO.Value.ToString());
			if (m3_NTDA.HasValue)
				request.WithQueryParameter("NTDA", m3_NTDA.Value.ToString());
			if (m3_RNCD.HasValue)
				request.WithQueryParameter("RNCD", m3_RNCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RADJ))
				request.WithQueryParameter("RADJ", m3_RADJ.Trim());
			if (m3_LOCP.HasValue)
				request.WithQueryParameter("LOCP", m3_LOCP.Value.ToString());
			if (m3_LODT.HasValue)
				request.WithQueryParameter("LODT", m3_LODT.Value.ToM3String());
			if (m3_FUDT.HasValue)
				request.WithQueryParameter("FUDT", m3_FUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_FUCD))
				request.WithQueryParameter("FUCD", m3_FUCD.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_FRE1))
				request.WithQueryParameter("FRE1", m3_FRE1.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_LHCD))
				request.WithQueryParameter("LHCD", m3_LHCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3_CRTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRS1))
				request.WithQueryParameter("PRS1", m3_PRS1.Trim());
			if (m3_OPRI.HasValue)
				request.WithQueryParameter("OPRI", m3_OPRI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SDST))
				request.WithQueryParameter("SDST", m3_SDST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMCD))
				request.WithQueryParameter("SMCD", m3_SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLSO))
				request.WithQueryParameter("PLSO", m3_PLSO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCL))
				request.WithQueryParameter("CUCL", m3_CUCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXCD))
				request.WithQueryParameter("EXCD", m3_EXCD.Trim());

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
