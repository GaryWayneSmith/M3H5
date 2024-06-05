/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddIntItmFac
		/// Description Add Interface Item Facility
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3CSNO">Customs statistical number</param>
		/// <param name="m3ORCO">Country of origin</param>
		/// <param name="m3LEA4">Administrative lead time</param>
		/// <param name="m3REWH">Main warehouse</param>
		/// <param name="m3VAMT">Inventory accounting method</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3FATM">On-hand balance method - facility</param>
		/// <param name="m3ITFL">Item number flag</param>
		/// <param name="m3ITAB">Item selection table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddIntItmFac(
			string m3E0PA, 
			string m3E065, 
			string m3FACI, 
			string m3IFIN, 
			string m3PRMD = null, 
			string m3CSNO = null, 
			string m3ORCO = null, 
			int? m3LEA4 = null, 
			string m3REWH = null, 
			int? m3VAMT = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			decimal? m3TXID = null, 
			int? m3FATM = null, 
			int? m3ITFL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddIntItmFac",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSNO))
				request.WithQueryParameter("CSNO", m3CSNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORCO))
				request.WithQueryParameter("ORCO", m3ORCO.Trim());
			if (m3LEA4.HasValue)
				request.WithQueryParameter("LEA4", m3LEA4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REWH))
				request.WithQueryParameter("REWH", m3REWH.Trim());
			if (m3VAMT.HasValue)
				request.WithQueryParameter("VAMT", m3VAMT.Value.ToString(CultureInfo.CurrentCulture));
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
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FATM.HasValue)
				request.WithQueryParameter("FATM", m3FATM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3ITFL.Value.ToString(CultureInfo.CurrentCulture));
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
		/// Name ChgIntItmFac
		/// Description Change Interface Item facility
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3CSNO">Customs statistical number</param>
		/// <param name="m3ORCO">Country of origin</param>
		/// <param name="m3LEA4">Administrative lead time</param>
		/// <param name="m3REWH">Main warehouse</param>
		/// <param name="m3VAMT">Inventory accounting method</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3FATM">On-hand balance method - facility</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3STIM">Start time</param>
		/// <param name="m3ITFL">Item number flag</param>
		/// <param name="m3ACFL">Add/change flag</param>
		/// <param name="m3ITAB">Item selection table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgIntItmFac(
			string m3E0PA, 
			string m3E065, 
			string m3FACI, 
			string m3IFIN, 
			string m3PRMD = null, 
			string m3CSNO = null, 
			string m3ORCO = null, 
			int? m3LEA4 = null, 
			string m3REWH = null, 
			int? m3VAMT = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			decimal? m3TXID = null, 
			int? m3FATM = null, 
			DateTime? m3STDT = null, 
			int? m3STIM = null, 
			int? m3ITFL = null, 
			int? m3ACFL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgIntItmFac",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSNO))
				request.WithQueryParameter("CSNO", m3CSNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORCO))
				request.WithQueryParameter("ORCO", m3ORCO.Trim());
			if (m3LEA4.HasValue)
				request.WithQueryParameter("LEA4", m3LEA4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REWH))
				request.WithQueryParameter("REWH", m3REWH.Trim());
			if (m3VAMT.HasValue)
				request.WithQueryParameter("VAMT", m3VAMT.Value.ToString(CultureInfo.CurrentCulture));
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
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FATM.HasValue)
				request.WithQueryParameter("FATM", m3FATM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3STIM.HasValue)
				request.WithQueryParameter("STIM", m3STIM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3ITFL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACFL.HasValue)
				request.WithQueryParameter("ACFL", m3ACFL.Value.ToString(CultureInfo.CurrentCulture));
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
		/// Name CpyIntItmFac
		/// Description Copy Interface Item Facility
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3TE0P">Partner (Required)</param>
		/// <param name="m3TE06">Message type (Required)</param>
		/// <param name="m3TFAC">Facility (Required)</param>
		/// <param name="m3TFIN">Interface item number (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyIntItmFac(
			string m3E0PA, 
			string m3E065, 
			string m3FACI, 
			string m3IFIN, 
			string m3TE0P, 
			string m3TE06, 
			string m3TFAC, 
			string m3TFIN, 
			string m3PRMD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CpyIntItmFac",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));
			if (string.IsNullOrWhiteSpace(m3TE0P))
				throw new ArgumentNullException(nameof(m3TE0P));
			if (string.IsNullOrWhiteSpace(m3TE06))
				throw new ArgumentNullException(nameof(m3TE06));
			if (string.IsNullOrWhiteSpace(m3TFAC))
				throw new ArgumentNullException(nameof(m3TFAC));
			if (string.IsNullOrWhiteSpace(m3TFIN))
				throw new ArgumentNullException(nameof(m3TFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim())
				.WithQueryParameter("TE0P", m3TE0P.Trim())
				.WithQueryParameter("TE06", m3TE06.Trim())
				.WithQueryParameter("TFAC", m3TFAC.Trim())
				.WithQueryParameter("TFIN", m3TFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());

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
		/// Name DelIntItmFac
		/// Description Delete Interface Item Facility
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelIntItmFac(
			string m3E0PA, 
			string m3E065, 
			string m3FACI, 
			string m3IFIN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelIntItmFac",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim());

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
		/// Name GetIntItmFac
		/// Description Get Interface Item Facility
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetIntItmFacResponse></returns>
		/// <exception cref="M3Exception<GetIntItmFacResponse>"></exception>
		public async Task<M3Response<GetIntItmFacResponse>> GetIntItmFac(
			string m3E0PA, 
			string m3E065, 
			string m3FACI, 
			string m3IFIN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetIntItmFac",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim());

			// Execute the request
			var result = await Execute<GetIntItmFacResponse>(
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
		/// Name LstIntItmFac
		/// Description List Interface Item Facility
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner</param>
		/// <param name="m3E065">Message type</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3IFIN">Interface item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstIntItmFacResponse></returns>
		/// <exception cref="M3Exception<LstIntItmFacResponse>"></exception>
		public async Task<M3Response<LstIntItmFacResponse>> LstIntItmFac(
			string m3E0PA = null, 
			string m3E065 = null, 
			string m3FACI = null, 
			string m3IFIN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstIntItmFac",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3E0PA))
				request.WithQueryParameter("E0PA", m3E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3E065))
				request.WithQueryParameter("E065", m3E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3IFIN))
				request.WithQueryParameter("IFIN", m3IFIN.Trim());

			// Execute the request
			var result = await Execute<LstIntItmFacResponse>(
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
		/// Name SndAddIntItmFac
		/// Description Send Add Interface Item Facility
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3CSNO">Customs statistical number</param>
		/// <param name="m3ORCO">Country of origin</param>
		/// <param name="m3LEA4">Administrative lead time</param>
		/// <param name="m3REWH">Main warehouse</param>
		/// <param name="m3VAMT">Inventory accounting method</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3FATM">On-hand balance method - facility</param>
		/// <param name="m3ITFL">Item number flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndAddIntItmFac(
			string m3E0PA, 
			string m3E065, 
			string m3FACI, 
			string m3IFIN, 
			string m3PRMD = null, 
			string m3CSNO = null, 
			string m3ORCO = null, 
			int? m3LEA4 = null, 
			string m3REWH = null, 
			int? m3VAMT = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			decimal? m3TXID = null, 
			int? m3FATM = null, 
			int? m3ITFL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SndAddIntItmFac",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSNO))
				request.WithQueryParameter("CSNO", m3CSNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORCO))
				request.WithQueryParameter("ORCO", m3ORCO.Trim());
			if (m3LEA4.HasValue)
				request.WithQueryParameter("LEA4", m3LEA4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REWH))
				request.WithQueryParameter("REWH", m3REWH.Trim());
			if (m3VAMT.HasValue)
				request.WithQueryParameter("VAMT", m3VAMT.Value.ToString(CultureInfo.CurrentCulture));
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
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FATM.HasValue)
				request.WithQueryParameter("FATM", m3FATM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3ITFL.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name SndChgIntItmFac
		/// Description Send Change Interface Item facility
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3E065">Message type (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3IFIN">Interface item number (Required)</param>
		/// <param name="m3PRMD">Process flag</param>
		/// <param name="m3CSNO">Customs statistical number</param>
		/// <param name="m3ORCO">Country of origin</param>
		/// <param name="m3LEA4">Administrative lead time</param>
		/// <param name="m3REWH">Main warehouse</param>
		/// <param name="m3VAMT">Inventory accounting method</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3FATM">On-hand balance method - facility</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3STIM">Start time</param>
		/// <param name="m3ITFL">Item number flag</param>
		/// <param name="m3ACFL">Add/change flag</param>
		/// <param name="m3ITAB">Item selection table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndChgIntItmFac(
			string m3E0PA, 
			string m3E065, 
			string m3FACI, 
			string m3IFIN, 
			string m3PRMD = null, 
			string m3CSNO = null, 
			string m3ORCO = null, 
			int? m3LEA4 = null, 
			string m3REWH = null, 
			int? m3VAMT = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			decimal? m3TXID = null, 
			int? m3FATM = null, 
			DateTime? m3STDT = null, 
			int? m3STIM = null, 
			int? m3ITFL = null, 
			int? m3ACFL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SndChgIntItmFac",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3E065))
				throw new ArgumentNullException(nameof(m3E065));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3IFIN))
				throw new ArgumentNullException(nameof(m3IFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("E065", m3E065.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("IFIN", m3IFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRMD))
				request.WithQueryParameter("PRMD", m3PRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSNO))
				request.WithQueryParameter("CSNO", m3CSNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORCO))
				request.WithQueryParameter("ORCO", m3ORCO.Trim());
			if (m3LEA4.HasValue)
				request.WithQueryParameter("LEA4", m3LEA4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REWH))
				request.WithQueryParameter("REWH", m3REWH.Trim());
			if (m3VAMT.HasValue)
				request.WithQueryParameter("VAMT", m3VAMT.Value.ToString(CultureInfo.CurrentCulture));
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
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FATM.HasValue)
				request.WithQueryParameter("FATM", m3FATM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3STIM.HasValue)
				request.WithQueryParameter("STIM", m3STIM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ITFL.HasValue)
				request.WithQueryParameter("ITFL", m3ITFL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACFL.HasValue)
				request.WithQueryParameter("ACFL", m3ACFL.Value.ToString(CultureInfo.CurrentCulture));
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
