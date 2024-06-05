/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_ALD2">Log date (Required)</param>
		/// <param name="m3_AFLN">Departure ID (Required)</param>
		/// <param name="m3_AST3">From station (Required)</param>
		/// <param name="m3_DETY">Delay type (Required)</param>
		/// <param name="m3_AST4">To station (Required)</param>
		/// <param name="m3_STAT">Status (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TAIL">Registration number/site</param>
		/// <param name="m3_ASDT">Scheduled departure time</param>
		/// <param name="m3_ATAT">Delay end time</param>
		/// <param name="m3_ADET">Delay - total time</param>
		/// <param name="m3_DELR">Delay reason</param>
		/// <param name="m3_ADEC">Technical delay</param>
		/// <param name="m3_STNC">Standard numbering system</param>
		/// <param name="m3_FUNC">Function area</param>
		/// <param name="m3_DEID">Complaint</param>
		/// <param name="m3_CCEL">Canceled</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDelayReport(
			DateTime m3_ALD2, 
			string m3_AFLN, 
			string m3_AST3, 
			string m3_DETY, 
			string m3_AST4, 
			string m3_STAT, 
			int? m3_CONO = null, 
			string m3_TAIL = null, 
			int? m3_ASDT = null, 
			int? m3_ATAT = null, 
			int? m3_ADET = null, 
			string m3_DELR = null, 
			int? m3_ADEC = null, 
			string m3_STNC = null, 
			string m3_FUNC = null, 
			int? m3_DEID = null, 
			int? m3_CCEL = null, 
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
			if (string.IsNullOrWhiteSpace(m3_AFLN))
				throw new ArgumentNullException("m3_AFLN");
			if (string.IsNullOrWhiteSpace(m3_AST3))
				throw new ArgumentNullException("m3_AST3");
			if (string.IsNullOrWhiteSpace(m3_DETY))
				throw new ArgumentNullException("m3_DETY");
			if (string.IsNullOrWhiteSpace(m3_AST4))
				throw new ArgumentNullException("m3_AST4");
			if (string.IsNullOrWhiteSpace(m3_STAT))
				throw new ArgumentNullException("m3_STAT");

			// Set mandatory parameters
			request
				.WithQueryParameter("ALD2", m3_ALD2.ToM3String())
				.WithQueryParameter("AFLN", m3_AFLN.Trim())
				.WithQueryParameter("AST3", m3_AST3.Trim())
				.WithQueryParameter("DETY", m3_DETY.Trim())
				.WithQueryParameter("AST4", m3_AST4.Trim())
				.WithQueryParameter("STAT", m3_STAT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TAIL))
				request.WithQueryParameter("TAIL", m3_TAIL.Trim());
			if (m3_ASDT.HasValue)
				request.WithQueryParameter("ASDT", m3_ASDT.Value.ToString());
			if (m3_ATAT.HasValue)
				request.WithQueryParameter("ATAT", m3_ATAT.Value.ToString());
			if (m3_ADET.HasValue)
				request.WithQueryParameter("ADET", m3_ADET.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DELR))
				request.WithQueryParameter("DELR", m3_DELR.Trim());
			if (m3_ADEC.HasValue)
				request.WithQueryParameter("ADEC", m3_ADEC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STNC))
				request.WithQueryParameter("STNC", m3_STNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FUNC))
				request.WithQueryParameter("FUNC", m3_FUNC.Trim());
			if (m3_DEID.HasValue)
				request.WithQueryParameter("DEID", m3_DEID.Value.ToString());
			if (m3_CCEL.HasValue)
				request.WithQueryParameter("CCEL", m3_CCEL.Value.ToString());

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
		/// Name AddLogSequence
		/// Description Add an operational log sequence
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_TAIL">Registration number/site (Required)</param>
		/// <param name="m3_ALD2">Log date (Required)</param>
		/// <param name="m3_ATOT">Departure (Required)</param>
		/// <param name="m3_AST3">From station (Required)</param>
		/// <param name="m3_AST4">To station (Required)</param>
		/// <param name="m3_ATYF">Type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FLLN">Log number</param>
		/// <param name="m3_SEQC">Sequence</param>
		/// <param name="m3_ALA4">Arrival</param>
		/// <param name="m3_AFLT">Duration</param>
		/// <param name="m3_ANOC">Number of cycles</param>
		/// <param name="m3_ASTE">Start time engine</param>
		/// <param name="m3_AROT">Roll-out time</param>
		/// <param name="m3_AFLO">Exercise order</param>
		/// <param name="m3_MISS">Mission</param>
		/// <param name="m3_AMTM">Mission time</param>
		/// <param name="m3_AIT9">Instrument time</param>
		/// <param name="m3_VMC0">Meteorological condition</param>
		/// <param name="m3_AFLN">Departure ID</param>
		/// <param name="m3_TYEX">Exercise type</param>
		/// <param name="m3_AC20">Social security number</param>
		/// <param name="m3_ANOP">Number of passengers</param>
		/// <param name="m3_AEDU">Training period</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_DNES">Darkness</param>
		/// <param name="m3_AODN">Ordering organization</param>
		/// <param name="m3_APCM">Acting organization</param>
		/// <param name="m3_AWAY">Chocks away/off</param>
		/// <param name="m3_UNDR">Chocks under/on</param>
		/// <param name="m3_BLTM">Block time</param>
		/// <param name="m3_CHID">Changed by</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddLogSequenceResponse></returns>
		/// <exception cref="M3Exception<AddLogSequenceResponse>"></exception>
		public async Task<M3Response<AddLogSequenceResponse>> AddLogSequence(
			string m3_TAIL, 
			DateTime m3_ALD2, 
			int m3_ATOT, 
			string m3_AST3, 
			string m3_AST4, 
			string m3_ATYF, 
			int? m3_CONO = null, 
			int? m3_FLLN = null, 
			int? m3_SEQC = null, 
			int? m3_ALA4 = null, 
			int? m3_AFLT = null, 
			int? m3_ANOC = null, 
			int? m3_ASTE = null, 
			int? m3_AROT = null, 
			string m3_AFLO = null, 
			string m3_MISS = null, 
			int? m3_AMTM = null, 
			int? m3_AIT9 = null, 
			string m3_VMC0 = null, 
			string m3_AFLN = null, 
			string m3_TYEX = null, 
			string m3_AC20 = null, 
			string m3_ANOP = null, 
			string m3_AEDU = null, 
			string m3_FACI = null, 
			int? m3_DNES = null, 
			string m3_AODN = null, 
			string m3_APCM = null, 
			int? m3_AWAY = null, 
			int? m3_UNDR = null, 
			int? m3_BLTM = null, 
			string m3_CHID = null, 
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
			if (string.IsNullOrWhiteSpace(m3_TAIL))
				throw new ArgumentNullException("m3_TAIL");
			if (string.IsNullOrWhiteSpace(m3_AST3))
				throw new ArgumentNullException("m3_AST3");
			if (string.IsNullOrWhiteSpace(m3_AST4))
				throw new ArgumentNullException("m3_AST4");
			if (string.IsNullOrWhiteSpace(m3_ATYF))
				throw new ArgumentNullException("m3_ATYF");

			// Set mandatory parameters
			request
				.WithQueryParameter("TAIL", m3_TAIL.Trim())
				.WithQueryParameter("ALD2", m3_ALD2.ToM3String())
				.WithQueryParameter("ATOT", m3_ATOT.ToString())
				.WithQueryParameter("AST3", m3_AST3.Trim())
				.WithQueryParameter("AST4", m3_AST4.Trim())
				.WithQueryParameter("ATYF", m3_ATYF.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_FLLN.HasValue)
				request.WithQueryParameter("FLLN", m3_FLLN.Value.ToString());
			if (m3_SEQC.HasValue)
				request.WithQueryParameter("SEQC", m3_SEQC.Value.ToString());
			if (m3_ALA4.HasValue)
				request.WithQueryParameter("ALA4", m3_ALA4.Value.ToString());
			if (m3_AFLT.HasValue)
				request.WithQueryParameter("AFLT", m3_AFLT.Value.ToString());
			if (m3_ANOC.HasValue)
				request.WithQueryParameter("ANOC", m3_ANOC.Value.ToString());
			if (m3_ASTE.HasValue)
				request.WithQueryParameter("ASTE", m3_ASTE.Value.ToString());
			if (m3_AROT.HasValue)
				request.WithQueryParameter("AROT", m3_AROT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AFLO))
				request.WithQueryParameter("AFLO", m3_AFLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MISS))
				request.WithQueryParameter("MISS", m3_MISS.Trim());
			if (m3_AMTM.HasValue)
				request.WithQueryParameter("AMTM", m3_AMTM.Value.ToString());
			if (m3_AIT9.HasValue)
				request.WithQueryParameter("AIT9", m3_AIT9.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_VMC0))
				request.WithQueryParameter("VMC0", m3_VMC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AFLN))
				request.WithQueryParameter("AFLN", m3_AFLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TYEX))
				request.WithQueryParameter("TYEX", m3_TYEX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AC20))
				request.WithQueryParameter("AC20", m3_AC20.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ANOP))
				request.WithQueryParameter("ANOP", m3_ANOP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AEDU))
				request.WithQueryParameter("AEDU", m3_AEDU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (m3_DNES.HasValue)
				request.WithQueryParameter("DNES", m3_DNES.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AODN))
				request.WithQueryParameter("AODN", m3_AODN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APCM))
				request.WithQueryParameter("APCM", m3_APCM.Trim());
			if (m3_AWAY.HasValue)
				request.WithQueryParameter("AWAY", m3_AWAY.Value.ToString());
			if (m3_UNDR.HasValue)
				request.WithQueryParameter("UNDR", m3_UNDR.Value.ToString());
			if (m3_BLTM.HasValue)
				request.WithQueryParameter("BLTM", m3_BLTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());

			// Execute the request
			var result = await Execute<AddLogSequenceResponse>(
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
		/// Name DelDelayReport
		/// Description DelDelayReport
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_ALD2">Log date (Required)</param>
		/// <param name="m3_AFLN">Departure ID (Required)</param>
		/// <param name="m3_AST3">From station (Required)</param>
		/// <param name="m3_DETY">Delay type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelDelayReport(
			DateTime m3_ALD2, 
			string m3_AFLN, 
			string m3_AST3, 
			string m3_DETY, 
			int? m3_CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_AFLN))
				throw new ArgumentNullException("m3_AFLN");
			if (string.IsNullOrWhiteSpace(m3_AST3))
				throw new ArgumentNullException("m3_AST3");
			if (string.IsNullOrWhiteSpace(m3_DETY))
				throw new ArgumentNullException("m3_DETY");

			// Set mandatory parameters
			request
				.WithQueryParameter("ALD2", m3_ALD2.ToM3String())
				.WithQueryParameter("AFLN", m3_AFLN.Trim())
				.WithQueryParameter("AST3", m3_AST3.Trim())
				.WithQueryParameter("DETY", m3_DETY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name DelLogSequence
		/// Description Delete an operational log sequence
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_TAIL">Registration number/site (Required)</param>
		/// <param name="m3_ALD2">Log date (Required)</param>
		/// <param name="m3_FLLN">Log number (Required)</param>
		/// <param name="m3_SEQC">Sequence (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelLogSequence(
			string m3_TAIL, 
			DateTime m3_ALD2, 
			int m3_FLLN, 
			int m3_SEQC, 
			int? m3_CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_TAIL))
				throw new ArgumentNullException("m3_TAIL");

			// Set mandatory parameters
			request
				.WithQueryParameter("TAIL", m3_TAIL.Trim())
				.WithQueryParameter("ALD2", m3_ALD2.ToM3String())
				.WithQueryParameter("FLLN", m3_FLLN.ToString())
				.WithQueryParameter("SEQC", m3_SEQC.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
