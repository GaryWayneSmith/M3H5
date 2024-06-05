/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddIntItmAlt
		/// Description Add Interface Item/Related item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_RPTY">Replacement type (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_ALIT">Related item</param>
		/// <param name="m3_IFIA">Interface releated item number</param>
		/// <param name="m3_INTC">Interchangeability</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_RATY">Reference type</param>
		/// <param name="m3_RAID">Reference identity</param>
		/// <param name="m3_QAFC">Quantity factor</param>
		/// <param name="m3_PUPN">Preferred item</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_CPYS">Copy statistics</param>
		/// <param name="m3_CNRE">Cond replacement</param>
		/// <param name="m3_CNDN">Condition</param>
		/// <param name="m3_ITAB">Item selection table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddIntItmAlt(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			int m3_RPTY, 
			string m3_PRMD = null, 
			string m3_ALIT = null, 
			string m3_IFIA = null, 
			int? m3_INTC = null, 
			DateTime? m3_STDT = null, 
			int? m3_RATY = null, 
			string m3_RAID = null, 
			int? m3_QAFC = null, 
			int? m3_PUPN = null, 
			decimal? m3_TXID = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			int? m3_CPYS = null, 
			int? m3_CNRE = null, 
			string m3_CNDN = null, 
			string m3_ITAB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddIntItmAlt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("RPTY", m3_RPTY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALIT))
				request.WithQueryParameter("ALIT", m3_ALIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IFIA))
				request.WithQueryParameter("IFIA", m3_IFIA.Trim());
			if (m3_INTC.HasValue)
				request.WithQueryParameter("INTC", m3_INTC.Value.ToString());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_RATY.HasValue)
				request.WithQueryParameter("RATY", m3_RATY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RAID))
				request.WithQueryParameter("RAID", m3_RAID.Trim());
			if (m3_QAFC.HasValue)
				request.WithQueryParameter("QAFC", m3_QAFC.Value.ToString());
			if (m3_PUPN.HasValue)
				request.WithQueryParameter("PUPN", m3_PUPN.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_CPYS.HasValue)
				request.WithQueryParameter("CPYS", m3_CPYS.Value.ToString());
			if (m3_CNRE.HasValue)
				request.WithQueryParameter("CNRE", m3_CNRE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CNDN))
				request.WithQueryParameter("CNDN", m3_CNDN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITAB))
				request.WithQueryParameter("ITAB", m3_ITAB.Trim());

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
		/// Name ChgIntItmAlt
		/// Description Change Interface Item/Related Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_RPTY">Replacement type (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_ALIT">Related item</param>
		/// <param name="m3_IFIA">Interface releated item number</param>
		/// <param name="m3_INTC">Interchangeability</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_RATY">Reference type</param>
		/// <param name="m3_RAID">Reference identity</param>
		/// <param name="m3_QAFC">Quantity factor</param>
		/// <param name="m3_PUPN">Preferred item</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_STAR">Start date</param>
		/// <param name="m3_STIM">Start time</param>
		/// <param name="m3_ITFL">Item number flag</param>
		/// <param name="m3_ACFL">Add/change flag</param>
		/// <param name="m3_CPYS">Copy statistics</param>
		/// <param name="m3_CNRE">Cond replacement</param>
		/// <param name="m3_CNDN">Condition</param>
		/// <param name="m3_ITAB">Item selection table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgIntItmAlt(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			int m3_RPTY, 
			string m3_PRMD = null, 
			string m3_ALIT = null, 
			string m3_IFIA = null, 
			int? m3_INTC = null, 
			DateTime? m3_STDT = null, 
			int? m3_RATY = null, 
			string m3_RAID = null, 
			int? m3_QAFC = null, 
			int? m3_PUPN = null, 
			decimal? m3_TXID = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			DateTime? m3_STAR = null, 
			int? m3_STIM = null, 
			int? m3_ITFL = null, 
			int? m3_ACFL = null, 
			int? m3_CPYS = null, 
			int? m3_CNRE = null, 
			string m3_CNDN = null, 
			string m3_ITAB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgIntItmAlt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("RPTY", m3_RPTY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALIT))
				request.WithQueryParameter("ALIT", m3_ALIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IFIA))
				request.WithQueryParameter("IFIA", m3_IFIA.Trim());
			if (m3_INTC.HasValue)
				request.WithQueryParameter("INTC", m3_INTC.Value.ToString());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_RATY.HasValue)
				request.WithQueryParameter("RATY", m3_RATY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RAID))
				request.WithQueryParameter("RAID", m3_RAID.Trim());
			if (m3_QAFC.HasValue)
				request.WithQueryParameter("QAFC", m3_QAFC.Value.ToString());
			if (m3_PUPN.HasValue)
				request.WithQueryParameter("PUPN", m3_PUPN.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_STAR.HasValue)
				request.WithQueryParameter("STAR", m3_STAR.Value.ToM3String());
			if (m3_STIM.HasValue)
				request.WithQueryParameter("STIM", m3_STIM.Value.ToString());
			if (m3_ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3_ITFL.Value.ToString());
			if (m3_ACFL.HasValue)
				request.WithQueryParameter("ACFL", m3_ACFL.Value.ToString());
			if (m3_CPYS.HasValue)
				request.WithQueryParameter("CPYS", m3_CPYS.Value.ToString());
			if (m3_CNRE.HasValue)
				request.WithQueryParameter("CNRE", m3_CNRE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CNDN))
				request.WithQueryParameter("CNDN", m3_CNDN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITAB))
				request.WithQueryParameter("ITAB", m3_ITAB.Trim());

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
		/// Name CpyIntItmAlt
		/// Description Copy Interface Item/Related Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_RPTY">Replacement type (Required)</param>
		/// <param name="m3_TE0P">Partner (Required)</param>
		/// <param name="m3_TE06">Message type (Required)</param>
		/// <param name="m3_TFIN">Interface item number (Required)</param>
		/// <param name="m3_TRPT">Replacement type (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_ALIT">Related item</param>
		/// <param name="m3_IFIA">Interface releated item number</param>
		/// <param name="m3_TALI">Related item</param>
		/// <param name="m3_TIFA">Interface releated item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyIntItmAlt(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			int m3_RPTY, 
			string m3_TE0P, 
			string m3_TE06, 
			string m3_TFIN, 
			int m3_TRPT, 
			string m3_PRMD = null, 
			string m3_ALIT = null, 
			string m3_IFIA = null, 
			string m3_TALI = null, 
			string m3_TIFA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyIntItmAlt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");
			if (string.IsNullOrWhiteSpace(m3_TE0P))
				throw new ArgumentNullException("m3_TE0P");
			if (string.IsNullOrWhiteSpace(m3_TE06))
				throw new ArgumentNullException("m3_TE06");
			if (string.IsNullOrWhiteSpace(m3_TFIN))
				throw new ArgumentNullException("m3_TFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("RPTY", m3_RPTY.ToString())
				.WithQueryParameter("TE0P", m3_TE0P.Trim())
				.WithQueryParameter("TE06", m3_TE06.Trim())
				.WithQueryParameter("TFIN", m3_TFIN.Trim())
				.WithQueryParameter("TRPT", m3_TRPT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALIT))
				request.WithQueryParameter("ALIT", m3_ALIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IFIA))
				request.WithQueryParameter("IFIA", m3_IFIA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TALI))
				request.WithQueryParameter("TALI", m3_TALI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIFA))
				request.WithQueryParameter("TIFA", m3_TIFA.Trim());

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
		/// Name DelIntItmAlt
		/// Description Delete Interface Item/ Related Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_RPTY">Replacement type (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_ALIT">Related item</param>
		/// <param name="m3_IFIA">Interface releated item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelIntItmAlt(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			int m3_RPTY, 
			string m3_PRMD = null, 
			string m3_ALIT = null, 
			string m3_IFIA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelIntItmAlt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("RPTY", m3_RPTY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALIT))
				request.WithQueryParameter("ALIT", m3_ALIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IFIA))
				request.WithQueryParameter("IFIA", m3_IFIA.Trim());

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
		/// Name GetIntItmAlt
		/// Description Get Interface Item/Related Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_RPTY">Replacement type (Required)</param>
		/// <param name="m3_ALIT">Related item</param>
		/// <param name="m3_IFIA">Interface releated item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetIntItmAltResponse></returns>
		/// <exception cref="M3Exception<GetIntItmAltResponse>"></exception>
		public async Task<M3Response<GetIntItmAltResponse>> GetIntItmAlt(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			int m3_RPTY, 
			string m3_ALIT = null, 
			string m3_IFIA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetIntItmAlt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("RPTY", m3_RPTY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ALIT))
				request.WithQueryParameter("ALIT", m3_ALIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IFIA))
				request.WithQueryParameter("IFIA", m3_IFIA.Trim());

			// Execute the request
			var result = await Execute<GetIntItmAltResponse>(
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
		/// Name LstIntItmAlt
		/// Description List Interface Item/Related Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner</param>
		/// <param name="m3_E065">Message type</param>
		/// <param name="m3_IFIN">Interface item number</param>
		/// <param name="m3_RPTY">Replacement type</param>
		/// <param name="m3_ALIT">Related item</param>
		/// <param name="m3_IFIA">Interface releated item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstIntItmAltResponse></returns>
		/// <exception cref="M3Exception<LstIntItmAltResponse>"></exception>
		public async Task<M3Response<LstIntItmAltResponse>> LstIntItmAlt(
			string m3_E0PA = null, 
			string m3_E065 = null, 
			string m3_IFIN = null, 
			int? m3_RPTY = null, 
			string m3_ALIT = null, 
			string m3_IFIA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstIntItmAlt",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_E0PA))
				request.WithQueryParameter("E0PA", m3_E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E065))
				request.WithQueryParameter("E065", m3_E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IFIN))
				request.WithQueryParameter("IFIN", m3_IFIN.Trim());
			if (m3_RPTY.HasValue)
				request.WithQueryParameter("RPTY", m3_RPTY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALIT))
				request.WithQueryParameter("ALIT", m3_ALIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IFIA))
				request.WithQueryParameter("IFIA", m3_IFIA.Trim());

			// Execute the request
			var result = await Execute<LstIntItmAltResponse>(
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
		/// Name SndAddIntItmAlt
		/// Description Send Add Interface Item/Related Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_RPTY">Replacement type (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_ALIT">Related item</param>
		/// <param name="m3_IFIA">Interface releated item number</param>
		/// <param name="m3_INTC">Interchangeability</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_RATY">Reference type</param>
		/// <param name="m3_RAID">Reference identity</param>
		/// <param name="m3_QAFC">Quantity factor</param>
		/// <param name="m3_PUPN">Preferred item</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_CPYS">Copy statistics</param>
		/// <param name="m3_CNRE">Cond replacement</param>
		/// <param name="m3_CNDN">Condition</param>
		/// <param name="m3_ITAB">Item selection table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndAddIntItmAlt(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			int m3_RPTY, 
			string m3_PRMD = null, 
			string m3_ALIT = null, 
			string m3_IFIA = null, 
			int? m3_INTC = null, 
			DateTime? m3_STDT = null, 
			int? m3_RATY = null, 
			string m3_RAID = null, 
			int? m3_QAFC = null, 
			int? m3_PUPN = null, 
			decimal? m3_TXID = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			int? m3_CPYS = null, 
			int? m3_CNRE = null, 
			string m3_CNDN = null, 
			string m3_ITAB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndAddIntItmAlt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("RPTY", m3_RPTY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALIT))
				request.WithQueryParameter("ALIT", m3_ALIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IFIA))
				request.WithQueryParameter("IFIA", m3_IFIA.Trim());
			if (m3_INTC.HasValue)
				request.WithQueryParameter("INTC", m3_INTC.Value.ToString());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_RATY.HasValue)
				request.WithQueryParameter("RATY", m3_RATY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RAID))
				request.WithQueryParameter("RAID", m3_RAID.Trim());
			if (m3_QAFC.HasValue)
				request.WithQueryParameter("QAFC", m3_QAFC.Value.ToString());
			if (m3_PUPN.HasValue)
				request.WithQueryParameter("PUPN", m3_PUPN.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_CPYS.HasValue)
				request.WithQueryParameter("CPYS", m3_CPYS.Value.ToString());
			if (m3_CNRE.HasValue)
				request.WithQueryParameter("CNRE", m3_CNRE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CNDN))
				request.WithQueryParameter("CNDN", m3_CNDN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITAB))
				request.WithQueryParameter("ITAB", m3_ITAB.Trim());

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
		/// Name SndChgIntItmAlt
		/// Description Send Change Interface Item/Related Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_RPTY">Replacement type (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_ALIT">Related item</param>
		/// <param name="m3_IFIA">Interface releated item number</param>
		/// <param name="m3_INTC">Interchangeability</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_RATY">Reference type</param>
		/// <param name="m3_RAID">Reference identity</param>
		/// <param name="m3_QAFC">Quantity factor</param>
		/// <param name="m3_PUPN">Preferred item</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_STAR">Start date</param>
		/// <param name="m3_STIM">Start time</param>
		/// <param name="m3_ITFL">Item number flag</param>
		/// <param name="m3_ACFL">Add/change flag</param>
		/// <param name="m3_CPYS">Copy statistics</param>
		/// <param name="m3_CNRE">Cond replacement</param>
		/// <param name="m3_CNDN">Condition</param>
		/// <param name="m3_ITAB">Item selection table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndChgIntItmAlt(
			string m3_E0PA, 
			string m3_E065, 
			string m3_IFIN, 
			int m3_RPTY, 
			string m3_PRMD = null, 
			string m3_ALIT = null, 
			string m3_IFIA = null, 
			int? m3_INTC = null, 
			DateTime? m3_STDT = null, 
			int? m3_RATY = null, 
			string m3_RAID = null, 
			int? m3_QAFC = null, 
			int? m3_PUPN = null, 
			decimal? m3_TXID = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			DateTime? m3_STAR = null, 
			int? m3_STIM = null, 
			int? m3_ITFL = null, 
			int? m3_ACFL = null, 
			int? m3_CPYS = null, 
			int? m3_CNRE = null, 
			string m3_CNDN = null, 
			string m3_ITAB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndChgIntItmAlt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("RPTY", m3_RPTY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALIT))
				request.WithQueryParameter("ALIT", m3_ALIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IFIA))
				request.WithQueryParameter("IFIA", m3_IFIA.Trim());
			if (m3_INTC.HasValue)
				request.WithQueryParameter("INTC", m3_INTC.Value.ToString());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_RATY.HasValue)
				request.WithQueryParameter("RATY", m3_RATY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RAID))
				request.WithQueryParameter("RAID", m3_RAID.Trim());
			if (m3_QAFC.HasValue)
				request.WithQueryParameter("QAFC", m3_QAFC.Value.ToString());
			if (m3_PUPN.HasValue)
				request.WithQueryParameter("PUPN", m3_PUPN.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_STAR.HasValue)
				request.WithQueryParameter("STAR", m3_STAR.Value.ToM3String());
			if (m3_STIM.HasValue)
				request.WithQueryParameter("STIM", m3_STIM.Value.ToString());
			if (m3_ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3_ITFL.Value.ToString());
			if (m3_ACFL.HasValue)
				request.WithQueryParameter("ACFL", m3_ACFL.Value.ToString());
			if (m3_CPYS.HasValue)
				request.WithQueryParameter("CPYS", m3_CPYS.Value.ToString());
			if (m3_CNRE.HasValue)
				request.WithQueryParameter("CNRE", m3_CNRE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CNDN))
				request.WithQueryParameter("CNDN", m3_CNDN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITAB))
				request.WithQueryParameter("ITAB", m3_ITAB.Trim());

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
