/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetPayeeTotal
		/// Description Get Payee Total - Extension
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PRPN">Payment Proposal (Required)</param>
		/// <param name="m3PYON">Payment Order (Required)</param>
		/// <param name="m3SPYN">Payee (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPayeeTotalResponse></returns>
		/// <exception cref="M3Exception<GetPayeeTotalResponse>"></exception>
		public async Task<M3Response<GetPayeeTotalResponse>> GetPayeeTotal(
			int m3CONO, 
			string m3DIVI, 
			long m3PRPN, 
			int m3PYON, 
			string m3SPYN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetPayeeTotal",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3SPYN))
				throw new ArgumentNullException(nameof(m3SPYN));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PRPN", m3PRPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYON", m3PYON.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SPYN", m3SPYN.Trim());

			// Execute the request
			var result = await Execute<GetPayeeTotalResponse>(
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
		/// Name LstInvByPayee
		/// Description List Invoices by Payee - Extension
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PRPN">Payment Proposal (Required)</param>
		/// <param name="m3PYON">Payment Order (Required)</param>
		/// <param name="m3SPYN">Payee</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvByPayeeResponse></returns>
		/// <exception cref="M3Exception<LstInvByPayeeResponse>"></exception>
		public async Task<M3Response<LstInvByPayeeResponse>> LstInvByPayee(
			int m3CONO, 
			string m3DIVI, 
			long m3PRPN, 
			int m3PYON, 
			string m3SPYN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstInvByPayee",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PRPN", m3PRPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYON", m3PYON.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SPYN))
				request.WithQueryParameter("SPYN", m3SPYN.Trim());

			// Execute the request
			var result = await Execute<LstInvByPayeeResponse>(
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
