/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PDS090MI;
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
	/// Name: PDS090MI
	/// Component Name: ProductSelectionMatrices
	/// Description: Product selection matrices interface
	/// Version Release: 5ea0
	///</summary>
	public partial class PDS090MIResource : M3BaseResourceEndpoint
	{
		public PDS090MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PDS090MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MXID">Selection matrix (Required)</param>
		/// <param name="m3_MXTP">Selection matrix type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TX30">Text</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_MGRP">Field group</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_UNMS">Basic unit of measure</param>
		/// <param name="m3_DSQU">Display quantity</param>
		/// <param name="m3_DMD1">Text</param>
		/// <param name="m3_DMD2">Text</param>
		/// <param name="m3_DMD3">Text</param>
		/// <param name="m3_MOC1">Column Type</param>
		/// <param name="m3_MCC1">Column</param>
		/// <param name="m3_MRC1">Column Range</param>
		/// <param name="m3_MOC2">Column Type</param>
		/// <param name="m3_MCC2">Column</param>
		/// <param name="m3_MRC2">Column Range</param>
		/// <param name="m3_MOC3">Column Type</param>
		/// <param name="m3_MCC3">Column</param>
		/// <param name="m3_MRC3">Column Range</param>
		/// <param name="m3_MOC4">Column Type</param>
		/// <param name="m3_MCC4">Column</param>
		/// <param name="m3_MRC4">Column Range</param>
		/// <param name="m3_MOC5">Column Type</param>
		/// <param name="m3_MCC5">Column</param>
		/// <param name="m3_MRC5">Column Range</param>
		/// <param name="m3_MOC6">Column Type</param>
		/// <param name="m3_MCC6">Column</param>
		/// <param name="m3_MOC7">Column Type</param>
		/// <param name="m3_MRC6">Column Range</param>
		/// <param name="m3_MCC7">Column</param>
		/// <param name="m3_MRC7">Column Rank</param>
		/// <param name="m3_MOC8">Column Type</param>
		/// <param name="m3_MCC8">Column</param>
		/// <param name="m3_MRC8">Column Rank</param>
		/// <param name="m3_MOC9">Column Type</param>
		/// <param name="m3_MCC9">Column</param>
		/// <param name="m3_FOR1">Formula result identity</param>
		/// <param name="m3_FOR2">Formula result identity</param>
		/// <param name="m3_FOR3">Formula result identity</param>
		/// <param name="m3_FOR4">Formula result identity</param>
		/// <param name="m3_FOR5">Formula result identity</param>
		/// <param name="m3_FOR6">Formula result identity</param>
		/// <param name="m3_FOR7">Formula result identity</param>
		/// <param name="m3_FOR8">Formula result identity</param>
		/// <param name="m3_FOR9">Formula result identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_MXID, 
			int m3_MXTP, 
			int? m3_CONO = null, 
			string m3_TX30 = null, 
			string m3_TX15 = null, 
			string m3_MGRP = null, 
			string m3_RESP = null, 
			string m3_UNMS = null, 
			int? m3_DSQU = null, 
			string m3_DMD1 = null, 
			string m3_DMD2 = null, 
			string m3_DMD3 = null, 
			int? m3_MOC1 = null, 
			string m3_MCC1 = null, 
			int? m3_MRC1 = null, 
			int? m3_MOC2 = null, 
			string m3_MCC2 = null, 
			int? m3_MRC2 = null, 
			int? m3_MOC3 = null, 
			string m3_MCC3 = null, 
			int? m3_MRC3 = null, 
			int? m3_MOC4 = null, 
			string m3_MCC4 = null, 
			int? m3_MRC4 = null, 
			int? m3_MOC5 = null, 
			string m3_MCC5 = null, 
			int? m3_MRC5 = null, 
			int? m3_MOC6 = null, 
			string m3_MCC6 = null, 
			int? m3_MOC7 = null, 
			int? m3_MRC6 = null, 
			string m3_MCC7 = null, 
			int? m3_MRC7 = null, 
			int? m3_MOC8 = null, 
			string m3_MCC8 = null, 
			int? m3_MRC8 = null, 
			int? m3_MOC9 = null, 
			string m3_MCC9 = null, 
			string m3_FOR1 = null, 
			string m3_FOR2 = null, 
			string m3_FOR3 = null, 
			string m3_FOR4 = null, 
			string m3_FOR5 = null, 
			string m3_FOR6 = null, 
			string m3_FOR7 = null, 
			string m3_FOR8 = null, 
			string m3_FOR9 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_MXID))
				throw new ArgumentNullException("m3_MXID");

			// Set mandatory parameters
			request
				.WithQueryParameter("MXID", m3_MXID.Trim())
				.WithQueryParameter("MXTP", m3_MXTP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX30))
				request.WithQueryParameter("TX30", m3_TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MGRP))
				request.WithQueryParameter("MGRP", m3_MGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UNMS))
				request.WithQueryParameter("UNMS", m3_UNMS.Trim());
			if (m3_DSQU.HasValue)
				request.WithQueryParameter("DSQU", m3_DSQU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DMD1))
				request.WithQueryParameter("DMD1", m3_DMD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DMD2))
				request.WithQueryParameter("DMD2", m3_DMD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DMD3))
				request.WithQueryParameter("DMD3", m3_DMD3.Trim());
			if (m3_MOC1.HasValue)
				request.WithQueryParameter("MOC1", m3_MOC1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MCC1))
				request.WithQueryParameter("MCC1", m3_MCC1.Trim());
			if (m3_MRC1.HasValue)
				request.WithQueryParameter("MRC1", m3_MRC1.Value.ToString());
			if (m3_MOC2.HasValue)
				request.WithQueryParameter("MOC2", m3_MOC2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MCC2))
				request.WithQueryParameter("MCC2", m3_MCC2.Trim());
			if (m3_MRC2.HasValue)
				request.WithQueryParameter("MRC2", m3_MRC2.Value.ToString());
			if (m3_MOC3.HasValue)
				request.WithQueryParameter("MOC3", m3_MOC3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MCC3))
				request.WithQueryParameter("MCC3", m3_MCC3.Trim());
			if (m3_MRC3.HasValue)
				request.WithQueryParameter("MRC3", m3_MRC3.Value.ToString());
			if (m3_MOC4.HasValue)
				request.WithQueryParameter("MOC4", m3_MOC4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MCC4))
				request.WithQueryParameter("MCC4", m3_MCC4.Trim());
			if (m3_MRC4.HasValue)
				request.WithQueryParameter("MRC4", m3_MRC4.Value.ToString());
			if (m3_MOC5.HasValue)
				request.WithQueryParameter("MOC5", m3_MOC5.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MCC5))
				request.WithQueryParameter("MCC5", m3_MCC5.Trim());
			if (m3_MRC5.HasValue)
				request.WithQueryParameter("MRC5", m3_MRC5.Value.ToString());
			if (m3_MOC6.HasValue)
				request.WithQueryParameter("MOC6", m3_MOC6.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MCC6))
				request.WithQueryParameter("MCC6", m3_MCC6.Trim());
			if (m3_MOC7.HasValue)
				request.WithQueryParameter("MOC7", m3_MOC7.Value.ToString());
			if (m3_MRC6.HasValue)
				request.WithQueryParameter("MRC6", m3_MRC6.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MCC7))
				request.WithQueryParameter("MCC7", m3_MCC7.Trim());
			if (m3_MRC7.HasValue)
				request.WithQueryParameter("MRC7", m3_MRC7.Value.ToString());
			if (m3_MOC8.HasValue)
				request.WithQueryParameter("MOC8", m3_MOC8.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MCC8))
				request.WithQueryParameter("MCC8", m3_MCC8.Trim());
			if (m3_MRC8.HasValue)
				request.WithQueryParameter("MRC8", m3_MRC8.Value.ToString());
			if (m3_MOC9.HasValue)
				request.WithQueryParameter("MOC9", m3_MOC9.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MCC9))
				request.WithQueryParameter("MCC9", m3_MCC9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FOR1))
				request.WithQueryParameter("FOR1", m3_FOR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FOR2))
				request.WithQueryParameter("FOR2", m3_FOR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FOR3))
				request.WithQueryParameter("FOR3", m3_FOR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FOR4))
				request.WithQueryParameter("FOR4", m3_FOR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FOR5))
				request.WithQueryParameter("FOR5", m3_FOR5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FOR6))
				request.WithQueryParameter("FOR6", m3_FOR6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FOR7))
				request.WithQueryParameter("FOR7", m3_FOR7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FOR8))
				request.WithQueryParameter("FOR8", m3_FOR8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FOR9))
				request.WithQueryParameter("FOR9", m3_FOR9.Trim());

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
		/// Name AddLine
		/// Description AddLine
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MXID">Selection matrix (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MVC1">Value in column 1</param>
		/// <param name="m3_MVC2">Value in column 2</param>
		/// <param name="m3_MVC3">Value in column 3</param>
		/// <param name="m3_MVC4">Value in column 4</param>
		/// <param name="m3_MVC5">Value in column 5</param>
		/// <param name="m3_MVC6">Value in column 6</param>
		/// <param name="m3_FDAT">Valid from</param>
		/// <param name="m3_MRC1">Alpha result</param>
		/// <param name="m3_MNC1">Numeric result 1</param>
		/// <param name="m3_MNC2">Numeric result 2</param>
		/// <param name="m3_MNC3">Numeric result 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLine(
			string m3_MXID, 
			int? m3_CONO = null, 
			string m3_MVC1 = null, 
			string m3_MVC2 = null, 
			string m3_MVC3 = null, 
			string m3_MVC4 = null, 
			string m3_MVC5 = null, 
			string m3_MVC6 = null, 
			DateTime? m3_FDAT = null, 
			string m3_MRC1 = null, 
			decimal? m3_MNC1 = null, 
			decimal? m3_MNC2 = null, 
			decimal? m3_MNC3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MXID))
				throw new ArgumentNullException("m3_MXID");

			// Set mandatory parameters
			request
				.WithQueryParameter("MXID", m3_MXID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MVC1))
				request.WithQueryParameter("MVC1", m3_MVC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MVC2))
				request.WithQueryParameter("MVC2", m3_MVC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MVC3))
				request.WithQueryParameter("MVC3", m3_MVC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MVC4))
				request.WithQueryParameter("MVC4", m3_MVC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MVC5))
				request.WithQueryParameter("MVC5", m3_MVC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MVC6))
				request.WithQueryParameter("MVC6", m3_MVC6.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_MRC1))
				request.WithQueryParameter("MRC1", m3_MRC1.Trim());
			if (m3_MNC1.HasValue)
				request.WithQueryParameter("MNC1", m3_MNC1.Value.ToString());
			if (m3_MNC2.HasValue)
				request.WithQueryParameter("MNC2", m3_MNC2.Value.ToString());
			if (m3_MNC3.HasValue)
				request.WithQueryParameter("MNC3", m3_MNC3.Value.ToString());

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
		/// <param name="m3_MXID">Selection matrix (Required)</param>
		/// <param name="m3_CXID">To Selection matrix (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Copy(
			string m3_MXID, 
			string m3_CXID, 
			int? m3_CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_MXID))
				throw new ArgumentNullException("m3_MXID");
			if (string.IsNullOrWhiteSpace(m3_CXID))
				throw new ArgumentNullException("m3_CXID");

			// Set mandatory parameters
			request
				.WithQueryParameter("MXID", m3_MXID.Trim())
				.WithQueryParameter("CXID", m3_CXID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// <param name="m3_MXID">Selection matrix (Required)</param>
		/// <param name="m3_MXTP">Selection matrix type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3_MXID, 
			int m3_MXTP, 
			int? m3_CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_MXID))
				throw new ArgumentNullException("m3_MXID");

			// Set mandatory parameters
			request
				.WithQueryParameter("MXID", m3_MXID.Trim())
				.WithQueryParameter("MXTP", m3_MXTP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name DeleteLine
		/// Description Delete Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MXID">Selection matrix (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MVC1">Value in column 1</param>
		/// <param name="m3_MVC2">Value in column 2</param>
		/// <param name="m3_MVC3">Value in column 3</param>
		/// <param name="m3_MVC4">Value in column 4</param>
		/// <param name="m3_MVC5">Value in column 5</param>
		/// <param name="m3_MVC6">Value in column 6</param>
		/// <param name="m3_FDAT">Valid from</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteLine(
			string m3_MXID, 
			int? m3_CONO = null, 
			string m3_MVC1 = null, 
			string m3_MVC2 = null, 
			string m3_MVC3 = null, 
			string m3_MVC4 = null, 
			string m3_MVC5 = null, 
			string m3_MVC6 = null, 
			DateTime? m3_FDAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeleteLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MXID))
				throw new ArgumentNullException("m3_MXID");

			// Set mandatory parameters
			request
				.WithQueryParameter("MXID", m3_MXID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MVC1))
				request.WithQueryParameter("MVC1", m3_MVC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MVC2))
				request.WithQueryParameter("MVC2", m3_MVC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MVC3))
				request.WithQueryParameter("MVC3", m3_MVC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MVC4))
				request.WithQueryParameter("MVC4", m3_MVC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MVC5))
				request.WithQueryParameter("MVC5", m3_MVC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MVC6))
				request.WithQueryParameter("MVC6", m3_MVC6.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());

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
		/// <param name="m3_MXID">Selection matrix</param>
		/// <param name="m3_MXTP">Selection matrix type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			int? m3_CONO = null, 
			string m3_MXID = null, 
			int? m3_MXTP = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_MXID))
				request.WithQueryParameter("MXID", m3_MXID.Trim());
			if (m3_MXTP.HasValue)
				request.WithQueryParameter("MXTP", m3_MXTP.Value.ToString());

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
		/// <param name="m3_MXID">Selection matrix</param>
		/// <param name="m3_MXTP">Selection matrix type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			int? m3_CONO = null, 
			string m3_MXID = null, 
			int? m3_MXTP = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_MXID))
				request.WithQueryParameter("MXID", m3_MXID.Trim());
			if (m3_MXTP.HasValue)
				request.WithQueryParameter("MXTP", m3_MXTP.Value.ToString());

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
		/// Name ListLine
		/// Description List Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MXID">Selection matrix (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListLineResponse></returns>
		/// <exception cref="M3Exception<ListLineResponse>"></exception>
		public async Task<M3Response<ListLineResponse>> ListLine(
			string m3_MXID, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ListLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MXID))
				throw new ArgumentNullException("m3_MXID");

			// Set mandatory parameters
			request
				.WithQueryParameter("MXID", m3_MXID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<ListLineResponse>(
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
		/// <param name="m3_MXID">Selection matrix (Required)</param>
		/// <param name="m3_MXTP">Selection matrix type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TX30">Text</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_MGRP">Field group</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_UNMS">Basic unit of measure</param>
		/// <param name="m3_DSQU">Display quantity</param>
		/// <param name="m3_DMD1">Text</param>
		/// <param name="m3_DMD2">Text</param>
		/// <param name="m3_DMD3">Text</param>
		/// <param name="m3_MOC1">Column Type</param>
		/// <param name="m3_MCC1">Column</param>
		/// <param name="m3_MRC1">Column Range</param>
		/// <param name="m3_MOC2">Column Type</param>
		/// <param name="m3_MCC2">Column</param>
		/// <param name="m3_MRC2">Column Range</param>
		/// <param name="m3_MOC3">Column Type</param>
		/// <param name="m3_MCC3">Column</param>
		/// <param name="m3_MRC3">Column Range</param>
		/// <param name="m3_MOC4">Column Type</param>
		/// <param name="m3_MCC4">Column</param>
		/// <param name="m3_MRC4">Column Range</param>
		/// <param name="m3_MOC5">Column Type</param>
		/// <param name="m3_MCC5">Column</param>
		/// <param name="m3_MRC5">Column Range</param>
		/// <param name="m3_MOC6">Column Type</param>
		/// <param name="m3_MCC6">Column</param>
		/// <param name="m3_MOC7">Column Type</param>
		/// <param name="m3_MRC6">Column Range</param>
		/// <param name="m3_MCC7">Column</param>
		/// <param name="m3_MRC7">Column Rank</param>
		/// <param name="m3_MOC8">Column Type</param>
		/// <param name="m3_MCC8">Column</param>
		/// <param name="m3_MRC8">Column Rank</param>
		/// <param name="m3_MOC9">Column Type</param>
		/// <param name="m3_MCC9">Column</param>
		/// <param name="m3_MRC9">Column Rank</param>
		/// <param name="m3_FOR1">Formula result identity</param>
		/// <param name="m3_FOR2">Formula result identity</param>
		/// <param name="m3_FOR3">Formula result identity</param>
		/// <param name="m3_FOR4">Formula result identity</param>
		/// <param name="m3_FOR5">Formula result identity</param>
		/// <param name="m3_FOR6">Formula result identity</param>
		/// <param name="m3_FOR7">Formula result identity</param>
		/// <param name="m3_FOR8">Formula result identity</param>
		/// <param name="m3_FOR9">Formula result identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Update(
			string m3_MXID, 
			int m3_MXTP, 
			int? m3_CONO = null, 
			string m3_TX30 = null, 
			string m3_TX15 = null, 
			string m3_MGRP = null, 
			string m3_RESP = null, 
			string m3_UNMS = null, 
			int? m3_DSQU = null, 
			string m3_DMD1 = null, 
			string m3_DMD2 = null, 
			string m3_DMD3 = null, 
			int? m3_MOC1 = null, 
			string m3_MCC1 = null, 
			int? m3_MRC1 = null, 
			int? m3_MOC2 = null, 
			string m3_MCC2 = null, 
			int? m3_MRC2 = null, 
			int? m3_MOC3 = null, 
			string m3_MCC3 = null, 
			int? m3_MRC3 = null, 
			int? m3_MOC4 = null, 
			string m3_MCC4 = null, 
			int? m3_MRC4 = null, 
			int? m3_MOC5 = null, 
			string m3_MCC5 = null, 
			int? m3_MRC5 = null, 
			int? m3_MOC6 = null, 
			string m3_MCC6 = null, 
			int? m3_MOC7 = null, 
			int? m3_MRC6 = null, 
			string m3_MCC7 = null, 
			int? m3_MRC7 = null, 
			int? m3_MOC8 = null, 
			string m3_MCC8 = null, 
			int? m3_MRC8 = null, 
			int? m3_MOC9 = null, 
			string m3_MCC9 = null, 
			int? m3_MRC9 = null, 
			string m3_FOR1 = null, 
			string m3_FOR2 = null, 
			string m3_FOR3 = null, 
			string m3_FOR4 = null, 
			string m3_FOR5 = null, 
			string m3_FOR6 = null, 
			string m3_FOR7 = null, 
			string m3_FOR8 = null, 
			string m3_FOR9 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_MXID))
				throw new ArgumentNullException("m3_MXID");

			// Set mandatory parameters
			request
				.WithQueryParameter("MXID", m3_MXID.Trim())
				.WithQueryParameter("MXTP", m3_MXTP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX30))
				request.WithQueryParameter("TX30", m3_TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MGRP))
				request.WithQueryParameter("MGRP", m3_MGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UNMS))
				request.WithQueryParameter("UNMS", m3_UNMS.Trim());
			if (m3_DSQU.HasValue)
				request.WithQueryParameter("DSQU", m3_DSQU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DMD1))
				request.WithQueryParameter("DMD1", m3_DMD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DMD2))
				request.WithQueryParameter("DMD2", m3_DMD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DMD3))
				request.WithQueryParameter("DMD3", m3_DMD3.Trim());
			if (m3_MOC1.HasValue)
				request.WithQueryParameter("MOC1", m3_MOC1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MCC1))
				request.WithQueryParameter("MCC1", m3_MCC1.Trim());
			if (m3_MRC1.HasValue)
				request.WithQueryParameter("MRC1", m3_MRC1.Value.ToString());
			if (m3_MOC2.HasValue)
				request.WithQueryParameter("MOC2", m3_MOC2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MCC2))
				request.WithQueryParameter("MCC2", m3_MCC2.Trim());
			if (m3_MRC2.HasValue)
				request.WithQueryParameter("MRC2", m3_MRC2.Value.ToString());
			if (m3_MOC3.HasValue)
				request.WithQueryParameter("MOC3", m3_MOC3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MCC3))
				request.WithQueryParameter("MCC3", m3_MCC3.Trim());
			if (m3_MRC3.HasValue)
				request.WithQueryParameter("MRC3", m3_MRC3.Value.ToString());
			if (m3_MOC4.HasValue)
				request.WithQueryParameter("MOC4", m3_MOC4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MCC4))
				request.WithQueryParameter("MCC4", m3_MCC4.Trim());
			if (m3_MRC4.HasValue)
				request.WithQueryParameter("MRC4", m3_MRC4.Value.ToString());
			if (m3_MOC5.HasValue)
				request.WithQueryParameter("MOC5", m3_MOC5.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MCC5))
				request.WithQueryParameter("MCC5", m3_MCC5.Trim());
			if (m3_MRC5.HasValue)
				request.WithQueryParameter("MRC5", m3_MRC5.Value.ToString());
			if (m3_MOC6.HasValue)
				request.WithQueryParameter("MOC6", m3_MOC6.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MCC6))
				request.WithQueryParameter("MCC6", m3_MCC6.Trim());
			if (m3_MOC7.HasValue)
				request.WithQueryParameter("MOC7", m3_MOC7.Value.ToString());
			if (m3_MRC6.HasValue)
				request.WithQueryParameter("MRC6", m3_MRC6.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MCC7))
				request.WithQueryParameter("MCC7", m3_MCC7.Trim());
			if (m3_MRC7.HasValue)
				request.WithQueryParameter("MRC7", m3_MRC7.Value.ToString());
			if (m3_MOC8.HasValue)
				request.WithQueryParameter("MOC8", m3_MOC8.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MCC8))
				request.WithQueryParameter("MCC8", m3_MCC8.Trim());
			if (m3_MRC8.HasValue)
				request.WithQueryParameter("MRC8", m3_MRC8.Value.ToString());
			if (m3_MOC9.HasValue)
				request.WithQueryParameter("MOC9", m3_MOC9.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MCC9))
				request.WithQueryParameter("MCC9", m3_MCC9.Trim());
			if (m3_MRC9.HasValue)
				request.WithQueryParameter("MRC9", m3_MRC9.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FOR1))
				request.WithQueryParameter("FOR1", m3_FOR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FOR2))
				request.WithQueryParameter("FOR2", m3_FOR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FOR3))
				request.WithQueryParameter("FOR3", m3_FOR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FOR4))
				request.WithQueryParameter("FOR4", m3_FOR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FOR5))
				request.WithQueryParameter("FOR5", m3_FOR5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FOR6))
				request.WithQueryParameter("FOR6", m3_FOR6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FOR7))
				request.WithQueryParameter("FOR7", m3_FOR7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FOR8))
				request.WithQueryParameter("FOR8", m3_FOR8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FOR9))
				request.WithQueryParameter("FOR9", m3_FOR9.Trim());

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
		/// Name UpdateLine
		/// Description Update Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MXID">Selection matrix (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MVC1">Value in column 1</param>
		/// <param name="m3_MVC2">Value in column 2</param>
		/// <param name="m3_MVC3">Value in column 3</param>
		/// <param name="m3_MVC4">Value in column 4</param>
		/// <param name="m3_MVC5">Value in column 5</param>
		/// <param name="m3_MVC6">Value in column 6</param>
		/// <param name="m3_FDAT">Valid from</param>
		/// <param name="m3_MRC1">Alpha result</param>
		/// <param name="m3_MNC1">Numeric result 1</param>
		/// <param name="m3_MNC2">Numeric result 2</param>
		/// <param name="m3_MNC3">Numeric result 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdateLine(
			string m3_MXID, 
			int? m3_CONO = null, 
			string m3_MVC1 = null, 
			string m3_MVC2 = null, 
			string m3_MVC3 = null, 
			string m3_MVC4 = null, 
			string m3_MVC5 = null, 
			string m3_MVC6 = null, 
			DateTime? m3_FDAT = null, 
			string m3_MRC1 = null, 
			decimal? m3_MNC1 = null, 
			decimal? m3_MNC2 = null, 
			decimal? m3_MNC3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdateLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MXID))
				throw new ArgumentNullException("m3_MXID");

			// Set mandatory parameters
			request
				.WithQueryParameter("MXID", m3_MXID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MVC1))
				request.WithQueryParameter("MVC1", m3_MVC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MVC2))
				request.WithQueryParameter("MVC2", m3_MVC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MVC3))
				request.WithQueryParameter("MVC3", m3_MVC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MVC4))
				request.WithQueryParameter("MVC4", m3_MVC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MVC5))
				request.WithQueryParameter("MVC5", m3_MVC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MVC6))
				request.WithQueryParameter("MVC6", m3_MVC6.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_MRC1))
				request.WithQueryParameter("MRC1", m3_MRC1.Trim());
			if (m3_MNC1.HasValue)
				request.WithQueryParameter("MNC1", m3_MNC1.Value.ToString());
			if (m3_MNC2.HasValue)
				request.WithQueryParameter("MNC2", m3_MNC2.Value.ToString());
			if (m3_MNC3.HasValue)
				request.WithQueryParameter("MNC3", m3_MNC3.Value.ToString());

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
