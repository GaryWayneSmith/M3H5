/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MYS450MI;
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
	/// Name: MYS450MI
	/// Component Name: TPLTransportOPPlanning
	/// Description: Api: Transp. op. planning
	/// Version Release: 5e90
	///</summary>
	public partial class MYS450MIResource : M3BaseResourceEndpoint
	{
		public MYS450MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MYS450MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddDelivery
		/// Description Add delivery upload
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_DLIX">Delivery number (Required)</param>
		/// <param name="m3_INOU">Direction (Required)</param>
		/// <param name="m3_PRFL">Process flag</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DSDT">Departure date</param>
		/// <param name="m3_DSHM">Departure time</param>
		/// <param name="m3_ROUT">Route</param>
		/// <param name="m3_RODN">Route departure</param>
		/// <param name="m3_MODF">Final delivery method</param>
		/// <param name="m3_TEDF">Final delivery terms</param>
		/// <param name="m3_FWNO">Forwarding agent</param>
		/// <param name="m3_LODO">Loading platform</param>
		/// <param name="m3_EONN">External shipment number</param>
		/// <param name="m3_TRCA">Transportation equipment</param>
		/// <param name="m3_USD1">User defined field</param>
		/// <param name="m3_USD2">User defined field</param>
		/// <param name="m3_USD3">User defined field</param>
		/// <param name="m3_USD4">User defined field</param>
		/// <param name="m3_USD5">User defined field</param>
		/// <param name="m3_MULS">Place sequence number for unloading</param>
		/// <param name="m3_SULS">Unloading sequence within place</param>
		/// <param name="m3_DEDA">Delivery date</param>
		/// <param name="m3_OPCD">Operation code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDelivery(
			string m3_E0PA, 
			string m3_MSGN, 
			decimal m3_DLIX, 
			int m3_INOU, 
			string m3_PRFL = null, 
			int? m3_CONO = null, 
			DateTime? m3_DSDT = null, 
			int? m3_DSHM = null, 
			string m3_ROUT = null, 
			int? m3_RODN = null, 
			string m3_MODF = null, 
			string m3_TEDF = null, 
			string m3_FWNO = null, 
			string m3_LODO = null, 
			string m3_EONN = null, 
			string m3_TRCA = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			int? m3_MULS = null, 
			int? m3_SULS = null, 
			DateTime? m3_DEDA = null, 
			string m3_OPCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddDelivery",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("MSGN", m3_MSGN.Trim())
				.WithQueryParameter("DLIX", m3_DLIX.ToString())
				.WithQueryParameter("INOU", m3_INOU.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRFL))
				request.WithQueryParameter("PRFL", m3_PRFL.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_DSDT.HasValue)
				request.WithQueryParameter("DSDT", m3_DSDT.Value.ToM3String());
			if (m3_DSHM.HasValue)
				request.WithQueryParameter("DSHM", m3_DSHM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ROUT))
				request.WithQueryParameter("ROUT", m3_ROUT.Trim());
			if (m3_RODN.HasValue)
				request.WithQueryParameter("RODN", m3_RODN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MODF))
				request.WithQueryParameter("MODF", m3_MODF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDF))
				request.WithQueryParameter("TEDF", m3_TEDF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FWNO))
				request.WithQueryParameter("FWNO", m3_FWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LODO))
				request.WithQueryParameter("LODO", m3_LODO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EONN))
				request.WithQueryParameter("EONN", m3_EONN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRCA))
				request.WithQueryParameter("TRCA", m3_TRCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_MULS.HasValue)
				request.WithQueryParameter("MULS", m3_MULS.Value.ToString());
			if (m3_SULS.HasValue)
				request.WithQueryParameter("SULS", m3_SULS.Value.ToString());
			if (m3_DEDA.HasValue)
				request.WithQueryParameter("DEDA", m3_DEDA.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_OPCD))
				request.WithQueryParameter("OPCD", m3_OPCD.Trim());

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
		/// Name LstDelivery
		/// Description List delivery
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_INOU">Direction</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDeliveryResponse></returns>
		/// <exception cref="M3Exception<LstDeliveryResponse>"></exception>
		public async Task<M3Response<LstDeliveryResponse>> LstDelivery(
			string m3_E0PA, 
			string m3_MSGN, 
			int? m3_CONO = null, 
			int? m3_INOU = null, 
			decimal? m3_DLIX = null, 
			string m3_STAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDelivery",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("MSGN", m3_MSGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_INOU.HasValue)
				request.WithQueryParameter("INOU", m3_INOU.Value.ToString());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());

			// Execute the request
			var result = await Execute<LstDeliveryResponse>(
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
		/// Name LstHead
		/// Description List message header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadResponse></returns>
		/// <exception cref="M3Exception<LstHeadResponse>"></exception>
		public async Task<M3Response<LstHeadResponse>> LstHead(
			string m3_E0PA, 
			int? m3_CONO = null, 
			string m3_MSGN = null, 
			string m3_STAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());

			// Execute the request
			var result = await Execute<LstHeadResponse>(
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
		/// Name PrcDelivery
		/// Description Process delivery
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_DLIX">Delivery number (Required)</param>
		/// <param name="m3_INOU">Direction (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrcDelivery(
			string m3_E0PA, 
			string m3_MSGN, 
			decimal m3_DLIX, 
			int m3_INOU, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrcDelivery",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("MSGN", m3_MSGN.Trim())
				.WithQueryParameter("DLIX", m3_DLIX.ToString())
				.WithQueryParameter("INOU", m3_INOU.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name PrcHead
		/// Description Process message header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrcHead(
			string m3_E0PA, 
			string m3_MSGN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrcHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("MSGN", m3_MSGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
