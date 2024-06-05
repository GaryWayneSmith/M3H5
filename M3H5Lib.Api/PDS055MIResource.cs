/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.PDS055MI;
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
	/// Name: PDS055MI
	/// Component Name: ProductFeatures
	/// Description: Product features interface
	/// Version Release: 5ea1
	///</summary>
	public partial class PDS055MIResource : M3BaseResourceEndpoint
	{
		public PDS055MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PDS055MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FTID">Feature (Required)</param>
		/// <param name="m3FTTP">Feature type (Required)</param>
		/// <param name="m3TX30">Text (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TX10">Text</param>
		/// <param name="m3FGRP">Feature group</param>
		/// <param name="m3FICR">Feature check</param>
		/// <param name="m3VAOP">Option check</param>
		/// <param name="m3ADDF">Additional feature</param>
		/// <param name="m3POMO">Print on manufacturing order</param>
		/// <param name="m3PRED">Print control - order document</param>
		/// <param name="m3DCOO">Retreive from previous CO line</param>
		/// <param name="m3UNMS">Basic unit of measure</param>
		/// <param name="m3DCCD">Number of decimal places</param>
		/// <param name="m3NRMU">Numeric range multiple</param>
		/// <param name="m3NUVF">From numeric range value</param>
		/// <param name="m3NUVT">To numeric range value</param>
		/// <param name="m3GRPF">Bill of material group</param>
		/// <param name="m3ITGF">Item group</param>
		/// <param name="m3ITGT">Item group</param>
		/// <param name="m3ITCF">Product Group</param>
		/// <param name="m3ITCT">Product Group</param>
		/// <param name="m3PRFI">Print feature information</param>
		/// <param name="m3PRII">Print option information</param>
		/// <param name="m3PRNL">Print on new line</param>
		/// <param name="m3ATID">Attribute identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3FTID, 
			int m3FTTP, 
			string m3TX30, 
			int? m3CONO = null, 
			string m3TX10 = null, 
			string m3FGRP = null, 
			int? m3FICR = null, 
			int? m3VAOP = null, 
			int? m3ADDF = null, 
			int? m3POMO = null, 
			int? m3PRED = null, 
			int? m3DCOO = null, 
			string m3UNMS = null, 
			int? m3DCCD = null, 
			string m3NRMU = null, 
			string m3NUVF = null, 
			string m3NUVT = null, 
			int? m3GRPF = null, 
			string m3ITGF = null, 
			string m3ITGT = null, 
			string m3ITCF = null, 
			string m3ITCT = null, 
			int? m3PRFI = null, 
			int? m3PRII = null, 
			int? m3PRNL = null, 
			string m3ATID = null, 
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
			if (string.IsNullOrWhiteSpace(m3FTID))
				throw new ArgumentNullException(nameof(m3FTID));
			if (string.IsNullOrWhiteSpace(m3TX30))
				throw new ArgumentNullException(nameof(m3TX30));

			// Set mandatory parameters
			request
				.WithQueryParameter("FTID", m3FTID.Trim())
				.WithQueryParameter("FTTP", m3FTTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TX30", m3TX30.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX10))
				request.WithQueryParameter("TX10", m3TX10.Trim());
			if (!string.IsNullOrWhiteSpace(m3FGRP))
				request.WithQueryParameter("FGRP", m3FGRP.Trim());
			if (m3FICR.HasValue)
				request.WithQueryParameter("FICR", m3FICR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VAOP.HasValue)
				request.WithQueryParameter("VAOP", m3VAOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADDF.HasValue)
				request.WithQueryParameter("ADDF", m3ADDF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POMO.HasValue)
				request.WithQueryParameter("POMO", m3POMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRED.HasValue)
				request.WithQueryParameter("PRED", m3PRED.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DCOO.HasValue)
				request.WithQueryParameter("DCOO", m3DCOO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3UNMS))
				request.WithQueryParameter("UNMS", m3UNMS.Trim());
			if (m3DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3DCCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NRMU))
				request.WithQueryParameter("NRMU", m3NRMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3NUVF))
				request.WithQueryParameter("NUVF", m3NUVF.Trim());
			if (!string.IsNullOrWhiteSpace(m3NUVT))
				request.WithQueryParameter("NUVT", m3NUVT.Trim());
			if (m3GRPF.HasValue)
				request.WithQueryParameter("GRPF", m3GRPF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITGF))
				request.WithQueryParameter("ITGF", m3ITGF.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGT))
				request.WithQueryParameter("ITGT", m3ITGT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITCF))
				request.WithQueryParameter("ITCF", m3ITCF.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITCT))
				request.WithQueryParameter("ITCT", m3ITCT.Trim());
			if (m3PRFI.HasValue)
				request.WithQueryParameter("PRFI", m3PRFI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRII.HasValue)
				request.WithQueryParameter("PRII", m3PRII.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNL.HasValue)
				request.WithQueryParameter("PRNL", m3PRNL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ATID))
				request.WithQueryParameter("ATID", m3ATID.Trim());

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
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FTID">Feature (Required)</param>
		/// <param name="m3CTID">Feature (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FTTP">Feature type</param>
		/// <param name="m3TX30">Text</param>
		/// <param name="m3TX10">Text</param>
		/// <param name="m3FGRP">Feature group</param>
		/// <param name="m3FICR">Feature check</param>
		/// <param name="m3VAOP">Option check</param>
		/// <param name="m3ADDF">Additional feature</param>
		/// <param name="m3POMO">Print on manufacturing order</param>
		/// <param name="m3PRED">Print control - order document</param>
		/// <param name="m3DCOO">Retreive from previous CO line</param>
		/// <param name="m3UNMS">Basic unit of measure</param>
		/// <param name="m3DCCD">Number of decimal places</param>
		/// <param name="m3NRMU">Numeric range multiple</param>
		/// <param name="m3NUVF">From numeric range value</param>
		/// <param name="m3NUVT">To numeric range value</param>
		/// <param name="m3GRPF">Bill of material group</param>
		/// <param name="m3ITGF">Item group</param>
		/// <param name="m3ITGT">Item group</param>
		/// <param name="m3ITCF">Product Group</param>
		/// <param name="m3ITCT">Product Group</param>
		/// <param name="m3PRFI">Print feature information</param>
		/// <param name="m3PRII">Print option information</param>
		/// <param name="m3PRNL">Print on new line</param>
		/// <param name="m3ATID">Attribute identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Copy(
			string m3FTID, 
			string m3CTID, 
			int? m3CONO = null, 
			int? m3FTTP = null, 
			string m3TX30 = null, 
			string m3TX10 = null, 
			string m3FGRP = null, 
			int? m3FICR = null, 
			int? m3VAOP = null, 
			int? m3ADDF = null, 
			int? m3POMO = null, 
			int? m3PRED = null, 
			int? m3DCOO = null, 
			string m3UNMS = null, 
			int? m3DCCD = null, 
			string m3NRMU = null, 
			string m3NUVF = null, 
			string m3NUVT = null, 
			int? m3GRPF = null, 
			string m3ITGF = null, 
			string m3ITGT = null, 
			string m3ITCF = null, 
			string m3ITCT = null, 
			int? m3PRFI = null, 
			int? m3PRII = null, 
			int? m3PRNL = null, 
			string m3ATID = null, 
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

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FTID))
				throw new ArgumentNullException(nameof(m3FTID));
			if (string.IsNullOrWhiteSpace(m3CTID))
				throw new ArgumentNullException(nameof(m3CTID));

			// Set mandatory parameters
			request
				.WithQueryParameter("FTID", m3FTID.Trim())
				.WithQueryParameter("CTID", m3CTID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FTTP.HasValue)
				request.WithQueryParameter("FTTP", m3FTTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX30))
				request.WithQueryParameter("TX30", m3TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX10))
				request.WithQueryParameter("TX10", m3TX10.Trim());
			if (!string.IsNullOrWhiteSpace(m3FGRP))
				request.WithQueryParameter("FGRP", m3FGRP.Trim());
			if (m3FICR.HasValue)
				request.WithQueryParameter("FICR", m3FICR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VAOP.HasValue)
				request.WithQueryParameter("VAOP", m3VAOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADDF.HasValue)
				request.WithQueryParameter("ADDF", m3ADDF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POMO.HasValue)
				request.WithQueryParameter("POMO", m3POMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRED.HasValue)
				request.WithQueryParameter("PRED", m3PRED.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DCOO.HasValue)
				request.WithQueryParameter("DCOO", m3DCOO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3UNMS))
				request.WithQueryParameter("UNMS", m3UNMS.Trim());
			if (m3DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3DCCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NRMU))
				request.WithQueryParameter("NRMU", m3NRMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3NUVF))
				request.WithQueryParameter("NUVF", m3NUVF.Trim());
			if (!string.IsNullOrWhiteSpace(m3NUVT))
				request.WithQueryParameter("NUVT", m3NUVT.Trim());
			if (m3GRPF.HasValue)
				request.WithQueryParameter("GRPF", m3GRPF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITGF))
				request.WithQueryParameter("ITGF", m3ITGF.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGT))
				request.WithQueryParameter("ITGT", m3ITGT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITCF))
				request.WithQueryParameter("ITCF", m3ITCF.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITCT))
				request.WithQueryParameter("ITCT", m3ITCT.Trim());
			if (m3PRFI.HasValue)
				request.WithQueryParameter("PRFI", m3PRFI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRII.HasValue)
				request.WithQueryParameter("PRII", m3PRII.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNL.HasValue)
				request.WithQueryParameter("PRNL", m3PRNL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ATID))
				request.WithQueryParameter("ATID", m3ATID.Trim());

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
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FTID">Feature (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FTTP">Feature type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3FTID, 
			int? m3CONO = null, 
			int? m3FTTP = null, 
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
			if (string.IsNullOrWhiteSpace(m3FTID))
				throw new ArgumentNullException(nameof(m3FTID));

			// Set mandatory parameters
			request
				.WithQueryParameter("FTID", m3FTID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FTTP.HasValue)
				request.WithQueryParameter("FTTP", m3FTTP.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FTID">Feature (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FTTP">Feature type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3FTID, 
			int? m3CONO = null, 
			int? m3FTTP = null, 
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
			if (string.IsNullOrWhiteSpace(m3FTID))
				throw new ArgumentNullException(nameof(m3FTID));

			// Set mandatory parameters
			request
				.WithQueryParameter("FTID", m3FTID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FTTP.HasValue)
				request.WithQueryParameter("FTTP", m3FTTP.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FTID">Feature (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FTTP">Feature type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3FTID, 
			int? m3CONO = null, 
			int? m3FTTP = null, 
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

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FTID))
				throw new ArgumentNullException(nameof(m3FTID));

			// Set mandatory parameters
			request
				.WithQueryParameter("FTID", m3FTID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FTTP.HasValue)
				request.WithQueryParameter("FTTP", m3FTTP.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FTID">Feature (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FTTP">Feature type</param>
		/// <param name="m3TX30">Text</param>
		/// <param name="m3TX10">Text</param>
		/// <param name="m3FGRP">Feature group</param>
		/// <param name="m3FICR">Feature check</param>
		/// <param name="m3VAOP">Option check</param>
		/// <param name="m3ADDF">Additional feature</param>
		/// <param name="m3POMO">Print on manufacturing order</param>
		/// <param name="m3PRED">Print control - order document</param>
		/// <param name="m3DCOO">Retreive from previous CO line</param>
		/// <param name="m3UNMS">Basic unit of measure</param>
		/// <param name="m3DCCD">Number of decimal places</param>
		/// <param name="m3NRMU">Numeric range multiple</param>
		/// <param name="m3NUVF">From numeric range value</param>
		/// <param name="m3NUVT">To numeric range value</param>
		/// <param name="m3GRPF">Bill of material group</param>
		/// <param name="m3ITGF">Item group</param>
		/// <param name="m3ITGT">Item group</param>
		/// <param name="m3ITCF">Product Group</param>
		/// <param name="m3ITCT">Product Group</param>
		/// <param name="m3PRFI">Print feature information</param>
		/// <param name="m3PRII">Print option information</param>
		/// <param name="m3PRNL">Print on new line</param>
		/// <param name="m3ATID">Attribute identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Update(
			string m3FTID, 
			int? m3CONO = null, 
			int? m3FTTP = null, 
			string m3TX30 = null, 
			string m3TX10 = null, 
			string m3FGRP = null, 
			int? m3FICR = null, 
			int? m3VAOP = null, 
			int? m3ADDF = null, 
			int? m3POMO = null, 
			int? m3PRED = null, 
			int? m3DCOO = null, 
			string m3UNMS = null, 
			int? m3DCCD = null, 
			string m3NRMU = null, 
			string m3NUVF = null, 
			string m3NUVT = null, 
			int? m3GRPF = null, 
			string m3ITGF = null, 
			string m3ITGT = null, 
			string m3ITCF = null, 
			string m3ITCT = null, 
			int? m3PRFI = null, 
			int? m3PRII = null, 
			int? m3PRNL = null, 
			string m3ATID = null, 
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

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FTID))
				throw new ArgumentNullException(nameof(m3FTID));

			// Set mandatory parameters
			request
				.WithQueryParameter("FTID", m3FTID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FTTP.HasValue)
				request.WithQueryParameter("FTTP", m3FTTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX30))
				request.WithQueryParameter("TX30", m3TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX10))
				request.WithQueryParameter("TX10", m3TX10.Trim());
			if (!string.IsNullOrWhiteSpace(m3FGRP))
				request.WithQueryParameter("FGRP", m3FGRP.Trim());
			if (m3FICR.HasValue)
				request.WithQueryParameter("FICR", m3FICR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VAOP.HasValue)
				request.WithQueryParameter("VAOP", m3VAOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADDF.HasValue)
				request.WithQueryParameter("ADDF", m3ADDF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POMO.HasValue)
				request.WithQueryParameter("POMO", m3POMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRED.HasValue)
				request.WithQueryParameter("PRED", m3PRED.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DCOO.HasValue)
				request.WithQueryParameter("DCOO", m3DCOO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3UNMS))
				request.WithQueryParameter("UNMS", m3UNMS.Trim());
			if (m3DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3DCCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NRMU))
				request.WithQueryParameter("NRMU", m3NRMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3NUVF))
				request.WithQueryParameter("NUVF", m3NUVF.Trim());
			if (!string.IsNullOrWhiteSpace(m3NUVT))
				request.WithQueryParameter("NUVT", m3NUVT.Trim());
			if (m3GRPF.HasValue)
				request.WithQueryParameter("GRPF", m3GRPF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITGF))
				request.WithQueryParameter("ITGF", m3ITGF.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGT))
				request.WithQueryParameter("ITGT", m3ITGT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITCF))
				request.WithQueryParameter("ITCF", m3ITCF.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITCT))
				request.WithQueryParameter("ITCT", m3ITCT.Trim());
			if (m3PRFI.HasValue)
				request.WithQueryParameter("PRFI", m3PRFI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRII.HasValue)
				request.WithQueryParameter("PRII", m3PRII.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNL.HasValue)
				request.WithQueryParameter("PRNL", m3PRNL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ATID))
				request.WithQueryParameter("ATID", m3ATID.Trim());

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
