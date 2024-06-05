/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddXmlStructure
		/// Description Add a XML structure
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRTF">Printer file (Required)</param>
		/// <param name="m3RPLY">XML structure (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3XMLF">Format</param>
		/// <param name="m3XMLT">Variant</param>
		/// <param name="m3SPKY">Split XML file</param>
		/// <param name="m3RELM">Root element</param>
		/// <param name="m3NMSP">Default namespace</param>
		/// <param name="m3NMS1">Namespace 1</param>
		/// <param name="m3PRE1">Prefix for namespace 1</param>
		/// <param name="m3SCNP">Schema namespace</param>
		/// <param name="m3SCHM">Schema</param>
		/// <param name="m3ELNM">Element name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddXmlStructure(
			string m3PRTF, 
			string m3RPLY, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			int? m3XMLF = null, 
			int? m3XMLT = null, 
			int? m3SPKY = null, 
			string m3RELM = null, 
			string m3NMSP = null, 
			string m3NMS1 = null, 
			string m3PRE1 = null, 
			string m3SCNP = null, 
			string m3SCHM = null, 
			string m3ELNM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddXmlStructure",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRTF))
				throw new ArgumentNullException(nameof(m3PRTF));
			if (string.IsNullOrWhiteSpace(m3RPLY))
				throw new ArgumentNullException(nameof(m3RPLY));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3PRTF.Trim())
				.WithQueryParameter("RPLY", m3RPLY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3XMLF.HasValue)
				request.WithQueryParameter("XMLF", m3XMLF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3XMLT.HasValue)
				request.WithQueryParameter("XMLT", m3XMLT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPKY.HasValue)
				request.WithQueryParameter("SPKY", m3SPKY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RELM))
				request.WithQueryParameter("RELM", m3RELM.Trim());
			if (!string.IsNullOrWhiteSpace(m3NMSP))
				request.WithQueryParameter("NMSP", m3NMSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3NMS1))
				request.WithQueryParameter("NMS1", m3NMS1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRE1))
				request.WithQueryParameter("PRE1", m3PRE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SCNP))
				request.WithQueryParameter("SCNP", m3SCNP.Trim());
			if (!string.IsNullOrWhiteSpace(m3SCHM))
				request.WithQueryParameter("SCHM", m3SCHM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNM))
				request.WithQueryParameter("ELNM", m3ELNM.Trim());

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
		/// Name DltXmlStructure
		/// Description Delete a XML structure
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRTF">Printer file (Required)</param>
		/// <param name="m3RPLY">XML structure (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltXmlStructure(
			string m3PRTF, 
			string m3RPLY, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltXmlStructure",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRTF))
				throw new ArgumentNullException(nameof(m3PRTF));
			if (string.IsNullOrWhiteSpace(m3RPLY))
				throw new ArgumentNullException(nameof(m3RPLY));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3PRTF.Trim())
				.WithQueryParameter("RPLY", m3RPLY.Trim());

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
		/// Name GetXmlStructure
		/// Description Get data for a XML structure
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRTF">Printer file (Required)</param>
		/// <param name="m3RPLY">XML structure (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetXmlStructureResponse></returns>
		/// <exception cref="M3Exception<GetXmlStructureResponse>"></exception>
		public async Task<M3Response<GetXmlStructureResponse>> GetXmlStructure(
			string m3PRTF, 
			string m3RPLY, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetXmlStructure",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRTF))
				throw new ArgumentNullException(nameof(m3PRTF));
			if (string.IsNullOrWhiteSpace(m3RPLY))
				throw new ArgumentNullException(nameof(m3RPLY));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3PRTF.Trim())
				.WithQueryParameter("RPLY", m3RPLY.Trim());

			// Execute the request
			var result = await Execute<GetXmlStructureResponse>(
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
		/// Name LstXmlStructs
		/// Description List data for XML structures
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRTF">Printer file</param>
		/// <param name="m3RPLY">XML structure</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstXmlStructsResponse></returns>
		/// <exception cref="M3Exception<LstXmlStructsResponse>"></exception>
		public async Task<M3Response<LstXmlStructsResponse>> LstXmlStructs(
			string m3PRTF = null, 
			string m3RPLY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstXmlStructs",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRTF))
				request.WithQueryParameter("PRTF", m3PRTF.Trim());
			if (!string.IsNullOrWhiteSpace(m3RPLY))
				request.WithQueryParameter("RPLY", m3RPLY.Trim());

			// Execute the request
			var result = await Execute<LstXmlStructsResponse>(
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
		/// Name UpdXmlArchAttr
		/// Description Update an archive attribute
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRTF">Printer file (Required)</param>
		/// <param name="m3RPLY">XML structure (Required)</param>
		/// <param name="m3XMLA">XML attribute (Required)</param>
		/// <param name="m3RPBK">XML section</param>
		/// <param name="m3ESEQ">Element sequence number</param>
		/// <param name="m3ATNM">Attribute name</param>
		/// <param name="m3SPEV">Specific value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdXmlArchAttr(
			string m3PRTF, 
			string m3RPLY, 
			int m3XMLA, 
			int? m3RPBK = null, 
			int? m3ESEQ = null, 
			string m3ATNM = null, 
			string m3SPEV = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdXmlArchAttr",
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
				.WithQueryParameter("XMLA", m3XMLA.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3RPBK.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ESEQ.HasValue)
				request.WithQueryParameter("ESEQ", m3ESEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ATNM))
				request.WithQueryParameter("ATNM", m3ATNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPEV))
				request.WithQueryParameter("SPEV", m3SPEV.Trim());

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
		/// Name UpdXmlStructure
		/// Description Update data for a XML structure
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRTF">Printer file (Required)</param>
		/// <param name="m3RPLY">XML structure (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3XMLF">Format</param>
		/// <param name="m3XMLT">Variant</param>
		/// <param name="m3SPKY">Split XML file</param>
		/// <param name="m3RELM">Root element</param>
		/// <param name="m3NMSP">Default namespace</param>
		/// <param name="m3NMS1">Namespace 1</param>
		/// <param name="m3PRE1">Prefix for namespace 1</param>
		/// <param name="m3SCNP">Schema namespace</param>
		/// <param name="m3SCHM">Schema</param>
		/// <param name="m3ELNM">Element name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdXmlStructure(
			string m3PRTF, 
			string m3RPLY, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			int? m3XMLF = null, 
			int? m3XMLT = null, 
			int? m3SPKY = null, 
			string m3RELM = null, 
			string m3NMSP = null, 
			string m3NMS1 = null, 
			string m3PRE1 = null, 
			string m3SCNP = null, 
			string m3SCHM = null, 
			string m3ELNM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdXmlStructure",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRTF))
				throw new ArgumentNullException(nameof(m3PRTF));
			if (string.IsNullOrWhiteSpace(m3RPLY))
				throw new ArgumentNullException(nameof(m3RPLY));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3PRTF.Trim())
				.WithQueryParameter("RPLY", m3RPLY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3XMLF.HasValue)
				request.WithQueryParameter("XMLF", m3XMLF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3XMLT.HasValue)
				request.WithQueryParameter("XMLT", m3XMLT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPKY.HasValue)
				request.WithQueryParameter("SPKY", m3SPKY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RELM))
				request.WithQueryParameter("RELM", m3RELM.Trim());
			if (!string.IsNullOrWhiteSpace(m3NMSP))
				request.WithQueryParameter("NMSP", m3NMSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3NMS1))
				request.WithQueryParameter("NMS1", m3NMS1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRE1))
				request.WithQueryParameter("PRE1", m3PRE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SCNP))
				request.WithQueryParameter("SCNP", m3SCNP.Trim());
			if (!string.IsNullOrWhiteSpace(m3SCHM))
				request.WithQueryParameter("SCHM", m3SCHM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNM))
				request.WithQueryParameter("ELNM", m3ELNM.Trim());

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
