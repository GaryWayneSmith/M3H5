/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.ARS040MI;
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
	/// Name: ARS040MI
	/// Component Name: CustomerPayment
	/// Description: Customer payment interface
	/// Version Release: 14.x
	///</summary>
	public partial class ARS040MIResource : M3BaseResourceEndpoint
	{
		public ARS040MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "ARS040MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddBatchCharge
		/// Description Create new batch payment charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PBID">Payment batch (Required)</param>
		/// <param name="m3_CHAM">Charge amount (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_CHRI">Charge</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_ARAT">Exchange rate</param>
		/// <param name="m3_VTCD">VAT code</param>
		/// <param name="m3_VTAM">VAT</param>
		/// <param name="m3_BVTM">VAT calculation amount</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBatchCharge(
			long m3_PBID, 
			decimal m3_CHAM, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_CHRI = null, 
			string m3_CUCD = null, 
			decimal? m3_ARAT = null, 
			int? m3_VTCD = null, 
			decimal? m3_VTAM = null, 
			decimal? m3_BVTM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBatchCharge",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PBID", m3_PBID.ToString())
				.WithQueryParameter("CHAM", m3_CHAM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHRI))
				request.WithQueryParameter("CHRI", m3_CHRI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3_ARAT.Value.ToString());
			if (m3_VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3_VTCD.Value.ToString());
			if (m3_VTAM.HasValue)
				request.WithQueryParameter("VTAM", m3_VTAM.Value.ToString());
			if (m3_BVTM.HasValue)
				request.WithQueryParameter("BVTM", m3_BVTM.Value.ToString());

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
		/// Name AddBatchHead
		/// Description Create new batch payment head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PBID">Payment batch (Required)</param>
		/// <param name="m3_BOPE">Batch payment type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_BAAN">Bank account number</param>
		/// <param name="m3_NADO">Foreign/domestic</param>
		/// <param name="m3_VONO">Voucher number</param>
		/// <param name="m3_ACDT">Accounting date</param>
		/// <param name="m3_BPYS">Status - batch payments</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddBatchHeadResponse></returns>
		/// <exception cref="M3Exception<AddBatchHeadResponse>"></exception>
		public async Task<M3Response<AddBatchHeadResponse>> AddBatchHead(
			long m3_PBID, 
			string m3_BOPE, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_BAAN = null, 
			string m3_NADO = null, 
			int? m3_VONO = null, 
			DateTime? m3_ACDT = null, 
			int? m3_BPYS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBatchHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BOPE))
				throw new ArgumentNullException("m3_BOPE");

			// Set mandatory parameters
			request
				.WithQueryParameter("PBID", m3_PBID.ToString())
				.WithQueryParameter("BOPE", m3_BOPE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAAN))
				request.WithQueryParameter("BAAN", m3_BAAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NADO))
				request.WithQueryParameter("NADO", m3_NADO.Trim());
			if (m3_VONO.HasValue)
				request.WithQueryParameter("VONO", m3_VONO.Value.ToString());
			if (m3_ACDT.HasValue)
				request.WithQueryParameter("ACDT", m3_ACDT.Value.ToM3String());
			if (m3_BPYS.HasValue)
				request.WithQueryParameter("BPYS", m3_BPYS.Value.ToString());

			// Execute the request
			var result = await Execute<AddBatchHeadResponse>(
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
		/// Name AddBatchLine
		/// Description Create new batch payment line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PBID">Payment batch (Required)</param>
		/// <param name="m3_TRNO">Transaction number (Required)</param>
		/// <param name="m3_CINO">Invoice number (Required)</param>
		/// <param name="m3_INYR">Invoice year (Required)</param>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_PYAM">Payment amount (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_PYTP">Payment type</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_ARAT">Exchange rate</param>
		/// <param name="m3_LPDT">Payment date</param>
		/// <param name="m3_NBCM">Foreign currency amount</param>
		/// <param name="m3_ORAT">Original exchange rate</param>
		/// <param name="m3_NBAM">Recorded amount</param>
		/// <param name="m3_ADAM">Foreign currency amount</param>
		/// <param name="m3_ACDA">Foreign currency amount</param>
		/// <param name="m3_CDDT">Cash discount date</param>
		/// <param name="m3_CKNO">Check number</param>
		/// <param name="m3_AIT1">Accounting dimension 1</param>
		/// <param name="m3_AIT2">Accounting dimension 2</param>
		/// <param name="m3_AIT3">Accounting dimension 3</param>
		/// <param name="m3_AIT4">Accounting dimension 4</param>
		/// <param name="m3_AIT5">Accounting dimension 5</param>
		/// <param name="m3_AIT6">Accounting dimension 6</param>
		/// <param name="m3_AIT7">Accounting dimension 7</param>
		/// <param name="m3_CKST">Allocation status</param>
		/// <param name="m3_IRNO">Invoice reference number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBatchLine(
			long m3_PBID, 
			int m3_TRNO, 
			string m3_CINO, 
			int m3_INYR, 
			string m3_CUNO, 
			decimal m3_PYAM, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_PYNO = null, 
			string m3_PYTP = null, 
			string m3_CUCD = null, 
			decimal? m3_ARAT = null, 
			DateTime? m3_LPDT = null, 
			decimal? m3_NBCM = null, 
			decimal? m3_ORAT = null, 
			decimal? m3_NBAM = null, 
			decimal? m3_ADAM = null, 
			decimal? m3_ACDA = null, 
			DateTime? m3_CDDT = null, 
			string m3_CKNO = null, 
			string m3_AIT1 = null, 
			string m3_AIT2 = null, 
			string m3_AIT3 = null, 
			string m3_AIT4 = null, 
			string m3_AIT5 = null, 
			string m3_AIT6 = null, 
			string m3_AIT7 = null, 
			string m3_CKST = null, 
			string m3_IRNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBatchLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CINO))
				throw new ArgumentNullException("m3_CINO");
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PBID", m3_PBID.ToString())
				.WithQueryParameter("TRNO", m3_TRNO.ToString())
				.WithQueryParameter("CINO", m3_CINO.Trim())
				.WithQueryParameter("INYR", m3_INYR.ToString())
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("PYAM", m3_PYAM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYTP))
				request.WithQueryParameter("PYTP", m3_PYTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3_ARAT.Value.ToString());
			if (m3_LPDT.HasValue)
				request.WithQueryParameter("LPDT", m3_LPDT.Value.ToM3String());
			if (m3_NBCM.HasValue)
				request.WithQueryParameter("NBCM", m3_NBCM.Value.ToString());
			if (m3_ORAT.HasValue)
				request.WithQueryParameter("ORAT", m3_ORAT.Value.ToString());
			if (m3_NBAM.HasValue)
				request.WithQueryParameter("NBAM", m3_NBAM.Value.ToString());
			if (m3_ADAM.HasValue)
				request.WithQueryParameter("ADAM", m3_ADAM.Value.ToString());
			if (m3_ACDA.HasValue)
				request.WithQueryParameter("ACDA", m3_ACDA.Value.ToString());
			if (m3_CDDT.HasValue)
				request.WithQueryParameter("CDDT", m3_CDDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CKNO))
				request.WithQueryParameter("CKNO", m3_CKNO.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_CKST))
				request.WithQueryParameter("CKST", m3_CKST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IRNO))
				request.WithQueryParameter("IRNO", m3_IRNO.Trim());

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
		/// Name ControlBatch
		/// Description Control Batch
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_PBID">Payment batch</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ControlBatch(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			long? m3_PBID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ControlBatch",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_PBID.HasValue)
				request.WithQueryParameter("PBID", m3_PBID.Value.ToString());

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
