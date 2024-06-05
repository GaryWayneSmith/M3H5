/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3JNUM">Job number (Required)</param>
		/// <param name="m3PRDT">Job date (Required)</param>
		/// <param name="m3PRTM">Job time (Required)</param>
		/// <param name="m3RGTM">Entry time (Required)</param>
		/// <param name="m3UNMS">Basic U/M</param>
		/// <param name="m3FSCD">Kit control</param>
		/// <param name="m3UPCO">Full cost summation</param>
		/// <param name="m3PSET">Pricing method</param>
		/// <param name="m3SRCD">Reservation level</param>
		/// <param name="m3SCCD">Statistics level</param>
		/// <param name="m3CURV">Distribution template</param>
		/// <param name="m3XK02">Kit size</param>
		/// <param name="m3KPCD">Kit/Charge prt</param>
		/// <param name="m3ISQN">Seq no interval</param>
		/// <param name="m3PRTX">Name</param>
		/// <param name="m3EXIB">Exclude itm/whs</param>
		/// <param name="m3CWEV">Calculate weight/volume</param>
		/// <param name="m3SKTS">Suppress Kit Screen</param>
		/// <param name="m3KPPO">Kit printout PO</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CreateKit(
			string m3JNUM, 
			DateTime m3PRDT, 
			int m3PRTM, 
			int m3RGTM, 
			string m3UNMS = null, 
			int? m3FSCD = null, 
			int? m3UPCO = null, 
			int? m3PSET = null, 
			int? m3SRCD = null, 
			int? m3SCCD = null, 
			string m3CURV = null, 
			int? m3XK02 = null, 
			int? m3KPCD = null, 
			int? m3ISQN = null, 
			string m3PRTX = null, 
			int? m3EXIB = null, 
			int? m3CWEV = null, 
			int? m3SKTS = null, 
			int? m3KPPO = null, 
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
			if (string.IsNullOrWhiteSpace(m3JNUM))
				throw new ArgumentNullException(nameof(m3JNUM));

			// Set mandatory parameters
			request
				.WithQueryParameter("JNUM", m3JNUM.Trim())
				.WithQueryParameter("PRDT", m3PRDT.ToM3String())
				.WithQueryParameter("PRTM", m3PRTM.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RGTM", m3RGTM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3UNMS))
				request.WithQueryParameter("UNMS", m3UNMS.Trim());
			if (m3FSCD.HasValue)
				request.WithQueryParameter("FSCD", m3FSCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UPCO.HasValue)
				request.WithQueryParameter("UPCO", m3UPCO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PSET.HasValue)
				request.WithQueryParameter("PSET", m3PSET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SRCD.HasValue)
				request.WithQueryParameter("SRCD", m3SRCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCCD.HasValue)
				request.WithQueryParameter("SCCD", m3SCCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CURV))
				request.WithQueryParameter("CURV", m3CURV.Trim());
			if (m3XK02.HasValue)
				request.WithQueryParameter("XK02", m3XK02.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KPCD.HasValue)
				request.WithQueryParameter("KPCD", m3KPCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ISQN.HasValue)
				request.WithQueryParameter("ISQN", m3ISQN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRTX))
				request.WithQueryParameter("PRTX", m3PRTX.Trim());
			if (m3EXIB.HasValue)
				request.WithQueryParameter("EXIB", m3EXIB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CWEV.HasValue)
				request.WithQueryParameter("CWEV", m3CWEV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SKTS.HasValue)
				request.WithQueryParameter("SKTS", m3SKTS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KPPO.HasValue)
				request.WithQueryParameter("KPPO", m3KPPO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Initalize
		/// Description Initalize the creation of the kits
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3STYN">Style number (Required)</param>
		/// <param name="m3FGRP">Feature group (Required)</param>
		/// <param name="m3SEA1">Season</param>
		/// <param name="m3OPTZ">Z-option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<InitalizeResponse></returns>
		/// <exception cref="M3Exception<InitalizeResponse>"></exception>
		public async Task<M3Response<InitalizeResponse>> Initalize(
			string m3STYN, 
			string m3FGRP, 
			string m3SEA1 = null, 
			string m3OPTZ = null, 
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
			if (string.IsNullOrWhiteSpace(m3STYN))
				throw new ArgumentNullException(nameof(m3STYN));
			if (string.IsNullOrWhiteSpace(m3FGRP))
				throw new ArgumentNullException(nameof(m3FGRP));

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3STYN.Trim())
				.WithQueryParameter("FGRP", m3FGRP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SEA1))
				request.WithQueryParameter("SEA1", m3SEA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTZ))
				request.WithQueryParameter("OPTZ", m3OPTZ.Trim());

			// Execute the request
			var result = await Execute<InitalizeResponse>(
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
		/// Description List records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3JNUM">Job number (Required)</param>
		/// <param name="m3STYN">Style number</param>
		/// <param name="m3PHID">Phantom ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			int m3JNUM, 
			string m3STYN = null, 
			string m3PHID = null, 
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
				.WithQueryParameter("JNUM", m3JNUM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STYN))
				request.WithQueryParameter("STYN", m3STYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHID))
				request.WithQueryParameter("PHID", m3PHID.Trim());

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
		/// Name PrepareKit
		/// Description Prepare the kit creation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3JNUM">Job number (Required)</param>
		/// <param name="m3PRDT">Job date (Required)</param>
		/// <param name="m3PRTM">Job time (Required)</param>
		/// <param name="m3RGTM">Entry time (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3STYN">Style number (Required)</param>
		/// <param name="m3QTQT">Quantity (Required)</param>
		/// <param name="m3PHID">Phantom ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrepareKit(
			int m3JNUM, 
			DateTime m3PRDT, 
			int m3PRTM, 
			int m3RGTM, 
			string m3ITNO, 
			string m3STYN, 
			decimal m3QTQT, 
			string m3PHID = null, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3STYN))
				throw new ArgumentNullException(nameof(m3STYN));

			// Set mandatory parameters
			request
				.WithQueryParameter("JNUM", m3JNUM.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PRDT", m3PRDT.ToM3String())
				.WithQueryParameter("PRTM", m3PRTM.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RGTM", m3RGTM.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("STYN", m3STYN.Trim())
				.WithQueryParameter("QTQT", m3QTQT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PHID))
				request.WithQueryParameter("PHID", m3PHID.Trim());

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
