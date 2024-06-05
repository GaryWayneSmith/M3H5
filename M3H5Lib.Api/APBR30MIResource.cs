/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.APBR30MI;
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
	/// Name: APBR30MI
	/// Component Name: SupplierPayment
	/// Description: COUNTRY:Supplier payment interface
	/// Version Release: 14.0
	///</summary>
	public partial class APBR30MIResource : M3BaseResourceEndpoint
	{
		public APBR30MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "APBR30MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetHead
		/// Description Get Head information
		/// Version Release: 14.0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PRPN">Payment proposal (Required)</param>
		/// <param name="m3_PYON">Payment order (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadResponse></returns>
		/// <exception cref="M3Exception<GetHeadResponse>"></exception>
		public async Task<M3Response<GetHeadResponse>> GetHead(
			string m3_DIVI, 
			long m3_PRPN, 
			int m3_PYON, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PRPN", m3_PRPN.ToString())
				.WithQueryParameter("PYON", m3_PYON.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetHeadResponse>(
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
		/// Name GetHeadAddress
		/// Description Get Head Addresses
		/// Version Release: 14.0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PRPN">Payment proposal (Required)</param>
		/// <param name="m3_PYON">Payment order (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadAddressResponse></returns>
		/// <exception cref="M3Exception<GetHeadAddressResponse>"></exception>
		public async Task<M3Response<GetHeadAddressResponse>> GetHeadAddress(
			string m3_DIVI, 
			long m3_PRPN, 
			int m3_PYON, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHeadAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PRPN", m3_PRPN.ToString())
				.WithQueryParameter("PYON", m3_PYON.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetHeadAddressResponse>(
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
		/// Name LstInvByPayDate
		/// Description List invoices by payment date
		/// Version Release: 14.0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PRPN">Payment proposal (Required)</param>
		/// <param name="m3_PYON">Payment order (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PYDT">Payment date</param>
		/// <param name="m3_PDNB">Payment document number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvByPayDateResponse></returns>
		/// <exception cref="M3Exception<LstInvByPayDateResponse>"></exception>
		public async Task<M3Response<LstInvByPayDateResponse>> LstInvByPayDate(
			string m3_DIVI, 
			long m3_PRPN, 
			int m3_PYON, 
			int? m3_CONO = null, 
			DateTime? m3_PYDT = null, 
			int? m3_PDNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInvByPayDate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PRPN", m3_PRPN.ToString())
				.WithQueryParameter("PYON", m3_PYON.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PYDT.HasValue)
				request.WithQueryParameter("PYDT", m3_PYDT.Value.ToM3String());
			if (m3_PDNB.HasValue)
				request.WithQueryParameter("PDNB", m3_PDNB.Value.ToString());

			// Execute the request
			var result = await Execute<LstInvByPayDateResponse>(
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
		/// Name LstInvByPayDoc
		/// Description List invoices by payment document
		/// Version Release: 14.0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PRPN">Payment proposal (Required)</param>
		/// <param name="m3_PYON">Payment order (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PDNB">Payment document number</param>
		/// <param name="m3_SPYN">Payee</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvByPayDocResponse></returns>
		/// <exception cref="M3Exception<LstInvByPayDocResponse>"></exception>
		public async Task<M3Response<LstInvByPayDocResponse>> LstInvByPayDoc(
			string m3_DIVI, 
			long m3_PRPN, 
			int m3_PYON, 
			int? m3_CONO = null, 
			int? m3_PDNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInvByPayDoc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PRPN", m3_PRPN.ToString())
				.WithQueryParameter("PYON", m3_PYON.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PDNB.HasValue)
				request.WithQueryParameter("PDNB", m3_PDNB.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPYN))
				request.WithQueryParameter("SPYN", m3_SPYN.Trim());

			// Execute the request
			var result = await Execute<LstInvByPayDocResponse>(
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
		/// Description List invoices by payee
		/// Version Release: 14.0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PRPN">Payment proposal (Required)</param>
		/// <param name="m3_PYON">Payment order (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SPYN">Payee</param>
		/// <param name="m3_PDNB">Payment document number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvByPayeeResponse></returns>
		/// <exception cref="M3Exception<LstInvByPayeeResponse>"></exception>
		public async Task<M3Response<LstInvByPayeeResponse>> LstInvByPayee(
			string m3_DIVI, 
			long m3_PRPN, 
			int m3_PYON, 
			int? m3_CONO = null, 
			string m3_SPYN = null, 
			int? m3_PDNB = null, 
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
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PRPN", m3_PRPN.ToString())
				.WithQueryParameter("PYON", m3_PYON.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPYN))
				request.WithQueryParameter("SPYN", m3_SPYN.Trim());
			if (m3_PDNB.HasValue)
				request.WithQueryParameter("PDNB", m3_PDNB.Value.ToString());

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

		/// <summary>
		/// Name LstPayeeTotals
		/// Description List all payee totals
		/// Version Release: 14.0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PRPN">Payment proposal (Required)</param>
		/// <param name="m3_PYON">Payment order (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SPYN">Payee</param>
		/// <param name="m3_PDNB">Payment document number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPayeeTotalsResponse></returns>
		/// <exception cref="M3Exception<LstPayeeTotalsResponse>"></exception>
		public async Task<M3Response<LstPayeeTotalsResponse>> LstPayeeTotals(
			string m3_DIVI, 
			long m3_PRPN, 
			int m3_PYON, 
			int? m3_CONO = null, 
			string m3_SPYN = null, 
			int? m3_PDNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPayeeTotals",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PRPN", m3_PRPN.ToString())
				.WithQueryParameter("PYON", m3_PYON.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPYN))
				request.WithQueryParameter("SPYN", m3_SPYN.Trim());
			if (m3_PDNB.HasValue)
				request.WithQueryParameter("PDNB", m3_PDNB.Value.ToString());

			// Execute the request
			var result = await Execute<LstPayeeTotalsResponse>(
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
