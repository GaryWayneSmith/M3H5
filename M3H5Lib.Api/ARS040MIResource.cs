/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3PBID">Payment batch (Required)</param>
		/// <param name="m3CHAM">Charge amount (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3CHRI">Charge</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3ARAT">Exchange rate</param>
		/// <param name="m3VTCD">VAT code</param>
		/// <param name="m3VTAM">VAT</param>
		/// <param name="m3BVTM">VAT calculation amount</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBatchCharge(
			long m3PBID, 
			decimal m3CHAM, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3CHRI = null, 
			string m3CUCD = null, 
			decimal? m3ARAT = null, 
			int? m3VTCD = null, 
			decimal? m3VTAM = null, 
			decimal? m3BVTM = null, 
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
				.WithQueryParameter("PBID", m3PBID.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CHAM", m3CHAM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHRI))
				request.WithQueryParameter("CHRI", m3CHRI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3ARAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3VTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTAM.HasValue)
				request.WithQueryParameter("VTAM", m3VTAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BVTM.HasValue)
				request.WithQueryParameter("BVTM", m3BVTM.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddBatchHead
		/// Description Create new batch payment head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PBID">Payment batch (Required)</param>
		/// <param name="m3BOPE">Batch payment type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3BAAN">Bank account number</param>
		/// <param name="m3NADO">Foreign/domestic</param>
		/// <param name="m3VONO">Voucher number</param>
		/// <param name="m3ACDT">Accounting date</param>
		/// <param name="m3BPYS">Status - batch payments</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddBatchHeadResponse></returns>
		/// <exception cref="M3Exception<AddBatchHeadResponse>"></exception>
		public async Task<M3Response<AddBatchHeadResponse>> AddBatchHead(
			long m3PBID, 
			string m3BOPE, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3BAAN = null, 
			string m3NADO = null, 
			int? m3VONO = null, 
			DateTime? m3ACDT = null, 
			int? m3BPYS = null, 
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
			if (string.IsNullOrWhiteSpace(m3BOPE))
				throw new ArgumentNullException(nameof(m3BOPE));

			// Set mandatory parameters
			request
				.WithQueryParameter("PBID", m3PBID.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BOPE", m3BOPE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAAN))
				request.WithQueryParameter("BAAN", m3BAAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3NADO))
				request.WithQueryParameter("NADO", m3NADO.Trim());
			if (m3VONO.HasValue)
				request.WithQueryParameter("VONO", m3VONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACDT.HasValue)
				request.WithQueryParameter("ACDT", m3ACDT.Value.ToM3String());
			if (m3BPYS.HasValue)
				request.WithQueryParameter("BPYS", m3BPYS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddBatchHeadResponse>(
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
		/// Name AddBatchLine
		/// Description Create new batch payment line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PBID">Payment batch (Required)</param>
		/// <param name="m3TRNO">Transaction number (Required)</param>
		/// <param name="m3CINO">Invoice number (Required)</param>
		/// <param name="m3INYR">Invoice year (Required)</param>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3PYAM">Payment amount (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3PYTP">Payment type</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3ARAT">Exchange rate</param>
		/// <param name="m3LPDT">Payment date</param>
		/// <param name="m3NBCM">Foreign currency amount</param>
		/// <param name="m3ORAT">Original exchange rate</param>
		/// <param name="m3NBAM">Recorded amount</param>
		/// <param name="m3ADAM">Foreign currency amount</param>
		/// <param name="m3ACDA">Foreign currency amount</param>
		/// <param name="m3CDDT">Cash discount date</param>
		/// <param name="m3CKNO">Check number</param>
		/// <param name="m3AIT1">Accounting dimension 1</param>
		/// <param name="m3AIT2">Accounting dimension 2</param>
		/// <param name="m3AIT3">Accounting dimension 3</param>
		/// <param name="m3AIT4">Accounting dimension 4</param>
		/// <param name="m3AIT5">Accounting dimension 5</param>
		/// <param name="m3AIT6">Accounting dimension 6</param>
		/// <param name="m3AIT7">Accounting dimension 7</param>
		/// <param name="m3CKST">Allocation status</param>
		/// <param name="m3IRNO">Invoice reference number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBatchLine(
			long m3PBID, 
			int m3TRNO, 
			string m3CINO, 
			int m3INYR, 
			string m3CUNO, 
			decimal m3PYAM, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3PYNO = null, 
			string m3PYTP = null, 
			string m3CUCD = null, 
			decimal? m3ARAT = null, 
			DateTime? m3LPDT = null, 
			decimal? m3NBCM = null, 
			decimal? m3ORAT = null, 
			decimal? m3NBAM = null, 
			decimal? m3ADAM = null, 
			decimal? m3ACDA = null, 
			DateTime? m3CDDT = null, 
			string m3CKNO = null, 
			string m3AIT1 = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
			string m3CKST = null, 
			string m3IRNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3CINO))
				throw new ArgumentNullException(nameof(m3CINO));
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PBID", m3PBID.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TRNO", m3TRNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CINO", m3CINO.Trim())
				.WithQueryParameter("INYR", m3INYR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("PYAM", m3PYAM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYTP))
				request.WithQueryParameter("PYTP", m3PYTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3ARAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LPDT.HasValue)
				request.WithQueryParameter("LPDT", m3LPDT.Value.ToM3String());
			if (m3NBCM.HasValue)
				request.WithQueryParameter("NBCM", m3NBCM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORAT.HasValue)
				request.WithQueryParameter("ORAT", m3ORAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NBAM.HasValue)
				request.WithQueryParameter("NBAM", m3NBAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADAM.HasValue)
				request.WithQueryParameter("ADAM", m3ADAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACDA.HasValue)
				request.WithQueryParameter("ACDA", m3ACDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CDDT.HasValue)
				request.WithQueryParameter("CDDT", m3CDDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CKNO))
				request.WithQueryParameter("CKNO", m3CKNO.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3CKST))
				request.WithQueryParameter("CKST", m3CKST.Trim());
			if (!string.IsNullOrWhiteSpace(m3IRNO))
				request.WithQueryParameter("IRNO", m3IRNO.Trim());

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
		/// Name ControlBatch
		/// Description Control Batch
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3PBID">Payment batch</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ControlBatch(
			int? m3CONO = null, 
			string m3DIVI = null, 
			long? m3PBID = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3PBID.HasValue)
				request.WithQueryParameter("PBID", m3PBID.Value.ToString(CultureInfo.CurrentCulture));

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
