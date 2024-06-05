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
	/// Name: MOS510MI
	/// Component Name: MaintenanceDisturbance
	/// Description: Maintenance disturbance interface
	/// Version Release: 13.1
	///</summary>
	public partial class MOS510MIResource : M3BaseResourceEndpoint
	{
		public MOS510MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS510MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add disturbance
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_DITY">Disturbance type (Required)</param>
		/// <param name="m3_TAIL">Registration number/site (Required)</param>
		/// <param name="m3_REPR">Reported by (Required)</param>
		/// <param name="m3_RANK">Position of reponsible person (Required)</param>
		/// <param name="m3_RED0">Event date (Required)</param>
		/// <param name="m3_DES0">Subject (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ODTP">Original document type</param>
		/// <param name="m3_ODNO">Original document number</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_RET0">Event time</param>
		/// <param name="m3_TYRE">Report type - disturbance</param>
		/// <param name="m3_EVE0">Operational event</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_CSNS">Complaint numbering system</param>
		/// <param name="m3_CFUN">Functional area</param>
		/// <param name="m3_FLLN">Log number</param>
		/// <param name="m3_FPHA">Phase</param>
		/// <param name="m3_VMC0">Meteorological condition</param>
		/// <param name="m3_DNES">Darkness</param>
		/// <param name="m3_MISS">Mission</param>
		/// <param name="m3_TYEX">Exercise type</param>
		/// <param name="m3_AIRS">Airspace</param>
		/// <param name="m3_SUCC">Mission success</param>
		/// <param name="m3_FLSA">Safety effect</param>
		/// <param name="m3_ENVI">Disturbance environment</param>
		/// <param name="m3_EVPH">Ground event</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_SEQC">Sequence</param>
		/// <param name="m3_DAMA">Damage</param>
		/// <param name="m3_DST0">Status - disturbance</param>
		/// <param name="m3_BAPH">Ground phase</param>
		/// <param name="m3_IRID">Investigation number</param>
		/// <param name="m3_RTDC">Related complaint</param>
		/// <param name="m3_FLID">Flight disturbance</param>
		/// <param name="m3_GROD">Ground disturbance</param>
		/// <param name="m3_COMM">Comments - disturbance</param>
		/// <param name="m3_BIRT">Origin identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_DITY, 
			string m3_TAIL, 
			string m3_REPR, 
			string m3_RANK, 
			DateTime m3_RED0, 
			string m3_DES0, 
			int? m3_CONO = null, 
			string m3_ODTP = null, 
			string m3_ODNO = null, 
			string m3_FACI = null, 
			int? m3_RET0 = null, 
			string m3_TYRE = null, 
			string m3_EVE0 = null, 
			string m3_CFGL = null, 
			string m3_CSNS = null, 
			string m3_CFUN = null, 
			int? m3_FLLN = null, 
			string m3_FPHA = null, 
			string m3_VMC0 = null, 
			int? m3_DNES = null, 
			string m3_MISS = null, 
			string m3_TYEX = null, 
			string m3_AIRS = null, 
			string m3_SUCC = null, 
			string m3_FLSA = null, 
			string m3_ENVI = null, 
			string m3_EVPH = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			int? m3_SEQC = null, 
			int? m3_DAMA = null, 
			string m3_DST0 = null, 
			string m3_BAPH = null, 
			int? m3_IRID = null, 
			int? m3_RTDC = null, 
			int? m3_FLID = null, 
			int? m3_GROD = null, 
			int? m3_COMM = null, 
			long? m3_BIRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DITY))
				throw new ArgumentNullException("m3_DITY");
			if (string.IsNullOrWhiteSpace(m3_TAIL))
				throw new ArgumentNullException("m3_TAIL");
			if (string.IsNullOrWhiteSpace(m3_REPR))
				throw new ArgumentNullException("m3_REPR");
			if (string.IsNullOrWhiteSpace(m3_RANK))
				throw new ArgumentNullException("m3_RANK");
			if (string.IsNullOrWhiteSpace(m3_DES0))
				throw new ArgumentNullException("m3_DES0");

			// Set mandatory parameters
			request
				.WithQueryParameter("DITY", m3_DITY.Trim())
				.WithQueryParameter("TAIL", m3_TAIL.Trim())
				.WithQueryParameter("REPR", m3_REPR.Trim())
				.WithQueryParameter("RANK", m3_RANK.Trim())
				.WithQueryParameter("RED0", m3_RED0.ToM3String())
				.WithQueryParameter("DES0", m3_DES0.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ODTP))
				request.WithQueryParameter("ODTP", m3_ODTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ODNO))
				request.WithQueryParameter("ODNO", m3_ODNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (m3_RET0.HasValue)
				request.WithQueryParameter("RET0", m3_RET0.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TYRE))
				request.WithQueryParameter("TYRE", m3_TYRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVE0))
				request.WithQueryParameter("EVE0", m3_EVE0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSNS))
				request.WithQueryParameter("CSNS", m3_CSNS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFUN))
				request.WithQueryParameter("CFUN", m3_CFUN.Trim());
			if (m3_FLLN.HasValue)
				request.WithQueryParameter("FLLN", m3_FLLN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FPHA))
				request.WithQueryParameter("FPHA", m3_FPHA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VMC0))
				request.WithQueryParameter("VMC0", m3_VMC0.Trim());
			if (m3_DNES.HasValue)
				request.WithQueryParameter("DNES", m3_DNES.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MISS))
				request.WithQueryParameter("MISS", m3_MISS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TYEX))
				request.WithQueryParameter("TYEX", m3_TYEX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIRS))
				request.WithQueryParameter("AIRS", m3_AIRS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUCC))
				request.WithQueryParameter("SUCC", m3_SUCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLSA))
				request.WithQueryParameter("FLSA", m3_FLSA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ENVI))
				request.WithQueryParameter("ENVI", m3_ENVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVPH))
				request.WithQueryParameter("EVPH", m3_EVPH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_SEQC.HasValue)
				request.WithQueryParameter("SEQC", m3_SEQC.Value.ToString());
			if (m3_DAMA.HasValue)
				request.WithQueryParameter("DAMA", m3_DAMA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DST0))
				request.WithQueryParameter("DST0", m3_DST0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAPH))
				request.WithQueryParameter("BAPH", m3_BAPH.Trim());
			if (m3_IRID.HasValue)
				request.WithQueryParameter("IRID", m3_IRID.Value.ToString());
			if (m3_RTDC.HasValue)
				request.WithQueryParameter("RTDC", m3_RTDC.Value.ToString());
			if (m3_FLID.HasValue)
				request.WithQueryParameter("FLID", m3_FLID.Value.ToString());
			if (m3_GROD.HasValue)
				request.WithQueryParameter("GROD", m3_GROD.Value.ToString());
			if (m3_COMM.HasValue)
				request.WithQueryParameter("COMM", m3_COMM.Value.ToString());
			if (m3_BIRT.HasValue)
				request.WithQueryParameter("BIRT", m3_BIRT.Value.ToString());

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
