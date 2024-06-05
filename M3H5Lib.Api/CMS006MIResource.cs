/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CMS006MI;
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
	/// Name: CMS006MI
	/// Component Name: XML structure
	/// Description: XML structure interface
	/// Version Release: 5ea1
	///</summary>
	public partial class CMS006MIResource : M3BaseResourceEndpoint
	{
		public CMS006MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS006MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddXmlStructure
		/// Description Add a XML structure
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRTF">Printer file (Required)</param>
		/// <param name="m3_RPLY">XML structure (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_XMLF">Format</param>
		/// <param name="m3_XMLT">Variant</param>
		/// <param name="m3_SPKY">Split XML file</param>
		/// <param name="m3_RELM">Root element</param>
		/// <param name="m3_NMSP">Default namespace</param>
		/// <param name="m3_NMS1">Namespace 1</param>
		/// <param name="m3_PRE1">Prefix for namespace 1</param>
		/// <param name="m3_SCNP">Schema namespace</param>
		/// <param name="m3_SCHM">Schema</param>
		/// <param name="m3_ELNM">Element name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddXmlStructure(
			string m3_PRTF, 
			string m3_RPLY, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			int? m3_XMLF = null, 
			int? m3_XMLT = null, 
			int? m3_SPKY = null, 
			string m3_RELM = null, 
			string m3_NMSP = null, 
			string m3_NMS1 = null, 
			string m3_PRE1 = null, 
			string m3_SCNP = null, 
			string m3_SCHM = null, 
			string m3_ELNM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddXmlStructure",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRTF))
				throw new ArgumentNullException("m3_PRTF");
			if (string.IsNullOrWhiteSpace(m3_RPLY))
				throw new ArgumentNullException("m3_RPLY");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3_PRTF.Trim())
				.WithQueryParameter("RPLY", m3_RPLY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_XMLF.HasValue)
				request.WithQueryParameter("XMLF", m3_XMLF.Value.ToString());
			if (m3_XMLT.HasValue)
				request.WithQueryParameter("XMLT", m3_XMLT.Value.ToString());
			if (m3_SPKY.HasValue)
				request.WithQueryParameter("SPKY", m3_SPKY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RELM))
				request.WithQueryParameter("RELM", m3_RELM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NMSP))
				request.WithQueryParameter("NMSP", m3_NMSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NMS1))
				request.WithQueryParameter("NMS1", m3_NMS1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRE1))
				request.WithQueryParameter("PRE1", m3_PRE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCNP))
				request.WithQueryParameter("SCNP", m3_SCNP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCHM))
				request.WithQueryParameter("SCHM", m3_SCHM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNM))
				request.WithQueryParameter("ELNM", m3_ELNM.Trim());

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
		/// Name DltXmlStructure
		/// Description Delete a XML structure
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRTF">Printer file (Required)</param>
		/// <param name="m3_RPLY">XML structure (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltXmlStructure(
			string m3_PRTF, 
			string m3_RPLY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltXmlStructure",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRTF))
				throw new ArgumentNullException("m3_PRTF");
			if (string.IsNullOrWhiteSpace(m3_RPLY))
				throw new ArgumentNullException("m3_RPLY");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3_PRTF.Trim())
				.WithQueryParameter("RPLY", m3_RPLY.Trim());

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
		/// Name GetXmlStructure
		/// Description Get data for a XML structure
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRTF">Printer file (Required)</param>
		/// <param name="m3_RPLY">XML structure (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetXmlStructureResponse></returns>
		/// <exception cref="M3Exception<GetXmlStructureResponse>"></exception>
		public async Task<M3Response<GetXmlStructureResponse>> GetXmlStructure(
			string m3_PRTF, 
			string m3_RPLY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetXmlStructure",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRTF))
				throw new ArgumentNullException("m3_PRTF");
			if (string.IsNullOrWhiteSpace(m3_RPLY))
				throw new ArgumentNullException("m3_RPLY");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3_PRTF.Trim())
				.WithQueryParameter("RPLY", m3_RPLY.Trim());

			// Execute the request
			var result = await Execute<GetXmlStructureResponse>(
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
		/// Name LstXmlStructs
		/// Description List data for XML structures
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRTF">Printer file</param>
		/// <param name="m3_RPLY">XML structure</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstXmlStructsResponse></returns>
		/// <exception cref="M3Exception<LstXmlStructsResponse>"></exception>
		public async Task<M3Response<LstXmlStructsResponse>> LstXmlStructs(
			string m3_PRTF = null, 
			string m3_RPLY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstXmlStructs",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRTF))
				request.WithQueryParameter("PRTF", m3_PRTF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RPLY))
				request.WithQueryParameter("RPLY", m3_RPLY.Trim());

			// Execute the request
			var result = await Execute<LstXmlStructsResponse>(
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
		/// Name UpdXmlArchAttr
		/// Description Update an archive attribute
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRTF">Printer file (Required)</param>
		/// <param name="m3_RPLY">XML structure (Required)</param>
		/// <param name="m3_XMLA">XML attribute (Required)</param>
		/// <param name="m3_RPBK">XML section</param>
		/// <param name="m3_ESEQ">Element sequence number</param>
		/// <param name="m3_ATNM">Attribute name</param>
		/// <param name="m3_SPEV">Specific value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdXmlArchAttr(
			string m3_PRTF, 
			string m3_RPLY, 
			int m3_XMLA, 
			int? m3_RPBK = null, 
			int? m3_ESEQ = null, 
			string m3_ATNM = null, 
			string m3_SPEV = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdXmlArchAttr",
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
				.WithQueryParameter("XMLA", m3_XMLA.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3_RPBK.Value.ToString());
			if (m3_ESEQ.HasValue)
				request.WithQueryParameter("ESEQ", m3_ESEQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ATNM))
				request.WithQueryParameter("ATNM", m3_ATNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPEV))
				request.WithQueryParameter("SPEV", m3_SPEV.Trim());

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
		/// Name UpdXmlStructure
		/// Description Update data for a XML structure
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRTF">Printer file (Required)</param>
		/// <param name="m3_RPLY">XML structure (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_XMLF">Format</param>
		/// <param name="m3_XMLT">Variant</param>
		/// <param name="m3_SPKY">Split XML file</param>
		/// <param name="m3_RELM">Root element</param>
		/// <param name="m3_NMSP">Default namespace</param>
		/// <param name="m3_NMS1">Namespace 1</param>
		/// <param name="m3_PRE1">Prefix for namespace 1</param>
		/// <param name="m3_SCNP">Schema namespace</param>
		/// <param name="m3_SCHM">Schema</param>
		/// <param name="m3_ELNM">Element name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdXmlStructure(
			string m3_PRTF, 
			string m3_RPLY, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			int? m3_XMLF = null, 
			int? m3_XMLT = null, 
			int? m3_SPKY = null, 
			string m3_RELM = null, 
			string m3_NMSP = null, 
			string m3_NMS1 = null, 
			string m3_PRE1 = null, 
			string m3_SCNP = null, 
			string m3_SCHM = null, 
			string m3_ELNM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdXmlStructure",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRTF))
				throw new ArgumentNullException("m3_PRTF");
			if (string.IsNullOrWhiteSpace(m3_RPLY))
				throw new ArgumentNullException("m3_RPLY");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3_PRTF.Trim())
				.WithQueryParameter("RPLY", m3_RPLY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_XMLF.HasValue)
				request.WithQueryParameter("XMLF", m3_XMLF.Value.ToString());
			if (m3_XMLT.HasValue)
				request.WithQueryParameter("XMLT", m3_XMLT.Value.ToString());
			if (m3_SPKY.HasValue)
				request.WithQueryParameter("SPKY", m3_SPKY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RELM))
				request.WithQueryParameter("RELM", m3_RELM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NMSP))
				request.WithQueryParameter("NMSP", m3_NMSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NMS1))
				request.WithQueryParameter("NMS1", m3_NMS1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRE1))
				request.WithQueryParameter("PRE1", m3_PRE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCNP))
				request.WithQueryParameter("SCNP", m3_SCNP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCHM))
				request.WithQueryParameter("SCHM", m3_SCHM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNM))
				request.WithQueryParameter("ELNM", m3_ELNM.Trim());

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
