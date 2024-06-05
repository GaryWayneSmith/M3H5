/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PPQT">Planned quantity (Required)</param>
		/// <param name="m3RESP">Responsible (Required)</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3PRCS">Service process</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3PLDT">Planning date</param>
		/// <param name="m3BUYE">Buyer</param>
		/// <param name="m3RFID">Reference</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SITE">Supplier item number</param>
		/// <param name="m3PITD">Purchase order item name</param>
		/// <param name="m3PITT">Purchase order item description</param>
		/// <param name="m3PUPR">Purchase price</param>
		/// <param name="m3PPUN">Purchase price U/M</param>
		/// <param name="m3PUCD">Purchase price quantity</param>
		/// <param name="m3ODI1">Discount 1</param>
		/// <param name="m3ODI2">Discount 2</param>
		/// <param name="m3ODI3">Discount 3</param>
		/// <param name="m3TEOR">Telephone order</param>
		/// <param name="m3PTXT">Note</param>
		/// <param name="m3YRE3">Your reference</param>
		/// <param name="m3OUR1">Our reference number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3NHAI">Next item number</param>
		/// <param name="m3NHSN">Next serial number</param>
		/// <param name="m3AECN">Engineering order number</param>
		/// <param name="m3DEID">Complaint</param>
		/// <param name="m3MVA1">Meter value 1</param>
		/// <param name="m3MVA2">Meter value 2</param>
		/// <param name="m3MVA3">Meter value 3</param>
		/// <param name="m3MVA4">Meter value 4</param>
		/// <param name="m3MVB1">Actual meter value 1</param>
		/// <param name="m3MVB2">Actual meter value 2</param>
		/// <param name="m3MVB3">Actual meter value 3</param>
		/// <param name="m3MVB4">Actual meter value 4</param>
		/// <param name="m3MES1">Meter 1</param>
		/// <param name="m3MES2">Meter 2</param>
		/// <param name="m3MES3">Meter 3</param>
		/// <param name="m3MES4">Meter 4</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3PRNS">Service product</param>
		/// <param name="m3CFGH">NHA configuration position</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3CFI1">User-defined field 1 - item</param>
		/// <param name="m3CFI2">User-defined field 2 - item</param>
		/// <param name="m3CFI3">User-defined field 3 - item</param>
		/// <param name="m3CFI4">User-defined field 4 - item</param>
		/// <param name="m3CFI5">User-defined field 5 - item</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3MPRN">Main product number</param>
		/// <param name="m3MSTR">Main structure type</param>
		/// <param name="m3MSUF">Main service</param>
		/// <param name="m3ACTP">Action message (AM)</param>
		/// <param name="m3EXNO">Concession number</param>
		/// <param name="m3PSTS">Status - planned MO</param>
		/// <param name="m3METE">Selected meter</param>
		/// <param name="m3OPED">Operational tolerance - date</param>
		/// <param name="m3ETD1">Economical tolerance date 1</param>
		/// <param name="m3ETD2">Economical tolerance date 2</param>
		/// <param name="m3BLTA">Competing meters</param>
		/// <param name="m3FSER">First service</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3GRMT">Goods receiving method</param>
		/// <param name="m3IRCV">Recipient</param>
		/// <param name="m3PTCD">Purchase price text</param>
		/// <param name="m3REPP">Representative price</param>
		/// <param name="m3ORAD">Origin address</param>
		/// <param name="m3PURC">Requisition by</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3PLPN">Planned order</param>
		/// <param name="m3COCE">Cost center</param>
		/// <param name="m3PF20">Generate PUNO</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPoReqResponse></returns>
		/// <exception cref="M3Exception<AddPoReqResponse>"></exception>
		public async Task<M3Response<AddPoReqResponse>> AddPoReq(
			string m3FACI, 
			decimal m3PPQT, 
			string m3RESP, 
			string m3WHLO = null, 
			string m3ITNO = null, 
			string m3PRCS = null, 
			string m3SUFI = null, 
			string m3STRT = null, 
			DateTime? m3PLDT = null, 
			string m3BUYE = null, 
			string m3RFID = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			int? m3RORC = null, 
			string m3SUNO = null, 
			string m3SITE = null, 
			string m3PITD = null, 
			string m3PITT = null, 
			decimal? m3PUPR = null, 
			string m3PPUN = null, 
			int? m3PUCD = null, 
			int? m3ODI1 = null, 
			int? m3ODI2 = null, 
			int? m3ODI3 = null, 
			int? m3TEOR = null, 
			string m3PTXT = null, 
			string m3YRE3 = null, 
			string m3OUR1 = null, 
			string m3BANO = null, 
			string m3NHAI = null, 
			string m3NHSN = null, 
			string m3AECN = null, 
			int? m3DEID = null, 
			decimal? m3MVA1 = null, 
			decimal? m3MVA2 = null, 
			decimal? m3MVA3 = null, 
			decimal? m3MVA4 = null, 
			decimal? m3MVB1 = null, 
			decimal? m3MVB2 = null, 
			decimal? m3MVB3 = null, 
			decimal? m3MVB4 = null, 
			string m3MES1 = null, 
			string m3MES2 = null, 
			string m3MES3 = null, 
			string m3MES4 = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3PRNS = null, 
			string m3CFGH = null, 
			string m3CFGL = null, 
			string m3CFI1 = null, 
			decimal? m3CFI2 = null, 
			string m3CFI3 = null, 
			string m3CFI4 = null, 
			string m3CFI5 = null, 
			string m3AGNB = null, 
			string m3MPRN = null, 
			string m3MSTR = null, 
			string m3MSUF = null, 
			string m3ACTP = null, 
			string m3EXNO = null, 
			string m3PSTS = null, 
			int? m3METE = null, 
			DateTime? m3OPED = null, 
			DateTime? m3ETD1 = null, 
			DateTime? m3ETD2 = null, 
			int? m3BLTA = null, 
			int? m3FSER = null, 
			int? m3RORX = null, 
			decimal? m3ATNR = null, 
			string m3GRMT = null, 
			string m3IRCV = null, 
			int? m3PTCD = null, 
			int? m3REPP = null, 
			string m3ORAD = null, 
			string m3PURC = null, 
			string m3ACRF = null, 
			int? m3PLPN = null, 
			string m3COCE = null, 
			string m3PF20 = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3RESP))
				throw new ArgumentNullException(nameof(m3RESP));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PPQT", m3PPQT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RESP", m3RESP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRCS))
				request.WithQueryParameter("PRCS", m3PRCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3PLDT.HasValue)
				request.WithQueryParameter("PLDT", m3PLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3BUYE))
				request.WithQueryParameter("BUYE", m3BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFID))
				request.WithQueryParameter("RFID", m3RFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SITE))
				request.WithQueryParameter("SITE", m3SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3PITD))
				request.WithQueryParameter("PITD", m3PITD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PITT))
				request.WithQueryParameter("PITT", m3PITT.Trim());
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PPUN))
				request.WithQueryParameter("PPUN", m3PPUN.Trim());
			if (m3PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3PUCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ODI1.HasValue)
				request.WithQueryParameter("ODI1", m3ODI1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ODI2.HasValue)
				request.WithQueryParameter("ODI2", m3ODI2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ODI3.HasValue)
				request.WithQueryParameter("ODI3", m3ODI3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TEOR.HasValue)
				request.WithQueryParameter("TEOR", m3TEOR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PTXT))
				request.WithQueryParameter("PTXT", m3PTXT.Trim());
			if (!string.IsNullOrWhiteSpace(m3YRE3))
				request.WithQueryParameter("YRE3", m3YRE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OUR1))
				request.WithQueryParameter("OUR1", m3OUR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3NHAI))
				request.WithQueryParameter("NHAI", m3NHAI.Trim());
			if (!string.IsNullOrWhiteSpace(m3NHSN))
				request.WithQueryParameter("NHSN", m3NHSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3AECN))
				request.WithQueryParameter("AECN", m3AECN.Trim());
			if (m3DEID.HasValue)
				request.WithQueryParameter("DEID", m3DEID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVA1.HasValue)
				request.WithQueryParameter("MVA1", m3MVA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVA2.HasValue)
				request.WithQueryParameter("MVA2", m3MVA2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVA3.HasValue)
				request.WithQueryParameter("MVA3", m3MVA3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVA4.HasValue)
				request.WithQueryParameter("MVA4", m3MVA4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVB1.HasValue)
				request.WithQueryParameter("MVB1", m3MVB1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVB2.HasValue)
				request.WithQueryParameter("MVB2", m3MVB2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVB3.HasValue)
				request.WithQueryParameter("MVB3", m3MVB3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVB4.HasValue)
				request.WithQueryParameter("MVB4", m3MVB4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MES1))
				request.WithQueryParameter("MES1", m3MES1.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES2))
				request.WithQueryParameter("MES2", m3MES2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES3))
				request.WithQueryParameter("MES3", m3MES3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES4))
				request.WithQueryParameter("MES4", m3MES4.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNS))
				request.WithQueryParameter("PRNS", m3PRNS.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGH))
				request.WithQueryParameter("CFGH", m3CFGH.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI1))
				request.WithQueryParameter("CFI1", m3CFI1.Trim());
			if (m3CFI2.HasValue)
				request.WithQueryParameter("CFI2", m3CFI2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFI3))
				request.WithQueryParameter("CFI3", m3CFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI4))
				request.WithQueryParameter("CFI4", m3CFI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI5))
				request.WithQueryParameter("CFI5", m3CFI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3MPRN))
				request.WithQueryParameter("MPRN", m3MPRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSTR))
				request.WithQueryParameter("MSTR", m3MSTR.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSUF))
				request.WithQueryParameter("MSUF", m3MSUF.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACTP))
				request.WithQueryParameter("ACTP", m3ACTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXNO))
				request.WithQueryParameter("EXNO", m3EXNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PSTS))
				request.WithQueryParameter("PSTS", m3PSTS.Trim());
			if (m3METE.HasValue)
				request.WithQueryParameter("METE", m3METE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPED.HasValue)
				request.WithQueryParameter("OPED", m3OPED.Value.ToM3String());
			if (m3ETD1.HasValue)
				request.WithQueryParameter("ETD1", m3ETD1.Value.ToM3String());
			if (m3ETD2.HasValue)
				request.WithQueryParameter("ETD2", m3ETD2.Value.ToM3String());
			if (m3BLTA.HasValue)
				request.WithQueryParameter("BLTA", m3BLTA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FSER.HasValue)
				request.WithQueryParameter("FSER", m3FSER.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3GRMT))
				request.WithQueryParameter("GRMT", m3GRMT.Trim());
			if (!string.IsNullOrWhiteSpace(m3IRCV))
				request.WithQueryParameter("IRCV", m3IRCV.Trim());
			if (m3PTCD.HasValue)
				request.WithQueryParameter("PTCD", m3PTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REPP.HasValue)
				request.WithQueryParameter("REPP", m3REPP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORAD))
				request.WithQueryParameter("ORAD", m3ORAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PURC))
				request.WithQueryParameter("PURC", m3PURC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (m3PLPN.HasValue)
				request.WithQueryParameter("PLPN", m3PLPN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3COCE))
				request.WithQueryParameter("COCE", m3COCE.Trim());
			if (!string.IsNullOrWhiteSpace(m3PF20))
				request.WithQueryParameter("PF20", m3PF20.Trim());

			// Execute the request
			var result = await Execute<AddPoReqResponse>(
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
		/// Name UpdCostOnWoMat
		/// Description Update cost and sts on wo material
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3MSEQ">Sequence number (Required)</param>
		/// <param name="m3WMST">Material status (Required)</param>
		/// <param name="m3MPRC">Component price</param>
		/// <param name="m3RFTX">Reference text</param>
		/// <param name="m3CLOP">Yes/no - close operation</param>
		/// <param name="m3ALQT">Allocated quantity - basic U/M</param>
		/// <param name="m3RVQT">Received quantity</param>
		/// <param name="m3RPQT">Reported quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdCostOnWoMat(
			string m3MWNO, 
			int m3MSEQ, 
			string m3WMST, 
			decimal? m3MPRC = null, 
			string m3RFTX = null, 
			int? m3CLOP = null, 
			decimal? m3ALQT = null, 
			decimal? m3RVQT = null, 
			decimal? m3RPQT = null, 
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
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));
			if (string.IsNullOrWhiteSpace(m3WMST))
				throw new ArgumentNullException(nameof(m3WMST));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("MSEQ", m3MSEQ.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("WMST", m3WMST.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3MPRC.HasValue)
				request.WithQueryParameter("MPRC", m3MPRC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RFTX))
				request.WithQueryParameter("RFTX", m3RFTX.Trim());
			if (m3CLOP.HasValue)
				request.WithQueryParameter("CLOP", m3CLOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALQT.HasValue)
				request.WithQueryParameter("ALQT", m3ALQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RVQT.HasValue)
				request.WithQueryParameter("RVQT", m3RVQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPQT.HasValue)
				request.WithQueryParameter("RPQT", m3RPQT.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdPoLine
		/// Description Update Po line with info from external system
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PUNO">Purchase order number (Required)</param>
		/// <param name="m3PNLI">Purchase order line (Required)</param>
		/// <param name="m3PNLS">Purchase order line subnumber</param>
		/// <param name="m3SORN">Supplier order number</param>
		/// <param name="m3OURR">Our reference number</param>
		/// <param name="m3ECF1">User-defined TST field 1</param>
		/// <param name="m3ECF2">User-defined TST field 2</param>
		/// <param name="m3ECF3">User-defined TST field 3</param>
		/// <param name="m3ECF4">User-defined TST field  4</param>
		/// <param name="m3ECF5">User-defined TST field 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPoLine(
			string m3PUNO, 
			int m3PNLI, 
			int? m3PNLS = null, 
			string m3SORN = null, 
			string m3OURR = null, 
			string m3ECF1 = null, 
			string m3ECF2 = null, 
			string m3ECF3 = null, 
			string m3ECF4 = null, 
			string m3ECF5 = null, 
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
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim())
				.WithQueryParameter("PNLI", m3PNLI.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3PNLS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SORN))
				request.WithQueryParameter("SORN", m3SORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3OURR))
				request.WithQueryParameter("OURR", m3OURR.Trim());
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
