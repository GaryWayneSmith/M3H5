/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_AOTP">Agreement order type (Required)</param>
		/// <param name="m3_AGCN">Agreement customer (Required)</param>
		/// <param name="m3_NOPR">Number of periods (Required)</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_CUPL">Customer site</param>
		/// <param name="m3_SAID">Address number</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_USID">User</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_SMCD">Salesperson</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_AGRE">LTR agreement responsible</param>
		/// <param name="m3_SRES">Service manager</param>
		/// <param name="m3_ARCC">Reason code - created agreement</param>
		/// <param name="m3_ARCT">Reason code - terminated agreement</param>
		/// <param name="m3_AGRC">LTR agreement conditions</param>
		/// <param name="m3_PKIT">Kit price printout</param>
		/// <param name="m3_AGTP">Agreement type</param>
		/// <param name="m3_IIYR">Invoicing interval - years</param>
		/// <param name="m3_IIMO">Invoicing interval - months</param>
		/// <param name="m3_IIWE">Invoicing interval - weeks</param>
		/// <param name="m3_IXCD">Price index</param>
		/// <param name="m3_IXYR">Index interval years</param>
		/// <param name="m3_IXMO">Index interval months</param>
		/// <param name="m3_IXWE">Index interval weeks</param>
		/// <param name="m3_ANOS">Number of shifts</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddLTRHeadResponse></returns>
		/// <exception cref="M3Exception<AddLTRHeadResponse>"></exception>
		public async Task<M3Response<AddLTRHeadResponse>> AddLTRHead(
			string m3_FACI, 
			string m3_AOTP, 
			string m3_AGCN, 
			int m3_NOPR, 
			string m3_AGNB = null, 
			string m3_CUPL = null, 
			string m3_SAID = null, 
			string m3_PYNO = null, 
			DateTime? m3_FVDT = null, 
			string m3_CUOR = null, 
			string m3_USID = null, 
			string m3_TEPY = null, 
			string m3_SMCD = null, 
			string m3_CUCD = null, 
			string m3_AGRE = null, 
			string m3_SRES = null, 
			string m3_ARCC = null, 
			string m3_ARCT = null, 
			string m3_AGRC = null, 
			int? m3_PKIT = null, 
			string m3_AGTP = null, 
			int? m3_IIYR = null, 
			int? m3_IIMO = null, 
			int? m3_IIWE = null, 
			string m3_IXCD = null, 
			int? m3_IXYR = null, 
			int? m3_IXMO = null, 
			int? m3_IXWE = null, 
			int? m3_ANOS = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_AOTP))
				throw new ArgumentNullException("m3_AOTP");
			if (string.IsNullOrWhiteSpace(m3_AGCN))
				throw new ArgumentNullException("m3_AGCN");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("AOTP", m3_AOTP.Trim())
				.WithQueryParameter("AGCN", m3_AGCN.Trim())
				.WithQueryParameter("NOPR", m3_NOPR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUPL))
				request.WithQueryParameter("CUPL", m3_CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SAID))
				request.WithQueryParameter("SAID", m3_SAID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMCD))
				request.WithQueryParameter("SMCD", m3_SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGRE))
				request.WithQueryParameter("AGRE", m3_AGRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRES))
				request.WithQueryParameter("SRES", m3_SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARCC))
				request.WithQueryParameter("ARCC", m3_ARCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARCT))
				request.WithQueryParameter("ARCT", m3_ARCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGRC))
				request.WithQueryParameter("AGRC", m3_AGRC.Trim());
			if (m3_PKIT.HasValue)
				request.WithQueryParameter("PKIT", m3_PKIT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AGTP))
				request.WithQueryParameter("AGTP", m3_AGTP.Trim());
			if (m3_IIYR.HasValue)
				request.WithQueryParameter("IIYR", m3_IIYR.Value.ToString());
			if (m3_IIMO.HasValue)
				request.WithQueryParameter("IIMO", m3_IIMO.Value.ToString());
			if (m3_IIWE.HasValue)
				request.WithQueryParameter("IIWE", m3_IIWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_IXCD))
				request.WithQueryParameter("IXCD", m3_IXCD.Trim());
			if (m3_IXYR.HasValue)
				request.WithQueryParameter("IXYR", m3_IXYR.Value.ToString());
			if (m3_IXMO.HasValue)
				request.WithQueryParameter("IXMO", m3_IXMO.Value.ToString());
			if (m3_IXWE.HasValue)
				request.WithQueryParameter("IXWE", m3_IXWE.Value.ToString());
			if (m3_ANOS.HasValue)
				request.WithQueryParameter("ANOS", m3_ANOS.Value.ToString());

			// Execute the request
			var result = await Execute<AddLTRHeadResponse>(
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
		/// Name AddLeaseCond
		/// Description This transaction creates Leasing Cond
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_NOPR">Number of periods (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_CMPP">Months/period (Required)</param>
		/// <param name="m3_CSPR">Customer price (Required)</param>
		/// <param name="m3_INTT">Interest type (Required)</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_SBNO">Subnumber</param>
		/// <param name="m3_TX25">Text</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_INVM">Invoicing method</param>
		/// <param name="m3_RESV">Residual value</param>
		/// <param name="m3_REPE">Residual %</param>
		/// <param name="m3_INPE">Interest rate</param>
		/// <param name="m3_RENT">Rent amount</param>
		/// <param name="m3_INLL">Minimun variable interest rate</param>
		/// <param name="m3_INTH">Interest threshold value</param>
		/// <param name="m3_FFA1">User-defined field 1 alfa</param>
		/// <param name="m3_FFA2">User-defined field 1 alfa</param>
		/// <param name="m3_FFA3">User-defined field 1 alfa</param>
		/// <param name="m3_FFA4">User-defined field 1 alfa</param>
		/// <param name="m3_FFA5">User-defined field 1 alfa</param>
		/// <param name="m3_FFA6">User-defined field 1 alfa</param>
		/// <param name="m3_FFA7">User-defined field 1 alfa</param>
		/// <param name="m3_FFA8">User-defined field 1 alfa</param>
		/// <param name="m3_FFA9">User-defined field 1 alfa</param>
		/// <param name="m3_FFA0">User-defined field 1 alfa</param>
		/// <param name="m3_FFN1">User-defined field 1 numeric</param>
		/// <param name="m3_FFN2">User-defined field 1 numeric</param>
		/// <param name="m3_FFN3">User-defined field 1 numeric</param>
		/// <param name="m3_FFN4">User-defined field 1 numeric</param>
		/// <param name="m3_FFN5">User-defined field 1 numeric</param>
		/// <param name="m3_FFN6">User-defined field 1 numeric</param>
		/// <param name="m3_FFN7">User-defined field 1 numeric</param>
		/// <param name="m3_FFN8">User-defined field 1 numeric</param>
		/// <param name="m3_FFN9">User-defined field 1 numeric</param>
		/// <param name="m3_FFN0">User-defined field 1 numeric</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLeaseCond(
			string m3_AGNB, 
			int m3_PONR, 
			int m3_POSX, 
			string m3_ITNO, 
			int m3_NOPR, 
			DateTime m3_FVDT, 
			int m3_CMPP, 
			decimal m3_CSPR, 
			string m3_INTT, 
			string m3_BANO = null, 
			int? m3_SBNO = null, 
			string m3_TX25 = null, 
			string m3_STAT = null, 
			string m3_INVM = null, 
			decimal? m3_RESV = null, 
			int? m3_REPE = null, 
			decimal? m3_INPE = null, 
			decimal? m3_RENT = null, 
			decimal? m3_INLL = null, 
			int? m3_INTH = null, 
			string m3_FFA1 = null, 
			string m3_FFA2 = null, 
			string m3_FFA3 = null, 
			string m3_FFA4 = null, 
			string m3_FFA5 = null, 
			string m3_FFA6 = null, 
			string m3_FFA7 = null, 
			string m3_FFA8 = null, 
			string m3_FFA9 = null, 
			string m3_FFA0 = null, 
			decimal? m3_FFN1 = null, 
			decimal? m3_FFN2 = null, 
			decimal? m3_FFN3 = null, 
			decimal? m3_FFN4 = null, 
			decimal? m3_FFN5 = null, 
			decimal? m3_FFN6 = null, 
			decimal? m3_FFN7 = null, 
			decimal? m3_FFN8 = null, 
			decimal? m3_FFN9 = null, 
			decimal? m3_FFN0 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_INTT))
				throw new ArgumentNullException("m3_INTT");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("NOPR", m3_NOPR.ToString())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String())
				.WithQueryParameter("CMPP", m3_CMPP.ToString())
				.WithQueryParameter("CSPR", m3_CSPR.ToString())
				.WithQueryParameter("INTT", m3_INTT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_SBNO.HasValue)
				request.WithQueryParameter("SBNO", m3_SBNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX25))
				request.WithQueryParameter("TX25", m3_TX25.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INVM))
				request.WithQueryParameter("INVM", m3_INVM.Trim());
			if (m3_RESV.HasValue)
				request.WithQueryParameter("RESV", m3_RESV.Value.ToString());
			if (m3_REPE.HasValue)
				request.WithQueryParameter("REPE", m3_REPE.Value.ToString());
			if (m3_INPE.HasValue)
				request.WithQueryParameter("INPE", m3_INPE.Value.ToString());
			if (m3_RENT.HasValue)
				request.WithQueryParameter("RENT", m3_RENT.Value.ToString());
			if (m3_INLL.HasValue)
				request.WithQueryParameter("INLL", m3_INLL.Value.ToString());
			if (m3_INTH.HasValue)
				request.WithQueryParameter("INTH", m3_INTH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FFA1))
				request.WithQueryParameter("FFA1", m3_FFA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA2))
				request.WithQueryParameter("FFA2", m3_FFA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA3))
				request.WithQueryParameter("FFA3", m3_FFA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA4))
				request.WithQueryParameter("FFA4", m3_FFA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA5))
				request.WithQueryParameter("FFA5", m3_FFA5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA6))
				request.WithQueryParameter("FFA6", m3_FFA6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA7))
				request.WithQueryParameter("FFA7", m3_FFA7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA8))
				request.WithQueryParameter("FFA8", m3_FFA8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA9))
				request.WithQueryParameter("FFA9", m3_FFA9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA0))
				request.WithQueryParameter("FFA0", m3_FFA0.Trim());
			if (m3_FFN1.HasValue)
				request.WithQueryParameter("FFN1", m3_FFN1.Value.ToString());
			if (m3_FFN2.HasValue)
				request.WithQueryParameter("FFN2", m3_FFN2.Value.ToString());
			if (m3_FFN3.HasValue)
				request.WithQueryParameter("FFN3", m3_FFN3.Value.ToString());
			if (m3_FFN4.HasValue)
				request.WithQueryParameter("FFN4", m3_FFN4.Value.ToString());
			if (m3_FFN5.HasValue)
				request.WithQueryParameter("FFN5", m3_FFN5.Value.ToString());
			if (m3_FFN6.HasValue)
				request.WithQueryParameter("FFN6", m3_FFN6.Value.ToString());
			if (m3_FFN7.HasValue)
				request.WithQueryParameter("FFN7", m3_FFN7.Value.ToString());
			if (m3_FFN8.HasValue)
				request.WithQueryParameter("FFN8", m3_FFN8.Value.ToString());
			if (m3_FFN9.HasValue)
				request.WithQueryParameter("FFN9", m3_FFN9.Value.ToString());
			if (m3_FFN0.HasValue)
				request.WithQueryParameter("FFN0", m3_FFN0.Value.ToString());

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
		/// Name AddLeasingLine
		/// Description This transaction creates Leasing Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_NOPR">Number of periods (Required)</param>
		/// <param name="m3_INVM">Invoicing method (Required)</param>
		/// <param name="m3_FWHL">From warehouse (Required)</param>
		/// <param name="m3_TWHL">To warehouse (Required)</param>
		/// <param name="m3_CUPL">Customer site</param>
		/// <param name="m3_SAID">Address number</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_SERI">Serial number</param>
		/// <param name="m3_AGTP">Agreement type</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_SRES">Service manager</param>
		/// <param name="m3_SMCD">Salesperson</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_ETDT">Current valid to</param>
		/// <param name="m3_SIDT">Invoicing start date</param>
		/// <param name="m3_EIDT">Invoicing end date</param>
		/// <param name="m3_NODT">Next invoice date</param>
		/// <param name="m3_IIDF">Start date - invoicing range</param>
		/// <param name="m3_IIDT">End date - invoicing range</param>
		/// <param name="m3_IIYR">Invoicing interval - years</param>
		/// <param name="m3_IIMO">Invoicing interval - months</param>
		/// <param name="m3_IIWE">Invoicing interval - weeks</param>
		/// <param name="m3_IXYR">Index interval years</param>
		/// <param name="m3_IXMO">Index interval months</param>
		/// <param name="m3_IXWE">Index interval weeks</param>
		/// <param name="m3_IXVF">Valid from</param>
		/// <param name="m3_IXVT">Valid to</param>
		/// <param name="m3_SPCO">Split code - invoicing</param>
		/// <param name="m3_ANOS">Number of shifts</param>
		/// <param name="m3_AHLD">Hold code</param>
		/// <param name="m3_ARCC">Reason code - created agreement</param>
		/// <param name="m3_ARCT">Reason code - terminated agreement</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_DMOD">Delivery method</param>
		/// <param name="m3_CMOD">Delivery method - return</param>
		/// <param name="m3_DLDT">Planned delivery date</param>
		/// <param name="m3_DETH">Time of departure - hours</param>
		/// <param name="m3_DETM">Time of departure - minutes</param>
		/// <param name="m3_CODT">Confirmed Delivary date</param>
		/// <param name="m3_COTH">Pickup time hours</param>
		/// <param name="m3_COTM">Pickup minutes</param>
		/// <param name="m3_DTED">Delivery terms</param>
		/// <param name="m3_CTED">Delivery terms</param>
		/// <param name="m3_DEFO">Delivery ordered by</param>
		/// <param name="m3_CLFR">Rental return ordered by</param>
		/// <param name="m3_DEOD">Delivery order date</param>
		/// <param name="m3_COOD">Rental return order date</param>
		/// <param name="m3_DEFA">Delivery freight agreement number</param>
		/// <param name="m3_CLFA">Freight agreement number - rental return</param>
		/// <param name="m3_AIT1">Accounting dimension 1</param>
		/// <param name="m3_AIT2">Accounting dimension 2</param>
		/// <param name="m3_AIT3">Accounting dimension 3</param>
		/// <param name="m3_AIT4">Accounting dimension 4</param>
		/// <param name="m3_AIT5">Accounting dimension 5</param>
		/// <param name="m3_AIT6">Accounting dimension 6</param>
		/// <param name="m3_AIT7">Accounting dimension 7</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddLeasingLineResponse></returns>
		/// <exception cref="M3Exception<AddLeasingLineResponse>"></exception>
		public async Task<M3Response<AddLeasingLineResponse>> AddLeasingLine(
			string m3_AGNB, 
			string m3_ITNO, 
			DateTime m3_FVDT, 
			int m3_NOPR, 
			string m3_INVM, 
			string m3_FWHL, 
			string m3_TWHL, 
			string m3_CUPL = null, 
			string m3_SAID = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			string m3_SERI = null, 
			string m3_AGTP = null, 
			string m3_PYNO = null, 
			string m3_SRES = null, 
			string m3_SMCD = null, 
			string m3_ORNO = null, 
			DateTime? m3_ETDT = null, 
			DateTime? m3_SIDT = null, 
			DateTime? m3_EIDT = null, 
			DateTime? m3_NODT = null, 
			DateTime? m3_IIDF = null, 
			DateTime? m3_IIDT = null, 
			int? m3_IIYR = null, 
			int? m3_IIMO = null, 
			int? m3_IIWE = null, 
			int? m3_IXYR = null, 
			int? m3_IXMO = null, 
			int? m3_IXWE = null, 
			DateTime? m3_IXVF = null, 
			DateTime? m3_IXVT = null, 
			string m3_SPCO = null, 
			int? m3_ANOS = null, 
			string m3_AHLD = null, 
			string m3_ARCC = null, 
			string m3_ARCT = null, 
			string m3_BREM = null, 
			string m3_DMOD = null, 
			string m3_CMOD = null, 
			DateTime? m3_DLDT = null, 
			int? m3_DETH = null, 
			int? m3_DETM = null, 
			DateTime? m3_CODT = null, 
			int? m3_COTH = null, 
			int? m3_COTM = null, 
			string m3_DTED = null, 
			string m3_CTED = null, 
			string m3_DEFO = null, 
			string m3_CLFR = null, 
			DateTime? m3_DEOD = null, 
			DateTime? m3_COOD = null, 
			string m3_DEFA = null, 
			string m3_CLFA = null, 
			string m3_AIT1 = null, 
			string m3_AIT2 = null, 
			string m3_AIT3 = null, 
			string m3_AIT4 = null, 
			string m3_AIT5 = null, 
			string m3_AIT6 = null, 
			string m3_AIT7 = null, 
			string m3_PROJ = null, 
			string m3_ACRF = null, 
			string m3_ELNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_INVM))
				throw new ArgumentNullException("m3_INVM");
			if (string.IsNullOrWhiteSpace(m3_FWHL))
				throw new ArgumentNullException("m3_FWHL");
			if (string.IsNullOrWhiteSpace(m3_TWHL))
				throw new ArgumentNullException("m3_TWHL");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String())
				.WithQueryParameter("NOPR", m3_NOPR.ToString())
				.WithQueryParameter("INVM", m3_INVM.Trim())
				.WithQueryParameter("FWHL", m3_FWHL.Trim())
				.WithQueryParameter("TWHL", m3_TWHL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUPL))
				request.WithQueryParameter("CUPL", m3_CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SAID))
				request.WithQueryParameter("SAID", m3_SAID.Trim());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SERI))
				request.WithQueryParameter("SERI", m3_SERI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGTP))
				request.WithQueryParameter("AGTP", m3_AGTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRES))
				request.WithQueryParameter("SRES", m3_SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMCD))
				request.WithQueryParameter("SMCD", m3_SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (m3_ETDT.HasValue)
				request.WithQueryParameter("ETDT", m3_ETDT.Value.ToM3String());
			if (m3_SIDT.HasValue)
				request.WithQueryParameter("SIDT", m3_SIDT.Value.ToM3String());
			if (m3_EIDT.HasValue)
				request.WithQueryParameter("EIDT", m3_EIDT.Value.ToM3String());
			if (m3_NODT.HasValue)
				request.WithQueryParameter("NODT", m3_NODT.Value.ToM3String());
			if (m3_IIDF.HasValue)
				request.WithQueryParameter("IIDF", m3_IIDF.Value.ToM3String());
			if (m3_IIDT.HasValue)
				request.WithQueryParameter("IIDT", m3_IIDT.Value.ToM3String());
			if (m3_IIYR.HasValue)
				request.WithQueryParameter("IIYR", m3_IIYR.Value.ToString());
			if (m3_IIMO.HasValue)
				request.WithQueryParameter("IIMO", m3_IIMO.Value.ToString());
			if (m3_IIWE.HasValue)
				request.WithQueryParameter("IIWE", m3_IIWE.Value.ToString());
			if (m3_IXYR.HasValue)
				request.WithQueryParameter("IXYR", m3_IXYR.Value.ToString());
			if (m3_IXMO.HasValue)
				request.WithQueryParameter("IXMO", m3_IXMO.Value.ToString());
			if (m3_IXWE.HasValue)
				request.WithQueryParameter("IXWE", m3_IXWE.Value.ToString());
			if (m3_IXVF.HasValue)
				request.WithQueryParameter("IXVF", m3_IXVF.Value.ToM3String());
			if (m3_IXVT.HasValue)
				request.WithQueryParameter("IXVT", m3_IXVT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_SPCO))
				request.WithQueryParameter("SPCO", m3_SPCO.Trim());
			if (m3_ANOS.HasValue)
				request.WithQueryParameter("ANOS", m3_ANOS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AHLD))
				request.WithQueryParameter("AHLD", m3_AHLD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARCC))
				request.WithQueryParameter("ARCC", m3_ARCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARCT))
				request.WithQueryParameter("ARCT", m3_ARCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DMOD))
				request.WithQueryParameter("DMOD", m3_DMOD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CMOD))
				request.WithQueryParameter("CMOD", m3_CMOD.Trim());
			if (m3_DLDT.HasValue)
				request.WithQueryParameter("DLDT", m3_DLDT.Value.ToM3String());
			if (m3_DETH.HasValue)
				request.WithQueryParameter("DETH", m3_DETH.Value.ToString());
			if (m3_DETM.HasValue)
				request.WithQueryParameter("DETM", m3_DETM.Value.ToString());
			if (m3_CODT.HasValue)
				request.WithQueryParameter("CODT", m3_CODT.Value.ToM3String());
			if (m3_COTH.HasValue)
				request.WithQueryParameter("COTH", m3_COTH.Value.ToString());
			if (m3_COTM.HasValue)
				request.WithQueryParameter("COTM", m3_COTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DTED))
				request.WithQueryParameter("DTED", m3_DTED.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTED))
				request.WithQueryParameter("CTED", m3_CTED.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEFO))
				request.WithQueryParameter("DEFO", m3_DEFO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CLFR))
				request.WithQueryParameter("CLFR", m3_CLFR.Trim());
			if (m3_DEOD.HasValue)
				request.WithQueryParameter("DEOD", m3_DEOD.Value.ToM3String());
			if (m3_COOD.HasValue)
				request.WithQueryParameter("COOD", m3_COOD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_DEFA))
				request.WithQueryParameter("DEFA", m3_DEFA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CLFA))
				request.WithQueryParameter("CLFA", m3_CLFA.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());

			// Execute the request
			var result = await Execute<AddLeasingLineResponse>(
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
		/// Name AddPreCalc
		/// Description This transaction adds Pre Calculations
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_IXCD">Price index (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_KIDE">Kit identity (Required)</param>
		/// <param name="m3_OAPR">Original price (Required)</param>
		/// <param name="m3_IXVO">Original index value</param>
		/// <param name="m3_IXVA">Price index value</param>
		/// <param name="m3_IXCA">Calculation index value</param>
		/// <param name="m3_IXPA">Index share - percentage</param>
		/// <param name="m3_RAPR">Rent adjustment price</param>
		/// <param name="m3_ANOS">Number of shifts</param>
		/// <param name="m3_CRSA">Create service agreement line</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPreCalc(
			string m3_AGNB, 
			int m3_PONR, 
			string m3_IXCD, 
			int m3_POSX, 
			string m3_KIDE, 
			decimal m3_OAPR, 
			decimal? m3_IXVO = null, 
			decimal? m3_IXVA = null, 
			decimal? m3_IXCA = null, 
			int? m3_IXPA = null, 
			decimal? m3_RAPR = null, 
			int? m3_ANOS = null, 
			int? m3_CRSA = null, 
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
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_IXCD))
				throw new ArgumentNullException("m3_IXCD");
			if (string.IsNullOrWhiteSpace(m3_KIDE))
				throw new ArgumentNullException("m3_KIDE");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("IXCD", m3_IXCD.Trim())
				.WithQueryParameter("POSX", m3_POSX.ToString())
				.WithQueryParameter("KIDE", m3_KIDE.Trim())
				.WithQueryParameter("OAPR", m3_OAPR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_IXVO.HasValue)
				request.WithQueryParameter("IXVO", m3_IXVO.Value.ToString());
			if (m3_IXVA.HasValue)
				request.WithQueryParameter("IXVA", m3_IXVA.Value.ToString());
			if (m3_IXCA.HasValue)
				request.WithQueryParameter("IXCA", m3_IXCA.Value.ToString());
			if (m3_IXPA.HasValue)
				request.WithQueryParameter("IXPA", m3_IXPA.Value.ToString());
			if (m3_RAPR.HasValue)
				request.WithQueryParameter("RAPR", m3_RAPR.Value.ToString());
			if (m3_ANOS.HasValue)
				request.WithQueryParameter("ANOS", m3_ANOS.Value.ToString());
			if (m3_CRSA.HasValue)
				request.WithQueryParameter("CRSA", m3_CRSA.Value.ToString());

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
		/// Name DelLTRAgree
		/// Description This transaction deletes LTR Agreement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelLTRAgree(
			string m3_AGNB, 
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
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim());

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
		/// Name DelLeasingLine
		/// Description This transaction deletes Leasing Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_CUPL">Customer site</param>
		/// <param name="m3_SAID">Address number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelLeasingLine(
			string m3_AGNB, 
			int m3_PONR, 
			int m3_POSX, 
			string m3_CUPL = null, 
			string m3_SAID = null, 
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
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUPL))
				request.WithQueryParameter("CUPL", m3_CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SAID))
				request.WithQueryParameter("SAID", m3_SAID.Trim());

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
		/// Name DelPreCalc
		/// Description This transaction deletes Pre Calculations
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_UPDC">Update (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelPreCalc(
			string m3_AGNB, 
			int m3_PONR, 
			int m3_POSX, 
			int m3_UPDC, 
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
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString())
				.WithQueryParameter("UPDC", m3_UPDC.ToString());

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
		/// Name GetAgreeKit
		/// Description This transaction gets Agreements Kits
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_KTNO">Kit number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgreeKitResponse></returns>
		/// <exception cref="M3Exception<GetAgreeKitResponse>"></exception>
		public async Task<M3Response<GetAgreeKitResponse>> GetAgreeKit(
			string m3_KTNO, 
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
			if (string.IsNullOrWhiteSpace(m3_KTNO))
				throw new ArgumentNullException("m3_KTNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("KTNO", m3_KTNO.Trim());

			// Execute the request
			var result = await Execute<GetAgreeKitResponse>(
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
		/// Name GetInterest
		/// Description This transaction gets LTR agreement lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_INTT">Interest type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInterestResponse></returns>
		/// <exception cref="M3Exception<GetInterestResponse>"></exception>
		public async Task<M3Response<GetInterestResponse>> GetInterest(
			string m3_INTT, 
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
			if (string.IsNullOrWhiteSpace(m3_INTT))
				throw new ArgumentNullException("m3_INTT");

			// Set mandatory parameters
			request
				.WithQueryParameter("INTT", m3_INTT.Trim());

			// Execute the request
			var result = await Execute<GetInterestResponse>(
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
		/// Name GetLTRAgree
		/// Description This transaction gets LTR Agreement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLTRAgreeResponse></returns>
		/// <exception cref="M3Exception<GetLTRAgreeResponse>"></exception>
		public async Task<M3Response<GetLTRAgreeResponse>> GetLTRAgree(
			string m3_AGNB, 
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
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim());

			// Execute the request
			var result = await Execute<GetLTRAgreeResponse>(
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
		/// Name GetLeaseCond
		/// Description This transaction gets LTR Lease Cond
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SBNO">Subnumber (Required)</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLeaseCondResponse></returns>
		/// <exception cref="M3Exception<GetLeaseCondResponse>"></exception>
		public async Task<M3Response<GetLeaseCondResponse>> GetLeaseCond(
			string m3_AGNB, 
			int m3_PONR, 
			int m3_POSX, 
			string m3_ITNO, 
			int m3_SBNO, 
			string m3_BANO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SBNO", m3_SBNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());

			// Execute the request
			var result = await Execute<GetLeaseCondResponse>(
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
		/// Name GetLeasingLine
		/// Description This transaction gets Leasing Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CUPL">Customer site</param>
		/// <param name="m3_SAID">Address number</param>
		/// <param name="m3_SERI">Serial number</param>
		/// <param name="m3_AGTP">Agreement type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLeasingLineResponse></returns>
		/// <exception cref="M3Exception<GetLeasingLineResponse>"></exception>
		public async Task<M3Response<GetLeasingLineResponse>> GetLeasingLine(
			string m3_AGNB, 
			int m3_PONR, 
			int m3_POSX, 
			string m3_ITNO, 
			string m3_CUPL = null, 
			string m3_SAID = null, 
			string m3_SERI = null, 
			string m3_AGTP = null, 
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
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUPL))
				request.WithQueryParameter("CUPL", m3_CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SAID))
				request.WithQueryParameter("SAID", m3_SAID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERI))
				request.WithQueryParameter("SERI", m3_SERI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGTP))
				request.WithQueryParameter("AGTP", m3_AGTP.Trim());

			// Execute the request
			var result = await Execute<GetLeasingLineResponse>(
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
		/// Name LstAgreeKit
		/// Description This transaction lists Agreement Kits
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_KTNO">Kit number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgreeKitResponse></returns>
		/// <exception cref="M3Exception<LstAgreeKitResponse>"></exception>
		public async Task<M3Response<LstAgreeKitResponse>> LstAgreeKit(
			string m3_KTNO = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_KTNO))
				request.WithQueryParameter("KTNO", m3_KTNO.Trim());

			// Execute the request
			var result = await Execute<LstAgreeKitResponse>(
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
		/// Name LstInterest
		/// Description This transaction lists LTR agreement line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_INTT">Interest type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInterestResponse></returns>
		/// <exception cref="M3Exception<LstInterestResponse>"></exception>
		public async Task<M3Response<LstInterestResponse>> LstInterest(
			string m3_INTT = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_INTT))
				request.WithQueryParameter("INTT", m3_INTT.Trim());

			// Execute the request
			var result = await Execute<LstInterestResponse>(
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
		/// Name LstLTRByAgree
		/// Description This transaction lists LTR agreement line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLTRByAgreeResponse></returns>
		/// <exception cref="M3Exception<LstLTRByAgreeResponse>"></exception>
		public async Task<M3Response<LstLTRByAgreeResponse>> LstLTRByAgree(
			string m3_FACI = null, 
			string m3_AGNB = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());

			// Execute the request
			var result = await Execute<LstLTRByAgreeResponse>(
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
		/// Name LstLTRByCo
		/// Description This transaction lists LTR Agreement lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLTRByCoResponse></returns>
		/// <exception cref="M3Exception<LstLTRByCoResponse>"></exception>
		public async Task<M3Response<LstLTRByCoResponse>> LstLTRByCo(
			string m3_FACI = null, 
			string m3_ORNO = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Execute the request
			var result = await Execute<LstLTRByCoResponse>(
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
		/// Name LstLTRByCust
		/// Description This transaction lists LTR By Costomer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_AGCN">Agreement customer</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLTRByCustResponse></returns>
		/// <exception cref="M3Exception<LstLTRByCustResponse>"></exception>
		public async Task<M3Response<LstLTRByCustResponse>> LstLTRByCust(
			string m3_FACI = null, 
			string m3_AGCN = null, 
			string m3_AGNB = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGCN))
				request.WithQueryParameter("AGCN", m3_AGCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());

			// Execute the request
			var result = await Execute<LstLTRByCustResponse>(
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
		/// Name LstLTRByPayer
		/// Description This transaction list LTR By Payer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLTRByPayerResponse></returns>
		/// <exception cref="M3Exception<LstLTRByPayerResponse>"></exception>
		public async Task<M3Response<LstLTRByPayerResponse>> LstLTRByPayer(
			string m3_FACI = null, 
			string m3_PYNO = null, 
			string m3_AGNB = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());

			// Execute the request
			var result = await Execute<LstLTRByPayerResponse>(
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
		/// Name LstLeaseCond
		/// Description This transaction lists LTR Lease Cond
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_SBNO">Subnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLeaseCondResponse></returns>
		/// <exception cref="M3Exception<LstLeaseCondResponse>"></exception>
		public async Task<M3Response<LstLeaseCondResponse>> LstLeaseCond(
			string m3_AGNB, 
			int m3_PONR, 
			int m3_POSX, 
			string m3_ITNO, 
			string m3_BANO = null, 
			int? m3_SBNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_SBNO.HasValue)
				request.WithQueryParameter("SBNO", m3_SBNO.Value.ToString());

			// Execute the request
			var result = await Execute<LstLeaseCondResponse>(
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
		/// Name LstLeasingLine
		/// Description This transaction lists Leasing Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_CUPL">Customer site</param>
		/// <param name="m3_SAID">Address number</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLeasingLineResponse></returns>
		/// <exception cref="M3Exception<LstLeasingLineResponse>"></exception>
		public async Task<M3Response<LstLeasingLineResponse>> LstLeasingLine(
			string m3_AGNB, 
			string m3_CUPL = null, 
			string m3_SAID = null, 
			int? m3_PONR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLeasingLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUPL))
				request.WithQueryParameter("CUPL", m3_CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SAID))
				request.WithQueryParameter("SAID", m3_SAID.Trim());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());

			// Execute the request
			var result = await Execute<LstLeasingLineResponse>(
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
		/// Name UpdLTRHead
		/// Description This transaction updates LTR Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_AGCN">Agreement customer</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_USID">User</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_SMCD">Salesperson</param>
		/// <param name="m3_AGRE">LTR agreement responsible</param>
		/// <param name="m3_SRES">Service manager</param>
		/// <param name="m3_ARCC">Reason code - created agreement</param>
		/// <param name="m3_ARCT">Reason code - terminated agreement</param>
		/// <param name="m3_AGRC">LTR agreement conditions</param>
		/// <param name="m3_PKIT">Kit price printout</param>
		/// <param name="m3_AGTP">Agreement type</param>
		/// <param name="m3_IIYR">Invoicing interval - years</param>
		/// <param name="m3_IIMO">Invoicing interval - months</param>
		/// <param name="m3_IIWE">Invoicing interval - weeks</param>
		/// <param name="m3_IXCD">Price index</param>
		/// <param name="m3_IXYR">Index interval years</param>
		/// <param name="m3_IXMO">Index interval months</param>
		/// <param name="m3_IXWE">Index interval weeks</param>
		/// <param name="m3_ANOS">Number of shifts</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdLTRHead(
			string m3_AGNB, 
			string m3_AGCN = null, 
			string m3_CUOR = null, 
			string m3_USID = null, 
			string m3_TEPY = null, 
			string m3_SMCD = null, 
			string m3_AGRE = null, 
			string m3_SRES = null, 
			string m3_ARCC = null, 
			string m3_ARCT = null, 
			string m3_AGRC = null, 
			int? m3_PKIT = null, 
			string m3_AGTP = null, 
			int? m3_IIYR = null, 
			int? m3_IIMO = null, 
			int? m3_IIWE = null, 
			string m3_IXCD = null, 
			int? m3_IXYR = null, 
			int? m3_IXMO = null, 
			int? m3_IXWE = null, 
			int? m3_ANOS = null, 
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
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_AGCN))
				request.WithQueryParameter("AGCN", m3_AGCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMCD))
				request.WithQueryParameter("SMCD", m3_SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGRE))
				request.WithQueryParameter("AGRE", m3_AGRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRES))
				request.WithQueryParameter("SRES", m3_SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARCC))
				request.WithQueryParameter("ARCC", m3_ARCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARCT))
				request.WithQueryParameter("ARCT", m3_ARCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGRC))
				request.WithQueryParameter("AGRC", m3_AGRC.Trim());
			if (m3_PKIT.HasValue)
				request.WithQueryParameter("PKIT", m3_PKIT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AGTP))
				request.WithQueryParameter("AGTP", m3_AGTP.Trim());
			if (m3_IIYR.HasValue)
				request.WithQueryParameter("IIYR", m3_IIYR.Value.ToString());
			if (m3_IIMO.HasValue)
				request.WithQueryParameter("IIMO", m3_IIMO.Value.ToString());
			if (m3_IIWE.HasValue)
				request.WithQueryParameter("IIWE", m3_IIWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_IXCD))
				request.WithQueryParameter("IXCD", m3_IXCD.Trim());
			if (m3_IXYR.HasValue)
				request.WithQueryParameter("IXYR", m3_IXYR.Value.ToString());
			if (m3_IXMO.HasValue)
				request.WithQueryParameter("IXMO", m3_IXMO.Value.ToString());
			if (m3_IXWE.HasValue)
				request.WithQueryParameter("IXWE", m3_IXWE.Value.ToString());
			if (m3_ANOS.HasValue)
				request.WithQueryParameter("ANOS", m3_ANOS.Value.ToString());

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
		/// Name UpdLeaseCond
		/// Description This transaction updates Leasing Cond
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SBNO">Subnumber (Required)</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_TX25">Text</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_NOPR">Number of periods</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_CMPP">Months/period</param>
		/// <param name="m3_INVM">Invoicing method</param>
		/// <param name="m3_CSPR">Customer price</param>
		/// <param name="m3_RESV">Residual value</param>
		/// <param name="m3_REPE">Residual %</param>
		/// <param name="m3_INTT">Interest type</param>
		/// <param name="m3_INPE">Interest rate</param>
		/// <param name="m3_RENT">Rent amount</param>
		/// <param name="m3_INLL">Minimun variable interest rate</param>
		/// <param name="m3_INTH">Interest threshold value</param>
		/// <param name="m3_FFA1">User-defined field 1 alfa</param>
		/// <param name="m3_FFA2">User-defined field 1 alfa</param>
		/// <param name="m3_FFA3">User-defined field 1 alfa</param>
		/// <param name="m3_FFA4">User-defined field 1 alfa</param>
		/// <param name="m3_FFA5">User-defined field 1 alfa</param>
		/// <param name="m3_FFA6">User-defined field 1 alfa</param>
		/// <param name="m3_FFA7">User-defined field 1 alfa</param>
		/// <param name="m3_FFA8">User-defined field 1 alfa</param>
		/// <param name="m3_FFA9">User-defined field 1 alfa</param>
		/// <param name="m3_FFA0">User-defined field 1 alfa</param>
		/// <param name="m3_FFN1">User-defined field 1 numeric</param>
		/// <param name="m3_FFN2">User-defined field 1 numeric</param>
		/// <param name="m3_FFN3">User-defined field 1 numeric</param>
		/// <param name="m3_FFN4">User-defined field 1 numeric</param>
		/// <param name="m3_FFN5">User-defined field 1 numeric</param>
		/// <param name="m3_FFN6">User-defined field 1 numeric</param>
		/// <param name="m3_FFN7">User-defined field 1 numeric</param>
		/// <param name="m3_FFN8">User-defined field 1 numeric</param>
		/// <param name="m3_FFN9">User-defined field 1 numeric</param>
		/// <param name="m3_FFN0">User-defined field 1 numeric</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdLeaseCond(
			string m3_AGNB, 
			int m3_PONR, 
			int m3_POSX, 
			string m3_ITNO, 
			int m3_SBNO, 
			string m3_BANO = null, 
			string m3_TX25 = null, 
			string m3_STAT = null, 
			int? m3_NOPR = null, 
			DateTime? m3_FVDT = null, 
			int? m3_CMPP = null, 
			string m3_INVM = null, 
			decimal? m3_CSPR = null, 
			decimal? m3_RESV = null, 
			int? m3_REPE = null, 
			string m3_INTT = null, 
			decimal? m3_INPE = null, 
			decimal? m3_RENT = null, 
			decimal? m3_INLL = null, 
			int? m3_INTH = null, 
			string m3_FFA1 = null, 
			string m3_FFA2 = null, 
			string m3_FFA3 = null, 
			string m3_FFA4 = null, 
			string m3_FFA5 = null, 
			string m3_FFA6 = null, 
			string m3_FFA7 = null, 
			string m3_FFA8 = null, 
			string m3_FFA9 = null, 
			string m3_FFA0 = null, 
			decimal? m3_FFN1 = null, 
			decimal? m3_FFN2 = null, 
			decimal? m3_FFN3 = null, 
			decimal? m3_FFN4 = null, 
			decimal? m3_FFN5 = null, 
			decimal? m3_FFN6 = null, 
			decimal? m3_FFN7 = null, 
			decimal? m3_FFN8 = null, 
			decimal? m3_FFN9 = null, 
			decimal? m3_FFN0 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SBNO", m3_SBNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX25))
				request.WithQueryParameter("TX25", m3_TX25.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_NOPR.HasValue)
				request.WithQueryParameter("NOPR", m3_NOPR.Value.ToString());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_CMPP.HasValue)
				request.WithQueryParameter("CMPP", m3_CMPP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INVM))
				request.WithQueryParameter("INVM", m3_INVM.Trim());
			if (m3_CSPR.HasValue)
				request.WithQueryParameter("CSPR", m3_CSPR.Value.ToString());
			if (m3_RESV.HasValue)
				request.WithQueryParameter("RESV", m3_RESV.Value.ToString());
			if (m3_REPE.HasValue)
				request.WithQueryParameter("REPE", m3_REPE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INTT))
				request.WithQueryParameter("INTT", m3_INTT.Trim());
			if (m3_INPE.HasValue)
				request.WithQueryParameter("INPE", m3_INPE.Value.ToString());
			if (m3_RENT.HasValue)
				request.WithQueryParameter("RENT", m3_RENT.Value.ToString());
			if (m3_INLL.HasValue)
				request.WithQueryParameter("INLL", m3_INLL.Value.ToString());
			if (m3_INTH.HasValue)
				request.WithQueryParameter("INTH", m3_INTH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FFA1))
				request.WithQueryParameter("FFA1", m3_FFA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA2))
				request.WithQueryParameter("FFA2", m3_FFA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA3))
				request.WithQueryParameter("FFA3", m3_FFA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA4))
				request.WithQueryParameter("FFA4", m3_FFA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA5))
				request.WithQueryParameter("FFA5", m3_FFA5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA6))
				request.WithQueryParameter("FFA6", m3_FFA6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA7))
				request.WithQueryParameter("FFA7", m3_FFA7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA8))
				request.WithQueryParameter("FFA8", m3_FFA8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA9))
				request.WithQueryParameter("FFA9", m3_FFA9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA0))
				request.WithQueryParameter("FFA0", m3_FFA0.Trim());
			if (m3_FFN1.HasValue)
				request.WithQueryParameter("FFN1", m3_FFN1.Value.ToString());
			if (m3_FFN2.HasValue)
				request.WithQueryParameter("FFN2", m3_FFN2.Value.ToString());
			if (m3_FFN3.HasValue)
				request.WithQueryParameter("FFN3", m3_FFN3.Value.ToString());
			if (m3_FFN4.HasValue)
				request.WithQueryParameter("FFN4", m3_FFN4.Value.ToString());
			if (m3_FFN5.HasValue)
				request.WithQueryParameter("FFN5", m3_FFN5.Value.ToString());
			if (m3_FFN6.HasValue)
				request.WithQueryParameter("FFN6", m3_FFN6.Value.ToString());
			if (m3_FFN7.HasValue)
				request.WithQueryParameter("FFN7", m3_FFN7.Value.ToString());
			if (m3_FFN8.HasValue)
				request.WithQueryParameter("FFN8", m3_FFN8.Value.ToString());
			if (m3_FFN9.HasValue)
				request.WithQueryParameter("FFN9", m3_FFN9.Value.ToString());
			if (m3_FFN0.HasValue)
				request.WithQueryParameter("FFN0", m3_FFN0.Value.ToString());

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
		/// Name UpdLeasingLine
		/// Description This transaction updates Leasing Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_IIYR">Invoicing interval - years (Required)</param>
		/// <param name="m3_CUPL">Customer site</param>
		/// <param name="m3_SAID">Address number</param>
		/// <param name="m3_SERI">Serial number</param>
		/// <param name="m3_AGTP">Agreement type</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_SRES">Service manager</param>
		/// <param name="m3_SMCD">Salesperson</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_NOPR">Number of periods</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_ETDT">Current valid to</param>
		/// <param name="m3_SIDT">Invoicing start date</param>
		/// <param name="m3_EIDT">Invoicing end date</param>
		/// <param name="m3_NODT">Next invoice date</param>
		/// <param name="m3_IIDF">Start date - invoicing range</param>
		/// <param name="m3_IIDT">End date - invoicing range</param>
		/// <param name="m3_IIMO">Invoicing interval - months</param>
		/// <param name="m3_IIWE">Invoicing interval - weeks</param>
		/// <param name="m3_IXYR">Index interval years</param>
		/// <param name="m3_IXMO">Index interval months</param>
		/// <param name="m3_IXWE">Index interval weeks</param>
		/// <param name="m3_IXVF">Valid from</param>
		/// <param name="m3_IXVT">Valid to</param>
		/// <param name="m3_INVM">Invoicing method</param>
		/// <param name="m3_SPCO">Split code - invoicing</param>
		/// <param name="m3_ANOS">Number of shifts</param>
		/// <param name="m3_AHLD">Hold code</param>
		/// <param name="m3_ARCC">Reason code - created agreement</param>
		/// <param name="m3_ARCT">Reason code - terminated agreement</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_FWHL">From warehouse</param>
		/// <param name="m3_TWHL">To warehouse</param>
		/// <param name="m3_DMOD">Delivery method</param>
		/// <param name="m3_CMOD">Delivery method - return</param>
		/// <param name="m3_DLDT">Planned delivery date</param>
		/// <param name="m3_DETH">Time of departure - hours</param>
		/// <param name="m3_DETM">Time of departure - minutes</param>
		/// <param name="m3_CODT">Confirmed Delivary date</param>
		/// <param name="m3_COTH">Pickup time hours</param>
		/// <param name="m3_COTM">Pickup minutes</param>
		/// <param name="m3_DTED">Delivery terms</param>
		/// <param name="m3_CTED">Delivery terms</param>
		/// <param name="m3_DEFO">Delivery ordered by</param>
		/// <param name="m3_CLFR">Rental return ordered by</param>
		/// <param name="m3_DEOD">Delivery order date</param>
		/// <param name="m3_COOD">Rental return order date</param>
		/// <param name="m3_DEFA">Delivery freight agreement number</param>
		/// <param name="m3_CLFA">Freight agreement number - rental return</param>
		/// <param name="m3_AIT1">Accounting dimension 1</param>
		/// <param name="m3_AIT2">Accounting dimension 2</param>
		/// <param name="m3_AIT3">Accounting dimension 3</param>
		/// <param name="m3_AIT4">Accounting dimension 4</param>
		/// <param name="m3_AIT5">Accounting dimension 5</param>
		/// <param name="m3_AIT6">Accounting dimension 6</param>
		/// <param name="m3_AIT7">Accounting dimension 7</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdLeasingLine(
			string m3_AGNB, 
			int m3_PONR, 
			int m3_POSX, 
			string m3_ITNO, 
			int m3_IIYR, 
			string m3_CUPL = null, 
			string m3_SAID = null, 
			string m3_SERI = null, 
			string m3_AGTP = null, 
			string m3_PYNO = null, 
			string m3_SRES = null, 
			string m3_SMCD = null, 
			string m3_ORNO = null, 
			int? m3_NOPR = null, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_ETDT = null, 
			DateTime? m3_SIDT = null, 
			DateTime? m3_EIDT = null, 
			DateTime? m3_NODT = null, 
			DateTime? m3_IIDF = null, 
			DateTime? m3_IIDT = null, 
			int? m3_IIMO = null, 
			int? m3_IIWE = null, 
			int? m3_IXYR = null, 
			int? m3_IXMO = null, 
			int? m3_IXWE = null, 
			DateTime? m3_IXVF = null, 
			DateTime? m3_IXVT = null, 
			string m3_INVM = null, 
			string m3_SPCO = null, 
			int? m3_ANOS = null, 
			string m3_AHLD = null, 
			string m3_ARCC = null, 
			string m3_ARCT = null, 
			string m3_BREM = null, 
			string m3_FWHL = null, 
			string m3_TWHL = null, 
			string m3_DMOD = null, 
			string m3_CMOD = null, 
			DateTime? m3_DLDT = null, 
			int? m3_DETH = null, 
			int? m3_DETM = null, 
			DateTime? m3_CODT = null, 
			int? m3_COTH = null, 
			int? m3_COTM = null, 
			string m3_DTED = null, 
			string m3_CTED = null, 
			string m3_DEFO = null, 
			string m3_CLFR = null, 
			DateTime? m3_DEOD = null, 
			DateTime? m3_COOD = null, 
			string m3_DEFA = null, 
			string m3_CLFA = null, 
			string m3_AIT1 = null, 
			string m3_AIT2 = null, 
			string m3_AIT3 = null, 
			string m3_AIT4 = null, 
			string m3_AIT5 = null, 
			string m3_AIT6 = null, 
			string m3_AIT7 = null, 
			string m3_PROJ = null, 
			string m3_ACRF = null, 
			string m3_ELNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("IIYR", m3_IIYR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUPL))
				request.WithQueryParameter("CUPL", m3_CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SAID))
				request.WithQueryParameter("SAID", m3_SAID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERI))
				request.WithQueryParameter("SERI", m3_SERI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGTP))
				request.WithQueryParameter("AGTP", m3_AGTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRES))
				request.WithQueryParameter("SRES", m3_SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMCD))
				request.WithQueryParameter("SMCD", m3_SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (m3_NOPR.HasValue)
				request.WithQueryParameter("NOPR", m3_NOPR.Value.ToString());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_ETDT.HasValue)
				request.WithQueryParameter("ETDT", m3_ETDT.Value.ToM3String());
			if (m3_SIDT.HasValue)
				request.WithQueryParameter("SIDT", m3_SIDT.Value.ToM3String());
			if (m3_EIDT.HasValue)
				request.WithQueryParameter("EIDT", m3_EIDT.Value.ToM3String());
			if (m3_NODT.HasValue)
				request.WithQueryParameter("NODT", m3_NODT.Value.ToM3String());
			if (m3_IIDF.HasValue)
				request.WithQueryParameter("IIDF", m3_IIDF.Value.ToM3String());
			if (m3_IIDT.HasValue)
				request.WithQueryParameter("IIDT", m3_IIDT.Value.ToM3String());
			if (m3_IIMO.HasValue)
				request.WithQueryParameter("IIMO", m3_IIMO.Value.ToString());
			if (m3_IIWE.HasValue)
				request.WithQueryParameter("IIWE", m3_IIWE.Value.ToString());
			if (m3_IXYR.HasValue)
				request.WithQueryParameter("IXYR", m3_IXYR.Value.ToString());
			if (m3_IXMO.HasValue)
				request.WithQueryParameter("IXMO", m3_IXMO.Value.ToString());
			if (m3_IXWE.HasValue)
				request.WithQueryParameter("IXWE", m3_IXWE.Value.ToString());
			if (m3_IXVF.HasValue)
				request.WithQueryParameter("IXVF", m3_IXVF.Value.ToM3String());
			if (m3_IXVT.HasValue)
				request.WithQueryParameter("IXVT", m3_IXVT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_INVM))
				request.WithQueryParameter("INVM", m3_INVM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPCO))
				request.WithQueryParameter("SPCO", m3_SPCO.Trim());
			if (m3_ANOS.HasValue)
				request.WithQueryParameter("ANOS", m3_ANOS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AHLD))
				request.WithQueryParameter("AHLD", m3_AHLD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARCC))
				request.WithQueryParameter("ARCC", m3_ARCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARCT))
				request.WithQueryParameter("ARCT", m3_ARCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FWHL))
				request.WithQueryParameter("FWHL", m3_FWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWHL))
				request.WithQueryParameter("TWHL", m3_TWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DMOD))
				request.WithQueryParameter("DMOD", m3_DMOD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CMOD))
				request.WithQueryParameter("CMOD", m3_CMOD.Trim());
			if (m3_DLDT.HasValue)
				request.WithQueryParameter("DLDT", m3_DLDT.Value.ToM3String());
			if (m3_DETH.HasValue)
				request.WithQueryParameter("DETH", m3_DETH.Value.ToString());
			if (m3_DETM.HasValue)
				request.WithQueryParameter("DETM", m3_DETM.Value.ToString());
			if (m3_CODT.HasValue)
				request.WithQueryParameter("CODT", m3_CODT.Value.ToM3String());
			if (m3_COTH.HasValue)
				request.WithQueryParameter("COTH", m3_COTH.Value.ToString());
			if (m3_COTM.HasValue)
				request.WithQueryParameter("COTM", m3_COTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DTED))
				request.WithQueryParameter("DTED", m3_DTED.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTED))
				request.WithQueryParameter("CTED", m3_CTED.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEFO))
				request.WithQueryParameter("DEFO", m3_DEFO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CLFR))
				request.WithQueryParameter("CLFR", m3_CLFR.Trim());
			if (m3_DEOD.HasValue)
				request.WithQueryParameter("DEOD", m3_DEOD.Value.ToM3String());
			if (m3_COOD.HasValue)
				request.WithQueryParameter("COOD", m3_COOD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_DEFA))
				request.WithQueryParameter("DEFA", m3_DEFA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CLFA))
				request.WithQueryParameter("CLFA", m3_CLFA.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());

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
		/// Name UpdPreCalc
		/// Description This transaction updates Pre Calculations
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_IXCD">Price index (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_UPDC">Update (Required)</param>
		/// <param name="m3_IXVO">Original index value</param>
		/// <param name="m3_IXVA">Price index value</param>
		/// <param name="m3_IXCA">Calculation index value</param>
		/// <param name="m3_IXPA">Index share - percentage</param>
		/// <param name="m3_RAPR">Rent adjustment price</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_OAPR">Original price</param>
		/// <param name="m3_INAL">Index adjustment line</param>
		/// <param name="m3_CRSA">Create service agreement line</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPreCalc(
			string m3_AGNB, 
			int m3_PONR, 
			string m3_IXCD, 
			int m3_POSX, 
			int m3_UPDC, 
			decimal? m3_IXVO = null, 
			decimal? m3_IXVA = null, 
			decimal? m3_IXCA = null, 
			int? m3_IXPA = null, 
			decimal? m3_RAPR = null, 
			string m3_ITDS = null, 
			decimal? m3_OAPR = null, 
			int? m3_INAL = null, 
			int? m3_CRSA = null, 
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
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_IXCD))
				throw new ArgumentNullException("m3_IXCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("IXCD", m3_IXCD.Trim())
				.WithQueryParameter("POSX", m3_POSX.ToString())
				.WithQueryParameter("UPDC", m3_UPDC.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_IXVO.HasValue)
				request.WithQueryParameter("IXVO", m3_IXVO.Value.ToString());
			if (m3_IXVA.HasValue)
				request.WithQueryParameter("IXVA", m3_IXVA.Value.ToString());
			if (m3_IXCA.HasValue)
				request.WithQueryParameter("IXCA", m3_IXCA.Value.ToString());
			if (m3_IXPA.HasValue)
				request.WithQueryParameter("IXPA", m3_IXPA.Value.ToString());
			if (m3_RAPR.HasValue)
				request.WithQueryParameter("RAPR", m3_RAPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (m3_OAPR.HasValue)
				request.WithQueryParameter("OAPR", m3_OAPR.Value.ToString());
			if (m3_INAL.HasValue)
				request.WithQueryParameter("INAL", m3_INAL.Value.ToString());
			if (m3_CRSA.HasValue)
				request.WithQueryParameter("CRSA", m3_CRSA.Value.ToString());

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
