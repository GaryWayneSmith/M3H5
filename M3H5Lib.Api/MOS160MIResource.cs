/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3MES0">Meter (Required)</param>
		/// <param name="m3CONO">CompanyNumber</param>
		/// <param name="m3ITNO">ItemNumber</param>
		/// <param name="m3SERN">SerialNumber</param>
		/// <param name="m3TAIL">TailNumber</param>
		/// <param name="m3CFGL">ConfigPosition</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMeterValueResponse></returns>
		/// <exception cref="M3Exception<GetMeterValueResponse>"></exception>
		public async Task<M3Response<GetMeterValueResponse>> GetMeterValue(
			string m3MES0, 
			int? m3CONO = null, 
			string m3ITNO = null, 
			string m3SERN = null, 
			string m3TAIL = null, 
			string m3CFGL = null, 
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
			if (string.IsNullOrWhiteSpace(m3MES0))
				throw new ArgumentNullException(nameof(m3MES0));

			// Set mandatory parameters
			request
				.WithQueryParameter("MES0", m3MES0.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAIL))
				request.WithQueryParameter("TAIL", m3TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());

			// Execute the request
			var result = await Execute<GetMeterValueResponse>(
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
		/// Name LstMeterValue
		/// Description Maintenance - List Meter Values
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3MES0">Meter (Required)</param>
		/// <param name="m3CONO">CompanyNumber</param>
		/// <param name="m3ITNO">ItemNumber</param>
		/// <param name="m3SERN">SerialNumber</param>
		/// <param name="m3TAIL">TailNumber</param>
		/// <param name="m3CFGL">ConfigPosition</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMeterValueResponse></returns>
		/// <exception cref="M3Exception<LstMeterValueResponse>"></exception>
		public async Task<M3Response<LstMeterValueResponse>> LstMeterValue(
			string m3MES0, 
			int? m3CONO = null, 
			string m3ITNO = null, 
			string m3SERN = null, 
			string m3TAIL = null, 
			string m3CFGL = null, 
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
			if (string.IsNullOrWhiteSpace(m3MES0))
				throw new ArgumentNullException(nameof(m3MES0));

			// Set mandatory parameters
			request
				.WithQueryParameter("MES0", m3MES0.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAIL))
				request.WithQueryParameter("TAIL", m3TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());

			// Execute the request
			var result = await Execute<LstMeterValueResponse>(
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
		/// Name UpdMeterValue
		/// Description Maintenance - Update meter
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3MES0">Meter (Required)</param>
		/// <param name="m3MVA0">MeterValue (Required)</param>
		/// <param name="m3CONO">CompanyNumber</param>
		/// <param name="m3ITNO">ItemNumber</param>
		/// <param name="m3SERN">SerialNumber</param>
		/// <param name="m3TAIL">TailNumber</param>
		/// <param name="m3CFGL">ConfigPosition</param>
		/// <param name="m3OPCT">OperationCycleType</param>
		/// <param name="m3STDT">StartDate</param>
		/// <param name="m3STTI">StartTime  HHMMSS</param>
		/// <param name="m3ENTM">EndTime    HHMMSS</param>
		/// <param name="m3FCLA">Error code 1</param>
		/// <param name="m3FCL2">Error code 2</param>
		/// <param name="m3FCL3">Error code 3</param>
		/// <param name="m3TIZO">Time zone</param>
		/// <param name="m3MEEV">Meter event</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<UpdMeterValueResponse></returns>
		/// <exception cref="M3Exception<UpdMeterValueResponse>"></exception>
		public async Task<M3Response<UpdMeterValueResponse>> UpdMeterValue(
			string m3MES0, 
			decimal m3MVA0, 
			int? m3CONO = null, 
			string m3ITNO = null, 
			string m3SERN = null, 
			string m3TAIL = null, 
			string m3CFGL = null, 
			string m3OPCT = null, 
			DateTime? m3STDT = null, 
			string m3STTI = null, 
			string m3ENTM = null, 
			string m3FCLA = null, 
			string m3FCL2 = null, 
			string m3FCL3 = null, 
			string m3TIZO = null, 
			string m3MEEV = null, 
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
			if (string.IsNullOrWhiteSpace(m3MES0))
				throw new ArgumentNullException(nameof(m3MES0));

			// Set mandatory parameters
			request
				.WithQueryParameter("MES0", m3MES0.Trim())
				.WithQueryParameter("MVA0", m3MVA0.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAIL))
				request.WithQueryParameter("TAIL", m3TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPCT))
				request.WithQueryParameter("OPCT", m3OPCT.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3STTI))
				request.WithQueryParameter("STTI", m3STTI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ENTM))
				request.WithQueryParameter("ENTM", m3ENTM.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCLA))
				request.WithQueryParameter("FCLA", m3FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL2))
				request.WithQueryParameter("FCL2", m3FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL3))
				request.WithQueryParameter("FCL3", m3FCL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIZO))
				request.WithQueryParameter("TIZO", m3TIZO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEEV))
				request.WithQueryParameter("MEEV", m3MEEV.Trim());

			// Execute the request
			var result = await Execute<UpdMeterValueResponse>(
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
