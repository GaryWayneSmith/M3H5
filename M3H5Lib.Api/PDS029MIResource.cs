/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddOutput
		/// Description AddOutput
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product (Required)</param>
		/// <param name="m3_STRT">Product structure type (Required)</param>
		/// <param name="m3_OTNO">Output item (Required)</param>
		/// <param name="m3_OTQT">Output quantity (Required)</param>
		/// <param name="m3_VRSN">Version</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_MAUN">Manufacturing U/M</param>
		/// <param name="m3_OTSY">Auto-sync bulk item for item pack</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddOutput(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_STRT, 
			string m3_OTNO, 
			decimal m3_OTQT, 
			int? m3_VRSN = null, 
			int? m3_OPNO = null, 
			string m3_MAUN = null, 
			int? m3_OTSY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddOutput",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_STRT))
				throw new ArgumentNullException("m3_STRT");
			if (string.IsNullOrWhiteSpace(m3_OTNO))
				throw new ArgumentNullException("m3_OTNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("STRT", m3_STRT.Trim())
				.WithQueryParameter("OTNO", m3_OTNO.Trim())
				.WithQueryParameter("OTQT", m3_OTQT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3_VRSN.Value.ToString());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MAUN))
				request.WithQueryParameter("MAUN", m3_MAUN.Trim());
			if (m3_OTSY.HasValue)
				request.WithQueryParameter("OTSY", m3_OTSY.Value.ToString());

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
		/// Name DltOutput
		/// Description DltOutput
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product (Required)</param>
		/// <param name="m3_STRT">Product structure type (Required)</param>
		/// <param name="m3_OTNO">Output item (Required)</param>
		/// <param name="m3_VRSN">Version</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_OTSY">Auto-sync bulk item for item pack</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltOutput(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_STRT, 
			string m3_OTNO, 
			int? m3_VRSN = null, 
			int? m3_OPNO = null, 
			int? m3_OTSY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltOutput",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_STRT))
				throw new ArgumentNullException("m3_STRT");
			if (string.IsNullOrWhiteSpace(m3_OTNO))
				throw new ArgumentNullException("m3_OTNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("STRT", m3_STRT.Trim())
				.WithQueryParameter("OTNO", m3_OTNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3_VRSN.Value.ToString());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_OTSY.HasValue)
				request.WithQueryParameter("OTSY", m3_OTSY.Value.ToString());

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
		/// Name GetOutput
		/// Description GetOutput
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product (Required)</param>
		/// <param name="m3_STRT">Product structure type (Required)</param>
		/// <param name="m3_OTNO">Output item (Required)</param>
		/// <param name="m3_VRSN">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOutputResponse></returns>
		/// <exception cref="M3Exception<GetOutputResponse>"></exception>
		public async Task<M3Response<GetOutputResponse>> GetOutput(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_STRT, 
			string m3_OTNO, 
			int? m3_VRSN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetOutput",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_STRT))
				throw new ArgumentNullException("m3_STRT");
			if (string.IsNullOrWhiteSpace(m3_OTNO))
				throw new ArgumentNullException("m3_OTNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("STRT", m3_STRT.Trim())
				.WithQueryParameter("OTNO", m3_OTNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3_VRSN.Value.ToString());

			// Execute the request
			var result = await Execute<GetOutputResponse>(
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
		/// Name LstOutputs
		/// Description LstOutputs
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_VRSN">Version</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_OTNO">Output item</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOutputsResponse></returns>
		/// <exception cref="M3Exception<LstOutputsResponse>"></exception>
		public async Task<M3Response<LstOutputsResponse>> LstOutputs(
			string m3_FACI, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_VRSN = null, 
			int? m3_OPNO = null, 
			string m3_OTNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstOutputs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3_VRSN.Value.ToString());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OTNO))
				request.WithQueryParameter("OTNO", m3_OTNO.Trim());

			// Execute the request
			var result = await Execute<LstOutputsResponse>(
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
		/// Name UpdOutput
		/// Description UpdOutput
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product (Required)</param>
		/// <param name="m3_STRT">Product structure type (Required)</param>
		/// <param name="m3_OTNO">Output item (Required)</param>
		/// <param name="m3_VRSN">Version</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_OTQT">Output quantity</param>
		/// <param name="m3_MAUN">Manufacturing U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdOutput(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_STRT, 
			string m3_OTNO, 
			int? m3_VRSN = null, 
			int? m3_OPNO = null, 
			decimal? m3_OTQT = null, 
			string m3_MAUN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdOutput",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_STRT))
				throw new ArgumentNullException("m3_STRT");
			if (string.IsNullOrWhiteSpace(m3_OTNO))
				throw new ArgumentNullException("m3_OTNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("STRT", m3_STRT.Trim())
				.WithQueryParameter("OTNO", m3_OTNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3_VRSN.Value.ToString());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_OTQT.HasValue)
				request.WithQueryParameter("OTQT", m3_OTQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MAUN))
				request.WithQueryParameter("MAUN", m3_MAUN.Trim());

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
