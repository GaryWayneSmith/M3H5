/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_QCAM">Promotion (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_LVDT">Valid to (Required)</param>
		/// <param name="m3_DIPC">Discount (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_DISY">Discount model</param>
		/// <param name="m3_DIAM">Discount amount</param>
		/// <param name="m3_QCLY">Claimable</param>
		/// <param name="m3_LKNR">ID number</param>
		/// <param name="m3_ICUN">Internal customer</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_ITCL">Product group</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_INAP">Industry Application</param>
		/// <param name="m3_OENV">Operational Environment</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_CUCL">Customer group</param>
		/// <param name="m3_DISB">Discount base</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_INPM">Internal promotion</param>
		/// <param name="m3_DERE">Default record</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPromotion(
			string m3_QCAM, 
			string m3_TX40, 
			DateTime m3_FVDT, 
			DateTime m3_LVDT, 
			int m3_DIPC, 
			string m3_PRNO = null, 
			string m3_TX15 = null, 
			string m3_STAT = null, 
			string m3_RESP = null, 
			string m3_DISY = null, 
			decimal? m3_DIAM = null, 
			int? m3_QCLY = null, 
			string m3_LKNR = null, 
			string m3_ICUN = null, 
			string m3_ITGR = null, 
			string m3_ITCL = null, 
			string m3_SUNO = null, 
			string m3_INAP = null, 
			string m3_OENV = null, 
			string m3_CUNO = null, 
			string m3_CUCL = null, 
			int? m3_DISB = null, 
			string m3_CUCD = null, 
			int? m3_INPM = null, 
			int? m3_DERE = null, 
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
			if (string.IsNullOrWhiteSpace(m3_QCAM))
				throw new ArgumentNullException("m3_QCAM");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("QCAM", m3_QCAM.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String())
				.WithQueryParameter("LVDT", m3_LVDT.ToM3String())
				.WithQueryParameter("DIPC", m3_DIPC.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DISY))
				request.WithQueryParameter("DISY", m3_DISY.Trim());
			if (m3_DIAM.HasValue)
				request.WithQueryParameter("DIAM", m3_DIAM.Value.ToString());
			if (m3_QCLY.HasValue)
				request.WithQueryParameter("QCLY", m3_QCLY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LKNR))
				request.WithQueryParameter("LKNR", m3_LKNR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ICUN))
				request.WithQueryParameter("ICUN", m3_ICUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITCL))
				request.WithQueryParameter("ITCL", m3_ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INAP))
				request.WithQueryParameter("INAP", m3_INAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OENV))
				request.WithQueryParameter("OENV", m3_OENV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCL))
				request.WithQueryParameter("CUCL", m3_CUCL.Trim());
			if (m3_DISB.HasValue)
				request.WithQueryParameter("DISB", m3_DISB.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_INPM.HasValue)
				request.WithQueryParameter("INPM", m3_INPM.Value.ToString());
			if (m3_DERE.HasValue)
				request.WithQueryParameter("DERE", m3_DERE.Value.ToString());

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
		/// Name ChgPromotion
		/// Description Change Promotion
		/// Version Release: 
		/// </summary>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_QCAM">Promotion</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_DIPC">Discount</param>
		/// <param name="m3_DISY">Discount model</param>
		/// <param name="m3_DIAM">Discount amount</param>
		/// <param name="m3_QCLY">Claimable</param>
		/// <param name="m3_LKNR">ID number</param>
		/// <param name="m3_ICUN">Internal customer</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_ITCL">Product group</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_INAP">Industry Application</param>
		/// <param name="m3_OENV">Operational Environment</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_CUCL">Customer group</param>
		/// <param name="m3_DISB">Discount base</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_INPM">Internal promotion</param>
		/// <param name="m3_DERE">Default record</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgPromotion(
			string m3_PRNO = null, 
			string m3_QCAM = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_STAT = null, 
			string m3_RESP = null, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_LVDT = null, 
			int? m3_DIPC = null, 
			string m3_DISY = null, 
			decimal? m3_DIAM = null, 
			int? m3_QCLY = null, 
			string m3_LKNR = null, 
			string m3_ICUN = null, 
			string m3_ITGR = null, 
			string m3_ITCL = null, 
			string m3_SUNO = null, 
			string m3_INAP = null, 
			string m3_OENV = null, 
			string m3_CUNO = null, 
			string m3_CUCL = null, 
			int? m3_DISB = null, 
			string m3_CUCD = null, 
			int? m3_INPM = null, 
			int? m3_DERE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QCAM))
				request.WithQueryParameter("QCAM", m3_QCAM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (m3_DIPC.HasValue)
				request.WithQueryParameter("DIPC", m3_DIPC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DISY))
				request.WithQueryParameter("DISY", m3_DISY.Trim());
			if (m3_DIAM.HasValue)
				request.WithQueryParameter("DIAM", m3_DIAM.Value.ToString());
			if (m3_QCLY.HasValue)
				request.WithQueryParameter("QCLY", m3_QCLY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LKNR))
				request.WithQueryParameter("LKNR", m3_LKNR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ICUN))
				request.WithQueryParameter("ICUN", m3_ICUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITCL))
				request.WithQueryParameter("ITCL", m3_ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INAP))
				request.WithQueryParameter("INAP", m3_INAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OENV))
				request.WithQueryParameter("OENV", m3_OENV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCL))
				request.WithQueryParameter("CUCL", m3_CUCL.Trim());
			if (m3_DISB.HasValue)
				request.WithQueryParameter("DISB", m3_DISB.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_INPM.HasValue)
				request.WithQueryParameter("INPM", m3_INPM.Value.ToString());
			if (m3_DERE.HasValue)
				request.WithQueryParameter("DERE", m3_DERE.Value.ToString());

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
		/// Name DltPromotion
		/// Description Delete Promotion
		/// Version Release: 
		/// </summary>
		/// <param name="m3_QCAM">Promotion (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltPromotion(
			string m3_QCAM, 
			string m3_PRNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_QCAM))
				throw new ArgumentNullException("m3_QCAM");

			// Set mandatory parameters
			request
				.WithQueryParameter("QCAM", m3_QCAM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());

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
		/// Name GetPromotion
		/// Description Get Promotion
		/// Version Release: 
		/// </summary>
		/// <param name="m3_QCAM">Promotion (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPromotionResponse></returns>
		/// <exception cref="M3Exception<GetPromotionResponse>"></exception>
		public async Task<M3Response<GetPromotionResponse>> GetPromotion(
			string m3_QCAM, 
			string m3_PRNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_QCAM))
				throw new ArgumentNullException("m3_QCAM");

			// Set mandatory parameters
			request
				.WithQueryParameter("QCAM", m3_QCAM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());

			// Execute the request
			var result = await Execute<GetPromotionResponse>(
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
		/// Name LstPromotion
		/// Description List Promotion
		/// Version Release: 
		/// </summary>
		/// <param name="m3_QCAM">Promotion (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPromotionResponse></returns>
		/// <exception cref="M3Exception<LstPromotionResponse>"></exception>
		public async Task<M3Response<LstPromotionResponse>> LstPromotion(
			string m3_QCAM, 
			string m3_PRNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_QCAM))
				throw new ArgumentNullException("m3_QCAM");

			// Set mandatory parameters
			request
				.WithQueryParameter("QCAM", m3_QCAM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());

			// Execute the request
			var result = await Execute<LstPromotionResponse>(
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
