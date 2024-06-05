/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddDepot
		/// Description Add depot
		/// Version Release: 
		/// </summary>
		/// <param name="m3DPOT">Rental depot (Required)</param>
		/// <param name="m3DISY">Discount model (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3WHYA">Warehouse - yard (Required)</param>
		/// <param name="m3WHOH">Warehouse - on hire (Required)</param>
		/// <param name="m3PRRF">Price list (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3WXYA">Warehouse - cross hire on yard</param>
		/// <param name="m3WXOH">Warehouse - cross hire on hire</param>
		/// <param name="m3RPLT">Rent PL tab</param>
		/// <param name="m3PLTB">Price list table</param>
		/// <param name="m3RDIS">Rental discount model</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDepot(
			string m3DPOT, 
			string m3DISY, 
			string m3FACI, 
			string m3TX40, 
			string m3WHYA, 
			string m3WHOH, 
			string m3PRRF, 
			string m3CUCD, 
			string m3DIVI = null, 
			string m3TX15 = null, 
			string m3WXYA = null, 
			string m3WXOH = null, 
			string m3RPLT = null, 
			string m3PLTB = null, 
			string m3RDIS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddDepot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DPOT))
				throw new ArgumentNullException(nameof(m3DPOT));
			if (string.IsNullOrWhiteSpace(m3DISY))
				throw new ArgumentNullException(nameof(m3DISY));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));
			if (string.IsNullOrWhiteSpace(m3WHYA))
				throw new ArgumentNullException(nameof(m3WHYA));
			if (string.IsNullOrWhiteSpace(m3WHOH))
				throw new ArgumentNullException(nameof(m3WHOH));
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("DPOT", m3DPOT.Trim())
				.WithQueryParameter("DISY", m3DISY.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim())
				.WithQueryParameter("WHYA", m3WHYA.Trim())
				.WithQueryParameter("WHOH", m3WHOH.Trim())
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3WXYA))
				request.WithQueryParameter("WXYA", m3WXYA.Trim());
			if (!string.IsNullOrWhiteSpace(m3WXOH))
				request.WithQueryParameter("WXOH", m3WXOH.Trim());
			if (!string.IsNullOrWhiteSpace(m3RPLT))
				request.WithQueryParameter("RPLT", m3RPLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLTB))
				request.WithQueryParameter("PLTB", m3PLTB.Trim());
			if (!string.IsNullOrWhiteSpace(m3RDIS))
				request.WithQueryParameter("RDIS", m3RDIS.Trim());

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
		/// Name DltDepot
		/// Description Delete depot
		/// Version Release: 
		/// </summary>
		/// <param name="m3DPOT">Rental depot (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltDepot(
			string m3DPOT, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltDepot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DPOT))
				throw new ArgumentNullException(nameof(m3DPOT));

			// Set mandatory parameters
			request
				.WithQueryParameter("DPOT", m3DPOT.Trim());

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
		/// Name GetDepot
		/// Description Get depot
		/// Version Release: 
		/// </summary>
		/// <param name="m3DPOT">Rental depot (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDepotResponse></returns>
		/// <exception cref="M3Exception<GetDepotResponse>"></exception>
		public async Task<M3Response<GetDepotResponse>> GetDepot(
			string m3DPOT, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetDepot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DPOT))
				throw new ArgumentNullException(nameof(m3DPOT));

			// Set mandatory parameters
			request
				.WithQueryParameter("DPOT", m3DPOT.Trim());

			// Execute the request
			var result = await Execute<GetDepotResponse>(
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstDepots",
			};

			// Execute the request
			var result = await Execute<LstDepotsResponse>(
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
		/// Name UpdDepot
		/// Description Update depot
		/// Version Release: 
		/// </summary>
		/// <param name="m3DPOT">Rental depot (Required)</param>
		/// <param name="m3DISY">Discount model (Required)</param>
		/// <param name="m3WHYA">Warehouse - yard (Required)</param>
		/// <param name="m3WHOH">Warehouse - on hire (Required)</param>
		/// <param name="m3PRRF">Price list (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3WXYA">Warehouse - cross hire on yard</param>
		/// <param name="m3WXOH">Warehouse - cross hire on hire</param>
		/// <param name="m3RPLT">Rent PL tab</param>
		/// <param name="m3PLTB">Price list table</param>
		/// <param name="m3RDIS">Rental discount model</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdDepot(
			string m3DPOT, 
			string m3DISY, 
			string m3WHYA, 
			string m3WHOH, 
			string m3PRRF, 
			string m3CUCD, 
			string m3DIVI = null, 
			string m3FACI = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3WXYA = null, 
			string m3WXOH = null, 
			string m3RPLT = null, 
			string m3PLTB = null, 
			string m3RDIS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdDepot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DPOT))
				throw new ArgumentNullException(nameof(m3DPOT));
			if (string.IsNullOrWhiteSpace(m3DISY))
				throw new ArgumentNullException(nameof(m3DISY));
			if (string.IsNullOrWhiteSpace(m3WHYA))
				throw new ArgumentNullException(nameof(m3WHYA));
			if (string.IsNullOrWhiteSpace(m3WHOH))
				throw new ArgumentNullException(nameof(m3WHOH));
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("DPOT", m3DPOT.Trim())
				.WithQueryParameter("DISY", m3DISY.Trim())
				.WithQueryParameter("WHYA", m3WHYA.Trim())
				.WithQueryParameter("WHOH", m3WHOH.Trim())
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3WXYA))
				request.WithQueryParameter("WXYA", m3WXYA.Trim());
			if (!string.IsNullOrWhiteSpace(m3WXOH))
				request.WithQueryParameter("WXOH", m3WXOH.Trim());
			if (!string.IsNullOrWhiteSpace(m3RPLT))
				request.WithQueryParameter("RPLT", m3RPLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLTB))
				request.WithQueryParameter("PLTB", m3PLTB.Trim());
			if (!string.IsNullOrWhiteSpace(m3RDIS))
				request.WithQueryParameter("RDIS", m3RDIS.Trim());

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
