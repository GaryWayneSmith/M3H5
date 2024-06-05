/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name RemoveInstall
		/// Description RemoveInstall
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3RITP">Removal/installation transaction type (Required)</param>
		/// <param name="m3RESP">Responsible (Required)</param>
		/// <param name="m3TRDT">Transaction date (Required)</param>
		/// <param name="m3TRTM">Transaction time (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3RSC4">Removal reason (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="m3DEID">Complaint id</param>
		/// <param name="m3ACNO">Certificate reference number</param>
		/// <param name="m3TAIL">Registration number/site remove</param>
		/// <param name="m3NHAR">Next item number remove</param>
		/// <param name="m3NHSR">Next serial number remove</param>
		/// <param name="m3CFGR">Configuration position remove</param>
		/// <param name="m3ITNR">Item number remove</param>
		/// <param name="m3BANR">Lot number remove</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3TAI1">Registration number/site install</param>
		/// <param name="m3NHAI">Next item number install</param>
		/// <param name="m3NHSI">Next serial number install</param>
		/// <param name="m3CFGL">Configuration position install</param>
		/// <param name="m3ITNI">Item number install</param>
		/// <param name="m3BANI">Lot number install</param>
		/// <param name="m3DWNO">Drawing number</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RemoveInstall(
			string m3RITP, 
			string m3RESP, 
			DateTime m3TRDT, 
			int m3TRTM, 
			string m3WHLO, 
			string m3RSC4, 
			int? m3CONO = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3TWSL = null, 
			int? m3DEID = null, 
			string m3ACNO = null, 
			string m3TAIL = null, 
			string m3NHAR = null, 
			string m3NHSR = null, 
			string m3CFGR = null, 
			string m3ITNR = null, 
			string m3BANR = null, 
			string m3BREM = null, 
			string m3WHSL = null, 
			string m3TAI1 = null, 
			string m3NHAI = null, 
			string m3NHSI = null, 
			string m3CFGL = null, 
			string m3ITNI = null, 
			string m3BANI = null, 
			string m3DWNO = null, 
			int? m3MSEQ = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/RemoveInstall",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RITP))
				throw new ArgumentNullException(nameof(m3RITP));
			if (string.IsNullOrWhiteSpace(m3RESP))
				throw new ArgumentNullException(nameof(m3RESP));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3RSC4))
				throw new ArgumentNullException(nameof(m3RSC4));

			// Set mandatory parameters
			request
				.WithQueryParameter("RITP", m3RITP.Trim())
				.WithQueryParameter("RESP", m3RESP.Trim())
				.WithQueryParameter("TRDT", m3TRDT.ToM3String())
				.WithQueryParameter("TRTM", m3TRTM.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("RSC4", m3RSC4.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (m3DEID.HasValue)
				request.WithQueryParameter("DEID", m3DEID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACNO))
				request.WithQueryParameter("ACNO", m3ACNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAIL))
				request.WithQueryParameter("TAIL", m3TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3NHAR))
				request.WithQueryParameter("NHAR", m3NHAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3NHSR))
				request.WithQueryParameter("NHSR", m3NHSR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGR))
				request.WithQueryParameter("CFGR", m3CFGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNR))
				request.WithQueryParameter("ITNR", m3ITNR.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANR))
				request.WithQueryParameter("BANR", m3BANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAI1))
				request.WithQueryParameter("TAI1", m3TAI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3NHAI))
				request.WithQueryParameter("NHAI", m3NHAI.Trim());
			if (!string.IsNullOrWhiteSpace(m3NHSI))
				request.WithQueryParameter("NHSI", m3NHSI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNI))
				request.WithQueryParameter("ITNI", m3ITNI.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANI))
				request.WithQueryParameter("BANI", m3BANI.Trim());
			if (!string.IsNullOrWhiteSpace(m3DWNO))
				request.WithQueryParameter("DWNO", m3DWNO.Trim());
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));

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
