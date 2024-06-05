/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.CMS009MI;
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
	/// Name: CMS009MI
	/// Component Name: XML structure
	/// Description: XML structure interface
	/// Version Release: 5ea1
	///</summary>
	public partial class CMS009MIResource : M3BaseResourceEndpoint
	{
		public CMS009MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS009MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddLngTxtOVNM
		/// Description AddLngTxtOVNM
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRTF">Printer file (Required)</param>
		/// <param name="m3RPLY">XML structure (Required)</param>
		/// <param name="m3RPBK">XML section (Required)</param>
		/// <param name="m3ESEQ">Element sequence number (Required)</param>
		/// <param name="m3LNCD">Language (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLngTxtOVNM(
			string m3PRTF, 
			string m3RPLY, 
			int m3RPBK, 
			int m3ESEQ, 
			string m3LNCD, 
			string m3TX40, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLngTxtOVNM",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRTF))
				throw new ArgumentNullException(nameof(m3PRTF));
			if (string.IsNullOrWhiteSpace(m3RPLY))
				throw new ArgumentNullException(nameof(m3RPLY));
			if (string.IsNullOrWhiteSpace(m3LNCD))
				throw new ArgumentNullException(nameof(m3LNCD));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3PRTF.Trim())
				.WithQueryParameter("RPLY", m3RPLY.Trim())
				.WithQueryParameter("RPBK", m3RPBK.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ESEQ", m3ESEQ.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("LNCD", m3LNCD.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim());

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
		/// Name AddLngTxtTX40
		/// Description AddLngTxtTX40
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRTF">Printer file (Required)</param>
		/// <param name="m3RPLY">XML structure (Required)</param>
		/// <param name="m3RPBK">XML section (Required)</param>
		/// <param name="m3ESEQ">Element sequence number (Required)</param>
		/// <param name="m3LNCD">Language (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLngTxtTX40(
			string m3PRTF, 
			string m3RPLY, 
			int m3RPBK, 
			int m3ESEQ, 
			string m3LNCD, 
			string m3TX40, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLngTxtTX40",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRTF))
				throw new ArgumentNullException(nameof(m3PRTF));
			if (string.IsNullOrWhiteSpace(m3RPLY))
				throw new ArgumentNullException(nameof(m3RPLY));
			if (string.IsNullOrWhiteSpace(m3LNCD))
				throw new ArgumentNullException(nameof(m3LNCD));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3PRTF.Trim())
				.WithQueryParameter("RPLY", m3RPLY.Trim())
				.WithQueryParameter("RPBK", m3RPBK.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ESEQ", m3ESEQ.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("LNCD", m3LNCD.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim());

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
		/// Name AddXmlAttribute
		/// Description Add Xml attribute
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3PRTF">Printer file (Required)</param>
		/// <param name="m3RPLY">XML structure (Required)</param>
		/// <param name="m3RPBK">XML section (Required)</param>
		/// <param name="m3ESEQ">Element sequence number (Required)</param>
		/// <param name="m3ATN1">Attribute name (Required)</param>
		/// <param name="m3BDA1">Source of data (Required)</param>
		/// <param name="m3OBJ1">Field</param>
		/// <param name="m3SPV1">Specific value</param>
		/// <param name="m3XMLA">XML attribute</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddXmlAttribute(
			string m3PRTF, 
			string m3RPLY, 
			int m3RPBK, 
			int m3ESEQ, 
			string m3ATN1, 
			int m3BDA1, 
			string m3OBJ1 = null, 
			string m3SPV1 = null, 
			int? m3XMLA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddXmlAttribute",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRTF))
				throw new ArgumentNullException(nameof(m3PRTF));
			if (string.IsNullOrWhiteSpace(m3RPLY))
				throw new ArgumentNullException(nameof(m3RPLY));
			if (string.IsNullOrWhiteSpace(m3ATN1))
				throw new ArgumentNullException(nameof(m3ATN1));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3PRTF.Trim())
				.WithQueryParameter("RPLY", m3RPLY.Trim())
				.WithQueryParameter("RPBK", m3RPBK.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ESEQ", m3ESEQ.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ATN1", m3ATN1.Trim())
				.WithQueryParameter("BDA1", m3BDA1.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBJ1))
				request.WithQueryParameter("OBJ1", m3OBJ1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPV1))
				request.WithQueryParameter("SPV1", m3SPV1.Trim());
			if (m3XMLA.HasValue)
				request.WithQueryParameter("XMLA", m3XMLA.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddXmlElement
		/// Description Add a XML element
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRTF">Printer file (Required)</param>
		/// <param name="m3RPLY">XML structure (Required)</param>
		/// <param name="m3ELNT">Element type (Required)</param>
		/// <param name="m3BDAT">Source of data (Required)</param>
		/// <param name="m3LAIC">Label (Required)</param>
		/// <param name="m3RPBK">XML section</param>
		/// <param name="m3ESEQ">Element sequence number</param>
		/// <param name="m3DTTY">Data type</param>
		/// <param name="m3UCON">Update at report run</param>
		/// <param name="m3SPEV">Specific value</param>
		/// <param name="m3OBJC">Field</param>
		/// <param name="m3RPB2">XML section</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3ELNM">Element name</param>
		/// <param name="m3OVM7">Overriding message ID</param>
		/// <param name="m3MSGF">Message file</param>
		/// <param name="m3OVNM">Overriding name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddXmlElement(
			string m3PRTF, 
			string m3RPLY, 
			int m3ELNT, 
			int m3BDAT, 
			int m3LAIC, 
			int? m3RPBK = null, 
			int? m3ESEQ = null, 
			int? m3DTTY = null, 
			int? m3UCON = null, 
			string m3SPEV = null, 
			string m3OBJC = null, 
			int? m3RPB2 = null, 
			string m3TX40 = null, 
			string m3ELNM = null, 
			string m3OVM7 = null, 
			string m3MSGF = null, 
			string m3OVNM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddXmlElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRTF))
				throw new ArgumentNullException(nameof(m3PRTF));
			if (string.IsNullOrWhiteSpace(m3RPLY))
				throw new ArgumentNullException(nameof(m3RPLY));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3PRTF.Trim())
				.WithQueryParameter("RPLY", m3RPLY.Trim())
				.WithQueryParameter("ELNT", m3ELNT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BDAT", m3BDAT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("LAIC", m3LAIC.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3RPBK.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ESEQ.HasValue)
				request.WithQueryParameter("ESEQ", m3ESEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTTY.HasValue)
				request.WithQueryParameter("DTTY", m3DTTY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UCON.HasValue)
				request.WithQueryParameter("UCON", m3UCON.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPEV))
				request.WithQueryParameter("SPEV", m3SPEV.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBJC))
				request.WithQueryParameter("OBJC", m3OBJC.Trim());
			if (m3RPB2.HasValue)
				request.WithQueryParameter("RPB2", m3RPB2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNM))
				request.WithQueryParameter("ELNM", m3ELNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVM7))
				request.WithQueryParameter("OVM7", m3OVM7.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSGF))
				request.WithQueryParameter("MSGF", m3MSGF.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVNM))
				request.WithQueryParameter("OVNM", m3OVNM.Trim());

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
		/// Name DltLngTxtOVNM
		/// Description DltLngTxtOVNM
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRTF">Printer file (Required)</param>
		/// <param name="m3RPLY">XML structure (Required)</param>
		/// <param name="m3RPBK">XML section (Required)</param>
		/// <param name="m3ESEQ">Element sequence number (Required)</param>
		/// <param name="m3LNCD">Language (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltLngTxtOVNM(
			string m3PRTF, 
			string m3RPLY, 
			int m3RPBK, 
			int m3ESEQ, 
			string m3LNCD, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltLngTxtOVNM",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRTF))
				throw new ArgumentNullException(nameof(m3PRTF));
			if (string.IsNullOrWhiteSpace(m3RPLY))
				throw new ArgumentNullException(nameof(m3RPLY));
			if (string.IsNullOrWhiteSpace(m3LNCD))
				throw new ArgumentNullException(nameof(m3LNCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3PRTF.Trim())
				.WithQueryParameter("RPLY", m3RPLY.Trim())
				.WithQueryParameter("RPBK", m3RPBK.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ESEQ", m3ESEQ.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("LNCD", m3LNCD.Trim());

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
		/// Name DltLngTxtTX40
		/// Description DltLngTxtTX40
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRTF">Printer file (Required)</param>
		/// <param name="m3RPLY">XML structure (Required)</param>
		/// <param name="m3RPBK">XML section (Required)</param>
		/// <param name="m3ESEQ">Element sequence number (Required)</param>
		/// <param name="m3LNCD">Language (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltLngTxtTX40(
			string m3PRTF, 
			string m3RPLY, 
			int m3RPBK, 
			int m3ESEQ, 
			string m3LNCD, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltLngTxtTX40",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRTF))
				throw new ArgumentNullException(nameof(m3PRTF));
			if (string.IsNullOrWhiteSpace(m3RPLY))
				throw new ArgumentNullException(nameof(m3RPLY));
			if (string.IsNullOrWhiteSpace(m3LNCD))
				throw new ArgumentNullException(nameof(m3LNCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3PRTF.Trim())
				.WithQueryParameter("RPLY", m3RPLY.Trim())
				.WithQueryParameter("RPBK", m3RPBK.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ESEQ", m3ESEQ.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("LNCD", m3LNCD.Trim());

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
		/// Name DltXmlAttribute
		/// Description Delete Xml attribute
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRTF">Printer file (Required)</param>
		/// <param name="m3RPLY">XML structure (Required)</param>
		/// <param name="m3RPBK">XML section (Required)</param>
		/// <param name="m3ESEQ">Element sequence number (Required)</param>
		/// <param name="m3XMLA">XML attribute (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltXmlAttribute(
			string m3PRTF, 
			string m3RPLY, 
			int m3RPBK, 
			int m3ESEQ, 
			int m3XMLA, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltXmlAttribute",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRTF))
				throw new ArgumentNullException(nameof(m3PRTF));
			if (string.IsNullOrWhiteSpace(m3RPLY))
				throw new ArgumentNullException(nameof(m3RPLY));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3PRTF.Trim())
				.WithQueryParameter("RPLY", m3RPLY.Trim())
				.WithQueryParameter("RPBK", m3RPBK.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ESEQ", m3ESEQ.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("XMLA", m3XMLA.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltXmlElement
		/// Description Delete a XML element
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRTF">Printer file (Required)</param>
		/// <param name="m3RPLY">XML structure (Required)</param>
		/// <param name="m3RPBK">XML section (Required)</param>
		/// <param name="m3ESEQ">Element sequence number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltXmlElement(
			string m3PRTF, 
			string m3RPLY, 
			int m3RPBK, 
			int m3ESEQ, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltXmlElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRTF))
				throw new ArgumentNullException(nameof(m3PRTF));
			if (string.IsNullOrWhiteSpace(m3RPLY))
				throw new ArgumentNullException(nameof(m3RPLY));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3PRTF.Trim())
				.WithQueryParameter("RPLY", m3RPLY.Trim())
				.WithQueryParameter("RPBK", m3RPBK.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ESEQ", m3ESEQ.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetXmlAttribute
		/// Description GetXmlAttribute
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRTF">Printer file (Required)</param>
		/// <param name="m3RPLY">XML structure (Required)</param>
		/// <param name="m3RPBK">XML section (Required)</param>
		/// <param name="m3ESEQ">Element sequence number (Required)</param>
		/// <param name="m3XMLA">XML attribute (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetXmlAttributeResponse></returns>
		/// <exception cref="M3Exception<GetXmlAttributeResponse>"></exception>
		public async Task<M3Response<GetXmlAttributeResponse>> GetXmlAttribute(
			string m3PRTF, 
			string m3RPLY, 
			int m3RPBK, 
			int m3ESEQ, 
			int m3XMLA, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetXmlAttribute",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRTF))
				throw new ArgumentNullException(nameof(m3PRTF));
			if (string.IsNullOrWhiteSpace(m3RPLY))
				throw new ArgumentNullException(nameof(m3RPLY));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3PRTF.Trim())
				.WithQueryParameter("RPLY", m3RPLY.Trim())
				.WithQueryParameter("RPBK", m3RPBK.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ESEQ", m3ESEQ.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("XMLA", m3XMLA.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetXmlAttributeResponse>(
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
		/// Name GetXmlElement
		/// Description Get data for a XML element
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRTF">Printer file (Required)</param>
		/// <param name="m3RPLY">XML structure (Required)</param>
		/// <param name="m3RPBK">XML section (Required)</param>
		/// <param name="m3ESEQ">Element sequence number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetXmlElementResponse></returns>
		/// <exception cref="M3Exception<GetXmlElementResponse>"></exception>
		public async Task<M3Response<GetXmlElementResponse>> GetXmlElement(
			string m3PRTF, 
			string m3RPLY, 
			int m3RPBK, 
			int m3ESEQ, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetXmlElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRTF))
				throw new ArgumentNullException(nameof(m3PRTF));
			if (string.IsNullOrWhiteSpace(m3RPLY))
				throw new ArgumentNullException(nameof(m3RPLY));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3PRTF.Trim())
				.WithQueryParameter("RPLY", m3RPLY.Trim())
				.WithQueryParameter("RPBK", m3RPBK.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ESEQ", m3ESEQ.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetXmlElementResponse>(
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
		/// Name LstXmlElements
		/// Description List data for XML structures
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRTF">Printer file</param>
		/// <param name="m3RPLY">XML structure</param>
		/// <param name="m3RPBK">XML section</param>
		/// <param name="m3ESEQ">Element sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstXmlElementsResponse></returns>
		/// <exception cref="M3Exception<LstXmlElementsResponse>"></exception>
		public async Task<M3Response<LstXmlElementsResponse>> LstXmlElements(
			string m3PRTF = null, 
			string m3RPLY = null, 
			int? m3RPBK = null, 
			int? m3ESEQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstXmlElements",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRTF))
				request.WithQueryParameter("PRTF", m3PRTF.Trim());
			if (!string.IsNullOrWhiteSpace(m3RPLY))
				request.WithQueryParameter("RPLY", m3RPLY.Trim());
			if (m3RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3RPBK.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ESEQ.HasValue)
				request.WithQueryParameter("ESEQ", m3ESEQ.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstXmlElementsResponse>(
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
		/// Name UpdXmlElement
		/// Description Update data for a XML element
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRTF">Printer file (Required)</param>
		/// <param name="m3RPLY">XML structure (Required)</param>
		/// <param name="m3RPBK">XML section (Required)</param>
		/// <param name="m3ESEQ">Element sequence number (Required)</param>
		/// <param name="m3BDAT">Source of data</param>
		/// <param name="m3DTTY">Data type</param>
		/// <param name="m3UCON">Update at report run</param>
		/// <param name="m3SPEV">Specific value</param>
		/// <param name="m3OBJC">Field</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3ELNM">Element name</param>
		/// <param name="m3LAIC">Label</param>
		/// <param name="m3OVM7">Overriding message ID</param>
		/// <param name="m3MSGF">Message file</param>
		/// <param name="m3OVNM">Overriding name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdXmlElement(
			string m3PRTF, 
			string m3RPLY, 
			int m3RPBK, 
			int m3ESEQ, 
			int? m3BDAT = null, 
			int? m3DTTY = null, 
			int? m3UCON = null, 
			string m3SPEV = null, 
			string m3OBJC = null, 
			string m3TX40 = null, 
			string m3ELNM = null, 
			int? m3LAIC = null, 
			string m3OVM7 = null, 
			string m3MSGF = null, 
			string m3OVNM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdXmlElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRTF))
				throw new ArgumentNullException(nameof(m3PRTF));
			if (string.IsNullOrWhiteSpace(m3RPLY))
				throw new ArgumentNullException(nameof(m3RPLY));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3PRTF.Trim())
				.WithQueryParameter("RPLY", m3RPLY.Trim())
				.WithQueryParameter("RPBK", m3RPBK.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ESEQ", m3ESEQ.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3BDAT.HasValue)
				request.WithQueryParameter("BDAT", m3BDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTTY.HasValue)
				request.WithQueryParameter("DTTY", m3DTTY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UCON.HasValue)
				request.WithQueryParameter("UCON", m3UCON.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPEV))
				request.WithQueryParameter("SPEV", m3SPEV.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBJC))
				request.WithQueryParameter("OBJC", m3OBJC.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNM))
				request.WithQueryParameter("ELNM", m3ELNM.Trim());
			if (m3LAIC.HasValue)
				request.WithQueryParameter("LAIC", m3LAIC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OVM7))
				request.WithQueryParameter("OVM7", m3OVM7.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSGF))
				request.WithQueryParameter("MSGF", m3MSGF.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVNM))
				request.WithQueryParameter("OVNM", m3OVNM.Trim());

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
