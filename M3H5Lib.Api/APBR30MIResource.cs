/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetHead
		/// Description Get Head information
		/// Version Release: 14.0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PRPN">Payment proposal (Required)</param>
		/// <param name="m3PYON">Payment order (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadResponse></returns>
		/// <exception cref="M3Exception<GetHeadResponse>"></exception>
		public async Task<M3Response<GetHeadResponse>> GetHead(
			string m3DIVI, 
			long m3PRPN, 
			int m3PYON, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PRPN", m3PRPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYON", m3PYON.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetHeadResponse>(
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
		/// Name GetHeadAddress
		/// Description Get Head Addresses
		/// Version Release: 14.0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PRPN">Payment proposal (Required)</param>
		/// <param name="m3PYON">Payment order (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadAddressResponse></returns>
		/// <exception cref="M3Exception<GetHeadAddressResponse>"></exception>
		public async Task<M3Response<GetHeadAddressResponse>> GetHeadAddress(
			string m3DIVI, 
			long m3PRPN, 
			int m3PYON, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetHeadAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PRPN", m3PRPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYON", m3PYON.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetHeadAddressResponse>(
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
		/// Name LstInvByPayDate
		/// Description List invoices by payment date
		/// Version Release: 14.0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PRPN">Payment proposal (Required)</param>
		/// <param name="m3PYON">Payment order (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PYDT">Payment date</param>
		/// <param name="m3PDNB">Payment document number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvByPayDateResponse></returns>
		/// <exception cref="M3Exception<LstInvByPayDateResponse>"></exception>
		public async Task<M3Response<LstInvByPayDateResponse>> LstInvByPayDate(
			string m3DIVI, 
			long m3PRPN, 
			int m3PYON, 
			int? m3CONO = null, 
			DateTime? m3PYDT = null, 
			int? m3PDNB = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstInvByPayDate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PRPN", m3PRPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYON", m3PYON.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PYDT.HasValue)
				request.WithQueryParameter("PYDT", m3PYDT.Value.ToM3String());
			if (m3PDNB.HasValue)
				request.WithQueryParameter("PDNB", m3PDNB.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstInvByPayDateResponse>(
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
		/// Name LstInvByPayDoc
		/// Description List invoices by payment document
		/// Version Release: 14.0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PRPN">Payment proposal (Required)</param>
		/// <param name="m3PYON">Payment order (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PDNB">Payment document number</param>
		/// <param name="m3SPYN">Payee</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvByPayDocResponse></returns>
		/// <exception cref="M3Exception<LstInvByPayDocResponse>"></exception>
		public async Task<M3Response<LstInvByPayDocResponse>> LstInvByPayDoc(
			string m3DIVI, 
			long m3PRPN, 
			int m3PYON, 
			int? m3CONO = null, 
			int? m3PDNB = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstInvByPayDoc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PRPN", m3PRPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYON", m3PYON.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PDNB.HasValue)
				request.WithQueryParameter("PDNB", m3PDNB.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPYN))
				request.WithQueryParameter("SPYN", m3SPYN.Trim());

			// Execute the request
			var result = await Execute<LstInvByPayDocResponse>(
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
		/// Description List invoices by payee
		/// Version Release: 14.0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PRPN">Payment proposal (Required)</param>
		/// <param name="m3PYON">Payment order (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SPYN">Payee</param>
		/// <param name="m3PDNB">Payment document number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvByPayeeResponse></returns>
		/// <exception cref="M3Exception<LstInvByPayeeResponse>"></exception>
		public async Task<M3Response<LstInvByPayeeResponse>> LstInvByPayee(
			string m3DIVI, 
			long m3PRPN, 
			int m3PYON, 
			int? m3CONO = null, 
			string m3SPYN = null, 
			int? m3PDNB = null, 
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
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PRPN", m3PRPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYON", m3PYON.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPYN))
				request.WithQueryParameter("SPYN", m3SPYN.Trim());
			if (m3PDNB.HasValue)
				request.WithQueryParameter("PDNB", m3PDNB.Value.ToString(CultureInfo.CurrentCulture));

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

		/// <summary>
		/// Name LstPayeeTotals
		/// Description List all payee totals
		/// Version Release: 14.0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PRPN">Payment proposal (Required)</param>
		/// <param name="m3PYON">Payment order (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SPYN">Payee</param>
		/// <param name="m3PDNB">Payment document number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPayeeTotalsResponse></returns>
		/// <exception cref="M3Exception<LstPayeeTotalsResponse>"></exception>
		public async Task<M3Response<LstPayeeTotalsResponse>> LstPayeeTotals(
			string m3DIVI, 
			long m3PRPN, 
			int m3PYON, 
			int? m3CONO = null, 
			string m3SPYN = null, 
			int? m3PDNB = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPayeeTotals",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PRPN", m3PRPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYON", m3PYON.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPYN))
				request.WithQueryParameter("SPYN", m3SPYN.Trim());
			if (m3PDNB.HasValue)
				request.WithQueryParameter("PDNB", m3PDNB.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPayeeTotalsResponse>(
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
