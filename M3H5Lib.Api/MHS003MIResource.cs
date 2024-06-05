/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MHS003MI;
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
	/// Name: MHS003MI
	/// Component Name: Interface Item/Facility
	/// Description: Api: Interface Item/Facility
	/// Version Release: 5ea0
	///</summary>
	public partial class MHS003MIResource : M3BaseResourceEndpoint
	{
		public MHS003MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MHS003MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddIntItmFac
		/// Description Add Interface Item Facility
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_CSNO">Customs statistical number</param>
		/// <param name="m3_ORCO">Country of origin</param>
		/// <param name="m3_LEA4">Administrative lead time</param>
		/// <param name="m3_REWH">Main warehouse</param>
		/// <param name="m3_VAMT">Inventory accounting method</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_FATM">On-hand balance method - facility</param>
		/// <param name="m3_ITFL">Item number flag</param>
		/// <param name="m3_ITAB">Item selection table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddIntItmFac(
			string m3_E0PA, 
			string m3_E065, 
			string m3_FACI, 
			string m3_IFIN, 
			string m3_PRMD = null, 
			string m3_CSNO = null, 
			string m3_ORCO = null, 
			int? m3_LEA4 = null, 
			string m3_REWH = null, 
			int? m3_VAMT = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_TXID = null, 
			int? m3_FATM = null, 
			int? m3_ITFL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddIntItmFac",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSNO))
				request.WithQueryParameter("CSNO", m3_CSNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (m3_LEA4.HasValue)
				request.WithQueryParameter("LEA4", m3_LEA4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REWH))
				request.WithQueryParameter("REWH", m3_REWH.Trim());
			if (m3_VAMT.HasValue)
				request.WithQueryParameter("VAMT", m3_VAMT.Value.ToString());
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
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_FATM.HasValue)
				request.WithQueryParameter("FATM", m3_FATM.Value.ToString());
			if (m3_ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3_ITFL.Value.ToString());
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
		/// Name ChgIntItmFac
		/// Description Change Interface Item facility
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_CSNO">Customs statistical number</param>
		/// <param name="m3_ORCO">Country of origin</param>
		/// <param name="m3_LEA4">Administrative lead time</param>
		/// <param name="m3_REWH">Main warehouse</param>
		/// <param name="m3_VAMT">Inventory accounting method</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_FATM">On-hand balance method - facility</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STIM">Start time</param>
		/// <param name="m3_ITFL">Item number flag</param>
		/// <param name="m3_ACFL">Add/change flag</param>
		/// <param name="m3_ITAB">Item selection table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgIntItmFac(
			string m3_E0PA, 
			string m3_E065, 
			string m3_FACI, 
			string m3_IFIN, 
			string m3_PRMD = null, 
			string m3_CSNO = null, 
			string m3_ORCO = null, 
			int? m3_LEA4 = null, 
			string m3_REWH = null, 
			int? m3_VAMT = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_TXID = null, 
			int? m3_FATM = null, 
			DateTime? m3_STDT = null, 
			int? m3_STIM = null, 
			int? m3_ITFL = null, 
			int? m3_ACFL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgIntItmFac",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSNO))
				request.WithQueryParameter("CSNO", m3_CSNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (m3_LEA4.HasValue)
				request.WithQueryParameter("LEA4", m3_LEA4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REWH))
				request.WithQueryParameter("REWH", m3_REWH.Trim());
			if (m3_VAMT.HasValue)
				request.WithQueryParameter("VAMT", m3_VAMT.Value.ToString());
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
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_FATM.HasValue)
				request.WithQueryParameter("FATM", m3_FATM.Value.ToString());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STIM.HasValue)
				request.WithQueryParameter("STIM", m3_STIM.Value.ToString());
			if (m3_ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3_ITFL.Value.ToString());
			if (m3_ACFL.HasValue)
				request.WithQueryParameter("ACFL", m3_ACFL.Value.ToString());
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
		/// Name CpyIntItmFac
		/// Description Copy Interface Item Facility
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_TE0P">Partner (Required)</param>
		/// <param name="m3_TE06">Message type (Required)</param>
		/// <param name="m3_TFAC">Facility (Required)</param>
		/// <param name="m3_TFIN">Interface item number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyIntItmFac(
			string m3_E0PA, 
			string m3_E065, 
			string m3_FACI, 
			string m3_IFIN, 
			string m3_TE0P, 
			string m3_TE06, 
			string m3_TFAC, 
			string m3_TFIN, 
			string m3_PRMD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyIntItmFac",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");
			if (string.IsNullOrWhiteSpace(m3_TE0P))
				throw new ArgumentNullException("m3_TE0P");
			if (string.IsNullOrWhiteSpace(m3_TE06))
				throw new ArgumentNullException("m3_TE06");
			if (string.IsNullOrWhiteSpace(m3_TFAC))
				throw new ArgumentNullException("m3_TFAC");
			if (string.IsNullOrWhiteSpace(m3_TFIN))
				throw new ArgumentNullException("m3_TFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim())
				.WithQueryParameter("TE0P", m3_TE0P.Trim())
				.WithQueryParameter("TE06", m3_TE06.Trim())
				.WithQueryParameter("TFAC", m3_TFAC.Trim())
				.WithQueryParameter("TFIN", m3_TFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());

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
		/// Name DelIntItmFac
		/// Description Delete Interface Item Facility
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelIntItmFac(
			string m3_E0PA, 
			string m3_E065, 
			string m3_FACI, 
			string m3_IFIN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelIntItmFac",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim());

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
		/// Name GetIntItmFac
		/// Description Get Interface Item Facility
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetIntItmFacResponse></returns>
		/// <exception cref="M3Exception<GetIntItmFacResponse>"></exception>
		public async Task<M3Response<GetIntItmFacResponse>> GetIntItmFac(
			string m3_E0PA, 
			string m3_E065, 
			string m3_FACI, 
			string m3_IFIN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetIntItmFac",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim());

			// Execute the request
			var result = await Execute<GetIntItmFacResponse>(
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
		/// Name LstIntItmFac
		/// Description List Interface Item Facility
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner</param>
		/// <param name="m3_E065">Message type</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_IFIN">Interface item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstIntItmFacResponse></returns>
		/// <exception cref="M3Exception<LstIntItmFacResponse>"></exception>
		public async Task<M3Response<LstIntItmFacResponse>> LstIntItmFac(
			string m3_E0PA = null, 
			string m3_E065 = null, 
			string m3_FACI = null, 
			string m3_IFIN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstIntItmFac",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_E0PA))
				request.WithQueryParameter("E0PA", m3_E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E065))
				request.WithQueryParameter("E065", m3_E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IFIN))
				request.WithQueryParameter("IFIN", m3_IFIN.Trim());

			// Execute the request
			var result = await Execute<LstIntItmFacResponse>(
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
		/// Name SndAddIntItmFac
		/// Description Send Add Interface Item Facility
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_CSNO">Customs statistical number</param>
		/// <param name="m3_ORCO">Country of origin</param>
		/// <param name="m3_LEA4">Administrative lead time</param>
		/// <param name="m3_REWH">Main warehouse</param>
		/// <param name="m3_VAMT">Inventory accounting method</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_FATM">On-hand balance method - facility</param>
		/// <param name="m3_ITFL">Item number flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndAddIntItmFac(
			string m3_E0PA, 
			string m3_E065, 
			string m3_FACI, 
			string m3_IFIN, 
			string m3_PRMD = null, 
			string m3_CSNO = null, 
			string m3_ORCO = null, 
			int? m3_LEA4 = null, 
			string m3_REWH = null, 
			int? m3_VAMT = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_TXID = null, 
			int? m3_FATM = null, 
			int? m3_ITFL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndAddIntItmFac",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSNO))
				request.WithQueryParameter("CSNO", m3_CSNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (m3_LEA4.HasValue)
				request.WithQueryParameter("LEA4", m3_LEA4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REWH))
				request.WithQueryParameter("REWH", m3_REWH.Trim());
			if (m3_VAMT.HasValue)
				request.WithQueryParameter("VAMT", m3_VAMT.Value.ToString());
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
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_FATM.HasValue)
				request.WithQueryParameter("FATM", m3_FATM.Value.ToString());
			if (m3_ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3_ITFL.Value.ToString());

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
		/// Name SndChgIntItmFac
		/// Description Send Change Interface Item facility
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_E065">Message type (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_IFIN">Interface item number (Required)</param>
		/// <param name="m3_PRMD">Process flag</param>
		/// <param name="m3_CSNO">Customs statistical number</param>
		/// <param name="m3_ORCO">Country of origin</param>
		/// <param name="m3_LEA4">Administrative lead time</param>
		/// <param name="m3_REWH">Main warehouse</param>
		/// <param name="m3_VAMT">Inventory accounting method</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_FATM">On-hand balance method - facility</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STIM">Start time</param>
		/// <param name="m3_ITFL">Item number flag</param>
		/// <param name="m3_ACFL">Add/change flag</param>
		/// <param name="m3_ITAB">Item selection table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndChgIntItmFac(
			string m3_E0PA, 
			string m3_E065, 
			string m3_FACI, 
			string m3_IFIN, 
			string m3_PRMD = null, 
			string m3_CSNO = null, 
			string m3_ORCO = null, 
			int? m3_LEA4 = null, 
			string m3_REWH = null, 
			int? m3_VAMT = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_TXID = null, 
			int? m3_FATM = null, 
			DateTime? m3_STDT = null, 
			int? m3_STIM = null, 
			int? m3_ITFL = null, 
			int? m3_ACFL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndChgIntItmFac",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_E065))
				throw new ArgumentNullException("m3_E065");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_IFIN))
				throw new ArgumentNullException("m3_IFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("E065", m3_E065.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("IFIN", m3_IFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRMD))
				request.WithQueryParameter("PRMD", m3_PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSNO))
				request.WithQueryParameter("CSNO", m3_CSNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (m3_LEA4.HasValue)
				request.WithQueryParameter("LEA4", m3_LEA4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REWH))
				request.WithQueryParameter("REWH", m3_REWH.Trim());
			if (m3_VAMT.HasValue)
				request.WithQueryParameter("VAMT", m3_VAMT.Value.ToString());
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
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_FATM.HasValue)
				request.WithQueryParameter("FATM", m3_FATM.Value.ToString());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STIM.HasValue)
				request.WithQueryParameter("STIM", m3_STIM.Value.ToString());
			if (m3_ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3_ITFL.Value.ToString());
			if (m3_ACFL.HasValue)
				request.WithQueryParameter("ACFL", m3_ACFL.Value.ToString());
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
