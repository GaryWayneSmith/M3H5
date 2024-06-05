/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name CalRevCos
		/// Description This transaction calculates Revenue/Cost
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_FIDT">Finish date-From (Required)</param>
		/// <param name="m3_FID1">Finish date-To (Required)</param>
		/// <param name="m3_REVC">Cost/revenue update (Required)</param>
		/// <param name="m3_PCTP">Costing type (Required)</param>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_BUNO">Budget number</param>
		/// <param name="m3_BVER">Budget version</param>
		/// <param name="m3_FACI">Facility-From</param>
		/// <param name="m3_FACT">Facility-To</param>
		/// <param name="m3_PRNO">Product number-From</param>
		/// <param name="m3_PRNT">Product number-To</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_SER1">Serial number</param>
		/// <param name="m3_STRT">Product structure type-From</param>
		/// <param name="m3_STR1">Product structure type-To</param>
		/// <param name="m3_SUFI">Service-From</param>
		/// <param name="m3_SUFT">Service-To</param>
		/// <param name="m3_ORTY">Order type-From</param>
		/// <param name="m3_ORTT">Order type-To</param>
		/// <param name="m3_CUNO">Customer number-From</param>
		/// <param name="m3_CUNT">Customer number-To</param>
		/// <param name="m3_AAGN">Agreement number-From</param>
		/// <param name="m3_AAGT">Agreement number-To</param>
		/// <param name="m3_PCMC">Cost O/H</param>
		/// <param name="m3_DTRE">Detailed report</param>
		/// <param name="m3_AJSC">Accounting proposal</param>
		/// <param name="m3_UPCD">Update</param>
		/// <param name="m3_LITX">Report text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CalRevCosResponse></returns>
		/// <exception cref="M3Exception<CalRevCosResponse>"></exception>
		public async Task<M3Response<CalRevCosResponse>> CalRevCos(
			DateTime m3_FIDT, 
			DateTime m3_FID1, 
			int m3_REVC, 
			string m3_PCTP, 
			DateTime m3_FRDT, 
			int? m3_BUNO = null, 
			string m3_BVER = null, 
			string m3_FACI = null, 
			string m3_FACT = null, 
			string m3_PRNO = null, 
			string m3_PRNT = null, 
			string m3_SERN = null, 
			string m3_SER1 = null, 
			string m3_STRT = null, 
			string m3_STR1 = null, 
			string m3_SUFI = null, 
			string m3_SUFT = null, 
			string m3_ORTY = null, 
			string m3_ORTT = null, 
			string m3_CUNO = null, 
			string m3_CUNT = null, 
			string m3_AAGN = null, 
			string m3_AAGT = null, 
			int? m3_PCMC = null, 
			int? m3_DTRE = null, 
			int? m3_AJSC = null, 
			int? m3_UPCD = null, 
			string m3_LITX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CalRevCos",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PCTP))
				throw new ArgumentNullException("m3_PCTP");

			// Set mandatory parameters
			request
				.WithQueryParameter("FIDT", m3_FIDT.ToM3String())
				.WithQueryParameter("FID1", m3_FID1.ToM3String())
				.WithQueryParameter("REVC", m3_REVC.ToString())
				.WithQueryParameter("PCTP", m3_PCTP.Trim())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_BUNO.HasValue)
				request.WithQueryParameter("BUNO", m3_BUNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BVER))
				request.WithQueryParameter("BVER", m3_BVER.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACT))
				request.WithQueryParameter("FACT", m3_FACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNT))
				request.WithQueryParameter("PRNT", m3_PRNT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SER1))
				request.WithQueryParameter("SER1", m3_SER1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STR1))
				request.WithQueryParameter("STR1", m3_STR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFT))
				request.WithQueryParameter("SUFT", m3_SUFT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTT))
				request.WithQueryParameter("ORTT", m3_ORTT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNT))
				request.WithQueryParameter("CUNT", m3_CUNT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AAGN))
				request.WithQueryParameter("AAGN", m3_AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AAGT))
				request.WithQueryParameter("AAGT", m3_AAGT.Trim());
			if (m3_PCMC.HasValue)
				request.WithQueryParameter("PCMC", m3_PCMC.Value.ToString());
			if (m3_DTRE.HasValue)
				request.WithQueryParameter("DTRE", m3_DTRE.Value.ToString());
			if (m3_AJSC.HasValue)
				request.WithQueryParameter("AJSC", m3_AJSC.Value.ToString());
			if (m3_UPCD.HasValue)
				request.WithQueryParameter("UPCD", m3_UPCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LITX))
				request.WithQueryParameter("LITX", m3_LITX.Trim());

			// Execute the request
			var result = await Execute<CalRevCosResponse>(
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
