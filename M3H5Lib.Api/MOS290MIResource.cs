/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3RORN">Reference order number (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3BANO">Lot number (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TAIL">Registration number/site</param>
		/// <param name="m3WADT">Warranty date</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3OWNC">Owner</param>
		/// <param name="m3OWEX">Owner exception</param>
		/// <param name="m3HVA0">TSN meter 1</param>
		/// <param name="m3CVA0">TSN meter 2</param>
		/// <param name="m3AVA0">TSN meter 3</param>
		/// <param name="m3FVA0">TSN meter 4</param>
		/// <param name="m3SVD0">TSN date</param>
		/// <param name="m3SVT0">TSN time</param>
		/// <param name="m3HVA1">TSO meter 1</param>
		/// <param name="m3CVA1">TSO meter 2</param>
		/// <param name="m3AVA1">TSO meter 3</param>
		/// <param name="m3FVA1">TSO meter 4</param>
		/// <param name="m3SVD1">OVH date</param>
		/// <param name="m3SVT1">OVH time</param>
		/// <param name="m3HVA2">TSR meter 1</param>
		/// <param name="m3CVA2">TSR meter 2</param>
		/// <param name="m3AVA2">TSR meter 3</param>
		/// <param name="m3FVA2">TSR meter 4</param>
		/// <param name="m3SVD2">REP date</param>
		/// <param name="m3SVT2">Rep time</param>
		/// <param name="m3HVA3">TSI meter 1</param>
		/// <param name="m3CVA3">TSI meter 2</param>
		/// <param name="m3AVA3">TSI meter 3</param>
		/// <param name="m3FVA3">TSI meter 4</param>
		/// <param name="m3SVD3">INS date</param>
		/// <param name="m3SVT3">INS time</param>
		/// <param name="m3NHAI">Next item number</param>
		/// <param name="m3NHSN">Next serial number</param>
		/// <param name="m3MOTP">Model/site</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3INDA">Installation date</param>
		/// <param name="m3INTS">Installation time</param>
		/// <param name="m3HVAI">Meter 1 at installation for comp</param>
		/// <param name="m3CVAI">Meter 2 at installation for comp</param>
		/// <param name="m3AVAI">Meter 3 at installation for comp</param>
		/// <param name="m3FVAI">Meter 4 at installation for comp</param>
		/// <param name="m3HV0M">Meter 1 at installation for highest</param>
		/// <param name="m3CV0M">Meter 2 at installation for highest</param>
		/// <param name="m3AV0M">Meter 3 at installation for highest</param>
		/// <param name="m3FV0M">Meter 4 at installation for highest</param>
		/// <param name="m3MFDT">Manufacturing date</param>
		/// <param name="m3MPGM">Maintenance program</param>
		/// <param name="m3CONC">Continuous net change</param>
		/// <param name="m3HKNO">Estimated meter 1 value</param>
		/// <param name="m3CKNO">Estimated meter 2 value</param>
		/// <param name="m3AKNO">Estimated meter 3 value</param>
		/// <param name="m3FKNO">Estimated meter 4 value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3RORN, 
			string m3ITNO, 
			string m3BANO, 
			string m3FACI, 
			int? m3CONO = null, 
			string m3TAIL = null, 
			DateTime? m3WADT = null, 
			int? m3RORC = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3STAT = null, 
			string m3OWNC = null, 
			int? m3OWEX = null, 
			decimal? m3HVA0 = null, 
			decimal? m3CVA0 = null, 
			string m3AVA0 = null, 
			string m3FVA0 = null, 
			DateTime? m3SVD0 = null, 
			int? m3SVT0 = null, 
			decimal? m3HVA1 = null, 
			decimal? m3CVA1 = null, 
			string m3AVA1 = null, 
			string m3FVA1 = null, 
			DateTime? m3SVD1 = null, 
			int? m3SVT1 = null, 
			decimal? m3HVA2 = null, 
			decimal? m3CVA2 = null, 
			string m3AVA2 = null, 
			string m3FVA2 = null, 
			DateTime? m3SVD2 = null, 
			int? m3SVT2 = null, 
			decimal? m3HVA3 = null, 
			decimal? m3CVA3 = null, 
			string m3AVA3 = null, 
			string m3FVA3 = null, 
			DateTime? m3SVD3 = null, 
			int? m3SVT3 = null, 
			string m3NHAI = null, 
			string m3NHSN = null, 
			string m3MOTP = null, 
			string m3CFGL = null, 
			DateTime? m3INDA = null, 
			int? m3INTS = null, 
			decimal? m3HVAI = null, 
			decimal? m3CVAI = null, 
			string m3AVAI = null, 
			string m3FVAI = null, 
			decimal? m3HV0M = null, 
			decimal? m3CV0M = null, 
			string m3AV0M = null, 
			string m3FV0M = null, 
			DateTime? m3MFDT = null, 
			string m3MPGM = null, 
			int? m3CONC = null, 
			int? m3HKNO = null, 
			int? m3CKNO = null, 
			int? m3AKNO = null, 
			int? m3FKNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3RORN))
				throw new ArgumentNullException(nameof(m3RORN));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3BANO))
				throw new ArgumentNullException(nameof(m3BANO));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("RORN", m3RORN.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("BANO", m3BANO.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TAIL))
				request.WithQueryParameter("TAIL", m3TAIL.Trim());
			if (m3WADT.HasValue)
				request.WithQueryParameter("WADT", m3WADT.Value.ToM3String());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3OWNC))
				request.WithQueryParameter("OWNC", m3OWNC.Trim());
			if (m3OWEX.HasValue)
				request.WithQueryParameter("OWEX", m3OWEX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HVA0.HasValue)
				request.WithQueryParameter("HVA0", m3HVA0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CVA0.HasValue)
				request.WithQueryParameter("CVA0", m3CVA0.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AVA0))
				request.WithQueryParameter("AVA0", m3AVA0.Trim());
			if (!string.IsNullOrWhiteSpace(m3FVA0))
				request.WithQueryParameter("FVA0", m3FVA0.Trim());
			if (m3SVD0.HasValue)
				request.WithQueryParameter("SVD0", m3SVD0.Value.ToM3String());
			if (m3SVT0.HasValue)
				request.WithQueryParameter("SVT0", m3SVT0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HVA1.HasValue)
				request.WithQueryParameter("HVA1", m3HVA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CVA1.HasValue)
				request.WithQueryParameter("CVA1", m3CVA1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AVA1))
				request.WithQueryParameter("AVA1", m3AVA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FVA1))
				request.WithQueryParameter("FVA1", m3FVA1.Trim());
			if (m3SVD1.HasValue)
				request.WithQueryParameter("SVD1", m3SVD1.Value.ToM3String());
			if (m3SVT1.HasValue)
				request.WithQueryParameter("SVT1", m3SVT1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HVA2.HasValue)
				request.WithQueryParameter("HVA2", m3HVA2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CVA2.HasValue)
				request.WithQueryParameter("CVA2", m3CVA2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AVA2))
				request.WithQueryParameter("AVA2", m3AVA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FVA2))
				request.WithQueryParameter("FVA2", m3FVA2.Trim());
			if (m3SVD2.HasValue)
				request.WithQueryParameter("SVD2", m3SVD2.Value.ToM3String());
			if (m3SVT2.HasValue)
				request.WithQueryParameter("SVT2", m3SVT2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HVA3.HasValue)
				request.WithQueryParameter("HVA3", m3HVA3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CVA3.HasValue)
				request.WithQueryParameter("CVA3", m3CVA3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AVA3))
				request.WithQueryParameter("AVA3", m3AVA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3FVA3))
				request.WithQueryParameter("FVA3", m3FVA3.Trim());
			if (m3SVD3.HasValue)
				request.WithQueryParameter("SVD3", m3SVD3.Value.ToM3String());
			if (m3SVT3.HasValue)
				request.WithQueryParameter("SVT3", m3SVT3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NHAI))
				request.WithQueryParameter("NHAI", m3NHAI.Trim());
			if (!string.IsNullOrWhiteSpace(m3NHSN))
				request.WithQueryParameter("NHSN", m3NHSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3MOTP))
				request.WithQueryParameter("MOTP", m3MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (m3INDA.HasValue)
				request.WithQueryParameter("INDA", m3INDA.Value.ToM3String());
			if (m3INTS.HasValue)
				request.WithQueryParameter("INTS", m3INTS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HVAI.HasValue)
				request.WithQueryParameter("HVAI", m3HVAI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CVAI.HasValue)
				request.WithQueryParameter("CVAI", m3CVAI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AVAI))
				request.WithQueryParameter("AVAI", m3AVAI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FVAI))
				request.WithQueryParameter("FVAI", m3FVAI.Trim());
			if (m3HV0M.HasValue)
				request.WithQueryParameter("HV0M", m3HV0M.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CV0M.HasValue)
				request.WithQueryParameter("CV0M", m3CV0M.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AV0M))
				request.WithQueryParameter("AV0M", m3AV0M.Trim());
			if (!string.IsNullOrWhiteSpace(m3FV0M))
				request.WithQueryParameter("FV0M", m3FV0M.Trim());
			if (m3MFDT.HasValue)
				request.WithQueryParameter("MFDT", m3MFDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3MPGM))
				request.WithQueryParameter("MPGM", m3MPGM.Trim());
			if (m3CONC.HasValue)
				request.WithQueryParameter("CONC", m3CONC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HKNO.HasValue)
				request.WithQueryParameter("HKNO", m3HKNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CKNO.HasValue)
				request.WithQueryParameter("CKNO", m3CKNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AKNO.HasValue)
				request.WithQueryParameter("AKNO", m3AKNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FKNO.HasValue)
				request.WithQueryParameter("FKNO", m3FKNO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ClearAsBuild
		/// Description Remove Item Serial Numbers from As Build Structure
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3MTRL">Component identity (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ClearAsBuild(
			string m3MTRL, 
			string m3SERN, 
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
			if (string.IsNullOrWhiteSpace(m3MTRL))
				throw new ArgumentNullException(nameof(m3MTRL));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MTRL", m3MTRL.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim());

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
		/// Name CrtAsBuildList
		/// Description Create As Build List (F18-MOS256)
		/// Version Release: 
		/// </summary>
		/// <param name="m3MOTP">Model/site (Required)</param>
		/// <param name="m3MTRL">Component identity (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3TRT1">Transaction time hours</param>
		/// <param name="m3TRT2">Transaction time minutes</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CrtAsBuildListResponse></returns>
		/// <exception cref="M3Exception<CrtAsBuildListResponse>"></exception>
		public async Task<M3Response<CrtAsBuildListResponse>> CrtAsBuildList(
			string m3MOTP, 
			string m3MTRL, 
			string m3SERN, 
			DateTime? m3TRDT = null, 
			int? m3TRT1 = null, 
			int? m3TRT2 = null, 
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
			if (string.IsNullOrWhiteSpace(m3MOTP))
				throw new ArgumentNullException(nameof(m3MOTP));
			if (string.IsNullOrWhiteSpace(m3MTRL))
				throw new ArgumentNullException(nameof(m3MTRL));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3MOTP.Trim())
				.WithQueryParameter("MTRL", m3MTRL.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (m3TRT1.HasValue)
				request.WithQueryParameter("TRT1", m3TRT1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRT2.HasValue)
				request.WithQueryParameter("TRT2", m3TRT2.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<CrtAsBuildListResponse>(
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
		/// Name CrtAsBuildStr
		/// Description Create as Build Structure(Opt 14 in MMS240 )
		/// Version Release: 
		/// </summary>
		/// <param name="m3MTRL">Component identity (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CrtAsBuildStrResponse></returns>
		/// <exception cref="M3Exception<CrtAsBuildStrResponse>"></exception>
		public async Task<M3Response<CrtAsBuildStrResponse>> CrtAsBuildStr(
			string m3MTRL, 
			string m3SERN, 
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
			if (string.IsNullOrWhiteSpace(m3MTRL))
				throw new ArgumentNullException(nameof(m3MTRL));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MTRL", m3MTRL.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim());

			// Execute the request
			var result = await Execute<CrtAsBuildStrResponse>(
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
		/// Name UpdAsBuildStr
		/// Description Update as Build Structure
		/// Version Release: 
		/// </summary>
		/// <param name="m3MTRL">Component identity (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SER2">Serial number (Required)</param>
		/// <param name="m3MOTP">Model/site</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<UpdAsBuildStrResponse></returns>
		/// <exception cref="M3Exception<UpdAsBuildStrResponse>"></exception>
		public async Task<M3Response<UpdAsBuildStrResponse>> UpdAsBuildStr(
			string m3MTRL, 
			string m3SERN, 
			string m3ITNO, 
			string m3SER2, 
			string m3MOTP = null, 
			string m3CFGL = null, 
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
			if (string.IsNullOrWhiteSpace(m3MTRL))
				throw new ArgumentNullException(nameof(m3MTRL));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SER2))
				throw new ArgumentNullException(nameof(m3SER2));

			// Set mandatory parameters
			request
				.WithQueryParameter("MTRL", m3MTRL.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SER2", m3SER2.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MOTP))
				request.WithQueryParameter("MOTP", m3MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());

			// Execute the request
			var result = await Execute<UpdAsBuildStrResponse>(
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
