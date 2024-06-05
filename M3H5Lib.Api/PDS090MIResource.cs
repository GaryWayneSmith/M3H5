/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MXID">Selection matrix (Required)</param>
		/// <param name="m3MXTP">Selection matrix type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TX30">Text</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3MGRP">Field group</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3UNMS">Basic unit of measure</param>
		/// <param name="m3DSQU">Display quantity</param>
		/// <param name="m3DMD1">Text</param>
		/// <param name="m3DMD2">Text</param>
		/// <param name="m3DMD3">Text</param>
		/// <param name="m3MOC1">Column Type</param>
		/// <param name="m3MCC1">Column</param>
		/// <param name="m3MRC1">Column Range</param>
		/// <param name="m3MOC2">Column Type</param>
		/// <param name="m3MCC2">Column</param>
		/// <param name="m3MRC2">Column Range</param>
		/// <param name="m3MOC3">Column Type</param>
		/// <param name="m3MCC3">Column</param>
		/// <param name="m3MRC3">Column Range</param>
		/// <param name="m3MOC4">Column Type</param>
		/// <param name="m3MCC4">Column</param>
		/// <param name="m3MRC4">Column Range</param>
		/// <param name="m3MOC5">Column Type</param>
		/// <param name="m3MCC5">Column</param>
		/// <param name="m3MRC5">Column Range</param>
		/// <param name="m3MOC6">Column Type</param>
		/// <param name="m3MCC6">Column</param>
		/// <param name="m3MOC7">Column Type</param>
		/// <param name="m3MRC6">Column Range</param>
		/// <param name="m3MCC7">Column</param>
		/// <param name="m3MRC7">Column Rank</param>
		/// <param name="m3MOC8">Column Type</param>
		/// <param name="m3MCC8">Column</param>
		/// <param name="m3MRC8">Column Rank</param>
		/// <param name="m3MOC9">Column Type</param>
		/// <param name="m3MCC9">Column</param>
		/// <param name="m3FOR1">Formula result identity</param>
		/// <param name="m3FOR2">Formula result identity</param>
		/// <param name="m3FOR3">Formula result identity</param>
		/// <param name="m3FOR4">Formula result identity</param>
		/// <param name="m3FOR5">Formula result identity</param>
		/// <param name="m3FOR6">Formula result identity</param>
		/// <param name="m3FOR7">Formula result identity</param>
		/// <param name="m3FOR8">Formula result identity</param>
		/// <param name="m3FOR9">Formula result identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3MXID, 
			int m3MXTP, 
			int? m3CONO = null, 
			string m3TX30 = null, 
			string m3TX15 = null, 
			string m3MGRP = null, 
			string m3RESP = null, 
			string m3UNMS = null, 
			int? m3DSQU = null, 
			string m3DMD1 = null, 
			string m3DMD2 = null, 
			string m3DMD3 = null, 
			int? m3MOC1 = null, 
			string m3MCC1 = null, 
			int? m3MRC1 = null, 
			int? m3MOC2 = null, 
			string m3MCC2 = null, 
			int? m3MRC2 = null, 
			int? m3MOC3 = null, 
			string m3MCC3 = null, 
			int? m3MRC3 = null, 
			int? m3MOC4 = null, 
			string m3MCC4 = null, 
			int? m3MRC4 = null, 
			int? m3MOC5 = null, 
			string m3MCC5 = null, 
			int? m3MRC5 = null, 
			int? m3MOC6 = null, 
			string m3MCC6 = null, 
			int? m3MOC7 = null, 
			int? m3MRC6 = null, 
			string m3MCC7 = null, 
			int? m3MRC7 = null, 
			int? m3MOC8 = null, 
			string m3MCC8 = null, 
			int? m3MRC8 = null, 
			int? m3MOC9 = null, 
			string m3MCC9 = null, 
			string m3FOR1 = null, 
			string m3FOR2 = null, 
			string m3FOR3 = null, 
			string m3FOR4 = null, 
			string m3FOR5 = null, 
			string m3FOR6 = null, 
			string m3FOR7 = null, 
			string m3FOR8 = null, 
			string m3FOR9 = null, 
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

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MXID))
				throw new ArgumentNullException(nameof(m3MXID));

			// Set mandatory parameters
			request
				.WithQueryParameter("MXID", m3MXID.Trim())
				.WithQueryParameter("MXTP", m3MXTP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX30))
				request.WithQueryParameter("TX30", m3TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3MGRP))
				request.WithQueryParameter("MGRP", m3MGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3UNMS))
				request.WithQueryParameter("UNMS", m3UNMS.Trim());
			if (m3DSQU.HasValue)
				request.WithQueryParameter("DSQU", m3DSQU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DMD1))
				request.WithQueryParameter("DMD1", m3DMD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3DMD2))
				request.WithQueryParameter("DMD2", m3DMD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3DMD3))
				request.WithQueryParameter("DMD3", m3DMD3.Trim());
			if (m3MOC1.HasValue)
				request.WithQueryParameter("MOC1", m3MOC1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MCC1))
				request.WithQueryParameter("MCC1", m3MCC1.Trim());
			if (m3MRC1.HasValue)
				request.WithQueryParameter("MRC1", m3MRC1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MOC2.HasValue)
				request.WithQueryParameter("MOC2", m3MOC2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MCC2))
				request.WithQueryParameter("MCC2", m3MCC2.Trim());
			if (m3MRC2.HasValue)
				request.WithQueryParameter("MRC2", m3MRC2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MOC3.HasValue)
				request.WithQueryParameter("MOC3", m3MOC3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MCC3))
				request.WithQueryParameter("MCC3", m3MCC3.Trim());
			if (m3MRC3.HasValue)
				request.WithQueryParameter("MRC3", m3MRC3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MOC4.HasValue)
				request.WithQueryParameter("MOC4", m3MOC4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MCC4))
				request.WithQueryParameter("MCC4", m3MCC4.Trim());
			if (m3MRC4.HasValue)
				request.WithQueryParameter("MRC4", m3MRC4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MOC5.HasValue)
				request.WithQueryParameter("MOC5", m3MOC5.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MCC5))
				request.WithQueryParameter("MCC5", m3MCC5.Trim());
			if (m3MRC5.HasValue)
				request.WithQueryParameter("MRC5", m3MRC5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MOC6.HasValue)
				request.WithQueryParameter("MOC6", m3MOC6.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MCC6))
				request.WithQueryParameter("MCC6", m3MCC6.Trim());
			if (m3MOC7.HasValue)
				request.WithQueryParameter("MOC7", m3MOC7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MRC6.HasValue)
				request.WithQueryParameter("MRC6", m3MRC6.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MCC7))
				request.WithQueryParameter("MCC7", m3MCC7.Trim());
			if (m3MRC7.HasValue)
				request.WithQueryParameter("MRC7", m3MRC7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MOC8.HasValue)
				request.WithQueryParameter("MOC8", m3MOC8.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MCC8))
				request.WithQueryParameter("MCC8", m3MCC8.Trim());
			if (m3MRC8.HasValue)
				request.WithQueryParameter("MRC8", m3MRC8.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MOC9.HasValue)
				request.WithQueryParameter("MOC9", m3MOC9.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MCC9))
				request.WithQueryParameter("MCC9", m3MCC9.Trim());
			if (!string.IsNullOrWhiteSpace(m3FOR1))
				request.WithQueryParameter("FOR1", m3FOR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FOR2))
				request.WithQueryParameter("FOR2", m3FOR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FOR3))
				request.WithQueryParameter("FOR3", m3FOR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3FOR4))
				request.WithQueryParameter("FOR4", m3FOR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3FOR5))
				request.WithQueryParameter("FOR5", m3FOR5.Trim());
			if (!string.IsNullOrWhiteSpace(m3FOR6))
				request.WithQueryParameter("FOR6", m3FOR6.Trim());
			if (!string.IsNullOrWhiteSpace(m3FOR7))
				request.WithQueryParameter("FOR7", m3FOR7.Trim());
			if (!string.IsNullOrWhiteSpace(m3FOR8))
				request.WithQueryParameter("FOR8", m3FOR8.Trim());
			if (!string.IsNullOrWhiteSpace(m3FOR9))
				request.WithQueryParameter("FOR9", m3FOR9.Trim());

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
		/// Name AddLine
		/// Description AddLine
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MXID">Selection matrix (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MVC1">Value in column 1</param>
		/// <param name="m3MVC2">Value in column 2</param>
		/// <param name="m3MVC3">Value in column 3</param>
		/// <param name="m3MVC4">Value in column 4</param>
		/// <param name="m3MVC5">Value in column 5</param>
		/// <param name="m3MVC6">Value in column 6</param>
		/// <param name="m3FDAT">Valid from</param>
		/// <param name="m3MRC1">Alpha result</param>
		/// <param name="m3MNC1">Numeric result 1</param>
		/// <param name="m3MNC2">Numeric result 2</param>
		/// <param name="m3MNC3">Numeric result 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLine(
			string m3MXID, 
			int? m3CONO = null, 
			string m3MVC1 = null, 
			string m3MVC2 = null, 
			string m3MVC3 = null, 
			string m3MVC4 = null, 
			string m3MVC5 = null, 
			string m3MVC6 = null, 
			DateTime? m3FDAT = null, 
			string m3MRC1 = null, 
			decimal? m3MNC1 = null, 
			decimal? m3MNC2 = null, 
			decimal? m3MNC3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MXID))
				throw new ArgumentNullException(nameof(m3MXID));

			// Set mandatory parameters
			request
				.WithQueryParameter("MXID", m3MXID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MVC1))
				request.WithQueryParameter("MVC1", m3MVC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3MVC2))
				request.WithQueryParameter("MVC2", m3MVC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MVC3))
				request.WithQueryParameter("MVC3", m3MVC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MVC4))
				request.WithQueryParameter("MVC4", m3MVC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3MVC5))
				request.WithQueryParameter("MVC5", m3MVC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3MVC6))
				request.WithQueryParameter("MVC6", m3MVC6.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3MRC1))
				request.WithQueryParameter("MRC1", m3MRC1.Trim());
			if (m3MNC1.HasValue)
				request.WithQueryParameter("MNC1", m3MNC1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MNC2.HasValue)
				request.WithQueryParameter("MNC2", m3MNC2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MNC3.HasValue)
				request.WithQueryParameter("MNC3", m3MNC3.Value.ToString(CultureInfo.CurrentCulture));

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
		/// <param name="m3MXID">Selection matrix (Required)</param>
		/// <param name="m3CXID">To Selection matrix (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Copy(
			string m3MXID, 
			string m3CXID, 
			int? m3CONO = null, 
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

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MXID))
				throw new ArgumentNullException(nameof(m3MXID));
			if (string.IsNullOrWhiteSpace(m3CXID))
				throw new ArgumentNullException(nameof(m3CXID));

			// Set mandatory parameters
			request
				.WithQueryParameter("MXID", m3MXID.Trim())
				.WithQueryParameter("CXID", m3CXID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// <param name="m3MXID">Selection matrix (Required)</param>
		/// <param name="m3MXTP">Selection matrix type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3MXID, 
			int m3MXTP, 
			int? m3CONO = null, 
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

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MXID))
				throw new ArgumentNullException(nameof(m3MXID));

			// Set mandatory parameters
			request
				.WithQueryParameter("MXID", m3MXID.Trim())
				.WithQueryParameter("MXTP", m3MXTP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DeleteLine
		/// Description Delete Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MXID">Selection matrix (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MVC1">Value in column 1</param>
		/// <param name="m3MVC2">Value in column 2</param>
		/// <param name="m3MVC3">Value in column 3</param>
		/// <param name="m3MVC4">Value in column 4</param>
		/// <param name="m3MVC5">Value in column 5</param>
		/// <param name="m3MVC6">Value in column 6</param>
		/// <param name="m3FDAT">Valid from</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteLine(
			string m3MXID, 
			int? m3CONO = null, 
			string m3MVC1 = null, 
			string m3MVC2 = null, 
			string m3MVC3 = null, 
			string m3MVC4 = null, 
			string m3MVC5 = null, 
			string m3MVC6 = null, 
			DateTime? m3FDAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DeleteLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MXID))
				throw new ArgumentNullException(nameof(m3MXID));

			// Set mandatory parameters
			request
				.WithQueryParameter("MXID", m3MXID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MVC1))
				request.WithQueryParameter("MVC1", m3MVC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3MVC2))
				request.WithQueryParameter("MVC2", m3MVC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MVC3))
				request.WithQueryParameter("MVC3", m3MVC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MVC4))
				request.WithQueryParameter("MVC4", m3MVC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3MVC5))
				request.WithQueryParameter("MVC5", m3MVC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3MVC6))
				request.WithQueryParameter("MVC6", m3MVC6.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());

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
		/// <param name="m3MXID">Selection matrix</param>
		/// <param name="m3MXTP">Selection matrix type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			int? m3CONO = null, 
			string m3MXID = null, 
			int? m3MXTP = null, 
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
			if (!string.IsNullOrWhiteSpace(m3MXID))
				request.WithQueryParameter("MXID", m3MXID.Trim());
			if (m3MXTP.HasValue)
				request.WithQueryParameter("MXTP", m3MXTP.Value.ToString(CultureInfo.CurrentCulture));

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
		/// <param name="m3MXID">Selection matrix</param>
		/// <param name="m3MXTP">Selection matrix type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			int? m3CONO = null, 
			string m3MXID = null, 
			int? m3MXTP = null, 
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
			if (!string.IsNullOrWhiteSpace(m3MXID))
				request.WithQueryParameter("MXID", m3MXID.Trim());
			if (m3MXTP.HasValue)
				request.WithQueryParameter("MXTP", m3MXTP.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ListLine
		/// Description List Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MXID">Selection matrix (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListLineResponse></returns>
		/// <exception cref="M3Exception<ListLineResponse>"></exception>
		public async Task<M3Response<ListLineResponse>> ListLine(
			string m3MXID, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ListLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MXID))
				throw new ArgumentNullException(nameof(m3MXID));

			// Set mandatory parameters
			request
				.WithQueryParameter("MXID", m3MXID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ListLineResponse>(
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
		/// <param name="m3MXID">Selection matrix (Required)</param>
		/// <param name="m3MXTP">Selection matrix type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TX30">Text</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3MGRP">Field group</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3UNMS">Basic unit of measure</param>
		/// <param name="m3DSQU">Display quantity</param>
		/// <param name="m3DMD1">Text</param>
		/// <param name="m3DMD2">Text</param>
		/// <param name="m3DMD3">Text</param>
		/// <param name="m3MOC1">Column Type</param>
		/// <param name="m3MCC1">Column</param>
		/// <param name="m3MRC1">Column Range</param>
		/// <param name="m3MOC2">Column Type</param>
		/// <param name="m3MCC2">Column</param>
		/// <param name="m3MRC2">Column Range</param>
		/// <param name="m3MOC3">Column Type</param>
		/// <param name="m3MCC3">Column</param>
		/// <param name="m3MRC3">Column Range</param>
		/// <param name="m3MOC4">Column Type</param>
		/// <param name="m3MCC4">Column</param>
		/// <param name="m3MRC4">Column Range</param>
		/// <param name="m3MOC5">Column Type</param>
		/// <param name="m3MCC5">Column</param>
		/// <param name="m3MRC5">Column Range</param>
		/// <param name="m3MOC6">Column Type</param>
		/// <param name="m3MCC6">Column</param>
		/// <param name="m3MOC7">Column Type</param>
		/// <param name="m3MRC6">Column Range</param>
		/// <param name="m3MCC7">Column</param>
		/// <param name="m3MRC7">Column Rank</param>
		/// <param name="m3MOC8">Column Type</param>
		/// <param name="m3MCC8">Column</param>
		/// <param name="m3MRC8">Column Rank</param>
		/// <param name="m3MOC9">Column Type</param>
		/// <param name="m3MCC9">Column</param>
		/// <param name="m3MRC9">Column Rank</param>
		/// <param name="m3FOR1">Formula result identity</param>
		/// <param name="m3FOR2">Formula result identity</param>
		/// <param name="m3FOR3">Formula result identity</param>
		/// <param name="m3FOR4">Formula result identity</param>
		/// <param name="m3FOR5">Formula result identity</param>
		/// <param name="m3FOR6">Formula result identity</param>
		/// <param name="m3FOR7">Formula result identity</param>
		/// <param name="m3FOR8">Formula result identity</param>
		/// <param name="m3FOR9">Formula result identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Update(
			string m3MXID, 
			int m3MXTP, 
			int? m3CONO = null, 
			string m3TX30 = null, 
			string m3TX15 = null, 
			string m3MGRP = null, 
			string m3RESP = null, 
			string m3UNMS = null, 
			int? m3DSQU = null, 
			string m3DMD1 = null, 
			string m3DMD2 = null, 
			string m3DMD3 = null, 
			int? m3MOC1 = null, 
			string m3MCC1 = null, 
			int? m3MRC1 = null, 
			int? m3MOC2 = null, 
			string m3MCC2 = null, 
			int? m3MRC2 = null, 
			int? m3MOC3 = null, 
			string m3MCC3 = null, 
			int? m3MRC3 = null, 
			int? m3MOC4 = null, 
			string m3MCC4 = null, 
			int? m3MRC4 = null, 
			int? m3MOC5 = null, 
			string m3MCC5 = null, 
			int? m3MRC5 = null, 
			int? m3MOC6 = null, 
			string m3MCC6 = null, 
			int? m3MOC7 = null, 
			int? m3MRC6 = null, 
			string m3MCC7 = null, 
			int? m3MRC7 = null, 
			int? m3MOC8 = null, 
			string m3MCC8 = null, 
			int? m3MRC8 = null, 
			int? m3MOC9 = null, 
			string m3MCC9 = null, 
			int? m3MRC9 = null, 
			string m3FOR1 = null, 
			string m3FOR2 = null, 
			string m3FOR3 = null, 
			string m3FOR4 = null, 
			string m3FOR5 = null, 
			string m3FOR6 = null, 
			string m3FOR7 = null, 
			string m3FOR8 = null, 
			string m3FOR9 = null, 
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

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MXID))
				throw new ArgumentNullException(nameof(m3MXID));

			// Set mandatory parameters
			request
				.WithQueryParameter("MXID", m3MXID.Trim())
				.WithQueryParameter("MXTP", m3MXTP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX30))
				request.WithQueryParameter("TX30", m3TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3MGRP))
				request.WithQueryParameter("MGRP", m3MGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3UNMS))
				request.WithQueryParameter("UNMS", m3UNMS.Trim());
			if (m3DSQU.HasValue)
				request.WithQueryParameter("DSQU", m3DSQU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DMD1))
				request.WithQueryParameter("DMD1", m3DMD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3DMD2))
				request.WithQueryParameter("DMD2", m3DMD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3DMD3))
				request.WithQueryParameter("DMD3", m3DMD3.Trim());
			if (m3MOC1.HasValue)
				request.WithQueryParameter("MOC1", m3MOC1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MCC1))
				request.WithQueryParameter("MCC1", m3MCC1.Trim());
			if (m3MRC1.HasValue)
				request.WithQueryParameter("MRC1", m3MRC1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MOC2.HasValue)
				request.WithQueryParameter("MOC2", m3MOC2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MCC2))
				request.WithQueryParameter("MCC2", m3MCC2.Trim());
			if (m3MRC2.HasValue)
				request.WithQueryParameter("MRC2", m3MRC2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MOC3.HasValue)
				request.WithQueryParameter("MOC3", m3MOC3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MCC3))
				request.WithQueryParameter("MCC3", m3MCC3.Trim());
			if (m3MRC3.HasValue)
				request.WithQueryParameter("MRC3", m3MRC3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MOC4.HasValue)
				request.WithQueryParameter("MOC4", m3MOC4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MCC4))
				request.WithQueryParameter("MCC4", m3MCC4.Trim());
			if (m3MRC4.HasValue)
				request.WithQueryParameter("MRC4", m3MRC4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MOC5.HasValue)
				request.WithQueryParameter("MOC5", m3MOC5.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MCC5))
				request.WithQueryParameter("MCC5", m3MCC5.Trim());
			if (m3MRC5.HasValue)
				request.WithQueryParameter("MRC5", m3MRC5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MOC6.HasValue)
				request.WithQueryParameter("MOC6", m3MOC6.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MCC6))
				request.WithQueryParameter("MCC6", m3MCC6.Trim());
			if (m3MOC7.HasValue)
				request.WithQueryParameter("MOC7", m3MOC7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MRC6.HasValue)
				request.WithQueryParameter("MRC6", m3MRC6.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MCC7))
				request.WithQueryParameter("MCC7", m3MCC7.Trim());
			if (m3MRC7.HasValue)
				request.WithQueryParameter("MRC7", m3MRC7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MOC8.HasValue)
				request.WithQueryParameter("MOC8", m3MOC8.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MCC8))
				request.WithQueryParameter("MCC8", m3MCC8.Trim());
			if (m3MRC8.HasValue)
				request.WithQueryParameter("MRC8", m3MRC8.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MOC9.HasValue)
				request.WithQueryParameter("MOC9", m3MOC9.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MCC9))
				request.WithQueryParameter("MCC9", m3MCC9.Trim());
			if (m3MRC9.HasValue)
				request.WithQueryParameter("MRC9", m3MRC9.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FOR1))
				request.WithQueryParameter("FOR1", m3FOR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FOR2))
				request.WithQueryParameter("FOR2", m3FOR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FOR3))
				request.WithQueryParameter("FOR3", m3FOR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3FOR4))
				request.WithQueryParameter("FOR4", m3FOR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3FOR5))
				request.WithQueryParameter("FOR5", m3FOR5.Trim());
			if (!string.IsNullOrWhiteSpace(m3FOR6))
				request.WithQueryParameter("FOR6", m3FOR6.Trim());
			if (!string.IsNullOrWhiteSpace(m3FOR7))
				request.WithQueryParameter("FOR7", m3FOR7.Trim());
			if (!string.IsNullOrWhiteSpace(m3FOR8))
				request.WithQueryParameter("FOR8", m3FOR8.Trim());
			if (!string.IsNullOrWhiteSpace(m3FOR9))
				request.WithQueryParameter("FOR9", m3FOR9.Trim());

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
		/// Name UpdateLine
		/// Description Update Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MXID">Selection matrix (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MVC1">Value in column 1</param>
		/// <param name="m3MVC2">Value in column 2</param>
		/// <param name="m3MVC3">Value in column 3</param>
		/// <param name="m3MVC4">Value in column 4</param>
		/// <param name="m3MVC5">Value in column 5</param>
		/// <param name="m3MVC6">Value in column 6</param>
		/// <param name="m3FDAT">Valid from</param>
		/// <param name="m3MRC1">Alpha result</param>
		/// <param name="m3MNC1">Numeric result 1</param>
		/// <param name="m3MNC2">Numeric result 2</param>
		/// <param name="m3MNC3">Numeric result 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdateLine(
			string m3MXID, 
			int? m3CONO = null, 
			string m3MVC1 = null, 
			string m3MVC2 = null, 
			string m3MVC3 = null, 
			string m3MVC4 = null, 
			string m3MVC5 = null, 
			string m3MVC6 = null, 
			DateTime? m3FDAT = null, 
			string m3MRC1 = null, 
			decimal? m3MNC1 = null, 
			decimal? m3MNC2 = null, 
			decimal? m3MNC3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdateLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MXID))
				throw new ArgumentNullException(nameof(m3MXID));

			// Set mandatory parameters
			request
				.WithQueryParameter("MXID", m3MXID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MVC1))
				request.WithQueryParameter("MVC1", m3MVC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3MVC2))
				request.WithQueryParameter("MVC2", m3MVC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MVC3))
				request.WithQueryParameter("MVC3", m3MVC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MVC4))
				request.WithQueryParameter("MVC4", m3MVC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3MVC5))
				request.WithQueryParameter("MVC5", m3MVC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3MVC6))
				request.WithQueryParameter("MVC6", m3MVC6.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3MRC1))
				request.WithQueryParameter("MRC1", m3MRC1.Trim());
			if (m3MNC1.HasValue)
				request.WithQueryParameter("MNC1", m3MNC1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MNC2.HasValue)
				request.WithQueryParameter("MNC2", m3MNC2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MNC3.HasValue)
				request.WithQueryParameter("MNC3", m3MNC3.Value.ToString(CultureInfo.CurrentCulture));

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
