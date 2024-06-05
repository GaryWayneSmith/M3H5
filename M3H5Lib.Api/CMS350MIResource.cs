/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.CMS350MI;
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
	/// Name: CMS350MI
	/// Component Name: Equipment
	/// Description: Event log subscriber
	/// Version Release: 15
	///</summary>
	public partial class CMS350MIResource : M3BaseResourceEndpoint
	{
		public CMS350MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS350MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddPartner
		/// Description Add record to CSYEVS
		/// Version Release: 15
		/// </summary>
		/// <param name="m3EVNM">Event name</param>
		/// <param name="m3EVNO">Event name operation</param>
		/// <param name="m3EVPB">Event publisher</param>
		/// <param name="m3FLDI">Field</param>
		/// <param name="m3PAID">Partner identity</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPartner(
			string m3EVNM = null, 
			string m3EVNO = null, 
			string m3EVPB = null, 
			string m3FLDI = null, 
			string m3PAID = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddPartner",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EVNM))
				request.WithQueryParameter("EVNM", m3EVNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVNO))
				request.WithQueryParameter("EVNO", m3EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVPB))
				request.WithQueryParameter("EVPB", m3EVPB.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLDI))
				request.WithQueryParameter("FLDI", m3FLDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAID))
				request.WithQueryParameter("PAID", m3PAID.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());

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
		/// Name DltPartner
		/// Description Delete record in CSYEVS
		/// Version Release: 15
		/// </summary>
		/// <param name="m3EVNM">Event name</param>
		/// <param name="m3EVNO">Event name operation</param>
		/// <param name="m3EVPB">Event publisher</param>
		/// <param name="m3FLDI">Field</param>
		/// <param name="m3PAID">Partner identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltPartner(
			string m3EVNM = null, 
			string m3EVNO = null, 
			string m3EVPB = null, 
			string m3FLDI = null, 
			string m3PAID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltPartner",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EVNM))
				request.WithQueryParameter("EVNM", m3EVNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVNO))
				request.WithQueryParameter("EVNO", m3EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVPB))
				request.WithQueryParameter("EVPB", m3EVPB.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLDI))
				request.WithQueryParameter("FLDI", m3FLDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAID))
				request.WithQueryParameter("PAID", m3PAID.Trim());

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
		/// Name GetPartner
		/// Description Get partner
		/// Version Release: 15
		/// </summary>
		/// <param name="m3EVNM">Event name</param>
		/// <param name="m3EVNO">Event name operation</param>
		/// <param name="m3EVPB">Event publisher</param>
		/// <param name="m3FLDI">Field</param>
		/// <param name="m3PAID">Partner identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPartnerResponse></returns>
		/// <exception cref="M3Exception<GetPartnerResponse>"></exception>
		public async Task<M3Response<GetPartnerResponse>> GetPartner(
			string m3EVNM = null, 
			string m3EVNO = null, 
			string m3EVPB = null, 
			string m3FLDI = null, 
			string m3PAID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetPartner",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EVNM))
				request.WithQueryParameter("EVNM", m3EVNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVNO))
				request.WithQueryParameter("EVNO", m3EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVPB))
				request.WithQueryParameter("EVPB", m3EVPB.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLDI))
				request.WithQueryParameter("FLDI", m3FLDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAID))
				request.WithQueryParameter("PAID", m3PAID.Trim());

			// Execute the request
			var result = await Execute<GetPartnerResponse>(
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
		/// Name LstPartners
		/// Description List partners
		/// Version Release: 15
		/// </summary>
		/// <param name="m3EVNM">Event name</param>
		/// <param name="m3EVNO">Event name operation</param>
		/// <param name="m3EVPB">Event publisher</param>
		/// <param name="m3FLDI">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPartnersResponse></returns>
		/// <exception cref="M3Exception<LstPartnersResponse>"></exception>
		public async Task<M3Response<LstPartnersResponse>> LstPartners(
			string m3EVNM = null, 
			string m3EVNO = null, 
			string m3EVPB = null, 
			string m3FLDI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPartners",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EVNM))
				request.WithQueryParameter("EVNM", m3EVNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVNO))
				request.WithQueryParameter("EVNO", m3EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVPB))
				request.WithQueryParameter("EVPB", m3EVPB.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLDI))
				request.WithQueryParameter("FLDI", m3FLDI.Trim());

			// Execute the request
			var result = await Execute<LstPartnersResponse>(
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
		/// Name UpdPartner
		/// Description Update record in CSYEVS
		/// Version Release: 15
		/// </summary>
		/// <param name="m3EVNM">Event name</param>
		/// <param name="m3EVNO">Event name operation</param>
		/// <param name="m3EVPB">Event publisher</param>
		/// <param name="m3FLDI">Field</param>
		/// <param name="m3PAID">Partner identity</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPartner(
			string m3EVNM = null, 
			string m3EVNO = null, 
			string m3EVPB = null, 
			string m3FLDI = null, 
			string m3PAID = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdPartner",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EVNM))
				request.WithQueryParameter("EVNM", m3EVNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVNO))
				request.WithQueryParameter("EVNO", m3EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVPB))
				request.WithQueryParameter("EVPB", m3EVPB.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLDI))
				request.WithQueryParameter("FLDI", m3FLDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAID))
				request.WithQueryParameter("PAID", m3PAID.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());

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
