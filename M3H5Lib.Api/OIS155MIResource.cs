/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.OIS155MI;
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
	/// Name: OIS155MI
	/// Component Name: Delivery
	/// Description: Api: Delivery interface
	/// Version Release: 5ea1
	///</summary>
	public partial class OIS155MIResource : M3BaseResourceEndpoint
	{
		public OIS155MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS155MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Approve
		/// Description Approve a delivery for invoicing
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3TEPY">Payment terms (Required)</param>
		/// <param name="m3APBY">Approved by signature (Required)</param>
		/// <param name="m3APDT">Date approved</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Approve(
			string m3ORNO, 
			string m3WHLO, 
			decimal m3DLIX, 
			string m3TEPY, 
			string m3APBY, 
			DateTime? m3APDT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Approve",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3TEPY))
				throw new ArgumentNullException(nameof(m3TEPY));
			if (string.IsNullOrWhiteSpace(m3APBY))
				throw new ArgumentNullException(nameof(m3APBY));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TEPY", m3TEPY.Trim())
				.WithQueryParameter("APBY", m3APBY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3APDT.HasValue)
				request.WithQueryParameter("APDT", m3APDT.Value.ToM3String());

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

		/// <summary>
		/// Name ListDeliveries
		/// Description List deliveries that need approval
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListDeliveriesResponse></returns>
		/// <exception cref="M3Exception<ListDeliveriesResponse>"></exception>
		public async Task<M3Response<ListDeliveriesResponse>> ListDeliveries(
			string m3FACI, 
			string m3CUNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ListDeliveries",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Execute the request
			var result = await Execute<ListDeliveriesResponse>(
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
		/// Name UpdateQty
		/// Description Report deviations in delivered quantities
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3TEPY">Payment terms (Required)</param>
		/// <param name="m3PONR">Order line number (Required)</param>
		/// <param name="m3DLQA">Delivered quantity - alternate U/M (Required)</param>
		/// <param name="m3DLQS">Delivered quantity - sales price U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdateQty(
			string m3ORNO, 
			string m3WHLO, 
			decimal m3DLIX, 
			string m3TEPY, 
			int m3PONR, 
			decimal m3DLQA, 
			decimal? m3DLQS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdateQty",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3TEPY))
				throw new ArgumentNullException(nameof(m3TEPY));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TEPY", m3TEPY.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DLQA", m3DLQA.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3DLQS.HasValue)
				request.WithQueryParameter("DLQS", m3DLQS.Value.ToString(CultureInfo.CurrentCulture));

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
