/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.PMS090MI;
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
	/// Name: PMS090MI
	/// Component Name: Report Co-Product for Manf Ord
	/// Description: Manufacturing order report Co-product
	/// Version Release: 14.x
	///</summary>
	public partial class PMS090MIResource : M3BaseResourceEndpoint
	{
		public PMS090MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PMS090MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ConfirmReport
		/// Description ConfirmReport for a given MO and operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3CPNO">Co-product number (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ConfirmReport(
			string m3FACI, 
			string m3MFNO, 
			int m3OPNO, 
			string m3CPNO, 
			string m3PRNO = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ConfirmReport",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3MFNO))
				throw new ArgumentNullException(nameof(m3MFNO));
			if (string.IsNullOrWhiteSpace(m3CPNO))
				throw new ArgumentNullException(nameof(m3CPNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("MFNO", m3MFNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CPNO", m3CPNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());

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
		/// Name DelCoProdReport
		/// Description Delete co product for a given MO and operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3CPNO">Co-product number (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelCoProdReport(
			string m3FACI, 
			string m3MFNO, 
			int m3OPNO, 
			string m3CPNO, 
			string m3PRNO = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelCoProdReport",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3MFNO))
				throw new ArgumentNullException(nameof(m3MFNO));
			if (string.IsNullOrWhiteSpace(m3CPNO))
				throw new ArgumentNullException(nameof(m3CPNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("MFNO", m3MFNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CPNO", m3CPNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());

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
		/// Name GetCoProdReport
		/// Description Gets all co products for a given MO and operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3CPNO">Co-product number (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCoProdReportResponse></returns>
		/// <exception cref="M3Exception<GetCoProdReportResponse>"></exception>
		public async Task<M3Response<GetCoProdReportResponse>> GetCoProdReport(
			string m3FACI, 
			string m3MFNO, 
			int m3OPNO, 
			string m3CPNO, 
			string m3PRNO = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetCoProdReport",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3MFNO))
				throw new ArgumentNullException(nameof(m3MFNO));
			if (string.IsNullOrWhiteSpace(m3CPNO))
				throw new ArgumentNullException(nameof(m3CPNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("MFNO", m3MFNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CPNO", m3CPNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());

			// Execute the request
			var result = await Execute<GetCoProdReportResponse>(
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
		/// Name LstCoProdReport
		/// Description Lists all co products for a given MO and operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCoProdReportResponse></returns>
		/// <exception cref="M3Exception<LstCoProdReportResponse>"></exception>
		public async Task<M3Response<LstCoProdReportResponse>> LstCoProdReport(
			string m3FACI, 
			string m3MFNO, 
			int m3OPNO, 
			string m3PRNO = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstCoProdReport",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3MFNO))
				throw new ArgumentNullException(nameof(m3MFNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("MFNO", m3MFNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());

			// Execute the request
			var result = await Execute<LstCoProdReportResponse>(
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
		/// Name UpdCoProdReport
		/// Description Update co product for a given MO and operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3CPNO">Co-product number (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3TRTM">Transaction time</param>
		/// <param name="m3PRDT">Priority date</param>
		/// <param name="m3POCY">Normal potency</param>
		/// <param name="m3MAQA">Manufactured quantity</param>
		/// <param name="m3RVQA">Received quantity</param>
		/// <param name="m3REND">Manual completion flag</param>
		/// <param name="m3STAS">Status - balance ID</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3TRPR">Inventory accounting price</param>
		/// <param name="m3TRPC">Inventory accounting price quantity</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3DSP6">Flag</param>
		/// <param name="m3EXPI">Expiration date</param>
		/// <param name="m3HVDT">Harvested date</param>
		/// <param name="m3BBDT">Best before date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdCoProdReport(
			string m3FACI, 
			string m3MFNO, 
			int m3OPNO, 
			string m3CPNO, 
			string m3PRNO = null, 
			DateTime? m3RPDT = null, 
			int? m3TRTM = null, 
			DateTime? m3PRDT = null, 
			int? m3POCY = null, 
			decimal? m3MAQA = null, 
			decimal? m3RVQA = null, 
			int? m3REND = null, 
			string m3STAS = null, 
			string m3WHSL = null, 
			string m3CAMU = null, 
			decimal? m3CAWE = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			decimal? m3TRPR = null, 
			int? m3TRPC = null, 
			string m3BANO = null, 
			int? m3DSP6 = null, 
			DateTime? m3EXPI = null, 
			DateTime? m3HVDT = null, 
			DateTime? m3BBDT = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdCoProdReport",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3MFNO))
				throw new ArgumentNullException(nameof(m3MFNO));
			if (string.IsNullOrWhiteSpace(m3CPNO))
				throw new ArgumentNullException(nameof(m3CPNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("MFNO", m3MFNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CPNO", m3CPNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3TRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3PRDT.Value.ToM3String());
			if (m3POCY.HasValue)
				request.WithQueryParameter("POCY", m3POCY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MAQA.HasValue)
				request.WithQueryParameter("MAQA", m3MAQA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RVQA.HasValue)
				request.WithQueryParameter("RVQA", m3RVQA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REND.HasValue)
				request.WithQueryParameter("REND", m3REND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAS))
				request.WithQueryParameter("STAS", m3STAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3TRPR.HasValue)
				request.WithQueryParameter("TRPR", m3TRPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRPC.HasValue)
				request.WithQueryParameter("TRPC", m3TRPC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3DSP6.HasValue)
				request.WithQueryParameter("DSP6", m3DSP6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3EXPI.Value.ToM3String());
			if (m3HVDT.HasValue)
				request.WithQueryParameter("HVDT", m3HVDT.Value.ToM3String());
			if (m3BBDT.HasValue)
				request.WithQueryParameter("BBDT", m3BBDT.Value.ToM3String());

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
