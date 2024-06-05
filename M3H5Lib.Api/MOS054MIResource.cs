/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.MOS054MI;
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
	/// Name: MOS054MI
	/// Component Name: Service Error Report
	/// Description: Api: Service Error Report
	/// Version Release: 14.x
	///</summary>
	public partial class MOS054MIResource : M3BaseResourceEndpoint
	{
		public MOS054MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS054MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetSerError
		/// Description Get Service Error Report
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MWNO">WO No. (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSerErrorResponse></returns>
		/// <exception cref="M3Exception<GetSerErrorResponse>"></exception>
		public async Task<M3Response<GetSerErrorResponse>> GetSerError(
			string m3MWNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetSerError",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetSerErrorResponse>(
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
		/// Name UpdSerError
		/// Description Upd Service Error Report
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3MWNO">WO No. (Required)</param>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3BANO">Serial No</param>
		/// <param name="m3ITNO">Item Causing Failure</param>
		/// <param name="m3TLX1">Text Item Causing Failure</param>
		/// <param name="m3TLX2">Text Item Causing Failure</param>
		/// <param name="m3FCLA">Error code 1</param>
		/// <param name="m3TLX3">Text Error code 1</param>
		/// <param name="m3TLX4">Text Error code 1</param>
		/// <param name="m3FCL2">Error code 2</param>
		/// <param name="m3TLX5">Text Error code 2</param>
		/// <param name="m3TLX6">Text Error code 2</param>
		/// <param name="m3FCL3">Error code 3</param>
		/// <param name="m3TLX7">Text Error code 3</param>
		/// <param name="m3TLX8">Text Error code 3</param>
		/// <param name="m3TLX9">Repair Comments</param>
		/// <param name="m3TLX0">Repair Comments</param>
		/// <param name="m3BRDT">Breakdown date</param>
		/// <param name="m3BRTI">Breakdown time</param>
		/// <param name="m3MRDT">Ready date</param>
		/// <param name="m3MRTI">Ready time</param>
		/// <param name="m3EQDT">Running date</param>
		/// <param name="m3EQTI">Running time</param>
		/// <param name="m3SMC0">User defined field 1</param>
		/// <param name="m3SMC1">User defined field 2</param>
		/// <param name="m3SMC2">User defined field 3</param>
		/// <param name="m3SMC3">User defined field 4</param>
		/// <param name="m3SMC4">User defined field 5</param>
		/// <param name="m3SMC5">User defined field 6</param>
		/// <param name="m3SMC6">User defined field 7</param>
		/// <param name="m3SMC7">User defined field 8</param>
		/// <param name="m3SMC8">User defined field 9</param>
		/// <param name="m3SMC9">User defined field 10</param>
		/// <param name="m3DWPO">Drawing position</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSerError(
			string m3FACI, 
			string m3MWNO, 
			string m3PRNO, 
			int? m3CONO = null, 
			string m3BANO = null, 
			string m3ITNO = null, 
			string m3TLX1 = null, 
			string m3TLX2 = null, 
			string m3FCLA = null, 
			string m3TLX3 = null, 
			string m3TLX4 = null, 
			string m3FCL2 = null, 
			string m3TLX5 = null, 
			string m3TLX6 = null, 
			string m3FCL3 = null, 
			string m3TLX7 = null, 
			string m3TLX8 = null, 
			string m3TLX9 = null, 
			string m3TLX0 = null, 
			DateTime? m3BRDT = null, 
			int? m3BRTI = null, 
			DateTime? m3MRDT = null, 
			int? m3MRTI = null, 
			DateTime? m3EQDT = null, 
			int? m3EQTI = null, 
			string m3SMC0 = null, 
			string m3SMC1 = null, 
			string m3SMC2 = null, 
			string m3SMC3 = null, 
			string m3SMC4 = null, 
			string m3SMC5 = null, 
			string m3SMC6 = null, 
			string m3SMC7 = null, 
			string m3SMC8 = null, 
			string m3SMC9 = null, 
			string m3DWPO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdSerError",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TLX1))
				request.WithQueryParameter("TLX1", m3TLX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TLX2))
				request.WithQueryParameter("TLX2", m3TLX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCLA))
				request.WithQueryParameter("FCLA", m3FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3TLX3))
				request.WithQueryParameter("TLX3", m3TLX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3TLX4))
				request.WithQueryParameter("TLX4", m3TLX4.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL2))
				request.WithQueryParameter("FCL2", m3FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TLX5))
				request.WithQueryParameter("TLX5", m3TLX5.Trim());
			if (!string.IsNullOrWhiteSpace(m3TLX6))
				request.WithQueryParameter("TLX6", m3TLX6.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL3))
				request.WithQueryParameter("FCL3", m3FCL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3TLX7))
				request.WithQueryParameter("TLX7", m3TLX7.Trim());
			if (!string.IsNullOrWhiteSpace(m3TLX8))
				request.WithQueryParameter("TLX8", m3TLX8.Trim());
			if (!string.IsNullOrWhiteSpace(m3TLX9))
				request.WithQueryParameter("TLX9", m3TLX9.Trim());
			if (!string.IsNullOrWhiteSpace(m3TLX0))
				request.WithQueryParameter("TLX0", m3TLX0.Trim());
			if (m3BRDT.HasValue)
				request.WithQueryParameter("BRDT", m3BRDT.Value.ToM3String());
			if (m3BRTI.HasValue)
				request.WithQueryParameter("BRTI", m3BRTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MRDT.HasValue)
				request.WithQueryParameter("MRDT", m3MRDT.Value.ToM3String());
			if (m3MRTI.HasValue)
				request.WithQueryParameter("MRTI", m3MRTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EQDT.HasValue)
				request.WithQueryParameter("EQDT", m3EQDT.Value.ToM3String());
			if (m3EQTI.HasValue)
				request.WithQueryParameter("EQTI", m3EQTI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SMC0))
				request.WithQueryParameter("SMC0", m3SMC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC1))
				request.WithQueryParameter("SMC1", m3SMC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC2))
				request.WithQueryParameter("SMC2", m3SMC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC3))
				request.WithQueryParameter("SMC3", m3SMC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC4))
				request.WithQueryParameter("SMC4", m3SMC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC5))
				request.WithQueryParameter("SMC5", m3SMC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC6))
				request.WithQueryParameter("SMC6", m3SMC6.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC7))
				request.WithQueryParameter("SMC7", m3SMC7.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC8))
				request.WithQueryParameter("SMC8", m3SMC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC9))
				request.WithQueryParameter("SMC9", m3SMC9.Trim());
			if (!string.IsNullOrWhiteSpace(m3DWPO))
				request.WithQueryParameter("DWPO", m3DWPO.Trim());

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
