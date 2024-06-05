/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.FLS001MI;
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
	/// Name: FLS001MI
	/// Component Name: OperationalLog
	/// Description: Operational log sequence interface
	/// Version Release: 13.1
	///</summary>
	public partial class FLS001MIResource : M3BaseResourceEndpoint
	{
		public FLS001MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "FLS001MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddDelayReport
		/// Description Add Delay Report
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3ALD2">Log date (Required)</param>
		/// <param name="m3AFLN">Departure ID (Required)</param>
		/// <param name="m3AST3">From station (Required)</param>
		/// <param name="m3DETY">Delay type (Required)</param>
		/// <param name="m3AST4">To station (Required)</param>
		/// <param name="m3STAT">Status (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TAIL">Registration number/site</param>
		/// <param name="m3ASDT">Scheduled departure time</param>
		/// <param name="m3ATAT">Delay end time</param>
		/// <param name="m3ADET">Delay - total time</param>
		/// <param name="m3DELR">Delay reason</param>
		/// <param name="m3ADEC">Technical delay</param>
		/// <param name="m3STNC">Standard numbering system</param>
		/// <param name="m3FUNC">Function area</param>
		/// <param name="m3DEID">Complaint</param>
		/// <param name="m3CCEL">Canceled</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDelayReport(
			DateTime m3ALD2, 
			string m3AFLN, 
			string m3AST3, 
			string m3DETY, 
			string m3AST4, 
			string m3STAT, 
			int? m3CONO = null, 
			string m3TAIL = null, 
			int? m3ASDT = null, 
			int? m3ATAT = null, 
			int? m3ADET = null, 
			string m3DELR = null, 
			int? m3ADEC = null, 
			string m3STNC = null, 
			string m3FUNC = null, 
			int? m3DEID = null, 
			int? m3CCEL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddDelayReport",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AFLN))
				throw new ArgumentNullException(nameof(m3AFLN));
			if (string.IsNullOrWhiteSpace(m3AST3))
				throw new ArgumentNullException(nameof(m3AST3));
			if (string.IsNullOrWhiteSpace(m3DETY))
				throw new ArgumentNullException(nameof(m3DETY));
			if (string.IsNullOrWhiteSpace(m3AST4))
				throw new ArgumentNullException(nameof(m3AST4));
			if (string.IsNullOrWhiteSpace(m3STAT))
				throw new ArgumentNullException(nameof(m3STAT));

			// Set mandatory parameters
			request
				.WithQueryParameter("ALD2", m3ALD2.ToM3String())
				.WithQueryParameter("AFLN", m3AFLN.Trim())
				.WithQueryParameter("AST3", m3AST3.Trim())
				.WithQueryParameter("DETY", m3DETY.Trim())
				.WithQueryParameter("AST4", m3AST4.Trim())
				.WithQueryParameter("STAT", m3STAT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TAIL))
				request.WithQueryParameter("TAIL", m3TAIL.Trim());
			if (m3ASDT.HasValue)
				request.WithQueryParameter("ASDT", m3ASDT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATAT.HasValue)
				request.WithQueryParameter("ATAT", m3ATAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADET.HasValue)
				request.WithQueryParameter("ADET", m3ADET.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DELR))
				request.WithQueryParameter("DELR", m3DELR.Trim());
			if (m3ADEC.HasValue)
				request.WithQueryParameter("ADEC", m3ADEC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STNC))
				request.WithQueryParameter("STNC", m3STNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3FUNC))
				request.WithQueryParameter("FUNC", m3FUNC.Trim());
			if (m3DEID.HasValue)
				request.WithQueryParameter("DEID", m3DEID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CCEL.HasValue)
				request.WithQueryParameter("CCEL", m3CCEL.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddLogSequence
		/// Description Add an operational log sequence
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3TAIL">Registration number/site (Required)</param>
		/// <param name="m3ALD2">Log date (Required)</param>
		/// <param name="m3ATOT">Departure (Required)</param>
		/// <param name="m3AST3">From station (Required)</param>
		/// <param name="m3AST4">To station (Required)</param>
		/// <param name="m3ATYF">Type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FLLN">Log number</param>
		/// <param name="m3SEQC">Sequence</param>
		/// <param name="m3ALA4">Arrival</param>
		/// <param name="m3AFLT">Duration</param>
		/// <param name="m3ANOC">Number of cycles</param>
		/// <param name="m3ASTE">Start time engine</param>
		/// <param name="m3AROT">Roll-out time</param>
		/// <param name="m3AFLO">Exercise order</param>
		/// <param name="m3MISS">Mission</param>
		/// <param name="m3AMTM">Mission time</param>
		/// <param name="m3AIT9">Instrument time</param>
		/// <param name="m3VMC0">Meteorological condition</param>
		/// <param name="m3AFLN">Departure ID</param>
		/// <param name="m3TYEX">Exercise type</param>
		/// <param name="m3AC20">Social security number</param>
		/// <param name="m3ANOP">Number of passengers</param>
		/// <param name="m3AEDU">Training period</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3DNES">Darkness</param>
		/// <param name="m3AODN">Ordering organization</param>
		/// <param name="m3APCM">Acting organization</param>
		/// <param name="m3AWAY">Chocks away/off</param>
		/// <param name="m3UNDR">Chocks under/on</param>
		/// <param name="m3BLTM">Block time</param>
		/// <param name="m3CHID">Changed by</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddLogSequenceResponse></returns>
		/// <exception cref="M3Exception<AddLogSequenceResponse>"></exception>
		public async Task<M3Response<AddLogSequenceResponse>> AddLogSequence(
			string m3TAIL, 
			DateTime m3ALD2, 
			int m3ATOT, 
			string m3AST3, 
			string m3AST4, 
			string m3ATYF, 
			int? m3CONO = null, 
			int? m3FLLN = null, 
			int? m3SEQC = null, 
			int? m3ALA4 = null, 
			int? m3AFLT = null, 
			int? m3ANOC = null, 
			int? m3ASTE = null, 
			int? m3AROT = null, 
			string m3AFLO = null, 
			string m3MISS = null, 
			int? m3AMTM = null, 
			int? m3AIT9 = null, 
			string m3VMC0 = null, 
			string m3AFLN = null, 
			string m3TYEX = null, 
			string m3AC20 = null, 
			string m3ANOP = null, 
			string m3AEDU = null, 
			string m3FACI = null, 
			int? m3DNES = null, 
			string m3AODN = null, 
			string m3APCM = null, 
			int? m3AWAY = null, 
			int? m3UNDR = null, 
			int? m3BLTM = null, 
			string m3CHID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLogSequence",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TAIL))
				throw new ArgumentNullException(nameof(m3TAIL));
			if (string.IsNullOrWhiteSpace(m3AST3))
				throw new ArgumentNullException(nameof(m3AST3));
			if (string.IsNullOrWhiteSpace(m3AST4))
				throw new ArgumentNullException(nameof(m3AST4));
			if (string.IsNullOrWhiteSpace(m3ATYF))
				throw new ArgumentNullException(nameof(m3ATYF));

			// Set mandatory parameters
			request
				.WithQueryParameter("TAIL", m3TAIL.Trim())
				.WithQueryParameter("ALD2", m3ALD2.ToM3String())
				.WithQueryParameter("ATOT", m3ATOT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("AST3", m3AST3.Trim())
				.WithQueryParameter("AST4", m3AST4.Trim())
				.WithQueryParameter("ATYF", m3ATYF.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLLN.HasValue)
				request.WithQueryParameter("FLLN", m3FLLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SEQC.HasValue)
				request.WithQueryParameter("SEQC", m3SEQC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALA4.HasValue)
				request.WithQueryParameter("ALA4", m3ALA4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AFLT.HasValue)
				request.WithQueryParameter("AFLT", m3AFLT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ANOC.HasValue)
				request.WithQueryParameter("ANOC", m3ANOC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ASTE.HasValue)
				request.WithQueryParameter("ASTE", m3ASTE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AROT.HasValue)
				request.WithQueryParameter("AROT", m3AROT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AFLO))
				request.WithQueryParameter("AFLO", m3AFLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MISS))
				request.WithQueryParameter("MISS", m3MISS.Trim());
			if (m3AMTM.HasValue)
				request.WithQueryParameter("AMTM", m3AMTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AIT9.HasValue)
				request.WithQueryParameter("AIT9", m3AIT9.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3VMC0))
				request.WithQueryParameter("VMC0", m3VMC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3AFLN))
				request.WithQueryParameter("AFLN", m3AFLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TYEX))
				request.WithQueryParameter("TYEX", m3TYEX.Trim());
			if (!string.IsNullOrWhiteSpace(m3AC20))
				request.WithQueryParameter("AC20", m3AC20.Trim());
			if (!string.IsNullOrWhiteSpace(m3ANOP))
				request.WithQueryParameter("ANOP", m3ANOP.Trim());
			if (!string.IsNullOrWhiteSpace(m3AEDU))
				request.WithQueryParameter("AEDU", m3AEDU.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (m3DNES.HasValue)
				request.WithQueryParameter("DNES", m3DNES.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AODN))
				request.WithQueryParameter("AODN", m3AODN.Trim());
			if (!string.IsNullOrWhiteSpace(m3APCM))
				request.WithQueryParameter("APCM", m3APCM.Trim());
			if (m3AWAY.HasValue)
				request.WithQueryParameter("AWAY", m3AWAY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UNDR.HasValue)
				request.WithQueryParameter("UNDR", m3UNDR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BLTM.HasValue)
				request.WithQueryParameter("BLTM", m3BLTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());

			// Execute the request
			var result = await Execute<AddLogSequenceResponse>(
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
		/// Name DelDelayReport
		/// Description DelDelayReport
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3ALD2">Log date (Required)</param>
		/// <param name="m3AFLN">Departure ID (Required)</param>
		/// <param name="m3AST3">From station (Required)</param>
		/// <param name="m3DETY">Delay type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelDelayReport(
			DateTime m3ALD2, 
			string m3AFLN, 
			string m3AST3, 
			string m3DETY, 
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelDelayReport",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AFLN))
				throw new ArgumentNullException(nameof(m3AFLN));
			if (string.IsNullOrWhiteSpace(m3AST3))
				throw new ArgumentNullException(nameof(m3AST3));
			if (string.IsNullOrWhiteSpace(m3DETY))
				throw new ArgumentNullException(nameof(m3DETY));

			// Set mandatory parameters
			request
				.WithQueryParameter("ALD2", m3ALD2.ToM3String())
				.WithQueryParameter("AFLN", m3AFLN.Trim())
				.WithQueryParameter("AST3", m3AST3.Trim())
				.WithQueryParameter("DETY", m3DETY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelLogSequence
		/// Description Delete an operational log sequence
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3TAIL">Registration number/site (Required)</param>
		/// <param name="m3ALD2">Log date (Required)</param>
		/// <param name="m3FLLN">Log number (Required)</param>
		/// <param name="m3SEQC">Sequence (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelLogSequence(
			string m3TAIL, 
			DateTime m3ALD2, 
			int m3FLLN, 
			int m3SEQC, 
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelLogSequence",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TAIL))
				throw new ArgumentNullException(nameof(m3TAIL));

			// Set mandatory parameters
			request
				.WithQueryParameter("TAIL", m3TAIL.Trim())
				.WithQueryParameter("ALD2", m3ALD2.ToM3String())
				.WithQueryParameter("FLLN", m3FLLN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEQC", m3SEQC.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
