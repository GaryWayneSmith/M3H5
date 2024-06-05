/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.COS403MI;
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
	/// Name: COS403MI
	/// Component Name: Agreement Site
	/// Description: Agreement Site interface
	/// Version Release: 5ea0
	///</summary>
	public partial class COS403MIResource : M3BaseResourceEndpoint
	{
		public COS403MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "COS403MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAgrSite
		/// Description AddAgrSite
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_AAGN">Agreement (Required)</param>
		/// <param name="m3_CUPL">Customer site (Required)</param>
		/// <param name="m3_ADID">Address number (Required)</param>
		/// <param name="m3_VADF">Valid from</param>
		/// <param name="m3_VADT">Valid to</param>
		/// <param name="m3_LSCD">Service stop</param>
		/// <param name="m3_ILCD">Invoice block</param>
		/// <param name="m3_INVM">Invoicing method</param>
		/// <param name="m3_IIDF">Start date - invoicing range</param>
		/// <param name="m3_IIDT">End date - invoicing range</param>
		/// <param name="m3_IIYR">Invoicing interval - years</param>
		/// <param name="m3_IIMO">Invoicing interval - months</param>
		/// <param name="m3_IIDA">Invoicing interval - days</param>
		/// <param name="m3_NODT">Next invoice date</param>
		/// <param name="m3_IVNO">Invoice number</param>
		/// <param name="m3_IFDT">First invoice date</param>
		/// <param name="m3_AIT1">Accounting dimension 1</param>
		/// <param name="m3_AIT2">Accounting dimension 2</param>
		/// <param name="m3_AIT3">Accounting dimension 3</param>
		/// <param name="m3_AIT4">Accounting dimension 4</param>
		/// <param name="m3_AIT5">Accounting dimension 5</param>
		/// <param name="m3_AIT6">Accounting dimension 6</param>
		/// <param name="m3_AIT7">Accounting dimension 7</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_INPX">Invoice prefix</param>
		/// <param name="m3_EXIN">Extended invoice number</param>
		/// <param name="m3_SRES">Service manager</param>
		/// <param name="m3_TEC1">Technician</param>
		/// <param name="m3_TEC2">Technician</param>
		/// <param name="m3_DIST">Number of kilometer</param>
		/// <param name="m3_LZON">Service zone</param>
		/// <param name="m3_TRTI">Planned travel time</param>
		/// <param name="m3_TVCD">Travel type</param>
		/// <param name="m3_APTM">Response time</param>
		/// <param name="m3_FUCD">Follow-up code</param>
		/// <param name="m3_FUDT">Follow-up date</param>
		/// <param name="m3_OFNO">Quotation number</param>
		/// <param name="m3_WOSC">Work schedule</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_PRTX">Text</param>
		/// <param name="m3_POTX">Retrieve purchase order line text</param>
		/// <param name="m3_DOWT">Downtime</param>
		/// <param name="m3_CFJ1">User-defined field 1 - serv agreement</param>
		/// <param name="m3_CFJ2">User-defined field 2 - serv agreement</param>
		/// <param name="m3_CFJ3">User-defined field 3 - serv agreement</param>
		/// <param name="m3_CFJ4">User-defined field 4 - serv agreement</param>
		/// <param name="m3_CFJ5">User-defined field 5 - serv agreement</param>
		/// <param name="m3_CFJ6">User-defined field 6 - serv agreement</param>
		/// <param name="m3_CFJ7">User-defined field 7 - serv agreement</param>
		/// <param name="m3_CFJ8">User-defined field 8 - serv agreement</param>
		/// <param name="m3_CFJ9">User-defined field 9 - serv agreement</param>
		/// <param name="m3_CFJ0">User-defined field 10 - serv agreement</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_MBII">Meter-based invoicing indicator</param>
		/// <param name="m3_ITPE">Invoice type</param>
		/// <param name="m3_AMTN">Curve</param>
		/// <param name="m3_NPAM">Number of periods</param>
		/// <param name="m3_RCYR">Reconciliation interval - years</param>
		/// <param name="m3_RCMO">Reconciliation interval - months</param>
		/// <param name="m3_RCDY">Reconciliation interval - days</param>
		/// <param name="m3_MRED">Reconciliation days</param>
		/// <param name="m3_OPVR">Operation plan version</param>
		/// <param name="m3_OUMP">Overusage meter unit price</param>
		/// <param name="m3_ADP5">Maximum discrepancy % over</param>
		/// <param name="m3_ADP6">Maximum discrepancy % under</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAgrSite(
			string m3_AAGN, 
			string m3_CUPL, 
			string m3_ADID, 
			DateTime? m3_VADF = null, 
			DateTime? m3_VADT = null, 
			int? m3_LSCD = null, 
			int? m3_ILCD = null, 
			string m3_INVM = null, 
			DateTime? m3_IIDF = null, 
			DateTime? m3_IIDT = null, 
			int? m3_IIYR = null, 
			int? m3_IIMO = null, 
			int? m3_IIDA = null, 
			DateTime? m3_NODT = null, 
			int? m3_IVNO = null, 
			DateTime? m3_IFDT = null, 
			string m3_AIT1 = null, 
			string m3_AIT2 = null, 
			string m3_AIT3 = null, 
			string m3_AIT4 = null, 
			string m3_AIT5 = null, 
			string m3_AIT6 = null, 
			string m3_AIT7 = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_ACRF = null, 
			string m3_PYNO = null, 
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_INPX = null, 
			string m3_EXIN = null, 
			string m3_SRES = null, 
			string m3_TEC1 = null, 
			string m3_TEC2 = null, 
			int? m3_DIST = null, 
			int? m3_LZON = null, 
			int? m3_TRTI = null, 
			string m3_TVCD = null, 
			int? m3_APTM = null, 
			string m3_FUCD = null, 
			DateTime? m3_FUDT = null, 
			string m3_OFNO = null, 
			int? m3_WOSC = null, 
			decimal? m3_TXID = null, 
			string m3_PRTX = null, 
			int? m3_POTX = null, 
			int? m3_DOWT = null, 
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
			string m3_STAT = null, 
			int? m3_MBII = null, 
			int? m3_ITPE = null, 
			int? m3_AMTN = null, 
			int? m3_NPAM = null, 
			int? m3_RCYR = null, 
			int? m3_RCMO = null, 
			int? m3_RCDY = null, 
			int? m3_MRED = null, 
			string m3_OPVR = null, 
			decimal? m3_OUMP = null, 
			int? m3_ADP5 = null, 
			int? m3_ADP6 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAgrSite",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");
			if (string.IsNullOrWhiteSpace(m3_CUPL))
				throw new ArgumentNullException("m3_CUPL");
			if (string.IsNullOrWhiteSpace(m3_ADID))
				throw new ArgumentNullException("m3_ADID");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim())
				.WithQueryParameter("CUPL", m3_CUPL.Trim())
				.WithQueryParameter("ADID", m3_ADID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_VADF.HasValue)
				request.WithQueryParameter("VADF", m3_VADF.Value.ToM3String());
			if (m3_VADT.HasValue)
				request.WithQueryParameter("VADT", m3_VADT.Value.ToM3String());
			if (m3_LSCD.HasValue)
				request.WithQueryParameter("LSCD", m3_LSCD.Value.ToString());
			if (m3_ILCD.HasValue)
				request.WithQueryParameter("ILCD", m3_ILCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INVM))
				request.WithQueryParameter("INVM", m3_INVM.Trim());
			if (m3_IIDF.HasValue)
				request.WithQueryParameter("IIDF", m3_IIDF.Value.ToM3String());
			if (m3_IIDT.HasValue)
				request.WithQueryParameter("IIDT", m3_IIDT.Value.ToM3String());
			if (m3_IIYR.HasValue)
				request.WithQueryParameter("IIYR", m3_IIYR.Value.ToString());
			if (m3_IIMO.HasValue)
				request.WithQueryParameter("IIMO", m3_IIMO.Value.ToString());
			if (m3_IIDA.HasValue)
				request.WithQueryParameter("IIDA", m3_IIDA.Value.ToString());
			if (m3_NODT.HasValue)
				request.WithQueryParameter("NODT", m3_NODT.Value.ToM3String());
			if (m3_IVNO.HasValue)
				request.WithQueryParameter("IVNO", m3_IVNO.Value.ToString());
			if (m3_IFDT.HasValue)
				request.WithQueryParameter("IFDT", m3_IFDT.Value.ToM3String());
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
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INPX))
				request.WithQueryParameter("INPX", m3_INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXIN))
				request.WithQueryParameter("EXIN", m3_EXIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRES))
				request.WithQueryParameter("SRES", m3_SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEC1))
				request.WithQueryParameter("TEC1", m3_TEC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEC2))
				request.WithQueryParameter("TEC2", m3_TEC2.Trim());
			if (m3_DIST.HasValue)
				request.WithQueryParameter("DIST", m3_DIST.Value.ToString());
			if (m3_LZON.HasValue)
				request.WithQueryParameter("LZON", m3_LZON.Value.ToString());
			if (m3_TRTI.HasValue)
				request.WithQueryParameter("TRTI", m3_TRTI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TVCD))
				request.WithQueryParameter("TVCD", m3_TVCD.Trim());
			if (m3_APTM.HasValue)
				request.WithQueryParameter("APTM", m3_APTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FUCD))
				request.WithQueryParameter("FUCD", m3_FUCD.Trim());
			if (m3_FUDT.HasValue)
				request.WithQueryParameter("FUDT", m3_FUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_OFNO))
				request.WithQueryParameter("OFNO", m3_OFNO.Trim());
			if (m3_WOSC.HasValue)
				request.WithQueryParameter("WOSC", m3_WOSC.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRTX))
				request.WithQueryParameter("PRTX", m3_PRTX.Trim());
			if (m3_POTX.HasValue)
				request.WithQueryParameter("POTX", m3_POTX.Value.ToString());
			if (m3_DOWT.HasValue)
				request.WithQueryParameter("DOWT", m3_DOWT.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_MBII.HasValue)
				request.WithQueryParameter("MBII", m3_MBII.Value.ToString());
			if (m3_ITPE.HasValue)
				request.WithQueryParameter("ITPE", m3_ITPE.Value.ToString());
			if (m3_AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3_AMTN.Value.ToString());
			if (m3_NPAM.HasValue)
				request.WithQueryParameter("NPAM", m3_NPAM.Value.ToString());
			if (m3_RCYR.HasValue)
				request.WithQueryParameter("RCYR", m3_RCYR.Value.ToString());
			if (m3_RCMO.HasValue)
				request.WithQueryParameter("RCMO", m3_RCMO.Value.ToString());
			if (m3_RCDY.HasValue)
				request.WithQueryParameter("RCDY", m3_RCDY.Value.ToString());
			if (m3_MRED.HasValue)
				request.WithQueryParameter("MRED", m3_MRED.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OPVR))
				request.WithQueryParameter("OPVR", m3_OPVR.Trim());
			if (m3_OUMP.HasValue)
				request.WithQueryParameter("OUMP", m3_OUMP.Value.ToString());
			if (m3_ADP5.HasValue)
				request.WithQueryParameter("ADP5", m3_ADP5.Value.ToString());
			if (m3_ADP6.HasValue)
				request.WithQueryParameter("ADP6", m3_ADP6.Value.ToString());

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
		/// Name DltAgrSite
		/// Description DltAgrSite
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_AAGN">Agreement (Required)</param>
		/// <param name="m3_CUPL">Customer site (Required)</param>
		/// <param name="m3_ADID">Address number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAgrSite(
			string m3_AAGN, 
			string m3_CUPL, 
			string m3_ADID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltAgrSite",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");
			if (string.IsNullOrWhiteSpace(m3_CUPL))
				throw new ArgumentNullException("m3_CUPL");
			if (string.IsNullOrWhiteSpace(m3_ADID))
				throw new ArgumentNullException("m3_ADID");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim())
				.WithQueryParameter("CUPL", m3_CUPL.Trim())
				.WithQueryParameter("ADID", m3_ADID.Trim());

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
		/// Name GetAgrSite
		/// Description GetAgrSite
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_AAGN">Agreement (Required)</param>
		/// <param name="m3_CUPL">Customer site (Required)</param>
		/// <param name="m3_ADID">Address number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgrSiteResponse></returns>
		/// <exception cref="M3Exception<GetAgrSiteResponse>"></exception>
		public async Task<M3Response<GetAgrSiteResponse>> GetAgrSite(
			string m3_AAGN, 
			string m3_CUPL, 
			string m3_ADID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAgrSite",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");
			if (string.IsNullOrWhiteSpace(m3_CUPL))
				throw new ArgumentNullException("m3_CUPL");
			if (string.IsNullOrWhiteSpace(m3_ADID))
				throw new ArgumentNullException("m3_ADID");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim())
				.WithQueryParameter("CUPL", m3_CUPL.Trim())
				.WithQueryParameter("ADID", m3_ADID.Trim());

			// Execute the request
			var result = await Execute<GetAgrSiteResponse>(
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
		/// Name LstAgrSite
		/// Description LstAgrSite
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_AAGN">Agreement</param>
		/// <param name="m3_CUPL">Customer site</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrSiteResponse></returns>
		/// <exception cref="M3Exception<LstAgrSiteResponse>"></exception>
		public async Task<M3Response<LstAgrSiteResponse>> LstAgrSite(
			string m3_AAGN = null, 
			string m3_CUPL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgrSite",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_AAGN))
				request.WithQueryParameter("AAGN", m3_AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUPL))
				request.WithQueryParameter("CUPL", m3_CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());

			// Execute the request
			var result = await Execute<LstAgrSiteResponse>(
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
		/// Name UpdAgrSite
		/// Description UpdAgrSite
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_AAGN">Agreement</param>
		/// <param name="m3_CUPL">Customer site</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_VADF">Valid from</param>
		/// <param name="m3_VADT">Valid to</param>
		/// <param name="m3_LSCD">Service stop</param>
		/// <param name="m3_ILCD">Invoice block</param>
		/// <param name="m3_INVM">Invoicing method</param>
		/// <param name="m3_IIDF">Start date - invoicing range</param>
		/// <param name="m3_IIDT">End date - invoicing range</param>
		/// <param name="m3_IIYR">Invoicing interval - years</param>
		/// <param name="m3_IIMO">Invoicing interval - months</param>
		/// <param name="m3_IIDA">Invoicing interval - days</param>
		/// <param name="m3_NODT">Next invoice date</param>
		/// <param name="m3_IVNO">Invoice number</param>
		/// <param name="m3_IFDT">First invoice date</param>
		/// <param name="m3_AIT1">Accounting dimension 1</param>
		/// <param name="m3_AIT2">Accounting dimension 2</param>
		/// <param name="m3_AIT3">Accounting dimension 3</param>
		/// <param name="m3_AIT4">Accounting dimension 4</param>
		/// <param name="m3_AIT5">Accounting dimension 5</param>
		/// <param name="m3_AIT6">Accounting dimension 6</param>
		/// <param name="m3_AIT7">Accounting dimension 7</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_INPX">Invoice prefix</param>
		/// <param name="m3_EXIN">Extended invoice number</param>
		/// <param name="m3_SRES">Service manager</param>
		/// <param name="m3_TEC1">Technician</param>
		/// <param name="m3_TEC2">Technician</param>
		/// <param name="m3_DIST">Number of kilometer</param>
		/// <param name="m3_LZON">Service zone</param>
		/// <param name="m3_TRTI">Planned travel time</param>
		/// <param name="m3_TVCD">Travel type</param>
		/// <param name="m3_APTM">Response time</param>
		/// <param name="m3_FUCD">Follow-up code</param>
		/// <param name="m3_FUDT">Follow-up date</param>
		/// <param name="m3_OFNO">Quotation number</param>
		/// <param name="m3_WOSC">Work schedule</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_PRTX">Text</param>
		/// <param name="m3_POTX">Retrieve purchase order line text</param>
		/// <param name="m3_DOWT">Downtime</param>
		/// <param name="m3_CFJ1">User-defined field 1 - serv agreement</param>
		/// <param name="m3_CFJ2">User-defined field 2 - serv agreement</param>
		/// <param name="m3_CFJ3">User-defined field 3 - serv agreement</param>
		/// <param name="m3_CFJ4">User-defined field 4 - serv agreement</param>
		/// <param name="m3_CFJ5">User-defined field 5 - serv agreement</param>
		/// <param name="m3_CFJ6">User-defined field 6 - serv agreement</param>
		/// <param name="m3_CFJ7">User-defined field 7 - serv agreement</param>
		/// <param name="m3_CFJ8">User-defined field 8 - serv agreement</param>
		/// <param name="m3_CFJ9">User-defined field 9 - serv agreement</param>
		/// <param name="m3_CFJ0">User-defined field 10 - serv agreement</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_MBII">Meter-based invoicing indicator</param>
		/// <param name="m3_ITPE">Invoice type</param>
		/// <param name="m3_AMTN">Curve</param>
		/// <param name="m3_NPAM">Number of periods</param>
		/// <param name="m3_RCYR">Reconciliation interval - years</param>
		/// <param name="m3_RCMO">Reconciliation interval - months</param>
		/// <param name="m3_RCDY">Reconciliation interval - days</param>
		/// <param name="m3_MRED">Reconciliation days</param>
		/// <param name="m3_OPVR">Operation plan version</param>
		/// <param name="m3_OUMP">Overusage meter unit price</param>
		/// <param name="m3_ADP5">Maximum discrepancy % over</param>
		/// <param name="m3_ADP6">Maximum discrepancy % under</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAgrSite(
			string m3_AAGN = null, 
			string m3_CUPL = null, 
			string m3_ADID = null, 
			DateTime? m3_VADF = null, 
			DateTime? m3_VADT = null, 
			int? m3_LSCD = null, 
			int? m3_ILCD = null, 
			string m3_INVM = null, 
			DateTime? m3_IIDF = null, 
			DateTime? m3_IIDT = null, 
			int? m3_IIYR = null, 
			int? m3_IIMO = null, 
			int? m3_IIDA = null, 
			DateTime? m3_NODT = null, 
			int? m3_IVNO = null, 
			DateTime? m3_IFDT = null, 
			string m3_AIT1 = null, 
			string m3_AIT2 = null, 
			string m3_AIT3 = null, 
			string m3_AIT4 = null, 
			string m3_AIT5 = null, 
			string m3_AIT6 = null, 
			string m3_AIT7 = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_ACRF = null, 
			string m3_PYNO = null, 
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_INPX = null, 
			string m3_EXIN = null, 
			string m3_SRES = null, 
			string m3_TEC1 = null, 
			string m3_TEC2 = null, 
			int? m3_DIST = null, 
			int? m3_LZON = null, 
			int? m3_TRTI = null, 
			string m3_TVCD = null, 
			int? m3_APTM = null, 
			string m3_FUCD = null, 
			DateTime? m3_FUDT = null, 
			string m3_OFNO = null, 
			int? m3_WOSC = null, 
			decimal? m3_TXID = null, 
			string m3_PRTX = null, 
			int? m3_POTX = null, 
			int? m3_DOWT = null, 
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
			string m3_STAT = null, 
			int? m3_MBII = null, 
			int? m3_ITPE = null, 
			int? m3_AMTN = null, 
			int? m3_NPAM = null, 
			int? m3_RCYR = null, 
			int? m3_RCMO = null, 
			int? m3_RCDY = null, 
			int? m3_MRED = null, 
			string m3_OPVR = null, 
			decimal? m3_OUMP = null, 
			int? m3_ADP5 = null, 
			int? m3_ADP6 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdAgrSite",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_AAGN))
				request.WithQueryParameter("AAGN", m3_AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUPL))
				request.WithQueryParameter("CUPL", m3_CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (m3_VADF.HasValue)
				request.WithQueryParameter("VADF", m3_VADF.Value.ToM3String());
			if (m3_VADT.HasValue)
				request.WithQueryParameter("VADT", m3_VADT.Value.ToM3String());
			if (m3_LSCD.HasValue)
				request.WithQueryParameter("LSCD", m3_LSCD.Value.ToString());
			if (m3_ILCD.HasValue)
				request.WithQueryParameter("ILCD", m3_ILCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INVM))
				request.WithQueryParameter("INVM", m3_INVM.Trim());
			if (m3_IIDF.HasValue)
				request.WithQueryParameter("IIDF", m3_IIDF.Value.ToM3String());
			if (m3_IIDT.HasValue)
				request.WithQueryParameter("IIDT", m3_IIDT.Value.ToM3String());
			if (m3_IIYR.HasValue)
				request.WithQueryParameter("IIYR", m3_IIYR.Value.ToString());
			if (m3_IIMO.HasValue)
				request.WithQueryParameter("IIMO", m3_IIMO.Value.ToString());
			if (m3_IIDA.HasValue)
				request.WithQueryParameter("IIDA", m3_IIDA.Value.ToString());
			if (m3_NODT.HasValue)
				request.WithQueryParameter("NODT", m3_NODT.Value.ToM3String());
			if (m3_IVNO.HasValue)
				request.WithQueryParameter("IVNO", m3_IVNO.Value.ToString());
			if (m3_IFDT.HasValue)
				request.WithQueryParameter("IFDT", m3_IFDT.Value.ToM3String());
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
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INPX))
				request.WithQueryParameter("INPX", m3_INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXIN))
				request.WithQueryParameter("EXIN", m3_EXIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRES))
				request.WithQueryParameter("SRES", m3_SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEC1))
				request.WithQueryParameter("TEC1", m3_TEC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEC2))
				request.WithQueryParameter("TEC2", m3_TEC2.Trim());
			if (m3_DIST.HasValue)
				request.WithQueryParameter("DIST", m3_DIST.Value.ToString());
			if (m3_LZON.HasValue)
				request.WithQueryParameter("LZON", m3_LZON.Value.ToString());
			if (m3_TRTI.HasValue)
				request.WithQueryParameter("TRTI", m3_TRTI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TVCD))
				request.WithQueryParameter("TVCD", m3_TVCD.Trim());
			if (m3_APTM.HasValue)
				request.WithQueryParameter("APTM", m3_APTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FUCD))
				request.WithQueryParameter("FUCD", m3_FUCD.Trim());
			if (m3_FUDT.HasValue)
				request.WithQueryParameter("FUDT", m3_FUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_OFNO))
				request.WithQueryParameter("OFNO", m3_OFNO.Trim());
			if (m3_WOSC.HasValue)
				request.WithQueryParameter("WOSC", m3_WOSC.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRTX))
				request.WithQueryParameter("PRTX", m3_PRTX.Trim());
			if (m3_POTX.HasValue)
				request.WithQueryParameter("POTX", m3_POTX.Value.ToString());
			if (m3_DOWT.HasValue)
				request.WithQueryParameter("DOWT", m3_DOWT.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_MBII.HasValue)
				request.WithQueryParameter("MBII", m3_MBII.Value.ToString());
			if (m3_ITPE.HasValue)
				request.WithQueryParameter("ITPE", m3_ITPE.Value.ToString());
			if (m3_AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3_AMTN.Value.ToString());
			if (m3_NPAM.HasValue)
				request.WithQueryParameter("NPAM", m3_NPAM.Value.ToString());
			if (m3_RCYR.HasValue)
				request.WithQueryParameter("RCYR", m3_RCYR.Value.ToString());
			if (m3_RCMO.HasValue)
				request.WithQueryParameter("RCMO", m3_RCMO.Value.ToString());
			if (m3_RCDY.HasValue)
				request.WithQueryParameter("RCDY", m3_RCDY.Value.ToString());
			if (m3_MRED.HasValue)
				request.WithQueryParameter("MRED", m3_MRED.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OPVR))
				request.WithQueryParameter("OPVR", m3_OPVR.Trim());
			if (m3_OUMP.HasValue)
				request.WithQueryParameter("OUMP", m3_OUMP.Value.ToString());
			if (m3_ADP5.HasValue)
				request.WithQueryParameter("ADP5", m3_ADP5.Value.ToString());
			if (m3_ADP6.HasValue)
				request.WithQueryParameter("ADP6", m3_ADP6.Value.ToString());

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
