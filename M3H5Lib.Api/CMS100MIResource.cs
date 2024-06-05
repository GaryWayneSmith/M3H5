/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.CMS100MI;
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
	/// Name: CMS100MI
	/// Component Name: Custom list designer MI
	/// Description: Custom list designer MI
	/// Version Release: 
	///</summary>
	public partial class CMS100MIResource : M3BaseResourceEndpoint
	{
		public CMS100MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS100MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Lst_test
		/// Description Keys: DIVI YEA4 JRNO JSNO
		/// Version Release: 
		/// </summary>
		/// <param name="m3EGDIVI">Division (Required)</param>
		/// <param name="m3EGYEA4">Year</param>
		/// <param name="m3EGJRNO">Journal no</param>
		/// <param name="m3EGJSNO">Journal seq no</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<Lst_testResponse></returns>
		/// <exception cref="M3Exception<Lst_testResponse>"></exception>
		public async Task<M3Response<Lst_testResponse>> Lst_test(
			string m3EGDIVI, 
			int? m3EGYEA4 = null, 
			int? m3EGJRNO = null, 
			int? m3EGJSNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Lst_test",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EGDIVI))
				throw new ArgumentNullException(nameof(m3EGDIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("EGDIVI", m3EGDIVI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3EGYEA4.HasValue)
				request.WithQueryParameter("EGYEA4", m3EGYEA4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EGJRNO.HasValue)
				request.WithQueryParameter("EGJRNO", m3EGJRNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EGJSNO.HasValue)
				request.WithQueryParameter("EGJSNO", m3EGJSNO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<Lst_testResponse>(
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
