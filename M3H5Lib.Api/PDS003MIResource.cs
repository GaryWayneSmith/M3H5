/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3MTNO">Component number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3OTYP">Selection type</param>
		/// <param name="m3FTID">Feature</param>
		/// <param name="m3OPTN">Option</param>
		/// <param name="m3INCE">Include/exclude product structure line</param>
		/// <param name="m3NUVT">To numeric range value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3FDAT = null, 
			int? m3MSEQ = null, 
			string m3MTNO = null, 
			int? m3OPNO = null, 
			string m3PLGR = null, 
			string m3OTYP = null, 
			string m3FTID = null, 
			string m3OPTN = null, 
			string m3INCE = null, 
			decimal? m3NUVT = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MTNO))
				request.WithQueryParameter("MTNO", m3MTNO.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3OTYP))
				request.WithQueryParameter("OTYP", m3OTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FTID))
				request.WithQueryParameter("FTID", m3FTID.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTN))
				request.WithQueryParameter("OPTN", m3OPTN.Trim());
			if (!string.IsNullOrWhiteSpace(m3INCE))
				request.WithQueryParameter("INCE", m3INCE.Trim());
			if (m3NUVT.HasValue)
				request.WithQueryParameter("NUVT", m3NUVT.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Copy
		/// Description Copy
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3MTNO">Component number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3OTYP">Selection type</param>
		/// <param name="m3FTID">Feature</param>
		/// <param name="m3OPTN">Option</param>
		/// <param name="m3CFTI">Feature</param>
		/// <param name="m3COPT">Option</param>
		/// <param name="m3INCE">Include/exclude product structure line</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Copy(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3FDAT = null, 
			int? m3MSEQ = null, 
			string m3MTNO = null, 
			int? m3OPNO = null, 
			string m3PLGR = null, 
			string m3OTYP = null, 
			string m3FTID = null, 
			string m3OPTN = null, 
			string m3CFTI = null, 
			string m3COPT = null, 
			string m3INCE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Copy",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MTNO))
				request.WithQueryParameter("MTNO", m3MTNO.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3OTYP))
				request.WithQueryParameter("OTYP", m3OTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FTID))
				request.WithQueryParameter("FTID", m3FTID.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTN))
				request.WithQueryParameter("OPTN", m3OPTN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFTI))
				request.WithQueryParameter("CFTI", m3CFTI.Trim());
			if (!string.IsNullOrWhiteSpace(m3COPT))
				request.WithQueryParameter("COPT", m3COPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3INCE))
				request.WithQueryParameter("INCE", m3INCE.Trim());

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
		/// Description Delete
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3MTNO">Component number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3OTYP">Selection type</param>
		/// <param name="m3FTID">Feature</param>
		/// <param name="m3OPTN">Option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3FDAT = null, 
			int? m3MSEQ = null, 
			string m3MTNO = null, 
			int? m3OPNO = null, 
			string m3PLGR = null, 
			string m3OTYP = null, 
			string m3FTID = null, 
			string m3OPTN = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MTNO))
				request.WithQueryParameter("MTNO", m3MTNO.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3OTYP))
				request.WithQueryParameter("OTYP", m3OTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FTID))
				request.WithQueryParameter("FTID", m3FTID.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTN))
				request.WithQueryParameter("OPTN", m3OPTN.Trim());

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
		/// Description Get
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3MTNO">Component number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3OTYP">Selection type</param>
		/// <param name="m3FTID">Feature</param>
		/// <param name="m3OPTN">Option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3FDAT = null, 
			int? m3MSEQ = null, 
			string m3MTNO = null, 
			int? m3OPNO = null, 
			string m3PLGR = null, 
			string m3OTYP = null, 
			string m3FTID = null, 
			string m3OPTN = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MTNO))
				request.WithQueryParameter("MTNO", m3MTNO.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3OTYP))
				request.WithQueryParameter("OTYP", m3OTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FTID))
				request.WithQueryParameter("FTID", m3FTID.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTN))
				request.WithQueryParameter("OPTN", m3OPTN.Trim());

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
		/// Description List
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3MTNO">Component number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3OTYP">Selection type</param>
		/// <param name="m3FTID">Feature</param>
		/// <param name="m3OPTN">Option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3FDAT = null, 
			int? m3MSEQ = null, 
			string m3MTNO = null, 
			int? m3OPNO = null, 
			string m3PLGR = null, 
			string m3OTYP = null, 
			string m3FTID = null, 
			string m3OPTN = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MTNO))
				request.WithQueryParameter("MTNO", m3MTNO.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3OTYP))
				request.WithQueryParameter("OTYP", m3OTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FTID))
				request.WithQueryParameter("FTID", m3FTID.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTN))
				request.WithQueryParameter("OPTN", m3OPTN.Trim());

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
		/// Name Update
		/// Description Update
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3MTNO">Component number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3OTYP">Selection type</param>
		/// <param name="m3FTID">Feature</param>
		/// <param name="m3OPTN">Option</param>
		/// <param name="m3INCE">Include/exclude product structure line</param>
		/// <param name="m3NUVT">To numeric range value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Update(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3FDAT = null, 
			int? m3MSEQ = null, 
			string m3MTNO = null, 
			int? m3OPNO = null, 
			string m3PLGR = null, 
			string m3OTYP = null, 
			string m3FTID = null, 
			string m3OPTN = null, 
			string m3INCE = null, 
			decimal? m3NUVT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Update",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MTNO))
				request.WithQueryParameter("MTNO", m3MTNO.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3OTYP))
				request.WithQueryParameter("OTYP", m3OTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FTID))
				request.WithQueryParameter("FTID", m3FTID.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTN))
				request.WithQueryParameter("OPTN", m3OPTN.Trim());
			if (!string.IsNullOrWhiteSpace(m3INCE))
				request.WithQueryParameter("INCE", m3INCE.Trim());
			if (m3NUVT.HasValue)
				request.WithQueryParameter("NUVT", m3NUVT.Value.ToString(CultureInfo.CurrentCulture));

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
