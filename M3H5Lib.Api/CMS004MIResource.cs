/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.CMS004MI;
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
	/// Name: CMS004MI
	/// Component Name: XML variant
	/// Description: XML variant interface
	/// Version Release: 5ea0
	///</summary>
	public partial class CMS004MIResource : M3BaseResourceEndpoint
	{
		public CMS004MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS004MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetXmlVariant
		/// Description Get data for XML variant
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRTF">Printer file (Required)</param>
		/// <param name="m3XMLT">XML variant (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetXmlVariantResponse></returns>
		/// <exception cref="M3Exception<GetXmlVariantResponse>"></exception>
		public async Task<M3Response<GetXmlVariantResponse>> GetXmlVariant(
			string m3PRTF, 
			int m3XMLT, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetXmlVariant",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRTF))
				throw new ArgumentNullException(nameof(m3PRTF));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3PRTF.Trim())
				.WithQueryParameter("XMLT", m3XMLT.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetXmlVariantResponse>(
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
		/// Name LstXmlVariants
		/// Description List data for XML variants
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRTF">Printer file</param>
		/// <param name="m3XMLT">XML variant</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstXmlVariantsResponse></returns>
		/// <exception cref="M3Exception<LstXmlVariantsResponse>"></exception>
		public async Task<M3Response<LstXmlVariantsResponse>> LstXmlVariants(
			string m3PRTF = null, 
			int? m3XMLT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstXmlVariants",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRTF))
				request.WithQueryParameter("PRTF", m3PRTF.Trim());
			if (m3XMLT.HasValue)
				request.WithQueryParameter("XMLT", m3XMLT.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstXmlVariantsResponse>(
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
		/// Name UpdXmlVariant
		/// Description Update data for XML variant
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRTF">Printer file (Required)</param>
		/// <param name="m3XMLT">XML variant (Required)</param>
		/// <param name="m3RLAY">Report layout</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdXmlVariant(
			string m3PRTF, 
			int m3XMLT, 
			string m3RLAY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdXmlVariant",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRTF))
				throw new ArgumentNullException(nameof(m3PRTF));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3PRTF.Trim())
				.WithQueryParameter("XMLT", m3XMLT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3RLAY))
				request.WithQueryParameter("RLAY", m3RLAY.Trim());

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
