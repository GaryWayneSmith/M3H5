/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.MHS020MI;
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
	/// Name: MHS020MI
	/// Component Name: Interface Item/Supplier
	/// Description: Api: Interface Item/Related Item
	/// Version Release: 14.x
	///</summary>
	public partial class MHS020MIResource : M3BaseResourceEndpoint
	{
		public MHS020MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MHS020MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddIntItmAlt
		/// Description Add Interface Item/Related item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3RPTY">Replacement type (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3ALIT">Related item</param>
		/// <param name="m3IFIA">Interface releated item number</param>
		/// <param name="m3INTC">Interchangeability</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3RATY">Reference type</param>
		/// <param name="m3RAID">Reference identity</param>
		/// <param name="m3QAFC">Quantity factor</param>
		/// <param name="m3PUPN">Preferred item</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3CPYS">Copy statistics</param>
		/// <param name="m3CNRE">Cond replacement</param>
		/// <param name="m3CNDN">Condition</param>
		/// <param name="m3ITAB">Item selection table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddIntItmAlt(
			string m3E0PA, 
			string m3E065, 
			string m3IFIN, 
			int m3RPTY, 
			string m3PRMD = null, 
			string m3ALIT = null, 
			string m3IFIA = null, 
			int? m3INTC = null, 
			DateTime? m3STDT = null, 
			int? m3RATY = null, 
			string m3RAID = null, 
			int? m3QAFC = null, 
			int? m3PUPN = null, 
			decimal? m3TXID = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			int? m3CPYS = null, 
			int? m3CNRE = null, 
			string m3CNDN = null, 
			string m3ITAB = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddIntItmAlt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim())
				.WithQueryParameter("RPTY", m3RPTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALIT))
				request.WithQueryParameter("ALIT", m3ALIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3IFIA))
				request.WithQueryParameter("IFIA", m3IFIA.Trim());
			if (m3INTC.HasValue)
				request.WithQueryParameter("INTC", m3INTC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3RATY.HasValue)
				request.WithQueryParameter("RATY", m3RATY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RAID))
				request.WithQueryParameter("RAID", m3RAID.Trim());
			if (m3QAFC.HasValue)
				request.WithQueryParameter("QAFC", m3QAFC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUPN.HasValue)
				request.WithQueryParameter("PUPN", m3PUPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3CPYS.HasValue)
				request.WithQueryParameter("CPYS", m3CPYS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CNRE.HasValue)
				request.WithQueryParameter("CNRE", m3CNRE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CNDN))
				request.WithQueryParameter("CNDN", m3CNDN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITAB))
				request.WithQueryParameter("ITAB", m3ITAB.Trim());

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
		/// Name ChgIntItmAlt
		/// Description Change Interface Item/Related Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3RPTY">Replacement type (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3ALIT">Related item</param>
		/// <param name="m3IFIA">Interface releated item number</param>
		/// <param name="m3INTC">Interchangeability</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3RATY">Reference type</param>
		/// <param name="m3RAID">Reference identity</param>
		/// <param name="m3QAFC">Quantity factor</param>
		/// <param name="m3PUPN">Preferred item</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3STAR">Start date</param>
		/// <param name="m3STIM">Start time</param>
		/// <param name="m3ITFL">Item number flag</param>
		/// <param name="m3ACFL">Add/change flag</param>
		/// <param name="m3CPYS">Copy statistics</param>
		/// <param name="m3CNRE">Cond replacement</param>
		/// <param name="m3CNDN">Condition</param>
		/// <param name="m3ITAB">Item selection table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgIntItmAlt(
			string m3E0PA, 
			string m3E065, 
			string m3IFIN, 
			int m3RPTY, 
			string m3PRMD = null, 
			string m3ALIT = null, 
			string m3IFIA = null, 
			int? m3INTC = null, 
			DateTime? m3STDT = null, 
			int? m3RATY = null, 
			string m3RAID = null, 
			int? m3QAFC = null, 
			int? m3PUPN = null, 
			decimal? m3TXID = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			DateTime? m3STAR = null, 
			int? m3STIM = null, 
			int? m3ITFL = null, 
			int? m3ACFL = null, 
			int? m3CPYS = null, 
			int? m3CNRE = null, 
			string m3CNDN = null, 
			string m3ITAB = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgIntItmAlt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim())
				.WithQueryParameter("RPTY", m3RPTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALIT))
				request.WithQueryParameter("ALIT", m3ALIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3IFIA))
				request.WithQueryParameter("IFIA", m3IFIA.Trim());
			if (m3INTC.HasValue)
				request.WithQueryParameter("INTC", m3INTC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3RATY.HasValue)
				request.WithQueryParameter("RATY", m3RATY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RAID))
				request.WithQueryParameter("RAID", m3RAID.Trim());
			if (m3QAFC.HasValue)
				request.WithQueryParameter("QAFC", m3QAFC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUPN.HasValue)
				request.WithQueryParameter("PUPN", m3PUPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3STAR.HasValue)
				request.WithQueryParameter("STAR", m3STAR.Value.ToM3String());
			if (m3STIM.HasValue)
				request.WithQueryParameter("STIM", m3STIM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3ITFL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACFL.HasValue)
				request.WithQueryParameter("ACFL", m3ACFL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CPYS.HasValue)
				request.WithQueryParameter("CPYS", m3CPYS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CNRE.HasValue)
				request.WithQueryParameter("CNRE", m3CNRE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CNDN))
				request.WithQueryParameter("CNDN", m3CNDN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITAB))
				request.WithQueryParameter("ITAB", m3ITAB.Trim());

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
		/// Name CpyIntItmAlt
		/// Description Copy Interface Item/Related Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3RPTY">Replacement type (Required)</param>
		/// <param name="m3TE0P">Partner (Required)</param>
		/// <param name="m3TE06">Message type (Required)</param>
		/// <param name="m3TFIN">Interface item number (Required)</param>
		/// <param name="m3TRPT">Replacement type (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3ALIT">Related item</param>
		/// <param name="m3IFIA">Interface releated item number</param>
		/// <param name="m3TALI">Related item</param>
		/// <param name="m3TIFA">Interface releated item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyIntItmAlt(
			string m3E0PA, 
			string m3E065, 
			string m3IFIN, 
			int m3RPTY, 
			string m3TE0P, 
			string m3TE06, 
			string m3TFIN, 
			int m3TRPT, 
			string m3PRMD = null, 
			string m3ALIT = null, 
			string m3IFIA = null, 
			string m3TALI = null, 
			string m3TIFA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CpyIntItmAlt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));
			if (string.IsNullOrWhiteSpace(m3TE0P))
				throw new ArgumentNullException(nameof(m3TE0P));
			if (string.IsNullOrWhiteSpace(m3TE06))
				throw new ArgumentNullException(nameof(m3TE06));
			if (string.IsNullOrWhiteSpace(m3TFIN))
				throw new ArgumentNullException(nameof(m3TFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim())
				.WithQueryParameter("RPTY", m3RPTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TE0P", m3TE0P.Trim())
				.WithQueryParameter("TE06", m3TE06.Trim())
				.WithQueryParameter("TFIN", m3TFIN.Trim())
				.WithQueryParameter("TRPT", m3TRPT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALIT))
				request.WithQueryParameter("ALIT", m3ALIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3IFIA))
				request.WithQueryParameter("IFIA", m3IFIA.Trim());
			if (!string.IsNullOrWhiteSpace(m3TALI))
				request.WithQueryParameter("TALI", m3TALI.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIFA))
				request.WithQueryParameter("TIFA", m3TIFA.Trim());

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
		/// Name DelIntItmAlt
		/// Description Delete Interface Item/ Related Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3RPTY">Replacement type (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3ALIT">Related item</param>
		/// <param name="m3IFIA">Interface releated item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelIntItmAlt(
			string m3E0PA, 
			string m3E065, 
			string m3IFIN, 
			int m3RPTY, 
			string m3PRMD = null, 
			string m3ALIT = null, 
			string m3IFIA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelIntItmAlt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim())
				.WithQueryParameter("RPTY", m3RPTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALIT))
				request.WithQueryParameter("ALIT", m3ALIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3IFIA))
				request.WithQueryParameter("IFIA", m3IFIA.Trim());

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
		/// Name GetIntItmAlt
		/// Description Get Interface Item/Related Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3RPTY">Replacement type (Required)</param>
		/// <param name="m3ALIT">Related item</param>
		/// <param name="m3IFIA">Interface releated item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetIntItmAltResponse></returns>
		/// <exception cref="M3Exception<GetIntItmAltResponse>"></exception>
		public async Task<M3Response<GetIntItmAltResponse>> GetIntItmAlt(
			string m3E0PA, 
			string m3E065, 
			string m3IFIN, 
			int m3RPTY, 
			string m3ALIT = null, 
			string m3IFIA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetIntItmAlt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim())
				.WithQueryParameter("RPTY", m3RPTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ALIT))
				request.WithQueryParameter("ALIT", m3ALIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3IFIA))
				request.WithQueryParameter("IFIA", m3IFIA.Trim());

			// Execute the request
			var result = await Execute<GetIntItmAltResponse>(
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
		/// Name LstIntItmAlt
		/// Description List Interface Item/Related Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner</param>
		/// <param name="m3E065">Message type</param>
		/// <param name="m3IFIN">Interface item number</param>
		/// <param name="m3RPTY">Replacement type</param>
		/// <param name="m3ALIT">Related item</param>
		/// <param name="m3IFIA">Interface releated item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstIntItmAltResponse></returns>
		/// <exception cref="M3Exception<LstIntItmAltResponse>"></exception>
		public async Task<M3Response<LstIntItmAltResponse>> LstIntItmAlt(
			string m3E0PA = null, 
			string m3E065 = null, 
			string m3IFIN = null, 
			int? m3RPTY = null, 
			string m3ALIT = null, 
			string m3IFIA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstIntItmAlt",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3E0PA))
				request.WithQueryParameter("E0PA", m3E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3E065))
				request.WithQueryParameter("E065", m3E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3IFIN))
				request.WithQueryParameter("IFIN", m3IFIN.Trim());
			if (m3RPTY.HasValue)
				request.WithQueryParameter("RPTY", m3RPTY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALIT))
				request.WithQueryParameter("ALIT", m3ALIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3IFIA))
				request.WithQueryParameter("IFIA", m3IFIA.Trim());

			// Execute the request
			var result = await Execute<LstIntItmAltResponse>(
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
		/// Name SndAddIntItmAlt
		/// Description Send Add Interface Item/Related Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3RPTY">Replacement type (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3ALIT">Related item</param>
		/// <param name="m3IFIA">Interface releated item number</param>
		/// <param name="m3INTC">Interchangeability</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3RATY">Reference type</param>
		/// <param name="m3RAID">Reference identity</param>
		/// <param name="m3QAFC">Quantity factor</param>
		/// <param name="m3PUPN">Preferred item</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3CPYS">Copy statistics</param>
		/// <param name="m3CNRE">Cond replacement</param>
		/// <param name="m3CNDN">Condition</param>
		/// <param name="m3ITAB">Item selection table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndAddIntItmAlt(
			string m3E0PA, 
			string m3E065, 
			string m3IFIN, 
			int m3RPTY, 
			string m3PRMD = null, 
			string m3ALIT = null, 
			string m3IFIA = null, 
			int? m3INTC = null, 
			DateTime? m3STDT = null, 
			int? m3RATY = null, 
			string m3RAID = null, 
			int? m3QAFC = null, 
			int? m3PUPN = null, 
			decimal? m3TXID = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			int? m3CPYS = null, 
			int? m3CNRE = null, 
			string m3CNDN = null, 
			string m3ITAB = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SndAddIntItmAlt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim())
				.WithQueryParameter("RPTY", m3RPTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALIT))
				request.WithQueryParameter("ALIT", m3ALIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3IFIA))
				request.WithQueryParameter("IFIA", m3IFIA.Trim());
			if (m3INTC.HasValue)
				request.WithQueryParameter("INTC", m3INTC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3RATY.HasValue)
				request.WithQueryParameter("RATY", m3RATY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RAID))
				request.WithQueryParameter("RAID", m3RAID.Trim());
			if (m3QAFC.HasValue)
				request.WithQueryParameter("QAFC", m3QAFC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUPN.HasValue)
				request.WithQueryParameter("PUPN", m3PUPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3CPYS.HasValue)
				request.WithQueryParameter("CPYS", m3CPYS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CNRE.HasValue)
				request.WithQueryParameter("CNRE", m3CNRE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CNDN))
				request.WithQueryParameter("CNDN", m3CNDN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITAB))
				request.WithQueryParameter("ITAB", m3ITAB.Trim());

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
		/// Name SndChgIntItmAlt
		/// Description Send Change Interface Item/Related Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3RPTY">Replacement type (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3ALIT">Related item</param>
		/// <param name="m3IFIA">Interface releated item number</param>
		/// <param name="m3INTC">Interchangeability</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3RATY">Reference type</param>
		/// <param name="m3RAID">Reference identity</param>
		/// <param name="m3QAFC">Quantity factor</param>
		/// <param name="m3PUPN">Preferred item</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3STAR">Start date</param>
		/// <param name="m3STIM">Start time</param>
		/// <param name="m3ITFL">Item number flag</param>
		/// <param name="m3ACFL">Add/change flag</param>
		/// <param name="m3CPYS">Copy statistics</param>
		/// <param name="m3CNRE">Cond replacement</param>
		/// <param name="m3CNDN">Condition</param>
		/// <param name="m3ITAB">Item selection table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndChgIntItmAlt(
			string m3E0PA, 
			string m3E065, 
			string m3IFIN, 
			int m3RPTY, 
			string m3PRMD = null, 
			string m3ALIT = null, 
			string m3IFIA = null, 
			int? m3INTC = null, 
			DateTime? m3STDT = null, 
			int? m3RATY = null, 
			string m3RAID = null, 
			int? m3QAFC = null, 
			int? m3PUPN = null, 
			decimal? m3TXID = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			DateTime? m3STAR = null, 
			int? m3STIM = null, 
			int? m3ITFL = null, 
			int? m3ACFL = null, 
			int? m3CPYS = null, 
			int? m3CNRE = null, 
			string m3CNDN = null, 
			string m3ITAB = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SndChgIntItmAlt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim())
				.WithQueryParameter("RPTY", m3RPTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALIT))
				request.WithQueryParameter("ALIT", m3ALIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3IFIA))
				request.WithQueryParameter("IFIA", m3IFIA.Trim());
			if (m3INTC.HasValue)
				request.WithQueryParameter("INTC", m3INTC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3RATY.HasValue)
				request.WithQueryParameter("RATY", m3RATY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RAID))
				request.WithQueryParameter("RAID", m3RAID.Trim());
			if (m3QAFC.HasValue)
				request.WithQueryParameter("QAFC", m3QAFC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUPN.HasValue)
				request.WithQueryParameter("PUPN", m3PUPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3STAR.HasValue)
				request.WithQueryParameter("STAR", m3STAR.Value.ToM3String());
			if (m3STIM.HasValue)
				request.WithQueryParameter("STIM", m3STIM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3ITFL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACFL.HasValue)
				request.WithQueryParameter("ACFL", m3ACFL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CPYS.HasValue)
				request.WithQueryParameter("CPYS", m3CPYS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CNRE.HasValue)
				request.WithQueryParameter("CNRE", m3CNRE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CNDN))
				request.WithQueryParameter("CNDN", m3CNDN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITAB))
				request.WithQueryParameter("ITAB", m3ITAB.Trim());

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
