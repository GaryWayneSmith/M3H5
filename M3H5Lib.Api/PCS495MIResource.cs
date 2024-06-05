/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.PCS495MI;
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
	/// Name: PCS495MI
	/// Component Name: Cust Sales and Serv
	/// Description: Api: Budgeting maintenance proposal/update
	/// Version Release: 14.1
	///</summary>
	public partial class PCS495MIResource : M3BaseResourceEndpoint
	{
		public PCS495MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PCS495MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name CalRevCos
		/// Description This transaction calculates Revenue/Cost
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3FIDT">Finish date-From (Required)</param>
		/// <param name="m3FID1">Finish date-To (Required)</param>
		/// <param name="m3REVC">Cost/revenue update (Required)</param>
		/// <param name="m3PCTP">Costing type (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3BUNO">Budget number</param>
		/// <param name="m3BVER">Budget version</param>
		/// <param name="m3FACI">Facility-From</param>
		/// <param name="m3FACT">Facility-To</param>
		/// <param name="m3PRNO">Product number-From</param>
		/// <param name="m3PRNT">Product number-To</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3SER1">Serial number</param>
		/// <param name="m3STRT">Product structure type-From</param>
		/// <param name="m3STR1">Product structure type-To</param>
		/// <param name="m3SUFI">Service-From</param>
		/// <param name="m3SUFT">Service-To</param>
		/// <param name="m3ORTY">Order type-From</param>
		/// <param name="m3ORTT">Order type-To</param>
		/// <param name="m3CUNO">Customer number-From</param>
		/// <param name="m3CUNT">Customer number-To</param>
		/// <param name="m3AAGN">Agreement number-From</param>
		/// <param name="m3AAGT">Agreement number-To</param>
		/// <param name="m3PCMC">Cost O/H</param>
		/// <param name="m3DTRE">Detailed report</param>
		/// <param name="m3AJSC">Accounting proposal</param>
		/// <param name="m3UPCD">Update</param>
		/// <param name="m3LITX">Report text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CalRevCosResponse></returns>
		/// <exception cref="M3Exception<CalRevCosResponse>"></exception>
		public async Task<M3Response<CalRevCosResponse>> CalRevCos(
			DateTime m3FIDT, 
			DateTime m3FID1, 
			int m3REVC, 
			string m3PCTP, 
			DateTime m3FRDT, 
			int? m3BUNO = null, 
			string m3BVER = null, 
			string m3FACI = null, 
			string m3FACT = null, 
			string m3PRNO = null, 
			string m3PRNT = null, 
			string m3SERN = null, 
			string m3SER1 = null, 
			string m3STRT = null, 
			string m3STR1 = null, 
			string m3SUFI = null, 
			string m3SUFT = null, 
			string m3ORTY = null, 
			string m3ORTT = null, 
			string m3CUNO = null, 
			string m3CUNT = null, 
			string m3AAGN = null, 
			string m3AAGT = null, 
			int? m3PCMC = null, 
			int? m3DTRE = null, 
			int? m3AJSC = null, 
			int? m3UPCD = null, 
			string m3LITX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CalRevCos",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PCTP))
				throw new ArgumentNullException(nameof(m3PCTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("FIDT", m3FIDT.ToM3String())
				.WithQueryParameter("FID1", m3FID1.ToM3String())
				.WithQueryParameter("REVC", m3REVC.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PCTP", m3PCTP.Trim())
				.WithQueryParameter("FRDT", m3FRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3BUNO.HasValue)
				request.WithQueryParameter("BUNO", m3BUNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BVER))
				request.WithQueryParameter("BVER", m3BVER.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACT))
				request.WithQueryParameter("FACT", m3FACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNT))
				request.WithQueryParameter("PRNT", m3PRNT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SER1))
				request.WithQueryParameter("SER1", m3SER1.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STR1))
				request.WithQueryParameter("STR1", m3STR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFT))
				request.WithQueryParameter("SUFT", m3SUFT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTT))
				request.WithQueryParameter("ORTT", m3ORTT.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNT))
				request.WithQueryParameter("CUNT", m3CUNT.Trim());
			if (!string.IsNullOrWhiteSpace(m3AAGN))
				request.WithQueryParameter("AAGN", m3AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3AAGT))
				request.WithQueryParameter("AAGT", m3AAGT.Trim());
			if (m3PCMC.HasValue)
				request.WithQueryParameter("PCMC", m3PCMC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTRE.HasValue)
				request.WithQueryParameter("DTRE", m3DTRE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AJSC.HasValue)
				request.WithQueryParameter("AJSC", m3AJSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UPCD.HasValue)
				request.WithQueryParameter("UPCD", m3UPCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LITX))
				request.WithQueryParameter("LITX", m3LITX.Trim());

			// Execute the request
			var result = await Execute<CalRevCosResponse>(
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
