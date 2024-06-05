/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3BUYE">Buyer (Required)</param>
		/// <param name="m3SUNO">Supplier (Required)</param>
		/// <param name="m3PRGP">Procurement group (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3PUNO">Purchase order number (Required)</param>
		/// <param name="m3RELD">Release date</param>
		/// <param name="m3DLDT">Planned delivery date</param>
		/// <param name="m3TOCO">Total cost</param>
		/// <param name="m3TVOL">Total volume</param>
		/// <param name="m3TGRW">Total gross weight</param>
		/// <param name="m3GRWE">Gross weight</param>
		/// <param name="m3NEWE">Net weight</param>
		/// <param name="m3LAPL">Late proposals</param>
		/// <param name="m3RFPL">Referenced proposals</param>
		/// <param name="m3NOPL">Normal proposals</param>
		/// <param name="m3NUPL">Number of planned orders</param>
		/// <param name="m3TRGT">Target type</param>
		/// <param name="m3TRGW">Target weight</param>
		/// <param name="m3TRGV">Target volume</param>
		/// <param name="m3TRGC">Target cost</param>
		/// <param name="m3RLIV">Release interval</param>
		/// <param name="m3LIBU">Line buy</param>
		/// <param name="m3FILU">Fill-up</param>
		/// <param name="m3PRLD">Planned release date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLine(
			string m3BUYE, 
			string m3SUNO, 
			string m3PRGP, 
			string m3WHLO, 
			string m3PUNO, 
			DateTime? m3RELD = null, 
			DateTime? m3DLDT = null, 
			decimal? m3TOCO = null, 
			decimal? m3TVOL = null, 
			decimal? m3TGRW = null, 
			decimal? m3GRWE = null, 
			decimal? m3NEWE = null, 
			int? m3LAPL = null, 
			int? m3RFPL = null, 
			int? m3NOPL = null, 
			int? m3NUPL = null, 
			int? m3TRGT = null, 
			decimal? m3TRGW = null, 
			decimal? m3TRGV = null, 
			decimal? m3TRGC = null, 
			int? m3RLIV = null, 
			int? m3LIBU = null, 
			int? m3FILU = null, 
			DateTime? m3PRLD = null, 
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
			if (string.IsNullOrWhiteSpace(m3BUYE))
				throw new ArgumentNullException(nameof(m3BUYE));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3PRGP))
				throw new ArgumentNullException(nameof(m3PRGP));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("BUYE", m3BUYE.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("PRGP", m3PRGP.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("PUNO", m3PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3RELD.HasValue)
				request.WithQueryParameter("RELD", m3RELD.Value.ToM3String());
			if (m3DLDT.HasValue)
				request.WithQueryParameter("DLDT", m3DLDT.Value.ToM3String());
			if (m3TOCO.HasValue)
				request.WithQueryParameter("TOCO", m3TOCO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TVOL.HasValue)
				request.WithQueryParameter("TVOL", m3TVOL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TGRW.HasValue)
				request.WithQueryParameter("TGRW", m3TGRW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3NEWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LAPL.HasValue)
				request.WithQueryParameter("LAPL", m3LAPL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RFPL.HasValue)
				request.WithQueryParameter("RFPL", m3RFPL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NOPL.HasValue)
				request.WithQueryParameter("NOPL", m3NOPL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUPL.HasValue)
				request.WithQueryParameter("NUPL", m3NUPL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRGT.HasValue)
				request.WithQueryParameter("TRGT", m3TRGT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRGW.HasValue)
				request.WithQueryParameter("TRGW", m3TRGW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRGV.HasValue)
				request.WithQueryParameter("TRGV", m3TRGV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRGC.HasValue)
				request.WithQueryParameter("TRGC", m3TRGC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RLIV.HasValue)
				request.WithQueryParameter("RLIV", m3RLIV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LIBU.HasValue)
				request.WithQueryParameter("LIBU", m3LIBU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FILU.HasValue)
				request.WithQueryParameter("FILU", m3FILU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRLD.HasValue)
				request.WithQueryParameter("PRLD", m3PRLD.Value.ToM3String());

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
		/// Name DltLine
		/// Description DltLine
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3BUYE">Buyer (Required)</param>
		/// <param name="m3SUNO">Supplier (Required)</param>
		/// <param name="m3PRGP">Procurement group (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3PUNO">Purchase order number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltLine(
			string m3BUYE, 
			string m3SUNO, 
			string m3PRGP, 
			string m3WHLO, 
			string m3PUNO, 
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
			if (string.IsNullOrWhiteSpace(m3BUYE))
				throw new ArgumentNullException(nameof(m3BUYE));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3PRGP))
				throw new ArgumentNullException(nameof(m3PRGP));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("BUYE", m3BUYE.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("PRGP", m3PRGP.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("PUNO", m3PUNO.Trim());

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
		/// Name GetLine
		/// Description Get Line from Review Cycle
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3BUYE">Buyer (Required)</param>
		/// <param name="m3SUNO">Supplier (Required)</param>
		/// <param name="m3PRGP">Procurement group (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3PUNO">Purchase order number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLineResponse></returns>
		/// <exception cref="M3Exception<GetLineResponse>"></exception>
		public async Task<M3Response<GetLineResponse>> GetLine(
			string m3BUYE, 
			string m3SUNO, 
			string m3PRGP, 
			string m3WHLO, 
			string m3PUNO, 
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
			if (string.IsNullOrWhiteSpace(m3BUYE))
				throw new ArgumentNullException(nameof(m3BUYE));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3PRGP))
				throw new ArgumentNullException(nameof(m3PRGP));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("BUYE", m3BUYE.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("PRGP", m3PRGP.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("PUNO", m3PUNO.Trim());

			// Execute the request
			var result = await Execute<GetLineResponse>(
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
		/// Name LstLines
		/// Description List lines from review cycle
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3BUYE">Buyer</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3PRGP">Procurement group</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3PUNO">Purchase order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLinesResponse></returns>
		/// <exception cref="M3Exception<LstLinesResponse>"></exception>
		public async Task<M3Response<LstLinesResponse>> LstLines(
			string m3BUYE = null, 
			string m3SUNO = null, 
			string m3PRGP = null, 
			string m3WHLO = null, 
			string m3PUNO = null, 
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
			if (!string.IsNullOrWhiteSpace(m3BUYE))
				request.WithQueryParameter("BUYE", m3BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRGP))
				request.WithQueryParameter("PRGP", m3PRGP.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PUNO))
				request.WithQueryParameter("PUNO", m3PUNO.Trim());

			// Execute the request
			var result = await Execute<LstLinesResponse>(
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
		/// Name UpdLine
		/// Description UpdLine
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3BUYE">Buyer (Required)</param>
		/// <param name="m3SUNO">Supplier (Required)</param>
		/// <param name="m3PRGP">Procurement group (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3PUNO">Purchase order number (Required)</param>
		/// <param name="m3RELD">Release date</param>
		/// <param name="m3DLDT">Planned delivery date</param>
		/// <param name="m3TOCO">Total cost</param>
		/// <param name="m3TVOL">Total volume</param>
		/// <param name="m3TGRW">Total gross weight</param>
		/// <param name="m3GRWE">Gross weight</param>
		/// <param name="m3NEWE">Net weight</param>
		/// <param name="m3LAPL">Late proposals</param>
		/// <param name="m3RFPL">Referenced proposals</param>
		/// <param name="m3NOPL">Normal proposals</param>
		/// <param name="m3NUPL">Number of planned orders</param>
		/// <param name="m3TRGT">Target type</param>
		/// <param name="m3TRGW">Target weight</param>
		/// <param name="m3TRGV">Target volume</param>
		/// <param name="m3TRGC">Target cost</param>
		/// <param name="m3RLIV">Release interval</param>
		/// <param name="m3LIBU">Line buy</param>
		/// <param name="m3FILU">Fill-up</param>
		/// <param name="m3PRLD">Planned release date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdLine(
			string m3BUYE, 
			string m3SUNO, 
			string m3PRGP, 
			string m3WHLO, 
			string m3PUNO, 
			DateTime? m3RELD = null, 
			DateTime? m3DLDT = null, 
			decimal? m3TOCO = null, 
			decimal? m3TVOL = null, 
			decimal? m3TGRW = null, 
			decimal? m3GRWE = null, 
			decimal? m3NEWE = null, 
			int? m3LAPL = null, 
			int? m3RFPL = null, 
			int? m3NOPL = null, 
			int? m3NUPL = null, 
			int? m3TRGT = null, 
			decimal? m3TRGW = null, 
			decimal? m3TRGV = null, 
			decimal? m3TRGC = null, 
			int? m3RLIV = null, 
			int? m3LIBU = null, 
			int? m3FILU = null, 
			DateTime? m3PRLD = null, 
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
			if (string.IsNullOrWhiteSpace(m3BUYE))
				throw new ArgumentNullException(nameof(m3BUYE));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3PRGP))
				throw new ArgumentNullException(nameof(m3PRGP));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("BUYE", m3BUYE.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("PRGP", m3PRGP.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("PUNO", m3PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3RELD.HasValue)
				request.WithQueryParameter("RELD", m3RELD.Value.ToM3String());
			if (m3DLDT.HasValue)
				request.WithQueryParameter("DLDT", m3DLDT.Value.ToM3String());
			if (m3TOCO.HasValue)
				request.WithQueryParameter("TOCO", m3TOCO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TVOL.HasValue)
				request.WithQueryParameter("TVOL", m3TVOL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TGRW.HasValue)
				request.WithQueryParameter("TGRW", m3TGRW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3NEWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LAPL.HasValue)
				request.WithQueryParameter("LAPL", m3LAPL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RFPL.HasValue)
				request.WithQueryParameter("RFPL", m3RFPL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NOPL.HasValue)
				request.WithQueryParameter("NOPL", m3NOPL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUPL.HasValue)
				request.WithQueryParameter("NUPL", m3NUPL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRGT.HasValue)
				request.WithQueryParameter("TRGT", m3TRGT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRGW.HasValue)
				request.WithQueryParameter("TRGW", m3TRGW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRGV.HasValue)
				request.WithQueryParameter("TRGV", m3TRGV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRGC.HasValue)
				request.WithQueryParameter("TRGC", m3TRGC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RLIV.HasValue)
				request.WithQueryParameter("RLIV", m3RLIV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LIBU.HasValue)
				request.WithQueryParameter("LIBU", m3LIBU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FILU.HasValue)
				request.WithQueryParameter("FILU", m3FILU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRLD.HasValue)
				request.WithQueryParameter("PRLD", m3PRLD.Value.ToM3String());

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
