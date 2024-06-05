/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.STS205MI;
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
	/// Name: STS205MI
	/// Component Name: StockReturn
	/// Description: Rental sales line stock return interface
	/// Version Release: 15.1
	///</summary>
	public partial class STS205MIResource : M3BaseResourceEndpoint
	{
		public STS205MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "STS205MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Create
		/// Description Create a stock return
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3PONR">Order line number (Required)</param>
		/// <param name="m3WHSL">Location (Required)</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CreateResponse></returns>
		/// <exception cref="M3Exception<CreateResponse>"></exception>
		public async Task<M3Response<CreateResponse>> Create(
			string m3AGNB, 
			int m3PONR, 
			string m3WHSL, 
			string m3BANO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Create",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));
			if (string.IsNullOrWhiteSpace(m3WHSL))
				throw new ArgumentNullException(nameof(m3WHSL));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("WHSL", m3WHSL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());

			// Execute the request
			var result = await Execute<CreateResponse>(
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
