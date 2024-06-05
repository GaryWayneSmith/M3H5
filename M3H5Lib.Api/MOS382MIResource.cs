/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MOS382MI;
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
	/// Name: MOS382MI
	/// Component Name: MaintenanceOrderAPP
	/// Description: Maintentance order APP interface
	/// Version Release: 14.x
	///</summary>
	public partial class MOS382MIResource : M3BaseResourceEndpoint
	{
		public MOS382MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS382MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name SelOperations
		/// Description Selection of operations
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_MFNO">Manufacturing order number</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelOperationsResponse></returns>
		/// <exception cref="M3Exception<SelOperationsResponse>"></exception>
		public async Task<M3Response<SelOperationsResponse>> SelOperations(
			string m3_FACI, 
			int? m3_CONO = null, 
			string m3_PRNO = null, 
			string m3_MFNO = null, 
			string m3_REAR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelOperations",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MFNO))
				request.WithQueryParameter("MFNO", m3_MFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());

			// Execute the request
			var result = await Execute<SelOperationsResponse>(
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
		/// Name Select
		/// Description Selection of maintenance orders
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACF">From facility (Required)</param>
		/// <param name="m3_FACT">To facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STSF">From status</param>
		/// <param name="m3_STST">To status</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_DATE">Timestamp - Date</param>
		/// <param name="m3_TIME">Timestamp - Time</param>
		/// <param name="m3_SCHH">Scheduling horizon</param>
		/// <param name="m3_FWHS">From warehouse</param>
		/// <param name="m3_TWHS">To warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectResponse></returns>
		/// <exception cref="M3Exception<SelectResponse>"></exception>
		public async Task<M3Response<SelectResponse>> Select(
			string m3_FACF, 
			string m3_FACT, 
			int? m3_CONO = null, 
			int? m3_STSF = null, 
			int? m3_STST = null, 
			string m3_REAR = null, 
			DateTime? m3_DATE = null, 
			int? m3_TIME = null, 
			int? m3_SCHH = null, 
			string m3_FWHS = null, 
			string m3_TWHS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Select",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACF))
				throw new ArgumentNullException("m3_FACF");
			if (string.IsNullOrWhiteSpace(m3_FACT))
				throw new ArgumentNullException("m3_FACT");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACF", m3_FACF.Trim())
				.WithQueryParameter("FACT", m3_FACT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_STSF.HasValue)
				request.WithQueryParameter("STSF", m3_STSF.Value.ToString());
			if (m3_STST.HasValue)
				request.WithQueryParameter("STST", m3_STST.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (m3_DATE.HasValue)
				request.WithQueryParameter("DATE", m3_DATE.Value.ToM3String());
			if (m3_TIME.HasValue)
				request.WithQueryParameter("TIME", m3_TIME.Value.ToString());
			if (m3_SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3_SCHH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FWHS))
				request.WithQueryParameter("FWHS", m3_FWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWHS))
				request.WithQueryParameter("TWHS", m3_TWHS.Trim());

			// Execute the request
			var result = await Execute<SelectResponse>(
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
