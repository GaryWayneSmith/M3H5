/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PPS194MI;
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
	/// Name: PPS194MI
	/// Component Name: PO
	/// Description: Review Cycle
	/// Version Release: 5e90
	///</summary>
	public partial class PPS194MIResource : M3BaseResourceEndpoint
	{
		public PPS194MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PPS194MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddLine
		/// Description AddLine
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_BUYE">Buyer (Required)</param>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_PRGP">Procurement group (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_PUNO">Purchase order number (Required)</param>
		/// <param name="m3_RELD">Release date</param>
		/// <param name="m3_DLDT">Planned delivery date</param>
		/// <param name="m3_TOCO">Total cost</param>
		/// <param name="m3_TVOL">Total volume</param>
		/// <param name="m3_TGRW">Total gross weight</param>
		/// <param name="m3_GRWE">Gross weight</param>
		/// <param name="m3_NEWE">Net weight</param>
		/// <param name="m3_LAPL">Late proposals</param>
		/// <param name="m3_RFPL">Referenced proposals</param>
		/// <param name="m3_NOPL">Normal proposals</param>
		/// <param name="m3_NUPL">Number of planned orders</param>
		/// <param name="m3_TRGT">Target type</param>
		/// <param name="m3_TRGW">Target weight</param>
		/// <param name="m3_TRGV">Target volume</param>
		/// <param name="m3_TRGC">Target cost</param>
		/// <param name="m3_RLIV">Release interval</param>
		/// <param name="m3_LIBU">Line buy</param>
		/// <param name="m3_FILU">Fill-up</param>
		/// <param name="m3_PRLD">Planned release date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLine(
			string m3_BUYE, 
			string m3_SUNO, 
			string m3_PRGP, 
			string m3_WHLO, 
			string m3_PUNO, 
			DateTime? m3_RELD = null, 
			DateTime? m3_DLDT = null, 
			decimal? m3_TOCO = null, 
			decimal? m3_TVOL = null, 
			decimal? m3_TGRW = null, 
			decimal? m3_GRWE = null, 
			decimal? m3_NEWE = null, 
			int? m3_LAPL = null, 
			int? m3_RFPL = null, 
			int? m3_NOPL = null, 
			int? m3_NUPL = null, 
			int? m3_TRGT = null, 
			decimal? m3_TRGW = null, 
			decimal? m3_TRGV = null, 
			decimal? m3_TRGC = null, 
			int? m3_RLIV = null, 
			int? m3_LIBU = null, 
			int? m3_FILU = null, 
			DateTime? m3_PRLD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BUYE))
				throw new ArgumentNullException("m3_BUYE");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_PRGP))
				throw new ArgumentNullException("m3_PRGP");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("BUYE", m3_BUYE.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("PRGP", m3_PRGP.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("PUNO", m3_PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RELD.HasValue)
				request.WithQueryParameter("RELD", m3_RELD.Value.ToM3String());
			if (m3_DLDT.HasValue)
				request.WithQueryParameter("DLDT", m3_DLDT.Value.ToM3String());
			if (m3_TOCO.HasValue)
				request.WithQueryParameter("TOCO", m3_TOCO.Value.ToString());
			if (m3_TVOL.HasValue)
				request.WithQueryParameter("TVOL", m3_TVOL.Value.ToString());
			if (m3_TGRW.HasValue)
				request.WithQueryParameter("TGRW", m3_TGRW.Value.ToString());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (m3_NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3_NEWE.Value.ToString());
			if (m3_LAPL.HasValue)
				request.WithQueryParameter("LAPL", m3_LAPL.Value.ToString());
			if (m3_RFPL.HasValue)
				request.WithQueryParameter("RFPL", m3_RFPL.Value.ToString());
			if (m3_NOPL.HasValue)
				request.WithQueryParameter("NOPL", m3_NOPL.Value.ToString());
			if (m3_NUPL.HasValue)
				request.WithQueryParameter("NUPL", m3_NUPL.Value.ToString());
			if (m3_TRGT.HasValue)
				request.WithQueryParameter("TRGT", m3_TRGT.Value.ToString());
			if (m3_TRGW.HasValue)
				request.WithQueryParameter("TRGW", m3_TRGW.Value.ToString());
			if (m3_TRGV.HasValue)
				request.WithQueryParameter("TRGV", m3_TRGV.Value.ToString());
			if (m3_TRGC.HasValue)
				request.WithQueryParameter("TRGC", m3_TRGC.Value.ToString());
			if (m3_RLIV.HasValue)
				request.WithQueryParameter("RLIV", m3_RLIV.Value.ToString());
			if (m3_LIBU.HasValue)
				request.WithQueryParameter("LIBU", m3_LIBU.Value.ToString());
			if (m3_FILU.HasValue)
				request.WithQueryParameter("FILU", m3_FILU.Value.ToString());
			if (m3_PRLD.HasValue)
				request.WithQueryParameter("PRLD", m3_PRLD.Value.ToM3String());

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
		/// Name DltLine
		/// Description DltLine
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_BUYE">Buyer (Required)</param>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_PRGP">Procurement group (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_PUNO">Purchase order number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltLine(
			string m3_BUYE, 
			string m3_SUNO, 
			string m3_PRGP, 
			string m3_WHLO, 
			string m3_PUNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BUYE))
				throw new ArgumentNullException("m3_BUYE");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_PRGP))
				throw new ArgumentNullException("m3_PRGP");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("BUYE", m3_BUYE.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("PRGP", m3_PRGP.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("PUNO", m3_PUNO.Trim());

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
		/// Name GetLine
		/// Description Get Line from Review Cycle
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_BUYE">Buyer (Required)</param>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_PRGP">Procurement group (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_PUNO">Purchase order number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLineResponse></returns>
		/// <exception cref="M3Exception<GetLineResponse>"></exception>
		public async Task<M3Response<GetLineResponse>> GetLine(
			string m3_BUYE, 
			string m3_SUNO, 
			string m3_PRGP, 
			string m3_WHLO, 
			string m3_PUNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BUYE))
				throw new ArgumentNullException("m3_BUYE");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_PRGP))
				throw new ArgumentNullException("m3_PRGP");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("BUYE", m3_BUYE.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("PRGP", m3_PRGP.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("PUNO", m3_PUNO.Trim());

			// Execute the request
			var result = await Execute<GetLineResponse>(
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
		/// Name LstLines
		/// Description List lines from review cycle
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_BUYE">Buyer</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_PRGP">Procurement group</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_PUNO">Purchase order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLinesResponse></returns>
		/// <exception cref="M3Exception<LstLinesResponse>"></exception>
		public async Task<M3Response<LstLinesResponse>> LstLines(
			string m3_BUYE = null, 
			string m3_SUNO = null, 
			string m3_PRGP = null, 
			string m3_WHLO = null, 
			string m3_PUNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLines",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BUYE))
				request.WithQueryParameter("BUYE", m3_BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRGP))
				request.WithQueryParameter("PRGP", m3_PRGP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PUNO))
				request.WithQueryParameter("PUNO", m3_PUNO.Trim());

			// Execute the request
			var result = await Execute<LstLinesResponse>(
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
		/// Name UpdLine
		/// Description UpdLine
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_BUYE">Buyer (Required)</param>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_PRGP">Procurement group (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_PUNO">Purchase order number (Required)</param>
		/// <param name="m3_RELD">Release date</param>
		/// <param name="m3_DLDT">Planned delivery date</param>
		/// <param name="m3_TOCO">Total cost</param>
		/// <param name="m3_TVOL">Total volume</param>
		/// <param name="m3_TGRW">Total gross weight</param>
		/// <param name="m3_GRWE">Gross weight</param>
		/// <param name="m3_NEWE">Net weight</param>
		/// <param name="m3_LAPL">Late proposals</param>
		/// <param name="m3_RFPL">Referenced proposals</param>
		/// <param name="m3_NOPL">Normal proposals</param>
		/// <param name="m3_NUPL">Number of planned orders</param>
		/// <param name="m3_TRGT">Target type</param>
		/// <param name="m3_TRGW">Target weight</param>
		/// <param name="m3_TRGV">Target volume</param>
		/// <param name="m3_TRGC">Target cost</param>
		/// <param name="m3_RLIV">Release interval</param>
		/// <param name="m3_LIBU">Line buy</param>
		/// <param name="m3_FILU">Fill-up</param>
		/// <param name="m3_PRLD">Planned release date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdLine(
			string m3_BUYE, 
			string m3_SUNO, 
			string m3_PRGP, 
			string m3_WHLO, 
			string m3_PUNO, 
			DateTime? m3_RELD = null, 
			DateTime? m3_DLDT = null, 
			decimal? m3_TOCO = null, 
			decimal? m3_TVOL = null, 
			decimal? m3_TGRW = null, 
			decimal? m3_GRWE = null, 
			decimal? m3_NEWE = null, 
			int? m3_LAPL = null, 
			int? m3_RFPL = null, 
			int? m3_NOPL = null, 
			int? m3_NUPL = null, 
			int? m3_TRGT = null, 
			decimal? m3_TRGW = null, 
			decimal? m3_TRGV = null, 
			decimal? m3_TRGC = null, 
			int? m3_RLIV = null, 
			int? m3_LIBU = null, 
			int? m3_FILU = null, 
			DateTime? m3_PRLD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BUYE))
				throw new ArgumentNullException("m3_BUYE");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_PRGP))
				throw new ArgumentNullException("m3_PRGP");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("BUYE", m3_BUYE.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("PRGP", m3_PRGP.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("PUNO", m3_PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RELD.HasValue)
				request.WithQueryParameter("RELD", m3_RELD.Value.ToM3String());
			if (m3_DLDT.HasValue)
				request.WithQueryParameter("DLDT", m3_DLDT.Value.ToM3String());
			if (m3_TOCO.HasValue)
				request.WithQueryParameter("TOCO", m3_TOCO.Value.ToString());
			if (m3_TVOL.HasValue)
				request.WithQueryParameter("TVOL", m3_TVOL.Value.ToString());
			if (m3_TGRW.HasValue)
				request.WithQueryParameter("TGRW", m3_TGRW.Value.ToString());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (m3_NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3_NEWE.Value.ToString());
			if (m3_LAPL.HasValue)
				request.WithQueryParameter("LAPL", m3_LAPL.Value.ToString());
			if (m3_RFPL.HasValue)
				request.WithQueryParameter("RFPL", m3_RFPL.Value.ToString());
			if (m3_NOPL.HasValue)
				request.WithQueryParameter("NOPL", m3_NOPL.Value.ToString());
			if (m3_NUPL.HasValue)
				request.WithQueryParameter("NUPL", m3_NUPL.Value.ToString());
			if (m3_TRGT.HasValue)
				request.WithQueryParameter("TRGT", m3_TRGT.Value.ToString());
			if (m3_TRGW.HasValue)
				request.WithQueryParameter("TRGW", m3_TRGW.Value.ToString());
			if (m3_TRGV.HasValue)
				request.WithQueryParameter("TRGV", m3_TRGV.Value.ToString());
			if (m3_TRGC.HasValue)
				request.WithQueryParameter("TRGC", m3_TRGC.Value.ToString());
			if (m3_RLIV.HasValue)
				request.WithQueryParameter("RLIV", m3_RLIV.Value.ToString());
			if (m3_LIBU.HasValue)
				request.WithQueryParameter("LIBU", m3_LIBU.Value.ToString());
			if (m3_FILU.HasValue)
				request.WithQueryParameter("FILU", m3_FILU.Value.ToString());
			if (m3_PRLD.HasValue)
				request.WithQueryParameter("PRLD", m3_PRLD.Value.ToM3String());

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
