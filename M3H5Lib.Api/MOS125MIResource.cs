/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
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
	/// Name: MOS125MI
	/// Component Name: MaintenanceRemoveInstall
	/// Description: Maintenance Removal Installation
	/// Version Release: 14.x
	///</summary>
	public partial class MOS125MIResource : M3BaseResourceEndpoint
	{
		public MOS125MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS125MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name RemoveInstall
		/// Description RemoveInstall
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RITP">Removal/installation transaction type (Required)</param>
		/// <param name="m3_RESP">Responsible (Required)</param>
		/// <param name="m3_TRDT">Transaction date (Required)</param>
		/// <param name="m3_TRTM">Transaction time (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_RSC4">Removal reason (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="m3_DEID">Complaint id</param>
		/// <param name="m3_ACNO">Certificate reference number</param>
		/// <param name="m3_TAIL">Registration number/site remove</param>
		/// <param name="m3_NHAR">Next item number remove</param>
		/// <param name="m3_NHSR">Next serial number remove</param>
		/// <param name="m3_CFGR">Configuration position remove</param>
		/// <param name="m3_ITNR">Item number remove</param>
		/// <param name="m3_BANR">Lot number remove</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_TAI1">Registration number/site install</param>
		/// <param name="m3_NHAI">Next item number install</param>
		/// <param name="m3_NHSI">Next serial number install</param>
		/// <param name="m3_CFGL">Configuration position install</param>
		/// <param name="m3_ITNI">Item number install</param>
		/// <param name="m3_BANI">Lot number install</param>
		/// <param name="m3_DWNO">Drawing number</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RemoveInstall(
			string m3_RITP, 
			string m3_RESP, 
			DateTime m3_TRDT, 
			int m3_TRTM, 
			string m3_WHLO, 
			string m3_RSC4, 
			int? m3_CONO = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_TWSL = null, 
			int? m3_DEID = null, 
			string m3_ACNO = null, 
			string m3_TAIL = null, 
			string m3_NHAR = null, 
			string m3_NHSR = null, 
			string m3_CFGR = null, 
			string m3_ITNR = null, 
			string m3_BANR = null, 
			string m3_BREM = null, 
			string m3_WHSL = null, 
			string m3_TAI1 = null, 
			string m3_NHAI = null, 
			string m3_NHSI = null, 
			string m3_CFGL = null, 
			string m3_ITNI = null, 
			string m3_BANI = null, 
			string m3_DWNO = null, 
			int? m3_MSEQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RemoveInstall",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RITP))
				throw new ArgumentNullException("m3_RITP");
			if (string.IsNullOrWhiteSpace(m3_RESP))
				throw new ArgumentNullException("m3_RESP");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_RSC4))
				throw new ArgumentNullException("m3_RSC4");

			// Set mandatory parameters
			request
				.WithQueryParameter("RITP", m3_RITP.Trim())
				.WithQueryParameter("RESP", m3_RESP.Trim())
				.WithQueryParameter("TRDT", m3_TRDT.ToM3String())
				.WithQueryParameter("TRTM", m3_TRTM.ToString())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("RSC4", m3_RSC4.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (m3_DEID.HasValue)
				request.WithQueryParameter("DEID", m3_DEID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACNO))
				request.WithQueryParameter("ACNO", m3_ACNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAIL))
				request.WithQueryParameter("TAIL", m3_TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NHAR))
				request.WithQueryParameter("NHAR", m3_NHAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NHSR))
				request.WithQueryParameter("NHSR", m3_NHSR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGR))
				request.WithQueryParameter("CFGR", m3_CFGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNR))
				request.WithQueryParameter("ITNR", m3_ITNR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANR))
				request.WithQueryParameter("BANR", m3_BANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAI1))
				request.WithQueryParameter("TAI1", m3_TAI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NHAI))
				request.WithQueryParameter("NHAI", m3_NHAI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NHSI))
				request.WithQueryParameter("NHSI", m3_NHSI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNI))
				request.WithQueryParameter("ITNI", m3_ITNI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANI))
				request.WithQueryParameter("BANI", m3_BANI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DWNO))
				request.WithQueryParameter("DWNO", m3_DWNO.Trim());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());

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
