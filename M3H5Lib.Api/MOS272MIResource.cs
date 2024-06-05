/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MOS272MI;
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
	/// Name: MOS272MI
	/// Component Name: VehicleLocationHistory
	/// Description: Vehicle location history interface
	/// Version Release: 5ea0
	///</summary>
	public partial class MOS272MIResource : M3BaseResourceEndpoint
	{
		public MOS272MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS272MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TAIL">Registration number/site (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_STTI">Start time (Required)</param>
		/// <param name="m3_CUA1">Customer address 1 (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_CORX">Coordinate X</param>
		/// <param name="m3_CORY">Coordinate Y</param>
		/// <param name="m3_CORZ">Coordinate Z</param>
		/// <param name="m3_CUA2">Customer address 2</param>
		/// <param name="m3_CUA3">Customer address 3</param>
		/// <param name="m3_CUA4">Customer address 4</param>
		/// <param name="m3_PONO">Postal code</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_ADRT">Address type</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TEDL">Delivery terms</param>
		/// <param name="m3_TX60">Text</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Reference order Line suffix</param>
		/// <param name="m3_DELE">Yes/no</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_TAIL, 
			DateTime m3_STDT, 
			int m3_STTI, 
			string m3_CUA1, 
			string m3_ITNO, 
			string m3_SERN, 
			int? m3_CONO = null, 
			string m3_CFGL = null, 
			string m3_CORX = null, 
			string m3_CORY = null, 
			string m3_CORZ = null, 
			string m3_CUA2 = null, 
			string m3_CUA3 = null, 
			string m3_CUA4 = null, 
			string m3_PONO = null, 
			string m3_PHNO = null, 
			string m3_YREF = null, 
			string m3_ECAR = null, 
			string m3_CSCD = null, 
			string m3_TOWN = null, 
			string m3_CUNO = null, 
			int? m3_ADRT = null, 
			string m3_MODL = null, 
			string m3_TEDL = null, 
			string m3_TX60 = null, 
			string m3_STAT = null, 
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_DELE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TAIL))
				throw new ArgumentNullException("m3_TAIL");
			if (string.IsNullOrWhiteSpace(m3_CUA1))
				throw new ArgumentNullException("m3_CUA1");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");

			// Set mandatory parameters
			request
				.WithQueryParameter("TAIL", m3_TAIL.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("STTI", m3_STTI.ToString())
				.WithQueryParameter("CUA1", m3_CUA1.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CORX))
				request.WithQueryParameter("CORX", m3_CORX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CORY))
				request.WithQueryParameter("CORY", m3_CORY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CORZ))
				request.WithQueryParameter("CORZ", m3_CORZ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA2))
				request.WithQueryParameter("CUA2", m3_CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA3))
				request.WithQueryParameter("CUA3", m3_CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA4))
				request.WithQueryParameter("CUA4", m3_CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOWN))
				request.WithQueryParameter("TOWN", m3_TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3_ADRT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX60))
				request.WithQueryParameter("TX60", m3_TX60.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DELE))
				request.WithQueryParameter("DELE", m3_DELE.Trim());

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
		/// Name ChgStatus
		/// Description Change Status
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_STAT">Status (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TAIL">Registration number/site</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STTI">Start time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgStatus(
			string m3_STAT, 
			int? m3_CONO = null, 
			string m3_TAIL = null, 
			string m3_CFGL = null, 
			string m3_ITNO = null, 
			string m3_SERN = null, 
			DateTime? m3_STDT = null, 
			int? m3_STTI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgStatus",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STAT))
				throw new ArgumentNullException("m3_STAT");

			// Set mandatory parameters
			request
				.WithQueryParameter("STAT", m3_STAT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TAIL))
				request.WithQueryParameter("TAIL", m3_TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STTI.HasValue)
				request.WithQueryParameter("STTI", m3_STTI.Value.ToString());

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
		/// Name CnvDataFeed
		/// Description Convert Date from one Timezone to another
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_RDTE">Received date</param>
		/// <param name="m3_RTIM">Received time (HHMMSS)</param>
		/// <param name="m3_MDTE">Module Date</param>
		/// <param name="m3_MTIM">Module Time (HHMMSS)</param>
		/// <param name="m3_FTZN">From Time zone</param>
		/// <param name="m3_TTZN">To Time zone</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CnvDataFeedResponse></returns>
		/// <exception cref="M3Exception<CnvDataFeedResponse>"></exception>
		public async Task<M3Response<CnvDataFeedResponse>> CnvDataFeed(
			DateTime? m3_RDTE = null, 
			int? m3_RTIM = null, 
			DateTime? m3_MDTE = null, 
			int? m3_MTIM = null, 
			string m3_FTZN = null, 
			string m3_TTZN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CnvDataFeed",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RDTE.HasValue)
				request.WithQueryParameter("RDTE", m3_RDTE.Value.ToM3String());
			if (m3_RTIM.HasValue)
				request.WithQueryParameter("RTIM", m3_RTIM.Value.ToString());
			if (m3_MDTE.HasValue)
				request.WithQueryParameter("MDTE", m3_MDTE.Value.ToM3String());
			if (m3_MTIM.HasValue)
				request.WithQueryParameter("MTIM", m3_MTIM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FTZN))
				request.WithQueryParameter("FTZN", m3_FTZN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TTZN))
				request.WithQueryParameter("TTZN", m3_TTZN.Trim());

			// Execute the request
			var result = await Execute<CnvDataFeedResponse>(
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
		/// Name DltDataFeed
		/// Description Delete Data Feed
		/// Version Release: 
		/// </summary>
		/// <param name="m3_BIRT">Origin identity (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_STTI">Start time (Required)</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_CORZ">Coordinate Z</param>
		/// <param name="m3_DALL">Delete all records</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltDataFeed(
			long m3_BIRT, 
			DateTime m3_STDT, 
			int m3_STTI, 
			string m3_CFGL = null, 
			string m3_CORZ = null, 
			int? m3_DALL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltDataFeed",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("BIRT", m3_BIRT.ToString())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("STTI", m3_STTI.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CORZ))
				request.WithQueryParameter("CORZ", m3_CORZ.Trim());
			if (m3_DALL.HasValue)
				request.WithQueryParameter("DALL", m3_DALL.Value.ToString());

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
		/// Name GetAddress
		/// Description Get latest address for an Equipment/Position
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TAIL">Registration number/site</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STTI">Start time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAddressResponse></returns>
		/// <exception cref="M3Exception<GetAddressResponse>"></exception>
		public async Task<M3Response<GetAddressResponse>> GetAddress(
			string m3_TAIL = null, 
			string m3_CFGL = null, 
			string m3_ITNO = null, 
			string m3_SERN = null, 
			DateTime? m3_STDT = null, 
			int? m3_STTI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAddress",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TAIL))
				request.WithQueryParameter("TAIL", m3_TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STTI.HasValue)
				request.WithQueryParameter("STTI", m3_STTI.Value.ToString());

			// Execute the request
			var result = await Execute<GetAddressResponse>(
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
		/// Name GetAddressById
		/// Description Get address based on ADID,
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAddressByIdResponse></returns>
		/// <exception cref="M3Exception<GetAddressByIdResponse>"></exception>
		public async Task<M3Response<GetAddressByIdResponse>> GetAddressById(
			string m3_ADID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAddressById",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());

			// Execute the request
			var result = await Execute<GetAddressByIdResponse>(
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
