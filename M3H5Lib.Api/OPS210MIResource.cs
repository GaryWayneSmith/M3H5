/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddExtTickLin
		/// Description Add External Ticket lines
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3REFE">Reference (Required)</param>
		/// <param name="m3TRDT">Transaction date (Required)</param>
		/// <param name="m3TRTM">Transaction time (Required)</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3SMCD">Salesperson</param>
		/// <param name="m3PDAN">Net daily rate</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3QTYA">Quantity</param>
		/// <param name="m3ALUN">Alternate U/M</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3SPUN">Sales price unit of measure</param>
		/// <param name="m3DIA1">Discount amount 1</param>
		/// <param name="m3CFC1">User-defined field 1 - customer</param>
		/// <param name="m3CFC2">User-defined field 2 - customer</param>
		/// <param name="m3CFC3">User-defined field 3 - customer</param>
		/// <param name="m3CFC4">User-defined field 4 - customer</param>
		/// <param name="m3CFC5">User-defined field 5 - customer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddExtTickLin(
			string m3REFE, 
			DateTime m3TRDT, 
			int m3TRTM, 
			string m3WHLO = null, 
			string m3CUNO = null, 
			string m3SMCD = null, 
			decimal? m3PDAN = null, 
			string m3ITNO = null, 
			decimal? m3QTYA = null, 
			string m3ALUN = null, 
			decimal? m3SAPR = null, 
			string m3SPUN = null, 
			decimal? m3DIA1 = null, 
			string m3CFC1 = null, 
			decimal? m3CFC2 = null, 
			string m3CFC3 = null, 
			string m3CFC4 = null, 
			string m3CFC5 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddExtTickLin",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3REFE))
				throw new ArgumentNullException(nameof(m3REFE));

			// Set mandatory parameters
			request
				.WithQueryParameter("REFE", m3REFE.Trim())
				.WithQueryParameter("TRDT", m3TRDT.ToM3String())
				.WithQueryParameter("TRTM", m3TRTM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMCD))
				request.WithQueryParameter("SMCD", m3SMCD.Trim());
			if (m3PDAN.HasValue)
				request.WithQueryParameter("PDAN", m3PDAN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3QTYA.HasValue)
				request.WithQueryParameter("QTYA", m3QTYA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALUN))
				request.WithQueryParameter("ALUN", m3ALUN.Trim());
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPUN))
				request.WithQueryParameter("SPUN", m3SPUN.Trim());
			if (m3DIA1.HasValue)
				request.WithQueryParameter("DIA1", m3DIA1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFC1))
				request.WithQueryParameter("CFC1", m3CFC1.Trim());
			if (m3CFC2.HasValue)
				request.WithQueryParameter("CFC2", m3CFC2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFC3))
				request.WithQueryParameter("CFC3", m3CFC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFC4))
				request.WithQueryParameter("CFC4", m3CFC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFC5))
				request.WithQueryParameter("CFC5", m3CFC5.Trim());

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
		/// Name CnfExtTickLin
		/// Description Confirm External Ticket lines
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3REFE">Reference (Required)</param>
		/// <param name="m3TRDT">Transaction date (Required)</param>
		/// <param name="m3TRTM">Transaction time (Required)</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CnfExtTickLin(
			string m3REFE, 
			DateTime m3TRDT, 
			int m3TRTM, 
			string m3WHLO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CnfExtTickLin",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3REFE))
				throw new ArgumentNullException(nameof(m3REFE));

			// Set mandatory parameters
			request
				.WithQueryParameter("REFE", m3REFE.Trim())
				.WithQueryParameter("TRDT", m3TRDT.ToM3String())
				.WithQueryParameter("TRTM", m3TRTM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());

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
		/// Name LstExtTickLin
		/// Description List External Ticket lines
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3REFE">Reference</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstExtTickLinResponse></returns>
		/// <exception cref="M3Exception<LstExtTickLinResponse>"></exception>
		public async Task<M3Response<LstExtTickLinResponse>> LstExtTickLin(
			string m3WHLO = null, 
			string m3REFE = null, 
			DateTime? m3TRDT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstExtTickLin",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3REFE))
				request.WithQueryParameter("REFE", m3REFE.Trim());
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstExtTickLinResponse>(
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
