/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name DelPanelVersion
		/// Description Delete a Panel version record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PGNM">Program name (Required)</param>
		/// <param name="m3PAVR">Panel version (Required)</param>
		/// <param name="m3PIC1">Panel (Required)</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3IBCA">Information browser category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelPanelVersion(
			string m3PGNM, 
			string m3PAVR, 
			string m3PIC1, 
			string m3RESP = null, 
			string m3IBCA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelPanelVersion",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));
			if (string.IsNullOrWhiteSpace(m3PAVR))
				throw new ArgumentNullException(nameof(m3PAVR));
			if (string.IsNullOrWhiteSpace(m3PIC1))
				throw new ArgumentNullException(nameof(m3PIC1));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim())
				.WithQueryParameter("PAVR", m3PAVR.Trim())
				.WithQueryParameter("PIC1", m3PIC1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3IBCA))
				request.WithQueryParameter("IBCA", m3IBCA.Trim());

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
		/// Name GetFldColParm
		/// Description Get field column parameters
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PGNM">Program name (Required)</param>
		/// <param name="m3PIC1">Panel (Required)</param>
		/// <param name="m3IBCA">Information browser category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFldColParmResponse></returns>
		/// <exception cref="M3Exception<GetFldColParmResponse>"></exception>
		public async Task<M3Response<GetFldColParmResponse>> GetFldColParm(
			string m3PGNM, 
			string m3PIC1, 
			string m3IBCA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetFldColParm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));
			if (string.IsNullOrWhiteSpace(m3PIC1))
				throw new ArgumentNullException(nameof(m3PIC1));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim())
				.WithQueryParameter("PIC1", m3PIC1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3IBCA))
				request.WithQueryParameter("IBCA", m3IBCA.Trim());

			// Execute the request
			var result = await Execute<GetFldColParmResponse>(
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
		/// Name LstAllColumns
		/// Description List all columns for existing panel version
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PGNM">Program name (Required)</param>
		/// <param name="m3PAVR">Panel version (Required)</param>
		/// <param name="m3PIC1">Panel (Required)</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3IBCA">Information browser category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAllColumnsResponse></returns>
		/// <exception cref="M3Exception<LstAllColumnsResponse>"></exception>
		public async Task<M3Response<LstAllColumnsResponse>> LstAllColumns(
			string m3PGNM, 
			string m3PAVR, 
			string m3PIC1, 
			string m3RESP = null, 
			string m3IBCA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAllColumns",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));
			if (string.IsNullOrWhiteSpace(m3PAVR))
				throw new ArgumentNullException(nameof(m3PAVR));
			if (string.IsNullOrWhiteSpace(m3PIC1))
				throw new ArgumentNullException(nameof(m3PIC1));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim())
				.WithQueryParameter("PAVR", m3PAVR.Trim())
				.WithQueryParameter("PIC1", m3PIC1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3IBCA))
				request.WithQueryParameter("IBCA", m3IBCA.Trim());

			// Execute the request
			var result = await Execute<LstAllColumnsResponse>(
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
		/// Name LstAllFields
		/// Description List all possible fields for panelversion
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PGNM">Program name (Required)</param>
		/// <param name="m3IBCA">Information browser category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAllFieldsResponse></returns>
		/// <exception cref="M3Exception<LstAllFieldsResponse>"></exception>
		public async Task<M3Response<LstAllFieldsResponse>> LstAllFields(
			string m3PGNM, 
			string m3IBCA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAllFields",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3IBCA))
				request.WithQueryParameter("IBCA", m3IBCA.Trim());

			// Execute the request
			var result = await Execute<LstAllFieldsResponse>(
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
		/// Name LstMandatoryFld
		/// Description List All Mandatory Fields for panelversion view
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PGNM">Program name (Required)</param>
		/// <param name="m3PIC1">Panel (Required)</param>
		/// <param name="m3QTTP">Inquiry type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMandatoryFldResponse></returns>
		/// <exception cref="M3Exception<LstMandatoryFldResponse>"></exception>
		public async Task<M3Response<LstMandatoryFldResponse>> LstMandatoryFld(
			string m3PGNM, 
			string m3PIC1, 
			int m3QTTP, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMandatoryFld",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));
			if (string.IsNullOrWhiteSpace(m3PIC1))
				throw new ArgumentNullException(nameof(m3PIC1));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim())
				.WithQueryParameter("PIC1", m3PIC1.Trim())
				.WithQueryParameter("QTTP", m3QTTP.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstMandatoryFldResponse>(
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
		/// Name LstSortingSeq
		/// Description List Sorting sequence for panelversion view
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PGNM">Program name (Required)</param>
		/// <param name="m3PIC1">Panel (Required)</param>
		/// <param name="m3QTTP">Inquiry type (Required)</param>
		/// <param name="m3IBCA">Information browser category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSortingSeqResponse></returns>
		/// <exception cref="M3Exception<LstSortingSeqResponse>"></exception>
		public async Task<M3Response<LstSortingSeqResponse>> LstSortingSeq(
			string m3PGNM, 
			string m3PIC1, 
			int m3QTTP, 
			string m3IBCA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstSortingSeq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));
			if (string.IsNullOrWhiteSpace(m3PIC1))
				throw new ArgumentNullException(nameof(m3PIC1));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim())
				.WithQueryParameter("PIC1", m3PIC1.Trim())
				.WithQueryParameter("QTTP", m3QTTP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3IBCA))
				request.WithQueryParameter("IBCA", m3IBCA.Trim());

			// Execute the request
			var result = await Execute<LstSortingSeqResponse>(
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
		/// Name LstViews
		/// Description List views in sorting order
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PGNM">Program name (Required)</param>
		/// <param name="m3IBCA">Information browser category</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3QTTP">Sorting order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstViewsResponse></returns>
		/// <exception cref="M3Exception<LstViewsResponse>"></exception>
		public async Task<M3Response<LstViewsResponse>> LstViews(
			string m3PGNM, 
			string m3IBCA = null, 
			string m3RESP = null, 
			int? m3QTTP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstViews",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3IBCA))
				request.WithQueryParameter("IBCA", m3IBCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3QTTP.HasValue)
				request.WithQueryParameter("QTTP", m3QTTP.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstViewsResponse>(
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
		/// Name UpdPanelVerCol
		/// Description Update Panel version column
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PGNM">Program name (Required)</param>
		/// <param name="m3PIC1">Panel (Required)</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3PAVR">Panel version</param>
		/// <param name="m3QTTP">Inquiry type</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3COID">Column number</param>
		/// <param name="m3FLDI">Field</param>
		/// <param name="m3FLTY">Field type</param>
		/// <param name="m3MSID">Message ID</param>
		/// <param name="m3FLDL">Field length</param>
		/// <param name="m3FLLU">Field length user value</param>
		/// <param name="m3FNDC">Number of decimals</param>
		/// <param name="m3UNDC">Number of decimals - user</param>
		/// <param name="m3ECDE">Edit code</param>
		/// <param name="m3ECDU">Edit code - user</param>
		/// <param name="m3SMFL">Small field</param>
		/// <param name="m3MXAV">Maximum accumulated value</param>
		/// <param name="m3SUMA">Sum</param>
		/// <param name="m3OMAX">Override max value</param>
		/// <param name="m3SOSQ">Sorting sequence</param>
		/// <param name="m3FDCA">Field information code</param>
		/// <param name="m3DCNY">Debit / credit code used</param>
		/// <param name="m3IBCA">Information browser category</param>
		/// <param name="m3UDCN">Debit / credit code used - user</param>
		/// <param name="m3EDFL">Edit field</param>
		/// <param name="m3AGDR">Aggregation display rule</param>
		/// <param name="m3AGUR">Aggregation update rule</param>
		/// <param name="m3SUBR">Subtotal rule</param>
		/// <param name="m3DTFR">Date format</param>
		/// <param name="m3DCFM">Decimal format</param>
		/// <param name="m3DDBX">Drop down box</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPanelVerCol(
			string m3DIVI, 
			string m3PGNM, 
			string m3PIC1, 
			string m3RESP = null, 
			string m3PAVR = null, 
			int? m3QTTP = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			int? m3COID = null, 
			string m3FLDI = null, 
			string m3FLTY = null, 
			string m3MSID = null, 
			int? m3FLDL = null, 
			int? m3FLLU = null, 
			string m3FNDC = null, 
			string m3UNDC = null, 
			string m3ECDE = null, 
			string m3ECDU = null, 
			int? m3SMFL = null, 
			decimal? m3MXAV = null, 
			int? m3SUMA = null, 
			int? m3OMAX = null, 
			int? m3SOSQ = null, 
			string m3FDCA = null, 
			int? m3DCNY = null, 
			string m3IBCA = null, 
			string m3UDCN = null, 
			string m3EDFL = null, 
			int? m3AGDR = null, 
			int? m3AGUR = null, 
			int? m3SUBR = null, 
			string m3DTFR = null, 
			string m3DCFM = null, 
			int? m3DDBX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdPanelVerCol",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));
			if (string.IsNullOrWhiteSpace(m3PIC1))
				throw new ArgumentNullException(nameof(m3PIC1));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PGNM", m3PGNM.Trim())
				.WithQueryParameter("PIC1", m3PIC1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAVR))
				request.WithQueryParameter("PAVR", m3PAVR.Trim());
			if (m3QTTP.HasValue)
				request.WithQueryParameter("QTTP", m3QTTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3COID.HasValue)
				request.WithQueryParameter("COID", m3COID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FLDI))
				request.WithQueryParameter("FLDI", m3FLDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLTY))
				request.WithQueryParameter("FLTY", m3FLTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSID))
				request.WithQueryParameter("MSID", m3MSID.Trim());
			if (m3FLDL.HasValue)
				request.WithQueryParameter("FLDL", m3FLDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLLU.HasValue)
				request.WithQueryParameter("FLLU", m3FLLU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FNDC))
				request.WithQueryParameter("FNDC", m3FNDC.Trim());
			if (!string.IsNullOrWhiteSpace(m3UNDC))
				request.WithQueryParameter("UNDC", m3UNDC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECDE))
				request.WithQueryParameter("ECDE", m3ECDE.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECDU))
				request.WithQueryParameter("ECDU", m3ECDU.Trim());
			if (m3SMFL.HasValue)
				request.WithQueryParameter("SMFL", m3SMFL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXAV.HasValue)
				request.WithQueryParameter("MXAV", m3MXAV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUMA.HasValue)
				request.WithQueryParameter("SUMA", m3SUMA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OMAX.HasValue)
				request.WithQueryParameter("OMAX", m3OMAX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SOSQ.HasValue)
				request.WithQueryParameter("SOSQ", m3SOSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FDCA))
				request.WithQueryParameter("FDCA", m3FDCA.Trim());
			if (m3DCNY.HasValue)
				request.WithQueryParameter("DCNY", m3DCNY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3IBCA))
				request.WithQueryParameter("IBCA", m3IBCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3UDCN))
				request.WithQueryParameter("UDCN", m3UDCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDFL))
				request.WithQueryParameter("EDFL", m3EDFL.Trim());
			if (m3AGDR.HasValue)
				request.WithQueryParameter("AGDR", m3AGDR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGUR.HasValue)
				request.WithQueryParameter("AGUR", m3AGUR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUBR.HasValue)
				request.WithQueryParameter("SUBR", m3SUBR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DTFR))
				request.WithQueryParameter("DTFR", m3DTFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DCFM))
				request.WithQueryParameter("DCFM", m3DCFM.Trim());
			if (m3DDBX.HasValue)
				request.WithQueryParameter("DDBX", m3DDBX.Value.ToString(CultureInfo.CurrentCulture));

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
