/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAgrSite
		/// Description AddAgrSite
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3AAGN">Agreement (Required)</param>
		/// <param name="m3CUPL">Customer site (Required)</param>
		/// <param name="m3ADID">Address number (Required)</param>
		/// <param name="m3VADF">Valid from</param>
		/// <param name="m3VADT">Valid to</param>
		/// <param name="m3LSCD">Service stop</param>
		/// <param name="m3ILCD">Invoice block</param>
		/// <param name="m3INVM">Invoicing method</param>
		/// <param name="m3IIDF">Start date - invoicing range</param>
		/// <param name="m3IIDT">End date - invoicing range</param>
		/// <param name="m3IIYR">Invoicing interval - years</param>
		/// <param name="m3IIMO">Invoicing interval - months</param>
		/// <param name="m3IIDA">Invoicing interval - days</param>
		/// <param name="m3NODT">Next invoice date</param>
		/// <param name="m3IVNO">Invoice number</param>
		/// <param name="m3IFDT">First invoice date</param>
		/// <param name="m3AIT1">Accounting dimension 1</param>
		/// <param name="m3AIT2">Accounting dimension 2</param>
		/// <param name="m3AIT3">Accounting dimension 3</param>
		/// <param name="m3AIT4">Accounting dimension 4</param>
		/// <param name="m3AIT5">Accounting dimension 5</param>
		/// <param name="m3AIT6">Accounting dimension 6</param>
		/// <param name="m3AIT7">Accounting dimension 7</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3INPX">Invoice prefix</param>
		/// <param name="m3EXIN">Extended invoice number</param>
		/// <param name="m3SRES">Service manager</param>
		/// <param name="m3TEC1">Technician</param>
		/// <param name="m3TEC2">Technician</param>
		/// <param name="m3DIST">Number of kilometer</param>
		/// <param name="m3LZON">Service zone</param>
		/// <param name="m3TRTI">Planned travel time</param>
		/// <param name="m3TVCD">Travel type</param>
		/// <param name="m3APTM">Response time</param>
		/// <param name="m3FUCD">Follow-up code</param>
		/// <param name="m3FUDT">Follow-up date</param>
		/// <param name="m3OFNO">Quotation number</param>
		/// <param name="m3WOSC">Work schedule</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3PRTX">Text</param>
		/// <param name="m3POTX">Retrieve purchase order line text</param>
		/// <param name="m3DOWT">Downtime</param>
		/// <param name="m3CFJ1">User-defined field 1 - serv agreement</param>
		/// <param name="m3CFJ2">User-defined field 2 - serv agreement</param>
		/// <param name="m3CFJ3">User-defined field 3 - serv agreement</param>
		/// <param name="m3CFJ4">User-defined field 4 - serv agreement</param>
		/// <param name="m3CFJ5">User-defined field 5 - serv agreement</param>
		/// <param name="m3CFJ6">User-defined field 6 - serv agreement</param>
		/// <param name="m3CFJ7">User-defined field 7 - serv agreement</param>
		/// <param name="m3CFJ8">User-defined field 8 - serv agreement</param>
		/// <param name="m3CFJ9">User-defined field 9 - serv agreement</param>
		/// <param name="m3CFJ0">User-defined field 10 - serv agreement</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3MBII">Meter-based invoicing indicator</param>
		/// <param name="m3ITPE">Invoice type</param>
		/// <param name="m3AMTN">Curve</param>
		/// <param name="m3NPAM">Number of periods</param>
		/// <param name="m3RCYR">Reconciliation interval - years</param>
		/// <param name="m3RCMO">Reconciliation interval - months</param>
		/// <param name="m3RCDY">Reconciliation interval - days</param>
		/// <param name="m3MRED">Reconciliation days</param>
		/// <param name="m3OPVR">Operation plan version</param>
		/// <param name="m3OUMP">Overusage meter unit price</param>
		/// <param name="m3ADP5">Maximum discrepancy % over</param>
		/// <param name="m3ADP6">Maximum discrepancy % under</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAgrSite(
			string m3AAGN, 
			string m3CUPL, 
			string m3ADID, 
			DateTime? m3VADF = null, 
			DateTime? m3VADT = null, 
			int? m3LSCD = null, 
			int? m3ILCD = null, 
			string m3INVM = null, 
			DateTime? m3IIDF = null, 
			DateTime? m3IIDT = null, 
			int? m3IIYR = null, 
			int? m3IIMO = null, 
			int? m3IIDA = null, 
			DateTime? m3NODT = null, 
			int? m3IVNO = null, 
			DateTime? m3IFDT = null, 
			string m3AIT1 = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3ACRF = null, 
			string m3PYNO = null, 
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3INPX = null, 
			string m3EXIN = null, 
			string m3SRES = null, 
			string m3TEC1 = null, 
			string m3TEC2 = null, 
			int? m3DIST = null, 
			int? m3LZON = null, 
			int? m3TRTI = null, 
			string m3TVCD = null, 
			int? m3APTM = null, 
			string m3FUCD = null, 
			DateTime? m3FUDT = null, 
			string m3OFNO = null, 
			int? m3WOSC = null, 
			decimal? m3TXID = null, 
			string m3PRTX = null, 
			int? m3POTX = null, 
			int? m3DOWT = null, 
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
			string m3STAT = null, 
			int? m3MBII = null, 
			int? m3ITPE = null, 
			int? m3AMTN = null, 
			int? m3NPAM = null, 
			int? m3RCYR = null, 
			int? m3RCMO = null, 
			int? m3RCDY = null, 
			int? m3MRED = null, 
			string m3OPVR = null, 
			decimal? m3OUMP = null, 
			int? m3ADP5 = null, 
			int? m3ADP6 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddAgrSite",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));
			if (string.IsNullOrWhiteSpace(m3CUPL))
				throw new ArgumentNullException(nameof(m3CUPL));
			if (string.IsNullOrWhiteSpace(m3ADID))
				throw new ArgumentNullException(nameof(m3ADID));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim())
				.WithQueryParameter("CUPL", m3CUPL.Trim())
				.WithQueryParameter("ADID", m3ADID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3VADF.HasValue)
				request.WithQueryParameter("VADF", m3VADF.Value.ToM3String());
			if (m3VADT.HasValue)
				request.WithQueryParameter("VADT", m3VADT.Value.ToM3String());
			if (m3LSCD.HasValue)
				request.WithQueryParameter("LSCD", m3LSCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ILCD.HasValue)
				request.WithQueryParameter("ILCD", m3ILCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INVM))
				request.WithQueryParameter("INVM", m3INVM.Trim());
			if (m3IIDF.HasValue)
				request.WithQueryParameter("IIDF", m3IIDF.Value.ToM3String());
			if (m3IIDT.HasValue)
				request.WithQueryParameter("IIDT", m3IIDT.Value.ToM3String());
			if (m3IIYR.HasValue)
				request.WithQueryParameter("IIYR", m3IIYR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIMO.HasValue)
				request.WithQueryParameter("IIMO", m3IIMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIDA.HasValue)
				request.WithQueryParameter("IIDA", m3IIDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NODT.HasValue)
				request.WithQueryParameter("NODT", m3NODT.Value.ToM3String());
			if (m3IVNO.HasValue)
				request.WithQueryParameter("IVNO", m3IVNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IFDT.HasValue)
				request.WithQueryParameter("IFDT", m3IFDT.Value.ToM3String());
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
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INPX))
				request.WithQueryParameter("INPX", m3INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXIN))
				request.WithQueryParameter("EXIN", m3EXIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRES))
				request.WithQueryParameter("SRES", m3SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEC1))
				request.WithQueryParameter("TEC1", m3TEC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEC2))
				request.WithQueryParameter("TEC2", m3TEC2.Trim());
			if (m3DIST.HasValue)
				request.WithQueryParameter("DIST", m3DIST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LZON.HasValue)
				request.WithQueryParameter("LZON", m3LZON.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRTI.HasValue)
				request.WithQueryParameter("TRTI", m3TRTI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TVCD))
				request.WithQueryParameter("TVCD", m3TVCD.Trim());
			if (m3APTM.HasValue)
				request.WithQueryParameter("APTM", m3APTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FUCD))
				request.WithQueryParameter("FUCD", m3FUCD.Trim());
			if (m3FUDT.HasValue)
				request.WithQueryParameter("FUDT", m3FUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3OFNO))
				request.WithQueryParameter("OFNO", m3OFNO.Trim());
			if (m3WOSC.HasValue)
				request.WithQueryParameter("WOSC", m3WOSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRTX))
				request.WithQueryParameter("PRTX", m3PRTX.Trim());
			if (m3POTX.HasValue)
				request.WithQueryParameter("POTX", m3POTX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DOWT.HasValue)
				request.WithQueryParameter("DOWT", m3DOWT.Value.ToString(CultureInfo.CurrentCulture));
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
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3MBII.HasValue)
				request.WithQueryParameter("MBII", m3MBII.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ITPE.HasValue)
				request.WithQueryParameter("ITPE", m3ITPE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3AMTN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NPAM.HasValue)
				request.WithQueryParameter("NPAM", m3NPAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RCYR.HasValue)
				request.WithQueryParameter("RCYR", m3RCYR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RCMO.HasValue)
				request.WithQueryParameter("RCMO", m3RCMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RCDY.HasValue)
				request.WithQueryParameter("RCDY", m3RCDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MRED.HasValue)
				request.WithQueryParameter("MRED", m3MRED.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OPVR))
				request.WithQueryParameter("OPVR", m3OPVR.Trim());
			if (m3OUMP.HasValue)
				request.WithQueryParameter("OUMP", m3OUMP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADP5.HasValue)
				request.WithQueryParameter("ADP5", m3ADP5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADP6.HasValue)
				request.WithQueryParameter("ADP6", m3ADP6.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltAgrSite
		/// Description DltAgrSite
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3AAGN">Agreement (Required)</param>
		/// <param name="m3CUPL">Customer site (Required)</param>
		/// <param name="m3ADID">Address number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAgrSite(
			string m3AAGN, 
			string m3CUPL, 
			string m3ADID, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltAgrSite",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));
			if (string.IsNullOrWhiteSpace(m3CUPL))
				throw new ArgumentNullException(nameof(m3CUPL));
			if (string.IsNullOrWhiteSpace(m3ADID))
				throw new ArgumentNullException(nameof(m3ADID));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim())
				.WithQueryParameter("CUPL", m3CUPL.Trim())
				.WithQueryParameter("ADID", m3ADID.Trim());

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
		/// Name GetAgrSite
		/// Description GetAgrSite
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3AAGN">Agreement (Required)</param>
		/// <param name="m3CUPL">Customer site (Required)</param>
		/// <param name="m3ADID">Address number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgrSiteResponse></returns>
		/// <exception cref="M3Exception<GetAgrSiteResponse>"></exception>
		public async Task<M3Response<GetAgrSiteResponse>> GetAgrSite(
			string m3AAGN, 
			string m3CUPL, 
			string m3ADID, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetAgrSite",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));
			if (string.IsNullOrWhiteSpace(m3CUPL))
				throw new ArgumentNullException(nameof(m3CUPL));
			if (string.IsNullOrWhiteSpace(m3ADID))
				throw new ArgumentNullException(nameof(m3ADID));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim())
				.WithQueryParameter("CUPL", m3CUPL.Trim())
				.WithQueryParameter("ADID", m3ADID.Trim());

			// Execute the request
			var result = await Execute<GetAgrSiteResponse>(
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
		/// Name LstAgrSite
		/// Description LstAgrSite
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3AAGN">Agreement</param>
		/// <param name="m3CUPL">Customer site</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrSiteResponse></returns>
		/// <exception cref="M3Exception<LstAgrSiteResponse>"></exception>
		public async Task<M3Response<LstAgrSiteResponse>> LstAgrSite(
			string m3AAGN = null, 
			string m3CUPL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAgrSite",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AAGN))
				request.WithQueryParameter("AAGN", m3AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUPL))
				request.WithQueryParameter("CUPL", m3CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());

			// Execute the request
			var result = await Execute<LstAgrSiteResponse>(
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
		/// Name UpdAgrSite
		/// Description UpdAgrSite
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3AAGN">Agreement</param>
		/// <param name="m3CUPL">Customer site</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3VADF">Valid from</param>
		/// <param name="m3VADT">Valid to</param>
		/// <param name="m3LSCD">Service stop</param>
		/// <param name="m3ILCD">Invoice block</param>
		/// <param name="m3INVM">Invoicing method</param>
		/// <param name="m3IIDF">Start date - invoicing range</param>
		/// <param name="m3IIDT">End date - invoicing range</param>
		/// <param name="m3IIYR">Invoicing interval - years</param>
		/// <param name="m3IIMO">Invoicing interval - months</param>
		/// <param name="m3IIDA">Invoicing interval - days</param>
		/// <param name="m3NODT">Next invoice date</param>
		/// <param name="m3IVNO">Invoice number</param>
		/// <param name="m3IFDT">First invoice date</param>
		/// <param name="m3AIT1">Accounting dimension 1</param>
		/// <param name="m3AIT2">Accounting dimension 2</param>
		/// <param name="m3AIT3">Accounting dimension 3</param>
		/// <param name="m3AIT4">Accounting dimension 4</param>
		/// <param name="m3AIT5">Accounting dimension 5</param>
		/// <param name="m3AIT6">Accounting dimension 6</param>
		/// <param name="m3AIT7">Accounting dimension 7</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3INPX">Invoice prefix</param>
		/// <param name="m3EXIN">Extended invoice number</param>
		/// <param name="m3SRES">Service manager</param>
		/// <param name="m3TEC1">Technician</param>
		/// <param name="m3TEC2">Technician</param>
		/// <param name="m3DIST">Number of kilometer</param>
		/// <param name="m3LZON">Service zone</param>
		/// <param name="m3TRTI">Planned travel time</param>
		/// <param name="m3TVCD">Travel type</param>
		/// <param name="m3APTM">Response time</param>
		/// <param name="m3FUCD">Follow-up code</param>
		/// <param name="m3FUDT">Follow-up date</param>
		/// <param name="m3OFNO">Quotation number</param>
		/// <param name="m3WOSC">Work schedule</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3PRTX">Text</param>
		/// <param name="m3POTX">Retrieve purchase order line text</param>
		/// <param name="m3DOWT">Downtime</param>
		/// <param name="m3CFJ1">User-defined field 1 - serv agreement</param>
		/// <param name="m3CFJ2">User-defined field 2 - serv agreement</param>
		/// <param name="m3CFJ3">User-defined field 3 - serv agreement</param>
		/// <param name="m3CFJ4">User-defined field 4 - serv agreement</param>
		/// <param name="m3CFJ5">User-defined field 5 - serv agreement</param>
		/// <param name="m3CFJ6">User-defined field 6 - serv agreement</param>
		/// <param name="m3CFJ7">User-defined field 7 - serv agreement</param>
		/// <param name="m3CFJ8">User-defined field 8 - serv agreement</param>
		/// <param name="m3CFJ9">User-defined field 9 - serv agreement</param>
		/// <param name="m3CFJ0">User-defined field 10 - serv agreement</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3MBII">Meter-based invoicing indicator</param>
		/// <param name="m3ITPE">Invoice type</param>
		/// <param name="m3AMTN">Curve</param>
		/// <param name="m3NPAM">Number of periods</param>
		/// <param name="m3RCYR">Reconciliation interval - years</param>
		/// <param name="m3RCMO">Reconciliation interval - months</param>
		/// <param name="m3RCDY">Reconciliation interval - days</param>
		/// <param name="m3MRED">Reconciliation days</param>
		/// <param name="m3OPVR">Operation plan version</param>
		/// <param name="m3OUMP">Overusage meter unit price</param>
		/// <param name="m3ADP5">Maximum discrepancy % over</param>
		/// <param name="m3ADP6">Maximum discrepancy % under</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAgrSite(
			string m3AAGN = null, 
			string m3CUPL = null, 
			string m3ADID = null, 
			DateTime? m3VADF = null, 
			DateTime? m3VADT = null, 
			int? m3LSCD = null, 
			int? m3ILCD = null, 
			string m3INVM = null, 
			DateTime? m3IIDF = null, 
			DateTime? m3IIDT = null, 
			int? m3IIYR = null, 
			int? m3IIMO = null, 
			int? m3IIDA = null, 
			DateTime? m3NODT = null, 
			int? m3IVNO = null, 
			DateTime? m3IFDT = null, 
			string m3AIT1 = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3ACRF = null, 
			string m3PYNO = null, 
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3INPX = null, 
			string m3EXIN = null, 
			string m3SRES = null, 
			string m3TEC1 = null, 
			string m3TEC2 = null, 
			int? m3DIST = null, 
			int? m3LZON = null, 
			int? m3TRTI = null, 
			string m3TVCD = null, 
			int? m3APTM = null, 
			string m3FUCD = null, 
			DateTime? m3FUDT = null, 
			string m3OFNO = null, 
			int? m3WOSC = null, 
			decimal? m3TXID = null, 
			string m3PRTX = null, 
			int? m3POTX = null, 
			int? m3DOWT = null, 
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
			string m3STAT = null, 
			int? m3MBII = null, 
			int? m3ITPE = null, 
			int? m3AMTN = null, 
			int? m3NPAM = null, 
			int? m3RCYR = null, 
			int? m3RCMO = null, 
			int? m3RCDY = null, 
			int? m3MRED = null, 
			string m3OPVR = null, 
			decimal? m3OUMP = null, 
			int? m3ADP5 = null, 
			int? m3ADP6 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdAgrSite",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AAGN))
				request.WithQueryParameter("AAGN", m3AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUPL))
				request.WithQueryParameter("CUPL", m3CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (m3VADF.HasValue)
				request.WithQueryParameter("VADF", m3VADF.Value.ToM3String());
			if (m3VADT.HasValue)
				request.WithQueryParameter("VADT", m3VADT.Value.ToM3String());
			if (m3LSCD.HasValue)
				request.WithQueryParameter("LSCD", m3LSCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ILCD.HasValue)
				request.WithQueryParameter("ILCD", m3ILCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INVM))
				request.WithQueryParameter("INVM", m3INVM.Trim());
			if (m3IIDF.HasValue)
				request.WithQueryParameter("IIDF", m3IIDF.Value.ToM3String());
			if (m3IIDT.HasValue)
				request.WithQueryParameter("IIDT", m3IIDT.Value.ToM3String());
			if (m3IIYR.HasValue)
				request.WithQueryParameter("IIYR", m3IIYR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIMO.HasValue)
				request.WithQueryParameter("IIMO", m3IIMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIDA.HasValue)
				request.WithQueryParameter("IIDA", m3IIDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NODT.HasValue)
				request.WithQueryParameter("NODT", m3NODT.Value.ToM3String());
			if (m3IVNO.HasValue)
				request.WithQueryParameter("IVNO", m3IVNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IFDT.HasValue)
				request.WithQueryParameter("IFDT", m3IFDT.Value.ToM3String());
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
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INPX))
				request.WithQueryParameter("INPX", m3INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXIN))
				request.WithQueryParameter("EXIN", m3EXIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRES))
				request.WithQueryParameter("SRES", m3SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEC1))
				request.WithQueryParameter("TEC1", m3TEC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEC2))
				request.WithQueryParameter("TEC2", m3TEC2.Trim());
			if (m3DIST.HasValue)
				request.WithQueryParameter("DIST", m3DIST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LZON.HasValue)
				request.WithQueryParameter("LZON", m3LZON.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRTI.HasValue)
				request.WithQueryParameter("TRTI", m3TRTI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TVCD))
				request.WithQueryParameter("TVCD", m3TVCD.Trim());
			if (m3APTM.HasValue)
				request.WithQueryParameter("APTM", m3APTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FUCD))
				request.WithQueryParameter("FUCD", m3FUCD.Trim());
			if (m3FUDT.HasValue)
				request.WithQueryParameter("FUDT", m3FUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3OFNO))
				request.WithQueryParameter("OFNO", m3OFNO.Trim());
			if (m3WOSC.HasValue)
				request.WithQueryParameter("WOSC", m3WOSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRTX))
				request.WithQueryParameter("PRTX", m3PRTX.Trim());
			if (m3POTX.HasValue)
				request.WithQueryParameter("POTX", m3POTX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DOWT.HasValue)
				request.WithQueryParameter("DOWT", m3DOWT.Value.ToString(CultureInfo.CurrentCulture));
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
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3MBII.HasValue)
				request.WithQueryParameter("MBII", m3MBII.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ITPE.HasValue)
				request.WithQueryParameter("ITPE", m3ITPE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3AMTN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NPAM.HasValue)
				request.WithQueryParameter("NPAM", m3NPAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RCYR.HasValue)
				request.WithQueryParameter("RCYR", m3RCYR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RCMO.HasValue)
				request.WithQueryParameter("RCMO", m3RCMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RCDY.HasValue)
				request.WithQueryParameter("RCDY", m3RCDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MRED.HasValue)
				request.WithQueryParameter("MRED", m3MRED.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OPVR))
				request.WithQueryParameter("OPVR", m3OPVR.Trim());
			if (m3OUMP.HasValue)
				request.WithQueryParameter("OUMP", m3OUMP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADP5.HasValue)
				request.WithQueryParameter("ADP5", m3ADP5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADP6.HasValue)
				request.WithQueryParameter("ADP6", m3ADP6.Value.ToString(CultureInfo.CurrentCulture));

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
