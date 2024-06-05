/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.MWS023MI;
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
	/// Name: MWS023MI
	/// Component Name: Tool
	/// Description: Tool interface
	/// Version Release: 5ea0
	///</summary>
	public partial class MWS023MIResource : M3BaseResourceEndpoint
	{
		public MWS023MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MWS023MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstWhsEq
		/// Description List Warehouse Equipment
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PISE">Warehouse equipment</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstWhsEqResponse></returns>
		/// <exception cref="M3Exception<LstWhsEqResponse>"></exception>
		public async Task<M3Response<LstWhsEqResponse>> LstWhsEq(
			string m3PISE = null, 
			string m3ITNO = null, 
			string m3SERN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstWhsEq",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PISE))
				request.WithQueryParameter("PISE", m3PISE.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());

			// Execute the request
			var result = await Execute<LstWhsEqResponse>(
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
