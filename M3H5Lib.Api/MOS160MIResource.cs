/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MOS160MI;
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
	/// Name: MOS160MI
	/// Component Name: MaintenanceMeter
	/// Description: Maintenance meter interface
	/// Version Release: 5ea1
	///</summary>
	public partial class MOS160MIResource : M3BaseResourceEndpoint
	{
		public MOS160MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS160MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetMeterValue
		/// Description Maintenance - Get Meter Value
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_MES0">Meter (Required)</param>
		/// <param name="m3_CONO">CompanyNumber</param>
		/// <param name="m3_ITNO">ItemNumber</param>
		/// <param name="m3_SERN">SerialNumber</param>
		/// <param name="m3_TAIL">TailNumber</param>
		/// <param name="m3_CFGL">ConfigPosition</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMeterValueResponse></returns>
		/// <exception cref="M3Exception<GetMeterValueResponse>"></exception>
		public async Task<M3Response<GetMeterValueResponse>> GetMeterValue(
			string m3_MES0, 
			int? m3_CONO = null, 
			string m3_ITNO = null, 
			string m3_SERN = null, 
			string m3_TAIL = null, 
			string m3_CFGL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMeterValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MES0))
				throw new ArgumentNullException("m3_MES0");

			// Set mandatory parameters
			request
				.WithQueryParameter("MES0", m3_MES0.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAIL))
				request.WithQueryParameter("TAIL", m3_TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());

			// Execute the request
			var result = await Execute<GetMeterValueResponse>(
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
		/// Name LstMeterValue
		/// Description Maintenance - List Meter Values
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_MES0">Meter (Required)</param>
		/// <param name="m3_CONO">CompanyNumber</param>
		/// <param name="m3_ITNO">ItemNumber</param>
		/// <param name="m3_SERN">SerialNumber</param>
		/// <param name="m3_TAIL">TailNumber</param>
		/// <param name="m3_CFGL">ConfigPosition</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMeterValueResponse></returns>
		/// <exception cref="M3Exception<LstMeterValueResponse>"></exception>
		public async Task<M3Response<LstMeterValueResponse>> LstMeterValue(
			string m3_MES0, 
			int? m3_CONO = null, 
			string m3_ITNO = null, 
			string m3_SERN = null, 
			string m3_TAIL = null, 
			string m3_CFGL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMeterValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MES0))
				throw new ArgumentNullException("m3_MES0");

			// Set mandatory parameters
			request
				.WithQueryParameter("MES0", m3_MES0.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAIL))
				request.WithQueryParameter("TAIL", m3_TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());

			// Execute the request
			var result = await Execute<LstMeterValueResponse>(
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
		/// Name UpdMeterValue
		/// Description Maintenance - Update meter
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_MES0">Meter (Required)</param>
		/// <param name="m3_MVA0">MeterValue (Required)</param>
		/// <param name="m3_CONO">CompanyNumber</param>
		/// <param name="m3_ITNO">ItemNumber</param>
		/// <param name="m3_SERN">SerialNumber</param>
		/// <param name="m3_TAIL">TailNumber</param>
		/// <param name="m3_CFGL">ConfigPosition</param>
		/// <param name="m3_OPCT">OperationCycleType</param>
		/// <param name="m3_STDT">StartDate</param>
		/// <param name="m3_STTI">StartTime  HHMMSS</param>
		/// <param name="m3_ENTM">EndTime    HHMMSS</param>
		/// <param name="m3_FCLA">Error code 1</param>
		/// <param name="m3_FCL2">Error code 2</param>
		/// <param name="m3_FCL3">Error code 3</param>
		/// <param name="m3_TIZO">Time zone</param>
		/// <param name="m3_MEEV">Meter event</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<UpdMeterValueResponse></returns>
		/// <exception cref="M3Exception<UpdMeterValueResponse>"></exception>
		public async Task<M3Response<UpdMeterValueResponse>> UpdMeterValue(
			string m3_MES0, 
			decimal m3_MVA0, 
			int? m3_CONO = null, 
			string m3_ITNO = null, 
			string m3_SERN = null, 
			string m3_TAIL = null, 
			string m3_CFGL = null, 
			string m3_OPCT = null, 
			DateTime? m3_STDT = null, 
			string m3_STTI = null, 
			string m3_ENTM = null, 
			string m3_FCLA = null, 
			string m3_FCL2 = null, 
			string m3_FCL3 = null, 
			string m3_TIZO = null, 
			string m3_MEEV = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdMeterValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MES0))
				throw new ArgumentNullException("m3_MES0");

			// Set mandatory parameters
			request
				.WithQueryParameter("MES0", m3_MES0.Trim())
				.WithQueryParameter("MVA0", m3_MVA0.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAIL))
				request.WithQueryParameter("TAIL", m3_TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPCT))
				request.WithQueryParameter("OPCT", m3_OPCT.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_STTI))
				request.WithQueryParameter("STTI", m3_STTI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ENTM))
				request.WithQueryParameter("ENTM", m3_ENTM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCLA))
				request.WithQueryParameter("FCLA", m3_FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL2))
				request.WithQueryParameter("FCL2", m3_FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL3))
				request.WithQueryParameter("FCL3", m3_FCL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIZO))
				request.WithQueryParameter("TIZO", m3_TIZO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEEV))
				request.WithQueryParameter("MEEV", m3_MEEV.Trim());

			// Execute the request
			var result = await Execute<UpdMeterValueResponse>(
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
