/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_PRTF">Printer file (Required)</param>
		/// <param name="m3_RPLY">XML structure (Required)</param>
		/// <param name="m3_RPBK">XML section (Required)</param>
		/// <param name="m3_ESEQ">Element sequence number (Required)</param>
		/// <param name="m3_LNCD">Language (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLngTxtOVNM(
			string m3_PRTF, 
			string m3_RPLY, 
			int m3_RPBK, 
			int m3_ESEQ, 
			string m3_LNCD, 
			string m3_TX40, 
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
			if (string.IsNullOrWhiteSpace(m3_PRTF))
				throw new ArgumentNullException("m3_PRTF");
			if (string.IsNullOrWhiteSpace(m3_RPLY))
				throw new ArgumentNullException("m3_RPLY");
			if (string.IsNullOrWhiteSpace(m3_LNCD))
				throw new ArgumentNullException("m3_LNCD");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3_PRTF.Trim())
				.WithQueryParameter("RPLY", m3_RPLY.Trim())
				.WithQueryParameter("RPBK", m3_RPBK.ToString())
				.WithQueryParameter("ESEQ", m3_ESEQ.ToString())
				.WithQueryParameter("LNCD", m3_LNCD.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim());

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
		/// Name AddLngTxtTX40
		/// Description AddLngTxtTX40
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRTF">Printer file (Required)</param>
		/// <param name="m3_RPLY">XML structure (Required)</param>
		/// <param name="m3_RPBK">XML section (Required)</param>
		/// <param name="m3_ESEQ">Element sequence number (Required)</param>
		/// <param name="m3_LNCD">Language (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLngTxtTX40(
			string m3_PRTF, 
			string m3_RPLY, 
			int m3_RPBK, 
			int m3_ESEQ, 
			string m3_LNCD, 
			string m3_TX40, 
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
			if (string.IsNullOrWhiteSpace(m3_PRTF))
				throw new ArgumentNullException("m3_PRTF");
			if (string.IsNullOrWhiteSpace(m3_RPLY))
				throw new ArgumentNullException("m3_RPLY");
			if (string.IsNullOrWhiteSpace(m3_LNCD))
				throw new ArgumentNullException("m3_LNCD");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3_PRTF.Trim())
				.WithQueryParameter("RPLY", m3_RPLY.Trim())
				.WithQueryParameter("RPBK", m3_RPBK.ToString())
				.WithQueryParameter("ESEQ", m3_ESEQ.ToString())
				.WithQueryParameter("LNCD", m3_LNCD.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim());

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
		/// Name AddXmlAttribute
		/// Description Add Xml attribute
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_PRTF">Printer file (Required)</param>
		/// <param name="m3_RPLY">XML structure (Required)</param>
		/// <param name="m3_RPBK">XML section (Required)</param>
		/// <param name="m3_ESEQ">Element sequence number (Required)</param>
		/// <param name="m3_ATN1">Attribute name (Required)</param>
		/// <param name="m3_BDA1">Source of data (Required)</param>
		/// <param name="m3_OBJ1">Field</param>
		/// <param name="m3_SPV1">Specific value</param>
		/// <param name="m3_XMLA">XML attribute</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddXmlAttribute(
			string m3_PRTF, 
			string m3_RPLY, 
			int m3_RPBK, 
			int m3_ESEQ, 
			string m3_ATN1, 
			int m3_BDA1, 
			string m3_OBJ1 = null, 
			string m3_SPV1 = null, 
			int? m3_XMLA = null, 
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
			if (string.IsNullOrWhiteSpace(m3_PRTF))
				throw new ArgumentNullException("m3_PRTF");
			if (string.IsNullOrWhiteSpace(m3_RPLY))
				throw new ArgumentNullException("m3_RPLY");
			if (string.IsNullOrWhiteSpace(m3_ATN1))
				throw new ArgumentNullException("m3_ATN1");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3_PRTF.Trim())
				.WithQueryParameter("RPLY", m3_RPLY.Trim())
				.WithQueryParameter("RPBK", m3_RPBK.ToString())
				.WithQueryParameter("ESEQ", m3_ESEQ.ToString())
				.WithQueryParameter("ATN1", m3_ATN1.Trim())
				.WithQueryParameter("BDA1", m3_BDA1.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBJ1))
				request.WithQueryParameter("OBJ1", m3_OBJ1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPV1))
				request.WithQueryParameter("SPV1", m3_SPV1.Trim());
			if (m3_XMLA.HasValue)
				request.WithQueryParameter("XMLA", m3_XMLA.Value.ToString());

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
		/// Name AddXmlElement
		/// Description Add a XML element
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRTF">Printer file (Required)</param>
		/// <param name="m3_RPLY">XML structure (Required)</param>
		/// <param name="m3_ELNT">Element type (Required)</param>
		/// <param name="m3_BDAT">Source of data (Required)</param>
		/// <param name="m3_LAIC">Label (Required)</param>
		/// <param name="m3_RPBK">XML section</param>
		/// <param name="m3_ESEQ">Element sequence number</param>
		/// <param name="m3_DTTY">Data type</param>
		/// <param name="m3_UCON">Update at report run</param>
		/// <param name="m3_SPEV">Specific value</param>
		/// <param name="m3_OBJC">Field</param>
		/// <param name="m3_RPB2">XML section</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_ELNM">Element name</param>
		/// <param name="m3_OVM7">Overriding message ID</param>
		/// <param name="m3_MSGF">Message file</param>
		/// <param name="m3_OVNM">Overriding name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddXmlElement(
			string m3_PRTF, 
			string m3_RPLY, 
			int m3_ELNT, 
			int m3_BDAT, 
			int m3_LAIC, 
			int? m3_RPBK = null, 
			int? m3_ESEQ = null, 
			int? m3_DTTY = null, 
			int? m3_UCON = null, 
			string m3_SPEV = null, 
			string m3_OBJC = null, 
			int? m3_RPB2 = null, 
			string m3_TX40 = null, 
			string m3_ELNM = null, 
			string m3_OVM7 = null, 
			string m3_MSGF = null, 
			string m3_OVNM = null, 
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
			if (string.IsNullOrWhiteSpace(m3_PRTF))
				throw new ArgumentNullException("m3_PRTF");
			if (string.IsNullOrWhiteSpace(m3_RPLY))
				throw new ArgumentNullException("m3_RPLY");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3_PRTF.Trim())
				.WithQueryParameter("RPLY", m3_RPLY.Trim())
				.WithQueryParameter("ELNT", m3_ELNT.ToString())
				.WithQueryParameter("BDAT", m3_BDAT.ToString())
				.WithQueryParameter("LAIC", m3_LAIC.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3_RPBK.Value.ToString());
			if (m3_ESEQ.HasValue)
				request.WithQueryParameter("ESEQ", m3_ESEQ.Value.ToString());
			if (m3_DTTY.HasValue)
				request.WithQueryParameter("DTTY", m3_DTTY.Value.ToString());
			if (m3_UCON.HasValue)
				request.WithQueryParameter("UCON", m3_UCON.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPEV))
				request.WithQueryParameter("SPEV", m3_SPEV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBJC))
				request.WithQueryParameter("OBJC", m3_OBJC.Trim());
			if (m3_RPB2.HasValue)
				request.WithQueryParameter("RPB2", m3_RPB2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNM))
				request.WithQueryParameter("ELNM", m3_ELNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVM7))
				request.WithQueryParameter("OVM7", m3_OVM7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSGF))
				request.WithQueryParameter("MSGF", m3_MSGF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVNM))
				request.WithQueryParameter("OVNM", m3_OVNM.Trim());

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
		/// Name DltLngTxtOVNM
		/// Description DltLngTxtOVNM
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRTF">Printer file (Required)</param>
		/// <param name="m3_RPLY">XML structure (Required)</param>
		/// <param name="m3_RPBK">XML section (Required)</param>
		/// <param name="m3_ESEQ">Element sequence number (Required)</param>
		/// <param name="m3_LNCD">Language (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltLngTxtOVNM(
			string m3_PRTF, 
			string m3_RPLY, 
			int m3_RPBK, 
			int m3_ESEQ, 
			string m3_LNCD, 
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
			if (string.IsNullOrWhiteSpace(m3_PRTF))
				throw new ArgumentNullException("m3_PRTF");
			if (string.IsNullOrWhiteSpace(m3_RPLY))
				throw new ArgumentNullException("m3_RPLY");
			if (string.IsNullOrWhiteSpace(m3_LNCD))
				throw new ArgumentNullException("m3_LNCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3_PRTF.Trim())
				.WithQueryParameter("RPLY", m3_RPLY.Trim())
				.WithQueryParameter("RPBK", m3_RPBK.ToString())
				.WithQueryParameter("ESEQ", m3_ESEQ.ToString())
				.WithQueryParameter("LNCD", m3_LNCD.Trim());

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
		/// Name DltLngTxtTX40
		/// Description DltLngTxtTX40
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRTF">Printer file (Required)</param>
		/// <param name="m3_RPLY">XML structure (Required)</param>
		/// <param name="m3_RPBK">XML section (Required)</param>
		/// <param name="m3_ESEQ">Element sequence number (Required)</param>
		/// <param name="m3_LNCD">Language (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltLngTxtTX40(
			string m3_PRTF, 
			string m3_RPLY, 
			int m3_RPBK, 
			int m3_ESEQ, 
			string m3_LNCD, 
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
			if (string.IsNullOrWhiteSpace(m3_PRTF))
				throw new ArgumentNullException("m3_PRTF");
			if (string.IsNullOrWhiteSpace(m3_RPLY))
				throw new ArgumentNullException("m3_RPLY");
			if (string.IsNullOrWhiteSpace(m3_LNCD))
				throw new ArgumentNullException("m3_LNCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3_PRTF.Trim())
				.WithQueryParameter("RPLY", m3_RPLY.Trim())
				.WithQueryParameter("RPBK", m3_RPBK.ToString())
				.WithQueryParameter("ESEQ", m3_ESEQ.ToString())
				.WithQueryParameter("LNCD", m3_LNCD.Trim());

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
		/// Name DltXmlAttribute
		/// Description Delete Xml attribute
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRTF">Printer file (Required)</param>
		/// <param name="m3_RPLY">XML structure (Required)</param>
		/// <param name="m3_RPBK">XML section (Required)</param>
		/// <param name="m3_ESEQ">Element sequence number (Required)</param>
		/// <param name="m3_XMLA">XML attribute (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltXmlAttribute(
			string m3_PRTF, 
			string m3_RPLY, 
			int m3_RPBK, 
			int m3_ESEQ, 
			int m3_XMLA, 
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
			if (string.IsNullOrWhiteSpace(m3_PRTF))
				throw new ArgumentNullException("m3_PRTF");
			if (string.IsNullOrWhiteSpace(m3_RPLY))
				throw new ArgumentNullException("m3_RPLY");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3_PRTF.Trim())
				.WithQueryParameter("RPLY", m3_RPLY.Trim())
				.WithQueryParameter("RPBK", m3_RPBK.ToString())
				.WithQueryParameter("ESEQ", m3_ESEQ.ToString())
				.WithQueryParameter("XMLA", m3_XMLA.ToString());

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
		/// Name DltXmlElement
		/// Description Delete a XML element
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRTF">Printer file (Required)</param>
		/// <param name="m3_RPLY">XML structure (Required)</param>
		/// <param name="m3_RPBK">XML section (Required)</param>
		/// <param name="m3_ESEQ">Element sequence number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltXmlElement(
			string m3_PRTF, 
			string m3_RPLY, 
			int m3_RPBK, 
			int m3_ESEQ, 
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
			if (string.IsNullOrWhiteSpace(m3_PRTF))
				throw new ArgumentNullException("m3_PRTF");
			if (string.IsNullOrWhiteSpace(m3_RPLY))
				throw new ArgumentNullException("m3_RPLY");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3_PRTF.Trim())
				.WithQueryParameter("RPLY", m3_RPLY.Trim())
				.WithQueryParameter("RPBK", m3_RPBK.ToString())
				.WithQueryParameter("ESEQ", m3_ESEQ.ToString());

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
		/// Name GetXmlAttribute
		/// Description GetXmlAttribute
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRTF">Printer file (Required)</param>
		/// <param name="m3_RPLY">XML structure (Required)</param>
		/// <param name="m3_RPBK">XML section (Required)</param>
		/// <param name="m3_ESEQ">Element sequence number (Required)</param>
		/// <param name="m3_XMLA">XML attribute (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetXmlAttributeResponse></returns>
		/// <exception cref="M3Exception<GetXmlAttributeResponse>"></exception>
		public async Task<M3Response<GetXmlAttributeResponse>> GetXmlAttribute(
			string m3_PRTF, 
			string m3_RPLY, 
			int m3_RPBK, 
			int m3_ESEQ, 
			int m3_XMLA, 
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
			if (string.IsNullOrWhiteSpace(m3_PRTF))
				throw new ArgumentNullException("m3_PRTF");
			if (string.IsNullOrWhiteSpace(m3_RPLY))
				throw new ArgumentNullException("m3_RPLY");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3_PRTF.Trim())
				.WithQueryParameter("RPLY", m3_RPLY.Trim())
				.WithQueryParameter("RPBK", m3_RPBK.ToString())
				.WithQueryParameter("ESEQ", m3_ESEQ.ToString())
				.WithQueryParameter("XMLA", m3_XMLA.ToString());

			// Execute the request
			var result = await Execute<GetXmlAttributeResponse>(
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
		/// Name GetXmlElement
		/// Description Get data for a XML element
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRTF">Printer file (Required)</param>
		/// <param name="m3_RPLY">XML structure (Required)</param>
		/// <param name="m3_RPBK">XML section (Required)</param>
		/// <param name="m3_ESEQ">Element sequence number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetXmlElementResponse></returns>
		/// <exception cref="M3Exception<GetXmlElementResponse>"></exception>
		public async Task<M3Response<GetXmlElementResponse>> GetXmlElement(
			string m3_PRTF, 
			string m3_RPLY, 
			int m3_RPBK, 
			int m3_ESEQ, 
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
			if (string.IsNullOrWhiteSpace(m3_PRTF))
				throw new ArgumentNullException("m3_PRTF");
			if (string.IsNullOrWhiteSpace(m3_RPLY))
				throw new ArgumentNullException("m3_RPLY");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3_PRTF.Trim())
				.WithQueryParameter("RPLY", m3_RPLY.Trim())
				.WithQueryParameter("RPBK", m3_RPBK.ToString())
				.WithQueryParameter("ESEQ", m3_ESEQ.ToString());

			// Execute the request
			var result = await Execute<GetXmlElementResponse>(
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
		/// Name LstXmlElements
		/// Description List data for XML structures
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRTF">Printer file</param>
		/// <param name="m3_RPLY">XML structure</param>
		/// <param name="m3_RPBK">XML section</param>
		/// <param name="m3_ESEQ">Element sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstXmlElementsResponse></returns>
		/// <exception cref="M3Exception<LstXmlElementsResponse>"></exception>
		public async Task<M3Response<LstXmlElementsResponse>> LstXmlElements(
			string m3_PRTF = null, 
			string m3_RPLY = null, 
			int? m3_RPBK = null, 
			int? m3_ESEQ = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_PRTF))
				request.WithQueryParameter("PRTF", m3_PRTF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RPLY))
				request.WithQueryParameter("RPLY", m3_RPLY.Trim());
			if (m3_RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3_RPBK.Value.ToString());
			if (m3_ESEQ.HasValue)
				request.WithQueryParameter("ESEQ", m3_ESEQ.Value.ToString());

			// Execute the request
			var result = await Execute<LstXmlElementsResponse>(
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
		/// Name UpdXmlElement
		/// Description Update data for a XML element
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRTF">Printer file (Required)</param>
		/// <param name="m3_RPLY">XML structure (Required)</param>
		/// <param name="m3_RPBK">XML section (Required)</param>
		/// <param name="m3_ESEQ">Element sequence number (Required)</param>
		/// <param name="m3_BDAT">Source of data</param>
		/// <param name="m3_DTTY">Data type</param>
		/// <param name="m3_UCON">Update at report run</param>
		/// <param name="m3_SPEV">Specific value</param>
		/// <param name="m3_OBJC">Field</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_ELNM">Element name</param>
		/// <param name="m3_LAIC">Label</param>
		/// <param name="m3_OVM7">Overriding message ID</param>
		/// <param name="m3_MSGF">Message file</param>
		/// <param name="m3_OVNM">Overriding name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdXmlElement(
			string m3_PRTF, 
			string m3_RPLY, 
			int m3_RPBK, 
			int m3_ESEQ, 
			int? m3_BDAT = null, 
			int? m3_DTTY = null, 
			int? m3_UCON = null, 
			string m3_SPEV = null, 
			string m3_OBJC = null, 
			string m3_TX40 = null, 
			string m3_ELNM = null, 
			int? m3_LAIC = null, 
			string m3_OVM7 = null, 
			string m3_MSGF = null, 
			string m3_OVNM = null, 
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
			if (string.IsNullOrWhiteSpace(m3_PRTF))
				throw new ArgumentNullException("m3_PRTF");
			if (string.IsNullOrWhiteSpace(m3_RPLY))
				throw new ArgumentNullException("m3_RPLY");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3_PRTF.Trim())
				.WithQueryParameter("RPLY", m3_RPLY.Trim())
				.WithQueryParameter("RPBK", m3_RPBK.ToString())
				.WithQueryParameter("ESEQ", m3_ESEQ.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_BDAT.HasValue)
				request.WithQueryParameter("BDAT", m3_BDAT.Value.ToString());
			if (m3_DTTY.HasValue)
				request.WithQueryParameter("DTTY", m3_DTTY.Value.ToString());
			if (m3_UCON.HasValue)
				request.WithQueryParameter("UCON", m3_UCON.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPEV))
				request.WithQueryParameter("SPEV", m3_SPEV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBJC))
				request.WithQueryParameter("OBJC", m3_OBJC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNM))
				request.WithQueryParameter("ELNM", m3_ELNM.Trim());
			if (m3_LAIC.HasValue)
				request.WithQueryParameter("LAIC", m3_LAIC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OVM7))
				request.WithQueryParameter("OVM7", m3_OVM7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSGF))
				request.WithQueryParameter("MSGF", m3_MSGF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVNM))
				request.WithQueryParameter("OVNM", m3_OVNM.Trim());

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
