/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.PDS029MI;
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
	/// Name: PDS029MI
	/// Component Name: Outputs
	/// Description: Output interface
	/// Version Release: 5ea0
	///</summary>
	public partial class PDS029MIResource : M3BaseResourceEndpoint
	{
		public PDS029MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PDS029MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddOutput
		/// Description AddOutput
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3STRT">Product structure type (Required)</param>
		/// <param name="m3OTNO">Output item (Required)</param>
		/// <param name="m3OTQT">Output quantity (Required)</param>
		/// <param name="m3VRSN">Version</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3MAUN">Manufacturing U/M</param>
		/// <param name="m3OTSY">Auto-sync bulk item for item pack</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddOutput(
			string m3FACI, 
			string m3PRNO, 
			string m3STRT, 
			string m3OTNO, 
			decimal m3OTQT, 
			int? m3VRSN = null, 
			int? m3OPNO = null, 
			string m3MAUN = null, 
			int? m3OTSY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddOutput",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3STRT))
				throw new ArgumentNullException(nameof(m3STRT));
			if (string.IsNullOrWhiteSpace(m3OTNO))
				throw new ArgumentNullException(nameof(m3OTNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("STRT", m3STRT.Trim())
				.WithQueryParameter("OTNO", m3OTNO.Trim())
				.WithQueryParameter("OTQT", m3OTQT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3VRSN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MAUN))
				request.WithQueryParameter("MAUN", m3MAUN.Trim());
			if (m3OTSY.HasValue)
				request.WithQueryParameter("OTSY", m3OTSY.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltOutput
		/// Description DltOutput
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3STRT">Product structure type (Required)</param>
		/// <param name="m3OTNO">Output item (Required)</param>
		/// <param name="m3VRSN">Version</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3OTSY">Auto-sync bulk item for item pack</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltOutput(
			string m3FACI, 
			string m3PRNO, 
			string m3STRT, 
			string m3OTNO, 
			int? m3VRSN = null, 
			int? m3OPNO = null, 
			int? m3OTSY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltOutput",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3STRT))
				throw new ArgumentNullException(nameof(m3STRT));
			if (string.IsNullOrWhiteSpace(m3OTNO))
				throw new ArgumentNullException(nameof(m3OTNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("STRT", m3STRT.Trim())
				.WithQueryParameter("OTNO", m3OTNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3VRSN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OTSY.HasValue)
				request.WithQueryParameter("OTSY", m3OTSY.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetOutput
		/// Description GetOutput
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3STRT">Product structure type (Required)</param>
		/// <param name="m3OTNO">Output item (Required)</param>
		/// <param name="m3VRSN">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOutputResponse></returns>
		/// <exception cref="M3Exception<GetOutputResponse>"></exception>
		public async Task<M3Response<GetOutputResponse>> GetOutput(
			string m3FACI, 
			string m3PRNO, 
			string m3STRT, 
			string m3OTNO, 
			int? m3VRSN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetOutput",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3STRT))
				throw new ArgumentNullException(nameof(m3STRT));
			if (string.IsNullOrWhiteSpace(m3OTNO))
				throw new ArgumentNullException(nameof(m3OTNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("STRT", m3STRT.Trim())
				.WithQueryParameter("OTNO", m3OTNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3VRSN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetOutputResponse>(
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
		/// Name LstOutputs
		/// Description LstOutputs
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3VRSN">Version</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3OTNO">Output item</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOutputsResponse></returns>
		/// <exception cref="M3Exception<LstOutputsResponse>"></exception>
		public async Task<M3Response<LstOutputsResponse>> LstOutputs(
			string m3FACI, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3VRSN = null, 
			int? m3OPNO = null, 
			string m3OTNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstOutputs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3VRSN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OTNO))
				request.WithQueryParameter("OTNO", m3OTNO.Trim());

			// Execute the request
			var result = await Execute<LstOutputsResponse>(
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
		/// Name UpdOutput
		/// Description UpdOutput
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3STRT">Product structure type (Required)</param>
		/// <param name="m3OTNO">Output item (Required)</param>
		/// <param name="m3VRSN">Version</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3OTQT">Output quantity</param>
		/// <param name="m3MAUN">Manufacturing U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdOutput(
			string m3FACI, 
			string m3PRNO, 
			string m3STRT, 
			string m3OTNO, 
			int? m3VRSN = null, 
			int? m3OPNO = null, 
			decimal? m3OTQT = null, 
			string m3MAUN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdOutput",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3STRT))
				throw new ArgumentNullException(nameof(m3STRT));
			if (string.IsNullOrWhiteSpace(m3OTNO))
				throw new ArgumentNullException(nameof(m3OTNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("STRT", m3STRT.Trim())
				.WithQueryParameter("OTNO", m3OTNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3VRSN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OTQT.HasValue)
				request.WithQueryParameter("OTQT", m3OTQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MAUN))
				request.WithQueryParameter("MAUN", m3MAUN.Trim());

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
