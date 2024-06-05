/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS020MI;
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
	/// Name: CRS020MI
	/// Component Name: CRS020MI
	/// Description: Panel version interface
	/// Version Release: 5ea0
	///</summary>
	public partial class CRS020MIResource : M3BaseResourceEndpoint
	{
		public CRS020MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS020MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name DelPanelVersion
		/// Description Delete a Panel version record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PGNM">Program name (Required)</param>
		/// <param name="m3_PAVR">Panel version (Required)</param>
		/// <param name="m3_PIC1">Panel (Required)</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_IBCA">Information browser category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelPanelVersion(
			string m3_PGNM, 
			string m3_PAVR, 
			string m3_PIC1, 
			string m3_RESP = null, 
			string m3_IBCA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelPanelVersion",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");
			if (string.IsNullOrWhiteSpace(m3_PAVR))
				throw new ArgumentNullException("m3_PAVR");
			if (string.IsNullOrWhiteSpace(m3_PIC1))
				throw new ArgumentNullException("m3_PIC1");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim())
				.WithQueryParameter("PAVR", m3_PAVR.Trim())
				.WithQueryParameter("PIC1", m3_PIC1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IBCA))
				request.WithQueryParameter("IBCA", m3_IBCA.Trim());

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
		/// Name GetFldColParm
		/// Description Get field column parameters
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PGNM">Program name (Required)</param>
		/// <param name="m3_PIC1">Panel (Required)</param>
		/// <param name="m3_IBCA">Information browser category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFldColParmResponse></returns>
		/// <exception cref="M3Exception<GetFldColParmResponse>"></exception>
		public async Task<M3Response<GetFldColParmResponse>> GetFldColParm(
			string m3_PGNM, 
			string m3_PIC1, 
			string m3_IBCA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetFldColParm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");
			if (string.IsNullOrWhiteSpace(m3_PIC1))
				throw new ArgumentNullException("m3_PIC1");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim())
				.WithQueryParameter("PIC1", m3_PIC1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_IBCA))
				request.WithQueryParameter("IBCA", m3_IBCA.Trim());

			// Execute the request
			var result = await Execute<GetFldColParmResponse>(
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
		/// Name LstAllColumns
		/// Description List all columns for existing panel version
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PGNM">Program name (Required)</param>
		/// <param name="m3_PAVR">Panel version (Required)</param>
		/// <param name="m3_PIC1">Panel (Required)</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_IBCA">Information browser category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAllColumnsResponse></returns>
		/// <exception cref="M3Exception<LstAllColumnsResponse>"></exception>
		public async Task<M3Response<LstAllColumnsResponse>> LstAllColumns(
			string m3_PGNM, 
			string m3_PAVR, 
			string m3_PIC1, 
			string m3_RESP = null, 
			string m3_IBCA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAllColumns",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");
			if (string.IsNullOrWhiteSpace(m3_PAVR))
				throw new ArgumentNullException("m3_PAVR");
			if (string.IsNullOrWhiteSpace(m3_PIC1))
				throw new ArgumentNullException("m3_PIC1");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim())
				.WithQueryParameter("PAVR", m3_PAVR.Trim())
				.WithQueryParameter("PIC1", m3_PIC1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IBCA))
				request.WithQueryParameter("IBCA", m3_IBCA.Trim());

			// Execute the request
			var result = await Execute<LstAllColumnsResponse>(
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
		/// Name LstAllFields
		/// Description List all possible fields for panelversion
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PGNM">Program name (Required)</param>
		/// <param name="m3_IBCA">Information browser category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAllFieldsResponse></returns>
		/// <exception cref="M3Exception<LstAllFieldsResponse>"></exception>
		public async Task<M3Response<LstAllFieldsResponse>> LstAllFields(
			string m3_PGNM, 
			string m3_IBCA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAllFields",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_IBCA))
				request.WithQueryParameter("IBCA", m3_IBCA.Trim());

			// Execute the request
			var result = await Execute<LstAllFieldsResponse>(
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
		/// Name LstMandatoryFld
		/// Description List All Mandatory Fields for panelversion view
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PGNM">Program name (Required)</param>
		/// <param name="m3_PIC1">Panel (Required)</param>
		/// <param name="m3_QTTP">Inquiry type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMandatoryFldResponse></returns>
		/// <exception cref="M3Exception<LstMandatoryFldResponse>"></exception>
		public async Task<M3Response<LstMandatoryFldResponse>> LstMandatoryFld(
			string m3_PGNM, 
			string m3_PIC1, 
			int m3_QTTP, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMandatoryFld",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");
			if (string.IsNullOrWhiteSpace(m3_PIC1))
				throw new ArgumentNullException("m3_PIC1");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim())
				.WithQueryParameter("PIC1", m3_PIC1.Trim())
				.WithQueryParameter("QTTP", m3_QTTP.ToString());

			// Execute the request
			var result = await Execute<LstMandatoryFldResponse>(
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
		/// Name LstSortingSeq
		/// Description List Sorting sequence for panelversion view
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PGNM">Program name (Required)</param>
		/// <param name="m3_PIC1">Panel (Required)</param>
		/// <param name="m3_QTTP">Inquiry type (Required)</param>
		/// <param name="m3_IBCA">Information browser category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSortingSeqResponse></returns>
		/// <exception cref="M3Exception<LstSortingSeqResponse>"></exception>
		public async Task<M3Response<LstSortingSeqResponse>> LstSortingSeq(
			string m3_PGNM, 
			string m3_PIC1, 
			int m3_QTTP, 
			string m3_IBCA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSortingSeq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");
			if (string.IsNullOrWhiteSpace(m3_PIC1))
				throw new ArgumentNullException("m3_PIC1");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim())
				.WithQueryParameter("PIC1", m3_PIC1.Trim())
				.WithQueryParameter("QTTP", m3_QTTP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_IBCA))
				request.WithQueryParameter("IBCA", m3_IBCA.Trim());

			// Execute the request
			var result = await Execute<LstSortingSeqResponse>(
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
		/// Name LstViews
		/// Description List views in sorting order
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PGNM">Program name (Required)</param>
		/// <param name="m3_IBCA">Information browser category</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_QTTP">Sorting order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstViewsResponse></returns>
		/// <exception cref="M3Exception<LstViewsResponse>"></exception>
		public async Task<M3Response<LstViewsResponse>> LstViews(
			string m3_PGNM, 
			string m3_IBCA = null, 
			string m3_RESP = null, 
			int? m3_QTTP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstViews",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_IBCA))
				request.WithQueryParameter("IBCA", m3_IBCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_QTTP.HasValue)
				request.WithQueryParameter("QTTP", m3_QTTP.Value.ToString());

			// Execute the request
			var result = await Execute<LstViewsResponse>(
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
		/// Name UpdPanelVerCol
		/// Description Update Panel version column
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PGNM">Program name (Required)</param>
		/// <param name="m3_PIC1">Panel (Required)</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_PAVR">Panel version</param>
		/// <param name="m3_QTTP">Inquiry type</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_COID">Column number</param>
		/// <param name="m3_FLDI">Field</param>
		/// <param name="m3_FLTY">Field type</param>
		/// <param name="m3_MSID">Message ID</param>
		/// <param name="m3_FLDL">Field length</param>
		/// <param name="m3_FLLU">Field length user value</param>
		/// <param name="m3_FNDC">Number of decimals</param>
		/// <param name="m3_UNDC">Number of decimals - user</param>
		/// <param name="m3_ECDE">Edit code</param>
		/// <param name="m3_ECDU">Edit code - user</param>
		/// <param name="m3_SMFL">Small field</param>
		/// <param name="m3_MXAV">Maximum accumulated value</param>
		/// <param name="m3_SUMA">Sum</param>
		/// <param name="m3_OMAX">Override max value</param>
		/// <param name="m3_SOSQ">Sorting sequence</param>
		/// <param name="m3_FDCA">Field information code</param>
		/// <param name="m3_DCNY">Debit / credit code used</param>
		/// <param name="m3_IBCA">Information browser category</param>
		/// <param name="m3_UDCN">Debit / credit code used - user</param>
		/// <param name="m3_EDFL">Edit field</param>
		/// <param name="m3_AGDR">Aggregation display rule</param>
		/// <param name="m3_AGUR">Aggregation update rule</param>
		/// <param name="m3_SUBR">Subtotal rule</param>
		/// <param name="m3_DTFR">Date format</param>
		/// <param name="m3_DCFM">Decimal format</param>
		/// <param name="m3_DDBX">Drop down box</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPanelVerCol(
			string m3_DIVI, 
			string m3_PGNM, 
			string m3_PIC1, 
			string m3_RESP = null, 
			string m3_PAVR = null, 
			int? m3_QTTP = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			int? m3_COID = null, 
			string m3_FLDI = null, 
			string m3_FLTY = null, 
			string m3_MSID = null, 
			int? m3_FLDL = null, 
			int? m3_FLLU = null, 
			string m3_FNDC = null, 
			string m3_UNDC = null, 
			string m3_ECDE = null, 
			string m3_ECDU = null, 
			int? m3_SMFL = null, 
			decimal? m3_MXAV = null, 
			int? m3_SUMA = null, 
			int? m3_OMAX = null, 
			int? m3_SOSQ = null, 
			string m3_FDCA = null, 
			int? m3_DCNY = null, 
			string m3_IBCA = null, 
			string m3_UDCN = null, 
			string m3_EDFL = null, 
			int? m3_AGDR = null, 
			int? m3_AGUR = null, 
			int? m3_SUBR = null, 
			string m3_DTFR = null, 
			string m3_DCFM = null, 
			int? m3_DDBX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdPanelVerCol",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");
			if (string.IsNullOrWhiteSpace(m3_PIC1))
				throw new ArgumentNullException("m3_PIC1");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PGNM", m3_PGNM.Trim())
				.WithQueryParameter("PIC1", m3_PIC1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAVR))
				request.WithQueryParameter("PAVR", m3_PAVR.Trim());
			if (m3_QTTP.HasValue)
				request.WithQueryParameter("QTTP", m3_QTTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_COID.HasValue)
				request.WithQueryParameter("COID", m3_COID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FLDI))
				request.WithQueryParameter("FLDI", m3_FLDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLTY))
				request.WithQueryParameter("FLTY", m3_FLTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSID))
				request.WithQueryParameter("MSID", m3_MSID.Trim());
			if (m3_FLDL.HasValue)
				request.WithQueryParameter("FLDL", m3_FLDL.Value.ToString());
			if (m3_FLLU.HasValue)
				request.WithQueryParameter("FLLU", m3_FLLU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FNDC))
				request.WithQueryParameter("FNDC", m3_FNDC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UNDC))
				request.WithQueryParameter("UNDC", m3_UNDC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECDE))
				request.WithQueryParameter("ECDE", m3_ECDE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECDU))
				request.WithQueryParameter("ECDU", m3_ECDU.Trim());
			if (m3_SMFL.HasValue)
				request.WithQueryParameter("SMFL", m3_SMFL.Value.ToString());
			if (m3_MXAV.HasValue)
				request.WithQueryParameter("MXAV", m3_MXAV.Value.ToString());
			if (m3_SUMA.HasValue)
				request.WithQueryParameter("SUMA", m3_SUMA.Value.ToString());
			if (m3_OMAX.HasValue)
				request.WithQueryParameter("OMAX", m3_OMAX.Value.ToString());
			if (m3_SOSQ.HasValue)
				request.WithQueryParameter("SOSQ", m3_SOSQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FDCA))
				request.WithQueryParameter("FDCA", m3_FDCA.Trim());
			if (m3_DCNY.HasValue)
				request.WithQueryParameter("DCNY", m3_DCNY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_IBCA))
				request.WithQueryParameter("IBCA", m3_IBCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UDCN))
				request.WithQueryParameter("UDCN", m3_UDCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDFL))
				request.WithQueryParameter("EDFL", m3_EDFL.Trim());
			if (m3_AGDR.HasValue)
				request.WithQueryParameter("AGDR", m3_AGDR.Value.ToString());
			if (m3_AGUR.HasValue)
				request.WithQueryParameter("AGUR", m3_AGUR.Value.ToString());
			if (m3_SUBR.HasValue)
				request.WithQueryParameter("SUBR", m3_SUBR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DTFR))
				request.WithQueryParameter("DTFR", m3_DTFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DCFM))
				request.WithQueryParameter("DCFM", m3_DCFM.Trim());
			if (m3_DDBX.HasValue)
				request.WithQueryParameter("DDBX", m3_DDBX.Value.ToString());

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
