/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Approve
		/// Description Approve a delivery for invoicing
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_DLIX">Delivery number (Required)</param>
		/// <param name="m3_TEPY">Payment terms (Required)</param>
		/// <param name="m3_APBY">Approved by signature (Required)</param>
		/// <param name="m3_APDT">Date approved</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Approve(
			string m3_ORNO, 
			string m3_WHLO, 
			decimal m3_DLIX, 
			string m3_TEPY, 
			string m3_APBY, 
			DateTime? m3_APDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Approve",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_TEPY))
				throw new ArgumentNullException("m3_TEPY");
			if (string.IsNullOrWhiteSpace(m3_APBY))
				throw new ArgumentNullException("m3_APBY");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("DLIX", m3_DLIX.ToString())
				.WithQueryParameter("TEPY", m3_TEPY.Trim())
				.WithQueryParameter("APBY", m3_APBY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_APDT.HasValue)
				request.WithQueryParameter("APDT", m3_APDT.Value.ToM3String());

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

		/// <summary>
		/// Name ListDeliveries
		/// Description List deliveries that need approval
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListDeliveriesResponse></returns>
		/// <exception cref="M3Exception<ListDeliveriesResponse>"></exception>
		public async Task<M3Response<ListDeliveriesResponse>> ListDeliveries(
			string m3_FACI, 
			string m3_CUNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ListDeliveries",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Execute the request
			var result = await Execute<ListDeliveriesResponse>(
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
		/// Name UpdateQty
		/// Description Report deviations in delivered quantities
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_DLIX">Delivery number (Required)</param>
		/// <param name="m3_TEPY">Payment terms (Required)</param>
		/// <param name="m3_PONR">Order line number (Required)</param>
		/// <param name="m3_DLQA">Delivered quantity - alternate U/M (Required)</param>
		/// <param name="m3_DLQS">Delivered quantity - sales price U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdateQty(
			string m3_ORNO, 
			string m3_WHLO, 
			decimal m3_DLIX, 
			string m3_TEPY, 
			int m3_PONR, 
			decimal m3_DLQA, 
			decimal? m3_DLQS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdateQty",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_TEPY))
				throw new ArgumentNullException("m3_TEPY");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("DLIX", m3_DLIX.ToString())
				.WithQueryParameter("TEPY", m3_TEPY.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("DLQA", m3_DLQA.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DLQS.HasValue)
				request.WithQueryParameter("DLQS", m3_DLQS.Value.ToString());

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
