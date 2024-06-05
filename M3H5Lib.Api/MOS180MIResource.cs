/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MOS180MI;
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
	/// Name: MOS180MI
	/// Component Name: MaintenanceServiceApprove
	/// Description: Maintenance Service Approve
	/// Version Release: 5ea3
	///</summary>
	public partial class MOS180MIResource : M3BaseResourceEndpoint
	{
		public MOS180MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS180MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddServiceHist
		/// Description Add service history
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_BANO">Lot number (Required)</param>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_SVDT">Service date (Required)</param>
		/// <param name="m3_RESP">Responsible (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_MWNO">Work order number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SVTS">Service time</param>
		/// <param name="m3_PRIP">Priority</param>
		/// <param name="m3_ORQA">Ordered quantity - alternate U/M</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_TSTA">Time at/since service</param>
		/// <param name="m3_METE">Selected meter</param>
		/// <param name="m3_MVB1">Actual meter value 1</param>
		/// <param name="m3_MVB2">Actual meter value 2</param>
		/// <param name="m3_MVB3">Actual meter value 3</param>
		/// <param name="m3_MVB4">Actual meter value 4</param>
		/// <param name="m3_APRB">Approved by</param>
		/// <param name="m3_CFI1">User-defined field 1 - item</param>
		/// <param name="m3_CFI2">User-defined field 2 - item</param>
		/// <param name="m3_CFI3">User-defined field 3 - item</param>
		/// <param name="m3_CFI4">User-defined field 4 - item</param>
		/// <param name="m3_CFI5">User-defined field 5 - item</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddServiceHist(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_BANO, 
			string m3_SUFI, 
			DateTime m3_SVDT, 
			string m3_RESP, 
			string m3_WHLO, 
			DateTime m3_STDT, 
			string m3_MWNO = null, 
			string m3_STRT = null, 
			int? m3_SVTS = null, 
			string m3_PRIP = null, 
			decimal? m3_ORQA = null, 
			string m3_RSCD = null, 
			int? m3_TSTA = null, 
			int? m3_METE = null, 
			decimal? m3_MVB1 = null, 
			decimal? m3_MVB2 = null, 
			decimal? m3_MVB3 = null, 
			decimal? m3_MVB4 = null, 
			string m3_APRB = null, 
			string m3_CFI1 = null, 
			decimal? m3_CFI2 = null, 
			string m3_CFI3 = null, 
			string m3_CFI4 = null, 
			string m3_CFI5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddServiceHist",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");
			if (string.IsNullOrWhiteSpace(m3_RESP))
				throw new ArgumentNullException("m3_RESP");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("BANO", m3_BANO.Trim())
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("SVDT", m3_SVDT.ToM3String())
				.WithQueryParameter("RESP", m3_RESP.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MWNO))
				request.WithQueryParameter("MWNO", m3_MWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_SVTS.HasValue)
				request.WithQueryParameter("SVTS", m3_SVTS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRIP))
				request.WithQueryParameter("PRIP", m3_PRIP.Trim());
			if (m3_ORQA.HasValue)
				request.WithQueryParameter("ORQA", m3_ORQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (m3_TSTA.HasValue)
				request.WithQueryParameter("TSTA", m3_TSTA.Value.ToString());
			if (m3_METE.HasValue)
				request.WithQueryParameter("METE", m3_METE.Value.ToString());
			if (m3_MVB1.HasValue)
				request.WithQueryParameter("MVB1", m3_MVB1.Value.ToString());
			if (m3_MVB2.HasValue)
				request.WithQueryParameter("MVB2", m3_MVB2.Value.ToString());
			if (m3_MVB3.HasValue)
				request.WithQueryParameter("MVB3", m3_MVB3.Value.ToString());
			if (m3_MVB4.HasValue)
				request.WithQueryParameter("MVB4", m3_MVB4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_APRB))
				request.WithQueryParameter("APRB", m3_APRB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI1))
				request.WithQueryParameter("CFI1", m3_CFI1.Trim());
			if (m3_CFI2.HasValue)
				request.WithQueryParameter("CFI2", m3_CFI2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFI3))
				request.WithQueryParameter("CFI3", m3_CFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI4))
				request.WithQueryParameter("CFI4", m3_CFI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI5))
				request.WithQueryParameter("CFI5", m3_CFI5.Trim());

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
		/// Name Approve
		/// Description Approve
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_RESP">Responsible (Required)</param>
		/// <param name="m3_APRB">Approved By (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_BANO">Lot no</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TRTM">Transaction time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Approve(
			string m3_FACI, 
			string m3_MWNO, 
			string m3_RESP, 
			string m3_APRB, 
			int? m3_CONO = null, 
			string m3_PRNO = null, 
			string m3_BANO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			DateTime? m3_TRDT = null, 
			int? m3_TRTM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Approve",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");
			if (string.IsNullOrWhiteSpace(m3_RESP))
				throw new ArgumentNullException("m3_RESP");
			if (string.IsNullOrWhiteSpace(m3_APRB))
				throw new ArgumentNullException("m3_APRB");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("RESP", m3_RESP.Trim())
				.WithQueryParameter("APRB", m3_APRB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());

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
		/// Name ListServiceHist
		/// Description ListServiceHist
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_PRNO">Product (Required)</param>
		/// <param name="m3_BANO">Lot number (Required)</param>
		/// <param name="m3_SVDT">Service date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListServiceHistResponse></returns>
		/// <exception cref="M3Exception<ListServiceHistResponse>"></exception>
		public async Task<M3Response<ListServiceHistResponse>> ListServiceHist(
			string m3_PRNO, 
			string m3_BANO, 
			DateTime? m3_SVDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ListServiceHist",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("BANO", m3_BANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_SVDT.HasValue)
				request.WithQueryParameter("SVDT", m3_SVDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<ListServiceHistResponse>(
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
		/// Name ResetApproval
		/// Description ResetApproval
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_MWNO">Work order number</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_PLPN">Planned order</param>
		/// <param name="m3_PLPS">Subnumber - planned order</param>
		/// <param name="m3_PLP2">Subnumber - planned order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ResetApproval(
			string m3_FACI = null, 
			string m3_MWNO = null, 
			string m3_PRNO = null, 
			string m3_BANO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			int? m3_PLPN = null, 
			int? m3_PLPS = null, 
			int? m3_PLP2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ResetApproval",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MWNO))
				request.WithQueryParameter("MWNO", m3_MWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_PLPN.HasValue)
				request.WithQueryParameter("PLPN", m3_PLPN.Value.ToString());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());
			if (m3_PLP2.HasValue)
				request.WithQueryParameter("PLP2", m3_PLP2.Value.ToString());

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
