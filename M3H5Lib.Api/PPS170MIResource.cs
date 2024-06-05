/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PPS170MI;
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
	/// Name: PPS170MI
	/// Component Name: PurchaseOrderProposal
	/// Description: Purchase order proposal information and text interface
	/// Version Release: 5ea2
	///</summary>
	public partial class PPS170MIResource : M3BaseResourceEndpoint
	{
		public PPS170MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PPS170MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ClrInboxPOP
		/// Description Clear Inbox for POP
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ClrInboxPOP(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ClrInboxPOP",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name CrtPOP
		/// Description Create Purchase Order Proposal
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_PLDT">Planning date (Required)</param>
		/// <param name="m3_PPQT">Planned quantity (Required)</param>
		/// <param name="m3_PSTS">Status (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PLPN">Planned order</param>
		/// <param name="m3_PLPS">Subnumber - planned order</param>
		/// <param name="m3_PRCS">Service process</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_ODI1">Discount 1</param>
		/// <param name="m3_ODI2">Discount 2</param>
		/// <param name="m3_ODI3">Discount 3</param>
		/// <param name="m3_OURT">Reference type</param>
		/// <param name="m3_OURR">Our reference number</param>
		/// <param name="m3_PPUN">Purchase price U/M</param>
		/// <param name="m3_PUCD">Purchase price quantity</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TEDL">Delivery terms</param>
		/// <param name="m3_PRIO">Priority</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_PITD">Purchase order item name</param>
		/// <param name="m3_PITT">Purchase order item description</param>
		/// <param name="m3_SITE">Supplier item number</param>
		/// <param name="m3_YRE3">Your reference</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_COCE">Cost center</param>
		/// <param name="m3_PORQ">PO requisition</param>
		/// <param name="m3_RE20">Reference</param>
		/// <param name="m3_PURC">Requisition by</param>
		/// <param name="m3_BUYE">Buyer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CrtPOPResponse></returns>
		/// <exception cref="M3Exception<CrtPOPResponse>"></exception>
		public async Task<M3Response<CrtPOPResponse>> CrtPOP(
			string m3_WHLO, 
			string m3_ITNO, 
			string m3_SUNO, 
			DateTime m3_PLDT, 
			decimal m3_PPQT, 
			string m3_PSTS, 
			int? m3_CONO = null, 
			int? m3_PLPN = null, 
			int? m3_PLPS = null, 
			string m3_PRCS = null, 
			string m3_SUFI = null, 
			string m3_ORTY = null, 
			string m3_RESP = null, 
			string m3_CUCD = null, 
			int? m3_ODI1 = null, 
			int? m3_ODI2 = null, 
			int? m3_ODI3 = null, 
			string m3_OURT = null, 
			string m3_OURR = null, 
			string m3_PPUN = null, 
			int? m3_PUCD = null, 
			decimal? m3_PUPR = null, 
			string m3_MODL = null, 
			string m3_TEDL = null, 
			int? m3_PRIO = null, 
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_PITD = null, 
			string m3_PITT = null, 
			string m3_SITE = null, 
			string m3_YRE3 = null, 
			string m3_BANO = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_STRT = null, 
			string m3_COCE = null, 
			int? m3_PORQ = null, 
			string m3_RE20 = null, 
			string m3_PURC = null, 
			string m3_BUYE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CrtPOP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_PSTS))
				throw new ArgumentNullException("m3_PSTS");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("PLDT", m3_PLDT.ToM3String())
				.WithQueryParameter("PPQT", m3_PPQT.ToString())
				.WithQueryParameter("PSTS", m3_PSTS.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PLPN.HasValue)
				request.WithQueryParameter("PLPN", m3_PLPN.Value.ToString());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRCS))
				request.WithQueryParameter("PRCS", m3_PRCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_ODI1.HasValue)
				request.WithQueryParameter("ODI1", m3_ODI1.Value.ToString());
			if (m3_ODI2.HasValue)
				request.WithQueryParameter("ODI2", m3_ODI2.Value.ToString());
			if (m3_ODI3.HasValue)
				request.WithQueryParameter("ODI3", m3_ODI3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OURT))
				request.WithQueryParameter("OURT", m3_OURT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OURR))
				request.WithQueryParameter("OURR", m3_OURR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PPUN))
				request.WithQueryParameter("PPUN", m3_PPUN.Trim());
			if (m3_PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3_PUCD.Value.ToString());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (m3_PRIO.HasValue)
				request.WithQueryParameter("PRIO", m3_PRIO.Value.ToString());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PITD))
				request.WithQueryParameter("PITD", m3_PITD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PITT))
				request.WithQueryParameter("PITT", m3_PITT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SITE))
				request.WithQueryParameter("SITE", m3_SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YRE3))
				request.WithQueryParameter("YRE3", m3_YRE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COCE))
				request.WithQueryParameter("COCE", m3_COCE.Trim());
			if (m3_PORQ.HasValue)
				request.WithQueryParameter("PORQ", m3_PORQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RE20))
				request.WithQueryParameter("RE20", m3_RE20.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PURC))
				request.WithQueryParameter("PURC", m3_PURC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BUYE))
				request.WithQueryParameter("BUYE", m3_BUYE.Trim());

			// Execute the request
			var result = await Execute<CrtPOPResponse>(
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
		/// Name DelPlannedPO
		/// Description DelPlannedPO
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PLPN">Planned order (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PLPS">Subnumber - planned order</param>
		/// <param name="m3_PLP2">Subnumber - order proposal</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelPlannedPO(
			int m3_PLPN, 
			int? m3_CONO = null, 
			int? m3_PLPS = null, 
			int? m3_PLP2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelPlannedPO",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());
			if (m3_PLP2.HasValue)
				request.WithQueryParameter("PLP2", m3_PLP2.Value.ToString());

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
		/// Name GetPOProp
		/// Description Retrieve purchase order proposal
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLPN">Order proposal number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PLPS">Sub number - order proposal</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPOPropResponse></returns>
		/// <exception cref="M3Exception<GetPOPropResponse>"></exception>
		public async Task<M3Response<GetPOPropResponse>> GetPOProp(
			int m3_PLPN, 
			int? m3_CONO = null, 
			int? m3_PLPS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPOProp",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());

			// Execute the request
			var result = await Execute<GetPOPropResponse>(
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
		/// Name GetPlannedPO
		/// Description Retrieve purchase order proposal
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLPN">Order proposal number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PLPS">Sub number - order proposal</param>
		/// <param name="m3_PLP2">Subnumber - order proposal</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPlannedPOResponse></returns>
		/// <exception cref="M3Exception<GetPlannedPOResponse>"></exception>
		public async Task<M3Response<GetPlannedPOResponse>> GetPlannedPO(
			int m3_PLPN, 
			int? m3_CONO = null, 
			int? m3_PLPS = null, 
			int? m3_PLP2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPlannedPO",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());
			if (m3_PLP2.HasValue)
				request.WithQueryParameter("PLP2", m3_PLP2.Value.ToString());

			// Execute the request
			var result = await Execute<GetPlannedPOResponse>(
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
		/// Name GetText
		/// Description Retrieve text associated with a purchase order proposal
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLPN">Order proposal number (Required)</param>
		/// <param name="m3_LNCD">Language (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_PLPS">Sub number - order proposal</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTextResponse></returns>
		/// <exception cref="M3Exception<GetTextResponse>"></exception>
		public async Task<M3Response<GetTextResponse>> GetText(
			int m3_PLPN, 
			string m3_LNCD, 
			int? m3_CONO = null, 
			string m3_WHLO = null, 
			int? m3_PLPS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_LNCD))
				throw new ArgumentNullException("m3_LNCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString())
				.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());

			// Execute the request
			var result = await Execute<GetTextResponse>(
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
		/// Name GetUserJobSts
		/// Description Get Update status per user
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetUserJobStsResponse></returns>
		/// <exception cref="M3Exception<GetUserJobStsResponse>"></exception>
		public async Task<M3Response<GetUserJobStsResponse>> GetUserJobSts(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetUserJobSts",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetUserJobStsResponse>(
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
		/// Name LstPOProp
		/// Description List purchase order proposal
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_PURC">Requisition by (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPOPropResponse></returns>
		/// <exception cref="M3Exception<LstPOPropResponse>"></exception>
		public async Task<M3Response<LstPOPropResponse>> LstPOProp(
			string m3_WHLO, 
			string m3_PURC, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPOProp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_PURC))
				throw new ArgumentNullException("m3_PURC");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("PURC", m3_PURC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstPOPropResponse>(
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
		/// Name LstPlannedPO
		/// Description List purchase order proposal
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLPN">Order proposal number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPlannedPOResponse></returns>
		/// <exception cref="M3Exception<LstPlannedPOResponse>"></exception>
		public async Task<M3Response<LstPlannedPOResponse>> LstPlannedPO(
			int m3_PLPN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPlannedPO",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstPlannedPOResponse>(
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
		/// Name LstText
		/// Description List text associated with a purchase order proposal
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLPN">Order proposal number (Required)</param>
		/// <param name="m3_LNCD">Language (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_PLPS">Sub number - order proposal</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTextResponse></returns>
		/// <exception cref="M3Exception<LstTextResponse>"></exception>
		public async Task<M3Response<LstTextResponse>> LstText(
			int m3_PLPN, 
			string m3_LNCD, 
			int? m3_CONO = null, 
			string m3_WHLO = null, 
			int? m3_PLPS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_LNCD))
				throw new ArgumentNullException("m3_LNCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString())
				.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());

			// Execute the request
			var result = await Execute<LstTextResponse>(
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
		/// Name SelErrPOP
		/// Description Selection of POP not correctly updated
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelErrPOPResponse></returns>
		/// <exception cref="M3Exception<SelErrPOPResponse>"></exception>
		public async Task<M3Response<SelErrPOPResponse>> SelErrPOP(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelErrPOP",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<SelErrPOPResponse>(
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
		/// Name Select
		/// Description Selection of POP for MSP/APP
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_STSF">From status</param>
		/// <param name="m3_STST">To status</param>
		/// <param name="m3_P150">Deselect POP not affecting mtrl balance</param>
		/// <param name="m3_APIP">APS-policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectResponse></returns>
		/// <exception cref="M3Exception<SelectResponse>"></exception>
		public async Task<M3Response<SelectResponse>> Select(
			string m3_WHLO, 
			int? m3_CONO = null, 
			string m3_WHGR = null, 
			int? m3_STSF = null, 
			int? m3_STST = null, 
			int? m3_P150 = null, 
			string m3_APIP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Select",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (m3_STSF.HasValue)
				request.WithQueryParameter("STSF", m3_STSF.Value.ToString());
			if (m3_STST.HasValue)
				request.WithQueryParameter("STST", m3_STST.Value.ToString());
			if (m3_P150.HasValue)
				request.WithQueryParameter("P150", m3_P150.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());

			// Execute the request
			var result = await Execute<SelectResponse>(
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
		/// Name SetUserJobSts
		/// Description Set update status per user
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STA3">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetUserJobSts(
			int? m3_CONO = null, 
			string m3_STA3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SetUserJobSts",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STA3))
				request.WithQueryParameter("STA3", m3_STA3.Trim());

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
		/// Name SndInboxPOP
		/// Description Send record to POP inbox
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_PRCS">Service process</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_PLPN">Order proposal number</param>
		/// <param name="m3_PLPS">Subnumber - order proposal</param>
		/// <param name="m3_PLP2">Subnumber - order proposal</param>
		/// <param name="m3_PLDT">Planning date</param>
		/// <param name="m3_PPQT">Planned quantity</param>
		/// <param name="m3_PSTS">Status - planned order</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_OPT2">Option</param>
		/// <param name="m3_PUNO">Purchase order number(PO-functionality)</param>
		/// <param name="m3_PNLI">Purchase order line(PO-functionality)</param>
		/// <param name="m3_PNLS">Purchase order line subnumber(PO-funct)</param>
		/// <param name="m3_CODT">Confirmed delivery date(PO-funct)</param>
		/// <param name="m3_CFQA">Confirmed quantity (PO-funct)</param>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="m3_MACN">Macro order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndInboxPOP(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			string m3_ITNO = null, 
			string m3_PRCS = null, 
			string m3_SUFI = null, 
			int? m3_PLPN = null, 
			int? m3_PLPS = null, 
			int? m3_PLP2 = null, 
			DateTime? m3_PLDT = null, 
			decimal? m3_PPQT = null, 
			string m3_PSTS = null, 
			long? m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			int? m3_RORC = null, 
			string m3_SUNO = null, 
			string m3_STRT = null, 
			int? m3_OPT2 = null, 
			string m3_PUNO = null, 
			int? m3_PNLI = null, 
			int? m3_PNLS = null, 
			DateTime? m3_CODT = null, 
			decimal? m3_CFQA = null, 
			string m3_ORCA = null, 
			decimal? m3_MACN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndInboxPOP",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRCS))
				request.WithQueryParameter("PRCS", m3_PRCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_PLPN.HasValue)
				request.WithQueryParameter("PLPN", m3_PLPN.Value.ToString());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());
			if (m3_PLP2.HasValue)
				request.WithQueryParameter("PLP2", m3_PLP2.Value.ToString());
			if (m3_PLDT.HasValue)
				request.WithQueryParameter("PLDT", m3_PLDT.Value.ToM3String());
			if (m3_PPQT.HasValue)
				request.WithQueryParameter("PPQT", m3_PPQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PSTS))
				request.WithQueryParameter("PSTS", m3_PSTS.Trim());
			if (m3_RORN.HasValue)
				request.WithQueryParameter("RORN", m3_RORN.Value.ToString());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_OPT2.HasValue)
				request.WithQueryParameter("OPT2", m3_OPT2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PUNO))
				request.WithQueryParameter("PUNO", m3_PUNO.Trim());
			if (m3_PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3_PNLI.Value.ToString());
			if (m3_PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3_PNLS.Value.ToString());
			if (m3_CODT.HasValue)
				request.WithQueryParameter("CODT", m3_CODT.Value.ToM3String());
			if (m3_CFQA.HasValue)
				request.WithQueryParameter("CFQA", m3_CFQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());
			if (m3_MACN.HasValue)
				request.WithQueryParameter("MACN", m3_MACN.Value.ToString());

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
		/// Name TriggerUpdJob
		/// Description Start updates processing
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STA3">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> TriggerUpdJob(
			int? m3_CONO = null, 
			string m3_STA3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/TriggerUpdJob",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STA3))
				request.WithQueryParameter("STA3", m3_STA3.Trim());

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
