/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.CPS170MI;
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
	/// Name: CPS170MI
	/// Component Name: PersonCapacity
	/// Description: Person capacity interface
	/// Version Release: 12.0
	///</summary>
	public partial class CPS170MIResource : M3BaseResourceEndpoint
	{
		public CPS170MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CPS170MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Lst
		/// Description List Person Capacity
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3FACI, 
			int? m3CONO = null, 
			string m3EMNO = null, 
			DateTime? m3FDAT = null, 
			DateTime? m3TDAT = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());

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
