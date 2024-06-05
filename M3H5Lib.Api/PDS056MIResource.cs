/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.PDS056MI;
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
	/// Name: PDS056MI
	/// Component Name: ProductFeatureConnectOptions
	/// Description: Product features. Connect options interface
	/// Version Release: 5ea0
	///</summary>
	public partial class PDS056MIResource : M3BaseResourceEndpoint
	{
		public PDS056MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PDS056MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FTID">Feature (Required)</param>
		/// <param name="m3SQNU">Sequence number for sorting (Required)</param>
		/// <param name="m3OPTN">Option (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRII">Print option information</param>
		/// <param name="m3PRFI">Print feature information</param>
		/// <param name="m3PSPR">Print separator prefix</param>
		/// <param name="m3PSES">Print separator suffix</param>
		/// <param name="m3PSEP">Print separator</param>
		/// <param name="m3PRNL">Print on new line</param>
		/// <param name="m3RGBR">RGB-code red</param>
		/// <param name="m3RGBG">RGB-code green</param>
		/// <param name="m3RGBB">RGB-code blue</param>
		/// <param name="m3MTCT">Material category</param>
		/// <param name="m3PINO">GUI picture</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3FTID, 
			int m3SQNU, 
			string m3OPTN, 
			int? m3CONO = null, 
			int? m3PRII = null, 
			int? m3PRFI = null, 
			string m3PSPR = null, 
			string m3PSES = null, 
			string m3PSEP = null, 
			int? m3PRNL = null, 
			int? m3RGBR = null, 
			int? m3RGBG = null, 
			int? m3RGBB = null, 
			string m3MTCT = null, 
			string m3PINO = null, 
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
			if (string.IsNullOrWhiteSpace(m3OPTN))
				throw new ArgumentNullException(nameof(m3OPTN));

			// Set mandatory parameters
			request
				.WithQueryParameter("FTID", m3FTID.Trim())
				.WithQueryParameter("SQNU", m3SQNU.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OPTN", m3OPTN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRII.HasValue)
				request.WithQueryParameter("PRII", m3PRII.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRFI.HasValue)
				request.WithQueryParameter("PRFI", m3PRFI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PSPR))
				request.WithQueryParameter("PSPR", m3PSPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PSES))
				request.WithQueryParameter("PSES", m3PSES.Trim());
			if (!string.IsNullOrWhiteSpace(m3PSEP))
				request.WithQueryParameter("PSEP", m3PSEP.Trim());
			if (m3PRNL.HasValue)
				request.WithQueryParameter("PRNL", m3PRNL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RGBR.HasValue)
				request.WithQueryParameter("RGBR", m3RGBR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RGBG.HasValue)
				request.WithQueryParameter("RGBG", m3RGBG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RGBB.HasValue)
				request.WithQueryParameter("RGBB", m3RGBB.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MTCT))
				request.WithQueryParameter("MTCT", m3MTCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PINO))
				request.WithQueryParameter("PINO", m3PINO.Trim());

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
		/// <param name="m3SQNU">Sequence number for sorting (Required)</param>
		/// <param name="m3OPTN">Option (Required)</param>
		/// <param name="m3CFTI">Feature (Required)</param>
		/// <param name="m3CSQN">Sequence number for sorting (Required)</param>
		/// <param name="m3COPT">Option (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRII">Print option information</param>
		/// <param name="m3PRFI">Print feature information</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Copy(
			string m3FTID, 
			int m3SQNU, 
			string m3OPTN, 
			string m3CFTI, 
			int m3CSQN, 
			string m3COPT, 
			int? m3CONO = null, 
			int? m3PRII = null, 
			int? m3PRFI = null, 
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
			if (string.IsNullOrWhiteSpace(m3OPTN))
				throw new ArgumentNullException(nameof(m3OPTN));
			if (string.IsNullOrWhiteSpace(m3CFTI))
				throw new ArgumentNullException(nameof(m3CFTI));
			if (string.IsNullOrWhiteSpace(m3COPT))
				throw new ArgumentNullException(nameof(m3COPT));

			// Set mandatory parameters
			request
				.WithQueryParameter("FTID", m3FTID.Trim())
				.WithQueryParameter("SQNU", m3SQNU.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OPTN", m3OPTN.Trim())
				.WithQueryParameter("CFTI", m3CFTI.Trim())
				.WithQueryParameter("CSQN", m3CSQN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("COPT", m3COPT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRII.HasValue)
				request.WithQueryParameter("PRII", m3PRII.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRFI.HasValue)
				request.WithQueryParameter("PRFI", m3PRFI.Value.ToString(CultureInfo.CurrentCulture));

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
		/// <param name="m3FTID">Feature (Required)</param>
		/// <param name="m3SQNU">Sequence number for sorting (Required)</param>
		/// <param name="m3OPTN">Option (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3FTID, 
			int m3SQNU, 
			string m3OPTN, 
			int? m3CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3OPTN))
				throw new ArgumentNullException(nameof(m3OPTN));

			// Set mandatory parameters
			request
				.WithQueryParameter("FTID", m3FTID.Trim())
				.WithQueryParameter("SQNU", m3SQNU.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OPTN", m3OPTN.Trim());

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
		/// Name List
		/// Description List
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FTID">Feature (Required)</param>
		/// <param name="m3SQNU">Sequence number for sorting (Required)</param>
		/// <param name="m3OPTN">Option (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3FTID, 
			int m3SQNU, 
			string m3OPTN, 
			int? m3CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3OPTN))
				throw new ArgumentNullException(nameof(m3OPTN));

			// Set mandatory parameters
			request
				.WithQueryParameter("FTID", m3FTID.Trim())
				.WithQueryParameter("SQNU", m3SQNU.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OPTN", m3OPTN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Retrieve
		/// Description Retrieve
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FTID">Feature (Required)</param>
		/// <param name="m3SQNU">Sequence number for sorting (Required)</param>
		/// <param name="m3OPTN">Option (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<RetrieveResponse></returns>
		/// <exception cref="M3Exception<RetrieveResponse>"></exception>
		public async Task<M3Response<RetrieveResponse>> Retrieve(
			string m3FTID, 
			int m3SQNU, 
			string m3OPTN, 
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Retrieve",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FTID))
				throw new ArgumentNullException(nameof(m3FTID));
			if (string.IsNullOrWhiteSpace(m3OPTN))
				throw new ArgumentNullException(nameof(m3OPTN));

			// Set mandatory parameters
			request
				.WithQueryParameter("FTID", m3FTID.Trim())
				.WithQueryParameter("SQNU", m3SQNU.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OPTN", m3OPTN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<RetrieveResponse>(
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
		/// Name Revise
		/// Description Revise
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FTID">Feature (Required)</param>
		/// <param name="m3SQNU">Sequence number for sorting (Required)</param>
		/// <param name="m3OPTN">Option (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRII">Print option information</param>
		/// <param name="m3PRFI">Print feature information</param>
		/// <param name="m3PSPR">Print separator prefix</param>
		/// <param name="m3PSES">Print separator suffix</param>
		/// <param name="m3PSEP">Print separator</param>
		/// <param name="m3PRNL">Print on new line</param>
		/// <param name="m3RGBR">RGB-code red</param>
		/// <param name="m3RGBG">RGB-code green</param>
		/// <param name="m3RGBB">RGB-code blue</param>
		/// <param name="m3MTCT">Material category</param>
		/// <param name="m3PINO">GUI picture</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Revise(
			string m3FTID, 
			int m3SQNU, 
			string m3OPTN, 
			int? m3CONO = null, 
			int? m3PRII = null, 
			int? m3PRFI = null, 
			string m3PSPR = null, 
			string m3PSES = null, 
			string m3PSEP = null, 
			int? m3PRNL = null, 
			int? m3RGBR = null, 
			int? m3RGBG = null, 
			int? m3RGBB = null, 
			string m3MTCT = null, 
			string m3PINO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Revise",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FTID))
				throw new ArgumentNullException(nameof(m3FTID));
			if (string.IsNullOrWhiteSpace(m3OPTN))
				throw new ArgumentNullException(nameof(m3OPTN));

			// Set mandatory parameters
			request
				.WithQueryParameter("FTID", m3FTID.Trim())
				.WithQueryParameter("SQNU", m3SQNU.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OPTN", m3OPTN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRII.HasValue)
				request.WithQueryParameter("PRII", m3PRII.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRFI.HasValue)
				request.WithQueryParameter("PRFI", m3PRFI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PSPR))
				request.WithQueryParameter("PSPR", m3PSPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PSES))
				request.WithQueryParameter("PSES", m3PSES.Trim());
			if (!string.IsNullOrWhiteSpace(m3PSEP))
				request.WithQueryParameter("PSEP", m3PSEP.Trim());
			if (m3PRNL.HasValue)
				request.WithQueryParameter("PRNL", m3PRNL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RGBR.HasValue)
				request.WithQueryParameter("RGBR", m3RGBR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RGBG.HasValue)
				request.WithQueryParameter("RGBG", m3RGBG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RGBB.HasValue)
				request.WithQueryParameter("RGBB", m3RGBB.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MTCT))
				request.WithQueryParameter("MTCT", m3MTCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PINO))
				request.WithQueryParameter("PINO", m3PINO.Trim());

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
