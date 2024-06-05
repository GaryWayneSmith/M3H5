/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PDS003MI;
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
	/// Name: PDS003MI
	/// Component Name: ConnectFeatureAndOptions
	/// Description: Connect feature and options interface
	/// Version Release: 14.x
	///</summary>
	public partial class PDS003MIResource : M3BaseResourceEndpoint
	{
		public PDS003MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PDS003MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_MTNO">Component number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_OTYP">Selection type</param>
		/// <param name="m3_FTID">Feature</param>
		/// <param name="m3_OPTN">Option</param>
		/// <param name="m3_INCE">Include/exclude product structure line</param>
		/// <param name="m3_NUVT">To numeric range value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_FDAT = null, 
			int? m3_MSEQ = null, 
			string m3_MTNO = null, 
			int? m3_OPNO = null, 
			string m3_PLGR = null, 
			string m3_OTYP = null, 
			string m3_FTID = null, 
			string m3_OPTN = null, 
			string m3_INCE = null, 
			decimal? m3_NUVT = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToString());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MTNO))
				request.WithQueryParameter("MTNO", m3_MTNO.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OTYP))
				request.WithQueryParameter("OTYP", m3_OTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FTID))
				request.WithQueryParameter("FTID", m3_FTID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTN))
				request.WithQueryParameter("OPTN", m3_OPTN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INCE))
				request.WithQueryParameter("INCE", m3_INCE.Trim());
			if (m3_NUVT.HasValue)
				request.WithQueryParameter("NUVT", m3_NUVT.Value.ToString());

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
		/// Name Copy
		/// Description Copy
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_MTNO">Component number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_OTYP">Selection type</param>
		/// <param name="m3_FTID">Feature</param>
		/// <param name="m3_OPTN">Option</param>
		/// <param name="m3_CFTI">Feature</param>
		/// <param name="m3_COPT">Option</param>
		/// <param name="m3_INCE">Include/exclude product structure line</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Copy(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_FDAT = null, 
			int? m3_MSEQ = null, 
			string m3_MTNO = null, 
			int? m3_OPNO = null, 
			string m3_PLGR = null, 
			string m3_OTYP = null, 
			string m3_FTID = null, 
			string m3_OPTN = null, 
			string m3_CFTI = null, 
			string m3_COPT = null, 
			string m3_INCE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Copy",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToString());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MTNO))
				request.WithQueryParameter("MTNO", m3_MTNO.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OTYP))
				request.WithQueryParameter("OTYP", m3_OTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FTID))
				request.WithQueryParameter("FTID", m3_FTID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTN))
				request.WithQueryParameter("OPTN", m3_OPTN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFTI))
				request.WithQueryParameter("CFTI", m3_CFTI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COPT))
				request.WithQueryParameter("COPT", m3_COPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INCE))
				request.WithQueryParameter("INCE", m3_INCE.Trim());

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
		/// Description Delete
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_MTNO">Component number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_OTYP">Selection type</param>
		/// <param name="m3_FTID">Feature</param>
		/// <param name="m3_OPTN">Option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_FDAT = null, 
			int? m3_MSEQ = null, 
			string m3_MTNO = null, 
			int? m3_OPNO = null, 
			string m3_PLGR = null, 
			string m3_OTYP = null, 
			string m3_FTID = null, 
			string m3_OPTN = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToString());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MTNO))
				request.WithQueryParameter("MTNO", m3_MTNO.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OTYP))
				request.WithQueryParameter("OTYP", m3_OTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FTID))
				request.WithQueryParameter("FTID", m3_FTID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTN))
				request.WithQueryParameter("OPTN", m3_OPTN.Trim());

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
		/// Description Get
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_MTNO">Component number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_OTYP">Selection type</param>
		/// <param name="m3_FTID">Feature</param>
		/// <param name="m3_OPTN">Option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_FDAT = null, 
			int? m3_MSEQ = null, 
			string m3_MTNO = null, 
			int? m3_OPNO = null, 
			string m3_PLGR = null, 
			string m3_OTYP = null, 
			string m3_FTID = null, 
			string m3_OPTN = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToString());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MTNO))
				request.WithQueryParameter("MTNO", m3_MTNO.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OTYP))
				request.WithQueryParameter("OTYP", m3_OTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FTID))
				request.WithQueryParameter("FTID", m3_FTID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTN))
				request.WithQueryParameter("OPTN", m3_OPTN.Trim());

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
		/// Description List
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_MTNO">Component number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_OTYP">Selection type</param>
		/// <param name="m3_FTID">Feature</param>
		/// <param name="m3_OPTN">Option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_FDAT = null, 
			int? m3_MSEQ = null, 
			string m3_MTNO = null, 
			int? m3_OPNO = null, 
			string m3_PLGR = null, 
			string m3_OTYP = null, 
			string m3_FTID = null, 
			string m3_OPTN = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToString());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MTNO))
				request.WithQueryParameter("MTNO", m3_MTNO.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OTYP))
				request.WithQueryParameter("OTYP", m3_OTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FTID))
				request.WithQueryParameter("FTID", m3_FTID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTN))
				request.WithQueryParameter("OPTN", m3_OPTN.Trim());

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
		/// Name Update
		/// Description Update
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_MTNO">Component number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_OTYP">Selection type</param>
		/// <param name="m3_FTID">Feature</param>
		/// <param name="m3_OPTN">Option</param>
		/// <param name="m3_INCE">Include/exclude product structure line</param>
		/// <param name="m3_NUVT">To numeric range value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Update(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_FDAT = null, 
			int? m3_MSEQ = null, 
			string m3_MTNO = null, 
			int? m3_OPNO = null, 
			string m3_PLGR = null, 
			string m3_OTYP = null, 
			string m3_FTID = null, 
			string m3_OPTN = null, 
			string m3_INCE = null, 
			decimal? m3_NUVT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Update",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToString());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MTNO))
				request.WithQueryParameter("MTNO", m3_MTNO.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OTYP))
				request.WithQueryParameter("OTYP", m3_OTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FTID))
				request.WithQueryParameter("FTID", m3_FTID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTN))
				request.WithQueryParameter("OPTN", m3_OPTN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INCE))
				request.WithQueryParameter("INCE", m3_INCE.Trim());
			if (m3_NUVT.HasValue)
				request.WithQueryParameter("NUVT", m3_NUVT.Value.ToString());

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
