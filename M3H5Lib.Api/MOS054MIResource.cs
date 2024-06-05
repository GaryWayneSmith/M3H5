/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetSerError
		/// Description Get Service Error Report
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MWNO">WO No. (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSerErrorResponse></returns>
		/// <exception cref="M3Exception<GetSerErrorResponse>"></exception>
		public async Task<M3Response<GetSerErrorResponse>> GetSerError(
			string m3_MWNO, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSerError",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetSerErrorResponse>(
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
		/// Name UpdSerError
		/// Description Upd Service Error Report
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_MWNO">WO No. (Required)</param>
		/// <param name="m3_PRNO">Product (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_BANO">Serial No</param>
		/// <param name="m3_ITNO">Item Causing Failure</param>
		/// <param name="m3_TLX1">Text Item Causing Failure</param>
		/// <param name="m3_TLX2">Text Item Causing Failure</param>
		/// <param name="m3_FCLA">Error code 1</param>
		/// <param name="m3_TLX3">Text Error code 1</param>
		/// <param name="m3_TLX4">Text Error code 1</param>
		/// <param name="m3_FCL2">Error code 2</param>
		/// <param name="m3_TLX5">Text Error code 2</param>
		/// <param name="m3_TLX6">Text Error code 2</param>
		/// <param name="m3_FCL3">Error code 3</param>
		/// <param name="m3_TLX7">Text Error code 3</param>
		/// <param name="m3_TLX8">Text Error code 3</param>
		/// <param name="m3_TLX9">Repair Comments</param>
		/// <param name="m3_TLX0">Repair Comments</param>
		/// <param name="m3_BRDT">Breakdown date</param>
		/// <param name="m3_BRTI">Breakdown time</param>
		/// <param name="m3_MRDT">Ready date</param>
		/// <param name="m3_MRTI">Ready time</param>
		/// <param name="m3_EQDT">Running date</param>
		/// <param name="m3_EQTI">Running time</param>
		/// <param name="m3_SMC0">User defined field 1</param>
		/// <param name="m3_SMC1">User defined field 2</param>
		/// <param name="m3_SMC2">User defined field 3</param>
		/// <param name="m3_SMC3">User defined field 4</param>
		/// <param name="m3_SMC4">User defined field 5</param>
		/// <param name="m3_SMC5">User defined field 6</param>
		/// <param name="m3_SMC6">User defined field 7</param>
		/// <param name="m3_SMC7">User defined field 8</param>
		/// <param name="m3_SMC8">User defined field 9</param>
		/// <param name="m3_SMC9">User defined field 10</param>
		/// <param name="m3_DWPO">Drawing position</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSerError(
			string m3_FACI, 
			string m3_MWNO, 
			string m3_PRNO, 
			int? m3_CONO = null, 
			string m3_BANO = null, 
			string m3_ITNO = null, 
			string m3_TLX1 = null, 
			string m3_TLX2 = null, 
			string m3_FCLA = null, 
			string m3_TLX3 = null, 
			string m3_TLX4 = null, 
			string m3_FCL2 = null, 
			string m3_TLX5 = null, 
			string m3_TLX6 = null, 
			string m3_FCL3 = null, 
			string m3_TLX7 = null, 
			string m3_TLX8 = null, 
			string m3_TLX9 = null, 
			string m3_TLX0 = null, 
			DateTime? m3_BRDT = null, 
			int? m3_BRTI = null, 
			DateTime? m3_MRDT = null, 
			int? m3_MRTI = null, 
			DateTime? m3_EQDT = null, 
			int? m3_EQTI = null, 
			string m3_SMC0 = null, 
			string m3_SMC1 = null, 
			string m3_SMC2 = null, 
			string m3_SMC3 = null, 
			string m3_SMC4 = null, 
			string m3_SMC5 = null, 
			string m3_SMC6 = null, 
			string m3_SMC7 = null, 
			string m3_SMC8 = null, 
			string m3_SMC9 = null, 
			string m3_DWPO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdSerError",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TLX1))
				request.WithQueryParameter("TLX1", m3_TLX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TLX2))
				request.WithQueryParameter("TLX2", m3_TLX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCLA))
				request.WithQueryParameter("FCLA", m3_FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TLX3))
				request.WithQueryParameter("TLX3", m3_TLX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TLX4))
				request.WithQueryParameter("TLX4", m3_TLX4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL2))
				request.WithQueryParameter("FCL2", m3_FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TLX5))
				request.WithQueryParameter("TLX5", m3_TLX5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TLX6))
				request.WithQueryParameter("TLX6", m3_TLX6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL3))
				request.WithQueryParameter("FCL3", m3_FCL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TLX7))
				request.WithQueryParameter("TLX7", m3_TLX7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TLX8))
				request.WithQueryParameter("TLX8", m3_TLX8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TLX9))
				request.WithQueryParameter("TLX9", m3_TLX9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TLX0))
				request.WithQueryParameter("TLX0", m3_TLX0.Trim());
			if (m3_BRDT.HasValue)
				request.WithQueryParameter("BRDT", m3_BRDT.Value.ToM3String());
			if (m3_BRTI.HasValue)
				request.WithQueryParameter("BRTI", m3_BRTI.Value.ToString());
			if (m3_MRDT.HasValue)
				request.WithQueryParameter("MRDT", m3_MRDT.Value.ToM3String());
			if (m3_MRTI.HasValue)
				request.WithQueryParameter("MRTI", m3_MRTI.Value.ToString());
			if (m3_EQDT.HasValue)
				request.WithQueryParameter("EQDT", m3_EQDT.Value.ToM3String());
			if (m3_EQTI.HasValue)
				request.WithQueryParameter("EQTI", m3_EQTI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SMC0))
				request.WithQueryParameter("SMC0", m3_SMC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC1))
				request.WithQueryParameter("SMC1", m3_SMC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC2))
				request.WithQueryParameter("SMC2", m3_SMC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC3))
				request.WithQueryParameter("SMC3", m3_SMC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC4))
				request.WithQueryParameter("SMC4", m3_SMC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC5))
				request.WithQueryParameter("SMC5", m3_SMC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC6))
				request.WithQueryParameter("SMC6", m3_SMC6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC7))
				request.WithQueryParameter("SMC7", m3_SMC7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC8))
				request.WithQueryParameter("SMC8", m3_SMC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC9))
				request.WithQueryParameter("SMC9", m3_SMC9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DWPO))
				request.WithQueryParameter("DWPO", m3_DWPO.Trim());

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
