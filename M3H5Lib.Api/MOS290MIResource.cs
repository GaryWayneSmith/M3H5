/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MOS290MI;
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
	/// Name: MOS290MI
	/// Component Name: MaintenanceOrderIndividual
	/// Description: Maintenance order individual interface
	/// Version Release: 13.1
	///</summary>
	public partial class MOS290MIResource : M3BaseResourceEndpoint
	{
		public MOS290MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS290MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add order individual
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_RORN">Reference order number (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_BANO">Lot number (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TAIL">Registration number/site</param>
		/// <param name="m3_WADT">Warranty date</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_OWNC">Owner</param>
		/// <param name="m3_OWEX">Owner exception</param>
		/// <param name="m3_HVA0">TSN meter 1</param>
		/// <param name="m3_CVA0">TSN meter 2</param>
		/// <param name="m3_AVA0">TSN meter 3</param>
		/// <param name="m3_FVA0">TSN meter 4</param>
		/// <param name="m3_SVD0">TSN date</param>
		/// <param name="m3_SVT0">TSN time</param>
		/// <param name="m3_HVA1">TSO meter 1</param>
		/// <param name="m3_CVA1">TSO meter 2</param>
		/// <param name="m3_AVA1">TSO meter 3</param>
		/// <param name="m3_FVA1">TSO meter 4</param>
		/// <param name="m3_SVD1">OVH date</param>
		/// <param name="m3_SVT1">OVH time</param>
		/// <param name="m3_HVA2">TSR meter 1</param>
		/// <param name="m3_CVA2">TSR meter 2</param>
		/// <param name="m3_AVA2">TSR meter 3</param>
		/// <param name="m3_FVA2">TSR meter 4</param>
		/// <param name="m3_SVD2">REP date</param>
		/// <param name="m3_SVT2">Rep time</param>
		/// <param name="m3_HVA3">TSI meter 1</param>
		/// <param name="m3_CVA3">TSI meter 2</param>
		/// <param name="m3_AVA3">TSI meter 3</param>
		/// <param name="m3_FVA3">TSI meter 4</param>
		/// <param name="m3_SVD3">INS date</param>
		/// <param name="m3_SVT3">INS time</param>
		/// <param name="m3_NHAI">Next item number</param>
		/// <param name="m3_NHSN">Next serial number</param>
		/// <param name="m3_MOTP">Model/site</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_INDA">Installation date</param>
		/// <param name="m3_INTS">Installation time</param>
		/// <param name="m3_HVAI">Meter 1 at installation for comp</param>
		/// <param name="m3_CVAI">Meter 2 at installation for comp</param>
		/// <param name="m3_AVAI">Meter 3 at installation for comp</param>
		/// <param name="m3_FVAI">Meter 4 at installation for comp</param>
		/// <param name="m3_HV0M">Meter 1 at installation for highest</param>
		/// <param name="m3_CV0M">Meter 2 at installation for highest</param>
		/// <param name="m3_AV0M">Meter 3 at installation for highest</param>
		/// <param name="m3_FV0M">Meter 4 at installation for highest</param>
		/// <param name="m3_MFDT">Manufacturing date</param>
		/// <param name="m3_MPGM">Maintenance program</param>
		/// <param name="m3_CONC">Continuous net change</param>
		/// <param name="m3_HKNO">Estimated meter 1 value</param>
		/// <param name="m3_CKNO">Estimated meter 2 value</param>
		/// <param name="m3_AKNO">Estimated meter 3 value</param>
		/// <param name="m3_FKNO">Estimated meter 4 value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_RORN, 
			string m3_ITNO, 
			string m3_BANO, 
			string m3_FACI, 
			int? m3_CONO = null, 
			string m3_TAIL = null, 
			DateTime? m3_WADT = null, 
			int? m3_RORC = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_STAT = null, 
			string m3_OWNC = null, 
			int? m3_OWEX = null, 
			decimal? m3_HVA0 = null, 
			decimal? m3_CVA0 = null, 
			string m3_AVA0 = null, 
			string m3_FVA0 = null, 
			DateTime? m3_SVD0 = null, 
			int? m3_SVT0 = null, 
			decimal? m3_HVA1 = null, 
			decimal? m3_CVA1 = null, 
			string m3_AVA1 = null, 
			string m3_FVA1 = null, 
			DateTime? m3_SVD1 = null, 
			int? m3_SVT1 = null, 
			decimal? m3_HVA2 = null, 
			decimal? m3_CVA2 = null, 
			string m3_AVA2 = null, 
			string m3_FVA2 = null, 
			DateTime? m3_SVD2 = null, 
			int? m3_SVT2 = null, 
			decimal? m3_HVA3 = null, 
			decimal? m3_CVA3 = null, 
			string m3_AVA3 = null, 
			string m3_FVA3 = null, 
			DateTime? m3_SVD3 = null, 
			int? m3_SVT3 = null, 
			string m3_NHAI = null, 
			string m3_NHSN = null, 
			string m3_MOTP = null, 
			string m3_CFGL = null, 
			DateTime? m3_INDA = null, 
			int? m3_INTS = null, 
			decimal? m3_HVAI = null, 
			decimal? m3_CVAI = null, 
			string m3_AVAI = null, 
			string m3_FVAI = null, 
			decimal? m3_HV0M = null, 
			decimal? m3_CV0M = null, 
			string m3_AV0M = null, 
			string m3_FV0M = null, 
			DateTime? m3_MFDT = null, 
			string m3_MPGM = null, 
			int? m3_CONC = null, 
			int? m3_HKNO = null, 
			int? m3_CKNO = null, 
			int? m3_AKNO = null, 
			int? m3_FKNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_RORN))
				throw new ArgumentNullException("m3_RORN");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("RORN", m3_RORN.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("BANO", m3_BANO.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TAIL))
				request.WithQueryParameter("TAIL", m3_TAIL.Trim());
			if (m3_WADT.HasValue)
				request.WithQueryParameter("WADT", m3_WADT.Value.ToM3String());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OWNC))
				request.WithQueryParameter("OWNC", m3_OWNC.Trim());
			if (m3_OWEX.HasValue)
				request.WithQueryParameter("OWEX", m3_OWEX.Value.ToString());
			if (m3_HVA0.HasValue)
				request.WithQueryParameter("HVA0", m3_HVA0.Value.ToString());
			if (m3_CVA0.HasValue)
				request.WithQueryParameter("CVA0", m3_CVA0.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AVA0))
				request.WithQueryParameter("AVA0", m3_AVA0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FVA0))
				request.WithQueryParameter("FVA0", m3_FVA0.Trim());
			if (m3_SVD0.HasValue)
				request.WithQueryParameter("SVD0", m3_SVD0.Value.ToM3String());
			if (m3_SVT0.HasValue)
				request.WithQueryParameter("SVT0", m3_SVT0.Value.ToString());
			if (m3_HVA1.HasValue)
				request.WithQueryParameter("HVA1", m3_HVA1.Value.ToString());
			if (m3_CVA1.HasValue)
				request.WithQueryParameter("CVA1", m3_CVA1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AVA1))
				request.WithQueryParameter("AVA1", m3_AVA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FVA1))
				request.WithQueryParameter("FVA1", m3_FVA1.Trim());
			if (m3_SVD1.HasValue)
				request.WithQueryParameter("SVD1", m3_SVD1.Value.ToM3String());
			if (m3_SVT1.HasValue)
				request.WithQueryParameter("SVT1", m3_SVT1.Value.ToString());
			if (m3_HVA2.HasValue)
				request.WithQueryParameter("HVA2", m3_HVA2.Value.ToString());
			if (m3_CVA2.HasValue)
				request.WithQueryParameter("CVA2", m3_CVA2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AVA2))
				request.WithQueryParameter("AVA2", m3_AVA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FVA2))
				request.WithQueryParameter("FVA2", m3_FVA2.Trim());
			if (m3_SVD2.HasValue)
				request.WithQueryParameter("SVD2", m3_SVD2.Value.ToM3String());
			if (m3_SVT2.HasValue)
				request.WithQueryParameter("SVT2", m3_SVT2.Value.ToString());
			if (m3_HVA3.HasValue)
				request.WithQueryParameter("HVA3", m3_HVA3.Value.ToString());
			if (m3_CVA3.HasValue)
				request.WithQueryParameter("CVA3", m3_CVA3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AVA3))
				request.WithQueryParameter("AVA3", m3_AVA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FVA3))
				request.WithQueryParameter("FVA3", m3_FVA3.Trim());
			if (m3_SVD3.HasValue)
				request.WithQueryParameter("SVD3", m3_SVD3.Value.ToM3String());
			if (m3_SVT3.HasValue)
				request.WithQueryParameter("SVT3", m3_SVT3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NHAI))
				request.WithQueryParameter("NHAI", m3_NHAI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NHSN))
				request.WithQueryParameter("NHSN", m3_NHSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MOTP))
				request.WithQueryParameter("MOTP", m3_MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (m3_INDA.HasValue)
				request.WithQueryParameter("INDA", m3_INDA.Value.ToM3String());
			if (m3_INTS.HasValue)
				request.WithQueryParameter("INTS", m3_INTS.Value.ToString());
			if (m3_HVAI.HasValue)
				request.WithQueryParameter("HVAI", m3_HVAI.Value.ToString());
			if (m3_CVAI.HasValue)
				request.WithQueryParameter("CVAI", m3_CVAI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AVAI))
				request.WithQueryParameter("AVAI", m3_AVAI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FVAI))
				request.WithQueryParameter("FVAI", m3_FVAI.Trim());
			if (m3_HV0M.HasValue)
				request.WithQueryParameter("HV0M", m3_HV0M.Value.ToString());
			if (m3_CV0M.HasValue)
				request.WithQueryParameter("CV0M", m3_CV0M.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AV0M))
				request.WithQueryParameter("AV0M", m3_AV0M.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FV0M))
				request.WithQueryParameter("FV0M", m3_FV0M.Trim());
			if (m3_MFDT.HasValue)
				request.WithQueryParameter("MFDT", m3_MFDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_MPGM))
				request.WithQueryParameter("MPGM", m3_MPGM.Trim());
			if (m3_CONC.HasValue)
				request.WithQueryParameter("CONC", m3_CONC.Value.ToString());
			if (m3_HKNO.HasValue)
				request.WithQueryParameter("HKNO", m3_HKNO.Value.ToString());
			if (m3_CKNO.HasValue)
				request.WithQueryParameter("CKNO", m3_CKNO.Value.ToString());
			if (m3_AKNO.HasValue)
				request.WithQueryParameter("AKNO", m3_AKNO.Value.ToString());
			if (m3_FKNO.HasValue)
				request.WithQueryParameter("FKNO", m3_FKNO.Value.ToString());

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
		/// Name ClearAsBuild
		/// Description Remove Item Serial Numbers from As Build Structure
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_MTRL">Component identity (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ClearAsBuild(
			string m3_MTRL, 
			string m3_SERN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ClearAsBuild",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MTRL))
				throw new ArgumentNullException("m3_MTRL");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MTRL", m3_MTRL.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim());

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
		/// Name CrtAsBuildList
		/// Description Create As Build List (F18-MOS256)
		/// Version Release: 
		/// </summary>
		/// <param name="m3_MOTP">Model/site (Required)</param>
		/// <param name="m3_MTRL">Component identity (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TRT1">Transaction time hours</param>
		/// <param name="m3_TRT2">Transaction time minutes</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CrtAsBuildListResponse></returns>
		/// <exception cref="M3Exception<CrtAsBuildListResponse>"></exception>
		public async Task<M3Response<CrtAsBuildListResponse>> CrtAsBuildList(
			string m3_MOTP, 
			string m3_MTRL, 
			string m3_SERN, 
			DateTime? m3_TRDT = null, 
			int? m3_TRT1 = null, 
			int? m3_TRT2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CrtAsBuildList",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MOTP))
				throw new ArgumentNullException("m3_MOTP");
			if (string.IsNullOrWhiteSpace(m3_MTRL))
				throw new ArgumentNullException("m3_MTRL");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3_MOTP.Trim())
				.WithQueryParameter("MTRL", m3_MTRL.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TRT1.HasValue)
				request.WithQueryParameter("TRT1", m3_TRT1.Value.ToString());
			if (m3_TRT2.HasValue)
				request.WithQueryParameter("TRT2", m3_TRT2.Value.ToString());

			// Execute the request
			var result = await Execute<CrtAsBuildListResponse>(
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
		/// Name CrtAsBuildStr
		/// Description Create as Build Structure(Opt 14 in MMS240 )
		/// Version Release: 
		/// </summary>
		/// <param name="m3_MTRL">Component identity (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CrtAsBuildStrResponse></returns>
		/// <exception cref="M3Exception<CrtAsBuildStrResponse>"></exception>
		public async Task<M3Response<CrtAsBuildStrResponse>> CrtAsBuildStr(
			string m3_MTRL, 
			string m3_SERN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CrtAsBuildStr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MTRL))
				throw new ArgumentNullException("m3_MTRL");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MTRL", m3_MTRL.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim());

			// Execute the request
			var result = await Execute<CrtAsBuildStrResponse>(
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
		/// Name UpdAsBuildStr
		/// Description Update as Build Structure
		/// Version Release: 
		/// </summary>
		/// <param name="m3_MTRL">Component identity (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SER2">Serial number (Required)</param>
		/// <param name="m3_MOTP">Model/site</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<UpdAsBuildStrResponse></returns>
		/// <exception cref="M3Exception<UpdAsBuildStrResponse>"></exception>
		public async Task<M3Response<UpdAsBuildStrResponse>> UpdAsBuildStr(
			string m3_MTRL, 
			string m3_SERN, 
			string m3_ITNO, 
			string m3_SER2, 
			string m3_MOTP = null, 
			string m3_CFGL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdAsBuildStr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MTRL))
				throw new ArgumentNullException("m3_MTRL");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SER2))
				throw new ArgumentNullException("m3_SER2");

			// Set mandatory parameters
			request
				.WithQueryParameter("MTRL", m3_MTRL.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SER2", m3_SER2.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MOTP))
				request.WithQueryParameter("MOTP", m3_MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());

			// Execute the request
			var result = await Execute<UpdAsBuildStrResponse>(
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
