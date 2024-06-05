/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddSim
		/// Description Create simulation based on Attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3CFIN">Configuration number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddSimResponse></returns>
		/// <exception cref="M3Exception<AddSimResponse>"></exception>
		public async Task<M3Response<AddSimResponse>> AddSim(
			string m3ORNO, 
			int m3PONR, 
			int? m3POSX = null, 
			long? m3CFIN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddSim",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3CFIN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddSimResponse>(
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
		/// Name SelSimConf
		/// Description Select Simulation Conf - Materials and Operations
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3CFIN">Configuration number (Required)</param>
		/// <param name="m3ECVS">Version number</param>
		/// <param name="m3SMFN">Simulated manufacturing order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelSimConfResponse></returns>
		/// <exception cref="M3Exception<SelSimConfResponse>"></exception>
		public async Task<M3Response<SelSimConfResponse>> SelSimConf(
			string m3FACI, 
			string m3PRNO, 
			long m3CFIN, 
			int? m3ECVS = null, 
			int? m3SMFN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelSimConf",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("CFIN", m3CFIN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3ECVS.HasValue)
				request.WithQueryParameter("ECVS", m3ECVS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SMFN.HasValue)
				request.WithQueryParameter("SMFN", m3SMFN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelSimConfResponse>(
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
