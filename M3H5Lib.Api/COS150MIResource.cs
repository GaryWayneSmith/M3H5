/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.COS150MI;
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
	/// Name: COS150MI
	/// Component Name: MCOMiscCost
	/// Description: Api; MCO Miscellaneous cost
	/// Version Release: 5ea1
	///</summary>
	public partial class COS150MIResource : M3BaseResourceEndpoint
	{
		public COS150MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "COS150MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add MCO Miscellaneous cost record
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3USID">User (Required)</param>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3MWNO">Work order number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3AMTY">Cost type</param>
		/// <param name="m3TRQT">Quantity - basic U/M</param>
		/// <param name="m3UNIT">Unit of measure</param>
		/// <param name="m3ASP1">Sales price</param>
		/// <param name="m3AWCO">WIP debit</param>
		/// <param name="m3UPGL">Update General Ledger</param>
		/// <param name="m3REMK">Remark</param>
		/// <param name="m3MAUP">Manually updated</param>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3TAIL">Registration number/site</param>
		/// <param name="m3AIST">Transaction status</param>
		/// <param name="m3CELE">Create operation element</param>
		/// <param name="m3CMAT">Create misc material</param>
		/// <param name="m3IORN">Interface order number</param>
		/// <param name="m3IORL">Interface order line</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddResponse></returns>
		/// <exception cref="M3Exception<AddResponse>"></exception>
		public async Task<M3Response<AddResponse>> Add(
			string m3USID, 
			string m3ORNO = null, 
			int? m3PONR = null, 
			string m3MWNO = null, 
			int? m3OPNO = null, 
			string m3AMTY = null, 
			decimal? m3TRQT = null, 
			string m3UNIT = null, 
			decimal? m3ASP1 = null, 
			decimal? m3AWCO = null, 
			int? m3UPGL = null, 
			string m3REMK = null, 
			int? m3MAUP = null, 
			string m3EMNO = null, 
			string m3TAIL = null, 
			string m3AIST = null, 
			string m3CELE = null, 
			string m3CMAT = null, 
			string m3IORN = null, 
			int? m3IORL = null, 
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

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3USID))
				throw new ArgumentNullException(nameof(m3USID));

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3USID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MWNO))
				request.WithQueryParameter("MWNO", m3MWNO.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AMTY))
				request.WithQueryParameter("AMTY", m3AMTY.Trim());
			if (m3TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3TRQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3UNIT))
				request.WithQueryParameter("UNIT", m3UNIT.Trim());
			if (m3ASP1.HasValue)
				request.WithQueryParameter("ASP1", m3ASP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AWCO.HasValue)
				request.WithQueryParameter("AWCO", m3AWCO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UPGL.HasValue)
				request.WithQueryParameter("UPGL", m3UPGL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REMK))
				request.WithQueryParameter("REMK", m3REMK.Trim());
			if (m3MAUP.HasValue)
				request.WithQueryParameter("MAUP", m3MAUP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAIL))
				request.WithQueryParameter("TAIL", m3TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIST))
				request.WithQueryParameter("AIST", m3AIST.Trim());
			if (!string.IsNullOrWhiteSpace(m3CELE))
				request.WithQueryParameter("CELE", m3CELE.Trim());
			if (!string.IsNullOrWhiteSpace(m3CMAT))
				request.WithQueryParameter("CMAT", m3CMAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3IORN))
				request.WithQueryParameter("IORN", m3IORN.Trim());
			if (m3IORL.HasValue)
				request.WithQueryParameter("IORL", m3IORL.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Approve
		/// Description Approve MCO Miscellaneous cost record
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3USID">User (Required)</param>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3OPNO">New field description</param>
		/// <param name="m3TRNO">Transaction number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Approve(
			int m3CONO, 
			string m3USID, 
			string m3MWNO, 
			int? m3OPNO = null, 
			int? m3TRNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Approve",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3USID))
				throw new ArgumentNullException(nameof(m3USID));
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("USID", m3USID.Trim())
				.WithQueryParameter("MWNO", m3MWNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRNO.HasValue)
				request.WithQueryParameter("TRNO", m3TRNO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Description Delete MCO Miscellaneous cost record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3USID">User (Required)</param>
		/// <param name="m3TRNO">Transaction number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3USID, 
			int m3TRNO, 
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
			if (string.IsNullOrWhiteSpace(m3USID))
				throw new ArgumentNullException(nameof(m3USID));

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3USID.Trim())
				.WithQueryParameter("TRNO", m3TRNO.ToString(CultureInfo.CurrentCulture));

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
		/// Name DeleteByMSEQ
		/// Description Delete MCO Miscellaneous cost record
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3MSEQ">Sequence number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteByMSEQ(
			string m3MWNO, 
			int m3OPNO, 
			int m3MSEQ, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DeleteByMSEQ",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("MSEQ", m3MSEQ.ToString(CultureInfo.CurrentCulture));

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
		/// Description Get MCO Miscellaneous cost record
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3USID">User (Required)</param>
		/// <param name="m3TRNO">Transaction number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3USID, 
			int m3TRNO, 
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
			if (string.IsNullOrWhiteSpace(m3USID))
				throw new ArgumentNullException(nameof(m3USID));

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3USID.Trim())
				.WithQueryParameter("TRNO", m3TRNO.ToString(CultureInfo.CurrentCulture));

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
		/// Name List
		/// Description List MCO Miscellaneous cost records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3USID">User</param>
		/// <param name="m3TRNO">Transaction number</param>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3USID = null, 
			int? m3TRNO = null, 
			decimal? m3LMTS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/List",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());
			if (m3TRNO.HasValue)
				request.WithQueryParameter("TRNO", m3TRNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ListResponse>(
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
		/// Name ListMisc
		/// Description List Micselleanous cost items
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListMiscResponse></returns>
		/// <exception cref="M3Exception<ListMiscResponse>"></exception>
		public async Task<M3Response<ListMiscResponse>> ListMisc(
			string m3MWNO, 
			string m3FACI = null, 
			string m3PRNO = null, 
			int? m3OPNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ListMisc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ListMiscResponse>(
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
		/// Name LstOperElement
		/// Description List Operation Elements
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOperElementResponse></returns>
		/// <exception cref="M3Exception<LstOperElementResponse>"></exception>
		public async Task<M3Response<LstOperElementResponse>> LstOperElement(
			string m3MWNO, 
			int m3OPNO, 
			string m3FACI = null, 
			string m3PRNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstOperElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());

			// Execute the request
			var result = await Execute<LstOperElementResponse>(
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
		/// Name Transfer
		/// Description Transfer MCO Miscellaneous cost records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3USID">User (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Transfer(
			string m3USID, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Transfer",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3USID))
				throw new ArgumentNullException(nameof(m3USID));

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3USID.Trim());

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
		/// Name TransferByOPNO
		/// Description Transfer MCO Miscellaneous cost record
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> TransferByOPNO(
			string m3MWNO, 
			int m3OPNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/TransferByOPNO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

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
		/// Name Upd
		/// Description Add MCO Miscellaneous cost record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3USID">User (Required)</param>
		/// <param name="m3TRNO">Transaction number (Required)</param>
		/// <param name="m3AMTY">Miscellaneous cost types</param>
		/// <param name="m3TRQT">Transaction quantity - basic U/M</param>
		/// <param name="m3UNIT">Unit of measure</param>
		/// <param name="m3ASP1">Sales price</param>
		/// <param name="m3AWCO">WIP debit</param>
		/// <param name="m3UPGL">Update General Ledger</param>
		/// <param name="m3REMK">Remark</param>
		/// <param name="m3MAUP">Manually updated</param>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3TAIL">Registration number/site</param>
		/// <param name="m3AIST">Transaction status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3USID, 
			int m3TRNO, 
			string m3AMTY = null, 
			decimal? m3TRQT = null, 
			string m3UNIT = null, 
			decimal? m3ASP1 = null, 
			decimal? m3AWCO = null, 
			int? m3UPGL = null, 
			string m3REMK = null, 
			int? m3MAUP = null, 
			string m3EMNO = null, 
			string m3TAIL = null, 
			string m3AIST = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Upd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3USID))
				throw new ArgumentNullException(nameof(m3USID));

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3USID.Trim())
				.WithQueryParameter("TRNO", m3TRNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AMTY))
				request.WithQueryParameter("AMTY", m3AMTY.Trim());
			if (m3TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3TRQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3UNIT))
				request.WithQueryParameter("UNIT", m3UNIT.Trim());
			if (m3ASP1.HasValue)
				request.WithQueryParameter("ASP1", m3ASP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AWCO.HasValue)
				request.WithQueryParameter("AWCO", m3AWCO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UPGL.HasValue)
				request.WithQueryParameter("UPGL", m3UPGL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REMK))
				request.WithQueryParameter("REMK", m3REMK.Trim());
			if (m3MAUP.HasValue)
				request.WithQueryParameter("MAUP", m3MAUP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAIL))
				request.WithQueryParameter("TAIL", m3TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIST))
				request.WithQueryParameter("AIST", m3AIST.Trim());

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
		/// Name UpdByMSEQ
		/// Description Update MCO Miscellaneous cost record
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3MSEQ">Sequence number (Required)</param>
		/// <param name="m3USID">User (Required)</param>
		/// <param name="m3AMTY">Miscellaneous cost types</param>
		/// <param name="m3TRQT">Transaction quantity - basic U/M</param>
		/// <param name="m3UNIT">Unit of measure</param>
		/// <param name="m3ASP1">Sales price</param>
		/// <param name="m3AWCO">WIP debit</param>
		/// <param name="m3UPGL">Update General Ledger</param>
		/// <param name="m3REMK">Remark</param>
		/// <param name="m3MAUP">Manually updated</param>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3TAIL">Registration number/site</param>
		/// <param name="m3AIST">Transaction status</param>
		/// <param name="m3TRNO">Transaction number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdByMSEQ(
			string m3MWNO, 
			int m3OPNO, 
			int m3MSEQ, 
			string m3USID, 
			string m3AMTY = null, 
			decimal? m3TRQT = null, 
			string m3UNIT = null, 
			decimal? m3ASP1 = null, 
			decimal? m3AWCO = null, 
			int? m3UPGL = null, 
			string m3REMK = null, 
			int? m3MAUP = null, 
			string m3EMNO = null, 
			string m3TAIL = null, 
			string m3AIST = null, 
			int? m3TRNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdByMSEQ",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));
			if (string.IsNullOrWhiteSpace(m3USID))
				throw new ArgumentNullException(nameof(m3USID));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("MSEQ", m3MSEQ.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("USID", m3USID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AMTY))
				request.WithQueryParameter("AMTY", m3AMTY.Trim());
			if (m3TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3TRQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3UNIT))
				request.WithQueryParameter("UNIT", m3UNIT.Trim());
			if (m3ASP1.HasValue)
				request.WithQueryParameter("ASP1", m3ASP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AWCO.HasValue)
				request.WithQueryParameter("AWCO", m3AWCO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UPGL.HasValue)
				request.WithQueryParameter("UPGL", m3UPGL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REMK))
				request.WithQueryParameter("REMK", m3REMK.Trim());
			if (m3MAUP.HasValue)
				request.WithQueryParameter("MAUP", m3MAUP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAIL))
				request.WithQueryParameter("TAIL", m3TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIST))
				request.WithQueryParameter("AIST", m3AIST.Trim());
			if (m3TRNO.HasValue)
				request.WithQueryParameter("TRNO", m3TRNO.Value.ToString(CultureInfo.CurrentCulture));

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
