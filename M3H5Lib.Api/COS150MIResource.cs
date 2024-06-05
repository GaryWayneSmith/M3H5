/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add MCO Miscellaneous cost record
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_USID">User (Required)</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_MWNO">Work order number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_AMTY">Cost type</param>
		/// <param name="m3_TRQT">Quantity - basic U/M</param>
		/// <param name="m3_UNIT">Unit of measure</param>
		/// <param name="m3_ASP1">Sales price</param>
		/// <param name="m3_AWCO">WIP debit</param>
		/// <param name="m3_UPGL">Update General Ledger</param>
		/// <param name="m3_REMK">Remark</param>
		/// <param name="m3_MAUP">Manually updated</param>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="m3_TAIL">Registration number/site</param>
		/// <param name="m3_AIST">Transaction status</param>
		/// <param name="m3_CELE">Create operation element</param>
		/// <param name="m3_CMAT">Create misc material</param>
		/// <param name="m3_IORN">Interface order number</param>
		/// <param name="m3_IORL">Interface order line</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddResponse></returns>
		/// <exception cref="M3Exception<AddResponse>"></exception>
		public async Task<M3Response<AddResponse>> Add(
			string m3_USID, 
			string m3_ORNO = null, 
			int? m3_PONR = null, 
			string m3_MWNO = null, 
			int? m3_OPNO = null, 
			string m3_AMTY = null, 
			decimal? m3_TRQT = null, 
			string m3_UNIT = null, 
			decimal? m3_ASP1 = null, 
			decimal? m3_AWCO = null, 
			int? m3_UPGL = null, 
			string m3_REMK = null, 
			int? m3_MAUP = null, 
			string m3_EMNO = null, 
			string m3_TAIL = null, 
			string m3_AIST = null, 
			string m3_CELE = null, 
			string m3_CMAT = null, 
			string m3_IORN = null, 
			int? m3_IORL = null, 
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
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3_USID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MWNO))
				request.WithQueryParameter("MWNO", m3_MWNO.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AMTY))
				request.WithQueryParameter("AMTY", m3_AMTY.Trim());
			if (m3_TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3_TRQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNIT))
				request.WithQueryParameter("UNIT", m3_UNIT.Trim());
			if (m3_ASP1.HasValue)
				request.WithQueryParameter("ASP1", m3_ASP1.Value.ToString());
			if (m3_AWCO.HasValue)
				request.WithQueryParameter("AWCO", m3_AWCO.Value.ToString());
			if (m3_UPGL.HasValue)
				request.WithQueryParameter("UPGL", m3_UPGL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REMK))
				request.WithQueryParameter("REMK", m3_REMK.Trim());
			if (m3_MAUP.HasValue)
				request.WithQueryParameter("MAUP", m3_MAUP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAIL))
				request.WithQueryParameter("TAIL", m3_TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIST))
				request.WithQueryParameter("AIST", m3_AIST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CELE))
				request.WithQueryParameter("CELE", m3_CELE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CMAT))
				request.WithQueryParameter("CMAT", m3_CMAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IORN))
				request.WithQueryParameter("IORN", m3_IORN.Trim());
			if (m3_IORL.HasValue)
				request.WithQueryParameter("IORL", m3_IORL.Value.ToString());

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
		/// Name Approve
		/// Description Approve MCO Miscellaneous cost record
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_USID">User (Required)</param>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_OPNO">New field description</param>
		/// <param name="m3_TRNO">Transaction number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Approve(
			int m3_CONO, 
			string m3_USID, 
			string m3_MWNO, 
			int? m3_OPNO = null, 
			int? m3_TRNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Approve",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("USID", m3_USID.Trim())
				.WithQueryParameter("MWNO", m3_MWNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_TRNO.HasValue)
				request.WithQueryParameter("TRNO", m3_TRNO.Value.ToString());

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
		/// Description Delete MCO Miscellaneous cost record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_USID">User (Required)</param>
		/// <param name="m3_TRNO">Transaction number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3_USID, 
			int m3_TRNO, 
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
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3_USID.Trim())
				.WithQueryParameter("TRNO", m3_TRNO.ToString());

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
		/// Name DeleteByMSEQ
		/// Description Delete MCO Miscellaneous cost record
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_MSEQ">Sequence number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteByMSEQ(
			string m3_MWNO, 
			int m3_OPNO, 
			int m3_MSEQ, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeleteByMSEQ",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString())
				.WithQueryParameter("MSEQ", m3_MSEQ.ToString());

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
		/// Description Get MCO Miscellaneous cost record
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_USID">User (Required)</param>
		/// <param name="m3_TRNO">Transaction number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_USID, 
			int m3_TRNO, 
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
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3_USID.Trim())
				.WithQueryParameter("TRNO", m3_TRNO.ToString());

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
		/// Name List
		/// Description List MCO Miscellaneous cost records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_USID">User</param>
		/// <param name="m3_TRNO">Transaction number</param>
		/// <param name="m3_LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3_USID = null, 
			int? m3_TRNO = null, 
			decimal? m3_LMTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/List",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());
			if (m3_TRNO.HasValue)
				request.WithQueryParameter("TRNO", m3_TRNO.Value.ToString());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<ListResponse>(
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
		/// Name ListMisc
		/// Description List Micselleanous cost items
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListMiscResponse></returns>
		/// <exception cref="M3Exception<ListMiscResponse>"></exception>
		public async Task<M3Response<ListMiscResponse>> ListMisc(
			string m3_MWNO, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			int? m3_OPNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ListMisc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());

			// Execute the request
			var result = await Execute<ListMiscResponse>(
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
		/// Name LstOperElement
		/// Description List Operation Elements
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOperElementResponse></returns>
		/// <exception cref="M3Exception<LstOperElementResponse>"></exception>
		public async Task<M3Response<LstOperElementResponse>> LstOperElement(
			string m3_MWNO, 
			int m3_OPNO, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstOperElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());

			// Execute the request
			var result = await Execute<LstOperElementResponse>(
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
		/// Name Transfer
		/// Description Transfer MCO Miscellaneous cost records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_USID">User (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Transfer(
			string m3_USID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Transfer",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3_USID.Trim());

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
		/// Name TransferByOPNO
		/// Description Transfer MCO Miscellaneous cost record
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> TransferByOPNO(
			string m3_MWNO, 
			int m3_OPNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/TransferByOPNO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString());

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
		/// Name Upd
		/// Description Add MCO Miscellaneous cost record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_USID">User (Required)</param>
		/// <param name="m3_TRNO">Transaction number (Required)</param>
		/// <param name="m3_AMTY">Miscellaneous cost types</param>
		/// <param name="m3_TRQT">Transaction quantity - basic U/M</param>
		/// <param name="m3_UNIT">Unit of measure</param>
		/// <param name="m3_ASP1">Sales price</param>
		/// <param name="m3_AWCO">WIP debit</param>
		/// <param name="m3_UPGL">Update General Ledger</param>
		/// <param name="m3_REMK">Remark</param>
		/// <param name="m3_MAUP">Manually updated</param>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="m3_TAIL">Registration number/site</param>
		/// <param name="m3_AIST">Transaction status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3_USID, 
			int m3_TRNO, 
			string m3_AMTY = null, 
			decimal? m3_TRQT = null, 
			string m3_UNIT = null, 
			decimal? m3_ASP1 = null, 
			decimal? m3_AWCO = null, 
			int? m3_UPGL = null, 
			string m3_REMK = null, 
			int? m3_MAUP = null, 
			string m3_EMNO = null, 
			string m3_TAIL = null, 
			string m3_AIST = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Upd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3_USID.Trim())
				.WithQueryParameter("TRNO", m3_TRNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_AMTY))
				request.WithQueryParameter("AMTY", m3_AMTY.Trim());
			if (m3_TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3_TRQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNIT))
				request.WithQueryParameter("UNIT", m3_UNIT.Trim());
			if (m3_ASP1.HasValue)
				request.WithQueryParameter("ASP1", m3_ASP1.Value.ToString());
			if (m3_AWCO.HasValue)
				request.WithQueryParameter("AWCO", m3_AWCO.Value.ToString());
			if (m3_UPGL.HasValue)
				request.WithQueryParameter("UPGL", m3_UPGL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REMK))
				request.WithQueryParameter("REMK", m3_REMK.Trim());
			if (m3_MAUP.HasValue)
				request.WithQueryParameter("MAUP", m3_MAUP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAIL))
				request.WithQueryParameter("TAIL", m3_TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIST))
				request.WithQueryParameter("AIST", m3_AIST.Trim());

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
		/// Name UpdByMSEQ
		/// Description Update MCO Miscellaneous cost record
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_MSEQ">Sequence number (Required)</param>
		/// <param name="m3_USID">User (Required)</param>
		/// <param name="m3_AMTY">Miscellaneous cost types</param>
		/// <param name="m3_TRQT">Transaction quantity - basic U/M</param>
		/// <param name="m3_UNIT">Unit of measure</param>
		/// <param name="m3_ASP1">Sales price</param>
		/// <param name="m3_AWCO">WIP debit</param>
		/// <param name="m3_UPGL">Update General Ledger</param>
		/// <param name="m3_REMK">Remark</param>
		/// <param name="m3_MAUP">Manually updated</param>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="m3_TAIL">Registration number/site</param>
		/// <param name="m3_AIST">Transaction status</param>
		/// <param name="m3_TRNO">Transaction number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdByMSEQ(
			string m3_MWNO, 
			int m3_OPNO, 
			int m3_MSEQ, 
			string m3_USID, 
			string m3_AMTY = null, 
			decimal? m3_TRQT = null, 
			string m3_UNIT = null, 
			decimal? m3_ASP1 = null, 
			decimal? m3_AWCO = null, 
			int? m3_UPGL = null, 
			string m3_REMK = null, 
			int? m3_MAUP = null, 
			string m3_EMNO = null, 
			string m3_TAIL = null, 
			string m3_AIST = null, 
			int? m3_TRNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdByMSEQ",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString())
				.WithQueryParameter("MSEQ", m3_MSEQ.ToString())
				.WithQueryParameter("USID", m3_USID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_AMTY))
				request.WithQueryParameter("AMTY", m3_AMTY.Trim());
			if (m3_TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3_TRQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNIT))
				request.WithQueryParameter("UNIT", m3_UNIT.Trim());
			if (m3_ASP1.HasValue)
				request.WithQueryParameter("ASP1", m3_ASP1.Value.ToString());
			if (m3_AWCO.HasValue)
				request.WithQueryParameter("AWCO", m3_AWCO.Value.ToString());
			if (m3_UPGL.HasValue)
				request.WithQueryParameter("UPGL", m3_UPGL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REMK))
				request.WithQueryParameter("REMK", m3_REMK.Trim());
			if (m3_MAUP.HasValue)
				request.WithQueryParameter("MAUP", m3_MAUP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAIL))
				request.WithQueryParameter("TAIL", m3_TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIST))
				request.WithQueryParameter("AIST", m3_AIST.Trim());
			if (m3_TRNO.HasValue)
				request.WithQueryParameter("TRNO", m3_TRNO.Value.ToString());

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
