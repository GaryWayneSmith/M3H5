/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Order line number (Required)</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3PYAG">Payer agreement</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Dlt(
			string m3ORNO, 
			int m3PONR, 
			string m3PYNO = null, 
			string m3PYAG = null, 
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
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYAG))
				request.WithQueryParameter("PYAG", m3PYAG.Trim());

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
		/// Name Get
		/// Description Get
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Order line number (Required)</param>
		/// <param name="m3PYNO">Payer (Required)</param>
		/// <param name="m3PYAG">Payer agreement (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3ORNO, 
			int m3PONR, 
			string m3PYNO, 
			string m3PYAG, 
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
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3PYNO))
				throw new ArgumentNullException(nameof(m3PYNO));
			if (string.IsNullOrWhiteSpace(m3PYAG))
				throw new ArgumentNullException(nameof(m3PYAG));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYNO", m3PYNO.Trim())
				.WithQueryParameter("PYAG", m3PYAG.Trim());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name Lst
		/// Description List
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Order line number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3ORNO, 
			int? m3PONR = null, 
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
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstResponse>(
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
		/// Name Upd
		/// Description Upd
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Order line number (Required)</param>
		/// <param name="m3PYNO">Payer (Required)</param>
		/// <param name="m3PYAG">Payer agreement (Required)</param>
		/// <param name="m3TIAM">Labor</param>
		/// <param name="m3MAA1">Material</param>
		/// <param name="m3SUAM">Subcontract</param>
		/// <param name="m3MIA1">Miscellaneous</param>
		/// <param name="m3LOA3">Loan</param>
		/// <param name="m3TIP1">Labor %</param>
		/// <param name="m3MAP1">Material %</param>
		/// <param name="m3SUP1">Subcontract %</param>
		/// <param name="m3MIP1">Miscellaneous %</param>
		/// <param name="m3LOP1">Loan percent</param>
		/// <param name="m3ASBO">Service bill of material</param>
		/// <param name="m3ACWA">Claim warranty</param>
		/// <param name="m3WPRN">Product service BoM</param>
		/// <param name="m3WSTR">Structure type service bill of material</param>
		/// <param name="m3WSUF">Service bill of material</param>
		/// <param name="m3YEA4">Year</param>
		/// <param name="m3IVNO">Invoice number</param>
		/// <param name="m3IVDT">Invoice date</param>
		/// <param name="m3AOST">Highest status</param>
		/// <param name="m3VTCD">VAT code</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3TXAP">Tax applicable</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3PREY">Previous invoice year</param>
		/// <param name="m3TIA7">Labor Warranty split</param>
		/// <param name="m3MAA7">Material Warranty split</param>
		/// <param name="m3SUA7">Subcontract Warranty split</param>
		/// <param name="m3MIA7">Misc amount</param>
		/// <param name="m3LOA7">Loan amount</param>
		/// <param name="m3TIP7">Labor discount</param>
		/// <param name="m3MAP7">Material discount</param>
		/// <param name="m3MIP7">Misc discount</param>
		/// <param name="m3LPO7">Loan discount</param>
		/// <param name="m3APAC">Fixed amount</param>
		/// <param name="m3PYCL">Payment class</param>
		/// <param name="m3CLAG">Agreement Claim</param>
		/// <param name="m3CLNO">Claim</param>
		/// <param name="m3INPX">Invoice prefix</param>
		/// <param name="m3EXIN">Extended invoice number</param>
		/// <param name="m3PINP">Previous invoice prefix</param>
		/// <param name="m3PXIN">Previous extended invoice number</param>
		/// <param name="m3TIP3">Labor split %</param>
		/// <param name="m3MAP3">Material split %</param>
		/// <param name="m3SUP3">Subcontract split %</param>
		/// <param name="m3MIP3">New field description</param>
		/// <param name="m3LOP3">Loan split %</param>
		/// <param name="m3SRVP">Service price method</param>
		/// <param name="m3ORSP">Split origin</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3ORNO, 
			int m3PONR, 
			string m3PYNO, 
			string m3PYAG, 
			decimal? m3TIAM = null, 
			decimal? m3MAA1 = null, 
			decimal? m3SUAM = null, 
			decimal? m3MIA1 = null, 
			decimal? m3LOA3 = null, 
			int? m3TIP1 = null, 
			int? m3MAP1 = null, 
			int? m3SUP1 = null, 
			int? m3MIP1 = null, 
			int? m3LOP1 = null, 
			int? m3ASBO = null, 
			int? m3ACWA = null, 
			string m3WPRN = null, 
			string m3WSTR = null, 
			string m3WSUF = null, 
			int? m3YEA4 = null, 
			int? m3IVNO = null, 
			DateTime? m3IVDT = null, 
			string m3AOST = null, 
			int? m3VTCD = null, 
			string m3TEPY = null, 
			int? m3TXAP = null, 
			decimal? m3TXID = null, 
			int? m3PREY = null, 
			decimal? m3TIA7 = null, 
			decimal? m3MAA7 = null, 
			decimal? m3SUA7 = null, 
			decimal? m3MIA7 = null, 
			string m3LOA7 = null, 
			int? m3TIP7 = null, 
			int? m3MAP7 = null, 
			int? m3MIP7 = null, 
			int? m3LPO7 = null, 
			int? m3APAC = null, 
			int? m3PYCL = null, 
			string m3CLAG = null, 
			string m3CLNO = null, 
			string m3INPX = null, 
			string m3EXIN = null, 
			string m3PINP = null, 
			string m3PXIN = null, 
			int? m3TIP3 = null, 
			int? m3MAP3 = null, 
			int? m3SUP3 = null, 
			int? m3MIP3 = null, 
			int? m3LOP3 = null, 
			int? m3SRVP = null, 
			int? m3ORSP = null, 
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
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3PYNO))
				throw new ArgumentNullException(nameof(m3PYNO));
			if (string.IsNullOrWhiteSpace(m3PYAG))
				throw new ArgumentNullException(nameof(m3PYAG));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYNO", m3PYNO.Trim())
				.WithQueryParameter("PYAG", m3PYAG.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3TIAM.HasValue)
				request.WithQueryParameter("TIAM", m3TIAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MAA1.HasValue)
				request.WithQueryParameter("MAA1", m3MAA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUAM.HasValue)
				request.WithQueryParameter("SUAM", m3SUAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MIA1.HasValue)
				request.WithQueryParameter("MIA1", m3MIA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LOA3.HasValue)
				request.WithQueryParameter("LOA3", m3LOA3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TIP1.HasValue)
				request.WithQueryParameter("TIP1", m3TIP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MAP1.HasValue)
				request.WithQueryParameter("MAP1", m3MAP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUP1.HasValue)
				request.WithQueryParameter("SUP1", m3SUP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MIP1.HasValue)
				request.WithQueryParameter("MIP1", m3MIP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LOP1.HasValue)
				request.WithQueryParameter("LOP1", m3LOP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ASBO.HasValue)
				request.WithQueryParameter("ASBO", m3ASBO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACWA.HasValue)
				request.WithQueryParameter("ACWA", m3ACWA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WPRN))
				request.WithQueryParameter("WPRN", m3WPRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3WSTR))
				request.WithQueryParameter("WSTR", m3WSTR.Trim());
			if (!string.IsNullOrWhiteSpace(m3WSUF))
				request.WithQueryParameter("WSUF", m3WSUF.Trim());
			if (m3YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3YEA4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IVNO.HasValue)
				request.WithQueryParameter("IVNO", m3IVNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IVDT.HasValue)
				request.WithQueryParameter("IVDT", m3IVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3AOST))
				request.WithQueryParameter("AOST", m3AOST.Trim());
			if (m3VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3VTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (m3TXAP.HasValue)
				request.WithQueryParameter("TXAP", m3TXAP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PREY.HasValue)
				request.WithQueryParameter("PREY", m3PREY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TIA7.HasValue)
				request.WithQueryParameter("TIA7", m3TIA7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MAA7.HasValue)
				request.WithQueryParameter("MAA7", m3MAA7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUA7.HasValue)
				request.WithQueryParameter("SUA7", m3SUA7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MIA7.HasValue)
				request.WithQueryParameter("MIA7", m3MIA7.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LOA7))
				request.WithQueryParameter("LOA7", m3LOA7.Trim());
			if (m3TIP7.HasValue)
				request.WithQueryParameter("TIP7", m3TIP7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MAP7.HasValue)
				request.WithQueryParameter("MAP7", m3MAP7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MIP7.HasValue)
				request.WithQueryParameter("MIP7", m3MIP7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LPO7.HasValue)
				request.WithQueryParameter("LPO7", m3LPO7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3APAC.HasValue)
				request.WithQueryParameter("APAC", m3APAC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PYCL.HasValue)
				request.WithQueryParameter("PYCL", m3PYCL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CLAG))
				request.WithQueryParameter("CLAG", m3CLAG.Trim());
			if (!string.IsNullOrWhiteSpace(m3CLNO))
				request.WithQueryParameter("CLNO", m3CLNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3INPX))
				request.WithQueryParameter("INPX", m3INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXIN))
				request.WithQueryParameter("EXIN", m3EXIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PINP))
				request.WithQueryParameter("PINP", m3PINP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PXIN))
				request.WithQueryParameter("PXIN", m3PXIN.Trim());
			if (m3TIP3.HasValue)
				request.WithQueryParameter("TIP3", m3TIP3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MAP3.HasValue)
				request.WithQueryParameter("MAP3", m3MAP3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUP3.HasValue)
				request.WithQueryParameter("SUP3", m3SUP3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MIP3.HasValue)
				request.WithQueryParameter("MIP3", m3MIP3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LOP3.HasValue)
				request.WithQueryParameter("LOP3", m3LOP3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SRVP.HasValue)
				request.WithQueryParameter("SRVP", m3SRVP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORSP.HasValue)
				request.WithQueryParameter("ORSP", m3ORSP.Value.ToString(CultureInfo.CurrentCulture));

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
