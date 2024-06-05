/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.COS117MI;
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
	/// Name: COS117MI
	/// Component Name: Split Payer MCO
	/// Description: Split Payer MCO  interface
	/// Version Release: 5ea1
	///</summary>
	public partial class COS117MIResource : M3BaseResourceEndpoint
	{
		public COS117MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "COS117MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Dlt
		/// Description Delete
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Order line number (Required)</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_PYAG">Payer agreement</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Dlt(
			string m3_ORNO, 
			int m3_PONR, 
			string m3_PYNO = null, 
			string m3_PYAG = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Dlt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYAG))
				request.WithQueryParameter("PYAG", m3_PYAG.Trim());

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
		/// Name Get
		/// Description Get
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Order line number (Required)</param>
		/// <param name="m3_PYNO">Payer (Required)</param>
		/// <param name="m3_PYAG">Payer agreement (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_ORNO, 
			int m3_PONR, 
			string m3_PYNO, 
			string m3_PYAG, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_PYNO))
				throw new ArgumentNullException("m3_PYNO");
			if (string.IsNullOrWhiteSpace(m3_PYAG))
				throw new ArgumentNullException("m3_PYAG");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("PYNO", m3_PYNO.Trim())
				.WithQueryParameter("PYAG", m3_PYAG.Trim());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name Lst
		/// Description List
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Order line number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3_ORNO, 
			int? m3_PONR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Lst",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());

			// Execute the request
			var result = await Execute<LstResponse>(
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
		/// Name Upd
		/// Description Upd
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Order line number (Required)</param>
		/// <param name="m3_PYNO">Payer (Required)</param>
		/// <param name="m3_PYAG">Payer agreement (Required)</param>
		/// <param name="m3_TIAM">Labor</param>
		/// <param name="m3_MAA1">Material</param>
		/// <param name="m3_SUAM">Subcontract</param>
		/// <param name="m3_MIA1">Miscellaneous</param>
		/// <param name="m3_LOA3">Loan</param>
		/// <param name="m3_TIP1">Labor %</param>
		/// <param name="m3_MAP1">Material %</param>
		/// <param name="m3_SUP1">Subcontract %</param>
		/// <param name="m3_MIP1">Miscellaneous %</param>
		/// <param name="m3_LOP1">Loan percent</param>
		/// <param name="m3_ASBO">Service bill of material</param>
		/// <param name="m3_ACWA">Claim warranty</param>
		/// <param name="m3_WPRN">Product service BoM</param>
		/// <param name="m3_WSTR">Structure type service bill of material</param>
		/// <param name="m3_WSUF">Service bill of material</param>
		/// <param name="m3_YEA4">Year</param>
		/// <param name="m3_IVNO">Invoice number</param>
		/// <param name="m3_IVDT">Invoice date</param>
		/// <param name="m3_AOST">Highest status</param>
		/// <param name="m3_VTCD">VAT code</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_TXAP">Tax applicable</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_PREY">Previous invoice year</param>
		/// <param name="m3_TIA7">Labor Warranty split</param>
		/// <param name="m3_MAA7">Material Warranty split</param>
		/// <param name="m3_SUA7">Subcontract Warranty split</param>
		/// <param name="m3_MIA7">Misc amount</param>
		/// <param name="m3_LOA7">Loan amount</param>
		/// <param name="m3_TIP7">Labor discount</param>
		/// <param name="m3_MAP7">Material discount</param>
		/// <param name="m3_MIP7">Misc discount</param>
		/// <param name="m3_LPO7">Loan discount</param>
		/// <param name="m3_APAC">Fixed amount</param>
		/// <param name="m3_PYCL">Payment class</param>
		/// <param name="m3_CLAG">Agreement Claim</param>
		/// <param name="m3_CLNO">Claim</param>
		/// <param name="m3_INPX">Invoice prefix</param>
		/// <param name="m3_EXIN">Extended invoice number</param>
		/// <param name="m3_PINP">Previous invoice prefix</param>
		/// <param name="m3_PXIN">Previous extended invoice number</param>
		/// <param name="m3_TIP3">Labor split %</param>
		/// <param name="m3_MAP3">Material split %</param>
		/// <param name="m3_SUP3">Subcontract split %</param>
		/// <param name="m3_MIP3">New field description</param>
		/// <param name="m3_LOP3">Loan split %</param>
		/// <param name="m3_SRVP">Service price method</param>
		/// <param name="m3_ORSP">Split origin</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3_ORNO, 
			int m3_PONR, 
			string m3_PYNO, 
			string m3_PYAG, 
			decimal? m3_TIAM = null, 
			decimal? m3_MAA1 = null, 
			decimal? m3_SUAM = null, 
			decimal? m3_MIA1 = null, 
			decimal? m3_LOA3 = null, 
			int? m3_TIP1 = null, 
			int? m3_MAP1 = null, 
			int? m3_SUP1 = null, 
			int? m3_MIP1 = null, 
			int? m3_LOP1 = null, 
			int? m3_ASBO = null, 
			int? m3_ACWA = null, 
			string m3_WPRN = null, 
			string m3_WSTR = null, 
			string m3_WSUF = null, 
			int? m3_YEA4 = null, 
			int? m3_IVNO = null, 
			DateTime? m3_IVDT = null, 
			string m3_AOST = null, 
			int? m3_VTCD = null, 
			string m3_TEPY = null, 
			int? m3_TXAP = null, 
			decimal? m3_TXID = null, 
			int? m3_PREY = null, 
			decimal? m3_TIA7 = null, 
			decimal? m3_MAA7 = null, 
			decimal? m3_SUA7 = null, 
			decimal? m3_MIA7 = null, 
			string m3_LOA7 = null, 
			int? m3_TIP7 = null, 
			int? m3_MAP7 = null, 
			int? m3_MIP7 = null, 
			int? m3_LPO7 = null, 
			int? m3_APAC = null, 
			int? m3_PYCL = null, 
			string m3_CLAG = null, 
			string m3_CLNO = null, 
			string m3_INPX = null, 
			string m3_EXIN = null, 
			string m3_PINP = null, 
			string m3_PXIN = null, 
			int? m3_TIP3 = null, 
			int? m3_MAP3 = null, 
			int? m3_SUP3 = null, 
			int? m3_MIP3 = null, 
			int? m3_LOP3 = null, 
			int? m3_SRVP = null, 
			int? m3_ORSP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Upd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_PYNO))
				throw new ArgumentNullException("m3_PYNO");
			if (string.IsNullOrWhiteSpace(m3_PYAG))
				throw new ArgumentNullException("m3_PYAG");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("PYNO", m3_PYNO.Trim())
				.WithQueryParameter("PYAG", m3_PYAG.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_TIAM.HasValue)
				request.WithQueryParameter("TIAM", m3_TIAM.Value.ToString());
			if (m3_MAA1.HasValue)
				request.WithQueryParameter("MAA1", m3_MAA1.Value.ToString());
			if (m3_SUAM.HasValue)
				request.WithQueryParameter("SUAM", m3_SUAM.Value.ToString());
			if (m3_MIA1.HasValue)
				request.WithQueryParameter("MIA1", m3_MIA1.Value.ToString());
			if (m3_LOA3.HasValue)
				request.WithQueryParameter("LOA3", m3_LOA3.Value.ToString());
			if (m3_TIP1.HasValue)
				request.WithQueryParameter("TIP1", m3_TIP1.Value.ToString());
			if (m3_MAP1.HasValue)
				request.WithQueryParameter("MAP1", m3_MAP1.Value.ToString());
			if (m3_SUP1.HasValue)
				request.WithQueryParameter("SUP1", m3_SUP1.Value.ToString());
			if (m3_MIP1.HasValue)
				request.WithQueryParameter("MIP1", m3_MIP1.Value.ToString());
			if (m3_LOP1.HasValue)
				request.WithQueryParameter("LOP1", m3_LOP1.Value.ToString());
			if (m3_ASBO.HasValue)
				request.WithQueryParameter("ASBO", m3_ASBO.Value.ToString());
			if (m3_ACWA.HasValue)
				request.WithQueryParameter("ACWA", m3_ACWA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WPRN))
				request.WithQueryParameter("WPRN", m3_WPRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WSTR))
				request.WithQueryParameter("WSTR", m3_WSTR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WSUF))
				request.WithQueryParameter("WSUF", m3_WSUF.Trim());
			if (m3_YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3_YEA4.Value.ToString());
			if (m3_IVNO.HasValue)
				request.WithQueryParameter("IVNO", m3_IVNO.Value.ToString());
			if (m3_IVDT.HasValue)
				request.WithQueryParameter("IVDT", m3_IVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_AOST))
				request.WithQueryParameter("AOST", m3_AOST.Trim());
			if (m3_VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3_VTCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (m3_TXAP.HasValue)
				request.WithQueryParameter("TXAP", m3_TXAP.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_PREY.HasValue)
				request.WithQueryParameter("PREY", m3_PREY.Value.ToString());
			if (m3_TIA7.HasValue)
				request.WithQueryParameter("TIA7", m3_TIA7.Value.ToString());
			if (m3_MAA7.HasValue)
				request.WithQueryParameter("MAA7", m3_MAA7.Value.ToString());
			if (m3_SUA7.HasValue)
				request.WithQueryParameter("SUA7", m3_SUA7.Value.ToString());
			if (m3_MIA7.HasValue)
				request.WithQueryParameter("MIA7", m3_MIA7.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LOA7))
				request.WithQueryParameter("LOA7", m3_LOA7.Trim());
			if (m3_TIP7.HasValue)
				request.WithQueryParameter("TIP7", m3_TIP7.Value.ToString());
			if (m3_MAP7.HasValue)
				request.WithQueryParameter("MAP7", m3_MAP7.Value.ToString());
			if (m3_MIP7.HasValue)
				request.WithQueryParameter("MIP7", m3_MIP7.Value.ToString());
			if (m3_LPO7.HasValue)
				request.WithQueryParameter("LPO7", m3_LPO7.Value.ToString());
			if (m3_APAC.HasValue)
				request.WithQueryParameter("APAC", m3_APAC.Value.ToString());
			if (m3_PYCL.HasValue)
				request.WithQueryParameter("PYCL", m3_PYCL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CLAG))
				request.WithQueryParameter("CLAG", m3_CLAG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CLNO))
				request.WithQueryParameter("CLNO", m3_CLNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INPX))
				request.WithQueryParameter("INPX", m3_INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXIN))
				request.WithQueryParameter("EXIN", m3_EXIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PINP))
				request.WithQueryParameter("PINP", m3_PINP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PXIN))
				request.WithQueryParameter("PXIN", m3_PXIN.Trim());
			if (m3_TIP3.HasValue)
				request.WithQueryParameter("TIP3", m3_TIP3.Value.ToString());
			if (m3_MAP3.HasValue)
				request.WithQueryParameter("MAP3", m3_MAP3.Value.ToString());
			if (m3_SUP3.HasValue)
				request.WithQueryParameter("SUP3", m3_SUP3.Value.ToString());
			if (m3_MIP3.HasValue)
				request.WithQueryParameter("MIP3", m3_MIP3.Value.ToString());
			if (m3_LOP3.HasValue)
				request.WithQueryParameter("LOP3", m3_LOP3.Value.ToString());
			if (m3_SRVP.HasValue)
				request.WithQueryParameter("SRVP", m3_SRVP.Value.ToString());
			if (m3_ORSP.HasValue)
				request.WithQueryParameter("ORSP", m3_ORSP.Value.ToString());

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
