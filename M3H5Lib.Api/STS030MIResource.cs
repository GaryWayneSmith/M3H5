/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.STS030MI;
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
	/// Name: STS030MI
	/// Component Name: 
	/// Description: API: Rental depot
	/// Version Release: 5ea0
	///</summary>
	public partial class STS030MIResource : M3BaseResourceEndpoint
	{
		public STS030MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "STS030MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddDepot
		/// Description Add depot
		/// Version Release: 
		/// </summary>
		/// <param name="m3_DPOT">Rental depot (Required)</param>
		/// <param name="m3_DISY">Discount model (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_WHYA">Warehouse - yard (Required)</param>
		/// <param name="m3_WHOH">Warehouse - on hire (Required)</param>
		/// <param name="m3_PRRF">Price list (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_WXYA">Warehouse - cross hire on yard</param>
		/// <param name="m3_WXOH">Warehouse - cross hire on hire</param>
		/// <param name="m3_RPLT">Rent PL tab</param>
		/// <param name="m3_PLTB">Price list table</param>
		/// <param name="m3_RDIS">Rental discount model</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDepot(
			string m3_DPOT, 
			string m3_DISY, 
			string m3_FACI, 
			string m3_TX40, 
			string m3_WHYA, 
			string m3_WHOH, 
			string m3_PRRF, 
			string m3_CUCD, 
			string m3_DIVI = null, 
			string m3_TX15 = null, 
			string m3_WXYA = null, 
			string m3_WXOH = null, 
			string m3_RPLT = null, 
			string m3_PLTB = null, 
			string m3_RDIS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddDepot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DPOT))
				throw new ArgumentNullException("m3_DPOT");
			if (string.IsNullOrWhiteSpace(m3_DISY))
				throw new ArgumentNullException("m3_DISY");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");
			if (string.IsNullOrWhiteSpace(m3_WHYA))
				throw new ArgumentNullException("m3_WHYA");
			if (string.IsNullOrWhiteSpace(m3_WHOH))
				throw new ArgumentNullException("m3_WHOH");
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("DPOT", m3_DPOT.Trim())
				.WithQueryParameter("DISY", m3_DISY.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim())
				.WithQueryParameter("WHYA", m3_WHYA.Trim())
				.WithQueryParameter("WHOH", m3_WHOH.Trim())
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WXYA))
				request.WithQueryParameter("WXYA", m3_WXYA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WXOH))
				request.WithQueryParameter("WXOH", m3_WXOH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RPLT))
				request.WithQueryParameter("RPLT", m3_RPLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLTB))
				request.WithQueryParameter("PLTB", m3_PLTB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RDIS))
				request.WithQueryParameter("RDIS", m3_RDIS.Trim());

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
		/// Name DltDepot
		/// Description Delete depot
		/// Version Release: 
		/// </summary>
		/// <param name="m3_DPOT">Rental depot (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltDepot(
			string m3_DPOT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltDepot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DPOT))
				throw new ArgumentNullException("m3_DPOT");

			// Set mandatory parameters
			request
				.WithQueryParameter("DPOT", m3_DPOT.Trim());

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
		/// Name GetDepot
		/// Description Get depot
		/// Version Release: 
		/// </summary>
		/// <param name="m3_DPOT">Rental depot (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDepotResponse></returns>
		/// <exception cref="M3Exception<GetDepotResponse>"></exception>
		public async Task<M3Response<GetDepotResponse>> GetDepot(
			string m3_DPOT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDepot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DPOT))
				throw new ArgumentNullException("m3_DPOT");

			// Set mandatory parameters
			request
				.WithQueryParameter("DPOT", m3_DPOT.Trim());

			// Execute the request
			var result = await Execute<GetDepotResponse>(
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
		/// Name LstDepots
		/// Description List depots
		/// Version Release: 
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDepotsResponse></returns>
		/// <exception cref="M3Exception<LstDepotsResponse>"></exception>
		public async Task<M3Response<LstDepotsResponse>> LstDepots(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDepots",
			};

			// Execute the request
			var result = await Execute<LstDepotsResponse>(
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
		/// Name UpdDepot
		/// Description Update depot
		/// Version Release: 
		/// </summary>
		/// <param name="m3_DPOT">Rental depot (Required)</param>
		/// <param name="m3_DISY">Discount model (Required)</param>
		/// <param name="m3_WHYA">Warehouse - yard (Required)</param>
		/// <param name="m3_WHOH">Warehouse - on hire (Required)</param>
		/// <param name="m3_PRRF">Price list (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_WXYA">Warehouse - cross hire on yard</param>
		/// <param name="m3_WXOH">Warehouse - cross hire on hire</param>
		/// <param name="m3_RPLT">Rent PL tab</param>
		/// <param name="m3_PLTB">Price list table</param>
		/// <param name="m3_RDIS">Rental discount model</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdDepot(
			string m3_DPOT, 
			string m3_DISY, 
			string m3_WHYA, 
			string m3_WHOH, 
			string m3_PRRF, 
			string m3_CUCD, 
			string m3_DIVI = null, 
			string m3_FACI = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_WXYA = null, 
			string m3_WXOH = null, 
			string m3_RPLT = null, 
			string m3_PLTB = null, 
			string m3_RDIS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdDepot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DPOT))
				throw new ArgumentNullException("m3_DPOT");
			if (string.IsNullOrWhiteSpace(m3_DISY))
				throw new ArgumentNullException("m3_DISY");
			if (string.IsNullOrWhiteSpace(m3_WHYA))
				throw new ArgumentNullException("m3_WHYA");
			if (string.IsNullOrWhiteSpace(m3_WHOH))
				throw new ArgumentNullException("m3_WHOH");
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("DPOT", m3_DPOT.Trim())
				.WithQueryParameter("DISY", m3_DISY.Trim())
				.WithQueryParameter("WHYA", m3_WHYA.Trim())
				.WithQueryParameter("WHOH", m3_WHOH.Trim())
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WXYA))
				request.WithQueryParameter("WXYA", m3_WXYA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WXOH))
				request.WithQueryParameter("WXOH", m3_WXOH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RPLT))
				request.WithQueryParameter("RPLT", m3_RPLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLTB))
				request.WithQueryParameter("PLTB", m3_PLTB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RDIS))
				request.WithQueryParameter("RDIS", m3_RDIS.Trim());

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
