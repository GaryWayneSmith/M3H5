/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CMS007MI;
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
	/// Name: CMS007MI
	/// Component Name: XML structure
	/// Description: XML structure interface
	/// Version Release: 5ea3
	///</summary>
	public partial class CMS007MIResource : M3BaseResourceEndpoint
	{
		public CMS007MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS007MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddCustSection
		/// Description Add custom XML section
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRTF">Printer file (Required)</param>
		/// <param name="m3_RPLY">XML structure (Required)</param>
		/// <param name="m3_RPBK">XML section (Required)</param>
		/// <param name="m3_RPBA">Base XML section</param>
		/// <param name="m3_FILE">Table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCustSection(
			string m3_PRTF, 
			string m3_RPLY, 
			int m3_RPBK, 
			int? m3_RPBA = null, 
			string m3_FILE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCustSection",
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
				.WithQueryParameter("RPBK", m3_RPBK.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RPBA.HasValue)
				request.WithQueryParameter("RPBA", m3_RPBA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());

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
		/// Name ChangeStatus
		/// Description Change section status.
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_PRTF">Printer file (Required)</param>
		/// <param name="m3_RPLY">XML structure (Required)</param>
		/// <param name="m3_RPBK">XML section (Required)</param>
		/// <param name="m3_XMBS">Section status (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChangeStatus(
			string m3_PRTF, 
			string m3_RPLY, 
			int m3_RPBK, 
			string m3_XMBS, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChangeStatus",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRTF))
				throw new ArgumentNullException("m3_PRTF");
			if (string.IsNullOrWhiteSpace(m3_RPLY))
				throw new ArgumentNullException("m3_RPLY");
			if (string.IsNullOrWhiteSpace(m3_XMBS))
				throw new ArgumentNullException("m3_XMBS");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3_PRTF.Trim())
				.WithQueryParameter("RPLY", m3_RPLY.Trim())
				.WithQueryParameter("RPBK", m3_RPBK.ToString())
				.WithQueryParameter("XMBS", m3_XMBS.Trim());

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
		/// Name DeleteAllFields
		/// Description Delete all fields for the section, even standard fields.
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_PRTF">Printer file (Required)</param>
		/// <param name="m3_RPLY">XML structure (Required)</param>
		/// <param name="m3_RPBK">XML section (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteAllFields(
			string m3_PRTF, 
			string m3_RPLY, 
			int m3_RPBK, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeleteAllFields",
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
				.WithQueryParameter("RPBK", m3_RPBK.ToString());

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
		/// Name DltXmlSection
		/// Description Delete XML section
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRTF">Printer file (Required)</param>
		/// <param name="m3_RPLY">XML structure (Required)</param>
		/// <param name="m3_RPBK">XML section (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltXmlSection(
			string m3_PRTF, 
			string m3_RPLY, 
			int m3_RPBK, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltXmlSection",
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
				.WithQueryParameter("RPBK", m3_RPBK.ToString());

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
		/// Name GetXmlSection
		/// Description Get data for a XML section
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRTF">Printer file (Required)</param>
		/// <param name="m3_RPLY">XML structure (Required)</param>
		/// <param name="m3_RPBK">XML section (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetXmlSectionResponse></returns>
		/// <exception cref="M3Exception<GetXmlSectionResponse>"></exception>
		public async Task<M3Response<GetXmlSectionResponse>> GetXmlSection(
			string m3_PRTF, 
			string m3_RPLY, 
			int m3_RPBK, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetXmlSection",
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
				.WithQueryParameter("RPBK", m3_RPBK.ToString());

			// Execute the request
			var result = await Execute<GetXmlSectionResponse>(
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
		/// Name LstXmlSections
		/// Description List data for XML sections
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRTF">Printer file</param>
		/// <param name="m3_RPLY">XML structure</param>
		/// <param name="m3_RPBK">XML section</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstXmlSectionsResponse></returns>
		/// <exception cref="M3Exception<LstXmlSectionsResponse>"></exception>
		public async Task<M3Response<LstXmlSectionsResponse>> LstXmlSections(
			string m3_PRTF = null, 
			string m3_RPLY = null, 
			int? m3_RPBK = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstXmlSections",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRTF))
				request.WithQueryParameter("PRTF", m3_PRTF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RPLY))
				request.WithQueryParameter("RPLY", m3_RPLY.Trim());
			if (m3_RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3_RPBK.Value.ToString());

			// Execute the request
			var result = await Execute<LstXmlSectionsResponse>(
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
		/// Name UpdXmlSection
		/// Description Update Xml section
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_PRTF">Printer file (Required)</param>
		/// <param name="m3_RPLY">XML structure (Required)</param>
		/// <param name="m3_RPBK">XML section (Required)</param>
		/// <param name="m3_XMBS">Section status</param>
		/// <param name="m3_ELNM">Element name</param>
		/// <param name="m3_EMEL">Empty element</param>
		/// <param name="m3_SATR">Section attribute</param>
		/// <param name="m3_GRBY">Group by element name</param>
		/// <param name="m3_FGBY">Subgroup by element name</param>
		/// <param name="m3_BLLE">Section level</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdXmlSection(
			string m3_PRTF, 
			string m3_RPLY, 
			int m3_RPBK, 
			string m3_XMBS = null, 
			string m3_ELNM = null, 
			int? m3_EMEL = null, 
			int? m3_SATR = null, 
			string m3_GRBY = null, 
			string m3_FGBY = null, 
			int? m3_BLLE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdXmlSection",
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
				.WithQueryParameter("RPBK", m3_RPBK.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_XMBS))
				request.WithQueryParameter("XMBS", m3_XMBS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNM))
				request.WithQueryParameter("ELNM", m3_ELNM.Trim());
			if (m3_EMEL.HasValue)
				request.WithQueryParameter("EMEL", m3_EMEL.Value.ToString());
			if (m3_SATR.HasValue)
				request.WithQueryParameter("SATR", m3_SATR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_GRBY))
				request.WithQueryParameter("GRBY", m3_GRBY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FGBY))
				request.WithQueryParameter("FGBY", m3_FGBY.Trim());
			if (m3_BLLE.HasValue)
				request.WithQueryParameter("BLLE", m3_BLLE.Value.ToString());

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
