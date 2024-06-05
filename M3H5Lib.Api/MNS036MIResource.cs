/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MNS036MI;
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
	/// Name: MNS036MI
	/// Component Name: DrillbackMapping
	/// Description: Api: Infor drillback mapping
	/// Version Release: 15.1
	///</summary>
	public partial class MNS036MIResource : M3BaseResourceEndpoint
	{
		public MNS036MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MNS036MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddDrillbackMap
		/// Description Transaction adds a Drillback mapping
		/// Version Release: 
		/// </summary>
		/// <param name="m3_IDVI">Infor Drillback View ID (Required)</param>
		/// <param name="m3_USID">User</param>
		/// <param name="m3_BPG1">Browse program</param>
		/// <param name="m3_SPIC">Opening panel</param>
		/// <param name="m3_RELO">Option</param>
		/// <param name="m3_MASH">Mashup</param>
		/// <param name="m3_MAON">Application</param>
		/// <param name="m3_MDEV">Default values</param>
		/// <param name="m3_BPG2">Browse program</param>
		/// <param name="m3_SPI3">Opening panel</param>
		/// <param name="m3_REL2">Option</param>
		/// <param name="m3_MAS2">Mashup</param>
		/// <param name="m3_MAO2">Application</param>
		/// <param name="m3_MDE2">Default values</param>
		/// <param name="m3_BPG3">Browse program</param>
		/// <param name="m3_SPI4">Opening panel</param>
		/// <param name="m3_REL3">Option</param>
		/// <param name="m3_MAS3">Mashup</param>
		/// <param name="m3_MAO3">Application</param>
		/// <param name="m3_MDE3">Default values</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDrillbackMap(
			string m3_IDVI, 
			string m3_USID = null, 
			string m3_BPG1 = null, 
			string m3_SPIC = null, 
			string m3_RELO = null, 
			string m3_MASH = null, 
			string m3_MAON = null, 
			string m3_MDEV = null, 
			string m3_BPG2 = null, 
			string m3_SPI3 = null, 
			string m3_REL2 = null, 
			string m3_MAS2 = null, 
			string m3_MAO2 = null, 
			string m3_MDE2 = null, 
			string m3_BPG3 = null, 
			string m3_SPI4 = null, 
			string m3_REL3 = null, 
			string m3_MAS3 = null, 
			string m3_MAO3 = null, 
			string m3_MDE3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddDrillbackMap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDVI))
				throw new ArgumentNullException("m3_IDVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDVI", m3_IDVI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BPG1))
				request.WithQueryParameter("BPG1", m3_BPG1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPIC))
				request.WithQueryParameter("SPIC", m3_SPIC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RELO))
				request.WithQueryParameter("RELO", m3_RELO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MASH))
				request.WithQueryParameter("MASH", m3_MASH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MAON))
				request.WithQueryParameter("MAON", m3_MAON.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MDEV))
				request.WithQueryParameter("MDEV", m3_MDEV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BPG2))
				request.WithQueryParameter("BPG2", m3_BPG2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPI3))
				request.WithQueryParameter("SPI3", m3_SPI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REL2))
				request.WithQueryParameter("REL2", m3_REL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MAS2))
				request.WithQueryParameter("MAS2", m3_MAS2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MAO2))
				request.WithQueryParameter("MAO2", m3_MAO2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MDE2))
				request.WithQueryParameter("MDE2", m3_MDE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BPG3))
				request.WithQueryParameter("BPG3", m3_BPG3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPI4))
				request.WithQueryParameter("SPI4", m3_SPI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REL3))
				request.WithQueryParameter("REL3", m3_REL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MAS3))
				request.WithQueryParameter("MAS3", m3_MAS3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MAO3))
				request.WithQueryParameter("MAO3", m3_MAO3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MDE3))
				request.WithQueryParameter("MDE3", m3_MDE3.Trim());

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
		/// Name ChgDrillbackMap
		/// Description Transaction changes a Drillback mapping
		/// Version Release: 
		/// </summary>
		/// <param name="m3_IDVI">Infor Drillback View ID (Required)</param>
		/// <param name="m3_USID">User</param>
		/// <param name="m3_BPG1">Browse program</param>
		/// <param name="m3_SPIC">Opening panel</param>
		/// <param name="m3_RELO">Option</param>
		/// <param name="m3_MASH">Mashup</param>
		/// <param name="m3_MAON">Application</param>
		/// <param name="m3_MDEV">Default values</param>
		/// <param name="m3_BPG2">Browse program</param>
		/// <param name="m3_SPI3">Opening panel</param>
		/// <param name="m3_REL2">Option</param>
		/// <param name="m3_MAS2">Mashup</param>
		/// <param name="m3_MAO2">Application</param>
		/// <param name="m3_MDE2">Default values</param>
		/// <param name="m3_BPG3">Browse program</param>
		/// <param name="m3_SPI4">Opening panel</param>
		/// <param name="m3_REL3">Option</param>
		/// <param name="m3_MAS3">Mashup</param>
		/// <param name="m3_MAO3">Application</param>
		/// <param name="m3_MDE3">Default values</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgDrillbackMap(
			string m3_IDVI, 
			string m3_USID = null, 
			string m3_BPG1 = null, 
			string m3_SPIC = null, 
			string m3_RELO = null, 
			string m3_MASH = null, 
			string m3_MAON = null, 
			string m3_MDEV = null, 
			string m3_BPG2 = null, 
			string m3_SPI3 = null, 
			string m3_REL2 = null, 
			string m3_MAS2 = null, 
			string m3_MAO2 = null, 
			string m3_MDE2 = null, 
			string m3_BPG3 = null, 
			string m3_SPI4 = null, 
			string m3_REL3 = null, 
			string m3_MAS3 = null, 
			string m3_MAO3 = null, 
			string m3_MDE3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgDrillbackMap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDVI))
				throw new ArgumentNullException("m3_IDVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDVI", m3_IDVI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BPG1))
				request.WithQueryParameter("BPG1", m3_BPG1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPIC))
				request.WithQueryParameter("SPIC", m3_SPIC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RELO))
				request.WithQueryParameter("RELO", m3_RELO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MASH))
				request.WithQueryParameter("MASH", m3_MASH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MAON))
				request.WithQueryParameter("MAON", m3_MAON.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MDEV))
				request.WithQueryParameter("MDEV", m3_MDEV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BPG2))
				request.WithQueryParameter("BPG2", m3_BPG2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPI3))
				request.WithQueryParameter("SPI3", m3_SPI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REL2))
				request.WithQueryParameter("REL2", m3_REL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MAS2))
				request.WithQueryParameter("MAS2", m3_MAS2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MAO2))
				request.WithQueryParameter("MAO2", m3_MAO2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MDE2))
				request.WithQueryParameter("MDE2", m3_MDE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BPG3))
				request.WithQueryParameter("BPG3", m3_BPG3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPI4))
				request.WithQueryParameter("SPI4", m3_SPI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REL3))
				request.WithQueryParameter("REL3", m3_REL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MAS3))
				request.WithQueryParameter("MAS3", m3_MAS3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MAO3))
				request.WithQueryParameter("MAO3", m3_MAO3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MDE3))
				request.WithQueryParameter("MDE3", m3_MDE3.Trim());

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
		/// Name DelDrillbackMap
		/// Description Transaction deletes an existing Drillback mapping
		/// Version Release: 
		/// </summary>
		/// <param name="m3_IDVI">Infor Drillback View ID (Required)</param>
		/// <param name="m3_USID">User</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelDrillbackMap(
			string m3_IDVI, 
			string m3_USID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelDrillbackMap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDVI))
				throw new ArgumentNullException("m3_IDVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDVI", m3_IDVI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());

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
		/// Name GetDrillbackMap
		/// Description Tranaction will get infor for a Drillback mapping
		/// Version Release: 
		/// </summary>
		/// <param name="m3_IDVI">Infor Drillback View ID (Required)</param>
		/// <param name="m3_USID">User</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDrillbackMapResponse></returns>
		/// <exception cref="M3Exception<GetDrillbackMapResponse>"></exception>
		public async Task<M3Response<GetDrillbackMapResponse>> GetDrillbackMap(
			string m3_IDVI, 
			string m3_USID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDrillbackMap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDVI))
				throw new ArgumentNullException("m3_IDVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDVI", m3_IDVI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());

			// Execute the request
			var result = await Execute<GetDrillbackMapResponse>(
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
		/// Name LstDrillbackMap
		/// Description Tranaction lists infor for entity map
		/// Version Release: 
		/// </summary>
		/// <param name="m3_IDVI">Infor Drillback View ID</param>
		/// <param name="m3_USID">User</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDrillbackMapResponse></returns>
		/// <exception cref="M3Exception<LstDrillbackMapResponse>"></exception>
		public async Task<M3Response<LstDrillbackMapResponse>> LstDrillbackMap(
			string m3_IDVI = null, 
			string m3_USID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDrillbackMap",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_IDVI))
				request.WithQueryParameter("IDVI", m3_IDVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());

			// Execute the request
			var result = await Execute<LstDrillbackMapResponse>(
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
