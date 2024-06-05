/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.XBE130MI;
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
	/// Name: XBE130MI
	/// Component Name: Supplier Payments
	/// Description: COUNTRY:Supplier Payment Proposal - Extension
	/// Version Release: 12.4
	///</summary>
	public partial class XBE130MIResource : M3BaseResourceEndpoint
	{
		public XBE130MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "XBE130MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetPayeeTotal
		/// Description Get Payee Total - Extension
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PRPN">Payment Proposal (Required)</param>
		/// <param name="m3_PYON">Payment Order (Required)</param>
		/// <param name="m3_SPYN">Payee (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPayeeTotalResponse></returns>
		/// <exception cref="M3Exception<GetPayeeTotalResponse>"></exception>
		public async Task<M3Response<GetPayeeTotalResponse>> GetPayeeTotal(
			int m3_CONO, 
			string m3_DIVI, 
			long m3_PRPN, 
			int m3_PYON, 
			string m3_SPYN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPayeeTotal",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_SPYN))
				throw new ArgumentNullException("m3_SPYN");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PRPN", m3_PRPN.ToString())
				.WithQueryParameter("PYON", m3_PYON.ToString())
				.WithQueryParameter("SPYN", m3_SPYN.Trim());

			// Execute the request
			var result = await Execute<GetPayeeTotalResponse>(
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
		/// Name LstInvByPayee
		/// Description List Invoices by Payee - Extension
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PRPN">Payment Proposal (Required)</param>
		/// <param name="m3_PYON">Payment Order (Required)</param>
		/// <param name="m3_SPYN">Payee</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvByPayeeResponse></returns>
		/// <exception cref="M3Exception<LstInvByPayeeResponse>"></exception>
		public async Task<M3Response<LstInvByPayeeResponse>> LstInvByPayee(
			int m3_CONO, 
			string m3_DIVI, 
			long m3_PRPN, 
			int m3_PYON, 
			string m3_SPYN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInvByPayee",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PRPN", m3_PRPN.ToString())
				.WithQueryParameter("PYON", m3_PYON.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SPYN))
				request.WithQueryParameter("SPYN", m3_SPYN.Trim());

			// Execute the request
			var result = await Execute<LstInvByPayeeResponse>(
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
