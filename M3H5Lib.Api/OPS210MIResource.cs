/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.OPS210MI;
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
	/// Name: OPS210MI
	/// Component Name: POS and SAD
	/// Description: Fnc: External Ticket lines
	/// Version Release: 13.1
	///</summary>
	public partial class OPS210MIResource : M3BaseResourceEndpoint
	{
		public OPS210MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OPS210MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddExtTickLin
		/// Description Add External Ticket lines
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_REFE">Reference (Required)</param>
		/// <param name="m3_TRDT">Transaction date (Required)</param>
		/// <param name="m3_TRTM">Transaction time (Required)</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_SMCD">Salesperson</param>
		/// <param name="m3_PDAN">Net daily rate</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_QTYA">Quantity</param>
		/// <param name="m3_ALUN">Alternate U/M</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_SPUN">Sales price unit of measure</param>
		/// <param name="m3_DIA1">Discount amount 1</param>
		/// <param name="m3_CFC1">User-defined field 1 - customer</param>
		/// <param name="m3_CFC2">User-defined field 2 - customer</param>
		/// <param name="m3_CFC3">User-defined field 3 - customer</param>
		/// <param name="m3_CFC4">User-defined field 4 - customer</param>
		/// <param name="m3_CFC5">User-defined field 5 - customer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddExtTickLin(
			string m3_REFE, 
			DateTime m3_TRDT, 
			int m3_TRTM, 
			string m3_WHLO = null, 
			string m3_CUNO = null, 
			string m3_SMCD = null, 
			decimal? m3_PDAN = null, 
			string m3_ITNO = null, 
			decimal? m3_QTYA = null, 
			string m3_ALUN = null, 
			decimal? m3_SAPR = null, 
			string m3_SPUN = null, 
			decimal? m3_DIA1 = null, 
			string m3_CFC1 = null, 
			decimal? m3_CFC2 = null, 
			string m3_CFC3 = null, 
			string m3_CFC4 = null, 
			string m3_CFC5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddExtTickLin",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_REFE))
				throw new ArgumentNullException("m3_REFE");

			// Set mandatory parameters
			request
				.WithQueryParameter("REFE", m3_REFE.Trim())
				.WithQueryParameter("TRDT", m3_TRDT.ToM3String())
				.WithQueryParameter("TRTM", m3_TRTM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMCD))
				request.WithQueryParameter("SMCD", m3_SMCD.Trim());
			if (m3_PDAN.HasValue)
				request.WithQueryParameter("PDAN", m3_PDAN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_QTYA.HasValue)
				request.WithQueryParameter("QTYA", m3_QTYA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPUN))
				request.WithQueryParameter("SPUN", m3_SPUN.Trim());
			if (m3_DIA1.HasValue)
				request.WithQueryParameter("DIA1", m3_DIA1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFC1))
				request.WithQueryParameter("CFC1", m3_CFC1.Trim());
			if (m3_CFC2.HasValue)
				request.WithQueryParameter("CFC2", m3_CFC2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFC3))
				request.WithQueryParameter("CFC3", m3_CFC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFC4))
				request.WithQueryParameter("CFC4", m3_CFC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFC5))
				request.WithQueryParameter("CFC5", m3_CFC5.Trim());

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
		/// Name CnfExtTickLin
		/// Description Confirm External Ticket lines
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_REFE">Reference (Required)</param>
		/// <param name="m3_TRDT">Transaction date (Required)</param>
		/// <param name="m3_TRTM">Transaction time (Required)</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CnfExtTickLin(
			string m3_REFE, 
			DateTime m3_TRDT, 
			int m3_TRTM, 
			string m3_WHLO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CnfExtTickLin",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_REFE))
				throw new ArgumentNullException("m3_REFE");

			// Set mandatory parameters
			request
				.WithQueryParameter("REFE", m3_REFE.Trim())
				.WithQueryParameter("TRDT", m3_TRDT.ToM3String())
				.WithQueryParameter("TRTM", m3_TRTM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());

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
		/// Name LstExtTickLin
		/// Description List External Ticket lines
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_REFE">Reference</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstExtTickLinResponse></returns>
		/// <exception cref="M3Exception<LstExtTickLinResponse>"></exception>
		public async Task<M3Response<LstExtTickLinResponse>> LstExtTickLin(
			string m3_WHLO = null, 
			string m3_REFE = null, 
			DateTime? m3_TRDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstExtTickLin",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REFE))
				request.WithQueryParameter("REFE", m3_REFE.Trim());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstExtTickLinResponse>(
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
