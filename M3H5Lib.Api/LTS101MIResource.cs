/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.LTS101MI;
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
	/// Name: LTS101MI
	/// Component Name: Cust Sales and Serv
	/// Description: Api: LTR Agreement line
	/// Version Release: 14.x
	///</summary>
	public partial class LTS101MIResource : M3BaseResourceEndpoint
	{
		public LTS101MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "LTS101MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddLTRHead
		/// Description This transaction creates LTR Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3AOTP">Agreement order type (Required)</param>
		/// <param name="m3AGCN">Agreement customer (Required)</param>
		/// <param name="m3NOPR">Number of periods (Required)</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3CUPL">Customer site</param>
		/// <param name="m3SAID">Address number</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3USID">User</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3SMCD">Salesperson</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3AGRE">LTR agreement responsible</param>
		/// <param name="m3SRES">Service manager</param>
		/// <param name="m3ARCC">Reason code - created agreement</param>
		/// <param name="m3ARCT">Reason code - terminated agreement</param>
		/// <param name="m3AGRC">LTR agreement conditions</param>
		/// <param name="m3PKIT">Kit price printout</param>
		/// <param name="m3AGTP">Agreement type</param>
		/// <param name="m3IIYR">Invoicing interval - years</param>
		/// <param name="m3IIMO">Invoicing interval - months</param>
		/// <param name="m3IIWE">Invoicing interval - weeks</param>
		/// <param name="m3IXCD">Price index</param>
		/// <param name="m3IXYR">Index interval years</param>
		/// <param name="m3IXMO">Index interval months</param>
		/// <param name="m3IXWE">Index interval weeks</param>
		/// <param name="m3ANOS">Number of shifts</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddLTRHeadResponse></returns>
		/// <exception cref="M3Exception<AddLTRHeadResponse>"></exception>
		public async Task<M3Response<AddLTRHeadResponse>> AddLTRHead(
			string m3FACI, 
			string m3AOTP, 
			string m3AGCN, 
			int m3NOPR, 
			string m3AGNB = null, 
			string m3CUPL = null, 
			string m3SAID = null, 
			string m3PYNO = null, 
			DateTime? m3FVDT = null, 
			string m3CUOR = null, 
			string m3USID = null, 
			string m3TEPY = null, 
			string m3SMCD = null, 
			string m3CUCD = null, 
			string m3AGRE = null, 
			string m3SRES = null, 
			string m3ARCC = null, 
			string m3ARCT = null, 
			string m3AGRC = null, 
			int? m3PKIT = null, 
			string m3AGTP = null, 
			int? m3IIYR = null, 
			int? m3IIMO = null, 
			int? m3IIWE = null, 
			string m3IXCD = null, 
			int? m3IXYR = null, 
			int? m3IXMO = null, 
			int? m3IXWE = null, 
			int? m3ANOS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLTRHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3AOTP))
				throw new ArgumentNullException(nameof(m3AOTP));
			if (string.IsNullOrWhiteSpace(m3AGCN))
				throw new ArgumentNullException(nameof(m3AGCN));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("AOTP", m3AOTP.Trim())
				.WithQueryParameter("AGCN", m3AGCN.Trim())
				.WithQueryParameter("NOPR", m3NOPR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUPL))
				request.WithQueryParameter("CUPL", m3CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SAID))
				request.WithQueryParameter("SAID", m3SAID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMCD))
				request.WithQueryParameter("SMCD", m3SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGRE))
				request.WithQueryParameter("AGRE", m3AGRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRES))
				request.WithQueryParameter("SRES", m3SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARCC))
				request.WithQueryParameter("ARCC", m3ARCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARCT))
				request.WithQueryParameter("ARCT", m3ARCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGRC))
				request.WithQueryParameter("AGRC", m3AGRC.Trim());
			if (m3PKIT.HasValue)
				request.WithQueryParameter("PKIT", m3PKIT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AGTP))
				request.WithQueryParameter("AGTP", m3AGTP.Trim());
			if (m3IIYR.HasValue)
				request.WithQueryParameter("IIYR", m3IIYR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIMO.HasValue)
				request.WithQueryParameter("IIMO", m3IIMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIWE.HasValue)
				request.WithQueryParameter("IIWE", m3IIWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3IXCD))
				request.WithQueryParameter("IXCD", m3IXCD.Trim());
			if (m3IXYR.HasValue)
				request.WithQueryParameter("IXYR", m3IXYR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IXMO.HasValue)
				request.WithQueryParameter("IXMO", m3IXMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IXWE.HasValue)
				request.WithQueryParameter("IXWE", m3IXWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ANOS.HasValue)
				request.WithQueryParameter("ANOS", m3ANOS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddLTRHeadResponse>(
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
		/// Name AddLeaseCond
		/// Description This transaction creates Leasing Cond
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3NOPR">Number of periods (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3CMPP">Months/period (Required)</param>
		/// <param name="m3CSPR">Customer price (Required)</param>
		/// <param name="m3INTT">Interest type (Required)</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3SBNO">Subnumber</param>
		/// <param name="m3TX25">Text</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3INVM">Invoicing method</param>
		/// <param name="m3RESV">Residual value</param>
		/// <param name="m3REPE">Residual %</param>
		/// <param name="m3INPE">Interest rate</param>
		/// <param name="m3RENT">Rent amount</param>
		/// <param name="m3INLL">Minimun variable interest rate</param>
		/// <param name="m3INTH">Interest threshold value</param>
		/// <param name="m3FFA1">User-defined field 1 alfa</param>
		/// <param name="m3FFA2">User-defined field 1 alfa</param>
		/// <param name="m3FFA3">User-defined field 1 alfa</param>
		/// <param name="m3FFA4">User-defined field 1 alfa</param>
		/// <param name="m3FFA5">User-defined field 1 alfa</param>
		/// <param name="m3FFA6">User-defined field 1 alfa</param>
		/// <param name="m3FFA7">User-defined field 1 alfa</param>
		/// <param name="m3FFA8">User-defined field 1 alfa</param>
		/// <param name="m3FFA9">User-defined field 1 alfa</param>
		/// <param name="m3FFA0">User-defined field 1 alfa</param>
		/// <param name="m3FFN1">User-defined field 1 numeric</param>
		/// <param name="m3FFN2">User-defined field 1 numeric</param>
		/// <param name="m3FFN3">User-defined field 1 numeric</param>
		/// <param name="m3FFN4">User-defined field 1 numeric</param>
		/// <param name="m3FFN5">User-defined field 1 numeric</param>
		/// <param name="m3FFN6">User-defined field 1 numeric</param>
		/// <param name="m3FFN7">User-defined field 1 numeric</param>
		/// <param name="m3FFN8">User-defined field 1 numeric</param>
		/// <param name="m3FFN9">User-defined field 1 numeric</param>
		/// <param name="m3FFN0">User-defined field 1 numeric</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLeaseCond(
			string m3AGNB, 
			int m3PONR, 
			int m3POSX, 
			string m3ITNO, 
			int m3NOPR, 
			DateTime m3FVDT, 
			int m3CMPP, 
			decimal m3CSPR, 
			string m3INTT, 
			string m3BANO = null, 
			int? m3SBNO = null, 
			string m3TX25 = null, 
			string m3STAT = null, 
			string m3INVM = null, 
			decimal? m3RESV = null, 
			int? m3REPE = null, 
			decimal? m3INPE = null, 
			decimal? m3RENT = null, 
			decimal? m3INLL = null, 
			int? m3INTH = null, 
			string m3FFA1 = null, 
			string m3FFA2 = null, 
			string m3FFA3 = null, 
			string m3FFA4 = null, 
			string m3FFA5 = null, 
			string m3FFA6 = null, 
			string m3FFA7 = null, 
			string m3FFA8 = null, 
			string m3FFA9 = null, 
			string m3FFA0 = null, 
			decimal? m3FFN1 = null, 
			decimal? m3FFN2 = null, 
			decimal? m3FFN3 = null, 
			decimal? m3FFN4 = null, 
			decimal? m3FFN5 = null, 
			decimal? m3FFN6 = null, 
			decimal? m3FFN7 = null, 
			decimal? m3FFN8 = null, 
			decimal? m3FFN9 = null, 
			decimal? m3FFN0 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLeaseCond",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3INTT))
				throw new ArgumentNullException(nameof(m3INTT));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("POSX", m3POSX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("NOPR", m3NOPR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FVDT", m3FVDT.ToM3String())
				.WithQueryParameter("CMPP", m3CMPP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CSPR", m3CSPR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("INTT", m3INTT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3SBNO.HasValue)
				request.WithQueryParameter("SBNO", m3SBNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX25))
				request.WithQueryParameter("TX25", m3TX25.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3INVM))
				request.WithQueryParameter("INVM", m3INVM.Trim());
			if (m3RESV.HasValue)
				request.WithQueryParameter("RESV", m3RESV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REPE.HasValue)
				request.WithQueryParameter("REPE", m3REPE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INPE.HasValue)
				request.WithQueryParameter("INPE", m3INPE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RENT.HasValue)
				request.WithQueryParameter("RENT", m3RENT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INLL.HasValue)
				request.WithQueryParameter("INLL", m3INLL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INTH.HasValue)
				request.WithQueryParameter("INTH", m3INTH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FFA1))
				request.WithQueryParameter("FFA1", m3FFA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA2))
				request.WithQueryParameter("FFA2", m3FFA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA3))
				request.WithQueryParameter("FFA3", m3FFA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA4))
				request.WithQueryParameter("FFA4", m3FFA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA5))
				request.WithQueryParameter("FFA5", m3FFA5.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA6))
				request.WithQueryParameter("FFA6", m3FFA6.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA7))
				request.WithQueryParameter("FFA7", m3FFA7.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA8))
				request.WithQueryParameter("FFA8", m3FFA8.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA9))
				request.WithQueryParameter("FFA9", m3FFA9.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA0))
				request.WithQueryParameter("FFA0", m3FFA0.Trim());
			if (m3FFN1.HasValue)
				request.WithQueryParameter("FFN1", m3FFN1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN2.HasValue)
				request.WithQueryParameter("FFN2", m3FFN2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN3.HasValue)
				request.WithQueryParameter("FFN3", m3FFN3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN4.HasValue)
				request.WithQueryParameter("FFN4", m3FFN4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN5.HasValue)
				request.WithQueryParameter("FFN5", m3FFN5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN6.HasValue)
				request.WithQueryParameter("FFN6", m3FFN6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN7.HasValue)
				request.WithQueryParameter("FFN7", m3FFN7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN8.HasValue)
				request.WithQueryParameter("FFN8", m3FFN8.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN9.HasValue)
				request.WithQueryParameter("FFN9", m3FFN9.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN0.HasValue)
				request.WithQueryParameter("FFN0", m3FFN0.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddLeasingLine
		/// Description This transaction creates Leasing Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3NOPR">Number of periods (Required)</param>
		/// <param name="m3INVM">Invoicing method (Required)</param>
		/// <param name="m3FWHL">From warehouse (Required)</param>
		/// <param name="m3TWHL">To warehouse (Required)</param>
		/// <param name="m3CUPL">Customer site</param>
		/// <param name="m3SAID">Address number</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3SERI">Serial number</param>
		/// <param name="m3AGTP">Agreement type</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3SRES">Service manager</param>
		/// <param name="m3SMCD">Salesperson</param>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3ETDT">Current valid to</param>
		/// <param name="m3SIDT">Invoicing start date</param>
		/// <param name="m3EIDT">Invoicing end date</param>
		/// <param name="m3NODT">Next invoice date</param>
		/// <param name="m3IIDF">Start date - invoicing range</param>
		/// <param name="m3IIDT">End date - invoicing range</param>
		/// <param name="m3IIYR">Invoicing interval - years</param>
		/// <param name="m3IIMO">Invoicing interval - months</param>
		/// <param name="m3IIWE">Invoicing interval - weeks</param>
		/// <param name="m3IXYR">Index interval years</param>
		/// <param name="m3IXMO">Index interval months</param>
		/// <param name="m3IXWE">Index interval weeks</param>
		/// <param name="m3IXVF">Valid from</param>
		/// <param name="m3IXVT">Valid to</param>
		/// <param name="m3SPCO">Split code - invoicing</param>
		/// <param name="m3ANOS">Number of shifts</param>
		/// <param name="m3AHLD">Hold code</param>
		/// <param name="m3ARCC">Reason code - created agreement</param>
		/// <param name="m3ARCT">Reason code - terminated agreement</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3DMOD">Delivery method</param>
		/// <param name="m3CMOD">Delivery method - return</param>
		/// <param name="m3DLDT">Planned delivery date</param>
		/// <param name="m3DETH">Time of departure - hours</param>
		/// <param name="m3DETM">Time of departure - minutes</param>
		/// <param name="m3CODT">Confirmed Delivary date</param>
		/// <param name="m3COTH">Pickup time hours</param>
		/// <param name="m3COTM">Pickup minutes</param>
		/// <param name="m3DTED">Delivery terms</param>
		/// <param name="m3CTED">Delivery terms</param>
		/// <param name="m3DEFO">Delivery ordered by</param>
		/// <param name="m3CLFR">Rental return ordered by</param>
		/// <param name="m3DEOD">Delivery order date</param>
		/// <param name="m3COOD">Rental return order date</param>
		/// <param name="m3DEFA">Delivery freight agreement number</param>
		/// <param name="m3CLFA">Freight agreement number - rental return</param>
		/// <param name="m3AIT1">Accounting dimension 1</param>
		/// <param name="m3AIT2">Accounting dimension 2</param>
		/// <param name="m3AIT3">Accounting dimension 3</param>
		/// <param name="m3AIT4">Accounting dimension 4</param>
		/// <param name="m3AIT5">Accounting dimension 5</param>
		/// <param name="m3AIT6">Accounting dimension 6</param>
		/// <param name="m3AIT7">Accounting dimension 7</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddLeasingLineResponse></returns>
		/// <exception cref="M3Exception<AddLeasingLineResponse>"></exception>
		public async Task<M3Response<AddLeasingLineResponse>> AddLeasingLine(
			string m3AGNB, 
			string m3ITNO, 
			DateTime m3FVDT, 
			int m3NOPR, 
			string m3INVM, 
			string m3FWHL, 
			string m3TWHL, 
			string m3CUPL = null, 
			string m3SAID = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
			string m3SERI = null, 
			string m3AGTP = null, 
			string m3PYNO = null, 
			string m3SRES = null, 
			string m3SMCD = null, 
			string m3ORNO = null, 
			DateTime? m3ETDT = null, 
			DateTime? m3SIDT = null, 
			DateTime? m3EIDT = null, 
			DateTime? m3NODT = null, 
			DateTime? m3IIDF = null, 
			DateTime? m3IIDT = null, 
			int? m3IIYR = null, 
			int? m3IIMO = null, 
			int? m3IIWE = null, 
			int? m3IXYR = null, 
			int? m3IXMO = null, 
			int? m3IXWE = null, 
			DateTime? m3IXVF = null, 
			DateTime? m3IXVT = null, 
			string m3SPCO = null, 
			int? m3ANOS = null, 
			string m3AHLD = null, 
			string m3ARCC = null, 
			string m3ARCT = null, 
			string m3BREM = null, 
			string m3DMOD = null, 
			string m3CMOD = null, 
			DateTime? m3DLDT = null, 
			int? m3DETH = null, 
			int? m3DETM = null, 
			DateTime? m3CODT = null, 
			int? m3COTH = null, 
			int? m3COTM = null, 
			string m3DTED = null, 
			string m3CTED = null, 
			string m3DEFO = null, 
			string m3CLFR = null, 
			DateTime? m3DEOD = null, 
			DateTime? m3COOD = null, 
			string m3DEFA = null, 
			string m3CLFA = null, 
			string m3AIT1 = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
			string m3PROJ = null, 
			string m3ACRF = null, 
			string m3ELNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLeasingLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3INVM))
				throw new ArgumentNullException(nameof(m3INVM));
			if (string.IsNullOrWhiteSpace(m3FWHL))
				throw new ArgumentNullException(nameof(m3FWHL));
			if (string.IsNullOrWhiteSpace(m3TWHL))
				throw new ArgumentNullException(nameof(m3TWHL));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String())
				.WithQueryParameter("NOPR", m3NOPR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("INVM", m3INVM.Trim())
				.WithQueryParameter("FWHL", m3FWHL.Trim())
				.WithQueryParameter("TWHL", m3TWHL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUPL))
				request.WithQueryParameter("CUPL", m3CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SAID))
				request.WithQueryParameter("SAID", m3SAID.Trim());
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SERI))
				request.WithQueryParameter("SERI", m3SERI.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGTP))
				request.WithQueryParameter("AGTP", m3AGTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRES))
				request.WithQueryParameter("SRES", m3SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMCD))
				request.WithQueryParameter("SMCD", m3SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (m3ETDT.HasValue)
				request.WithQueryParameter("ETDT", m3ETDT.Value.ToM3String());
			if (m3SIDT.HasValue)
				request.WithQueryParameter("SIDT", m3SIDT.Value.ToM3String());
			if (m3EIDT.HasValue)
				request.WithQueryParameter("EIDT", m3EIDT.Value.ToM3String());
			if (m3NODT.HasValue)
				request.WithQueryParameter("NODT", m3NODT.Value.ToM3String());
			if (m3IIDF.HasValue)
				request.WithQueryParameter("IIDF", m3IIDF.Value.ToM3String());
			if (m3IIDT.HasValue)
				request.WithQueryParameter("IIDT", m3IIDT.Value.ToM3String());
			if (m3IIYR.HasValue)
				request.WithQueryParameter("IIYR", m3IIYR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIMO.HasValue)
				request.WithQueryParameter("IIMO", m3IIMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIWE.HasValue)
				request.WithQueryParameter("IIWE", m3IIWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IXYR.HasValue)
				request.WithQueryParameter("IXYR", m3IXYR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IXMO.HasValue)
				request.WithQueryParameter("IXMO", m3IXMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IXWE.HasValue)
				request.WithQueryParameter("IXWE", m3IXWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IXVF.HasValue)
				request.WithQueryParameter("IXVF", m3IXVF.Value.ToM3String());
			if (m3IXVT.HasValue)
				request.WithQueryParameter("IXVT", m3IXVT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3SPCO))
				request.WithQueryParameter("SPCO", m3SPCO.Trim());
			if (m3ANOS.HasValue)
				request.WithQueryParameter("ANOS", m3ANOS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AHLD))
				request.WithQueryParameter("AHLD", m3AHLD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARCC))
				request.WithQueryParameter("ARCC", m3ARCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARCT))
				request.WithQueryParameter("ARCT", m3ARCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3DMOD))
				request.WithQueryParameter("DMOD", m3DMOD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CMOD))
				request.WithQueryParameter("CMOD", m3CMOD.Trim());
			if (m3DLDT.HasValue)
				request.WithQueryParameter("DLDT", m3DLDT.Value.ToM3String());
			if (m3DETH.HasValue)
				request.WithQueryParameter("DETH", m3DETH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DETM.HasValue)
				request.WithQueryParameter("DETM", m3DETM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CODT.HasValue)
				request.WithQueryParameter("CODT", m3CODT.Value.ToM3String());
			if (m3COTH.HasValue)
				request.WithQueryParameter("COTH", m3COTH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COTM.HasValue)
				request.WithQueryParameter("COTM", m3COTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DTED))
				request.WithQueryParameter("DTED", m3DTED.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTED))
				request.WithQueryParameter("CTED", m3CTED.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEFO))
				request.WithQueryParameter("DEFO", m3DEFO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CLFR))
				request.WithQueryParameter("CLFR", m3CLFR.Trim());
			if (m3DEOD.HasValue)
				request.WithQueryParameter("DEOD", m3DEOD.Value.ToM3String());
			if (m3COOD.HasValue)
				request.WithQueryParameter("COOD", m3COOD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3DEFA))
				request.WithQueryParameter("DEFA", m3DEFA.Trim());
			if (!string.IsNullOrWhiteSpace(m3CLFA))
				request.WithQueryParameter("CLFA", m3CLFA.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());

			// Execute the request
			var result = await Execute<AddLeasingLineResponse>(
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
		/// Name AddPreCalc
		/// Description This transaction adds Pre Calculations
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3IXCD">Price index (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="m3KIDE">Kit identity (Required)</param>
		/// <param name="m3OAPR">Original price (Required)</param>
		/// <param name="m3IXVO">Original index value</param>
		/// <param name="m3IXVA">Price index value</param>
		/// <param name="m3IXCA">Calculation index value</param>
		/// <param name="m3IXPA">Index share - percentage</param>
		/// <param name="m3RAPR">Rent adjustment price</param>
		/// <param name="m3ANOS">Number of shifts</param>
		/// <param name="m3CRSA">Create service agreement line</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPreCalc(
			string m3AGNB, 
			int m3PONR, 
			string m3IXCD, 
			int m3POSX, 
			string m3KIDE, 
			decimal m3OAPR, 
			decimal? m3IXVO = null, 
			decimal? m3IXVA = null, 
			decimal? m3IXCA = null, 
			int? m3IXPA = null, 
			decimal? m3RAPR = null, 
			int? m3ANOS = null, 
			int? m3CRSA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPreCalc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));
			if (string.IsNullOrWhiteSpace(m3IXCD))
				throw new ArgumentNullException(nameof(m3IXCD));
			if (string.IsNullOrWhiteSpace(m3KIDE))
				throw new ArgumentNullException(nameof(m3KIDE));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("IXCD", m3IXCD.Trim())
				.WithQueryParameter("POSX", m3POSX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("KIDE", m3KIDE.Trim())
				.WithQueryParameter("OAPR", m3OAPR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3IXVO.HasValue)
				request.WithQueryParameter("IXVO", m3IXVO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IXVA.HasValue)
				request.WithQueryParameter("IXVA", m3IXVA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IXCA.HasValue)
				request.WithQueryParameter("IXCA", m3IXCA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IXPA.HasValue)
				request.WithQueryParameter("IXPA", m3IXPA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RAPR.HasValue)
				request.WithQueryParameter("RAPR", m3RAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ANOS.HasValue)
				request.WithQueryParameter("ANOS", m3ANOS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRSA.HasValue)
				request.WithQueryParameter("CRSA", m3CRSA.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelLTRAgree
		/// Description This transaction deletes LTR Agreement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelLTRAgree(
			string m3AGNB, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelLTRAgree",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3AGNB.Trim());

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
		/// Name DelLeasingLine
		/// Description This transaction deletes Leasing Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="m3CUPL">Customer site</param>
		/// <param name="m3SAID">Address number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelLeasingLine(
			string m3AGNB, 
			int m3PONR, 
			int m3POSX, 
			string m3CUPL = null, 
			string m3SAID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelLeasingLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("POSX", m3POSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUPL))
				request.WithQueryParameter("CUPL", m3CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SAID))
				request.WithQueryParameter("SAID", m3SAID.Trim());

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
		/// Name DelPreCalc
		/// Description This transaction deletes Pre Calculations
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="m3UPDC">Update (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelPreCalc(
			string m3AGNB, 
			int m3PONR, 
			int m3POSX, 
			int m3UPDC, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelPreCalc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("POSX", m3POSX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("UPDC", m3UPDC.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetAgreeKit
		/// Description This transaction gets Agreements Kits
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3KTNO">Kit number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgreeKitResponse></returns>
		/// <exception cref="M3Exception<GetAgreeKitResponse>"></exception>
		public async Task<M3Response<GetAgreeKitResponse>> GetAgreeKit(
			string m3KTNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAgreeKit",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3KTNO))
				throw new ArgumentNullException(nameof(m3KTNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("KTNO", m3KTNO.Trim());

			// Execute the request
			var result = await Execute<GetAgreeKitResponse>(
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
		/// Name GetInterest
		/// Description This transaction gets LTR agreement lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3INTT">Interest type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInterestResponse></returns>
		/// <exception cref="M3Exception<GetInterestResponse>"></exception>
		public async Task<M3Response<GetInterestResponse>> GetInterest(
			string m3INTT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetInterest",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3INTT))
				throw new ArgumentNullException(nameof(m3INTT));

			// Set mandatory parameters
			request
				.WithQueryParameter("INTT", m3INTT.Trim());

			// Execute the request
			var result = await Execute<GetInterestResponse>(
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
		/// Name GetLTRAgree
		/// Description This transaction gets LTR Agreement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLTRAgreeResponse></returns>
		/// <exception cref="M3Exception<GetLTRAgreeResponse>"></exception>
		public async Task<M3Response<GetLTRAgreeResponse>> GetLTRAgree(
			string m3AGNB, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetLTRAgree",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3AGNB.Trim());

			// Execute the request
			var result = await Execute<GetLTRAgreeResponse>(
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
		/// Name GetLeaseCond
		/// Description This transaction gets LTR Lease Cond
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SBNO">Subnumber (Required)</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLeaseCondResponse></returns>
		/// <exception cref="M3Exception<GetLeaseCondResponse>"></exception>
		public async Task<M3Response<GetLeaseCondResponse>> GetLeaseCond(
			string m3AGNB, 
			int m3PONR, 
			int m3POSX, 
			string m3ITNO, 
			int m3SBNO, 
			string m3BANO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetLeaseCond",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("POSX", m3POSX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SBNO", m3SBNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());

			// Execute the request
			var result = await Execute<GetLeaseCondResponse>(
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
		/// Name GetLeasingLine
		/// Description This transaction gets Leasing Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CUPL">Customer site</param>
		/// <param name="m3SAID">Address number</param>
		/// <param name="m3SERI">Serial number</param>
		/// <param name="m3AGTP">Agreement type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLeasingLineResponse></returns>
		/// <exception cref="M3Exception<GetLeasingLineResponse>"></exception>
		public async Task<M3Response<GetLeasingLineResponse>> GetLeasingLine(
			string m3AGNB, 
			int m3PONR, 
			int m3POSX, 
			string m3ITNO, 
			string m3CUPL = null, 
			string m3SAID = null, 
			string m3SERI = null, 
			string m3AGTP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetLeasingLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("POSX", m3POSX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUPL))
				request.WithQueryParameter("CUPL", m3CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SAID))
				request.WithQueryParameter("SAID", m3SAID.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERI))
				request.WithQueryParameter("SERI", m3SERI.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGTP))
				request.WithQueryParameter("AGTP", m3AGTP.Trim());

			// Execute the request
			var result = await Execute<GetLeasingLineResponse>(
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
		/// Name LstAgreeKit
		/// Description This transaction lists Agreement Kits
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3KTNO">Kit number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgreeKitResponse></returns>
		/// <exception cref="M3Exception<LstAgreeKitResponse>"></exception>
		public async Task<M3Response<LstAgreeKitResponse>> LstAgreeKit(
			string m3KTNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgreeKit",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3KTNO))
				request.WithQueryParameter("KTNO", m3KTNO.Trim());

			// Execute the request
			var result = await Execute<LstAgreeKitResponse>(
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
		/// Name LstInterest
		/// Description This transaction lists LTR agreement line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3INTT">Interest type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInterestResponse></returns>
		/// <exception cref="M3Exception<LstInterestResponse>"></exception>
		public async Task<M3Response<LstInterestResponse>> LstInterest(
			string m3INTT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInterest",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3INTT))
				request.WithQueryParameter("INTT", m3INTT.Trim());

			// Execute the request
			var result = await Execute<LstInterestResponse>(
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
		/// Name LstLTRByAgree
		/// Description This transaction lists LTR agreement line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLTRByAgreeResponse></returns>
		/// <exception cref="M3Exception<LstLTRByAgreeResponse>"></exception>
		public async Task<M3Response<LstLTRByAgreeResponse>> LstLTRByAgree(
			string m3FACI = null, 
			string m3AGNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLTRByAgree",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());

			// Execute the request
			var result = await Execute<LstLTRByAgreeResponse>(
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
		/// Name LstLTRByCo
		/// Description This transaction lists LTR Agreement lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLTRByCoResponse></returns>
		/// <exception cref="M3Exception<LstLTRByCoResponse>"></exception>
		public async Task<M3Response<LstLTRByCoResponse>> LstLTRByCo(
			string m3FACI = null, 
			string m3ORNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLTRByCo",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Execute the request
			var result = await Execute<LstLTRByCoResponse>(
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
		/// Name LstLTRByCust
		/// Description This transaction lists LTR By Costomer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3AGCN">Agreement customer</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLTRByCustResponse></returns>
		/// <exception cref="M3Exception<LstLTRByCustResponse>"></exception>
		public async Task<M3Response<LstLTRByCustResponse>> LstLTRByCust(
			string m3FACI = null, 
			string m3AGCN = null, 
			string m3AGNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLTRByCust",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGCN))
				request.WithQueryParameter("AGCN", m3AGCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());

			// Execute the request
			var result = await Execute<LstLTRByCustResponse>(
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
		/// Name LstLTRByPayer
		/// Description This transaction list LTR By Payer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLTRByPayerResponse></returns>
		/// <exception cref="M3Exception<LstLTRByPayerResponse>"></exception>
		public async Task<M3Response<LstLTRByPayerResponse>> LstLTRByPayer(
			string m3FACI = null, 
			string m3PYNO = null, 
			string m3AGNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLTRByPayer",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());

			// Execute the request
			var result = await Execute<LstLTRByPayerResponse>(
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
		/// Name LstLeaseCond
		/// Description This transaction lists LTR Lease Cond
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3SBNO">Subnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLeaseCondResponse></returns>
		/// <exception cref="M3Exception<LstLeaseCondResponse>"></exception>
		public async Task<M3Response<LstLeaseCondResponse>> LstLeaseCond(
			string m3AGNB, 
			int m3PONR, 
			int m3POSX, 
			string m3ITNO, 
			string m3BANO = null, 
			int? m3SBNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLeaseCond",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("POSX", m3POSX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3SBNO.HasValue)
				request.WithQueryParameter("SBNO", m3SBNO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstLeaseCondResponse>(
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
		/// Name LstLeasingLine
		/// Description This transaction lists Leasing Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3CUPL">Customer site</param>
		/// <param name="m3SAID">Address number</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLeasingLineResponse></returns>
		/// <exception cref="M3Exception<LstLeasingLineResponse>"></exception>
		public async Task<M3Response<LstLeasingLineResponse>> LstLeasingLine(
			string m3AGNB, 
			string m3CUPL = null, 
			string m3SAID = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLeasingLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3AGNB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUPL))
				request.WithQueryParameter("CUPL", m3CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SAID))
				request.WithQueryParameter("SAID", m3SAID.Trim());
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstLeasingLineResponse>(
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
		/// Name UpdLTRHead
		/// Description This transaction updates LTR Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3AGCN">Agreement customer</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3USID">User</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3SMCD">Salesperson</param>
		/// <param name="m3AGRE">LTR agreement responsible</param>
		/// <param name="m3SRES">Service manager</param>
		/// <param name="m3ARCC">Reason code - created agreement</param>
		/// <param name="m3ARCT">Reason code - terminated agreement</param>
		/// <param name="m3AGRC">LTR agreement conditions</param>
		/// <param name="m3PKIT">Kit price printout</param>
		/// <param name="m3AGTP">Agreement type</param>
		/// <param name="m3IIYR">Invoicing interval - years</param>
		/// <param name="m3IIMO">Invoicing interval - months</param>
		/// <param name="m3IIWE">Invoicing interval - weeks</param>
		/// <param name="m3IXCD">Price index</param>
		/// <param name="m3IXYR">Index interval years</param>
		/// <param name="m3IXMO">Index interval months</param>
		/// <param name="m3IXWE">Index interval weeks</param>
		/// <param name="m3ANOS">Number of shifts</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdLTRHead(
			string m3AGNB, 
			string m3AGCN = null, 
			string m3CUOR = null, 
			string m3USID = null, 
			string m3TEPY = null, 
			string m3SMCD = null, 
			string m3AGRE = null, 
			string m3SRES = null, 
			string m3ARCC = null, 
			string m3ARCT = null, 
			string m3AGRC = null, 
			int? m3PKIT = null, 
			string m3AGTP = null, 
			int? m3IIYR = null, 
			int? m3IIMO = null, 
			int? m3IIWE = null, 
			string m3IXCD = null, 
			int? m3IXYR = null, 
			int? m3IXMO = null, 
			int? m3IXWE = null, 
			int? m3ANOS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdLTRHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3AGNB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AGCN))
				request.WithQueryParameter("AGCN", m3AGCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMCD))
				request.WithQueryParameter("SMCD", m3SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGRE))
				request.WithQueryParameter("AGRE", m3AGRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRES))
				request.WithQueryParameter("SRES", m3SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARCC))
				request.WithQueryParameter("ARCC", m3ARCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARCT))
				request.WithQueryParameter("ARCT", m3ARCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGRC))
				request.WithQueryParameter("AGRC", m3AGRC.Trim());
			if (m3PKIT.HasValue)
				request.WithQueryParameter("PKIT", m3PKIT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AGTP))
				request.WithQueryParameter("AGTP", m3AGTP.Trim());
			if (m3IIYR.HasValue)
				request.WithQueryParameter("IIYR", m3IIYR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIMO.HasValue)
				request.WithQueryParameter("IIMO", m3IIMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIWE.HasValue)
				request.WithQueryParameter("IIWE", m3IIWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3IXCD))
				request.WithQueryParameter("IXCD", m3IXCD.Trim());
			if (m3IXYR.HasValue)
				request.WithQueryParameter("IXYR", m3IXYR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IXMO.HasValue)
				request.WithQueryParameter("IXMO", m3IXMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IXWE.HasValue)
				request.WithQueryParameter("IXWE", m3IXWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ANOS.HasValue)
				request.WithQueryParameter("ANOS", m3ANOS.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdLeaseCond
		/// Description This transaction updates Leasing Cond
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SBNO">Subnumber (Required)</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3TX25">Text</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3NOPR">Number of periods</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3CMPP">Months/period</param>
		/// <param name="m3INVM">Invoicing method</param>
		/// <param name="m3CSPR">Customer price</param>
		/// <param name="m3RESV">Residual value</param>
		/// <param name="m3REPE">Residual %</param>
		/// <param name="m3INTT">Interest type</param>
		/// <param name="m3INPE">Interest rate</param>
		/// <param name="m3RENT">Rent amount</param>
		/// <param name="m3INLL">Minimun variable interest rate</param>
		/// <param name="m3INTH">Interest threshold value</param>
		/// <param name="m3FFA1">User-defined field 1 alfa</param>
		/// <param name="m3FFA2">User-defined field 1 alfa</param>
		/// <param name="m3FFA3">User-defined field 1 alfa</param>
		/// <param name="m3FFA4">User-defined field 1 alfa</param>
		/// <param name="m3FFA5">User-defined field 1 alfa</param>
		/// <param name="m3FFA6">User-defined field 1 alfa</param>
		/// <param name="m3FFA7">User-defined field 1 alfa</param>
		/// <param name="m3FFA8">User-defined field 1 alfa</param>
		/// <param name="m3FFA9">User-defined field 1 alfa</param>
		/// <param name="m3FFA0">User-defined field 1 alfa</param>
		/// <param name="m3FFN1">User-defined field 1 numeric</param>
		/// <param name="m3FFN2">User-defined field 1 numeric</param>
		/// <param name="m3FFN3">User-defined field 1 numeric</param>
		/// <param name="m3FFN4">User-defined field 1 numeric</param>
		/// <param name="m3FFN5">User-defined field 1 numeric</param>
		/// <param name="m3FFN6">User-defined field 1 numeric</param>
		/// <param name="m3FFN7">User-defined field 1 numeric</param>
		/// <param name="m3FFN8">User-defined field 1 numeric</param>
		/// <param name="m3FFN9">User-defined field 1 numeric</param>
		/// <param name="m3FFN0">User-defined field 1 numeric</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdLeaseCond(
			string m3AGNB, 
			int m3PONR, 
			int m3POSX, 
			string m3ITNO, 
			int m3SBNO, 
			string m3BANO = null, 
			string m3TX25 = null, 
			string m3STAT = null, 
			int? m3NOPR = null, 
			DateTime? m3FVDT = null, 
			int? m3CMPP = null, 
			string m3INVM = null, 
			decimal? m3CSPR = null, 
			decimal? m3RESV = null, 
			int? m3REPE = null, 
			string m3INTT = null, 
			decimal? m3INPE = null, 
			decimal? m3RENT = null, 
			decimal? m3INLL = null, 
			int? m3INTH = null, 
			string m3FFA1 = null, 
			string m3FFA2 = null, 
			string m3FFA3 = null, 
			string m3FFA4 = null, 
			string m3FFA5 = null, 
			string m3FFA6 = null, 
			string m3FFA7 = null, 
			string m3FFA8 = null, 
			string m3FFA9 = null, 
			string m3FFA0 = null, 
			decimal? m3FFN1 = null, 
			decimal? m3FFN2 = null, 
			decimal? m3FFN3 = null, 
			decimal? m3FFN4 = null, 
			decimal? m3FFN5 = null, 
			decimal? m3FFN6 = null, 
			decimal? m3FFN7 = null, 
			decimal? m3FFN8 = null, 
			decimal? m3FFN9 = null, 
			decimal? m3FFN0 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdLeaseCond",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("POSX", m3POSX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SBNO", m3SBNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX25))
				request.WithQueryParameter("TX25", m3TX25.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3NOPR.HasValue)
				request.WithQueryParameter("NOPR", m3NOPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3CMPP.HasValue)
				request.WithQueryParameter("CMPP", m3CMPP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INVM))
				request.WithQueryParameter("INVM", m3INVM.Trim());
			if (m3CSPR.HasValue)
				request.WithQueryParameter("CSPR", m3CSPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RESV.HasValue)
				request.WithQueryParameter("RESV", m3RESV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REPE.HasValue)
				request.WithQueryParameter("REPE", m3REPE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INTT))
				request.WithQueryParameter("INTT", m3INTT.Trim());
			if (m3INPE.HasValue)
				request.WithQueryParameter("INPE", m3INPE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RENT.HasValue)
				request.WithQueryParameter("RENT", m3RENT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INLL.HasValue)
				request.WithQueryParameter("INLL", m3INLL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INTH.HasValue)
				request.WithQueryParameter("INTH", m3INTH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FFA1))
				request.WithQueryParameter("FFA1", m3FFA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA2))
				request.WithQueryParameter("FFA2", m3FFA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA3))
				request.WithQueryParameter("FFA3", m3FFA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA4))
				request.WithQueryParameter("FFA4", m3FFA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA5))
				request.WithQueryParameter("FFA5", m3FFA5.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA6))
				request.WithQueryParameter("FFA6", m3FFA6.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA7))
				request.WithQueryParameter("FFA7", m3FFA7.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA8))
				request.WithQueryParameter("FFA8", m3FFA8.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA9))
				request.WithQueryParameter("FFA9", m3FFA9.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA0))
				request.WithQueryParameter("FFA0", m3FFA0.Trim());
			if (m3FFN1.HasValue)
				request.WithQueryParameter("FFN1", m3FFN1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN2.HasValue)
				request.WithQueryParameter("FFN2", m3FFN2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN3.HasValue)
				request.WithQueryParameter("FFN3", m3FFN3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN4.HasValue)
				request.WithQueryParameter("FFN4", m3FFN4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN5.HasValue)
				request.WithQueryParameter("FFN5", m3FFN5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN6.HasValue)
				request.WithQueryParameter("FFN6", m3FFN6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN7.HasValue)
				request.WithQueryParameter("FFN7", m3FFN7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN8.HasValue)
				request.WithQueryParameter("FFN8", m3FFN8.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN9.HasValue)
				request.WithQueryParameter("FFN9", m3FFN9.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN0.HasValue)
				request.WithQueryParameter("FFN0", m3FFN0.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdLeasingLine
		/// Description This transaction updates Leasing Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3IIYR">Invoicing interval - years (Required)</param>
		/// <param name="m3CUPL">Customer site</param>
		/// <param name="m3SAID">Address number</param>
		/// <param name="m3SERI">Serial number</param>
		/// <param name="m3AGTP">Agreement type</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3SRES">Service manager</param>
		/// <param name="m3SMCD">Salesperson</param>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3NOPR">Number of periods</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3ETDT">Current valid to</param>
		/// <param name="m3SIDT">Invoicing start date</param>
		/// <param name="m3EIDT">Invoicing end date</param>
		/// <param name="m3NODT">Next invoice date</param>
		/// <param name="m3IIDF">Start date - invoicing range</param>
		/// <param name="m3IIDT">End date - invoicing range</param>
		/// <param name="m3IIMO">Invoicing interval - months</param>
		/// <param name="m3IIWE">Invoicing interval - weeks</param>
		/// <param name="m3IXYR">Index interval years</param>
		/// <param name="m3IXMO">Index interval months</param>
		/// <param name="m3IXWE">Index interval weeks</param>
		/// <param name="m3IXVF">Valid from</param>
		/// <param name="m3IXVT">Valid to</param>
		/// <param name="m3INVM">Invoicing method</param>
		/// <param name="m3SPCO">Split code - invoicing</param>
		/// <param name="m3ANOS">Number of shifts</param>
		/// <param name="m3AHLD">Hold code</param>
		/// <param name="m3ARCC">Reason code - created agreement</param>
		/// <param name="m3ARCT">Reason code - terminated agreement</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3FWHL">From warehouse</param>
		/// <param name="m3TWHL">To warehouse</param>
		/// <param name="m3DMOD">Delivery method</param>
		/// <param name="m3CMOD">Delivery method - return</param>
		/// <param name="m3DLDT">Planned delivery date</param>
		/// <param name="m3DETH">Time of departure - hours</param>
		/// <param name="m3DETM">Time of departure - minutes</param>
		/// <param name="m3CODT">Confirmed Delivary date</param>
		/// <param name="m3COTH">Pickup time hours</param>
		/// <param name="m3COTM">Pickup minutes</param>
		/// <param name="m3DTED">Delivery terms</param>
		/// <param name="m3CTED">Delivery terms</param>
		/// <param name="m3DEFO">Delivery ordered by</param>
		/// <param name="m3CLFR">Rental return ordered by</param>
		/// <param name="m3DEOD">Delivery order date</param>
		/// <param name="m3COOD">Rental return order date</param>
		/// <param name="m3DEFA">Delivery freight agreement number</param>
		/// <param name="m3CLFA">Freight agreement number - rental return</param>
		/// <param name="m3AIT1">Accounting dimension 1</param>
		/// <param name="m3AIT2">Accounting dimension 2</param>
		/// <param name="m3AIT3">Accounting dimension 3</param>
		/// <param name="m3AIT4">Accounting dimension 4</param>
		/// <param name="m3AIT5">Accounting dimension 5</param>
		/// <param name="m3AIT6">Accounting dimension 6</param>
		/// <param name="m3AIT7">Accounting dimension 7</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdLeasingLine(
			string m3AGNB, 
			int m3PONR, 
			int m3POSX, 
			string m3ITNO, 
			int m3IIYR, 
			string m3CUPL = null, 
			string m3SAID = null, 
			string m3SERI = null, 
			string m3AGTP = null, 
			string m3PYNO = null, 
			string m3SRES = null, 
			string m3SMCD = null, 
			string m3ORNO = null, 
			int? m3NOPR = null, 
			DateTime? m3FVDT = null, 
			DateTime? m3ETDT = null, 
			DateTime? m3SIDT = null, 
			DateTime? m3EIDT = null, 
			DateTime? m3NODT = null, 
			DateTime? m3IIDF = null, 
			DateTime? m3IIDT = null, 
			int? m3IIMO = null, 
			int? m3IIWE = null, 
			int? m3IXYR = null, 
			int? m3IXMO = null, 
			int? m3IXWE = null, 
			DateTime? m3IXVF = null, 
			DateTime? m3IXVT = null, 
			string m3INVM = null, 
			string m3SPCO = null, 
			int? m3ANOS = null, 
			string m3AHLD = null, 
			string m3ARCC = null, 
			string m3ARCT = null, 
			string m3BREM = null, 
			string m3FWHL = null, 
			string m3TWHL = null, 
			string m3DMOD = null, 
			string m3CMOD = null, 
			DateTime? m3DLDT = null, 
			int? m3DETH = null, 
			int? m3DETM = null, 
			DateTime? m3CODT = null, 
			int? m3COTH = null, 
			int? m3COTM = null, 
			string m3DTED = null, 
			string m3CTED = null, 
			string m3DEFO = null, 
			string m3CLFR = null, 
			DateTime? m3DEOD = null, 
			DateTime? m3COOD = null, 
			string m3DEFA = null, 
			string m3CLFA = null, 
			string m3AIT1 = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
			string m3PROJ = null, 
			string m3ACRF = null, 
			string m3ELNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdLeasingLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("POSX", m3POSX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("IIYR", m3IIYR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUPL))
				request.WithQueryParameter("CUPL", m3CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SAID))
				request.WithQueryParameter("SAID", m3SAID.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERI))
				request.WithQueryParameter("SERI", m3SERI.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGTP))
				request.WithQueryParameter("AGTP", m3AGTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRES))
				request.WithQueryParameter("SRES", m3SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMCD))
				request.WithQueryParameter("SMCD", m3SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (m3NOPR.HasValue)
				request.WithQueryParameter("NOPR", m3NOPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3ETDT.HasValue)
				request.WithQueryParameter("ETDT", m3ETDT.Value.ToM3String());
			if (m3SIDT.HasValue)
				request.WithQueryParameter("SIDT", m3SIDT.Value.ToM3String());
			if (m3EIDT.HasValue)
				request.WithQueryParameter("EIDT", m3EIDT.Value.ToM3String());
			if (m3NODT.HasValue)
				request.WithQueryParameter("NODT", m3NODT.Value.ToM3String());
			if (m3IIDF.HasValue)
				request.WithQueryParameter("IIDF", m3IIDF.Value.ToM3String());
			if (m3IIDT.HasValue)
				request.WithQueryParameter("IIDT", m3IIDT.Value.ToM3String());
			if (m3IIMO.HasValue)
				request.WithQueryParameter("IIMO", m3IIMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIWE.HasValue)
				request.WithQueryParameter("IIWE", m3IIWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IXYR.HasValue)
				request.WithQueryParameter("IXYR", m3IXYR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IXMO.HasValue)
				request.WithQueryParameter("IXMO", m3IXMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IXWE.HasValue)
				request.WithQueryParameter("IXWE", m3IXWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IXVF.HasValue)
				request.WithQueryParameter("IXVF", m3IXVF.Value.ToM3String());
			if (m3IXVT.HasValue)
				request.WithQueryParameter("IXVT", m3IXVT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3INVM))
				request.WithQueryParameter("INVM", m3INVM.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPCO))
				request.WithQueryParameter("SPCO", m3SPCO.Trim());
			if (m3ANOS.HasValue)
				request.WithQueryParameter("ANOS", m3ANOS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AHLD))
				request.WithQueryParameter("AHLD", m3AHLD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARCC))
				request.WithQueryParameter("ARCC", m3ARCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARCT))
				request.WithQueryParameter("ARCT", m3ARCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3FWHL))
				request.WithQueryParameter("FWHL", m3FWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWHL))
				request.WithQueryParameter("TWHL", m3TWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3DMOD))
				request.WithQueryParameter("DMOD", m3DMOD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CMOD))
				request.WithQueryParameter("CMOD", m3CMOD.Trim());
			if (m3DLDT.HasValue)
				request.WithQueryParameter("DLDT", m3DLDT.Value.ToM3String());
			if (m3DETH.HasValue)
				request.WithQueryParameter("DETH", m3DETH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DETM.HasValue)
				request.WithQueryParameter("DETM", m3DETM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CODT.HasValue)
				request.WithQueryParameter("CODT", m3CODT.Value.ToM3String());
			if (m3COTH.HasValue)
				request.WithQueryParameter("COTH", m3COTH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COTM.HasValue)
				request.WithQueryParameter("COTM", m3COTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DTED))
				request.WithQueryParameter("DTED", m3DTED.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTED))
				request.WithQueryParameter("CTED", m3CTED.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEFO))
				request.WithQueryParameter("DEFO", m3DEFO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CLFR))
				request.WithQueryParameter("CLFR", m3CLFR.Trim());
			if (m3DEOD.HasValue)
				request.WithQueryParameter("DEOD", m3DEOD.Value.ToM3String());
			if (m3COOD.HasValue)
				request.WithQueryParameter("COOD", m3COOD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3DEFA))
				request.WithQueryParameter("DEFA", m3DEFA.Trim());
			if (!string.IsNullOrWhiteSpace(m3CLFA))
				request.WithQueryParameter("CLFA", m3CLFA.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());

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
		/// Name UpdPreCalc
		/// Description This transaction updates Pre Calculations
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3IXCD">Price index (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="m3UPDC">Update (Required)</param>
		/// <param name="m3IXVO">Original index value</param>
		/// <param name="m3IXVA">Price index value</param>
		/// <param name="m3IXCA">Calculation index value</param>
		/// <param name="m3IXPA">Index share - percentage</param>
		/// <param name="m3RAPR">Rent adjustment price</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3OAPR">Original price</param>
		/// <param name="m3INAL">Index adjustment line</param>
		/// <param name="m3CRSA">Create service agreement line</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPreCalc(
			string m3AGNB, 
			int m3PONR, 
			string m3IXCD, 
			int m3POSX, 
			int m3UPDC, 
			decimal? m3IXVO = null, 
			decimal? m3IXVA = null, 
			decimal? m3IXCA = null, 
			int? m3IXPA = null, 
			decimal? m3RAPR = null, 
			string m3ITDS = null, 
			decimal? m3OAPR = null, 
			int? m3INAL = null, 
			int? m3CRSA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdPreCalc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));
			if (string.IsNullOrWhiteSpace(m3IXCD))
				throw new ArgumentNullException(nameof(m3IXCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("IXCD", m3IXCD.Trim())
				.WithQueryParameter("POSX", m3POSX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("UPDC", m3UPDC.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3IXVO.HasValue)
				request.WithQueryParameter("IXVO", m3IXVO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IXVA.HasValue)
				request.WithQueryParameter("IXVA", m3IXVA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IXCA.HasValue)
				request.WithQueryParameter("IXCA", m3IXCA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IXPA.HasValue)
				request.WithQueryParameter("IXPA", m3IXPA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RAPR.HasValue)
				request.WithQueryParameter("RAPR", m3RAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (m3OAPR.HasValue)
				request.WithQueryParameter("OAPR", m3OAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INAL.HasValue)
				request.WithQueryParameter("INAL", m3INAL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRSA.HasValue)
				request.WithQueryParameter("CRSA", m3CRSA.Value.ToString(CultureInfo.CurrentCulture));

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
