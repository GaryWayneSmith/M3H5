/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MOS156MI;
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
	/// Name: MOS156MI
	/// Component Name: Ad hoc address
	/// Description: Ad hoc address repository interface
	/// Version Release: 5e90
	///</summary>
	public partial class MOS156MIResource : M3BaseResourceEndpoint
	{
		public MOS156MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS156MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add ad hoc address
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_CUNM">Name</param>
		/// <param name="m3_CUA1">Address line 1</param>
		/// <param name="m3_CUA2">Address line 2</param>
		/// <param name="m3_CUA3">Address line 3</param>
		/// <param name="m3_CUA4">Address line 4</param>
		/// <param name="m3_PONO">Postal code</param>
		/// <param name="m3_DSTX">Delivery comment</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_TFNO">Facsimile transmission number</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_MEAL">Valid media</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_VRNO">VAT registration number</param>
		/// <param name="m3_EDES">Place</param>
		/// <param name="m3_ROUT">Route</param>
		/// <param name="m3_RODN">Route departure</param>
		/// <param name="m3_ULZO">Unloading zone</param>
		/// <param name="m3_ECF1">User-defined TST field 1</param>
		/// <param name="m3_ECF2">User-defined TST field 2</param>
		/// <param name="m3_ECF3">User-defined TST field 3</param>
		/// <param name="m3_ECF4">User-defined TST field  4</param>
		/// <param name="m3_ECF5">User-defined TST field 5</param>
		/// <param name="m3_GEOC">Geographical code</param>
		/// <param name="m3_TAXC">Tax code customer/address</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_HAFE">Harbor or airport</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="m3_SPLE">Standard point location code</param>
		/// <param name="m3_RASN">Rail station</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddResponse></returns>
		/// <exception cref="M3Exception<AddResponse>"></exception>
		public async Task<M3Response<AddResponse>> Add(
			string m3_CUNM = null, 
			string m3_CUA1 = null, 
			string m3_CUA2 = null, 
			string m3_CUA3 = null, 
			string m3_CUA4 = null, 
			string m3_PONO = null, 
			string m3_DSTX = null, 
			string m3_TOWN = null, 
			string m3_PHNO = null, 
			string m3_TFNO = null, 
			string m3_YREF = null, 
			string m3_MEAL = null, 
			string m3_CSCD = null, 
			string m3_VRNO = null, 
			string m3_EDES = null, 
			string m3_ROUT = null, 
			int? m3_RODN = null, 
			string m3_ULZO = null, 
			string m3_ECF1 = null, 
			string m3_ECF2 = null, 
			string m3_ECF3 = null, 
			string m3_ECF4 = null, 
			string m3_ECF5 = null, 
			int? m3_GEOC = null, 
			string m3_TAXC = null, 
			string m3_ECAR = null, 
			string m3_HAFE = null, 
			string m3_FRCO = null, 
			string m3_SPLE = null, 
			string m3_RASN = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNM))
				request.WithQueryParameter("CUNM", m3_CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA1))
				request.WithQueryParameter("CUA1", m3_CUA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA2))
				request.WithQueryParameter("CUA2", m3_CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA3))
				request.WithQueryParameter("CUA3", m3_CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA4))
				request.WithQueryParameter("CUA4", m3_CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSTX))
				request.WithQueryParameter("DSTX", m3_DSTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOWN))
				request.WithQueryParameter("TOWN", m3_TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEAL))
				request.WithQueryParameter("MEAL", m3_MEAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VRNO))
				request.WithQueryParameter("VRNO", m3_VRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDES))
				request.WithQueryParameter("EDES", m3_EDES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ROUT))
				request.WithQueryParameter("ROUT", m3_ROUT.Trim());
			if (m3_RODN.HasValue)
				request.WithQueryParameter("RODN", m3_RODN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ULZO))
				request.WithQueryParameter("ULZO", m3_ULZO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECF1))
				request.WithQueryParameter("ECF1", m3_ECF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECF2))
				request.WithQueryParameter("ECF2", m3_ECF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECF3))
				request.WithQueryParameter("ECF3", m3_ECF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECF4))
				request.WithQueryParameter("ECF4", m3_ECF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECF5))
				request.WithQueryParameter("ECF5", m3_ECF5.Trim());
			if (m3_GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3_GEOC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TAXC))
				request.WithQueryParameter("TAXC", m3_TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HAFE))
				request.WithQueryParameter("HAFE", m3_HAFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRCO))
				request.WithQueryParameter("FRCO", m3_FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPLE))
				request.WithQueryParameter("SPLE", m3_SPLE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RASN))
				request.WithQueryParameter("RASN", m3_RASN.Trim());

			// Execute the request
			var result = await Execute<AddResponse>(
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
		/// Name Chg
		/// Description Change ad hoc address
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ADID">Address number (Required)</param>
		/// <param name="m3_CUNM">Name</param>
		/// <param name="m3_CUA1">Address line 1</param>
		/// <param name="m3_CUA2">Address line 2</param>
		/// <param name="m3_CUA3">Address line 3</param>
		/// <param name="m3_CUA4">Address line 4</param>
		/// <param name="m3_PONO">Postal code</param>
		/// <param name="m3_DSTX">Delivery comment</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_TFNO">Facsimile transmission number</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_MEAL">Valid media</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_VRNO">VAT registration number</param>
		/// <param name="m3_EDES">Place</param>
		/// <param name="m3_ROUT">Route</param>
		/// <param name="m3_RODN">Route departure</param>
		/// <param name="m3_ULZO">Unloading zone</param>
		/// <param name="m3_ECF1">User-defined TST field 1</param>
		/// <param name="m3_ECF2">User-defined TST field 2</param>
		/// <param name="m3_ECF3">User-defined TST field 3</param>
		/// <param name="m3_ECF4">User-defined TST field  4</param>
		/// <param name="m3_ECF5">User-defined TST field 5</param>
		/// <param name="m3_GEOC">Geographical code</param>
		/// <param name="m3_TAXC">Tax code customer/address</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_HAFE">Harbor or airport</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="m3_SPLE">Standard point location code</param>
		/// <param name="m3_RASN">Rail station</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Chg(
			string m3_ADID, 
			string m3_CUNM = null, 
			string m3_CUA1 = null, 
			string m3_CUA2 = null, 
			string m3_CUA3 = null, 
			string m3_CUA4 = null, 
			string m3_PONO = null, 
			string m3_DSTX = null, 
			string m3_TOWN = null, 
			string m3_PHNO = null, 
			string m3_TFNO = null, 
			string m3_YREF = null, 
			string m3_MEAL = null, 
			string m3_CSCD = null, 
			string m3_VRNO = null, 
			string m3_EDES = null, 
			string m3_ROUT = null, 
			int? m3_RODN = null, 
			string m3_ULZO = null, 
			string m3_ECF1 = null, 
			string m3_ECF2 = null, 
			string m3_ECF3 = null, 
			string m3_ECF4 = null, 
			string m3_ECF5 = null, 
			int? m3_GEOC = null, 
			string m3_TAXC = null, 
			string m3_ECAR = null, 
			string m3_HAFE = null, 
			string m3_FRCO = null, 
			string m3_SPLE = null, 
			string m3_RASN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Chg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ADID))
				throw new ArgumentNullException("m3_ADID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ADID", m3_ADID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNM))
				request.WithQueryParameter("CUNM", m3_CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA1))
				request.WithQueryParameter("CUA1", m3_CUA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA2))
				request.WithQueryParameter("CUA2", m3_CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA3))
				request.WithQueryParameter("CUA3", m3_CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA4))
				request.WithQueryParameter("CUA4", m3_CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSTX))
				request.WithQueryParameter("DSTX", m3_DSTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOWN))
				request.WithQueryParameter("TOWN", m3_TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEAL))
				request.WithQueryParameter("MEAL", m3_MEAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VRNO))
				request.WithQueryParameter("VRNO", m3_VRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDES))
				request.WithQueryParameter("EDES", m3_EDES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ROUT))
				request.WithQueryParameter("ROUT", m3_ROUT.Trim());
			if (m3_RODN.HasValue)
				request.WithQueryParameter("RODN", m3_RODN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ULZO))
				request.WithQueryParameter("ULZO", m3_ULZO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECF1))
				request.WithQueryParameter("ECF1", m3_ECF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECF2))
				request.WithQueryParameter("ECF2", m3_ECF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECF3))
				request.WithQueryParameter("ECF3", m3_ECF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECF4))
				request.WithQueryParameter("ECF4", m3_ECF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECF5))
				request.WithQueryParameter("ECF5", m3_ECF5.Trim());
			if (m3_GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3_GEOC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TAXC))
				request.WithQueryParameter("TAXC", m3_TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HAFE))
				request.WithQueryParameter("HAFE", m3_HAFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRCO))
				request.WithQueryParameter("FRCO", m3_FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPLE))
				request.WithQueryParameter("SPLE", m3_SPLE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RASN))
				request.WithQueryParameter("RASN", m3_RASN.Trim());

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
		/// Name Delete
		/// Description Delete a specific ad hoc address
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ADID">Address number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3_ADID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Delete",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ADID))
				throw new ArgumentNullException("m3_ADID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ADID", m3_ADID.Trim());

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
		/// Name Get
		/// Description Get specific ad hoc address
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ADID">Address number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_ADID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ADID))
				throw new ArgumentNullException("m3_ADID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ADID", m3_ADID.Trim());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name LstByCustAddr
		/// Description LstByCustAddr
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_CUA1">Address line 1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByCustAddrResponse></returns>
		/// <exception cref="M3Exception<LstByCustAddrResponse>"></exception>
		public async Task<M3Response<LstByCustAddrResponse>> LstByCustAddr(
			string m3_CUA1 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByCustAddr",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUA1))
				request.WithQueryParameter("CUA1", m3_CUA1.Trim());

			// Execute the request
			var result = await Execute<LstByCustAddrResponse>(
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
		/// Name LstByCustName
		/// Description List By Customer Name
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_CUNM">Name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByCustNameResponse></returns>
		/// <exception cref="M3Exception<LstByCustNameResponse>"></exception>
		public async Task<M3Response<LstByCustNameResponse>> LstByCustName(
			string m3_CUNM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByCustName",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNM))
				request.WithQueryParameter("CUNM", m3_CUNM.Trim());

			// Execute the request
			var result = await Execute<LstByCustNameResponse>(
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
		/// Name LstByDelComment
		/// Description LstByDelComment
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_DSTX">Delivery comment</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByDelCommentResponse></returns>
		/// <exception cref="M3Exception<LstByDelCommentResponse>"></exception>
		public async Task<M3Response<LstByDelCommentResponse>> LstByDelComment(
			string m3_DSTX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByDelComment",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DSTX))
				request.WithQueryParameter("DSTX", m3_DSTX.Trim());

			// Execute the request
			var result = await Execute<LstByDelCommentResponse>(
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
