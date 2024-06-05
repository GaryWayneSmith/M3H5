/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.QUS117MI;
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
	/// Name: QUS117MI
	/// Component Name: Promotion
	/// Description: Api: Add Promotion
	/// Version Release: 14.x
	///</summary>
	public partial class QUS117MIResource : M3BaseResourceEndpoint
	{
		public QUS117MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QUS117MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddPromotion
		/// Description Add Promotion
		/// Version Release: 
		/// </summary>
		/// <param name="m3QCAM">Promotion (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3LVDT">Valid to (Required)</param>
		/// <param name="m3DIPC">Discount (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3DISY">Discount model</param>
		/// <param name="m3DIAM">Discount amount</param>
		/// <param name="m3QCLY">Claimable</param>
		/// <param name="m3LKNR">ID number</param>
		/// <param name="m3ICUN">Internal customer</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3ITCL">Product group</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3INAP">Industry Application</param>
		/// <param name="m3OENV">Operational Environment</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3CUCL">Customer group</param>
		/// <param name="m3DISB">Discount base</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3INPM">Internal promotion</param>
		/// <param name="m3DERE">Default record</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPromotion(
			string m3QCAM, 
			string m3TX40, 
			DateTime m3FVDT, 
			DateTime m3LVDT, 
			int m3DIPC, 
			string m3PRNO = null, 
			string m3TX15 = null, 
			string m3STAT = null, 
			string m3RESP = null, 
			string m3DISY = null, 
			decimal? m3DIAM = null, 
			int? m3QCLY = null, 
			string m3LKNR = null, 
			string m3ICUN = null, 
			string m3ITGR = null, 
			string m3ITCL = null, 
			string m3SUNO = null, 
			string m3INAP = null, 
			string m3OENV = null, 
			string m3CUNO = null, 
			string m3CUCL = null, 
			int? m3DISB = null, 
			string m3CUCD = null, 
			int? m3INPM = null, 
			int? m3DERE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPromotion",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3QCAM))
				throw new ArgumentNullException(nameof(m3QCAM));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("QCAM", m3QCAM.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String())
				.WithQueryParameter("LVDT", m3LVDT.ToM3String())
				.WithQueryParameter("DIPC", m3DIPC.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3DISY))
				request.WithQueryParameter("DISY", m3DISY.Trim());
			if (m3DIAM.HasValue)
				request.WithQueryParameter("DIAM", m3DIAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QCLY.HasValue)
				request.WithQueryParameter("QCLY", m3QCLY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LKNR))
				request.WithQueryParameter("LKNR", m3LKNR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ICUN))
				request.WithQueryParameter("ICUN", m3ICUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITCL))
				request.WithQueryParameter("ITCL", m3ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3INAP))
				request.WithQueryParameter("INAP", m3INAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3OENV))
				request.WithQueryParameter("OENV", m3OENV.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCL))
				request.WithQueryParameter("CUCL", m3CUCL.Trim());
			if (m3DISB.HasValue)
				request.WithQueryParameter("DISB", m3DISB.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3INPM.HasValue)
				request.WithQueryParameter("INPM", m3INPM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DERE.HasValue)
				request.WithQueryParameter("DERE", m3DERE.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgPromotion
		/// Description Change Promotion
		/// Version Release: 
		/// </summary>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3QCAM">Promotion</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3DIPC">Discount</param>
		/// <param name="m3DISY">Discount model</param>
		/// <param name="m3DIAM">Discount amount</param>
		/// <param name="m3QCLY">Claimable</param>
		/// <param name="m3LKNR">ID number</param>
		/// <param name="m3ICUN">Internal customer</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3ITCL">Product group</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3INAP">Industry Application</param>
		/// <param name="m3OENV">Operational Environment</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3CUCL">Customer group</param>
		/// <param name="m3DISB">Discount base</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3INPM">Internal promotion</param>
		/// <param name="m3DERE">Default record</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgPromotion(
			string m3PRNO = null, 
			string m3QCAM = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3STAT = null, 
			string m3RESP = null, 
			DateTime? m3FVDT = null, 
			DateTime? m3LVDT = null, 
			int? m3DIPC = null, 
			string m3DISY = null, 
			decimal? m3DIAM = null, 
			int? m3QCLY = null, 
			string m3LKNR = null, 
			string m3ICUN = null, 
			string m3ITGR = null, 
			string m3ITCL = null, 
			string m3SUNO = null, 
			string m3INAP = null, 
			string m3OENV = null, 
			string m3CUNO = null, 
			string m3CUCL = null, 
			int? m3DISB = null, 
			string m3CUCD = null, 
			int? m3INPM = null, 
			int? m3DERE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgPromotion",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QCAM))
				request.WithQueryParameter("QCAM", m3QCAM.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (m3DIPC.HasValue)
				request.WithQueryParameter("DIPC", m3DIPC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DISY))
				request.WithQueryParameter("DISY", m3DISY.Trim());
			if (m3DIAM.HasValue)
				request.WithQueryParameter("DIAM", m3DIAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QCLY.HasValue)
				request.WithQueryParameter("QCLY", m3QCLY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LKNR))
				request.WithQueryParameter("LKNR", m3LKNR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ICUN))
				request.WithQueryParameter("ICUN", m3ICUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITCL))
				request.WithQueryParameter("ITCL", m3ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3INAP))
				request.WithQueryParameter("INAP", m3INAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3OENV))
				request.WithQueryParameter("OENV", m3OENV.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCL))
				request.WithQueryParameter("CUCL", m3CUCL.Trim());
			if (m3DISB.HasValue)
				request.WithQueryParameter("DISB", m3DISB.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3INPM.HasValue)
				request.WithQueryParameter("INPM", m3INPM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DERE.HasValue)
				request.WithQueryParameter("DERE", m3DERE.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltPromotion
		/// Description Delete Promotion
		/// Version Release: 
		/// </summary>
		/// <param name="m3QCAM">Promotion (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltPromotion(
			string m3QCAM, 
			string m3PRNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltPromotion",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3QCAM))
				throw new ArgumentNullException(nameof(m3QCAM));

			// Set mandatory parameters
			request
				.WithQueryParameter("QCAM", m3QCAM.Trim());

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
		/// Name GetPromotion
		/// Description Get Promotion
		/// Version Release: 
		/// </summary>
		/// <param name="m3QCAM">Promotion (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPromotionResponse></returns>
		/// <exception cref="M3Exception<GetPromotionResponse>"></exception>
		public async Task<M3Response<GetPromotionResponse>> GetPromotion(
			string m3QCAM, 
			string m3PRNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPromotion",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3QCAM))
				throw new ArgumentNullException(nameof(m3QCAM));

			// Set mandatory parameters
			request
				.WithQueryParameter("QCAM", m3QCAM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());

			// Execute the request
			var result = await Execute<GetPromotionResponse>(
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
		/// Name LstPromotion
		/// Description List Promotion
		/// Version Release: 
		/// </summary>
		/// <param name="m3QCAM">Promotion (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPromotionResponse></returns>
		/// <exception cref="M3Exception<LstPromotionResponse>"></exception>
		public async Task<M3Response<LstPromotionResponse>> LstPromotion(
			string m3QCAM, 
			string m3PRNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPromotion",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3QCAM))
				throw new ArgumentNullException(nameof(m3QCAM));

			// Set mandatory parameters
			request
				.WithQueryParameter("QCAM", m3QCAM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());

			// Execute the request
			var result = await Execute<LstPromotionResponse>(
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
