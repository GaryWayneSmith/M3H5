/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.QUAMSIMI;
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
	/// Name: QUAMSIMI
	/// Component Name: QUAMSimulation
	/// Description: QUAM simulation
	/// Version Release: 14.x
	///</summary>
	public partial class QUAMSIMIResource : M3BaseResourceEndpoint
	{
		public QUAMSIMIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QUAMSIMI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddSim
		/// Description Create simulation based on Attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_CFIN">Configuration number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddSimResponse></returns>
		/// <exception cref="M3Exception<AddSimResponse>"></exception>
		public async Task<M3Response<AddSimResponse>> AddSim(
			string m3_ORNO, 
			int m3_PONR, 
			int? m3_POSX = null, 
			long? m3_CFIN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSim",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (m3_CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3_CFIN.Value.ToString());

			// Execute the request
			var result = await Execute<AddSimResponse>(
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
		/// Name SelSimConf
		/// Description Select Simulation Conf - Materials and Operations
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_CFIN">Configuration number (Required)</param>
		/// <param name="m3_ECVS">Version number</param>
		/// <param name="m3_SMFN">Simulated manufacturing order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelSimConfResponse></returns>
		/// <exception cref="M3Exception<SelSimConfResponse>"></exception>
		public async Task<M3Response<SelSimConfResponse>> SelSimConf(
			string m3_FACI, 
			string m3_PRNO, 
			long m3_CFIN, 
			int? m3_ECVS = null, 
			int? m3_SMFN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelSimConf",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("CFIN", m3_CFIN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_ECVS.HasValue)
				request.WithQueryParameter("ECVS", m3_ECVS.Value.ToString());
			if (m3_SMFN.HasValue)
				request.WithQueryParameter("SMFN", m3_SMFN.Value.ToString());

			// Execute the request
			var result = await Execute<SelSimConfResponse>(
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
