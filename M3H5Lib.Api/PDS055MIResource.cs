/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_FTID">Feature (Required)</param>
		/// <param name="m3_FTTP">Feature type (Required)</param>
		/// <param name="m3_TX30">Text (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TX10">Text</param>
		/// <param name="m3_FGRP">Feature group</param>
		/// <param name="m3_FICR">Feature check</param>
		/// <param name="m3_VAOP">Option check</param>
		/// <param name="m3_ADDF">Additional feature</param>
		/// <param name="m3_POMO">Print on manufacturing order</param>
		/// <param name="m3_PRED">Print control - order document</param>
		/// <param name="m3_DCOO">Retreive from previous CO line</param>
		/// <param name="m3_UNMS">Basic unit of measure</param>
		/// <param name="m3_DCCD">Number of decimal places</param>
		/// <param name="m3_NRMU">Numeric range multiple</param>
		/// <param name="m3_NUVF">From numeric range value</param>
		/// <param name="m3_NUVT">To numeric range value</param>
		/// <param name="m3_GRPF">Bill of material group</param>
		/// <param name="m3_ITGF">Item group</param>
		/// <param name="m3_ITGT">Item group</param>
		/// <param name="m3_ITCF">Product Group</param>
		/// <param name="m3_ITCT">Product Group</param>
		/// <param name="m3_PRFI">Print feature information</param>
		/// <param name="m3_PRII">Print option information</param>
		/// <param name="m3_PRNL">Print on new line</param>
		/// <param name="m3_ATID">Attribute identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_FTID, 
			int m3_FTTP, 
			string m3_TX30, 
			int? m3_CONO = null, 
			string m3_TX10 = null, 
			string m3_FGRP = null, 
			int? m3_FICR = null, 
			int? m3_VAOP = null, 
			int? m3_ADDF = null, 
			int? m3_POMO = null, 
			int? m3_PRED = null, 
			int? m3_DCOO = null, 
			string m3_UNMS = null, 
			int? m3_DCCD = null, 
			string m3_NRMU = null, 
			string m3_NUVF = null, 
			string m3_NUVT = null, 
			int? m3_GRPF = null, 
			string m3_ITGF = null, 
			string m3_ITGT = null, 
			string m3_ITCF = null, 
			string m3_ITCT = null, 
			int? m3_PRFI = null, 
			int? m3_PRII = null, 
			int? m3_PRNL = null, 
			string m3_ATID = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FTID))
				throw new ArgumentNullException("m3_FTID");
			if (string.IsNullOrWhiteSpace(m3_TX30))
				throw new ArgumentNullException("m3_TX30");

			// Set mandatory parameters
			request
				.WithQueryParameter("FTID", m3_FTID.Trim())
				.WithQueryParameter("FTTP", m3_FTTP.ToString())
				.WithQueryParameter("TX30", m3_TX30.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX10))
				request.WithQueryParameter("TX10", m3_TX10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FGRP))
				request.WithQueryParameter("FGRP", m3_FGRP.Trim());
			if (m3_FICR.HasValue)
				request.WithQueryParameter("FICR", m3_FICR.Value.ToString());
			if (m3_VAOP.HasValue)
				request.WithQueryParameter("VAOP", m3_VAOP.Value.ToString());
			if (m3_ADDF.HasValue)
				request.WithQueryParameter("ADDF", m3_ADDF.Value.ToString());
			if (m3_POMO.HasValue)
				request.WithQueryParameter("POMO", m3_POMO.Value.ToString());
			if (m3_PRED.HasValue)
				request.WithQueryParameter("PRED", m3_PRED.Value.ToString());
			if (m3_DCOO.HasValue)
				request.WithQueryParameter("DCOO", m3_DCOO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNMS))
				request.WithQueryParameter("UNMS", m3_UNMS.Trim());
			if (m3_DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3_DCCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NRMU))
				request.WithQueryParameter("NRMU", m3_NRMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NUVF))
				request.WithQueryParameter("NUVF", m3_NUVF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NUVT))
				request.WithQueryParameter("NUVT", m3_NUVT.Trim());
			if (m3_GRPF.HasValue)
				request.WithQueryParameter("GRPF", m3_GRPF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITGF))
				request.WithQueryParameter("ITGF", m3_ITGF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGT))
				request.WithQueryParameter("ITGT", m3_ITGT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITCF))
				request.WithQueryParameter("ITCF", m3_ITCF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITCT))
				request.WithQueryParameter("ITCT", m3_ITCT.Trim());
			if (m3_PRFI.HasValue)
				request.WithQueryParameter("PRFI", m3_PRFI.Value.ToString());
			if (m3_PRII.HasValue)
				request.WithQueryParameter("PRII", m3_PRII.Value.ToString());
			if (m3_PRNL.HasValue)
				request.WithQueryParameter("PRNL", m3_PRNL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ATID))
				request.WithQueryParameter("ATID", m3_ATID.Trim());

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
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FTID">Feature (Required)</param>
		/// <param name="m3_CTID">Feature (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FTTP">Feature type</param>
		/// <param name="m3_TX30">Text</param>
		/// <param name="m3_TX10">Text</param>
		/// <param name="m3_FGRP">Feature group</param>
		/// <param name="m3_FICR">Feature check</param>
		/// <param name="m3_VAOP">Option check</param>
		/// <param name="m3_ADDF">Additional feature</param>
		/// <param name="m3_POMO">Print on manufacturing order</param>
		/// <param name="m3_PRED">Print control - order document</param>
		/// <param name="m3_DCOO">Retreive from previous CO line</param>
		/// <param name="m3_UNMS">Basic unit of measure</param>
		/// <param name="m3_DCCD">Number of decimal places</param>
		/// <param name="m3_NRMU">Numeric range multiple</param>
		/// <param name="m3_NUVF">From numeric range value</param>
		/// <param name="m3_NUVT">To numeric range value</param>
		/// <param name="m3_GRPF">Bill of material group</param>
		/// <param name="m3_ITGF">Item group</param>
		/// <param name="m3_ITGT">Item group</param>
		/// <param name="m3_ITCF">Product Group</param>
		/// <param name="m3_ITCT">Product Group</param>
		/// <param name="m3_PRFI">Print feature information</param>
		/// <param name="m3_PRII">Print option information</param>
		/// <param name="m3_PRNL">Print on new line</param>
		/// <param name="m3_ATID">Attribute identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Copy(
			string m3_FTID, 
			string m3_CTID, 
			int? m3_CONO = null, 
			int? m3_FTTP = null, 
			string m3_TX30 = null, 
			string m3_TX10 = null, 
			string m3_FGRP = null, 
			int? m3_FICR = null, 
			int? m3_VAOP = null, 
			int? m3_ADDF = null, 
			int? m3_POMO = null, 
			int? m3_PRED = null, 
			int? m3_DCOO = null, 
			string m3_UNMS = null, 
			int? m3_DCCD = null, 
			string m3_NRMU = null, 
			string m3_NUVF = null, 
			string m3_NUVT = null, 
			int? m3_GRPF = null, 
			string m3_ITGF = null, 
			string m3_ITGT = null, 
			string m3_ITCF = null, 
			string m3_ITCT = null, 
			int? m3_PRFI = null, 
			int? m3_PRII = null, 
			int? m3_PRNL = null, 
			string m3_ATID = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FTID))
				throw new ArgumentNullException("m3_FTID");
			if (string.IsNullOrWhiteSpace(m3_CTID))
				throw new ArgumentNullException("m3_CTID");

			// Set mandatory parameters
			request
				.WithQueryParameter("FTID", m3_FTID.Trim())
				.WithQueryParameter("CTID", m3_CTID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_FTTP.HasValue)
				request.WithQueryParameter("FTTP", m3_FTTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX30))
				request.WithQueryParameter("TX30", m3_TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX10))
				request.WithQueryParameter("TX10", m3_TX10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FGRP))
				request.WithQueryParameter("FGRP", m3_FGRP.Trim());
			if (m3_FICR.HasValue)
				request.WithQueryParameter("FICR", m3_FICR.Value.ToString());
			if (m3_VAOP.HasValue)
				request.WithQueryParameter("VAOP", m3_VAOP.Value.ToString());
			if (m3_ADDF.HasValue)
				request.WithQueryParameter("ADDF", m3_ADDF.Value.ToString());
			if (m3_POMO.HasValue)
				request.WithQueryParameter("POMO", m3_POMO.Value.ToString());
			if (m3_PRED.HasValue)
				request.WithQueryParameter("PRED", m3_PRED.Value.ToString());
			if (m3_DCOO.HasValue)
				request.WithQueryParameter("DCOO", m3_DCOO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNMS))
				request.WithQueryParameter("UNMS", m3_UNMS.Trim());
			if (m3_DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3_DCCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NRMU))
				request.WithQueryParameter("NRMU", m3_NRMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NUVF))
				request.WithQueryParameter("NUVF", m3_NUVF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NUVT))
				request.WithQueryParameter("NUVT", m3_NUVT.Trim());
			if (m3_GRPF.HasValue)
				request.WithQueryParameter("GRPF", m3_GRPF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITGF))
				request.WithQueryParameter("ITGF", m3_ITGF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGT))
				request.WithQueryParameter("ITGT", m3_ITGT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITCF))
				request.WithQueryParameter("ITCF", m3_ITCF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITCT))
				request.WithQueryParameter("ITCT", m3_ITCT.Trim());
			if (m3_PRFI.HasValue)
				request.WithQueryParameter("PRFI", m3_PRFI.Value.ToString());
			if (m3_PRII.HasValue)
				request.WithQueryParameter("PRII", m3_PRII.Value.ToString());
			if (m3_PRNL.HasValue)
				request.WithQueryParameter("PRNL", m3_PRNL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ATID))
				request.WithQueryParameter("ATID", m3_ATID.Trim());

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
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FTID">Feature (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FTTP">Feature type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3_FTID, 
			int? m3_CONO = null, 
			int? m3_FTTP = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FTID))
				throw new ArgumentNullException("m3_FTID");

			// Set mandatory parameters
			request
				.WithQueryParameter("FTID", m3_FTID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_FTTP.HasValue)
				request.WithQueryParameter("FTTP", m3_FTTP.Value.ToString());

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
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FTID">Feature (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FTTP">Feature type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_FTID, 
			int? m3_CONO = null, 
			int? m3_FTTP = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FTID))
				throw new ArgumentNullException("m3_FTID");

			// Set mandatory parameters
			request
				.WithQueryParameter("FTID", m3_FTID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_FTTP.HasValue)
				request.WithQueryParameter("FTTP", m3_FTTP.Value.ToString());

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
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FTID">Feature (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FTTP">Feature type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3_FTID, 
			int? m3_CONO = null, 
			int? m3_FTTP = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FTID))
				throw new ArgumentNullException("m3_FTID");

			// Set mandatory parameters
			request
				.WithQueryParameter("FTID", m3_FTID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_FTTP.HasValue)
				request.WithQueryParameter("FTTP", m3_FTTP.Value.ToString());

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
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FTID">Feature (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FTTP">Feature type</param>
		/// <param name="m3_TX30">Text</param>
		/// <param name="m3_TX10">Text</param>
		/// <param name="m3_FGRP">Feature group</param>
		/// <param name="m3_FICR">Feature check</param>
		/// <param name="m3_VAOP">Option check</param>
		/// <param name="m3_ADDF">Additional feature</param>
		/// <param name="m3_POMO">Print on manufacturing order</param>
		/// <param name="m3_PRED">Print control - order document</param>
		/// <param name="m3_DCOO">Retreive from previous CO line</param>
		/// <param name="m3_UNMS">Basic unit of measure</param>
		/// <param name="m3_DCCD">Number of decimal places</param>
		/// <param name="m3_NRMU">Numeric range multiple</param>
		/// <param name="m3_NUVF">From numeric range value</param>
		/// <param name="m3_NUVT">To numeric range value</param>
		/// <param name="m3_GRPF">Bill of material group</param>
		/// <param name="m3_ITGF">Item group</param>
		/// <param name="m3_ITGT">Item group</param>
		/// <param name="m3_ITCF">Product Group</param>
		/// <param name="m3_ITCT">Product Group</param>
		/// <param name="m3_PRFI">Print feature information</param>
		/// <param name="m3_PRII">Print option information</param>
		/// <param name="m3_PRNL">Print on new line</param>
		/// <param name="m3_ATID">Attribute identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Update(
			string m3_FTID, 
			int? m3_CONO = null, 
			int? m3_FTTP = null, 
			string m3_TX30 = null, 
			string m3_TX10 = null, 
			string m3_FGRP = null, 
			int? m3_FICR = null, 
			int? m3_VAOP = null, 
			int? m3_ADDF = null, 
			int? m3_POMO = null, 
			int? m3_PRED = null, 
			int? m3_DCOO = null, 
			string m3_UNMS = null, 
			int? m3_DCCD = null, 
			string m3_NRMU = null, 
			string m3_NUVF = null, 
			string m3_NUVT = null, 
			int? m3_GRPF = null, 
			string m3_ITGF = null, 
			string m3_ITGT = null, 
			string m3_ITCF = null, 
			string m3_ITCT = null, 
			int? m3_PRFI = null, 
			int? m3_PRII = null, 
			int? m3_PRNL = null, 
			string m3_ATID = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FTID))
				throw new ArgumentNullException("m3_FTID");

			// Set mandatory parameters
			request
				.WithQueryParameter("FTID", m3_FTID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_FTTP.HasValue)
				request.WithQueryParameter("FTTP", m3_FTTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX30))
				request.WithQueryParameter("TX30", m3_TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX10))
				request.WithQueryParameter("TX10", m3_TX10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FGRP))
				request.WithQueryParameter("FGRP", m3_FGRP.Trim());
			if (m3_FICR.HasValue)
				request.WithQueryParameter("FICR", m3_FICR.Value.ToString());
			if (m3_VAOP.HasValue)
				request.WithQueryParameter("VAOP", m3_VAOP.Value.ToString());
			if (m3_ADDF.HasValue)
				request.WithQueryParameter("ADDF", m3_ADDF.Value.ToString());
			if (m3_POMO.HasValue)
				request.WithQueryParameter("POMO", m3_POMO.Value.ToString());
			if (m3_PRED.HasValue)
				request.WithQueryParameter("PRED", m3_PRED.Value.ToString());
			if (m3_DCOO.HasValue)
				request.WithQueryParameter("DCOO", m3_DCOO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNMS))
				request.WithQueryParameter("UNMS", m3_UNMS.Trim());
			if (m3_DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3_DCCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NRMU))
				request.WithQueryParameter("NRMU", m3_NRMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NUVF))
				request.WithQueryParameter("NUVF", m3_NUVF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NUVT))
				request.WithQueryParameter("NUVT", m3_NUVT.Trim());
			if (m3_GRPF.HasValue)
				request.WithQueryParameter("GRPF", m3_GRPF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITGF))
				request.WithQueryParameter("ITGF", m3_ITGF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGT))
				request.WithQueryParameter("ITGT", m3_ITGT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITCF))
				request.WithQueryParameter("ITCF", m3_ITCF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITCT))
				request.WithQueryParameter("ITCT", m3_ITCT.Trim());
			if (m3_PRFI.HasValue)
				request.WithQueryParameter("PRFI", m3_PRFI.Value.ToString());
			if (m3_PRII.HasValue)
				request.WithQueryParameter("PRII", m3_PRII.Value.ToString());
			if (m3_PRNL.HasValue)
				request.WithQueryParameter("PRNL", m3_PRNL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ATID))
				request.WithQueryParameter("ATID", m3_ATID.Trim());

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
