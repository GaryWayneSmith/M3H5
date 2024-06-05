/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddDelivery
		/// Description Add delivery upload
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3INOU">Direction (Required)</param>
		/// <param name="m3PRFL">Process flag</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DSDT">Departure date</param>
		/// <param name="m3DSHM">Departure time</param>
		/// <param name="m3ROUT">Route</param>
		/// <param name="m3RODN">Route departure</param>
		/// <param name="m3MODF">Final delivery method</param>
		/// <param name="m3TEDF">Final delivery terms</param>
		/// <param name="m3FWNO">Forwarding agent</param>
		/// <param name="m3LODO">Loading platform</param>
		/// <param name="m3EONN">External shipment number</param>
		/// <param name="m3TRCA">Transportation equipment</param>
		/// <param name="m3USD1">User defined field</param>
		/// <param name="m3USD2">User defined field</param>
		/// <param name="m3USD3">User defined field</param>
		/// <param name="m3USD4">User defined field</param>
		/// <param name="m3USD5">User defined field</param>
		/// <param name="m3MULS">Place sequence number for unloading</param>
		/// <param name="m3SULS">Unloading sequence within place</param>
		/// <param name="m3DEDA">Delivery date</param>
		/// <param name="m3OPCD">Operation code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDelivery(
			string m3E0PA, 
			string m3MSGN, 
			decimal m3DLIX, 
			int m3INOU, 
			string m3PRFL = null, 
			int? m3CONO = null, 
			DateTime? m3DSDT = null, 
			int? m3DSHM = null, 
			string m3ROUT = null, 
			int? m3RODN = null, 
			string m3MODF = null, 
			string m3TEDF = null, 
			string m3FWNO = null, 
			string m3LODO = null, 
			string m3EONN = null, 
			string m3TRCA = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			int? m3MULS = null, 
			int? m3SULS = null, 
			DateTime? m3DEDA = null, 
			string m3OPCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddDelivery",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("MSGN", m3MSGN.Trim())
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("INOU", m3INOU.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRFL))
				request.WithQueryParameter("PRFL", m3PRFL.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSDT.HasValue)
				request.WithQueryParameter("DSDT", m3DSDT.Value.ToM3String());
			if (m3DSHM.HasValue)
				request.WithQueryParameter("DSHM", m3DSHM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ROUT))
				request.WithQueryParameter("ROUT", m3ROUT.Trim());
			if (m3RODN.HasValue)
				request.WithQueryParameter("RODN", m3RODN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MODF))
				request.WithQueryParameter("MODF", m3MODF.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDF))
				request.WithQueryParameter("TEDF", m3TEDF.Trim());
			if (!string.IsNullOrWhiteSpace(m3FWNO))
				request.WithQueryParameter("FWNO", m3FWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3LODO))
				request.WithQueryParameter("LODO", m3LODO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EONN))
				request.WithQueryParameter("EONN", m3EONN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRCA))
				request.WithQueryParameter("TRCA", m3TRCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3MULS.HasValue)
				request.WithQueryParameter("MULS", m3MULS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SULS.HasValue)
				request.WithQueryParameter("SULS", m3SULS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DEDA.HasValue)
				request.WithQueryParameter("DEDA", m3DEDA.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3OPCD))
				request.WithQueryParameter("OPCD", m3OPCD.Trim());

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
		/// Name LstDelivery
		/// Description List delivery
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3INOU">Direction</param>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDeliveryResponse></returns>
		/// <exception cref="M3Exception<LstDeliveryResponse>"></exception>
		public async Task<M3Response<LstDeliveryResponse>> LstDelivery(
			string m3E0PA, 
			string m3MSGN, 
			int? m3CONO = null, 
			int? m3INOU = null, 
			decimal? m3DLIX = null, 
			string m3STAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstDelivery",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("MSGN", m3MSGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INOU.HasValue)
				request.WithQueryParameter("INOU", m3INOU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());

			// Execute the request
			var result = await Execute<LstDeliveryResponse>(
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
		/// Name LstHead
		/// Description List message header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadResponse></returns>
		/// <exception cref="M3Exception<LstHeadResponse>"></exception>
		public async Task<M3Response<LstHeadResponse>> LstHead(
			string m3E0PA, 
			int? m3CONO = null, 
			string m3MSGN = null, 
			string m3STAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());

			// Execute the request
			var result = await Execute<LstHeadResponse>(
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
		/// Name PrcDelivery
		/// Description Process delivery
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3INOU">Direction (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrcDelivery(
			string m3E0PA, 
			string m3MSGN, 
			decimal m3DLIX, 
			int m3INOU, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/PrcDelivery",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("MSGN", m3MSGN.Trim())
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("INOU", m3INOU.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name PrcHead
		/// Description Process message header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrcHead(
			string m3E0PA, 
			string m3MSGN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/PrcHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("MSGN", m3MSGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
