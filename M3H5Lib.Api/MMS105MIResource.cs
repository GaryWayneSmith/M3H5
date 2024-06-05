/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
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
	/// Name: MMS105MI
	/// Component Name: Container Movement
	/// Description: Api: Container Movement
	/// Version Release: 13.1
	///</summary>
	public partial class MMS105MIResource : M3BaseResourceEndpoint
	{
		public MMS105MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS105MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add Transaction
		/// Version Release: 
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3CAMU">Container (Required)</param>
		/// <param name="m3TWSL">To location (Required)</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3RFTX">Reference text</param>
		/// <param name="m3DSP1">Flag-Status-0/1</param>
		/// <param name="m3DSP2">Flag-StockLoc-0/1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3WHLO, 
			string m3CAMU, 
			string m3TWSL, 
			DateTime? m3TRDT = null, 
			string m3RFTX = null, 
			int? m3DSP1 = null, 
			int? m3DSP2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3CAMU))
				throw new ArgumentNullException(nameof(m3CAMU));
			if (string.IsNullOrWhiteSpace(m3TWSL))
				throw new ArgumentNullException(nameof(m3TWSL));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("CAMU", m3CAMU.Trim())
				.WithQueryParameter("TWSL", m3TWSL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3RFTX))
				request.WithQueryParameter("RFTX", m3RFTX.Trim());
			if (m3DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3DSP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP2.HasValue)
				request.WithQueryParameter("DSP2", m3DSP2.Value.ToString(CultureInfo.CurrentCulture));

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
