/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add ad hoc address
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3CUNM">Name</param>
		/// <param name="m3CUA1">Address line 1</param>
		/// <param name="m3CUA2">Address line 2</param>
		/// <param name="m3CUA3">Address line 3</param>
		/// <param name="m3CUA4">Address line 4</param>
		/// <param name="m3PONO">Postal code</param>
		/// <param name="m3DSTX">Delivery comment</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3TFNO">Facsimile transmission number</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3MEAL">Valid media</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3VRNO">VAT registration number</param>
		/// <param name="m3EDES">Place</param>
		/// <param name="m3ROUT">Route</param>
		/// <param name="m3RODN">Route departure</param>
		/// <param name="m3ULZO">Unloading zone</param>
		/// <param name="m3ECF1">User-defined TST field 1</param>
		/// <param name="m3ECF2">User-defined TST field 2</param>
		/// <param name="m3ECF3">User-defined TST field 3</param>
		/// <param name="m3ECF4">User-defined TST field  4</param>
		/// <param name="m3ECF5">User-defined TST field 5</param>
		/// <param name="m3GEOC">Geographical code</param>
		/// <param name="m3TAXC">Tax code customer/address</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3HAFE">Harbor or airport</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="m3SPLE">Standard point location code</param>
		/// <param name="m3RASN">Rail station</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddResponse></returns>
		/// <exception cref="M3Exception<AddResponse>"></exception>
		public async Task<M3Response<AddResponse>> Add(
			string m3CUNM = null, 
			string m3CUA1 = null, 
			string m3CUA2 = null, 
			string m3CUA3 = null, 
			string m3CUA4 = null, 
			string m3PONO = null, 
			string m3DSTX = null, 
			string m3TOWN = null, 
			string m3PHNO = null, 
			string m3TFNO = null, 
			string m3YREF = null, 
			string m3MEAL = null, 
			string m3CSCD = null, 
			string m3VRNO = null, 
			string m3EDES = null, 
			string m3ROUT = null, 
			int? m3RODN = null, 
			string m3ULZO = null, 
			string m3ECF1 = null, 
			string m3ECF2 = null, 
			string m3ECF3 = null, 
			string m3ECF4 = null, 
			string m3ECF5 = null, 
			int? m3GEOC = null, 
			string m3TAXC = null, 
			string m3ECAR = null, 
			string m3HAFE = null, 
			string m3FRCO = null, 
			string m3SPLE = null, 
			string m3RASN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Add",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNM))
				request.WithQueryParameter("CUNM", m3CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA1))
				request.WithQueryParameter("CUA1", m3CUA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA2))
				request.WithQueryParameter("CUA2", m3CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA3))
				request.WithQueryParameter("CUA3", m3CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA4))
				request.WithQueryParameter("CUA4", m3CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSTX))
				request.WithQueryParameter("DSTX", m3DSTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOWN))
				request.WithQueryParameter("TOWN", m3TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEAL))
				request.WithQueryParameter("MEAL", m3MEAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3VRNO))
				request.WithQueryParameter("VRNO", m3VRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDES))
				request.WithQueryParameter("EDES", m3EDES.Trim());
			if (!string.IsNullOrWhiteSpace(m3ROUT))
				request.WithQueryParameter("ROUT", m3ROUT.Trim());
			if (m3RODN.HasValue)
				request.WithQueryParameter("RODN", m3RODN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ULZO))
				request.WithQueryParameter("ULZO", m3ULZO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECF1))
				request.WithQueryParameter("ECF1", m3ECF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECF2))
				request.WithQueryParameter("ECF2", m3ECF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECF3))
				request.WithQueryParameter("ECF3", m3ECF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECF4))
				request.WithQueryParameter("ECF4", m3ECF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECF5))
				request.WithQueryParameter("ECF5", m3ECF5.Trim());
			if (m3GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3GEOC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TAXC))
				request.WithQueryParameter("TAXC", m3TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3HAFE))
				request.WithQueryParameter("HAFE", m3HAFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRCO))
				request.WithQueryParameter("FRCO", m3FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPLE))
				request.WithQueryParameter("SPLE", m3SPLE.Trim());
			if (!string.IsNullOrWhiteSpace(m3RASN))
				request.WithQueryParameter("RASN", m3RASN.Trim());

			// Execute the request
			var result = await Execute<AddResponse>(
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
		/// Name Chg
		/// Description Change ad hoc address
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3ADID">Address number (Required)</param>
		/// <param name="m3CUNM">Name</param>
		/// <param name="m3CUA1">Address line 1</param>
		/// <param name="m3CUA2">Address line 2</param>
		/// <param name="m3CUA3">Address line 3</param>
		/// <param name="m3CUA4">Address line 4</param>
		/// <param name="m3PONO">Postal code</param>
		/// <param name="m3DSTX">Delivery comment</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3TFNO">Facsimile transmission number</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3MEAL">Valid media</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3VRNO">VAT registration number</param>
		/// <param name="m3EDES">Place</param>
		/// <param name="m3ROUT">Route</param>
		/// <param name="m3RODN">Route departure</param>
		/// <param name="m3ULZO">Unloading zone</param>
		/// <param name="m3ECF1">User-defined TST field 1</param>
		/// <param name="m3ECF2">User-defined TST field 2</param>
		/// <param name="m3ECF3">User-defined TST field 3</param>
		/// <param name="m3ECF4">User-defined TST field  4</param>
		/// <param name="m3ECF5">User-defined TST field 5</param>
		/// <param name="m3GEOC">Geographical code</param>
		/// <param name="m3TAXC">Tax code customer/address</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3HAFE">Harbor or airport</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="m3SPLE">Standard point location code</param>
		/// <param name="m3RASN">Rail station</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Chg(
			string m3ADID, 
			string m3CUNM = null, 
			string m3CUA1 = null, 
			string m3CUA2 = null, 
			string m3CUA3 = null, 
			string m3CUA4 = null, 
			string m3PONO = null, 
			string m3DSTX = null, 
			string m3TOWN = null, 
			string m3PHNO = null, 
			string m3TFNO = null, 
			string m3YREF = null, 
			string m3MEAL = null, 
			string m3CSCD = null, 
			string m3VRNO = null, 
			string m3EDES = null, 
			string m3ROUT = null, 
			int? m3RODN = null, 
			string m3ULZO = null, 
			string m3ECF1 = null, 
			string m3ECF2 = null, 
			string m3ECF3 = null, 
			string m3ECF4 = null, 
			string m3ECF5 = null, 
			int? m3GEOC = null, 
			string m3TAXC = null, 
			string m3ECAR = null, 
			string m3HAFE = null, 
			string m3FRCO = null, 
			string m3SPLE = null, 
			string m3RASN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Chg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ADID))
				throw new ArgumentNullException(nameof(m3ADID));

			// Set mandatory parameters
			request
				.WithQueryParameter("ADID", m3ADID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNM))
				request.WithQueryParameter("CUNM", m3CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA1))
				request.WithQueryParameter("CUA1", m3CUA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA2))
				request.WithQueryParameter("CUA2", m3CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA3))
				request.WithQueryParameter("CUA3", m3CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA4))
				request.WithQueryParameter("CUA4", m3CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSTX))
				request.WithQueryParameter("DSTX", m3DSTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOWN))
				request.WithQueryParameter("TOWN", m3TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEAL))
				request.WithQueryParameter("MEAL", m3MEAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3VRNO))
				request.WithQueryParameter("VRNO", m3VRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDES))
				request.WithQueryParameter("EDES", m3EDES.Trim());
			if (!string.IsNullOrWhiteSpace(m3ROUT))
				request.WithQueryParameter("ROUT", m3ROUT.Trim());
			if (m3RODN.HasValue)
				request.WithQueryParameter("RODN", m3RODN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ULZO))
				request.WithQueryParameter("ULZO", m3ULZO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECF1))
				request.WithQueryParameter("ECF1", m3ECF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECF2))
				request.WithQueryParameter("ECF2", m3ECF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECF3))
				request.WithQueryParameter("ECF3", m3ECF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECF4))
				request.WithQueryParameter("ECF4", m3ECF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECF5))
				request.WithQueryParameter("ECF5", m3ECF5.Trim());
			if (m3GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3GEOC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TAXC))
				request.WithQueryParameter("TAXC", m3TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3HAFE))
				request.WithQueryParameter("HAFE", m3HAFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRCO))
				request.WithQueryParameter("FRCO", m3FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPLE))
				request.WithQueryParameter("SPLE", m3SPLE.Trim());
			if (!string.IsNullOrWhiteSpace(m3RASN))
				request.WithQueryParameter("RASN", m3RASN.Trim());

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
		/// Name Delete
		/// Description Delete a specific ad hoc address
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3ADID">Address number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3ADID, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Delete",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ADID))
				throw new ArgumentNullException(nameof(m3ADID));

			// Set mandatory parameters
			request
				.WithQueryParameter("ADID", m3ADID.Trim());

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
		/// Name Get
		/// Description Get specific ad hoc address
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3ADID">Address number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3ADID, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ADID))
				throw new ArgumentNullException(nameof(m3ADID));

			// Set mandatory parameters
			request
				.WithQueryParameter("ADID", m3ADID.Trim());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name LstByCustAddr
		/// Description LstByCustAddr
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3CUA1">Address line 1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByCustAddrResponse></returns>
		/// <exception cref="M3Exception<LstByCustAddrResponse>"></exception>
		public async Task<M3Response<LstByCustAddrResponse>> LstByCustAddr(
			string m3CUA1 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByCustAddr",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUA1))
				request.WithQueryParameter("CUA1", m3CUA1.Trim());

			// Execute the request
			var result = await Execute<LstByCustAddrResponse>(
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
		/// Name LstByCustName
		/// Description List By Customer Name
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3CUNM">Name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByCustNameResponse></returns>
		/// <exception cref="M3Exception<LstByCustNameResponse>"></exception>
		public async Task<M3Response<LstByCustNameResponse>> LstByCustName(
			string m3CUNM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByCustName",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNM))
				request.WithQueryParameter("CUNM", m3CUNM.Trim());

			// Execute the request
			var result = await Execute<LstByCustNameResponse>(
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
		/// Name LstByDelComment
		/// Description LstByDelComment
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3DSTX">Delivery comment</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByDelCommentResponse></returns>
		/// <exception cref="M3Exception<LstByDelCommentResponse>"></exception>
		public async Task<M3Response<LstByDelCommentResponse>> LstByDelComment(
			string m3DSTX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByDelComment",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DSTX))
				request.WithQueryParameter("DSTX", m3DSTX.Trim());

			// Execute the request
			var result = await Execute<LstByDelCommentResponse>(
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
