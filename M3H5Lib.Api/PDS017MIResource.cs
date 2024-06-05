/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PDS017MI;
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
	/// Name: PDS017MI
	/// Component Name: Create Kits
	/// Description: Api: Create Kits
	/// Version Release: 14.x
	///</summary>
	public partial class PDS017MIResource : M3BaseResourceEndpoint
	{
		public PDS017MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PDS017MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name CreateKit
		/// Description Creates Kit
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_JNUM">Job number (Required)</param>
		/// <param name="m3_PRDT">Job date (Required)</param>
		/// <param name="m3_PRTM">Job time (Required)</param>
		/// <param name="m3_RGTM">Entry time (Required)</param>
		/// <param name="m3_UNMS">Basic U/M</param>
		/// <param name="m3_FSCD">Kit control</param>
		/// <param name="m3_UPCO">Full cost summation</param>
		/// <param name="m3_PSET">Pricing method</param>
		/// <param name="m3_SRCD">Reservation level</param>
		/// <param name="m3_SCCD">Statistics level</param>
		/// <param name="m3_CURV">Distribution template</param>
		/// <param name="m3_XK02">Kit size</param>
		/// <param name="m3_KPCD">Kit/Charge prt</param>
		/// <param name="m3_ISQN">Seq no interval</param>
		/// <param name="m3_PRTX">Name</param>
		/// <param name="m3_EXIB">Exclude itm/whs</param>
		/// <param name="m3_CWEV">Calculate weight/volume</param>
		/// <param name="m3_SKTS">Suppress Kit Screen</param>
		/// <param name="m3_KPPO">Kit printout PO</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CreateKit(
			string m3_JNUM, 
			DateTime m3_PRDT, 
			int m3_PRTM, 
			int m3_RGTM, 
			string m3_UNMS = null, 
			int? m3_FSCD = null, 
			int? m3_UPCO = null, 
			int? m3_PSET = null, 
			int? m3_SRCD = null, 
			int? m3_SCCD = null, 
			string m3_CURV = null, 
			int? m3_XK02 = null, 
			int? m3_KPCD = null, 
			int? m3_ISQN = null, 
			string m3_PRTX = null, 
			int? m3_EXIB = null, 
			int? m3_CWEV = null, 
			int? m3_SKTS = null, 
			int? m3_KPPO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CreateKit",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_JNUM))
				throw new ArgumentNullException("m3_JNUM");

			// Set mandatory parameters
			request
				.WithQueryParameter("JNUM", m3_JNUM.Trim())
				.WithQueryParameter("PRDT", m3_PRDT.ToM3String())
				.WithQueryParameter("PRTM", m3_PRTM.ToString())
				.WithQueryParameter("RGTM", m3_RGTM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_UNMS))
				request.WithQueryParameter("UNMS", m3_UNMS.Trim());
			if (m3_FSCD.HasValue)
				request.WithQueryParameter("FSCD", m3_FSCD.Value.ToString());
			if (m3_UPCO.HasValue)
				request.WithQueryParameter("UPCO", m3_UPCO.Value.ToString());
			if (m3_PSET.HasValue)
				request.WithQueryParameter("PSET", m3_PSET.Value.ToString());
			if (m3_SRCD.HasValue)
				request.WithQueryParameter("SRCD", m3_SRCD.Value.ToString());
			if (m3_SCCD.HasValue)
				request.WithQueryParameter("SCCD", m3_SCCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CURV))
				request.WithQueryParameter("CURV", m3_CURV.Trim());
			if (m3_XK02.HasValue)
				request.WithQueryParameter("XK02", m3_XK02.Value.ToString());
			if (m3_KPCD.HasValue)
				request.WithQueryParameter("KPCD", m3_KPCD.Value.ToString());
			if (m3_ISQN.HasValue)
				request.WithQueryParameter("ISQN", m3_ISQN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRTX))
				request.WithQueryParameter("PRTX", m3_PRTX.Trim());
			if (m3_EXIB.HasValue)
				request.WithQueryParameter("EXIB", m3_EXIB.Value.ToString());
			if (m3_CWEV.HasValue)
				request.WithQueryParameter("CWEV", m3_CWEV.Value.ToString());
			if (m3_SKTS.HasValue)
				request.WithQueryParameter("SKTS", m3_SKTS.Value.ToString());
			if (m3_KPPO.HasValue)
				request.WithQueryParameter("KPPO", m3_KPPO.Value.ToString());

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
		/// Name Initalize
		/// Description Initalize the creation of the kits
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_STYN">Style number (Required)</param>
		/// <param name="m3_FGRP">Feature group (Required)</param>
		/// <param name="m3_SEA1">Season</param>
		/// <param name="m3_OPTZ">Z-option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<InitalizeResponse></returns>
		/// <exception cref="M3Exception<InitalizeResponse>"></exception>
		public async Task<M3Response<InitalizeResponse>> Initalize(
			string m3_STYN, 
			string m3_FGRP, 
			string m3_SEA1 = null, 
			string m3_OPTZ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Initalize",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STYN))
				throw new ArgumentNullException("m3_STYN");
			if (string.IsNullOrWhiteSpace(m3_FGRP))
				throw new ArgumentNullException("m3_FGRP");

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3_STYN.Trim())
				.WithQueryParameter("FGRP", m3_FGRP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SEA1))
				request.WithQueryParameter("SEA1", m3_SEA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTZ))
				request.WithQueryParameter("OPTZ", m3_OPTZ.Trim());

			// Execute the request
			var result = await Execute<InitalizeResponse>(
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
		/// Description List records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_JNUM">Job number (Required)</param>
		/// <param name="m3_STYN">Style number</param>
		/// <param name="m3_PHID">Phantom ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			int m3_JNUM, 
			string m3_STYN = null, 
			string m3_PHID = null, 
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

			// Set mandatory parameters
			request
				.WithQueryParameter("JNUM", m3_JNUM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STYN))
				request.WithQueryParameter("STYN", m3_STYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHID))
				request.WithQueryParameter("PHID", m3_PHID.Trim());

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
		/// Name PrepareKit
		/// Description Prepare the kit creation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_JNUM">Job number (Required)</param>
		/// <param name="m3_PRDT">Job date (Required)</param>
		/// <param name="m3_PRTM">Job time (Required)</param>
		/// <param name="m3_RGTM">Entry time (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_STYN">Style number (Required)</param>
		/// <param name="m3_QTQT">Quantity (Required)</param>
		/// <param name="m3_PHID">Phantom ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrepareKit(
			int m3_JNUM, 
			DateTime m3_PRDT, 
			int m3_PRTM, 
			int m3_RGTM, 
			string m3_ITNO, 
			string m3_STYN, 
			decimal m3_QTQT, 
			string m3_PHID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrepareKit",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_STYN))
				throw new ArgumentNullException("m3_STYN");

			// Set mandatory parameters
			request
				.WithQueryParameter("JNUM", m3_JNUM.ToString())
				.WithQueryParameter("PRDT", m3_PRDT.ToM3String())
				.WithQueryParameter("PRTM", m3_PRTM.ToString())
				.WithQueryParameter("RGTM", m3_RGTM.ToString())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("STYN", m3_STYN.Trim())
				.WithQueryParameter("QTQT", m3_QTQT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PHID))
				request.WithQueryParameter("PHID", m3_PHID.Trim());

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
