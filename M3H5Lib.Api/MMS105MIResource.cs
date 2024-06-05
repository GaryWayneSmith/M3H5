/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CAMU">Container (Required)</param>
		/// <param name="m3_TWSL">To location (Required)</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_RFTX">Reference text</param>
		/// <param name="m3_DSP1">Flag-Status-0/1</param>
		/// <param name="m3_DSP2">Flag-StockLoc-0/1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_WHLO, 
			string m3_CAMU, 
			string m3_TWSL, 
			DateTime? m3_TRDT = null, 
			string m3_RFTX = null, 
			int? m3_DSP1 = null, 
			int? m3_DSP2 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_CAMU))
				throw new ArgumentNullException("m3_CAMU");
			if (string.IsNullOrWhiteSpace(m3_TWSL))
				throw new ArgumentNullException("m3_TWSL");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("CAMU", m3_CAMU.Trim())
				.WithQueryParameter("TWSL", m3_TWSL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_RFTX))
				request.WithQueryParameter("RFTX", m3_RFTX.Trim());
			if (m3_DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3_DSP1.Value.ToString());
			if (m3_DSP2.HasValue)
				request.WithQueryParameter("DSP2", m3_DSP2.Value.ToString());

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
