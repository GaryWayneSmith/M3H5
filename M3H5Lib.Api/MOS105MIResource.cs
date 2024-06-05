/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MOS105MI;
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
	/// Name: MOS105MI
	/// Component Name: MOS105MI
	/// Description: Api: Purchase interface for work order
	/// Version Release: 5ea0
	///</summary>
	public partial class MOS105MIResource : M3BaseResourceEndpoint
	{
		public MOS105MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS105MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddPoReq
		/// Description Add purchase request to work order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PPQT">Planned quantity (Required)</param>
		/// <param name="m3_RESP">Responsible (Required)</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_PRCS">Service process</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_PLDT">Planning date</param>
		/// <param name="m3_BUYE">Buyer</param>
		/// <param name="m3_RFID">Reference</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_SITE">Supplier item number</param>
		/// <param name="m3_PITD">Purchase order item name</param>
		/// <param name="m3_PITT">Purchase order item description</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_PPUN">Purchase price U/M</param>
		/// <param name="m3_PUCD">Purchase price quantity</param>
		/// <param name="m3_ODI1">Discount 1</param>
		/// <param name="m3_ODI2">Discount 2</param>
		/// <param name="m3_ODI3">Discount 3</param>
		/// <param name="m3_TEOR">Telephone order</param>
		/// <param name="m3_PTXT">Note</param>
		/// <param name="m3_YRE3">Your reference</param>
		/// <param name="m3_OUR1">Our reference number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_NHAI">Next item number</param>
		/// <param name="m3_NHSN">Next serial number</param>
		/// <param name="m3_AECN">Engineering order number</param>
		/// <param name="m3_DEID">Complaint</param>
		/// <param name="m3_MVA1">Meter value 1</param>
		/// <param name="m3_MVA2">Meter value 2</param>
		/// <param name="m3_MVA3">Meter value 3</param>
		/// <param name="m3_MVA4">Meter value 4</param>
		/// <param name="m3_MVB1">Actual meter value 1</param>
		/// <param name="m3_MVB2">Actual meter value 2</param>
		/// <param name="m3_MVB3">Actual meter value 3</param>
		/// <param name="m3_MVB4">Actual meter value 4</param>
		/// <param name="m3_MES1">Meter 1</param>
		/// <param name="m3_MES2">Meter 2</param>
		/// <param name="m3_MES3">Meter 3</param>
		/// <param name="m3_MES4">Meter 4</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_PRNS">Service product</param>
		/// <param name="m3_CFGH">NHA configuration position</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_CFI1">User-defined field 1 - item</param>
		/// <param name="m3_CFI2">User-defined field 2 - item</param>
		/// <param name="m3_CFI3">User-defined field 3 - item</param>
		/// <param name="m3_CFI4">User-defined field 4 - item</param>
		/// <param name="m3_CFI5">User-defined field 5 - item</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_MPRN">Main product number</param>
		/// <param name="m3_MSTR">Main structure type</param>
		/// <param name="m3_MSUF">Main service</param>
		/// <param name="m3_ACTP">Action message (AM)</param>
		/// <param name="m3_EXNO">Concession number</param>
		/// <param name="m3_PSTS">Status - planned MO</param>
		/// <param name="m3_METE">Selected meter</param>
		/// <param name="m3_OPED">Operational tolerance - date</param>
		/// <param name="m3_ETD1">Economical tolerance date 1</param>
		/// <param name="m3_ETD2">Economical tolerance date 2</param>
		/// <param name="m3_BLTA">Competing meters</param>
		/// <param name="m3_FSER">First service</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_GRMT">Goods receiving method</param>
		/// <param name="m3_IRCV">Recipient</param>
		/// <param name="m3_PTCD">Purchase price text</param>
		/// <param name="m3_REPP">Representative price</param>
		/// <param name="m3_ORAD">Origin address</param>
		/// <param name="m3_PURC">Requisition by</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_PLPN">Planned order</param>
		/// <param name="m3_COCE">Cost center</param>
		/// <param name="m3_PF20">Generate PUNO</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPoReqResponse></returns>
		/// <exception cref="M3Exception<AddPoReqResponse>"></exception>
		public async Task<M3Response<AddPoReqResponse>> AddPoReq(
			string m3_FACI, 
			decimal m3_PPQT, 
			string m3_RESP, 
			string m3_WHLO = null, 
			string m3_ITNO = null, 
			string m3_PRCS = null, 
			string m3_SUFI = null, 
			string m3_STRT = null, 
			DateTime? m3_PLDT = null, 
			string m3_BUYE = null, 
			string m3_RFID = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORC = null, 
			string m3_SUNO = null, 
			string m3_SITE = null, 
			string m3_PITD = null, 
			string m3_PITT = null, 
			decimal? m3_PUPR = null, 
			string m3_PPUN = null, 
			int? m3_PUCD = null, 
			int? m3_ODI1 = null, 
			int? m3_ODI2 = null, 
			int? m3_ODI3 = null, 
			int? m3_TEOR = null, 
			string m3_PTXT = null, 
			string m3_YRE3 = null, 
			string m3_OUR1 = null, 
			string m3_BANO = null, 
			string m3_NHAI = null, 
			string m3_NHSN = null, 
			string m3_AECN = null, 
			int? m3_DEID = null, 
			decimal? m3_MVA1 = null, 
			decimal? m3_MVA2 = null, 
			decimal? m3_MVA3 = null, 
			decimal? m3_MVA4 = null, 
			decimal? m3_MVB1 = null, 
			decimal? m3_MVB2 = null, 
			decimal? m3_MVB3 = null, 
			decimal? m3_MVB4 = null, 
			string m3_MES1 = null, 
			string m3_MES2 = null, 
			string m3_MES3 = null, 
			string m3_MES4 = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_PRNS = null, 
			string m3_CFGH = null, 
			string m3_CFGL = null, 
			string m3_CFI1 = null, 
			decimal? m3_CFI2 = null, 
			string m3_CFI3 = null, 
			string m3_CFI4 = null, 
			string m3_CFI5 = null, 
			string m3_AGNB = null, 
			string m3_MPRN = null, 
			string m3_MSTR = null, 
			string m3_MSUF = null, 
			string m3_ACTP = null, 
			string m3_EXNO = null, 
			string m3_PSTS = null, 
			int? m3_METE = null, 
			DateTime? m3_OPED = null, 
			DateTime? m3_ETD1 = null, 
			DateTime? m3_ETD2 = null, 
			int? m3_BLTA = null, 
			int? m3_FSER = null, 
			int? m3_RORX = null, 
			decimal? m3_ATNR = null, 
			string m3_GRMT = null, 
			string m3_IRCV = null, 
			int? m3_PTCD = null, 
			int? m3_REPP = null, 
			string m3_ORAD = null, 
			string m3_PURC = null, 
			string m3_ACRF = null, 
			int? m3_PLPN = null, 
			string m3_COCE = null, 
			string m3_PF20 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPoReq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_RESP))
				throw new ArgumentNullException("m3_RESP");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PPQT", m3_PPQT.ToString())
				.WithQueryParameter("RESP", m3_RESP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRCS))
				request.WithQueryParameter("PRCS", m3_PRCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_PLDT.HasValue)
				request.WithQueryParameter("PLDT", m3_PLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_BUYE))
				request.WithQueryParameter("BUYE", m3_BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFID))
				request.WithQueryParameter("RFID", m3_RFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SITE))
				request.WithQueryParameter("SITE", m3_SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PITD))
				request.WithQueryParameter("PITD", m3_PITD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PITT))
				request.WithQueryParameter("PITT", m3_PITT.Trim());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PPUN))
				request.WithQueryParameter("PPUN", m3_PPUN.Trim());
			if (m3_PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3_PUCD.Value.ToString());
			if (m3_ODI1.HasValue)
				request.WithQueryParameter("ODI1", m3_ODI1.Value.ToString());
			if (m3_ODI2.HasValue)
				request.WithQueryParameter("ODI2", m3_ODI2.Value.ToString());
			if (m3_ODI3.HasValue)
				request.WithQueryParameter("ODI3", m3_ODI3.Value.ToString());
			if (m3_TEOR.HasValue)
				request.WithQueryParameter("TEOR", m3_TEOR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PTXT))
				request.WithQueryParameter("PTXT", m3_PTXT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YRE3))
				request.WithQueryParameter("YRE3", m3_YRE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OUR1))
				request.WithQueryParameter("OUR1", m3_OUR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NHAI))
				request.WithQueryParameter("NHAI", m3_NHAI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NHSN))
				request.WithQueryParameter("NHSN", m3_NHSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AECN))
				request.WithQueryParameter("AECN", m3_AECN.Trim());
			if (m3_DEID.HasValue)
				request.WithQueryParameter("DEID", m3_DEID.Value.ToString());
			if (m3_MVA1.HasValue)
				request.WithQueryParameter("MVA1", m3_MVA1.Value.ToString());
			if (m3_MVA2.HasValue)
				request.WithQueryParameter("MVA2", m3_MVA2.Value.ToString());
			if (m3_MVA3.HasValue)
				request.WithQueryParameter("MVA3", m3_MVA3.Value.ToString());
			if (m3_MVA4.HasValue)
				request.WithQueryParameter("MVA4", m3_MVA4.Value.ToString());
			if (m3_MVB1.HasValue)
				request.WithQueryParameter("MVB1", m3_MVB1.Value.ToString());
			if (m3_MVB2.HasValue)
				request.WithQueryParameter("MVB2", m3_MVB2.Value.ToString());
			if (m3_MVB3.HasValue)
				request.WithQueryParameter("MVB3", m3_MVB3.Value.ToString());
			if (m3_MVB4.HasValue)
				request.WithQueryParameter("MVB4", m3_MVB4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MES1))
				request.WithQueryParameter("MES1", m3_MES1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES2))
				request.WithQueryParameter("MES2", m3_MES2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES3))
				request.WithQueryParameter("MES3", m3_MES3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES4))
				request.WithQueryParameter("MES4", m3_MES4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNS))
				request.WithQueryParameter("PRNS", m3_PRNS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGH))
				request.WithQueryParameter("CFGH", m3_CFGH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI1))
				request.WithQueryParameter("CFI1", m3_CFI1.Trim());
			if (m3_CFI2.HasValue)
				request.WithQueryParameter("CFI2", m3_CFI2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFI3))
				request.WithQueryParameter("CFI3", m3_CFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI4))
				request.WithQueryParameter("CFI4", m3_CFI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI5))
				request.WithQueryParameter("CFI5", m3_CFI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MPRN))
				request.WithQueryParameter("MPRN", m3_MPRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSTR))
				request.WithQueryParameter("MSTR", m3_MSTR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSUF))
				request.WithQueryParameter("MSUF", m3_MSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACTP))
				request.WithQueryParameter("ACTP", m3_ACTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXNO))
				request.WithQueryParameter("EXNO", m3_EXNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PSTS))
				request.WithQueryParameter("PSTS", m3_PSTS.Trim());
			if (m3_METE.HasValue)
				request.WithQueryParameter("METE", m3_METE.Value.ToString());
			if (m3_OPED.HasValue)
				request.WithQueryParameter("OPED", m3_OPED.Value.ToM3String());
			if (m3_ETD1.HasValue)
				request.WithQueryParameter("ETD1", m3_ETD1.Value.ToM3String());
			if (m3_ETD2.HasValue)
				request.WithQueryParameter("ETD2", m3_ETD2.Value.ToM3String());
			if (m3_BLTA.HasValue)
				request.WithQueryParameter("BLTA", m3_BLTA.Value.ToString());
			if (m3_FSER.HasValue)
				request.WithQueryParameter("FSER", m3_FSER.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_GRMT))
				request.WithQueryParameter("GRMT", m3_GRMT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IRCV))
				request.WithQueryParameter("IRCV", m3_IRCV.Trim());
			if (m3_PTCD.HasValue)
				request.WithQueryParameter("PTCD", m3_PTCD.Value.ToString());
			if (m3_REPP.HasValue)
				request.WithQueryParameter("REPP", m3_REPP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORAD))
				request.WithQueryParameter("ORAD", m3_ORAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PURC))
				request.WithQueryParameter("PURC", m3_PURC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (m3_PLPN.HasValue)
				request.WithQueryParameter("PLPN", m3_PLPN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_COCE))
				request.WithQueryParameter("COCE", m3_COCE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PF20))
				request.WithQueryParameter("PF20", m3_PF20.Trim());

			// Execute the request
			var result = await Execute<AddPoReqResponse>(
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
		/// Name UpdCostOnWoMat
		/// Description Update cost and sts on wo material
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_MSEQ">Sequence number (Required)</param>
		/// <param name="m3_WMST">Material status (Required)</param>
		/// <param name="m3_MPRC">Component price</param>
		/// <param name="m3_RFTX">Reference text</param>
		/// <param name="m3_CLOP">Yes/no - close operation</param>
		/// <param name="m3_ALQT">Allocated quantity - basic U/M</param>
		/// <param name="m3_RVQT">Received quantity</param>
		/// <param name="m3_RPQT">Reported quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdCostOnWoMat(
			string m3_MWNO, 
			int m3_MSEQ, 
			string m3_WMST, 
			decimal? m3_MPRC = null, 
			string m3_RFTX = null, 
			int? m3_CLOP = null, 
			decimal? m3_ALQT = null, 
			decimal? m3_RVQT = null, 
			decimal? m3_RPQT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdCostOnWoMat",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");
			if (string.IsNullOrWhiteSpace(m3_WMST))
				throw new ArgumentNullException("m3_WMST");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("MSEQ", m3_MSEQ.ToString())
				.WithQueryParameter("WMST", m3_WMST.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_MPRC.HasValue)
				request.WithQueryParameter("MPRC", m3_MPRC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RFTX))
				request.WithQueryParameter("RFTX", m3_RFTX.Trim());
			if (m3_CLOP.HasValue)
				request.WithQueryParameter("CLOP", m3_CLOP.Value.ToString());
			if (m3_ALQT.HasValue)
				request.WithQueryParameter("ALQT", m3_ALQT.Value.ToString());
			if (m3_RVQT.HasValue)
				request.WithQueryParameter("RVQT", m3_RVQT.Value.ToString());
			if (m3_RPQT.HasValue)
				request.WithQueryParameter("RPQT", m3_RPQT.Value.ToString());

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
		/// Name UpdPoLine
		/// Description Update Po line with info from external system
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PUNO">Purchase order number (Required)</param>
		/// <param name="m3_PNLI">Purchase order line (Required)</param>
		/// <param name="m3_PNLS">Purchase order line subnumber</param>
		/// <param name="m3_SORN">Supplier order number</param>
		/// <param name="m3_OURR">Our reference number</param>
		/// <param name="m3_ECF1">User-defined TST field 1</param>
		/// <param name="m3_ECF2">User-defined TST field 2</param>
		/// <param name="m3_ECF3">User-defined TST field 3</param>
		/// <param name="m3_ECF4">User-defined TST field  4</param>
		/// <param name="m3_ECF5">User-defined TST field 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPoLine(
			string m3_PUNO, 
			int m3_PNLI, 
			int? m3_PNLS = null, 
			string m3_SORN = null, 
			string m3_OURR = null, 
			string m3_ECF1 = null, 
			string m3_ECF2 = null, 
			string m3_ECF3 = null, 
			string m3_ECF4 = null, 
			string m3_ECF5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdPoLine",
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
			if (!string.IsNullOrWhiteSpace(m3_SORN))
				request.WithQueryParameter("SORN", m3_SORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OURR))
				request.WithQueryParameter("OURR", m3_OURR.Trim());
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
