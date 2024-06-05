/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3PRTF">Printer file (Required)</param>
		/// <param name="m3RPLY">XML structure (Required)</param>
		/// <param name="m3RPBK">XML section (Required)</param>
		/// <param name="m3RPBA">Base XML section</param>
		/// <param name="m3FILE">Table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCustSection(
			string m3PRTF, 
			string m3RPLY, 
			int m3RPBK, 
			int? m3RPBA = null, 
			string m3FILE = null, 
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
			if (string.IsNullOrWhiteSpace(m3PRTF))
				throw new ArgumentNullException(nameof(m3PRTF));
			if (string.IsNullOrWhiteSpace(m3RPLY))
				throw new ArgumentNullException(nameof(m3RPLY));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3PRTF.Trim())
				.WithQueryParameter("RPLY", m3RPLY.Trim())
				.WithQueryParameter("RPBK", m3RPBK.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3RPBA.HasValue)
				request.WithQueryParameter("RPBA", m3RPBA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());

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
		/// Name ChangeStatus
		/// Description Change section status.
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3PRTF">Printer file (Required)</param>
		/// <param name="m3RPLY">XML structure (Required)</param>
		/// <param name="m3RPBK">XML section (Required)</param>
		/// <param name="m3XMBS">Section status (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChangeStatus(
			string m3PRTF, 
			string m3RPLY, 
			int m3RPBK, 
			string m3XMBS, 
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
			if (string.IsNullOrWhiteSpace(m3PRTF))
				throw new ArgumentNullException(nameof(m3PRTF));
			if (string.IsNullOrWhiteSpace(m3RPLY))
				throw new ArgumentNullException(nameof(m3RPLY));
			if (string.IsNullOrWhiteSpace(m3XMBS))
				throw new ArgumentNullException(nameof(m3XMBS));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3PRTF.Trim())
				.WithQueryParameter("RPLY", m3RPLY.Trim())
				.WithQueryParameter("RPBK", m3RPBK.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("XMBS", m3XMBS.Trim());

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
		/// Name DeleteAllFields
		/// Description Delete all fields for the section, even standard fields.
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3PRTF">Printer file (Required)</param>
		/// <param name="m3RPLY">XML structure (Required)</param>
		/// <param name="m3RPBK">XML section (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteAllFields(
			string m3PRTF, 
			string m3RPLY, 
			int m3RPBK, 
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
			if (string.IsNullOrWhiteSpace(m3PRTF))
				throw new ArgumentNullException(nameof(m3PRTF));
			if (string.IsNullOrWhiteSpace(m3RPLY))
				throw new ArgumentNullException(nameof(m3RPLY));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3PRTF.Trim())
				.WithQueryParameter("RPLY", m3RPLY.Trim())
				.WithQueryParameter("RPBK", m3RPBK.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltXmlSection
		/// Description Delete XML section
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRTF">Printer file (Required)</param>
		/// <param name="m3RPLY">XML structure (Required)</param>
		/// <param name="m3RPBK">XML section (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltXmlSection(
			string m3PRTF, 
			string m3RPLY, 
			int m3RPBK, 
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
			if (string.IsNullOrWhiteSpace(m3PRTF))
				throw new ArgumentNullException(nameof(m3PRTF));
			if (string.IsNullOrWhiteSpace(m3RPLY))
				throw new ArgumentNullException(nameof(m3RPLY));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3PRTF.Trim())
				.WithQueryParameter("RPLY", m3RPLY.Trim())
				.WithQueryParameter("RPBK", m3RPBK.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetXmlSection
		/// Description Get data for a XML section
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRTF">Printer file (Required)</param>
		/// <param name="m3RPLY">XML structure (Required)</param>
		/// <param name="m3RPBK">XML section (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetXmlSectionResponse></returns>
		/// <exception cref="M3Exception<GetXmlSectionResponse>"></exception>
		public async Task<M3Response<GetXmlSectionResponse>> GetXmlSection(
			string m3PRTF, 
			string m3RPLY, 
			int m3RPBK, 
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
			if (string.IsNullOrWhiteSpace(m3PRTF))
				throw new ArgumentNullException(nameof(m3PRTF));
			if (string.IsNullOrWhiteSpace(m3RPLY))
				throw new ArgumentNullException(nameof(m3RPLY));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3PRTF.Trim())
				.WithQueryParameter("RPLY", m3RPLY.Trim())
				.WithQueryParameter("RPBK", m3RPBK.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetXmlSectionResponse>(
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
		/// Name LstXmlSections
		/// Description List data for XML sections
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRTF">Printer file</param>
		/// <param name="m3RPLY">XML structure</param>
		/// <param name="m3RPBK">XML section</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstXmlSectionsResponse></returns>
		/// <exception cref="M3Exception<LstXmlSectionsResponse>"></exception>
		public async Task<M3Response<LstXmlSectionsResponse>> LstXmlSections(
			string m3PRTF = null, 
			string m3RPLY = null, 
			int? m3RPBK = null, 
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
			if (!string.IsNullOrWhiteSpace(m3PRTF))
				request.WithQueryParameter("PRTF", m3PRTF.Trim());
			if (!string.IsNullOrWhiteSpace(m3RPLY))
				request.WithQueryParameter("RPLY", m3RPLY.Trim());
			if (m3RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3RPBK.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstXmlSectionsResponse>(
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
		/// Name UpdXmlSection
		/// Description Update Xml section
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3PRTF">Printer file (Required)</param>
		/// <param name="m3RPLY">XML structure (Required)</param>
		/// <param name="m3RPBK">XML section (Required)</param>
		/// <param name="m3XMBS">Section status</param>
		/// <param name="m3ELNM">Element name</param>
		/// <param name="m3EMEL">Empty element</param>
		/// <param name="m3SATR">Section attribute</param>
		/// <param name="m3GRBY">Group by element name</param>
		/// <param name="m3FGBY">Subgroup by element name</param>
		/// <param name="m3BLLE">Section level</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdXmlSection(
			string m3PRTF, 
			string m3RPLY, 
			int m3RPBK, 
			string m3XMBS = null, 
			string m3ELNM = null, 
			int? m3EMEL = null, 
			int? m3SATR = null, 
			string m3GRBY = null, 
			string m3FGBY = null, 
			int? m3BLLE = null, 
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
			if (string.IsNullOrWhiteSpace(m3PRTF))
				throw new ArgumentNullException(nameof(m3PRTF));
			if (string.IsNullOrWhiteSpace(m3RPLY))
				throw new ArgumentNullException(nameof(m3RPLY));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3PRTF.Trim())
				.WithQueryParameter("RPLY", m3RPLY.Trim())
				.WithQueryParameter("RPBK", m3RPBK.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3XMBS))
				request.WithQueryParameter("XMBS", m3XMBS.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNM))
				request.WithQueryParameter("ELNM", m3ELNM.Trim());
			if (m3EMEL.HasValue)
				request.WithQueryParameter("EMEL", m3EMEL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SATR.HasValue)
				request.WithQueryParameter("SATR", m3SATR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3GRBY))
				request.WithQueryParameter("GRBY", m3GRBY.Trim());
			if (!string.IsNullOrWhiteSpace(m3FGBY))
				request.WithQueryParameter("FGBY", m3FGBY.Trim());
			if (m3BLLE.HasValue)
				request.WithQueryParameter("BLLE", m3BLLE.Value.ToString(CultureInfo.CurrentCulture));

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
