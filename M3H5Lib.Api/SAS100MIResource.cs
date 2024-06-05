/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddServiceAgrmt
		/// Description This transaction adds service agreement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CUPL">Customer site (Required)</param>
		/// <param name="m3AOTP">Agreement order type (Required)</param>
		/// <param name="m3AGTP">Agreement type (Required)</param>
		/// <param name="m3CTNO">Agreement number</param>
		/// <param name="m3VLCD">Validity type</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3VADF">Valid from</param>
		/// <param name="m3IIDF">Invoicing range</param>
		/// <param name="m3VADT">Valid to</param>
		/// <param name="m3IIDT">End inv</param>
		/// <param name="m3NODT">Next order date</param>
		/// <param name="m3IIYR">Invoicing interval - years</param>
		/// <param name="m3IIMO">Invoicing interval - months</param>
		/// <param name="m3IIDA">Invoicing interval - days</param>
		/// <param name="m3INVM">Invoicing method</param>
		/// <param name="m3ILCD">Invoice block</param>
		/// <param name="m3LSCD">Service stop</param>
		/// <param name="m3DBCO">Payer control</param>
		/// <param name="m3MAIV">Aggregated meter invoicing</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3AICD">Summary invoice</param>
		/// <param name="m3AMTN">Curve</param>
		/// <param name="m3ADDI">Higher level</param>
		/// <param name="m3OREF">Our reference</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3AINF">Agreement info</param>
		/// <param name="m3AGPC">Agreed discount</param>
		/// <param name="m3APTM">Response time</param>
		/// <param name="m3IXCD">Price index</param>
		/// <param name="m3IXVA">Quantity</param>
		/// <param name="m3NTYR">Period of notice years</param>
		/// <param name="m3NTMO">Period of notice months</param>
		/// <param name="m3NTDA">Period of notice days</param>
		/// <param name="m3RNCD">Agreement update/renewal</param>
		/// <param name="m3RADJ">Audit</param>
		/// <param name="m3LOCP">Fixed price</param>
		/// <param name="m3LODT">Fixed price to</param>
		/// <param name="m3FUDT">Follow-up date</param>
		/// <param name="m3FUCD">Follow-up code</param>
		/// <param name="m3RORC">Reference order cat</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3ACRF">Accounting control object</param>
		/// <param name="m3AIT1">Accounting dimension 1</param>
		/// <param name="m3AIT2">Accounting dimension 2</param>
		/// <param name="m3AIT3">Accounting dimension 3</param>
		/// <param name="m3AIT4">Accounting dimension 4</param>
		/// <param name="m3AIT5">Accounting dimension 5</param>
		/// <param name="m3AIT6">Accounting dimension 6</param>
		/// <param name="m3AIT7">Accounting dimension 7</param>
		/// <param name="m3FRE1">Statistics identity 1</param>
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
		/// <param name="m3LHCD">Language</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3CRTP">Exchange rate type</param>
		/// <param name="m3PRS1">Price list</param>
		/// <param name="m3OPRI">Priority</param>
		/// <param name="m3SDST">District</param>
		/// <param name="m3SMCD">Salesperson</param>
		/// <param name="m3PLSO">Price list service</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3CUCL">Customer group</param>
		/// <param name="m3EXCD">Service charge</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddServiceAgrmtResponse></returns>
		/// <exception cref="M3Exception<AddServiceAgrmtResponse>"></exception>
		public async Task<M3Response<AddServiceAgrmtResponse>> AddServiceAgrmt(
			string m3FACI, 
			string m3CUPL, 
			string m3AOTP, 
			string m3AGTP, 
			string m3CTNO = null, 
			string m3VLCD = null, 
			string m3CUOR = null, 
			DateTime? m3VADF = null, 
			DateTime? m3IIDF = null, 
			DateTime? m3VADT = null, 
			DateTime? m3IIDT = null, 
			DateTime? m3NODT = null, 
			int? m3IIYR = null, 
			int? m3IIMO = null, 
			int? m3IIDA = null, 
			string m3INVM = null, 
			int? m3ILCD = null, 
			int? m3LSCD = null, 
			string m3DBCO = null, 
			int? m3MAIV = null, 
			string m3TEPY = null, 
			int? m3AICD = null, 
			int? m3AMTN = null, 
			int? m3ADDI = null, 
			string m3OREF = null, 
			string m3YREF = null, 
			string m3AINF = null, 
			int? m3AGPC = null, 
			int? m3APTM = null, 
			string m3IXCD = null, 
			decimal? m3IXVA = null, 
			int? m3NTYR = null, 
			int? m3NTMO = null, 
			int? m3NTDA = null, 
			int? m3RNCD = null, 
			string m3RADJ = null, 
			int? m3LOCP = null, 
			DateTime? m3LODT = null, 
			DateTime? m3FUDT = null, 
			string m3FUCD = null, 
			int? m3RORC = null, 
			string m3PROJ = null, 
			string m3RORN = null, 
			string m3ELNO = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3ACRF = null, 
			string m3AIT1 = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
			string m3FRE1 = null, 
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
			string m3LHCD = null, 
			string m3CUCD = null, 
			int? m3CRTP = null, 
			string m3PRS1 = null, 
			int? m3OPRI = null, 
			string m3SDST = null, 
			string m3SMCD = null, 
			string m3PLSO = null, 
			string m3CSCD = null, 
			string m3CUCL = null, 
			string m3EXCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddServiceAgrmt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3CUPL))
				throw new ArgumentNullException(nameof(m3CUPL));
			if (string.IsNullOrWhiteSpace(m3AOTP))
				throw new ArgumentNullException(nameof(m3AOTP));
			if (string.IsNullOrWhiteSpace(m3AGTP))
				throw new ArgumentNullException(nameof(m3AGTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("CUPL", m3CUPL.Trim())
				.WithQueryParameter("AOTP", m3AOTP.Trim())
				.WithQueryParameter("AGTP", m3AGTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CTNO))
				request.WithQueryParameter("CTNO", m3CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3VLCD))
				request.WithQueryParameter("VLCD", m3VLCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (m3VADF.HasValue)
				request.WithQueryParameter("VADF", m3VADF.Value.ToM3String());
			if (m3IIDF.HasValue)
				request.WithQueryParameter("IIDF", m3IIDF.Value.ToM3String());
			if (m3VADT.HasValue)
				request.WithQueryParameter("VADT", m3VADT.Value.ToM3String());
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
			if (!string.IsNullOrWhiteSpace(m3DBCO))
				request.WithQueryParameter("DBCO", m3DBCO.Trim());
			if (m3MAIV.HasValue)
				request.WithQueryParameter("MAIV", m3MAIV.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (m3AICD.HasValue)
				request.WithQueryParameter("AICD", m3AICD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3AMTN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADDI.HasValue)
				request.WithQueryParameter("ADDI", m3ADDI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OREF))
				request.WithQueryParameter("OREF", m3OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3AINF))
				request.WithQueryParameter("AINF", m3AINF.Trim());
			if (m3AGPC.HasValue)
				request.WithQueryParameter("AGPC", m3AGPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3APTM.HasValue)
				request.WithQueryParameter("APTM", m3APTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3IXCD))
				request.WithQueryParameter("IXCD", m3IXCD.Trim());
			if (m3IXVA.HasValue)
				request.WithQueryParameter("IXVA", m3IXVA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NTYR.HasValue)
				request.WithQueryParameter("NTYR", m3NTYR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NTMO.HasValue)
				request.WithQueryParameter("NTMO", m3NTMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NTDA.HasValue)
				request.WithQueryParameter("NTDA", m3NTDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RNCD.HasValue)
				request.WithQueryParameter("RNCD", m3RNCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RADJ))
				request.WithQueryParameter("RADJ", m3RADJ.Trim());
			if (m3LOCP.HasValue)
				request.WithQueryParameter("LOCP", m3LOCP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LODT.HasValue)
				request.WithQueryParameter("LODT", m3LODT.Value.ToM3String());
			if (m3FUDT.HasValue)
				request.WithQueryParameter("FUDT", m3FUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3FUCD))
				request.WithQueryParameter("FUCD", m3FUCD.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3FRE1))
				request.WithQueryParameter("FRE1", m3FRE1.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3LHCD))
				request.WithQueryParameter("LHCD", m3LHCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3CRTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRS1))
				request.WithQueryParameter("PRS1", m3PRS1.Trim());
			if (m3OPRI.HasValue)
				request.WithQueryParameter("OPRI", m3OPRI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SDST))
				request.WithQueryParameter("SDST", m3SDST.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMCD))
				request.WithQueryParameter("SMCD", m3SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLSO))
				request.WithQueryParameter("PLSO", m3PLSO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCL))
				request.WithQueryParameter("CUCL", m3CUCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXCD))
				request.WithQueryParameter("EXCD", m3EXCD.Trim());

			// Execute the request
			var result = await Execute<AddServiceAgrmtResponse>(
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
		/// Name DelServiceAgrmt
		/// Description This transaction deletes service agreement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CTNO">Agreement number (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelServiceAgrmt(
			string m3CTNO, 
			string m3FACI, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelServiceAgrmt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CTNO))
				throw new ArgumentNullException(nameof(m3CTNO));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("CTNO", m3CTNO.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim());

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
		/// Name GetServiceAgrmt
		/// Description This transaction displays service agreement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CTNO">Agreement number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetServiceAgrmtResponse></returns>
		/// <exception cref="M3Exception<GetServiceAgrmtResponse>"></exception>
		public async Task<M3Response<GetServiceAgrmtResponse>> GetServiceAgrmt(
			string m3CTNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetServiceAgrmt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CTNO))
				throw new ArgumentNullException(nameof(m3CTNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CTNO", m3CTNO.Trim());

			// Execute the request
			var result = await Execute<GetServiceAgrmtResponse>(
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
		/// Name LstServiceAgrmt
		/// Description This transaction lists service agreement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3CUPL">Customer site</param>
		/// <param name="m3CTNO">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstServiceAgrmtResponse></returns>
		/// <exception cref="M3Exception<LstServiceAgrmtResponse>"></exception>
		public async Task<M3Response<LstServiceAgrmtResponse>> LstServiceAgrmt(
			string m3FACI = null, 
			string m3CUPL = null, 
			string m3CTNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstServiceAgrmt",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUPL))
				request.WithQueryParameter("CUPL", m3CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTNO))
				request.WithQueryParameter("CTNO", m3CTNO.Trim());

			// Execute the request
			var result = await Execute<LstServiceAgrmtResponse>(
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
		/// Name UpdServiceAgrmt
		/// Description This transaction updates service agreement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CTNO">Agreement number (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3AGTP">Agreement type</param>
		/// <param name="m3VLCD">Validity type</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3VADF">Valid from</param>
		/// <param name="m3IIDF">Invoicing range</param>
		/// <param name="m3VADT">Valid to</param>
		/// <param name="m3IIDT">End inv</param>
		/// <param name="m3NODT">Next invoice date</param>
		/// <param name="m3IIYR">Invoicing interval - years</param>
		/// <param name="m3IIMO">Invoicing interval - months</param>
		/// <param name="m3IIDA">Invoicing interval - days</param>
		/// <param name="m3INVM">Invoicing method</param>
		/// <param name="m3ILCD">Invoice block</param>
		/// <param name="m3LSCD">Service stop</param>
		/// <param name="m3DBCO">Payer control</param>
		/// <param name="m3MAIV">Aggregated meter invoicing</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3AICD">Summary invoice</param>
		/// <param name="m3AMTN">Curve</param>
		/// <param name="m3ADDI">Higher level</param>
		/// <param name="m3OREF">Our reference</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3AINF">Agreement info</param>
		/// <param name="m3AGPC">Agreed discount</param>
		/// <param name="m3APTM">Response time</param>
		/// <param name="m3IXCD">Price index</param>
		/// <param name="m3IXVA">Quantity</param>
		/// <param name="m3NTYR">Period of notice years</param>
		/// <param name="m3NTMO">Period of notice months</param>
		/// <param name="m3NTDA">Period of notice days</param>
		/// <param name="m3RNCD">Agreement update/renewal</param>
		/// <param name="m3RADJ">Audit</param>
		/// <param name="m3LOCP">Fixed price</param>
		/// <param name="m3LODT">Fixed price to</param>
		/// <param name="m3FUDT">Follow-up date</param>
		/// <param name="m3FUCD">Follow-up code</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3ACRF">Accounting control object</param>
		/// <param name="m3AIT1">Accounting dimension 1</param>
		/// <param name="m3AIT2">Accounting dimension 2</param>
		/// <param name="m3AIT3">Accounting dimension 3</param>
		/// <param name="m3AIT4">Accounting dimension 4</param>
		/// <param name="m3AIT5">Accounting dimension 5</param>
		/// <param name="m3AIT6">Accounting dimension 6</param>
		/// <param name="m3AIT7">Accounting dimension 7</param>
		/// <param name="m3FRE1">Statistics identity 1 customer</param>
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
		/// <param name="m3LHCD">Language</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3CRTP">Exchange rate type</param>
		/// <param name="m3PRS1">Price list</param>
		/// <param name="m3OPRI">Priority</param>
		/// <param name="m3SDST">District</param>
		/// <param name="m3SMCD">Salesperson</param>
		/// <param name="m3PLSO">Price list service</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3CUCL">Customer group</param>
		/// <param name="m3EXCD">Service charge</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdServiceAgrmt(
			string m3CTNO, 
			string m3FACI, 
			string m3AGTP = null, 
			string m3VLCD = null, 
			string m3CUOR = null, 
			DateTime? m3VADF = null, 
			DateTime? m3IIDF = null, 
			DateTime? m3VADT = null, 
			DateTime? m3IIDT = null, 
			DateTime? m3NODT = null, 
			int? m3IIYR = null, 
			int? m3IIMO = null, 
			int? m3IIDA = null, 
			string m3INVM = null, 
			int? m3ILCD = null, 
			int? m3LSCD = null, 
			string m3DBCO = null, 
			int? m3MAIV = null, 
			string m3TEPY = null, 
			int? m3AICD = null, 
			int? m3AMTN = null, 
			int? m3ADDI = null, 
			string m3OREF = null, 
			string m3YREF = null, 
			string m3AINF = null, 
			int? m3AGPC = null, 
			int? m3APTM = null, 
			string m3IXCD = null, 
			decimal? m3IXVA = null, 
			int? m3NTYR = null, 
			int? m3NTMO = null, 
			int? m3NTDA = null, 
			int? m3RNCD = null, 
			string m3RADJ = null, 
			int? m3LOCP = null, 
			DateTime? m3LODT = null, 
			DateTime? m3FUDT = null, 
			string m3FUCD = null, 
			int? m3RORC = null, 
			string m3PROJ = null, 
			string m3RORN = null, 
			string m3ELNO = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3ACRF = null, 
			string m3AIT1 = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
			string m3FRE1 = null, 
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
			string m3LHCD = null, 
			string m3CUCD = null, 
			int? m3CRTP = null, 
			string m3PRS1 = null, 
			int? m3OPRI = null, 
			string m3SDST = null, 
			string m3SMCD = null, 
			string m3PLSO = null, 
			string m3CSCD = null, 
			string m3CUCL = null, 
			string m3EXCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdServiceAgrmt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CTNO))
				throw new ArgumentNullException(nameof(m3CTNO));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("CTNO", m3CTNO.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AGTP))
				request.WithQueryParameter("AGTP", m3AGTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3VLCD))
				request.WithQueryParameter("VLCD", m3VLCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (m3VADF.HasValue)
				request.WithQueryParameter("VADF", m3VADF.Value.ToM3String());
			if (m3IIDF.HasValue)
				request.WithQueryParameter("IIDF", m3IIDF.Value.ToM3String());
			if (m3VADT.HasValue)
				request.WithQueryParameter("VADT", m3VADT.Value.ToM3String());
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
			if (!string.IsNullOrWhiteSpace(m3DBCO))
				request.WithQueryParameter("DBCO", m3DBCO.Trim());
			if (m3MAIV.HasValue)
				request.WithQueryParameter("MAIV", m3MAIV.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (m3AICD.HasValue)
				request.WithQueryParameter("AICD", m3AICD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3AMTN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADDI.HasValue)
				request.WithQueryParameter("ADDI", m3ADDI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OREF))
				request.WithQueryParameter("OREF", m3OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3AINF))
				request.WithQueryParameter("AINF", m3AINF.Trim());
			if (m3AGPC.HasValue)
				request.WithQueryParameter("AGPC", m3AGPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3APTM.HasValue)
				request.WithQueryParameter("APTM", m3APTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3IXCD))
				request.WithQueryParameter("IXCD", m3IXCD.Trim());
			if (m3IXVA.HasValue)
				request.WithQueryParameter("IXVA", m3IXVA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NTYR.HasValue)
				request.WithQueryParameter("NTYR", m3NTYR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NTMO.HasValue)
				request.WithQueryParameter("NTMO", m3NTMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NTDA.HasValue)
				request.WithQueryParameter("NTDA", m3NTDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RNCD.HasValue)
				request.WithQueryParameter("RNCD", m3RNCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RADJ))
				request.WithQueryParameter("RADJ", m3RADJ.Trim());
			if (m3LOCP.HasValue)
				request.WithQueryParameter("LOCP", m3LOCP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LODT.HasValue)
				request.WithQueryParameter("LODT", m3LODT.Value.ToM3String());
			if (m3FUDT.HasValue)
				request.WithQueryParameter("FUDT", m3FUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3FUCD))
				request.WithQueryParameter("FUCD", m3FUCD.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3FRE1))
				request.WithQueryParameter("FRE1", m3FRE1.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3LHCD))
				request.WithQueryParameter("LHCD", m3LHCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3CRTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRS1))
				request.WithQueryParameter("PRS1", m3PRS1.Trim());
			if (m3OPRI.HasValue)
				request.WithQueryParameter("OPRI", m3OPRI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SDST))
				request.WithQueryParameter("SDST", m3SDST.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMCD))
				request.WithQueryParameter("SMCD", m3SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLSO))
				request.WithQueryParameter("PLSO", m3PLSO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCL))
				request.WithQueryParameter("CUCL", m3CUCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXCD))
				request.WithQueryParameter("EXCD", m3EXCD.Trim());

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
