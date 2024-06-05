/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.MLS170MI;
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
	/// Name: MLS170MI
	/// Component Name: MCO_Invoice_Specification
	/// Description: Maint CO Invoice Specification Interface
	/// Version Release: 5e90
	///</summary>
	public partial class MLS170MIResource : M3BaseResourceEndpoint
	{
		public MLS170MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MLS170MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Get
		/// Description List MCO Invoice Specification
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3AQUO">Quotation</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3ALI1">Transaction number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3ORNO, 
			int m3PONR, 
			int? m3AQUO = null, 
			string m3PYNO = null, 
			int? m3ALI1 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3AQUO.HasValue)
				request.WithQueryParameter("AQUO", m3AQUO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (m3ALI1.HasValue)
				request.WithQueryParameter("ALI1", m3ALI1.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name Lst
		/// Description List MCO Invoice Specification
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3AQUO">Quotation</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3ORNO, 
			int? m3PONR = null, 
			int? m3AQUO = null, 
			string m3PYNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Lst",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AQUO.HasValue)
				request.WithQueryParameter("AQUO", m3AQUO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());

			// Execute the request
			var result = await Execute<LstResponse>(
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
