/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_PUNO">Purchase order number (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_ORQA">Ordered quantity - alternate U/M (Required)</param>
		/// <param name="m3_PNLI">Purchase order line</param>
		/// <param name="m3_PNLS">Purchase order line subnumber</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_DWDT">Requested delivery date</param>
		/// <param name="m3_SITE">Supplier item number</param>
		/// <param name="m3_PITD">Purchase order item name</param>
		/// <param name="m3_PITT">Purchase order item description</param>
		/// <param name="m3_PROD">Manufacturer</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="m3_REVN">PO Revision number</param>
		/// <param name="m3_ETRF">External instruction</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_ODI1">Discount 1</param>
		/// <param name="m3_ODI2">Discount 2</param>
		/// <param name="m3_ODI3">Discount 3</param>
		/// <param name="m3_PUUN">Purchase order U/M</param>
		/// <param name="m3_PPUN">Purchase price U/M</param>
		/// <param name="m3_PUCD">Purchase price quantity</param>
		/// <param name="m3_PTCD">Purchase price text</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_OURR">Our reference number</param>
		/// <param name="m3_OURT">Reference type</param>
		/// <param name="m3_PRIP">Priority</param>
		/// <param name="m3_FUSC">Monitoring activity list</param>
		/// <param name="m3_PURC">Requisition by</param>
		/// <param name="m3_BUYE">Buyer</param>
		/// <param name="m3_TERE">Technical supervisor</param>
		/// <param name="m3_GRMT">Goods receiving method</param>
		/// <param name="m3_IRCV">Recipient</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_VTCD">VAT code</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_COCE">Cost center</param>
		/// <param name="m3_CSNO">Customs statistical number</param>
		/// <param name="m3_ECLC">Labor code - trade statistics (TST)</param>
		/// <param name="m3_VRCD">Business type - trade statistics (TST)</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_CPRI">Customs procedure - import</param>
		/// <param name="m3_HAFE">Harbor or airport</param>
		/// <param name="m3_TAXC">Tax code customer/address</param>
		/// <param name="m3_TIHM">Time hours & minutes</param>
		/// <param name="m3_MSTN">Milestone chain</param>
		/// <param name="m3_UPCK">Unpack</param>
		/// <param name="m3_ORCO">Country of origin</param>
		/// <param name="m3_GEOC">Geographical code</param>
		/// <param name="m3_TRRC">Order relation category</param>
		/// <param name="m3_TRRN">Order relation number</param>
		/// <param name="m3_TRRL">Order relation line</param>
		/// <param name="m3_TRRX">Line suffix</param>
		/// <param name="m3_RASN">Rail station</param>
		/// <param name="m3_PIAD">Pickup address number</param>
		/// <param name="m3_ORAD">Origin address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLine(
			string m3_PUNO, 
			string m3_ITNO, 
			decimal m3_ORQA, 
			int? m3_PNLI = null, 
			int? m3_PNLS = null, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			string m3_SUNO = null, 
			DateTime? m3_DWDT = null, 
			string m3_SITE = null, 
			string m3_PITD = null, 
			string m3_PITT = null, 
			string m3_PROD = null, 
			string m3_ECVE = null, 
			string m3_REVN = null, 
			string m3_ETRF = null, 
			decimal? m3_PUPR = null, 
			int? m3_ODI1 = null, 
			int? m3_ODI2 = null, 
			int? m3_ODI3 = null, 
			string m3_PUUN = null, 
			string m3_PPUN = null, 
			int? m3_PUCD = null, 
			int? m3_PTCD = null, 
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_OURR = null, 
			string m3_OURT = null, 
			string m3_PRIP = null, 
			string m3_FUSC = null, 
			string m3_PURC = null, 
			string m3_BUYE = null, 
			string m3_TERE = null, 
			string m3_GRMT = null, 
			string m3_IRCV = null, 
			string m3_PACT = null, 
			int? m3_VTCD = null, 
			string m3_ACRF = null, 
			string m3_COCE = null, 
			string m3_CSNO = null, 
			string m3_ECLC = null, 
			string m3_VRCD = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_CPRI = null, 
			string m3_HAFE = null, 
			string m3_TAXC = null, 
			int? m3_TIHM = null, 
			long? m3_MSTN = null, 
			int? m3_UPCK = null, 
			string m3_ORCO = null, 
			int? m3_GEOC = null, 
			int? m3_TRRC = null, 
			string m3_TRRN = null, 
			int? m3_TRRL = null, 
			int? m3_TRRX = null, 
			string m3_RASN = null, 
			string m3_PIAD = null, 
			string m3_ORAD = null, 
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
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("ORQA", m3_ORQA.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3_PNLI.Value.ToString());
			if (m3_PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3_PNLS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3_DWDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_SITE))
				request.WithQueryParameter("SITE", m3_SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PITD))
				request.WithQueryParameter("PITD", m3_PITD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PITT))
				request.WithQueryParameter("PITT", m3_PITT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROD))
				request.WithQueryParameter("PROD", m3_PROD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REVN))
				request.WithQueryParameter("REVN", m3_REVN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETRF))
				request.WithQueryParameter("ETRF", m3_ETRF.Trim());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (m3_ODI1.HasValue)
				request.WithQueryParameter("ODI1", m3_ODI1.Value.ToString());
			if (m3_ODI2.HasValue)
				request.WithQueryParameter("ODI2", m3_ODI2.Value.ToString());
			if (m3_ODI3.HasValue)
				request.WithQueryParameter("ODI3", m3_ODI3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PUUN))
				request.WithQueryParameter("PUUN", m3_PUUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PPUN))
				request.WithQueryParameter("PPUN", m3_PPUN.Trim());
			if (m3_PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3_PUCD.Value.ToString());
			if (m3_PTCD.HasValue)
				request.WithQueryParameter("PTCD", m3_PTCD.Value.ToString());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OURR))
				request.WithQueryParameter("OURR", m3_OURR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OURT))
				request.WithQueryParameter("OURT", m3_OURT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRIP))
				request.WithQueryParameter("PRIP", m3_PRIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FUSC))
				request.WithQueryParameter("FUSC", m3_FUSC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PURC))
				request.WithQueryParameter("PURC", m3_PURC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BUYE))
				request.WithQueryParameter("BUYE", m3_BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TERE))
				request.WithQueryParameter("TERE", m3_TERE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRMT))
				request.WithQueryParameter("GRMT", m3_GRMT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IRCV))
				request.WithQueryParameter("IRCV", m3_IRCV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (m3_VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3_VTCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COCE))
				request.WithQueryParameter("COCE", m3_COCE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSNO))
				request.WithQueryParameter("CSNO", m3_CSNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECLC))
				request.WithQueryParameter("ECLC", m3_ECLC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VRCD))
				request.WithQueryParameter("VRCD", m3_VRCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CPRI))
				request.WithQueryParameter("CPRI", m3_CPRI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HAFE))
				request.WithQueryParameter("HAFE", m3_HAFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAXC))
				request.WithQueryParameter("TAXC", m3_TAXC.Trim());
			if (m3_TIHM.HasValue)
				request.WithQueryParameter("TIHM", m3_TIHM.Value.ToString());
			if (m3_MSTN.HasValue)
				request.WithQueryParameter("MSTN", m3_MSTN.Value.ToString());
			if (m3_UPCK.HasValue)
				request.WithQueryParameter("UPCK", m3_UPCK.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (m3_GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3_GEOC.Value.ToString());
			if (m3_TRRC.HasValue)
				request.WithQueryParameter("TRRC", m3_TRRC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TRRN))
				request.WithQueryParameter("TRRN", m3_TRRN.Trim());
			if (m3_TRRL.HasValue)
				request.WithQueryParameter("TRRL", m3_TRRL.Value.ToString());
			if (m3_TRRX.HasValue)
				request.WithQueryParameter("TRRX", m3_TRRX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RASN))
				request.WithQueryParameter("RASN", m3_RASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PIAD))
				request.WithQueryParameter("PIAD", m3_PIAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORAD))
				request.WithQueryParameter("ORAD", m3_ORAD.Trim());

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
		/// Name DltLine
		/// Description Delete PO-line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PUNO">Purchase order number (Required)</param>
		/// <param name="m3_PNLI">Purchase order line (Required)</param>
		/// <param name="m3_PNLS">Purchase order line subnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltLine(
			string m3_PUNO, 
			int m3_PNLI, 
			int? m3_PNLS = null, 
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
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim())
				.WithQueryParameter("PNLI", m3_PNLI.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3_PNLS.Value.ToString());

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
		/// Name GetAddresses
		/// Description Get Purchase Order Addresses
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PUNO">Purchase Order Number (Required)</param>
		/// <param name="m3_CONO">Company number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAddressesResponse></returns>
		/// <exception cref="M3Exception<GetAddressesResponse>"></exception>
		public async Task<M3Response<GetAddressesResponse>> GetAddresses(
			string m3_PUNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAddresses",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetAddressesResponse>(
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
		/// Name GetDelAddress
		/// Description Get Delivery Address
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PUNO">Purchase Order Number (Required)</param>
		/// <param name="m3_PNLI">Purchase order line (Required)</param>
		/// <param name="m3_CONO">Company number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDelAddressResponse></returns>
		/// <exception cref="M3Exception<GetDelAddressResponse>"></exception>
		public async Task<M3Response<GetDelAddressResponse>> GetDelAddress(
			string m3_PUNO, 
			int m3_PNLI, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDelAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim())
				.WithQueryParameter("PNLI", m3_PNLI.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetDelAddressResponse>(
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
		/// Name GetDelPrevPrtNo
		/// Description Get Delivery Schedule Previous Printout number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_DSPN">Printout number - delivery schedule (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDelPrevPrtNoResponse></returns>
		/// <exception cref="M3Exception<GetDelPrevPrtNoResponse>"></exception>
		public async Task<M3Response<GetDelPrevPrtNoResponse>> GetDelPrevPrtNo(
			string m3_WHLO, 
			string m3_ITNO, 
			decimal m3_DSPN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDelPrevPrtNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("DSPN", m3_DSPN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetDelPrevPrtNoResponse>(
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
		/// Name GetHead
		/// Description Get Purchase Order Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PUNO">Purchase order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadResponse></returns>
		/// <exception cref="M3Exception<GetHeadResponse>"></exception>
		public async Task<M3Response<GetHeadResponse>> GetHead(
			string m3_PUNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetHeadResponse>(
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
		/// Name GetLine
		/// Description List Purchase Order Line
		/// Version Release: 5ea7
		/// </summary>
		/// <param name="m3_PUNO">Purchase order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PNLI">Purchase order line</param>
		/// <param name="m3_PNLS">Purchase order line subnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLineResponse></returns>
		/// <exception cref="M3Exception<GetLineResponse>"></exception>
		public async Task<M3Response<GetLineResponse>> GetLine(
			string m3_PUNO, 
			int? m3_CONO = null, 
			int? m3_PNLI = null, 
			int? m3_PNLS = null, 
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
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3_PNLI.Value.ToString());
			if (m3_PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3_PNLS.Value.ToString());

			// Execute the request
			var result = await Execute<GetLineResponse>(
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
		/// Name GetLineTrans
		/// Description Retrieve goods receipt transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRTR">Purchase reporting transaction (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PUNO">Purchase order number</param>
		/// <param name="m3_PNLI">Purchase order line</param>
		/// <param name="m3_PNLS">Purchase order line subnumber</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLineTransResponse></returns>
		/// <exception cref="M3Exception<GetLineTransResponse>"></exception>
		public async Task<M3Response<GetLineTransResponse>> GetLineTrans(
			int m3_PRTR, 
			int? m3_CONO = null, 
			string m3_PUNO = null, 
			int? m3_PNLI = null, 
			int? m3_PNLS = null, 
			long? m3_REPN = null, 
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
				.WithQueryParameter("PRTR", m3_PRTR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PUNO))
				request.WithQueryParameter("PUNO", m3_PUNO.Trim());
			if (m3_PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3_PNLI.Value.ToString());
			if (m3_PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3_PNLS.Value.ToString());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());

			// Execute the request
			var result = await Execute<GetLineTransResponse>(
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
		/// Name LstDelSchLine
		/// Description List Purchase Delivery Schedule Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company number</param>
		/// <param name="m3_DSPN">Printout number - delivery schedule</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDelSchLineResponse></returns>
		/// <exception cref="M3Exception<LstDelSchLineResponse>"></exception>
		public async Task<M3Response<LstDelSchLineResponse>> LstDelSchLine(
			int? m3_CONO = null, 
			decimal? m3_DSPN = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_DSPN.HasValue)
				request.WithQueryParameter("DSPN", m3_DSPN.Value.ToString());

			// Execute the request
			var result = await Execute<LstDelSchLineResponse>(
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
		/// Name LstDupOrders
		/// Description List duplicate orders
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PUNO">Purchase order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDupOrdersResponse></returns>
		/// <exception cref="M3Exception<LstDupOrdersResponse>"></exception>
		public async Task<M3Response<LstDupOrdersResponse>> LstDupOrders(
			string m3_PUNO = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_PUNO))
				request.WithQueryParameter("PUNO", m3_PUNO.Trim());

			// Execute the request
			var result = await Execute<LstDupOrdersResponse>(
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
		/// Name LstHeadTxt
		/// Description List Purchase Order Head Text
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PUNO">Purchase Order Number (Required)</param>
		/// <param name="m3_CONO">Company number</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadTxtResponse></returns>
		/// <exception cref="M3Exception<LstHeadTxtResponse>"></exception>
		public async Task<M3Response<LstHeadTxtResponse>> LstHeadTxt(
			string m3_PUNO, 
			int? m3_CONO = null, 
			string m3_LNCD = null, 
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
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<LstHeadTxtResponse>(
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
		/// Name LstLatestDel
		/// Description List three latest deliveries for a delivery schedule
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company number</param>
		/// <param name="m3_PRCS">Service process</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLatestDelResponse></returns>
		/// <exception cref="M3Exception<LstLatestDelResponse>"></exception>
		public async Task<M3Response<LstLatestDelResponse>> LstLatestDel(
			string m3_SUNO, 
			string m3_WHLO, 
			string m3_ITNO, 
			int? m3_CONO = null, 
			string m3_PRCS = null, 
			string m3_SUFI = null, 
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
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRCS))
				request.WithQueryParameter("PRCS", m3_PRCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());

			// Execute the request
			var result = await Execute<LstLatestDelResponse>(
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
		/// Name LstLine
		/// Description List Purchase Order Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PUNO">Purchase order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineResponse></returns>
		/// <exception cref="M3Exception<LstLineResponse>"></exception>
		public async Task<M3Response<LstLineResponse>> LstLine(
			string m3_PUNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstLineResponse>(
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
		/// Name LstLine2
		/// Description LstLine2
		/// Version Release: 5ea7
		/// </summary>
		/// <param name="m3_PUNO">Purchase order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLine2Response></returns>
		/// <exception cref="M3Exception<LstLine2Response>"></exception>
		public async Task<M3Response<LstLine2Response>> LstLine2(
			string m3_PUNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLine2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstLine2Response>(
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
		/// Name LstLineTrans
		/// Description Retrieve goods receipt transactions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRTR">Purchase reporting transaction (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PUNO">Purchase order number</param>
		/// <param name="m3_PNLI">Purchase order line</param>
		/// <param name="m3_PNLS">Purchase order line subnumber</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineTransResponse></returns>
		/// <exception cref="M3Exception<LstLineTransResponse>"></exception>
		public async Task<M3Response<LstLineTransResponse>> LstLineTrans(
			int m3_PRTR, 
			int? m3_CONO = null, 
			string m3_PUNO = null, 
			int? m3_PNLI = null, 
			int? m3_PNLS = null, 
			long? m3_REPN = null, 
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
				.WithQueryParameter("PRTR", m3_PRTR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PUNO))
				request.WithQueryParameter("PUNO", m3_PUNO.Trim());
			if (m3_PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3_PNLI.Value.ToString());
			if (m3_PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3_PNLS.Value.ToString());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());

			// Execute the request
			var result = await Execute<LstLineTransResponse>(
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
		/// Name LstLineTxt
		/// Description List Purchase Order Line Text
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PUNO">Purchase Order Number (Required)</param>
		/// <param name="m3_PNLI">Purchase order line (Required)</param>
		/// <param name="m3_PNLS">Purchase order line subnumber (Required)</param>
		/// <param name="m3_CONO">Company number</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineTxtResponse></returns>
		/// <exception cref="M3Exception<LstLineTxtResponse>"></exception>
		public async Task<M3Response<LstLineTxtResponse>> LstLineTxt(
			string m3_PUNO, 
			int m3_PNLI, 
			int m3_PNLS, 
			int? m3_CONO = null, 
			string m3_LNCD = null, 
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
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim())
				.WithQueryParameter("PNLI", m3_PNLI.ToString())
				.WithQueryParameter("PNLS", m3_PNLS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<LstLineTxtResponse>(
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
		/// Name SearchHead
		/// Description SearchHead
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchHeadResponse></returns>
		/// <exception cref="M3Exception<SearchHeadResponse>"></exception>
		public async Task<M3Response<SearchHeadResponse>> SearchHead(
			string m3_SQRY, 
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
			if (string.IsNullOrWhiteSpace(m3_SQRY))
				throw new ArgumentNullException("m3_SQRY");

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3_SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchHeadResponse>(
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
		/// Name SearchLine
		/// Description SearchLine
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchLineResponse></returns>
		/// <exception cref="M3Exception<SearchLineResponse>"></exception>
		public async Task<M3Response<SearchLineResponse>> SearchLine(
			string m3_SQRY, 
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
			if (string.IsNullOrWhiteSpace(m3_SQRY))
				throw new ArgumentNullException("m3_SQRY");

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3_SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchLineResponse>(
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
		/// Name UpdAddress
		/// Description Update Purchase Order Address
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PUNO">Purchase order number (Required)</param>
		/// <param name="m3_PNLI">Purchase order line (Required)</param>
		/// <param name="m3_POAD">PO address type (Required)</param>
		/// <param name="m3_ADK2">Address key 2</param>
		/// <param name="m3_ADK3">Address key 3</param>
		/// <param name="m3_ADR1">Address line 1</param>
		/// <param name="m3_ADR2">Address line 2</param>
		/// <param name="m3_ADR3">Address line 3</param>
		/// <param name="m3_ADR4">Address line 4</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_PONO">Postal code</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="m3_CONM">Company name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAddress(
			string m3_PUNO, 
			int m3_PNLI, 
			int m3_POAD, 
			string m3_ADK2 = null, 
			string m3_ADK3 = null, 
			string m3_ADR1 = null, 
			string m3_ADR2 = null, 
			string m3_ADR3 = null, 
			string m3_ADR4 = null, 
			string m3_TOWN = null, 
			string m3_ECAR = null, 
			string m3_CSCD = null, 
			string m3_PONO = null, 
			string m3_FRCO = null, 
			string m3_CONM = null, 
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
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim())
				.WithQueryParameter("PNLI", m3_PNLI.ToString())
				.WithQueryParameter("POAD", m3_POAD.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ADK2))
				request.WithQueryParameter("ADK2", m3_ADK2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADK3))
				request.WithQueryParameter("ADK3", m3_ADK3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR1))
				request.WithQueryParameter("ADR1", m3_ADR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR2))
				request.WithQueryParameter("ADR2", m3_ADR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR3))
				request.WithQueryParameter("ADR3", m3_ADR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR4))
				request.WithQueryParameter("ADR4", m3_ADR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOWN))
				request.WithQueryParameter("TOWN", m3_TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRCO))
				request.WithQueryParameter("FRCO", m3_FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CONM))
				request.WithQueryParameter("CONM", m3_CONM.Trim());

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
		/// Name UpdHead
		/// Description Update Purchase Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PUNO">Purchase order number (Required)</param>
		/// <param name="m3_CMCO">Communication code</param>
		/// <param name="m3_PUDT">Order date</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_PYME">Payment method - accounts payable</param>
		/// <param name="m3_TEAF">Freight terms</param>
		/// <param name="m3_TEPA">Packaging terms</param>
		/// <param name="m3_YRE1">Your reference</param>
		/// <param name="m3_DWDT">Requested delivery date</param>
		/// <param name="m3_PRSU">Payee</param>
		/// <param name="m3_OURR">Our reference number</param>
		/// <param name="m3_OURT">Reference type</param>
		/// <param name="m3_PURC">Requisition by</param>
		/// <param name="m3_BUYE">Buyer</param>
		/// <param name="m3_FUSC">Monitoring activity list</param>
		/// <param name="m3_ODAM">Order total discount</param>
		/// <param name="m3_OTPC">Order total discount generating</param>
		/// <param name="m3_TFNO">Facsimile transmission number</param>
		/// <param name="m3_CUTE">Currency terms</param>
		/// <param name="m3_AGRA">Agreed rate</param>
		/// <param name="m3_PYAD">Our invoicing address</param>
		/// <param name="m3_SHVI">Your via address</param>
		/// <param name="m3_FIDS">Your receiving address</param>
		/// <param name="m3_TEOR">Telephone order</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdHead(
			string m3_PUNO, 
			string m3_CMCO = null, 
			DateTime? m3_PUDT = null, 
			string m3_LNCD = null, 
			string m3_TEPY = null, 
			string m3_PYME = null, 
			string m3_TEAF = null, 
			string m3_TEPA = null, 
			string m3_YRE1 = null, 
			DateTime? m3_DWDT = null, 
			string m3_PRSU = null, 
			string m3_OURR = null, 
			string m3_OURT = null, 
			string m3_PURC = null, 
			string m3_BUYE = null, 
			string m3_FUSC = null, 
			decimal? m3_ODAM = null, 
			int? m3_OTPC = null, 
			string m3_TFNO = null, 
			int? m3_CUTE = null, 
			decimal? m3_AGRA = null, 
			string m3_PYAD = null, 
			string m3_SHVI = null, 
			string m3_FIDS = null, 
			int? m3_TEOR = null, 
			string m3_PROJ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CMCO))
				request.WithQueryParameter("CMCO", m3_CMCO.Trim());
			if (m3_PUDT.HasValue)
				request.WithQueryParameter("PUDT", m3_PUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYME))
				request.WithQueryParameter("PYME", m3_PYME.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEAF))
				request.WithQueryParameter("TEAF", m3_TEAF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YRE1))
				request.WithQueryParameter("YRE1", m3_YRE1.Trim());
			if (m3_DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3_DWDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PRSU))
				request.WithQueryParameter("PRSU", m3_PRSU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OURR))
				request.WithQueryParameter("OURR", m3_OURR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OURT))
				request.WithQueryParameter("OURT", m3_OURT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PURC))
				request.WithQueryParameter("PURC", m3_PURC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BUYE))
				request.WithQueryParameter("BUYE", m3_BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FUSC))
				request.WithQueryParameter("FUSC", m3_FUSC.Trim());
			if (m3_ODAM.HasValue)
				request.WithQueryParameter("ODAM", m3_ODAM.Value.ToString());
			if (m3_OTPC.HasValue)
				request.WithQueryParameter("OTPC", m3_OTPC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (m3_CUTE.HasValue)
				request.WithQueryParameter("CUTE", m3_CUTE.Value.ToString());
			if (m3_AGRA.HasValue)
				request.WithQueryParameter("AGRA", m3_AGRA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PYAD))
				request.WithQueryParameter("PYAD", m3_PYAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SHVI))
				request.WithQueryParameter("SHVI", m3_SHVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIDS))
				request.WithQueryParameter("FIDS", m3_FIDS.Trim());
			if (m3_TEOR.HasValue)
				request.WithQueryParameter("TEOR", m3_TEOR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
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
		/// Name UpdLine
		/// Description Update Purchase Order Line
		/// Version Release: 5ea7
		/// </summary>
		/// <param name="m3_PUNO">Purchase order number (Required)</param>
		/// <param name="m3_PNLI">Purchase order line (Required)</param>
		/// <param name="m3_PNLS">Purchase order line subnumber (Required)</param>
		/// <param name="m3_SITE">Supplier item number</param>
		/// <param name="m3_PITD">Purchase order item name</param>
		/// <param name="m3_PITT">Purchase order item description</param>
		/// <param name="m3_SORN">Supplier order number</param>
		/// <param name="m3_PROD">Manufacturer</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="m3_NOED">Revision printout</param>
		/// <param name="m3_REVN">PO Revision number</param>
		/// <param name="m3_ETRF">External instruction</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_ODI1">Discount 1</param>
		/// <param name="m3_ODI2">Discount 2</param>
		/// <param name="m3_ODI3">Discount 3</param>
		/// <param name="m3_PUUN">Purchase order U/M</param>
		/// <param name="m3_PPUN">Purchase price U/M</param>
		/// <param name="m3_PUCD">Purchase price quantity</param>
		/// <param name="m3_PTCD">Purchase price text</param>
		/// <param name="m3_OTOD">Part of order total discount</param>
		/// <param name="m3_ORQA">Ordered quantity - alternate U/M</param>
		/// <param name="m3_DT4T">Date type</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_OURR">Our reference number</param>
		/// <param name="m3_OURT">Reference type</param>
		/// <param name="m3_UPAV">Update material plan</param>
		/// <param name="m3_REPP">Representative price</param>
		/// <param name="m3_PRIP">Priority</param>
		/// <param name="m3_FUSC">Monitoring activity list</param>
		/// <param name="m3_PURC">Requisition by</param>
		/// <param name="m3_GRMT">Goods receiving method</param>
		/// <param name="m3_UPIV">Update item/supplier with purchase price</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_VTCD">VAT code</param>
		/// <param name="m3_PLDT">Planning date</param>
		/// <param name="m3_CSNO">Customs statistical number</param>
		/// <param name="m3_ECLC">Labor code - trade statistics (TST)</param>
		/// <param name="m3_VRCD">Business type - trade statistics (TST)</param>
		/// <param name="m3_ECF1">User-defined TST field 1</param>
		/// <param name="m3_ECF2">User-defined TST field 2</param>
		/// <param name="m3_ECF3">User-defined TST field 3</param>
		/// <param name="m3_ECF4">User-defined TST field  4</param>
		/// <param name="m3_ECF5">User-defined TST field 5</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_CPRI">Customs procedure - import</param>
		/// <param name="m3_HAFE">Harbor or airport</param>
		/// <param name="m3_TAXC">Tax code customer/address</param>
		/// <param name="m3_TIHM">Time hours & minutes</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_ATPR">Attribute pricing rule</param>
		/// <param name="m3_MSTN">Milestone chain</param>
		/// <param name="m3_FATP">Fixed asset type</param>
		/// <param name="m3_ORCO">Country of origin</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TEDL">Delivery terms</param>
		/// <param name="m3_TEL1">Terms text</param>
		/// <param name="m3_RASN">Rail station</param>
		/// <param name="m3_PIAD">Pickup address number</param>
		/// <param name="m3_ORAD">Origin address</param>
		/// <param name="m3_DWDT">Requested delivery date</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_COCE">cost center</param>
		/// <param name="m3_GEOC">Geographical code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdLine(
			string m3_PUNO, 
			int m3_PNLI, 
			int m3_PNLS, 
			string m3_SITE = null, 
			string m3_PITD = null, 
			string m3_PITT = null, 
			string m3_SORN = null, 
			string m3_PROD = null, 
			string m3_ECVE = null, 
			int? m3_NOED = null, 
			string m3_REVN = null, 
			string m3_ETRF = null, 
			decimal? m3_PUPR = null, 
			int? m3_ODI1 = null, 
			int? m3_ODI2 = null, 
			int? m3_ODI3 = null, 
			string m3_PUUN = null, 
			string m3_PPUN = null, 
			int? m3_PUCD = null, 
			int? m3_PTCD = null, 
			int? m3_OTOD = null, 
			decimal? m3_ORQA = null, 
			int? m3_DT4T = null, 
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_OURR = null, 
			string m3_OURT = null, 
			int? m3_UPAV = null, 
			int? m3_REPP = null, 
			string m3_PRIP = null, 
			string m3_FUSC = null, 
			string m3_PURC = null, 
			string m3_GRMT = null, 
			int? m3_UPIV = null, 
			string m3_PACT = null, 
			int? m3_VTCD = null, 
			DateTime? m3_PLDT = null, 
			string m3_CSNO = null, 
			string m3_ECLC = null, 
			string m3_VRCD = null, 
			string m3_ECF1 = null, 
			string m3_ECF2 = null, 
			string m3_ECF3 = null, 
			string m3_ECF4 = null, 
			string m3_ECF5 = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_CPRI = null, 
			string m3_HAFE = null, 
			string m3_TAXC = null, 
			int? m3_TIHM = null, 
			decimal? m3_ATNR = null, 
			string m3_ATPR = null, 
			long? m3_MSTN = null, 
			string m3_FATP = null, 
			string m3_ORCO = null, 
			string m3_MODL = null, 
			string m3_TEDL = null, 
			string m3_TEL1 = null, 
			string m3_RASN = null, 
			string m3_PIAD = null, 
			string m3_ORAD = null, 
			DateTime? m3_DWDT = null, 
			string m3_ACRF = null, 
			string m3_COCE = null, 
			int? m3_GEOC = null, 
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
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim())
				.WithQueryParameter("PNLI", m3_PNLI.ToString())
				.WithQueryParameter("PNLS", m3_PNLS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SITE))
				request.WithQueryParameter("SITE", m3_SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PITD))
				request.WithQueryParameter("PITD", m3_PITD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PITT))
				request.WithQueryParameter("PITT", m3_PITT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SORN))
				request.WithQueryParameter("SORN", m3_SORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROD))
				request.WithQueryParameter("PROD", m3_PROD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
			if (m3_NOED.HasValue)
				request.WithQueryParameter("NOED", m3_NOED.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REVN))
				request.WithQueryParameter("REVN", m3_REVN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETRF))
				request.WithQueryParameter("ETRF", m3_ETRF.Trim());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (m3_ODI1.HasValue)
				request.WithQueryParameter("ODI1", m3_ODI1.Value.ToString());
			if (m3_ODI2.HasValue)
				request.WithQueryParameter("ODI2", m3_ODI2.Value.ToString());
			if (m3_ODI3.HasValue)
				request.WithQueryParameter("ODI3", m3_ODI3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PUUN))
				request.WithQueryParameter("PUUN", m3_PUUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PPUN))
				request.WithQueryParameter("PPUN", m3_PPUN.Trim());
			if (m3_PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3_PUCD.Value.ToString());
			if (m3_PTCD.HasValue)
				request.WithQueryParameter("PTCD", m3_PTCD.Value.ToString());
			if (m3_OTOD.HasValue)
				request.WithQueryParameter("OTOD", m3_OTOD.Value.ToString());
			if (m3_ORQA.HasValue)
				request.WithQueryParameter("ORQA", m3_ORQA.Value.ToString());
			if (m3_DT4T.HasValue)
				request.WithQueryParameter("DT4T", m3_DT4T.Value.ToString());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OURR))
				request.WithQueryParameter("OURR", m3_OURR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OURT))
				request.WithQueryParameter("OURT", m3_OURT.Trim());
			if (m3_UPAV.HasValue)
				request.WithQueryParameter("UPAV", m3_UPAV.Value.ToString());
			if (m3_REPP.HasValue)
				request.WithQueryParameter("REPP", m3_REPP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRIP))
				request.WithQueryParameter("PRIP", m3_PRIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FUSC))
				request.WithQueryParameter("FUSC", m3_FUSC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PURC))
				request.WithQueryParameter("PURC", m3_PURC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRMT))
				request.WithQueryParameter("GRMT", m3_GRMT.Trim());
			if (m3_UPIV.HasValue)
				request.WithQueryParameter("UPIV", m3_UPIV.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (m3_VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3_VTCD.Value.ToString());
			if (m3_PLDT.HasValue)
				request.WithQueryParameter("PLDT", m3_PLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CSNO))
				request.WithQueryParameter("CSNO", m3_CSNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECLC))
				request.WithQueryParameter("ECLC", m3_ECLC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VRCD))
				request.WithQueryParameter("VRCD", m3_VRCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECF1))
				request.WithQueryParameter("ECF1", m3_ECF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECF2))
				request.WithQueryParameter("ECF2", m3_ECF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECF3))
				request.WithQueryParameter("ECF3", m3_ECF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECF4))
				request.WithQueryParameter("ECF4", m3_ECF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECF5))
				request.WithQueryParameter("ECF5", m3_ECF5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CPRI))
				request.WithQueryParameter("CPRI", m3_CPRI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HAFE))
				request.WithQueryParameter("HAFE", m3_HAFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAXC))
				request.WithQueryParameter("TAXC", m3_TAXC.Trim());
			if (m3_TIHM.HasValue)
				request.WithQueryParameter("TIHM", m3_TIHM.Value.ToString());
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ATPR))
				request.WithQueryParameter("ATPR", m3_ATPR.Trim());
			if (m3_MSTN.HasValue)
				request.WithQueryParameter("MSTN", m3_MSTN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FATP))
				request.WithQueryParameter("FATP", m3_FATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEL1))
				request.WithQueryParameter("TEL1", m3_TEL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RASN))
				request.WithQueryParameter("RASN", m3_RASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PIAD))
				request.WithQueryParameter("PIAD", m3_PIAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORAD))
				request.WithQueryParameter("ORAD", m3_ORAD.Trim());
			if (m3_DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3_DWDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COCE))
				request.WithQueryParameter("COCE", m3_COCE.Trim());
			if (m3_GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3_GEOC.Value.ToString());

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
