/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.PPS200MI;
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
	/// Name: PPS200MI
	/// Component Name: PurchaseOrder
	/// Description: Purchase Order interface
	/// Version Release: 5ea9
	///</summary>
	public partial class PPS200MIResource : M3BaseResourceEndpoint
	{
		public PPS200MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PPS200MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddLine
		/// Description AddLine
		/// Version Release: 5ea9
		/// </summary>
		/// <param name="m3PUNO">Purchase order number (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3ORQA">Ordered quantity - alternate U/M (Required)</param>
		/// <param name="m3PNLI">Purchase order line</param>
		/// <param name="m3PNLS">Purchase order line subnumber</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3DWDT">Requested delivery date</param>
		/// <param name="m3SITE">Supplier item number</param>
		/// <param name="m3PITD">Purchase order item name</param>
		/// <param name="m3PITT">Purchase order item description</param>
		/// <param name="m3PROD">Manufacturer</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="m3REVN">PO Revision number</param>
		/// <param name="m3ETRF">External instruction</param>
		/// <param name="m3PUPR">Purchase price</param>
		/// <param name="m3ODI1">Discount 1</param>
		/// <param name="m3ODI2">Discount 2</param>
		/// <param name="m3ODI3">Discount 3</param>
		/// <param name="m3PUUN">Purchase order U/M</param>
		/// <param name="m3PPUN">Purchase price U/M</param>
		/// <param name="m3PUCD">Purchase price quantity</param>
		/// <param name="m3PTCD">Purchase price text</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3OURR">Our reference number</param>
		/// <param name="m3OURT">Reference type</param>
		/// <param name="m3PRIP">Priority</param>
		/// <param name="m3FUSC">Monitoring activity list</param>
		/// <param name="m3PURC">Requisition by</param>
		/// <param name="m3BUYE">Buyer</param>
		/// <param name="m3TERE">Technical supervisor</param>
		/// <param name="m3GRMT">Goods receiving method</param>
		/// <param name="m3IRCV">Recipient</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3VTCD">VAT code</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3COCE">Cost center</param>
		/// <param name="m3CSNO">Customs statistical number</param>
		/// <param name="m3ECLC">Labor code - trade statistics (TST)</param>
		/// <param name="m3VRCD">Business type - trade statistics (TST)</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3CPRI">Customs procedure - import</param>
		/// <param name="m3HAFE">Harbor or airport</param>
		/// <param name="m3TAXC">Tax code customer/address</param>
		/// <param name="m3TIHM">Time hours & minutes</param>
		/// <param name="m3MSTN">Milestone chain</param>
		/// <param name="m3UPCK">Unpack</param>
		/// <param name="m3ORCO">Country of origin</param>
		/// <param name="m3GEOC">Geographical code</param>
		/// <param name="m3TRRC">Order relation category</param>
		/// <param name="m3TRRN">Order relation number</param>
		/// <param name="m3TRRL">Order relation line</param>
		/// <param name="m3TRRX">Line suffix</param>
		/// <param name="m3RASN">Rail station</param>
		/// <param name="m3PIAD">Pickup address number</param>
		/// <param name="m3ORAD">Origin address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLine(
			string m3PUNO, 
			string m3ITNO, 
			decimal m3ORQA, 
			int? m3PNLI = null, 
			int? m3PNLS = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
			string m3SUNO = null, 
			DateTime? m3DWDT = null, 
			string m3SITE = null, 
			string m3PITD = null, 
			string m3PITT = null, 
			string m3PROD = null, 
			string m3ECVE = null, 
			string m3REVN = null, 
			string m3ETRF = null, 
			decimal? m3PUPR = null, 
			int? m3ODI1 = null, 
			int? m3ODI2 = null, 
			int? m3ODI3 = null, 
			string m3PUUN = null, 
			string m3PPUN = null, 
			int? m3PUCD = null, 
			int? m3PTCD = null, 
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3OURR = null, 
			string m3OURT = null, 
			string m3PRIP = null, 
			string m3FUSC = null, 
			string m3PURC = null, 
			string m3BUYE = null, 
			string m3TERE = null, 
			string m3GRMT = null, 
			string m3IRCV = null, 
			string m3PACT = null, 
			int? m3VTCD = null, 
			string m3ACRF = null, 
			string m3COCE = null, 
			string m3CSNO = null, 
			string m3ECLC = null, 
			string m3VRCD = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3CPRI = null, 
			string m3HAFE = null, 
			string m3TAXC = null, 
			int? m3TIHM = null, 
			long? m3MSTN = null, 
			int? m3UPCK = null, 
			string m3ORCO = null, 
			int? m3GEOC = null, 
			int? m3TRRC = null, 
			string m3TRRN = null, 
			int? m3TRRL = null, 
			int? m3TRRX = null, 
			string m3RASN = null, 
			string m3PIAD = null, 
			string m3ORAD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("ORQA", m3ORQA.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3PNLI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3PNLS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3DWDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3SITE))
				request.WithQueryParameter("SITE", m3SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3PITD))
				request.WithQueryParameter("PITD", m3PITD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PITT))
				request.WithQueryParameter("PITT", m3PITT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROD))
				request.WithQueryParameter("PROD", m3PROD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3REVN))
				request.WithQueryParameter("REVN", m3REVN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETRF))
				request.WithQueryParameter("ETRF", m3ETRF.Trim());
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ODI1.HasValue)
				request.WithQueryParameter("ODI1", m3ODI1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ODI2.HasValue)
				request.WithQueryParameter("ODI2", m3ODI2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ODI3.HasValue)
				request.WithQueryParameter("ODI3", m3ODI3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PUUN))
				request.WithQueryParameter("PUUN", m3PUUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PPUN))
				request.WithQueryParameter("PPUN", m3PPUN.Trim());
			if (m3PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3PUCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PTCD.HasValue)
				request.WithQueryParameter("PTCD", m3PTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OURR))
				request.WithQueryParameter("OURR", m3OURR.Trim());
			if (!string.IsNullOrWhiteSpace(m3OURT))
				request.WithQueryParameter("OURT", m3OURT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRIP))
				request.WithQueryParameter("PRIP", m3PRIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FUSC))
				request.WithQueryParameter("FUSC", m3FUSC.Trim());
			if (!string.IsNullOrWhiteSpace(m3PURC))
				request.WithQueryParameter("PURC", m3PURC.Trim());
			if (!string.IsNullOrWhiteSpace(m3BUYE))
				request.WithQueryParameter("BUYE", m3BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3TERE))
				request.WithQueryParameter("TERE", m3TERE.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRMT))
				request.WithQueryParameter("GRMT", m3GRMT.Trim());
			if (!string.IsNullOrWhiteSpace(m3IRCV))
				request.WithQueryParameter("IRCV", m3IRCV.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (m3VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3VTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3COCE))
				request.WithQueryParameter("COCE", m3COCE.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSNO))
				request.WithQueryParameter("CSNO", m3CSNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECLC))
				request.WithQueryParameter("ECLC", m3ECLC.Trim());
			if (!string.IsNullOrWhiteSpace(m3VRCD))
				request.WithQueryParameter("VRCD", m3VRCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CPRI))
				request.WithQueryParameter("CPRI", m3CPRI.Trim());
			if (!string.IsNullOrWhiteSpace(m3HAFE))
				request.WithQueryParameter("HAFE", m3HAFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAXC))
				request.WithQueryParameter("TAXC", m3TAXC.Trim());
			if (m3TIHM.HasValue)
				request.WithQueryParameter("TIHM", m3TIHM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSTN.HasValue)
				request.WithQueryParameter("MSTN", m3MSTN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UPCK.HasValue)
				request.WithQueryParameter("UPCK", m3UPCK.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORCO))
				request.WithQueryParameter("ORCO", m3ORCO.Trim());
			if (m3GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3GEOC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRRC.HasValue)
				request.WithQueryParameter("TRRC", m3TRRC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TRRN))
				request.WithQueryParameter("TRRN", m3TRRN.Trim());
			if (m3TRRL.HasValue)
				request.WithQueryParameter("TRRL", m3TRRL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRRX.HasValue)
				request.WithQueryParameter("TRRX", m3TRRX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RASN))
				request.WithQueryParameter("RASN", m3RASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PIAD))
				request.WithQueryParameter("PIAD", m3PIAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORAD))
				request.WithQueryParameter("ORAD", m3ORAD.Trim());

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
		/// Name DltLine
		/// Description Delete PO-line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PUNO">Purchase order number (Required)</param>
		/// <param name="m3PNLI">Purchase order line (Required)</param>
		/// <param name="m3PNLS">Purchase order line subnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltLine(
			string m3PUNO, 
			int m3PNLI, 
			int? m3PNLS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim())
				.WithQueryParameter("PNLI", m3PNLI.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3PNLS.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetAddresses
		/// Description Get Purchase Order Addresses
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PUNO">Purchase Order Number (Required)</param>
		/// <param name="m3CONO">Company number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAddressesResponse></returns>
		/// <exception cref="M3Exception<GetAddressesResponse>"></exception>
		public async Task<M3Response<GetAddressesResponse>> GetAddresses(
			string m3PUNO, 
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAddresses",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetAddressesResponse>(
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
		/// Name GetDelAddress
		/// Description Get Delivery Address
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PUNO">Purchase Order Number (Required)</param>
		/// <param name="m3PNLI">Purchase order line (Required)</param>
		/// <param name="m3CONO">Company number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDelAddressResponse></returns>
		/// <exception cref="M3Exception<GetDelAddressResponse>"></exception>
		public async Task<M3Response<GetDelAddressResponse>> GetDelAddress(
			string m3PUNO, 
			int m3PNLI, 
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDelAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim())
				.WithQueryParameter("PNLI", m3PNLI.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetDelAddressResponse>(
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
		/// Name GetDelPrevPrtNo
		/// Description Get Delivery Schedule Previous Printout number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3DSPN">Printout number - delivery schedule (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDelPrevPrtNoResponse></returns>
		/// <exception cref="M3Exception<GetDelPrevPrtNoResponse>"></exception>
		public async Task<M3Response<GetDelPrevPrtNoResponse>> GetDelPrevPrtNo(
			string m3WHLO, 
			string m3ITNO, 
			decimal m3DSPN, 
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDelPrevPrtNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("DSPN", m3DSPN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetDelPrevPrtNoResponse>(
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
		/// Name GetHead
		/// Description Get Purchase Order Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PUNO">Purchase order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadResponse></returns>
		/// <exception cref="M3Exception<GetHeadResponse>"></exception>
		public async Task<M3Response<GetHeadResponse>> GetHead(
			string m3PUNO, 
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetHeadResponse>(
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
		/// Name GetLine
		/// Description List Purchase Order Line
		/// Version Release: 5ea7
		/// </summary>
		/// <param name="m3PUNO">Purchase order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PNLI">Purchase order line</param>
		/// <param name="m3PNLS">Purchase order line subnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLineResponse></returns>
		/// <exception cref="M3Exception<GetLineResponse>"></exception>
		public async Task<M3Response<GetLineResponse>> GetLine(
			string m3PUNO, 
			int? m3CONO = null, 
			int? m3PNLI = null, 
			int? m3PNLS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3PNLI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3PNLS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetLineResponse>(
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
		/// Name GetLineTrans
		/// Description Retrieve goods receipt transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRTR">Purchase reporting transaction (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PUNO">Purchase order number</param>
		/// <param name="m3PNLI">Purchase order line</param>
		/// <param name="m3PNLS">Purchase order line subnumber</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLineTransResponse></returns>
		/// <exception cref="M3Exception<GetLineTransResponse>"></exception>
		public async Task<M3Response<GetLineTransResponse>> GetLineTrans(
			int m3PRTR, 
			int? m3CONO = null, 
			string m3PUNO = null, 
			int? m3PNLI = null, 
			int? m3PNLS = null, 
			long? m3REPN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetLineTrans",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTR", m3PRTR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PUNO))
				request.WithQueryParameter("PUNO", m3PUNO.Trim());
			if (m3PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3PNLI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3PNLS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetLineTransResponse>(
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
		/// Name LstDelSchLine
		/// Description List Purchase Delivery Schedule Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company number</param>
		/// <param name="m3DSPN">Printout number - delivery schedule</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDelSchLineResponse></returns>
		/// <exception cref="M3Exception<LstDelSchLineResponse>"></exception>
		public async Task<M3Response<LstDelSchLineResponse>> LstDelSchLine(
			int? m3CONO = null, 
			decimal? m3DSPN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDelSchLine",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSPN.HasValue)
				request.WithQueryParameter("DSPN", m3DSPN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstDelSchLineResponse>(
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
		/// Name LstDupOrders
		/// Description List duplicate orders
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PUNO">Purchase order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDupOrdersResponse></returns>
		/// <exception cref="M3Exception<LstDupOrdersResponse>"></exception>
		public async Task<M3Response<LstDupOrdersResponse>> LstDupOrders(
			string m3PUNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDupOrders",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PUNO))
				request.WithQueryParameter("PUNO", m3PUNO.Trim());

			// Execute the request
			var result = await Execute<LstDupOrdersResponse>(
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
		/// Name LstHeadTxt
		/// Description List Purchase Order Head Text
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PUNO">Purchase Order Number (Required)</param>
		/// <param name="m3CONO">Company number</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadTxtResponse></returns>
		/// <exception cref="M3Exception<LstHeadTxtResponse>"></exception>
		public async Task<M3Response<LstHeadTxtResponse>> LstHeadTxt(
			string m3PUNO, 
			int? m3CONO = null, 
			string m3LNCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstHeadTxt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<LstHeadTxtResponse>(
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
		/// Name LstLatestDel
		/// Description List three latest deliveries for a delivery schedule
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company number</param>
		/// <param name="m3PRCS">Service process</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLatestDelResponse></returns>
		/// <exception cref="M3Exception<LstLatestDelResponse>"></exception>
		public async Task<M3Response<LstLatestDelResponse>> LstLatestDel(
			string m3SUNO, 
			string m3WHLO, 
			string m3ITNO, 
			int? m3CONO = null, 
			string m3PRCS = null, 
			string m3SUFI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLatestDel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRCS))
				request.WithQueryParameter("PRCS", m3PRCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());

			// Execute the request
			var result = await Execute<LstLatestDelResponse>(
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
		/// Name LstLine
		/// Description List Purchase Order Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PUNO">Purchase order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineResponse></returns>
		/// <exception cref="M3Exception<LstLineResponse>"></exception>
		public async Task<M3Response<LstLineResponse>> LstLine(
			string m3PUNO, 
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstLineResponse>(
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
		/// Name LstLine2
		/// Description LstLine2
		/// Version Release: 5ea7
		/// </summary>
		/// <param name="m3PUNO">Purchase order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLine2Response></returns>
		/// <exception cref="M3Exception<LstLine2Response>"></exception>
		public async Task<M3Response<LstLine2Response>> LstLine2(
			string m3PUNO, 
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLine2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstLine2Response>(
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
		/// Name LstLineTrans
		/// Description Retrieve goods receipt transactions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRTR">Purchase reporting transaction (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PUNO">Purchase order number</param>
		/// <param name="m3PNLI">Purchase order line</param>
		/// <param name="m3PNLS">Purchase order line subnumber</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineTransResponse></returns>
		/// <exception cref="M3Exception<LstLineTransResponse>"></exception>
		public async Task<M3Response<LstLineTransResponse>> LstLineTrans(
			int m3PRTR, 
			int? m3CONO = null, 
			string m3PUNO = null, 
			int? m3PNLI = null, 
			int? m3PNLS = null, 
			long? m3REPN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLineTrans",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTR", m3PRTR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PUNO))
				request.WithQueryParameter("PUNO", m3PUNO.Trim());
			if (m3PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3PNLI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3PNLS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstLineTransResponse>(
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
		/// Name LstLineTxt
		/// Description List Purchase Order Line Text
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PUNO">Purchase Order Number (Required)</param>
		/// <param name="m3PNLI">Purchase order line (Required)</param>
		/// <param name="m3PNLS">Purchase order line subnumber (Required)</param>
		/// <param name="m3CONO">Company number</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineTxtResponse></returns>
		/// <exception cref="M3Exception<LstLineTxtResponse>"></exception>
		public async Task<M3Response<LstLineTxtResponse>> LstLineTxt(
			string m3PUNO, 
			int m3PNLI, 
			int m3PNLS, 
			int? m3CONO = null, 
			string m3LNCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLineTxt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim())
				.WithQueryParameter("PNLI", m3PNLI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PNLS", m3PNLS.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<LstLineTxtResponse>(
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
		/// Name SearchHead
		/// Description SearchHead
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchHeadResponse></returns>
		/// <exception cref="M3Exception<SearchHeadResponse>"></exception>
		public async Task<M3Response<SearchHeadResponse>> SearchHead(
			string m3SQRY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SQRY))
				throw new ArgumentNullException(nameof(m3SQRY));

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchHeadResponse>(
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
		/// Name SearchLine
		/// Description SearchLine
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchLineResponse></returns>
		/// <exception cref="M3Exception<SearchLineResponse>"></exception>
		public async Task<M3Response<SearchLineResponse>> SearchLine(
			string m3SQRY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SQRY))
				throw new ArgumentNullException(nameof(m3SQRY));

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchLineResponse>(
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
		/// Name UpdAddress
		/// Description Update Purchase Order Address
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PUNO">Purchase order number (Required)</param>
		/// <param name="m3PNLI">Purchase order line (Required)</param>
		/// <param name="m3POAD">PO address type (Required)</param>
		/// <param name="m3ADK2">Address key 2</param>
		/// <param name="m3ADK3">Address key 3</param>
		/// <param name="m3ADR1">Address line 1</param>
		/// <param name="m3ADR2">Address line 2</param>
		/// <param name="m3ADR3">Address line 3</param>
		/// <param name="m3ADR4">Address line 4</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3PONO">Postal code</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="m3CONM">Company name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAddress(
			string m3PUNO, 
			int m3PNLI, 
			int m3POAD, 
			string m3ADK2 = null, 
			string m3ADK3 = null, 
			string m3ADR1 = null, 
			string m3ADR2 = null, 
			string m3ADR3 = null, 
			string m3ADR4 = null, 
			string m3TOWN = null, 
			string m3ECAR = null, 
			string m3CSCD = null, 
			string m3PONO = null, 
			string m3FRCO = null, 
			string m3CONM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim())
				.WithQueryParameter("PNLI", m3PNLI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("POAD", m3POAD.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ADK2))
				request.WithQueryParameter("ADK2", m3ADK2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADK3))
				request.WithQueryParameter("ADK3", m3ADK3.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR1))
				request.WithQueryParameter("ADR1", m3ADR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR2))
				request.WithQueryParameter("ADR2", m3ADR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR3))
				request.WithQueryParameter("ADR3", m3ADR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR4))
				request.WithQueryParameter("ADR4", m3ADR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOWN))
				request.WithQueryParameter("TOWN", m3TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRCO))
				request.WithQueryParameter("FRCO", m3FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CONM))
				request.WithQueryParameter("CONM", m3CONM.Trim());

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
		/// Name UpdHead
		/// Description Update Purchase Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PUNO">Purchase order number (Required)</param>
		/// <param name="m3CMCO">Communication code</param>
		/// <param name="m3PUDT">Order date</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3PYME">Payment method - accounts payable</param>
		/// <param name="m3TEAF">Freight terms</param>
		/// <param name="m3TEPA">Packaging terms</param>
		/// <param name="m3YRE1">Your reference</param>
		/// <param name="m3DWDT">Requested delivery date</param>
		/// <param name="m3PRSU">Payee</param>
		/// <param name="m3OURR">Our reference number</param>
		/// <param name="m3OURT">Reference type</param>
		/// <param name="m3PURC">Requisition by</param>
		/// <param name="m3BUYE">Buyer</param>
		/// <param name="m3FUSC">Monitoring activity list</param>
		/// <param name="m3ODAM">Order total discount</param>
		/// <param name="m3OTPC">Order total discount generating</param>
		/// <param name="m3TFNO">Facsimile transmission number</param>
		/// <param name="m3CUTE">Currency terms</param>
		/// <param name="m3AGRA">Agreed rate</param>
		/// <param name="m3PYAD">Our invoicing address</param>
		/// <param name="m3SHVI">Your via address</param>
		/// <param name="m3FIDS">Your receiving address</param>
		/// <param name="m3TEOR">Telephone order</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdHead(
			string m3PUNO, 
			string m3CMCO = null, 
			DateTime? m3PUDT = null, 
			string m3LNCD = null, 
			string m3TEPY = null, 
			string m3PYME = null, 
			string m3TEAF = null, 
			string m3TEPA = null, 
			string m3YRE1 = null, 
			DateTime? m3DWDT = null, 
			string m3PRSU = null, 
			string m3OURR = null, 
			string m3OURT = null, 
			string m3PURC = null, 
			string m3BUYE = null, 
			string m3FUSC = null, 
			decimal? m3ODAM = null, 
			int? m3OTPC = null, 
			string m3TFNO = null, 
			int? m3CUTE = null, 
			decimal? m3AGRA = null, 
			string m3PYAD = null, 
			string m3SHVI = null, 
			string m3FIDS = null, 
			int? m3TEOR = null, 
			string m3PROJ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CMCO))
				request.WithQueryParameter("CMCO", m3CMCO.Trim());
			if (m3PUDT.HasValue)
				request.WithQueryParameter("PUDT", m3PUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYME))
				request.WithQueryParameter("PYME", m3PYME.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEAF))
				request.WithQueryParameter("TEAF", m3TEAF.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3YRE1))
				request.WithQueryParameter("YRE1", m3YRE1.Trim());
			if (m3DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3DWDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PRSU))
				request.WithQueryParameter("PRSU", m3PRSU.Trim());
			if (!string.IsNullOrWhiteSpace(m3OURR))
				request.WithQueryParameter("OURR", m3OURR.Trim());
			if (!string.IsNullOrWhiteSpace(m3OURT))
				request.WithQueryParameter("OURT", m3OURT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PURC))
				request.WithQueryParameter("PURC", m3PURC.Trim());
			if (!string.IsNullOrWhiteSpace(m3BUYE))
				request.WithQueryParameter("BUYE", m3BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3FUSC))
				request.WithQueryParameter("FUSC", m3FUSC.Trim());
			if (m3ODAM.HasValue)
				request.WithQueryParameter("ODAM", m3ODAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OTPC.HasValue)
				request.WithQueryParameter("OTPC", m3OTPC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (m3CUTE.HasValue)
				request.WithQueryParameter("CUTE", m3CUTE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGRA.HasValue)
				request.WithQueryParameter("AGRA", m3AGRA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PYAD))
				request.WithQueryParameter("PYAD", m3PYAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SHVI))
				request.WithQueryParameter("SHVI", m3SHVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIDS))
				request.WithQueryParameter("FIDS", m3FIDS.Trim());
			if (m3TEOR.HasValue)
				request.WithQueryParameter("TEOR", m3TEOR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
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
		/// Name UpdLine
		/// Description Update Purchase Order Line
		/// Version Release: 5ea7
		/// </summary>
		/// <param name="m3PUNO">Purchase order number (Required)</param>
		/// <param name="m3PNLI">Purchase order line (Required)</param>
		/// <param name="m3PNLS">Purchase order line subnumber (Required)</param>
		/// <param name="m3SITE">Supplier item number</param>
		/// <param name="m3PITD">Purchase order item name</param>
		/// <param name="m3PITT">Purchase order item description</param>
		/// <param name="m3SORN">Supplier order number</param>
		/// <param name="m3PROD">Manufacturer</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="m3NOED">Revision printout</param>
		/// <param name="m3REVN">PO Revision number</param>
		/// <param name="m3ETRF">External instruction</param>
		/// <param name="m3PUPR">Purchase price</param>
		/// <param name="m3ODI1">Discount 1</param>
		/// <param name="m3ODI2">Discount 2</param>
		/// <param name="m3ODI3">Discount 3</param>
		/// <param name="m3PUUN">Purchase order U/M</param>
		/// <param name="m3PPUN">Purchase price U/M</param>
		/// <param name="m3PUCD">Purchase price quantity</param>
		/// <param name="m3PTCD">Purchase price text</param>
		/// <param name="m3OTOD">Part of order total discount</param>
		/// <param name="m3ORQA">Ordered quantity - alternate U/M</param>
		/// <param name="m3DT4T">Date type</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3OURR">Our reference number</param>
		/// <param name="m3OURT">Reference type</param>
		/// <param name="m3UPAV">Update material plan</param>
		/// <param name="m3REPP">Representative price</param>
		/// <param name="m3PRIP">Priority</param>
		/// <param name="m3FUSC">Monitoring activity list</param>
		/// <param name="m3PURC">Requisition by</param>
		/// <param name="m3GRMT">Goods receiving method</param>
		/// <param name="m3UPIV">Update item/supplier with purchase price</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3VTCD">VAT code</param>
		/// <param name="m3PLDT">Planning date</param>
		/// <param name="m3CSNO">Customs statistical number</param>
		/// <param name="m3ECLC">Labor code - trade statistics (TST)</param>
		/// <param name="m3VRCD">Business type - trade statistics (TST)</param>
		/// <param name="m3ECF1">User-defined TST field 1</param>
		/// <param name="m3ECF2">User-defined TST field 2</param>
		/// <param name="m3ECF3">User-defined TST field 3</param>
		/// <param name="m3ECF4">User-defined TST field  4</param>
		/// <param name="m3ECF5">User-defined TST field 5</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3CPRI">Customs procedure - import</param>
		/// <param name="m3HAFE">Harbor or airport</param>
		/// <param name="m3TAXC">Tax code customer/address</param>
		/// <param name="m3TIHM">Time hours & minutes</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3ATPR">Attribute pricing rule</param>
		/// <param name="m3MSTN">Milestone chain</param>
		/// <param name="m3FATP">Fixed asset type</param>
		/// <param name="m3ORCO">Country of origin</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3TEDL">Delivery terms</param>
		/// <param name="m3TEL1">Terms text</param>
		/// <param name="m3RASN">Rail station</param>
		/// <param name="m3PIAD">Pickup address number</param>
		/// <param name="m3ORAD">Origin address</param>
		/// <param name="m3DWDT">Requested delivery date</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3COCE">cost center</param>
		/// <param name="m3GEOC">Geographical code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdLine(
			string m3PUNO, 
			int m3PNLI, 
			int m3PNLS, 
			string m3SITE = null, 
			string m3PITD = null, 
			string m3PITT = null, 
			string m3SORN = null, 
			string m3PROD = null, 
			string m3ECVE = null, 
			int? m3NOED = null, 
			string m3REVN = null, 
			string m3ETRF = null, 
			decimal? m3PUPR = null, 
			int? m3ODI1 = null, 
			int? m3ODI2 = null, 
			int? m3ODI3 = null, 
			string m3PUUN = null, 
			string m3PPUN = null, 
			int? m3PUCD = null, 
			int? m3PTCD = null, 
			int? m3OTOD = null, 
			decimal? m3ORQA = null, 
			int? m3DT4T = null, 
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3OURR = null, 
			string m3OURT = null, 
			int? m3UPAV = null, 
			int? m3REPP = null, 
			string m3PRIP = null, 
			string m3FUSC = null, 
			string m3PURC = null, 
			string m3GRMT = null, 
			int? m3UPIV = null, 
			string m3PACT = null, 
			int? m3VTCD = null, 
			DateTime? m3PLDT = null, 
			string m3CSNO = null, 
			string m3ECLC = null, 
			string m3VRCD = null, 
			string m3ECF1 = null, 
			string m3ECF2 = null, 
			string m3ECF3 = null, 
			string m3ECF4 = null, 
			string m3ECF5 = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3CPRI = null, 
			string m3HAFE = null, 
			string m3TAXC = null, 
			int? m3TIHM = null, 
			decimal? m3ATNR = null, 
			string m3ATPR = null, 
			long? m3MSTN = null, 
			string m3FATP = null, 
			string m3ORCO = null, 
			string m3MODL = null, 
			string m3TEDL = null, 
			string m3TEL1 = null, 
			string m3RASN = null, 
			string m3PIAD = null, 
			string m3ORAD = null, 
			DateTime? m3DWDT = null, 
			string m3ACRF = null, 
			string m3COCE = null, 
			int? m3GEOC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim())
				.WithQueryParameter("PNLI", m3PNLI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PNLS", m3PNLS.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SITE))
				request.WithQueryParameter("SITE", m3SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3PITD))
				request.WithQueryParameter("PITD", m3PITD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PITT))
				request.WithQueryParameter("PITT", m3PITT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SORN))
				request.WithQueryParameter("SORN", m3SORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROD))
				request.WithQueryParameter("PROD", m3PROD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
			if (m3NOED.HasValue)
				request.WithQueryParameter("NOED", m3NOED.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REVN))
				request.WithQueryParameter("REVN", m3REVN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETRF))
				request.WithQueryParameter("ETRF", m3ETRF.Trim());
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ODI1.HasValue)
				request.WithQueryParameter("ODI1", m3ODI1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ODI2.HasValue)
				request.WithQueryParameter("ODI2", m3ODI2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ODI3.HasValue)
				request.WithQueryParameter("ODI3", m3ODI3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PUUN))
				request.WithQueryParameter("PUUN", m3PUUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PPUN))
				request.WithQueryParameter("PPUN", m3PPUN.Trim());
			if (m3PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3PUCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PTCD.HasValue)
				request.WithQueryParameter("PTCD", m3PTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OTOD.HasValue)
				request.WithQueryParameter("OTOD", m3OTOD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORQA.HasValue)
				request.WithQueryParameter("ORQA", m3ORQA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DT4T.HasValue)
				request.WithQueryParameter("DT4T", m3DT4T.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OURR))
				request.WithQueryParameter("OURR", m3OURR.Trim());
			if (!string.IsNullOrWhiteSpace(m3OURT))
				request.WithQueryParameter("OURT", m3OURT.Trim());
			if (m3UPAV.HasValue)
				request.WithQueryParameter("UPAV", m3UPAV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REPP.HasValue)
				request.WithQueryParameter("REPP", m3REPP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRIP))
				request.WithQueryParameter("PRIP", m3PRIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FUSC))
				request.WithQueryParameter("FUSC", m3FUSC.Trim());
			if (!string.IsNullOrWhiteSpace(m3PURC))
				request.WithQueryParameter("PURC", m3PURC.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRMT))
				request.WithQueryParameter("GRMT", m3GRMT.Trim());
			if (m3UPIV.HasValue)
				request.WithQueryParameter("UPIV", m3UPIV.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (m3VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3VTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLDT.HasValue)
				request.WithQueryParameter("PLDT", m3PLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CSNO))
				request.WithQueryParameter("CSNO", m3CSNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECLC))
				request.WithQueryParameter("ECLC", m3ECLC.Trim());
			if (!string.IsNullOrWhiteSpace(m3VRCD))
				request.WithQueryParameter("VRCD", m3VRCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECF1))
				request.WithQueryParameter("ECF1", m3ECF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECF2))
				request.WithQueryParameter("ECF2", m3ECF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECF3))
				request.WithQueryParameter("ECF3", m3ECF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECF4))
				request.WithQueryParameter("ECF4", m3ECF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECF5))
				request.WithQueryParameter("ECF5", m3ECF5.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CPRI))
				request.WithQueryParameter("CPRI", m3CPRI.Trim());
			if (!string.IsNullOrWhiteSpace(m3HAFE))
				request.WithQueryParameter("HAFE", m3HAFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAXC))
				request.WithQueryParameter("TAXC", m3TAXC.Trim());
			if (m3TIHM.HasValue)
				request.WithQueryParameter("TIHM", m3TIHM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ATPR))
				request.WithQueryParameter("ATPR", m3ATPR.Trim());
			if (m3MSTN.HasValue)
				request.WithQueryParameter("MSTN", m3MSTN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FATP))
				request.WithQueryParameter("FATP", m3FATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORCO))
				request.WithQueryParameter("ORCO", m3ORCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEL1))
				request.WithQueryParameter("TEL1", m3TEL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3RASN))
				request.WithQueryParameter("RASN", m3RASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PIAD))
				request.WithQueryParameter("PIAD", m3PIAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORAD))
				request.WithQueryParameter("ORAD", m3ORAD.Trim());
			if (m3DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3DWDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3COCE))
				request.WithQueryParameter("COCE", m3COCE.Trim());
			if (m3GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3GEOC.Value.ToString(CultureInfo.CurrentCulture));

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
