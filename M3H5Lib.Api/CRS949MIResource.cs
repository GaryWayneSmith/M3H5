/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddPartnerEmail
		/// Description Add new document/partner - email connection
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DONR">Document number (Required)</param>
		/// <param name="m3MEDC">Media (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="m3MEPF">Media profile</param>
		/// <param name="m3PRF1">Document/media controlling object 1</param>
		/// <param name="m3PRF2">Document/media control object 2</param>
		/// <param name="m3SIID">Service identity</param>
		/// <param name="m3FMTP">Paper Size</param>
		/// <param name="m3TFT1">Fax text 1</param>
		/// <param name="m3FLRN">Folder name</param>
		/// <param name="m3TOMA">To email address</param>
		/// <param name="m3FRMA">From email address</param>
		/// <param name="m3CCMA">Copy to email address</param>
		/// <param name="m3SUBJ">Subject</param>
		/// <param name="m3NOTE">Note</param>
		/// <param name="m3CPPL">Copy</param>
		/// <param name="m3LAYC">Modification</param>
		/// <param name="m3MARI">Country</param>
		/// <param name="m3ARCH">Archiving</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPartnerEmail(
			string m3DONR, 
			string m3MEDC, 
			string m3DIVI = null, 
			string m3DOVA = null, 
			string m3MEPF = null, 
			string m3PRF1 = null, 
			string m3PRF2 = null, 
			string m3SIID = null, 
			string m3FMTP = null, 
			string m3TFT1 = null, 
			string m3FLRN = null, 
			string m3TOMA = null, 
			string m3FRMA = null, 
			string m3CCMA = null, 
			string m3SUBJ = null, 
			string m3NOTE = null, 
			int? m3CPPL = null, 
			string m3LAYC = null, 
			string m3MARI = null, 
			int? m3ARCH = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddPartnerEmail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DONR))
				throw new ArgumentNullException(nameof(m3DONR));
			if (string.IsNullOrWhiteSpace(m3MEDC))
				throw new ArgumentNullException(nameof(m3MEDC));

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3DONR.Trim())
				.WithQueryParameter("MEDC", m3MEDC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEPF))
				request.WithQueryParameter("MEPF", m3MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF1))
				request.WithQueryParameter("PRF1", m3PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF2))
				request.WithQueryParameter("PRF2", m3PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SIID))
				request.WithQueryParameter("SIID", m3SIID.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMTP))
				request.WithQueryParameter("FMTP", m3FMTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFT1))
				request.WithQueryParameter("TFT1", m3TFT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLRN))
				request.WithQueryParameter("FLRN", m3FLRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOMA))
				request.WithQueryParameter("TOMA", m3TOMA.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRMA))
				request.WithQueryParameter("FRMA", m3FRMA.Trim());
			if (!string.IsNullOrWhiteSpace(m3CCMA))
				request.WithQueryParameter("CCMA", m3CCMA.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUBJ))
				request.WithQueryParameter("SUBJ", m3SUBJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3NOTE))
				request.WithQueryParameter("NOTE", m3NOTE.Trim());
			if (m3CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3CPPL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LAYC))
				request.WithQueryParameter("LAYC", m3LAYC.Trim());
			if (!string.IsNullOrWhiteSpace(m3MARI))
				request.WithQueryParameter("MARI", m3MARI.Trim());
			if (m3ARCH.HasValue)
				request.WithQueryParameter("ARCH", m3ARCH.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddPartnerEvent
		/// Description Add new document/partner - event connection
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DONR">Document number (Required)</param>
		/// <param name="m3MEDC">Media (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="m3MEPF">Media profile</param>
		/// <param name="m3PRF1">Document/media controlling object 1</param>
		/// <param name="m3PRF2">Document/media control object 2</param>
		/// <param name="m3CPPL">Copy</param>
		/// <param name="m3TEME">Test flag</param>
		/// <param name="m3RRD1">Receiver reference data 1</param>
		/// <param name="m3RRD2">Receiver reference data 2</param>
		/// <param name="m3RRD3">Receiver reference data 3</param>
		/// <param name="m3CNID">Connector ID</param>
		/// <param name="m3EVPR">Event priority</param>
		/// <param name="m3BONM">Business object name</param>
		/// <param name="m3BOVB">Event verb</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPartnerEvent(
			string m3DONR, 
			string m3MEDC, 
			string m3DIVI = null, 
			string m3DOVA = null, 
			string m3MEPF = null, 
			string m3PRF1 = null, 
			string m3PRF2 = null, 
			int? m3CPPL = null, 
			int? m3TEME = null, 
			string m3RRD1 = null, 
			string m3RRD2 = null, 
			string m3RRD3 = null, 
			int? m3CNID = null, 
			int? m3EVPR = null, 
			string m3BONM = null, 
			string m3BOVB = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddPartnerEvent",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DONR))
				throw new ArgumentNullException(nameof(m3DONR));
			if (string.IsNullOrWhiteSpace(m3MEDC))
				throw new ArgumentNullException(nameof(m3MEDC));

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3DONR.Trim())
				.WithQueryParameter("MEDC", m3MEDC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEPF))
				request.WithQueryParameter("MEPF", m3MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF1))
				request.WithQueryParameter("PRF1", m3PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF2))
				request.WithQueryParameter("PRF2", m3PRF2.Trim());
			if (m3CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3CPPL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TEME.HasValue)
				request.WithQueryParameter("TEME", m3TEME.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RRD1))
				request.WithQueryParameter("RRD1", m3RRD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3RRD2))
				request.WithQueryParameter("RRD2", m3RRD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3RRD3))
				request.WithQueryParameter("RRD3", m3RRD3.Trim());
			if (m3CNID.HasValue)
				request.WithQueryParameter("CNID", m3CNID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EVPR.HasValue)
				request.WithQueryParameter("EVPR", m3EVPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BONM))
				request.WithQueryParameter("BONM", m3BONM.Trim());
			if (!string.IsNullOrWhiteSpace(m3BOVB))
				request.WithQueryParameter("BOVB", m3BOVB.Trim());

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
		/// Name AddPartnerFax
		/// Description Add new document/partner - fax connection
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DONR">Document number (Required)</param>
		/// <param name="m3MEDC">Media (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="m3MEPF">Media profile</param>
		/// <param name="m3PRF1">Document/media controlling object 1</param>
		/// <param name="m3PRF2">Document/media control object 2</param>
		/// <param name="m3SIID">Service identity</param>
		/// <param name="m3FMTP">Paper size</param>
		/// <param name="m3OUTP">Priority</param>
		/// <param name="m3UDTA">User data</param>
		/// <param name="m31UDT">Field selection</param>
		/// <param name="m3TFNO">Facsimile transmission number</param>
		/// <param name="m3TFT1">Fax text 1</param>
		/// <param name="m31TFT">Field selection</param>
		/// <param name="m3FLRN">Folder name</param>
		/// <param name="m3FAXT">Send time - fax</param>
		/// <param name="m3SUBJ">Subject</param>
		/// <param name="m3NOTE">Note</param>
		/// <param name="m3CPPL">Copy</param>
		/// <param name="m3LAYC">Modification</param>
		/// <param name="m3MARI">Country</param>
		/// <param name="m3ARCH">Archive</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPartnerFax(
			string m3DONR, 
			string m3MEDC, 
			string m3DIVI = null, 
			string m3DOVA = null, 
			string m3MEPF = null, 
			string m3PRF1 = null, 
			string m3PRF2 = null, 
			string m3SIID = null, 
			string m3FMTP = null, 
			string m3OUTP = null, 
			string m3UDTA = null, 
			string m31UDT = null, 
			string m3TFNO = null, 
			string m3TFT1 = null, 
			string m31TFT = null, 
			string m3FLRN = null, 
			int? m3FAXT = null, 
			string m3SUBJ = null, 
			string m3NOTE = null, 
			int? m3CPPL = null, 
			string m3LAYC = null, 
			string m3MARI = null, 
			int? m3ARCH = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddPartnerFax",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DONR))
				throw new ArgumentNullException(nameof(m3DONR));
			if (string.IsNullOrWhiteSpace(m3MEDC))
				throw new ArgumentNullException(nameof(m3MEDC));

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3DONR.Trim())
				.WithQueryParameter("MEDC", m3MEDC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEPF))
				request.WithQueryParameter("MEPF", m3MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF1))
				request.WithQueryParameter("PRF1", m3PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF2))
				request.WithQueryParameter("PRF2", m3PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SIID))
				request.WithQueryParameter("SIID", m3SIID.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMTP))
				request.WithQueryParameter("FMTP", m3FMTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3OUTP))
				request.WithQueryParameter("OUTP", m3OUTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3UDTA))
				request.WithQueryParameter("UDTA", m3UDTA.Trim());
			if (!string.IsNullOrWhiteSpace(m31UDT))
				request.WithQueryParameter("1UDT", m31UDT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFT1))
				request.WithQueryParameter("TFT1", m3TFT1.Trim());
			if (!string.IsNullOrWhiteSpace(m31TFT))
				request.WithQueryParameter("1TFT", m31TFT.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLRN))
				request.WithQueryParameter("FLRN", m3FLRN.Trim());
			if (m3FAXT.HasValue)
				request.WithQueryParameter("FAXT", m3FAXT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUBJ))
				request.WithQueryParameter("SUBJ", m3SUBJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3NOTE))
				request.WithQueryParameter("NOTE", m3NOTE.Trim());
			if (m3CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3CPPL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LAYC))
				request.WithQueryParameter("LAYC", m3LAYC.Trim());
			if (!string.IsNullOrWhiteSpace(m3MARI))
				request.WithQueryParameter("MARI", m3MARI.Trim());
			if (m3ARCH.HasValue)
				request.WithQueryParameter("ARCH", m3ARCH.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddPartnerFile
		/// Description Add new document/partner - file connection
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DONR">Document number (Required)</param>
		/// <param name="m3MEDC">Media (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="m3MEPF">Media profile</param>
		/// <param name="m3PRF1">Document/media controlling object 1</param>
		/// <param name="m3PRF2">Document/media control object 2</param>
		/// <param name="m3SIID">Service identity</param>
		/// <param name="m3FMTP">Paper size</param>
		/// <param name="m3FLRN">Folder name</param>
		/// <param name="m3PAFD">File path</param>
		/// <param name="m3FSUX">File suffix</param>
		/// <param name="m3GNNM">Generic name method</param>
		/// <param name="m3CPPL">Copy</param>
		/// <param name="m3LAYC">Modification</param>
		/// <param name="m3MARI">Country</param>
		/// <param name="m3ARCH">Archive</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPartnerFile(
			string m3DONR, 
			string m3MEDC, 
			string m3DIVI = null, 
			string m3DOVA = null, 
			string m3MEPF = null, 
			string m3PRF1 = null, 
			string m3PRF2 = null, 
			string m3SIID = null, 
			string m3FMTP = null, 
			string m3FLRN = null, 
			string m3PAFD = null, 
			string m3FSUX = null, 
			int? m3GNNM = null, 
			int? m3CPPL = null, 
			string m3LAYC = null, 
			string m3MARI = null, 
			int? m3ARCH = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddPartnerFile",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DONR))
				throw new ArgumentNullException(nameof(m3DONR));
			if (string.IsNullOrWhiteSpace(m3MEDC))
				throw new ArgumentNullException(nameof(m3MEDC));

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3DONR.Trim())
				.WithQueryParameter("MEDC", m3MEDC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEPF))
				request.WithQueryParameter("MEPF", m3MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF1))
				request.WithQueryParameter("PRF1", m3PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF2))
				request.WithQueryParameter("PRF2", m3PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SIID))
				request.WithQueryParameter("SIID", m3SIID.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMTP))
				request.WithQueryParameter("FMTP", m3FMTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLRN))
				request.WithQueryParameter("FLRN", m3FLRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAFD))
				request.WithQueryParameter("PAFD", m3PAFD.Trim());
			if (!string.IsNullOrWhiteSpace(m3FSUX))
				request.WithQueryParameter("FSUX", m3FSUX.Trim());
			if (m3GNNM.HasValue)
				request.WithQueryParameter("GNNM", m3GNNM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3CPPL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LAYC))
				request.WithQueryParameter("LAYC", m3LAYC.Trim());
			if (!string.IsNullOrWhiteSpace(m3MARI))
				request.WithQueryParameter("MARI", m3MARI.Trim());
			if (m3ARCH.HasValue)
				request.WithQueryParameter("ARCH", m3ARCH.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddPartnerMBM
		/// Description Add new document/partner - MBM connection
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DONR">Document number (Required)</param>
		/// <param name="m3MEDC">Media (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="m3MEPF">Media profile</param>
		/// <param name="m3PRF1">Document/media controlling object 1</param>
		/// <param name="m3PRF2">Document/media control object 2</param>
		/// <param name="m3SIID">Service identity</param>
		/// <param name="m3CPPL">Copy</param>
		/// <param name="m3TEME">Test flag</param>
		/// <param name="m3SRD1">Sender reference data 1</param>
		/// <param name="m3SRD2">Sender reference data 2</param>
		/// <param name="m3RRD1">Receiver reference data 1</param>
		/// <param name="m3RRD2">Receiver reference data 2</param>
		/// <param name="m3RRD3">Receiver reference data 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPartnerMBM(
			string m3DONR, 
			string m3MEDC, 
			string m3DIVI = null, 
			string m3DOVA = null, 
			string m3MEPF = null, 
			string m3PRF1 = null, 
			string m3PRF2 = null, 
			string m3SIID = null, 
			int? m3CPPL = null, 
			int? m3TEME = null, 
			string m3SRD1 = null, 
			string m3SRD2 = null, 
			string m3RRD1 = null, 
			string m3RRD2 = null, 
			string m3RRD3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddPartnerMBM",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DONR))
				throw new ArgumentNullException(nameof(m3DONR));
			if (string.IsNullOrWhiteSpace(m3MEDC))
				throw new ArgumentNullException(nameof(m3MEDC));

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3DONR.Trim())
				.WithQueryParameter("MEDC", m3MEDC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEPF))
				request.WithQueryParameter("MEPF", m3MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF1))
				request.WithQueryParameter("PRF1", m3PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF2))
				request.WithQueryParameter("PRF2", m3PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SIID))
				request.WithQueryParameter("SIID", m3SIID.Trim());
			if (m3CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3CPPL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TEME.HasValue)
				request.WithQueryParameter("TEME", m3TEME.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SRD1))
				request.WithQueryParameter("SRD1", m3SRD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRD2))
				request.WithQueryParameter("SRD2", m3SRD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3RRD1))
				request.WithQueryParameter("RRD1", m3RRD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3RRD2))
				request.WithQueryParameter("RRD2", m3RRD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3RRD3))
				request.WithQueryParameter("RRD3", m3RRD3.Trim());

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
		/// Name AddPartnerPrint
		/// Description Add new document/partner - print connection
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DONR">Document number (Required)</param>
		/// <param name="m3MEDC">Media (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="m3MEPF">Media profile</param>
		/// <param name="m3PRF1">Document/media controlling object 1</param>
		/// <param name="m3PRF2">Document/media control object 2</param>
		/// <param name="m3SIID">Service identity</param>
		/// <param name="m3FMTP">Paper size</param>
		/// <param name="m3COPY">Number of copies</param>
		/// <param name="m3DEV">Printer</param>
		/// <param name="m3FOVR">Overlay front page name</param>
		/// <param name="m3BINX">Bin</param>
		/// <param name="m3CPPL">Copy</param>
		/// <param name="m3TRAY">Tray</param>
		/// <param name="m3LAYC">Modification</param>
		/// <param name="m3MARI">Country</param>
		/// <param name="m3ARCH">Archive</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPartnerPrint(
			string m3DONR, 
			string m3MEDC, 
			string m3DIVI = null, 
			string m3DOVA = null, 
			string m3MEPF = null, 
			string m3PRF1 = null, 
			string m3PRF2 = null, 
			string m3SIID = null, 
			string m3FMTP = null, 
			int? m3COPY = null, 
			string m3DEV = null, 
			string m3FOVR = null, 
			string m3BINX = null, 
			int? m3CPPL = null, 
			string m3TRAY = null, 
			string m3LAYC = null, 
			string m3MARI = null, 
			int? m3ARCH = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddPartnerPrint",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DONR))
				throw new ArgumentNullException(nameof(m3DONR));
			if (string.IsNullOrWhiteSpace(m3MEDC))
				throw new ArgumentNullException(nameof(m3MEDC));

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3DONR.Trim())
				.WithQueryParameter("MEDC", m3MEDC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEPF))
				request.WithQueryParameter("MEPF", m3MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF1))
				request.WithQueryParameter("PRF1", m3PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF2))
				request.WithQueryParameter("PRF2", m3PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SIID))
				request.WithQueryParameter("SIID", m3SIID.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMTP))
				request.WithQueryParameter("FMTP", m3FMTP.Trim());
			if (m3COPY.HasValue)
				request.WithQueryParameter("COPY", m3COPY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DEV))
				request.WithQueryParameter("DEV", m3DEV.Trim());
			if (!string.IsNullOrWhiteSpace(m3FOVR))
				request.WithQueryParameter("FOVR", m3FOVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3BINX))
				request.WithQueryParameter("BINX", m3BINX.Trim());
			if (m3CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3CPPL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TRAY))
				request.WithQueryParameter("TRAY", m3TRAY.Trim());
			if (!string.IsNullOrWhiteSpace(m3LAYC))
				request.WithQueryParameter("LAYC", m3LAYC.Trim());
			if (!string.IsNullOrWhiteSpace(m3MARI))
				request.WithQueryParameter("MARI", m3MARI.Trim());
			if (m3ARCH.HasValue)
				request.WithQueryParameter("ARCH", m3ARCH.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltPartnerMedia
		/// Description Delete document/partner - media connection
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DONR">Document number (Required)</param>
		/// <param name="m3MEDC">Media (Required)</param>
		/// <param name="m3SEQN">Sequence number (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="m3MEPF">Media profile</param>
		/// <param name="m3PRF1">Document/media controlling object 1</param>
		/// <param name="m3PRF2">Document/media control object 2</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltPartnerMedia(
			string m3DONR, 
			string m3MEDC, 
			int m3SEQN, 
			string m3DIVI = null, 
			string m3DOVA = null, 
			string m3MEPF = null, 
			string m3PRF1 = null, 
			string m3PRF2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltPartnerMedia",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DONR))
				throw new ArgumentNullException(nameof(m3DONR));
			if (string.IsNullOrWhiteSpace(m3MEDC))
				throw new ArgumentNullException(nameof(m3MEDC));

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3DONR.Trim())
				.WithQueryParameter("MEDC", m3MEDC.Trim())
				.WithQueryParameter("SEQN", m3SEQN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEPF))
				request.WithQueryParameter("MEPF", m3MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF1))
				request.WithQueryParameter("PRF1", m3PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF2))
				request.WithQueryParameter("PRF2", m3PRF2.Trim());

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
		/// Name GetPartnerMedia
		/// Description Get a document/partner - media connection record
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3DONR">Document number</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="m3MEPF">Media profile</param>
		/// <param name="m3PRF1">Document/media controlling object 1</param>
		/// <param name="m3PRF2">Document/media control object 2</param>
		/// <param name="m3MEDC">Media</param>
		/// <param name="m3SEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPartnerMediaResponse></returns>
		/// <exception cref="M3Exception<GetPartnerMediaResponse>"></exception>
		public async Task<M3Response<GetPartnerMediaResponse>> GetPartnerMedia(
			string m3DIVI = null, 
			string m3DONR = null, 
			string m3DOVA = null, 
			string m3MEPF = null, 
			string m3PRF1 = null, 
			string m3PRF2 = null, 
			string m3MEDC = null, 
			int? m3SEQN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetPartnerMedia",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3DONR))
				request.WithQueryParameter("DONR", m3DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEPF))
				request.WithQueryParameter("MEPF", m3MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF1))
				request.WithQueryParameter("PRF1", m3PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF2))
				request.WithQueryParameter("PRF2", m3PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEDC))
				request.WithQueryParameter("MEDC", m3MEDC.Trim());
			if (m3SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3SEQN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetPartnerMediaResponse>(
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
		/// Name LstPartnerMedia
		/// Description List documents/partner - media connection records
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3DONR">Document number</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="m3MEPF">Media profile</param>
		/// <param name="m3PRF1">Document/media controlling object 1</param>
		/// <param name="m3PRF2">Document/media control object 2</param>
		/// <param name="m3MEDC">Media</param>
		/// <param name="m3SEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPartnerMediaResponse></returns>
		/// <exception cref="M3Exception<LstPartnerMediaResponse>"></exception>
		public async Task<M3Response<LstPartnerMediaResponse>> LstPartnerMedia(
			string m3DIVI = null, 
			string m3DONR = null, 
			string m3DOVA = null, 
			string m3MEPF = null, 
			string m3PRF1 = null, 
			string m3PRF2 = null, 
			string m3MEDC = null, 
			int? m3SEQN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPartnerMedia",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3DONR))
				request.WithQueryParameter("DONR", m3DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEPF))
				request.WithQueryParameter("MEPF", m3MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF1))
				request.WithQueryParameter("PRF1", m3PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF2))
				request.WithQueryParameter("PRF2", m3PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEDC))
				request.WithQueryParameter("MEDC", m3MEDC.Trim());
			if (m3SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3SEQN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPartnerMediaResponse>(
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
		/// Name UpdPartnerEmail
		/// Description Update document/partner - email connection
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DONR">Document number (Required)</param>
		/// <param name="m3MEDC">Media (Required)</param>
		/// <param name="m3SEQN">Sequence number (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="m3MEPF">Media profile</param>
		/// <param name="m3PRF1">Document/media controlling object 1</param>
		/// <param name="m3PRF2">Document/media control object 2</param>
		/// <param name="m3SIID">Service identity</param>
		/// <param name="m3FMTP">Paper Size</param>
		/// <param name="m3TFT1">Fax text 1</param>
		/// <param name="m3FLRN">Folder name</param>
		/// <param name="m3TOMA">To email address</param>
		/// <param name="m3FRMA">From email address</param>
		/// <param name="m3CCMA">Copy to email address</param>
		/// <param name="m3SUBJ">Subject</param>
		/// <param name="m3NOTE">Note</param>
		/// <param name="m3CPPL">Copy</param>
		/// <param name="m3LAYC">Modification</param>
		/// <param name="m3MARI">Country</param>
		/// <param name="m3ARCH">Archiving</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPartnerEmail(
			string m3DONR, 
			string m3MEDC, 
			int m3SEQN, 
			string m3DIVI = null, 
			string m3DOVA = null, 
			string m3MEPF = null, 
			string m3PRF1 = null, 
			string m3PRF2 = null, 
			string m3SIID = null, 
			string m3FMTP = null, 
			string m3TFT1 = null, 
			string m3FLRN = null, 
			string m3TOMA = null, 
			string m3FRMA = null, 
			string m3CCMA = null, 
			string m3SUBJ = null, 
			string m3NOTE = null, 
			int? m3CPPL = null, 
			string m3LAYC = null, 
			string m3MARI = null, 
			int? m3ARCH = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdPartnerEmail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DONR))
				throw new ArgumentNullException(nameof(m3DONR));
			if (string.IsNullOrWhiteSpace(m3MEDC))
				throw new ArgumentNullException(nameof(m3MEDC));

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3DONR.Trim())
				.WithQueryParameter("MEDC", m3MEDC.Trim())
				.WithQueryParameter("SEQN", m3SEQN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEPF))
				request.WithQueryParameter("MEPF", m3MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF1))
				request.WithQueryParameter("PRF1", m3PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF2))
				request.WithQueryParameter("PRF2", m3PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SIID))
				request.WithQueryParameter("SIID", m3SIID.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMTP))
				request.WithQueryParameter("FMTP", m3FMTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFT1))
				request.WithQueryParameter("TFT1", m3TFT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLRN))
				request.WithQueryParameter("FLRN", m3FLRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOMA))
				request.WithQueryParameter("TOMA", m3TOMA.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRMA))
				request.WithQueryParameter("FRMA", m3FRMA.Trim());
			if (!string.IsNullOrWhiteSpace(m3CCMA))
				request.WithQueryParameter("CCMA", m3CCMA.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUBJ))
				request.WithQueryParameter("SUBJ", m3SUBJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3NOTE))
				request.WithQueryParameter("NOTE", m3NOTE.Trim());
			if (m3CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3CPPL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LAYC))
				request.WithQueryParameter("LAYC", m3LAYC.Trim());
			if (!string.IsNullOrWhiteSpace(m3MARI))
				request.WithQueryParameter("MARI", m3MARI.Trim());
			if (m3ARCH.HasValue)
				request.WithQueryParameter("ARCH", m3ARCH.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdPartnerEvent
		/// Description Update document/partner - event connection
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DONR">Document number (Required)</param>
		/// <param name="m3MEDC">Media (Required)</param>
		/// <param name="m3SEQN">Sequence number (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="m3MEPF">Media profile</param>
		/// <param name="m3PRF1">Document/media controlling object 1</param>
		/// <param name="m3PRF2">Document/media control object 2</param>
		/// <param name="m3CPPL">Copy</param>
		/// <param name="m3TEME">Test flag</param>
		/// <param name="m3RRD1">Receiver reference data 1</param>
		/// <param name="m3RRD2">Receiver reference data 2</param>
		/// <param name="m3RRD3">Receiver reference data 3</param>
		/// <param name="m3CNID">Connector ID</param>
		/// <param name="m3EVPR">Event priority</param>
		/// <param name="m3BONM">Business object name</param>
		/// <param name="m3BOVB">Event verb</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPartnerEvent(
			string m3DONR, 
			string m3MEDC, 
			int m3SEQN, 
			string m3DIVI = null, 
			string m3DOVA = null, 
			string m3MEPF = null, 
			string m3PRF1 = null, 
			string m3PRF2 = null, 
			int? m3CPPL = null, 
			int? m3TEME = null, 
			string m3RRD1 = null, 
			string m3RRD2 = null, 
			string m3RRD3 = null, 
			int? m3CNID = null, 
			int? m3EVPR = null, 
			string m3BONM = null, 
			string m3BOVB = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdPartnerEvent",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DONR))
				throw new ArgumentNullException(nameof(m3DONR));
			if (string.IsNullOrWhiteSpace(m3MEDC))
				throw new ArgumentNullException(nameof(m3MEDC));

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3DONR.Trim())
				.WithQueryParameter("MEDC", m3MEDC.Trim())
				.WithQueryParameter("SEQN", m3SEQN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEPF))
				request.WithQueryParameter("MEPF", m3MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF1))
				request.WithQueryParameter("PRF1", m3PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF2))
				request.WithQueryParameter("PRF2", m3PRF2.Trim());
			if (m3CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3CPPL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TEME.HasValue)
				request.WithQueryParameter("TEME", m3TEME.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RRD1))
				request.WithQueryParameter("RRD1", m3RRD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3RRD2))
				request.WithQueryParameter("RRD2", m3RRD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3RRD3))
				request.WithQueryParameter("RRD3", m3RRD3.Trim());
			if (m3CNID.HasValue)
				request.WithQueryParameter("CNID", m3CNID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EVPR.HasValue)
				request.WithQueryParameter("EVPR", m3EVPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BONM))
				request.WithQueryParameter("BONM", m3BONM.Trim());
			if (!string.IsNullOrWhiteSpace(m3BOVB))
				request.WithQueryParameter("BOVB", m3BOVB.Trim());

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
		/// Name UpdPartnerFax
		/// Description Update document/partner - fax connection
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DONR">Document number (Required)</param>
		/// <param name="m3MEDC">Media (Required)</param>
		/// <param name="m3SEQN">Sequence number (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="m3MEPF">Media profile</param>
		/// <param name="m3PRF1">Document/media controlling object 1</param>
		/// <param name="m3PRF2">Document/media control object 2</param>
		/// <param name="m3SIID">Service identity</param>
		/// <param name="m3FMTP">Paper size</param>
		/// <param name="m3OUTP">Priority</param>
		/// <param name="m3UDTA">User data</param>
		/// <param name="m31UDT">Field selection</param>
		/// <param name="m3TFNO">Facsimile transmission number</param>
		/// <param name="m3TFT1">Fax text 1</param>
		/// <param name="m31TFT">Field selection</param>
		/// <param name="m3FLRN">Folder name</param>
		/// <param name="m3FAXT">Send time - fax</param>
		/// <param name="m3SUBJ">Subject</param>
		/// <param name="m3NOTE">Note</param>
		/// <param name="m3CPPL">Copy</param>
		/// <param name="m3LAYC">Modification</param>
		/// <param name="m3MARI">Country</param>
		/// <param name="m3ARCH">Archive</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPartnerFax(
			string m3DONR, 
			string m3MEDC, 
			int m3SEQN, 
			string m3DIVI = null, 
			string m3DOVA = null, 
			string m3MEPF = null, 
			string m3PRF1 = null, 
			string m3PRF2 = null, 
			string m3SIID = null, 
			string m3FMTP = null, 
			string m3OUTP = null, 
			string m3UDTA = null, 
			string m31UDT = null, 
			string m3TFNO = null, 
			string m3TFT1 = null, 
			string m31TFT = null, 
			string m3FLRN = null, 
			int? m3FAXT = null, 
			string m3SUBJ = null, 
			string m3NOTE = null, 
			int? m3CPPL = null, 
			string m3LAYC = null, 
			string m3MARI = null, 
			int? m3ARCH = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdPartnerFax",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DONR))
				throw new ArgumentNullException(nameof(m3DONR));
			if (string.IsNullOrWhiteSpace(m3MEDC))
				throw new ArgumentNullException(nameof(m3MEDC));

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3DONR.Trim())
				.WithQueryParameter("MEDC", m3MEDC.Trim())
				.WithQueryParameter("SEQN", m3SEQN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEPF))
				request.WithQueryParameter("MEPF", m3MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF1))
				request.WithQueryParameter("PRF1", m3PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF2))
				request.WithQueryParameter("PRF2", m3PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SIID))
				request.WithQueryParameter("SIID", m3SIID.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMTP))
				request.WithQueryParameter("FMTP", m3FMTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3OUTP))
				request.WithQueryParameter("OUTP", m3OUTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3UDTA))
				request.WithQueryParameter("UDTA", m3UDTA.Trim());
			if (!string.IsNullOrWhiteSpace(m31UDT))
				request.WithQueryParameter("1UDT", m31UDT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFT1))
				request.WithQueryParameter("TFT1", m3TFT1.Trim());
			if (!string.IsNullOrWhiteSpace(m31TFT))
				request.WithQueryParameter("1TFT", m31TFT.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLRN))
				request.WithQueryParameter("FLRN", m3FLRN.Trim());
			if (m3FAXT.HasValue)
				request.WithQueryParameter("FAXT", m3FAXT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUBJ))
				request.WithQueryParameter("SUBJ", m3SUBJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3NOTE))
				request.WithQueryParameter("NOTE", m3NOTE.Trim());
			if (m3CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3CPPL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LAYC))
				request.WithQueryParameter("LAYC", m3LAYC.Trim());
			if (!string.IsNullOrWhiteSpace(m3MARI))
				request.WithQueryParameter("MARI", m3MARI.Trim());
			if (m3ARCH.HasValue)
				request.WithQueryParameter("ARCH", m3ARCH.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdPartnerFile
		/// Description Update document/partner - file connection
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DONR">Document number (Required)</param>
		/// <param name="m3MEDC">Media (Required)</param>
		/// <param name="m3SEQN">Sequence number (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="m3MEPF">Media profile</param>
		/// <param name="m3PRF1">Document/media controlling object 1</param>
		/// <param name="m3PRF2">Document/media control object 2</param>
		/// <param name="m3SIID">Service identity</param>
		/// <param name="m3FMTP">Paper size</param>
		/// <param name="m3FLRN">Folder name</param>
		/// <param name="m3PAFD">File path</param>
		/// <param name="m3FSUX">File suffix</param>
		/// <param name="m3GNNM">Generic name method</param>
		/// <param name="m3CPPL">Copy</param>
		/// <param name="m3LAYC">Modification</param>
		/// <param name="m3MARI">Country</param>
		/// <param name="m3ARCH">Archive</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPartnerFile(
			string m3DONR, 
			string m3MEDC, 
			int m3SEQN, 
			string m3DIVI = null, 
			string m3DOVA = null, 
			string m3MEPF = null, 
			string m3PRF1 = null, 
			string m3PRF2 = null, 
			string m3SIID = null, 
			string m3FMTP = null, 
			string m3FLRN = null, 
			string m3PAFD = null, 
			string m3FSUX = null, 
			int? m3GNNM = null, 
			int? m3CPPL = null, 
			string m3LAYC = null, 
			string m3MARI = null, 
			int? m3ARCH = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdPartnerFile",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DONR))
				throw new ArgumentNullException(nameof(m3DONR));
			if (string.IsNullOrWhiteSpace(m3MEDC))
				throw new ArgumentNullException(nameof(m3MEDC));

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3DONR.Trim())
				.WithQueryParameter("MEDC", m3MEDC.Trim())
				.WithQueryParameter("SEQN", m3SEQN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEPF))
				request.WithQueryParameter("MEPF", m3MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF1))
				request.WithQueryParameter("PRF1", m3PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF2))
				request.WithQueryParameter("PRF2", m3PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SIID))
				request.WithQueryParameter("SIID", m3SIID.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMTP))
				request.WithQueryParameter("FMTP", m3FMTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLRN))
				request.WithQueryParameter("FLRN", m3FLRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAFD))
				request.WithQueryParameter("PAFD", m3PAFD.Trim());
			if (!string.IsNullOrWhiteSpace(m3FSUX))
				request.WithQueryParameter("FSUX", m3FSUX.Trim());
			if (m3GNNM.HasValue)
				request.WithQueryParameter("GNNM", m3GNNM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3CPPL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LAYC))
				request.WithQueryParameter("LAYC", m3LAYC.Trim());
			if (!string.IsNullOrWhiteSpace(m3MARI))
				request.WithQueryParameter("MARI", m3MARI.Trim());
			if (m3ARCH.HasValue)
				request.WithQueryParameter("ARCH", m3ARCH.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdPartnerMBM
		/// Description Update document/partner - MBM connection
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DONR">Document number (Required)</param>
		/// <param name="m3MEDC">Media (Required)</param>
		/// <param name="m3SEQN">Sequence number (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="m3MEPF">Media profile</param>
		/// <param name="m3PRF1">Document/media controlling object 1</param>
		/// <param name="m3PRF2">Document/media control object 2</param>
		/// <param name="m3SIID">Service identity</param>
		/// <param name="m3CPPL">Copy</param>
		/// <param name="m3TEME">Test flag</param>
		/// <param name="m3SRD1">Sender reference data 1</param>
		/// <param name="m3SRD2">Sender reference data 2</param>
		/// <param name="m3RRD1">Receiver reference data 1</param>
		/// <param name="m3RRD2">Receiver reference data 2</param>
		/// <param name="m3RRD3">Receiver reference data 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPartnerMBM(
			string m3DONR, 
			string m3MEDC, 
			int m3SEQN, 
			string m3DIVI = null, 
			string m3DOVA = null, 
			string m3MEPF = null, 
			string m3PRF1 = null, 
			string m3PRF2 = null, 
			string m3SIID = null, 
			int? m3CPPL = null, 
			int? m3TEME = null, 
			string m3SRD1 = null, 
			string m3SRD2 = null, 
			string m3RRD1 = null, 
			string m3RRD2 = null, 
			string m3RRD3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdPartnerMBM",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DONR))
				throw new ArgumentNullException(nameof(m3DONR));
			if (string.IsNullOrWhiteSpace(m3MEDC))
				throw new ArgumentNullException(nameof(m3MEDC));

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3DONR.Trim())
				.WithQueryParameter("MEDC", m3MEDC.Trim())
				.WithQueryParameter("SEQN", m3SEQN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEPF))
				request.WithQueryParameter("MEPF", m3MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF1))
				request.WithQueryParameter("PRF1", m3PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF2))
				request.WithQueryParameter("PRF2", m3PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SIID))
				request.WithQueryParameter("SIID", m3SIID.Trim());
			if (m3CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3CPPL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TEME.HasValue)
				request.WithQueryParameter("TEME", m3TEME.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SRD1))
				request.WithQueryParameter("SRD1", m3SRD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRD2))
				request.WithQueryParameter("SRD2", m3SRD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3RRD1))
				request.WithQueryParameter("RRD1", m3RRD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3RRD2))
				request.WithQueryParameter("RRD2", m3RRD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3RRD3))
				request.WithQueryParameter("RRD3", m3RRD3.Trim());

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
		/// Name UpdPartnerPrint
		/// Description Update document/partner - print connection
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DONR">Document number (Required)</param>
		/// <param name="m3MEDC">Media (Required)</param>
		/// <param name="m3SEQN">Sequence number (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="m3MEPF">Media profile</param>
		/// <param name="m3PRF1">Document/media controlling object 1</param>
		/// <param name="m3PRF2">Document/media control object 2</param>
		/// <param name="m3SIID">Service identity</param>
		/// <param name="m3FMTP">Paper size</param>
		/// <param name="m3COPY">Number of copies</param>
		/// <param name="m3DEV">Printer</param>
		/// <param name="m3FOVR">Overlay front page name</param>
		/// <param name="m3BINX">Bin</param>
		/// <param name="m3CPPL">Copy</param>
		/// <param name="m3TRAY">Tray</param>
		/// <param name="m3LAYC">Modification</param>
		/// <param name="m3MARI">Country</param>
		/// <param name="m3ARCH">Archive</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPartnerPrint(
			string m3DONR, 
			string m3MEDC, 
			int m3SEQN, 
			string m3DIVI = null, 
			string m3DOVA = null, 
			string m3MEPF = null, 
			string m3PRF1 = null, 
			string m3PRF2 = null, 
			string m3SIID = null, 
			string m3FMTP = null, 
			int? m3COPY = null, 
			string m3DEV = null, 
			string m3FOVR = null, 
			string m3BINX = null, 
			int? m3CPPL = null, 
			string m3TRAY = null, 
			string m3LAYC = null, 
			string m3MARI = null, 
			int? m3ARCH = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdPartnerPrint",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DONR))
				throw new ArgumentNullException(nameof(m3DONR));
			if (string.IsNullOrWhiteSpace(m3MEDC))
				throw new ArgumentNullException(nameof(m3MEDC));

			// Set mandatory parameters
			request
				.WithQueryParameter("DONR", m3DONR.Trim())
				.WithQueryParameter("MEDC", m3MEDC.Trim())
				.WithQueryParameter("SEQN", m3SEQN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEPF))
				request.WithQueryParameter("MEPF", m3MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF1))
				request.WithQueryParameter("PRF1", m3PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF2))
				request.WithQueryParameter("PRF2", m3PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SIID))
				request.WithQueryParameter("SIID", m3SIID.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMTP))
				request.WithQueryParameter("FMTP", m3FMTP.Trim());
			if (m3COPY.HasValue)
				request.WithQueryParameter("COPY", m3COPY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DEV))
				request.WithQueryParameter("DEV", m3DEV.Trim());
			if (!string.IsNullOrWhiteSpace(m3FOVR))
				request.WithQueryParameter("FOVR", m3FOVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3BINX))
				request.WithQueryParameter("BINX", m3BINX.Trim());
			if (m3CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3CPPL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TRAY))
				request.WithQueryParameter("TRAY", m3TRAY.Trim());
			if (!string.IsNullOrWhiteSpace(m3LAYC))
				request.WithQueryParameter("LAYC", m3LAYC.Trim());
			if (!string.IsNullOrWhiteSpace(m3MARI))
				request.WithQueryParameter("MARI", m3MARI.Trim());
			if (m3ARCH.HasValue)
				request.WithQueryParameter("ARCH", m3ARCH.Value.ToString(CultureInfo.CurrentCulture));

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
