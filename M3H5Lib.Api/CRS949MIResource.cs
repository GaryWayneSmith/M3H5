/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS949MI;
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
	/// Name: CRS949MI
	/// Component Name: Partner Reference - Media
	/// Description: API: Partner Reference - Media
	/// Version Release: 5ea0
	///</summary>
	public partial class CRS949MIResource : M3BaseResourceEndpoint
	{
		public CRS949MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS949MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddPartnerEmail
		/// Description Add new document/partner - email connection
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DONR">Document number (Required)</param>
		/// <param name="m3_MEDC">Media (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="m3_MEPF">Media profile</param>
		/// <param name="m3_PRF1">Document/media controlling object 1</param>
		/// <param name="m3_PRF2">Document/media control object 2</param>
		/// <param name="m3_SIID">Service identity</param>
		/// <param name="m3_FMTP">Paper Size</param>
		/// <param name="m3_TFT1">Fax text 1</param>
		/// <param name="m3_FLRN">Folder name</param>
		/// <param name="m3_TOMA">To email address</param>
		/// <param name="m3_FRMA">From email address</param>
		/// <param name="m3_CCMA">Copy to email address</param>
		/// <param name="m3_SUBJ">Subject</param>
		/// <param name="m3_NOTE">Note</param>
		/// <param name="m3_CPPL">Copy</param>
		/// <param name="m3_LAYC">Modification</param>
		/// <param name="m3_MARI">Country</param>
		/// <param name="m3_ARCH">Archiving</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPartnerEmail(
			string m3_DONR, 
			string m3_MEDC, 
			string m3_DIVI = null, 
			string m3_DOVA = null, 
			string m3_MEPF = null, 
			string m3_PRF1 = null, 
			string m3_PRF2 = null, 
			string m3_SIID = null, 
			string m3_FMTP = null, 
			string m3_TFT1 = null, 
			string m3_FLRN = null, 
			string m3_TOMA = null, 
			string m3_FRMA = null, 
			string m3_CCMA = null, 
			string m3_SUBJ = null, 
			string m3_NOTE = null, 
			int? m3_CPPL = null, 
			string m3_LAYC = null, 
			string m3_MARI = null, 
			int? m3_ARCH = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPartnerEmail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DONR))
				throw new ArgumentNullException("m3_DONR");
			if (string.IsNullOrWhiteSpace(m3_MEDC))
				throw new ArgumentNullException("m3_MEDC");

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3_DONR.Trim())
				.WithQueryParameter("MEDC", m3_MEDC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEPF))
				request.WithQueryParameter("MEPF", m3_MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF1))
				request.WithQueryParameter("PRF1", m3_PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF2))
				request.WithQueryParameter("PRF2", m3_PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SIID))
				request.WithQueryParameter("SIID", m3_SIID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMTP))
				request.WithQueryParameter("FMTP", m3_FMTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFT1))
				request.WithQueryParameter("TFT1", m3_TFT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLRN))
				request.WithQueryParameter("FLRN", m3_FLRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOMA))
				request.WithQueryParameter("TOMA", m3_TOMA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRMA))
				request.WithQueryParameter("FRMA", m3_FRMA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CCMA))
				request.WithQueryParameter("CCMA", m3_CCMA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUBJ))
				request.WithQueryParameter("SUBJ", m3_SUBJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NOTE))
				request.WithQueryParameter("NOTE", m3_NOTE.Trim());
			if (m3_CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3_CPPL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LAYC))
				request.WithQueryParameter("LAYC", m3_LAYC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MARI))
				request.WithQueryParameter("MARI", m3_MARI.Trim());
			if (m3_ARCH.HasValue)
				request.WithQueryParameter("ARCH", m3_ARCH.Value.ToString());

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
		/// Name AddPartnerEvent
		/// Description Add new document/partner - event connection
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DONR">Document number (Required)</param>
		/// <param name="m3_MEDC">Media (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="m3_MEPF">Media profile</param>
		/// <param name="m3_PRF1">Document/media controlling object 1</param>
		/// <param name="m3_PRF2">Document/media control object 2</param>
		/// <param name="m3_CPPL">Copy</param>
		/// <param name="m3_TEME">Test flag</param>
		/// <param name="m3_RRD1">Receiver reference data 1</param>
		/// <param name="m3_RRD2">Receiver reference data 2</param>
		/// <param name="m3_RRD3">Receiver reference data 3</param>
		/// <param name="m3_CNID">Connector ID</param>
		/// <param name="m3_EVPR">Event priority</param>
		/// <param name="m3_BONM">Business object name</param>
		/// <param name="m3_BOVB">Event verb</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPartnerEvent(
			string m3_DONR, 
			string m3_MEDC, 
			string m3_DIVI = null, 
			string m3_DOVA = null, 
			string m3_MEPF = null, 
			string m3_PRF1 = null, 
			string m3_PRF2 = null, 
			int? m3_CPPL = null, 
			int? m3_TEME = null, 
			string m3_RRD1 = null, 
			string m3_RRD2 = null, 
			string m3_RRD3 = null, 
			int? m3_CNID = null, 
			int? m3_EVPR = null, 
			string m3_BONM = null, 
			string m3_BOVB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPartnerEvent",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DONR))
				throw new ArgumentNullException("m3_DONR");
			if (string.IsNullOrWhiteSpace(m3_MEDC))
				throw new ArgumentNullException("m3_MEDC");

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3_DONR.Trim())
				.WithQueryParameter("MEDC", m3_MEDC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEPF))
				request.WithQueryParameter("MEPF", m3_MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF1))
				request.WithQueryParameter("PRF1", m3_PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF2))
				request.WithQueryParameter("PRF2", m3_PRF2.Trim());
			if (m3_CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3_CPPL.Value.ToString());
			if (m3_TEME.HasValue)
				request.WithQueryParameter("TEME", m3_TEME.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RRD1))
				request.WithQueryParameter("RRD1", m3_RRD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RRD2))
				request.WithQueryParameter("RRD2", m3_RRD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RRD3))
				request.WithQueryParameter("RRD3", m3_RRD3.Trim());
			if (m3_CNID.HasValue)
				request.WithQueryParameter("CNID", m3_CNID.Value.ToString());
			if (m3_EVPR.HasValue)
				request.WithQueryParameter("EVPR", m3_EVPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BONM))
				request.WithQueryParameter("BONM", m3_BONM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BOVB))
				request.WithQueryParameter("BOVB", m3_BOVB.Trim());

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
		/// Name AddPartnerFax
		/// Description Add new document/partner - fax connection
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DONR">Document number (Required)</param>
		/// <param name="m3_MEDC">Media (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="m3_MEPF">Media profile</param>
		/// <param name="m3_PRF1">Document/media controlling object 1</param>
		/// <param name="m3_PRF2">Document/media control object 2</param>
		/// <param name="m3_SIID">Service identity</param>
		/// <param name="m3_FMTP">Paper size</param>
		/// <param name="m3_OUTP">Priority</param>
		/// <param name="m3_UDTA">User data</param>
		/// <param name="m3_1UDT">Field selection</param>
		/// <param name="m3_TFNO">Facsimile transmission number</param>
		/// <param name="m3_TFT1">Fax text 1</param>
		/// <param name="m3_1TFT">Field selection</param>
		/// <param name="m3_FLRN">Folder name</param>
		/// <param name="m3_FAXT">Send time - fax</param>
		/// <param name="m3_SUBJ">Subject</param>
		/// <param name="m3_NOTE">Note</param>
		/// <param name="m3_CPPL">Copy</param>
		/// <param name="m3_LAYC">Modification</param>
		/// <param name="m3_MARI">Country</param>
		/// <param name="m3_ARCH">Archive</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPartnerFax(
			string m3_DONR, 
			string m3_MEDC, 
			string m3_DIVI = null, 
			string m3_DOVA = null, 
			string m3_MEPF = null, 
			string m3_PRF1 = null, 
			string m3_PRF2 = null, 
			string m3_SIID = null, 
			string m3_FMTP = null, 
			string m3_OUTP = null, 
			string m3_UDTA = null, 
			string m3_1UDT = null, 
			string m3_TFNO = null, 
			string m3_TFT1 = null, 
			string m3_1TFT = null, 
			string m3_FLRN = null, 
			int? m3_FAXT = null, 
			string m3_SUBJ = null, 
			string m3_NOTE = null, 
			int? m3_CPPL = null, 
			string m3_LAYC = null, 
			string m3_MARI = null, 
			int? m3_ARCH = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPartnerFax",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DONR))
				throw new ArgumentNullException("m3_DONR");
			if (string.IsNullOrWhiteSpace(m3_MEDC))
				throw new ArgumentNullException("m3_MEDC");

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3_DONR.Trim())
				.WithQueryParameter("MEDC", m3_MEDC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEPF))
				request.WithQueryParameter("MEPF", m3_MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF1))
				request.WithQueryParameter("PRF1", m3_PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF2))
				request.WithQueryParameter("PRF2", m3_PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SIID))
				request.WithQueryParameter("SIID", m3_SIID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMTP))
				request.WithQueryParameter("FMTP", m3_FMTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OUTP))
				request.WithQueryParameter("OUTP", m3_OUTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UDTA))
				request.WithQueryParameter("UDTA", m3_UDTA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_1UDT))
				request.WithQueryParameter("1UDT", m3_1UDT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFT1))
				request.WithQueryParameter("TFT1", m3_TFT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_1TFT))
				request.WithQueryParameter("1TFT", m3_1TFT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLRN))
				request.WithQueryParameter("FLRN", m3_FLRN.Trim());
			if (m3_FAXT.HasValue)
				request.WithQueryParameter("FAXT", m3_FAXT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUBJ))
				request.WithQueryParameter("SUBJ", m3_SUBJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NOTE))
				request.WithQueryParameter("NOTE", m3_NOTE.Trim());
			if (m3_CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3_CPPL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LAYC))
				request.WithQueryParameter("LAYC", m3_LAYC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MARI))
				request.WithQueryParameter("MARI", m3_MARI.Trim());
			if (m3_ARCH.HasValue)
				request.WithQueryParameter("ARCH", m3_ARCH.Value.ToString());

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
		/// Name AddPartnerFile
		/// Description Add new document/partner - file connection
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DONR">Document number (Required)</param>
		/// <param name="m3_MEDC">Media (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="m3_MEPF">Media profile</param>
		/// <param name="m3_PRF1">Document/media controlling object 1</param>
		/// <param name="m3_PRF2">Document/media control object 2</param>
		/// <param name="m3_SIID">Service identity</param>
		/// <param name="m3_FMTP">Paper size</param>
		/// <param name="m3_FLRN">Folder name</param>
		/// <param name="m3_PAFD">File path</param>
		/// <param name="m3_FSUX">File suffix</param>
		/// <param name="m3_GNNM">Generic name method</param>
		/// <param name="m3_CPPL">Copy</param>
		/// <param name="m3_LAYC">Modification</param>
		/// <param name="m3_MARI">Country</param>
		/// <param name="m3_ARCH">Archive</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPartnerFile(
			string m3_DONR, 
			string m3_MEDC, 
			string m3_DIVI = null, 
			string m3_DOVA = null, 
			string m3_MEPF = null, 
			string m3_PRF1 = null, 
			string m3_PRF2 = null, 
			string m3_SIID = null, 
			string m3_FMTP = null, 
			string m3_FLRN = null, 
			string m3_PAFD = null, 
			string m3_FSUX = null, 
			int? m3_GNNM = null, 
			int? m3_CPPL = null, 
			string m3_LAYC = null, 
			string m3_MARI = null, 
			int? m3_ARCH = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPartnerFile",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DONR))
				throw new ArgumentNullException("m3_DONR");
			if (string.IsNullOrWhiteSpace(m3_MEDC))
				throw new ArgumentNullException("m3_MEDC");

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3_DONR.Trim())
				.WithQueryParameter("MEDC", m3_MEDC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEPF))
				request.WithQueryParameter("MEPF", m3_MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF1))
				request.WithQueryParameter("PRF1", m3_PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF2))
				request.WithQueryParameter("PRF2", m3_PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SIID))
				request.WithQueryParameter("SIID", m3_SIID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMTP))
				request.WithQueryParameter("FMTP", m3_FMTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLRN))
				request.WithQueryParameter("FLRN", m3_FLRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAFD))
				request.WithQueryParameter("PAFD", m3_PAFD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FSUX))
				request.WithQueryParameter("FSUX", m3_FSUX.Trim());
			if (m3_GNNM.HasValue)
				request.WithQueryParameter("GNNM", m3_GNNM.Value.ToString());
			if (m3_CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3_CPPL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LAYC))
				request.WithQueryParameter("LAYC", m3_LAYC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MARI))
				request.WithQueryParameter("MARI", m3_MARI.Trim());
			if (m3_ARCH.HasValue)
				request.WithQueryParameter("ARCH", m3_ARCH.Value.ToString());

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
		/// Name AddPartnerMBM
		/// Description Add new document/partner - MBM connection
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DONR">Document number (Required)</param>
		/// <param name="m3_MEDC">Media (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="m3_MEPF">Media profile</param>
		/// <param name="m3_PRF1">Document/media controlling object 1</param>
		/// <param name="m3_PRF2">Document/media control object 2</param>
		/// <param name="m3_SIID">Service identity</param>
		/// <param name="m3_CPPL">Copy</param>
		/// <param name="m3_TEME">Test flag</param>
		/// <param name="m3_SRD1">Sender reference data 1</param>
		/// <param name="m3_SRD2">Sender reference data 2</param>
		/// <param name="m3_RRD1">Receiver reference data 1</param>
		/// <param name="m3_RRD2">Receiver reference data 2</param>
		/// <param name="m3_RRD3">Receiver reference data 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPartnerMBM(
			string m3_DONR, 
			string m3_MEDC, 
			string m3_DIVI = null, 
			string m3_DOVA = null, 
			string m3_MEPF = null, 
			string m3_PRF1 = null, 
			string m3_PRF2 = null, 
			string m3_SIID = null, 
			int? m3_CPPL = null, 
			int? m3_TEME = null, 
			string m3_SRD1 = null, 
			string m3_SRD2 = null, 
			string m3_RRD1 = null, 
			string m3_RRD2 = null, 
			string m3_RRD3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPartnerMBM",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DONR))
				throw new ArgumentNullException("m3_DONR");
			if (string.IsNullOrWhiteSpace(m3_MEDC))
				throw new ArgumentNullException("m3_MEDC");

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3_DONR.Trim())
				.WithQueryParameter("MEDC", m3_MEDC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEPF))
				request.WithQueryParameter("MEPF", m3_MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF1))
				request.WithQueryParameter("PRF1", m3_PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF2))
				request.WithQueryParameter("PRF2", m3_PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SIID))
				request.WithQueryParameter("SIID", m3_SIID.Trim());
			if (m3_CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3_CPPL.Value.ToString());
			if (m3_TEME.HasValue)
				request.WithQueryParameter("TEME", m3_TEME.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SRD1))
				request.WithQueryParameter("SRD1", m3_SRD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRD2))
				request.WithQueryParameter("SRD2", m3_SRD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RRD1))
				request.WithQueryParameter("RRD1", m3_RRD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RRD2))
				request.WithQueryParameter("RRD2", m3_RRD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RRD3))
				request.WithQueryParameter("RRD3", m3_RRD3.Trim());

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
		/// Name AddPartnerPrint
		/// Description Add new document/partner - print connection
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DONR">Document number (Required)</param>
		/// <param name="m3_MEDC">Media (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="m3_MEPF">Media profile</param>
		/// <param name="m3_PRF1">Document/media controlling object 1</param>
		/// <param name="m3_PRF2">Document/media control object 2</param>
		/// <param name="m3_SIID">Service identity</param>
		/// <param name="m3_FMTP">Paper size</param>
		/// <param name="m3_COPY">Number of copies</param>
		/// <param name="m3_DEV">Printer</param>
		/// <param name="m3_FOVR">Overlay front page name</param>
		/// <param name="m3_BINX">Bin</param>
		/// <param name="m3_CPPL">Copy</param>
		/// <param name="m3_TRAY">Tray</param>
		/// <param name="m3_LAYC">Modification</param>
		/// <param name="m3_MARI">Country</param>
		/// <param name="m3_ARCH">Archive</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPartnerPrint(
			string m3_DONR, 
			string m3_MEDC, 
			string m3_DIVI = null, 
			string m3_DOVA = null, 
			string m3_MEPF = null, 
			string m3_PRF1 = null, 
			string m3_PRF2 = null, 
			string m3_SIID = null, 
			string m3_FMTP = null, 
			int? m3_COPY = null, 
			string m3_DEV = null, 
			string m3_FOVR = null, 
			string m3_BINX = null, 
			int? m3_CPPL = null, 
			string m3_TRAY = null, 
			string m3_LAYC = null, 
			string m3_MARI = null, 
			int? m3_ARCH = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPartnerPrint",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DONR))
				throw new ArgumentNullException("m3_DONR");
			if (string.IsNullOrWhiteSpace(m3_MEDC))
				throw new ArgumentNullException("m3_MEDC");

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3_DONR.Trim())
				.WithQueryParameter("MEDC", m3_MEDC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEPF))
				request.WithQueryParameter("MEPF", m3_MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF1))
				request.WithQueryParameter("PRF1", m3_PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF2))
				request.WithQueryParameter("PRF2", m3_PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SIID))
				request.WithQueryParameter("SIID", m3_SIID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMTP))
				request.WithQueryParameter("FMTP", m3_FMTP.Trim());
			if (m3_COPY.HasValue)
				request.WithQueryParameter("COPY", m3_COPY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DEV))
				request.WithQueryParameter("DEV", m3_DEV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FOVR))
				request.WithQueryParameter("FOVR", m3_FOVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BINX))
				request.WithQueryParameter("BINX", m3_BINX.Trim());
			if (m3_CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3_CPPL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TRAY))
				request.WithQueryParameter("TRAY", m3_TRAY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LAYC))
				request.WithQueryParameter("LAYC", m3_LAYC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MARI))
				request.WithQueryParameter("MARI", m3_MARI.Trim());
			if (m3_ARCH.HasValue)
				request.WithQueryParameter("ARCH", m3_ARCH.Value.ToString());

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
		/// Name DltPartnerMedia
		/// Description Delete document/partner - media connection
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DONR">Document number (Required)</param>
		/// <param name="m3_MEDC">Media (Required)</param>
		/// <param name="m3_SEQN">Sequence number (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="m3_MEPF">Media profile</param>
		/// <param name="m3_PRF1">Document/media controlling object 1</param>
		/// <param name="m3_PRF2">Document/media control object 2</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltPartnerMedia(
			string m3_DONR, 
			string m3_MEDC, 
			int m3_SEQN, 
			string m3_DIVI = null, 
			string m3_DOVA = null, 
			string m3_MEPF = null, 
			string m3_PRF1 = null, 
			string m3_PRF2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltPartnerMedia",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DONR))
				throw new ArgumentNullException("m3_DONR");
			if (string.IsNullOrWhiteSpace(m3_MEDC))
				throw new ArgumentNullException("m3_MEDC");

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3_DONR.Trim())
				.WithQueryParameter("MEDC", m3_MEDC.Trim())
				.WithQueryParameter("SEQN", m3_SEQN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEPF))
				request.WithQueryParameter("MEPF", m3_MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF1))
				request.WithQueryParameter("PRF1", m3_PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF2))
				request.WithQueryParameter("PRF2", m3_PRF2.Trim());

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
		/// Name GetPartnerMedia
		/// Description Get a document/partner - media connection record
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_DONR">Document number</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="m3_MEPF">Media profile</param>
		/// <param name="m3_PRF1">Document/media controlling object 1</param>
		/// <param name="m3_PRF2">Document/media control object 2</param>
		/// <param name="m3_MEDC">Media</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPartnerMediaResponse></returns>
		/// <exception cref="M3Exception<GetPartnerMediaResponse>"></exception>
		public async Task<M3Response<GetPartnerMediaResponse>> GetPartnerMedia(
			string m3_DIVI = null, 
			string m3_DONR = null, 
			string m3_DOVA = null, 
			string m3_MEPF = null, 
			string m3_PRF1 = null, 
			string m3_PRF2 = null, 
			string m3_MEDC = null, 
			int? m3_SEQN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPartnerMedia",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DONR))
				request.WithQueryParameter("DONR", m3_DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEPF))
				request.WithQueryParameter("MEPF", m3_MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF1))
				request.WithQueryParameter("PRF1", m3_PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF2))
				request.WithQueryParameter("PRF2", m3_PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEDC))
				request.WithQueryParameter("MEDC", m3_MEDC.Trim());
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());

			// Execute the request
			var result = await Execute<GetPartnerMediaResponse>(
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
		/// Name LstPartnerMedia
		/// Description List documents/partner - media connection records
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_DONR">Document number</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="m3_MEPF">Media profile</param>
		/// <param name="m3_PRF1">Document/media controlling object 1</param>
		/// <param name="m3_PRF2">Document/media control object 2</param>
		/// <param name="m3_MEDC">Media</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPartnerMediaResponse></returns>
		/// <exception cref="M3Exception<LstPartnerMediaResponse>"></exception>
		public async Task<M3Response<LstPartnerMediaResponse>> LstPartnerMedia(
			string m3_DIVI = null, 
			string m3_DONR = null, 
			string m3_DOVA = null, 
			string m3_MEPF = null, 
			string m3_PRF1 = null, 
			string m3_PRF2 = null, 
			string m3_MEDC = null, 
			int? m3_SEQN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPartnerMedia",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DONR))
				request.WithQueryParameter("DONR", m3_DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEPF))
				request.WithQueryParameter("MEPF", m3_MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF1))
				request.WithQueryParameter("PRF1", m3_PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF2))
				request.WithQueryParameter("PRF2", m3_PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEDC))
				request.WithQueryParameter("MEDC", m3_MEDC.Trim());
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());

			// Execute the request
			var result = await Execute<LstPartnerMediaResponse>(
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
		/// Name UpdPartnerEmail
		/// Description Update document/partner - email connection
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DONR">Document number (Required)</param>
		/// <param name="m3_MEDC">Media (Required)</param>
		/// <param name="m3_SEQN">Sequence number (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="m3_MEPF">Media profile</param>
		/// <param name="m3_PRF1">Document/media controlling object 1</param>
		/// <param name="m3_PRF2">Document/media control object 2</param>
		/// <param name="m3_SIID">Service identity</param>
		/// <param name="m3_FMTP">Paper Size</param>
		/// <param name="m3_TFT1">Fax text 1</param>
		/// <param name="m3_FLRN">Folder name</param>
		/// <param name="m3_TOMA">To email address</param>
		/// <param name="m3_FRMA">From email address</param>
		/// <param name="m3_CCMA">Copy to email address</param>
		/// <param name="m3_SUBJ">Subject</param>
		/// <param name="m3_NOTE">Note</param>
		/// <param name="m3_CPPL">Copy</param>
		/// <param name="m3_LAYC">Modification</param>
		/// <param name="m3_MARI">Country</param>
		/// <param name="m3_ARCH">Archiving</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPartnerEmail(
			string m3_DONR, 
			string m3_MEDC, 
			int m3_SEQN, 
			string m3_DIVI = null, 
			string m3_DOVA = null, 
			string m3_MEPF = null, 
			string m3_PRF1 = null, 
			string m3_PRF2 = null, 
			string m3_SIID = null, 
			string m3_FMTP = null, 
			string m3_TFT1 = null, 
			string m3_FLRN = null, 
			string m3_TOMA = null, 
			string m3_FRMA = null, 
			string m3_CCMA = null, 
			string m3_SUBJ = null, 
			string m3_NOTE = null, 
			int? m3_CPPL = null, 
			string m3_LAYC = null, 
			string m3_MARI = null, 
			int? m3_ARCH = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdPartnerEmail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DONR))
				throw new ArgumentNullException("m3_DONR");
			if (string.IsNullOrWhiteSpace(m3_MEDC))
				throw new ArgumentNullException("m3_MEDC");

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3_DONR.Trim())
				.WithQueryParameter("MEDC", m3_MEDC.Trim())
				.WithQueryParameter("SEQN", m3_SEQN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEPF))
				request.WithQueryParameter("MEPF", m3_MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF1))
				request.WithQueryParameter("PRF1", m3_PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF2))
				request.WithQueryParameter("PRF2", m3_PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SIID))
				request.WithQueryParameter("SIID", m3_SIID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMTP))
				request.WithQueryParameter("FMTP", m3_FMTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFT1))
				request.WithQueryParameter("TFT1", m3_TFT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLRN))
				request.WithQueryParameter("FLRN", m3_FLRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOMA))
				request.WithQueryParameter("TOMA", m3_TOMA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRMA))
				request.WithQueryParameter("FRMA", m3_FRMA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CCMA))
				request.WithQueryParameter("CCMA", m3_CCMA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUBJ))
				request.WithQueryParameter("SUBJ", m3_SUBJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NOTE))
				request.WithQueryParameter("NOTE", m3_NOTE.Trim());
			if (m3_CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3_CPPL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LAYC))
				request.WithQueryParameter("LAYC", m3_LAYC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MARI))
				request.WithQueryParameter("MARI", m3_MARI.Trim());
			if (m3_ARCH.HasValue)
				request.WithQueryParameter("ARCH", m3_ARCH.Value.ToString());

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
		/// Name UpdPartnerEvent
		/// Description Update document/partner - event connection
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DONR">Document number (Required)</param>
		/// <param name="m3_MEDC">Media (Required)</param>
		/// <param name="m3_SEQN">Sequence number (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="m3_MEPF">Media profile</param>
		/// <param name="m3_PRF1">Document/media controlling object 1</param>
		/// <param name="m3_PRF2">Document/media control object 2</param>
		/// <param name="m3_CPPL">Copy</param>
		/// <param name="m3_TEME">Test flag</param>
		/// <param name="m3_RRD1">Receiver reference data 1</param>
		/// <param name="m3_RRD2">Receiver reference data 2</param>
		/// <param name="m3_RRD3">Receiver reference data 3</param>
		/// <param name="m3_CNID">Connector ID</param>
		/// <param name="m3_EVPR">Event priority</param>
		/// <param name="m3_BONM">Business object name</param>
		/// <param name="m3_BOVB">Event verb</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPartnerEvent(
			string m3_DONR, 
			string m3_MEDC, 
			int m3_SEQN, 
			string m3_DIVI = null, 
			string m3_DOVA = null, 
			string m3_MEPF = null, 
			string m3_PRF1 = null, 
			string m3_PRF2 = null, 
			int? m3_CPPL = null, 
			int? m3_TEME = null, 
			string m3_RRD1 = null, 
			string m3_RRD2 = null, 
			string m3_RRD3 = null, 
			int? m3_CNID = null, 
			int? m3_EVPR = null, 
			string m3_BONM = null, 
			string m3_BOVB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdPartnerEvent",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DONR))
				throw new ArgumentNullException("m3_DONR");
			if (string.IsNullOrWhiteSpace(m3_MEDC))
				throw new ArgumentNullException("m3_MEDC");

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3_DONR.Trim())
				.WithQueryParameter("MEDC", m3_MEDC.Trim())
				.WithQueryParameter("SEQN", m3_SEQN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEPF))
				request.WithQueryParameter("MEPF", m3_MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF1))
				request.WithQueryParameter("PRF1", m3_PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF2))
				request.WithQueryParameter("PRF2", m3_PRF2.Trim());
			if (m3_CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3_CPPL.Value.ToString());
			if (m3_TEME.HasValue)
				request.WithQueryParameter("TEME", m3_TEME.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RRD1))
				request.WithQueryParameter("RRD1", m3_RRD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RRD2))
				request.WithQueryParameter("RRD2", m3_RRD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RRD3))
				request.WithQueryParameter("RRD3", m3_RRD3.Trim());
			if (m3_CNID.HasValue)
				request.WithQueryParameter("CNID", m3_CNID.Value.ToString());
			if (m3_EVPR.HasValue)
				request.WithQueryParameter("EVPR", m3_EVPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BONM))
				request.WithQueryParameter("BONM", m3_BONM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BOVB))
				request.WithQueryParameter("BOVB", m3_BOVB.Trim());

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
		/// Name UpdPartnerFax
		/// Description Update document/partner - fax connection
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DONR">Document number (Required)</param>
		/// <param name="m3_MEDC">Media (Required)</param>
		/// <param name="m3_SEQN">Sequence number (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="m3_MEPF">Media profile</param>
		/// <param name="m3_PRF1">Document/media controlling object 1</param>
		/// <param name="m3_PRF2">Document/media control object 2</param>
		/// <param name="m3_SIID">Service identity</param>
		/// <param name="m3_FMTP">Paper size</param>
		/// <param name="m3_OUTP">Priority</param>
		/// <param name="m3_UDTA">User data</param>
		/// <param name="m3_1UDT">Field selection</param>
		/// <param name="m3_TFNO">Facsimile transmission number</param>
		/// <param name="m3_TFT1">Fax text 1</param>
		/// <param name="m3_1TFT">Field selection</param>
		/// <param name="m3_FLRN">Folder name</param>
		/// <param name="m3_FAXT">Send time - fax</param>
		/// <param name="m3_SUBJ">Subject</param>
		/// <param name="m3_NOTE">Note</param>
		/// <param name="m3_CPPL">Copy</param>
		/// <param name="m3_LAYC">Modification</param>
		/// <param name="m3_MARI">Country</param>
		/// <param name="m3_ARCH">Archive</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPartnerFax(
			string m3_DONR, 
			string m3_MEDC, 
			int m3_SEQN, 
			string m3_DIVI = null, 
			string m3_DOVA = null, 
			string m3_MEPF = null, 
			string m3_PRF1 = null, 
			string m3_PRF2 = null, 
			string m3_SIID = null, 
			string m3_FMTP = null, 
			string m3_OUTP = null, 
			string m3_UDTA = null, 
			string m3_1UDT = null, 
			string m3_TFNO = null, 
			string m3_TFT1 = null, 
			string m3_1TFT = null, 
			string m3_FLRN = null, 
			int? m3_FAXT = null, 
			string m3_SUBJ = null, 
			string m3_NOTE = null, 
			int? m3_CPPL = null, 
			string m3_LAYC = null, 
			string m3_MARI = null, 
			int? m3_ARCH = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdPartnerFax",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DONR))
				throw new ArgumentNullException("m3_DONR");
			if (string.IsNullOrWhiteSpace(m3_MEDC))
				throw new ArgumentNullException("m3_MEDC");

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3_DONR.Trim())
				.WithQueryParameter("MEDC", m3_MEDC.Trim())
				.WithQueryParameter("SEQN", m3_SEQN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEPF))
				request.WithQueryParameter("MEPF", m3_MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF1))
				request.WithQueryParameter("PRF1", m3_PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF2))
				request.WithQueryParameter("PRF2", m3_PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SIID))
				request.WithQueryParameter("SIID", m3_SIID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMTP))
				request.WithQueryParameter("FMTP", m3_FMTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OUTP))
				request.WithQueryParameter("OUTP", m3_OUTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UDTA))
				request.WithQueryParameter("UDTA", m3_UDTA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_1UDT))
				request.WithQueryParameter("1UDT", m3_1UDT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFT1))
				request.WithQueryParameter("TFT1", m3_TFT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_1TFT))
				request.WithQueryParameter("1TFT", m3_1TFT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLRN))
				request.WithQueryParameter("FLRN", m3_FLRN.Trim());
			if (m3_FAXT.HasValue)
				request.WithQueryParameter("FAXT", m3_FAXT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUBJ))
				request.WithQueryParameter("SUBJ", m3_SUBJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NOTE))
				request.WithQueryParameter("NOTE", m3_NOTE.Trim());
			if (m3_CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3_CPPL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LAYC))
				request.WithQueryParameter("LAYC", m3_LAYC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MARI))
				request.WithQueryParameter("MARI", m3_MARI.Trim());
			if (m3_ARCH.HasValue)
				request.WithQueryParameter("ARCH", m3_ARCH.Value.ToString());

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
		/// Name UpdPartnerFile
		/// Description Update document/partner - file connection
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DONR">Document number (Required)</param>
		/// <param name="m3_MEDC">Media (Required)</param>
		/// <param name="m3_SEQN">Sequence number (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="m3_MEPF">Media profile</param>
		/// <param name="m3_PRF1">Document/media controlling object 1</param>
		/// <param name="m3_PRF2">Document/media control object 2</param>
		/// <param name="m3_SIID">Service identity</param>
		/// <param name="m3_FMTP">Paper size</param>
		/// <param name="m3_FLRN">Folder name</param>
		/// <param name="m3_PAFD">File path</param>
		/// <param name="m3_FSUX">File suffix</param>
		/// <param name="m3_GNNM">Generic name method</param>
		/// <param name="m3_CPPL">Copy</param>
		/// <param name="m3_LAYC">Modification</param>
		/// <param name="m3_MARI">Country</param>
		/// <param name="m3_ARCH">Archive</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPartnerFile(
			string m3_DONR, 
			string m3_MEDC, 
			int m3_SEQN, 
			string m3_DIVI = null, 
			string m3_DOVA = null, 
			string m3_MEPF = null, 
			string m3_PRF1 = null, 
			string m3_PRF2 = null, 
			string m3_SIID = null, 
			string m3_FMTP = null, 
			string m3_FLRN = null, 
			string m3_PAFD = null, 
			string m3_FSUX = null, 
			int? m3_GNNM = null, 
			int? m3_CPPL = null, 
			string m3_LAYC = null, 
			string m3_MARI = null, 
			int? m3_ARCH = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdPartnerFile",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DONR))
				throw new ArgumentNullException("m3_DONR");
			if (string.IsNullOrWhiteSpace(m3_MEDC))
				throw new ArgumentNullException("m3_MEDC");

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3_DONR.Trim())
				.WithQueryParameter("MEDC", m3_MEDC.Trim())
				.WithQueryParameter("SEQN", m3_SEQN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEPF))
				request.WithQueryParameter("MEPF", m3_MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF1))
				request.WithQueryParameter("PRF1", m3_PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF2))
				request.WithQueryParameter("PRF2", m3_PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SIID))
				request.WithQueryParameter("SIID", m3_SIID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMTP))
				request.WithQueryParameter("FMTP", m3_FMTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLRN))
				request.WithQueryParameter("FLRN", m3_FLRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAFD))
				request.WithQueryParameter("PAFD", m3_PAFD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FSUX))
				request.WithQueryParameter("FSUX", m3_FSUX.Trim());
			if (m3_GNNM.HasValue)
				request.WithQueryParameter("GNNM", m3_GNNM.Value.ToString());
			if (m3_CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3_CPPL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LAYC))
				request.WithQueryParameter("LAYC", m3_LAYC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MARI))
				request.WithQueryParameter("MARI", m3_MARI.Trim());
			if (m3_ARCH.HasValue)
				request.WithQueryParameter("ARCH", m3_ARCH.Value.ToString());

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
		/// Name UpdPartnerMBM
		/// Description Update document/partner - MBM connection
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DONR">Document number (Required)</param>
		/// <param name="m3_MEDC">Media (Required)</param>
		/// <param name="m3_SEQN">Sequence number (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="m3_MEPF">Media profile</param>
		/// <param name="m3_PRF1">Document/media controlling object 1</param>
		/// <param name="m3_PRF2">Document/media control object 2</param>
		/// <param name="m3_SIID">Service identity</param>
		/// <param name="m3_CPPL">Copy</param>
		/// <param name="m3_TEME">Test flag</param>
		/// <param name="m3_SRD1">Sender reference data 1</param>
		/// <param name="m3_SRD2">Sender reference data 2</param>
		/// <param name="m3_RRD1">Receiver reference data 1</param>
		/// <param name="m3_RRD2">Receiver reference data 2</param>
		/// <param name="m3_RRD3">Receiver reference data 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPartnerMBM(
			string m3_DONR, 
			string m3_MEDC, 
			int m3_SEQN, 
			string m3_DIVI = null, 
			string m3_DOVA = null, 
			string m3_MEPF = null, 
			string m3_PRF1 = null, 
			string m3_PRF2 = null, 
			string m3_SIID = null, 
			int? m3_CPPL = null, 
			int? m3_TEME = null, 
			string m3_SRD1 = null, 
			string m3_SRD2 = null, 
			string m3_RRD1 = null, 
			string m3_RRD2 = null, 
			string m3_RRD3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdPartnerMBM",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DONR))
				throw new ArgumentNullException("m3_DONR");
			if (string.IsNullOrWhiteSpace(m3_MEDC))
				throw new ArgumentNullException("m3_MEDC");

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3_DONR.Trim())
				.WithQueryParameter("MEDC", m3_MEDC.Trim())
				.WithQueryParameter("SEQN", m3_SEQN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEPF))
				request.WithQueryParameter("MEPF", m3_MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF1))
				request.WithQueryParameter("PRF1", m3_PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF2))
				request.WithQueryParameter("PRF2", m3_PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SIID))
				request.WithQueryParameter("SIID", m3_SIID.Trim());
			if (m3_CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3_CPPL.Value.ToString());
			if (m3_TEME.HasValue)
				request.WithQueryParameter("TEME", m3_TEME.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SRD1))
				request.WithQueryParameter("SRD1", m3_SRD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRD2))
				request.WithQueryParameter("SRD2", m3_SRD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RRD1))
				request.WithQueryParameter("RRD1", m3_RRD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RRD2))
				request.WithQueryParameter("RRD2", m3_RRD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RRD3))
				request.WithQueryParameter("RRD3", m3_RRD3.Trim());

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
		/// Name UpdPartnerPrint
		/// Description Update document/partner - print connection
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DONR">Document number (Required)</param>
		/// <param name="m3_MEDC">Media (Required)</param>
		/// <param name="m3_SEQN">Sequence number (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="m3_MEPF">Media profile</param>
		/// <param name="m3_PRF1">Document/media controlling object 1</param>
		/// <param name="m3_PRF2">Document/media control object 2</param>
		/// <param name="m3_SIID">Service identity</param>
		/// <param name="m3_FMTP">Paper size</param>
		/// <param name="m3_COPY">Number of copies</param>
		/// <param name="m3_DEV">Printer</param>
		/// <param name="m3_FOVR">Overlay front page name</param>
		/// <param name="m3_BINX">Bin</param>
		/// <param name="m3_CPPL">Copy</param>
		/// <param name="m3_TRAY">Tray</param>
		/// <param name="m3_LAYC">Modification</param>
		/// <param name="m3_MARI">Country</param>
		/// <param name="m3_ARCH">Archive</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPartnerPrint(
			string m3_DONR, 
			string m3_MEDC, 
			int m3_SEQN, 
			string m3_DIVI = null, 
			string m3_DOVA = null, 
			string m3_MEPF = null, 
			string m3_PRF1 = null, 
			string m3_PRF2 = null, 
			string m3_SIID = null, 
			string m3_FMTP = null, 
			int? m3_COPY = null, 
			string m3_DEV = null, 
			string m3_FOVR = null, 
			string m3_BINX = null, 
			int? m3_CPPL = null, 
			string m3_TRAY = null, 
			string m3_LAYC = null, 
			string m3_MARI = null, 
			int? m3_ARCH = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdPartnerPrint",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DONR))
				throw new ArgumentNullException("m3_DONR");
			if (string.IsNullOrWhiteSpace(m3_MEDC))
				throw new ArgumentNullException("m3_MEDC");

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3_DONR.Trim())
				.WithQueryParameter("MEDC", m3_MEDC.Trim())
				.WithQueryParameter("SEQN", m3_SEQN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEPF))
				request.WithQueryParameter("MEPF", m3_MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF1))
				request.WithQueryParameter("PRF1", m3_PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF2))
				request.WithQueryParameter("PRF2", m3_PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SIID))
				request.WithQueryParameter("SIID", m3_SIID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMTP))
				request.WithQueryParameter("FMTP", m3_FMTP.Trim());
			if (m3_COPY.HasValue)
				request.WithQueryParameter("COPY", m3_COPY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DEV))
				request.WithQueryParameter("DEV", m3_DEV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FOVR))
				request.WithQueryParameter("FOVR", m3_FOVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BINX))
				request.WithQueryParameter("BINX", m3_BINX.Trim());
			if (m3_CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3_CPPL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TRAY))
				request.WithQueryParameter("TRAY", m3_TRAY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LAYC))
				request.WithQueryParameter("LAYC", m3_LAYC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MARI))
				request.WithQueryParameter("MARI", m3_MARI.Trim());
			if (m3_ARCH.HasValue)
				request.WithQueryParameter("ARCH", m3_ARCH.Value.ToString());

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
