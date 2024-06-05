/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddDrillbackMap
		/// Description Transaction adds a Drillback mapping
		/// Version Release: 
		/// </summary>
		/// <param name="m3IDVI">Infor Drillback View ID (Required)</param>
		/// <param name="m3USID">User</param>
		/// <param name="m3BPG1">Browse program</param>
		/// <param name="m3SPIC">Opening panel</param>
		/// <param name="m3RELO">Option</param>
		/// <param name="m3MASH">Mashup</param>
		/// <param name="m3MAON">Application</param>
		/// <param name="m3MDEV">Default values</param>
		/// <param name="m3BPG2">Browse program</param>
		/// <param name="m3SPI3">Opening panel</param>
		/// <param name="m3REL2">Option</param>
		/// <param name="m3MAS2">Mashup</param>
		/// <param name="m3MAO2">Application</param>
		/// <param name="m3MDE2">Default values</param>
		/// <param name="m3BPG3">Browse program</param>
		/// <param name="m3SPI4">Opening panel</param>
		/// <param name="m3REL3">Option</param>
		/// <param name="m3MAS3">Mashup</param>
		/// <param name="m3MAO3">Application</param>
		/// <param name="m3MDE3">Default values</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDrillbackMap(
			string m3IDVI, 
			string m3USID = null, 
			string m3BPG1 = null, 
			string m3SPIC = null, 
			string m3RELO = null, 
			string m3MASH = null, 
			string m3MAON = null, 
			string m3MDEV = null, 
			string m3BPG2 = null, 
			string m3SPI3 = null, 
			string m3REL2 = null, 
			string m3MAS2 = null, 
			string m3MAO2 = null, 
			string m3MDE2 = null, 
			string m3BPG3 = null, 
			string m3SPI4 = null, 
			string m3REL3 = null, 
			string m3MAS3 = null, 
			string m3MAO3 = null, 
			string m3MDE3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddDrillbackMap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDVI))
				throw new ArgumentNullException(nameof(m3IDVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDVI", m3IDVI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3BPG1))
				request.WithQueryParameter("BPG1", m3BPG1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPIC))
				request.WithQueryParameter("SPIC", m3SPIC.Trim());
			if (!string.IsNullOrWhiteSpace(m3RELO))
				request.WithQueryParameter("RELO", m3RELO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MASH))
				request.WithQueryParameter("MASH", m3MASH.Trim());
			if (!string.IsNullOrWhiteSpace(m3MAON))
				request.WithQueryParameter("MAON", m3MAON.Trim());
			if (!string.IsNullOrWhiteSpace(m3MDEV))
				request.WithQueryParameter("MDEV", m3MDEV.Trim());
			if (!string.IsNullOrWhiteSpace(m3BPG2))
				request.WithQueryParameter("BPG2", m3BPG2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPI3))
				request.WithQueryParameter("SPI3", m3SPI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3REL2))
				request.WithQueryParameter("REL2", m3REL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MAS2))
				request.WithQueryParameter("MAS2", m3MAS2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MAO2))
				request.WithQueryParameter("MAO2", m3MAO2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MDE2))
				request.WithQueryParameter("MDE2", m3MDE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3BPG3))
				request.WithQueryParameter("BPG3", m3BPG3.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPI4))
				request.WithQueryParameter("SPI4", m3SPI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3REL3))
				request.WithQueryParameter("REL3", m3REL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MAS3))
				request.WithQueryParameter("MAS3", m3MAS3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MAO3))
				request.WithQueryParameter("MAO3", m3MAO3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MDE3))
				request.WithQueryParameter("MDE3", m3MDE3.Trim());

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
		/// Name ChgDrillbackMap
		/// Description Transaction changes a Drillback mapping
		/// Version Release: 
		/// </summary>
		/// <param name="m3IDVI">Infor Drillback View ID (Required)</param>
		/// <param name="m3USID">User</param>
		/// <param name="m3BPG1">Browse program</param>
		/// <param name="m3SPIC">Opening panel</param>
		/// <param name="m3RELO">Option</param>
		/// <param name="m3MASH">Mashup</param>
		/// <param name="m3MAON">Application</param>
		/// <param name="m3MDEV">Default values</param>
		/// <param name="m3BPG2">Browse program</param>
		/// <param name="m3SPI3">Opening panel</param>
		/// <param name="m3REL2">Option</param>
		/// <param name="m3MAS2">Mashup</param>
		/// <param name="m3MAO2">Application</param>
		/// <param name="m3MDE2">Default values</param>
		/// <param name="m3BPG3">Browse program</param>
		/// <param name="m3SPI4">Opening panel</param>
		/// <param name="m3REL3">Option</param>
		/// <param name="m3MAS3">Mashup</param>
		/// <param name="m3MAO3">Application</param>
		/// <param name="m3MDE3">Default values</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgDrillbackMap(
			string m3IDVI, 
			string m3USID = null, 
			string m3BPG1 = null, 
			string m3SPIC = null, 
			string m3RELO = null, 
			string m3MASH = null, 
			string m3MAON = null, 
			string m3MDEV = null, 
			string m3BPG2 = null, 
			string m3SPI3 = null, 
			string m3REL2 = null, 
			string m3MAS2 = null, 
			string m3MAO2 = null, 
			string m3MDE2 = null, 
			string m3BPG3 = null, 
			string m3SPI4 = null, 
			string m3REL3 = null, 
			string m3MAS3 = null, 
			string m3MAO3 = null, 
			string m3MDE3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgDrillbackMap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDVI))
				throw new ArgumentNullException(nameof(m3IDVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDVI", m3IDVI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3BPG1))
				request.WithQueryParameter("BPG1", m3BPG1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPIC))
				request.WithQueryParameter("SPIC", m3SPIC.Trim());
			if (!string.IsNullOrWhiteSpace(m3RELO))
				request.WithQueryParameter("RELO", m3RELO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MASH))
				request.WithQueryParameter("MASH", m3MASH.Trim());
			if (!string.IsNullOrWhiteSpace(m3MAON))
				request.WithQueryParameter("MAON", m3MAON.Trim());
			if (!string.IsNullOrWhiteSpace(m3MDEV))
				request.WithQueryParameter("MDEV", m3MDEV.Trim());
			if (!string.IsNullOrWhiteSpace(m3BPG2))
				request.WithQueryParameter("BPG2", m3BPG2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPI3))
				request.WithQueryParameter("SPI3", m3SPI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3REL2))
				request.WithQueryParameter("REL2", m3REL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MAS2))
				request.WithQueryParameter("MAS2", m3MAS2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MAO2))
				request.WithQueryParameter("MAO2", m3MAO2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MDE2))
				request.WithQueryParameter("MDE2", m3MDE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3BPG3))
				request.WithQueryParameter("BPG3", m3BPG3.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPI4))
				request.WithQueryParameter("SPI4", m3SPI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3REL3))
				request.WithQueryParameter("REL3", m3REL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MAS3))
				request.WithQueryParameter("MAS3", m3MAS3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MAO3))
				request.WithQueryParameter("MAO3", m3MAO3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MDE3))
				request.WithQueryParameter("MDE3", m3MDE3.Trim());

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
		/// Name DelDrillbackMap
		/// Description Transaction deletes an existing Drillback mapping
		/// Version Release: 
		/// </summary>
		/// <param name="m3IDVI">Infor Drillback View ID (Required)</param>
		/// <param name="m3USID">User</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelDrillbackMap(
			string m3IDVI, 
			string m3USID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelDrillbackMap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDVI))
				throw new ArgumentNullException(nameof(m3IDVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDVI", m3IDVI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());

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
		/// Name GetDrillbackMap
		/// Description Tranaction will get infor for a Drillback mapping
		/// Version Release: 
		/// </summary>
		/// <param name="m3IDVI">Infor Drillback View ID (Required)</param>
		/// <param name="m3USID">User</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDrillbackMapResponse></returns>
		/// <exception cref="M3Exception<GetDrillbackMapResponse>"></exception>
		public async Task<M3Response<GetDrillbackMapResponse>> GetDrillbackMap(
			string m3IDVI, 
			string m3USID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetDrillbackMap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDVI))
				throw new ArgumentNullException(nameof(m3IDVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDVI", m3IDVI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());

			// Execute the request
			var result = await Execute<GetDrillbackMapResponse>(
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
		/// Name LstDrillbackMap
		/// Description Tranaction lists infor for entity map
		/// Version Release: 
		/// </summary>
		/// <param name="m3IDVI">Infor Drillback View ID</param>
		/// <param name="m3USID">User</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDrillbackMapResponse></returns>
		/// <exception cref="M3Exception<LstDrillbackMapResponse>"></exception>
		public async Task<M3Response<LstDrillbackMapResponse>> LstDrillbackMap(
			string m3IDVI = null, 
			string m3USID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstDrillbackMap",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3IDVI))
				request.WithQueryParameter("IDVI", m3IDVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());

			// Execute the request
			var result = await Execute<LstDrillbackMapResponse>(
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
