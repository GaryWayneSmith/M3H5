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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add disturbance
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3DITY">Disturbance type (Required)</param>
		/// <param name="m3TAIL">Registration number/site (Required)</param>
		/// <param name="m3REPR">Reported by (Required)</param>
		/// <param name="m3RANK">Position of reponsible person (Required)</param>
		/// <param name="m3RED0">Event date (Required)</param>
		/// <param name="m3DES0">Subject (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ODTP">Original document type</param>
		/// <param name="m3ODNO">Original document number</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3RET0">Event time</param>
		/// <param name="m3TYRE">Report type - disturbance</param>
		/// <param name="m3EVE0">Operational event</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3CSNS">Complaint numbering system</param>
		/// <param name="m3CFUN">Functional area</param>
		/// <param name="m3FLLN">Log number</param>
		/// <param name="m3FPHA">Phase</param>
		/// <param name="m3VMC0">Meteorological condition</param>
		/// <param name="m3DNES">Darkness</param>
		/// <param name="m3MISS">Mission</param>
		/// <param name="m3TYEX">Exercise type</param>
		/// <param name="m3AIRS">Airspace</param>
		/// <param name="m3SUCC">Mission success</param>
		/// <param name="m3FLSA">Safety effect</param>
		/// <param name="m3ENVI">Disturbance environment</param>
		/// <param name="m3EVPH">Ground event</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3SEQC">Sequence</param>
		/// <param name="m3DAMA">Damage</param>
		/// <param name="m3DST0">Status - disturbance</param>
		/// <param name="m3BAPH">Ground phase</param>
		/// <param name="m3IRID">Investigation number</param>
		/// <param name="m3RTDC">Related complaint</param>
		/// <param name="m3FLID">Flight disturbance</param>
		/// <param name="m3GROD">Ground disturbance</param>
		/// <param name="m3COMM">Comments - disturbance</param>
		/// <param name="m3BIRT">Origin identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3DITY, 
			string m3TAIL, 
			string m3REPR, 
			string m3RANK, 
			DateTime m3RED0, 
			string m3DES0, 
			int? m3CONO = null, 
			string m3ODTP = null, 
			string m3ODNO = null, 
			string m3FACI = null, 
			int? m3RET0 = null, 
			string m3TYRE = null, 
			string m3EVE0 = null, 
			string m3CFGL = null, 
			string m3CSNS = null, 
			string m3CFUN = null, 
			int? m3FLLN = null, 
			string m3FPHA = null, 
			string m3VMC0 = null, 
			int? m3DNES = null, 
			string m3MISS = null, 
			string m3TYEX = null, 
			string m3AIRS = null, 
			string m3SUCC = null, 
			string m3FLSA = null, 
			string m3ENVI = null, 
			string m3EVPH = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			int? m3SEQC = null, 
			int? m3DAMA = null, 
			string m3DST0 = null, 
			string m3BAPH = null, 
			int? m3IRID = null, 
			int? m3RTDC = null, 
			int? m3FLID = null, 
			int? m3GROD = null, 
			int? m3COMM = null, 
			long? m3BIRT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DITY))
				throw new ArgumentNullException(nameof(m3DITY));
			if (string.IsNullOrWhiteSpace(m3TAIL))
				throw new ArgumentNullException(nameof(m3TAIL));
			if (string.IsNullOrWhiteSpace(m3REPR))
				throw new ArgumentNullException(nameof(m3REPR));
			if (string.IsNullOrWhiteSpace(m3RANK))
				throw new ArgumentNullException(nameof(m3RANK));
			if (string.IsNullOrWhiteSpace(m3DES0))
				throw new ArgumentNullException(nameof(m3DES0));

			// Set mandatory parameters
			request
				.WithQueryParameter("DITY", m3DITY.Trim())
				.WithQueryParameter("TAIL", m3TAIL.Trim())
				.WithQueryParameter("REPR", m3REPR.Trim())
				.WithQueryParameter("RANK", m3RANK.Trim())
				.WithQueryParameter("RED0", m3RED0.ToM3String())
				.WithQueryParameter("DES0", m3DES0.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ODTP))
				request.WithQueryParameter("ODTP", m3ODTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ODNO))
				request.WithQueryParameter("ODNO", m3ODNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (m3RET0.HasValue)
				request.WithQueryParameter("RET0", m3RET0.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TYRE))
				request.WithQueryParameter("TYRE", m3TYRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVE0))
				request.WithQueryParameter("EVE0", m3EVE0.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSNS))
				request.WithQueryParameter("CSNS", m3CSNS.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFUN))
				request.WithQueryParameter("CFUN", m3CFUN.Trim());
			if (m3FLLN.HasValue)
				request.WithQueryParameter("FLLN", m3FLLN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FPHA))
				request.WithQueryParameter("FPHA", m3FPHA.Trim());
			if (!string.IsNullOrWhiteSpace(m3VMC0))
				request.WithQueryParameter("VMC0", m3VMC0.Trim());
			if (m3DNES.HasValue)
				request.WithQueryParameter("DNES", m3DNES.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MISS))
				request.WithQueryParameter("MISS", m3MISS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TYEX))
				request.WithQueryParameter("TYEX", m3TYEX.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIRS))
				request.WithQueryParameter("AIRS", m3AIRS.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUCC))
				request.WithQueryParameter("SUCC", m3SUCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLSA))
				request.WithQueryParameter("FLSA", m3FLSA.Trim());
			if (!string.IsNullOrWhiteSpace(m3ENVI))
				request.WithQueryParameter("ENVI", m3ENVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVPH))
				request.WithQueryParameter("EVPH", m3EVPH.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (m3SEQC.HasValue)
				request.WithQueryParameter("SEQC", m3SEQC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DAMA.HasValue)
				request.WithQueryParameter("DAMA", m3DAMA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DST0))
				request.WithQueryParameter("DST0", m3DST0.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAPH))
				request.WithQueryParameter("BAPH", m3BAPH.Trim());
			if (m3IRID.HasValue)
				request.WithQueryParameter("IRID", m3IRID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RTDC.HasValue)
				request.WithQueryParameter("RTDC", m3RTDC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLID.HasValue)
				request.WithQueryParameter("FLID", m3FLID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GROD.HasValue)
				request.WithQueryParameter("GROD", m3GROD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COMM.HasValue)
				request.WithQueryParameter("COMM", m3COMM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BIRT.HasValue)
				request.WithQueryParameter("BIRT", m3BIRT.Value.ToString(CultureInfo.CurrentCulture));

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
